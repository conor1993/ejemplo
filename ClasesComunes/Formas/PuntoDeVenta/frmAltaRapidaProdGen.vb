Imports System.Windows.Forms
Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports ClasesNegocio
Imports System.Data.SqlClient
Imports IntegraLab.ORMSeguridad
Imports ECS = IntegraLab.ORMSeguridad

Public Class frmAltaRapidaProdGen

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
    Dim esNuevo As Boolean = False
    Dim Almacen As ClasesNegocio.AlmacenClass
    Dim _FolioAlm As String = ""
    Dim InvMovAlmacenCab As CN.AlmacenGeneral.MovimientoAlmacenPVClass
    Dim InvMovAlmacenDet As CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass
    Dim m_invAlmacen = New CN.AlmacenGeneral.InventarioAlmacenClass()
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
        Me.txtCodigoBarra.Text = ""
        Me.dtpFecha.Value = Now
        Editar = False
        Me.lblestatus.Visible = False
        Seleccionado = False
        Me.chkIVA.Checked = False
        txtUltimoCosto.Clear()
        txtExistenciaActual.Clear()
        chkIVA.Checked = False
        txtCodigoBarra.Focus()
        txtNuevaExistencia.Text = ""
        txtIeps.Text = ""
    End Sub

    Private Sub sbHabilitar()
        Pan.Enabled = True
        gbInvenario.Enabled = True
        'Me.txtUltimoCosto.Enabled = False

    End Sub

    Private Sub sbDeshabilitar()
        Pan.Enabled = False
        gbInvenario.Enabled = False
    End Sub

    Private Sub sbGuardar()

        If Not txtCodigo.Text.Trim.Equals("") Then
            Producto = New CN.ProductoGeneralClass(CInt(txtCodigo.Text.Trim))
            Editar = True
        End If



        puedorefrescar = False


        ' Producto.SeAplicaIva = False
        If chkIVA.Checked Then
            Producto.SeAplicaIva = ClasesNegocio.AsignadaEnum.SI
        Else
            Producto.SeAplicaIva = ClasesNegocio.AsignadaEnum.NO
        End If

        Producto.PorcIEPS = 0
        Producto.ArtPuntoVenta = True
        Producto.FechaAlta = Me.dtpFecha.Value
        Producto.Descripcion = Me.txtDescripcion.Text
        Producto.DescCorta = Me.txtDescCorta.Text
        Producto.IdLinea = CType(Me.cmbFamilia.SelectedValue, Integer)
        Producto.UnidadMedida = Me.cmbUnidadesMedida.SelectedItem
        Producto.Marca = Me.cmbMarcas.SelectedItem
        Producto.CodigoBarra = txtCodigoBarra.Text
        Producto.SeFactura = False
        Producto.SeRecibeParcial = False
        Producto.SeObtieneMermas = False
        Producto.SeRecibeSinFactura = False
        Producto.SeFacturaSinExistencia = True
        Producto.SeManejaPorLotes = False
        Producto.ProductoGeneral = ClasesNegocio.AsignadaEnum.SI
        Producto.EsMezcla = False
        Producto.Ingrediente = False
        Producto.MaterialEnvase = False
        Producto.Caducidad = False
        Producto.DiasminCaducidad = 0
        Producto.Piezas = 0
        If Not txtIeps.Text.Trim.Equals("") Then
            Producto.PorcIEPS = txtIeps.Text.Trim
        Else
            Producto.PorcIEPS = 0.0
        End If





        'Me.m_invAlmacen.RellenarMe(Entity.DetAlimentos)


        If Application.ProductName.ToUpper() = "PUNTO DE VENTA" Or Application.ProductName.ToUpper() = "BACKEND" Then Producto.ArtPuntoVenta = True
        If Application.ProductName.ToUpper() = "MEAT" Then Producto.ArtMeat = True

        puedorefrescar = True
    End Sub

    Private Function Validar() As Boolean
        If Me.txtDescripcion.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtDescripcion.Focus()
            Return False
        End If

        'If Me.txtDescCorta.Text = "" Then
        '    MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
        '    Me.txtDescCorta.Focus()
        '    Return False
        'End If

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

        If Me.cmbFamilia.SelectedIndex = -1 Or Me.cmbFamilia.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar una familia", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbFamilia.Focus()
            Return False
        End If


        If Me.cmbMarcas.SelectedIndex = -1 Or cmbMarcas.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar una marca", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbMarcas.Focus()
            Return False
        End If

        If Me.cmbUnidadesMedida.SelectedIndex = -1 Or cmbUnidadesMedida.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar una unidad de medida", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbUnidadesMedida.Focus()
            Return False
        End If

        If txtCodigoBarra.Text.Trim = "" Then
            MsgBox("Debe ingresar un codigo de barras.", MsgBoxStyle.Exclamation, "Faltan Datos")
            txtCodigoBarra.Focus()
            Return False
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
        esNuevo = False
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo

        sbLimpiar()
        sbHabilitar()
        esNuevo = True

        If cmbUnidadesMedida.Items.Count <> 0 Then
            cmbUnidadesMedida.SelectedIndex = 0
        End If
        If cmbFamilia.Items.Count <> 0 Then
            cmbFamilia.SelectedIndex = 0
        End If
        If cmbMarcas.Items.Count <> 0 Then
            cmbMarcas.SelectedIndex = 0
        End If
        txtExistenciaActual.Text = CDec(0).ToString("N3")
        txtCodigoBarra.Focus()
        Producto = New ClasesNegocio.ProductoGeneralClass()
        clmNutriente.DataSource = CN.NutrientesCollectionClass.CargarNutrientes(HC.CatNutrientesFields.Estatus = "1")
        'dgvNutrientes.AllowUserToAddRows = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Or Not Me.Validate Then
                Cancelar = True
                Exit Sub
            End If

            If Editar Then
                Windows.Forms.Cursor.Current = Cursors.WaitCursor
                'Cursor = Cursors.WaitCursor
                Dim prods As New CN.ProductoCollectionClass
                prods.Obtener(HC.ProductoFields.CodigoBarra = txtCodigoBarra.Text.Trim Or HC.ProductoFields.Descripcion = txtDescripcion.Text.Trim)
                If prods.Count > 0 Then
                    Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "AltaProdRapida")

                    Dim lista As New ClasesNegocio.ListaPrecioClass(1)

                    sbGuardar()
                    If Producto.Guardar(trans) Then
                        trans.Commit()
                        Application.DoEvents()

                        ''actualza la existencia
                        If txtNuevaExistencia.Text.Trim() <> "" Then
                            ActualizarExistencia()
                        End If

                        lista.AgregarProductosNuevos()
                        If Not lista.Guardar Then
                            trans.Rollback()
                            MsgBox("Error al actualizar la lista de precios.", MsgBoxStyle.Critical, "Error")
                            Return
                        End If
                        Dim listadet As New ClasesNegocio.ListaPrecioDetalleClass(lista.Codigo, Producto.Codigo)

                        If txtUltimoCosto.Text.Trim() <> "" And IsNumeric(txtUltimoCosto.Text) Then
                            listadet.PrecioVentaP = Convert.ToDecimal(txtUltimoCosto.Text)
                            listadet.PrecioVentaC = Convert.ToDecimal(txtUltimoCosto.Text)
                            If Not listadet.Guardar() Then
                                trans.Rollback()
                                MsgBox("Error al actualizar el precio", MsgBoxStyle.Critical, "Error")
                                Return
                            End If
                        End If


                        MsgBox(String.Format("{0} se {1} satisfactoriamente", "El producto", IIf(Editar, "modifico", "guardo")), MsgBoxStyle.Information, "Aviso")

                        sbLimpiar()
                        sbDeshabilitar()
                    Else
                        MsgBox("Error al guardar producto", MsgBoxStyle.Exclamation, "Aviso")
                        trans.Rollback()
                        Cancelar = True
                    End If
                End If
            Else
                Dim prods As New CN.ProductoCollectionClass
                prods.Obtener(HC.ProductoFields.CodigoBarra = txtCodigoBarra.Text.Trim Or HC.ProductoFields.Descripcion = txtDescripcion.Text.Trim)
                If prods.Count > 0 Then
                    Cancelar = True
                    MsgBox("Ya se encuentra dado de alta el producto " & prods(0).Descripcion & " con el codigo de barra: " + txtCodigoBarra.Text.Trim.ToUpper, MsgBoxStyle.Exclamation, "Aviso")
                    Return
                Else
                    Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    'Cursor = Cursors.WaitCursor
                    Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "AltaProdRapida")

                    Dim lista As New ClasesNegocio.ListaPrecioClass(1)

                    sbGuardar()
                    If Producto.Guardar(trans) Then
                        trans.Commit()
                        Application.DoEvents()

                        If txtNuevaExistencia.Text.Trim() <> "" Then
                            ActualizarExistencia()
                        End If

                        lista.AgregarProductosNuevos()
                        If Not lista.Guardar Then
                            trans.Rollback()
                            MsgBox("Error al actualizar la lista de precios.", MsgBoxStyle.Critical, "Error")
                            Return
                        End If
                        Dim listadet As New ClasesNegocio.ListaPrecioDetalleClass(lista.Codigo, Producto.Codigo)

                        If txtUltimoCosto.Text.Trim() <> "" And IsNumeric(txtUltimoCosto.Text) Then
                            listadet.PrecioVentaP = Convert.ToDecimal(txtUltimoCosto.Text)
                            listadet.PrecioVentaC = Convert.ToDecimal(txtUltimoCosto.Text)
                            If Not listadet.Guardar() Then
                                trans.Rollback()
                                MsgBox("Error al actualizar el precio", MsgBoxStyle.Critical, "Error")
                                Return
                            End If
                        End If


                        MsgBox(String.Format("{0} se {1} satisfactoriamente", "El producto", IIf(Editar, "modifico", "guardo")), MsgBoxStyle.Information, "Aviso")

                        sbLimpiar()
                        sbDeshabilitar()
                        esNuevo = False
                    Else
                        MsgBox("Error al guardar producto", MsgBoxStyle.Exclamation, "Aviso")
                        trans.Rollback()
                        Cancelar = True
                    End If
                End If
            End If

                'If prods.Count = 0 Then
                '    Windows.Forms.Cursor.Current = Cursors.WaitCursor
                '    'Cursor = Cursors.WaitCursor
                '    Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "AltaProdRapida")

                '    Dim lista As New ClasesNegocio.ListaPrecioClass(1)

                '    sbGuardar()
                '    If Producto.Guardar(trans) Then
                '        trans.Commit()
                '        Application.DoEvents()
                '        lista.AgregarProductosNuevos()
                '        If Not lista.Guardar Then
                '            trans.Rollback()
                '            MsgBox("Error al actualizar la lista de precios.", MsgBoxStyle.Critical, "Error")
                '            Return
                '        End If
                '        Dim listadet As New ClasesNegocio.ListaPrecioDetalleClass(lista.Codigo, Producto.Codigo)

                '        If txtUltimoCosto.Text.Trim() <> "" And IsNumeric(txtUltimoCosto.Text) Then
                '            listadet.PrecioVentaP = Convert.ToDecimal(txtUltimoCosto.Text)
                '            listadet.PrecioVentaC = Convert.ToDecimal(txtUltimoCosto.Text)
                '            If Not listadet.Guardar() Then
                '                trans.Rollback()
                '                MsgBox("Error al actualizar el precio", MsgBoxStyle.Critical, "Error")
                '                Return
                '            End If
                '        End If


                '        MsgBox(String.Format("{0} se {1} satisfactoriamente", "El producto", IIf(Editar, "modifico", "guardo")), MsgBoxStyle.Information, "Aviso")

                '        sbLimpiar()
                '        sbDeshabilitar()
                '    Else
                '        MsgBox("Error al guardar producto", MsgBoxStyle.Exclamation, "Aviso")
                '        trans.Rollback()
                '        Cancelar = True
                '    End If
                'Else
                '    Cancelar = True
                '    MsgBox("EL producto ya se encuentra dado de alta.", MsgBoxStyle.Exclamation, "Aviso")
                '    Return
                'End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
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

            Me.lblestatus.Visible = True
            Seleccionado = True
        End If
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        Try
            Cursor = Cursors.WaitCursor
            If Producto.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                sbHabilitar()

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
#If DEBUG Then
        txtRegistrosql.Visible = True
