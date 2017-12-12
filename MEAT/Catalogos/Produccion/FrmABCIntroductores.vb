Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Public Class FrmABCIntroductores
    Dim Introductor As New CatIntroductoresClass

    Private Sub FrmABCIntroductores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.IntroductorC.Obtener()

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")


            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub
#Region "KeyPress"
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtApellidoPaterno.Focus()
        End If
    End Sub


    Private Sub txtApellidoPaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoPaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtApellidoMaterno.Focus()
        End If
    End Sub

    Private Sub txtApellidoMaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoMaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRFC.Focus()
        End If
    End Sub
#End Region

#Region "Metodos"
    Public Function Limpiar() As Boolean
        Me.txtApellidoMaterno.Text = ""
        Me.txtApellidoPaterno.Text = ""
        Me.txtCantCabezas.Text = 0
        Me.txtNombre.Text = ""
        Me.txtRFC.Text = ""
        Me.txtCodigo.Text = ""
        Me.dtpFecha.Value = Now
        Me.lblEstatus.Visible = False
    End Function
    Public Function Deshabilitar() As Boolean
        Me.txtApellidoMaterno.Enabled = False
        Me.txtApellidoPaterno.Enabled = False
        Me.txtNombre.Enabled = False
        Me.txtRFC.Enabled = False
        Me.dgvIntroductores.Enabled = True
    End Function
    Public Function Habilitar() As Boolean
        Me.txtApellidoMaterno.Enabled = True
        Me.txtApellidoPaterno.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtRFC.Enabled = True
        Me.dgvIntroductores.Enabled = False
    End Function
    Public Function Guardar() As Boolean
        Introductor.Nombre = Me.txtNombre.Text
        Introductor.ApellidoPaterno = Me.txtApellidoPaterno.Text
        Introductor.ApellidoMaterno = Me.txtApellidoMaterno.Text
        Introductor.RFC = Me.txtRFC.Text
    End Function
    Public Function PonerDatos() As Boolean
        Me.txtNombre.Text = Introductor.Nombre
        Me.txtApellidoMaterno.Text = Introductor.ApellidoMaterno
        Me.txtApellidoPaterno.Text = Introductor.ApellidoPaterno
        Me.txtCantCabezas.Text = Introductor.CantCabUltimaIntGanado
        Me.txtCodigo.Text = Introductor.IdIntroductor
        Me.txtRFC.Text = Introductor.RFC
        Me.dtpFecha.Value = Introductor.FechaUltimaIntGanado
        Me.lblEstatus.Text = Introductor.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Function
    Public Function Validar() As Boolean
        Try
            If Me.txtNombre.Text = "" Then
                MessageBox.Show("Especifique nombre de introductor", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtNombre.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "BotonesToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Introductor.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar este Introductor", MsgBoxStyle.Exclamation, "MEAT")
                Exit Sub
            End If
            Me.Introductor.Borrar()
            Me.Limpiar()
            Me.IntroductorC.Obtener()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Introductor.Estatus = EstatusDatos.VIGENTE Then
            Me.Habilitar()
        Else
            MessageBox.Show("No se puede editar este introductor", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Me.Validar Then
                Cancelar = True
                Exit Sub
            End If
            Me.Guardar()
            Introductor.Guardar()
            Me.Limpiar()
            Me.IntroductorC.Obtener()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.Habilitar()
        Me.txtNombre.Focus()
        Introductor = New ClasesNegocio.CatIntroductoresClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

    Private Sub dgvIntroductores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvIntroductores.DoubleClick
        Try
            If Me.dgvIntroductores.SelectedRows.Count > 0 Then
                Introductor = New ClasesNegocio.CatIntroductoresClass
                If Not Introductor.Obtener(DirectCast(Me.dgvIntroductores.SelectedRows(0).DataBoundItem, ClasesNegocio.CatIntroductoresClass).IdIntroductor) Then
                    MessageBox.Show("No existe introductor de ganado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.PonerDatos()
                    Me.mtb.sbCambiarEstadoBotones("Buscar")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class