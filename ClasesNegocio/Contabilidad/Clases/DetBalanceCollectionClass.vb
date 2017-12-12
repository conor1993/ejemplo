Imports IC = Integra.Clases
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CM = System.ComponentModel

Public Class DetBalanceCollectionClass
    Inherits ColleccionBase(Of EC.DetBalanceEntity, CC.DetBalanceCollection, DetBalanceClass)

    Public Overloads Function Obtener(ByVal CveBalance As String) As Integer
        Try
            Me.Clear()
            Dim Filtro As New SC.PredicateExpression
            Filtro.Add(HC.DetBalanceFields.CveBalance = CveBalance)
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function
End Class