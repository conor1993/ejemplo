
Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ComRecepcionOrdenesCompra

    Private Orden As ClasesNegocio.OrdenCompraClass
    ''' <summary>
    '''  
    ''' </summary>
    ''' <remarks></remarks>
    Private OrdenDet As New ClasesNegocio.OrdenCompraDetalleClass
    Dim RecepcionOrdenCompra As RecepcionOrdenCompraClass
    Dim RecepcionOrdenCompraDetalle As RecepcionOrdenCompraDetClass
    'Dim Almacen As New AlmacenCatalogoClass
    Dim InvMovAlmacenCab As AlmacenGeneral.MovimientoAlmacenClass
    Dim InvMovAlmacenDet As New AlmacenGeneral.MovimientoAlmacenDetalleClass
    Dim TipoMovClass As TipoMovimientoAlmacenClass
    Dim InvAlmacen As AlmacenGeneral.InventarioAlmacenClass
    Dim InvAlmacenConsulta As AlmacenGeneral.InventarioAlmacenClass
    Dim Almacen As ClasesNegocio.AlmacenClass
    Dim Modo As Integer
    Public _FolioAlm As String
    Dim UltimaTeclaProveedor As DateTime
    Dim TipoMovId As Integer
    Dim Bandera As Boolean 'para mostrar el detalle de la orden de compra y evitar el error del metodo rowenter al asignar por primera vez una orden de compra
    Dim Plaza As PlazaClass
    Dim Sucursal As SucursalClass
    Dim CodigoOrdenCompra As Integer
    Dim BanderaBusqueda As Boolean

    Private Sub ComRecepcionOrdenesCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim a As New EC.MfacEmbarquesCabEntity

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

            Me.AlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, False)
            MonedaTC.Obtener()
            Me.SucursalC.Obtener(CondicionEnum.ACTIVOS)

            Me.Limpiar()
            Me.DesHabilitar()
            'Me.LlenaCombox()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Key Press"
    Private Sub txtNoFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbProveedor.Focus()
        End If
    End Sub

    Private Sub cmbAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAlmacen.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbAlmacen.Focus()
        End If
    End Sub
#End Region

