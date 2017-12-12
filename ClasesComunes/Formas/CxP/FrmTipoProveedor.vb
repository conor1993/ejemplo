Public Class FrmTipoProveedor
    Dim WithEvents TipoProveedor As New ClasesNegocio.TiposProveedoresClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    'Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.TiposProveedoresClass)

    Private Sub FrmTipoProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100001"
        MtbEstados.StateEditar = "0010100001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        Deshabilitar()
        Me.TiposProveedorCollectionClass1.Obtener()
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub dtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            dtpFecha.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescripcionCorta.Focus()
            If txtDescripcion.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción . . . ")
                txtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescripcionCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionCorta.KeyPress
        If e.KeyChar = Chr(32) Then
            e.Handled = True
        End If
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtObservacion.Focus()
            If txtDescripcionCorta.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción Corta . . . ")
                txtDescripcionCorta.Focus()
            End If
        End If
    End Sub

    Private Sub TipoProveedor_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles TipoProveedor.MensajeError
        MessageBox.Show(mensaje)
    End Sub

    Private Sub TipoProveedor_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles TipoProveedor.Modificado
        If puedorefrescar Then
            txtCodigo.Text = TipoProveedor.Codigo
            dtpFecha.Value = TipoProveedor.FechaAlta
            txtDescripcion.Text = TipoProveedor.Descripcion
            txtDescripcionCorta.Text = TipoProveedor.DescripcionCorta
            TxtObservacion.Text = TipoProveedor.Observaciones
            Me.lblEstatus.Visible = True
            lblEstatus.Text = TipoProveedor.Estatus.ToString
        End If
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.dtpFecha.Value = Now
        Me.txtDescripcion.Clear()
        Me.txtDescripcionCorta.Clear()
        Me.TxtObservacion.Clear()
        Me.lblEstatus.Visible = False
        lblEstatus.Text = "ESTATUS"
        seleccionado = False
    End Sub

    Private Sub Deshabilitar()
        txtCodigo.Enabled = False
        dtpFecha.Enabled = False
        txtDescripcion.Enabled = False
        txtDescripcionCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        txtCodigo.Enabled = False
        dtpFecha.Enabled = True
        txtDescripcion.Enabled = True
        txtDescripcionCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub Guardar()
        TipoProveedor.FechaAlta = dtpFecha.Value
        TipoProveedor.Descripcion = txtDescripcion.Text
        TipoProveedor.DescripcionCorta = txtDescripcionCorta.Text
        TipoProveedor.Observaciones = TxtObservacion.Text
        TipoProveedor.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
    End Sub

#End Region

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        If TipoProveedor.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If TipoProveedor.Borrar Then
                MessageBox.Show("El Tipo de Proveedor ha sido Inactivado.")
                Deshabilitar()
                TiposProveedorCollectionClass1.Obtener()
                Limpiar()
            Else
                Cancelar = True
            End If
        Else
            MessageBox.Show("El Tipo de Proveedor ya esta Inactivado.")
            Limpiar()
            Deshabilitar()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If TipoProveedor.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            Habilitar()
            Editar = True
        Else
            MessageBox.Show("El Tipo de Proveedor esta Inactivo No se Puede Editar.")
            Editar = False
            Cancelar = True
            MEAToolBar1.sbCambiarEstadoBotones("Guardar")
            Limpiar()
            Deshabilitar()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If txtDescripcion.Text = "" Or txtDescripcionCorta.Text = "" Then
                MessageBox.Show("La Descripción y Descripción Corta es Obligatoria Agregue Información ")
                Cancelar = True
            Else
                If TipoProveedor.Guardar Then
                    MessageBox.Show("El Tipo de Proveedor se ha guardado satisfactoriamente.")
                    Limpiar()
                    Deshabilitar()
                    TiposProveedorCollectionClass1.Obtener()
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            'Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            'Previsualizar.Text = "Reporte Tipos de Proveedores"
            'Previsualizar.Reporte = TiposProveedorCollectionClass1.Reporte
            'Previsualizar.ShowDialog()

            TiposProveedorCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim Reporte As New ClasesNegocio.rptABCTiposProveedores
            Dim VerReporte As New FrmReportes
            Reporte.SetDataSource(TiposProveedorCollectionClass1)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(2, "Catalogos\Cuentas por Pagar\Tipos de Proveedores")
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.seleccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Limpiar()
        Habilitar()
        Editar = False
        TipoProveedor = New ClasesNegocio.TiposProveedoresClass()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        If Me.DataGrid.SelectedRows.Count > 0 Then
            TipoProveedor = New ClasesNegocio.TiposProveedoresClass(CInt(Me.DataGrid.SelectedRows(0).Cells(Me.CodigoDataGridViewTextBoxColumn.Index).Value))

            If Not IsNothing(TipoProveedor) Then
                TipoProveedor_Modificado(Me, e)
                MEAToolBar1.sbCambiarEstadoBotones("Buscar")
                Me.seleccionado = True
            Else
                Windows.Forms.MessageBox.Show("No selecciono un elemento valido.")
            End If
        End If
    End Sub
End Class