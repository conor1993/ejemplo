Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum

Public Class AplicacionMedicamentoDetalleCollectionClass
    Inherits ColleccionBase(Of EC.AplicMediDetEntity, CC.AplicMediDetCollection, AplicacionMedicamentoDetalleClass)

    Sub New()
        'no se requiere codigo
    End Sub

    Sub New(ByVal coleccion As CC.AplicMediDetCollection)
        Me.coleccion = coleccion
        Rellenar()
    End Sub

    Public Sub Guardar(ByVal entidad As AplicacionMedicamentoDetalleClass)
        Me.Transaction.Add(entidad)
        entidad.Guardar()
    End Sub
End Class