Imports HC = Integralab.ORM.HelperClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio
Public Class FrmConFacturas
    Private Sub FrmConFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Clientes As New CN.ClientesIntroductoresColeccion
            Dim Cliente As New CN.ClientesIntroductoresClass
            Cliente.Nombre = "TODOS"
            Clientes.Add(Cliente)

            Dim ClientesAux As New CN.ClientesIntroductoresColeccion
            ClientesAux.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            For Each Cli As CN.ClientesIntroductoresClass In ClientesAux
                Clientes.Add(Cli)
            Next

            Me.CmbCliente.ValueMember = "Codigo"
            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.DataSource = Clientes

            Limpiar()
            Buscar()
            txtNoFactura.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Limpiar()
        Me.CmbCliente.SelectedIndex = -1
        Me.txtNoFactura.Text = ""
        Me.RbtVigentes.Checked = True
        Me.ChkFechas.Checked = True
        Me.DtpFechaIni.Value = Now
        Me.DtpFechaFin.Value = Now
        Me.DgvFacturas.DataSource = Nothing
    End Sub

    Private Function Validar() As Boolean
        If Me.ChkFechas.Checked Then
            If Me.DtpFechaIni.Value > Me.DtpFechaFin.Value Then
                MsgBox("La fecha inicial debe ser mayor o igual a la fecha final", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Private Sub Buscar()
        Try
            Dim Vista As New TC.VwConsultaFacturasSinFiltradoTypedView
            Dim Filtro As New OC.PredicateExpression

            If Me.CmbCliente.SelectedIndex > 0 Then
                Filtro.Add(HC.VwConsultaFacturasSinFiltradoFields.IdCliente = Me.CmbCliente.SelectedValue)
            End If

            If Not Me.txtNoFactura.Text = "" Then
                Filtro.Add(HC.VwConsultaFacturasSinFiltradoFields.NoFactura Mod String.Format("%{0}%", Me.txtNoFactura.Text))
            End If

            If Me.ChkFechas.Checked And Validar() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwConsultaFacturasSinFiltradoFields.FechaFactura, Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            If Not Me.RbtnTodas.Checked Then
                If Me.RbtVigentes.Checked Then
                    Filtro.Add(HC.VwConsultaFacturasSinFiltradoFields.Estatus = "V")
                End If
                If Me.RbtnCanceladas.Checked Then
                    Filtro.Add(HC.VwConsultaFacturasSinFiltradoFields.Estatus = "C")
                End If
                'If Me.RbtnAbonadas.Checked Then
                '    Filtro.Add(HC.VwConsultaFacturasSinFiltradoFields.Estatus = "A")
                'End If
                'If Me.RbtnPagadas.Checked Then
                '    Filtro.Add(HC.VwConsultaFacturasSinFiltradoFields.Estatus = "P")
                'End If
            End If

            Vista.Fill(0, Nothing, False, Filtro)
            Me.DgvFacturas.AutoGenerateColumns = False
            Me.DgvFacturas.DataSource = Vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ChkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFechas.CheckedChanged
        If Me.ChkFechas.Checked Then
            Me.GroupBox1.Enabled = True
        Else
            Me.GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Buscar()
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DgvFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvFacturas.DoubleClick
        If Me.DgvFacturas.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.DgvFacturas.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BrnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtNoFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoFactura.TextChanged
        If Me.txtNoFactura.Text.Length > 3 Then
            Buscar()
        End If
    End Sub

    Private Sub txtNoFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoFactura.KeyPress, RbtVigentes.KeyPress, RbtnTodas.KeyPress, RbtnCanceladas.KeyPress, DtpFechaIni.KeyPress, DtpFechaFin.KeyPress, DgvFacturas.KeyPress, CmbCliente.KeyPress, ChkFechas.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

End Class