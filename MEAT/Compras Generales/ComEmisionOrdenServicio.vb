Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class ComEmisionOrdenServicio
    Dim Orden As OrdenServicioClass
    Dim OrdenDet As OrdenServicioDetClass
    Dim ProveedorId As Integer
    Dim Modo As Integer 'Para saber si se va ingresar un registro nuevo o se va hacer una consulta
    Dim Inicio As Boolean
    Dim UltimaTeclaPlaza As DateTime
    Dim UltimaTeclaSucursal As DateTime

    Private Sub ComEmisionOrdenServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.PlazaC.Obtener(CondicionEnum.ACTIVOS)
            'Me.SucursalC.Obtener(CondicionEnum.ACTIVOS)
            Me.MonedaTC.Obtener()
            Me.CmbMoneda.SelectedValue = 1

            Me.Limpiar()
            Me.DesHabilitar()
            Inicio = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"

    Sub Limpiar()
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione una Plaza..."
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbSucursal.Text = "Seleccione una Sucursal..."
        Me.txtProveedor.Text = ""

        Me.dgvCotizaciones.DataSource = Nothing
        Me.dgvDetalle.DataSource = Nothing
        Me.txtFolio.Text = 0

        Me.txtSubTotal.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtIVA.Text = ""
        Me.txtTotal.Text = ""

        Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.clmProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.lblEstatus.Visible = False
        Me.txtObservaciones.Text = ""
    End Sub

    Sub Habilitar()
        Me.cmbPlaza.Enabled = True
        'Me.cmbSucursal.Enabled = True
        Me.dgvCotizaciones.Enabled = True
        Me.txtObservaciones.Enabled = True
        'Me.btnAceptar.Enabled = True
        Me.TabControl1.Enabled = True
    End Sub

    Sub DesHabilitar()
        Me.cmbSucursal.Enabled = False
        Me.cmbPlaza.Enabled = False
        Me.dgvCotizaciones.Enabled = False
        Me.txtObservaciones.Enabled = False
        'Me.btnAceptar.Enabled = False
        Me.TabControl1.Enabled = False
    End Sub

    Sub Guardar()
        'Me.Orden.Folio = Me.txtFolio.Text
        Me.Orden.SucursalId = Me.cmbSucursal.SelectedValue
        Me.Orden.ProveedorId = ProveedorId
        Me.Orden.Monedaid = Me.CmbMoneda.SelectedValue
        Me.Orden.TipoCambio = 1
        Me.Orden.DiasCredito = Orden.ObtenerEntidad.Proveedor.ProveedorAvanzado.DiasCredito
        Me.Orden.UsuarioAltaId = Controlador.Sesion.Usrndx
        Me.Orden.Total = Me.txtTotal.Text
        Me.Orden.Descuento = Me.txtDescuento.Text
        Me.Orden.SubTotal = Me.txtSubTotal.Text
        Me.Orden.IVA = Me.txtIVA.Text
        Me.Orden.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
        Me.Orden.Autorizada = False
        Me.Orden.Recibida = 0
        Me.Orden.Observaciones = Me.txtObservaciones.Text
    End Sub

    Sub CalcularImportes()
        Try
            Me.txtSubTotal.Text = ""
            Me.txtDescuento.Text = ""
            Me.txtIVA.Text = ""
            Me.txtTotal.Text = ""

            Dim SubTotal As Decimal = 0
            Dim Descuento As Decimal = 0
            Dim IVA As Decimal = 0
            Dim Total As Decimal = 0

            For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                If Not Me.dgvDetalle.Rows(i).Cells("clmcantOrd").Value = 0 Then
                    Descuento += CDec(Me.dgvDetalle.Rows(i).Cells("clmDescuentos").Value)

                    If Not Me.dgvDetalle.Rows(i).Cells("clmImportes").Value = Nothing Then
                        Total += CDec(Me.dgvDetalle.Rows(i).Cells("clmImportes").Value)
                    End If

                    'Me.txtImporte.Text += CDec(Me.dgvDetalle.Rows(i).Cells("clmCantidad").Value * Me.dgvDetalle.Rows(i).Cells("clmcosto").Value)
                    SubTotal += CDec((Me.dgvDetalle.Rows(i).Cells("clmCantOrd").Value * Me.dgvDetalle.Rows(i).Cells("clmPrecio").Value) - Me.dgvDetalle.Rows(i).Cells("clmDescuentos").Value)

                    If Not Me.dgvDetalle.Rows(i).Cells("clmIvas").Value = Nothing Then
                        IVA += CDec((Me.dgvDetalle.Rows(i).Cells("clmCantOrd").Value * Me.dgvDetalle.Rows(i).Cells("clmPrecio").Value - CDec(Me.dgvDetalle.Rows(i).Cells("clmDescuentos").Value)) * (dgvDetalle.Rows(i).Cells("clmivas").Value / 100))
                    End If
                End If
            Next
            Me.txtDescuento.Text = Descuento.ToString("C2")
            Me.txtTotal.Text = Total.ToString("C2")
            Me.txtIVA.Text = IVA.ToString("C2")
            Me.txtSubTotal.Text = SubTotal.ToString("C2")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Imprimir()
        Try
            Dim verReporte As New FrmReportes
            Me.OrdenServicioC.Clear()
            Me.OrdenServicioC.Add(Me.Orden)
            verReporte.CRV.ReportSource = Me.OrdenServicioC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            verReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function Validar() As Boolean
        Try
            If Me.cmbSucursal.SelectedIndex = -1 Then
                MessageBox.Show("Especifique la Sucursal", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Me.cmbSucursal.Focus()
            End If
            If Me.cmbPlaza.SelectedIndex = -1 Then
                MessageBox.Show("Especifique la Plaza", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Me.cmbPlaza.Focus()
            End If

            For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                If Me.dgvDetalle.Rows(i).Cells("clmCantOrd").Value = 0 Then
                    MessageBox.Show("Ingrese la Cantidad a Ordenar ", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub PonerDatos()
        Me.txtFolio.Text = Me.Orden.Folio
        Me.cmbSucursal.SelectedValue = Me.Orden.SucursalId
        Me.cmbPlaza.SelectedValue = Me.Orden.ObtenerEntidad.Sucursal.Plaza.Codigo
        Me.txtProveedor.Text = Me.Orden.ObtenerEntidad.Proveedor.RazonSocial
        Me.CmbMoneda.SelectedValue = Me.Orden.Monedaid
        Me.txtObservaciones.Text = Me.Orden.Observaciones
        Me.DtpFecha.Text = Me.Orden.FechaAlta
        Me.txtDescuento.Text = Me.Orden.Descuento.ToString("C2")
        Me.txtSubTotal.Text = Me.Orden.SubTotal.ToString("C2")
        Me.txtIVA.Text = Me.Orden.IVA.ToString("C2")
        Me.txtTotal.Text = Me.Orden.Total.ToString("C2")
        Me.lblEstatus.Text = Me.Orden.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub

#End Region

#Region "Botones Toolbar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Me.Orden.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                MessageBox.Show("No se puede cancelar la orden de servicios, ya se encuentra cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            If Not Me.Orden.FolioFactura = "" Or Not Me.Orden.FolioFactura = Nothing Then
                MessageBox.Show("No se puede cancelar la orden de servicios, ya se encuentra facturada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
                Exit Sub
            End If
            For Each Det As ClasesNegocio.OrdenServicioDetClass In Me.Orden.Detalle
                Det.ServicioDet.Estatus = ClasesNegocio.EstatusEnum.INACTIVO
            Next

            If MessageBox.Show("¿Esta seguro de Cancelar la Orden de Servicios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Orden.UsuarioCancelacionId = Controlador.Sesion.Usrndx
                If Me.Orden.Borrar() Then
                    MessageBox.Show("Se ha Cancelado la Orden de Servicios", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Limpiar()
                    Me.DesHabilitar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Inicio = True
            Modo = 2 ' Consulta
            Dim Ventana As New BusquedaOrdenesServicio
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Folio As String = Ventana.DataGridView1.SelectedRows(0).Cells("ClmFolio").Value
                Me.Orden = New OrdenServicioClass
                Me.Orden.Obtener(Folio)
                PonerDatos()
                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.DataSource = Me.Orden.Detalle
                Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.clmFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                'Me.clmObservaciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                ' Me.CalcularImportes()
                Me.TabControl1.SelectedIndex = 1
                Me.DesHabilitar()
            Else
                Cancelar = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New Integralab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            If Me.dgvDetalle.Rows.Count = 0 Then
                MessageBox.Show("No ha seleccionado Servicios para agregar a la Orden de Servicios", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Cancelar = True
                Exit Sub
            End If
            Me.dgvDetalle.Rows(0).Cells("clmServicios").Selected = True
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            Me.Guardar()
            If Not Me.Orden.Guardar2 Then
                MessageBox.Show("No se logró Guardar la Orden de Servicio ", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            Me.txtFolio.Text = Me.Orden.Folio
            MessageBox.Show("Se Generó la Orden de Servicio con el Folio:" & Me.Orden.Folio)

            'If MessageBox.Show("¿Desea ver el Reporte de la Cotización?", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Imprimir()
            'End If
            ' Trans.Commit()
            ' End If
            Me.Limpiar()
            Me.DesHabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        If Orden.Autorizada = True Then
            Imprimir()
        Else
            MessageBox.Show("La orden no se ha autorizado, debera autorizarse para imprimirla", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Limpiar()
            Habilitar()
            Me.Orden = New OrdenServicioClass
            Me.dgvDetalle.AutoGenerateColumns = False
            Me.dgvDetalle.DataSource = Orden.Detalle
            Me.cmbPlaza.Focus()
            Modo = 1 ' Nuevo Registro
            Inicio = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "Busqueda"

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
                Me.cmbPlaza.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            If Not Me.cmbPlaza.SelectedValue = Nothing Then
                Me.cmbSucursal.DataSource = CC.SucursalCollection.GetMultiAsDataTable(HC.SucursalFields.CodigoPlaza = Me.cmbPlaza.SelectedValue And HC.SucursalFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.SucursalFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
                Me.cmbSucursal.Enabled = True
                AgregarDetalle()
                ' Me.cmbSucursal.Text = "Seleccione una Sucursal"
            End If
            'If Not Me.cmbPlaza.SelectedIndex = -1 And Not Me.cmbSucursal.SelectedIndex = -1 Then
            '    Buscar(Me.cmbPlaza.SelectedValue, Me.cmbSucursal.SelectedValue)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Buscar(ByVal idPlaza As Integer, ByVal IdSucursal As Integer)
        Try
            If Inicio = False Then
                Dim Filtro As New OC.PredicateExpression
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.SucursalId = IdSucursal)
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.ScidPlaza = idPlaza)
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.Estatus = EstatusDatos.VIGENTE)
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.FolioOrdenServicio = "")
                Dim Lista As New TC.VwCompBusqCotizacionServiciosTypedView
                Lista.Fill(0, Nothing, True, Filtro)

                Me.dgvCotizaciones.AutoGenerateColumns = False
                Me.dgvCotizaciones.DataSource = Lista
                Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.clmProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSucursal.KeyPress
        If e.KeyChar <> Chr(13) Then
            TmSucursal.Stop()
            UltimaTeclaSucursal = Now
            Me.TmSucursal.Start()
        End If
    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbPlaza_SelectedIndexChanged(Me, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectedIndexChanged
        Try
            If Not Me.cmbPlaza.SelectedIndex = -1 And Not Me.cmbSucursal.SelectedIndex = -1 Then
                Buscar(Me.cmbPlaza.SelectedValue, Me.cmbSucursal.SelectedValue)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '    Try
    '        If Modo = 1 Then ' Si es un nuevo registro
    '            Orden.Detalle.Clear()
    '            Orden.CotizacionesModificar.Clear()
    '            For i As Integer = 0 To Me.dgvCotizaciones.Rows.Count - 1
    '                With Me.dgvCotizaciones.Rows(i)
    '                    If CBool(.Cells("clmSeleccion").Value) Then
    '                        Dim det As New ClasesNegocio.OrdenServicioDetClass
    '                        det.FolioDetSolic = .Cells("clmFolioSolic").Value
    '                        det.Indice = .Cells("clmIndice").Value
    '                        det.CantidadSolic = .Cells("clmCantidad").Value
    '                        'det.CantidadOrdenar = .Cells("clmCantOrd").Value
    '                        det.Precio = .Cells("clmCosto").Value
    '                        det.Descuento = .Cells("clmDescuento").Value
    '                        'det.Importe = .Cells("clmImporte").Value
    '                        det.IVA = .Cells("ClmIva").Value
    '                        det.Orden = Me.Orden
    '                        Orden.Detalle.Add(det)
    '                        det.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
    '                        det.ServicioDet.Estatus = ClasesNegocio.EstatusEnum.INACTIVO
    '                        Dim Cotizacion As New CotizacionServicioClass
    '                        Cotizacion.Obtener(.Cells("clmCotizacion").Value)
    '                        Orden.CotizacionesModificar.Add(Cotizacion)
    '                        Me.dgvDetalle.Rows(Me.dgvDetalle.Rows.Count - 1).Cells("clmFolioCotiz").Value = .Cells("clmCotizacion").Value
    '                    End If
    '                End With
    '            Next

    '            Me.TabControl1.SelectedIndex = 1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    'If Me.TabControl1.SelectedIndex = 0 Then
    'Me.txtDescuento.Text = 0
    'Me.txtIVA.Text = 0
    'Me.txtSubTotal.Text = 0
    'Me.txtTotal.Text = 0
    'Me.txtProveedor.Text = ""
    'Else
    'Me.btnAceptar_Click(Me, e)
    'End If
    'End Sub

#Region "DataGrid"
    Private Sub dgvDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        Dim CantOrd As Integer = Me.dgvDetalle.CurrentRow.Cells("clmCantord").Value
        Dim Importe As Decimal
        Dim Costo As Decimal = Me.dgvDetalle.CurrentRow.Cells("clmPrecio").Value
        Dim IVA As Decimal = Me.dgvDetalle.CurrentRow.Cells("clmIvas").Value
        Dim Descuento As Decimal = Me.dgvDetalle.CurrentRow.Cells("clmDescuentos").Value

        Select Case e.ColumnIndex
            Case Me.clmServicios.Index
                Refresh()

            Case Me.clmCantOrd.Index
                If Not IsNumeric(Me.dgvDetalle.CurrentRow.Cells("clmCantOrd").Value) Then
                    MessageBox.Show("Ingrese solo Números", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not CantOrd = 0 Then

                        Dim ImporteIva As Decimal
                        ImporteIva = IVA / 100D + 1D
                        Importe = (CantOrd * Costo - Descuento) * ImporteIva
                        Me.dgvDetalle.CurrentRow.Cells("clmImportes").Value = Importe

                        Me.CalcularImportes()
                    Else
                        Me.dgvDetalle.CurrentRow.Cells("clmImportes").Value = 0
                    End If
                End If
        End Select
    End Sub

    Private Sub dgvCotizaciones_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCotizaciones.CellContentClick
        Dim Control As DataGridViewCheckBoxCell = CType(Me.dgvCotizaciones.CurrentRow.Cells("clmSeleccion"), DataGridViewCheckBoxCell)
        Dim bandera As Boolean
        Select Case e.ColumnIndex
            Case Me.clmSeleccion.Index
                If Not Me.txtProveedor.Text = "" Then
                    If Not Me.dgvCotizaciones.CurrentRow.Cells("clmProveedor").Value = Me.txtProveedor.Text Then
                        MessageBox.Show("No Puede realizar una Orden de Servicio para diferentes Proveedores", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Control.EditingCellFormattedValue = False
                        Control.Value = False
                        Exit Select
                    End If
                Else
                    Me.txtProveedor.Text = Me.dgvCotizaciones.CurrentRow.Cells("clmProveedor").Value
                    ProveedorId = Me.dgvCotizaciones.CurrentRow.Cells("clmProveedorId").Value
                End If

                For i As Integer = 0 To Me.dgvCotizaciones.Rows.Count - 1
                    Dim Control2 As DataGridViewCheckBoxCell = CType(Me.dgvCotizaciones.Rows(i).Cells("clmSeleccion"), DataGridViewCheckBoxCell)

                    If Control2.EditingCellFormattedValue = True Then
                        AgregarDetalle()
                        bandera = True
                        Exit For
                    Else
                        bandera = False
                    End If
                Next
                If bandera = False Then
                    AgregarDetalle()
                    Me.txtProveedor.Text = ""
                End If
        End Select
    End Sub

    'Private Sub dgvCotizaciones_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCotizaciones.CellEndEdit
    'Select Case e.ColumnIndex
    '    Case Me.clmSeleccion.Index
    '        For i As Integer = 0 To Me.dgvCotizaciones.Rows.Count - 1
    '            If CBool(Me.dgvCotizaciones.Rows(i).Cells("clmSeleccion").Value) = True Then
    '                If Not Me.dgvCotizaciones.CurrentRow.Cells("clmProveedor").Value = Me.dgvCotizaciones.Rows(i).Cells("clmProveedor").Value Then
    '                    MessageBox.Show("No Puede realizar una Orden de Servicio para diferentes Proveedores", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Me.dgvCotizaciones.CurrentRow.Cells("clmSeleccion").Value = False
    '                    Exit Select
    '                End If
    '            End If
    '        Next
    '        Me.txtProveedor.Text = Me.dgvCotizaciones.CurrentRow.Cells("clmProveedor").Value
    '        ProveedorId = Me.dgvCotizaciones.CurrentRow.Cells("clmProveedorId").Value
    'End Select
    'End Sub

    Private Sub dgvCotizaciones_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCotizaciones.DataError

    End Sub

    Private Sub dgvDetalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalle.DataError

    End Sub

#End Region

    Private Sub CmbMoneda_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbMoneda.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.MonedaTC.Obtener()
                Me.CmbMoneda.SelectedValue = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.TextChanged
        Try
            If Not Me.cmbPlaza.SelectedValue = Nothing Then
                Me.cmbSucursal.DataSource = CC.SucursalCollection.GetMultiAsDataTable(HC.SucursalFields.CodigoPlaza = Me.cmbPlaza.SelectedValue And HC.SucursalFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.SucursalFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
                ' Me.cmbSucursal.Text = "Seleccione una Sucursal"
            End If
            'If Not Me.cmbPlaza.SelectedIndex = -1 And Not Me.cmbSucursal.SelectedIndex = -1 Then
            '    Buscar(Me.cmbPlaza.SelectedValue, Me.cmbSucursal.SelectedValue)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Me.SucursalC.Obtener(Me.cmbSucursal.Text, ClasesNegocio.CondicionEnum.ACTIVOS, Me.cmbPlaza.SelectedValue)
            Me.cmbSucursal.DataSource = SucursalC
        End If
    End Sub

    Sub AgregarDetalle()
        Try
            If Modo = 1 Then
                Orden.Detalle.Clear()
                Orden.CotizacionesModificar.Clear()
                Me.txtDescuento.Text = 0
                Me.txtIVA.Text = 0
                Me.txtSubTotal.Text = 0
                Me.txtTotal.Text = 0
                For i As Integer = 0 To Me.dgvCotizaciones.Rows.Count - 1
                    Dim Control As DataGridViewCheckBoxCell = CType(Me.dgvCotizaciones.Rows(i).Cells("clmSeleccion"), DataGridViewCheckBoxCell)
                    With Me.dgvCotizaciones.Rows(i)
                        If Control.EditingCellFormattedValue = True Then
                            'If CBool(.Cells("clmSeleccion").Value) Then
                            Dim det As New ClasesNegocio.OrdenServicioDetClass
                            det.FolioDetSolic = .Cells("clmFolioSolic").Value
                            det.Indice = .Cells("clmIndice").Value
                            det.CantidadSolic = .Cells("clmCantidad").Value
                            'det.FolioDetSolic = .Cells("clmCotizacion").Value
                            'det.CantidadOrdenar = .Cells("clmCantOrd").Value
                            det.Precio = .Cells("clmCosto").Value
                            det.Descuento = .Cells("clmDescuento").Value
                            'det.Importe = .Cells("clmImporte").Value
                            det.IVA = .Cells("ClmIva").Value
                            det.Orden = Me.Orden
                            Orden.Detalle.Add(det)
                            det.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                            det.ServicioDet.Estatus = ClasesNegocio.EstatusEnum.INACTIVO
                            Dim Cotizacion As New CotizacionServicioClass
                            Cotizacion.Obtener(.Cells("clmCotizacion").Value)
                            Orden.CotizacionesModificar.Add(Cotizacion)
                            Me.dgvDetalle.Rows(Me.dgvDetalle.Rows.Count - 1).Cells("clmFolioCotiz").Value = .Cells("clmCotizacion").Value
                        End If
                    End With
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class