Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses

Partial Class FrmRegSolProducto
    Inherits MeatForm

#Region "Miembros"

    Private Solicitud As SolicitudProductoClass = Nothing

#End Region

#Region "Metodos Dinamicos"

    Public Sub ValidarDetalle(ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        Dim SolicitudDetalle As SolicitudProductoDetalleClass

        If Not dgvSolicitudDetalles.Rows(e.RowIndex).IsNewRow Then
            SolicitudDetalle = CType(dgvSolicitudDetalles.Rows(e.RowIndex).DataBoundItem, SolicitudProductoDetalleClass)
            e.Cancel = True
            SolicitudDetalle.Validar()
            e.Cancel = False
        End If
    End Sub

    Public Overrides Sub Modo(ByVal Edicion As Boolean)
        Me.dtpFechaSurtir.Enabled = Edicion
        Me.txtEntregarA.Enabled = Edicion
        Me.txtEntregarEn.Enabled = Edicion
        Me.txtFolio.Enabled = Edicion
        Me.txtObservaciones.Enabled = Edicion
        Me.txtSolicita.Enabled = Edicion
        Me.txtPara.Enabled = Edicion
        Me.cmbPlaza.Enabled = Edicion
        Me.cmbSucursal.Enabled = Edicion
        Me.txtPlazaCodigo.Enabled = Edicion
        Me.txtSucursalCodigo.Enabled = Edicion

        clmFechaSurtir.Visible = Not Edicion
        clmEstatus.Visible = Not Edicion

        Me.dgvSolicitudDetalles.ReadOnly = Not Edicion
        dgvSolicitudDetalles.AllowUserToAddRows = Edicion
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
            txtSucursalCodigo.Clear()
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione la Sucursal..."
        End If
    End Sub

    Public Overrides Sub InicializarForma()
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "001101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100001"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        tbrMenu.ToolBarButtonStatus = MtbEstados
        tbrMenu.sbCambiarEstadoBotones("Cancelar")

        Me.dgvSolicitudDetalles.AutoGenerateColumns = False

        cmbSucursal.DisplayMember = "Descripcion"
        cmbSucursal.ValueMember = "Codigo"

        Controlador.LlenarComboPlazas(cmbPlaza, CondicionEnum.ACTIVOS)
        Controlador.LlenarComboProductosGenerales(clmIdProducto, CondicionEnum.ACTIVOS)

        Modo(False)
        Limpiar()
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Overrides Function Cancelar() As Boolean
        Solicitud = Nothing

        clmEstatus.Visible = False
        clmFechaSurtir.Visible = False

        Return MyBase.Cancelar()
    End Function

    Public Overrides Function Limpiar() As Boolean
        Me.txtEntregarA.Clear()
        Me.txtEntregarEn.Clear()
        Me.txtFolio.Clear()
        Me.txtObservaciones.Clear()
        Me.txtSolicita.Clear()
        Me.txtPara.Clear()
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione la Plaza..."
        Me.txtPlazaCodigo.Clear()
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbSucursal.Text = ""
        Me.txtSucursalCodigo.Clear()
        Me.lblEstatus.Visible = False
        Me.dgvSolicitudDetalles.DataSource = Nothing
        txtPara.Focus()
        Return True
    End Function

    Public Overrides Function Nuevo() As Boolean
        Estado = FormState.Nuevo
        Modo(True)
        Solicitud = Nothing
        Limpiar()

        clmEstatus.Visible = False
        clmFechaSurtir.Visible = False

        dgvSolicitudDetalles.DataSource = New SolicitudProductoDetalleCollectionClass
        txtSolicita.Text = Controlador.Sesion.MiUsuario.Usrnomcom
        txtPara.Text = txtSolicita.Text
        txtPara.Focus()
        txtPara.SelectionStart = 0
        txtPara.SelectionLength = txtPara.Text.Length
        Return True
    End Function

    Public Overrides Function Editar() As Boolean
        If Not Solicitud.Estatus = SolicitudProductoClass.EstatusSolicitud.CANCELADA _
        AndAlso Not Solicitud.Estatus = SolicitudProductoClass.EstatusSolicitud.VIGENTE Then
            MessageBox.Show("La solicitud ha sido ordenada, no es posible modificarla", Controlador.Sesion.MiEmpresa.Empnom)
            Return False
        End If

        Modo(True)
        clmEstatus.Visible = False
        clmFechaSurtir.Visible = false

        Estado = FormState.Editar
        Return True
    End Function

    Public Overrides Function Buscar() As Boolean
        Dim ventana As New FrmBusquedaSolicitudProducto
        Dim Resultado As DialogResult = ventana.ShowDialog

        Cancelar()

        If Resultado = Windows.Forms.DialogResult.OK Then
            Solicitud = CType(ventana.dgvSolicitudes.SelectedRows(0).DataBoundItem, SolicitudProductoClass)

            Me.cmbPlaza.SelectedValue = Solicitud.Sucursal.Plaza.Codigo
            Me.txtPlazaCodigo.Text = Solicitud.Sucursal.Plaza.Codigo
            'Me.cmbSucursal.SelectedValue = Solicitud.Sucursal.Codigo
            Me.txtSucursalCodigo.Text = Solicitud.Sucursal.Codigo
            Me.cmbSucursal.Text = Solicitud.Sucursal.Descripcion
            Me.dtpFechaSolicitud.Value = Solicitud.FechaSolicitud
            Me.dtpFechaSurtir.Value = Solicitud.FechaSurtir
            Me.txtSolicita.Text = Solicitud.UsuarioAlta.NombreCompleto
            Me.txtPara.Text = Solicitud.SolicitadoPor
            Me.txtFolio.Text = Solicitud.FolioSolicitud
            Me.txtEntregarA.Text = Solicitud.EntregarA
            Me.txtEntregarEn.Text = Solicitud.EntregarEn
            Me.txtObservaciones.Text = Solicitud.Observaciones
            Me.lblEstatus.Visible = True
            Me.lblEstatus.Text = Solicitud.DescripcionEstatus

            Me.dgvSolicitudDetalles.DataSource = Solicitud.Detalle
            Me.dgvSolicitudDetalles.ReadOnly = True

            clmEstatus.Visible = True
            clmFechaSurtir.Visible = True
        ElseIf Resultado = Windows.Forms.DialogResult.Cancel Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim SolicitudDetalles As SolicitudProductoDetalleCollectionClass = Nothing
        Dim IdSucursal As Integer = 0
        Me.Validate()

        If cmbSucursal.SelectedIndex > -1 Then
            IdSucursal = CType(cmbSucursal.SelectedValue, Integer)
        End If

        If Solicitud Is Nothing OrElse Solicitud.Entidad.IsNew Then
            Solicitud = New SolicitudProductoClass(IdSucursal, txtPara.Text.Trim, txtEntregarA.Text.Trim, txtEntregarEn.Text.Trim, txtObservaciones.Text.Trim, dtpFechaSolicitud.Value, dtpFechaSurtir.Value)

            For Each Fila As DataGridViewRow In dgvSolicitudDetalles.Rows
                If Not Fila.IsNewRow Then
                    Solicitud.Detalle.Add(CType(Fila.DataBoundItem, SolicitudProductoDetalleClass))
                End If
            Next

            If MessageBox.Show("La solicitud sera generada, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Controlador.RegistrarSolicitudCompra(Solicitud, Trans)
                Trans.Commit()
                MessageBox.Show("La Solicitud se ha registrado con el folio: " & Solicitud.FolioSolicitud, Controlador.Sesion.MiEmpresa.Empnom)
            Else
                Return False
            End If
        Else
            If MessageBox.Show("La Solicitud sera modificada, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Me.Solicitud.Estatus = SolicitudProductoClass.EstatusSolicitud.CANCELADA Then
                    If MessageBox.Show("La solicitud ha sido cancelada, se tendria que activar para modificarla, ¿esta deacuerdo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Return False
                    Else
                        Solicitud.Estatus = SolicitudProductoClass.EstatusSolicitud.VIGENTE
                    End If
                End If
                Solicitud.IdSucursal = IdSucursal
                Solicitud.EntregarA = txtEntregarA.Text.Trim
                Solicitud.EntregarEn = txtEntregarEn.Text.Trim
                Solicitud.Observaciones = txtObservaciones.Text.Trim.Trim
                Solicitud.FechaSolicitud = dtpFechaSolicitud.Value
                Solicitud.FechaSurtir = dtpFechaSurtir.Value
                Controlador.RegistrarSolicitudCompra(Solicitud, Trans)
                Trans.Commit()
                MessageBox.Show("Se han modificado los datos satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
            Else
                Return False
            End If
        End If
        Cancelar()
        Return True
    End Function

    Public Overrides Function Borrar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        If Solicitud.Estatus = SolicitudProductoClass.EstatusSolicitud.CANCELADA Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 5)
        End If

        If MessageBox.Show("¿Deseas cancelar la Solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
            Return False
        End If

        Controlador.CancelarSolicitudCompra(Solicitud, Trans)
        Trans.Commit()
        MessageBox.Show("La Solicitud de productos ha sido cancelada", Controlador.Sesion.MiEmpresa.Empnom)
        Cancelar()
        Return True
    End Function

    Public Overrides Function Imprimir() As Boolean
        Controlador.ImpresionSolicitudCompra(Solicitud)
        Return True
    End Function

#End Region

#Region "Eventos"

    Private Sub ComRegSolProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "InicializarForma")
    End Sub

    Private Sub dgvSolicitudDetalles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSolicitudDetalles.KeyDown
        If Not dgvSolicitudDetalles.Rows(dgvSolicitudDetalles.CurrentRow.Index).IsNewRow Then
            If e.KeyCode = Keys.Delete Then
                If MessageBox.Show("¿Desea quitar el producto?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Me.dgvSolicitudDetalles.Rows.RemoveAt(dgvSolicitudDetalles.CurrentRow.Index)
                End If
            End If
        End If
    End Sub

    Private Sub dgvSolicitudDetalles_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvSolicitudDetalles.DataError

    End Sub

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Utilerias.RunControlException(Me, "ActualizarPlazas", New Object() {e})
    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Utilerias.RunControlException(Me, "ActualizarSucursales", New Object() {e})
    End Sub

    Private Sub dgvSolicitudDetalles_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvSolicitudDetalles.RowValidating
        Utilerias.RunControlException(Me, "ValidarDetalle", New Object() {e})
    End Sub

    Private Sub dgvSolicitudDetalles_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSolicitudDetalles.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If dgvSolicitudDetalles.CurrentCell.ColumnIndex = clmCantidad.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub dgvSolicitudDetalles_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudDetalles.CellLeave
        If e.ColumnIndex = clmCantidad.Index Then
            If Not IsNumeric(dgvSolicitudDetalles.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) Then
                dgvSolicitudDetalles.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0D
            End If
        End If
    End Sub

    Private Sub txtPlazaCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlazaCodigo.TextChanged
        Dim Argumentos As New PreviewKeyDownEventArgs(Keys.F12)

        cmbPlaza.SelectedIndex = -1
        cmbPlaza.Text = "Seleccione la Plaza..."

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
        cmbSucursal.Text = "Seleccione la Sucursal..."

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

    Private Sub cmbPlaza_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectionChangeCommitted
        Dim Argumentos As New PreviewKeyDownEventArgs(Keys.F12)

        Utilerias.RunControlException(Me, "ActualizarSucursales", New Object() {Argumentos})

        RemoveHandler txtPlazaCodigo.TextChanged, AddressOf txtPlazaCodigo_TextChanged
        txtPlazaCodigo.Clear()

        If cmbPlaza.SelectedValue IsNot Nothing Then
            txtPlazaCodigo.Text = cmbPlaza.SelectedValue
            txtSucursalCodigo.Focus()
        End If
        AddHandler txtPlazaCodigo.TextChanged, AddressOf txtPlazaCodigo_TextChanged
    End Sub

    Private Sub cmbSucursal_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectionChangeCommitted
        RemoveHandler txtSucursalCodigo.TextChanged, AddressOf txtSucursalCodigo_TextChanged
        txtSucursalCodigo.Clear()

        If cmbSucursal.SelectedValue IsNot Nothing Then
            txtSucursalCodigo.Text = cmbSucursal.SelectedValue
            txtEntregarA.Focus()
        End If
        AddHandler txtSucursalCodigo.TextChanged, AddressOf txtSucursalCodigo_TextChanged
    End Sub

#End Region
   
End Class