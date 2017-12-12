Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class MedicamentoReimplanteCollectionClass
    Inherits ColleccionBase(Of EC.CabMediReimEntity, CC.CabMediReimCollection, MedicamentoReimplanteClass)

    Public Function Guardar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Medicamento Trabajo")

        Try
            Dim medicamentosBD As New CC.CabMediReimCollection
            Dim encontro As Boolean = False

            trans.Add(medicamentosBD)
            medicamentosBD.GetMulti(Nothing)

            If medicamentosBD.Count > 0 Then
                medicamentosBD.DeleteMulti()

                For Each medicamentoGuardar As MedicamentoReimplanteClass In Me
                    medicamentoGuardar.Entidad.IsNew = True

                    With medicamentoGuardar
                        .Nombre = .Nombre
                        .IdMedicamento = .IdMedicamento
                        .Entidad.BooXcab = .Entidad.BooXcab
                        .Entidad.BooXkilo = .Entidad.BooXkilo
                        .CantidadXCabeza = .CantidadXCabeza
                        .CantidadXKilo = .CantidadXKilo
                    End With

                    medicamentoGuardar.Guardar(trans)
                Next
            Else
                For Each medicamento As MedicamentoReimplanteClass In Me
                    medicamento.Guardar(trans)
                Next
            End If

            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub Imprimir(ByVal empresa As String, ByVal usuario As String)
        Try
            Dim prev As New PreVisualizarForm
            Dim rpt As New rptMedicamentosTrabajo

            rpt.SetDataSource(Me)
            rpt.SetParameterValue(0, empresa)
            rpt.SetParameterValue(1, "Reporte Medicamentos de Reimplante")
            rpt.SetParameterValue(2, usuario)
            rpt.SetParameterValue(3, "Manejo de Engorda/Reportes/Medicamentos/Trabajo")

            prev.Reporte = rpt
            prev.Text = "Reporte Medicamentos de Reimplante"

            prev.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class