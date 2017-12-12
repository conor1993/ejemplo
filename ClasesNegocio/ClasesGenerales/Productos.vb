Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports AlmacenGeneral
Imports ClasesNegocio.AlmacenGeneral
Imports System.Data.SqlClient

Public Class ProductoGeneralClass
    Inherits ClassBase(Of EC.ProductoEntity)
    Implements IEntidad

#Region "Miembros Privados"

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private m_familia As New LineaClass


#End Region

#Region "Propiedades"

    <ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    <ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescCorta() As String
        Get
            Return Entity.DescrpcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescrpcionCorta = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescrpcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescrpcionCorta = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    'Private m_subfamilia As New SubLineaClass
    '<ComponentModel.DisplayName("Sub-Línea")> _
    'Public Property SubLinea() As SubLineaClass
    '    Get
    '        m_subfamilia.LeerEntidad(Entity.SubLinea)
    '        Return m_subfamilia
    '    End Get
    '    Set(ByVal value As SubLineaClass)
    '        m_subfamilia = value
    '        Entity.SubLinea = m_subfamilia.ObtenerEntidad
    '        'RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    '<ComponentModel.DisplayName("Línea")> _
    'Public ReadOnly Property Linea() As LineaClass
    '    Get
    '        Return SubLinea.Linea
    '    End Get
    'End Property
    <ComponentModel.DisplayName("IdLinea")> _
    Public Property IdLinea() As Integer
        Get
            Return Entity.PdIdLinea
        End Get
        Set(ByVal value As Integer)
            Entity.PdIdLinea = value
        End Set
    End Property


    <ComponentModel.DisplayName("Línea")> _
    Public ReadOnly Property Linea() As LineaClass
        Get
            m_familia.LeerEntidad(Entity.Linea)
            Return m_familia
        End Get
    End Property


    <ComponentModel.DisplayName("Nom Línea")> _
    Public ReadOnly Property NomLinea() As String
        Get
            m_familia.LeerEntidad(Entity.Linea)
            Return m_familia.Descripcion
        End Get
    End Property

    '<ComponentModel.DisplayName("Nom Sub Línea")> _
    'Public ReadOnly Property NomSubLinea() As String
    '    Get
    '        m_familia.LeerEntidad(Entity.Linea)
    '        Return m_familia.SubLineas(0).Descripcion
    '    End Get
    'End Property
    '<ComponentModel.DisplayName("Línea")> _
    'Public ReadOnly Property Linea() As LineaClass
    '    Get
    '        Return SubLinea.Linea
    '    End Get
    'End Property

    Private m_unidadmedida As New UnidadesMedidaClass()
    <ComponentModel.DisplayName("Unidad de Medida")> _
    Public Property UnidadMedida() As UnidadesMedidaClass
        Get
            m_unidadmedida.LeerEntidad(Entity.UnidadMedida)
            Return m_unidadmedida
        End Get
        Set(ByVal value As UnidadesMedidaClass)
            m_unidadmedida = value
            Entity.UnidadMedida = m_unidadmedida.ObtenerEntidad
            Entity.CodigoUnidadMedida = m_unidadmedida.Codigo
            '_Entidad.UnidadMedida = m_unidadmedida.Codigo
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName(" Nom Unidad de Medida")> _
    Public ReadOnly Property NomUnidadMedida() As String
        Get
            m_unidadmedida.LeerEntidad(Entity.UnidadMedida)
            Return m_unidadmedida.DescCorta
        End Get
    End Property

    Private m_marca As New MarcaClass()
    <ComponentModel.DisplayName("Marca")> _
    Public Property Marca() As MarcaClass
        Get
            m_marca.LeerEntidad(Entity.Marca)
            Return m_marca
        End Get
        Set(ByVal value As MarcaClass)
            m_marca = value
            Entity.Marca = m_marca.ObtenerEntidad
            Entity.CodigoMarca = m_marca.Codigo
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Marca")> _
    Public ReadOnly Property NomMarca() As String
        Get
            m_marca.LeerEntidad(Entity.Marca)
            Return m_marca.Nombre
        End Get

    End Property


    Private m_presentacion As New presentacionClass
    <ComponentModel.DisplayName("Presentación")> _
    Public Property Presentacion() As presentacionClass
        Get
            m_presentacion.LeerEntidad(Entity.Presentacion)
            Return m_presentacion
        End Get
        Set(ByVal value As presentacionClass)
            m_presentacion = value
            Entity.Presentacion = m_presentacion.ObtenerEntidad
            Entity.CodigoPresentacion = m_presentacion.Codigo
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public ReadOnly Property NomPresentacion() As String
        Get
            m_presentacion.LeerEntidad(Entity.Presentacion)
            Return m_presentacion.Descripcion
        End Get
        'Set(ByVal value As presentacionClass)
        '    m_presentacion = value
        '    Entity.Presentacion = m_presentacion.ObtenerEntidad
        '    Entity.CodigoPresentacion = m_presentacion.Codigo
        '    'RaiseEvent Modificado(Me, New EventArgs)
        'End Set
    End Property

    Private m_tproducto As New TipoProductoClass
    <ComponentModel.DisplayName("Tipo de Producto")> _
    Public Property TProducto() As TipoProductoClass
        Get
            m_tproducto.LeerEntidad(Entity.TipoProducto)
            Return m_tproducto
        End Get
        Set(ByVal value As TipoProductoClass)
            m_tproducto = value
            Entity.TipoProducto = m_tproducto.ObtenerEntidad
            Entity.CodigoTipoProducto = m_tproducto.Codigo
        End Set
    End Property

    Public ReadOnly Property NomTipoProducto() As String
        Get
            m_tproducto.LeerEntidad(Entity.TipoProducto)
            Return m_tproducto.Descripcion
        End Get

    End Property

    <ComponentModel.DisplayName("Se Factura")> _
    Public Property SeFactura() As Boolean
        Get
            Return Entity.SeFactura
        End Get
        Set(ByVal value As Boolean)
            Entity.SeFactura = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Es Kit")> _
    Public Property EsKit() As Boolean
        Get
            Return Entity.PdEsKit
        End Get
        Set(ByVal value As Boolean)
            Entity.PdEsKit = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Se Recibe Parcialmente")> _
    Public Property SeRecibeParcial() As Boolean
        Get
            Return Entity.SeRecibeParcial
        End Get
        Set(ByVal value As Boolean)
            Entity.SeRecibeParcial = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Se Obtiene Mermas")> _
    Public Property SeObtieneMermas() As Boolean
        Get
            Return Entity.SeObtieneMermas
        End Get
        Set(ByVal value As Boolean)
            Entity.SeObtieneMermas = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Se Recibe sin Factura")> _
    Public Property SeRecibeSinFactura() As Boolean
        Get
            Return Entity.SeRecibeSinFactura
        End Get
        Set(ByVal value As Boolean)
            Entity.SeRecibeSinFactura = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Se Factura sin Existencia")> _
    Public Property SeFacturaSinExistencia() As Boolean
        Get
            Return Entity.SeFacturaSinExistencia
        End Get
        Set(ByVal value As Boolean)
            Entity.SeFacturaSinExistencia = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Se Maneja por Lotes")> _
    Public Property SeManejaPorLotes() As AsignadaEnum
        Get
            Return Entity.SeManejaPorLotes
        End Get
        Set(ByVal value As AsignadaEnum)
            Entity.SeManejaPorLotes = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Producto General")> _
    Public Property ProductoGeneral() As AsignadaEnum
        Get
            Return Entity.ProductoGeneral
        End Get
        Set(ByVal value As AsignadaEnum)
            Entity.ProductoGeneral = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Es Mezcla")> _
    Public Property EsMezcla() As AsignadaEnum
        Get
            Return Entity.EsMezcla
        End Get
        Set(ByVal value As AsignadaEnum)
            Entity.EsMezcla = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Es Ingrediente")> _
    Public Property Ingrediente() As AsignadaEnum
        Get
            Return Entity.EsIngrediente
        End Get
        Set(ByVal value As AsignadaEnum)
            Entity.EsIngrediente = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Es material para envase")> _
    Public Property MaterialEnvase() As AsignadaEnum
        Get
            Return Entity.EsMaterialEnvase
        End Get
        Set(ByVal value As AsignadaEnum)
            Entity.EsMaterialEnvase = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Dias Mínimos de Caducidad")> _
    Public Property DiasminCaducidad() As Short
        Get
            Return Entity.DiasMinCaducidad
        End Get
        Set(ByVal value As Short)
            Entity.DiasMinCaducidad = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Piezas")> _
    Public Property Piezas() As Short
        Get
            Return Entity.Piezas
        End Get
        Set(ByVal value As Short)
            Entity.Piezas = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Usuario Alta")> _
    Public Property CodigoUsuarioAlta() As Integer
        Get
            Return Entity.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.UsuarioAlta = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Usuario de Baja")> _
    Public Property CodigoUsuarioBaja() As Integer
        Get
            Return Entity.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            Entity.UsuarioBaja = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha de Baja")> _
    Public Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Motivo de Baja")> _
    Public Property CodigoMotivoBaja() As Integer
        Get
            Return Entity.MotivoBaja
        End Get
        Set(ByVal value As Integer)
            Entity.MotivoBaja = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Observacion de Baja")> _
    Public Property ObservacionBaja() As String
        Get
            Return Entity.ObservacionBaja
        End Get
        Set(ByVal value As String)
            Entity.ObservacionBaja = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Tiene Caducidad")> _
    Public Property Caducidad() As Boolean
        Get
            Return Entity.PdCaduca
        End Get
        Set(ByVal value As Boolean)
            Entity.PdCaduca = value
        End Set
    End Property

    Public Property IsNew() As Boolean
        Get
            Return Entity.IsNew
        End Get
        Set(ByVal value As Boolean)
            Entity.IsNew = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return CType(Entity.Estatus, EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = CType(value, Short)
        End Set
    End Property

    Private m_prodpaquete As ProductosPaqueteCollection
    <ComponentModel.DisplayName("Productos Mezcla")> _
    Public Property ProductoPaquete() As ProductosPaqueteCollection
        Get
            If m_prodpaquete Is Nothing Then
                m_prodpaquete = New ProductosPaqueteCollection
                m_prodpaquete.LeerColeccion(Me.Entity.ProductoMezcla)
            End If

            Return m_prodpaquete
        End Get
        Set(ByVal value As ProductosPaqueteCollection)
            m_prodpaquete = value
        End Set
    End Property

    Private m_costosindirectos As New ProdCostoIndirectoCollection
    <ComponentModel.DisplayName("Costos Indirectos del Paquete")> _
    Public Property CostosIndirectosP() As ProdCostoIndirectoCollection
        Get
            If Me.m_costosindirectos Is Nothing Then
                Me.m_costosindirectos = New ProdCostoIndirectoCollection
                m_costosindirectos.LeerColeccion(Me.Entity.ProductoCostoIndirecto)
            End If

            Return m_costosindirectos
        End Get
        Set(ByVal value As ProdCostoIndirectoCollection)
            m_costosindirectos = value
        End Set
    End Property

    Private m_nutrientes As NutrientesporProductoCollectionClass
    <ComponentModel.DisplayName("Nutrientes por Producto")> _
    Public ReadOnly Property Nutrientes() As NutrientesporProductoCollectionClass
        Get
            If Me.m_nutrientes Is Nothing Then
                Me.m_nutrientes = New NutrientesporProductoCollectionClass()
                Me.m_nutrientes.RellenarMe(Entity.DetAlimentos)
            End If
            Return m_nutrientes
        End Get
    End Property

    Private m_invAlmacen As AlmacenGeneral.InventarioAlmacenClass
    <ComponentModel.DisplayName("Inventario almacen")> _
    Public ReadOnly Property InvAlmacen(Optional ByVal CodAlmacen As Integer = 1) As InventarioAlmacenClass
        Get
            If Me.m_invAlmacen Is Nothing Then
                Me.m_invAlmacen = New InventarioAlmacenClass()

                'Me.m_invAlmacen.RellenarMe(Entity.DetAlimentos)
                Me.m_invAlmacen.Obtener(Entity.Codigo, CodAlmacen)
            End If
            Return m_invAlmacen
        End Get
    End Property



    ''' <summary>
    ''' Obtiene o establece si se le aplicara iva al producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Se Aplica IVA")> _
    Public Property SeAplicaIva() As AsignadaEnum
        Get
            Return Me.Entity.SeAplicaIva
        End Get
        Set(ByVal value As AsignadaEnum)
            Entity.SeAplicaIva = value
        End Set
    End Property


    <ComponentModel.DisplayName(" IVA")> _
    Public ReadOnly Property IVA() As Decimal
        Get
            Dim controlador As New ClasesNegocio.ControladorGanadera
            If Entity.SeAplicaIva = True Then
                Return controlador.ObtenerIVA()
            Else
                Return 0
            End If


        End Get

    End Property

    <ComponentModel.DisplayName(" IEPS")> _
    Public ReadOnly Property IEPS() As Decimal
        Get
            If Entity.PorcIeps > 0 Then
                Return Entity.PorcIeps
            Else
                Return 0
            End If
        End Get

    End Property

    <ComponentModel.DisplayName("KIT")> _
    Public ReadOnly Property Kit() As String
        Get
            If Entity.PdEsKit = True Then
                Return "SI"
            Else
                Return "NO"
            End If
        End Get

    End Property
    ''' <summary>
    ''' Obtiene o establece el porcentaje de iva a aplicar al producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Porcentaje IEPS")> _
    Public Property PorcIEPS() As Decimal
        Get
            Return Me.Entity.PorcIeps
        End Get
        Set(ByVal value As Decimal)
            Entity.PorcIeps = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el codigo de barras del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Codigo de barras")> _
    Public Property CodigoBarra() As String
        Get
            Return Entity.CodigoBarra
        End Get
        Set(ByVal value As String)
            Entity.CodigoBarra = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si el producto se usa en el Punto de Venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Artículo de Punto de Venta")> _
    Public Property ArtPuntoVenta() As Boolean
        Get
            Return Entity.ArtPuntoVenta
        End Get
        Set(ByVal value As Boolean)
            Entity.ArtPuntoVenta = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si el producto se usa en el Meat
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Artículo de Meat")> _
    Public Property ArtMeat() As Boolean
        Get
            Return Entity.ArtMeat
        End Get
        Set(ByVal value As Boolean)
            Entity.ArtMeat = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si el producto se usa en el Meat
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Ultimo Costo")> _
    Public Property UltimoCosto() As Decimal
        Get
            Return IIf(Entity.UltimoCosto.HasValue, Entity.UltimoCosto, 0)
        End Get
        Set(ByVal value As Decimal)
            Entity.UltimoCosto = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    '<ComponentModel.DisplayName("Costo Promedio")> _
    'Public Property CostoPromedio() As Decimal
    '    Get
    '        Return IIf(Entity.UltimoCosto.HasValue, Entity.UltimoCosto, 0)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.UltimoCosto = value
    '        'RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    Public Property FechaUltimaCompra() As Date
        Get
            Return IIf(Entity.FechaUltimaCompra Is Nothing, New Date(1900, 1, 1), Entity.FechaUltimaCompra)
        End Get
        Set(ByVal value As Date)
            Entity.FechaUltimaCompra = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property CantidadUltimaCompra() As Decimal
        Get
            Return IIf(Entity.CantidadUltimaCompra Is Nothing, 0, Entity.CantidadUltimaCompra)
        End Get
        Set(ByVal value As Decimal)
            Entity.CantidadUltimaCompra = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property ImporteUltimaCompra() As Decimal
        Get
            Return IIf(Entity.ImporteUltimaCompra Is Nothing, 0, Entity.ImporteUltimaCompra)
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteUltimaCompra = value
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public ReadOnly Property PrecioV As String
        Get
            Dim lista As New ListaPrecioDetalleClass(1, Codigo)
            Return lista.PrecioVentaC.ToString("N2")
        End Get
    End Property

    'Public ReadOnly Property CantidadExistencia As Decimal
    '    Get

    '        Dim lista As New ListaPrecioDetalleClass(1, Codigo)
    '        Return lista.PrecioVentaC
    '    End Get
    'End Property

    <ComponentModel.DisplayName("Inventario almacen")> _
    Public ReadOnly Property CantidadExistencia As String
        Get
            If Me.m_invAlmacen Is Nothing Then
                Dim sucursal As New SucursalClass(UtileriasCN.ObtenerCodSucursal)
                Me.m_invAlmacen = New InventarioAlmacenClass()

                'Me.m_invAlmacen.RellenarMe(Entity.DetAlimentos)
                Me.m_invAlmacen.Obtener(Entity.Codigo, sucursal.IdAlmacen)
            End If
            Return m_invAlmacen.CantidadExistencia.ToString("N3")
        End Get

    End Property

    <ComponentModel.DisplayName("Inventario almacen")> _
    Public ReadOnly Property CostoPromedio As String
        Get
            If Me.m_invAlmacen Is Nothing Then
                Dim sucursal As New SucursalClass(UtileriasCN.ObtenerCodSucursal)
                Me.m_invAlmacen = New InventarioAlmacenClass()

                'Me.m_invAlmacen.RellenarMe(Entity.DetAlimentos)
                Me.m_invAlmacen.Obtener(Entity.Codigo, sucursal.IdAlmacen)
            End If
            Return m_invAlmacen.CostoPromedio.ToString("N2")
        End Get

    End Property

    <ComponentModel.DisplayName("Inventario almacen")> _
    Public ReadOnly Property CostoUltimo As String
        Get
            If Me.m_invAlmacen Is Nothing Then
                Dim sucursal As New SucursalClass(UtileriasCN.ObtenerCodSucursal)
                Me.m_invAlmacen = New InventarioAlmacenClass()

                'Me.m_invAlmacen.RellenarMe(Entity.DetAlimentos)
                Me.m_invAlmacen.Obtener(Entity.Codigo, sucursal.IdAlmacen)
            End If
            Return m_invAlmacen.UltimoCosto.ToString("N2")
        End Get

    End Property
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Return Entity.FetchUsingPK(Codigo)
    End Function

    Private Function Obtener(ByVal Codigo As String) As Boolean

    End Function

    Public Function Precio(ByVal CodLista As Integer) As ListaPrecioDetalleClass
        'Dim pdc As ListaPrecioDetalleClass()
        For Each prec As EC.ListaPrecioDetalleEntity In Entity.ListaPrecioDetalle
            If prec.ListaPrecios = CodLista Then
                Dim pdc As New ListaPrecioDetalleClass(prec)
                Return pdc
            End If
        Next
        Return Nothing
    End Function

    Public Overloads Function ObtenerEntidad() As EC.ProductoEntity
        Return Entity
    End Function

    Public Overloads Sub LeerEntidad(ByVal FcEntidad As EC.ProductoEntity)
        Entity = FcEntidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Private Function ValidarNulos() As String
        Dim mensaje As String = ""

        'If Descripcion = "" Then mensaje &= "Debe ingresar el nombre del producto..." & Chr(13)
        'If SubLinea = Nothing Then mensaje &= "Debe seleccionar una subfamilia..." & Chr(13)
        'If TipoProducto = "" Then mensaje &= "Debe seleccionar un tipo de producto..." & Chr(13)
        'If UnidadMedida = "" Then mensaje &= "Debe seleccionar una unidad de medida..." & Chr(13)
        'If CodigoRelacionado = "" Then mensaje &= "Debe ingresar un codigo relacionado..." & Chr(13)
        'If Marca = "" Then mensaje &= "Debe seleccionar una marca..." & Chr(13)
        'If Costo <= 0 Then mensaje &= "El costo debe ser mayor a 0..." & Chr(13)

        Return mensaje
    End Function

    'Public Overrides Function ToString() As String
    '    Return Me.ProductosDelPaquete.Name
    'End Function
    Private Function ValidarDisponibilidad() As String
        Dim pro As New CC.ProductoCollection

        Dim mensaje As String = ""

        If pro.GetDbCount(HC.ProductoFields.DescrpcionCorta = Me.DescCorta) > 0 Then _
            mensaje &= "El codigo del producto no esta disponible..." & Chr(13)
        If pro.GetDbCount(HC.ProductoFields.Descripcion = Descripcion) > 0 Then _
            mensaje &= "El nombre del producto no esta disponible..." & Chr(13)
        'If pro.GetDbCount(HC.ProductoFields.Procodrel = CodigoRelacionado) Then _
        '    mensaje &= "El codigo relacionado no esta disponible..." & Chr(13)

        Return mensaje
    End Function

    Private Shadows Function ValidarGuardar() As Boolean
        Dim mensaje As String = ValidarNulos() & ValidarDisponibilidad()

        If mensaje = "" Then
            Return True
        Else
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
    End Function

    'Private Function ValidarBorrar() As Boolean

    'End Function

    Private Function ValidarModificar() As Boolean
        Dim pro As New CC.ProductoCollection
        Dim mensaje As String = ""
        Dim filtro As New OC.PredicateExpression

        filtro.Add(Not HC.ProductoFields.Codigo = Codigo)
        filtro.Add(HC.ProductoFields.Descripcion = Descripcion)
        If pro.GetDbCount(filtro) > 0 Then _
            mensaje &= "El nombre del producto no esta disponible..." & Chr(13)

        filtro = New OC.PredicateExpression
        filtro.Add(Not HC.ProductoFields.Codigo = Codigo)
        'filtro.Add(HC.ProductoFields.Procodrel = CodigoRelacionado)

        If pro.GetDbCount(filtro) > 0 Then _
            mensaje &= "El codigo relacionado del producto no esta disponible..." & Chr(13)

        Return mensaje
    End Function

    Public Function Modificar() As Boolean
        If ValidarModificar() Then
            If Entity.Save Then
                Return True
            Else
                MsgBox("No se a logrado modificar, intente de nuevo...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Shared Function ObtenerLista(ByVal condicion As CondicionEnum) As DataTable
        Select Case condicion
            Case CondicionEnum.TODOS
                Return CC.ProductoCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Case Else
                Return CC.ProductoCollection.GetMultiAsDataTable(HC.ProductoFields.Estatus = condicion, 0, Nothing)
        End Select
    End Function

    Public Shadows Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Me.Estatus = EstatusEnum.INACTIVO

            If Entity.Save Then
                Return True
            Else
                MsgBox("No se a logrado dar de baja el producto, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se a logrado dar de baja el producto, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

    Public Shadows Function Cancelar() As Boolean Implements IEntidad.Cancelar
        Try
            Me.Estatus = EstatusEnum.INACTIVO

            If Entity.Save Then
                Return True
            Else
                MsgBox("No se a logrado dar de baja el producto, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se a logrado dar de baja el producto, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

    'Private ProdMezcla As Ec.ProductoMezclaEntity
    'Private CostoInd As Ec.CostoIndirectoEntity

    Public Shadows Function Guardar() As Boolean Implements IEntidad.Guardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")

        For i As Integer = 0 To Nutrientes.Count - 1
            Nutrientes(0).IdRenglon = i + 1
        Next
        Try
            If Entity.IsNew Then

                If EsMezcla Then
                    If Me.ProductoPaquete.Count = 0 Then
                        MsgBox("Debe ingresar almenos un producto", MsgBoxStyle.Exclamation, "Faltan Productos")
                        Return False
                    End If

                    Dim porcentaje As Decimal

                    For Each paq As ProductosPaqueteClass In Me.ProductoPaquete
                        porcentaje += paq.Cantidad
                    Next

                    If Not porcentaje = 100 Then
                        MsgBox("La suma de los porcentajes debe ser del 100%", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                ElseIf Ingrediente = AsignadaEnum.SI Then
                    'If Me.Nutrientes.Count = 0 Then
                    'MsgBox("Debe ingresar almenos un nutriente", MsgBoxStyle.Exclamation, "Faltan Nutrientes")
                    'Return False
                    'End If
                End If

                Estatus = EstatusEnum.ACTIVO

                Trans.Add(Entity)

                If Not Entity.Save Then
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If EsMezcla Then
                    Dim ingredientes As CC.ProductoMezclaCollection = ProductoPaquete.ObtenerColeccion()
                    Trans.Add(ingredientes)

                    For Each Item As EC.ProductoMezclaEntity In ingredientes
                        Item.CodigoProducto = Me.Codigo
                    Next

                    If ingredientes.SaveMulti = 0 Then
                        Trans.Rollback()
                        MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If

                    If Me.CostosIndirectosP.Count = 0 Then
                        Trans.Commit()
                        Return True
                    Else
                        Dim costos As CC.ProductoCostoIndirectoCollection = Me.CostosIndirectosP.ObtenerColeccion

                        Trans.Add(costos)

                        If costos.SaveMulti = 0 Then
                            Trans.Rollback()
                            MsgBox("No se logro guardar, intente de intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        Else
                            Trans.Commit()
                            Return True
                        End If
                    End If
                Else
                    If Ingrediente = AsignadaEnum.SI Then
                        For i As Integer = 0 To Me.Nutrientes.Count - 1
                            Dim Nutriente As NutrienteporProductoClass = Me.Nutrientes(i)
                            Nutriente.IdProducto = Me.Codigo
                            Nutriente.IdRenglon = i + 1
                            Trans.Add(Nutriente.Entidad)

                            If Not Nutriente.Entidad.Save() Then
                                Throw New Exception("ha ocurrido un error al intentar guardar los nutrientes, intente de nuevo")
                            End If
                        Next
                    End If
                    Trans.Commit()
                    Return True
                End If
            Else
                Trans.Add(Entity)

                If Entity.Save Then
                    If Me.EsMezcla Then
                        Dim TempIngredientes As New CC.ProductoMezclaCollection
                        TempIngredientes.GetMulti(HC.ProductoMezclaFields.CodigoProducto = Me.Codigo)
                        Trans.Add(TempIngredientes)
                        TempIngredientes.DeleteMulti()

                        For i As Integer = 0 To Me.ProductoPaquete.Count - 1
                            Dim Ingrediente As New EC.ProductoMezclaEntity()
                            Ingrediente.CodigoProducto = Me.Codigo
                            Ingrediente.CodigoIngrediente = Me.ProductoPaquete(i).Entidad.CodigoIngrediente
                            Ingrediente.Porcentaje = Me.ProductoPaquete(i).Entidad.Porcentaje
                            TempIngredientes.Add(Ingrediente)
                        Next

                        Trans.Add(TempIngredientes)
                        TempIngredientes.SaveMulti()

                        Dim col As New CC.ProductoCostoIndirectoCollection
                        Dim encontro As Boolean
                        Trans.Add(col)

                        col.GetMulti(HC.ProductoCostoIndirectoFields.CodigoProducto = Codigo)

                        For Each ente As EC.ProductoCostoIndirectoEntity In col
                            encontro = False
                            For Each entc As ProdCostosIndirectosClass In Me.CostosIndirectosP
                                If ente.CostoIndirecto.Codigo = entc.CostoIndirecto.IDCostosIndirectos Then
                                    encontro = True
                                    If Not entc.ObtenerEntidad.IsDirty Then
                                        Me.CostosIndirectosP.Remove(entc)
                                        Exit For
                                    Else
                                        Exit For
                                    End If
                                End If
                            Next

                            If Not encontro Then
                                Trans.Add(ente)

                                If Not ente.Delete Then
                                    Trans.Rollback()
                                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                                    Return False
                                End If
                            End If
                        Next

                        If Me.CostosIndirectosP.Count = 0 Then
                            Trans.Commit()
                            Return True
                        Else
                            Dim colg As CC.ProductoCostoIndirectoCollection = Me.CostosIndirectosP.ObtenerColeccion

                            Trans.Add(colg)

                            If colg.SaveMulti = 0 Then
                                Trans.Rollback()
                                MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                                Return False
                            Else
                                Trans.Commit()
                                Return True
                            End If
                        End If
                    Else
                        If Ingrediente = AsignadaEnum.SI Then
                            Dim TempNutrientes As New CC.DetAlimentosCollection()
                            TempNutrientes.GetMulti(HC.DetAlimentosFields.CveAlimento = Me.Codigo)
                            Trans.Add(TempNutrientes)
                            TempNutrientes.DeleteMulti()

                            For i As Integer = 0 To Me.Nutrientes.Count - 1
                                Dim Nutriente As New EC.DetAlimentosEntity()
                                Nutriente.CveAlimento = Me.Codigo
                                Nutriente.CveNutriente = Me.Nutrientes(i).Entidad.CveNutriente
                                Nutriente.CveRenglon = i + 1
                                Nutriente.PtjNutriente = Me.Nutrientes(i).Entidad.PtjNutriente
                                TempNutrientes.Add(Nutriente)
                            Next

                            Trans.Add(TempNutrientes)
                            TempNutrientes.SaveMulti()
                        End If
                        Trans.Commit()
                        Return True
                    End If
                Else
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            Return False
        End Try
        'Dim ProductoC As New ProductoCollectionClass
        'Dim ProductoE As New EC.ProductoEntity

        'If _Entidad.IsNew Then

        '    If ProductoC.Obtener(Me) > 0 Then
        '        ProductoE = ProductoC.Item(0).ObtenerEntidad
        '        If ProductoE.Estatus = EstatusEnum.Inactivo Then
        '            RaiseEvent MensajeError(Me, "El Producto ya existe en estado Inactivo...")
        '        Else
        '            RaiseEvent MensajeError(Me, "El Producto ya existe...")
        '        End If
        '    Else
        '        If _Entidad.Save() Then
        '            If Me.m_costosindirectos.Guardar() Then
        '                Me.m_prodpaquete.Guardar()
        '            End If
        '        End If
        '        Return True
        '    End If
        'Else
        '    If ProductoC.Obtener(Me) > -1 Then
        '        If ProductoC.Count > 0 Then
        '            ProductoE = ProductoC.Item(0).ObtenerEntidad
        '        Else
        '            ProductoE = _Entidad
        '        End If
        '        If ProductoE.Codigo = Me.Codigo Then

        '            If _Entidad.Save() Then
        '                If Me.m_costosindirectos.Guardar() Then
        '                    Me.m_prodpaquete.Guardar()
        '                End If
        '            End If
        '            Return True
        '        Else
        '            RaiseEvent MensajeError(Me, "El Producto ya existe...")
        '        End If
        '    Else
        '        RaiseEvent MensajeError(Me, "Hubo un error al intentar guardar...")
        '    End If
        'End If
        'Return False
    End Function

    Public Shadows Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        For i As Integer = 0 To Nutrientes.Count - 1
            Nutrientes(0).IdRenglon = i + 1
        Next
        Try
            If Entity.IsNew Then
                Estatus = EstatusEnum.ACTIVO
                Trans.Add(Entity)

                If Not Entity.Save Then
                    Return False
                Else
                    Return True
                End If
            Else
                Trans.Add(Entity)

                If Not Entity.Save Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Private Function CuentaModificada(ByVal _detalle As EC.DetAlimentosEntity, ByVal Transaccion As HC.Transaction) As Boolean
    '    For Each row As NutrienteporProductoClass In Nutrientes
    '        If row.IdNutriente = _detalle.CveNutriente And Not row.Entidad.IsNew Then
    '            If row.PorcentajeNutriente <> _detalle.PtjNutriente Then
    '                row.Guardar(Transaccion)
    '            End If

    '            Nutrientes().Remove(row)
    '            Return True
    '        End If
    '    Next
    '    Return False
    'End Function
#End Region

#Region "Contructores"

    Sub New()
        Entity = New EC.ProductoEntity
    End Sub

    Sub New(ByVal codigo As Integer)
        Entity = New EC.ProductoEntity(codigo)
        IsNew = False
    End Sub

    Sub New(ByVal Entidad As Integralab.ORM.EntityClasses.ProductoEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Clave As String)
        Dim productos As New ProductoCollectionClass()
        If productos.Obtener(Clave) > 0 Then
            Entity = productos(0).ObtenerEntidad
        Else
            Entity = New Integralab.ORM.EntityClasses.ProductoEntity
        End If
    End Sub



#End Region

End Class

Public Class ProductoCollectionClass
    Inherits ColleccionBase(Of EC.ProductoEntity, CC.ProductoCollection, ProductoGeneralClass)

    Private ProductoCollection As New CC.ProductoCollection
    Public Event MensajeError As MensajeErrorHandler
    Private Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))


    Sub New()
        MyBase.New()
    End Sub

    Public Overloads Function IndexOf(ByVal IdProducto As Integer) As Integer
        For i As Integer = 0 To Me.Count - 1
            If Me.Item(i).Codigo = IdProducto Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function Borrar() As Object
        ProductoCollection = New CC.ProductoCollection
        For Each Producto As ProductoGeneralClass In Me
            Dim ProductoEntity As New EC.ProductoEntity
            ProductoEntity = Producto.ObtenerEntidad()
            ProductoCollection.Add(ProductoEntity)
        Next
        Try
            Dim Conteo As Integer = ProductoCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        ProductoCollection = New CC.ProductoCollection
        For Each Producto As ProductoGeneralClass In Me
            Dim ProductoEntity As New EC.ProductoEntity
            ProductoEntity = Producto.ObtenerEntidad()
            ProductoCollection.Add(ProductoEntity)
        Next
        Try
            Dim Conteo As Integer = ProductoCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener() As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = ProductoCollection.GetDbCount()
            If Conteo > 0 Then
                ProductoCollection.GetMulti(Nothing, 0, Ordenamiento)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Clave As String) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression(HC.ProductoFields.DescrpcionCorta = Clave)
            Dim Conteo As Integer = ProductoCollection.GetDbCount(filtro)
            If Conteo > 0 Then
                ProductoCollection.GetMulti(filtro, 0, Ordenamiento)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal FcCondicion As CondicionEnum, Optional ByVal SeFactura As Boolean = True) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression()
            If FcCondicion = CondicionEnum.ACTIVOS Then
                filtro.Add(HC.ProductoFields.SeFactura = SeFactura And HC.ProductoFields.Estatus = True)
            ElseIf FcCondicion = CondicionEnum.INACTIVOS Then
                filtro.Add(HC.ProductoFields.SeFactura = SeFactura And HC.ProductoFields.Estatus = False)
            Else
                filtro.Add(HC.ProductoFields.SeFactura = SeFactura)
            End If


            Dim Conteo As Integer = ProductoCollection.GetDbCount(filtro)
            If Conteo > 0 Then
                ProductoCollection.GetMulti(filtro, 0, Ordenamiento)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function ObtenerCodBarra(ByVal CodBarra As String) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression(HC.ProductoFields.CodigoBarra = CodBarra)
            Dim Conteo As Integer = ProductoCollection.GetDbCount(filtro)
            If Conteo > 0 Then
                ProductoCollection.GetMulti(filtro, 0, Ordenamiento)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal FcCondicion As CondicionEnum, ByVal FcProductoGeneral As CondicionAsignadaEnum, ByVal FcMezcla As CondicionAsignadaEnum, _
                            ByVal FcIngrediente As CondicionAsignadaEnum, ByVal FcMaterialEnvase As CondicionAsignadaEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.ProductoFields.Estatus = FcCondicion)
            End If

            If Not FcProductoGeneral = CondicionAsignadaEnum.TODOS Then
                Filtro.Add(HC.ProductoFields.ProductoGeneral = FcProductoGeneral)
            End If

            If Not FcMezcla = CondicionAsignadaEnum.TODOS Then
                Filtro.Add(HC.ProductoFields.EsMezcla = FcMezcla)
            End If

            If Not FcIngrediente = CondicionAsignadaEnum.TODOS Then
                Filtro.Add(HC.ProductoFields.EsIngrediente = FcIngrediente)
            End If

            If Not FcMaterialEnvase = CondicionAsignadaEnum.TODOS Then
                Filtro.Add(HC.ProductoFields.EsMaterialEnvase = FcMaterialEnvase)
            End If

            Me.ProductoCollection.GetMulti(Filtro, 0, Ordenamiento)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    'Metodo que me trae la colección de productos por lineas y/o sublineas, marca, descripción e ingredientes.
    Public Overloads Function Obtener(ByVal Lin As LineaClass, ByVal Linea As LineaClass, ByVal Marca As MarcaClass, ByVal Descripcion As String, ByVal Ingrediente As Boolean, ByVal Paquete As Boolean) As Integer
        'Variable que controla el filtrado...
        Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
        Dim Todos As Boolean = False
        Try
            Me.ClearItems()
            'Instancío el filtro.
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            'Valido Linea...
            If Not IsNothing(Linea) Then
                filtro.Add(HC.ProductoFields.PdIdLinea = Linea.Codigo)
                Todos = True
            End If 'Else
            'Valido que sublinea tenga valor, si hay valor recupero los registros...
            'If Not IsNothing(Lin) Then
            '    If Lin.Codigo <> 0 Then
            '        Dim fams As LineaCollectionClass = Lin.ObtenerEntidad
            '        For Each fam As LineaClass In fams
            '            filtro.AddWithOr(HC.ProductoFields.PdIdLinea = fam.Codigo)
            '        Next
            '        Todos = True
            '    End If
            'End If
            'End If
            'Valido Ingrediente...
            If Ingrediente Then
                filtro.AddWithAnd(HC.ProductoFields.EsIngrediente = True)
                Todos = True
            End If
            'Valido Paquete...
            If Paquete Then
                filtro.AddWithOr(HC.ProductoFields.EsMezcla = True)
                Todos = True
            End If
            'Valido Marca...
            If Not IsNothing(Marca) Then
                filtro.AddWithAnd(HC.ProductoFields.CodigoMarca = Marca.Codigo)
                Todos = True
            End If
            'Valido Descripcion...
            If Descripcion <> "" Then
                filtro.Add(HC.ProductoFields.Descripcion Mod ("%" & Descripcion & "%"))
                Todos = True
            End If
            Dim Conteo As Integer = ProductoCollection.GetDbCount(filtro)
            If Conteo > 0 Then
                If Todos = False Then
                    ProductoCollection.GetMulti(Nothing, 0, Ordenamiento)
                Else
                    ProductoCollection.GetMulti(filtro, 0, Ordenamiento)
                End If
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Prod As ProductoGeneralClass) As Integer
        Try
            Me.ClearItems()
            Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.ProductoFields.Codigo = Prod.Codigo)
            filtro.AddWithOr(HC.ProductoFields.DescrpcionCorta = Prod.DescCorta)
            filtro.AddWithOr(HC.ProductoFields.Descripcion = Prod.Descripcion)

            ProductoCollection.GetMulti(filtro, 0, Ordenamiento)

            For Each ProdEntity As EC.ProductoEntity In ProductoCollection
                Dim MiProd As New ProductoGeneralClass
                MiProd.LeerEntidad(ProdEntity)
                Me.Add(MiProd)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal filtro As OC.IPredicate, Optional ByVal rel As OC.RelationCollection = Nothing) As Integer
        Try
            Me.ProductoCollection.GetMulti(filtro, 0, Ordenamiento, rel)

            Me.Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los productos", MsgBoxStyle.Critical, "Error")
