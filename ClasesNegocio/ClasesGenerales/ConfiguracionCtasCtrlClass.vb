Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class ConfiguracionCtasCtrlClass
    Inherits ClassBase(Of EC.CfgCtrlCtasEntity)

#Region "Miembros"

    Private _CuentaContable As CuentaContableClass
    Private _ConCfgCtas As ConCfgCtasClass

#End Region

#Region "Propiedades"

    Public Property IdConCfgCtas() As Integer
        Get
            Return Entity.IdConCfgCtas
        End Get
        Set(ByVal value As Integer)
            Entity.IdConCfgCtas = value
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

    Public ReadOnly Property CuentaContable() As CuentaContableClass
        Get
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass(Me.IdCuentaContable)
            End If
            Return _CuentaContable
        End Get
    End Property

    Public ReadOnly Property Concepto() As ConCfgCtasClass
        Get
            If _ConCfgCtas Is Nothing Then
                _ConCfgCtas = New ConCfgCtasClass(Me.IdConCfgCtas)
            End If
            Return _ConCfgCtas
        End Get
    End Property

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal IdConCfgCtas As Integer)
        Entity = New EC.CfgCtrlCtasEntity(IdConCfgCtas)
    End Sub

    Sub New(ByVal Entidad As EC.CfgCtrlCtasEntity)
        Entity = Entidad
    End Sub

#End Region

End Class