Public Class frmMetodoPagoEmergente
    Dim CveMetodoPago As String
    Dim NoCta As String
    Private Sub frmMetodoPagoEmergente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        llenarMetodosPago()
    End Sub

    Public Property MetodoPagoCVE() As String
        Get
            Return Me.CveMetodoPago
        End Get
        Set(ByVal Value As String)
            Me.CveMetodoPago = Value
        End Set
    End Property

    Public Property NumeroCuenta() As String
        Get
            Return Me.NoCta
        End Get
        Set(ByVal Value As String)
            Me.NoCta = Value
        End Set
    End Property

    Public Sub llenarMetodosPago()
       ' Declare DataTable
        Dim Table1 As New DataTable
        ' Define columns
        Table1.Columns.Add("Clave", GetType(System.String))
        Table1.Columns.Add("Concepto", GetType(System.String))

        Table1.Rows.Add("01", "Efectivo.")
        Table1.Rows.Add("02", "Cheque nominativo.")
        Table1.Rows.Add("03", "Transferencia electrónica de fondos.")
        Table1.Rows.Add("04", "Tarjeta de Crédito")
        Table1.Rows.Add("05", "Monedero Electrónico.")
        Table1.Rows.Add("06", "Dinero electrónico")
        Table1.Rows.Add("08", "Vales de despensa.")
        Table1.Rows.Add("28", "Tarjeta de Débito.")
        Table1.Rows.Add("29", "Tarjeta de Servicio.")
        Table1.Rows.Add("99", "Otros.")

        cmbFormasPago.DisplayMember = "Concepto"
        cmbFormasPago.ValueMember = "Clave"
        cmbFormasPago.DataSource = Table1
        cmbFormasPago.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If cmbFormasPago.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un metodo de pago.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        MetodoPagoCVE = CStr(cmbFormasPago.SelectedValue)
        NumeroCuenta = txtNoCta.Text.Trim()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MetodoPagoCVE = CStr("")
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub frmMetodoPagoEmergente_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub frmMetodoPagoEmergente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub Button1_Enter(sender As System.Object, e As System.EventArgs) Handles Button1.Enter
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderColor = Color.DodgerBlue
        Button1.FlatAppearance.BorderSize = 1

    End Sub
End Class