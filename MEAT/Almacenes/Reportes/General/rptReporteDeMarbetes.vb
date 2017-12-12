Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ClasesNegocio

Public Class rptReporteDeMarbetes
    Dim Editar As Boolean = False
    Private listaProductos As New Dictionary(Of Integer, DataRow)
    Dim tablaProductos As New DataTable
    Dim tablaDetalle As New DataTable
    Dim vecProducto As New ArrayList
    Dim vecCodigoProducto As New ArrayList
    Dim vecNomAlm As New ArrayList

    Private Sub rptReporteDeMarbetes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = "000100011"
            MtbEstados.StateCancelar = "100100011"
            'MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateNuevo = "011000001"
            MtbEstados.StateGuardar = "110100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010000"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            'DESHABILITAR()

            Me.txtAlmacen.Enabled = False
            Me.cmbAlmacen.Enabled = False
            'Me.cmbAlmacen.SelectedIndex = -2
            'Me.cmbAlmacen.Text = "Seleccione un almacen"
            Me.txtLinea.Enabled = False
            Me.cmbLinea.Enabled = False
            'Me.cmbLinea.SelectedIndex = -2
            'Me.cmbLinea.Text = "Seleccione una linea"
            Me.DataGridView1.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "ToolBar"

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DESHABILITAR()
        Me.mtb.HabilitarImprimir = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Try
            Cursor = Cursors.WaitCursor
            Escritura()
            Limpiar()
            HABILITAR()
            Me.AlmacenCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Dim alm As New AlmacenClass(0)
            alm.Descripcion = "Todos Los Almacenes"
            alm.Estatus = EstatusEnum.ACTIVO
            Me.AlmacenCollectionClass1.Add(alm)

            Me.LineaCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Dim linea As New LineaClass()
            linea.Codigo = -1
            linea.Descripcion = "Todas Las Lineas"
            linea.DescripcionCorta = "Todas"
            linea.Estatus = EstatusEnum.ACTIVO
            linea.FechaAlta = Now
            Me.LineaCollectionClass1.Add(linea)
            Me.lblMensaje.Text = ""
            
            Editar = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Me.Imprimir()
        Me.DESHABILITAR()
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarImprimir = False
    End Sub
#End Region

