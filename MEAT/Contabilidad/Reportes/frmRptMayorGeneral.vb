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

        If ultcmbMes.SelectedItem IsNot Nothing Then
            Controlador.ReporteMayorGeneral(CType(ultcmbMes.SelectedItem.DataValue, MesEnum2), ucbe_Ejercicio.Value)
        Else
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.BALANCE_GENERAL, 0)
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
    End Sub

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        PictureBox1.Visible = True
        Utilerias.RunControlException(Me, e.Button.Text)
        PictureBox1.Visible = False
    End Sub
#End Region
End Class