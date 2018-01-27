Imports CN = ClasesNegocio

Public Class FrmABCServicios
    Dim Servicio As CN.ServiciosClass

    Private Sub FrmABCServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            Me.MEAToolBar1.ToolBarButtonStatus = MtbEstados

            Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
            Me.MEAToolBar1.Buttons(1).Visible = False

            Limpiar()
            DesHabilitar()
            Me.ServiciosC.Obtener()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.txtDescFiltro.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtCosto.Text = ""
        Me.Dtpfecha.Value = Now
        Me.lblEstatus.Visible = False
        Me.rbtnProduccion.Checked = True
    End Sub

    Private Sub Habilitar()
        Me.txtDescripcion.ReadOnly = False
        Me.GrpTipoServ.Enabled = True
        Me.txtCosto.ReadOnly = False

    End Sub

    Private Sub DesHabilitar()
        Me.txtDescripcion.ReadOnly = True
        Me.GrpTipoServ.Enabled = False
        Me.txtCosto.ReadOnly = True

    End Sub

    Private Sub Imprimir()

        Dim VerReporte As New FrmReportes
        VerReporte.CRV.ReportSource = Me.ServiciosC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        VerReporte.Show()
    End Sub
#End Region

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Try
            If Servicio.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar el Servicio, ya fue cancelado por otro usuario", MsgBoxStyle.Critical, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Servicio.Estatus = ClasesNegocio.EstatusDatos.CANCELADO
                If Servicio.Borrar Then
                    MsgBox("El servicio ha sido cancelado", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    DesHabilitar()
                    Me.ServiciosC.Obtener()
                Else
                    Cancelar = True
                    Exit Sub
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        If Servicio.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
            If MessageBox.Show("El Servicio se encuentra cancelado, para editarlo es necesario activarlo, ¿Desea activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Servicio.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Habilitar()
            Else
                Cancelar = True
                Exit Sub
            End If
        End If
        Habilitar()
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            If Me.txtDescripcion.Text = "" Then
                MsgBox("Ingrese la descripción del Servicio", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtDescripcion.Focus()
                Cancelar = True
                Exit Sub
            End If

            If Me.txtCosto.Text = "" Then
                MsgBox("Ingrese el costo del servicio", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtCosto.Focus()
                Cancelar = True
                Exit Sub
            End If

            Servicio.Descripcion = Trim(Me.txtDescripcion.Text)
            Servicio.Costo = Trim(Me.txtCosto.Text)


            If Me.rbtnProduccion.Checked Then
                Servicio.TipoServicio = ClasesNegocio.TipoServicionEnum.PRODUCCION
            Else
                Servicio.TipoServicio = ClasesNegocio.TipoServicionEnum.EMBARQUE
            End If

            If Servicio.Guardar() Then
                MsgBox("Se ha guardado el Servicio con el código: " & Servicio.Codigo, MsgBoxStyle.Information, "Aviso")
                Limpiar()
                DesHabilitar()
                Me.ServiciosC.Obtener()
                Exit Sub
            End If

            Cancelar = True
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Imprimir()
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Limpiar()
        Habilitar()
        Me.txtDescripcion.Focus()
        Me.Servicio = New CN.ServiciosClass
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Sub dgvServicios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvServicios.Click
        Try
            If Me.dgvServicios.SelectedRows.Count > 0 Then
                Me.Servicio = DirectCast(Me.dgvServicios.SelectedRows(0).DataBoundItem, CN.ServiciosClass)

                DesHabilitar()
                Me.txtCodigo.Text = Servicio.Codigo
                Me.txtDescripcion.Text = Servicio.Descripcion
                Me.Dtpfecha.Value = Servicio.FechaAlta
                Me.lblEstatus.Text = Servicio.Estatus.ToString
                Me.lblEstatus.Visible = True
                If Servicio.TipoServicio = ClasesNegocio.TipoServicionEnum.PRODUCCION Then
                    Me.rbtnProduccion.Checked = True
                Else
                    Me.rbtnEmbarque.Checked = True
                End If

                Me.MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtDescFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescFiltro.KeyPress
        If Me.txtDescFiltro.Text.Length > 4 Or e.KeyChar = Chr(13) Then
            Me.ServiciosC.Obtener(Me.txtDescFiltro.Text)
        End If
    End Sub

    Private Sub dgvServicios_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvServicios.DataError

    End Sub

    Private Sub dgvServicios_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicios.RowEnter
        Try
            If Me.dgvServicios.SelectedRows.Count > 0 Then
                Me.Servicio = DirectCast(Me.dgvServicios.SelectedRows(0).DataBoundItem, CN.ServiciosClass)

                DesHabilitar()
                Me.txtCodigo.Text = Servicio.Codigo
                Me.txtDescripcion.Text = Servicio.Descripcion
                Me.Dtpfecha.Value = Servicio.FechaAlta
                Me.lblEstatus.Text = Servicio.Estatus.ToString
                Me.lblEstatus.Visible = True
                If Servicio.TipoServicio = ClasesNegocio.TipoServicionEnum.PRODUCCION Then
                    Me.rbtnProduccion.Checked = True
                Else
                    Me.rbtnEmbarque.Checked = True
                End If

                Me.MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCosto.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True


        End If
    End Sub
End Class