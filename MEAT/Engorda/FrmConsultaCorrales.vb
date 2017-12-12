Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmConsultaCorrales

#Region "Definiciones"
    Private Corrales As CorralColecttionClass = Nothing
#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        dgvGanado.AutoGenerateColumns = False
        cmbTipoCorral.DataSource = Controlador.ObtenerTiposCorrales(EstatusChar.VIGENTE)
        Corrales = New CorralColecttionClass()
        Corrales.Obtener(CondicionEstatusEnum.ACTIVO)
        Limpiar()
    End Sub

    Public Sub ActualizarDatosCorral(ByVal Corral As CorralClass)
        Dim CostoEntrada As Decimal = 0D, CostoMedicamentos As Decimal = 0D, CostoAlimentos As Decimal = 0D, CostoIndirecto As Decimal = 0D

        Limpiar2()
        txtCodigo.Text = Corral.IdCorral

        If Corral.Entidad.McecatLotesCab.Count > 0 Then
            For Each Lote As EC.McecatLotesCabEntity In Corral.Entidad.McecatLotesCab
                If Lote.Estatus = 1 Then
                    txtLotes.Text = Lote.NombreLote
                End If
            Next
        End If

        txtCapacidad.Text = Corral.Capacidad
        txtSuperficie.Text = Corral.Superficie
        dgvGanado.DataSource = Corral.Detalle

        For Each Det As CorralDetalleClass In Corral.Detalle
            CostoEntrada += Det.CostoEnt
            CostoMedicamentos += Det.ImpteMedicamento
            CostoAlimentos += Det.ImpteAlimento
            CostoIndirecto += Det.SaldoCostoInd
        Next
        txtTotalCostoGanado.Text = (CostoEntrada + CostoMedicamentos + CostoAlimentos + CostoIndirecto).ToString("C2")
        txtTotalCostoEntrada.Text = CostoEntrada.ToString("C2")
        txtTotalCostoMedicamentos.Text = CostoMedicamentos.ToString("C2")
        txtTotalCostoAlimentos.Text = CostoAlimentos.ToString("C2")
        txtTotalCostosIndirectos.Text = CostoIndirecto.ToString("C2")
    End Sub
#End Region

#Region "Acciones del Menu"
    Public Sub Limpiar()
        cmbTipoCorral.SelectedIndex = -1
        cmbTipoCorral.Text = "Seleccione el Tipo de Corral"
        cmbCorral.Enabled = False
        txtCodigo.ResetText()
        txtCapacidad.ResetText()
        txtSuperficie.ResetText()
        txtLotes.ResetText()
        dgvGanado.DataSource = Nothing
        txtTotalCostosIndirectos.ResetText()
        txtTotalCostoAlimentos.ResetText()
        txtTotalCostoMedicamentos.ResetText()
        txtTotalCostoEntrada.ResetText()
        txtTotalCostoGanado.ResetText()
    End Sub

    Private Sub Limpiar2()
        txtCodigo.ResetText()
        txtCapacidad.ResetText()
        txtSuperficie.ResetText()
        txtLotes.ResetText()
        dgvGanado.DataSource = Nothing
        txtTotalCostosIndirectos.ResetText()
        txtTotalCostoAlimentos.ResetText()
        txtTotalCostoMedicamentos.ResetText()
        txtTotalCostoEntrada.ResetText()
        txtTotalCostoGanado.ResetText()
    End Sub

    Public Sub Imprimir()

    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub
#End Region

#Region "Eventos"

    Private Sub FrmConsultaCorrales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub Menu_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar, mtb.ClickImprimir, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub cmbTipoCorral_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCorral.SelectedIndexChanged
        If sender.SelectedIndex <> -1 And Corrales IsNot Nothing Then
            cmbCorral.Enabled = True
            cmbCorral.DisplayMember = "NombreCorral"
            cmbCorral.ValueMember = "IdCorral"
            cmbCorral.DataSource = Corrales.ObtenerCorrales(sender.SelectedValue)

            If cmbCorral.Items.Count > 1 Then
                cmbCorral.SelectedIndex = -1
                cmbCorral.Text = "Seleccione el Corral"
            ElseIf cmbCorral.Items.Count = 1 Then
                cmbCorral.SelectedIndex = 0
            End If
        Else
            cmbCorral.DataSource = Nothing
            cmbCorral.Enabled = False
        End If
    End Sub

    Private Sub cmbCorral_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCorral.SelectedIndexChanged
        If sender.SelectedIndex <> -1 Then
            Utilerias.RunControlException(Me, "ActualizarDatosCorral", New Object() {CType(sender.SelectedItem, CorralClass)})
        Else
            Limpiar2()
        End If
    End Sub

#End Region

End Class