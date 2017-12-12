Imports CN = ClasesNegocio
Imports Integra.Clases


Public Class CatBeneficiariosForm
    Implements InterfaceForm

#Region " Declaraciones "
    Private WithEvents beneficiario As CN.BeneficiarioClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.BeneficiarioClass)
    Private chkEstatus As CondicionEnum = CondicionEnum.ACTIVOS
    Dim Editar As Boolean = False
#End Region

#Region " Forma "
    Private Sub CatBeneficiariosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        MtbEstados.StateLimpiar = ""
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
        MtbEstados.StateCancelar = "000100011"
        Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Beneficiario."
        MtbEstados.StateNuevo = "011010001"
        Me.mtb.Buttons(6).ToolTipText = "Guarda el Beneficiario o los cambios que se le hayan Realizado."
        MtbEstados.StateGuardar = "110100011"
        Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del Beneficiario."
        MtbEstados.StateBorrar = "100100001"
        Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Beneficiario."
        MtbEstados.StateEditar = "001010000"
        Me.mtb.Buttons(10).ToolTipText = "Imprime Los Beneficiarios Registrados."
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        mtb.Buttons(1).Visible = False
        Lectura()
        Beneficiarios.Obtener(CondicionEnum.ACTIVOS)
        Me.lblEstatus.Visible = False
    End Sub
#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        gpo.Enabled = False
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = False
        gpo.Enabled = True
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        txtDescripcion.Clear()
        Me.Txtfiltro.Clear()
        Me.lblEstatus.Visible = False
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        txtDescripcion.Text = beneficiario.Beneficiario
        Me.lblEstatus.Visible = True
        lblEstatus.Text = beneficiario.Estatus.ToString
    End Sub

    Public Function Validar() As String Implements InterfaceForm.Validar
        Dim Cadena As String = "Faltan los siguientes datos:" & vbCrLf
        Dim Bl As Boolean = False
        If txtDescripcion.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Beneficiario" & vbCrLf
            Bl = True
        End If
        If Not Bl Then
            Cadena = Nothing
            beneficiario.Beneficiario = txtDescripcion.Text
        End If
        Return Cadena
    End Function
#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cancelar = True
        If beneficiario.Borrar() Then
            Limpiar()
            Lectura()
        Else
            Cancelar = True
        End If
        Beneficiarios.Obtener(chkEstatus)
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        beneficiario = Nothing
        Lectura()
        Limpiar()
        Beneficiarios.Obtener(chkEstatus)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If beneficiario.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If Not beneficiario.EsProveedor Then
                Escritura()
                Me.txtDescripcion.Focus()
                Cancelar = False
            Else
                MessageBox.Show("No se puede editar a este beneficiario ya que es proveedor.", "Operación no Valida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If MessageBox.Show("El beneficiario está inactivo, ¿Desea activarlo?", "Activar beneficiario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Not beneficiario.EsProveedor Then
                    beneficiario.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblEstatus.Text = beneficiario.Estatus.ToString
                    Escritura()
                    Me.txtDescripcion.Focus()
                    Editar = True
                Else
                    beneficiario.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    beneficiario.Guardar(Editar)
                End If
            Else
                Cancelar = True
                mtb.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                Lectura()
            End If
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True
        If IsNothing(Validar()) Then
            If beneficiario.Guardar(Editar) Then
                Limpiar()
                Lectura()
                Cancelar = False
            End If
        Else
            MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Beneficiarios.Obtener(chkEstatus)
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim pre As New ClasesNegocio.PreVisualizarForm
        pre.Reporte = Me.Beneficiarios.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        pre.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        beneficiario = New ClasesNegocio.BeneficiarioClass
        Me.txtDescripcion.Focus()
        Editar = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

#Region " Otros "

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked Then
            chkEstatus = CondicionEnum.TODOS
        Else
            chkEstatus = CondicionEnum.ACTIVOS
        End If
        Beneficiarios.Obtener(chkEstatus)
    End Sub

#End Region

#Region " DataGrid "

    Private Sub dgvBeneficiarios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvBeneficiarios.Click
        beneficiario = Nothing
        beneficiario = seleccion.ObtenerdeDataGrid(dgvBeneficiarios)
        If Not IsNothing(beneficiario) Then
            Mostrar()
            mtb.sbCambiarEstadoBotones("Buscar")
        End If
    End Sub

#End Region

    Private Sub banco_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles beneficiario.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        Me.Beneficiarios.Obtener(Me.Txtfiltro.Text, ClasesNegocio.CondicionEnum.ACTIVOS)
    End Sub

End Class