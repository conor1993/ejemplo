Imports cn = ClasesNegocio

Public Class FrmNomConfiguracion
    Dim ConfiguracionNomina As New cn.NomConfiguracionClass
    Private Sub FrmNomConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
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

            Deshabilitar()
            ConfiguracionNomina.Obtener(1)
            PonerDatos()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
#Region "Metodos"
    Private Sub Limpiar()
        Me.txtDiasdetrabajo.Text = 0
        Me.txtMesComercial.Text = 0
        Me.txtSalarioMinimoDF.Text = 0
        Me.txtSalarioMinimoSinaloa.Text = 0
        Me.txtHorasDiarias.Text = 0
    End Sub

    Private Sub Deshabilitar()
        Me.txtDiasdetrabajo.Enabled = False
        Me.txtMesComercial.Enabled = False
        Me.txtSalarioMinimoDF.Enabled = False
        Me.txtSalarioMinimoSinaloa.Enabled = False
        Me.txtHorasDiarias.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.txtDiasdetrabajo.Enabled = True
        Me.txtMesComercial.Enabled = True
        Me.txtSalarioMinimoDF.Enabled = True
        Me.txtSalarioMinimoSinaloa.Enabled = True
        Me.txtHorasDiarias.Enabled = True
    End Sub

    Private Sub Guardar()
        ConfiguracionNomina.SalarioMinimoDF = Me.txtSalarioMinimoDF.Text
        ConfiguracionNomina.SalarioMinimoSinaloa = Me.txtSalarioMinimoSinaloa.Text
        ConfiguracionNomina.MesComercial = Me.txtMesComercial.Text
        ConfiguracionNomina.Horasdetrabajo = Me.txtHorasDiarias.Text
        ConfiguracionNomina.DiasdeTrabajo = Me.txtDiasdetrabajo.Text
    End Sub

    Private Sub PonerDatos()
        Me.txtSalarioMinimoDF.Text = ConfiguracionNomina.SalarioMinimoDF
        Me.txtSalarioMinimoSinaloa.Text = ConfiguracionNomina.SalarioMinimoSinaloa
        Me.txtMesComercial.Text = ConfiguracionNomina.MesComercial
        Me.txtHorasDiarias.Text = ConfiguracionNomina.Horasdetrabajo
        Me.txtDiasdetrabajo.Text = ConfiguracionNomina.DiasdeTrabajo
    End Sub
#End Region

#Region "ToolBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try

            Guardar()
            If ConfiguracionNomina.Guardar() Then
                MsgBox("Se ha guardado la configuración de la Nomina", MsgBoxStyle.Information, "Aviso")
                Limpiar()
                Deshabilitar()
            End If

            'Me.PuestosC.Obtener()
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
        Me.txtSalarioMinimoDF.Focus()
        'Me.Configuracion = New cn.ConfiguracionIMSSClass
    End Sub
    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region


    Private Sub txtSalarioMinimoDF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalarioMinimoDF.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSalarioMinimoSinaloa.Focus()
        End If
    End Sub

    Private Sub txtSalarioMinimoSinaloa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalarioMinimoSinaloa.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtMesComercial.Focus()
        End If
    End Sub

    Private Sub txtMesComercial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMesComercial.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtHorasDiarias.Focus()
        End If
    End Sub

    Private Sub txtHorasDiarias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHorasDiarias.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDiasdetrabajo.Focus()
        End If
    End Sub

    Private Sub txtDiasdetrabajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasdetrabajo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSalarioMinimoDF.Focus()
        End If
    End Sub
End Class