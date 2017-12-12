Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class LugaresDeCompraCollectionClass
    Inherits ColleccionBase(Of EC.CatLugaresDeCompraEntity, CC.CatLugaresDeCompraCollection, LugaresDeCompraClass)

    Public Overloads Function Obtener(ByVal fcEstatus As CondicionEnum) As Integer
        Try
            If fcEstatus = CondicionEnum.TODOS Then
                Return Me.Obtener(Nothing, New OC.SortExpression(New OC.SortClause(HC.CatLugaresDeCompraFields.Descripcion, OC.SortOperator.Ascending)))
            Else
                Return Me.Obtener(HC.CatLugaresDeCompraFields.Estatus = fcEstatus, New OC.SortExpression(New OC.SortClause(HC.CatLugaresDeCompraFields.Descripcion, OC.SortOperator.Ascending)))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Shared Function CargarLugaresdeCompra(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim LugaresdeCompra As New CC.CatLugaresDeCompraCollection()

        Try
            LugaresdeCompra.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatLugaresDeCompraFields.Descripcion, OC.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return LugaresdeCompra.GetList()
    End Function

    Public Function Reporte() As rptCatLugaresDeCompra
        Dim Reportes As New rptCatLugaresDeCompra
        Dim ds As New DataSet
        Dim dsCatLugaresDeCompra As New DSetCatLugaresDeCompra.dtLugaresDeCompraDataTable
        For Each LugaresDeCompra As LugaresDeCompraClass In Me
            dsCatLugaresDeCompra.AdddtLugaresDeCompraRow(LugaresDeCompra.IdLugarCompra, LugaresDeCompra.Descripcion, LugaresDeCompra.Estado.Descripcion, LugaresDeCompra.Ciudad.Descripcion, LugaresDeCompra.Poblacion.Descripcion, LugaresDeCompra.HorasTransporte, LugaresDeCompra.Estatus.ToString)
        Next
        ds.Tables.Add(dsCatLugaresDeCompra)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class