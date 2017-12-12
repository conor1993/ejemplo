Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmRecepcionesOrdenesDirectasMeat
    Private Orden As ClasesNegocio.OrdenCompraClass
    Dim RecepcionOrdenCompra As RecepcionOrdenCompraClass
    Dim RecepcionOrdenCompraDetalle As RecepcionOrdenCompraDetClass
    Dim SucColeccion As New SucursalCollectionClass
    'Dim Almacen As New AlmacenCatalogoClass
    Dim InvMovAlmacenCab As AlmacenGeneral.MovimientoAlmacenClass
    Dim InvMovAlmacenDet As AlmacenGeneral.MovimientoAlmacenDetalleClass
    Dim InvAlmacen As AlmacenGeneral.InventarioAlmacenClass
    Dim Almacen As ClasesNegocio.AlmacenClass
    Dim Modo As Integer
    Public _FolioAlm As String
    Dim TipoCambio As Decimal

#Region "Load"

    Private Sub frmRecepcionesOrdenesDirectas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.Mtb.ToolBarButtonStatus = tbEstados
            Me.Mtb.sbCambiarEstadoBotones("Cancelar")

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            MonedaTC.Obtener()

            dgvDetalleOrdenCompra.AutoGenerateColumns = False

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
                Me.Almacen = New ClasesNegocio.AlmacenClass
                Almacen.Obtener(Me.RecepcionOrdenCompra.AlmacenId)

                If Me.cmbAlmacen.SelectedValue Is Nothing Then
                    MessageBox.Show("No se puede realizar la cancelación de la Recpción de Orden Compra debido a que el Almacén:" & Almacen.Descripcion & " esta cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If
                'asigna el folio de movimiento de almacen
                _FolioAlm = AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, trans)
                'guardar Movimientos de almacen cabecero
                InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenClass
                If Not Me.GuardarMovAlmacenCab() Then
                    trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                trans.Add(InvMovAlmacenCab.Entidad)

                If Not Me.InvMovAlmacenCab.Entidad.Save Then
                    trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                'Guardar Movimientos de Almacen Detalle

                Dim i As Integer = 0
                For Each det As RecepcionOrdenCompraDetClass In Me.RecepcionOrdenCompra.Detalles
                    i += 1
                    Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenDetalleClass
                    Me.InvMovAlmacenDet.IdAlmacen = Me.cmbAlmacen.SelectedValue
                    Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                    ' Me.InvMovAlmacenDet.EmpresaId = det.EmpresaId
                    Me.InvMovAlmacenDet.IdProducto = det.IdProducto
                    Me.InvMovAlmacenDet.Cantidad = det.Cantidad
                    Me.InvMovAlmacenDet.Costo = det.OrdenCompraDetalle.Precio
                    Me.InvMovAlmacenDet.Descuento = det.OrdenCompraDetalle.Descuento
                    Me.InvMovAlmacenDet.FechaMovimiento = Now
                    Me.InvMovAlmacenDet.Indice = i
                    'Me.InvMovAlmacenDet.DescripcionMov = TipoMovClass.Nombre

                    'If det.OrdenDet.Producto.SeAplicaIva = SiNoEnum.SI Then
                    '    Me.InvMovAlmacenDet. = (det.Cantidad * det.OrdenDet.Precio) * (ObtenerIVA() / 100)
                    'End If

                    If Not Me.InvMovAlmacenDet.Guardar(trans) Then
                        Cancelar = True
                        trans.Rollback()
                        Exit Sub
                    End If
                Next

                'If Not GuardarSalida(trans) Then
                '    Cancelar = True
                '    trans.Rollback()
                '    Exit Sub
                'End If

                Me.RecepcionOrdenCompra.FolioMovimientoAlmCan = _FolioAlm
                Me.RecepcionOrdenCompra.UsuarioCancelacionId = Controlador.Sesion.MiUsuario.Usrndx

                If Me.RecepcionOrdenCompra.Borrar(trans) Then
                    trans.Commit()
                    MessageBox.Show("La recepcion de orden de compra ha sido Cancelada", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickBuscar
        Try
            Dim Forma As New ComBusquedaRecepcionOrden(True)
            Forma.Icon = Me.Icon
            If Forma.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Dim Folio As String = Forma.DataGridView1.SelectedRows(0).Cells("idRecepcionOrdenCompra").Value
                Dim Codigo As Integer = Forma.DataGridView1.SelectedRows(0).Cells("clmIdRecepcion").Value
                Dim FolioOrden As Integer = Forma.DataGridView1.SelectedRows(0).Cells("clmIdOrdenCompra").Value
                Me.RecepcionOrdenCompra = New RecepcionOrdenCompraClass
                Me.RecepcionOrdenCompra.Obtener(Codigo)
                PonerDatos()
                Me.Orden = New OrdenCompraClass
                Orden.Obtener(FolioOrden)

                Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
                Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

                'cmbMoneda.SelectedValue = Orden.Moneda.Codigo
                'txtTipoCambio.Text = Orden.TipoCambio.ToString("C2")
                cmbProveedor.SelectedValue = Orden.Proveedor.Codigo
                cmbPlaza.SelectedValue = Orden.Sucursal.Plaza.Codigo
                Me.txtFletes.Text = Orden.ImpteIvaFlete.ToString("C2")
                Me.txtIVAFletes.Text = Orden.IvaFlete.ToString("C2")

                Me.txtDescuento.Text = RecepcionOrdenCompra.Descuento.ToString("C2")
                Me.txtIVA.Text = RecepcionOrdenCompra.IVA.ToString("C2")
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
                ' CalcularTotal()
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

        Try
            If Not Me.Validar OrElse Not Me.Validate() Then
                Cancelar = True
                Exit Sub
            End If

            'Guardar la Orden de Compra
            GuardarOrden()

            For j As Integer = 0 To Orden.Detalle.Count - 1
                Dim OrdenDet As OrdenCompraDetalleClass = Orden.Detalle(j)
                Dim Imp As Decimal = OrdenDet.Precio * OrdenDet.CantidadOrdenada
                'OrdenDet.Descuento = Imp * OrdenDet.Descuento / 100

                OrdenDet.Renglon = j + 1
                OrdenDet.IdMoneda = Orden.IdMoneda
                OrdenDet.TipoCambio = Orden.TipoCambio
                OrdenDet.CantPendiente = 0D
                OrdenDet.CantRecibida = OrdenDet.CantidadOrdenada
                OrdenDet.CantidadSolicitada = OrdenDet.CantidadOrdenada
                OrdenDet.Estatus = EstatusEnum.ACTIVO
                OrdenDet.Descuento = Convert.ToDecimal(Replace(txtDescuento.Text, "$", ""))
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
            InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenClass

            If Not GuardarMovAlmacenCab() Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            Trans.Add(Me.InvMovAlmacenCab.Entidad)

            If Not Me.InvMovAlmacenCab.Entidad.Save Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            'Se guarda el Cabecero de la Recepcion
            Me.txtFolio.Text = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
            Guardar()
            If Not Me.RecepcionOrdenCompra.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            Dim IdProducto As Integer
            Dim IdAlmacen As Integer
            Dim i As Integer = 0
            Dim divisor As Integer = 0
            Dim PrecioProd As Decimal = 0D
            Dim CantRecibir As Decimal = 0D
            Dim CostoPromedio As Decimal = 0D
            'Guardar Movimientos de Almacen Detalle
            For Each Det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle

                If Det.CantidadOrdenada > 0 Then
                    i = i + 1
                    IdProducto = Det.Producto.Codigo
                    IdAlmacen = Me.cmbAlmacen.SelectedValue
                    Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenDetalleClass

                    Me.InvMovAlmacenDet.IdAlmacen = IdAlmacen
                    Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                    Me.InvMovAlmacenDet.IdProducto = Det.Producto.Codigo
                    Me.InvMovAlmacenDet.Cantidad = Det.CantRecibida
                    Me.InvMovAlmacenDet.Costo = Det.Precio
                    Me.InvMovAlmacenDet.Descuento = Det.Descuento
                    Me.InvMovAlmacenDet.Indice = i
                    'Me.InvMovAlmacenDet.CostoPromedio = Det.Precio
                    'Me.InvMovAlmacenDet.CostoPromedio = (Det.Precio)
                    'If Det.Producto.SeAplicaIva = SiNoEnum.SI Then

                    '    Me.InvMovAlmacenDet.IVA = (Det.CantPendiente * Det.Precio) * (ObtenerIVA(Controlador.Sesion.Empndx) / 100)
                    'End If
                    If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If
                End If

                'Guardar el detalle de la recepcion
                Me.RecepcionOrdenCompraDetalle = New RecepcionOrdenCompraDetClass

                Me.RecepcionOrdenCompraDetalle.IdRecepcionOrdenCompra = Me.RecepcionOrdenCompra.IdRecepcionOrdenCompra
                Me.RecepcionOrdenCompraDetalle.IdProducto = IdProducto
                Me.RecepcionOrdenCompraDetalle.Cantidad = Det.CantRecibida
                Me.RecepcionOrdenCompraDetalle.Costo = Det.Precio
                Me.RecepcionOrdenCompraDetalle.Descuento = Det.Descuento
                Me.RecepcionOrdenCompraDetalle.IVA = Det.Iva
                ' Me.RecepcionOrdenCompraDetalle.IVA = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(Me.clmIva.Index).Value
                Me.RecepcionOrdenCompraDetalle.Total = Me.dgvDetalleOrdenCompra.Rows(i - 1).Cells(clmImporte.Index).Value
                If Not RecepcionOrdenCompraDetalle.Guardar(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If
            Next

            Trans.Commit()
            MessageBox.Show("Se guardo la Recepcion de Compra Directa con el Folio: " & Me.txtFolio.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Limpiar()
            Me.DesHabilitar()

            'Me.RecepcionOrdenCompraC.Add(Me.RecepcionOrdenCompra)
            'Imprimir()
        Catch ex As Exception
            Cancelar = True
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

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
        Me.Limpiar()
    End Sub

    Private Sub Mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickNuevo
        Try
            Me.Limpiar()
            Me.Habilitar()
            Me.cmbPlaza.Focus()
            Me.Orden = New OrdenCompraClass
            Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

            RecepcionOrdenCompra = New RecepcionOrdenCompraClass
            Me.RecepcionOrdenCompraDetalle = New RecepcionOrdenCompraDetClass

            Modo = 1 'Modo inserccion
            'Me.RecepcionOrdenCompraC.Clear()
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
        Me.txtImporteTotal.Text = 0
        Me.txtDescuento.Text = 0
        Me.txtSubTotal.Text = 0
        Me.txtFletes.Text = 0
        Me.txtIVAFletes.Text = 0
        Me.txtIVA.Text = 0
        Me.txtTotal.Text = 0

        Me.txtImportePesos.Text = 0
        Me.txtDescuentoPesos.Text = 0
        Me.txtSubTotalPesos.Text = 0
        Me.txtFletesPesos.Text = 0
        Me.txtIVAFletesPesos.Text = 0
        Me.txtIvaPesos.Text = 0
        Me.txtTotalPesos.Text = 0
    End Sub

    Sub Limpiar()
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbMoneda.SelectedIndex = -1
        Me.cmbProveedor.SelectedIndex = -1
        Me.cmbAlmacen.SelectedIndex = -1
        Me.txtFolio.Text = ""
        'Me.txtFolioRecepcion.Text = 0
        Me.txtNoFactura.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtSumaRecibir.Text = 0
        ' Me.txtSumaOrdenada.Text = 0
        'Me.txtSumaRecibidas.Text = 0
        Me.txtTipoCambio.Text = 0
        RemoveHandler dgvDetalleOrdenCompra.RowValidating, AddressOf dgvDetalleOrdenCompra_RowValidating
        Me.dgvDetalleOrdenCompra.DataSource = Nothing
        AddHandler dgvDetalleOrdenCompra.RowValidating, AddressOf dgvDetalleOrdenCompra_RowValidating
        ' Me.dgvDetalleOrdenCompra.DataSource = Nothing
        Me.lblEstatus.Visible = False
        Me.GrpImportesPesos.Visible = False
        Me.DtpFecha.Value = Now

        LimpiarMontos()
    End Sub

    Sub DesHabilitar()
        Me.cmbPlaza.Enabled = False
        Me.cmbSucursal.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.cmbMoneda.Enabled = False

        Me.txtNoFactura.Enabled = False
        Me.dgvDetalleOrdenCompra.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.cmbAlmacen.Enabled = False
        Me.txtFletes.ReadOnly = True
    End Sub

    Sub Habilitar()
        Me.cmbAlmacen.Enabled = True
        Me.cmbPlaza.Enabled = True
        Me.cmbSucursal.Enabled = True

        Me.txtNoFactura.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.dgvDetalleOrdenCompra.Enabled = True
        Me.cmbMoneda.Enabled = True
        Me.cmbProveedor.Enabled = True
        Me.txtFletes.ReadOnly = False
    End Sub

    Sub Guardar()
        Try
            Me.RecepcionOrdenCompra.IdOrdenCompra = Orden.IdOrdenCompra
            Me.RecepcionOrdenCompra.IdSucursal = Me.cmbSucursal.SelectedValue
            Me.RecepcionOrdenCompra.AlmacenId = Me.cmbAlmacen.SelectedValue
            Me.RecepcionOrdenCompra.FechaRecepcion = Now
            Me.RecepcionOrdenCompra.FechaCancelacion = "01/01/1900"
            Me.RecepcionOrdenCompra.Observaciones = Me.txtObservaciones.Text
            Me.RecepcionOrdenCompra.FolioMovimientoAlm = _FolioAlm
            Me.RecepcionOrdenCompra.FolioMovimientoAlmCan = ""
            Me.RecepcionOrdenCompra.UsuarioAltaId = Controlador.Sesion.Usrndx
            Me.RecepcionOrdenCompra.NumFactura = Me.txtNoFactura.Text
            Me.RecepcionOrdenCompra.SubTotal = Me.txtSubTotal.Text
            Me.RecepcionOrdenCompra.Descuento = Me.txtDescuento.Text
            Me.RecepcionOrdenCompra.IVA = Me.txtIVA.Text
            Me.RecepcionOrdenCompra.Total = Me.txtTotal.Text
            Me.RecepcionOrdenCompra.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            Me.RecepcionOrdenCompra.Observaciones_Cancelacion = ""
            Me.RecepcionOrdenCompra.EsDirecta = True

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

    Private Function GuardarSalida(ByRef Trans As HC.Transaction) As Boolean
        Try
            Dim IdAlmacen As Integer = Me.RecepcionOrdenCompra.AlmacenId
            Dim IdProducto As Integer
            Dim Precio As Decimal
            Dim CostoPromedio As Decimal
            Dim Divisor As Decimal

            ' se lee los registros del detalle de la orden de compra

            For Each det As ClasesNegocio.RecepcionOrdenCompraDetClass In Me.RecepcionOrdenCompra.Detalles
                Precio = det.OrdenCompraDetalle.Precio
                IdProducto = det.IdProducto
                Dim CantSalir As Integer = det.Cantidad
                InvAlmacen = New AlmacenGeneral.InventarioAlmacenClass
                'Se buscan los movimientos del producto en el mes actual
                If InvAlmacen.Obtener(IdAlmacen, IdProducto, Me.RecepcionOrdenCompra.FechaRecepcion.Year, Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM")) Then

                    Divisor = Me.InvAlmacen.CantidadExistencia - CantSalir
                    If Divisor = 0 Then
                        CostoPromedio = 0
                    Else
                        CostoPromedio = ((Me.InvAlmacen.CantidadExistencia * Me.InvAlmacen.CostoPromedio) - (CantSalir * Precio)) / _
                                             Divisor
                    End If

                    InvAlmacen.CantidadExistencia = InvAlmacen.CantidadExistencia - CantSalir
                    InvAlmacen.CantidadSalidas = CantSalir
                    InvAlmacen.CostoPromedio = CostoPromedio
                    If InvAlmacen.CantidadExistencia = 0 Then
                        InvAlmacen.UltimoCosto = 0
                        InvAlmacen.FechaUltimoCosto = #1/1/1900#
                    End If

                    If Not InvAlmacen.Guardar(Trans) Then
                        Return False
                    End If
                Else
                    Dim InvCol As New CC.InventarioAlmacenCollection
                    Dim Filtro As New OC.PredicateExpression
                    'Se obtiene el ultimo movimiento del producto en el almacen 
                    Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = IdAlmacen And _
                              HC.InventarioAlmacenFields.ProductoId = IdProducto)
                    Dim Orden As New OC.SortExpression
                    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                    InvCol.GetMulti(Filtro, 1, Orden)

                    Dim AuxInvEntity As EC.InventarioAlmacenEntity
                    If InvCol.Count > 0 Then
                        AuxInvEntity = InvCol(0)
                    Else
                        MessageBox.Show("No se encontro el producto en el almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End If
                    Dim CantExistencias As Decimal = AuxInvEntity.CantidadExistencia
                    Divisor = CantExistencias - CantSalir
                    If Divisor = 0 Then
                        CostoPromedio = 0
                    Else
                        CostoPromedio = ((Me.InvAlmacen.CantidadExistencia * Me.InvAlmacen.CostoPromedio) - (CantSalir * Precio)) / _
                                             Divisor
                    End If
                    Dim InvEntity As New EC.InventarioAlmacenEntity
                    With InvEntity
                        ' .EmpresaId = AuxInvEntity.EmpresaId
                        .AlmacenId = AuxInvEntity.AlmacenId
                        .ProductoId = AuxInvEntity.ProductoId
                        .Año = Now.Year
                        .Mes = Now.Month
                        .CantidadExistencia = CantExistencias - CantSalir
                        .CantidadEntrada = 0
                        .CantidadSalidas = CantSalir
                        .CostoPromedio = CostoPromedio
                        .CostoPromedio = CostoPromedio
                        .UltimoCosto = AuxInvEntity.UltimoCosto
                        .FechaUltimoCosto = AuxInvEntity.FechaUltimoCosto
                    End With
                    Trans.Add(InvEntity)
                    If Not InvEntity.Save Then
                        Return False
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function GuardarMovAlmacenCab() As Boolean
        Try
            Dim ConfigAlm As New CC.InventarioConfiguracionCollection
            ConfigAlm.GetMulti(Nothing, 0, Nothing)

            If ConfigAlm.Count < 1 Then
                MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Me.InvMovAlmacenCab.IdAlmacen = Me.cmbAlmacen.SelectedValue
            Me.InvMovAlmacenCab.FolioMovimientoAlmacen = _FolioAlm
            Me.InvMovAlmacenCab.FechaMovimiento = Now

            If Modo = 1 Then
                If IsDBNull(ConfigAlm(0).ExCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
                    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
                Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
            ElseIf Modo = 2 Then
                If IsDBNull(ConfigAlm(0).SxDevolucionCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
                    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
                Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
            End If
            ' Me.InvMovAlmacenCab.ValorMovimientoId = ""
            Me.InvMovAlmacenCab.Origen = "COMPRAS"
            Me.InvMovAlmacenCab.Referencia = Me.txtFolio.Text
            Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.InvMovAlmacenCab.EstatusContabilizado = 0
            Me.InvMovAlmacenCab.CostoTotal = CDec(Me.txtTotal.Text)
            Return True
            ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
            'Me.InvMovAlmacenCab.PolizaContabilidad = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub Imprimir()
        Try
            Dim verReporte As New FrmReportes
            Dim RecepcionOrdenCompraC As New RecepcionOrdenCompraCollectionClass
            RecepcionOrdenCompraC.Add(Me.RecepcionOrdenCompra)
            verReporte.CRV.ReportSource = RecepcionOrdenCompraC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            verReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            If Not Me.cmbAlmacen.SelectedIndex > -1 Then
                MessageBox.Show("Especifique el Almacen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbAlmacen.Focus()
                Return False
            End If

            If Not Me.cmbPlaza.SelectedIndex > -1 Then
                MsgBox("Seleccione una Plaza", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbPlaza.SelectedIndex = 0
                Me.cmbPlaza.Focus()
                Return False
            End If

            If Not Me.cmbSucursal.SelectedIndex > -1 Then
                MsgBox("Seleccione una Sucursal", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbSucursal.SelectedIndex = 0
                Me.cmbSucursal.Focus()
                Return False
            End If

            If Not Me.cmbProveedor.SelectedIndex > -1 Then
                MsgBox("Seleccione un Proveedor", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbProveedor.SelectedIndex = 0
                Me.cmbProveedor.Focus()
                Return False
            End If

            If Not Me.cmbMoneda.SelectedIndex > -1 Then
                MsgBox("Seleccione el Tipo de Moneda", MsgBoxStyle.Exclamation, "Aviso")
                Me.cmbMoneda.SelectedIndex = 0
                Me.cmbMoneda.Focus()
                Return False
            End If

            If Me.txtNoFactura.Text = "" Then
                MsgBox("Ingrese el Número de Factura", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtNoFactura.Focus()
                Return False
            End If

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
        Me.cmbMoneda.SelectedValue = Me.RecepcionOrdenCompra.OrdenCompra.IdMoneda
        Me.txtTipoCambio.Text = Me.RecepcionOrdenCompra.OrdenCompra.TipoCambio.ToString("C2")
    End Sub

    Sub CalcularSuma()
        Dim Suma As Decimal = 0D

        For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
            If Not Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantOrd.Index).Value Is Nothing Then
                Suma += Decimal.Parse(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmCantOrd.Index).Value.ToString)
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
        Dim Total As Decimal = 0D

        For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
            If Not Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmPrecio.Index).Value Is Nothing AndAlso Not Me.dgvDetalleOrdenCompra.Rows(i).Cells(clmCantOrd.Index).Value Is Nothing Then
                Dim Imp As Decimal = CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmPrecio.Index).Value, Decimal) * CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(clmCantOrd.Index).Value, Decimal)

                Importe += Imp

                If Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value IsNot Nothing Then
                    Descuento += Imp * CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value, Decimal) / 100
                End If
                Iva += CType(Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIva.Index).Value, Decimal)
            End If
        Next
        SubTotal = Importe - Descuento

        If IsNumeric(txtFletesPesos.Text) Then
            Flete = CType(txtFletes.Text, Decimal)
        End If

        If IsNumeric(txtIVAFletesPesos.Text) Then
            FleteIva = CType(txtIVAFletes.Text, Decimal)
        End If
        Total = SubTotal + Iva + Flete + FleteIva

        txtImporteTotal.Text = Importe.ToString("C2")
        txtDescuento.Text = Descuento.ToString("C2")
        txtSubTotal.Text = SubTotal.ToString("C2")
        txtIVA.Text = Iva.ToString("C2")
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
        If e.ColumnIndex = clmCantOrd.Index OrElse e.ColumnIndex = clmPrecio.Index OrElse e.ColumnIndex = clmDescuento.Index Then
            CType(dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem, OrdenCompraDetalleClass).CalcularImporte(Controlador.ObtenerIVA)
            Calcular()
            dgvDetalleOrdenCompra.Refresh()
        End If
    End Sub

    Private Sub dgvDetalleOrdenCompra_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalleOrdenCompra.DataError

    End Sub

    Private Sub dgvDetalleOrdenCompra_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalleOrdenCompra.RowValidating
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

        Dim OrdenDetalle As OrdenCompraDetalleClass = CType(dgvDetalleOrdenCompra.Rows(e.RowIndex).DataBoundItem, OrdenCompraDetalleClass)

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
            MessageBox.Show("Debe especificar el precio", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub dgvDetalleOrdenCompra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvDetalleOrdenCompra.KeyDown
        If dgvDetalleOrdenCompra.CurrentRow.Index <> dgvDetalleOrdenCompra.NewRowIndex Then
            If e.KeyCode = Keys.Delete Then
                If MessageBox.Show("Se eliminara el detalle, ¿esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    dgvDetalleOrdenCompra.Rows.RemoveAt(dgvDetalleOrdenCompra.CurrentRow.Index)
                    Calcular()
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

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.DtpFecha.Focus()
            End If
            If e.KeyCode = Keys.F12 Then
                Me.SucursalC.Obtener()
                Me.cmbSucursal.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbAlmacen_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbAlmacen.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.AlmacenC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Me.cmbAlmacen.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedValueChanged
        LimpiarMontos()

        If cmbAlmacen.SelectedValue IsNot Nothing Then
            clmIdProducto.DisplayMember = "Descripcion"
            clmIdProducto.ValueMember = "Codigo"
            clmIdProducto.DataSource = CType(cmbAlmacen.SelectedItem, AlmacenClass).CatalogoProductos
        Else
            clmIdProducto.DataSource = Nothing
        End If
    End Sub

    Private Sub cmbProveedor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProveedor.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.ProveedorC.Obtener(CondicionEnum.ACTIVOS)
                Me.cmbProveedor.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.cmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
                Me.cmbProveedor.Focus()
            Else
                Me.cmbAlmacen.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbProveedor.ValueMember = "IDProveedor"
            Me.cmbProveedor.DataSource = ProveedorC
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.SelectedIndex = -1
            Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        End If
    End Sub

    Private Sub cmbMoneda_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbMoneda.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmbProveedor.Focus()
            End If
            If e.KeyCode = Keys.F12 Then
                MonedaTC.Obtener()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
            Me.txtIVAFletes.Text = (CType(Me.txtFletes.Text, Decimal) * Controlador.ObtenerIVA / 100).ToString("C2")
        Else
            Me.txtIVAFletes.Text = 0D.ToString("C2")
        End If
        Calcular()
    End Sub

End Class