Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CabRecCorClass
    Inherits ClassBase(Of EC.CabRecCorEntity)

#Region "Constructores"

    Sub New()
        Entity = New EC.CabRecCorEntity
    End Sub

    Sub New(ByVal Entidad As EC.CabRecCorEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String)
        Entity = New EC.CabRecCorEntity
    End Sub
#End Region

#Region "Propiedades"
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
    Property ImporteAlimentosRec() As Decimal
        Get
            Return Entity.ImpteAlimRec
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteAlimRec = value
        End Set
    End Property
    Property CostoEntRec() As Decimal
        Get
            Return Entity.CostoEntRec
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoEntRec = value
        End Set
    End Property
    Property ImporteMedicinaRec() As Decimal
        Get
            Return Entity.ImpteMedRec
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteMedRec = value
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
    Property CostoPorMovimiento() As Decimal
        Get
            Return Entity.CostoMovto
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoMovto = value
        End Set
    End Property
    Property FechaContable() As String
        Get
            Return Entity.FecConta
        End Get
        Set(ByVal value As String)
            Entity.FecConta = value
        End Set
    End Property
    Property Poliza() As String
        Get
            Return Entity.FolPoliza
        End Get
        Set(ByVal value As String)
            Entity.FolPoliza = value
        End Set
    End Property
    Property Estatus() As String
        Get
            Return Entity.StaMov
        End Get
        Set(ByVal value As String)
            Entity.StaMov = value
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
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Dim Coleccion As New CC.CabRecCorCollection
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

Public Class CabRecCorCollectionClass
    Inherits ColleccionBase(Of EC.CabRecCorEntity, CC.CabRecCorCollection, CabRecCorClass)

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

    Public Overloads Function Obtener(ByVal Folio As Integer) As Integer
        Try
            If Not Folio = "" Then
                coleccion.GetMulti(HC.CabRecCorFields.FolMov)
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