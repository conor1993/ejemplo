Imports CN = ClasesNegocio
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Public Class CancelacionPagoAProveedoresForm

    Dim Pagos As CN.PagosProveedoresColeccionClass
    Dim proveedores As New CN.ProveedorCollectionClass
    Dim Cheques As New TC.VwpagosaProveedoresTypedView
    Dim Cheque As CN.ChequeClass
    Dim Poliza As CN.PolizaClass
    Dim UltimaTeclaProv As DateTime
    Dim MovBancos As CN.MovimientosBancosClass

    Private Sub CancelacionPagoAProveedoresForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With Controlador.Sesion.MiEmpresa
                Me.lblEmpresa.Text = .Empnom
            End With
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "111101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "111101111"
            MtbEstados.StateNuevo = "011011001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "111111111"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            ' Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Cancelación."
            'Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(7).ToolTipText = "Cancela el Pago a Proveedores Seleccionado."
            'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Factura."
            ' Me.mtb.Buttons(10).ToolTipText = "Imprime las Ciudades Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."
            Me.DgvPagos.AutoGenerateColumns = False
            Me.DgvFacturas.AutoGenerateColumns = False
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            Me.CmbProveedor.DataSource = proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.ValueMember = "codigo"
            Me.DgvPagos.DataSource = Cheques
            Me.DgvFacturas.DataSource = Pagos
            Limpiar()
            proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Pagos = New CN.PagosProveedoresColeccionClass
            Cheque = New CN.ChequeClass
            Poliza = New CN.PolizaClass
            Limpiar()
            Habilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Limpiar()
        Me.CmbProveedor.SelectedIndex = -1
        Me.CmbProveedor.Text = "Seleccione un Proveedor"
        Me.DgvPagos.DataSource = Nothing
        Me.DgvFacturas.DataSource = Nothing
        Me.lblEstatus.Visible = False
    End Sub
    Public Sub Habilitar()
        Me.CmbProveedor.Enabled = True
        Me.DgvPagos.Enabled = True
    End Sub
    Public Sub Deshabilitar()
        Me.CmbProveedor.Enabled = False
        Me.DgvPagos.Enabled = False
    End Sub

