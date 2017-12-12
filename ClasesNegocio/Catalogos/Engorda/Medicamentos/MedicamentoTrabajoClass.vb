Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class MedicamentoTrabajoClass
    Inherits ClassBase(Of EC.CabMediTrabEntity)

#Region "Campos"

#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.CabMediTrabEntity
    End Sub

    Sub New(ByVal idMedicamento As Integer)
        MyBase.New(New EC.CabMediTrabEntity(idMedicamento))
    End Sub

    Sub New(ByVal entidad As EC.CabMediTrabEntity)
        MyBase.New(entidad)
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdMedicamento() As Integer
        Get
            Return Entity.CveMedi
        End Get
        Set(ByVal value As Integer)
            Entity.CveMedi = value

                Dim prod As New CC.ProductoCollection
                Dim unidad As New CC.UnidadMedidaCollection
                Dim rel As New OC.RelationCollection

                rel.Add(New OC.EntityRelation(HC.ProductoFields.CodigoUnidadMedida, HC.UnidadMedidaFields.Codigo, _
                        SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany), SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

                Nombre = prod.GetScalar(Integralab.ORM.ProductoFieldIndex.Descripcion, _
                                                    New OC.Expression(HC.ProductoFields.Descripcion), _
                                                    SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, _
                                                    HC.ProductoFields.Codigo = value)
                Me.UnidadMedida = unidad.GetScalar(Integralab.ORM.UnidadMedidaFieldIndex.DescripcionCorta, _
                                New OC.Expression(HC.UnidadMedidaFields.DescripcionCorta), _
                                SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, _
                                HC.ProductoFields.Codigo = value, rel, Nothing)
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Entity.NomMedi
        End Get
        Set(ByVal value As String)
            Entity.NomMedi = value
        End Set
    End Property

    Public Property PorCabeza() As Boolean
        Get
            Return Entity.BooXcab
        End Get
        Set(ByVal value As Boolean)
            Me.CantidadXKilo = 0D
            Me.CantidadXCabeza = 0D

            Entity.BooXcab = value
            Entity.BooXkilo = Not value
        End Set
    End Property

    Public Property PorKilo() As Boolean
        Get
            Return Entity.BooXkilo
        End Get
        Set(ByVal value As Boolean)
            Me.CantidadXKilo = 0D
            Me.CantidadXCabeza = 0D

            Entity.BooXkilo = value
            Entity.BooXcab = Not value
        End Set
    End Property

    Public Property UnidadMedida() As String
        Get
            Return Entity.Unidad
        End Get
        Set(ByVal value As String)
            Entity.Unidad = value
        End Set
    End Property

    Public Property CantidadXCabeza() As Decimal
        Get
            Return Entity.Unidades
        End Get
        Set(ByVal value As Decimal)
            If Me.PorCabeza Then Entity.Unidades = value
        End Set
    End Property

    Public Property CantidadXKilo() As Decimal
        Get
            Return Entity.UniXkilo
        End Get
        Set(ByVal value As Decimal)
            If PorKilo Then Entity.UniXkilo = value
        End Set
    End Property
#End Region
End Class