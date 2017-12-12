Imports HC = Integralab.ORM.HelperClasses

Public Class FrmSaldosPromedios

    Private Sub FrmSaldosPromedios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'BancosC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Me.cmbBanco.SelectedIndex = -1
        'Me.cmbBanco.Text = "Seleccione un Banco..."
        Me.dtpFecha.Value = New Date(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month, 1)
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Reporte As New ClasesNegocio.rptSaldosPromediosdeBancos
            Dim VerReporte As New FrmReportes
            Dim Depositos As Decimal = 0
            Dim Retiros As Decimal = 0
            Dim SaldodelDia As Decimal = 0
            Dim SaldoInicial As Decimal = 0
            Dim SaldoPromedio As Decimal = 0
            Dim Mes As Integer = Me.dtpFecha.Value.Month
            Dim Año As Integer = Me.dtpFecha.Value.Year
            Dim FechaInicial As Date
            Dim FechaFinal As Date
            FechaInicial = Me.dtpFecha.Value.ToString("MM/yyyy")
            FechaInicial = FechaInicial.ToString("MM/yyyy")
            FechaFinal = Me.dtpFecha.Value.ToString("MM/yyyy")
            FechaFinal = FechaFinal.ToString("MM/yyyy")
            Dim DiaFinal As Integer
            Dim CuentaId As Integer = 0
            Dim Contador As Decimal = 0
            Dim Fecha As Date = Me.dtpFecha.Value.ToString("MM/yyyy")
            Dim MovBancariosC As New ClasesNegocio.MovimientosBancosColecctionClass
            Dim MovBancarioC As New ClasesNegocio.MovimientosBancosColecctionClass

            If Now.Day > Date.DaysInMonth(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month) Then
                Me.dtpFecha.Value = New Date(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month, Date.DaysInMonth(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month))
            Else
                Me.dtpFecha.Value = New Date(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month, 1)
            End If


            'Dim Query1 As String = "Select " & _
            '                            "Bancos.BncDescripcion as Banco, " & _
            '                            "Cuentas.Cuenta, " & _
            '                            "MovBancario.Cta_Bancar, " & _
            '                            "MovBancario.Tipo_Mov as TipoMovimiento, " & _
            '                            "MovBancario.SaldoAnterior, " & _
            '                            "MovBancario.Importe, " & _
            '                            "MovBancario.Fec_Mov, " & _
            '                            "YEAR(MovBancario.Fec_Mov) as Año, " & _
            '                            "MONTH(MovBancario.Fec_Mov) as Mes, " & _
            '                            "DAY(MovBancario.Fec_Mov) as Dia " & _
            '                      "From dbo.MvbaCb as MovBancario inner join " & _
            '                            "dbo.usrBanCuentas as Cuentas on Cuentas.codigo = MovBancario.Cta_Bancar inner join " & _
            '                            "dbo.MCatCompBancos as Bancos on Bancos.BncIdBanco = Cuentas.bancoId "
            'Dim Where As String = ""
            'Dim Orden As String = ""
            'Where &= "Where YEAR(MovBancario.Fec_Mov) = '" & Año & "' and MONTH (MovBancario.Fec_Mov) = '" & Mes & "' "
            'Orden &= "Order by Cta_Bancar, Fec_Mov"
            'Query1 &= Where
            'Query1 &= Orden

            'Dim Query2 As String = "Select " & _
            '                            "Bancos.BncDescripcion as Banco, " & _
            '                            "Cuentas.Cuenta, MovBancario.Cta_Bancar " & _
            '                       "From dbo.MvbaCb as MovBancario inner join " & _
            '                            "dbo.usrBanCuentas as Cuentas on Cuentas.codigo = MovBancario.Cta_Bancar inner join " & _
            '                            "dbo.MCatCompBancos as Bancos on Bancos.BncIdBanco = Cuentas.bancoId "

            'Dim Where2 As String = ""
            'Dim GroupBy As String = ""
            'Dim Orden2 As String = ""
            'Where2 &= "Where YEAR(MovBancario.Fec_Mov) = '" & Año & "' and MONTH (MovBancario.Fec_Mov) = '" & Mes & "' "
            'GroupBy &= "Group by Cta_Bancar, Bancos.BncDescripcion, Cuentas.Cuenta "
            'Orden2 &= "Order by Cta_Bancar"
            'Query2 &= Where
            'Query2 &= GroupBy
            'Query2 &= Orden2

            'Dim da As New System.Data.SqlClient.SqlDataAdapter(Query1, HC.DbUtils.ActualConnectionString)
            'Dim da2 As New System.Data.SqlClient.SqlDataAdapter(Query2, HC.DbUtils.ActualConnectionString)

            Dim dtReporte As New ClasesNegocio.DSetSaldosPromediosdeBancos.dtSaldosPromediosdeBancosDataTable
            'Dim dt As New ClasesNegocio.DSetSaldosPromediosdeBancos.dtSaldosPromediosdeBancosDataTable
            'Dim dtCuentas As New DataTable
            Dim ds As New DataSet
            'da.Fill(dt)
            'da2.Fill(dtCuentas)

            If Not Me.dtpFecha.Value.Date > Now.Date Then
                If Año = Now.Date.Year Then
                    If Mes = Now.Date.Month Then
                        DiaFinal = Now.Date.Day
                        FechaFinal = FechaFinal.AddDays(DiaFinal - 1)
                    End If
                Else
                    DiaFinal = Date.DaysInMonth(Año, Mes)
                    FechaFinal = FechaFinal.AddDays(DiaFinal - 1)
                End If
            Else
                MsgBox("Porfavor indique una fecha valida", MsgBoxStyle.Information, "Fecha no valida")
                Exit Sub
            End If

            MovBancariosC.Obtener(FechaInicial, FechaFinal)
            For i As Integer = 0 To MovBancariosC.Count - 1
                If Not CuentaId = MovBancariosC(i).CtaBancaria Then
                    CuentaId = MovBancariosC(i).CtaBancaria
                    Fecha = FechaInicial
                    MovBancarioC.Obtener(CuentaId, FechaInicial, FechaFinal)
                    For dm As Integer = 0 To MovBancarioC.Count - 1
                        SaldoInicial = MovBancarioC(0).SaldoAnterior
                        SaldodelDia = SaldoInicial
                        Contador = 0
                        For fech As Integer = 1 To FechaFinal.Day
                            Depositos = 0
                            Retiros = 0
                            For w As Integer = 0 To MovBancarioC.Count - 1
                                If Fecha = MovBancarioC(w).FechaCaptura.Date Then
                                    If MovBancarioC(w).TipoMov = "D" Then
                                        Depositos += MovBancarioC(w).Importe
                                    Else
                                        Retiros += MovBancarioC(w).Importe
                                    End If
                                End If
                            Next
                            SaldodelDia = SaldodelDia + Depositos
                            SaldodelDia = SaldodelDia - Retiros
                            Contador += SaldodelDia
                            SaldoPromedio = Contador / Fecha.Day
                            dtReporte.AdddtSaldosPromediosdeBancosRow(MovBancarioC(dm).Banco.Descripcion, MovBancarioC(dm).CuentaBancaria.Cuenta, Depositos, Retiros, SaldodelDia, SaldoInicial, Fecha.Day, Fecha, Año, SaldoPromedio, MovBancarioC(dm).TipoMov, MovBancarioC(dm).Importe)
                            If Not Fecha > FechaFinal Then
                                Fecha = Fecha.AddDays(1)
                                If Fecha > FechaFinal Then
                                    Exit For
                                End If
                            End If
                        Next
                        Exit For
                    Next
                End If
            Next



            '    For i As Integer = 0 To dt.Count - 1
            '        Cuenta = dt(i).Cuenta
            '        Dim expresion As String = "Cuenta = '" & Cuenta & "'"
            '        For d = 1 To Dia
            '            Dim A1 As Integer = 0
            '            Dim A2 As Integer = 0
            '            Dim A3 As Integer = 0
            '            If dt.Count > 0 Then
            '                dt.Select(expresion)
            '                For dm As Integer = 0 To dtCuentas.Rows.Count - 1
            '                Next
            '            End If
            '            If dt(i).Dia = d Then
            '                If dt(i).TipoMovimiento = "D" Then
            '                    Depositos = Depositos + dt(i).Importe
            '                Else
            '                    Retiros = Retiros + dt(i).Importe
            '                End If
            '            Else
            '                dtReporte.AdddtSaldosPromediosdeBancosRow(dt(i).Banco, dt(i).Cuenta, "0", "0", SaldodelDia, SaldoInicial, d, Mes, Año, SaldoPromedio, "", "")
            '                Continue For
            '            End If
            '            Contador = dt(i).Dia
            '            If dt(i).Dia = Contador Then
            '                If dt(i).TipoMovimiento = "D" Then
            '                    Depositos = Depositos + dt(i).Importe
            '                Else
            '                    Retiros = Retiros + dt(i).Importe
            '                End If
            '                Exit For
            '            End If
            '            If i = 0 Then
            '                If dt(i).TipoMovimiento = "D" Then
            '                    Depositos = Depositos + dt(i).Importe
            '                Else
            '                    Retiros = Retiros + dt(i).Importe
            '                End If
            '            Else
            '                If dt(i).Dia = dt(i - 1).Dia Then
            '                End If
            '            End If
            '            Contador = dt(i).Dia
            '            dtReporte.AdddtSaldosPromediosdeBancosRow(Banco, Cuenta, Depositos, Retiros, "", "", d, Mes, Año, SaldoPromedio, TipoMovimiento, Importe)
            '        Next
            '    Next
            '    dtReporte.AdddtSaldosPromediosdeBancosRow(Banco, Cuenta, Depositos, Retiros, SaldodelDia, SaldoInicial, d, Mes, Año, SaldoPromedio, TipoMovimiento, Importe)
            '    d = d + 1


            ds.Tables.Add(dtReporte)
            Reporte.SetDataSource(ds)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, "Bancos\Reportes\Saldos Promedios")
            Reporte.SetParameterValue(3, FechaInicial)
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

End Class