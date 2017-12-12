Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Public Class frmOtrasEntradasProduccion

#Region "Miembros"
    Private productos As New DataTable
    Private seleccionar As Boolean = False
#End Region

#Region "Metodos"
    Private Sub ObtenerProductos()
        Try
            Dim consulta As String = "SELECT [IdProducto],[Descripcion],Canal,Corte,SubProducto,PreCorte FROM [dbo].[MSCCatProductos] WHERE IdProducto=1"

            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
                        New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()
                ad.Fill(productos)
                ad.SelectCommand.Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Limpiar()
        Try
            For Each control As Control In Me.Controls
                Dim tipo As String = control.GetType.ToString

                Select Case tipo
                    Case "System.Windows.Forms.TextBox"
                        DirectCast(control, System.Windows.Forms.TextBox).Clear()
                    Case "IntegraLab.Controles.TextBoxMejorado"
                        DirectCast(control, IntegraLab.Controles.TextBoxMejorado).Clear()
                    Case "IntegraLab.Controles.ComboBoxMejorado"
                        Dim combo As IntegraLab.Controles.ComboBoxMejorado = DirectCast(control, IntegraLab.Controles.ComboBoxMejorado)

                        combo.SelectedIndex = -1
                        combo.Text = combo.Tag
                    Case "System.Windows.Forms.DateTimePicker"
                        DirectCast(control, DateTimePicker).Value = Now
                End Select
            Next

            Me.CapturaInventarioC.Clear()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al limpiar los controles", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub Habilitar()
        Try
            For Each control As Control In Me.Controls
                control.Enabled = True
            Next
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al habilitar los controles", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub Deshabilitar()
        Try
            For Each control As Control In Me.Controls
                If Not control.GetType.ToString = "System.Windows.Forms.Label" Then
                    control.Enabled = False
                End If
            Next

            Me.lblTitulo.Enabled = True
            Me.mtb.Enabled = True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al deshabilitar los controles", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmOtrasEntradasProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "010101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010000"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Me.AlmacenC.ObtenerDeProduccion()
            Me.TipoMovimientoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, ClasesNegocio.CondicionDireccionEnum.ENTRADAS)
            Me.ProductosC.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.Deshabilitar()
            Limpiar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al iniciar la ventana", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub txtEntregarA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtRecibe.Focus()
        End If
    End Sub

    Private Sub txtRecibe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub DgvProductos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProductos.CellEndEdit
        Me.seleccionar = False
    End Sub

    Private Sub DgvProductos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvProductos.EditingControlShowing
        If Me.DgvProductos.CurrentCell.ColumnIndex = Me.ProductoDataGridViewTextBoxColumn.Index Then
            Dim combo As ComboBox = DirectCast(e.Control, ComboBox)

            'combo.DataSource = Me.productos
            combo.Tag = Me.DgvProductos.CurrentCell.RowIndex

            RemoveHandler combo.PreviewKeyDown, AddressOf ComboPreviwKeyDown
            AddHandler combo.PreviewKeyDown, AddressOf ComboPreviwKeyDown
            RemoveHandler combo.SelectedIndexChanged, AddressOf ComboSelectedIndexChange
            AddHandler combo.SelectedIndexChanged, AddressOf ComboSelectedIndexChange
            Me.seleccionar = True
        End If
    End Sub

    Private Sub ComboPreviwKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.F12 Then
            'Me.ObtenerProductos()
            Me.ProductosC.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            'Dim combo As ComboBox = DirectCast(sender, ComboBox)

            'combo.DataSource = Me.dsProductos.Tables(0)

            'combo.DataSource = Me.productos
            'combo.ValueMember = "IdProducto"
            'combo.DisplayMember = "Descripcion"
            'combo.SelectedIndex = -1
            'combo.Text = "Seleccione un producto..."
        End If
    End Sub

    Private Sub ComboSelectedIndexChange(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If Not seleccionar Then
                Exit Sub
            End If

            Dim codigo As Integer = CInt(DirectCast(sender, ComboBox).SelectedValue)

            If Not codigo = 0 Then
                Me.DgvProductos.Rows(CInt(sender.Tag)).Cells(Me.IdProductoDataGridViewTextBoxColumn.Index).Value = CInt(DirectCast(sender, ComboBox).SelectedValue)

            End If

            Me.DgvProductos.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvProductos_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvProductos.DataError

    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar

    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Cursor = Cursors.WaitCursor

            Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Otras entradas")
            Dim ConfigAlmCol As New CC.MscconfigMovtosAlmacenCollection
            Dim folioMovimiento As String
            Dim idAlmacenCanal As Integer
            Dim idAlmacenCorte As Integer
            Dim idAlmacenProducto As Integer
            Dim canales As New CN.CapturaInventarioCollectionClass
            Dim cortes As New CN.CapturaInventarioCollectionClass
            Dim productos As New CN.CapturaInventarioCollectionClass
            Dim Folio As New CN.FoliosClass
            Dim movimientoCanal As EC.MscmovtosAlmacenCabEntity
            Dim movimientoCorte As EC.MscmovtosAlmacenCabEntity
            Dim movimientoProducto As EC.MscmovtosAlmacenCabEntity
            Dim kilosCanales As Decimal
            Dim kilosCortes As Decimal
            Dim piezasCortes As Decimal
            Dim kilosProductos As Decimal
            Dim piezasProductos As Decimal

            'configuro el mes y año del que sacara los folios
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            'obtengo la configuracion de los movimientos de almacen
            ConfigAlmCol.GetMulti(Nothing)

            'obtengo y valido que haya una configuracion de produccion
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                MsgBox("Debe establecer la configuración de producción; los almacenes de canales, productos y cortes", MsgBoxStyle.Exclamation, "Aviso")
            Else
                'obtengo los idAlmacen de canales, cortes y productos para realizar los movimientos en el inventario
                idAlmacenCanal = Controlador.Configuracion.Produccion.IdAlmacenCanales
                idAlmacenCorte = Controlador.Configuracion.Produccion.IdAlmacenesCortes
                idAlmacenProducto = Controlador.Configuracion.Produccion.IdAlmacenProductos
            End If

            'valido que haya una configuracion de movimientos de alamcen
            If ConfigAlmCol.Count < 0 Then
                MsgBox("Configure los movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            'valido que esten configurados los movimientos de entrada de canales, cortes y productos
            Select Case -1
                Case ConfigAlmCol(0).EntradaCanalXotrasEntradas.GetValueOrDefault(-1)
                    MsgBox("Configure los movimientos de almacén entrada de producto por otras entradas", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                Case ConfigAlmCol(0).EntradaCanalXotrasEntradas.GetValueOrDefault(-1)
                    MsgBox("Configure los movimientos de almacén entrada de canalaes por otras entradas", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                Case ConfigAlmCol(0).EntradaCorteXotrasEntradas.GetValueOrDefault(-1)
                    MsgBox("Configure los movimientos de almacén entrada de cortes por otras entradas", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
            End Select

            'separo los canales, productos y cortes en diferentes colecciones
            For Each item As CN.CapturaInventarioClass In Me.CapturaInventarioC
                If item.Canal Then
                    canales.Add(item)
                    'sumos los kilos de todos los canales
                    kilosCanales += item.Kilos
                ElseIf item.EsCorte Then
                    cortes.Add(item)
                    'sumo las piezas y kilos de  todos los cortes
                    kilosCortes += item.Kilos
                    piezasCortes += item.Piezas
                ElseIf item.EsProducto Then
                    productos.Add(item)
                    'sumo los kilos y piezas de todos los productos
                    kilosProductos += item.Kilos
                    piezasProductos += item.Piezas
                End If
            Next

            '============================= C A N A L E S ===============================

            If canales.Count > 0 Then
                'crear folio de movimeinto de almacen 
                Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen

                If Not Folio.Guardar(trans) Then
                    trans.Rollback()
                    MessageBox.Show("Error al generar folio de almacén", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Cancelar = True
                    Exit Sub
                End If

                folioMovimiento = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")

                movimientoCanal = New EC.MscmovtosAlmacenCabEntity

                trans.Add(movimientoCanal)

                movimientoCanal.IdCodAlmacen = idAlmacenCanal
                movimientoCanal.IdFolioMovimiento = folioMovimiento
                movimientoCanal.FechaMovimiento = Me.dtFechaAlta.Value
                movimientoCanal.FechaCaptura = Now
                movimientoCanal.IdCodMovimiento = ConfigAlmCol(0).EntradaCanalXotrasEntradas.Value
                movimientoCanal.CantKilos = kilosCanales
                movimientoCanal.CantPzas = canales.Count
                movimientoCanal.Estatus = "V"
                movimientoCanal.QuienCancelo = ""
                movimientoCanal.QuienContabilizo = ""
                movimientoCanal.ObservacionCancela = ""
                movimientoCanal.IdPoliza = ""

                'guardo el cabecero del movimiento
                movimientoCanal.Save()


                ''genero el folio para la recepcion de canal
                'Folio.Codigo = CodigodeFolios.EntradaCanalesAlmacen

                'If Not Folio.Guardar(trans) Then
                '    trans.Rollback()
                '    MessageBox.Show("Error al generar folio de almacén", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Cancelar = True
                '    Exit Sub
                'End If

                'RecepcCanales = New ClasesNegocio.RecepcionCanalesCabClass

                'RecepcCanales.FolioMov = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
                'RecepcCanales.FolioSacrificio = "0"
                'RecepcCanales.FechaSacrificio = Me.dtFechaAlta.Value
                'RecepcCanales.FechaCaptura = Now
                'RecepcCanales.LotePropio = True
                'RecepcCanales.CodCliente = 0
                'RecepcCanales.CantCanales = canales.Count
                'RecepcCanales.KgrsRastro = kilosCanales
                'RecepcCanales.Observaciones = ""
                'RecepcCanales.Estatus = "V"
                'RecepcCanales.IdRastro = 0
                'RecepcCanales.KgrsCalientes = kilosCanales
                'RecepcCanales.KgrsBascula = kilosCanales
                'RecepcCanales.Funcion = "I"
                'RecepcCanales.Opcion = 0

                'If Not RecepcCanales.Guardar(trans) Then
                '    trans.Rollback()
                '    Cancelar = True
                '    Exit Sub
                'End If

                'obtengo los canales y le doy entrada al almacen
                For Each item As CN.CapturaInventarioClass In canales
                    Dim movimientoDetalle As New EC.MscmovtosAlmacenDetEntity
                    'Dim recepcionCanalesDet As New ClasesNegocio.RecepcionCanalesDetClass

                    trans.Add(movimientoDetalle)

                    movimientoDetalle.MscmovtosAlmacenCab = movimientoCanal
                    movimientoDetalle.IdCodProducto = item.IdProducto
                    movimientoDetalle.CantPzas = item.Piezas
                    movimientoDetalle.CantKilos = item.Kilos
                    movimientoDetalle.CostoUnitario = item.Costo
                    movimientoDetalle.Iva = 0D

                    movimientoDetalle.Save()

                    'recepcionCanalesDet.FolioSacrificio = "0"
                    'recepcionCanalesDet.IdFolioCanal = ""
                    ''RecepcCanalesDet.Consecutivo = Me.txtNoRes.Text
                    'recepcionCanalesDet.Lado = 1
                    'recepcionCanalesDet.KgrsRastro = 0
                    'recepcionCanalesDet.KgrsBascula = 0
                    'recepcionCanalesDet.Estatus = ClasesNegocio.EstatusCanal.VIGENTE
                    'recepcionCanalesDet.IdFolioMovimiento = movimientoCanal.IdFolioMovimiento
                    'recepcionCanalesDet.CodigoBarra = ""
                    'recepcionCanalesDet.KgrsCalientes = 0
                    'recepcionCanalesDet.Sexo = ClasesNegocio.SexoEnum.MACHO
                    'recepcionCanalesDet.Funcion = "I"
                    'recepcionCanalesDet.Opcion = 0

                    'If Not recepcionCanalesDet.Guardar(trans) Then
                    '    trans.Rollback()
                    '    Cancelar = True
                    '    Exit Sub
                    'End If

                    Dim Inventario As New CN.InventarioClass

                    Inventario.IdCodAlmacen = idAlmacenCanal
                    Inventario.IdCodProducto = item.IdProducto
                    Inventario.ExistKilos = item.Kilos
                    Inventario.ExistPzas = 1
                    Inventario.EntKilos = item.Kilos
                    Inventario.EntPzas = item.Piezas
                    Inventario.SalKilos = 0D
                    Inventario.SalPzas = 0D
                    Inventario.Func = "I"
                    Inventario.NumOpc = 1
                    Inventario.Año = Now.Year
                    Inventario.Mes = Now.Month

                    'llama el guardar del inventario de productos
                    If Not Inventario.Guardar(trans) Then
                        trans.Rollback()
                        MessageBox.Show("Error al guardar en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Cancelar = True
                        Exit Sub
                    End If
                Next
            End If

            '========================= P R O D U C T O S =========================

            If productos.Count > 0 Then
                'crear folio de movimeinto de almacen 
                Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen

                If Not Folio.Guardar(trans) Then
                    trans.Rollback()
                    MessageBox.Show("Error al generar folio de almacén", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Cancelar = True
                    Exit Sub
                End If

                folioMovimiento = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")

                movimientoProducto = New EC.MscmovtosAlmacenCabEntity

                trans.Add(movimientoProducto)

                movimientoProducto.IdCodAlmacen = idAlmacenCanal
                movimientoProducto.IdFolioMovimiento = folioMovimiento
                movimientoProducto.FechaMovimiento = Me.dtFechaAlta.Value
                movimientoProducto.FechaCaptura = Now
                movimientoProducto.IdCodMovimiento = ConfigAlmCol(0).EntradaProductoXotrasEntradas.Value
                movimientoProducto.CantKilos = kilosCanales
                movimientoProducto.CantPzas = canales.Count
                movimientoProducto.Estatus = "V"
                movimientoProducto.QuienCancelo = ""
                movimientoProducto.QuienContabilizo = ""
                movimientoProducto.ObservacionCancela = ""
                movimientoProducto.IdPoliza = ""

                'guardo el cabecero del movimiento
                movimientoProducto.Save()

                For Each item As ClasesNegocio.CapturaInventarioClass In productos
                    Dim movimientoDetalle As New EC.MscmovtosAlmacenDetEntity

                    trans.Add(movimientoDetalle)

                    movimientoDetalle.MscmovtosAlmacenCab = movimientoProducto
                    movimientoDetalle.IdCodProducto = item.IdProducto
                    movimientoDetalle.CantPzas = item.Piezas
                    movimientoDetalle.CantKilos = item.Kilos
                    movimientoDetalle.CostoUnitario = item.Costo
                    movimientoDetalle.Iva = 0D

                    movimientoDetalle.Save()

                    'variable para la clase de inventario
                    Dim Inventario As New CN.InventarioClass

                    Inventario.IdCodAlmacen = idAlmacenProducto
                    Inventario.IdCodProducto = item.IdProducto
                    Inventario.ExistKilos = item.Kilos
                    Inventario.ExistPzas = item.Piezas
                    Inventario.EntKilos = item.Kilos
                    Inventario.EntPzas = item.Piezas
                    Inventario.SalKilos = 0D
                    Inventario.SalPzas = 0D
                    Inventario.Año = Now.Year
                    Inventario.Mes = Now.Month
                    Inventario.Func = "I"
                    Inventario.NumOpc = 1

                    'llama el guardar del inventario de productos
                    If Not Inventario.Guardar(trans) Then
                        trans.Rollback()
                        MessageBox.Show("Error al guardar en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Cancelar = True
                        Exit Sub
                    End If
                Next
            End If

            If cortes.Count > 0 Then
                'crear folio de movimeinto de almacen 
                Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen

                If Not Folio.Guardar(trans) Then
                    trans.Rollback()
                    MessageBox.Show("Error al generar folio de almacén", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Cancelar = True
                    Exit Sub
                End If

                folioMovimiento = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")

                movimientoCorte = New EC.MscmovtosAlmacenCabEntity

                trans.Add(movimientoCorte)

                movimientoCorte.IdCodAlmacen = idAlmacenCorte
                movimientoCorte.IdFolioMovimiento = folioMovimiento
                movimientoCorte.FechaMovimiento = Me.dtFechaAlta.Value
                movimientoCorte.FechaCaptura = Now
                movimientoCorte.IdCodMovimiento = ConfigAlmCol(0).EntradaCorteXotrasEntradas.Value
                movimientoCorte.CantKilos = kilosCanales
                movimientoCorte.CantPzas = canales.Count
                movimientoCorte.Estatus = "V"
                movimientoCorte.QuienCancelo = ""
                movimientoCorte.QuienContabilizo = ""
                movimientoCorte.ObservacionCancela = ""
                movimientoCorte.IdPoliza = ""

                'guardo el cabecero del movimiento
                movimientoCorte.Save()

                For Each item As ClasesNegocio.CapturaInventarioClass In productos
                    Dim movimientoDetalle As New EC.MscmovtosAlmacenDetEntity

                    trans.Add(movimientoDetalle)

                    movimientoDetalle.MscmovtosAlmacenCab = movimientoCorte
                    movimientoDetalle.IdCodProducto = item.IdProducto
                    movimientoDetalle.CantPzas = item.Piezas
                    movimientoDetalle.CantKilos = item.Kilos
                    movimientoDetalle.CostoUnitario = item.Costo
                    movimientoDetalle.Iva = 0D

                    movimientoDetalle.Save()

                    'variable para la clase de inventario
                    Dim Inventario As New CN.InventarioClass

                    Inventario.IdCodAlmacen = idAlmacenProducto
                    Inventario.IdCodProducto = item.IdProducto
                    Inventario.ExistKilos = item.Kilos
                    Inventario.ExistPzas = item.Piezas
                    Inventario.EntKilos = item.Kilos
                    Inventario.EntPzas = item.Piezas
                    Inventario.SalKilos = 0D
                    Inventario.SalPzas = 0D
                    Inventario.Año = Now.Year
                    Inventario.Mes = Now.Month
                    Inventario.Func = "I"
                    Inventario.NumOpc = 1

                    'llama el guardar del inventario de productos
                    If Not Inventario.Guardar(trans) Then
                        trans.Rollback()
                        MessageBox.Show("Error al guardar en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Cancelar = True
                        Exit Sub
                    End If
                Next
            End If

            trans.Commit()
            MsgBox("Se guardo la entrada de productos", MsgBoxStyle.Information, "Aviso")
            Limpiar()
            Deshabilitar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar las entradas", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Cursor = Cursors.WaitCursor
        Limpiar()
        Cursor = Cursors.Default
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Cursor = Cursors.WaitCursor

            Habilitar()
            Limpiar()
        Catch ex As Exception

        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        If cmbAlmacen.SelectedIndex > -1 Then
            Dim conf As New CC.UsrProdConfiguracionCollection

            conf.GetMulti(Nothing, 1)

            If conf.Count > 0 Then
                Select Case cmbAlmacen.SelectedValue
                    Case conf(0).IdAlmacenCanales
                        Me.ProductosC.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
                    Case conf(0).IdAlmacenCortes
                    Case conf(0).IdAlmacenDecomisos
                    Case conf(0).IdAlmacenProductos
                End Select
            Else

            End If
        End If
    End Sub
End Class