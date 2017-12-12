'Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ChequeDevueltoClass
    Inherits EC.ChequeDevueltoEntity

#Region "Miembros"
    Private _Banco As BancosClass = Nothing
    Private _Cliente As ClientesIntroductoresClass = Nothing
    Private _Pagos As PagoCheDevueltoDetCollectionClass = Nothing
    Private _Pagos_Vigentes As PagoCheDevueltoDetCollectionClass = Nothing

    Enum ChequeDevueltoEstatus As Byte
        CANCELADO = 0
        VIGENTE
        ABONADO
        PAGADO
    End Enum

#End Region

#Region "Constructores"
    Sub New(ByVal IdChequeDevuelto As Integer)
        Me.FetchUsingPK(IdChequeDevuelto)
    End Sub

    Sub New(ByVal NoCheque As String, ByVal IdBanco As Integer, ByVal IdCliente As Integer, ByVal FechaDevolucion As Date, ByVal Importe As Decimal, ByVal Recibio As String, ByVal Observaciones As String)
        Me.NoCheque = NoCheque
        Me.IdBanco = IdBanco
        Me.IdCliente = IdCliente
        Me.FechaDevolucion = FechaDevolucion
        Me.Importe = Importe
        Me.Recibio = Recibio
        Me.Observaciones = Observaciones
    End Sub

    Sub New(ByVal Entidad As EC.ChequeDevueltoEntity)
        Me.FetchUsingPK(Entidad.IdChequeDevuelto)

        If Entidad.IsDirty Then
            Me.NoCheque = Entidad.NoCheque
            Me.IdBanco = Entidad.IdBanco
            Me.IdCliente = Entidad.IdCliente
            Me.FechaDevolucion = Entidad.FechaDevolucion
            Me.FechaCaptura = Entidad.FechaCaptura
            Me.Observaciones = Entidad.Observaciones
            Me.Recibio = Entidad.Recibio
            Me.Importe = Entidad.Importe
            Me.Estatus = DirectCast(Entidad.Estatus, ChequeDevueltoEstatus)
        End If
    End Sub
#End Region

#Region "Propiedades"

    Public Shadows Property Estatus() As ChequeDevueltoEstatus
        Get
            Return CType(MyBase.Estatus, ChequeDevueltoEstatus)
        End Get
        Set(ByVal value As ChequeDevueltoEstatus)
            MyBase.Estatus = CType(value, Byte)
        End Set
    End Property

    Public ReadOnly Property DescripcionEstatus() As String
        Get
            Return Me.Estatus.ToString
        End Get
    End Property

    Public ReadOnly Property Banco() As BancosClass
        Get
            If _Banco Is Nothing Then
                _Banco = New BancosClass(Me.IdBanco)
            End If
            Return _Banco
        End Get
    End Property

    Public ReadOnly Property DescripcionBanco() As String
        Get
            Return Banco.Descripcion
        End Get
    End Property

    Public ReadOnly Property Cliente() As ClientesIntroductoresClass
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(Me.IdCliente)
            End If
            Return _Cliente
        End Get
    End Property

    Public ReadOnly Property NombreCliente() As String
        Get
            Return Cliente.Nombre
        End Get
    End Property

    Public ReadOnly Property Pagos() As PagoCheDevueltoDetCollectionClass
        Get
            If _Pagos Is Nothing Then
                _Pagos = New PagoCheDevueltoDetCollectionClass

                For Each _Det As EC.PagoCheDevueltoDetEntity In Me.PagoCheDevueltoDet
                    _Pagos.Add(_Det)
                Next
            End If
            Return _Pagos
        End Get
    End Property

    Public ReadOnly Property Pagos_Vigentes() As PagoCheDevueltoDetCollectionClass
        Get
            If _Pagos_Vigentes Is Nothing Then
                Dim Relacion As New OC.RelationCollection, Filtro As New OC.PredicateExpression, PagosChequesDevueltos As New CC.PagoCheDevueltoDetCollection
                Dim Orden As New OC.SortExpression(New OC.SortClause(HC.PagoCheDevueltoCabFields.FechaPago, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
                Relacion.Add(EC.PagoCheDevueltoDetEntity.Relations.PagoCheDevueltoCabEntityUsingIdPagoCheDevueltoCab)
                Filtro.Add(HC.PagoCheDevueltoDetFields.IdChequeDevuelto = Me.IdChequeDevuelto And HC.PagoCheDevueltoCabFields.Estatus = PagoCheDevueltoCabClass.EstatusPago.VIGENTE)
                PagosChequesDevueltos.GetMulti(Filtro, 0, Orden, Relacion)

                _Pagos_Vigentes = New PagoCheDevueltoDetCollectionClass

                For Each _Det As EC.PagoCheDevueltoDetEntity In PagosChequesDevueltos
                    _Pagos_Vigentes.Add(_Det)
                Next
            End If
            Return _Pagos_Vigentes
        End Get
    End Property

    Public ReadOnly Property Saldo() As Decimal
        Get
            Saldo = Me.Importe

            For Each Pago As PagoCheDevueltoDetClass In Pagos_Vigentes
                Saldo -= Pago.Importe
            Next
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Overrides Function ToString() As String
        Return Me.NoCheque
    End Function

    Public Sub Guardar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)

        If Me.IsNew Then
            Me.FechaCaptura = Now
        End If
        Me.Estatus = ChequeDevueltoEstatus.VIGENTE
        Me.Save()
    End Sub

    Public Sub Cancelar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Estatus = ChequeDevueltoEstatus.CANCELADO
        Me.Save()
    End Sub

#End Region

End Class

Public Class ChequeDevueltoCollectionClass
    Inherits ColleccionBase(Of ChequeDevueltoClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal Entidad As ChequeDevueltoClass)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.ChequeDevueltoEntity)
        Me.Add(New ChequeDevueltoClass(Entidad))
    End Sub
#End Region
End Class
