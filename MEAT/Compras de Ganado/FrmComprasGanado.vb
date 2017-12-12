Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmComprasGanado

#Region "Miembros"

    Dim chofer As ClasesNegocio.ChoferesCollectionClass
    Dim camiones As ClasesNegocio.VehiculosCollectionClass
    Private WithEvents CompraGanado As ClasesNegocio.CompraGanadoClass
    Dim validarSalidaFila As Boolean = True
    Dim buscando As Boolean = False

#End Region

#Region "Metodos"
#Region "Manipulacion Controles"
    Private Function LlenaComboBox() As Boolean
        Try
            Dim lugares As New LugaresDeCompraCollectionClass
            Me.chofer = New ClasesNegocio.ChoferesCollectionClass
            Me.camiones = New ClasesNegocio.VehiculosCollectionClass
            Dim proveedores As New CC.ProveedorCollection

            proveedores.GetMulti(HC.ProveedorFields.EsdeGanado = 1 And HC.ProveedorFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            'llena combo proveedores
            Me.cmbProveedor.DataSource = proveedores
            Me.cmbProveedor.DisplayMember = "RazSocial"
            Me.cmbProveedor.ValueMember = "Codigo"
            Me.cmbProveedor.SelectedIndex = -1

            'llena combo corrales
            Me.cmbCorral.DataSource = CC.McecatCorralesCabCollection.GetMultiAsDataTable(HC.McecatCorralesCabFields.TipoCorral = _
                                      ClasesNegocio.TipoCorral.RECIBA, 0, New OC.SortExpression(New OC.SortClause(HC.McecatCorralesCabFields.NombreCorral, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbCorral.DisplayMember = "NombreCorral"
            Me.cmbCorral.ValueMember = "IdCorral"
            Me.cmbCorral.SelectedIndex = -1
            'llena como Tipo de ganado

            TipoGanadoC.Obtener(ClasesNegocio.EstatusDatos.VIGENTE)
            chofer.Obtener()
            camiones.Obtener(Nothing, New OC.SortExpression(New OC.SortClause(HC.McgcatVehiculosFields.DescVehiculo, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            lugares.Obtener(CondicionEnum.ACTIVOS)
            Me.CompradoresGanadoC.Obtener(CondicionEnum.ACTIVOS)
            Me.ConceptoGastoC.Obtener(CondicionEnum.ACTIVOS)

            Me.cmbChofer.DisplayMember = "NombreCompleto"
            Me.cmbChofer.ValueMember = "IdChofer"
            Me.cmbChofer.DataSource = chofer
            Me.cmbChofer.SelectedValue = -1

            Me.CmbCamion.DisplayMember = "Descripcion"
            Me.CmbCamion.ValueMember = "Codigo"
            Me.CmbCamion.DataSource = camiones
            Me.CmbCamion.SelectedValue = -1

            Me.CmbLugarCompra.DisplayMember = "Descripcion"
            Me.CmbLugarCompra.ValueMember = "IdLugarCompra"
            Me.CmbLugarCompra.DataSource = lugares
            Me.CmbLugarCompra.SelectedIndex = -1

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso")
            Return False
        End Try
    End Function

    Private Function Limpiar() As Boolean
        Me.chkImpuestoEducacion.Checked = False
        Me.chkImpuestoPredial.Checked = False
        Me.txtCantCabezas.Text = 0
        Me.txtNoGuia.Text = 0
        Me.txtImporteGuia.Text = 0D.ToString("C2")
        Me.txtFolioCompra.Text = ""
        Me.txtKilosComprados.Text = 0D
        Me.txtKilosRecibidos.Text = 0D
        Me.txtKilosMerma.Text = 0D
        Me.txtObservaciones.Text = ""
        Me.txtPorcentajeMerma.Text = 0
        Me.cmbCorral.Text = ""
        Me.cmbComprador.Text = ""
        Me.cmbProveedor.Text = ""
        'Me.dgvTiposdeGanado.DataSource = Nothing
        Me.dgvTiposdeGanado.Rows.Clear()
        Me.DgvConceptoGastos.Rows.Clear()
        Me.dtpFecha.Value = Now
        Me.lblEstatus.Visible = False
        Me.cmbComprador.SelectedValue = -1
        Me.cmbProveedor.SelectedValue = -1
        Me.cmbCorral.SelectedValue = -1
        Me.txtComision.Text = 0D.ToString("C2")
        'Me.txtKilo.Text = ""
        Me.txtAdquisicion.Text = 0D.ToString("C2")
        Me.txtImporteEducacion.Text = 0D.ToString("C2")
        Me.txtImportePredial.Text = 0D.ToString("C2")
        Me.txtImporteTotal.Text = 0D.ToString("C2")
        Me.txtGastosTransporte.Text = 0D.ToString("C2")
        Me.txtGuiaTransito.Text = 0D.ToString("C2")
        Me.txtNoFactura.Text = ""
        Me.txtBanco.Text = ""
        Me.txtSucursal.Text = ""
        Me.txtNoCuenta.Text = ""
        'Me.TxtCamion.Text = ""
        Me.cmbChofer.SelectedValue = -1
        Me.CmbCamion.SelectedValue = -1
        Me.CmbLugarCompra.SelectedValue = -1
        Me.txtDiasDeCredito.Text = ""
        TxtFolio.ResetText()
    End Function

    Private Function Deshabilitar() As Boolean
        Me.chkImpuestoEducacion.Enabled = False
        Me.chkImpuestoPredial.Enabled = False
        Me.rbtCabeza.Enabled = False
        Me.rbtKilo.Enabled = False
        Me.txtCantCabezas.Enabled = False
        Me.txtFolioCompra.Enabled = False
        'Me.txtImporte.Enabled = False
        Me.txtImporteGuia.Enabled = False
        Me.txtKilosComprados.Enabled = False
        Me.txtKilosRecibidos.Enabled = False
        Me.txtKilosMerma.Enabled = False
        Me.txtNoGuia.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtPorcentajeMerma.Enabled = False
        Me.cmbCorral.Enabled = False
        Me.cmbComprador.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.dtpFecha.Enabled = False

        Me.dgvTiposdeGanado.ReadOnly = True
        Me.DgvConceptoGastos.ReadOnly = True

        Me.txtComision.Enabled = False
        'Me.txtKilo.Enabled = False
        Me.txtAdquisicion.Enabled = False
        Me.txtImportePredial.Enabled = False
        Me.txtImporteTotal.Enabled = False
        Me.txtGastosTransporte.Enabled = False
        Me.txtGuiaTransito.Enabled = False
        Me.txtImporteEducacion.Enabled = False

        Me.dtpFechaPago.Enabled = False
        Me.txtNoFactura.Enabled = False
        Me.txtBanco.Enabled = False
        Me.txtSucursal.Enabled = False
        Me.txtNoCuenta.Enabled = False
        Me.txtNoGuia.Enabled = False
        'Me.txtImporte.Enabled = False
        Me.txtKilosMerma.Enabled = False
        Me.txtPorcentajeMerma.Enabled = False
        Me.CmbLugarCompra.Enabled = False
        Me.cmbChofer.Enabled = False
        Me.CmbCamion.Enabled = False
        'Me.TxtCamion.Enabled = False
    End Function

    Private Function Habilitar() As Boolean
        Me.chkImpuestoEducacion.Enabled = True
        Me.chkImpuestoPredial.Enabled = True
        Me.txtImporteGuia.Enabled = True
        Me.txtKilosComprados.Enabled = False
        Me.txtNoGuia.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtKilosRecibidos.Enabled = True
        Me.cmbCorral.Enabled = True
        Me.cmbComprador.Enabled = True
        Me.cmbProveedor.Enabled = True
        Me.dtpFecha.Enabled = True
        Me.dgvTiposdeGanado.ReadOnly = False
        Me.CantKilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantCabezasDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioXKiloDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.DgvConceptoGastos.ReadOnly = False
        Me.txtComision.Enabled = True
        'Me.txtKilo.Enabled = True
        Me.txtAdquisicion.Enabled = True
        Me.txtImportePredial.Enabled = True
        Me.txtImporteTotal.Enabled = True
        Me.txtGastosTransporte.Enabled = True
        Me.txtGuiaTransito.Enabled = True
        Me.txtImporteEducacion.Enabled = True

        Me.dtpFechaPago.Enabled = True
        Me.txtNoFactura.Enabled = True
        Me.txtBanco.Enabled = True
        Me.txtSucursal.Enabled = True
        Me.txtNoCuenta.Enabled = True
        Me.txtNoGuia.Enabled = True
        Me.txtKilosMerma.Enabled = True
        Me.txtPorcentajeMerma.Enabled = True
        Me.CmbLugarCompra.Enabled = True
        Me.cmbChofer.Enabled = True
        Me.CmbCamion.Enabled = True
    End Function

    Private Function ObtenerDatosCabecero() As Boolean
        With Me.CompraGanado
            .FechaRecepcion = Me.dtpFecha.Value
            .IdProveedor = CInt(Me.cmbProveedor.SelectedValue)
            .IdLugarCompra = CInt(Me.CmbLugarCompra.SelectedValue)
            .IdComprador = CInt(Me.cmbComprador.SelectedValue)

            If IsNumeric(txtNoGuia.Text) Then
                .NumGuias = CShort(Me.txtNoGuia.Text)
            Else
                .NumGuias = 0S
            End If

            If IsNumeric(Me.txtImporteGuia.Text) Then
                .ImporteXGuia = CDec(Me.txtImporteGuia.Text)
            Else
                .ImporteXGuia = 0D
            End If

            .HorasViaje = CDec(Me.txtHorasViaje.Text)
            .ImportePredial = CDec(IIf(Me.chkImpuestoPredial.Checked, CDec(Me.txtImportePredial.Text), 0D))
            .PagarImportePredial = Me.chkImpuestoPredial.Checked
            .PagarImporteEducacion = Me.chkImpuestoEducacion.Checked
            .ImporteEducacion = CDec(IIf(Me.chkImpuestoEducacion.Checked, CDec(Me.txtImporteEducacion.Text), 0D))
            .KilosRecibidos = CDec(Me.txtKilosRecibidos.Text.Replace("kgs", ""))
            .Cabezas = CInt(Me.txtCantCabezas.Text)
            .KilosComprados = CDec(Me.txtKilosComprados.Text.Replace("kgs", ""))
            .ImporteCompra = CDec(Me.txtAdquisicion.Text)
            .Observaciones = Me.txtObservaciones.Text.Trim
            .Cerrado = False
            .IdCorral = Me.cmbCorral.SelectedValue

            If IsNumeric(Me.txtDiasDeCredito.Text) Then
                .DiasCredito = CByte(Me.txtDiasDeCredito.Text)
            Else
                .DiasCredito = 0D
            End If

            .FechaPago = Me.dtpFechaPago.Value
            .NumFactura = Me.txtNoFactura.Text.Trim
            .NomBanco = Me.txtBanco.Text.Trim
            .NomSucursal = Me.txtSucursal.Text.Trim
            .NumCuenta = Me.txtNoCuenta.Text.Trim

            If Me.DgvConceptoGastos.Rows.Count > 1 Then
                .GastosTransporte.IVA = CDec(Me.txtIVA.Text.Replace("$", ""))
                .GastosTransporte.ImporteTotal = CDec(Me.txtTotal.Text.Replace("$", ""))
                .GastosTransporte.FechaRecepcion = Me.dtpFecha.Value
                .GastosTransporte.IdChofer = CInt(Me.cmbChofer.SelectedValue)
                .GastosTransporte.IdVehiculo = CInt(Me.CmbCamion.SelectedValue)

                If .GastosTransporte.Detalle.Count = DgvConceptoGastos.RowCount Then
                    For Each Fila As DataGridViewRow In DgvConceptoGastos.Rows
                        If Fila.IsNewRow Then
                            .GastosTransporte.Detalle.RemoveAt(Fila.Index)
                        End If
                    Next
                End If
            End If

            If .Detalle.Count > 0 Then
                If Not .Detalle(.Detalle.Count - 1).Entidad.IsDirty Then
                    .Detalle.RemoveAt(.Detalle.Count - 1)
                End If
            End If

            .Comision = CDec(Me.txtComision.Text)
            .Estatus = EstatusChar.VIGENTE
            .CostoIndirecto = CDec(Me.txtGastosTransporte.Text.Replace("$", ""))
            .FolioFactura = Me.txtNoFactura.Text.Trim

            If Me.rbtCabeza.Checked Then
                .TipoComision = CompraGanadoClass.TiposComision.CABEZAS
            ElseIf Me.rbtKilo.Checked Then
                .TipoComision = CompraGanadoClass.TiposComision.KILOS
            Else
                .TipoComision = CompraGanadoClass.TiposComision.SIN_COMISION
            End If

            .FolioRecepcionPesada = ""

            Return True
        End With
    End Function

    Public Const NombreAplicacion As String = "Aplicacion"

    Private Sub PonerDatos()
        With Me.CompraGanado
            Me.dtpFecha.Value = .FechaRecepcion
            Me.cmbProveedor.SelectedValue = .IdProveedor
            Me.CmbLugarCompra.SelectedValue = .IdLugarCompra
            Me.cmbComprador.SelectedValue = .IdComprador
            Me.cmbCorral.SelectedValue = .IdCorral
            Me.TxtFolio.Text = .Folio
            Me.txtFolioCompra.Text = .Folio
            Me.txtKilosMerma.Text = .KilosMerma.ToString("N3")
            Me.txtPorcentajeMerma.Text = (.PorcentajeMerma / 100D).ToString("P2")
            Me.txtComision.Text = .Comision.ToString("C2")
            Me.txtNoGuia.Text = .NumGuias.ToString("N0")
            Me.txtGuiaTransito.Text = .ImporteXGuia.ToString("C2")
            Me.txtImporteGuia.Text = .ImporteXGuia.ToString("C2")
            Me.txtHorasViaje.Text = .HorasViaje
            Me.txtImportePredial.Text = .ImportePredial.ToString("C2")
            Me.txtGastosTransporte.Text = .GastosTransporte.ImporteTotal.ToString("C2")
            Me.chkImpuestoPredial.Checked = .PagarImportePredial
            Me.chkImpuestoEducacion.Checked = .PagarImporteEducacion
            Me.txtImporteEducacion.Text = .ImporteEducacion.ToString("C2")
            Me.txtKilosRecibidos.Text = .KilosRecibidos.ToString("#,###.000 kgs")
            Me.txtCantCabezas.Text = .Cabezas
            Me.txtKilosComprados.Text = .KilosComprados.ToString("#,###.000 kgs")
            Me.txtAdquisicion.Text = .ImporteCompra.ToString("C2")
            Me.txtObservaciones.Text = .Observaciones
            Me.cmbCorral.SelectedValue = .IdCorral
            Me.txtDiasDeCredito.Text = .DiasCredito
            Me.dtpFechaPago.Value = .FechaPago
            Me.txtNoFactura.Text = .NumFactura
            Me.txtBanco.Text = .NomBanco
            Me.txtSucursal.Text = .NomSucursal
            Me.txtNoCuenta.Text = .NumCuenta

            If Not Me.CompraGanado.GastosTransporte.Detalle.Count = 0 Then
                Me.txtSubTotal.Text = .GastosTransporte.SubTotal.ToString("C2")
                Me.txtIVA.Text = .GastosTransporte.IVA.ToString("C2")
                Me.txtTotal.Text = .GastosTransporte.ImporteTotal
                'Me.dtpFecha.Value = .GastosTransporte.FechaRecepcion
                Me.cmbChofer.SelectedValue = .GastosTransporte.IdChofer
                Me.CmbCamion.SelectedValue = .GastosTransporte.IdVehiculo
            End If

            Me.txtComision.Text = .Comision
            Me.lblEstatus.Text = .Estatus.ToString
            Me.lblEstatus.Visible = True
            Me.txtImporteTotal.Text = .ImporteCompraTotal.ToString("C2")
            Me.txtNoFactura.Text = .FolioFactura

            Me.rbtCabeza.Checked = .TipoComision = CompraGanadoClass.TiposComision.CABEZAS
            Me.rbtKilo.Checked = .TipoComision = CompraGanadoClass.TiposComision.KILOS

            Me.DgvConceptoGastos.AutoGenerateColumns = False
            Me.DgvConceptoGastos.DataSource = .GastosTransporte.Detalle
            Me.dgvTiposdeGanado.AutoGenerateColumns = False
            Me.dgvTiposdeGanado.DataSource = .Detalle
        End With
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.cmbComprador.Text = "" Then
                MessageBox.Show("Especifique comprador de ganado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbComprador.Focus()
                Return False
            End If

            If Me.cmbCorral.Text = "" Then
                MessageBox.Show("Especifique corral de reciba de ganado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbCorral.Focus()
                Return False
            End If

            If Me.cmbProveedor.Text = "" Then
                MessageBox.Show("Especifique proveedor de ganado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbProveedor.Focus()
                Return False
            End If

            If Me.txtKilosComprados.Text = "" OrElse Decimal.Parse(Me.txtKilosComprados.Text.Replace("kgs", "")) = 0D Then
                MessageBox.Show("Especifique Los Kilos Comprados", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dgvTiposdeGanado.Focus()
                Return False
            End If

            If Me.txtKilosRecibidos.Text = "" OrElse Decimal.Parse(Me.txtKilosRecibidos.Text.Replace("kgs", "")) = 0D Then
                MessageBox.Show("Especifique Los Kilos Recibidos", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtKilosRecibidos.Focus()
                Return False
            End If

            If Me.DgvConceptoGastos.Rows.Count = 1 Then
                If MessageBox.Show("¿No a ingresado gastos de transporte, quiere realizar la recepcion de compra?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Return False
                End If
            Else
                If (Me.cmbChofer.Text = "") Then
                    MessageBox.Show("Especifique chofer", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.cmbChofer.Focus()
                    Return False
                End If

                If (Me.CmbCamion.Text = "") Then
                    MessageBox.Show("Especifique camión", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.CmbCamion.Focus()
                    Return False
                End If
            End If

            If Me.rbtCabeza.Checked = False AndAlso Me.rbtKilo.Checked = False Then
                If MessageBox.Show("No a seleccionado un tipo de comsión. ¿Quiere realizar la recepción compra de ganado?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Calculos"
    Private Sub CalcularComision()
        If buscando Then Exit Sub

        If Not Me.rbtCabeza.Checked AndAlso Not Me.rbtKilo.Checked Then
            Me.txtComision.Text = 0D.ToString("C2")
        Else
            If Me.rbtCabeza.Checked Then
                If Me.cmbComprador.SelectedIndex > -1 Then
                    Dim comprador As CompradorGanadoClass = Me.cmbComprador.SelectedItem

                    If IsNumeric(Me.txtCantCabezas.Text) Then
                        Me.txtComision.Text = (comprador.ComisionxCabeza * CDec(Me.txtCantCabezas.Text)).ToString("C2")
                    End If
                End If
            End If

            If Me.rbtKilo.Checked Then
                If Me.cmbComprador.SelectedIndex > -1 Then
                    Dim comprador As CompradorGanadoClass = Me.cmbComprador.SelectedItem

                    If IsNumeric(Me.txtKilosComprados.Text) Then
                        Me.txtComision.Text = (comprador.ComisionPorKilo * CDec(Me.txtKilosComprados.Text)).ToString("C2")
                    End If
                End If
            End If
        End If

        Me.CalcularTotales()
    End Sub

    Private Sub CalcularMerma()
        If buscando Then Exit Sub

        Dim kilosComprados As Decimal = 0D
        Dim kilosRecibidos As Decimal = 0D
        Dim kilosMerma As Decimal = 0D

        If Not Me.txtKilosComprados.Text = "" AndAlso _
            IsNumeric(Me.txtKilosComprados.Text.Replace("kgs", "").Replace(",", "")) Then _
            kilosComprados = CDec(Me.txtKilosComprados.Text.Replace("kgs", "").Replace(",", ""))
        If IsNumeric(Me.txtKilosRecibidos.Text.Replace("kgs", "")) Then kilosRecibidos = CDec(Me.txtKilosRecibidos.Text.Replace("kgs", ""))

        If kilosRecibidos > kilosComprados Then
            Me.txtKilosMerma.Text = 0D.ToString("N3")
            Me.txtPorcentajeMerma.Text = 0D.ToString("P2")
        Else
            kilosMerma = (kilosComprados - kilosRecibidos)
            Me.txtKilosMerma.Text = kilosMerma.ToString("N3")

            If kilosComprados > 0D Then
                Me.txtPorcentajeMerma.Text = (kilosMerma / kilosComprados).ToString("P2")
            Else
                Me.txtPorcentajeMerma.Text = 0D.ToString("P2")
            End If
        End If
    End Sub

    Private Sub CalcularKilosYCabezasRecibidas()
        Dim kilos As Decimal = 0D
        Dim cabezas As Integer = 0
        Dim importe As Decimal = 0D
        Dim kilosComprados As Decimal = 0D

        'For Each row As DataGridViewRow In Me.dgvTiposdeGanado.Rows
        '    kilos += CDec(row.Cells(Me.Kilos.Index).Value)
        '    cabezas += CInt(row.Cells(Me.Cabezas.Index).Value)
        '    importe += CDec(row.Cells(Me.Importe.Index).Value)
        'Next

        For Each tipoGanado As CompraGanadoDetalleClass In Me.CompraGanado.Detalle
            kilos += tipoGanado.KilosRecibidos
            cabezas += tipoGanado.CantCabezas
            importe += tipoGanado.Importe
            kilosComprados += tipoGanado.CantKilos
        Next

        'Me.txtKilosRecibidos.Text = kilos.ToString("#,##0.000 kgs")
        Me.txtCantCabezas.Text = cabezas.ToString("N0")
        'Me.txtImporte.Text = importe.ToString("C2")
        Me.txtAdquisicion.Text = importe.ToString("C2")
        Me.txtKilosComprados.Text = kilosComprados.ToString("N3") '& " kgs"

        Me.CalcularMerma()
        Me.CalcularTotales()
    End Sub

    Private Sub CalcularGastos()
        Dim subTotal As Decimal = 0D
        Dim Iva As Decimal = 0D
        Dim total As Decimal = 0D

        For Each gasto As ClasesNegocio.GastoTransporteDetalleClass In Me.CompraGanado.GastosTransporte.Detalle
            subTotal += (gasto.ImporteGasto / (gasto.PorcentajeIva / 100D + 1D))
            Iva += (gasto.ImporteGasto - (gasto.ImporteGasto / (gasto.PorcentajeIva / 100D + 1D)))
            total += gasto.ImporteGasto
        Next

        Me.txtSubTotal.Text = subTotal.ToString("C2")
        Me.txtIVA.Text = Iva.ToString("C2")
        Me.txtTotal.Text = total.ToString("C2")
        Me.txtGastosTransporte.Text = total.ToString("C2")

        Me.CalcularTotales()
    End Sub

    Private Sub CalcularGuias()
        If Me.buscando Then Exit Sub

        Dim guias As Decimal = 0D
        Dim importeXGuia As Decimal = 0D

        If IsNumeric(Me.txtNoGuia.Text) Then guias = CDec(Me.txtNoGuia.Text)
        If IsNumeric(Me.txtImporteGuia.Text) Then importeXGuia = CDec(Me.txtImporteGuia.Text)

        Me.txtGuiaTransito.Text = (guias * importeXGuia).ToString("C2")
        Me.CalcularTotales()
    End Sub

    Private Sub CalcularimpuestoEducacion()
        Me.CalcularKilosYCabezasRecibidas()

        If Me.chkImpuestoEducacion.Checked Then
            Me.txtImporteEducacion.Text = ((Controlador.Configuracion.Engorda.PorcentajeEducacion / 100D) * _
                                                    CDec(Me.txtAdquisicion.Text)).ToString("C2")
        Else
            Me.txtImporteEducacion.Text = 0D.ToString("C2")
        End If

        Me.CalcularTotales()
    End Sub

    Private Sub CalcularImpuestoPredial()
        Me.CalcularKilosYCabezasRecibidas()

        If Me.chkImpuestoPredial.Checked Then
            Me.txtImportePredial.Text = (Controlador.Configuracion.Engorda.ImportePredial * CDec(Me.txtCantCabezas.Text)).ToString("C2")
        Else
            Me.txtImportePredial.Text = 0D.ToString("C2")
        End If

        Me.CalcularTotales()
    End Sub

    Private Sub CalcularTotales()
        If buscando Then Exit Sub

        Dim adquisicion As Decimal = 0D
        Dim comision As Decimal = 0D
        Dim guiaTransito As Decimal = 0D
        Dim impuestoPredial As Decimal = 0D
        Dim impuestoEducacion As Decimal = 0D
        Dim gastoTransporte As Decimal = 0D
        Dim importe As Decimal = 0D

        If IsNumeric(Me.txtAdquisicion.Text) Then adquisicion = CDec(Me.txtAdquisicion.Text)
        If IsNumeric(Me.txtComision.Text) Then comision = CDec(Me.txtComision.Text)
        If IsNumeric(Me.txtImportePredial.Text) Then impuestoPredial = CDec(Me.txtImportePredial.Text)
        If IsNumeric(Me.txtGuiaTransito.Text) Then guiaTransito = CDec(Me.txtGuiaTransito.Text)
        If IsNumeric(Me.txtImporteEducacion.Text) Then impuestoEducacion = CDec(Me.txtImporteEducacion.Text)
        If IsNumeric(Me.txtGastosTransporte.Text) Then gastoTransporte = CDec(Me.txtGastosTransporte.Text)

        importe = adquisicion + comision + guiaTransito + impuestoPredial + impuestoEducacion + gastoTransporte

        Me.txtImporteTotal.Text = importe.ToString("C2")
    End Sub
#End Region

    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim SC_CLOSE As Integer = &HF060
        Dim WM_SYSCOMMAND As Integer = &H112

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_CLOSE Then
            Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub KeyPressEdicionGirdEntero(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub KeyPressEdicionGirdDecimal(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse _
            (e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComprasGanadoDetalle_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs)
        If e.NewObject IsNot Nothing Then
            CType(e.NewObject, CompraGanadoDetalleClass).CompraGanado = Me.CompraGanado
        Else
            e.NewObject = New CompraGanadoDetalleClass
            CType(e.NewObject, CompraGanadoDetalleClass).CompraGanado = Me.CompraGanado
        End If
    End Sub

    Private Sub ComprasGanadoGastoTransporteDetalle_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs)
        If e.NewObject IsNot Nothing Then
            CType(e.NewObject, GastoTransporteDetalleClass).GastoTransporte = Me.CompraGanado.GastosTransporte
        Else
            e.NewObject = New GastoTransporteDetalleClass
            CType(e.NewObject, GastoTransporteDetalleClass).GastoTransporte = Me.CompraGanado.GastosTransporte
        End If
    End Sub
#End Region

#Region "Eventos"

#Region "Form"

    Private Sub FrmComprasGanado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mtb.CurrentToolBarButtonStatus And (MEAToolBar.MEAToolBar.ToolBarButtonEnum.Nuevo Or MEAToolBar.MEAToolBar.ToolBarButtonEnum.Editar) Then
            If MessageBox.Show("La Ventana se cerrara y los datos capturados se limpiaran, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Me.AutoValidate = Windows.Forms.AutoValidate.Inherit
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FrmComprasGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.TipoGanadoC.Obtener()

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "001101101"
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

            Me.Limpiar()
            Me.Deshabilitar()
            'Me.LlenaCombox()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If CompraGanado.Estatus = EstatusChar.CANCELADO Then
                MsgBox("No se puede cancelar esta Compra de Ganado, por que ya esta cancelada", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Quiere cancelar la compra de ganado?", "Cancelar Compra de Ganado", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = _
                        Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Me.CompraGanado.FechaCancelacion = Now
            Me.CompraGanado.IdUsuarioCancelacion = Controlador.Sesion.Usrndx

            If Me.CompraGanado.Borrar() Then
                MsgBox("Se cancelo la Recepción Compra de Ganado", MsgBoxStyle.Information, "Cancelada")
                Me.Limpiar()
                Me.Deshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        buscando = True

        Try
            Dim forma As New FrmConsultaComprasGanado

            If forma.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.CompraGanado = forma.CompraGanadoSeleccionada
                Me.LlenaComboBox()
                Me.PonerDatos()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        Finally
            buscando = False
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            If Me.CompraGanado.Estatus = EstatusChar.CANCELADO Then
                MsgBox("La compra de ganado esta cancelada, no se puede editar", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
            Else
                Me.DgvConceptoGastos.ReadOnly = False
                Me.ImporteGastoDataGridViewTextBoxColumn.ReadOnly = False
                Me.ConceptoGastoDataGridViewTextBoxColumn.ReadOnly = False
                Me.PorcentajeIvaDataGridViewTextBoxColumn.ReadOnly = True
                Me.txtNoGuia.Enabled = True
                Me.txtImporteGuia.Enabled = True
                Me.CmbCamion.Enabled = True
                Me.cmbChofer.Enabled = True
                Me.txtNoGuia.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Me.Validar Then
                Cancelar = True
                'MessageBox.Show("No se ha podido guardar el registro, verifique los datos", "Verificar Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Me.ObtenerDatosCabecero() Then
                If Me.CompraGanado.Guardar() Then
                    MsgBox("La compra se a guardado con el folio " & CompraGanado.Folio, MsgBoxStyle.Information, "Aviso")
                    Me.Limpiar()
                    Me.Deshabilitar()
                Else
                    Cancelar = True
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Controlador.Configuracion.ActualizarEngorda()

            CompraGanado = New ClasesNegocio.CompraGanadoClass
            Me.DgvConceptoGastos.AutoGenerateColumns = False
            Me.DgvConceptoGastos.DataSource = Me.CompraGanado.GastosTransporte.Detalle
            Me.dgvTiposdeGanado.AutoGenerateColumns = False
            Me.dgvTiposdeGanado.DataSource = Me.CompraGanado.Detalle

            AddHandler CType(Me.CompraGanado.Detalle, ComprasGanadoDetalleCollectionClass).AddingNew, _
                            AddressOf ComprasGanadoDetalle_AddingNew
            AddHandler CType(Me.CompraGanado.GastosTransporte.Detalle, GastoTransporteDetalleCollectionClass).AddingNew, _
                            AddressOf ComprasGanadoGastoTransporteDetalle_AddingNew

            Me.LlenaComboBox()
            Me.Limpiar()
            Me.Habilitar()

            If cmbProveedor.DataSource IsNot Nothing AndAlso cmbProveedor.DataSource.GetType Is GetType(CC.ProveedorCollection) _
            AndAlso CType(cmbProveedor.DataSource, CC.ProveedorCollection).Count = 1 Then
                cmbProveedor.SelectedIndex = 0
            End If

            If cmbCorral.DataSource IsNot Nothing AndAlso cmbCorral.DataSource.GetType Is GetType(DataTable) _
            AndAlso CType(cmbCorral.DataSource, DataTable).Rows.Count = 1 Then
                cmbCorral.SelectedIndex = 0
            End If

            If cmbChofer.DataSource IsNot Nothing AndAlso cmbChofer.DataSource.GetType Is GetType(ChoferesCollectionClass) _
            AndAlso CType(cmbChofer.DataSource, ChoferesCollectionClass).Count = 1 Then
                cmbChofer.SelectedIndex = 0
            End If

            If CmbCamion.DataSource IsNot Nothing AndAlso CmbCamion.DataSource.GetType Is GetType(VehiculosCollectionClass) _
            AndAlso CType(CmbCamion.DataSource, VehiculosCollectionClass).Count = 1 Then
                CmbCamion.SelectedIndex = 0
            End If

            If cmbComprador.DataSource IsNot Nothing AndAlso cmbComprador.DataSource.GetType Is GetType(CompradorGanadoCollectionClass) _
            AndAlso CType(cmbComprador.DataSource, CompradorGanadoCollectionClass).Count = 1 Then
                cmbComprador.SelectedIndex = 0
            End If

            If CmbLugarCompra.DataSource IsNot Nothing AndAlso CmbLugarCompra.DataSource.GetType Is GetType(LugaresDeCompraCollectionClass) _
            AndAlso CType(CmbLugarCompra.DataSource, LugaresDeCompraCollectionClass).Count = 1 Then
                CmbLugarCompra.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()

        If Me.AutoValidate <> Windows.Forms.AutoValidate.Disable Then
            Cancelar = True
        End If
    End Sub
#End Region

#Region "DataGrid"

    Private Sub dgvTiposdeGanado_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTiposdeGanado.CellValueChanged
        If e.RowIndex <> -1 Then
            If IdTipoGanadoDataGridViewTextBoxColumn.Index = e.ColumnIndex Then
                Dim Result As Boolean = Not (dgvTiposdeGanado(Me.IdTipoGanadoDataGridViewTextBoxColumn.Index, e.RowIndex).Value IsNot Nothing AndAlso dgvTiposdeGanado(Me.IdTipoGanadoDataGridViewTextBoxColumn.Index, e.RowIndex).Value > 0) ' AndAlso Not dgvTiposdeGanado.Rows(e.RowIndex).IsNewRow
                dgvTiposdeGanado(Me.CantKilosDataGridViewTextBoxColumn.Index, e.RowIndex).ReadOnly = Result
                dgvTiposdeGanado(Me.PrecioXKiloDataGridViewTextBoxColumn.Index, e.RowIndex).ReadOnly = Result
                dgvTiposdeGanado(Me.CantCabezasDataGridViewTextBoxColumn.Index, e.RowIndex).ReadOnly = Result
            End If
        End If
    End Sub

    Private Sub dgvTiposdeGanado_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvTiposdeGanado.SelectionChanged
        If Not Me.validarSalidaFila OrElse Me.dgvTiposdeGanado.CurrentRow Is Nothing Then Exit Sub

        Dim filaActual As Integer = Me.dgvTiposdeGanado.CurrentRow.Index

        For i As Integer = 0 To Me.dgvTiposdeGanado.Rows.Count - 2
            If i = filaActual Then Continue For

            Dim row As DataGridViewRow = Me.dgvTiposdeGanado.Rows(i)

            'If (Not IsNumeric(row.Cells(Me.CantKilosDataGridViewTextBoxColumn.Index).Value) OrElse _
            '    CDec(row.Cells(Me.CantKilosDataGridViewTextBoxColumn.Index).Value) = 0D) OrElse _
            '    (Not IsNumeric(row.Cells(Me.PrecioXKiloDataGridViewTextBoxColumn.Index).Value) OrElse _
            '    CDec(row.Cells(Me.PrecioXKiloDataGridViewTextBoxColumn.Index).Value) = 0D) OrElse _
            '    (Not IsNumeric(row.Cells(Me.CantCabezasDataGridViewTextBoxColumn.Index).Value) OrElse _
            '    CDec(row.Cells(Me.CantCabezasDataGridViewTextBoxColumn.Index).Value) = 0D) Then
            '    Me.validarSalidaFila = False
            '    Me.dgvTiposdeGanado.Rows(i).Cells(Me.dgvTiposdeGanado.CurrentCell.ColumnIndex).Selected = True
            '    Me.validarSalidaFila = True
            'End If

            If (Not IsNumeric(row.Cells(Me.PrecioXKiloDataGridViewTextBoxColumn.Index).Value) OrElse _
                CDec(row.Cells(Me.PrecioXKiloDataGridViewTextBoxColumn.Index).Value) = 0D) OrElse _
                (Not IsNumeric(row.Cells(Me.CantCabezasDataGridViewTextBoxColumn.Index).Value) OrElse _
                CDec(row.Cells(Me.CantCabezasDataGridViewTextBoxColumn.Index).Value) = 0D) Then
                Me.validarSalidaFila = False
                Me.dgvTiposdeGanado.Rows(i).Cells(Me.dgvTiposdeGanado.CurrentCell.ColumnIndex).Selected = True
                Me.validarSalidaFila = True
            End If
        Next
    End Sub

    Private Sub dgvTiposdeGanado_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTiposdeGanado.CellEndEdit
        Try
            Dim row As DataGridViewRow = Me.dgvTiposdeGanado.CurrentRow

            Select Case e.ColumnIndex
                Case Me.IdTipoGanadoDataGridViewTextBoxColumn.Index
                    Me.dgvTiposdeGanado.Refresh()
                Case Me.CantKilosDataGridViewTextBoxColumn.Index
                    Me.CalcularKilosYCabezasRecibidas()
                    Me.CalcularComision()
                    Me.CalcularimpuestoEducacion()
                    Me.CalcularImpuestoPredial()
                Case Me.PrecioXKiloDataGridViewTextBoxColumn.Index
                    Me.CalcularKilosYCabezasRecibidas()
                    Me.CalcularComision()
                    Me.CalcularimpuestoEducacion()
                    Me.CalcularImpuestoPredial()
                Case Me.CantCabezasDataGridViewTextBoxColumn.Index
                    Me.CalcularKilosYCabezasRecibidas()
                    Me.CalcularComision()
                    Me.CalcularimpuestoEducacion()
                    Me.CalcularImpuestoPredial()
                Case Me.KilosRecibidosDataGridViewTextBoxColumn.Index
                    Me.CalcularKilosYCabezasRecibidas()
                    Me.CalcularComision()
                    Me.CalcularimpuestoEducacion()
                    Me.CalcularImpuestoPredial()
            End Select

            Me.dgvTiposdeGanado.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvTiposdeGanado_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvTiposdeGanado.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf KeyPressEdicionGirdDecimal
        RemoveHandler e.Control.KeyPress, AddressOf KeyPressEdicionGirdEntero

        If Me.dgvTiposdeGanado.CurrentCell.ColumnIndex = Me.IdTipoGanadoDataGridViewTextBoxColumn.Index Then
            RemoveHandler CType(e.Control, DataGridViewComboBoxEditingControl).SelectionChangeCommitted, AddressOf Utilerias.DataGridViewComboBoxEditingControl_SelectionChangeCommitted
            AddHandler CType(e.Control, DataGridViewComboBoxEditingControl).SelectionChangeCommitted, AddressOf Utilerias.DataGridViewComboBoxEditingControl_SelectionChangeCommitted
        ElseIf Me.dgvTiposdeGanado.CurrentCell.ColumnIndex = Me.CantCabezasDataGridViewTextBoxColumn.Index Then
            AddHandler e.Control.KeyPress, AddressOf KeyPressEdicionGirdEntero
        ElseIf Me.dgvTiposdeGanado.CurrentCell.ColumnIndex = Me.CantKilosDataGridViewTextBoxColumn.Index OrElse _
                Me.dgvTiposdeGanado.CurrentCell.ColumnIndex = Me.PrecioXKiloDataGridViewTextBoxColumn.Index OrElse _
                Me.dgvTiposdeGanado.CurrentCell.ColumnIndex = Me.KilosRecibidosDataGridViewTextBoxColumn.Index Then
            AddHandler e.Control.KeyPress, AddressOf KeyPressEdicionGirdDecimal
            'ElseIf Me.dgvTiposdeGanado.CurrentCell.ColumnIndex = Me.IdTipoGanadoDataGridViewTextBoxColumn.Index Then
            '    Dim tiposGanado As New ClasesNegocio.TipoGanadoColecttionClass
            '    Dim tiposGanadoUsados As New Dictionary(Of Integer, String)

            '    For Each detalleCompraGanado As CompraGanadoDetalleClass In Me.CompraGanado.Detalle
            '        tiposGanadoUsados.Add(detalleCompraGanado.IdTipoGanado, "")
            '    Next

            '    For Each tipoGanado As TipoGanadoClass In Me.TipoGanadoC
            '        If Not tiposGanadoUsados.ContainsKey(tipoGanado.IdTipoGanado) Then
            '            tiposGanado.Add(tipoGanado)
            '        End If
            '    Next

            '    DirectCast(e.Control, ComboBox).DataSource = tiposGanado
        End If
    End Sub

    Private Sub dgvTiposdeGanado_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvTiposdeGanado.DataError

    End Sub

    Private Sub dgvTiposdeGanado_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvTiposdeGanado.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgvTiposdeGanado.CurrentCell.RowIndex > -1 AndAlso _
                        Me.dgvTiposdeGanado.CurrentCell.RowIndex < Me.dgvTiposdeGanado.Rows.Count - 1 Then
                If MessageBox.Show("¿Quiere quitar el tipo de ganado seleccionado?", "Quitar tipo ganado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Me.dgvTiposdeGanado.Rows.RemoveAt(dgvTiposdeGanado.CurrentCell.RowIndex)
                End If
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            Me.TipoGanadoC.Obtener(ClasesNegocio.EstatusDatos.VIGENTE)
        End If
    End Sub

    Private Sub DgvConceptoGastos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvConceptoGastos.CellEndEdit
        Try
            If e.ColumnIndex = Me.ImporteGastoDataGridViewTextBoxColumn.Index OrElse _
                e.ColumnIndex = Me.PorcentajeIvaDataGridViewTextBoxColumn.Index Then
                Me.CalcularGastos()
            End If

            Me.DgvConceptoGastos.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvConceptoGastos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvConceptoGastos.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf KeyPressEdicionGirdDecimal

        If Me.DgvConceptoGastos.CurrentCell.ColumnIndex = Me.ImporteGastoDataGridViewTextBoxColumn.Index OrElse _
            Me.DgvConceptoGastos.CurrentCell.ColumnIndex = Me.PorcentajeIvaDataGridViewTextBoxColumn.Index Then
            AddHandler e.Control.KeyPress, AddressOf KeyPressEdicionGirdDecimal
        End If
    End Sub

    Private Sub DgvConceptoGastos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvConceptoGastos.SelectionChanged
        If Not validarSalidaFila Then Exit Sub

        For i As Integer = 0 To Me.DgvConceptoGastos.Rows.Count - 2
            If Me.DgvConceptoGastos.CurrentRow.Index = i Then Continue For

            Dim row As DataGridViewRow = Me.DgvConceptoGastos.Rows(i)

            If Not IsNumeric(row.Cells(Me.ImporteGastoDataGridViewTextBoxColumn.Index).Value) OrElse _
                CDec(row.Cells(Me.ImporteGastoDataGridViewTextBoxColumn.Index).Value) = 0D Then
                Me.validarSalidaFila = False
                Me.DgvConceptoGastos.Rows(i).Cells(Me.DgvConceptoGastos.CurrentCell.ColumnIndex).Selected = True
                Me.validarSalidaFila = True
            End If
        Next
    End Sub

    Private Sub DgvConceptoGastos_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvConceptoGastos.DataError

    End Sub

    Private Sub DgvConceptoGastos_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DgvConceptoGastos.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.DgvConceptoGastos.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Quiere quitar el gasto de trasporte seleccionado de la lista?", "Quitar Gasto de Transporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Me.DgvConceptoGastos.Rows.RemoveAt(Me.DgvConceptoGastos.CurrentCell.RowIndex)
                End If
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            Me.ConceptoGastoC.Obtener(CondicionEnum.ACTIVOS)
        End If
    End Sub
#End Region

#Region "TextBox"
    Private Sub txtCabeza_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComision.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtImporteTotal.Focus()
        End If
    End Sub

    Private Sub txtImporteComision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteTotal.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.rbtKilo.Focus()
        End If
    End Sub

    Private Sub txtKilo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtGastosTransporte.Focus()
        End If
    End Sub

    Private Sub txtOtrosGastos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGastosTransporte.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtAdquisicion.Focus()
        End If
    End Sub

    Private Sub txtAdquisicion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdquisicion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtGuiaTransito.Focus()
        End If
    End Sub

    Private Sub txtGuiaTransito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaTransito.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtImportePredial.Focus()
        End If
    End Sub

    Private Sub txtImpuestoPredial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImportePredial.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtImporteEducacion.Focus()
        End If
    End Sub

    Private Sub txtImporteEducacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteEducacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.DgvConceptoGastos.Focus()
        End If
    End Sub

    Private Sub txtNoFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoFactura.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuenta.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKilosComprados_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKilosComprados.GotFocus
        Me.txtKilosComprados.Text = IIf(Me.txtKilosComprados.Text = "", "", Me.txtKilosComprados.Text.Replace(",", "").Replace("kgs", ""))
    End Sub

    Private Sub txtKilosComprados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosComprados.KeyPress
        Try
            If e.KeyChar = "." And Me.txtKilosComprados.Text.IndexOf(".") > -1 Then
                e.Handled = True
            End If
            If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtObservaciones.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNoGuia.Focus()
        End If
    End Sub

    Private Sub txtNoGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoGuia.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtImporteGuia.Focus()
            Exit Sub
        End If

        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoGuia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoGuia.TextChanged
        Try
            Me.CalcularGuias()
        Catch ec As ArithmeticException
            MsgBox("Ocurrio un error al calcular el importe total de guias", MsgBoxStyle.Critical, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtKilosComprados_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKilosComprados.LostFocus
        Me.txtKilosComprados.Text = CDec(IIf(IsNumeric(Me.txtKilosComprados.Text), Me.txtKilosComprados.Text, 0)).ToString("#,###.000 kgs")
    End Sub

    Private Sub txtImporteGuia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteGuia.GotFocus
        Me.txtImporteGuia.Text = IIf(Me.txtImporteGuia.Text = "", 0.0, Me.txtImporteGuia.Text.Replace("$", "").Replace(",", ""))
    End Sub

    Private Sub txtImporteGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteGuia.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Me.rbtCabeza.Focus()
                Exit Sub
            End If

            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse _
                (e.KeyChar = "."c AndAlso Me.txtImporteGuia.Text.IndexOf("."c) > -1) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtImporteGuia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteGuia.LostFocus
        Me.txtImporteGuia.Text = CDec(IIf(IsNumeric(Me.txtImporteGuia.Text), Me.txtImporteGuia.Text, 0)).ToString("C2")
    End Sub

    Private Sub txtImporteGuia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteGuia.TextChanged
        Try
            Me.CalcularGuias()
        Catch ec As ArithmeticException
            MsgBox("Ocurrio un error al realizar el calculo de gasto de guias", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtKilosComprados_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKilosComprados.TextChanged
        'Try
        '    Me.CalcularMerma()
        '    Me.CalcularTotales()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub txtKilosRecibidos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKilosRecibidos.GotFocus
        Try
            Me.txtKilosRecibidos.Text = Me.txtKilosRecibidos.Text.Replace("kgs", "").Replace(",", "")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtKilosRecibidos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosRecibidos.KeyPress
        If e.KeyChar = "." And Me.txtKilosComprados.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKilosRecibidos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKilosRecibidos.LostFocus
        Try
            If Not Me.txtKilosRecibidos.Text.Trim = "" Then
                Me.txtKilosRecibidos.Text = CDec(Me.txtKilosRecibidos.Text).ToString("#,##0.00 kgs")
            Else
                Me.txtKilosRecibidos.Text = 0D.ToString("#,##0.00 kgs")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtKilosRecibidos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKilosRecibidos.TextChanged
        Try
            Me.CalcularMerma()
            Me.CalcularTotales()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmbProveedor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProveedor.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbProveedor.DataSource = CC.ProveedorCollection.GetMultiAsDataTable(HC.ProveedorFields.EsdeGanado = 1, 0, Nothing)
                Me.cmbProveedor.SelectedIndex = -1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbComprador_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbComprador.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.CompradoresGanadoC.Obtener()
                Me.cmbComprador.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCorral_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbCorral.PreviewKeyDown

        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbCorral.DataSource = CC.McecatCorralesCabCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
                Me.cmbCorral.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If (Me.cmbProveedor.SelectedIndex > -1) Then
            Me.txtDiasDeCredito.Text = DirectCast(Me.cmbProveedor.SelectedItem, _
                                        EC.ProveedorEntity).ProveedorAvanzado.DiasCredito
        Else
            Me.txtDiasDeCredito.Clear()
        End If
    End Sub

    Private Sub cmbproveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbComprador.Focus()
        End If
    End Sub

    Private Sub cmbcomprador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbComprador.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbCorral.Focus()
        End If
    End Sub

    Private Sub cmbCorral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCorral.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKilosComprados.Focus()
        End If
    End Sub

    Private Sub cmbComprador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComprador.SelectedIndexChanged
        Try
            If Me.cmbComprador.SelectedIndex > -1 Then
                Dim compradorGanado As CompradorGanadoClass = DirectCast(Me.cmbComprador.SelectedItem, CompradorGanadoClass)

                If compradorGanado.ComisionPorKilo > 0D Then
                    Me.rbtKilo.Checked = True
                ElseIf compradorGanado.ComisionxCabeza > 0D Then
                    Me.rbtCabeza.Checked = True
                Else
                    Me.rbtCabeza.Checked = False
                    Me.rbtKilo.Checked = False
                End If

                Me.CalcularComision()
            Else
                Me.cmbComprador.Text = "Seleccione un comprador"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbLugarCompra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLugarCompra.SelectedIndexChanged
        If Me.CmbLugarCompra.SelectedIndex > -1 Then
            Dim lug As LugaresDeCompraClass = Me.CmbLugarCompra.SelectedItem

            Me.txtHorasViaje.Text = lug.Entidad.HorasTransporte
        Else
            Me.txtHorasViaje.Clear()
            Me.CmbLugarCompra.Text = "Seleccione un lugar de compra"
        End If
    End Sub

    Private Sub CmbLugarCompra_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbLugarCompra.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Dim lugaresCompra As New LugaresDeCompraCollectionClass

                lugaresCompra.Obtener(CondicionEnum.ACTIVOS)
                Me.CmbLugarCompra.DataSource = lugaresCompra
                CmbLugarCompra.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "RadioButons"
    Private Sub rbtCabeza_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbtCabeza.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtComision.Focus()
        End If
    End Sub

    Private Sub rbtCabeza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCabeza.CheckedChanged
        Try
            Me.CalcularComision()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub rbtKilo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtKilo.CheckedChanged
        Try
            Me.CalcularComision()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "DateTime"
    Private Sub dtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbProveedor.Focus()
        End If
    End Sub
#End Region

#Region "CheckBox"
    Private Sub chkImpuestoPredial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImpuestoPredial.CheckedChanged
        If Me.buscando Then Exit Sub

        Try
            Me.CalcularImpuestoPredial()
        Catch ec As ArithmeticException
            MsgBox("Ocurrio un error al calcular el impuesto predial", MsgBoxStyle.Critical, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkImpuestoEducacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImpuestoEducacion.CheckedChanged
        If Me.buscando Then Exit Sub

        Try
            Me.CalcularimpuestoEducacion()
        Catch ec As ArithmeticException
            MsgBox("Ocurrio un error al calcular el impuesto a la educación", MsgBoxStyle.Critical, "Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#End Region
    
    Private Sub dgvTiposdeGanado_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvTiposdeGanado.UserAddedRow
        If mtb.CurrentToolBarButtonStatus = MEAToolBar.MEAToolBar.ToolBarButtonEnum.Nuevo Then
            e.Row.Cells(Me.CantKilosDataGridViewTextBoxColumn.Index).ReadOnly = True
            e.Row.Cells(Me.PrecioXKiloDataGridViewTextBoxColumn.Index).ReadOnly = True
            e.Row.Cells(Me.CantCabezasDataGridViewTextBoxColumn.Index).ReadOnly = True
        End If
    End Sub
End Class