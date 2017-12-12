Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmDetalleLote
#Region "Miembros"
    Private DetalleSeleccionado As dsSeleccionDetalleLote.SelDetalleLoteDataTable
#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        dgvDetalleLote.AutoGenerateColumns = False
        Me.dgvDetalleLote.DataSource = DetalleSeleccionado
    End Sub
#End Region

#Region "Constructores"
    Sub New(ByRef DetalleSeleccionado As dsSeleccionDetalleLote.SelDetalleLoteDataTable, ByVal EsSalidaPorVenta As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DetalleSeleccionado = DetalleSeleccionado
        clmPrecioxKilo.Visible = EsSalidaPorVenta
    End Sub
#End Region

#Region "Acciones_Menu"

#End Region

#Region "Eventos"
    Private Sub frmSeleccionDetalleLote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

End Class