Imports System.Windows.Forms
Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Drawing
Imports Integralab.ORM.EntityClasses
Imports System.Data.SqlClient

Public Class frmABCProducosComprasGen

#Region "Miembros"
    Dim WithEvents Familias As New ClasesNegocio.LineaCollectionClass
    Dim WithEvents Marcas As New ClasesNegocio.MarcaCollectionClass
    Dim WithEvents UnidadesMedida As New ClasesNegocio.UnidadesMedidaCollectionClass
    Dim WithEvents SubFamilias As New ClasesNegocio.SubLineaCollectionClass
    Dim WithEvents Familia As New ClasesNegocio.LineaClass
    Dim WithEvents Presentaciones As New ClasesNegocio.PresentacionCollectionClass
    Dim WithEvents Prods As New ClasesNegocio.ProductoCollectionClass
    Dim WithEvents Producto As New ClasesNegocio.ProductoGeneralClass
    Dim WithEvents DetalleKit As New ClasesNegocio.DetalleKitClass
    Dim WithEvents TProds As New ClasesNegocio.TipoProductoCollectionClass
    Dim WithEvents CInd As New ClasesNegocio.CostosIndirectosClass
    Dim WithEvents CInds As New ClasesNegocio.CostosIndirectosCollectionClass
    Dim WithEvents PCindi As ClasesNegocio.ProdCostosIndirectosClass
    Dim WithEvents PCindis As New ClasesNegocio.ProdCostoIndirectoCollection
    Dim WithEvents PsPaquetes As New ClasesNegocio.ProductosPaqueteCollection
    Dim WithEvents PPaquete As ClasesNegocio.ProductosPaqueteClass
    Dim puedorefrescar As Boolean = True
    Dim Seleccionado As Boolean
    Dim Editar As Boolean = False
    Dim ultimoporcentaje As Decimal
    Dim rowindex As Integer
    Dim RenglonValidado As Boolean = False
    Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "AltaProd")
    Dim rowindexdelete As Integer = -1
    Dim preCosto As Double = 0D
    Dim preVenta As Double = 0D
    Dim cargacodsucursal As Boolean
    Dim BuscarKit As Boolean = False
    Dim endedit As Boolean = False

#End Region

