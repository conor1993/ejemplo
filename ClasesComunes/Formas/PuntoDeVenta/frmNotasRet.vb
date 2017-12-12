Imports System.Data.SqlClient

Public Class frmNotasRet
    Public lnCantidad As Decimal = 0D
    Dim index As Integer = 0

    

    Private Sub frmPagoEfectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            'Case Chr(13)
            '    BtnAceptar_Click(sender, New System.EventArgs())
            Case Chr(27)
                BtnCancelar_Click(sender, New System.EventArgs())
        End Select
    End Sub

    Private Sub VentaPgoEfectivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgvNotasRet.AutoGenerateColumns = False
        ObtenerNotasRetenidas()
        dgvNotasRet.Focus()
        '#If DEBUG Then
        '        dgvNotasRet.Columns(clmIdInterno.Index).Visible = True
        '#End If

        If dgvNotasRet.RowCount = 1 Then
            SendKeys.Send("{ENTER}")
        End If

        'dgvNotasRet.CurrentCell = dgvNotasRet.Rows[0].Cells[0]
        'dgvNotasRet.CurrentCell = dgvNotasRet.CurrentRow.Cells(0)
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    'Private Sub dgvNotasRet_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotasRet.CellContentDoubleClick
    '    BtnAceptar_Click(sender, New System.EventArgs())
    'End Sub

    Private Sub dgvNotasRet_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvNotasRet.SelectionChanged
        Indice = CInt(dgvNotasRet.CurrentRow.Cells(clmIdInterno.Index).Value)
    End Sub

    Public Property Indice() As Integer
        Get
            Return index
        End Get
        Set(value As Integer)
            index = value
        End Set
    End Property

    Private Sub dgvNotasRet_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvNotasRet.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnAceptar_Click(sender, New System.EventArgs())
        End If

    End Sub

    Public Sub ObtenerNotasRetenidas()
        Try
            dgvNotasRet.AutoGenerateColumns = False
            Dim resultado As New DataSet()
            Dim str As String = "select * from dbo.PVNotasVentaRetCab "
            Dim cmd As SqlCommand = New SqlCommand(str, New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))
            cmd.CommandType = CommandType.Text
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.SelectCommand.CommandTimeout = 300

            Dim DS As DataSet
            adapter.Fill(resultado)
            cmd.Dispose()

            If resultado.Tables(0).Rows.Count > 0 Then
                dgvNotasRet.DataSource = resultado.Tables(0)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class