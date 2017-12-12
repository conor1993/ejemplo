Imports System.Data
Imports System.Data.SqlClient
Imports ClasesNegocio

Public Class ComRecepcionOrdenServicio
    Private Orden As ClasesNegocio.OrdenServicioClass
    Private nuevo As Boolean = False
    Private FolioOrden As String = ""
    Dim UltimaTeclaPlaza As DateTime
    Dim UltimaTeclaSucursal As DateTime

#Region "Load"
    Private Sub ComRecepcionOrdenServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.ToolBar.ToolBarButtonStatus = tbEstados
            Me.ToolBar.sbCambiarEstadoBotones("Cancelar")

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            cmbPlaza.DisplayMember = "Descripcion"
            cmbPlaza.ValueMember = "Codigo"
            cmbPlaza.DataSource = PlazaC
            Limpiar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "MToolBar"

    Private Sub ToolBar_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles ToolBar.ClickBorrar
        Try
            Orden.UsuarioCancelaRecepOrdenId = Controlador.Sesion.Usrndx
            Orden.Recibida = CByte(EstatusRecepcionEnum.CANCELADA)
            Orden.Guardar()
            MessageBox.Show("Se ha Cancelado la recepción de la Orden de Servicio en el sistema", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Habilitar(False)
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ToolBar_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles ToolBar.ClickBuscar
        Try
            Dim ventana As New BusquedaOrdenesServicio
            'ventana.cualquier control de esa forma
            'incluir un control oculto que le asigne el valor
            ventana.DefaultRecibida(True) = EstatusOrdenRecibida.RECIBIDA
            ventana.DefaultAutorizada(True) = EstatusAutorizada.SI
            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Orden = New ClasesNegocio.OrdenServicioClass
                FolioOrden = ventana.DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
                'cuando manejo la coleccion en el grid
                'Orden = DirectCast(ventana.DataGridView1.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenServicioClass)
                Orden.Obtener(ventana.DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
                cmbPlaza.SelectedValue = Orden.Plaza.Codigo
                cmbSucursal.SelectedValue = Orden.SucursalId
                txtProveedor.Text = Orden.Proveedor
                txtMoneda.Text = Orden.Moneda
                txtTipoCambio.Text = Orden.TipoCambio.ToString("C2")

                Me.DtpFecha.Value = Orden.FechaAlta
                Me.lblEstatus.Visible = True
                Me.lblEstatus.Text = Orden.Estatus.ToString()

                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.DataSource = Orden.Detalle
                Me.txtFolioOrden.Text = Orden.Folio
                Me.txtObservaciones.Text = Orden.Observaciones
                Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
                Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
                Me.txtIVA.Text = Orden.IVA.ToString("C2")
                Me.txtTotal.Text = Orden.Total.ToString("C2")

            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolBar_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles ToolBar.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If
            If Orden.Recibida = EstatusRecepcionEnum.RECEPCIONADA Then
                MessageBox.Show("No se puede Recepcionar la Orden de Servicios por que su estado es Recepcionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cancelar = True
                Exit Sub
            End If
            Orden.FolioFactura = Me.txtNoFactura.Text
            Orden.FechaRecepcion = Now
            Orden.UsuarioRecepOrdenId = Controlador.Sesion.Usrndx
            Orden.Recibida = CByte(EstatusRecepcionEnum.RECEPCIONADA)
            Orden.Guardar()
            MessageBox.Show("Se ha registrado la recepción de la Orden de Servicio en el sistema", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Habilitar(False)
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolBar_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles ToolBar.ClickCancelar
        Limpiar()
        Habilitar(False)
    End Sub

    Private Sub ToolBar_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles ToolBar.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub ToolBar_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles ToolBar.ClickNuevo
        Habilitar(True)
        nuevo = True
    End Sub

    Private Sub ToolBar_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles ToolBar.ClickSalir
        Me.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Habilitar(ByVal opcion As Boolean)
        Me.btBuscarOrdenes.Enabled = opcion
        Me.txtNoFactura.Enabled = opcion
        'Me.cmbPlaza.Enabled = opcion
        'Me.cmbSucursal.Enabled = opcion
        'Me.dgvDetalleOrdenServicio.Enabled = opcion
    End Sub

    Private Sub Limpiar()
        'PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Me.SucursalC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione una Plaza..."
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbSucursal.Text = "Seleccione una Sucursal..."

        Me.dgvDetalle.DataSource = Nothing
        Me.txtFolioOrden.Text = ""
        Me.txtTipoCambio.Text = ""
        Me.txtSubTotal.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtIVA.Text = ""
        Me.txtTotal.Text = ""
        Me.lblEstatus.Visible = False
        Me.txtProveedor.Text = ""
        Me.txtMoneda.Text = ""
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.txtNoFactura.Text = "" Then
                MessageBox.Show("Deve de especificar el numero de Factura para Guardar", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Me.txtNoFactura.Focus()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

#End Region

    Private Sub btBuscarOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscarOrdenes.Click
        Try
            Dim ventana As New BusquedaOrdenesServicio
            ventana.DefaultAutorizada(True) = EstatusAutorizada.SI
            ventana.DefaultRecibida(True) = EstatusOrdenRecibida.NO_RECIBIDA

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Limpiar()
                Orden = New ClasesNegocio.OrdenServicioClass

                'cuando manejo la coleccion en el grid
                'Orden = DirectCast(ventana.DataGridView1.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenServicioClass)
                Orden.Obtener(ventana.DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
                cmbPlaza.SelectedValue = Orden.Plaza.Codigo
                cmbSucursal.SelectedValue = Orden.SucursalId
                txtProveedor.Text = Orden.Proveedor
                txtMoneda.Text = Orden.Moneda
                txtTipoCambio.Text = Orden.TipoCambio.ToString("C2")
                Me.DtpFecha.Value = Orden.FechaAlta
                Me.lblEstatus.Visible = True
                Me.lblEstatus.Text = Orden.Estatus.ToString() 'ventana.DataGridView1.SelectedRows(0).Cells("Estatus").Value.ToString()

                Me.dgvDetalle.AutoGenerateColumns = False
                Me.dgvDetalle.DataSource = Orden.Detalle

                Me.txtFolioOrden.Text = Orden.Folio
                Me.txtObservaciones.Text = Orden.Observaciones
                Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
                Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
                Me.txtIVA.Text = Orden.IVA.ToString("C2")
                Me.txtTotal.Text = Orden.Total.ToString("C2")
                'CalcularTotal()
                'CalcularSuma()
                'Me.BtnBuscar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
                PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbPlaza.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > -1 Then
            'cmbSucursal.DataSource = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales

            Me.SucursalC.Obtener(cmbPlaza.SelectedValue, ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbSucursal.DataSource = SucursalC
            cmbSucursal.DisplayMember = "Descripcion"
            cmbSucursal.ValueMember = "Codigo"
            cmbSucursal.SelectedIndex = -1

            cmbSucursal.Text = "Seleccione una Sucursal..."
        Else
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvDetalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalle.DataError

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
                Me.cmbSucursal.SelectedIndex = -1
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
            Me.SucursalC.Obtener(Me.cmbSucursal.Text, ClasesNegocio.CondicionEnum.ACTIVOS, CInt(Me.cmbPlaza.SelectedValue))
            Me.cmbSucursal.DataSource = SucursalC
        End If
    End Sub

End Class