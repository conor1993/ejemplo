Imports CN = ClasesNegocio

Public Class ModInvProdConfigForm
    Private WithEvents InvProdConfiguracion As CN.InventarioConfigProduccionClass
    Private Tipos As New CN.TipoMovimientoAlmacenCollectionClass

    Private Sub ModInvProdConfigForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            InvProdConfiguracion.Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModInvProdConfigForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Tipos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            InvProdConfiguracion = New CN.InventarioConfigProduccionClass(1, Tipos)
            pptGrid.SelectedObject = InvProdConfiguracion
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class