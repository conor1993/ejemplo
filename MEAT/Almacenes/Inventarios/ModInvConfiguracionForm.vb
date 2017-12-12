Imports HC = Integralab.ORM.HelperClasses
Imports CN = ClasesNegocio

Public Class ModInvConfiguracionForm

    Private Sub ModInvConfiguracionForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            Controlador.Configuracion.Inventario.Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ModInvConfiguracionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Controlador.Configuracion.ActualizarInventario()
            pptGrid.SelectedObject = Controlador.Configuracion.Inventario
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pptGrid_PropertyValueChanged(ByVal s As Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles pptGrid.PropertyValueChanged
        Try
            Controlador.Configuracion.Inventario.Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class