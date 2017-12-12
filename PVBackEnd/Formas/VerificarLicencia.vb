Imports System.Data.SqlClient
Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports IntegraLab.FormasSeguridad
Public Class frmVerificarLicencia
    Dim Seg As IntegraLab.Seguridad.Classes.Seguridad
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal seguridad As IntegraLab.Seguridad.Classes.Seguridad)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Seg = seguridad
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmVerificarLicencia_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If

        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then

        End If
    End Sub

    'Private Declare Auto Function SendMessage Lib "user32" ( ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr ) As IntPtr

    '   Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '       SendMessage(Me.ActiveMdiChild.Handle, msg.Msg, msg.WParam, msg.LParam)
    '       'Return MyBase.ProcessCmdKey(msg, keyData)
    '   End Function

    Private Sub frmVerificarLicencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Campo1.Focus()
    End Sub

    Private Sub Campo1_TextChanged(sender As System.Object, e As System.EventArgs) Handles Campo1.TextChanged
        If Campo1.Text.Trim.Length >= 8 Then
            Campo2.Focus()
        End If
    End Sub

    Private Sub Campo2_TextChanged(sender As System.Object, e As System.EventArgs) Handles Campo2.TextChanged
        If Campo2.Text.Trim.Length >= 4 Then
            Campo3.Focus()
        End If
    End Sub

    Private Sub Campo3_TextChanged(sender As System.Object, e As System.EventArgs) Handles Campo3.TextChanged
        If Campo3.Text.Trim.Length >= 4 Then
            Campo4.Focus()
        End If
    End Sub

    Private Sub Campo4_TextChanged(sender As System.Object, e As System.EventArgs) Handles Campo4.TextChanged
        If Campo4.Text.Trim.Length >= 4 Then
            Campo5.Focus()
        End If
    End Sub

    Private Sub btnActivar_Click(sender As System.Object, e As System.EventArgs) Handles btnActivar.Click
        Try
            If Validar() = False Then Return
            Dim Serial As String = ""
            Serial = Campo1.Text.Trim() & "-" & Campo2.Text.Trim() & "-" & Campo3.Text.Trim() & "-" & Campo4.Text.Trim() & "-" & Campo5.Text.Trim()
            Dim constr As String = ""
            constr = "Data Source=integrabc.dyndns.org,41433;" & _
                        "Initial Catalog=IntegraSidevi;" & _
                        "User ID=PV;" & _
                        "Password=int3gr@;"
            Dim con As New SqlClient.SqlConnection(constr)
            Dim cmd1 As SqlCommand = New SqlCommand("dbo.SP_validacionlicenciaPV", con)
            cmd1.CommandType = CommandType.StoredProcedure
            cmd1.Parameters.Add("@Serial", SqlDbType.VarChar, 36, ParameterDirection.Input).Value = Serial
            'cmd1.Parameters.Add("@YY", SqlDbType.VarChar, 50, ParameterDirection.Input).Value = "'" & YY & "'"
            cmd1.Parameters.Add("@Validar", SqlDbType.Bit).Direction = ParameterDirection.Output
            'cmd1.Parameters("@Validar").Direction = ParameterDirection.Output
            cmd1.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
            ' cmd1.Parameters("@Mensaje").Direction = ParameterDirection.Output
            con.Open()
            cmd1.ExecuteNonQuery()

            If cmd1.Parameters("@Validar").Value = True Then
                con.Close()
                con = New SqlConnection(Seg.SeguridadConnectionString)
                con.Open()
                cmd1 = New SqlCommand("update config set config = 1", con)
                cmd1.ExecuteNonQuery()
                con.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show(cmd1.Parameters("@Mensaje").Value.ToString())
                Me.DialogResult = Windows.Forms.DialogResult.Cancel

            End If


            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function Validar() As Boolean
        Dim Serial As String = ""
        Serial = Campo1.Text.Trim() & "-" & Campo2.Text.Trim() & "-" & Campo3.Text.Trim() & "-" & Campo4.Text.Trim() & "-" & Campo5.Text.Trim()

        If Serial.Length < 36 Then
            MessageBox.Show("La licencia esta incompleta, favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Campo1.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub Campo5_TextChanged(sender As System.Object, e As System.EventArgs) Handles Campo5.TextChanged
        If Campo5.Text.Trim.Length >= 12 Then
            btnActivar.Focus()
        End If
    End Sub

    Private Sub frmVerificarLicencia_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Campo1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Campo1.KeyDown

    End Sub
End Class