Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ClasesNegocio

Public Class FrmABCPrecioxClienteDestino

#Region "Miembros"
    Private dtProdCatPrexCort As dsCatPrecios.CatPrexCortDataTable
    Private dtProdCatPrexProd As dsCatPrecios.CatPrexProdDataTable
    Private chkTodos As CheckBox
#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        'Incrustar chekbox de Todos
        chkTodos = New CheckBox()
        chkTodos.BackColor = Color.White
        Dim rect As Rectangle = dgvClientes.GetCellDisplayRectangle(0, -1, True)
        chkTodos.Size = New Size(14, 14)
        chkTodos.Location = rect.Location
        chkTodos.Left = 5
        chkTodos.Top = 10
        AddHandler chkTodos.CheckedChanged, AddressOf chkTodos_CheckedChanged
        dgvClientes.Controls.Add(chkTodos)

        dgvProductos.AutoGenerateColumns = False
        dgvClientes.AutoGenerateColumns = False
        dgvDestinos.AutoGenerateColumns = False
        Limpiar()
    End Sub

    Private Sub VerificarMovimientoProductos(ByVal Producto As DataGridViewRow)
        Dim Resultado As Boolean = False

        If IsNumeric(Producto.Cells(clmPrecioNuevo.Index).Value) AndAlso Decimal.Parse(Producto.Cells(clmPrecioNuevo.Index).Value.ToString) > 0 Then
            Resultado = True
        End If

        For Each Cliente As DataGridViewRow In CType(Producto.Tag, Collection)
            If Resultado Or CType(Cliente.Cells(clmSeleccion.Index).Value, Boolean) <> Resultado Then
                Dim Celda As DataGridViewCheckBoxCell = CType(Cliente.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)
                Celda.EditingCellFormattedValue = Resultado
                Celda.Value = Resultado
                dgvClientes_CellContentClick(Producto, New DataGridViewCellEventArgs(clmSeleccion.Index, Cliente.Index))
            End If
        Next
    End Sub

    Private Sub VerificarMovimientoProductoDestino(ByVal Cliente As DataGridViewRow, ByVal IdPuntoEntrega As Integer, ByVal Producto As DataGridViewRow, ByVal Precio As Decimal)
        Dim IdPreCorte As Integer = 0

        If Not IsDBNull(Producto.Cells(clmIdPreCorte.Index).Value) Then
            IdPreCorte = Integer.Parse(Producto.Cells(clmIdPreCorte.Index).Value.ToString())
        End If

        If Precio <> 0 Then
            AgregarProducto(Cliente, Producto, IdPuntoEntrega, Precio)
        Else
            QuitarProducto(Integer.Parse(Cliente.Cells(clmIdCliente.Index).Value.ToString), Producto, IdPuntoEntrega)
        End If
    End Sub

    Private Sub AgregarProducto(ByVal Cliente As DataGridViewRow, ByVal Producto As DataGridViewRow, Optional ByVal IdPuntoEntrega As Object = Nothing, Optional ByVal Precio As Object = Nothing)
        Dim drSelectProductos() As DataRow = Nothing, dtProductos As DataTable = Nothing
        Dim IdCliente As Short = Short.Parse(Cliente.Cells(clmIdCliente.Index).Value.ToString), WhereDestino As String = ""
        Dim IdProducto As Short = Short.Parse(Producto.Cells(clmIdProducto.Index).Value.ToString)
        Dim Categoria As Char = Producto.Cells(clmCategoria.Index).Value.ToString()(0)
        Dim IdPreCorte As Short = 0

        If Not IsDBNull(Producto.Cells(clmIdPreCorte.Index).Value) Then
            IdPreCorte = Short.Parse(Producto.Cells(clmIdPreCorte.Index).Value.ToString)
        End If

        If Categoria = "C" Then
            dtProductos = dtProdCatPrexCort
        Else
            dtProductos = dtProdCatPrexProd
        End If

        If IsNumeric(IdPuntoEntrega) Then
            WhereDestino = " AND IdPuntoEntrega = " & IdPuntoEntrega.ToString
        Else
            Precio = Val(Producto.Cells(clmPrecioNuevo.Index).Value).ToString("N4")
        End If
        drSelectProductos = dtProductos.Select("IdCliente = " & IdCliente & WhereDestino & " AND IdProducto = " & IdProducto)

        If drSelectProductos IsNot Nothing AndAlso drSelectProductos.Length > 0 Then
            For Each Renglon As DataRow In drSelectProductos
                dtProductos.Rows.Remove(Renglon)
            Next
        End If

        If IsNumeric(IdPuntoEntrega) Then
            If Categoria = "C" Then
                dtProdCatPrexCort.AddCatPrexCortRow(IdCliente, Short.Parse(IdPuntoEntrega.ToString), IdPreCorte, IdProducto, Decimal.Parse(Precio.ToString))
            Else
                dtProdCatPrexProd.AddCatPrexProdRow(IdCliente, Short.Parse(IdPuntoEntrega.ToString), IdProducto, Decimal.Parse(Precio.ToString))
            End If
        Else
            ActualizarDestinosyPreciosActuales(Cliente)

            For Each Destino As DataRow In CType(Cliente.Tag, DataSet).Tables(0).Rows
                IdPuntoEntrega = Destino.Item("IdPuntoEntrega")

                If Categoria = "C" Then
                    dtProdCatPrexCort.AddCatPrexCortRow(CType(IdCliente, Short), CType(IdPuntoEntrega, Short), CType(IdPreCorte, Short), CType(IdProducto, Short), CType(Precio, Decimal))
                Else
                    dtProdCatPrexProd.AddCatPrexProdRow(IdCliente, Short.Parse(IdPuntoEntrega.ToString), IdProducto, Decimal.Parse(Precio.ToString))
                End If
            Next
        End If
        dtProductos.Dispose()
        dtProductos = Nothing
    End Sub

    Private Sub QuitarProducto(ByVal IdCliente As Integer, ByVal Producto As DataGridViewRow, Optional ByVal IdPuntoEntrega As Object = Nothing)
        Dim drClientes() As DataRow = Nothing, dtProductos As DataTable = Nothing
        Dim IdProducto As Integer = Integer.Parse(Producto.Cells(clmIdProducto.Index).Value.ToString)
        Dim WhereDestino As String = "", Categoria As Char = Producto.Cells(clmCategoria.Index).Value.ToString()(0)

        If IdPuntoEntrega IsNot Nothing And IsNumeric(IdPuntoEntrega) Then
            WhereDestino = " AND IdPuntoEntrega = " & IdPuntoEntrega.ToString
        End If

        If Categoria = "C" Then
            dtProductos = dtProdCatPrexCort
        Else
            dtProductos = dtProdCatPrexProd
        End If
        drClientes = dtProductos.Select("IdCliente = " & IdCliente & WhereDestino & " AND IdProducto = " & IdProducto)

        If drClientes IsNot Nothing AndAlso drClientes.Length > 0 Then
            For Each Renglon As DataRow In drClientes
                dtProductos.Rows.Remove(Renglon)
            Next
        End If
        dtProductos.Dispose()
        dtProductos = Nothing
    End Sub

    Private Sub EscrituraDestinosPrecios(ByVal Modo As Boolean)
        For Each Renglon As DataGridViewRow In dgvDestinos.Rows
            Renglon.Cells(clmPrecio.Index).ReadOnly = Not Modo
        Next
    End Sub

    Private Sub ActualizarDestinosyPreciosActuales(ByVal Cliente As DataGridViewRow)
        If Cliente.Tag Is Nothing OrElse Not CType(Cliente.Tag, DataSet).Tables(0).Rows.Count > 0 _
        OrElse CType(Cliente.Tag, DataSet).Tables(1) Is Nothing _
        OrElse Integer.Parse(CType(Cliente.Tag, DataSet).Tables(0).Rows(0).Item("IdCliente").ToString) <> Integer.Parse(Cliente.Cells(clmIdCliente.Index).Value.ToString) Then
            Cliente.Tag = New DataSet()
            Dim dtProductos As DataTable = Nothing

            dtProductos = CC.CatPrexCortCollection.GetMultiAsDataTable(HC.CatPrexCortFields.CveCliente = Cliente.Cells(clmIdCliente.Index).Value, 0, Nothing)
            dtProductos.Merge(CC.CatPrexProdCollection.GetMultiAsDataTable(HC.CatPrexProdFields.CveCliente = Cliente.Cells(clmIdCliente.Index).Value, 0, Nothing))

            CType(Cliente.Tag, DataSet).Tables.AddRange(New DataTable() { _
                CC.MgralcatPuntosEntregaCollection.GetMultiAsDataTable(HC.MgralcatPuntosEntregaFields.IdCliente = Cliente.Cells(clmIdCliente.Index).Value And HC.MgralcatPuntosEntregaFields.Estatus = "V", 0, New OC.SortExpression(New OC.SortClause(HC.MgralcatPuntosEntregaFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))), _
                dtProductos})
        End If
    End Sub

    Private Sub ActualizarPreciosDestinos()
        Dim IdCliente As Integer = Integer.Parse(dgvClientes.SelectedRows(0).Cells(clmIdCliente.Index).Value.ToString)
        Dim IdProducto As Integer = Integer.Parse(dgvProductos.SelectedRows(0).Cells(clmIdProducto.Index).Value.ToString)
        Dim Categoria As Char = dgvProductos.SelectedRows(0).Cells(clmCategoria.Index).Value.ToString()(0)

        For Each Renglon As DataGridViewRow In dgvDestinos.Rows
            Dim IdPuntoEntrega As Integer = Integer.Parse(Renglon.Cells(clmIdPuntoEntrega.Index).Value.ToString)
            Dim dr() As DataRow = Nothing

            If dgvClientes.CurrentRow.Tag IsNot Nothing AndAlso CType(dgvClientes.CurrentRow.Tag, DataSet).Tables(1) IsNot Nothing AndAlso CType(dgvClientes.CurrentRow.Tag, DataSet).Tables(1).Rows.Count > 0 Then
                Dim Precios() As DataRow = CType(dgvClientes.CurrentRow.Tag, DataSet).Tables(1).Select("CveDestino = " & IdPuntoEntrega.ToString & " AND " & IIf(Categoria = "C", "CveSubCorte", "CveProdRas").ToString & " = " & IdProducto)

                If Precios IsNot Nothing AndAlso Precios.Length > 0 Then
                    Renglon.Cells(clmPrecioActual.Index).Value = Precios(0).Item("PrecioxKgr")
                Else
                    Renglon.Cells(clmPrecioActual.Index).Value = ""
                End If
            End If

            If Categoria = "C" Then
                dr = dtProdCatPrexCort.Select("IdCliente = " & IdCliente & " AND IdProducto = " & IdProducto & " AND IdPuntoEntrega = " & IdPuntoEntrega)
            Else
                dr = dtProdCatPrexProd.Select("IdCliente = " & IdCliente & " AND IdProducto = " & IdProducto & " AND IdPuntoEntrega = " & IdPuntoEntrega)
            End If

            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                Renglon.Cells(clmPrecio.Index).Value = dr(0)("PrecioxKgr")
            Else
                Renglon.Cells(clmPrecio.Index).Value = ""
            End If
        Next
    End Sub

    Private Sub RefrescarClientesSeleccionados()
        Dim IdProducto As Integer = Integer.Parse(dgvProductos.SelectedRows(0).Cells(clmIdProducto.Index).Value.ToString)
        Dim Categoria As Char = dgvProductos.SelectedRows(0).Cells(clmCategoria.Index).Value.ToString()(0)
        Dim Clientes As New Collection

        For Each Renglon As DataGridViewRow In dgvClientes.Rows
            Dim IdCliente As Integer = Integer.Parse(Renglon.Cells(clmIdCliente.Index).Value.ToString)
            Dim dr() As DataRow = Nothing

            If Categoria = "C" Then
                dr = dtProdCatPrexCort.Select("IdCliente = " & IdCliente & " AND IdProducto = " & IdProducto)
            Else
                dr = dtProdCatPrexProd.Select("IdCliente = " & IdCliente & " AND IdProducto = " & IdProducto)
            End If

            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                Renglon.Cells(clmSeleccion.Index).Value = True
                Clientes.Add(Renglon, IdCliente.ToString)
            Else
                Renglon.Cells(clmSeleccion.Index).Value = False
            End If
        Next
        dgvProductos.SelectedRows(0).Tag = Clientes
        RemoveHandler chkTodos.CheckedChanged, AddressOf chkTodos_CheckedChanged

        If Clientes.Count = dgvClientes.Rows.Count Then
            chkTodos.Checked = True
        Else
            chkTodos.Checked = False
        End If
        AddHandler chkTodos.CheckedChanged, AddressOf chkTodos_CheckedChanged
    End Sub
