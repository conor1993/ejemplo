Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmEstadisticoLotes

#Region "Miembros"

#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        Controlador.LlenarComboLotes(cmbLote, LoteClass.EstatusLote.CERRADO)
        dgvFomulaciones.AutoGenerateColumns = False
        dgvFormulasAplicadas.AutoGenerateColumns = False
        dgvMedicamentosAplicados.AutoGenerateColumns = False
        udtpFechaInicial.Value = Nothing
        udtpFechaFinal.Value = Nothing
        rbnResumen.Checked = True
    End Sub
#End Region

#Region "Acciones del Menu"
    Public Sub Limpiar()
        rbnResumen.Checked = True
        lblEstatus.Text = "ESTATUS"
        udtpFechaInicial.Value = Nothing
        udtpFechaFinal.Value = Nothing
        dgvFomulaciones.DataSource = Nothing
        dgvFormulasAplicadas.DataSource = Nothing
        dgvMedicamentosAplicados.DataSource = Nothing

        For Each Control As Control In Me.Controls
            If Control.GetType Is GetType(TextBox) Then
                Control.ResetText()
            End If
        Next

        For Each Control As Control In Me.GroupBox2.Controls
            If Control.GetType Is GetType(TextBox) Then
                Control.ResetText()
            End If
        Next

        For Each Control As Control In Me.GroupBox5.Controls
            If Control.GetType Is GetType(TextBox) Then
                Control.ResetText()
            End If
        Next

        For Each Control As Control In Me.GroupBox6.Controls
            If Control.GetType Is GetType(TextBox) Then
                Control.ResetText()
            End If
        Next

        For Each Control As Control In Me.GroupBox7.Controls
            If Control.GetType Is GetType(TextBox) Then
                Control.ResetText()
            End If
        Next

        For Each Control As Control In Me.tbpIndicadores.Controls
            If Control.GetType Is GetType(TextBox) Then
                Control.ResetText()
            End If
        Next
        cmbLote.SelectedIndex = -1
        cmbLote.Text = "Seleccione el Lote"
    End Sub

    Public Sub Imprimir()
        Dim Lote As LoteClass = Nothing
        Dim TipoImpresion As ControladorGanadera.ImpresionDatosDeLote

        If cmbLote.SelectedItem IsNot Nothing Then
            Lote = CType(cmbLote.SelectedItem, LoteClass)

            If rbnResumen.Checked Then
                TipoImpresion = ControladorGanadera.ImpresionDatosDeLote.Resumen
            ElseIf rbnDetalle.Checked Then
                TipoImpresion = ControladorGanadera.ImpresionDatosDeLote.Detalle
            Else
                TipoImpresion = ControladorGanadera.ImpresionDatosDeLote.Movimientos
            End If
            Controlador.ReporteEstadisticoDeLote(Lote, TipoImpresion)
        Else
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 4)
        End If
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmSalidasRecibaRastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub AccionMenu(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir, MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub dgvFomulaciones_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFomulaciones.DataError, dgvFormulasAplicadas.DataError, dgvMedicamentosAplicados.DataError

    End Sub

    Private Sub cmbLote_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            Dim Lote As LoteClass = CType(sender.SelectedItem, LoteClass)
            lblEstatus.Text = Lote.Estatus.ToString()
            txtCorral.Text = Lote.Corral.Descripcion
            udtpFechaInicial.Value = Lote.FechaInicio
            udtpFechaFinal.Value = Lote.FechaCierre

            'Cabezas
            txtEntradaCabeza.Text = Lote.EntradasDeRecibaEnCabezas
            txtEntradasTransferencia.Text = Lote.EntradasDeTransferenciaEnCabezas
            txtSalidasTransferencia.Text = Lote.SalidasDeTransferenciaEnCabezas
            txtSalidasMuerte.Text = Lote.SalidasPorMuerteEnCabezas
            txtTotalCabezas.Text = Lote.TotalCabezasMenosMuertesYSalidasDeTransferencia
            txtSalidasRastro.Text = Lote.SalidasARastroEnCabezas
            txtSalidasVenta.Text = Lote.SalidasAVentaEnCabezas
            txtTotalSalidas.Text = Lote.TotalDeSalidasEnCabezas

            'Kilos
            txtKilogramosSalida.Text = Lote.TotalSalidasEnKg.ToString("N4")
            txtKilogramosEntrada.Text = Lote.TotalEntradasEnKg.ToString("N4")
            txtAumentoLote.Text = Lote.AumentoBrutoEnKgs.ToString("N4")
            txtKilogramosMuerte.Text = Lote.SalidasPorMuerteEnKg.ToString("N4")
            txtAumentoNeto.Text = Lote.AumentoNetoEnKgs.ToString("N4")
            txtKgrsSalidasRastro.Text = Lote.SalidasARastroEnKg.ToString("N4")
            txtKgrsSalidasVenta.Text = Lote.SalidasAVentaEnKg.ToString("N4")
            txtKgrsTotalSalidas.Text = Lote.TotalDeSalidasSinTransferenciasEnKg.ToString("N4")

            'Costos
            txtCostoEntrada.Text = Lote.AcumEntImpte.ToString("C2")
            txtCostoAlimento.Text = Lote.AcumImpteAlim.ToString("C2")
            txtCostoMedicamentos.Text = Lote.AcumImpteMedic.ToString("C2")
            txtCostosIndirectos.Text = Lote.TotalCostoIndirecto.ToString("C2")
            txtCostoTotal.Text = Lote.CostoTotal.ToString("C2")
            txtCostoxCabeza.Text = Lote.CostoxCabeza.ToString("C2")

            'Promedios
            txtKgrsSalidaxCabeza.Text = Lote.SalidasxCabezaEnKg.ToString("N4")
            txtKgrsEntradaxCabeza.Text = Lote.EntradasxCabezaEnKg.ToString("N4")
            txtCostosEntradaxCabeza.Text = Lote.CostoEntradaxCabeza.ToString("C2")
            txtCostosAlimentoxCabeza.Text = Lote.CostoAlimentoxCabeza.ToString("C2")
            txtCostoMedicamentoxCabeza.Text = Lote.CostoMedicamentoxCabeza.ToString("C2")
            txtAumentoNetoxCabeza.Text = Lote.AumentoNetoxCabeza.ToString("N4")
            txtCostoSalidasxKg.Text = Lote.CostoDeSalidasxKg.ToString("C2")

            'Indicadores
            txtDiasEngorda.Text = Lote.DiasEngorda
            txtGDP.Text = Lote.GDP.ToString("N4")
            txtECA.Text = Lote.ECA.ToString("N4")
            txtCKI.Text = Lote.CKI.ToString("N4")
            txtDiasCabeza.Text = Lote.DiasCabeza.ToString("N4")
            dgvFormulasAplicadas.DataSource = Lote.FormulasAplicadas
            dgvMedicamentosAplicados.DataSource = Lote.MedicamentosAplicados
        End If
    End Sub

    Private Sub cmbLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.TextChanged
        If sender.Text = "" Then
            Limpiar()
        End If
    End Sub

#End Region

End Class