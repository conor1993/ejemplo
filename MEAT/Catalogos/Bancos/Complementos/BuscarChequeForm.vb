Imports Integra.Clases

Public Class BuscarChequeForm

    Private _Cheque As ClasesNegocio.ChequeClass
    Private Bus As New Integra.Clases.BusquedaClass(Of ClasesNegocio.ChequeClass)

    Public Property Cheque() As ClasesNegocio.ChequeClass
        Get
            Return _Cheque
        End Get
        Set(ByVal value As ClasesNegocio.ChequeClass)
            _Cheque = value
        End Set
    End Property

    Private Cond As Boolean = False
    Private _tipMov As ClasesNegocio.BancosMovimientosTipo

    Public Property TipoMovimientos() As ClasesNegocio.BancosMovimientosTipo
        Get
            Return _tipMov
        End Get
        Set(ByVal value As ClasesNegocio.BancosMovimientosTipo)
            _tipMov = value
            Select Case _tipMov
                Case ClasesNegocio.BancosMovimientosTipo.DEPOSITO
                    rdbDep.Checked = True
                    rdbRet.Checked = False
                    rdbTod.Checked = False
                    rdbCardiv.Checked = False
                    rdbAbodiv.Checked = False
                    rdbTras.Checked = False
                Case ClasesNegocio.BancosMovimientosTipo.RETIRO
                    rdbDep.Checked = False
                    rdbRet.Checked = True
                    rdbTod.Checked = False
                    rdbCardiv.Checked = False
                    rdbAbodiv.Checked = False
                    rdbTras.Checked = False
                Case ClasesNegocio.BancosMovimientosTipo.CARGO_DIVERSO
                    rdbDep.Checked = False
                    rdbRet.Checked = False
                    rdbTod.Checked = False
                    rdbCardiv.Checked = True
                    rdbAbodiv.Checked = False
                    rdbTras.Checked = False
                Case ClasesNegocio.BancosMovimientosTipo.ABONO_DIVERSO
                    rdbDep.Checked = False
                    rdbRet.Checked = False
                    rdbTod.Checked = False
                    rdbCardiv.Checked = False
                    rdbAbodiv.Checked = True
                    rdbTras.Checked = False
                Case ClasesNegocio.BancosMovimientosTipo.TRASPASO
                    rdbDep.Checked = False
                    rdbRet.Checked = False
                    rdbTod.Checked = False
                    rdbCardiv.Checked = False
                    rdbAbodiv.Checked = False
                    rdbTras.Checked = True
                Case Else
                    rdbDep.Checked = False
                    rdbRet.Checked = False
                    rdbTod.Checked = True
                    rdbCardiv.Checked = False
                    rdbAbodiv.Checked = False
                    rdbTras.Checked = False
            End Select
            Cond = True
        End Set
    End Property

    Public Property BloquearTiposMovimiento() As Boolean
        Get
            Return gpoTipo.Enabled
        End Get
        Set(ByVal value As Boolean)
            gpoTipo.Enabled = Not value
        End Set
    End Property

    Private Sub LimpiarBeneficiarios()
        txtBeneficiario.Clear()
        cmbBeneficiario.SelectedIndex = -1
        cmbBeneficiario.Text = "Seleccione un Beneficiario..."
    End Sub

    Private Sub RellenarBeneficiarios()
        Beneficiarios.Obtener(CondicionEnum.ACTIVOS)
        txtBeneficiario.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBeneficiario.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBeneficiario.AutoCompleteCustomSource.AddRange(Beneficiarios.Listar)
    End Sub

    Private Sub cmbBeneficiario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBeneficiario.SelectedIndexChanged
        If cmbBeneficiario.SelectedIndex > -1 Then
            txtBeneficiario.Text = cmbBeneficiario.SelectedValue
            Me.txtCodBeneficiario.Text = Beneficiarios(Me.cmbBeneficiario.SelectedIndex).Codigo
        End If
    End Sub

    Private Sub txtBeneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBeneficiario.KeyDown, cmbBeneficiario.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Beneficiarios.Obtener(CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBeneficiario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBeneficiario.TextChanged
        cmbBeneficiario.SelectedValue = txtBeneficiario.Text
    End Sub

    Private Anti As Windows.Forms.CheckState = CheckState.Indeterminate

    Public Property Anticipos() As Windows.Forms.CheckState
        Get
            Return Anti
        End Get
        Set(ByVal value As Windows.Forms.CheckState)
            Anti = value
        End Set
    End Property

    Private Elec As Windows.Forms.CheckState = CheckState.Indeterminate

    Public Property Electronicos() As Windows.Forms.CheckState
        Get
            Return Elec
        End Get
        Set(ByVal value As Windows.Forms.CheckState)
            Elec = value
        End Set
    End Property

    Private Sub BusquedaCuentasContablesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        RellenarBeneficiarios()
        btnLimpiar_Click(sender, e)
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Cheque = Nothing
        LimpiarBeneficiarios()
        txtFolio.Clear()
        chkAnt.Checked = False
        Me.txtCodBeneficiario.Text = ""
        If Not Cond Then rdbTod.Checked = True
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cheques.Obtener(cmbBeneficiario.SelectedItem, txtFolio.Text, chkAnt.CheckState, chkEle.CheckState, TipMov, chkActivos.CheckState, chkInactivos.CheckState, chkCheque.CheckState)
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.RowIndex >= 0 Then
            _Cheque = Nothing
            _Cheque = Bus.ObtenerdeDataGrid(dgv)
            If Not IsNothing(_Cheque) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        _Cheque = Nothing
        _Cheque = Bus.ObtenerdeDataGrid(dgv)
        'If Not IsNothing(_Cheque) Then
        '    btnAceptar.Enabled = True
        'Else
        '    btnAceptar.Enabled = False
        'End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            btnBuscar_Click(sender, New EventArgs)
        End If
    End Sub

    Dim TipMov As Object = Nothing

    Private Sub rdbDep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDep.CheckedChanged
        If rdbDep.Checked Then
            TipMov = ClasesNegocio.BancosMovimientosTipo.DEPOSITO
        End If
    End Sub

    Private Sub rdbRet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRet.CheckedChanged
        If rdbRet.Checked Then
            TipMov = ClasesNegocio.BancosMovimientosTipo.RETIRO
        End If
    End Sub

    Private Sub rdbTod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTod.CheckedChanged
        If rdbTod.Checked Then
            TipMov = Nothing
        End If
    End Sub

    Private Sub rdbAbodiv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbAbodiv.CheckedChanged
        If rdbAbodiv.Checked Then
            TipMov = ClasesNegocio.BancosMovimientosTipo.ABONO_DIVERSO
        End If
    End Sub

    Private Sub rdbCardiv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbCardiv.CheckedChanged
        If rdbCardiv.Checked Then
            TipMov = ClasesNegocio.BancosMovimientosTipo.CARGO_DIVERSO
        End If
    End Sub

    Private Sub rdbTras_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbTras.CheckedChanged
        If rdbTras.Checked Then
            TipMov = ClasesNegocio.BancosMovimientosTipo.TRASPASO
        End If
    End Sub

    Sub CheckEstatus()
        If Me.chkActivos.Checked = False And Me.chkInactivos.Checked = False Then
            Me.chkActivos.Checked = True
            Me.chkInactivos.Checked = True
        End If
    End Sub

    Sub CheckMedio()
        If Me.chkCheque.Checked = False And Me.chkEle.Checked = False Then
            Me.chkEle.Checked = True
            Me.chkCheque.Checked = True
        End If
    End Sub

    Private Sub chkActivos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkActivos.CheckedChanged
        CheckEstatus()
    End Sub

    Private Sub chkInactivos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInactivos.CheckedChanged
        CheckEstatus()
    End Sub

    Private Sub chkCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
        CheckMedio()
    End Sub

    Private Sub chkEle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEle.CheckedChanged
        CheckMedio()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Cheques.Obtener(cmbBeneficiario.SelectedItem, txtFolio.Text, chkAnt.CheckState, chkEle.CheckState, TipMov, chkActivos.CheckState, chkInactivos.CheckState, chkCheque.CheckState)
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Cheques.Clear()
        txtFolio.Clear()
        _Cheque = Nothing
        chkAnt.Checked = False
        LimpiarBeneficiarios()
        Me.txtCodBeneficiario.Text = ""
        If Not Cond Then rdbTod.Checked = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtCodBeneficiario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodBeneficiario.TextChanged
        If IsNumeric(Me.txtCodBeneficiario.Text) Then
            For i As Integer = 0 To Beneficiarios.Count - 1
                If Me.txtCodBeneficiario.Text = Beneficiarios(i).Codigo Then
                    Me.cmbBeneficiario.SelectedValue = Beneficiarios(i).Beneficiario.ToString
                End If
            Next
        Else
            Me.cmbBeneficiario.SelectedValue = ""
            Me.txtCodBeneficiario.Text = ""
        End If
    End Sub
End Class