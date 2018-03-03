Imports ORM = Integralab.ORM
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class FacturasClass
#Region "Miembros"

    'Inherits ClassBase(Of EC.CabFacturasEntity)
    Inherits EC.CabFacturasEntity
    Private _Detalle As FacturasDetalleCollectionClass = Nothing
    Private _cliente As ClasesNegocio.ClientesIntroductoresClass
#End Region


#Region "Constructores"

    Public Sub New()
        MyBase.FetchUsingPK(NoFactura)
    End Sub

    Sub New(ByVal Entidad As EC.CabFacturasEntity)
        If Not MyBase.FetchUsingPK(Entidad.FolFactura) AndAlso Not Entidad.IsDirty Then
            Me.Cabezas = Entidad.Cabezas
            Me.ClaveUsuario = Entidad.CveUs
            Me.Cliente = Entidad.CveCliente
            Me.DiasCredito = Entidad.DiasCred
            Me.FechaCancelacion = Entidad.FecCancelacion
            Me.FechaCancelacionContable = Entidad.FecCanConta
            Me.FechaCaptura = Entidad.FecCaptura
            Me.FechaContable = Entidad.FecConta
            Me.FechaFactura = Entidad.FecFactura
            Me.FechaVencimiento = Entidad.FecVenci
            Me.PolizaCancelacion = Entidad.FolCanPoliza
            Me.PolizaFactura = Entidad.FolPoliza
            Me.ImporteDescuento = Entidad.ImpteDescto
            Me.ImporteIVA = Entidad.ImpteIva
            Me.Kilos = Entidad.Kilos
            Me.MotivodeCancelacion = Entidad.MotivoCancel
            Me.PorcentajeIVA = Entidad.PtjIva
            Me.Referencia = Entidad.Referencia
            Me.EstatusF = Entidad.StaFacturacion
            Me.Estatus = Entidad.Status
            Me.SubTotal = Entidad.SubTotal
            Me.TipoFactura = Entidad.TipoFactu
            Me.TipoComprobante = Entidad.TipoComprobante
            Me.RelacionCfdi = Entidad.RelacionCfdi
            Me.IsNew = True
            Me.IsDirty = Entidad.IsDirty
        End If
    End Sub
    
#End Region

