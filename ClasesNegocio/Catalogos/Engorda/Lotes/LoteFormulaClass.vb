Imports ORM = Integralab.ORM
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class LoteFormulaClass
    Inherits EC.McecatLotesCabForEntity

#Region "Miembros"

    Private _Lote As LoteClass
    Private _Formula As ProductoGeneralClass

#End Region

#Region "Constructores"

    Sub New()
        Me.FecInicio = Now
        Me.FecFinal = FecInicio.AddMonths(1)
        Me.IsDirty = False
    End Sub

    Sub New(ByVal IdLote As Integer, ByVal IdFormula As Integer, ByVal IdRenglon As Integer, ByVal DiasFormula As Short, ByVal FechaInicio As Date, ByVal FechaFinal As Date, ByVal ConsxCabKil As Decimal, ByVal PorServida1 As Decimal, ByVal PorServida2 As Decimal, ByVal PorServida3 As Decimal, ByVal PorServida4 As Decimal)
        Me.IdLote = IdLote
        Me.IdFormula = IdFormula
        Me.IdRenglon = IdRenglon
        Me.DiasFormula = DiasFormula
        Me.FecInicio = FecInicio
        Me.FecFinal = FecFinal
        Me.ConsxCabKil = ConsxCabKil
        Me.PorServida1 = PorServida1
        Me.PorServida2 = PorServida2
        Me.PorServida3 = PorServida3
        Me.PorServida4 = PorServida4
    End Sub

    Sub New(ByVal Entidad As EC.McecatLotesCabForEntity)
        Me.IdLote = Entidad.IdLote
        Me.IdFormula = Entidad.IdFormula
        Me.IdRenglon = Entidad.IdRenglon
        Me.DiasFormula = Entidad.DiasFormula
        Me.FecInicio = Entidad.FecInicio
        Me.FecFinal = Entidad.FecFinal
        Me.ConsxCabKil = Entidad.ConsxCabKil
        Me.PorServida1 = Entidad.PorServida1
        Me.PorServida2 = Entidad.PorServida2
        Me.PorServida3 = Entidad.PorServida3
        Me.PorServida4 = Entidad.PorServida4
        Me.IsNew = Entidad.IsNew
        Me.IsDirty = Entidad.IsDirty
    End Sub

    Sub New(ByVal IdLote As Integer, ByVal IdFormula As Integer, ByVal IdRenglon As Integer)
        MyBase.FetchUsingPK(IdLote, IdFormula, IdRenglon)
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property Lote() As LoteClass
        Get
            If _Lote Is Nothing OrElse _Lote.IdLote <> IdLote Then
                _Lote = New LoteClass(Me.McecatLotesCab)
            End If
            Return _Lote
        End Get
    End Property

    Public ReadOnly Property Formula() As ProductoGeneralClass
        Get
            If _Formula Is Nothing OrElse _Formula.Codigo <> IdFormula Then
                _Formula = New ProductoGeneralClass(Me.Producto)
            End If
            Return _Formula
        End Get
    End Property

#End Region

#Region "Metodos"

    Friend Sub EstablecerCabecero(ByRef LoteCabecero As LoteClass)
        Me.IdLote = LoteCabecero.IdLote
        Me._Lote = LoteCabecero
    End Sub

#End Region

End Class

Public Class LoteFormulaCollectionClass
    Inherits ColleccionBase(Of LoteFormulaClass)

#Region "Miembros"
    Private _LoteCabecero As LoteClass
#End Region

#Region "Constructores"

    Sub New(ByVal Lote As EC.McecatLotesCabEntity)
        _LoteCabecero = New LoteClass(Lote)
    End Sub

    Sub New(ByVal Lote As LoteClass)
        _LoteCabecero = Lote
    End Sub

    Sub New()

    End Sub

#End Region

#Region "Propiedades"
    Public ReadOnly Property LoteCabecero() As LoteClass
        Get
            Return Me._LoteCabecero
        End Get
    End Property
#End Region

#Region "Metodos"
    Protected Overrides Function AddNewCore() As Object
        Dim LoteFormula As LoteFormulaClass = CType(MyBase.AddNewCore(), LoteFormulaClass)
        LoteFormula.EstablecerCabecero(LoteCabecero)
        Return LoteFormula
    End Function

    Public Shadows Sub Add(ByVal LoteFormula As LoteFormulaClass)
        LoteFormula.EstablecerCabecero(LoteCabecero)
        MyBase.Add(LoteFormula)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.McecatLotesCabForEntity)
        Me.Add(New LoteFormulaClass(Entidad))
    End Sub
#End Region

End Class
