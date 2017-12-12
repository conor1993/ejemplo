Imports cn = ClasesNegocio
Public Class FrmNomPuestos
    Dim Puestos As cn.NomcatpuestosClass
    Dim Editar As Boolean = False
    Private Sub FrmNomPuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Me.mtb.Buttons(1).Visible = False
            Me.mtb.Buttons(4).Visible = False
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.PuestosC.Obtener()

            Limpiar()
            Deshabilitar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
#Region "Metodos"
    Sub Limpiar()
        Me.txtCodigo.Text = 0
        Me.txtDescripcion.Text = ""
        Me.txtSueldoDiario.Text = 0.0
        Me.lblEstatus.Visible = False
    End Sub
    Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.txtSueldoDiario.Enabled = True
        Me.dgLista.Enabled = False
    End Sub
    Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtSueldoDiario.Enabled = False
        Me.txtCodigo.Enabled = False
        Me.dgLista.Enabled = True
    End Sub
    Private Function Guardar() As Boolean
        Try
            Puestos.Descripcion = Me.txtDescripcion.Text
            Puestos.SueldoDiario = Me.txtSueldoDiario.Text
            Puestos.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            'Puestos.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Puestos.FechaAlta = Now
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub PonerDatos()
        Me.txtCodigo.Text = Puestos.IdPuesto
        Me.txtDescripcion.Text = Puestos.Descripcion
        Me.txtSueldoDiario.Text = Puestos.SueldoDiario
        Me.lblEstatus.Text = Puestos.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub

    Private Function Validar() As Boolean
        Try

            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Ingrese la Descrición", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            End If

            If CDec(Me.txtSueldoDiario.Text) = 0 Then
                MessageBox.Show("Ingrese el sueldo diario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "ToolBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Puestos.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar el Puesto debido a que ya se encuentra cancelado", MsgBoxStyle.Information)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("Esta seguro de cancelar el Puesto", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Puestos.Estatus = ClasesNegocio.EstatusDatos.CANCELADO
                If Puestos.Borrar Then
                    MsgBox("Se ha cancelado el centro de costos", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Deshabilitar()
                    Me.PuestosC.Obtener()
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub
    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If Not Guardar() Then
                Cancelar = True
                Exit Sub
            End If

            If Puestos.Guardar() Then
                MsgBox("El puesto ha sido guardado con el código: " & Puestos.IdPuesto, MsgBoxStyle.Information, "Aviso")
                Limpiar()
                Deshabilitar()
            End If

            Me.PuestosC.Obtener()
            'Me.DgvCentros.AutoGenerateColumns = False
            'Me.DgvCentros.DataSource = CentroDeCostosC
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Habilitar()
        Limpiar()
        Me.Puestos = New cn.NomcatpuestosClass
    End Sub
    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSueldoDiario.Focus()
        End If
    End Sub


    Private Sub txtSueldoDiario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldoDiario.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub dgLista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLista.CellContentClick

    End Sub
    Private Sub dgLista_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLista.Click
        Try
            If Me.dgLista.SelectedRows.Count > 0 Then
                Puestos = DirectCast(Me.dgLista.SelectedRows(0).DataBoundItem, cn.NomcatpuestosClass)
                PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgLista_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLista.RowEnter
        Try
            If Me.dgLista.SelectedRows.Count > 0 Then
                Puestos = DirectCast(Me.dgLista.SelectedRows(0).DataBoundItem, cn.NomcatpuestosClass)
                PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        If Puestos.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Editar = True
            Me.txtDescripcion.Focus()
        Else
            If MessageBox.Show("El Puesto esta Inactivo, ¿Desea activarlo?", "Activar puesto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Puestos.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Text = Puestos.Estatus.ToString
                Habilitar()
                Editar = True
                Me.txtDescripcion.Focus()
            Else
                Cancelar = True
                mtb.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                Deshabilitar()
            End If
        End If
    End Sub
End Class