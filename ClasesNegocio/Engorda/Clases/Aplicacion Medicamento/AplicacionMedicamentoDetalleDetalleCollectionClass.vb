Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum


Public Class AplicacionMedicamentoDetalleDetalleCollectionClass
    Inherits ColleccionBase(Of EC.AplicMediDetDetEntity, CC.AplicMediDetDetCollection, AplicacionMedicamentoDetalleDetalleClass)

    Sub New()
        'no se requiere inicializar variables
    End Sub

    Public Sub New(ByVal coleccion As CC.AplicMediDetDetCollection)
        Me.coleccion = coleccion
        Rellenar()
    End Sub

    Public Sub Guardar(ByVal entidad As AplicacionMedicamentoDetalleDetalleClass)
        Me.Transaction.Add(entidad)
        entidad.Guardar()
    End Sub

    'Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
    '    For Each det As AplicacionMedicamentoDetalleDetalleClass In Me
    '        If det.Seleccionado Then
    '            trans.Add(det.Entidad)

    '            det.Guardar(trans)
    '        End If
    '    Next
    'End Function
End Class