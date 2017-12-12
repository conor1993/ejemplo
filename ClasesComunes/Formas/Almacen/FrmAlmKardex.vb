Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports System.Data.SqlClient
Imports ClasesNegocio.AlmacenGeneral

Public Class FrmAlmKardex
    Dim movAlmDet As New CC.InventarioMovimientoAlmacenDetallesCollection
    Dim band As Boolean
    Dim InvAlmCol As CC.InventarioAlmacenCollection
    Dim Lista As New TC.VwAlmKardexTypedView
    Dim ds As New DataSet()
    Private Sub FrmAlmKardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "101011111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "000100001"
            tbEstados.StateNuevo = "111010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")
            band = True
            Me.cmbMes.DataSource = New ClasesNegocio.MesesCollectionClass

            Me.ProductosVistaC.Obtener(CondicionEnum.ACTIVOS)
            Me.CmbProducto.ValueMember = "Codigo"
            Me.CmbProducto.DisplayMember = "Descripcion"
            Me.CmbProducto.DataSource = ProductosVistaC

            Me.AlmacenC.Obtener(CondicionEnum.TODOS)
            Me.limpiar()
            Deshabilitar()
            Me.DtpFecha.Value = Now
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ocurrió un Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        Me.CmbProducto.SelectedIndex = -1
        Me.cmbAlmacen.SelectedIndex = -1
        Me.txtLinea.Text = ""
        Me.CmbAño.SelectedIndex = -1
        Me.cmbMes.SelectedIndex = -1
        Me.txtUnidadMed.Text = ""
        Me.txtCostoInicial.Text = ""
        Me.txtExistencia.Text = ""
        Me.txtTotalEntradas.Text = ""
        Me.txtTotalSalidas.Text = ""
        Me.DgvDetalles.DataSource = Nothing
    End Sub
    Private Sub Deshabilitar()
        Me.CmbProducto.Enabled = False
        Me.cmbAlmacen.Enabled = False
        Me.CmbAño.Enabled = False
        Me.cmbMes.Enabled = False
        Me.DtpFecha.Enabled = False
        Me.DgvDetalles.Enabled = False
    End Sub
    Private Sub Habilitar()
        Me.CmbProducto.Enabled = True
        Me.cmbAlmacen.Enabled = True
        Me.CmbAño.Enabled = True
        Me.cmbMes.Enabled = True
        Me.DtpFecha.Enabled = True
        Me.DgvDetalles.Enabled = True
    End Sub
    'Private Sub LlenarAños()
    '    Try
    '        If band = False Then
    '            If Me.cmbAlmacen.SelectedIndex > -1 And Me.CmbProducto.SelectedIndex > -1 Then
    '                Dim maxFecha As Object
    '                Dim minFecha As Object
    '                Dim filtro As New OC.PredicateExpression
    '                filtro.Add(HC.MinvMovimientosAlmacenPvdetallesFields.AlmacenId = Me.cmbAlmacen.SelectedValue)
    '                filtro.Add(HC.MinvMovimientosAlmacenPvdetallesFields.ProductoId = Me.CmbProducto.SelectedValue)
    '                maxFecha = movAlmDet.GetScalar(Integralab.ORM.MinvMovimientosAlmacenPvFieldIndex.FechaMovimiento, New OC.Expression(HC.MinvMovimientosAlmacenPvFields.FechaMovimiento), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max, filtro)
    '                minFecha = movAlmDet.GetScalar(Integralab.ORM.MinvMovimientosAlmacenPvFieldIndex.FechaMovimiento, New OC.Expression(HC.MinvMovimientosAlmacenPvFields.FechaMovimiento), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Min, filtro)
    '                If minFecha.ToString = "" Then
    '                    MessageBox.Show("No se encontraron Movimientos del Producto especificado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Else
    '                    Me.CmbAño.DataSource = New ClasesNegocio.AñoCollectionClass(minFecha, maxFecha)
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Ocurrió un Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Public Sub LlenarAños()


        Try
            If band = False Then
                If Me.cmbAlmacen.SelectedIndex > -1 And Me.CmbProducto.SelectedIndex > -1 Then
                    Dim mesesinv As New InventarioAlmacenClass
                    Dim cmd As SqlCommand = New SqlCommand("  select min(Fechamovimiento) as fechamin,max(FechaMovimiento) as fechamax from MInvMovimientosAlmacenPV", New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))
                    cmd.CommandType = CommandType.Text
                    Dim resultado As New DataSet()
                    'cmd.Parameters.Add("@FechaInicial", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpFechaInicio.Value.Date.ToString("dd/MM/yyyy 00:00:00"))
                    'cmd.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpFechaFin.Value.Date.ToString("dd/MM/yyyy 23:59:59"))

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.SelectCommand.CommandTimeout = 300

                    adapter.Fill(resultado)
                    cmd.Dispose()

                    If resultado.Tables(0).Rows.Count Then

                        Me.CmbAño.DataSource = New ClasesNegocio.AñoCollectionClass(resultado.Tables(0).Rows(0)("fechamin"), resultado.Tables(0).Rows(resultado.Tables(0).Rows.Count - 1)("fechamax"))
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ocurrió un Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        'Dim table As New DataTable
        'table.Columns.Add("IdAnio", GetType(Integer))
        'table.Columns.Add("Anio", GetType(String))
        'table.Rows.Add(0, "TODOS")
        'Dim YearActual As Integer = Now.Year, i As Integer
        'For i = YearActual - 10 To YearActual
        '    For Each dr As DataRow In resultado.Tables(0).Rows
        '        If i = dr(0) Then
        '            table.Rows.Add(i, i.ToString())
        '        End If
        '    Next
        'Next
        'CmbAño.DisplayMember = "Anio"
        'CmbAño.ValueMember = "IdAnio"
        'CmbAño.DataSource = table
        'CmbAño.SelectedValue = Now.Year
    End Sub


    Private Sub Sumas()
        Try
            Dim TotalEntradas As Integer
            Dim TotalSalidas As Integer
            Dim ExistenciaActual As Integer
            Me.txtTotalEntradas.Text = 0
            Me.txtTotalSalidas.Text = 0
            Me.txtExistencia.Text = 0

            For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                TotalEntradas += CType(Me.DgvDetalles.Rows(i).Cells("clmEntrada").Value, Integer)
                TotalSalidas += CType(Me.DgvDetalles.Rows(i).Cells("clmSalida").Value, Integer)
            Next
            Me.txtTotalEntradas.Text = TotalEntradas
            Me.txtTotalSalidas.Text = TotalSalidas

            ExistenciaActual = Me.txtExistenciaInicial.Text + TotalEntradas - TotalSalidas
            Me.txtExistencia.Text = ExistenciaActual

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Existencia()
        Dim i As Integer
        Dim existencia As Integer = Me.txtExistenciaInicial.Text
        For i = 0 To Me.DgvDetalles.Rows.Count - 1
            If Not Me.DgvDetalles.Rows(i).Cells("clmEntrada").Value Is Nothing Then
                existencia += CType(Me.DgvDetalles.Rows(i).Cells("clmEntrada").Value, Integer)
                Me.DgvDetalles.Rows(i).Cells("clmExistencia").Value = existencia
            End If
            If Not Me.DgvDetalles.Rows(i).Cells("clmSalida").Value Is Nothing Then
                existencia -= CType(Me.DgvDetalles.Rows(i).Cells("clmSalida").Value, Integer)
                Me.DgvDetalles.Rows(i).Cells("clmExistencia").Value = existencia
            End If
        Next
    End Sub

    Private Function Reporte() As rptKardexProductos
        Try
            Dim rpt As New rptKardexProductos
            Dim dt As New dsKardexProductos.dtKardexProductosDataTable
            Dim dtd As New dsKardexProductos.dtKardexProdDetalleDataTable
            dt.AdddtKardexProductosRow(Me.CmbProducto.Text, Me.cmbAlmacen.Text, Me.txtLinea.Text, Me.txtUnidadMed.Text, Me.cmbMes.Text, Me.DtpFecha.Value.ToString("dd-MM-yyyy"), Me.CmbAño.Text, Me.txtCostoInicial.Text, Me.txtExistenciaInicial.Text, Me.txtTotalEntradas.Text, Me.txtTotalSalidas.Text, Me.txtExistencia.Text)
            For Each l As DataRow In ds.Tables(0).Rows
                'dtd.AdddtKardexProdDetalleRow(l.FechaMovimiento.ToString("dd-MM-yyyy"), l.FolioMovimiento, l.Descripcion, l.CantidadEntradas, l.CantidadSalidas, l.Costo, l.CostoPromedio)
                dtd.AdddtKardexProdDetalleRow(l("FechaMovimiento"), l("FolioMovimiento"), l("Descripcion"), l("CantidadEntradas"), l("CantidadSalidas"), l("Costo"), l("CostoPromedio"))
            Next
            rpt.SetDataSource(CType(dt, DataTable))
            rpt.Subreports.Item(0).SetDataSource(CType(dtd, DataTable))
            rpt.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            rpt.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            rpt.SetParameterValue(2, "ALMACENES")

            Return rpt
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
#End Region

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        LlenarAños()
    End Sub

    Private Sub CmbProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProducto.SelectedIndexChanged
        LlenarAños()
    End Sub



