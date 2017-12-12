Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class MovimientosEstadosCuentaClass
    Inherits ClassBase(Of EC.MveCtaEntity)

#Region "Constructores"
    Sub New()
        Conciliado = False
    End Sub

    Sub New(ByVal Entidad As EC.MveCtaEntity)
        MyBase.New(Entidad)
    End Sub

#End Region

#Region "Propiedades"
    Public ReadOnly Property IdMveCta() As Integer
        Get
            Return Entity.IdMveCta
        End Get
    End Property

    Public Property IdCuenta() As Integer
        Get
            Return Entity.IdCuenta
        End Get
        Set(ByVal value As Integer)
            Entity.IdCuenta = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return Entity.Referencia
        End Get
        Set(ByVal value As String)
            Entity.Referencia = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return Entity.Fecha
        End Get
        Set(ByVal value As Date)
            Entity.Fecha = value
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return Entity.Concepto
        End Get
        Set(ByVal value As String)
            Entity.Concepto = value
        End Set
    End Property

    Public Property TipoMovimiento() As String
        Get
            Return Entity.TipoMov
        End Get
        Set(ByVal value As String)
            Entity.TipoMov = value
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

    Public Property Conciliado() As Boolean
        Get
            Return Entity.Conciliado
        End Get
        Set(ByVal value As Boolean)
            Entity.Conciliado = value
        End Set
    End Property

#End Region

End Class

Public Class MovimientosEstadosCuentaCollectionClass
    Inherits ColleccionBase(Of EC.MveCtaEntity, CC.MveCtaCollection, MovimientosEstadosCuentaClass)

#Region "Metodos"

    Public Overloads Function Obtener(ByVal idCuentaBancaria As Integer) As Integer
        Dim Filtro As New OC.PredicateExpression
        Filtro.Add(HC.MveCtaFields.IdCuenta = idCuentaBancaria)
        coleccion.GetMulti(Filtro)
        Rellenar()
        Return Count
    End Function

#End Region

End Class
