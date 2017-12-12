Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class FrmAlmProdTarjetaAuxiliar
    Dim Tarjeta As New TC.VwAlmTarjetasTypedView
    Dim Existencias As New TC.VwAlmKardexProduccionTypedView

    Private Sub FrmAlmProdTarjetaAuxiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            'Obteniendo almacenes
            Me.AlmacenC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Me.limpiar()
            Deshabilitar()

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
    End Sub
    Private Sub Deshabilitar()
        Me.CmbProducto.Enabled = False
        Me.cmbAlmacen.Enabled = False
    End Sub
    Private Sub Habilitar()
        Me.CmbProducto.Enabled = True
        Me.cmbAlmacen.Enabled = True
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
            'Me.txtTotalEntradasPzas.Text = TotalEntradasPzas
            'Me.txtTotalEntradasKgrs.Text = TotalEntradasKgrs.ToString("N2")
            'Me.txtTotalSalidasPzas.Text = TotalSalidasPzas
            'Me.txtTotalSalidasKgrs.Text = TotalSalidasKgrs.ToString("N2")

            ExistenciaPzas = Me.txtExistenciaInicialPzas.Text + TotalEntradasPzas - TotalSalidasPzas
            ExistenciaKgrs = Me.txtExistenciaInicialKgrs.Text + TotalEntradasKgrs - TotalSalidasKgrs
            Me.txtExistenciasEnKilos.Text = ExistenciaKgrs.ToString("N2")
            Me.txtExistenciaEnPiezas.Text = ExistenciaPzas.ToString("N2")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'suma las cantidades de los movimientos de almacen desplegados en el grid.
    Private Sub Existencia()
        Try
            Dim i As Integer
            Dim existenciaPzas As Integer = Me.txtExistenciaInicialPzas.Text
            Dim existenciaKgrs As Integer = Me.txtExistenciaInicialKgrs.Text
            For i = 0 To Me.dgvDetalles.Rows.Count - 1
                If Me.dgvDetalles.Rows(i).Cells("clmTipoMovimiento").Value = 0 Then
                    existenciaPzas += Me.dgvDetalles.Rows(i).Cells("clmCantidadPzas").Value
                    existenciaKgrs += Me.dgvDetalles.Rows(i).Cells("clmCantidadKgrs").Value
                Else
                    existenciaPzas -= Me.dgvDetalles.Rows(i).Cells("clmCantidadPzas").Value
                    existenciaKgrs -= Me.dgvDetalles.Rows(i).Cells("clmCantidadkgrs").Value
                End If

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            'If Me.CmbProducto.SelectedIndex > -1 And Me.cmbAlmacen.SelectedIndex > -1 Then
            Dim Filtro As New OC.PredicateExpression
            Dim Filtro2 As New OC.PredicateExpression
            Dim Año As Integer
            Dim Mes As Integer

            'Obtener existencias
            Año = Year(Me.dtFechaInicial.Value)
            Mes = Month(Me.dtFechaInicial.Value)
            Filtro.Add(HC.VwAlmKardexProduccionFields.Año = Año And HC.VwAlmKardexProduccionFields.Mes = Mes And HC.VwAlmKardexProduccionFields.IdCodAlmacen = Me.cmbAlmacen.SelectedValue And HC.VwAlmKardexProduccionFields.IdCodProducto = Me.CmbProducto.SelectedValue)
            Existencias.Clear()
            Existencias.Fill(0, Nothing, True, Filtro)

            'asignar los valores iniciales del producto al recuadro de cantidades iniciales
            If Existencias.Rows.Count > 0 Then
                Me.txtExistenciaInicialKgrs.Text = Existencias(0).ExtKilosInicial.ToString("N2")
                Me.txtExistenciaInicialPzas.Text = Existencias(0).ExtPiezasInicial.ToString("N2")
            Else
                Me.txtExistenciaInicialKgrs.Text = 0
                Me.txtExistenciaInicialPzas.Text = 0
            End If

            'Obtener Detalles
            Filtro2.Add(HC.VwAlmTarjetasFields.IdCodAlmacen = Me.cmbAlmacen.SelectedValue And HC.VwAlmTarjetasFields.IdCodProducto = Me.CmbProducto.SelectedValue)
            Filtro2.Add(New OC.FieldBetweenPredicate(HC.VwAlmTarjetasFields.FechaMovimiento, Me.dtFechaInicial.Value.ToLongDateString, Me.DtFechaFinal.Value.AddDays(1).ToShortDateString))
            Tarjeta.Clear()
            Tarjeta.Fill(0, Nothing, True, Filtro2)
            Me.dgvDetalles.AutoGenerateColumns = False
            Me.dgvDetalles.DataSource = Tarjeta

            If Me.dgvDetalles.Rows.Count > 1 Then
                Sumas()
                Existencia()
            Else
                MessageBox.Show("No se encontraron movimientos del producto en el rango de fechas especificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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


    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        limpiar()
        Habilitar()
        Me.cmbAlmacen.Focus()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

End Class