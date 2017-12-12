Imports ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmRptEmisionPolizas
#Region "Miembros"

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        dtpFechaInicial.Value = Now.Date
        dtpFechaFinal.Value = Now.Date
        cmbTipoPoliza.SelectedIndex = 4
        cmbTipoImpresion.SelectedIndex = 0
    End Sub

    Private Function Imprimir() As Boolean
        If Me.Validate() Then
            Dim Filtro As New OC.PredicateExpression(New OC.FieldBetweenPredicate(HC.PolizaFields.FechaPoliza, dtpFechaInicial.Value, dtpFechaFinal.Value.AddDays(0.99999)))
            Dim TipoPoliza As String = ""

            Select Case cmbTipoPoliza.SelectedText
                Case "CANCELACION"
                    TipoPoliza = Chr(PolizaTipoPolizaEnum.CANCELACION)
                Case "DIARIO"
                    TipoPoliza = Chr(PolizaTipoPolizaEnum.DIARIO)
                Case "EGRESO"
                    TipoPoliza = Chr(PolizaTipoPolizaEnum.EGRESO)
                Case "INGRESO"
                    TipoPoliza = Chr(PolizaTipoPolizaEnum.INGRESO)
            End Select

            If TipoPoliza <> String.Empty Then
                Filtro.Add(HC.PolizaFields.TipoPoliza = TipoPoliza)
            End If
            PolizaCollectionClass.Imprimir(Controlador.Sesion, IIf(cmbTipoImpresion.SelectedItem = "NORMAL", PolizaCollectionClass.TipoReporte.Emision_de_Polizas, PolizaCollectionClass.TipoReporte.Emision_de_Polizas_por_Pagina), Filtro)
        End If
    End Function
#End Region

#Region "Eventos"

#End Region

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick
        If e.Button.Text = "Limpiar" Then
            Limpiar()
        ElseIf e.Button.Text = "Imprimir" Then
            Imprimir()
        ElseIf e.Button.Text = "Salir" Then
            Me.AutoValidate = Windows.Forms.AutoValidate.Disable
            Me.Close()
        End If
    End Sub

    Private Sub FrmRptDiariosPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub dtpFechaInicial_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaInicial.Validating
        If dtpFechaInicial.Value.Ticks > dtpFechaFinal.Value.Ticks Then
            e.Cancel = True
            MsgBox("La Fecha Final no puede ser menor que la Fecha Inicial", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
        End If
    End Sub
End Class