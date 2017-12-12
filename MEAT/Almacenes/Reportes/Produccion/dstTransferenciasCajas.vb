Partial Class dstTransferenciasCajas
    Partial Class TransferenciaCabDataTable

        Private Sub TransferenciaCabDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FechaColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class TransferenciaDetDataTable

        Private Sub TransferenciaDetDataTable_TransferenciaDetRowChanging(ByVal sender As System.Object, ByVal e As TransferenciaDetRowChangeEvent) Handles Me.TransferenciaDetRowChanging

        End Sub

    End Class

End Class
