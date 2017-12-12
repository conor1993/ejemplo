Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class PagoCheDevueltoCabClass
    Inherits EC.PagoCheDevueltoCabEntity

#Region "Miembros"

    Private _Detalles As PagoCheDevueltoDetCollectionClass = Nothing
    Private _BancoDeposito As BancosClass = Nothing

    Enum EstatusPago As Byte
        CANCELADO = 0
        VIGENTE
    End Enum

#End Region

#Region "Constructores"

    Sub New(ByVal IdPagoCheDevueltoCab As Integer)
        FetchUsingPK(IdPagoCheDevueltoCab)
    End Sub

    Sub New(ByVal Entidad As EC.PagoCheDevueltoCabEntity)
        Me.FetchUsingPK(Entidad.IdPagoCheDevueltoCab)

        If Entidad.IsDirty Then
            MyBase.FechaCaptura = Entidad.FechaCaptura
            MyBase.FechaPago = Entidad.FechaPago
            MyBase.Saldo = Entidad.Saldo
            MyBase.Importe = Entidad.Importe
            MyBase.IdBancoDeposito = Entidad.IdBancoDeposito
            MyBase.Referencia = Entidad.Referencia
            MyBase.Estatus = Entidad.Estatus
        End If
    End Sub

    Sub New(ByVal FechaPago As Date, ByVal Saldo As Decimal, ByVal Importe As Decimal, ByVal IdBancoDeposito As Integer, ByVal Referencia As String)
        Me.FechaPago = FechaPago
        Me.Saldo = Saldo
        Me.Importe = Importe

        If IdBancoDeposito > 0 Then
            Me.IdBancoDeposito = IdBancoDeposito
        End If
        Me.Referencia = Referencia
    End Sub

#End Region

#Region "Propiedades"

    Public Shadows Property Estatus() As EstatusPago
        Get
            Return CType(MyBase.Estatus, EstatusPago)
        End Get
        Set(ByVal value As EstatusPago)
            MyBase.Estatus = CType(value, Byte)
        End Set
    End Property

    Public ReadOnly Property Detalles() As PagoCheDevueltoDetCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New PagoCheDevueltoDetCollectionClass(Me)

                For Each _Det As EC.PagoCheDevueltoDetEntity In Me.PagoCheDevueltoDet
                    _Detalles.Add(_Det)
                Next
            End If
            Return _Detalles
        End Get
    End Property

    Public ReadOnly Property Cliente() As ClientesIntroductoresClass
        Get
            If Me.Detalles.Count > 0 Then
                Return Me.Detalles(0).ChequeDevuelto.Cliente
            End If
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property BancoDeposito() As BancosClass
        Get
            If _BancoDeposito Is Nothing OrElse Me.IdBancoDeposito.HasValue AndAlso _BancoDeposito.Codigo <> Me.IdBancoDeposito.Value Then
                _BancoDeposito = New BancosClass(Me.IdBancoDeposito)
            End If
            Return _BancoDeposito
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Overrides Function ToString() As String
        Return MyBase.Folio
    End Function

    Private Sub GuardarDetalle(ByRef Trans As HC.Transaction)
        For i As Integer = 0 To Me.Detalles.Count - 1
            Dim DetallePago As PagoCheDevueltoDetClass = Me.Detalles(i)
            DetallePago.IdPagoCheDevueltoDet = i + 1
            Trans.Add(DetallePago)
            DetallePago.Save()
        Next
    End Sub

    Friend Sub Guardar(ByRef Trans As HC.Transaction)
        Me.FechaCaptura = Now
        Me.Estatus = EstatusPago.VIGENTE
        Trans.Add(Me)
        Me.Save()
        Me.GuardarDetalle(Trans)
    End Sub

    Friend Sub Cancelar(ByRef Trans As HC.Transaction)
        Me.FechaCancelacion = Now
        Me.Estatus = EstatusPago.CANCELADO
        Trans.Add(Me)
        Me.Save()
    End Sub

#End Region

End Class

Public Class PagoCheDevueltoCabCollectionClass
    Inherits ColleccionBase(Of PagoCheDevueltoCabClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal Entidad As PagoCheDevueltoCabClass)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.PagoCheDevueltoCabEntity)
        Me.Add(New PagoCheDevueltoCabClass(Entidad))
    End Sub
#End Region
End Class
