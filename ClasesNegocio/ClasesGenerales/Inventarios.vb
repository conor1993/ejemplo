Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.ComponentModel
Imports Keys = System.Windows.Forms.Keys
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures

'************************************************************************
'*  ENUMERACIONES
'************************************************************************
Public Enum OrigenEnum As Byte
    COMPRAS = Keys.C
    VENTAS = Keys.V
    INVENTARIOS = Keys.I
End Enum

Public Class InventarioConfigProduccionClass
    Implements IDisposable, IEntidad2

    Public Enum TipoMovimientoProdEnum
        Entrada_Canal_A_Almacen
        Entrada_Corte_X_Captura
        Entrada_Producto_X_Captura
        Entrada_Canal_X_Devolucion_Venta
        Entrada_Corte_X_Devolucion_Venta
        Entrada_Producto_X_Devolucion_Venta
        Entrada_Canal_X_Decomiso
        Entrada_Producto_X_Decomiso
        Entrada_Canal_X_Compra
        Entrada_Corte_X_Compra
        Entrada_Producto_X_Compra
        Entrada_Canal_X_Otras_Entradas
        Entrada_Corte_X_Otras_Entradas
        Entrada_Producto_X_Otras_Entradas
        Entrada_Canal_X_Inventario_Inicial
        Entrada_Corte_X_Inventario_Inicial
        Entrada_Producto_X_Inventario_Inicial
        Entrada_Canal_X_Ajuste_Inventario
        Entrada_Corte_X_Ajuste_Inventario
        Entrada_Producto_X_Ajuste_Inventario
        Entrada_Canal_X_Cancelacion_Canal_A_Corte
        Entrada_Canal_X_Cancelacion_Venta
        Entrada_Corte_X_Cancelacion_Venta
        Entrada_Producto_X_Cancelacion_Venta
        Entrada_Corte_X_Cancelacion_Reproceso
        Entrada_Corte_X_Cancelacion_Salida_Traspaso
        Entrada_Corte_X_Traspaso

        Salida_Canal_X_Cancelacion_Canal_Almacen
        Salida_Corte_X_Cancelacion_Captura_Corte
        Salida_Producto_X_Cancelacion_Producto_Captura
        Salida_Corte_X_Venta
        Salida_Canal_X_Venta
        Salida_Producto_X_Venta
        Salida_Canal_X_Cancelacion_Decomiso
        Salida_Producto_X_Cancelacion_Decomiso
        Salida_Producto_X_Cancelacion_Compra
        Salida_Canal_X_Cancelacion_Compra
        Salida_Corte_X_Cancelacion_Compra
        Salida_Producto_X_Otras_Salidas
        Salida_Canal_X_Otras_Salidas
        Salida_Corte_X_Otras_Salidas
        Salida_Producto_X_Cancelacion_Inventario_Inicial
        Salida_Canal_X_Cancelacion_Inventario_Inicial
        Salida_Corte_X_Cancelacion_Inventario_Inicial
        Salida_Producto_X_Ajuste_Inventario
        Salida_Canal_X_Ajuste_Inventario
        Salida_Corte_X_Ajuste_Inventario
        Salida_Canal_X_Canal_A_Corte
        Salida_Corte_X_Reproceso
        Salida_Corte_X_Cancelacion_Devolucion_Venta
        Salida_Corte_X_Cancelacion_Entrada_Traspaso
        Salida_Corte_X_Traspaso
    End Enum


#Region " IDispose "
    Private disposed As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                ' TODO: free unmanaged resources when explicitly called
            End If

            ' TODO: free shared unmanaged resources
        End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region
#End Region

#Region " Declaraciones "
    Private Shared _tipos As TipoMovimientoAlmacenCollectionClass
    Private InvConfigProd As EC.MscconfigMovtosAlmacenEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
#End Region

#Region " Constructores "
    Sub New(ByVal Tipos As TipoMovimientoAlmacenCollectionClass)
        InvConfigProd = New EC.MscconfigMovtosAlmacenEntity
        _tipos = Tipos
        For x As Integer = 1 To 14
            tms.Add(Nothing)
        Next
    End Sub

    Sub New(ByVal Entidad As EC.MscconfigMovtosAlmacenEntity, ByVal Tipos As TipoMovimientoAlmacenCollectionClass)
        InvConfigProd = Entidad
        _tipos = Tipos

        For x As Integer = 1 To 14
            tms.Add(Nothing)
        Next
        Inicializar()
    End Sub

    Sub New(ByVal Indice As Integer, ByVal Tipos As TipoMovimientoAlmacenCollectionClass)
        InvConfigProd = New EC.MscconfigMovtosAlmacenEntity(Indice)
        _tipos = Tipos

        For x As Integer = 1 To 52
            tms.Add(Nothing)
        Next

        Inicializar()
    End Sub

    Private Sub Inicializar()
        tms(TipoMovimientoProdEnum.Entrada_Canal_A_Almacen) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalAlmacen.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Captura) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXcaptura.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Captura) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoXcaptura.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Devolucion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalXdevolucionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Devolucion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXdevolucionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Devolucion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoXdevolucionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Decomiso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoXdecomiso.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Decomiso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalXdecomiso.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoXcompra.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalXcompra.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXcompra.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Otras_Entradas) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoXotrasEntradas.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Otras_Entradas) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalXotrasEntradas.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Otras_Entradas) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXotrasEntradas.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Inventario_Inicial) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoInventarioInicial.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Inventario_Inicial) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalInventarioInicial.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Inventario_Inicial) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteInventarioInicial.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoXajusteInventario.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXajusteInventario.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalXajusteInventario.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Canal_A_Corte) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalXcancelacionCanalAcorte.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCanalXcancelacionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXcancelacionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaProductoXcancelacionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXtraspaso.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Salida_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorteXcancelacionSalidaTraspaso.GetValueOrDefault(0)))

        tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Canal_Almacen) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXcancelacionCanalAlmacen.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Captura_Corte) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXcancelacionCapturaCorte.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Producto_Captura) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaProductoXcancelacionProductoCaptura.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXventa.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Canal_X_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXventa.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Producto_X_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaProductoXventa.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Decomiso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXcancelacionDecomiso.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Decomiso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaProductoXcancelacionDecomiso.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaProductoXcancelacionCompra.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXcancelacionCompra.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXcancelacionCompra.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Producto_X_Otras_Salidas) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaProductoXotrasSalidas.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Canal_X_Otras_Salidas) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXotrasSalidas.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Otras_Salidas) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXotrasSalidas.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Inventario_Inicial) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaProductoXcancelacionInventarioInicial.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Inventario_Inicial) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXcancelacionInventarioInicial.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Inventario_Inicial) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXcancelacionInventarioInicial.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Producto_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaProductoXajusteInventario.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXajusteInventario.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Canal_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXajusteInventario.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Canal_X_Canal_A_Corte) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCanalXcanalAcorte.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Devolucion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXcancelacionDevolucionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXtraspaso.GetValueOrDefault(0)))
        tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Entrada_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorteXcancelacionEntradaTraspaso.GetValueOrDefault(0)))
    End Sub
#End Region

    Private Function ObtenerNombre(ByVal tipo As TipoMovimientoAlmacenClass) As String
        If Not IsNothing(tipo) Then Return tipo.Nombre
        Return Nothing
    End Function

