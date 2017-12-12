Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class SubcidioClass
    Inherits ClassBase(Of EC.NomSubsidioEmpleoEntity)

#Region "Propiedades"
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    Public Property Año() As Short
        Get
            Return Entity.Año
        End Get
        Set(ByVal value As Short)
            Entity.Año = value
        End Set
    End Property

    Public Property IngresoDe() As Decimal
        Get
            Return Entity.IngresosDe
        End Get
        Set(ByVal value As Decimal)
            Entity.IngresosDe = value
        End Set
    End Property

    Public Property IngresoHasta() As Decimal
        Get
            Return Entity.IngresosHasta
        End Get
        Set(ByVal value As Decimal)
            Entity.IngresosHasta = value
        End Set
    End Property

    Public Property Subcidio() As Decimal
        Get
            Return Entity.Subsidio
        End Get
        Set(ByVal value As Decimal)
            Entity.Subsidio = value
        End Set
    End Property
#End Region
End Class
