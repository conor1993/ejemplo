Imports System.Data.SqlClient
Imports HC = Integralab.ORM.HelperClasses

Public Class frmCierreContableAnual

    Dim cuentaActual As Integer

    Public Sub New(ByVal codigoCuenta As Integer)
        InitializeComponent()
        cuentaActual = codigoCuenta
    End Sub

    Private Sub frmCierreContableAnual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarEjercicio()
        'validacion, si el tamaño del texto es 4(caracteres del año. ejemplo - '2018') entonces llama metodo
        If (tb_anioContable.TextLength = 4) Then
            cargarCuentaActual(cuentaActual)
            cargarCuentaAtenrior()
        End If
    End Sub

    'Carga los datos de la cuenta donde se va realizar el cierre
    Private Sub cargarCuentaActual(ByVal codigoCuenta As Integer)
        Dim query As String = "select (Cta + '-' + SubCta + '-' + SSubCta + '-' + SSSubCta), NomCuenta from usrContCuentas where codigo = {0}"
        query = String.Format(query, codigoCuenta)

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader
            reader = command.ExecuteReader()
            reader.Read()

            If (reader.HasRows) Then
                tb_cuentaEjercicioActual.Text = reader.GetValue(0)
                tb_cuentaEjercicioActual.TextAlign = HorizontalAlignment.Center
                tb_nombreEjercicioActual.Text = reader.GetValue(1)
                tb_nombreEjercicioActual.TextAlign = HorizontalAlignment.Center
            Else
                MessageBox.Show("No logro encontrar la cuenta en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            connection.Close()
        End Using
    End Sub

    'Mueatra el resultado del ejercicio anterior
    Private Sub cargarCuentaAtenrior()

        Dim query As String = "SELECT NomCuenta, Cta, SubCta, SSubCta, SSSubCta FROM usrContCuentas tCuentas INNER JOIN AcumuladoCuentasContables " +
            "tAcumulados on tCuentas.codigo = tAcumulados.Codigo where tAcumulados.Ejercicio = {0} " +
            "AND tAcumulados.SaldoIniEjer <> 0"
        query = String.Format(query, (Convert.ToInt64(tb_anioContable.Text) - 1))

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader
            Try
                reader = command.ExecuteReader()
                reader.Read()
                If (reader.HasRows) Then
                    tb_nombreEjercicioAnterior.Text = reader.GetValue(0)
                    tb_cuentaEjercicioAterior.Text = reader.GetValue(1) + "-" + reader.GetValue(2) + "-" + reader.GetValue(3) + "-" + reader.GetValue(4)
                    tb_cuentaEjercicioAterior.TextAlign = HorizontalAlignment.Center
                    tb_nombreEjercicioAnterior.TextAlign = HorizontalAlignment.Center
                Else
                    MessageBox.Show("No se tiene registrado ningun ejercicio aterior", "Atneción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al buscar la informacion de cierre anterior en la base de datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using

    End Sub

    'Muestra el ejercicio que se va cerrar y verifica su esta abierto el siguiete(Validacion), sino cierra la ventana
    Private Sub cargarEjercicio()
        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim query As String = "EXEC cosultaEjercicio"

        Try
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                command.Connection = connection
                command.CommandText = query
                reader = command.ExecuteReader()
                reader.Read()

                If IsDBNull(reader.GetValue(1)) Then
                    MessageBox.Show("El ejercicio " + reader.GetValue(0).ToString() + " no se puede cerrar, porque no se ha dado de alta el ejercicio " + (reader.GetValue(0) + 1).ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dispose()
                Else
                    tb_anioContable.Text = reader.GetValue(0).ToString()
                    tb_anioContable.TextAlign = HorizontalAlignment.Center
                End If
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("No se logro acceder a los datos de la base de datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Cierre Contable
    Private Sub btn_IniciarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IniciarCierre.Click

        If (MessageBox.Show("¿Estas seguro que desea cerrar el ejercicio?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
            Dim query As String = "EXEC spCierreAnual '{0}', '{1}'"
            query = String.Format(query, tb_anioContable.Text, cuentaActual)

            Dim transaction As SqlTransaction

            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                Dim command As New SqlCommand(query, connection)

                transaction = connection.BeginTransaction("SampleTransaction")
                command.Transaction = transaction

                Try
                    command.ExecuteNonQuery()
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("No se lograron registrar los datos en la base de dato" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
                connection.Close()
            End Using

            lbl_porcentaje.Visible = True
            pb_cierreAnual.Visible = True
            timer_progressbar.Start()
            btn_IniciarCierre.Enabled = False
            actualizarNombreEjercicioActual()
        End If

    End Sub

    'Animacion progress bar con el timer
    Private Sub timer_progressbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_progressbar.Tick
        pb_cierreAnual.Increment(20)
        lbl_porcentaje.Text = pb_cierreAnual.Value.ToString() + "%"
        If pb_cierreAnual.Value = 100 Then
            timer_progressbar.Stop()
            MessageBox.Show("El ejercicio se ha cerrado con éxito", "Cierre de ejercicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'despues de realizar el cierre actualiza el nombre en el textbox para mostar reusltado(perdida o ganancia)
    Private Sub actualizarNombreEjercicioActual()

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Dim query As String = "SELECT nomCuenta FROM usrContCuentas WHERE Codigo = {0}"
            query = String.Format(query, cuentaActual)
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader
            Try
                reader = command.ExecuteReader()
                reader.Read()
                tb_nombreEjercicioActual.Text = reader.GetValue(0).ToString()
            Catch ex As Exception
                'Nada
            End Try
            connection.Close()
        End Using

    End Sub

End Class