#Region "Metodos"
    Private Sub Escritura()
        Me.cmbAlmacen.Enabled = True
        Me.txtAlmacen.Enabled = True
        Me.cmbLinea.Enabled = True
        Me.txtLinea.Enabled = True
        Me.DataGridView1.ReadOnly = False
    End Sub

    Private Sub Limpiar()
        Me.txtAlmacen.Clear()
        cmbAlmacen.SelectedValue = "Seleccione Almacen"
        Me.txtLinea.Clear()
        Me.cmbLinea.SelectedValue = "Seleccione Linea"
        Me.DataGridView1.Rows.Clear()
        Me.lblMensaje.Text = ""
    End Sub

    Private Sub HABILITAR()
        Me.cmbAlmacen.Enabled = True
        Me.txtAlmacen.Enabled = True
        Me.cmbLinea.Enabled = True
        Me.txtLinea.Enabled = True
        Me.DataGridView1.ReadOnly = False
        Me.clmAlmacen.ReadOnly = True
        Me.clmLinea.ReadOnly = True
        Me.clmCodigo.ReadOnly = True
        Me.clmProducto.ReadOnly = True
        Me.DataGridView1.Enabled = True
    End Sub

    Private Sub DESHABILITAR()
        Me.cmbAlmacen.Enabled = False
        Me.txtAlmacen.Enabled = False
        Me.cmbLinea.Enabled = False
        Me.txtLinea.Enabled = False
        Me.DataGridView1.ReadOnly = True
        Me.clmAlmacen.ReadOnly = True
        Me.clmLinea.ReadOnly = True
        Me.clmCodigo.ReadOnly = True
        Me.clmProducto.ReadOnly = True
        Me.DataGridView1.Enabled = True
    End Sub

    Private Sub ObtenerProductoPorLineaYAlmacen()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "SELECT     MCatCompProductos.PdIdProducto, " & _
                            "            MCatCompProductos.PdDescripcion " & _
                            "FROM        MCatCompProductos INNER JOIN " & _
                            "            MCatCompSubLineas " & _
                            "ON          MCatCompProductos.PdIdSubLinea = MCatCompSubLineas.SLIdSubLinea " & _
                            "INNER JOIN  MCatCompLineas " & _
                            "ON          MCatCompSubLineas.SLIdLinea = MCatCompLineas.LNIdLinea " & _
                            "INNER JOIN  MInvAlmacen " & _
                            "ON MCatCompProductos.PdIdProducto = MInvAlmacen.ProductoId " & _
                            "where       MCatCompSubLineas.SLIdLinea = " & Me.cmbLinea.SelectedValue & _
                            "And         MInvAlmacen.almacenid = " & Me.cmbAlmacen.SelectedValue & _
                            "group by    pdidproducto,pddescripcion"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
            Me.tablaProductos = listaproductos
            Me.listaProductos.Clear()
            For Each row As DataRow In listaproductos.Rows
                Me.listaProductos.Add(CInt(row("PdIdProducto")), row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub ObtenerProductoPorLinea()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "SELECT        MCatCompProductos.PdIdProducto, " & _
                            "               MCatCompProductos.PdDescripcion, " & _
                            "               MCatCompLineas.LNDescripcion, " & _
                            "               MInvAlmacen.AlmacenId, " & _
                            "               MCatAlmacenes.Nombre " & _
                            "FROM           MCatCompProductos INNER JOIN MCatCompSubLineas " & _
                            "ON             MCatCompProductos.PdIdSubLinea = MCatCompSubLineas.SLIdSubLinea " & _
                            "INNER JOIN     MCatCompLineas " & _
                            "ON             MCatCompSubLineas.SLIdLinea = MCatCompLineas.LNIdLinea " & _
                            "INNER JOIN     MInvAlmacen " & _
                            "ON             MCatCompProductos.PdIdProducto = MInvAlmacen.ProductoId " & _
                            "INNER JOIN     MCatAlmacenes " & _
                            "ON             MInvAlmacen.AlmacenId = MCatAlmacenes.Codigo " & _
                            "WHERE          MCatCompLineas.LNIdLinea = " & Me.cmbLinea.SelectedValue & _
            "GROUP BY       MCatCompProductos.PdIdProducto, " & _
            "               MCatCompProductos.PdDescripcion, " & _
            "               MCatCompLineas.LNDescripcion, " & _
            "               MCatCompLineas.LNIdLinea, " & _
            "               MInvAlmacen.AlmacenId, " & _
            "               MCatAlmacenes.Nombre"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
            Me.tablaDetalle = listaproductos
            Me.listaProductos.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub ObtenerProductoPorAlmacen()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "SELECT        MCatCompProductos.PdIdProducto, " & _
                            "               MCatCompProductos.PdDescripcion, " & _
                            "               MCatCompLineas.LNDescripcion, " & _
                            "               MInvAlmacen.AlmacenId, " & _
                            "               MCatAlmacenes.Nombre " & _
                            "FROM           MCatCompProductos INNER JOIN MCatCompSubLineas " & _
                            "ON             MCatCompProductos.PdIdSubLinea = MCatCompSubLineas.SLIdSubLinea " & _
                            "INNER JOIN     MCatCompLineas " & _
                            "ON             MCatCompSubLineas.SLIdLinea = MCatCompLineas.LNIdLinea " & _
                            "INNER JOIN     MInvAlmacen " & _
                            "ON             MCatCompProductos.PdIdProducto = MInvAlmacen.ProductoId " & _
                            "INNER JOIN     MCatAlmacenes " & _
                            "ON             MInvAlmacen.AlmacenId = MCatAlmacenes.Codigo " & _
                            "WHERE          MCatAlmacenes.Codigo = " & Me.cmbAlmacen.SelectedValue & _
            "GROUP BY       MCatCompProductos.PdIdProducto, " & _
            "               MCatCompProductos.PdDescripcion, " & _
            "               MCatCompLineas.LNDescripcion, " & _
            "               MCatCompLineas.LNIdLinea, " & _
            "               MInvAlmacen.AlmacenId, " & _
            "               MCatAlmacenes.Nombre"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
            Me.tablaDetalle = listaproductos
            Me.listaProductos.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub ObtenerProducto()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "SELECT        MCatCompProductos.PdIdProducto, " & _
                            "               MCatCompProductos.PdDescripcion, " & _
                            "               MCatCompLineas.LNDescripcion, " & _
                            "               MInvAlmacen.AlmacenId, " & _
                            "               MCatAlmacenes.Nombre " & _
                            "FROM           MCatCompProductos INNER JOIN MCatCompSubLineas " & _
                            "ON             MCatCompProductos.PdIdSubLinea = MCatCompSubLineas.SLIdSubLinea " & _
                            "INNER JOIN     MCatCompLineas " & _
                            "ON             MCatCompSubLineas.SLIdLinea = MCatCompLineas.LNIdLinea " & _
                            "INNER JOIN     MInvAlmacen " & _
                            "ON             MCatCompProductos.PdIdProducto = MInvAlmacen.ProductoId " & _
                            "INNER JOIN     MCatAlmacenes " & _
                            "ON             MInvAlmacen.AlmacenId = MCatAlmacenes.Codigo " & _
                             "GROUP BY      MCatCompProductos.PdIdProducto, " & _
                             "              MCatCompProductos.PdDescripcion, " & _
                             "              MCatCompLineas.LNDescripcion, " & _
                             "              MCatCompLineas.LNIdLinea, " & _
                             "              MInvAlmacen.AlmacenId, " & _
                             "              MCatAlmacenes.Nombre"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
            Me.tablaDetalle = listaproductos
            Me.listaProductos.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub ponerdatosGridAyL()
        Try
            Dim contadorAyL As Integer = 0
            Dim cont As Integer = 2
            Me.DataGridView1.Rows.Clear()
            If Not Me.DataGridView1.Rows.Count <= 0 Then
                If Me.tablaProductos.Rows.Count = 0 Then
                    Me.lblMensaje.Text = "La Consulta No Trajo Datos"
                    Me.lblMensaje.ForeColor = Color.Red
                    Me.lblMensaje.Visible = True
                Else
                    Me.DataGridView1.Rows.Add(Me.tablaProductos.Rows.Count)
                    For Each row As DataRow In Me.tablaProductos.Rows
                        With Me.DataGridView1.Rows(contadorAyL)
                            Me.DataGridView1.Rows(contadorAyL).Cells(Me.clmAlmacen.Index).Value = Me.cmbAlmacen.Text
                            Me.DataGridView1.Rows(contadorAyL).Cells(Me.clmLinea.Index).Value = Me.cmbLinea.Text
                            .Cells(Me.clmCodigo.Index).Value = Me.tablaProductos.Rows(contadorAyL)("PdIdProducto")
                            .Cells(Me.clmProducto.Index).Value = Me.tablaProductos.Rows(contadorAyL)("PdDescripcion")
                        End With
                        cont += 1
                        contadorAyL += 1
                    Next
                    Me.lblMensaje.Text = "Consulta Exitosa"
                    Me.lblMensaje.ForeColor = Color.Green
                    Me.lblMensaje.Visible = True
                End If
            End If
            Me.mtb.HabilitarImprimir = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error llenarGrid")
        End Try
    End Sub

    Private Sub ponerDatosGridL()
        Try
            Dim contadorAyL As Integer = 0
            Dim cont As Integer = 2
            Me.DataGridView1.Rows.Clear()
            Me.vecNomAlm.Clear()
            If Not Me.DataGridView1.Rows.Count <= 0 Then
                If Me.tablaDetalle.Rows.Count = 0 Then
                    Me.lblMensaje.Text = "La Consulta No Trajo Datos"
                    Me.lblMensaje.ForeColor = Color.Red
                    Me.lblMensaje.Visible = True
                Else
                    Me.DataGridView1.Rows.Add(Me.tablaDetalle.Rows.Count)
                    For Each row As DataRow In Me.tablaDetalle.Rows
                        With Me.DataGridView1.Rows(contadorAyL)
                            .Cells(Me.clmAlmacen.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("Nombre")
                            .Cells(Me.clmLinea.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("LNDescripcion")
                            .Cells(Me.clmCodigo.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("PdIdProducto")
                            .Cells(Me.clmProducto.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("PdDescripcion")
                        End With
                        cont += 1
                        contadorAyL += 1
                    Next
                    Me.DataGridView1.Sort(Me.clmAlmacen, System.ComponentModel.ListSortDirection.Descending)
                    Me.lblMensaje.Text = "Consulta Exitosa"
                    Me.lblMensaje.ForeColor = Color.Green
                    Me.lblMensaje.Visible = True
                End If
            End If
            Me.mtb.HabilitarImprimir = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error llenarGrid")
        End Try
    End Sub

    Private Sub ponerDatosGridA()
        Try
            Dim contadorAyL As Integer = 0
            Dim cont As Integer = 2
            Me.DataGridView1.Rows.Clear()
            Me.vecNomAlm.Clear()
            If Not Me.DataGridView1.Rows.Count <= 0 Then
                If Me.tablaDetalle.Rows.Count = 0 Then
                    Me.lblMensaje.Text = "La Consulta No Trajo Datos"
                    Me.lblMensaje.ForeColor = Color.Red
                    Me.lblMensaje.Visible = True
                Else
                    Me.DataGridView1.Rows.Add(Me.tablaDetalle.Rows.Count)
                    For Each row As DataRow In Me.tablaDetalle.Rows
                        With Me.DataGridView1.Rows(contadorAyL)
                            .Cells(Me.clmAlmacen.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("Nombre")
                            .Cells(Me.clmLinea.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("LNDescripcion")
                            .Cells(Me.clmCodigo.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("PdIdProducto")
                            .Cells(Me.clmProducto.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("PdDescripcion")
                        End With
                        cont += 1
                        contadorAyL += 1
                    Next
                    Me.DataGridView1.Sort(Me.clmLinea, System.ComponentModel.ListSortDirection.Descending)
                    Me.lblMensaje.Text = "Consulta Exitosa"
                    Me.lblMensaje.ForeColor = Color.Green
                    Me.lblMensaje.Visible = True
                End If
            End If
            Me.mtb.HabilitarImprimir = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error llenarGrid")
        End Try
    End Sub

    Private Sub ponerDatosGrid()
        Try
            Dim contadorAyL As Integer = 0
            Dim cont As Integer = 2
            Me.DataGridView1.Rows.Clear()
            Me.vecNomAlm.Clear()
            If Not Me.DataGridView1.Rows.Count <= 0 Then
                If Me.tablaDetalle.Rows.Count = 0 Then
                    Me.lblMensaje.Text = "La Consulta No Trajo Datos"
                    Me.lblMensaje.ForeColor = Color.Red
                    Me.lblMensaje.Visible = True
                Else
                    Me.DataGridView1.Rows.Add(Me.tablaDetalle.Rows.Count)
                    For Each row As DataRow In Me.tablaDetalle.Rows
                        With Me.DataGridView1.Rows(contadorAyL)
                            .Cells(Me.clmAlmacen.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("Nombre")
                            .Cells(Me.clmLinea.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("LNDescripcion")
                            .Cells(Me.clmCodigo.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("PdIdProducto")
                            .Cells(Me.clmProducto.Index).Value = Me.tablaDetalle.Rows(contadorAyL)("PdDescripcion")
                        End With
                        cont += 1
                        contadorAyL += 1
                    Next
                    Me.DataGridView1.Sort(Me.clmAlmacen, System.ComponentModel.ListSortDirection.Descending)
                    Me.lblMensaje.Text = "Consulta Exitosa"
                    Me.lblMensaje.ForeColor = Color.Green
                    Me.lblMensaje.Visible = True
                End If
            End If
            Me.mtb.HabilitarImprimir = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error llenarGrid")
        End Try
    End Sub
#End Region

    Public Sub Imprimir()
        Try
            Dim reporte As New rptReporteMarbete
            Dim ventana As New PreVisualizarForm
            Dim salidas As New dsReporteMarbete
            Dim tabla As dsReporteMarbete.tablaDataTable = salidas.Tables("tabla")
            Dim rowtabla As dsReporteMarbete.tablaRow
            Dim contador As Integer = 0
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                rowtabla = tabla.AddtablaRow(Me.DataGridView1.Rows(contador).Cells(Me.clmCodigo.Index).Value, _
                                            Me.DataGridView1.Rows(contador).Cells(Me.clmProducto.Index).Value, _
                                            Me.DataGridView1.Rows(contador).Cells(Me.clmAlmacen.Index).Value, _
                                            Me.DataGridView1.Rows(contador).Cells(Me.clmLinea.Index).Value)
                contador += 1
            Next

            reporte.SetDataSource(salidas)
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, "Almacen/Inventario/Reporte de marbete")
            reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            ventana.Reporte = reporte
            ventana.Text = "Reporte de marbete"
            ventana.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            ventana.WindowState = Windows.Forms.FormWindowState.Maximized
            ventana.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    
    Private Sub cmbAlmacen_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged

        If Not Me.cmbAlmacen.Text = "" And Not Me.txtAlmacen.Text = "" _
        And Not Me.cmbLinea.Text = "" And Not Me.txtLinea.Text = "" Then

            If Me.cmbAlmacen.Text = "Todos Los Almacenes" And Me.txtAlmacen.Text = 0 _
            And Not Me.cmbLinea.Text = "Todas Las Lineas" And Not Me.txtLinea.Text = 0 Then
                Me.ObtenerProductoPorLinea()
                Me.ponerDatosGridL()
            End If

            If Me.cmbAlmacen.Text IsNot "Todos Los Almacenes" And Not Me.txtAlmacen.Text = 0 _
            And Me.cmbLinea.Text Is "Todas Las Lineas" And Me.txtLinea.Text = 0 Then
                Me.ObtenerProductoPorAlmacen()
                Me.ponerDatosGridA()
            End If

            If Me.cmbAlmacen.Text IsNot "Todos Los Almacenes" And Not Me.txtAlmacen.Text = 0 _
            And Not Me.cmbLinea.Text IsNot "Todas Las Lineas" And Not Me.txtLinea.Text = 0 Then
                Me.ObtenerProductoPorLineaYAlmacen()
                Me.ponerdatosGridAyL()
            End If

            If Me.cmbAlmacen.Text Is "Todos Los Almacenes" And Me.txtAlmacen.Text = 0 _
           And Not Me.cmbLinea.Text Is "Todas Las Lineas" And Me.txtLinea.Text = 0 Then
                Me.ObtenerProducto()
                Me.ponerDatosGrid()
            End If
        End If
    End Sub

    Private Sub cmbLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLinea.SelectedIndexChanged
        If Not Me.cmbAlmacen.Text = "" And Not Me.txtAlmacen.Text = "" _
    And Not Me.cmbLinea.Text = "" And Not Me.txtLinea.Text = "" Then

            If Me.cmbAlmacen.Text = "Todos Los Almacenes" And Me.txtAlmacen.Text = 0 _
            And Not Me.cmbLinea.Text = "Todas Las Lineas" And Not Me.txtLinea.Text = 0 Then
                Me.ObtenerProductoPorLinea()
                Me.ponerDatosGridL()
            End If

            If Me.cmbAlmacen.Text IsNot "Todos Los Almacenes" And Not Me.txtAlmacen.Text = 0 _
            And Me.cmbLinea.Text Is "Todas Las Lineas" And Me.txtLinea.Text = 0 Then
                Me.ObtenerProductoPorAlmacen()
                Me.ponerDatosGridA()
            End If

            If Me.cmbAlmacen.Text IsNot "Todos Los Almacenes" And Not Me.txtAlmacen.Text = 0 _
            And Me.cmbLinea.Text IsNot "Todas Las Lineas" And Not Me.txtLinea.Text = 0 Then
                Me.ObtenerProductoPorLineaYAlmacen()
                Me.ponerdatosGridAyL()
            End If

            If Me.cmbAlmacen.Text Is "Todos Los Almacenes" And Me.txtAlmacen.Text = 0 _
           And Me.cmbLinea.Text Is "Todas Las Lineas" And Me.txtLinea.Text = 0 Then
                Me.ObtenerProducto()
                Me.ponerDatosGrid()
            End If
        End If
    End Sub
End Class