Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteLotesCerrados

#Region "Miembros"

#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        ultdtpFechaInicial.Value = Date.Today
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Imprimir()
        Controlador.ReporteLotesCerrados(CType(ultdtpFechaInicial.Value, Date))
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

    Private Sub ultdtpFechaInicial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ultdtpFechaInicial.KeyDown
        If ultdtpFechaInicial IsNot Nothing Then
            If e.Shift AndAlso (e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down) Then
                Dim Incremento As Integer = 1

                If e.KeyCode = Keys.Down Then
                    Incremento = -1
                End If
                ultdtpFechaInicial.Value = CType(ultdtpFechaInicial.Value, Date).AddYears(Incremento)
                e.Handled = True
            End If
        End If
    End Sub

#End Region

End Class