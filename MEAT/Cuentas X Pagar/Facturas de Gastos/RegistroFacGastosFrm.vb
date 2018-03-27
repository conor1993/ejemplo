Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Data.SqlClient

Public Class RegistroFacGastosFrm
    Dim Poliza As CN.PolizaClass
    Private Proveedores As New ClasesNegocio.ProveedorCollectionClass
    Private CXP As New ClasesNegocio.FacturasCXP
    Private Factura As CN.FacturasCabCXPClass
    Private FacDet As CN.FacturaDetalleCXPColeccion
    'Dim Poliza As CN.PolizaClass
    Dim UltimaTeclaProveedor As Date
    Dim SumaCargo As Decimal
    Dim SumaAbono As Decimal
    Dim Buscar As Boolean = False
    Dim gastos As CN.GastosDepartamentosClass
    Public Shared valor As Decimal
    Dim formato As String = "C4"
    Dim formatoImp As String = "N4"

    Dim Subtotal As Decimal
    Dim IVAA As Decimal
    Dim TotalAux As Decimal 'Se usa para comparar el total de cargos y abonos para el total de facturas
    Dim Editar As Boolean = False

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
                                Me.DgvCuentas.Rows(i).Cells("clmIDCuenta").Value = Cta.Codigo
                                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
                                Me.DgvCuentas.Rows.Add()
                            Else
                                Me.DgvCuentas.Rows(i - 1).Cells("clmIDCuenta").Value = Cta.Codigo
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
                        Me.DgvCuentas.Rows(i).Cells("clmIDCuenta").Value = Cta.Codigo
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
                Me.DgvCuentas.Rows(i).Cells("clmIDCuenta").Value = Cta.Codigo
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Importe.ToString(formato)
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
            Else
                Me.DgvCuentas.Rows(i).Cells("clmIDCuenta").Value = Cta.Codigo
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Importe.ToString(formato)
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
        Me.txtSubtotal.Text = 0.ToString(formato)
        Me.txtIva.Text = 0.ToString(formato)
        Me.TxtAnticipo.Text = 0.ToString(formato)
        Me.TxtTotal.Text = 0.ToString(formato)
        Me.txtObservaciones.Clear()
        Me.Txtconcepto.Clear()
        Me.lblEstatus.Visible = False
        Me.txtTasaIva.Text = 0.ToString(formatoImp)
        Me.TxtTasaISR.Text = 0.ToString(formatoImp)
        Me.TxtTasaRetIVA.Text = 0.ToString(formatoImp)
        Me.TxtISR.Text = 0.ToString(formato)
        Me.txtRetIva.Text = 0.ToString(formato)
        Me.txtSumaAbono.Text = 0.ToString(formato)
        Me.txtSumaCargo.Text = 0.ToString(formato)
        Me.DgvCuentas.Rows.Clear()
        Buscar = False
        ckbFletes.Checked = False
        ckbHonorarios.Checked = False
        TxtIVAFlete.Text = 0.ToString(formatoImp)
        TxtIVAFlete1.Text = 0.ToString(formato)
        Me.UUID.Text = ""
        Me.dgvDistribuciondeGastos.Rows.Clear()
        Me.dgvdistribuciongastosdet.Rows.Clear()
        SumaCargo = 0
        SumaAbono = 0

        Editar = False
    End Sub

    Public Sub Habilitar()
        Me.CmbProveedor.Enabled = True
        Me.txtCheque.Enabled = True
        Me.txtPoliza.Enabled = True
        Me.DtpFechaFactura.Enabled = True
        Me.TxtFactura.Enabled = True
        Me.chkPagada.Enabled = True
        Me.txtSubtotal.Enabled = True
        Me.txtIva.Enabled = True
        Me.TxtAnticipo.Enabled = True
        'Me.TxtTotal.Enabled = True
        Me.Txtconcepto.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtTasaIva.Enabled = True

        'Me.TxtTasaISR.Enabled = True
        'Me.TxtTasaRetIVA.Enabled = True
        'TxtIVAFlete.Enabled = True

        'Me.TxtISR.Enabled = True
        'Me.txtRetIva.Enabled = True


        Me.DgvCuentas.Enabled = True
        ckbFletes.Enabled = True
        ckbHonorarios.Enabled = True

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
        If ckbFletes.Checked = True Then
            Me.Factura.Ivaflete = Me.TxtIVAFlete1.Text
        Else
            Me.Factura.Ivaflete = 0
        End If
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
        If Not CDec(Me.txtSumaAbono.Text) = calcularSubtotal(False) Then
            'If Not CDec(Me.txtSumaAbono.Text) = CDec(Me.txtSumaCargo.Text) Then
            MsgBox("Las Sumas del Cargo y del Abono deben ser Equivalentes", MsgBoxStyle.Exclamation, "Aviso")
            Return False
            'ElseIf Not CDec(Me.txtSumaAbono.Text) = CDec(Me.TxtTotal.Text) Then
            '    MsgBox("El importe de las Sumas de Cargos y Abonos debe ser Igual al Importe Total...", , "Aviso")
            '    Return False
        End If

        If Me.txtSumaCargo.Text <> calcularSubtotal(False) Then
            MsgBox("La Suma de el (los) Cargo(s) no Coinciden con el Total de la Factura", MsgBoxStyle.Exclamation, "Error")
            Return False
        End If

        Dim facts As New CN.FacturaCabCXPColeccion
        facts.Obtener(Me.TxtFactura.Text, Me.CmbProveedor.SelectedValue, False, 0, 0)
        If facts.Count > 0 Then
            MsgBox("El número de Factura ya está Registrado...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
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
                Me.Factura.Detalles.Add(Det)
            End If
        Next
    End Sub

    Private Sub ObtenerValores()

        'If Factura.Ivaflete <> 0 Then
        '    ckbFletes.Checked = True
        '    Dim Conf As New CC.UsrConfigContabilidadCollection
        '    Conf.GetMulti(Nothing)
        '    Me.TxtIVAFlete.Text = CInt(Conf(0).Ivaflete)
        '    TxtIVAFlete1.Text = Me.Factura.Ivaflete.ToString(formato)

        'ElseIf Factura.TasaISR <> 0 And Factura.TasaRetIva <> 0 Then
        '    ckbHonorarios.Checked = True
        '    Dim Conf As New CC.UsrConfigContabilidadCollection
        '    Conf.GetMulti(Nothing)
        '    Me.TxtTasaISR.Text = CInt(Conf(0).Isr)
        '    Me.TxtTasaRetIVA.Text = CInt(Conf(0).TasaRetencion)
        '    TxtTasaISR.Text = Me.Factura.TasaISR.ToString(formato)
        '    TxtTasaRetIVA.Text = Me.Factura.TasaRetIva.ToString(formato)
        'Else
        '    TxtIVAFlete1.Text = 0
        '    TxtTasaISR.Text = 0
        '    TxtTasaRetIVA.Text = 0
        'End If
        Me.CmbProveedor.SelectedValue = Me.Factura.Proveedor.Codigo
        Me.TxtFactura.Text = Me.Factura.NoFactura
        Me.DtpFechaFactura.Value = Factura.FechaFactura
        Me.DtpFechaVencimiento.Value = Factura.FechaVencimiento
        Me.DtpFechaCaptura.Value = Factura.FechaCaptura
        Me.TxtTotal.Text = Me.Factura.Saldo.ToString(formato)
        Me.txtIva.Text = Factura.Iva.ToString(formato)
        Me.TxtAnticipo.Text = Factura.Anticipo.ToString(formato)
        Me.TxtISR.Text = Me.Factura.ImporteIsr
        Me.txtRetIva.Text = Me.Factura.ImporteRetIva
        Me.txtSubtotal.Text = Me.Factura.Subtotal.ToString(formato)
        Me.txtObservaciones.Text = Me.Factura.Observaciones
        Me.TxtTasaISR.Text = Me.Factura.TasaISR
        Me.txtTasaIva.Text = Me.Factura.TasaIva
        'Me.TxtTasaRetIVA.Text = Me.Factura.TasaRetIva
        'Me.txtSumaAbono.Text = Me.Factura.Total.ToString(formato)
        'Me.txtSumaCargo.Text = Me.Factura.Total.ToString(formato)
        Me.TxtTasaISR.Text = Me.Factura.TasaISR.ToString(formatoImp)
        Me.txtTasaIva.Text = Me.Factura.TasaIva.ToString(formato)
        Me.TxtTasaRetIVA.Text = Me.Factura.TasaRetIva.ToString(formatoImp)
        Me.Txtconcepto.Text = Me.Factura.Concepto
        Me.UUID.Text = Me.Factura.UUID
        If Factura.Ivaflete <> 0 Then
            ckbFletes.Checked = True
            Dim Conf As New CC.UsrConfigContabilidadCollection
            Conf.GetMulti(Nothing)
            Me.TxtIVAFlete.Text = CDec(Conf(0).Ivaflete).ToString(formatoImp)
            Dim ivaFlete As Decimal = Me.Factura.Ivaflete.ToString()
            ivaFlete = ivaFlete.ToString(formatoImp)
            TxtIVAFlete1.Text = ivaFlete
            ''TxtIVAFlete1.Text = Me.Factura.Ivaflete.ToString(formato)

        ElseIf Factura.TasaISR <> 0 And Factura.TasaRetIva <> 0 Then
            ckbHonorarios.Checked = True
            Dim Conf As New CC.UsrConfigContabilidadCollection
            Conf.GetMulti(Nothing)
            Me.TxtTasaISR.Text = CDec(Conf(0).Isr).ToString(formatoImp)
            Me.TxtTasaRetIVA.Text = CDec(Conf(0).TasaRetencion).ToString(formatoImp)
            TxtTasaISR.Text = Me.Factura.TasaISR.ToString(formatoImp)
            TxtTasaRetIVA.Text = Me.Factura.TasaRetIva.ToString(formatoImp)
        Else
            TxtIVAFlete1.Text = 0.ToString(formato)
            TxtTasaISR.Text = 0.ToString(formatoImp)
            TxtTasaRetIVA.Text = 0.ToString(formatoImp)
        End If

        Select Case (Me.Factura.Estatus)
            Case 0
                Me.lblEstatus.Text = "CANCELADA"
            Case 1
                Me.lblEstatus.Text = "PAGADA"
            Case 2
                Me.lblEstatus.Text = "VIGENTE"
            Case 3
                Me.lblEstatus.Text = "ABONADA"
        End Select
        'Me.chkServicio.Checked = Me.Fact.Servicios
        'Me.MtxtUUID.Text = Me.Fact.Uuid
        'If TxtIVAFlete1.Text = Me.Factura.Ivaflete.ToString(formato) Then
        '    ckbFletes.Checked = True
        '    Dim Conf As New CC.UsrConfigContabilidadCollection
        '    Conf.GetMulti(Nothing)
        '    Me.TxtIVAFlete.Text = CInt(Conf(0).Ivaflete)
        '    TxtIVAFlete1.Text = Me.Factura.Ivaflete.ToString(formato)

        'ElseIf TxtTasaISR.Text = Me.Factura.TasaISR.ToString(formato) Or TxtTasaRetIVA.Text = Me.Factura.TasaRetIva.ToString(formato) Then
        '    ckbHonorarios.Checked = True
        '    Dim Conf As New CC.UsrConfigContabilidadCollection
        '    Conf.GetMulti(Nothing)
        '    Me.TxtTasaISR.Text = CInt(Conf(0).Isr)
        '    Me.TxtTasaRetIVA.Text = CInt(Conf(0).TasaRetencion)
        '    TxtTasaISR.Text = Me.Factura.TasaISR.ToString(formato)
        '    TxtTasaRetIVA.Text = Me.Factura.TasaRetIva.ToString(formato)
        'Else
        '    TxtIVAFlete1.Text = 0
        '    TxtTasaISR.Text = 0
        '    TxtTasaRetIVA.Text = 0
        'End If
        'If TxtTasaISR.Text = Me.Factura.TasaISR.ToString(formato) Or TxtTasaRetIVA.Text = Me.Factura.TasaRetIva.ToString(formato) Then
        '    ckbHonorarios.Checked = True

        'Else

        'End If

        'If TxtIVAFlete.Text IsNot Nothing Then
        '    TxtIVAFlete.Text = 0.ToString(formato)
        'Else
        '    Me.TxtIVAFlete.Text = Me.Factura.Ivaflete
        'End If
        'Me.TxtIVAFlete.Text = Me.Factura.Ivaflete
        'Me.TxtIVAFlete1.Text = Me.Factura.Ivaflete


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
    Private Function CuentasRepetidas(ByVal cta As CN.CuentaContableClass, Optional ByVal eliminarRow As Boolean = False) As Boolean
        Try
            For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
                If cta.NombreCuenta = Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value Then
                    If (eliminarRow) Then
                        Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.Rows(i))
                    End If
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    'Private Function CuentasRepetidas(ByVal cta As CN.CuentaContableClass) As Boolean
    '    Try
    '        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
    '            If cta.NombreCuenta = Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value Then
    '                Return True
    '            End If
    '        Next
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Function

    Private Sub Calculos()
        If Not IsNothing(Me.Factura) Then
            If Me.txtSubtotal.Text = "" Or Me.txtSubtotal.Text = "$" Then
                Me.txtSubtotal.Text = 0.ToString(formato)
            ElseIf Not Me.txtSubtotal.Text = "0" Then
                'Me.txtSubtotal.Text = CDec(Me.txtSubtotal.Text).ToString(formato)
                If Not IsNumeric(Me.txtTasaIva.Text) Then
                    Me.txtTasaIva.Text = 0.ToString(formatoImp)
                End If
                If Not IsNumeric(Me.TxtTasaRetIVA.Text) Then
                    Me.TxtTasaRetIVA.Text = 0.ToString(formatoImp)
                End If
                If Not IsNumeric(Me.TxtTasaISR.Text) Then
                    Me.TxtTasaISR.Text = 0.ToString(formatoImp)
                End If
                If Not IsNumeric(Me.TxtIVAFlete.Text) Then
                    Me.TxtIVAFlete.Text = 0.ToString(formatoImp)
                End If
                Me.txtIva.Text = ((CDec(Me.txtSubtotal.Text) * CDec(Me.txtTasaIva.Text)) / 100).ToString(formato)
                Me.TxtISR.Text = (((CDec(Me.txtSubtotal.Text) + Me.txtIva.Text) * CDec(Me.TxtTasaISR.Text)) / 100).ToString(formato)
                Me.txtRetIva.Text = (((CDec(Me.txtSubtotal.Text) + Me.txtIva.Text) * CDec(Me.TxtTasaRetIVA.Text)) / 100).ToString(formato)
                Me.TxtIVAFlete1.Text = ((CDec(Me.txtSubtotal.Text) * CDec(Me.TxtIVAFlete.Text)) / 100).ToString(formato)
                If ckbHonorarios.Checked = True Then
                    Me.TxtIVAFlete.Text = 0.ToString(formatoImp)
                    Me.TxtTotal.Text = ((CDec(txtSubtotal.Text) + CDec(txtIva.Text) + CDec(TxtIVAFlete1.Text)) - (CDec(TxtISR.Text) + CDec(txtRetIva.Text) + CDec(TxtAnticipo.Text))).ToString(formato)
                    'Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.txtRetIva.Text) - CDec(Me.TxtISR.Text) - CDec(Me.TxtAnticipo.Text)).ToString(formato)


                ElseIf ckbFletes.Checked = True Then
                    Me.TxtTasaRetIVA.Text = 0.ToString(formatoImp)
                    Me.TxtTasaISR.Text = 0.ToString(formatoImp)
                    Me.TxtTotal.Text = ((CDec(txtSubtotal.Text) + CDec(txtIva.Text) + CDec(TxtIVAFlete1.Text)) - (CDec(TxtISR.Text) + CDec(txtRetIva.Text) + CDec(TxtAnticipo.Text))).ToString(formato)
                    'Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) + CDec(Me.TxtIVAFlete1.Text) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                Else
                    ckbFletes.Checked = False And ckbHonorarios.Checked = False
                    Me.TxtTasaRetIVA.Text = 0.ToString(formatoImp)
                    Me.TxtTasaISR.Text = 0.ToString(formatoImp)
                    Me.TxtIVAFlete.Text = 0.ToString(formatoImp)
                    Me.TxtTotal.Text = ((CDec(txtSubtotal.Text) + CDec(txtIva.Text) + CDec(TxtIVAFlete1.Text)) - (CDec(TxtISR.Text) + CDec(txtRetIva.Text) + CDec(TxtAnticipo.Text))).ToString(formato)
                    'Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                End If

            End If

        End If

    End Sub

    Private Sub Calculos2()
        If Not IsNothing(Me.Factura) Then
            If Me.txtIva.Text = "" Or Me.txtIva.Text = "$" Then
                Me.txtIva.Text = 0.ToString(formato)
            ElseIf Not Me.txtIva.Text = "0" Then
                'Me.txtSubtotal.Text = CDec(Me.txtSubtotal.Text).ToString(formato)
                If Not IsNumeric(Me.txtTasaIva.Text) Then
                    Me.txtTasaIva.Text = 0.ToString(formatoImp)
                End If
                If Not IsNumeric(Me.TxtTasaRetIVA.Text) Then
                    Me.TxtTasaRetIVA.Text = 0.ToString(formatoImp)
                End If
                If Not IsNumeric(Me.TxtTasaISR.Text) Then
                    Me.TxtTasaISR.Text = 0.ToString(formatoImp)
                End If
                If Not IsNumeric(Me.TxtIVAFlete.Text) Then
                    Me.TxtIVAFlete.Text = 0.ToString(formatoImp)
                End If
                'Me.txtIva.Text = ((CDec(Me.txtSubtotal.Text) * CDec(Me.txtTasaIva.Text)) / 100).ToString(formato)
                Me.TxtISR.Text = (((CDec(Me.txtSubtotal.Text) + Me.txtIva.Text) * CDec(Me.TxtTasaISR.Text)) / 100).ToString(formato)
                Me.txtRetIva.Text = (((CDec(Me.txtSubtotal.Text) + Me.txtIva.Text) * CDec(Me.TxtTasaRetIVA.Text)) / 100).ToString(formato)
                Me.TxtIVAFlete1.Text = ((CDec(Me.txtSubtotal.Text) * CDec(Me.TxtIVAFlete.Text)) / 100).ToString(formato)
                If ckbHonorarios.Checked = True Then
                    Me.TxtIVAFlete.Text = 0.ToString(formatoImp)
                    Me.TxtTotal.Text = ((CDec(txtSubtotal.Text) + CDec(txtIva.Text) + CDec(TxtIVAFlete1.Text)) - (CDec(TxtISR.Text) + CDec(txtRetIva.Text) + CDec(TxtAnticipo.Text))).ToString(formato)
                    'Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.txtRetIva.Text) - CDec(Me.TxtISR.Text) - CDec(Me.TxtAnticipo.Text)).ToString(formato)


                ElseIf ckbFletes.Checked = True Then
                    Me.TxtTasaRetIVA.Text = 0.ToString(formatoImp)
                    Me.TxtTasaISR.Text = 0.ToString(formatoImp)
                    Me.TxtTotal.Text = ((CDec(txtSubtotal.Text) + CDec(txtIva.Text) + CDec(TxtIVAFlete1.Text)) - (CDec(TxtISR.Text) + CDec(txtRetIva.Text) + CDec(TxtAnticipo.Text))).ToString(formato)
                    'Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) + CDec(Me.TxtIVAFlete1.Text) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                Else
                    ckbFletes.Checked = False And ckbHonorarios.Checked = False
                    Me.TxtTasaRetIVA.Text = 0.ToString(formatoImp)
                    Me.TxtTasaISR.Text = 0.ToString(formatoImp)
                    Me.TxtIVAFlete.Text = 0.ToString(formatoImp)
                    Me.TxtTotal.Text = ((CDec(txtSubtotal.Text) + CDec(txtIva.Text) + CDec(TxtIVAFlete1.Text)) - (CDec(TxtISR.Text) + CDec(txtRetIva.Text) + CDec(TxtAnticipo.Text))).ToString(formato)
                    'Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
                End If

            End If

        End If

    End Sub

    Private Sub SugerirPorcentajes()
        Dim Conf As New CC.UsrConfigContabilidadCollection
        Conf.GetMulti(Nothing)
        Me.txtTasaIva.Text = CDec(Conf(0).Iva).ToString(formatoImp)
        Me.TxtTasaISR.Text = CDec(Conf(0).Isr).ToString(formatoImp)
        Me.TxtTasaRetIVA.Text = CDec(Conf(0).TasaRetencion).ToString(formatoImp)
        Me.TxtIVAFlete.Text = CDec(Conf(0).Ivaflete).ToString(formatoImp)
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

            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Factura."
            Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Factura a Inactiva."

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
    'Mee
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        'Es posible cancelar siempre y cuando no tenga cheques vigentes 
        Try
            If Me.Factura.Estatus <> ClasesNegocio.EstatusFacturasEnum.CANCELADA Then
                If Me.Factura.Contabilizada = "S" Then
                    MsgBox("La Factura no puede ser cancelada porque ya esta contabilizada")
                    Limpiar()
                Else
                    Dim pag As New CN.PagosProveedoresColeccionClass
                    pag.Obtener(Me.Factura.IdProveedor, Factura.NoFactura, Controlador.Sesion.Empndx, True)
                    If pag.Count = 0 Then
                        Factura.Estatus = ClasesNegocio.EstatusFacturasEnum.CANCELADA
                        If Factura.Guardar() Then
                            Dim NumeroFactura As String = Factura.NoFactura
                            Dim FactPagar As New CN.FacturasAPagarCXPColeccion
                            FactPagar.Obtener(Me.Factura.IdProveedor, Factura.NoFactura)
                            If FactPagar.Count = 1 Then
                                FactPagar.ObtenerColeccion.DeleteMulti()
                            End If
                            CXP.CancelarFactura(NumeroFactura)
                            MsgBox("La Factura fue cancelada satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
                            Limpiar()
                        End If
                    Else
                        MsgBox("No es posible Cancelar la factura hay cheques emitidos")
                        Limpiar()
                    End If
                End If

            Else
                MsgBox("No es posible Cancelar la factura, ya está cancelada")
                Limpiar()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Dim Busqueda As New BusquedaFacturasForm
        Busqueda.EsDeGastos = True
        If Busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Busqueda.Ifacturacancelada = 0 Then
                Dim Facturas_ As New CN.FacturaCabCXPColeccion
                Facturas_.Obtener(Busqueda.Factura, Busqueda.ProveedorID)
                Editar = True
                If Facturas_.Count = 1 Then
                    Me.Limpiar()
                    Buscar = True
                    Me.Factura = Facturas_(0)
                    ObtenerValores()
                    ObtenerDetalle()
                    ' calcular()
                End If
            Else
                buscarcanceladas(Busqueda.Ifacturacancelada)
                Me.lblEstatus.Visible = True
                Me.txtSubtotal.Enabled = False
                Me.txtIva.Enabled = True
                Me.TxtTotal.Enabled = False
            End If
            calcular()
            Me.DgvCuentas.Enabled = True
            Buscar = True
            'Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
            Me.lblEstatus.Visible = True
        End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

        Dim Tran As New HC.Transaction(IsolationLevel.ReadCommitted, "Fac")
        Dim Trans As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Poliza")
        Try
            If Validar() Then
                PasarValores()
                AgregarDetalles()

                If Factura.Guardar(Tran) Then
                    For Each Det As CN.FacturasDetalleCXPClass In FacDet
                        Tran.Add(Det)
                        Det.Guardar(Tran)
                    Next
                    Tran.Commit()
                    Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                    Try
                        For i As Integer = 0 To dgvDistribuciondeGastos.Rows.Count - 1


                            Dim cadenaConsulta As String = "INSERT INTO GastosDepartamentalesFG(IdPoliza,IdSucursal,IdMetodo,Cuenta,Ptj_Importe,Importe,Fecha,Estatus,Factura,Idprovedor,EmpresaId) VALUES({0},{1},{2},{3},{4},{5},'{6}',{7},'{8}',{9},{10})"
                            cadenaConsulta = String.Format(cadenaConsulta, 0, dgvDistribuciondeGastos.Rows(i).Cells(clmSucursal.Index).Value, dgvDistribuciondeGastos.Rows(i).Cells(clmMetodoProrrateo.Index).Value, dgvDistribuciondeGastos.Rows(i).Cells(clmCuentaContable.Index).Value, dgvDistribuciondeGastos.Rows(i).Cells(clmPorcentaje.Index).Value, CDec(dgvDistribuciondeGastos.Rows(i).Cells(clmImporte.Index).Value), DtpFechaFactura.Text, 0, Factura.NoFactura, Factura.IdProveedor, Factura.IdEmpresa)
                            Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                            Dim adp As New SqlDataAdapter(sqlcom)

                            'Dim tb As New DataTable
                            'sqlCon.Open()
                            '    adp.Fill(tb)
                            '    Me.dgvDistribuciondeGastos.AutoGenerateColumns = False
                            '    Me.dgvDistribuciondeGastos.DataSource = tb

                            sqlCon.Open()
                            sqlcom.ExecuteNonQuery()
                            sqlCon.Close()

                        Next

                    Catch ex As Exception

                    End Try
                    Dim sqlCone As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                    Try
                        For i As Integer = 0 To (dgvdistribuciongastosdet.Rows.Count - 2)
                            Dim cadenaConsulta As String = "INSERT INTO GastosDepartamentosDetFG(IdSucursal,IdMetodoProrrateo,IdCuentaContable,Factura,Cod_CentroCostos,Porcentaje) values({0},{1},{2},'{3}',{4},{5})"
                            cadenaConsulta = String.Format(cadenaConsulta, dgvdistribuciongastosdet.Rows(i).Cells(sucursal1.Index).Value, dgvdistribuciongastosdet.Rows(i).Cells(Prorrateo1.Index).Value, dgvdistribuciongastosdet.Rows(i).Cells(Cuenta1.Index).Value, Factura.NoFactura, dgvdistribuciongastosdet.Rows(i).Cells(cod_centro.Index).Value, dgvdistribuciongastosdet.Rows(i).Cells(idporcentaje.Index).Value)

                            Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCone)
                            Dim adp As New SqlDataAdapter(sqlcom)

                            'Dim tb As New DataTable
                            'sqlCon.Open()
                            '    adp.Fill(tb)
                            '    Me.dgvDistribuciondeGastos.AutoGenerateColumns = False
                            '    Me.dgvDistribuciondeGastos.DataSource = tb
                            sqlCone.Open()
                            sqlcom.ExecuteNonQuery()
                            sqlCone.Close()


                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try

                    sqlCon.Close()
                    sqlCone.Close()

                    MsgBox("La Factura se ha Guardado Satisfactoriamente...", MsgBoxStyle.Information, "Aviso")
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

            Me.Factura = New CN.FacturasCabCXPClass
            FacDet = New CN.FacturaDetalleCXPColeccion
            Limpiar()
            Habilitar()
            ' El valor de  las tasas en la factura se dan en el constructor
            'Me.txtTasaIva.Text = Factura.TasaIva.ToString("N2")
            'Me.TxtTasaISR.Text = Factura.TasaISR.ToString("N2")
            'Me.TxtTasaRetIVA.Text = Factura.TasaRetIva.ToString("N2")

            Proveedores.Obtener(Integra.Clases.EstatusEnum.ACTIVO)
            Me.CmbProveedor.ValueMember = "IDProveedor"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
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

    Private Sub Txtconcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtconcepto.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub
#End Region

#Region "Importes"

    Private Sub txtSubtotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubtotal.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtSubtotal.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            If Me.txtSubtotal.Text <> "" Then
                Me.txtIva.Focus()
            End If
        Else
            e.Handled = True
        End If
        'If e.KeyChar = Chr(13) Then
        '    Dim Subtotal As Decimal = CDec(Me.txtSubtotal.Text)
        '    Me.txtSubtotal.Text = Subtotal.ToString(formato)
        '    Me.TxtAnticipo.Focus()
        'End If
    End Sub
    'Private Sub txtSubtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubtotal.TextChanged
    '    Try
    '        If Not IsNumeric(Me.txtSubtotal.Text) Then
    '            MsgBox("Teclee una cantidad válida")
    '            Me.txtSubtotal.Text = 0.ToString(formato)
    '            Me.txtIva.Focus()
    '        Else

    '            'Calculos()

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    Private Sub txtSubtotal_Leave(sender As Object, e As EventArgs) Handles txtSubtotal.Leave
        Me.txtSubtotal.Text = CDec(If(String.IsNullOrEmpty(Me.txtSubtotal.Text), 0, Me.txtSubtotal.Text)).ToString(formato)
        Me.Calcular_New(True)
    End Sub
    Private Sub TxtAnticipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAnticipo.TextChanged
        'Try
        '    If Not IsNumeric(Me.TxtAnticipo.Text) Then
        '        MsgBox("Teclee una cantidad válida")
        '        Me.TxtAnticipo.Text = 0.ToString(formato)
        '        Me.TxtAnticipo.Focus()
        '    Else
        '        If Not IsNothing(Me.Factura) Then
        '            If Me.TxtAnticipo.Text = "" Then
        '                Me.TxtAnticipo.Text = 0.ToString(formato)
        '                Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.txtRetIva.Text) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
        '            Else
        '                'Me.TxtAnticipo.Text = CDec(Me.TxtAnticipo.Text).ToString(formato)
        '                Me.TxtTotal.Text = ((CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text)) - CDec(Me.txtRetIva.Text) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
        '            End If
        '            If CDec(Me.TxtAnticipo.Text) > CDec(Me.TxtTotal.Text) Then
        '                MsgBox("El Anticipo no puede ser Mayor al Importe Total...", MsgBoxStyle.Exclamation, "Advertencia")
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