#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            If Me.CmbProducto.SelectedIndex > -1 And Me.cmbAlmacen.SelectedIndex > -1 Then
                Dim Filtro As New OC.PredicateExpression
                Dim Filtro2 As New OC.PredicateExpression

                Dim consulta As String = "Select * from vwAlmKardexPV "

                If Me.CmbProducto.SelectedIndex > -1 Then

                    consulta &= "where ProductoId=" & Me.CmbProducto.SelectedValue.ToString()

                    'Filtro.Add(HC.VwAlmKardexFields.AlmacenId = Me.cmbAlmacen.SelectedValue)
                End If
                If Me.cmbAlmacen.SelectedIndex > -1 Then
                    'Filtro.Add(HC.VwAlmKardexFields.ProductoId = Me.CmbProducto.SelectedValue)
                    If consulta.Contains("where") Then
                        consulta &= " and AlmacenId = " & Me.cmbAlmacen.SelectedValue.ToString()
                    Else
                        consulta &= "where AlmacenId=" & Me.cmbAlmacen.SelectedValue.ToString()
                    End If
                End If

                If Me.cmbMes.SelectedIndex > -1 And Me.CmbAño.SelectedIndex > -1 Then
                    Dim FechaIni As String
                    FechaIni = "01/" & Me.cmbMes.SelectedValue.ToString & "/" & Me.CmbAño.SelectedValue.ToString
                    Dim FI As Date
                    Dim FF As DateTime
                    FI = CDate(FechaIni)
                    FF = FI.AddMonths(1).AddMilliseconds(-2)
                    'Filtro.Add(New OC.FieldBetweenPredicate(HC.VwAlmKardexFields.FechaMovimiento, FechaIni, Me.DtpFecha.Value.AddDays(1).ToShortDateString))

                    If consulta.Contains("where") Then
                        consulta &= " and FechaMovimiento between '" & FI.ToShortDateString & "' and '" & Me.DtpFecha.Value.AddDays(1).ToShortDateString & "'" & " and Mes=" & Month(FI).ToString() & " and Año=" & Me.CmbAño.SelectedValue.ToString
                    Else
                        consulta &= "where FechaMovimiento between '" & FI.ToShortDateString & "' and '" & Me.DtpFecha.Value.AddDays(1).ToShortDateString & "'" & " and Mes=" & Month(FI).ToString() & " and Año=" & Me.CmbAño.SelectedValue.ToString
                    End If
                End If
                consulta &= " order by FechaMovimiento"
                Dim cmd As New SqlCommand(consulta, New SqlConnection(HC.DbUtils.ActualConnectionString))
                Dim da As New SqlDataAdapter(cmd)
                ds = New DataSet()

                da.Fill(ds, "logn")
                'Dim dc As DataColumn
                'For Each dc In ds.Tables(0).Columns
                '    Console.Write("{0,12}", dc.ColumnName)
                'Next
                'Console.WriteLine("")
                'Dim dr As DataRow
                'For Each dr In ds.Tables(0).Rows
                '    Dim i As Integer
                '    For i = 1 To ds.Tables(0).Columns.Count
                '        Console.Write("{0,12}", dr(i - 1))
                '    Next i
                '    Console.WriteLine("")
                'Next


                'Lista.Clear()
                'Lista.Fill(0, Nothing, True, Filtro)

                Me.DgvDetalles.AutoGenerateColumns = False
                Me.DgvDetalles.DataSource = ds.Tables(0)

                If Me.DgvDetalles.Rows.Count > 1 Then
                    Me.txtLinea.Text = ds.Tables(0).Rows(0)("LNDescripcion")
                    Me.txtUnidadMed.Text = ds.Tables(0).Rows(0)("UMDescripcion")
                    Me.txtExistenciaInicial.Text = ds.Tables(0).Rows(0)("CantidadInicial")
                    'Se Busca el costo inicial y la existencua inicial
                    Dim Año As String
                    Dim Mes As String
                    Dim Fecha As Date
                    Fecha = CDate("01/" & Me.cmbMes.SelectedValue.ToString() & "/" & Me.CmbAño.SelectedValue.ToString())
                    If Month(Fecha) = 1 Then
                        Año = (CType(Me.CmbAño.SelectedValue, Integer) - 1).ToString
                        Mes = "12"
                    Else
                        Año = Me.CmbAño.SelectedValue
                        Mes = Month(Fecha)
                    End If
                    Filtro2.Add(HC.InventarioAlmacenFields.Año = Año)
                    Filtro2.Add(HC.InventarioAlmacenFields.Mes = Mes)
                    Filtro2.Add(HC.InventarioAlmacenFields.ProductoId = Me.CmbProducto.SelectedValue)
                    Filtro2.Add(HC.InventarioAlmacenFields.AlmacenId = Me.cmbAlmacen.SelectedValue)

                    InvAlmCol = New CC.InventarioAlmacenCollection
                    InvAlmCol.GetMulti(Filtro2)

                    ''Dim Lista2 As New TC.VwAlmKardexDetalleTypedView
                    ''Lista2.Fill(0, Nothing, True, Filtro2)

                    If InvAlmCol.Count > 0 Then
                        Me.txtCostoInicial.Text = InvAlmCol(0).UltimoCosto
                        ' Me.txtExistenxiaInicial.Text = Lista2(0).Cantidad
                    Else
                        ' Me.txtExistenxiaInicial.Text = 0
                        Me.txtCostoInicial.Text = 0
                    End If
                    Sumas()
                    Existencia()
                    If Me.cmbMes.SelectedIndex = -1 Then
                        Me.cmbMes.SelectedIndex = Now.Month - 1
                    End If
                Else
                    MessageBox.Show("No se encontraron movimientos del producto en el rango de fechas especificado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cancelar = True
                End If
            Else
                MessageBox.Show("Seleccione un producto y un almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Deshabilitar()
        limpiar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim previsualizar As New PreVisualizarForm
        previsualizar.Reporte = Me.Reporte
        previsualizar.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            limpiar()
            Habilitar()
            band = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region


    Private Sub DgvDetalles_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvDetalles.DataError

    End Sub

    Private Sub DgvDetalles_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgvDetalles.ColumnHeaderMouseClick
        Me.Existencia()
    End Sub
End Class