#Region " Propiedades "

#Region " Declaraciones "
    Shared tms As New List(Of String)
    Dim Nulo As New System.Nullable(Of Integer)
#End Region

    <Description("Movimiento utilizado para las entradas de Canales a Almacén."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canales a Almacén"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canales_A_Almacen() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_A_Almacen)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_A_Almacen, Value)
            If opc > -1 Then
                InvConfigProd.EntradaCanalAlmacen = opc
            Else
                InvConfigProd.EntradaCanalAlmacen = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes capturados."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Captura"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corte_X_Captura() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Captura)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Captura, Value)
            If opc > -1 Then
                InvConfigProd.EntradaCorteXcaptura = opc
            Else
                InvConfigProd.EntradaCorteXcaptura = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de productos capturados."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Productos por Captura"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Producto_X_Captura() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Captura)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Captura, Value)
            If opc > -1 Then
                InvConfigProd.EntradaProductoXcaptura = opc
            Else
                InvConfigProd.EntradaProductoXcaptura = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por devolución de venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Devolución de Venta"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corte_X_Devolucion_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Devolucion_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Devolucion_Venta, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXdevolucionVenta = opc
            Else
                InvConfigProd.EntradaCorteXdevolucionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canal por devolución de venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canal por Devolución de Venta"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Devolucion_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Devolucion_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Devolucion_Venta, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalXdevolucionVenta = opc
            Else
                InvConfigProd.EntradaCanalXdevolucionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de producto por devolución de venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Producto por Devolución de Venta"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Producto_X_Devolucion_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Devolucion_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Devolucion_Venta, Value)

            If opc > -1 Then
                InvConfigProd.EntradaProductoXdevolucionVenta = opc
            Else
                InvConfigProd.EntradaProductoXdevolucionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de producto por decomisado."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Producto por Decomiso"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Producto_X_Decomiso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Decomiso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Decomiso, Value)

            If opc > -1 Then
                InvConfigProd.EntradaProductoXdecomiso = opc
            Else
                InvConfigProd.EntradaProductoXdecomiso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canal por decomisado."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canal por Decomiso"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Decomiso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Decomiso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Decomiso, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalXdecomiso = opc
            Else
                InvConfigProd.EntradaCanalXdecomiso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de producto comprados."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Productos por Compra"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Producto_X_Compra() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Compra)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Compra, Value)

            If opc > -1 Then
                InvConfigProd.EntradaProductoXcompra = opc
            Else
                InvConfigProd.EntradaProductoXcompra = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canales comprados."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canales por Compra"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Compra() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Compra)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Compra, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalXcompra = opc
            Else
                InvConfigProd.EntradaCanalXcompra = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de corte comprados."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Compra"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corte_X_Compra() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Compra)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Compra, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXcompra = opc
            Else
                InvConfigProd.EntradaCorteXcompra = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de productos por otras entradas."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Producto por Otras Entradas"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Producto_X_Otras_Entradas() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Otras_Entradas)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Otras_Entradas, Value)

            If opc > -1 Then
                InvConfigProd.EntradaProductoXotrasEntradas = opc
            Else
                InvConfigProd.EntradaProductoXotrasEntradas = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canales por otras entradas."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canal por Otras Entradas"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Otras_Entradas() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Otras_Entradas)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Otras_Entradas, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalXotrasEntradas = opc
            Else
                InvConfigProd.EntradaCanalXotrasEntradas = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por otras entradas."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Otras Entradas"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corte_X_Otras_Entradas() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Otras_Entradas)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Otras_Entradas, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXotrasEntradas = opc
            Else
                InvConfigProd.EntradaCorteXotrasEntradas = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de productos por inventario inicial."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Productos por Inventario Inicial"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Producto_X_Inventario_Inicial() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Inventario_Inicial)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Inventario_Inicial, Value)

            If opc > -1 Then
                InvConfigProd.EntradaProductoInventarioInicial = opc
            Else
                InvConfigProd.EntradaProductoInventarioInicial = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canales por inventario inicial."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canal por Inventario Inicial"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Inventario_Inicial() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Inventario_Inicial)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Inventario_Inicial, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalInventarioInicial = opc
            Else
                InvConfigProd.EntradaCanalInventarioInicial = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por inventario inicial."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Corte por Inventario Inicial"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corte_X_Inventario_Inicial() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Inventario_Inicial)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Inventario_Inicial, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteInventarioInicial = opc
            Else
                InvConfigProd.EntradaCorteInventarioInicial = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de productos por ajiste de inventario."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Producto por Ajuste de Inventario"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Producto_X_Ajuste_Inventario() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Ajuste_Inventario)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Ajuste_Inventario, Value)

            If opc > -1 Then
                InvConfigProd.EntradaProductoXajusteInventario = opc
            Else
                InvConfigProd.EntradaProductoXajusteInventario = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canales por ajiste de inventario."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canal por Ajuste de Inventario"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Ajuste_Inventario() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Ajuste_Inventario)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Ajuste_Inventario, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalXajusteInventario = opc
            Else
                InvConfigProd.EntradaCanalXajusteInventario = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por ajiste de inventario."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Corte por Ajuste de Inventario"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corte_X_Ajuste_Inventario() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Ajuste_Inventario)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Ajuste_Inventario, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXajusteInventario = opc
            Else
                InvConfigProd.EntradaCorteXajusteInventario = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canales por cancelación de canal a corte."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canal por Cancelación de Canal a Corte"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Cancelacion_Canal_A_Corte() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Canal_A_Corte)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Canal_A_Corte, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalXcancelacionCanalAcorte = opc
            Else
                InvConfigProd.EntradaCanalXcancelacionCanalAcorte = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de canales por cancelación de venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Canal por Cancelación de Venta"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Canal_X_Cancelacion_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCanalXcancelacionVenta = opc
            Else
                InvConfigProd.EntradaCanalXcancelacionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por cancelación de venta."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Cancelación de Ventas"), _
System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_Corte_X_Cancelacion_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXcancelacionVenta = opc
            Else
                InvConfigProd.EntradaCorteXcancelacionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de productos por cancelación de venta."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Productos por Cancelación de Venta"), _
System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_Producto_X_Cancelacion_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta, Value)

            If opc > -1 Then
                InvConfigProd.EntradaProductoXcancelacionVenta = opc
            Else
                InvConfigProd.EntradaProductoXcancelacionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por cancelación de reproceso."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Cancelación de Reproceso"), _
System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_Corte_X_Cancelacion_Reproceso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Reproceso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Reproceso, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXcancelacionReproceso = opc
            Else
                InvConfigProd.EntradaCorteXcancelacionReproceso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por traspaso."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Traspaso"), _
System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_Corte_X_Traspaso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Traspaso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Traspaso, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXtraspaso = opc
            Else
                InvConfigProd.EntradaCorteXtraspaso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la entrada de cortes por cancelación de salidas por traspaso."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas de Cortes por Cancelación de Salidas por Traspaso"), _
