Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProrrateoMedicamentoDetalleCollectionClass
    Inherits ColleccionBase(Of EC.DetProMedEntity, CC.DetProMedCollection, ProrrateoMedicamentoDetalleClass)

    Public Sub Guardar()
        For Each det As ProrrateoMedicamentoDetalleClass In Me
            Me.Transaction.Add(det)
            det.Guardar()
        Next
    End Sub
End Class