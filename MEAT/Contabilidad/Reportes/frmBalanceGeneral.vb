Imports ClasesNegocio
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class frmBalanceGeneral

#Region "Miembros"
    Dim Estado As FormState
#End Region

#Region "Metodos"
    Public Sub InicializarForma()
        '' Llenar el combo de Ejercicio (años)
        Using conn As New SqlConnection(HC.DbUtils.ActualConnectionString)
            conn.Open()
            Dim dt As New DataTable
            Dim command As New SqlCommand("SELECT Ejercicio FROM UsrGralPeriodosCont")
            command.Connection = conn
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dt)
            ultCmbEjercicio.DataSource = dt
        End Using
    End Sub

    Public Sub Limpiar()
        Estado = FormState.Limpiar
        ultcmbMes.Clear()
        ultCmbEjercicio.Clear()
    End Sub

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        'Me.CalcularSaldo()
        'PictureBox1.Visible = True
        'Me.Refresh()
        'Me.OnPrintPage()
        'Estado = FormState.Guardar
        'PictureBox1.Visible = True
        'Me.Refresh()

        'If ultcmbMes.SelectedItem IsNot Nothing Then
        '    Dim ColeccionCabecerosBalance As New CabBalanceCollectionClass
        '    ColeccionCabecerosBalance.Obtener()

        '    For Each Balance As CabBalanceClass In ColeccionCabecerosBalance
        '        Balance.CalcularSaldo(Trans, CType(ultcmbMes.SelectedItem.DataValue, MesEnum2))
        '    Next
        '    Trans.Commit()
        '    ColeccionCabecerosBalance.Imprimir(Controlador.Sesion, ultcmbMes.SelectedText.Substring(0, 3) & " " & Now.Year)
        '    PictureBox1.Visible = False
        '    Limpiar()
        '    Return True
        'Else
        '    PictureBox1.Visible = False
        '    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.BALANCE_GENERAL, 0)
        'End If
        Try
            '' Variables necesarias para el reporte
            Dim Reporte As New rptBalanceGeneral
            'Dim Reporte As New rptBalanceGeneralX
            Dim Previsualizar As New PreVisualizarForm
            Dim dt As New DataTable

            ''Obtener los datos desde el procedimiento almacenado "AcumuladosCuentasContablesConsulta"''
            Dim command As New SqlCommand("AcumuladosCuentasContablesConsulta")
            Using conn As New SqlConnection(HC.DbUtils.ActualConnectionString)
                command.Connection = conn
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("V_Op", 1)
                command.Parameters.AddWithValue("V_Ejercicio", Me.ultCmbEjercicio.Value)
                command.Parameters.AddWithValue("V_Mes", Me.ultcmbMes.Value)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using

            Reporte.SetDataSource(dt)
            Reporte.SetParameterValue("EmpresaNombre", Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue("Ejercicio", Me.ultCmbEjercicio.Value)
            Reporte.SetParameterValue("Mes", Me.ultcmbMes.SelectedItem.DisplayText)
            Previsualizar.Reporte = Reporte
            Previsualizar.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Sub Salir()
        Estado = FormState.Salir
        Me.Close()
    End Sub
    'calcular los saldos para balance general
    Private Sub CalcularSaldo()
        Dim dt As New DataTable, dt2 As New DataTable
        Dim Query1 As String = "SELECT  Cc.Codigo," & _
                                    "          NomCuenta," & _
                                    "          Titulo," & _
                                    "          Cef.Descripcion as TituloDes," & _
                                    "          SubTitulo," & _
                                    "          Def.Descripcion as SubtituloDes" & _
                                    " FROM usrContCuentas Cc INNER JOIN ClasificadordeEstadosFinancieros Cef ON Cef.codigo=Cc.Titulo" & _
                                    "						  left JOIN DetalleClasificadordeEstadosFinancieros Def ON def.Codigo = Cc.Subtitulo" & _
                                    " WHERE SubCta='0000' AND ceF.cODIGO BETWEEN 1 AND 3"
        Using ad As New SqlClient.SqlDataAdapter("", IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)
            ad.SelectCommand.Connection.Open()
            ad.SelectCommand.CommandText = Query1
            ad.SelectCommand.Prepare()
            ad.Fill(dt)
        End Using

        Me.dgvCuentasContables.AutoGenerateColumns = False
        Me.dgvCuentasContables.DataSource = dt

        For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1
            Dim Balance As New BalanceGeneralClass
            Dim CuentaCon As New CuentaContableClass
            Balance.IdCuenta = Me.dgvCuentasContables.Rows(i).Cells(Me.clmCodigoCuenta.Index).Value
            Balance.Ejercicio = CInt(Me.ultCmbEjercicio.Value)
            'Select Case Me.ultcmbMes.SelectedIndex
            '    Case 0
            '        Balance.CalcularSaldo(MesEnum2.ENERO)
            '    Case 1
            '        Balance.CalcularSaldo(MesEnum2.FEBRERO)
            '    Case 2
            '        Balance.CalcularSaldo(MesEnum2.MARZO)
            '    Case 3
            '        Balance.CalcularSaldo(MesEnum2.ABRIL)
            '    Case 4
            '        Balance.CalcularSaldo(MesEnum2.MAYO)
            '    Case 5
            '        Balance.CalcularSaldo(MesEnum2.JUNIO)
            '    Case 6
            '        Balance.CalcularSaldo(MesEnum2.JULIO)
            '    Case 7
            '        Balance.CalcularSaldo(MesEnum2.AGOSTO)
            '    Case 8
            '        Balance.CalcularSaldo(MesEnum2.SEPTIEMBRE)
            '    Case 9
            '        Balance.CalcularSaldo(MesEnum2.OCTUBRE)
            '    Case 10
            '        Balance.CalcularSaldo(MesEnum2.NOVIEMBRE)
            '    Case 11
            '        Balance.CalcularSaldo(MesEnum2.DICIEMBRE)
            'End Select
            ' 
            '' Los meses se empiezan a contar desde el 1, entonces se envia el mes tomando el index de ultCmbMes que empieza de 0 y se le suma 1
            Balance.CalcularSaldo(Me.ultcmbMes.SelectedIndex + 1)
            Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value = Balance.Saldo

        Next


    End Sub
    'metodos para traer la informacion a imprimir en balance general
    Private Sub PrintBalance_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintBalance.PrintPage
        Dim Ejercio As Integer
        Ejercio = 2017
        Dim fn As New Drawing.Font("Courier New", 10)
        Dim fnt As New Drawing.Font("Courier New", 12)
        'imprimir en documento.
        Dim tx As Single
        Dim ty As Single
        tx = 20
        ty = 30
        'DgvDatos.DataSource = dt
        'Dim BandTitulos1 As Boolean
        'Dim BandTitulos2 As Boolean
        Dim Titulo As String
        Dim TituloAux As String
        Dim SubTitulo As String
        Dim SubTituloAux As String
        TituloAux = ""
        SubTituloAux = ""
        tx = 20
        ty = 75
        'e.HasMorePages = True
        For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1 ' DgvDatos.Rows.Count - 1
            'titulo para el estado de resultado
            e.Graphics.DrawString("BALANCE GENERAL DE " & Controlador.Sesion.MiEmpresa.Empnom, fnt, Drawing.Brushes.Black, 100, 30)
            e.Graphics.DrawString("DEL MES " & Me.ultcmbMes.Text, fnt, Drawing.Brushes.Black, 200, 45)
            e.Graphics.DrawString("AL " & Now.Day & " DEL " & Now.Month.ToString, fnt, Drawing.Brushes.Black, 200, 60)
            'tx = 20
            'ty = 75
            'colacar titulos
            Titulo = Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionTitulo.Index).Value
            If Titulo <> TituloAux Then
                Select Case Me.dgvCuentasContables.Rows(i).Cells(Me.clmCodigoTitulo.Index).Value
                    Case 1
                        e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionTitulo.Index).Value, fn, Drawing.Brushes.Black, 50, ty)
                        tx = 20
                    Case 2
                        e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionTitulo.Index).Value, fn, Drawing.Brushes.Black, 550, 75)
                        ty = 75
                        tx = 350
                    Case 3
                        e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionTitulo.Index).Value, fn, Drawing.Brushes.Black, 550, ty)
                        tx = 350
                End Select
                ty += 15
                TituloAux = Titulo
            End If
            'colocar subtitulos
            If Trim(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionSubtitulo.Index).Value.ToString) <> "" Then
                SubTitulo = Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionSubtitulo.Index).Value
                If SubTitulo <> SubTituloAux Then
                    Select Case Me.dgvCuentasContables.Rows(i).Cells(Me.clmCodigoTitulo.Index).Value
                        Case 1
                            e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionSubtitulo.Index).Value, fn, Drawing.Brushes.Black, 40, ty)
                            tx = 20
                        Case 2
                            e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionSubtitulo.Index).Value, fn, Drawing.Brushes.Black, 540, ty)
                            tx = 450
                        Case 3
                            e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionSubtitulo.Index).Value, fn, Drawing.Brushes.Black, 540, ty)
                            tx = 450
                    End Select
                    ty += 15
                    SubTituloAux = SubTitulo
                End If
            Else
                tx = 450
            End If



            'nombre de la cuenta mayor
            e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmCuentaDescripcion.Index).Value, fn, Drawing.Brushes.Black, tx, ty)
            tx += 300
            'impote de la cuenta mayor
            e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value, fn, Drawing.Brushes.Black, tx, ty)
            ty += 15
            tx -= 300


        Next
        'BandTitulos1 = False
        'BandTitulos2 = False
    End Sub

    Private Sub OnPrintPage() 'ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'traer los datos para impresion 

        AddHandler PrintBalance.PrintPage, AddressOf PrintBalance_PrintPage
        'PrintBalance.Print()
        Dim prtPrev As New PrintPreviewDialog
        prtPrev.Document = PrintBalance


        prtPrev.Text = "Previsualizar documento"
        prtPrev.ShowDialog()

    End Sub

#End Region

#Region "Eventos"
    Private Sub frmBalanceGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InicializarForma()
    End Sub

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickGuardar, MEAToolBar1.ClickSalir
        If e.Button.Text = "Guardar" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Balance General")

            If Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans}) Is Nothing Then
                Trans.Rollback()
            End If
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
    End Sub
#End Region

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Balance General")

        If Utilerias.RunControlException(Me, "Guardar", New Object() {Trans}) Is Nothing Then
            Trans.Rollback()
        End If
    End Sub
End Class