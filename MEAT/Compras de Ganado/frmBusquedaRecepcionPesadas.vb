Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class frmBusquedaRecepcionPesadas

#Region "Miembros"

#End Region

#Region "Metodos"
    Private Function Limpiar() As Boolean
        txtFolio.Text = String.Empty
        txtProveedor.Text = String.Empty
        cmbProveedor.SelectedValue = -1
        cmbProveedor.Text = "Seleccione el proveedor"
        dtpFechaInicial.Value = Now
        dtpFechaFinal.Value = Now
        chkVigente.Checked = True
        chkCancelado.Checked = True
        Return True
    End Function

    Private Function Buscar(ByVal Todos As Boolean) As Boolean
        If Not Me.Validate() Then
            Exit Function
        End If

        Try
            Dim Filtro As New OC.PredicateExpression()
            Dim Coleccion As New RecepcionGanadoColeccion()

            If Not Todos Then

                If Not txtFolio.Text = String.Empty Then
                    Filtro.Add(HC.RecepcionGanadoFields.LoteRecepcion = txtFolio.Text)
                Else
                    If cmbProveedor.SelectedValue > 0 And (IsNumeric(txtProveedor.Text) AndAlso txtProveedor.Text <> 0) Then
                        Filtro.Add(HC.RecepcionGanadoFields.IdProveedor = cmbProveedor.SelectedValue)
                    End If

                    If chkVigente.Checked And Not chkCancelado.Checked Then
                        Filtro.Add(HC.RecepcionGanadoFields.Estatus <> "X")
                    ElseIf Not chkVigente.Checked And chkCancelado.Checked Then
                        Filtro.Add(HC.RecepcionGanadoFields.Estatus = "X")
                    End If

                    If chkPorFecha.Checked Then
                        Filtro.Add(New OC.FieldBetweenPredicate(HC.RecepcionGanadoFields.FechaRecepcion, _
                        dtpFechaInicial.Value.ToShortDateString, dtpFechaFinal.Value.AddDays(1).ToShortDateString))
                    End If
                End If
            End If
            Filtro.Add(New OC.FieldCompareNullPredicate(HC.RecepcionGanadoFields.TipoPesada, True))
            Coleccion.Obtener(Filtro)
            dgvRecepcionPesadas.DataSource = Nothing
            dgvRecepcionPesadas.DataSource = Coleccion
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"
    Private Sub Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar, mtb.ClickSalir, mtb.ClickLimpiar
        Dim Resultado As Boolean = False

        If e.Button.Text = "Buscar" Then
            Resultado = Buscar(False)
        ElseIf e.Button.Text = "Limpiar" Then
            Resultado = Limpiar()
        ElseIf e.Button.Text = "Salir" Then
            Me.AutoValidate = Windows.Forms.AutoValidate.Disable
            Me.Close()
        End If

        Cancelar = Not Resultado
    End Sub

    Private Sub frmBusquedaRecepcionPesadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbProveedor.DataSource = ProveedorCollectionClass.CargarProveedores(HC.ProveedorFields.EsdeGanado = 1)
        cmbProveedor.SelectedValue = -1
        cmbProveedor.Text = "Seleccione el proveedor"
        txtProveedor.Text = String.Empty

        Buscar(True)
    End Sub

    Private Sub dgvRecepcionPesadas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepcionPesadas.CellDoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub dgvRecepcionPesadas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRecepcionPesadas.CellFormatting
        If clmEstatus.Index = e.ColumnIndex Then
            Select Case e.Value
                Case "X"
                    e.Value = "CANCELADO"
                Case "V", "G", "I", "O"
                    e.Value = "VIGENTE"
            End Select
        ElseIf clmTipoPesada.Index = e.ColumnIndex Then
            e.Value = e.Value.ToString().ToUpper()
        End If
    End Sub

    Private Sub dgvRecepcionPesadas_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvRecepcionPesadas.DataError

    End Sub

    Private Sub txtProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedor.TextChanged
        If Not txtProveedor.Text = String.Empty Then
            For Each item As EC.ProveedorEntity In cmbProveedor.Items
                If item.Codigo = txtProveedor.Text Then
                    cmbProveedor.SelectedItem = item
                    Exit Sub
                End If
            Next
        End If
        cmbProveedor.SelectedValue = -1
        cmbProveedor.Text = "Seleccione el proveedor"
    End Sub

    Private Sub cmbProveedor_Format(ByVal sender As Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbProveedor.Format
        e.Value = e.Value.ToString().Trim()
    End Sub

    Private Sub cmbProveedor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedValueChanged
        If Not cmbProveedor.SelectedValue Is Nothing Then
            txtProveedor.Text = cmbProveedor.SelectedValue.ToString()
        End If
    End Sub

    Private Sub Estatus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigente.CheckedChanged, chkCancelado.CheckedChanged, chkVigente.CheckedChanged, chkCancelado.CheckedChanged
        If Not chkVigente.Checked And Not chkCancelado.Checked Then
            chkVigente.Checked = True
            chkCancelado.Checked = True
        End If
    End Sub

    Private Sub dtpFecha_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaFinal.Validating, dtpFechaInicial.Validating
        If dtpFechaInicial.Value.Year > dtpFechaFinal.Value.Year Or dtpFechaInicial.Value.Month > dtpFechaFinal.Value.Month Or dtpFechaInicial.Value.Day > dtpFechaFinal.Value.Day Then
            MsgBox("La fecha inicial no debe ser mayor a la fecha final", MsgBoxStyle.Exclamation, "Aviso")
            e.Cancel = True
        End If
    End Sub
#End Region
End Class