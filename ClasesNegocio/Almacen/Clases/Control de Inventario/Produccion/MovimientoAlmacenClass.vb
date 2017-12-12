Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class MovimientoAlmacenClass
    Inherits ClassBase(Of EC.MscmovtosAlmacenCabEntity)

#Region "Miembros"
    Dim m_almacen As AlmacenClass
    Dim m_TipoMovimiento As TipoMovimientoAlmacenClass
    Dim m_Detalle As MovimientoAlmacenDetalleCollectionClass
#End Region

#Region "Construsctores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.MscmovtosAlmacenCabEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal folioMovimiento As String)
        MyBase.New(New EC.MscmovtosAlmacenCabEntity(folioMovimiento))
    End Sub
#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("Folio Movimeinto"), ComponentModel.DataObjectField(True, False, False, 12)> _
    Public Property FolioMovimiento() As String
        Get
            Return Entity.IdFolioMovimiento
        End Get
        Private Set(ByVal value As String)
            Entity.IdFolioMovimiento = value
        End Set
    End Property

    <ComponentModel.DisplayName("Código Almacén"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property IdAlmacen() As Integer
        Get
            Return Entity.IdCodAlmacen
        End Get
        Set(ByVal value As Integer)
            Entity.IdCodAlmacen = value
        End Set
    End Property

    <ComponentModel.DisplayName("Almacén"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property Almacen() As AlmacenClass
        Get
            If m_almacen Is Nothing Then
                m_almacen = New AlmacenClass(Entity.Almacen)
            ElseIf Not m_almacen.Codigo = IdAlmacen Then
                m_almacen.LeerEntidad(Entity.Almacen)
            End If

            Return m_almacen
        End Get
        Set(ByVal value As AlmacenClass)
            m_almacen = value

            If value Is Nothing Then
                Entity.Almacen = Nothing
            Else
                Entity.Almacen = value.ObtenerEntidad
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha Movimieto"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property FechaMovimiento() As Date
        Get
            Return Entity.FechaMovimiento
        End Get
        Set(ByVal value As Date)
            Entity.FechaMovimiento = value
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha Captura"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    <ComponentModel.DisplayName("Código Tipo Movimiento"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property IdTipoMovimiento() As Integer
        Get
            Return Entity.IdCodMovimiento
        End Get
        Set(ByVal value As Integer)
            Entity.IdCodMovimiento = value
        End Set
    End Property

    <ComponentModel.DisplayName("Tipo Movimiento"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property TipoMovimiento() As TipoMovimientoAlmacenClass
        Get
            If m_TipoMovimiento Is Nothing Then
                m_TipoMovimiento = New TipoMovimientoAlmacenClass(Entity.TipoMovimientoAlmacen)
            ElseIf Not m_TipoMovimiento.Codigo = IdTipoMovimiento Then
                m_TipoMovimiento.LeerEntidad(Entity.TipoMovimientoAlmacen)
            End If

            Return m_TipoMovimiento
        End Get
        Set(ByVal value As TipoMovimientoAlmacenClass)
            m_TipoMovimiento = value

            If value Is Nothing Then
                Entity.TipoMovimientoAlmacen = Nothing
            Else
                Entity.TipoMovimientoAlmacen = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property Piezas() As Integer
        Get
            Return Entity.CantPzas
        End Get
        Set(ByVal value As Integer)
            Entity.CantPzas = value
        End Set
    End Property

    Public Property Kilos() As Decimal
        Get
            Return Entity.CantKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.CantKilos = value
        End Set
    End Property

    Public Property Contabilizado() As SiNoCharEnum
        Get
            Return Asc(Entity.Contabilizado)
        End Get
        Set(ByVal value As SiNoCharEnum)
            Entity.Contabilizado = Chr(value)
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha Contabilización")> _
    Public Property FechaContabilizacion() As Date
        Get
            Return Entity.FechaContabilizacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaContabilizacion = value
        End Set
    End Property

    <ComponentModel.DisplayName("Código Poliza")> _
    Public Property IdPoliza() As String
        Get
            Return Entity.IdPoliza
        End Get
        Set(ByVal value As String)
            Entity.IdPoliza = value
        End Set
    End Property

    <ComponentModel.DisplayName("Quien Contabilizo"), ComponentModel.DataObjectField(False, False, False, 50)> _
    Public Property QuienContabilizo() As String
        Get
            Return Entity.QuienContabilizo
        End Get
        Set(ByVal value As String)
            Entity.QuienContabilizo = value
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha Cancelación")> _
    Public Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property

    <ComponentModel.DisplayName("Quien Contabilizo")> _
    Public Property QuienCancelo() As String
        Get
            Return Entity.QuienCancelo
        End Get
        Set(ByVal value As String)
            Entity.QuienCancelo = value
        End Set
    End Property

    <ComponentModel.DisplayName("Observación Cancelacion"), ComponentModel.DataObjectField(False, False, False, 500)> _
    Public Property ObservacionCancela() As String
        Get
            Return Entity.ObservacionCancela
        End Get
        Set(ByVal value As String)
            Entity.ObservacionCancela = value
        End Set
    End Property

    <ComponentModel.DisplayName("Folio Movimiento Referencia")> _
    Public Property FolioMovmientoReferencia() As String
        Get
            Return Entity.FolioMovmientoReferencia
        End Get
        Set(ByVal value As String)
            Entity.FolioMovmientoReferencia = value
        End Set
    End Property

    <ComponentModel.DisplayName("Detalle"), ComponentModel.Description("Contiene el datalle del movimiento de almacén")> _
    Public ReadOnly Property Detalle() As MovimientoAlmacenDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New MovimientoAlmacenDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.MscmovtosAlmacenDet)
            End If

            Return m_Detalle
        End Get
    End Property

    Public Property Estatus() As EstatusChar
        Get
            Return Asc(Entity.Estatus)
        End Get
        Set(ByVal value As EstatusChar)
            Entity.Estatus = Chr(value)
        End Set
    End Property
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Agrega un detalle al movimiento de almacén. Antes de agregar un detalle es necesario que ya haya ingresado todos los datos del movimiento
    ''' </summary>
    ''' <param name="idProducto">Id del producto que va a agregar al detalle. Si es canal no ocupa establecerlo solo ingrese 0</param>
    ''' <param name="kilos"></param>
    ''' <param name="piezas"></param>
    ''' <param name="costo"></param>
    ''' <param name="iva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AgregarDetalle(ByVal idProducto As Integer, ByVal kilos As Decimal, ByVal piezas As Integer, ByVal costo As Decimal, ByVal iva As Decimal) As Boolean
        Try
            Dim det As New MovimientoAlmacenDetalleClass

            Me.Detalle.ResetBindings()

            det.Movimiento = Me
            det.IdProducto = idProducto
            det.Kilos = kilos
            det.Piezas = piezas
            det.CostoUnitario = costo
            det.IVA = iva

            Me.Detalle.Add(det)

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al agregar el detalle del movimiento al movimiento", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Agrega un detalle al movimiento de almacén. Antes de agregar un detalle es necesario que ya haya ingresado todos los datos del movimiento
    ''' </summary>
    ''' <param name="kilos"></param>
    ''' <param name="piezas"></param>
    ''' <param name="costo"></param>
    ''' <param name="iva"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AgregarCanalAlDetalle(ByVal kilos As Decimal, ByVal piezas As Integer, ByVal costo As Decimal, ByVal iva As Decimal) As Boolean
        Try
            Dim det As New MovimientoAlmacenDetalleClass
            Dim idProducto As Integer
            Dim productoC As New CC.MsccatProductosCollection
            Dim valor As Object

            valor = productoC.GetScalar(Integralab.ORM.MsccatProductosFieldIndex.IdProducto, New OC.Expression(HC.MsccatProductosFields.IdProducto), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, HC.MsccatProductosFields.Canal = 1)

            If valor Is Nothing OrElse DBNull.Value.Equals(valor) Then
                MsgBox("No hay un producto registrado como canal", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                idProducto = CInt(valor)
            End If

            Me.Detalle.ResetBindings()

            det.Movimiento = Me
            det.IdProducto = idProducto
            det.Kilos = kilos
            det.Piezas = piezas
            det.CostoUnitario = costo
            det.IVA = iva

            Me.Detalle.Add(det)

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al agregar el detalle del movimiento al movimiento", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guarda el movieminto de almacen con sus detalles y afecta el inventario del almacén, El folio de movimiento se genera al momento de guardar
    ''' </summary>
    ''' <param name="Trans">Ingrese la transaccion a la que pertenesera esta operacion, en caso de no tener transaccion solo establesca nothing</param>
    ''' <returns>True si se completo toda la operación y una Exception si ocurre algun error</returns>
    ''' <remarks>Se requiere cachar una Exception</remarks>
    Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Dim terminarTrans As Boolean = False

            If Me.Detalle.Count = 0 Then
                Throw New Exception("No hay movimientos que registrar")
            End If

            If Trans Is Nothing Then
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "movimeinto")
                terminarTrans = True
            End If

            Dim folio As New FoliosClass

            folio.Codigo = CodigodeFolios.MovimientosdeAlmacen
            folio.Año = Now.Year
            folio.Mes = Now.ToString("MM")

            If Not folio.Guardar(Trans) Then
                Throw New Exception("Ocurrio un error al general el folio de movimiento")
            End If

            Me.Estatus = EstatusChar.VIGENTE
            Me.FolioMovimiento = folio.Año & folio.Mes & folio.Consecutivo.ToString("000000")

            For Each det As MovimientoAlmacenDetalleClass In Detalle
                det.Movimiento = Me
            Next

            Trans.Add(Entity)

            Entity.Save()

            For Each det As MovimientoAlmacenDetalleClass In Me.Detalle
                Dim ent As EC.MscmovtosAlmacenDetEntity = det.Entidad
                Dim inv As New InventarioClass

                Trans.Add(ent)

                ent.Save()

                With inv
                    .IdCodAlmacen = Me.IdAlmacen
                    .IdCodProducto = det.IdProducto
                    .Mes = Now.Month
                    .Año = Now.Year

                    If Me.TipoMovimiento.Direccion = DireccionEnum.ENTRADAS Then
                        .EntKilos = det.Kilos
                        .EntPzas = det.Piezas
                        .NumOpc = 1
                    Else
                        .SalKilos = det.Kilos
                        .SalPzas = det.Piezas
                        .NumOpc = 2
                    End If

                    .Func = "I"

                    If Not .Guardar(Trans) Then
                        Throw New Exception("Ocurrio un error al guardar el movimiento de almacen")
                    End If
                End With
            Next

            If terminarTrans Then
                Trans.Commit()
            End If

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            Throw New Exception(ex.Message, ex)
#Else
            Throw New Exception("Ocurrio un error al guardar el movimiento de almacen", ex)
#End If
        End Try
    End Function

    Public Function EstablecerAlmacen(ByVal tipoAlmacen As TipoAlmacenEnum) As Boolean
        Try
            Dim config As New CC.UsrProdConfiguracionCollection

            config.GetMulti(Nothing)

            If config.Count > 0 Then
                Select Case tipoAlmacen
                    Case TipoAlmacenEnum.CANAL
                        IdAlmacen = config(0).IdAlmacenCanales
                    Case TipoAlmacenEnum.CORTE
                        IdAlmacen = config(0).IdAlmacenCortes
                    Case TipoAlmacenEnum.DECOMISO
                        IdAlmacen = config(0).IdAlmacenDecomisos
                    Case TipoAlmacenEnum.PRODUCTO
                        IdAlmacen = config(0).IdAlmacenProductos
                    Case TipoAlmacenEnum.CONGELADO
                        IdAlmacen = config(0).IdAlmacenCorteCongelado
                    Case TipoAlmacenEnum.VALOR_AGREGADO_FRESCO
                        IdAlmacen = config(0).IdAlmacenValorAgregado
                    Case TipoAlmacenEnum.VALOR_AGREGADO_CONGELADO
                        IdAlmacen = config(0).IdAlmacenValorAgregadoCongelado
                End Select

                Return True
            Else
                Throw New Exception("Debe establecer primero una configuracion de producción")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Public Function EstablecerTipoMovimiento(ByVal tipoMovimiento As InventarioConfigProduccionClass.TipoMovimientoProdEnum) As Boolean
        Try
            Dim confMov As New CC.MscconfigMovtosAlmacenCollection

            confMov.GetMulti(Nothing)

            If confMov.Count > 0 Then
                Select Case tipoMovimiento
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_A_Almacen
                        If confMov(0).EntradaCanalAlmacen.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canales a Almacén")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalAlmacen
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Captura
                        If confMov(0).EntradaCorteXcaptura.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Cortes")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXcaptura
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Captura
                        If confMov(0).EntradaProductoXcaptura.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoXcaptura
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Devolucion_Venta
                        If confMov(0).EntradaCorteXdevolucionVenta.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Cortes por Devolución de Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXdevolucionVenta
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Devolucion_Venta
                        If confMov(0).EntradaCanalXdevolucionVenta.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canales por Devolución de Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXdevolucionVenta
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Devolucion_Venta
                        If confMov(0).EntradaProductoXdevolucionVenta.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos por Devolución de Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoXdevolucionVenta
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Decomiso
                        If confMov(0).EntradaCanalXdecomiso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canales por Decomiso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalXdecomiso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Decomiso
                        If confMov(0).EntradaProductoXdecomiso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos por Decomiso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoXdecomiso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Compra
                        If confMov(0).EntradaCorteXcompra.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Cortes por Compra")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXcompra
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Compra
                        If confMov(0).EntradaCanalXcompra.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canales por Compra")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalXcompra
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Compra
                        If confMov(0).EntradaProductoXcompra.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos por Compra")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoXcompra
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Otras_Entradas
                        If confMov(0).EntradaCorteXotrasEntradas.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Cortes por Otras Entradas")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXotrasEntradas
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Otras_Entradas
                        If confMov(0).EntradaCanalXotrasEntradas.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canales por Otras Entradas")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalXotrasEntradas
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Otras_Entradas
                        If confMov(0).EntradaProductoXotrasEntradas.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos por Otras Entradas")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoXotrasEntradas
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Inventario_Inicial
                        If confMov(0).EntradaCorteInventarioInicial.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Cortes por Inventario Inicial")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteInventarioInicial
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Inventario_Inicial
                        If confMov(0).EntradaCanalInventarioInicial.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canales por Inventario Inicial")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalInventarioInicial
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Inventario_Inicial
                        If confMov(0).EntradaProductoInventarioInicial.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos por Inventario Inicial")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoInventarioInicial
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Ajuste_Inventario
                        If confMov(0).EntradaCorteXajusteInventario.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Cortes por Ajuste de Inventario")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXajusteInventario
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Ajuste_Inventario
                        If confMov(0).EntradaCanalXajusteInventario.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canales por Ajuste de Inventario")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalXajusteInventario
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Ajuste_Inventario
                        If confMov(0).EntradaProductoXajusteInventario.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos por Ajuste de Inventario")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoXajusteInventario
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Canal_A_Corte
                        If confMov(0).EntradaCanalXcancelacionCanalAcorte.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canal por Cancelación de Canal a Corte")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalXcancelacionCanalAcorte
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta
                        If confMov(0).EntradaCanalXcancelacionVenta.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Canal por Cancelación de Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCanalXcancelacionVenta
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta
                        If confMov(0).EntradaCorteXcancelacionVenta.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Cortes por Cancelación de Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXcancelacionVenta
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta
                        If confMov(0).EntradaProductoXcancelacionVenta.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Productos por Cancelación de Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaProductoXcancelacionVenta
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Reproceso
                        If confMov(0).EntradaCorteXcancelacionReproceso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Corte por Cancelación de Reproceso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXcancelacionReproceso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Traspaso
                        If confMov(0).EntradaCorteXtraspaso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Corte por Traspaso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXtraspaso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Salida_Traspaso
                        If confMov(0).EntradaCorteXcancelacionSalidaTraspaso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Entradas de Corte por Cancelación de Salida Por Traspaso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).EntradaCorteXcancelacionSalidaTraspaso
                        End If

                        '=================== S A L I D A S ======================
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Canal_Almacen
                        If confMov(0).SalidaCanalXcancelacionCanalAlmacen.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canal por Cancelación del Canal a Corte")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXcancelacionCanalAlmacen
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Captura_Corte
                        If confMov(0).SalidaCorteXcancelacionCapturaCorte.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Cancelación de Captura")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXcancelacionCapturaCorte
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Compra
                        If confMov(0).SalidaProductoXcancelacionProductoCaptura.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Producto por Cancelación de Captura")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaProductoXcancelacionProductoCaptura
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Venta
                        If confMov(0).SalidaCorteXventa.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXventa
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Venta
                        If confMov(0).SalidaCanalXventa.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canal por Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXventa
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Venta
                        If confMov(0).SalidaProductoXventa.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Producto por Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaProductoXventa
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Decomiso
                        If confMov(0).SalidaCanalXcancelacionDecomiso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canal por Cancelación de Decomiso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXcancelacionDecomiso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Decomiso
                        If confMov(0).SalidaProductoXcancelacionDecomiso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Producto por Cancelación de Decomiso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaProductoXcancelacionDecomiso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Compra
                        If confMov(0).SalidaCorteXcancelacionCompra.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Cancelación de Compra")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXcancelacionCompra
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Compra
                        If confMov(0).SalidaCanalXcancelacionCompra.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canal por Cancelación de Compra")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXcancelacionCompra
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Compra
                        If confMov(0).SalidaProductoXcancelacionCompra.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Producto por Cancelación de Compra")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaProductoXcancelacionCompra
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Otras_Salidas
                        If confMov(0).SalidaCorteXotrasSalidas.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Otras Salidas")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXotrasSalidas
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Otras_Salidas
                        If confMov(0).SalidaCanalXotrasSalidas.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canal por Otra Salidas")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXotrasSalidas
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Otras_Salidas
                        If confMov(0).SalidaProductoXotrasSalidas.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Producto por Otras Salidas")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaProductoXotrasSalidas
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Inventario_Inicial
                        If confMov(0).SalidaCorteXcancelacionInventarioInicial.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Cancelación de Inventario Inicial")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXcancelacionInventarioInicial
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Inventario_Inicial
                        If confMov(0).SalidaCanalXcancelacionInventarioInicial.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canal por Cancelación de Inventario Inicial")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXcancelacionInventarioInicial
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Inventario_Inicial
                        If confMov(0).SalidaProductoXcancelacionInventarioInicial.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Productos por Inventario Inicial")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaProductoXcancelacionInventarioInicial
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Ajuste_Inventario
                        If confMov(0).SalidaCorteXajusteInventario.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Ajuste de Inventario")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXajusteInventario
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Ajuste_Inventario
                        If confMov(0).SalidaCanalXajusteInventario.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canales por Ajuste de Inventario")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXajusteInventario
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Ajuste_Inventario
                        If confMov(0).SalidaProductoXajusteInventario.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Productos por Ajuste de Inventario")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaProductoXajusteInventario
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Canal_A_Corte
                        If confMov(0).SalidaCanalXcanalAcorte.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Canal Por Canal a Corte")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCanalXcanalAcorte
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Reproceso
                        If confMov(0).SalidaCorteXreproceso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Reproceso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXreproceso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Devolucion_Venta
                        If confMov(0).SalidaCorteXcancelacionDevolucionVenta.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Cancelación de Devolución de Venta")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXcancelacionDevolucionVenta
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Traspaso
                        If confMov(0).SalidaCorteXtraspaso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Traspaso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXtraspaso
                        End If
                    Case InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Entrada_Traspaso
                        If confMov(0).SalidaCorteXcancelacionEntradaTraspaso.GetValueOrDefault(-1) = -1 Then
                            Throw New Exception("Debe configurar primero el movimiento de almacén Salida de Corte por Cancelación de Entrada Por Traspaso")
                        Else
                            Me.IdTipoMovimiento = confMov(0).SalidaCorteXcancelacionEntradaTraspaso
                        End If
                End Select
            Else
                Throw New Exception("Debe establecer priemro una configuración de movimientos de almacén")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.FolioMovimiento
    End Function
#End Region

#Region "Eventos"

#End Region

#Region "Enumeradores"
    Public Enum TipoAlmacenEnum
        CANAL
        CORTE
        DECOMISO
        PRODUCTO
        CONGELADO
        VALOR_AGREGADO_FRESCO
        VALOR_AGREGADO_CONGELADO
    End Enum
#End Region
End Class