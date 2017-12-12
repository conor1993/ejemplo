Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Class BcoCatBancos

    Dim WithEvents Banco As ClasesNegocio.BancosClass
    Dim WithEvents BancoCol As New ClasesNegocio.BancosCollectionClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.BancosClass)

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescCorta.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Información a Descripción ")
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
                MsgBox("Agregue Información a Descripción Corta ")
                TxtDescCorta.Focus()
            End If
        End If
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

#Region "METODOS"
    Private Sub LIMPIAR()
        TxtCodigo.Clear()
        TxtDescripcion.Clear()
        TxtDescCorta.Clear()
        TxtObservacion.Clear()
        lblEstatus.Visible = False
        Me.txtFiltro.Text = ""
        selesccionado = False
    End Sub

    Private Sub HABILITAR()
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = True
        TxtDescCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub DESHABILITAR()
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub GUARDAR()
        Banco.Descripcion = TxtDescripcion.Text
        Banco.DescripcionCta = TxtDescCorta.Text
        Banco.Observaciones = TxtObservacion.Text
    End Sub
#End Region

    Private Sub Banco_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Banco.Modificado
        If puedorefrescar Then
            TxtCodigo.Text = Banco.Codigo
            TxtDescripcion.Text = Banco.Descripcion
            TxtDescCorta.Text = Banco.DescripcionCta
            TxtObservacion.Text = Banco.Observaciones
            lblEstatus.Text = Banco.Estatus.ToString
            Me.lblEstatus.Visible = True
        End If
    End Sub

    Private Sub Banco_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Banco.MensajeError
        MessageBox.Show(mensaje)
        Select Case sender.ToString
            Case "Descripcion"
                Me.TxtDescripcion.Focus()
            Case "DescripcionCta"
                Me.TxtDescCorta.Focus()
        End Select
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Try
            If Banco.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If Banco.Borrar Then
                    MessageBox.Show("El Banco ha sido Inactivado.")
                    DESHABILITAR()
                    LIMPIAR()
                    BancoCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Else
                    Cancelar = True
                End If
            Else
                MessageBox.Show("El Banco ya esta Inactivado.")
                LIMPIAR()
                DESHABILITAR()
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        LIMPIAR()
        DESHABILITAR()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Banco.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            HABILITAR()
            Editar = True
        Else
            If MessageBox.Show("El Banco no se puede editar, se encuentra inactivo, ¿Desea activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Banco.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Editar = True
                HABILITAR()
            Else
                Editar = False
                Cancelar = True
                LIMPIAR()
                DESHABILITAR()
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            puedorefrescar = False
            GUARDAR()
            puedorefrescar = True
            If TxtDescripcion.Text = "" Or TxtDescCorta.Text = "" Then
                MessageBox.Show("La Descripción y Descripción Corta es Obligatoria Agregue Información ")
                Cancelar = True
            Else
                If Banco.Guardar Then
                    MessageBox.Show("El Banco se ha guardado satisfactoriamente.")
                    LIMPIAR()
                    DESHABILITAR()
                    BancoCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
        Previsualizar.Reporte = BancoCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        Previsualizar.ShowDialog()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        LIMPIAR()
        HABILITAR()
        Editar = False
        Banco = New ClasesNegocio.BancosClass()
        Me.TxtDescripcion.Focus()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub BcoCatBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        MEAToolBar1.Buttons(1).Visible = False
        DESHABILITAR()
        'Obtener registros existentes
        Me.BancoCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = Me.BancoCol
        '
        CodigoColumn.DataPropertyName = "codigo"
        DescripcionColumn.DataPropertyName = "Descripcion"
        DescripcionCtaColumn.DataPropertyName = "Descripcioncta"
        ObservacionColumn.DataPropertyName = "Observaciones"
        EstatusColumn.DataPropertyName = "Estatus"

        LIMPIAR()
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Banco = Busqueda.ObtenerdeDataGrid(DataGrid)
        If Not IsNothing(Banco) Then
            Banco_Modificado(Me, e)
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.selesccionado = True
        Else
            Windows.Forms.MessageBox.Show("No selecciono un elemento valido.")
        End If
    End Sub


    Private Sub txtFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text.Length > 4 Or e.KeyChar = Chr(13) Then
                Me.BancoCol.Obtener(Me.txtFiltro.Text)
                DataGrid.AutoGenerateColumns = False
                DataGrid.DataSource = Me.BancoCol
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class