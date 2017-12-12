Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenEntradaCollectionClass
    Inherits ColleccionBase(Of EC.MinvTransferenciaAlmacenEntradaEntity, _
                            CC.MinvTransferenciaAlmacenEntradaCollection, _
                            TransferenciaAlmacenEntradaClass)

    Public Sub Imprimir(ByVal empresa As String)
        Try
            Dim rpt As New rptEntradaPorTransferencias
            Dim ventPrevisualizacion As New PreVisualizarForm
            Dim dst As New dstTransferenciasEntradas
            Dim tbCab As dstTransferenciasEntradas.TransferenciaEntradasDataTable = dst.Tables(0)
            Dim tbDet As dstTransferenciasEntradas.TransferenciaEntradasDetalleDataTable = dst.Tables(1)

            For Each transferencia As TransferenciaAlmacenEntradaClass In Me
                With transferencia
                    Dim row As dstTransferenciasEntradas.TransferenciaEntradasRow = _
                                            tbCab.AddTransferenciaEntradasRow(.FolioTranferencia, _
                                            .AlmacenDestino.Descripcion, .AlmacenOrigen.Descripcion, _
                                            .FechaMovimiento, .TotalProductos, .Importe, .Estatus.ToString, _
                                            .FolioTranferenciaSalida)

                    For Each det As TransferenciaAlmacenEntradaDetalleClass In .Detalle
                        tbDet.AddTransferenciaEntradasDetalleRow(row, det.Producto.Descripcion, _
                                                            det.Lote, det.Cantidad, det.Importe, _
                                                            det.CostoUnitario, det.Iva)
                    Next
                End With
            Next

            rpt.SetDataSource(dst)
            rpt.SetParameterValue(0, empresa)

            ventPrevisualizacion.Reporte = rpt
            ventPrevisualizacion.Text = "Reporte de Entradas Por Transferencias"
            ventPrevisualizacion.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se realizaba la impresión de la transferencia", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
End Class