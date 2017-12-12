Imports HC = Integralab.ORM.HelperClasses
Imports ClasesNegocio

Public Class BcoCatTipoMoneda

    Dim WithEvents Moneda As ClasesNegocio.TipoMonedaClass
    Dim WithEvents Monedas As New ClasesNegocio.TipoMonedaCollectionClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripcion.Focus()
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescCorta.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Información a la Descripción")
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
                MsgBox("Agregue Información a la Descripción Corta")
                TxtDescCorta.Focus()
            End If
        End If
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtObservacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtObservacion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            ChkEsMonedaLocal.Focus()
        End If
    End Sub

#Region "metodos"

    Private Sub limpiar()
        TxtCodigo.Clear()
        DtpFecha.Value = Now
        TxtDescripcion.Clear()
        TxtDescCorta.Clear()
        ChkEsMonedaLocal.Checked = False
        TxtObservacion.Clear()
        lblEstatus.Text = "ESTATUS"
        selesccionado = False
    End Sub

    Private Sub deshabilitar()
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescCorta.Enabled = False
        ChkEsMonedaLocal.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub habilitar()
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = True
        TxtDescCorta.Enabled = True
        ChkEsMonedaLocal.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub guardar()
        Moneda.Descripcion = TxtDescripcion.Text
        Moneda.DescripcionCorta = TxtDescCorta.Text
        Moneda.Observacion = TxtObservacion.Text
        Moneda.EsMonedaLocal = ChkEsMonedaLocal.Checked
    End Sub

#End Region

    Private Sub MEAToolBar_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub MEAToolBar_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        habilitar()
        Editar = True
    End Sub

    Private Sub MEAToolBar_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Moneda")
        Dim Mensaje As String = "El Tipo de Moneda se Guardara, ¿Esta seguro?"

        Try
            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If TxtDescripcion.Text = "" Or TxtDescCorta.Text = "" Then
                MessageBox.Show("La Descripción y Descripción Corta es Obligatoria Agregue Información ")
                Cancelar = True
            Else
                If Not Moneda.Entidad.IsNew Then
                    Mensaje = "El Tipo de Moneda se Modificara, ¿Esta seguro?"
                End If

                If MessageBox.Show(Mensaje, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Cancelar = True
                    Exit Sub
                End If

                If Not Moneda.Entidad.IsNew AndAlso Moneda.Estatus = EstatusEnum.INACTIVO Then
                    If MessageBox.Show("El Tipo de Moneda esta Inactiva, Se activara, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Moneda.Estatus = EstatusEnum.ACTIVO
                    Else
                        Cancelar = True
                        Exit Sub
                    End If
                End If

                If Moneda.Guardar(Trans) Then
                    Trans.Commit()
                    MessageBox.Show("El Tipo de Moneda se ha Guardado Satisfactoriamente.")
                    limpiar()
                    deshabilitar()
                    Me.Monedas.Obtener()
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Me.selesccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        limpiar()
        habilitar()
        Editar = False
        Moneda = New ClasesNegocio.TipoMonedaClass()
    End Sub

    Private Sub MEAToolBar_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Moneda")

        If Moneda.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If Moneda.Borrar(Trans) Then
                Trans.Commit()
                MessageBox.Show("El Tipo de Moneda ha sido Inactivado.")
                deshabilitar()
                limpiar()
                Monedas.Obtener()
            Else
                Cancelar = True
            End If
            limpiar()
        Else
            Trans.Rollback()
            MessageBox.Show("El Tipo de Moneda ya esta Inactivada.")
            limpiar()
            deshabilitar()
        End If
    End Sub

    Private Sub BcoCatTipoMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        mtb.Buttons(1).Visible = False

        deshabilitar()
        'Obtener Datos Existentes
        Me.Monedas.Obtener()
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = Me.Monedas

        'Agrega datos al grid
        CodigoColumn.DataPropertyName = "Codigo"
        DescripcionColumn.DataPropertyName = "Descripcion"
        DescripcionCtaColumn.DataPropertyName = "Descripcioncorta"
        ObservacionColumn.DataPropertyName = "Observacion"
        clmMonedaLocal.DataPropertyName = "MonedaLocal"
        FechaColumn.DataPropertyName = "Fecha"
        EstatusColumn.DataPropertyName = "Estatus"
        limpiar()
    End Sub

    Private Sub Moneda_modificado(ByVal sender As Object, ByVal e As System.EventArgs)
        If puedorefrescar Then
            TxtCodigo.Text = Moneda.Codigo.ToString
            TxtDescripcion.Text = Moneda.Descripcion
            TxtDescCorta.Text = Moneda.DescripcionCorta
            DtpFecha.Value = Moneda.Fecha
            ChkEsMonedaLocal.Checked = Moneda.EsMonedaLocal
            TxtObservacion.Text = Moneda.Observacion
            lblEstatus.Text = Moneda.Estatus.ToString
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        'Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
        'Previsualizar.Reporte = Monedas.Reporte
        'Previsualizar.ShowDialog()
        Cursor = Cursors.WaitCursor
        Try
            Monedas.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If Monedas.Count.ToString > 0 Then
                Dim Reporte As New ClasesNegocio.CRepTipoMoneda
                Dim VerReporte As New FrmReportes
                Reporte.SetDataSource(Monedas)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Generales\Tipo de Moneda")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Tipo de Moneda", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        If e.RowIndex > -1 Then
            Moneda = CType(DataGrid.Rows(e.RowIndex).DataBoundItem, TipoMonedaClass)

            Moneda_modificado(Me, e)
            mtb.sbCambiarEstadoBotones("Buscar")
            Me.selesccionado = True
        Else
            MessageBox.Show("No selecciono un elemento valido.", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class