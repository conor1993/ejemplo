Public Class BusquedaClass(Of TipoEntidad As {IEntidad})
    Public Function ObtenerdeDataGrid(ByVal Datagrid As Windows.Forms.DataGridView) As TipoEntidad
        Dim Entidad As TipoEntidad = Nothing
        If Datagrid.SelectedRows.Count > 0 Then
            If Not Datagrid.SelectedRows(0).DataBoundItem Is Nothing Then
                Entidad = DirectCast(Datagrid.SelectedRows(0).DataBoundItem, TipoEntidad)
            End If
        End If
        Return Entidad
    End Function
End Class

