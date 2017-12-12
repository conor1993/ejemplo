Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses

''' <summary>
''' Clase que Guarda, Actualiza, Borra y Obtiene un Detalle de una Lista de Precios
''' </summary>
''' <remarks></remarks>
Public Class ListaPrecioDetalleClass
    Implements IEntidad

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private _Detalle As EC.ListaPrecioDetalleEntity
    Private _ListaPrecio As ListaPrecioClass
    Private _Producto As ProductoGeneralClass

#Region "Propiedades"

    ''' <summary>
    ''' Obtiene o establece la lista de precios del detalle
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Lista de Precios"), ComponentModel.DataObjectField(True, False, False)> _
    Public Property ListaPrecio() As ListaPrecioClass
        Get
            If _ListaPrecio Is Nothing Then
                _ListaPrecio = New ListaPrecioClass
            End If
            _ListaPrecio.LeerEntidad(_Detalle.ListaPrecio)
            Return _ListaPrecio
        End Get
        Set(ByVal value As ListaPrecioClass)
            _Detalle.ListaPrecio = value.ObtenerEntidad
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el producto del Detalle
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>

    <ComponentModel.DisplayName("Producto"), ComponentModel.DataObjectField(True, False, False)> _
    Public ReadOnly Property NomProducto() As String
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass
            End If
            _Producto.LeerEntidad(_Detalle.Producto_)
            Return _Producto.Descripcion
        End Get
    End Property

    <ComponentModel.DisplayName("Producto"), ComponentModel.DataObjectField(True, False, False)> _
    Public ReadOnly Property CodProducto() As Integer
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass
            End If
            _Producto.LeerEntidad(_Detalle.Producto_)
            Return _Producto.Codigo
        End Get
    End Property

    <ComponentModel.DisplayName("Producto"), ComponentModel.DataObjectField(True, False, False)> _
    Public Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass
            End If
            _Producto.LeerEntidad(_Detalle.Producto_)
            Return _Producto
        End Get
        Set(ByVal value As ProductoGeneralClass)
            _Detalle.Producto_ = value.ObtenerEntidad
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo del Producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Costo"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property Costo() As Decimal
        Get
            Return _Detalle.Costo
        End Get
        Set(ByVal value As Decimal)
            _Detalle.Costo = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la utilidad
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Utilidad"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property Utilidad() As Decimal
        Get
            Return _Detalle.Utilidad
        End Get
        Set(ByVal value As Decimal)
            _Detalle.Utilidad = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el porcentaje de comición
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("% de Comición"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property ComisionP() As Decimal
        Get
            Return _Detalle.ComicionP
        End Get
        Set(ByVal value As Decimal)
            _Detalle.ComicionP = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la Comicion en cantidad
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("$ de Comicion"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property ComicionC() As Decimal
        Get
            Return _Detalle.ComicionC
        End Get
        Set(ByVal value As Decimal)
            _Detalle.ComicionC = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el pocentaje del precio de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("% Precio de Venta"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property PrecioVentaP() As Decimal
        Get
            Return _Detalle.PrecioVentaP
        End Get
        Set(ByVal value As Decimal)
            _Detalle.PrecioVentaP = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad del precio de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("$ de Precio de Venta"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property PrecioVentaC() As Decimal
        Get
            Return _Detalle.PrecioVentaC
        End Get
        Set(ByVal value As Decimal)
            _Detalle.PrecioVentaC = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el estatus
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Estatus"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return _Detalle.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            _Detalle.Estatus = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la linea a la que pertenese el producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Linea")> _
    Public ReadOnly Property Linea() As LineaClass
        Get
            Return Me.Producto.Linea
        End Get
    End Property

    <ComponentModel.DisplayName("Linea")> _
    Public ReadOnly Property NomLinea() As String
        Get
            Return Me.Producto.Linea.Descripcion
        End Get
    End Property

    '''' <summary>
    '''' Obtiene la Sub-Linea a la que pertenece el producto
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    '<ComponentModel.DisplayName("Sub-Linea")> _
    'Public ReadOnly Property SubLinea() As SubLineaClass
    '    Get
    '        Return _Producto.SubLinea
    '    End Get
    'End Property


    ''' <summary>
    ''' Obtiene la marca a la que pertenese el producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Marca")> _
    Public ReadOnly Property Marca() As MarcaClass
        Get
            Return Producto.Marca
        End Get
    End Property

    <ComponentModel.DisplayName("Marca")> _
    Public ReadOnly Property NomMarca() As String
        Get
            Return Producto.Marca.Nombre
        End Get
    End Property

    '''' <summary>
    '''' Obtiene el IVA a pagar del Producto
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    '<ComponentModel.DisplayName("IEPS"), ComponentModel.DataObjectField(False, False, False)> _
    'Public ReadOnly Property IEPS() As Decimal
    '    Get
    '        Return _Detalle.PrecioVentaC * _Producto.PorcIEPS / 100
    '    End Get
    'End Property

    ''' <summary>
    ''' Obtiene el importe del descuento del Producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Descuento"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property Descuento() As Decimal
        Get
            Return _Detalle.LpdimpDescto
        End Get
        Set(ByVal value As Decimal)
            _Detalle.LpdimpDescto = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene el porcentaje del descuento del Producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Descuento"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property PorcDescuento() As Decimal
        Get
            Return _Detalle.LpdporcDescto
        End Get
        Set(ByVal value As Decimal)
            _Detalle.LpdporcDescto = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Da de baja el Detalle de la Lista de Precios
    ''' </summary>
    ''' <returns></returns>

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            _Detalle.Estatus = EstatusEnum.INACTIVO
            If _Detalle.Save Then
                Return True
            Else
                Return False
                RaiseEvent MensajeError(Me, "La lista de precios no pudo ser dada de baja...")
            End If
        Catch ex As Exception
            Return False
            RaiseEvent MensajeError(Me, "La lista de precios no pudo ser dada de baja...")
        End Try
    End Function

    ''' <summary>
    ''' Guarda o actualiza los datos del Detalle de la Lista de Precios
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function Guardar() As Boolean Implements IEntidad.Guardar
        Try
            _Detalle.Estatus = EstatusEnum.ACTIVO
            If _Detalle.Save Then
                Return True
            Else
                Return False
                RaiseEvent MensajeError(Me, "La lista de precios no pudo ser guardada...")
            End If
        Catch ex As Exception
            Return False
            RaiseEvent MensajeError(Me, "La lista de precios no pudo ser guardada...")
        End Try
    End Function

    Public Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        Try
            If _Detalle.IsNew Then
                _Detalle.Estatus = EstatusEnum.ACTIVO
            End If
            Trans.Add(_Detalle)
            If _Detalle.Save() Then
                Return True
            Else
                Return False
                RaiseEvent MensajeError(Me, "La lista de precios no pudo ser guardada...")
            End If
        Catch ex As Exception
            Return False
            RaiseEvent MensajeError(Me, "La lista de precios no pudo ser guardada...")
        End Try
    End Function

    ''' <summary>
    ''' Cancela el Detalle de la Lista de Precios
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar
        Return True
    End Function


    ''' <summary>
    ''' Obtiene un detalle de una Lista de Precios
    ''' </summary>
    ''' <param name="Codigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            'If _Detalle.FetchUsingPK(ListaPrecio, Producto) Then
            '    Return True
            'End If
            RaiseEvent MensajeError(Me, "El Detalle de Lista de Precio especificado no existe...")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Obtiene un Detalle de la Lista de Precios
    ''' </summary>
    ''' <param name="CodigoLista">Código de la Lista de Precio que tiene el detalle</param>
    ''' <param name="CodigoProducto">Código del Producto del Detalle de la Lista de Precios</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function Obtener(ByVal CodigoLista As Integer, ByVal CodigoProducto As Integer) As Boolean
        Try
            Return _Detalle.FetchUsingPK(CodigoLista, CodigoProducto)
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se logró obtener el detalle")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Lee un ListaPrecioDetalleEntity y Copia sus valores sus valores
    ''' </summary>
    ''' <param name="Entidad">ListaPrecioDetalleEntity que se desea leer</param>
    ''' <remarks></remarks>
    Public Sub LeerEntidad(ByVal Entidad As EC.ListaPrecioDetalleEntity)
        Me._Detalle = Entidad
    End Sub

    ''' <summary>
    ''' Obtiene un ListaPrecioDetalleEntity con todos los datos del detalle
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerEntidad() As EC.ListaPrecioDetalleEntity
        Return Me._Detalle
    End Function

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

#End Region

    Sub New()

        AddHandler Modificado, AddressOf FueModificado
        'Inicialización de todas las variables...
        _Detalle = New EC.ListaPrecioDetalleEntity
        'listaPrecioDetalle.Plaza = 0
        'listaPrecioDetalle.Producto = 0
        'listaPrecioDetalle.Familia = 0
        'listaPrecioDetalle.SubFamilia = 0
        'listaPrecioDetalle.Costo = 0
        'listaPrecioDetalle.CostoIndirecto = 0
        'listaPrecioDetalle.PorcentajeComision = 0
        'listaPrecioDetalle.PrecioVenta = 0
    End Sub

    Sub New(ByVal CodigoListaPrecio As Integer, ByVal CodigoProducto As Integer)
        _Detalle = New EC.ListaPrecioDetalleEntity(CodigoListaPrecio, CodigoProducto)
    End Sub

    Sub New(ByVal Entidad As EC.ListaPrecioDetalleEntity)
        _Detalle = Entidad
    End Sub

End Class
