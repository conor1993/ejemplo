Public Class FacturasDetallesForm

    Public FolioF As String

    'Private Sub RecepcionesFacturadasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '

    'End Sub

    Private Sub FacturasDetallesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Rec As New FacturasDetallesForm

        ''Rec.FolioF = Factura
        'Dim Receps As New IntegraLab.ORM.TypedViewClasses.VwRecepcionFacturaTypedView
        'Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
        'filtro.Add(IntegraLab.ORM.HelperClasses.VwRecepcionFacturaFields.FolioFactura = Me.FolioF)
        'Rec.DataGridView1.AutoGenerateColumns = False
        'Receps.Fill(0, Nothing, True, filtro)
        'If Receps.Count > 0 Then
        '    Rec.DataGridView1.DataSource = Receps
        '    'Rec.ShowDialog()
        'Else
        '    MsgBox("La Factura no tiene Recepciones Relacionadas...")
        'End If
    End Sub
End Class