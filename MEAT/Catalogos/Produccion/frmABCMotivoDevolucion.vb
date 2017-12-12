Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmABCMotivoDevolucion

#Region "Miembros"
    Private MotivoDevolucion As New ClasesNegocio.MotivoDevolucionClass
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.txtDescCorta.Clear()
        Me.txtDescripcion.Clear()
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.GroupBox1.Enabled = False
        Me.lblEstatus.Visible = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.GroupBox1.Enabled = True
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub PasarValores()
        Me.motivoDevolucion.Descripcion = Me.txtDescripcion.Text
        Me.motivoDevolucion.DescripcionCorta = Me.txtDescCorta.Text
        Me.motivoDevolucion.Entidad.IdUsuarioAlta = Controlador.Sesion.Usrndx
    End Sub

    Private Sub ObtenerValores()
        Me.txtDescripcion.Text = Me.motivoDevolucion.Descripcion
        Me.txtDescCorta.Text = Me.motivoDevolucion.DescripcionCorta
        Me.txtCodigo.Text = Me.motivoDevolucion.IdMotivoDevolucion
        Me.lblEstatus.Text = Me.motivoDevolucion.Estatus.ToString
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub frmABCMotivoDevolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
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

            Me.MotivoDevolucionC.Obtener()
            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor

        Try
            If Me.motivoDevolucion.Borrar(Nothing) Then
                MsgBox("El motivo de devolución a sido cancelado", MsgBoxStyle.Information, "Aviso")
                Deshabilitar()
                Limpiar()
                Me.MotivoDevolucionC.Obtener()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBuscar

    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        If motivoDevolucion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Me.txtDescripcion.Focus()
        Else
            If MessageBox.Show("El motivo de devolución esta INACTIVO, ¿Quiere ACTIVARLO", "ACTIVAR Motivo de Devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Habilitar()
                Me.motivoDevolucion.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.txtDescripcion.Focus()
                Me.ObtenerValores()
            Else
                Cancelar = True
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            Me.PasarValores()

            If Me.motivoDevolucion.Guardar(Nothing) Then
                MsgBox("El motivo de devolución a sido guardado", MsgBoxStyle.Information, "Aviso")
                Limpiar()
                Deshabilitar()
                Me.MotivoDevolucionC.Obtener()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Controlador.ReporteMotivoDevolucion()
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Cursor = Cursors.WaitCursor

        Try
            Me.motivoDevolucion = New ClasesNegocio.MotivoDevolucionClass
            Habilitar()
            Me.txtDescripcion.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgvMotivoDecomiso_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMotivoDecomiso.CellClick
        Cursor = Cursors.WaitCursor

        Try
            If e.RowIndex > -1 Then
                Me.motivoDevolucion = New ClasesNegocio.MotivoDevolucionClass

                Me.motivoDevolucion.Obtener(Me.MotivoDevolucionC(e.RowIndex).IdMotivoDevolucion)
                Me.ObtenerValores()
                MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
#End Region
#End Region
End Class