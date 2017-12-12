Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class FrmCierreLoteCorte
    Dim WithEvents LoteCorte As CN.CortesClass
    ''Private Function Guardar() As Boolean
    ''    Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

    ''    Try
    ''        'cierre de lote de cortes
    ''        LoteCorte.LoteSacrificio = Me.txtLoteSacrificio.Text
    ''        LoteCorte.LoteCorte = Me.txtLoteCorte.Text
    ''        LoteCorte.Estatus = "C"
    ''        LoteCorte.FechaCierre = Now
    ''        LoteCorte.Func = "M"
    ''        LoteCorte.NumOpc = 2
    ''        If Not LoteCorte.Guardar(Trans) Then
    ''            Trans.Rollback()
    ''            Return False
    ''        End If
    ''        Trans.Commit()
    ''        Return True
    ''    Catch ex As Exception
    ''        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    ''        Trans.Rollback()
    ''        Return False
    ''    End Try


    ''End Function
    Private Function Limpiar() As Boolean
        Me.txtDiasCaducidad.Text = "0"
        Me.txtLoteCorte.Text = ""
        Me.txtLoteSacrificio.Text = ""
        Me.txtNombre.Text = ""
        Me.txtObservaciones.Text = ""
        Me.dtpFechaCaducidad.Value = Now
        Me.dtpFechaLoteCorte.Value = Now
        Me.dtpFechaSacrificio.Value = Now
    End Function
    'Private Function Buscar() As Boolean
    '    Try
    '        Dim Cortes As DataSet
    '        Dim Consultas As New FrmConsLoteCortes
    '        Cortes = LoteCorte.Obtener(1, "")
    '        If Cortes.Tables(0).Rows.Count = 0 Then
    '            MessageBox.Show("No existen lotes de cortes ", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Return False
    '        Else
    '            Consultas.dgvLoteCortes.AutoGenerateColumns = False
    '            Consultas.dgvLoteCortes.DataSource = Cortes.Tables(0)
    '            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                Me.txtLoteCorte.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("LoteCorte").Value
    '                Me.dtpFechaLoteCorte.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("FechaCorte").Value
    '                Me.txtDiasCaducidad.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("DiasCad").Value
    '                Me.txtLoteSacrificio.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("LoteSacrificio").Value
    '            End If
    '            Me.mtb.HabilitarBorrar = False
    '            Me.mtb.HabilitarBuscar = False
    '            Me.mtb.HabilitarCancelar = False
    '            Me.mtb.HabilitarEditar = False
    '            Me.mtb.HabilitarGuardar = True
    '            Me.mtb.HabilitarImprimir = False
    '            Me.mtb.HabilitarLimpiar = False
    '            Me.mtb.HabilitarNuevo = True
    '            Me.mtb.HabilitarSalir = True
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try


    'End Function

    Private Sub PonerDatos()
        Me.txtLoteCorte.Text = Me.LoteCorte.LoteCorte
        Me.txtLoteSacrificio.Text = LoteCorte.LoteSacrificio
        Me.txtNombre.Text = LoteCorte.Cliente.Nombre
        Me.txtDiasCaducidad.Text = LoteCorte.DiasCad
        Me.txtObservaciones.Text = LoteCorte.Observaciones
        Me.dtpFechaCaducidad.Value = LoteCorte.FechaCad
        Me.dtpFechaLoteCorte.Value = LoteCorte.FechaCorte
        Me.dtpFechaSacrificio.Value = LoteCorte.FechaFapsa
    End Sub
    Private Sub Buscar()
        Try
            Dim Vista As New TC.VwBusquedaLoteCortesTypedView
            Dim filtro As New OC.PredicateExpression

            filtro.Add(Not HC.VwBusquedaLoteCortesFields.Estatus = "X")
            Vista.Fill(0, Nothing, False, filtro)
            Me.DgvLotes.AutoGenerateColumns = False
            Me.DgvLotes.DataSource = Vista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Imprimir() As Boolean
    End Function

    'Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
    '    If Not Buscar() Then
    '        MessageBox.Show("No se encuentran recepciones de ganado", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = False
        Me.mtb.HabilitarSalir = True
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            If LoteCorte.Estatus = "C" Then
                MessageBox.Show("No se puede cerrar el lote porque ya se encuentra cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If MessageBox.Show("Esta seguro de cerrar el lote de corte", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                LoteCorte.LoteSacrificio = Me.txtLoteSacrificio.Text
                LoteCorte.LoteCorte = Me.txtLoteCorte.Text
                LoteCorte.Estatus = "C"
                LoteCorte.FechaCierre = Now
                LoteCorte.Func = "M"
                LoteCorte.NumOpc = 2
                If Not LoteCorte.Guardar(Trans) Then
                    Trans.Rollback()
                End If
                Trans.Commit()
                MessageBox.Show("Se ha cerrado el lote de corte: " & LoteCorte.LoteCorte, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Buscar()
                Limpiar()
            End If

        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub FrmCierreLoteCorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Limpiar()
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvLotes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvLotes.CellClick
        Try
            If Me.DgvLotes.SelectedRows.Count > 0 Then
                Me.dgvDetalle.DataSource = Nothing
                Dim Detalle As New DataSet
                Dim LoteCorte As String = Me.DgvLotes.SelectedRows(0).Cells(Me.clmLoteCorte.Index).Value
                Me.LoteCorte = New CN.CortesClass(LoteCorte)
                PonerDatos()
                Me.lblEstatus.Visible = True
                lblEstatus.Text = Me.DgvLotes.SelectedRows(0).Cells(Me.clmEstatus.Index).Value

                Detalle = SPR.UspConMscloteCortesCab(6, LoteCorte)
                If Detalle.Tables(0).Rows.Count > 0 Then
                    Me.dgvDetalle.AutoGenerateColumns = False
                    Me.dgvDetalle.DataSource = Detalle.Tables(0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
