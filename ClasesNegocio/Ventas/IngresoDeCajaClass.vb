Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Windows.Forms
Imports System

<System.ComponentModel.Bindable(True)> _
Public Class IngresoDeCajaClass
    Inherits ClassBase(Of EC.IngresoCajaEntity)
    Private _ControlTurno As New ControlTurnoClass
    Private modificado As Boolean = False

#Region "Constructores"
    Sub New()
        'Inicialización de todas las variables
        Entity.CodControlTurno = 0
        Entity.CodCaja = 0
        Entity.CodUsuario = 0
        Entity.FechaHora = DateTime.Now
    End Sub

    Sub New(ByVal Ent As Integralab.ORM.EntityClasses.IngresoCajaEntity)
        Me.Entity = Ent
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el codigo del retiro de caja
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Código ingreso")> _
    Public Property Id() As Integer
        Get
            Return Entity.Id
        End Get
        Set(ByVal value As Integer)
            Entity.Id = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el identificador del control del turno
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Id Control de Turnos")> _
    Public Property CodControlTurno() As Integer
        Get
            Return Entity.CodControlTurno
        End Get
        Set(ByVal value As Integer)
            Entity.CodControlTurno = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene el evento del turno al que pertenece el retiro
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ControlTurno() As ControlTurnoClass
        Get
            If _ControlTurno Is Nothing OrElse _ControlTurno.Id <> Entity.CodControlTurno Then
                _ControlTurno = New ControlTurnoClass(Entity.ControlTurno)
            End If
            Return _ControlTurno
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
    ''' Obtiene o establece importe del retiro
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Importe")> _
    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("IdConcepto")> _
    Public Property IdConcepto() As Integer
        Get
            Return Entity.IdConcepto
        End Get
        Set(ByVal value As Integer)
            Entity.IdConcepto = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha y hora en que se realiza el retiro
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fecha y hora")> _
    Public Property FechaHora() As DateTime
        Get
            Return Entity.FechaHora
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaHora = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean
        Try
            Entity.Estatus = EstatusEnum.INACTIVO
            Return Entity.Delete()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return False
    End Function

    Public Function Guardar(Optional ByVal ApplicationName As String = "") As Boolean
        Try
            Dim col As New CC.RetiroCajaCollection

            If Entity.IsNew Then
                If System.Convert.IsDBNull(Entity.FechaHora) Then
                    MsgBox("No se puede tener fecha de fin al abrir un control de turno.", MsgBoxStyle.Exclamation, "")
                    Return False
                End If
            Else
                If col.GetDbCount(HC.RetiroCajaFields.FechaHora <= Entity.FechaHora) > 0 Then
                    MsgBox("La fecha de inicio se traslapa con otro control de turno.", MsgBoxStyle.Exclamation, "Lapso de tiempo traslapado")
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

    Public Sub LeerEntidad(ByVal EntidadL As EC.IngresoCajaEntity)
        Me.Entity = EntidadL
    End Sub

    Public Function ObtenerEntidad() As EC.IngresoCajaEntity
        Return Me.Entity
    End Function
#End Region

#Region "Eventos"
    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
#End Region

End Class


Public Class IngresoCajaCollectionClass
    Inherits ColleccionBase(Of EC.IngresoCajaEntity, CC.IngresoCajaCollection, IngresoDeCajaClass)

#Region "Miembros"
#End Region

#Region "Constructores"
#End Region

#Region "Propiedades"
#End Region

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As IngresoDeCajaClass)
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

    Public Sub AgregarControlTurno(ByVal ControlTurno As IngresoDeCajaClass)
        Me.Add(ControlTurno)
    End Sub
#End Region

#Region "Eventos"

#End Region

End Class