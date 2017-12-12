Imports CN = ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient
Imports ClasesNegocio.InventarioConfigProduccionClass
Imports ClasesNegocio

Public Class frmTransferenciasCajas

#Region "Miembros"
    Dim idAlmacenesProd As New List(Of Integer)
    Dim cargando As Boolean = False
    'Dim detalle As New TC.VwConsltaTransferenciasCajasDetalleTypedView
    Dim editando As Boolean = False
    Dim validarCajas As Boolean = True
    'Dim AlmacenDestinoC As New ClasesNegocio.AlmacenCollectionClass
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        editando = False
        Me.txtFolioEtiqueta.Clear()
        Me.txtFolioTransferencia.Clear()
        Me.txtkilos.Clear()
        Me.txtPiezas.Clear()
        Me.DgvCortes.Rows.Clear()
        Me.cmbAlmacenDestino.SelectedIndex = -1
        Me.cmbAlmacenDestino.Text = "Seleccione un almacén..."
    End Sub

    Private Sub Deshabilitar()
        Me.cmbAlmacenDestino.Enabled = False
        Me.txtFolioEtiqueta.Enabled = False
        Me.btnBusquedaEtiquetas.Enabled = False
        Me.btnVaciarPistola.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.cmbAlmacenDestino.Enabled = True
        Me.txtFolioEtiqueta.Enabled = True
        Me.btnBusquedaEtiquetas.Enabled = True
        Me.btnVaciarPistola.Enabled = True
    End Sub

    Private Sub AgregarCajasAlGrid(ByVal etiquetas As List(Of String), Optional ByVal EsBusqueda As Boolean = False)
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            Dim cadenaConsulta As String
            Dim col As New CC.MscloteCortesDetCollection
            Dim etiquetasNoAgregadas As New List(Of EtiquetasNoValidas)
            Dim sqlCom As SqlClient.SqlCommand
            Dim dr As SqlDataReader
            Dim ad As New SqlDataAdapter
            Dim tb As New DataTable
            Dim condicion As String = ""

            For Each etiqueta As String In etiquetas
                If condicion = "" Then
                    condicion = "'" & etiqueta.Trim & "'"
                Else
                    condicion &= ", '" & etiqueta.Trim & "'"
                End If
            Next

            cadenaConsulta = "SELECT        dbo.MSCLoteCortesDet.*, dbo.MSCCatProductos.Descripcion AS Producto, " & _
                             "              dbo.MSCLoteCortesCab.FechaCorte, dbo.MSCLoteCortesCab.FechaCad, " & _
                             "              MCatAlmacenes.Nombre AS Almacen " & _
                             "FROM          dbo.MSCLoteCortesDet INNER JOIN dbo.MSCCatProductos ON " & _
                             "              dbo.MSCLoteCortesDet.IdProducto = dbo.MSCCatProductos.IdProducto " & _
                             "              INNER JOIN dbo.MSCLoteCortesCab ON dbo.MSCLoteCortesDet.LoteCorte " & _
                             "              = dbo.MSCLoteCortesCab.LoteCorte INNER JOIN MCatAlmacenes ON MCatAlmacenes.Codigo = MSCLoteCortesDet.IdAlmacenActual " & _
                             "WHERE         dbo.MSCLoteCortesDet.IdFolioEtiqueta IN (" & condicion & ") OR " & _
                             "              dbo.MSCLoteCortesDet.CodigoBarra IN (" & condicion & ")"

            sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
            sqlCon.Open()
            dr = sqlCom.ExecuteReader()

            While dr.Read()
                Dim Almacen As String

                If Not validarCajas Then GoTo SINVALIDAR

                If dr("Estatus") = 1 Then
                    If DBNull.Value.Equals(dr("IdFolioEmbarque")) OrElse dr("IdFolioEmbarque").ToString.Trim = "" Then
                        If (dr("TipoProducto") = ClasesNegocio.TipoCorte.CONGELADO OrElse _
                            dr("TipoProducto") = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO OrElse _
                            dr("TipoProducto") = ClasesNegocio.TipoCorte.HUESO_CONGELADO) AndAlso _
                            Not (TryCast(Me.cmbAlmacenDestino.SelectedItem, _
                            EC.AlmacenEntity).TipoProducto = ClasesNegocio.TipoProductoAlmacen.CONGELADO OrElse _
                            TryCast(Me.cmbAlmacenDestino.SelectedItem, _
                            EC.AlmacenEntity).TipoProducto = ClasesNegocio.TipoProductoAlmacen.VENTA) Then

                            etiquetasNoAgregadas.Add(New EtiquetasNoValidas(dr("IdFolioEtiqueta").ToString.Trim, _
                                                    "CAJA CONGELADA NO PUEDE TRANSPASARSE A UN ALMACÉN DE PRODUCTO FRESCO", _
                                                    dr("IdProducto"), dr("Producto"), dr("CodigoBarra")))
                        Else