System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_Corte_X_Cancelacion_Salida_Traspaso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Salida_Traspaso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Salida_Traspaso, Value)

            If opc > -1 Then
                InvConfigProd.EntradaCorteXcancelacionSalidaTraspaso = opc
            Else
                InvConfigProd.EntradaCorteXcancelacionSalidaTraspaso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property


    '================= S A L I D A S ===================

    <Description("Movimiento utilizado para las salidas de canales por cancelación de canal a almcén."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canal por Cancelación de Canales a Almacén"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salidas_Canal_X_Cancelacion_Canales_A_Almacen() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Canal_Almacen)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Canal_Almacen, Value)
            If opc > -1 Then
                InvConfigProd.SalidaCanalXcancelacionCanalAlmacen = opc
            Else
                InvConfigProd.SalidaCanalXcancelacionCanalAlmacen = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de cortes por cancelación de capturas de cortes."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Corte por Cancelación de Captura"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Cancelacion_Captura() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Captura_Corte)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Captura_Corte, Value)
            If opc > -1 Then
                InvConfigProd.SalidaCorteXcancelacionCapturaCorte = opc
            Else
                InvConfigProd.SalidaCorteXcancelacionCapturaCorte = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de productos por cancelación de captura."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Productos por Cancelación de Captura"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Producto_X_Cancelacion_Captura() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Producto_Captura)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Producto_Captura, Value)
            If opc > -1 Then
                InvConfigProd.SalidaProductoXcancelacionProductoCaptura = opc
            Else
                InvConfigProd.SalidaProductoXcancelacionProductoCaptura = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de cortres por venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Cortes por Venta"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Venta, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXventa = opc
            Else
                InvConfigProd.SalidaCorteXventa = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de canales por venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canales por Venta"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Canal_X_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Venta, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCanalXventa = opc
            Else
                InvConfigProd.SalidaCanalXventa = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de productos por venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Productos por Venta"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Ptroducto_X_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Producto_X_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Producto_X_Venta, Value)

            If opc > -1 Then
                InvConfigProd.SalidaProductoXventa = opc
            Else
                InvConfigProd.SalidaProductoXventa = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de producto por cancelación de decomiso."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Producto por Cancelación de Decomiso"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Producto_X_Cancelacion_Decomiso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Decomiso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Decomiso, Value)

            If opc > -1 Then
                InvConfigProd.SalidaProductoXcancelacionDecomiso = opc
            Else
                InvConfigProd.SalidaProductoXcancelacionDecomiso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de canales por cancelación de decomiso."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canales por Cancelación de Decomiso"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salidas_Canal_X_Cancelacion_Decomiso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Decomiso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Decomiso, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCanalXcancelacionDecomiso = opc
            Else
                InvConfigProd.SalidaCanalXcancelacionDecomiso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de producto por cancelación de compra."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Producto por Cancelación de Compra"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Producto_X_Cancelacion_Compra() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Compra)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Compra, Value)

            If opc > -1 Then
                InvConfigProd.SalidaProductoXcancelacionCompra = opc
            Else
                InvConfigProd.SalidaProductoXcancelacionCompra = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de canales por cancelación de compra."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canales por Cancelación de Compra"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Canal_X_Cancelacion_Compra() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Compra)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Compra, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCanalXcancelacionCompra = opc
            Else
                InvConfigProd.SalidaCanalXcancelacionCompra = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de cortes por cancelación de compra."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Cortes por Cancelación de Compra"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Cancelacion_Compra() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Compra)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Compra, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXcancelacionCompra = opc
            Else
                InvConfigProd.SalidaCorteXcancelacionCompra = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de producto por otras salidas."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Producto por Otras Salidas"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Producto_X_Otras_Salidas() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Producto_X_Otras_Salidas)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Producto_X_Otras_Salidas, Value)

            If opc > -1 Then
                InvConfigProd.SalidaProductoXotrasSalidas = opc
            Else
                InvConfigProd.SalidaProductoXotrasSalidas = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de canales por otras salidas."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canales por Otras Salidas"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Canal_X_Otras_Salidas() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Otras_Salidas)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Otras_Salidas, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCanalXotrasSalidas = opc
            Else
                InvConfigProd.SalidaCanalXotrasSalidas = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de cortes por otras salidas."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Cortes por Otras Salidas"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Cortes_X_Otras_Salidas() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Otras_Salidas)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Otras_Salidas, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXotrasSalidas = opc
            Else
                InvConfigProd.SalidaCorteXotrasSalidas = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de producto por cancelación de inventario inicial."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Producto por Cancelación de Inventario Inicial"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Producto_X_Inventario_Inicial() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Inventario_Inicial)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Producto_X_Cancelacion_Inventario_Inicial, Value)

            If opc > -1 Then
                InvConfigProd.SalidaProductoXcancelacionInventarioInicial = opc
            Else
                InvConfigProd.SalidaProductoXcancelacionInventarioInicial = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de canales por cancelación de inventario inicial."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canales por Cancelación de Inventario Inicial"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Canal_X_Cancelacion_Inventario_Inicial() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Inventario_Inicial)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Inventario_Inicial, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCanalXcancelacionInventarioInicial = opc
            Else
                InvConfigProd.SalidaCanalXcancelacionInventarioInicial = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de cortes por cancelación de inventario inicial."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Cortes por Cancelación de Inventario Inicial"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Cancelacion_Inventario_Inicial() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Inventario_Inicial)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Inventario_Inicial, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXcancelacionInventarioInicial = opc
            Else
                InvConfigProd.SalidaCorteXcancelacionInventarioInicial = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de producto por ajuste de inventario."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Productos por Ajuste de Inventario"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Producto_X_Ajuste_De_Inventario() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Producto_X_Ajuste_Inventario)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Producto_X_Ajuste_Inventario, Value)

            If opc > -1 Then
                InvConfigProd.SalidaProductoXajusteInventario = opc
            Else
                InvConfigProd.SalidaProductoXajusteInventario = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de canales por ajuste de inventario."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canales por Ajuste de Inventario"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Canal_X_Ajuste_Inventario() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Ajuste_Inventario)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Ajuste_Inventario, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCanalXajusteInventario = opc
            Else
                InvConfigProd.SalidaCanalXajusteInventario = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salidas de corte por ajuste de inventario."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Cortes por Ajuste de Inventario"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Ajuste_Inventario() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Ajuste_Inventario)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Ajuste_Inventario, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXajusteInventario = opc
            Else
                InvConfigProd.SalidaCorteXajusteInventario = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de canal a corte."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Canales a Corte"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Canal_A_Corte() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Canal_X_Canal_A_Corte)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Canal_X_Canal_A_Corte, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCanalXcanalAcorte = opc
            Else
                InvConfigProd.SalidaCanalXcanalAcorte = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de corte por reproceso."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Corte Por Reproceso"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Reproceso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Reproceso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Reproceso, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXreproceso = opc
            Else
                InvConfigProd.SalidaCorteXreproceso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de corte por cancelación de devolucion de venta."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Corte Por Cancelación de Devolución de Venta"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Cancelacion_Devolucion_Venta() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Devolucion_Venta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Devolucion_Venta, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXcancelacionDevolucionVenta = opc
            Else
                InvConfigProd.SalidaCorteXcancelacionDevolucionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de corte por traspaso."), _
    TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Corte Por Traspaso"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corte_X_Traspaso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Traspaso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Traspaso, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXtraspaso = opc
            Else
                InvConfigProd.SalidaCorteXtraspaso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para la salida de corte por cancelación de entrada por traspaso."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas de Corte Por Cancelación de Entrada Por Traspaso"), _
