Imports ClasesNegocio
Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmCapturaProductos
    Dim WithEvents Decomisos As New DecomisosClass
    Dim WithEvents RegistroSacrificiosCab As New RegistroSacrificiosClass
    Dim Sacrificio As New CN.RegistroSacrificioColeccionClass
    Dim OrdenProductos As New OC.SortExpression(New SD.LLBLGen.Pro.ORMSupportClasses.SortClause(HC.MsccatProductosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
    Dim Productos As New CN.ProductosCollectionsClass
    Dim Motivos As New MotivosDecomisoCollectionClass
    Dim UltimaTeclaProducto As Date
    Dim DecomisosCol As New DecomisosColeccionClass
    'nuevas variables para usarse cuando no sea un rastro

    Private Sub FrmCapturaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        'guarda el detalle
        Try
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                MsgBox("Debe establecer la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'variables para las clases de movimientos almacen
            Dim Almacen As New CN.AlmacenProduccionClass
            Dim AlmacenDetalle As New CN.AlmacenDetalleClass
            Dim Folio As New CN.FoliosClass
            Dim FolioAlmacen As String

            'crear folio para almacen
            'Folio.Codigo = CodigodeFolios.Registrodeembarque
            Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al generar folio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            FolioAlmacen = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")

            Dim ConfigAlmCol As New CC.MscconfigMovtosAlmacenCollection

            ConfigAlmCol.GetMulti(Nothing)

            If ConfigAlmCol.Count < 0 Then
                Trans.Rollback()
                MsgBox("Configure los movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'asignar datos de almacen a clase de cabecero de almacen 
            Almacen.IdFolioMovimiento = FolioAlmacen

            If Controlador.Configuracion.Produccion.IdAlmacenProductos.HasValue Then
                Almacen.IdCodAlmacen = Controlador.Configuracion.Produccion.IdAlmacenProductos
            Else
                Trans.Rollback()
                MsgBox("No ha seleccionado un almacén para los productos en la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If ConfigAlmCol(0).EntradaProductoXcaptura.GetValueOrDefault(-1) = -1 Then
                Trans.Rollback()
                MsgBox("Debe configurar el movimiento de almacén Entradas de Productos por Captura", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Almacen.FechaMovimiento = Now
            Almacen.FechaCaptura = Now
            Almacen.IdCodMovimiento = ConfigAlmCol(0).EntradaProductoXcaptura
            Almacen.CantKilos = Me.txtPeso.Text
            Almacen.CantPzas = Me.txtPiezas.Text
            Almacen.Estatus = "V"
            Almacen.QuienCancelo = ""
            Almacen.QuienContabilizo = ""
            Almacen.ObservacionCancela = ""
            Almacen.NumOpc = 1
            Almacen.Func = "I"

            If Not Almacen.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al guardar en almacen", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            AlmacenDetalle.IdFolioMovimiento = FolioAlmacen
            AlmacenDetalle.IdCodProducto = Me.cmbProductos.SelectedValue
            AlmacenDetalle.CantPzas = Me.txtPiezas.Text
            AlmacenDetalle.CantKilos = Me.txtPeso.Text
            AlmacenDetalle.CostoUnitario = 0D
            AlmacenDetalle.IVA = 0D
            'AlmacenDetalle.Estatus = "V"
            AlmacenDetalle.Func = "I"
            AlmacenDetalle.NumOpc = 1

            'llama el guardar del detalle de almacenes
            If Not AlmacenDetalle.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al guardar el detalle del almacen", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Decomisos = New ClasesNegocio.DecomisosClass(Me.txtLoteSacrificio.Text, Me.cmbProductos.SelectedValue)
            Decomisos.IdAlmacenProd = Almacen.IdCodAlmacen
            Decomisos.LoteSacrificio = Me.txtLoteSacrificio.Text
            Decomisos.IdProducto = Me.cmbProductos.SelectedValue
            Decomisos.Piezas = Me.txtPiezas.Text
            Decomisos.Kilos = Me.txtPeso.Text
            Decomisos.Decomiso = False
            Decomisos.FolioMovimientoAlm = Almacen.IdFolioMovimiento
            Decomisos.Estatus = ClasesNegocio.EstatusDatos.VIGENTE

            If Decomisos.Entidad.IsNew Then
                Decomisos.Func = "I"
                Decomisos.NumOpc = 1

                If Not Decomisos.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
            Else
                If Not Decomisos.Guardar2(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
            End If

            'variable para la clase de inventario
            Dim Inventario As New CN.InventarioClass

            Inventario.IdCodAlmacen = Controlador.Configuracion.Produccion.IdAlmacenProductos
            Inventario.IdCodProducto = AlmacenDetalle.IdCodProducto
            Inventario.ExistKilos += AlmacenDetalle.CantKilos
            Inventario.ExistPzas += AlmacenDetalle.CantPzas
            Inventario.EntKilos = AlmacenDetalle.CantKilos
            Inventario.EntPzas = AlmacenDetalle.CantPzas
            Inventario.SalKilos = 0D
            Inventario.SalPzas = 0D
            Inventario.Func = "I"
            Inventario.NumOpc = 1
            Inventario.Año = Now.Year
            Inventario.Mes = Now.Month

            'llama el guardar del inventario de productos
            If Not Inventario.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al guardar en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Trans.Commit()

            MsgBox("Se guardo el producto", MsgBoxStyle.Information, "Aviso")
            Me.ObtenerDecomisos()
            Me.txtPiezas.Text = 0
            Me.txtPeso.Text = 0
            Me.cmbProductos.SelectedIndex = -1
            Me.cmbProductos.Text = "Seleccione un producto"

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub ObtenerDecomisos()
        Try
            DecomisosCol.Obtener(False, Me.txtLoteSacrificio.Text, CondicionEnum.ACTIVOS)
            Me.dgvDecomisos.AutoGenerateColumns = False
            Me.dgvDecomisos.DataSource = DecomisosCol

            Dim kilos As Decimal = 0D
            Dim piezas As Decimal = 0D

            For Each deco As ClasesNegocio.DecomisosClass In Me.DecomisosCol
                kilos += deco.Kilos
                piezas += deco.Piezas
            Next

            Me.TextBox5.Text = piezas
            Me.TextBox4.Text = kilos.ToString("N3")
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
        Me.lblMerma.Visible = False
        '  Me.CmbMotivoDecomiso.SelectedIndex = -1
    End Sub

    Private Sub Habilitar()
        Me.txtPiezas.Enabled = True
        Me.txtProductor.Enabled = True
        Me.cmbProductos.Enabled = True
        ' Me.CmbMotivoDecomiso.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtPiezas.Enabled = False
        Me.txtProductor.Enabled = False
        Me.cmbProductos.Enabled = False
        '   Me.CmbMotivoDecomiso.Enabled = False
    End Sub

    Private Sub ObtenerValores()
        Me.txtLoteSacrificio.Text = Decomisos.LoteSacrificio
        Me.txtProductor.Text = Decomisos.Sacrificio.NombreIntroductor
        Me.dtpFechaSacrificio.Value = Decomisos.Sacrificio.FechaSacrificio
        Me.cmbProductos.SelectedValue = Decomisos.IdProducto
        ' Me.CmbMotivoDecomiso.SelectedValue = Decomisos.MotivoDecomiso
        Me.txtPiezas.Text = Decomisos.Piezas
        Me.txtPeso.Text = Decomisos.Kilos
        Deshabilitar()
    End Sub

    Private Function Buscar() As Boolean
        Try
            Dim ventana As New ReporteRegistroSacrificios

            ventana.Text = "SELECCIONES LOTE DE SACRIFICIO PARA CAPTURA DE PRODUCTOS"
            ventana.Label17.Text = "SELECCIONES LOTE DE SACRIFICIO PARA CAPTURA DE PRODUCTOS"
            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.RegistroSacrificiosCab = ventana.Sacrificio
                Me.Limpiar()
                ObtenerSacrificios(1)
            Else
                Me.Close()
            End If
            Productos.ObtenerProductos(CondicionEstatusEnum.ACTIVO)
            Me.cmbProductos.DataSource = Productos
            Me.cmbProductos.ValueMember = "IdProducto"
            Me.cmbProductos.DisplayMember = "Descripcion"
            Me.cmbProductos.SelectedIndex = -1
            Me.ObtenerDecomisos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


        'Try

        'Dim ventana As New FrmConDecomisos


        'ventana.Text = "BÚSQUEDA DE PRODUCTOS"
        'ventana.Label17.Text = "BÚSQUEDA DE PRODUCTOS"


        'If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
        'Me.Decomisos = ventana.DgvDecomisos.SelectedRows(0).DataBoundItem
        ' ObtenerValores()
        'End If

        'Return True
        'Catch ex As Exception
        '#If CONFIG = "Debug" Then
        '  MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '#Else
        ' MsgBox("Ocurrio un error al buscar un decomiso", MsgBoxStyle.Critical, "Error")
        '#End If
        'Return False
        ' End Try
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

    Private Function CancelarCanal() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            'guarda el detalle
            Decomisos.LoteSacrificio = Me.txtLoteSacrificio.Text
            Decomisos.IdProducto = Me.cmbProductos.SelectedValue
            Decomisos.Piezas = Me.txtPiezas.Text
            Decomisos.Kilos = Me.txtPeso.Text

            Decomisos.Func = "M"
            Decomisos.NumOpc = 1

            If Not Decomisos.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            Trans.Commit()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            If Me.txtPeso.Text = "" Or Me.txtPeso.Text = 0 Then
                MsgBox("Ingrese el peso del producto", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtPeso.Focus()
                Return False
            End If

            If Me.txtPiezas.Text = "" Or Me.txtPiezas.Text = 0 Then
                MsgBox("Ingrese el número de piezas del producto", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtPiezas.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If Guardar() Then
            MessageBox.Show("Se guardo el Producto ", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Limpiar()
        Else
            Cancelar = True
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
            Controlador.Configuracion.ActualizarProduccion()

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
            If Validar() Then
                Me.Guardar()
            End If
            Me.cmbProductos.Focus()
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbProductos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProductos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPiezas.Focus()
        Else
            Me.TmProducto.Stop()
            Me.UltimaTeclaProducto = Now
            Me.TmProducto.Start()
        End If
    End Sub

    Private Sub BtnBascula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBascula.Click
        ObtenerPesoBascula()
    End Sub

    Private Sub cmbProductos_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProductos.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Productos.ObtenerProductos(CondicionEstatusEnum.ACTIVO)
        End If
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductos.SelectedIndexChanged
        Try
            If Me.cmbProductos.SelectedIndex > -1 Then
                Dim Merma As Boolean
                Merma = DirectCast(Me.cmbProductos.SelectedItem, CN.ProductosClass).EsMerma
                If Merma Then
                    Me.lblMerma.Visible = True
                Else
                    Me.lblMerma.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvDecomisos_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvDecomisos.PreviewKeyDown
        If Me.dgvDecomisos.SelectedRows.Count > 0 AndAlso e.KeyCode = Keys.Delete Then
            If MsgBox("Se cancelara el producto, ¿Esta seguro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Controlador.Sesion.MiEmpresa.Empnom) = MsgBoxResult.Yes Then
                CancelarProducto(CType(CType(sender, DataGridView).SelectedRows(0).DataBoundItem, DecomisosClass))
            End If
        End If
    End Sub

    Private Function CancelarProducto(ByVal Decomiso As DecomisosClass) As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelacion de Producto")

        Try
            'guarda el detalle

            Controlador.Configuracion.ActualizarProduccion()

            'variables para las clases de movimientos almacen
            Dim Almacen As New CN.AlmacenProduccionClass
            Dim AlmacenDetalle As New CN.AlmacenDetalleClass
            Dim Folio As New CN.FoliosClass
            Dim FolioAlmacen As String

            'crear folio para almacen
            'Folio.Codigo = CodigodeFolios.Registrodeembarque
            Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al generar folio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            FolioAlmacen = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")

            Dim ConfigAlmCol As New CC.MscconfigMovtosAlmacenCollection

            ConfigAlmCol.GetMulti(Nothing)

            If ConfigAlmCol.Count < 0 Then
                Trans.Rollback()
                MsgBox("Configure los movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'asignar datos de almacen a clase de cabecero de almacen 
            Almacen.IdFolioMovimiento = FolioAlmacen

            If Controlador.Configuracion.Produccion.IdAlmacenProductos.HasValue Then
                Almacen.IdCodAlmacen = Controlador.Configuracion.Produccion.IdAlmacenProductos
            Else
                Trans.Rollback()
                MsgBox("No ha seleccionado un almacén para los productos en la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If ConfigAlmCol(0).SalidaProductoXcancelacionProductoCaptura.GetValueOrDefault(-1) = -1 Then
                Trans.Rollback()
                MsgBox("Debe configurar el movimiento de almacén Salidas de Productos por Cancelacion de Captura", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Almacen.FechaMovimiento = Now
            Almacen.FechaCaptura = Now
            Almacen.IdCodMovimiento = ConfigAlmCol(0).SalidaProductoXcancelacionProductoCaptura
            Almacen.CantKilos = Decomiso.Kilos
            Almacen.CantPzas = Decomiso.Piezas
            Almacen.Estatus = "V"
            Almacen.QuienCancelo = Controlador.Sesion.MiUsuario.Usrnom
            Almacen.QuienContabilizo = ""
            Almacen.ObservacionCancela = ""
            Almacen.NumOpc = 1
            Almacen.Func = "I"

            If Not Almacen.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al guardar en almacen", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            AlmacenDetalle.IdFolioMovimiento = FolioAlmacen
            AlmacenDetalle.IdCodProducto = Decomiso.IdProducto
            AlmacenDetalle.CantPzas = Decomiso.Piezas
            AlmacenDetalle.CantKilos = Decomiso.Kilos
            AlmacenDetalle.CostoUnitario = 0D
            AlmacenDetalle.IVA = 0D
            'AlmacenDetalle.Estatus = "V"
            AlmacenDetalle.Func = "I"
            AlmacenDetalle.NumOpc = 1

            'llama el guardar del detalle de almacenes
            If Not AlmacenDetalle.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al guardar el detalle del almacen", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If Not Decomiso.Borrar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'variable para la clase de inventario
            Dim Inventario As New CN.InventarioClass

            Inventario.IdCodAlmacen = Controlador.Configuracion.Produccion.IdAlmacenProductos
            Inventario.IdCodProducto = AlmacenDetalle.IdCodProducto
            Inventario.ExistKilos += AlmacenDetalle.CantKilos
            Inventario.ExistPzas += AlmacenDetalle.CantPzas
            Inventario.EntKilos = 0D
            Inventario.EntPzas = 0D
            Inventario.SalKilos = AlmacenDetalle.CantKilos
            Inventario.SalPzas = AlmacenDetalle.CantPzas
            Inventario.Func = "I"
            Inventario.NumOpc = 2
            Inventario.Año = Now.Year
            Inventario.Mes = Now.Month

            'llama el guardar del inventario de productos
            If Not Inventario.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("Error al guardar en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Trans.Commit()

            MsgBox("Se cancelo el producto satisfactoriamente", MsgBoxStyle.Information, "Aviso")
            Me.ObtenerDecomisos()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()

    End Sub

    Private Sub FrmCapturaProductos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos = True Then
                Dim Consultas As New ReporteRegistroSacrificios
                Consultas.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE PRODUCTOS"
                Consultas.Label17.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE PRODUCTOS"

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

            Productos.ObtenerProductos(CondicionEstatusEnum.ACTIVO)
            Me.cmbProductos.DataSource = Productos
            Me.cmbProductos.ValueMember = "IdProducto"
            Me.cmbProductos.DisplayMember = "Descripcion"
            Me.cmbProductos.SelectedIndex = -1
            Me.ObtenerDecomisos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class