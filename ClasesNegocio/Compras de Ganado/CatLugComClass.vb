Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class CatLugComClass
    Inherits ClassBase(Of EC.CatLugComEntity)

#Region "Constructores"

    Sub New()
        Entity = New EC.CatLugComEntity
    End Sub

    Sub New(ByVal Entidad As EC.CatLugComEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As String)
        Entity = New EC.CatLugComEntity
    End Sub
#End Region

#Region "Propiedades"

    Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property
    Property IdPoblacion() As Integer
        Get
            Return Entity.IdPoblacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoblacion = value
        End Set
    End Property
    'codigo idpoblacion descripcion domicilio horasviaje estatus

    Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Property Domicilio() As String
        Get
            Return Entity.Domicilio
        End Get
        Set(ByVal value As String)
            Entity.Domicilio = value
        End Set
    End Property

    Property HorasViaje() As Date
        Get
            Return Entity.HorasViaje
        End Get
        Set(ByVal value As Date)
            Entity.HorasViaje = value
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
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Dim Coleccion As New CC.CatLugComCollection
                If Entity.IsNew Then
                    Return Entity.Save
                Else
                    Return Entity.Save
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

End Class

Public Class CatLugComCollectionClass
    Inherits ColleccionBase(Of EC.CatLugComEntity, CC.CatLugComCollection, CatLugComClass)

End Class