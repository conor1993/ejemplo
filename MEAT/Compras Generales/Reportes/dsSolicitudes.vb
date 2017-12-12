Partial Class dsSolicitudes

    Sub ReporteSolicitudes(ByVal Folio As String, ByVal Plaza As String, ByVal Sucursal As String, ByVal Importe As String, ByVal Fecha As String)
        Dim ds As New DataSet, dt As New dsSolicitudes.SolicitudesDataTable

        dt.AddSolicitudesRow(Folio, Plaza, Sucursal, Importe, Fecha)
    End Sub

End Class
