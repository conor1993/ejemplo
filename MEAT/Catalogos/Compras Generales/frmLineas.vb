Public Class frmLineas

    Private Editar As Boolean = False
    Private selecciono As Boolean
    Private WithEvents Linea As ClasesNegocio.LineaClass
    Private Lineas As New ClasesNegocio.LineaCollectionClass()
    Private PuedoRefrescar As Boolean = True
    Private Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.LineaClass)

    Private Sub limpiar()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtDescCorta.Clear()
        txtObservaciones.Clear()
        dtpFecha.Value = DateTime.Today
        lblEstatus.Text = "ESTATUS"
        selecciono = False
        Editar = False
        Me.lblEstatus.Visible = False
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub deshabilitar()
        txtDescripcion.Enabled = False
        txtDescCorta.Enabled = False
        txtObservaciones.Enabled = False
        dgvLineasReg.Enabled = True
    End Sub

    Private Sub habilitar()
        txtDescripcion.Focus()
        txtDescripcion.Enabled = True
        txtDescCorta.Enabled = True
        txtObservaciones.Enabled = True
        dgvLineasReg.Enabled = False
    End Sub

    Private Sub guardar()
        Linea.Descripcion = txtDescripcion.Text
        Linea.FechaAlta = dtpFecha.Value
        Linea.DescripcionCorta = txtDescCorta.Text
        Linea.Observaciones = txtObservaciones.Text
    End Sub

    Private Function Validar() As Boolean
        If Me.txtDescripcion.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Return False
        End If

        If Me.txtDescCorta.Text = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
            Return False
        End If

        Return True
    End Function

    Private Sub LlenarGrid()
        Try
            Me.dgvLineasReg.AutoGenerateColumns = False
            Me.dgvLineasReg.DataSource = Controlador.ObtenerLineas(ClasesNegocio.CondicionEnum.TODOS)
            ClmCodigo.DataPropertyName = "Codigo"
            ClmDescripcion.DataPropertyName = "Descripcion"
            ClmDescripcionCorta.DataPropertyName = "DescripcionCorta"
            ClmObservaciones.DataPropertyName = "Observaciones"
            ClmFechaAlta.DataPropertyName = "FechaAlta"
            ClmEstatus.DataPropertyName = "Estatus"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Sub

    Private Sub frmLineas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure()
        mtbEstados.StateBuscar = "110101111"
        mtbEstados.StateLimpiar = "100100011"
        mtbEstados.StateCancelar = "100100011"
        mtbEstados.StateNuevo = "011010001"
        mtbEstados.StateGuardar = "100100011"
        mtbEstados.StateBorrar = "100100011"
        mtbEstados.StateEditar = "001010001"
        mtbEstados.StateImprimir = ""
        mtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = mtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        LlenarGrid()
        limpiar()
        deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        Try
            If Linea.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                MsgBox("La Familia ya esta inactiva", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Linea.Borrar Then
                MsgBox("La Familia se a dado de baja exitosamente", MsgBoxStyle.Information, "Aviso")
                limpiar()
                deshabilitar()
                LlenarGrid()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        Cursor = Cursors.WaitCursor
        If Linea.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            habilitar()
            Editar = True
            Me.txtDescripcion.Focus()
        Else
            If MessageBox.Show("La Familia esta inactiva, ¿Desea Activarla?", "Activar Familia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Linea.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Text = Linea.Estatus.ToString
                Editar = True
                Me.txtDescripcion.Focus()
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                limpiar()
                deshabilitar()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try
            If Not Validar() Then
                Cancelar = True
                Cursor = Cursors.Default
                Exit Sub
            End If

            Me.PuedoRefrescar = False
            guardar()
            Me.PuedoRefrescar = True

            If Linea.Guardar Then
                If Editar Then
                    MsgBox("La Familia se a modificado exitosamente", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Familia se a guardado exitosamente", MsgBoxStyle.Information, "Aviso")
                End If

                limpiar()
                deshabilitar()
                LlenarGrid()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            LineaC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim Reporte As New ClasesNegocio.rptABCLineas
            Dim VerReporte As New FrmReportes
            Reporte.SetDataSource(LineaC)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(2, "Catalogos\Compras Generales\Familias")
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        If selecciono Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        habilitar()
        limpiar()
        Linea = New ClasesNegocio.LineaClass
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub dgvLineasReg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLineasReg.DoubleClick
        Cursor = Cursors.WaitCursor
        Try
            If Me.dgvLineasReg.SelectedRows.Count > 0 Then
                Linea = New ClasesNegocio.LineaClass
                Linea.Obtener(Me.dgvLineasReg.SelectedRows(0).Cells(0).Value)
                Me.PuedoRefrescar = True
                Me.Linea_Modificado(Me, e)
                Me.PuedoRefrescar = False
                MEAToolBar1.sbCambiarEstadoBotones("Buscar")
                selecciono = True
                Me.lblEstatus.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errro")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Linea_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Linea.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Information, "Aviso")

        Select Case sender.ToString
            Case "Descripcion"
                Me.txtDescripcion.Focus()
            Case "DescripcionCorta"
                Me.txtDescCorta.Focus()
        End Select
    End Sub

    Private Sub Linea_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Linea.Modificado
        If Me.PuedoRefrescar Then
            Me.txtCodigo.Text = Linea.Codigo
            Me.txtDescripcion.Text = Linea.Descripcion
            Me.txtDescCorta.Text = Linea.DescripcionCorta
            Me.txtObservaciones.Text = Linea.Observaciones
            Me.lblEstatus.Text = Linea.Estatus.ToString
        End If
    End Sub

End Class