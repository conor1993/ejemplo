Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteSalidasProgramadasxSem

#Region "Miembros"

#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        ultdtpFechaInicial.Value = Date.Today
    End Sub

    Private Sub ActualizarFechas()
        If ultdtpFechaInicial.Value IsNot Nothing AndAlso ultdtpFechaInicial.Value.GetType Is GetType(Date) _
        AndAlso ultnumNoSemanas.Value IsNot Nothing Then
            ultdtpFechaFinal.Value = CType(ultdtpFechaInicial.Value, Date).AddDays(CType(ultnumNoSemanas.Value, Integer) * 7).AddTicks(-1)
        End If
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Imprimir()
        Controlador.ReporteSalidasProgramadasxSemanas(CType(ultdtpFechaInicial.Value, Date), CType(ultdtpFechaFinal.Value, Date))
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Tool Bar"

    Private Sub FrmCorReporteDeExistenciasYCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub ultdtpFechaInicial_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ultdtpFechaInicial.ValueChanged
        ActualizarFechas()
    End Sub

    Private Sub ultnumNoSemanas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultnumNoSemanas.ValueChanged
        ActualizarFechas()
    End Sub

#End Region

End Class