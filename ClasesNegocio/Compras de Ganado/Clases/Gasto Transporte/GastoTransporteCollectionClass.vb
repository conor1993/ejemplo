Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class GastoTransporteCollectionClass
    Inherits ColleccionBase(Of EC.CabGasTransEntity, CC.CabGasTransCollection, GastoTransporteClass)

    Public Overloads Function Obtener(ByVal Folio As String) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not Folio = "" Then filtro.Add(HC.CabGasTransFields.FolRecep = Folio)

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class