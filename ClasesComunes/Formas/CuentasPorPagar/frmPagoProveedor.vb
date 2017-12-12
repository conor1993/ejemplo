Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports ClasesNegocio
Imports Microsoft.Win32

Public Class frmPagoProveedor
    Dim lnCantidad As Decimal = 0D


    Dim Proveedores As New CN.ProveedorCollectionClass()
    Dim IdProveedor As Integer
    Dim ImporteT As String = ""
    Dim NombreProveedor As String = ""
    Dim SubTot As String = ""
    Dim IVAP As String = ""
    Dim IepsP As String = ""
    Dim FolioRecep As String = ""
    Dim IdRecepOC As Long
    Dim RecepcionOrdenCompra As New CN.RecepcionOrdenCompraClass()
    Dim Retiro As New CN.RetiroDeCajaClass
    Dim Turno As New CN.ControlTurnoClass()



    Public Sub New(ByVal Proveedor As Integer, ByVal NomProveedor As String, ByVal Total As String, ByVal SubTotal As String, ByVal Iva As String, ByVal Ieps As String, ByVal FolRecep As String, ByVal idRecep As Long)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        IdProveedor = Proveedor
        ImporteT = Total
        NombreProveedor = NomProveedor
        SubTot = SubTotal
        IVAP = Iva
        IepsP = Ieps
        FolioRecep = FolRecep
        IdRecepOC = idRecep
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Me.llenarComboConceptos(Tipo)

        'rbFactura.Focus()
    End Sub





    Public Function Validar() As Boolean
        Dim Mensaje As String = ""
        Dim validado As Boolean = True
        Dim focus As Boolean = False


        If rbFactura.Checked = True Then
            If txtFactura.Text.Trim() = "" Then
                Mensaje = Mensaje & "   *Proporcione el número de la factura." & vbCrLf
                validado = False
                If focus = False Then
                    txtFactura.Focus()
                    focus = True
                End If
            End If
        ElseIf rbNotaRem.Checked = True Then
            If txtNumRemision.Text.Trim() = "" Then
                Mensaje = Mensaje & "   *Proporcione el número de la remisión." & vbCrLf
                validado = False
                If focus = False Then
                    txtNumRemision.Focus()
                    focus = True
                End If
            End If
        End If

        If txtFolRecep.Text = "" Then
            Mensaje = Mensaje & "   *Confirmar el numero de la recepción." & vbCrLf
            validado = False
            If focus = False Then
                txtFolRecep.Focus()
                focus = True
            End If
        End If
        If (Me.lblFolRecep.Text <> txtFolRecep.Text) Then
            Mensaje = Mensaje & "   *Confirmación incorrecta, reintente." & vbCrLf
            validado = False
            txtFolRecep.Text = ""
            If focus = False Then
                txtFolRecep.Focus()
                focus = True
            End If
        End If

        If Mensaje = "" Then
            validado = True
        Else
            Mensaje = "Antes de continuar es necesario corregir lo siguiente: " & vbCrLf & vbCrLf & Mensaje
            MsgBox(Mensaje, MsgBoxStyle.Exclamation, "AVISO")
        End If
        Return validado
    End Function





    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmPagoProveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.BtnAceptar.Enabled = False
        ' Me.BtnPagar.Enabled = False
        'lblCajero.Text = Controlador.Sesion.MiUsuario.Usrnom
        lblFecha.Text = Date.Now().ToString("dd-MM-yyyy hh:mm tt")
        rbFactura.Checked = True


        rbFactura.Focus()
        lblImporte.Text = ImporteT
        lblProveedor.Text = NombreProveedor
        txtFactura.CharacterCasing = CharacterCasing.Upper ''Mayusculas
        Dim temp As String = FolioRecep
        'Me.lblFolRecep.Text = temp.Replace("0", "")
        temp = temp.Replace("R", "")
        Me.lblFolRecep.Text = "R" & CInt(temp).ToString



    End Sub


    Private Sub BtnPagar_Click(sender As System.Object, e As System.EventArgs)

    End Sub



    Private Sub txtFactura_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFactura.KeyUp
        If Me.txtFactura.Text.Length <= 0 Then
            'Me.BtnPagar.Enabled = False
        Else
            'Me.BtnPagar.Enabled = True
        End If

    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub rbFactura_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFactura.CheckedChanged
        Me.txtFactura.Enabled = True
        Me.lblFec.Text = "Fecha Factura: "
        Me.MtxtUUID.Enabled = True
        'Me.DtpFechaFac.Enabled = True
        Me.DtpFechaFac.Enabled = True
        Me.txtNumRemision.Enabled = False
        Me.txtNumRemision.Text = ""
    End Sub

    Private Sub rbNotaRem_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNotaRem.CheckedChanged
        Me.txtFactura.Enabled = False
        Me.lblFec.Text = "Fecha Remisión:"
        Me.txtFactura.Text = ""
        Me.MtxtUUID.Enabled = False
        Me.MtxtUUID.Text = ""
        Me.DtpFechaFac.Enabled = True
        'Me.DtpFechaFac.Enabled = False
        Me.txtNumRemision.Enabled = True
    End Sub


    Private Sub btnPagar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnPagar.Click
        Dim Proveedor As New CN.ProveedorClass()
        Proveedor.Obtener(IdProveedor)
        '' Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
        If Validar() Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
            If rbFactura.Checked Then
                Dim Factura As New CN.FacturasCabCXPClass
                Try
                    Factura.IdEmpresa = Controlador.Sesion.Empndx
                    Factura.Proveedor = Proveedor
                    Factura.NoFactura = txtFactura.Text
                    Factura.FechaCaptura = Now
                    Factura.Subtotal = Convert.ToDecimal(Replace(SubTot, "$", ""))
                    Factura.Total = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                    Factura.Estatus = CN.EstatusFacturasEnum.PAGADA
                    Factura.IdUsuarioAlta = Controlador.Sesion.Usrndx
                    Factura.IdPoliza = 0
                    Factura.FechaFactura = DtpFechaFac.Value
                    Factura.FechaVencimiento = DtpFechaFac.Value
                    Factura.Gastos = True
                    Factura.Servicios = False
                    Factura.Saldo = 0.0
                    Factura.TasaIva = Controlador.ObtenerIVA()
                    Factura.Iva = Convert.ToDecimal(Replace(IVAP, "$", ""))
                    Factura.TasaISR = 0.0
                    Factura.Ieps = Convert.ToDecimal(Replace(IepsP, "$", ""))
                    Factura.TasaRetIva = 0.0
                    Factura.Contabilizada = "N"
                    Factura.FechaContabilizacion = New DateTime(1900, 1, 1)
                    Factura.Anticipo = 0.0

                    If Factura.Guardar(Trans) Then
                        RecepcionOrdenCompra = New CN.RecepcionOrdenCompraClass()
                        RecepcionOrdenCompra.Obtener(Convert.ToInt32(IdRecepOC))
                        RecepcionOrdenCompra.NumFactura = txtFactura.Text
                        RecepcionOrdenCompra.Facturada = True
                        RecepcionOrdenCompra.Pagada = True
                        If RecepcionOrdenCompra.Guardar(Trans) Then
                            ''SE REGISTRA EL RETIRO POR CONCEPTO DE PAGO PROVEEDOR
                            Dim Concepto As New ConceptoCajaClass
                            Dim ConfigPuntoVta As New CC.ConfigPuntoVtaCollection()
                            ConfigPuntoVta.GetMulti(Nothing)

                            Turno = Utilerias.ObtenerControlTurnoActual()

                            Retiro.CodUsuario = Controlador.Sesion.Usrndx
                            Retiro.FechaHora = DateTime.Now
                            Retiro.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                            Retiro.CodControlTurno = Turno.Id
                            Retiro.IdConcepto = CN.UtileriasCN.ObtenerCodConceptoRetiro
                            Retiro.Observaciones = NombreProveedor & " No.Fact: " & txtFactura.Text
                            Concepto.Obtener(Retiro.IdConcepto)
                            If Retiro.Guardar(Trans) Then
                                Dim Pago As New CN.PagosProveedoresClass
                                Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                                Pago.Proveedor = Proveedor
                                Pago.FechaPago = Now
                                ''CHEQUE Y POLIZA EN VACIO POR PAGO EN EFECTIVO
                                Pago.Cheque = ""
                                Pago.IdPoliza = 0
                                Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE
                                Pago.NoFactura = txtFactura.Text
                                Pago.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                                Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                                Pago.IdConcepto = Retiro.IdConcepto
                                Pago.Referencia = FolioRecep
                                If Pago.Guardar(Trans) Then
                                    Trans.Commit()
                                    Dim rep As New crRetiroTck
                                    rep.SetParameterValue("IdRetiro", Retiro.Id)
                                    rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
                                    rep.SetParameterValue("IdControlTurno", Retiro.Id)
                                    rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
                                    rep.SetParameterValue("FechaHora", Retiro.FechaHora)
                                    rep.SetParameterValue("Importe", Retiro.Importe)
                                    rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
                                    rep.SetParameterValue("Concepto", UCase(Concepto.Concepto))
                                    rep.SetParameterValue("Copia", "")
                                    rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
                                    rep.PrintToPrinter(1, False, 0, 0)
