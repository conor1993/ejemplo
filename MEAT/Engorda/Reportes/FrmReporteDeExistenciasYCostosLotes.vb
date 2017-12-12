Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteDeExistenciasYCostosLotes

#Region "Miembros"

#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        ActualizarCombos()
    End Sub

    Private Sub ActualizarCombos()
        Dim Lotes As LoteCollectionClass = Controlador.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
        Lotes.Insert(0, New LoteClass())
        Lotes(0).Descripcion = "TODOS"

        cmbLotes.DisplayMember = "Descripcion"
        cmbLotes.ValueMember = "IdLote"
        cmbLotes.DataSource = Lotes
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Imprimir()
        Dim Lote As LoteClass = Nothing

        If cmbLotes.SelectedIndex <> -1 AndAlso CType(cmbLotes.SelectedValue, Integer) <> 0 Then
            Lote = CType(cmbLotes.SelectedItem, LoteClass)
        End If
        Controlador.ReporteExistenciasYCostosLotes(Lote)
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub FrmCorReporteDeExistenciasYCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub cmbLotes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLotes.KeyDown
        If e.KeyCode = Keys.F12 Then
            ActualizarCombos()
        End If
    End Sub

#End Region

End Class