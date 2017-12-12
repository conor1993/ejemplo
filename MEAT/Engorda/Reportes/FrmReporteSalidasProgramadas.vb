Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteSalidasProgramadas

#Region "Miembros"

#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        ActualizarCombos()
    End Sub

    Private Sub ActualizarCombos()
        Dim Corrales As CC.McecatCorralesCabCollection = Controlador.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.ENGORDA, EstatusAutorizada.TODAS, EstatusAutorizada.SI)
        Corrales.Insert(0, New EC.McecatCorralesCabEntity())
        Corrales(0).NombreCorral = "TODOS"
        Corrales(0).IdCorral = "TODOS"

        cmbCorral.DisplayMember = "NombreCorral"
        cmbCorral.ValueMember = "IdCorral"
        cmbCorral.DataSource = Corrales
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Imprimir()
        Dim Corral As CorralClass = Nothing

        If cmbCorral.SelectedIndex <> -1 AndAlso cmbCorral.SelectedValue.ToString <> "TODOS" Then
            Corral = New CorralClass(CType(cmbCorral.SelectedItem, EC.McecatCorralesCabEntity))
        End If
        Controlador.ReporteSalidasProgramadas(Corral)
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub FrmCorReporteDeExistenciasYCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub cmbCorral_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCorral.KeyDown
        If e.KeyCode = Keys.F12 Then
            ActualizarCombos()
        End If
    End Sub

#End Region

End Class