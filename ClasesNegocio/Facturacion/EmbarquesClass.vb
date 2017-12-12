Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports System.Windows.Forms
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class EmbarquesClass
    Inherits ClassBase(Of EC.MfacEmbarquesCabEntity)

#Region "Miembros"
    Dim _Func As String
    Dim _NumOpc As Integer
    Dim _Detalles As EmbarqueDetalleCollectionClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
#End Region

#Region "Constructores"
    Sub New()
        entity = New EC.MfacEmbarquesCabEntity
        entity.FechaCancelacion = "01/01/1900"
    End Sub
#End Region

#Region "Propiedades"
    Property FolioEmbarque() As String
        Get
            Return Entity.IdFolioEmbarque
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("FolioEmbarque", "No se permite folio vacio")
                Throw New SystemException(" ")
            End If
            Entity.IdFolioEmbarque = value
        End Set
    End Property

    Property FechaEmbarque() As Date
        Get
            Return Entity.FechaEmbarque
        End Get
        Set(ByVal value As Date)
            Entity.FechaEmbarque = value
        End Set
    End Property

    Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property

    Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Property IdVehiculo() As Integer
        Get
            Return Entity.IdVehiculo
        End Get
        Set(ByVal value As Integer)
            Entity.IdVehiculo = value
        End Set
    End Property

    Property IdChofer() As Integer
        Get
            Return Entity.IdChofer
        End Get
        Set(ByVal value As Integer)
            Entity.IdChofer = value
        End Set
    End Property

    Property TotalPiezas() As Integer
        Get
            Return Entity.TotalPiezas
        End Get
        Set(ByVal value As Integer)
            Entity.TotalPiezas = value
        End Set
    End Property

    Property TotalKilos() As Decimal
        Get
            Return Entity.TotalKgrs
        End Get
        Set(ByVal value As Decimal)
            Entity.TotalKgrs = value
        End Set
    End Property

    Property IdEstado() As Integer
        Get
            Return Entity.IdEstado
        End Get
        Set(ByVal value As Integer)
            Entity.IdEstado = value
        End Set
    End Property

    Property IdCiudad() As Integer
        Get
            Return Entity.IdCiudad
        End Get
        Set(ByVal value As Integer)
            Entity.IdCiudad = value
        End Set
    End Property

    Property IdPoblacion() As Integer
        Get
            Return Entity.IdPoblacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoblacion = value
        End Set
    End Property

    Property IdPuntoEntrega() As Integer
        Get
            Return Entity.IdPuntoEntrega
        End Get
        Set(ByVal value As Integer)
            Entity.IdPuntoEntrega = value
        End Set
    End Property

    Property TotalCajas() As Integer
        Get
            Return Entity.TotalCajas
        End Get
        Set(ByVal value As Integer)
            Entity.TotalCajas = value
        End Set
    End Property

    Property IdFolioMovimiento() As String
        Get
            Return Entity.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimiento = value
        End Set
    End Property

    Property NoFactura() As String
        Get
            Return Entity.NoFactura
        End Get
        Set(ByVal value As String)
            Entity.NoFactura = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return Entity.FolioEmbarqueEmp
        End Get
        Set(ByVal value As String)
            Entity.FolioEmbarqueEmp = value
        End Set
    End Property

    Property IdUsuarioAutorizo() As Short
        Get
            Return Entity.IdUsuarioAutorizo.GetValueOrDefault(-1)
        End Get
        Set(ByVal value As Short)
            Entity.IdUsuarioAutorizo = value
        End Set
    End Property

    Public Property Detalles() As EmbarqueDetalleCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New EmbarqueDetalleCollectionClass
                _Detalles.RellenarMe(Entity.EmbarquesDet)
            End If
            Return _Detalles
        End Get
        Set(ByVal value As EmbarqueDetalleCollectionClass)
            _Detalles = value
        End Set
    End Property
    'propiedad para asignar cuando el embarque sea para clientes varios 
    Public Property IdClienteAsignado() As Integer
        Get
            Return Entity.IdClienteAsignado
        End Get
        Set(ByVal value As Integer)
            Entity.IdClienteAsignado = value
        End Set
    End Property

    Public Property Exportacion() As Boolean
        Get
            Return Entity.Exportacion
        End Get
        Set(ByVal value As Boolean)
            Entity.Exportacion = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal FolioEmbarque As String) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(FolioEmbarque)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Property Estatus() As EstatusCharX
        Get
            Return Asc(Entity.Estatus)
        End Get
        Set(ByVal value As EstatusCharX)
            Entity.Estatus = Chr(value)
        End Set
    End Property

    Public Overloads Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            trans.Add(Me.Entidad)
            Return Me.Entidad.Save()
        Catch ex As Exception
            RaiseEvent MensajeError(ex.Message, "Error al guardar información de embarque")
            Return False
        End Try
    End Function

    Public Function Guardar2(ByVal PrecioEmbarque As Boolean, ByVal trans As HC.Transaction) As Boolean
        Try
            trans.Add(Entity)

            Me.TotalPiezas = 0
            Me.TotalKilos = 0
            Me.TotalCajas = 0

            For Each det As EmbarqueDetalleClass In Me.Detalles
                Me.TotalPiezas += det.CantPzas
                Me.TotalKilos += det.CantKgrs

                If Not det.IdFolioEtiqueta.Trim = "" Then
                    Me.TotalCajas += 1
                End If
            Next

            Me.Entidad.Save()

            Dim DetalleCol As CC.MfacEmbarquesDetCollection = Me.Detalles.ObtenerColeccion


            Dim DetallesBD As New CC.MfacEmbarquesDetCollection

            trans.Add(DetallesBD)
            DetallesBD.GetMulti(HC.MfacEmbarquesDetFields.IdFolioEmbarque = Me.FolioEmbarque)

            If DetallesBD.Count > 0 Then
                ' Se agregara otra coleccion para agregar los detalles que se van a guardar 
                Dim Encontro As Boolean
                ' Dim pos As Integer = DetallesBD(DetallesBD.Count - 1).Renglon + 1
                Dim colNva As New CC.MfacEmbarquesDetCollection

                For Each DetBd As EC.MfacEmbarquesDetEntity In DetallesBD
                    Encontro = False

                    For Each det As EC.MfacEmbarquesDetEntity In DetalleCol
                        'Select Case det.TipoProducto
                        'Case TipoProductoEnum.CORTE
                        If det.IdFolioEtiqueta = DetBd.IdFolioEtiqueta And det.IdProducto = DetBd.IdProducto Then
                            Encontro = True

                            If Not PrecioEmbarque AndAlso det.CantKgrs = DetBd.CantKgrs AndAlso det.CantPzas = DetBd.CantPzas Then
                                DetalleCol.Remove(det)

                                Dim cajas As New CC.MscloteCortesDetCollection
                                Dim caja As EC.MscloteCortesDetEntity

                                trans.Add(cajas)

                                cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = det.IdFolioEtiqueta)

                                If cajas.Count > 0 Then
                                    caja = cajas(0)
                                    caja.IdFolioEmbarque = Me.FolioEmbarque
                                    caja.Save()
                                End If
                            ElseIf PrecioEmbarque AndAlso det.CantKgrs = DetBd.CantKgrs AndAlso det.CantPzas = DetBd.CantPzas AndAlso det.Precio.Value = DetBd.Precio.Value Then
                                DetalleCol.Remove(det)

                                Dim cajas As New CC.MscloteCortesDetCollection
                                Dim caja As EC.MscloteCortesDetEntity

                                trans.Add(cajas)

                                cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = det.IdFolioEtiqueta)

                                If cajas.Count > 0 Then
                                    caja = cajas(0)
                                    caja.IdFolioEmbarque = Me.FolioEmbarque
                                    caja.Save()
                                End If
                            Else
                                det.IsNew = False
                                det.IsDirty = True

                                Dim movimientoAlmCan As New MovimientoAlmacenClass
                                Dim movimientoAlm As New MovimientoAlmacenClass
                                Dim Producto As New DecomisosClass(det.FolioSacrificio, det.IdProducto)
                                Dim DiferKilos As Decimal = det.CantKgrs - DetBd.CantKgrs
                                Dim DifPzas As Integer = det.CantPzas - DetBd.CantPzas
                                Dim prod As New EC.MsccatProductosEntity
                                Dim cajas As New CC.MscloteCortesDetCollection
                                Dim Precio As Decimal = 0D

                                trans.Add(prod)
                                trans.Add(cajas)

                                prod.FetchUsingPK(det.IdProducto)

                                If prod.Corte OrElse prod.ValorAgregado Then
                                    cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = DetBd.IdFolioEtiqueta)

                                    If cajas.Count = 0 Then
                                        MsgBox("No existe la caja con el folio de etiqueta " & DetBd.IdFolioEtiqueta, MsgBoxStyle.Exclamation, "Aviso")
                                        trans.Rollback()
                                        Return False
                                    End If

                                    movimientoAlmCan.IdAlmacen = cajas(0).IdAlmacenActual
                                    'movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                                    movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta)

                                    movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                                    movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Venta)
                                ElseIf prod.Canal Then
                                    movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
                                    movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta)

                                    movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
                                    movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Venta)
                                ElseIf prod.SubProducto OrElse (Not prod.SubProducto AndAlso Not prod.Corte AndAlso Not prod.Canal) Then
                                    movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
                                    movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta)

                                    movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
                                    movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Venta)
                                End If

                                If PrecioEmbarque And det.Precio.HasValue Then Precio = det.Precio

                                movimientoAlmCan.Estatus = EstatusChar.VIGENTE
                                movimientoAlmCan.FechaMovimiento = Me.FechaEmbarque
                                movimientoAlmCan.FolioMovmientoReferencia = det.IdFolioMovimientoAlmacen
                                movimientoAlmCan.IdPoliza = ""
                                movimientoAlmCan.Kilos = DetBd.CantKgrs
                                movimientoAlmCan.Piezas = DetBd.CantPzas
                                movimientoAlmCan.AgregarDetalle(det.IdProducto, DetBd.CantKgrs, DetBd.CantPzas, Precio, 0D)

                                movimientoAlm.Estatus = EstatusChar.VIGENTE
                                movimientoAlm.FechaMovimiento = Me.FechaEmbarque
                                movimientoAlm.IdPoliza = ""
                                movimientoAlm.Kilos = det.CantKgrs
                                movimientoAlm.Piezas = det.CantPzas
                                movimientoAlm.AgregarDetalle(det.IdProducto, det.CantKgrs, det.CantPzas, Precio, 0D)

                                If DiferKilos > 0 Then
                                    Producto.KilosSalida += DiferKilos
                                    'Inventario.ExistKilos += DiferKilos
                                    'Inventario.EntKilos += DiferKilos
                                Else
                                    Producto.KilosSalida -= DiferKilos
                                    'Inventario.ExistKilos -= DiferKilos
                                    'Inventario.SalKilos += DiferKilos
                                End If

                                If DifPzas > 0 Then
                                    Producto.PiezasSalida += DifPzas
                                Else
                                    Producto.PiezasSalida -= DifPzas
                                End If

                                'Guardar el producto
                                If Not Producto.Guardar(trans) Then
                                    Return False
                                End If

                                If Not movimientoAlmCan.Guardar(trans) Then
                                    trans.Rollback()
                                    MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
                                    Return False
                                End If

                                If Not movimientoAlm.Guardar(trans) Then
                                    trans.Rollback()
                                    MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
                                    Return False
                                End If

                                det.IdFolioMovimientoAlmacen = movimientoAlm.FolioMovimiento
                                det.IsDirty = True
                            End If

                            Exit For
                        End If
                        'End Select
                    Next

                    If Not Encontro Then
                        Dim movimientoAlmCan As New MovimientoAlmacenClass
                        Dim Producto As New DecomisosClass(DetBd.FolioSacrificio, DetBd.IdProducto)
                        Dim mov As New MovimientoAlmacenClass
                        Dim prod As New EC.MsccatProductosEntity
                        Dim cajas As New CC.MscloteCortesDetCollection
                        Dim Precio As Decimal = 0D

                        trans.Add(prod)
                        trans.Add(cajas)

                        prod.FetchUsingPK(DetBd.IdProducto)

                        If prod.Corte OrElse prod.ValorAgregado Then
                            cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = DetBd.IdFolioEtiqueta)

                            If cajas.Count = 0 Then
                                MsgBox("No existe la caja con el folio de etiqueta " & DetBd.IdFolioEtiqueta, MsgBoxStyle.Exclamation, "Aviso")
                                trans.Rollback()
                                Return False
                            End If

                            movimientoAlmCan.IdAlmacen = cajas(0).IdAlmacenActual
                            'movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                            movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta)
                        ElseIf prod.Canal Then
                            movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
                            movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta)
                        ElseIf prod.SubProducto OrElse (Not prod.SubProducto AndAlso Not prod.Corte AndAlso Not prod.Canal) Then
                            movimientoAlmCan.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
                            movimientoAlmCan.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta)
                        End If

                        If PrecioEmbarque AndAlso DetBd.Precio.HasValue Then Precio = DetBd.Precio

                        movimientoAlmCan.Estatus = EstatusChar.VIGENTE
                        movimientoAlmCan.FechaMovimiento = Me.FechaEmbarque
                        movimientoAlmCan.FolioMovmientoReferencia = DetBd.IdFolioMovimientoAlmacen
                        movimientoAlmCan.IdPoliza = ""
                        movimientoAlmCan.Kilos = DetBd.CantKgrs
                        movimientoAlmCan.Piezas = DetBd.CantPzas
                        movimientoAlmCan.AgregarDetalle(DetBd.IdProducto, DetBd.CantKgrs, DetBd.CantPzas, Precio, 0D)

                        Producto.KilosSalida -= DetBd.CantKgrs
                        Producto.KilosSalida -= DetBd.CantPzas

                        'Guardar el producto
                        If Not Producto.Guardar(trans) Then
                            Return False
                        End If

                        trans.Add(DetBd)

                        If Not DetBd.Delete Then
                            Return False
                        End If

                        If Not movimientoAlmCan.Guardar(trans) Then
                            trans.Rollback()
                            MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        End If
                    End If
                Next


                For Each det As EC.MfacEmbarquesDetEntity In DetalleCol
                    If det.TipoProducto = TipoProductoEnum.CORTE Then
                        Dim movimientoAlm As New MovimientoAlmacenClass

                        With movimientoAlm
                            .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                            .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Venta)
                            .Estatus = EstatusChar.VIGENTE
                            .FechaMovimiento = Me.FechaEmbarque
                            .IdPoliza = ""
                            .Kilos = det.CantKgrs
                            .Piezas = det.CantPzas
                            .AgregarDetalle(det.IdProducto, .Kilos, .Piezas, 0D, 0D)

                            If Not .Guardar(trans) Then
                                trans.Rollback()
                                MsgBox("Error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
                                Return False
                            End If

                            det.IdFolioMovimientoAlmacen = .FolioMovimiento
                        End With

                        Dim cajas As New CC.MscloteCortesDetCollection
                        Dim caja As EC.MscloteCortesDetEntity

                        trans.Add(cajas)

                        cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = det.IdFolioEtiqueta)

                        If cajas.Count > 0 Then
                            caja = cajas(0)
                            caja.IdFolioEmbarque = Me.FolioEmbarque
                            caja.Save()
                        End If
                    End If
                Next

                trans.Add(DetalleCol)
                DetalleCol.SaveMulti()
                Return True
            Else
                trans.Add(DetalleCol)
                DetalleCol.SaveMulti()
                Return True
            End If
        Catch ex As Exception
            trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shadows Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Try
            'Me.Embarque.Estatus = "X"
            Trans.Add(Entity)
            Entity.Save()

            Dim CortesDet As New EC.MscloteCortesDetEntity
            Dim _CortesDetCol As New CC.MscloteCortesDetCollection
            Dim ListaCod As New List(Of String)
            Dim Lista2 As New List(Of String)
            Dim _DetalleEmbarques As CC.MfacEmbarquesDetCollection = Me.Detalles.ObtenerColeccion
            Dim _RecepCanalesDetCol As New CC.MscrecepcionCanalesDetCollection
            Dim _RecepCanalesDet As New EC.MscrecepcionCanalesDetEntity
            Dim cajas As New CC.MscloteCortesDetCollection

            Trans.Add(cajas)
            CortesDet.IdFolioEmbarque = ""
            _RecepCanalesDet.Estatus = "V"

            For Each Det As EC.MfacEmbarquesDetEntity In _DetalleEmbarques
                Det.Estatus = "X"

                Dim movimientoAlmacen As New MovimientoAlmacenClass

                With movimientoAlmacen
                    .Estatus = EstatusChar.VIGENTE
                    .FechaMovimiento = Now
                    .FolioMovmientoReferencia = Det.IdFolioMovimientoAlmacen
                    .IdPoliza = ""
                    .Kilos = Det.CantKgrs
                    .Piezas = Det.CantPzas
                    .AgregarDetalle(Det.IdProducto, Det.CantKgrs, Det.CantPzas, 0D, 0D)
                End With

                Select Case Det.TipoProducto
                    Case TipoProductoEnum.CORTE
                        ListaCod.Add(Det.IdFolioEtiqueta)
                        cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = Det.IdFolioEtiqueta.Trim)

                        If cajas.Count = 0 Then
                            MsgBox("No se encuentra la caja con la etiqueta " & Det.IdFolioEtiqueta, MsgBoxStyle.Exclamation, "Aviso")
                            Trans.Rollback()
                            Return False
                        End If

                        movimientoAlmacen.IdAlmacen = cajas(0).IdAlmacenActual
                        'movimientoAlmacen.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                        movimientoAlmacen.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Venta)
                    Case TipoProductoEnum.CANAL
                        Lista2.Add(Det.IdFolioEtiqueta)
                        movimientoAlmacen.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
                        movimientoAlmacen.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Venta)
                    Case TipoProductoEnum.PRODUCTO
                        Dim Prod As New DecomisosClass(Det.FolioSacrificio, Det.IdProducto)

                        movimientoAlmacen.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
                        movimientoAlmacen.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Producto_X_Cancelacion_Venta)
                        Prod.KilosSalida -= Det.CantKgrs
                        Prod.PiezasSalida -= Det.CantPzas

                        If Not Prod.Guardar(Trans) Then
                            Trans.Rollback()
                            Return False
                        End If

                        'Dim Inventario As New InventarioClass

                        'Inventario.IdCodProducto = Det.IdProducto
                        'Inventario.ExistKilos += Det.CantKgrs
                        'Inventario.ExistPzas += Det.CantPzas
                        'Inventario.EntKilos += Det.CantKgrs
                        'Inventario.EntPzas += Det.CantPzas
                        ''Inventario.SalKilos += Almacen.CantKilos
                        ''Inventario.SalPzas += Almacen.CantPzas
                        'Inventario.Func = "I"
                        'Inventario.NumOpc = 2
                        'Inventario.Año = Now.Year
                        'Inventario.Mes = Now.Month

                        ''clase para la modificacion de lotes de corte en el detalle
                        ''llama el guardar del inventario de productos
                        'If Not Inventario.Guardar(Trans) Then
                        '    MessageBox.Show("Error al guardar en inventario", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    Trans.Rollback()
                        '    Return False
                        'End If
                End Select

                If Not movimientoAlmacen.Guardar(Trans) Then
                    Trans.Rollback()
                    MsgBox("Ocurrio un error al guardar el movimiento de almacén", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Next

            Trans.Add(_DetalleEmbarques)
            _DetalleEmbarques.SaveMulti()

            Dim rango As OC.FieldCompareRangePredicate
            Dim rango2 As OC.FieldCompareRangePredicate

            If ListaCod.Count > 0 Then
                rango = New OC.FieldCompareRangePredicate(HC.MscloteCortesDetFields.IdFolioEtiqueta, ListaCod)
                Trans.Add(_CortesDetCol)
                _CortesDetCol.UpdateMulti(CortesDet, rango)
            End If

            If Lista2.Count > 0 Then
                rango2 = New OC.FieldCompareRangePredicate(HC.MscrecepcionCanalesDetFields.CodigoBarra, Lista2)
                Trans.Add(_RecepCanalesDetCol)
                _RecepCanalesDetCol.UpdateMulti(_RecepCanalesDet, rango2)
            End If

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
End Class

Public Class EmbarqueDetalleClass
    Inherits ClassBase(Of EC.MfacEmbarquesDetEntity)

#Region "Miembros"
    'Dim entity As EC.MfacEmbarquesDetEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Dim _Producto As ProductosClass
    Dim _LoteCorte As String
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
    Dim piezasMax As Decimal
    Dim KilosMax As Decimal
    Dim validar As Boolean = False
#End Region

#Region "Constructores"
    Sub New()
        entity = New EC.MfacEmbarquesDetEntity
    End Sub

    Sub New(ByVal Entidad As EC.MfacEmbarquesDetEntity)
        entity = Entidad
    End Sub

    Sub New(ByVal IdFolioEmbarque As String, ByVal Renglon As Integer)
        Me.New(New EC.MfacEmbarquesDetEntity(IdFolioEmbarque, Renglon))
    End Sub
#End Region

#Region "Propiedades"
    Property IdFolioEmbarque() As String
        Get
            Return entity.IdFolioEmbarque
        End Get
        Set(ByVal value As String)
            entity.IdFolioEmbarque = value
        End Set
    End Property

    Property Renglon() As Integer
        Get
            Return entity.Renglon
        End Get
        Set(ByVal value As Integer)
            entity.Renglon = value
        End Set
    End Property

    Property IdFolioEtiqueta() As String
        Get
            Return entity.IdFolioEtiqueta
        End Get
        Set(ByVal value As String)
            entity.IdFolioEtiqueta = value
        End Set
    End Property

    Property IdProducto() As String
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As String)
            entity.IdProducto = value
        End Set
    End Property

    Property CantPzas() As Integer
        Get
            Return entity.CantPzas
        End Get
        Set(ByVal value As Integer)
            If ValidarLimites AndAlso value > Me.PiezasMaximas Then
                MsgBox("No hay piezas suficientes para embarcar", MsgBoxStyle.Exclamation, "Aviso")
                entity.CantPzas = Me.PiezasMaximas
            Else
                entity.CantPzas = value
            End If
        End Set
    End Property

    Property CantKgrs() As Decimal
        Get
            Return entity.CantKgrs
        End Get
        Set(ByVal value As Decimal)
            If ValidarLimites AndAlso value > Me.kilosMaximos Then
                MsgBox("No hay kilos suficiente para embarcar", MsgBoxStyle.Exclamation, "Aviso")
                entity.CantKgrs = Me.kilosMaximos
            Else
                entity.CantKgrs = value
            End If
        End Set
    End Property

    Public Property Estatus() As EstatusCharX
        Get
            Return Asc(entity.Estatus)
        End Get
        Set(ByVal value As EstatusCharX)
            entity.Estatus = Chr(value)
        End Set
    End Property

    Public Property TipoProducto() As TipoProductoEnum
        Get
            Return Entity.TipoProducto
        End Get
        Set(ByVal value As TipoProductoEnum)
            entity.TipoProducto = value
        End Set
    End Property

    Public Property Factura() As String
        Get
            Return entity.NoFactura
        End Get
        Set(ByVal value As String)
            entity.NoFactura = value
        End Set
    End Property

    Property FolioSacrificio() As String
        Get
            Return entity.FolioSacrificio
        End Get
        Set(ByVal value As String)
            entity.FolioSacrificio = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductosClass
                _Producto.Obtener(entity.IdProducto)
            End If
            Return _Producto.Descripcion
        End Get
        Set(ByVal value As String)
            _Producto = New ProductosClass
            _Producto.Descripcion = value
        End Set
    End Property

    Public Property LoteCorte() As String
        Get
            Return _LoteCorte
        End Get
        Set(ByVal value As String)
            _LoteCorte = value
        End Set
    End Property

    Public Property PiezasMaximas() As Decimal
        Get
            Return Me.piezasMax
        End Get
        Set(ByVal value As Decimal)
            Me.piezasMax = value
        End Set
    End Property

    Public Property kilosMaximos() As Decimal
        Get
            Return Me.KilosMax
        End Get
        Set(ByVal value As Decimal)
            Me.KilosMax = value
        End Set
    End Property

    Public Property ValidarLimites() As Boolean
        Get
            Return Me.validar
        End Get
        Set(ByVal value As Boolean)
            Me.validar = value
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return Entity.Precio
        End Get
        Set(ByVal value As Double)
            Entity.Precio = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function ObtenerEtiqueta(ByVal Etiqueta_CodigoBarra As String) As DataSet
        Try
            Dim Query As String = "Select  IdFolioEtiqueta" & _
                ",Lcc.LoteCorte" & _
                ",(Select Descripcion From MSCCatProductos Where IdProducto=Lcd.IdCorte and PreCorte = 1) as Nom_Corte" & _
                ",(Select Descripcion From MSCCatProductos Where IdProducto=Lcd.IdProducto and (Corte = 1 or SubProducto = 1)) as Nom_SubCorte" & _
                ",CantPzas" & _
                ",CantKgrs" & _
                ",FechaCorte" & _
                ",FechaCad" & _
                " ,Case Lcd.Estatus When 1 Then 'VIGENTE'" & _
                " When 0 Then 'CANCELADA'" & _
                " End as Estatus" & _
                ",TotalPzas" & _
                ",TotalKgs" & _
                ",Lcd.IdCorte" & _
                ",Lcd.IdProducto, Lcd.IdCliente" & _
                " From MSCLoteCortesDet Lcd Inner Join MSCLoteCortesCab Lcc On Lcc.LoteCorte = Lcd.LoteCorte" & _
                " Where (Lcd.IdFolioEtiqueta = '" & Etiqueta_CodigoBarra & "' OR Lcd.CodigoBarra = '" & Etiqueta_CodigoBarra & "') AND Lcc.Estatus <> '0'" & _
                " AND Lcd.IdFolioEmbarque = '' AND Lcd.Estatus = 1"
            Dim da As New SqlClient.SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

            ObtenerEtiqueta = New DataSet
            da.Fill(ObtenerEtiqueta)
        Catch ex As Exception
            ObtenerEtiqueta = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function ActualizarPrecio(ByVal IdCliente As Integer, ByVal IdDestino As Integer) As Double
        Select Case Me.TipoProducto
            Case TipoProductoEnum.CORTE
                Dim Corte As New CortesPreCortesClass(Me.IdProducto)
                Dim PrecioxCorte As New PrecioXcorteClass(IdCliente, IdDestino, Corte.CodPrecorte, Me.IdProducto)
                If PrecioxCorte IsNot Nothing Then ActualizarPrecio = PrecioxCorte.Precio
            Case Else
                Dim PrecioxProducto As New PrecioXProductoClass(IdCliente, IdDestino, Me.IdProducto)
                If PrecioxProducto IsNot Nothing Then ActualizarPrecio = PrecioxProducto.Precio
        End Select

        Entity.Precio = ActualizarPrecio
        Return ActualizarPrecio
    End Function

