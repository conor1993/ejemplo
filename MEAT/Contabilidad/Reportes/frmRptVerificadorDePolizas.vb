Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmRptVerificadorDePolizas

#Region "Miembros"
    Dim Estado As FormState
#End Region

#Region "Metodos"
    Public Sub InicializarForma()
        rbnFecha.Checked = True
        PictureBox1.Visible = False
    End Sub

    Public Function Imprimir(ByVal Trans As HC.Transaction) As Boolean
        Estado = FormState.Imprimir
        PictureBox1.Visible = True
        Me.Refresh()

        If Controlador.ReporteVerificadorDePolizas(Trans, rbnFecha.Checked) Then
            PictureBox1.Visible = False
        End If
    End Function

    Public Sub Salir()
        Estado = FormState.Salir
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmBalanceGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarForma()
    End Sub

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        Dim Resultado As Object = Nothing

        If e.Button.Text = "Imprimir" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Polizas Errores")
            If Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans}) Is Nothing Then
                Trans.Rollback()
                Resultado = False
            Else
                Resultado = True
            End If
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If

        If Resultado Is Nothing OrElse Not Resultado Then
            Cancelar = True
        End If
    End Sub
#End Region
End Class