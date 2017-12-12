Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ClasesNegocio

Public Class CatAlmRegSalidaTranferencia
#Region "Miembros"
    Private Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Private WithEvents transferencia As TransferenciaAlmacenSalidaClass
    Private listaProductos As New Dictionary(Of Integer, DataRow)
    Private detalleC As DetalleColeccion
    Private seleccionar As Boolean = True
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Inicializa los controles de la ventana con lso valores por default
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Limpiar()
        Me.txtEntrega.Text = ""
        Me.txtFolio.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtRecive.Text = ""
        Me.txtTotal.Text = ""
        Me.cmbAlmacenDestino.SelectedIndex = -1
        Me.cmbAlmacenDestino.Text = "Seleccione un Almacen..."
        Me.cmbAlmacenOrigen.SelectedIndex = -1
        Me.cmbAlmacenOrigen.Text = "Seleccione un Almacen..."
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione un Almacen..."
        Me.lblEstatus.Text = "Estatus"
        Me.dgDetalles.Rows.Clear()
        Editar = False
        Me.lblEstatus.Visible = False
    End Sub

    ''' <summary>
    ''' Habilita los controles dodne el usuario capturara los datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Escritura()
        Me.cmbPlaza.Enabled = True
        Me.cmbAlmacenOrigen.Enabled = True
        Me.cmbAlmacenDestino.Enabled = True
        Me.txtEntrega.Enabled = True
        Me.txtFolio.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtRecive.Enabled = True
        Me.dgDetalles.ReadOnly = False
        Me.clmCosto.ReadOnly = True
        Me.clmImporte.ReadOnly = True
        Me.clmLote.ReadOnly = True
        Me.clmUnidad.ReadOnly = True
    End Sub

    ''' <summary>
    ''' Deshabilita los controles donde el suaurio captura los datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Lectura()
        Me.cmbPlaza.Enabled = False
        Me.cmbAlmacenOrigen.Enabled = False
        Me.cmbAlmacenDestino.Enabled = False
        Me.txtEntrega.Enabled = False
        Me.txtFolio.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtRecive.Enabled = False
        Me.txtTotal.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.dgDetalles.ReadOnly = True
        Me.lblEstatus.Visible = False
    End Sub

    ''' <summary>
    ''' Obtiene los productos registrados que se encuentran activos y enlaza el resultado a la columna
    ''' que muestra el listado de productos en el grid clmDescripcion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ObtenerProductos()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString) 'contiene la conexion a la BD

        Try
            Dim cadenaConsulta As String 'guarda la instruccion de sql para la consulta
            Dim sqlCom As SqlCommand 'comando que ejecutara la instrucion de sql
            Dim sqlDataAdapter As SqlDataAdapter 'adapatador para obtener los datos de la consulta
            Dim listaProductos As New DataTable 'tabla donde se guardara el resultado de la consulta

            'se crea la instruccion de sql con la que se realizara la consulta
            cadenaConsulta = "SELECT	 MCatCompProductos.PdIdProducto, " & _
                             "           MCatCompProductos.PdDescripcion, " & _
                             "           MCatCompProductos.PdSeManejaPorLotes, " & _
                             "           MCatCompUnidadMedida.UMDescCorta, " & _
                             "           MCatCompProductos.PdSeAplicaIva " & _
                             "FROM       MCatCompProductos INNER JOIN " & _
                             "           MCatCompUnidadMedida ON MCatCompProductos.PdIdUnidadMedida = " & _
                             "           MCatCompUnidadMedida.UMIdUnidadMedida INNER JOIN " & _
                             "           MInvAlmacen ON MCatCompProductos.PdIdProducto = MInvAlmacen.ProductoId " & _
                             "WHERE      MCatCompProductos.PdEstatus = 1 And MInvAlmacen.AlmacenId = " & _
                                         CInt(Me.cmbAlmacenOrigen.SelectedValue) & _
                             "GROUP BY	 MCatCompProductos.PdIdProducto,  " & _
                             "           MCatCompProductos.PdDescripcion, " & _
                             "           MCatCompUnidadMedida.UMDescCorta, " & _
                             "           MCatCompProductos.PdSeManejaPorLotes, " & _
                             "           MCatCompProductos.PdSeAplicaIva"

            'creo el comando con la instruccion de sql y le agrego la conexion de sql
            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            'creo el adapatador y le agrego el comando de consulta
            sqlDataAdapter = New SqlDataAdapter(sqlCom)

            'abro la conexion a sql
            sqlCon.Open()

            'realizo la consulta y guardo el resultado en la tabla listaProductos
            sqlDataAdapter.Fill(listaProductos)

            'relaciono el origen de datos de la columna del grid con la tabla
            'y establesco el campo a mostrar y de cual obtiene el valor
            Me.clmDescripcion.DataSource = listaProductos
            Me.clmDescripcion.DisplayMember = "PdDescripcion"
            Me.clmDescripcion.ValueMember = "PdIdProducto"
            Me.clmDescripcion.DataPropertyName = "Codigo"
            'asigno un valor por defacult por si el usuario agrega ninguno
            'me.clmDescripcion.DefaultCellStyle.DataSourceNullValue = -1
            Me.listaProductos.Clear()

            For Each row As DataRow In listaProductos.Rows
                Me.listaProductos.Add(CInt(row("PdIdProducto")), row)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    ''' <summary>
    ''' Metodo para redireccionar el evento KeyPress de los TextBox cuando se este editando
    ''' una celda del grid validando que solo ingresen numeros Enteros
    ''' </summary>
    ''' <param name="sender">Objeto que ejecuta el evento</param>
    ''' <param name="e">Valores del evento</param>
    ''' <remarks></remarks>
    Private Sub ColumnaIntegerKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Metodo que se utiliza para redireccionar el evento TextChanged
    ''' de los controles en edición del grid
    ''' </summary>
    ''' <param name="sender">Objeto que ejecuta el evento</param>
    ''' <param name="e">Valores del evento ejecutado</param>
    ''' <remarks></remarks>
    Private Sub ColumnaTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Guardo la referencia del control TextBox en edición
        'de la columna del grid para accesar a los metodos y propiedades
        'del TextBox
        Dim text As TextBox = sender

        'valido que el TextBox tenga un valor ingresado y que sea numerico
        If Not text.Text.Trim = "" AndAlso IsNumeric(text.Text) Then
            'busco cual es la columna que esta siendo editada para realizar 
            'los calculos que corresponden a cada columna
            If Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmCodigo.Index Then 'Columna clmCodigo
                Me.ObtenerProductoYCosto(text)
            ElseIf Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmCantidad.Index Then 'Columna clmCantidad
                Me.CalcularImporteCantidad(text)
            ElseIf Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmCosto.Index Then 'Columna clmCosto
                Me.CalcularImporteXCosto(text)
            ElseIf Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmLote.Index Then
                Me.ObtenerCostoXLote(text)
            End If
        ElseIf Not Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmLote.Index Then 'si el TextBox no se le a ingresado valor
            'en caso que no haya un valor ingresado en el TextBox indica que el costo o la cantidad del producto
            'que se esta editando o agregando no tiene valor por lo que al importe se le asigna valor 0
            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D.ToString("C2")
        End If

        Me.CalcularImporteTotal()
    End Sub

    ''' <summary>
    ''' Metodo que se utiliza para redireccionar el evento KeyPress de los controles TextBox 
    ''' que están en edición en el grid para validar que solo se ingresen numeros decimales
    ''' </summary>
    ''' <param name="sender">Objeto que ejecuta el evento</param>
    ''' <param name="e">Parametro con los valores del evento ejecutado</param>
    ''' <remarks></remarks>
    Private Sub ColumnaDecimalKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse _
            (e.KeyChar = "."c AndAlso sender.text.indexof("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Metodo que se utiliza para redireccionar el evento SelectedIndexChanged del control ComboBox en edicion
    ''' de un grid
    ''' </summary>
    ''' <param name="sender">Objeto que ejecuta el evento</param>
    ''' <param name="e">Valores generados en el evento</param>
    ''' <remarks></remarks>
    Private Sub ColumnaSelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'guarda la referencia del control ComboBox con el que 
            'se esta editando la columna clmDescripcion del grid
            'para poder accesar a las propiedades y metodos 
            'que un ComboBox tiene
            Dim combo As ComboBox = sender

            'valido que haya un producto seleccionado
            If combo.SelectedIndex > -1 Then
                'obtengo la fila de la tabla del origen de datos a la que el combobox
                'esta relacionada
                Dim row As DataRowView = DirectCast(combo.SelectedItem, DataRowView)
                'obtengo el valor de la fila y lo asegno a la variable utilizaLotes
                'para despues usarala para validaciones
                Dim utilizaLotes As Boolean = row("PdSeManejaPorLotes")
                'obtengo el código del producto seleccionado del combobox de la celda en edicion
                Dim codigo As Integer = combo.SelectedValue

                'valido si el producto se maneja en lotes para activar o desactivar la edición
                'de la celda lote en la fila seleccionada
                If utilizaLotes Then
                    Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = False

                    Dim lote As String

                    If IsNothing(Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).Value) Then
                        lote = ""
                    Else
                        lote = Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).Value.ToString.Trim
                    End If

                    If Not lote = "" Then
                        Dim invlote As New AlmacenGeneral.InventarioAlmacenLoteClass

                        If invlote.Obtener(codigo, Me.cmbAlmacenOrigen.SelectedValue, lote) Then
                            Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = invlote.CostoPromedio
                            'Asigno la unidad de medida que utiliza el producto en la celda que la muestra
                            Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                            Me.dgDetalles.CurrentRow.Cells(Me.clmCodigo.Index).Value = codigo
                            Me.dgDetalles.CurrentRow.ErrorText = ""
                        Else
                            Me.dgDetalles.CurrentRow.ErrorText = "El producto no esta registrado con ese lote"
                            Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = ""
                            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                            Me.dgDetalles.CurrentRow.Cells(Me.clmCodigo.Index).Value = combo.SelectedValue
                            Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
                        End If
                    Else
                        Me.dgDetalles.CurrentRow.Cells(Me.clmCodigo.Index).Value = combo.SelectedValue
                        Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                        Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                        Me.dgDetalles.CurrentRow.ErrorText = "No a ingresado un lote"
                        Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
                    End If
                Else
                    Dim inv As New AlmacenGeneral.InventarioAlmacenClass

                    If inv.Obtener(codigo, Me.cmbAlmacenOrigen.SelectedValue) Then
                        Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = inv.CostoPromedio
                        'Asigno la unidad de medida que utiliza el producto en la celda que la muestra
                        Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                        Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                        Me.dgDetalles.CurrentRow.Cells(Me.clmCodigo.Index).Value = codigo
                        Me.dgDetalles.CurrentRow.ErrorText = ""
                    Else
                        Me.dgDetalles.CurrentRow.ErrorText = "El producto no esta registrado en este alamcén"
                        Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = ""
                        'combo.SelectedIndex = -1
                        Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                        Me.dgDetalles.CurrentRow.Cells(Me.clmCodigo.Index).Value = ""
                    End If

                    Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = True
                    Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).Value = ""
                End If

                'Asigno la unidad de medida que utiliza el producto en la celda que la muestra
                Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                Me.dgDetalles.EndEdit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ''' <summary>
    ''' Metodo para redireccionar el evento LostFocus de los controles editores de una columna en el grid
    ''' </summary>
    ''' <param name="sender">Objeto que ejecuta el evento</param>
    ''' <param name="e">Valores del evento generado</param>
    ''' <remarks></remarks>
    Private Sub ColumnaLostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'guarda la referencia e el control ComboBox con el que 
        'se esta editando la columna clmDescripcion del grid
        'para poder accesar a los eventos que un ComboBox tiene
        Dim combo As ComboBox = sender

        'quito los redireccionamientos que el control podria tener 
        'a los metodos ColumnaLostFocus y ColumnaSelectedIndexChanged
        'para eviar que un control en edicion no deseado del grid 
        'se redireccione a ellos
        RemoveHandler combo.LostFocus, AddressOf ColumnaLostFocus
        RemoveHandler combo.SelectedIndexChanged, AddressOf ColumnaSelectedIndexChanged
    End Sub

    ''' <summary>
    ''' tiene los datos capturados en la ventana y los almacena
    ''' en la variable transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ObtenerDatos()
        Dim inv As New AlmacenGeneral.InventarioAlmacenClass
        Dim invLote As New AlmacenGeneral.InventarioAlmacenLoteClass

        Me.CalcularImporteTotal()

        With Me.transferencia
            .IdAlmacenDestino = Me.cmbAlmacenDestino.SelectedValue
            .FechaMovimiento = Me.dtpFecha.Value
            .Estatus = TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.EN_TRANSITO
            .IdAlmacenOrigen = Me.cmbAlmacenOrigen.SelectedValue
            .IdUsuarioAlta = Controlador.Sesion.Usrndx
            .Entrega = Me.txtEntrega.Text.Trim
            .Recibe = Me.txtRecive.Text.Trim
            .Observaciones = Me.txtObservaciones.Text.Trim

            .Detalle.Clear()

            .MovimientoAlmacen.IdAlmacen = .IdAlmacenOrigen
            .MovimientoAlmacen.FechaMovimiento = Now
            .MovimientoAlmacen.TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Traspaso
            .MovimientoAlmacen.IdUsuarioAlta = .IdUsuarioAlta
            .MovimientoAlmacen.PolizaContabilidad = 0
            .MovimientoAlmacen.Referencia = ""

            .MovimientoAlmacen.Detalle.Clear()

            For Each row As DataGridViewRow In Me.dgDetalles.Rows
                If row.Index = Me.dgDetalles.Rows.Count - 1 Then Continue For
                Dim det As New TransferenciaAlmacenSalidaDetalleClass
                Dim detMov As New AlmacenGeneral.MovimientoAlmacenDetalleClass

                det.IdProducto = row.Cells(Me.clmCodigo.Index).Value
                det.TransferenciaAlmacenSalida = Me.transferencia
                det.Lote = IIf(IsNothing(row.Cells(Me.clmLote.Index).Value), "", row.Cells(Me.clmLote.Index).Value)
                det.Cantidad = row.Cells(Me.clmCantidad.Index).Value
                det.Importe = row.Cells(Me.clmImporte.Index).Value

                If inv.ObteneryActualizarInventario(.IdAlmacenOrigen, det.IdProducto, Nothing) Then
                    If det.Producto.SeManejaPorLotes Then
                        If invLote.ObteneryActualizarInventario(.IdAlmacenOrigen, det.IdProducto, det.Lote, Nothing) Then
                            det.CostoUnitario = invLote.CostoPromedio
                            det.FechaCaducidad = invLote.FechaCaducidad
                        Else
                            Throw New Exception("El producto " & det.Producto.Descripcion & " no se encuentra en el invenrario")
                        End If
                    Else
                        det.CostoUnitario = invLote.CostoPromedio
                    End If
                Else
                    Throw New Exception("El producto " & det.Producto.Descripcion & " no se encuentra en el invenrario")
                End If

                If det.Producto.SeAplicaIva Then det.IVA = det.CostoUnitario * Controlador.ObtenerIVA Else det.IVA = 0D

                detMov.MovimientoAlmacen = .MovimientoAlmacen
                detMov.Cantidad = det.Cantidad
                detMov.Costo = det.CostoUnitario
                detMov.Descuento = 0D
                detMov.FechaMovimiento = Now
                detMov.IdProducto = det.IdProducto
                detMov.Lote = det.Lote
                detMov.Indice = .MovimientoAlmacen.Detalle.Count + 1
                detMov.FechaCaducidad = det.FechaCaducidad

                .Detalle.Add(det)
                .MovimientoAlmacen.Detalle.Add(detMov)
            Next
        End With
    End Sub

    Private Sub CalcularImporteTotal()
        Dim productosAgregados As New Dictionary(Of Integer, Boolean)
        Dim numProductos As Integer = 0
        Dim sumImporte As Decimal = 0D
        Dim importe As Decimal = 0D
        Dim sumIva As Decimal = 0D
        Dim iva As Decimal = 0D
        Dim producto As New ProductoClass

        For Each row As DataGridViewRow In Me.dgDetalles.Rows
            If row.Index = Me.dgDetalles.Rows.Count - 1 Then Continue For

            If row.Cells(Me.clmCodigo.Index).Value Is Nothing OrElse _
                row.Cells(Me.clmCodigo.Index).Value.ToString.Trim = "" Then
                Continue For
            End If

            producto.Obtener(row.Cells(Me.clmCodigo.Index).Value)

            If Not productosAgregados.ContainsKey(row.Cells(Me.clmCodigo.Index).Value) Then
                numProductos += 1
            End If

            importe = CDec(row.Cells(Me.clmImporte.Index).Value)
            sumImporte += CDec(row.Cells(Me.clmImporte.Index).Value)
            If producto.SeAplicaIva Then iva = importe * Controlador.ObtenerIVA Else iva = 0D
            sumIva += iva
        Next

        Me.txtTotal.Text = sumImporte.ToString("C2")
        Me.transferencia.Importe = sumImporte
        Me.transferencia.TotalProductos = numProductos
        Me.transferencia.Iva = sumIva
        Me.transferencia.Total = Me.transferencia.Importe + Me.transferencia.Iva
    End Sub

    Private Sub Ponerdatos()
        Me.txtFolio.Text = transferencia.FolioTransferencia
        Me.dtpFecha.Value = transferencia.FechaMovimiento
        Me.cmbAlmacenOrigen.SelectedValue = transferencia.IdAlmacenOrigen
        Me.cmbAlmacenDestino.SelectedValue = transferencia.IdAlmacenDestino
        Me.txtEntrega.Text = Me.transferencia.Entrega
        Me.txtRecive.Text = Me.transferencia.Recibe
        Me.txtObservaciones.Text = Me.transferencia.Observaciones
        Me.lblEstatus.Text = Me.transferencia.Estatus.ToString.Replace("_", " ")
        Me.lblEstatus.Visible = True

        Me.dgDetalles.Rows.Clear()
        Me.dgDetalles.Rows.Add(Me.transferencia.Detalle.Count)
        Dim fila As Integer = 0

        For Each det As TransferenciaAlmacenSalidaDetalleClass In Me.transferencia.Detalle
            With Me.dgDetalles.Rows(fila)
                .Cells(Me.clmCodigo.Index).Value = det.IdProducto
                .Cells(Me.clmDescripcion.Index).Value = det.IdProducto
                .Cells(Me.clmLote.Index).Value = det.Lote
                .Cells(Me.clmCantidad.Index).Value = det.Cantidad
                .Cells(Me.clmUnidad.Index).Value = det.Producto.UnidadMedida.DescCorta
                .Cells(Me.clmCosto.Index).Value = det.CostoUnitario
                .Cells(Me.clmImporte.Index).Value = det.Importe
            End With

            fila += 1
        Next
    End Sub

    Private Sub CalcularImporteCantidad(ByVal text As TextBox)
        'valido si el valor de la celda que contiene la cantidad de producto
        'tiene un valor numerico
        If IsNumeric(Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value) Then
            'obtengo la cantidad de producto que se le dara salida, el costo y calculo el importe
            Dim Cantidad As Decimal = CDec(text.Text)
            Dim costo As Decimal = CDec(Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value)
            Dim importe As Decimal = costo * Cantidad

            'asigno el importe a la celda que co
            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = importe.ToString("C2")
        Else
            'en caso que no haya una cantidad ingresada se le asigna el valor de 0
            'a la celda de importe
            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D.ToString("C2")
        End If
    End Sub

    Private Sub CalcularImporteXCosto(ByVal text As TextBox)
        'valido si el valor de la celda que contiene la cantidad de producto
        'tiene un valor numerico
        If IsNumeric(Me.dgDetalles.CurrentRow.Cells(Me.clmCantidad.Index).Value) Then
            'obtengo la cantidad de producto que se le dara salida, el costo y calculo el importe
            Dim costo As Decimal = CDec(text.Text)
            Dim cantidad As Decimal = CDec(Me.dgDetalles.CurrentRow.Cells(Me.clmCantidad.Index).Value)
            Dim importe As Decimal = costo * cantidad

            'asigno el importe a la celda que co
            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = importe.ToString("C2")
        Else
            'en caso que no haya una cantidad ingresada se le asigna el valor de 0
            'a la celda de importe
            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D.ToString("C2")
        End If
    End Sub

    Private Sub ObtenerProductoYCosto(ByVal text As TextBox)
        'obtengo el código de producto ingresado
        Dim codigo As Integer = CInt(text.Text)

        'le asigno el valor del código de producto ingresado a la celda
        'que contiene el ComboBox con el listado de productos 
        'para que se refresque a como se vaya escribiendo el código
        Me.dgDetalles.CurrentRow.Cells(Me.clmDescripcion.Index).Value = codigo

        'obtener el costo actual del producto
        If Me.listaProductos.ContainsKey(codigo) Then
            Dim row As DataRow = Me.listaProductos(codigo)

            If row("PdSeManejaPorLotes") Then
                Dim lote As String

                If IsNothing(Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).Value) Then
                    lote = ""
                Else
                    lote = Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).Value.ToString.Trim
                End If


                If Not lote = "" Then
                    Dim invlote As New AlmacenGeneral.InventarioAlmacenLoteClass

                    If invlote.Obtener(codigo, Me.cmbAlmacenOrigen.SelectedValue, lote) Then
                        Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = invlote.CostoPromedio
                        'Asigno la unidad de medida que utiliza el producto en la celda que la muestra
                        Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                        Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = _
                            CDec(Me.dgDetalles.CurrentRow.Cells(Me.clmCantidad.Index).Value) * _
                            invlote.CostoPromedio
                        Me.dgDetalles.CurrentRow.ErrorText = ""
                    Else
                        'Me.dgDetalles.CurrentRow.Cells(Me.clmDescripcion.Index).Value = -1
                        'Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = ""
                        Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                        Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
                        Me.dgDetalles.CurrentRow.ErrorText = "El producto no se encuentra en el lote especificado"
                    End If
                Else
                    Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
                    Me.dgDetalles.CurrentRow.ErrorText = "No a especificado un lote"
                    Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                    Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                End If

                Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = False
            Else
                Dim inv As New AlmacenGeneral.InventarioAlmacenClass

                If inv.Obtener(codigo, Me.cmbAlmacenOrigen.SelectedValue) Then
                    Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = inv.CostoPromedio
                    'Asigno la unidad de medida que utiliza el producto en la celda que la muestra
                    Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                    Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = _
                        CDec(Me.dgDetalles.CurrentRow.Cells(Me.clmCantidad.Index).Value) * _
                        inv.CostoPromedio
                    Me.dgDetalles.CurrentRow.ErrorText = ""
                Else
                    Me.dgDetalles.CurrentRow.ErrorText = "El producto no esta registrado en este alamcén"
                    Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = ""
                    Me.dgDetalles.CurrentRow.Cells(Me.clmDescripcion.Index).Value = -1
                    Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
                    Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
                End If

                Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = True
                Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).Value = ""
            End If
        Else
            Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = ""
            Me.dgDetalles.CurrentRow.Cells(Me.clmDescripcion.Index).Value = -1
            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
            Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
            Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).ReadOnly = True
            Me.dgDetalles.CurrentRow.Cells(Me.clmLote.Index).Value = ""
        End If
    End Sub

    Private Sub ObtenerCostoXLote(ByVal text As TextBox)
        Dim lote As String
        'obtengo el código de producto ingresado
        Dim codigo As Integer = Me.dgDetalles.CurrentRow.Cells(Me.clmCodigo.Index).Value
        Dim row As DataRow = Me.listaProductos(codigo)

        lote = text.Text.Trim

        If Not lote = "" Then
            Dim invlote As New AlmacenGeneral.InventarioAlmacenLoteClass

            If invlote.Obtener(Me.cmbAlmacenOrigen.SelectedValue, codigo, lote) Then
                Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = invlote.CostoPromedio
                'Asigno la unidad de medida que utiliza el producto en la celda que la muestra
                Me.dgDetalles.CurrentRow.Cells(Me.clmUnidad.Index).Value = row("UMDescCorta")
                Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = _
                            CDec(Me.dgDetalles.CurrentRow.Cells(Me.clmCantidad.Index).Value) * _
                            invlote.CostoPromedio
                Me.dgDetalles.CurrentRow.ErrorText = ""
            Else
                Me.dgDetalles.CurrentRow.ErrorText = "El lote no existe"
                Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
                Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
            End If
        Else
            Me.dgDetalles.CurrentRow.ErrorText = "Debe ingresar un lote"
            Me.dgDetalles.CurrentRow.Cells(Me.clmCosto.Index).Value = 0D
            Me.dgDetalles.CurrentRow.Cells(Me.clmImporte.Index).Value = 0D
        End If
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub CatAlmRegSalidaTranferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.AlmacenOrigenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Lectura()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Me.transferencia.Estatus = TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.RECIBIDA Then
                MsgBox("No se puede cancelar una transferencia que ya esta recibida", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            ElseIf Me.transferencia.Estatus = TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.CANCELADA Then
                MsgBox("La transferencia no se puede cancelar por que ya esta cancelada", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            Else
                If MessageBox.Show("¿Quiere cancelar la salida por transferencia?", _
                        "Cancelar Transferencia", MessageBoxButtons.YesNo, _
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = _
                        Windows.Forms.DialogResult.No Then
                    Cancelar = True
                    Exit Sub
                End If
            End If

            Me.transferencia.IdUsuarioCancelacion = Controlador.Sesion.Usrndx
            Me.transferencia.FechaCancelacion = Now

            If Me.transferencia.Borrar Then
                Limpiar()
                Me.Lectura()
                MsgBox("Se a cancelado la transfrencia", MsgBoxStyle.Information, "Aviso")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Dim ventana As New frmBusquedaTransferenciaAlmacenSalida

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.transferencia = ventana.TransferenciaSeleccionada
                Me.Ponerdatos()
                Me.CalcularImporteTotal()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Lectura()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'Dim a As ClasesNegocio.TransferenciaAlmacen

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Me.ObtenerDatos()

            If Me.transferencia.Guardar Then
                Me.transferencia.Imprimir(Controlador.Sesion.MiEmpresa.Empnom)
                Me.Limpiar()
                Me.Lectura()
                MsgBox("La transferencia se realizo con exito", MsgBoxStyle.Information, "Aviso")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Cursor = Cursors.WaitCursor

            Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.transferencia = New TransferenciaAlmacenSalidaClass
            Escritura()
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "TextBox"
    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtFolio.Text = "" Then
                MsgBox("Ingrese el Folio...", MsgBoxStyle.Information, "Aviso")
            Else
                Me.dtpFecha.Focus()
            End If
        End If
    End Sub

    Private Sub txtEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrega.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtEntrega.Text = "" Then
                MsgBox("Ingrese quien Entrega...", MsgBoxStyle.Information, "Aviso")
            Else
                Me.txtRecive.Focus()
            End If
        End If
    End Sub

    Private Sub txtRecive_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecive.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtRecive.Text = "" Then
                MsgBox("Ingrese quien recive...", MsgBoxStyle.Information, "Aviso")
            Else
                Me.txtObservaciones.Focus()
            End If
        End If
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmbAlmacenOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacenOrigen.SelectedIndexChanged
        Try
            If Me.cmbAlmacenOrigen.SelectedIndex > -1 Then
                Me.AlmacenDestinoC.Obtener(Not HC.AlmacenFields.AlmacenId = Me.cmbAlmacenOrigen.SelectedValue And _
                                            HC.AlmacenFields.Estatus = 1)
                Me.cmbAlmacenDestino.SelectedIndex = -1
                Me.cmbAlmacenDestino.Text = "Seleccione un almacén..."
                ObtenerProductos()
            Else
                Me.AlmacenDestinoC.Clear()
                Me.cmbAlmacenDestino.SelectedIndex = -1
                Me.cmbAlmacenDestino.Text = "Seleccione un almacén..."
                Me.clmDescripcion.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbPlaza.SelectedIndex = -1
                Me.cmbPlaza.Text = "Seleccione una plaza"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbAlmacenOrigen_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbAlmacenOrigen.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.AlmacenDestinoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbAlmacenOrigen.SelectedIndex = -1
                Me.cmbAlmacenOrigen.Text = "Seleccione un almacén"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "DateTime"
    Private Sub dtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbAlmacenOrigen.Focus()
        End If
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgDetalles_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDetalles.DataError

    End Sub

    Private Sub dgDetalles_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgDetalles.EditingControlShowing
        Try
            Dim combo As ComboBox = Nothing

            RemoveHandler e.Control.KeyPress, AddressOf ColumnaIntegerKeyPress
            RemoveHandler e.Control.KeyPress, AddressOf ColumnaDecimalKeyPress
            RemoveHandler e.Control.LostFocus, AddressOf ColumnaLostFocus
            RemoveHandler e.Control.TextChanged, AddressOf ColumnaTextChanged

            If e.Control.GetType.ToString = "System.Windows.Forms.DataGridViewComboBoxEditingControl" Then
                combo = e.Control
                RemoveHandler combo.SelectedIndexChanged, AddressOf ColumnaSelectedIndexChanged
            End If

            If Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmCodigo.Index Then
                AddHandler e.Control.KeyPress, AddressOf ColumnaIntegerKeyPress
                AddHandler e.Control.TextChanged, AddressOf ColumnaTextChanged
            ElseIf Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmCantidad.Index OrElse _
                    Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmCosto.Index Then
                AddHandler e.Control.KeyPress, AddressOf ColumnaDecimalKeyPress
                AddHandler e.Control.TextChanged, AddressOf ColumnaTextChanged
            ElseIf Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmDescripcion.Index Then
                AddHandler combo.SelectedIndexChanged, AddressOf ColumnaSelectedIndexChanged
                AddHandler e.Control.LostFocus, AddressOf ColumnaLostFocus
            ElseIf Me.dgDetalles.CurrentCell.ColumnIndex = Me.clmLote.Index Then
                AddHandler e.Control.TextChanged, AddressOf ColumnaTextChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgDetalles_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgDetalles.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            If Me.dgDetalles.ReadOnly Then Exit Sub

            'Dim ventana As New SistemaAgrosCS.Catalogos.Generales.ListaProdRegfrm

            'If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    If ventana.ProductosSeleccionados.Count > 0 Then
            '        Dim codigoProducto As Integer = ventana.ProductosSeleccionados(0).Codigo

            '        If Me.dgDetalles.CurrentRow.Index = Me.dgDetalles.Rows.Count - 1 Then
            '            Me.dgDetalles.Rows.Add(1)

            '            Dim row As DataGridViewRow = Me.dgDetalles.Rows(Me.dgDetalles.Rows.Count - 2)

            '            row.Cells(Me.clmCodigo.Index).Value = codigoProducto
            '            row.Cells(Me.clmDescripcion.Index).Value = codigoProducto
            '        End If
            '    End If
            'End If
        ElseIf e.KeyCode = Keys.Delete Then
            If Not Me.dgDetalles.CurrentRow.Index = Me.dgDetalles.Rows.Count - 1 Then
                If MessageBox.Show("¿Quiere quitar el producto de la transferencia", "Quitar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Me.dgDetalles.Rows.Remove(Me.dgDetalles.CurrentRow)
                End If
            End If
        End If
    End Sub

    Private Sub dgDetalles_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDetalles.SelectionChanged
        If Not Me.seleccionar Then Exit Sub

        For Each row As DataGridViewRow In Me.dgDetalles.Rows
            If row.Index = Me.dgDetalles.Rows.Count - 1 Then Continue For

            If Not row.ErrorText.Trim = "" OrElse Not IsNumeric(row.Cells(Me.clmCantidad.Index).Value) OrElse _
                    Not CDec(row.Cells(Me.clmCantidad.Index).Value) > 0D Then
                Me.seleccionar = False
                row.Cells(Me.dgDetalles.CurrentCell.ColumnIndex).Selected = True
                Me.seleccionar = True
                Exit Sub
            End If
        Next
    End Sub
#End Region
#End Region

#Region "Estructuras"
    Private Structure Detalle

        Private m_codigo As Integer
        Public Property Codigo() As Integer
            Get
                Return m_codigo
            End Get
            Set(ByVal value As Integer)
                m_codigo = value
            End Set
        End Property


        Private m_Lote As String
        Public Property Lote() As String
            Get
                Return m_Lote
            End Get
            Set(ByVal value As String)
                m_Lote = value
            End Set
        End Property


        Private m_Cantidad As Decimal
        Public Property Cantidad() As Decimal
            Get
                Return m_Cantidad
            End Get
            Set(ByVal value As Decimal)
                m_Cantidad = value
            End Set
        End Property


        Private m_UnidadMedida As String
        Public Property UnidadMedida() As String
            Get
                Return m_UnidadMedida
            End Get
            Set(ByVal value As String)
                m_UnidadMedida = value
            End Set
        End Property


        Private m_Costo As Decimal
        Public Property Costo() As Decimal
            Get
                Return m_Costo
            End Get
            Set(ByVal value As Decimal)
                m_Costo = value
            End Set
        End Property


        Private m_Importe As Decimal
        Public Property Importe() As Decimal
            Get
                Return m_Importe
            End Get
            Set(ByVal value As Decimal)
                m_Importe = value
            End Set
        End Property
    End Structure
#End Region

#Region "Colecciones"
    Private Class DetalleColeccion
        Inherits ColleccionBase(Of Detalle)

    End Class
#End Region
End Class