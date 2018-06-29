Imports System.Data.SqlClient
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports ClasesNegocio



Public Class frmCierreContableAnual

#Region "Declaracionies"

    'Private WithEvents Cheque As CN.ChequeClass
    Private codigoCuentaActual As Integer = 0

#End Region

    Private Sub frmCierreContableAnual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargarEjercicio() 'Carga el año que se quere cerrar
        cargarCuentaAtenrior()

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
        Dim query As String = "SELECT TOP 1 Ejercicio  FROM UsrGralPeriodosCont WHERE Estatus = 1"

        Try
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                command.Connection = connection
                command.CommandText = query
                reader = command.ExecuteReader()
                reader.Read()

                If (reader.HasRows) Then
                    tb_anioContable.Text = reader.GetValue(0).ToString()
                    tb_anioContable.TextAlign = HorizontalAlignment.Center
                Else
                    MessageBox.Show("El ejercicio " + reader.GetValue(0).ToString() + " no se puede cerrar, porque no se ha dado de alta el ejercicio " + (reader.GetValue(0) + 1).ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dispose()
                End If

                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("No se logro acceder a los datos de la base de datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Cierre Contable
    Private Sub btn_IniciarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IniciarCierre.Click
        If (tb_nombreEjercicioActual.TextLength = 0 And tb_cuentaEjercicioActual.TextLength = 0) Then
            MessageBox.Show("Antes de cerrar el año debe seleccionar una cuenta, para buscar una cuenta, debe seleccionar la caja de texto de ejercicio actual y presionar F3 ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If (MessageBox.Show("¿Estas seguro que desea cerrar el ejercicio?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
                Dim query As String = "EXEC spCierreAnual '{0}', '{1}'"
                query = String.Format(query, tb_anioContable.Text, codigoCuentaActual)
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
        End If
    End Sub

    'Animacion progress bar con el timer
    Private Sub timer_progressbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_progressbar.Tick
        pb_cierreAnual.Increment(5)
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
            query = String.Format(query, "Cuenta Actual - Integer") '-------------------------------------------------------
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

    'Busca en tabla acumulados el total de cada una de las cuentas del año del cierra para hacer poliza detalle
    Private Function buscarTablaPolizaDetalle()

        Dim tablaDetalle As New DataTable()
        Dim query As String = "SELECT Codigo, SaldoFinEjer AS Importe FROM AcumuladoCuentasContables WHERE Ejercicio = {0}"
        query = String.Format(query, tb_anioContable.Text)

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                Dim dataAdapter As New SqlDataAdapter(command)
                dataAdapter.Fill(tablaDetalle)
                dataAdapter.Dispose()
            Catch ex As Exception
                MessageBox.Show("No se logro acceder a los datos de la cuentas acumuladas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
        Return tablaDetalle
    End Function

    'Una vez que se cierra el ejercicio se llama este metodo para generar la poliza detalle
    Private Sub generaPolizaDetalle()
        Dim idPoliza As Integer = obtenerIDPlolizaDetalle() 'la tabla poliza detalle no tiene autocintementar, aqui se genera
        If idPoliza = 0 Then
            MessageBox.Show("No se logró obtener ID de la póliza de la base de datos (tabla usrContPolizasDetalle).", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim tablaDetalle As DataTable = buscarTablaPolizaDetalle() 'busca y regresa tabla con los movimientos del año que se esta cerrando
            Dim posicion As Integer = 0 'posicion de las cuentas de la tabla poliza detalles

            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()

                Dim query As String
                Dim command As SqlCommand = connection.CreateCommand()
                Dim transaction As SqlTransaction

                transaction = connection.BeginTransaction("SampleTransaction")

                command.Connection = connection
                command.Transaction = transaction

                Try
                    For Each filas As DataRow In tablaDetalle.Rows 'ciclo se repite como el numero de filas de la tabla
                        If (filas(0) = codigoCuentaActual) Then
                            query = "INSERT INTO usrContPolizasDetalle (PolizaId, Posicion, CuentaContableId, OperacionCA, Importe) VALUES ({0}, {1}, {2}, '{3}', {4})"
                            query = String.Format(query, idPoliza, posicion, filas(0), "C", filas(1))
                            command.CommandText = query
                            command.ExecuteNonQuery()
                        Else
                            posicion += 1
                            query = "INSERT INTO usrContPolizasDetalle (PolizaId, Posicion, CuentaContableId, OperacionCA, Importe) VALUES ({0}, {1}, {2}, '{3}', {4})"
                            query = String.Format(query, idPoliza, posicion, filas(0), "A", filas(1))
                            command.CommandText = query
                            command.ExecuteNonQuery()
                        End If
                    Next
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error al tratar de registrar la poliza detalle en la base de dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    'abre formulario de busqueda para seleccionar la cuanta a la que se va
    Private Sub buscarCuenta()

        Dim frmBuscarCuenta As New BusquedaCuentasContablesForm()
        frmBuscarCuenta.StartPosition = FormStartPosition.CenterScreen

        Dim drBuscarCuenta As New DialogResult() 'abre fomulario pra buscar cuenta del cierre actual
        drBuscarCuenta = frmBuscarCuenta.ShowDialog()

        codigoCuentaActual = frmBuscarCuenta.cierreCodigoCuenta 'regresa el codigo de la cuenta seleccionada

        Dim query As String = "SELECT (Cta + '-' + SubCta + '-' + SSubCta + '-' + SSSubCta) AS Cuenta , NomCuenta FROM usrContCuentas WHERE codigo = {0}"
        query = String.Format(query, codigoCuentaActual)

        Dim reader As SqlDataReader
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                reader = command.ExecuteReader()
                reader.Read()
                tb_cuentaEjercicioActual.Text = reader.GetValue(0).ToString()
                tb_cuentaEjercicioActual.TextAlign = HorizontalAlignment.Center
                tb_nombreEjercicioActual.Text = reader.GetValue(1).ToString()
                tb_nombreEjercicioActual.TextAlign = HorizontalAlignment.Center
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al buscar la cuenta: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
    End Sub

    Private Sub tb_cuentaEjercicioActual_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_cuentaEjercicioActual.KeyDown
        If (e.KeyCode = Keys.F3) Then
            buscarCuenta()
        End If
    End Sub

    Private Sub tb_nombreEjercicioActual_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_nombreEjercicioActual.KeyDown
        If (e.KeyCode = Keys.F3) Then
            buscarCuenta()
        End If
    End Sub

    'Como la tabla usrContPolizasDetalle(de la base de datos) el id no tiene auto incremento, se hace un select para generarlo(autoindrementar)
    Private Function obtenerIDPlolizaDetalle() As Integer

        Dim query As String = "select top 1 Codigo from usrContPolizas order by Codigo desc"
        Dim idPoliza As Integer = 0
        Using connecition As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connecition.Open()
            Try
                Dim command As New SqlCommand(query, connecition)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                reader.Read()
                idPoliza = Convert.ToInt32(reader.GetValue(0))
            Catch ex As Exception
                'si la poliza regresa 0 entonces se manda mensaje de erro en un condicion despues de llamar este metodo
            End Try
        End Using
        Return idPoliza
    End Function

End Class