#Region "Propiedades"
    Public Property NoFactura() As String
        Get
            Return MyBase.FolFactura
        End Get
        Set(ByVal value As String)
            MyBase.FolFactura = value
        End Set
    End Property
    Public Property FechaFactura() As Date
        Get
            Return MyBase.FecFactura
        End Get
        Set(ByVal value As Date)
            MyBase.FecFactura = value
        End Set
    End Property
    Public Property FechaCaptura() As Date
        Get
            Return MyBase.FecCaptura
        End Get
        Set(ByVal value As Date)
            MyBase.FecCaptura = value
        End Set
    End Property
    Public Property ReferenciaSalidas() As Integer
        Get
            Return MyBase.Referencia
        End Get
        Set(ByVal value As Integer)
            MyBase.Referencia = value
        End Set
    End Property
    Public Property ClaveUsuario() As Integer
        Get
            Return MyBase.CveUs
        End Get
        Set(ByVal value As Integer)
            MyBase.CveUs = value
        End Set
    End Property
    Public Property TipoFactura() As Integer
        Get
            Return MyBase.TipoFactu
        End Get
        Set(ByVal value As Integer)
            MyBase.TipoFactu = value
        End Set
    End Property
    Public Property Cliente() As Integer
        Get
            Return MyBase.CveCliente
        End Get
        Set(ByVal value As Integer)
            MyBase.CveCliente = value
        End Set
    End Property

    Public ReadOnly Property NomCliente As String
        Get
            _cliente = New ClasesNegocio.ClientesIntroductoresClass(MyBase.CveCliente)
            Return _cliente.Nombre
        End Get

    End Property

    Public Property EstatusF() As String
        Get
            Return MyBase.StaFacturacion
        End Get
        Set(ByVal value As String)
            MyBase.StaFacturacion = value
        End Set
    End Property
    Public Property DiasCredito() As Integer
        Get
            Return MyBase.DiasCred
        End Get
        Set(ByVal value As Integer)
            MyBase.DiasCred = value
        End Set
    End Property
    Public Property FechaVencimiento() As Date
        Get
            Return MyBase.FecVenci
        End Get
        Set(ByVal value As Date)
            MyBase.FecVenci = value
        End Set
    End Property
    Public Property ImporteSubTotal() As Decimal
        Get
            Return MyBase.SubTotal
        End Get
        Set(ByVal value As Decimal)
            MyBase.SubTotal = value
        End Set
    End Property
    Public Property ImporteDescuento() As Decimal
        Get
            Return MyBase.ImpteDescto
        End Get
        Set(ByVal value As Decimal)
            MyBase.ImpteDescto = value
        End Set
    End Property
    Public Property ImporteIVA() As Decimal
        Get
            Return MyBase.ImpteIva
        End Get
        Set(ByVal value As Decimal)
            MyBase.ImpteIva = value
        End Set
    End Property
    Public Property Estatus() As String
        Get
            Return MyBase.Status
        End Get
        Set(ByVal value As String)
            MyBase.Status = value
        End Set
    End Property
    Public Property FechaCancelacion() As Date
        Get
            Return MyBase.FecCancelacion
        End Get
        Set(ByVal value As Date)
            MyBase.FecCancelacion = value
        End Set
    End Property
    Public Property MotivodeCancelacion() As String
        Get
            Return MyBase.MotivoCancel
        End Get
        Set(ByVal value As String)
            MyBase.MotivoCancel = value
        End Set
    End Property
    Public Property FechaContable() As Date
        Get
            Return MyBase.FecConta
        End Get
        Set(ByVal value As Date)
            MyBase.FecConta = value
        End Set
    End Property
    Public Property PolizaFactura() As Integer
        Get
            Return MyBase.FolPoliza
        End Get
        Set(ByVal value As Integer)
            MyBase.FolPoliza = value
        End Set
    End Property
    Public Property FechaCancelacionContable() As Date
        Get
            Return MyBase.FecCanConta
        End Get
        Set(ByVal value As Date)
            MyBase.FecCanConta = value
        End Set
    End Property
    Public Property PolizaCancelacion() As Integer
        Get
            Return MyBase.FolCanPoliza
        End Get
        Set(ByVal value As Integer)
            MyBase.FolCanPoliza = value
        End Set
    End Property
    Public Property CabezasSalida() As Integer
        Get
            Return MyBase.Cabezas
        End Get
        Set(ByVal value As Integer)
            MyBase.Cabezas = value
        End Set
    End Property
    Public Property KilosSalida() As Decimal
        Get
            Return MyBase.Kilos
        End Get
        Set(ByVal value As Decimal)
            MyBase.Kilos = value
        End Set
    End Property
    Public Property PorcentajeIVA() As Decimal
        Get
            If IsDBNull(MyBase.PtjIva) Then
                Return 0
            Else
                Return MyBase.PtjIva
            End If
        End Get
        Set(ByVal value As Decimal)
            MyBase.PtjIva = value
        End Set
    End Property
    'propiedad para detalles de facturas
    Public ReadOnly Property Detalles() As FacturasDetalleCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New FacturasDetalleCollectionClass(Me)

                For Each _Det As EC.DetFacturasEntity In Me.DetFacturas
                    _Detalle.Add(_Det)
                Next
            End If
            Return _Detalle
        End Get
    End Property
  
#End Region

#Region "Metodos"

    Private Sub GuardarDetalle(ByRef Trans As HC.Transaction)
        Trans.Add(Me.DetFacturas)
        Me.DetFacturas.DeleteMulti()

        For i As Integer = 0 To Me.Detalles.Count - 1
            If Me.Detalles(i).IsDirty OrElse Not Me.Detalles(i).IsNew Then
                Trans.Add(Me.Detalles(i))
                Me.Detalles(i).CveRenglon = i + 1
                Me.Detalles(i).IsNew = True
                Me.Detalles(i).Save()
            End If
        Next
    End Sub

    Friend Sub Guardar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Save()
        'GuardarDetalle(Trans)
    End Sub

    Friend Sub Cancelar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Estatus = EstatusFacturasEnum.CANCELADA
        Me.Save()
    End Sub

    Friend Sub Pagar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Estatus = EstatusFacturasEnum.PAGADA
        Me.Save()
    End Sub

    Friend Sub Abonada(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Estatus = EstatusFacturasEnum.ABONADA
        Me.Save()
    End Sub
#End Region

End Class

Public Class FacturasCollectionClass
    Inherits ColleccionBase(Of FacturasClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal Entidad As FacturasClass)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.CabFacturasEntity)
        Me.Add(New FacturasClass(Entidad))
    End Sub
#End Region
End Class

Public Class FacturasDetalleClass
    'Inherits ClassBase(Of EC.DetFacturasEntity)
    Inherits EC.DetFacturasEntity
    Private _FacturasCabecero As FacturasClass
    Private _TipoGanado As TipoGanadoClass