System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_Corte_X_Cancelacion_Entrada_Traspaso() As String
        Get
            Return tms(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Entrada_Traspaso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Entrada_Traspaso, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorteXcancelacionEntradaTraspaso = opc
            Else
                InvConfigProd.SalidaCorteXcancelacionEntradaTraspaso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de almacén", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property


    Private Function EstablecerValor(ByVal Indice As Integer, ByVal Valor As String) As Integer
        Dim bl As Boolean = False

        For Each texto As String In tms
            If texto = Valor Then
                bl = True
                Exit For
            End If
        Next

        If Not bl Then
            tms(Indice) = Valor
            Return _tipos.Seleccionar(Valor).Codigo
        Else
            tms(Indice) = Nothing
            Return -1
        End If
    End Function

    <System.ComponentModel.Browsable(False)> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function ObtenerTipoMovimiento(ByVal TipoMovimiento As TipoMovimientoProdEnum) As TipoMovimientoAlmacenClass
        If Not IsNothing(tms(TipoMovimiento)) Then
            Return _tipos.Seleccionar(tms(TipoMovimiento))
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region " Metodos "
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Guardar() As Boolean
        Return InvConfigProd.Save
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Sub LeerEntidad(ByVal Entidad As Object) Implements IEntidad2.LeerEntidad
        InvConfigProd = Entidad
    End Sub

    Public Function ObtenerEntidad() As Object Implements IEntidad2.ObtenerEntidad
        Return InvConfigProd
    End Function
#End Region

#Region " Clases "
    Public Class TiposMovimientosClass
        Inherits StringConverter

        Private mTipos As New TipoMovimientoAlmacenCollectionClass

        Public Sub New()
            MyBase.New()

            For Each tipo As TipoMovimientoAlmacenClass In _tipos
                Dim b As Boolean = False
                For Each t As String In tms
                    If tipo.Nombre = t Then b = True
                Next
                If Not b Then mTipos.Add(tipo)
            Next
        End Sub

        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            'True = Se despliega la lista
            'False = No se despliega la lista y el ususario debe escribir un valor
            Return True
        End Function

        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As StandardValuesCollection
            Return New StandardValuesCollection(_tipos)
        End Function

        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            'True = el combo no admite más items que los de la lista
            'False = el combo admite un item que no esté en la lista
            Return True
        End Function
    End Class
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class InventarioConfigGanadoClass
    Implements IDisposable, IEntidad2

    Public Enum TipoMovimientoGanadoEnum As Byte
        EntradaXcompraGanado
        EntradaRecibaCancelacionVenta
        EntradaRecibaCancelacionMuerte
        EntradaRecibaCancelacionRastro
        EntradaRecibaCancelacionEnfermeria
        EntradaCorralCancelacionVenta
        EntradaCorralCancelacionMuerte
        EntradaCorralCancelacionRastro
        SalidaRecibaXtransferenciaAcorral
        SalidaXcancelacionCompraGanado
        SalidaRecibaVenta
        SalidaRecibaMuerte
        SalidaRecibaRastro
        SalidaRecibaEnfermeria
        SalidaCorralVenta
        SalidaCorralMuerte
        SalidaCorralRastro
        EntradaRecibaXcancelacionTransferenciaRecibaAcorral
        EntradaReinicioReciba
        EntradaCorralCancelacionTraspaso
        SalidaCorralTraspaso
    End Enum

#Region " IDispose "
    Private disposed As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                ' TODO: free unmanaged resources when explicitly called
            End If

            ' TODO: free shared unmanaged resources
        End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region
#End Region

#Region " Declaraciones "
    Private Shared _tipos As TipoMovimientoGanadoColeccionClass
    Private InvConfigProd As EC.McgconfiguracionMovimientoGanadoEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
#End Region

#Region " Constructores "
    Sub New(ByVal Tipos As TipoMovimientoGanadoColeccionClass)
        InvConfigProd = New EC.McgconfiguracionMovimientoGanadoEntity
        _tipos = Tipos

        For x As Integer = 0 To 20
            tms.Add(Nothing)
        Next
    End Sub

    Sub New(ByVal Entidad As EC.McgconfiguracionMovimientoGanadoEntity, ByVal Tipos As TipoMovimientoGanadoColeccionClass)
        InvConfigProd = Entidad
        _tipos = Tipos

        For x As Integer = 0 To 20
            tms.Add(Nothing)
        Next
        Inicializar()
    End Sub

    Sub New(ByVal Indice As Integer, ByVal Tipos As TipoMovimientoGanadoColeccionClass)
        InvConfigProd = New EC.McgconfiguracionMovimientoGanadoEntity(Indice)
        _tipos = Tipos

        For x As Integer = 0 To 20
            tms.Add(Nothing)
        Next
        Inicializar()
    End Sub

    Private Sub Inicializar()
        tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionMuerte) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorralCancelacionMuerte.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionRastro) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorralCancelacionRastro.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionTraspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorralCancelacionTraspaso.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionVenta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaCorralCancelacionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionEnfermeria) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaRecibaCancelacionEnfermeria.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionMuerte) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaRecibaCancelacionMuerte.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionRastro) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaRecibaCancelacionRastro.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionVenta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaRecibaCancelacionVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaXcompraGanado) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaXcompraGanado.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaRecibaXcancelacionTransferenciaRecibaAcorral) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaRecibaXcancelacionTransferenciaRecibaAcorral.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.EntradaReinicioReciba) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.EntradaReinicioReciba.GetValueOrDefault(0)))

        tms(TipoMovimientoGanadoEnum.SalidaCorralMuerte) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorralMuerte.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaCorralRastro) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorralRastro.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaCorralTraspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorralTraspaso.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaCorralVenta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaCorralVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaRecibaEnfermeria) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaRecibaEnfermeria.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaRecibaMuerte) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaRecibaMuerte.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaRecibaRastro) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaRecibaRastro.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaRecibaVenta) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaRecibaVenta.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaXcancelacionCompraGanado) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaXcancelacionCompraGanado.GetValueOrDefault(0)))
        tms(TipoMovimientoGanadoEnum.SalidaRecibaXtransferenciaAcorral) = ObtenerNombre(_tipos.Seleccionar(InvConfigProd.SalidaRecibaXtransferenciaAcorral.GetValueOrDefault(0)))
    End Sub
#End Region

    Private Function ObtenerNombre(ByVal tipo As TipoMovimientoGanadoClass) As String
        If Not IsNothing(tipo) Then Return tipo.Nombre
        Return Nothing
    End Function

#Region " Propiedades "

#Region " Declaraciones "
    Shared tms As New List(Of String)
    Dim Nulo As New System.Nullable(Of Integer)
