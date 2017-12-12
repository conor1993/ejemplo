Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class GastoTransporteClass
    Inherits ClassBase(Of EC.CabGasTransEntity)

#Region "Declaraciones"
    Private m_Chofer As ChoferesClass
    Private m_Vehiculo As VehiculosClass
    Private m_CompraGanado As ComprasGanadoClass
    Private m_Detalle As GastoTransporteDetalleCollectionClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.CabGasTransEntity
    End Sub

    Sub New(ByVal Entidad As EC.CabGasTransEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String)
        Entity = New EC.CabGasTransEntity(Folio)
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

    Public Property FechaRecepcion() As Date
        Get
            Return Entity.FecRecep
        End Get
        Set(ByVal value As Date)
            Entity.FecRecep = value
        End Set
    End Property

    Public Property IdChofer() As Integer
        Get
            Return Entity.CveChofer
        End Get
        Set(ByVal value As Integer)
            Entity.CveChofer = value
        End Set
    End Property

    Public Property Chofer() As ChoferesClass
        Get
            If m_Chofer Is Nothing Then
                m_Chofer = New ChoferesClass(Entity.McgcatChoferes)
            ElseIf Not m_Chofer.IdChofer = IdChofer Then
                m_Chofer.Entidad = Entity.McgcatChoferes
            End If

            Return m_Chofer
        End Get
        Set(ByVal value As ChoferesClass)
            m_Chofer = value

            If value Is Nothing Then
                Entity.McgcatChoferes = Nothing
            Else
                Entity.McgcatChoferes = value.Entidad
            End If
        End Set
    End Property

    Public Property IdVehiculo() As Integer
        Get
            Return Entity.CveVehiculo
        End Get
        Set(ByVal value As Integer)
            Entity.CveVehiculo = value
        End Set
    End Property

    Public Property Vehiculo() As VehiculosClass
        Get
            If m_Vehiculo Is Nothing Then
                m_Vehiculo = New VehiculosClass(Entity.McgcatVehiculos)
            ElseIf Not m_Vehiculo.Codigo = IdVehiculo Then
                m_Vehiculo.Entidad = Entity.McgcatVehiculos
            End If

            Return m_Vehiculo
        End Get
        Set(ByVal value As VehiculosClass)
            m_Vehiculo = value

            If value Is Nothing Then
                Entity.McgcatVehiculos = Nothing
            Else
                Entity.McgcatVehiculos = value.Entidad
            End If
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return Entity.ImpteIva
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteIva = value
        End Set
    End Property

    Public Property ImporteTotal() As Decimal
        Get
            Return Entity.ImpteTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteTotal = value
        End Set
    End Property

    Public Property FechaContabilizacion() As Date
        Get
            Return Entity.FecConta
        End Get
        Set(ByVal value As Date)
            Entity.FecConta = value
        End Set
    End Property

    Public Property NummeroPoliza() As String
        Get
            Return Entity.NumPoliza
        End Get
        Set(ByVal value As String)
            Entity.NumPoliza = value
        End Set
    End Property

    Public Property Estatus() As EstatusChar
        Get
            Return Entity.Status
        End Get
        Set(ByVal value As EstatusChar)
            Entity.Status = value
        End Set
    End Property

    Public Property CompraGanado() As ComprasGanadoClass
        Get
            'If m_CompraGanado Is Nothing Then
            '    m_CompraGanado = New ComprasGanadoClass(Entity.CabRegCom)
            'ElseIf Not m_CompraGanado.Folio.Trim = Me.Folio.Trim Then
            '    m_CompraGanado.Entidad = Entity.CabRegCom
            'End If

            'Return m_CompraGanado
        End Get
        Set(ByVal value As ComprasGanadoClass)
            'm_CompraGanado = value

            'If value Is Nothing Then
            '    Entity.CabRegCom = Nothing
            'Else
            '    Entity.CabRegCom = value.Entidad
            'End If
        End Set
    End Property

    Public ReadOnly Property Detalle() As GastoTransporteDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New GastoTransporteDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.DetGasTrans)
            End If

            Return m_Detalle
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Entity.FetchUsingPK(Folio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Dim Coleccion As New CC.CabGasTransCollection
                If Entity.IsNew Then
                    Return Entity.Save
                Else
                    Return Entity.Save
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region
End Class

Public Class GastoTransporteCollectionClass
    Inherits ColleccionBase(Of EC.CabGasTransEntity, CC.CabGasTransCollection, GastoTransporteClass)

    Public Overloads Function Obtener(ByVal Folio As String) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not Folio = "" Then filtro.Add(HC.CabGasTransFields.FolRecep = Folio)

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class