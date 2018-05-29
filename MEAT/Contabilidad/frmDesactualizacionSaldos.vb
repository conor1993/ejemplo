Imports System.Data.SqlClient
Imports HC = IntegraLab.ORM.HelperClasses

Public Class frmDesactualizacionSaldos

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnDesactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesactualizar.Click

        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Dim command As SqlCommand = connection.CreateCommand()
            Dim query As String
            Dim reader As SqlDataReader
            Try
                query = "exec spDesactualizarSaldos '{0}', '{1}'"
                query = String.Format(query, cb_Mes.SelectedValue, cb_Anio.SelectedItem)
                command.CommandText = query
                reader = command.ExecuteReader()

                If reader.Read() Then
                    MessageBox.Show("Se han desactualizados los saldos", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Este año no esta registrado o no se ha dado de alta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception
                MessageBox.Show("Se ha generado un error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
        '        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)
        '        Dim trans As SqlTransaction = Nothing
        '        Try
        '            Cursor = Cursors.WaitCursor

        '            Dim mes As New ClasesNegocio.ControlMesClass

        '            If mes.Obtener(Me.cb_Anio.SelectedValue.ToString(), Me.cb_Mes.SelectedValue.ToString()) Then
        '                If mes.Estatus = ClasesNegocio.EstatusMes.ABIERTO Then
        '                    sqlCon.Open()
        '                    trans = sqlCon.BeginTransaction

        '                    Dim sqlCom As New SqlCommand(String.Format("UPDATE usrContPolizas SET Estatus=1 WHERE dbo.usrContPolizas.Mes={0} AND dbo.usrContPolizas.Ano = {1}", Me.cb_Mes.SelectedValue.ToString(), Me.cb_Anio.SelectedValue.ToString()), sqlCon, trans)

        '                    If sqlCom.ExecuteNonQuery = 0 Then
        '                        trans.Rollback()
        '                        MsgBox("No se logro desactualizar los saldos, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
        '                        Exit Sub
        '                    End If

        '                    Dim sqlcomCuentas As New SqlCommand(String.Format("UPDATE usrContCuentas SET Cargos{0}=0, Abonos{0}=0", Me.cb_Mes.SelectedValue.ToString()), sqlCon, trans)

        '                    If sqlcomCuentas.ExecuteNonQuery = 0 Then
        '                        trans.Rollback()
        '                        MsgBox("No se logro desactualizar los saldos, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
        '                        Exit Sub
        '                    End If

        '                    trans.Commit()

        '                    MsgBox("Las cuentas contables se han desactualizado", MsgBoxStyle.Information, "Aviso")
        '                Else
        '                    MsgBox("El mes actual no se encuentra abrierto", MsgBoxStyle.Exclamation, "Aviso")
        '                End If
        '            Else
        '                MsgBox("El mes no esta dado de alta en el año actual", MsgBoxStyle.Exclamation, "Aviso")
        '            End If
        '        Catch ex As Exception
        '#If CONFIG = "Debug" Then
        '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '#Else
        '            MsgBox("Ocurrio un error al realizar la actualización de saldos", MsgBoxStyle.Critical, "Error")
        '#End If
        '            If trans IsNot Nothing Then
        '                trans.Rollback()
        '            End If
        '        Finally
        '            Cursor = Cursors.Default

        '            If sqlCon.State = ConnectionState.Open Then
        '                sqlCon.Close()
        '            End If
        '        End Try


    End Sub

    Private Sub frmDesactualizacionSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'diccionario de meses
        Dim meses As New Dictionary(Of String, String)
        meses.Add("01", "ENERO")
        meses.Add("02", "FEBRERO")
        meses.Add("03", "MARZO")
        meses.Add("04", "ABRIL")
        meses.Add("05", "MAYO")
        meses.Add("06", "JUNIO")
        meses.Add("07", "JULIO")
        meses.Add("08", "AGOSTO")
        meses.Add("09", "SEPTIEMBRE")
        meses.Add("10", "OCTUBRE")
        meses.Add("11", "NOVIEMBRE")
        meses.Add("12", "DICIEMBRE")

        'Cargar meses a combobox mes
        cb_Mes.DataSource = New BindingSource(meses, Nothing)
        cb_Mes.DisplayMember = "Value"
        cb_Mes.ValueMember = "Key"
        cb_Mes.TabIndex = 0

        'carga los años que se encuentren registrardos en la base de datos, sino, veremos que hace :V
        cargarAnios()
        cb_Anio.SelectedIndex = 0
    End Sub

    Private Sub cargarAnios()
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Dim command As SqlCommand = connection.CreateCommand()
            Dim reader As SqlDataReader
            Dim query As String
            Try
                query = "SELECT DISTINCT  Ano FROM usrContPolizas" 'regresa todos los años sin importar el estatus porque asi lo hacia anteriormente, y aunque es poco practico no se explica como se hace correctamte
                command.CommandText = query
                reader = command.ExecuteReader()
                While reader.Read()
                    cb_Anio.Items.Add(reader.GetValue(0))
                End While
                'MessageBox.Show("No existe ejercicio contable en la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'No se necesita codigo
            End Try
            connection.Close()
        End Using
    End Sub

End Class