#End Region

    <Description("Movimiento utilizado para las entradas a corral por cancelación de muerte."), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Corrar Por Cancelación De Muerte"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corrar_Cancelacion_Muerte() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionMuerte)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaCorralCancelacionMuerte, Value)
            If opc > -1 Then
                InvConfigProd.EntradaCorralCancelacionMuerte = opc
            Else
                InvConfigProd.EntradaCorralCancelacionMuerte = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas a corral por cancelación a rastro."), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Corrar Por Cancelación A Rastro"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corrar_Cancelacion_Rastro() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionRastro)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaCorralCancelacionRastro, Value)
            If opc > -1 Then
                InvConfigProd.EntradaCorralCancelacionRastro = opc
            Else
                InvConfigProd.EntradaCorralCancelacionRastro = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas a corral por cancelación por traspaso."), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Corrar Por Cancelación Por Traspaso"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corrar_Cancelacion_Traspaso() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionTraspaso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaCorralCancelacionTraspaso, Value)
            If opc > -1 Then
                InvConfigProd.EntradaCorralCancelacionTraspaso = opc
            Else
                InvConfigProd.EntradaCorralCancelacionTraspaso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas a corral por cancelación por venta."), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Corrar Por Cancelación Por Venta"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Corrar_Cancelacion_Venta() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaCorralCancelacionVenta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaCorralCancelacionVenta, Value)
            If opc > -1 Then
                InvConfigProd.EntradaCorralCancelacionVenta = opc
            Else
                InvConfigProd.EntradaCorralCancelacionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas a reciba por cancelación a enfermeria."), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Reciba Por Cancelación A Enfermeria"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Reciba_Cancelacion_Enfermeria() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionEnfermeria)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionEnfermeria, Value)
            If opc > -1 Then
                InvConfigProd.EntradaRecibaCancelacionEnfermeria = opc
            Else
                InvConfigProd.EntradaRecibaCancelacionEnfermeria = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas a reciba por cancelación de muerte."), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Reciba Por Cancelación De Muerte"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Reciba_Cancelacion_Muerte() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionMuerte)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionMuerte, Value)
            If opc > -1 Then
                InvConfigProd.EntradaRecibaCancelacionMuerte = opc
            Else
                InvConfigProd.EntradaRecibaCancelacionMuerte = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas a reciba por cancelación a rastro."), _
   TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Reciba Por Cancelación A Rastro"), _
   System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
   Public Property Entrada_Reciba_Cancelacion_Rastro() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionRastro)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionRastro, Value)
            If opc > -1 Then
                InvConfigProd.EntradaRecibaCancelacionRastro = opc
            Else
                InvConfigProd.EntradaRecibaCancelacionRastro = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas a reciba por cancelación de venta"), _
   TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada A Reciba Por Cancelación De Venta"), _
   System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
   Public Property Entrada_Reciba_Cancelacion_Venta() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionVenta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaRecibaCancelacionVenta, Value)
            If opc > -1 Then
                InvConfigProd.EntradaRecibaCancelacionVenta = opc
            Else
                InvConfigProd.EntradaRecibaCancelacionVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas por compra de ganado"), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada Por Compra De Ganado"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Compra_Ganado() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaXcompraGanado)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaXcompraGanado, Value)

            If opc > -1 Then
                InvConfigProd.EntradaXcompraGanado = opc
            Else
                InvConfigProd.EntradaXcompraGanado = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas por cancelacion de Transferencia de Reciba a Corral"), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada a Reciba Por Cancelacion de Transferencia a Corral"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Reciba_cancelacion_Transferencia_Reciba_A_corral() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaRecibaXcancelacionTransferenciaRecibaAcorral)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaRecibaXcancelacionTransferenciaRecibaAcorral, Value)

            If opc > -1 Then
                InvConfigProd.EntradaRecibaXcancelacionTransferenciaRecibaAcorral = opc
            Else
                InvConfigProd.EntradaRecibaXcancelacionTransferenciaRecibaAcorral = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las entradas por Reinicio de Reciba"), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Entrada Por Reinicio de Reciba"), _
    System.ComponentModel.Category("Entradas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_Reinicio_Reciba() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.EntradaReinicioReciba)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.EntradaReinicioReciba, Value)

            If opc > -1 Then
                InvConfigProd.EntradaReinicioReciba = opc
            Else
                InvConfigProd.EntradaReinicioReciba = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de corral por muerte"), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Corral Por Muerte"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corrar_Muerte() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaCorralMuerte)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaCorralMuerte, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorralMuerte = opc
            Else
                InvConfigProd.SalidaCorralMuerte = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de corral a rastro"), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Corral A Rastro"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Corrar_Rastro() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaCorralRastro)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaCorralRastro, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorralRastro = opc
            Else
                InvConfigProd.SalidaCorralRastro = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de corral por traspaso"), _
   TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Corral Por Traspaso"), _
   System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
   Public Property Salida_Corrar_Traspaso() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaCorralTraspaso)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaCorralTraspaso, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorralTraspaso = opc
            Else
                InvConfigProd.SalidaCorralTraspaso = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de corral por venta"), _
   TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Corral Por Venta"), _
   System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
   Public Property Salida_Corrar_Venta() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaCorralVenta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaCorralVenta, Value)

            If opc > -1 Then
                InvConfigProd.SalidaCorralVenta = opc
            Else
                InvConfigProd.SalidaCorralVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de reciba a enfermeria"), _
TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Reciba A Enfermeria"), _
System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_Reciba_Enfermeria() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaRecibaEnfermeria)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaRecibaEnfermeria, Value)

            If opc > -1 Then
                InvConfigProd.SalidaRecibaEnfermeria = opc
            Else
                InvConfigProd.SalidaRecibaEnfermeria = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de reciba por muerte"), _
TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Reciba Por Muerte"), _
System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_Reciba_Muerte() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaRecibaMuerte)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaRecibaMuerte, Value)

            If opc > -1 Then
                InvConfigProd.SalidaRecibaMuerte = opc
            Else
                InvConfigProd.SalidaRecibaMuerte = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de reciba a rastro"), _
TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Reciba A Rastro"), _
System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_Reciba_Rastro() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaRecibaRastro)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaRecibaRastro, Value)

            If opc > -1 Then
                InvConfigProd.SalidaRecibaRastro = opc
            Else
                InvConfigProd.SalidaRecibaRastro = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de reciba a venta"), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida De Reciba A Venta"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Reciba_Venta() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaRecibaVenta)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaRecibaVenta, Value)

            If opc > -1 Then
                InvConfigProd.SalidaRecibaVenta = opc
            Else
                InvConfigProd.SalidaRecibaVenta = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida por cancelación compra ganado"), _
    TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida Por Cancelación Compra Ganado"), _
    System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Salida_Cancelacion_Compra_Ganado() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaXcancelacionCompraGanado)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaXcancelacionCompraGanado, Value)

            If opc > -1 Then
                InvConfigProd.SalidaXcancelacionCompraGanado = opc
            Else
                InvConfigProd.SalidaXcancelacionCompraGanado = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    <Description("Movimiento utilizado para las salida de Reciba por Transferencia a Corral"), _
        TypeConverter(GetType(TiposMovimientosGanadoClass)), DisplayName("Salida de Reciba Por Transferencia a Corral"), _
        System.ComponentModel.Category("Salidas"), System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_Reciba_transferencia_A_corral() As String
        Get
            Return tms(TipoMovimientoGanadoEnum.SalidaRecibaXtransferenciaAcorral)
        End Get
        Set(ByVal Value As String)
            Dim opc As Integer = EstablecerValor(TipoMovimientoGanadoEnum.SalidaRecibaXtransferenciaAcorral, Value)

            If opc > -1 Then
                InvConfigProd.SalidaRecibaXtransferenciaAcorral = opc
            Else
                InvConfigProd.SalidaRecibaXtransferenciaAcorral = Nulo
                MsgBox("Este movimiento ya esta seleccionado en otro tipo de movimiento de ganado", MsgBoxStyle.Exclamation, "Movimiento ya saleccionado")
                'Throw New Exception("Este tipo de movimiento ya fue seleccionado.")
            End If
        End Set
    End Property

    Private Function EstablecerValor(ByVal Indice As Integer, ByVal Valor As String) As Integer
        Dim bl As Boolean = False

        For Each texto As String In tms
            If texto = Valor Then
                bl = True
                Exit For
            End If
        Next

        If Not bl Then
            tms(Indice) = Valor
            Return _tipos.Seleccionar(Valor).IdMovGanado
        Else
            tms(Indice) = Nothing
            Return -1
        End If
    End Function

    <System.ComponentModel.Browsable(False)> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function ObtenerTipoMovimiento(ByVal TipoMovimiento As TipoMovimientoGanadoEnum) As TipoMovimientoGanadoClass
        If Not IsNothing(tms(TipoMovimiento)) Then
            Return _tipos.Seleccionar(tms(TipoMovimiento))
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region " Metodos "
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Guardar() As Boolean
        Return InvConfigProd.Save
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Sub LeerEntidad(ByVal Entidad As Object) Implements IEntidad2.LeerEntidad
        InvConfigProd = Entidad
    End Sub

    Public Function ObtenerEntidad() As Object Implements IEntidad2.ObtenerEntidad
        Return InvConfigProd
    End Function
#End Region

#Region " Clases "
    Public Class TiposMovimientosGanadoClass
        Inherits StringConverter

        Private mTipos As New TipoMovimientoGanadoColeccionClass

        Public Sub New()
            MyBase.New()

            For Each tipo As TipoMovimientoGanadoClass In _tipos
                Dim b As Boolean = False
                For Each t As String In tms
                    If tipo.Nombre = t Then b = True
                Next
                If Not b Then mTipos.Add(tipo)
            Next
        End Sub

        Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            'True = Se despliega la lista
            'False = No se despliega la lista y el ususario debe escribir un valor
            Return True
        End Function

        Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As StandardValuesCollection
            Return New StandardValuesCollection(_tipos)
        End Function

        Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            'True = el combo no admite más items que los de la lista
            'False = el combo admite un item que no esté en la lista
            Return True
        End Function
    End Class
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

'************************************************************************
'*  ADECUACIONES
'************************************************************************

Public Class ProductoClass
    Inherits ProductoGeneralClass

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Codigo As Integer)
        MyBase.New(Codigo)
    End Sub

    Public Sub New(ByVal Clave As String)
        MyBase.New(Clave)
    End Sub

    Public Sub New(ByVal Entidad As IntegraLab.ORM.EntityClasses.ProductoEntity)
        MyBase.New(Entidad)
    End Sub
End Class

Public Class ConfiguracionProduccionClass
    Inherits ClassBase(Of EC.UsrProdConfiguracionEntity)

#Region "Miembros Privados"

    Private _AlmacenCortes As AlmacenClass
    Private _AlmacenCortesCongelado As AlmacenClass
    Private _AlmacenCanales As AlmacenClass
    Private _AlmacenDecomisos As AlmacenClass
    Private _AlmacenProductos As AlmacenClass
    Private _AlmacenValorAgregado As AlmacenClass
    Private _AlmacenValorAgregadoCongelado As AlmacenClass

#End Region

#Region "Constructores"

    Sub New()
        Me.Entity = New EC.UsrProdConfiguracionEntity
        Me.Entity.IdConfiguracion = 1
    End Sub

    Sub New(ByVal Entidad As EC.UsrProdConfiguracionEntity)
        Me.Entity = Entidad
        Me.Entity.IdConfiguracion = 1
    End Sub

    Sub New(ByVal Codigo As Integer)
        Me.Entity = New EC.UsrProdConfiguracionEntity(Codigo)
        Me.Entity.IdConfiguracion = 1
    End Sub

#End Region

