Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral

    Public Class MovimientoAlmacenCollectionClass
        Inherits ColleccionBase(Of EC.InventarioMovimientoAlmacenEntity, CC.InventarioMovimientoAlmacenCollection, MovimientoAlmacenClass)

        Public Sub Imprimir(ByVal empresa As String)
            Try
                Dim reporte As New rptOtrasEntradas
                Dim ventana As New PreVisualizarForm
                Dim entradas As New dsOtrasEntradas
                Dim ma As dsOtrasEntradas.MovimientoAlmacenDataTable = entradas.Tables("MovimientoAlmacen")
                Dim mad As dsOtrasEntradas.MovimientoAlmacenDetalleDataTable = entradas.Tables("MovimientoAlmacenDetalle")
                Dim rowMa As dsOtrasEntradas.MovimientoAlmacenRow
                Dim rowMad As dsOtrasEntradas.MovimientoAlmacenDetalleRow
                Dim SumaCosto As Decimal = 0D

                For Each OtraEntradaImprimir As AlmacenGeneral.MovimientoAlmacenClass In Me
                    With OtraEntradaImprimir
                        SumaCosto += .CostoTotal

                        rowMa = ma.AddMovimientoAlmacenRow(.FolioMovimientoAlmacen, .Almacen.Descripcion, .FechaMovimiento, _
                                    .EstatusContabilizado, .Entregar, .Recibe, .IdAlmacen)
                    End With

                    For Each OEI As MovimientoAlmacenDetalleClass In OtraEntradaImprimir.Detalle
                        With OEI
                            rowMad = mad.AddMovimientoAlmacenDetalleRow(rowMa, .Producto.Descripcion, .Cantidad, .Improte, .Costo, .Lote, _
                            .Producto.Descripcion, .Almacen.Descripcion)
                        End With
                    Next
                Next

                reporte.SetDataSource(entradas)
                reporte.SetParameterValue(0, empresa)
                'reporte.SetParameterVal(1, SumaCosto)
                ventana.Reporte = reporte
                ventana.Text = "Reporte de Otras Entradas"
                ventana.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
                ventana.WindowState = Windows.Forms.FormWindowState.Maximized
                ventana.ShowDialog()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Sub

        Public Sub ImprimirSalida(ByVal empresa As String, ByVal Usuario As String)
            Try
                Dim reporte As New rptOtrasSalidas
                Dim ventana As New PreVisualizarForm
                Dim salidas As New dsOtrasSalidas
                Dim ma As dsOtrasSalidas.MovimientoAlmacenDataTable = salidas.Tables("MovimientoAlmacen")
                Dim mad As dsOtrasSalidas.MovimientoAlmacenDetalleDataTable = salidas.Tables("MovimientoAlmacenDetalle")
                Dim rowMa As dsOtrasSalidas.MovimientoAlmacenRow
                Dim rowMad As dsOtrasSalidas.MovimientoAlmacenDetalleRow
                Dim SumaCosto As Decimal = 0D

                For Each OtraSalidaImprimir As MovimientoAlmacenClass In Me
                    With OtraSalidaImprimir
                        SumaCosto += .CostoTotal

                        rowMa = ma.AddMovimientoAlmacenRow(.FolioMovimientoAlmacen, .Almacen.Descripcion, .FechaMovimiento, _
                                    .EstatusContabilizado, .Entregar, .Recibe, .IdAlmacen)
                    End With

                    For Each OEI As MovimientoAlmacenDetalleClass In OtraSalidaImprimir.Detalle
                        With OEI
                            rowMad = mad.AddMovimientoAlmacenDetalleRow(rowMa, .Producto.Descripcion, .Cantidad, .Improte, .Costo, .Lote, _
                            .Producto.Descripcion, .Almacen.Descripcion)
                        End With
                    Next
                Next

                reporte.SetDataSource(salidas)
                reporte.SetParameterValue(0, empresa)
                reporte.SetParameterValue(1, usuario)
                ventana.Reporte = reporte
                ventana.Text = "Reporte de Otras Salidas"
                ventana.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
                ventana.WindowState = Windows.Forms.FormWindowState.Maximized
                ventana.ShowDialog()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Sub

        'Public Sub imprimirKardex(ByVal mov As MovimientoAlmacenClass, ByVal empresa As String, ByVal costoInicial As Decimal, ByVal existenciaInicial As Decimal, _
        '                            ByVal totalEntradas As Decimal, ByVal totalsalidas As Decimal, ByVal existenciaActual As Decimal, _
        '                            ByVal usuario As String, ByVal formulario As String, ByVal finicial As Date, ByVal ffinal As Date, _
        '                            ByVal plaza As String, ByVal sucursal As String, ByVal almacen As String, ByVal producto As String, _
        '                            ByVal UnidadMedida As String, ByVal Linea As String, ByVal subLinea As String, _
        '                            ByVal vfmvto As ArrayList, ByVal vfemvto As ArrayList, ByVal vmvto As ArrayList, ByVal ventrada As ArrayList, _
        '                            ByVal vsalidas As ArrayList, ByVal vexistencia As ArrayList, ByVal vcosto As ArrayList, _
        '                            ByVal vcp As ArrayList, ByVal datagrid As da)
        '    Try
        '        Dim reporte As New rptConsultaKardex
        '        Dim ventana As New PreVisualizarForm
        '        Dim salidas As New dsConsultaKardex

        '        Dim detalle As dsConsultaKardex.DetalleKardexDataTable = salidas.Tables("detalleKardex")
        '        Dim rowDetalles As dsConsultaKardex.DetalleKardexRow

        '        Dim contador As Integer = 0
        '        For Each obj As Object In vfmvto
        '            rowDetalles = detalle.AddDetalleKardexRow(CDate(vfemvto.Item(contador)), CType(vfmvto.Item(contador), String), _
        '                                                  CType(vmvto.Item(contador), String), CDec(ventrada.Item(contador)), _
        '                                                CDec(vsalidas.Item(contador)), CDec(vexistencia.Item(contador)), CDec(vcosto.Item(contador)), _
        '                                                CDec(vcp.Item(contador)))
        '            contador += 1
        '        Next


        '        reporte.SetDataSource(salidas)
        '        reporte.SetParameterValue(0, empresa)
        '        reporte.SetParameterValue(1, costoInicial)
        '        reporte.SetParameterValue(2, existenciaInicial)
        '        reporte.SetParameterValue(3, totalEntradas)
        '        reporte.SetParameterValue(4, totalsalidas)
        '        reporte.SetParameterValue(5, existenciaActual)
        '        reporte.SetParameterValue(6, usuario)
        '        reporte.SetParameterValue(7, formulario)
        '        reporte.SetParameterValue(8, finicial)
        '        reporte.SetParameterValue(9, ffinal)
        '        reporte.SetParameterValue(10, plaza)
        '        reporte.SetParameterValue(11, sucursal)
        '        reporte.SetParameterValue(12, almacen)
        '        reporte.SetParameterValue(13, producto)
        '        reporte.SetParameterValue(14, UnidadMedida)
        '        reporte.SetParameterValue(15, Linea)
        '        reporte.SetParameterValue(16, subLinea)
        '        ventana.Reporte = reporte
        '        ventana.Text = "Consulta de kardex de productos"
        '        ventana.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        '        ventana.WindowState = Windows.Forms.FormWindowState.Maximized
        '        ventana.ShowDialog()

        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error imprimirKardex")
        '    End Try
        'End Sub

        Public Shared Sub ImprimirKardex(ByVal empresa As String, ByVal costoInicial As Decimal, ByVal existenciaInicial As Decimal, _
                                                ByVal Entradas As Decimal, ByVal salidas As Decimal, ByVal existenciaFinal As Decimal, _
                                                ByVal usuario As String, ByVal formulario As String, ByVal fechaInicial As Date, ByVal fechaFinal As Date, _
                                                ByVal plaza As String, ByVal sucursal As String, ByVal almacen As String, ByVal producto As String, _
                                                ByVal UnidadMedida As String, ByVal Linea As String, ByVal subLinea As String, _
                                                ByVal movimientos As DataTable)

            Dim reporte As New rptConsultaKardex
            Dim ventana As New PreVisualizarForm

            reporte.SetDataSource(movimientos)
            reporte.SetParameterValue(0, empresa)
            reporte.SetParameterValue(1, costoInicial)
            reporte.SetParameterValue(2, existenciaInicial)
            reporte.SetParameterValue(3, Entradas)
            reporte.SetParameterValue(4, salidas)
            reporte.SetParameterValue(5, existenciaFinal)
            reporte.SetParameterValue(6, usuario)
            reporte.SetParameterValue(7, formulario)
            reporte.SetParameterValue(8, fechaInicial)
            reporte.SetParameterValue(9, fechaFinal)
            reporte.SetParameterValue(10, plaza)
            reporte.SetParameterValue(11, sucursal)
            reporte.SetParameterValue(12, almacen)
            reporte.SetParameterValue(13, producto)
            reporte.SetParameterValue(14, UnidadMedida)
            reporte.SetParameterValue(15, Linea)
            reporte.SetParameterValue(16, subLinea)

            ventana.Reporte = reporte
            ventana.Text = "Consulta de kardex de productos"
            ventana.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            ventana.WindowState = Windows.Forms.FormWindowState.Maximized
            ventana.ShowDialog()
        End Sub

        Public Sub ImprimirSalidaPorConsumo(ByVal empresa As String, ByVal vecCostoaplicacion As ArrayList, ByVal observaciones As String, _
                                                ByVal usuario As String, ByVal formulario As String)
            Try
                Dim reporte As New rptSalidasAlmacenPorConsumo
                Dim ventana As New PreVisualizarForm
                Dim salidas As New dsSalidaAlmacenPorConsumo
                Dim ma As dsSalidaAlmacenPorConsumo.MovimientoAlmacenDataTable = salidas.Tables("MovimientoAlmacen")
                Dim mad As dsSalidaAlmacenPorConsumo.MovimientoAlmacenDetalleDataTable = salidas.Tables("MovimientoAlmacenDetalle")
                Dim rowMa As dsSalidaAlmacenPorConsumo.MovimientoAlmacenRow
                Dim rowMad As dsSalidaAlmacenPorConsumo.MovimientoAlmacenDetalleRow
                Dim SumaCosto As Decimal = 0D

                For Each OtraSalidaImprimir As MovimientoAlmacenClass In Me
                    With OtraSalidaImprimir
                        SumaCosto += .CostoTotal

                        rowMa = ma.AddMovimientoAlmacenRow(.FolioMovimientoAlmacen, .Almacen.Descripcion, .FechaMovimiento, _
                                    .EstatusContabilizado, .Entregar, .Recibe, .IdAlmacen, .Observaciones)
                    End With

                    Dim cont As Integer = 0
                    For Each OEI As MovimientoAlmacenDetalleClass In OtraSalidaImprimir.Detalle
                        With OEI
                            rowMad = mad.AddMovimientoAlmacenDetalleRow(rowMa, .Producto.Descripcion, .Cantidad, .Improte, .Costo, .Lote, _
                            .Producto.Descripcion, .Almacen.Descripcion, vecCostoaplicacion(cont))
                        End With
                        cont += 1
                    Next
                Next

                reporte.SetDataSource(salidas)
                reporte.SetParameterValue(0, empresa)
                reporte.SetParameterValue(2, usuario)
                reporte.SetParameterValue(3, formulario)
                'reporte.SetParameterValue(1, observaciones)
                ventana.Reporte = reporte
                ventana.Text = "Reporte Salidas Por Consumo"
                ventana.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
                ventana.WindowState = Windows.Forms.FormWindowState.Maximized
                ventana.ShowDialog()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Sub

        ''' <summary>
        ''' Imprime los movimeintos del almacén general agrupado por producto
        ''' </summary>
        ''' <param name="empresa"></param>
        ''' <param name="usuario"></param>
        ''' <param name="formulario"></param>
        ''' <param name="agruparProducto"></param>
        ''' <param name="filtro"></param>
        ''' <remarks></remarks>
        Public Shared Sub Imprimir(ByVal empresa As String, ByVal usuario As String, ByVal formulario As String, ByVal agruparProducto As Boolean, ByVal filtro As OC.PredicateExpression)
            Dim movimientos As New Integralab.ORM.TypedListClasses.MovimientosAlmacenGeneralTypedList
            Dim reporteAgrupado As rptMovimientosAlmacenGeneralAgrupado
            Dim reporteSinAgrupar As rptMovimientosAlmacenGeneralSinAgrupar
            Dim previsualizar As New PreVisualizarForm

            movimientos.Fill(0, New OC.SortExpression(New OC.SortClause(HC.InventarioMovimientoAlmacenFields.FechaMovimiento, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), False, filtro)

            If agruparProducto Then
                reporteAgrupado = New rptMovimientosAlmacenGeneralAgrupado
                reporteAgrupado.SetDataSource(CType(movimientos, Object))
                reporteAgrupado.SetParameterValue(0, empresa)
                reporteAgrupado.SetParameterValue(1, usuario)
                reporteAgrupado.SetParameterValue(2, formulario)

                previsualizar.Reporte = reporteAgrupado
            Else
                reporteSinAgrupar = New rptMovimientosAlmacenGeneralSinAgrupar
                reporteSinAgrupar.SetDataSource(CType(movimientos, Object))
                reporteSinAgrupar.SetParameterValue(0, empresa)
                reporteSinAgrupar.SetParameterValue(1, usuario)
                reporteSinAgrupar.SetParameterValue(2, formulario)

                previsualizar.Reporte = reporteSinAgrupar
            End If

            previsualizar.Text = "Reporte de Movmientos de Almacén General"
            previsualizar.ShowDialog()
        End Sub
    End Class

End Namespace