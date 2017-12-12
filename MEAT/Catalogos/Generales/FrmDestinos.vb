Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class FrmDestinos
    Dim Destino As CN.PuntosEntregaClass
    Dim Destinos As CN.PuntosEntregaCollectionClass
    Dim Estados As CN.EstadoCollectionClass
    Dim Ciudades As CN.CiudadCollectionClass
    Dim Poblaciones As CN.PoblacionCollectionClass
    Dim Clientes As CN.ClientesIntroductoresColeccion
    Dim CiudadesC As CN.CiudadCollectionClass
    Dim PoblacionesC As CN.PoblacionCollectionClass

    Private Sub FrmDestinos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = "000100011"
            MtbEstados.StateCancelar = "000100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "000100011"
            MtbEstados.StateBorrar = "000100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            mtb.Buttons(1).Visible = False

            Estados = New CN.EstadoCollectionClass
            Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            CmbEstados.ValueMember = "Codigo"
            CmbEstados.DisplayMember = "Descripcion"
            CmbEstados.DataSource = Estados

            Me.CmbEstados.DisplayMember = "Descripcion"
            Me.CmbEstados.ValueMember = "Codigo"
            Me.CmbEstados.SelectedIndex = -1
            Estados = New CN.EstadoCollectionClass
            Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            CmbEstados.DataSource = Estados
            Me.CmbEstados.SelectedIndex = -1



            Clientes = New CN.ClientesIntroductoresColeccion
            Clientes.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.cmbClientes.ValueMember = "Codigo"
            Me.cmbClientes.DisplayMember = "Nombre"
            Me.cmbClientes.DataSource = Clientes
            Limpiar()
            DesHabilitar()

            Destinos = New CN.PuntosEntregaCollectionClass
            Destinos.Obtener()
            Me.DgvDestinos.AutoGenerateColumns = False
            Me.DgvDestinos.DataSource = Destinos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"

    Private Sub CmbEstados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEstados.KeyDown
        If e.KeyCode = Keys.F12 Then
            Estados = New CN.EstadoCollectionClass
            Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If

    End Sub

    Private Sub CmbEstados_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbEstados.SelectedIndexChanged
        Try
            If Me.CmbEstados.SelectedIndex > -1 And Me.CmbEstados.SelectedItem IsNot Nothing Then
                Me.CmbCiudad.DisplayMember = "Descripcion"
                Me.CmbCiudad.ValueMember = "Codigo"
                Me.CiudadesC = New CN.CiudadCollectionClass
                Me.CiudadesC.Obtener(CInt(CmbEstados.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CmbCiudad.SelectedIndex = -1
                Me.CmbCiudad.DataSource = CiudadesC
            Else
                Me.CmbCiudad.DataSource = Nothing
                Me.CmbCiudad.Text = "Seleccione una ciudad.."
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbCiudad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCiudad.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.CmbEstados_SelectedIndexChanged(sender, New EventArgs)
        End If
    End Sub


    Private Sub CmbCiudad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCiudad.SelectedIndexChanged
        Try
            If Me.CmbCiudad.SelectedIndex > -1 And Me.CmbCiudad.SelectedItem IsNot Nothing Then
                Me.CmbPoblacion.DisplayMember = "Descripcion"
                Me.CmbPoblacion.ValueMember = "Codigo"
                PoblacionesC = New CN.PoblacionCollectionClass
                PoblacionesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, CInt(CmbEstados.SelectedValue), CInt(CmbCiudad.SelectedValue))
                Me.CmbPoblacion.SelectedIndex = -1
                Me.CmbPoblacion.DataSource = PoblacionesC
            Else
                Me.CmbPoblacion.DataSource = Nothing
                Me.CmbPoblacion.Text = "Seleccione una población"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.CmbEstados.SelectedIndex = -1
        Me.CmbCiudad.SelectedIndex = -1
        Me.CmbPoblacion.SelectedIndex = -1
        'Me.DgvDestinos.DataSource = Nothing
        Me.txtColonia.Text = ""
        Me.txtCP.Text = ""
        Me.txtDomicilio.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtDescripcion.Text = ""
        Me.cmbClientes.SelectedIndex = -1
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub Habilitar()
        Me.CmbEstados.Enabled = True
        Me.CmbCiudad.Enabled = True
        Me.CmbPoblacion.Enabled = True
        Me.cmbClientes.Enabled = True
        Me.txtColonia.Enabled = True
        Me.txtCP.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtDomicilio.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub DesHabilitar()
        Me.CmbEstados.Enabled = False
        Me.CmbCiudad.Enabled = False
        Me.CmbPoblacion.Enabled = False
        Me.cmbClientes.Enabled = False
        Me.txtColonia.Enabled = False
        Me.txtCP.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtDomicilio.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub PonerDatos()
        Try
            Me.CmbEstados.SelectedValue = Destino.Estado.Codigo
            Me.CmbCiudad.SelectedValue = Destino.Ciudad.Codigo
            Me.CmbPoblacion.SelectedValue = Destino.Poblacion.Codigo
            Me.txtDescripcion.Text = Destino.Descripcion
            Me.txtDomicilio.Text = Destino.Direccion
            Me.txtTelefono.Text = Destino.Telefono
            Me.txtCP.Text = Destino.CodgoPostal
            Me.txtColonia.Text = Destino.Colonia
            Me.cmbClientes.SelectedValue = Destino.Cliente.Codigo
            Me.lblEstatus.Text = Destino.Estatus.ToString
            Me.lblEstatus.Visible = True
            Me.txtCodigo.Text = Destino.Codigo
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Guardar() As Boolean
        Try
            Me.Destino.IdEstado = Me.CmbEstados.SelectedValue
            Me.Destino.IdCiudad = Me.CmbCiudad.SelectedValue
            Me.Destino.IdPoblacion = Me.CmbPoblacion.SelectedValue
            Me.Destino.Descripcion = Me.txtDescripcion.Text
            Me.Destino.Direccion = Me.txtDomicilio.Text
            Me.Destino.Telefono = Me.txtTelefono.Text
            Me.Destino.CodgoPostal = Me.txtCP.Text
            Me.Destino.Colonia = Me.txtColonia.Text
            Me.Destino.IdCliente = Me.cmbClientes.SelectedValue
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            If Me.CmbEstados.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione un Estado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbEstados.SelectedIndex = 0
                Me.CmbEstados.Focus()
                Return False
            End If

            If Me.CmbCiudad.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione una ciudad", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbCiudad.SelectedIndex = 0
                Me.CmbCiudad.Focus()
                Return False
            End If

            If Me.CmbPoblacion.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione una población", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbPoblacion.SelectedIndex = 0
                Me.CmbPoblacion.Focus()
                Return False
            End If

            If Me.cmbClientes.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione un cliente", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbClientes.SelectedIndex = 0
                Me.cmbClientes.Focus()
                Return False
            End If

            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Ingresa una Descripción", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            End If

            If Me.txtDomicilio.Text = "" Then
                MessageBox.Show("Ingrese el Domicilio", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDomicilio.Focus()
                Return False
            End If

            If Me.txtColonia.Text = "" Then
                MessageBox.Show("Ingrese el Nombre de la Colonia", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtColonia.Focus()
                Return False
            End If

            'If CC.MgralcatPuntosEntregaCollection.GetMultiAsDataTable(HC.MgralcatPuntosEntregaFields.Descripcion = txtDescripcion.Text.Trim, 0, Nothing).Rows.Count > 0 Then
            '    MessageBox.Show("Se ha encontrado un destino con esa descripcion, Por favor especifique una descripcion diferente", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    txtDescripcion.Focus()
            '    Return False
            'End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region

#Region "ToolBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Destino.Estatus = ClasesNegocio.EstatusChar.CANCELADO Then
                MessageBox.Show("No se puede cancelar el destino, ya se encuentra cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el Destino?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Destino.Estatus = ClasesNegocio.EstatusChar.CANCELADO
            If Destino.Guardar Then
                MessageBox.Show("El destino ha sido Cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DesHabilitar()
                Limpiar()
                Destinos = New CN.PuntosEntregaCollectionClass
                Destinos.Obtener()
                Me.DgvDestinos.AutoGenerateColumns = False
                Me.DgvDestinos.DataSource = Destinos
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        DesHabilitar()
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Me.Destino.Estatus = ClasesNegocio.EstatusChar.CANCELADO Then
            If MessageBox.Show("El Destino se encuentra cancelado, no se puede editar, ¿Desea activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Destino.Estatus = ClasesNegocio.EstatusChar.VIGENTE
                Habilitar()
            Else
                Cancelar = True
            End If
        Else
            Habilitar()
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If Not Guardar() Then
                Cancelar = True
                Exit Sub
            End If
            If Not Destino.Guardar Then
                MessageBox.Show("No se logro guardar el Destino", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
                Exit Sub
            End If
            MessageBox.Show("El destinos ha sido guardado con el codigo: " & Destino.Codigo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesHabilitar()
            Limpiar()

            Destinos = New CN.PuntosEntregaCollectionClass
            Destinos.Obtener()
            Me.DgvDestinos.AutoGenerateColumns = False
            Me.DgvDestinos.DataSource = Destinos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        CmbEstados.Focus()
        Destino = New CN.PuntosEntregaClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "Grid"
    Private Sub DgvDestinos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvDestinos.DataError

    End Sub

    Private Sub DgvDestinos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvDestinos.DoubleClick
        Try
            If Me.DgvDestinos.SelectedRows.Count > 0 Then
                Destino = New CN.PuntosEntregaClass
                If Not Destino.Obtener(DirectCast(Me.DgvDestinos.SelectedRows(0).DataBoundItem, CN.PuntosEntregaClass).Codigo) Then
                    MessageBox.Show("No existe el Destino", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    PonerDatos()
                    Me.mtb.sbCambiarEstadoBotones("Buscar")
                    DesHabilitar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Filtros"
    Private Sub txtFiltroDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroDesc.KeyPress
        Try
            If Me.txtFiltroDesc.Text.Length > 4 Or e.KeyChar = Chr(13) Then
                Destinos = New CN.PuntosEntregaCollectionClass
                If IsNumeric(Me.txtFiltroCod.Text) Then
                    Destinos.Obtener(Me.txtFiltroCod.Text, Me.txtFiltroDesc.Text)
                Else
                    Destinos.Obtener(-1, Me.txtFiltroDesc.Text)
                End If
                Me.DgvDestinos.AutoGenerateColumns = False
                Me.DgvDestinos.DataSource = Destinos
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFiltroCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroCod.KeyPress
        Try
            If (Not IsNumeric(Me.txtFiltroCod.Text) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Destinos = New CN.PuntosEntregaCollectionClass
                If IsNumeric(Me.txtFiltroCod.Text) Then
                    Destinos.Obtener(Me.txtFiltroCod.Text, Me.txtFiltroDesc.Text)
                Else
                    Destinos.Obtener(-1, Me.txtFiltroDesc.Text)
                End If
                Me.DgvDestinos.AutoGenerateColumns = False
                Me.DgvDestinos.DataSource = Destinos
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Key Press"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDomicilio.Focus()
        End If
    End Sub

    Private Sub txtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtColonia.Focus()
        End If
    End Sub

    Private Sub txtColonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtTelefono.Focus()
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtCP.Focus()
        End If
    End Sub

    Private Sub txtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.cmbClientes.Focus()
        End If
    End Sub
#End Region

    Private Sub CmbPoblacion_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbPoblacion.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.CmbCiudad_SelectedIndexChanged(sender, New EventArgs)
        End If
    End Sub

    Private Sub cmbClientes_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbClientes.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Clientes = New CN.ClientesIntroductoresColeccion
            Clientes.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
        End If
    End Sub

    
End Class