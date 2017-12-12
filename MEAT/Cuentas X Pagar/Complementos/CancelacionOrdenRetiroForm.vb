Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses

Public Class CancelacionOrdenRetiroForm

    Private Usuarios As New CCS.UsuarioCollection
    Private MotivosCancel As New ClasesNegocio.MotivoCancelacionCollectionClass
    Private Autorizacion As New Integralab.ORM.CollectionClasses.AutorizaProcesosCollection
    Dim usuario_ As ECS.UsuarioEntity

    Public Property Usuario() As ECS.UsuarioEntity
        Get
            Return usuario_
        End Get
        Set(ByVal value As ECS.UsuarioEntity)
            usuario_ = value
        End Set
    End Property

    Private Motivo_ As ClasesNegocio.MotivoCancelacionClass

    Public Property Motivo() As ClasesNegocio.MotivoCancelacionClass
        Get
            Return Motivo_
        End Get
        Set(ByVal value As ClasesNegocio.MotivoCancelacionClass)
            Motivo_ = value
        End Set
    End Property

    Private Function Validar() As Boolean
        If IsNothing(Me.CmbUsuario.SelectedValue) Then
            MsgBox("Seleccione un usuario.", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
        If Me.txtContraseña.Text = "" Then
            MsgBox("Teclee una contraseña", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
        'If IsNothing(Me.CmbMotivoCan.SelectedValue) Then
        '    MsgBox("Seleccione un motivo de cancelación", MsgBoxStyle.Exclamation, "Aviso")
        '    Return False
        'End If
        Return True
    End Function

    Private Sub CancelacionOrdenRetiroForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'With Controlador.Sesion.MiEmpresa
        '    Me.lbltitulo.BackColorEnd = Color.FromArgb(0, .R, .G, .B)
        '    'Me.lblEmpresa.Text = .Empnom
        'End With
        MotivosCancel.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.CmbMotivoCan.DisplayMember = "Descripcion"
        Me.CmbMotivoCan.ValueMember = "Codigo"
        Me.CmbMotivoCan.DataSource = MotivosCancel
        Me.CmbMotivoCan.SelectedIndex = -1
        Me.CmbMotivoCan.Text = "Seleccione un Motivo de Cancelación ..."

        'Falta hacer un metodo para obtener todos los usuarios

        Me.CmbUsuario.DisplayMember = "Usrnom"
        Me.CmbUsuario.ValueMember = "Usrid"
        Me.CmbUsuario.DataSource = Usuarios
        Usuarios.GetMulti(Nothing)
        Me.CmbUsuario.SelectedIndex = -1
        Me.CmbUsuario.Text = "Seleccione un Usuario ..."
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Validar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub CmbUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbUsuario.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtContraseña.Focus()
        End If
    End Sub

    Private Sub CmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUsuario.SelectedIndexChanged
        'If CmbUsuario.SelectedIndex > -1 Then
        '    usuario_ = Me.CmbUsuario.SelectedItem

        '    Autorizacion.GetMulti(Integralab.ORM.HelperClasses.AutorizaProcesosFields.Usrndx = usuario_.Usrndx And Integralab.ORM.HelperClasses.AutorizaProcesosFields.CancelaFactura = True)
        '    If Autorizacion.Count <= 0 Then
        '        MsgBox("El usuario no está autorizado")
        '    End If
        'End If
    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    If Not Me.txtContraseña.Text = Autorizacion(0).Contraseña Then
        '        MsgBox("La contraseña es incorrecta...")
        '    Else
        '        Me.CmbMotivoCan.Focus()
        '    End If
        'End If
    End Sub

    Private Sub txtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub CmbMotivoCan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMotivoCan.SelectedIndexChanged
        If Not IsNothing(Me.CmbMotivoCan.SelectedItem) Then
            Motivo_ = CmbMotivoCan.SelectedItem
        End If
    End Sub
End Class