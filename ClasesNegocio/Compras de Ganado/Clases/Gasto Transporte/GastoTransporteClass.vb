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

#Region "Miembros"
    Private m_Chofer As ChoferesClass
    Private m_Vehiculo As VehiculosClass
    Private m_CompraGanado As CompraGanadoClass
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
            'If m_Chofer Is Nothing Then
            m_Chofer = New ChoferesClass(Entity.CveChofer)
            'ElseIf Not m_Chofer.IdChofer = IdChofer Then
            '    m_Chofer.Entidad = Entity.McgcatChoferes
            'End If

            Return m_Chofer
        End Get
        Set(ByVal value As ChoferesClass)
            m_Chofer = value

            ' If value Is Nothing Then
            'Entity.McgcatChoferes = Nothing
            ' Else
            ' Entity.McgcatChoferes = value.Entidad
            ' End If
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
            'If m_Vehiculo Is Nothing Then
            m_Vehiculo = New VehiculosClass(Entidad.CveVehiculo)
            'ElseIf Not m_Vehiculo.Codigo = IdVehiculo Then
            '    m_Vehiculo.Entidad = Entity.McgcatVehiculos
            'End If

            Return m_Vehiculo
        End Get
        Set(ByVal value As VehiculosClass)
            m_Vehiculo = value

            'If value Is Nothing Then
            '    Entity.McgcatVehiculos = Nothing
            'Else
            '    Entity.McgcatVehiculos = value.Entidad
            'End If
        End Set
    End Property

    Public ReadOnly Property SubTotal() As Decimal
        Get
            Return Me.ImporteTotal - Me.IVA
        End Get
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

    Public Property CompraGanado() As CompraGanadoClass
        Get
            If m_CompraGanado Is Nothing Then
                m_CompraGanado = New CompraGanadoClass(Entity.CabRegCom)
            ElseIf Not m_CompraGanado.Folio.Trim = Me.Folio.Trim Then
                m_CompraGanado.Entidad = Entity.CabRegCom
            End If

            Return m_CompraGanado
        End Get
        Set(ByVal value As CompraGanadoClass)
            m_CompraGanado = value

            If value Is Nothing Then
                Entity.CabRegCom = Nothing
            Else
                Entity.CabRegCom = value.Entidad
            End If
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
        Return Entity.FetchUsingPK(Folio)
    End Function

    Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Trans.Add(Entity)

        If Entity.IsNew Then
            Entity.Save()

            For Each det As GastoTransporteDetalleClass In Me.Detalle
                det.Folio = Me.Folio
                Trans.Add(det.Entidad)
                det.Entidad.Save()
            Next

            Return True
        Else
            Dim encontro As Boolean = False
            Dim detalleBD As New GastoTransporteDetalleCollectionClass

            detalleBD.Obtener(HC.CabGasTransFields.FolRecep = Me.Folio)

            For Each detBD As GastoTransporteDetalleClass In detalleBD
                encontro = False

                For Each det As GastoTransporteDetalleClass In Me.Detalle
                    If det.IdGasto = detBD.IdGasto Then
                        encontro = True
                        Exit For
                    End If
                Next

                If Not encontro Then
                    Trans.Add(detBD.Entidad)

                    detBD.Entidad.Delete()
                End If
            Next

            Entity.Save()

            For Each det As GastoTransporteDetalleClass In Me.Detalle
                det.GastoTransporte = Me
            Next

            Me.Detalle.Guardar(Trans)

            Return True
        End If
    End Function
#End Region
End Class