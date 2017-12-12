Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TVC = IntegraLab.ORM.TypedViewClasses

'' Relacionado a la tabla FacturaFolios
Public Class FacturaFoliosClass
    Inherits ClassBase(Of EC.FacturaFoliosEntity)

#Region "Constructores"
    Sub New()
        Entity = New EC.FacturaFoliosEntity
        Entity.FolioInicial = 0
        Entity.NumFolios = 0
        Entity.Consecutivo = 0
        Entity.StaLetraSerie = ""
        Entity.NoAprobacion = 0
        Entity.AnoAprobacion = 0
    End Sub

    Sub New(ByVal Entidad As EC.FacturaFoliosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdFacturaFolios As Integer)
        Entity = New EC.FacturaFoliosEntity(IdFacturaFolios)
    End Sub
#End Region

#Region "Propiedades"

    <System.ComponentModel.DisplayName("Código")> _
    <System.ComponentModel.DataObjectField(True)> _
    Property IdFacturaFolios() As Integer
        Get
            Return Entity.IdFacturaFolios
        End Get
        Set(ByVal value As Integer)
            Entity.IdFacturaFolios = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Folio Inicial")> _
    <System.ComponentModel.DataObjectField(True)> _
    Property FolioInicial() As Long
        Get
            Return Entity.FolioInicial
        End Get
        Set(ByVal value As Long)
            Entity.FolioInicial = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Número de folios")> _
    <System.ComponentModel.DataObjectField(True)> _
    Property NumFolios() As Long
        Get
            Return Entity.NumFolios
        End Get
        Set(ByVal value As Long)
            Entity.NumFolios = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Consecutivo")> _
    <System.ComponentModel.DataObjectField(True)> _
    Property Consecutivo() As Long
        Get
            Return Entity.Consecutivo
        End Get
        Set(ByVal value As Long)
            Entity.Consecutivo = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Serie")> _
    <System.ComponentModel.DataObjectField(True)> _
    Property StaLetraSerie() As String
        Get
            Return Entity.StaLetraSerie
        End Get
        Set(ByVal value As String)
            Entity.StaLetraSerie = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Número de aprobación")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property NoAprobacion() As Integer
        Get
            Return Entity.NoAprobacion
        End Get
        Set(ByVal value As Integer)
            Entity.NoAprobacion = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Año de aprobación")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property AnoAprobacion() As Integer
        Get
            Return Entity.AnoAprobacion
        End Get
        Set(ByVal value As Integer)
            Entity.AnoAprobacion = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal IdFacturaFolios As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(IdFacturaFolios)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Shadows Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            Me.Consecutivo = FolioInicial
            Me.StaLetraSerie = Me.StaLetraSerie.ToUpper
            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function GenerarFolio(ByRef Trans As HC.Transaction) As String
        Dim Consecutivo As Long = Me.Consecutivo

        Trans.Add(Me.Entidad)
        Me.Consecutivo += 1
        'If Guardar(Trans) Then

        'End If

        Me.Entidad.Save()
        'Trans.Commit()

        'Return IIf(Me.Entidad.StaLetraSerie.Trim = "", "", Me.Entidad.StaLetraSerie.Trim & "-") & Consecutivo
        Return Consecutivo
    End Function

    Public Function MostrarFolio() As String
        Dim Consecutivo As Long = Me.Consecutivo
        Me.Consecutivo += 1
        Return IIf(Me.Entidad.StaLetraSerie.Trim = "", "", Me.Entidad.StaLetraSerie.Trim & "-") & Consecutivo
    End Function

#End Region

End Class

Public Class FacturaFoliosCollectionClass
    Inherits ColleccionBase(Of EC.FacturaFoliosEntity, CC.FacturaFoliosCollection, FacturaFoliosClass)

End Class
