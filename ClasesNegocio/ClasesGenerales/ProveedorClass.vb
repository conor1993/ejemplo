Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = Integralab.ORM.StoredProcedureCallerClasses.ActionProcedures


Public Class ProveedorClass
    Inherits ClassBase(Of EC.ProveedorEntity)

    'Private ProveedorCollection As New CC.ProveedorCollection
    Private Benef As BeneficiarioClass
    Private ProveedorAvanzado As New EC.ProveedorAvanzadoEntity
    Private ProvAvanzado As ProvAvanzadoClass
    Private ProveedorDF As New EC.DomicilioFiscalEntity
    Private ProveedorContable As New ProvDtosContablesCollectionClass
    Private _LugarDeCompra As LugaresDeCompraClass
    Private Mipoblacion As New PoblacionClass
    Private _DomicilioFiscales As New DomicilioFiscalCollectionClass
    Private _Beneficiario As New BeneficiarioClass
    Private _comprasCol As New RecepcionOrdenCompraCollectionClass
    Private _pagoscol As New PagosProveedoresColeccionClass
    Dim tmp As CuentaContableClass
    Dim tmp2 As CuentaContableClass
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)

    Sub New()

        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        Entity = New EC.ProveedorEntity()
        Me.Mipoblacion = New PoblacionClass
        Me.Poblacion = New PoblacionClass
        Entity.Rfc = ""
        Entity.RazonSocial = ""
        Entity.Beneficiario = ""
        Entity.Contacto = ""
        Entity.ReprecentanteLegal = ""
        Entity.Domicilio = ""
        Entity.Colonia = ""
        Entity.CodigoPostal = ""
        Entity.CodigoPoblacion = 0
        Entity.Estatus = EstatusEnum.ACTIVO
        Entity.UsuarioAlta = 0
        ProveedorAvanzado = New EC.ProveedorAvanzadoEntity
        ProveedorAvanzado.Email = ""
        ProveedorAvanzado.Web = ""
        ProveedorAvanzado.PrioridadPago = CType(PPagoEnum.NO, Short)
        ProveedorAvanzado.CodigoTipoProveedor = 0
        ProveedorAvanzado.DiaRevision = 0
        ProveedorAvanzado.DiaPago = 0
        ProveedorAvanzado.Telefono1 = ""
        ProveedorAvanzado.Telefono2 = ""
        ProveedorAvanzado.Fax = ""
        ProveedorAvanzado.LadaTel1 = ""
        ProveedorAvanzado.LadaTel2 = ""
        ProveedorAvanzado.LadaFax = ""
        ProveedorAvanzado.DiasCredito = 0
        ProveedorAvanzado.PorcentajeDescuento = 0
        ProveedorAvanzado.ClaveBancaria = 0
        ProveedorAvanzado.CodigoBanco = 0
        ProveedorAvanzado.PrClaveBancaria = 0
        ProveedorAvanzado.PrNoCuenta = 0
        ProveedorAvanzado.ClaveMonedas = 0
        Entity.Idcontdiottiposterceros = 0
        Entity.Idcontdiottiposoperacion = 0

    End Sub

    Sub New(ByVal Entidad As EC.ProveedorEntity)
        Entity = Entidad
        ProveedorAvanzado = Entidad.ProveedorAvanzado
    End Sub

    Sub New(ByVal IdProveedor As Integer)
        Entity = New EC.ProveedorEntity(IdProveedor)
        ProveedorAvanzado = New EC.ProveedorAvanzadoEntity(IdProveedor)
    End Sub

    Public Overloads Sub LeerEntidad(ByVal Entidad As Object())
        Me.Entity = CType(Entidad(0), EC.ProveedorEntity)
        Me.ProveedorAvanzado = CType(Entidad(1), EC.ProveedorAvanzadoEntity)
        'Me.ProveedorContable = Entidad(2)
    End Sub

