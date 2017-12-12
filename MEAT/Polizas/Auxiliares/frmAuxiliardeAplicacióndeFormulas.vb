Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class frmAuxiliardeAplicacióndeFormulas

    Private Sub frmAuxiliardeAplicacióndeFormulas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101001111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.MEAToolBar1.ToolBarButtonStatus = MtbEstados
            Me.MEAToolBar1.sbCambiarEstadoBotones("imprimir")
            Me.dtbFechaContable.Value = Now
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Imprimir()
        Try
            'Controlador.ReporteAuxiliarPolizasFacturasReciba(ClasesNegocio.TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA, Me.dtbFechaContable.Value, ClasesNegocio.EstatusChar.VIGENTE)
            'ReporteAuxiliarPolizasFacturasReciba(ClasesNegocio.TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA, Me.dtbFechaContable.Value, ClasesNegocio.EstatusChar.VIGENTE)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Guardar()
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Imprimir()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub
    Public Sub ReporteAuxiliarPolizasFacturasReciba(Optional ByVal Tipo As TipoFacturaEnum = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA, Optional ByVal FechaContable As DateTime = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS)
        'Dim FacturasdeVenta As New FacturasCollectionClass
        'Dim FacturasVentas As New CC.CabFacturasCollection
        'Dim Previsualizar As New PreVisualizarForm
        'Dim Reporte As Object = Nothing
        'Dim ds As New DataSet, dt As New dsAuxiliarPolizaFacturaRecibaVenta.AuxiliarFacturasRecibaVentaDataTable
        'Dim Modulo As String = String.Empty
        'Dim Filtro As New OC.PredicateExpression
        'Dim Rows() As DataRow = Nothing
        'Dim RangodeFechas As New RangoFechas(Me.dtbFechaContable.Value, Me.dtbFechaContable.Value.AddDays(1))


        'Select Case Tipo
        '    Case TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA
        '        Modulo = "Auxiliar de Póliza de Facturación de Venta en Reciba"
        '        Reporte = New rptAuxiliarPolizaFacturaVentaReciba
        'End Select


        'For Each FacturasdeVentaCabecero As FacturasClass In Controlador.ObtenerFacturasdeVentasParaAuxiliarContable(Me.dtbFechaContable.Value.AddDays(1), TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA)
        '    With FacturasdeVentaCabecero
        '        For Each detalle As FacturasDetalleClass In .Detalles
        '            Dim GanadoDescripcion As String = "", ProductoDescripcion As String = "", UnidadMedidaDescripcion As String = ""
        '            Dim CorralDestinoDescripcion As String = "", CausaMuerteDescripcion As String = "", Recuperacion As String = "NO"
        '            Dim LoteOrigen As String = ""
        '            Dim Clientes As New ClientesIntroductoresClass
        '            Clientes.Obtener(.Cliente)

        '            If (FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA _
        '            OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_CORRAL _
        '            OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_MUERTE_EN_RECIBA _
        '            OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_MUERTE_EN_CORRAL) _
        '            Then
        '                Dim TipodeGanado As New TipoGanadoClass
        '                TipodeGanado.Obtener(detalle.TipoGanado)
        '                GanadoDescripcion = TipodeGanado.Descripcion
        '            End If


        '            If (FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_ESPECIAL _
        '             OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.VENTA_DE_PRODUCTO) _
        '             Then
        '                If detalle.IdProducto <> 0 Then
        '                    Dim Producto As New ProductoClass
        '                    Producto.Obtener(detalle.IdProducto)
        '                    ProductoDescripcion = Producto.Descripcion
        '                    UnidadMedidaDescripcion = Producto.UnidadMedida.DescCorta
        '                Else
        '                    ProductoDescripcion = detalle.Descripcion
        '                End If
        '            End If


        '            If Not detalle.PrecioxKilo.HasValue Then
        '                detalle.PrecioxKilo = 0D
        '            End If
        '            dt.AddAuxiliarFacturasRecibaVentaRow(.NoFactura, .Cliente, Clientes.Nombre, .FechaFactura, .FechaVencimiento, .ImporteSubTotal, .ImporteDescuento, detalle.PorcentajeIVA, detalle.TipoGanado, GanadoDescripcion, detalle.IdProducto, _
        '                                                 ProductoDescripcion, UnidadMedidaDescripcion, detalle.Cabezas, detalle.Kilos, detalle.PrecioxKiloxTipoGanado, detalle.Cantidad, detalle.PrecioUnitario, detalle.Descripcion)
        '        Next
        '    End With
        'Next

        'ds.Tables.Add(dt)
        'Reporte.SetDataSource(ds)
        ''Reporte.SetParameterValue(0, "AuxiliaresContables/" & Modulo)
        ''Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        'Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        'Previsualizar.Reporte = Reporte
        'Previsualizar.ShowDialog()
    End Sub
    Public Sub Guardar()
        'Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Facturas")
        'Try
        '    Dim Total As Decimal
        '    Total = 0
        '    For Each FacturasdeVentaCabecero As FacturasClass In Controlador.ObtenerFacturasdeVentasParaAuxiliarContable(Me.dtbFechaContable.Value.AddDays(1), TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA)
        '        FacturasdeVentaCabecero.FechaContable = Me.dtbFechaContable.Value.Date
        '        Controlador.ContabilizarFacturas(FacturasdeVentaCabecero, FacturasdeVentaCabecero.NoFactura, Trans)
        '    Next
        '    Trans.Commit()
        '    Me.MEAToolBar1.sbCambiarEstadoBotones("imprimir")
        'Catch ex As Exception
        '    Trans.Rollback()
        '    MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class