Imports CN = ClasesNegocio
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class MConsEmbarques

    Private m_Estatus As ClasesNegocio.EstatusCharX = ClasesNegocio.EstatusCharX.TODOS
    Private PorFacturar As Boolean = False

#Region "Constructores"

    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByVal PorFacturar As Boolean)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.PorFacturar = PorFacturar
        If Me.PorFacturar Then
            m_Estatus = ClasesNegocio.EstatusCharX.VIGENTE
        End If
    End Sub

#End Region

    Public Property EstatusDefault(ByVal bloquearControl As Boolean) As ClasesNegocio.EstatusCharX
        Get
            Return m_Estatus
        End Get
        Set(ByVal value As ClasesNegocio.EstatusCharX)
            m_Estatus = value
            Me.GroupBox2.Enabled = Not bloquearControl
        End Set
    End Property

    Private Sub Limpiar()
        Try
            Me.txtFolio.Text = ""
            Me.CmbClientes.SelectedIndex = 0
            Me.rbtnTodos.Checked = True
            Me.ChkFechas.Checked = False
            Me.DgvEmbarques.DataSource = Nothing

            Select Case Me.EstatusDefault(CType(IIf(PorFacturar, True, False), Boolean))
                Case ClasesNegocio.EstatusCharX.CANCELADO
                    Me.RbtnCancelado.Checked = True
                Case ClasesNegocio.EstatusCharX.FACTURADO
                    Me.rbtnFacturados.Checked = True
                Case ClasesNegocio.EstatusCharX.TODOS
                    Me.rbtnTodos.Checked = True
                Case ClasesNegocio.EstatusCharX.VIGENTE
                    Me.RbtnVigente.Checked = True
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MConsEmbarques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ClientesCol As New CN.ClientesIntroductoresColeccion
            Dim Cliente As New CN.ClientesIntroductoresClass
            Cliente.Nombre = "TODOS"
            ClientesCol.Add(Cliente)

            Dim AuxCol As New CN.ClientesIntroductoresColeccion
            AuxCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            Me.txtFolio.Focus()
            For Each Cli As CN.ClientesIntroductoresClass In AuxCol
                ClientesCol.Add(Cli)
            Next

            Me.CmbClientes.DisplayMember = "Nombre"
            Me.CmbClientes.ValueMember = "Codigo"
            Me.CmbClientes.DataSource = ClientesCol

            Limpiar()
            buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buscar()
        Try
            Dim Vista As New TC.VwBusquedaEmbarquesTypedView
            Dim Filtro As New OC.PredicateExpression


            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwBusquedaEmbarquesFields.IdFolioEmbarque Mod String.Format("%{0}%", Me.txtFolio.Text.Trim))

                If PorFacturar Then
                    Filtro.Add(HC.VwBusquedaEmbarquesFields.Estatus = "V")
                End If
            ElseIf Not Me.txtReferencia.Text.Trim = "" Then
                Filtro.Add(HC.VwBusquedaEmbarquesFields.FolioEmbarqueEmp Mod String.Format("%{0}%", Me.txtReferencia.Text.Trim))

                If PorFacturar Then
                    Filtro.Add(HC.VwBusquedaEmbarquesFields.Estatus = "V")
                End If
            Else
                If Me.CmbClientes.SelectedIndex > 0 Then
                    Filtro.Add(HC.VwBusquedaEmbarquesFields.IdCliente = Me.CmbClientes.SelectedValue)
                End If

                If Me.ChkFechas.Checked And Validar() Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaEmbarquesFields.FechaEmbarque, Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
                End If

                If Me.RbtnVigente.Checked Then
                    Filtro.Add(HC.VwBusquedaEmbarquesFields.Estatus = "V")
                End If

                If Me.RbtnCancelado.Checked Then
                    Filtro.Add(HC.VwBusquedaEmbarquesFields.Estatus = "X")
                End If

                If Me.rbtnFacturados.Checked Then
                    Filtro.Add(HC.VwBusquedaEmbarquesFields.Estatus = "F")
                End If
            End If
            Vista.Fill(0, New OC.SortExpression(New OC.SortClause(HC.VwBusquedaEmbarquesFields.FechaEmbarque, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)), False, Filtro)

            Me.DgvEmbarques.AutoGenerateColumns = False
            Me.DgvEmbarques.DataSource = Vista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean
        If Me.ChkFechas.Checked Then
            If Me.DtpFechaIni.Value > Me.DtpFechaFin.Value Then
                MessageBox.Show("La Fecha Inicial debe ser Menor  o Igual a la fecha Final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim idcliente As Integer
        If Me.DgvEmbarques.SelectedRows.Count > 0 Then
            If Me.DgvEmbarques.SelectedRows.Count > 1 Then
                Dim i As Integer
                For i = 0 To Me.DgvEmbarques.Rows.Count - 1
                    If Me.DgvEmbarques.Rows(i).Selected Then
                        idcliente = Me.DgvEmbarques.Rows(i).Cells("clmIdCliente").Value
                        Exit For
                    End If
                Next
                For j As Integer = i + 1 To Me.DgvEmbarques.Rows.Count - 1
                    If Me.DgvEmbarques.Rows(j).Selected Then
                        If idcliente <> Me.DgvEmbarques.Rows(j).Cells("clmIdCliente").Value Then
                            MsgBox("Embarques de diferentes clientes no se pueden facturar, vuelva a selecionar", MsgBoxStyle.OkOnly, "AVISO")
                            Me.DialogResult = Windows.Forms.DialogResult.Cancel
                            Exit Sub
                        End If
                    End If
                Next
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub BrnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        buscar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DgvEmbarques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvEmbarques.DoubleClick
        If Me.DgvEmbarques.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub ChkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFechas.CheckedChanged
        If Me.ChkFechas.Checked Then
            Me.DtpFechaFin.Enabled = True
            Me.DtpFechaIni.Enabled = True
        Else
            Me.DtpFechaIni.Enabled = False
            Me.DtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub txtFolio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFolio.TextChanged
        Try
            If Me.txtFolio.Text.Length > 4 Then
                buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub txtReferencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReferencia.TextChanged
        Try
            If Me.txtReferencia.Text.Trim.Length > 4 Then
                buscar()
            End If
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub txtFolio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress, txtReferencia.KeyPress, CmbClientes.KeyPress, RbtnVigente.KeyPress, rbtnTodos.KeyPress, rbtnFacturados.KeyPress, RbtnCancelado.KeyPress, ChkFechas.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

End Class