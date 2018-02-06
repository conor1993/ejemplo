Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class RegistroFacGastosFrm

    Private Proveedores As New ClasesNegocio.ProveedorCollectionClass
    Private Factura As CN.FacturasCabCXPClass
    Private FacDet As CN.FacturaDetalleCXPColeccion
    Dim UltimaTeclaProveedor As Date
    Dim SumaCargo As Decimal
    Dim SumaAbono As Decimal
    Dim Buscar As Boolean = False

#Region "Métodos"
    Private Sub RellenarGridCuentas(ByVal Cta As ClasesNegocio.CuentaContableClass)
        Try
            Dim CtasBan As New CN.CuentaCollectionClass
            CtasBan.Obtener(Cta.Codigo)
            If CtasBan.Count > 0 Then
                MsgBox("Imposible obtener la cuenta, es una Cuenta Bancaria", MsgBoxStyle.Information, "Aviso")
            Else
                If CuentasRepetidas(Cta) Then
                    MsgBox("Imposible obtener la cuenta, Error de duplicidad", MsgBoxStyle.Information, "Aviso")
                Else
                    Dim i As Integer = Me.DgvCuentas.Rows.Count
                    If i <> 0 Then
                        If Me.DgvCuentas.Rows(0).Cells("ClmCtaMayor").Value = Cta.CuentaMayor And _
                        Me.DgvCuentas.Rows(0).Cells("ClmSubCta").Value = Cta.SubCuenta And _
                        Me.DgvCuentas.Rows(0).Cells("ClmSsbCta").Value = Cta.SSubCuenta And _
                        Me.DgvCuentas.Rows(0).Cells("ClmSssCta").Value = Cta.SSSubCuenta And _
                        Me.DgvCuentas.Rows(0).Cells("ClmDescripcion").Value = Cta.NombreCuenta Then
                            MsgBox("Imposible agregar cuenta contable duplicada", MsgBoxStyle.Information, "Aviso")
                        Else
                            If Not Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = "" Then
                                Me.DgvCuentas.Rows.Add()
                                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
                                Me.DgvCuentas.Rows.Add()
                            Else
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmSubCta").Value = Cta.SubCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmCargo").Value = 0
                                Me.DgvCuentas.Rows(i - 1).Cells("ClmAbono").Value = 0
                                Me.DgvCuentas.Rows.Add()
                            End If
                        End If
                    Else
                        Me.DgvCuentas.Rows.Add()
                        Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                        Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                        Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                        Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
                        Me.DgvCuentas.Rows.Add()
                    End If
                    If Me.DgvCuentas.Rows.Count = 1 Then
                        For j As Integer = 0 To Me.DgvCuentas.Columns.Count - 3
                            Me.DgvCuentas.Rows(0).Cells(j).ReadOnly = True
                        Next
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Rellenar cuentas con los importes de detalle de la factura
    Private Sub RellenarGridCuentasB(ByVal Cta As ClasesNegocio.CuentaContableClass, ByVal Importe As Decimal, ByVal Cargo As Boolean)
        Try
            Dim i As Integer = Me.DgvCuentas.Rows.Count
            Me.DgvCuentas.Rows.Add()
            If Cargo Then
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Importe.ToString("C2")
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
            Else
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Importe.ToString("C2")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Limpiar()
        Me.CmbProveedor.SelectedIndex = -1
        Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Me.txtCheque.Clear()
        Me.txtPoliza.Clear()
        Me.txtDiasPlazo.Text = ""
        Me.TxtFactura.Clear()
        Me.chkPagada.Checked = False
        Me.txtSubtotal.Text = 0.ToString("C2")
        Me.txtIva.Text = 0.ToString("C2")
        Me.TxtAnticipo.Text = 0.ToString("C2")
        Me.TxtTotal.Text = 0.ToString("C2")
        Me.txtObservaciones.Clear()
        Me.Txtconcepto.Clear()
        Me.lblEstatus.Visible = False
        Me.txtTasaIva.Text = 0.0
        Me.TxtTasaISR.Text = 0.0
        Me.TxtTasaRetIVA.Text = 0.0
        Me.TxtISR.Text = 0.ToString("C2")
        Me.txtRetIva.Text = 0.ToString("C2")
        Me.txtSumaAbono.Text = 0.ToString("C2")
        Me.txtSumaCargo.Text = 0.ToString("C2")
        Me.DgvCuentas.Rows.Clear()
        Buscar = False
        ckbFletes.Checked = False
        ckbHonorarios.Checked = False
        TxtIVAFlete.Text = 0.0
        TxtIVAFlete1.Text = 0.ToString("C2")
        Me.UUID.Text = ""
    End Sub

    Public Sub Habilitar()
        Me.CmbProveedor.Enabled = True
        Me.txtCheque.Enabled = True
        Me.txtPoliza.Enabled = True
        Me.DtpFechaFactura.Enabled = True
        Me.TxtFactura.Enabled = True
        Me.chkPagada.Enabled = True
        Me.txtSubtotal.Enabled = True
        'Me.txtIva.Enabled = True
        Me.TxtAnticipo.Enabled = True
        'Me.TxtTotal.Enabled = True
        Me.Txtconcepto.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtTasaIva.Enabled = True
        Me.TxtTasaISR.Enabled = True
        Me.TxtTasaRetIVA.Enabled = True
        'Me.TxtISR.Enabled = True
        'Me.txtRetIva.Enabled = True
        Me.DgvCuentas.Enabled = True
        ckbFletes.Enabled = True
        ckbHonorarios.Enabled = True
        TxtIVAFlete.Enabled = True
        'TxtIVAFlete1.Enabled = True
        Me.UUID.Enabled = True

    End Sub

    Public Sub Deshabilitar()
        Me.CmbProveedor.Enabled = False
        Me.txtCheque.Enabled = False
        Me.DtpFechaFactura.Enabled = False
        Me.DtpFechaVencimiento.Enabled = False
        Me.txtPoliza.Enabled = False
        Me.TxtFactura.Enabled = False
        Me.chkPagada.Enabled = False
        Me.txtSubtotal.Enabled = False
        Me.txtIva.Enabled = False
        Me.TxtAnticipo.Enabled = False
        'Me.TxtTotal.Enabled = False
        Me.Txtconcepto.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtTasaIva.Enabled = False
        Me.TxtTasaISR.Enabled = False
        Me.TxtTasaRetIVA.Enabled = False
        Me.TxtISR.Enabled = False
        Me.txtRetIva.Enabled = False
        Me.DgvCuentas.Enabled = False
        ckbFletes.Enabled = False
        ckbHonorarios.Enabled = False
        TxtIVAFlete.Enabled = False
        TxtIVAFlete1.Enabled = False
        Me.UUID.Enabled = False
    End Sub

    Private Sub PasarValores()
        Me.Factura.NoFactura = Me.TxtFactura.Text
        Me.Factura.FechaCaptura = Me.DtpFechaCaptura.Value
        Me.Factura.FechaFactura = Me.DtpFechaFactura.Value
        Me.Factura.FechaVencimiento = Me.DtpFechaVencimiento.Value
        Me.Factura.Total = Me.TxtTotal.Text
        Me.Factura.Iva = Me.txtIva.Text
        Me.Factura.ImporteIsr = Me.TxtISR.Text
        Me.Factura.ImporteRetIva = Me.txtRetIva.Text
        Me.Factura.Subtotal = Me.txtSubtotal.Text
        Me.Factura.Anticipo = Me.TxtAnticipo.Text
        Me.Factura.Saldo = Me.TxtTotal.Text
        Me.Factura.Observaciones = Me.txtObservaciones.Text
        Me.Factura.IdEmpresa = Controlador.Sesion.Empndx
        Me.Factura.IdUsuarioAlta = Controlador.Sesion.Usrndx
        Me.Factura.Servicios = False
        Me.Factura.Gastos = True
        Me.Factura.UUID = Me.UUID.Text

        Me.Factura.TasaIva = Me.txtTasaIva.Text
        Me.Factura.Concepto = Me.Txtconcepto.Text

        If ckbHonorarios.Checked = True Then
            Me.Factura.TasaISR = Me.TxtTasaISR.Text
            Me.Factura.TasaRetIva = Me.TxtTasaRetIVA.Text
        End If
        'If ckbFletes.Checked = True Then

        'End If
    End Sub

    Private Function Validar() As Boolean
        If IsNothing(Me.CmbProveedor.SelectedValue) Then
            MsgBox("Seleccione un proveedor...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
        If Me.TxtFactura.Text = "" Then
            MsgBox("Teclee el Número de la Factura", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
        If CDec(Me.txtSubtotal.Text) = 0 Then
            MsgBox("No se puede Facturar por $0.")
            Return False
        End If
        If Me.DgvCuentas.Rows.Count <= 1 Then
            MsgBox("No ha relacionado las Cuentas Contables a Afectar.", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
        If Not CDec(Me.txtSumaAbono.Text) = CDec(Me.txtSumaCargo.Text) Then
            MsgBox("Las Sumas del Cargo y del Abono deben ser Equivalentes", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf Not CDec(Me.txtSumaAbono.Text) = CDec(Me.TxtTotal.Text) Then
            MsgBox("El importe de las Sumas de Cargos y Abonos debe ser Igual al Importe Total...", , "Aviso")
            Return False
        End If
        Dim facts As New CN.FacturaCabCXPColeccion
        facts.Obtener(Me.TxtFactura.Text, Me.CmbProveedor.SelectedValue)
        If facts.Count > 0 Then
            MsgBox("El número de Factura ya está Registrado...", MsgBoxStyle.Exclamation, "Aviso")
        End If
        Return True
    End Function

    Private Sub AgregarDetalles()
        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
            If Not Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = "" Then
                Dim CtaCon As New CN.CuentaContableCollectionClass
                Dim Det As New CN.FacturasDetalleCXPClass
                CtaCon.Obtener(, Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value, Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value, Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value, Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value, Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value, , , , , , )
                Det.CuentaContable = CtaCon(0)
                Det.EmpresaID = Controlador.Sesion.Empndx
                Det.Factura = Me.Factura
                Det.IdProveedor = Me.CmbProveedor.SelectedValue
                If Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value > 0 Then
                    Det.Importe = Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
                    Det.CargoOAbono = "C"
                ElseIf Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value > 0 Then
                    Det.Importe = Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
                    Det.CargoOAbono = "A"
                End If
                Me.FacDet.Add(Det)
                'Me.Factura.Detalles.Add(Det)
            End If
        Next
    End Sub

    Private Sub ObtenerValores()
        Me.CmbProveedor.SelectedValue = Me.Factura.Proveedor.Codigo
        Me.TxtFactura.Text = Me.Factura.NoFactura
        Me.DtpFechaFactura.Value = Factura.FechaFactura
        Me.DtpFechaVencimiento.Value = Factura.FechaVencimiento
        Me.DtpFechaCaptura.Value = Factura.FechaCaptura
        Me.TxtTotal.Text = Me.Factura.Saldo.ToString("C2")
        Me.txtIva.Text = Factura.Iva.ToString("C2")
        Me.TxtAnticipo.Text = Factura.Anticipo.ToString("C2")
        Me.TxtISR.Text = Me.Factura.ImporteIsr
        Me.txtRetIva.Text = Me.Factura.ImporteRetIva
        Me.txtSubtotal.Text = Me.Factura.Subtotal
        Me.txtObservaciones.Text = Me.Factura.Observaciones
        Me.TxtTasaISR.Text = Me.Factura.TasaISR
        Me.txtTasaIva.Text = Me.Factura.TasaIva
        Me.txtRetIva.Text = Me.Factura.TasaRetIva
        Me.txtSumaAbono.Text = Me.Factura.Total.ToString("C2")
        Me.txtSumaCargo.Text = Me.Factura.Total.ToString("C2")
        Me.TxtTasaISR.Text = Me.Factura.TasaISR.ToString
        Me.txtTasaIva.Text = Me.Factura.TasaIva.ToString
        Me.TxtTasaRetIVA.Text = Me.Factura.TasaRetIva.ToString
        Me.Txtconcepto.Text = Me.Factura.Concepto
        Me.UUID.Text = Me.Factura.UUID
    End Sub

    Private Sub ObtenerDetalle()
        Dim Detalles As New CN.FacturaDetalleCXPColeccion
        Detalles.Obtener(Me.Factura.NoFactura, Me.Factura.Proveedor.Codigo)
        For Each det As CN.FacturasDetalleCXPClass In Detalles
            If det.CargoOAbono = "C" Then
                Me.RellenarGridCuentasB(det.CuentaContable, det.Importe, True)
            Else
                Me.RellenarGridCuentasB(det.CuentaContable, det.Importe, False)
            End If
        Next
    End Sub

    'Metodo que valida que la cuenta no esté ya en el grid
    'cuentas repetidas
    Private Function CuentasRepetidas(ByVal cta As CN.CuentaContableClass) As Boolean
        Try
            For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                If cta.NombreCuenta = Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Sub Calculos()
        If Not IsNothing(Me.Factura) Then
            If Me.txtSubtotal.Text = "" Or Me.txtSubtotal.Text = "$" Then
                Me.txtSubtotal.Text = 0.ToString("C2")
            ElseIf Not Me.txtSubtotal.Text = "0" Then
                'Me.txtSubtotal.Text = CDec(Me.txtSubtotal.Text).ToString("C2")
                If Not IsNumeric(Me.txtTasaIva.Text) Then
                    Me.txtTasaIva.Text = "0.0"
                End If
                If Not IsNumeric(Me.TxtTasaRetIVA.Text) Then
                    Me.TxtTasaRetIVA.Text = "0.0"
                End If
                If Not IsNumeric(Me.TxtTasaISR.Text) Then
                    Me.TxtTasaISR.Text = "0.0"
                End If
                If Not IsNumeric(Me.TxtIVAFlete.Text) Then
                    Me.TxtTasaISR.Text = "0.0"
                End If
                Me.txtIva.Text = ((CDec(Me.txtSubtotal.Text) * CDec(Me.txtTasaIva.Text)) / 100).ToString("C2")
                Me.TxtISR.Text = (((CDec(Me.txtSubtotal.Text) + Me.txtIva.Text) * CDec(Me.TxtTasaISR.Text)) / 100).ToString("C2")
                Me.txtRetIva.Text = (((CDec(Me.txtSubtotal.Text) + Me.txtIva.Text) * CDec(Me.TxtTasaRetIVA.Text)) / 100).ToString("C2")
                Me.TxtIVAFlete1.Text = ((CDec(Me.txtSubtotal.Text) * CDec(Me.TxtIVAFlete.Text)) / 100).ToString("C2")
                If ckbHonorarios.Checked = True Then
                    Me.TxtIVAFlete.Text = 0.ToString("C2")
                    Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.txtRetIva.Text) - CDec(Me.TxtISR.Text) - CDec(Me.TxtAnticipo.Text)).ToString("C2")


                ElseIf ckbFletes.Checked = True Then
                    Me.TxtTasaRetIVA.Text = 0.ToString("C2")
                    Me.TxtTasaISR.Text = 0.ToString("C2")
                    Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) + CDec(Me.TxtIVAFlete1.Text) - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                Else
                    ckbFletes.Checked = False And ckbHonorarios.Checked = False
                    Me.TxtTasaRetIVA.Text = 0.ToString("C2")
                    Me.TxtTasaISR.Text = 0.ToString("C2")
                    Me.TxtIVAFlete.Text = 0.ToString("C2")
                    Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                End If

            End If
        End If
    End Sub

    Private Sub SugerirPorcentajes()
        Dim Conf As New CC.UsrConfigContabilidadCollection
        Conf.GetMulti(Nothing)
        Me.txtTasaIva.Text = CInt(Conf(0).Iva)
        Me.TxtTasaISR.Text = CInt(Conf(0).Isr)
        Me.TxtTasaRetIVA.Text = CInt(Conf(0).TasaRetencion)
    End Sub
#End Region

    'Private Sub RegistroFacGastosFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.F3 Then
    '        Dim buscarCuenta As New BusquedaCuentasContablesForm
    '        buscarCuenta.BloquearCaracteristicas = True
    '        buscarCuenta.Afectables = CheckState.Checked
    '        If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Me.RellenarGridCuentas(buscarCuenta.CuentaContable)
    '        End If
    '    End If
    'End Sub

    Private Sub RegistroFacGastosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Factura."
            Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Factura a Inactiva."
            Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Factura."
            ' Me.mtb.Buttons(10).ToolTipText = "Imprime las Ciudades Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")


            With Controlador.Sesion.MiEmpresa
                Me.lblEmpresa.Text = .Empnom
            End With
            'Proveedores.Obtener(Integra.Clases.EstatusEnum.ACTIVO)
            'Me.CmbProveedor.ValueMember = "IDProveedor"
            'Me.CmbProveedor.DataSource = Proveedores
            'Me.CmbProveedor.DisplayMember = "RazonSocial"

            Limpiar()
            Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProveedor.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                Proveedores.Obtener(False, Me.CmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedor.SelectedIndexChanged
        Try
            If Not IsNothing(Me.CmbProveedor.SelectedValue) Then
                If Buscar = False Then
                    Dim Prov As New CN.ProveedorCollectionClass
                    Dim Pr As CN.ProveedorClass = Prov.Obtener(Me.CmbProveedor.SelectedValue)
                    Me.Factura.Proveedor = Pr
                    Me.txtDiasPlazo.Text = Pr.DiasCredito
                    If Not IsNothing(Pr.CuentaContable2) Then
                        If Pr.CuentaContable2.CuentaMayor = "" Then
                            MsgBox("El proveedor no tiene una Cuenta Contable Asociada.")
                        Else
                            Me.DgvCuentas.Rows.Clear()
                            RellenarGridCuentas(Pr.CuentaContable2)
                        End If
                    Else
                        MsgBox("El Proveedor no tiene Cuenta Contable", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "ToolBaar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        'Es posible cancelar siempre y cuando no tenga cheques vigentes 
        If Me.Factura.Estatus <> ClasesNegocio.EstatusFacturasEnum.CANCELADA Then
            Dim pag As New CN.PagosProveedoresColeccionClass
            pag.Obtener(Me.Factura.IdProveedor, Factura.NoFactura, Controlador.Sesion.Empndx, True)
            If pag.Count = 0 Then
                Factura.Estatus = ClasesNegocio.EstatusFacturasEnum.CANCELADA
                If Factura.Guardar() Then
                    MsgBox("La Factura fue cancelada satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                End If
            Else
                MsgBox("No es posible Cancelar la factura hay cheques emitidos")
                Limpiar()
            End If
        Else
            MsgBox("La Factura ya está cancelada...")
            Limpiar()
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar = True
        Me.CmbProveedor.DataSource = Proveedores
        Me.CmbProveedor.DisplayMember = "RazonSocial"
        Me.CmbProveedor.ValueMember = "Codigo"
        Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.CmbProveedor.SelectedIndex = -1
        Dim Busqueda As New BusquedaFacturasForm
        Busqueda.EsDeGastos = True
        If Busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Facturas_ As New CN.FacturaCabCXPColeccion
            Facturas_.Obtener(Busqueda.Factura, Busqueda.ProveedorID)
            If Facturas_.Count = 1 Then
                Me.Factura = Facturas_(0)
                ObtenerValores()
                ObtenerDetalle()
            End If
        End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Tran As New HC.Transaction(IsolationLevel.ReadCommitted, "Fac")
        Try
            If Validar() Then
                PasarValores()
                AgregarDetalles()
                If Factura.Guardar(Tran) Then
                    For Each Det As CN.FacturasDetalleCXPClass In FacDet
                        'Tran.Add(Det)
                        Det.Guardar(Tran)
                    Next
                    Tran.Commit()
                    MsgBox("La Factura se ha Guardado Satisfactoriamente...", MsgBoxStyle.Exclamation, "Aviso")
                    Limpiar()
                    Deshabilitar()
                Else
                    Tran.Rollback()
                    Cancelar = True
                    MsgBox("La Factura no pudo ser Guardada... Intente de Nuevo", MsgBoxStyle.Critical, "Error")
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.ValueMember = "codigo"
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.Factura = New CN.FacturasCabCXPClass
            FacDet = New CN.FacturaDetalleCXPColeccion
            Limpiar()
            Habilitar()
            ' El valor de  las tasas en la factura se dan en el constructor
            'Me.txtTasaIva.Text = Factura.TasaIva.ToString("N2")
            'Me.TxtTasaISR.Text = Factura.TasaISR.ToString("N2")
            'Me.TxtTasaRetIVA.Text = Factura.TasaRetIva.ToString("N2")
            SugerirPorcentajes()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "Keypress"
    Private Sub CmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProveedor.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If IsNothing(Me.CmbProveedor.SelectedValue) Then
                    MsgBox("Seleccione un Proveedor")
                    Me.CmbProveedor.Focus()
                Else
                    Me.TxtFactura.Focus()
                End If
            ElseIf e.KeyChar = Chr(Keys.F12) Then
                Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CmbProveedor.ValueMember = "IDProveedor"
                Me.CmbProveedor.DataSource = Proveedores
                Me.CmbProveedor.DisplayMember = "RazonSocial"
                Me.CmbProveedor.SelectedIndex = -1
                Me.CmbProveedor.Text = "Seleccione un Proveedor..."
            Else
                Me.TmProveedor.Stop()
                Me.UltimaTeclaProveedor = Now
                Me.TmProveedor.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub TxtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.DtpFechaFactura.Focus()
            If Me.TxtFactura.Text = "" Then
                MsgBox("Agregue Información a el No. de Factura. . . ")
                TxtFactura.Focus()
            Else
                Dim facts As New CN.FacturaCabCXPColeccion
                facts.Obtener(Me.TxtFactura.Text, Me.CmbProveedor.SelectedValue)
                If facts.Count > 0 Then
                    MsgBox("El número de Factura ya fue registrado...")
                    Me.TxtFactura.Clear()
                    Me.TxtFactura.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub DtpFechaFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(Me.txtDiasPlazo.Text) <> "" Then
                Me.DtpFechaVencimiento.Value = Me.DtpFechaFactura.Value.AddDays(CInt(Me.txtDiasPlazo.Text))
            End If
            Me.Txtconcepto.Focus()
        End If
    End Sub

    Private Sub txtTasaIva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTasaIva.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtTasaIva.Text <> "" Then
                Me.TxtTasaISR.Focus()
            End If
        End If
    End Sub

    Private Sub TxtTasaISR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTasaISR.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.TxtTasaISR.Text <> "" Then
                Me.TxtTasaRetIVA.Focus()
            End If
        End If

    End Sub

    Private Sub TxtTasaRetIVA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTasaRetIVA.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.TxtTasaRetIVA.Text <> "" Then
                Me.txtSubtotal.Focus()
            End If
        End If

    End Sub

    Private Sub Txtconcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtconcepto.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub
#End Region

#Region "Importes"

    Private Sub txtSubtotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubtotal.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim Subtotal As Decimal = CDec(Me.txtSubtotal.Text)
            Me.txtSubtotal.Text = Subtotal.ToString("C2")
            Me.TxtAnticipo.Focus()
        End If
    End Sub
    Private Sub txtSubtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubtotal.TextChanged
        Try
            If Not IsNumeric(Me.txtSubtotal.Text) Then
                MsgBox("Teclee una cantidad válida")
                Me.txtSubtotal.Text = "0.0"
                Me.txtSubtotal.Focus()
            Else
                Calculos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub TxtAnticipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAnticipo.TextChanged
        Try
            If Not IsNumeric(Me.TxtAnticipo.Text) Then
                MsgBox("Teclee una cantidad válida")
                Me.TxtAnticipo.Text = "0.0"
                Me.TxtAnticipo.Focus()
            Else
                If Not IsNothing(Me.Factura) Then
                    If Me.TxtAnticipo.Text = "" Then
                        Me.TxtAnticipo.Text = 0.ToString("C2")
                        Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.txtRetIva.Text) - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                    Else
                        'Me.TxtAnticipo.Text = CDec(Me.TxtAnticipo.Text).ToString("C2")
                        Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.txtRetIva.Text) - CDec(Me.TxtAnticipo.Text)).ToString("C2")
                    End If
                    If CDec(Me.TxtAnticipo.Text) > CDec(Me.TxtTotal.Text) Then
                        MsgBox("El Anticipo no puede ser Mayor al Importe Total...", MsgBoxStyle.Exclamation, "Advertencia")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

    Private Sub DgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellEndEdit
        Try
            If e.ColumnIndex = Me.ClmCargo.Index Or e.ColumnIndex = Me.ClmAbono.Index Then
                SumaCargo = 0
                SumaAbono = 0
                If Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "" Or Not IsNumeric(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("C2")
                Else
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString("C2")
                End If
                If Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmCargo").Value < 0 Or Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmAbono").Value < 0 Then
                    MsgBox("La cantidad no puede ser Menor a 0.", MsgBoxStyle.Exclamation, "Advertencia")
                End If

                'If e.ColumnIndex = Me.ClmCargo.Index Then
                For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                    SumaCargo = SumaCargo + Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
                Next
                'End If
                'If e.ColumnIndex = Me.ClmAbono.Index Then
                For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                    SumaAbono = SumaAbono + Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
                Next
                'End If
                Me.txtSumaCargo.Text = SumaCargo.ToString("C2")
                Me.txtSumaAbono.Text = SumaAbono.ToString("C2")
            ElseIf e.ColumnIndex = Me.ClmSubCta.Index Or e.ColumnIndex = Me.ClmSsbCta.Index Or e.ColumnIndex = Me.ClmSssCta.Index Then
                Dim CtasConts As New CN.CuentaContableCollectionClass
                Dim Cta As CN.CuentaContableClass = CtasConts.ObtenerCuentaContable(Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmCtaMayor").Value, Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmSubCta").Value, Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmSsbCta").Value, Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmSssCta").Value)
                If Not IsNothing(Cta) Then
                    Me.RellenarGridCuentas(Cta)
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub DgvCuentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvCuentas.KeyDown
        If e.KeyCode = Keys.F3 Then
            Try
                Dim buscarCuenta As New BusquedaCuentasContablesForm
                buscarCuenta.BloquearCaracteristicas = True
                'ojo
                'buscarCuenta.Afectables = CheckState.Checked
                If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.RellenarGridCuentas(buscarCuenta.CuentaContable)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
        If e.KeyCode = Keys.Delete Then
            If MsgBox("¿Desea Realmente Borrar el detalle?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                Exit Sub
            Else
                Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.SelectedRows(0))
                SumaCargo = 0
                SumaAbono = 0
                For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                    SumaCargo = SumaCargo + Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
                    SumaAbono = SumaAbono + Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
                Next            
                Me.txtSumaCargo.Text = SumaCargo.ToString("C2")
                Me.txtSumaAbono.Text = SumaAbono.ToString("C2")
            End If
        End If
    End Sub

    Private Sub txtDiasPlazo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiasPlazo.TextChanged
        Try
            If Me.txtDiasPlazo.Text = "" Then
                Me.txtDiasPlazo.Text = "0"
            End If
            Me.DtpFechaVencimiento.Value = DtpFechaFactura.Value.AddDays(CDec(Me.txtDiasPlazo.Text))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtTasaIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTasaIva.TextChanged
        If Not Me.txtTasaIva.Text = "0.0" Then
            Calculos()
        End If
    End Sub

    Private Sub TxtTasaISR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTasaISR.TextChanged
        Calculos()
    End Sub

    Private Sub TxtTasaRetIVA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTasaRetIVA.TextChanged
        Calculos()
    End Sub

    Private Sub DtpFechaFactura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFechaFactura.ValueChanged
        Try
            If Trim(Me.txtDiasPlazo.Text) <> "" Then
                Me.DtpFechaVencimiento.Value = Me.DtpFechaFactura.Value.AddDays(CInt(Me.txtDiasPlazo.Text))
            End If
        Catch ex As Exception
            MessageBox.Show("Error al sumar los dias de plazo a la fecha de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbHonorarios.CheckedChanged
        If ckbHonorarios.Checked = True Then

            Label15.Visible = True
            TxtTasaISR.Visible = True
            Label16.Visible = True
            TxtTasaRetIVA.Visible = True
            ckbFletes.Checked = False
        Else
            Label15.Visible = False
            TxtTasaISR.Visible = False
            Label16.Visible = False
            TxtTasaRetIVA.Visible = False
            TxtTasaISR.Text = 0.ToString("C2")
            TxtTasaRetIVA.Text = 0.ToString("C2")

        End If

    End Sub

    Private Sub ckbFletes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbFletes.CheckedChanged
        If ckbFletes.Checked = True Then
            Label23.Visible = True
            TxtIVAFlete.Visible = True
            ckbHonorarios.Checked = False
        Else
            Label23.Visible = False
            TxtIVAFlete.Visible = False
            TxtIVAFlete.Text = 0.ToString("C2")
        End If
    End Sub

    Private Sub TxtIVAFlete_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtIVAFlete.TextChanged
        'If Not Me.txtTasaIva.Text = "0.0" Then
        Calculos()
        'End If
    End Sub
End Class