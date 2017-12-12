Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmReporteEmbarquesxDestinosyCliente

#Region "Miembros"

#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        Controlador.LlenarComboClientes(cmbCliente, EstatusChar.TODOS, True)
        Limpiar()
        ultdgvDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        AddHandler cmbCliente.SelectedIndexChanged, AddressOf cmbCliente_SelectedIndexChanged
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Limpiar()
        cmbCliente.SelectedIndex = -1
        cmbCliente.Text = "Seleccione el Cliente"
        dtpFechaInicial.Value = Now
        dtpFechaFinal.Value = Now
        chkRangoFechas.Checked = False
        btnExportar.Enabled = False
    End Sub

    Public Sub Buscar()
        Dim RangoDeFechas As RangoFechas = Nothing

        ultdgvDetalle.DataSource = Nothing
        btnExportar.Enabled = False

        If cmbCliente.SelectedIndex <> -1 Then
            If chkRangoFechas.Checked Then
                If dtpFechaInicial.Value.Date.Ticks > dtpFechaFinal.Value.Date.Ticks Then
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 10)
                End If
                RangoDeFechas = New RangoFechas(dtpFechaInicial.Value, dtpFechaFinal.Value)
            End If
            ultdgvDetalle.DataSource = Controlador.ReporteEmbarquesxDestinosyCliente(CType(cmbCliente.SelectedValue, Integer), RangoDeFechas)
            ultdgvDetalle.DisplayLayout.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            ultdgvDetalle.DisplayLayout.Bands(0).Columns(0).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            btnExportar.Enabled = IIf(ultdgvDetalle.Rows.Count > 0, True, False)
        End If
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub FrmCorReporteDeExistenciasYCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar, mtb.ClickSalir, mtb.ClickLimpiar
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub chkRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRangoFechas.CheckedChanged
        dtpFechaInicial.Enabled = chkRangoFechas.Checked
        dtpFechaFinal.Enabled = chkRangoFechas.Checked
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Utilerias.RunControlException(Me, "Buscar")
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim Archivo As New SaveFileDialog
        Archivo.Title = "Exportar a Excel"
        Archivo.Filter = "Archivos de Excel | *.xls"

        If Archivo.ShowDialog() = Windows.Forms.DialogResult.OK AndAlso Archivo.FileName IsNot Nothing AndAlso Archivo.FileName.Trim <> String.Empty Then
            Dim Documento As New Infragistics.Excel.Workbook
            UltraGridExcelExporter1.Export(ultdgvDetalle, Documento)
            Documento.Worksheets(0).Name = cmbCliente.Text
            Documento.Save(Archivo.FileName)
            Process.Start(Archivo.FileName)
        End If
    End Sub

#End Region

End Class