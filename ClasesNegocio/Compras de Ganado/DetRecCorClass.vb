Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class DetRecCorClass
    Inherits ClassBase(Of EC.DetRecCorEntity)

#Region "Constructores"

    Sub New()
        Entity = New EC.DetRecCorEntity
    End Sub

    Sub New(ByVal Entidad As EC.DetRecCorEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String)
        Entity = New EC.DetRecCorEntity
    End Sub
#End Region

#Region "Popiedades"
    Property Folio() As String
        Get
            Return Entity.FolMov
        End Get
        Set(ByVal value As String)
            Entity.FolMov = value
        End Set
    End Property
    Property Fecha() As Date
        Get
            Return Entity.FecMov
        End Get
        Set(ByVal value As Date)
            Entity.FecMov = value
        End Set
    End Property
    Property CveCorral() As Integer
        Get
            Return Entity.CveCorRec
        End Get
        Set(ByVal value As Integer)
            Entity.CveCorRec = value
        End Set
    End Property
    Property CveCorralDestino() As Integer
        Get
            Return Entity.CveCorDes
        End Get
        Set(ByVal value As Integer)
            Entity.CveCorDes = value
        End Set
    End Property
    Property CveLoteDestino() As Integer
        Get
            Return Entity.CveLoteDes
        End Get
        Set(ByVal value As Integer)
            Entity.CveLoteDes = value
        End Set
    End Property
    Property TipoGanado() As String
        Get
            Return Entity.CveGanado
        End Get
        Set(ByVal value As String)
            Entity.CveGanado = value
        End Set
    End Property
    Property Cabezas() As Integer
        Get
            Return Entity.Cabezas
        End Get
        Set(ByVal value As Integer)
            Entity.Cabezas = value
        End Set
    End Property
    Property Kilos() As Decimal
        Get
            Return Entity.Kilos
        End Get
        Set(ByVal value As Decimal)
            Entity.Kilos = value
        End Set
    End Property
    Property CostoPorKilo() As Decimal
        Get
            Return Entity.CostoxKilo
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoxKilo = value
        End Set
    End Property
    Property AreteSINIIGA() As String
        Get
            Return Entity.Aresiniiga
        End Get
        Set(ByVal value As String)
            Entity.Aresiniiga = value
        End Set
    End Property
    Property AreteTransporte() As String
        Get
            Return Entity.Aretransporte
        End Get
        Set(ByVal value As String)
            Entity.Aretransporte = value
        End Set
    End Property
    Property AretePropio() As String
        Get
            Return Entity.Arepropio
        End Get
        Set(ByVal value As String)
            Entity.Arepropio = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal Folio As String, ByVal TipoGanado As String) As Boolean
        Try
            Return Entity.FetchUsingPK(Folio, TipoGanado)
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
                Dim Coleccion As New CC.DetRecCorCollection
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
Public Class DetRecCorCollectionClass
    Inherits ColleccionBase(Of EC.DetRecCorEntity, CC.DetRecCorCollection, DetRecCorClass)

    Public Overloads Function Obtener() As Integer
        Try
            'If Not Estatus = EstatusChar.TODOS Then
            '    coleccion.GetMulti(HC.NotCreCteFields.StaNota = Estatus)
            'Else
            coleccion.GetMulti(Nothing)
            'End If
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Folio As String, ByVal TipoGanado As String) As Integer
        Try
            If Not Folio = "" Then
                coleccion.GetMulti(HC.DetRecCorFields.FolMov)
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