#Region "Metodos"

    Sub Limpiar()
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione una Plaza..."
        Me.cmbSucursal.SelectedIndex = -1
        Me.cmbSucursal.Text = "Seleccione una Sucursal..."
        Me.cmbProveedor.SelectedIndex = -1
        Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un Alamcen..."
        Me.cmbMoneda.SelectedIndex = -1
        Me.txtFolioOrden.Text = 0
        Me.txtFolioRecepcion.Text = 0
        Me.txtDescuento.Text = 0
        Me.txtImporteTotal.Text = 0
        Me.txtNoFactura.Text = 0
        Me.txtIVA.Text = 0
        Me.txtObservaciones.Text = ""
        Me.txtSubTotal.Text = 0
        Me.txtSumaRecibir.Text = 0
        Me.txtSumaOrdenada.Text = 0
        Me.txtSumaRecibidas.Text = 0
        Me.txtTipoCambio.Text = 0
        Me.txtTotal.Text = 0
        Me.dgvDetalleOrdenCompra.Rows.Clear()
        Me.dgvDetalleOrdenCompra.DataSource = Nothing
        Me.dgvOrdenCompra.Rows.Clear()
        Me.dgvOrdenCompra.DataSource = Nothing
        Me.lblEstatus.Visible = False
        Me.GrpImportesPesos.Visible = False
        Me.txtImportePesos.Text = 0
        Me.txtDescuentoPesos.Text = 0
        Me.txtSubTotal.Text = 0
        Me.txtIvaPesos.Text = 0
        Me.txtTotalPesos.Text = 0
        Me.DtpFecha.Value = Now
        BanderaBusqueda = False
    End Sub

    Sub DesHabilitar()
        ' Me.BtnBuscar.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.cmbPlaza.Enabled = False
        Me.cmbSucursal.Enabled = False
        Me.cmbAlmacen.Enabled = False
        'Me.txtFolioOrden.Enabled = False
        'Me.txtFolioRecepcion.Enabled = False
        'Me.DtpFecha.Enabled = False
        Me.txtNoFactura.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.dgvDetalleOrdenCompra.Enabled = False
    End Sub

    Sub Habilitar()
        Me.cmbPlaza.Enabled = True
        ' Me.BtnBuscar.Enabled = True
        ' Me.cmbProveedor.Enabled = True
        ' Me.cmbSucursal.Enabled = True
        ' Me.cmbAlmacen.Enabled = True        
        ' Me.txtNoFactura.Enabled = True
        ' Me.txtObservaciones.Enabled = True
        ' Me.dgvDetalleOrdenCompra.Enabled = True
    End Sub

    Sub Guardar()

        Me.RecepcionOrdenCompra.IdOrdenCompra = Me.CodigoOrdenCompra
        Me.RecepcionOrdenCompra.idSucursal = Me.cmbSucursal.SelectedValue
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
        Me.RecepcionOrdenCompra.Facturada = False

    End Sub

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
                If Not ConfigAlm(0).ExCompra.HasValue Then
                    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If

                Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
            ElseIf Modo = 2 Then
                If Not ConfigAlm(0).SxDevolucionCompra.HasValue Then
                    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
                Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
            End If
            ' Me.InvMovAlmacenCab.ValorMovimientoId = ""
            Me.InvMovAlmacenCab.Origen = "COMPRAS"
            Me.InvMovAlmacenCab.Referencia = Me.txtFolioRecepcion.Text
            Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.InvMovAlmacenCab.EstatusContabilizado = 0
            Me.InvMovAlmacenCab.CostoTotal = CDec(Me.txtTotal.Text.Replace("$", ""))
            TipoMovId = Me.InvMovAlmacenCab.IdTipoMovimiento
            Return True
            ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
            'Me.InvMovAlmacenCab.PolizaContabilidad = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub Imprimir()
        Try
            Dim verReporte As New FrmReportes
            verReporte.CRV.ReportSource = Me.RecepcionOrdenCompraC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            verReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Empresa.Nombre)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.cmbAlmacen.SelectedValue = Nothing Then
                MessageBox.Show("Especifique el Almacen", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbAlmacen.Focus()
                Return False
                Exit Function
            End If
            'If Me.txtFolioOrden.Text = "0" Then
            '    MessageBox.Show("Presones el boton Buscar Orden de Compra para Agregar una Orden de compra", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.BtnBuscar.Focus()
            '    Return False
            '    Exit Function
            'End If

            Dim Encuentra As Boolean = False
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                If Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmRecibir").Value > 0 Then
                    Encuentra = True
                    Exit For
                End If
            Next
            If Not Encuentra Then
                MessageBox.Show("Especifique la Cantidad de Productos a Recibir", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Sub PonerDatos()
        Me.txtFolioRecepcion.Text = Me.RecepcionOrdenCompra.FolioRecepcionOrdenCompra
        Me.txtFolioOrden.Text = Me.RecepcionOrdenCompra.OrdenCompra.FolioOrdenCompra
        'Me.cmbSucursal.SelectedValue = Me.RecepcionOrdenCompra.OrdenCompra.IdSucursal
        'Me.cmbProveedor.SelectedValue = Me.RecepcionOrdenCompra.OrdenCompra.IdProveedor
        Me.DtpFecha.Text = Me.RecepcionOrdenCompra.FechaRecepcion
        'Me.cmbSucursal.SelectedValue = Me.RecepcionOrdenCompra.idSucursal
        Me.txtObservaciones.Text = Me.RecepcionOrdenCompra.Observaciones
        Me.txtObservaciones.Enabled = False
        Me.txtNoFactura.Text = Me.RecepcionOrdenCompra.NumFactura
        Me.lblEstatus.Visible = True
        Me.lblEstatus.Text = Me.RecepcionOrdenCompra.Estatus.ToString
    End Sub

    Sub CalcularSuma()
        Try
            Me.txtSumaRecibir.Text = 0
            Me.txtSumaRecibidas.Text = 0
            Me.txtSumaOrdenada.Text = 0
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                If Not Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmrecibir").Value = Nothing Then
                    Me.txtSumaRecibir.Text += Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmrecibir").Value
                End If
                If Not Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmCantOrdenada").Value = Nothing Then
                    Me.txtSumaOrdenada.Text += Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmCantOrdenada").Value
                End If
                If Not Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmCantRecibida").Value = Nothing Then
                    Me.txtSumaRecibidas.Text += Me.dgvDetalleOrdenCompra.Rows(i).Cells("clmCantRecibida").Value
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Empresa.Nombre)
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

                    InvAlmacen.CantidadExistencia = Divisor
                    InvAlmacen.CantidadSalidas = CantSalir
                    InvAlmacen.CostoPromedio = CostoPromedio

                    If InvAlmacen.CantidadExistencia = 0 Then
                        InvAlmacen.UltimoCosto = 0
                        InvAlmacen.FechaUltimoCosto = "01/01/1900"
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
                        MessageBox.Show("No se encontro el producto " & det.Producto.Descripcion & " en el almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                        .Mes = Now.ToString("MM")
                        .CantidadExistencia = CantExistencias - CantSalir
                        .CantidadEntrada = 0
                        .CantidadSalidas = CantSalir
                        .CantidadInicial = AuxInvEntity.CantidadExistencia
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
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region

#Region "Botones TollBar"

    Private Sub CalcularTotal()
        Dim ImporteTotal, ImporteInd, Descuento, subtotal, iva As Decimal  'IvaInd As Decimal
        Dim Producto As ClasesNegocio.ProductoGeneralClass

        For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
            If Not Me.dgvDetalleOrdenCompra.Rows(i).DefaultCellStyle.BackColor = Color.Bisque Then
                ImporteInd = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmRecibir.Index).Value * Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmPrecio.Index).Value - Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value
                Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmImporte.Index).Value = ImporteInd
                ImporteTotal += ImporteInd
                Descuento += Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmDescuento.Index).Value
                'verificar si el producto se le aplica iva o no ...
                Producto = New ClasesNegocio.ProductoGeneralClass
                Producto = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmProducto.Index).Value
                If Producto Is Nothing Then Exit For
                If Producto.SeAplicaIva Then
                    iva += (ImporteInd - Descuento) * (Me.dgvOrdenCompra.CurrentRow.Cells(Me.clmIVAPor.Index).Value / 100)
                Else
                    iva += 0
                End If
            End If
        Next

        'For Each det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle
        '    If Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIdProducto.Index).Value = det.IdProducto Then
        '        If det.Producto.SeAplicaIva = AsignadaEnum.SI Then
        '            IvaInd = (Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmRecibir.Index).Value * Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmPrecio.Index).Value) * (Controlador.ObtenerIVA() / 100)
        '            Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIva.Index).Value = IvaInd
        '            iva += IvaInd
        '            Exit For
        '        Else
        '            Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmIva.Index).Value = IvaInd = 0D
        '            Exit For
        '        End If
        '    End If
        'Next
        'Next

        subtotal = ImporteTotal - Descuento
        Me.txtImporteTotal.Text = ImporteTotal.ToString("C2")
        Me.txtDescuento.Text = Descuento.ToString("C2")
        Me.txtSubTotal.Text = subtotal.ToString("C2")
        Me.txtIVA.Text = iva.ToString("C2")
        Me.txtTotal.Text = (subtotal + iva).ToString("C2") '(subtotal + iva - Descuento).ToString("C2")
    End Sub

    Private Sub Mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickBorrar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Salida")

        Try
            If Me.RecepcionOrdenCompra.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MessageBox.Show("No se puede cancelar la Recepcion, debido a que ya se encuentra Cancelada", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If Me.RecepcionOrdenCompra.Facturada = True Then
                MessageBox.Show("No se puede Cancelar la Recepcion por que ya se encuentra facturada", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de Cancelar la Recepción de Orden de compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Modo = 2 'Cancelacion
                'obtiene la letra serie del almacen seleccionado
                Me.Almacen = New ClasesNegocio.AlmacenClass
                Almacen.Obtener(Me.RecepcionOrdenCompra.AlmacenId)

                If Me.cmbAlmacen.SelectedValue = Nothing Then
                    MessageBox.Show("No se puede realizar la cancelación de la Recepción de Orden Compra debido a que el Almacén:" & Almacen.Descripcion & " esta cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cancelar = True
                    Exit Sub
                End If

                'genera el folio de movimiento de almacen en la clase
                Dim FolioAlmacen As New FolioAlmacenClass
                FolioAlmacen.LetraSerie = Almacen.Letras
                FolioAlmacen.Año = Now.Year
                FolioAlmacen.Mes = Now.Month
                If Not FolioAlmacen.Guardar(trans) Then
                    trans.Rollback()
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

                trans.Add(Me.InvMovAlmacenCab.Entidad)

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
                    Me.TipoMovClass = New TipoMovimientoAlmacenClass(TipoMovId)

                    If Not Me.InvMovAlmacenDet.Guardar(trans) Then
                        trans.Rollback()
                        Exit Sub
                    End If
                Next

                'If Not GuardarSalida(trans) Then
                '    trans.Rollback()
                '    Exit Sub
                'End If

                Me.RecepcionOrdenCompra.FolioMovimientoAlmCan = _FolioAlm

                If Me.RecepcionOrdenCompra.Borrar(trans) Then
                    trans.Commit()
                    MessageBox.Show("La recepcion de orden de compra ha sido Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Limpiar()
                DesHabilitar()
            Else
                Cancelar = True
                Exit Sub
            End If

        Catch ex As Exception
            trans.Rollback()
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickBuscar
        Try
            Dim Forma As New ComBusquedaRecepcionOrden(False)
            Forma.Icon = Me.Icon

            If Forma.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Folio As String = Forma.DataGridView1.SelectedRows(0).Cells("ClmFolioRecep").Value
                Dim FolioOrden As String = Forma.DataGridView1.SelectedRows(0).Cells("ClmFolioOrden").Value
                Dim IdRecepcion As Integer = Forma.DataGridView1.SelectedRows(0).Cells("ClmIdRecepcion").Value
                Dim IdOrdenCompra As Integer = Forma.DataGridView1.SelectedRows(0).Cells("ClmIdORdenCompra").Value

                RecepcionOrdenCompra = New RecepcionOrdenCompraClass
                RecepcionOrdenCompra.Obtener(IdRecepcion)
                PonerDatos()
                BanderaBusqueda = True

                Me.Orden = New OrdenCompraClass
                Orden.Obtener(IdOrdenCompra)
                Me.txtFolioOrden.Text = Orden.FolioOrdenCompra
                Me.cmbPlaza.SelectedValue = Orden.Sucursal.Plaza.Codigo
                Me.cmbSucursal.SelectedValue = Orden.IdSucursal
                Me.cmbProveedor.SelectedValue = Orden.Proveedor.Codigo
                Me.cmbAlmacen.SelectedValue = Me.RecepcionOrdenCompra.AlmacenId
                Me.cmbMoneda.SelectedValue = Orden.Detalle(0).IdMoneda

                Me.txtImporteTotal.Text = Orden.Importe.ToString("C2")
                Me.txtDescuento.Text = Orden.Descuento.ToString("C2")
                Me.txtSubTotal.Text = Orden.SubTotal.ToString("C2")
                Me.txtIVA.Text = Orden.IVATotal.ToString("C2")
                Me.txtTotal.Text = Orden.Total.ToString("C2")

                '===========================   Cabezero de la recepcion de Orden   ===========================
                Me.dgvOrdenCompra.DataSource = Nothing
                Dim Ordenes As New OrdenCompraCollectionClass
                Dim OrdenCompra As New ClasesNegocio.OrdenCompraClass
                OrdenCompra.Obtener(IdOrdenCompra)
                Ordenes.Add(Orden)
                Me.dgvOrdenCompra.AutoGenerateColumns = False
                Me.dgvOrdenCompra.DataSource = Ordenes

                Me.dgvOrdenCompra.Enabled = False
                Me.dgvDetalleOrdenCompra.ReadOnly = True
                Me.txtObservaciones.Enabled = False

                '===========================   Detalle de la Recepcion Orden Compra   ===========================
                ObtenerOrdendeCompraDetalle(IdOrdenCompra)

                'Me.dgvDetalleOrdenCompra.DataSource = Nothing
                'For I As Integer = 0 To RecepcionOrdenCompra.Detalles.Count - 1
                '    Me.dgvDetalleOrdenCompra.Rows.Add()
                '    Me.dgvDetalleOrdenCompra.Rows(I).Cells(Me.clmProducto.Index).Value = RecepcionOrdenCompra.Detalles(I).Producto
                '    Me.dgvDetalleOrdenCompra.Rows(I).Cells(Me.ClmUM.Index).Value = RecepcionOrdenCompra.Detalles(I).Producto.UnidadMedida
                '    Me.dgvDetalleOrdenCompra.Rows(I).Cells(Me.clmCantOrdenada.Index).Value = 0
                '    Me.dgvDetalleOrdenCompra.Rows(I).Cells(Me.clmCantRecibida.Index).Value = RecepcionOrdenCompra.Detalles(I).Cantidad
                '    Me.dgvDetalleOrdenCompra.Rows(I).Cells(Me.clmRecibir.Index).Value = RecepcionOrdenCompra.Detalles(I).Cantidad
                'Next

                'Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
                'Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle
                'Me.dgvDetalleOrdenCompra.Enabled = True
                'Me.clmRecibir.ReadOnly = True

                'txtTipoCambio.Text = Orden.TipoCambio.ToString("C2")

                'Me.txtDescuento.Text = RecepcionOrdenCompra.Descuento.ToString("C2")
                'Me.txtIVA.Text = RecepcionOrdenCompra.IVA.ToString("C2")
                'Me.txtTotal.Text = RecepcionOrdenCompra.Total.ToString("C2")
                'Me.txtSubTotal.Text = RecepcionOrdenCompra.SubTotal.ToString("C2")
                'Me.txtImporteTotal.Text = (RecepcionOrdenCompra.SubTotal - Me.RecepcionOrdenCompra.Descuento).ToString("C2")
                'CalcularTotal()

                'If Orden.TipoCambio > 1 Then
                '    Me.GrpImportesPesos.Visible = True
                '    Me.txtImportePesos.Text = ((RecepcionOrdenCompra.SubTotal - Me.RecepcionOrdenCompra.Descuento) * Orden.TipoCambio).ToString("C2")
                '    txtDescuentoPesos.Text = (RecepcionOrdenCompra.Descuento * Orden.TipoCambio).ToString("C2")
                '    txtIvaPesos.Text = (RecepcionOrdenCompra.IVA * Orden.TipoCambio).ToString("C2")
                '    txtSubTotalPesos.Text = (RecepcionOrdenCompra.SubTotal * Orden.TipoCambio).ToString("C2")
                '    txtTotalPesos.Text = ((RecepcionOrdenCompra.SubTotal + RecepcionOrdenCompra.IVA) * Orden.TipoCambio).ToString("C2")
                'End If

                CalcularSuma()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickCancelar
        Limpiar()
        Me.dgvDetalleOrdenCompra.Rows.Clear()
        Me.dgvOrdenCompra.Rows.Clear()
        Me.DesHabilitar()
    End Sub

    Private Sub Mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickGuardar
        Dim Trans2 As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            If Me.Validar = False Then
                Cancelar = True
                Exit Sub
            End If
            'obtiene la letra serie del almacen seleccionado
            Me.Almacen = New ClasesNegocio.AlmacenClass
            Almacen.Obtener(Me.cmbAlmacen.SelectedValue)
            'genera el folio de movimiento de almacen en la clase
            Dim FolioAlmacen As New FolioAlmacenClass
            FolioAlmacen.LetraSerie = Almacen.Letras
            FolioAlmacen.Año = Now.Year
            FolioAlmacen.Mes = Now.Month
            If Not FolioAlmacen.Guardar(Trans2) Then
                Trans2.Rollback()
                Cancelar = True
                Exit Sub
            End If
            'asigna el folio de movimiento de almacen
            _FolioAlm = AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, Trans2)

            'guardar Movimientos de almacen cabecero
            InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenClass
            If Not GuardarMovAlmacenCab() Then
                Trans2.Rollback()
                Cancelar = True
                Exit Sub
            End If

            Trans2.Add(Me.InvMovAlmacenCab.Entidad)

            If Not Me.InvMovAlmacenCab.Entidad.Save Then
                Trans2.Rollback()
                Cancelar = True
                Exit Sub
            End If

            'Guardar Movimientos de Almacen Detalle

            Me.Guardar()

            If Not Me.RecepcionOrdenCompra.Guardar(Trans2) Then
                Trans2.Rollback()
                Exit Sub
            End If

            'Dim Band As Boolean
            Dim IdProducto As Integer
            Dim IdAlmacen As Integer
            Dim i As Integer = 0
            'Dim divisor As Integer
            ''Dim PrecioProd As Decimal
            ''Dim CantRecibir As Decimal
            ''Dim CostoPromedio As Decimal
            Dim Producto As ClasesNegocio.ProductoGeneralClass
            Dim ContBandTrue As Integer 'variables para checar el estado de la recepcion de producto e indicarle a la orden de compra si esta ya se recibio totalmente
            Dim ContBandFalse As Integer 'variables para checar el estado de la recepcion de producto e indicarle a la orden de compra si esta ya se recibio totalmente
            'Guardar Movimientos de Almacen Detalle
            ContBandTrue = 0
            ContBandFalse = 0

            For j As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                'For Each Det As ClasesNegocio.OrdenCompraDetalleClass In Orden.Detalle

                'If Det.CantPendiente > 0 Then               
                Producto = New ClasesNegocio.ProductoGeneralClass
                Producto = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmProducto.Index).Value
                If Producto Is Nothing Then Exit For
                i = i + 1
                IdProducto = Producto.Codigo
                IdAlmacen = Me.cmbAlmacen.SelectedValue
                Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenDetalleClass

                Me.InvMovAlmacenDet.IdAlmacen = IdAlmacen
                Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                Me.InvMovAlmacenDet.IdProducto = Producto.Codigo
                Me.InvMovAlmacenDet.Cantidad = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmRecibir.Index).Value
                Me.InvMovAlmacenDet.Costo = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmPrecio.Index).Value
                Me.InvMovAlmacenDet.Descuento = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmDescuento.Index).Value
                Me.InvMovAlmacenDet.Indice = i
                Me.InvMovAlmacenDet.FechaMovimiento = Now
                TipoMovClass = New TipoMovimientoAlmacenClass(TipoMovId)

                If Not Me.InvMovAlmacenDet.Guardar(Trans2) Then
                    Trans2.Rollback()
                    Cancelar = True
                    Exit Sub
                End If
                'End If

                'Guardar el detalle de la recepcion
                Me.RecepcionOrdenCompraDetalle = New RecepcionOrdenCompraDetClass
                Me.RecepcionOrdenCompraDetalle.IdRecepcionOrdenCompra = Me.RecepcionOrdenCompra.IdRecepcionOrdenCompra
                Me.RecepcionOrdenCompraDetalle.IdProducto = IdProducto
                Me.RecepcionOrdenCompraDetalle.Cantidad = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmRecibir.Index).Value
                Me.RecepcionOrdenCompraDetalle.Costo = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmPrecio.Index).Value
                Me.RecepcionOrdenCompraDetalle.Descuento = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmDescuento.Index).Value
                Me.RecepcionOrdenCompraDetalle.IVA = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmIva.Index).Value
                Me.RecepcionOrdenCompraDetalle.Total = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmImporte.Index).Value

                If Not RecepcionOrdenCompraDetalle.Guardar(Trans2) Then
                    Trans2.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                'actualizar detalle de orden de compra
                Dim OrdenCompraDetalle As New OrdenCompraDetalleClass
                If OrdenCompraDetalle.Obtener(Me.CodigoOrdenCompra, IdProducto, Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmIdDetalle.Index).Value) Then
                    OrdenCompraDetalle.CantRecibida += Me.RecepcionOrdenCompraDetalle.Cantidad
                    If Not OrdenCompraDetalle.Guardar(Trans2) Then
                        Cancelar = True
                        Trans2.Rollback()
                        Exit Sub
                    End If
                End If


                If Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmEstatusRecepcion.Index).Value = 1 Then
                    ContBandTrue += 1
                Else
                    ContBandFalse += 1
                End If
            Next
            Dim OrdenComp As New OrdenCompraClass
            If OrdenComp.Obtener(Me.CodigoOrdenCompra) Then
                OrdenComp.FechaRecibida = Now
                If ContBandFalse > 0 Then
                    OrdenComp.Recibida = EstatusOrdenRecibida.PARCIAL
                Else
                    OrdenComp.Recibida = EstatusOrdenRecibida.RECIBIDA
                End If
                If Not OrdenComp.Guardar(Trans2) Then
                    Cancelar = True
                End If
            End If
            'Me.CompraGanadoC.Obtener()
            Trans2.Commit()
            MessageBox.Show("Se guardo la Recepcion de Orden de compra con el Folio: " & Me.RecepcionOrdenCompra.FolioRecepcionOrdenCompra, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DesHabilitar()
            Me.RecepcionOrdenCompraC.Add(Me.RecepcionOrdenCompra)
            Imprimir()
            Me.Limpiar()
        Catch ex As Exception
            Trans2.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
            'If Me.OrdenDet.Obtener(Me.txtFolioOrden.Text, IdProducto) Then
            '    If Det.CantPendiente <> 0D Then
            '        Dim CantRecibida As Integer = OrdenDet.CantRecibida
            '        OrdenDet.CantRecibida = CantRecibida + Det.CantPendiente
            '    End If
            '    OrdenDet.CantPendiente = OrdenDet.CantidadOrdenada - OrdenDet.CantRecibida

            '    If OrdenDet.CantPendiente > 0D Then
            '        Band = True
            '    Else
            '        OrdenDet.CantPendiente = 0D
            '    End If

            '    If Not OrdenDet.Guardar(Trans2) Then
            '        Trans2.Rollback()
            '        Cancelar = True
            '    End If
            'End If

            '//////////////////////////////////////
            'Guardar el inventario de almacen
            'Declaraciones
            'CantRecibir = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmRecibir.Index).Value
            'InvAlmacen = New AlmacenGeneral.InventarioAlmacenClass
            'PrecioProd = Me.dgvDetalleOrdenCompra.Rows(j).Cells(Me.clmPrecio.Index).Value
            ''Se buscan los movimientos del producto en el mes actual
            'If InvAlmacen.Obtener(IdAlmacen, IdProducto, Me.RecepcionOrdenCompra.FechaRecepcion.Year, Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM"), Trans2) Then
            '    divisor = Me.InvAlmacen.CantidadExistencia + CantRecibir
            '    If divisor = 0 Then
            '        CostoPromedio = 0
            '    Else
            '        CostoPromedio = ((Me.InvAlmacen.CantidadExistencia * Me.InvAlmacen.CostoPromedio) + (CantRecibir * PrecioProd)) / _
            '                         divisor
            '    End If

            '    InvAlmacen.CantidadExistencia = InvAlmacen.CantidadExistencia + CantRecibir
            '    InvAlmacen.CantidadEntrada = CantRecibir
            '    InvAlmacen.CantidadSalidas = 0
            '    InvAlmacen.FechaUltimoCosto = Now
            '    InvAlmacen.UltimoCosto = PrecioProd
            '    InvAlmacen.CostoPromedio = CostoPromedio

            '    If Not InvAlmacen.Guardar(Trans2) Then
            '        Trans2.Rollback()
            '        Cancelar = True
            '        Exit Sub
            '    End If
            'Else
            '    Dim InvCol As New CC.InventarioAlmacenCollection
            '    Dim Filtro As New OC.PredicateExpression
            '    'Se obtiene el ultimo movimiento del producto en el almacen 
            '    Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = IdAlmacen And _
            '              HC.InventarioAlmacenFields.ProductoId = IdProducto)
            '    Dim Orden As New OC.SortExpression
            '    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
            '    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
            '    InvCol.GetMulti(Filtro, 1, Orden)

            '    Dim AuxInvEntity As EC.InventarioAlmacenEntity
            '    If InvCol.Count > 0 Then
            '        AuxInvEntity = InvCol(0)

            '        Dim cantExistencia As Integer = AuxInvEntity.CantidadExistencia
            '        Dim CostoProm As Integer = AuxInvEntity.CostoPromedio
            '        divisor = cantExistencia + CantRecibir
            '        If divisor = 0 Then
            '            CostoPromedio = 0
            '        Else
            '            CostoPromedio = ((cantExistencia * CostoProm) + (CantRecibir * PrecioProd)) / _
            '                             divisor
            '        End If

            '        Dim InvEntity As New EC.InventarioAlmacenEntity
            '        With InvEntity
            '            .AlmacenId = AuxInvEntity.AlmacenId
            '            .ProductoId = AuxInvEntity.ProductoId
            '            .Año = Me.RecepcionOrdenCompra.FechaRecepcion.Year
            '            .Mes = Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM")
            '            .CantidadExistencia = cantExistencia + CantRecibir
            '            .CantidadEntrada = CantRecibir
            '            .CantidadSalidas = 0
            '            .CantidadInicial = AuxInvEntity.CantidadExistencia
            '            .CostoPromedio = CostoPromedio
            '            .UltimoCosto = PrecioProd
            '            .FechaUltimoCosto = Now
            '        End With
            '        Trans2.Add(InvEntity)
            '        If Not InvEntity.Save Then
            '            Trans2.Rollback()
            '            Cancelar = True
            '        End If
            '    Else
            '        Dim invEntity As New EC.InventarioAlmacenEntity
            '        With invEntity
            '            .AlmacenId = IdAlmacen
            '            .ProductoId = IdProducto
            '            .Año = Me.RecepcionOrdenCompra.FechaRecepcion.Year
            '            .Mes = Me.RecepcionOrdenCompra.FechaRecepcion.ToString("MM")
            '            .CantidadExistencia = CantRecibir
            '            .CantidadEntrada = CantRecibir
            '            .CantidadSalidas = 0
            '            .CantidadInicial = 0
            '            .UltimoCosto = PrecioProd
            '            .CostoPromedio = PrecioProd
            '            .FechaUltimoCosto = Now
            '        End With
            '        Trans2.Add(invEntity)
            '        If Not invEntity.Save Then
            '            Trans2.Rollback()
            '            Cancelar = True
            '        End If
            '    End If
            'End If
            'Next
            'guardar Recepcion de orden detalle
            ''Dim Band As Boolean
            ''For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
            ''    Dim IdProducto As Integer = Me.dgvDetalleOrdenCompra.Rows(i).Cells("ClmIdProducto").Value
            ''    Dim CantRecibir As Integer = Me.dgvDetalleOrdenCompra.Rows(i).Cells("ClmRecibir").Value

            ''    Me.RecepcionOrdenCompraDetalle = New RecepcionOrdenCompraDetClass
            ''    Me.RecepcionOrdenCompraDetalle.Folio = Me.txtFolioRecepcion.Text
            ''    Me.RecepcionOrdenCompraDetalle.IdProducto = IdProducto
            ''    Me.RecepcionOrdenCompraDetalle.Cantidad = CantRecibir
            ''    If Not RecepcionOrdenCompraDetalle.Guardar(Trans2) Then
            ''        Trans2.Rollback()
            ''        Cancelar = True
            ''        Exit Sub
            ''    End If
            ''    If Me.OrdenDet.Obtener(Me.txtFolioOrden.Text, IdProducto) Then
            ''        OrdenDet.CantRecibidas += CantRecibir
            ''        OrdenDet.CantPendiente = OrdenDet.CantidadOrdenada - OrdenDet.CantRecibidas
            ''        If OrdenDet.CantPendiente > 0 Then
            ''            Band = True
            ''        Else
            ''            OrdenDet.CantPendiente = 0
            ''        End If
            ''        If Not OrdenDet.Guardar(Trans2) Then
            ''            Cancelar = True
            ''            Trans2.Rollback()
            ''        End If
            ''    End If
            ''Next
            ' Guardar en Inventario de almacen
            'If Not Me.GuardarInvAlmacen(Trans2) Then
            '    Trans2.Rollback()
            '    Cancelar = True
            '    Exit Sub
            'End If
       

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
        Me.RecepcionOrdenCompraC.Clear()
        Me.RecepcionOrdenCompraC.Add(Me.RecepcionOrdenCompra)
        Imprimir()
    End Sub

    Private Sub Mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickLimpiar
        Me.Limpiar()
        Me.cmbAlmacen.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.cmbSucursal.Enabled = False
        Me.dgvDetalleOrdenCompra.Rows.Clear()
        Me.dgvOrdenCompra.Rows.Clear()
    End Sub

    Private Sub Mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickNuevo
        Try
            Me.Limpiar()
            Me.Habilitar()
            Me.Bandera = False

            'obtener las ordenes de compra que esten autorizadas
            Plaza = New PlazaClass
            Sucursal = New SucursalClass

            If Not ObtenerOrdendeCompra(0, Nothing, Sucursal) Then
                Cancelar = True
                Me.Limpiar()
                Me.DesHabilitar()
                'MessageBox.Show("No hay Ordenes de Compra Autorizadas, para Recibir", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Me.dgvDetalleOrdenCompra.Rows.Clear()
            Me.dgvOrdenCompra.Rows.Clear()

            'clase para guardar la recepecion
            RecepcionOrdenCompra = New RecepcionOrdenCompraClass
            Me.RecepcionOrdenCompraDetalle = New RecepcionOrdenCompraDetClass

            Modo = 1 'Modo inserccion
            Bandera = True
            Me.RecepcionOrdenCompraC.Clear()
            Me.txtNoFactura.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickSalir
        Close()
    End Sub

    'Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
    '    Try
    '        Dim ventana As New ComBusquedaOrdenCompra
    '        ventana.GroupBox4.Visible = False
    '        ventana.GroupBox2.Visible = False          
    '        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Dim OrdenCompra As New ClasesNegocio.OrdenCompraClass

    '            OrdenCompra.Obtener(ventana.DgvOrdencompra.SelectedRows(0).Cells("clmidOrdenCompra").Value)

    '            Orden = OrdenCompra

    '            'Orden = DirectCast(ventana.DgvOrdencompra.SelectedRows(0).DataBoundItem, ClasesNegocio.OrdenCompraClass)

    '            If Orden.Autorizada = False Then
    '                MessageBox.Show("La orden de compra que seleccionó no esta autorizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If

    '            If Orden.Recibida = EstatusOrdenRecibida.RECIBIDA Then
    '                MessageBox.Show("La orden de compra que ha seleccionado ya esta recibida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If

    '            If Orden.Estatus = EstatusRecepcionOrden.FINIQUITADO Then
    '                MessageBox.Show("La orden de compra ya se encuentra Finiquitada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If

    '            cmbPlaza.SelectedValue = Orden.Sucursal.Plaza.Codigo
    '            cmbSucursal.SelectedValue = Orden.Sucursal.Codigo
    '            cmbProveedor.SelectedValue = Orden.Proveedor.Codigo
    '            'cmbMoneda.SelectedValue = Orden.Moneda.Codigo
    '            'txtTipoCambio.Text = Orden.TipoCambio.ToString("C2")
    '            Me.DtpFecha.Value = Orden.FechaOrdenCompra
    '            Me.lblEstatus.Visible = True
    '            Me.lblEstatus.Text = Orden.Estatus.ToString
    '            Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
    '            Me.dgvDetalleOrdenCompra.DataSource = Orden.Detalle

    '            Me.txtFolioOrden.Text = Orden.FolioOrdenCompra

    '            CalcularTotal()
    '            CalcularSuma()
    '            Me.BtnBuscar.Enabled = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        'Cancelar = True
    '    End Try
    'End Sub
#End Region

#Region "Datagrid"
    Private Sub dgvDetalleOrdenCompra_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellEndEdit
        Select Case e.ColumnIndex
            Case Me.clmIdProducto.Index
                Refresh()
            Case Me.clmRecibir.Index
                If Not IsNumeric(Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmRecibir").Value) Then
                    MsgBox("Ingrese solo números", MsgBoxStyle.Information)
                Else

                    If Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmRecibir").Value > (Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantOrdenada").Value - Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantRecibida").Value) Then
                        MsgBox("Esta recibiendo mas Producto que el especificado, Alguien lo debe Autorizar")
                        Me.dgvDetalleOrdenCompra.CurrentRow.Cells(Me.clmEstatusRecepcion.Index).Value = 1
                        Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmRecibir").Value = "0.000"
                        Exit Sub
                    End If

                    If Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmRecibir").Value < (Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantOrdenada").Value - Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantRecibida").Value) Then
                        Me.dgvDetalleOrdenCompra.CurrentRow.Cells(Me.clmEstatusRecepcion.Index).Value = 0
                    End If

                    If Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmRecibir").Value = (Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantOrdenada").Value - Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantRecibida").Value) Then
                        Me.dgvDetalleOrdenCompra.CurrentRow.Cells(Me.clmEstatusRecepcion.Index).Value = 1
                    End If
                    CalcularSuma()
                    Me.CalcularTotal()
                    'Dim Recibida As Integer = Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantRecibida").Value
                    'Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmCantRecibida").Value = Recibida + Me.dgvDetalleOrdenCompra.CurrentRow.Cells("clmRecibir").Value
                End If
        End Select
    End Sub

    Private Sub dgvDetalleOrdenCompra_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalleOrdenCompra.DataError

    End Sub
