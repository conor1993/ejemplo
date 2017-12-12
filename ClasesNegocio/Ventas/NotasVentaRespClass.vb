Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports System.Windows.Forms
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class NotaVentaRespClass
    Inherits ClassBase(Of EC.NotaVentaRespEntity)

#Region "Miembros"
    Dim _Func As String
    Dim _NumOpc As Integer
    Dim _Detalles As NotaVentaDetalleRespCollectionClass
    Dim _Sucursal As SucursalClass
    Dim _ControlTurno, _ControlTurnoCanc As ControlTurnoClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.NotaVentaRespEntity
        Entity.FechaCancelacion = "01/01/1900"
        'Entity.Cliente = 0
        'Entity.TipoVentaId = 0
    End Sub

    Sub New(ByVal ent As EC.NotaVentaRespEntity)
        Entity = ent
    End Sub
#End Region

#Region "Propiedades"
    Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    Property IdSucursal() As Integer
        Get
            Return Entity.Sucursal
        End Get
        Set(ByVal value As Integer)
            Entity.Sucursal = value
        End Set
    End Property

    Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing Then
                _Sucursal = New SucursalClass(Entity.Sucursal)
            End If
            Return _Sucursal
        End Get
        Set(ByVal value As SucursalClass)
            _Sucursal = value
            Entity.Sucursal = value.Codigo
        End Set
    End Property

    Property Estatus() As CondicionEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As CondicionEnum)
            Entity.Estatus = value
        End Set
    End Property

    Property Subtotal() As Decimal
        Get
            Return Entity.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.SubTotal = value
        End Set
    End Property

    Property Descuento() As Decimal
        Get
            Return Entity.Descuento
        End Get
        Set(ByVal value As Decimal)
            Entity.Descuento = value
        End Set
    End Property

    Property Total() As Decimal
        Get
            Return Entity.Total
        End Get
        Set(ByVal value As Decimal)
            Entity.Total = value
        End Set
    End Property

    Property FechaVenta() As Date
        Get
            Return Entity.FechaVenta
        End Get
        Set(ByVal value As Date)
            Entity.FechaVenta = value
        End Set
    End Property

    Property FechaCancelacion() As Nullable(Of System.DateTime)
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Nullable(Of System.DateTime))
            Entity.FechaCancelacion = value
        End Set
    End Property

    Property UsuarioAlta() As Integer
        Get
            Return Entity.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.UsuarioAlta = value
        End Set
    End Property

    Property UsuarioCancelacion() As Nullable(Of System.Int32)
        Get
            Return Entity.UsuarioCancelacion
        End Get
        Set(ByVal value As Nullable(Of System.Int32))
            Entity.UsuarioCancelacion = value
        End Set
    End Property

    Property MotivoCancelacion() As Nullable(Of System.Int32)
        Get
            Return Entity.MotivoCancelacion
        End Get
        Set(ByVal value As Nullable(Of System.Int32))
            Entity.MotivoCancelacion = value
        End Set
    End Property

    Public Property ObservacionesCancelacion() As String
        Get
            Return Entity.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesCancelacion = value
        End Set
    End Property

    Property IVA() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property

    Property IEPS() As Decimal
        Get
            Return Entity.Ieps
        End Get
        Set(ByVal value As Decimal)
            Entity.Ieps = value
        End Set
    End Property

    Property IdFactura() As Nullable(Of System.Int64)
        Get
            Return Entity.IdFactura
        End Get
        Set(ByVal value As Nullable(Of System.Int64))
            Entity.IdFactura = value
        End Set
    End Property

    Property PagoEfectivo() As Decimal
        Get
            Return Entity.PagoEfec
        End Get
        Set(ByVal value As Decimal)
            Entity.PagoEfec = value
        End Set
    End Property

    Property PagoTarjeta() As Decimal
        Get
            Return Entity.PagoTarj
        End Get
        Set(ByVal value As Decimal)
            Entity.PagoTarj = value
        End Set
    End Property

    Property Cambio() As Decimal
        Get
            Return Entity.Cambio
        End Get
        Set(ByVal value As Decimal)
            Entity.Cambio = value
        End Set
    End Property

    Property CodCaja() As Integer
        Get
            Return Entity.CodCaja
        End Get
        Set(ByVal value As Integer)
            Entity.CodCaja = value
        End Set
    End Property

    Property IdControlTurno() As Integer
        Get
            Return Entity.IdControlTurno
        End Get
        Set(ByVal value As Integer)
            Entity.IdControlTurno = value
        End Set
    End Property

    Property SerieFactura() As String
        Get
            Return Entity.SerieFact
        End Get
        Set(ByVal value As String)
            Entity.SerieFact = value
        End Set
    End Property

    Property FolioFactura() As String
        Get
            Return Entity.FolioFact
        End Get
        Set(ByVal value As String)
            Entity.FolioFact = value
        End Set
    End Property


    Property ControlTurno() As Integer
        Get
            'If _ControlTurno Is Nothing Then
            '    _ControlTurno = New ControlTurnoClass(Entity.IdControlTurno)
            'End If
            Return Entity.IdControlTurno
        End Get
        Set(ByVal value As Integer)
            Entity.IdControlTurno = value
        End Set
    End Property

    'Property ControlTurno() As ControlTurnoClass
    '    Get
    '        If _ControlTurno Is Nothing Then
    '            _ControlTurno = New ControlTurnoClass(Entity.IdControlTurno)
    '        End If
    '        Return _ControlTurno
    '    End Get
    '    Set(ByVal value As ControlTurnoClass)
    '        _ControlTurno = value
    '        Entity.IdControlTurno = value.Id
    '    End Set
    'End Property

    'Property ControlTurnoCanc() As ControlTurnoClass
    '    Get
    '        If _ControlTurnoCanc Is Nothing Then
    '            _ControlTurnoCanc = New ControlTurnoClass(Entity.control)
    '        End If
    '        Return _ControlTurnoCanc
    '    End Get
    '    Set(ByVal value As ControlTurnoClass)
    '        _ControlTurnoCanc = value
    '        Entity.IdControlTurnoCanc = value.Id
    '    End Set
    'End Property

    Property IdControlTurnoCanc() As Integer
        Get
            Return Entity.IdControlTurnoCanc
        End Get
        Set(ByVal value As Integer)
            Entity.IdControlTurnoCanc = value
        End Set
    End Property

    'Property Modif() As Boolean
    '    Get
    '        Return Entity.Mod
    '    End Get
    '    Set(ByVal value As Boolean)
    '        Entity.Mod = value
    '    End Set
    'End Property

    Public Property Detalles() As NotaVentaDetalleRespCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New NotaVentaDetalleRespCollectionClass()
                _Detalles.RellenarMe(Entity.MventaNotaVentaDetalleResp)

            End If
            Return _Detalles
        End Get
        Set(ByVal value As NotaVentaDetalleRespCollectionClass)
            _Detalles = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Long) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            trans.Add(Me.Entity)
            If Not Me.Entity.Save() Then
                Return False
            End If

            ' identifica el detalle con el código de la nota y graba los renglones
            'For Each det As NotaVentaDetalleRespClass In _Detalles
            '    'det.NotaVenta = Entity.Codigo
            '    trans.Add(det.Entidad)
            '    det.Entidad.Save()
            'Next

            ' ******************************************************
            ' * pendiente programar la salida de almacen por venta *
            ' ******************************************************
            Return True

        Catch ex As Exception
            'If MensajeError Is Nothing Then
            ' RaiseEvent MensajeError(ex.Message, "Error al guardar información de embarque")
            'Else
            Throw (ex)
            'End If
            Return False
        End Try
    End Function

    'Public Function Guardar2(ByVal trans As HC.Transaction) As Boolean
    '    Try
    '        trans.Add(Entity)

    '        Me.Entidad.Save()

    '        Dim DetalleCol As CC.NotaVentaDetalleCollection = Me.Detalles.ObtenerColeccion

    '        Dim DetallesBD As New CC.NotaVentaDetalleCollection

    '        trans.Add(DetallesBD)
    '        DetallesBD.GetMulti(HC.NotaVentaDetalleFields.NotaVenta = Me.Codigo)

    '        If DetallesBD.Count > 0 Then
    '            ' Se agregara otra coleccion para agregar los detalles que se van a guardar 
    '            Dim Encontro As Boolean
    '            Dim colNva As New CC.NotaVentaDetalleCollection

    '            For Each DetBd As EC.NotaVentaDetalleEntity In DetallesBD
    '                Encontro = False

    '                For Each det As EC.NotaVentaDetalleEntity In DetalleCol
    '                    If det.Producto = DetBd.Producto Then
    '                        Encontro = True

    '                        If Not PrecioEmbarque AndAlso det.Cantidad = DetBd.Cantidad Then
    '                            DetalleCol.Remove(det)

    '                            Dim cajas As New CC.MscloteCortesDetCollection
    '                            Dim caja As EC.MscloteCortesDetEntity

    '                            trans.Add(cajas)

    '                            cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = det.IdFolioEtiqueta)

    '                            If cajas.Count > 0 Then
    '                                caja = cajas(0)
    '                                caja.IdFolioEmbarque = Me.FolioEmbarque
    '                                caja.Save()
    '                            End If

    '                        ElseIf PrecioEmbarque AndAlso det.CantKgrs = DetBd.CantKgrs AndAlso det.CantPzas = DetBd.CantPzas AndAlso det.Precio.Value = DetBd.Precio.Value Then
    '                            DetalleCol.Remove(det)

    '                            Dim cajas As New CC.MscloteCortesDetCollection
    '                            Dim caja As EC.MscloteCortesDetEntity

    '                            trans.Add(cajas)

    '                            cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = det.IdFolioEtiqueta)

    '                            If cajas.Count > 0 Then
    '                                caja = cajas(0)
    '                                caja.IdFolioEmbarque = Me.FolioEmbarque
    '                                caja.Save()
    '                            End If
    '                        Else
    '                            det.IsNew = False
    '                            det.IsDirty = True

    '                            Dim movimientoAlmCan As New MovimientoAlmacenClass
    '                            Dim movimientoAlm As New MovimientoAlmacenClass
    '                            Dim Producto As New DecomisosClass(det.FolioSacrificio, det.IdProducto)
    '                            Dim DiferKilos As Decimal = det.CantKgrs - DetBd.CantKgrs
    '                            Dim DifPzas As Integer = det.CantPzas - DetBd.CantPzas
    '                            Dim prod As New EC.MsccatProductosEntity
    '                            Dim cajas As New CC.MscloteCortesDetCollection
    '                            Dim Precio As Decimal = 0D

    '                            trans.Add(prod)
    '                            trans.Add(cajas)

    '                            prod.FetchUsingPK(det.IdProducto)

    '                            If prod.Corte OrElse prod.ValorAgregado Then
    '                                cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = DetBd.IdFolioEtiqueta)

    '                                If cajas.Count = 0 Then
    '                                    MsgBox("No existe la caja con el folio de etiqueta " & DetBd.IdFolioEtiqueta, MsgBoxStyle.Exclamation, "Aviso")
    '                                    trans.Rollback()
    '                                    Return False
    '                                End If

    '                                movimientoAlmCan.IdAlmacen = cajas(0).IdAlmacenActual
    '                                'movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
    '                                movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta)

    '                                movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
    '                                movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Venta)
    '                            ElseIf prod.Canal Then
    '                                movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
    '                                movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta)

    '                                movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
    '                                movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Venta)
    '                            ElseIf prod.SubProducto OrElse (Not prod.SubProducto AndAlso Not prod.Corte AndAlso Not prod.Canal) Then
    '                                movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
    '                                movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta)

    '                                movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
    '                                movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Venta)
    '                            End If

    '                            If PrecioEmbarque And det.Precio.HasValue Then Precio = det.Precio

    '                            movimientoAlmCan.Estatus = EstatusChar.VIGENTE
    '                            movimientoAlmCan.FechaMovimiento = Me.FechaEmbarque
    '                            movimientoAlmCan.FolioMovmientoReferencia = det.IdFolioMovimientoAlmacen
    '                            movimientoAlmCan.IdPoliza = ""
    '                            movimientoAlmCan.Kilos = DetBd.CantKgrs
    '                            movimientoAlmCan.Piezas = DetBd.CantPzas
    '                            movimientoAlmCan.AgregarDetalle(det.IdProducto, DetBd.CantKgrs, DetBd.CantPzas, Precio, 0D)

    '                            movimientoAlm.Estatus = EstatusChar.VIGENTE
    '                            movimientoAlm.FechaMovimiento = Me.FechaEmbarque
    '                            movimientoAlm.IdPoliza = ""
    '                            movimientoAlm.Kilos = det.CantKgrs
    '                            movimientoAlm.Piezas = det.CantPzas
    '                            movimientoAlm.AgregarDetalle(det.IdProducto, det.CantKgrs, det.CantPzas, Precio, 0D)

    '                            If DiferKilos > 0 Then
    '                                Producto.KilosSalida += DiferKilos
    '                                'Inventario.ExistKilos += DiferKilos
    '                                'Inventario.EntKilos += DiferKilos
    '                            Else
    '                                Producto.KilosSalida -= DiferKilos
    '                                'Inventario.ExistKilos -= DiferKilos
    '                                'Inventario.SalKilos += DiferKilos
    '                            End If

    '                            If DifPzas > 0 Then
    '                                Producto.PiezasSalida += DifPzas
    '                            Else
    '                                Producto.PiezasSalida -= DifPzas
    '                            End If

    '                            'Guardar el producto
    '                            If Not Producto.Guardar(trans) Then
    '                                Return False
    '                            End If

    '                            If Not movimientoAlmCan.Guardar(trans) Then
    '                                trans.Rollback()
    '                                MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
    '                                Return False
    '                            End If

    '                            If Not movimientoAlm.Guardar(trans) Then
    '                                trans.Rollback()
    '                                MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
    '                                Return False
    '                            End If

    '                            det.IdFolioMovimientoAlmacen = movimientoAlm.FolioMovimiento
    '                            det.IsDirty = True
    '                        End If

    '                        Exit For
    '                    End If
    '                    'End Select
    '                Next

    '                If Not Encontro Then
    '                    Dim movimientoAlmCan As New MovimientoAlmacenClass
    '                    Dim Producto As New DecomisosClass(DetBd.FolioSacrificio, DetBd.IdProducto)
    '                    Dim mov As New MovimientoAlmacenClass
    '                    Dim prod As New EC.MsccatProductosEntity
    '                    Dim cajas As New CC.MscloteCortesDetCollection
    '                    Dim Precio As Decimal = 0D

    '                    trans.Add(prod)
    '                    trans.Add(cajas)

    '                    prod.FetchUsingPK(DetBd.IdProducto)

    '                    If prod.Corte OrElse prod.ValorAgregado Then
    '                        cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = DetBd.IdFolioEtiqueta)

    '                        If cajas.Count = 0 Then
    '                            MsgBox("No existe la caja con el folio de etiqueta " & DetBd.IdFolioEtiqueta, MsgBoxStyle.Exclamation, "Aviso")
    '                            trans.Rollback()
    '                            Return False
    '                        End If

    '                        movimientoAlmCan.IdAlmacen = cajas(0).IdAlmacenActual
    '                        'movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
    '                        movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta)
    '                    ElseIf prod.Canal Then
    '                        movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
    '                        movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta)
    '                    ElseIf prod.SubProducto OrElse (Not prod.SubProducto AndAlso Not prod.Corte AndAlso Not prod.Canal) Then
    '                        movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
    '                        movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta)
    '                    End If

    '                    If PrecioEmbarque AndAlso DetBd.Precio.HasValue Then Precio = DetBd.Precio

    '                    movimientoAlmCan.Estatus = EstatusChar.VIGENTE
    '                    movimientoAlmCan.FechaMovimiento = Me.FechaEmbarque
    '                    movimientoAlmCan.FolioMovmientoReferencia = DetBd.IdFolioMovimientoAlmacen
    '                    movimientoAlmCan.IdPoliza = ""
    '                    movimientoAlmCan.Kilos = DetBd.CantKgrs
    '                    movimientoAlmCan.Piezas = DetBd.CantPzas
    '                    movimientoAlmCan.AgregarDetalle(DetBd.IdProducto, DetBd.CantKgrs, DetBd.CantPzas, Precio, 0D)

    '                    Producto.KilosSalida -= DetBd.CantKgrs
    '                    Producto.KilosSalida -= DetBd.CantPzas

    '                    'Guardar el producto
    '                    If Not Producto.Guardar(trans) Then
    '                        Return False
    '                    End If

    '                    trans.Add(DetBd)

    '                    If Not DetBd.Delete Then
    '                        Return False
    '                    End If

    '                    If Not movimientoAlmCan.Guardar(trans) Then
    '                        trans.Rollback()
    '                        MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
    '                        Return False
    '                    End If
    '                End If
    '            Next


    '            For Each det As EC.NotaVentaDetalleEntity In DetalleCol
    '                If det.TipoProducto = TipoProductoEnum.CORTE Then
    '                    Dim movimientoAlm As New MovimientoAlmacenClass

    '                    With movimientoAlm
    '                        .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
    '                        .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Venta)
    '                        .Estatus = EstatusChar.VIGENTE
    '                        .FechaMovimiento = Me.FechaEmbarque
    '                        .IdPoliza = ""
    '                        .Kilos = det.CantKgrs
    '                        .Piezas = det.CantPzas
    '                        .AgregarDetalle(det.IdProducto, .Kilos, .Piezas, 0D, 0D)

    '                        If Not .Guardar(trans) Then
    '                            trans.Rollback()
    '                            MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
    '                            Return False
    '                        End If

    '                        det.IdFolioMovimientoAlmacen = .FolioMovimiento
    '                    End With

    '                    Dim cajas As New CC.MscloteCortesDetCollection
    '                    Dim caja As EC.MscloteCortesDetEntity

    '                    trans.Add(cajas)

    '                    cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = det.IdFolioEtiqueta)

    '                    If cajas.Count > 0 Then
    '                        caja = cajas(0)
    '                        caja.IdFolioEmbarque = Me.FolioEmbarque
    '                        caja.Save()
    '                    End If
    '                End If
    '            Next

    '            trans.Add(DetalleCol)
    '            DetalleCol.SaveMulti()
    '            Return True
    '        Else
    '            trans.Add(DetalleCol)
    '            DetalleCol.SaveMulti()
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        trans.Rollback()
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try
    'End Function

    Public Shadows Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Try
            Me.Estatus = CondicionEnum.INACTIVOS
            Trans.Add(Entity)
            Entity.Save()

            ' **********************************************
            ' * Pendiente programar movimientos de almacen *
            ' **********************************************

            'Dim ListaCod As New List(Of String)
            'Dim Lista2 As New List(Of String)
            'Dim _DetalleNota As CC.NotaVentaDetalleCollection = Me.Detalles.ObtenerColeccion

            'For Each Det As EC.NotaVentaDetalleEntity In _DetalleNota

            '    Dim movimientoAlmacen As New MovimientoAlmacenClass

            '    With movimientoAlmacen
            '        .Estatus = EstatusChar.VIGENTE
            '        .FechaMovimiento = Now
            '        .FolioMovmientoReferencia = Det.IdFolioMovimientoAlmacen
            '        .IdPoliza = ""
            '        .AgregarDetalle(Det.Producto, Det.Cantidad, Det.CantPzas, 0D, 0D)
            '    End With

            '    'Select Case Det.Producto_.TipoProducto
            '    '    Case TipoProductoEnum.CORTE
            '    '        ListaCod.Add(Det.IdFolioEtiqueta)
            '    '        cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = Det.IdFolioEtiqueta.Trim)

            '    '        If cajas.Count = 0 Then
            '    '            MsgBox("No se encuentra la caja con la etiqueta " & Det.IdFolioEtiqueta, MsgBoxStyle.Exclamation, "Aviso")
            '    '            Trans.Rollback()
            '    '            Return False
            '    '        End If

            '    '        movimientoAlmacen.IdAlmacen = cajas(0).IdAlmacenActual
            '    '        'movimientoAlmacen.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
            '    '        movimientoAlmacen.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta)
            '    '    Case TipoProductoEnum.CANAL
            '    '        Lista2.Add(Det.IdFolioEtiqueta)
            '    '        movimientoAlmacen.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
            '    '        movimientoAlmacen.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta)
            '    '    Case TipoProductoEnum.PRODUCTO
            '    '        Dim Prod As New DecomisosClass(Det.FolioSacrificio, Det.IdProducto)

            '            movimientoAlmacen.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
            '            movimientoAlmacen.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta)

            '            If Not Prod.Guardar(Trans) Then
            '                Trans.Rollback()
            '                Return False
            '            End If

            '            'Dim Inventario As New InventarioClass

            '            'Inventario.IdCodProducto = Det.IdProducto
            '            'Inventario.ExistKilos += Det.CantKgrs
            '            'Inventario.ExistPzas += Det.CantPzas
            '            'Inventario.EntKilos += Det.CantKgrs
            '            'Inventario.EntPzas += Det.CantPzas
            '            ''Inventario.SalKilos += Almacen.CantKilos
            '            ''Inventario.SalPzas += Almacen.CantPzas
            '            'Inventario.Func = "I"
            '            'Inventario.NumOpc = 2
            '            'Inventario.Año = Now.Year
            '            'Inventario.Mes = Now.Month

            '            ''clase para la modificacion de lotes de corte en el detalle
            '            ''llama el guardar del inventario de productos
            '            'If Not Inventario.Guardar(Trans) Then
            '            '    MessageBox.Show("Error al guardar en inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '            '    Trans.Rollback()
            '            '    Return False
            '            'End If
            '    'End Select

            '    If Not movimientoAlmacen.Guardar(Trans) Then
            '        Trans.Rollback()
            '        MsgBox("Ocurrio un error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
            '        Return False
            '    End If
            'Next

            'Trans.Add(_DetalleNota)
            '_DetalleNota.SaveMulti()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

End Class

Public Class NotaVentaDetalleRespClass
    Inherits ClassBase(Of EC.NotaVentaDetalleRespEntity)

#Region "Miembros"
    'Dim entity As EC.MfacEmbarquesDetEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Dim _Producto As ProductoGeneralClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
    Dim validar As Boolean = False
#End Region

#Region "Propiedades"
    Property Codigo() As Long
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Long)
            Entity.Codigo = value
        End Set
    End Property

    Property NotaVenta() As Long
        Get
            Return Entity.NotaVenta
        End Get
        Set(ByVal value As Long)
            Entity.NotaVenta = value
        End Set
    End Property

    Property IdProducto() As Integer
        Get
            Return Entity.Producto
        End Get
        Set(ByVal value As Integer)
            Entity.Producto = value
        End Set
    End Property

    Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Cantidad = value
        End Set
    End Property

    Public Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass()
                _Producto.Obtener(Entity.Producto)
            End If
            Return _Producto
        End Get
        Set(ByVal value As ProductoGeneralClass)
            _Producto = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return Entity.Precio
        End Get
        Set(ByVal value As Decimal)
            Entity.Precio = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Entity.Descuento
        End Get
        Set(ByVal value As Decimal)
            Entity.Descuento = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property

    Public Property IEPS() As Decimal
        Get
            Return Entity.Ieps
        End Get
        Set(ByVal value As Decimal)
            Entity.Ieps = value
        End Set
    End Property

    Property IdProductoCompuesto() As Integer
        Get
            Return Entity.IdProductoCompuesto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProductoCompuesto = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.NotaVentaDetalleRespEntity
    End Sub

    Sub New(ByVal Entidad As EC.NotaVentaDetalleRespEntity)
        Entity = Entidad
    End Sub

