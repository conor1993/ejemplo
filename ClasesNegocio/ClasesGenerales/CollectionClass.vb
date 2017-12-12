Public Class CollectionClass(Of TipoEntidad As IEntidad)
    Inherits System.ComponentModel.BindingList(Of TipoEntidad)
    Implements ComponentModel.IComponent, ComponentModel.ISite

    Private ordenar As New OrdenarClass(Of TipoEntidad, CollectionClass(Of TipoEntidad))

#Region "Datos Componente"
    Public Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Implements System.ComponentModel.IComponent.Disposed
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private m_cursite As System.ComponentModel.ISite
    Private m_component As System.ComponentModel.IComponent
    Private m_container As System.ComponentModel.IContainer
    Private m_designmode As Boolean = False
    Private m_Name As String
    Private m_getservice As System.IServiceProvider

#Region "Property"

    Public Property Site() As System.ComponentModel.ISite Implements System.ComponentModel.IComponent.Site
        Get
            Return m_cursite
        End Get
        Set(ByVal value As System.ComponentModel.ISite)
            m_cursite = value
        End Set
    End Property

    Public ReadOnly Property Component() As System.ComponentModel.IComponent Implements System.ComponentModel.ISite.Component
        Get
            Return m_component
        End Get
    End Property

    Public ReadOnly Property Container() As System.ComponentModel.IContainer Implements System.ComponentModel.ISite.Container
        Get
            Return m_container
        End Get
    End Property

    Public ReadOnly Property DesignMode() As Boolean Implements System.ComponentModel.ISite.DesignMode
        Get
            Return m_designmode
        End Get
    End Property

    Public Property Name() As String Implements System.ComponentModel.ISite.Name
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = ""
        End Set
    End Property

#End Region

    Public Function GetService(ByVal serviceType As System.Type) As Object Implements System.IServiceProvider.GetService
        Return m_getservice.GetService(serviceType)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
            End If

            ' TODO: Liberar recursos no administrados compartidos
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
#End Region

#Region "Datos de Ordenacion"

    Protected Overrides Sub ApplySortCore(ByVal prop As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection)
        Direc = direction
        Propiedad = prop

        If Count > 0 Then
            ordenar.Ordenar(Me, 0, Me.Count - 1, prop.Name, Direc)
        End If

        EstaOrdenada = True

        Me.OnListChanged(New System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, prop))
    End Sub

    Protected Overrides Sub RemoveSortCore()

    End Sub

    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Dim Direc As System.ComponentModel.ListSortDirection ' = System.ComponentModel.ListSortDirection.Descending
    Protected Overrides ReadOnly Property SortDirectionCore() As System.ComponentModel.ListSortDirection
        Get
            Return Direc
        End Get
    End Property

    Dim Propiedad As System.ComponentModel.PropertyDescriptor
    Protected Overrides ReadOnly Property SortPropertyCore() As System.ComponentModel.PropertyDescriptor
        Get
            Return Propiedad
        End Get
    End Property

    Private EstaOrdenada As Boolean = False
    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
        Get
            Return EstaOrdenada
        End Get
    End Property

#End Region

End Class