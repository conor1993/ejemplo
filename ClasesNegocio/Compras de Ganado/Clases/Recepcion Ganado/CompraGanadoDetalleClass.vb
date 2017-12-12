Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class CompraGanadoDetalleClass
    Inherits ClassBase(Of EC.DetRegComEntity)
    Implements IMovimientoGanadoDetalle, IMovimientoGanadoDetalleCancelacion

#Region "Miembros"
    Dim m_CompraGanado As CompraGanadoClass
    Dim m_TipoGanado As TipoGanadoClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.DetRegComEntity
    End Sub

    Sub New(ByVal Entidad As EC.DetRegComEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String, ByVal IdRenglon As Short, ByVal IdTipoGanado As Integer)
        Entity = New EC.DetRegComEntity(Folio, IdRenglon, IdTipoGanado)
    End Sub
#End Region

#Region "Propiedades"
    Property Folio() As String
        Get
            Return Entity.FolRecep
        End Get
        Set(ByVal value As String)
            Entity.FolRecep = value
        End Set
    End Property

    Public Property CompraGanado() As CompraGanadoClass
        Get
            If m_CompraGanado Is Nothing Then
                m_CompraGanado = New CompraGanadoClass(Entity.CabRegCom)
            ElseIf Not m_CompraGanado.Folio.Trim = Folio.Trim Then
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

    Property IdRenglon() As Short
        Get
            Return Entity.CveRenglon
        End Get
        Set(ByVal value As Short)
            Entity.CveRenglon = value
        End Set
    End Property

    Property IdTipoGanado() As Integer Implements IMovimientoGanadoDetalle.IdTipoGanado, IMovimientoGanadoDetalleCancelacion.IdTipoGanado
        Get
            Return Entity.CveGanado
        End Get
        Set(ByVal value As Integer)
            Entity.CveGanado = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Cabezas")> _
    Property CantCabezas() As Integer Implements IMovimientoGanadoDetalle.Cabezas, IMovimientoGanadoDetalleCancelacion.Cabezas
        Get
            Return Entity.CantCabezas
        End Get
        Set(ByVal value As Integer)
            Entity.CantCabezas = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Kilos Comprados")> _
    Property CantKilos() As Decimal Implements IMovimientoGanadoDetalle.Kilos, IMovimientoGanadoDetalleCancelacion.Kilos
        Get
            Return Entity.CantKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.CantKilos = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Costo X Kilo")> _
    Property PrecioXKilo() As Decimal Implements IMovimientoGanadoDetalle.CostoKilo, IMovimientoGanadoDetalleCancelacion.CostoKilo
        Get
            Return Entity.PrecioXkilo
        End Get
        Set(ByVal value As Decimal)
            Entity.PrecioXkilo = value
        End Set
    End Property

    Property Encabezado() As CompraGanadoClass
        Get
            If Me.m_CompraGanado Is Nothing Then
                m_CompraGanado = New CompraGanadoClass(Entity.CabRegCom)
            ElseIf Not m_CompraGanado.Folio = Me.Folio Then
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

    Public ReadOnly Property TipoGanado() As TipoGanadoClass
        Get
            If m_TipoGanado Is Nothing Then
                m_TipoGanado = New TipoGanadoClass(Entity.McgcatTiposdeGanado)
            ElseIf Not m_TipoGanado.IdTipoGanado = Me.IdTipoGanado Then
                m_TipoGanado.Entidad.FetchUsingPK(Me.IdTipoGanado)
                m_TipoGanado.Entidad = Entity.McgcatTiposdeGanado
            End If

            Return m_TipoGanado
        End Get
    End Property

    <System.ComponentModel.DisplayName("Kilos Recibidos")> _
    Public Property KilosRecibidos() As Decimal
        Get
            Return Entity.CantKilosRecibidos
        End Get
        Set(ByVal value As Decimal)
            Entity.CantKilosRecibidos = value
        End Set
    End Property

    Public ReadOnly Property DescripcionTipoGanado() As String
        Get
            Return TipoGanado.Descripcion
        End Get
    End Property

    Public ReadOnly Property Importe() As Decimal Implements IMovimientoGanadoDetalle.Importe, IMovimientoGanadoDetalleCancelacion.Importe
        Get
            Return Me.CantKilos * PrecioXKilo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Kilos Promedio X Cabeza")> _
    Public ReadOnly Property KilosPromXCabeza() As Decimal
        Get
            Dim resultado As Decimal = 0D

            If Me.CantCabezas > 0D Then
                resultado = Me.CantKilos / Me.CantCabezas
            End If

            Return resultado
        End Get
    End Property

    <System.ComponentModel.DisplayName("Costo Promedio X Cabeza")> _
    Public ReadOnly Property CostoPromXCabeza() As Decimal
        Get
            Return Me.KilosPromXCabeza * Me.PrecioXKilo
        End Get
    End Property

    Public ReadOnly Property MovimeintoGanado() As MovimientoGanadoClass Implements IMovimientoGanadoDetalle.MovimeintoGanado
        Get
            Return Me.CompraGanado.MovimientoGanado
        End Get
    End Property

    Public ReadOnly Property FolioMovimeintoGanado() As String Implements IMovimientoGanadoDetalle.FolioMovimeintoGanado
        Get
            Return Me.MovimeintoGanado.FolioMovimeinto
        End Get
    End Property

    Public Property FechaMovimiento() As Date Implements IMovimientoGanadoDetalle.FechaMovimiento
        Get
            Return Me.CompraGanado.FechaRecepcion
        End Get
        Private Set(ByVal value As Date)
            'No se requeire se agrego para su compatibilidad con la interfase
        End Set
    End Property

    Public ReadOnly Property MovimientoGanadoCancelacion() As MovimientoGanadoClass Implements IMovimientoGanadoDetalleCancelacion.MovimeintoGanado
        Get
            Return Me.CompraGanado.MovimientoGanadoCancelacion
        End Get
    End Property

    Public ReadOnly Property FolioMovimientoGanadoCancelacion() As String Implements IMovimientoGanadoDetalleCancelacion.FolioMovimeintoGanado
        Get
            Return Me.MovimientoGanadoCancelacion.FolioMovimeinto
        End Get
    End Property

    Public Property FechaCancelacion() As System.Nullable(Of Date) Implements IMovimientoGanadoDetalleCancelacion.FechaCancelacion
        Get
            Return Me.CompraGanado.FechaCancelacion
        End Get
        Private Set(ByVal value As System.Nullable(Of Date))
            'No se requeire se agrego para su compatibilidad con la interfase
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Entity.FetchUsingPK(Folio, IdRenglon, IdTipoGanado)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Trans.Add(Entity)
            TipoGanado.Entidad.Refetch()
            Trans.Add(Me.TipoGanado.Entidad)

            TipoGanado.AcumuladoCabezas += Me.CantCabezas
            TipoGanado.AcumuladoKilos += ((Me.CantKilos / Me.CompraGanado.KilosComprados) * Me.CompraGanado.KilosRecibidos)
            TipoGanado.FechaUltimaEntrada = Me.FechaMovimiento

            Entity.Save()
            Me.TipoGanado.Entidad.Save()

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shadows Function Borrar(ByVal tran As HC.Transaction) As Boolean
        Try
            Me.TipoGanado.Entidad.Refetch()
            tran.Add(Me.TipoGanado.Entidad)

            Me.TipoGanado.AcumuladoKilos -= ((Me.CantKilos / Me.CompraGanado.KilosComprados) * Me.CompraGanado.KilosRecibidos)
            Me.TipoGanado.AcumuladoCabezas -= Me.CantCabezas
            Me.TipoGanado.FechaUltimaSalida = Me.FechaCancelacion

            Me.TipoGanado.Entidad.Save()

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
    '    Try
    '        Dim Nuevo As Boolean = False

    '        If Not Trans Is Nothing Then
    '            Trans.Add(Entity)
    '        Else
    '            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Poliza")
    '            Trans.Add(Entity)
    '            Nuevo = True
    '        End If

    '        Entity.Delete()

    '        If Nuevo Then
    '            Trans.Commit()
    '        End If

    '        Return True
    '    Catch ex As Exception
    '        Trans.Rollback()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        Return False
    '    End Try
    'End Function
#End Region
End Class