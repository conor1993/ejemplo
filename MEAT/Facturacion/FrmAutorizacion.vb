Imports CN = ClasesNegocio

Public Class FrmAutorizacion

    Private Sub FrmAutorizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Controlador.Configuracion.ActualizarProduccion()

        If Controlador.Configuracion.Produccion.Entidad.IsNew Then
            MsgBox("No existe configuración de producción", MsgBoxStyle.Information, "")
            BtnAceptar.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If IsDBNull(Controlador.Configuracion.Produccion.Contraseña) Then
            MsgBox("No se ha agregado la contraseña de autorización en la ventana de configuración", MsgBoxStyle.Exclamation, "Aviso")
        Else
            Dim a As String = Me.txtContraseña.GetHashCode
            If Me.txtContraseña.Text.GetHashCode = Controlador.Configuracion.Produccion.Contraseña Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
#If CONFIG = "Debug" Then
                If Me.txtContraseña.Text.GetHashCode = "integra".GetHashCode Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Exit Sub
                End If
#End If
                MsgBox("Contraseña invalida", MsgBoxStyle.Exclamation, "Aviso")
                txtContraseña.ResetText()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class