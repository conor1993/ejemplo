Imports ClasesNegocio
Imports ClasesNegocio.AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports Integralab.ORM.EntityClasses
Imports Integralab.ORM.CollectionClasses
Imports Integralab.ORM.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports IntegraLab.ORM.TypedViewClasses

Public Class frmBusquedaMovimientoAlmacen

#Region "Campos"
    Private validarCheckNodos As Boolean = True
    Private valoresTipoMovimientoDefult As New Dictionary(Of Integer, Nullable(Of Boolean))
    Private tiposMovimeintosDic As New Dictionary(Of Integer, TipoMovimientoAlmacenClass)
    Private m_movimientoAlmacen As AlmacenGeneral.MovimientoAlmacenClass

#End Region

#Region "Constructores"
    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.InicializarDiccionarioTipoMovimiento()
    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property MovimientoAlmacen() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            Return Me.m_movimientoAlmacen
        End Get
    End Property
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.ActivarODesactivarNodos(Me.tvTipoMovimientos.Nodes, True)
        Me.txtCodigoAlmacen.Clear()
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un almacén"
        Me.txtEntrega.Clear()
        Me.txtRecibe.Clear()
        Me.chkFiltrarFechas.Checked = False
        Me.dgMovimientosAlmacen.DataSource = Nothing
    End Sub

    Private Sub Buscar()
        Try
            Dim filtro As New OC.PredicateExpression
            Dim filtroEstatus As New OC.PredicateExpression
            Dim vista As New VwBusquedaMovimientosAlmacenTypedView

            If Me.txtFolioMovimeintoAlmacen.Text.Trim = "" Then
                If Me.cmbAlmacen.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaMovimientosAlmacenFields.IdAlmacen = Me.cmbAlmacen.SelectedValue)
                End If

                If Not Me.txtEntrega.Text.Trim = "" Then filtro.Add(HC.VwBusquedaMovimientosAlmacenFields.Entrega Mod String.Format("%{0}%", Me.txtEntrega.Text.Trim))
                If Not Me.txtRecibe.Text.Trim = "" Then filtro.Add(HC.VwBusquedaMovimientosAlmacenFields.Recibe Mod String.Format("%{0}%", Me.txtRecibe.Text.Trim))

                If Me.chkFiltrarFechas.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaMovimientosAlmacenFields.FechaMovimiento, _
                                Me.dtFechaInicial.Value.ToShortDateString, Me.dtFechaFinal.Value.AddDays(1).ToShortDateString))
                End If

                Me.CrearCondicionEstatus(filtroEstatus, Me.tvTipoMovimientos.Nodes)

                If filtroEstatus.Count > 0 Then
                    filtro.Add(filtroEstatus)
                End If
            Else
                filtro.Add(HC.VwBusquedaMovimientosAlmacenFields.FolioMovimiento Mod String.Format("%{0}%", Me.txtFolioMovimeintoAlmacen.Text.Trim))
            End If

            vista.Fill(0, Nothing, True, filtro)
            Me.dgMovimientosAlmacen.AutoGenerateColumns = False
            Me.dgMovimientosAlmacen.DataSource = vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub LlenarTiposMovimientoAlmacen(ByVal Codigo As Integer)
        Try
            Me.validarCheckNodos = False

            Dim tipoMovimientos As New TipoMovimientoAlmacenCollectionClass
            'Dim ConfMovimientosGeneral As New 

            If Codigo = 0 Then
                tipoMovimientos.Obtener(CondicionEnum.ACTIVOS, CondicionDireccionEnum.TODAS)
            Else
                tipoMovimientos.Obtener(Codigo)
            End If


            Me.tvTipoMovimientos.Nodes(0).Nodes.Clear()
            Me.tvTipoMovimientos.Nodes(1).Nodes.Clear()


            For Each tipoMovimiento As TipoMovimientoAlmacenClass In tipoMovimientos
                If tipoMovimiento.Direccion = DireccionEnum.ENTRADAS Then
                    Me.tvTipoMovimientos.Nodes(0).Nodes.Add(tipoMovimiento.Codigo, tipoMovimiento.Nombre)
                    Me.tvTipoMovimientos.Nodes(0).Nodes(Me.tvTipoMovimientos.Nodes(0).Nodes.Count - 1).Checked = _
                                Me.valoresTipoMovimientoDefult(tipoMovimiento.Codigo).GetValueOrDefault(True)
                Else
                    Me.tvTipoMovimientos.Nodes(1).Nodes.Add(tipoMovimiento.Codigo, tipoMovimiento.Nombre)
                    Me.tvTipoMovimientos.Nodes(1).Nodes(Me.tvTipoMovimientos.Nodes(1).Nodes.Count - 1).Checked = _
                                Me.valoresTipoMovimientoDefult(tipoMovimiento.Codigo).GetValueOrDefault(True)
                End If
            Next

            'For Each tipoMovimiento As TipoMovimientoClass In tipoMovimientos
            '    If tipoMovimiento.Direccion = DireccionEnum.ENTRADAS Then
            '        Me.tvTipoMovimientos.Nodes(0).Nodes.Add(tipoMovimiento.Codigo, tipoMovimiento.Nombre)
            '        Me.tvTipoMovimientos.Nodes(0).Nodes(Me.tvTipoMovimientos.Nodes(0).Nodes.Count - 1).Checked = _
            '                    Me.valoresTipoMovimientoDefult(tipoMovimiento.Codigo).GetValueOrDefault(True)
            '    Else
            '        Me.tvTipoMovimientos.Nodes(1).Nodes.Add(tipoMovimiento.Codigo, tipoMovimiento.Nombre)
            '        Me.tvTipoMovimientos.Nodes(1).Nodes(Me.tvTipoMovimientos.Nodes(1).Nodes.Count - 1).Checked = _
            '                    Me.valoresTipoMovimientoDefult(tipoMovimiento.Codigo).GetValueOrDefault(True)
            '    End If
            'Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.validarCheckNodos = True
        End Try
    End Sub

    Private Function BuscarActivos(ByVal nodo As TreeNode) As Boolean
        If nodo.Nodes.Count = 0 Then Return nodo.Checked

        For Each nodoHijo As TreeNode In nodo.Nodes
            If BuscarActivos(nodoHijo) Then Return True
        Next
    End Function

    Private Sub ValidarNodos(ByVal nodos As TreeNodeCollection)
        Dim hayActivos As Boolean = False

        For Each nodo As TreeNode In nodos
            If BuscarActivos(nodo) Then
                hayActivos = True
                Exit For
            End If
        Next

        If Not hayActivos Then ActivarODesactivarNodos(nodos, True)
    End Sub

    Private Sub ActivarODesactivarNodos(ByVal nodos As TreeNodeCollection, ByVal activar As Boolean)
        For Each nodo As TreeNode In nodos
            If nodo.Level = 0 Then
                nodo.Checked = activar
            Else
                nodo.Checked = Me.valoresTipoMovimientoDefult(CInt(nodo.Name)).GetValueOrDefault(activar)
            End If

            ActivarODesactivarNodos(nodo.Nodes, activar)
        Next
    End Sub

    Private Sub InicializarDiccionarioTipoMovimiento()
        Try
            Dim tipos As New TipoMovimientoAlmacenCollectionClass

            tipos.Obtener(CondicionEnum.ACTIVOS, CondicionDireccionEnum.TODAS)
            Me.valoresTipoMovimientoDefult.Clear()

            For Each tipo As TipoMovimientoAlmacenClass In tipos
                Me.valoresTipoMovimientoDefult.Add(tipo.Codigo, New Nullable(Of Boolean))
                Me.tiposMovimeintosDic.Add(tipo.Codigo, tipo)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub EstablecerTipoMovimiento(ByVal tipoMovimiento As AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum, _
                                        ByVal valor As Boolean)
        Dim idTipoMovimiento As Integer

        idTipoMovimiento = AlmacenGeneral.MovimientoAlmacenClass.ObtenerTipoMovimiento(tipoMovimiento)

        If Me.valoresTipoMovimientoDefult.ContainsKey(idTipoMovimiento) Then
            Me.valoresTipoMovimientoDefult(idTipoMovimiento) = valor

            If Me.tiposMovimeintosDic(idTipoMovimiento).Direccion = DireccionEnum.ENTRADAS Then
                Me.tvTipoMovimientos.Nodes(0).Nodes.Add(Me.tiposMovimeintosDic(idTipoMovimiento).Codigo, _
                                                        Me.tiposMovimeintosDic(idTipoMovimiento).Nombre)
                Me.tvTipoMovimientos.Nodes(0).Nodes(Me.tvTipoMovimientos.Nodes(0).Nodes.Count - 1).Checked = _
                                                        Me.valoresTipoMovimientoDefult( _
                                                        Me.tiposMovimeintosDic(idTipoMovimiento).Codigo).GetValueOrDefault(True)
            Else
                Me.tvTipoMovimientos.Nodes(1).Nodes.Add(Me.tiposMovimeintosDic(idTipoMovimiento).Codigo, _
                                                        Me.tiposMovimeintosDic(idTipoMovimiento).Nombre)
                Me.tvTipoMovimientos.Nodes(1).Nodes(Me.tvTipoMovimientos.Nodes(1).Nodes.Count - 1).Checked = _
                                                        Me.valoresTipoMovimientoDefult( _
                                                        Me.tiposMovimeintosDic(idTipoMovimiento).Codigo).GetValueOrDefault(True)
            End If
        End If
    End Sub

    Public Sub EstablecerTipoMovimiento(ByVal direccion As DireccionFiltrada, ByVal valor As Boolean)
        If direccion = DireccionFiltrada.Entradas Then
            EstablecerTipoMovimiento(Entradas_X_Ajuste_Inventario, valor)
            EstablecerTipoMovimiento(Entradas_X_Cancelacion_Salida_X_Preparacion_Mezcla, valor)
            EstablecerTipoMovimiento(Entradas_X_Cancelacion_Traspaso, valor)
            EstablecerTipoMovimiento(Entradas_X_Compra, valor)
            EstablecerTipoMovimiento(Entradas_X_Consignacion, valor)
            EstablecerTipoMovimiento(Entradas_X_Devolucion_Consumo, valor)
            EstablecerTipoMovimiento(Entradas_X_Devolucion_Venta, valor)
            EstablecerTipoMovimiento(Entradas_X_Inventario_Inicial, valor)
            EstablecerTipoMovimiento(Entradas_X_Otros, valor)
            EstablecerTipoMovimiento(Entradas_X_Preparacion_Mezcla, valor)
            EstablecerTipoMovimiento(Entradas_X_Traspaso, valor)
            EstablecerTipoMovimiento(Entradas_X_Cancelacion_Otras_Salidas, valor)
            Me.tvTipoMovimientos.Nodes(0).Checked = valor
        Else
            Me.EstablecerTipoMovimiento(Salidas_X_Ajuste_Inventario, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Cancelacion_Entrada_X_Preparacion_Mezcla, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Cancelacion_Traspaso, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Consumo, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Devolucion_Compra, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Devolucion_Consignacion, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Otros, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Preparacion_Mezcla, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Traspaso, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Venta, valor)
            Me.EstablecerTipoMovimiento(Salidas_X_Cancelacion_Otras_Entradas, valor)
            Me.tvTipoMovimientos.Nodes(1).Checked = valor
        End If
    End Sub

    Private Sub RevisarEstadoNodoPadre(ByVal nodo As TreeNode)
        Dim hayActivos As Boolean = False

        For Each nodoHijo As TreeNode In nodo.Nodes
            If nodoHijo.Checked Then
                hayActivos = True
                Exit For
            End If
        Next

        nodo.Checked = hayActivos
    End Sub

    Private Sub CrearCondicionEstatus(ByVal filtro As OC.PredicateExpression, ByVal nodos As TreeNodeCollection)
        For Each nodo As TreeNode In nodos
            If Not nodo.Level = 0 AndAlso nodo.Checked Then Me.EstablecerEstatus(filtro, CInt(nodo.Name)) Else CrearCondicionEstatus(filtro, nodo.Nodes)
        Next
    End Sub

    Private Sub EstablecerEstatus(ByVal filtroEstatus As OC.PredicateExpression, _
                                    ByVal idTipoMovimiento As Integer)
        If filtroEstatus.Count = 0 Then
            filtroEstatus.Add(HC.VwBusquedaMovimientosAlmacenFields.IdTipoMovimiento = idTipoMovimiento)
        Else
            filtroEstatus.AddWithOr(HC.VwBusquedaMovimientosAlmacenFields.IdTipoMovimiento = idTipoMovimiento)
        End If
    End Sub