#End Region

    Private Sub DgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellEndEdit
        Try
            ''------------------------------------------------------------
            Dim ren As Integer = 0
            Dim rendet As Integer = 0
            ''------------------------------------------------------------

            Select Case e.ColumnIndex
                Case Me.ClmCargo.Index
                    Dim Cuenta As New CN.CuentaContableClass
                    Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.clmIDCuenta.Index).Value)
                    If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then

                        Dim Ventana As New frmDistribuciondeGastos
                        frmDistribuciondeGastos.valor1 = Me.DgvCuentas.CurrentRow.Cells(Me.ClmCargo.Index).Value()
                        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then

                            Me.dgvDistribuciondeGastos.AutoGenerateColumns = False

                            If (dgvDistribuciondeGastos.Rows.Count) >= 1 Then
                                ren = dgvDistribuciondeGastos.Rows.Count
                            End If

                            For i As Integer = 0 To (Ventana.dgvMetodos.Rows.Count - 2)

                                Me.dgvDistribuciondeGastos.Rows.Add()
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmCuentaContable.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmIDCuenta.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmSucursal.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmSucursal.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmMetodoProrrateo.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmImporte.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmImporte.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmPorcentaje.Index).Value = Ventana.txtPorcentaje.Text

                                If (dgvdistribuciongastosdet.Rows.Count) >= 1 Then
                                    rendet = dgvdistribuciongastosdet.Rows.Count
                                End If

                                For j As Integer = 0 To Ventana.dgvDetalledeProrrateo.Rows.Count - 1
                                    Me.dgvdistribuciongastosdet.Rows.Add()
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.sucursal1.Index).Value = Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmSucursal.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Prorrateo1.Index).Value = Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmMetodoProrrateo.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Cuenta1.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmIDCuenta.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.cod_centro.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.Cve_Depto.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.idporcentaje.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmPorcentaje.Index).Value
                                Next
                            Next
                        End If
                    End If
                Case Me.ClmAbono.Index
                    Dim Cuenta As New CN.CuentaContableClass
                    Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.clmIDCuenta.Index).Value)
                    If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                        Dim Ventana As New frmDistribuciondeGastos
                        frmDistribuciondeGastos.valor1 = Me.DgvCuentas.CurrentRow.Cells(Me.ClmAbono.Index).Value()
                        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Me.dgvDistribuciondeGastos.AutoGenerateColumns = False

                            If (dgvDistribuciondeGastos.Rows.Count) >= 1 Then
                                ren = dgvDistribuciondeGastos.Rows.Count
                            End If

                            For i As Integer = 0 To Ventana.dgvMetodos.Rows.Count - 1
                                Me.dgvDistribuciondeGastos.Rows.Add()
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmCuentaContable.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmCuentaContablePri.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmSucursal.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmSucursal.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmMetodoProrrateo.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmImporte.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmImporte.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i + ren).Cells(Me.clmPorcentaje.Index).Value = Ventana.txtPorcentaje.Text

                                If (dgvdistribuciongastosdet.Rows.Count) >= 1 Then
                                    rendet = dgvdistribuciongastosdet.Rows.Count
                                End If

                                For j As Integer = 0 To Ventana.dgvDetalledeProrrateo.Rows.Count - 1
                                    Me.dgvdistribuciongastosdet.Rows.Add()
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.sucursal1.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmSucursal.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Prorrateo1.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.Cuenta1.Index).Value = Me.DgvCuentas.CurrentRow.Cells(Me.clmIDCuenta.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.cod_centro.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.Cve_Depto.Index).Value
                                    Me.dgvdistribuciongastosdet.Rows(j + rendet).Cells(Me.idporcentaje.Index).Value = Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmPorcentaje.Index).Value
                                Next
                            Next
                        End If
                    End If
            End Select
            If e.ColumnIndex = Me.ClmCargo.Index Or e.ColumnIndex = Me.ClmAbono.Index Then
                SumaCargo = 0
                SumaAbono = 0

                If Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "" Or Not IsNumeric(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                    Dim CargoAbono As Decimal = If(String.IsNullOrEmpty(Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value), 0, Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().Replace("$", ""))
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CargoAbono.ToString(formato)
                Else
                    Me.DgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0.ToString(formato)
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
                Me.txtSumaCargo.Text = SumaCargo.ToString(formato)
                Me.txtSumaAbono.Text = SumaAbono.ToString(formato)
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
                Me.txtSumaCargo.Text = SumaCargo.ToString(formato)
                Me.txtSumaAbono.Text = SumaAbono.ToString(formato)
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

    Private Sub TxtIVAFlete_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtIVAFlete.TextChanged
        'If Not Me.txtTasaIva.Text = 0.ToString(formatoImp) Then
        'Calculos()
        'Me.Calcular_New(True)
        'End If
    End Sub

    'Private Sub txtTasaIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTasaIva.TextChanged
    '    'If Not Me.txtTasaIva.Text = 0.ToString(formatoImp) Then
    '    'Calculos()
    '    'Me.Calcular_New(True)
    '    'End If
    'End Sub

    Private Sub TxtTasaISR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTasaISR.TextChanged
        'Calculos()
        'Me.Calcular_New(True)
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

   

    Public Function calcularFlete(Optional ByVal ignorarCuentaFlete As Boolean = False) As Boolean
        'Mee
        If ckbFletes.Checked = True Then
            If ignorarCuentaFlete = False Then
                Dim confi As New CN.ConfiguracionCtasCtrolColeccion
                If confi.Obtener(24) > 0 Then
                    Me.RellenarGridCuentas(confi(0).CuentaContable)
                Else
                    MessageBox.Show("No se ha configurado la cuenta para el IVA de Fletes." + vbNewLine + "Captúrelo desde Catálogos - Contabilidad - Cuentas de control.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ckbFletes.Checked = False
                    Return False
                End If


            End If
            TxtIVAFlete.Visible = True
            'ckbHonorarios.Checked = False
            Dim Conf As New CC.UsrConfigContabilidadCollection
            Conf.GetMulti(Nothing)
            Me.TxtIVAFlete.Text = CDec(Conf(0).Ivaflete).ToString(formatoImp)

            Dim SubtotalInt As Decimal = If(String.IsNullOrEmpty(Me.txtSubtotal.Text), 0, Me.txtSubtotal.Text)
            Dim IVAFleteInt As Decimal = If(String.IsNullOrEmpty(Me.TxtIVAFlete.Text), 0, Me.TxtIVAFlete.Text)
            Dim IVAFlete1Int As Decimal = If(String.IsNullOrEmpty(Me.TxtIVAFlete1.Text), 0, Me.TxtIVAFlete1.Text)

            IVAFlete1Int = ((SubtotalInt * IVAFleteInt) / 100).ToString(formato)
            Me.TxtIVAFlete1.Text = IVAFlete1Int.ToString(formato)

            'If IVAFlete1Int > 0 Then
            '    If TxtAnticipo.Text = "" Then
            '        Me.TxtTotal.Text = CDec(CDec(Me.TxtTotal.Text) - IVAFlete1Int).ToString(formato)
            '    Else
            '        Me.TxtTotal.Text = ((CDec(Me.TxtTotal.Text) - IVAFlete1Int) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
            '    End If
            'End If

        Else
            If ignorarCuentaFlete = False Then
                Dim confi As New CN.ConfiguracionCtasCtrolColeccion
                If confi.Obtener(24) > 0 Then
                    Dim Cta As New ClasesNegocio.CuentaContableClass()
                    Cta = confi(0).CuentaContable
                    CuentasRepetidas(Cta, True)
                Else
                    Return False
                End If
            End If

            Dim SubtotalInt As Decimal = If(String.IsNullOrEmpty(Me.txtSubtotal.Text), 0, Me.txtSubtotal.Text)
            Dim IVAFleteInt As Decimal = If(String.IsNullOrEmpty(Me.TxtIVAFlete.Text), 0, Me.TxtIVAFlete.Text)
            Dim IVAFlete1Int As Decimal = If(String.IsNullOrEmpty(Me.TxtIVAFlete1.Text), 0, Me.TxtIVAFlete1.Text)

            IVAFlete1Int = ((SubtotalInt * IVAFleteInt) / 100).ToString(formato)
            Me.TxtIVAFlete1.Text = IVAFlete1Int.ToString(formato)
            'If IVAFlete1Int > 0 Then
            '    If TxtAnticipo.Text = "" Then
            '        Me.TxtTotal.Text = CDec(CDec(Me.TxtTotal.Text) + IVAFlete1Int).ToString(formato)
            '    Else
            '        Me.TxtTotal.Text = ((CDec(Me.TxtTotal.Text) + IVAFlete1Int) - CDec(Me.TxtAnticipo.Text)).ToString(formato)
            '    End If
            '    'Me.TxtTotal.Text = (Subtotal - CDec(Me.TxtAnticipo.Text)).ToString(formato)
            'End If

            TxtIVAFlete.Visible = False
            Me.TxtIVAFlete1.Text = 0.ToString(formato)
        End If
        Return True
    End Function

    Private Sub ckbFletes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbFletes.CheckedChanged
        Me.Calcular_New()


        'If ckbFletes.Checked = True Then
        '    Label23.Visible = True
        '    TxtIVAFlete.Visible = True
        '    ckbHonorarios.Checked = False
        'Else
        '    Label23.Visible = False
        '    TxtIVAFlete.Visible = False
        '    'TxtIVAFlete.Text = 0.ToString(formato)

        'End If
    End Sub
    Private Sub DgvCuentas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellContentClick

    End Sub

    Private Sub DgvCuentas_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellContentDoubleClick
        Try
            If Buscar Then
                Dim Cuenta As New CN.CuentaContableClass
                Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.clmIDCuenta.Index).Value)
                If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                    Dim Ventana As New frmDistribuciondeGastosconsulta
                    frmDistribuciondeGastosconsulta.factura = TxtFactura.Text
                    frmDistribuciondeGastosconsulta.idcuentacontable = Me.DgvCuentas.CurrentRow.Cells(Me.clmIDCuenta.Index).Value
                    If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    End If
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub limpiargrids()
        Me.dgvDistribuciondeGastos.Rows.Clear()
        Me.dgvdistribuciongastosdet.Rows.Clear()
    End Sub


    Private Sub calcular()
        'If e.ColumnIndex = Me.ClmCargo.Index Then
        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
            SumaCargo = SumaCargo + Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value
        Next
        'End If
        'If e.ColumnIndex = Me.ClmAbono.Index Then
        For i As Integer = 0 To Me.DgvCuentas.Rows.Count - 1
            SumaAbono = SumaAbono + Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value
        Next
        Me.txtSumaCargo.Text = SumaCargo.ToString(formato)
        Me.txtSumaAbono.Text = SumaAbono.ToString(formato)
        'End If
    End Sub

    Private Sub TxtIVAFlete1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtIVAFlete1.TextChanged

    End Sub

    Private Sub TxtTasaRetIVA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTasaRetIVA.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.TxtTasaRetIVA.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            If Me.TxtTasaRetIVA.Text <> "" Then
                Me.TxtTasaISR.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTasaRetIVA_Leave(sender As System.Object, e As System.EventArgs) Handles TxtTasaRetIVA.Leave
        Dim value As Decimal = Replace(TxtTasaRetIVA.Text, ",", "")
        TxtTasaRetIVA.Text = value.ToString(formatoImp)
        Me.Calcular_New(True)
    End Sub

    Private Sub TxtTasaRetIVA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTasaRetIVA.TextChanged
        'Me.Calcular_New(True)
        'Calculos()
        'Me.Calcular_New(True)
    End Sub

    Private Sub TxtTasaISR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTasaISR.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.TxtTasaISR.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            If Me.TxtTasaISR.Text <> "" Then
                If (Me.ckbFletes.Checked) Then
                    Me.TxtIVAFlete.Focus()
                Else
                    Me.ckbFletes.Focus()
                End If

            End If
        Else
            e.Handled = True
        End If
        'Cambio Dorantes
        'If e.KeyChar = Chr(13) Then
        '    If Me.TxtTasaISR.Text <> "" Then
        '        Me.TxtTasaRetIVA.Focus()
        '    End If
        'End If

    End Sub

    Private Sub TxtTasaISR_Leave(sender As System.Object, e As System.EventArgs) Handles TxtTasaISR.Leave
        Dim value As Decimal = Replace(TxtTasaISR.Text, ",", "")
        TxtTasaISR.Text = value.ToString(formatoImp)
        Me.Calcular_New(True)
    End Sub


    Public Function calcularTotales(Optional ByVal tomarEnCuentaPorcentajeIVA As Boolean = False) As Boolean
        If (tomarEnCuentaPorcentajeIVA) Then
            Me.Subtotal = CDec(If(String.IsNullOrEmpty(Me.txtSubtotal.Text), 0, Me.txtSubtotal.Text))
            Me.IVAA = CDec(If(String.IsNullOrEmpty(Me.txtTasaIva.Text), 0, Me.txtTasaIva.Text))
            Me.txtTasaIva.Text = IVAA.ToString(formatoImp)
            Me.txtIva.Text = ((Me.Subtotal * IVAA) / 100).ToString(formato)
        Else
            Me.Subtotal = CDec(If(String.IsNullOrEmpty(Me.txtSubtotal.Text), 0, Me.txtSubtotal.Text))
            Me.IVAA = CDec(If(String.IsNullOrEmpty(Me.txtTasaIva.Text), 0, Me.txtTasaIva.Text))
            Me.txtTasaIva.Text = IVAA.ToString(formatoImp)
            Me.txtIva.Text = CDec(If(String.IsNullOrEmpty(Me.txtIva.Text), 0, Me.txtIva.Text)).ToString(formato) '((Me.Subtotal * IVAA) / 100).ToString(formato)
        End If
        'Me.txtISR.Text = 0.ToString(formato)
        'Me.txtIVAFlete1.Text = 0.ToString(formato)
        'Me.txtRetIVA.Text = 0.ToString(formato)
    End Function

    Public Function calcularSubtotal(Optional ByVal tomarEncuentaImpuestos As Boolean = False) As Decimal

        Me.Subtotal = If(String.IsNullOrEmpty(Me.txtSubtotal.Text), 0, Me.txtSubtotal.Text)
        Me.TotalAux = 0D
        Dim IVAFlete As Decimal = 0D
        Dim ISRInt As Decimal = 0D
        Dim RetIVAInt As Decimal = 0D
        Dim IVA As Decimal = 0D
        Dim Anticipo As Decimal = If(String.IsNullOrEmpty(Me.TxtAnticipo.Text), 0, Me.TxtAnticipo.Text)

        If Not IsNumeric(Me.txtSubtotal.Text) Or (CDec(If(String.IsNullOrEmpty(Me.txtSubtotal.Text), 0, Me.txtSubtotal.Text)) = 0) Then
            Me.txtSubtotal.Text = 0.ToString(formato)
            'Me.txtSubtotal.Focus()
        Else
            If Editar = False Then
                If Not Me.txtSubtotal.Text = "" Then
                    If ckbHonorarios.Checked = True Then
                        TxtTasaISR.Visible = True
                        Label23.Visible = True
                        TxtTasaRetIVA.Visible = True
                        Dim TasaISR As Decimal = If(String.IsNullOrEmpty(Me.TxtTasaISR.Text), 0, Me.TxtTasaISR.Text)
                        Dim TasaRetIVA As Decimal = If(String.IsNullOrEmpty(Me.TxtTasaRetIVA.Text), 0, Me.TxtTasaRetIVA.Text)
                        'Mee
                        If (tomarEncuentaImpuestos) Then
                            ISRInt = ((Me.Subtotal * TasaISR) / 100).ToString(formato)
                            RetIVAInt = ((Me.Subtotal * TasaRetIVA) / 100).ToString(formato)
                        Else
                            ISRInt = CDec(If(String.IsNullOrEmpty(Me.TxtISR.Text), 0, Me.TxtISR.Text))
                            RetIVAInt = CDec(If(String.IsNullOrEmpty(Me.txtRetIva.Text), 0, Me.txtRetIva.Text))
                        End If


                        Me.TxtISR.Text = ISRInt.ToString(formato)
                        Me.txtRetIva.Text = RetIVAInt.ToString(formato)

                    Else
                        txtRetIva.Text = 0.ToString(formato)
                        TxtISR.Text = 0.ToString(formato)
                    End If

                    If (ckbFletes.Checked) Then
                        IVAFlete = CDec(If(String.IsNullOrEmpty(Me.TxtIVAFlete1.Text), 0, Me.TxtIVAFlete1.Text))
                    End If
                    IVA = CDec(If(String.IsNullOrEmpty(Me.txtIva.Text), 0, Me.txtIva.Text))
                    Me.TotalAux = (Subtotal + IVA)
                    Me.Subtotal = (Subtotal + IVA) - (ISRInt + RetIVAInt + IVAFlete + Anticipo)

                    Me.TxtTotal.Text = Subtotal.ToString(formato)
                Else
                    'Subtotal = 0
                    'TotalAux = 0
                    'Me.TxtTotal.Text = Subtotal.ToString(formato)
                    'Me.txtIva.Text = (((Subtotal * Me.Fact.TasaIva) / 100)).ToString(formato)
                End If
            End If
        End If

        Return Me.TotalAux
    End Function

    Public Sub Calcular_New(Optional ByVal ignorar As Boolean = False, Optional ByVal tomarEnCuentaPorcentajeIVA As Boolean = True)
        'calcularHonorarios()
        calcularTotales(tomarEnCuentaPorcentajeIVA)
        calcularFlete(ignorar)
        calcularSubtotal(tomarEnCuentaPorcentajeIVA)
    End Sub

    Private Sub ckbHonorarios_CheckedChanged(sender As Object, e As EventArgs) Handles ckbHonorarios.CheckedChanged
        If ckbHonorarios.Checked = True Then
            TxtISR.Enabled = True
            txtRetIva.Enabled = True

            Label15.Visible = True
            TxtTasaISR.Visible = True
            Label16.Visible = True
            TxtTasaRetIVA.Visible = True
            ckbFletes.Checked = False

            Dim Conf As New CC.UsrConfigContabilidadCollection
            Conf.GetMulti(Nothing)

            Me.TxtTasaISR.Text = 0
            Me.TxtTasaRetIVA.Text = 0

            Me.TxtTasaISR.Text = CDec(Conf(0).Isr).ToString(formatoImp)
            Me.TxtTasaRetIVA.Text = CDec(Conf(0).TasaRetencion).ToString(formatoImp)
        Else
            TxtISR.Enabled = False
            txtRetIva.Enabled = False


            Label15.Visible = False
            TxtTasaISR.Visible = False
            Label16.Visible = False
            TxtTasaRetIVA.Visible = False

            TxtTasaISR.Text = 0.ToString(formato)
            TxtTasaRetIVA.Text = 0.ToString(formato)


        End If
        Me.Calcular_New(True)
    End Sub

    Private Sub txtIva_Leave(sender As Object, e As EventArgs) Handles txtIva.Leave
        Try
            If Not IsNumeric(Me.txtIva.Text) Then
                MsgBox("Teclee una cantidad válida")
                Me.txtIva.Text = 0.ToString(formato)
                Me.txtIva.Focus()
            Else
                Me.txtIva.Text = CDec(If(String.IsNullOrEmpty(Me.txtIva.Text), 0, Me.txtIva.Text)).ToString(formato)
                Me.Calcular_New(True, False)
                'Calculos2()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtIva_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtIva.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtIva.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            If Me.txtIva.Text <> "" Then
                If (ckbHonorarios.Checked) Then
                    Me.TxtISR.Focus()
                Else
                    Me.TxtAnticipo.Focus()
                End If
            End If
        Else
            e.Handled = True
        End If
        'If e.KeyChar = Chr(13) Then
        '    Dim Subtotal As Decimal = CDec(Me.txtIva.Text)
        '    Me.txtIva.Text = txtIva.ToString(formato)
        '    Me.TxtAnticipo.Focus()
        'End If
    End Sub

    Private Sub txtIva_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIva.TextChanged
        'MessageBox.Show("ola")

    End Sub

    Private Sub txtTasaIva_Leave(sender As Object, e As EventArgs) Handles txtTasaIva.Leave
        Me.Calcular_New(True)
    End Sub

    Private Sub txtTasaIva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTasaIva.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtTasaIva.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            Me.txtSubtotal.Focus()
            'Me.Calcular_New(True)
            'If Me.txtTasaIva.Text <> "" Then
            '    Me.TxtAnticipo.Focus()
            'End If
        Else
            e.Handled = True
        End If
        'If e.KeyChar = Chr(13) Then
        '    If Me.txtTasaIva.Text <> "" Then
        '        Me.TxtTasaISR.Focus()
        '    End If
        'End If
    End Sub

    Private Sub DgvCuentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvCuentas.EditingControlShowing
        Dim cajatexto As TextBox = TryCast(e.Control, TextBox)
        If (Me.DgvCuentas.CurrentCell.ColumnIndex() <> ClmDescripcion.Index) Then
            If cajatexto IsNot Nothing Then
                RemoveHandler cajatexto.KeyPress, AddressOf Me.txtSumaCargo_KeyPress
                AddHandler cajatexto.KeyPress, AddressOf Me.txtSumaCargo_KeyPress
            End If
        Else
            RemoveHandler cajatexto.KeyPress, AddressOf Me.txtSumaCargo_KeyPress
        End If
    End Sub


    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSumaCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSumaCargo.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub DgvCuentas_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCuentas.CellValueChanged

    End Sub

    Private Sub TxtISR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtISR.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.TxtISR.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            If Me.TxtISR.Text <> "" Then
                Me.txtRetIva.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRetIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetIva.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtRetIva.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            If Me.txtRetIva.Text <> "" Then
                Me.TxtAnticipo.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtISR_Leave(sender As Object, e As EventArgs) Handles TxtISR.Leave
        Me.TxtISR.Text = CDec(If(String.IsNullOrEmpty(Me.TxtISR.Text), 0, Me.TxtISR.Text)).ToString(formato)
        Me.Calcular_New(True, False)
    End Sub

    Private Sub txtRetIva_Leave(sender As Object, e As EventArgs) Handles txtRetIva.Leave
        Me.txtRetIva.Text = CDec(If(String.IsNullOrEmpty(Me.txtRetIva.Text), 0, Me.txtRetIva.Text)).ToString(formato)
        Me.Calcular_New(True, False)
    End Sub

    Private Sub TxtAnticipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAnticipo.KeyPress
        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.TxtAnticipo.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(13) Then
            If Me.TxtAnticipo.Text <> "" Then
                Me.UUID.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAnticipo_Leave(sender As Object, e As EventArgs) Handles TxtAnticipo.Leave
        Me.TxtAnticipo.Text = CDec(If(String.IsNullOrEmpty(Me.TxtAnticipo.Text), 0, Me.TxtAnticipo.Text)).ToString(formato)
    End Sub

    Private Sub buscarcanceladas(id As Integer)
        Try
            Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
            Dim cadenaConsulta As String = "EXEC Usp_HistorialUsrFacturas 1, {0}"
            cadenaConsulta = String.Format(cadenaConsulta, id)

            Using sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                sqlCon.Open()
                Dim adp As New SqlDataAdapter(sqlcom)
                Dim Rs As SqlDataReader = sqlcom.ExecuteReader()

                Dim cuentascontables As New DataSet()
                cuentascontables.Tables.Add("cuentascontables")
                cuentascontables.Tables(0).Load(Rs)

                Me.CmbProveedor.SelectedValue = CInt(cuentascontables.Tables(0).Rows(0).ItemArray(2).ToString())
                Me.TxtFactura.Text = cuentascontables.Tables(0).Rows(0).ItemArray(3).ToString()
                Me.DtpFechaFactura.Value = cuentascontables.Tables(0).Rows(0).ItemArray(4).ToString()
                Me.DtpFechaCaptura.Value = cuentascontables.Tables(0).Rows(0).ItemArray(5).ToString()
                Me.DtpFechaVencimiento.Value = cuentascontables.Tables(0).Rows(0).ItemArray(6).ToString()
                Me.txtSubtotal.Text = cuentascontables.Tables(0).Rows(0).ItemArray(7).ToString()
                Me.txtIva.Text = cuentascontables.Tables(0).Rows(0).ItemArray(8).ToString()
                Me.TxtTotal.Text = cuentascontables.Tables(0).Rows(0).ItemArray(9).ToString()
                Me.TxtAnticipo.Text = cuentascontables.Tables(0).Rows(0).ItemArray(10).ToString()
                Select Case (cuentascontables.Tables(0).Rows(0).ItemArray(11).ToString())
                    Case 0
                        Me.lblEstatus.Text = "CANCELADA"
                    Case 1
                        Me.lblEstatus.Text = "PAGADA"
                    Case 2
                        Me.lblEstatus.Text = "VIGENTE"
                    Case 3
                        Me.lblEstatus.Text = "ABONADA"
                End Select
                lblEstatus.Visible = True
                Me.txtObservaciones.Text = cuentascontables.Tables(0).Rows(0).ItemArray(15).ToString()
                Me.UUID.Text = cuentascontables.Tables(0).Rows(0).ItemArray(29).ToString()
                llenarcuentascontablesfac(cuentascontables)
                sqlCon.Close()

            End Using
        Catch ex As Exception

        End Try
      

    End Sub


    Private Sub llenarcuentascontablesfac(cuentascontables As DataSet)


        For Each row As DataRow In cuentascontables.Tables(0).Rows
            Dim i As Integer = Me.DgvCuentas.Rows.Count
            Me.DgvCuentas.Rows.Add()
            If row("CarAbo").ToString().Equals("C") Then
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = row("cta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = row("subcta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = row("SSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = row("SSSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = row("NomCuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = row("importecuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
            Else
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = row("cta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = row("subcta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = row("SSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = row("SSSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = row("NomCuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = row("importecuenta").ToString()
            End If
        Next

    End Sub

End Class