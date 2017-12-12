Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = Integralab.ORM.TypedViewClasses

Public Class frmReporteFacturacionXCliente
    Private Sub LlenarCombo()
        Try
            Dim campos As New HC.ResultsetFields(2)
            Dim tb As New DataTable
            Dim tv As New Integralab.ORM.DaoClasses.TypedListDAO

            campos.DefineField(HC.MfacCatClientesFields.IdCliente, 0)
            campos.DefineField(HC.MfacCatClientesFields.Nombre, 1)

            tv.GetMultiAsDataTable(campos, tb, 0, New OC.SortExpression(New OC.SortClause(HC.MfacCatClientesFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), HC.MfacCatClientesFields.Estatus = 1, Nothing, True, Nothing, Nothing, 0, 0)

            Me.cmbCliente.DataSource = tb
            Me.cmbCliente.DisplayMember = "Nombre"
            Me.cmbCliente.ValueMember = "IdCliente"
            Me.cmbCliente.SelectedIndex = -1
            Me.cmbCliente.Text = "Seleccione un cliente..."
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los clientes", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub frmReporteFacturacionXCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.mtb.Buttons(1).Visible = False
            Me.mtb.Buttons(4).Visible = False
            LlenarCombo()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al abrir la ventana", MsgBoxStyle.Critical, "Error")
#End If
            Close()
        End Try
    End Sub

    Private Sub cmbCliente_ActualizarCombo(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCliente.ActualizarCombo
        LlenarCombo()
    End Sub

    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        Me.dtFechaInicial.Enabled = Me.chkFiltrar.Checked
        Me.dtFechaFinal.Enabled = Me.chkFiltrar.Checked
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim ventana As New ClasesNegocio.PreVisualizarForm
            Dim reporte As New ClasesNegocio.rptFacturasxCliente
            Dim tv As New TC.VwVentasXfacturaTypedView
            Dim filtro As New OC.PredicateExpression

            If cmbCliente.SelectedIndex > -1 Then
                filtro.Add(HC.VwVentasXfacturaFields.IdCliente = Me.cmbCliente.SelectedValue)
            End If

            If Me.chkFiltrar.Checked Then
                filtro.Add(New OC.FieldBetweenPredicate(HC.VwVentasXfacturaFields.Fecha, Me.dtFechaInicial.Value.ToShortDateString, Me.dtFechaFinal.Value.AddDays(1).ToShortDateString))
            End If

            Dim FilEstatus As OC.IPredicate = Nothing
            Dim Coleccion As New Collection()

            Coleccion.Add(chkVigentes)
            Coleccion.Add(chkCanceladas)
            Coleccion.Add(chkAbonadas)
            Coleccion.Add(chkPagadas)

            For Each Item As CheckBox In Coleccion
                If FilEstatus Is Nothing And Item.Checked Then
                    FilEstatus = HC.VwVentasXfacturaFields.Sta = Item.Tag
                ElseIf Item.Checked Then
                    FilEstatus = FilEstatus Or HC.VwVentasXfacturaFields.Sta = Item.Tag
                End If
            Next

            If Not FilEstatus Is Nothing Then
                filtro.Add(FilEstatus)
            End If

            tv.Fill(0, New OC.SortExpression(New OC.SortClause(HC.VwVentasXfacturaFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), True, filtro, Nothing)

            reporte.SetDataSource(CType(tv, Object))
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, "Ventas/Reportes/Facturas por Cliente")
            reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)

            ventana.Text = "Reporte de Facturas por Cliente"
            ventana.Reporte = reporte
            ventana.StartPosition = FormStartPosition.CenterScreen
            ventana.WindowState = FormWindowState.Maximized
            ventana.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar las facturas", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        txtCodigoCliente.Text = String.Empty
        Me.cmbCliente.SelectedIndex = -1
        Me.cmbCliente.SelectedText = "Seleccione un cliente..."
        chkVigentes.Checked = True
        chkCanceladas.Checked = True
        chkAbonadas.Checked = True
        chkPagadas.Checked = True
        Me.chkFiltrar.Checked = False
        Me.dtFechaFinal.Value = Now
        Me.dtFechaInicial.Value = Now
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub chkEstatus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCanceladas.CheckedChanged, chkAbonadas.CheckedChanged, chkPagadas.CheckedChanged
        If (Not chkVigentes.Checked And Not chkCanceladas.Checked And Not chkAbonadas.Checked And Not chkPagadas.Checked) Then
            chkVigentes.Checked = True
            chkCanceladas.Checked = True
            chkAbonadas.Checked = True
            chkPagadas.Checked = True
        End If
    End Sub
End Class