#End Region

#Region "Acciones_Menu"
    Public Sub Limpiar()
        dtProdCatPrexCort = New dsCatPrecios.CatPrexCortDataTable
        dtProdCatPrexProd = New dsCatPrecios.CatPrexProdDataTable
        chkTodos.Checked = False
        nudAumentoPrecio.Value = 0
        txtTodoa.Text = ""

        Me.Validate()
        dgvProductos.DataSource = Nothing
        If Controlador.ObtenerPreciosMasFrecuentesdeProductos.Rows.Count > 0 Then
            dgvProductos.DataSource = Controlador.ObtenerPreciosMasFrecuentesdeProductos()
            dgvProductos.CurrentRow.Tag = New Collection()
        Else
            MsgBox("No se enconto ningun Producto", MsgBoxStyle.Information, "No hay Informacion")
            Exit Sub
        End If

        dgvClientes.DataSource = Nothing
        If Controlador.ObtenerClientes(EstatusChar.VIGENTE, True).Rows.Count > 0 Then
            dgvClientes.DataSource = Controlador.ObtenerClientes(ClasesNegocio.EstatusChar.VIGENTE, True)
        Else
            MsgBox("No se enconto ningun Cliente", MsgBoxStyle.Information, "No hay Informacion")
            Exit Sub
        End If

        If dgvClientes.CurrentRow IsNot Nothing AndAlso dgvClientes.CurrentRow.Tag Is Nothing Then
            ActualizarDestinosyPreciosActuales(dgvClientes.CurrentRow)
        End If
    End Sub

    Public Function Guardar(ByVal Trans As SqlTransaction) As Boolean
        Dim Cambios As Boolean = False
        Me.Validate()

        If (IsNumeric(txtTodoa.Text) AndAlso Decimal.Parse(txtTodoa.Text) > 0 Or nudAumentoPrecio.Value > 0) Then ' AndAlso Clientes.Count > 0
            Cambios = True

            If IsNumeric(txtTodoa.Text) AndAlso Val(txtTodoa.Text) > 0 Then
                Dim NuevoPrecio As Decimal = (Decimal.Parse(txtTodoa.Text) * (1 + nudAumentoPrecio.Value / 100))
                Controlador.ModificarPreciosClientes(Nothing, NuevoPrecio, Trans)
            Else
                Controlador.AumentarPreciosClientes(Nothing, nudAumentoPrecio.Value, Trans)
            End If
        End If

        If dtProdCatPrexCort.Count > 0 OrElse dtProdCatPrexProd.Count > 0 Then
            Cambios = True
            Controlador.ModificarPreciosClientes(dtProdCatPrexCort, Trans)
            Controlador.ModificarPreciosClientes(dtProdCatPrexProd, Trans)
        ElseIf Not Cambios Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CATALOGO_DE_PRECIOS_X_CLIENTE, 0)
        End If

        Trans.Commit()
        MessageBox.Show("Se han aplicado los cambios satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
        Limpiar()
        Return True
    End Function

    Public Sub Imprimir()
        Controlador.ImpresionPrecios()
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub FrmABCPrecioxClienteDestino_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar, mtb.ClickImprimir, mtb.ClickLimpiar, mtb.ClickSalir
        Cursor = Cursors.WaitCursor

        If e.Button.Text = "Guardar" Then
            Using Conexion As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Conexion.Open()
                Dim Trans As SqlTransaction = Conexion.BeginTransaction()
                Dim Resultado As Object = Nothing

                Resultado = Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans})

                If Resultado Is Nothing OrElse CType(Resultado, Boolean) = False Then
                    Cancelar = True

                    If Trans IsNot Nothing Then
                        Trans.Rollback()
                    End If
                End If
            End Using
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim IdCliente As Integer = Integer.Parse(dgvClientes.SelectedRows(0).Cells(clmIdCliente.Index).Value.ToString)
            Dim IdProducto As Integer = Integer.Parse(dgvProductos.SelectedRows(0).Cells(clmIdProducto.Index).Value.ToString)
            Dim Categoria As Char = dgvProductos.SelectedRows(0).Cells(clmCategoria.Index).Value.ToString()(0)
            Dim Celda As DataGridViewCheckBoxCell = CType(dgvClientes.SelectedRows(0).Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)

            ActualizarDestinosyPreciosActuales(dgvClientes.CurrentRow)
            dgvDestinos.DataSource = CType(dgvClientes.CurrentRow.Tag, DataSet).Tables(0)
            ActualizarPreciosDestinos()
            EscrituraDestinosPrecios(CType(Celda.EditedFormattedValue, Boolean))
        End If
    End Sub

    Private Sub txtTodoa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTodoa.KeyPress
        Utilerias.ValidarEntradaNumerosDecimales(sender, e)
    End Sub

    Private Sub dgvProductos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvProductos.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        CType(e.Control, TextBox).MaxLength = 9
        AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
    End Sub

    Private Sub dgvDestinos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDestinos.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        CType(e.Control, TextBox).MaxLength = 9
        AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
    End Sub

    Private Sub dgvProductos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellEndEdit
        If e.ColumnIndex = clmPrecioNuevo.Index Then
            VerificarMovimientoProductos(dgvProductos.Rows(e.RowIndex))
        End If
    End Sub

    Private Sub dgvDestinos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDestinos.CellEndEdit
        If e.ColumnIndex = clmPrecio.Index Then
            Dim IdPuntoEntrega As Integer = Integer.Parse(dgvDestinos.Rows(e.RowIndex).Cells(clmIdPuntoEntrega.Index).Value.ToString)
            Dim Precio As Decimal = Decimal.Parse(dgvDestinos.Rows(e.RowIndex).Cells(clmPrecio.Index).Value.ToString)
            VerificarMovimientoProductoDestino(dgvClientes.SelectedRows(0), IdPuntoEntrega, dgvProductos.SelectedRows(0), Precio)
        End If
    End Sub

    Private Sub dgvClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If e.ColumnIndex = clmSeleccion.Index Then
            Dim Producto As DataGridViewRow = Nothing, Precio As Object
            Dim Celda As DataGridViewCheckBoxCell = CType(dgvClientes.Rows(e.RowIndex).Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)
            Dim IdCliente As Integer = Integer.Parse(dgvClientes.Rows(e.RowIndex).Cells(clmIdCliente.Index).Value.ToString)

            If sender.GetType() Is GetType(DataGridViewRow) Then
                Producto = CType(sender, DataGridViewRow)
            Else
                Producto = dgvProductos.SelectedRows(0)
            End If
            Precio = Producto.Cells(clmPrecioNuevo.Index).Value

            If CType(Celda.EditedFormattedValue, Boolean) Then
                If Producto.Tag IsNot Nothing Then
                    If Not CType(Producto.Tag, Collection).Contains(IdCliente.ToString) Then
                        CType(Producto.Tag, Collection).Add(dgvClientes.Rows(e.RowIndex), IdCliente.ToString)
                    End If
                End If

                If IsNumeric(Precio) AndAlso Decimal.Parse(Precio.ToString) > 0 Then
                    AgregarProducto(dgvClientes.Rows(e.RowIndex), Producto)
                End If
            Else
                If Producto.Tag IsNot Nothing Then
                    If CType(Producto.Tag, Collection).Contains(IdCliente.ToString()) Then
                        CType(Producto.Tag, Collection).Remove(IdCliente.ToString())
                    End If
                End If
                QuitarProducto(IdCliente, Producto)
            End If

            If dgvProductos.CurrentRow.Index = Producto.Index Then
                If sender.GetType() IsNot GetType(CheckBox) Then
                    RemoveHandler chkTodos.CheckedChanged, AddressOf chkTodos_CheckedChanged

                    If CType(Producto.Tag, Collection).Count = dgvClientes.Rows.Count Then
                        chkTodos.Checked = True
                    Else
                        chkTodos.Checked = False
                    End If
                    AddHandler chkTodos.CheckedChanged, AddressOf chkTodos_CheckedChanged
                End If

                For Each Destino As DataGridViewRow In dgvDestinos.Rows
                    Destino.Cells(clmPrecio.Index).Value = Precio
                Next
                EscrituraDestinosPrecios(Boolean.Parse(Celda.EditedFormattedValue.ToString()))
            End If
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Cursor = Cursors.WaitCursor
        Dim chkTD As CheckBox = CType(sender, CheckBox)

        For Each Cliente As DataGridViewRow In dgvClientes.Rows
            If CType(Cliente.Cells(clmSeleccion.Index).Value, Boolean) <> chkTD.Checked Then
                Dim Celda As DataGridViewCheckBoxCell = CType(Cliente.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)
                Celda.EditingCellFormattedValue = chkTD.Checked
                Celda.Value = chkTD.Checked
                dgvClientes_CellContentClick(sender, New DataGridViewCellEventArgs(clmSeleccion.Index, Cliente.Index))
            End If
        Next
        Cursor = Cursors.Arrow
    End Sub

    Private Sub txtTodoa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTodoa.TextChanged, nudAumentoPrecio.ValueChanged
        If sender.GetType() Is GetType(TextBox) Then
            If IsNumeric(CType(sender, TextBox).Text) AndAlso Val(CType(sender, TextBox).Text) > 0 Then
                nudAumentoPrecio.Value = 0
            End If
        Else
            If nudAumentoPrecio.Value > 0 Then
                txtTodoa.Text = ""
            End If
        End If

        For Each Renglon As DataGridViewRow In dgvProductos.Rows
            Dim PrecioPrevisto As Decimal = 0D

            If txtTodoa.Text.Trim <> String.Empty Then
                PrecioPrevisto = Decimal.Parse(txtTodoa.Text.Trim)
                Renglon.Cells(clmPrecioPrevisto.Index).Value = PrecioPrevisto.ToString("N4")
            Else
                PrecioPrevisto = Decimal.Parse(Renglon.Cells(clmPrecioAnterior.Index).Value.ToString)
            End If

            If nudAumentoPrecio.Value <> 0 Then
                Renglon.Cells(clmPrecioPrevisto.Index).Value = (PrecioPrevisto * (1 + nudAumentoPrecio.Value / 100)).ToString("N4")
            ElseIf txtTodoa.Text.Trim = String.Empty Then
                Renglon.Cells(clmPrecioPrevisto.Index).Value = 0.0
            End If
        Next
    End Sub

    Private Sub dgvProductos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.SelectionChanged
        If dgvProductos.SelectedRows.Count > 0 AndAlso dgvClientes.SelectedRows.Count > 0 Then
            ActualizarPreciosDestinos()
            RefrescarClientesSeleccionados()
        End If
    End Sub

    Private Sub btnAplicaPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicaPrecios.Click
        Dim RenglonSeleccionado As Integer = dgvProductos.CurrentRow.Index
        Cursor = Cursors.WaitCursor

        For Each Producto As DataGridViewRow In dgvProductos.Rows
            If IsNumeric(Producto.Cells(clmPrecioNuevo.Index).Value) AndAlso Val(Producto.Cells(clmPrecioNuevo.Index).Value) > 0 Then
                For Each Cliente As DataGridViewRow In dgvClientes.Rows
                    Dim Celda As DataGridViewCheckBoxCell = CType(Cliente.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)
                    Celda.EditingCellFormattedValue = True
                    Celda.Value = True
                    dgvClientes_CellContentClick(Producto, New DataGridViewCellEventArgs(clmSeleccion.Index, Cliente.Index))
                Next
            End If
        Next

        If Not IsNumeric(dgvProductos.Rows(RenglonSeleccionado).Cells(clmPrecioNuevo.Index).Value) OrElse Not Val(dgvProductos.Rows(RenglonSeleccionado).Cells(clmPrecioNuevo.Index).Value.ToString) > 0 Then
            For Each Cliente As DataGridViewRow In dgvClientes.Rows
                Dim Celda As DataGridViewCheckBoxCell = CType(Cliente.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)
                Celda.EditingCellFormattedValue = False
                Celda.Value = False
            Next
        End If
        Cursor = Cursors.Arrow
    End Sub
#End Region
End Class
