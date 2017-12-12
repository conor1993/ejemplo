Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class GastoTransporteDetalleCollectionClass
    Inherits ColleccionBase(Of EC.DetGasTransEntity, CC.DetGasTransCollection, GastoTransporteDetalleClass)

    Public Shadows Sub Add(ByVal item As GastoTransporteDetalleClass)
        MyBase.Add(item)
    End Sub

    Public Shadows Sub Add(ByVal folioGasto As String, ByVal renglon As Integer, _
                            ByVal idConceptoGasto As Integer, ByVal ptjIva As Single, _
                            ByVal importe As Decimal)
        Dim crearDetalle As New GastoTransporteDetalleClass

        With crearDetalle
            .Folio = folioGasto
            .Renglon = renglon
            .IdGasto = idConceptoGasto
            .PorcentajeIva = ptjIva
            .ImporteGasto = importe
        End With

        Add(crearDetalle)
    End Sub

    Public Shadows Sub Add(ByVal gastoTransporte As GastoTransporteClass, ByVal renglon As Integer, _
                            ByVal idConceptoGasto As Integer, ByVal ptjIva As Single, _
                            ByVal importe As Decimal)
        Dim crearDetalle As New GastoTransporteDetalleClass

        With crearDetalle
            .GastoTransporte = gastoTransporte
            .Renglon = renglon
            .IdGasto = idConceptoGasto
            .PorcentajeIva = ptjIva
            .ImporteGasto = importe
        End With

        Add(crearDetalle)
    End Sub

    Public Function Guardar(ByVal trans As HC.Transaction) As Integer
        For Each gasto As GastoTransporteDetalleClass In Me
            gasto.Guardar(trans)
        Next

        Return Count
    End Function

    Public Overloads Function Obtener(ByVal Folio As String) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not Folio = "" Then filtro.Add(HC.DetGasTransFields.FolRecep = Folio)

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class