#Region "Métodos"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ''Add any initialization after the InitializeComponent() call.
        Me.dgvKit.Columns.Item(2).ValueType = GetType(Double)
        Me.dgvKit.Columns.Item(3).ValueType = GetType(Double)
        Me.dgvKit.Columns.Item(4).ValueType = GetType(Double)

        Me.dgvKit.Columns.Item(3).ReadOnly = True
        Me.dgvKit.Columns.Item(5).ReadOnly = True
        Me.dgvKit.Columns.Item(6).ReadOnly = True
        Me.dgvKit.Item(2, 0).Value = 0

    End Sub

    Private Sub sbLimpiar()
        Me.Producto = New ClasesNegocio.ProductoGeneralClass
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()
        Me.txtDescCorta.Clear()
        Me.cmbFamilia.SelectedIndex = -1
        Me.cmbFamilia.Text = "Seleccione una Línea..."
        Me.cmbUnidadesMedida.SelectedIndex = -1
        Me.cmbUnidadesMedida.Text = "Seleccione un Unidad de Medida..."
        Me.cmbMarcas.SelectedIndex = -1
        Me.cmbMarcas.Text = "Seleccione una Marca..."
        Me.txtCodigoBarra.Text = ""
        Me.cmbPresentacion.SelectedIndex = -1
        Me.cmbPresentacion.Text = "Seleccione una Presentación..."
        Me.cmbTipoProd.SelectedIndex = -1
        Me.cmbTipoProd.Text = "Seleccione un Tipo de Producto..."
        Me.dtpFecha.Value = Now
        Me.chkSeFactura.Checked = False
        Me.chkSeReciveSinFactura.Checked = False
        Me.chkObtenerMermas.Checked = False
        Me.chkSeManejaProLotes.Checked = False
        Me.chkFacturaSinExistencia.Checked = False
        Me.chkCaduca.Checked = False
        Me.chkSeRecibeParcialmente.Checked = False
        Me.chkIngrediente.Checked = False
        Me.rbProductoGeneral.Checked = False
        Me.txtPiezas.Text = 0
        Me.dgvCIR.DataSource = Nothing
        Me.dgvIngredientes.DataSource = Nothing
        'Me.dgvNutrientes.DataSource = Nothing
        dgvIngredientes.AllowUserToAddRows = False
        'dgvNutrientes.AllowUserToAddRows = False
        Me.txtCaducidad.Enabled = False
        Editar = False
        Me.lblestatus.Visible = False
        Seleccionado = False
        Me.txtCaducidad.Text = 0
        Me.chkAplicaIva.Checked = False
        Me.cmbSubFamilia.SelectedIndex = -1

        Me.dgvKit.DataSource = Nothing
        Me.chkEsKit.Checked = False

        txtprecio.Text = "0.00"
        lblTotalKit.Text = "0.00"
        lblTotalPrecio.Text = "0.00"
        preCosto = 0D
        preVenta = 0D
        txtieps.Text = "0"
        BuscarKit = False
        RemoveHandler dgvKit.RowValidating, AddressOf dgvKit_RowValidating
        Me.dgvKit.Rows.Clear()
        AddHandler dgvKit.RowValidating, AddressOf dgvKit_RowValidating
        dgvHistorialCompras.DataSource = Nothing
    End Sub

    Private Sub sbHabilitar()
        Pan.Enabled = True
        rbEsMezcla.Enabled = True
        rbProductoGeneral.Enabled = True


        If Producto.Codigo <> 0 Then
            Dim det As New CN.NotaVentaDetalleCollectionClass
            ''det.ObtenerTotal(Producto.Codigo)
            ''det.ObtenerTotalVendidos(Producto.Codigo)
            If det.ObtenerTotalVendidos(Producto.Codigo) > 0 Then
                dgvKit.Enabled = True
                chkEsKit.Enabled = False
                dgvKit.Columns(clmCodBarra.Index).ReadOnly = True
                dgvKit.Columns(clmProducto.Index).ReadOnly = True
                dgvKit.Columns(clmCantidad.Index).ReadOnly = True
                dgvKit.Columns(clmPreKit.Index).ReadOnly = False
                MessageBox.Show("Este Kit ya fue vendido, solo se podrá modificar" & vbLf & " el precio de kit en los articulos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                chkEsKit.Enabled = True
                dgvKit.Enabled = True
            End If
        Else
            dgvKit.Columns(clmCodBarra.Index).ReadOnly = False
            dgvKit.Columns(clmProducto.Index).ReadOnly = False
            dgvKit.Columns(clmCantidad.Index).ReadOnly = False
            dgvKit.Columns(clmPreKit.Index).ReadOnly = False
            chkEsKit.Enabled = True
            dgvKit.Enabled = True
        End If


        '----------parte de paquetes
        If Me.chkFormula.Checked Or chkIngrediente.Checked Then
            Me.tbcPaquetes.Enabled = True
        Else
        End If
        '-------------------------------

        Me.txtCantidadUltimaCompra.Enabled = False
        Me.txtUltimoCosto.Enabled = False
        Me.dtpFechaUltimaCompra.Enabled = False
        Me.txtImportteUltimaCompra.Enabled = False
    End Sub

    Private Sub sbDeshabilitar()
        Pan.Enabled = False
        PestanaGeneral()
        Me.tbcPaquetes.Enabled = False
    End Sub

    Private Sub sbGuardar()
        puedorefrescar = False

        Producto.SeAplicaIva = Me.chkAplicaIva.Checked
        'Producto.PorcIEPS = IIf(Me.chkAplicaIva.Checked, Me.txtIva.Text, 0)
        Producto.PorcIEPS = IIf(txtieps.Text.Trim() <> "", txtieps.Text, 0)
        Producto.ArtPuntoVenta = True
        Producto.FechaAlta = Me.dtpFecha.Value
        Producto.Descripcion = Me.txtDescripcion.Text
        Producto.DescCorta = Me.txtDescCorta.Text
        Producto.IdLinea = CType(Me.cmbFamilia.SelectedValue, Integer)
        Producto.UnidadMedida = Me.cmbUnidadesMedida.SelectedItem
        Producto.Marca = Me.cmbMarcas.SelectedItem
        'Producto.Presentacion = Me.cmbPresentacion.SelectedItem
        'Producto.TProducto = Me.cmbTipoProd.SelectedItem
        Producto.CodigoBarra = txtCodigoBarra.Text
        Producto.SeFactura = Me.chkSeFactura.Checked
        Producto.SeRecibeParcial = Me.chkSeRecibeParcialmente.Checked
        Producto.SeObtieneMermas = Me.chkObtenerMermas.Checked
        Producto.SeRecibeSinFactura = Me.chkSeReciveSinFactura.Checked
        Producto.SeFacturaSinExistencia = Me.chkFacturaSinExistencia.Checked
        Producto.SeManejaPorLotes = Me.chkSeManejaProLotes.Checked
        If Not Me.chkIngrediente.Checked And Not Me.chkFormula.Checked Then
            Producto.ProductoGeneral = ClasesNegocio.AsignadaEnum.SI
        Else
            Producto.ProductoGeneral = ClasesNegocio.AsignadaEnum.NO
        End If
        'Producto.ProductoGeneral = Me.rbProductoGeneral.Checked
        Producto.EsMezcla = Me.chkFormula.Checked
        Producto.Ingrediente = IIf(Producto.EsMezcla, True, Me.chkIngrediente.Checked)
        Producto.MaterialEnvase = Me.rbMaterialPaEnvases.Checked
        Producto.Caducidad = Me.chkCaduca.Checked
        Producto.DiasminCaducidad = IIf(Me.chkCaduca.Checked, Me.txtCaducidad.Text, 0)
        Producto.Piezas = 0
        If chkEsKit.Checked Then
            Producto.EsKit = True
        End If
        If Application.ProductName.ToUpper() = "PUNTO DE VENTA" Or Application.ProductName.ToUpper() = "BACKEND" Then Producto.ArtPuntoVenta = True
        If Application.ProductName.ToUpper() = "MEAT" Then Producto.ArtMeat = True

        puedorefrescar = True
    End Sub

    Public Function sbGuardarKit() As Boolean
        DetalleKit = New ClasesNegocio.DetalleKitClass()

        For Each row As DataGridViewRow In dgvKit.Rows
            If Not row.IsNewRow Then
                'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                Try
                    DetalleKit = New ClasesNegocio.DetalleKitClass
                    DetalleKit.IdKit = Producto.Codigo
                    DetalleKit.IdProd = Convert.ToInt32(row.Cells(1).Value)
                    DetalleKit.Cantidad = Convert.ToDecimal(row.Cells(2).Value)
                    DetalleKit.Precio = Convert.ToDecimal(row.Cells(clmPreKit.Index).Value)
                    Dim prodet As New CN.ProductoGeneralClass(CInt(row.Cells(1).Value))
                    Dim Imptos As Decimal = prodet.PorcIEPS
                    If prodet.SeAplicaIva = ClasesNegocio.AsignadaEnum.SI Then Imptos += Controlador.ObtenerIVA
                    Dim preSinImp As Decimal = (DetalleKit.Precio / ((Imptos / 100) + 1))
                    If prodet.SeAplicaIva Then
                        'DetalleKit.Iva = (DetalleKit.Precio - (DetalleKit.Precio / ((Controlador.ObtenerIVA / 100) + 1)))
                        DetalleKit.Iva = preSinImp * (Controlador.ObtenerIVA / 100)
                        'totalivakit += DetalleKit.Iva
                    End If
                    If prodet.PorcIEPS > 0 Then
                        'DetalleKit.Ieps = (DetalleKit.Precio - (DetalleKit.Precio / ((prodet.PorcIEPS / 100) + 1)))
                        DetalleKit.Ieps = preSinImp * (prodet.PorcIEPS / 100)
                        'totalIepsKit = DetalleKit.Ieps
                    End If
                    If Not DetalleKit.Guardar(trans) Then
                        MsgBox("No se guardaron los productos del kit.", MsgBoxStyle.Exclamation, "AVISO")
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("ERROR: " & ex.Message.ToString, MsgBoxStyle.Critical, "ERROR")
                    Return False
                End Try
            End If
        Next
        Return True
    End Function

    Private Function Validar() As Boolean
        If Me.txtDescripcion.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtDescripcion.Focus()
            Return False
        End If

        If Me.txtDescCorta.Text = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtDescCorta.Focus()
            Return False
        End If

        'If IsNumeric(Me.txtPiezas.Text) Then
        '    If CDec(Me.txtPiezas.Text) = 0 Then
        '        MsgBox("Debe ingresar las piezas", MsgBoxStyle.Exclamation, "Faltan Datos")
        '        Me.txtPiezas.Focus()
        '        Return False
        '    End If
        'Else
        '    MsgBox("Debe ingresar las piezas", MsgBoxStyle.Exclamation, "Faltan Datos")
        '    Me.txtPiezas.Focus()
        '    Return False
        'End If

        'If Me.cmbSubFamilia.SelectedIndex = -1 Then
        '    MsgBox("Debe seleccionar una sub-familia", MsgBoxStyle.Exclamation, "Faltan Datos")
        '    cmbSubFamilia.Focus()
        '    Return False
        'End If



        If Me.cmbFamilia.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una familia", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbFamilia.Focus()
            Return False
        End If

        If Me.cmbMarcas.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una marca", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbMarcas.Focus()
            Return False
        End If

        If Me.cmbUnidadesMedida.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una unidad de medida", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbUnidadesMedida.Focus()
            Return False
        End If

        If Me.txtCodigoBarra.Text = "" Then
            MsgBox("Debe ingresar el codigo de barras", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtCodigoBarra.Focus()
            Return False
        End If

        If chkEsKit.Checked Then
            If dgvKit.RowCount <= 1 Then
                MsgBox("Debe ingresar al menos 1 articulo al kit.", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.dgvKit.Focus()
                Return False
            End If


        End If

        If dgvKit.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvKit.Rows
                If Not row.IsNewRow Then
                    If row.Cells(0).Value Is Nothing Or (row.Cells(1).Value <= 0 Or row.Cells(1).Value Is Nothing) Then
                        dgvKit.Rows.RemoveAt(row.Index)
                    End If
                End If
            Next
        End If

        'If Me.cmbPresentacion.SelectedIndex = -1 Then
        '    MsgBox("Debe seleccionar una presentación", MsgBoxStyle.Exclamation, "Faltan Datos")
        '    cmbPresentacion.Focus()
        '    Return False
        'End If

        'If Me.cmbTipoProd.SelectedIndex = -1 Then
        '    MsgBox("Debe seleccionar un tipo de producto", MsgBoxStyle.Exclamation, "Faltan Datos")
        '    cmbTipoProd.Focus()
        '    Return False
        'End If

        'If Me.chkCaduca.Checked Then
        '    If IsNumeric(Me.txtCaducidad.Text) Then
        '        If CDec(Me.txtCaducidad.Text) = 0 Then
        '            MsgBox("Debe ingresar los dias de caducidad", MsgBoxStyle.Exclamation, "Faltan Datos")
        '            Me.txtCaducidad.Focus()
        '            Return False
        '        End If
        '    Else
        '        MsgBox("Debe ingresar los dias de caducidad", MsgBoxStyle.Exclamation, "Faltan Datos")
        '        Me.txtCaducidad.Focus()
        '        Return False
        '    End If
        'End If

        Return True
    End Function

#End Region

#Region "Paso de Controles"

    Private Sub txtCaducidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCaducidad.KeyPress
        If Not e.KeyChar = Chr(8) And Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPiesas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPiezas.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub rbEsMezcla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEsMezcla.CheckedChanged
        If rbEsMezcla.Checked Then
            Me.rbIngrediente.Enabled = False
            Me.rbIngrediente.Checked = True
            Me.rbMaterialPaEnvases.Enabled = False
            PestanaMezclas()
        Else
            Me.rbIngrediente.Enabled = True
            Me.rbIngrediente.Checked = True
            Me.rbMaterialPaEnvases.Enabled = True
            PestanaNutrientes()
        End If
    End Sub

#End Region

#Region "MEAToolBar"
    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim forma As New ClasesComunes.frmReporteArticulos
        forma.StartPosition = FormStartPosition.CenterScreen
        forma.Show()

    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Seleccionado Then
            sbLimpiar()
        Else
            sbLimpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        sbLimpiar()
        sbDeshabilitar()
        lblestatus.Visible = False



    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo

        sbLimpiar()
        sbHabilitar()
        Producto = New ClasesNegocio.ProductoGeneralClass()
        Me.dgvIngredientes.DataSource = Producto.ProductoPaquete




        'Me.dgvNutrientes.DataSource = Producto.Nutrientes
        Me.dgvCIR.DataSource = Producto.CostosIndirectosP
        Me.chkFacturaSinExistencia.Enabled = False
        'clmIngrediente.DataSource = CN.ProductoCollectionClass.CargarProductos(HC.ProductoFields.EsIngrediente = 1 And HC.ProductoFields.Estatus = "1")
        clmNutriente.DataSource = CN.NutrientesCollectionClass.CargarNutrientes(HC.CatNutrientesFields.Estatus = "1")
        'dgvIngredientes.AllowUserToAddRows = True
        'dgvNutrientes.AllowUserToAddRows = True
        PestanaHistorial()
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar

        If Validar() Then
            trans = New HC.Transaction(IsolationLevel.ReadCommitted, "AltaProd")
            Dim Productos As New CN.ProductoCollectionClass
            Dim Filtro As New PredicateExpression

            Dim lista As New ClasesNegocio.ListaPrecioClass
            MessageBox.Show(Utilerias.ObtenerCodSucursal.ToString())
            lista.ObtenerVigente(New CN.SucursalClass(Utilerias.ObtenerCodSucursal).Plaza.Codigo)
            Filtro.Add(HC.ProductoFields.CodigoBarra = txtCodigoBarra.Text.Trim() And HC.ProductoFields.Estatus = True)
            Productos.Obtener(Filtro)
            If Productos.Count = 0 Or (Productos.Count = 1 And Editar = True) Then
                Try
                    Cursor = Cursors.WaitCursor

                    If Not Validar() Then
                        Cancelar = True
                        Exit Sub
                    End If

                    sbGuardar()
                    If Producto.Guardar(trans) Then

                        ''si es un kit
                        If chkEsKit.Checked Then

                            If Editar Then
                                Dim kitcol As New CN.DetalleKitCollectionClass
                                kitcol.Obtener(HC.DetalleKitPvFields.IdKit = Producto.Codigo)
                                For Each row As CN.DetalleKitClass In kitcol
                                    DetalleKit = New CN.DetalleKitClass(Producto.Codigo, row.IdProd)
                                    If Not DetalleKit.Borrar() Then
                                        MsgBox("No se puedo borrar detalle del kit.", MsgBoxStyle.Critical, "Error")
                                        trans.Rollback()
                                        Cancelar = True
                                        Return
                                    End If
                                Next
                            End If

                            If sbGuardarKit() Then
                                trans.Commit()
                                MsgBox(String.Format("{0} se {1} satisfactoriamente", IIf(Me.rbEsMezcla.Checked, "La mezcla", "El producto"), IIf(Editar, "modifico", "guardo")), MsgBoxStyle.Information, "Aviso")
                                'sbLimpiar()
                                'sbDeshabilitar()
                            Else
                                trans.Rollback()
                            End If

                            Application.DoEvents()
                            If lista.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                                lista.AgregarProductosNuevos()
                                If Not lista.Guardar Then
                                    trans.Rollback()
                                    MsgBox("Error al actualizar la lista de precios.", MsgBoxStyle.Critical, "Error")
                                    Return
                                End If


                                ''si le colocan un precio lo actualiza automaticamente sin ir a la lista de precios listo para marcar en la nota de venta
                                'If CDbl(txtprecio.Text) > 0 And txtprecio.Text.Trim <> "" Then

                                Dim listadet As New ClasesNegocio.ListaPrecioDetalleClass(lista.Codigo, Producto.Codigo)
                                'listadet.PrecioVentaP = Convert.ToDecimal(txtprecio.Text)
                                listadet.PrecioVentaC = Convert.ToDecimal(lblTotalKit.Text.Replace("$", ""))
                                If Not listadet.Guardar() Then
                                    trans.Rollback()
                                    MsgBox("Error al actualizar el precio", MsgBoxStyle.Critical, "Error")
                                    Return
                                End If
                            End If

                            
                            sbLimpiar()
                            sbDeshabilitar()
                            

                            'End If
                        Else
                            Dim kitcol As New CN.DetalleKitCollectionClass
                            kitcol.Obtener(HC.DetalleKitPvFields.IdKit = Producto.Codigo)
                            For Each row As CN.DetalleKitClass In kitcol
                                DetalleKit = New CN.DetalleKitClass(Producto.Codigo, row.IdProd)
                                If Not DetalleKit.Borrar() Then
                                    MsgBox("No se puedo borrar detalle del kit.", MsgBoxStyle.Critical, "Error")
                                    trans.Rollback()
                                    Cancelar = True
                                    Return
                                End If
                            Next
                            trans.Commit()
                            Application.DoEvents()
                            If lista.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                                lista.AgregarProductosNuevos()
                                If Not lista.Guardar Then
                                    trans.Rollback()
                                    MsgBox("Error al actualizar la lista de precios.", MsgBoxStyle.Critical, "Error")
                                    Return
                                End If
                            End If
                           
                            MsgBox(String.Format("{0} se {1} satisfactoriamente", IIf(Me.rbEsMezcla.Checked, "La mezcla", "El producto"), IIf(Editar, "modifico", "guardo")), MsgBoxStyle.Information, "Aviso")
                            sbLimpiar()
                            sbDeshabilitar()
                        End If
                    Else
                        Cancelar = True
                        trans.Rollback()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Finally
                    Cursor = Cursors.Default
                End Try
            Else
                MsgBox("AVISO: producto que intentas dar de alta ya se encuentra activo.", MsgBoxStyle.Exclamation, "Aviso")
                sbLimpiar()
                sbDeshabilitar()
                Return
            End If
        Else
            Cancelar = True
            Return
        End If
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar
        If Producto.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If Producto.Borrar Then
                MessageBox.Show("El Producto ha sido desactivado.")
                sbDeshabilitar()
                Prods.Obtener()
                sbLimpiar()
            Else
                Cancelar = True
            End If
        Else
            MessageBox.Show("El Producto ya esta inactivo.")
            sbLimpiar()
            sbDeshabilitar()
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar

        puedorefrescar = True
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Dim ventana As New FrmBuscarProductos

        ventana.dgvProductosReg.Columns(ventana.clmExistencia.Index).Visible = False
        ventana.Edicion = True
        ventana.txtDescripcion.Focus()

        If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Prods = ventana.ProductosSeleccionados

            Producto = Prods.Item(0)

            Producto_Modificado(Me, e)
            llenarHistorialCompras()
            sbDeshabilitar()
            'Dim bit As New CN.BitacoraPV
            'bit.RecorrerForm(Me)
            'bit = Nothing

            Me.dgvIngredientes.DataSource = Producto.ProductoPaquete
            'Me.dgvNutrientes.DataSource = Producto.Nutrientes
            Me.dgvCIR.DataSource = Producto.CostosIndirectosP
            Me.lblestatus.Visible = True
            Seleccionado = True
            MostrarPestanas()
            Me.tbcPaquetes.Enabled = True
        Else
            Cancelar = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        Try
            Cursor = Cursors.WaitCursor
            If Producto.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                sbHabilitar()

                Me.chkFormula.Enabled = True
                Me.rbProductoGeneral.Enabled = True
                Me.chkIngrediente.Enabled = True
                Me.rbMaterialPaEnvases.Enabled = True

                'If chkIngrediente.Checked Then
                '    dgvNutrientes.AllowUserToAddRows = True
                'End If

                If chkFormula.Checked Then
                    dgvCIR.AllowUserToAddRows = True
                    dgvIngredientes.AllowUserToAddRows = True
                End If
                MostrarPestanas()

                Editar = True
                Me.txtDescripcion.Focus()
            Else
                If MessageBox.Show("El Producto esta inactivo, ¿Desea Activarlo?", "Activar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Select Case ClasesNegocio.EstatusEnum.INACTIVO
                        Case Producto.Linea.Estatus
                            MsgBox("No es posible activar el producto, la línea " & Producto.Linea.Descripcion & " esta inactiva", MsgBoxStyle.Exclamation, "Línea Inactiva")
                            Cancelar = True
                            Exit Sub
                        Case Producto.Marca.Estatus
                            MsgBox("No es posible activar el producto, la marca " & Producto.Marca.Nombre & " esta inactiva", MsgBoxStyle.Exclamation, "Marca Inactiva")
                            Cancelar = True
                            Exit Sub
                            'Case Producto.Linea.Estatus
                            '    MsgBox("No es posible activar el producto, la línea " & Producto.Linea.Descripcion & " esta inactiva", MsgBoxStyle.Exclamation, "Sub-Línea Inactiva")
                            '    Cancelar = True
                            '    Exit Sub
                        Case Producto.UnidadMedida.Estatus
                            MsgBox("No es posible activar el producto, la unidad de medida " & Producto.UnidadMedida.Descripcion & " esta inactiva", MsgBoxStyle.Exclamation, "Unidad de Medida Inactiva")
                            Cancelar = True
                            Exit Sub
                            'Case Producto.TProducto.Estatus
                            '    MsgBox("No es posible activar el producto, el tipo de producto " & Producto.TProducto.Descripcion & " esta inactivo", MsgBoxStyle.Exclamation, "Tipo de Producto Inactivo")
                            '    Cancelar = True
                            '    Exit Sub
                            'Case Producto.Presentacion.Estatus
                            '    MsgBox("No es posible activar el producto, la presentación " & Producto.Presentacion.Descripcion & " esta inactiva", MsgBoxStyle.Exclamation, "Presentación Inactiva")
                            '    Cancelar = True
                            '    Exit Sub
                    End Select

                    Producto.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblestatus.Text = Producto.Estatus.ToString
                    sbHabilitar()

                    Me.chkFormula.Enabled = False
                    Me.rbProductoGeneral.Enabled = False
                    Me.chkIngrediente.Enabled = False
                    Me.rbMaterialPaEnvases.Enabled = False

                    MostrarPestanas()

                    Editar = True
                    Me.txtDescripcion.Focus()
                Else
                    sbLimpiar()
                    sbDeshabilitar()
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
#End Region



    Private Sub cmbFamilia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFamilia.SelectedIndexChanged
        If Me.cmbFamilia.SelectedIndex = -1 Or cmbFamilia.ValueMember = "" Then Exit Sub
        Familia = New ClasesNegocio.LineaClass
        Familia = cmbFamilia.SelectedItem

        SubFamilias = Familia.ObtenerSubLinea()
        Me.cmbSubFamilia.DataSource = SubFamilias
        Me.cmbSubFamilia.DisplayMember = "Descripcion"
        Me.cmbSubFamilia.ValueMember = "Codigo"
        Me.cmbSubFamilia.SelectedIndex = -1
        Me.cmbSubFamilia.Text = "Seleccione una SubFamilia..."
    End Sub

    Private Sub frmABCProductos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If dgvKit.CurrentRow IsNot Nothing Then
                If e.KeyCode = Keys.F1 AndAlso dgvKit.CurrentRow.Cells(clmCodBarra.Index).Selected Then
                    If dgvKit.CurrentRow.Cells(clmCodBarra.Index).Selected Then

                        e.Handled = True
                        Dim ventana As New FrmBuscarProductos
                        ventana.dgvProductosReg.Columns(ventana.clmExistencia.Index).Visible = False
                        'ventana.Edicion = True
                        ventana.txtDescripcion.Focus()
                        'ventana.txtDescripcion.Text = valorcelda
                        ventana.txtDescripcion.Text = dgvKit.CurrentRow.Cells(clmCodBarra.Index).EditedFormattedValue.ToString
                        If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Dim prod As ClasesNegocio.ProductoGeneralClass = ventana.ProductosSeleccionados.Item(0)
                            endedit = True
                            e.Handled = True

                            SendKeys.Send(Chr(Keys.Enter))
                            Application.DoEvents()




                            dgvKit.CurrentRow.Cells(clmCodBarra.Index).Value = prod.CodigoBarra
                            dgvKit.CurrentRow.Cells(clmProducto.Index).Value = prod.Codigo
                            dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value = ObtenerVenta(prod.Codigo)
                            dgvKit.CurrentRow.Cells(clmCantidad.Index).Value = 1
                            dgvKit.CurrentRow.Cells(clmTotalPre.Index).Value = dgvKit.CurrentRow.Cells(clmCantidad.Index).Value * dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value
                            calcular()


                            endedit = False
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




        '    If Me.txtDescripcion.Enabled And Me.rbEsMezcla.Checked Then
        '        If e.KeyCode = Windows.Forms.Keys.F5 And Not Editar Then
        '            'Dim ventana = New frmListaProductosReg

        '            Dim ventana = New SistemaAgrosCS.Catalogos.Generales.ListaProdRegfrm

        '            ventana.Edicion = False

        '            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then

        '                Prods = ventana.ProductosSeleccionados

        '                For Each Pro As ClasesNegocio.Productos In Prods
        '                    If Pro.Paquete Then
        '                        Dim existe As Boolean
        '                        For Each ingrediente As ClasesNegocio.ProductosPaqueteClass In Pro.ProductoPaquete
        '                            Dim ingredienteN As New ClasesNegocio.ProductosPaqueteClass
        '                            ingredienteN.Cantidad = 0
        '                            ingredienteN.Ingrediente = ingrediente.Ingrediente
        '                            ingredienteN.Paquete = Producto

        '                            existe = False
        '                            For Each prod As ClasesNegocio.ProductosPaqueteClass In Producto.ProductoPaquete
        '                                If prod.Ingrediente.Codigo = ingrediente.Ingrediente.Codigo Then
        '                                    existe = True
        '                                    Exit For
        '                                End If
        '                            Next

        '                            If Not existe Then
        '                                Producto.ProductoPaquete.Add(ingredienteN)
        '                            End If
        '                        Next
        '                        'Si es ingrediente
        '                    Else
        '                        Dim existe As Boolean = False

        '                        For Each prod As ClasesNegocio.ProductosPaqueteClass In Producto.ProductoPaquete
        '                            If Pro.Codigo = prod.Ingrediente.Codigo Then
        '                                existe = True
        '                                Exit For
        '                            End If
        '                        Next

        '                        If Not existe Then
        '                            Dim paq As New ClasesNegocio.ProductosPaqueteClass
        '                            paq.Cantidad = 0
        '                            paq.Ingrediente = Pro
        '                            paq.Paquete = Producto

        '                            Producto.ProductoPaquete.Add(paq)
        '                        End If
        '                    End If
        '                Next
        '            End If
        '        ElseIf e.KeyCode = Windows.Forms.Keys.F6 Then
        '            Dim ventana = New SistemaAgrosCS.Catalogos.Generales.ListaCtosIndRegfrm

        '            If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '                Dim existe As Boolean

        '                For Each costoind As ClasesNegocio.CostosIndirectosClass In ventana.CI
        '                    Dim costo As New ClasesNegocio.ProdCostosIndirectosClass

        '                    costo.CostoIndirecto = costoind
        '                    costo.Importe = 0
        '                    costo.PDProducto = Producto

        '                    existe = False
        '                    For Each costos As ClasesNegocio.ProdCostosIndirectosClass In Producto.CostosIndirectosP
        '                        If costos.CostoIndirecto.IDCostosIndirectos = costoind.IDCostosIndirectos Then
        '                            existe = True
        '                            Exit For
        '                        End If
        '                    Next

        '                    If Not existe Then
        '                        Producto.CostosIndirectosP.Add(costo)
        '                    End If
        '                Next
        '            End If
        '        End If
        '    End If
        'End Sub

        ''Evento que al seleccionar el chkSeFactura selecciona tambien chkFacturarSinExistencia...
        'Private Sub chkSeFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeFactura.CheckedChanged
        '    If Not Me.chkSeFactura.Checked Then
        '        Me.chkFacturaSinExistencia.Checked = False
        '        Me.chkFacturaSinExistencia.Enabled = False
        '    Else
        '        Me.chkFacturaSinExistencia.Enabled = True
        '    End If
    End Sub

    Private Sub Producto_Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
        If puedorefrescar Then
            txtCodigo.Text = Producto.Codigo
            txtDescripcion.Text = Producto.Descripcion
            txtDescCorta.Text = Producto.DescCorta
            txtCaducidad.Text = Producto.DiasminCaducidad
            txtPiezas.Text = Producto.Piezas
            Me.lblestatus.Text = Producto.Estatus.ToString

            'cmbSubLinea.SelectedIndex = Producto.SubLinea.Codigo
            'Obtengo la Línea de la SubLínea
            'Dim SubLinea As New ClasesNegocio.SubLineaClass
            'SubLinea = cmbSubLinea.SelectedItem
            'cmbLinea.SelectedItem = SubLinea.Linea
            ' 
            'Me.cmbSubLinea.SelectedIndex = Producto.SubLinea.Codigo

            Me.cmbFamilia.SelectedValue = Producto.Linea.Codigo
            Me.cmbSubFamilia.SelectedValue = Producto.Linea.Codigo
            Me.cmbMarcas.SelectedValue = Producto.Marca.Codigo
            Me.cmbUnidadesMedida.SelectedValue = Producto.UnidadMedida.Codigo
            Me.cmbPresentacion.SelectedValue = Producto.Presentacion.Codigo
            Me.cmbTipoProd.SelectedValue = Producto.TProducto.Codigo

            chkSeFactura.Checked = Producto.SeFactura
            chkObtenerMermas.Checked = Producto.SeObtieneMermas
            chkFacturaSinExistencia.Checked = Producto.SeFacturaSinExistencia
            chkSeRecibeParcialmente.Checked = Producto.SeRecibeParcial
            chkSeReciveSinFactura.Checked = Producto.SeRecibeSinFactura
            chkSeManejaProLotes.Checked = Producto.SeManejaPorLotes
            rbProductoGeneral.Checked = Producto.ProductoGeneral
            Me.chkFormula.Checked = Producto.EsMezcla
            chkIngrediente.Checked = Producto.Ingrediente
            rbMaterialPaEnvases.Checked = Producto.MaterialEnvase
            chkCaduca.Checked = Producto.Caducidad

            Me.dgvCIR.AutoGenerateColumns = False
            Me.dgvIngredientes.AutoGenerateColumns = False

            Me.dgvCIR.DataSource = Producto.CostosIndirectosP
            Me.chkAplicaIva.Checked = Producto.SeAplicaIva
            Me.txtieps.Text = Format(Producto.PorcIEPS, "N2")
            Me.txtCodigoBarra.Text = Producto.CodigoBarra
            Me.chkEsKit.Checked = Producto.EsKit
            If chkEsKit.Checked Then
                BuscarKit = True
                Dim kitdetalles As New ClasesNegocio.DetalleKitCollectionClass
                kitdetalles.Obtener(HC.DetalleKitPvFields.IdKit = Producto.Codigo)
                For Each det As ClasesNegocio.DetalleKitClass In kitdetalles
                    dgvKit.Rows.Add(det.Producto.CodigoBarra.ToUpper, det.IdProd, det.Cantidad, ObtenerVenta(det.IdProd), det.Precio, (det.Cantidad * ObtenerVenta(det.IdProd)), (det.Cantidad * det.Precio))
                Next
                'dgvKit.DataSource = kitdetalles
                calcular()
                dgvKit.Enabled = False


            End If

            Dim Sucursal As New CN.SucursalClass(CN.UtileriasCN.ObtenerCodSucursal)
            '' llenar datos ultima compra
            Dim inv As New CN.AlmacenGeneral.InventarioAlmacenClass(Sucursal.IdAlmacen, Producto.Codigo, Date.Now.Year, Date.Now.Month)
            dtpFechaUltimaCompra.Value = inv.FechaUltimaEntrada
            txtUltimoCosto.Text = inv.UltimoCosto.ToString("N2")

            'Dim listpredet As New CN.ListaPrecioDetalleClass(1, Producto.Codigo)
            'txtprecio.Text = listpredet.PrecioVentaC
            MostrarPestanas()

        End If
        'Me.dgvIngredientes.AutoGenerateColumns = Producto.ProductosDelPaquete

    End Sub

    Private Sub chkCaduca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCaduca.CheckedChanged
        If Not chkCaduca.Checked Then
            txtCaducidad.Enabled = False
        Else
            txtCaducidad.Enabled = True
        End If
    End Sub

    Private Sub dgvIngredientes_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvIngredientes.CellBeginEdit
        ultimoporcentaje = Producto.ProductoPaquete(e.RowIndex).Cantidad
    End Sub

    Private Sub dgvIngredientes_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngredientes.CellEndEdit
        Dim suma As Decimal

        For Each prod As ClasesNegocio.ProductosPaqueteClass In Producto.ProductoPaquete
            suma += prod.Cantidad
        Next

        If suma > 100 Then
            MsgBox("La suma de los porcentajes debe ser 100", MsgBoxStyle.Exclamation, "Aviso")
            Producto.ProductoPaquete(e.RowIndex).Cantidad = ultimoporcentaje
        End If
    End Sub

    Private Sub dgvIngredientes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvIngredientes.DataError
        'If e.Exception.GetType.ToString = "System.FormatException" Then
        'MsgBox("Debe ingresar numeros en la celda", MsgBoxStyle.Exclamation, "Aviso")
        'End If
    End Sub

    Private Sub PestanaMezclas()
        Me.tbcPaquetes.Enabled = True
        Me.tbcPaquetes.TabPages.Clear()
        Me.tbcPaquetes.TabPages.Add(tpArmadoPaquetes)
        Me.tbcPaquetes.TabPages.Add(tpHistorial)
    End Sub

    Private Sub PestanaNutrientes()
        Me.tbcPaquetes.Enabled = True
        Me.tbcPaquetes.TabPages.Clear()
        'Me.tbcPaquetes.TabPages.Add(tpNutrientes)
        Me.tbcPaquetes.TabPages.Add(tpHistorial)
    End Sub

    Private Sub PestanaHistorial()
        Me.tbcPaquetes.Enabled = True
        Me.tbcPaquetes.TabPages.Clear()
        Me.tbcPaquetes.TabPages.Add(tpHistorial)
    End Sub

    Private Sub PestanaKit()
        Me.tbcPaquetes.Enabled = True
        Me.tbcPaquetes.TabPages.Clear()
        Me.tbcPaquetes.TabPages.Add(tpKit)
    End Sub

    Private Sub PestanaGeneral()
        Me.tbcPaquetes.Enabled = True
        Me.tbcPaquetes.TabPages.Clear()
        'Me.tbcPaquetes.TabPages.Add(tpNutrientes)
        Me.tbcPaquetes.TabPages.Add(tpArmadoPaquetes)
        Me.tbcPaquetes.TabPages.Add(tpHistorial)


    End Sub

    Private Sub HistorialdeCompras()
        Dim Compras As New CC.McomRecepcionOrdenCompraDetCollection
    End Sub

    'Private Sub dgvNutrientes_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
    '    If e.KeyCode = Keys.Delete Then
    '        If sender.SelectedRows(0).Index <> sender.Rows.Count - 1 Then
    '            If MessageBox.Show("¿Desea eliminarlo?", "ERP MEAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '                sender.Rows.RemoveAt(sender.SelectedRows(0).Index)
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub dgvNutrientes_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
    '    For i As Integer = 0 To dgvNutrientes.Rows.Count - 2
    '        If dgvNutrientes.Rows(i).Index <> e.RowIndex AndAlso dgvNutrientes.Rows(e.RowIndex).Cells(clmNutriente.Index).Value = dgvNutrientes.Rows(i).Cells(clmNutriente.Index).Value Then
    '            MsgBox("No se puede repetir el mismo nutriente", MsgBoxStyle.Exclamation, "ERP MEAT")
    '            e.Cancel = True
    '        End If
    '    Next
    'End Sub

    Private Sub dgvIngredientes_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvIngredientes.RowValidating
        For i As Integer = 0 To dgvIngredientes.Rows.Count - 2
            If dgvIngredientes.Rows(i).Index <> e.RowIndex AndAlso dgvIngredientes.Rows(e.RowIndex).Cells(clmIngrediente.Index).Value = dgvIngredientes.Rows(i).Cells(clmIngrediente.Index).Value Then
                MsgBox("No se puede repetir el mismo ingrediente", MsgBoxStyle.Exclamation, "ERP MEAT")
                e.Cancel = True
            End If
        Next
    End Sub

    Private Sub ValidarNumerico(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Not IsNumeric(sender.Text & e.KeyChar) And e.KeyChar <> Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    'Private Sub dgvNutrientes_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
    '    RemoveHandler e.Control.KeyPress, AddressOf ValidarNumerico
    '    AddHandler e.Control.KeyPress, AddressOf ValidarNumerico
    'End Sub

    Private Sub chkIngrediente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIngrediente.CheckedChanged
        'dgvNutrientes.AllowUserToAddRows = chkIngrediente.Checked

        If Not chkIngrediente.Checked Then
            Me.tbcPaquetes.Enabled = False
            'dgvNutrientes.DataSource = Nothing
        End If
        MostrarPestanas()
    End Sub

    Private Sub chkFormula_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFormula.CheckedChanged
        If chkFormula.Checked Then
            Me.rbIngrediente.Enabled = False
            Me.rbIngrediente.Checked = True
            Me.rbMaterialPaEnvases.Enabled = False
        Else
            Me.rbIngrediente.Enabled = True
            Me.rbIngrediente.Checked = True
            Me.rbMaterialPaEnvases.Enabled = True
        End If
        MostrarPestanas()
    End Sub

    Private Sub MostrarPestanas()
        If chkFormula.Checked AndAlso chkIngrediente.Checked Then
            PestanaGeneral()
        ElseIf chkFormula.Checked Then
            PestanaMezclas()
        ElseIf chkIngrediente.Checked Then
            PestanaNutrientes()
        ElseIf chkEsKit.Checked Then
            PestanaKit()
        Else
            PestanaHistorial()
        End If
    End Sub

    Public Sub llenarHistorialCompras()
        Using connection As SqlConnection = New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString.ToString)
            connection.Open()
            Dim sqlquery As String
            sqlquery = "SELECT Proveedor,Costo, REPLACE(CONVERT(VARCHAR(11),Fecha,106), ' ','/') as Fecha FROM( "
            sqlquery &= "select CP.PrRazSocial as Proveedor,RCD.Costo as Costo,RC.FechaRecepcion as Fecha,ROW_NUMBER() OVER(partition by  CP.PrRazSocial ORDER BY RC.FechaRecepcion desc) as Num, CCP.PdIdProducto as Idproducto "
            sqlquery &= "from MCatCompProductos CCP "
            sqlquery &= "inner join MComRecepcionOrdenCompraDet RCD on RCD.IdProducto = CCP.PdIdProducto "
            sqlquery &= "inner join MComRecepcionOrdenCompra RC on RC.IdRecepcionOrdenCompra = RCD.IdRecepcionOrdenCompra "
            sqlquery &= "inner join MCatCompProveedores CP on RC.IdProveedor = CP.PrIdProveedor "
            sqlquery &= ") A where A.Num = 1 and A.Idproducto =" & Producto.Codigo.ToString() & " "
            sqlquery &= "order by A.Fecha desc "
            Using comm As SqlCommand = New SqlCommand(sqlquery, connection)
                Dim rs As SqlDataReader = comm.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                dgvHistorialCompras.DataSource = dt
                ' as an example set the ValueMember and DisplayMember'
                ' to two columns of the returned table'
                'cmboxDatabaseName.ValueMember = "IDCustomer"
                'cmboxDatabaseName.DisplayMember = "Name"
                'cmboxDatabaseName.DataSource = dt
            End Using 'comm
        End Using
    End Sub

    Private Sub chkEsKit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEsKit.CheckedChanged



        If chkEsKit.Checked Then
            If Utilerias.ObtenerCodSucursal = 0 Then
                'mtb_ClickCancelar(New Object, Nothing, False)
                chkEsKit.Checked = False
                Exit Sub
            End If
            Me.tbcPaquetes.TabPages.Add(tpKit)
            Me.tbcPaquetes.SelectedTab = tpKit
            'chkAplicaIva.Enabled = False
            'chkSeFactura.Enabled = False
            'chkSeManejaProLotes.Enabled = False
            'chkCaduca.Enabled = False
            'txtCaducidad.Enabled = False
            'txtieps.Enabled = False
            gbdet.Enabled = False

        Else
            gbdet.Enabled = True
            Me.tbcPaquetes.TabPages.Remove(tpKit)
        End If
    End Sub

    Private Sub dgvKit_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvKit.RowValidating
        Dim pos As Point = dgvKit.PointToClient(Control.MousePosition)
        Dim hi As DataGridView.HitTestInfo = dgvKit.HitTest(pos.X, pos.Y)
        If hi.Type = DataGridViewHitTestType.Cell And hi.RowIndex <> e.RowIndex Then
            'e.Cancel = AllowChangeCurrent()
            'MessageBox.Show("..............................................", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            'If dgvKit.Rows(e.RowIndex).Cells(0).Value Is Nothing Or dgvKit.Rows(e.RowIndex).Cells(1).Value < 0 Or dgvKit.Rows(e.RowIndex).Cells(1).Value Is Nothing Then
            '    rowindexdelete = e.RowIndex
            'End If
            Exit Sub
        End If




        If dgvKit.Rows(e.RowIndex).Cells(clmProducto.Index).Value Is Nothing And (dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0 Or dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 1) And dgvKit.Rows(e.RowIndex).Cells(clmPreKit.Index).Value Is Nothing Then

            dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0
            dgvKit.Rows(e.RowIndex).Cells(clmPreVenta.Index).Value = Nothing
            dgvKit.Rows(e.RowIndex).Cells(clmTotalPre.Index).Value = Nothing
            e.Cancel = False
            RenglonValidado = True
        Else

            If dgvKit.Rows(e.RowIndex).Cells(clmProducto.Index).Value Is Nothing Then
                e.Cancel = True
                MessageBox.Show("Debe especificar el producto", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                RenglonValidado = False
            End If

            If Not IsNumeric(dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) _
            OrElse dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0 Then
                e.Cancel = True
                MessageBox.Show("Debe especificar la cantidad.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dgvKit.CurrentCell = dgvKit.Item(clmCantidad.Index, e.RowIndex)
                RenglonValidado = False
            End If

            If Not IsNumeric(dgvKit.Rows(e.RowIndex).Cells(clmPreKit.Index).Value) _
            OrElse dgvKit.Rows(e.RowIndex).Cells(clmPreKit.Index).Value = 0 Then
                e.Cancel = True
                MessageBox.Show("Debe especificar el precio de producto en kit.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dgvKit.CurrentCell = dgvKit.Item(clmPreKit.Index, e.RowIndex)
                RenglonValidado = False
            End If

        End If
    End Sub


    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub dgvKit_CellMouseUp(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvKit.CellMouseUp
        '        if (e.Button == MouseButtons.Right)
        '{
        '    this.dataGridView1.Rows[e.RowIndex].Selected = true;
        '    this.rowIndex = e.RowIndex;
        '    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
        '    this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
        '    contextMenuStrip1.Show(Cursor.Position);
        '}
        If e.Button = MouseButtons.Right Then
            Me.dgvKit.Rows(e.RowIndex).Selected = True
            Me.rowindex = e.RowIndex
            Me.dgvKit.CurrentCell = Me.dgvKit.Rows(e.RowIndex).Cells(1)
            Me.ContextMenuStrip1.Show(Me.dgvKit, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If

    End Sub

    Private Sub EliminarFilaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarFilaToolStripMenuItem.Click
        Me.dgvKit.Rows.RemoveAt(Me.rowindex)
        calcular()
    End Sub



    Private Sub frmABCProducosComprasGen_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            ' e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space)
            e.Handled = True
            'Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            SendKeys.Send(Chr(Keys.Tab))

        End If

        If txtprecio.Focused Then
            If e.KeyChar <> ChrW(Keys.Back) And (Not Char.IsNumber(e.KeyChar)) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "." Then
                MsgBox("Solo se permiten numeros.", MsgBoxStyle.Exclamation, "Advertencia")
                e.Handled = True
                Return

            End If
        End If

        If txtDescCorta.Focused Or txtDescripcion.Focused Then
            If e.KeyChar <> ChrW(Keys.Back) And (Not Char.IsLetterOrDigit(e.KeyChar)) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "#" And e.KeyChar <> "." And e.KeyChar <> "," And e.KeyChar <> ChrW(Keys.Space) Then
                MsgBox("Solo se permiten letras y numeros.", MsgBoxStyle.Exclamation, "Advertencia")
                e.Handled = True
                Return
            End If
        End If

        If txtCodigoBarra.Focused Then
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
                Return
            End If
        End If


    End Sub

    Private Sub dgvKit_Leave(sender As System.Object, e As System.EventArgs) Handles dgvKit.Leave
        Try
            If dgvKit.Rows.Count > 0 Then
                For Each row As DataGridViewRow In dgvKit.Rows
                    If Not row.IsNewRow Then
                        If row.Cells(0).Value Is Nothing Or (row.Cells(1).Value <= 0 Or row.Cells(1).Value Is Nothing Or row.Cells(3).Value Is Nothing) Then
                            dgvKit.Rows.RemoveAt(row.Index)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            calcular()
        End Try


    End Sub

    Private Sub dgvKit_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKit.CellEndEdit



        'If Not IsNumeric(dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) _
        'OrElse dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0 Then
        '    'e.Cancel = True
        '    MessageBox.Show("Debe especificar la cantidad.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    dgvKit.CurrentCell = dgvKit.Item(clmCantidad.Index, e.RowIndex)
        'End If
        If Not IsNumeric(dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) And dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value < 0 Then
            dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0
            MessageBox.Show("Campo cantidad acepta solo numeros.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Not IsNumeric(dgvKit.Rows(e.RowIndex).Cells(clmPreKit.Index).Value) And dgvKit.Rows(e.RowIndex).Cells(clmPreKit.Index).Value > 0 Then
            dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0
            MessageBox.Show("Campo Precio Kit acepta solo numeros.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If



        If dgvKit.Rows(e.RowIndex).Cells(clmProducto.Index).Value IsNot Nothing Then '' And IsNumeric(dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value) And dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value > 0 Then

            ''preCosto = 0D
            'preVenta = 0D
            ' MessageBox.Show("Calcula el precio costo y venta.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Dim sucursal As New CN.SucursalClass(Utilerias.ObtenerCodSucursal)
            'Dim sort As New SortExpression

            'sort.Add(New SortClause(HC.InventarioAlmacenFields.Año, _
            '            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
            'sort.Add(New SortClause(HC.InventarioAlmacenFields.Mes, _
            '            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))



            ''ultimoInventario.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And _
            ''            HC.InventarioAlmacenFields.ProductoId = idProducto, 1, sort)
            'Dim invs As New CC.InventarioAlmacenCollection

            'invs.GetMulti(HC.InventarioAlmacenFields.AlmacenId = sucursal.IdAlmacen And _
            '            HC.InventarioAlmacenFields.ProductoId = CInt(dgvKit.Rows(e.RowIndex).Cells(clmprod.Index).Value), 1, sort) 'And HC.InventarioAlmacenFields.Año = Now.Year And HC.InventarioAlmacenFields.Mes = Now.Month, 1)

            'If invs.Count > 0 Then
            '    Dim invAlmacen As New InventarioAlmacenEntity
            '    invAlmacen = invs(0)
            '    dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = CDbl(invAlmacen.CostoPromedio * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value)

            'Else
            '    dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = 0D
            'End If
            ''dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = ObtenerCosto(dgvKit.Rows(e.RowIndex).Cells(clmprod.Index).Value, dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value)

            'dgvKit.Rows(e.RowIndex).Cells(clmPreVenta.Index).Value = ObtenerVenta(dgvKit.Rows(e.RowIndex).Cells(clmprod.Index).Value)


            dgvKit.Rows(e.RowIndex).Cells(clmTotalPre.Index).Value = dgvKit.Rows(e.RowIndex).Cells(clmPreVenta.Index).Value * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value

            dgvKit.Rows(e.RowIndex).Cells(clmTotalPreKit.Index).Value = dgvKit.Rows(e.RowIndex).Cells(clmPreKit.Index).Value * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value
            'If dgvKit.Rows(e.RowIndex).Cells(clmPreKit.Index).Selected = True Then

            'End If


            'Dim lista As New CN.ListaPrecioDetalleClass(1, CInt(dgvKit.Rows(e.RowIndex).Cells(clmprod.Index).Value))
            'If lista IsNot Nothing Then
            '    dgvKit.Rows(e.RowIndex).Cells(clmPreVenta.Index).Value = CDbl(lista.PrecioVentaC * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value)

            'Else
            '    dgvKit.Rows(e.RowIndex).Cells(clmPreVenta.Index).Value = 0D
            'End If

        End If




        calcular()



    End Sub


    ''METODO PARA INTERPRETAR EL ENTET COMO UN TAB
    'Public Function GetNextCell(ByVal currentcell As DataGridViewCell) As DataGridViewCell
    '    Dim i As Integer = 0
    '    Dim nextcell As DataGridViewCell = currentcell

    'End Function


    'Private Sub dgvKit_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvKit.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Enter
    '            e.Handled = True
    '            SendKeys.Send("{TAB}")
    '    End Select
    'End Sub
    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
    '    'Return MyBase.ProcessCmdKey(msg, keyData)
    '    Dim KeyCode As Integer = CType(keyData, Integer)
    '    Dim key As Keys = CType(KeyCode, Keys)


    '    If (ActiveControl.GetType Is GetType(DataGridViewTextBoxEditingControl) OrElse ActiveControl.GetType Is GetType(DataGridViewComboBoxEditingControl)) OrElse ActiveControl Is dgvKit Then
    '        If ActiveControl.GetType Is GetType(DataGridViewTextBoxEditingControl) Then
    '            Dim dgvtec As DataGridViewTextBoxEditingControl = CType(Me.ActiveControl, DataGridViewTextBoxEditingControl)
    '        End If

    '    End If

    'End Function

    Private Sub frmABCProducosComprasGen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        'Me.dgvIngredientes.AutoGenerateColumns = False

        'clmIngrediente.DisplayMember = "Descripcion"
        'clmIngrediente.ValueMember = "Codigo"
        'clmNutriente.DisplayMember = "NomNutriente"
        'clmNutriente.ValueMember = "CveNutriente"



        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        mtb.ToolBarButtonStatus = MtbEstados

        mtb.sbCambiarEstadoBotones("Cancelar")

        'llena el combo de productos de la pestalla de kit
        Dim Prods As New ClasesNegocio.ProductoCollectionClass

        'Prods.Obtener(HC.ProductoFields.PdEsKit = False)
        Prods.Obtener()
        clmProducto.DisplayMember = "Descripcion"
        clmProducto.ValueMember = "Codigo"

        clmProducto.DataSource = Prods


        Try
            'clmIngrediente.DataSource = CN.ProductoCollectionClass.CargarProductos(HC.ProductoFields.EsIngrediente = 1 And HC.ProductoFields.Estatus = "1")
            'clmNutriente.DataSource = CN.NutrientesCollectionClass.CargarNutrientes(HC.CatNutrientesFields.Estatus = "1")

            Familias.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbFamilia.DataSource = Familias 'CVB.FuncionesCatalogos.ListaFamilia(ClasesNegocio.Condicion.Activos)
            Me.cmbFamilia.DisplayMember = "Descripcion"
            Me.cmbFamilia.ValueMember = "Codigo"
            Me.cmbFamilia.SelectedIndex = -1
            Me.cmbFamilia.Text = "Seleccione una Línea..."

            Marcas.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            'Me.cmbMarcas.DataSource = CVB.FuncionesCatalogos.ListaMarcas(ClasesNegocio.Condicion.Activos)
            Me.cmbMarcas.DataSource = Marcas
            Me.cmbMarcas.DisplayMember = "Nombre"
            Me.cmbMarcas.ValueMember = "Codigo"
            Me.cmbMarcas.SelectedIndex = -1
            Me.cmbMarcas.Text = "Seleccione una Marca..."

            UnidadesMedida.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            'Me.cmbUnidadesMedida.DataSource = CVB.FuncionesCatalogos.ListaUnidadesMedida(ClasesNegocio.Condicion.Activos)
            Me.cmbUnidadesMedida.DataSource = UnidadesMedida
            Me.cmbUnidadesMedida.DisplayMember = "Descripcion"
            Me.cmbUnidadesMedida.ValueMember = "Codigo"
            Me.cmbUnidadesMedida.SelectedIndex = -1
            Me.cmbUnidadesMedida.Text = "Seleccione una Unidad de Medida..."

            'Presentaciones.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            'Me.cmbPresentacion.DataSource = Presentaciones
            'Me.cmbPresentacion.DisplayMember = "Descripcion"
            'Me.cmbPresentacion.ValueMember = "Codigo"
            'Me.cmbPresentacion.SelectedIndex = -1
            'Me.cmbPresentacion.Text = "Seleccione una Presentación..."

            'TProds.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            'Me.cmbTipoProd.DataSource = TProds
            'Me.cmbTipoProd.DisplayMember = "Descripcion"
            'Me.cmbTipoProd.ValueMember = "Codigo"
            'Me.cmbTipoProd.SelectedIndex = -1
            'Me.cmbTipoProd.Text = "Seleccione un Tipo de Producto..."
            checkArtSinExis.Checked = True
            Me.dgvIngredientes.AutoGenerateColumns = False
            Me.dgvCIR.AutoGenerateColumns = False

            sbLimpiar()
            sbDeshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvKit_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles dgvKit.CurrentCellDirtyStateChanged
        ''DataGridViewColumn col = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex];
        'If Me.dgvKit.IsCurrentCellDirty Then
        '    MsgBox("mensaje", MsgBoxStyle.Information, "HOLA")
        ''End If
        'If dgvKit.CurrentCell Is System.Windows.Forms.DataGridViewComboBoxCell Then

        'End If



    End Sub

    Public Sub calcular()
        Dim precioKit As Decimal = 0
        preVenta = 0D
        For Each row As DataGridViewRow In dgvKit.Rows
            With row
                precioKit += .Cells(clmTotalPreKit.Index).Value
                preVenta += .Cells(clmTotalPre.Index).Value
            End With
        Next
        lblTotalKit.Text = precioKit.ToString("C2")
        lblTotalPrecio.Text = preVenta.ToString("C2")
    End Sub

    Private Sub dgvKit_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvKit.RowsRemoved
        calcular()
    End Sub

    Public Function ObtenerCosto(ByVal Codprod As Integer, ByVal cantidad As Integer) As Double
        Dim sucursal As New CN.SucursalClass(Utilerias.ObtenerCodSucursal)
        Dim sort As New SortExpression

        sort.Add(New SortClause(HC.InventarioAlmacenFields.Año, _
                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        sort.Add(New SortClause(HC.InventarioAlmacenFields.Mes, _
                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))



        'ultimoInventario.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And _
        '            HC.InventarioAlmacenFields.ProductoId = idProducto, 1, sort)
        Dim invs As New CC.InventarioAlmacenCollection

        invs.GetMulti(HC.InventarioAlmacenFields.AlmacenId = sucursal.IdAlmacen And _
                    HC.InventarioAlmacenFields.ProductoId = Codprod, 1, sort) 'And HC.InventarioAlmacenFields.Año = Now.Year And HC.InventarioAlmacenFields.Mes = Now.Month, 1)

        If invs.Count > 0 Then
            Dim invAlmacen As New InventarioAlmacenEntity
            invAlmacen = invs(0)
            Return CDbl(invAlmacen.CostoPromedio * cantidad)
            'dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = CDbl(invAlmacen.CostoPromedio * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value)

        Else
            'dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = 0D
            Return 0D
        End If

    End Function

    Public Function ObtenerVenta(ByVal Codprod As Integer) As Double
        Dim Det As New CN.ListaPrecioDetalleClass
        Dim suc As New CN.SucursalClass(Utilerias.ObtenerCodSucursal)
        Det.Obtener(suc.Plaza.ListasPrecio(0).Codigo, Codprod)
        If Det IsNot Nothing Then
            Return CDbl(Det.PrecioVentaC)
            'dgvKit.Rows(e.RowIndex).Cells(clmPreVenta.Index).Value = CDbl(lista.PrecioVentaC * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value)
        Else
            Return 0D
        End If
    End Function

    Private Sub dgvKit_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvKit.KeyUp
        'If e.KeyCode = Keys.Tab Then
        '    ''If dgvKit.CurrentCell.ReadOnly Then dgvKit.CurrentCell = GetNextCell(dgvKit.CurrentCell)
        '    e.Handled = True
        'End If
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If


    End Sub

    Private Sub dgvKit_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvKit.KeyDown

    End Sub


    Private Sub dgvKit_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvKit.RowsAdded
        If BuscarKit = False Then dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value = 0
    End Sub

    Private Sub dgvKit_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvKit.CellValidating
        If endedit = False Then
            If e.ColumnIndex = clmCodBarra.Index And e.FormattedValue <> "" Then
                Dim prod As New CN.ProductoCollectionClass

                prod.ObtenerCodBarra(e.FormattedValue)
                If prod.Count > 0 Then
                    If Not Editar Then
                        dgvKit.CurrentRow.Cells(clmProducto.Index).Value = prod(0).Codigo
                        dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value = ObtenerVenta(prod(0).Codigo)
                        dgvKit.CurrentRow.Cells(clmCantidad.Index).Value = 1
                        dgvKit.CurrentRow.Cells(clmTotalPre.Index).Value = dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value * dgvKit.CurrentRow.Cells(clmCantidad.Index).Value
                    End If
                    calcular()
                Else

                    MessageBox.Show("No existe codigo de barras.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgvKit.CurrentRow.Cells(clmProducto.Index).Value = 0
                    dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value = 0
                    dgvKit.CurrentRow.Cells(clmCantidad.Index).Value = 0
                    dgvKit.CurrentRow.Cells(clmTotalPre.Index).Value = 0
                    dgvKit.CurrentRow.Cells(clmCodBarra.Index).Selected = True
                    calcular()
                End If


            End If
        End If


    End Sub

    Private Sub dgvKit_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvKit.EditingControlShowing
        If TypeOf (e.Control) Is ComboBox Then
            Dim comboBox As ComboBox = CType(e.Control, ComboBox)

            If (comboBox IsNot Nothing) Then
                'Remove an existing event-handler
                RemoveHandler comboBox.SelectedIndexChanged, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

                'Add the event handler. 
                AddHandler comboBox.SelectedIndexChanged, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
            End If
        End If
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim comboBox As ComboBox = CType(sender, ComboBox)

        'Display selected value
        If comboBox IsNot Nothing Then
            Dim prod As CN.ProductoGeneralClass
            If TypeOf (comboBox.SelectedValue) Is CN.ProductoGeneralClass Then
                prod = CType(comboBox.SelectedValue, CN.ProductoGeneralClass)
                dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value = ObtenerVenta(prod.Codigo)
                dgvKit.CurrentRow.Cells(clmCodBarra.Index).Value = prod.CodigoBarra
            Else
                dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value = ObtenerVenta(comboBox.SelectedValue)
                prod = New CN.ProductoGeneralClass(CInt(comboBox.SelectedValue))
                dgvKit.CurrentRow.Cells(clmCodBarra.Index).Value = prod.CodigoBarra
            End If


            '' MsgBox("ProgramID: " & comboBox.SelectedValue.ToString)
            ' dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value = ObtenerVenta(prod.Codigo)

            dgvKit.CurrentRow.Cells(clmCantidad.Index).Value = 1
            dgvKit.CurrentRow.Cells(clmTotalPre.Index).Value = dgvKit.CurrentRow.Cells(clmPreVenta.Index).Value * dgvKit.CurrentRow.Cells(clmCantidad.Index).Value

            calcular()
        End If
    End Sub


    Private Sub dgvKit_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvKit.DataError
        e.ThrowException = False
    End Sub

    Private Sub dgvKit_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKit.CellValueChanged

        If e.ColumnIndex = clmCodBarra.Index Then
            If dgvKit.CurrentRow IsNot Nothing Then
                If dgvKit.CurrentRow.Cells(clmCodBarra.Index).Value <> "" Then
                    dgvKit.CurrentRow.Cells(clmCodBarra.Index).Value = dgvKit.CurrentRow.Cells(clmCodBarra.Index).Value.ToString.ToUpper
                End If
            End If
        End If

    End Sub
End Class