#End Region

#Region "Eventos"
#Region "Buttons"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgMovimientosAlmacen.SelectedRows.Count > 0 Then
            Me.m_movimientoAlmacen = New AlmacenGeneral.MovimientoAlmacenClass

            m_movimientoAlmacen.Obtener(CInt(Me.dgMovimientosAlmacen.SelectedRows(0).Cells(Me.IdAlmacenDataGridViewTextBoxColumn.Index).Value), _
                                    Me.dgMovimientosAlmacen.SelectedRows(0).Cells(Me.FolioMovimientoDataGridViewTextBoxColumn.Index).Value.ToString)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "CheckBox"
    Private Sub chkFiltrarFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarFechas.CheckedChanged
        Me.gbRangoFechas.Enabled = Me.chkFiltrarFechas.Checked

        'Dim almacenes As New CC.AlmacenCollection
        'Dim filtro As New OC.PredicateExpression
        'Dim sort As New OC.SortExpression
        'Dim relacion As New OC.RelationCollection
        'Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, " ")
        'Dim numerosRegistroReturn As Integer = 0 '0=Todos
        'Dim numeroPaginas As Integer = 0 'Sin paginacion
        'Dim numeroRegistrosXPaginas As Integer = 0 '0=Sin limite

        'almacenes.GetMulti(filtro, numerosRegistroReturn, sort, relacion, 0, 0)

        If Me.chkFiltrarFechas.Checked Then
            Me.dtFechaFinal.Value = Now
            Me.dtFechaInicial.Value = Now
        End If
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmbAlmacen_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.ActualizarCombo
        'Me.AlmacenC.Obtener(CondicionEnum.TODOS)
    End Sub
