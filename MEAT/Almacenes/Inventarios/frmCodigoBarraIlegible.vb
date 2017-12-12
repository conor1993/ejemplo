Public Class frmCodigoBarraIlegible

#Region "Constructores"
    Sub New(ByVal Codigo As String, ByVal Mensaje As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtCodigo.Text = Codigo
        lblMensaje.Text = Mensaje
    End Sub
#End Region

#Region "Eventos"

    Private Sub btnIgnorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnorar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbortar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

#End Region

End Class