Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports ClasesNegocio
Imports System.Threading
Imports System.Data.SqlClient

Public Class FrmCapturaInvFisico
    Dim InvenFisico As CN.InventarioFisicoClass
    Dim bucket As New RelationCollection
    Dim Filtro As New OC.PredicateExpression
    Dim producto As CN.ProductoGeneralClass
    Dim dts As DataTable
    Dim Buscar As Boolean = False
    Dim fi As Date
    Dim checkedchk As Boolean = False
    Dim list As ArrayList
    Dim loadfin As Boolean
    Dim count As Integer
    Dim cambios As Boolean = False
    Dim contcap As Integer = 0
    Dim contporCap As Integer = 0

    Private Sub FrmCapturaInvFisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadfin = False
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "001101101"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados

            mtb.sbCambiarEstadoBotones("Cancelar")
            Me.Panel1.Enabled = False
            count = 0
            Dim AlmacenesCol As New CN.AlmacenCollectionClass
            AlmacenesCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            CmbAlmacenes.DataSource = AlmacenesCol

            CmbAlmacenes.DisplayMember = "Descripcion"
            CmbAlmacenes.ValueMember = "Codigo"

            Habilitar(False)

            'Limpiar()
#If DEBUG Then
            DgvProductos.Columns(clmAlmacenId.Index).Visible = True
            DgvProductos.Columns(clmProductoId.Index).Visible = True
            DgvProductos.Columns(clmGuardado.Index).Visible = True
#End If
            Dim x As Integer = 10, y As Integer = 10, i As Integer = 1
            Dim lineas As New ClasesNegocio.LineaCollectionClass
            lineas.Obtener(CondicionEnum.ACTIVOS)

            For Each row As CN.LineaClass In lineas
                Dim check As New CheckBox
                Me.Panel1.Controls.Add(check)
                check.Location = New Drawing.Point(x, y)
                check.AutoSize = True
                check.Text = row.DescripcionCorta
                check.Name = "chk" & row.DescripcionCorta
                check.Tag = row.Codigo.ToString
                AddHandler check.CheckedChanged, AddressOf checkboxCheckedChanged
                x += 170
                If i Mod 3 = 0 Then
                    y += 23
                    x = 10
                End If
                i += 1
            Next

            CmbAlmacenes.Text = "Seleccione un almacen..."
            CmbAlmacenes.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.DgvProductos.Columns(clmIdLinea.Index).DataPropertyName = "LNIdLinea"
        Me.DgvProductos.Columns(clmCodBarra.Index).DataPropertyName = "CodigoBarra"
        Me.DgvProductos.Columns(clmAlmacenId.Index).DataPropertyName = "AlmacenId"

        Me.DgvProductos.Columns(clmCantidad.Index).DefaultCellStyle.Format = "##,##0.000"

        Me.btnAjuste.Enabled = False
        fi = DtpFecha.Value.ToString("dd/MM/yyyy")
        loadfin = True
    End Sub

#Region "Metodos"

    Private Sub Limpiar()

        DgvProductos.DataSource = Nothing
        DgvProductos.Rows.Clear()
        CmbAlmacenes.SelectedIndex = -1
        Buscar = False
        DtpFecha.Value = Now
        btnAjuste.Enabled = False
        ''limpiar los checks
        For Each ctrl As Control In Panel1.Controls
            Dim check As CheckBox = CType(ctrl, CheckBox)
            If check.Checked Then
                check.Checked = False
            End If
        Next
        rbNombre.Checked = True
        cambios = False
        contporCap = 0
        contcap = 0
        lblCapturados.Text = "0"
        lblPorCapturar.Text = "0"
        lblTotal.Text = "0"

    End Sub

    Private Sub Habilitar(ByVal Estado As Boolean)
        Me.DgvProductos.Enabled = Estado
        Me.CmbAlmacenes.Enabled = Estado
        'Me.Panel1.Enabled = Estado
        Me.txtProducto.Enabled = Estado
        If Not Buscar Then
            DtpFecha.Enabled = Estado
        End If
        rbNombre.Enabled = Estado
        rbId.Enabled = Estado
        rbCodBarra.Enabled = Estado
    End Sub

