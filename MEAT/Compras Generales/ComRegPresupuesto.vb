Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class ComRegPresupuesto
#Region "Miembros"
    Private Presupuesto As ClasesNegocio.PresupuestoCompraClass
    Private ProductosSolicitados As ClasesNegocio.SolicitudProductoDetalleCollectionClass
    Private Editar As Boolean
    Dim Cantidad As Decimal
    Dim Modo As Integer
    Dim UltimaTeclaPlaza As DateTime
    Dim UltimaTeclaSucursal As DateTime
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        cmbPlaza.SelectedIndex = -1
        Me.txtDescripcion.Clear()
        Me.txtObservaciones.Clear()
        Me.DataGrid.DataSource = Nothing
        Me.txtCantidad.Clear()
        Me.txtFolio.Clear()
        Me.Presupuesto = Nothing
        ProductosSolicitados = Nothing
        Editar = False
        Me.cmbPlaza.Focus()
        Cantidad = 0
        cmbTipoPresupuesto.SelectedIndex = -1
        cmbTipoPresupuesto.Text = "Seleccione un tipo de presupuesto"
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub Deshabilitar()
        cmbPlaza.Enabled = False
        cmbSucursal.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.DataGrid.Enabled = False
        Me.cmbTipoPresupuesto.Enabled = False
    End Sub

    Private Sub Habilitar()
        cmbPlaza.Enabled = True
        cmbSucursal.Enabled = True
        cmbTipoPresupuesto.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.DataGrid.Enabled = True
    End Sub

    Private Sub Guardar()
        Presupuesto.Descripcion = Me.txtDescripcion.Text
        Presupuesto.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
        Presupuesto.Observaciones = Me.txtObservaciones.Text
        Presupuesto.IdUsuarioAlta = Controlador.Sesion.MiUsuario.Usrndx
        Presupuesto.IdSucursal = CType(cmbSucursal.SelectedValue, Integer)
        Presupuesto.IdTipoPresupuesto = CType(cmbTipoPresupuesto.SelectedValue, Integer)
    End Sub

    Private Function Validar() As Boolean
        If Me.txtDescripcion.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtDescripcion.Focus()
            Return False
        End If

        If cmbPlaza.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar una plaza", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.cmbPlaza.Focus()
            Return False
        End If

        If cmbSucursal.SelectedIndex < 0 Then
            MsgBox("Debe selecciona un sucursal", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbSucursal.Focus()
            Return False
        End If

        If cmbTipoPresupuesto.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un tipo de presupuesto", MsgBoxStyle.Exclamation, "Faltan Datos")
            cmbTipoPresupuesto.Focus()
            Return False
        End If

        If Presupuesto.Detalle.Count = 0 Then
            MsgBox("Debe agregar productos al prespuesto", MsgBoxStyle.Exclamation, "Faltan Datos")
            DataGrid.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub PonerDatos()
        cmbPlaza.SelectedValue = Presupuesto.Sucursal.Plaza.Codigo
        cmbSucursal.SelectedValue = Presupuesto.Sucursal.Codigo
        Me.txtFolio.Text = Presupuesto.Folio
        Me.dtFechaAlta.Value = Presupuesto.FechaAlta
        Me.txtDescripcion.Text = Presupuesto.Descripcion
        cmbTipoPresupuesto.SelectedValue = Presupuesto.TipoPresupuesto.Codigo
        txtObservaciones.Text = Presupuesto.Observaciones
        Me.DataGrid.DataSource = Presupuesto.Detalle
        Me.lblEstatus.Visible = True
        Me.lblEstatus.Text = Presupuesto.Estatus.ToString
    End Sub
#End Region

    Private Sub ComRegPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "001101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            MEAToolBar1.ToolBarButtonStatus = MtbEstados
            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbPlaza.DataSource = PlazaC
            cmbPlaza.DisplayMember = "Descripcion"
            cmbPlaza.ValueMember = "Codigo"

            TipoPresupuestoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Deshabilitar()
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ProductosSolicitadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosSolicitadosToolStripMenuItem.Click
        Try
            'If cmbPlaza.SelectedIndex < 0 Then
            '    MsgBox("Debe Seleccionar primero una plaza", MsgBoxStyle.Exclamation, "Aviso")
            '    Exit Sub
            'End If

            'If cmbSucursal.SelectedIndex < 0 Then
            '    MsgBox("Debe seleccionar primero una sucursal", MsgBoxStyle.Exclamation, "Aviso")
            '    Exit Sub
            'End If
            If Modo = 1 Then ' modo inserccion
                Dim Ventana As New FrmListaProdSolicitados

                If Me.cmbPlaza.SelectedIndex > -1 And Me.cmbSucursal.SelectedIndex > -1 Then
                    Ventana.CodigoPlaza = cmbPlaza.SelectedValue
                    Ventana.CodigoSucursal = cmbSucursal.SelectedValue
                    Ventana.cmbPlaza.Enabled = False
                    Ventana.cmbSucursal.Enabled = False
                End If

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If ProductosSolicitados Is Nothing Then
                        ProductosSolicitados = New ClasesNegocio.SolicitudProductoDetalleCollectionClass
                    Else
                        ProductosSolicitados.Clear()
                    End If

                    Presupuesto.Detalle.Clear()
                    Cantidad = 0

                    For i As Integer = 0 To Ventana.DataGrid.Rows.Count - 1
                        If CBool(Ventana.DataGrid.Rows(i).Cells(0).Value) Then
                            Dim det As New ClasesNegocio.PresupuestoCompraDetalleClass
                            det.PresupuestoCompra = Presupuesto
                            det.Cantidad = Ventana.DataGrid.Rows(i).Cells("ClmCantidad").Value
                            det.CodigoProducto = Ventana.DataGrid.Rows(i).Cells("ClmCodigo").Value
                            det.PrecioUltimaCompra = det.Producto.ObtenerEntidad.CostoProducto.Costo

                            Dim encontro As Boolean = False

                            For Each d As ClasesNegocio.PresupuestoCompraDetalleClass In Presupuesto.Detalle
                                If d.Producto.Codigo = det.Producto.Codigo Then
                                    encontro = True
                                    d.Cantidad += det.Cantidad
                                    Exit For
                                End If
                            Next

                            If Not encontro Then
                                Presupuesto.Detalle.Add(det)
                            End If

                            Cantidad += det.Cantidad

                            Dim prodsol As SolicitudProductoDetalleClass = SolicitudProductoDetalleClass.Obtener(CType(Ventana.DataGrid.Rows(i).Cells("clmIdSolicitud").Value, Integer), det.Producto.Codigo)

                            If prodsol IsNot Nothing Then
                                prodsol.Estatus = ClasesNegocio.EstatusDatos.CANCELADO
                                ProductosSolicitados.Add(prodsol)
                            End If
                        End If
                    Next

                    Me.cmbPlaza.SelectedValue = Ventana.cmbPlaza.SelectedValue
                    Me.cmbSucursal.SelectedValue = Ventana.cmbSucursal.SelectedValue
                    Me.cmbPlaza.Enabled = False
                    Me.cmbSucursal.Enabled = False
                    Me.txtCantidad.Text = Cantidad.ToString("N3")
                End If
            ElseIf Modo = 2 Then 'modo edicion
                Dim Ventana As New FrmListaProdSolicitados
                If Not Me.cmbPlaza.SelectedValue = Nothing And Not Me.cmbSucursal.SelectedValue = Nothing Then
                    Ventana.CodigoPlaza = cmbPlaza.SelectedValue
                    Ventana.CodigoSucursal = cmbSucursal.SelectedValue
                    Ventana.cmbPlaza.Enabled = False
                    Ventana.cmbSucursal.Enabled = False
                End If
                Ventana.FolioPres = Presupuesto.Folio
                Ventana.ListaProd = ProductosSolicitados

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    For i As Integer = 0 To Ventana.DataGrid.Rows.Count - 1
                        If CBool(Ventana.DataGrid.Rows(i).Cells(0).Value) Then
                            Dim det As New ClasesNegocio.PresupuestoCompraDetalleClass
                            det.PresupuestoCompra = Presupuesto
                            det.Cantidad = Ventana.DataGrid.Rows(i).Cells("ClmCantidad").Value
                            det.CodigoProducto = Ventana.DataGrid.Rows(i).Cells("ClmCodigo").Value
                            det.PrecioUltimaCompra = det.Producto.ObtenerEntidad.CostoProducto.Costo

                            Dim encontro As Boolean = False

                            For Each d As ClasesNegocio.PresupuestoCompraDetalleClass In Presupuesto.Detalle
                                If d.Producto.Codigo = det.Producto.Codigo Then
                                    encontro = True
                                    d.Cantidad += det.Cantidad
                                    Exit For
                                End If
                            Next

                            If Not encontro Then
                                Presupuesto.Detalle.Add(det)
                            End If

                            Cantidad += det.Cantidad
                            Me.cmbSucursal.SelectedValue = Ventana.cmbSucursal.SelectedValue
                            Me.cmbPlaza.SelectedValue = Ventana.cmbPlaza.SelectedValue
                            Dim prodsol As SolicitudProductoDetalleClass = SolicitudProductoDetalleClass.Obtener(CType(Ventana.DataGrid.Rows(i).Cells("ClmIdSolicitud").Value, Integer), det.Producto.Codigo)

                            If prodsol IsNot Nothing Then
                                prodsol.Estatus = ClasesNegocio.EstatusEnum.INACTIVO
                                ProductosSolicitados.Add(prodsol)
                            End If
                        End If
                    Next

                    Me.cmbPlaza.SelectedValue = Ventana.cmbPlaza.SelectedValue
                    Me.cmbSucursal.SelectedValue = Ventana.cmbSucursal.SelectedValue
                    Me.cmbPlaza.Enabled = False
                    Me.cmbSucursal.Enabled = False
                    Me.txtCantidad.Text = Cantidad.ToString("N3")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Presupuesto")
        Try
            If Me.Presupuesto.Estatus = EstatusDatos.CANCELADO Then
                MessageBox.Show("No se puede Cancelar el presupuesto, puesto que este ya se encuentra Cancelado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If Me.Presupuesto.OrdenCompraGenerada = ClasesNegocio.AsignadaEnum.SI Then
                MessageBox.Show("No se puede Cancelar el Presupuesto, ya se Generó una Orden de Compra con este presupuesto", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Me.Presupuesto.IdUsuarioCancelacion = Controlador.Sesion.MiUsuario.Usrndx

            If Me.Presupuesto.Borrar(Trans) Then
                MessageBox.Show("Se ha Cancelado el Presupuesto", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Limpiar()
                Me.Deshabilitar()
            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
#Else
            messagebox.Show("Ocurrió un error en la aplicación", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
#End If
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim ventana As New ComBusquedaPresupuestoCompra

            'ventana.cmbPlaza.Enabled = False

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Presupuesto = ventana.DataGrid.SelectedRows(0).DataBoundItem

                PonerDatos()

                Dim Cantidad As Decimal

                For Each det As ClasesNegocio.PresupuestoCompraDetalleClass In Presupuesto.Detalle
                    Cantidad += det.Cantidad
                Next

                Me.txtCantidad.Text = Cantidad.ToString("N3")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        Try
            If Me.Presupuesto.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                MessageBox.Show("No se puede editar el presupuesto, su estado es inactivo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            ProductosSolicitados = New ClasesNegocio.SolicitudProductoDetalleCollectionClass
            ProductosSolicitados.Obtener()
            Habilitar()
            Modo = 2 'modo Edicion
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
#Else
         messagebox.Show("Ocurrió un Error en la Aplicación","MEAT",MessageBoxButtons.OK,MessageBoxIcon.Error)
#End If
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Presupuesto")

        Try
            Cursor = Cursors.WaitCursor

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            Guardar()
            If Modo = 1 Then 'Modo Inserccion
                If Presupuesto.Guardar(Trans) Then
                    For Each solprod As SolicitudProductoDetalleClass In Me.ProductosSolicitados
                        solprod.Guardar(Trans)
                    Next

                    Trans.Commit()
                    MsgBox("Se a guardado el presupuesto con el FOLIO: " & Presupuesto.Folio, MsgBoxStyle.Information, "Aviso")
                    Deshabilitar()
                    Limpiar()
                Else
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                End If
            ElseIf Modo = 2 Then ' Modo Edicion
                If Presupuesto.Guardar(Trans) Then
                    For Each solprod As SolicitudProductoDetalleClass In Me.ProductosSolicitados
                        solprod.Guardar(Trans)
                    Next

                    Trans.Commit()
                    MsgBox("Se a Modificado el presupuesto con el FOLIO: " & Presupuesto.Folio, MsgBoxStyle.Information, "Aviso")
                    Deshabilitar()
                    Limpiar()
                Else
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
            Trans.Rollback()
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Habilitar()
        Limpiar()
        Modo = 1 ' Modo inserccion
        Presupuesto = New ClasesNegocio.PresupuestoCompraClass
        Me.DataGrid.DataSource = Presupuesto.Detalle
    End Sub

    Private Sub cmbTipoPresupuesto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipoPresupuesto.KeyDown
        If e.KeyData = Keys.F12 Then
            TipoPresupuestoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbTipoPresupuesto.SelectedIndex = -1
            cmbTipoPresupuesto.Text = "Seleccione un tipo de presupuesto"
        End If
    End Sub

    Private Sub cmbPlaza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPlaza.KeyDown
        If e.KeyData = Keys.F12 Then
            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            cmbPlaza.SelectedIndex = -1
            cmbPlaza.Text = "Seleccione una plaza"
        End If
    End Sub

    Private Sub cmbSucursal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSucursal.KeyDown
        If e.KeyData = Keys.F12 Then
            If cmbPlaza.SelectedIndex > -1 Then
                Dim codigoplaza As Integer = cmbPlaza.SelectedValue
                PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                cmbPlaza.SelectedValue = codigoplaza

                cmbSucursal.DataSource = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
                cmbSucursal.SelectedIndex = -1
                cmbSucursal.Text = "Seleccione una sucursal"
            End If
        End If
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

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > -1 Then
            cmbSucursal.DataSource = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
            cmbSucursal.DisplayMember = "Descripcion"
            cmbSucursal.ValueMember = "Codigo"
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione una sucursal"
        Else
            cmbSucursal.Text = ""
            cmbSucursal.DataSource = Nothing
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub DataGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGrid.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If MsgBox("¿Desea Realmente Borrar el detalle?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Dim Cantidad As Decimal
                    cantidad = Me.DataGrid.CurrentRow.Cells(Me.CantidadDataGridViewTextBoxColumn.Index).Value
                    Me.DataGrid.Rows.Remove(Me.DataGrid.SelectedRows(0))
                    If Me.DataGrid.Rows.Count = 0 Then
                        Me.txtCantidad.Text = 0
                        Exit Sub
                    End If
                    Me.txtCantidad.Text = CDbl((CDbl(Me.txtCantidad.Text) - Cantidad)).ToString("N2")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al descontar cantidad en presupuesto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPlaza.KeyPress
        If e.KeyChar <> Chr(13) Then
            Tmplaza.Stop()
            UltimaTeclaPlaza = Now
            Me.Tmplaza.Start()
        End If
    End Sub

    Private Sub cmbSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSucursal.KeyPress
        If e.KeyChar <> Chr(13) Then
            TmSucursal.Stop()
            UltimaTeclaSucursal = Now
            Me.TmSucursal.Start()
        End If
    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbPlaza_SelectedIndexChanged(Me, e)
                Me.cmbSucursal.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbTipoPresupuesto_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbTipoPresupuesto.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                TipoPresupuestoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TmSucursal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmSucursal.Tick
        If Me.UltimaTeclaSucursal.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.TmSucursal.Stop()
            Me.SucursalC.Obtener(Me.cmbSucursal.Text, ClasesNegocio.CondicionEnum.ACTIVOS, Me.cmbPlaza.SelectedValue)
            Me.cmbSucursal.DataSource = SucursalC
        End If
    End Sub

    Private Sub Tmplaza_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmplaza.Tick
        If Me.UltimaTeclaPlaza.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.Tmplaza.Stop()
            Me.PlazaC.Obtener(Me.cmbPlaza.Text, ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub cmbPlaza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.TextChanged
        If cmbPlaza.SelectedIndex > -1 Then
            cmbSucursal.DataSource = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
            cmbSucursal.DisplayMember = "Descripcion"
            cmbSucursal.ValueMember = "Codigo"
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione una sucursal"
        Else
            cmbSucursal.Text = ""
            cmbSucursal.DataSource = Nothing
        End If
    End Sub

End Class