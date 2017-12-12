Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenEntradaDetalleCollectionClass
    Inherits ColleccionBase(Of EC.MinvTransferenciaAlmacenEntradaDetalleEntity, _
                            CC.MinvTransferenciaAlmacenEntradaDetalleCollection, _
                            TransferenciaAlmacenEntradaDetalleClass)

#Region "Add"
    Public Shadows Sub Add(ByVal item As TransferenciaAlmacenEntradaDetalleClass)
        MyBase.Add(item)
    End Sub

    Public Shadows Sub Add(ByVal folioTransferencia As String, ByVal idProducto As Integer, _
                            ByVal lote As String, ByVal cantidad As Decimal, ByVal importe As Decimal, _
                            ByVal costoUnitario As Decimal, ByVal iva As Decimal)
        Dim det As New TransferenciaAlmacenEntradaDetalleClass

        With det
            .FolioTransferencia = folioTransferencia
            .IdProducto = idProducto
            .Lote = lote
            .Cantidad = cantidad
            .Importe = importe
            .CostoUnitario = costoUnitario
            .Iva = iva
        End With

        Add(det)
    End Sub

    Public Shadows Sub Add(ByVal transferenciaEntrada As TransferenciaAlmacenEntradaClass, ByVal idProducto As Integer, _
                            ByVal lote As String, ByVal cantidad As Decimal, ByVal importe As Decimal, _
                            ByVal costoUnitario As Decimal, ByVal iva As Decimal)
        Dim det As New TransferenciaAlmacenEntradaDetalleClass

        With det
            .TransferenciaEntrada = transferenciaEntrada
            .IdProducto = idProducto
            .Lote = lote
            .Cantidad = cantidad
            .Importe = importe
            .CostoUnitario = costoUnitario
            .Iva = iva
        End With

        Add(det)
    End Sub
#End Region

    Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
        For Each det As TransferenciaAlmacenEntradaDetalleClass In Me
            det.Guardar(trans)
        Next

        Return True
    End Function
End Class