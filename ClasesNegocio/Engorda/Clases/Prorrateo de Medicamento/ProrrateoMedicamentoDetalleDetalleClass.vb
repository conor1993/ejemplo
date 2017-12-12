Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProrrateoMedicamentoDetalleDetalleClass
    Inherits ClassBase(Of EC.DetDproMedEntity)

#Region "Campos"
    Private m_ProrrateoMedicamento As ProrrateoMedicamentoClass
    Private m_Medicamento As ProductoClass
    Private m_ProrrateoMedicamentoDetalle As ProrrateoMedicamentoDetalleClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.DetDproMedEntity
    End Sub

    Sub New(ByVal folioProrrateo As String, ByVal idMedicamento As Integer, ByVal idLote As Integer)
        Me.New(New EC.DetDproMedEntity(folioProrrateo, idMedicamento, idLote))
    End Sub

    Sub New(ByVal entidad As EC.DetDproMedEntity)
        Entity = entidad
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioProrrateoMedicamento() As String
        Get
            Return Entity.FolioProrrateoMedicamento
        End Get
        Set(ByVal value As String)
            Entity.FolioProrrateoMedicamento = value
        End Set
    End Property

    Public Property IdMedicamento() As Integer
        Get
            Return Entity.IdMedicamento
        End Get
        Set(ByVal value As Integer)
            Entity.IdMedicamento = value
        End Set
    End Property

    Public Property IdLote() As Integer
        Get
            Return Entity.IdLote
        End Get
        Set(ByVal value As Integer)
            Entity.IdLote = value
        End Set
    End Property

    Public Property ProrrateoMedicamento() As ProrrateoMedicamentoClass
        Get
            If Me.m_ProrrateoMedicamento Is Nothing Then
                Me.m_ProrrateoMedicamento = New ProrrateoMedicamentoClass(Entity.CabProMed)
            ElseIf Not Me.m_ProrrateoMedicamento.FolioMovimeintoSalida = Me.FolioProrrateoMedicamento Then
                Me.m_ProrrateoMedicamento.Entidad = Entity.CabProMed
            End If

            Return Me.m_ProrrateoMedicamento
        End Get
        Set(ByVal value As ProrrateoMedicamentoClass)
            Me.m_ProrrateoMedicamento = value

            If value Is Nothing Then
                Entity.CabProMed = Nothing
            Else
                Entity.CabProMed = value.Entidad
            End If
        End Set
    End Property

    Public Property Medicamento() As ProductoClass
        Get
            If Me.m_Medicamento Is Nothing Then
                Me.m_Medicamento = New ProductoClass(Entity.Producto)
            ElseIf Not Me.m_Medicamento.Codigo = IdMedicamento Then
                Me.m_Medicamento.Entidad = Entity.Producto
            End If

            Return Me.m_Medicamento
        End Get
        Set(ByVal value As ProductoClass)
            Me.m_Medicamento = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.Entidad
            End If
        End Set
    End Property

    Public Property CostoPorMedicamento() As Decimal
        Get
            Return Entity.CostoXmedi
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoXmedi = value
        End Set
    End Property

    Public Property ProrrateoMedicamentoDetalle() As ProrrateoMedicamentoDetalleClass
        Get
            If Me.m_ProrrateoMedicamentoDetalle Is Nothing Then
                Me.m_ProrrateoMedicamentoDetalle = New ProrrateoMedicamentoDetalleClass(Entity.DetProMed)
            ElseIf Not Me.m_ProrrateoMedicamentoDetalle.FolioProrrateoMedicamento = Me.FolioProrrateoMedicamento AndAlso _
                    Not Me.m_ProrrateoMedicamentoDetalle.IdMedicamento = Me.IdMedicamento Then
                Me.m_ProrrateoMedicamentoDetalle.Entidad = Entity.DetProMed
            End If

            Return Me.m_ProrrateoMedicamentoDetalle
        End Get
        Set(ByVal value As ProrrateoMedicamentoDetalleClass)
            Me.m_ProrrateoMedicamentoDetalle = value

            If value Is Nothing Then
                Entity.DetProMed = Nothing
            Else
                Entity.DetProMed = value.Entidad
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Guardar() As Boolean
        Try
            If Me.ParticipatesInTransaction Then
                Me.Transaction.Add(Entity)
            End If

            Entity.Save()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class