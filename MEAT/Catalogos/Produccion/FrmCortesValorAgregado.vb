Imports CD = IntegraLab.ORM.CollectionClasses
Imports ED = IntegraLab.ORM.HelperClasses
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmCortesValorAgregado

    Private Sub FrmCortesValorAgregado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CatProductos.GetMulti(HC.MsccatProductosFields.Corte = 1)
    End Sub
End Class