#End Region

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
        Try
            If Me.cmbAlmacen.SelectedIndex > -1 Then
                ObtenerOrdendeCompra(Me.cmbProveedor.SelectedValue, Plaza, Sucursal)
                Dim FamiliasAlmacenes As New CC.AlmacenesFamiliasCollection
                FamiliasAlmacenes.GetMulti(HC.AlmacenesFamiliasFields.CodigoAlmacen = Me.cmbAlmacen.SelectedValue)
                Me.dgvFamilias.DataSource = FamiliasAlmacenes
                VerificarFamiliasdeAlmacen()
                Me.txtObservaciones.Enabled = True
                Me.dgvDetalleOrdenCompra.Enabled = True
                Me.dgvDetalleOrdenCompra.ReadOnly = False
                Me.dgvOrdenCompra.Enabled = True
            Else
                Me.txtObservaciones.Enabled = False
                Me.dgvDetalleOrdenCompra.Enabled = False
                Me.dgvDetalleOrdenCompra.ReadOnly = True
                Me.dgvOrdenCompra.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbMoneda_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbMoneda.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                MonedaTC.Obtener()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.cmbPlaza.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedValueChanged
        Try
            If Me.BanderaBusqueda Then Exit Sub
            If Me.cmbPlaza.SelectedValue Is Nothing Then
                Exit Sub
            Else
                Plaza.Obtener(Me.cmbPlaza.SelectedValue)
                Me.cmbSucursal.Enabled = True
                'If Not ObtenerOrdendeCompra(0, Plaza, Sucursal) Then
                '    Me.dgvDetalleOrdenCompra.Rows.Clear()
                '    Me.dgvOrdenCompra.Rows.Clear()
                'End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.cmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
                Me.cmbProveedor.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbProveedor.ValueMember = "IDProveedor"
            Me.cmbProveedor.DataSource = ProveedorC
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.SelectedIndex = -1
            Me.cmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            Me.TmProveedor.Stop()
            Me.UltimaTeclaProveedor = Now
            Me.TmProveedor.Start()
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

    Private Sub cmbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedValueChanged
        Try
            If Me.BanderaBusqueda Then Exit Sub
            If Me.cmbProveedor.SelectedValue Is Nothing Then
                Exit Sub
            Else
                Me.cmbAlmacen.Enabled = True
                If Not ObtenerOrdendeCompra(Me.cmbProveedor.SelectedValue, Plaza, Sucursal) Then
                    Me.dgvDetalleOrdenCompra.Rows.Clear()
                    Me.dgvOrdenCompra.Rows.Clear()
                    Me.cmbAlmacen.Enabled = False
                    Me.cmbAlmacen.SelectedIndex = -1
                    Me.cmbAlmacen.Text = "Seleccione un Almacen..."
                    Me.txtObservaciones.Text = ""
                End If
                Me.dgvDetalleOrdenCompra.Rows.Clear()
                Me.dgvOrdenCompra.Rows.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.SucursalC.Obtener()
                Me.cmbSucursal.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSucursal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectedValueChanged
        Try
            If Me.BanderaBusqueda Then Exit Sub
            If Me.cmbSucursal.SelectedValue Is Nothing Then
                Exit Sub
            Else
                Sucursal.Obtener(Me.cmbSucursal.SelectedValue)
                Me.cmbProveedor.Enabled = True
                If Not ObtenerOrdendeCompra(0, Plaza, Sucursal) Then
                    Me.dgvDetalleOrdenCompra.Rows.Clear()
                    Me.dgvOrdenCompra.Rows.Clear()
                    Me.cmbProveedor.Enabled = False
                End If
                Me.dgvDetalleOrdenCompra.Rows.Clear()
                Me.dgvOrdenCompra.Rows.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProveedor.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                ProveedorC.Obtener(False, Me.cmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvOrdenCompra_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOrdenCompra.RowEnter
        Try
            If Not Bandera Then Exit Sub
            ' If Me.dgvDetalleOrdenCompra.SelectedRows.Count = 0 Then Exit Sub
            If Me.dgvOrdenCompra.Rows(e.RowIndex).Cells(Me.clmIdOrdenCompra.Index).Value = 0 Then Exit Sub

            If Not ObtenerOrdendeCompraDetalle(Me.dgvOrdenCompra.Rows(e.RowIndex).Cells(Me.clmIdOrdenCompra.Index).Value) Then
                MessageBox.Show("Detalle de Orden de Compra no Existe", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.txtFolioOrden.Text = Me.dgvOrdenCompra.Rows(e.RowIndex).Cells(Me.clmFolioOrdenCompra.Index).Value
                Me.CodigoOrdenCompra = Me.dgvOrdenCompra.Rows(e.RowIndex).Cells(Me.clmIdOrdenCompra.Index).Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'funcion para traer las ordenes de compra para la recepcion
    Function ObtenerOrdendeCompra(ByVal IdProveedor As Integer, ByVal Plaza As PlazaClass, ByVal Sucursal As SucursalClass) As Boolean
        Dim OrdenCompra As New ClasesNegocio.OrdenCompraCollectionClass
        Dim Band As Boolean

        If IdProveedor = 0 Then
            If OrdenCompra.Obtener(CondicionEnum.ACTIVOS, Plaza, Sucursal, Nothing, CondicionAsignadaEnum.SI, CondicionOrdenRecibida.NOYPARCIAL) > 0 Then
                Band = True
            Else
                Band = False
            End If
        Else
            Dim Prov As New ProveedorClass
            Prov.Obtener(IdProveedor)
            If OrdenCompra.Obtener(CondicionEnum.ACTIVOS, Plaza, Sucursal, Prov, CondicionAsignadaEnum.SI, CondicionOrdenRecibida.NOYPARCIAL) > 0 Then
                Band = True
            Else
                Band = False
            End If
        End If

        If Band Then
            Me.dgvOrdenCompra.AutoGenerateColumns = False
            Me.dgvOrdenCompra.DataSource = OrdenCompra
        Else
            MessageBox.Show("No hay Ordenes de Compra Autorizadas, para Recibir", Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        ObtenerOrdendeCompraDetalle(OrdenCompra(0).IdOrdenCompra)
        Return True

    End Function

    Function ObtenerOrdendeCompraDetalle(ByVal IdOrdenDeCompra As Integer) As Boolean
        Dim OrdenComp As New ClasesNegocio.OrdenCompraDetalleCollectionClass
        OrdenComp.Obtener(HC.OrdenCompraDetalleFields.IdOrdenCompra = IdOrdenDeCompra)
        Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
        Me.dgvDetalleOrdenCompra.DataSource = OrdenComp
        VerificarFamiliasdeAlmacen()
        Return True
    End Function

    Function VerificarFamiliasdeAlmacen() As Boolean
        Try
            Dim Producto As ClasesNegocio.ProductoGeneralClass
            For i As Integer = 0 To Me.dgvDetalleOrdenCompra.Rows.Count - 1
                Producto = New ClasesNegocio.ProductoGeneralClass
                Producto = Me.dgvDetalleOrdenCompra.Rows(i).Cells(Me.clmProducto.Index).Value
                If Producto Is Nothing Then Exit For
                If Me.dgvFamilias.Rows.Count = 0 Then
                    Me.dgvDetalleOrdenCompra.Rows(i).ReadOnly = False
                    Me.dgvDetalleOrdenCompra.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
                For j As Integer = 0 To Me.dgvFamilias.Rows.Count - 1
                    If Producto.IdLinea <> Me.dgvFamilias.Rows(j).Cells(Me.clmIdFamilia.Index).Value Then
                        Me.dgvDetalleOrdenCompra.Rows(i).ReadOnly = True
                        Me.dgvDetalleOrdenCompra.Rows(i).DefaultCellStyle.BackColor = Color.Bisque
                    Else
                        Me.dgvDetalleOrdenCompra.Rows(i).ReadOnly = False
                        Me.dgvDetalleOrdenCompra.Rows(i).DefaultCellStyle.BackColor = Color.White
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Sub dgvDetalleOrdenCompra_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleOrdenCompra.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If dgvDetalleOrdenCompra.CurrentCell.ColumnIndex = clmRecibir.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub dgvDetalleOrdenCompra_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDetalleOrdenCompra.Sorted
        VerificarFamiliasdeAlmacen()
    End Sub
End Class