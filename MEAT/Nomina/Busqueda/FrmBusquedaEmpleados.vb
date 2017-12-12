Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CN = ClasesNegocio
Imports tc = IntegraLab.ORM.TypedViewClasses

Public Class FrmBusquedaEmpleados
    Dim empleados As New CN.EmpleadosCollectionClass
    Private empleado As New CN.NomcatempleadosClass

    Private Sub Buscar()
        Try
            Cursor = Cursors.WaitCursor
            Dim filtro As New OC.PredicateExpression
            If Not Me.txtCodigo.Text = "" Then
                filtro.Add(HC.NomCatEmpleadosFields.Codigo Mod String.Format("%{0}%", Me.txtCodigo.Text.Trim))
            Else
                If Not Me.txtNombre.Text = "" Then
                    filtro.Add(HC.NomCatEmpleadosFields.Nombres Mod String.Format("%{0}%", Me.txtNombre.Text))
                End If

                If Not Me.txtAPaterno.Text = "" Then
                    filtro.Add(HC.NomCatEmpleadosFields.ApellidoPaterno Mod String.Format("%{0}%", Me.txtAPaterno.Text))
                End If

                If Not Me.TxtAMaterno.Text = "" Then
                    filtro.Add(HC.NomCatEmpleadosFields.ApellidoMaterno Mod String.Format("%{0}%", Me.TxtAMaterno.Text))
                End If

                If Me.ChkFechas.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.NomCatEmpleadosFields.FechaAlta, Me.dtpFechaInicial.Value.ToString("dd/MM/yyyy"), Me.dtpFechaFinal.Value.AddDays(1).ToString("dd/MM/yyyy")))
                End If

                If Me.rbtnActivo.Checked Then
                    filtro.Add(HC.NomCatEmpleadosFields.Estatus = CN.CondicionEstatusEnum.ACTIVO)
                ElseIf Me.rbtnInactivo.Checked Then
                    filtro.Add(HC.NomCatEmpleadosFields.Estatus = CN.CondicionEstatusEnum.INACTIVO)
                End If
            End If

            Me.Empleados.Obtener(filtro)
            Me.dgvEmpleados.AutoGenerateColumns = False
            Me.dgvEmpleados.DataSource = Me.Empleados

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If IsNumeric(txtCodigo.Text) Then
                    Buscar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Me.dgvEmpleados.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Try
            Me.txtCodigo.Text = ""
            Me.txtNombre.Text = ""
            Me.txtAPaterno.Text = ""
            Me.TxtAMaterno.Text = ""
            Me.ChkFechas.Checked = False
            Me.rbtnTodos.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvEmpleados_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvEmpleados.DataError

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

    Private Sub dgvEmpleados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvEmpleados.DoubleClick
        Try
            If Me.dgvEmpleados.SelectedRows.Count = 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmBusquedaEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Buscar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Buscar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtAPaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAPaterno.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Buscar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TxtAMaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAMaterno.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Buscar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class