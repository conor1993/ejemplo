Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient

Public Class FrmBanCargosDiversos
    Implements InterfaceForm

#Region " Declaraciones "
    Private WithEvents Cargo As CN.ChequeClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.ChequeClass)
    Private Cuentas As New CN.CuentaCollectionClass
    Private CtasCont As New CN.CuentaContableCollectionClass
    Private Cuenta As CN.CuentaClass
    Private chkEstatus As CondicionEnum = CondicionEnum.ACTIVOS
    Private TipoCambio As CN.TipoCambioClass
    Private Buscar As Boolean = False
    Dim distribucionGastosTb As New DataTable
    Dim detalleDistGastosTb As New DataTable
#End Region

    Private Sub FrmBanCargosDiversos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        Me.mtb.Buttons(0).ToolTipText = "Busca los Registros de Dep�sitos Registrados"
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acci�n actual."
        Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Registro de dep�sitos."
        Me.mtb.Buttons(6).ToolTipText = "Guarda el Registro de Dep�sito o los cambios que se le hayan Realizado."
        Me.mtb.Buttons(10).ToolTipText = "Imprime Los resgistros de Dep�sitos Registrados."
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."
        mtb.ToolBarButtonStatus = MtbEstados

        ''Inicializar tabla de Distribucion de gastos y detalle de gastos
        distribucionGastosTb.Columns.Add("rowNumber", GetType(Integer))
        distribucionGastosTb.PrimaryKey = New DataColumn() {distribucionGastosTb.Columns("rowNumber")}
        'distribucionGastosTb.Columns.Add("idPoliza", GetType(Integer))
        distribucionGastosTb.Columns.Add("idSucursal", GetType(Integer))
        distribucionGastosTb.Columns.Add("idMetdProrrateo", GetType(Integer))
        distribucionGastosTb.Columns.Add("idCuentaContable", GetType(Integer))
        distribucionGastosTb.Columns.Add("importe", GetType(Decimal))
        distribucionGastosTb.Columns.Add("ptjImporte", GetType(Decimal))


        detalleDistGastosTb.Columns.Add("rowNumber", GetType(Integer))
        detalleDistGastosTb.Columns.Add("detSucursal", GetType(Integer))
        detalleDistGastosTb.Columns.Add("detMetdProrrateo", GetType(Integer))
        detalleDistGastosTb.Columns.Add("detCuenta", GetType(Integer))
        detalleDistGastosTb.Columns.Add("detCentroCostos", GetType(Integer))
        detalleDistGastosTb.Columns.Add("detPorcentaje", GetType(Decimal))

        mtb.sbCambiarEstadoBotones("Cancelar")
        Cargos.Obtener(ClasesNegocio.BancosMovimientosTipo.CARGO_DIVERSO, chkEstatus)
        RellenarBancos()
        Lectura()
        LimpiarBancos()

    End Sub

