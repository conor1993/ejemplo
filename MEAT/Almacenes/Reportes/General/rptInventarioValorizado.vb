Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ClasesNegocio

Public Class rptInventarioValorizado

#Region "Miembros"
    Dim Editar As Boolean = False
    Private listaAlmacenes As New Dictionary(Of Integer, DataRow)
    Private listaPlazas As New Dictionary(Of Integer, DataRow)
    Dim datosGrid As New DataTable
#End Region

    Private Sub rptInventarioValorizado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            Me.txtPlaza.Enabled = False
            Me.cmbPlaza.Enabled = False
            ' Me.cmbPlaza.SelectedIndex = -1
            'Me.cmbPlaza.Text = "Seleccione una plaza"
            Me.txtAlmacen.Enabled = False
            Me.cmbAlmacen.Enabled = False
            ' Me.cmbAlmacen.SelectedIndex = -1
            'Me.cmbAlmacen.Text = "Seleccione un almacen"
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
            'Me.cmbPlaza.DataSource = Nothing
            Cursor = Cursors.WaitCursor
            'Me.AlmacenCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Escritura()
            Limpiar()
            HABILITAR()
            'Me.obtenerPlazas()
            Me.PlazaCol.Obtener(CondicionEnum.ACTIVOS)
            Dim plaza As New PlazaClass()
            plaza.Codigo = -1
            plaza.Descripcion = "Todas Las Plazas"
            Me.PlazaCol.Add(plaza)
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
        Me.cmbPlaza.Enabled = True
        Me.txtPlaza.Enabled = True
        Me.cmbAlmacen.Enabled = True
        Me.txtAlmacen.Enabled = True
        Me.DataGridView1.ReadOnly = False
        
    End Sub

    Private Sub Limpiar()
        Me.txtPlaza.Clear()
        'Me.cmbPlaza.SelectedValue = "Seleccione Plaza"
        Me.txtAlmacen.Clear()
        'cmbAlmacen.SelectedValue = "Seleccione Almacen"
        Me.DataGridView1.Rows.Clear()
        
    End Sub

    Private Sub HABILITAR()
        Me.cmbPlaza.Enabled = True
        Me.txtPlaza.Enabled = True
        Me.cmbAlmacen.Enabled = True
        Me.txtAlmacen.Enabled = True
        Me.DataGridView1.ReadOnly = False
        Me.clmAlmacen.ReadOnly = True
        Me.clmCodigo.ReadOnly = True
        Me.clmProducto.ReadOnly = True
        Me.clmCosto.ReadOnly = True
        Me.clmTotal.ReadOnly = True
        Me.DataGridView1.Enabled = True

       
    End Sub

    Private Sub DESHABILITAR()
        Me.cmbPlaza.Enabled = False
        Me.txtPlaza.Enabled = False
        Me.cmbAlmacen.Enabled = False
        Me.txtAlmacen.Enabled = False
        Me.DataGridView1.ReadOnly = True
        Me.clmAlmacen.ReadOnly = True
        'Me.clmProveedor.ReadOnly = True
        Me.clmCodigo.ReadOnly = True
        Me.clmProducto.ReadOnly = True
        Me.clmCosto.ReadOnly = True
        Me.clmTotal.ReadOnly = True
        Me.DataGridView1.Enabled = False
       
    End Sub

    Private Sub obtenerPlazas()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "select PLIdPlaza, PLDescripcion from MCatGenPlazas"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)

            Me.cmbPlaza.DataSource = listaproductos
            Me.cmbPlaza.DisplayMember = "PLDescripcion"
            Me.cmbPlaza.ValueMember = "PLIdPlaza"

            Me.listaPlazas.Clear()
            For Each row As DataRow In listaproductos.Rows
                Me.listaPlazas.Add(CInt(row("PLIdPlaza")), row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerAlmacenesPorPlaza()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable
            

            cadenaConsulta = "select codigo, nombre " & _
                            "from mcatalmacenes " & _
                            " where plaza = " & CInt(Me.cmbPlaza.SelectedValue)

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)

            Me.cmbAlmacen.DataSource = listaproductos
            Me.cmbAlmacen.DisplayMember = "nombre"
            Me.cmbAlmacen.ValueMember = "codigo"

            Me.listaAlmacenes.Clear()
            For Each row As DataRow In listaproductos.Rows
                Me.listaAlmacenes.Add(CInt(row("codigo")), row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerAlmacenes()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "select codigo, nombre " & _
                            "from mcatalmacenes " 

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)

            Me.cmbAlmacen.DataSource = listaproductos
            Me.cmbAlmacen.DisplayMember = "nombre"
            Me.cmbAlmacen.ValueMember = "codigo"

            Me.listaAlmacenes.Clear()
            For Each row As DataRow In listaproductos.Rows
                Me.listaAlmacenes.Add(CInt(row("codigo")), row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerDatosGridConPlazaYalmacen()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable
            If Me.cmbAlmacen.SelectedValue Is Nothing Then
                Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1
            End If

            cadenaConsulta = "SELECT    Inv.AlmacenId, Alm.Nombre AS Almacen, " & _
                            "           Inv.ProductoId, Prod.PdDescripcion AS Producto,uni.umdesccorta, " & _
                            "           Plaz.PLIdPlaza AS IdPlaza, Plaz.PLDescripcion AS Plaza, " & _
                            "           (SELECT     TOP 1 CantidadExistencia " & _
                            "           FROM       MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Existencia, " & _
                            "           (SELECT     TOP 1 CostoPromedio " & _
                            "           FROM  MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Costo " & _
                            "FROM       MInvAlmacen AS Inv INNER JOIN MCatAlmacenes AS Alm ON Inv.AlmacenId = Alm.Codigo " & _
                            "                              INNER JOIN MCatCompProductos AS Prod ON Inv.ProductoId = Prod.PdIdProducto " & _
                            "                              INNER JOIN mcatcompunidadmedida AS uni ON uni.umidunidadmedida=prod.pdidunidadmedida " & _
                            "                              INNER JOIN MCatGenPlazas AS Plaz ON Alm.Plaza = Plaz.PLIdPlaza " & _
                            "where      Plaz.PLIdPlaza = " & Me.cmbPlaza.SelectedValue & _
                            "           And inv.almacenid = " & Me.cmbAlmacen.SelectedValue & _
                            "GROUP BY   Inv.AlmacenId, Alm.Nombre, Inv.ProductoId, Prod.PdDescripcion, uni.umdesccorta, Plaz.PLIdPlaza, Plaz.PLDescripcion " & _
                            "ORDER BY   Plaza, Almacen, Producto"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
            Me.datosGrid = listaproductos

           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerDatosGridConPlaza()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "SELECT    Inv.AlmacenId, Alm.Nombre AS Almacen, " & _
                            "           Inv.ProductoId, Prod.PdDescripcion AS Producto,uni.umdesccorta, " & _
                            "           Plaz.PLIdPlaza AS IdPlaza, Plaz.PLDescripcion AS Plaza, " & _
                            "           (SELECT     TOP 1 CantidadExistencia " & _
                            "           FROM       MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Existencia, " & _
                            "           (SELECT     TOP 1 CostoPromedio " & _
                            "           FROM  MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Costo " & _
                            "FROM       MInvAlmacen AS Inv INNER JOIN MCatAlmacenes AS Alm ON Inv.AlmacenId = Alm.Codigo " & _
                            "                              INNER JOIN MCatCompProductos AS Prod ON Inv.ProductoId = Prod.PdIdProducto " & _
                            "                              INNER JOIN mcatcompunidadmedida AS uni ON uni.umidunidadmedida=prod.pdidunidadmedida " & _
                            "                              INNER JOIN MCatGenPlazas AS Plaz ON Alm.Plaza = Plaz.PLIdPlaza " & _
                            "where      Plaz.PLIdPlaza = " & Me.cmbPlaza.SelectedValue & _
                            " GROUP BY   Inv.AlmacenId, Alm.Nombre,Inv.ProductoId, Prod.PdDescripcion, uni.umdesccorta, Plaz.PLIdPlaza, Plaz.PLDescripcion " & _
                            "ORDER BY   Plaza, Almacen, Producto"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
            Me.datosGrid = listaproductos



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerDatosGridConAlmacen()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable



            cadenaConsulta = "SELECT    Inv.AlmacenId, Alm.Nombre AS Almacen, " & _
                            "           Inv.ProductoId, Prod.PdDescripcion AS Producto,uni.umdesccorta, " & _
                            "           Plaz.PLIdPlaza AS IdPlaza, Plaz.PLDescripcion AS Plaza, " & _
                            "           (SELECT     TOP 1 CantidadExistencia " & _
                            "           FROM       MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Existencia, " & _
                            "           (SELECT     TOP 1 CostoPromedio " & _
                            "           FROM  MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Costo " & _
                            "FROM       MInvAlmacen AS Inv INNER JOIN MCatAlmacenes AS Alm ON Inv.AlmacenId = Alm.Codigo " & _
                            "                              INNER JOIN MCatCompProductos AS Prod ON Inv.ProductoId = Prod.PdIdProducto " & _
                            "                              INNER JOIN mcatcompunidadmedida AS uni ON uni.umidunidadmedida=prod.pdidunidadmedida " & _
                            "                              INNER JOIN MCatGenPlazas AS Plaz ON Alm.Plaza = Plaz.PLIdPlaza " & _
                            "where      inv.almacenid = " & Me.cmbAlmacen.SelectedValue & _
                            "GROUP BY   Inv.AlmacenId, Alm.Nombre, Inv.ProductoId, Prod.PdDescripcion, umi.umdescorta, Plaz.PLIdPlaza, Plaz.PLDescripcion " & _
                            "ORDER BY   Plaza, Almacen, Producto"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
           Me.datosGrid = listaproductos


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerDatosGrid()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            Dim cadenaConsulta As String
            Dim sqlCom As SqlCommand
            Dim sqlDataAdapter As SqlDataAdapter
            Dim listaproductos As New DataTable

            cadenaConsulta = "SELECT    Inv.AlmacenId, Alm.Nombre AS Almacen, " & _
                            "           Inv.ProductoId, Prod.PdDescripcion AS Producto,uni.umdesccorta, " & _
                            "           Plaz.PLIdPlaza AS IdPlaza, Plaz.PLDescripcion AS Plaza, " & _
                            "           (SELECT     TOP 1 CantidadExistencia " & _
                            "           FROM       MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Existencia, " & _
                            "           (SELECT     TOP 1 CostoPromedio " & _
                            "           FROM  MInvAlmacen " & _
                            "           WHERE      ProductoId = Inv.ProductoId AND AlmacenId = Inv.AlmacenId " & _
                            "           ORDER BY Año DESC, Mes DESC) AS Costo " & _
                            "FROM       MInvAlmacen AS Inv INNER JOIN MCatAlmacenes AS Alm ON Inv.AlmacenId = Alm.Codigo " & _
                            "                              INNER JOIN MCatCompProductos AS Prod ON Inv.ProductoId = Prod.PdIdProducto " & _
                            "                              INNER JOIN mcatcompunidadmedida AS uni ON uni.umidunidadmedida=prod.pdidunidadmedida " & _
                            "                              INNER JOIN MCatGenPlazas AS Plaz ON Alm.Plaza = Plaz.PLIdPlaza " & _
                            "GROUP BY   Inv.AlmacenId, Alm.Nombre,Inv.ProductoId, Prod.PdDescripcion, uni.umdesccorta, Plaz.PLIdPlaza, Plaz.PLDescripcion " & _
                            "ORDER BY   Plaza, Almacen, Producto"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)
            sqlCon.Open()
            sqlDataAdapter.Fill(listaproductos)
            Me.datosGrid = listaproductos


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub llenarGrid()
        Try
            Dim cont As Integer = 0
            Dim total As Decimal = 0D
            Me.DataGridView1.Rows.Clear()
            If Not Me.DataGridView1.Rows.Count <= 0 Then
                If Me.datosGrid.Rows.Count = 0 Then
                    'Me.lblMensaje.Text = "La Consulta No Trajo Datos"
                    'Me.lblMensaje.ForeColor = Color.Red
                    'Me.lblMensaje.Visible = True
                Else
                    Me.DataGridView1.Rows.Add(Me.datosGrid.Rows.Count)
                    For Each row As DataRow In Me.datosGrid.Rows
                        With Me.DataGridView1.Rows(cont)
                            .Cells(Me.clmPlaza.Index).Value = Me.datosGrid.Rows(cont)("Plaza")
                            .Cells(Me.clmAlmacen.Index).Value = Me.datosGrid.Rows(cont)("Almacen")
                            .Cells(Me.clmCodigo.Index).Value = Me.datosGrid.Rows(cont)("ProductoId")
                            .Cells(Me.clmProducto.Index).Value = Me.datosGrid.Rows(cont)("Producto")
                            .Cells(Me.clmUnidadMedida.Index).Value = Me.datosGrid.Rows(cont)("umdesccorta")
                            .Cells(Me.clmExistencia.Index).Value = Me.datosGrid.Rows(cont)("Existencia")
                            .Cells(Me.clmCosto.Index).Value = Me.datosGrid.Rows(cont)("Costo")
                            .Cells(Me.clmTotal.Index).Value = CDec(Me.datosGrid.Rows(cont)("Existencia")) * CDec(Me.datosGrid.Rows(cont)("Costo"))
                            total += CDec(.Cells(Me.clmTotal.Index).Value).ToString("C2")
                        End With
                        cont += 1
                        'contadorAyL += 1
                    Next
                    'Me.lblMensaje.Text = "La Consulta Fue Exitosa"
                    'Me.lblMensaje.ForeColor = Color.Green
                    'Me.lblMensaje.Visible = True
                End If
            End If
            Me.txtTotal.Text = total.ToString("C2")
            Me.mtb.HabilitarImprimir = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error llenarGrid")
        End Try
    End Sub

    Public Sub Imprimir()
        Try
            Dim reporte As New rptReporteInventarioValorizado
            Dim ventana As New PreVisualizarForm
            Dim salidas As New dsInventarioValorizao
            Dim tabla As dsInventarioValorizao.InvValorizadoDataTable = salidas.Tables("InvValorizado")
            Dim rowtabla As dsInventarioValorizao.InvValorizadoRow
            Dim contador As Integer = 0
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                rowtabla = tabla.AddInvValorizadoRow(Me.DataGridView1.Rows(contador).Cells(Me.clmPlaza.Index).Value, _
                                                    Me.DataGridView1.Rows(contador).Cells(Me.clmAlmacen.Index).Value, _
                                                    Me.DataGridView1.Rows(contador).Cells(Me.clmCodigo.Index).Value, _
                                                    Me.DataGridView1.Rows(contador).Cells(Me.clmProducto.Index).Value, _
                                                    Me.DataGridView1.Rows(contador).Cells(Me.clmExistencia.Index).Value, _
                                                    Me.DataGridView1.Rows(contador).Cells(Me.clmCosto.Index).Value, _
                                                    Me.DataGridView1.Rows(contador).Cells(Me.clmTotal.Index).Value, _
                Me.DataGridView1.Rows(contador).Cells(Me.clmUnidadMedida.Index).Value)
                contador += 1
            Next

            reporte.SetDataSource(salidas)
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, "Almacen/General/Reportes/Inventario Valorizado")
            reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            ventana.Reporte = reporte
            ventana.Text = "Inventario Valorizado"
            ventana.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            ventana.WindowState = Windows.Forms.FormWindowState.Maximized
            ventana.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "TextChanged"
    'Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not Me.cmbPlaza.SelectedIndex <= -1 And Not Me.txtPlaza.Text = "" And Me.chkAlmacenes.Checked = True Then
    '            Me.obtenerDatosGridConPlaza()
    '            Me.llenarGrid()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    'Private Sub CmbAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Me.cmbAlmacen.Text = "" Then
    '            If Not Me.txtAlmacen.Text = "" Then
    '                Me.cmbAlmacen.SelectedValue = Me.txtAlmacen.Text
    '                If Me.chkPlaza.Checked = True Then
    '                    Me.obtenerDatosGridConPlazaYalmacen()
    '                    Me.llenarGrid()
    '                End If
    '            End If
    '        Else
    '            Me.txtAlmacen.Text = Me.cmbAlmacen.SelectedValue
    '            If Me.chkPlaza.Checked = True Then
    '                Me.obtenerDatosGridConPlazaYalmacen()
    '                Me.llenarGrid()
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub


