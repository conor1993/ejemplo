Imports HC = Integralab.ORM.HelperClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports Integralab.Controles

Public Class BusquedaCuentasContablesForm

    Private Cuenta As ClasesNegocio.CuentaContableClass
    Private Bus As New Integra.Clases.BusquedaClass(Of ClasesNegocio.CuentaContableClass)

    Public IdCuentaContableBusqueda As Integer

#Region "Propiedades"
    Private _NaturalezaDefault As ClasesNegocio.CuentaContableNaturalezaCondicionEnum = ClasesNegocio.CuentaContableNaturalezaCondicionEnum.TODAS
    Public Property NarutalezaDefault(Optional ByVal bloquearControl As Boolean = False) As ClasesNegocio.CuentaContableNaturalezaCondicionEnum
        Get
            Return _NaturalezaDefault
        End Get
        Set(ByVal value As ClasesNegocio.CuentaContableNaturalezaCondicionEnum)
            _NaturalezaDefault = value
            Me.gpoNaturaleza.Enabled = Not bloquearControl
        End Set
    End Property

    Private _ResultadosDefault As ClasesNegocio.CondicionAsignadaEnum = ClasesNegocio.CondicionAsignadaEnum.TODOS
    Public Property ResultadosDefault(Optional ByVal bloquearControl As Boolean = False) As ClasesNegocio.CondicionAsignadaEnum
        Get
            Return _ResultadosDefault
        End Get
        Set(ByVal value As ClasesNegocio.CondicionAsignadaEnum)
            _ResultadosDefault = value
            Me.chkRes.Enabled = Not bloquearControl
        End Set
    End Property

    Private _PresupuestoDefault As ClasesNegocio.CondicionAsignadaEnum = ClasesNegocio.CondicionAsignadaEnum.TODOS
    Public Property PresupuestoDefault(Optional ByVal bloquearControl As Boolean = False) As ClasesNegocio.CondicionAsignadaEnum
        Get
            Return _PresupuestoDefault
        End Get
        Set(ByVal value As ClasesNegocio.CondicionAsignadaEnum)
            _PresupuestoDefault = value
            Me.chkPre.Enabled = Not bloquearControl
        End Set
    End Property

    Private _DepartamentalizableDefault As ClasesNegocio.CondicionAsignadaEnum = ClasesNegocio.CondicionAsignadaEnum.TODOS
    Public Property DepartamentalizableDefault(Optional ByVal bloquearControl As Boolean = False) As ClasesNegocio.CondicionAsignadaEnum
        Get
            Return _DepartamentalizableDefault
        End Get
        Set(ByVal value As ClasesNegocio.CondicionAsignadaEnum)
            _DepartamentalizableDefault = value
            Me.chkDep.Enabled = Not bloquearControl
        End Set
    End Property

    Private _BancosDefault As ClasesNegocio.CondicionAsignadaEnum = ClasesNegocio.CondicionAsignadaEnum.TODOS
    Public Property BancosDefault(Optional ByVal bloquearControl As Boolean = False) As ClasesNegocio.CondicionAsignadaEnum
        Get
            Return _BancosDefault
        End Get
        Set(ByVal value As ClasesNegocio.CondicionAsignadaEnum)
            _BancosDefault = value
            Me.chkBan.Enabled = Not bloquearControl
        End Set
    End Property

    Private _AfectableDefault As ClasesNegocio.CondicionAsignadaEnum = ClasesNegocio.CondicionAsignadaEnum.TODOS
    Public Property AfectableDefault(Optional ByVal bloquearControl As Boolean = False) As ClasesNegocio.CondicionAsignadaEnum
        Get
            Return _AfectableDefault
        End Get
        Set(ByVal value As ClasesNegocio.CondicionAsignadaEnum)
            _AfectableDefault = value
            Me.chkAfe.Enabled = Not bloquearControl
        End Set
    End Property

    Private _InactivaDefault As ClasesNegocio.CondicionAsignadaEnum = ClasesNegocio.CondicionAsignadaEnum.TODOS
    Public Property InactivaDefault(Optional ByVal bloquearControl As Boolean = False) As ClasesNegocio.CondicionAsignadaEnum
        Get
            Return _InactivaDefault
        End Get
        Set(ByVal value As ClasesNegocio.CondicionAsignadaEnum)
            _InactivaDefault = value
            Me.chkIna.Enabled = Not bloquearControl
        End Set
    End Property

    Private _CtaDefault As String = "0000"
    Public Property CtaDefault(Optional ByVal bloquearControl As Boolean = False) As String
        Get
            Return _CtaDefault
        End Get
        Set(ByVal value As String)
            _CtaDefault = value
            Me.txtCta.Enabled = Not bloquearControl
        End Set
    End Property

    Private _SCtaDefault As String = "0000"
    Public Property SCtaDefault(Optional ByVal bloquearControl As Boolean = False) As String
        Get
            Return _SCtaDefault
        End Get
        Set(ByVal value As String)
            _SCtaDefault = value
            Me.txtSCta.Enabled = Not bloquearControl
        End Set
    End Property

    Private _SSCtaDefault As String = "0000"
    Public Property SSCtaDefault(Optional ByVal bloquearControl As Boolean = False) As String
        Get
            Return _SSCtaDefault
        End Get
        Set(ByVal value As String)
            _SSCtaDefault = value
            Me.txtSSCta.Enabled = Not bloquearControl
        End Set
    End Property

    Private _SSSCtaDefault As String = "0000"
    Public Property SSSCtaDefault(Optional ByVal bloquearControl As Boolean = False) As String
        Get
            Return _SSSCtaDefault
        End Get
        Set(ByVal value As String)
            _SSSCtaDefault = value
            Me.txtSSSCta.Enabled = Not bloquearControl
        End Set
    End Property