#End If
        Try


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


            sbLimpiar()
            sbDeshabilitar()

            Dim permiso As New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, Controlador.Sesion.MiUsuario.Usrndx)

            If Not IsDBNull(permiso.Usrtipo) Then
                If permiso.Usrtipo.Equals("A") Then
                    txtNuevaExistencia.Enabled = True
                Else
                    txtNuevaExistencia.Enabled = False
                End If
            End If

            'Dim Grupo As New CollectionClasses.DetallegruposCollection()
            'Grupo.GetMulti(HelperClasses.DetallegruposFields.Usrndx = Controlador.Sesion.MiUsuario.Usrndx And HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
            'Dim gpo As Integer = 0
            'For Each elem As EntityClasses.DetallegruposEntity In Grupo
            '    gpo = elem.Gpondx
            'Next

            'If gpo = 1 Then
            '    txtNuevaExistencia.Enabled = True
            'Else
            '    txtNuevaExistencia.Enabled = False
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbFamilia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFamilia.SelectedIndexChanged
        If Me.cmbFamilia.SelectedIndex = -1 Or cmbFamilia.ValueMember = "" Then Exit Sub
        Familia = New ClasesNegocio.LineaClass
        Familia = cmbFamilia.SelectedItem

        SubFamilias = Familia.ObtenerSubLinea()
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
            Me.lblestatus.Text = Producto.Estatus.ToString

            Me.cmbFamilia.SelectedValue = Producto.Linea.Codigo
            Me.cmbMarcas.SelectedValue = Producto.Marca.Codigo
            Me.cmbUnidadesMedida.SelectedValue = Producto.UnidadMedida.Codigo

            Me.txtCodigoBarra.Text = Producto.CodigoBarra

        End If

    End Sub

    Private Sub HistorialdeCompras()
        Dim Compras As New CC.McomRecepcionOrdenCompraDetCollection
    End Sub

    Private Sub ValidarNumerico(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Not IsNumeric(sender.Text & e.KeyChar) And e.KeyChar <> Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmAltaRapidaProdGen_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            ' e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space)
            e.Handled = True
            'Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            If txtCodigoBarra.Focused And esNuevo = False Then
                buscar()
            End If

            SendKeys.Send(Chr(Keys.Tab))

        End If

        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
            Me.Dispose()
        End If

    End Sub

    Private Sub Pan_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Pan.Paint

    End Sub

    Private Sub txtCodigoBarra_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarra.KeyPress
        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

        '    ' e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space)
        '    e.Handled = True

        '    'Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        '    ''SendKeys.Send(Chr(Keys.Tab))
        '    buscar()
        'End If
    End Sub

    Public Sub buscar()
        Prods = New CN.ProductoCollectionClass
        Prods.ObtenerCodBarra(txtCodigoBarra.Text.Trim)
        If Prods.Count > 0 Then
            Producto = CType(Prods(0), CN.ProductoGeneralClass)
            txtCodigo.Text = Producto.Codigo.ToString
            txtDescripcion.Text = Producto.Descripcion
            txtDescCorta.Text = Producto.DescCorta
            cmbFamilia.SelectedValue = Producto.IdLinea
            cmbMarcas.SelectedValue = Producto.Marca.Codigo
            cmbUnidadesMedida.SelectedValue = Producto.UnidadMedida.Codigo
            txtUltimoCosto.Text = Producto.PrecioV
            chkIVA.Checked = Producto.SeAplicaIva
            txtIeps.Text = Producto.PorcIEPS.ToString("N2")
            txtExistenciaActual.Text = Producto.CantidadExistencia
            'txtNuevaExistencia.Text = CDec(0).ToString("N3")
            Pan.Enabled = True
            gbInvenario.Enabled = True
            mtb.sbCambiarEstadoBotones("Editar")
            Editar = True
        Else
            MessageBox.Show("No se encontro articulo.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Prods = Nothing
        End If



    End Sub

    Public Sub ActualizarExistencia()
        Dim resultado As New DataSet()
        Dim str As String = "SELECT Cast(isnull(x.CantidadExistencia,0) as decimal(16,3))  as Existencia,X.Almacenid,x.Año,x.Mes " &
                            "FROM( " &
                            "select *,row_number() over (partition by ProductoId order by AlmacenId,ProductoId,Año desc ,Mes desc) as Det from MInvAlmacen " &
                            ") x " &
                            "WHERE x.ProductoId =" & Producto.Codigo.ToString &
                            " and x.Det = 1"

        Dim cmd As SqlCommand = New SqlCommand(str, New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))
        cmd.CommandType = CommandType.Text

        Dim adapter As New SqlDataAdapter(cmd)
        adapter.SelectCommand.CommandTimeout = 300

        Dim DS As DataSet
        adapter.Fill(resultado)
        cmd.Dispose()
        Try
            If resultado.Tables(0).Rows.Count <> 0 Then
                With resultado.Tables(0).Rows(0)

                    str = "update MInvAlmacen set CantidadExistencia = " & txtNuevaExistencia.Text.Trim &
                          " where AlmacenId = " & .Item(1).ToString &
                          " and Año = " & .Item(2).ToString &
                          " and Mes = " & .Item(3).ToString &
                          " and ProductoId = " & Producto.Codigo.ToString
                    txtRegistrosql.Text = str
                    Dim cn As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)
                    cn.Open()
                    cmd = New SqlCommand(str, cn)
                    cmd.CommandType = CommandType.Text
                    If cmd.ExecuteNonQuery <> 1 Then
                        MessageBox.Show("No se puedo guardar existencia del articulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Dim Usuario As New UsuarioClass(Controlador.Sesion.Usrndx)
                        str = "insert into PVHistorialCambioExistAltRap " &
                              "values (" & .Item(1).ToString &
                              "," & Producto.Codigo.ToString &
                              "," & txtExistenciaActual.Text.Trim &
                              "," & txtNuevaExistencia.Text.Trim &
                              "," & Controlador.Sesion.Usrndx.ToString &
                              ",'" & Usuario.UserName &
                              "'," & "(select getdate())" &
                              ")"
                        cmd = New SqlCommand(str, cn)
                        cmd.CommandType = CommandType.Text
                        If cmd.ExecuteNonQuery <> 1 Then
                            MessageBox.Show("No se puedo guardar el historial cambio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                    End If
                    cn.Close()

                End With
            Else
                Dim sucursal As New CN.SucursalClass
                sucursal.Obtener(Utilerias.ObtenerControlTurnoActual.CodSucursal)
                'obtiene la letra serie del almacen seleccionado

                str = "insert into MInvAlmacen " &
                       "values(" & sucursal.IdAlmacen.ToString & "," &
                       Producto.Codigo.ToString & "," &
                       "(select year(Getdate()))," &
                       "(select month(Getdate()))," &
                       "'01-01-1900'," &
                       "0," &
                       "0," &
                       "0," &
                       txtNuevaExistencia.Text.Trim & "," &
                       "0," &
                       "null," &
                       "0," &
                       "null," &
                       "0" &
                       ")"
                txtRegistrosql.Text = str
                Application.DoEvents()
                Dim cn As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)
                cn.Open()
                cmd = New SqlCommand(str, cn)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery <> 1 Then
                    MessageBox.Show("No se puedo guardar existencia del articulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    Dim Usuario As New UsuarioClass(Controlador.Sesion.Usrndx)
                    str = "insert into PVHistorialCambioExistAltRap " &
                          "values (" & sucursal.IdAlmacen.ToString &
                          "," & Producto.Codigo.ToString &
                          "," & txtExistenciaActual.Text.Trim &
                          "," & txtNuevaExistencia.Text.Trim &
                          "," & Controlador.Sesion.Usrndx.ToString &
                          ",'" & Usuario.UserName.ToString &
                          "'," & "(select getdate())" &
                          ")"
                    txtRegistrosql.Text = str
                    cmd = New SqlCommand(str, cn)
                    cmd.CommandType = CommandType.Text
                    If cmd.ExecuteNonQuery <> 1 Then
                        MessageBox.Show("No se puedo guardar el historial cambio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
                cn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtUltimoCosto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUltimoCosto.TextChanged

    End Sub

    Private Sub txtUltimoCosto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUltimoCosto.KeyPress
        ValidarNumerico(sender, e)
    End Sub

    Private Sub txtExistenciaActual_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExistenciaActual.KeyPress
        ValidarNumerico(sender, e)
    End Sub

    Private Sub txtNuevaExistencia_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevaExistencia.KeyPress
        ValidarNumerico(sender, e)
    End Sub
End Class