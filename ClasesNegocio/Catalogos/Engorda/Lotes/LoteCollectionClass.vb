Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class LoteCollectionClass
    Inherits ColleccionBase(Of EC.McecatLotesCabEntity, CC.McecatLotesCabCollection, LoteClass)

    Public Shared Function ObtenerUltimoLoteRegistrado() As LoteClass
        Try
            Dim col As New CC.McecatLotesCabCollection
            Dim lote As LoteClass = Nothing

            col.GetMulti(Nothing, 1, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.IdLote, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            If col.Count > 0 Then
                lote = New LoteClass(col(0))
            End If

            Return lote
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Overloads Function IndexOf(ByVal IdLote As Integer) As Integer
        For i As Integer = 0 To Me.Count - 1
            If Me.Item(i).IdLote = IdLote Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Overloads Function Obtener(ByVal fcEstatus As CondicionEstatusEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not fcEstatus = CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.McecatCorralesCabFields.Estatus = fcEstatus)
            End If

            Return Obtener(filtro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Reporte() As RptCatLotes
        Dim Reportes As New RptCatLotes
        Dim ds As New DataSet
        Dim dtLotes As New DSetCatLotes.dtLotesDataTable
        For Each Lotes As LoteClass In Me
            dtLotes.AdddtLotesRow(Lotes.IdLote, Lotes.Descripcion, Lotes.DescCorta, Lotes.Corral.IdCorral, Lotes.GDP, Lotes.PesoProyectadoxCbz, Lotes.FechaInicio.Date, Lotes.FechaCierre.Date)
        Next
        ds.Tables.Add(dtLotes)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class