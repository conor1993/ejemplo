Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmEmbarqueCanales

    Dim WithEvents RegistroSacrificiosCab As New RegistroSacrificiosClass
    Dim WithEvents RegistroSacrificiosDet As New RegistroSacrificioDetClass
    'Dim Almacen As New AlmacenProduccionClass
    'Dim AlmacenDetalle As New AlmacenDetalleClass
    Dim Folio As New FoliosClass
    Dim Inventario As New InventarioClass
    Dim Productos As New ProductosClass
    Dim Embarque As New EmbarquesClass
    Dim EmbarqueDetalle As New EmbarqueDetalleClass
    Dim Canales As DataSet
    Dim Sacrificio As DataTable


    Private Sub FrmEmabarqueCanales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Limpiar()
            'se llena el combo de clientes
            'Me.CmbCliente.DataSource = CD.CatProveedoresCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "IdProveedor"
            Me.CmbCliente.SelectedIndex = -1
            'se llena el combo de tranportes
            'Me.CmbTransporte.DataSource = CD.McgcatVehiculosCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Me.CmbTransporte.DisplayMember = "DescVehiculo"
            Me.CmbTransporte.ValueMember = "IdVehiculo"
            Me.CmbTransporte.SelectedIndex = -1
            'se llena el combo de choferes o conductores
            'Me.CmbConductor.DataSource = CD.McgcatChoferesCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Me.CmbConductor.DisplayMember = "NombreChofer"
            Me.CmbConductor.ValueMember = "IdChofer"
            Me.CmbConductor.SelectedIndex = -1
            'se llena el combo de puntos de entrega en base al estado, ciudad y poblacion seleccionados
            'Me.CmbPuntoEntrega.DataSource = CD.MgralcatPuntosEntregaCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Me.CmbPuntoEntrega.DisplayMember = "Descripcion"
            Me.CmbPuntoEntrega.ValueMember = "IdPuntoEntrega"
            Me.CmbPuntoEntrega.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            Dim FolioAlmacen As String
            Dim FolioEmbarque As String



            'crear folio para embarque.
            Folio.Codigo = CodigodeFolios.Registrodeembarques
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            'folio para el registro de embarque
            FolioEmbarque = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
            'asignar datos de embarque a clase de cabecero de embarque
            Embarque.FolioEmbarque = FolioEmbarque
            Embarque.FechaEmbarque = Me.dtpFechaEmbarque.Value
            Embarque.FechaCaptura = Now
            Embarque.IdCliente = Me.CmbCliente.SelectedValue
            Embarque.IdVehiculo = Me.CmbConductor.SelectedValue
            Embarque.IdChofer = Me.CmbTransporte.SelectedValue
            Embarque.IdEstado = 1
            Embarque.IdCiudad = 1
            Embarque.IdPoblacion = 1
            Embarque.IdPuntoEntrega = Me.CmbPuntoEntrega.SelectedValue
            Embarque.TotalCajas = 1
            Embarque.TotalKilos = Me.txtTotalCanales.Text
            Embarque.TotalPiezas = Me.txtTotalKilos.Text
            Embarque.Estatus = EstatusCharX.VIGENTE
            Embarque.Func = "I"
            Embarque.NumOpc = 1
            'guardar cabecero de embarque
            If Not Embarque.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            

            Folio.Codigo = CodigodeFolios.SalidaCanalesAlmacen
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'folio para el registro de movimientos de almacen
            FolioAlmacen = Folio.Año & Folio.Mes & Folio.Codigo & Folio.Consecutivo.ToString("0000")
            'asignar datos de almacen a clase de cabecero de almacen 
            Almacen.IdFolioMovimiento = FolioAlmacen
            Almacen.IdCodAlmacen = 1
            Almacen.FechaMovimiento = Now
            Almacen.FechaCaptura = Now
            Almacen.IdCodMovimiento = MovtosAlmacen.SalidasdeCanalesaVenta
            Almacen.CantKilos = Me.txtTotalKilos.Text
            Almacen.CantPzas = Me.txtTotalCanales.Text
            Almacen.Estatus = "V"
            Almacen.QuienCancelo = ""
            Almacen.QuienContabilizo = ""
            Almacen.ObservacionCancela = ""
            Almacen.NumOpc = 1
            Almacen.Func = "I"
            If Not Almacen.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            For i As Integer = 0 To dgvCanales.Rows.Count - 1
                'clase para el detalle de embarques
                EmbarqueDetalle.CantKgrs = dgvCanales.Item("KilosBascula", i).Value
                EmbarqueDetalle.CantPzas = 1
                EmbarqueDetalle.Renglon = i
                EmbarqueDetalle.IdProducto = 1
                EmbarqueDetalle.IdFolioEtiqueta = dgvCanales.Item("FolioCanal", i).Value
                EmbarqueDetalle.Estatus = "V"
                EmbarqueDetalle.Func = "I"
                EmbarqueDetalle.NumOpc = 1
                EmbarqueDetalle.IdFolioEmbarque = FolioEmbarque

                'clase para el detalle de almacen
                AlmacenDetalle.IdFolioMovimiento = FolioAlmacen
                AlmacenDetalle.IdCodProducto = 1
                AlmacenDetalle.CantPzas = 1
                AlmacenDetalle.CantKilos = dgvCanales.Item("KilosBascula", i).Value
                AlmacenDetalle.CostoUnitario = 0
                AlmacenDetalle.IVA = 0
                'AlmacenDetalle.Estatus = "V"
                AlmacenDetalle.Func = "I"
                AlmacenDetalle.NumOpc = 1
                If Not AlmacenDetalle.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If

                'clase para el control de inventarios
                Inventario.IdCodAlmacen = 1
                Inventario.IdCodProducto = AlmacenDetalle.IdCodProducto
                Inventario.ExistKilos = AlmacenDetalle.CantKilos
                Inventario.ExistPzas = AlmacenDetalle.CantPzas
                Inventario.EntKilos = 0
                Inventario.EntPzas = 0
                Inventario.SalKilos = AlmacenDetalle.CantKilos
                Inventario.SalPzas = AlmacenDetalle.CantPzas
                Inventario.Func = "I"
                Inventario.NumOpc = 2
                Inventario.Año = Now.Year
                Inventario.Mes = Now.Month

                'llama el guardar del inventario de productos
                If Not Inventario.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
                'actualiza el canal
                'RegistroSacrificiosDet.LoteSacrificio = Me.txtLoteSacrificio.Text
                RegistroSacrificiosDet.FolioCanal = dgvCanales.Item("FolioCanal", i).Value
                RegistroSacrificiosDet.KilosFrios = AlmacenDetalle.CantKilos
                RegistroSacrificiosDet.Estatus = "E"
                RegistroSacrificiosDet.LoteCorte = Me.txtFolioEmbarque.Text
                RegistroSacrificiosDet.Func = "M"
                RegistroSacrificiosDet.NumOpc = 1
                If Not RegistroSacrificiosDet.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If

            Next
            Trans.Commit()
            'MessageBox.Show("Se guardo Canal a Corte ", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ObtenerCanales()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try


    End Function
    Private Function Limpiar() As Boolean
        'Me.GroupBox2.Enabled = False
        Me.txtFolioCanal.Text = ""
        Me.txtFolioEmbarque.Text = ""
        Me.CmbCliente.Text = ""
        Me.CmbCliente.SelectedIndex = -1
        Me.CmbConductor.Text = ""
        Me.CmbConductor.SelectedIndex = -1
        Me.CmbPuntoEntrega.Text = ""
        Me.CmbPuntoEntrega.SelectedIndex = -1
        Me.CmbTransporte.Text = ""
        Me.CmbTransporte.SelectedIndex = -1
        Me.txtTotalCanales.Text = "0"
        Me.txtTotalKilos.Text = "0"
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = False
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = False
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.GroupBox2.Enabled = False
    End Function
    Private Function Buscar() As Boolean
    End Function
    Private Function Imprimir() As Boolean
    End Function
    Private Function ObtenerCanales() As Boolean
        Try
            Canales = RegistroSacrificiosDet.Obtener(1, "", Me.txtFolioCanal.Text)
            'If Canales.Rows.Count > 0 Then
            '    Me.dgvCanales.AutoGenerateColumns = False
            '    Me.dgvCanales.DataSource = Canales
            '    Me.txtTotalCanales.Text = Me.dgvCanales.Rows.Count - 1
            '    For i As Integer = 0 To Me.dgvCanales.Rows.Count - 1
            '        Me.txtTotalKilos.Text = Me.txtTotalKilos.Text + Me.dgvCanales.Rows(i).Cells("KilosBascula").Value
            '    Next
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        If Not Buscar() Then
            MessageBox.Show("No se encuentran recepciones de ganado", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = False
        Me.mtb.HabilitarSalir = True
        Me.GroupBox2.Enabled = True
    End Sub



    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If Not Guardar() Then
            'MessageBox.Show("No se pudo guardar tipo de corral", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Se guardo embarque de canales con folio : " & Me.txtFolioEmbarque.Text, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = False
        Me.mtb.HabilitarSalir = True
        Me.GroupBox2.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub txtFolioCanal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioCanal.KeyPress
        If e.KeyChar = Chr(13) Then
            Canales = RegistroSacrificiosDet.Obtener(1, "", Me.txtFolioCanal.Text)
            'If Canales.Row.Count = 0 Then
            '    MessageBox.Show("No existe folio de canal para enviarlo a corte", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    Me.txtKilosFrios.Focus()
            'End If
        End If
    End Sub

    Private Sub txtKilosFrios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosFrios.KeyPress
        If e.KeyChar = Chr(13) Then
            Canales = RegistroSacrificiosDet.Obtener(1, "", Me.txtFolioCanal.Text)
            Me.dgvCanales.AutoGenerateColumns = False
            Me.dgvCanales.DataSource = Canales
            Me.dgvCanales.Rows(Me.dgvCanales.Rows.Count - 2).Cells("KilosBascula").Value = Me.txtKilosFrios.Text
            Me.txtKilosFrios.Text = 0
            Me.txtFolioCanal.Text = ""
            Me.txtFolioCanal.Focus()
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub




    Private Sub RegistroSacrificiosDet_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles RegistroSacrificiosDet.MensajeError
        MessageBox.Show(mensaje)
    End Sub
End Class