
Partial Public Class DSRecepcionOrdenCompra
    Partial Class RecepcionOrdenCabDataTable

        Private Sub RecepcionOrdenCabDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SucursalColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
