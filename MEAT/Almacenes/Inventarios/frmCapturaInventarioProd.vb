Imports ClasesNegocio
Imports System.Data.SqlClient
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmCapturaInventarioProd

    'Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproducto.TextChanged
    '    Me.CapturaInventarioC.Filtrar(Me.txtproducto.Text.Trim)
    'End Sub

    'Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
    '    Try
    '        Me.CapturaInventarioC.ObtenerProductos()
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub frmCapturaInventarioInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tb As New DataTable
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT [IdProducto],[Descripcion]  FROM [dbo].[MSCCatProductos] WHERE Estatus = 1 ORDER BY [Descripcion]", New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()
                ad.Fill(tb)
                ad.SelectCommand.Connection.Close()

                Me.cmbProducto.DataSource = tb
                cmbProducto.DisplayMember = "Descripcion"
                cmbProducto.ValueMember = "IdProducto"
                Me.cmbProducto.SelectedIndex = -1
                Me.cmbProducto.Text = "Seleccione un producto"
            End Using
            Me.CmbAlmacenes.OnActualizaCombo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dtFechaMov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtFechaMov.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnAgregar.Focus()
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Agregar(Me.txtFolioEtiqueta.Text)
    End Sub

    Private Sub cmbProducto_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducto.ActualizarCombo
        Dim tb As New DataTable
        Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT [IdProducto],[Descripcion]  FROM [dbo].[MSCCatProductos] WHERE Estatus = 1 ORDER BY [Descripcion]", New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
            ad.SelectCommand.Connection.Open()
            ad.Fill(tb)
            ad.SelectCommand.Connection.Close()

            Me.cmbProducto.DataSource = tb
            cmbProducto.DisplayMember = "Descripcion"
            cmbProducto.ValueMember = "IdProducto"
            Me.cmbProducto.SelectedIndex = -1
            Me.cmbProducto.Text = "Seleccione un producto"
        End Using
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        BorraInventario()
        If Me.CapturaInventarioCajasC.Guardar() Then
            MsgBox("Se guardadon los productos en el inventario", MsgBoxStyle.Information, "Aviso")
        End If
        Me.CapturaInventarioCajasC.Clear()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar

    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub btnLeerExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeerExcel.Click
        'Try
        '    Dim m_Excel As Microsoft.Office.Interop.Excel.Application
        '    Dim strRutaExcel As String
        '    Dim archivoExcel As New OpenFileDialog

        '    archivoExcel.Filter = "*.xls |*.xls"

        '    If archivoExcel.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        strRutaExcel = archivoExcel.FileName

        '        m_Excel = CreateObject("Excel.Application")
        '        m_Excel.Workbooks.Open(strRutaExcel)
        '        m_Excel.Visible = False 'Dejamos el libro oculto

        '        'Mostramos el valor de la celda 1,1 del primer libre

        '        'for i as Integer =
        '        'MsgBox(m_Excel.Worksheets("Hoja1").Cells(4, 5).Value)
        '        Me.CapturaInventarioCajasC.Clear()

        '        For i As Integer = 2 To 987
        '            Me.txtFolioEtiqueta.Text = i
        '            Me.cmbProducto.SelectedValue = m_Excel.Worksheets("Hoja1").Cells(i, 2).Value
        '            Me.txtPiezas.Text = m_Excel.Worksheets("Hoja1").Cells(i, 4).Value
        '            Me.txtKilos.Text = m_Excel.Worksheets("Hoja1").Cells(i, 5).Value
        '            Me.dtFechaMov.Value = m_Excel.Worksheets("Hoja1").Cells(i, 6).Value
        '            Agregar()
        '        Next

        '        If Not m_Excel Is Nothing Then
        '            m_Excel.Quit()
        '            m_Excel = Nothing
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
        Try

            Dim strRuta As String
            Dim archivo As New OpenFileDialog
            Dim ListadeCortes As List(Of String) 'lista para guardar los codigos de barra a guardar en la tabla de cortes
            Dim ConfiguracionEtiqueta As New DataSet 'busca el detalle de la configuracion de etiqueta.
            Dim TablaProductos As New DataSet 'tabla de productos
            Dim ProductosRastros As New DataSet 'tabla de relacion de productos de rastros
            Dim CodigoRastro As String 'variable para buscar el codigo del rastro en la tabla de relaciones
            Dim CodigoPropio As String = String.Empty 'variable para codigo que se encuentra registrado en la tabla de productos propia
            Dim Productos As New ClasesNegocio.ProductosClass
            Dim CodigoBarra As String
            Dim bandera As Boolean
            Dim LoteCorteDetalle As ClasesNegocio.CortesDetalleClass
            Dim Cajas As New DataSet
            Dim loteCorteDetC As New CC.MscloteCortesDetCollection

            'verificar que el combo de almacenes tenga seleccionado al menos un almacen para la comparacion.
            If Me.CmbAlmacenes.SelectedValue = 0 Then
                MessageBox.Show("Seleccione Almacen para la Captura de Inventario", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'obtener configuracion.
            ConfiguracionEtiqueta = Utilerias.EjecutarSQL("Select * From ConfiguracionLecturaEtiqueta", "ConfiguracionLecturaEtiqueta", HC.DbUtils.ActualConnectionString)
            'lectura de archivo
            archivo.Filter = "*.txt |*.txt"

            If archivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                strRuta = archivo.FileName

                ListadeCortes = Utilerias.LeerArchivodeTexto(strRuta)
                'Me.txtFolioReferencia.Text = Utilerias.LeerArchivodeTexto(strRuta)
                For i As Integer = 0 To ListadeCortes.Count - 1
                    bandera = False
                    CodigoBarra = ListadeCortes.Item(i)

                    'If Not CodigoBarra.Length = 25 Then
                    '    Dim CodigoBarraIlebible As New frmCodigoBarraIlegible(CodigoBarra, "El siguiente codigo de barra no es legible:")

                    '    If CodigoBarraIlebible.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                    '        CapturaInventarioCajasC.Clear()
                    '        Exit Sub
                    '    Else
                    '        Continue For
                    '    End If
                    'End If

                    'buscar el codigo de barra para que no se repita
                    For j As Integer = 0 To Me.DgvProductos.RowCount - 1
                        If Me.DgvProductos.Rows(j).Cells(Me.CodigoBarraDataGridViewTextBoxColumn.Index).Value = CodigoBarra Then
                            bandera = True
                            Exit For
                        End If
                    Next
                    'buscar en cajas si es que no son originadas en otro rastro y que no esten repetidas
                    If Not bandera Then
                        Me.txtFolioEtiqueta.Text = Mid(CodigoBarra, 1, 14) 'ListadeCortes.Item(i)
                        LoteCorteDetalle = New ClasesNegocio.CortesDetalleClass()
                        'LoteCorteDetalle.ObtenerEntidad()
                        '''' agrega esto aqui
                        loteCorteDetC.GetMulti(HC.MscloteCortesDetFields.CodigoBarra = CodigoBarra.Trim)
                        If loteCorteDetC.Count = 0 Then
                            'Cajas = LoteCorteDetalle.Obtener(10, "", loteCorteDetC(0).IdFolioEtiqueta, 0)
                            'If Cajas.Tables(0).Rows.Count = 0 Then
                            Me.txtKilos.Text = Mid(CodigoBarra, ConfiguracionEtiqueta.Tables(0).Rows(0)("KilosColumnaInicial"), ConfiguracionEtiqueta.Tables(0).Rows(0)("KilosLongitud"))
                            Me.txtKilos.Text = Mid(Me.txtKilos.Text, 1, 4) & "." & Mid(Me.txtKilos.Text, 5, 2)
                            Me.txtPiezas.Text = Mid(Me.txtFolioEtiqueta.Text, ConfiguracionEtiqueta.Tables(0).Rows(0)("PiezasColumnaInicial"), ConfiguracionEtiqueta.Tables(0).Rows(0)("PiezasLongitud"))
                            'busca el codigo del producto en la tabla de relacion del rastro
                            CodigoRastro = Mid(Me.txtFolioEtiqueta.Text, ConfiguracionEtiqueta.Tables(0).Rows(0)("CodigoColumnaInicial"), ConfiguracionEtiqueta.Tables(0).Rows(0)("CodigoLongitud"))
                            ProductosRastros = Utilerias.EjecutarSQL("Select * From MSCRelacionProductosRastros where CodProductoRastro=" & CodigoRastro, "MSCRelacionProductosRastros", HC.DbUtils.ActualConnectionString)

                            If ProductosRastros.Tables(0).Rows.Count > 0 Then
                                CodigoPropio = ProductosRastros.Tables(0).Rows(0)("CodProducto").ToString
                            Else
                                Dim Codigo As String = String.Empty, CodigoBarraIlebible As frmCodigoBarraIlegible
                                Dim IndiceInicial As Integer = CType(ConfiguracionEtiqueta.Tables(0).Rows(0)("CodigoColumnaInicial"), Integer) - 1
                                Dim Longitud As Integer = CType(ConfiguracionEtiqueta.Tables(0).Rows(0)("CodigoLongitud"), Integer) + 1

                                Codigo = CodigoBarra.Insert(IndiceInicial, "(").Insert(Longitud, ")")

                                CodigoBarraIlebible = New frmCodigoBarraIlegible(Codigo, "El siguiente codigo no ha sido capturado en la relacion de Productos - Rastro:")

                                If CodigoBarraIlebible.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                                    CapturaInventarioCajasC.Clear()
                                    Exit Sub
                                Else
                                    Continue For
                                End If
                            End If
                            'buscar producto y lo guarda en la tabla de cortes
                            TablaProductos = Productos.Obtener(CodigoPropio, "", 0, 7)
                            Me.txtCodigoProducto.Text = CodigoPropio 'TablaProductos.Tables(0).Rows(0)("IdCorte").ToString
                            'Me.txtCodCorte.Text = TablaProductos.Tables(0).Rows(0)("IdPreCorte").ToString
                            'Me.txtCorte.Text = TablaProductos.Tables(0).Rows(0)("PreCorte").ToString
                            'Me.txtSubCorte.Text = TablaProductos.Tables(0).Rows(0)("Corte").ToString
                            'Exit For
                            Agregar(CodigoBarra)
                        Else
                            Me.txtKilos.Text = loteCorteDetC(0).CantKgrs 'Cajas.Tables(0).Rows(0)("CantKgrs").ToString
                            Me.txtPiezas.Text = loteCorteDetC(0).CantPzas 'Cajas.Tables(0).Rows(0)("CantPzas").ToString
                            Me.txtCodigoProducto.Text = loteCorteDetC(0).IdProducto 'Cajas.Tables(0).Rows(0)("IdProducto").ToString
                            Agregar(CodigoBarra)
                            Cajas = Nothing
                        End If
                    End If
                Next

                MsgBox("Se ha capturado inventario", MsgBoxStyle.Information, "AVISO")
                'Limpiar()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub Agregar(ByVal CodigoBarra As String)
        Try
            Dim nuevaFila As New ClasesNegocio.CapturaInventarioCajasClass

            With nuevaFila
                .IdFolioEtiquetaReferencia = Me.txtFolioEtiqueta.Text
                .IdProducto = Me.txtCodigoProducto.Text
                .Piezas = Me.txtPiezas.Text
                .Kilos = Me.txtKilos.Text
                .FechaMovimeinto = Me.dtFechaMov.Value
                .Grados = 0
                .CodigoBarra = CodigoBarra
                .IdCorte = .Entidad.MsccatProductos.MsccortesPreCortes.IdPreCorte
                .CodigoAlmacen = Me.CmbAlmacenes.SelectedValue
            End With

            Me.CapturaInventarioCajasC.Add(nuevaFila)

            Me.txtFolioEtiqueta.Clear()
            Me.txtCodigoProducto.Clear()
            Me.txtPiezas.Clear()
            Me.txtKilos.Clear()
            Me.dtFechaMov.Value = Now
            Me.cmbProducto.SelectedIndex = -1
            Me.txtFolioEtiqueta.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Reporte As New rptInventarios
            Dim Tabla As New DataTable
            Dim ConexionSql As New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

            ConexionSql.Open()

            Dim comandoSql As New SqlClient.SqlCommand
            comandoSql = ConexionSql.CreateCommand
            Dim CadenaSql As String

            CadenaSql = "select * from dbo.VwReporteDeInventario"


            comandoSql.CommandText = CadenaSql
            Dim da As New SqlClient.SqlDataAdapter(CadenaSql, ConexionSql)

            da.Fill(Tabla)

            If Tabla.Rows.Count <> 0 Then
                ConexionSql.Close()

                Dim visualizar As New PreVisualizarForm

                Reporte.SetDataSource(Tabla)
                Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                'Reporte.SetParameterValue("FechaInicio", Me.dtpFechaInicial.Value.ToShortDateString)
                'Reporte.SetParameterValue("Fechafin", Me.dtpFechaFinal.Value.ToShortDateString)
                'Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)

                visualizar.Reporte = Reporte
                visualizar.Text = "Reporte de Inventario de Cortes"
                visualizar.ShowDialog()

            Else
                MessageBox.Show("No se encontraron registros", "Aviso")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function BorraInventario() As Boolean
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try

            Dim sqlCom As New SqlCommand("delete MSCLoteCortesDetComparacion", sqlCon)

            sqlCon.Open()

            sqlCom.ExecuteNonQuery()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function

    Private Sub DgvProductos_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvProductos.DataError

    End Sub

    Private Sub CmbAlmacenes_ActualizarCombo(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.ActualizarCombo
        Try
            Me.CmbAlmacenes.DataSource = CC.AlmacenCollection.GetMultiAsDataTable(Nothing, 0, _
                                New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.CmbAlmacenes.DisplayMember = "Descripcion"
            Me.CmbAlmacenes.ValueMember = "AlmacenId"
            Me.CmbAlmacenes.SelectedIndex = -1
            Me.CmbAlmacenes.Text = "Seleccione un almacén"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbAlmacenes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.SelectedIndexChanged

    End Sub
End Class