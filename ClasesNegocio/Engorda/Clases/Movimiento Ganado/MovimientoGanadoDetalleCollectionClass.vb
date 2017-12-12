Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class MovimientoGanadoDetalleCollectionClass
    Inherits ColleccionBase(Of EC.DetMovGanEntity, CC.DetMovGanCollection, MovimientoGanadoDetalleClass)

#Region "Metodos"
#Region "Metodos Add"

    Public Shadows Sub Add(ByVal Item As MovimientoGanadoDetalleClass)
        MyBase.Add(Item)
    End Sub

    Public Shadows Sub Add(ByRef MovimientoGanado As MovimientoGanadoClass, ByVal Item As MovimientoGanadoDetalleClass)
        Item.MovimeintoGanado = MovimientoGanado
        Item.Contenedor = Me
        MovimientoGanado.CostoTotal += Item.Importe
        MyBase.Add(Item)
    End Sub

    Public Shadows Sub Add(ByVal item As IMovimientoGanadoDetalle)
        Dim detAdd As New MovimientoGanadoDetalleClass

        With detAdd
            .MovimeintoGanado = item.MovimeintoGanado
            .IdTipoGanado = item.IdTipoGanado
            .FechaMovimiento = item.FechaMovimiento
            .Cabezas = item.Cabezas
            .Kilos = item.Kilos
            .CostoXKilo = item.CostoKilo
        End With

        detAdd.Contenedor = Me
        item.MovimeintoGanado.CostoTotal += detAdd.Importe

        MyBase.Add(detAdd)
    End Sub

    Public Shadows Sub Add(ByVal item As IMovimientoGanadoDetalleCancelacion)
        Dim detAdd As New MovimientoGanadoDetalleClass

        With detAdd
            .MovimeintoGanado = item.MovimeintoGanado
            .IdTipoGanado = item.IdTipoGanado
            .FechaMovimiento = item.FechaCancelacion
            .Cabezas = item.Cabezas
            .Kilos = item.Kilos
            .CostoXKilo = item.CostoKilo
        End With

        detAdd.Contenedor = Me
        item.MovimeintoGanado.CostoTotal += detAdd.Importe

        MyBase.Add(detAdd)
    End Sub

    Public Shadows Sub Add(ByVal movimientoGanado As MovimientoGanadoClass, ByVal idTipoGanado As Integer, _
                            ByVal fechaMovimiento As Date, ByVal cabezas As Integer, ByVal kilos As Decimal, _
                            ByVal costoXKilo As Decimal)
        Dim detAdd As New MovimientoGanadoDetalleClass

        With detAdd
            .MovimeintoGanado = movimientoGanado
            .IdTipoGanado = idTipoGanado
            .FechaMovimiento = fechaMovimiento
            .Cabezas = cabezas
            .Kilos = kilos
            .CostoXKilo = costoXKilo
        End With

        movimientoGanado.Contenedor = Me
        movimientoGanado.CostoTotal += detAdd.Importe

        MyBase.Add(detAdd)
    End Sub
#End Region

#Region "Sobrecarga Operadores"
    Public Shared Operator +(ByVal detalle As MovimientoGanadoDetalleCollectionClass, ByVal det As IMovimientoGanadoDetalle) As MovimientoGanadoDetalleCollectionClass
        detalle.Add(det)
        Return detalle
    End Operator

    Public Shared Operator +(ByVal detalle As MovimientoGanadoDetalleCollectionClass, _
                                ByVal det As IMovimientoGanadoDetalleCancelacion) As MovimientoGanadoDetalleCollectionClass
        detalle.Add(det)
        Return detalle
    End Operator
#End Region

#Region "Generles"
    Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
        For i As Integer = 0 To Me.Count - 1
            Me(i).IdDetMovGan = i + 1
            Me(i).Guardar(trans)
        Next

        Return True
    End Function
#End Region
#End Region
End Class