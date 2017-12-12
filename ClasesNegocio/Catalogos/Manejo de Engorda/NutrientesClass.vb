Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class NutrienteClass
    Inherits ClassBase(Of EC.CatNutrientesEntity)

#Region "Contructores"
    Sub New()

    End Sub

    Sub New(ByVal IdNutriente As Integer)
        Entity = New EC.CatNutrientesEntity(IdNutriente)
    End Sub

    Sub New(ByVal Entidad As EC.CatNutrientesEntity)
        Entity = Entidad
    End Sub
#End Region

#Region "Propiedades"
    ReadOnly Property IdNutriente() As Integer
        Get
            Return Entity.CveNutriente
        End Get
    End Property

    Property Descripcion() As String
        Get
            Return Entity.NomNutriente
        End Get
        Set(ByVal value As String)
            Entity.NomNutriente = value
        End Set
    End Property

    Property IdUnidad() As Integer
        Get
            Return Entity.Unidad
        End Get
        Set(ByVal value As Integer)
            Entity.Unidad = value
        End Set
    End Property

    Property Estatus() As EstatusEnum
        Get
            Return IIf(Entity.Estatus = "1", EstatusEnum.ACTIVO, EstatusEnum.INACTIVO)
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = IIf(value = EstatusEnum.ACTIVO, "1", "0")
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Dim Nuevo As Boolean = False

        If Not Trans Is Nothing Then
            Trans.Add(Entity)
        Else
            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Nutrientes")
            Trans.Add(Entity)
            Nuevo = True
        End If

        Try
            If Not Entity.Save() Then
                Throw New Exception("Error al intentar guardar el nutriente, Intente de nuevo")
            End If

            If Nuevo Then
                Trans.Commit()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Estatus = EstatusEnum.INACTIVO
            Entity.Save()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Shared Function CargarNutriente(ByVal IdNutriente As Integer) As NutrienteClass
        Return New NutrienteClass(IdNutriente)
    End Function
#End Region
End Class
