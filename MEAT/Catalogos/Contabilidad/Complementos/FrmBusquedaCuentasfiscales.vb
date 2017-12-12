Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmBusquedaCuentasfiscales
    Private Cuenta As ClasesNegocio.CuentaFiscalClass
    Private Bus As New Integra.Clases.BusquedaClass(Of ClasesNegocio.CuentaFiscalClass)

    Public Property CuentaContable() As ClasesNegocio.CuentaFiscalClass
        Get
            Return Cuenta
        End Get
        Set(ByVal value As ClasesNegocio.CuentaFiscalClass)
            Cuenta = value
        End Set
    End Property

    Public WriteOnly Property BloquearCaracteristicas() As Boolean
        Set(ByVal value As Boolean)
            gpoCaracteristicas.Enabled = Not value
        End Set
    End Property

    Private afec As Windows.Forms.CheckState = CheckState.Indeterminate
    Public Property Afectables() As Windows.Forms.CheckState
        Get
            Return afec
        End Get
        Set(ByVal value As Windows.Forms.CheckState)
            afec = value
        End Set
    End Property

    Private depa As Windows.Forms.CheckState = CheckState.Indeterminate
    Public Property Departamentalizable() As Windows.Forms.CheckState
        Get
            Return depa
        End Get
        Set(ByVal value As Windows.Forms.CheckState)
            depa = value
        End Set
    End Property

    Private bans As Windows.Forms.CheckState = CheckState.Indeterminate
    Public Property Bancos() As Windows.Forms.CheckState
        Get
            Return bans
        End Get
        Set(ByVal value As Windows.Forms.CheckState)
            bans = value
        End Set
    End Property
    Private Sub FrmCuentasfiscales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        Me.btnAceptar.Enabled = False
        btnLimpiar_Click(sender, e)
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Cuenta = Nothing
        txtNombre.Clear()
        txtCta.Text = "0000"
        txtSCta.Text = "0000"
        txtSSCta.Text = "0000"
        txtSSSCta.Text = "0000"
        rdbAcr.Checked = False
        rdbDeu.Checked = False
        If Not Me.txtForma.Text = "Poliza de Diario" Then
            chkAfe.CheckState = CheckState.Indeterminate
            chkBan.CheckState = CheckState.Indeterminate
            chkDep.CheckState = CheckState.Indeterminate
            chkIna.CheckState = CheckState.Indeterminate
            chkPre.CheckState = CheckState.Indeterminate
            chkRes.CheckState = CheckState.Indeterminate
            chkAfe.CheckState = afec
            chkBan.CheckState = bans
            chkDep.CheckState = depa
        End If
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Dim bAfe As Object = Nothing
        'Dim bBan As Object = Nothing
        'Dim bDep As Object = Nothing
        'Dim bIna As Object = Nothing
        'Dim bPre As Object = Nothing
        'Dim bRes As Object = Nothing
        'Dim bNat As Object = Nothing
        'If chkAfe.CheckState <> CheckState.Indeterminate Then bAfe = chkAfe.Checked
        'If chkBan.CheckState <> CheckState.Indeterminate Then bBan = chkBan.Checked
        'If chkDep.CheckState <> CheckState.Indeterminate Then bDep = chkDep.Checked
        'If chkIna.CheckState <> CheckState.Indeterminate Then bIna = Not chkIna.Checked
        'If chkPre.CheckState <> CheckState.Indeterminate Then bPre = chkPre.Checked
        'If chkRes.CheckState <> CheckState.Indeterminate Then bRes = chkRes.Checked
        'If Not rdbAcr.Checked And rdbDeu.Checked Then
        '    bNat = ClasesNegocios.CuentaContableNaturalezaEnum.DEUDORA
        'ElseIf rdbAcr.Checked And Not rdbDeu.Checked Then
        '    bNat = ClasesNegocios.CuentaContableNaturalezaEnum.ACREEDORA
        'End If
        'Cuentas.Obtener(bIna, txtNombre.Text, txtCta.Text, txtSCta.Text, txtSSCta.Text, txtSSSCta.Text, bNat, bRes, bPre, bDep, bBan, bAfe)
        Me.MostrarCuentas()
    End Sub
    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        'Cuenta = 
        'Cuenta.Obtener()
        'If Not IsNothing(Cuenta) Then
        '    btnAceptar.Enabled = True
        'Else
        '    btnAceptar.Enabled = False
        'End If
        If Me.dgv.SelectedRows.Count > 0 Then
            'Cuenta = New CN.CuentaContableClass
            'Me.Cuenta.Obtener(Me.dgv.SelectedRows(0).Cells("clmCodigo").Value)
            'If Not IsNothing(Cuenta) Then
            btnAceptar.Enabled = True
            'Else
            '    btnAceptar.Enabled = False
            'End If
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub dgv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.DoubleClick
        'Cuenta = Nothing
        'Cuenta = Bus.ObtenerdeDataGrid(dgv)
        If Me.dgv.SelectedRows.Count > 0 Then
            Cuenta = New CN.CuentaFiscalClass
            Me.Cuenta.Obtener(Me.dgv.SelectedRows(0).Cells("clmCodigo").Value)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'If Not IsNothing(Cuenta) Then
            '    btnAceptar.Enabled = True
            'Else
            '    btnAceptar.Enabled = False
            'End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Me.dgv.SelectedRows.Count > 0 Then
                Cuenta = New CN.CuentaFiscalClass
                Me.Cuenta.Obtener(Me.dgv.SelectedRows(0).Cells("clmCodigo").Value)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress, txtCta.KeyPress, txtSCta.KeyPress, txtSSCta.KeyPress, txtSSSCta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.MostrarCuentas()
        Else
            If Me.txtNombre.Text.Length >= 3 Then
                Me.MostrarCuentas()
            End If
        End If
    End Sub
    Private Sub MostrarCuentas()
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.chkAfe.CheckState <> CheckState.Indeterminate Then
                If Me.chkAfe.Checked = True Then
                    Filtro.Add(HC.VwCuentasFiscFields.AfectableCad = True)
                Else
                    Filtro.Add(HC.VwCuentasFiscFields.AfectableCad = False)
                End If
            End If

            If Me.chkBan.CheckState <> CheckState.Indeterminate Then
                If Me.chkBan.Checked = True Then
                    Filtro.Add(HC.VwCuentasFiscFields.BancosCad = chkBan.Checked)
                Else
                    Filtro.Add(HC.VwCuentasFiscFields.BancosCad = chkBan.Checked)
                End If
            End If

            If Me.chkDep.CheckState <> CheckState.Indeterminate Then
                If Me.chkDep.Checked = True Then
                    Filtro.Add(HC.VwCuentasFiscFields.DepartamentalizableCad = Me.chkDep.Checked)
                Else
                    Filtro.Add(HC.VwCuentasFiscFields.DepartamentalizableCad = chkDep.Checked)
                End If
            End If

            If Me.chkIna.CheckState <> CheckState.Indeterminate Then
                If Me.chkIna.Checked = True Then
                    Filtro.Add(HC.VwCuentasFiscFields.Inactiva = "SI")
                Else
                    Filtro.Add(HC.VwCuentasFiscFields.Inactiva = "NO")
                End If
            End If

            If Me.chkPre.CheckState <> CheckState.Indeterminate Then
                If Me.chkPre.Checked = True Then
                    Filtro.Add(HC.VwCuentasFiscFields.PresupuestoCad = Me.chkPre.Checked)
                Else
                    Filtro.Add(HC.VwCuentasFiscFields.PresupuestoCad = Me.chkPre.Checked)
                End If
            End If

            If Me.chkRes.CheckState <> CheckState.Indeterminate Then
                If Me.chkRes.Checked = True Then
                    Filtro.Add(HC.VwCuentasFiscFields.ResultadosCad = Me.chkRes.Checked)
                Else
                    Filtro.Add(HC.VwCuentasFiscFields.ResultadosCad = Me.chkRes.Checked)
                End If
            End If
            If Not Me.rdbAcr.Checked = True And Me.rdbDeu.Checked Then
                Filtro.Add(HC.VwCuentasFiscFields.NaturalezaCad = Chr(ClasesNegocio.CuentaContableNaturalezaEnum.DEUDORA))
            ElseIf Me.rdbAcr.Checked And Not Me.rdbDeu.Checked Then
                Filtro.Add(HC.VwCuentasFiscFields.NaturalezaCad = Chr(ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA))
            End If
            If Not Me.txtNombre.Text = "" Then
                Filtro.Add(HC.VwCuentasFiscFields.NombreCuenta Mod String.Format("%{0}%", Me.txtNombre.Text))
            End If
            If Not Me.txtCta.Text = "0000" Then
                Filtro.Add(HC.VwCuentasFiscFields.Cta = Me.txtCta.Text)
            End If
            If Not Me.txtSCta.Text = "0000" Then
                Filtro.Add(HC.VwCuentasFiscFields.SubCta = Me.txtSCta.Text)
            End If
            If Not Me.txtSSCta.Text = "0000" Then
                Filtro.Add(HC.VwCuentasFiscFields.SsubCta = Me.txtSSCta.Text)
            End If
            If Not Me.txtSSSCta.Text = "0000" Then
                Filtro.Add(HC.VwCuentasFiscFields.SssubCta = Me.txtSSSCta.Text)
            End If

            Dim Lista As New TC.VwCuentasFiscTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            Me.dgv.AutoGenerateColumns = False
            Me.dgv.DataSource = Lista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class