#Region "Mitollbar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            Dim SaldoAnterior As Decimal = Cheque.Cuenta.SaldoActual
            If Cheque.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
                MsgBox("El Pago ya fué Cancelado...", MsgBoxStyle.Information, "Aviso")
                Cancelar = True
            Else
                Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelacion")
                'ojoo
                If Me.Cheque.Entregado Then
                    MsgBox("El Cheque ya fué Entregado, Imposible Cancelar", MsgBoxStyle.Information, "Aviso")
                    Cancelar = True
                Else
                    'If MsgBox("¿Desea que se Genere una Póliza de Diario con Movimientos en Negativo?" & vbNewLine & "De lo Contrario Se Generará una Póliza de Cancelación.", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                    '    Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
                    'Else
                    Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
                    'End If
                    If MsgBox("¿Desea Realmente Cancelar el Pago?", MsgBoxStyle.YesNoCancel, "Confirmación") = MsgBoxResult.Yes Then
                        GenerarPoliza()
                        If Poliza.Guardar(tr) Then
                            Cheque.ObtenerEntidad.PolizaIdCancelacion = Poliza.Codigo
                            If Cheque.Borrar(tr) Then

                                ''--------------------------------------------------------------------
                                ''--------------------------------------------------------------------

                                MovBancos = New CN.MovimientosBancosClass() '(cheque.Poliza.Codigo, cheque.Cuenta.Codigo)
                                MovBancos.NumPoliza = Cheque.PolizaCancelacion.Codigo
                                MovBancos.FechaCaptura = Cheque.Poliza.FechaCaptura
                                MovBancos.FechaMov = Now
                                MovBancos.Concepto = Cheque.PolizaCancelacion.Concepto
                                MovBancos.CveCancelacion = "S"
                                MovBancos.Referencia = Cheque.Poliza.Codigo
                                MovBancos.CtaBancaria = Cheque.Cuenta.Codigo
                                MovBancos.SaldoAnterior = SaldoAnterior
                                MovBancos.TipoMov = "D"
                                MovBancos.Origen = "P"
                                'MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)
                                MovBancos.Importe = Cheque.Importe

                                If Not MovBancos.Guardar(tr) Then
                                    tr.Rollback()
                                    Cancelar = True
                                    MsgBox("El Cheque no pudo ser Cancelado...", MsgBoxStyle.Critical, "Error")
                                End If

                                ''-------------------------------------------------------------------
                                ''-------------------------------------------------------------------

                                For Each Pago As CN.PagosProveedoresClass In Pagos
                                    'Si se supone qe no deja qe cancele si el cheque ya fue entregado por lo tanto
                                    'el saldo de las facturas no se ha afectado
                                    'y no se debe afectar aki tampoco
                                    Dim Facturas As New CC.UsrCxpfacturasCabCollection
                                    Facturas.GetMulti(HC.UsrCxpfacturasCabFields.NoFactura = Pago.NoFactura)
                                    Facturas(0).Saldo = Facturas(0).Saldo + Pago.Importe
                                    If Facturas(0).Saldo = Facturas(0).Total Then
                                        Facturas(0).Estatus = CN.EstatusFacturasEnum.VIGENTE
                                    ElseIf Facturas(0).Saldo > 0 Then
                                        Facturas(0).Estatus = CN.EstatusFacturasEnum.ABONADA
                                    End If
                                    Facturas(0).Save()
                                    'Dim FacturasApagar As New CN.FacturasAPagarCXPColeccion
                                    'FacturasApagar.Obtener(Pago.Proveedor.Codigo, Pago.NoFactura)
                                    'For Each factura As CN.FacturasAPagarCxP In FacturasApagar
                                    '    factura.Estatus = ClasesNegocio.EstatusFacturasApagar.AUTORIZADA
                                    '    factura.Guardar()
                                    'Next
                                    Pago.PolizaIdCancelacion = Poliza.Codigo
                                    Pago.IdUsuarioCancelacion = Controlador.Sesion.Usrndx
                                    Pago.Borrar()
                                Next
                                tr.Commit()
                                MsgBox(String.Format("Los Pagos al Proveedor del Cheque: {0}  han sido Cancelados Satisfactoriamente...", Cheque.Folio), MsgBoxStyle.Information, "Aviso")
                                Impresion()
                                Limpiar()
                                Deshabilitar()
                            Else
                                tr.Rollback()
                                Cancelar = True
                                MsgBox("Los Pagos al Proveedor no pudieron ser Cancelados", MsgBoxStyle.Critical, "Error")
                            End If
                        Else
                            tr.Rollback()
                            Cancelar = True
                            MsgBox("Los Pagos al Proveedor no pudieron ser Cancelados", MsgBoxStyle.Critical, "Error")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    'Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
    '    'Ojooo
    '    proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
    '    Pagos = New CN.PagosProveedoresColeccionClass
    '    Cheque = New CN.ChequeClass
    '    Poliza = New CN.PolizaClass
    '    Limpiar()
    '    Habilitar()
    'End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub GenerarPoliza()
        Try
            'Me.Poliza.Referencia = Cheque.Folio  ' El Folio del cheque
            Me.Poliza.Referencia = Cheque.IdPoliza ' El Folio del cheque
            Dim Empresa As New CN.EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
            Poliza.Concepto = Cheque.Concepto
            Poliza.Empresa = Empresa
            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            Poliza.FechaCaptura = Now
            Poliza.FechaPoliza = Now
            Poliza.Importe = Me.Cheque.Importe
            'Poliza.Referencia = Cheque.Poliza.Folio
            Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.CUENTASxPAGAR
            Poliza.TipoCambio = Cheque.TipoCambio
            Poliza.TipoError = 0
            If Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION Then
                For Each Detalle As CN.PolizaDetalleClass In Cheque.Poliza.Detalles
                    If Detalle.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO Then
                        Dim polizaDet As New CN.PolizaDetalleClass
                        polizaDet.CuentaContable = Detalle.CuentaContable
                        polizaDet.Importe = Detalle.Importe
                        polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                        polizaDet.Posicion = 0
                        Poliza.AgregarDetalle(polizaDet)
                    ElseIf Detalle.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO Then
                        Dim polizaDet As New CN.PolizaDetalleClass
                        polizaDet.CuentaContable = Detalle.CuentaContable
                        polizaDet.Importe = Detalle.Importe
                        polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                        polizaDet.Posicion = 1
                        Poliza.AgregarDetalle(polizaDet)
                    End If
                Next
            Else
                For Each Detalle As CN.PolizaDetalleClass In Cheque.Poliza.Detalles
                    If Detalle.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO Then
                        Dim polizaDet As New CN.PolizaDetalleClass
                        polizaDet.CuentaContable = Detalle.CuentaContable
                        polizaDet.Importe = Detalle.Importe * (-1)
                        polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                        polizaDet.Posicion = 0
                        Poliza.AgregarDetalle(polizaDet)
                    ElseIf Detalle.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO Then
                        Dim polizaDet As New CN.PolizaDetalleClass
                        polizaDet.CuentaContable = Detalle.CuentaContable
                        polizaDet.Importe = Detalle.Importe * (-1)
                        polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                        polizaDet.Posicion = 1
                        Poliza.AgregarDetalle(polizaDet)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Impresion()
        Try
            If Not IsNothing(Cheque) Then
                'Ojooo
                ImprimirCheque.Cheque = Cheque
                ppDg.ShowDialog()
                If Not Cheque.Emitido Then
                    If Cheque.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                        'ojo
                        PagoElectronico.Cheque = Cheque
                        pDg.Document = PagoElectronico
                        If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Try
                                'ojo
                                PagoElectronico.Print()
                                If MessageBox.Show("¿Se imprimió el comprobante?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    PagoElectronico.ImpresionExitosa()
                                    Cheque.Guardar()
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    Else
                        If MessageBox.Show("¿Desea imprimir la Póliza?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            'ojooo
                            ImprimirCheque.Cheque = Cheque
                            ImprimirCheque.AbonoEnCuenta = MessageBox.Show("¿Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            pDg.Document = ImprimirCheque
                            If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                                Try
                                    ImprimirCheque.Print()
                                    If MessageBox.Show("¿Se imprimio el cheque?", "Confirmación de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                        ImprimirCheque.ImpresionExitosa()
                                        Cheque.Guardar()
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End If
                        End If
                    End If
                Else
                    If Not Cheque.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", Cheque.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.CmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
                Me.CmbProveedor.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, False)
            Me.CmbProveedor.ValueMember = "IDProveedor"
            Me.CmbProveedor.DataSource = proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.SelectedIndex = -1
            Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            Me.TmProveedor.Stop()
            Me.UltimaTeclaProv = Now
            Me.TmProveedor.Start()
        End If
    End Sub

    Private Sub CmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedor.SelectedIndexChanged
        If Not IsNothing(Me.CmbProveedor.SelectedValue) Then
            Cheques = New TC.VwpagosaProveedoresTypedView
            Cheques.Fill(0, Nothing, True, HC.VwpagosaProveedoresFields.IdProveedor = Me.CmbProveedor.SelectedValue And HC.VwpagosaProveedoresFields.EmpresaId = Controlador.Sesion.Empndx)
            Me.DgvPagos.DataSource = Cheques
        End If
    End Sub

    Private Sub DgvPagos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPagos.CellClick
        If Me.DgvPagos.SelectedRows.Count > 0 Then
            Me.Pagos.Obtener(Me.DgvPagos.SelectedRows(0).Cells("ClmCheque").Value)
            Me.lblEstatus.Visible = True
            Me.lblEstatus.Text = Pagos(0).Estatus.ToString
            Me.DgvFacturas.DataSource = Pagos
            Dim ChequeSelect As New CN.ChequeCollectionClass
            ChequeSelect.Obtener(Me.DgvPagos.SelectedRows(0).Cells("ClmCheque").Value, Me.DgvPagos.SelectedRows(0).Cells("ClmPoliza").Value, Me.DgvPagos.SelectedRows(0).Cells("ClmImporte").Value)
            If ChequeSelect.Count = 1 Then
                Cheque = ChequeSelect(0)
            End If
        End If
    End Sub

    Private Sub DgvFacturas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvFacturas.DataError

    End Sub

    Private Sub DgvPagos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvPagos.DataError

    End Sub

    Private Sub DgvPagos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvPagos.SelectionChanged
        If Me.DgvPagos.SelectedRows.Count > 0 Then
            Me.Pagos.Obtener(Me.DgvPagos.SelectedRows(0).Cells("ClmCheque").Value)
            Me.lblEstatus.Visible = True
            Me.lblEstatus.Text = Pagos(0).Estatus.ToString
            Me.DgvFacturas.DataSource = Pagos
            Dim ChequeSelect As New CN.ChequeCollectionClass
            ChequeSelect.Obtener(Me.DgvPagos.SelectedRows(0).Cells("ClmCheque").Value, Me.DgvPagos.SelectedRows(0).Cells("ClmPoliza").Value, Me.DgvPagos.SelectedRows(0).Cells("ClmImporte").Value)
            If ChequeSelect.Count = 1 Then
                Cheque = ChequeSelect(0)
            End If
        End If
    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProv.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                proveedores.Obtener(False, Me.CmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class