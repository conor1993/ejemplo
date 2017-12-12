Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmReportesProduccion
    Dim reportes As New ReportesClass
    Private Sub FrmReportesProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'llenar productos para decomisos
            'Me.cmbProductores.DataSource = CD.CatProveedoresCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Me.cmbProductores.DisplayMember = "Nombre"
            Me.cmbProductores.ValueMember = "IdProveedor"
            Me.cmbProductores.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Function Imprimir() As Boolean
        Try
            If Me.optRecepcion.Checked Then
                Dim Recepciones As DataSet
                Recepciones = reportes.ObtenerRecepcion(1, Me.cmbProductores.SelectedValue)
                Dim DatosRecepcion As New dsRecepcionGanado
                For Each Renglon As DataRow In Recepciones.Tables(0).Rows
                    '  DatosRecepcion.DtRecepcionGanado.AddDataTable1Row(Renglon("LoteRecepcion"), Renglon("FechaRecepcion"), Renglon("Productor"), Renglon("Cabezas"), Renglon("KilosEnviados"), Renglon("KilosRecibidos"), Renglon("Diferencia"))
                Next
                Dim Reporte As New crRecepcionGanado
                Reporte.SetDataSource(Recepciones)
                Dim VerReporte As New FrmReportes
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()

            End If
            If Me.optRegistro.Checked Then
                Dim Sacrificios As DataSet
                Sacrificios = reportes.ObtenerSacrificios(1, Me.cmbProductores.SelectedValue)
                Dim Datos As New dsRegistroSacrificios
                'For Each Renglon As DataRow In Sacrificios.Rows(0).Table.Rows
                '    Datos.DataTable1.AddDataTable1Row(Renglon("LoteSacrificio"), Renglon("FechaSacrificio"), Renglon("Productor"), Renglon("Sacrificadas"), Renglon("KilosEnPie"), Renglon("SinSacrificar"), Renglon("KilosSacrificio"), Renglon("Rendimiento"))
                'Next
                Dim Reporte As New crRegistroSacrificios
                Reporte.SetDataSource(Sacrificios)
                Dim VerReporte As New FrmReportes
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()

            End If
            If Me.optCanales.Checked Then
                Dim Sacrificios As DataSet
                Sacrificios = reportes.ObtenerCanales(1, Me.cmbProductores.SelectedValue)
                Dim Datos As New dsCanales
                'For Each Renglon As DataRow In Sacrificios.Rows(0).Table.Rows
                '    Datos.DataTable1.AddDataTable1Row(Renglon("LoteSacrificio"), Renglon("Productor"), Renglon("FolioCanal"), Renglon("KilosCalientes"), Renglon("KilosFrios"), Renglon("Rendimiento"), Renglon("LoteCorte"))
                'Next
                Dim Reporte As New crCanales
                Reporte.SetDataSource(Sacrificios)
                Dim VerReporte As New FrmReportes
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()

            End If
            If Me.optCortes.Checked Then
                Dim Sacrificios As DataSet
                Sacrificios = reportes.ObtenerCortes(1, Me.cmbProductores.SelectedValue)
                Dim Datos As New dsCortes
                'For Each Renglon As DataRow In Sacrificios.Rows(0).Table.Rows
                '    Datos.DataTable1.AddDataTable1Row(Renglon("FolioEtiqueta"), Renglon("Descripcion"), Renglon("Piezas"), Renglon("Kilos"), Renglon("LoteCorte"), Renglon("LoteSacrificio"), Renglon("Productor"))
                'Next
                Dim Reporte As New crCortes
                Reporte.SetDataSource(Sacrificios)
                Dim VerReporte As New FrmReportes
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Me.Imprimir()
    End Sub
End Class