#Region " Rellenar "
    Private Sub LimpiarBancos()
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        txtSaldo.Text = "0.00"
        txtImporte.Text = "0.00"
        lv.Items.Clear()
        LimpiarGridCuentas()
    End Sub

    Private Sub RellenarBancos()
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBanco.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBanco.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBanco.AutoCompleteCustomSource.AddRange(Bancos.Listar)
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex > -1 Then
            txtBanco.Text = Me.cmbBanco.SelectedValue
            Dim banco As CN.BancosClass = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            Cuentas.Obtener(banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            RellenarCuentas()
        End If
    End Sub

    Private Sub txtBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBanco.KeyDown, cmbBanco.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBanco_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.TextChanged, txtCuenta.TextChanged, txtSaldo.TextChanged
        cmbBanco.SelectedValue = txtBanco.Text
    End Sub

    Private Sub RellenarCuentas()
        lv.Items.Clear()
        For Each cta As CN.CuentaClass In Cuentas
            Dim lvi As New ListViewItem(cta.Cuenta)
            lvi.Tag = cta
            Dim lvsi As New ListViewItem.ListViewSubItem(lvi, cta.Descripcion)
            Dim lvsi1 As New ListViewItem.ListViewSubItem(lvi, cta.TipoMoneda.DescripcionCorta)
            lvi.SubItems.Add(lvsi)
            lvi.SubItems.Add(lvsi1)
            Me.lv.Items.Add(lvi)
        Next
    End Sub

    Private Sub lv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv.SelectedIndexChanged
        If lv.SelectedItems.Count > 0 Then
            For Each indice As ListViewItem In lv.SelectedItems
                Me.LimpiarGridCuentas()
                Me.txtImporte.Enabled = True
                txtCuenta.Text = String.Format("{0} - {1}", indice.SubItems(0).Text, indice.SubItems(1).Text)
                Cuenta = DirectCast(indice.Tag, CN.CuentaClass)
                If Not IsNothing(Cuenta.CuentaContable) Then
                    'Dim r As C1.Win.C1FlexGrid.Row = fg.Rows.Add
                    'Dim r As New System.Windows.Forms.DataGridViewRow
                    'Me.DgvCuentas.Rows.Add(r)
                    'r.ReadOnly = False
                    '
                    ' Me.DgvCuentas.DataSource = Cuenta.CuentaContable
                    'Cuen = Cuenta
                    RellenarGridCuentas(Cuenta.CuentaContable)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C2")
                    ' txtFolio.Text = Cuenta.FolioActual + 1

                    Dim tc As New CN.TipoCambioCollectionClass
                    If Cuenta.TipoMoneda.Codigo = 0 Then
                        MessageBox.Show("Cuenta bancaria no tiene Tipo de Moneda Asignado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.lv.Refresh()
                        Exit Sub
                    Else
                        If Not Cuenta.TipoMoneda.EsMonedaLocal Then
                            TipoCambio = tc.ObtenerTipoCambio(Cuenta.TipoMoneda, Now.ToString("dd/MM/yyyy"))
                            If IsNothing(TipoCambio) Then
                                If Not Buscar Then
                                    MessageBox.Show("No existe tipo de cambio registrado, no se puede continuar con el registro.", "No hay tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                                    mtb.sbCambiarEstadoBotones("Cancelar")
                                Else
                                    If Not IsNothing(TipoCambio) Then
                                        txtTipoCambio.Text = TipoCambio.TipoCambio
                                    End If
                                End If
                            Else
                                txtTipoCambio.Text = "1.00"
                            End If
                        Else
                            Me.txtTipoCambio.Text = "1.00"
                        End If
                    End If
                Else
                    MessageBox.Show("Esta cuenta no tiene una Cuenta Contable Asociada, no se puede continuar con el registro.", "No hay Cuenta Contable asociada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mtb_ClickCancelar(sender, New ToolBarButtonClickEventArgs(mtb.Buttons(2)), False)
                    mtb.sbCambiarEstadoBotones("Cancelar")
                End If
            Next
        Else
            txtCuenta.Clear()
            Cuenta = Nothing
        End If
        If Not IsNothing(Cargo) Then
            Cargo.Cuenta = Cuenta
            txtImporte.Text = Cargo.Importe.ToString("C2")
        End If
    End Sub
#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        Me.DgvCuentas.Enabled = True
        Me.txtImporte.Enabled = False
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = False
        ' Me.DgvCuentas.Enabled = False
        Me.txtImporte.Enabled = False
        Me.txtCargo.Enabled = False
        Me.txtAbono.Enabled = False
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        LimpiarBancos()
        dtp.Value = Now
        txtImporte.Text = "0.00"
        txtSaldo.Text = "0.00"
        txtConcepto.Clear()
        txtImporteLetra.Clear()
        txtCuenta.Clear()
        ' txtFolio.Clear()
        txtReferencia.Clear()
        txtPoliza.Clear()
        Buscar = False
        chkElectronico.Checked = False
        Me.txtAbono.Text = "0.00"
        Me.txtCargo.Text = "0.00"
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        cmbBanco.SelectedValue = Cargo.Cuenta.Banco.DescripcionCta
        RellenarCuentas()
        For Each item As ListViewItem In lv.Items
            If IsNothing(item.Tag) And IsNothing(Cargo.Cuenta) Then
                item.Selected = True
                txtCuenta.Text = String.Format("{0} - {1}")
                txtSaldo.Text = "0.00".ToString("C2")
            ElseIf Not IsNothing(item.Tag) And Not IsNothing(Cargo.Cuenta) Then
                Dim tmp As CN.CuentaClass = DirectCast(item.Tag, CN.CuentaClass)
                If tmp.Cuenta = Cargo.Cuenta.Cuenta Then
                    item.Selected = True
                    Cuenta = tmp
                    txtCuenta.Text = String.Format("{0} - {1}", item.SubItems(0).Text, item.SubItems(1).Text)
                    txtSaldo.Text = Cuenta.SaldoActual.ToString("C2")
                End If
            End If
        Next
        dtp.Value = Cargo.FechaDocumento
        txtImporte.Text = Cargo.Importe.ToString("C2")
        txtConcepto.Text = Cargo.Concepto
        Select Case Cargo.Medio
            Case ClasesNegocio.BancosMovimientosMedio.CHEQUE
                chkElectronico.Checked = False

            Case ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
                chkElectronico.Checked = True
        End Select
        txtReferencia.Text = Cargo.Folio
        ' txtFolio.Text = Cargo.Folio
        'ojo
        MostrarPolizaFlexGrid(Cargo.Poliza)
    End Sub

    Public Function Validar() As String Implements InterfaceForm.Validar
        Dim Cadena As String = "Faltan los siguientes datos:" & vbCrLf
        Dim Bl As Boolean = False
        If txtBanco.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Banco" & vbCrLf
            Bl = True
        End If
        If txtCuenta.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Cuenta Bancaria" & vbCrLf
            Bl = True
        End If
        If txtImporte.Text = 0 Then
            Cadena &= "* Importe" & vbCrLf
            Bl = True
        End If
        If txtConcepto.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Concepto" & vbCrLf
            Bl = True
        End If
        If chkElectronico.Checked And txtReferencia.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Referencia" & vbCrLf
            Bl = True
        End If
        If Not Bl Then
            Cadena = Nothing
            Cargo.Anticipo = False
            Cargo.Beneficiario = Nothing
            Cargo.Concepto = txtConcepto.Text
            Cargo.Cuenta = Cuenta
            Cargo.FechaDocumento = dtp.Value
            Cargo.Importe = txtImporte.Text
            Cargo.Origen = ClasesNegocio.BancosMovimientosOrigen.BANCOS
            Cargo.Resguardo = SiNoEnum.NO
            Cargo.TipoCambio = txtTipoCambio.Text
            Cargo.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.CARGO_DIVERSO
            'If Cargo.TipoMovimiento = ClasesNegocio.BancosMovimientosTipo.DEPOSITO Then
            '    If Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE Then
            '        Cargo.Folio = txtFolio.Valor
            '    ElseIf Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
            Cargo.Folio = txtReferencia.Text
            'End If
            '    End If
        End If
        Return Cadena
    End Function

#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cancelar = True
        If Cargo.Borrar() Then
            Limpiar()
            Lectura()
        Else
            Cancelar = True
        End If
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        Cargos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Cargo = Nothing
        Lectura()
        Limpiar()
        Cargos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
        Me.txtCargo.Enabled = False
        Me.txtAbono.Enabled = False
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'Escritura()
        MessageBox.Show("No est� habilitada la edici�n para este m�dulo.", "Acci�n no permitida", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Ingresos Depositos")
        Dim TransDet As SqlTransaction
        Try
            Dim SaldoAnterior As Decimal = Cuenta.SaldoActual
            Cancelar = True
            If IsNothing(Validar()) Then
                If VerificarBalance() = 0 Then
                    GenerarPoliza()
                    If Cargo.Guardar(Trans) Then
                        'guardar movimiento en tabla de movimientos bancarios
                        Dim MovBancos As New CN.MovimientosBancosClass
                        MovBancos.NumPoliza = Cargo.Poliza.Codigo
                        MovBancos.CtaBancaria = Cuenta.Codigo
                        MovBancos.SaldoAnterior = SaldoAnterior
                        MovBancos.FechaMov = Me.dtp.Value
                        MovBancos.FechaCaptura = Now
                        MovBancos.Importe = Me.txtImporte.Text 'Me.DgvFacturas.Rows(i).Cells(Me.clmApagar.Index).Value
                        MovBancos.Concepto = Cargo.Poliza.Concepto
                        MovBancos.Cargo_Abono = ClasesNegocio.PolizaOperacionEnum.ABONO
                        MovBancos.TipoCambio = CDec(Me.txtTipoCambio.Text)
                        MovBancos.TipoMov = "R"
                        MovBancos.Origen = "B"
                        MovBancos.CveCancelacion = "N"

                        If Me.chkElectronico.Checked = True Then
                            MovBancos.Referencia = Me.txtReferencia.Text
                        Else
                            MovBancos.Referencia = Me.txtReferencia.Text
                        End If

                        If Not MovBancos.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                            MessageBox.Show("No se pudieron Guardar los ingresos(depositos), Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                        Cuenta.SaldoActual -= MovBancos.Importe
                        Trans.Add(Cuenta.ObtenerEntidad)
                        Cuenta.ObtenerEntidad.Save()

                        ''------------------------------guardar prorrateo---------------------------------------------------------------------------------------------------------------
                        ''--------------------------------------------------------------------------------------------------------------------------------------------------------------
                        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                        Dim errorValue As Integer = 0
                        Dim idGastoDepartamental As Integer = 0

                        sqlCon.Open()

                        TransDet = sqlCon.BeginTransaction(IsolationLevel.ReadCommitted, "DetallesGastos")

                        Dim command As SqlCommand = sqlCon.CreateCommand()
                        command.Connection = sqlCon
                        command.Transaction = TransDet

                        Dim query As String

                        For i As Integer = 0 To distribucionGastosTb.Rows.Count - 1

                            query = "EXEC saveProrrateo 4, 0,       {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, '{11}',{12}"
                            query = String.Format(query,
                                                  "NULL",
                                                  Controlador.Sesion.MiEmpresa.Empndx,
                                                  "NULL",
                                                  "NULL",
                                                  distribucionGastosTb.Rows(i)("idMetdProrrateo"),
                                                  distribucionGastosTb.Rows(i)("idCuentaContable"),
                                                  1,
                                                  Cargo.Poliza.Codigo,
                                                  1,
                                                  CDec(distribucionGastosTb.Rows(i)("importe")),
                                                  100,
                                                  Cargo.Poliza.FechaPoliza.ToString("dd'/'MM'/'yyyy hh:mm:ss"),
                                                  distribucionGastosTb.Rows(i)("rowNumber"))
                            command.CommandText = query
                            ''Leer los valores regresados por el Procedimiento Almacenado
                            Dim readCommand As SqlDataReader = command.ExecuteReader()
                            readCommand.Read()
                            errorValue = CInt(readCommand(0))
                            Dim a As String = CStr(readCommand(1))
                            idGastoDepartamental = CInt(readCommand(2))
                            readCommand.Close()
                            'sqlcom.ExecuteNonQuery()

                            If (errorValue > 0) Then
                                Exit For
                            End If
                            ''Detalle de Distribucion de gastos
                            If Not errorValue > 0 Then
                                Dim ConsultaCompleta As String = ""

                                For j As Integer = 0 To (detalleDistGastosTb.Rows.Count - 1)
                                    If detalleDistGastosTb.Rows(j)("rowNumber") = distribucionGastosTb.Rows(i)("rowNumber") Then

                                        query = "EXEC saveProrrateo 3, {0},       {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, '{12}',{13}"

                                        query = String.Format(query,
                                                              idGastoDepartamental,
                                                              "NULL",
                                                              Controlador.Sesion.MiEmpresa.Empndx,
                                                              "NULL",
                                                              "NULL",
                                                              detalleDistGastosTb.Rows(j)("detMetdProrrateo"),
                                                              detalleDistGastosTb.Rows(j)("detCuenta"),
                                                              1,
                                                              Cargo.Poliza.Codigo,
                                                              detalleDistGastosTb.Rows(j)("detCentroCostos"),
                                                              CDec(1),
                                                              detalleDistGastosTb.Rows(j)("detPorcentaje"),
                                                              Cargo.Poliza.FechaPoliza.ToString("dd'/'MM'/'yyyy hh:mm:ss"),
                                                              "NULL")


                                        command.CommandText = query

                                        Dim readCommands As SqlDataReader = command.ExecuteReader()
                                        readCommands.Read()
                                        errorValue = CInt(readCommands(0))
                                        idGastoDepartamental = CInt(readCommands(2))
                                        readCommands.Close()

                                        If (errorValue > 0) Then
                                            Exit For
                                        End If
                                    End If
                        Next
                            End If
                        Next



                        If errorValue > 0 Then
                            Trans.Rollback()
                            TransDet.Rollback()
                            Cancelar = True
                            sqlCon.Close()
                            MessageBox.Show("Error al guardar los detalles de prorrateo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        ''-----------------------FIN DE GUARDADO DE PRORATE-------------------------------------------------------------------------------------------------------------
                        ''--------------------------------------------------------------------------------------------------------------------------------------------------------------

                        Trans.Commit() ''Se escriben los datos en la tabla, si no ha pasado ningun error
                        TransDet.Commit()
                        sqlCon.Close()
                        MessageBox.Show(String.Format("N�mero de P�liza Generado:{0}{1}", vbCrLf, Cargo.Poliza.NumeroPoliza), "Poliza Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'mtb_ClickImprimir(sender, e, Cancelar)
                        Limpiar()
                        Lectura()
                        Cancelar = False
                    End If
                Else
                    MessageBox.Show("No se puede generar el dep�sito por que no esta cuadrada la p�liza.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
            Cargos.Obtener(ClasesNegocio.BancosMovimientosTipo.DEPOSITO, chkEstatus)
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        Cargo = New ClasesNegocio.ChequeClass
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        Me.txtAbono.Enabled = True
        Me.txtCargo.Enabled = True
        Me.txtConcepto.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        If Not IsNothing(Cargo) Then
            If Not Cargo.Emitido Then
                If Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then
                    PagoElectronico.Cheque = Cargo
                    pDg.Document = PagoElectronico
                    If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Try
                            PagoElectronico.Print()
                            If MessageBox.Show("�Se imprimi� el comprobante?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                PagoElectronico.ImpresionExitosa()
                                Cargo.Guardar()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Else
                    If MessageBox.Show("�Desea imprimir el cheque?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        ImprimirCheque.Cheque = Cargo
                        ImprimirCheque.AbonoEnCuenta = MessageBox.Show("�Es para abono en cuenta?", "Tipo de Cheque", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        pDg.Document = ImprimirCheque
                        If pDg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Try
                                ImprimirCheque.Print()
                                If MessageBox.Show("�Se imprimi� el cheque?", "Confirmaci�n de Impresi�n", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    ImprimirCheque.ImpresionExitosa()
                                    Cargo.Guardar()
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            Else
                If Not Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO Then MessageBox.Show(String.Format("Este cheque ya fue emitido el {0}.", Cargo.FechaEmision.ToString("dd MMM' de 'yyyy"), "Cheque ya emitido", MessageBoxButtons.OK, MessageBoxIcon.Error))
            End If
        End If
    End Sub
#End Region

#Region " Otros "
    Private Sub cheque_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles Cargo.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private Sub chkElectronico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkElectronico.CheckedChanged
        txtReferencia.Visible = chkElectronico.Checked
        lblRef.Visible = chkElectronico.Checked
        If chkElectronico.Checked Then
            Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.ELECTRONICO
        Else
            Cargo.Medio = ClasesNegocio.BancosMovimientosMedio.CHEQUE
            txtReferencia.Clear()
        End If
    End Sub

    Private Sub txtTipoCambio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not bl Then
            bl = True
            txtTipoCambio.Text = txtTipoCambio.Text.ToString("C")
            bl = False
        End If
    End Sub
#End Region

#Region " Importe "
    Private Sub txtImporteLetra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteLetra.GotFocus
        txtConcepto.Focus()
    End Sub

    Private bl As Boolean = False

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                If e.KeyChar = "." Then
                    If txtImporte.Text.Contains(".") OrElse txtImporte.Text = String.Empty Then
                        e.Handled = True
                    ElseIf txtImporte.SelectionStart <= txtImporte.Text.Length - 3 Then
                        e.Handled = True
                    End If
                Else
                    e.Handled = True
                End If
            End If
        Else
            Dim index As Integer = txtImporte.Text.IndexOf(".")

            If index <> -1 Then
                If index = txtImporte.Text.Length - 3 Then
                    If txtImporte.SelectionStart > index AndAlso txtImporte.SelectionLength <> 2 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    'Private Sub txtImporte_TextChanged1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not bl Then
    '        If Not IsNothing(Cargo) Then
    '            Cargo.Importe = txtImporte.Text
    '            txtImporteLetra.Text = Cargo.ImporteLetra.ToUpper
    '            bl = True
    '            'txtImporte.Text = txtImporte.Text.ToString("C")
    '            ValorGridCuentas(0, 6, txtImporte.Text)
    '            bl = False
    '        End If
    '    End If
    'End Sub

    Private Sub txtImporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
        Try
            If Not (Me.txtImporte.Text = "") Then
                If Not bl Then
                    If Not IsNothing(Cargo) Then
                        Cargo.Importe = txtImporte.Text
                        txtImporteLetra.Text = Cargo.ImporteLetra.ToUpper
                        bl = True
                        'txtImporte.Text = txtImporte.Text.ToString("C")
                        ValorGridCuentas(0, 6, txtImporte.Text)
                        bl = False
                    End If
                End If
            Else
                Me.txtImporte.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region


#Region " Grid "

    Private Sub PasarCuenta(ByVal CtaCont As CN.CuentaContableClass, ByVal Renglon As Integer)
        If IsNothing(CtaCont) Then
            'fg.Rows(Renglon).UserData = Nothing
            ValorGridCuentas(Renglon, 4, "")
            ValorGridCuentas(Renglon, 5, 0D)
            ValorGridCuentas(Renglon, 6, 0D)
        Else
            If CtaCont.Bancos = SiNoEnum.NO And CtaCont.Afectable = SiNoEnum.SI Then
                'fg.Rows(Renglon).UserData = CtaCont
                RellenarGridCuentas(CtaCont)
                'fg.FinishEditing()
                'fg.Col = 5
            Else
                Dim sMensaje As String = "No se puede utilizar esta cuenta por que sus propiedades son:" & vbCrLf
                If CtaCont.Bancos = SiNoEnum.SI Then sMensaje &= "* De Bancos" & vbCrLf
                If CtaCont.Afectable = SiNoEnum.NO Then sMensaje &= "* No Afectable" & vbCrLf
                ' fg.Rows(Renglon).UserData = Nothing
                ValorGridCuentas(Renglon, 4, "")
                ValorGridCuentas(Renglon, 5, 0D)
                ValorGridCuentas(Renglon, 6, 0D)
                MessageBox.Show(sMensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'ojoo
    'Private Sub fg_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.AfterEdit
    '    Select Case e.Col
    '        Case 1 To 4
    '            Dim tmp As CN.CuentaContableClass
    '            ValorFlexGrid(e.Row, 1, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 1)))
    '            ValorFlexGrid(e.Row, 2, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 2)))
    '            ValorFlexGrid(e.Row, 3, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 3)))
    '            ValorFlexGrid(e.Row, 4, FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 4)))
    '            tmp = CtasCont.ObtenerCuentaContable(FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 1)), FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 2)), FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 3)), FuncionesClass.PonerCeros(ValorFlexGrid(e.Row, 4)))
    '            PasarCuenta(tmp, e.Row)
    '        Case 5
    '            'Buscar Cuenta Por Nombre
    '            CtasCont.Obtener(Nothing, ValorFlexGrid(e.Row, 5))
    '            Dim tmp As CN.CuentaContableClass
    '            Select Case CtasCont.Count
    '                Case 1
    '                    tmp = CtasCont(0)
    '                Case Is > 1
    '                    SelCuentaContableForm.CuentasContables = CtasCont
    '                    If SelCuentaContableForm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                        tmp = SelCuentaContableForm.CuentaContable
    '                    End If
    '                Case Else
    '            End Select
    '            PasarCuenta(tmp, e.Row)
    '        Case 7
    '            If VerificarBalance() < 0 Then
    '                ValorFlexGrid(e.Row, e.Col, 0)
    '                MessageBox.Show("La suma de los Abonos sobrepasa a la suma de los Cargos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '    End Select
    'End Sub
    '
    'ojooooooooooo
    'Private Sub fg_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.BeforeEdit
    '    If txtImporte.Valor > 0 Then
    '        If e.Row > 0 Then
    '            If IsNothing(fg.Rows(e.Row - 1).UserData) Then
    '                e.Cancel = True
    '            Else
    '                If ValorFlexGrid(e.Row - 1, 6) > 0 Or ValorFlexGrid(e.Row - 1, 7) > 0 Then
    '                    If (VerificarBalance() = 0) And ValorFlexGrid(e.Row, 7) = 0 Then e.Cancel = True
    '                Else
    '                    e.Cancel = True
    '                End If
    '                Select Case e.Col
    '                    Case 1, 2, 3, 4
    '                        'ValorFlexGrid(e.Row, e.Col, QuitarCeros(ValorFlexGrid(e.Row, e.Col)))
    '                End Select
    '            End If
    '        End If
    '    Else
    '        e.Cancel = True
    '        txtImporte.Focus()
    '    End If
    'End Sub

    'Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
    '    Select Case e.KeyCode
    '        Case Keys.Delete
    '            If fg.RowSel > 1 Then fg.Rows.Remove(fg.RowSel)
    '        Case Keys.F3
    '            Dim BuscarCuentas As New BusquedaCuentasContablesForm
    '            BuscarCuentas.BloquearCaracteristicas = True
    '            'ojo
    '            'BuscarCuentas.Bancos = CheckState.Unchecked
    '            'BuscarCuentas.Afectables = CheckState.Checked
    '            If BuscarCuentas.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                If fg.RowSel > 1 Then
    '                    Dim cta As New ClasesNegocio.CuentaContableClass
    '                    cta = BuscarCuentas.CuentaContable
    '                    'ojo
    '                    'RellenarFilaFlexGrid(fg.Rows(fg.RowSel), cta)
    '                    'fg.Col = 7
    '                End If
    '            End If
    '    End Select
    'End Sub
    'ojooo

    Private Sub DgvCuentas_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvCuentas.CellBeginEdit
        If txtImporte.Text > 0 Then
            If e.RowIndex > 0 Then
                If IsNothing(Me.DgvCuentas.Rows(e.RowIndex - 1).Cells("ClmCtaMayor").Value) Then
                    e.Cancel = True
                Else
                    If ValorGridCuentas(e.RowIndex - 1, 5) > 0 Or ValorGridCuentas(e.RowIndex - 1, 6) > 0 Then
                        If (VerificarBalance() = 0) And ValorGridCuentas(e.RowIndex, 5) = 0 Then e.Cancel = True
                    Else
                        e.Cancel = True
                    End If
                    Select Case e.ColumnIndex
                        Case 1, 2, 3, 4
                            'ValorGridCuentas(e.RowIndex, e.ColumnIndex, QuitarCeros(ValorGridCuentas(e.RowIndex, e.ColumnIndex)))
                    End Select
                End If
            End If
        Else
            e.Cancel = True
            txtImporte.Focus()
        End If
    End Sub

    Private Sub DgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellEndEdit
        Select Case e.ColumnIndex
            Case 0 To 3
                Dim tmp As CN.CuentaContableClass
                ValorGridCuentas(e.RowIndex, 0, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 0)))
                ValorGridCuentas(e.RowIndex, 1, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 1)))
                ValorGridCuentas(e.RowIndex, 2, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 2)))
                ValorGridCuentas(e.RowIndex, 3, FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 3)))
                tmp = CtasCont.ObtenerCuentaContable(FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 0)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 1)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 2)), FuncionesClass.PonerCeros(ValorGridCuentas(e.RowIndex, 3)))
                PasarCuenta(tmp, e.RowIndex)
            Case 4
                'Buscar Cuenta Por Nombre
                CtasCont.Obtener(Nothing, ValorGridCuentas(e.RowIndex, 4))
                Dim tmp As CN.CuentaContableClass = Nothing
                Select Case CtasCont.Count
                    Case 0
                        tmp = CtasCont(0)
                    Case Is > 0
                        SelCuentaContableForm.CuentasContables = CtasCont
                        If SelCuentaContableForm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            tmp = SelCuentaContableForm.CuentaContable
                        End If
                    Case Else
                End Select
                PasarCuenta(tmp, e.RowIndex)
            Case 5
                If VerificarBalance() < 0 Then
                    ValorGridCuentas(e.RowIndex, e.ColumnIndex, 0)
                    MessageBox.Show("La suma de los Cargos sobrepasa a la suma de los Abonos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select

        ''----------------------------------------------------------------------------------------------------------------------------------------------------------
        ''en esta parte iniciamos el prorrateo ---------------------------------------------------------------------------------------------------------------------

        Dim Cuenta As New CN.CuentaContableClass
        Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.IdCuentaContable.Index).Value)
        Dim Ventana As New frmDistribuciondeGastos
        frmDistribuciondeGastos.valor = If(e.ColumnIndex = Me.ClmCargo.Index, Me.DgvCuentas.CurrentRow.Cells(Me.ClmCargo.Index).Value(),
                                                Me.DgvCuentas.CurrentRow.Cells(Me.ClmAbono.Index).Value())

        If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI And (e.ColumnIndex = ClmAbono.Index Or e.ColumnIndex = ClmCargo.Index) Then
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then

                For i As Integer = 0 To (Ventana.dgvMetodos.Rows.Count - 2)
                    If distribucionGastosTb.Rows.Count Then

                        ''Checar si la fila actual ya existe en el DataTable, si ya existe removerla de ambas tablas
                        For j As Integer = distribucionGastosTb.Rows.Count - 1 To 0 Step -1
                            If distribucionGastosTb.Rows(j)("rowNumber") = Me.DgvCuentas.CurrentRow.Index Then
                                For k As Integer = detalleDistGastosTb.Rows.Count - 1 To 0 Step -1
                                    If detalleDistGastosTb.Rows(k)("rowNumber") = Me.DgvCuentas.CurrentRow.Index Then
                                        detalleDistGastosTb.Rows(k).Delete()
                                    End If
                                Next
                                distribucionGastosTb.Rows(j).Delete()
                            End If
                        Next
                    End If
                    ''Aqui se agregan los datos de la Distribucion de gastos al DataTable 'distribucionGastosTb'
                    distribucionGastosTb.Rows.Add(
                        Me.DgvCuentas.CurrentRow.Index,
                        Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmSucursal.Index).Value,
                        Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmMetodoProrrateo.Index).Value,
                        Me.DgvCuentas.CurrentRow.Cells(Me.IdCuentaContable.Index).Value,
                        Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmImporte.Index).Value,
                        Ventana.txtPorcentaje.Text)
                    '' e.RowIndex
                    'If (dgvdistribuciongastosdet.Rows.Count) >= 1 Then
                    '    rendet = dgvdistribuciongastosdet.Rows.Count
                    'End If

                    For j As Integer = 0 To Ventana.dgvDetalledeProrrateo.Rows.Count - 1

                        ''Aqui se agregan los detalles de la Distribucion de gastos al DataTable 'detalleDistGastosTb'
                        detalleDistGastosTb.Rows.Add(Me.DgvCuentas.CurrentRow.Index, Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmSucursal.Index).Value,
                            Ventana.dgvMetodos.CurrentRow.Cells(Ventana.clmMetodoProrrateo.Index).Value, Me.DgvCuentas.CurrentRow.Cells(Me.IdCuentaContable.Index).Value,
                            Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.Cve_Depto.Index).Value, Ventana.dgvDetalledeProrrateo.Rows(j).Cells(Ventana.clmPorcentaje.Index).Value)
                    Next
                Next
            End If
        End If

        ''------------------------------------------------------------------------------------------------------------------------------------------------------------
        ''------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Function ValorGridCuentas(ByVal Renglon As Integer, ByVal Columna As Integer, Optional ByVal Valor As Object = Nothing) As Object
        If Me.DgvCuentas.Rows.Count > 0 Then
            If Not IsNothing(Valor) Then
                Me.DgvCuentas.Rows(Renglon).Cells(Columna).Value = Valor
            Else
                Return Me.DgvCuentas.Rows(Renglon).Cells(Columna).Value
            End If
        End If
        Return Nothing
    End Function

    Private Function VerificarBalance() As Decimal
        Dim Cargos As Decimal = 0
        Dim Abonos As Decimal = 0
        For Each r As System.Windows.Forms.DataGridViewRow In Me.DgvCuentas.Rows
            If r.Index > -1 Then
                Cargos += r.Cells("ClmCargo").Value
                Abonos += r.Cells("ClmAbono").Value
            End If
        Next
        txtAbono.Text = Abonos.ToString("C2")
        txtCargo.Text = Cargos.ToString("C2")
        Return Abonos - Cargos
    End Function

    Private Sub LimpiarGridCuentas()
        Me.DgvCuentas.Rows.Clear()
        'fg.Rows.RemoveRange(1, fg.Rows.Count - 1)
    End Sub

    Private Sub RellenarGridCuentas(ByVal Cta As ClasesNegocio.CuentaContableClass)
        Try
            Dim i As Integer = Me.DgvCuentas.Rows.Count
            If i <> 0 Then
                If Not Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = "" Then
                    Me.DgvCuentas.Rows.Add()
                    Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                    Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = Cta.SubCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                    Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = 0
                    Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = 0
                    Me.DgvCuentas.Rows(i).Cells("IdCuentaContable").Value = Cta.Codigo
                    Me.DgvCuentas.Rows.Add()
                Else
                    Me.DgvCuentas.Rows(i - 1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
                    Me.DgvCuentas.Rows(i - 1).Cells("ClmSubCta").Value = Cta.SubCuenta
                    Me.DgvCuentas.Rows(i - 1).Cells("ClmSsbCta").Value = Cta.SSubCuenta
                    Me.DgvCuentas.Rows(i - 1).Cells("ClmSssCta").Value = Cta.SSSubCuenta
                    Me.DgvCuentas.Rows(i - 1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
                    Me.DgvCuentas.Rows(i - 1).Cells("ClmCargo").Value = 0
                    Me.DgvCuentas.Rows(i - 1).Cells("ClmAbono").Value = 0
                    Me.DgvCuentas.Rows(i - 1).Cells("IdCuentaContable").Value = Cta.Codigo
                    Me.DgvCuentas.Rows.Add()
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
                Me.DgvCuentas.Rows(i).Cells("IdCuentaContable").Value = Cta.Codigo
                Me.DgvCuentas.Rows.Add()
            End If


            If Me.DgvCuentas.Rows.Count > 1 Then
                ' For j As Integer = 0 To Me.DgvCuentas.Columns.Count - 3
                Me.DgvCuentas.Rows(0).ReadOnly = True
                Me.DgvCuentas.Rows(1).ReadOnly = False
                'Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GenerarPoliza()
        Cargo.Poliza = Nothing
        Dim Empresa As New CN.EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
        Dim Poliza As New CN.PolizaClass
        Poliza.Concepto = txtConcepto.Text
        Poliza.Empresa = Empresa
        Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
        Poliza.FechaCaptura = Now
        Poliza.FechaPoliza = Now
        Poliza.Importe = txtImporte.Text
        Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.BANCOS
        Poliza.TipoCambio = txtTipoCambio.Text
        Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.EGRESO
        Poliza.TipoError = 0
        For Each r As System.Windows.Forms.DataGridViewRow In Me.DgvCuentas.Rows
            If r.Index > -1 Then
                'If ValorFlexGrid(r.Index, 6) > 0 Then
                If Me.DgvCuentas.Rows(r.Index).Cells("ClmCargo").Value > 0 Then
                    Dim polizaDet As New CN.PolizaDetalleClass
                    Dim CuenCont As New CN.CuentaContableCollectionClass
                    'Se obtiene la Cuenta contable ya qe como fue enlazada al dgv manualmente no acepta el databounditem
                    'polizaDet.CuentaContable = r.DataBoundItem
                    CuenCont.Obtener(, , r.Cells("ClmCtaMayor").Value, r.Cells("ClmSubCta").Value, r.Cells("ClmSsbCta").Value, r.Cells("ClmSssCta").Value)
                    If CuenCont.Count = 1 Then
                        polizaDet.CuentaContable = CuenCont(0)
                    End If
                    '  polizaDet.Importe = ValorFlexGrid(r.Index, 6)
                    polizaDet.Importe = Me.DgvCuentas.Rows(r.Index).Cells("ClmCargo").Value
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                    polizaDet.Posicion = r.Index
                    polizaDet.Concepto = Me.txtConcepto.Text
                    Poliza.AgregarDetalle(polizaDet)
                    'ElseIf ValorFlexGrid(r.Index, 7) > 0 Then
                ElseIf Me.DgvCuentas.Rows(r.Index).Cells("ClmAbono").Value > 0 Then
                    Dim polizaDet As New CN.PolizaDetalleClass
                    Dim CuenCont As New CN.CuentaContableCollectionClass
                    'Se obtiene la Cuenta contable ya qe como fue enlazada al dgv manualmente no acepta el databounditem
                    'polizaDet.CuentaContable = r.DataBoundItem
                    CuenCont.Obtener(, , r.Cells("ClmCtaMayor").Value, r.Cells("ClmSubCta").Value, r.Cells("ClmSsbCta").Value, r.Cells("ClmSssCta").Value)
                    If CuenCont.Count = 1 Then
                        polizaDet.CuentaContable = CuenCont(0)
                    End If
                    polizaDet.Importe = Me.DgvCuentas.Rows(r.Index).Cells("ClmAbono").Value
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                    polizaDet.Posicion = r.Index
                    polizaDet.Concepto = Me.txtConcepto.Text
                    Poliza.AgregarDetalle(polizaDet)
                End If
            End If
        Next
        Cargo.Poliza = Poliza
    End Sub

    Private Sub RellenarGridCtasProveedor(ByVal Cta As ClasesNegocio.CuentaContableClass)
        For i As Integer = Me.DgvCuentas.Rows.Count - 1 To 1 Step -1
            Me.DgvCuentas.Rows.RemoveAt(i)
        Next
        If Me.DgvCuentas.Rows.Count = 1 Then
            Me.DgvCuentas.Rows.Add()
            Me.DgvCuentas.Rows(1).Cells("ClmCtaMayor").Value = Cta.CuentaMayor
            Me.DgvCuentas.Rows(1).Cells("ClmSubCta").Value = Cta.SubCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmSsbCta").Value = Cta.SSubCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmSssCta").Value = Cta.SSSubCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmDescripcion").Value = Cta.NombreCuenta
            Me.DgvCuentas.Rows(1).Cells("ClmCargo").Value = 0
            Me.DgvCuentas.Rows(1).Cells("ClmAbono").Value = 0
        Else
            MsgBox("Seleccione la cuenta Bancaria", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub MostrarPolizaFlexGrid(ByVal Poliza As CN.PolizaClass)
        'LimpiarGridCuentas()
        'For i As Integer = 0 To Poliza.Detalles.Count - 1
        '    'Me.DgvCuentas.Rows.Add()
        '    If i > 0 Then
        '        Me.RellenarGridCtasProveedor(Poliza.Detalles(i).CuentaContable)
        '    Else
        '        RellenarGridCuentas(Poliza.Detalles(i).CuentaContable)
        '    End If
        '    If Poliza.Detalles(i).Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO Then
        '        Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = Poliza.Detalles(i).Importe.ToString("C2")
        '    Else
        '        Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = Poliza.Detalles(i).Importe.ToString("C2")
        '    End If
        'Next
        txtPoliza.Text = Poliza.NumeroPoliza
    End Sub
#End Region

    Private Sub txtCargo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not bl Then
            bl = True
            txtCargo.Text = txtCargo.Text.ToString("C2")
            bl = False
        End If
    End Sub

    Private Sub txtAbono_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not bl Then
            bl = True
            txtAbono.Text = txtAbono.Text.ToString("C2")
            bl = False
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Dim BuscarCheques As New BuscarChequeForm
        BuscarCheques.Icon = Me.Icon
        BuscarCheques.BloquearTiposMovimiento = True
        BuscarCheques.TipoMovimientos = ClasesNegocio.BancosMovimientosTipo.CARGO_DIVERSO
        Buscar = True
        If BuscarCheques.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cargo = BuscarCheques.Cheque
            Mostrar()
            LimpiarGridCuentas()
            RellenarCuentasstore(Cargo.IdPoliza)

        End If
    End Sub

    Private Sub DgvCuentas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellValueChanged
        If Me.txtImporte.Text <> "" Then
            If txtImporte.Text > 0 Then
                ' If e.RowIndex > -1 Then
                If IsNothing(Me.DgvCuentas.Rows(e.RowIndex).Cells("ClmCtaMayor").Value) Then
                    Exit Sub
                Else
                    If ValorGridCuentas(e.RowIndex, 5) > 0 Or ValorGridCuentas(e.RowIndex, 6) > 0 Then
                        If (VerificarBalance() = 0) And ValorGridCuentas(e.RowIndex, 5) = 0 Then Exit Sub
                    Else
                        Exit Sub
                    End If
                    Select Case e.ColumnIndex
                        Case 1, 2, 3, 4
                            'ValorGridCuentas(e.RowIndex, e.ColumnIndex, QuitarCeros(ValorGridCuentas(e.RowIndex, e.ColumnIndex)))
                    End Select
                End If
            Else
                Me.txtAbono.Text = "0.00"
            End If
            'Else
            'Exit Sub
            'txtImporte.Focus()
            'End If
        End If
    End Sub

    Private Sub DgvCuentas_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvCuentas.KeyDown
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
            If Me.DgvCuentas.Rows.Count > 1 Then
                If Me.DgvCuentas.CurrentRow.Index = 0 Then
                    Exit Sub
                End If
                If MessageBox.Show("�Esta seguro de eliminar el registro?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    Me.DgvCuentas.Rows.Remove(Me.DgvCuentas.CurrentRow)
                    If VerificarBalance() < 0 Then
                        MessageBox.Show("La suma de los Cargos sobrepasa a la suma de los Abonos.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RellenarCuentasstore(idpoliza As Integer)
        Try
            Dim i As Integer = 0
            Dim datos As New DataSet
            Dim query = "EXEC  ConsultaProrrateo {0}"
            query = String.Format(query, idpoliza)
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(datos)
            End Using
            LimpiarGridCuentas()
            For Each row As DataRow In datos.Tables(0).Rows
                Me.DgvCuentas.Rows.Add()
                Me.DgvCuentas.Rows(i).Cells("ClmCtaMayor").Value = row("Cta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSubCta").Value = row("SubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSsbCta").Value = row("SSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmSssCta").Value = row("SSSubCta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmDescripcion").Value = row("NomCuenta").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmCargo").Value = row("Cargo").ToString()
                Me.DgvCuentas.Rows(i).Cells("ClmAbono").Value = row("Abono").ToString()

                Me.DgvCuentas.Rows(i).Cells("IdCuentaContable").Value = row("IdCuentaContable").ToString()
                Me.DgvCuentas.Rows(i).Cells("posicion").Value = row("Posicion").ToString()

                i = i + 1
            Next

        Catch ex As Exception

        End Try

    End Sub


    Private Sub DgvCuentas_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCuentas.CellContentDoubleClick
        Try
            If Buscar Then
                Dim Cuenta As New CN.CuentaContableClass
                Cuenta.Obtener(Me.DgvCuentas.CurrentRow.Cells(Me.IdCuentaContable.Index).Value)
                If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                    Dim Ventana As New frmDistribuciondeGastosconsulta
                    frmDistribuciondeGastosconsulta.idpoliza = Me.Cargo.IdPoliza
                    'frmDistribuciondeGastosconsulta.idcuentacontable = Me.dgvPoliza.CurrentRow.Cells(Me.clmIdCuentaContable.Index).Value
                    frmDistribuciondeGastosconsulta.posicion = Me.DgvCuentas.CurrentRow.Cells(Me.posicion.Index).Value
                    If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class