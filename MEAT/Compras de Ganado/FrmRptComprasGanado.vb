Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class FrmRptComprasGanado

#Region "Metodos"
    Private Sub Imprimir()
        Dim filtro As New OC.PredicateExpression
        Dim filtroDetalle As New OC.PredicateExpression
        Dim busquedaDetalle As New TC.VwBusquedaComprasGanadoDetalleTypedView
        Dim dst As New ClasesNegocio.DsRptComprasGanado
        Dim tbCab As DsRptComprasGanado.CabeceroDataTable = dst.Tables(0)
        Dim tbDet As DsRptComprasGanado.DetalleDataTable = dst.Tables(1)
        Dim folios As New Dictionary(Of String, DsRptComprasGanado.CabeceroRow)

        If Me.txtFolioCompra.Text.Trim = "" Then
            If Me.cmbComprador.SelectedIndex > -1 Then
                filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdCompradorGanado = CInt(Me.cmbComprador.SelectedValue))
                filtroDetalle.Add(HC.VwBusquedaComprasGanadoDetalleFields.CveComiGan = CInt(Me.cmbComprador.SelectedValue))
            End If

            If Me.cmbProveedor.SelectedIndex > -1 Then
                filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdProveedor = CInt(Me.cmbProveedor.SelectedValue))
                filtroDetalle.Add(HC.VwBusquedaComprasGanadoDetalleFields.CveProveGan = CInt(Me.cmbProveedor.SelectedValue))
            End If

            If Me.cmbLugarCompra.SelectedIndex > -1 Then
                filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdLugarCompra = CInt(Me.cmbLugarCompra.SelectedValue))
                filtroDetalle.Add(HC.VwBusquedaComprasGanadoDetalleFields.CveLugCom = CInt(Me.cmbLugarCompra.SelectedValue))
            End If

            If Me.cmbCorral.SelectedIndex > -1 Then
                filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdCorral = Me.cmbCorral.SelectedValue)
                filtroDetalle.Add(HC.VwBusquedaComprasGanadoDetalleFields.CveCorral = Me.cmbCorral.SelectedValue)
            End If

            If Me.chkFiltrar.Checked Then
                filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaComprasdeGanadoFields.FechaRecepcionCompra, _
                                        Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
                filtroDetalle.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaComprasGanadoDetalleFields.FecRecep, _
                                                        Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            If Not (Me.chkCanceladas.Checked And Me.chkVigentes.Checked) Then
                If Me.chkCanceladas.Checked Then
                    filtro.Add(HC.VwBusquedaComprasdeGanadoFields.Status = Chr(EstatusChar.CANCELADO))
                    filtroDetalle.Add(HC.VwBusquedaComprasGanadoDetalleFields.Status = Chr(EstatusChar.CANCELADO))
                Else
                    filtro.Add(HC.VwBusquedaComprasdeGanadoFields.Status = Chr(EstatusChar.VIGENTE))
                    filtroDetalle.Add(HC.VwBusquedaComprasGanadoDetalleFields.Status = Chr(EstatusChar.VIGENTE))
                End If
            End If
        Else
            filtro.Add(HC.VwBusquedaComprasdeGanadoFields.FolioRecepcionCompra Mod String.Format("%{0}%", Me.txtFolioCompra.Text.Trim))
            filtroDetalle.Add(HC.VwBusquedaComprasGanadoDetalleFields.FolioRecepcionCompra Mod String.Format("%{0}%", Me.txtFolioCompra.Text.Trim))
        End If

        Me.busquedaRecepcionCompras.Clear()
        Me.busquedaRecepcionCompras.Fill(0, Nothing, False, filtro)
        busquedaDetalle.Fill(0, Nothing, False, filtroDetalle)

        For Each row As TC.VwBusquedaComprasdeGanadoRow In Me.busquedaRecepcionCompras
            folios.Add(row.FolioRecepcionCompra.Trim, tbCab.AddCabeceroRow(row.FolioRecepcionCompra, row.FechaRecepcionCompra, row.Proveedor, row.CabezasComp, row.KilosComp, row.ImpteComp, row.CompradorGanado, row.LugarCompra, row.Corral, row.CostosIndi, row.ImpteComp + row.CostosIndi, row.EstatusStr))
        Next

        Dim renglon As Integer = 0

        For Each row As TC.VwBusquedaComprasGanadoDetalleRow In busquedaDetalle
            tbDet.AddDetalleRow(folios(row.FolioRecepcionCompra), renglon, row.IdTipoGanado, row.TipoGanado, row.Cabezas, row.KilosRecibidos, row.PrecioXkilo, row.KilosPromedioPorCabeza, row.Importe, row.CostoPromedioXcabeza)
            renglon += 1
        Next

        Dim reporte As New CrRptComprasGanado
        Dim prev As New PreVisualizarForm

        reporte.SetDataSource(dst)
        reporte.SetParameterValue(0, "Compras de Ganado/Reportes/Compras de Ganado")
        reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
        reporte.SetParameterValue(2, Controlador.Sesion.MiEmpresa.Empnom)

        prev.Text = "Reporte de Compras de Ganado"
        prev.Reporte = reporte

        prev.ShowDialog()
    End Sub
