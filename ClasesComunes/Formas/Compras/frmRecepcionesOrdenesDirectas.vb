
Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmRecepcionesOrdenesDirectas
    Private Orden As ClasesNegocio.OrdenCompraClass
    Dim RecepcionOrdenCompra As RecepcionOrdenCompraClass
    Dim RecepcionOrdenCompraDetalle As RecepcionOrdenCompraDetClass
    Dim SucColeccion As New SucursalCollectionClass
    Dim MonedaColeccion As New TipoMonedaCollectionClass

    ''Kareli 16/01/2015 inicia 05:54 p.m.
    Dim lp As ClasesNegocio.ListaPrecioClass
    ''Kareli 16/01/2015 Fin 

    Dim Plaza As New ClasesNegocio.PlazaClass
    Dim Sucursal As New ClasesNegocio.SucursalClass
    Dim Moneda As New ClasesNegocio.TipoMonedaClass
    Dim NomProveedor As String = ""
    Dim Modo As Integer
    Public _FolioAlm As String
    Dim TipoCambio As Decimal
    Dim Prods As ProductoCollectionClass
    Dim CodListaPrecios As Integer

    Dim Iva As Decimal
    Dim moverme
    Dim ValidandoCelda As Boolean = False
    Dim Guardando As Boolean = False
    Dim preguntaporfacturar As Boolean = False
    'Dim Almacenes As New ClasesNegocio.AlamacenCatalagoColletionClass
    Dim Almacen As ClasesNegocio.AlmacenClass
    'Dim Almacen As New AlmacenCatalogoClass
    ''kareli 03/12/2014
    Dim InvMovAlmacenCab As AlmacenGeneral.MovimientoAlmacenPVClass
    Dim InvMovAlmacenDet As AlmacenGeneral.MovimientoAlmacenPVDetalleClass
    Dim valorcelda As String
    Dim endedit As Boolean = False
    Dim cargacodsucursal As Boolean
    Dim carganomimpresora As Boolean
    'Dim InvAlmacen As AlmacenGeneral.InventarioAlmacenClass
    'Dim Almacen As New ClasesNegocio.AlmacenCatalogoClass

    ''CONTROLADOR.OBTENERIVA ()----FUNCION PARA OBTENER IVA7702003469381