#Region "Constructores"

    Public Sub New()
        MyBase.FetchUsingPK(NoFactura, Renglon)
    End Sub

    Sub New(ByVal Entidad As EC.DetFacturasEntity)
        If Not MyBase.FetchUsingPK(Entidad.FolFactura, Entidad.CveRenglon) AndAlso Not Entidad.IsDirty Then
            Me.NoFactura = Entidad.FolFactura
            Me.FechaFactura = Entidad.FecFactura
            Me.Renglon = Entidad.CveRenglon
            Me.TipoFactura = Entidad.TipoFactu
            Me.IdTipoGanado = Entidad.CveGanado
            Me.CabezasxTipoGanado = Entidad.Cabezas
            Me.Corral = Entidad.CveCorral
            Me.KilosxTipoGanado = Entidad.Kilos
            Me.PrecioxKiloxTipoGanado = Entidad.PrecioxKilo
            Me.PorcentajeIVA = Entidad.PtjIva
            Me.Estatus = Entidad.Status
            Me.FechaContable = Entidad.FecConta
            Me.Polizas = Entidad.FolPoliza
            Me.FechaCancelacion = Entidad.FecCancelacion
            Me.IdAlmacen = Entidad.CveAlmacen
            Me.IdProducto = Entidad.CveProducto
            Me.Servicios = Entidad.BooServicio
            Me.CantidadxProducto = Entidad.Cantidad
            Me.CostoUnitario = Entidad.CostoUni
            Me.PrecioUnitario = Entidad.Status
            Me.Descripcion = Entidad.Descripcion
            Me.IsNew = True
            Me.IsDirty = Entidad.IsDirty
        End If
    End Sub

#End Region

