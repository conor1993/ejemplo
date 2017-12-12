Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral

    Public Class InventarioAlmacenCollectionClass
        Inherits ColleccionBase(Of EC.InventarioAlmacenEntity, CC.InventarioAlmacenCollection, InventarioAlmacenClass)

#Region "Metodos de Consulta"
        Public Overloads Function Obtener(ByVal Almacen As Integer) As Integer
            Try
                Return Obtener(HC.InventarioAlmacenFields.AlmacenId = Almacen)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return -1
            End Try
        End Function
#End Region

    End Class

End Namespace