#Region "Load"

    'Private Sub frmRecepcionesOrdenesDirectas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        e.Handled = True
    '    SendKeys.Send(Chr(Keys.Tab))
    '    End If
    'End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmRecepcionesOrdenesDirectas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Utilerias.ObtenerCodSucursal = 0 Then
                cargacodsucursal = False
                Exit Sub
            Else
                cargacodsucursal = True
            End If

            If Utilerias.ObtenerNomImpresora = "" Then
                carganomimpresora = False
                Exit Sub
            Else
                carganomimpresora = True
            End If


            Me.KeyPreview = True
            Me.Icon = MdiParent.Icon
            For Each col As DataGridViewColumn In dgvDetalleOrdenCompra.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "000100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "000100011"
            tbEstados.StateBorrar = "000100011"
            tbEstados.StateEditar = "000011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.Mtb.ToolBarButtonStatus = tbEstados
            Me.Mtb.sbCambiarEstadoBotones("Cancelar")

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            dgvDetalleOrdenCompra.AutoGenerateColumns = False
            Prods = New ClasesNegocio.ProductoCollectionClass
            Prods.Obtener()
            clmIdProducto.DisplayMember = "Descripcion"
            clmIdProducto.ValueMember = "Codigo"
            clmIdProducto.DataSource = Prods

            ''/****kareli 22/12/2014*****/
            ''Obtener valor del iva
            Iva = Controlador.ObtenerIVA()
            ''Obtener valor del iva
            ''/****kareli 22/12/2014*****/


            ''kareli 05/12/2014 (inicia)
            Dim codsuc As Integer
            If Utilerias.ObtenerCodSucursal = 0 Then
                'MessageBox.Show("Es necesario configurar una sucursal del punto de venta.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
                Me.Dispose()
            End If
            codsuc = Utilerias.ObtenerCodSucursal()
            If codsuc = 0 Then
                Sucursal = Nothing
                cmbPlaza.Enabled = True
                cmbSucursal.Enabled = True
            Else
                Sucursal.Obtener(codsuc)
                cmbPlaza.Enabled = True
                cmbSucursal.Enabled = True
                cmbPlaza.SelectedValue = Sucursal.IdPlaza
                SucColeccion.Obtener(CInt(cmbPlaza.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbSucursal.DataSource = SucColeccion
                cmbSucursal.DisplayMember = "DescripcionCorta"
                cmbSucursal.ValueMember = "Codigo"
                cmbSucursal.SelectedValue = Sucursal.Codigo
                cmbPlaza_SelectedIndexChanged(Nothing, Nothing)
            End If
            ''kareli 05/12/2014 (Termina)

            ''kareli 17/11/2014 (inicia)******
            cmbMoneda.SelectedValue = "1"
            txtTipoCambio.Text = 1
            txtTipoCambio.Enabled = False
            Dim codmoneda As Integer
            codmoneda = MonedaTC.Obtener(CondicionEnum.ACTIVOS)
            If codmoneda = 0 Then
                Moneda = Nothing
                cmbMoneda.Enabled = True
            Else
                cmbMoneda.Enabled = False
                cmbMoneda.DataSource = MonedaTC
                cmbMoneda.DisplayMember = "DescripcionCorta"
                cmbMoneda.ValueMember = "Codigo"
                cmbMoneda.SelectedValue = 1

            End If
            txtTipoCambio.Visible = False
            cmbMoneda.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            ''kareli 17/11/2014 (termina)******

            cmbAlmacen.Enabled = False
            cmbSucursal.Enabled = False

            cmbPlaza.Enabled = False


            cmbSucursal.SelectedValue = Utilerias.ObtenerCodSucursal

            cmbAlmacen.SelectedValue = Sucursal.IdAlmacen
            ''kareli 16/12/2014******
            'cmbAlmacen.DataSource = Me.Almacenes
            'cmbAlmacen.DisplayMember = "Descripcion Corta"
            'cmbAlmacen.ValueMember = "Codigo"
            ''cmbAlmacen.SelectedIndex = -1
            'Dim codAlmacen As Integer
            'codAlmacen = Almacenes.Obtener()
            'If codAlmacen = 0 Then
            '    Almacen = Nothing
            '    cmbAlmacen.Enabled = True
            'Else
            '    Almacenes.Obtener()
            '    cmbAlmacen.DataSource = Almacenes
            '    cmbAlmacen.DisplayMember = "DescripcionCorta"
            '    cmbAlmacen.ValueMember = "IdAlmacen"
            '    cmbAlmacen.SelectedValue = Almacen.IdCodAlmacen
            'End If
            'Me.Almacen = New ClasesNegocio.AlmacenClass
            'Almacen.Obtener(Me.RecepcionOrdenCompra.AlmacenId)
            ''kareli06/12/2014

            ''Kareli 06/01/2015 inicia
            'If (DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)).ListasPrecio(0).Codigo <> Nothing Then
            '    CodListaPrecios = (DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)).ListasPrecio(0).Codigo
            'End If
            CodListaPrecios = (DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)).ListasPrecio(0).Codigo


            ''Kareli 06/01/2015 termina

            Me.Limpiar()
            Me.DesHabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Botones TollBar"

    Private Sub Mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickBorrar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Salida")

        Try
            If Me.RecepcionOrdenCompra.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MessageBox.Show("No se puede cancelar la Recepcion, debido a que ya se encuentra Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            'If Me.RecepcionOrdenCompra.Facturada Then
            '    MessageBox.Show("No se puede Cancelar la Recepcion por que ya se encuentra facturada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Cancelar = True
            '    Exit Sub
            'End If

            If MessageBox.Show("¿Esta seguro de Cancelar la Recepción de Orden de compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Orden.Estatus = EstatusOrdenCompra.CANCELADO
                trans.Add(Orden.ObtenerEntidad)
                If Not Orden.ObtenerEntidad.Save Then
                    trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                Modo = 2 'Cancelacion
                'obtiene la letra serie del almacen seleccionado

                ''kareli 03/12/2014
                'Me.Almacen = New ClasesNegocio.AlmacenClass
                'Almacen.Obtener(Me.RecepcionOrdenCompra.AlmacenId)

                'If Me.cmbAlmacen.SelectedValue Is Nothing Then
                '    MessageBox.Show("No se puede realizar la cancelación de la Recpción de Orden Compra debido a que el Almacén:" & Almacen.Descripcion & " esta cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    trans.Rollback()
                '    Cancelar = True
                '    Exit Sub
                'End If
                ''kareli 03/12/2014

                ''asigna el folio de movimiento de almacen
                '_FolioAlm = AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, trans)
                'guardar Movimientos de almacen cabecero
                'InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenClass
                ''If Not Me.GuardarMovAlmacenCab() Then
                ''    trans.Rollback()
                ''    Cancelar = True
                ''    Exit Sub
                ''End If

                'trans.Add(InvMovAlmacenCab.Entidad)

                'If Not Me.InvMovAlmacenCab.Entidad.Save Then
                '    trans.Rollback()
                '    Cancelar = True
                '    Exit Sub
                'End If

                'Guardar Movimientos de Almacen Detalle

                'Dim i As Integer = 0
                'For Each det As RecepcionOrdenCompraDetClass In Me.RecepcionOrdenCompra.Detalles
                '    i += 1
                '    Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenDetalleClass
                '    Me.InvMovAlmacenDet.IdAlmacen = Me.cmbAlmacen.SelectedValue
                '    Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                '    Me.InvMovAlmacenDet.EmpresaId = det.EmpresaId
                '    Me.InvMovAlmacenDet.IdProducto = det.IdProducto
                '    Me.InvMovAlmacenDet.Cantidad = det.Cantidad
                '    Me.InvMovAlmacenDet.Costo = det.OrdenCompraDetalle.Precio
                '    Me.InvMovAlmacenDet.Descuento = det.OrdenCompraDetalle.Descuento
                '    Me.InvMovAlmacenDet.FechaMovimiento = Now
                '    Me.InvMovAlmacenDet.Indice = i
                'Me.InvMovAlmacenDet.DescripcionMov = TipoMovClass.Nombre

                'If det.OrdenDet.Producto.SeAplicaIva = SiNoEnum.SI Then
                '    Me.InvMovAlmacenDet. = (det.Cantidad * det.OrdenDet.Precio) * (ObtenerIVA() / 100)
                'End If

                'If Not Me.InvMovAlmacenDet.Guardar(trans) Then
                '    Cancelar = True
                '    trans.Rollback()
                '    Exit Sub
                'End If
                'Next

                'If Not GuardarSalida(trans) Then
                '    Cancelar = True
                '    trans.Rollback()
                '    Exit Sub
                'End If

                'Me.RecepcionOrdenCompra.FolioMovimientoAlmCan = _FolioAlm
                Me.RecepcionOrdenCompra.UsuarioCancelacionId = Controlador.Sesion.MiUsuario.Usrndx

                If Me.RecepcionOrdenCompra.Borrar(trans) Then
                    trans.Commit()
                    MessageBox.Show("La recepcion de orden de compra ha sido Cancelada", "Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Limpiar()
                DesHabilitar()
            Else
                trans.Rollback()
                Cancelar = True
                Exit Sub
            End If
        Catch ex As Exception
            Cancelar = True
            trans.Rollback()
            MessageBox.Show(ex.Message, "Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickBuscar
        Try
            Dim Forma As New ComBusquedaRecepcionOrden(True)
            Forma.Icon = Me.Icon
            If Forma.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Folio As String = Forma.DataGridView1.SelectedRows(0).Cells("idRecepcionOrdenCompra").Value
                Dim Codigo As Integer = Forma.DataGridView1.SelectedRows(0).Cells("clmIdRecepcion").Value
                Dim FolioOrden As Integer = Forma.DataGridView1.SelectedRows(0).Cells("clmIdOrdenCompra").Value
                Me.RecepcionOrdenCompra = New RecepcionOrdenCompraClass
                Me.RecepcionOrdenCompra.Obtener(Codigo)
                PonerDatos()
                Me.Orden = New OrdenCompraClass
                Orden.Obtener(FolioOrden)

                Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
                Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

                cmbMoneda.SelectedValue = Orden.Moneda.Codigo
                txtTipoCambio.Text = Orden.TipoCambio.ToString("C2")
                cmbProveedor.SelectedValue = Orden.Proveedor.Codigo
                cmbPlaza.SelectedValue = Orden.Sucursal.Plaza.Codigo
                Me.txtFletes.Text = Orden.ImpteIvaFlete.ToString("C2")
                Me.txtIVAFletes.Text = Orden.IvaFlete.ToString("C2")

                Me.txtDescuento.Text = RecepcionOrdenCompra.Descuento.ToString("C2")
                Me.txtIVA.Text = RecepcionOrdenCompra.IVA.ToString("C2")


                ''Kareli 15/01/2015 inicia
                ''Me.txtIEPS.Text = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(Me.clmIeps.Index).Value
                ''Kareli 15/01/2015 Termina

                Me.txtIEPS.Text = RecepcionOrdenCompra.Ieps.ToString("C2")
                Me.txtTotal.Text = RecepcionOrdenCompra.Total.ToString("C2")
                Me.txtSubTotal.Text = RecepcionOrdenCompra.SubTotal.ToString("C2")
                Me.txtImporteTotal.Text = (RecepcionOrdenCompra.SubTotal - Me.RecepcionOrdenCompra.Descuento).ToString("C2")


                'If Orden.TipoCambio > 1 Then
                '    Me.GrpImportesPesos.Visible = True
                '    Me.txtImportePesos.Text = ((RecepcionOrdenCompra.SubTotal - Me.RecepcionOrdenCompra.Descuento) * Orden.TipoCambio).ToString("C2")
                '    txtDescuentoPesos.Text = (RecepcionOrdenCompra.Descuento * Orden.TipoCambio).ToString("C2")
                '    txtIvaPesos.Text = (RecepcionOrdenCompra.IVA * Orden.TipoCambio).ToString("C2")
                '    txtSubTotalPesos.Text = (RecepcionOrdenCompra.SubTotal * Orden.TipoCambio).ToString("C2")
                '    txtTotalPesos.Text = ((RecepcionOrdenCompra.SubTotal + RecepcionOrdenCompra.IVA) * Orden.TipoCambio).ToString("C2")
                'End If
                'CalcularTotal()

                CalcularSuma()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickCancelar
        Limpiar()
        Me.DesHabilitar()
    End Sub

    Private Sub Mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Dim correcto As Boolean = False
        Me.Cursor = Cursors.WaitCursor
        Try
            Guardando = True
            ValidandoCelda = False
            If Not Me.Validar OrElse Not Me.Validate() Then
                Guardando = False ''
                Cancelar = True
                Exit Sub
            End If

            'Guardar la Orden de Compra
            GuardarOrden()
            Dim cont = Orden.Detalle.Count
            For j As Integer = 0 To Orden.Detalle.Count - 1
                Dim OrdenDet As OrdenCompraDetalleClass = Orden.Detalle(j)
                Dim Imp As Decimal = OrdenDet.Precio * OrdenDet.CantidadOrdenada
                OrdenDet.Descuento = Imp * OrdenDet.Descuento / 100

                OrdenDet.Renglon = j + 1
                OrdenDet.IdMoneda = Orden.IdMoneda
                OrdenDet.TipoCambio = Orden.TipoCambio
                OrdenDet.CantPendiente = 0D
                OrdenDet.CantRecibida = OrdenDet.CantidadOrdenada
                OrdenDet.CantidadSolicitada = OrdenDet.CantidadOrdenada
                OrdenDet.Estatus = EstatusEnum.ACTIVO
            Next

            If Not Orden.GuardarDirecta(Trans) Then
                Trans.Rollback()
                Cancelar = True
                MsgBox("No se logro guardar la Orden de Compra", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            'obtiene la letra serie del almacen seleccionado
            Me.Almacen = New ClasesNegocio.AlmacenClass
            Almacen.Obtener(Me.cmbAlmacen.SelectedValue)
            'genera el folio de movimiento de almacen en la clase
            Dim FolioAlmacen As New FolioAlmacenClass
            FolioAlmacen.LetraSerie = Almacen.Letras
            FolioAlmacen.Año = Now.Year
            FolioAlmacen.Mes = Now.ToString("MM")

            If Not FolioAlmacen.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            'asigna el folio de movimiento de almacen
            _FolioAlm = AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, Trans)

            'Generar el Folio de la Recepcion
            Dim Folio As New FoliosClass
            Folio.Codigo = CodigodeFolios.ComprasDirectas
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            'guardar Movimientos de almacen cabecero
            InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenPVClass

            If Not GuardarMovAlmacenCab(1) Then ''EL 1 REPRESENTA UNA ENTRADA POR COMPRA
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            'Trans.Add(Me.InvMovAlmacenCab.Entidad)

            'If Not Me.InvMovAlmacenCab.Entidad.Save Then
            '    Trans.Rollback()
            '    Cancelar = True
            '    Exit Sub
            'End If

            If Not InvMovAlmacenCab.Guardar(Trans) Then
                Trans.Rollback()
                'TransMovAlm.Rollback()

                Cancelar = True
                'Exit Function
                Exit Sub
            End If

            'Se guarda el Cabecero de la Recepcion
            Me.txtFolio.Text = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
            Guardar()
            If Not Me.RecepcionOrdenCompra.Guardar(Trans) Then
                Trans.Rollback()
                'Cancelar = True
                Exit Sub

                Throw (New Exception("No fue posible guardar la compra."))
            Else
                txtFolio.Text = RecepcionOrdenCompra.FolioRecepcionOrdenCompra.ToString
                InvMovAlmacenCab.Referencia = RecepcionOrdenCompra.FolioRecepcionOrdenCompra.ToString
                If Not InvMovAlmacenCab.Guardar(Trans) Then
                    Trans.Rollback()
                    'TransMovAlm.Rollback()

                    Cancelar = True
                    'Exit Function
                    Exit Sub
                End If
            End If

            Dim IdProducto As Integer
            Dim IdAlmacen As Integer
            Dim i As Integer = 0
            Dim divisor As Integer = 0
            Dim PrecioProd As Decimal = 0D
            Dim CantRecibir As Decimal = 0D
            Dim CostoPromedio As Decimal = 0D
            ''Guardar Movimientos de Almacen Detalle
            For Each Det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle

                If Det.CantidadOrdenada > 0 Then
                    i = i + 1
                    IdProducto = Det.Producto.Codigo

                    IdAlmacen = Me.cmbAlmacen.SelectedValue
                    Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                    Me.InvMovAlmacenDet.IdAlmacen = IdAlmacen
                    Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                    Me.InvMovAlmacenDet.IdProducto = Det.Producto.Codigo
                    Me.InvMovAlmacenDet.Cantidad = Det.CantRecibida
                    Me.InvMovAlmacenDet.Costo = Det.Precio
                    Me.InvMovAlmacenDet.Descuento = Det.Descuento
                    Me.InvMovAlmacenDet.Indice = i
                    'If Det.Producto.SeAplicaIva = SiNoEnum.SI Then
                    '    Me.InvMovAlmacenDet.IVA = (Det.CantPendiente * Det.Precio) * (ObtenerIVA(Controlador.Sesion.Empndx) / 100)
                    'End If
                    If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If

                    'Guardar el detalle de la recepcion
                    Me.RecepcionOrdenCompraDetalle = New RecepcionOrdenCompraDetClass
                    Me.RecepcionOrdenCompraDetalle.IdRecepcionOrdenCompra = Me.RecepcionOrdenCompra.IdRecepcionOrdenCompra
                    Me.RecepcionOrdenCompraDetalle.IdProducto = IdProducto
                    Me.RecepcionOrdenCompraDetalle.Cantidad = Det.CantRecibida
                    Me.RecepcionOrdenCompraDetalle.Costo = Det.Precio
                    Me.RecepcionOrdenCompraDetalle.Descuento = Det.Descuento
                    Me.RecepcionOrdenCompraDetalle.IVA = Det.Iva
                    Me.RecepcionOrdenCompraDetalle.IVA = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(Me.clmIva.Index).Value

                    ''Kareli 15/01/2015 inicia
                    Me.RecepcionOrdenCompraDetalle.Ieps = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(Me.clmIeps.Index).Value
                    ''Kareli 15/01/2015 Termina

                    Me.RecepcionOrdenCompraDetalle.Total = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(clmImporte.Index).Value

                    Det.Producto.UltimoCosto = Det.Precio
                    Det.Producto.FechaUltimaCompra = Me.RecepcionOrdenCompra.FechaRecepcion
                    Det.Producto.CantidadUltimaCompra = Det.CantRecibida
                    Det.Producto.ImporteUltimaCompra = Det.Precio * Det.CantRecibida
                    If Not Det.Producto.Guardar(Trans) Then
                        'Trans.Rollback()
                        'Cancelar = True
                        'Exit Sub
                        Throw New Exception("Se produjo un error al intentar actualizar el costo del producto " + Det.ProductoNombre)
                    End If

                    ' Si se actualizó el precio de venta guarda el nuevo precio
                    If Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(clmActualizarPrecio.Index).Value = 1 Then
                        Dim codprod As Integer = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(clmIdProducto.Index).Value
                        Dim ListaPrecioDet As New ClasesNegocio.ListaPrecioDetalleClass
                        'Dim lp As New ClasesNegocio.ListaPrecioClass

                        ListaPrecioDet.Obtener(CodListaPrecios, codprod)

                        ''PRUEBAS
                        ListaPrecioDet.PrecioVentaC = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(clmPrecioVenta.Index).Value

                        ''Kareli 16/01/2015 inicia 05:58 p.m.
                        'ListaPrecioDet.ListaPrecio.FechaCaptura = DateTime.Now



                        If Not ListaPrecioDet.Guardar(Trans) Then
                            'Trans.Rollback()
                            'Cancelar = True
                            'Exit Sub
                            Throw New Exception("Se produjo un error al intentar actualizar el precio del producto " + Det.ProductoNombre)
                        End If
                        If Not ListaPrecioDet.ListaPrecio.Actualizar(Trans) Then
                            Throw New Exception("Se produjo un error al intentar actualizar el precio del producto " + Det.ProductoNombre)
                        End If
                    End If

                    If Not RecepcionOrdenCompraDetalle.Guardar(Trans) Then
                        'Trans.Rollback()
                        'Cancelar = True
                        'Exit Sub
                        Throw New Exception("Se produjo un error al intentar guardar el detalle de la compra" + vbNewLine + "producto " + Det.ProductoNombre)
                    End If
                End If

            Next
            Trans.Commit()
            MessageBox.Show("Se guardo la Recepcion de Compra Directa con el Folio: " & Me.txtFolio.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            correcto = True


            ' Me.RecepcionOrdenC.Add(Me.RecepcionOrdenCompra)
            Me.Cursor = Cursors.WaitCursor
            Imprimir()

        Catch ex As Exception
            Cancelar = True
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Exit Sub
        Finally
            Me.Cursor = Cursors.Default
            If correcto Then
                Guardando = False
                If Convert.ToDecimal(Replace(txtTotal.Text, "$", "")) < 2000 Then
                    Select Case MsgBox("¿Quieres pagar esta compra?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Aviso")
                        Case MsgBoxResult.Yes
                            Dim vent As New frmPagoProveedor(cmbProveedor.SelectedValue, cmbProveedor.Text, txtTotal.Text, txtSubTotal.Text, txtIVA.Text, txtIEPS.Text, Me.txtFolio.Text, RecepcionOrdenCompra.IdRecepcionOrdenCompra)
                            vent.ShowDialog()
                            'Case MsgBoxResult.No
                            '    MessageBox.Show("NO button")
                    End Select
                End If
                Me.Limpiar()
                Me.DesHabilitar()
            End If

            
        End Try
    End Sub

    Public Function GuardarMovAlmacenCab(ByVal TipoMov As Integer) As Boolean
        Try
            'Dim ConfigAlm As New CC.InventarioConfiguracionCollection
            'ConfigAlm.GetMulti(Nothing, 0, Nothing)

            'If ConfigAlm.Count < 1 Then
            '    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If

            Me.InvMovAlmacenCab.IdAlmacen = Me.cmbAlmacen.SelectedValue
            Me.InvMovAlmacenCab.FolioMovimientoAlmacen = _FolioAlm
            Me.InvMovAlmacenCab.FechaMovimiento = Now

            'If Modo = 1 Then
            '    If IsDBNull(ConfigAlm(0).ExCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
            'ElseIf Modo = 2 Then
            '    If IsDBNull(ConfigAlm(0).SxDevolucionCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
            'End If
            ' Me.InvMovAlmacenCab.ValorMovimientoId = ""
            Me.InvMovAlmacenCab.IdTipoMovimiento = TipoMov ''ENTRADA POR COMPRA
            Me.InvMovAlmacenCab.CostoTotal = CDec(Me.txtTotal.Text)
            Me.InvMovAlmacenCab.Origen = "COMPRAS"
            Me.InvMovAlmacenCab.Referencia = Me.txtFolio.Text
            Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.InvMovAlmacenCab.EstatusContabilizado = 0

            Return True
            ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
            'Me.InvMovAlmacenCab.PolizaContabilidad = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''Function GuardarInvAlmacen(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
    ''    Try

    ''        Dim IdAlmacen As Integer = Me.cmbAlmacen.SelectedValue
    ''        ' se lee los registros del detalle de la orden de compra
    ''        For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
    ''            'Declaraciones
    ''            Me.InvAlmacen = New MInvAlmacenClass
    ''            Dim CantidadRecibir As Integer = Me.dgvDetalleOrdenCompra.Rows(i).Cells("ClmRecibir").Value
    ''            Dim PrecioProd As Integer = Me.dgvDetalleOrdenCompra.Rows(i).Cells("ClmPrecio").Value
    ''            Dim IdProducto As Integer = Me.dgvDetalleOrdenCompra.Rows(i).Cells("ClmIdProducto").Value
    ''            Dim CostoPromedio As Decimal
    ''            Dim divisor As Decimal

    ''            ' si existe el almacen y el producto se modifican los campos 
    ''            If Me.InvAlmacen.Obtener(IdAlmacen, IdProducto, Me.RecepcionOrdenCompra.FechaRecepcion.Year, Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM")) Then
    ''                'actualiza los valores de la tabla
    ''                'Formula Costo Promedio

    ''                divisor = Me.InvAlmacen.Cantidad + CantidadRecibir
    ''                If divisor = 0 Then
    ''                    CostoPromedio = 0
    ''                Else
    ''                    CostoPromedio = ((Me.InvAlmacen.Cantidad * Me.InvAlmacen.CostoPromedio) + (CantidadRecibir * PrecioProd)) / _
    ''                                     divisor
    ''                End If

    ''                With Me.InvAlmacen
    ''                    '.CantidadInicial = 0
    ''                    .Cantidad -= CantidadRecibir
    ''                    .CantidadSalida += CantidadRecibir
    ''                    .FechaUltimoCosto = Now
    ''                    .UltimoCosto = PrecioProd
    ''                    .CostoPromedio = CostoPromedio
    ''                End With
    ''                If Not Me.InvAlmacen.Guardar(trans) Then
    ''                    Return False
    ''                Else
    ''                    Continue For
    ''                End If
    ''            Else
    ''                If Me.InvAlmacen.Obtener(IdAlmacen, IdProducto, Me.RecepcionOrdenCompra.FechaRecepcion.AddMonths(-1).Year, Me.RecepcionOrdenCompra.FechaRecepcion.AddMonths(-1).Month) Then
    ''                    Dim TempAlm As New EC.InventarioAlmacenEntity
    ''                    divisor = Me.InvAlmacen.Cantidad + CantidadRecibir
    ''                    If divisor = 0 Then
    ''                        CostoPromedio = 0
    ''                    Else
    ''                        CostoPromedio = (Me.InvAlmacen.CostoPromedio * Me.InvAlmacen.Cantidad + PrecioProd * CantidadRecibir) / divisor
    ''                    End If

    ''                    With TempAlm
    ''                        .AlmacenId = IdAlmacen
    ''                        .ProductoId = IdProducto
    ''                        .CantidadInicial = Me.InvAlmacen.Cantidad
    ''                        .Cantidad = Me.InvAlmacen.Cantidad + CantidadRecibir
    ''                        .Año = Me.RecepcionOrdenCompra.FechaRecepcion.Year
    ''                        .Mes = Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM")
    ''                        .CantidadEntrada = CantidadRecibir
    ''                        .CantidadSalida = 0
    ''                        .CostoPromedio = CostoPromedio
    ''                        .UltimoCosto = PrecioProd
    ''                        .FechaUltimoCosto = Now
    ''                    End With
    ''                    Me.InvAlmacen.LeerEntidad(TempAlm)
    ''                    If Not Me.InvAlmacen.Guardar(trans) Then
    ''                        Return False
    ''                    Else
    ''                        Continue For
    ''                    End If
    ''                End If
    ''            End If

    ''            ' si no existe el almacen y el producto se agrega un nuevo registro
    ''            With Me.InvAlmacen
    ''                .AlmacenId = IdAlmacen
    ''                .ProductoId = IdProducto
    ''                .CantidadInicial = 0
    ''                .Cantidad = CantidadRecibir
    ''                .UltimoCosto = PrecioProd
    ''                .CostoPromedio = PrecioProd
    ''                .FechaUltimoCosto = Now
    ''                .PorSurtir = 0
    ''                .CantidadEntrada = CantidadRecibir
    ''                .CantidadSalida = 0
    ''                .Año = Me.RecepcionOrdenCompra.FechaRecepcion.Year
    ''                .Mes = Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM")
    ''            End With
    ''            If Not Me.InvAlmacen.Guardar(trans) Then
    ''                Return False
    ''            End If
    ''        Next
    ''        Return True
    ''    Catch ex As Exception
    ''        MsgBox(ex.Message)
    ''        Return False
    ''    End Try
    ''End Function

    Private Sub Mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub Mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickLimpiar
        'Me.Limpiar()
        Mtb_ClickCancelar(sender, Nothing, False)
        Mtb_ClickNuevo(sender, Nothing, False)
    End Sub

    Private Sub Mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickNuevo
        Try
            Me.Limpiar()
            Me.Habilitar()
            ''***Kareli 18/12/2014***
            ''Me.cmbPlaza.Focus()
            ''***Kareli 18/12/2014***
            Me.cmbProveedor.Focus()
            Me.Orden = New OrdenCompraClass
            Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle
            'Almacen.Obtener(Utilerias.ObtenerControlTurnoActual
            ''lblSucursal.Text = Sucursal.DescripcionCorta

            ''kareli 05/12/2014
            RecepcionOrdenCompra = New RecepcionOrdenCompraClass
            Me.RecepcionOrdenCompraDetalle = New RecepcionOrdenCompraDetClass

            Modo = 1 'Modo inserccion
            'Me.RecepcionOrdenCompra.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Close()
    End Sub

#End Region

#Region "Metodos"

    Sub LimpiarMontos()
        Me.txtImporteTotal.Text = "0.00"
        Me.txtDescuento.Text = "0.00"
        Me.txtSubTotal.Text = "0.00"
        Me.txtFletes.Text = "0.00"
        Me.txtIVAFletes.Text = "0.00"
        Me.txtIVA.Text = "0.00"
        Me.txtIEPS.Text = "0.00"
        Me.txtIEPSPesos.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        Me.txtImportePesos.Text = "0.00"
        Me.txtDescuentoPesos.Text = "0.00"
        Me.txtSubTotalPesos.Text = "0.00"
        Me.txtFletesPesos.Text = "0.00"
        Me.txtIVAFletesPesos.Text = "0.00"
        Me.txtIvaPesos.Text = "0.00"
        Me.txtTotalPesos.Text = "0.00"
    End Sub

    Sub Limpiar()
        'Me.cmbPlaza.SelectedIndex = -1
        'Me.cmbSucursal.SelectedIndex = -1
        ''**kareli 16/12/2014****
        ''Me.cmbMoneda.SelectedIndex = -1
        ''**kareli 16/12/2014****
        Me.cmbProveedor.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione un Proveedor..."
        'Me.cmbAlmacen.SelectedIndex = -1
        Me.txtFolio.Text = ""
        'Me.txtFolioRecepcion.Text = 0
        Me.txtNoFactura.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtSumaRecibir.Text = 0
        'Me.txtSumaOrdenada.Text = 0
        'Me.txtSumaRecibidas.Text = 0
        'Me.txtTipoCambio.Text = 0
        RemoveHandler dgvDetalleOrdenCompra.RowValidating, AddressOf dgvDetalleOrdenCompra_RowValidating
        Me.dgvDetalleOrdenCompra.DataSource = Nothing
        AddHandler dgvDetalleOrdenCompra.RowValidating, AddressOf dgvDetalleOrdenCompra_RowValidating
        ' Me.dgvDetalleOrdenCompra.DataSource = Nothing
        Me.lblEstatus.Visible = False
        Me.GrpImportesPesos.Visible = False
        Me.DtpFecha.Value = Now
        preguntaporfacturar = False
        LimpiarMontos()
    End Sub

    Sub DesHabilitar()
        'Me.cmbPlaza.Enabled = False
        'Me.cmbSucursal.Enabled = False
        'Me.cmbAlmacen.Enabled = False
        Me.cmbProveedor.Enabled = False
        ''**kareli 16/12/2014****
        'Me.cmbMoneda.Enabled = False
        ''**kareli 16/12/2014****
        Me.txtNoFactura.Enabled = False
        Me.dgvDetalleOrdenCompra.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtFletes.ReadOnly = True
    End Sub

    Sub Habilitar()
        'Me.cmbAlmacen.Enabled = True
        'Me.cmbPlaza.Enabled = True
        'Me.cmbSucursal.Enabled = True

        'Me.txtNoFactura.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.dgvDetalleOrdenCompra.Enabled = True
        'Me.cmbMoneda.Enabled = True
        Me.cmbProveedor.Enabled = True
        Me.txtFletes.ReadOnly = False
    End Sub

    Sub Guardar()
        Try
            Me.RecepcionOrdenCompra.IdOrdenCompra = Orden.IdOrdenCompra
            Me.RecepcionOrdenCompra.IdSucursal = Me.cmbSucursal.SelectedValue
            Me.RecepcionOrdenCompra.AlmacenId = Me.cmbAlmacen.SelectedValue
            Me.RecepcionOrdenCompra.FechaRecepcion = Now
            'Me.RecepcionOrdenCompra.IdProveedor = Orden.IdProveedor = CType(Me.cmbProveedor.SelectedValue, Integer)
            Me.RecepcionOrdenCompra.FechaCancelacion = "01/01/1900"
            Me.RecepcionOrdenCompra.Observaciones = Me.txtObservaciones.Text
            Me.RecepcionOrdenCompra.FolioMovimientoAlm = "" '_FolioAlm
            Me.RecepcionOrdenCompra.FolioMovimientoAlmCan = ""
            Me.RecepcionOrdenCompra.UsuarioAltaId = Controlador.Sesion.Usrndx
            Me.RecepcionOrdenCompra.NumFactura = Me.txtNoFactura.Text
            Me.RecepcionOrdenCompra.SubTotal = Me.txtSubTotal.Text
            Me.RecepcionOrdenCompra.Descuento = Me.txtDescuento.Text
            Me.RecepcionOrdenCompra.IVA = Me.txtIVA.Text
            ''Kareli 16/01/2015 inicia
            Me.RecepcionOrdenCompra.Ieps = Me.txtIEPS.Text
            ''Kareli 16/01/2015 Termina
            Me.RecepcionOrdenCompra.Total = Me.txtTotal.Text
            Me.RecepcionOrdenCompra.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            Me.RecepcionOrdenCompra.Observaciones_Cancelacion = ""
            Me.RecepcionOrdenCompra.EsDirecta = True
            Me.RecepcionOrdenCompra.OrigenMovimiento = "P"

            Me.RecepcionOrdenCompra.IdProveedor = CType(Me.cmbProveedor.SelectedValue, Integer)
            If RecepcionOrdenCompra.NumFactura = "" Then
                Me.RecepcionOrdenCompra.Facturada = False
            Else
                Me.RecepcionOrdenCompra.Facturada = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GuardarOrden()
        Try
            Orden.IdSucursal = CType(Me.cmbSucursal.SelectedValue, Integer)
            Orden.IdProveedor = CType(Me.cmbProveedor.SelectedValue, Integer)
            NomProveedor = CType(Me.cmbProveedor.SelectedText, String)
            Orden.TipoCambio = CDec(Me.txtTipoCambio.Text)
            Orden.IdMoneda = CType(Me.cmbMoneda.SelectedValue, Integer)
            Orden.Observaciones = txtObservaciones.Text
            Orden.ObservacionesCancelacion = ""
            Orden.DiasCredito = DirectCast(Me.cmbProveedor.SelectedItem, ProveedorClass).DiasCredito
            Orden.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Orden.Importe = CDec(Me.txtImporteTotal.Text)
            Orden.Descuento = CDec(Me.txtDescuento.Text)
            Orden.SubTotal = CDec(Me.txtSubTotal.Text)
            Orden.IVAPor = 0
            Orden.IVATotal = CDec(Me.txtIVA.Text)

            Orden.Total = CDec(Me.txtTotal.Text)
            Orden.Estatus = EstatusOrdenCompra.VIGENTE
            Orden.Autorizada = CondicionAsignadaEnum.SI
            Orden.Recibida = EstatusOrdenRecibida.RECIBIDA
            Orden.FechaAutorizacion = Me.DtpFecha.Value
            Orden.FechaRecibida = Me.DtpFecha.Value
            Orden.IvaFlete = CDec(Me.txtIVAFletes.Text)
            Orden.ImpteIvaFlete = CDec(Me.txtFletes.Text)
            Orden.FechaOrdenCompra = Now
            Orden.EsDirecta = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Private Function GuardarSalida(ByRef Trans As HC.Transaction) As Boolean
    '    Try
    '        Dim IdAlmacen As Integer = Me.RecepcionOrdenCompra.AlmacenId
    '        Dim IdProducto As Integer
    '        Dim Precio As Decimal
    '        Dim CostoPromedio As Decimal
    '        Dim Divisor As Decimal

    '        ' se lee los registros del detalle de la orden de compra

    '        For Each det As ClasesNegocio.RecepcionOrdenCompraDetClass In Me.RecepcionOrdenCompra.Detalles
    '            Precio = det.OrdenCompraDetalle.Precio
    '            IdProducto = det.IdProducto
    '            Dim CantSalir As Integer = det.Cantidad
    '            'InvAlmacen = New AlmacenGeneral.InventarioAlmacenClass
    '            'Se buscan los movimientos del producto en el mes actual
    '            If InvAlmacen.Obtener(IdAlmacen, IdProducto, Me.RecepcionOrdenCompra.FechaRecepcion.Year, Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM")) Then

    '                Divisor = Me.InvAlmacen.CantidadExistencia - CantSalir
    '                If Divisor = 0 Then
    '                    CostoPromedio = 0
    '                Else
    '                    CostoPromedio = ((Me.InvAlmacen.CantidadExistencia * Me.InvAlmacen.CostoPromedio) - (CantSalir * Precio)) / _
    '                                         Divisor
    '                End If

    '                InvAlmacen.CantidadExistencia = InvAlmacen.CantidadExistencia - CantSalir
    '                InvAlmacen.CantidadSalidas = CantSalir
    '                InvAlmacen.CostoPromedio = CostoPromedio
    '                If InvAlmacen.CantidadExistencia = 0 Then
    '                    InvAlmacen.UltimoCosto = 0
    '                    InvAlmacen.FechaUltimoCosto = #1/1/1900#
    '                End If

    '                If Not InvAlmacen.Guardar(Trans) Then
    '                    Return False
    '                End If
    '            Else
    '                Dim InvCol As New CC.InventarioAlmacenCollection
    '                Dim Filtro As New OC.PredicateExpression
    '                'Se obtiene el ultimo movimiento del producto en el almacen 
    '                Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = IdAlmacen And _
    '                          HC.InventarioAlmacenFields.ProductoId = IdProducto)
    '                Dim Orden As New OC.SortExpression
    '                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
    '                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
    '                InvCol.GetMulti(Filtro, 1, Orden)

    '                Dim AuxInvEntity As EC.InventarioAlmacenEntity
    '                If InvCol.Count > 0 Then
    '                    AuxInvEntity = InvCol(0)
    '                Else
    '                    MessageBox.Show("No se encontro el producto en el almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                    Return False
    '                End If
    '                Dim CantExistencias As Decimal = AuxInvEntity.CantidadExistencia
    '                Divisor = CantExistencias - CantSalir
    '                If Divisor = 0 Then
    '                    CostoPromedio = 0
    '                Else
    '                    CostoPromedio = ((Me.InvAlmacen.CantidadExistencia * Me.InvAlmacen.CostoPromedio) - (CantSalir * Precio)) / _
    '                                         Divisor
    '                End If
    '                Dim InvEntity As New EC.InventarioAlmacenEntity
    '                With InvEntity
    '                    ' .EmpresaId = AuxInvEntity.EmpresaId
    '                    .AlmacenId = AuxInvEntity.AlmacenId
    '                    .ProductoId = AuxInvEntity.ProductoId
    '                    .Año = Now.Year
    '                    .Mes = Now.Month
    '                    .CantidadExistencia = CantExistencias - CantSalir
    '                    .CantidadEntrada = 0
    '                    .CantidadSalidas = CantSalir
    '                    .CostoPromedio = CostoPromedio
    '                    .CostoPromedio = CostoPromedio
    '                    .UltimoCosto = AuxInvEntity.UltimoCosto
    '                    .FechaUltimoCosto = AuxInvEntity.FechaUltimoCosto
    '                End With
    '                Trans.Add(InvEntity)
    '                If Not InvEntity.Save Then
    '                    Return False
    '                End If
    '            End If
    '        Next
    '        Return True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try
    'End Function

    'Private Function GuardarMovAlmacenCab() As Boolean
    '    Try
    '        Dim ConfigAlm As New CC.InventarioConfiguracionCollection
    '        ConfigAlm.GetMulti(Nothing, 0, Nothing)

    '        If ConfigAlm.Count < 1 Then
    '            MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Return False
    '        End If

    '        Me.InvMovAlmacenCab.IdAlmacen = Me.cmbAlmacen.SelectedValue
    '        Me.InvMovAlmacenCab.FolioMovimientoAlmacen = _FolioAlm
    '        Me.InvMovAlmacenCab.FechaMovimiento = Now

    '        If Modo = 1 Then
    '            If IsDBNull(ConfigAlm(0).ExCompra) Then
    '                MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Return False
    '            End If
    '            Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
    '        ElseIf Modo = 2 Then
    '            If IsDBNull(ConfigAlm(0).SxDevolucionCompra) Then
    '                MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Return False
    '            End If
    '            Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
    '        End If
    '        ' Me.InvMovAlmacenCab.ValorMovimientoId = ""
    '        Me.InvMovAlmacenCab.Origen = "COMPRAS"
    '        Me.InvMovAlmacenCab.Referencia = Me.txtFolio.Text
    '        Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
    '        Me.InvMovAlmacenCab.EstatusContabilizado = 0
    '        Me.InvMovAlmacenCab.CostoTotal = CDec(Me.txtTotal.Text)
    '        Return True
    '        ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
    '        'Me.InvMovAlmacenCab.PolizaContabilidad = ""
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try
    'End Function

    Sub Imprimir()
        Try

            'Dim cr As New ClasesNegocio.crRecepCompraTck()
            Dim verReporte As New FrmReportes
            Dim RecepcionOrdenCompraC As New RecepcionOrdenCompraCollectionClass
            RecepcionOrdenCompraC.Add(Me.RecepcionOrdenCompra)
            RecepcionOrdenCompraC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            'verReporte.CRV.ReportSource = RecepcionOrdenCompraC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            'verReporte.Show()
            'verReporte.CRV.PrintOptions = "TICKET"
            'verReporte.CRV.PrintReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub ImprimirTicket()

    End Sub

    Private Function Validar() As Boolean
        Try
            'If Not Me.cmbAlmacen.SelectedIndex > -1 Then
            '    MessageBox.Show("Especifique el Almacen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.cmbAlmacen.Focus()
            '    Return False
            'End If

            If Not Me.cmbPlaza.SelectedIndex > -1 Then
                MsgBox("Seleccione una Plaza", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbPlaza.SelectedIndex = 0
                Me.cmbPlaza.Focus()
                Return False
            End If

            'If Not Me.cmbSucursal.SelectedIndex > -1 Then
            '    MsgBox("Seleccione una Sucursal", MsgBoxStyle.Exclamation, "Aviso")
            '    Me.cmbSucursal.SelectedIndex = 0
            '    Me.cmbSucursal.Focus()
            '    Return False
            'End If

            If Not Me.cmbProveedor.SelectedIndex > -1 Then
                MsgBox("Seleccione un Proveedor", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbProveedor.SelectedIndex = 0
                Me.cmbProveedor.Focus()
                Return False
            End If

            'If Not Me.cmbMoneda.SelectedIndex > -1 Then
            '    MsgBox("Seleccione el Tipo de Moneda", MsgBoxStyle.Exclamation, "Aviso")
            '    Me.cmbMoneda.SelectedIndex = 0
            '    Me.cmbMoneda.Focus()
            '    Return False
            'End If

            'If Me.txtNoFactura.Text = "" Then
            '    MsgBox("Ingrese el Número de Factura", MsgBoxStyle.Exclamation, "Aviso")
            '    Me.txtNoFactura.Focus()
            '    Return False
            'End If

            If dgvDetalleOrdenCompra.DataSource Is Nothing OrElse Not dgvDetalleOrdenCompra.DataSource.Count > 0 Then
                MessageBox.Show("Especifique los productos a recibir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub PonerDatos()
        Me.txtFolio.Text = Me.RecepcionOrdenCompra.FolioRecepcionOrdenCompra
        Me.cmbPlaza.SelectedValue = Me.RecepcionOrdenCompra.Sucursal.IdPlaza
        Me.cmbAlmacen.SelectedValue = Me.RecepcionOrdenCompra.AlmacenId
        Me.DtpFecha.Text = Me.RecepcionOrdenCompra.FechaRecepcion
        Me.cmbSucursal.SelectedValue = Me.RecepcionOrdenCompra.IdSucursal
        Me.cmbProveedor.SelectedValue = Me.RecepcionOrdenCompra.OrdenCompra.IdProveedor
        Me.txtObservaciones.Text = Me.RecepcionOrdenCompra.Observaciones
        Me.txtNoFactura.Text = Me.RecepcionOrdenCompra.NumFactura
        Me.lblEstatus.Visible = True
        Me.lblEstatus.Text = Me.RecepcionOrdenCompra.Estatus.ToString
        'Me.cmbMoneda.SelectedValue = Me.RecepcionOrdenCompra.OrdenCompra.IdMoneda
        Me.txtTipoCambio.Text = Me.RecepcionOrdenCompra.OrdenCompra.TipoCambio.ToString("C2")
    End Sub

    Sub CalcularSuma()
        Dim Suma As Decimal = 0D

        For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
            If Not Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantOrd.Index).Value Is Nothing Then
                'Suma += Decimal.Parse(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantOrd.Index).Value.ToString)
                Suma += Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantOrd.Index).Value
            End If
        Next
        Me.txtSumaRecibir.Text = Suma.ToString("N2")
    End Sub

    Sub ConvertirPesos(ByVal Importe As Decimal, ByVal Descuento As Decimal, ByVal SubTotal As Decimal, ByVal Flete As Decimal, ByVal FleteIva As Decimal, ByVal Iva As Decimal, ByVal Total As Decimal)
        Dim TipoCambio As Decimal = 0D

        If IsNumeric(txtTipoCambio.Text) Then
            TipoCambio = CType(txtTipoCambio.Text, Decimal)
        End If

        txtImportePesos.Text = (Importe * TipoCambio).ToString("C2")
        txtDescuentoPesos.Text = (Descuento * TipoCambio).ToString("C2")
        txtSubTotalPesos.Text = (SubTotal * TipoCambio).ToString("C2")
        txtFletesPesos.Text = (Flete * TipoCambio).ToString("C2")
        txtIVAFletesPesos.Text = (FleteIva * TipoCambio).ToString("C2")
        txtIvaPesos.Text = (Iva * TipoCambio).ToString("C2")
        txtTotalPesos.Text = (Total * TipoCambio).ToString("C2")
    End Sub

    Sub CalcularImportes()
        Dim Importe As Decimal = 0D
        Dim Descuento As Decimal = 0D
        Dim SubTotal As Decimal = 0D
        Dim Flete As Decimal = 0D
        Dim FleteIva As Decimal = 0D
        Dim Iva As Decimal = 0D
        ''Kareli 16/01/2015 inicia
        Dim Ieps As Decimal = 0D
        ''Kareli 16/01/2015 termina
        Dim Total As Decimal = 0D

        For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
            If Not Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmPrecio.Index).Value Is Nothing AndAlso Not Me.dgvDetalleOrdenCompra.Rows(i).Cells(clmCantOrd.Index).Value Is Nothing Then
                Dim Imp As Decimal = CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmPrecio.Index).Value, Decimal) * CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(clmCantOrd.Index).Value, Decimal)

                Importe += Imp

                If Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value IsNot Nothing Then
                    Descuento += Imp * CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value, Decimal) / 100
                End If
                Iva += CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIva.Index).Value, Decimal)
                ''Kareli 16/01/2015 inicia
                Ieps += CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIeps.Index).Value, Decimal)
                ''Kareli 16/01/2015 termina

            End If
        Next
        SubTotal = Importe - Descuento

        If IsNumeric(txtFletesPesos.Text) Then
            Flete = CType(txtFletes.Text, Decimal)
        End If

        If IsNumeric(txtIVAFletesPesos.Text) Then
            FleteIva = CType(txtIVAFletes.Text, Decimal)
        End If
        Total = SubTotal + Iva + Flete + FleteIva + Ieps

        txtImporteTotal.Text = Importe.ToString("C2")
        txtDescuento.Text = Descuento.ToString("C2")
        txtSubTotal.Text = SubTotal.ToString("C2")
        txtIVA.Text = Iva.ToString("C2")
        txtIEPS.Text = Ieps.ToString("C2")
        txtTotal.Text = Total.ToString("C2")
    End Sub

    Private Sub Calcular()
        CalcularSuma()
        CalcularImportes()
    End Sub

