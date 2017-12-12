Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral

    Public Class InventarioAlmacenLoteCollectionClass
        Inherits ColleccionBase(Of EC.inventarioAlmacenLotesEntity, CC.inventarioAlmacenLotesCollection, _
                                    InventarioAlmacenLoteClass)

#Region "Metodos Consulta"
        Public Overloads Function Obtener(ByVal idAlmacen As Integer, ByVal idProducto As Integer) As Boolean

        End Function
#End Region
    End Class

End Namespace