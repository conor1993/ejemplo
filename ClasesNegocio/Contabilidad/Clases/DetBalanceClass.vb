Imports IC = Integra.Clases
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CM = System.ComponentModel

Public Class DetBalanceClass
    Inherits ClassBase(Of EC.DetBalanceEntity)

    Dim _Cuenta As CuentaContableClass
    Dim _Balance As CabBalanceClass

#Region "Constructores"
    Sub New()
        Entity = New EC.DetBalanceEntity
    End Sub

    Sub New(ByVal Entidad As EC.DetBalanceEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdBalance As String, ByVal IdCuentaContrable As Integer, ByVal IdEmpresa As Integer)
        Entity = New EC.DetBalanceEntity(IdBalance, IdCuentaContrable)
    End Sub
#End Region

#Region "Propiedades"

    Public Property IdBalance() As String
        Get
            Return Entity.CveBalance
        End Get
        Set(ByVal value As String)
            Entity.CveBalance = value
        End Set
    End Property

    Public Property IdRenglon() As Integer
        Get
            Return Entity.CveRenglon
        End Get
        Set(ByVal value As Integer)
            Entity.CveRenglon = value
        End Set
    End Property

    Public Property SumaResta() As Char
        Get
            Return CChar(Entity.StaSumaResta)
        End Get
        Set(ByVal value As Char)
            Entity.StaSumaResta = value
        End Set
    End Property

    Public Property IdCuentaContable() As Integer
        Get
            Return Entity.CveCuentaContable
        End Get
        Set(ByVal value As Integer)
            Entity.CveCuentaContable = value
        End Set
    End Property

    Public Property Cuenta() As CuentaContableClass
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _Cuenta
        End Get
        Set(ByVal value As CuentaContableClass)
            _Cuenta = value
            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property Cta() As String
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _Cuenta.CuentaMayor
        End Get
    End Property

    Public ReadOnly Property SCta() As String
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _Cuenta.SubCuenta
        End Get
    End Property

    Public ReadOnly Property SSCta() As String
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _Cuenta.SSubCuenta
        End Get
    End Property

    Public ReadOnly Property SSSCta() As String
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _Cuenta.SSSubCuenta
        End Get
    End Property

    Public Property Saldo() As Decimal
        Get
            Return Entity.Saldo
        End Get
        Set(ByVal value As Decimal)
            Entity.Saldo = value
        End Set
    End Property

    Public Property Balance() As CabBalanceClass
        Get
            If _Balance Is Nothing Then
                Return New CabBalanceClass(Entity.CabBalance)
            End If
            Return _Balance
        End Get
        Set(ByVal value As CabBalanceClass)
            If Not value Is Nothing Then
                Entity.CabBalance = value.ObtenerEntidad
            End If
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal IdBalance As String, ByVal IdRenglon As Integer, ByVal IdEmpresa As Integer) As Boolean
        Return Entity.FetchUsingPK(IdBalance, IdRenglon)
    End Function

    Private Function ObtenerCuentas() As Boolean
        Try
            If Not _Cuenta Is Nothing Then
                Dim Coleccion As New CC.CuentaContableCollection
                Coleccion.GetMulti(HC.CuentaContableFields.Cta = Me.Cta And HC.CuentaContableFields.SubCta = Me.SCta And HC.CuentaContableFields.SsubCta = Me.SSCta And _
                  HC.CuentaContableFields.SssubCta = Me.SSSCta And HC.CuentaContableFields.BooAfectable = True)

                If Coleccion.Count > 0 Then
                    Entity.CuentaContable = Coleccion(0)
                    _Cuenta.LeerEntidad(Entity.CuentaContable)
                Else
                    Dim TempCta As New CuentaContableClass
                    TempCta.CuentaMayor = Me.Cta
                    TempCta.SubCuenta = Me.SCta
                    TempCta.SSubCuenta = Me.SSCta
                    TempCta.SSSubCuenta = Me.SSSCta
                    _Cuenta = TempCta
                    Entity.CuentaContable = Nothing
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region
End Class