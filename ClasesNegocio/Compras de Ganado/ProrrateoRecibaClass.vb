Imports ORM = Integralab.ORM
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProrrateoRecibaClass
    Inherits EC.ProrraRecEntity

#Region "Miembros"

#End Region

#Region "Constructores"

    Sub New(ByVal Entidad As EC.ProrraRecEntity)
        If Not Entidad.IsNew Then
            Me.FetchUsingPK(Entidad.IdProrraRec)
        Else
            Me.Fecha = Entidad.Fecha
            Me.Kilos = Entidad.Kilos
            Me.IdLote = Entidad.IdLote
            Me.IdCorralReciba = Entidad.IdCorralReciba
            Me.CostoxKilo = Entidad.CostoxKilo
            Me.Importe = Entidad.Importe
        End If
    End Sub

    Sub New(ByVal IdSalidaGanadoCab As Integer, ByVal Fecha As Date, ByVal Kilos As Decimal, ByVal IdLote As Integer, ByVal IdCorralReciba As String, ByVal CostoxKilo As Decimal, ByVal Importe As Decimal)
        Me.IdSalidaGanadoCab = IdSalidaGanadoCab
        Me.Fecha = Fecha
        Me.Kilos = Kilos
        Me.IdLote = IdLote
        Me.IdCorralReciba = IdCorralReciba
        Me.CostoxKilo = CostoxKilo
        Me.Importe = Importe
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property Folio() As String
        Get
            Return "G" & Me.IdProrraRec.ToString.PadLeft(10, "0")
        End Get
    End Property

#End Region

#Region "Metodos"
    Public Sub Guardar(ByVal Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Save()
    End Sub
#End Region

End Class

Public Class ProrrateoRecibaCollectionClass
    Inherits ColleccionBase(Of ProrrateoRecibaClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal Entidad As ProrrateoRecibaClass)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.ProrraRecEntity)
        Me.Add(New ProrrateoRecibaClass(Entidad))
    End Sub
#End Region
End Class
