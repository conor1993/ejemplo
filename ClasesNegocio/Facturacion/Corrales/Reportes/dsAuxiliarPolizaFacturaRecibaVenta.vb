Partial Class dsAuxiliarPolizaFacturaRecibaVenta
    Partial Class AuxiliarFacturasRecibaVentaDataTable

        Private Sub AuxiliarFacturasRecibaVentaDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PrecioUnitarioColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