#End Region

#Region "Metodos"

    'Public Function ObtenerEtiqueta(ByVal Etiqueta_CodigoBarra As String) As DataSet
    '    Try
    '        Dim Query As String = "Select  IdFolioEtiqueta" & _
    '            ",Lcc.LoteCorte" & _
    '            ",(Select Descripcion From MSCCatProductos Where IdProducto=Lcd.IdCorte and PreCorte = 1) as Nom_Corte" & _
    '            ",(Select Descripcion From MSCCatProductos Where IdProducto=Lcd.IdProducto and (Corte = 1 or SubProducto = 1)) as Nom_SubCorte" & _
    '            ",CantPzas" & _
    '            ",CantKgrs" & _
    '            ",FechaCorte" & _
    '            ",FechaCad" & _
    '            " ,Case Lcd.Estatus When 1 Then 'VIGENTE'" & _
    '            " When 0 Then 'CANCELADA'" & _
    '            " End as Estatus" & _
    '            ",TotalPzas" & _
    '            ",TotalKgs" & _
    '            ",Lcd.IdCorte" & _
    '            ",Lcd.IdProducto, Lcd.IdCliente" & _
    '            " From MSCLoteCortesDet Lcd Inner Join MSCLoteCortesCab Lcc On Lcc.LoteCorte = Lcd.LoteCorte" & _
    '            " Where (Lcd.IdFolioEtiqueta = '" & Etiqueta_CodigoBarra & "' OR Lcd.CodigoBarra = '" & Etiqueta_CodigoBarra & "') AND Lcc.Estatus <> '0'" & _
    '            " AND Lcd.IdFolioEmbarque = '' AND Lcd.Estatus = 1"
    '        Dim da As New SqlClient.SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

    '        ObtenerEtiqueta = New DataSet
    '        da.Fill(ObtenerEtiqueta)
    '    Catch ex As Exception
    '        ObtenerEtiqueta = Nothing
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Function

    'Public Function ActualizarPrecio(ByVal IdCliente As Integer, ByVal IdDestino As Integer) As Double
    '    Select Case Me.TipoProducto
    '        Case TipoProductoEnum.CORTE
    '            Dim Corte As New CortesPreCortesClass(Me.IdProducto)
    '            Dim PrecioxCorte As New PrecioXcorteClass(IdCliente, IdDestino, Corte.CodPrecorte, Me.IdProducto)
    '            If PrecioxCorte IsNot Nothing Then ActualizarPrecio = PrecioxCorte.Precio
    '        Case Else
    '            Dim PrecioxProducto As New PrecioXProductoClass(IdCliente, IdDestino, Me.IdProducto)
    '            If PrecioxProducto IsNot Nothing Then ActualizarPrecio = PrecioxProducto.Precio
    '    End Select

    '    Entity.Precio = ActualizarPrecio
    '    Return ActualizarPrecio
    'End Function

