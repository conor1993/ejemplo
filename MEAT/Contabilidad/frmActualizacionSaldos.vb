Imports System.Data.SqlClient
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = Integralab.ORM.StoredProcedureCallerClasses.ActionProcedures

Public Class frmActualizacionSaldos


    Private m_progreso As ToolStripProgressBar
    Public Property BarraProgreso() As ToolStripProgressBar
        Get
            Return m_progreso
        End Get
        Set(ByVal value As ToolStripProgressBar)
            m_progreso = value
        End Set
    End Property


    Private m_Timer As Timer
    Public Property Timer() As Timer
        Get
            Return m_Timer
        End Get
        Set(ByVal value As Timer)
            m_Timer = value
        End Set
    End Property

    Private Sub frmActualizacionSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RichTextBox1.Select(Me.RichTextBox1.Text.IndexOf("ACTUALIZARA"), 11)
        Me.RichTextBox1.SelectionColor = Color.Blue
        Me.RichTextBox1.SelectionFont = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point, 12)
        Me.RichTextBox1.Select(Me.RichTextBox1.Text.IndexOf("CONTABILIDAD GENERAL"), 20)
        Me.RichTextBox1.SelectionColor = Color.Blue
        Me.RichTextBox1.SelectionFont = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point, 12)
        Me.RichTextBox1.Select(Me.RichTextBox1.Text.IndexOf("NO"), 2)
        Me.RichTextBox1.SelectionColor = Color.Blue
        Me.RichTextBox1.SelectionFont = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point, 12)
        Me.RichTextBox1.Select(Me.RichTextBox1.Text.IndexOf("ERROR"), 5)
        Me.RichTextBox1.SelectionColor = Color.Blue
        Me.RichTextBox1.SelectionFont = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point, 12)
        Me.RichTextBox1.Select(Me.RichTextBox1.Text.IndexOf("VERIFICADOR DE POLIZAS"), "VERIFICADOR DE POLIZAS".Length)
        Me.RichTextBox1.SelectionColor = Color.Blue
        Me.RichTextBox1.SelectionFont = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point, 12)
        Me.RichTextBox1.DeselectAll()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim trans As New HC.Transaction(IsolationLevel.RepeatableRead, "Actualizacion de Saldos")

        Try
            Cursor = Cursors.WaitCursor

            Dim mes As New ClasesNegocio.ControlMesClass

            'validar que existan las cuentas contables en el acumulado de cuentas para realizar la actualizacion de los mismos
            Dim Ejercicios As New ClasesNegocio.PeriodosContablesClass
            Ejercicios.Obtener(Me.DateTimePicker1.Value.Year)
            If Ejercicios.Estatus = Integra.Clases.EstatusEnum.ACTIVO Then
                If mes.Obtener(Me.DateTimePicker1.Value.Year, Me.DateTimePicker1.Value.Month) Then
                    If mes.Estatus = ClasesNegocio.EstatusMes.ABIERTO Then
                        If SPA.UspActualizarSaldos(Me.DateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm:ss")) > 0 Then 'error <------------------------------------------------
                            trans.Commit()
                        Else
                            trans.Rollback()
                            MsgBox("No se logro actualizar los saldos", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                        End If
                    Else
                        MsgBox("El mes actual no se encuentra abierto", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    End If
                Else
                    MsgBox("El mes no esta dado de alta en el año actual", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                End If
            Else
                MsgBox("Ejercicio Contable no se encuentra disponible para asignar acumulado de saldos", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Exit Sub
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                    MsgBox("Ocurrio un error al realizar la actualización de saldos", MsgBoxStyle.Critical, "Error")
#End If
            trans.Rollback()
        Finally
            'Me.BarraProgreso.Visible = False
            'Timer.Stop()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    'Private Sub btnActualizar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnActualizar.MouseDown
    '    'Me.BarraProgreso.Visible = True
    '    Me.Timer.Start()
    'End Sub
End Class