Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures

Public Class OrdenCompraClass
    Inherits ClassBase(Of EC.OrdenCompraEntity)

#Region "Miembros"

    Private _Sucursal As SucursalClass
    Private _Proveedor As ProveedorClass
    Private _UsuarioAlta As UsuarioClass
    Private _UsuarioCancelacion As UsuarioClass
    Private _Cotizacion As CotizacionCompraClass
    Private _Detalle As OrdenCompraDetalleCollectionClass
    Private _Moneda As TipoMonedaClass

#End Region

#Region "Propiedades"

    Public ReadOnly Property FolioOrdenCompra() As String
        Get
            Return Entidad.FolioOrdenCompra
        End Get
    End Property

    Public ReadOnly Property IdOrdenCompra() As Integer
        Get
            Return Entidad.IdOrdenCompra
        End Get
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return Entidad.IdSucursal
        End Get
        Set(ByVal value As Integer)
            Entidad.IdSucursal = value
        End Set
    End Property

    Public ReadOnly Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing OrElse _Sucursal.Codigo <> Me.IdSucursal Then
                _Sucursal = New SucursalClass(Entidad.Sucursal)
            End If
            Return _Sucursal
        End Get
    End Property

    Public Property IdProveedor() As Integer
        Get
            Return Entidad.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entidad.IdProveedor = value
        End Set
    End Property

    Public ReadOnly Property Proveedor() As ProveedorClass
        Get
            If _Proveedor Is Nothing OrElse _Proveedor.Codigo <> Me.IdProveedor Then
                _Proveedor = New ProveedorClass(Entidad.Proveedor)
            End If
            Return _Proveedor
        End Get
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entidad.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entidad.IdUsuarioAlta = value
        End Set
    End Property

    <ComponentModel.DisplayName("Usuario de Alta")> _
    Public ReadOnly Property UsuarioAlta() As UsuarioClass
        Get
            If _UsuarioAlta Is Nothing OrElse _UsuarioAlta.Codigo <> Me.IdUsuarioAlta Then
                _UsuarioAlta = New UsuarioClass(Entidad.IdUsuarioAlta)
            End If
            Return _UsuarioAlta
        End Get
    End Property

    Public Property IdUsuarioCancelacion() As Nullable(Of Integer)
        Get
            Return Entidad.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entidad.IdUsuarioCancelacion = value
        End Set
    End Property

    Public ReadOnly Property UsuarioCancelacion() As UsuarioClass
        Get
            If _UsuarioCancelacion Is Nothing OrElse Me.IdUsuarioCancelacion.HasValue AndAlso _UsuarioCancelacion.Codigo <> Me.IdUsuarioCancelacion.Value Then
                _UsuarioCancelacion = New UsuarioClass(Entidad.IdUsuarioCancelacion.Value)
            End If
            Return _UsuarioCancelacion
        End Get
    End Property

    Public Property Observaciones() As String
        Get
            Return Entidad.Observaciones
        End Get
        Set(ByVal value As String)
            Entidad.Observaciones = value
        End Set
    End Property

    Public Property DiasCredito() As Integer
        Get
            Return Entidad.DiasCredito
        End Get
        Set(ByVal value As Integer)
            Entidad.DiasCredito = value
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

    Public Property FechaOrdenCompra() As DateTime
        Get
            Return Entity.FechaOrdenCompra
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaOrdenCompra = value
        End Set
    End Property

    Public Property FechaCancelacion() As Nullable(Of Date)
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return Entidad.Importe
        End Get
        Set(ByVal value As Decimal)
            Entidad.Importe = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Entidad.Descuento
        End Get
        Set(ByVal value As Decimal)
            Entidad.Descuento = value
        End Set
    End Property

    Public Property SubTotal() As Decimal
        Get
            Return Entidad.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Entidad.SubTotal = value
        End Set
    End Property

    Public Property IVAPor() As Decimal
        Get
            Return Entidad.IvaPor
        End Get
        Set(ByVal value As Decimal)
            Entidad.IvaPor = value
        End Set
    End Property

    Public Property IVATotal() As Decimal
        Get
            Return Entity.IvaTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.IvaTotal = value
        End Set
    End Property

    Public Property Total() As Decimal
        Get
            Return Entidad.Total
        End Get
        Set(ByVal value As Decimal)
            Entidad.Total = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As OrdenCompraDetalleCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New OrdenCompraDetalleCollectionClass
                _Detalle.RellenarMe(Entidad.OrdenCompraDetalle)
            End If
            Return _Detalle
        End Get
    End Property

    Public Property IvaFlete() As Decimal
        Get
            Return Entidad.IvaFlete
        End Get
        Set(ByVal value As Decimal)
            Entidad.IvaFlete = value
        End Set
    End Property

    Public Property ImpteIvaFlete() As Decimal
        Get
            Return Entidad.ImpteIvaFlete
        End Get
        Set(ByVal value As Decimal)
            Entidad.ImpteIvaFlete = value
        End Set
    End Property

    Public Property Autorizada() As Boolean
        Get
            Return Entidad.Autorizada
        End Get
        Set(ByVal value As Boolean)
            Entidad.Autorizada = value
        End Set
    End Property

    Public Property FechaAutorizacion() As Nullable(Of Date)
        Get
            Return Entidad.FechaAutorizacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entidad.FechaAutorizacion = value
        End Set
    End Property

    Public Property FechaRecibida() As Nullable(Of Date)
        Get
            Return Entidad.FechaRecepcion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entidad.FechaRecepcion = value
        End Set
    End Property

    Public Property Recibida() As EstatusOrdenRecibida
        Get
            Return CType(Entidad.Recibida, EstatusOrdenRecibida)
        End Get
        Set(ByVal value As EstatusOrdenRecibida)
            Me.Entidad.Recibida = CType(value, Byte)
        End Set
    End Property

    Public Property Estatus() As EstatusOrdenCompra
        Get
            Return CType(Me.Entidad.Estatus, EstatusOrdenCompra)
        End Get
        Set(ByVal value As EstatusOrdenCompra)
            Me.Entidad.Estatus = CType(value, Byte)
        End Set
    End Property

    Public Property EsDirecta() As Boolean
        Get
            Return Entity.EsDirecta
        End Get
        Set(ByVal value As Boolean)
            Entity.EsDirecta = value
        End Set
    End Property

    Public Property IdMoneda() As Integer
        Get
            Return Entity.IdMoneda
        End Get
        Set(ByVal value As Integer)
            Entity.IdMoneda = value
        End Set
    End Property

    Public Property TipoCambio() As Decimal
        Get
            Return Entity.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            Entity.TipoCambio = value
        End Set
    End Property

    Public ReadOnly Property Moneda() As TipoMonedaClass
        Get
            If _Moneda Is Nothing Then
                _Moneda = New TipoMonedaClass(Entity.TipoMoneda)
            End If
            Return _Moneda
        End Get
    End Property

