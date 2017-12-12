Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class _092ChequesPostfechados
    Dim Chequespost As CN.ChequesPosfechadosClass
    Dim ChequesPostCol As New CN.ChequesPosfechadosCollectionClass

    Private Sub _092ChequesPostfechados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Dim ClientesCol As New CN.ClientesIntroductoresColeccion
            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.CmbClientes.DisplayMember = "Nombre"
            Me.CmbClientes.ValueMember = "Codigo"
            Me.CmbClientes.DataSource = ClientesCol

            Dim Bancos As New CN.BancosCollectionClass
            Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Me.CmbCuentas.DisplayMember = "Descripcion"
            Me.CmbCuentas.ValueMember = "Codigo"
            Me.CmbCuentas.DataSource = Bancos

            ChequesPostCol.Obtener(ClasesNegocio.EstatusChar.TODOS)
            Me.DgvCheques.AutoGenerateColumns = False
            Me.DgvCheques.DataSource = ChequesPostCol
            DesHabilitar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"

    Private Sub Habilitar()
        Me.CmbClientes.Enabled = True
        Me.CmbCuentas.Enabled = True
        Me.TxtDescripcion.Enabled = True
        Me.txtImporte.Enabled = True
        Me.DtpFecha.Enabled = True
        Me.DtpFechaCobro.Enabled = True
        Me.DgvCheques.Enabled = False
    End Sub

    Private Sub DesHabilitar()
        Me.CmbClientes.Enabled = False
        Me.CmbCuentas.Enabled = False
        Me.TxtDescripcion.Enabled = False
        Me.txtImporte.Enabled = False
        Me.DtpFecha.Enabled = False
        Me.DtpFechaCobro.Enabled = False
        Me.DgvCheques.Enabled = True
    End Sub

    Private Sub Limpiar()
        Me.CmbClientes.SelectedIndex = -1
        Me.CmbCuentas.SelectedIndex = -1
        Me.TxtDescripcion.Text = ""
        Me.txtImporte.Text = 0
        Me.lblEstatus.Visible = False
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.CmbClientes.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione el cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbClientes.SelectedIndex = 0
                Me.CmbClientes.Focus()
                Return False
            End If

            If Me.TxtDescripcion.Text = "" Then
                MessageBox.Show("Ingrese el Número de Cheque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.TxtDescripcion.Focus()
                Return False
            End If

            If Me.CmbCuentas.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione el Banco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbCuentas.SelectedIndex = 0
                Me.CmbCuentas.Focus()
                Return False
            End If

            If CInt(Me.txtImporte.Text) = 0 Then
                MessageBox.Show("Ingrese el Importe del Cheque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtImporte.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Private Function Guardar() As Boolean
        Try
            Me.Chequespost.IdCliente = Me.CmbClientes.SelectedValue
            Me.Chequespost.FechaCaptura = Me.DtpFecha.Value
            Me.Chequespost.FechaCobro = Me.DtpFechaCobro.Value
            Me.Chequespost.IdBanco = Me.CmbCuentas.SelectedValue
            Me.Chequespost.Estatus = ClasesNegocio.EstatusChar.VIGENTE
            Me.Chequespost.Aplicar = False
            Me.Chequespost.Importe = Me.txtImporte.Text
            Me.Chequespost.IdUsuario = Controlador.Sesion.Usrndx
            Me.Chequespost.NumeroCheque = Me.TxtDescripcion.Text
            Me.Chequespost.FolioCobro = ""

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub PonerDatos()
        Me.CmbClientes.SelectedValue = Me.Chequespost.IdCliente
        Me.DtpFecha.Value = Me.Chequespost.FechaCaptura
        Me.DtpFechaCobro.Value = Me.Chequespost.FechaCobro
        Me.CmbCuentas.SelectedValue = Me.Chequespost.IdBanco
        lblEstatus.Text = Me.Chequespost.Estatus.ToString
        lblEstatus.Visible = True
        Me.txtImporte.Text = Me.Chequespost.Importe
        Me.TxtDescripcion.Text = Me.Chequespost.NumeroCheque()
    End Sub

    Private Sub Imprimir()
        Try
            ChequesPostCol = New CN.ChequesPosfechadosCollectionClass
            ChequesPostCol.Add(Chequespost)
            Dim Reporte As New CN.RptChequesPostFechados
            Reporte = ChequesPostCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)

            Dim Visualizar As New FrmReportes
            Visualizar.CRV.ReportSource = Reporte
            Visualizar.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Me.Chequespost.Estatus = ClasesNegocio.EstatusChar.CANCELADO Then
                MessageBox.Show("No se puede cancelar el cheque, Ya habia sido cancelado anteriormente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el cheque?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If
            Me.Chequespost.Estatus = ClasesNegocio.EstatusChar.CANCELADO
            If Me.Chequespost.Borrar() Then
                MessageBox.Show("El cheque a sido cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DesHabilitar()
                Limpiar()
                Me.ChequesPostCol.Obtener(ClasesNegocio.EstatusChar.TODOS)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        DesHabilitar()
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Or Not Guardar() Then
                Cancelar = True
                Exit Sub
            End If
            If Not Me.Chequespost.Guardar() Then
                MessageBox.Show("No se ha podido Guardar la Información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
                Exit Sub
            Else
                MessageBox.Show("La información ha sido Guardadda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ChequesPostCol.Obtener(ClasesNegocio.EstatusChar.TODOS)
                DesHabilitar()
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Habilitar()
        Limpiar()
        Me.CmbClientes.Focus()
        Me.Chequespost = New CN.ChequesPosfechadosClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub DgvCheques_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvCheques.DataError

    End Sub

    Private Sub DgvCheques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCheques.DoubleClick
        Try
            If Me.DgvCheques.SelectedRows.Count > 0 Then
                Me.Chequespost = New CN.ChequesPosfechadosClass
                Chequespost = DirectCast(Me.DgvCheques.SelectedRows(0).DataBoundItem, CN.ChequesPosfechadosClass)
                PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtImporte_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.GotFocus
        If Not Me.txtImporte.Text = "" Then
            Me.txtImporte.Text = Me.txtImporte.Text.Replace("$", "").Replace(".00", "")
        End If
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        If (Not IsNumeric(txtImporte.Text) AndAlso Not e.KeyChar = Chr(18) AndAlso Not e.KeyChar = ".") OrElse (e.KeyChar = "." AndAlso Me.txtImporte.Text.IndexOf(".") > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtImporte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.LostFocus
        If Not Me.txtImporte.Text = "" Then
            Me.txtImporte.Text = Me.txtImporte.Text.ToString("C2")
        Else
            Me.txtImporte.Text = "0".ToString("C2")
        End If
    End Sub
End Class