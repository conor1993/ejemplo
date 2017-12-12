Imports HC = IntegraLab.ORM.HelperClasses
Imports CN = ClasesNegocio

Public Class FrmBanConciliacionBancaria

    Dim MovBancosC As CN.MovimientosBancosColecctionClass
    Dim CuentaBancaria As CN.BancosCollectionClass
    Dim CuentasC As CN.CuentaCollectionClass
    Dim Cuenta As CN.CuentaClass

    Private Sub FrmBanConciliacionBancaria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        RellenarBancos()

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim NumCuenta As String
        Dim FechaInicial As Date = Me.dtpFechaInicial.Value.Date
        Dim FechaFinal As Date = Me.dtpFechaFinal.Value.Date
        If Me.cmbCuentaBancaria.SelectedIndex > -1 Then
            NumCuenta = Me.cmbCuentaBancaria.SelectedValue.ToString
        Else
            MsgBox("Deve de Seleccionar una Cuenta", MsgBoxStyle.Information, "No ha Seleccionado Cuenta")
            Exit Sub
        End If
        If (Me.dtpFechaInicial.Value.Date > Me.dtpFechaFinal.Value.Date) Then
            MsgBox("Rango de Fechas no válido, intente de nuevo", MsgBoxStyle.Information, "Rango de Fechas Incorrecto")
            Exit Sub
        End If
        Reporte(NumCuenta, FechaInicial, FechaFinal)
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub RellenarBancos()
        Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.cmbBanco.SelectedIndex = -1
        Me.cmbBanco.Text = "Seleccione un Banco..."
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If Me.cmbBanco.SelectedIndex > -1 Then
            Dim Banco As CN.BancosClass = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            CuentasC = New CN.CuentaCollectionClass
            CuentasC.Obtener(Banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            Me.cmbCuentaBancaria.DataSource = CuentasC
            Me.cmbCuentaBancaria.DisplayMember = "Cuenta"
            Me.cmbCuentaBancaria.SelectedIndex = -1
            Me.cmbCuentaBancaria.Text = "Seleccione una Cuenta..."
        End If
    End Sub

    Private Sub cmbCuentaBancaria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCuentaBancaria.SelectedIndexChanged
        If Me.cmbCuentaBancaria.SelectedIndex > -1 Then
            Cuenta = DirectCast(cmbCuentaBancaria.SelectedItem, CN.CuentaClass)
        End If
    End Sub

    Sub Reporte(ByVal NumCuenta As String, ByVal FechaInicial As Date, ByVal FechaFinal As Date)
        Try
            Cursor = Cursors.WaitCursor
            Dim Query As String = "select " & _
                                          "MovimientosBancarios.Numero_pol as NumPoliza, " & _
                                          "MovimientosBancarios.Fec_Mov as FechaMov, " & _
                                          "MovimientosBancarios.Referencia, " & _
                                          "MovimientosBancarios.Concepto, " & _
                                          "CuentasBancarias.Cuenta, " & _
                                          "Bancos.BncDescripcion as Banco, " & _
                                     "case TipoMovimiento.TipoMovimiento " & _
                                          "when 'D' then 'Deposito' " & _
                                          "when 'R' then 'Retiro' " & _
                                          "when 'C' then 'Cargo Diverso' " & _
                                          "when 'A' then 'Abono Diverso' " & _
                                          "when 'T' then 'Traspaso' " & _
                                     "end as TipoMov, " & _
                                     "case MovimientosBancarios.Tipo_Mov " & _
                                          "when 'D' then MovimientosBancarios.Importe " & _
                                          "when 'A' then MovimientosBancarios.Importe " & _
                                     "end as Depositos, " & _
                                     "case MovimientosBancarios.Tipo_Mov " & _
                                          "when 'R' then MovimientosBancarios.Importe " & _
                                     "end as Retiros, " & _
                                          "'E' as Origen " & _
                                 "from dbo.MvbaCb as MovimientosBancarios inner join " & _
                                      "dbo.usrBanCuentas as CuentasBancarias on MovimientosBancarios.Cta_Bancar = CuentasBancarias.codigo inner join " & _
                                      "dbo.MCatCompBancos as Bancos on bancos.BncIdBanco = CuentasBancarias.bancoId inner join " & _
                                      "dbo.UsrBanCheques as TipoMovimiento on MovimientosBancarios.Numero_pol = TipoMovimiento.PolizaId and MovimientosBancarios.Cta_Bancar = TipoMovimiento.CuentaId "

            Dim Where As String = ""
            Dim Orden As String = ""
            Where &= " where CuentasBancarias.cuenta = '" & NumCuenta & "' and MovimientosBancarios.Fec_Mov Between '" & FechaInicial.ToString("yyyyMMdd") & "' AND '" & FechaFinal.AddDays(1).Date.ToString("yyyyMMdd") & "'" & "and Cve_Concil = 'N'"
            Query &= Where

            Dim Query2 As String = "select " & _
                                           "null as NumPoliza, " & _
                                           "MovimientosEstadoCuenta.Fecha as FechaMov, " & _
                                           "MovimientosEstadoCuenta.Referencia, " & _
                                           "MovimientosEstadoCuenta.Concepto, " & _
                                           "CuentasBancarias.Cuenta, " & _
                                           "bancos.BncDescripcion as Banco, " & _
                                     "case MovimientosEstadoCuenta.Tipo_Mov " & _
                                           "when 'D' then 'Deposito' " & _
                                           "when 'R' then 'Retiro' " & _
                                     "end as Tipo_Mov, " & _
                                     "case MovimientosEstadoCuenta.Tipo_Mov " & _
                                           "when 'D' then MovimientosEstadoCuenta.Importe " & _
                                     "end as Depositos, " & _
                                     "Case MovimientosEstadoCuenta.Tipo_Mov " & _
                                           "when 'R' then MovimientosEstadoCuenta.Importe " & _
                                     "end as Retiros, " & _
                                                "'B' as Origen " & _
                                     "From dbo.MveCta as MovimientosEstadoCuenta inner join " & _
                                          "dbo.usrBanCuentas as CuentasBancarias on MovimientosEstadoCuenta.IdCuenta = CuentasBancarias.codigo inner join " & _
                                          "dbo.MCatCompBancos as Bancos on bancos.BncIdBanco = CuentasBancarias.bancoId "

            Dim Where2 As String = ""
            Dim Orden2 As String = ""
            Where2 &= " where CuentasBancarias.cuenta = '" & NumCuenta & "' and MovimientosEstadoCuenta.Fecha Between '" & FechaInicial.ToString("yyyyMMdd") & "' AND '" & FechaFinal.AddDays(1).Date.ToString("yyyyMMdd") & "'" & "and Conciliado = 0 "
            Orden2 &= " Order by Fec_Mov"
            Query2 &= Where2
            Query2 &= Orden2

            Dim da As New System.Data.SqlClient.SqlDataAdapter(Query & " UNION " & Query2, HC.DbUtils.ActualConnectionString)
            Dim dt As New ClasesNegocio.DSetConciliacionBancaria.dtConciliacionBancariaDataTable
            Dim ds As New DataSet
            da.Fill(dt)

            Dim Reporte As New ClasesNegocio.RptConciliacionBancaria
            Dim VerReporte As New FrmReportes

            If Not dt.Count > 0 Then
                MsgBox("No se enconto ningun Registro", MsgBoxStyle.Information, "No hay Informacion")
                Exit Sub
            End If

            ds.Tables.Add(dt)
            Reporte.SetDataSource(ds)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, "Bancos\Reportes\Conciliación Bancaria")
            Reporte.SetParameterValue(3, Me.dtpFechaInicial.Value.Date)
            Reporte.SetParameterValue(4, Me.dtpFechaFinal.Value.Date)
            Reporte.SetParameterValue(5, "Reporte de Conciliacón Bancaria")
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class