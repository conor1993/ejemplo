Imports CN = ClasesNegocio
Public Class _390ConsultaProveedores
    '    'ojo
    Dim Proveedores As New CN.ProveedorCollectionClass
    Dim UltimaTeclaProv As DateTime
    Private Sub _390ConsultaProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            ' Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Consulta."
            'Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Factura a Inactiva."
            'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Factura."
            ' Me.mtb.Buttons(10).ToolTipText = "Imprime las Ciudades Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Nuevo")
            'ojo
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbProveedor.ValueMember = "Codigo"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            With Controlador.Sesion.MiEmpresa
                Me.lblEmpresa.Text = .Empnom
            End With

            Limpiar()
            'Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        Me.CmbProveedor.SelectedIndex = -1
        Me.CmbProveedor.Text = "Seleccione un Proveedor"
        Me.dtpFechaCorte.Value = Now
        Me.txtDias.Clear()
        Me.dgvFacturasconsaldo.DataSource = Nothing
        Me.dgvFacturasSaldadas.DataSource = Nothing
        Me.txtVencidos.Text = "0.0"
        Me.txtSinvencer.Text = "0.0"
        Me.txtSaldoGen.Text = "0.0"
        Me.txtVencidomenor30.Text = "0.0"
        Me.txtVencidoMayor30Menor60.Text = "0.0"
        Me.txtVencidoMayor60.Text = "0.0"
    End Sub
    Private Sub Habilitar()
        Me.CmbProveedor.Enabled = True
        Me.dtpFechaCorte.Enabled = True
        Me.txtDias.Enabled = True
        Me.dgvFacturasSaldadas.Enabled = True
        Me.dgvFacturasconsaldo.Enabled = True
    End Sub
    Private Sub Deshabilitar()
        Me.CmbProveedor.Enabled = False
        Me.dtpFechaCorte.Enabled = False
        Me.txtDias.Enabled = False
        Me.dgvFacturasSaldadas.Enabled = False
        Me.dgvFacturasconsaldo.Enabled = False
        'Me.txtVencidos.Enabled = False
        'Me.txtSinvencer.Enabled = False
        'Me.txtSaldoGen.Enabled = False
        'Me.txtVencidomenor30.Enabled = False
        'Me.txtVencidoMayor30Menor60.Enabled = False
        'Me.txtVencidoMayor60.Enabled = False
    End Sub
    Private Function ObtenerSaldosVencidos(ByVal Facs As CN.FacturaCabCXPColeccion) As Decimal
        Dim SaldoVencido As Decimal = 0
        For i As Integer = 0 To Facs.Count - 1
            If Now.ToShortDateString > Facs(i).FechaVencimiento.ToShortDateString Then
                SaldoVencido = Facs(i).Saldo + SaldoVencido
            End If
        Next
        Return SaldoVencido
    End Function
    Private Function ObtenerSaldosSinVencer(ByVal Facs As CN.FacturaCabCXPColeccion) As Decimal
        Dim SaldoVencido As Decimal = 0
        For i As Integer = 0 To Facs.Count - 1
            If Facs(i).FechaVencimiento.ToShortDateString > Now.ToShortDateString Then
                SaldoVencido = Facs(i).Saldo + SaldoVencido
            End If
        Next
        Return SaldoVencido
    End Function
    Private Function ObtenerSaldosMenorA30Dias(ByVal Facs As CN.FacturaCabCXPColeccion) As Decimal
        Dim SaldoVencido As Decimal = 0
        For i As Integer = 0 To Facs.Count - 1
            If Now.ToShortDateString > Facs(i).FechaVencimiento.ToShortDateString Then
                Dim Diferencia As Integer
                Diferencia = Now.DayOfYear - Facs(i).FechaVencimiento.DayOfYear
                If Diferencia < 30 Then
                    SaldoVencido = Facs(i).Saldo + SaldoVencido
                End If
            End If
        Next
        Return SaldoVencido
    End Function
    Private Function ObtenerSaldosMayorA30Dias(ByVal Facs As CN.FacturaCabCXPColeccion) As Decimal
        Dim SaldoVencido As Decimal = 0
        For i As Integer = 0 To Facs.Count - 1
            If Now.ToShortDateString > Facs(i).FechaVencimiento.ToShortDateString Then
                Dim Diferencia As Integer
                Diferencia = Now.DayOfYear - Facs(i).FechaVencimiento.DayOfYear
                If Diferencia >= 30 And Diferencia <= 60 Then
                    SaldoVencido = Facs(i).Saldo + SaldoVencido
                End If
            End If
        Next
        Return SaldoVencido
    End Function
    Private Function ObtenerSaldosMayorA60Dias(ByVal Facs As CN.FacturaCabCXPColeccion) As Decimal
        Dim SaldoVencido As Decimal = 0
        For i As Integer = 0 To Facs.Count - 1
            If Now.ToShortDateString > Facs(i).FechaVencimiento.ToShortDateString Then
                Dim Diferencia As Integer
                Diferencia = Now.DayOfYear - Facs(i).FechaVencimiento.DayOfYear
                If Diferencia > 60 Then
                    SaldoVencido = Facs(i).Saldo + SaldoVencido
                End If
            End If
        Next
        Return SaldoVencido
    End Function
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar

    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Deshabilitar()
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        'ojo
        Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.CmbProveedor.ValueMember = "Codigo"
        Me.CmbProveedor.DataSource = Proveedores
        Me.CmbProveedor.DisplayMember = "RazonSocial"
        'Habilitar()
        'Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub CmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.CmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
                Me.CmbProveedor.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "IDProveedor"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.SelectedIndex = -1
            Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            Me.TmProveedor.Stop()
            Me.UltimaTeclaProv = Now
            Me.TmProveedor.Start()
        End If
    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProv.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                Proveedores.Obtener(True, Me.CmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedor.SelectedIndexChanged
        If Not IsNothing(Me.CmbProveedor.SelectedValue) Then
            Dim Facturas As New CN.FacturaCabCXPColeccion
            Facturas.Obtener(Me.CmbProveedor.SelectedValue, Me.dtpFechaCorte.Value, True)
            Me.dgvFacturasconsaldo.AutoGenerateColumns = False
            Me.dgvFacturasconsaldo.DataSource = Facturas
            Me.txtVencidos.Text = (Me.ObtenerSaldosVencidos(Facturas).ToString("C2"))
            Me.txtSinvencer.Text = Me.ObtenerSaldosSinVencer(Facturas).ToString("C2")
            Me.txtVencidomenor30.Text = ObtenerSaldosMenorA30Dias(Facturas).ToString("C2")
            Me.txtVencidoMayor30Menor60.Text = Me.ObtenerSaldosMayorA30Dias(Facturas).ToString("C2")
            Me.txtVencidoMayor60.Text = Me.ObtenerSaldosMayorA60Dias(Facturas).ToString("C2")
            Dim Facturas_ As New CN.FacturaCabCXPColeccion
            Facturas_.Obtener(Me.CmbProveedor.SelectedValue, Me.dtpFechaCorte.Value, False)
            Me.dgvFacturasSaldadas.AutoGenerateColumns = False
            Me.dgvFacturasSaldadas.DataSource = Facturas_
            Me.txtSaldoGen.Text = (CDec(Me.txtSinvencer.Text) + CDec(Me.txtVencidos.Text)).ToString("C2")
        End If
    End Sub

    Private Sub dgvFacturasconsaldo_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFacturasconsaldo.DataError

    End Sub

    Private Sub dgvFacturasSaldadas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFacturasSaldadas.DataError

    End Sub

    
    Private Sub dtpFechaCorte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaCorte.ValueChanged
        If Not IsNothing(Me.CmbProveedor.SelectedValue) Then
            Dim Facturas As New CN.FacturaCabCXPColeccion
            Facturas.Obtener(Me.CmbProveedor.SelectedValue, Me.dtpFechaCorte.Value, True)
            Me.dgvFacturasconsaldo.AutoGenerateColumns = False
            Me.dgvFacturasconsaldo.DataSource = Facturas
            Me.txtVencidos.Text = (Me.ObtenerSaldosVencidos(Facturas).ToString("C2"))
            Me.txtSinvencer.Text = Me.ObtenerSaldosSinVencer(Facturas).ToString("C2")
            Me.txtVencidomenor30.Text = ObtenerSaldosMenorA30Dias(Facturas).ToString("C2")
            Me.txtVencidoMayor30Menor60.Text = Me.ObtenerSaldosMayorA30Dias(Facturas).ToString("C2")
            Me.txtVencidoMayor60.Text = Me.ObtenerSaldosMayorA60Dias(Facturas).ToString("C2")
            Dim Facturas_ As New CN.FacturaCabCXPColeccion
            Facturas_.Obtener(Me.CmbProveedor.SelectedValue, Me.dtpFechaCorte.Value, False)
            Me.dgvFacturasSaldadas.AutoGenerateColumns = False
            Me.dgvFacturasSaldadas.DataSource = Facturas_
            Me.txtSaldoGen.Text = (CDec(Me.txtSinvencer.Text) + CDec(Me.txtVencidos.Text)).ToString("C2")
        End If

    End Sub
End Class