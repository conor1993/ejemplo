Imports EC = Integralab.ORM.EntityClasses

Public Class ConCfgCtasClass
    Inherits ClassBase(Of EC.ConCfgCtasEntity)

#Region "Miembros"

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal IdConCfgCtas As Integer)
        Entity = New EC.ConCfgCtasEntity(IdConCfgCtas)
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property IdConCfgCtas() As Integer
        Get
            Return Entity.IdConCfgCtas
        End Get
    End Property

    Public Property Concepto() As String
        Get
            Return Entity.Concepto
        End Get
        Set(ByVal value As String)
            Entity.Concepto = value
        End Set
    End Property

    Public Property Afectable() As Nullable(Of Boolean)
        Get
            Return Entity.Afectable
        End Get
        Set(ByVal value As Nullable(Of Boolean))
            Entity.Afectable = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overrides Function ToString() As String
        Return Me.Concepto
    End Function

#End Region

End Class
