Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral

    Public Class MovimientoAlmacenDetalleCollectionClass
        Inherits ColleccionBase(Of EC.InventarioMovimientoAlmacenDetallesEntity, _
                                CC.InventarioMovimientoAlmacenDetallesCollection, MovimientoAlmacenDetalleClass)

#Region "Metodos"
        Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
            For Each det As MovimientoAlmacenDetalleClass In Me
                det.Guardar(trans)
            Next

            Return True
        End Function

        Public Shadows Sub Add(ByVal item As MovimientoAlmacenDetalleClass)
            MyBase.Add(item)
        End Sub

        Public Shadows Sub Add(ByVal indice As Integer, ByVal idAlmacen As Integer, ByVal folioMovimiento As String, _
                                ByVal idProducto As Integer, ByVal fechaMovimiento As Date, ByVal cantidad As Decimal, _
                                ByVal costo As Decimal, ByVal descuento As Decimal, ByVal lote As String)
            Dim movDetalle As New MovimientoAlmacenDetalleClass

            With movDetalle
                .Indice = indice
                .IdAlmacen = idAlmacen
                .FolioMovimientoAlmacen = folioMovimiento
                .IdProducto = idProducto
                .FechaMovimiento = fechaMovimiento
                .Cantidad = cantidad
                .Costo = costo
                .Descuento = descuento
                .Lote = lote
            End With

            Add(movDetalle)
        End Sub

        Public Shadows Sub Add(ByVal movimientoAlmacen As MovimientoAlmacenClass, ByVal indice As Integer, _
                                ByVal idProducto As Integer, ByVal fechaMovimiento As Date, _
                                ByVal cantidad As Decimal, ByVal costo As Decimal, _
                                ByVal descuento As Decimal, ByVal lote As String, ByVal fechaCaducidad As Nullable(Of Date))
            Dim movDetalle As New MovimientoAlmacenDetalleClass


            With movDetalle
                .Indice = indice
                .MovimientoAlmacen = movimientoAlmacen
                .IdProducto = idProducto
                .FechaMovimiento = fechaMovimiento
                .Cantidad = cantidad
                .Costo = costo
                .Descuento = descuento
                .Lote = lote
                .FechaCaducidad = fechaCaducidad
            End With

            movimientoAlmacen.CostoTotal += movDetalle.Improte

            Add(movDetalle)
        End Sub

        Public Shadows Sub Add(ByVal movimientoAlmacen As MovimientoAlmacenClass, ByVal indice As Integer, _
                                ByVal idProducto As Integer, ByVal fechaMovimiento As Date, _
                                ByVal cantidad As Decimal, ByVal costo As Decimal, _
                                ByVal descuento As Decimal, ByVal lote As String, ByVal fechaCaducidad As Nullable(Of Date), _
                                ByVal IdCostoAplicacion As Nullable(Of Integer))
            Dim movDetalle As New MovimientoAlmacenDetalleClass


            With movDetalle
                .Indice = indice
                .MovimientoAlmacen = movimientoAlmacen
                .IdProducto = idProducto
                .FechaMovimiento = fechaMovimiento
                .Cantidad = cantidad
                .Costo = costo
                .Descuento = descuento
                .Lote = lote
                .FechaCaducidad = fechaCaducidad
                .idCostoAplicacion = IdCostoAplicacion
            End With

            movimientoAlmacen.CostoTotal += movDetalle.Improte

            Add(movDetalle)
        End Sub
#End Region
    End Class

End Namespace