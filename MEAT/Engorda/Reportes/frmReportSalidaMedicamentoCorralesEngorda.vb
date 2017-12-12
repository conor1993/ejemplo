Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class frmReportSalidaMedicamentoCorralesEngorda
    Private cambiandoCheckBox As Boolean = False

    Private Sub cmbLote_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.ActualizarCombo
        Try
            Me.cmbLote.DataSource = CC.McecatLotesCabCollection.GetMultiAsDataTable( _
                                        HC.McecatLotesCabFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO, _
                                        0, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.NombreLote, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbLote.DisplayMember = "NombreLote"
            Me.cmbLote.ValueMember = "IdLote"
            Me.cmbLote.SelectedIndex = -1
            Me.cmbLote.Text = "Seleccione un Lote"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked Then
            Me.CambiarValorCheckBox(True)
        End If
    End Sub

    Private Sub frmReportSalidaMedicamentoCorralesEngorda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each check As CheckBox In Me.gbTipoReporte.Controls
            AddHandler check.CheckedChanged, AddressOf CheckedChanged
        Next

        Me.cmbLote.OnActualizaCombo()
    End Sub

    Private Sub CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.cambiandoCheckBox Then Exit Sub

        If Not Me.chkAplicacionMedicamento.Checked AndAlso Not Me.chkMedicamentoAplicacion.Checked AndAlso _
             Not Me.chkMedicamentoProrrateo.Checked AndAlso Not Me.chkProrrateoMedicamento.Checked Then
            Me.CambiarValorCheckBox(True)
        ElseIf Me.chkAplicacionMedicamento.Checked AndAlso Me.chkMedicamentoAplicacion.Checked AndAlso _
             Me.chkMedicamentoProrrateo.Checked AndAlso Me.chkProrrateoMedicamento.Checked Then
            Me.chkTodos.Checked = True
        Else
            Me.chkTodos.CheckState = CheckState.Indeterminate
        End If
    End Sub

    Private Sub CambiarValorCheckBox(ByVal valor As Boolean)
        Me.cambiandoCheckBox = True
        For Each control As CheckBox In Me.gbTipoReporte.Controls
            control.Checked = valor
        Next

        Me.cambiandoCheckBox = False
    End Sub

    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        Me.gbRangoFechas.Enabled = Me.chkFiltrar.Checked

        If Me.chkFiltrar.Checked Then
            Me.dtFechaFin.Value = Now
            Me.dtFechaInicio.Value = Now
        End If
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor

        Dim sqlCon As SqlClient.SqlConnection = HC.DbUtils.CreateConnection

        Try
            Dim ventana As New ClasesNegocio.PreVisualizarForm
            Dim rptAplicacionMedicamento As New ClasesNegocio.rptSalidaMedicamentoAplicacionMedicamento
            Dim rptMedicamentosAplicaion As New ClasesNegocio.rptSalidaMedicamentoMedicamentosAplicacion
            Dim rptProrrateoMedicamento As New ClasesNegocio.rptSalidaMedicamentoProrrateoMedicamento
            Dim rptMedicamentoProrrateo As New ClasesNegocio.rptSalidaMedicamentoMedicamentoProrrateo

            ventana.Text = "Reporte Salidas de Medicamentos a Corrales de Engorda"

            If Me.chkAplicacionMedicamento.Checked Then
                rptAplicacionMedicamento.SetDataSource(Me.AplicacionMedicamento(sqlCon))

                With rptAplicacionMedicamento
                    .SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    .SetParameterValue(1, "Manejo de Ganado/Reportes/Medicamentos/Salidas a Corrales de Engorda")
                    .SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                End With

                ventana.Reporte = rptAplicacionMedicamento
                ventana.ShowDialog()
            End If

            If Me.chkMedicamentoAplicacion.Checked Then
                rptMedicamentosAplicaion.SetDataSource(Me.AplicacionMedicamento(sqlCon))

                With rptMedicamentosAplicaion
                    .SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    .SetParameterValue(1, "Manejo de Ganado/Reportes/Medicamentos/Salidas a Corrales de Engorda")
                    .SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                End With

                ventana.Reporte = rptMedicamentosAplicaion
                ventana.ShowDialog()
            End If

            If Me.chkProrrateoMedicamento.Checked Then
                rptProrrateoMedicamento.SetDataSource(Me.ProrrateoMedicamento(sqlCon))

                With rptProrrateoMedicamento
                    .SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    .SetParameterValue(1, "Manejo de Ganado/Reportes/Medicamentos/Salidas a Corrales de Engorda")
                    .SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                End With

                ventana.Reporte = rptProrrateoMedicamento
                ventana.ShowDialog()
            End If

            If Me.chkMedicamentoProrrateo.Checked Then
                rptMedicamentoProrrateo.SetDataSource(Me.ProrrateoMedicamento(sqlCon))

                With rptMedicamentoProrrateo
                    .SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    .SetParameterValue(1, "Manejo de Ganado/Reportes/Medicamentos/Salidas a Corrales de Engorda")
                    .SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                End With

                ventana.Reporte = rptMedicamentoProrrateo
                ventana.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If

            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        Try
            Me.cmbLote.SelectedIndex = -1
            Me.cmbLote.Text = "Seleccione un lote"
            Me.chkFiltrar.Checked = False
            Me.chkTodos.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

    Private Function AplicacionMedicamento(ByVal sqlCon As SqlClient.SqlConnection) As DataTable
        AplicacionMedicamento = New DataTable

        Dim sqlCom As New SqlClient.SqlCommand("SELECT      AplicMediDet.FolioAplicacionMedicamento AS Aplicacion, " & _
                                                   "            AplicMedi.FechaAplicacionMedicamento AS Fecha, " & _
                                                   "            AplicMediDet.Cantidad, " & _
                                                   "            AplicMediDet.CosProm AS CostoUnitario, " & _
                                                   "            AplicMediDet.Importe, MCECatLotesCab.NombreLote AS Lote, " & _
                                                   "            MCECatCorralesCab.NombreCorral AS Corral, " & _
                                                   "            MCatCompProductos.PdDescripcion AS Medicamento, " & _
                                                   "            MCatCompUnidadMedida.UMDescripcion AS Unidad " & _
                                                   "FROM        AplicMediDet INNER JOIN MCatCompProductos ON " & _
                                                   "            AplicMediDet.IdMedicamento = MCatCompProductos.PdIdProducto " & _
                                                   "            INNER JOIN MCECatLotesCab ON AplicMediDet.IdLote = " & _
                                                   "            MCECatLotesCab.IdLote INNER JOIN MCECatCorralesCab ON " & _
                                                   "            AplicMediDet.IdCorral = MCECatCorralesCab.IdCorral " & _
                                                   "            INNER JOIN AplicMedi ON AplicMediDet.FolioAplicacionMedicamento = " & _
                                                   "            AplicMedi.FolioAplicacionMedicamento INNER JOIN " & _
                                                   "            MCatCompUnidadMedida ON MCatCompProductos.PdIdUnidadMedida = " & _
                                                   "            MCatCompUnidadMedida.UMIdUnidadMedida", sqlCon)
        Dim sqlDa As New SqlClient.SqlDataAdapter(sqlCom)
        Dim reporte As New ClasesNegocio.rptAplicacionMedicamentoPorLote

        If Me.cmbLote.SelectedIndex > -1 Then
            If Me.chkFiltrar.Checked Then
                sqlCom.CommandText &= " WHERE AplicMediDet.IdLote = " & CInt(Me.cmbLote.SelectedValue)
                sqlCom.CommandText &= String.Format(" AND AplicMedi.FechaAplicacionMedicamento BETWEEN '{0}' AND '{1}'", Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString)
            Else
                sqlCom.CommandText &= " WHERE AplicMediDet.IdLote = " & CInt(Me.cmbLote.SelectedValue)
            End If
        ElseIf Me.chkFiltrar.Checked Then
            sqlCom.CommandText &= String.Format(" WHERE AplicMedi.FechaAplicacionMedicamento BETWEEN '{0}' AND '{1}'", Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString)
        End If

        sqlDa.Fill(AplicacionMedicamento)
    End Function

    Private Function ProrrateoMedicamento(ByVal sqlCon As SqlClient.SqlConnection) As DataTable
        ProrrateoMedicamento = New DataTable

        Dim cadenaConsulta As String
        Dim sqlCom As New SqlClient.SqlCommand("", sqlCon)
        Dim da As New SqlClient.SqlDataAdapter(sqlCom)

        cadenaConsulta = "SELECT        CabProMed.FolioProrrateoMedicamento AS Prorrateo, " & _
                         "              MCECatLotesCab.NombreLote AS Lote, " & _
                         "              MCECatCorralesCab.NombreCorral AS Corral, " & _
                         "              CabProMed.FechaProrrateo, DetDProMed.IdLote, " & _
                         "              DetDProMed.CostoXMedi AS Importe, " & _
                         "              MCatCompProductos.PdDescripcion AS Medicamento " & _
                         "FROM          CabProMed INNER JOIN " & _
                         "              DetDProMed ON CabProMed.FolioProrrateoMedicamento = " & _
                         "              DetDProMed.FolioProrrateoMedicamento INNER JOIN " & _
                         "              MCECatLotesCab ON DetDProMed.IdLote = MCECatLotesCab.IdLote INNER JOIN " & _
                         "              MCatCompProductos ON DetDProMed.IdMedicamento = " & _
                         "              MCatCompProductos.PdIdProducto INNER JOIN " & _
                         "              MCECatCorralesCab ON MCECatLotesCab.IdCorral = " & _
                         "              MCECatCorralesCab.IdCorral INNER JOIN " & _
                         "              MCatCompUnidadMedida ON MCatCompProductos.PdIdUnidadMedida = " & _
                         "              MCatCompUnidadMedida.UMIdUnidadMedida"

        If Me.cmbLote.SelectedIndex > -1 Then
            If Me.chkFiltrar.Checked Then
                cadenaConsulta &= " WHERE DetDProMed.IdLote = " & CInt(Me.cmbLote.SelectedValue)
                cadenaConsulta &= String.Format(" AND CabProMed.FechaProrrateo BETWEEN '{0}' AND '{1}'", _
                                    Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString)
            Else
                cadenaConsulta &= " WHERE DetDProMed.IdLote = " & CInt(Me.cmbLote.SelectedValue)
            End If
        ElseIf Me.chkFiltrar.Checked Then
            cadenaConsulta &= String.Format(" WHERE CabProMed.FechaProrrateo BETWEEN '{0}' AND '{1}'", _
                            Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString)
        End If

        sqlCom.CommandText = cadenaConsulta

        da.Fill(ProrrateoMedicamento)
    End Function
End Class