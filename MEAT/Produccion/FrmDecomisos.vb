Imports ClasesNegocio
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FrmDecomisos

    Dim WithEvents RegistroSacrificiosCab As New RegistroSacrificiosClass
    Dim Sacrificio As New CN.RegistroSacrificioColeccionClass
    Dim OrdenProductos As New OC.SortExpression(New SD.LLBLGen.Pro.ORMSupportClasses.SortClause(HC.MsccatProductosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
    Dim Productos As New CN.ProductosCollectionsClass
    Dim Motivos As New MotivosDecomisoCollectionClass
    Dim UltimaTeclaProducto As Date
    Dim DecomisosCol As New DecomisosColeccionClass

    Private Sub FrmDecomisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
    End Sub

#Region "Metodos"
    Private Sub ObtenerSacrificios(ByVal Opcion As Integer)
        Sacrificio = New RegistroSacrificioColeccionClass

        If Opcion = 1 Then
            Sacrificio.Obtener(Me.RegistroSacrificiosCab.IdLoteSacrificio, Me.RegistroSacrificiosCab.Introductor)

            If Sacrificio.Count = 0 Then
                MessageBox.Show("Este lote de sacrifcio no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            Sacrificio.Obtener("A")

            If Sacrificio.Count = 0 Then
                MessageBox.Show("No existen lotes de sacrificios en apertura", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        For Each Sacrif As RegistroSacrificiosClass In Sacrificio
            Me.txtLoteSacrificio.Text = Sacrif.IdLoteSacrificio
            Me.dtpFechaSacrificio.Text = Sacrif.FechaSacrificio
            'TotalCabezasSacrifcar = Sacrif.CantCabezasSacrificio
            Me.txtProductor.Text = Sacrif.NombreIntroductor
            ' Me.txtCantCanales.Text = Sacrif.CantCanales
            ' CodCliente = Sacrif.Introductor
        Next
    End Sub

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            Dim configuracionMovimientosAlmacenes As New CC.MscconfigMovtosAlmacenCollection
            Dim configuracionMovimientosAlmacen As EC.MscconfigMovtosAlmacenEntity
            Dim idAlmacenDecomisos As Integer
            Dim ConfigProduccion As New CC.UsrProdConfiguracionCollection
            Dim decomiso As New EC.UsrProdRegistroSacrificiosDecomisoEntity

            configuracionMovimientosAlmacenes.GetMulti(Nothing, 1, New SD.LLBLGen.Pro.ORMSupportClasses.SortExpression(New SD.LLBLGen.Pro.ORMSupportClasses.SortClause(HC.MscconfigMovtosAlmacenFields.IdConfiguracion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            If configuracionMovimientosAlmacenes.Count > 0 Then
                configuracionMovimientosAlmacen = configuracionMovimientosAlmacenes(0)

                Select Case -1
                    Case configuracionMovimientosAlmacen.EntradaProductoXdecomiso.GetValueOrDefault(-1)
                        MsgBox("No tiene configuradas las entradas de producto por decomiso en la configuración de movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    Case configuracionMovimientosAlmacen.SalidaProductoXcancelacionDecomiso.GetValueOrDefault(-1)
                        MsgBox("No tiene configuradas la salida de producto por la cancelación de decomiso en la configuración de movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                End Select
            Else
                MsgBox("Configure los movimientos de Almacén producción para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'Obtener la Configuracion 
            ConfigProduccion.GetMulti(Nothing)

            If Not ConfigProduccion.Count > 0 Then
                Trans.Rollback()
                MessageBox.Show("Seleccione un Almacen para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            Else
                idAlmacenDecomisos = ConfigProduccion(0).IdAlmacenDecomisos
            End If

            If Not decomiso.FetchUsingPK(Me.txtLoteSacrificio.Text, Me.cmbProductos.SelectedValue, Me.CmbMotivoDecomiso.SelectedValue) Then
                Dim Movimiento As New ClasesNegocio.MovimientoAlmacenClass

                Movimiento.IdAlmacen = idAlmacenDecomisos
                Movimiento.FechaMovimiento = Me.dtpFechaSacrificio.Value
                Movimiento.FechaCaptura = Now
                Movimiento.IdTipoMovimiento = configuracionMovimientosAlmacen.EntradaProductoXdecomiso
                Movimiento.Kilos = CDec(Me.txtPeso.Text)
                Movimiento.Piezas = CInt(Me.txtPiezas.Text)
                Movimiento.Estatus = EstatusChar.VIGENTE
                Movimiento.IdPoliza = ""
                Movimiento.QuienCancelo = ""
                Movimiento.QuienContabilizo = ""
                Movimiento.ObservacionCancela = ""

                Movimiento.AgregarDetalle(Me.cmbProductos.SelectedValue, CDec(Me.txtPeso.Text), CInt(Me.txtPiezas.Text), 0D, 0D)

                'al momento de guardar se genera el folio de movimeinto y se afecta el inventario del producto
                Movimiento.Guardar(Trans)

                Trans.Add(decomiso)

                'guarda el detalle
                decomiso.FolioSacrificio = Me.txtLoteSacrificio.Text
                decomiso.IdProducto = Me.cmbProductos.SelectedValue
                decomiso.Piezas = CInt(Me.txtPiezas.Text)
                decomiso.Kilos = CDec(Me.txtPeso.Text)
                decomiso.FolioMovAlmacen = Movimiento.FolioMovimiento
                decomiso.Estatus = 1
                decomiso.IdDecomiso = Me.CmbMotivoDecomiso.SelectedValue

                decomiso.Save()
            ElseIf MessageBox.Show("El producto ya tiene registrado un decomiso, si guarda el decomiso los datos del decomiso anterior seran sustituidos por los nuevos. ¿Quiere guardar el decomiso?", "Modificar Decomiso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Dim MovimientoSalida As New ClasesNegocio.MovimientoAlmacenClass
                Dim MovimientoEntrada As New ClasesNegocio.MovimientoAlmacenClass

                MovimientoSalida.IdAlmacen = idAlmacenDecomisos
                MovimientoSalida.FechaMovimiento = Me.dtpFechaSacrificio.Value
                MovimientoSalida.FechaCaptura = Now
                MovimientoSalida.IdTipoMovimiento = configuracionMovimientosAlmacen.SalidaProductoXcancelacionDecomiso
                MovimientoSalida.Kilos = decomiso.Kilos
                MovimientoSalida.Piezas = decomiso.Piezas
                MovimientoSalida.Estatus = EstatusChar.VIGENTE
                MovimientoSalida.IdPoliza = ""
                MovimientoSalida.QuienCancelo = ""
                MovimientoSalida.QuienContabilizo = ""
                MovimientoSalida.ObservacionCancela = ""
                MovimientoSalida.FolioMovmientoReferencia = decomiso.FolioMovAlmacen

                MovimientoSalida.AgregarDetalle(Me.cmbProductos.SelectedValue, decomiso.Kilos, decomiso.Piezas, 0D, 0D)

                'al momento de guardar se genera el folio de movimeinto y se afecta el inventario del producto
                MovimientoSalida.Guardar(Trans)

                MovimientoEntrada.IdAlmacen = idAlmacenDecomisos
                MovimientoEntrada.FechaMovimiento = Me.dtpFechaSacrificio.Value
                MovimientoEntrada.FechaCaptura = Now
                MovimientoEntrada.IdTipoMovimiento = configuracionMovimientosAlmacen.EntradaProductoXdecomiso
                MovimientoEntrada.Kilos = CDec(Me.txtPeso.Text)
                MovimientoEntrada.Piezas = CInt(Me.txtPiezas.Text)
                MovimientoEntrada.Estatus = EstatusChar.VIGENTE
                MovimientoEntrada.IdPoliza = ""
                MovimientoEntrada.QuienCancelo = ""
                MovimientoEntrada.QuienContabilizo = ""
                MovimientoEntrada.ObservacionCancela = ""

                MovimientoEntrada.AgregarDetalle(Me.cmbProductos.SelectedValue, CDec(Me.txtPeso.Text), CInt(Me.txtPiezas.Text), 0D, 0D)

                'al momento de guardar se genera el folio de movimeinto y se afecta el inventario del producto
                MovimientoEntrada.Guardar(Trans)

                Trans.Add(decomiso)

                'guarda el detalle
                'decomiso.FolioSacrificio = Me.txtLoteSacrificio.Text
                'decomiso.IdProducto = Me.cmbProductos.SelectedValue
                decomiso.Piezas = CInt(Me.txtPiezas.Text)
                decomiso.Kilos = CDec(Me.txtPeso.Text)
                decomiso.FolioCancelAlmacen = MovimientoSalida.FolioMovimiento
                decomiso.FolioMovAlmacen = MovimientoEntrada.FolioMovimiento
                decomiso.Estatus = 1
                decomiso.IdDecomiso = Me.CmbMotivoDecomiso.SelectedValue

                decomiso.Save()
            Else
                Trans.Rollback()
                Return False
            End If

            Trans.Commit()

            Me.ObtenerDecomisos(Me.txtLoteSacrificio.Text.Trim)

            Me.txtPiezas.Text = 0
            Me.txtPeso.Text = 0
            Me.cmbProductos.SelectedIndex = -1
            Me.cmbProductos.Text = "Seleccione un producto"
            Me.CmbMotivoDecomiso.SelectedIndex = -1
            Me.CmbMotivoDecomiso.Text = "Seleccione un motivo de decomiso"
            Me.cmbProductos.Focus()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Borrar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            Dim configuracionMovimientosAlmacenes As New CC.MscconfigMovtosAlmacenCollection
            Dim configuracionMovimientosAlmacen As EC.MscconfigMovtosAlmacenEntity
            Dim idAlmacenDecomisos As Integer
            Dim ConfigProduccion As New CC.UsrProdConfiguracionCollection
            Dim decomiso As New EC.UsrProdRegistroSacrificiosDecomisoEntity

            configuracionMovimientosAlmacenes.GetMulti(Nothing, 1, New SD.LLBLGen.Pro.ORMSupportClasses.SortExpression(New SD.LLBLGen.Pro.ORMSupportClasses.SortClause(HC.MscconfigMovtosAlmacenFields.IdConfiguracion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            If configuracionMovimientosAlmacenes.Count > 0 Then
                configuracionMovimientosAlmacen = configuracionMovimientosAlmacenes(0)

                Select Case -1
                    Case configuracionMovimientosAlmacen.EntradaProductoXdecomiso.GetValueOrDefault(-1)
                        MsgBox("No tiene configuradas las entradas por decomiso en la configuración de movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    Case configuracionMovimientosAlmacen.SalidaProductoXcancelacionDecomiso.GetValueOrDefault(-1)
                        MsgBox("No tiene configuradas la cancelación de entradas por decomiso en la configuración de movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                End Select
            Else
                MsgBox("Configure los movimientos de Almacén producción para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'Obtener la Configuracion 
            ConfigProduccion.GetMulti(Nothing)

            If Not ConfigProduccion.Count > 0 Then
                Trans.Rollback()
                MessageBox.Show("Seleccione un Almacen para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            Else
                idAlmacenDecomisos = ConfigProduccion(0).IdAlmacenDecomisos
            End If

            If decomiso.FetchUsingPK(Me.dgvDecomisos.SelectedRows(0).Cells(Me.Codigo.Index).Value, DirectCast(Me.dgvDecomisos.DataSource, DataTable).Rows(Me.dgvDecomisos.SelectedRows(0).Index)("IdProducto"), Me.dgvDecomisos.SelectedRows(0).Cells(Me.clmIdMotivoDecomiso.Index).Value) Then
                Dim MovimientoSalida As New ClasesNegocio.MovimientoAlmacenClass

                MovimientoSalida.IdAlmacen = idAlmacenDecomisos
                MovimientoSalida.FechaMovimiento = Me.dtpFechaSacrificio.Value
                MovimientoSalida.FechaCaptura = Now
                MovimientoSalida.IdTipoMovimiento = configuracionMovimientosAlmacen.SalidaProductoXcancelacionDecomiso
                MovimientoSalida.Kilos = decomiso.Kilos
                MovimientoSalida.Piezas = decomiso.Piezas
                MovimientoSalida.Estatus = EstatusChar.VIGENTE
                MovimientoSalida.IdPoliza = ""
                MovimientoSalida.QuienCancelo = ""
                MovimientoSalida.QuienContabilizo = ""
                MovimientoSalida.ObservacionCancela = ""
                MovimientoSalida.FolioMovmientoReferencia = decomiso.FolioMovAlmacen

                MovimientoSalida.AgregarDetalle(decomiso.IdProducto, decomiso.Kilos, decomiso.Piezas, 0D, 0D)
                'al momento de guardar se genera el folio de movimeinto y se afecta el inventario del producto
                MovimientoSalida.Guardar(Trans)

                Trans.Add(decomiso)

                decomiso.Delete()
            End If

            Trans.Commit()

            Me.ObtenerDecomisos(Me.txtLoteSacrificio.Text.Trim)

            Me.txtPiezas.Text = 0
            Me.txtPeso.Text = 0
            Me.cmbProductos.SelectedIndex = -1
            Me.cmbProductos.Text = "Seleccione un producto"
            Me.CmbMotivoDecomiso.SelectedIndex = -1
            Me.CmbMotivoDecomiso.Text = "Seleccione un motivo de decomiso"
            Me.cmbProductos.Focus()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub ObtenerDecomisos(ByVal folioSacrificio As String)
        Try
            Dim tb As New DataTable
            Dim consulta As String

            consulta = "SELECT      UsrProdRegistroSacrificiosDecomiso.FolioSacrificio, UsrProdRegistroSacrificiosDecomiso.Piezas, " & _
                       "            UsrProdRegistroSacrificiosDecomiso.Kilos, MSCCatProductos.Descripcion AS Producto, " & _
                       "            MSCCatDecomisos.Descripcion AS [Motivo Decomiso],UsrProdRegistroSacrificiosDecomiso.IdProducto, " & _
                       "            UsrProdRegistroSacrificiosDecomiso.IdDecomiso " & _
                       "FROM        UsrProdRegistroSacrificiosDecomiso INNER JOIN " & _
                       "            MSCCatProductos ON UsrProdRegistroSacrificiosDecomiso.IdProducto = MSCCatProductos.IdProducto INNER JOIN " & _
                       "            MSCCatDecomisos ON UsrProdRegistroSacrificiosDecomiso.IdDecomiso = MSCCatDecomisos.IdDecomiso " & _
                       "WHERE       UsrProdRegistroSacrificiosDecomiso.FolioSacrificio='" & folioSacrificio.Trim & "'"

            Using ad As New SqlDataAdapter(New SqlCommand(consulta, New SqlConnection(HC.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()

                ad.Fill(tb)

                ad.SelectCommand.Connection.Close()
            End Using

            Me.dgvDecomisos.AutoGenerateColumns = False
            Me.dgvDecomisos.DataSource = tb

            Dim piezas As Decimal = 0D
            Dim kilos As Decimal = 0D

            For Each decom As ClasesNegocio.DecomisosClass In Me.DecomisosCol
                piezas += decom.Piezas
                kilos += decom.Kilos
            Next

            Me.txtTotalPiezas.Text = piezas
            Me.txtTotalKilos.Text = kilos
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtPeso.Text = 0
        Me.txtLoteSacrificio.Clear()
        Me.txtPiezas.Text = 0
        Me.txtProductor.Clear()
        Me.cmbProductos.SelectedIndex = -1
        Me.CmbMotivoDecomiso.SelectedIndex = -1
    End Sub

    Private Sub Habilitar()
        Me.txtPiezas.Enabled = True
        Me.txtProductor.Enabled = True
        Me.cmbProductos.Enabled = True
        Me.CmbMotivoDecomiso.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtPiezas.Enabled = False
        Me.txtProductor.Enabled = False
        Me.cmbProductos.Enabled = False
        Me.CmbMotivoDecomiso.Enabled = False
    End Sub

    Private Sub ObtenerValores()
        'Me.txtLoteSacrificio.Text = Decomisos.LoteSacrificio
        'Me.txtProductor.Text = Decomisos.Sacrificio.NombreIntroductor
        'Me.dtpFechaSacrificio.Value = Decomisos.Sacrificio.FechaSacrificio
        'Me.cmbProductos.SelectedValue = Decomisos.IdProducto
        'Me.CmbMotivoDecomiso.SelectedValue = Decomisos.MotivoDecomiso
        'Me.txtPiezas.Text = Decomisos.Piezas
        'Me.txtPeso.Text = Decomisos.Kilos
        Deshabilitar()
    End Sub

    Private Function Buscar() As Boolean
        'Dim ventana As New FrmConDecomisos
        'If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Me.Decomisos = ventana.DgvDecomisos.SelectedRows(0).DataBoundItem
        '    ObtenerValores()
        'End If
        Try
            If Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos Then
                Dim Consultas As New ReporteRegistroSacrificios

                Consultas.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE DECOMISOS"
                Consultas.Label17.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE DECOMISOS"

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.RegistroSacrificiosCab = Consultas.Sacrificio

                Else
                    Me.Close()

                End If

                Me.Limpiar()
                ObtenerSacrificios(1)
            Else
                Me.Limpiar()
                ObtenerSacrificios(2)
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Function Imprimir() As Boolean
    End Function

    Private Sub ObtenerPesoBascula()
        If Not Me.SerialPort.IsOpen Then
            Me.SerialPort.Open()
            If Me.SerialPort.CDHolding Then
                If Me.SerialPort.NewLine = "" Then
                    MsgBox("No es posible leer el Peso, Favor de Capturarlo...", MsgBoxStyle.Information, "Aviso")
                    Me.txtPeso.Enabled = True
                Else
                    Dim kilos As String = Me.SerialPort.NewLine
                    Me.txtPeso.Text = CDec(kilos).ToString("C2")
                    Me.SerialPort.Close()
                End If
            Else
                MsgBox("La Báscula no se encuentra conectada...")
                Me.txtPeso.Enabled = True
                Me.txtPeso.Focus()
            End If
            Me.SerialPort.Close()
        End If
    End Sub

    'Private Function CancelarCanal() As Boolean
    '    Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
    '    Try
    '        'guarda el detalle
    '        Decomisos.LoteSacrificio = Me.txtLoteSacrificio.Text
    '        Decomisos.IdProducto = Me.cmbProductos.SelectedValue
    '        Decomisos.Piezas = Me.txtPiezas.Text
    '        Decomisos.Kilos = Me.txtPeso.Text
    '        'If Me.optDecomiso.Checked = True Then
    '        '    Decomisos.Decomiso = True
    '        'Else
    '        '    Decomisos.Decomiso = False
    '        'End If
    '        Decomisos.Func = "M"
    '        Decomisos.NumOpc = 1
    '        If Not Decomisos.Guardar(Trans) Then
    '            Trans.Rollback()
    '            Return False
    '        End If

    '        Trans.Commit()
    '        Return True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Trans.Rollback()
    '        Return False
    '    End Try
    'End Function
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If Not Guardar() Then
            Cancelar = True
            'MessageBox.Show("No se pudo guardar tipo de corral", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Se guardo decomios o subproducto ", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Limpiar()
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub txtPiezas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPiezas.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Controlador.Configuracion.Produccion.ObtenerPeso Then
                Me.txtPeso.Enabled = True
                MsgBox("Teclee el Peso...")
                Me.txtPeso.Focus()
            Else
                ObtenerPesoBascula()
            End If
            If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.Guardar() Then
                MsgBox("Se a guardado el decomiso", MsgBoxStyle.Information, "Decomiso Guardado")
            End If
        End If

        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbProductos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProductos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TmProducto.Stop()
            Me.UltimaTeclaProducto = Now
            Me.TmProducto.Start()
            'Me.txtPiezas.Focus()
        End If
    End Sub

    Private Sub CmbMotivoDecomiso_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbMotivoDecomiso.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Motivos.Obtener(CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub CmbMotivoDecomiso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMotivoDecomiso.SelectedIndexChanged
        'If Me.CmbMotivoDecomiso.SelectedIndex > -1 Then
        '    Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
        '    ObtenerPeso.Obtener()
        '    If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = False Then
        '        Me.txtPeso.Enabled = True
        '        MsgBox("Teclee el Peso...")
        '    End If
        'End If
    End Sub

    Private Sub BtnBascula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBascula.Click
        ObtenerPesoBascula()
    End Sub

    Private Sub cmbProductos_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProductos.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Productos.Obtener(True, CondicionEstatusEnum.ACTIVO, OrdenProductos)
        End If
    End Sub

    Private Sub dgvDecomisos_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvDecomisos.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("¿Quiere borrar el decomiso?", "Borrar Decomiso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then Me.Borrar()
        End If
    End Sub

    Private Sub FrmDecomisos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos Then
                Dim Consultas As New ReporteRegistroSacrificios

                Consultas.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE DECOMISOS"
                Consultas.Label17.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE DECOMISOS"

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.RegistroSacrificiosCab = Consultas.Sacrificio

                Else
                    Me.Close()
                End If

                Me.Limpiar()
                ObtenerSacrificios(1)
            Else
                Me.Limpiar()
                ObtenerSacrificios(2)
            End If


            Productos.Obtener(True, CondicionEstatusEnum.ACTIVO, OrdenProductos)
            Me.cmbProductos.DataSource = Productos
            Me.cmbProductos.ValueMember = "IdProducto"
            Me.cmbProductos.DisplayMember = "Descripcion"
            Me.cmbProductos.SelectedIndex = -1
            Me.ObtenerDecomisos(Me.txtLoteSacrificio.Text.Trim)
            Motivos.Obtener(CondicionEnum.ACTIVOS)
            Me.CmbMotivoDecomiso.ValueMember = "IdDecomiso"
            Me.CmbMotivoDecomiso.DataSource = Motivos
            Me.CmbMotivoDecomiso.DisplayMember = "Descripcion"
            Me.CmbMotivoDecomiso.SelectedIndex = -1

            ' Habilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class