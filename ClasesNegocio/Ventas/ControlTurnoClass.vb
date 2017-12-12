Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Windows.Forms
Imports System

<System.ComponentModel.Bindable(True)> _
Public Class ControlTurnoClass
    Inherits ClassBase(Of EC.ControlTurnoEntity)
    Private _Sucursal As New SucursalClass
    Private modificado As Boolean = False

#Region "Constructores"
    Sub New()
        'Inicialización de todas las variables
        Entity.CodSucursal = 0
        Entity.CodCaja = 0
        Entity.CodUsuario = 0
        Entity.FechaInicio = DateTime.Now
    End Sub

    Sub New(ByVal Ent As Integralab.ORM.EntityClasses.ControlTurnoEntity)
        Me.Entity = Ent
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el identificador del control del turno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Id Control de Turnos")> _
    Public Property Id() As Integer
        Get
            Return Entity.Id
        End Get
        Set(ByVal value As Integer)
            Entity.Id = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el codigo de la sucursal
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Código Sucursal")> _
    Public Property CodSucursal() As Integer
        Get
            Return Entity.CodSucursal
        End Get
        Set(ByVal value As Integer)
            Entity.CodSucursal = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la sucursal a la que pertenece el control del turno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing OrElse _Sucursal.Codigo <> Me.CodSucursal Then
                _Sucursal = New SucursalClass(Entity.Sucursal)
            End If
            Return _Sucursal
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece el codigo del usuario o cajero
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Codigo usuario")> _
    Public Property CodUsuario() As Integer
        Get
            Return Entity.CodUsuario
        End Get
        Set(ByVal value As Integer)
            Entity.CodUsuario = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha y hora en que se inicia el control del turno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fecha Inicio")> _
    Public Property FechaInicio() As DateTime
        Get
            Return Entity.FechaInicio
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaInicio = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha y hora en que termina el control del turno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fecha Fin")> _
    Public Property FechaFin() As Nullable(Of DateTime)
        Get
            Return Entity.FechaFin
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            Entity.FechaFin = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha y hora en que termina el control del turno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fondo Inicial")> _
    Public Property FondoInicial() As Decimal
        Get
            Return Entity.FondoInicial
        End Get
        Set(ByVal value As Decimal)
            Entity.FondoInicial = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean
        Try
            'Entity.Estatus = EstatusEnum.INACTIVO
            Return Entity.Delete()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return False
    End Function

    'Public Function Guardar(Optional ByVal ApplicationName As String = "") As Boolean
    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.ControlTurnoCollection

            If Entity.IsNew Then
                If Entity.FechaFin.HasValue Then
                    MsgBox("No se puede tener fecha de fin al abrir un control de turno.", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                If col.GetDbCount(HC.ControlTurnoFields.CodUsuario = Entity.CodUsuario And HC.ControlTurnoFields.FechaFin >= Entity.FechaInicio) > 0 Then
                    MsgBox("La fecha de inicio se traslapa con otro control de turno.", MsgBoxStyle.Exclamation, "Lapso de tiempo traslapado")
                    Return False
                End If
            Else
                If Entity.FechaFin.HasValue Then
                    If Entity.FechaFin <= Entity.FechaInicio Then
                        MsgBox("La fecha de fin no puede ser menor que la de inicio.", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                Else
                    MsgBox("La fecha de fin no puede tener valor nulo.", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
            Return Entity.Save()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal EntidadL As EC.ControlTurnoEntity)
        Me.Entity = EntidadL
    End Sub

    Public Function ObtenerEntidad() As EC.ControlTurnoEntity
        Return Me.Entity
    End Function

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    'Public Overrides Function ToString() As String
    '    Return Me.Descripcion
    'End Function

    'Public Function AgregarAlmacen(ByVal Almacen As AlmacenClass) As Boolean
    '    'Dim AlmSuc As New IntegraLab.ORM.EntityClasses.AlmacenSucursalEntity
    '    'AlmSuc.AlmacenId = Almacen.ObtenerEntidad
    '    'AlmSuc.SucursalId = sucursal
    '    'If sucursal.AlmacenSucursal.SaveMulti() > 0 Then Return True
    '    'Return False
    'End Function

    'Public Function QuitarAlmacen(ByVal Almacen As AlmacenClass) As Boolean
    '    'Dim tmp As IntegraLab.ORM.EntityClasses.AlmacenSucursalEntity
    '    'For Each AlmSuc As Integralab.ORM.EntityClasses.AlmacenSucursalEntity In sucursal.AlmacenSucursal
    '    '    If AlmSuc.Almacen.AlmacenId = Almacen.ObtenerEntidad.AlmacenId Then
    '    '        tmp = AlmSuc
    '    '        Exit For
    '    '    End If
    '    'Next
    '    'If Not IsNothing(tmp) Then
    '    '    tmp.Delete()
    '    '    Return True
    '    'End If
    '    'Return False
    'End Function

    'Public Function AgregarUsuario(ByVal Usuario As UsuarioClass) As Boolean
    '    'Dim UsuSuc As New Integralab.ORM.EntityClasses.UsuarioEntity
    '    'UsuSuc.Usrndx = Usuario.Obtener
    '    'UsuSuc.Usrndx = sucursal
    '    'If sucursal.UsuariosSucursal.SaveMulti() > 0 Then Return True
    '    'Return False
    'End Function

    'Public Function QuitarUsuario(ByVal Usuario As UsuarioClass) As Boolean
    '    'Dim tmp As IntegraLab.ORM.EntityClasses.UsuarioSucursalEntity
    '    'For Each UsuSuc As IntegraLab.ORM.EntityClasses.UsuarioSucursalEntity In sucursal.UsuariosSucursal
    '    '    If UsuSuc.UsuarioId = Usuario.Codigo Then
    '    '        tmp = UsuSuc
    '    '        Exit For
    '    '    End If
    '    'Next
    '    'If Not IsNothing(tmp) Then
    '    '    tmp.Delete()
    '    '    Return True
    '    'End If
    '    'Return False
    'End Function
#End Region

End Class


Public Class ControlTurnoCollectionClass
    Inherits ColleccionBase(Of EC.ControlTurnoEntity, CC.ControlTurnoCollection, ControlTurnoClass)

#Region "Miembros"
#End Region

#Region "Constructores"
#End Region

#Region "Propiedades"
#End Region

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As ControlTurnoClass)
        MyBase.Add(item)
    End Sub

    Public Overloads Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal filtro As OC.PredicateExpression) As Integer
        Try
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Sub QuitarControlTurno(ByVal Id As Long)
        For i As Integer = 0 To Me.Count - 1
            If Trim(Me(i).Id) = Id Then
                Me.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Public Sub AgregarControlTurno(ByVal ControlTurno As ControlTurnoClass)
        Me.Add(ControlTurno)
    End Sub
#End Region

#Region "Eventos"

#End Region
End Class