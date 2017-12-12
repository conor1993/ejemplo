Imports System.Windows.Forms
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CatIntroductoresClass
    Implements IEntidad


    Dim Introductor As EC.CatIntroductoresEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

#Region "Propiedades"
    ReadOnly Property IdIntroductor() As Integer
        Get
            Return Introductor.IdIntroductor
        End Get
    End Property
    Property Nombre() As String
        Get
            Return Introductor.Nombre
        End Get
        Set(ByVal value As String)
            Introductor.Nombre = value
        End Set
    End Property
    Property ApellidoPaterno() As String
        Get
            Return Introductor.ApellidoPaterno
        End Get
        Set(ByVal value As String)
            Introductor.ApellidoPaterno = value
        End Set
    End Property
    Property ApellidoMaterno() As String
        Get
            Return Introductor.ApellidoMaterno
        End Get
        Set(ByVal value As String)
            Introductor.ApellidoMaterno = value
        End Set
    End Property
    Property RFC() As String
        Get
            Return Introductor.Rfc
        End Get
        Set(ByVal value As String)
            Introductor.Rfc = value
        End Set
    End Property
    Property FechaUltimaIntGanado() As Date
        Get
            Return Introductor.FechaUltimaIntGanado
        End Get
        Set(ByVal value As Date)
            Introductor.FechaUltimaIntGanado = value
        End Set
    End Property
    Property CantCabUltimaIntGanado() As Integer
        Get
            Return Introductor.CantCabUltimaIntGanado
        End Get
        Set(ByVal value As Integer)
            Introductor.CantCabUltimaIntGanado = value
        End Set
    End Property
    Property Estatus() As EstatusDatos
        Get
            Return Introductor.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            Introductor.Estatus = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Introductor.Estatus = EstatusDatos.CANCELADO
            Return Introductor.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function
    Public Function Guardar() As Boolean
        Try
            Dim IG As New CC.CatIntroductoresCollection
            If Introductor.IsNew Then
                If IG.GetDbCount(HC.CatIntroductoresFields.Nombre = Nombre And HC.CatIntroductoresFields.ApellidoPaterno = ApellidoPaterno And HC.CatIntroductoresFields.ApellidoMaterno = ApellidoMaterno) > 0 Then
                    MessageBox.Show("Nombre de Introductor de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                If IG.GetDbCount(Not HC.CatIntroductoresFields.IdIntroductor = IdIntroductor And HC.CatIntroductoresFields.Nombre = Nombre And HC.CatIntroductoresFields.ApellidoPaterno = ApellidoPaterno And HC.CatIntroductoresFields.ApellidoMaterno = ApellidoMaterno) > 0 Then
                    MessageBox.Show("Nombre de Introductor de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
            Return Introductor.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function
    Public Function Guardar1() As Boolean

    End Function
    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            Return Introductor.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function ObtenerEntidad() As EC.CatIntroductoresEntity
        Return Introductor
    End Function

#End Region

#Region "Constructores"
    Sub New()
        Introductor = New EC.CatIntroductoresEntity
    End Sub
    Sub New(ByVal Entidad As EC.CatIntroductoresEntity)
        Introductor = Entidad
    End Sub
    Sub New(ByVal Codigo As Long)
        Introductor = New EC.CatIntroductoresEntity
    End Sub

#End Region

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus1() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class CatIntroductoresCollectionClass
    Inherits CollectionClass(Of CatIntroductoresClass)

    Private WithEvents Coleccion As New CC.CatIntroductoresCollection

    Public Function Obtener() As Integer
        Try
            Coleccion.GetMulti(Nothing, 0, Nothing)
            Rellenar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try

    End Function

#Region "Código de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.CatIntroductoresEntity In Coleccion
            Add(New CatIntroductoresClass(ente))
        Next
    End Sub

    Public Sub RellenarMe(ByVal Collection As CC.CatIntroductoresCollection)
        Coleccion = Collection
        Rellenar()
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each entc As CatIntroductoresClass In Me
            Coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.CatIntroductoresCollection
        RellenarColeccion()
        Return Coleccion
    End Function
#End Region
End Class