#End Region

#Region "Key Press"

    Private Sub txtNoFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub cmbAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAlmacen.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNoFactura.Focus()
        End If
    End Sub

#End Region

#Region "Datagrid"

    Private Sub dgvDetalleOrdenCompra_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellEndEdit
        Dim bandera As Boolean = False
        'Dim objeto As Object = dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem
        'If objeto Is Nothing Then
        '    Exit Sub
        'End If
        If Not dgvDetalleOrdenCompra.CurrentRow.IsNewRow Then
            If e.ColumnIndex = clmCantOrd.Index OrElse e.ColumnIndex = clmPrecio.Index OrElse e.ColumnIndex = clmDescuento.Index Then
                If e.ColumnIndex = clmPrecio.Index OrElse e.ColumnIndex = clmCantOrd.Index Then
                    With dgvDetalleOrdenCompra.Rows(e.RowIndex)
                        'And dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCantOrd.Index).Value <> 0 Then
                        ''sub_total = dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCantOrd.Index).Value * dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value

                        'If .Cells(clmCantOrd.Index).Value <> 0 Then
                        '    bandera = True
                        'End If

                        .Cells(clmSubtotal.Index).Value = .Cells(clmCantOrd.Index).Value * .Cells(clmPrecio.Index).Value
                    End With

                End If


                CType(dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem, OrdenCompraDetalleClass).CalcularImporte(Iva)



                Calcular()
                dgvDetalleOrdenCompra.Refresh()
            End If
        End If
    End Sub

    Private Sub dgvDetalleOrdenCompra_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDetalleOrdenCompra.CellValidating
        If endedit = False Then
            If Not Guardando Then ValidandoCelda = True
            If e.ColumnIndex = clmCodigoBarra.Index And e.FormattedValue <> "" Then
                Dim col As New CC.ProductoCollection()
                Dim rel As OC.RelationCollection = Nothing
                Dim filtro As New OC.PredicateExpression()

                filtro.Add(HC.ProductoFields.CodigoBarra = e.FormattedValue)
                col.GetMulti(filtro, 0, Nothing, rel)
                If col.Count = 0 Then
                    e.Cancel = True
                    MessageBox.Show("El código de barras no existe.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmIdProducto.Index).Value = col(0).Codigo
                End If
            End If
        Else

            valorcelda = e.FormattedValue
            'e.Cancel = True
        End If
        
    End Sub

    Private Sub dgvDetalleOrdenCompra_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalleOrdenCompra.DataError

    End Sub

    Private Sub dgvDetalleOrdenCompra_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalleOrdenCompra.RowValidating
        Try
            Dim OrdenDetalle As OrdenCompraDetalleClass = CType(dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem, OrdenCompraDetalleClass)
            If e.RowIndex = dgvDetalleOrdenCompra.RowCount - 1 Then
                If OrdenDetalle Is Nothing OrElse OrdenDetalle.Producto Is Nothing OrElse OrdenDetalle.Producto.Entidad.IsNew Then
                    e.Cancel = False
                    Return
                End If
            End If

            ''Comentado por Kareli 06/01/2015 (inicia)
            ''Se comentó para que se pudiera capturar otro renglón del grid
            'If ValidandoCelda Then
            '    e.Cancel = True
            '    ValidandoCelda = False
            '    Return
            'End If
            ''Comentado por Kareli 06/01/2015 (termina)

            For i As Integer = 0 To dgvDetalleOrdenCompra.Rows.Count - 1
                If dgvDetalleOrdenCompra.NewRowIndex <> i Then
                    If i <> e.RowIndex Then
                        If dgvDetalleOrdenCompra.Rows(i).Cells(clmIdProducto.Index).Value = dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmIdProducto.Index).Value Then
                            e.Cancel = True
                            MessageBox.Show("El producto esta duplicado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                End If
            Next

            'Dim OrdenDetalle As OrdenCompraDetalleClass = CType(dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem, OrdenCompraDetalleClass)
            If OrdenDetalle Is Nothing OrElse OrdenDetalle.Producto Is Nothing OrElse OrdenDetalle.Producto.Entidad.IsNew Then
                e.Cancel = True
                MessageBox.Show("Debe especificar el producto", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not IsNumeric(dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCantOrd.Index).Value) _
            OrElse dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCantOrd.Index).Value = 0 Then
                e.Cancel = True
                MessageBox.Show("Debe especificar la cantidad a ordenar", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not IsNumeric(dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value) _
            OrElse dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value = 0 Then
                e.Cancel = True
                ''***Kareli 17/12/2014****
                ''***Se cambió el mensaje en lugar de Costo, decía Precio, debe ser costo
                ''***porque es compra
                MessageBox.Show("Debe especificar el Costo", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvDetalleOrdenCompra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvDetalleOrdenCompra.KeyDown
       



        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send(Chr(Keys.Tab))
            Return
        End If
        If dgvDetalleOrdenCompra.CurrentRow IsNot Nothing Then
            If dgvDetalleOrdenCompra.CurrentRow.Index <> dgvDetalleOrdenCompra.NewRowIndex Then
                If e.KeyCode = Keys.Delete Then
                    If MessageBox.Show("Se eliminara el detalle, ¿esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        dgvDetalleOrdenCompra.Rows.RemoveAt(dgvDetalleOrdenCompra.CurrentRow.Index)
                        Application.DoEvents()

                        Calcular()
                    End If
                End If
            End If
        End If

        
    End Sub

#End Region


#Region "ComboBox"

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmbSucursal.Focus()
            End If
            If e.KeyCode = Keys.F12 Then
                PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbPlaza.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > -1 Then
            SucColeccion.Obtener(CInt(cmbPlaza.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbSucursal.DataSource = SucColeccion
            cmbSucursal.SelectedIndex = -1
            CodListaPrecios = (DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)).ListasPrecio(0).Codigo

            Me.AlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, CInt(cmbPlaza.SelectedValue))
            cmbAlmacen.DataSource = Me.AlmacenC
            cmbAlmacen.SelectedIndex = -1
        Else
            cmbSucursal.SelectedIndex = -1
            SucColeccion.Clear()
            cmbAlmacen.SelectedIndex = -1
            AlmacenC.Clear()
        End If
    End Sub

    'Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Me.DtpFecha.Focus()
    '        End If
    '        If e.KeyCode = Keys.F12 Then
    '            Me.SucursalC.Obtener()
    '            Me.cmbSucursal.SelectedIndex = -1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    ''Private Sub cmbAlmacen_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbAlmacen.PreviewKeyDown
    'Try
    '    If e.KeyCode = Keys.F12 Then
    '        Me.AlmacenC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
    '        Me.cmbAlmacen.SelectedIndex = -1
    '    End If
    'Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    ''End Sub

    'Private Sub cmbAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedValueChanged
    'LimpiarMontos()

    'If cmbAlmacen.SelectedValue IsNot Nothing Then
    '    clmIdProducto.DisplayMember = "Descripcion"
    '    clmIdProducto.ValueMember = "Codigo"
    '    clmIdProducto.DataSource = CType(cmbAlmacen.SelectedItem, AlmacenClass).CatalogoProductos
    'Else
    '    clmIdProducto.DataSource = Nothing
    'End If
    'End Sub


    ''/***comentado 13/01/2015
    'Private Sub cmbProveedor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProveedor.PreviewKeyDown
    '    Try
    '        If e.KeyCode = Keys.F12 Then
    '            Me.ProveedorC.Obtener(CondicionEnum.ACTIVOS)
    '            Me.cmbProveedor.SelectedIndex = -1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    ''/***comentado por kareli 13/01/2015*///

    Private Sub cmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProveedor.KeyPress
        
        ''/***comentado por kareli 13/01/2015*///
        'If e.KeyChar = Chr(13) Then
        '    If IsNothing(Me.cmbProveedor.SelectedValue) Then
        '        MsgBox("Seleccione un Proveedor")
        '        Me.cmbProveedor.Focus()
        '    Else
        '        Me.cmbAlmacen.Focus()
        '    End If
        'ElseIf e.KeyChar = Chr(Keys.F12) Then
        '    ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        '    Me.cmbProveedor.ValueMember = "IDProveedor"
        '    Me.cmbProveedor.DataSource = ProveedorC
        '    Me.cmbProveedor.DisplayMember = "RazonSocial"
        '    Me.cmbProveedor.SelectedIndex = -1
        '    Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        'End If
        ''/***comentado por kareli 13/01/2015*///

        ''/*** 13/01/2015 inicio
        If e.KeyChar = Chr(Keys.F12) Then
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbProveedor.ValueMember = "IDProveedor"
            Me.cmbProveedor.DataSource = ProveedorC
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.SelectedIndex = -1
            Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        End If
        ''/*** 13/01/2015 fin

    End Sub

    'Private Sub cmbMoneda_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbMoneda.PreviewKeyDown
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Me.cmbProveedor.Focus()
    '        End If
    '        If e.KeyCode = Keys.F12 Then
    '            MonedaTC.Obtener()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        If cmbMoneda.SelectedIndex > -1 Then
            TipoCambio = DirectCast(cmbMoneda.SelectedItem, ClasesNegocio.TipoMonedaClass).TipoCambio(Me.DtpFecha.Value)
            Me.txtTipoCambio.Text = TipoCambio.ToString("C2")
        Else
            Me.txtTipoCambio.Clear()
        End If
    End Sub

#End Region

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.cmbMoneda.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.dgvDetalleOrdenCompra.Focus()
        End If
    End Sub

    Private Sub txtFletes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFletes.LostFocus
        If IsNumeric(Me.txtFletes.Text) Then
            Me.txtIVAFletes.Text = (CType(Me.txtFletes.Text, Decimal) * Iva / 100).ToString("C2")
        Else
            Me.txtIVAFletes.Text = 0D.ToString("C2")
        End If
        Calcular()
    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectedIndexChanged

    End Sub


    Private Sub Mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles Mtb.ButtonClick

    End Sub
    ''****kareli 11/12/2014****
    Private Sub dgvDetalleOrdenCompra_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellValueChanged
        ''Dim Idprod As Integer
        Dim prod As New ClasesNegocio.ProductoGeneralClass
        Dim codprod As Integer
        Try
            ''***kareli 17/12/2014 modificaciones***
            ''If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = clmIdProducto.Index And e.RowIndex >= 0 Then
                ''***kareli 17/12/2014 modificación= se cambió el columnIndex a 1, tenía cero, porque el índice de la columna era 0
                ''**pero se agregó la columna codigo de barras, antes de el idproducto y el índice de la columna ahora es 1.

                codprod = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmIdProducto.Index).Value
                prod.Obtener(codprod)
                ''***Kareli 18/12/2014****
                ''MessageBox.Show("Se mostrará el Último Costo del Producto", "Punto de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                ''***Kareli 18/12/2014****
                ''***Para hacer la comparación del último costo con el nuevo
                Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCodigoBarra.Index).Value = prod.CodigoBarra
                Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value = prod.UltimoCosto
                txtCostoAnterior.Text = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value

                ''kareli 06/01/2015 inicia
                Dim ListaPrecio As New ClasesNegocio.ListaPrecioDetalleClass
                ListaPrecio.Obtener(CodListaPrecios, codprod)
                Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecioVenta.Index).Value = ListaPrecio.PrecioVentaC
                ''Kareli 06/01/2015 termina
                'if then
                ''End if
                ''
                dgvDetalleOrdenCompra.Refresh()
            End If

            


            ''****kareli 19/12/2014***/
            If e.ColumnIndex = clmPrecio.Index And e.RowIndex >= 0 Then
                '' (Carlos 31/12/2014) Se agrega el calculo del importe para asegurar que se envia el porcentaje de iva a la clase para los calculos donde es necesario
                Dim det As ClasesNegocio.OrdenCompraDetalleClass = DirectCast(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem(), ClasesNegocio.OrdenCompraDetalleClass)
                det.CalcularImporte(Iva)
                '' (Carlos 31/12/2014) termina

                ''***** Kareli 06/01/2015 inicia
                ''Se comentan las siguientes líneas porque se agregaron en el if anterior
                ''Dim ListaPrecio As New ClasesNegocio.ListaPrecioDetalleClass
                ''ListaPrecio.Obtener(CodListaPrecios, codprod)
                ''Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecioVenta.Index).Value = ListaPrecio.PrecioVentaC
                ''****Kareli 06/01/2015 termina

                Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmActualizarPrecio.Index).Value = 0

                If Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value <> Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value Then
                    Dim Forma As New FrmCambiaPrecioProducto
                    ''Dim pruebaprecio As Decimal
                    ''Idprod = clmIdProducto.ValueMember
                    Forma.Icon = Me.Icon
                    Dim Producto As New Integralab.ORM.CollectionClasses.ProductoCollection
                    Producto.GetMulti(HC.ProductoFields.CodigoBarra = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCodigoBarra.Index).Value And HC.ProductoFields.Estatus = EstatusEnum.ACTIVO)

                    Forma.CostoUnitarioAnterior = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value
                    Forma.NuevoCostoUnitario = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value
                    If Producto(0).SeAplicaIva = True Then
                        Forma.IvaCUAnterior = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Controlador.ObtenerIVA / 100), "C2")
                        Forma.IvaCUNuevo = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Controlador.ObtenerIVA / 100), "C2")

                        If Producto(0).PorcIeps <> 0 Then
                            Forma.IepsCUAnterior = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Producto(0).PorcIeps / 100), "C2")
                            Forma.IepsCUNuevo = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Producto(0).PorcIeps / 100), "C2")
                            Forma.CUImpuestos = Format(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Controlador.ObtenerIVA / 100)) + (Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Producto(0).PorcIeps / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value), "C2")
                            Forma.CUImpuestosN = Format(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Controlador.ObtenerIVA / 100)) + (Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Producto(0).PorcIeps / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value), "C2")
                        Else
                            Forma.IepsCUAnterior = 0.0
                            Forma.IepsCUNuevo = 0.0
                            'MessageBox.Show(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Controlador.ObtenerIVA / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value).ToString)
                            Forma.CUImpuestos = Format(CDec(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Controlador.ObtenerIVA / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value)), "C2")
                            Forma.CUImpuestosN = Format(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Controlador.ObtenerIVA / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value), "C2")
                        End If


                    Else
                        Forma.IvaCUAnterior = 0.0
                        Forma.IvaCUNuevo = 0.0
                        If Producto(0).PorcIeps <> 0 Then
                            Forma.IepsCUAnterior = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Producto(0).PorcIeps / 100), "C2")
                            Forma.IepsCUNuevo = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Producto(0).PorcIeps / 100), "C2")
                            Forma.CUImpuestos = Format(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Producto(0).PorcIeps / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value), "C2")
                            Forma.CUImpuestosN = Format(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Producto(0).PorcIeps / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value), "C2")
                        Else
                            Forma.IepsCUAnterior = 0.0
                            Forma.IepsCUNuevo = 0.0
                            Forma.CUImpuestos = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value, "C2")
                            Forma.CUImpuestosN = Format(Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value, "C2")
                        End If
                        'Forma.CUImpuestos = Format(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Controlador.ObtenerIVA / 100)) + (Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value * (Producto(0).PorcIeps / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value), "C2")
                        'Forma.CUImpuestosN = Format(((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Controlador.ObtenerIVA / 100)) + (Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value * (Producto(0).PorcIeps / 100)) + Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value), "C2")


                    End If

                    Forma.PrecioVentaActual = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecioVenta.Index).Value
                    If Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value = 0 Then
                        Forma.PorcentajeUtilidad = 0
                    Else
                        'Forma.PorcentajeUtilidad = ((ListaPrecio.PrecioVentaC / Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value) - 1) * 100
                        Forma.PorcentajeUtilidad = ((CDec(Forma.PrecioVentaActual.ToString().Replace("$", "")) / CDec(Forma.CUImpuestos.ToString().Replace("$", "")) - 1) * 100)

                    End If
                    'If Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value = 0 Then
                    '    Forma.PorcentajeUtilidad = 0
                    'Else
                    '    'Forma.PorcentajeUtilidad = ((ListaPrecio.PrecioVentaC / Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value) - 1) * 100
                    '    Forma.PorcentajeUtilidad = ((Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecioVenta.Index).Value / Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value) - 1) * 100

                    'End If

                    ''Kareli 08/01/2015 inicia
                    Forma.ShowDialog()
                    If Forma.DialogResult = Windows.Forms.DialogResult.OK Then
                        'If Forma.txtNuevoPrecio.Text.Trim = "" Then
                        Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecioVenta.Index).Value = Forma.NuevoPrecioVenta
                        'End If
                        Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmActualizarPrecio.Index).Value = 1
                    Else
                        Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmActualizarPrecio.Index).Value = 0
                        Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmPrecio.Index).Value = Me.dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmUltimoCosto.Index).Value
                    End If
                    ''Kareli 08/01/2015 termina

                End If
            End If

            ''****kareli 19/12/2014***/
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso")
        End Try
    End Sub
    ''****kareli 11/12/2014****

    Private Sub frmRecepcionesOrdenesDirectas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        '' No se puede  comentar, porque afecta los tabuladores de los componentes que estan fuera del grid
        'If Not TypeOf Me.ActiveControl Is DataGridView Then Return

        ''Kareli 14/01/2015 inicia
        ''El código comentado es el que inicialmente tenía la forma
        ''Se comentó porque estaba afectando la funcionalidad del datagrid
        'If e.KeyChar = Chr(Keys.Enter) Then
        '    e.Handled = True
        '    SendKeys.Send(Chr(Keys.Tab))
        'End If
        ''El siguiente código yo (kareli) lo escribí
        If Not TypeOf Me.ActiveControl Is DataGridView Then
            If e.KeyChar = Chr(Keys.Enter) Then
                If IsNothing(cmbProveedor.SelectedValue) Or cmbProveedor.SelectedIndex = -1 Then
                    cmbProveedor.SelectedIndex = -1
                    cmbProveedor.Text = "Seleccione un proveedor..."
                    cmbProveedor.Focus()
                    MsgBox("Seleccione un Proveedor")

                    Return
                End If
                e.Handled = True
                SendKeys.Send(Chr(Keys.Tab))
            ElseIf e.KeyChar = Chr(Keys.Tab) Then
                If IsNothing(cmbProveedor.SelectedValue) Or cmbProveedor.SelectedIndex = -1 Then
                    cmbProveedor.SelectedIndex = -1
                    cmbProveedor.Text = "Seleccione un proveedor..."
                    cmbProveedor.Focus()
                    MsgBox("Seleccione un Proveedor")
                    Return
                End If
                e.Handled = True
                SendKeys.Send(Chr(Keys.Tab))
            End If
        Else : Return
        End If
        ''Kareli 14/01/2015 termina

        'If Not TypeOf Me.ActiveControl Is ComboBox Then

        'End If



    End Sub

    Private Sub dgvDetalleOrdenCompra_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellLeave
        ''ValidandoCelda = False
    End Sub

    Private Sub dgvDetalleOrdenCompra_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellEnter
        ''ValidandoCelda = False
    End Sub


    Private Sub dgvDetalleOrdenCompra_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDetalleOrdenCompra.Enter
        If cmbProveedor.SelectedValue IsNot Nothing And cmbProveedor.SelectedValue <> 0 And preguntaporfacturar = False Then
            preguntaporfacturar = True
            Dim colrecep As New ClasesNegocio.RecepcionOrdenCompraCollectionClass
            Dim filtro As New OC.PredicateExpression
            filtro.Add(HC.RecepcionOrdenCompraFields.IdProveedor = CInt(cmbProveedor.SelectedValue))
            filtro.Add(HC.RecepcionOrdenCompraFields.Facturada = 0)
            colrecep.Obtener(filtro)
            If colrecep.Count > 0 Then
                Dim resultado As DialogResult = MessageBox.Show("El proveedor " & cmbProveedor.Text & " cuenta con " & colrecep.Count.ToString() & " compra(s) que no se han facturado, ¿Desea imprimir la relación de las compras?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                Try
                    If resultado = Windows.Forms.DialogResult.Yes Then
                        'Dim cr As New ClasesNegocio.crRecepCompraTck()
                        Windows.Forms.Cursor.Current = Cursors.WaitCursor
                        Dim verReporte As New FrmReportes
                        Dim reporte As New crComprasXFacturarTck
                        Dim dt As New DataTable
                        dt.Columns.Add("FolioRecepcionOrdenCompra")
                        dt.Columns.Add("FechaRecepcion")
                        dt.Columns.Add("Proveedor")
                        dt.Columns.Add("Total")
                        dt.Columns.Add("NoRemision")
                        dt.Columns.Add("Sucursal")
                        '' dt = CollectionHelper.ConvertTo(Of ClasesNegocio.RecepcionOrdenCompraClass)(colrecep)
                        For Each row As ClasesNegocio.RecepcionOrdenCompraClass In colrecep
                            dt.Rows.Add(row.FolioRecepcionOrdenCompra, row.FechaRecepcion, row.proveedor, row.Total, row.NoRemision, row.Sucursal.Descripcion)
                        Next

                        reporte.SetDataSource(dt)
                        reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
                        reporte.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnom)

