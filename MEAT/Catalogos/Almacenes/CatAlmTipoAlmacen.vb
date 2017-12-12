Imports System.Windows.Forms

Public Class CatAlmTipoAlmacen

    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim WithEvents TAlmacen As ClasesNegocio.TipoAlmacenClass
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.TipoAlmacenClass)

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(CType(sender, Control), True, True, False, True)
            TxtDescripcion.Focus()
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(CType(sender, Control), True, True, False, True)
            TxtDescripcionCorta.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Información a Descripción", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                TxtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescripcionCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcionCorta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(CType(sender, Control), True, True, False, True)
            ChckSubalmacen.Focus()
            If TxtDescripcionCorta.Text = "" Then
                MsgBox("Agregue Información a Descripción Corta", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                TxtDescripcion.Focus()
            End If
        End If
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        Me.chkProduccion.Checked = False
        TxtCodigo.Clear()
        DtpFecha.Value = Now
        TxtDescripcion.Clear()
        TxtDescripcionCorta.Clear()
        ChckSubalmacen.Checked = False
        lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        Editar = False
        Me.TxtDescripcion.Focus()
    End Sub

    Private Sub deshabilitar()
        Me.chkProduccion.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescripcionCorta.Enabled = False
        ChckSubalmacen.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        Me.chkProduccion.Enabled = True
        TxtDescripcion.Enabled = True
        TxtDescripcionCorta.Enabled = True
        ChckSubalmacen.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub Guardar()
        TAlmacen.Descripcion = TxtDescripcion.Text
        TAlmacen.DescripcionCorta = TxtDescripcionCorta.Text
        TAlmacen.SubAlmacen = CType(IIf(ChckSubalmacen.Checked, ClasesNegocio.TipoAlmacenEnum.SUBALMACEN, ClasesNegocio.TipoAlmacenEnum.ALMACEN), ClasesNegocio.TipoAlmacenEnum)
        Me.TAlmacen.DeProduccion = Me.chkProduccion.Checked
    End Sub

#End Region

    Private Sub Talmacen_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles TAlmacen.Modificado
        If puedorefrescar Then
            TxtCodigo.Text = TAlmacen.Codigo.ToString
            TxtDescripcion.Text = TAlmacen.Descripcion
            TxtDescripcionCorta.Text = TAlmacen.DescripcionCorta
            lblEstatus.Text = TAlmacen.Estatus.ToString
            ChckSubalmacen.Checked = CType(IIf(TAlmacen.SubAlmacen = ClasesNegocio.TipoAlmacenEnum.ALMACEN, False, True), Boolean)
            Me.chkProduccion.Checked = Me.TAlmacen.DeProduccion
        End If
    End Sub

    Private Sub tipoalmacen_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles TAlmacen.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
    End Sub

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
        TAlmacen = New ClasesNegocio.TipoAlmacenClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub CatAlmTipoAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
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
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        deshabilitar()

        Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        If TAlmacen.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            Habilitar()
            Editar = True
        Else

            If MsgBox("Tipo de Almacen esta inactivo, ¿Desea Activarlo?", MsgBoxStyle.OkCancel, Controlador.Sesion.MiEmpresa.Empnom) = MsgBoxResult.Ok Then
                Me.TAlmacen.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Text = TAlmacen.Estatus.ToString
                Habilitar()
                Me.TxtDescripcion.Focus()
            Else
                Cancelar = True
                mtb.sbCambiarEstadoBotones("Guardar")
                limpiar()
                deshabilitar()
            End If
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Try
            puedorefrescar = False
            Guardar()
            puedorefrescar = True

            If TxtDescripcion.Text = "" Or TxtDescripcionCorta.Text = "" Then
                MsgBox("La Descripción y Descripción Corta es Obligatoria Agregue Información ", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Cancelar = True
            Else
                If TAlmacen.Guardar Then
                    If Editar Then
                        MsgBox("El Tipo de Almacen se ha modificado satisfactoriamente.", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    Else
                        MsgBox("El Tipo de Almacen se ha guardado satisfactoriamente.", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    End If
                    limpiar()
                    deshabilitar()
                    Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Else
                    Cancelar = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar

        If TAlmacen.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If MsgBox("¿ Esta seguro que desea Cancelar este tipo de Almacén?", MsgBoxStyle.OkCancel, Controlador.Sesion.MiEmpresa.Empnom) = MsgBoxResult.Ok Then
                If TAlmacen.Borrar Then
                    MsgBox("El Tipo de Almacen ha sido Inactivado/Cancelado.", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    deshabilitar()
                    limpiar()
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
            MsgBox("El Tipo de Almacen ya ha sido Inactivado.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            limpiar()
            deshabilitar()
        End If
    End Sub

    Private Sub tipoalmacen_modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles TAlmacen.modificado
        If puedorefrescar Then
            TxtCodigo.Text = TAlmacen.Codigo.ToString
            TxtDescripcion.Text = TAlmacen.Descripcion
            TxtDescripcionCorta.Text = TAlmacen.DescripcionCorta
            lblEstatus.Text = TAlmacen.Estatus.ToString
        End If
    End Sub

    Private Sub DataGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.Click
        'TAlmacen = Busqueda.ObtenerdeDataGrid(DataGrid)
        'If Not IsNothing(TAlmacen) Then
        '    Talmacen_Modificado(Me, e)
        '    mtb.sbCambiarEstadoBotones("Buscar")
        '    Me.seleccionado = True
        '    Me.lblEstatus.Visible = True
        'Else
        '    MsgBox("No selecciono un elemento valido.", MsgBoxStyle.Exclamation, "Aviso")
        'End If
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        'TAlmacen = Busqueda.ObtenerdeDataGrid(DataGrid)
        'If Not IsNothing(TAlmacen) Then
        '    Talmacen_Modificado(Me, e)
        '    mtb.sbCambiarEstadoBotones("Buscar")
        '    Me.seleccionado = True
        '    Me.lblEstatus.Visible = True
        'Else
        '    MsgBox("No selecciono un elemento valido.", MsgBoxStyle.Exclamation, "Aviso")
        'End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
        Previsualizar.Reporte = TipoAlmacenC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        Previsualizar.ShowDialog()
    End Sub

    Private Sub DataGrid_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.RowEnter
        If Me.DataGrid.SelectedRows.Count > 0 Then
            TAlmacen = Busqueda.ObtenerdeDataGrid(DataGrid)
            If Not IsNothing(TAlmacen) Then
                Talmacen_Modificado(Me, e)
                mtb.sbCambiarEstadoBotones("Buscar")
                Me.seleccionado = True
                Me.lblEstatus.Visible = True
            Else
                MsgBox("No selecciono un elemento valido.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            End If
        End If
    End Sub
End Class