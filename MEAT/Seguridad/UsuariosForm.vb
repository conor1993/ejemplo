Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports ClasesNegocio

Public Class UsuariosForm

    Private _inicioDeSeguridad As Boolean = False

    Sub New(ByVal usuarioGuest As ECS.UsuarioEntity)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        For Each grupousuario As ECS.GruposEntity In usuarioGuest.MisGrupos
            If grupousuario.Gposeg Then
                _inicioDeSeguridad = True
                Exit Sub
            End If
        Next
        SeguridadGrupoCheckBox.Enabled = False
        ReqAutGrupoCheckBox.Enabled = False
    End Sub

    Sub New(ByVal InicioDeSeguridad As Boolean)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If InicioDeSeguridad Then _inicioDeSeguridad = True
    End Sub

    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SeguridadGrupoCheckBox.Enabled = False
        ReqAutGrupoCheckBox.Enabled = False

    End Sub

#Region " Administracion de Usuarios"
    Private Encriptador As New EncriptadorClass

    Private usuario As New ECS.UsuarioEntity

    Private Sub sbLectura()
        Panel.Enabled = False
        UsuariosListBox.Enabled = True
    End Sub

    Private Sub sbLimpiar()
        IdTextBox.Clear()
        NombreTextBox.Clear()
        ApellidoPTextBox.Clear()
        ApellidoMTextBox.Clear()
        NacimientoDateTimePicker.Value = Now
        RfcMaskedTextBox.Clear()
        DomicilioTextBox.Clear()
        ColoniaTextBox.Clear()
        CPMaskedTextBox.Clear()
        CdTextBox.Clear()
        EdoTextBox.Clear()
        Tel1MaskedTextBox.Clear()
        Tel2MaskedTextBox.Clear()
    End Sub

    Private Sub sbEscritura()
        Panel.Enabled = True
        UsuariosListBox.Enabled = False
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Not usuario.Delete() Then
                MsgBox("El usuario no pudo ser eliminado.")
            End If
            sbLimpiar()
            sbLectura()
            Usuarios.GetMulti(Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        sbLimpiar()
        sbLectura()
        UsuariosListBox.SelectedIndex = -1
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        sbEscritura()
        NombreTextBox.Focus()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            With usuario
                .Usrid = IdTextBox.Text
                .Usrnom = NombreTextBox.Text
                .Usrapp = ApellidoPTextBox.Text
                .Usrapm = ApellidoMTextBox.Text
                .Usrnac = NacimientoDateTimePicker.Value
                .Usrrfc = RfcMaskedTextBox.Text
                .Usrgradom = DomicilioTextBox.Text
                .Usrgracol = ColoniaTextBox.Text
                .Usrgracp = CPMaskedTextBox.Text
                .Usrgracd = CdTextBox.Text
                .Usrgraedo = EdoTextBox.Text
                .Usrgrate1 = Tel1MaskedTextBox.Text
                .Usrgrate2 = Tel2MaskedTextBox.Text
                If usuario.IsNew Then
                    Dim frmPassword As New PasswordForm
                    If frmPassword.ShowDialog = Windows.Forms.DialogResult.OK Then
                        .Usrpas = frmPassword.Password
                        If .Save Then
                            Usuarios.GetMulti(Nothing)
                        End If
                    Else
                        MsgBox("La creación del usuario fue cancelada.")
                    End If
                Else
                    If .Save Then
                        Usuarios.GetMulti(Nothing)
                    End If
                End If
                sbLimpiar()
                sbLectura()
                UsuariosListBox.SelectedIndex = -1
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sbLimpiar()
            sbLectura()
            UsuariosListBox.SelectedIndex = -1
        Finally
            IdTextBox.Enabled = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        sbLimpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        sbEscritura()
        sbLimpiar()
        usuario = New ECS.UsuarioEntity
        IdTextBox.Focus()
    End Sub

#End Region

#Region " Administracion de Grupos "
    Private grupo As New ECS.GruposEntity

    Private Sub sbGrupoLimpiar()
        CodigoGrupoTextBox.Clear()
        NombreGrupoTextBox.Clear()
        DescripcionGrupoTextBox.Clear()
        SeguridadGrupoCheckBox.Checked = False
        ReqAutGrupoCheckBox.Checked = False
    End Sub

    Private Sub sbGrupoLectura()
        PanelGrupo.Enabled = False
        GruposListBox.Enabled = True
    End Sub

    Private Sub sbGrupoEscritura()
        PanelGrupo.Enabled = True
        GruposListBox.Enabled = False
    End Sub

    Private Sub Grupomtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Grupomtb.ClickBorrar
        grupo.Delete()
        sbGrupoLimpiar()
    End Sub

    Private Sub Grupomtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Grupomtb.ClickCancelar
        sbGrupoLimpiar()
        sbGrupoLectura()
    End Sub

    Private Sub Grupomtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Grupomtb.ClickEditar
        sbGrupoEscritura()
    End Sub

    Private Sub Grupomtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Grupomtb.ClickGuardar
        Try
            grupo.Gpoid = CodigoGrupoTextBox.Text
            grupo.Gponom = NombreGrupoTextBox.Text
            grupo.Gpodes = DescripcionGrupoTextBox.Text
            grupo.Gporeqaut = ReqAutGrupoCheckBox.Checked
            grupo.Gposeg = SeguridadGrupoCheckBox.Checked
            grupo.Save()
            Grupos.GetMulti(Nothing)
            sbGrupoLimpiar()
            sbGrupoLectura()
            GruposListBox.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grupomtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Grupomtb.ClickLimpiar
        sbGrupoLimpiar()
    End Sub

    Private Sub Grupomtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Grupomtb.ClickNuevo
        sbGrupoEscritura()
        sbGrupoLimpiar()
        grupo = New ECS.GruposEntity
        CodigoGrupoTextBox.Focus()
    End Sub

    Private Sub GruposListBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GruposListBox.Click
        If GruposListBox.SelectedIndex > -1 Then
            grupo = New ECS.GruposEntity
            grupo = DirectCast(GruposListBox.SelectedItem, ECS.GruposEntity)
            CodigoGrupoTextBox.Text = grupo.Gpoid
            NombreGrupoTextBox.Text = grupo.Gponom
            DescripcionGrupoTextBox.Text = grupo.Gpodes
            ReqAutGrupoCheckBox.Checked = grupo.Gporeqaut
            SeguridadGrupoCheckBox.Checked = grupo.Gposeg
            Grupomtb.sbCambiarEstadoBotones("Buscar")
        End If
    End Sub
#End Region

#Region " Administracion de Miembros "
    Private Sub sbObtenerGruposDeUsuario()
        Dim Filtro As New OC.PredicateExpression
        Filtro.Add(New OC.FieldCompareSetPredicate( _
        HCS.GruposFields.Gpondx, HCS.DetallegruposFields.Gpondx, SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.In, _
        New OC.FieldCompareValuePredicate(HCS.DetallegruposFields.Usrndx, SD.LLBLGen.Pro.ORMSupportClasses.ComparisonOperator.Equal, _
        usuario.Usrndx)))
        GruposAsociados.GetMulti(Filtro)

        Filtro = New OC.PredicateExpression
        Filtro.Add(New OC.FieldCompareSetPredicate( _
        HCS.GruposFields.Gpondx, _
        HCS.DetallegruposFields.Gpondx, _
         SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.NotEqualAll, _
        New OC.FieldCompareValuePredicate( _
        HCS.DetallegruposFields.Usrndx, _
        SD.LLBLGen.Pro.ORMSupportClasses.ComparisonOperator.Equal, _
        usuario.Usrndx)))
        GruposDisponibles.GetMulti(Filtro)
    End Sub

    Private Function fnVerificacionDePrivilegios(ByVal miGrupo As ECS.GruposEntity) As Boolean
        If _inicioDeSeguridad Or Not miGrupo.Gporeqaut Then
            Return True
        Else
            Dim frmValidacion As New ValidateForm
            If frmValidacion.ShowDialog = Windows.Forms.DialogResult.OK Then
                For Each grupo As ECS.GruposEntity In frmValidacion.Grupos
                    If grupo.Gposeg Then
                        Return True
                    End If
                Next
            End If
            Return False
        End If
    End Function

    Private Sub AsociarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsociarButton.Click
        'Dim GrupoAAsociar As EC.GruposEntity = GruposDisponiblesListBox.SelectedItem
        Dim GrupoAAsociar As ECS.GruposEntity = grupo
        If fnVerificacionDePrivilegios(GrupoAAsociar) Then
            Dim detallegrupo As New ECS.DetallegruposEntity
            'detallegrupo.Gpondx = GruposDisponiblesListBox.SelectedValue
            detallegrupo.Gpondx = grupo.Gpondx
            'detallegrupo.Usrndx = UsuariosListBox.SelectedValue
            detallegrupo.Usrndx = usuario.Usrndx
            detallegrupo.Save()
            sbObtenerGruposDeUsuario()
        Else
            MsgBox("Se requiere pertenecer a un grupo de seguridad o " & vbCrLf & "autentificarse para poder asociar este grupo.")
        End If
    End Sub

    Private Sub DesasociarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesasociarButton.Click
        'Dim GrupoADesasociar As EC.GruposEntity = GruposAsociadosListBox.SelectedItem
        Dim GrupoADesasociar As ECS.GruposEntity = grupo
        If fnVerificacionDePrivilegios(GrupoADesasociar) Then
            Dim detallegrupo As New ECS.DetallegruposEntity
            'detallegrupo.FetchUsingPK(UsuariosListBox.SelectedValue, GruposAsociadosListBox.SelectedValue)
            detallegrupo.FetchUsingPK(usuario.Usrndx, grupo.Gpondx)
            detallegrupo.Delete()
            sbObtenerGruposDeUsuario()
        Else
            MsgBox("Se requiere pertenecer a un grupo de seguridad o " & vbCrLf & "autentificarse para poder desasociar este grupo.")
        End If
    End Sub

    Private Sub GruposDisponiblesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GruposDisponiblesListBox.SelectedIndexChanged
        If GruposDisponiblesListBox.SelectedIndex > -1 Then
            grupo = DirectCast(GruposDisponiblesListBox.SelectedItem, ECS.GruposEntity)
            AsociarButton.Enabled = True
        Else
            AsociarButton.Enabled = False
        End If
    End Sub

    Private Sub GruposAsociadosListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GruposAsociadosListBox.SelectedIndexChanged
        If GruposAsociadosListBox.SelectedIndex > -1 Then
            grupo = DirectCast(GruposAsociadosListBox.SelectedItem, ECS.GruposEntity)
            DesasociarButton.Enabled = True
        Else
            DesasociarButton.Enabled = False
        End If
    End Sub
#End Region

#Region " General "
    Private Sub sbInicializarToolBar()
        Dim mtbStructure As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        mtbStructure.StateBuscar = "010101101"
        mtbStructure.StateLimpiar = ""
        mtbStructure.StateCancelar = "000100001"
        mtbStructure.StateNuevo = "011010000"
        mtbStructure.StateGuardar = "000100001"
        mtbStructure.StateBorrar = "000100001"
        mtbStructure.StateEditar = "011010000"
        mtbStructure.StateSalir = "000000000"
        mtb.ToolBarButtonStatus = mtbStructure
        mtb.sbCambiarEstadoBotones("Cancelar")
        Grupomtb.ToolBarButtonStatus = mtbStructure
        Grupomtb.sbCambiarEstadoBotones("Cancelar")
    End Sub

    Private Sub UsuariosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sbInicializarToolBar()
        sbLectura()
        sbGrupoLectura()
        Usuarios.GetMulti(Nothing)
        UsuariosListBox.SelectedIndex = -1
    End Sub

    Private Sub RestablecerContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestablecerContraseñaToolStripMenuItem.Click
        If UsuariosListBox.SelectedIndex > -1 Then
            Dim frmPassword As New PasswordForm
            If frmPassword.ShowDialog = Windows.Forms.DialogResult.OK Then
                usuario.Usrpas = frmPassword.Password
                If usuario.Save Then
                    MsgBox("Contraseña Reestablecida.")
                    Usuarios.GetMulti(Nothing)
                End If
            End If
            UsuariosListBox.SelectedIndex = -1
            usuario = New ECS.UsuarioEntity
            sbLimpiar()
        Else
            MsgBox("Seleccione un usuario.")
        End If
    End Sub

    Private Sub tabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabControl.SelectedIndexChanged
        Select Case tabControl.SelectedIndex
            Case 0
                UsuariosListBox.Enabled = True
            Case 1
                UsuariosListBox.Enabled = False
                Grupos.GetMulti(Nothing)
                GruposListBox.SelectedIndex = -1
                GruposAsociados.Clear()
                GruposDisponibles.Clear()
                UsuariosListBox.SelectedIndex = -1
            Case 2
                UsuariosListBox.Enabled = True
                AsociarButton.Enabled = False
                DesasociarButton.Enabled = False
                GruposAsociadosListBox.SelectedIndex = -1
                GruposDisponiblesListBox.SelectedIndex = -1
        End Select
    End Sub

    Private Sub UsuariosListBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsuariosListBox.Click
        Select Case tabControl.SelectedIndex
            Case 0
                If UsuariosListBox.SelectedIndex > -1 Then
                    usuario = New ECS.UsuarioEntity
                    usuario = DirectCast(UsuariosListBox.SelectedItem, ECS.UsuarioEntity)
                    With usuario
                        IdTextBox.Text = .Usrid
                        NombreTextBox.Text = .Usrnom
                        ApellidoPTextBox.Text = .Usrapp
                        ApellidoMTextBox.Text = .Usrapm
                        NacimientoDateTimePicker.Value = .Usrnac
                        RfcMaskedTextBox.Text = .Usrrfc
                        DomicilioTextBox.Text = .Usrgradom
                        ColoniaTextBox.Text = .Usrgracol
                        CPMaskedTextBox.Text = .Usrgracp
                        CdTextBox.Text = .Usrgracd
                        EdoTextBox.Text = .Usrgraedo
                        Tel1MaskedTextBox.Text = .Usrgrate1
                        Tel2MaskedTextBox.Text = .Usrgrate2
                    End With
                    mtb.sbCambiarEstadoBotones("Buscar")
                End If
            Case 2
                If UsuariosListBox.SelectedIndex > -1 Then
                    usuario = New ECS.UsuarioEntity
                    usuario = DirectCast(UsuariosListBox.SelectedItem, ECS.UsuarioEntity)
                    sbObtenerGruposDeUsuario()
                    GruposDisponiblesListBox.SelectedIndex = -1
                    GruposAsociadosListBox.SelectedIndex = -1
                End If
        End Select
    End Sub
#End Region

End Class