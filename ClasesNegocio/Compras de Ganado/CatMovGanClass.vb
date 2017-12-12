Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TVC = IntegraLab.ORM.TypedViewClasses

Public Class CabMovGanClass
    Inherits ClassBase(Of EC.CabMovGanEntity)

#Region "Constructores"

    Sub New()
        Entity = New EC.CabMovGanEntity
    End Sub

    Sub New(ByVal Entidad As EC.CabMovGanEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String)
        Entity = New EC.CabMovGanEntity
    End Sub
#End Region

#Region "Propiedades"

    Property Folio() As String
        Get
            Return Entity.FolMovGan
        End Get
        Set(ByVal value As String)
            Entity.FolMovGan = value
        End Set
    End Property
    Property FecMovGan() As Date
        Get
            Return Entity.FecMovGan
        End Get
        Set(ByVal value As Date)
            Entity.FecMovGan = value
        End Set
    End Property
    Property CveMovGan() As String
        Get
            Return Entity.CveMovGan
        End Get
        Set(ByVal value As String)
            Entity.CveMovGan = value
        End Set
    End Property
    Property CveGanadera() As Byte
        Get
            Return Entity.CveGanadera
        End Get
        Set(ByVal value As Byte)
            Entity.CveGanadera = value
        End Set
    End Property
    Property FecConta() As Date
        Get
            Return Entity.FecConta
        End Get
        Set(ByVal value As Date)
            Entity.FecConta = value
        End Set
    End Property

    Property FolPoliza() As String
        Get
            Return Entity.FolPoliza
        End Get
        Set(ByVal value As String)
            Entity.FolPoliza = value
        End Set
    End Property

    Property StaMov() As String
        Get
            Return Entity.StaMov
        End Get
        Set(ByVal value As String)
            Entity.StaMov = value
        End Set
    End Property
    Property CostoTotal() As Decimal
        Get
            Return Entity.CostoTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoTotal = value
        End Set
    End Property

    Property FolReferencia() As String
        Get
            Return Entity.FolRefere
        End Get
        Set(ByVal value As String)
            Entity.FolRefere = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Entity.FetchUsingPK(Folio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            'If Not Trans Is Nothing Then
            '    Trans.Add(Entity)
            'End If
            If Entity.IsNew Then
                Dim Coleccion As New CC.CabMovGanCollection
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

Public Class CabMovGanCollectionClass
    Inherits ColleccionBase(Of EC.CabMovGanEntity, CC.CabMovGanCollection, CabMovGanClass)

    Public Overloads Function Obtener() As Integer
        Try
            'If Not Estatus = EstatusChar.TODOS Then
            '    coleccion.GetMulti(HC.CabMovGanFields.StaMov = Estatus)
            'Else
            '    coleccion.GetMulti(Nothing)
            'End If
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Folio As String) As Integer
        Try
            If Not Folio = "" Then
                coleccion.GetMulti(HC.CabMovGanFields.FolMovGan)
            Else
                coleccion.GetMulti(Nothing)
            End If
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function


End Class
