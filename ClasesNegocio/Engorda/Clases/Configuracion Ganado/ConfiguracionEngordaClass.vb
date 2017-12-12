Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ConfiguracionEngordaClass
    Inherits ClassBase(Of EC.ConfigGanEntity)

#Region "Miembros"

    Private m_TipoAlmacenMedicamento As TipoAlmacenClass
    Private m_TipoAlmacenFormula As TipoAlmacenClass
    Private m_TipoAlmacenRolado As TipoAlmacenClass
    Private _FamiliaMedicamentos As LineaClass

#End Region

#Region "Constructores"

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.ConfigGanEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal indice As Byte)
        MyBase.New(New EC.ConfigGanEntity(indice))
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property IdConfiguracion() As Integer
        Get
            Return Entity.IdConfiguracion
        End Get
    End Property

    Public Property TipoCambio() As Decimal
        Get
            Return Entity.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            Entity.TipoCambio = value
        End Set
    End Property

    Public Property FactorCover() As Single
        Get
            Return Entity.FactorConver
        End Get
        Set(ByVal value As Single)
            Entity.FactorConver = value
        End Set
    End Property

    Public Property IdTipoAlmacenFormula() As Nullable(Of Integer)
        Get
            Return Entity.IdTipoAlmacenFormula
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdTipoAlmacenFormula = value
        End Set
    End Property

    Public ReadOnly Property TipoAlmacenFormula() As TipoAlmacenClass
        Get
            If Me.m_TipoAlmacenFormula Is Nothing Then
                Me.m_TipoAlmacenFormula = New TipoAlmacenClass(Entity.TipoAlmacenFormula)
            ElseIf Me.IdTipoAlmacenFormula.HasValue AndAlso Not Me.m_TipoAlmacenFormula.Codigo = Me.IdTipoAlmacenFormula.Value Then
                Me.m_TipoAlmacenFormula.LeerEntidad(Entity.TipoAlmacenFormula)
            End If
            Return Me.m_TipoAlmacenFormula
        End Get
    End Property

    Public Property IdTipoAlmacenRolado() As Nullable(Of Integer)
        Get
            Return Entity.IdTipoAlmacenRolado
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdTipoAlmacenRolado = value
        End Set
    End Property

    Public ReadOnly Property TipoAlmacenRolado() As TipoAlmacenClass
        Get
            If Me.m_TipoAlmacenRolado Is Nothing Then
                Me.m_TipoAlmacenRolado = New TipoAlmacenClass(Entity.TipoAlmacenRolado)
            ElseIf Me.IdTipoAlmacenRolado.HasValue AndAlso Not Me.m_TipoAlmacenRolado.Codigo = Me.IdTipoAlmacenRolado.Value Then
                Me.m_TipoAlmacenRolado.LeerEntidad(Entity.TipoAlmacenRolado)
            End If
            Return Me.m_TipoAlmacenRolado
        End Get
    End Property

    Public Property IdTipoAlmacenMedicamento() As Nullable(Of Integer)
        Get
            Return Entity.IdTipoAlmacenMedicamento
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdTipoAlmacenMedicamento = value
        End Set
    End Property

    Public ReadOnly Property TipoAlmacenMedicamento() As TipoAlmacenClass
        Get
            If Me.m_TipoAlmacenMedicamento Is Nothing Then
                Me.m_TipoAlmacenMedicamento = New TipoAlmacenClass(Entity.TipoAlmacenMedicamento)
            ElseIf Me.IdTipoAlmacenMedicamento.HasValue AndAlso Not Me.m_TipoAlmacenMedicamento.Codigo = Me.IdTipoAlmacenMedicamento.Value Then
                Me.m_TipoAlmacenMedicamento.LeerEntidad(Entity.TipoAlmacenMedicamento)
            End If
            Return Me.m_TipoAlmacenMedicamento
        End Get
    End Property

    Public Property GDP() As Decimal
        Get
            Return Entity.Gdpini
        End Get
        Set(ByVal value As Decimal)
            Entity.Gdpini = value
        End Set
    End Property

    Public Property ImportePredial() As Decimal
        Get
            Return Entity.ImptePredial
        End Get
        Set(ByVal value As Decimal)
            Entity.ImptePredial = value
        End Set
    End Property

    Public Property PorcentajeEducacion() As Integer
        Get
            Return Entity.PtjEduca
        End Get
        Set(ByVal value As Integer)
            Entity.PtjEduca = value
        End Set
    End Property

    Public Property CostoIndirectoMensual() As Decimal
        Get
            Return Entity.CosIndMen
        End Get
        Set(ByVal value As Decimal)
            Entity.CosIndMen = value
        End Set
    End Property

    Public Property MesCostosIndirecto() As MesesCollectionClass.MesesEnum
        Get
            Return CType(Entity.MesCosInd, MesesCollectionClass.MesesEnum)
        End Get
        Set(ByVal value As MesesCollectionClass.MesesEnum)
            Entity.MesCosInd = CType(value, Byte)
        End Set
    End Property

    Public Property FechaCierreEngorda() As Date
        Get
            Return Entity.FecCieEng
        End Get
        Set(ByVal value As Date)
            Entity.FecCieEng = value
        End Set
    End Property

    Public Property IdFamiliaMedicamento() As Nullable(Of Integer)
        Get
            Return Entity.IdFamiliaMedicamento
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdFamiliaMedicamento = value
        End Set
    End Property

    Public Property RequerirArete() As Boolean
        Get
            Return Entity.RequerirArete
        End Get
        Set(ByVal value As Boolean)
            Entity.RequerirArete = value
        End Set
    End Property

    Public Property TransferirDesdeRecibaPorArete() As Boolean
        Get
            Return Entity.TransferirRecibaPorArete
        End Get
        Set(ByVal value As Boolean)
            Entity.TransferirRecibaPorArete = value
        End Set
    End Property

    Public ReadOnly Property FamiliaMedicamentos() As LineaClass
        Get
            If Me.IdFamiliaMedicamento.HasValue Then
                If Me._FamiliaMedicamentos Is Nothing OrElse Me._FamiliaMedicamentos.Codigo <> Me.IdFamiliaMedicamento.Value Then
                    Me._FamiliaMedicamentos = New LineaClass(Me.IdFamiliaMedicamento)
                End If
                Return Me._FamiliaMedicamentos
            Else
                Return Nothing
            End If
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Shadows Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Entity)
            Return Entity.Save()
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

#End Region

End Class