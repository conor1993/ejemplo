Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class PolizaModeloDetClass
    Inherits ClassBase(Of EC.PolizasModeloDetEntity)

#Region "Miembros"
    Private m_Poliza As PolizaModeloCabClass
    Private m_CuentaContable As CuentaContableClass
    Private m_Cta As String
    Private m_Subcta As String
    Private m_Ssubcta As String
    Private m_Sssubcta As String
    Private m_Afectable As Boolean
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal IdPoliza As Integer, ByVal IdDetalle As Integer)
        Entity = New EC.PolizasModeloDetEntity(IdPoliza, IdDetalle)
    End Sub

    Sub New(ByVal Entidad As EC.PolizasModeloDetEntity)
        Entity = Entidad
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdPoliza() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    Public Property IdCuentaContable() As Integer
        Get
            Return Entity.IdCuentaContable
        End Get
        Set(ByVal value As Integer)
            Entity.IdCuentaContable = value
        End Set
    End Property

    Public Property CargoAbono() As String
        Get
            Return Entity.CargoAbono
        End Get
        Set(ByVal value As String)
            Entity.CargoAbono = value
        End Set
    End Property

    Public Property Poliza() As PolizaModeloCabClass
        Get
            If Me.m_Poliza Is Nothing Then
                m_Poliza = New PolizaModeloCabClass(Entity.PolizasModeloCab)
            ElseIf Not m_Poliza.IdPoliza = Me.IdPoliza Then
                m_Poliza.Entidad = Entity.PolizasModeloCab
            End If

            Return m_Poliza
        End Get
        Set(ByVal value As PolizaModeloCabClass)
            m_Poliza = value

            If value Is Nothing Then
                Entity.PolizasModeloCab = Nothing
            Else
                Entity.PolizasModeloCab = value.Entidad
            End If
        End Set
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get
            If Me.m_CuentaContable Is Nothing Then
                m_CuentaContable = New CuentaContableClass(Entity.CuentaContable)
            ElseIf Not m_CuentaContable.Codigo = Me.IdCuentaContable Then
                m_CuentaContable.Entidad = Entity.CuentaContable
            End If

            Return m_CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            m_CuentaContable = value

            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.Entidad
            End If
        End Set
    End Property

#Region "Propiedades Ajenas"
    Public Property Cta() As String
        Get
            Return IIf(m_Cta = String.Empty, "0000", m_Cta)
        End Get
        Set(ByVal value As String)
            m_Cta = CInt(value).ToString("0000")
            Me.ConsultarCuentaContable()
        End Set
    End Property

    Public Property Subcta() As String
        Get
            Return IIf(m_Subcta = String.Empty, "0000", m_Subcta)
        End Get
        Set(ByVal value As String)
            m_Subcta = CInt(value).ToString("0000")
            Me.ConsultarCuentaContable()
        End Set
    End Property

    Public Property Ssubcta() As String
        Get
            Return IIf(m_Ssubcta = String.Empty, "0000", m_Ssubcta)
        End Get
        Set(ByVal value As String)
            m_Ssubcta = CInt(value).ToString("0000")
            Me.ConsultarCuentaContable()
        End Set
    End Property

    Public Property Sssubcta() As String
        Get
            Return IIf(m_Sssubcta = String.Empty, "0000", m_Sssubcta)
        End Get
        Set(ByVal value As String)
            m_Sssubcta = CInt(value).ToString("0000")
            Me.ConsultarCuentaContable()
        End Set
    End Property

    Public ReadOnly Property Afectable() As Boolean
        Get
            Return IIf(CuentaContable IsNot Nothing, CuentaContable.Afectable, False)
        End Get
    End Property
#End Region
#End Region

#Region "Metodos"

    Private Sub ConsultarCuentaContable()
        Try
            Dim _cuenta As New CC.CuentaContableCollection()
            _cuenta.GetMulti(HC.CuentaContableFields.Cta = Me.Cta _
            And HC.CuentaContableFields.SubCta = Me.Subcta And HC.CuentaContableFields.SsubCta = Me.Ssubcta _
            And HC.CuentaContableFields.SssubCta = Me.Sssubcta, 0, Nothing)

            If _cuenta.Count > 0 Then
                IdCuentaContable = _cuenta(0).Codigo
            Else
                IdCuentaContable = 0
                m_CuentaContable = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ActualizarCuentas()
        If Not CuentaContable Is Nothing Then
            m_Cta = CuentaContable.CuentaMayor
            m_Subcta = CuentaContable.SubCuenta
            m_Ssubcta = CuentaContable.SSubCuenta
            m_Sssubcta = CuentaContable.SSSubCuenta
        End If
    End Sub

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim Nuevo As Boolean = False

            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            Else
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Poliza")
                Trans.Add(Entity)
                Nuevo = True
            End If

            Entity.Delete()

            If Nuevo Then
                Trans.Commit()
            End If
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"

#End Region
End Class