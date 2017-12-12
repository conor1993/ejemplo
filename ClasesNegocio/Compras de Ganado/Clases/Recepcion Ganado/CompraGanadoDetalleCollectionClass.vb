Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class ComprasGanadoDetalleCollectionClass
    Inherits ColleccionBase(Of EC.DetRegComEntity, CC.DetRegComCollection, CompraGanadoDetalleClass)

    Public Shadows Sub Add(ByVal item As CompraGanadoDetalleClass)
        MyBase.Add(item)
    End Sub

    Public Shadows Sub Add(ByVal folioCompraGanado As String, ByVal renglon As Short, _
                    ByVal idTipoGanado As Integer, ByVal cabezas As Integer, _
                    ByVal kilos As Decimal, ByVal precioxkilo As Decimal, _
                    ByVal kilosRecibidos As Decimal)
        Dim det As New CompraGanadoDetalleClass

        det.Folio = folioCompraGanado
        det.IdRenglon = renglon
        det.IdTipoGanado = idTipoGanado
        det.CantCabezas = cabezas
        det.CantKilos = kilos
        det.PrecioXKilo = precioxkilo
        det.KilosRecibidos = kilosRecibidos

        Add(det)
    End Sub

    Public Shadows Sub Add(ByVal compraGanado As CompraGanadoClass, ByVal renglon As Short, _
                ByVal idTipoGanado As Integer, ByVal cabezas As Integer, _
                ByVal kilos As Decimal, ByVal precioxkilo As Decimal, _
                ByVal kilosRecibidos As Decimal)
        Dim det As New CompraGanadoDetalleClass

        det.CompraGanado = compraGanado
        det.IdRenglon = renglon
        det.IdTipoGanado = idTipoGanado
        det.CantCabezas = cabezas
        det.CantKilos = kilos
        det.PrecioXKilo = precioxkilo
        det.KilosRecibidos = kilosRecibidos

        Add(det)
    End Sub

    Public Function Guardar(ByVal trans As HC.Transaction) As Integer
        For i As Integer = 0 To Me.Count - 1
            Me(i).IdRenglon = i + 1
            Me(i).Guardar(trans)
        Next

        Return Count
    End Function

    Public Function Borrar(ByVal trans As HC.Transaction) As Integer
        For Each detalle As CompraGanadoDetalleClass In Me
            detalle.Borrar(trans)
        Next

        Return Count
    End Function
End Class