#End Region

#Region "Form"
    Private Sub frmBusquedaMovimientoAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.LlenarTiposMovimientoAlmacen(CodigoMovimiento)
            Me.RevisarEstadoNodoPadre(Me.tvTipoMovimientos.Nodes(0))
            Me.RevisarEstadoNodoPadre(Me.tvTipoMovimientos.Nodes(1))
            'Me.AlmacenC.Obtener(CondicionEnum.TODOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Toolbar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "TreeView"
    Private Sub tvTipoMovimientos_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvTipoMovimientos.AfterCheck
        If Not validarCheckNodos Then Exit Sub

        Try
            validarCheckNodos = False

            If e.Node.Nodes.Count > 0 Then
                ActivarODesactivarNodos(e.Node.Nodes, e.Node.Checked)
                Me.RevisarEstadoNodoPadre(e.Node)
            End If

            If Not e.Node.Level = 0 Then
                e.Node.Checked = Me.valoresTipoMovimientoDefult(CInt(e.Node.Name)).GetValueOrDefault(e.Node.Checked)

                If e.Node.Checked Then
                    e.Node.Parent.Checked = Me.valoresTipoMovimientoDefult(CInt(e.Node.Name)).GetValueOrDefault(True)
                Else
                    Me.RevisarEstadoNodoPadre(e.Node.Parent)
                End If
            End If

            Me.ValidarNodos(Me.tvTipoMovimientos.Nodes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.validarCheckNodos = True
        End Try
    End Sub
#End Region
#End Region

#Region "Tipos Anidados"
    Public Enum DireccionFiltrada
        Entradas
        Salidas
    End Enum
#End Region
End Class