#Region "Propiedades"

    Public Property NoFactura() As String
        Get
            Return MyBase.FolFactura
        End Get
        Set(ByVal value As String)
            MyBase.FolFactura = value
        End Set
    End Property

    Public Property FechaFactura() As Date
        Get
            Return MyBase.FecFactura
        End Get
        Set(ByVal value As Date)
            MyBase.FecFactura = value
        End Set
    End Property
    Public Property Renglon() As Integer
        Get
            Return MyBase.CveRenglon
        End Get
        Set(ByVal value As Integer)
            MyBase.CveRenglon = value
        End Set
    End Property
    Public Property TipoFactura() As Integer
        Get
            Return MyBase.TipoFactu
        End Get
        Set(ByVal value As Integer)
            MyBase.TipoFactu = value
        End Set
    End Property

    Public Property IdTipoGanado() As Integer
        Get
            If MyBase.CveGanado > 0 Then
                Return MyBase.CveGanado
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            MyBase.CveGanado = value
        End Set
    End Property

    Public ReadOnly Property TipoGanado() As TipoGanadoClass
        Get
            If _TipoGanado Is Nothing Then
                _TipoGanado = New TipoGanadoClass(Me.McgcatTiposdeGanado)
            End If
            Return _TipoGanado
        End Get
    End Property

    Public Property CabezasxTipoGanado() As Integer
        Get
            If MyBase.Cabezas > 0 Then
                Return MyBase.Cabezas
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            MyBase.Cabezas = value
        End Set
    End Property
    Public Property Corral() As String
        Get
            Return MyBase.CveCorral
        End Get
        Set(ByVal value As String)
            MyBase.CveCorral = value
        End Set
    End Property
    Public Property KilosxTipoGanado() As Decimal
        Get
            If MyBase.Kilos > 0 Then
                Return MyBase.Kilos
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Decimal)
            MyBase.Kilos = value
        End Set
    End Property
    Public Property PrecioxKiloxTipoGanado() As Decimal
        Get
            If IsDBNull(MyBase.PrecioxKilo) Then
                Return 0
            Else
                Return MyBase.PrecioxKilo
            End If
        End Get
        Set(ByVal value As Decimal)
            MyBase.PrecioxKilo = value
        End Set
    End Property
    Public Property PorcentajeIVA() As Decimal
        Get
            If MyBase.PtjIva = 0 Then
                Return 0
            Else
                Return MyBase.PtjIva
            End If
        End Get
        Set(ByVal value As Decimal)
            MyBase.PtjIva = value
        End Set
    End Property
    Public Property Estatus() As String
        Get
            Return MyBase.Status
        End Get
        Set(ByVal value As String)
            MyBase.Status = value
        End Set
    End Property
    Public Property FechaContable() As Date
        Get
            Return MyBase.FecConta
        End Get
        Set(ByVal value As Date)
            MyBase.FecConta = value
        End Set
    End Property
    Public Property Polizas() As Integer
        Get
            Return MyBase.FolPoliza
        End Get
        Set(ByVal value As Integer)
            MyBase.FolPoliza = value
        End Set
    End Property
    Public Property FechaCancelacion() As Date
        Get
            Return MyBase.FecCancelacion
        End Get
        Set(ByVal value As Date)
            MyBase.FecCancelacion = value
        End Set
    End Property
    Public Property IdAlmacen() As Integer
        Get
            Return MyBase.CveAlmacen
        End Get
        Set(ByVal value As Integer)
            MyBase.CveAlmacen = value
        End Set
    End Property
    Public Property IdProducto() As Integer
        Get
            If MyBase.CveProducto > 0 Then
                Return MyBase.CveProducto
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            MyBase.CveProducto = value
        End Set
    End Property
    Public Property Servicios() As String
        Get
            Return MyBase.BooServicio
        End Get
        Set(ByVal value As String)
            MyBase.BooServicio = value
        End Set
    End Property
    Public Property CantidadxProducto() As Decimal
        Get
            If MyBase.Cantidad > 0 Then
                Return MyBase.Cantidad
            Else
                Return 0
            End If            
        End Get
        Set(ByVal value As Decimal)
            MyBase.Cantidad = value
        End Set
    End Property
    Public Property CostoUnitario() As Decimal
        Get
            If MyBase.CostoUni > 0 Then
                Return MyBase.CostoUni
            Else
                Return 0
            End If            
        End Get
        Set(ByVal value As Decimal)
            MyBase.CostoUni = value
        End Set
    End Property
    Public Property PrecioUnitario() As Decimal
        Get
            If MyBase.PrecioUni > 0 Then
                Return MyBase.PrecioUni
            Else
                Return 0
            End If
            'Return MyBase.PrecioUni
        End Get
        Set(ByVal value As Decimal)
            MyBase.PrecioUni = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return MyBase.Descripcion
        End Get
        Set(ByVal value As String)
            MyBase.Descripcion = value
        End Set
    End Property

    Public ReadOnly Property ImporteVenta() As Decimal
        Get
            Return Me.Kilos * Me.PrecioxKilo
        End Get
    End Property

    Public Property CveProductoServ() As String
        Get
            Return MyBase.CveProdServ
        End Get
        Set(ByVal value As String)
            MyBase.CveProdServ = value
        End Set
    End Property

    Public Property CveUnidad() As String
        Get
            Return MyBase.CveUnidad
        End Get
        Set(ByVal value As String)
            MyBase.CveUnidad = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return MyBase.Iva
        End Get
        Set(ByVal value As Decimal)
            MyBase.Iva = value
        End Set
    End Property

    Public Property Total() As Decimal
        Get
            Return MyBase.Total
        End Get
        Set(ByVal value As Decimal)
            MyBase.Total = value
        End Set
    End Property

    Public Property Subtotal() As Decimal
        Get
            Return MyBase.Subtotal
        End Get
        Set(ByVal value As Decimal)
            MyBase.Subtotal = value
        End Set
    End Property

    Public Property Unidad() As String
        Get
            Return MyBase.Unidad
        End Get
        Set(ByVal value As String)
            MyBase.Unidad = value
        End Set
    End Property


#End Region

#Region "Metodos"
    Friend Sub EstablecerCabecero(ByRef Cabecero As FacturasClass)
        _FacturasCabecero = Cabecero
    End Sub

    Public Shadows Function Save() As Boolean
        Me.NoFactura = Me.CabFacturas.FolFactura
        Me.Fechafactura = Me.CabFacturas.FecFactura
        Return MyBase.Save()
    End Function

    Public Shadows Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        Trans.Add(Me)
        Me.Save()
    End Function

#End Region
End Class

Public Class FacturasDetalleCollectionClass
    Inherits ColleccionBase(Of FacturasDetalleClass)

#Region "Miembros"
    Dim _Cabecero As FacturasClass
#End Region

#Region "Constructores"
    Sub New(ByRef Cabecero As FacturasClass)
        _Cabecero = Cabecero
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property Cabecero() As FacturasClass
        Get
            Return _Cabecero
        End Get
    End Property
#End Region

#Region "Metodos"

    Protected Overrides Function AddNewCore() As Object
        Dim FacturasDetalle As FacturasDetalleClass = CType(MyBase.AddNewCore(), FacturasDetalleClass)
        FacturasDetalle.EstablecerCabecero(Cabecero)
        Return FacturasDetalle
    End Function

    Public Shadows Sub Add(ByVal Entidad As FacturasDetalleClass)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.DetFacturasEntity)
        Me.Add(New FacturasDetalleClass(Entidad))
    End Sub
   

    
#End Region
End Class