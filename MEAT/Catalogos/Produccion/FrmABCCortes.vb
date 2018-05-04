'Programa:          ERP MEAT
'Objetivo:          
'Modulo:            ABC de Cortes
'Elaboro:           
'Fecha Inicio:      
'Fecha Modificado:  
'Fecha Terminado:   
'Fecha Modificado:  Miercoles, 12 de Junio de 2009
'Modificado Por:    Jorge Alfredo Niebla Ojeda

Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CD = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FrmABCCortes
    Dim LbNuevo As Boolean
    Private Productos As ProductosClass
    Private WithEvents CortePreCorte As CortesPreCortesClass
    Dim PrecortesCol As ProductosCollectionsClass

    Private Sub FrmABCCortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CatProductos.ObtenerCortes(CondicionEstatusEnum.TODOS)
            Me.dgvProductos.AutoGenerateColumns = False
            Me.dgvProductos.DataSource = CatProductos

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001010000"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")
            Me.mtb.Buttons(1).Visible = False
            Me.cmbPreCortes.DisplayMember = "Descripcion"
            Me.cmbPreCortes.ValueMember = "IdProducto"
            LlenarComboPreCortes()
            Try
                Dim FormasPago As DataSet = New DataSet
                Dim queryString As String = "SELECT clave, clave+'.- '+concepto as productosat FROM CatProdServSAT"
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
                adapter.Fill(FormasPago)
                Me.cmbProdSAT.DataSource = FormasPago.Tables(0)
                Me.cmbProdSAT.DisplayMember = "productosat"
                Me.cmbProdSAT.ValueMember = "Clave"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Metodos"

    Public Function Limpiar() As Boolean
        Me.txtCodigo.Text = 0
        ' Me.txtCuentaContable.Text = ""
        Me.txtDescCorta.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtCodigoBarra.Text = ""
        ' Me.txtCuentaContable.Text = ""
        Me.txtMaximoPiezasxCaja.Text = "0"
        Me.txtNombreIngles.Text = ""
        Me.txtCodigoPrecorte.Text = ""
        Me.cmbPreCortes.SelectedIndex = -1
        ' Me.cmbCuentaContable.Text = ""
        Me.lblEstatus.Visible = False
        Me.txtPrecio.Text = 0
        Me.txtPiezasXCabeza.Text = 0
        Me.cmbProdSAT.SelectedItem = Nothing
    End Function

    Public Function Deshabilitar() As Boolean
        Me.txtCodigo.Enabled = False
        ' Me.txtCuentaContable.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtCodigoBarra.Enabled = False
        ' Me.txtCuentaContable.Enabled = False
        Me.txtMaximoPiezasxCaja.Enabled = False
        Me.txtNombreIngles.Enabled = False
        Me.txtCodigoPrecorte.Enabled = False
        Me.cmbPreCortes.Enabled = False
        Me.dgvProductos.Enabled = True
        'Me.cmbCuentaContable.Enabled = False
        Me.txtPrecio.Enabled = False
        Me.txtPiezasXCabeza.Enabled = False
        Me.chkHueso.Enabled = False
        Me.cmbProdSAT.Enabled = False

    End Function

    Public Function Habilitar() As Boolean
        Me.txtCodigo.Enabled = True
        ' Me.txtCuentaContable.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtCodigoBarra.Enabled = True
        ' Me.txtCuentaContable.Enabled = True
        Me.txtMaximoPiezasxCaja.Enabled = True
        Me.txtNombreIngles.Enabled = True
        Me.txtCodigoPrecorte.Enabled = True
        Me.cmbPreCortes.Enabled = True
        Me.dgvProductos.Enabled = False
        'Me.cmbCuentaContable.Enabled = True
        Me.txtPrecio.Enabled = True
        Me.txtPiezasXCabeza.Enabled = True
        Me.chkHueso.Enabled = True
        Me.cmbProdSAT.Enabled = True

    End Function

    Public Function Guardar() As Boolean
        Productos.Observaciones = ""
        Productos.Descripcion = Me.txtDescripcion.Text
        Productos.DescripcionCorta = Me.txtDescCorta.Text
        Productos.MaximoPiezasxCaja = Me.txtMaximoPiezasxCaja.Text
        Productos.NombreIngles = Me.txtNombreIngles.Text
        Productos.CodigoBarra = Me.txtCodigoBarra.Text
        Productos.Corte = True
        Productos.SubProducto = True
        Productos.PiezasXCabeza = Me.txtPiezasXCabeza.Text
        Productos.PrecioXKilo = CDec(Me.txtPrecio.Text.Replace("$", "").Replace(",", ","))
        Productos.ConHueso = Me.chkHueso.Checked
        Productos.ClaveprodSat = Me.cmbProdSAT.SelectedValue
    End Function

    Public Function PonerDatos() As Boolean
        Me.txtCodigo.Text = Productos.IdProducto
        Me.txtDescripcion.Text = Productos.Descripcion
        Me.txtDescCorta.Text = Productos.DescripcionCorta
        Me.txtNombreIngles.Text = Productos.NombreIngles
        Me.txtMaximoPiezasxCaja.Text = Productos.MaximoPiezasxCaja
        Me.txtCodigoBarra.Text = Productos.CodigoBarra
        Me.lblEstatus.Text = Productos.Estatus.ToString
        Me.lblEstatus.Visible = True
        Me.txtPiezasXCabeza.Text = Productos.PiezasXCabeza.ToString("N3")
        Me.txtPrecio.Text = Productos.PrecioXKilo.ToString("C2")
        Me.chkHueso.Checked = Productos.ConHueso
        Me.cmbProdSAT.SelectedValue = Productos.ClaveprodSat
    End Function

    ''' <summary>
    ''' Validacion previa para Guardar
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar() As Boolean
        Try
            Dim Filtro As New OC.PredicateExpression
            Filtro.Add(HC.MsccatProductosFields.Corte = True)

            If Not Productos.Entidad.IsNew Then
                Filtro.Add(HC.MsccatProductosFields.IdProducto <> Productos.IdProducto)
            End If

            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Especifique descripcion de corte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            ElseIf ProductosCollectionsClass.CargarProductos(Filtro.Add(HC.MsccatProductosFields.Descripcion = txtDescripcion.Text.Trim)).Count > 0 Then
                MsgBox("La descripcion proporcionada ya esta registrada, por favor especifique otra", MessageBoxIcon.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Me.txtDescripcion.Focus()
                Return False
            ElseIf ProductosCollectionsClass.CargarProductos(Filtro.Add(HC.MsccatProductosFields.DescripcionCorta = txtDescCorta.Text.Trim)).Count > 0 Then
                MsgBox("La descripcion-corta proporcionada ya esta registrada, por favor especifique otra", MessageBoxIcon.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Me.txtDescCorta.Focus()
                Return False
            End If

            If Me.cmbPreCortes.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un PreCorte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' llena el combo de productos clasificados como precortes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LlenarComboPreCortes()
        PrecortesCol = New ProductosCollectionsClass
        PrecortesCol.ObtenerPrecortes(CondicionEstatusEnum.ACTIVO)
        Me.cmbPreCortes.DataSource = PrecortesCol
    End Sub
#End Region

#Region "KeyPress"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub
    Private Sub txtCodigoBarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub
    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtMaximoPiezasxCaja.Focus()
        End If
    End Sub

    Private Sub txtMaximoPiezasxCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtNombreIngles.Focus()
        End If
    End Sub

    Private Sub txtNombreIngles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.cmbPreCortes.Focus()
        End If
    End Sub

    Private Sub cmbPreCortes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtPrecio.Focus()
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtMaximoPiezasxCaja.Focus()
        End If
    End Sub

    Private Sub txtMaximoPiezasxCaja_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.mtb.Focus()
        End If
    End Sub
#End Region

#Region "BotonesToolBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Productos.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar este Corte", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el Corte?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Me.CortePreCorte.Borrar() And Me.Productos.Borrar() Then
                    MsgBox("El Corte ha sido cancelado", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    Me.Limpiar()
                    Me.Deshabilitar()
                    Me.CatProductos.ObtenerCortes(CondicionEstatusEnum.TODOS)
                    Me.dgvProductos.AutoGenerateColumns = False
                    Me.dgvProductos.DataSource = CatProductos
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Productos.Estatus = EstatusDatos.CANCELADO Then
            If MessageBox.Show("El Corte actualmente esta Cancelado, para editarlo necesita activarlo ¿Desea Activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Productos.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Me.Habilitar()
            Else
                Cancelar = True
            End If
        Else
            Habilitar()
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")

        Try
            If Not Me.Validar Then
                Cancelar = True
                Exit Sub
            End If

            Me.Guardar()

            If Not Productos.Guardar(Trans) Then
                Trans.Rollback()
                MsgBox("Ocurrio un error al guardar el producto", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            'traer informacion del dato guardado.
            If Me.CortePreCorte.CodCorte = 0 Then
                CortePreCorte.CodCorte = Productos.IdProducto
            End If

            CortePreCorte.CodPrecorte = Me.cmbPreCortes.SelectedValue

            If Not CortePreCorte.Guardar(Trans) Then
                Trans.Rollback()
                MsgBox("Ocurrio un error al guardar el corte", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            Else
                MsgBox("El Corte ha sido guardado", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
            End If

            Trans.Commit()

            Me.Limpiar()
            Me.Deshabilitar()
            Me.CatProductos.ObtenerCortes(CondicionEstatusEnum.TODOS)
            Me.dgvProductos.AutoGenerateColumns = False
            Me.dgvProductos.DataSource = CatProductos
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.Habilitar()
        Me.txtDescripcion.Focus()
        Productos = New ClasesNegocio.ProductosClass
        CortePreCorte = New ClasesNegocio.CortesPreCortesClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

#End Region

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Not Me.txtFiltro.Text = "" Then
                Me.CatProductos.Obtener(Me.txtFiltro.Text, False, True)
            Else
                Me.CatProductos.ObtenerCortes(CondicionEstatusEnum.TODOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim VerReporte As New PreVisualizarForm
            VerReporte.Reporte = Me.CatProductos.ReporteCortes(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            VerReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvProductos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.SelectionChanged
        Try
            If Me.dgvProductos.SelectedRows.Count > 0 Then
                Productos = New ProductosClass
                Productos = DirectCast(Me.dgvProductos.SelectedRows(0).DataBoundItem, ProductosClass)

                Me.CortePreCorte = New CortesPreCortesClass

                If Not Me.CortePreCorte.ObtenerEntidad.FetchUsingPK(Productos.IdProducto) Then
                    Me.CortePreCorte = New CortesPreCortesClass
                End If

                'Me.txtCodigoPrecorte.Text = CortePreCorte.CodPrecorte
                Me.cmbPreCortes.SelectedValue = CortePreCorte.CodPrecorte

                Me.PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Refrescar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F12 Then
            LlenarComboPreCortes()
        End If
    End Sub
End Class