#Region "Propiedades"

    Public Property IdConfiguracion() As Integer
        Get
            Return Me.Entity.IdConfiguracion
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdConfiguracion = value
        End Set
    End Property

    Public Property ObtenerPeso() As Boolean
        Get
            Return Me.Entity.ObtenerPeso
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.ObtenerPeso = value
        End Set
    End Property

    Public Property RecibirCanales() As Boolean
        Get
            Return Me.Entity.RecibirCanales
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.RecibirCanales = value
        End Set
    End Property

    Public Property EmbarcarMasDeUnCliente() As Boolean
        Get
            Return Me.Entity.Embarcarmasdeuncliente
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.Embarcarmasdeuncliente = value
        End Set
    End Property

    Public Property EmbarcarDiferentesProd() As Boolean
        Get
            Return Me.Entity.EmbarcarDiferentesProductos
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.EmbarcarDiferentesProductos = value
        End Set
    End Property

    Public Property ImprimirEtiquetasCortes() As Boolean
        Get
            Return Me.Entity.ImprimirEtiquetasCortes
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.ImprimirEtiquetasCortes = value
        End Set
    End Property

    Public Property ImprimirEtiquetasCanales() As Boolean
        Get
            Return Me.Entity.ImprimirEtiquetasCanales
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.ImprimirEtiquetasCanales = value
        End Set
    End Property

    Public Property ImprimirEtiquetasProductos() As Boolean
        Get
            Return Me.Entity.ImprimirEtiquetasProductos
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.ImprimirEtiquetasProductos = value
        End Set
    End Property

    Public Property LlenarCajasDifProductos() As Boolean
        Get
            Return Me.Entity.LlenarCajasDiferentesProductos
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.LlenarCajasDiferentesProductos = value
        End Set
    End Property

    Public Property ImprimirEtiquetasDifProd() As Boolean
        Get
            Return Me.Entity.ImprimirEtiquetaDiferentesProductos
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.ImprimirEtiquetaDiferentesProductos = value
        End Set
    End Property

    Public Property TrabajarLotesSacrificiosAbiertos() As Boolean
        Get
            Return Me.Entity.TrabajarLoteSacrificiosAbiertos
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.TrabajarLoteSacrificiosAbiertos = value
        End Set
    End Property

    Public Property TrabajarLotesCortesAbiertos() As Boolean
        Get
            Return Me.Entity.TrabajarLoteCortesAbiertos
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.TrabajarLoteCortesAbiertos = value
        End Set
    End Property

    Public Property IdAlmacenCanales() As Nullable(Of Integer)
        Get
            Return Me.Entity.IdAlmacenCanales
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Me.Entity.IdAlmacenCanales = value
        End Set
    End Property

    Public Property IdAlmacenesCortes() As Nullable(Of Integer)
        Get
            Return Me.Entity.IdAlmacenCortes
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Me.Entity.IdAlmacenCortes = value
        End Set
    End Property

    Public Property IdAlmacenProductos() As Nullable(Of Integer)
        Get
            Return Me.Entity.IdAlmacenProductos
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Me.Entity.IdAlmacenProductos = value
        End Set
    End Property

    Public Property IdAlmacenDecomisos() As Nullable(Of Integer)
        Get
            Return Me.Entity.IdAlmacenDecomisos
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Me.Entity.IdAlmacenDecomisos = value
        End Set
    End Property

    Public Property IdAlmacenCorteCongelado() As Nullable(Of Integer)
        Get
            Return Entity.IdAlmacenCorteCongelado
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdAlmacenCorteCongelado = value
        End Set
    End Property

    Public Property IdAlmacenValorAgregado() As Nullable(Of Integer)
        Get
            Return Entity.IdAlmacenValorAgregado
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdAlmacenValorAgregado = value
        End Set
    End Property

    Public Property IdAlmacenValorAgregadoCongelado() As Nullable(Of Integer)
        Get
            Return Entity.IdAlmacenValorAgregadoCongelado
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdAlmacenValorAgregadoCongelado = value
        End Set
    End Property

    Public Property DiasCaducidadProdCongelado() As Integer
        Get
            Return Entity.DiasCaducidadProdCongelado
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCaducidadProdCongelado = value
        End Set
    End Property

    Public Property TemperaturaProdCongelado() As Integer
        Get
            Return Entity.TemperaturaProdCongelado
        End Get
        Set(ByVal value As Integer)
            Entity.TemperaturaProdCongelado = value
        End Set
    End Property

    Public Property DiasCaducidadProdFresco() As Integer
        Get
            Return Entity.DiasCaducidadProdFresco
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCaducidadProdFresco = value
        End Set
    End Property

    Public Property TemperaturaProdFresco() As Integer
        Get
            Return Entity.TemperaturaProdFresco
        End Get
        Set(ByVal value As Integer)
            Entity.TemperaturaProdFresco = value
        End Set
    End Property

    Public Property TemperaturaValorAgregado() As Integer
        Get
            Return Entity.TemperaturaValorAgregado
        End Get
        Set(ByVal value As Integer)
            Entity.TemperaturaValorAgregado = value
        End Set
    End Property

    Public Property DiasCaducidadValorAgregado() As Integer
        Get
            Return Entity.DiasCaducidadValorAgregado
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCaducidadValorAgregado = value
        End Set
    End Property

    Public Property DiasCaducidadValorAgregadoCongelado() As Integer
        Get
            Return Entity.DiasCaducidadValorAgregadoCongelado
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCaducidadValorAgregadoCongelado = value
        End Set
    End Property

    Public Property TemperaturaValorAgregadoCongelado() As Integer
        Get
            Return Entity.TemperaturaValorAgregadoCongelado
        End Get
        Set(ByVal value As Integer)
            Entity.TemperaturaValorAgregadoCongelado = value
        End Set
    End Property

    Public Property DiasCaducidadHuesoFresco() As Integer
        Get
            Return Entity.DiasCaducidadHuesoFresco
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCaducidadHuesoFresco = value
        End Set
    End Property

    Public Property DiasCaducidadHuesoCongelado() As Integer
        Get
            Return Entity.DiasCaducidadHuesoCongelado
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCaducidadHuesoCongelado = value
        End Set
    End Property

    Public Property ObtenerCanalAutomaticamente() As Boolean
        Get
            Return Me.Entity.ObtenerCanalEntradaCanalAlmacen
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.ObtenerCanalEntradaCanalAlmacen = value
        End Set
    End Property

    ' se asgrego nueva propiedad para saber si el sistema permitira asociar mas de un lote de sacrificio al lote de corte
    Public Property LoteCorteAsociado() As Boolean
        Get
            Return Me.Entity.LoteCorteAsociadoaLotesSacrificio
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.LoteCorteAsociadoaLotesSacrificio = value
        End Set
    End Property

    Property Contraseña() As String
        Get
            Return Entity.ContraseñaEmb
        End Get
        Set(ByVal value As String)
            Entity.ContraseñaEmb = value
        End Set
    End Property

    Property IdTipoAlmacen() As Nullable(Of Integer)
        Get
            Return Entity.IdTipoAlmacen
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdTipoAlmacen = value
        End Set
    End Property

    Public Property TiempoEspera() As Integer
        Get
            Return Entity.TiempoEsperaSacrificio
        End Get
        Set(ByVal value As Integer)
            Entity.TiempoEsperaSacrificio = value
        End Set
    End Property

    Public Property PrecioEmbarque() As Boolean
        Get
            Return Entity.IncluirPrecioEmbarque
        End Get
        Set(ByVal value As Boolean)
            Entity.IncluirPrecioEmbarque = value
        End Set
    End Property

    Public Property HuesoFresco() As Integer
        Get
            Return Entity.DiasCaducidadHuesoFresco
        End Get
        Set(ByVal value As Integer)
            Entity.IncluirPrecioEmbarque = value
        End Set
    End Property

    Public Property ProductosDerivados() As Boolean
        Get
            Return Entity.ProductosDerivados
        End Get
        Set(ByVal value As Boolean)
            Entity.ProductosDerivados = value
        End Set
    End Property

    Public Property ReferenciarPrecioEmbarqueEnFacturacion() As Boolean
        Get
            Return Entity.ReferenciarPrecioEmbarqueEnFacturacion
        End Get
        Set(ByVal value As Boolean)
            Entity.ReferenciarPrecioEmbarqueEnFacturacion = value
        End Set
    End Property

    Public Property EsTIFLogo() As Boolean
        Get
            Return Entity.EsTiflogo
        End Get
        Set(ByVal value As Boolean)
            Entity.EsTiflogo = value
        End Set
    End Property

    Public ReadOnly Property AlmacenCortes() As AlmacenClass
        Get
            If Me.IdAlmacenesCortes.HasValue Then
                If _AlmacenCortes Is Nothing OrElse _AlmacenCortes.Codigo <> Me.IdAlmacenesCortes.Value Then
                    _AlmacenCortes = New AlmacenClass(Me.IdAlmacenesCortes.Value)
                End If
            Else
                _AlmacenCortes = Nothing
            End If
            Return _AlmacenCortes
        End Get
    End Property

    Public ReadOnly Property AlmacenCortesCongelado() As AlmacenClass
        Get
            If Me.IdAlmacenCorteCongelado.HasValue Then
                If _AlmacenCortesCongelado Is Nothing OrElse _AlmacenCortesCongelado.Codigo <> Me.IdAlmacenCorteCongelado.Value Then
                    _AlmacenCortesCongelado = New AlmacenClass(Me.IdAlmacenCorteCongelado.Value)
                End If
            Else
                _AlmacenCortesCongelado = Nothing
            End If
            Return _AlmacenCortesCongelado
        End Get
    End Property

    Public ReadOnly Property AlmacenCanales() As AlmacenClass
        Get
            If Me.IdAlmacenCanales.HasValue Then
                If _AlmacenCanales Is Nothing OrElse _AlmacenCanales.Codigo <> Me.IdAlmacenCanales.Value Then
                    _AlmacenCanales = New AlmacenClass(Me.IdAlmacenCanales.Value)
                End If
            Else
                _AlmacenCanales = Nothing
            End If
            Return _AlmacenCanales
        End Get
    End Property

    Public ReadOnly Property AlmacenDecomisos() As AlmacenClass
        Get
            If Me.IdAlmacenDecomisos.HasValue Then
                If _AlmacenDecomisos Is Nothing OrElse _AlmacenDecomisos.Codigo <> Me.IdAlmacenDecomisos.Value Then
                    _AlmacenDecomisos = New AlmacenClass(Me.IdAlmacenDecomisos.Value)
                End If
            Else
                _AlmacenDecomisos = Nothing
            End If
            Return _AlmacenDecomisos
        End Get
    End Property

    Public ReadOnly Property AlmacenProductos() As AlmacenClass
        Get
            If Me.IdAlmacenProductos.HasValue Then
                If _AlmacenProductos Is Nothing OrElse _AlmacenProductos.Codigo <> Me.IdAlmacenProductos.Value Then
                    _AlmacenProductos = New AlmacenClass(Me.IdAlmacenProductos.Value)
                End If
            Else
                _AlmacenProductos = Nothing
            End If
            Return _AlmacenProductos
        End Get
    End Property

    Public ReadOnly Property AlmacenValorAgregado() As AlmacenClass
        Get
            If Me.IdAlmacenValorAgregado.HasValue Then
                If _AlmacenValorAgregado Is Nothing OrElse _AlmacenValorAgregado.Codigo <> Me.IdAlmacenValorAgregado.Value Then
                    _AlmacenValorAgregado = New AlmacenClass(Me.IdAlmacenValorAgregado.Value)
                End If
            Else
                _AlmacenValorAgregado = Nothing
            End If
            Return _AlmacenValorAgregado
        End Get
    End Property

    Public ReadOnly Property AlmacenValorAgregadoCongelado() As AlmacenClass
        Get
            If Me.IdAlmacenValorAgregadoCongelado.HasValue Then
                If _AlmacenValorAgregadoCongelado Is Nothing OrElse _AlmacenValorAgregadoCongelado.Codigo <> Me.IdAlmacenValorAgregadoCongelado.Value Then
                    _AlmacenValorAgregadoCongelado = New AlmacenClass(Me.IdAlmacenValorAgregadoCongelado.Value)
                End If
            Else
                _AlmacenValorAgregadoCongelado = Nothing
            End If
            Return _AlmacenValorAgregadoCongelado
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Function Guardar() As Boolean
        Try
            Return Me.Entity.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.UsrProdConfiguracionEntity
        Return Me.Entity
    End Function

    Sub LeerEntidad(ByVal Entidad As EC.UsrProdConfiguracionEntity)
        Me.Entity = Entidad
    End Sub

