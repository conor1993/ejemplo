Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmABCmotivosDecomiso
    Dim WithEvents Motivo As New MotivosDecomisoClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Dim cargo As Boolean = False

    Private Sub Motivo_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Motivo.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub motivo_modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Motivo.Modificado
        If puedorefrescar Then
            txtCodigo.Text = Motivo.IdDecomiso
            txtDescripcion.Text = Motivo.Descripcion
            txtDescCorta.Text = Motivo.DescripcionCorta
            lblEstatus.Text = Motivo.Estatus.ToString
            Me.txtObservaciones.Text = Motivo.Observaciones
        End If
    End Sub

#Region "KeyPress"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescCorta.Focus()
            If txtDescripcion.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción . . . ", MsgBoxStyle.Exclamation, "Aviso")
                txtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(32) Then
            e.Handled = True
        End If
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescripcion.Focus()
            If txtDescCorta.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción Corta . . . ", MsgBoxStyle.Exclamation, "Aviso")
                txtDescCorta.Focus()
            End If
        End If
    End Sub
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtObservaciones.Clear()
        Me.txtCodigo.Text = 0
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.lblEstatus.Visible = False
        selesccionado = False
        Me.cmbEstatus.SelectedIndex = 0
        Me.txtDescripcionBusqueda.Clear()
    End Sub

    Private Sub Habilitar()
        Me.txtObservaciones.Enabled = True
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True
        txtDescCorta.Enabled = True
        dgvMotivoDecomiso.Enabled = False
    End Sub

    Private Sub DesHabilitar()
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        txtDescCorta.Enabled = False
        dgvMotivoDecomiso.Enabled = True
        Me.txtObservaciones.Enabled = False
    End Sub

    Private Sub guardar()
        Motivo.Descripcion = Me.txtDescripcion.Text
        Motivo.DescripcionCorta = Me.txtDescCorta.Text
        Motivo.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
        Motivo.Observaciones = Me.txtObservaciones.Text
    End Sub

    Private Sub LlenarMotivosDecomisos()
        Me.dgvMotivoDecomiso.DataSource = Nothing
        Me.MotivosDecomisoC.Obtener(Me.txtDescripcionBusqueda.Text, Me.cmbEstatus.SelectedItem)
        Me.dgvMotivoDecomiso.DataSource = Me.MotivosDecomisoC
    End Sub
#End Region

    Private Sub FrmABCmotivosDecomiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        Me.MEAToolBar1.Buttons(1).Visible = False
        Me.cmbEstatus.DataSource = New ClasesNegocio.CondicionEstatusEnumCollectionClass

        DesHabilitar()
        Limpiar()

        Me.LlenarMotivosDecomisos()
        cargo = True
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.selesccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar

        Try
            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If txtDescripcion.Text = "" Or txtDescCorta.Text = "" Then
                MsgBox("La Descripción y Descripción Corta son Obligatorias, Agregue Información ", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.txtDescripcion.Focus()
                Cancelar = True
            Else
                If Motivo.Guardar Then
                    If Editar Then
                        MsgBox("El motivo de decomiso se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                        'MessageBox.Show("Se guardo motivo decomiso con el codigo : " & Me.txtCodigo.Text, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        'MsgBox("El motivo de decomiso se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                        MessageBox.Show("Se guardo motivo decomiso con el codigo : " & Motivo.IdDecomiso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Me.MotivosDecomisoC.Obtener(CondicionEnum.TODOS)
                    Me.dgvMotivoDecomiso.AutoGenerateColumns = False
                    Me.dgvMotivoDecomiso.DataSource = MotivosDecomisoC
                    Limpiar()
                    DesHabilitar()
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Limpiar()
        Habilitar()
        Motivo = New ClasesNegocio.MotivosDecomisoClass
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Motivo.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            Habilitar()
            Editar = True
            Me.txtDescripcion.Focus()
        Else
            If MessageBox.Show("El motivo de decomiso esta inactivo, ¿Desea activarlo?", "Activar Motivo de decomiso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Motivo.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Text = Motivo.Estatus.ToString
                Habilitar()
                Editar = True
                Me.txtDescripcion.Focus()
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                DesHabilitar()
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        If Motivo.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            If MessageBox.Show("Por favor confirme la cancelacion", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If Motivo.Borrar Then
                    MsgBox("El motivo de decomiso ha sido inactivado.", MsgBoxStyle.Information, "Aviso")
                    Me.MotivosDecomisoC.Obtener(CondicionEnum.TODOS)
                    Me.dgvMotivoDecomiso.AutoGenerateColumns = False
                    Me.dgvMotivoDecomiso.DataSource = MotivosDecomisoC
                    DesHabilitar()
                    Limpiar()
                Else
                    Cancelar = True
                End If
            End If
        Else
            MsgBox("El motivo de decomiso ya esta inactivado.", MsgBoxStyle.Exclamation, "Aviso")
            Limpiar()
            DesHabilitar()
        End If
    End Sub

    Private Sub txtDescripcionBusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionBusqueda.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.LlenarMotivosDecomisos()
        ElseIf Me.txtDescripcionBusqueda.Text.Length >= 3 Then
            Me.LlenarMotivosDecomisos()
        End If
    End Sub

    Private Sub cmbEstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstatus.SelectedIndexChanged
        If cargo Then
            Me.LlenarMotivosDecomisos()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Dim ventana As New ClasesNegocio.PreVisualizarForm

        ventana.Reporte = Me.MotivosDecomisoC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        ventana.Text = "Reporte ABC Movimientos de Decomiso"

        ventana.ShowDialog()
    End Sub


    Private Sub dgvMotivoDecomiso_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMotivoDecomiso.RowEnter
        If Me.dgvMotivoDecomiso.SelectedRows.Count > 0 Then
            Motivo = New ClasesNegocio.MotivosDecomisoClass
            Me.Motivo.Obtener(Me.MotivosDecomisoC(Me.dgvMotivoDecomiso.SelectedRows(0).Index).IdDecomiso)
            motivo_modificado(Me, e)
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.selesccionado = True
            Me.lblEstatus.Visible = True
        End If
    End Sub
End Class