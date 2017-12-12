Imports System.IO.File
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports CN = ClasesNegocio

Public Class ModCatAutorizacion
    Private _Usuario As New EC.AutorizaProcesosEntity

    Public ReadOnly Property Permisos() As EC.AutorizaProcesosEntity
        Get
            Return _Usuario
        End Get
    End Property

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim usuario As New CCS.UsuarioCollection

            usuario.GetMulti(HCS.UsuarioFields.Usrid = Me.txtUsuario.Text)

            If usuario.Count = 0 Then
                MsgBox("No existe el usuario o la contraseña no es válida", MsgBoxStyle.Exclamation, "Usuario o Contraseña Inválida")
                Me.txtUsuario.Clear()
                Me.txtContraseña.Clear()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Dim encrip As New ClasesNegocio.EncriptadorClass

                If usuario(0).Usrpas = encrip.Encriptar(Me.txtContraseña.Text) Then
                    Dim permiso As New CC.AutorizaProcesosCollection

                    permiso.GetMulti(HC.AutorizaProcesosFields.Usrndx = usuario(0).Usrndx)

                    If permiso.Count = 0 Then
                        MsgBox("No existe el usuario o la contraseña no es válida", MsgBoxStyle.Exclamation, "Usuario o Contraseña Inválida")
                        Me.txtUsuario.Clear()
                        Me.txtContraseña.Clear()
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Else
                        _Usuario = permiso(0)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Else
                    MsgBox("No existe el usuario o la contraseña no es válida", MsgBoxStyle.Exclamation, "Usuario o Contraseña Inválida")
                    Me.txtUsuario.Clear()
                    Me.txtContraseña.Clear()
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al realizar la validacion del usaurio", MsgBoxStyle.Critical, "Error")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub ModCatAutorizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.keys
    End Sub
End Class