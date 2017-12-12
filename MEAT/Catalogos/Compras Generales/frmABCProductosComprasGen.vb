Imports System.Windows.Forms
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses

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
#End Region

#Region "Métodos"
    Private Sub sbLimpiar()
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()
        Me.txtDescCorta.Clear()
        Me.cmbFamilia.SelectedIndex = -1
        Me.cmbFamilia.Text = "Seleccione una Línea..."
        Me.cmbUnidadesMedida.SelectedIndex = -1
        Me.cmbUnidadesMedida.Text = "Seleccione un Unidad de Medida..."
        Me.cmbMarcas.SelectedIndex = -1
        Me.cmbMarcas.Text = "Seleccione una Marca..."
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
        Me.dgvNutrientes.DataSource = Nothing
        dgvIngredientes.AllowUserToAddRows = False
        dgvNutrientes.AllowUserToAddRows = False
        Me.txtCaducidad.Enabled = False
        Editar = False
        Me.lblestatus.Visible = False
        Seleccionado = False
        Me.txtCaducidad.Text = 0
        Me.chkAplicaIva.Checked = False
        Me.cmbSubFamilia.SelectedIndex = -1
    End Sub

    Private Sub sbHabilitar()
        Pan.Enabled = True
        rbEsMezcla.Enabled = True
        rbProductoGeneral.Enabled = True

        'If Me.chkFormula.Checked Or chkIngrediente.Checked Then
        '    Me.tbcPaquetes.Enabled = True
        'Else
        'End If
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
        Producto.FechaAlta = Me.dtpFecha.Value
        Producto.Descripcion = Me.txtDescripcion.Text
        Producto.DescCorta = Me.txtDescCorta.Text
        Producto.IdLinea = CType(Me.cmbFamilia.SelectedValue, Integer)
        Producto.UnidadMedida = Me.cmbUnidadesMedida.SelectedItem
        'Producto.Marca = Me.cmbMarcas.SelectedItem
        'Producto.Presentacion = Me.cmbPresentacion.SelectedItem
        'Producto.TProducto = Me.cmbTipoProd.SelectedItem
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
        Producto.DiasminCaducidad = Me.txtCaducidad.Text
        Producto.Piezas = 0
        puedorefrescar = True
    End Sub

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

        If Me.cmbUnidadesMedida.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una unidad de medida", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbUnidadesMedida.Focus()
            Return False
        End If

        'If Me.cmbMarcas.SelectedIndex = -1 Then
        '    MsgBox("Debe seleccionar una marca", MsgBoxStyle.Exclamation, "Faltan Datos")
        '    cmbMarcas.Focus()
        '    Return False
        'End If

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

    Private Sub rbEsMezcla_o_Producto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEsMezcla.CheckedChanged, rbProductoGeneral.CheckedChanged
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
        Dim Previsualizar As New CN.PreVisualizarForm

        If Me.Prods.Count = 0 Then
            Prods.Obtener()
        End If

        Previsualizar.Reporte = Prods.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnom)
        Previsualizar.ShowDialog()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
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
        Me.dgvNutrientes.DataSource = Producto.Nutrientes
        Me.dgvCIR.DataSource = Producto.CostosIndirectosP
        Me.chkFacturaSinExistencia.Enabled = False
        clmIngrediente.DataSource = CN.ProductoCollectionClass.CargarProductos(HC.ProductoFields.EsIngrediente = 1 And HC.ProductoFields.Estatus = "1")
        clmNutriente.DataSource = CN.NutrientesCollectionClass.CargarNutrientes(HC.CatNutrientesFields.Estatus = "1")
        dgvIngredientes.AllowUserToAddRows = True
        dgvNutrientes.AllowUserToAddRows = True
        PestanaHistorial()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Try
            Cursor = Cursors.WaitCursor

            If Not Validar() Or Not Me.Validate Then
                Cancelar = True
                Exit Sub
            End If

            sbGuardar()
            If Producto.Guardar() Then

                MsgBox(String.Format("{0} se {1} satisfactoriamente", IIf(Me.rbEsMezcla.Checked, "La mezcla", "El producto"), IIf(Editar, "modifico", "guardo")), MsgBoxStyle.Information, "Aviso")

                sbLimpiar()
                sbDeshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
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
        Dim ventana As New FrmBuscarProductos

        ventana.Edicion = True
        If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Prods = ventana.ProductosSeleccionados

            Producto = Prods.Item(0)
            Producto_Modificado(Me, e)
            sbDeshabilitar()

            Me.dgvIngredientes.DataSource = Producto.ProductoPaquete
            Me.dgvNutrientes.DataSource = Producto.Nutrientes
            Me.dgvCIR.DataSource = Producto.CostosIndirectosP
            Me.lblestatus.Visible = True
            Seleccionado = True
            MostrarPestanas()
            Me.tbcPaquetes.Enabled = True
        End If
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

                If chkIngrediente.Checked Then
                    dgvNutrientes.AllowUserToAddRows = True
                End If

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
                        Case Producto.Linea.Estatus
                            MsgBox("No es posible activar el producto, la línea " & Producto.Linea.Descripcion & " esta inactiva", MsgBoxStyle.Exclamation, "Sub-Línea Inactiva")
                            Cancelar = True
                            Exit Sub
                        Case Producto.UnidadMedida.Estatus
                            MsgBox("No es posible activar el producto, la unidad de medida " & Producto.UnidadMedida.Descripcion & " esta inactiva", MsgBoxStyle.Exclamation, "Unidad de Medida Inactiva")
                            Cancelar = True
                            Exit Sub
                        Case Producto.TProducto.Estatus
                            MsgBox("No es posible activar el producto, el tipo de producto " & Producto.TProducto.Descripcion & " esta inactivo", MsgBoxStyle.Exclamation, "Tipo de Producto Inactivo")
                            Cancelar = True
                            Exit Sub
                        Case Producto.Presentacion.Estatus
                            MsgBox("No es posible activar el producto, la presentación " & Producto.Presentacion.Descripcion & " esta inactiva", MsgBoxStyle.Exclamation, "Presentación Inactiva")
                            Cancelar = True
                            Exit Sub
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

    Private Sub frmABCProductosCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvIngredientes.AutoGenerateColumns = False
        Me.dgvNutrientes.AutoGenerateColumns = False
        clmIngrediente.DisplayMember = "Descripcion"
        clmIngrediente.ValueMember = "Codigo"
        clmNutriente.DisplayMember = "NomNutriente"
        clmNutriente.ValueMember = "CveNutriente"

        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "000100001"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        mtb.ToolBarButtonStatus = MtbEstados

        mtb.sbCambiarEstadoBotones("Cancelar")

        Try
            clmIngrediente.DataSource = CN.ProductoCollectionClass.CargarProductos(HC.ProductoFields.EsIngrediente = 1 And HC.ProductoFields.Estatus = "1")
            clmNutriente.DataSource = CN.NutrientesCollectionClass.CargarNutrientes(HC.CatNutrientesFields.Estatus = "1")

            Familias.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbFamilia.DataSource = Familias 'CVB.FuncionesCatalogos.ListaFamilia(ClasesNegocio.Condicion.Activos)
            Me.cmbFamilia.DisplayMember = "Descripcion"
            Me.cmbFamilia.ValueMember = "Codigo"
            Me.cmbFamilia.SelectedIndex = -1
            Me.cmbFamilia.Text = "Seleccione una Línea..."

            'Marcas.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            ''Me.cmbMarcas.DataSource = CVB.FuncionesCatalogos.ListaMarcas(ClasesNegocio.Condicion.Activos)
            'Me.cmbMarcas.DataSource = Marcas
            'Me.cmbMarcas.DisplayMember = "Nombre"
            'Me.cmbMarcas.ValueMember = "Codigo"
            'Me.cmbMarcas.SelectedIndex = -1
            'Me.cmbMarcas.Text = "Seleccione una Marca..."

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

            Me.dgvIngredientes.AutoGenerateColumns = False
            Me.dgvCIR.AutoGenerateColumns = False

            sbLimpiar()
            sbDeshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
        Me.tbcPaquetes.TabPages.Add(tpNutrientes)
        Me.tbcPaquetes.TabPages.Add(tpHistorial)
    End Sub

    Private Sub PestanaHistorial()
        Me.tbcPaquetes.Enabled = True
        Me.tbcPaquetes.TabPages.Clear()
        Me.tbcPaquetes.TabPages.Add(tpHistorial)
    End Sub

    Private Sub PestanaGeneral()
        Me.tbcPaquetes.Enabled = True
        Me.tbcPaquetes.TabPages.Clear()
        Me.tbcPaquetes.TabPages.Add(tpNutrientes)
        Me.tbcPaquetes.TabPages.Add(tpArmadoPaquetes)
        Me.tbcPaquetes.TabPages.Add(tpHistorial)
    End Sub

    Private Sub HistorialdeCompras()
        Dim Compras As New CC.McomRecepcionOrdenCompraDetCollection
    End Sub

    Private Sub dgvNutrientes_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvNutrientes.DataError

    End Sub

    Private Sub dgvNutrientes_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvNutrientes.PreviewKeyDown, dgvIngredientes.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If sender.SelectedRows(0).Index <> sender.Rows.Count - 1 Then
                If MessageBox.Show("¿Desea eliminarlo?", "ERP MEAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    sender.Rows.RemoveAt(sender.SelectedRows(0).Index)
                End If
            End If
        End If
    End Sub

    Private Sub dgvNutrientes_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvNutrientes.RowValidating
        For i As Integer = 0 To dgvNutrientes.Rows.Count - 2
            If dgvNutrientes.Rows(i).Index <> e.RowIndex AndAlso dgvNutrientes.Rows(e.RowIndex).Cells(clmNutriente.Index).Value = dgvNutrientes.Rows(i).Cells(clmNutriente.Index).Value Then
                MsgBox("No se puede repetir el mismo nutriente", MsgBoxStyle.Exclamation, "ERP MEAT")
                e.Cancel = True
            End If
        Next
    End Sub

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

    Private Sub dgvNutrientes_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNutrientes.EditingControlShowing, dgvIngredientes.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf ValidarNumerico
        AddHandler e.Control.KeyPress, AddressOf ValidarNumerico
    End Sub

    Private Sub chkIngrediente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIngrediente.CheckedChanged
        dgvNutrientes.AllowUserToAddRows = chkIngrediente.Checked

        If Not chkIngrediente.Checked Then
            Me.tbcPaquetes.Enabled = False
            dgvNutrientes.DataSource = Nothing
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
        Else
            PestanaHistorial()
        End If
    End Sub

End Class