Imports system.Windows.Forms
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class SolicitudServiciosClass
    Inherits ClassBase(Of EC.SolicitudServiciosEntity)

    Private _Detalle As SolicitudServDetCollectionClass
    Private _Sucursal As SucursalClass
    Private _UsuarioAlta As UsuarioClass

#Region "Constructores"

    Sub New()
        Me.Entity = New EC.SolicitudServiciosEntity
    End Sub

    Sub New(ByVal Entidad As EC.SolicitudServiciosEntity)
        Me.Entity = Entidad
    End Sub

    Sub New(ByVal codigo As Integer)
        Me.Entity = New EC.SolicitudServiciosEntity(codigo)
    End Sub

#End Region

#Region "Propiedades"

    Public Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing Then
                _Sucursal = New SucursalClass(Entity.Sucursal)
            End If

            Return _Sucursal
        End Get
        Set(ByVal value As SucursalClass)
            _Sucursal = value
            If value Is Nothing Then
                Entity.Sucursal = Nothing
            Else
                Entity.Sucursal = value.ObtenerEntidad
            End If
        End Set
    End Property

    Property Folio() As String
        Get
            Return Me.Entity.Folio
        End Get
        Set(ByVal value As String)
            Me.Entity.Folio = value
        End Set
    End Property

    Property SucursalId() As Integer
        Get
            Return Me.Entity.SucursalId
        End Get
        Set(ByVal value As Integer)
            Me.Entity.SucursalId = value
        End Set
    End Property

    Property IdUsuarioAlta() As Integer
        Get
            Return Me.Entity.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Me.Entity.UsuarioAlta = value
        End Set
    End Property

    Public ReadOnly Property UsuarioAlta() As UsuarioClass
        Get
            If _UsuarioAlta Is Nothing OrElse _UsuarioAlta.Codigo <> Me.IdUsuarioAlta Then
                _UsuarioAlta = New UsuarioClass(Me.IdUsuarioAlta)
            End If
            Return _UsuarioAlta
        End Get
    End Property

    Property Observaciones() As String
        Get
            Return Me.Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Me.Entity.Observaciones = value
        End Set
    End Property

    ReadOnly Property FechaAlta() As Date
        Get
            Return Me.Entity.FechaAlta
        End Get
    End Property

    Property UsuarioCancelacion() As Integer
        Get
            Return Me.Entity.UsuarioCancelacion
        End Get
        Set(ByVal value As Integer)
            Me.Entity.UsuarioCancelacion = value
        End Set
    End Property

    Property MotivoCancelacion() As Integer
        Get
            Return Me.Entity.MotivoCancelacion
        End Get
        Set(ByVal value As Integer)
            Me.Entity.MotivoCancelacion = value
        End Set
    End Property

    Property ObservacionesCancelacion() As String
        Get
            Return Me.Entity.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Me.Entity.ObservacionesCancelacion = value
        End Set
    End Property

    Property FechaCancel() As Date
        Get
            Return Me.Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return Me.Entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            Me.Entity.Estatus = value
        End Set
    End Property

    Public Property EntregarEn() As String
        Get
            Return Me.Entity.EntregarEn
        End Get
        Set(ByVal value As String)
            Me.Entity.EntregarEn = value
        End Set
    End Property

    Public Property EntregarA() As String
        Get
            Return Me.Entity.EntregarA
        End Get
        Set(ByVal value As String)
            Me.Entity.EntregarA = value
        End Set
    End Property

    Public Property FechaCaptura() As Date
        Get
            Return Me.Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaCaptura = value
        End Set
    End Property

    Public Property SolicitadoPor() As String
        Get
            Return Me.Entity.SolicitadoPor
        End Get
        Set(ByVal value As String)
            Me.Entity.SolicitadoPor = value
        End Set
    End Property

    Public Property Detalle() As SolicitudServDetCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New SolicitudServDetCollectionClass
                _Detalle.RellenarMe(Me.Entity.SolicitudServiciosDetalle)
            End If
            Return _Detalle
        End Get
        Set(ByVal value As SolicitudServDetCollectionClass)
            _Detalle = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Me.Entity)

            Me.Estatus = EstatusDatos.CANCELADO
            Me.Entity.FechaCancelacion = Now
            Me.Entity.Save()

            Trans.Add(Me.Detalle.ObtenerColeccion)

            For Each Detalle As EC.SolicitudServiciosDetalleEntity In Me.Detalle.ObtenerColeccion
                Detalle.Estatus = EstatusDatos.CANCELADO
            Next
            Me.Detalle.ObtenerColeccion.SaveMulti()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Trans.Add(Me.Entity)
            Me.FechaCaptura = Now
            Return Me.Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(Folio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

End Class

Public Class SolicitudServiciosDetClass
    Inherits ClassBase(Of EC.SolicitudServiciosDetalleEntity)

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Entidad As EC.SolicitudServiciosDetalleEntity)
        Me.Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String, ByVal Indice As Integer)
        Me.Entity = New EC.SolicitudServiciosDetalleEntity(Folio, Indice)
    End Sub

#End Region

#Region "Propiedades"

    Property Folio() As String
        Get
            Return Me.Entity.Folio
        End Get
        Set(ByVal value As String)
            Me.Entity.Folio = value
        End Set
    End Property

    Property Indice() As Integer
        Get
            Return Me.Entity.Indice
        End Get
        Set(ByVal value As Integer)
            Me.Entity.Indice = value
        End Set
    End Property

    Property Servicio() As String
        Get
            Return Me.Entity.Servicio
        End Get
        Set(ByVal value As String)
            Me.Entity.Servicio = value
        End Set
    End Property

    Property Cantidad() As Integer
        Get
            Return Me.Entity.Cantidad
        End Get
        Set(ByVal value As Integer)
            Me.Entity.Cantidad = value
        End Set
    End Property

    Property Urgente() As Boolean
        Get
            Return Me.Entity.Urgente
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.Urgente = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return Me.Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Me.Entity.Observaciones = value
        End Set
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return CType(Me.Entity.Estatus, EstatusDatos)
        End Get
        Set(ByVal value As EstatusDatos)
            Me.Entity.Estatus = CType(value, Short)
        End Set
    End Property

    Property FechaServicio() As Date
        Get
            Return Me.Entity.FechaServicio
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaServicio = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Me.Entity)

            Me.Entity.Estatus = EstatusDatos.CANCELADO
            Return Me.Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Trans.Add(Me.Entity)
            Return Me.Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal Folio As String, ByVal Indice As Integer) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(Folio, Indice)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

End Class

Public Class SolicitudServCabCollectionClass
    Inherits ColleccionBase(Of EC.SolicitudServiciosEntity, CC.SolicitudServiciosCollection, SolicitudServiciosClass)

End Class

Public Class SolicitudServDetCollectionClass
    Inherits ColleccionBase(Of EC.SolicitudServiciosDetalleEntity, CC.SolicitudServiciosDetalleCollection, SolicitudServiciosDetClass)

End Class