#Region "propiedades"
    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Razón Social")> _
    Public Property RazonSocial() As String
        Get
            Return Entity.RazonSocial
        End Get
        Set(ByVal value As String)
            Entity.RazonSocial = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha")> _
    Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum
        Get
            Return CType(Entity.Estatus, EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("R.F.C.")> _
    Public Property rfc() As String
        Get
            Return Entity.Rfc
        End Get
        Set(ByVal value As String)
            Entity.Rfc = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("NomBeneficiario")> _
    Public Property NomBeneficiario() As String
        Get
            Return Entity.Beneficiario
        End Get
        Set(ByVal value As String)
            Entity.Beneficiario = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Beneficiario")> _
    Public ReadOnly Property Beneficiario() As BeneficiarioClass
        Get
            If _Beneficiario Is Nothing Then
                _Beneficiario = New BeneficiarioClass(Entity.Beneficiario_(0))
            End If
            Return _Beneficiario
        End Get
    End Property

    <System.ComponentModel.DisplayName("Contacto")> _
    Public Property Contacto() As String
        Get
            Return Entity.Contacto
        End Get
        Set(ByVal value As String)
            Entity.Contacto = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Representante")> _
    Public Property RepLegal() As String
        Get
            Return Entity.ReprecentanteLegal
        End Get
        Set(ByVal value As String)
            Entity.ReprecentanteLegal = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Domicilio")> _
    Public Property Domicilio() As String
        Get
            Return Entity.Domicilio
        End Get
        Set(ByVal value As String)
            Entity.Domicilio = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Colonia")> _
    Public Property Colonia() As String
        Get
            Return Entity.Colonia
        End Get
        Set(ByVal value As String)
            Entity.Colonia = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("C.P.")> _
    Public Property CP() As String
        Get
            Return Entity.CodigoPostal
        End Get
        Set(ByVal value As String)
            Entity.CodigoPostal = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estado")> _
    Public ReadOnly Property Estado() As EstadoClass
        Get
            Dim estadov As New EstadoClass(Entity.PrIdEstado)
            Return estadov
        End Get
    End Property

    <System.ComponentModel.DisplayName("Ciudad")> _
    Public ReadOnly Property Ciudad() As CiudadClass
        Get
            Dim ciudadv As New CiudadClass(Entity.PrIdEstado, Entity.PrIdCiudad)
            Return ciudadv
        End Get
    End Property

    <System.ComponentModel.DisplayName("Población")> _
    Public Property Poblacion() As PoblacionClass
        Get
            Dim poblacionv As New PoblacionClass(Entity.PrIdEstado, Entity.PrIdCiudad, Entity.CodigoPoblacion)
            Return poblacionv
        End Get
        Set(ByVal value As PoblacionClass)
            Dim poblacionv As New PoblacionClass(value.ObtenerEntidad)
            Entity.CodigoPoblacion = poblacionv.Codigo
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Es de Ganado")> _
    Public Property EsdeGanado() As Nullable(Of Boolean)
        Get
            If Not Entity.EsdeGanado.HasValue Then
                Return False
            Else
                Return Entity.EsdeGanado
            End If
        End Get
        Set(ByVal value As Nullable(Of Boolean))
            Entity.EsdeGanado = value
        End Set
    End Property

    'Datos Avanzados
    <System.ComponentModel.DisplayName("Email")> _
    Public Property Email() As String
        Get
            Return ProveedorAvanzado.Email
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.Email = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Prioridad Pago")> _
    Public Property ppago() As PPagoEnum
        Get
            Return CType(ProveedorAvanzado.PrioridadPago, PPagoEnum)
        End Get
        Set(ByVal value As PPagoEnum)
            ProveedorAvanzado.PrioridadPago = CType(value, Short)
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Web")> _
    Public Property Web() As String
        Get
            Return ProveedorAvanzado.Web
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.Web = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Tipo Proveedor")> _
    Public Property TipoProveedor() As Nullable(Of Integer)
        Get
            Return ProveedorAvanzado.CodigoTipoProveedor
        End Get
        Set(ByVal value As Nullable(Of Integer))
            ProveedorAvanzado.CodigoTipoProveedor = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Dia Revisión")> _
    Public Property DiaRevision() As DiasEnum
        Get
            Return CType(ProveedorAvanzado.DiaRevision, DiasEnum)
        End Get
        Set(ByVal value As DiasEnum)
            ProveedorAvanzado.DiaRevision = CType(value, Byte)
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Dia Pago")> _
    Public Property DiaPago() As DiasEnum
        Get
            Return CType(ProveedorAvanzado.DiaPago, DiasEnum)
        End Get
        Set(ByVal value As DiasEnum)
            ProveedorAvanzado.DiaPago = CType(value, Byte)
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono1() As String
        Get
            Return ProveedorAvanzado.Telefono1
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.Telefono1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono2() As String
        Get
            Return ProveedorAvanzado.Telefono2
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.Telefono2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fax")> _
    Public Property Fax() As String
        Get
            Return ProveedorAvanzado.Fax
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.Fax = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property lada1() As String
        Get
            Return ProveedorAvanzado.LadaTel1
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.LadaTel1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property lada2() As String
        Get
            Return ProveedorAvanzado.LadaTel2
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.LadaTel2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada Fax")> _
    Public Property ladafax() As String
        Get
            Return ProveedorAvanzado.LadaFax
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.LadaFax = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Dia Credito")> _
    Public Property DiasCredito() As Short
        Get
            Return ProveedorAvanzado.DiasCredito
        End Get
        Set(ByVal value As Short)
            ProveedorAvanzado.DiasCredito = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descuento")> _
    Public Property PorcDescto() As Byte
        Get
            Return ProveedorAvanzado.PorcentajeDescuento
        End Get
        Set(ByVal value As Byte)
            ProveedorAvanzado.PorcentajeDescuento = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Banco")> _
    Public Property Banco() As Nullable(Of Integer)
        Get
            Return ProveedorAvanzado.CodigoBanco
        End Get
        Set(ByVal value As Nullable(Of Integer))
            ProveedorAvanzado.CodigoBanco = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Clave Interbancaria")> _
    Public Property Clabe() As String
        Get
            Return ProveedorAvanzado.ClaveBancaria
        End Get
        Set(ByVal value As String)
            ProveedorAvanzado.ClaveBancaria = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("ClaveBancaria")> _
    Public Property prClaveBancaria() As Int64?
        Get
            Return ProveedorAvanzado.PrClaveBancaria
        End Get
        Set(ByVal value As Int64?)
            ProveedorAvanzado.PrClaveBancaria = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("CuentaBancaria")> _
    Public Property prNoCuenta() As Int64?
        Get
            Return ProveedorAvanzado.PrNoCuenta

        End Get
        Set(ByVal value As Int64?)
            ProveedorAvanzado.PrNoCuenta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Tipomoneda")> _
    Public Property TipoMoneda() As Integer?
        Get
            Return ProveedorAvanzado.ClaveMonedas

        End Get
        Set(ByVal value As Integer?)
            ProveedorAvanzado.ClaveMonedas = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("TipoTerceros")> _
    Public Property TipoTerceros() As Integer?
        Get
            Return Entity.Idcontdiottiposterceros

        End Get
        Set(ByVal value As Integer?)
            Entity.Idcontdiottiposterceros = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("TipoOperacion")> _
    Public Property TipoOperacion() As Integer?
        Get
            Return Entity.Idcontdiottiposoperacion

        End Get
        Set(ByVal value As Integer?)
            Entity.Idcontdiottiposoperacion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Porcentaje Financiero")> _
    Public Property PorcentajeFinanciero() As Nullable(Of Decimal)
        Get
            If Not ProveedorAvanzado.PorcentajeFinanciero.HasValue Then
                Return 0
            Else
                Return ProveedorAvanzado.PorcentajeFinanciero
            End If
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            ProveedorAvanzado.PorcentajeFinanciero = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Facturacion Automatica")> _
    Public Property AutoFactura() As Nullable(Of Boolean)
        Get
            If Not ProveedorAvanzado.AutoFactura.HasValue Then
                Return False
            Else
                Return ProveedorAvanzado.AutoFactura
            End If
        End Get
        Set(ByVal value As Nullable(Of Boolean))
            ProveedorAvanzado.AutoFactura = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Nombre")> _
    Public Property Nombre() As String
        Get
            Return Entity.Nombre
        End Get
        Set(ByVal value As String)
            Entity.Nombre = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha de Ultima Compra")> _
    Public Property FechaUltimaCompra() As Nullable(Of Date)
        Get
            If Not Entity.FechaUltimaCompra.HasValue Then
                Return New DateTime(1753, 1, 1)
            Else
                Return Entity.FechaUltimaCompra
            End If
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaUltimaCompra = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Importe de Ultima Compra")> _
    Public Property ImporteUltimaCompra() As Nullable(Of Decimal)
        Get
            If Not Entity.ImporteUltimaCompra.HasValue Then
                Return 0
            Else
                Return Entity.ImporteUltimaCompra
            End If
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.ImporteUltimaCompra = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha de Ultimo Pago")> _
    Public Property FechaUltimoPago() As Nullable(Of Date)
        Get
            If Not Entity.FechaUltimoPago.HasValue Then
                Return New DateTime(1753, 1, 1)
            Else
                Return Entity.FechaUltimoPago
            End If
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaUltimoPago = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Importe de Ultimo Pago")> _
    Public Property ImporteUltimoPago() As Nullable(Of Decimal)
        Get
            If Not Entity.ImporteUltimoPago.HasValue Then
                Entity.ImporteUltimoPago = 0D
            End If
            Return Entity.ImporteUltimoPago
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.ImporteUltimoPago = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Compras Año Actual")> _
    Public Property ComprasAnoActual() As Nullable(Of Decimal)
        Get
            If Not Entity.ComprasAnoActual.HasValue Then
                Entity.ComprasAnoActual = 0D
            End If
            Return Entity.ComprasAnoActual
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.ComprasAnoActual = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Compras Año Anterior")> _
    Public Property ComprasAnoAnterior() As Nullable(Of Decimal)
        Get
            If Not Entity.ComprasAnoAnterior.HasValue Then
                Entity.ComprasAnoAnterior = 0D
            End If
            Return Entity.ComprasAnoAnterior
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.ComprasAnoAnterior = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Saldo Actual")> _
    Public Property SaldoActual() As Nullable(Of Decimal)
        Get
            If Not Entity.SaldoActual.HasValue Then
                Entity.SaldoActual = 0D
            End If
            Return Entity.SaldoActual
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.SaldoActual = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Codigo Lugar de Compra")> _
    Public Property IdLugarCompra() As Nullable(Of Integer)
        Get
            If Not Entity.IdLugarCompra.HasValue Then
                Entity.IdLugarCompra = -1
            End If
            Return Entity.IdLugarCompra
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdLugarCompra = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Acumulado Compras de Cabeza")> _
    Public Property AcumComCab() As Nullable(Of Decimal)
        Get
            If Not Entity.AcumComCab.HasValue Then
                Entity.AcumComCab = 0D
            End If
            Return Entity.AcumComCab
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.AcumComCab = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Acumulados Compras de Kilos")> _
    Public Property AcumComKil() As Nullable(Of Decimal)
        Get
            If Not Entity.AcumComKil.HasValue Then
                Entity.AcumComKil = 0D
            End If
            Return Entity.AcumComKil
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.AcumComKil = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Acumulados Compras de Cabeza Anterior")> _
    Public Property AcumComCabAnterior() As Nullable(Of Decimal)
        Get
            If Not Entity.AcumComCabAnterior.HasValue Then
                Entity.AcumComCabAnterior = 0D
            End If
            Return Entity.AcumComCabAnterior
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.AcumComCabAnterior = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Acumulados Compras de Kilos Anterior")> _
    Public Property AcumComKilAnterior() As Nullable(Of Decimal)
        Get
            If Not Entity.AcumComKilAnterior.HasValue Then
                Entity.AcumComKilAnterior = 0D
            End If
            Return Entity.AcumComKilAnterior
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            Entity.AcumComKilAnterior = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Prov. Meat.")> _
    Public Property ProvMeat() As Boolean
        Get
            Return Entity.PrMeat
        End Get
        Set(ByVal value As Boolean)
            Entity.PrMeat = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Prov. P.V.")> _
    Public Property ProvPuntoVenta() As Boolean
        Get
            Return Entity.PrPuntoVenta
        End Get
        Set(ByVal value As Boolean)
            Entity.PrPuntoVenta = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Cuenta Contable")> _
    Public Property cuentacontable() As ProvDtosContablesCollectionClass
        Get
            Return ProveedorContable
        End Get
        Set(ByVal value As ProvDtosContablesCollectionClass)
            ProveedorContable = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Cuenta Contable")> _
    Public Property CuentaContable2() As CuentaContableClass
        Get
            If tmp Is Nothing Then
                tmp = New CuentaContableClass(Entity.CuentaContable)
            End If
            If Entity.CuentaContId.GetValueOrDefault(0) > 0 Or Entity.IsNew Then tmp = New CuentaContableClass(Entity.CuentaContable)
            Return tmp
        End Get
        Set(ByVal value As CuentaContableClass)
            tmp = value
            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Cuenta Anticipo")> _
    Public Property CuentaAnticipo() As CuentaContableClass
        Get
            If tmp2 Is Nothing Then
                tmp2 = New CuentaContableClass(Entity.CuentaContable_)
            End If
            Return tmp2
        End Get
        Set(ByVal value As CuentaContableClass)
            tmp2 = value
            If value Is Nothing Then
                Entity.CuentaContable_ = Nothing
            Else
                Entity.CuentaContable_ = value.ObtenerEntidad
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Domicilios Fiscales")> _
    Public Property DomicilioFiscales() As DomicilioFiscalCollectionClass
        Get
            Return Me._DomicilioFiscales
        End Get
        Set(ByVal value As DomicilioFiscalCollectionClass)
            Me._DomicilioFiscales = value
        End Set
    End Property

    Public Property ProveeorAvanzado() As ProvAvanzadoClass
        Get
            If Me.ProvAvanzado Is Nothing Then
                Me.ProvAvanzado = New ProvAvanzadoClass
                Me.ProvAvanzado.LeerEntidad(Me.Entity.ProveedorAvanzado)
            End If
            Return Me.ProvAvanzado
        End Get
        Set(ByVal value As ProvAvanzadoClass)
            Me.ProvAvanzado = value
            If value Is Nothing Then
                Me.Entity.ProveedorAvanzado = Nothing
            Else
                Me.Entity.ProveedorAvanzado = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property LugarDeCompra() As LugaresDeCompraClass
        Get
            If Me._LugarDeCompra Is Nothing Then
                Me._LugarDeCompra = New LugaresDeCompraClass(Me._LugarDeCompra.Entidad)
            End If
            Return Me._LugarDeCompra
        End Get
        Set(ByVal value As LugaresDeCompraClass)
            Me._LugarDeCompra = value

            If value Is Nothing Then
                Entity.CatLugaresDeCompra = Nothing
            Else
                Entity.CatLugaresDeCompra = value.Entidad
            End If
        End Set
    End Property

    Public ReadOnly Property UltimaCompraObj As RecepcionOrdenCompraClass
        Get
            _comprasCol = New RecepcionOrdenCompraCollectionClass
            _comprasCol.Obtener(Me.Codigo, "", CondicionEnum.ACTIVOS)
            Dim cont As Integer = _comprasCol.Count
            If cont > 0 Then
                Return _comprasCol(cont - 1)
            End If
            Dim _comp As New RecepcionOrdenCompraClass
            _comp = Nothing
            Return _comp
        End Get
    End Property

    Public ReadOnly Property UltimaPagoObj(ByVal Idempresa As Integer) As PagosProveedoresClass
        Get
            _pagoscol = New PagosProveedoresColeccionClass
            _pagoscol.Obtener(Me.Codigo, "", Idempresa)
            Dim cont As Integer = _pagoscol.Count
            If cont > 0 Then
                Return _pagoscol(cont - 1)
            End If
            Dim _comp As New PagosProveedoresClass
            _comp = Nothing
            Return _comp
        End Get
    End Property

    Public ReadOnly Property ComprasAnioActual() As Integer
        Get
            _comprasCol = New RecepcionOrdenCompraCollectionClass
            _comprasCol.Obtener(Me.Codigo, Date.Now.Year)
            Dim cont As Integer = _comprasCol.Count
            If cont > 0 Then
                Return _comprasCol.Count
            End If

        End Get
    End Property

    Public ReadOnly Property ComprasAnioAnterior() As Integer
        Get
            _comprasCol = New RecepcionOrdenCompraCollectionClass
            _comprasCol.Obtener(Me.Codigo, Date.Now.Year - 1)
            Dim cont As Integer = _comprasCol.Count
            If cont > 0 Then
                Return _comprasCol.Count
            End If

        End Get
    End Property
#End Region

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Overrides Function ToString() As String
        Return Me.RazonSocial
    End Function

    Public Function Borrar() As Boolean
        Try
            Dim Facturas As New CC.UsrCxpfacturasCabCollection
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasCabFields.IdProveedor = Me.Codigo)
            filtro.Add(HC.UsrCxpfacturasCabFields.Estatus = EstatusFacturasEnum.ABONADA Or HC.UsrCxpfacturasCabFields.Estatus = EstatusFacturasEnum.VIGENTE)
            Dim F As Integer = Facturas.GetDbCount(filtro)
            If F > 0 Then
                RaiseEvent MensajeError(Me, "No se Puede Cancelar el Proveedor, Se le Deben Facturas.")
            Else
                Entity.Estatus = EstatusEnum.INACTIVO
                If Entity.Save() Then Return True
                RaiseEvent MensajeError(Me, "El Proveedor no se pudo borrar.")
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Shadows Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Entity)
            Trans.Add(ProveedorAvanzado)

            If Entity.IsNew Then
                If Entity.Save() Then
                    Dim beneficiario As New Integralab.ORM.EntityClasses.BeneficiarioEntity

                    ProveedorAvanzado.Proveedor = Entity

                    beneficiario.Proveedor = Entity
                    beneficiario.Estatus = EstatusEnum.ACTIVO
                    beneficiario.Beneficiario = Entity.RazonSocial
                    Trans.Add(beneficiario)
                    beneficiario.Save()

                    If ProveedorAvanzado.Save Then
                        Trans.Commit()
                        Entity.Refetch()
                        Return True
                    Else
                        Trans.Rollback()
                        MsgBox("El Proveedor no pudo ser guardado, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                Else
                    Trans.Rollback()
                    MsgBox("El Proveedor no pudo ser guardado, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If ProveedorAvanzado.Save() AndAlso Entity.Save() Then
                    Trans.Commit()
                    Entity.Refetch()
                    Return True
                Else
                    Trans.Rollback()
                    MsgBox("El Proveedor no pudo ser guardado, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Trans.Dispose()
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            If Entity.FetchUsingPK(Codigo) Then
                ProveedorAvanzado.FetchUsingPK(Codigo)
                Dim COL As New CC.DomicilioFiscalCollection
                COL.GetMulti(HC.DomicilioFiscalFields.Rfc = rfc)
                For Each x As EC.DomicilioFiscalEntity In COL
                    ProveedorDF = x
                Next
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Proveedor especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function ObtenerEntidad() As Object()
        Dim Entidad(1) As Object
        Entidad(0) = Me.Entity
        Entidad(1) = Me.ProveedorAvanzado
        Return Entidad
    End Function

    Public Sub AgregarDatosContables(ByVal DtoContable As ProvDtosContablesClass)
        ProveedorContable.Add(DtoContable)
    End Sub

    Public Function obtenerDatos(ByVal Codigo As Integer) As Boolean
        Try
            If Entity.FetchUsingPK(Codigo) Then
                ProveedorAvanzado = Entity.GetSingleProveedorAvanzado(True)
                'provdtoscontablesCol = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Proveedor especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Cancelar() As Boolean

    End Function

    Public Function Guardar1() As Boolean

    End Function

    'Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    'Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Shared Function CargarProveedor(ByVal IdProveedor As Integer) As ProveedorClass
        Dim Proveedor As New ProveedorClass()
        Proveedor.Obtener(IdProveedor)
        Return Proveedor
    End Function
End Class

Public Class ProveedorCollectionClass
    Inherits ColleccionBase(Of EC.ProveedorEntity, CC.ProveedorCollection, ProveedorClass)

    Private ProveedorAVCollection As New CC.ProveedorAvanzadoCollection
    Private _mostrar As MostrarEnum
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Property Mostrar() As MostrarEnum
        Get
            Return _mostrar
        End Get
        Set(ByVal value As MostrarEnum)
            _mostrar = value
        End Set
    End Property

    Public Function Listar() As String()
        Dim lista As New List(Of String)
        For Each p As ProveedorClass In Me
            lista.Add(p.NomBeneficiario)
        Next
        Return lista.ToArray
    End Function

    Public Overloads Function IndexOf(ByVal Codigo As Integer) As Integer
        IndexOf = -1

        For i As Integer = 0 To Me.Items.Count - 1
            If Me.Items(i).Codigo = Codigo Then
                Return i
            End If
        Next
        Return IndexOf
    End Function

    Public Overloads Function Obtener(ByVal RazonSocial As String, ByVal TipoProveedor As TipoProveedorClass, ByVal Estatus As CondicionEnum) As Integer
        ProveedorAVCollection = New Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection

        Me.Clear()

        Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

        If Not IsNothing(TipoProveedor) Then
            If Not Estatus = CondicionEnum.TODOS Then
                filtro.Add(Integralab.ORM.HelperClasses.ProveedorFields.Estatus = Estatus)
            End If

            If RazonSocial <> "" Then
                filtro.Add(HC.ProveedorFields.RazonSocial Mod (String.Format("%{0}%", RazonSocial)))
            End If

            Me.coleccion.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

            Dim filtro2 As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            filtro.Add(Integralab.ORM.HelperClasses.ProveedorAvanzadoFields.CodigoTipoProveedor = TipoProveedor.Codigo)
            Me.ProveedorAVCollection.GetMulti(filtro2)

            For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                Dim Proveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = ProveedorEntity
                Entidades(1) = ProveedorAVCollection(0)
                Proveedor.LeerEntidad(Entidades)
                Me.Add(Proveedor)
            Next
        End If
        ' Rellenar()
        Return Me.Count
    End Function

    Public Overloads Function Obtener(ByVal TipoProveedor As Integer, ByVal Estatus As CondicionEnum) As Integer
        Try
            'ProveedorAVCollection = New Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Dim rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection
            rel.Add(EC.ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            If Not IsNothing(TipoProveedor) Then
                filtro.Add(HC.ProveedorAvanzadoFields.CodigoTipoProveedor = TipoProveedor)
            End If
            filtro.Add(HC.ProveedorFields.Estatus = Estatus)
            Me.coleccion.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), rel)
            For Each proveedorEntity As EC.ProveedorEntity In coleccion
                Dim Proveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = proveedorEntity
                Entidades(1) = proveedorEntity.GetSingleProveedorAvanzado
                Proveedor.LeerEntidad(Entidades)
                Me.Add(Proveedor)
            Next
            Return Me.Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Obtener2(ByVal Beneficiario As String, Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Not Beneficiario = "" Then
                filtro.Add(HC.ProveedorFields.Beneficiario = Beneficiario)
            End If
            If Not FcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.ProveedorFields.Estatus = FcCondicion)
            End If
            coleccion.GetMulti(filtro)
            For Each proveedorEntity As EC.ProveedorEntity In coleccion
                Dim Proveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = proveedorEntity
                Entidades(1) = proveedorEntity.GetSingleProveedorAvanzado
                Proveedor.LeerEntidad(Entidades)
                Me.Add(Proveedor)
            Next
            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS, Optional ByVal AgregarTodos As Boolean = False) As Integer
        Try
            Me.ClearItems()

            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not FcCondicion = CondicionEnum.TODOS Then
                coleccion.GetMulti(HC.ProveedorFields.Estatus = FcCondicion, 0, Orden)
            Else
                coleccion.GetMulti(Nothing)
            End If
            If AgregarTodos Then
                Dim Prov As New ProveedorClass
                Prov.RazonSocial = "TODOS"
                Me.Add(Prov)
            End If
            For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                Dim Proveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = ProveedorEntity
                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
                Proveedor.LeerEntidad(Entidades)
                Me.Add(Proveedor)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal AgregarTodos As Boolean, ByVal RazonSocial As String, ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()

            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not FcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.ProveedorFields.Estatus = FcCondicion)
            End If

            If Not RazonSocial = "" Then
                filtro.Add(HC.ProveedorFields.RazonSocial Mod (String.Format("%{0}%", RazonSocial)))
            End If
            Me.coleccion.GetMulti(filtro, 0, Orden)
            For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                Dim Proveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = ProveedorEntity
                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
                Proveedor.LeerEntidad(Entidades)
                Me.Add(Proveedor)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal RazonSocial As String) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not RazonSocial = "" Then
                filtro.Add(HC.ProveedorFields.RazonSocial = Trim(RazonSocial))
            End If
            Me.coleccion.GetMulti(filtro, 0, Orden)
            For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                Dim Proveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = ProveedorEntity
                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
                Proveedor.LeerEntidad(Entidades)
                Me.Add(Proveedor)
            Next
            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal RazonSocial As String, ByVal RFC As String, Optional ByVal Codigo As Integer = -1, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Codigo = -1 Then
                Filtro.Add(HC.ProveedorFields.RazonSocial Mod String.Format("%{0}%", RazonSocial))
                Filtro.Add(HC.ProveedorFields.Rfc Mod String.Format("%{0}%", RFC))
            Else
                Filtro.Add(HC.ProveedorFields.Codigo = Codigo)
            End If

            If Not fccondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.ProveedorFields.Estatus = fccondicion)
            End If

            Dim Conteo As Integer = 0

            coleccion.GetMulti(Filtro)

            For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                Dim MiProveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = ProveedorEntity
                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
                'Entidades(2) = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
                MiProveedor.LeerEntidad(Entidades)
                Me.Add(MiProveedor)
                Conteo += 1
            Next
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Proveedor As ProveedorClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.ProveedorFields.Codigo = Proveedor.Codigo)
            Dim Conteo As Integer = coleccion.GetDbCount(Filtro)

            If Conteo > 0 Then
                coleccion.GetMulti(Filtro)
                For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                    Dim MiProveedor As New ProveedorClass
                    Dim Entidades(1) As Object
                    Entidades(0) = ProveedorEntity
                    Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
                    MiProveedor.LeerEntidad(Entidades)
                    Me.Add(MiProveedor)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal TipoBusqueda As TipoBusquedaEnum, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.Clear()
            Dim Conteo As Integer = 0

            If Mostrar = MostrarEnum.TODOS Then
                If fccondicion = CondicionEnum.TODOS Then
                    coleccion.GetMulti(Nothing)
                Else
                    coleccion.GetMulti(HC.ProveedorFields.Estatus = fccondicion)
                End If
            Else
                If fccondicion = CondicionEnum.TODOS Then
                    coleccion.GetMulti(HC.ProveedorFields.Codigo = Mostrar)
                Else
                    coleccion.GetMulti(HC.ProveedorFields.Codigo = Mostrar And HC.ProveedorFields.Estatus = fccondicion)
                End If
            End If

            For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                Dim Proveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = ProveedorEntity
                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
                Proveedor.LeerEntidad(Entidades)
                Proveedor.DomicilioFiscales = New DomicilioFiscalCollectionClass
                Me.Add(Proveedor)
                Conteo += 1
            Next
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal IdProveedor As Integer) As ProveedorClass
        Try
            Me.Clear()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.ProveedorFields.Codigo = IdProveedor)
            coleccion.GetMulti(Filtro)
            For Each ProveedorEntity As EC.ProveedorEntity In coleccion
                Dim MiProveedor As New ProveedorClass
                Dim Entidades(1) As Object
                Entidades(0) = ProveedorEntity
                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
                'Entidades(2) = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
                MiProveedor.LeerEntidad(Entidades)
                Me.Add(MiProveedor)
            Next
            Return Me(0)
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Guardar() As Integer
        coleccion = New CC.ProveedorCollection
        ProveedorAVCollection = New CC.ProveedorAvanzadoCollection
        'ProveedorDCCollection = New CC.ProveedoresControlContableCollection
        For Each Proveedor As ProveedorClass In Me
            Dim ProveedorEntity As New EC.ProveedorEntity
            Dim ProveedorAVEntity As New EC.ProveedorAvanzadoEntity
            'Dim proveedorDCEntity As New EC.ProveedoresControlContableEntity
            Dim Entidades(2) As Object
            Entidades = Proveedor.ObtenerEntidad()
            ProveedorEntity = CType(Entidades(0), EC.ProveedorEntity)
            ProveedorAVEntity = CType(Entidades(1), EC.ProveedorAvanzadoEntity)
            'proveedorDCEntity = Entidades(2)
            coleccion.Add(ProveedorEntity)
            ProveedorAVCollection.Add(ProveedorAVEntity)
            'ProveedorDCCollection.Add(proveedorDCEntity)
        Next
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Proveedor")
        Try
            Trans.Add(coleccion)
            Dim Conteo As Integer = coleccion.SaveMulti()
            If Conteo <= 0 Then
                Trans.Rollback()
                RaiseEvent MensajeError(Me, "No se pudo Guardar Informacion del Proveedor.")
            Else
                Trans.Add(ProveedorAVCollection)
                If ProveedorAVCollection.SaveMulti() <= 0 Then
                    Trans.Rollback()
                    RaiseEvent MensajeError(Me, "No se pudo Guardar Informacion del Proveedor.")
                Else

                    Trans.Commit()
                End If
            End If
            Return Conteo
        Catch ex As Exception
            Trans.Rollback()
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        coleccion = New CC.ProveedorCollection
        ProveedorAVCollection = New CC.ProveedorAvanzadoCollection
        For Each Proveedor As ProveedorClass In Me
            Dim ProveedorEntity As New EC.ProveedorEntity
            Dim ProveedorAVEntity As New EC.ProveedorAvanzadoEntity
            Dim Entidades(1) As Object
            Entidades = Proveedor.ObtenerEntidad()
            ProveedorEntity = CType(Entidades(0), EC.ProveedorEntity)
            ProveedorAVEntity = CType(Entidades(1), EC.ProveedorAvanzadoEntity)
            coleccion.Add(ProveedorEntity)
            ProveedorAVCollection.Add(ProveedorAVEntity)

        Next
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Proveedor")
        Try
            Dim Conteo As Integer = 0
            Trans.Add(ProveedorAVCollection)
            If ProveedorAVCollection.DeleteMulti() <= 0 Then
                Trans.Rollback()
                RaiseEvent MensajeError(Me, "No se pudieron borrar los Proveedores.")
            Else
                Trans.Add(coleccion)
                Conteo = coleccion.DeleteMulti()
                If Conteo <= 0 Then
                    Trans.Rollback()
                    RaiseEvent MensajeError(Me, "No se pudieron borrar los Proveedores.")
                Else
                    Trans.Commit()
                End If
            End If
            Return Conteo
        Catch ex As Exception
            Trans.Rollback()
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CRepProveedor
        Dim Reportes As New CRepProveedor
        Dim ds As New DataSet
        Dim dtProv As New DSetProveedor.ProveedorDataTable
        For Each Prov As ProveedorClass In Me
            Dim domicilio As String = Prov.Domicilio & " " & Prov.Colonia
            dtProv.AddProveedorRow(Prov.Codigo.ToString, Prov.RazonSocial, Prov.rfc, Prov.Contacto, Prov.RepLegal, domicilio, Prov.Estatus.ToString)
        Next
        ds.Tables.Add(dtProv)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Catálogos/Proveedores")
        Return Reportes
    End Function

    Public Shared Function CargarProveedores(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Proveedores As New CC.ProveedorCollection()

        Try
            Proveedores.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, OC.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return Proveedores.GetList()
    End Function
End Class