Public Class PreVisualizarForm

    Public WriteOnly Property Reporte() As Object
        Set(ByVal value As Object)
            Me.CrystalReportViewer1.ReportSource = value
        End Set
    End Property


End Class