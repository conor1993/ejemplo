Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Windows.Forms
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CompradorGanadoCollectionClass
    Inherits ColleccionBase(Of EC.McgcatCompradoresdeGanadoEntity, CC.McgcatCompradoresdeGanadoCollection, CompradorGanadoClass)

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression
            Dim ordenamiento As New OC.SortExpression(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoPaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoMaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not fcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.McgcatCompradoresdeGanadoFields.Estatus = fcCondicion)
            End If

            Return Obtener(filtro, ordenamiento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal NombreComp As String) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim ordenamiento As New OC.SortExpression(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoPaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoMaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not NombreComp = "" Then
                Filtro.Add(HC.McgcatCompradoresdeGanadoFields.Nombre Mod String.Format("%{0}%", NombreComp))
                Filtro.AddWithOr(HC.McgcatCompradoresdeGanadoFields.ApellidoPaterno Mod String.Format("%{0}%", NombreComp))
                Filtro.AddWithOr(HC.McgcatCompradoresdeGanadoFields.ApellidoMaterno Mod String.Format("%{0}%", NombreComp))
            End If

            Return Obtener(Filtro, ordenamiento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptCatCompradoresGanado
        Dim Reportes As New rptCatCompradoresGanado
        Dim ds As New DataSet
        Dim dsCompradoresGanado As New DSetCatCompradoresGanado.dtCompradoresGanadoDataTable
        For Each CompradoresGanado As CompradorGanadoClass In Me
            dsCompradoresGanado.AdddtCompradoresGanadoRow(CompradoresGanado.IdComprador, CompradoresGanado.NomCompleto, CompradoresGanado.RFC, CompradoresGanado.Calle, CompradoresGanado.Colonia, CompradoresGanado.Estado.Descripcion, CompradoresGanado.Ciudad.Descripcion, CompradoresGanado.Poblacion.Descripcion, CompradoresGanado.Estatus.ToString)
        Next
        ds.Tables.Add(dsCompradoresGanado)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function
End Class