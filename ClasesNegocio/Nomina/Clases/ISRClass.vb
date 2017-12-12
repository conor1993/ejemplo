Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class ISRClass
    Inherits ClassBase(Of EC.NomIsrEntity)

#Region "Miembros"

#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    Public Property LimiteInferior() As Decimal
        Get
            Return Entity.LimiteInf
        End Get
        Set(ByVal value As Decimal)
            Entity.LimiteInf = value
        End Set
    End Property

    Public Property LimiteSuperior() As Decimal
        Get
            Return Entity.LimiteSup
        End Get
        Set(ByVal value As Decimal)
            Entity.LimiteSup = value
        End Set
    End Property

    Public Property Porcentaje() As Decimal
        Get
            Return Entity.PorcentajeParaExedente
        End Get
        Set(ByVal value As Decimal)
            Entity.PorcentajeParaExedente = value
        End Set
    End Property

    Public Property Año() As Short
        Get
            Return Entity.Año
        End Get
        Set(ByVal value As Short)
            Entity.Año = value
        End Set
    End Property

    Public Property CuotaFija() As Decimal
        Get
            Return Entity.CuotaFija
        End Get
        Set(ByVal value As Decimal)
            Entity.CuotaFija = value
        End Set
    End Property
#End Region

#Region "Metodos"

#End Region
End Class
