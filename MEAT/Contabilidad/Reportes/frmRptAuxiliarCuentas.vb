Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmRptAuxiliarCuentas

#Region "Miembros"
    Dim Estado As FormState
#End Region

#Region "Metodos"
    Private Function ValidarFechas() As Boolean
        If ultdtpInicial.Value Is Nothing OrElse ultdtpFinal.Value Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.AUXILIAR_CONTABLE, 0)
        End If
    End Function

    Public Sub ObtenerCuentaContable(ByVal EsCuentaInicial As Boolean)
        Dim CuentaContable As New CC.CuentaContableCollection
        Dim Cta As String = ""
        Dim SubCta As String = ""
        Dim SsubCta As String = ""
        Dim SssubCta As String = ""

        If EsCuentaInicial Then
            Cta = txtIniCuentaP1.Text.PadLeft(4, "0")
            SubCta = txtIniCuentaP2.Text.PadLeft(4, "0")
            SsubCta = txtIniCuentaP3.Text.PadLeft(4, "0")
            SssubCta = txtIniCuentaP4.Text.PadLeft(4, "0")
        Else
            Cta = txtFinCuentaP1.Text.PadLeft(4, "0")
            SubCta = txtFinCuentaP2.Text.PadLeft(4, "0")
            SsubCta = txtFinCuentaP3.Text.PadLeft(4, "0")
            SssubCta = txtFinCuentaP4.Text.PadLeft(4, "0")
        End If
        CuentaContable.GetMulti(HC.CuentaContableFields.Cta = Cta And HC.CuentaContableFields.SubCta = SubCta And HC.CuentaContableFields.SsubCta = SsubCta And HC.CuentaContableFields.SssubCta = SssubCta)

        If CuentaContable.Count > 0 Then
            If EsCuentaInicial Then
                txtIniCuentaDescripcion.Text = CuentaContable(0).NomCuenta
            Else
                txtFinCuentaDescripcion.Text = CuentaContable(0).NomCuenta
            End If
        Else
            If EsCuentaInicial Then
                txtIniCuentaDescripcion.Text = ""
            Else
                txtFinCuentaDescripcion.Text = ""
            End If
        End If
    End Sub

    Public Sub InicializarForma()
        Limpiar()
    End Sub

#Region "Acciones"
    Public Sub Limpiar()
        Estado = FormState.Limpiar
        txtIniCuentaP1.Text = "0000"
        txtIniCuentaP2.Text = "0000"
        txtIniCuentaP3.Text = "0000"
        txtIniCuentaP4.Text = "0000"
        txtFinCuentaP1.Text = "0000"
        txtFinCuentaP2.Text = "0000"
        txtFinCuentaP3.Text = "0000"
        txtFinCuentaP4.Text = "0000"
        ultdtpInicial.Value = Nothing
        ultdtpFinal.Value = Nothing
    End Sub

    Public Sub Imprimir()
        Estado = FormState.Imprimir
        ValidarFechas()
        PictureBox1.Visible = True
        Controlador.ReporteAuxiliarContable(ultdtpInicial.Value, ultdtpFinal.Value, txtIniCuentaP1.Text & txtIniCuentaP2.Text & txtIniCuentaP3.Text & txtIniCuentaP4.Text, txtFinCuentaP1.Text & txtFinCuentaP2.Text & txtFinCuentaP3.Text & txtFinCuentaP4.Text)
    End Sub

    Public Sub Salir()
        Estado = FormState.Salir
        Me.Close()
    End Sub
#End Region
#End Region

#Region "Eventos"
    Private Sub frmBalanceGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarForma()
    End Sub

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
        PictureBox1.Visible = False
    End Sub

    Private Sub Digitos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIniCuentaP1.KeyPress, txtIniCuentaP2.KeyPress, txtIniCuentaP3.KeyPress, txtIniCuentaP4.KeyPress, txtFinCuentaP1.KeyPress, txtFinCuentaP2.KeyPress, txtFinCuentaP3.KeyPress, txtFinCuentaP4.KeyPress
        Utilerias.ValidarEntradaNumerosEnteros(sender, e)
    End Sub

    Private Sub CuentaInicial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIniCuentaP1.KeyDown, txtIniCuentaP2.KeyDown, txtIniCuentaP3.KeyDown, txtIniCuentaP4.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim BusquedaCuentasContables As New BusquedaCuentasContablesForm

            If BusquedaCuentasContables.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtIniCuentaP1.Text = BusquedaCuentasContables.CuentaContable.CuentaMayor
                txtIniCuentaP2.Text = BusquedaCuentasContables.CuentaContable.SubCuenta
                txtIniCuentaP3.Text = BusquedaCuentasContables.CuentaContable.SSubCuenta
                txtIniCuentaP4.Text = BusquedaCuentasContables.CuentaContable.SSSubCuenta
            End If
        End If
    End Sub

    Private Sub CuentaFinal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFinCuentaP1.KeyDown, txtFinCuentaP2.KeyDown, txtFinCuentaP3.KeyDown, txtFinCuentaP4.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim BusquedaCuentasContables As New BusquedaCuentasContablesForm

            If BusquedaCuentasContables.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtFinCuentaP1.Text = BusquedaCuentasContables.CuentaContable.CuentaMayor
                txtFinCuentaP2.Text = BusquedaCuentasContables.CuentaContable.SubCuenta
                txtFinCuentaP3.Text = BusquedaCuentasContables.CuentaContable.SSubCuenta
                txtFinCuentaP4.Text = BusquedaCuentasContables.CuentaContable.SSSubCuenta
            End If
        End If
    End Sub

    Private Sub Cuentas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIniCuentaP1.Leave, txtIniCuentaP2.Leave, txtIniCuentaP3.Leave, txtIniCuentaP4.Leave, txtFinCuentaP1.Leave, txtFinCuentaP2.Leave, txtFinCuentaP3.Leave, txtFinCuentaP4.Leave
        Dim Campo As TextBox = CType(sender, TextBox)
        Campo.Text = Campo.Text.PadLeft(4, "0")
    End Sub

    Private Sub txtIniCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIniCuentaP1.TextChanged, txtIniCuentaP2.TextChanged, txtIniCuentaP3.TextChanged, txtIniCuentaP4.TextChanged
        Utilerias.RunControlException(Me, "ObtenerCuentaContable", New Object() {True})
    End Sub

    Private Sub txtFinCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinCuentaP1.TextChanged, txtFinCuentaP2.TextChanged, txtFinCuentaP3.TextChanged, txtFinCuentaP4.TextChanged
        Utilerias.RunControlException(Me, "ObtenerCuentaContable", New Object() {False})
    End Sub

    Private Sub txtCuentas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIniCuentaP1.Enter, txtIniCuentaP2.Enter, txtIniCuentaP3.Enter, txtIniCuentaP4.Enter, txtFinCuentaP1.Enter, txtFinCuentaP2.Enter, txtFinCuentaP3.Enter, txtFinCuentaP4.Enter
        If Not String.IsNullOrEmpty(CType(sender, TextBox).Text) AndAlso CType(sender, TextBox).Text = "0000" Then
            CType(sender, TextBox).Text = String.Empty
        End If
    End Sub
#End Region
End Class