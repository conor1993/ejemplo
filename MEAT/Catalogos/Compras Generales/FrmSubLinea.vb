Imports System.Windows.Forms

Public Class FrmSubLinea

    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim WithEvents Sublinea As ClasesNegocio.SubLineaClass
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.SubLineaClass)

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescCorta.Focus()
            If txtDescripcion.Text = "" Then
                MsgBox("Agregue Información a la Descripción . . . ", MsgBoxStyle.Exclamation, "Faltan Datos")
                txtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = Chr(32) Then
            e.Handled = True
        End If
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtObservacion.Focus()
            If txtDescCorta.Text = "" Then
                MsgBox("Agregue Información a la Descripción Corta . . . ", MsgBoxStyle.Exclamation, "Faltan Datos")
                txtDescCorta.Focus()
            End If
        End If
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        DtpFecha.Value = Now
        CmbLinea.SelectedIndex = -1
        CmbLinea.Text = "Seleccione una Linea..."
        txtDescripcion.Clear()
        txtDescCorta.Clear()
        TxtObservacion.Clear()
        seleccionado = False
        Editar = False
        Me.lblEstatus.Visible = False
        Me.lblEstatus.Text = "ESTATUS"
    End Sub

    Private Sub Deshabilitar()
        CmbLinea.Enabled = False
        txtDescripcion.Enabled = False
        txtDescCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        CmbLinea.Enabled = True
        txtDescripcion.Enabled = True
        txtDescCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub Guardar()
        Sublinea.FechaAlta = DtpFecha.Value
        Sublinea.Linea = CmbLinea.SelectedItem
        Sublinea.Descripcion = txtDescripcion.Text
        Sublinea.DescCorta = txtDescCorta.Text
        Sublinea.Observaciones = TxtObservacion.Text
    End Sub

    Private Function Validar() As Boolean
        If Me.txtDescripcion.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            txtDescripcion.Focus()
            Return False
        End If

        If Me.txtDescCorta.Text = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
            txtDescCorta.Focus()
            Return False
        End If

        If Me.CmbLinea.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una linea", MsgBoxStyle.Exclamation, "Faltan Datos")
            CmbLinea.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaSubLineasXEstatus"
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@Estatus", SqlDbType.SmallInt).Value = ClasesNegocio.CondicionEnum.TODOS
            com.Connection = New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

            Dim ad As New SqlClient.SqlDataAdapter

            ad.SelectCommand = com
            com.Connection.Open()

            Dim tb As New DataTable

            ad.Fill(tb)

            Me.DataGrid.AutoGenerateColumns = False
            Me.DataGrid.DataSource = tb
            ClmCodigo.DataPropertyName = "Código"
            ClmDescripcion.DataPropertyName = "Descripción"
            ClmDescripcionCorta.DataPropertyName = "Descripción Corta"
            ClmObservaciones.DataPropertyName = "Observaciones"
            ClmLinea.DataPropertyName = "Línea"
            ClmFechaAlta.DataPropertyName = "Fecha de Alta"
            ClmEstatus.DataPropertyName = "Estatus"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            com.Connection.Close()
        End Try
    End Sub

#End Region

    Private Sub Sublinea_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Sublinea.Modificado
        If puedorefrescar Then
            txtCodigo.Text = Sublinea.Codigo
            DtpFecha.Value = Sublinea.FechaAlta
            CmbLinea.SelectedValue = Sublinea.Linea.Codigo
            txtDescripcion.Text = Sublinea.Descripcion
            txtDescCorta.Text = Sublinea.DescCorta
            TxtObservacion.Text = Sublinea.Observaciones
            lblEstatus.Text = Sublinea.Estatus.ToString
        End If
    End Sub

    Private Sub Sublinea_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Sublinea.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub FrmSubLinea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        Deshabilitar()
        Me.LineaCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        LlenarGrid()
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        Try
            If Sublinea.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If Sublinea.Borrar Then
                    MsgBox("La Sublinea ha sido inactivada.", MsgBoxStyle.Information, "Aviso")
                    Deshabilitar()
                    LlenarGrid()
                    Limpiar()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("La Sublinea ya ha sido inactivada.", MsgBoxStyle.Exclamation, "Aviso")
                Limpiar()
                Deshabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        Cursor = Cursors.WaitCursor
        If Sublinea.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Editar = True
            txtDescripcion.Focus()
        Else
            If MessageBox.Show("La Sub-Linea esta inactiva, ¿Desea Activarla?", "Activar Sub-Linea", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Sublinea.Linea.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                    Sublinea.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblEstatus.Text = Sublinea.Estatus.ToString
                    Habilitar()
                    txtDescripcion.Focus()
                    Editar = True
                Else
                    MsgBox(String.Format("No es posible activar la sub-línea, debe activar la línea {0}", Sublinea.Linea.Descripcion), MsgBoxStyle.Exclamation, "Activar Línea")
                    Cancelar = True
                    MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                    Limpiar()
                    Deshabilitar()
                End If
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                Deshabilitar()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try

            If Not Validar() Then
                Cancelar = True
                Cursor = Cursors.Default
                Exit Sub
            End If

            puedorefrescar = False
            Guardar()
            puedorefrescar = True

            If Sublinea.Guardar Then
                If Editar Then
                    MsgBox("La Sublinea se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Sublinea se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If

                Limpiar()
                Deshabilitar()
                LlenarGrid()
            Else
                Cancelar = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            Me.SubLineaCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Previsualizar.Text = "Reporte de ABC de Sub-Lineas"
            Previsualizar.Reporte = SubLineaCollectionClass1.Reporte
            Previsualizar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
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
        Sublinea = New ClasesNegocio.SubLineaClass
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Cursor = Cursors.WaitCursor
        Try
            If DataGrid.SelectedRows.Count > 0 Then
                Sublinea = New ClasesNegocio.SubLineaClass
                Sublinea.Obtener(DataGrid.SelectedRows(0).Cells(0).Value)

                puedorefrescar = True
                Sublinea_Modificado(Me, e)
                puedorefrescar = False

                MEAToolBar1.sbCambiarEstadoBotones("Buscar")
                Me.seleccionado = True
                Me.lblEstatus.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CmbLinea_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbLinea.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.LineaCollectionClass1.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub
End Class