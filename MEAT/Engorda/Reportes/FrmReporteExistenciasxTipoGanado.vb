Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteExistenciasxTipoGanado

#Region "Miembros"

#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        ActualizarCombos()
    End Sub

    Private Sub ActualizarCombos()
        Dim TiposGanado As CC.McgcatTiposdeGanadoCollection = Controlador.ObtenerTiposGanado(CondicionEnum.ACTIVOS)
        TiposGanado.Insert(0, New EC.McgcatTiposdeGanadoEntity())
        TiposGanado(0).Descripcion = "TODOS"

        cmbTipoGanado.DisplayMember = "Descripcion"
        cmbTipoGanado.ValueMember = "IdTipoGanado"
        cmbTipoGanado.DataSource = TiposGanado
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Imprimir()
        Dim TipoGanado As TipoGanadoClass = Nothing

        If cmbTipoGanado.SelectedIndex <> -1 AndAlso CType(cmbTipoGanado.SelectedValue, Integer) <> 0 Then
            TipoGanado = New TipoGanadoClass(CType(cmbTipoGanado.SelectedItem, EC.McgcatTiposdeGanadoEntity))
        End If
        Controlador.ReporteExistenciasxTipoGanado(TipoGanado)
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

    Private Sub cmbTipoGanado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipoGanado.KeyDown
        ActualizarCombos()
    End Sub

#End Region

End Class