#If DEBUG Then
                        verReporte.CRV.ReportSource = reporte
                        'Dim RecepcionOrdenCompraC As New RecepcionOrdenCompraCollectionClass
                        'RecepcionOrdenCompraC.Add(Me.RecepcionOrdenCompra)
                        'RecepcionOrdenCompraC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                        'verReporte.CRV.ReportSource = RecepcionOrdenCompraC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                        verReporte.Show()
#End If


                        reporte.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
                        reporte.PrintToPrinter(1, False, 0, 0)

                        Windows.Forms.Cursor.Current = Cursors.Default
                        'verReporte.CRV.PrintOptions = "TICKET"
                        'verReporte.CRV.PrintReport()
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub cmbProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbProveedor.Validating
        ''13/01/2015
        'If IsNothing(Me.cmbProveedor.SelectedValue) Then
        '    e.Cancel = True
        '    MsgBox("Seleccione un Proveedor")
        'End If
        ''13/01/2015
    End Sub

    ''/***kareli 13-01-2015
    Private Sub dgvDetalleOrdenCompra_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleOrdenCompra.EditingControlShowing
        ' Ignoramos otros tipos de controles existentes en las celdas
        '
        If Not TypeOf e.Control Is  _
        DataGridViewComboBoxEditingControl Then Return

        ' Referenciamos el control TextBox subyacente en la celda actual.
        '
        Dim _cellComboBox As DataGridViewComboBoxEditingControl = TryCast(e.Control, DataGridViewComboBoxEditingControl)

        ' Añadimos un controlador de evento.
        AddHandler _cellComboBox.SelectedValueChanged, AddressOf SelectedValueChanged
    End Sub

    Private Sub SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        ' Referenciamos el control ComboBox
        '
        Dim combo As ComboBox = DirectCast(sender, ComboBox)

        If combo.SelectedIndex <> -1 Then
            'MessageBox.Show(combo.SelectedValue.ToString)
            SendKeys.Send(Chr(Keys.Tab))
        End If

        ' Eliminamos el controlador de eventos
        RemoveHandler combo.SelectedValueChanged, AddressOf SelectedValueChanged
    End Sub
    ''/***kareli 13-01-2015

    Private Sub dgvDetalleOrdenCompra_Click(sender As System.Object, e As System.EventArgs) Handles dgvDetalleOrdenCompra.Click
        If IsNothing(Me.cmbProveedor.SelectedValue) Then
            'e.Cancel = True
            MsgBox("Seleccione un Proveedor")
            cmbProveedor.SelectedIndex = -1
            cmbProveedor.Text = "Seleccione un Proveedor..."
            cmbProveedor.Focus()
        Else

        End If
    End Sub

    Private Sub frmRecepcionesOrdenesDirectas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If Me.dgvDetalleOrdenCompra.CurrentRow IsNot Nothing Then
            If e.KeyCode = Keys.F1 AndAlso Me.dgvDetalleOrdenCompra.CurrentRow.Cells(clmCodigoBarra.Index).Selected Then
                'endedit = True
                'dgvDetalleOrdenCompra_KeyDown(dgvDetalleOrdenCompra, e)
                'endedit = False
                If dgvDetalleOrdenCompra.CurrentRow.Cells(clmCodigoBarra.Index).Selected Then
                    e.Handled = True
                    Dim ventana As New FrmBuscarProductos
                    ventana.dgvProductosReg.Columns(ventana.clmExistencia.Index).Visible = False
                    'ventana.Edicion = True
                    ventana.txtDescripcion.Focus()
                    'ventana.txtDescripcion.Text = valorcelda
                    ventana.txtDescripcion.Text = dgvDetalleOrdenCompra.CurrentRow.Cells(clmCodigoBarra.Index).EditedFormattedValue.ToString
                    'ventana.txtDescripcion.Text = dgvDetalleOrdenCompra.CurrentRow.Cells(clmCodigoBarra.Index).Value.ToString
                    If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Dim prod As ClasesNegocio.ProductoGeneralClass = ventana.ProductosSeleccionados.Item(0)
                        endedit = True
                        e.Handled = True
                        SendKeys.Send(Chr(Keys.Enter))
                        Application.DoEvents()
                        dgvDetalleOrdenCompra.CurrentRow.Cells(clmIdProducto.Index).Value = prod.Codigo
                        dgvDetalleOrdenCompra.CurrentRow.Cells(clmCodigoBarra.Index).Value = prod.CodigoBarra
                        SendKeys.Send(Chr(Keys.Enter))
                        SendKeys.Send(Chr(Keys.Enter))
                        endedit = False
                    End If
                End If
            End If

        End If

        If Not TypeOf Me.ActiveControl Is DataGridView Then
            If e.KeyCode = Keys.Tab Then
                If IsNothing(cmbProveedor.SelectedValue) Or cmbProveedor.SelectedIndex = -1 Then
                    cmbProveedor.SelectedIndex = -1
                    cmbProveedor.Text = "Seleccione un proveedor..."
                    cmbProveedor.Focus()
                    MsgBox("Seleccione un Proveedor")
                    Return
                Else
                    e.SuppressKeyPress = True
                End If
            End If
        Else : Return
        End If

    End Sub

 
    Private Sub dgvDetalleOrdenCompra_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.RowEnter
        If dgvDetalleOrdenCompra.Focused Then
            If IsNothing(cmbProveedor.SelectedValue) Or cmbProveedor.SelectedIndex = -1 Then
                cmbProveedor.SelectedIndex = -1
                cmbProveedor.Text = "Seleccione un proveedor..."
                cmbProveedor.Focus()
                MsgBox("Seleccione un Proveedor")
                Return
            End If
        End If
    End Sub

    
    'Private Sub dgvDetalleOrdenCompra_CellBeginEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalleOrdenCompra.CellBeginEdit
    '    valorcelda = dgvDetalleOrdenCompra.Rows(e.RowIndex).Cells(clmCodigoBarra.Index).Value
    'End Sub

    Private Sub frmRecepcionesOrdenesDirectas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If cargacodsucursal = False Then
            Me.Close()
            Me.Dispose()
        End If

        If carganomimpresora = False Then
            Me.Close()
            Me.Dispose()
        End If


    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If cmbProveedor.SelectedValue <> 0 And cmbProveedor.SelectedValue IsNot Nothing Then
            preguntaporfacturar = False
        End If
    End Sub

End Class