#End Region

    Private Sub CmbAlmacenes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.SelectedIndexChanged
        If loadfin Then



            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                If Me.CmbAlmacenes.SelectedIndex <> -1 And loadfin Then
                    If Buscar = False Then
                        Dim Coleccion As New CN.InventarioFisicoCollectionClass
                        Coleccion.Obtener(CmbAlmacenes.SelectedValue)
                        If Coleccion.Count > 0 Then
                            MessageBox.Show("Ya cuenta con un inventario pendiente por capturar." & vbLf & "Con la fecha: " & Coleccion(Coleccion.Count - 1).FechaInventario.ToString("dd/MM/yyyy"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CmbAlmacenes.Text = "Seleccione un almacen..."
                            CmbAlmacenes.SelectedIndex = -1
                            Exit Sub
                        End If

                        Me.Panel1.Enabled = True
                        'Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = CmbAlmacenes.SelectedValue)


                        'Me.DgvProductos.AutoGenerateColumns = False

                        'Dim inventario As New CC.InventarioAlmacenCollection()
                        'inventario.GetMulti(Filtro)
                        'For Each row As EC.InventarioAlmacenEntity In inventario
                        '    DgvProductos.Rows.Add(row.Producto.Descripcion, row.Producto.UnidadMedida.Descripcion, Nothing)
                        'Next
                        Filtro = New PredicateExpression
                        Filtro.Add(HC.VwProductosEnAlmacenFields.AlmacenId = Me.CmbAlmacenes.SelectedValue Or HC.VwProductosEnAlmacenFields.AlmacenId = 0)
                        Dim Vista As New TC.VwProductosEnAlmacenTypedView
                        Vista.Fill(0, New SortExpression(New SortClause(HC.VwProductosEnAlmacenFields.PdDescripcion, SortOperator.Ascending)), False, Filtro)

                        Me.DgvProductos.AutoGenerateColumns = False

                        Me.DgvProductos.DataSource = Vista
                        dts = New DataTable
                        dts = Vista
                        Me.DgvProductos.Columns(clmIdLinea.Index).DataPropertyName = "LNIdLinea"
                        Me.DgvProductos.Columns(clmCodBarra.Index).DataPropertyName = "CodigoBarra"
                        Me.DgvProductos.Columns(clmAlmacenId.Index).DataPropertyName = "AlmacenId"
                        txtProducto.Focus()
                        Application.DoEvents()
                        lblTotal.Text = CStr(DgvProductos.RowCount)
                    End If
                Else
                    Me.Panel1.Enabled = False
                End If




#If DEBUG Then
                ''MessageBox.Show(DgvProductos.RowCount.ToString)
#End If
                DgvProductos.Refresh()
                Application.DoEvents()
                ''Guarda todos los articulos en como inventario
                Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Inventario_Fisico")

                For i As Integer = 0 To Me.DgvProductos.Rows.Count - 1
                    InvenFisico = New CN.InventarioFisicoClass(Me.CmbAlmacenes.SelectedValue, DgvProductos.Rows(i).Cells(Me.clmProductoId.Index).Value)
                    Dim Entidad As New EC.InventarioFisicoEntity()
                    Entidad = InvenFisico.ObtenerEntidad


                    ''If DgvProductos.Rows(i).Cells(clmGuardado.Index).Value = "N" Then

                    If Not Entidad.IsNew Then

                        ' InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        'IIf(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Or Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value = "", InvenFisico.Cantidad = 0, InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                        If Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value IsNot Nothing Then
                            '    InvenFisico.Cantidadnull = vbNull
                            'Else
                            InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        Else
                            InvenFisico.Cantidadnull = Nothing
                        End If
                        'InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        'InvenFisico.FechaInventario = Now
                        If Not InvenFisico.Guardar(Trans) Then
                            Trans.Rollback()
                            ''Cancelar = True
                            Exit Sub
                        End If
                    Else

                        InvenFisico = New CN.InventarioFisicoClass
                        InvenFisico.AlmacenId = Me.CmbAlmacenes.SelectedValue
                        InvenFisico.ProductoID = Me.DgvProductos.Rows(i).Cells(Me.clmProductoId.Index).Value
                        If Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value IsNot Nothing Then
                            '    InvenFisico.Cantidadnull = vbNull
                            'Else
                            InvenFisico.Cantidad = CDbl(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                        End If
                        'If Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Then
                        '    InvenFisico.Cantidad = 0
                        'Else
                        '    InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        'End If

                        'IIf(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Or Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value = "", InvenFisico.Cantidad = 0, InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                        InvenFisico.FechaInventario = DtpFecha.Value

                        If Not InvenFisico.Guardar(Trans) Then
                            Trans.Rollback()
                            ''Cancelar = True
                            Exit Sub
                        End If
                        'InvenFisico = New CN.InventarioFisicoClass
                    End If
                    '' End If
                Next
                Trans.Commit()
                Windows.Forms.Cursor.Current = Cursors.Default

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New FrmBusqInvFisico
            Ventana.StartPosition = FormStartPosition.CenterParent
            mtb.sbCambiarEstadoBotones("Buscar")
            contporCap = 0
            contcap = 0
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Application.DoEvents()
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                
                Buscar = True
                rbNombre.Checked = True
                Dim Coleccion As New CN.InventarioFisicoCollectionClass
                Coleccion.Obtener(Ventana.CmbAlmacenes.SelectedValue)
                Me.CmbAlmacenes.SelectedValue = Ventana.CmbAlmacenes.SelectedValue
                'Dim fil As New PredicateExpression
                'fil.Add(HC.VwProductosEnAlmacenFields.AlmacenId = Me.CmbAlmacenes.SelectedValue)
                'Dim Vista As New TC.VwProductosEnAlmacenTypedView
                'Vista.Fill(0, Nothing, False, fil)

                'Me.DgvProductos.AutoGenerateColumns = False
                'Me.DgvProductos.DataSource = Vista
                'Me.DgvProductos.Columns(clmIdLinea.Index).DataPropertyName = "LNIdLinea"
                'Me.DgvProductos.Columns(clmCodBarra.Index).DataPropertyName = "CodigoBarra"
                'Me.DgvProductos.Columns(clmAlmacenId.Index).DataPropertyName = "AlmacenId"
                DgvProductos.Enabled = True
                
                If Coleccion.Count > 0 Then

                    CmbAlmacenes.Enabled = False
                    Application.DoEvents()
                    Me.DtpFecha.Value = Coleccion(Coleccion.Count - 1).FechaInventario
                    For Each row As CN.InventarioFisicoClass In Coleccion

                        If row.Cantidadnull IsNot Nothing Then
                            DgvProductos.Rows.Add(row.AlmacenId, row.ProductoID, row.Producto.CodigoBarra, row.Producto.Descripcion, row.Producto.UnidadMedida.Descripcion, row.Cantidad, row.Producto.IdLinea)
                            contcap += 1
                        Else
                            DgvProductos.Rows.Add(row.AlmacenId, row.ProductoID, row.Producto.CodigoBarra, row.Producto.Descripcion, row.Producto.UnidadMedida.Descripcion, Nothing, row.Producto.IdLinea)
                            contporCap += 1
                        End If






                    Next

                    
                    ''Se checa si hubo algun articulo nuevo para agregarlo
                    Dim consulta As String = "select A.AlmacenId,A.ProductoID,A.PdDescripcion,A.UMDescripcion,A.LNIdLinea,A.CodigoBarra FROM VwProductosEnAlmacen  A " +
                                             "FULL OUTER JOIN  UsrAlmInvFisico B ON  A.productoId = B.ProductoID and B.AlmacenId = " + CmbAlmacenes.SelectedValue.ToString + " " +
                                             "Where B.ProductoId  is null"

                    Dim resultado As New DataSet()
                    Dim cmd As SqlCommand = New SqlCommand(consulta, New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))
                    cmd.CommandType = CommandType.Text

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.SelectCommand.CommandTimeout = 300
                    adapter.Fill(resultado)
                    cmd.Dispose()


                    If resultado.Tables(0).Rows.Count > 0 Then
                        For Each row As DataRow In resultado.Tables(0).Rows
                            DgvProductos.Rows.Add(CmbAlmacenes.SelectedValue, row(1), row(5).ToString, row(2).ToString, row(3).ToString, Nothing, row(4))
                            contporCap += 1
                        Next
                    End If

                    lblCapturados.Text = contcap.ToString
                    lblPorCapturar.Text = contporCap.ToString
                    lblTotal.Text = CStr(DgvProductos.RowCount)


                    Application.DoEvents()
                    DgvProductos.Sort(DgvProductos.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
                    Application.DoEvents()


                    DgvProductos.Refresh()
                    DgvProductos.Enabled = False
                    btnAjuste.Enabled = True
#If DEBUG Then
                    MessageBox.Show(DgvProductos.RowCount.ToString)
#End If
                    'Me.DtpFecha.Value = Coleccion(Coleccion.Count - 1).FechaInventario
                    'Me.DgvProductos.AutoGenerateColumns = False
                    'Me.DgvProductos.DataSource = Coleccion
                    'Me.DgvProductos.Columns(clmIdLinea.Index).DataPropertyName = "LNIdLinea"
                    'Me.DgvProductos.Columns(clmCodBarra.Index).DataPropertyName = "CodigoBarra"
                    'Me.DgvProductos.Columns(clmAlmacenId.Index).DataPropertyName = "AlmacenId"
                Else
                    MessageBox.Show("Sin inventario para el almacen: " & CmbAlmacenes.Text & ".", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cancelar = True
                    mtb.sbCambiarEstadoBotones("Cancelar")
                    Limpiar()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cambiarcolorgrid(Drawing.Color.LightGray, Drawing.Color.Gray)
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Public Sub cambiarcolorgrid(ByVal color As Drawing.Color, ByVal colorletra As Drawing.Color)
        For Each row As DataGridViewRow In DgvProductos.Rows
            row.DefaultCellStyle.BackColor = color
            row.DefaultCellStyle.ForeColor = colorletra
            If row.Index = 0 Then
                row.Cells(clmCantidad.Index).Selected = True
            End If
            row.Cells(clmProductoId.Index).Selected = False
            row.Cells(clmCantidad.Index).Selected = False
        Next
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Habilitar(False)
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            Habilitar(True)
            CmbAlmacenes.Enabled = False
            Me.clmCantidad.ReadOnly = False
            Me.Panel1.Enabled = True
            cambiarcolorgrid(Drawing.Color.White, Drawing.Color.Black)
            DgvProductos.Focus()
            btnAjuste.Enabled = False
            If DgvProductos.Rows.Count > 0 Then
                DgvProductos.CurrentCell = DgvProductos.Item("clmCantidad", 0)
            End If
            txtProducto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickEliminar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            'Habilitar(True)
            'Me.clmCantidad.ReadOnly = False
            'Me.Panel1.Enabled = True
            'cambiarcolorgrid(Drawing.Color.White, Drawing.Color.Black)
            'DgvProductos.Focus()
            'btnAjuste.Enabled = False
            'If DgvProductos.Rows.Count > 0 Then
            '    DgvProductos.CurrentCell = DgvProductos.Item("clmCantidad", 0)
            'End If
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Eliminar_Inv_Fisico")
            If MessageBox.Show("¿Estas seguro de borrar el inventario?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Dim Coleccion As New CN.InventarioFisicoCollectionClass
                Coleccion.Obtener(CmbAlmacenes.SelectedValue)

                For Each row As CN.InventarioFisicoClass In Coleccion
                    If Not row.Borrar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        MessageBox.Show("Error al eliminar el inventario fisico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                Trans.Commit()
                MessageBox.Show("Se elimino inventario fisico correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Habilitar(False)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Inventario_Fisico")
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If Me.CmbAlmacenes.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Trans.Rollback()
                Exit Sub
            End If
            If Me.DgvProductos.Rows.Count = 0 Then
                MessageBox.Show("No hay productos registrados en el almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Trans.Rollback()
                Exit Sub
            End If

            If Not Buscar Then
                If fi = DtpFecha.Value.ToString("dd/MM/yyyy") Then
                    If MessageBox.Show("Esta seguro que la fecha del inventario es: " & fi, Application.ProductName, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Cancelar = True
                        Trans.Rollback()
                        Exit Sub
                    End If
                End If
            End If

            

            Me.CmbAlmacenes.Focus()
            For i As Integer = 0 To Me.DgvProductos.Rows.Count - 1
                InvenFisico = New CN.InventarioFisicoClass(Me.CmbAlmacenes.SelectedValue, DgvProductos.Rows(i).Cells(Me.clmProductoId.Index).Value)
                Dim Entidad As New EC.InventarioFisicoEntity()
                Entidad = InvenFisico.ObtenerEntidad

                If DgvProductos.Rows(i).Cells(clmGuardado.Index).Value = "N" Then

                    If Not Entidad.IsNew Then

                        ' InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        'IIf(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Or Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value = "", InvenFisico.Cantidad = 0, InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                        If Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value IsNot Nothing Then
                            '    InvenFisico.Cantidadnull = vbNull
                            'Else
                            InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        Else
                            InvenFisico.Cantidadnull = Nothing
                        End If
                        'InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        'InvenFisico.FechaInventario = Now
                        If Not InvenFisico.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                            Exit Sub
                        End If
                    Else

                        InvenFisico = New CN.InventarioFisicoClass
                        InvenFisico.AlmacenId = Me.CmbAlmacenes.SelectedValue
                        InvenFisico.ProductoID = Me.DgvProductos.Rows(i).Cells(Me.clmProductoId.Index).Value
                        If Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value IsNot Nothing Then
                            '    InvenFisico.Cantidadnull = vbNull
                            'Else
                            InvenFisico.Cantidad = CDbl(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                        End If
                        'If Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Then
                        '    InvenFisico.Cantidad = 0
                        'Else
                        '    InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                        'End If

                        'IIf(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Or Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value = "", InvenFisico.Cantidad = 0, InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                        InvenFisico.FechaInventario = DtpFecha.Value

                        If Not InvenFisico.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                            Exit Sub
                        End If
                        'InvenFisico = New CN.InventarioFisicoClass
                    End If
                End If
            Next
            Trans.Commit()
            MessageBox.Show("Los Datos han sido guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            Habilitar(False)
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar(True)
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
        ''Dispose()
    End Sub

    Private Sub DgvProductos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProductos.CellEndEdit
        Try
            Select Case e.ColumnIndex
                Case Me.clmCantidad.Index
                    'If Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value <> "" And Not Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value Is Nothing Then
                    'If Not IsNumeric(Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value) Then
                    'MessageBox.Show("Ingrese solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Nothing
                    ''Me.DgvProductos.CurrentRow.Cells(clmCantidad.Index).b
                    ' Else
                    InvenFisico = New CN.InventarioFisicoClass(Me.CmbAlmacenes.SelectedValue, DgvProductos.Rows(e.RowIndex).Cells(Me.clmProductoId.Index).Value)
                    If DgvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value IsNot Nothing Then
                        ''GUARDA AUTOMATICAMENTE EL ARTICULO EN EL INVENTARIO
                        producto = New CN.ProductoGeneralClass(CInt(Me.DgvProductos.CurrentRow.Cells(clmProductoId.Index).Value))
                        Dim Entidad As New EC.InventarioFisicoEntity()
                        Entidad = InvenFisico.ObtenerEntidad
                        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Inventario_Fisico")

                        If Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = "" Then
                            Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Nothing
                        Else
                            Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Convert.ToDouble(Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value).ToString("##,##0.000")
                        End If






                        If Not Entidad.IsNew Then

                            ' InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                            'IIf(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Or Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value = "", InvenFisico.Cantidad = 0, InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                            If Me.DgvProductos.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value IsNot Nothing Then
                                '    InvenFisico.Cantidadnull = vbNull
                                'Else
                                InvenFisico.Cantidad = Me.DgvProductos.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value
                                InvenFisico.CantidadSistema = CDec(producto.CantidadExistencia)
                            Else
                                InvenFisico.Cantidadnull = Nothing
                                InvenFisico.CantidadSistema = Nothing
                            End If
                            'InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                            'InvenFisico.FechaInventario = Now
                            If Not InvenFisico.Guardar(Trans) Then
                                Trans.Rollback()
                                'Cancelar = True
                                Exit Sub
                            End If
                        Else

                            InvenFisico = New CN.InventarioFisicoClass
                            InvenFisico.AlmacenId = Me.CmbAlmacenes.SelectedValue
                            InvenFisico.ProductoID = Me.DgvProductos.Rows(e.RowIndex).Cells(Me.clmProductoId.Index).Value
                            If Me.DgvProductos.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value IsNot Nothing Then
                                '    InvenFisico.Cantidadnull = vbNull
                                'Else
                                InvenFisico.Cantidad = CDbl(Me.DgvProductos.Rows(e.RowIndex).Cells(Me.clmCantidad.Index).Value)
                                InvenFisico.CantidadSistema = CDec(producto.CantidadExistencia)
                            End If
                            'If Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Then
                            '    InvenFisico.Cantidad = 0
                            'Else
                            '    InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                            'End If

                            'IIf(Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value Is Nothing Or Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value = "", InvenFisico.Cantidad = 0, InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value)
                            InvenFisico.FechaInventario = DtpFecha.Value

                            If Not InvenFisico.Guardar(Trans) Then
                                Trans.Rollback()
                                '' Cancelar = True
                                Exit Sub
                            End If
                            'InvenFisico = New CN.InventarioFisicoClass
                        End If
                        Trans.Commit()
                        cambios = True
                        Me.DgvProductos.CurrentRow.Cells(clmGuardado.Index).Value = "S"

                        ''txtProducto.Text = ""
                        txtProducto.Focus()
                        'End If
                        'End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvProductos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvProductos.DataError

    End Sub

    Private Sub checkboxCheckedChanged(sender As Object, e As EventArgs)


        list = New ArrayList
        For Each ctrl As Control In Panel1.Controls
            Dim check As CheckBox = CType(ctrl, CheckBox)
            If check.Checked Then
                list.Add(CInt(check.Tag.ToString))
            End If
        Next

        If list.Count <> 0 Then
            Me.txtProducto.Text = ""
            For i As Integer = 0 To DgvProductos.Rows.Count - 1
                'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
                'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
                'If Not DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Contains(txtProducto.Text.Trim) Then
                DgvProductos.CurrentCell = Nothing
                DgvProductos.Rows(i).Visible = True
                'list.Add(i)
                'End If
            Next
            count = 0

            For i As Integer = 0 To DgvProductos.Rows.Count - 1
                'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
                'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
                'If Not DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Contains(txtProducto.Text.Trim) Then
                DgvProductos.CurrentCell = Nothing
                DgvProductos.Rows(i).Visible = False
                'list.Add(i)
                'End If
            Next


            Try
                For j As Integer = 0 To list.Count - 1
                    For i As Integer = 0 To DgvProductos.Rows.Count - 1
                        'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
                        'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value

                        If CInt(DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value) = list(j) Then
                            DgvProductos.CurrentCell = Nothing
                            DgvProductos.Rows(i).Visible = True
                            count += 1
                            'Else
                            '    DgvProductos.CurrentCell = Nothing
                            '    DgvProductos.Rows(i).Visible = True
                            'list.Add(i)
                        End If
                    Next
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'list.Clear()
        Else
            For i As Integer = 0 To DgvProductos.Rows.Count - 1
                'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
                'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
                'If Not DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Contains(txtProducto.Text.Trim) Then
                DgvProductos.CurrentCell = Nothing
                DgvProductos.Rows(i).Visible = True
                'list.Add(i)
                'End If
            Next

        End If
        'DgvProductos.FirstDisplayedScrollingRowIndex = 1
        DgvProductos.Focus()
        Dim b As Boolean = False
        For Each row As DataGridViewRow In DgvProductos.Rows
            row.Cells(clmProductoId.Index).Selected = False
            If row.Visible And b = False Then
                'If row.Index = 0 Then
                b = True
                row.Cells(clmCantidad.Index).Selected = True
                DgvProductos.CurrentCell = DgvProductos.Item("clmCantidad", row.Index)
                ' End If
                'row.Cells(clmProductoId.Index).Selected = False
                'row.Cells(clmCantidad.Index).Selected = False
            End If
        Next

        'For i As Integer = 0 To DgvProductos.Rows.Count - 1
        '    Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
        '    Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
        'Next
        'dts = New DataTable
        'Dim confiltro As Boolean = False
        'Filtro = New PredicateExpression
        'DgvProductos.DataSource = Nothing
        'For Each ctrl As Control In Panel1.Controls
        '    Dim check As CheckBox = CType(ctrl, CheckBox)

        '    If check.Checked Then
        '        Try
        '            For i As Integer = 0 To DgvProductos.Rows.Count - 1
        '                'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
        '                'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
        '                If Not CInt(DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value) = CInt(check.Tag.ToString) Then
        '                    DgvProductos.CurrentCell = Nothing
        '                    DgvProductos.Rows(i).Visible = False
        '                Else
        '                    DgvProductos.CurrentCell = Nothing
        '                    DgvProductos.Rows(i).Visible = True
        '                    'list.Add(i)
        '                End If
        '            Next
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End Try
        '        'confiltro = True
        '        'Filtro.AddWithOr(HC.VwProductosEnAlmacenFields.LnidLinea = CInt(check.Tag.ToString) And HC.VwProductosEnAlmacenFields.AlmacenId = CmbAlmacenes.SelectedValue)
        '        'Filtro.Add()
        '        'filLin = True
        '        'For i As Integer = 0 To dts.Rows.Count - 1
        '        '    'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
        '        '    'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
        '        'Next
        '        'Else
        '        '    For i As Integer = 0 To DgvProductos.Rows.Count - 1
        '        '        'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
        '        '        'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
        '        '        'If Not DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Contains(txtProducto.Text.Trim) Then
        '        '        DgvProductos.CurrentCell = Nothing
        '        '        DgvProductos.Rows(i).Visible = True
        '        '        'list.Add(i)
        '        '        'End If
        '        '    Next
        '    End If
        'Next

        'If confiltro = False Then
        '    Filtro.Add(HC.VwProductosEnAlmacenFields.AlmacenId = CmbAlmacenes.SelectedValue)
        'End If


        'Dim Vista As New TC.VwProductosEnAlmacenTypedView
        'Vista.Fill(0, Nothing, False, Filtro)
        'Me.DgvProductos.AutoGenerateColumns = False
        'Me.DgvProductos.DataSource = Vista
        'dts = Vista
        txtProducto.Text = ""
        txtProducto.Focus()
    End Sub

    Public Sub checarchecks()

    End Sub

    Private Sub txtProducto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProducto.TextChanged
        'Dim list As New ArrayList
        If txtProducto.Text.Length <> 0 Then
            Try
                For i As Integer = 0 To DgvProductos.Rows.Count - 1
                    'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
                    'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
                    If DgvProductos.Rows(i).Visible Then
                        If rbNombre.Checked Then
                            If Not DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Contains(txtProducto.Text.ToUpper.Trim) Then
                                'DgvProductos.CurrentCell = Nothing
                                'DgvProductos.Rows(i).Visible = False
                                DgvProductos.Rows(i).Selected = False
                                DgvProductos.CurrentCell = Nothing
                                count -= 1
                            Else
                                'If DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Equals(txtProducto.Text.ToUpper.Trim) Then
                                '    DgvProductos.Rows(i).Selected = True
                                '    DgvProductos.CurrentCell = DgvProductos.Item(4, i)
                                '    DgvProductos.FirstDisplayedCell = DgvProductos.CurrentCell
                                '    DgvProductos.CurrentCell.Selected = True
                                'End If

                                DgvProductos.Rows(i).Selected = True
                                DgvProductos.CurrentCell = DgvProductos.Item(4, i)
                                DgvProductos.FirstDisplayedCell = DgvProductos.CurrentCell
                                DgvProductos.CurrentCell.Selected = True
                                Exit For
                                ''count += 1
                                'list.Add(i)
                            End If
                        ElseIf rbId.Checked Then
                            If Not DgvProductos.Rows(i).Cells(clmProductoId.Index).Value.ToString.Contains(txtProducto.Text.ToUpper.Trim) Then
                                DgvProductos.CurrentCell = Nothing
                                DgvProductos.Rows(i).Visible = False
                                count -= 1
                            Else
                                DgvProductos.CurrentCell = Nothing
                                DgvProductos.Rows(i).Visible = True
                                ''count += 1
                                'list.Add(i)
                            End If
                        Else
                            If Not DgvProductos.Rows(i).Cells(clmCodBarra.Index).Value.ToString.Contains(txtProducto.Text.ToUpper.Trim) Then
                                'DgvProductos.CurrentCell = Nothing
                                'DgvProductos.Rows(i).Visible = False
                                DgvProductos.Rows(i).Selected = False
                                DgvProductos.CurrentCell = Nothing
                                count -= 1
                            Else
                                If DgvProductos.Rows(i).Cells(clmCodBarra.Index).Value.ToString.Equals(txtProducto.Text.ToUpper.Trim) Then
                                    DgvProductos.Rows(i).Selected = True
                                    DgvProductos.CurrentCell = DgvProductos.Item(4, i)
                                    DgvProductos.FirstDisplayedCell = DgvProductos.CurrentCell
                                    DgvProductos.CurrentCell.Selected = True
                                    Exit For
                                End If
                                ''DgvProductos.CurrentCell = Nothing
                                'DgvProductos.Rows(i).Visible = True
                                ''count += 1
                                'list.Add(i)
                            End If
                        End If
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'For j As Integer = 0 To list.Count - 1
            '    DgvProductos.CurrentCell = Nothing
            '    DgvProductos.Rows(list(j)).Visible = False
            'Next
            'Else
            '    DgvProductos.DataSource = Nothing
            '    DgvProductos.DataSource = dts
        Else
            If list.Count > 0 Then
                checkboxCheckedChanged(Nothing, Nothing)
            Else
                For i As Integer = 0 To DgvProductos.Rows.Count - 1
                    'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
                    'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
                    'If Not DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Contains(txtProducto.Text.Trim) Then
                    DgvProductos.CurrentCell = Nothing
                    DgvProductos.Rows(i).Visible = True
                    'list.Add(i)
                    'End If
                Next
            End If
            txtProducto.Focus()
        End If
    End Sub

    Private Sub btnAjuste_Click(sender As System.Object, e As System.EventArgs) Handles btnAjuste.Click
        Dim forma As New ClasesComunes.FrmInvRevisionAjuste
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Ajuste_Inv_Fisico")
        forma.valorAlmacen = CmbAlmacenes.SelectedValue
        forma.StartPosition = FormStartPosition.CenterParent

        If forma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Coleccion As New CN.InventarioFisicoCollectionClass
            Coleccion.Obtener(CmbAlmacenes.SelectedValue)

            For Each row As CN.InventarioFisicoClass In Coleccion
                If Not row.Borrar(Trans) Then
                    Trans.Rollback()
                    'Cancelar = True
                    MessageBox.Show("Error al eliminar el inventario fisico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            Trans.Commit()
            'MessageBox.Show("Se elimino inventario fisico correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            Habilitar(False)
            mtb.sbCambiarEstadoBotones("Cancelar")
        End If


    End Sub

    Private Sub rbNombre_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNombre.CheckedChanged
        If rbNombre.Checked Then
            rengridvisibles()
        End If


    End Sub

    Private Sub rbId_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbId.CheckedChanged
        If rbId.Checked Then
            rengridvisibles()
        End If
    End Sub

    Private Sub rbCodBarra_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbCodBarra.CheckedChanged
        If rbCodBarra.Checked Then
            rengridvisibles()
        End If
    End Sub

    Public Sub rengridvisibles()
        txtProducto.Text = ""
        'For i As Integer = 0 To DgvProductos.Rows.Count - 1
        '    'Dim obj As Object = DgvProductos.Rows(i).Cells(clmIdLinea.Index).Value
        '    'Dim obja As Object = DgvProductos.Rows(i).Cells(clmCantidad.Index).Value
        '    'If Not DgvProductos.Rows(i).Cells(clmPdDescripcion.Index).Value.ToString.Contains(txtProducto.Text.Trim) Then
        '    DgvProductos.CurrentCell = Nothing
        '    DgvProductos.Rows(i).Visible = True
        '    'list.Add(i)
        '    'End If
        'Next
        checkboxCheckedChanged(Nothing, Nothing)
        txtProducto.Focus()
    End Sub



    Private Sub txtProducto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
        '' If DgvProductos.Rows.Count > 0 Then
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then


            ' e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space)
            e.Handled = True
            ''Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            'SendKeys.Send(Chr(Keys.Tab))
            'DgvProductos.CurrentCell.
            ''DgvProductos.Focus()
            If DgvProductos.CurrentCell IsNot Nothing Then
                DgvProductos.Focus()
                DgvProductos.CurrentCell = DgvProductos.Item("clmCantidad", DgvProductos.CurrentRow.Index)
                DgvProductos.CurrentRow.Selected = False
                Application.DoEvents()
                DgvProductos.Item("clmCantidad", DgvProductos.CurrentRow.Index).Selected = True
            Else
                MessageBox.Show("Producto no encontrado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ''Application.DoEvents()
            'DgvProductos.CurrentCell = DgvProductos.Item("clmCantidad", DgvProductos.CurrentRow.Index)
        End If
        '' End If
    End Sub

    Private Sub DgvProductos_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DgvProductos.CellValidating
        Try
            Select Case e.ColumnIndex
                Case Me.clmCantidad.Index
                    'If Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).FormattedValue <> "" And Not Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).FormattedValue Is Nothing Then
                    '    If Not IsNumeric(Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).FormattedValue) Then
                    '        MessageBox.Show("Ingrese solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '        e.Cancel = True
                    '        'Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Nothing
                    '        ''Me.DgvProductos.CurrentRow.Cells(clmCantidad.Index).b
                    '        'Else
                    '        '    Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Convert.ToDouble(Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value).ToString("##,##0.000")
                    '        '    Application.DoEvents()
                    '        '    txtProducto.Text = ""
                    '        '    txtProducto.Focus()
                    '    End If
                    'End If
                    If CStr(DgvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) <> e.FormattedValue Then
                        If DgvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Is Nothing Or e.FormattedValue = "" Then
                            If e.FormattedValue <> "" And Not e.FormattedValue Is Nothing Then
                                If Not IsNumeric(e.FormattedValue) Then
                                    MessageBox.Show("Ingrese solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    e.Cancel = True

                                    'Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Nothing
                                    ''Me.DgvProductos.CurrentRow.Cells(clmCantidad.Index).b
                                    'Else
                                    '    Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Convert.ToDouble(Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value).ToString("##,##0.000")
                                    '    Application.DoEvents()
                                    '    txtProducto.Text = ""
                                    '    txtProducto.Focus()
                                Else
                                    contcap += 1
                                    contporCap -= 1
                                    lblCapturados.Text = Str(contcap)
                                    lblPorCapturar.Text = Str(contporCap)
                                End If
                            Else
                                contcap -= 1
                                contporCap += 1
                                lblCapturados.Text = Str(contcap)
                                lblPorCapturar.Text = Str(contporCap)
                            End If
                        End If
                        Else

                            txtProducto.Focus()
                        End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmCapturaInvFisico_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If cambios Then
        '    If MessageBox.Show("Se han realiado cambios, ¿Desea cerrar sin guardar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
        '        e.Cancel = True
        '    End If
        'End If
    End Sub

    Private Sub DgvProductos_DefaultValuesNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DgvProductos.DefaultValuesNeeded
        'e.Row.Cells(clmGuardado.Index).Value = "N"
    End Sub

    Private Sub DgvProductos_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DgvProductos.RowsAdded
        ''DgvProductos.Rows(e.RowIndex).Cells(clmGuardado.Index).Value = "N"
    End Sub

    Private Sub DgvProductos_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvProductos.RowValidating
        'txtProducto.Text = ""
        'txtProducto.Focus()
    End Sub

    Private Sub txtProducto_Enter(sender As System.Object, e As System.EventArgs) Handles txtProducto.Enter
        txtProducto.Text = ""
    End Sub
End Class