#End Region
End Class

Public Class EmbarqueDetalleCollectionClass
    Inherits ColleccionBase(Of EC.MfacEmbarquesDetEntity, CC.MfacEmbarquesDetCollection, EmbarqueDetalleClass)

#Region "Miembros"
    Dim _Canales As EmbarqueDetalleCollectionClass
    Dim _Cortes As EmbarqueDetalleCollectionClass
    Dim _Productos As EmbarqueDetalleCollectionClass
    Private _SepararTipoProductos As Boolean = False
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece si al agregar un EmbarqueDetalle se agregara automaticamente a una sub coleccion de 
    ''' Canales/Cortes/Productos dependiendo el tipo de producto que tenga el EmbarqueDetalle
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>True: se separaran en sub colecciones. False: no se separaran en sub colecciones</returns>
    ''' <remarks></remarks>
    Public Property SepararTipoProducto() As Boolean
        Get
            Return Me._SepararTipoProductos
        End Get
        Set(ByVal value As Boolean)
            Me._SepararTipoProductos = value
        End Set
    End Property

    Public ReadOnly Property Canales() As EmbarqueDetalleCollectionClass
        Get
            If _Canales Is Nothing Then
                _Canales = New EmbarqueDetalleCollectionClass
            End If

            Return _Canales
        End Get
    End Property

    Public ReadOnly Property Cortes() As EmbarqueDetalleCollectionClass
        Get
            If _Cortes Is Nothing Then
                _Cortes = New EmbarqueDetalleCollectionClass
            End If

            Return _Cortes
        End Get
    End Property

    Public ReadOnly Property Productos() As EmbarqueDetalleCollectionClass
        Get
            If _Productos Is Nothing Then
                _Productos = New EmbarqueDetalleCollectionClass
            End If

            Return _Productos
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As EmbarqueDetalleClass)
        MyBase.Add(item)

        If Me.SepararTipoProducto Then
            If item.Entidad.MsccatProductos.Canal Then
                Me.Canales.Add(item)
            ElseIf item.Entidad.MsccatProductos.Corte Then
                Me.Cortes.Add(item)
            ElseIf item.Entidad.MsccatProductos.SubProducto OrElse (Not item.Entidad.MsccatProductos.Corte AndAlso Not item.Entidad.MsccatProductos.Canal AndAlso Not item.Entidad.MsccatProductos.SubProducto) Then
                Me.Productos.Add(item)
            End If
        End If
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

    Public Sub QuitarProducto(ByVal Etiqueta As String, ByVal IdProducto As String)
        For i As Integer = 0 To Me.Count - 1
            If Trim(Me(i).IdFolioEtiqueta) = Etiqueta And Me(i).IdProducto = IdProducto Then
                Me.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Public Sub AgregarProducto(ByVal Detalle As EmbarqueDetalleClass)
        Me.Add(Detalle)
    End Sub
#End Region

#Region "Eventos"

#End Region
End Class