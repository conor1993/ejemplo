Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class frmBusquedaNotas
    Public TipoFactura As TipoFacturaEnum
    Dim Renglones As Integer

    Public busquedaNotas As Boolean = False
    Dim frmPrincipal As FrmNotaCredito
    Public Property FormPrincipal As FrmNotaCredito
        Get
            Return (frmPrincipal)
        End Get
        Set(ByVal value As FrmNotaCredito)
            frmPrincipal = value
        End Set
    End Property

#Region "Metodos"
    Public Sub Inicializar_Forma()
        'Cargar Corrales
        ActualizarClientes()

        Me.dgvFacturasCabecero.AutoGenerateColumns = False
        Me.dgvFacturasDetalle.AutoGenerateColumns = False
        Limpiar()
    End Sub

    Private Sub ActualizarClientes()
        Dim Clientes As CC.MfacCatClientesCollection = Nothing '= Controlador.ObtenerClientes(CondicionEnum.ACTIVOS)

        Me.cmbClientes.DataSource = Nothing
        Me.cmbClientes.ValueMember = "IdCliente"
        Me.cmbClientes.DisplayMember = "Nombre"
        Me.cmbClientes.DataSource = Clientes
        Me.cmbClientes.SelectedIndex = -1
        Me.cmbClientes.Text = "Seleccione el Cliente"
    End Sub
#End Region

