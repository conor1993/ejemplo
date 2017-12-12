Public Class CompCatMarcas

    Dim WithEvents Marca As ClasesNegocio.MarcaClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.MarcaClass)

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
            TxtObservacion.Focus()
            If TxtDescCorta.Text = "" Then
                MsgBox("Agregue Información a Descripción Corta ", MsgBoxStyle.Exclamation, "Faltan Datos")
                TxtDescCorta.Focus()
            End If
        End If
        If e.KeyChar = Chr(32) Then
            e.Handled = True
        End If
    End Sub

#Region "METODOS"

    Private Sub limpiar()
        Txtcodigo.Clear()
        TxtDescripción.Clear()
        TxtDescCorta.Clear()
        TxtObservacion.Clear()
        LblEstatus.Text = "ESTATUS"
        TxtDescripción.Focus()
        selesccionado = False
        Editar = False
        Me.LblEstatus.Visible = False
    End Sub

    Private Sub deshabilitar()
        TxtDescripción.Enabled = False
        TxtDescCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub habilitar()
        TxtDescripción.Enabled = True
        TxtDescCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub guardar()
        Marca.Nombre = TxtDescripción.Text
        Marca.NombreCorto = TxtDescCorta.Text
        Marca.Observacion = TxtObservacion.Text
    End Sub

    Private Function Validar() As Boolean
        If Me.TxtDescripción.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Return False
        End If

        If Me.TxtDescCorta.Text = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
            Return False
        End If

        Return True
    End Function

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaMarcaXEstatus"
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
            ClmEstatus.DataPropertyName = "Estatus"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            com.Connection.Close()
        End Try
    End Sub

#End Region

    Private Sub Marca_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Marca.Modificado
        If puedorefrescar Then
            Txtcodigo.Text = CStr(Marca.Codigo)
            TxtDescripción.Text = Marca.Nombre
            TxtDescCorta.Text = Marca.NombreCorto
            TxtObservacion.Text = Marca.Observacion
            LblEstatus.Text = Marca.Estatus.ToString
        End If
    End Sub

    Private Sub Marca_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Marca.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub CompCatMarcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100001"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        LlenarGrid()
        deshabilitar()
        limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        deshabilitar()
        limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.selesccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        Cursor = Cursors.WaitCursor
        If Marca.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            habilitar()
            Editar = True
            Me.TxtDescripción.Focus()
        Else
            If MessageBox.Show("La Marca esta inactiva, ¿Desea Activarla?", "Activar Marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Marca.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.LblEstatus.Text = Marca.Estatus.ToString
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
        Cursor = Cursors.Default
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

            If Marca.Guardar Then
                If Editar Then
                    MsgBox("La Marca se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Marca se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
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
            If Marca.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If Marca.Borrar Then
                    MsgBox("La Marca ha sido Inactivada.", MsgBoxStyle.Information, "Aviso")
                    deshabilitar()
                    limpiar()
                    LlenarGrid()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("La Marca ya esta Inactivada.", MsgBoxStyle.Exclamation, "Aviso")
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
        Marca = New ClasesNegocio.MarcaClass()
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Cursor = Cursors.WaitCursor
        Try
            If DataGrid.SelectedRows.Count > 0 Then
                Marca = New ClasesNegocio.MarcaClass
                Marca.Obtener(CInt(DataGrid.SelectedRows(0).Cells(0).Value))

                puedorefrescar = True
                Marca_Modificado(Me, e)
                puedorefrescar = False

                MEAToolBar1.sbCambiarEstadoBotones("Buscar")
                Me.selesccionado = True
                Me.LblEstatus.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            MarcaC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Previsualizar.Text = "Reporte de Marcas"
            Previsualizar.Reporte = MarcaC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            Previsualizar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class