Public Class FrmSucursal

    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Dim WithEvents Sucursal As New ClasesNegocio.SucursalClass

    Private Sub dtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescripcion.Focus()
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
            txtObservaciones.Focus()
            If txtDescripcionCorta.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción Corta . . . ")
                txtDescripcionCorta.Focus()
            End If
        End If
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        Me.txtCodigo.Text = ""
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.SelectedValue = "Seleccione Plaza"
        Me.txtDescripcion.Text = ""
        Me.txtDescripcionCorta.Text = ""
        Me.txtObservaciones.Text = ""
        lblEstatus.Text = "ESTATUS"
        Me.txtLetras.Clear()
        selesccionado = False
        Editar = False
        Me.lblEstatus.Visible = False
        Me.cmbPlaza.Focus()
    End Sub

    Private Sub Deshabilitar()
        txtCodigo.Enabled = False
        cmbPlaza.Enabled = False
        txtDescripcion.Enabled = False
        txtDescripcionCorta.Enabled = False
        txtObservaciones.Enabled = False
        DataGrid.Enabled = True
        Me.txtLetras.Enabled = False
    End Sub

    Private Sub Habilitar()
        txtCodigo.Enabled = False
        cmbPlaza.Enabled = True
        txtDescripcion.Enabled = True
        txtDescripcionCorta.Enabled = True
        txtObservaciones.Enabled = True
        DataGrid.Enabled = False
        Me.txtLetras.Enabled = True
    End Sub

    Private Sub guardar()
        Sucursal.IdPlaza = CType(cmbPlaza.SelectedValue, Integer)
        Sucursal.Descripcion = txtDescripcion.Text
        Sucursal.DescripcionCorta = txtDescripcionCorta.Text
        Sucursal.Observaciones = txtObservaciones.Text
    End Sub

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaSucursalesXEstatus"
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@Estatus", SqlDbType.SmallInt).Value = ClasesNegocio.CondicionEnum.TODOS
            com.Connection = New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

            Dim ad As New SqlClient.SqlDataAdapter

            ad.SelectCommand = com
            com.Connection.Open()

            Dim tb As New DataTable

            ad.Fill(tb)

            DataGrid.AutoGenerateColumns = False
            Me.DataGrid.DataSource = tb
            ClmCodigo.DataPropertyName = "Código"
            ClmDescripcion.DataPropertyName = "Descripción"
            ClmDescripcionCorta.DataPropertyName = "Descripción Corta"
            ClmPlaza.DataPropertyName = "Plaza"
            ClmObservaciones.DataPropertyName = "Observaciones"
            ClmFechaAlta.DataPropertyName = "Fecha de Alta"
            ClmEstatus.DataPropertyName = "Estatus"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            com.Connection.Close()
        End Try
    End Sub

#End Region

    Private Sub Sucursal_MensajeError(ByVal sender As Object, ByVal mensaje As String)
        MessageBox.Show(mensaje)
    End Sub

    Private Sub Sucursal_Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
        If puedorefrescar Then
            txtCodigo.Text = Sucursal.Codigo
            cmbPlaza.SelectedValue = Sucursal.Plaza.Codigo
            txtDescripcion.Text = Sucursal.Descripcion
            txtDescripcionCorta.Text = Sucursal.DescripcionCorta
            txtObservaciones.Text = Sucursal.Observaciones
            lblEstatus.Text = Sucursal.Estatus.ToString
            Me.txtLetras.Text = Sucursal.Letra
        End If
    End Sub

    Private Sub FrmSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        LlenarGrid()
        limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        Try
            If Sucursal.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If Sucursal.Borrar Then
                    MsgBox("La Sucursal ha sido inactivada.", MsgBoxStyle.Information, "Aviso")
                    Deshabilitar()
                    LlenarGrid()
                    limpiar()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("La Sucursal ya esta inactivada.", MsgBoxStyle.Exclamation, "Aviso")
                limpiar()
                Deshabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Sucursal.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Editar = True

            ''If Me.HabilitarPlaza Then
            ''    cmbPlaza.Focus()
            ''Else
            ''    cmbPlaza.Enabled = False
            ''    Me.txtDescripcion.Focus()
            ''End If

            ' Me.txtLetras.Enabled = Me.HabilitarLetra
        Else
            If MessageBox.Show("La  Sucursal esta inactiva, ¿Desea Activarla?", "Activar Sucursal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Sucursal.Plaza.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                    Sucursal.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblEstatus.Visible = True
                    Me.lblEstatus.Text = Sucursal.Estatus.ToString
                    Editar = True
                    Habilitar()

                    ''If Me.HabilitarPlaza Then
                    ''    cmbPlaza.Focus()
                    ''Else
                    ''    cmbPlaza.Enabled = False
                    ''    Me.txtDescripcion.Focus()
                    ''End If

                    ''Me.txtLetras.Enabled = Me.HabilitarLetra
                Else
                    MsgBox(String.Format("No es posible activar la sucursal, debe activar la plaza {0}", Sucursal.Plaza.Descripcion), MsgBoxStyle.Exclamation, "Plaza Inactiva")
                    Cancelar = True
                    MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                    limpiar()
                    Deshabilitar()
                End If
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                limpiar()
                Deshabilitar()
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try

            If Me.txtDescripcion.Text = "" Then
                MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            If Me.txtDescripcionCorta.Text = "" Then
                MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            If Me.cmbPlaza.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar una plaza", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If Sucursal.Guardar Then
                If Editar Then
                    MsgBox("La Sucursal se ha modificada satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Sucursal se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If

                limpiar()
                Deshabilitar()
                LlenarGrid()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir

        'Me.SucursalCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
        'Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
        'Previsualizar.Text = "Reporte de ABC de Sucursales"
        'Previsualizar.Reporte = SucursalCol.Reporte
        'Previsualizar.ShowDialog()

        Cursor = Cursors.WaitCursor
        Try
            SucursalCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If SucursalCol.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptABCSucursales = SucursalCol.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(SucursalCol)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Generales\Sucursales")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ninguna Sucursal", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.selesccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Habilitar()
        limpiar()
        Sucursal = New ClasesNegocio.SucursalClass
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub DataGrid_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        If Me.DataGrid.SelectedRows.Count > 0 Then
            Sucursal = New ClasesNegocio.SucursalClass
            Sucursal.Obtener(DataGrid.SelectedRows(0).Cells(0).Value)

            puedorefrescar = True
            Sucursal_Modificado(Me, e)
            puedorefrescar = False
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.selesccionado = True
            Me.lblEstatus.Visible = True
        End If
    End Sub

End Class