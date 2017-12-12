Public Class frmAutorizacionCambioPrecio

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAutorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutorizar.Click
        Dim ventanaAutorizacion As New ModCatAutorizacion

        If ventanaAutorizacion.ShowDialog = Windows.Forms.DialogResult.OK Then
            If ventanaAutorizacion.Permisos.CambiarPrecioFacturacion Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("No cuenta con permisos para cambiar precios de productos", MsgBoxStyle.Exclamation, "Sin Autorización")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub
End Class