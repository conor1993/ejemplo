Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Public Class frmReportedePagos

    Dim Vista As New TC.VwPagoClientesTypedView


    Private Sub frmReportedePagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Cli As New CN.ClientesIntroductoresClass
            Cli.Nombre = "TODOS"
            Dim ClientesCol As New CN.ClientesIntroductoresColeccion
            ClientesCol.Add(Cli)

            Dim ColeccionClie As New CN.ClientesIntroductoresColeccion
            ColeccionClie.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            For Each Clie As CN.ClientesIntroductoresClass In ColeccionClie
                ClientesCol.Add(Clie)
            Next

            Me.CmbClientes.ValueMember = "Codigo"
            Me.CmbClientes.DisplayMember = "Nombre"
            Me.CmbClientes.DataSource = ClientesCol
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        Me.CmbClientes.SelectedIndex = -1
        Me.txtNoPago.Clear()
        Me.txtNoFactura.Clear()
        chkVigentes.Checked = True
        chkCancelados.Checked = True
        'Me.DgvFacturas.DataSource = Nothing
        'Me.RbtnTodos.Checked = True
        'Me.ChkFechas.Checked = False
    End Sub

    Private Sub Buscar()
        Try

            Dim Filtro As New OC.PredicateExpression

            If Me.CmbClientes.SelectedIndex > 0 Then
                Filtro.Add(HC.VwPagoClientesFields.CveCliente = Me.CmbClientes.SelectedValue)
            End If

            If Not Me.txtNoPago.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolIngreso Mod String.Format("%{0}%", Me.txtNoPago.Text))
            End If

            If Not Me.txtNoFactura.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolFactura Mod String.Format("%{0}%", Me.txtNoFactura.Text))
            End If

            If ValidarFechas() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwPagoClientesFields.FecIngreso, Me.DtPFechaini.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            'If Me.RbtnVigentes.Checked Then
            '    Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.VIGENTE)
            'End If

            'If Me.RbtnCancelados.Checked Then
            '    Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.CANCELADO)
            'End If

            Vista.Fill(0, Nothing, False, Filtro)

            Me.dgvPagos.AutoGenerateColumns = False
            Me.dgvPagos.DataSource = Vista

            'Me.DgvFacturas.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Reporte() As CN.rptPagosClientes2
        Try
            Dim rep As New CN.rptPagosClientes2
            Dim Vista1 As New TC.VwPagoClientesTypedView
            'Dim reporteporbanco As New CN.rptPagosClientes2
            'Dim reporteporbancocuenta As New CN.rptPagosClientes3
            Dim dt As New CN.DsReportePagosdeClientes.DtPagosdeClientesDataTable
            Dim ds As New DataSet
            Dim Filtro As New OC.PredicateExpression

            If Me.CmbClientes.SelectedIndex > 0 Then
                Filtro.Add(HC.VwPagoClientesFields.CveCliente = Me.CmbClientes.SelectedValue)
            End If

            If Not Me.txtNoPago.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolIngreso Mod String.Format("%{0}%", Me.txtNoPago.Text))
            End If

            If Not Me.txtNoFactura.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolFactura Mod String.Format("%{0}%", Me.txtNoFactura.Text))
            End If

            If ValidarFechas() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwPagoClientesFields.FecIngreso, Me.DtPFechaini.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            If Me.chkVigentes.Checked And Not Me.chkCancelados.Checked Then
                Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.VIGENTE)
            ElseIf Me.chkCancelados.Checked And Not Me.chkVigentes.Checked Then
                Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.CANCELADO)
            End If

            Vista1.Fill(0, Nothing, False, Filtro)

            Me.dgvPagos.AutoGenerateColumns = False
            Me.dgvPagos.DataSource = Vista1


            For Each Pago As TC.VwPagoClientesRow In Vista1
                dt.AddDtPagosdeClientesRow(Pago.FolIngreso, Pago.FecIngreso.ToShortDateString(), Pago.Nombre, Pago.FolFactura, Pago.Importe.ToString("C"), Pago.EstatusCad, Pago.CveCliente, Pago.Cuenta, Pago.BncDescripcion, Pago.TipoFactura)
            Next
            ds.Tables.Add(dt)
            rep.SetDataSource(ds)
            rep.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            rep.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, "Cuentas X Cobrar")


            Return rep
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
    Private Function ReportePorBanco() As CN.rptPagosdeClientes
        Try
            Dim rep As New CN.rptPagosdeClientes
            Dim dt As New CN.DsReportePagosdeClientes.DtPagosdeClientesDataTable
            Dim ds As New DataSet
            Dim Filtro As New OC.PredicateExpression
            Dim Vista2 As New TC.VwPagoClientesTypedView

            If Me.CmbClientes.SelectedIndex > 0 Then
                Filtro.Add(HC.VwPagoClientesFields.CveCliente = Me.CmbClientes.SelectedValue)
            End If

            If Not Me.txtNoPago.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolIngreso Mod String.Format("%{0}%", Me.txtNoPago.Text))
            End If

            If Not Me.txtNoFactura.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolFactura Mod String.Format("%{0}%", Me.txtNoFactura.Text))
            End If

            If ValidarFechas() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwPagoClientesFields.FecIngreso, Me.DtPFechaini.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            If Me.chkVigentes.Checked And Not Me.chkCancelados.Checked Then
                Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.VIGENTE)
            ElseIf Me.chkCancelados.Checked And Not Me.chkVigentes.Checked Then
                Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.CANCELADO)
            End If

            Vista2.Fill(0, Nothing, False, Filtro)

            Me.dgvPagos.AutoGenerateColumns = False
            Me.dgvPagos.DataSource = Vista2


            For Each Pago As TC.VwPagoClientesRow In Vista2
                dt.AddDtPagosdeClientesRow(Pago.FolIngreso, Pago.FecIngreso.ToShortDateString(), Pago.Nombre, Pago.FolFactura, Pago.Importe.ToString("C"), Pago.EstatusCad, Pago.CveCliente, Pago.Cuenta, Pago.BncDescripcion, Pago.TipoFactura)
            Next
            ds.Tables.Add(dt)

            rep.SetDataSource(ds)
            rep.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            rep.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, "Cuentas X Cobrar")


            Return rep
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
    Private Function ReporteProBancoCuenta() As CN.rptPagosClientes3
        Try
            Dim rep As New CN.rptPagosClientes3
            Dim dt As New CN.DsReportePagosdeClientes.DtPagosdeClientesDataTable
            Dim ds As New DataSet
            Dim Filtro As New OC.PredicateExpression
            Dim Vista3 As New TC.VwPagoClientesTypedView

            If Me.CmbClientes.SelectedIndex > 0 Then
                Filtro.Add(HC.VwPagoClientesFields.CveCliente = Me.CmbClientes.SelectedValue)
            End If

            If Not Me.txtNoPago.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolIngreso Mod String.Format("%{0}%", Me.txtNoPago.Text))
            End If

            If Not Me.txtNoFactura.Text = "" Then
                Filtro.Add(HC.VwPagoClientesFields.FolFactura Mod String.Format("%{0}%", Me.txtNoFactura.Text))
            End If

            If ValidarFechas() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwPagoClientesFields.FecIngreso, Me.DtPFechaini.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            If Me.chkVigentes.Checked And Not Me.chkCancelados.Checked Then
                Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.VIGENTE)
            ElseIf Me.chkCancelados.Checked And Not Me.chkVigentes.Checked Then
                Filtro.Add(HC.VwPagoClientesFields.Estatus = ClasesNegocio.EstatusChar.CANCELADO)
            End If

            Vista3.Fill(0, Nothing, False, Filtro)

            Me.dgvPagos.AutoGenerateColumns = False
            Me.dgvPagos.DataSource = Vista3


            For Each Pago As TC.VwPagoClientesRow In Vista3
                dt.AddDtPagosdeClientesRow(Pago.FolIngreso, Pago.FecIngreso.ToShortDateString(), Pago.Nombre, Pago.FolFactura, Pago.Importe.ToString("C"), Pago.EstatusCad, Pago.CveCliente, Pago.Cuenta, Pago.BncDescripcion, Pago.TipoFactura)
            Next
            ds.Tables.Add(dt)

            rep.SetDataSource(ds)
            rep.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            rep.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, "Cuentas X Cobrar")


            Return rep
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
    Private Function ValidarFechas() As Boolean
        If Me.DtPFechaini.Value > Me.DtpFechaFin.Value Then
            MessageBox.Show("La Fecha Inicial debe ser mayor o igual a la Fecha Final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Me.Buscar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim previsualizador As New CN.PreVisualizarForm
        If Me.optCliente.Checked Then
            previsualizador.Reporte = Me.Reporte
        End If
        If Me.optBanco.Checked Then
            previsualizador.Reporte = Me.ReportePorBanco
        End If
        If Me.optCuenta.Checked Then
            previsualizador.Reporte = Me.ReporteProBancoCuenta
        End If
        previsualizador.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub Estatus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCancelados.CheckedChanged
        If Not (chkVigentes.Checked Or chkCancelados.Checked) Then
            chkVigentes.Checked = True
            chkCancelados.Checked = True
        End If
    End Sub
End Class