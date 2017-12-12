Imports CN = ClasesNegocio
Public Class EntregaChequesAProveedoresForm

    Dim Cuentas As CN.CuentaCollectionClass
    Dim Cheques As New CN.ChequeCollectionClass
    Dim UltimaTecla As Date

    Private Sub EntregaChequesAProveedoresForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "111111111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "111111111"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "111111111"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        Me.mtb.Buttons(0).ToolTipText = "Busca los Cheque Entregados"
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
        Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Registro de Cheques Entregados."
        Me.mtb.Buttons(6).ToolTipText = "Guarda el Registro de Cheque o los cambios que se le hayan Realizado."
        'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del Banco."
        'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Banco."
        Me.mtb.Buttons(10).ToolTipText = "Imprime Los resgistros de Cheques Entregados."
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

        mtb.sbCambiarEstadoBotones("Cancelar")
        Limpiar()
        Me.Cuentas = New CN.CuentaCollectionClass
        Me.cmbCuenta.DisplayMember = "Cuenta"
        Me.cmbCuenta.ValueMember = "Codigo"
        Cuentas.Obtener(ClasesNegocio.EstatusEnum.ACTIVO)
        Me.cmbCuenta.DataSource = Cuentas
        Limpiar()
        Habilitar()
        Me.DgvCheques.AutoGenerateColumns = False
    End Sub

    Private Sub Limpiar()
        Me.cmbCuenta.SelectedIndex = -1
        Me.cmbCuenta.Text = "Seleccione una Cuenta Bancaria"
        Me.txtBanco.Clear()
        Me.txtCuentaHabiente.Clear()
        Me.DgvCheques.DataSource = Nothing
    End Sub
    Private Sub Deshabilitar()
        Me.cmbCuenta.Enabled = False
        Me.DgvCheques.Enabled = False
    End Sub
    Private Sub Habilitar()
        Me.cmbCuenta.Enabled = True
        Me.DgvCheques.Enabled = True
    End Sub

    Private Function Imprimir() As CN.RptEntregaCheques
        Try
            Dim reporte As New CN.RptEntregaCheques
            Dim ds As New DataSet
            Dim dt As New CN.DsEntregaCheques.DtEntregaChequesDataTable
            For Each ch As CN.ChequeClass In Cheques
                dt.AddDtEntregaChequesRow(ch.Folio, ch.FechaMovimiento, ch.Beneficiario.Beneficiario, ch.Importe, "", "")
            Next
            ds.Tables.Add(dt)
            reporte.SetDataSource(ds)
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            reporte.SetParameterValue(2, "Cuentas x Pagar/ Entrega de Cheques")
            Return reporte
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
    Private Sub cmbCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCuenta.KeyPress
        If e.KeyChar = Chr(13) Then

        End If
    End Sub

    Private Sub cmbCuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCuenta.SelectedIndexChanged
        If Not IsNothing(Me.cmbCuenta.SelectedValue) Then
            Dim cuenta As CN.CuentaClass = Me.cmbCuenta.SelectedItem
            Me.txtBanco.Text = cuenta.Banco.Descripcion
            Me.txtCuentaHabiente.Text = cuenta.CuentaHabiente
            Me.Cheques.Obtener(cmbCuenta.SelectedValue)
            Me.DgvCheques.AutoGenerateColumns = False
            Me.DgvCheques.DataSource = Cheques
        End If
    End Sub

