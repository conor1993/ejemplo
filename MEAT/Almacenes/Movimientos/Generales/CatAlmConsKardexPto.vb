Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ClasesNegocio

Public Class CatAlmConsKardexPto

    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Dim Mes As New ClasesNegocio.MesesClass
    Private mcproducto As ProductoClass
    Private Comando As New SqlClient.SqlCommand("ConsultarProductosXClave", New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString))
    Private seleccionar As Boolean = False
    Private dt As DataTable
    Dim codigoProducto As Integer
    Private listaDatos As New Dictionary(Of Integer, DataRow)
    Dim tablaDatos As DataTable
    Private datosGrid As New DataTable
    Dim movimiento As New MovimientoAlmacenClass
    Dim datoExistenciaInicial As DataTable
    Dim seleccionado As Boolean = False

#Region "KeyPress"
    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPlaza.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            Me.cmbSucursal.Focus()
            If CmbPlaza.Text = "" Then
                MsgBox("Seleccione una Plaza")
                CmbPlaza.Focus()
            End If
        End If
    End Sub

    Private Sub cmbSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSucursal.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            cmbAlmacen.Focus()
            If Me.cmbSucursal.Text = "" Then
                MsgBox("Seleccione una Sucursal")
                CmbPlaza.Focus()
            End If
        End If
    End Sub

    Private Sub cmbAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPlaza.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbProducto.Focus()
            If cmbAlmacen.Text = "" Then
                MsgBox("Seleccione un almacen")
                CmbPlaza.Focus()
            End If
        End If
    End Sub

    Private Sub CmbProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProducto.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLinea.Focus()
            If CmbProducto.Text = "" Then
                MsgBox("Seleccione una Producto")
                CmbProducto.Focus()
            End If
        End If
    End Sub

    Private Sub TxtLinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLinea.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtUnidad.Focus()
            If TxtLinea.Text = "" Then
                MsgBox("Agregue Información a Linea ")
                TxtLinea.Focus()
            End If
        End If
    End Sub

    Private Sub TxtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUnidad.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbSublinea.Focus()
            If TxtUnidad.Text = "" Then
                MsgBox("Agregue Información a Unidad ")
                TxtUnidad.Focus()
            End If
        End If
    End Sub

    Private Sub CmbSublinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSublinea.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            dtpInicial.Focus()
            If CmbSublinea.Text = "" Then
                MsgBox("Seleccione una Linea")
                CmbSublinea.Focus()
            End If
        End If
    End Sub

    Private Sub dtpInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpInicial.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            dtpFinal.Focus()
            If Me.dtpInicial.Value < Me.dtpFinal.Value Then
                Me.llenarGrid()
            Else
                MsgBox("Fecha Final debe ser mayor que Fecha Inicial", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub TxtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCostoInicial.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtExisInicial.Focus()
            If TxtCostoInicial.Text = "" Then
                MsgBox("Agregue Información a Costo Inicial ")
                TxtCostoInicial.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtCostoInicial.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtCostoInicial.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtCostoInicial.Text.Length - Me.TxtCostoInicial.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtCostoInicial.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtExisInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtExisInicial.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtEntrada.Focus()
            If TxtExisInicial.Text = "" Then
                MsgBox("Agregue Información a Existencia Inicial ")
                TxtExisInicial.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtExisInicial.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtExisInicial.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtExisInicial.Text.Length - Me.TxtExisInicial.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtExisInicial.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEntrada.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtSalidas.Focus()
            If TxtEntrada.Text = "" Then
                MsgBox("Agregue Información a Total Entradas ")
                TxtEntrada.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtEntrada.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtEntrada.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtEntrada.Text.Length - Me.TxtEntrada.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtEntrada.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtSalidas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSalidas.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtExisActual.Focus()
            If TxtSalidas.Text = "" Then
                MsgBox("Agregue Información a Total Salidas ")
                TxtSalidas.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtSalidas.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtSalidas.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtSalidas.Text.Length - Me.TxtSalidas.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtSalidas.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtExisActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtExisActual.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            'TxtReferencia.Focus()
            If TxtExisActual.Text = "" Then
                MsgBox("Agregue Información a Existencia Actual ")
                TxtExisActual.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtExisActual.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtExisActual.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtExisActual.Text.Length - Me.TxtExisActual.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtExisActual.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        'Me.CmbPlaza.DataSource = Nothing
        Me.CmbPlaza.Text = ""
        'Me.cmbSucursal.DataSource = Nothing
        Me.cmbSucursal.Text = ""
        'Me.cmbAlmacen.DataSource = Nothing
        Me.cmbAlmacen.Text = ""
        Me.DataGrid.DataSource = Nothing
        TxtLinea.Clear()
        TxtUnidad.Clear()
        Me.txtProducto.Clear()
        CmbSublinea.SelectedValue = "Seleccione Plaza"
        Dim month As New DateTime(Now.Year, Now.Month - 1, Now.Day)
        Me.dtpInicial.Value = month
        dtpFinal.Value = Now
        TxtCostoInicial.Clear()
        TxtExisInicial.Clear()
        TxtEntrada.Clear()
        TxtSalidas.Clear()
        TxtExisActual.Clear()
    End Sub

    Private Sub Deshabilitar()
        CmbPlaza.Enabled = False
        CmbProducto.Enabled = False
        Me.cmbAlmacen.Enabled = False
        Me.cmbSucursal.Enabled = False
        TxtLinea.Enabled = False
        TxtUnidad.Enabled = False
        Me.txtProducto.Enabled = False
        CmbSublinea.Enabled = False
        dtpInicial.Enabled = False
        dtpFinal.Enabled = False
        'CmbMes.Enabled = False
        'DtpFecha.Enabled = False
        'CmbAño.Enabled = False
        TxtCostoInicial.Enabled = False
        TxtExisInicial.Enabled = False
        TxtEntrada.Enabled = False
        TxtSalidas.Enabled = False
        TxtExisActual.Enabled = False
        'TxtReferencia.Enabled = False
        DataGrid.Enabled = False
    End Sub

    Private Sub Habilitar()
        CmbPlaza.Enabled = True
        CmbProducto.Enabled = True
        Me.cmbSucursal.Enabled = True
        Me.cmbAlmacen.Enabled = True
        TxtLinea.Enabled = False
        TxtUnidad.Enabled = False
        Me.txtProducto.Enabled = True
        CmbSublinea.Enabled = False
        dtpInicial.Enabled = True
        dtpFinal.Enabled = True
        'CmbMes.Enabled = True
        'DtpFecha.Enabled = True
        'CmbAño.Enabled = True
        TxtCostoInicial.Enabled = False
        TxtExisInicial.Enabled = False
        TxtEntrada.Enabled = False
        TxtSalidas.Enabled = False
        TxtExisActual.Enabled = False
        'TxtReferencia.Enabled = True
        DataGrid.Enabled = True
    End Sub

    Private Sub obtenerSucursales()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString) 'contiene la conexion a la BD

        Try
            Dim cadenaConsulta As String 'guarda la instruccion de sql para la consulta
            Dim sqlCom As SqlCommand 'comando que ejecutara la instrucion de sql
            Dim sqlDataAdapter As SqlDataAdapter 'adapatador para obtener los datos de la consulta
            Dim listaDato As New DataTable 'tabla donde se guardara el resultado de la consulta

            'se crea la instruccion de sql con la que se realizara la consulta
            cadenaConsulta = "SELECT     MCatGenSucursales.SCIdSucursal, " & _
                            "            MCatGenSucursales.SCDescripcion, " & _
                            "            MCatGenPlazas.PLIdPlaza " & _
                            "FROM        MCatGenSucursales INNER JOIN " & _
                            "            MCatGenPlazas ON MCatGenSucursales.SCIdPlaza = MCatGenPlazas.PLIdPlaza " & _
                            "WHERE       MCatGenPlazas.PLIdPlaza = " & Me.CmbPlaza.SelectedValue

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)

            sqlCon.Open()
            sqlDataAdapter.Fill(listaDato)

            Me.cmbSucursal.ValueMember = "SCIdSucursal"
            Me.cmbSucursal.DataSource = listaDato
            Me.cmbSucursal.DisplayMember = "SCDescripcion"
            Me.cmbSucursal.SelectedIndex = -1
            Me.listaDatos.Clear()

            'For Each row As DataRow In listaDato.Rows
            '    Me.listaDatos.Add(CInt(row("Codigo")), row)
            'Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ObtenerAlmacen")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub ObtenerAlmacen()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString) 'contiene la conexion a la BD

        Try
            Dim cadenaConsulta As String 'guarda la instruccion de sql para la consulta
            Dim sqlCom As SqlCommand 'comando que ejecutara la instrucion de sql
            Dim sqlDataAdapter As SqlDataAdapter 'adapatador para obtener los datos de la consulta
            Dim listaDato As New DataTable 'tabla donde se guardara el resultado de la consulta
            Dim x As Integer = 0
            If Me.cmbSucursal.SelectedIndex > -1 Then
                x = Me.cmbSucursal.SelectedValue
            Else
                x = 1
            End If

            'se crea la instruccion de sql con la que se realizara la consulta
            cadenaConsulta = "SELECT     MCatAlmacenes.Codigo, MCatAlmacenes.Nombre " & _
                            "FROM        MCatAlmacenes INNER JOIN " & _
                            "MCatGenPlazas ON MCatAlmacenes.Plaza = MCatGenPlazas.PLIdPlaza INNER JOIN " & _
                            "MCatGenSucursales ON MCatGenPlazas.PLIdPlaza = MCatGenSucursales.SCIdPlaza " & _
                            "WHERE(MCatGenSucursales.SCIdSucursal = " & x & ")"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)

            sqlCon.Open()
            sqlDataAdapter.Fill(listaDato)

            Me.cmbAlmacen.ValueMember = "Codigo"
            Me.cmbAlmacen.DataSource = listaDato
            Me.cmbAlmacen.DisplayMember = "Nombre"
            Me.listaDatos.Clear()
            Me.cmbAlmacen.SelectedIndex = -1

            'For Each row As DataRow In listaDato.Rows
            '    Me.listaDatos.Add(CInt(row("Codigo")), row)
            'Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ObtenerAlmacen")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub ObtenerProductosPorAlmacen()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString) 'contiene la conexion a la BD
        Try
            Dim cadenaConsulta As String 'guarda la instruccion de sql para la consulta
            Dim sqlCom As SqlCommand 'comando que ejecutara la instrucion de sql
            Dim sqlDataAdapter As SqlDataAdapter 'adapatador para obtener los datos de la consulta
            Dim listaDato As New DataTable 'tabla donde se guardara el resultado de la consulta
            'Dim x As Integer = Me.cmbAlmacen.SelectedValue
            'se crea la instruccion de sql con la que se realizara la consulta
            Dim x As Integer = 0
            If Me.cmbAlmacen.SelectedIndex > -1 Then
                x = Me.cmbAlmacen.SelectedValue
            Else
                x = 1
            End If

            cadenaConsulta = "SELECT     MCatCompProductos.PdIdProducto, " & _
                            "            MCatCompProductos.PdDescripcion, " & _
                            "            MCatCompProductos.PdDescrpcionCorta, " & _
                            "            MCatCompProductos.PdIdSubLinea, " & _
                            "            MCatCompProductos.PdIdUnidadMedida, " & _
                            "            MCatAlmacenes.Codigo, " & _
                            "            MCatAlmacenes.Nombre " & _
                            "FROM        MCatCompProductos INNER JOIN " & _
                            "            MInvAlmacen ON MCatCompProductos.PdIdProducto = MInvAlmacen.ProductoId INNER JOIN " & _
                            "            MCatAlmacenes ON MInvAlmacen.AlmacenId = MCatAlmacenes.Codigo " & _
                            "GROUP BY MCatCompProductos.PdIdProducto, MCatCompProductos.PdDescripcion, MCatCompProductos.PdDescrpcionCorta, " & _
                            "MCatCompProductos.PdIdSubLinea, MCatCompProductos.PdIdUnidadMedida, MCatAlmacenes.Codigo, MCatAlmacenes.Nombre " & _
                            "HAVING      MCatAlmacenes.Codigo = " & x
            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)

            sqlCon.Open()
            sqlDataAdapter.Fill(listaDato)
            'sqlDataAdapter.Fill(tablaDatos)
            tablaDatos = listaDato

            Me.CmbProducto.ValueMember = "PdDescrpcionCorta"
            Me.CmbProducto.DataSource = listaDato
            Me.CmbProducto.DisplayMember = "PdDescripcion"
            Me.CmbProducto.SelectedIndex = -1
            Me.listaDatos.Clear()

            For Each row As DataRow In listaDato.Rows
                Me.listaDatos.Add(CInt(row("PdIdProducto")), row)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ObtenerProductosPorAlmacen")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerDatosParaGrid()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString) 'contiene la conexion a la BD
        Dim bol As Boolean = False
        Try
            Dim cadenaConsulta As String 'guarda la instruccion de sql para la consulta
            Dim sqlCom As SqlCommand 'comando que ejecutara la instrucion de sql
            Dim sqlDataAdapter As SqlDataAdapter 'adapatador para obtener los datos de la consulta
            Dim listaDato As New DataTable 'tabla donde se guardara el resultado de la consulta
            Dim m_inicial As String = Me.regresaMes(Me.dtpInicial.Value.Month)
            Dim m_final As String = Me.regresaMes(Me.dtpFinal.Value.Month)


            cadenaConsulta = "select    ma.FolioMovimiento, " & _
                            "           ma.fechamovimiento, " & _
                            "           Descripcion as movimiento , " & _
                            "           Case when direccion = 0 then md.cantidad else 0 end as entrada, " & _
                            "           Case when direccion = 1 then md.cantidad else 0 end as Salida, " & _
                            "           md.Costo, " & _
                            "           md.CostoPromedio, " & _
                            "           0 AS CantidadExistencia, Direccion " & _
                            "from minvmovimientosalmacen ma " & _
                            "inner join mcattipomovimiento tm " & _
                            "on tm.codigo=ma.tipomovimientoid " & _
                            "inner join minvmovimientosalmacendetalles md " & _
                            "on ma.foliomovimiento=md.foliomovimiento and ma.almacenid=md.almacenid " & _
                            "where ma.almacenid = " & Me.cmbAlmacen.SelectedValue & _
                            " And md.productoid = " & Me.mcproducto.Codigo & _
                            " and ma.fechamovimiento between '" & Me.dtpInicial.Value.Year & Me.dtpInicial.Value.Month.ToString().PadLeft(2, "0") & "01' " & _
                            " and '" & Me.dtpFinal.Value.Year & Me.dtpFinal.Value.Month.ToString.PadLeft(2, "0") & "01' " & _
                            " order by ma.fechamovimiento asc"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)

            'sqlCon.Open()
            sqlDataAdapter.Fill(listaDato)
            Me.datosGrid = listaDato

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ObtenerProductosPorAlmacen")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub obtenerExistenciaInicial()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString) 'contiene la conexion a la BD
        Dim bol As Boolean = False
        Try
            Dim cadenaConsulta As String 'guarda la instruccion de sql para la consulta
            Dim sqlCom As SqlCommand 'comando que ejecutara la instrucion de sql
            Dim sqlDataAdapter As SqlDataAdapter 'adapatador para obtener los datos de la consulta
            Dim listaDato As New DataTable 'tabla donde se guardara el resultado de la consulta
            Dim m_inicial As String = Me.regresaMes(Me.dtpInicial.Value.Month)

            cadenaConsulta = "SELECT        TOP 1 CantidadExistencia,fechaultimocosto,CostoPromedio " & _
                             "FROM          dbo.MInvAlmacen " & _
                             "WHERE         Productoid = " & Me.mcproducto.Codigo & _
                             "              AND AlmacenId = " & Me.cmbAlmacen.SelectedValue & _
                             "              AND CAST('01/' + CAST(Mes AS VARCHAR(2)) + '/' + CAST(Año AS VARCHAR(4)) AS DATETIME) " & _
                             "				<  " & String.Format("'01/{0}' ", Me.dtpInicial.Value.ToString("MM/yyyy")) & _
                             "ORDER BY      Año DESC, Mes DESC"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlDataAdapter = New SqlDataAdapter(sqlCom)

            'sqlCon.Open()
            sqlDataAdapter.Fill(listaDato)
            Me.datoExistenciaInicial = listaDato

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ObtenerProductosPorAlmacen")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Public Function regresaMes(ByVal mesNum As Integer) As String
        Dim mes As String = ""
        If mesNum = 1 Then
            mes = "Ene"
        ElseIf mesNum = 2 Then
            mes = "Feb"
        ElseIf mesNum = 3 Then
            mes = "Mar"
        ElseIf mesNum = 4 Then
            mes = "Abr"
        ElseIf mesNum = 5 Then
            mes = "May"
        ElseIf mesNum = 6 Then
            mes = "Jun"
        ElseIf mesNum = 7 Then
            mes = "Jul"
        ElseIf mesNum = 8 Then
            mes = "Ago"
        ElseIf mesNum = 9 Then
            mes = "Sep"
        ElseIf mesNum = 10 Then
            mes = "Oct"
        ElseIf mesNum = 11 Then
            mes = "Nov"
        ElseIf mesNum = 12 Then
            mes = "Dic"
        End If
        Return mes
    End Function

    Private Sub llenarGrid()
        Try
            Me.obtenerExistenciaInicial()
            Me.obtenerDatosParaGrid()
            Dim existenciaFinal As Decimal = 0D
            Dim existenciaInicial As Decimal
            Dim entradas As Decimal = 0D
            Dim salidas As Decimal = 0D
            Dim costoInicial As Decimal = 0D
            Dim costoFinal As Decimal = 0D

            If Not Me.datoExistenciaInicial.Rows.Count <= 0 Then
                existenciaInicial = CDec(Me.datoExistenciaInicial.Rows(0)("CantidadExistencia"))
                costoInicial = CDec(Me.datoExistenciaInicial.Rows(0)("CostoPromedio"))
            Else
                existenciaInicial = 0D
                costoInicial = 0D
            End If

            existenciaFinal = existenciaInicial

            For Each dr As DataRow In Me.datosGrid.Rows
                If CShort(dr("Direccion")) = 0 Then
                    existenciaFinal += CDec(dr("entrada"))
                    entradas += CDec(dr("entrada"))
                Else
                    existenciaFinal -= CDec(dr("salida"))
                    salidas += CDec(dr("salida"))
                End If

                dr("CantidadExistencia") = existenciaFinal
            Next

            Me.DataGrid.AutoGenerateColumns = False
            Me.DataGrid.DataSource = Me.datosGrid

            'Limpia Campos
            Me.TxtCostoInicial.Text = ""
            Me.TxtExisInicial.Text = ""
            Me.TxtEntrada.Text = ""
            Me.TxtSalidas.Text = ""
            Me.TxtExisActual.Text = ""

            Me.TxtCostoInicial.Text = costoInicial
            Me.TxtExisInicial.Text = existenciaInicial
            Me.TxtEntrada.Text = entradas
            Me.TxtSalidas.Text = salidas
            Me.TxtExisActual.Text = existenciaFinal
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error llenarGrid")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Me.selesccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Editar = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub CatAlmConsKardexPto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010011"
        MtbEstados.StateGuardar = "110100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = "00010001"
        MtbEstados.StateSalir = ""

        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        Deshabilitar()
        Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        CmbPlaza.SelectedIndex = -1
        Me.CmbPlaza.SelectedText = "Seleccione una plaza..."
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbSucursal.SelectedText = "Seleccione una sucursal..."
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbSucursal.Enabled = False
        Me.cmbAlmacen.SelectedText = "Seleccione un almacen..."
        Me.cmbAlmacen.Enabled = False
        Me.CmbProducto.SelectedIndex = -1
        Me.CmbProducto.SelectedText = "Seleccione un producto..."
        'Me.CmbProducto.SelectedValue = "Seleccione un producto..."
        Me.CmbProducto.Enabled = False
        Me.txtProducto.Enabled = False
    End Sub

    Private Sub CmbProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProducto.SelectedIndexChanged
        If Me.seleccionado Then Exit Sub

        Try
            If Not Me.CmbProducto.SelectedIndex < 0 Then
                Me.txtProducto.Text = Me.CmbProducto.SelectedValue
                Me.codigoProducto = tablaDatos.Rows(Me.CmbProducto.SelectedIndex)("PdIdProducto")
                mcproducto = New ProductoClass(Me.codigoProducto)
                Me.TxtLinea.Text = mcproducto.Linea.Descripcion
                Me.CmbSublinea.Text = mcproducto.Linea.Descripcion
                Me.TxtUnidad.Text = mcproducto.UnidadMedida.Descripcion
                Me.txtProducto.Text = mcproducto.DescCorta

                If Me.dtpInicial.Value < Me.dtpFinal.Value Then
                    Me.llenarGrid()
                Else
                    MsgBox("Fecha Final debe ser mayor que Fecha Inicial", MsgBoxStyle.Information)
                End If
            Else
                Me.TxtLinea.Text = ""
                Me.CmbSublinea.Text = ""
                Me.TxtUnidad.Text = ""
                Me.txtProducto.Text = ""
                Me.DataGrid.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error CmbProducto_SelectedIndexChanged")
        End Try
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        If Me.seleccionado Then Exit Sub

        Try
            If Me.cmbAlmacen.SelectedIndex > -1 Then
                Me.seleccionado = True
                Me.ObtenerProductosPorAlmacen()
                Me.seleccionado = False
            Else
                Me.CmbProducto.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPlaza.SelectedIndexChanged
        Try
            If Me.CmbPlaza.SelectedIndex > -1 Then
                Me.seleccionado = True
                Me.obtenerSucursales()
                Me.seleccionado = False
            Else
                Me.cmbSucursal.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        End Try
    End Sub

    Private Sub txtProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProducto.TextChanged
        Try
            If Not Me.txtProducto.Text = "" Then
                'If Not Me.txtProducto.Text Is Nothing Then
                Me.CmbProducto.SelectedValue = Me.txtProducto.Text
                'End If
            Else
                Me.CmbProducto.SelectedValue = Me.txtProducto.Text
                Me.TxtLinea.Clear()
                Me.CmbSublinea.Text = ""
                Me.TxtUnidad.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        End Try
    End Sub

    Private Sub CmbProducto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbProducto.TextChanged
        If Me.CmbProducto.Text = "" Then
            Me.TxtLinea.Clear()
            Me.CmbSublinea.Text = ""
            Me.TxtUnidad.Clear()
            Me.txtProducto.Clear()
        End If
    End Sub

    Private Sub dtpFinal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFinal.TextChanged
        If Me.dtpInicial.Value < Me.dtpFinal.Value Then
            Me.llenarGrid()
            'Me.CalculaCampos()
        Else
            MsgBox("Fecha Final debe ser mayor que Fecha Inicial", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectedIndexChanged
        If Me.seleccionado Then Exit Sub

        Try
            If Me.cmbSucursal.SelectedIndex > -1 Then
                Me.seleccionado = True
                Me.ObtenerAlmacen()
                Me.seleccionado = False
            Else
                Me.cmbAlmacen.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Try
            Me.Imprimir()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error mtb_ClickImprimir")
        End Try
    End Sub

    Public Sub Imprimir()
        Try
            'Dim mov As New MovimientoAlmacenClass
            'Dim invAlm As New InventarioAlmacenClass
            'Dim vfmvto As New ArrayList
            'Dim vfemvto As New ArrayList
            'Dim vmvto As New ArrayList
            'Dim ventrada As New ArrayList
            'Dim vsalidas As New ArrayList
            'Dim vexistencia As New ArrayList
            'Dim vcosto As New ArrayList
            'Dim vcp As New ArrayList

            'Me.ObtenerDatos(mov, vfmvto, vfemvto, vmvto, ventrada, vsalidas, vexistencia, vcosto, vcp)

            ''Dim invAlm As New InventarioAlmacenClass

            'Dim kardexImprimir As New MovimientoAlmacenCollectionClass

            'kardexImprimir.Add(mov)
            'kardexImprimir.imprimirKardex(mov, SesionActual.MiEmpresa.Empnom, CDec(Me.TxtCosto.Text), CDec(Me.TxtExisInicial.Text), _
            '                                CDec(Me.TxtEntrada.Text), CDec(Me.TxtSalidas.Text), CDec(Me.TxtExisActual.Text), SesionActual.MiUsuario.Usrnomcom, _
            '                                "Almacen/Consultas/Consulta de kardex", Me.dtpInicial.Value, Me.dtpFinal.Value, Me.CmbPlaza.Text, _
            '                                Me.cmbSucursal.Text, Me.cmbAlmacen.Text, Me.CmbProducto.Text, Me.TxtUnidad.Text, Me.TxtLinea.Text, _
            '                                Me.CmbSublinea.Text, vfmvto, vfemvto, vmvto, ventrada, vsalidas, vexistencia, vcosto, vcp)
            ClasesNegocio.AlmacenGeneral.MovimientoAlmacenCollectionClass.ImprimirKardex(Controlador.Sesion.MiEmpresa.Empnom, CDec(Me.TxtCostoInicial.Text), _
                                            CDec(Me.TxtExisInicial.Text), CDec(Me.TxtEntrada.Text), CDec(Me.TxtSalidas.Text), _
                                            CDec(Me.TxtExisActual.Text), Controlador.Sesion.MiUsuario.Usrnomcom, _
                                            "Almacen/Consultas/Consulta de kardex", Me.dtpInicial.Value, Me.dtpFinal.Value, Me.CmbPlaza.Text, _
                                            Me.cmbSucursal.Text, Me.cmbAlmacen.Text, Me.CmbProducto.Text, Me.TxtUnidad.Text, Me.TxtLinea.Text, _
                                            Me.CmbSublinea.Text, Me.DataGrid.DataSource)
            Me.Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Imprimir")
        End Try
    End Sub

    Private Sub ObtenerDatos(ByVal mov As AlmacenGeneral.MovimientoAlmacenClass, ByVal vfmvto As ArrayList, ByVal vfemvto As ArrayList, _
                            ByVal vmvto As ArrayList, ByVal ventrada As ArrayList, ByVal vsalidas As ArrayList, _
                            ByVal vexistencia As ArrayList, ByVal vcosto As ArrayList, ByVal vcp As ArrayList)
        With mov
            .Contabilizado = AlmacenGeneral.MovimientoAlmacenClass.MovimientoAlmacenEstatus.VIGENTE
            .Almacen.Descripcion = Me.cmbAlmacen.Text
            .Almacen.Plaza.Codigo = CInt(Me.CmbPlaza.SelectedValue)
            .Almacen.Plaza.Descripcion = Me.CmbPlaza.Text
        End With

        For Each row As DataGridViewRow In Me.DataGrid.Rows
            If row.Index = Me.DataGrid.Rows.Count - 1 Then Continue For
            mov.Detalle.Add(mov, row.Index + 1, Me.mcproducto.Codigo, row.Cells(Me.FechaColumn.Index).Value, _
                            row.Cells(Me.ExistenciaColumn.Index).Value, row.Cells(Me.CostoColumn.Index).Value, _
                            0D, "", New Nullable(Of Date))
            vfmvto.Add(row.Cells(Me.FolioColumn.Index).Value)
            vfemvto.Add(row.Cells(Me.FechaColumn.Index).Value)
            vmvto.Add(row.Cells(Me.MovtoColumn.Index).Value)
            ventrada.Add(row.Cells(Me.EntradaColumn.Index).Value)
            vsalidas.Add(row.Cells(Me.SalidaColumn.Index).Value)
            vexistencia.Add(row.Cells(Me.ExistenciaColumn.Index).Value)
            vcosto.Add(row.Cells(Me.CostoColumn.Index).Value)
            vcp.Add(row.Cells(Me.CostopColumn.Index).Value)
        Next
    End Sub

End Class