#End If

            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal filtro As OC.IPredicate, ByVal sort As OC.SortExpression) As Integer
        Try
            'sort = New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Me.ProductoCollection.GetMulti(filtro, 0, sort)

            Me.Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los productos", MsgBoxStyle.Critical, "Error")
#End If

            Return -1
        End Try
    End Function

    Public Function ObtenerProductoCollection() As CC.ProductoCollection
        RellenarProductoCollection()
        Return ProductoCollection
    End Function

    Private Sub RellenarProductoCollection()
        ProductoCollection = New CC.ProductoCollection
        For Each Producto As ProductoGeneralClass In Me
            Dim ProductoE As New EC.ProductoEntity
            ProductoE = Producto.ObtenerEntidad
            ProductoCollection.Add(ProductoE)
        Next
    End Sub

    Private Sub RellenarMe()
        Me.ClearItems()
        For Each ProductoEntity As EC.ProductoEntity In ProductoCollection
            Dim Producto As New ProductoGeneralClass
            Producto.LeerEntidad(ProductoEntity)
            If Producto.Estatus = EstatusEnum.ACTIVO Then
                Me.Add(Producto)
            End If
        Next
    End Sub

    Public Sub RellenarMe(ByVal ProductoCol As CC.ProductoCollection)
        Me.ClearItems()
        For Each ProductoE As EC.ProductoEntity In ProductoCol
            Dim Producto As New ProductoClass
            Producto.LeerEntidad(ProductoE)
            Me.Add(Producto)
        Next
    End Sub

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.ProductoEntity In Me.ProductoCollection
            Add(New ProductoGeneralClass(ente))
        Next
    End Sub

    Public Function Reporte(ByVal Empresa As String, ByVal usuario As String) As RptProductoComando
        Try
            Dim Rep As New Global.ClasesNegocio.RptProductoComando

            Dim ds As New DataSet
            Dim dts As New DsProductos
            Dim dt As DataTable

            Dim Sql As String = "select A.PdIdProducto as Codigo, A.CodigoBarra, 0.00 as Piezas,A.PdDescripcion as Descripcion, A.PdDescrpcionCorta as DescripcionCorta,B.LNDescripcion as NomLinea,C.marnombre as NomMarca, D.UMDescCorta as NomUnidadMedida,isnull(E.PrNombre,'') as NomPresentacion, Case when A.PdSeAplicaIva = 1 then (Select top 1 IVA from usrConfigContabilidad) else 0 end as IVA, A.PorcIEPS as IEPS, Case when A.PdEsKit = 1  then 'SI' else 'NO' end as Kit from MCatCompProductos A left join MCatCompLineas B on B.LNIdLinea = A.PdIdLinea left join MCatGenMarcas C on C.maridMarca = A.PdIdMarca left join MCatCompUnidadMedida D on D.UMIdUnidadMedida = A.PdIdUnidadMedida left join MCatCompPresentacion E on E.PrIdPresentacion = A.PdIdPresentacion "
            Dim cmd As New SqlClient.SqlCommand(Sql, New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString.ToString))
            cmd.CommandType = CommandType.Text
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.SelectCommand.CommandTimeout = 1500
            'Fill the dataset'
            ds = New DataSet
            adapter.Fill(ds)


            'dt = CollectionHelper.ConvertTo(Of ClasesNegocio.ProductoGeneralClass)(Me)
            'Dim dt As New DsProductos.DtProductoDataTable
            'For Each pro As ProductoGeneralClass In Me
            '    dt.AddDtProductoRow(pro.Codigo, pro.DescCorta, pro.Descripcion, pro.Linea.Descripcion, pro.Linea.Descripcion, pro.Marca.Nombre, _
            '    pro.Presentacion.Descripcion, pro.TProducto.Descripcion, pro.Piezas.ToString(), pro.UnidadMedida.Descripcion)
            'Next


            ''COMENTADO PRUEBA
            'For Each pro As ProductoGeneralClass In Me
            '    dts.DtProducto.AddDtProductoRow(pro.Codigo, pro.DescCorta, pro.Descripcion, pro.Linea.Descripcion, pro.Linea.Descripcion, pro.Marca.Nombre, _
            '    pro.Presentacion.Descripcion, pro.TProducto.Descripcion, pro.Piezas.ToString(), pro.UnidadMedida.Descripcion)

            'Next

            'dts.DtProducto.AddDtProductoRow()

            'ds.Tables.Add(dts)
            ''COMENTADO PRUEBA
            'Rep.SetDataSource(dts)
            Rep.SetDataSource(ds.Tables(0))
            Rep.SetParameterValue(0, Empresa)
            Rep.SetParameterValue(1, usuario)
            Rep.SetParameterValue(2, "Catálogos/Compras Generales/Productos")

            Return Rep
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function

    Public Shared Function CargarProductos(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Ingredientes As New CC.ProductoCollection

        Try
            Ingredientes.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, OC.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return Ingredientes.GetList()
    End Function

    Public Function ObtenerElemento(ByVal Codigo As String) As ProductoGeneralClass
        For Each prod As ProductoGeneralClass In Me
            If prod.Codigo = Codigo Then
                Return prod
            End If
        Next
        Return Nothing
    End Function

End Class

Public Class ProductosVistaClass
    Implements IEntidad
    Dim Producto As Integralab.ORM.TypedViewClasses.VwProductosGeneralesRow

#Region "Propiedades"
    Public Property Codigo() As Integer
        Get
            Return Producto.PdIdProducto
        End Get
        Set(ByVal value As Integer)
            Producto.PdIdProducto = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Producto.PdDescripcion
        End Get
        Set(ByVal value As String)
            Producto.PdDescripcion = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Producto.PdEstatus
        End Get
        Set(ByVal value As EstatusEnum)
            Producto.PdEstatus = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Private Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function



    Private Function Guardar() As Boolean Implements IEntidad.Guardar

    End Function

    Private Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Private Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Renglon As Integralab.ORM.TypedViewClasses.VwProductosGeneralesRow)
        Producto = Renglon
    End Sub
#End Region
End Class

Public Class ProductosVistaCollectionClass
    Inherits CollectionClass(Of ProductosVistaClass)

    Dim Coleccion As New Integralab.ORM.TypedViewClasses.VwProductosGeneralesTypedView

    Public Function Obtener(ByVal Estatus As CondicionEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.VwProductosGeneralesFields.PdDescripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not Estatus = CondicionEnum.TODOS Then
                Filtro.Add(HC.VwProductosGeneralesFields.PdEstatus = Estatus)
            End If

            Coleccion.Clear()
            Coleccion.Fill(0, Orden, False, Filtro)
            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener() As Integer
        Try
            Dim dr As DataRow = Coleccion.NewRow()

            dr(1) = "-TODOS-"

            Coleccion.Clear()
            Coleccion.Rows.Add(dr)
            Coleccion.Fill(0, Nothing, True)

            For Each Row As Integralab.ORM.TypedViewClasses.VwProductosGeneralesRow In Coleccion
                Add(New ProductosVistaClass(Row))
            Next

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Sub Rellenar()
        Clear()
        For Each Row As Integralab.ORM.TypedViewClasses.VwProductosGeneralesRow In Coleccion
            Add(New ProductosVistaClass(Row))
        Next
    End Sub

End Class