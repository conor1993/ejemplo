Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenSalidaDetalleCollectionClass
    Inherits ColleccionBase(Of EC.MinvTransferenciaAlmacenSalidaDetalleEntity, _
                            CC.MinvTransferenciaAlmacenSalidaDetalleCollection, _
                            TransferenciaAlmacenSalidaDetalleClass)

    Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
        Try
            For Each det As TransferenciaAlmacenSalidaDetalleClass In Me
                det.Guardar(trans)
            Next

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class