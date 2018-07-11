Imports System.Data.SqlClient
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports ClasesNegocio


'Joel Jimenez Carrillo
'29/06/2018
'Realiza el cierre contable anual

Public Class frmCierreContableAnual

#Region "Declaracionies"

    'Private WithEvents Cheque As CN.ChequeClass
    Private codigoCuentaActual As Integer = 0

#End Region

    Private Sub frmCierreContableAnual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargarEjercicio() 'Carga el año que se quere cerrar
        cargarCuentaAnterior()

    End Sub

    'Mueatra el resultado del ejercicio anterior
    Private Sub cargarCuentaAnterior()
        Dim query As String = "SELECT (CC.Cta + '-' + CC.SubCta + '-' + CC.SSubCta + '-' + CC.SSSubCta) AS Cuenta, CC.NomCuenta FROM AcumuladoCuentasContables" +
            " ACC INNER JOIN usrContPolizasDetalle CPD on ACC.Codigo = CPD.CuentaContableId INNER JOIN usrContPolizas CP on CP.Codigo = CPD.PolizaId INNER JOIN" +
            " UsrGralPeriodosCont GPC on GPC.PolizaCierre = CPD.PolizaId INNER JOIN usrContCuentas CC on CC.codigo = ACC.Codigo WHERE ACC.Ejercicio = {0} AND" +
            " CPD.OperacionCA = 'C' AND GPC.Ejercicio = {0}"
        query = String.Format(query, Convert.ToInt32(tb_anioContable.Text) - 1)
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                reader.Read()
                If (reader.HasRows) Then
                    tb_cuentaEjercicioAterior.Text = reader.GetValue(0).ToString()
                    tb_cuentaEjercicioAterior.TextAlign = HorizontalAlignment.Center
                    tb_nombreEjercicioAnterior.Text = reader.GetValue(1).ToString()
                    tb_nombreEjercicioAnterior.TextAlign = HorizontalAlignment.Center
                Else
                    MessageBox.Show("No se tiene registrado ningún cierre antes del año " + tb_anioContable.Text, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("No se pudo cargar ejercicio del año anterior: " + ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If (tb_nombreEjercicioActual.TextLength = 0 Or tb_cuentaEjercicioActual.TextLength = 0) Then
            MessageBox.Show("Antes de cerrar el año debe seleccionar una cuenta, para buscar una cuenta, debe seleccionar la caja de texto de ejercicio actual y presionar F3 ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If (MessageBox.Show("¿Estas seguro que desea cerrar el ejercicio?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then

                If relacionarCuentaCierreEjercicio() Then

                    lbl_porcentaje.Visible = True
                    pb_cierreAnual.Visible = True
                    btn_IniciarCierre.Enabled = False

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
                            MessageBox.Show("No se logro cerrar el ejercicio " + tb_anioContable.Text +
                                            ". Verifique que el ejercicio " + (Convert.ToInt32(tb_anioContable.Text) + 1).ToString() + " este abierto.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End Try
                        connection.Close()
                    End Using
                    sumaTotalCuentas()
                    generarPolizaCab()
                    generarPolizaDetalle()
                    polizaCierre()
                    actualizarCuentas()
                    timer_progressbar.Start()
                End If
            End If
        End If
    End Sub

    Private Sub actualizarCuentas()
        Dim queryTabla As String = "SELECT ACC.Codigo, SaldoFinEjer FROM AcumuladoCuentasContables ACC " +
            "INNER JOIN usrContCuentas CC ON ACC.Codigo = CC.codigo WHERE Ejercicio = {0} AND Titulo IN (1,2,3) AND SaldoFinEjer <> 0"
        Dim tablaCuentas As DataTable = buscarTabla(querytabla)
        Dim query As String

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("SampleTransaction")
            command.Connection = connection
            command.Transaction = transaction
            Try
                For Each filas As DataRow In tablaCuentas.Rows
                    query = "EXEC RegistrarCuentaCierre 2, {0}, {1}, {2}"
                    query = String.Format(query, filas(0), tb_anioContable.Text, filas(1))
                    command.CommandText = query
                    command.ExecuteNonQuery()
                Next
                transaction.Commit()
                codigoCuentaActual = 0 'se iguala a cero si se realizo todo el cierre sin errores para madar mensaje de confirmacion en el timer
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("No se lograron actualizar los saldo del siguiente año de las cuentas 1, 2 y 3. Consulte al Adminitrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
    End Sub

    'Animacion progress bar con el timer
    Private Sub timer_progressbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_progressbar.Tick
        pb_cierreAnual.Increment(800)
        lbl_porcentaje.Text = pb_cierreAnual.Value.ToString() + "%"
        If pb_cierreAnual.Value = 100 Then
            timer_progressbar.Stop()
            If codigoCuentaActual = 0 Then
                MessageBox.Show("El ejercicio se ha cerrado con éxito", "Cierre de ejercicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Poliza cabecero
    Private Sub generarPolizaCab()
        Dim idEmpresa As String = Controlador.Sesion.MiEmpresa.Empid
        Dim tipoPoliza As String = "D"
        Dim mes As String = Date.Now.Month.ToString()
        Dim anio As String = Date.Now.Year.ToString()
        Dim folio As Integer = buscarFolio(idEmpresa.ToString(), tipoPoliza, mes) 'busca el consecutivo del folio 
        Dim fechaPolizaCaptura As String = Date.Now.ToString("dd/MM/yyy")
        Dim importe As String = buscarImporteCierre()
        Dim concepto As String = tb_nombreEjercicioActual.Text
        Dim origen As String = "C"
        Dim tipoErro As String = "0"
        Dim estatus As String = "1" 'Vigente
        Dim tipoCambio As String = "1"
        'Dim numeroPoliza As String = tipoPoliza + anio.ToString() + mes.ToString("0#") + folio.ToString("000#")

        Dim query As String =
            "INSERT INTO usrContPolizas (EmpresaId, TipoPoliza, Mes, Ano, Folio, FechaPoliza, FechaCaptura, Importe, Concepto, Origen, TipoError,Estatus, TipoCambio)" +
            "VALUES({0}, '{1}', {2}, {3}, {4}, '{5}', '{6}', {7}, '{8}', '{9}', {10}, {11}, {12})"
        query = String.Format(query, idEmpresa, tipoPoliza, mes, anio, folio, "31/12/" + anio, fechaPolizaCaptura, importe, tb_nombreEjercicioActual.Text, origen, tipoErro, estatus, tipoCambio)
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("No se pudo registrar la poliza. Consulte al administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using

        registrarFolioCierrePeriodo()
    End Sub

    'Busca en tabla acumulados el total de cada una de las cuentas tipo del 4 al 7 y la cuenta del cierra(activo) para hacer poliza detalle
    Private Function buscarTabla(ByVal query As String)
        Dim tablaDetalle As New DataTable()
        query = String.Format(query, tb_anioContable.Text, codigoCuentaActual)
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

    'Una vez que se cierra el ejercicio se llama este metodo para generar la poliza
    Private Sub generarPolizaDetalle()
        Dim idPoliza As Integer = obtenerIDPloliza() 'la tabla poliza detalle no tiene autocintementar, aqui se genera
        If idPoliza = 0 Then
            MessageBox.Show("No se logró obtener ID de la póliza de la base de datos (tabla usrContPolizasDetalle).", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim queryTabla As String = "SELECT  ACC.Codigo, SaldoFinEjer, Operacion = case when CC.Titulo IN (4) then 'C' when CC.Titulo IN(5 ,6 ,7) then 'A' End " +
            "FROM AcumuladoCuentasContables ACC INNER JOIN usrContCuentas CC ON ACC.Codigo = CC.codigo WHERE Ejercicio = {0} AND (Titulo in (4,5,6,7) OR ACC.Codigo = {1})"
            Dim tablaDetalle As DataTable = buscarTabla(queryTabla) 'busca y regresa tabla con los movimientos del año que se esta cerrando
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
                            posicion += 1
                            query = "INSERT INTO usrContPolizasDetalle (PolizaId, Posicion, CuentaContableId, OperacionCA, Importe) VALUES ({0}, {1}, {2}, '{3}', {4})"
                            If (filas(1) > 0) Then
                                query = String.Format(query, idPoliza, posicion, filas(0), "A", filas(1))
                            Else
                                filas(1) = -(filas(1))
                                query = String.Format(query, idPoliza, posicion, filas(0), "C", filas(1))
                            End If
                            command.CommandText = query
                            command.ExecuteNonQuery()
                        ElseIf (filas(2) = "C") Then
                            posicion += 1
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
                    MessageBox.Show("Error al tratar de registrar la poliza detalle en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                connection.Close()
            End Using
        End If
    End Sub

    'abre formulario de busqueda para seleccionar la cuanta a la que se va
    Private Sub buscarCuenta()
        Dim frmBuscarCuenta As New frmBusquedaCuentaCierre
        frmBuscarCuenta.StartPosition = FormStartPosition.CenterScreen

        Dim drBuscarCuenta As New DialogResult() 'abre fomulario pra buscar cuenta del cierre actual
        drBuscarCuenta = frmBuscarCuenta.ShowDialog()

        If drBuscarCuenta = Windows.Forms.DialogResult.OK Then
            codigoCuentaActual = frmBuscarCuenta.codigoCuenta 'regresa el codigo de la cuenta seleccionada

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
                    'MessageBox.Show("Ocurrio un error al buscar la cuenta: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                connection.Close()
            End Using
        End If


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
    Private Function obtenerIDPloliza() As Integer

        Dim query As String = "select top 1 Codigo from usrContPolizas order by Codigo desc"
        Dim idPoliza As Integer = 0
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                reader.Read()
                idPoliza = Convert.ToInt32(reader.GetValue(0))
            Catch ex As Exception
                'si la poliza regresa 0 entonces se manda mensaje de erro en un condicion despues de llamar este metodo
            End Try
            connection.Close()
        End Using
        Return idPoliza
    End Function

    'regresa el numero de la poliza del mes
    Private Function buscarFolio(ByVal empresa As String, ByVal tipoPoliza As String, ByVal mes As String) As Integer
        Dim poliza As Integer = 0
        Dim query As String = "EXEC GENERARFOLIOPOLIZA {0}, {1}, {2}"
        query = String.Format(query, empresa, tipoPoliza, mes)
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                reader.Read()
                If (reader.HasRows) Then
                    poliza = reader.GetValue(0) + 1
                Else
                    poliza = 1
                End If
            Catch ex As Exception
                MessageBox.Show("No se pudo encontrar folio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
        Return poliza
    End Function

    Private Function buscarImporteCierre() As String
        Dim importeCierre As String = ""
        Dim query As String = "select SaldoFinEjer from AcumuladoCuentasContables where Codigo = {0}"
        query = String.Format(query, codigoCuentaActual)

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                reader.Read()
                importeCierre = reader.GetValue(0).ToString()
            Catch ex As Exception
                MessageBox.Show("No se pudo cargar el importe del cierre contable. Consulte con el administrador de Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return importeCierre
    End Function

    'actualiza en la tabla periodos relacionando la poliza con el periodo
    Private Sub registrarFolioCierrePeriodo()
        Dim idPoliza As Integer = obtenerIDPloliza()
        Dim query As String = "UPDATE UsrGralPeriodosCont SET PolizaCierre = {0} WHERE Ejercicio = {1}"
        query = String.Format(query, idPoliza, tb_anioContable.Text)
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("No se pudo relacionar la poliza con el cierre de periodo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
    End Sub

    'relaciona la poliza con el campo de polizacierre de la tabla periodos
    Private Sub polizaCierre()
        Dim idPoliza As Integer = obtenerIDPloliza()
        Dim query As String = "update UsrGralPeriodosCont set PolizaCierre = {0} where Ejercicio = {1}"
        query = String.Format(query, idPoliza, tb_anioContable.Text)

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("No se pudo relacionar la poliza con el periodo que se esta cerrando: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
    End Sub

    'busca tabla que regresa el total de la cuentas y reliza la operacion de cierre contable para guardarlo en la cuenta seleccionda(en la variable codigoCuentaActual)
    'registra la cuenta donde se guarda el total y la del año siguiente
    Private Sub sumaTotalCuentas()
        Dim queryTabla As String = "SELECT  ACC.Codigo, SaldoFinEjer, Operacion = case when CC.Titulo IN (4) then 'C' when CC.Titulo IN(5 ,6 ,7) then 'A' End " +
            "FROM AcumuladoCuentasContables ACC INNER JOIN usrContCuentas CC ON ACC.Codigo = CC.codigo WHERE Ejercicio = {0} AND (Titulo in (4,5,6,7) OR ACC.Codigo = {1})"
        Dim tablacuentas As DataTable = buscarTabla(queryTabla)
        Dim total As Double = 0
        For Each filas As DataRow In tablacuentas.Rows
            If IsDBNull(filas(2)) Then
                'no hace nada
            ElseIf filas(2) = "C" Then
                total += filas(1)
            Else
                total -= filas(1)
            End If
        Next

        Dim query As String = "EXEC RegistrarCuentaCierre 1, {0}, {1}, {2}"
        query = String.Format(query, codigoCuentaActual, tb_anioContable.Text, total)
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("No se registro la cuenta de cierre, verificar con administrador del sistema " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
    End Sub

    'Relaciona la cuenta de  cierre con el ejercicio para difereciarlo de las demas cuentas  de capital
    Private Function relacionarCuentaCierreEjercicio() As Boolean
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim query As String = "SELECT * FROM cuentascierres WHERE Ejercicio = '{0}' AND ID_Cuenta = '{1}'"
                query = String.Format(query, tb_anioContable.Text, codigoCuentaActual)
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    'update
                    query = "UPDATE CuentasCierres SET Ejercicio ='{0}', ID_Cuenta= '{1}', RegistroCambio = '{2}', ID_RegistroCambio = '{3}' WHERE Ejercicio = '{0}'"
                    query = String.Format(query, tb_anioContable.Text, codigoCuentaActual, Date.Now.ToString("dd/MM/yyy"), Controlador.Sesion.MiUsuario.Usrndx)
                Else
                    'insert
                    query = "INSERT INTO  CuentasCierres (Ejercicio, ID_Cuenta, ID_UsuarioAlta) VALUES ('{0}', '{1}', '{2}')"
                    query = String.Format(query, tb_anioContable.Text, codigoCuentaActual, Controlador.Sesion.MiUsuario.Usrndx)
                End If
                reader.Close()
                command.CommandText = query
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("No se logro relacionar la cuenta de cierre con el ejercicio " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            Return True
        End Using
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dataSet As New DataSet
            Dim query = "SELECT CC.codigo AS Codigo, CC.NomCuenta AS Concepto, CC.Titulo, ACC.SaldoFinEjer AS Importe, Tipo = CASE WHEN CC.Titulo = 4 THEN '1' WHEN CC.Titulo IN (5, 6, 7) THEN '0' END " +
                "FROM AcumuladoCuentasContables ACC INNER JOIN usrContCuentas CC ON ACC.Codigo = CC.codigo WHERE ACC.Ejercicio = '{0}' " +
                "AND (Titulo in (4,5,6,7) OR ACC.Codigo = '{1}')"
            query = String.Format(query, tb_anioContable.Text, codigoCuentaActual)
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(dataSet)
            End Using

            Dim Reporte As New rptCierreContable
            Reporte.SetDataSource(dataSet.Tables(0))
            Reporte.SetParameterValue("EmpresaNombre", Controlador.Empresa.Nombre)
            'Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)
            'Reporte.SetParameterValue("Modulo", "Catalogos\Contabilidad\Cuentas Contables")

            Dim Pre As New ClasesNegocio.PreVisualizarForm
            pre.Reporte = Reporte
            pre.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class