#End Region

#Region "Metodos"
    'Public Function Reporte() As crEmisionOrdenCompra
    '    Dim report As New crEmisionOrdenCompra
    '    Dim datos As New DataSet
    '    Dim tabla As New EmisionOrdenCompra.DataTable1DataTable
    '    For Each Orden As OrdenCompraClass In Me
    '        tabla.AddDataTable1Row(Orden.Folio, Orden.Sucursal.Codigo, Orden.ObtenerEntidad.Sucursal.Descripcion, Orden.Proveedor.Codigo, Orden.Proveedor.RazonSocial, Orden.FechaAlta, Orden.Importe, Orden.Descuento, Orden.SubTotal, Orden.IVA, Orden.Total, Orden.ObtenerEntidad)
    '    Next
    'End Function

    Public Shadows Function Borrar(ByVal Trans As HC.Transaction) As Boolean

        Try

            Select Case Estatus
                'Case EstatusOrdenCompra.AUTORIZADO
                '    Estatus = EstatusOrdenCompra.VIGENTE
                '    Autorizada = False
                'Case EstatusOrdenCompra.EMITIDA
                '    Estatus = EstatusOrdenCompra.VIGENTE
                '    Autorizada = False
                Case EstatusOrdenCompra.FACTURADA
                    Estatus = EstatusOrdenCompra.VIGENTE
                    Autorizada = False
                Case EstatusOrdenCompra.FINIQUITADO
                    Estatus = EstatusOrdenCompra.VIGENTE
                    Autorizada = False
                Case EstatusOrdenCompra.VIGENTE
                    Estatus = EstatusOrdenCompra.CANCELADO
                    Autorizada = False
            End Select

            Trans.Add(Entidad)

            'guardo cabecero de orden
            If Not Entidad.Save Then
                Trans.Rollback()
                MsgBox("No se logro cancelar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Shadows Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        If Entidad.IsNew Then
            If Detalle.Count = 0 Then
                MsgBox("Debe agregar productos a la orden de compra", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Trans.Add(Me.Entidad)
            Me.Entidad.Save()

            Dim col As CC.OrdenCompraDetalleCollection = Detalle.ObtenerColeccion

            Trans.Add(col)

            'guardo los detalles de la orden de compra
            If col.SaveMulti = 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Trans.Add(Me.Entidad)
            Me.Entidad.Save()
            Dim Col As CC.OrdenCompraDetalleCollection = Detalle.ObtenerColeccion
            Trans.Add(Col)
            Col.SaveMulti()
        End If
        Return True
    End Function

    Public Function GuardarDirecta(ByVal Trans As HC.Transaction) As Boolean
        Try
            If Entidad.IsNew Then
                If Detalle.Count = 0 Then
                    MsgBox("Debe agregar productos a la orden de compra", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                'Guardo cabecero de la orden de compra
                Trans.Add(Me.Entidad)
                Me.Entidad.Save()

                Dim col As CC.OrdenCompraDetalleCollection = Detalle.ObtenerColeccion

                'guardo los detalles de la orden de compra
                Trans.Add(col)
                col.SaveMulti()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Friend Function GuardarIngrediente(ByVal Trans As HC.Transaction) As Boolean
        If Entidad.IsNew Then
            'Guardo cabecero de la orden de compra
            Me.FechaRecibida = Now
            Me.FechaAutorizacion = Me.FechaRecibida

            Trans.Add(Me.Entidad)
            Me.Entidad.Save()

            Dim col As CC.OrdenCompraDetalleCollection = Detalle.ObtenerColeccion

            'guardo los detalles de la orden de compra
            Trans.Add(col)
            col.SaveMulti()
            Return True
        End If
    End Function

    Public Function Obtener(ByVal IdOrdenCompra As Integer) As Boolean
        Try
            Return Entidad.FetchUsingPK(IdOrdenCompra)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    'Public Function Obtener2(ByVal FolioOrdenCompra As String) As Boolean
    '    Try
    '        Return Entidad.FetchUsingPK(FolioOrdenCompra)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        Return False
    '    End Try
    'End Function

#End Region

#Region "Constructores"
    Sub New()
        Me.Entity = New EC.OrdenCompraEntity
    End Sub

    Sub New(ByVal Entidad As EC.OrdenCompraEntity)
        Me.Entity = Entidad
    End Sub

    Sub New(ByVal IdOrdenCompra As Integer)
        Try
            Me.Entity = New EC.OrdenCompraEntity(IdOrdenCompra)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub New(ByVal IdProveedor As Integer, ByVal IdProducto As Integer, ByVal Cantidad As Decimal)
        'Inicializar Cabecero
        Entidad = New EC.OrdenCompraEntity()
        IdProveedor = IdProveedor
        Estatus = EstatusRecepcionOrden.VIGENTE
        Autorizada = True

        'Inicializar Detalle
        Detalle.Add(New OrdenCompraDetalleClass())
        Detalle(0).IdProducto = IdProducto
        Detalle(0).CantidadOrdenada = Cantidad
        Detalle(0).CantidadSolicitada = Cantidad
        Detalle(0).CantRecibida = Cantidad
        Detalle(0).Estatus = EstatusEnum.ACTIVO
        Detalle(0).Precio = 0
        Detalle(0).Descuento = 0
        Detalle(0).Importe = 0
        Detalle(0).IdOrdenCompra = Me.IdOrdenCompra
    End Sub
#End Region

End Class

Public Class OrdenCompraDetalleClass
    Inherits ClassBase(Of EC.OrdenCompraDetalleEntity)

#Region "Miembros"

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) ' Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) ' Implements IEntidad.Modificado
    Private _Orden As OrdenCompraClass
    Private _Producto As ProductoGeneralClass
    Private _Moneda As TipoMonedaClass
    'variables agregadas el 28/07/2010
    Private _Cotizacion As CotizacionCompraClass
    Private _Solicitud As SolicitudProductoClass
    Private PorcIva As Decimal

#End Region

#Region "Propiedades"

    Public ReadOnly Property FolioOrdenCompra() As String
        Get
            Return _Orden.FolioOrdenCompra
        End Get
    End Property

    Public Property IdOrdenCompra() As Integer
        Get
            Return Entidad.IdOrdenCompra
        End Get
        Set(ByVal value As Integer)
            Entidad.IdOrdenCompra = value
        End Set
    End Property

    Public ReadOnly Property OrdenCompra() As OrdenCompraClass
        Get
            If _Orden Is Nothing OrElse _Orden.IdOrdenCompra <> Me.IdOrdenCompra Then
                _Orden = New OrdenCompraClass(Entidad.OrdenCompra)
            End If
            Return _Orden
        End Get
    End Property

    Public Property IdProducto() As Integer
        Get
            Return Entidad.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entidad.IdProducto = value
        End Set
    End Property

    Public ReadOnly Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing OrElse _Producto.Codigo <> Me.IdProducto Then
                _Producto = New ProductoGeneralClass(Entidad.Producto)
            End If
            Return _Producto
        End Get
    End Property

    Public ReadOnly Property ProductoNombre() As String
        Get
            Return Producto.Descripcion
        End Get
    End Property

    <ComponentModel.DisplayName("Cantidad Solicitada")> _
    Public Property CantidadSolicitada() As Decimal
        Get
            Return Entidad.CantidadSolicitada
        End Get
        Set(ByVal value As Decimal)
            Entidad.CantidadSolicitada = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cantidad Ordenada")> _
    Public Property CantidadOrdenada() As Decimal
        Get
            Return Entidad.CantidadOrdenar
        End Get
        Set(ByVal value As Decimal)
            Entidad.CantidadOrdenar = value
        End Set
    End Property

    <ComponentModel.DisplayName("Unidad")> _
    Public ReadOnly Property UnidadMedida() As String
        Get
            Return Producto.UnidadMedida.DescCorta
        End Get
    End Property

    Public Property IdMoneda() As Integer
        Get
            Return Entidad.IdMoneda
        End Get
        Set(ByVal value As Integer)
            Entidad.IdMoneda = value
        End Set
    End Property

    Public ReadOnly Property Moneda() As TipoMonedaClass
        Get
            If _Moneda Is Nothing OrElse _Moneda.Codigo <> Me.IdMoneda Then
                _Moneda = New TipoMonedaClass(Me.Entidad.TipoMoneda)
            End If
            Return _Moneda
        End Get
    End Property

    Public Property TipoCambio() As Decimal
        Get
            Return Entidad.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            Entidad.TipoCambio = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return Entidad.Precio
        End Get
        Set(ByVal value As Decimal)
            Entidad.Precio = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Entidad.Descuento
        End Get
        Set(ByVal value As Decimal)
            Entidad.Descuento = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return Entidad.Importe
        End Get
        Set(ByVal value As Decimal)
            Entidad.Importe = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return CType(Entidad.Estatus, EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entidad.Estatus = CType(value, Byte)
        End Set
    End Property

    Public Sub CalcularImporte(ByVal Iva As Decimal)
        Dim Imp As Decimal = Me.Precio * Me.CantidadOrdenada

        PorcIva = Iva
        If Me.Descuento <> 0 And Imp <> 0 Then
            Imp -= Imp * (Descuento / 100)
        End If

        'If Me.Producto.SeAplicaIva = AsignadaEnum.SI Then
        '   If Iva > 0 Then
        '       Imp += Imp * (Iva / 100) + Imp * (Me.Producto.PorcIEPS / 100)
        '   End If
        'End If
        If Me.Producto.SeAplicaIva = AsignadaEnum.SI And Iva > 0 Then
            Imp += (Imp * (Iva / 100)) + (Imp * (Me.Producto.PorcIEPS / 100))
        End If

        Me.Importe = Imp
    End Sub

    Public ReadOnly Property Iva() As Decimal
        Get
            If Me.Producto.SeAplicaIva = AsignadaEnum.SI Then
                Dim Var As Decimal
                'Var = (precio * cantidadordenada) - ((Precio * CantidadOrdenada) * (Descuento / 100))
                'Return Importe - Var '(Importe + Me.Descuento) - (Me.Precio * Me.CantidadOrdenada)
                Var = Precio * (1 - (Descuento / 100))
                Return Var * (PorcIva / 100) * CantidadOrdenada
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property Ieps() As Decimal
        Get
            If Me.Producto.PorcIEPS > 0 Then
                Dim Var As Decimal
                Var = Precio * (1 - (Descuento / 100))
                Return Var * (Me.Producto.PorcIEPS / 100) * Me.CantidadOrdenada
            Else
                Return 0
            End If
        End Get
    End Property

    Public Property CantPendiente() As Decimal
        Get
            Return Me.Entidad.CantPendientexRecibir
        End Get
        Set(ByVal value As Decimal)
            Me.Entidad.CantPendientexRecibir = value
        End Set
    End Property

    Public Property CantRecibida() As Decimal
        Get
            Return Me.Entidad.CantRecibida
        End Get
        Set(ByVal value As Decimal)
            Me.Entidad.CantRecibida = value
        End Set
    End Property

    'propiedades agregadas el 28/07/2010
    Public Property IdCotizacion() As Nullable(Of Integer)
        Get
            Return Entidad.IdCotizacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entidad.IdCotizacion = value
        End Set
    End Property

    Public ReadOnly Property Cotizacion() As CotizacionCompraClass
        Get
            If _Cotizacion Is Nothing OrElse (Me.IdCotizacion.HasValue AndAlso _Cotizacion.IdCotizacion <> Me.IdCotizacion.Value) Then
                _Cotizacion = New CotizacionCompraClass(Entidad.IdCotizacion.Value)
            End If
            Return _Cotizacion
        End Get
    End Property

    Public Property IdSolicitud() As Nullable(Of Integer)
        Get
            Return Entidad.IdSolicitud
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entidad.IdSolicitud = value
        End Set
    End Property

    Public ReadOnly Property Solicitud() As SolicitudProductoClass
        Get
            If _Solicitud Is Nothing OrElse (Me.IdSolicitud.HasValue AndAlso _Solicitud.IdSolicitud <> Me.IdSolicitud.Value) Then
                _Solicitud = New SolicitudProductoClass(Entidad.IdSolicitud.Value)
            End If
            Return _Solicitud
        End Get
    End Property

    'Propiedada Agregada el 09/08/2010
    Public Property Renglon() As Integer
        Get
            Return Entidad.IdDetalle
        End Get
        Set(ByVal value As Integer)
            Entidad.IdDetalle = value
        End Set
    End Property

    Public ReadOnly Property DescImporte() As Decimal
        Get
            If Me.Descuento <> 0D Then
                Return (Me.CantidadOrdenada * Me.Precio) * Me.Descuento / 100
            End If
            Return 0D
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Trans.Add(Entidad)
            Return Me.Entidad.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal IdOrdenCompra As Integer, ByVal IdProducto As Integer, ByVal IdDetalle As Integer) As Boolean
        Try
            Return Me.Entidad.FetchUsingPK(IdOrdenCompra, IdProducto, IdDetalle)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region

#Region "Constructores"

    Sub New()
        Entidad = New EC.OrdenCompraDetalleEntity
        Me.CantidadOrdenada = 0
        Me.CantRecibida = 0
        Me.CantPendiente = 0
    End Sub

    Sub New(ByVal IdDetalle As Integer, ByVal IdOrdenCompra As Integer, ByVal IdProducto As Integer)
        Entidad = New EC.OrdenCompraDetalleEntity(IdDetalle, IdOrdenCompra, IdProducto)
    End Sub

    Sub New(ByVal Entidad As EC.OrdenCompraDetalleEntity)
        Me.Entidad = Entidad
    End Sub

#End Region

End Class

Public Class OrdenCompraCollectionClass
    Inherits ColleccionBase(Of EC.OrdenCompraEntity, CC.OrdenCompraCollection, OrdenCompraClass)

    'Public Function Obtener2(ByVal IdOrdenCompra As I) As Integer
    '    Try
    '        Dim Filtro As New OC.PredicateExpression
    '        If Not IdOrdenCompra Is Nothing Then
    '            Filtro.Add(HC.OrdenCompraFields.IdOrdenCompra = IdOrdenCompra.IdOrdenCompra)
    '        End If
    '        Rellenar()
    '        Return Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        Return -1
    '    End Try
    'End Function

    Public Function Obtener(ByVal FcCondicion As CondicionEnum, Optional ByVal Plaza As PlazaClass = Nothing, Optional ByVal Sucursal As SucursalClass = Nothing, Optional ByVal Proveedor As ProveedorClass = Nothing, Optional ByVal Actorizadas As CondicionAsignadaEnum = CondicionAsignadaEnum.TODOS, Optional ByVal Recibidas As CondicionOrdenRecibida = CondicionOrdenRecibida.TODOS) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not Actorizadas = CondicionAsignadaEnum.TODOS Then
                Filtro.Add(HC.OrdenCompraFields.Autorizada = Actorizadas)
            End If

            If Not Recibidas = CondicionOrdenRecibida.NOYPARCIAL Then
                Filtro.Add(HC.OrdenCompraFields.Recibida = Recibidas)
            End If

            If Recibidas = CondicionOrdenRecibida.NOYPARCIAL Then
                Filtro.Add(HC.OrdenCompraFields.Recibida = CondicionOrdenRecibida.NO Or HC.OrdenCompraFields.Recibida = CondicionOrdenRecibida.PARCIAL)
            End If
            If Not FcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.OrdenCompraFields.Estatus = FcCondicion)
            End If

            If Not Proveedor Is Nothing Then
                Filtro.Add(HC.OrdenCompraFields.IdProveedor = Proveedor.Codigo)
            End If

            Dim Relacion As OC.RelationCollection = Nothing

            If Not Plaza Is Nothing Then
                If Sucursal Is Nothing Then
                    Relacion = New OC.RelationCollection
                    Relacion.Add(EC.OrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal)
                    'For Each suc As SucursalClass In Plaza.Sucursales
                    Filtro.Add(HC.SucursalFields.CodigoPlaza = Plaza.Codigo)
                    ' Next
                Else
                    Filtro.Add(HC.OrdenCompraFields.IdSucursal = Sucursal.Codigo)
                End If
            End If

            If Relacion Is Nothing Then
                coleccion.GetMulti(Filtro)
            Else
                coleccion.GetMulti(Filtro, Relacion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

End Class

Public Class OrdenCompraDetalleCollectionClass
    Inherits ColleccionBase(Of EC.OrdenCompraDetalleEntity, CC.OrdenCompraDetalleCollection, OrdenCompraDetalleClass)

End Class