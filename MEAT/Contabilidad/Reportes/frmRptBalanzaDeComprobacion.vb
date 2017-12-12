Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmRptBalanzaDeComprobacion

#Region "Miembros"
    Dim Estado As FormState
#End Region

#Region "Metodos"
    Public Sub InicializarForma()

    End Sub

    Public Sub Limpiar()
        Estado = FormState.Limpiar
        ultcmbMes.Clear()
    End Sub

    Public Sub Imprimir()
        Estado = FormState.Imprimir

        If ultcmbMes.SelectedItem IsNot Nothing Then
            Controlador.ReporteBalanzaDeComprobacion(CType(ultcmbMes.SelectedItem.DataValue, MesEnum2))
        Else
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.BALANCE_GENERAL, 0)
        End If
    End Sub

    Public Sub Salir()
        Estado = FormState.Salir
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmBalanceGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarForma()
    End Sub

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        PictureBox1.Visible = True
        Utilerias.RunControlException(Me, e.Button.Text)
        PictureBox1.Visible = False
    End Sub
#End Region
End Class