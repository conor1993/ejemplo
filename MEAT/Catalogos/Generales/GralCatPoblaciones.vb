Public Class GralCatPoblaciones

    Dim WithEvents Poblacion As ClasesNegocio.PoblacionClass
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim bandera As Boolean = False

    Private Sub CmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstado.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbCiudad.Focus()
            If CmbEstado.Text = "" Then
                MsgBox("Agregue Información al Combo de Estado . . . ", MsgBoxStyle.Exclamation, "Aviso")
                CmbEstado.Focus()
            End If
        End If
    End Sub

    Private Sub CmbCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCiudad.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripcion.Focus()
            If CmbCiudad.Text = "" Then
                MsgBox("Agregue Información al Combo de Ciudad . . . ", MsgBoxStyle.Exclamation, "Aviso")
                CmbCiudad.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescCorta.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Información a la Descripción . . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescCorta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtObservacion.Focus()
            If TxtDescCorta.Text = "" Then
                MsgBox("Agregue Información a la Descripción Corta. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescCorta.Focus()
            End If
        End If

        'Impedir que pueda teclear Espacios
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        CmbEstado.SelectedIndex = -1
        CmbEstado.Text = "Seleccione un Estado..."
        CmbCiudad.SelectedIndex = -1
        CmbCiudad.Text = "Seleccione una Ciudad..."
        TxtCodigo.Clear()
        TxtDescripcion.Clear()
        TxtDescCorta.Clear()
        TxtObservacion.Clear()
        LblEstatus.Text = "ESTATUS"
        seleccionado = False
        Editar = False
        LblEstatus.Visible = False
        Me.TxtDescripcion.Focus()
    End Sub

    Private Sub deshabilitar()
        CmbEstado.Enabled = False
        CmbCiudad.Enabled = False
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub habilitar()
        CmbEstado.Enabled = True
        CmbCiudad.Enabled = True
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = True
        TxtDescCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub guardar()
        Poblacion.CodigoEstado = CmbEstado.SelectedItem
        Poblacion.CodigoCiudad = CmbCiudad.SelectedItem
        Poblacion.Descripcion = TxtDescripcion.Text
        Poblacion.DescripcionCorta = TxtDescCorta.Text
        Poblacion.Observaciones = TxtObservacion.Text
    End Sub

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaPoblacionesXEstatus"
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
            ClmEstado.DataPropertyName = "Estado"
            ClmCiudad.DataPropertyName = "Ciudad"
            ClmObservaciones.DataPropertyName = "Observaciones"
            ClmEstatus.DataPropertyName = "Estatus"
            clmCodEstado.DataPropertyName = "CodEstado"
            clmCodCd.DataPropertyName = "CodCiudad"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            com.Connection.Close()
        End Try
    End Sub

#End Region

    Private Sub GralCatPoblaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        bandera = False
        ' Barra de botones de la ToolBar...
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
        EstadoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        LlenarGrid()
        deshabilitar()
        limpiar()
        Cursor = Cursors.Default
        bandera = True
    End Sub

    Private Sub CmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEstado.SelectedIndexChanged
        If CmbEstado.SelectedIndex > -1 And Not Me.CmbEstado.ValueMember = "" And bandera Then
            CiudadC.Obtener(CInt(CmbEstado.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbCiudad.SelectedIndex = -1
            CmbCiudad.Text = "Seleccione una Ciudad..."
        Else
            CiudadC.Clear()
            Me.CmbCiudad.SelectedIndex = -1
            CmbCiudad.Text = ""
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
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
        habilitar()
        Editar = False
        Poblacion = New ClasesNegocio.PoblacionClass()
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try

            If Me.TxtDescripcion.Text = "" Then
                MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = False
                Exit Sub
            End If

            If Me.TxtDescCorta.Text = "" Then
                MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            If Me.CmbEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar un estado", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            If CmbCiudad.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar una ciudad", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            guardar()

            If Poblacion.Guardar Then
                If Editar Then
                    MsgBox("La Población se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Población se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If
                deshabilitar()
                limpiar()
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

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Cursor = Cursors.WaitCursor
        If Me.DataGrid.SelectedRows.Count > 0 Then
            Poblacion = New ClasesNegocio.PoblacionClass
            Poblacion.Obtener(DataGrid.SelectedRows(0).Cells(clmCodEstado.Index).Value, DataGrid.SelectedRows(0).Cells(clmCodCd.Index).Value, DataGrid.SelectedRows(0).Cells(0).Value)

            CmbEstado.SelectedValue = CInt(DataGrid.SelectedRows(0).Cells(clmCodEstado.Index).Value)
            CmbCiudad.SelectedValue = CInt(DataGrid.SelectedRows(0).Cells(clmCodCd.Index).Value)
            TxtCodigo.Text = Poblacion.Codigo
            TxtDescripcion.Text = Poblacion.Descripcion
            TxtDescCorta.Text = Poblacion.DescripcionCorta
            TxtObservacion.Text = Poblacion.Observaciones
            LblEstatus.Text = Poblacion.Estatus.ToString

            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.seleccionado = True
            Me.LblEstatus.Visible = True
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Poblacion.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            habilitar()
            Editar = True
            Me.TxtDescripcion.Focus()
        Else
            If MessageBox.Show("La Poblacion esta inactiva, ¿Desea Activarla?", "Activar Población", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Poblacion.CodigoCiudad.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                    Poblacion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.LblEstatus.Visible = True
                    Me.LblEstatus.Text = Poblacion.Estatus.ToString
                    Editar = True
                    habilitar()
                    Me.TxtDescripcion.Focus()
                Else
                    MsgBox(String.Format("No es posible activarlo, primero debe activar la ciudad {0}", Poblacion.CodigoCiudad.Descripcion), MsgBoxStyle.Exclamation, "Ciudad Inactiva")
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
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        If Poblacion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If Poblacion.Borrar Then
                MsgBox("La Población ha sido Inactivada.", MsgBoxStyle.Information, "Aviso")
                deshabilitar()
                LlenarGrid()
                limpiar()
            Else
                Cancelar = True
            End If
        Else
            MsgBox("La Población Ya esta Inactivada.", MsgBoxStyle.Exclamation, "Aviso")
            limpiar()
            deshabilitar()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        'PoblacionC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
        'Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
        'Previsualizar.Text = "Reporte de ABC de Poblaciones"
        'Previsualizar.Reporte = PoblacionC.Reporte
        'Previsualizar.ShowDialog()

        Cursor = Cursors.WaitCursor
        Try
            PoblacionC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If PoblacionC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.CRepPblacion = PoblacionC.Reporte
                Dim VerReporte As New FrmReportes
                Reporte.SetParameterValue(0, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(1, "Catalogos\Generales\Poblaciones")
                Reporte.SetParameterValue(2, Controlador.Sesion.MiEmpresa.Empnom)
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ninguna Poblacion", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class