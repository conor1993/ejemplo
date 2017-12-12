Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class FoliosClass
#Region "Miembros"
    Dim Folio As EC.MgcnfFoliadoresEntity
#End Region

#Region "Constructores"
    Sub New()
        Folio = New EC.MgcnfFoliadoresEntity
        Clasificador = -1
    End Sub
#End Region

#Region "Propiedades"
    Property Codigo() As CodigodeFolios
        Get
            Return Folio.Codigo
        End Get
        Set(ByVal value As CodigodeFolios)
            Folio.Codigo = value
        End Set
    End Property

    Property Año() As String
        Get
            Return Folio.Año
        End Get
        Set(ByVal value As String)
            Folio.Año = value
        End Set
    End Property

    Property Mes() As String
        Get
            Return Folio.Mes
        End Get
        Set(ByVal value As String)
            Folio.Mes = value
        End Set
    End Property

    Public Property Clasificador() As Integer
        Get
            Return Folio.IdAlmacen
        End Get
        Set(ByVal value As Integer)
            Folio.IdAlmacen = value
        End Set
    End Property

    Property Consecutivo() As Integer
        Get
            Return Folio.Consecutivo
        End Get
        Set(ByVal value As Integer)
            Folio.Consecutivo = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Dim col As New CC.MgcnfFoliadoresCollection
            Dim sort As New OC.SortExpression

            trans.Add(col)

            sort.Add(New OC.SortClause(HC.MgcnfFoliadoresFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
            sort.Add(New OC.SortClause(HC.MgcnfFoliadoresFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

            col.GetMulti(HC.MgcnfFoliadoresFields.Codigo = Codigo And _
                            HC.MgcnfFoliadoresFields.Año = Año And _
                            HC.MgcnfFoliadoresFields.Mes = Mes, 1, Nothing)

            If col.Count = 0 Then
                trans.Add(Folio)

                Folio.Consecutivo = 1

                Return Folio.Save()
            Else
                Folio = col(0)

                Folio.Consecutivo += 1

                trans.Add(Folio)

                Return Folio.Save()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class