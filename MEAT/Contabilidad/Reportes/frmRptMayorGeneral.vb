Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class frmRptMayorGeneral

#Region "Miembros"
    Dim Estado As FormState
#End Region

#Region "Metodos"
    Public Sub InicializarForma()

    End Sub

    Public Sub Limpiar()
        Estado = FormState.Limpiar
        ultcmbMes.Clear()
    End Sub

    Public Sub Imprimir()
        Estado = FormState.Imprimir

        If (ultcmbMes.SelectedItem IsNot Nothing And ucbe_Ejercicio.SelectedItem IsNot Nothing) Then
            Controlador.ReporteMayorGeneral(ultcmbMes.Value, ucbe_Ejercicio.Value, cbOrdenar.Checked)
        Else
            MessageBox.Show("Debe seleccionar el Mes y Año", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Salir()
        Estado = FormState.Salir
        Me.Close()
    End Sub
    'Carga los ejercicios(años) registrados en la tabla de periodos
    Private Sub cargarEjercicio()
        Dim tablaEjercicios As New DataTable()
        Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connection.Open()
            Try
                Dim query As String = "SELECT Ejercicio FROM UsrGralPeriodosCont"
                Dim command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(tablaEjercicios)
                adapter.Dispose()
            Catch ex As Exception
                MessageBox.Show("No se logró cargar les ejercicios disponibles al Combo Box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connection.Close()
        End Using
        ucbe_Ejercicio.DataSource = tablaEjercicios
        ucbe_Ejercicio.ValueMember = "Ejercicio"
        ucbe_Ejercicio.DisplayMember = "Ejercicio"
    End Sub

#End Region

#Region "Eventos"
    Private Sub frmBalanceGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarForma()
        cargarEjercicio()

        'Diccionario para combobox
        Dim cbMeses As New Dictionary(Of String, String)
        cbMeses.Add("Enero", "01")
        cbMeses.Add("Febrero", "02")
        cbMeses.Add("Marzo", "03")
        cbMeses.Add("Abril", "04")
        cbMeses.Add("Mayo", "05")
        cbMeses.Add("Junio", "06")
        cbMeses.Add("Julio", "07")
        cbMeses.Add("Agosto", "08")
        cbMeses.Add("Septiembre", "09")
        cbMeses.Add("Octubre", "10")
        cbMeses.Add("Noviembre", "11")
        cbMeses.Add("Diciembre", "12")

        ultcmbMes.DisplayMember = "Key"
        ultcmbMes.ValueMember = "Value"
        ultcmbMes.DataSource = New BindingSource(cbMeses, Nothing)
    End Sub

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        PictureBox1.Visible = True
        Utilerias.RunControlException(Me, e.Button.Text)
        PictureBox1.Visible = False
    End Sub
#End Region
End Class