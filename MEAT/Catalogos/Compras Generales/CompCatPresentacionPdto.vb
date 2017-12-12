Public Class CompCatPresentacionPdto

    Dim WithEvents Presentacion As ClasesNegocio.presentacionClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.presentacionClass)

    Private Sub CompCatPrestacionPdto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        Me.UnidadesMedidaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        LlenarGrid()
        deshabilitar()
        limpiar()
    End Sub

    Private Sub TxtDescripción_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripción.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescCorta.Focus()
            If TxtDescripción.Text = "" Then
                MsgBox("Agregue Información a Descripción ", MsgBoxStyle.Exclamation, "Faltan Datos")
                TxtDescripción.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescCorta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtPiezas.Focus()
            If TxtDescCorta.Text = "" Then
                MsgBox("Agregue Información a Descripción Corta", MsgBoxStyle.Exclamation, "Faltan Datos")
                TxtDescCorta.Focus()
            End If
        End If

        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPiezas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPiezas.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbUnidadMedida.Focus()
            If TxtPiezas.Text = "" Then
                MsgBox("Agregue Información a Piezas ", MsgBoxStyle.Exclamation, "Faltan Datos")
                TxtPiezas.Focus()
            End If
        End If

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Valida que el caracter ingresado sea numerico
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        Txtcodigo.Clear()
        TxtDescripción.Clear()
        TxtDescCorta.Clear()
        TxtPiezas.Text = "0"
        CmbUnidadMedida.SelectedIndex = -1
        CmbUnidadMedida.Text = "Seleccione una Unidad de Medida"
        TxtObservacion.Clear()
        LblEstatus.Text = "ESTATUS"
        selesccionado = False
        Editar = False
        Me.LblEstatus.Visible = False
        TxtDescripción.Focus()
    End Sub

    Private Sub deshabilitar()
        TxtDescripción.Enabled = False
        TxtDescCorta.Enabled = False
        TxtPiezas.Enabled = False
        CmbUnidadMedida.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        TxtDescripción.Enabled = True
        TxtDescCorta.Enabled = True
        TxtPiezas.Enabled = True
        CmbUnidadMedida.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub guardar()
        Presentacion.Descripcion = TxtDescripción.Text
        Presentacion.DescripcionCta = TxtDescCorta.Text
        Presentacion.Piezas = TxtPiezas.Text
        Presentacion.UnidadMedida = CmbUnidadMedida.SelectedItem
        Presentacion.Observaciones = TxtObservacion.Text
    End Sub

    Private Function Validar() As Boolean
        If Me.TxtDescripción.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.TxtDescripción.Focus()
            Return False
        End If

        If Me.TxtDescCorta.Text = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
            TxtDescCorta.Focus()
            Return False
        End If

        If Not IsNumeric(Me.TxtPiezas.Text) Then
            TxtPiezas.Text = 0
        End If

        If CLng(Me.TxtPiezas.Text) <= 0 Then
            MsgBox("Debe ingresar piezas", MsgBoxStyle.Exclamation, "Aviso")
            Me.TxtPiezas.Focus()
            Return False
        End If

        If CmbUnidadMedida.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una Unidad de Medida", MsgBoxStyle.Exclamation, "Faltan Datos")
            CmbUnidadMedida.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaPresentacionXEstatus"
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
            ClmPiezas.DataPropertyName = "Piezas"
            ClmUnidadMedida.DataPropertyName = "Unidad de Medida"
            ClmObservaciones.DataPropertyName = "Observaciones"
            'ClmFechaAlta.DataPropertyName = "Fecha de Alta"
            ClmEstatus.DataPropertyName = "Estatus"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            com.Connection.Close()
        End Try
    End Sub

#End Region

    Private Sub Presentacion_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Presentacion.Modificado
        If puedorefrescar Then
            Txtcodigo.Text = Presentacion.Codigo
            TxtDescripción.Text = Presentacion.Descripcion
            TxtDescCorta.Text = Presentacion.DescripcionCta
            TxtPiezas.Text = Presentacion.Piezas
            CmbUnidadMedida.SelectedValue = Presentacion.UnidadMedida.Codigo
            TxtObservacion.Text = Presentacion.Observaciones
            LblEstatus.Text = Presentacion.Estatus.ToString
        End If
    End Sub

    Private Sub Presentacion_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Presentacion.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.selesccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        If Presentacion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If Presentacion.Borrar Then
                MsgBox("La Presentación ha sido Inactivada.", MsgBoxStyle.Information, "Aviso")
                deshabilitar()
                limpiar()
                LlenarGrid()
            Else
                Cancelar = True
            End If
        Else
            MsgBox("La Presentacion ya esta inactivada.", MsgBoxStyle.Exclamation, "Aviso")
            limpiar()
            deshabilitar()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        Cursor = Cursors.WaitCursor
        Try
            If Presentacion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                Habilitar()
                Editar = True
                Me.TxtDescripción.Focus()
            Else
                If MessageBox.Show("La Presentación esta inactiva, ¿Desea Activarla?", "Activar Precentación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If Presentacion.UnidadMedida.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                        Presentacion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                        Me.LblEstatus.Text = Presentacion.Estatus.ToString
                        Habilitar()
                        Editar = True
                        Me.TxtDescripción.Focus()
                    Else
                        MsgBox("No se peude activar la presentacion, la unidad de medida " & Presentacion.UnidadMedida.Descripcion & _
                        " esta inactiva", MsgBoxStyle.Exclamation, "Unidad de Medida Inactiva")
                        Cancelar = True
                        MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                        limpiar()
                        deshabilitar()
                    End If
                Else
                    Cancelar = True
                    MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                    limpiar()
                    deshabilitar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If Presentacion.Guardar Then
                If Editar Then
                    MsgBox("La Presentacion se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Presentacion se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If
                limpiar()
                deshabilitar()
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

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Habilitar()
        limpiar()
        Presentacion = New ClasesNegocio.presentacionClass()
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Cursor = Cursors.WaitCursor
        Try
            If DataGrid.SelectedRows.Count > 0 Then
                Presentacion = New ClasesNegocio.presentacionClass
                Presentacion.Obtener(Me.DataGrid.SelectedRows(0).Cells(0).Value)
                puedorefrescar = True
                Presentacion_Modificado(Me, e)
                puedorefrescar = False

                MEAToolBar1.sbCambiarEstadoBotones("Buscar")
                Me.selesccionado = True
                Me.LblEstatus.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            PresentacionC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Previsualizar.Reporte = PresentacionC.Reporte
            Previsualizar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class