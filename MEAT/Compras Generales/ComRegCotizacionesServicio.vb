Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class ComRegCotizacionServicio
    Dim Cotizacion As CotizacionServicioClass
    Dim CotizacionDet As CotizacionServicioDetClass
    Dim modo As Short
    Dim inicio As Boolean
    Dim UltimaTeclaPlaza As DateTime
    Dim UltimaTeclaSucursal As DateTime
    Dim UltimaTeclaProveedor As DateTime

    Private Sub ComRegPresupuestoServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "011011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.ProveedorC.Obtener(CondicionEnum.ACTIVOS)
            Me.MonedaTC.Obtener()
            ' Me.SucursalC.Obtener(CondicionEnum.ACTIVOS)
            inicio = True
            Me.LlenaCombox()
            Limpiar()
            DesHabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Metodos"

    Sub LlenaCombox()
        Try
            'llena combo Plazas
            Me.cmbPlaza.DisplayMember = "Descripcion"
            Me.cmbPlaza.ValueMember = "Codigo"
            Me.PlazaC.Obtener(CondicionEnum.ACTIVOS)
            Me.cmbPlaza.DataSource = Me.PlazaC
            ' Me.cmbPlaza.DataSource = CC.PlazaCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Me.cmbPlaza.Text = "Seleccione una Plaza"
            Me.cmbPlaza.SelectedIndex = -1
            'Llena combo Sucursal
            'Me.CmbSucursal.DataSource = CC.SucursalCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            'Me.CmbSucursal.DisplayMember = "Descripcion"
            'Me.CmbSucursal.ValueMember = "Codigo"
            'Me.CmbSucursal.SelectedIndex = -1
            'Me.CmbSucursal.Text = "Seleccione una Sucursal"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Limpiar()
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione una Plaza..."
        Me.CmbSucursal.SelectedIndex = -1
        Me.CmbSucursal.Text = "Seleccione una Sucursal..."
        Me.cmbProveedor.SelectedIndex = -1
        Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        Me.txtSolicito.Text = ""
        Me.txtObservaciones.Text = ""

        Me.txtImporte.Text = "0"
        Me.txtDescuento.Text = "0"
        'Me.CmbSucursal.Text = ""
        'Me.cmbProveedor.Text = ""
        'Me.cmbPlaza.Text = ""
        Me.txtFolio.Text = "0"
        Me.txtSuma.Text = "0"
        'Me.dgvDetalle.Rows.Clear()
        Me.dgvDetalle.DataSource = Nothing
        Me.txtSubTotal.Text = "0"
        Me.txtTotal.Text = "0"
        Me.txtIVA.Text = "0"
        'Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        'Me.clmFechaSurtir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.clmDescuento.ReadOnly = False
        Me.clmIVA.ReadOnly = False
        Me.clmImporte.ReadOnly = False
        Me.lblEstatus.Visible = False
    End Sub

    Sub Habilitar()
        Me.cmbPlaza.Enabled = True
        Me.CmbSucursal.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.dgvDetalle.Enabled = False
    End Sub

    Sub DesHabilitar()
        Me.cmbProveedor.Enabled = False
        Me.CmbSucursal.Enabled = False
        Me.cmbPlaza.Enabled = False
        Me.dgvDetalle.Enabled = False
        Me.txtObservaciones.Enabled = False
    End Sub

    Sub Guardar()
        Me.Cotizacion.Folio = Me.txtFolio.Text
        Me.Cotizacion.SucursalId = CType(Me.CmbSucursal.SelectedValue, Integer)
        Me.Cotizacion.IdProveedor = CType(Me.cmbProveedor.SelectedValue, Integer)
        Me.Cotizacion.Observaciones = Me.txtObservaciones.Text
        Me.Cotizacion.IdUsuarioAlta = Controlador.Sesion.Usrndx
        Me.Cotizacion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
        Me.Cotizacion.OrdenServicioGenerada = False
        Me.Cotizacion.SubTotal = CDbl(Me.txtSubTotal.Text)
        Me.Cotizacion.IVA = CDbl(Me.txtIVA.Text)
        Me.Cotizacion.Descuento = CDbl(Me.txtDescuento.Text)
        Me.Cotizacion.Total = CDbl(Me.txtTotal.Text)
        Me.Cotizacion.TipoMonedaId = CType(Me.cmbMoneda.SelectedValue, Integer)
    End Sub

    Sub PonerDatos()
        Me.cmbPlaza.SelectedValue = Me.Cotizacion.Sucursal.Plaza.Codigo
        Me.CmbSucursal.SelectedText = Me.Cotizacion.Sucursal.Descripcion
        Me.txtFolio.Text = Me.Cotizacion.Folio
        Me.DtpFecha.Value = Me.Cotizacion.FechaAlta
        Me.cmbProveedor.SelectedValue = Me.Cotizacion.IdProveedor
        Me.txtSolicito.Text = Me.Cotizacion.UsuarioAlta.NombreCompleto
        Me.txtObservaciones.Text = Me.Cotizacion.Observaciones
        Me.cmbMoneda.SelectedValue = Me.Cotizacion.TipoMonedaId
        Me.lblEstatus.Text = Me.Cotizacion.Estatus.ToString
        Me.lblEstatus.Visible = True
        Me.CmbSucursal.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.dgvDetalle.ReadOnly = True
    End Sub

    Public Function Validar() As Boolean
        Try
            If Me.CmbSucursal.SelectedIndex = -1 Then
                MessageBox.Show("Especifique la Sucursal", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CmbSucursal.Focus()
                Return False
            End If
            If Me.cmbPlaza.SelectedIndex = -1 Then
                MessageBox.Show("Especifique la Plaza", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbPlaza.Focus()
                Return False
            End If
            If Me.cmbProveedor.SelectedIndex = -1 Then
                MessageBox.Show("Especifique un Proveedor", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbProveedor.Focus()
                Return False
            End If

            Dim Selecciono As Boolean = False
            For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                If CType(Me.dgvDetalle.Rows(i).Cells(Me.clmSeleccion.Index).Value, Boolean) Then
                    Selecciono = True
                End If
            Next
            If Not Selecciono Then
                MessageBox.Show("seleccione una solicitud", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dgvDetalle.Focus()
                Return False
            End If
            If Me.txtTotal.Text = 0 Then
                MessageBox.Show("No puede guardar una cotizacion en $0.00 ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function GuardarDetalle(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If Me.dgvDetalle.Rows.Count > 0 Then
                For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                    If CType(Me.dgvDetalle.Rows(i).Cells("clmSeleccion").Value, Boolean) Then
                        Me.CotizacionDet = New CotizacionServicioDetClass

                        Me.CotizacionDet.FolioCotizacion = Me.txtFolio.Text
                        Me.CotizacionDet.FolioSolicitud = Me.dgvDetalle.Rows(i).Cells("clmFolio").Value.ToString
                        Me.CotizacionDet.indice = CType(Me.dgvDetalle.Rows(i).Cells("clmIndice").Value, Integer)
                        Me.CotizacionDet.Cantidad = Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmcantidad").Value.ToString)

                        If Me.dgvDetalle.Rows(i).Cells("clmcosto").Value Is Nothing Then
                            MessageBox.Show("Especifique la Costo del Servicio", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return False
                        Else
                            Me.CotizacionDet.Costo = Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("ClmCosto").Value.ToString)
                        End If

                        Me.CotizacionDet.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                        Me.CotizacionDet.Descuento = CDec(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value) 'Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("ClmDescuento").Value.ToString)
                        Me.CotizacionDet.IVA = CDec(Me.dgvDetalle.Rows(i).Cells("Clmiva").Value) 'Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("Clmiva").Value.ToString)
                        Me.CotizacionDet.Total = Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("ClmImporte").Value.ToString)

                        If Not Me.CotizacionDet.Guardar(Trans) Then
                            Return False
                        End If
                    End If
                Next
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub CalcularImportes()
        Try
            Me.txtSubTotal.Text = ""
            Me.txtDescuento.Text = ""
            Me.txtIVA.Text = ""
            Me.txtTotal.Text = ""
            Me.txtImporte.Text = ""

            Dim SubTotal As Decimal = 0
            Dim Descuento As Decimal = 0
            Dim IVA As Decimal = 0
            Dim Total As Decimal = 0
            Dim Importe As Decimal = 0

            For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                If Not Me.dgvDetalle.Rows(i).Cells(Me.clmCosto.Index).Value Is Nothing And CType(Me.dgvDetalle.Rows(i).Cells("clmSeleccion").Value, Boolean) Then
                    Descuento += CDec(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value)

                    If Not Me.dgvDetalle.Rows(i).Cells("clmImporte").Value Is Nothing Then
                        Total += CDec(Me.dgvDetalle.Rows(i).Cells("clmImporte").Value)
                    End If

                    Importe += Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value.ToString) * Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmcosto").Value.ToString)
                    SubTotal += Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value.ToString) * Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmcosto").Value.ToString) - Descuento 'Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value.ToString)

                    If Not Me.dgvDetalle.Rows(i).Cells("clmIva").Value Is Nothing Then
                        IVA += (CDec(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value) * CDec(Me.dgvDetalle.Rows(i).Cells("clmcosto").Value) - CDec(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value)) * (CDec(Me.dgvDetalle.Rows(i).Cells("clmiva").Value) / 100)
                        '(Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value.ToString) * Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmcosto").Value.ToString) - Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value.ToString)) * (Decimal.Parse(dgvDetalle.Rows(i).Cells("clmiva").Value.ToString) / 100)
                    End If
                Else
                    If Not Me.dgvDetalle.Rows(i).Cells(Me.clmCosto.Index).Value Is Nothing Then
                        Descuento += CDec(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value)
                        If Not Me.dgvDetalle.Rows(i).Cells("clmImporte").Value Is Nothing Then
                            Total += CDec(Me.dgvDetalle.Rows(i).Cells("clmImporte").Value)
                        End If

                        Importe += Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value.ToString) * Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmcosto").Value.ToString)
                        SubTotal += Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value.ToString) * Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmcosto").Value.ToString) - Descuento 'Decimal.Parse(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value.ToString)

                        If Not Me.dgvDetalle.Rows(i).Cells("clmIva").Value Is Nothing Then
                            IVA += (CDec(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value) * CDec(Me.dgvDetalle.Rows(i).Cells("clmcosto").Value) - CDec(Me.dgvDetalle.Rows(i).Cells("clmDescuento").Value)) * (CDec(Me.dgvDetalle.Rows(i).Cells("clmiva").Value) / 100)
                        End If
                    End If
                End If
            Next

            Me.txtDescuento.Text = Descuento.ToString("C2")
            Me.txtImporte.Text = Importe.ToString("C2")
            Me.txtIVA.Text = IVA.ToString("C2")
            Me.txtTotal.Text = Total.ToString("C2")
            Me.txtSubTotal.Text = SubTotal.ToString("C2")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub CalcularSuma()
        Try
            Dim Suma As Decimal = 0D

            For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                If Not Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value Is Nothing Then
                    Suma += CType(Me.dgvDetalle.Rows(i).Cells("clmcantidad").Value, Decimal)
                End If
            Next
            Me.txtSuma.Text = Suma.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub Imprimir()
        Try
            Dim verReporte As New FrmReportes
            Me.CotizacionSolicCabC.Clear()
            Me.CotizacionSolicCabC.Add(Me.Cotizacion)
            verReporte.CRV.ReportSource = Me.CotizacionSolicCabC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            verReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


