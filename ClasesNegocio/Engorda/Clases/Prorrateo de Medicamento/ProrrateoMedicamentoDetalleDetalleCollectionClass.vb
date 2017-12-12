Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProrrateoMedicamentoDetalleDetalleCollectionClass
    Inherits ColleccionBase(Of EC.DetDproMedEntity, CC.DetDproMedCollection, ProrrateoMedicamentoDetalleDetalleClass)

    Public Sub Guardar()
        For Each det As ProrrateoMedicamentoDetalleDetalleClass In Me
            Me.Transaction.Add(det)
            det.Guardar()
        Next
    End Sub
End Class