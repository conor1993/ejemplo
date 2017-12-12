Imports System.Data.SqlClient

Public Class frmDesactualizacionSaldos

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)
        Dim trans As SqlTransaction = Nothing

        Try
            Cursor = Cursors.WaitCursor

            Dim mes As New ClasesNegocio.ControlMesClass

            If mes.Obtener(Me.DateTimePicker1.Value.Year.ToString, Me.DateTimePicker1.Value.ToString("MM")) Then
                If mes.Estatus = ClasesNegocio.EstatusMes.ABIERTO Then
                    sqlCon.Open()
                    trans = sqlCon.BeginTransaction

                    Dim sqlCom As New SqlCommand(String.Format("UPDATE usrContPolizas SET Estatus=1 WHERE dbo.usrContPolizas.Mes={0} AND dbo.usrContPolizas.Ano = {1}", Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year), sqlCon, trans)

                    If sqlCom.ExecuteNonQuery = 0 Then
                        trans.Rollback()
                        MsgBox("No se logro desactualizar los saldos, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If

                    Dim sqlcomCuentas As New SqlCommand(String.Format("UPDATE usrContCuentas SET Cargos{0}=0, Abonos{0}=0", Me.DateTimePicker1.Value.ToString("MM")), sqlCon, trans)

                    If sqlcomCuentas.ExecuteNonQuery = 0 Then
                        trans.Rollback()
                        MsgBox("No se logro desactualizar los saldos, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If

                    trans.Commit()

                    MsgBox("Las cuentas contables se han desactualizado", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("El mes actual no se encuentra abrierto", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("El mes no esta dado de alta en el año actual", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al realizar la actualización de saldos", MsgBoxStyle.Critical, "Error")
#End If
            If trans IsNot Nothing Then
                trans.Rollback()
            End If
        Finally
            Cursor = Cursors.Default

            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class