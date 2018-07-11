Imports System.Data.SqlClient
Imports HC = IntegraLab.ORM.HelperClasses

Public Class frmCancelaciondeCierre

    Private Sub frmCancelaciondeCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaEjercicioAnterior()
    End Sub

    Private Sub btn_CancelarAnio_Click(sender As Object, e As EventArgs) Handles btn_CancelarAnio.Click
        If (MessageBox.Show("Al cancelar el cierre del ejercicio " + tb_Anio.Text + " se eliminaran los registro del año actual. " +
                            "¿Desea continuar?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                Dim query As String = "EXEC cancelacionCierre {0}"
                query = String.Format(query, tb_Anio.Text)
                Try
                    Dim command As New SqlCommand(query, connection)
                    command.ExecuteNonQuery()
                    lbl_Pocentaje.Visible = True
                    pb_Cancelaranio.Visible = True
                    btn_CancelarAnio.Enabled = False
                    timer_cancelaranio.Start()
                    MessageBox.Show("Se ha realizado la cancelacion del ejercicio " + tb_Anio.Text + " con exito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("No se logro cancelar el cierre anual anterior " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                connection.Close()
            End Using
            Dispose()
        End If
        
    End Sub

    Private Sub cargaEjercicioAnterior()
        Try
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                Dim query As String = "SELECT TOP 1 Ejercicio FROM UsrGralPeriodosCont WHERE Estatus = 2 ORDER BY Ejercicio DESC"
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    tb_Anio.Text = reader.GetValue(0).ToString()
                Else
                    MessageBox.Show("No se encontró ningún ejercicio cerrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("No se logro cargar el ejercicio anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub timer_cancelaranio_Tick(sender As Object, e As EventArgs) Handles timer_cancelaranio.Tick
        pb_Cancelaranio.Increment(800)
        lbl_Pocentaje.Text = pb_Cancelaranio.Value.ToString() + "%"
        If pb_Cancelaranio.Value = 100 Then
            timer_cancelaranio.Stop()
        End If
    End Sub
End Class