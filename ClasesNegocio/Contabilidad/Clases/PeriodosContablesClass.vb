Imports IC = Integra.Clases
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CM = System.ComponentModel

Public Class PeriodosContablesClass
    Inherits ClassBase(Of EC.PeriodosContEntity)

#Region "Constructores"
    Sub New()
        Entity = New EC.PeriodosContEntity
    End Sub

    Sub New(ByVal Ejercicio As Integer)
        Entity = New EC.PeriodosContEntity(Ejercicio)
    End Sub

    Sub New(ByVal Entidad As EC.PeriodosContEntity)
        Entity = Entidad
    End Sub
#End Region

#Region "Propiedades"

    Public Property Ejercicio() As Integer
        Get
            Return Entity.Ejercicio
        End Get
        Set(ByVal value As Integer)
            Entity.Ejercicio = value
        End Set
    End Property

    Public Property PolizaCierre() As String
        Get
            Return Entity.PolizaCierre
        End Get
        Set(ByVal value As String)
            Entity.PolizaCierre = value
        End Set
    End Property

    Public Property PolizaTraspazo() As String
        Get
            Return Entity.PolizaTraspaso
        End Get
        Set(ByVal value As String)
            Entity.PolizaTraspaso = value
        End Set
    End Property

    Public Property FechaCierre() As DateTime
        Get
            Return Entity.FechaCierre
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaCierre = value
        End Set
    End Property

    Public Property Estatus() As Integra.Clases.EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As Integra.Clases.EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property
#End Region

    Public Function Obtener(ByVal Ejercicio As Integer) As Boolean
        Return Entity.FetchUsingPK(Ejercicio)
    End Function
    Public Overloads Function Borrar() As Boolean
        Try

            Entity.Save()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Overloads Function Guardar() As Boolean
        Try
            Dim Col As New CC.PeriodosContCollection

            If Col.GetDbCount(HC.PeriodosContFields.Ejercicio = Me.Ejercicio) > 0 Then
                MsgBox("El periodo contable que ingreso ya existe", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Entity.Save()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class

Public Class PeriodosContablesCollectionClass
    Inherits ColleccionBase(Of EC.PeriodosContEntity, CC.PeriodosContCollection, PeriodosContablesClass)

    Private col As New CC.PeriodosContCollection

    Sub New()
        MyBase.New()
    End Sub
    Sub New(ByVal coleccion As CC.PeriodosContCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.PeriodosContEntity In col
            Dim n As New PeriodosContablesClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.PeriodosContCollection
        Return col
    End Function
    Public Function ObtenerConEstatus(ByVal Estatus As EstatusEnum) As Integer
        Try
            Me.Clear()
            coleccion.GetMulti(HC.PeriodosContFields.Estatus = Estatus)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function


    
End Class