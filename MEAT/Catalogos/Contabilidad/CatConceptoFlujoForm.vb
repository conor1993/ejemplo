Imports CN = ClasesNegocio
Imports Integra.Clases


Public Class CatConceptoFlujoForm
    Implements InterfaceForm

#Region " Declaraciones "
    Private WithEvents Concepto As CN.ConceptoFlujoClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.ConceptoFlujoClass)
#End Region

#Region " Forma "
    Private Sub CatConceptosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        'Me.mtb.Buttons(0).ToolTipText = "Busca los Proveedores Registrados."
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
        Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Concepto de Flujo."
        Me.mtb.Buttons(6).ToolTipText = "Guarda el Concepto de Flujo o los cambios que se le hayan Realizado."
        Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de el Concepto de Flujo a Inactivo."
        Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Concepto de Flujo."
        Me.mtb.Buttons(10).ToolTipText = "Imprime los Conceptos de Flujos Registrados."
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

        mtb.sbCambiarEstadoBotones("Cancelar")
        Lectura()
        Conceptos.Obtener(cmbEstatus.SelectedValue)
        dgvDetalles.AutoGenerateColumns = False

    End Sub
#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        gpo.Enabled = False
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        dgvDetalles.DataSource = Nothing
        pan.Enabled = False
        gpo.Enabled = True
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        txtClave.Clear()
        txtDescripcion.Clear()
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        txtClave.Text = Concepto.Clave
        txtDescripcion.Text = Concepto.Descripcion
        dgvDetalles.DataSource = Concepto.CuentasContables
    End Sub

    Public Function Validar() As String Implements InterfaceForm.Validar
        Dim Cadena As String = "Faltan los siguientes datos:" & vbCrLf
        Dim Bl As Boolean = False
        If txtClave.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Clave" & vbCrLf
            Bl = True
        End If
        If txtDescripcion.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Descripción" & vbCrLf
            Bl = True
        End If
        If Not Bl Then
            Cadena = Nothing
            Concepto.Clave = txtClave.Text
            Concepto.Descripcion = txtDescripcion.Text
        End If
        Return Cadena
    End Function
#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cancelar = True
        If Concepto.Borrar() Then
            Limpiar()
            Lectura()
        Else
            Cancelar = True
        End If
        Conceptos.Obtener(cmbEstatus.SelectedValue)
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Concepto = Nothing
        Lectura()
        Limpiar()
        Conceptos.Obtener(cmbEstatus.SelectedValue)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Escritura()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True
        If IsNothing(Validar()) Then
            If Concepto.Guardar() Then
                Limpiar()
                Lectura()
                Cancelar = False
            End If
        Else
            MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Conceptos.Obtener(cmbEstatus.SelectedValue)
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Cursor = Cursors.WaitCursor

            'Dim pre As New ClasesNegocio.PreVisualizarForm
            'pre.Reporte = Me.Conceptos.Reporte(Controlador.Sesion.MiEmpresa.Empnom)
            'pre.ShowDialog()

            Conceptos.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If Conceptos.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.RptFlujos = Conceptos.Reporte(Controlador.Sesion.MiEmpresa.Empnom)
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(Conceptos)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Contabilidad\Conceptos de Flujo")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Concepto de Flujo", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        Concepto = New ClasesNegocio.ConceptoFlujoClass
        dgvDetalles.DataSource = Concepto.CuentasContables
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region " Otros "
    Private Sub cmbEstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstatus.SelectedIndexChanged
        If cmbEstatus.SelectedIndex > -1 Then
            Conceptos.Obtener(cmbEstatus.SelectedValue)
        End If
    End Sub
#End Region

#Region " DataGrid "
    Private Sub dgvConceptos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        Concepto = Nothing
        Concepto = seleccion.ObtenerdeDataGrid(dgv)
        If Not IsNothing(Concepto) Then
            Mostrar()
            mtb.sbCambiarEstadoBotones("Buscar")
        End If
    End Sub
#End Region

    Private Sub Concepto_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles Concepto.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim buscarCuenta As New BusquedaCuentasContablesForm
        'buscarCuenta.BloquearCaracteristicas = True
        'bscarCuenta.AfectableDefault(True) = ClasesNegocios.CondicionAsignadaEnum.SI
        'buscarCuenta.DepartamentalizableDefault(True) = ClasesNegocios.CondicionAsignadaEnum.SI
        'buscarCuenta.BancosDefault(True) = ClasesNegocios.CondicionAsignadaEnum.NO
        If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not Concepto.AgregarCuentaContable(buscarCuenta.CuentaContable) Then
                MessageBox.Show("La cuenta contable especificada ya existe.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dgvDetalles.DataSource = Nothing
                dgvDetalles.DataSource = Concepto.CuentasContables
            End If
        End If
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        For Each dgvr As DataGridViewRow In dgvDetalles.SelectedRows
            Concepto.QuitarCuentaContable(dgvr.DataBoundItem)
        Next
        dgvDetalles.DataSource = Nothing
        dgvDetalles.DataSource = Concepto.CuentasContables
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtClave.Text = "" Then
                MsgBox("Agregue información a la Clave...")
            Else
                Me.SelectNextControl(sender, True, True, False, True)
                Me.txtDescripcion.Focus()
            End If
        End If
    End Sub
End Class