Imports CN = ClasesNegocio

Public Class frmConfiguracionMovimientoGanado
    Private WithEvents InvProdConfiguracion As CN.InventarioConfigGanadoClass
    Private Tipos As New CN.TipoMovimientoGanadoColeccionClass

    Private Sub frmConfiguracionMovimientoGanado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            InvProdConfiguracion.Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmConfiguracionMovimientoGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Tipos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            InvProdConfiguracion = New CN.InventarioConfigGanadoClass(1, Tipos)
            pptGrid.SelectedObject = InvProdConfiguracion
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class