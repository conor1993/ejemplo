Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class PagoCheDevueltoDetClass
    Inherits EC.PagoCheDevueltoDetEntity

#Region "Miembros"
    Private _PagoCabecero As PagoCheDevueltoCabClass
    Private _ChequeDevuelto As ChequeDevueltoClass
#End Region

#Region "Constructores"

    Sub New(ByVal IdPagoCheDevueltoCab As Integer, ByVal IdPagoCheDevueltoDet As Integer)
        Me.FetchUsingPK(IdPagoCheDevueltoCab, IdPagoCheDevueltoDet)
    End Sub

    Sub New(ByVal Entidad As EC.PagoCheDevueltoDetEntity)
        Me.IdPagoCheDevueltoCab = Entidad.IdPagoCheDevueltoCab
        Me.IdPagoCheDevueltoDet = Entidad.IdPagoCheDevueltoDet
        Me.IdChequeDevuelto = Entidad.IdChequeDevuelto
        Me.Saldo = Entidad.Saldo
        Me.Importe = Entidad.Importe
    End Sub

    Sub New(ByVal IdPagoCheDevueltoCab As Integer, ByVal IdPagoCheDevueltoDet As Integer, ByVal IdChequeDevuelto As Integer, ByVal Saldo As Decimal, ByVal Importe As Decimal)
        Me.IdPagoCheDevueltoCab = IdPagoCheDevueltoCab
        Me.IdPagoCheDevueltoDet = IdPagoCheDevueltoDet
        Me.IdChequeDevuelto = IdChequeDevuelto
        Me.Saldo = Saldo
        Me.Importe = Importe
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property PagoCabecero() As PagoCheDevueltoCabClass
        Get
            If _PagoCabecero Is Nothing Then
                _PagoCabecero = New PagoCheDevueltoCabClass(Me.IdPagoCheDevueltoCab)
            End If
            Return _PagoCabecero
        End Get
    End Property

    Public Shadows ReadOnly Property ChequeDevuelto() As ChequeDevueltoClass
        Get
            If _ChequeDevuelto Is Nothing Then
                _ChequeDevuelto = New ChequeDevueltoClass(MyBase.ChequeDevuelto)
            End If
            Return _ChequeDevuelto
        End Get
    End Property

    Public ReadOnly Property NoCheque() As String
        Get
            Return Me.ChequeDevuelto.NoCheque
        End Get
    End Property

    Public ReadOnly Property Banco() As BancosClass
        Get
            Return Me.ChequeDevuelto.Banco
        End Get
    End Property

    Public ReadOnly Property FechaDevolucion() As Date
        Get
            Return Me.ChequeDevuelto.FechaDevolucion
        End Get
    End Property

    Public ReadOnly Property Folio() As String
        Get
            Return "P" & Me.IdPagoCheDevueltoCab.ToString.PadLeft(10, "0")
        End Get
    End Property

    Public ReadOnly Property FechaPago() As Date
        Get
            Return Me.PagoCabecero.FechaPago
        End Get
    End Property

    Public ReadOnly Property Observaciones() As String
        Get
            Return Me.PagoCabecero.Referencia
        End Get
    End Property

#End Region

#Region "Metodos"

    Friend Sub EstablecerCabecero(ByRef Cabecero As PagoCheDevueltoCabClass)
        _PagoCabecero = Cabecero
    End Sub

    Public Shadows Function Save() As Boolean
        MyBase.IdPagoCheDevueltoCab = Me.PagoCabecero.IdPagoCheDevueltoCab
        Return MyBase.Save()
    End Function

#End Region

End Class

Public Class PagoCheDevueltoDetCollectionClass
    Inherits ColleccionBase(Of PagoCheDevueltoDetClass)

#Region "Miembros"
    Private _Cabecero As PagoCheDevueltoCabClass
#End Region

#Region "Constructores"
    Sub New(ByRef Cabecero As PagoCheDevueltoCabClass)
        _Cabecero = Cabecero
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property Cabecero() As PagoCheDevueltoCabClass
        Get
            Return _Cabecero
        End Get
    End Property
#End Region

#Region "Metodos"
    Friend Sub EstablecerCabecero(ByVal Cabecero As PagoCheDevueltoCabClass)
        _Cabecero = Cabecero

        For Each Item As PagoCheDevueltoDetClass In Me.Items
            Item.EstablecerCabecero(Me.Cabecero)
        Next
    End Sub

    Protected Overrides Function AddNewCore() As Object
        Dim PagoDetalle As PagoCheDevueltoDetClass = CType(MyBase.AddNewCore(), PagoCheDevueltoDetClass)
        PagoDetalle.EstablecerCabecero(Cabecero)
        Return PagoDetalle
    End Function

    Public Shadows Sub Add(ByVal Entidad As PagoCheDevueltoDetClass)
        Entidad.EstablecerCabecero(Cabecero)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.PagoCheDevueltoDetEntity)
        Me.Add(New PagoCheDevueltoDetClass(Entidad))
    End Sub
#End Region
End Class


