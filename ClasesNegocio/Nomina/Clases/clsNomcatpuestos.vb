Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses


Public Class NomcatpuestosClass
    Inherits ClassBase(Of EC.NomCatPuestosEntity)

#Region "Propiedades"
    Public ReadOnly Property IdPuesto() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return Entidad.Descripcion
        End Get

        Set(ByVal value As String)
            Entidad.Descripcion = value
        End Set
    End Property

    Public Property SueldoDiario() As Decimal
        Get
            Return Entidad.SueldoDiario
        End Get

        Set(ByVal value As Decimal)
            Entidad.SueldoDiario = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entidad.Estatus
        End Get

        Set(ByVal value As EstatusEnum)
            Entidad.Estatus = value
        End Set
    End Property

    Public Property IdUsuarioAlta() As Int32
        Get
            Return Entidad.IdUsuarioAlta
        End Get

        Set(ByVal value As Int32)
            Entidad.IdUsuarioAlta = value
        End Set
    End Property


    Public Property FechaAlta() As DateTime
        Get
            Return Entidad.FechaAlta
        End Get

        Set(ByVal value As DateTime)
            Entidad.FechaAlta = value
        End Set
    End Property


    Public Property IdUsuarioCancela() As Int32
        Get
            Return Entidad.IdUsuarioCancela
        End Get

        Set(ByVal value As Int32)
            Entidad.IdUsuarioCancela = value
        End Set
    End Property


    Public Property FechaCancelacion() As DateTime
        Get
            Return Entidad.FechaCancelacion
        End Get

        Set(ByVal value As DateTime)
            Entidad.FechaCancelacion = value
        End Set
    End Property

#End Region

#Region "Costructores"
    Sub New()
        Entity = New EC.NomCatPuestosEntity
    End Sub
    Sub New(ByVal Entidad As EC.NomCatPuestosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal codigo As Integer)
        Entity = New EC.NomCatPuestosEntity(codigo)
    End Sub

    Sub New(ByVal IdPlaza As Integer, ByVal Codigo As Integer)
        Entity = New EC.NomCatPuestosEntity(Codigo)
    End Sub


#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal IdPlaza As Integer, ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As HC.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Return Entity.Save
            Else
                Dim Col As New CC.NomCatPuestosCollection
                If Col.GetDbCount(Not HC.NomCatPuestosFields.Codigo = Me.IdPuesto And HC.NomCatPuestosFields.Descripcion = Me.Descripcion) > 0 Then
                    MsgBox("Ya existe otro puesto con la misma Descripción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region

End Class
Public Class PuestosCollectionClass
    Inherits ColleccionBase(Of EC.NomCatPuestosEntity, CC.NomCatPuestosCollection, NomcatpuestosClass)

    Public Overloads Function Obtener(Optional ByVal Descripcion As String = "", Optional ByVal fcCondicion As CondicionEstatusDepartamento = CondicionEstatusDepartamento.TODOS) As Integer
        Try
            Me.Clear()
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Not fcCondicion = CondicionEstatusDepartamento.TODOS Then
                Filtro.Add(HC.NomCatPuestosFields.Estatus = fcCondicion)
                'coleccion.GetMulti(HC.NomCatPuestosFields.Estatus = fcCondicion)
            End If

            If Not Descripcion = "" Then
                Filtro.Add(HC.NomCatPuestosFields.Descripcion Mod String.Format("%{0}%", Descripcion))
                'coleccion.GetMulti(HC.NomCatPuestosFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            End If

            coleccion.GetMulti(filtro)

            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class