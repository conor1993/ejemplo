Imports CN = ClasesNegocio
Public Class FrmBusqInvFisico

    Private Sub FemBusqInvFisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim AlmacenesCol As New CN.AlmacenCollectionClass
        AlmacenesCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        CmbAlmacenes.SelectedIndex = -1
        CmbAlmacenes.ValueMember = "Codigo"
        CmbAlmacenes.DisplayMember = "Descripcion"
        CmbAlmacenes.DataSource = AlmacenesCol


    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            If Me.CmbAlmacenes.SelectedIndex > -1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub FrmBusqInvFisico_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
    '    If e.KeyChar = ChrW(Keys.Enter) Then
    '        SendKeys.Send(Keys.Tab)
    '        e.Handled = True
    '    End If

    'End Sub

    

    Private Sub CmbAlmacenes_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CmbAlmacenes.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            ' e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space)
            e.Handled = True
            'Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            SendKeys.Send(Chr(Keys.Tab))

        End If
    End Sub
End Class