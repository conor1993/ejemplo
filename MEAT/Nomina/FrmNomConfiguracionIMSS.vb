Imports cn = ClasesNegocio
Public Class FrmNomConfiguracionIMSS
    Dim Configuracion As New cn.ConfiguracionIMSSClass
    'Dim ConfiguracionCol As New cn.ConfiguracionCollectionClass
    Private Sub FrmNomConfiguracionIMSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Configuracion.Obtener(1)
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
        Me.txtCesantiayvejezObrero.Text = 0
        Me.txtCesantiayvejezPatron.Text = 0
        Me.txtCuotaFijaObrero.Text = 0
        Me.txtCuotaFijaPatron.Text = 0
        Me.txtEndineroObrero.Text = 0
        Me.txtEndineroPatron.Text = 0
        Me.txtExcedenteObrero.Text = 0
        Me.txtExcendentePatron.Text = 0
        Me.txtGastosMedicosObrero.Text = 0
        Me.txtGastosMedicosPatron.Text = 0
        Me.txtGuarderias.Text = 0
        Me.txtINFONAVIT.Text = 0
        Me.txtInvalidezyvidaObrero.Text = 0
        Me.txtInvalidezyvidaPatron.Text = 0
        Me.txtRetiro.Text = 0
        Me.txtRiesgodeTrabajo.Text = 0
        Me.txtTopeCalculoCesantiayvejez.Text = 0
        Me.txttopecalculoendinero.Text = 0
        Me.txttopecalculoexcedente.Text = 0
        Me.txtTopeCalculoGastosMedicos.Text = 0
        Me.txtTopeCalculoguarderias.Text = 0
        Me.txtTopeCalculoINFONAVIT.Text = 0
        Me.txtTopeCalculoInvalidezyvida.Text = 0
        Me.txtTopeCalculoRetiro.Text = 0
        Me.txtTopeCalculoRiesgodeTrabajo.Text = 0
        Me.txtTopeCaluloCuotaFija.Text = 0
        Me.txtTopeIntegrarCesantiayvejez.Text = 0
        Me.txtTopeIntegrarCuotaFija.Text = 0
        Me.txttopeintegrarendinero.Text = 0
        Me.txttopeintegrarexcedente.Text = 0
        Me.txtTopeIntegrarGastosMedicos.Text = 0
        Me.txtTopeIntegrarGuarderias.Text = 0
        Me.txtTopeIntegrarINFONAIT.Text = 0
        Me.txtTopeIntegrarInvalidezyvida.Text = 0
        Me.txtTopeIntegrarRetiro.Text = 0
        Me.txtTopeIntegrarRiesgodeTrabajo.Text = 0
    End Sub

    Private Sub Habilitar()
        Me.txtCesantiayvejezObrero.Enabled = True
        Me.txtCesantiayvejezPatron.Enabled = True
        Me.txtCuotaFijaObrero.Enabled = True
        Me.txtCuotaFijaPatron.Enabled = True
        Me.txtEndineroObrero.Enabled = True
        Me.txtEndineroPatron.Enabled = True
        Me.txtExcedenteObrero.Enabled = True
        Me.txtExcendentePatron.Enabled = True
        Me.txtGastosMedicosObrero.Enabled = True
        Me.txtGastosMedicosPatron.Enabled = True
        Me.txtGuarderias.Enabled = True
        Me.txtINFONAVIT.Enabled = True
        Me.txtInvalidezyvidaObrero.Enabled = True
        Me.txtInvalidezyvidaPatron.Enabled = True
        Me.txtRetiro.Enabled = True
        Me.txtRiesgodeTrabajo.Enabled = True
        Me.txtTopeCalculoCesantiayvejez.Enabled = True
        Me.txttopecalculoendinero.Enabled = True
        Me.txttopecalculoexcedente.Enabled = True
        Me.txtTopeCalculoGastosMedicos.Enabled = True
        Me.txtTopeCalculoguarderias.Enabled = True
        Me.txtTopeCalculoINFONAVIT.Enabled = True
        Me.txtTopeCalculoInvalidezyvida.Enabled = True
        Me.txtTopeCalculoRetiro.Enabled = True
        Me.txtTopeCalculoRiesgodeTrabajo.Enabled = True
        Me.txtTopeCaluloCuotaFija.Enabled = True
        Me.txtTopeIntegrarCesantiayvejez.Enabled = True
        Me.txtTopeIntegrarCuotaFija.Enabled = True
        Me.txttopeintegrarendinero.Enabled = True
        Me.txttopeintegrarexcedente.Enabled = True
        Me.txtTopeIntegrarGastosMedicos.Enabled = True
        Me.txtTopeIntegrarGuarderias.Enabled = True
        Me.txtTopeIntegrarINFONAIT.Enabled = True
        Me.txtTopeIntegrarInvalidezyvida.Enabled = True
        Me.txtTopeIntegrarRetiro.Enabled = True
        Me.txtTopeIntegrarRiesgodeTrabajo.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtCesantiayvejezObrero.Enabled = False
        Me.txtCesantiayvejezPatron.Enabled = False
        Me.txtCuotaFijaObrero.Enabled = False
        Me.txtCuotaFijaPatron.Enabled = False
        Me.txtEndineroObrero.Enabled = False
        Me.txtEndineroPatron.Enabled = False
        Me.txtExcedenteObrero.Enabled = False
        Me.txtExcendentePatron.Enabled = False
        Me.txtGastosMedicosObrero.Enabled = False
        Me.txtGastosMedicosPatron.Enabled = False
        Me.txtGuarderias.Enabled = False
        Me.txtINFONAVIT.Enabled = False
        Me.txtInvalidezyvidaObrero.Enabled = False
        Me.txtInvalidezyvidaPatron.Enabled = False
        Me.txtRetiro.Enabled = False
        Me.txtRiesgodeTrabajo.Enabled = False
        Me.txtTopeCalculoCesantiayvejez.Enabled = False
        Me.txttopecalculoendinero.Enabled = False
        Me.txttopecalculoexcedente.Enabled = False
        Me.txtTopeCalculoGastosMedicos.Enabled = False
        Me.txtTopeCalculoguarderias.Enabled = False
        Me.txtTopeCalculoINFONAVIT.Enabled = False
        Me.txtTopeCalculoInvalidezyvida.Enabled = False
        Me.txtTopeCalculoRetiro.Enabled = False
        Me.txtTopeCalculoRiesgodeTrabajo.Enabled = False
        Me.txtTopeCaluloCuotaFija.Enabled = False
        Me.txtTopeIntegrarCesantiayvejez.Enabled = False
        Me.txtTopeIntegrarCuotaFija.Enabled = False
        Me.txttopeintegrarendinero.Enabled = False
        Me.txttopeintegrarexcedente.Enabled = False
        Me.txtTopeIntegrarGastosMedicos.Enabled = False
        Me.txtTopeIntegrarGuarderias.Enabled = False
        Me.txtTopeIntegrarINFONAIT.Enabled = False
        Me.txtTopeIntegrarInvalidezyvida.Enabled = False
        Me.txtTopeIntegrarRetiro.Enabled = False
        Me.txtTopeIntegrarRiesgodeTrabajo.Enabled = False
    End Sub

    Private Sub Guardar()
        Configuracion.CesantiayvejezObrero = Me.txtCesantiayvejezObrero.Text
        Configuracion.CesantiayVejezPatronal = Me.txtCesantiayvejezPatron.Text
        Configuracion.CuotFijaObrero = Me.txtCuotaFijaObrero.Text
        Configuracion.CuotaFijaPatronal = Me.txtCuotaFijaPatron.Text
        Configuracion.EndineroObrero = Me.txtEndineroObrero.Text
        Configuracion.EndineroPatronal = Me.txtEndineroPatron.Text
        Configuracion.ExcedenteObrero = Me.txtExcedenteObrero.Text
        Configuracion.ExcedentePatronal = Me.txtExcendentePatron.Text
        Configuracion.GastosMedicosObrero = Me.txtGastosMedicosObrero.Text
        Configuracion.GastosMedicosPatronal = Me.txtGastosMedicosPatron.Text
        Configuracion.Guarderias = Me.txtGuarderias.Text
        Configuracion.INFONAVIT = Me.txtINFONAVIT.Text
        Configuracion.InvalidezyvidaObrero = Me.txtInvalidezyvidaObrero.Text
        Configuracion.InvalidezyvidaPatronal = Me.txtInvalidezyvidaPatron.Text
        Configuracion.Retiro = Me.txtRetiro.Text
        Configuracion.RiesgodeTrabajo = Me.txtRiesgodeTrabajo.Text
        Configuracion.TopeCalcularCesantiayVejez = Me.txtTopeCalculoCesantiayvejez.Text
        Configuracion.TopeCalcularEndinero = Me.txttopecalculoendinero.Text
        Configuracion.TopeCalcularCuotaFija = Me.txtTopeCaluloCuotaFija.Text
        Configuracion.TopeCalcularExcedente = Me.txttopecalculoexcedente.Text
        Configuracion.TopeCalcularGastosMedicos = Me.txtTopeCalculoGastosMedicos.Text
        Configuracion.TopeCalcularGuarderias = Me.txtTopeCalculoguarderias.Text
        Configuracion.TopeCalcularINFONAVIT = Me.txtTopeCalculoINFONAVIT.Text
        Configuracion.TopeCalcularInvalidezyvida = Me.txtTopeCalculoInvalidezyvida.Text
        Configuracion.TopeCalcularRetiro = Me.txtTopeCalculoRetiro.Text
        Configuracion.TopeCalcularriesgodeTrabajo = Me.txtTopeCalculoRiesgodeTrabajo.Text
        Configuracion.TopeIntegrarCesantiayVejez = Me.txtTopeIntegrarCesantiayvejez.Text
        Configuracion.TopeIntegrarCuotaFija = Me.txtTopeIntegrarCuotaFija.Text
        Configuracion.TopeIntegrarEndinero = Me.txttopeintegrarendinero.Text
        Configuracion.TopeIntegrarExcedente = Me.txttopeintegrarexcedente.Text
        Configuracion.TopeIntegrarGastosMedicos = Me.txtTopeIntegrarGastosMedicos.Text
        Configuracion.TopeIntegrarGuarderias = Me.txtTopeIntegrarGuarderias.Text
        Configuracion.TopeIntegrarINFONAVIT = Me.txtTopeIntegrarINFONAIT.Text
        Configuracion.TopeIntegrarInvalidezyvida = Me.txtTopeIntegrarInvalidezyvida.Text
        Configuracion.TopeIntegrarRetiro = Me.txtTopeIntegrarRetiro.Text
        Configuracion.TopeIntegrarriesgodeTrabajo = Me.txtTopeIntegrarRiesgodeTrabajo.Text

    End Sub

    Private Sub PonerDatos()
        Me.txtCesantiayvejezObrero.Text = Configuracion.CesantiayvejezObrero
        Me.txtCesantiayvejezPatron.Text = Configuracion.CesantiayVejezPatronal
        Me.txtCuotaFijaObrero.Text = Configuracion.CuotFijaObrero
        Me.txtCuotaFijaPatron.Text = Configuracion.CuotaFijaPatronal
        Me.txtEndineroObrero.Text = Configuracion.EndineroObrero
        Me.txtEndineroPatron.Text = Configuracion.EndineroPatronal
        Me.txtExcedenteObrero.Text = Configuracion.ExcedenteObrero
        Me.txtExcendentePatron.Text = Configuracion.ExcedentePatronal
        Me.txtGastosMedicosObrero.Text = Configuracion.GastosMedicosObrero
        Me.txtGastosMedicosPatron.Text = Configuracion.GastosMedicosPatronal
        Me.txtGuarderias.Text = Configuracion.Guarderias
        Me.txtINFONAVIT.Text = Configuracion.INFONAVIT
        Me.txtInvalidezyvidaObrero.Text = Configuracion.InvalidezyvidaObrero
        Me.txtInvalidezyvidaPatron.Text = Configuracion.InvalidezyvidaPatronal
        Me.txtRetiro.Text = Configuracion.Retiro
        Me.txtRiesgodeTrabajo.Text = Configuracion.RiesgodeTrabajo
        Me.txtTopeCalculoCesantiayvejez.Text = Configuracion.TopeCalcularCesantiayVejez
        Me.txttopecalculoendinero.Text = Configuracion.TopeCalcularEndinero
        Me.txtTopeCaluloCuotaFija.Text = Configuracion.TopeCalcularCuotaFija
        Me.txttopecalculoexcedente.Text = Configuracion.TopeCalcularExcedente
        Me.txtTopeCalculoGastosMedicos.Text = Configuracion.TopeCalcularGastosMedicos
        Me.txtTopeCalculoguarderias.Text = Configuracion.TopeCalcularGuarderias
        Me.txtTopeCalculoINFONAVIT.Text = Configuracion.TopeCalcularINFONAVIT
        Me.txtTopeCalculoInvalidezyvida.Text = Configuracion.TopeCalcularInvalidezyvida
        Me.txtTopeCalculoRetiro.Text = Configuracion.TopeCalcularRetiro
        Me.txtTopeCalculoRiesgodeTrabajo.Text = Configuracion.TopeCalcularriesgodeTrabajo
        Me.txtTopeIntegrarCesantiayvejez.Text = Configuracion.TopeIntegrarCesantiayVejez
        Me.txtTopeIntegrarCuotaFija.Text = Configuracion.TopeIntegrarCuotaFija
        Me.txttopeintegrarendinero.Text = Configuracion.TopeIntegrarEndinero
        Me.txttopeintegrarexcedente.Text = Configuracion.TopeIntegrarExcedente
        Me.txtTopeIntegrarGastosMedicos.Text = Configuracion.TopeIntegrarGastosMedicos
        Me.txtTopeIntegrarGuarderias.Text = Configuracion.TopeIntegrarGuarderias
        Me.txtTopeIntegrarINFONAIT.Text = Configuracion.TopeIntegrarINFONAVIT
        Me.txtTopeIntegrarInvalidezyvida.Text = Configuracion.TopeIntegrarInvalidezyvida 
        Me.txtTopeIntegrarRetiro.Text = Configuracion.TopeIntegrarRetiro 
        Me.txtTopeIntegrarRiesgodeTrabajo.Text = Configuracion.TopeIntegrarriesgodeTrabajo

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
            If Configuracion.Guardar() Then
                MsgBox("Se ha guardado la configuración del IMSS", MsgBoxStyle.Information, "Aviso")
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
        Me.txtCuotaFijaObrero.Focus()
        'Me.Configuracion = New cn.ConfiguracionIMSSClass
    End Sub
    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

    Private Sub txtCuotaFijaObrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuotaFijaObrero.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCuotaFijaPatron.Focus()
        End If
    End Sub

    Private Sub txtCuotaFijaPatron_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuotaFijaPatron.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarCuotaFija.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarCuotaFija_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarCuotaFija.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCaluloCuotaFija.Focus()
        End If
    End Sub

    Private Sub txtTopeCaluloCuotaFija_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCaluloCuotaFija.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtExcedenteObrero.Focus()
        End If
    End Sub

    Private Sub txtExcedenteObrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExcedenteObrero.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtExcendentePatron.Focus()
        End If
    End Sub

    Private Sub txtExcendentePatron_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExcendentePatron.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txttopeintegrarexcedente.Focus()
        End If
    End Sub

    Private Sub txttopeintegrarexcedente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttopeintegrarexcedente.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txttopecalculoexcedente.Focus()
        End If
    End Sub

    Private Sub txttopecalculoexcedente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttopecalculoexcedente.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtEndineroObrero.Focus()
        End If
    End Sub

    Private Sub txtGastosMedicosObrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGastosMedicosObrero.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtGastosMedicosPatron.Focus()
        End If
    End Sub

    Private Sub txtGastosMedicosPatron_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGastosMedicosPatron.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarGastosMedicos.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarGastosMedicos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarGastosMedicos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCalculoGastosMedicos.Focus()
        End If
    End Sub

    Private Sub txtTopeCalculoGastosMedicos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCalculoGastosMedicos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtInvalidezyvidaObrero.Focus()
        End If
    End Sub

    Private Sub txtInvalidezyvidaObrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvalidezyvidaObrero.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtInvalidezyvidaPatron.Focus()
        End If
    End Sub

    Private Sub txtInvalidezyvidaPatron_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvalidezyvidaPatron.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarInvalidezyvida.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarInvalidezyvida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarInvalidezyvida.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCalculoInvalidezyvida.Focus()
        End If
    End Sub

    Private Sub txtTopeCalculoInvalidezyvida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCalculoInvalidezyvida.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCesantiayvejezObrero.Focus()
        End If
    End Sub

    Private Sub txtCesantiayvejezObrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCesantiayvejezObrero.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCesantiayvejezPatron.Focus()
        End If
    End Sub

    Private Sub txtCesantiayvejezPatron_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCesantiayvejezPatron.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarCesantiayvejez.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarCesantiayvejez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarCesantiayvejez.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCalculoCesantiayvejez.Focus()
        End If
    End Sub

    Private Sub txtTopeCalculoCesantiayvejez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCalculoCesantiayvejez.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtGuarderias.Focus()
        End If
    End Sub

    Private Sub txtGuarderias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuarderias.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarGuarderias.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarGuarderias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarGuarderias.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCalculoguarderias.Focus()
        End If
    End Sub

    Private Sub txtTopeCalculoguarderias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCalculoguarderias.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRetiro.Focus()
        End If
    End Sub

    Private Sub txtRetiro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetiro.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarRetiro.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarRetiro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarRetiro.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCalculoRetiro.Focus()
        End If
    End Sub

    Private Sub txtTopeCalculoRetiro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCalculoRetiro.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtINFONAVIT.Focus()
        End If
    End Sub

    Private Sub txtINFONAVIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtINFONAVIT.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarINFONAIT.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarINFONAIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarINFONAIT.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCalculoINFONAVIT.Focus()
        End If
    End Sub

    Private Sub txtTopeCalculoINFONAVIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCalculoINFONAVIT.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRiesgodeTrabajo.Focus()
        End If
    End Sub

    Private Sub txtRiesgodeTrabajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRiesgodeTrabajo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeIntegrarRiesgodeTrabajo.Focus()
        End If
    End Sub

    Private Sub txtTopeIntegrarRiesgodeTrabajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeIntegrarRiesgodeTrabajo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTopeCalculoRiesgodeTrabajo.Focus()
        End If
    End Sub

    Private Sub txtTopeCalculoRiesgodeTrabajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopeCalculoRiesgodeTrabajo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCuotaFijaObrero.Focus()
        End If
    End Sub

    Private Sub txtExcedenteObrero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExcedenteObrero.TextChanged

    End Sub

    Private Sub txtEndineroObrero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtEndineroPatron.Focus()
        End If
    End Sub

    Private Sub txtEndineroPatron_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txttopeintegrarendinero.Focus()
        End If
    End Sub

    Private Sub txttopeintegrarendinero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txttopecalculoendinero.Focus()
        End If
    End Sub

    Private Sub txttopecalculoendinero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtGastosMedicosObrero.Focus()
        End If
    End Sub
End Class