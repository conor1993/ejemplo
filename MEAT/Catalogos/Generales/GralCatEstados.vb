Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class GralCatEstados

    Dim WithEvents Estado As ClasesNegocio.EstadoClass
    Dim WithEvents Ciudad As New ClasesNegocio.CiudadClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.EstadoClass)
    Dim selesccionado As Boolean = False

#Region "metodos"

    Private Sub limpiar()
        Me.txtCodigo.Text = ""
        Me.txtDescripción.Text = ""
        Me.txtDescCorta.Text = ""
        Me.TxtObservacion.Text = ""
        lblEstatus.Text = "ESTATUS"
        selesccionado = False
        Me.lblEstatus.Visible = False
        Editar = False
        Me.txtDescripción.Focus()
    End Sub

    Private Sub Deshabilitar()
        txtCodigo.Enabled = False
        txtDescripción.Enabled = False
        txtDescCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        txtCodigo.Enabled = False
        txtDescripción.Enabled = True
        txtDescCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub Guardar()
        Estado.Descripcion = txtDescripción.Text
        Estado.DescripcionCorta = txtDescCorta.Text
        Estado.Observaciones = TxtObservacion.Text
    End Sub

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaEstadosXEstatus"
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@Estatus", SqlDbType.SmallInt).Value = ClasesNegocio.CondicionEnum.TODOS
            com.Connection = New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

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

    Private Sub txtDescripción_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripción.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescCorta.Focus()
            If txtDescripción.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción . . . ", MsgBoxStyle.Exclamation, "Aviso")
                txtDescripción.Focus()
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
                MsgBox("Agregue Informacion a la Descripción Corta . . . ", MsgBoxStyle.Exclamation, "Aviso")
                txtDescCorta.Focus()
            End If
        End If
    End Sub

    Private Sub TxtObservacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObservacion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtCodigo.Focus()
            If TxtObservacion.Text = "" Then
                MsgBox("Agregue Informacion a la Observación. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtObservacion.Focus()
            End If
        End If
    End Sub

    Private Sub estado_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Estado.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub estado_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Estado.Modificado
        If puedorefrescar Then
            txtCodigo.Text = Estado.Codigo
            txtDescripción.Text = Estado.Descripcion
            txtDescCorta.Text = Estado.DescripcionCorta
            TxtObservacion.Text = Estado.Observaciones
            lblEstatus.Text = Estado.Estatus.ToString
        End If
    End Sub

    Private Sub GralCatEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        LlenarGrid()
        Deshabilitar()
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

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        limpiar()
        Habilitar()
        Estado = New ClasesNegocio.EstadoClass()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try
            puedorefrescar = False
            Guardar()
            puedorefrescar = True

            If txtDescripción.Text = "" Or txtDescCorta.Text = "" Then
                MsgBox("La Descripción y Descripción Corta es Obligatoria Agregue Información ", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.txtDescripción.Focus()
                Cancelar = True
            Else
                If Estado.Guardar Then
                    If Editar Then
                        MsgBox("El Estado se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                    Else
                        MsgBox("El Estado se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                    End If

                    limpiar()
                    Deshabilitar()
                    LlenarGrid()
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Estado.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Editar = True
            Me.txtDescripción.Focus()
        Else
            If MessageBox.Show("El Estado esta inactivo, ¿Desea activarlo?", "Activar Estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Estado.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Text = Estado.Estatus.ToString
                Habilitar()
                Editar = True
                Me.txtDescripción.Focus()
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                limpiar()
                Deshabilitar()
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        If Estado.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If Estado.Borrar Then
                MsgBox("El Estado ha sido inactivado.", MsgBoxStyle.Information, "Aviso")
                Deshabilitar()
                limpiar()
                LlenarGrid()
            Else
                Cancelar = True
            End If
        Else
            MsgBox("El Estado ya esta inactivado.", MsgBoxStyle.Exclamation, "Aviso")
            limpiar()
            Deshabilitar()
        End If
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        If Me.DataGrid.SelectedRows.Count > 0 Then
            Estado = New ClasesNegocio.EstadoClass
            Estado.Obtener(DataGrid.SelectedRows(0).Cells(0).Value)
            estado_Modificado(Me, e)
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.selesccionado = True
            Me.lblEstatus.Visible = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Cursor = Cursors.WaitCursor
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Dim Estados As New ClasesNegocio.EstadoCollectionClass
            Previsualizar.Text = "Reporte de Estados"

            Estados.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If Estados.Count > 0 Then
                Previsualizar.Reporte = Estados.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                Previsualizar.ShowDialog()
            Else
                MsgBox("No se enconto ningun Estado", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class