Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio
Imports System.Reflection

Public Class frmConsultaAnaliticaSaldos
    Dim cuenta As ClasesNegocio.CuentaContableClass

    Private Sub ConsultarCuenta()
        Try
            If Me.txtCta.Text = "0000" AndAlso Me.txtSubCta.Text = "0000" AndAlso _
                Me.txtSSubCta.Text = "0000" AndAlso Me.txtSSSubCta.Text = "0000" Then
                cuenta = Nothing
                Exit Sub
            End If

            Dim col As New CC.CuentaContableCollection

            col.GetMulti(HC.CuentaContableFields.Cta = Me.txtCta.Text And _
                        HC.CuentaContableFields.SubCta = Me.txtSubCta.Text And _
                        HC.CuentaContableFields.SsubCta = Me.txtSSubCta.Text And _
                        HC.CuentaContableFields.SssubCta = Me.txtSSSubCta.Text, 1)

            If col.Count > 0 Then
                cuenta = New ClasesNegocio.CuentaContableClass(col(0))
                Dim mes As String = Me.DateTimePicker1.Value.ToString("MMMM")
                mes = Char.ToUpper(mes.Chars(0)) & mes.Substring(1)

                Dim proCargo As PropertyInfo = GetType(ClasesNegocio.CuentaContableClass).GetProperty(mes & "Cargo")
                Dim proAbono As PropertyInfo = GetType(ClasesNegocio.CuentaContableClass).GetProperty(mes & "Abono")
                Dim proCargoAnt As PropertyInfo = GetType(ClasesNegocio.CuentaContableClass).GetProperty(mes & "Cargo")
                Dim proAbonoAnt As PropertyInfo = GetType(ClasesNegocio.CuentaContableClass).GetProperty(mes & "Abono")

                Dim cargo As Decimal = CDec(proCargo.GetValue(cuenta, Nothing))
                Dim abono As Decimal = CDec(proAbono.GetValue(cuenta, Nothing))
                Dim cargoAnt As Decimal = CDec(proCargoAnt.GetValue(cuenta, Nothing))
                Dim abonoAnt As Decimal = CDec(proAbonoAnt.GetValue(cuenta, Nothing))

                Me.txtCargoMes.Text = cargo.ToString("C2")
                Me.txtAbonoMes.Text = abono.ToString("C2")

                If cuenta.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA Then
                    Me.txtSaldoActual.Text = (abono - cargo).ToString("C2")

                    If Me.DateTimePicker1.Value.Month > 1 Then
                        Me.txtSaldoAnterior.Text = (abonoAnt - cargoAnt).ToString("C2")
                    Else
                        Me.txtSaldoAnterior.Text = cuenta.SaldoAñoAnterior.ToString("C2")
                    End If
                Else
                    Me.txtSaldoActual.Text = (cargo - abono).ToString("C2")

                    If Me.DateTimePicker1.Value.Month > 1 Then
                        Me.txtSaldoAnterior.Text = (cargoAnt - abonoAnt).ToString("C2")
                    Else
                        Me.txtSaldoAnterior.Text = cuenta.SaldoAñoAnterior.ToString("C2")
                    End If
                End If

                Dim polizas As New CC.PolizaDetalleCollection
                Dim rel As New OC.RelationCollection

                rel.Add(EC.PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId)
                polizas.GetMulti(HC.PolizaDetalleFields.CuentaContableId = cuenta.Codigo And HC.PolizaFields.Mes = Me.DateTimePicker1.Value.Month And HC.PolizaFields.Ano = Me.DateTimePicker1.Value.Year, 0, New OC.SortExpression(New OC.SortClause(HC.PolizaFields.FechaPoliza, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), rel)

                Dim detallePol As New ClasesNegocio.PolizaDetalleCollectionClass
                detallePol.RellenarMe(polizas)

                Me.DataGridView1.AutoGenerateColumns = False
                Me.DataGridView1.DataSource = detallePol
            Else
                cuenta = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCta.LostFocus
        If Me.txtCta.Text = "" Then
            Me.txtCta.Text = "0000"
        ElseIf IsNumeric(Me.txtCta.Text) Then
            Me.txtCta.Text = CInt(Me.txtCta.Text).ToString("0000")
        End If
    End Sub

    Private Sub txtCta_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtCta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCta.Text = "" Then
                Me.txtCta.Text = "0000"
            ElseIf IsNumeric(Me.txtCta.Text) Then
                Me.txtCta.Text = CInt(Me.txtCta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub txtSubCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubCta.LostFocus
        If Me.txtSubCta.Text = "" Then
            Me.txtSubCta.Text = "0000"
        ElseIf IsNumeric(Me.txtSubCta.Text) Then
            Me.txtSubCta.Text = CInt(Me.txtSubCta.Text).ToString("0000")
        End If
    End Sub

    Private Sub txtSubCta_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSubCta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSubCta.Text = "" Then
                Me.txtSubCta.Text = "0000"
            ElseIf IsNumeric(Me.txtSubCta.Text) Then
                Me.txtSubCta.Text = CInt(Me.txtSubCta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub txtSSubCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSubCta.LostFocus
        If Me.txtSSubCta.Text = "" Then
            Me.txtSSubCta.Text = "0000"
        ElseIf IsNumeric(Me.txtSSubCta.Text) Then
            Me.txtSSubCta.Text = CInt(Me.txtSSubCta.Text).ToString("0000")
        End If
    End Sub

    Private Sub txtSSubCta_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSSubCta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSSubCta.Text = "" Then
                Me.txtSSubCta.Text = "0000"
            ElseIf IsNumeric(Me.txtSSubCta.Text) Then
                Me.txtSSubCta.Text = CInt(Me.txtSSubCta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub txtSSSubCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSSubCta.LostFocus
        If Me.txtSSSubCta.Text = "" Then
            Me.txtSSSubCta.Text = "0000"
        ElseIf IsNumeric(Me.txtSubCta.Text) Then
            Me.txtSSSubCta.Text = CInt(Me.txtSSSubCta.Text).ToString("0000")
        End If
    End Sub

    Private Sub txtSSSubCta_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSSSubCta.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSSSubCta.Text = "" Then
                Me.txtSSSubCta.Text = "0000"
            ElseIf IsNumeric(Me.txtSubCta.Text) Then
                Me.txtSSSubCta.Text = CInt(Me.txtSSSubCta.Text).ToString("0000")
            End If

            ConsultarCuenta()
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.DateTimePicker1.Value = Now
        Me.DataGridView1.DataSource = Nothing
        Me.txtAbonoMes.Clear()
        Me.txtCargoMes.Clear()
        Me.txtCta.Text = "0000"
        Me.txtSaldoActual.Clear()
        Me.txtSaldoAnterior.Clear()
        Me.txtSSSubCta.Text = "0000"
        Me.txtSSubCta.Text = "0000"
        Me.txtSubCta.Text = "0000"
        Me.txtNombreCuenta.Clear()
    End Sub

    Private Sub frmConsultaAnaliticaSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub txtCta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCta.KeyDown
        Dim CtasBan As New CN.CuentaCollectionClass
        If e.KeyCode = Keys.F3 Then
            Try
                Dim buscarCuenta As New BusquedaCuentasContablesForm
                buscarCuenta.BloquearCaracteristicas = True
                If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    CtasBan.Obtener(buscarCuenta.CuentaContable.Codigo)
                    txtCta.Text = buscarCuenta.CuentaContable.CuentaMayor
                    txtSubCta.Text = buscarCuenta.CuentaContable.SubCuenta
                    txtSSubCta.Text = buscarCuenta.CuentaContable.SSubCuenta
                    txtSSSubCta.Text = buscarCuenta.CuentaContable.SSSubCuenta
                    txtNombreCuenta.Text = buscarCuenta.CuentaContable.NombreCuenta
                    ConsultarCuenta()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class