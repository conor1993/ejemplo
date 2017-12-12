Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CN = ClasesNegocio
Imports tc = IntegraLab.ORM.TypedViewClasses

Public Class frmBusquedaCalculosdeNomina
    'Dim CalculosNomina As New CN.CalculoNominaColeccion
    Private CalculoNomina As New CN.CalculoNominaClass

    Private Sub Buscar()
        Try
            Cursor = Cursors.WaitCursor
            Dim filtro As New OC.PredicateExpression
            If Not Me.TxtFolio.Text = "" Then
                filtro.Add(HC.NomImportesFields.Folio Mod String.Format("%{0}%", Me.TxtFolio.Text))
            End If

            If Me.ChkFechas.Checked Then
                filtro.Add(New OC.FieldBetweenPredicate(HC.NomCatEmpleadosFields.FechaAlta, Me.dtpFechaInicial.Value.ToString("dd/MM/yyyy"), Me.dtpFechaFinal.Value.AddDays(1).ToString("dd/MM/yyyy")))
            End If



            'Me.CalculosNomina.Obtener(filtro)
            Dim VistaCalculoNomina As New tc.VwConsultaNominaTypedView
            VistaCalculoNomina.Fill(0, Nothing, True, filtro)

            If VistaCalculoNomina.Rows.Count = 0 Then
                MsgBox("No existe información para esta nomina ", MsgBoxStyle.Information, "")
                Exit Sub
            End If

            Me.DgvCalculos.AutoGenerateColumns = False
            Me.DgvCalculos.DataSource = VistaCalculoNomina

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ChkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFechas.CheckedChanged
        If Me.ChkFechas.Checked = True Then
            Me.dtpFechaInicial.Enabled = True
            Me.dtpFechaFinal.Enabled = True
        Else
            Me.dtpFechaInicial.Enabled = False
            Me.dtpFechaFinal.Enabled = False
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Try
            Me.TxtFolio.Text = ""
            Me.TxtDescripcion.Text = ""
            Me.ChkFechas.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub TxtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFolio.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If IsNumeric(TxtFolio.Text) Then
                    Buscar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Buscar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmBusquedaCalculosdeNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Buscar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvCalculos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvCalculos.DataError

    End Sub

    Private Sub DgvCalculos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCalculos.DoubleClick
        Try
            If Me.DgvCalculos.SelectedRows.Count = 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class