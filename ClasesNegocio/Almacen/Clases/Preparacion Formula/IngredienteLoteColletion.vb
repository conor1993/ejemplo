Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class IngredienteLoteColletion
    Inherits ColleccionBase(Of EC.DetPrepFormLoteEntity, CC.DetPrepFormLoteCollection, IngredienteLote)

#Region "Constructores"
    Sub New()
    End Sub

    Sub New(ByVal ingredienteLotes As CC.DetPrepFormLoteCollection)
        coleccion = ingredienteLotes
        Rellenar()
    End Sub
#End Region

#Region "Metodos"
    Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
        For Each loteIngrediente As IngredienteLote In Me
            loteIngrediente.Guardar(trans)
        Next

        Return True
    End Function
#End Region
End Class