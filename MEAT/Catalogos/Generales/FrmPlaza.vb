Public Class FrmPlaza

    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim WithEvents Plaza As New ClasesNegocio.PlazaClass

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
                MsgBox("Agregue Informacion a la Descripción . . . ", MsgBoxStyle.Exclamation, "Aviso")
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
            txtObservacion.Focus()
            If txtDescripcionCorta.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción Corta . . . ", MsgBoxStyle.Exclamation, "Aviso")
                txtDescripcionCorta.Focus()
            End If
        End If
    End Sub

#Region "metodos"

    Private Sub limpiar()
        Me.txtCodigo.Clear()
        Me.dtpFecha.Value = Now
        Me.txtDescripcion.Clear()
        Me.txtDescripcionCorta.Clear()
        Me.txtObservacion.Clear()
        lblEstatus.Text = "ESTATUS"
        seleccionado = False
        Editar = False
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub Deshabilitar()
        txtDescripcion.Enabled = False
        txtDescripcionCorta.Enabled = False
        txtObservacion.Enabled = False
        Datagrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        txtDescripcion.Enabled = True
        txtDescripcionCorta.Enabled = True
        txtObservacion.Enabled = True
        Datagrid.Enabled = False
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub guardar()
        Plaza.FechaAlta = dtpFecha.Value
        Plaza.Descripcion = txtDescripcion.Text
        Plaza.DescripcionCorta = txtDescripcionCorta.Text
        Plaza.Observaciones = txtObservacion.Text
    End Sub

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaPlazaXEstatus"
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

    Private Sub plaza_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Plaza.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub plaza_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Plaza.Modificado
        If puedorefrescar Then
            txtCodigo.Text = Plaza.Codigo
            dtpFecha.Value = Plaza.FechaAlta
            txtDescripcion.Text = Plaza.Descripcion
            txtDescripcionCorta.Text = Plaza.DescripcionCorta
            txtObservacion.Text = Plaza.Observaciones
            Me.lblEstatus.Text = Plaza.Estatus.ToString
        End If
    End Sub

    Private Sub FrmPlaza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = "100100011"
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "000100011"
            MtbEstados.StateBorrar = "000100011"
            MtbEstados.StateEditar = "0010100001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            MEAToolBar1.ToolBarButtonStatus = MtbEstados
            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
            Deshabilitar()
            LlenarGrid()
            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        Try
            If Plaza.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If Plaza.Borrar Then
                    MsgBox("La Plaza ha sido Inactivada.", MsgBoxStyle.Information, "Aviso")
                    Deshabilitar()
                    limpiar()
                    LlenarGrid()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("La Plaza ya esta Inactivada.", MsgBoxStyle.Exclamation, "Aviso")
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
        If Plaza.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            Habilitar()
            Editar = True
            Me.txtDescripcion.Focus()
        Else
            If MessageBox.Show("La Plaza esta Inactiva, ¿Desea Activarla?", "Activar Plaza", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Plaza.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Visible = True
                Me.lblEstatus.Text = Plaza.Estatus.ToString
                Editar = True
                Habilitar()
                Me.txtDescripcion.Focus()
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
            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If txtDescripcion.Text = "" Or txtDescripcionCorta.Text = "" Then
                MsgBox("La Descripción y Descripción Corta es Obligatoria Agregue Información ", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
            Else
                If Plaza.Guardar Then
                    If Editar Then
                        MsgBox("La Plaza se ha modificada satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                    Else
                        MsgBox("La Plaza se ha guardada satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                    End If
                    limpiar()
                    Deshabilitar()
                    LlenarGrid()
                Else
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

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            'Me.PlazaCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            'Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            'Previsualizar.Text = "Reporte de ABC de Plazas"
            'Previsualizar.Reporte = PlazaCollectionClass1.Reporte
            'Previsualizar.ShowDialog()

            PlazaCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If PlazaCollectionClass1.Count.ToString > 0 Then
                Dim Reporte As New ClasesNegocio.rptABCPlazas
                Dim VerReporte As New FrmReportes
                Reporte.SetDataSource(PlazaCollectionClass1)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(2, "Catalogos\Generales\Plazas")
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningua Plaza", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.seleccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        limpiar()
        Habilitar()
        Editar = False
        Plaza = New ClasesNegocio.PlazaClass()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub Datagrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Datagrid.DataError

    End Sub

    Private Sub Datagrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Datagrid.DoubleClick
        If Datagrid.SelectedRows.Count > 0 Then
            Plaza = New ClasesNegocio.PlazaClass
            Plaza.Obtener(Datagrid.SelectedRows(0).Cells(0).Value)
            plaza_Modificado(Me, e)
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.seleccionado = True
            Me.lblEstatus.Visible = True
        End If
    End Sub

End Class