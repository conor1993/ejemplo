Imports CN = ClasesNegocio
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Net.NetworkInformation
Imports System.Data.SqlClient

Public Class FrmRecepcionPagosClientes

#Region "Miembros"

    Private PagoClientes As CN.PagosDeClientesClass
    Private Poliza As CN.PolizaClass
    Private PolizaDet As CN.PolizaDetalleClass
    Private MovBancos As CN.MovimientosBancosClass
    Private Cuentas As CN.CuentaCollectionClass
    Private Cuenta As CN.CuentaClass
    Private _Folio As String = ""
    Private ConceptodePago As String
    Private PagosCol As CN.PagosDeClientesCollectionClass
    Private _NotaCredito As CN.NotaCreditoDetClass

#End Region

#Region "Metodos"

    Sub Limpiar()
        Me.CmbClientes.SelectedIndex = -1
        Me.txtChequesPos.Text = "0"
        Me.txtDocumento.Text = ""
        Me.txtImporteDetalle.Text = "0"
        Me.txtImportePago.Text = "0"
        Me.txtImporteTotal.Text = "0"
        Me.txtNotasCredito.Text = "0"
        Me.txtSaldoActual.Text = "0"
        Me.DgvFacturas.DataSource = Nothing
        Me.DtpFechaPago.Value = Now
        Me.txtCuentaHabiente.Text = ""
        Me.CmbCuentas.SelectedIndex = -1
        Me.txtBanco.Text = ""
        Me.lblEstatus.Visible = False
        Me.txtFolio.Text = ""
    End Sub

    Sub Habilitar(ByVal Estado As Boolean)
        Me.CmbClientes.Enabled = Estado
        Me.DgvFacturas.Enabled = Estado
        Me.txtDocumento.Enabled = Estado
        Me.DtpFechaPago.Enabled = Estado
        Me.CmbCuentas.Enabled = Estado
        Me.txtImporteDetalle.Enabled = Estado
        Me.cmdAplicarNota.Enabled = Estado
    End Sub

    Private Sub Sumar()
        Try
            Dim Total As Decimal = 0D
            Dim Saldo As Decimal = 0D
            Dim TotalNotasCredito As Decimal = 0D

            For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                If CBool(Me.DgvFacturas.Rows(i).Cells(Me.clmChk.Index).Value) Then
                    Total += Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value

                    TotalNotasCredito += CDec(DgvFacturas.Rows(i).Cells(Me.clmImporteNotaCredito.Index).Value)
                End If
                Saldo += Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
            Next


            txtImporteTotal.Text = Total.ToString("C2") 'If((Total - TotalNotasCredito) < 0, 0.ToString("C2"), (Total - TotalNotasCredito).ToString("C2"))
            txtImportePago.Text = Total.ToString("C2")
            txtSaldoActual.Text = Saldo.ToString("C2")
            txtNotasCredito.Text = TotalNotasCredito.ToString("C2")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            Dim band As Boolean = False
            If Me.txtDocumento.Text = "" Then
                MessageBox.Show("Ingrese el Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            If Me.CmbCuentas.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione una cuenta bancaria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1

                If CBool(Me.DgvFacturas.Rows(i).Cells(Me.clmChk.Index).Value) = True Then
                    band = True
                    Exit For
                End If
            Next
            If band = False Then
                MessageBox.Show("Seleccione una Factura a Pagar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'If CDec(Me.txtImportePago.Text) > CDec(Me.txtImporteTotal.Text) Then
            '    MessageBox.Show("El pago es mayor al saldo de la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub AplicacionNotasCredito(ByVal RowIndex As Integer, Optional ByVal Edicion As Boolean = False)
        If DgvFacturas.Rows(RowIndex).Cells(Me.clmChk.Index).Value Then
            Dim NotaPorAplicar As Boolean = False
            Dim Factura As CN.FacturasClientesCabClass = CType(DgvFacturas.Rows(RowIndex).Tag, CN.FacturasClientesCabClass)

            For Each NotaDetalle As EC.NotaCreditoDetEntity In Factura.NotasCredito
                If CType(NotaDetalle.Estatus, CN.NotaCreditoEnum) = CN.NotaCreditoEnum.VIGENTE Then
                    NotaPorAplicar = True
                End If
            Next

            If NotaPorAplicar Then
                Dim Resultado As DialogResult

                If Edicion Then
                    Resultado = MessageBox.Show("¿Desea seleccionar las notas de credito para su aplicacion?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Else
                    Resultado = MessageBox.Show("Esta factura tiene notas de credito pendientes por aplicar, ¿desea aplicarlas?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                End If

                If Resultado = Windows.Forms.DialogResult.Yes Then
                    Dim NotasCreditoAplicar As New FrmAplicarNotadeCredito
                    NotasCreditoAplicar.Factura = CType(DgvFacturas.Rows(RowIndex).Tag, CN.FacturasClientesCabClass)
                    NotasCreditoAplicar.ShowDialog()
                End If
            End If
            'DgvFacturas.Rows(RowIndex).Cells(clmImporteNotaCredito.Index).Value = Factura.TotalNotasCreditoPorAplicar
            DgvFacturas.Rows(RowIndex).Cells(Me.clmApagar.Index).Value = DgvFacturas.Rows(RowIndex).Cells(Me.clmSaldo.Index).Value - DgvFacturas.Rows(RowIndex).Cells(clmImporteNotaCredito.Index).Value
        End If
    End Sub

    Private Sub Preseleccionar()
        Dim Sql As String = "select distinct(Cta_Bancar), count(*) as Est from MvbaCb" & _
                    " group by Cta_Bancar" & _
                    " order by Est desc"
        Dim da As New SqlClient.SqlDataAdapter(Sql, HC.DbUtils.ActualConnectionString)
        Dim dt As New DataTable

        da.Fill(dt)

        If dt.Rows.Count > 1 AndAlso CType(dt.Rows(0)(1), Integer) > CType(dt.Rows(1)(1), Integer) Then
            CmbCuentas.SelectedValue = CType(dt.Rows(0)(0), Integer)
        End If
    End Sub

    Private Sub Nuevo()
        Limpiar()
        Habilitar(True)
        Me.DtpFechaPago.Value = Now
        Me.DgvFacturas.AutoGenerateColumns = False
        Preseleccionar()
        CmbClientes.Focus()
    End Sub

#End Region

#Region "Eventos"

    Private Sub FrmRecepcionPagosClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados

            Dim ClientesCol As New CN.ClientesIntroductoresColeccion
            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.CmbClientes.DisplayMember = "Nombre"
            Me.CmbClientes.ValueMember = "Codigo"
            Me.CmbClientes.DataSource = ClientesCol

            Cuentas = New CN.CuentaCollectionClass
            Me.CmbCuentas.DisplayMember = "Cuenta"
            Me.CmbCuentas.ValueMember = "Codigo"
            Cuentas.Obtener(ClasesNegocio.EstatusEnum.ACTIVO)
            Me.CmbCuentas.DataSource = Cuentas

            mtb.sbCambiarEstadoBotones("Nuevo")
            Nuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbClientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbClientes.SelectedIndexChanged
        Try
            Dim Filtro As New OC.PredicateExpression

            Dim _idUsuario As Integer = 0
            If Not Me.CmbClientes.SelectedValue Is Nothing Then
                _idUsuario = Me.CmbClientes.SelectedValue
            End If

            Me.DgvFacturas.DataSource = Nothing
            Dim dt As New DataTable
            Dim query As String = "ConsultaPagosdeCliente"
            Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
            Dim command As New SqlCommand(query, sqlCon)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@V_ID_Cliente", _idUsuario))
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dt)

            'Filtro.Add(HC.VwCxcfacturasClientesFields.IdClienteCargo = Me.CmbClientes.SelectedValue And HC.VwCxcfacturasClientesFields.SaldoFactura <> 0)

            'Dim Vista As New TC.VwCxcfacturasClientesTypedView
            'Vista.Fill(0, Nothing, True, Filtro)

            Me.DgvFacturas.AutoGenerateColumns = False
            Me.DgvFacturas.DataSource = dt

            'For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
            'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value = Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
            'Next
            Sumar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "CancelacionPago")

        Try
            Dim SaldoAnterior As Decimal = Cuenta.SaldoActual

            If Me.PagoClientes.Estatus = ClasesNegocio.EstatusChar.CANCELADO Then
                MessageBox.Show("No se puede cancelar el pago debido a que ya esta cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el pago del cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim PolizaAux As New CN.PolizaClass
                PolizaAux.Obtener(PagoClientes.IdPoliza)
                Me.Poliza = New CN.PolizaClass()
                Dim Polizas As String = ""

                For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                    Polizas = Polizas & Me.DgvFacturas.Rows(i).Cells(Me.ClmNoFactura.Index).Value & ", "
                Next

                Polizas = Polizas.Substring(0, Polizas.Length - 2)

                Poliza.Concepto = "Cancelación del deposito " & Me.txtFolio.Text & " del Cliente: " & Trim(Me.CmbClientes.Text) '& " a las Facturas: " & Polizas
                Poliza.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
                Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
                Poliza.FechaCaptura = Now.Date
                Poliza.FechaPoliza = Now.Date
                Poliza.Importe = Me.txtImporteTotal.Text
                Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.CUENTASxCOBRAR
                Poliza.TipoCambio = 1
                Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
                Poliza.TipoError = 0
                Poliza.Referencia = PagoClientes.IdPoliza

                If Not PolizaAux.Detalles.Count > 0 Then
                    MsgBox("Poliza erronea no se encontro su detalle", MsgBoxStyle.Exclamation, "Aviso")
                    Trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If
                'Se crea el cargo de la poliza
                Me.PolizaDet = New CN.PolizaDetalleClass
                Me.PolizaDet.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.C
                PolizaDet.CuentaContable = PolizaAux.Detalles(1).CuentaContable
                PolizaDet.Posicion = 1
                PolizaDet.Importe = Me.txtImporteTotal.Text

                Poliza.Detalles2.Add(PolizaDet)

                If Not Poliza.Detalles2.Count > 0 Then
                    MsgBox("Se cancelara la instrucción debido a que no se encuentra el detalle de la poliza", MsgBoxStyle.Exclamation, "Aviso")
                    Trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If
                'Se crea el abono de la poliza
                PolizaDet = New CN.PolizaDetalleClass
                PolizaDet.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.A
                PolizaDet.CuentaContable = PolizaAux.Detalles(0).CuentaContable
                PolizaDet.Posicion = 2
                PolizaDet.Importe = Me.txtImporteTotal.Text

                Poliza.Detalles2.Add(PolizaDet)

                If Not Poliza.Guardar2(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                For Each Pago As CN.PagosDeClientesClass In PagosCol
                    Pago.Estatus = ClasesNegocio.EstatusChar.CANCELADO
                    Pago.IdUsurioCancelacion = Controlador.Sesion.Usrndx
                    Pago.IdPolizaCancelacion = Poliza.Codigo
                    Pago.FechaCancelacion = Now
                    Cuenta.SaldoActual -= Pago.ImporteIngreso
                Next

                Trans.Add(Cuenta.ObtenerEntidad)
                Cuenta.ObtenerEntidad.Save()

                If PagosCol.Count > 0 Then
                    PagoClientes = New CN.PagosDeClientesClass

                    If Not PagoClientes.Borrar(Trans, PagosCol) Then
                        Trans.Rollback()
                        MessageBox.Show("No se logro cancelar el pago intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Cancelar = True
                        Exit Sub
                    End If
                Else
                    MsgBox("No se encontraron facturas afectadas con este pago", MsgBoxStyle.Exclamation, "Aviso")
                    Trans.Rollback()
                    Cancelar = True
                    Exit Sub
                End If

                MovBancos = New CN.MovimientosBancosClass()
                MovBancos.NumPoliza = Me.Poliza.Codigo
                MovBancos.CtaBancaria = Cuenta.Codigo
                MovBancos.SaldoAnterior = SaldoAnterior
                MovBancos.FechaMov = Now
                MovBancos.FechaCaptura = MovBancos.FechaMov
                MovBancos.Importe = Me.txtImporteTotal.Text
                MovBancos.Concepto = Poliza.Concepto
                MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.ABONO
                MovBancos.TipoCambio = 1
                MovBancos.TipoMov = "R"
                MovBancos.Origen = "Y"
                MovBancos.CveCancelacion = "S"

                If Not MovBancos.Guardar(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                End If

                Trans.Commit()
                MessageBox.Show("El Pago fue cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Habilitar(False)
                Limpiar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Limpiar()
            Dim Ventana As New FrmBusquedaPagoClientes
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim IdCliente As Integer = Ventana.dgvPagos.SelectedRows(0).Cells(Ventana.clmIdCliente.Index).Value
                Dim FolioIngreso As String = Ventana.dgvPagos.SelectedRows(0).Cells(Ventana.clmFolioIngreso.Index).Value
                Dim FolioFact As String = Ventana.DgvFacturas.Rows(0).Cells(Ventana.NoFactura.Index).Value

                PagoClientes = New CN.PagosDeClientesClass
                PagoClientes.Obtener(FolioIngreso, FolioFact)
                Me.txtDocumento.Text = PagoClientes.Documento
                Me.txtFolio.Text = PagoClientes.FolioIngreso
                Me.lblEstatus.Visible = True
                Me.lblEstatus.Text = PagoClientes.Estatus.ToString
                Me.DtpFechaPago.Value = PagoClientes.Fecha_ingreso
                Me.CmbClientes.SelectedValue = PagoClientes.Cve_cliente

                Me.PagosCol = New CN.PagosDeClientesCollectionClass
                PagosCol.Obtener(IdCliente, FolioIngreso)
                'Coleccion.Obtener(FolioFact, FolioIngreso)

                Me.DgvFacturas.AutoGenerateColumns = False
                Me.DgvFacturas.DataSource = PagosCol
                Me.DgvFacturas.Enabled = False

                For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                    Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value = Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
                Next

                Dim Total As Decimal = 0D
                Dim Saldo As Decimal = 0D
                Dim TotalNotasCredito As Decimal = 0D
                For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                    Dim Pago As CN.PagosDeClientesClass = CType(DgvFacturas.Rows(i).DataBoundItem, CN.PagosDeClientesClass)
                    DgvFacturas.Rows(i).Cells(Me.clmImporteNotaCredito.Index).Value = Pago.ImporteNotaCredito
                    DgvFacturas.Rows(i).Cells(clmTotal.Index).Value = Pago.ImporteFactura
                    Total += Me.DgvFacturas.Rows(i).Cells(Me.clmAbono.Index).Value
                    Saldo += Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
                    TotalNotasCredito += Pago.ImporteNotaCredito
                Next
                txtNotasCredito.Text = TotalNotasCredito.ToString("C2")
                Me.txtImporteTotal.Text = (Total + TotalNotasCredito).ToString("C2")
                Me.txtImportePago.Text = Total.ToString("C2")
                Me.txtSaldoActual.Text = Saldo.ToString("C2")

                Dim MovBancosCol As New CN.MovimientosBancosColecctionClass
                If PagoClientes.Estatus = ClasesNegocio.EstatusChar.VIGENTE Then
                    MovBancosCol.Obtener(PagoClientes.IdPoliza, "Y", ClasesNegocio.CondicionEnum.ACTIVOS)
                Else
                    MovBancosCol.Obtener(PagoClientes.IdPoliza, "Y", ClasesNegocio.CondicionEnum.INACTIVOS)
                End If

                Cuenta = New CN.CuentaClass(MovBancosCol(0).CtaBancaria)
                Me.CmbCuentas.SelectedValue = Cuenta.Codigo
                Me.txtBanco.Text = Cuenta.Banco.Descripcion
                Me.txtCuentaHabiente.Text = Cuenta.CuentaHabiente
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Habilitar(False)
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "PagoClientes")
        Dim ColeccionNotasCredito As New CC.NotaCreditoCabCollection
        Dim ColeccionNotasCreditoDetalle As New CC.NotaCreditoDetCollection

        Try
            'Me.DgvFacturas.CurrentRow.Cells(Me.clmApagar.Index).Selected = True
            Dim SaldoAnterior As Decimal = Cuenta.SaldoActual
            Dim band As Boolean = False
            Dim Cliente As New CN.ClientesIntroductoresClass

            Cliente = DirectCast(Me.CmbClientes.SelectedItem, CN.ClientesIntroductoresClass)

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If Cliente.CuentaContableId = -1 Then
                MessageBox.Show("El Cliente no tiene asignada una cuenta contable, Se cancelara la instrucción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
                Exit Sub
            End If

            Dim PagoClientesFolio As New CN.PagosDeClientesClass
            Dim FolioIngreso As String

            'clases de movimientos bancarios y polizas
            Me.MovBancos = New CN.MovimientosBancosClass
            Me.Poliza = New CN.PolizaClass

            'se guarda la poliza en contabilidad
            Poliza.Concepto = "Deposito del Cliente: " & Trim(Me.CmbClientes.Text) & " a la Facturas: " & ConceptodePago
            Poliza.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            Poliza.FechaCaptura = Now
            Poliza.FechaPoliza = Me.DtpFechaPago.Value
            Poliza.Importe = Me.txtImporteTotal.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
            Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.CUENTASxCOBRAR
            Poliza.TipoCambio = 1
            Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.INGRESO
            Poliza.TipoError = 0

            'Se crea el cargo de la poliza

            Me.PolizaDet = New CN.PolizaDetalleClass
            Me.PolizaDet.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.C
            PolizaDet.CuentaContable = Cuenta.CuentaContable
            PolizaDet.Posicion = 1
            PolizaDet.Importe = Me.txtImporteTotal.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value

            Poliza.Detalles2.Add(PolizaDet)

            'Se crea el abono de la poliza
            Me.PolizaDet = New CN.PolizaDetalleClass
            PolizaDet.Operacion2 = ClasesNegocio.PolizaOperacionEnum2.A
            PolizaDet.CuentaContable = Cliente.CuentaContable
            PolizaDet.Posicion = 2
            PolizaDet.Importe = Me.txtImporteTotal.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value

            Poliza.Detalles2.Add(PolizaDet)

            If Not Poliza.Detalles2.Count > 0 Then
                MsgBox("Se cancelara la instrucción debido a que no se encuentra el detalle de la poliza", MsgBoxStyle.Exclamation, "Aviso")
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            If Not Poliza.Guardar2(Trans) Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudieron Guardar los pagos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'se guarda movimiento en tabla de bancos
            MovBancos.NumPoliza = Me.Poliza.Codigo
            MovBancos.CtaBancaria = Cuenta.Codigo
            MovBancos.SaldoAnterior = SaldoAnterior
            MovBancos.FechaMov = Me.DtpFechaPago.Value
            MovBancos.FechaCaptura = Now
            MovBancos.Importe = Me.txtImporteTotal.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
            MovBancos.Concepto = Poliza.Concepto
            MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.CARGO
            MovBancos.TipoCambio = 1
            MovBancos.TipoMov = "D"
            MovBancos.Origen = "Y"
            MovBancos.CveCancelacion = "N"

            If Not MovBancos.Guardar(Trans) Then
                Trans.Rollback()
                MessageBox.Show("No se pudieron Guardar los pagos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            PagoClientesFolio.GenerarFolio()
            FolioIngreso = PagoClientesFolio.FolioIngreso

            For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1

                If CBool(Me.DgvFacturas.Rows(i).Cells(Me.clmChk.Index).Value) Then
                    'band = True
                    ' Se registra el pago del cliente
                    Me.PagoClientes = New CN.PagosDeClientesClass
                    PagoClientes.Cve_cliente = Me.CmbClientes.SelectedValue
                    PagoClientes.Documento = Me.txtDocumento.Text
                    PagoClientes.Estatus = ClasesNegocio.EstatusChar.VIGENTE
                    PagoClientes.Fecha_ingreso = Me.DtpFechaPago.Value
                    PagoClientes.NoFactura = DgvFacturas.Rows(i).Cells(Me.ClmNoFactura.Index).Value
                    PagoClientes.IdUsuario = Controlador.Sesion.MiUsuario.Usrndx
                    PagoClientes.IdUsurioCancelacion = 0
                    PagoClientes.ImporteChequePos = 0
                    PagoClientes.ImporteFactura = CDbl(DgvFacturas.Rows(i).Cells(Me.clmTotal.Index).Value)
                    PagoClientes.ImporteIngreso = CDbl(DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value)
                    PagoClientes.ImporteNotaCredito = CDbl(DgvFacturas.Rows(i).Cells(Me.clmImporteNotaCredito.Index).Value)
                    PagoClientes.SaldoFactura = CDbl(DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value) - CDbl(DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value) - CDbl(DgvFacturas.Rows(i).Cells(Me.clmImporteNotaCredito.Index).Value)
                    PagoClientes.TipoPago = ClasesNegocio.TipoPagoFactura.EFECTIVO
                    PagoClientes.IdPoliza = Poliza.Codigo
                    PagoClientes.ClienteFactura = DgvFacturas.Rows(i).Cells(Me.clmIdCliente.Index).Value
                    'PagoClientes._FolioIngreso = _Folio
                    PagoClientes.FolioIngreso = FolioIngreso

                    If Not Me.PagoClientes.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        MessageBox.Show("No se pudieron Guardar los pagos, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    Cuenta.SaldoActual += PagoClientes.ImporteIngreso
                    Trans.Add(Cuenta.ObtenerEntidad)
                    Cuenta.ObtenerEntidad.Save()

                    If DgvFacturas.Rows(i).Tag IsNot Nothing Then
                        Dim Factura As CN.FacturasClientesCabClass = CType(DgvFacturas.Rows(i).Tag, CN.FacturasClientesCabClass)

                        'Actualiza el estatus en las notas de credito de la factura
                        If CType(DgvFacturas.Rows(i).Tag, CN.FacturasClientesCabClass).NotasCredito.Count > 0 Then
                            Dim Lista As New List(Of String)
                            Dim NotasCredito As New CC.NotaCreditoCabCollection

                            For Each NotDetalle As EC.NotaCreditoDetEntity In Factura.NotasCredito
                                Lista.Add(NotDetalle.FolNota)
                            Next
                            NotasCredito.GetMulti(New OC.FieldCompareRangePredicate(HC.NotaCreditoCabFields.FolNota, Lista.ToArray))
                            ColeccionNotasCredito.AddRange(NotasCredito)

                            If PagoClientes.SaldoFactura <= 0 Then
                                For Each NotaDetalle As EC.NotaCreditoDetEntity In Factura.NotasCredito
                                    Dim PorAplicar As Boolean = False

                                    For Each NotDet As EC.NotaCreditoDetEntity In Factura.NotasCreditoPorAplicar
                                        If NotDet.FolNota = NotaDetalle.FolNota And NotDet.FolFactura = NotaDetalle.FolFactura Then
                                            PorAplicar = True
                                            Exit For
                                        End If
                                    Next

                                    If Not PorAplicar AndAlso NotaDetalle.Estatus = CN.NotaCreditoEnum.VIGENTE Then
                                        NotaDetalle.Estatus = CN.NotaCreditoEnum.NO_APLICABLE
                                        ColeccionNotasCreditoDetalle.Add(NotaDetalle)
                                    End If
                                Next
                            End If
                        End If

                        If CType(DgvFacturas.Rows(i).Tag, CN.FacturasClientesCabClass).NotasCreditoPorAplicar.Count > 0 Then
                            For Each NotaDetalle As EC.NotaCreditoDetEntity In Factura.NotasCreditoPorAplicar
                                If NotaDetalle.Total <> (NotaDetalle.SubTotal * NotaDetalle.ImpteIva / 100) Then
                                    NotaDetalle.ImpteIva = 0
                                    NotaDetalle.SubTotal = NotaDetalle.Total
                                End If
                                NotaDetalle.FecAplica = Now
                                NotaDetalle.FolPago = PagoClientes.FolioIngreso
                                NotaDetalle.Estatus = CN.NotaCreditoEnum.APLICADA
                                ColeccionNotasCreditoDetalle.Add(NotaDetalle)
                            Next
                        End If
                    End If
                End If
            Next

            For Each Nota As EC.NotaCreditoCabEntity In ColeccionNotasCredito
                Dim Cancelada As Boolean = False
                Dim Vigente As Boolean = False
                Dim Aplicada As Boolean = False

                For Each NotaDetalle As EC.NotaCreditoDetEntity In Nota.NotaCreditoDet
                    Dim PorAplicar As Boolean = False

                    For Each NotDet As EC.NotaCreditoDetEntity In ColeccionNotasCreditoDetalle
                        If NotDet.FolNota = NotaDetalle.FolNota And NotDet.FolFactura = NotaDetalle.FolFactura And CType(NotDet.Estatus, CN.NotaCreditoEnum) = ClasesNegocio.NotaCreditoEnum.APLICADA Then
                            PorAplicar = True
                            Exit For
                        End If
                    Next

                    If PorAplicar OrElse CType(NotaDetalle.Estatus, CN.NotaCreditoEnum) = ClasesNegocio.NotaCreditoEnum.APLICADA Then
                        Aplicada = True
                    ElseIf CType(NotaDetalle.Estatus, CN.NotaCreditoEnum) = ClasesNegocio.NotaCreditoEnum.CANCELADA Then
                        Cancelada = True
                    ElseIf CType(NotaDetalle.Estatus, CN.NotaCreditoEnum) = ClasesNegocio.NotaCreditoEnum.VIGENTE Then
                        Vigente = True
                    End If
                Next

                If Aplicada And (Cancelada Or Vigente) Then
                    Nota.Estatus = CN.NotaCreditoEnum.PARCIALMENTE_APLICADA
                ElseIf Aplicada And Not Cancelada And Not Vigente Then
                    Nota.Estatus = CN.NotaCreditoEnum.APLICADA
                ElseIf Vigente Then
                    If Vigente And PagoClientes.SaldoFactura <= 0 Then
                        Nota.Estatus = CN.NotaCreditoEnum.NO_APLICABLE
                    End If
                End If
            Next
            Trans.Add(ColeccionNotasCredito)
            ColeccionNotasCredito.SaveMulti()
            Trans.Add(ColeccionNotasCreditoDetalle)
            ColeccionNotasCreditoDetalle.SaveMulti()
            Trans.Commit()
            MessageBox.Show("Los Pagos han Sido Guardados con el folio :" & FolioIngreso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cancelar = True
            Nuevo()
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Nuevo()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub CmbCuentas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCuentas.SelectedIndexChanged
        Try
            If Not IsNothing(Me.CmbCuentas.SelectedValue) Then
                Cuenta = CType(Me.CmbCuentas.SelectedItem, CN.CuentaClass)
                Me.txtBanco.Text = Cuenta.Banco.Descripcion
                Me.txtCuentaHabiente.Text = Cuenta.CuentaHabiente
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvFacturas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellDoubleClick
        If e.ColumnIndex = clmImporteNotaCredito.Index Then
            'AplicacionNotasCredito(e.RowIndex, True)
            Sumar()
        End If
    End Sub

    Private Sub DgvFacturas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellEndEdit
        Select Case e.ColumnIndex
            Case Me.clmApagar.Index
                If Me.DgvFacturas.CurrentRow.Cells(Me.clmApagar.Index).Value = "" Or Me.DgvFacturas.CurrentRow.Cells(Me.clmApagar.Index).Value = "0" Then
                    Me.DgvFacturas.CurrentRow.Cells(Me.clmApagar.Index).Value = "$0.00"
                Else
                    Me.DgvFacturas.CurrentRow.Cells(Me.clmChk.Index).Value = True
                End If
                If CDec(Me.DgvFacturas.CurrentRow.Cells(Me.clmApagar.Index).Value) > Me.DgvFacturas.CurrentRow.Cells(Me.clmSaldo.Index).Value Then
                    MessageBox.Show("El pago es mayor al saldo de la factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.DgvFacturas.CurrentRow.Cells(Me.clmApagar.Index).Value = DgvFacturas.Rows(e.RowIndex).Cells(clmSaldo.Index).Value
                End If
                Sumar()
            Case Me.clmChk.Index
                Sumar()
        End Select
    End Sub

    Private Sub DgvFacturas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvFacturas.DataError

    End Sub

    Private Sub txtImporteDetalle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteDetalle.GotFocus
        Try
            If Not Me.txtImporteDetalle.Text = "" Then
                Me.txtImporteDetalle.Text = Me.txtImporteDetalle.Text.Replace("$", "").Replace(".00", "")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtImporteDetalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteDetalle.KeyPress
        Try
            If Not Me.txtImporteDetalle.Text = "" Then
                If (Not IsNumeric(Me.txtImporteDetalle.Text) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = ".") OrElse (e.KeyChar = "." AndAlso Me.txtImporteDetalle.Text.IndexOf(".") > -1) Then
                    e.Handled = True
                End If
            End If
            If e.KeyChar = Chr(13) Then
                Dim Suma As Decimal = 0D
                Dim Resta As Decimal = CDec(Me.txtImporteDetalle.Text)
                If Not CInt(Me.txtImporteDetalle.Text) = 0 Then
                    For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                        Suma += Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
                        If Me.txtImporteDetalle.Text >= Suma Then
                            Me.DgvFacturas.Rows(i).Cells(Me.clmChk.Index).Value = True
                            Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value = Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
                            Resta -= DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
                        Else
                            Me.DgvFacturas.Rows(i).Cells(Me.clmChk.Index).Value = True
                            Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value = Resta
                            Exit For
                        End If
                    Next
                End If
                Sumar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtImporteDetalle_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteDetalle.LostFocus
        Try
            If Not Me.txtImporteDetalle.Text = "" Then
                Me.txtImporteDetalle.Text = CDec(Me.txtImporteDetalle.Text).ToString("C2")
            Else
                Me.txtImporteDetalle.Text = "$0.00"
            End If

            'Dim Suma As Decimal = 0D
            'For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
            '    Suma += Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
            '    If Me.txtImporteDetalle.Text >= Suma Then
            '        Me.DgvFacturas.Rows(i).Cells(Me.clmChk.Index).Value = True
            '        Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value = Me.DgvFacturas.Rows(i).Cells(Me.clmSaldo.Index).Value
            '    Else
            '        Me.DgvFacturas.Rows(i).Cells(Me.clmChk.Index).Value = True
            '        Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value = Me.txtImporteDetalle.Text
            '        Exit For
            '    End If
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvFacturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellContentClick
        Try
            If e.ColumnIndex = Me.clmChk.Index Then
                If CBool(Me.DgvFacturas.Rows(e.RowIndex).Cells(Me.clmChk.Index).Value) Then
                    Me.DgvFacturas.Rows(e.RowIndex).Cells(Me.clmChk.Index).Value = False
                    DgvFacturas.Rows(e.RowIndex).Tag = Nothing
                    DgvFacturas.Rows(e.RowIndex).Cells(clmImporteNotaCredito.Index).Value = 0D
                Else
                    Me.DgvFacturas.Rows(e.RowIndex).Cells(Me.clmChk.Index).Value = True
                    'DgvFacturas.Rows(e.RowIndex).Tag = New CN.FacturasClientesCabClass(DgvFacturas.Rows(e.RowIndex).Cells(clmSerie.Index).Value.ToString(), DgvFacturas.Rows(e.RowIndex).Cells(ClmNoFactura.Index).Value.ToString())
                End If

                'AplicacionNotasCredito(e.RowIndex)
                Sumar()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar Sumar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdAplicarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAplicarNota.Click
        Try
            Dim AplicarNotaCredito As New FrmAplicarNotadeCredito
            Dim Factura As String
            If AplicarNotaCredito.ShowDialog = Windows.Forms.DialogResult.OK Then
                Factura = Trim(AplicarNotaCredito.DgvNotas.CurrentRow.Cells("clmFactura").Value)
                'Factura = AplicarNotaCredito.DgvNotas.SelectedRows(0).DataBoundItem

                For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                    If Trim(Me.DgvFacturas.Rows(i).Cells(Me.ClmNoFactura.Index).Value) = Trim(Factura) Then
                        Me.DgvFacturas.Rows(i).Cells(Me.clmNotaCrédito.Index).Value = AplicarNotaCredito.DgvNotas.CurrentRow.Cells("clmFolio").Value
                        Me.DgvFacturas.Rows(i).Cells(Me.clmImporteNotaCredito.Index).Value = AplicarNotaCredito.DgvNotas.CurrentRow.Cells("clmImporte").Value
                        Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value = Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value - Me.DgvFacturas.Rows(i).Cells(Me.clmImporteNotaCredito.Index).Value
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvFacturas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DgvFacturas.CellFormatting
        If e.ColumnIndex = clmApagar.Index Then
            Dim APagar As String = DgvFacturas.Rows(e.RowIndex).Cells(clmApagar.Index).Value

            If APagar = String.Empty Or APagar = "0" Then
                DgvFacturas.Rows(e.RowIndex).Cells(clmApagar.Index).Value = DgvFacturas.Rows(e.RowIndex).Cells(clmSaldo.Index).Value
            Else
                Dim Resultado As Decimal
                If Decimal.TryParse(APagar, Resultado) Then
                    DgvFacturas.Rows(e.RowIndex).Cells(clmApagar.Index).Value = Resultado.ToString("C2")
                End If
            End If
        End If
    End Sub

#End Region

End Class