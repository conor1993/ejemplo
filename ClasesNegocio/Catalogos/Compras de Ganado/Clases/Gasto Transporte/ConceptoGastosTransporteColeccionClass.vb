Imports System.Windows.Forms
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class ConceptoGastosTransporteColeccionClass
    Inherits ColleccionBase(Of EC.McgcatConcepGastosEntity, CC.McgcatConcepGastosCollection, ConceptoGastosTransporteClass)

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not fcCondicion = CondicionEnum.TODOS Then filtro.Add(HC.McgcatConcepGastosFields.Estatus = fcCondicion)

            Return Obtener(filtro, New OC.SortExpression(New OC.SortClause(HC.McgcatConcepGastosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Descripcion As String) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not Descripcion = "" Then filtro.Add(HC.McgcatConcepGastosFields.Descripcion Mod String.Format("%{0}%", Descripcion))

            Return Obtener(filtro, New OC.SortExpression(New OC.SortClause(HC.McgcatConcepGastosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptCatConceptoGastosTransporte
        Dim Reportes As New rptCatConceptoGastosTransporte
        Dim ds As New DataSet
        Dim dtConceptoGastosTransporte As New DSetCatConceptoGastosTransporte.dtConceptoGastosTransporteDataTable
        For Each ConceptoGastosTransporte As ConceptoGastosTransporteClass In Me
            dtConceptoGastosTransporte.AdddtConceptoGastosTransporteRow(ConceptoGastosTransporte.IdConceptoGasto, ConceptoGastosTransporte.DescCorta, ConceptoGastosTransporte.Descripcion, ConceptoGastosTransporte.AplicaIVA, ConceptoGastosTransporte.PorcentajeIVA, ConceptoGastosTransporte.Observaciones, ConceptoGastosTransporte.Estatus.ToString())
        Next
        ds.Tables.Add(dtConceptoGastosTransporte)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class