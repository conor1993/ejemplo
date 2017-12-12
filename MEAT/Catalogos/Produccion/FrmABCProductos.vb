'Programa:          ERP MEAT
'Objetivo:          
'Modulo:            ABC de Productos
'Elaboro:           
'Fecha Inicio:      
'Fecha Modificado:  
'Fecha Terminado:   
'Fecha Modificado:  Miercoles, 13 de Junio de 2009
'Modificado Por:    Jorge Alfredo Niebla Ojeda

Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmABCProductosCompras

    Dim LbNuevo As Boolean
    Private WithEvents Productos As New ProductosClass
    Public Codigos As New List(Of Integer)
    Dim buscando As Boolean = False


#Region "Metodos"
    Private Sub Limpiar()
        Dim a As New Integralab.ORM.TypedViewClasses.ComCotizacionesTypedView

        Me.ProductosC.Clear()
        '  Me.chkProductoValorAgregado.Checked = True
        Me.chkProductoValorAgregado.Checked = False
        Codigos.Clear()
        Me.txtCodigo.Text = 0
        Me.txtMaximoPiezasxCaja.Clear()
        Me.txtCodigoBarra.Clear()
        Me.txtPrecio.Clear()
        Me.txtPiezasXCabeza.Clear()
        'Me.txtCuentaContable.Clear()
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.lblEstatus.Text = "ESTATUS"
        Me.txtNombreIngles.Text = ""
        Me.lblEstatus.Visible = False
        Me.chkProductoValorAgregado.Checked = False
        Me.chkManejoPiezas.Checked = False
        Me.chkDecomisable.Checked = False
        Me.chkSubproducto.Checked = False
        Me.chkCanal.Checked = False
        Me.chkCorte.Checked = False
        'Me.txtObservaciones.Clear()
    End Sub

    Private Sub Habilitar()
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.GroupBox1.Enabled = False
        Me.chkProductoValorAgregado.Checked = False
    End Sub

    Private Sub LlenarDecomisos()
        Me.lsbListaDecomiso.DataSource = Nothing
        Dim idDecomisos As New List(Of Integer)

        For i As Integer = 0 To Me.lsbDecomisosAgregados.Items.Count - 1
            Me.lsbDecomisosAgregados.SelectedIndex = i
            idDecomisos.Add(Me.lsbDecomisosAgregados.SelectedValue)
        Next

        Try
            Me.MotivosDecomisoC.Obtener(CondicionEnum.ACTIVOS, idDecomisos.ToArray)
            Me.lsbListaDecomiso.DataSource = Me.MotivosDecomisoC
        Catch ex As Exception

        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.txtDescripcion.Text = "" Then
                MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            ElseIf Me.txtDescCorta.Text = "" Then
                MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            ElseIf Me.txtNombreIngles.Text = "" Then
                MsgBox("Debe ingresar un nombre en ingles", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            ElseIf Me.txtPrecio.Text = "" OrElse CDec(Me.txtPrecio.Text.Replace("$", "").Replace(",", "")) = 0 Then
                MsgBox("Debe ingresar un precio", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            ElseIf Me.txtPiezasXCabeza.Text = "" OrElse CDec(Me.txtPiezasXCabeza.Text.Replace(",", "")) = 0 Then
                MsgBox("Debe ingresar un las piezas por cabeza", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            ElseIf Me.chkCanal.Checked Then
                Dim colProd As New CC.MsccatProductosCollection

                If colProd.GetDbCount(HC.MsccatProductosFields.Canal = 1) > 0 AndAlso Productos.Entidad.IsNew Then
                    MsgBox("Ya existe un producto registrado como canal", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                Dim colProd As New CC.MsccatProductosCollection

                Dim num1 As Integer = colProd.GetDbCount(HC.MsccatProductosFields.Descripcion = txtDescripcion.Text.Trim)
                Dim num2 As Integer = colProd.GetDbCount(HC.MsccatProductosFields.DescripcionCorta = txtDescCorta.Text.Trim)

                If Productos.Entidad.IsNew Then
                    If num1 > 0 Then
                        MsgBox("Ya existe un producto registrado con esa descripcion", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If

                    If num2 > 0 Then
                        MsgBox("Ya existe un producto registrado con esa descripcion corta", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                Else
                    Dim num3 As Integer = colProd.GetDbCount(HC.MsccatProductosFields.Descripcion = txtDescripcion.Text.Trim And HC.MsccatProductosFields.Estatus = 1 And HC.MsccatProductosFields.IdProducto <> Integer.Parse(txtCodigo.Text))

                    If num3 <> 0 Then

                        If num1 > 0 Then
                            MsgBox("Ya existe un producto registrado con esa descripcion", MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        End If

                        If num2 > 0 Then
                            MsgBox("Ya existe un producto registrado con esa descripcion corta", MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        End If
                    End If
                End If
                End If

                Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "ToolBar"

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim ventana As New frmBusquedaProductos

            ventana.Icon = Icon

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Productos = ventana.ProductosC(ventana.DataGridView1.SelectedRows(0).Index)
                Me.ProductosC.Clear()
                Me.ProductosC.Add(Productos)
                Me.Productos.Detalle.ResetBindings()

                Me.txtDescripcion.Text = Me.Productos.Descripcion
                Me.txtDescCorta.Text = Me.Productos.DescripcionCorta
                Me.txtNombreIngles.Text = Productos.NombreIngles
                Me.chkDecomisable.Checked = Me.Productos.Decomisa
                Me.chkManejoPiezas.Checked = Me.Productos.EnPiezas
                Me.chkSubproducto.Checked = Me.Productos.SubProducto
                Me.chkCanal.Checked = Productos.Canal
                Me.txtMaximoPiezasxCaja.Text = Me.Productos.MaximoPiezasxCaja.ToString("N3")
                Me.txtPrecio.Text = Me.Productos.PrecioXKilo.ToString("N3")
                Me.txtPiezasXCabeza.Text = Me.Productos.PiezasXCabeza.ToString("N3")
                Me.txtCodigoBarra.Text = Me.Productos.CodigoBarra
                Me.chkSubproducto.Checked = Productos.SubProducto
                Me.chkProductoValorAgregado.Checked = Productos.ObtenerEntidad.ValorAgregado
                ' Me.Productos.Observaciones = Me.txtObservaciones.Text
                Me.lblEstatus.Text = Me.Productos.Estatus.ToString
                Me.chkMerma.Checked = Me.Productos.EsMerma
                Me.chkDerivable.Checked = Me.Productos.EsDerivable
                'Me.lsbDecomisosAgregados.DataSource = Me.Productos.Detalle
                Me.Panel1.Enabled = False
                Me.grpListaDecomisosAgregados.Enabled = False
                Me.grpListaDecomisos.Enabled = False
                Me.lblEstatus.Visible = True

                If Me.chkProductoValorAgregado.Checked Then
                    Dim col As New CC.MscproductosValorAgregadoCollection

                    col.GetMulti(HC.MscproductosValorAgregadoFields.IdProducto = Productos.IdProducto)

                    Codigos.Clear()

                    For Each ent As EC.MscproductosValorAgregadoEntity In col
                        Codigos.Add(ent.IdSubCorte)
                    Next
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Cursor = Cursors.WaitCursor

        Try
            If Me.Productos.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then

                If MessageBox.Show("El producto esta cancelado. ¿Quiere Activarlo?", "Activar producto", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = _
                    Windows.Forms.DialogResult.Yes Then
                    Productos.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Else
                    Cancelar = True
                    Exit Sub
                End If
            End If
            Habilitar()
            buscando = True
            chkDecomisable_CheckedChanged(Me, New EventArgs())
        Catch ex As Exception

        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")

        Try
            If Not Me.Validar Then
                Cancelar = True
                Exit Sub
            End If

            Me.Productos.Descripcion = Me.txtDescripcion.Text
            Me.Productos.DescripcionCorta = Me.txtDescCorta.Text
            Me.Productos.NombreIngles = Me.txtNombreIngles.Text.Trim
            Me.Productos.SubProducto = Me.chkSubproducto.Checked
            Me.Productos.Decomisa = Me.chkDecomisable.Checked
            Me.Productos.EnPiezas = Me.chkManejoPiezas.Checked
            Me.Productos.SubProducto = Me.chkSubproducto.Checked
            Me.Productos.MaximoPiezasxCaja = Me.txtMaximoPiezasxCaja.Text.Replace(",", "")
            Me.Productos.PrecioXKilo = CDec(Me.txtPrecio.Text.Replace("$", "").Replace(",", ""))
            Me.Productos.PiezasXCabeza = CDec(Me.txtPiezasXCabeza.Text.Replace(",", ""))
            Me.Productos.CodigoBarra = Me.txtCodigoBarra.Text
            Me.Productos.SubProducto = Me.chkSubproducto.Checked
            Me.Productos.Canal = Me.chkCanal.Checked
            Me.Productos.Corte = Me.chkCorte.Checked
            Me.Productos.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            Me.Productos.EsMerma = Me.chkMerma.Checked
            Me.Productos.EsDerivable = Me.chkDerivable.Checked
            Me.Productos.ObtenerEntidad.ValorAgregado = Me.chkProductoValorAgregado.Checked


            If Not Me.Productos.Guardar(trans) Then
                trans.Rollback()
                MessageBox.Show("No se ha podido guardar el producto, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
                Exit Sub
            End If

            If Me.chkProductoValorAgregado.Checked Then
                If Not Codigos Is Nothing Then  ' Se guardan los productos de valor agregado 
                    For Each idCorte As Integer In Codigos.FindAll(AddressOf CortesNoRelacionados)
                        Dim ValorAgregadoEntity As New EC.MscproductosValorAgregadoEntity

                        ValorAgregadoEntity.IdProducto = Productos.IdProducto
                        ValorAgregadoEntity.IdSubCorte = idCorte

                        trans.Add(ValorAgregadoEntity)

                        If Not ValorAgregadoEntity.Save Then
                            trans.Rollback()
                            MessageBox.Show("No se ha podido guardar el producto, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Cancelar = True
                            Exit Sub
                        End If
                    Next

                    Dim col As New CC.MscproductosValorAgregadoCollection

                    trans.Add(col)

                    col.DeleteMulti(HC.MscproductosValorAgregadoFields.IdProducto = Productos.IdProducto And New OC.FieldCompareRangePredicate(HC.MscproductosValorAgregadoFields.IdSubCorte, True, Codigos.ToArray))
                End If
            End If

            trans.Commit()
            MessageBox.Show("El Producto ha sido guardado con el código: " & Productos.IdProducto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            Deshabilitar()
            Productos = New ProductosClass()
            LlenarDecomisos()
        Catch ex As Exception
            Cancelar = True
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function CortesNoRelacionados(ByVal idCorte As Integer) As Boolean
        Try
            Dim cortes As New CC.MscproductosValorAgregadoCollection

            Return cortes.GetDbCount(HC.MscproductosValorAgregadoFields.IdProducto = _
                   Me.Productos.IdProducto And HC.MscproductosValorAgregadoFields.IdSubCorte = idCorte) = 0
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Habilitar()
        Me.GroupBox1.Enabled = True
        Me.ProductosC.Add(New ProductosClass)
        Me.LlenarDecomisos()
        Me.txtCodigoBarra.Focus()
        buscando = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

#End Region

#Region "TextBox"

    Private Sub txtPrecio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not Me.txtPrecio.Text = "" Then
            Me.txtPrecio.Text = Me.txtPrecio.Text.Replace("$", "").Replace(".00", "")
            Me.txtPrecio.SelectAll()
        End If
    End Sub
    Private Sub txtPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.txtPrecio.Text = "" Then
                Me.txtPrecio.Text = 0.ToString("C2")
            End If

            Me.txtPiezasXCabeza.Focus()
        ElseIf (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse _
                (e.KeyChar = "."c AndAlso Me.txtPrecio.Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoBarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtPiezasXCabeza_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.txtPiezasXCabeza.Text = "" Then
                Me.txtPiezasXCabeza.Text = 0
            End If

            Me.lsbListaDecomiso.Focus()
        ElseIf Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lsbListaDecomiso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lsbListaDecomiso.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnAgregar.Focus()
        End If
    End Sub

    Private Sub txtPrecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtPrecio.Text = "" Then
            Me.txtPrecio.Text = 0.ToString("C2")
        Else
            Me.txtPrecio.Text = CDec(Me.txtPrecio.Text.Replace("$", "").Replace(",", "")).ToString("C2")
        End If
    End Sub

    Private Sub txtPiezasXCabeza_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtPiezasXCabeza.Text = "" Then
            Me.txtPiezasXCabeza.Text = 0
        Else
            Me.txtPiezasXCabeza.Text = CDec(Me.txtPiezasXCabeza.Text).ToString("N0")
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtNombreIngles.Focus()
        End If
    End Sub

    Private Sub txtNombreIngles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtPrecio.Focus()
        End If
    End Sub
    Private Sub txtMaximoPiezasxCaja_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txtMaximoPiezasxCaja.Text = CDec(Me.txtMaximoPiezasxCaja.Text.Replace(",", ""))
    End Sub

    Private Sub txtMaximoPiezasxCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.txtMaximoPiezasxCaja.Text = "" Then
                Me.txtMaximoPiezasxCaja.Text = "0"
            End If

            Me.txtNombreIngles.Focus()
        ElseIf (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMaximoPiezasxCaja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtMaximoPiezasxCaja.Text = "" Then
            Me.txtMaximoPiezasxCaja.Text = 0
        Else
            Me.txtMaximoPiezasxCaja.Text = CDec(Me.txtMaximoPiezasxCaja.Text.Replace(",", "")).ToString("N0")
        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnAgregarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTodos.Click
        Try
            If Me.lsbListaDecomiso.Items.Count = 0 Then
                MsgBox("No hay decomisos para agregar", MsgBoxStyle.Exclamation, "Sin Decomisos")
                Exit Sub
            End If

            For i As Integer = Me.lsbListaDecomiso.Items.Count - 1 To 0 Step -1
                Dim det As New ClasesNegocio.ProductosDetalleDecomisoClass
                det.Decomiso = Me.MotivosDecomisoC(i)
                det.Producto = Me.ProductosC(0)
                Me.ProductosC(0).Detalle.Add(det)
                Me.MotivosDecomisoC.RemoveAt(i)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If Me.lsbListaDecomiso.Items.Count = 0 Then
                MsgBox("No hay decomisos para agregar", MsgBoxStyle.Exclamation, "Sin Decomisos")
                Exit Sub
            End If

            If Me.lsbListaDecomiso.SelectedItems.Count > 0 Then
                Dim det As New ClasesNegocio.ProductosDetalleDecomisoClass
                det.Decomiso = Me.lsbListaDecomiso.SelectedItem 'Me.MotivosDecomisoC(Me.lsbListaDecomiso.SelectedIndex)
                det.Producto = Me.ProductosC(0)
                Me.ProductosC(0).Detalle.Add(det)
                'Me.ProductosC(0).Detalle.ResetItem(Me.Productos.Detalle.Count - 1)
                Me.MotivosDecomisoC.Remove(det.Decomiso)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            If Me.lsbDecomisosAgregados.Items.Count = 0 Then
                MsgBox("No hay decomisos para quitar", MsgBoxStyle.Exclamation, "Sin Decomisos")
                Exit Sub
            End If

            If Me.lsbDecomisosAgregados.SelectedItems.Count > 0 Then
                For i As Integer = 0 To Me.lsbDecomisosAgregados.SelectedItems.Count - 1
                    Dim det As ClasesNegocio.ProductosDetalleDecomisoClass = Me.lsbDecomisosAgregados.SelectedItems(0)
                    Me.ProductosC(0).Detalle.Remove(det)
                    Me.MotivosDecomisoC.Add(det.Decomiso)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnQuitarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTodos.Click
        Try
            If Me.lsbDecomisosAgregados.Items.Count = 0 Then
                MsgBox("No hay decomisos para quitar", MsgBoxStyle.Exclamation, "Sin Decomisos")
                Exit Sub
            End If

            For i As Integer = Me.lsbDecomisosAgregados.Items.Count - 1 To 0 Step -1
                Dim det As ClasesNegocio.ProductosDetalleDecomisoClass = Me.ProductosC(0).Detalle(i)
                Me.ProductosC(0).Detalle.Remove(det)
                Me.MotivosDecomisoC.Add(det.Decomiso)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

    Private Sub FrmABCProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LlenarDecomisos()
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "011011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.Limpiar()
            Me.Deshabilitar()
            Me.txtMaximoPiezasxCaja.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Almacen_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Productos.MensajeError
        MsgBox(mensaje)
    End Sub

    Private Sub dgvProductos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim Producto As ED.MsccatProductosEntity
        'Producto = DirectCast(dgvProductos.SelectedRows(0).DataBoundItem, ED.MsccatProductosEntity)
        'Me.txtCodigo.Text = Producto.IdProducto
        'Me.txtDescripcion.Text = Producto.Descripcion
        'Me.txtDescCorta.Text = Producto.DescripcionCorta

    End Sub

    'Private Sub chkProductoValorAgregado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProductoValorAgregado.Click
    '    'If chkProductoValorAgregado.Checked = True Then
    '    '    Dim ValorAgregado As New FrmCortesValorAgregado
    '    '    If ValorAgregado.ShowDialog = Windows.Forms.DialogResult.OK Then
    '    '    End If
    '    'End If
    'End Sub

    Private Sub chkProductoValorAgregado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProductoValorAgregado.CheckedChanged
        If Me.buscando Then Exit Sub

        Try
            Dim activado As Boolean = Me.chkProductoValorAgregado.Checked

            Me.grpListaDecomisos.Enabled = activado
            Me.grpListaDecomisosAgregados.Enabled = activado
            Me.btnAgregar.Enabled = activado
            Me.btnAgregarTodos.Enabled = activado
            Me.btnQuitar.Enabled = activado
            Me.btnQuitarTodos.Enabled = activado

            If activado Then
                Dim Ventana As New FrmBusquedaCortesEmbarque

                Ventana.Text = "Cortes"
                Ventana.lblTitulo.Text = "Cortes"
                Ventana.Cortes = True
                Ventana.Bloquear = False

                If Not Codigos Is Nothing Then
                    Ventana.Codigos = Codigos.ToArray
                    Codigos.Clear()
                Else
                    Codigos.Clear()
                End If

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Or Ventana.DialogResult = Windows.Forms.DialogResult.Cancel Then
                    For i As Integer = 0 To Ventana.DgvCortes.Rows.Count - 1
                        If CBool(Ventana.DgvCortes.Rows(i).Cells(Ventana.clmSeleccion.Index).Value) And Ventana.DgvCortes.Rows(i).Cells(Ventana.clmSeleccion.Index).ReadOnly = False Then
                            Codigos.Add(Ventana.DgvCortes.Rows(i).Cells(Ventana.ClmCodigo.Index).Value)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkDecomisable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDecomisable.CheckedChanged
        If buscando Then
            Me.grpListaDecomisos.Enabled = Me.chkDecomisable.Checked
            Me.grpListaDecomisosAgregados.Enabled = Me.chkDecomisable.Checked
            Me.Panel1.Enabled = Me.chkDecomisable.Checked
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        ProductosCollectionsClass.Imprimir(Controlador.Sesion, HC.MsccatProductosFields.SubProducto = True _
                Or HC.MsccatProductosFields.ValorAgregado = True Or HC.MsccatProductosFields.Decomisa = True _
                Or HC.MsccatProductosFields.Canal = True Or HC.MsccatProductosFields.EsMerma = True)
    End Sub

 
End Class