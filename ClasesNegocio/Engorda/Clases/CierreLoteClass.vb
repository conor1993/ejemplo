Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CierreLoteClass
    Inherits EC.CierreLoteEntity

#Region "Miembros"

#End Region

#Region "Constructores"
    Sub New(ByVal IdCierreLote As Integer)
        Me.FetchUsingPK(IdCierreLote)
    End Sub

    Sub New(ByVal Entidad As EC.CierreLoteEntity)
        If Not Me.FetchUsingPK(Entidad.IdCierreLote) AndAlso Not Me.IsDirty Then
            Me.IdLote = Entidad.IdLote
            Me.DiasCabezas = Entidad.DiasCabezas
            Me.FecCierre = Entidad.FecCierre
            Me.Estatus = Entidad.Estatus
            Me.Cki = Entidad.Cki
            Me.Gdp = Entidad.Gdp
            Me.Eca = Entidad.Eca
        End If
    End Sub

    Sub New(ByVal IdLote As Integer, ByVal DiasCabezas As Integer, ByVal FecCierre As Date, ByVal Estatus As Boolean, ByVal Cki As Decimal, ByVal Gdp As Decimal, ByVal Eca As Decimal)
        Me.IdLote = IdLote
        Me.DiasCabezas = DiasCabezas
        Me.FecCierre = FecCierre
        Me.Estatus = Estatus
        Me.Cki = Cki
        Me.Gdp = Gdp
        Me.Eca = Eca
    End Sub
#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Public Sub Guardar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Save()
    End Sub
#End Region

End Class

Public Class CierreLoteCollectionClass
    Inherits ColleccionBase(Of CierreLoteClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal Entidad As CierreLoteClass)
        Me.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.CierreLoteEntity)
        Me.Add(New CierreLoteClass(Entidad))
    End Sub
#End Region
End Class