#Region "Acciones del Menu"
    Public Sub Buscar()
        Try
            Dim RangodeFechas As New RangoFechas(ultdtpFechaInicial.Value, ultdtpFechaFinal.Value)
            Dim Estatus As EstatusChar




            If chkVigentes.Checked And Not chkCancelados.Checked Then
                Estatus = EstatusChar.VIGENTE
            ElseIf chkCancelados.Checked And Not chkVigentes.Checked Then
                Estatus = EstatusChar.CANCELADO
            Else
                Estatus = EstatusChar.TODOS
            End If


            Me.dgvFacturasCabecero.DataSource = Nothing
            Me.dgvFacturasDetalle.DataSource = Nothing
            If busquedaNotas = False Then
                If IsNothing(cmbClientes.SelectedValue) Then
                    Me.dgvFacturasCabecero.DataSource = Controlador.ObtenerFacturasDeVenta(txtFolio.Text, RangodeFechas, 0, Estatus, TipoFactura)
                Else
                    Dim cliente As ClasesNegocio.ClientesIntroductoresClass
                    cliente = Me.cmbClientes.SelectedValue
                    Me.dgvFacturasCabecero.DataSource = Controlador.ObtenerFacturasDeVenta(txtFolio.Text, RangodeFechas, cliente.Codigo, Estatus, TipoFactura)
                End If
            End If
            
            If busquedaNotas = True Then
                If IsNothing(cmbClientes.SelectedValue) Then
                    Me.dgvFacturasCabecero.DataSource = Controlador.ObtenerFacturasDeVenta(txtFolio.Text, RangodeFechas, 0, Estatus, TipoFactura, "E")
                Else
                    Dim cliente As ClasesNegocio.ClientesIntroductoresClass
                    cliente = Me.cmbClientes.SelectedValue
                    Me.dgvFacturasCabecero.DataSource = Controlador.ObtenerFacturasDeVenta(txtFolio.Text, RangodeFechas, cliente.Codigo, Estatus, TipoFactura, "E")
                End If
            End If

        Catch ex As Exception
            dgvFacturasDetalle.DataSource = Nothing
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub Limpiar()
        txtFolio.ResetText()
        cmbClientes.SelectedIndex = -1
        cmbClientes.Text = "Seleccione el Cliente"
        ultdtpFechaInicial.Value = Nothing
        ultdtpFechaFinal.Value = Nothing
        dgvFacturasCabecero.DataSource = Nothing
        dgvFacturasDetalle.DataSource = Nothing
        chkVigentes.Checked = True
        chkCancelados.Checked = False
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmBusquedaFacturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
        Dim clientes As New ClientesIntroductoresColeccion
        clientes.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
        cmbClientes.DataSource = clientes
        cmbClientes.SelectedIndex = -1
        If busquedaNotas Then
            Me.Text = "Busqueda de Notas de Credito"
        End If
    End Sub
    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar, mtb.ClickBuscar, mtb.ClickCancelar, mtb.ClickEditar, mtb.ClickGuardar, mtb.ClickImprimir, mtb.ClickLimpiar, mtb.ClickNuevo, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub Estatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCancelados.CheckedChanged
        If Not chkVigentes.Checked And Not chkCancelados.Checked Then
            chkVigentes.Checked = True
            chkCancelados.Checked = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        If busquedaNotas = True Then
            frmPrincipal.btnRelacion.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvFacturasCabecero_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvFacturasCabecero.SelectionChanged
        Try
            If dgvFacturasCabecero.SelectedRows.Count > 0 Then
                Dim FacturasCab As New FacturasClass
                Dim Folio As String = ""
                Dim i As Integer = 0
                Folio = Me.dgvFacturasCabecero.CurrentRow.Cells(Me.clmNoFactura.Index).Value
                dgvFacturasDetalle.AutoGenerateColumns = False
                FacturasCab = CType(dgvFacturasCabecero.CurrentRow.DataBoundItem, FacturasClass)
                If FacturasCab.Detalles.Count > 0 Then
                    For j As Integer = Me.dgvFacturasDetalle.Rows.Count - 1 To 0 Step -1
                        Me.dgvFacturasDetalle.Rows.RemoveAt(j)
                        Me.dgvFacturasDetalle.Refresh()
                    Next
                    Me.dgvFacturasDetalle.Rows.Add(FacturasCab.Detalles.Count)
                Else
                    For j As Integer = Me.dgvFacturasDetalle.Rows.Count - 1 To 0 Step -1
                        Me.dgvFacturasDetalle.Rows.RemoveAt(j)
                        Me.dgvFacturasDetalle.Refresh()
                    Next
                    Exit Sub
                End If
                If TipoFactura = TipoFacturaEnum.FACTURACION_ESPECIAL Or TipoFactura = TipoFacturaEnum.VENTA_DE_PRODUCTO Then
                    For Each Detalle As FacturasDetalleClass In FacturasCab.Detalles
                        If Detalle.IdProducto = 0 And Detalle.Descripcion = "" Then
                            ' Me.dgvFacturasDetalle.Rows.RemoveAt(FacturasCab.Detalles.Count)
                            Exit For
                        End If
                        Dim Producto As New ProductoClass
                        Me.clmCabezas.Visible = False
                        Me.clmTipoGanado.Visible = False
                        Me.clmKilos.Visible = False
                        Me.clmPrecioxKilo.Visible = False
                        Producto.Obtener(Detalle.IdProducto)
                        If Producto.Codigo > 0 Then
                            Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmDescripcion.Index).Value = Producto.Descripcion
                        Else
                            Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmDescripcion.Index).Value = Detalle.Descripcion
                        End If

                        Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmCantidad.Index).Value = Detalle.CantidadxProducto
                        Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmPrecioUnitario.Index).Value = Detalle.PrecioUnitario
                        Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmImporteDetalle.Index).Value = Detalle.CantidadxProducto * Detalle.PrecioUnitario
                        i = i + 1
                        Renglones = i
                    Next
                Else
                    For Each Detalle As FacturasDetalleClass In FacturasCab.Detalles
                        If Detalle.IdTipoGanado = 0 Then
                            'Me.dgvFacturasDetalle.Rows.RemoveAt(FacturasCab.Detalles.Count)
                            Exit For
                        End If
                        Dim TipoGanado As New TipoGanadoClass
                        Me.clmDescripcion.Visible = False
                        Me.clmCantidad.Visible = False
                        Me.clmPrecioUnitario.Visible = False
                        Me.clmImporteDetalle.Visible = False
                        TipoGanado.Obtener(Detalle.IdTipoGanado)
                        Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmTipoGanado.Index).Value = TipoGanado.Descripcion
                        Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmCabezas.Index).Value = Detalle.CabezasxTipoGanado
                        Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmKilos.Index).Value = Detalle.KilosxTipoGanado
                        Me.dgvFacturasDetalle.Rows(i).Cells(Me.clmPrecioxKilo.Index).Value = Detalle.PrecioxKiloxTipoGanado
                        i = i + 1
                        Renglones = i
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub dgvFacturasCabecero_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturasCabecero.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            If busquedaNotas = True Then
                frmPrincipal.btnRelacion.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvFacturasCabecero_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvFacturasCabecero.CellFormatting
        'VariantType()
    End Sub
End Class