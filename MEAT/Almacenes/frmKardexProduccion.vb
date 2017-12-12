Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class frmKardexProduccion

    Dim MovAlm As New CC.MscmovtosAlmacenCabCollection
    Dim Lista As New TC.VwAlmKardexProduccionTypedView
    Dim ListaDet As New TC.VwAlmKardexProduccionDetTypedView
    Dim band As Boolean

    Private Sub frmKardexProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            'obteniendo Productos
            Me.ProductosCol.Obtener(CondicionEstatusEnum.ACTIVO, False)

            'Meses
            band = True
            Me.cmbMes.DataSource = New ClasesNegocio.MesesCollectionClass
            'LlenarAños()
            'Obteniendo almacenes
            Me.AlmacenC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Me.limpiar()
            Deshabilitar()
            Me.DtpFecha.Value = Now
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "Metodos"
    Private Sub limpiar()
        Me.CmbProducto.SelectedIndex = -1
        Me.cmbAlmacen.SelectedIndex = -1
        Me.txtExistenciaInicialKgrs.Clear()
        Me.txtExistenciaInicialPzas.Clear()
        Me.txtExistenciaPzas.Clear()
        Me.txtTotalEntradasKgrs.Clear()
        Me.txtTotalSalidasKgrs.Clear()
        Me.CmbAño.SelectedIndex = -1
        Me.cmbMes.SelectedIndex = -1
        Me.txtCostoInicial.Text = ""
        Me.txtExistenciaKgrs.Text = ""
        Me.txtTotalEntradasPzas.Text = ""
        Me.txtTotalSalidasPzas.Text = ""
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
    Private Sub LlenarAños()
        Try
            If band = False Then
                If Me.cmbAlmacen.SelectedIndex > -1 And Me.CmbProducto.SelectedIndex > -1 Then
                    Dim maxFecha As Object
                    Dim minFecha As Object
                    Dim filtro As New OC.PredicateExpression
                    Dim rel As New OC.RelationCollection
                    rel.Add(EC.MscmovtosAlmacenCabEntity.Relations.MscmovtosAlmacenDetEntityUsingIdFolioMovimiento, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
                    filtro.Add(HC.MscmovtosAlmacenCabFields.IdCodAlmacen = Me.cmbAlmacen.SelectedValue)
                    filtro.Add(HC.MscmovtosAlmacenDetFields.IdCodProducto = Me.CmbProducto.SelectedValue)
                    maxFecha = MovAlm.GetScalar(IntegraLab.ORM.MscmovtosAlmacenCabFieldIndex.FechaMovimiento, New OC.Expression(HC.MscmovtosAlmacenCabFields.FechaMovimiento), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max, filtro, rel, Nothing)
                    minFecha = MovAlm.GetScalar(IntegraLab.ORM.MscmovtosAlmacenCabFieldIndex.FechaMovimiento, New OC.Expression(HC.MscmovtosAlmacenCabFields.FechaMovimiento), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Min, filtro, rel, Nothing)
                    If minFecha.ToString = "" Then
                        MessageBox.Show("No se encontraron Movimientos del Producto especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Me.CmbAño.DataSource = New ClasesNegocio.AñoCollectionClass(minFecha, maxFecha)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'suma las entradas y salidas de las piezas y kilos para el kardex los totales del kardex en la parte superior de la forma
    Private Sub Sumas()
        Try
            Dim TotalEntradasPzas As Integer
            Dim TotalEntradasKgrs As Integer
            Dim TotalSalidasPzas As Integer
            Dim TotalSalidasKgrs As Integer
            Dim ExistenciaPzas As Integer
            Dim ExistenciaKgrs As Integer
            Me.txtTotalEntradasKgrs.Text = 0
            Me.txtTotalEntradasPzas.Text = 0
            Me.txtTotalSalidasKgrs.Text = 0
            Me.txtTotalSalidasPzas.Text = 0
            Me.txtExistenciaPzas.Text = 0
            Me.txtExistenciaKgrs.Text = 0

            'suma las entradas y salidas de las piezas y kilos para el kardex
            For i As Integer = 0 To Me.DgvDetalles.Rows.Count - 1
                If Me.DgvDetalles.Rows(i).Cells("clmTipoMovimiento").Value = 0 Then
                    TotalEntradasPzas += Me.DgvDetalles.Rows(i).Cells("clmCantidadPzas").Value
                    TotalEntradasKgrs += Me.DgvDetalles.Rows(i).Cells("clmCantidadKgrs").Value
                Else
                    TotalSalidasPzas += Me.DgvDetalles.Rows(i).Cells("clmCantidadPzas").Value
                    TotalSalidasKgrs += Me.DgvDetalles.Rows(i).Cells("clmCantidadKgrs").Value
                End If
            Next
            Me.txtTotalEntradasPzas.Text = TotalEntradasPzas
            Me.txtTotalEntradasKgrs.Text = TotalEntradasKgrs.ToString("N2")
            Me.txtTotalSalidasPzas.Text = TotalSalidasPzas
            Me.txtTotalSalidasKgrs.Text = TotalSalidasKgrs.ToString("N2")

            ExistenciaPzas = Me.txtExistenciaInicialPzas.Text + TotalEntradasPzas - TotalSalidasPzas
            ExistenciaKgrs = Me.txtExistenciaInicialKgrs.Text + TotalEntradasKgrs - TotalSalidasKgrs
            Me.txtExistenciaKgrs.Text = ExistenciaKgrs.ToString("N2")
            Me.txtExistenciaPzas.Text = ExistenciaPzas.ToString("N2")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'suma las cantidades de los movimientos de almacen desplegados en el grid.
    Private Sub Existencia()
        Dim i As Integer
        Dim existenciaPzas As Integer = Me.txtExistenciaInicialPzas.Text
        Dim existenciaKgrs As Integer = Me.txtExistenciaInicialKgrs.Text
        For i = 0 To Me.DgvDetalles.Rows.Count - 1
            If Me.DgvDetalles.Rows(i).Cells("clmTipoMovimiento").Value = 0 Then              
                existenciaPzas += Me.DgvDetalles.Rows(i).Cells("clmCantidadPzas").Value
                Me.DgvDetalles.Rows(i).Cells("clmExistenciaPzas").Value = existenciaPzas
                existenciaKgrs += Me.DgvDetalles.Rows(i).Cells("clmCantidadKgrs").Value
                Me.DgvDetalles.Rows(i).Cells("clmExistenciaKgrs").Value = existenciaKgrs
            Else
                existenciaPzas -= Me.DgvDetalles.Rows(i).Cells("clmCantidadPzas").Value
                Me.DgvDetalles.Rows(i).Cells("clmExistenciaPzas").Value = existenciaPzas
                existenciaKgrs -= Me.DgvDetalles.Rows(i).Cells("clmCantidadkgrs").Value
                Me.DgvDetalles.Rows(i).Cells("clmExistenciaKgrs").Value = existenciaKgrs
            End If

            'If Not Me.DgvDetalles.Rows(i).Cells("clmEntradasPzas").Value = Nothing Then
            '    existenciaPzas += Me.DgvDetalles.Rows(i).Cells("clmEntradasPzas").Value
            '    Me.DgvDetalles.Rows(i).Cells("clmExistenciaPzas").Value = existenciaPzas
            'End If
            'If Not Me.DgvDetalles.Rows(i).Cells("clmEntradaKgrs").Value = Nothing Then
            '    existenciaKgrs += Me.DgvDetalles.Rows(i).Cells("clmEntradaKgrs").Value
            '    Me.DgvDetalles.Rows(i).Cells("clmExistenciaKgrs").Value = existenciaKgrs
            'End If
            'If Not Me.DgvDetalles.Rows(i).Cells("clmSalidasPzas").Value = Nothing Then
            '    existenciaPzas -= Me.DgvDetalles.Rows(i).Cells("clmSalidasPzas").Value
            '    Me.DgvDetalles.Rows(i).Cells("clmExistenciaPzas").Value = existenciaPzas
            'End If
            'If Not Me.DgvDetalles.Rows(i).Cells("clmSalidaKgrs").Value = Nothing Then
            '    existenciaKgrs -= Me.DgvDetalles.Rows(i).Cells("clmSalidaKgrs").Value
            '    Me.DgvDetalles.Rows(i).Cells("clmExistenciaKgrs").Value = existenciaKgrs
            'End If

        Next
    End Sub

    Private Sub Buscar()
        'If Me.CmbProducto.SelectedIndex > -1 And Me.cmbAlmacen.SelectedIndex > -1 Then
        Dim Filtro As New OC.PredicateExpression
        Dim Filtro2 As New OC.PredicateExpression


        'Obtener Cabecero
        Filtro.Add(HC.VwAlmKardexProduccionFields.Mes = Me.cmbMes.SelectedValue And HC.VwAlmKardexProduccionFields.Año = Me.CmbAño.SelectedValue)
        Lista.Clear()
        Lista.Fill(0, Nothing, True, Filtro)

        'asignar los valores iniciales del producto al recuadro de cantidades iniciales
        If Lista.Rows.Count > 0 Then
            Me.txtExistenciaInicialKgrs.Text = Lista(0).ExtKilosInicial.ToString("N2")
            Me.txtExistenciaInicialPzas.Text = Lista(0).ExtPiezasInicial.ToString("N2")
            Me.txtCostoInicial.Text = Lista(0).CostoProm.ToString("N2")
        Else
            Me.txtExistenciaInicialKgrs.Text = 0
            Me.txtExistenciaInicialPzas.Text = 0
            Me.txtCostoInicial.Text = 0
        End If

        'Obtener Detalles
        If Me.CmbProducto.SelectedIndex > -1 Then
            Filtro2.Add(HC.VwAlmKardexProduccionDetFields.IdCodAlmacen = Me.cmbAlmacen.SelectedValue)
        End If
        If Me.cmbAlmacen.SelectedIndex > -1 Then
            Filtro2.Add(HC.VwAlmKardexProduccionDetFields.IdCodProducto = Me.CmbProducto.SelectedValue)
        End If

        If Me.cmbMes.SelectedIndex > -1 And Me.CmbAño.SelectedIndex > -1 Then
            Dim FechaIni As String
            FechaIni = "01/" & Me.cmbMes.SelectedValue & "/" & Me.CmbAño.SelectedValue
            'Filtro.Add(New OC.FieldBetweenPredicate(HC.VwAlmKardexProduccionFields.FechaMovimiento, FechaIni, Me.DtpFecha.Value.AddDays(1).ToShortDateString))
            Filtro2.Add(New OC.FieldBetweenPredicate(HC.VwAlmKardexProduccionDetFields.FechaMovimiento, FechaIni, Me.DtpFecha.Value.AddDays(1).ToShortDateString))
        End If
        ListaDet.Clear()
        ListaDet.Fill(0, Nothing, True, Filtro2)
        Me.DgvDetalles.AutoGenerateColumns = False
        Me.DgvDetalles.DataSource = ListaDet

        If Me.DgvDetalles.Rows.Count > 1 Then
            'Me.txtExistenciaInicialKgrs.Text = Lista(0).ExtKilosInicial.ToString("N2")
            'Me.txtExistenciaInicialPzas.Text = Lista(0).ExtPiezasInicial.ToString("N2")
            'Me.txtCostoInicial.Text = Lista(0).UltimoCosto.ToString("N2")
            'Se Busca el costo inicial y la existencua inicial
            'Dim Año As String
            'Dim Mes As String
            'If Me.cmbMes.SelectedValue = "01" Then
            '    Año = Me.CmbAño.SelectedValue - 1
            '    Mes = "12"
            'Else
            '    Año = Me.CmbAño.SelectedValue
            '    Mes = Me.cmbMes.SelectedValue - 1
            'End If
            'Filtro2.Add(HC.InventarioAlmacenFields.Año = Año)
            'Filtro2.Add(HC.InventarioAlmacenFields.Mes = Mes)
            'Filtro2.Add(HC.InventarioAlmacenFields.ProductoId = Me.CmbProducto.SelectedValue)
            'Filtro2.Add(HC.InventarioAlmacenFields.AlmacenId = Me.cmbAlmacen.SelectedValue)

            'OJO
            'InvAlmCol = New CC.InventarioAlmacenCollection
            'InvAlmCol.GetMulti(Filtro2)

            ''Dim Lista2 As New TC.VwAlmKardexDetalleTypedView
            ''Lista2.Fill(0, Nothing, True, Filtro2)

            'If InvAlmCol.Count > 0 Then
            '    Me.txtCostoInicial.Text = InvAlmCol(0).UltimoCosto
            '    ' Me.txtExistenxiaInicial.Text = Lista2(0).Cantidad
            'Else
            '    ' Me.txtExistenxiaInicial.Text = 0
            '    Me.txtCostoInicial.Text = 0
            'End If
            Sumas()
            Existencia()
            If Me.cmbMes.SelectedIndex = -1 Then
                Me.cmbMes.SelectedIndex = Now.Month - 1
            End If
        Else
            MessageBox.Show("No se encontraron movimientos del producto en el rango de fechas especificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'Else
        'MessageBox.Show("Seleccione un producto y un almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
    End Sub

    Private Function Reporte() As rptKardexProduccionCab
        Try
            Dim rpt As New rptKardexProduccionCab
            Dim dt As New dsKardexProduccion.dtKardexProduccionCabDataTable
            Dim dtd As New dsKardexProduccion.dtKardexProduccionDetDataTable

            dt.AdddtKardexProduccionCabRow(Me.CmbProducto.Text, Me.cmbAlmacen.Text, Me.cmbMes.Text, Me.DtpFecha.Value.ToString("dd/MM/yyyy"), Me.CmbAño.Text, Me.txtExistenciaInicialPzas.Text, Me.txtExistenciaInicialKgrs.Text, _
            Me.txtCostoInicial.Text, Me.txtTotalEntradasPzas.Text, Me.txtTotalEntradasKgrs.Text, Me.txtTotalSalidasPzas.Text, Me.txtTotalSalidasKgrs.Text, Me.txtExistenciaPzas.Text, Me.txtExistenciaKgrs.Text)

            For i As Integer = 0 To Me.Lista.Count - 1
                'dtd.AdddtKardexProduccionDetRow(Lista(i).FechaMovimiento.ToString("dd/MM/yyyy"), Lista(i).IdFolioMovimiento, Lista(i).Tmovimiento, Lista(i).EntPzas, Lista(i).EntKilos, _
                '  Lista(i).SalPzas, Lista(i).SalKilos, Me.DgvDetalles.Rows(i).Cells("clmExistenciaPzas").Value, Me.DgvDetalles.Rows(i).Cells("clmExistenciaKgrs").Value, Lista(i).CostoUnitario, Lista(i).CostoProm)
            Next
            'dtd.AdddtKardexProduccionDetRow(
            rpt.SetDataSource(CType(dt, DataTable))
            rpt.Subreports.Item(0).SetDataSource(CType(dtd, DataTable))
            rpt.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            rpt.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            rpt.SetParameterValue(2, "Almacenes")

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

#Region "ToolBar"

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Buscar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Deshabilitar()
        limpiar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim previsualizar As New PreVisualizarForm
            previsualizar.Reporte = Me.Reporte()
            previsualizar.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        limpiar()
        Habilitar()
        Me.band = False
        Me.CmbProducto.Focus()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub CmbProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProducto.SelectedIndexChanged
        Me.LlenarAños()
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        Me.LlenarAños()
    End Sub

    
    
End Class