#Region "Toolbar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar

    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    'Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
    '    Habilitar()
    'End Sub
    'Private Sub Guardar()
    '    ' se obtendran las facturas qe hayan sido pagadas con ese cheque y se modificaran en su
    '    'caso si ya estan pagadas o abonadas
    '    For Each che As CN.ChequeClass In Cheques
    '        'ojooo
    '        If che.Entregado Then
    '            che.FechaEntrega = Now
    '            Dim pagos As New CN.PagosProveedoresColeccionClass
    '            pagos.Obtener(che.Folio)
    '            For Each pago As CN.PagosProveedoresClass In pagos
    '                Dim Facturas As New CN.FacturasCabCXPClass
    '                Facturas.Obtener(Controlador.Sesion.Empndx, pago.Proveedor.Codigo, pago.NoFactura)
    '                Facturas.Saldo = Facturas.Saldo - pago.Importe
    '                If CDec(Facturas.Saldo) = 0D Then
    '                    Facturas.Estatus = CN.EstatusFacturasEnum.PAGADA
    '                Else
    '                    Facturas.Estatus = CN.EstatusFacturasEnum.ABONADA
    '                End If
    '                Facturas.Guardar()
    '                'Dim FacAp As New Integralab.ORM.EntityClasses.UsrCxpfacturasApagarEntity
    '                'If FacAp.FetchUsingPK(Controlador.Sesion.Empndx, pago.Proveedor.Codigo, pago.NoFactura) Then
    '                '    FacAp.Estatus = ClasesNegocio.EstatusFacturasApagar.PAGADA
    '                '    FacAp.Saldo = FacAp.Saldo - pago.Importe
    '                '    FacAp.ImporteApagar = 0
    '                '    FacAp.Save()
    '                'End If
    '            Next
    '        End If
    '    Next
    'End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            ' Guardar()
            If Me.Cheques.ObtenerColeccion.SaveMulti() Then
                MsgBox("Los Cheques Entregados han sido Guardados Satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
                Limpiar()
                'Deshabilitar()
            Else
                MsgBox("Los Cheques Entregados No pudieron ser Guardados", MsgBoxStyle.Critical, "Error")
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            If Cheques.Count > 0 Then
                Dim previsualizador As New CN.PreVisualizarForm
                previsualizador.Reporte = Imprimir()
                previsualizador.ShowDialog()
            Else
                Cheques.Obtener(0)
                Dim previsualizador As New CN.PreVisualizarForm
                previsualizador.Reporte = Imprimir()
                previsualizador.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    'Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
    '    Me.Cuentas = New CN.CuentaCollectionClass
    '    Cuentas.Obtener(ClasesNegocio.EstatusEnum.ACTIVO)
    '    Me.cmbCuenta.DisplayMember = "Cuenta"
    '    Me.cmbCuenta.ValueMember = "Codigo"
    '    Me.cmbCuenta.DataSource = Cuentas
    '    Limpiar()
    '    Habilitar()
    'End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub DgvCheques_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCheques.CellContentClick
        If e.ColumnIndex = Me.ClmEntregado.Index Then
            'If CBool(Me.DgvCheques.Rows(e.RowIndex).Cells("ClmEntregado").Value) Then
            Me.DgvCheques.EndEdit()
            'Me.DgvCheques.SelectedRows(e.RowIndex).Cells("ClmEntregado").Value = False
            'Dim ChequeSelect As New CN.ChequeCollectionClass
            'ChequeSelect.Obtener(Me.DgvCheques.Rows(e.RowIndex).Cells("ClmCheque").Value)
            'If ChequeSelect.Count = 1 Then
            '    'Ojo
            '    ChequeSelect(0).Entregado = False
            '    ChequeSelect(0).ObtenerEntidad.Save()
            'End If
            'Else
            '    Me.DgvCheques.Rows(e.RowIndex).Cells("ClmEntregado").Value = True
            '    Dim ChequeSelect As New CN.ChequeCollectionClass
            '    ChequeSelect.Obtener(Me.DgvCheques.Rows(e.RowIndex).Cells("ClmCheque").Value)
            '    If ChequeSelect.Count = 1 Then
            '        'Ojo
            '        ChequeSelect(0).Entregado = True
            '        ChequeSelect(0).ObtenerEntidad.Save()
            '    End If
            'End If
        End If
    End Sub

    Private Sub DgvCheques_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DgvCheques.RowsAdded
        'ojo
        If Cheques(e.RowIndex).Entregado Then
            Me.DgvCheques.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Khaki
        Else
            Me.DgvCheques.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    'Private Sub TmCuenta_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TmCuenta.Tick
    '    Try
    '        If Me.UltimaTecla.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
    '            Me.TmCuenta.Stop()
    '            Me.Cuentas.Obtener(Me.cmbCuenta.Text.Trim, ClasesNegocios.CondicionEstatusEnum.ACTIVO)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub
End Class