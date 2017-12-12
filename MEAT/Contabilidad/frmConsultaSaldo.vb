Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmConsultaSaldo

    Private Sub ConsultarCuenta()
        Try
            If Me.txtCuenta.Text = "0000" AndAlso Me.txtSubCuenta.Text = "0000" AndAlso _
                Me.txtSSubCuenta.Text = "0000" AndAlso Me.txtSSSubCuenta.Text = "0000" Then
                Me.CuentaContableC.Clear()
                Exit Sub
            End If

            Dim col As New CC.CuentaContableCollection

            col.GetMulti(HC.CuentaContableFields.Cta = Me.txtCuenta.Text And _
                        HC.CuentaContableFields.SubCta = Me.txtSubCuenta.Text And _
                        HC.CuentaContableFields.SsubCta = Me.txtSSubCuenta.Text And _
                        HC.CuentaContableFields.SssubCta = Me.txtSSSubCuenta.Text, 1)

            If col.Count > 0 Then
                'cuenta = New ClasesNegocio.CuentaContableClass(col(0))
                Me.CuentaContableC.Clear()
                Me.CuentaContableC.Add(New ClasesNegocio.CuentaContableClass(col(0)))
            Else
                Me.CuentaContableC.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSubCuenta_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSubCuenta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSubCuenta.Text = "" Then
                Me.txtSubCuenta.Text = "0000"
            ElseIf IsNumeric(Me.txtSubCuenta.Text) Then
                Me.txtSubCuenta.Text = CInt(Me.txtSubCuenta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub txtCuenta_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtCuenta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCuenta.Text = "" Then
                Me.txtCuenta.Text = "0000"
            ElseIf IsNumeric(Me.txtCuenta.Text) Then
                Me.txtCuenta.Text = CInt(Me.txtCuenta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub txtSSubCuenta_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSSubCuenta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSSubCuenta.Text = "" Then
                Me.txtSSubCuenta.Text = "0000"
            ElseIf IsNumeric(Me.txtSSubCuenta.Text) Then
                Me.txtSSubCuenta.Text = CInt(Me.txtSSubCuenta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub txtSSSubCuenta_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSSSubCuenta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSSSubCuenta.Text = "" Then
                Me.txtSSSubCuenta.Text = "0000"
            ElseIf IsNumeric(Me.txtSSSubCuenta.Text) Then
                Me.txtSSSubCuenta.Text = CInt(Me.txtSSSubCuenta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub frmConsultaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.txtCuenta.Text = "0000"
        Me.txtSubCuenta.Text = "0000"
        Me.txtSSubCuenta.Text = "0000"
        Me.txtSSSubCuenta.Text = "0000"
        Me.CuentaContableC.Clear()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Dim ventana As New BusquedaCuentasContablesForm

        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CuentaContableC.Clear()
            Me.CuentaContableC.Add(ventana.CuentaContable)
            Me.txtCuenta.Text = ventana.CuentaContable.CuentaMayor
            Me.txtSubCuenta.Text = ventana.CuentaContable.SubCuenta
            Me.txtSSubCuenta.Text = ventana.CuentaContable.SSubCuenta
            Me.txtSSSubCuenta.Text = ventana.CuentaContable.SSubCuenta
        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.TextChanged

    End Sub
End Class