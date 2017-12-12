Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class IngredienteCollection
    Inherits ColleccionBase(Of EC.DetPrepFormEntity, CC.DetPrepFormCollection, Ingrediente)

#Region "Constructor"
    Sub New()
    End Sub

    Sub New(ByVal ingredientes As CC.DetPrepFormCollection)
        coleccion = ingredientes
        Rellenar()
    End Sub
#End Region

#Region "Metodos"
    Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
        For Each ingrediente As Ingrediente In Me
            ingrediente.Guardar(trans)
        Next

        Return True
    End Function
#End Region
End Class