#End Region

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        
        If Me.cmbPlaza.SelectedIndex > -1 Then
            If Not Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 Then
                Me.AlmacenCollectionClass1.Obtener(CondicionEnum.ACTIVOS, CInt(Me.cmbPlaza.SelectedValue))
            Else
                Me.AlmacenCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
            Dim alm As New AlmacenClass()
            alm.Descripcion = "Todos Los Almacenes"
            alm.Estatus = EstatusEnum.ACTIVO
            Me.AlmacenCollectionClass1.Add(alm)

            If Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 And Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                If Me.cmbPlaza.Text = "Todas Las Plazas" And Me.cmbAlmacen.Text = "Todos Los Almacenes" Then
                    If Me.txtPlaza.Text = "0" Or Me.txtPlaza.Text = "" Then
                        If Me.txtAlmacen.Text = "0" Or Me.txtAlmacen.Text = "" Then
                            Me.obtenerDatosGrid()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If

            If Not Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 And Not Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                If Not Me.cmbPlaza.Text = "Todas Las Plazas" And Not Me.cmbAlmacen.Text = "Todos Los Almacenes" Then
                    If Not Me.txtPlaza.Text = "" Then
                        If Not Me.txtAlmacen.Text = "0" Or Not Me.txtAlmacen.Text = "" Then
                            Me.obtenerDatosGridConPlazaYalmacen()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If

            If Me.txtPlaza.Text = "" Or Me.txtPlaza.Text = "0" Then
                If Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 Or Me.cmbPlaza.Text = "Todas Las Plazas" Then
                    If Not Me.txtAlmacen.Text = "0" And Not Me.txtAlmacen.Text = "" Then
                        If Not Me.cmbAlmacen.Text Is "Todos Los Almacenes" And Not Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                            Me.obtenerDatosGridConAlmacen()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If

            If Not Me.txtPlaza.Text = "" Then
                If Not Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 Or Not Me.cmbPlaza.Text = "Todas Las Plazas" Then
                    If Me.txtAlmacen.Text = "0" Or Me.txtAlmacen.Text = "" Then
                        If Me.cmbAlmacen.Text = "Todos Los Almacenes" Or Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                            Me.obtenerDatosGridConPlaza()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    'Private Sub txtPlaza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlaza.TextChanged

    '    If Me.txtPlaza.Text IsNot "" Then
    '        Me.cmbPlaza.Text = Me.cmbPlaza.Text
    '        'Me.obtenerAlmacenesPorPlaza()
    '        If Not Me.cmbPlaza.SelectedIndex <= -1 And Not Me.txtPlaza.Text = "" And _
    '                Not Me.cmbAlmacen.SelectedIndex <= -1 And Not Me.txtAlmacen.Text = "" Then
    '            'Me.obtenerDatosGridConPlazaYalmacen()
    '            'Me.llenarGrid()
    '        End If
    '    Else
    '        Me.cmbAlmacen.SelectedValue = 0
    '    End If
    'End Sub

    'Private Sub txtAlmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacen.TextChanged
    '    If Not Me.cmbPlaza.SelectedIndex <= -1 And Not Me.txtPlaza.Text = "" And _
    '            Not Me.cmbAlmacen.SelectedIndex <= -1 And Not Me.txtAlmacen.Text = "" Then
    '        'Me.obtenerDatosGridConPlazaYalmacen()
    '        'Me.llenarGrid()
    '    End If
    'End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        If Me.cmbPlaza.SelectedIndex > -1 Then
           
            If Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 And Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                If Me.cmbPlaza.Text = "Todas Las Plazas" And Me.cmbAlmacen.Text = "Todos Los Almacenes" Then
                    If Me.txtPlaza.Text = "0" Or Me.txtPlaza.Text = "" Then
                        If Me.txtAlmacen.Text = "0" Or Me.txtAlmacen.Text = "" Then
                            Me.obtenerDatosGrid()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If

            If Not Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 And Not Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                If Not Me.cmbPlaza.Text = "Todas Las Plazas" And Not Me.cmbAlmacen.Text = "Todos Los Almacenes" Then
                    If Not Me.txtPlaza.Text = "" Then
                        If Not Me.txtAlmacen.Text = "0" Or Not Me.txtAlmacen.Text = "" Then
                            Me.obtenerDatosGridConPlazaYalmacen()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If

            If Me.txtPlaza.Text = "" Or Me.txtPlaza.Text = "0" Then
                If Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 Or Me.cmbPlaza.Text = "Todas Las Plazas" Then
                    If Not Me.txtAlmacen.Text = "0" And Not Me.txtAlmacen.Text = "" Then
                        If Not Me.cmbAlmacen.Text = "Todos Los Almacenes" And Not Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                            Me.obtenerDatosGridConAlmacen()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If

            If Not Me.txtPlaza.Text = "" Then
                If Not Me.cmbPlaza.SelectedIndex = Me.PlazaCol.Count - 1 Or Not Me.cmbPlaza.Text = "Todas Las Plazas" Then
                    If Me.txtAlmacen.Text = "0" Or Me.txtAlmacen.Text = "" Then
                        If Me.cmbAlmacen.Text = "Todos Los Almacenes" Or Me.cmbAlmacen.SelectedIndex = Me.AlmacenCollectionClass1.Count - 1 Then
                            Me.obtenerDatosGridConPlaza()
                            Me.llenarGrid()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class