#If DEBUG Then
                                    '.....prueba del ticket visualmente
                                    Dim Prev As New ClasesNegocio.PreVisualizarForm
                                    Prev.Reporte = rep
                                    Prev.Text = "TICKET"
                                    Prev.ShowDialog()
#End If
                                    rep.Dispose()
                                    MsgBox("Pago se realizo correctamente del proveedor " & Proveedor.RazonSocial & " la factura no. " & txtFactura.Text.Trim & ".", MsgBoxStyle.Information, "AVISO")
                                    Me.Close()

                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                    Trans.Rollback()
                End Try
            ElseIf rbNotaRem.Checked Then
                ''SE REGISTRA EL RETIRO POR CONCEPTO DE PAGO PROVEEDOR
                Dim Concepto As New ConceptoCajaClass

                Dim ConfigPuntoVta As New CC.ConfigPuntoVtaCollection()
                Try
                    ConfigPuntoVta.GetMulti(Nothing)

                    Turno = Utilerias.ObtenerControlTurnoActual()

                    Retiro.CodUsuario = Controlador.Sesion.Usrndx
                    Retiro.FechaHora = DateTime.Now
                    Retiro.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                    Retiro.CodControlTurno = Turno.Id
                    Retiro.IdConcepto = CN.UtileriasCN.ObtenerCodConceptoRetiro
                    Retiro.Observaciones = NombreProveedor & " No.Remisión: " & txtNumRemision.Text.Trim()
                    Concepto.Obtener(Retiro.IdConcepto)
                    If Retiro.Guardar(Trans) Then
                        Dim Pago As New CN.PagosProveedoresClass
                        Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                        Pago.Proveedor = Proveedor
                        Pago.FechaPago = Now
                        ''CHEQUE Y POLIZA EN VACIO POR PAGO EN EFECTIVO
                        Pago.Cheque = ""
                        Pago.IdPoliza = 0
                        Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE

                        Pago.NoRemision = txtNumRemision.Text.Trim()
                        ''se coloca el numero de remision en pago hasta que se reciba la factura de la remision se cambiara campo
                        Pago.NoFactura = txtNumRemision.Text.Trim()
                        Pago.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                        Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                        Pago.IdConcepto = Retiro.IdConcepto
                        Pago.Referencia = FolioRecep
                        If Pago.Guardar(Trans) Then
                            RecepcionOrdenCompra = New CN.RecepcionOrdenCompraClass()
                            RecepcionOrdenCompra.Obtener(Convert.ToInt32(IdRecepOC))
                            RecepcionOrdenCompra.NumFactura = txtNumRemision.Text
                            RecepcionOrdenCompra.Facturada = False
                            RecepcionOrdenCompra.NoRemision = txtNumRemision.Text.Trim()
                            RecepcionOrdenCompra.Pagada = True
                            If RecepcionOrdenCompra.Guardar(Trans) Then
                                Trans.Commit()
                                Dim rep As New crRetiroTck
                                rep.SetParameterValue("IdRetiro", Retiro.Id)
                                rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
                                rep.SetParameterValue("IdControlTurno", Retiro.Id)
                                rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
                                rep.SetParameterValue("FechaHora", Retiro.FechaHora)
                                rep.SetParameterValue("Importe", Retiro.Importe)
                                rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
                                rep.SetParameterValue("Concepto", UCase(Concepto.Concepto))
                                rep.SetParameterValue("Copia", "")
                                rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
                                rep.PrintToPrinter(1, False, 0, 0)
