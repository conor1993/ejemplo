Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class MezclaCollection
    Inherits ColleccionBase(Of EC.CabPrepFormEntity, CC.CabPrepFormCollection, Mezcla)

#Region "Metodos"
    Public Sub Imprimir(ByVal empresa As String)
        Try
            Dim reporte As New rptMezcla
            Dim ventanaReporte As New PreVisualizarForm
            Dim mezclas As New dstPreparacionMezcla
            Dim mezcla As dstPreparacionMezcla.MezclasDataTable = mezclas.Tables("Mezclas")
            Dim ingrediente As dstPreparacionMezcla.IngredientesDataTable = mezclas.Tables("Ingredientes")
            Dim loteIngrediente As dstPreparacionMezcla.LotesIngredientesDataTable = mezclas.Tables("LotesIngredientes")
            Dim rowMezcla As dstPreparacionMezcla.MezclasRow
            Dim rowIngrediente As dstPreparacionMezcla.IngredientesRow
            Dim sumaCosto As Decimal = 0D
            Dim sumaCantidadPreparada As Decimal = 0D

            For Each mezclaAImprimir As Mezcla In Me

                With mezclaAImprimir
                    sumaCosto += .CostoTotal
                    sumaCantidadPreparada += .CantidadRealPreparada

                    rowMezcla = mezcla.AddMezclasRow(.FolioPreparacionMezcla, _
                                                .Plaza.Descripcion, .FechaPreparacion, .Almacen.Descripcion, _
                                                .Envase.Descripcion, .CostoTotal, .CantidadPreparar, _
                                                .CantidadRealPreparada, .Mezcla.Descripcion)
                End With

                For Each ingredienteMezcla As Ingrediente In mezclaAImprimir.Ingredientes
                    With ingredienteMezcla
                        rowIngrediente = ingrediente.AddIngredientesRow(.FolioPreparacionMezcla, _
                                                    mezclaAImprimir.Plaza.Descripcion, _
                                                    .Producto.Descripcion, .KilogramosMezcla, _
                                                    .KilogramosSalidaMezcla, .CostoUnitario, .Importe)
                    End With

                    For Each lote As IngredienteLote In ingredienteMezcla.IngredienteLotes
                        With lote
                            loteIngrediente.AddLotesIngredientesRow(.FolioPreparacionMezcla, _
                                                                mezclaAImprimir.Plaza.Descripcion, _
                                                                ingredienteMezcla.Producto.Descripcion, .Lote, _
                                                                .Cantidad, .CostoUnitario, .CostoUnitario * .Cantidad)
                        End With
                    Next
                Next
            Next

            reporte.SetDataSource(mezclas)
            reporte.SetParameterValue(0, empresa)
            reporte.SetParameterValue(1, sumaCantidadPreparada)
            reporte.SetParameterValue(2, sumaCosto)

            ventanaReporte.Reporte = reporte
            ventanaReporte.Text = "Reporte de Preparación de Mezclas"
            ventanaReporte.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            ventanaReporte.WindowState = Windows.Forms.FormWindowState.Maximized

            ventanaReporte.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region
End Class