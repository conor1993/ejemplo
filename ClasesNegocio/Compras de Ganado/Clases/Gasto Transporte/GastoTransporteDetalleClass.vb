Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class GastoTransporteDetalleClass
    Inherits ClassBase(Of EC.DetGasTransEntity)

#Region "Miembros"
    Private m_ConceptoGasto As ConceptoGastosTransporteClass
    Private m_GastoTransporte As GastoTransporteClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.DetGasTransEntity
    End Sub

    Sub New(ByVal Entidad As EC.DetGasTransEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String)
        Entity = New EC.DetGasTransEntity
    End Sub
#End Region

#Region "Propiedades"
    Public Property Folio() As String
        Get
            Return Entity.FolRecep
        End Get
        Set(ByVal value As String)
            Entity.FolRecep = value
        End Set
    End Property

    Public Property GastoTransporte() As GastoTransporteClass
        Get
            If m_gastoTransporte Is Nothing Then
                m_GastoTransporte = New GastoTransporteClass(Entity.CabGasTrans)
            ElseIf Not m_GastoTransporte.Folio.Trim = Folio Then
                m_GastoTransporte.Entidad = Entity.CabGasTrans
            End If

            Return m_GastoTransporte
        End Get
        Set(ByVal value As GastoTransporteClass)
            m_GastoTransporte = value

            If value Is Nothing Then
                Entity.CabGasTrans = Nothing
            Else
                Entity.CabGasTrans = value.Entidad
            End If
        End Set
    End Property

    Public Property Renglon() As Short
        Get
            Return Entity.CveRenglon
        End Get
        Set(ByVal value As Short)
            Entity.CveRenglon = value
        End Set
    End Property

    Public Property IdGasto() As Integer
        Get
            Return Entity.CveGasto
        End Get
        Set(ByVal value As Integer)
            Entity.CveGasto = value
            PorcentajeIva = ConceptoGasto.PorcentajeIVA
        End Set
    End Property

    Public Property ConceptoGasto() As ConceptoGastosTransporteClass
        Get
            If m_ConceptoGasto Is Nothing Then
                Me.m_ConceptoGasto = New ConceptoGastosTransporteClass(Entity.McgcatConcepGastos)
            ElseIf Not Me.IdGasto = m_ConceptoGasto.IdConceptoGasto Then
                m_ConceptoGasto.Entidad = Entity.McgcatConcepGastos
            End If

            Return m_ConceptoGasto
        End Get
        Set(ByVal value As ConceptoGastosTransporteClass)
            m_ConceptoGasto = value

            If (value Is Nothing) Then
                Entity.McgcatConcepGastos = Nothing
            Else
                Entity.McgcatConcepGastos = value.Entidad
            End If
        End Set
    End Property

    Public Property PorcentajeIva() As Decimal
        Get
            Return Entity.PtjIva
        End Get
        Set(ByVal value As Decimal)
            Entity.PtjIva = value
        End Set
    End Property

    Public Property ImporteGasto() As Decimal
        Get
            Return Entity.ImpteGasto
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteGasto = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal Folio As String, ByVal cveRenglon As Short, ByVal CveGasto As Short) As Boolean
        Try
            Return Entity.FetchUsingPK(Folio, cveRenglon, CveGasto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Trans.Add(Entity)

            Return Entity.Save
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region
End Class