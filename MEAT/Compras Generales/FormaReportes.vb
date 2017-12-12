Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ClasesNegocio

Public Class FormaReportes

    'Private Solicitudes As New listadoSolicitudesCollectionClass
    Private Presupuestos As New ListadoPresupuestosCollectionClass
    Private Cotizaciones As New ListadoCotizacionesCollectionClass
    Private Recepciones As New ListadoRecepciondeOrdenesdeCompraCollectionClass


    Private Sub FormaReportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'llena combo plazas
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.ValueMember = "Codigo"
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.DataSource = CC.PlazaCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
        Me.cmbPlaza.SelectedIndex = -1
        'llena combo proveedores
        Me.cmbProveedor.DataSource = CC.ProveedorCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.ValueMember = "Codigo"
        Me.cmbProveedor.SelectedIndex = -1
        'llena combo productos
        Me.cmbProducto.DataSource = CC.ProductoCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
        Me.cmbProducto.DisplayMember = "Descripcion"
        Me.cmbProducto.ValueMember = "Codigo"
        Me.cmbProducto.SelectedIndex = -1
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            If Me.rbtServicios.Checked = True Then
                If Me.rbtSolSer.Checked Then
                    Me.SolicitudesServicios()
                    Exit Sub
                End If
                If Me.RbtCotizServ.Checked Then
                    Me.CotizacionesServicios()
                    Exit Sub
                End If
                If Me.RbtOrdSer.Checked Then
                    Me.OrdenesServicios(False)
                    Exit Sub
                End If
                If Me.RbtRecepServ.Checked Then
                    Me.OrdenesServicios(True)
                    Exit Sub
                End If
            Else

                Dim PLazaId As Integer = -1
                Dim Sucursalid As Integer = -1
                Dim ProductoId As Integer = -1
                Dim ProveedorId As Integer = -1
                Dim Folio As String = -1
                Dim FechaInicial As Date = Now.Date
                Dim FechaFinal As Date = Now.Date
                Dim RangoFechas As Integer = -1

                Dim DatosPresupuestos As New DataGridView
                Dim DatosCotizaciones As New DataGridView
                Dim DatosOrdenesdeCompra As New DataGridView
                Dim DatosRecepcion As New DataGridView
                Dim DatosSolicitudes As New DataGridView

                DatosCotizaciones.AutoGenerateColumns = False
                DatosCotizaciones.DataSource = Cotizaciones

                DatosOrdenesdeCompra.AutoGenerateColumns = False
                'DatosOrdenesdeCompra.DataSource = OrdenesdeCompra

                DatosRecepcion.AutoGenerateColumns = False
                DatosRecepcion.DataSource = Recepciones

                'DatosSolicitudes.AutoGenerateColumns = False
                'DatosSolicitudes.DataSource = Solicitud

                If Me.txtFolio.Text = "" Then
                    If Me.cmbPlaza.SelectedValue > -1 Then
                        PLazaId = Me.cmbPlaza.SelectedValue
                    End If
                    If Me.cmbProducto.SelectedValue > -1 Then
                        ProductoId = Me.cmbProducto.SelectedValue
                    End If
                    If Me.cmbProveedor.SelectedValue > -1 Then
                        ProveedorId = Me.cmbProveedor.SelectedValue
                    End If
                    If Me.cmbSucursal.SelectedValue > -1 Then
                        Sucursalid = Me.cmbSucursal.SelectedValue
                    End If
                Else
                    Folio = Me.txtFolio.Text
                    RangoFechas = -1
                End If


                If Me.rbSolicitudes.Checked Then
                    'Solicitud.Obtener(PLazaId, Sucursalid, ProductoId, Folio, FechaInicial, FechaFinal, RangoFechas)
                    'Dim Reporte As New ClasesNegocio.rptSolicitudes
                    'Reporte.SetDataSource(DatosSolicitudes.DataSource)
                    'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    'Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                    'Reporte.SetParameterValue(1, "Compras Generales\Reportes\Solicitudes")
                    'Dim VerReporte As New FrmReportes
                    'VerReporte.CRV.ReportSource = Reporte
                    'VerReporte.Show()
                    'Me.DataGridView1.DataSource = Solicitud
                End If

                If Me.rbOrdenes.Checked Then
                    'OrdenesdeCompra.Obtener(PLazaId, Sucursalid, ProductoId, ProveedorId, Folio, FechaInicial, FechaFinal, RangoFechas)
                    'Dim Reporte As New rptCompOrdenesCompra
                    'Reporte.SetDataSource(DatosOrdenesdeCompra.DataSource)
                    'Reporte.SetParameterValue(2, Controlador.Sesion.MiEmpresa.Empnom)
                    'Reporte.SetParameterValue(0, Controlador.Sesion.MiUsuario.Usrnomcom)
                    'Reporte.SetParameterValue(1, "Compras Generales\Reportes\OrdenesdeCompra")
                    'Dim VerReporte As New FrmReportes
                    'VerReporte.CRV.ReportSource = Reporte
                    'VerReporte.Show()
                    'Me.DataGridView1.DataSource = OrdenesdeCompra
                End If

                If Me.rbRecepciones.Checked Then
                    Recepciones.Obtener(PLazaId, Sucursalid, ProductoId, ProveedorId, Folio, FechaInicial, FechaFinal, RangoFechas)
                    'Dim Reporte As New rptCompRecepciones
                    'Reporte.SetDataSource(DatosRecepcion.DataSource)
                    'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    'Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                    'Reporte.SetParameterValue(2, "Compras Generales\Reportes\Recepción Orden de Compra")
                    'Dim VerReporte As New FrmReportes
                    'VerReporte.CRV.ReportSource = Reporte
                    'VerReporte.Show()
                    Me.DataGridView1.DataSource = Recepciones
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Utilerias.RunControlException(Me, "Imprimir")
    End Sub

    Public Sub Imprimir()
        If Me.rbtServicios.Checked Then
            If Me.rbtSolSer.Checked Then
                Me.BuscarSolicitudesServicios()
                Exit Sub
            End If
            If Me.RbtCotizServ.Checked Then
                Me.BuscarCotizacionesServicios()
                Exit Sub
            End If
            If Me.RbtOrdSer.Checked Then
                Me.BuscarOrdenesServicios(True)
                Exit Sub
            End If
            If Me.RbtRecepServ.Checked Then
                Me.BuscarOrdenesServicios(False)
                Exit Sub
            End If
        Else
            Dim PLazaId As Integer = -1
            Dim SucursalId As Integer = -1
            Dim ProductoId As Integer = -1
            Dim ProveedorId As Integer = -1
            Dim Folio As String = ""
            Dim FechaInicial As Date = Me.dtFechaI.Value.Date
            Dim FechaFinal As Date = Me.dtFechaF.Value.Date

            If Me.txtFolio.Text = "" Then
                If Me.cmbPlaza.SelectedIndex > -1 Then
                    PLazaId = Me.cmbPlaza.SelectedValue
                End If
                If Me.cmbProducto.SelectedIndex > -1 Then
                    ProductoId = Me.cmbProducto.SelectedValue
                End If
                If Me.cmbProveedor.SelectedIndex > -1 Then
                    ProveedorId = Me.cmbProveedor.SelectedValue
                End If
                If Me.cmbSucursal.SelectedIndex > -1 Then
                    SucursalId = Me.cmbSucursal.SelectedValue
                End If
            Else
                Folio = Me.txtFolio.Text
            End If

            If Me.rbSolicitudes.Checked Then
                ReporteSolicitudes(PLazaId, ProductoId, SucursalId, FechaInicial, FechaFinal, Folio)
            End If

            If Me.rbOrdenes.Checked Then
                Controlador.ReporteOrdenesCompra(PLazaId, SucursalId, ProductoId, ProveedorId, Folio, FechaInicial, FechaFinal)
            End If

            If Me.rbRecepciones.Checked Then
                ReporteRecepciones(PLazaId, ProductoId, ProveedorId, SucursalId, FechaInicial, FechaFinal, Folio)
            End If

        End If
    End Sub

    Private Sub rbSolicitudes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSolicitudes.CheckedChanged
        If rbSolicitudes.Checked Then
            cmbProveedor.Enabled = False
        End If
    End Sub

    Private Sub rbOrdenes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOrdenes.CheckedChanged
        If rbOrdenes.Checked Then
            cmbProveedor.Enabled = True
        End If
    End Sub

    Private Sub rbRecepciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRecepciones.CheckedChanged
        If rbRecepciones.Checked Then
            cmbProveedor.Enabled = True
        End If
    End Sub

    Public Function Validar() As Boolean
        If Not Me.dtFechaI.Text = "" And Not Me.dtFechaF.Text = "" Then
            If Me.dtFechaI.Value > Me.dtFechaF.Value Then
                MessageBox.Show("La Fecha Inicial debe ser Menor o Igual a la Fecha Final", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Sub BuscarSolicitudesServicios()
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.cmbPlaza.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.PlidPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.Folio = Me.txtFolio.Text)
            End If
            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompBusqSolicitudServiciosFields.FechaAlta, Me.dtFechaI.Value.Date, Me.dtFechaF.Value.AddDays(1).Date))
            Dim Lista As New TC.VwCompBusqSolicitudServiciosTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            If Not Lista.Count > 0 Then
                MsgBox("No se enconto ninguna Solicitud", MsgBoxStyle.Information, "No hay Informacion")
                Exit Sub
            End If

            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Lista

            Dim Reporte As New rptCompSolicitudServicios
            Reporte.SetDataSource(Me.DataGridView1.DataSource)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(1, "Compras Generales\Reportes\Solicitud de Servicios")
            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub BuscarCotizacionesServicios()
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.cmbPlaza.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.ScidPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If Me.cmbProveedor.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.ProveedorId = Me.cmbProveedor.SelectedValue)
            End If

            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.Folio = Me.txtFolio.Text)
            End If
            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompBusqCotizacionServiciosFields.FechaAlta, Me.dtFechaI.Value.Date, Me.dtFechaF.Value.AddDays(1).Date))
            Dim Lista As New TC.VwCompBusqCotizacionServiciosTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            If Not Lista.Count > 0 Then
                MsgBox("No se enconto ninguna Cotizacion", MsgBoxStyle.Information, "No hay Informacion")
                Exit Sub
            End If

            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Lista

            Dim Reporte As New rptCompCotizacionesServicios
            Reporte.SetDataSource(Me.DataGridView1.DataSource)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(1, "Compras Generales\Reportes\Cotizaciones de Servicios")
            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub BuscarOrdenesServicios(ByVal Recepcion As Boolean)
        Try
            Dim Filtro As New OC.PredicateExpression

            If Recepcion = True Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.Recibida = EstatusOrdenRecibida.RECIBIDA)
            End If

            If Me.cmbPlaza.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.ScidPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If Me.cmbProveedor.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.ProveedorId = Me.cmbProveedor.SelectedValue)
            End If

            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.Folio = Me.txtFolio.Text)
            End If

            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompReporteOrdenesServiciosFields.FechaAlta, Me.dtFechaI.Value.Date, Me.dtFechaF.Value.AddDays(1).Date))
            Dim Lista As New TC.VwCompReporteOrdenesServiciosTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            If Recepcion = True Then
                If Not Lista.Count > 0 Then
                    MsgBox("No se enconto ninguna Orden de Servicio", MsgBoxStyle.Information, "No hay Informacion")
                    Exit Sub
                End If
            Else
                If Not Lista.Count > 0 Then
                    MsgBox("No se enconto ninguna Recepcion", MsgBoxStyle.Information, "No hay Informacion")
                    Exit Sub
                End If
            End If

            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Lista

            Dim Reporte As New rptCompOrdenesServicios
            Reporte.SetDataSource(Me.DataGridView1.DataSource)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, "Compras Generales\Reportes\Cotizaciones de Servicios")
            If Me.RbtRecepServ.Checked Then
                Reporte.SetParameterValue("Titulo", "Reporte de Recepción de Ordenes de Servicios")
            Else
                Reporte.SetParameterValue("Titulo", "Reporte de Ordenes de Servicios")
            End If
            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub SolicitudesServicios()
        Try
            Dim Filtro As New OC.PredicateExpression

            If cmbPlaza.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.PlidPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwCompBusqSolicitudServiciosFields.Folio = Me.txtFolio.Text)
            End If
            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompBusqSolicitudServiciosFields.FechaAlta, Me.dtFechaI.Value.Date, Me.dtFechaF.Value.AddDays(1).Date))
            Dim Lista As New TC.VwCompBusqSolicitudServiciosTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            'Me.DataGridView1.AutoGenerateColumns = True
            Me.DataGridView1.DataSource = Lista

            'Dim Reporte As New rptCompSolicitudServicios
            'Reporte.SetDataSource(Me.DataGridView1.DataSource)
            'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            'Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            'Reporte.SetParameterValue(1, "Compras Generales\Reportes\Solicitud de Servicios")
            'Dim VerReporte As New FrmReportes
            'VerReporte.CRV.ReportSource = Reporte
            'VerReporte.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub CotizacionesServicios()
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.cmbPlaza.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.ScidPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If cmbProveedor.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.ProveedorId = Me.cmbProveedor.SelectedValue)
            End If

            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwCompBusqCotizacionServiciosFields.Folio = Me.txtFolio.Text)
            End If

            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompBusqCotizacionServiciosFields.FechaAlta, Me.dtFechaI.Value.Date, Me.dtFechaF.Value.AddDays(1).Date))
            Dim Lista As New TC.VwCompBusqCotizacionServiciosTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            'Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Lista

            'Dim Reporte As New rptCompCotizacionesServicios
            'Reporte.SetDataSource(Me.DataGridView1.DataSource)
            'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            'Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            'Reporte.SetParameterValue(1, "Compras Generales\Reportes\Cotizaciones de Servicios")
            'Dim VerReporte As New FrmReportes
            'VerReporte.CRV.ReportSource = Reporte
            'VerReporte.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub OrdenesServicios(ByVal Recepcion As Boolean)
        Try

            Dim Filtro As New OC.PredicateExpression

            If Recepcion = True Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.Recibida = EstatusOrdenRecibida.RECIBIDA)
            End If

            If Me.cmbPlaza.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.ScidPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If Me.cmbProveedor.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.ProveedorId = Me.cmbProveedor.SelectedValue)
            End If

            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwCompReporteOrdenesServiciosFields.Folio = Me.txtFolio.Text)
            End If
            Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompReporteOrdenesServiciosFields.FechaAlta, Me.dtFechaI.Value.Date, Me.dtFechaF.Value.AddDays(1).Date))
            Dim Lista As New TC.VwCompReporteOrdenesServiciosTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            ' Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Lista

            'Dim Reporte As New rptCompOrdenesServicios
            'Reporte.SetDataSource(Me.DataGridView1.DataSource)
            'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            'Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            'Reporte.SetParameterValue(2, "Compras Generales\Reportes\Cotizaciones de Servicios")
            'If Me.RbtRecepServ.Checked Then
            '    Reporte.SetParameterValue("Titulo", "Reporte de Recepción de Ordenes de Servicios")
            'Else
            '    Reporte.SetParameterValue("Titulo", "Reporte de Ordenes de Servicios")
            'End If
            'Dim VerReporte As New FrmReportes
            'VerReporte.CRV.ReportSource = Reporte
            'VerReporte.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbtServicios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtServicios.CheckedChanged
        If Me.rbtServicios.Checked = True Then
            Me.GroupBox3.Enabled = True
            Me.cmbProducto.Enabled = False
        Else
            Me.GroupBox3.Enabled = False
            Me.cmbProducto.Enabled = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub rbtCompras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCompras.CheckedChanged
        If Me.rbtCompras.Checked = True Then
            Me.GroupBox1.Enabled = True
        Else
            Me.GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            If Me.cmbPlaza.SelectedIndex > -1 Then
                'llena combo sucursales
                Dim SucursalC As New SucursalCollectionClass
                If Not Me.cmbPlaza.SelectedValue Is Nothing Then
                    SucursalC.Obtener(Me.cmbPlaza.SelectedValue, CondicionEnum.ACTIVOS)
                End If
                Me.cmbSucursal.DataSource = SucursalC
                Me.cmbSucursal.DisplayMember = "Descripcion"
                Me.cmbSucursal.ValueMember = "Codigo"
                Me.cmbSucursal.SelectedIndex = -1
                Me.cmbSucursal.Text = "Seleccione la Sucursal"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.rbtCompras.Checked = False
        Me.rbtServicios.Checked = False
        Me.rbSolicitudes.Checked = False
        Me.rbOrdenes.Checked = False
        Me.rbRecepciones.Checked = False
        Me.rbtServicios.Checked = False
        Me.rbtSolSer.Checked = False
        Me.RbtCotizServ.Checked = False
        Me.RbtOrdSer.Checked = False
        Me.RbtRecepServ.Checked = False
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione la Plaza"
        cmbProveedor.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione el Proveedor"
        cmbProducto.SelectedIndex = -1
        cmbProducto.Text = "Seleccione el Producto"
        txtFolio.Text = ""
        Me.dtFechaF.Value = Now
        Me.dtFechaI.Value = Now
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbProveedor.SelectedIndex = -1
        Me.cmbProducto.SelectedIndex = -1
    End Sub

    Sub ReporteSolicitudes(ByRef PLazaId As Integer, ByRef ProductoId As Integer, ByRef SucursalId As Integer, ByRef FechaInicial As Date, ByRef FechaFinal As Date, ByRef Folio As String)
        Dim Query As String = "select FolioSolicitud as Folio, " & _
                                                         "idproducto as Productoid, " & _
                                                         "CatalogoProductos.PdDescripcion as PdDescripcion, " & _
                                                         "CatalogoPlaza.PLDescripcion as PlDescripcion, " & _
                                                         "CatalogoPlaza.PLIdPlaza, " & _
                                                         "CatalogoSucursales.SCIdSucursal, " & _
                                                         "CatalogoSucursales.SCDescripcion, " & _
                                                         "EntregarA, " & _
                                                         "EntregarEn, " & _
                                                         "Solicitudproductos.Observaciones, " & _
                                                         "FechaSolicitud as FechaAlta, " & _
                                                         "Cantidad, " & _
                                                         "FechaSurtir, " & _
                                                         "SolicitudProductos.Observaciones as ObservacionesProducto, " & _
                                                         "CatalogoProductos.PdIdUnidadMedida as UmidUnidadMedida, " & _
                                                         "CatalogoProductos.PdDescripcion as UmDescripcion, " & _
                                                 "case SolicitudProductos.Estatus " & _
                                                         "when 0 then 'Cancelada' " & _
                                                         "when 1 then 'Vigente' " & _
                                                         "when 2 then 'Emitida' " & _
                                                         "when 3 then 'Parcialmente Emitida' " & _
                                                 "end  as Estatus, " & _
                                                 "case SolicitudProductosDetalle.Estatus " & _
                                                         "when 0 then 'Cancelada' " & _
                                                         "when 1 then 'Vigente' " & _
                                                         "when 2 then 'Emitida' " & _
                                                 "end as EstatusProducto, " & _
                                                 "case Urgente " & _
                                                         "when 0 then 'No' " & _
                                                         "Else 'Si' " & _
                                                 "end as Urgente " & _
                                                 "FROM dbo.MComSolicitudProductos as SolicitudProductos inner Join " & _
                                                      "dbo.MComSolicitudProductoDetalle as SolicitudProductosDetalle on SolicitudProductos.IdSolicitud = SolicitudProductosDetalle.IdSolicitud inner join " & _
                                                      "dbo.MCatCompProductos as CatalogoProductos on CatalogoProductos.PdIdProducto = SolicitudProductosDetalle.IdProducto inner join " & _
                                                      "dbo.MCatGenSucursales as CatalogoSucursales on CatalogoSucursales.SCIdSucursal = SolicitudProductos.IdSucursal inner join " & _
                                                      "dbo.MCatGenPlazas as CatalogoPlaza on CatalogoPlaza.PLIdPlaza = CatalogoSucursales.SCIdPlaza "
        Dim Where As String = ""

        If (Folio = "") Then
            If (PLazaId > -1) Then
                Where &= " Where PLIdPlaza = " & PLazaId
            End If

            If (SucursalId > -1) Then
                Where &= " AND SCIdSucursal = " & SucursalId
            End If

            If (ProductoId > -1) Then
                If (Where = "") Then
                    Where &= " Where "
                Else
                    Where &= " AND "
                End If
                Where &= " idproducto = " & ProductoId
            End If

            If (Where = "") Then
                Where &= " Where "
            Else
                Where &= " AND "
            End If
            Where &= " FechaSolicitud Between '" & FechaInicial.ToString("yyyyMMdd") & "' AND '" & FechaFinal.AddDays(1).Date.ToString("yyyyMMdd") & "'"
        Else
            Where &= " WHERE FolioSolicitud Like '%" & Folio & "%'"
        End If
        Query &= Where

        Dim da As New System.Data.SqlClient.SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)
        Dim dt As New ClasesNegocio.dsSolicitudes.ComSolicitudProductosDataTable
        Dim Reporte As New ClasesNegocio.rptSolicitudes
        Dim VerReporte As New FrmReportes
        Dim ds As New DataSet

        da.Fill(dt)
        If Not dt.Count > 0 Then
            MsgBox("No se enconto ninguna Solicitud", MsgBoxStyle.Information, "No hay Informacion")
            Exit Sub
        End If
        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, "Compras Generales\Reportes\Solicitudes")
        Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
        VerReporte.CRV.ReportSource = Reporte
        VerReporte.Show()
    End Sub

    Sub ReporteRecepciones(ByRef PLazaId As Integer, ByRef ProductoId As Integer, ByRef ProveedorId As Integer, ByRef SucursalId As Integer, ByRef FechaInicial As Date, ByRef FechaFinal As Date, ByRef Folio As String)
        Dim Query As String = "SELECT  Mcc.IdRecepcionOrdenCompra, " & _
                                       "Mcc.IdOrdenCompra, " & _
                                       "Mcc.FolioMovimientoAlm, " & _
                                       "Mcc.IdAlmacen, " & _
                                       "mcc.FolioRecepcionOrdenCompra AS Folio, " & _
                                       "moc.FolioOrdenCompra AS	OrdenCompraFolio, " & _
                                       "Mcc.IdSucursal, " & _
                                        "Cs.SCDescripcion, " & _
                                        "Cs.SCIdPlaza, " & _
                                        "Cp.PLDescripcion, " & _
                                       "Mcc.Observaciones, " & _
                                       "Mcd.IdProducto, " & _
                                       "Cpr.PdDescripcion, " & _
                                       "Mcd.Cantidad, " & _
                                       "Cum.UMDescripcion, " & _
                                       "Moc.IdProveedor as ProveedorId, " & _
                                       "Cpv.PrRazSocial, " & _
                                       "Mcc.FolioMovimientoAlmCan, " & _
                                       "Mcc.FechaRecepcion " & _
                        "FROM   dbo.MComRecepcionOrdenCompra AS Mcc INNER JOIN " & _
                               "dbo.MComRecepcionOrdenCompraDet AS Mcd ON Mcc.IdRecepcionOrdenCompra = Mcd.IdRecepcionOrdenCompra INNER JOIN " & _
                               "dbo.MComOrdenCompra AS Moc ON Moc.IdOrdenCompra = Mcc.IdOrdenCompra INNER JOIN " & _
                               "dbo.MCatGenSucursales AS Cs ON Cs.SCIdSucursal = Mcc.IdSucursal INNER JOIN " & _
                               "dbo.MCatGenPlazas AS Cp ON Cs.SCIdPlaza = Cp.PLIdPlaza INNER JOIN " & _
                               "dbo.MCatCompProductos AS Cpr ON Cpr.PdIdProducto = Mcd.IdProducto INNER JOIN " & _
                               "dbo.MCatCompUnidadMedida AS Cum ON Cum.UMIdUnidadMedida = Cpr.PdIdUnidadMedida INNER JOIN " & _
                               "dbo.MCatCompProveedores AS Cpv ON Cpv.PrIdProveedor = Moc.IdProveedor INNER JOIN " & _
                               "dbo.MCatAlmacenes AS Mca ON Mca.Codigo = Mcc.IdAlmacen "
        Dim Where As String = ""

        If (Folio = "") Then
            If (PLazaId > -1) Then
                Where &= " Where SCIdPlaza = " & PLazaId
            End If

            If (SucursalId > -1) Then
                Where &= " AND Mcc.IdSucursal = " & SucursalId
            End If

            If (ProveedorId > -1) Then
                Where &= " AND Mcc.IdProveedor=  " & ProveedorId
            End If

            If (ProductoId > -1) Then
                If (Where = "") Then
                    Where &= " Where "
                Else
                    Where &= " AND "
                End If
                Where &= " Mcc.IdProducto = " & ProductoId
            End If

            If (Where = "") Then
                Where &= " Where "
            Else
                Where &= " AND "
            End If
            Where &= " mcc.FechaRecepcion Between '" & FechaInicial.ToString("yyyyMMdd") & "' AND '" & FechaFinal.AddDays(1).Date.ToString("yyyyMMdd") & "'"
        Else
            Where &= " WHERE mcc.FechaRecepcion Like '%" & Folio & "%'"
        End If

        Query &= Where

        TextBox1.Text = Query

        Dim da As New System.Data.SqlClient.SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)
        Dim dt As New dsRecepciones.vwCompReporteRecepcionesOrdenesCompraDataTable
        Dim Reporte As New rptCompRecepciones
        Dim VerReporte As New FrmReportes
        Dim ds As New DataSet

        da.Fill(dt)
        If Not dt.Count > 0 Then
            MsgBox("No se enconto ninguna Recepcion", MsgBoxStyle.Information, "No hay Informacion")
            Exit Sub
        End If
        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Compras Generales\Reportes\Recepción Orden de Compra")
        VerReporte.CRV.ReportSource = Reporte
        VerReporte.Show()

    End Sub

End Class