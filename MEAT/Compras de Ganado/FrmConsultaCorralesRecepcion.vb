Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmConsultaCorralesRecepcion

#Region "Miembros"

#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        Controlador.LlenarComboCorralesRecepcion(cmbCorralRecepcion)
    End Sub

    Private Sub ActualizarCorral(ByVal Corral As CorralClass)
        txtCabezas.Text = Corral.TotalCabezas.ToString("N0")
        txtKilos.Text = Corral.TotalKilos.ToString("N2")
        txtEntradas.Text = Corral.CostoEntradas.ToString("C2")
        txtAlimentos.Text = Corral.CostoAlimmentos.ToString("C2")
        txtMedicamentos.Text = Corral.CostoMedicamentos.ToString("C2")
        txtTotal.Text = Corral.CostoTotal.ToString("C2")
        txtCostoxKilo.Text = Corral.CostoxKilo.ToString("C2")
        txtCostoxCabeza.Text = Corral.CostoxCabeza.ToString("C2")

        If Corral.FechaUltimaEntrada.HasValue Then
            txtUltEntrada.Text = Corral.FechaUltimaEntrada.Value.Day.ToString().PadLeft(2, "0") & "/" & Controlador.Culture.DateTimeFormat.GetAbbreviatedMonthName(Corral.FechaUltimaEntrada.Value.Month).ToUpper & "/" & Corral.FechaUltimaEntrada.Value.Year
        Else
            txtUltEntrada.Text = ""
        End If

        If Corral.FechaUltimaSalida.HasValue Then
            txtUltSalida.Text = Corral.FechaUltimaSalida.Value.Day.ToString().PadLeft(2, "0") & "/" & Controlador.Culture.DateTimeFormat.GetAbbreviatedMonthName(Corral.FechaUltimaSalida.Value.Month).ToUpper & "/" & Corral.FechaUltimaSalida.Value.Year
        Else
            txtUltSalida.Text = ""
        End If

        If Corral.FechaUltimoReinicio.HasValue Then
            txtUltReinicio.Text = Corral.FechaUltimoReinicio.Value.Day.ToString().PadLeft(2, "0") & "/" & Controlador.Culture.DateTimeFormat.GetAbbreviatedMonthName(Corral.FechaUltimoReinicio.Value.Month).ToUpper & "/" & Corral.FechaUltimoReinicio.Value.Year
        Else
            txtUltReinicio.Text = ""
        End If
    End Sub
#End Region

#Region "Acciones_Menu"
    Public Sub Limpiar()
        cmbCorralRecepcion.SelectedIndex = -1
        cmbCorralRecepcion.Text = "Seleccione el Corral de Recepcion"
        txtCabezas.ResetText()
        txtKilos.ResetText()
        txtEntradas.ResetText()
        txtAlimentos.ResetText()
        txtMedicamentos.ResetText()
        txtTotal.ResetText()
        txtCostoxKilo.ResetText()
        txtCostoxCabeza.ResetText()
        txtUltEntrada.ResetText()
        txtUltSalida.ResetText()
        txtUltReinicio.ResetText()
    End Sub

    Public Sub Imprimir()
        Controlador.ImpresionCorrales(cmbCorralRecepcion.SelectedValue)
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub cmbCorralRecepcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCorralRecepcion.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboCorralesRecepcion(sender)
        End If
    End Sub

    Private Sub cmbCorralRecepcion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCorralRecepcion.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            ActualizarCorral(New CorralClass(CType(sender.SelectedItem, EC.McecatCorralesCabEntity)))
        Else
            Limpiar()
        End If
    End Sub

    Private Sub FrmConsultaCorralesRecepcion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub
#End Region

End Class
