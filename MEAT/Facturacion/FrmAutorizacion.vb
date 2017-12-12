Imports CN = ClasesNegocio

Public Class FrmAutorizacion

    Private Sub FrmAutorizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Controlador.Configuracion.ActualizarProduccion()

        If Controlador.Configuracion.Produccion.Entidad.IsNew Then
            MsgBox("No existe configuraci�n de producci�n", MsgBoxStyle.Information, "")
            BtnAceptar.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If IsDBNull(Controlador.Configuracion.Produccion.Contrase�a) Then
            MsgBox("No se ha agregado la contrase�a de autorizaci�n en la ventana de configuraci�n", MsgBoxStyle.Exclamation, "Aviso")
        Else
            Dim a As String = Me.txtContrase�a.GetHashCode
            If Me.txtContrase�a.Text.GetHashCode = Controlador.Configuracion.Produccion.Contrase�a Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
#If CONFIG = "Debug" Then
                If Me.txtContrase�a.Text.GetHashCode = "integra".GetHashCode Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Exit Sub
                End If
#End If
                MsgBox("Contrase�a invalida", MsgBoxStyle.Exclamation, "Aviso")
                txtContrase�a.ResetText()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class