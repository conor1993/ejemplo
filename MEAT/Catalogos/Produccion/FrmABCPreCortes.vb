'Programa:          ERP MEAT
'Objetivo:          
'Modulo:            ABC de PreCortes
'Elaboro:           
'Fecha Inicio:      
'Fecha Modificado:  
'Fecha Terminado:   
'Fecha Modificado:  Miercoles, 12 de Junio de 2009
'Modificado Por:    Jorge Alfredo Niebla Ojeda

Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmABCPreCortes
    Dim LbNuevo As Boolean
    Private WithEvents Productos As New ProductosClass

    Private Sub FrmABCPreCortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CatProductos.ObtenerPrecortes(CondicionEstatusEnum.TODOS)

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.mtb.Buttons(1).Visible = False
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
        'Me.txtCuentaContable.Text = ""
        Me.txtDescCorta.Text = ""
        Me.txtDescripcion.Text = ""
        txtNombreIngles.Text = ""
        txtPiezasXCabeza.Text = 0
        txtPrecio.Text = 0
        txtCodigoBarra.Text = ""
        ' Me.cmbCuentaContable.Text = ""
        Me.lblEstatus.Visible = False
    End Function

    Public Function Deshabilitar() As Boolean
        Me.txtCodigo.Enabled = False
        ' Me.txtCuentaContable.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.dgvProductos.Enabled = True
        txtNombreIngles.Enabled = False
        txtPiezasXCabeza.Enabled = False
        txtPrecio.Enabled = False
        txtCodigoBarra.Enabled = False
        'Me.cmbCuentaContable.Enabled = False
    End Function

    Public Function Habilitar() As Boolean
        Me.txtCodigo.Enabled = True
        ' Me.txtCuentaContable.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.dgvProductos.Enabled = False
        ' Me.cmbCuentaContable.Enabled = True
        txtNombreIngles.Enabled = True
        txtPiezasXCabeza.Enabled = True
        txtPrecio.Enabled = True
        txtCodigoBarra.Enabled = True
    End Function

    Public Function Guardar() As Boolean
        If Me.txtPrecio.Text = "" Then
            Me.txtPrecio.Text = 0.0
        End If
        Productos.Descripcion = Me.txtDescripcion.Text
        Productos.DescripcionCorta = Me.txtDescCorta.Text
        Productos.PreCorte = True
        Productos.NombreIngles = Me.txtNombreIngles.Text
        Productos.PrecioXKilo = CDec(Me.txtPrecio.Text.Replace("$", "").Replace(",", ""))
        'Productos.MaximoPiezasxCaja = Me.txtPiezasXCabeza.Text.Replace(",", "")
        Productos.PiezasXCabeza = Me.txtPiezasXCabeza.Text.Replace(",", "")
        Productos.CodigoBarra = Me.txtCodigoBarra.Text
    End Function

    Public Function PonerDatos() As Boolean
        Me.txtCodigo.Text = Productos.IdProducto
        Me.txtDescripcion.Text = Productos.Descripcion
        Me.txtDescCorta.Text = Productos.DescripcionCorta
        Me.lblEstatus.Text = Productos.Estatus.ToString
        Me.lblEstatus.Visible = True
        txtNombreIngles.Text = Productos.NombreIngles
        txtCodigoBarra.Text = Productos.CodigoBarra
        txtPrecio.Text = Productos.PrecioXKilo.ToString("C4")
        'txtPiezasXCabeza.Text = Productos.MaximoPiezasxCaja.ToString("N0")
        txtPiezasXCabeza.Text = Productos.PiezasXCabeza.ToString("N0")
    End Function

    Public Function Validar() As Boolean
        Try
            Dim Filtro As New OC.PredicateExpression
            Filtro.Add(HC.MsccatProductosFields.PreCorte = True)

            If Not Productos.Entidad.IsNew Then
                Filtro.Add(HC.MsccatProductosFields.IdProducto <> Productos.IdProducto)
            End If

            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Especifique descripcion de precorte", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            ElseIf ProductosCollectionsClass.CargarProductos(Filtro.Add(HC.MsccatProductosFields.Descripcion = txtDescripcion.Text.Trim)).Count > 0 Then
                MessageBox.Show("La descripcion proporcionada ya esta registrada, por favor especifique otra", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            ElseIf ProductosCollectionsClass.CargarProductos(Filtro.Add(HC.MsccatProductosFields.DescripcionCorta = txtDescCorta.Text.Trim)).Count > 0 Then
                MessageBox.Show("La descripcion-corta proporcionada ya esta registrada, por favor especifique otra", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescCorta.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Imprimir()
        Try
            If CatProductos.Count > 0 Then
                Dim VerReporte As New PreVisualizarForm
                VerReporte.Reporte = Me.CatProductos.ReportePrecortes(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                VerReporte.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "KeyPress"

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtNombreIngles.Focus()
        End If
    End Sub

    Private Sub txtCodigoBarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtPrecio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Not Me.txtPrecio.Text = "" Then
        '    Me.txtPrecio.Text = Me.txtPrecio.Text.Replace("$", "").Replace(".00", "")
        '    Me.txtPrecio.SelectAll()
        'End If
    End Sub

    Private Sub txtPrecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtPrecio.Text = "" Then
            Me.txtPrecio.Text = 0.ToString("C2")
        Else
            Me.txtPrecio.Text = CDec(Me.txtPrecio.Text).ToString("C2")
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = ".") OrElse (e.KeyChar = "." AndAlso Me.txtPrecio.Text.IndexOf(".") > -1) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.txtPiezasXCabeza.Focus()
        End If
    End Sub

    Private Sub txtNombreIngles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtPrecio.Focus()
        End If
    End Sub

    Private Sub txtPiezasXCabeza_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not Me.txtPiezasXCabeza.Text = "" Then
            Me.txtPiezasXCabeza.Text = Me.txtPiezasXCabeza.Text.Replace(",", "").Replace(".000", "")
        End If
    End Sub

    Private Sub txtPiezasXCabeza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(Me.txtPiezasXCabeza.Text) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.mtb.Focus()
        End If
    End Sub

    Private Sub txtPiezasXCabeza_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtPiezasXCabeza.Text = "" Then
            Me.txtPiezasXCabeza.Text = 0.ToString("N0")
        Else
            Me.txtPiezasXCabeza.Text = CDec(Me.txtPiezasXCabeza.Text).ToString("N3")
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text = "" Then
                CatProductos.Obtener(CondicionEstatusEnum.TODOS, False, True)
            Else
                Me.CatProductos.Obtener(Me.txtFiltro.Text, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "BotonesToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Productos.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar este Precorte", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el precorte?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Me.Productos.Borrar() Then
                    MsgBox("El Precorte ha sido cancelado", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    Me.Limpiar()
                    Me.Deshabilitar()
                    Me.CatProductos.ObtenerPrecortes(CondicionEstatusEnum.TODOS)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()

    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Productos.Estatus = EstatusDatos.CANCELADO Then
            If MessageBox.Show("El Precorte se encuentra cancelado, necesita activarlo para poder editarlo, ¿Desea activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Productos.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Me.Habilitar()
            Else
                Cancelar = True
            End If
        Else
            Me.Habilitar()
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")

        Try
            If Not Me.Validar Then
                Cancelar = True
                Exit Sub
            End If

            Me.Guardar()

            If Not Productos.Guardar(trans) Then
                trans.Rollback()
                MessageBox.Show("No se ha podido guardar el producto, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
                Exit Sub
            Else
                trans.Commit()
                MsgBox("El Pre-Corte ha sido guardado con el código: " & Productos.IdProducto, MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                Me.Limpiar()
                Me.Deshabilitar()
                Me.CatProductos.ObtenerPrecortes(CondicionEstatusEnum.TODOS)
            End If
        Catch ex As Exception
            trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.Habilitar()
        Me.txtCodigoBarra.Focus()
        Productos = New ClasesNegocio.ProductosClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub
#End Region

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub dgvProductos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProductos.SelectionChanged
        Try
            If Me.dgvProductos.SelectedRows.Count > 0 Then
                Productos = DirectCast(Me.dgvProductos.SelectedRows(0).DataBoundItem, ProductosClass)
                Me.PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class