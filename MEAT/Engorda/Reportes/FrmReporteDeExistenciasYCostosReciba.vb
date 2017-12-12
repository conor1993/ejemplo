Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteDeExistenciasYCostosReciba

#Region "Miembros"

#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        ActualizarCombos()
    End Sub

    Private Sub ActualizarCombos()
        Dim Corrales As CC.McecatCorralesCabCollection = Controlador.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.RECIBA)
        Corrales.Insert(0, New EC.McecatCorralesCabEntity())
        Corrales(0).NombreCorral = "TODOS"
        Corrales(0).IdCorral = "TODOS"

        cmbRecepcion.DisplayMember = "NombreCorral"
        cmbRecepcion.ValueMember = "IdCorral"
        cmbRecepcion.DataSource = Corrales
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Imprimir()
        Dim Corral As EC.McecatCorralesCabEntity = Nothing

        If cmbRecepcion.SelectedIndex <> -1 AndAlso cmbRecepcion.SelectedValue <> "TODOS" Then
            Corral = CType(cmbRecepcion.SelectedItem, EC.McecatCorralesCabEntity)
        End If
        Controlador.ReporteExistenciasYCostosRecepcion(Corral)
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

    Private Sub cmbRecepcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRecepcion.KeyDown
        If e.KeyCode = Keys.F12 Then
            ActualizarCombos()
        End If
    End Sub

#End Region

End Class