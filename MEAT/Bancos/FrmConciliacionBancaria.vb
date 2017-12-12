Imports HC = Integralab.ORM.HelperClasses

Public Class FrmConciliacionBancaria

    Dim CuentasC As New ClasesNegocio.CuentaCollectionClass
    Dim Cuenta As New ClasesNegocio.CuentaClass
    Dim CuentaContable As New ClasesNegocio.CuentaContableClass
    Dim Conciliar As New ClasesNegocio.ChequeCollectionClass
    Dim MovBancos As New ClasesNegocio.MovimientosBancosColecctionClass
    Dim MovBanco As New ClasesNegocio.MovimientosBancosClass
    Dim idCuantabancaria As Integer
    Dim FechaInicial As Date
    Dim FechaFinal As Date
    Dim DiaFinal As Integer
    Dim Mes As Integer
    Dim Año As Integer

    Private Sub FrmConciliacionBancaria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110010101"
            MtbEstados.StateLimpiar = "100000001"
            MtbEstados.StateCancelar = ""
            MtbEstados.StateNuevo = ""
            MtbEstados.StateGuardar = ""
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = ""
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = MtbEstados
            Me.mtb.sbCambiarEstadoBotones("Limpiar")

            BancosC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbBanco.SelectedIndex = -1
            Me.cmbBanco.Text = "Seleccione un Banco..."
            Me.dgvConciliar.AutoGenerateColumns = False
            RangoFechas()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


#Region "MToolBar"

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            If Me.cmbCuentaBancaria.SelectedIndex > -1 Then
                Conciliar.Obtener(Cuenta.Codigo, FechaInicial, FechaFinal)
                Me.dgvConciliar.DataSource = Conciliar
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "ModificarConciliacion")
        Try
            Me.Validate()
            MovBancos.Obtener(Cuenta.Codigo, FechaInicial, FechaFinal)
            Dim CveConciliacion As String
            Dim NumPoliza As Integer
            For i As Integer = 0 To Me.dgvConciliar.RowCount - 1
                NumPoliza = Me.dgvConciliar.Rows(i).Cells(Me.cmdPoliza.Index).Value
                If Me.dgvConciliar.Rows(i).Cells(Me.CveConciliacion.Index).Value = True Then 'CType(Me.dgvConciliar.Rows(i).DataBoundItem, ClasesNegocio.ChequeClass).Conciliado = True Then 
                    CveConciliacion = "S"
                Else
                    CveConciliacion = "N"
                End If
                For d As Integer = 0 To MovBancos.Count - 1
                    If MovBancos(d).NumPoliza = NumPoliza Then
                        If Not CveConciliacion = MovBancos(d).CveConciliacion Then
                            'Quiere decir que si cambio
                            'Cambiar la Clave de Conciliacion por la nueva
                            MovBanco.Obtener(MovBancos(d).NumPoliza, MovBancos(d).CtaBancaria)
                            MovBanco.ModificarConciliacion(CveConciliacion, trans)
                        End If
                    End If
                Next
            Next
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If Me.cmbBanco.SelectedIndex > -1 Then
            Dim Banco As ClasesNegocio.BancosClass = DirectCast(cmbBanco.SelectedItem, ClasesNegocio.BancosClass)
            CuentasC.Obtener(Banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            Me.cmbCuentaBancaria.DataSource = CuentasC
            Me.cmbCuentaBancaria.SelectedIndex = -1
            Me.cmbCuentaBancaria.Text = "Seleccione una Cuenta..."
        End If
    End Sub

    Private Sub cmbCuentaBancaria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCuentaBancaria.SelectedIndexChanged
        If Me.cmbCuentaBancaria.SelectedIndex > -1 Then
            Cuenta = DirectCast(Me.cmbCuentaBancaria.SelectedItem, ClasesNegocio.CuentaClass)
        End If
    End Sub

    Private Sub RangoFechas()
        Mes = Me.dtpFecha.Value.Month
        Año = Me.dtpFecha.Value.Year

        FechaInicial = Me.dtpFecha.Value.ToString("MM/yyyy")
        FechaInicial = FechaInicial.ToString("MM/yyyy")

        FechaFinal = Me.dtpFecha.Value.ToString("MM/yyyy")
        FechaFinal = FechaFinal.ToString("MM/yyyy")
        DiaFinal = Date.DaysInMonth(Año, Mes)
        FechaFinal = FechaFinal.AddDays(DiaFinal - 1)

        'DiaFinal = DateAdd(DateInterval.Day, -1, DiaFinal)
        'DiaFinal = DiaFinal.AddDays(-1)
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        RangoFechas()
    End Sub

    Private Sub limpiar()
        Me.cmbBanco.SelectedIndex = -1
        Me.cmbBanco.Text = "Seleccione un Banco..."
        Me.cmbCuentaBancaria.DataSource = Nothing
        Me.dtpFecha.Value = Now
        Me.dgvConciliar.DataSource = Nothing
        Me.txtConcepto.Text = ""
    End Sub

    Private Sub dgvConciliar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvConciliar.Click

    End Sub

    Private Sub dgvConciliar_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvConciliar.SelectionChanged
        If Me.dgvConciliar.RowCount > 0 Then
            Me.txtConcepto.Text = Me.dgvConciliar.Rows(dgvConciliar.CurrentRow.Index).Cells("Concepto").Value
        End If
    End Sub

End Class