#End Region

#Region "Botones TollBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Me.Cotizacion.Estatus = EstatusDatos.CANCELADO Then
                MessageBox.Show("No se puede Cancelar esta cotizacion debido a que ya estaba cancelada", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Limpiar()
                Me.DesHabilitar()
                Cancelar = True
                Exit Sub
            End If
            If Me.Cotizacion.OrdenServicioGenerada = True Then
                MessageBox.Show("No se puede cancelar la cotización debido a que ya tiene un orden de servicios generada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Limpiar()
                Me.DesHabilitar()
                Cancelar = True
                Exit Sub
            End If
            If Not Me.Cotizacion.FolioOrdenServicio = " " Then
                MessageBox.Show("No se Puede Cancelar esta Cotización debido a que esta relacionada con una Orden de Servicios", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Me.Limpiar()
                Me.DesHabilitar()
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de Cancelar la Cotización de Servicios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Cotizacion.UsuarioCancelacion = Controlador.Sesion.Usrndx
                If Me.Cotizacion.Borrar() Then
                    MessageBox.Show("La Cotizacion ha sido Cancelada", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Limpiar()
                    Me.DesHabilitar()
                End If
            Else
                Cancelar = True
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            inicio = True
            Dim Ventana As New ComBusquedaCotizacionServicios
            Ventana.Icon = Me.Icon
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Folio As String = Ventana.DataGridView1.SelectedRows(0).Cells(Ventana.clmFolio.Index).Value.ToString
                Me.Cotizacion = New CotizacionServicioClass
                Me.Cotizacion.Obtener(Folio)
                PonerDatos()
                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.DataSource = Me.Cotizacion.Detalle
                'Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'Me.clmFechaSurtir.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.clmFolio.DataPropertyName = "FolioSolicitud"
                'Me.clmObservaciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.CalcularSuma()
                Me.CalcularImportes()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        DesHabilitar()
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            Me.dgvDetalle.Enabled = True
            Me.dgvDetalle.ReadOnly = False
            Me.clmDescuento.ReadOnly = True
            Me.txtObservaciones.Enabled = True
            Me.clmIVA.ReadOnly = True
            Me.clmImporte.ReadOnly = True
            modo = 2 'Modo edicion
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        If MessageBox.Show("¿Esta seguro de Guardar la Cotización de Servicios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Me.dgvDetalle.Refresh()
                If Me.dgvDetalle.Rows.Count = 0 Then
                    MessageBox.Show("Ingrese los Detalles de la Cotización", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cancelar = True
                    Exit Sub
                End If

                Me.dgvDetalle.Rows(0).Cells("clmimporte").Selected = True

                If Not Me.Validar Then
                    Cancelar = True
                    Exit Sub
                End If

                ' Genero el Folio
                If modo = 1 Then 'Si es nuevo el registro
                    If SPA.UspMcompFolioCotizacionServIns(Me.txtFolio.Text, Trans) = 0 Then
                        Trans.Rollback()
                    End If
                    ' Guardar el cabecero
                    Me.Guardar()
                    If Not Me.Cotizacion.Guardar(Trans) Then
                        Trans.Rollback()
                        Exit Sub
                    End If
                    'guardar el detalle
                    If Not Me.GuardarDetalle(Trans) Then
                        Trans.Rollback()
                        MessageBox.Show("No se ha podido Guardar la Cotización de Servicios ")
                        Cancelar = True
                        Exit Sub
                    End If
                    Trans.Commit()
                    MessageBox.Show("Se Guardo la Cotización de Servicios con el Folio: " & Me.txtFolio.Text)
                    Limpiar()
                    DesHabilitar()
                Else
                    ' Guardar el cabecero
                    Me.Guardar()
                    If Not Me.Cotizacion.Guardar(Trans) Then
                        Trans.Rollback()
                        Exit Sub
                    End If
                    If Me.Cotizacion.Detalle.Guardar(Trans) = -1 Then
                        Trans.Rollback()
                        MessageBox.Show("No se ha podido modificar la Cotización de Servicios ")
                        Cancelar = True
                        Exit Sub
                    End If
                    Trans.Commit()
                    MessageBox.Show("Se ha modificado la Cotización de Servicios")
                    Limpiar()
                    DesHabilitar()
                End If

                Me.Imprimir()

                ' Me.SolicitudServDetC.Obtener()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Habilitar()
            Limpiar()
            Me.cmbPlaza.Focus()
            Me.txtSolicito.Text = Controlador.Sesion.MiUsuario.Usrnomcom
            Me.Cotizacion = New CotizacionServicioClass
            Me.CotizacionDet = New CotizacionServicioDetClass
            modo = 1 ' nuevo
            inicio = False
            Me.CotizacionSolicCabC.Clear()

            Dim TipoMonedaColeccion As New Integralab.ORM.CollectionClasses.TipoMonedaCollection
            TipoMonedaColeccion.GetMulti(Integralab.ORM.HelperClasses.TipoMonedaFields.MonedaLocal = True)

            If TipoMonedaColeccion.Count > 0 Then
                cmbMoneda.SelectedValue = TipoMonedaColeccion(0).Codigo
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "Filtro Busqueda"
    '' ================================  PLAZA   ================================
    Private Sub cmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPlaza.KeyPress
        If e.KeyChar <> Chr(13) Then
            Tmplaza.Stop()
            UltimaTeclaPlaza = Now
            Me.Tmplaza.Start()
        End If
    End Sub

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.PlazaC.Obtener(CondicionEnum.ACTIVOS)
                Me.cmbPlaza.Text = "Seleccione una Plaza"
                Me.cmbPlaza.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.TextChanged
        Try
            'If inicio = False Then
            If Me.cmbPlaza.SelectedIndex > -1 Then
                Me.SucursalC.Obtener(CType(Me.cmbPlaza.SelectedValue, Integer), CondicionEnum.ACTIVOS)
                Me.CmbSucursal.DataSource = Me.SucursalC
                Me.CmbSucursal.DisplayMember = "Descripcion"
                Me.CmbSucursal.ValueMember = "codigo"
                If Me.CmbSucursal.SelectedIndex = -1 Then
                    Me.CmbSucursal.Text = "Seleccione una Sucursal"
                End If
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            'If inicio = False Then
            If Me.cmbPlaza.SelectedIndex > -1 Then
                Me.SucursalC.Obtener(CType(Me.cmbPlaza.SelectedValue, Integer), CondicionEnum.ACTIVOS)
                Me.CmbSucursal.DataSource = Me.SucursalC
                Me.CmbSucursal.DisplayMember = "Descripcion"
                Me.CmbSucursal.ValueMember = "codigo"
                Me.CmbSucursal.Enabled = True
                If Me.CmbSucursal.SelectedIndex > -1 Then
                    Me.CmbSucursal.Text = "Seleccione una Sucursal..."
                End If
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '' ================================   SUCURSAL   ================================
    Private Sub CmbSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSucursal.KeyPress
        If e.KeyChar <> Chr(13) Then
            TmSucursal.Stop()
            UltimaTeclaSucursal = Now
            Me.TmSucursal.Start()
        End If
    End Sub

    Private Sub CmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbSucursal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbPlaza_SelectedIndexChanged(Me, e)
                Me.CmbSucursal.SelectedIndex = -1
                Me.CmbSucursal.Text = "Seleccione una Sucursal"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSucursal.SelectedIndexChanged
        Try
            If Not Me.cmbPlaza.SelectedIndex = -1 And Not Me.CmbSucursal.SelectedIndex = -1 Then
                Buscar2(CType(Me.cmbPlaza.SelectedValue, Integer), CType(Me.CmbSucursal.SelectedValue, Integer))
                If Me.dgvDetalle.Rows.Count > 0 Then
                    Me.dgvDetalle.Enabled = False
                    Me.cmbProveedor.Enabled = True
                Else
                    Me.dgvDetalle.Enabled = False
                    Me.cmbProveedor.Enabled = False
                    Me.cmbProveedor.SelectedIndex = -1
                    Me.cmbProveedor.Text = "Seleccione Proveedor..."
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '' ================================   PROVEEDOR   ================================
    Private Sub cmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            'If IsNothing(Me.cmbProveedor.SelectedValue) Then
            '    MsgBox("Seleccione un Proveedor")
            '    Me.cmbProveedor.Focus()
            'End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbProveedor.ValueMember = "IDProveedor"
            Me.cmbProveedor.DataSource = ProveedorC
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.SelectedIndex = -1
            Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            'Me.TmProveedor.Stop()
            'Me.UltimaTeclaProveedor = Now
            'Me.TmProveedor.Start()
        End If
        If Me.cmbProveedor.SelectedIndex = 0 Then
            Me.cmbProveedor.SelectedIndex = -1
            Me.txtObservaciones.Enabled = False
        End If
    End Sub

    Private Sub cmbProveedor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProveedor.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.ProveedorC.Obtener(CondicionEnum.ACTIVOS)
                Me.cmbProveedor.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        Try
            If Me.cmbProveedor.SelectedIndex > -1 Then
                Me.dgvDetalle.Enabled = True
                Me.txtObservaciones.Enabled = True
            Else
                Me.dgvDetalle.Enabled = False
                Me.txtObservaciones.Enabled = False
                'Me.txtObservaciones.Text = ""

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Buscar2(ByVal IdPlaza As Integer, ByVal IdSucursal As Integer)
        Try
            If inicio = False Then
                Dim Filtro As New OC.PredicateExpression
                'ojo
                'Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.PlidPlaza = IdPlaza)
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.SucursalId = IdSucursal)
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.Estatus2 = EstatusDatos.VIGENTE)
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.EstatusDet = EstatusDatos.VIGENTE)

                Dim Lista As New TC.VwCompBusqSolicitudServiciosTypedView
                Lista.Fill(0, Nothing, True, Filtro)

                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.DataSource = Lista
                ' Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.clmFolio.DataPropertyName = "Folio"
                Me.clmImporte.ReadOnly = True
                CalcularSuma()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "DataGrid"

    Private Sub dgvDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        Dim Importe As Decimal
        Dim Cantidad As Integer = CType(Me.dgvDetalle.CurrentRow.Cells("clmCantidad").Value, Integer)
        Dim Costo As Decimal
        Dim Descuento As Decimal
        Dim IVA As Decimal
        ' Asiganarele valores a las variables si se ingresarin solo números
        If IsNumeric(Me.dgvDetalle.CurrentRow.Cells("clmcosto").Value) Then
            Costo = CType(Me.dgvDetalle.CurrentRow.Cells("clmcosto").Value, Decimal)
        End If

        If IsNumeric(Me.dgvDetalle.CurrentRow.Cells("clmDescuento").Value) Then
            Descuento = CType(Me.dgvDetalle.CurrentRow.Cells("clmDescuento").Value, Decimal)
        End If

        If IsNumeric(Me.dgvDetalle.CurrentRow.Cells("clmIva").Value) Then
            IVA = CType(Me.dgvDetalle.CurrentRow.Cells("clmIva").Value, Decimal)
        End If

        Select Case e.ColumnIndex
            Case Me.clmServicio.Index
                Refresh()

            Case Me.clmSeleccion.Index 'Case Seleccion
                If CType(Me.dgvDetalle.CurrentRow.Cells("clmSeleccion").Value, Boolean) = False Then
                    Me.dgvDetalle.CurrentRow.Cells("clmCosto").Value = Nothing
                    Me.dgvDetalle.CurrentRow.Cells("clmDescuento").Value = Nothing
                    Me.dgvDetalle.CurrentRow.Cells("clmiva").Value = Nothing
                    Me.dgvDetalle.CurrentRow.Cells("clmimporte").Value = Nothing
                End If
                Me.CalcularImportes()
            Case Me.clmCosto.Index 'Case columna Costo
                If Not IsNumeric(Me.dgvDetalle.CurrentRow.Cells("clmcosto").Value) Then
                    MsgBox("Ingrese solo números", MsgBoxStyle.Information)
                    Me.dgvDetalle.CurrentRow.Cells("clmcosto").Value = 0
                End If
                If Not Costo = 0 Then ' si el costo no es cero se calcula el importe
                    Me.dgvDetalle.CurrentRow.Cells(Me.clmSeleccion.Index).Value = True
                    Importe = Cantidad * Costo
                    Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    If Not Descuento = 0 Then
                        Importe = Cantidad * Costo - Descuento
                        Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    End If

                    If Not IVA = 0 Then
                        Dim ImporteIva As Decimal
                        ImporteIva = IVA / 100D + 1D
                        Importe = (Cantidad * Costo - Descuento) * ImporteIva
                        Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    End If
                    CalcularImportes()
                Else  'si el costo es cero el importe es = a cero
                    Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = 0
                End If

            Case Me.clmDescuento.Index  'Case columna Descuento
                If Not IsNumeric(Me.dgvDetalle.CurrentRow.Cells("clmDescuento").Value) Then
                    MsgBox("Ingrese solo números", MsgBoxStyle.Information)
                    Me.dgvDetalle.CurrentRow.Cells("clmDescuento").Value = 0
                End If
                If Not Costo = 0 Then
                    Me.dgvDetalle.CurrentRow.Cells(Me.clmSeleccion.Index).Value = True
                    Importe = Cantidad * Costo
                    Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    If Not Descuento = 0 Then
                        Importe = Cantidad * Costo - Descuento
                        Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    End If

                    If Not IVA = 0 Then
                        Dim ImporteIva As Decimal
                        ImporteIva = IVA / 100D + 1D
                        Importe = (Cantidad * Costo - Descuento) * ImporteIva
                        Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    End If
                    CalcularImportes()
                Else
                    Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = 0
                End If

            Case Me.clmIVA.Index ' Case columna IVA
                If Not IsNumeric(Me.dgvDetalle.CurrentRow.Cells("clmIva").Value) Then
                    MsgBox("Ingrese solo números", MsgBoxStyle.Information)
                    Me.dgvDetalle.CurrentRow.Cells("clmIva").Value = 0
                End If
                If Not Costo = 0 Then
                    Me.dgvDetalle.CurrentRow.Cells(Me.clmSeleccion.Index).Value = True
                    Importe = Cantidad * Costo
                    Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    If Not Descuento = 0 Then
                        Importe = Cantidad * Costo - Descuento
                        Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    End If

                    If Not IVA = 0 Then
                        Dim ImporteIva As Decimal
                        ImporteIva = IVA / 100D + 1D
                        Importe = (Cantidad * Costo - Descuento) * ImporteIva
                        Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = Importe
                    End If
                    CalcularImportes()
                Else
                    Me.dgvDetalle.CurrentRow.Cells("clmImporte").Value = 0
                End If
        End Select
    End Sub
#End Region

    Private Sub cmbMoneda_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbMoneda.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.MonedaTC.Obtener()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Tmplaza_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmplaza.Tick
        If Me.UltimaTeclaPlaza.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.Tmplaza.Stop()
            Me.PlazaC.Obtener(Me.cmbPlaza.Text, ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub TmSucursal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmSucursal.Tick
        If Me.UltimaTeclaSucursal.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.TmSucursal.Stop()
            Me.SucursalC.Obtener(Me.CmbSucursal.Text, ClasesNegocio.CondicionEnum.ACTIVOS, CType(Me.cmbPlaza.SelectedValue, Integer))
            Me.CmbSucursal.DataSource = SucursalC
        End If
    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProveedor.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                ProveedorC.Obtener(False, Me.cmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvDetalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalle.DataError

    End Sub


End Class