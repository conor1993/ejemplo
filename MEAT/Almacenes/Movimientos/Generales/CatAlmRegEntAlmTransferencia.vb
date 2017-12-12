Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = sd.LLBLGen.Pro.ORMSupportClasses

Public Class CatAlmRegEntAlmTransferencia

#Region "Miembros"
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Private WithEvents transferencia As ClasesNegocio.TransferenciaAlmacenEntradaClass
#End Region

#Region "Metodos"
    Private Sub LIMPIAR()
        CmbPlaza.SelectedValue = "Seleccione Plaza"
        Me.mtxtFolioSalida.Clear()
        TxtFolioEntrada.Clear()
        DTPFecha.Value = Now
        TxtAlmOrigen.Clear()
        TxtAlmDest.Clear()
        TxtEntrega.Clear()
        TxtRecibe.Clear()
        TxtTotal.Clear()
        TxtObservaciones.Clear()
        lblEstatus.Text = "ESTATUS"
        Me.DataGrid.Rows.Clear()
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub DESHABILITAR()
        CmbPlaza.Enabled = False
        mtxtFolioSalida.Enabled = False
        TxtFolioEntrada.Enabled = False
        DTPFecha.Enabled = False
        TxtAlmOrigen.Enabled = False
        TxtAlmDest.Enabled = False
        TxtEntrega.Enabled = False
        TxtRecibe.Enabled = False
        TxtTotal.Enabled = False
        TxtObservaciones.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub HABILITAR()
        CmbPlaza.Enabled = True
        mtxtFolioSalida.Enabled = True
        TxtFolioEntrada.Enabled = False
        DTPFecha.Enabled = True
        TxtAlmOrigen.Enabled = True
        TxtAlmDest.Enabled = True
        TxtEntrega.Enabled = True
        TxtRecibe.Enabled = True
        TxtTotal.Enabled = True
        TxtObservaciones.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub AgregarDatosDeTransferenciaSalida()
        Me.TxtAlmDest.Text = Me.transferencia.AlmacenDestino.Descripcion
        Me.TxtAlmOrigen.Text = Me.transferencia.AlmacenOrigen.Descripcion
        Me.TxtEntrega.Text = Me.transferencia.Entrega
        Me.TxtTotal.Text = Me.transferencia.Importe.ToString("C2")

        Me.DataGrid.Rows.Clear()

        For Each det As TransferenciaAlmacenSalidaDetalleClass In Me.transferencia.TransferenciaSalida.Detalle
            Me.DataGrid.Rows.Add(1)

            With Me.DataGrid.Rows(Me.DataGrid.Rows.Count - 1)
                .Cells(Me.clmCodigo.Index).Value = det.IdProducto
                .Cells(Me.clmProducto.Index).Value = det.Producto.Descripcion
                .Cells(Me.clmUnidadMedida.Index).Value = det.Producto.UnidadMedida.Descripcion
                .Cells(Me.clmCantidad.Index).Value = det.Cantidad
                .Cells(Me.clmCosto.Index).Value = det.CostoUnitario
                .Cells(Me.clmImporte.Index).Value = det.Importe
                .Cells(Me.clmLote.Index).Value = det.Lote
                .Cells(Me.clmFechaCaducidad.Index).Value = det.FechaCaducidad.GetValueOrDefault(#1/1/1900#)
            End With
        Next
    End Sub

    Private Sub ObtenerDatos()
        With Me.transferencia
            .Recibe = Me.TxtRecibe.Text.Trim
            .Entrega = Me.TxtEntrega.Text.Trim
            .FechaMovimiento = Me.DTPFecha.Value
            .IdUsuarioAlta = Controlador.Sesion.Usrndx

            .MovimientoAlmacen.IdAlmacen = .IdAlmacenDestino
            .MovimientoAlmacen.FechaMovimiento = .FechaMovimiento
            .MovimientoAlmacen.TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Traspaso
            .MovimientoAlmacen.IdUsuarioAlta = .IdUsuarioAlta
            .MovimientoAlmacen.PolizaContabilidad = 0
            .MovimientoAlmacen.Referencia = ""

            .MovimientoAlmacen.Detalle.Clear()
            .Detalle.Clear()

            For Each row As DataGridViewRow In Me.DataGrid.Rows
                .Detalle.Add(Me.transferencia, CInt(row.Cells(Me.clmCodigo.Index).Value), _
                            IIf(IsNothing(row.Cells(Me.clmLote.Index).Value), " ", row.Cells(Me.clmLote.Index).Value), CDec(row.Cells(Me.clmCantidad.Index).Value), _
                            CDec(row.Cells(Me.clmImporte.Index).Value), CDec(row.Cells(Me.clmCosto.Index).Value), _
                            CDec(row.Cells(Me.clmIva.Index).Value))
                .MovimientoAlmacen.Detalle.Add(.MovimientoAlmacen, .MovimientoAlmacen.Detalle.Count + 1, _
                                CInt(row.Cells(Me.clmCodigo.Index).Value), .FechaMovimiento, _
                                CDec(row.Cells(Me.clmCantidad.Index).Value), _
                                CDec(row.Cells(Me.clmCosto.Index).Value), 0D, _
                                IIf(IsNothing(row.Cells(Me.clmLote.Index).Value), " ", _
                                row.Cells(Me.clmLote.Index).Value), _
                                IIf(CType(row.Cells(Me.clmFechaCaducidad.Index).Value, Date) = #1/1/1900#, New Nullable(Of Date), _
                                row.Cells(Me.clmFechaCaducidad.Index).Value))
            Next

            .Observaciones = Me.TxtObservaciones.Text.Trim
        End With
    End Sub

    Private Sub PonerDatos()
        Me.TxtFolioEntrada.Text = Me.transferencia.FolioTranferencia
        Me.TxtAlmDest.Text = Me.transferencia.AlmacenDestino.Descripcion
        Me.TxtAlmOrigen.Text = Me.transferencia.AlmacenOrigen.Descripcion
        Me.TxtEntrega.Text = Me.transferencia.Entrega
        Me.TxtTotal.Text = Me.transferencia.Importe.ToString("C2")
        Me.TxtRecibe.Text = Me.transferencia.Recibe
        Me.mtxtFolioSalida.Text = Me.transferencia.FolioTranferenciaSalida
        Me.mtxtFolioSalida.Enabled = False
        Me.TxtObservaciones.Text = Me.transferencia.Observaciones
        Me.lblEstatus.Visible = True
        Me.lblEstatus.Text = Me.transferencia.Estatus.ToString

        Me.DataGrid.Rows.Clear()
        Me.DataGrid.Rows.Add(Me.transferencia.Detalle.Count)
        Dim fila As Integer = 0

        For Each det As TransferenciaAlmacenEntradaDetalleClass In Me.transferencia.Detalle
            With Me.DataGrid.Rows(fila)
                .Cells(Me.clmCodigo.Index).Value = det.IdProducto
                .Cells(Me.clmProducto.Index).Value = det.Producto.Descripcion
                .Cells(Me.clmUnidadMedida.Index).Value = det.Producto.UnidadMedida.Descripcion
                .Cells(Me.clmCantidad.Index).Value = det.Cantidad
                .Cells(Me.clmCosto.Index).Value = det.CostoUnitario
                .Cells(Me.clmImporte.Index).Value = det.Importe
                .Cells(Me.clmLote.Index).Value = det.Lote
            End With

            fila += 1
        Next
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub CatAlmRegEntAlmTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010000"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            DESHABILITAR()
            LIMPIAR()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al abrir la ventana", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Me.transferencia.Estatus = TransferenciaAlmacenEntradaClass.EstatusTransferenciaEntrada.CANCELADA Then
                MsgBox("La transferencia ya esta cancelada", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
            Else
                If MessageBox.Show("¿Quiere cancelar la entrada por transferencia?", _
                        "Cancelar Transferencia", MessageBoxButtons.YesNo, _
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = _
                        Windows.Forms.DialogResult.No Then
                    Cancelar = True
                    Exit Sub
                End If

                Me.transferencia.IdUsuarioCancelacion = Controlador.Sesion.Usrndx
                Me.transferencia.FechaCancelacion = Now

                If Me.transferencia.Borrar Then
                    MsgBox("Se a cancelado la entrada por transferencia", MsgBoxStyle.Information, "Aviso")
                    LIMPIAR()
                    Me.DESHABILITAR()
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al realizar la cancelación", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim ventana As New frmBusquedaTransferenciaEntrada

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.transferencia = ventana.TransferenciaSeleccionada
                Me.PonerDatos()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        Try
            LIMPIAR()
            DESHABILITAR()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al limpiar los datos de la ventana y deshabilitar los controles", _
                    MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al habilitar los controles para su edición", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Me.ObtenerDatos()

            If Me.transferencia.Guardar Then
                Me.LIMPIAR()
                Me.DESHABILITAR()
                MsgBox("Se guardo la transferencia con el folio : " & _
                        Me.transferencia.FolioTranferencia.Trim, MsgBoxStyle.Information, "Aviso")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se guardaba la información", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Try
            If Me.selesccionado Then
                LIMPIAR()
            Else
                LIMPIAR()
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se inicializaban los valores de la ventana", _
                    MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Try
            LIMPIAR()
            HABILITAR()
            Editar = False
            Me.transferencia = New TransferenciaAlmacenEntradaClass
            Me.lblEstatus.Visible = False
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se inicializaban los valores", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "TextBox"
    Private Sub TxtAlmOrigen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAlmOrigen.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtAlmDest.Focus()
            If TxtAlmOrigen.Text = "" Then
                MsgBox("Agregue Información a Almacen Origen ")
                TxtAlmOrigen.Focus()
            End If
        End If
    End Sub

    Private Sub TxtAlmDest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAlmDest.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtEntrega.Focus()
            If TxtAlmDest.Text = "" Then
                MsgBox("Agregue Información a Almacen Destino ")
                TxtAlmDest.Focus()
            End If
        End If
    End Sub

    Private Sub TxtEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEntrega.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtRecibe.Focus()
            If TxtEntrega.Text = "" Then
                MsgBox("Agregue Información a Entrega")
                TxtEntrega.Focus()
            End If
        End If
    End Sub

    Private Sub TxtRecibe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRecibe.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtObservaciones.Focus()
            If TxtRecibe.Text = "" Then
                MsgBox("Agregue Información a Recibe")
                TxtRecibe.Focus()
            End If
        End If
    End Sub
#End Region

#Region "DataGrid"
    Private Sub TxtFolSalida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFolioEntrada.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            DTPFecha.Focus()
            If TxtFolioEntrada.Text = "" Then
                MsgBox("Agregue Información a Folio Salida ")
                TxtFolioEntrada.Focus()
            End If
        End If
    End Sub
#End Region

#Region "ComboBox"
    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPlaza.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)

            If CmbPlaza.Text = "" Then
                MsgBox("Seleccione una Plaza")
                CmbPlaza.Focus()
            End If
        End If
    End Sub
#End Region

#Region "DateTimePiker"
    Private Sub DTPFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtAlmOrigen.Focus()
        End If
    End Sub
#End Region

#Region "MaskTextBox"
    Private Sub mtxtFolioSalida_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtxtFolioSalida.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.transferencia = New TransferenciaAlmacenEntradaClass
            If Me.transferencia.Obtener(Me.mtxtFolioSalida.Text) Then
                Me.ObtenerDatos()
            Else
                MsgBox("No exite una salida por transferencia con este folio", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub mtxtFolioSalida_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles mtxtFolioSalida.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Dim ventana As New frmBusquedaTransferenciaAlmacenSalida

            ventana.chkCanceladas.Checked = False
            ventana.chkRecibidas.Checked = False
            ventana.chkRecibidas.Enabled = False
            ventana.chkCanceladas.Enabled = False
            ventana.ReiniciarEstatus = False
            ventana.chkEnTransito.Enabled = False

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.LIMPIAR()
                Me.mtxtFolioSalida.Text = ventana.TransferenciaSeleccionada.FolioTransferencia.Trim
                Me.transferencia.TransferenciaSalida = ventana.TransferenciaSeleccionada
                Me.transferencia.Importe = Me.transferencia.TransferenciaSalida.Importe
                Me.transferencia.TotalProductos = Me.transferencia.TransferenciaSalida.TotalProductos

                With Me.transferencia
                    .AlmacenDestino = .TransferenciaSalida.AlmacenDestino
                    .AlmacenOrigen = .TransferenciaSalida.AlmacenOrigen
                    .Entrega = .TransferenciaSalida.Recibe
                End With

                Me.AgregarDatosDeTransferenciaSalida()
            End If
        End If
    End Sub
#End Region
#End Region
End Class