#If DEBUG Then
                                '.....prueba del ticket visualmente
                                Dim Prev As New ClasesNegocio.PreVisualizarForm
                                Prev.Reporte = rep
                                Prev.Text = "TICKET"
                                Prev.ShowDialog()
#End If
                                rep.Dispose()
                                MsgBox("Pago se realizo correctamente del proveedor " & Proveedor.RazonSocial & " la nota de remisión: " & txtNumRemision.Text.Trim & ".", MsgBoxStyle.Information, "AVISO")
                                Me.Close()
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    Trans.Rollback()

                End Try
            ElseIf rbSinDocto.Checked Then
                Dim Concepto As New ConceptoCajaClass
                Try
                    Dim ConfigPuntoVta As New CC.ConfigPuntoVtaCollection()
                    ConfigPuntoVta.GetMulti(Nothing)

                    Turno = Utilerias.ObtenerControlTurnoActual()

                    Retiro.CodUsuario = Controlador.Sesion.Usrndx
                    Retiro.FechaHora = DateTime.Now
                    Retiro.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                    Retiro.CodControlTurno = Turno.Id
                    Retiro.IdConcepto = CN.UtileriasCN.ObtenerCodConceptoRetiro
                    Retiro.Observaciones = NombreProveedor & " S/Docto-Folio: " & FolioRecep
                    Concepto.Obtener(Retiro.IdConcepto)
                    If Retiro.Guardar(Trans) Then
                        Dim Pago As New CN.PagosProveedoresClass
                        Pago.ObtenerEntidad.EmpresaId = Controlador.Sesion.Empndx
                        Pago.Proveedor = Proveedor
                        Pago.FechaPago = Now
                        ''CHEQUE Y POLIZA EN VACIO POR PAGO EN EFECTIVO
                        Pago.Cheque = ""
                        Pago.IdPoliza = 0
                        Pago.Estatus = ClasesNegocio.EstatusPagosProveedoresEnum.VIGENTE

                        'Pago.NoRemision = txtFolRecep.Text.Trim()
                        ''se coloca el numero de remision en pago hasta que se reciba la factura de la remision se cambiara campo
                        Pago.NoFactura = txtFolRecep.Text.Trim
                        Pago.Importe = Convert.ToDecimal(Replace(lblImporte.Text, "$", ""))
                        Pago.IdUsuarioAlta = Controlador.Sesion.Usrndx
                        Pago.IdConcepto = Retiro.IdConcepto
                        Pago.Referencia = FolioRecep
                        If Pago.Guardar(Trans) Then
                            RecepcionOrdenCompra = New CN.RecepcionOrdenCompraClass()
                            RecepcionOrdenCompra.Obtener(Convert.ToInt32(IdRecepOC))
                            RecepcionOrdenCompra.NumFactura = txtFolRecep.Text.Trim()
                            RecepcionOrdenCompra.Facturada = False
                            'RecepcionOrdenCompra.NoRemision = txtFolRecep.Text.Trim()
                            RecepcionOrdenCompra.Pagada = True

                            If RecepcionOrdenCompra.Guardar(Trans) Then

                                Dim rep As New crRetiroTck
                                rep.SetParameterValue("IdRetiro", Retiro.Id)
                                rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
                                rep.SetParameterValue("IdControlTurno", Turno.Id)
                                rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
                                rep.SetParameterValue("FechaHora", Retiro.FechaHora)
                                rep.SetParameterValue("Importe", Retiro.Importe)
                                rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
                                rep.SetParameterValue("Concepto", UCase(Concepto.Concepto))
                                rep.SetParameterValue("Copia", "")
                                rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
                                rep.PrintToPrinter(1, True, 0, 0)
