Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Drawing.Printing
Public Class frmEstadodeResultados

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

    Public Function Imprimir() As Boolean
        Me.CalcularSaldo()
        'PictureBox1.Visible = True
        'Me.Refresh()
        Me.OnPrintPage()
        'Estado = FormState.Guardar
        'PictureBox1.Visible = True
        'Me.Refresh()

        'If ultcmbMes.SelectedItem IsNot Nothing Then
        '    Dim ColeccionCabecerosEstadoResultados As New EstadoResultadoCollectionClass
        '    ColeccionCabecerosEstadoResultados.Obtener()

        '    For Each EstadoResultado As EstadoResultadoClass In ColeccionCabecerosEstadoResultados
        '        EstadoResultado.CalcularSaldo(Trans, CType(ultcmbMes.SelectedItem.DataValue, MesEnum2))
        '    Next
        '    Trans.Commit()
        '    MsgBox("El proceso ha terminado satisfactoriamente.", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
        '    PictureBox1.Visible = False
        '    Limpiar()
        '    Return True
        'Else
        '    PictureBox1.Visible = False
        '    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.BALANCE_GENERAL, 0)
        'End If
    End Function

    Public Sub Salir()
        Estado = FormState.Salir
        Me.Close()
    End Sub
    'calcular los saldos para estado de resultados
    Private Sub CalcularSaldo()
        Dim dt As New DataTable, dt2 As New DataTable
        Dim Query1 As String = "SELECT  Cc.Codigo," & _
                                    "          NomCuenta," & _
                                    "          Titulo," & _
                                    "          Cef.Descripcion as TituloDes," & _
                                    "          SubTitulo" & _
                                    " FROM usrContCuentas Cc INNER JOIN ClasificadordeEstadosFinancieros Cef ON Cef.codigo=Cc.Titulo" & _
                                    " WHERE SubCta='0000' AND ceF.cODIGO BETWEEN 4 AND 8" & _
                                    " Order by Cef.Codigo,Cc.Codigo"
        Using ad As New SqlClient.SqlDataAdapter("", Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)
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
            Balance.Ejercicio = 2010
            Select Case Me.ultcmbMes.SelectedIndex
                Case 0
                    Balance.CalcularSaldo(MesEnum2.ENERO)
                Case 1
                    Balance.CalcularSaldo(MesEnum2.FEBRERO)
                Case 2
                    Balance.CalcularSaldo(MesEnum2.MARZO)
                Case 3
                    Balance.CalcularSaldo(MesEnum2.ABRIL)
                Case 4
                    Balance.CalcularSaldo(MesEnum2.MAYO)
                Case 5
                    Balance.CalcularSaldo(MesEnum2.JUNIO)
                Case 6
                    Balance.CalcularSaldo(MesEnum2.JULIO)
                Case 7
                    Balance.CalcularSaldo(MesEnum2.AGOSTO)
                Case 8
                    Balance.CalcularSaldo(MesEnum2.SEPTIEMBRE)
                Case 9
                    Balance.CalcularSaldo(MesEnum2.OCTUBRE)
                Case 10
                    Balance.CalcularSaldo(MesEnum2.NOVIEMBRE)
                Case 11
                    Balance.CalcularSaldo(MesEnum2.DICIEMBRE)
            End Select
            Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value = Balance.Saldo
        Next

    End Sub
    'metodos para traer la informacion a imprimir en estado de resultados
    
    Private Sub PrintBalance_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintBalance.PrintPage
        Dim Ejercio As Integer
        Ejercio = 2010

        'tamaño de letras para la impresion del documento
        Dim fn As New Drawing.Font("Courier New", 10)
        Dim fnt As New Drawing.Font("Courier New", 12)
        Dim fntot As New Drawing.Font("Courier New", 10, FontStyle.Bold)
        Dim fnlinea As New Drawing.Font("Courier New", 14, FontStyle.Bold)
        'imprimir en documento.
        Dim tx As Single
        Dim ty As Single
        Dim Titulo As String
        Dim TituloAux As String
        Dim CodTitulo As Integer
        Dim CodTituloAux As Integer
        'variables para el calculo de estado de resutados
        Dim UtilidadNeta As Decimal
        Dim UtilidaddeOperacion As Decimal
        Dim UtilidadBruta As Decimal
        Dim Ingresos As Decimal
        Dim CostodeVenta As Decimal
        Dim Gastos As Decimal
        Dim OtrosIngresos As Decimal
        Dim OtrosGastos As Decimal
        'variables de banderas para imprimir solo una vez los totales por utilida bruta, de operacion o neta
        Dim BandBruta As Boolean
        Dim BandOperacion As Boolean
        TituloAux = ""
        BandBruta = False
        BandOperacion = False
        'titulo para el estado de resultado
        e.Graphics.DrawString("ESTADO DE RESULTADOS DE " & Controlador.Sesion.MiEmpresa.Empnom, fnt, Drawing.Brushes.Black, 100, 30)
        e.Graphics.DrawString("DE " & Me.ultcmbMes.SelectedText & " DEL AÑO " & Now.Year, fnt, Drawing.Brushes.Black, 200, 45)
        e.Graphics.DrawString("AL " & Now.Day & " DEL " & Now.Month.ToString, fnt, Drawing.Brushes.Black, 200, 60)
        tx = 20
        ty = 75

        For i As Integer = 0 To Me.dgvCuentasContables.Rows.Count - 1 ' DgvDatos.Rows.Count - 1 
            Titulo = Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionTitulo.Index).Value
            CodTitulo = Me.dgvCuentasContables.Rows(i).Cells(Me.clmCodigoTitulo.Index).Value
            'preguntar para realizar calculos
            Select Case CodTitulo
                Case 4
                    Ingresos += Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value
                Case 5
                    CostodeVenta += Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value
                Case 6
                    Gastos += Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value
                Case 7
                    OtrosIngresos += Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value
                Case 8
                    OtrosGastos += Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value
            End Select

            'preguntar para impresion de calculos
            Select Case CodTitulo
                Case 6
                    If Not BandBruta Then
                        UtilidadBruta = Ingresos - CostodeVenta
                        e.Graphics.DrawString("UTILIDA BRUTA", fntot, Drawing.Brushes.Black, tx, ty)
                        e.Graphics.DrawString("__________", fnlinea, Drawing.Brushes.Black, 580, ty - 20)
                        e.Graphics.DrawString(UtilidadBruta, fntot, Drawing.Brushes.Black, 600, ty)
                        ty += 15
                        BandBruta = True
                    End If
                Case 7
                    If Not BandOperacion Then
                        UtilidaddeOperacion = UtilidadBruta - Gastos
                        e.Graphics.DrawString("UTILIDAD DE OPERACION ", fntot, Drawing.Brushes.Black, tx, ty)
                        e.Graphics.DrawString("__________", fnlinea, Drawing.Brushes.Black, 580, ty - 20)
                        e.Graphics.DrawString(UtilidaddeOperacion, fntot, Drawing.Brushes.Black, 600, ty)
                        ty += 15
                        BandOperacion = True
                    End If
            End Select
            'colacar titulos

            If CodTitulo <> CodTituloAux Then
                e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmDescripcionTitulo.Index).Value, fn, Drawing.Brushes.Black, 50, ty)
                tx = 20
                ty += 15
                CodTituloAux = CodTitulo
            End If
            'nombre de la cuenta mayor
            e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmCuentaDescripcion.Index).Value, fn, Drawing.Brushes.Black, tx, ty)
            tx += 580
            'impote de la cuenta mayor
            e.Graphics.DrawString(Me.dgvCuentasContables.Rows(i).Cells(Me.clmSaldo.Index).Value, fn, Drawing.Brushes.Black, tx, ty)
            ty += 15
            tx -= 580
        Next
        UtilidadNeta = UtilidaddeOperacion + OtrosIngresos - OtrosGastos
        e.Graphics.DrawString("UTILIDAD NETA", fntot, Drawing.Brushes.Black, tx, ty)
        e.Graphics.DrawString("__________", fnlinea, Drawing.Brushes.Black, 580, ty - 20)
        e.Graphics.DrawString(UtilidadNeta, fntot, Drawing.Brushes.Black, 600, ty)
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

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        If e.Button.Text = "Imprimir" Then
            '    Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Imprimir Estado de Resultados")

            '    If Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans}) Is Nothing Then
            '        Trans.Rollback()
            '    End If
            'Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
    End Sub
#End Region

    
End Class