#End Region

    Public Property CuentaContable() As ClasesNegocio.CuentaContableClass
        Get
            Return Cuenta
        End Get
        Set(ByVal value As ClasesNegocio.CuentaContableClass)
            Cuenta = value
        End Set
    End Property

    Public WriteOnly Property BloquearCaracteristicas() As Boolean
        Set(ByVal value As Boolean)
            gpoCaracteristicas.Enabled = Not value
        End Set
    End Property

    'Private afec As Windows.Forms.CheckState = CheckState.Indeterminate
    'Public Property Afectables() As Windows.Forms.CheckState
    '    Get
    '        Return afec
    '    End Get
    '    Set(ByVal value As Windows.Forms.CheckState)
    '        afec = value
    '    End Set
    'End Property

    'Private depa As Windows.Forms.CheckState = CheckState.Indeterminate
    'Public Property Departamentalizable() As Windows.Forms.CheckState
    '    Get
    '        Return depa
    '    End Get
    '    Set(ByVal value As Windows.Forms.CheckState)
    '        depa = value
    '    End Set
    'End Property

    'Private bans As Windows.Forms.CheckState = CheckState.Indeterminate
    'Public Property Bancos() As Windows.Forms.CheckState
    '    Get
    '        Return bans
    '    End Get
    '    Set(ByVal value As Windows.Forms.CheckState)
    '        bans = value
    '    End Set
    'End Property

    Public Var As Boolean

    Private Sub BusquedaCuentasContablesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BusquedaCuentasContablesForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BusquedaCuentasContablesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        Me.btnAceptar.Enabled = False
        Me.btnBuscar_Click(sender, New EventArgs)
    End Sub


    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Cuenta = Nothing
        txtNombre.Clear()
        txtCta.Text = Me.CtaDefault
        txtSCta.Text = Me.SCtaDefault
        txtSSCta.Text = Me.SSCtaDefault
        txtSSSCta.Text = Me.SSSCtaDefault

        If Var Then
            Select Case Me.NarutalezaDefault
                Case ClasesNegocio.CuentaContableNaturalezaCondicionEnum.TODAS
                    rdbAcr.Checked = False
                    rdbDeu.Checked = False
                Case ClasesNegocio.CuentaContableNaturalezaCondicionEnum.ACREEDORAS
                    rdbAcr.Checked = True
                Case ClasesNegocio.CuentaContableNaturalezaCondicionEnum.DEUDORAS
                    rdbDeu.Checked = True
            End Select

            Select Case Me.ResultadosDefault
                Case ClasesNegocio.CondicionAsignadaEnum.TODOS
                    chkRes.CheckState = CheckState.Indeterminate
                Case Else
                    chkRes.Checked = CType(Me.ResultadosDefault, Boolean)
            End Select

            Select Case Me.AfectableDefault
                Case ClasesNegocio.CondicionAsignadaEnum.TODOS
                    chkAfe.CheckState = CheckState.Indeterminate
                Case Else
                    chkAfe.Checked = CType(Me.AfectableDefault, Boolean)
            End Select

            Select Case Me.BancosDefault
                Case ClasesNegocio.CondicionAsignadaEnum.TODOS
                    chkBan.CheckState = CheckState.Indeterminate
                Case Else
                    chkBan.Checked = CType(Me.BancosDefault, Boolean)
            End Select

            Select Case Me.DepartamentalizableDefault
                Case ClasesNegocio.CondicionAsignadaEnum.TODOS
                    chkDep.CheckState = CheckState.Indeterminate
                Case Else
                    chkDep.Checked = CType(Me.DepartamentalizableDefault, Boolean)
            End Select

            Select Case Me.InactivaDefault
                Case ClasesNegocio.CondicionAsignadaEnum.TODOS
                    chkIna.CheckState = CheckState.Indeterminate
                Case Else
                    chkIna.Checked = CType(Me.InactivaDefault, Boolean)
            End Select

            Select Case Me.PresupuestoDefault
                Case ClasesNegocio.CondicionAsignadaEnum.TODOS
                    chkPre.CheckState = CheckState.Indeterminate
                Case Else
                    chkPre.Checked = CType(Me.PresupuestoDefault, Boolean)
            End Select
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.chkAfe.CheckState <> CheckState.Indeterminate Then
                If Me.chkAfe.Checked = True Then
                    Filtro.Add(HC.VwContCuentasFields.AfectableCad = True)
                Else
                    Filtro.Add(HC.VwContCuentasFields.AfectableCad = False)
                End If
            End If

            If Me.chkBan.CheckState <> CheckState.Indeterminate Then
                If Me.chkBan.Checked = True Then
                    Filtro.Add(HC.VwContCuentasFields.BancosCad = chkBan.Checked)
                Else
                    Filtro.Add(HC.VwContCuentasFields.BancosCad = chkBan.Checked)
                End If
            End If

            If Me.chkDep.CheckState <> CheckState.Indeterminate Then
                If Me.chkDep.Checked = True Then
                    Filtro.Add(HC.VwContCuentasFields.DepartamentalizableCad = Me.chkDep.Checked)
                Else
                    Filtro.Add(HC.VwContCuentasFields.DepartamentalizableCad = chkDep.Checked)
                End If
            End If

            If Me.chkIna.CheckState <> CheckState.Indeterminate Then
                If Me.chkIna.Checked = True Then
                    Filtro.Add(HC.VwContCuentasFields.Inactiva = "SI")
                Else
                    Filtro.Add(HC.VwContCuentasFields.Inactiva = "NO")
                End If
            End If

            If Me.chkPre.CheckState <> CheckState.Indeterminate Then
                If Me.chkPre.Checked = True Then
                    Filtro.Add(HC.VwContCuentasFields.PresupuestoCad = Me.chkPre.Checked)
                Else
                    Filtro.Add(HC.VwContCuentasFields.PresupuestoCad = Me.chkPre.Checked)
                End If
            End If

            If Me.chkRes.CheckState <> CheckState.Indeterminate Then
                If Me.chkRes.Checked = True Then
                    Filtro.Add(HC.VwContCuentasFields.ResultadosCad = Me.chkRes.Checked)
                Else
                    Filtro.Add(HC.VwContCuentasFields.ResultadosCad = Me.chkRes.Checked)
                End If
            End If

            If Not Me.rdbAcr.Checked = True And Me.rdbDeu.Checked Then
                Filtro.Add(HC.VwContCuentasFields.NaturalezaCad = Chr(ClasesNegocio.CuentaContableNaturalezaEnum.DEUDORA))
            ElseIf Me.rdbAcr.Checked And Not Me.rdbDeu.Checked Then
                Filtro.Add(HC.VwContCuentasFields.NaturalezaCad = Chr(ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA))
            End If

            If Not Me.txtNombre.Text = "" Then
                Filtro.Add(HC.VwContCuentasFields.NombreCuenta Mod String.Format("%{0}%", Me.txtNombre.Text))
            End If
            If Not Me.txtCta.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.Cta = Me.txtCta.Text)
            End If
            If Not Me.txtSCta.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.SubCta = Me.txtSCta.Text)
            End If
            If Not Me.txtSSCta.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.SsubCta = Me.txtSSCta.Text)
            End If
            If Not Me.txtSSSCta.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.SssubCta = Me.txtSSSCta.Text)
            End If


            Dim Lista As New TC.VwContCuentasTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            Me.dgv.AutoGenerateColumns = False
            Me.dgv.DataSource = Lista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Dim lista As New TC.VwContCuentasTypedView
        'Dim filtro As New OC.PredicateExpression

        'If Not Me.chkAfe.CheckState = CheckState.Indeterminate Then
        '    filtro.Add(HC.VwContCuentasFields.AfectableCad = Me.chkAfe.Checked)
        'End If

        'If Not Me.chkBan.CheckState = CheckState.Indeterminate Then
        '    filtro.Add(HC.VwContCuentasFields.BancosCad = Me.chkBan.Checked)
        'End If

        'If Not Me.chkDep.CheckState = CheckState.Indeterminate Then
        '    filtro.Add(HC.VwContCuentasFields.DepartamentalizableCad = Me.chkDep.Checked)
        'End If

        'If Not Me.chkIna.CheckState = CheckState.Indeterminate Then
        '    If Me.chkIna.Checked Then
        '        filtro.Add(HC.VwContCuentasFields.Inactiva = "SI")
        '    Else
        '        filtro.Add(HC.VwContCuentasFields.Inactiva = "NO")
        '    End If
        'End If

        'If Not Me.chkPre.CheckState = CheckState.Indeterminate Then
        '    filtro.Add(HC.VwContCuentasFields.PresupuestoCad = Me.chkPre.Checked)
        'End If

        'If Not Me.chkRes.CheckState = CheckState.Indeterminate Then
        '    filtro.Add(HC.VwContCuentasFields.ResultadosCad = Me.chkRes.Checked)
        'End If

        'If Me.rdbDeu.Checked Then
        '    filtro.Add(HC.VwContCuentasFields.NaturalezaCad = "D"c)
        'ElseIf Me.rdbAcr.Checked Then
        '    filtro.Add(HC.VwContCuentasFields.NaturalezaCad = "A"c)
        'End If

        'filtro.Add(HC.VwContCuentasFields.Cta Mod String.Format("%{0}%", Me.txtCta.Text))
        'filtro.Add(HC.VwContCuentasFields.SubCta Mod String.Format("%{0}%", Me.txtSCta.Text))
        'filtro.Add(HC.VwContCuentasFields.SsubCta Mod String.Format("%{0}%", Me.txtSSCta.Text))
        'filtro.Add(HC.VwContCuentasFields.SssubCta Mod String.Format("%{0}%", Me.txtSSSCta.Text))
        'filtro.Add(HC.VwContCuentasFields.NombreCuenta Mod String.Format("%{0}%", Me.txtNombre.Text))

        'lista.Fill(0, Nothing, True, filtro)

        'Me.dgv.AutoGenerateColumns = False
        'Me.dgv.DataSource = lista

        '    Dim bAfe As Object = Nothing
        '    Dim bBan As Object = Nothing
        '    Dim bDep As Object = Nothing
        '    Dim bIna As Object = Nothing
        '    Dim bPre As Object = Nothing
        '    Dim bRes As Object = Nothing
        '    Dim bNat As Object = Nothing
        '    If chkAfe.CheckState <> CheckState.Indeterminate Then bAfe = chkAfe.Checked
        '    If chkBan.CheckState <> CheckState.Indeterminate Then bBan = chkBan.Checked
        '    If chkDep.CheckState <> CheckState.Indeterminate Then bDep = chkDep.Checked
        '    If chkIna.CheckState <> CheckState.Indeterminate Then bIna = Not chkIna.Checked
        '    If chkPre.CheckState <> CheckState.Indeterminate Then bPre = chkPre.Checked
        '    If chkRes.CheckState <> CheckState.Indeterminate Then bRes = chkRes.Checked
        '    If Not rdbAcr.Checked And rdbDeu.Checked Then
        '        bNat = ClasesNegocio.CuentaContableNaturalezaEnum.DEUDORA
        '    ElseIf rdbAcr.Checked And Not rdbDeu.Checked Then
        '        bNat = ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA
        '    End If
        '    Cuentas.Obtener(bIna, txtNombre.Text, txtCta.Text, txtSCta.Text, txtSSCta.Text, txtSSSCta.Text, bNat, bRes, bPre, bDep, bBan, bAfe)
    End Sub

    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        'Cuenta = Nothing
        'Cuenta = Bus.ObtenerdeDataGrid(dgv)
        btnAceptar.Enabled = True
    End Sub

    Private Sub dgv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.DoubleClick
        If Me.dgv.SelectedRows.Count > 0 Then
            Cuenta = New ClasesNegocio.CuentaContableClass

            If Me.Cuenta.Obtener(Integer.Parse(Me.dgv.SelectedRows(0).Cells(Me.clmCodigo.Index).Value.ToString)) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgv.SelectedRows.Count > 0 Then
            Cuenta = New ClasesNegocio.CuentaContableClass

            If Me.Cuenta.Obtener(Integer.Parse(Me.dgv.SelectedRows(0).Cells(Me.clmCodigo.Index).Value.ToString)) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress, txtCta.KeyPress, txtSCta.KeyPress, txtSSCta.KeyPress, txtSSSCta.KeyPress
        If e.KeyChar = Chr(13) Then
            btnBuscar_Click(sender, New EventArgs)
        ElseIf Me.txtNombre.Text.Length >= 3 Then
            btnBuscar_Click(sender, New EventArgs)
        End If
    End Sub
End Class