Imports HC = Integralab.ORM.HelperClasses
Imports ClasesNegocio

Public Class FrmRegCotizaciones
    Inherits MeatForm

#Region "Miembros"

    Dim Cotizacion As CotizacionCompraClass = Nothing

#End Region

#Region "Metodos"

    Public Overrides Sub Modo(ByVal Edicion As Boolean)
        Me.txtObservaciones.Enabled = Edicion
        dtpFechaCotizacion.Enabled = Edicion
        dtpFechaVigencia.Enabled = Edicion
        txtPlazaCodigo.Enabled = Edicion
        cmbPlaza.Enabled = Edicion
        txtSucursalCodigo.Enabled = Edicion
        cmbSucursal.Enabled = Edicion
        dgvProductosSolicitados.ReadOnly = Not Edicion
        clmEstatus.Visible = Not (Edicion AndAlso tbrMenu.CurrentToolBarButtonStatus = MEAToolBar.MEAToolBar.ToolBarButtonEnum.Nuevo)
    End Sub

    Private Function Validar() As Boolean
        If cmbPlaza.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una plaza", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.cmbPlaza.Focus()
            Return False
        End If

        If cmbSucursal.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una sucursal", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbSucursal.Focus()
            Return False
        End If

        If Cotizacion.Detalle.Count = 0 Then
            Return False
        End If

        Return True
    End Function

    Private Sub CalcularTotal()
        Dim Cantidad As Decimal = 0D, TipoCambio As Decimal = 0D
        'Cotizacion.Importe = 0
        'Cotizacion.Descuento = 0
        'Cotizacion.SubTotal = 0
        'Cotizacion.IVA = 0
        'Cotizacion.Total = 0

        'For Each det As ClasesNegocio.CotizacionCompraProveedorCollectionClass In Cotizacion.Detalle
        '    Cotizacion.Importe += det.Precio * det.Cantidad
        '    Cotizacion.Descuento += det.Descuento

        '    If det.Producto.SeAplicaIva = AsignadaEnum.SI Then
        '        Cotizacion.SubTotal += det.Importe
        '        Cotizacion.IVA += Decimal.Round(det.Importe * 0.15D, 2I)
        '    Else
        '        Cotizacion.SubTotal += det.Importe
        '    End If
        '    Cantidad += det.Cantidad
        'Next
        'txtCantidad.Text = Cantidad.ToString("N3")

        'Cotizacion.Total = Cotizacion.SubTotal + Cotizacion.IVA

        'Me.txtSubTotal.Text = Cotizacion.SubTotal.ToString("C2")
        'Me.txtIVA.Text = Cotizacion.IVA.ToString("C2")
        'Me.txtTotal.Text = Cotizacion.Total.ToString("C2")

        'If Not IsNumeric(txtTipoCambio.Text) Then
        '    TipoCambio = CDbl(txtTipoCambio.Text)
        'End If

        'If TipoCambio > 1 Then
        '    Me.GrpImportesPesos.Visible = True
        '    txtSubTotalPesos.Text = (Cotizacion.SubTotal * TipoCambio).ToString("C2")
        '    txtIvaPesos.Text = (Cotizacion.IVA * TipoCambio).ToString("C2")
        '    txtTotalPesos.Text = ((Cotizacion.IVA + Cotizacion.SubTotal) * TipoCambio).ToString("C2")
        'End If
    End Sub

    Public Overrides Function Imprimir() As Boolean
        'Dim VerReporte As New FrmReportes
        'CotizacionCol = New CotizacionCompraCollectionClass
        'CotizacionCol.Add(Me.Cotizacion)
        'VerReporte.CRV.ReportSource = CotizacionCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        'VerReporte.Show()
        Return True
    End Function

    Public Overrides Sub InicializarForma()
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "010101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100001"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        Me.tbrMenu.ToolBarButtonStatus = MtbEstados
        Me.tbrMenu.sbCambiarEstadoBotones("Cancelar")

        dgvProductosSolicitados.AutoGenerateColumns = False

        'Controlador.LlenarComboMonedas(cmbMoneda, CondicionEnum.ACTIVOS)
        'Controlador.LlenarComboPlazas(cmbPlaza, CondicionEnum.ACTIVOS)
        Controlador.LlenarComboProveedores(clmProProveedor, False)

        Limpiar()
        Modo(False)
    End Sub

    Public Sub ActualizarPlazas(ByVal e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboPlazas(cmbPlaza, CondicionEnum.ACTIVOS)
        End If
    End Sub

    Public Sub ActualizarSucursales(ByVal e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.F12 Then
            If cmbPlaza.SelectedIndex <> -1 Then
                cmbSucursal.DataSource = CType(cmbPlaza.SelectedItem, PlazaClass).Sucursales
            Else
                cmbSucursal.DataSource = Nothing
            End If
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione la Sucursal"
        End If
    End Sub

    'Public Sub ActualizarMonedas(ByVal e As PreviewKeyDownEventArgs)
    '    If e.KeyCode = Keys.F12 Then
    '        Controlador.LlenarComboMonedas(cmbMoneda, CondicionEnum.ACTIVOS)
    '    End If
    'End Sub

    'Public Sub ActualizarProveedores(ByVal e As PreviewKeyDownEventArgs)
    '    If e.KeyCode = Keys.F12 Then
    '        Controlador.LlenarComboProveedores(cmbProveedor, False)
    '    End If
    'End Sub

    Private Sub CalcularCotizacion()
        'For Each CotDetalle As CotizacionCompraDetalleClass In Cotizacion.Detalle

        'Next
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Overrides Function Limpiar() As Boolean
        Me.txtCantidad.Clear()
        Me.txtFolio.Clear()
        Me.txtObservaciones.Clear()
        Me.txtCapturista.Clear()
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbSucursal.Text = "Seleccione la Sucursal"
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione la Plaza"
        Me.dgvProductosSolicitados.DataSource = Nothing
        Me.txtSubTotal.Clear()
        Me.txtIVA.Clear()
        Me.txtTotal.Clear()
        Me.lblEstatus.Text = ""
        Me.lblEstatus.Visible = False
        Me.GrpImportesPesos.Visible = False
        Me.txtTotalPesos.Text = "0"
        Me.txtIvaPesos.Text = "0"
        Me.txtSubTotalPesos.Text = "0"
        Return True
    End Function

    Public Overrides Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        If Me.Cotizacion.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
            MessageBox.Show("No se puede cancelar la cotización debido a que ya se encuentra cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If MessageBox.Show("¿Esta seguro de cancelar la Cotización de Productos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Me.Cotizacion.Borrar Then
                Me.Cotizacion.IdUsuarioCancelacion = Controlador.Sesion.Usrndx
                MessageBox.Show("La Cotizacion ha sido Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Modo(False)
                Limpiar()
            End If
        Else
            Return False
        End If
        Return True
    End Function

    Public Overrides Function Nuevo() As Boolean
        Modo(True)
        Limpiar()
        Cotizacion = New ClasesNegocio.CotizacionCompraClass
        dgvProductosSolicitados.DataSource = Cotizacion.Detalle
        Cotizacion.IdUsuarioAlta = Controlador.Sesion.MiUsuario.Usrndx
        txtCapturista.Text = Cotizacion.UsuarioAlta.NombreCompleto
        Return True
    End Function

    Public Overrides Function Buscar() As Boolean
        Dim Ventana As New ComBusquedaCotizacion

        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cotizacion = CType(Ventana.DataGridView1.SelectedRows(0).DataBoundItem, CotizacionCompraClass)

            Me.cmbPlaza.SelectedValue = Cotizacion.Sucursal.Plaza.Codigo
            Me.cmbSucursal.SelectedValue = Cotizacion.Sucursal.Codigo
            'Me.cmbMoneda.SelectedValue = Cotizacion.Moneda.Codigo
            'Me.cmbProveedor.SelectedValue = Cotizacion.Proveedor.Codigo
            'Me.txtCapturista.Text = Cotizacion.UsuarioAlta.NombreCompleto
            'Me.dtpFechaCotizacion.Value = Cotizacion.FechaCotizacion
            'Me.txtDiasCredito.Text = Me.Cotizacion.Proveedor.DiasCredito.ToString
            'Me.txtTipoCambio.Text = Me.Cotizacion.TipoCambio.ToString("C2")
            'Me.txtObservaciones.Text = Me.Cotizacion.Observaciones
            'Me.txtSubTotal.Text = Me.Cotizacion.SubTotal.ToString("C2")
            'Me.txtTotal.Text = Me.Cotizacion.Total.ToString("C2")
            'Me.txtIVA.Text = Me.Cotizacion.IVA.ToString("C2")
            Me.lblEstatus.Text = Me.Cotizacion.Estatus.ToString
            Me.lblEstatus.Visible = True

            Me.dgvProductosSolicitados.AutoGenerateColumns = False
            Me.dgvProductosSolicitados.DataSource = Cotizacion.Detalle
            Modo(False)
            CalcularTotal()
        Else
            Return False
        End If
        Return True
    End Function

    Public Overrides Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        If Not Validar() Then
            Return False
        End If

        Cotizacion.IdSucursal = CType(cmbSucursal.SelectedValue, Integer)
        'Cotizacion.IdMoneda = CType(cmbMoneda.SelectedValue, Integer)
        'Cotizacion.IdProveedor = CType(cmbProveedor.SelectedValue, Integer)
        'Cotizacion.TipoCambio = CDbl(txtTipoCambio.Text)
        Cotizacion.Observaciones = txtObservaciones.Text

        'Cotizacion.DiasCredito = 0I

        'If IsNumeric(txtDiasCredito.Text) Then
        '    Cotizacion.DiasCredito = CType(Me.txtDiasCredito.Text, Integer)
        'End If
        CalcularTotal()

        'If Cotizacion.Guardar Then
        '    MsgBox("Se ha guardado la cotización con el FOLIO: " & Cotizacion.FolioCotizacion, MsgBoxStyle.Information, "Aviso")
        '    Limpiar()
        '    Modo(False)
        'Else
        '    Return False
        'End If
        Return True
    End Function

#End Region

#Region "Eventos"

    Private Sub ComRegCotizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "InicializarForma")
    End Sub

    Private Sub DataGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductosSolicitados.CellEndEdit
        dgvProductosSolicitados.Refresh()
        CalcularTotal()
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvProductosSolicitados.DataError

    End Sub

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Utilerias.RunControlException(Me, "ActualizarPlazas", New Object() {e})
    End Sub

    Private Sub cmbPlaza_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectionChangeCommitted
        Dim Argumentos As New PreviewKeyDownEventArgs(Keys.F12)

        Utilerias.RunControlException(Me, "ActualizarSucursales", New Object() {Argumentos})

        RemoveHandler txtPlazaCodigo.TextChanged, AddressOf txtPlazaCodigo_TextChanged
        txtPlazaCodigo.Clear()

        If cmbPlaza.SelectedValue IsNot Nothing Then
            txtPlazaCodigo.Text = cmbPlaza.SelectedValue.ToString()
            txtSucursalCodigo.Focus()
        End If
        AddHandler txtPlazaCodigo.TextChanged, AddressOf txtPlazaCodigo_TextChanged
    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Utilerias.RunControlException(Me, "ActualizarSucursales", New Object() {e})
    End Sub

    'Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cmbMoneda.SelectedIndex = -1 Then
    '        txtTipoCambio.Clear()
    '    Else
    '        Dim Moneda As TipoMonedaClass = CType(cmbMoneda.SelectedItem, TipoMonedaClass)

    '        If Moneda.EsMonedaLocal Then
    '            txtTipoCambio.Text = 1I
    '        End If
    '    End If
    'End Sub

    Private Sub cmbMoneda_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        Utilerias.RunControlException(Me, "ActualizarMonedas", New Object() {e})
    End Sub

    Private Sub cmbProveedor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        Utilerias.RunControlException(Me, "ActualizarProveedores", New Object() {e})
    End Sub

    'Private Sub txtTipoCambio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not IsNumeric(txtTipoCambio.Text) Then
    '        txtTipoCambio.Text = 0D
    '    End If
    '    txtTipoCambio.Text = CDbl(txtTipoCambio.Text).ToString("C2")
    'End Sub

    Private Sub txtPlazaCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlazaCodigo.TextChanged
        Dim Argumentos As New PreviewKeyDownEventArgs(Keys.F12)

        cmbPlaza.SelectedIndex = -1
        cmbPlaza.Text = "Seleccione la Plaza"

        If IsNumeric(txtPlazaCodigo.Text) Then
            Dim Codigo As Integer = CType(txtPlazaCodigo.Text, Integer)

            If cmbPlaza.DataSource IsNot Nothing Then
                Dim Indice As Integer = CType(cmbPlaza.DataSource, PlazaCollectionClass).IndexOf(Codigo)

                If Indice > -1 Then
                    cmbPlaza.SelectedValue = Codigo
                End If
            End If
        End If
        Utilerias.RunControlException(Me, "ActualizarSucursales", New Object() {Argumentos})
    End Sub

    Private Sub txtSucursalCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSucursalCodigo.TextChanged
        cmbSucursal.SelectedIndex = -1
        cmbSucursal.Text = "Seleccione la Sucursal"

        If IsNumeric(txtSucursalCodigo.Text) Then
            Dim Codigo As Integer = CType(txtSucursalCodigo.Text, Integer)

            If cmbSucursal.DataSource IsNot Nothing Then
                Dim Indice As Integer = CType(cmbSucursal.DataSource, SucursalCollectionClass).IndexOf(Codigo)

                If Indice > -1 Then
                    cmbSucursal.SelectedValue = Codigo
                End If
            End If
        End If
    End Sub

    'Private Sub txtProveedorCodigo_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    cmbProveedor.SelectedIndex = -1
    '    cmbProveedor.Text = "Seleccione el Proveedor"

    '    If IsNumeric(txtProveedorCodigo.Text) Then
    '        Dim Codigo As Integer = CType(txtProveedorCodigo.Text, Integer)

    '        If cmbProveedor.DataSource IsNot Nothing Then
    '            Dim Indice As Integer = CType(cmbProveedor.DataSource, ProveedorCollectionClass).IndexOf(Codigo)

    '            If Indice > -1 Then
    '                cmbProveedor.SelectedValue = Codigo
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub cmbSucursal_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectionChangeCommitted
        dgvProductosSolicitados.DataSource = Nothing

        RemoveHandler txtSucursalCodigo.TextChanged, AddressOf txtSucursalCodigo_TextChanged
        txtSucursalCodigo.Clear()

        If cmbSucursal.SelectedValue IsNot Nothing Then
            txtSucursalCodigo.Text = cmbSucursal.SelectedValue.ToString()
        End If
        AddHandler txtSucursalCodigo.TextChanged, AddressOf txtSucursalCodigo_TextChanged

        If cmbSucursal.SelectedIndex > -1 Then
            dgvProductosSolicitados.DataSource = Controlador.ObtenerProductosSolicitados(CType(cmbSucursal.SelectedValue, Integer))
        End If
    End Sub

    'Private Sub cmbProveedor_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    RemoveHandler txtProveedorCodigo.TextChanged, AddressOf txtProveedorCodigo_TextChanged
    '    Me.txtProveedorCodigo.Clear()
    '    Me.txtDiasCredito.Clear()

    '    If cmbProveedor.SelectedValue IsNot Nothing Then
    '        Dim Proveedor As ProveedorClass = CType(cmbProveedor.SelectedItem, ProveedorClass)

    '        txtProveedorCodigo.Text = Proveedor.Codigo
    '        txtDiasCredito.Text = Proveedor.DiasCredito.ToString
    '        txtProveedorCodigo.Focus()
    '    End If
    '    AddHandler txtProveedorCodigo.TextChanged, AddressOf txtProveedorCodigo_TextChanged
    'End Sub

    Private Sub dgvProveedores_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvProveedores.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros

        If dgvProveedores.CurrentCell.ColumnIndex = clmProDiasCredito.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        End If
    End Sub

#End Region

End Class