#End Region

End Class

Public Class InventarioFisicoClass
    Inherits ClassBase(Of EC.InventarioFisicoEntity)

    Dim _UnidadMed As UnidadesMedidaClass
    Dim m_producto As ProductoClass
    Dim _producto As ProductoClass

#Region "Propiedades"

    Public Property AlmacenId() As Integer
        Get
            Return Entity.AlmacenId
        End Get
        Set(ByVal value As Integer)
            Entity.AlmacenId = value
        End Set
    End Property

    Public Property ProductoID() As Integer
        Get
            If ProductoID = 882 Then
                ProductoID = 882
            End If

            Return Entity.ProductoId
        End Get
        Set(ByVal value As Integer)
            Entity.ProductoId = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Cantidad = value
        End Set
    End Property

    Public Property CantidadSistema() As Nullable(Of Decimal)
        Get

            If CantidadSistema Is Nothing Then
                CantidadSistema = 0D
            End If


            Return Entity.CantidadSistema
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.CantidadSistema = value
        End Set
    End Property

    Public Property Existencia() As Decimal
        Get
            Return Entity.CantidadSistema
        End Get
        Set(ByVal value As Decimal)
            Entity.CantidadSistema = value
        End Set
    End Property

    Public Property Cantidadnull() As Nullable(Of Decimal)
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.Cantidad = value
        End Set
    End Property

    Public Property FechaInventario() As Date
        Get
            Return Entity.FechaInventario
        End Get
        Set(ByVal value As Date)
            Entity.FechaInventario = value
        End Set
    End Property

    Public ReadOnly Property PdDescripcion() As String
        Get
            If _producto Is Nothing Then
                _producto = New ProductoClass(Entity.Producto)
            End If
            Return _producto.Descripcion
        End Get
    End Property

    Public ReadOnly Property UMDescripcion() As String
        Get
            If _UnidadMed Is Nothing Then
                _UnidadMed = New UnidadesMedidaClass(Entity.Producto.UnidadMedida)
            End If
            Return _UnidadMed.Descripcion
        End Get
    End Property

    Public Function Obtener(ByVal IdAlmacen As Integer, ByVal IdProducto As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(IdAlmacen, IdProducto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Property Producto() As ProductoClass
        Get
            If m_Producto Is Nothing Then
                m_Producto = New ProductoClass(Entity.Producto)
            ElseIf Not m_producto.Codigo = ProductoID Then
                m_producto.LeerEntidad(Entity.Producto)
            End If

            Return m_Producto
        End Get
        Private Set(ByVal value As ProductoClass)
            m_Producto = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = m_Producto.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property CodProducto() As Integer
        Get
            If m_producto Is Nothing Then
                m_producto = New ProductoClass(Entity.Producto)
            ElseIf Not m_producto.Codigo = ProductoID Then
                m_producto.LeerEntidad(Entity.Producto)
            End If

            Return m_producto.Codigo
        End Get

    End Property
    Public ReadOnly Property DesProducto() As String
        Get
            If m_producto Is Nothing Then
                m_producto = New ProductoClass(Entity.Producto)
            ElseIf Not m_producto.Codigo = ProductoID Then
                m_producto.LeerEntidad(Entity.Producto)
            End If

            Return m_producto.Descripcion.ToUpper
        End Get

    End Property

    Public ReadOnly Property Diferencia() As Decimal
        Get
            If CantidadSistema Is Nothing Then
                CantidadSistema = 0D
            End If
            Return (Cantidad - CantidadSistema)
        End Get

    End Property
#End Region

#Region "Costructores"

    Sub New()
        Entity = New EC.InventarioFisicoEntity
    End Sub

    Sub New(ByVal Entidad As EC.InventarioFisicoEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal AlmacenId As Integer, ByVal ProductoId As Integer)
        Entity = New EC.InventarioFisicoEntity(AlmacenId, ProductoId)
    End Sub

#End Region

#Region "METODOS"
    Public Shadows Function Borrar(Optional ByVal Trans As HC.Transaction = Nothing) As Boolean
        Try
            'Me.Estatus = EstatusEnum.INACTIVO
            If Trans IsNot Nothing Then
                Trans.Add(Entity)
            End If

            If Entity.Delete Then
                Return True
            Else
                MsgBox("No se a logrado dar de baja el inventario, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se a logrado dar de baja el inventario, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function
#End Region

End Class

Public Class InventarioFisicoCollectionClass
    Inherits ColleccionBase(Of EC.InventarioFisicoEntity, CC.InventarioFisicoCollection, InventarioFisicoClass)

    Public Overloads Function Obtener(ByVal IdAlmacen As Integer) As Integer
        Try
            coleccion.GetMulti(HC.InventarioFisicoFields.AlmacenId = IdAlmacen)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class