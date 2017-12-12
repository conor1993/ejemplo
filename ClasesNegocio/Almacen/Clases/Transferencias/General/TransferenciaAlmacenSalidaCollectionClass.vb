Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenSalidaCollectionClass
    Inherits ColleccionBase(Of EC.MinvTransferenciaAlmacenSalidaEntity, _
                            CC.MinvTransferenciaAlmacenSalidaCollection, TransferenciaAlmacenSalidaClass)

    Public Function Reporte(ByVal empresa As String) As Boolean
        Try
            Dim vent As New PreVisualizarForm
            Dim rpt As New rptSalidasPorTransferencias
            Dim dst As New dstTransferenciasSalidas
            Dim tbCab As dstTransferenciasSalidas.TransferenciaSalidaDataTable = CType(dst.Tables(0), dstTransferenciasSalidas.TransferenciaSalidaDataTable)
            Dim tbDet As dstTransferenciasSalidas.TransferenciaSalidaDetalleDataTable = CType(dst.Tables(1), dstTransferenciasSalidas.TransferenciaSalidaDetalleDataTable)

            vent.Text = "Reporte de Salidas Por Transferencias"

            For Each transferencia As TransferenciaAlmacenSalidaClass In Me
                With transferencia
                    Dim row As dstTransferenciasSalidas.TransferenciaSalidaRow = _
                                                                tbCab.AddTransferenciaSalidaRow(.FolioTransferencia.Trim, _
                                                                .AlmacenDestino.Descripcion, .AlmacenOrigen.Descripcion, _
                                                                .FechaMovimiento, Integer.Parse(.TotalProductos.ToString()), .Importe, _
                                                                .Estatus.ToString.Replace("_", " "))

                    For Each det As TransferenciaAlmacenSalidaDetalleClass In .Detalle
                        tbDet.AddTransferenciaSalidaDetalleRow(row, det.Producto.Descripcion, det.Lote, _
                                                            det.Cantidad, det.Importe, _
                                                            det.CostoUnitario, det.IVA)
                    Next
                End With
            Next
            
            rpt.SetDataSource(dst)
            rpt.SetParameterValue(0, empresa)

            vent.Reporte = rpt

            vent.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class