Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class frmReporteMedicamentosTrabajo

    Private Sub cmbMedicamento_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicamento.ActualizarCombo
        Try
            Dim rel As New OC.RelationCollection

            rel.Add(New OC.EntityRelation(HC.ProductoFields.Codigo, HC.CabMediTrabFields.CveMedi, _
                    SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne), SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

            Me.cmbMedicamento.DataSource = CC.ProductoCollection.GetMultiAsDataTable(Nothing, 0, _
                                            New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, _
                                            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), rel)
            Me.cmbMedicamento.DisplayMember = "Descripcion"
            Me.cmbMedicamento.ValueMember = "Codigo"
            Me.cmbMedicamento.SelectedIndex = -1
            Me.cmbMedicamento.Text = "Seleccione un medicamento"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor

        Try
            Dim col As New ClasesNegocio.MedicamentoTrabajoColletionClass
            Dim filtro As New OC.PredicateExpression

            If Me.cmbMedicamento.SelectedIndex > -1 Then filtro.Add(HC.CabMediTrabFields.CveMedi = CInt(Me.cmbMedicamento.SelectedValue))

            col.Obtener(filtro)
            col.Imprimir(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Try
            Me.cmbMedicamento.SelectedIndex = -1
            Me.cmbMedicamento.Text = "Seleccione un medicamento"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub frmReporteMedicamentosTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbMedicamento.OnActualizaCombo()
    End Sub
End Class