#End Region

#Region "Eventos"
#Region "ComboBox"
    Private Sub cmbProveedor_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.ActualizarCombo
        Try
            Me.cmbProveedor.DataSource = CC.ProveedorCollection.GetMultiAsDataTable(Nothing, 0, _
                                New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.ValueMember = "Codigo"
            Me.cmbProveedor.SelectedIndex = -1
            Me.cmbProveedor.Text = "Seleccione un proveedor"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbComprador_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComprador.ActualizarCombo
        Try
            Me.cmbComprador.DataSource = CC.McgcatCompradoresdeGanadoCollection.GetMultiAsDataTable(Nothing, 0, _
                                        New OC.SortExpression(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.Nombre, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbComprador.ValueMember = "IdComprador"
            Me.cmbComprador.DisplayMember = "Nombre"
            Me.cmbComprador.SelectedIndex = -1
            Me.cmbComprador.Text = "Seleccione un comprador"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbCorral_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCorral.ActualizarCombo
        Try
            Me.cmbCorral.DataSource = CC.McecatCorralesCabCollection.GetMultiAsDataTable(HC.McecatCorralesCabFields.TipoCorral = _
                                        TipoCorral.RECIBA, 0, _
                                        New OC.SortExpression(New OC.SortClause(HC.McecatCorralesCabFields.NombreCorral, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbCorral.DisplayMember = "NombreCorral"
            Me.cmbCorral.ValueMember = "IdCorral"
            Me.cmbCorral.SelectedIndex = -1
            Me.cmbCorral.Text = "Seleccione un corral"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbLugarCompra_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLugarCompra.ActualizarCombo
        Try
            Me.cmbLugarCompra.DataSource = CC.CatLugaresDeCompraCollection.GetMultiAsDataTable(Nothing, 0, _
                                            New OC.SortExpression(New OC.SortClause(HC.CatLugaresDeCompraFields.Descripcion, _
                                            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbLugarCompra.DisplayMember = "Descripcion"
            Me.cmbLugarCompra.ValueMember = "IdLugarCompra"
            Me.cmbLugarCompra.SelectedIndex = -1
            Me.cmbLugarCompra.Text = "Seleccione un lugar de compra"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ChekBox"
    Private Sub chkVigentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged
        If Not Me.chkCanceladas.Checked AndAlso Not Me.chkVigentes.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkVigentes.Checked = True
        End If
    End Sub

    Private Sub chkCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCanceladas.CheckedChanged
        If Not Me.chkCanceladas.Checked AndAlso Not Me.chkVigentes.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkVigentes.Checked = True
        End If
    End Sub

    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        If Me.chkFiltrar.Checked Then
            Me.DtpFechaIni.Value = Now
            Me.DtpFechaFin.Value = Now
        End If
        Me.DtpFechaIni.Enabled = Me.chkFiltrar.Checked
        Me.DtpFechaFin.Enabled = Me.chkFiltrar.Checked
    End Sub
#End Region

#Region "Form"
    Private Sub FrmRptComprasGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.cmbLugarCompra.OnActualizaCombo()
            Me.cmbComprador.OnActualizaCombo()
            Me.cmbCorral.OnActualizaCombo()
            Me.cmbProveedor.OnActualizaCombo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Try
            Imprimir()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        txtFolioCompra.ResetText()
        Me.cmbLugarCompra.OnActualizaCombo()
        Me.cmbComprador.OnActualizaCombo()
        Me.cmbCorral.OnActualizaCombo()
        Me.cmbProveedor.OnActualizaCombo()
        chkFiltrar.Checked = False
        chkVigentes.Checked = True
        chkCanceladas.Checked = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub
#End Region
#End Region

End Class