#If DEBUG Then
                                '.....prueba del ticket visualmente
                                Dim Prev As New ClasesNegocio.PreVisualizarForm
                                Prev.Reporte = rep
                                Prev.Text = "TICKET"
                                Prev.ShowDialog()
#End If
                                rep.Dispose()
                                Trans.Commit()
                                MsgBox("Pago se realizo correctamente del proveedor " & Proveedor.RazonSocial & " con el numero de folio: " & FolioRecep & ".", MsgBoxStyle.Information, "AVISO")
                                Me.Close()
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    Trans.Rollback()

                End Try
            End If
        Else
            Return
        End If
    End Sub

    Private Sub frmPagoProveedor_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            Case Keys.Escape
                Select Case MsgBox("¿Deseas salir sin pagar la compra?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Aviso")
                    Case MsgBoxResult.Yes
                        Me.Button1_Click(sender, e)
                End Select
        End Select
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub rbSinDocto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbSinDocto.CheckedChanged
        Me.txtFactura.Enabled = False
        Me.lblFec.Text = "Fecha Factura: "
        Me.txtFactura.Text = ""
        Me.MtxtUUID.Enabled = False
        Me.MtxtUUID.Text = ""
        Me.txtNumRemision.Text = ""
        Me.txtNumRemision.Enabled = False
        Me.DtpFechaFac.Enabled = False
        'Me.txtNumRemision.Enabled = True
    End Sub
End Class