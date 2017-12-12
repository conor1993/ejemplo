Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class PlazaClass
    Inherits ClassBase(Of EC.PlazaEntity)

    Private PlazaCollection As New CC.PlazaCollection
    Private _ListasPrecio As ListaPrecioCollectionClass
    Private _ListaBase As ListaPrecioClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)

    Public ReadOnly Property Sucursales() As SucursalCollectionClass
        Get
            Dim sucs As New SucursalCollectionClass
            sucs.Obtener(Entity.Codigo, CondicionEnum.ACTIVOS)
            Return sucs
        End Get
    End Property

    <System.ComponentModel.DisplayName("Código Plaza")> _
    Public Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha Alta")> _
    Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Alta Usuario")> _
    Public Property CodigoUsuarioAlta() As Integer
        Get
            Return Entity.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.UsuarioAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha Baja")> _
    Public Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Baja Usuario")> _
    Public Property CodigoUsuarioBaja() As Integer
        Get
            Return Entity.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            Entity.UsuarioBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Motivo Baja")> _
    Public Property CodigoMotivoBaja() As Integer
        Get
            Return Entity.MotivoBaja
        End Get
        Set(ByVal value As Integer)
            Entity.MotivoBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones Baja")> _
    Public Property ObservacionesBaja() As String
        Get
            Return Entity.ObservacionesBaja
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Lista de Precio")> _
    Public ReadOnly Property ListasPrecio() As ListaPrecioCollectionClass
        Get
            If _ListasPrecio Is Nothing Then
                If Me.Entity.ListaPrecio.Count > 0 Then
                    _ListasPrecio = New ListaPrecioCollectionClass
                    _ListasPrecio.RellenarMe(Entity.ListaPrecio)
                End If
            End If

            Return _ListasPrecio
        End Get
    End Property

    <ComponentModel.DisplayName("Lista de Precios Base")> _
    Public ReadOnly Property ListaBase() As ListaPrecioClass
        Get
            If _ListaBase Is Nothing Then
                If Entity.ListaPrecio.Count > 0 Then
                    _ListaBase = New ListaPrecioClass
                    _ListaBase.LeerEntidad(Entity.ListaPrecio(0))
                End If
            End If

            Return _ListaBase
        End Get
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Estatus Descripcion")> _
    Public ReadOnly Property EstatusDescripcion() As String
        Get
            Return Me.Estatus.ToString
        End Get
    End Property

    Sub New()
        'Inicializacion de Todas las variables
        Entity = New EC.PlazaEntity
        'PlazaEntity.Plaza = 0
        Entity.Descripcion = ""
        Entity.DescripcionCorta = ""
        Entity.Observaciones = ""
        Entity.FechaAlta = Now
        Entity.UsuarioAlta = 0
        Entity.Estatus = EstatusEnum.ACTIVO
        Entity.FechaBaja = New Date(1900, 1, 1)
        Entity.UsuarioBaja = 0
        Entity.MotivoBaja = 0
        Entity.ObservacionesBaja = ""
    End Sub

    Sub New(ByVal Entidad As EC.PlazaEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.PlazaEntity(Codigo)
    End Sub

    Public Overloads Function Borrar() As Boolean
        Try
            Entity.Estatus = EstatusEnum.INACTIVO
            If Entity.Save() Then Return True
            RaiseEvent MensajeError(Me, "La plaza no se pudo borrar.")
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Overloads Function Guardar() As Boolean
        Dim PlazaC As New PlazaCollectionClass
        Dim PlazaE As New EC.PlazaEntity
        If Entity.IsNew Then
            If PlazaC.Obtener(Me) > 0 Then
                PlazaE = PlazaC.Item(0).ObtenerEntidad
                If PlazaE.Estatus = EstatusEnum.INACTIVO Then
                    RaiseEvent MensajeError(Me, "La Plaza ya existe en estado inactivo...")
                Else
                    RaiseEvent MensajeError(Me, "La Plaza ya existe.")
                End If
            Else
                Return Entity.Save()
            End If
        Else
            If PlazaC.Obtener(Me) > -1 Then
                If PlazaC.Count > 0 Then
                    PlazaE = PlazaC.Item(0).ObtenerEntidad
                Else
                    PlazaE = Entity
                End If
                If PlazaE.Codigo = Me.Codigo Then
                    Return Entity.Save()
                Else
                    RaiseEvent MensajeError(Me, "La Plaza ya existe.")
                End If
            Else
                RaiseEvent MensajeError(Me, "Ha ocurrido un error al querer guardar la plaza.")
            End If
        End If
        Return False
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            If Entity.FetchUsingPK(Codigo) Then
                Return True
            End If
            RaiseEvent MensajeError(Me, "La plaza especificada no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

End Class