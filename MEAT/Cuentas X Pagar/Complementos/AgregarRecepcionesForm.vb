Public Class AgregarRecepcionesForm

    Public prov As Integer
    Public Fact As String
    Private Sub AgregarRecepcionesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

        'filtro.Add(IntegraLab.ORM.HelperClasses.RecepcionesProveedoresFields.IdProveedor = prov)
        'filtro.Add(IntegraLab.ORM.HelperClasses.RecepcionesProveedoresFields.FolioFactura = "")
        'Me.DgvRecepciones.AutoGenerateColumns = False

        'Recep.Fill(0, Nothing, True, filtro)
        'Me.DgvRecepciones.DataSource = Recep
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class