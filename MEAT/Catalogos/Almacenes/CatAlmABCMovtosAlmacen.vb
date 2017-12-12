Imports System.Windows.Forms
Imports ClasesNegocio

Public Class CatAlmABCMovtosAlmacen

    Dim Editar As Boolean = False
    Dim puedorefrescar As Boolean = True
    Dim seleccionado As Boolean = False
    Private WithEvents tmov As New ClasesNegocio.TipoMovimientoAlmacenClass

    Private Sub Txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripcionCorta.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Información a Movimiento", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                TxtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescripcionCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcionCorta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            RbSalida.Focus()
            If TxtDescripcionCorta.Text = "" Then
                MsgBox("Agregue Información a Descripción Corta", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                TxtDescripcionCorta.Focus()
            End If
        End If
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        TxtCodigo.Clear()
        TxtDescripcion.Clear()
        TxtDescripcionCorta.Clear()
        RbEntrada.Checked = True
        RbSalida.Checked = False
        DtpFecha.Value = DateTime.Today
        DtpFecha.Enabled = False
        ChkAfectacion.Checked = False
        lblEstatus.Visible = False
        Editar = False
        seleccionado = False
    End Sub

    Private Sub deshabilitar()
        TxtDescripcion.Enabled = False
        TxtDescripcionCorta.Enabled = False
        RbEntrada.Enabled = False
        RbSalida.Enabled = False
        ChkAfectacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        TxtDescripcion.Enabled = True
        TxtDescripcionCorta.Enabled = True
        RbEntrada.Enabled = True
        RbSalida.Enabled = True
        ChkAfectacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub guardar()
        tmov.Nombre = TxtDescripcion.Text
        tmov.NombreCorto = Me.TxtDescripcionCorta.Text

        If RbEntrada.Checked = True Then
            tmov.Direccion = ClasesNegocio.DireccionEnum.ENTRADAS
        Else
            tmov.Direccion = ClasesNegocio.DireccionEnum.SALIDAS
        End If

        tmov.AfectaCosto = Me.ChkAfectacion.Checked
    End Sub

    Private Function Validar() As Boolean
        Select Case ""
            Case Me.TxtDescripcionCorta.Text
                MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Return False
            Case Me.TxtDescripcion.Text
                MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Return False
        End Select

        Return True
    End Function

#End Region

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Me.seleccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        limpiar()
        Habilitar()
        Me.TxtDescripcion.Focus()
        tmov = New ClasesNegocio.TipoMovimientoAlmacenClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub CatAlmABCMovtosAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "0010100001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        mtb.Buttons(1).Visible = False

        deshabilitar()
        limpiar()
        Me.TipoMovimientoC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        Try
            If tmov.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                Habilitar()
                Editar = True
                Me.TxtDescripcion.Focus()
            Else
                If MessageBox.Show("El Tipo de Movimiendo Inactivo, ¿Desea Activarlo?", "Activar Tipo de Movimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Habilitar()
                    Editar = True
                    Me.TxtDescripcion.Focus()
                    tmov.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblEstatus.Text = tmov.Estatus.ToString
                Else
                    Cancelar = True
                    mtb.sbCambiarEstadoBotones("Guardar")
                    limpiar()
                    deshabilitar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Try
            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If tmov.Guardar Then
                If Editar Then
                    MsgBox("El Movimiento se ha modificado satisfactoriamente.", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                Else
                    MsgBox("El Movimiento se ha guardado satisfactoriamente.", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                End If

                limpiar()
                deshabilitar()
                Me.TipoMovimientoC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
        Previsualizar.Reporte = Me.TipoMovimientoC.Reporte(Controlador.Sesion.MiUsuario.Usrnomcom, Controlador.Sesion.MiEmpresa.Empnom)
        Previsualizar.Text = "Reporte de Tipos de Movimiento de Almacén"
        Previsualizar.ShowDialog()
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar
        If tmov.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If MsgBox("¿ Esta seguro que desea Cancelar este Movimiento de Almacén?", MsgBoxStyle.OkCancel, Controlador.Sesion.MiEmpresa.Empnom) = MsgBoxResult.Ok Then
                If tmov.Borrar Then
                    MsgBox("El Movimiento de Almacén ha sido inactivado\cancelado.", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    deshabilitar()
                    limpiar()
                    Me.TipoMovimientoC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Else
                    Cancelar = True
                End If
            Else
                Cancelar = True
                mtb.sbCambiarEstadoBotones("Guardar")
                limpiar()
                deshabilitar()
            End If
        Else
            MsgBox("El Movimiento de Almacén ya está inactivado.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            limpiar()
            deshabilitar()
        End If
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        'Try
        '    Dim buscar As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.TipoMovimientoClass)

        '    tmov = buscar.ObtenerdeDataGrid(Me.DataGrid)

        '    If tmov Is Nothing Then
        '        MsgBox("No hay elementos seleccionados", MsgBoxStyle.Exclamation, "Aviso")
        '    Else
        '        Me.puedorefrescar = True
        '        Me.tmov_Modificado(sender, e)
        '        Me.puedorefrescar = False
        '        Me.lblEstatus.Visible = True
        '        Me.seleccionado = True
        '        mtb.sbCambiarEstadoBotones("Buscar")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub tmov_Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.puedorefrescar Then
            Me.TxtCodigo.Text = tmov.Codigo
            Me.TxtDescripcion.Text = tmov.Nombre
            Me.TxtDescripcionCorta.Text = tmov.NombreCorto()

            If tmov.Direccion = ClasesNegocio.DireccionEnum.ENTRADAS Then
                Me.RbSalida.Checked = False
                Me.RbEntrada.Checked = True
            Else
                Me.RbSalida.Checked = True
                Me.RbEntrada.Checked = False
            End If

            Me.ChkAfectacion.Checked = tmov.AfectaCosto
            Me.lblEstatus.Text = tmov.Estatus.ToString
        End If
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text.Length > 5 Or e.KeyChar = Chr(13) Then
                Me.TipoMovimientoC.Obtener(Me.txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Sub

    Private Sub DataGrid_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.RowEnter
        Try
            If Me.DataGrid.SelectedRows.Count > 0 Then
                tmov = CType(DataGrid.SelectedRows(0).DataBoundItem, TipoMovimientoAlmacenClass)

                If tmov Is Nothing Then
                    MsgBox("No hay elementos seleccionados", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Else
                    Me.puedorefrescar = True
                    Me.tmov_Modificado(sender, e)
                    Me.puedorefrescar = False
                    Me.lblEstatus.Visible = True
                    Me.seleccionado = True
                    mtb.sbCambiarEstadoBotones("Buscar")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
       
    End Sub
End Class