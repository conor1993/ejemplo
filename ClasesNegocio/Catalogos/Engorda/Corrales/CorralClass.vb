Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CorralClass
    Inherits ClassBase(Of EC.McecatCorralesCabEntity)

#Region "Miembros"
    Private m_detalle As CorralDetalleCollectionClass
    Private _Cabezas As Integer
    Private _Kilos As Decimal
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.McecatCorralesCabEntity
        Entity.FechaBaja = "01/01/1900"
    End Sub

    Sub New(ByVal Entidad As EC.McecatCorralesCabEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As String)
        Entity = New EC.McecatCorralesCabEntity(Codigo)
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdCorral() As String
        Get
            Return Entity.IdCorral
        End Get
        Set(ByVal value As String)
            Entity.IdCorral = value
        End Set
    End Property

    Property Descripcion() As String
        Get
            Return Entity.NombreCorral
        End Get
        Set(ByVal value As String)
            Entity.NombreCorral = value
        End Set
    End Property

    Property DescCorta() As String
        Get
            Return Entity.NomCorCorral
        End Get
        Set(ByVal value As String)
            Entity.NomCorCorral = value
        End Set
    End Property

    Property IdTipoCorral() As Integer
        Get
            Return Entity.IdTipoCorral
        End Get
        Set(ByVal value As Integer)
            Entity.IdTipoCorral = value
        End Set
    End Property

    Property Capacidad() As Decimal
        Get
            Return Entity.Capacidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Capacidad = value
        End Set
    End Property

    Property Superficie() As Decimal
        Get
            Return Entity.Superficie
        End Get
        Set(ByVal value As Decimal)
            Entity.Superficie = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
        End Set
    End Property

    Property MotivoBaja() As String
        Get
            Return Entity.MotivoBaja
        End Get
        Set(ByVal value As String)
            Entity.MotivoBaja = value
        End Set
    End Property

    Property Quiendiobaja() As Integer
        Get
            Return Entity.QuiendioBaja
        End Get
        Set(ByVal value As Integer)
            Entity.QuiendioBaja = value
        End Set
    End Property

    Public Property TipoCorral() As TipoCorral
        Get
            Return Entity.TipoCorral
        End Get
        Set(ByVal value As TipoCorral)
            Entity.TipoCorral = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As CorralDetalleCollectionClass
        Get
            If m_detalle Is Nothing Then
                m_detalle = New CorralDetalleCollectionClass
                m_detalle.RellenarMe(Entity.McecatCorralesDet)
            End If
            Return m_detalle
        End Get
    End Property

    Public ReadOnly Property TotalCabezas() As Integer
        Get
            _Cabezas = 0

            For Each Detalle As EC.McecatCorralesDetEntity In Me.Entidad.McecatCorralesDet
                _Cabezas += Detalle.ExistCabezas
            Next
            Return _Cabezas
        End Get
    End Property

    Public ReadOnly Property TotalKilos() As Decimal
        Get
            _Kilos = 0D

            For Each Detalle As EC.McecatCorralesDetEntity In Me.Entidad.McecatCorralesDet
                _Kilos += Detalle.ExistKilos
            Next
            Return _Kilos
        End Get
    End Property

    Public ReadOnly Property CostoEntradas() As Decimal
        Get
            Dim _CostoEntrada As Decimal = 0D

            For Each detalle As CorralDetalleClass In Me.Detalle
                _CostoEntrada += detalle.CostoEnt
            Next
            Return _CostoEntrada
        End Get
    End Property

    Public ReadOnly Property CostoAlimmentos() As Decimal
        Get
            Dim _CostoAlimentos As Decimal = 0D

            For Each detalle As CorralDetalleClass In Me.Detalle
                _CostoAlimentos += detalle.ImpteAlimento
            Next
            Return _CostoAlimentos
        End Get
    End Property

    Public ReadOnly Property CostoMedicamentos() As Decimal
        Get
            Dim _CostoMedicamentos As Decimal = 0D

            For Each detalle As CorralDetalleClass In Me.Detalle
                _CostoMedicamentos += detalle.ImpteMedicamento
            Next
            Return _CostoMedicamentos
        End Get
    End Property

    Public ReadOnly Property CostoTotal() As Decimal
        Get
            Return CostoAlimmentos + CostoEntradas + CostoMedicamentos
        End Get
    End Property

    Public ReadOnly Property CostoxKilo() As Decimal
        Get
            If TotalKilos = 0 Then
                Return 0
            End If
            Return CostoTotal / TotalKilos
        End Get
    End Property

    Public ReadOnly Property CostoxCabeza() As Decimal
        Get
            If TotalCabezas = 0 Then
                Return 0
            End If
            Return CostoTotal / TotalCabezas
        End Get
    End Property

    Public ReadOnly Property FechaUltimaEntrada() As Nullable(Of Date)
        Get
            Dim _FechaUltimaEntrada As Nullable(Of Date) = Nothing

            If Me.Detalle.Count > 0 Then
                _FechaUltimaEntrada = Me.Detalle(0).FechaUltEnt
            End If

            For i As Integer = 1 To Me.Detalle.Count - 1
                If _FechaUltimaEntrada > Me.Detalle(i).FechaUltEnt Then
                    _FechaUltimaEntrada = Me.Detalle(i).FechaUltEnt
                End If
            Next
            Return _FechaUltimaEntrada
        End Get
    End Property

    Public ReadOnly Property FechaUltimaSalida() As Nullable(Of Date)
        Get
            Dim _FechaUltimaSalida As Nullable(Of Date) = Nothing

            If Me.Detalle.Count > 0 Then
                _FechaUltimaSalida = Me.Detalle(0).FEchaUltSal
            End If

            For i As Integer = 1 To Me.Detalle.Count - 1
                If _FechaUltimaSalida > Me.Detalle(i).FEchaUltSal Then
                    _FechaUltimaSalida = Me.Detalle(i).FEchaUltSal
                End If
            Next
            Return _FechaUltimaSalida
        End Get
    End Property

    Public ReadOnly Property FechaUltimoReinicio() As Nullable(Of Date)
        Get
            Dim _FechaUltimoReinicio As Nullable(Of Date) = Nothing

            If Me.Detalle.Count > 0 Then
                _FechaUltimoReinicio = Me.Detalle(0).FechaUltReinicio
            End If

            For i As Integer = 1 To Me.Detalle.Count - 1
                If _FechaUltimoReinicio > Me.Detalle(i).FechaUltReinicio Then
                    _FechaUltimoReinicio = Me.Detalle(i).FechaUltReinicio
                End If
            Next
            Return _FechaUltimoReinicio
        End Get
    End Property

    Public ReadOnly Property LoteActivo() As LoteClass
        Get
            LoteActivo = Nothing

            For Each Lote As EC.McecatLotesCabEntity In Me.Entidad.McecatLotesCab
                If Lote.Estatus = 1 Then
                    LoteActivo = New LoteClass(Lote)
                    Exit For
                End If
            Next
            Return LoteActivo
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Sub RefrescarDetalle()
        If m_detalle IsNot Nothing Then m_detalle.Dispose()
        m_detalle = New CorralDetalleCollectionClass
        m_detalle.RellenarMe(Me.Entidad.McecatCorralesDet)
    End Sub
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean
        Try
            Entity.Estatus = EstatusDatos.CANCELADO
            Entity.FechaBaja = Now
            Entity.MotivoBaja = ""
            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Not trans Is Nothing Then
                trans.Add(Entity)
            End If

            Dim Col As New CC.McecatCorralesCabCollection

            If Entity.IsNew Then
                If Col.GetDbCount(HC.McecatCorralesCabFields.NombreCorral = Me.Descripcion Or HC.McecatCorralesCabFields.NomCorCorral = Me.DescCorta) > 0 Then
                    MsgBox("Ya existe otro corral con la misma Descripción o Descripcioón Corta, Ingrese otra", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If Col.GetDbCount(Not HC.McecatCorralesCabFields.IdCorral = Me.IdCorral And _
                                    (HC.McecatCorralesCabFields.NombreCorral = Me.Descripcion Or _
                                    HC.McecatCorralesCabFields.NomCorCorral = Me.DescCorta)) > 1 Then
                    MsgBox("Ya existe otro corral con la misma Descripción o Descripcioón Corta, Ingrese otra", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If

            Return Entity.Save
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal idCorral As String) As Boolean
        Try
            Return Entity.FetchUsingPK(idCorral)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function ObtenerGanado(ByVal IdTipoGanado As Integer) As CorralDetalleClass
        Return New CorralDetalleClass(Me.IdCorral, IdTipoGanado)
    End Function

#End Region
End Class