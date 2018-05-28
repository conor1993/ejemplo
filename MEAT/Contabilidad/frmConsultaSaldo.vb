Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class frmConsultaSaldo

    Private Sub ConsultarCuenta()
        Dim codigoCuentaContable As String
        Try
            If Me.txtCuenta.Text = "0000" AndAlso Me.txtSubCuenta.Text = "0000" AndAlso _
                Me.txtSSubCuenta.Text = "0000" AndAlso Me.txtSSSubCuenta.Text = "0000" Then
                Me.CuentaContableC.Clear()
                Exit Sub
            End If

            codigoCuentaContable = buscarCuentaContable()

            If codigoCuentaContable = False Then
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
                'busca los datos de la consulta
                Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)

                    connection.Open()
                    Dim command As SqlCommand = connection.CreateCommand()
                    Dim adaptador As New SqlDataAdapter
                    Dim tablaConsulta As New DataTable
                    command.Connection = connection
                    Dim query As String

                    Try
                        query = "EXEC spConsultaCentasContables '{0}'"
                        query = String.Format(query, codigoCuentaContable)
                        command.CommandText = query
                        adaptador.SelectCommand = command
                        adaptador.Fill(tablaConsulta)
                        connection.Close()
                    Catch ex As Exception
                        connection.Close()

                    End Try
                    'metodo para llenar la tabla, manda como parametro la tabla que se obtiene de la consulta anterior
                    llenarGridConsulta(tablaConsulta)
                End Using
            Else
                Me.CuentaContableC.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub frmConsultaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        generarPeriodos()
        'se desactiva que se pueda ordenar las colmnas al hacer click en el cabecero de estas
        dgvConsulta.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvConsulta.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvConsulta.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvConsulta.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        'desactiva la opcion cambiar tamaño celdas
        dgvConsulta.AllowUserToResizeRows = False
    End Sub

    Private Sub Limpiar()
        Me.txtCuenta.Text = "0000"
        Me.txtSubCuenta.Text = "0000"
        Me.txtSSubCuenta.Text = "0000"
        Me.txtSSSubCuenta.Text = "0000"
        generarPeriodos()
        Me.CuentaContableC.Clear()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Dim ventana As New BusquedaCuentasContablesForm
        Dim nombreCuentaContable As String = ""
        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CuentaContableC.Clear()
            Me.CuentaContableC.Add(ventana.CuentaContable)
            Me.txtCuenta.Text = ventana.CuentaContable.CuentaMayor
            Me.txtSubCuenta.Text = ventana.CuentaContable.SubCuenta
            Me.txtSSubCuenta.Text = ventana.CuentaContable.SSubCuenta
            Me.txtSSSubCuenta.Text = ventana.CuentaContable.SSubCuenta
            ConsultarCuenta()
        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub txtCuenta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.Leave
        'If sender.KeyCode = Keys.Enter Then

        If Me.txtCuenta.Text = "" Then
            Me.txtCuenta.Text = "0000"
        ElseIf IsNumeric(Me.txtCuenta.Text) Then
            Me.txtCuenta.Text = CInt(Me.txtCuenta.Text).ToString("0000")
        End If

        ConsultarCuenta()
        'End If
    End Sub

    Private Sub txtSubCuenta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubCuenta.Leave
        'If e.KeyCode = Keys.Enter Then
        If Me.txtSubCuenta.Text = "" Then
            Me.txtSubCuenta.Text = "0000"
        ElseIf IsNumeric(Me.txtSubCuenta.Text) Then
            Me.txtSubCuenta.Text = CInt(Me.txtSubCuenta.Text).ToString("0000")
        End If
        ConsultarCuenta()
        'End If
    End Sub

    Private Sub txtSSubCuenta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSubCuenta.Leave
        'If e.KeyCode = Keys.Enter Then
        If Me.txtSSubCuenta.Text = "" Then
            Me.txtSSubCuenta.Text = "0000"
        ElseIf IsNumeric(Me.txtSSubCuenta.Text) Then
            Me.txtSSubCuenta.Text = CInt(Me.txtSSubCuenta.Text).ToString("0000")
        End If
        ConsultarCuenta()
        'End If
    End Sub

    Private Sub txtSSSubCuenta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSSubCuenta.Leave
        'If e.KeyCode = Keys.Enter Then
        If Me.txtSSSubCuenta.Text = "" Then
            Me.txtSSSubCuenta.Text = "0000"
        ElseIf IsNumeric(Me.txtSSSubCuenta.Text) Then
            Me.txtSSSubCuenta.Text = CInt(Me.txtSSSubCuenta.Text).ToString("0000")
        End If
        ConsultarCuenta()
        'End If
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtSubCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubCuenta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtSSubCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSubCuenta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtSSSubCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSSubCuenta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub llenarGridConsulta(ByVal tabla As DataTable)
        Dim contador As Integer = tabla.Columns.Count - 1
        Dim col As Integer
        Dim totalCargos As Double = 0
        Dim totalAbonos As Double = 0
        Dim totalSaldos As Double = 0

        For col = 1 To contador
            'muestras los cargos, abonos y saldos de la tabla en el grid
            dgvConsulta.Rows(col - 1).Cells(1).Value = Convert.ToDouble(tabla.Rows(0).Item(col))
            dgvConsulta.Rows(col - 1).Cells(2).Value = Convert.ToDouble(tabla.Rows(1).Item(col))
            dgvConsulta.Rows(col - 1).Cells(3).Value = Convert.ToDouble(tabla.Rows(2).Item(col))

            'camumula los totales de todos lo abonos 
            totalCargos += Convert.ToDouble(tabla.Rows(0).Item(col))
            totalAbonos += Convert.ToDouble(tabla.Rows(1).Item(col))
            totalSaldos += Convert.ToDouble(tabla.Rows(2).Item(col))
        Next

        dgvConsulta.Rows(12).Cells(1).Value = totalCargos
        dgvConsulta.Rows(12).Cells(2).Value = totalAbonos
        dgvConsulta.Rows(12).Cells(3).Value = totalSaldos
    End Sub

    Private Sub dgvConsulta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvConsulta.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub generarPeriodos()
        dgvConsulta.Rows.Clear()
        'Genera los periodos
        dgvConsulta.Rows.Add("Enero", "0", "0", "0")
        dgvConsulta.Rows.Add("Febrero", "0", "0", "0")
        dgvConsulta.Rows.Add("Marzo", "0", "0", "0")
        dgvConsulta.Rows.Add("Abril", "0", "0", "0")
        dgvConsulta.Rows.Add("Mayo", "0", "0", "0")
        dgvConsulta.Rows.Add("Junio", "0", "0", "0")
        dgvConsulta.Rows.Add("Julio", "0", "0", "0")
        dgvConsulta.Rows.Add("Agosto", "0", "0", "0")
        dgvConsulta.Rows.Add("Septiembre", "0", "0", "0")
        dgvConsulta.Rows.Add("Octubre", "0", "0", "0")
        dgvConsulta.Rows.Add("Noviembre", "0", "0", "0")
        dgvConsulta.Rows.Add("Diciembre", "0", "0", "0")
        dgvConsulta.Rows.Add("Totales", "0", "0", "0")

    End Sub

    Private Function buscarCuentaContable()
        generarPeriodos()
        Dim codigoCuentaContable As String = ""
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Dim command As SqlCommand = connection.CreateCommand()
            Dim reader As SqlDataReader
            Dim query As String
            Try
                query = "select t1.codigo, t2.SaldoIniEjer from usrContCuentas t1 inner join AcumuladoCuentasContables t2 " & _
                    "on t1.codigo = t2.Codigo where Cta = '{0}' and SubCta='{1}' and SSubCta = '{2}' and SSSubCta = '{3}'"
                query = String.Format(query, txtCuenta.Text, txtSubCuenta.Text, txtSSubCuenta.Text, txtSSSubCuenta.Text)
                command.CommandText = query
                reader = command.ExecuteReader()
                If reader.Read Then
                    codigoCuentaContable = reader.GetValue(0).ToString()
                    txtSaldoInicial.Text = reader.GetValue(1).ToString()
                Else
                    Return False
                End If
                connection.Close()

            Catch ex As Exception
                connection.Close()
            End Try
        End Using
        Return codigoCuentaContable
    End Function

End Class