Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CorralDetalleClass
    Inherits ClassBase(Of EC.McecatCorralesDetEntity)

#Region "Definiciones"
    Private _TipoGanado As TipoGanadoClass
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
        ExistCabezas = 0D
        ExistKilos = 0D
        CostoEnt = 0D
        ImpteAlimento = 0D
        ImpteMedicamento = 0D
        KilosAlimento = 0D
        SaldoCostoInd = 0D
    End Sub

    Sub New(ByVal Entidad As EC.McecatCorralesDetEntity)
        MyBase.New(Entidad)
    End Sub

    Sub New(ByVal idCorral As String, ByVal idTipoganado As Integer)
        MyBase.New(New EC.McecatCorralesDetEntity(idCorral, idTipoganado))
    End Sub
#End Region

#Region "Propiedades"
    Property IdCorral() As String
        Get
            Return Entity.IdCorral
        End Get
        Set(ByVal value As String)
            Entity.IdCorral = value
        End Set
    End Property

    Property IdTipoGanado() As Integer
        Get
            Return Entity.IdTipoGanado
        End Get
        Set(ByVal value As Integer)
            Entity.IdTipoGanado = value
        End Set
    End Property

    Property ExistCabezas() As Decimal
        Get
            Return Entity.ExistCabezas
        End Get
        Set(ByVal value As Decimal)
            Entity.ExistCabezas = value
        End Set
    End Property

    Property ExistKilos() As Decimal
        Get
            Return Entity.ExistKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.ExistKilos = value
        End Set
    End Property

    Property CostoEnt() As Decimal
        Get
            Return Entity.CostoEnt
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoEnt = value
        End Set
    End Property

    Property ImpteMedicamento() As Decimal
        Get
            Return Entity.ImpteMedicamento
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteMedicamento = value
        End Set
    End Property

    Property ImpteAlimento() As Decimal
        Get
            Return Entity.ImpteAlimento
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteAlimento = value
        End Set
    End Property

    Property KilosAlimento() As Decimal
        Get
            Return Entity.KilosAlimento
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosAlimento = value
        End Set
    End Property

    Property FechaUltEnt() As Date
        Get
            Return Entity.FechaUltEnt
        End Get
        Set(ByVal value As Date)
            Entity.FechaUltEnt = value
        End Set
    End Property

    Property FEchaUltSal() As Date
        Get
            Return Entity.FechaUltSal
        End Get
        Set(ByVal value As Date)
            Entity.FechaUltSal = value
        End Set
    End Property

    Property FechaUltReinicio() As Date
        Get
            Return Entity.FechaUltReinicio
        End Get
        Set(ByVal value As Date)
            Entity.FechaUltReinicio = value
        End Set
    End Property

    Property SaldoCostoInd() As Decimal
        Get
            Return Entity.SaldoCostoInd
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoCostoInd = value
        End Set
    End Property

    Public ReadOnly Property TipoGanado() As TipoGanadoClass
        Get
            If _TipoGanado Is Nothing OrElse _TipoGanado.IdTipoGanado <> Me.IdTipoGanado Then
                _TipoGanado = New TipoGanadoClass(Me.IdTipoGanado)
            End If
            Return _TipoGanado
        End Get
    End Property

    Public ReadOnly Property CostoTotal() As Decimal
        Get
            Return CostoEnt + ImpteAlimento + ImpteMedicamento + SaldoCostoInd
        End Get
    End Property

    Public ReadOnly Property KilosxCabeza() As Decimal
        Get
            If ExistCabezas <> 0D Then
                Return ExistKilos / ExistCabezas
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property CostoxCabeza() As Decimal
        Get
            If ExistCabezas <> 0D Then
                Return CostoTotal / ExistCabezas
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property CostoxKilo() As Decimal
        Get
            If ExistKilos <> 0D Then
                Return CostoTotal / ExistKilos
            End If
            Return 0D
        End Get
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal idCorral As String, ByVal idTipoGanado As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(idCorral, idTipoGanado)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class