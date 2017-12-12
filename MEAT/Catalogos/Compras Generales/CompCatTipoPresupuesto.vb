Public Class CompCatTipoPresupuesto

    Dim WithEvents Presupuesto As ClasesNegocio.TipoPresupuestoClass
    Dim WithEvents Presupuestos As New ClasesNegocio.TipoPresupuestoCollectionClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False

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
            TxtObservaciones.Focus()
            If TxtDescCorta.Text = "" Then
                MsgBox("Agregue Información a Descripción Corta", MsgBoxStyle.Exclamation, "Faltan Datos")
                TxtDescCorta.Focus()
            End If
        End If
        'Impedir que pueda escribir Espacios
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub CompCatTipoPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        LlenarGrid()
        deshabilitar()
        limpiar()
    End Sub

    Private Sub Presupuesto_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Presupuesto.Modificado
        If puedorefrescar Then
            Txtcodigo.Text = Presupuesto.Codigo
            TxtDescripción.Text = Presupuesto.Descripcion
            TxtDescCorta.Text = Presupuesto.DescripcionCta
            TxtObservaciones.Text = Presupuesto.Observaciones
            LblEstatus.Text = Presupuesto.Estatus.ToString
        End If
    End Sub

#Region "METODOS"

    Private Sub limpiar()
        Txtcodigo.Clear()
        DtpFechaAlta.Value = Now
        TxtDescripción.Clear()
        TxtDescCorta.Clear()
        TxtObservaciones.Clear()
        LblEstatus.Text = "ESTATUS"
        selesccionado = False
        Editar = False
        Me.LblEstatus.Visible = False
        TxtDescripción.Focus()
    End Sub

    Private Sub deshabilitar()
        TxtDescripción.Enabled = False
        TxtDescCorta.Enabled = False
        TxtObservaciones.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub habilitar()
        TxtDescripción.Enabled = True
        TxtDescCorta.Enabled = True
        TxtObservaciones.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub Guardar()
        Presupuesto.FechaAlta = Now
        Presupuesto.Descripcion = TxtDescripción.Text
        Presupuesto.DescripcionCta = TxtDescCorta.Text
        Presupuesto.Observaciones = TxtObservaciones.Text
    End Sub

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaTipoPresupuestoXEstatus"
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

    Private Function Validar() As Boolean
        If Me.TxtDescripción.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.TxtDescripción.Focus()
            Return False
        End If

        If Me.TxtDescCorta.Text = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.TxtDescCorta.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
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

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Presupuesto.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            habilitar()
            Editar = True
            Me.TxtDescripción.Focus()
        Else
            If MessageBox.Show("El Tipo de Presupuesto esta Inactivo, ¿Desea Activarlo?", "Activar Tipo Presupuesto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Presupuesto.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.LblEstatus.Text = Presupuesto.Estatus.ToString
                habilitar()
                Editar = True
                Me.TxtDescripción.Focus()
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                limpiar()
                deshabilitar()
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            Guardar()
            puedorefrescar = True

            If Presupuesto.Guardar Then
                If Editar Then
                    MsgBox("El Tipo de Presupuesto se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("El Tipo de Presupuesto se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
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

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        Try
            If Presupuesto.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If Presupuesto.Borrar Then
                    MsgBox("El Tipo de Presupuesto ha sido inactivado.", MsgBoxStyle.Information, "Aviso")
                    deshabilitar()
                    limpiar()
                    LlenarGrid()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("El Tipo de Presupuesto ya esta inactivado.", MsgBoxStyle.Exclamation, "Aviso")
                limpiar()
                deshabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        habilitar()
        limpiar()
        Presupuesto = New ClasesNegocio.TipoPresupuestoClass()
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Cursor = Cursors.WaitCursor
        Try
            If DataGrid.SelectedRows.Count > 0 Then
                Presupuesto = New ClasesNegocio.TipoPresupuestoClass(CInt(DataGrid.SelectedRows(0).Cells(0).Value))

                puedorefrescar = True
                Presupuesto_Modificado(Me, e)
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
            Presupuestos.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Previsualizar.Text = "Reporte de ABC de Tipo de Presupuesto"
            Previsualizar.Reporte = Presupuestos.Reporte
            Previsualizar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class