SINVALIDAR:
                            If EsBusqueda Then
                                Dim traspasoDetalle As New EC.MinvTransferenciaAlmacenProdDetalleEntity(txtFolioTransferencia.Text, dr("IdFolioEtiqueta").ToString)
                                Almacen = traspasoDetalle.Almacen.Descripcion
                            Else
                                Almacen = dr("Almacen")
                            End If

                            AgregarFilaGrid(Almacen, dr("IdFolioEtiqueta"), dr("LoteCorte"), dr("IdProducto"), _
                                                dr("Producto"), dr("CantPzas"), CDec(dr("CantKgrs")), _
                                                dr("FechaCorte"), _
                                                IIf(DBNull.Value.Equals(dr("FechaCaducidad")), _
                                                    dr("FechaCad"), dr("FechaCaducidad")), _
                                                IIf(DBNull.Value.Equals(dr("FechaCaducidadAnterior")), _
                                                    IIf(DBNull.Value.Equals(dr("FechaCaducidad")), dr("FechaCad"), _
                                                        dr("FechaCaducidad")), _
                                                    dr("FechaCaducidadAnterior")), _
                                                dr("Estatus"), dr("TipoProducto"), _
                                                IIf(DBNull.Value.Equals(dr("TipoProductoAnterior")), -1, _
                                                    dr("TipoProductoAnterior")), dr("IdAlmacenActual"), _
                                                    IIf(DBNull.Value.Equals(dr("IdAlmacenOrigen")), 0, dr("IdAlmacenOrigen")))
                        End If
                    Else
                        etiquetasNoAgregadas.Add(New EtiquetasNoValidas(dr("IdFolioEtiqueta"), _
                                                 "ETIQUETA EMBARCADA", dr("IdProducto"), _
                                                 dr("Producto"), dr("CodigoBarra")))
                    End If
                ElseIf dr("Estatus") = ClasesNegocio.EstatusCorte.REPROCESO Then
                    etiquetasNoAgregadas.Add(New EtiquetasNoValidas(dr("IdFolioEtiqueta"), _
                                            "ETIQUETA REPROCESADA", dr("IdProducto"), _
                                            dr("Producto"), dr("CodigoBarra")))
                ElseIf dr("Estatus") = ClasesNegocio.EstatusCorte.CANCELADO Then
                    etiquetasNoAgregadas.Add(New EtiquetasNoValidas(dr("IdFolioEtiqueta"), _
                                            "ETIQUETA CANCELADA", dr("IdProducto"), _
                                            dr("Producto"), dr("CodigoBarra")))
                ElseIf dr("Estatus") = ClasesNegocio.EstatusCorte.AJUSTE Then
                    etiquetasNoAgregadas.Add(New EtiquetasNoValidas(dr("IdFolioEtiqueta"), _
                                            "ETIQUETA AJUSTADA", dr("IdProducto"), _
                                            dr("Producto"), dr("CodigoBarra")))
                End If
            End While

            Dim ventana As New frmMensajeCajasNoAgregadas
            Dim lv As ListView = ventana.lvwCajas

            For Each etiqueta As EtiquetasNoValidas In etiquetasNoAgregadas
                With etiqueta
                    lv.Items.Add(etiqueta.idFolioEtiqueta)
                    lv.Items(lv.Items.Count - 1).SubItems.Add(etiqueta.CodigoBarras)
                    lv.Items(lv.Items.Count - 1).SubItems.Add(etiqueta.Producto)
                    lv.Items(lv.Items.Count - 1).SubItems.Add(etiqueta.idMotivo)
                End With
            Next

            Me.SumarKilosYPiezas()

            If etiquetasNoAgregadas.Count > 0 Then
                ventana.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub AgregarFilaGrid(ByVal Almacen As String, ByVal folioEtiqueta As String, ByVal loteCorte As String, ByVal idCorte As Integer, _
                                ByVal nombreCorte As String, ByVal piezas As Integer, _
                                ByVal kilos As Decimal, ByVal fechaCorte As Date, _
                                ByVal fechaCaducidad As Date, ByVal fechaCaducidadAnterior As Date, _
                                ByVal estatusCaja As Short, ByVal tipoProducto As Short, _
                                ByVal tipoProductoAnterior As Short, ByVal idAlmacenActual As Integer, _
                                ByVal idAlmacenOrigen As Integer)
        Me.DgvCortes.Rows.Add(1)

        With Me.DgvCortes.Rows(Me.DgvCortes.Rows.Count - 1)
            .Cells(Me.clmAlmacen.Index).Value = Almacen
            .Cells(Me.clmEtiqueta.Index).Value = folioEtiqueta
            .Cells(Me.clmLoteCorte.Index).Value = loteCorte
            .Cells(Me.clmIdCorte.Index).Value = idCorte
            .Cells(Me.clmCorte.Index).Value = nombreCorte
            .Cells(Me.clmPiezas.Index).Value = piezas
            .Cells(Me.clmKilos.Index).Value = kilos
            .Cells(Me.clmFechaCorte.Index).Value = fechaCorte
            .Cells(Me.clmFechaCad.Index).Value = fechaCaducidad
            .Cells(Me.clmFechaCaducidadAnterior.Index).Value = fechaCaducidadAnterior
            .Cells(Me.clmEstatusCaja.Index).Value = estatusCaja
            .Cells(Me.clmTipoProducto.Index).Value = tipoProducto
            .Cells(Me.clmTipoProductoAnterior.Index).Value = tipoProductoAnterior
            .Cells(Me.clmIdAlmacenActual.Index).Value = idAlmacenActual
            .Cells(Me.clmIdAlmacenOrigen.Index).Value = idAlmacenOrigen
        End With
    End Sub

    Private Sub SumarKilosYPiezas()
        Try
            Dim kilos As Decimal = 0D
            Dim piezas As Integer = 0

            For Each fila As DataGridViewRow In Me.DgvCortes.Rows
                kilos += CDec(fila.Cells(Me.clmKilos.Index).Value)
                piezas += CInt(fila.Cells(Me.clmPiezas.Index).Value)
            Next

            Me.txtPiezas.Text = piezas
            Me.txtkilos.Text = kilos.ToString("N2")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function EstablecerTipoProducto(ByVal fila As DataGridViewRow, _
                                        ByRef cajaDatosModificados As EC.MscloteCortesDetEntity, _
                                        ByRef mensajeError As String) As Boolean
        Dim AlmacenDestino As EC.AlmacenEntity = CType(Me.cmbAlmacenDestino.SelectedItem, EC.AlmacenEntity)

        If AlmacenDestino.TipoProducto = ClasesNegocio.TipoProductoAlmacen.CONGELADO Then
            'traspasar corte a almacen congelado

            Select Case CShort(fila.Cells(Me.clmTipoProducto.Index).Value)
                Case ClasesNegocio.TipoCorte.CONGELADO
                    'de corte congelado a corte congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.CONGELADO
                Case ClasesNegocio.TipoCorte.FRESCO
                    'de corte fresco a corte congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.FRESCO
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.VENTA
                    'de corte fresco a corte congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VENTA
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                    'de valor agregado congelado a valor agregado congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                    'de valor agregado fresco a valor agregado congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    'de valor agregado fresco a valor agregado congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.HUESO_CONGELADO
                    'de corte congelado a uno congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_CONGELADO
                Case ClasesNegocio.TipoCorte.HUESO_FRESCO
                    'de fresco a congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_FRESCO
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.HUESO_VENTA
                    'de fresco a congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_CONGELADO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_VENTA
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
            End Select
        ElseIf AlmacenDestino.TipoProducto = ClasesNegocio.TipoProductoAlmacen.FRESCO Then
            'traspasar corte a almacen fresco 

            Select Case CShort(fila.Cells(Me.clmTipoProducto.Index).Value)
                Case ClasesNegocio.TipoCorte.CONGELADO
                    'de corte Congelado a Fresco
                    mensajeError = "No se puede traspasar un corte congelado a fresco"
                    Return False
                Case ClasesNegocio.TipoCorte.FRESCO
                    'de corte fresco a corte fresco
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.FRESCO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.FRESCO
                Case ClasesNegocio.TipoCorte.VENTA
                    'de corte fresco a corte fresco
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.FRESCO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VENTA
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                    'de valor agregado congelado a valor agregado fresco
                    mensajeError = "No se puede traspasar un corte valor agregado congelado a fresco"
                    Return False
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                    'de valor agregado fresco a valor agregado fresco
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    'de valor agregado fresco a valor agregado fresco
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                Case ClasesNegocio.TipoCorte.HUESO_CONGELADO
                    'de corte congelado a uno fresco
                    mensajeError = "No se puede traspasar un corte congelado a fresco"
                    Return False
                Case ClasesNegocio.TipoCorte.HUESO_FRESCO
                    'de fresco a fresco
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_FRESCO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_FRESCO
                Case ClasesNegocio.TipoCorte.HUESO_VENTA
                    'de fresco a fresco
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_FRESCO
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_VENTA
            End Select
        ElseIf AlmacenDestino.TipoProducto = ClasesNegocio.TipoProductoAlmacen.VENTA Then
            Select Case CShort(fila.Cells(Me.clmTipoProducto.Index).Value)
                Case ClasesNegocio.TipoCorte.CONGELADO
                    'de corte congelado a corte congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.CONGELADO
                Case ClasesNegocio.TipoCorte.FRESCO
                    'de corte fresco a corte congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.FRESCO
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.VENTA
                    'de corte fresco a corte congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VENTA
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                    'de valor agregado congelado a valor agregado congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_CONGELADO
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                    'de valor agregado fresco a valor agregado congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_FRESCO
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    'de valor agregado fresco a valor agregado congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.VALOR_AGREGADO_VENTA
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.HUESO_CONGELADO
                    'de corte congelado a uno congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_CONGELADO
                Case ClasesNegocio.TipoCorte.HUESO_FRESCO
                    'de fresco a congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_FRESCO
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
                Case ClasesNegocio.TipoCorte.HUESO_VENTA
                    'de fresco a congelado
                    cajaDatosModificados.TipoProducto = ClasesNegocio.TipoCorte.HUESO_VENTA
                    cajaDatosModificados.TipoProductoAnterior = ClasesNegocio.TipoCorte.HUESO_VENTA
                    cajaDatosModificados.FechaCaducidad = CDate(fila.Cells(Me.clmFechaCorte.Index).Value).AddDays(Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado)
                    cajaDatosModificados.FechaCaducidadAnterior = CDate(fila.Cells(Me.clmFechaCad.Index).Value)
            End Select
        End If

        Return True
    End Function

    Private Function AfectarInventario(ByVal tipoMovimientoEntrada As TipoMovimientoProdEnum, _
                                    ByVal tipoMovimientoSalida As TipoMovimientoProdEnum, _
                                    ByVal kilos As Decimal, ByVal piezas As Decimal, ByVal idAlmacenDestino As Integer, _
                                    ByVal idAlmacenActual As Integer, ByVal idProducto As Integer, _
                                    ByRef trans As HC.Transaction, _
                                    ByRef folioMovimientoAlmacenEntrada As String, _
                                    ByRef folioMovimeintoAlmacenSalida As String) As Boolean
        Dim movAlmSal As New ClasesNegocio.MovimientoAlmacenClass
        Dim movAlmEnt As New ClasesNegocio.MovimientoAlmacenClass

        With movAlmSal
            .EstablecerTipoMovimiento(tipoMovimientoSalida)
            .IdAlmacen = idAlmacenActual
            .IdPoliza = ""
            .Estatus = ClasesNegocio.EstatusChar.VIGENTE
            .Kilos = kilos
            .Piezas = piezas
            .FechaMovimiento = Now
            .AgregarDetalle(idProducto, .Kilos, .Piezas, 0D, 0D)

            If Not .Guardar(trans) Then
                trans.Rollback()
                MsgBox("No se logro afectar el almacen", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End With

        With movAlmEnt
            .IdAlmacen = idAlmacenDestino
            .EstablecerTipoMovimiento(tipoMovimientoEntrada)
            .Estatus = ClasesNegocio.EstatusChar.VIGENTE
            .FechaMovimiento = Now
            .IdPoliza = ""
            .Kilos = movAlmSal.Kilos
            .Piezas = movAlmSal.Piezas
            .AgregarDetalle(idProducto, .Kilos, .Piezas, 0D, 0D)

            If Not .Guardar(trans) Then
                trans.Rollback()
                MsgBox("No se logro afectar el almacen", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End With

        folioMovimientoAlmacenEntrada = movAlmEnt.FolioMovimiento
        folioMovimeintoAlmacenSalida = movAlmSal.FolioMovimiento

        Return True
    End Function

    Private Function GuardarGrid(ByRef traspaso As EC.MinvTransferenciaAlmacenProdEntity, _
                                ByRef trans As HC.Transaction) As Boolean
        Try
            Dim folioMovimientoAlmacenEntrada As String = ""
            Dim folioMovimientoAlmacenSalida As String = ""
            Dim mensajeError As String = ""
            Dim col As New CC.MscloteCortesDetCollection
            Dim detalleTraspaso As New CC.MinvTransferenciaAlmacenProdDetalleCollection

            For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                Dim fila As DataGridViewRow = Me.DgvCortes.Rows(i)
                Dim cajaDatosModificados As New EC.MscloteCortesDetEntity
                Dim detTraspaso As New EC.MinvTransferenciaAlmacenProdDetalleEntity
                Dim idAlmacenDestino As Integer = traspaso.IdAlmacenDestino
                Dim idAlmacenActual As Integer = CInt(fila.Cells(Me.clmIdAlmacenActual.Index).Value)
                Dim idProducto As Integer = CInt(fila.Cells(Me.clmIdCorte.Index).Value)
                Dim kilos As Decimal = CDec(fila.Cells(Me.clmKilos.Index).Value)
                Dim piezas As Integer = CInt(fila.Cells(Me.clmPiezas.Index).Value)

                If Not Me.AfectarInventario(TipoMovimientoProdEnum.Entrada_Corte_X_Traspaso, _
                                        TipoMovimientoProdEnum.Salida_Corte_X_Traspaso, _
                                        kilos, piezas, idAlmacenDestino, idAlmacenActual, idProducto, _
                                        trans, folioMovimientoAlmacenEntrada, _
                                        folioMovimientoAlmacenSalida) Then
                    Return False
                End If

                cajaDatosModificados.IdFolioMovimiento = folioMovimientoAlmacenEntrada
                cajaDatosModificados.IdAlmacenActual = idAlmacenDestino
                cajaDatosModificados.IdAlmacenOrigen = idAlmacenActual

                If Not Me.EstablecerTipoProducto(fila, cajaDatosModificados, mensajeError) Then
                    trans.Rollback()
                    MsgBox(mensajeError, MsgBoxStyle.Exclamation, "Error")
                    Return False
                End If

                trans.Add(col)

                col.UpdateMulti(cajaDatosModificados, HC.MscloteCortesDetFields.IdFolioEtiqueta = _
                                fila.Cells(Me.clmEtiqueta.Index).Value.ToString.Trim And _
                                HC.MscloteCortesDetFields.LoteCorte = _
                                fila.Cells(Me.clmLoteCorte.Index).Value.ToString.Trim)

                traspaso.Kilos += CDec(fila.Cells(Me.clmKilos.Index).Value)
                traspaso.Piezas += CInt(fila.Cells(Me.clmPiezas.Index).Value)

                With detTraspaso
                    .FolioTransferencia = traspaso.FolioTransferencia
                    .FolioEtiqueta = fila.Cells(Me.clmEtiqueta.Index).Value.ToString.Trim
                    .FolioMovimeinto = folioMovimientoAlmacenEntrada
                    .IdAlmacenOrigen = idAlmacenActual
                    .IdProducto = idProducto
                    .Kilos = kilos
                    .Piezas = piezas
                    .TipoProducto = cajaDatosModificados.TipoProducto
                End With

                detalleTraspaso.Add(detTraspaso)
            Next

            trans.Add(traspaso)
            trans.Add(detalleTraspaso)

            traspaso.Save()
            detalleTraspaso.SaveMulti()

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub frmTransferenciasCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "001101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Controlador.Configuracion.ActualizarProduccion()

            If Not Controlador.Configuracion.Produccion.Entidad.IsNew Then
                With Controlador.Configuracion.Produccion
                    idAlmacenesProd.Add(.IdAlmacenCanales)
                    idAlmacenesProd.Add(.IdAlmacenDecomisos)
                    idAlmacenesProd.Add(.IdAlmacenProductos)
                End With
            Else
                mtb.Enabled = False
                cmbAlmacenDestino.Enabled = False
                gbCajas.Enabled = False
                MessageBox.Show("Debe definir la configuracion de Produccion", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim rel As New OC.RelationCollection
            Dim alm As New CC.AlmacenCollection

            rel.Add(New OC.EntityRelation(HC.TipoAlmacenFields.Codigo, HC.AlmacenFields.TipoAlmacen, SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany))

            alm.GetMulti(HC.TipoAlmacenFields.DeProduccion = 1 And _
                                        HC.AlmacenFields.Estatus = 1 And _
                                        New OC.FieldCompareRangePredicate(HC.AlmacenFields.AlmacenId, True, _
                                        idAlmacenesProd.ToArray) And Not HC.AlmacenFields.TipoProducto = 0, rel)
            Me.cmbAlmacenDestino.DataSource = alm
            Me.cmbAlmacenDestino.DisplayMember = "Descripcion"
            Me.cmbAlmacenDestino.ValueMember = "AlmacenId"

            Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ComboBox"

#End Region

#Region "DataGrid"
    Private Sub DgvCortes_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DgvCortes.PreviewKeyDown
        If Not editando Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            If Me.DgvCortes.SelectedRows.Count > 0 Then
                Dim corte As New EC.MscloteCortesDetEntity

                corte.FetchUsingPK(Me.DgvCortes.SelectedRows(0).Cells(Me.clmLoteCorte.Index).Value.ToString.Trim, _
                                    Me.DgvCortes.SelectedRows(0).Cells(Me.clmEtiqueta.Index).Value.ToString.Trim)

                If corte.Estatus = 1 Then
                    If DBNull.Value.Equals(corte.IdFolioEmbarque) OrElse corte.IdFolioEmbarque.ToString.Trim = "" Then
                        If MessageBox.Show("¿Quiere quitar la caja del traspaso?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            Me.DgvCortes.Rows.RemoveAt(Me.DgvCortes.SelectedRows(0).Index)
                        End If
                    Else
                        MsgBox("La caja esta embarcada, no se puede cancelar el traspaso", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                ElseIf corte.Estatus = ClasesNegocio.EstatusCorte.REPROCESO Then
                    MsgBox("La caja esta reprocesada, no se puede cancelar el traspaso", MsgBoxStyle.Exclamation, "Aviso")
                ElseIf corte.Estatus = ClasesNegocio.EstatusCorte.CANCELADO Then
                    MsgBox("La caja esta cancelada, no se puede cancelar el traspaso", MsgBoxStyle.Exclamation, "Aviso")
                ElseIf corte.Estatus = ClasesNegocio.EstatusCorte.AJUSTE Then
                    MsgBox("La caja esta ajustada, no se puede cancelar el traspaso", MsgBoxStyle.Exclamation, "Aviso")
                End If
            End If
        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnBusquedaEtiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusquedaEtiquetas.Click
        If cmbAlmacenDestino.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el almacen destino", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            Dim busqueda As New FrmBusquedaCortesConEtiqueta(CType(cmbAlmacenDestino.SelectedItem, EC.AlmacenEntity))
            Dim etiquetasAgregadas As New List(Of String)

            busqueda.EstablecerEstatus(True, False, False, False, False)

            For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                etiquetasAgregadas.Add(Me.DgvCortes.Rows(i).Cells(Me.clmEtiqueta.Index).Value.ToString.Trim)
            Next

            busqueda.EtiquetasSelecionadas = etiquetasAgregadas.ToArray

            If busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim etiquetas As New List(Of String)

                For i As Integer = 0 To busqueda.DgvCortes.Rows.Count - 1
                    Dim row As DataGridViewRow = busqueda.DgvCortes.Rows(i)

                    If CBool(row.Cells(busqueda.clmSeleccion.Index).Value) And _
                        Not Array.IndexOf(busqueda.EtiquetasSelecionadas, _
                        row.Cells(busqueda.clmFolioEtiqueta.Index).Value.ToString.Trim) > -1 Then
                        etiquetas.Add(row.Cells(busqueda.clmFolioEtiqueta.Index).Value)
                    End If
                Next

                Me.AgregarCajasAlGrid(etiquetas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnVaciarPistola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaciarPistola.Click
        Try
            'If Me.cmbAlmacenDestino.SelectedIndex = -1 Then
            '    MsgBox("Debe seleccionar un almacén antes de agregar cajas al traspaso", MsgBoxStyle.Exclamation, "Aviso")
            '    Exit Sub
            'End If

            Dim abrirArchivo As New OpenFileDialog

            abrirArchivo.Filter = "Archivos de Texto(Bloc de Notas)*.txt|*.txt"

            If abrirArchivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Update()
                Cursor = Cursors.WaitCursor
                Dim fileContents As String
                Dim etiquetas As New List(Of String)
                Dim etiquetasAgregadas As New List(Of String)
                Dim cajas() As String = Nothing

                For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                    etiquetasAgregadas.Add(Me.DgvCortes.Rows(i).Cells(Me.clmEtiqueta.Index).Value.ToString.Trim)
                Next

                If etiquetasAgregadas.Count > 0 Then
                    cajas = etiquetasAgregadas.ToArray
                End If

                fileContents = My.Computer.FileSystem.ReadAllText(abrirArchivo.FileName)

                For Each folioEtiqueta As String In fileContents.Split(New Char() {Chr(13), Chr(10)})
                    If Not folioEtiqueta.Trim = "" AndAlso (etiquetasAgregadas.Count = 0 OrElse _
                        (etiquetasAgregadas.Count > 0 AndAlso Not Array.IndexOf(cajas, folioEtiqueta.Trim) > -1)) Then
                        etiquetas.Add(folioEtiqueta.Trim)
                    End If
                Next

                If etiquetas.Count > 0 Then
                    Me.AgregarCajasAlGrid(etiquetas)

                    If Me.DgvCortes.Rows.Count > 0 Then
                        'Me.cmbAlmacenDestino.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "TextBox"
    Private Sub txtFolioEtiqueta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioEtiqueta.KeyPress
        Try
            If Not Me.txtFolioEtiqueta.Text.Trim = "" Then
                Dim etiqueta As New List(Of String)

                etiqueta.Add(Me.txtFolioEtiqueta.Text.Trim)

                Me.AgregarCajasAlGrid(etiqueta)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Dim ventana As New frmTraspasoCajasBusqueda

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Update()
                Cursor = Cursors.WaitCursor

                Dim traspaso As New EC.MinvTransferenciaAlmacenProdEntity
                Dim etiquetas As New List(Of String)

                traspaso.FetchUsingPK(ventana.DataGridView1.SelectedRows(0).Cells(ventana.clmFolioTraspaso.Index).Value.ToString.Trim)

                Me.txtFolioTransferencia.Text = traspaso.FolioTransferencia
                Me.txtkilos.Text = traspaso.Kilos.ToString("N2")
                Me.txtPiezas.Text = traspaso.Piezas.ToString("N0")
                Me.dtpFechaTrasoaso.Value = traspaso.FechaMovimiento
                Me.cmbAlmacenDestino.SelectedValue = traspaso.IdAlmacenDestino

                For Each det As EC.MinvTransferenciaAlmacenProdDetalleEntity In traspaso.MinvTransferenciaAlmacenProdDetalle
                    etiquetas.Add(det.FolioEtiqueta.Trim)
                Next

                Me.validarCajas = False
                Me.AgregarCajasAlGrid(etiquetas, True)
                Me.validarCajas = True
                Me.DgvCortes.Enabled = True

            End If
        Catch ex As Exception

        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Deshabilitar()
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        editando = True
        Me.Habilitar()
        Me.cmbAlmacenDestino.Enabled = False
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cursor = Cursors.WaitCursor

        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transferencia")

        Try
            Dim traspaso As New EC.MinvTransferenciaAlmacenProdEntity
            Dim mensajeError As String = ""

            If editando Then
                Dim detalleBD As New CC.MinvTransferenciaAlmacenProdDetalleCollection
                Dim encontro As Boolean
                Dim col As New CC.MscloteCortesDetCollection

                trans.Add(traspaso)

                traspaso.FetchUsingPK(Me.txtFolioTransferencia.Text.Trim)

                trans.Add(detalleBD)

                detalleBD.GetMulti(HC.MinvTransferenciaAlmacenProdDetalleFields.FolioTransferencia = traspaso.FolioTransferencia)

                For Each detDB As EC.MinvTransferenciaAlmacenProdDetalleEntity In detalleBD
                    encontro = False

                    For Each fila As DataGridViewRow In Me.DgvCortes.Rows
                        If fila.Cells(Me.clmEtiqueta.Index).Value.ToString.Trim = detDB.FolioEtiqueta.Trim Then
                            encontro = True
                            Me.DgvCortes.Rows.RemoveAt(fila.Index)
                            Exit For
                        End If
                    Next

                    If Not encontro Then
                        Dim cajaDatosModificados As New EC.MscloteCortesDetEntity
                        Dim folioMovimientoAlmacenEntrada As String = ""
                        Dim folioMovimientoAlmacenSalida As String = ""

                        trans.Add(detDB)

                        If Not Me.AfectarInventario(TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Salida_Traspaso, _
                                    TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Entrada_Traspaso, _
                                    detDB.Kilos, detDB.Piezas, detDB.IdAlmacenOrigen, traspaso.IdAlmacenDestino, _
                                    detDB.IdProducto, trans, folioMovimientoAlmacenEntrada, _
                                    folioMovimientoAlmacenSalida) Then
                            Cancelar = True
                            Exit Sub
                        End If

                        trans.Add(col)

                        col.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = detDB.FolioEtiqueta.Trim)

                        If col.Count > 0 Then
                            With col(0)
                                .IdAlmacenActual = .IdAlmacenOrigen
                                .IdAlmacenOrigen = New System.Nullable(Of Integer)
                                .TipoProducto = .TipoProductoAnterior
                                .TipoProductoAnterior = New System.Nullable(Of Short)
                                .IdFolioMovimiento = folioMovimientoAlmacenEntrada
                            End With

                            col.SaveMulti()
                        End If

                        traspaso.Kilos -= detDB.Kilos
                        traspaso.Piezas -= detDB.Piezas

                        detDB.Delete()
                    End If
                Next

                If Not Me.GuardarGrid(traspaso, trans) Then
                    Cancelar = True
                End If
            Else
                Dim folio As New ClasesNegocio.FoliosClass

                folio.Codigo = ClasesNegocio.CodigodeFolios.TransferenciasAlmacenesProduccion
                folio.Año = Year(Now)
                folio.Mes = Month(Now)

                If Not folio.Guardar(trans) Then
                    trans.Rollback()
                    Cancelar = True
                    MsgBox("No se logro generar el folio de transferencia", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If

                With traspaso
                    .FolioTransferencia = Now.ToString("yyyyMMdd") & folio.Consecutivo.ToString("0000")
                    .IdAlmacenDestino = Me.cmbAlmacenDestino.SelectedValue
                    .FechaMovimiento = Me.dtpFechaTrasoaso.Value
                    .Estatus = 1
                End With

                If Not Me.GuardarGrid(traspaso, trans) Then
                    Cancelar = True
                    Exit Sub
                End If
            End If

            trans.Commit()

            MsgBox("Traspaso Al Almacén " & TryCast(Me.cmbAlmacenDestino.SelectedItem, EC.AlmacenEntity).Descripcion & _
                    " Realizado con el folio de traspaso " & traspaso.FolioTransferencia, MsgBoxStyle.Information, "Aviso")

            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            Cancelar = True
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Habilitar()
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region
#End Region

#Region "Estructuras"
    Private Structure EtiquetasNoValidas
        Public idFolioEtiqueta As String
        Public idMotivo As String
        Public idProducto As Integer
        Public Producto As String
        Public CodigoBarras As String

        Sub New(ByVal idFolioEtiqueta As String, ByVal idMotivo As String, ByVal idProducto As Integer, ByVal Producto As String, ByVal codigoBarras As String)
            Me.idFolioEtiqueta = idFolioEtiqueta
            Me.idMotivo = idMotivo
            Me.idProducto = idProducto
            Me.Producto = Producto
            Me.CodigoBarras = codigoBarras
        End Sub
    End Structure
#End Region

#Region "Clases"

#End Region
End Class