#End Region
End Class

Public Class NotaVentaDetalleRespCollectionClass
    Inherits ColleccionBase(Of EC.NotaVentaDetalleRespEntity, CC.NotaVentaDetalleRespCollection, NotaVentaDetalleRespClass)

#Region "Miembros"
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"
    '''' <summary>
    '''' Obtiene o establece si al agregar un EmbarqueDetalle se agregara automaticamente a una sub coleccion de 
    '''' Canales/Cortes/Productos dependiendo el tipo de producto que tenga el EmbarqueDetalle
    '''' </summary>
    '''' <value>Boolean</value>
    '''' <returns>True: se separaran en sub colecciones. False: no se separaran en sub colecciones</returns>
    '''' <remarks></remarks>
    'Public Property SepararTipoProducto() As Boolean
    '    Get
    '        Return Me._SepararTipoProductos
    '    End Get
    '    Set(ByVal value As Boolean)
    '        Me._SepararTipoProductos = value
    '    End Set
    'End Property

    'Public ReadOnly Property Canales() As EmbarqueDetalleCollectionClass
    '    Get
    '        If _Canales Is Nothing Then
    '            _Canales = New EmbarqueDetalleCollectionClass
    '        End If

    '        Return _Canales
    '    End Get
    'End Property

    'Public ReadOnly Property Cortes() As EmbarqueDetalleCollectionClass
    '    Get
    '        If _Cortes Is Nothing Then
    '            _Cortes = New EmbarqueDetalleCollectionClass
    '        End If

    '        Return _Cortes
    '    End Get
    'End Property

    'Public ReadOnly Property Productos() As EmbarqueDetalleCollectionClass
    '    Get
    '        If _Productos Is Nothing Then
    '            _Productos = New EmbarqueDetalleCollectionClass
    '        End If

    '        Return _Productos
    '    End Get
    'End Property
#End Region

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As NotaVentaDetalleRespClass)
        MyBase.Add(item)
    End Sub

    Public Overloads Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Overloads Function ObtenerTotal(ByVal CodProdComp As Integer) As Integer
        Try
            Dim filtro As New OC.PredicateExpression
            filtro.Add(HC.NotaVentaDetalleRespFields.IdProductoCompuesto = CodProdComp)
            coleccion.GetMulti(filtro, 1)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Overloads Function ObtenerTotalVendidos(ByVal CodProdComp As Integer) As Integer
        Try
            Dim filtro As New OC.PredicateExpression
            filtro.Add(HC.NotaVentaDetalleRespFields.IdProductoCompuesto = CodProdComp)
            ''coleccion.GetMulti(filtro, 1)
            ''Rellenar()
            Return coleccion.GetDbCount(filtro)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Sub QuitarProducto(ByVal Codigo As Long)
        For i As Integer = 0 To Me.Count - 1
            If Trim(Me(i).Codigo) = Codigo Then
                Me.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Public Sub AgregarProducto(ByVal Detalle As NotaVentaDetalleRespClass)
        Me.Add(Detalle)
    End Sub
#End Region

#Region "Eventos"

#End Region
End Class


Public Class NotaVentaRespCollectionClass
    Inherits ColleccionBase(Of EC.NotaVentaRespEntity, CC.NotaVentaRespCollection, NotaVentaRespClass)

#Region "Miembros"
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"
#End Region

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As NotaVentaRespClass)
        MyBase.Add(item)
    End Sub

    Public Overloads Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function



    Public Sub QuitarNota(ByVal Codigo As Long)
        For i As Integer = 0 To Me.Count - 1
            If Trim(Me(i).Codigo) = Codigo Then
                Me.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Public Sub AgregarNota(ByVal Detalle As NotaVentaRespClass)
        Me.Add(Detalle)
    End Sub
#End Region

#Region "Eventos"
#End Region
End Class