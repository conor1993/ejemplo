﻿Partial Class dsFacturaVentasPorClienteSubInf
    Partial Class FacturaDetDataTable

        Private Sub FacturaDetDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PrecioxKgrColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
