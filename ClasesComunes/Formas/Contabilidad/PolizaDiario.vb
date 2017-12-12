Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class PolizaDiario
    Dim Poliza As CN.PolizaClass
    Dim RegistrosDetalle As Integer = 0
    'Dim EstadoForma As String = "Nuevo"
    Private Sub PolizaDiario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.lblEmpresa.Text = Controlador.Sesion.MiEmpresa.Empnom
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101101"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100001"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        Me.mtb.Buttons(0).ToolTipText = ""
        Me.mtb.Buttons(2).ToolTipText = ""
        Me.mtb.Buttons(3).ToolTipText = ""
        Me.mtb.Buttons(5).ToolTipText = ""
        Me.mtb.Buttons(6).ToolTipText = ""
        'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del Banco."
        'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Banco."
        Me.mtb.Buttons(10).ToolTipText = ""
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

        mtb.sbCambiarEstadoBotones("Cancelar")
        'Me.gridDetalle.RowCount = 0
        Me.dgvPoliza.Enabled = False
        Me.txtConcepto.Enabled = False
        Limpiar()
        'rbDiario.Checked = True
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelar Poliza")
        Try
            If Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.CANCELADA Then
                MessageBox.Show("No se puede cancelar la poliza, debido a que ya se encuentra cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            If MessageBox.Show("¿Esta seguro de cancelar la poliza?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.CANCELADA
            If Not Poliza.Guardar2(Trans) Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudo generar la poliza de cancelación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim PolizaAux As New CN.PolizaClass
            PolizaAux.EmpresaId = Poliza.EmpresaId
            PolizaAux.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
            PolizaAux.FechaCaptura = Now
            PolizaAux.FechaPoliza = Now
            PolizaAux.Importe = Poliza.Importe
            PolizaAux.Origen = ClasesNegocio.PolizaOrigenEnum.CONTABILIDAD
            PolizaAux.TipoError = ClasesNegocio.ErroresPolizaEnum.NINGUNO
            PolizaAux.TipoCambio = 1
            PolizaAux.Referencia = Poliza.Codigo
            PolizaAux.Mes = Now.Month
            PolizaAux.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            PolizaAux.Concepto = "Cancelacion de la Poliza: " & Poliza.Codigo

            For Each polDet As CN.PolizaDetalleClass In Poliza.Detalles2
                Dim Det As New CN.PolizaDetalleClass
                Det.Posicion = polDet.Posicion
                Det.CuentaContable = polDet.CuentaContable
                Det.Importe = polDet.Importe

                If polDet.Operacion2 = CN.PolizaOperacionEnum2.C Then
                    Det.Operacion2 = CN.PolizaOperacionEnum2.A
                Else
                    Det.Operacion2 = CN.PolizaOperacionEnum2.C
                End If
                PolizaAux.Detalles2.Add(Det)
            Next

            If Not PolizaAux.Guardar2(Trans) Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudo generar la poliza de cancelación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
                Exit Sub
            End If

            Trans.Commit()
            MessageBox.Show("La Poliza ha sido cancelada", "¡Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            Me.txtConcepto.Enabled = False
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New FrmBusquedaPolizas
            Ventana.Icon = Me.Icon
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim CodPoliza As Integer = Ventana.DgvPolizas.SelectedRows(0).Cells(Ventana.clmCodigo.Index).Value
                Poliza = New CN.PolizaClass(CodPoliza)

                Me.lblEstatus.Text = Poliza.Estatus.ToString
                Me.lblEstatus.Visible = True
                Me.txtConcepto.Text = Poliza.Concepto
                Me.txtPoliza.Text = Poliza.NumeroPoliza
                'Me.lblEmpresa.Text = Controlador.Sesion.MiEmpresa.Empnom
                Me.txtImporte.Text = Poliza.Importe
                Me.DtpFecha.Value = Poliza.FechaPoliza

                dgvPoliza.AutoGenerateColumns = False
                dgvPoliza.DataSource = Poliza.Detalles2
                ObtenerTotal()
                Me.txtConcepto.Enabled = False
            Else
                Cancelar = True
            End If

            'If EstadoForma = "Buscando" And Me.txtPoliza.Text <> "" Then
            '    'Obtener los detalles de la Póliza
            '    Dim strConsulta As String
            '    Dim dsPolizasDetalle As DataSet

            '    'strConsulta = "Select c.cta + ' ' + subcta + ' ' + ssubcta + ' ' + sssubcta as [Cuenta Contable], c.nomcuenta as Descripcion, " & _
            '    '              "[Importe Cargo]= case p.OperacionCA when 'C' then p.importe else 0	end, " & _
            '    '              "[Importe Abono]= case p.OperacionCA when 'A' then p.importe	else 0	end " & _
            '    '              "from UsrContPolizasdetalle p  " & _
            '    '              "inner join UsrContCuentas c on c.codigo=p.polizaID  " & _
            '    '              "where polizaid = " & Poliza

            '    strConsulta = "Select c.cta as Cuenta,SubCta,SSubCta,SSSubCta, c.nomcuenta as CuentaContable, p.OperacionCA as CA, p.importe, p.posicion, p.cuentacontableid " & _
            '                  "from UsrContPolizasdetalle p  inner join UsrContCuentas c on c.codigo=p.polizaID  where polizaid = " & Poliza

            '    dsPolizasDetalle = Utilerias.EjecutarSQL(strConsulta, "Polizas", Utilerias.ConexionSQL)
            '    If dsPolizasDetalle.Tables.Count > 0 Then
            '        Me.grid.Visible = True
            '        Me.grid.DataSource = dsPolizasDetalle.Tables(0)
            '        'FormatoGrid()
            '        Me.grid.Columns("Posicion").Visible = False
            '        Me.grid.Columns("CuentaContableID").Visible = False
            '    End If
            '    'FormatoGrid()
            '    '  Me.gridDetalle.Refresh()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub FormatoGrid()
    'Mostrar Ocultar Columnas del Grid
    'Me.gridDetalle.Columns("Cta").Visible = False
    'Me.gridDetalle.Columns("SubCta").Visible = False
    'Me.gridDetalle.Columns("SsubCTa").Visible = False
    'Me.gridDetalle.Columns("SSSubcta").Visible = False
    'Me.gridDetalle.Columns("NombreCta").Visible = False
    'Me.gridDetalle.Columns("OperacionCA").Visible = False
    'Me.gridDetalle.Columns("Importe").Visible = False
    'Me.gridDetalle.Columns("Posicion").Visible = False

    ''Modificar el Texto del Encabezado que se muestra de las Columnas
    'Me.gridDetalle.Columns("FechaPoliza").HeaderText = "Fecha"
    'Me.gridDetalle.Columns("NumeroPoliza").HeaderText = "Poliza"
    'Me.gridDetalle.Columns("Importe").HeaderText = "Importe"
    'Me.gridDetalle.Columns("Concepto").HeaderText = "Concepto"

    ''Modificar el ancho de las columnas
    'Me.gridDetalle.Columns("FechaPoliza").Width = 100
    'Me.gridDetalle.Columns("NumeroPoliza").Width = 100
    'Me.gridDetalle.Columns("Importe").Width = 100
    'Me.gridDetalle.Columns("Concepto").Width = 150

    ''Formato del grid y sus columnas
    ''   para los valores nulos
    'Me.gridDetalle.DefaultCellStyle.NullValue = "Sin datos"
    ''   para habilitar el ajuste automático de líneas en celdas basadas en texto
    'Me.gridDetalle.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    'Me.gridDetalle.Columns("FechaPoliza").DefaultCellStyle.Format = "d"
    'Me.gridDetalle.Columns("Importe").DefaultCellStyle.Format = "c"

    ''para alineacion de las columnas
    'Me.gridDetalle.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


    'End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        mtb.sbCambiarEstadoBotones("Cancelar")
        Limpiar()
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            If Me.Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.CANCELADA Then
                MessageBox.Show("No se puede Editar la poliza por que esta cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            Me.txtConcepto.Enabled = True
            Me.dgvPoliza.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        'Iniciar transaccion
        If Not Me.Validate() Then
            Exit Sub
        End If

        Dim Trans As New Integralab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Poliza")
        Try
            If txtConcepto.Text = "" Then
                MessageBox.Show("Introduzca el concepto de la poliza", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            Poliza.Concepto = Me.txtConcepto.Text
            Poliza.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            Poliza.FechaCaptura = Now
            Poliza.FechaPoliza = Me.DtpFecha.Value
            Poliza.Importe = Me.txtImporte.Text
            Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.CONTABILIDAD
            Poliza.TipoCambio = 1
            If rbDiario.Checked Then
                Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
            ElseIf rbIngreso.Checked Then
                Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.INGRESO
            Else
                Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.EGRESO
            End If

            'Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
            Poliza.TipoError = ClasesNegocio.ErroresPolizaEnum.NINGUNO

            If Me.txtTotalCargo.Text <> Me.txtTotalAbono.Text Then
                If MessageBox.Show("¡La Poliza esta Descuadrada!, ¿Aun asi desea Guardarla?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Cancelar = True
                    Exit Sub
                End If
                Poliza.TipoError = ClasesNegocio.ErroresPolizaEnum.POLIZA_DESCUADRADA
            End If

            For i As Integer = 0 To dgvPoliza.Rows.Count - 2
                Poliza.Detalles2(i).Posicion = i + 1
            Next

            If Poliza.Detalles2.Count = 0 Then
                Poliza.TipoError = ClasesNegocio.ErroresPolizaEnum.NO_SE_ENCONTRO_EL_DETALLE_DE_LA_POLIZA
            End If

            If dgvPoliza.Rows.Count = Poliza.Detalles2.Count Then
                Poliza.Detalles2.RemoveAt(Poliza.Detalles2.Count - 1)
            End If

            If Not Poliza.Guardar2(Trans) Then
                Trans.Rollback()
                Cancelar = True
            Else
                'codigo para guardar los gastos
                For i As Integer = 0 To Me.dgvDistribuciondeGastos.Rows.Count - 1
                    If Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmImporte.Index).Value = 0 Then
                        Exit For
                    End If
                    Dim Gastos As New CN.GastosDepartamentosClass
                    Gastos.IdCuentaContable = Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmCuentaContable.Index).Value
                    Gastos.IdSucursal = Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmSucursal.Index).Value
                    Gastos.IdMetodoProrrateo = Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmMetodoProrrateo.Index).Value
                    Gastos.Importe = Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmImporte.Index).Value
                    Gastos.IdPoliza = Poliza.Codigo
                    If Not Gastos.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                    End If
                Next
                Trans.Commit()
                MessageBox.Show("La Póliza ha sido grabada con el folio " & Poliza.NumeroPoliza, "¡Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Me.txtConcepto.Enabled = False
            End If
           

        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerNumPoliza() As Integer
        Dim dt As DataTable = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.Generarfoliopoliza(Controlador.Sesion.MiEmpresa.Empndx, "D", Me.DtpFecha.Value.Month)
        If dt.Rows.Count > 0 Then
            ObtenerNumPoliza = dt.Rows(0)(0) + 1
        Else
            ObtenerNumPoliza = 1
        End If
        Return ObtenerNumPoliza
    End Function

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.txtConcepto.Text = ""
        Me.txtImporte.Text = ""
        Me.txtPoliza.Text = ""
        Me.txtTotalAbono.Text = 0D
        Me.txtTotalCargo.Text = 0D
        Me.dgvPoliza.DataSource = Nothing
        Me.lblEstatus.Visible = False
        rbDiario.Checked = True
    End Sub


    Private Sub ObtenerTotal()
        Try
            Me.txtTotalCargo.Text = 0
            Me.txtTotalAbono.Text = 0
            Dim Enc As Boolean = False
            For i As Integer = 0 To Me.dgvPoliza.Rows.Count - 2
                If Not Me.dgvPoliza.Rows(i).Cells(Me.AbonoDataGridViewTextBoxColumn.Index).Value = 0 Then
                    Me.txtTotalAbono.Text = CDec(txtTotalAbono.Text + Me.dgvPoliza.Rows(i).Cells(Me.AbonoDataGridViewTextBoxColumn.Index).Value).ToString("C2")
                End If
                If Not Me.dgvPoliza.Rows(i).Cells(Me.CargoDataGridViewTextBoxColumn.Index).Value = 0 Then
                    Me.txtTotalCargo.Text = CDec(txtTotalCargo.Text + Me.dgvPoliza.Rows(i).Cells(Me.CargoDataGridViewTextBoxColumn.Index).Value).ToString("C2")
                End If
                Enc = True
            Next

            If CDec(Me.txtTotalAbono.Text) <> CDec(Me.txtTotalCargo.Text) Then
                Me.txtImporte.Text = "$0.00"
            Else
                Me.txtImporte.Text = Me.txtTotalCargo.Text
            End If

            If Not Me.txtTotalAbono.Text = "" And Not Me.txtTotalCargo.Text = "" Then
                Me.txtDiferencia.Text = CDec(Me.txtTotalCargo.Text - Me.txtTotalAbono.Text).ToString("C2")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        mtb.sbCambiarEstadoBotones("Nuevo")
        Me.GroupBox1.Enabled = True
        Me.txtConcepto.Enabled = True
        Me.txtConcepto.Focus()
        Me.DtpFecha.Value = Now.Date
        RegistrosDetalle = 0
        Limpiar()
        'Me.lblEstatus.Visible = True
        Poliza = New CN.PolizaClass
        Me.dgvPoliza.DataSource = Poliza.Detalles2
        Me.dgvPoliza.Enabled = True
        Me.NombreCtaDataGridViewTextBoxColumn.ReadOnly = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub LimpiarControlesCuenta()
        Me.txtConcepto.Text = ""
        Me.txtPoliza.Text = ""
        Me.txtImporte.Text = ""
    End Sub

    Private Sub txtConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto.KeyPress
        If e.KeyChar = Chr(13) Then

            Me.txtImporte.Focus()

        End If
    End Sub

    Private Sub grid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPoliza.CellEndEdit
        Try
            Me.dgvPoliza.Refresh()
            Select Case e.ColumnIndex
                Case Me.CargoDataGridViewTextBoxColumn.Index
                    'verificar si es cuenta de gastos 
                    'Dim Cuenta As CN.CuentaContableClass = CType(Me.dgvPoliza.CurrentRow.DataBoundItem, CN.CuentaContableClass)
                    Dim Cuenta As New CN.CuentaContableClass
                    Cuenta.Obtener(Me.dgvPoliza.CurrentRow.Cells(Me.clmIdCuentaContable.Index).Value)
                    If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                        Dim Ventana As New frmDistribuciondeGastos
                        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Me.dgvDistribuciondeGastos.AutoGenerateColumns = False
                            For i As Integer = 0 To Ventana.dgvMetodos.Rows.Count - 1
                                Me.dgvDistribuciondeGastos.Rows.Add()
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmCuentaContable.Index).Value = Me.dgvPoliza.CurrentRow.Cells(Me.clmIdCuentaContable.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmSucursal.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmSucursal.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmMetodoProrrateo.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmImporte.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmImporte.Index).Value
                            Next
                        End If
                    End If
                    ObtenerTotal()
                Case Me.AbonoDataGridViewTextBoxColumn.Index
                    'verificar si es cuenta de gastos 
                    Dim Cuenta As New CN.CuentaContableClass
                    Cuenta.Obtener(Me.dgvPoliza.CurrentRow.Cells(Me.clmIdCuentaContable.Index).Value)
                    If Cuenta.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                        Dim Ventana As New frmDistribuciondeGastos
                        If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                            Me.dgvDistribuciondeGastos.AutoGenerateColumns = False
                            For i As Integer = 0 To Ventana.dgvMetodos.Rows.Count - 1
                                Me.dgvDistribuciondeGastos.Rows.Add()
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmCuentaContable.Index).Value = Me.dgvPoliza.CurrentRow.Cells(Me.clmCuentaContablePri.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmSucursal.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmSucursal.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmMetodoProrrateo.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmMetodoProrrateo.Index).Value
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmImporte.Index).Value = Ventana.dgvMetodos.Rows(i).Cells(Ventana.clmImporte.Index).Value
                            Next
                        End If
                    End If
                    ObtenerTotal()
                Case Me.CtaDataGridViewTextBoxColumn.Index
                    Dim Cta As New CN.CuentaContableCollectionClass
                    dgvPoliza.CurrentRow.Cells(SCtaDataGridViewTextBoxColumn.Index).Value = "0000"
                    dgvPoliza.CurrentRow.Cells(SSCtaDataGridViewTextBoxColumn.Index).Value = "0000"
                    dgvPoliza.CurrentRow.Cells(SSSCtaDataGridViewTextBoxColumn.Index).Value = "0000"
                    Cta.Obtener(Nothing, "", dgvPoliza.CurrentRow.Cells(CtaDataGridViewTextBoxColumn.Index).Value.ToString(), "0000", "0000", "0000")
                    If Cta.Count > 0 Then
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = Cta(0).NombreCuenta.ToString()
                    Else
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = ""
                        MessageBox.Show("Cuenta no existe.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    'dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = IIf(Cta.Count > 0, Cta(0).NombreCuenta.ToString(), "")
                    'If dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value.Equals("") Then MessageBox.Show("Cuenta no existe.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case Me.SCtaDataGridViewTextBoxColumn.Index
                    Dim Cta As New CN.CuentaContableCollectionClass
                    dgvPoliza.CurrentRow.Cells(SSCtaDataGridViewTextBoxColumn.Index).Value = "0000"
                    dgvPoliza.CurrentRow.Cells(SSSCtaDataGridViewTextBoxColumn.Index).Value = "0000"
                    Cta.Obtener(Nothing, "", dgvPoliza.CurrentRow.Cells(CtaDataGridViewTextBoxColumn.Index).Value.ToString(), dgvPoliza.CurrentRow.Cells(SCtaDataGridViewTextBoxColumn.Index).Value.ToString(), "0000", "0000")
                    If Cta.Count > 0 Then
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = Cta(0).NombreCuenta.ToString()
                    Else
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = ""
                        MessageBox.Show("Cuenta no existe.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case Me.SSCtaDataGridViewTextBoxColumn.Index
                    Dim Cta As New CN.CuentaContableCollectionClass
                    dgvPoliza.CurrentRow.Cells(SSSCtaDataGridViewTextBoxColumn.Index).Value = "0000"
                    Cta.Obtener(Nothing, "", dgvPoliza.CurrentRow.Cells(CtaDataGridViewTextBoxColumn.Index).Value.ToString(), dgvPoliza.CurrentRow.Cells(SCtaDataGridViewTextBoxColumn.Index).Value.ToString(), dgvPoliza.CurrentRow.Cells(SSCtaDataGridViewTextBoxColumn.Index).Value.ToString(), "0000")
                    If Cta.Count > 0 Then
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = Cta(0).NombreCuenta.ToString()
                    Else
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = ""
                        MessageBox.Show("Cuenta no existe.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case Me.SSSCtaDataGridViewTextBoxColumn.Index
                    Dim Cta As New CN.CuentaContableCollectionClass
                    Cta.Obtener(Nothing, "", dgvPoliza.CurrentRow.Cells(CtaDataGridViewTextBoxColumn.Index).Value.ToString(), dgvPoliza.CurrentRow.Cells(SCtaDataGridViewTextBoxColumn.Index).Value.ToString(), dgvPoliza.CurrentRow.Cells(SSCtaDataGridViewTextBoxColumn.Index).Value.ToString(), dgvPoliza.CurrentRow.Cells(SSSCtaDataGridViewTextBoxColumn.Index).Value.ToString())
                    If Cta.Count > 0 Then
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = Cta(0).NombreCuenta.ToString()
                    Else
                        dgvPoliza.CurrentRow.Cells(NombreCtaDataGridViewTextBoxColumn.Index).Value = ""
                        MessageBox.Show("Cuenta no existe.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
            If e.ColumnIndex = AbonoDataGridViewTextBoxColumn.Index Then
                'dgvPoliza.CurrentRow.Selected = dgvPoliza.Rows(e.RowIndex + 1)
                'dgvPoliza.Rows.Add()
                'dgvPoliza.CurrentRow.Selected = e.RowIndex + 1
                'dgvPoliza.CurrentCell.Selected = CtaDataGridViewTextBoxColumn.Index
                'SendKeys.Send("{right}")
                'SendKeys.Send("{up}")
                SendKeys.Send("{home}")
            Else
                SendKeys.Send("{right}")
                SendKeys.Send("{up}")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPoliza.DataError

    End Sub

    Private Sub grid_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvPoliza.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Dim VtaBuscaCta As New BusquedaCuentasContablesForm

                VtaBuscaCta.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
                VtaBuscaCta.InactivaDefault(True) = ClasesNegocio.CondicionAsignadaEnum.NO

                If VtaBuscaCta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    
                    If VtaBuscaCta.CuentaContable.Departamentalizable = Integra.Clases.SiNoEnum.SI Then
                        For i As Integer = 0 To Me.dgvDistribuciondeGastos.Rows.Count - 1
                            If Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmDepartamentalizable.Index).Value = "" Then
                                Me.dgvDistribuciondeGastos.Rows.Add()
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmCodigoCuenta.Index).Value = VtaBuscaCta.CuentaContable.Codigo
                                Me.dgvDistribuciondeGastos.Rows(i).Cells(Me.clmDepartamentalizable.Index).Value = "SI"
                            End If
                        Next
                    End If

                    Dim DetalleNvo As New CN.PolizaDetalleClass
                    dgvPoliza.DataSource = Nothing
                    DetalleNvo.IdCuentaContable = VtaBuscaCta.CuentaContable.Codigo
                    DetalleNvo.Cta = VtaBuscaCta.CuentaContable.CuentaMayor
                    DetalleNvo.SCta = VtaBuscaCta.CuentaContable.SubCuenta
                    DetalleNvo.SSCta = VtaBuscaCta.CuentaContable.SSubCuenta
                    DetalleNvo.SSSCta = VtaBuscaCta.CuentaContable.SSSubCuenta
                    DetalleNvo.Concepto = VtaBuscaCta.CuentaContable.NombreCuenta
                    Poliza.Detalles2.Add(DetalleNvo)

                    dgvPoliza.DataSource = Poliza.Detalles2

                    'grid.Rows(grid.Rows.Count - 2).Cells(Me.CtaDataGridViewTextBoxColumn.Index).Value = VtaBuscaPolizas.gridCuentas.SelectedRows(0).Cells("Cta").Value
                    'grid.Rows(grid.Rows.Count - 2).Cells(Me.SCtaDataGridViewTextBoxColumn.Index).Value = VtaBuscaPolizas.gridCuentas.SelectedRows(0).Cells("SubCta").Value
                    'grid.Rows(grid.Rows.Count - 2).Cells(Me.SSCtaDataGridViewTextBoxColumn.Index).Value = VtaBuscaPolizas.gridCuentas.SelectedRows(0).Cells("SSubCta").Value
                    'grid.Rows(grid.Rows.Count - 2).Cells(Me.SSSCtaDataGridViewTextBoxColumn.Index).Value = VtaBuscaPolizas.gridCuentas.SelectedRows(0).Cells("SSSubCta").Value

                    VtaBuscaCta.Close()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvPoliza.UserDeletedRow
        

        ObtenerTotal()
    End Sub

    Private Sub grid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgvPoliza.UserDeletingRow
        If dgvPoliza.Rows.Count - 1 = 1 Then
            Dim result As DialogResult = MessageBox.Show("¿Seguro que quiere eliminar este renglón?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                Me.txtTotalAbono.Text = "$0.00"
                Me.txtTotalCargo.Text = "$0.00"
            Else
                e.Cancel = True
            End If
            
        End If
    End Sub

    Private Sub grid_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPoliza.CellBeginEdit
        Try
            If e.ColumnIndex <> NombreCtaDataGridViewTextBoxColumn.Index Then
                If dgvPoliza.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0 Then
                    If e.ColumnIndex = CargoDataGridViewTextBoxColumn.Index And dgvPoliza.Rows(e.RowIndex).Cells(AbonoDataGridViewTextBoxColumn.Index).Value <> 0 Then
                        If MessageBox.Show("La operacion se establecera como Cargo, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                            CType(dgvPoliza.Rows(e.RowIndex).DataBoundItem, CN.PolizaDetalleClass).Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                            dgvPoliza.Rows(e.RowIndex).Cells(AbonoDataGridViewTextBoxColumn.Index).Value = 0
                        Else
                            e.Cancel = True
                        End If
                    ElseIf e.ColumnIndex = AbonoDataGridViewTextBoxColumn.Index And dgvPoliza.Rows(e.RowIndex).Cells(CargoDataGridViewTextBoxColumn.Index).Value <> 0 Then
                        If MessageBox.Show("La operacion se establecera como Abono, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                            CType(dgvPoliza.Rows(e.RowIndex).DataBoundItem, CN.PolizaDetalleClass).Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                            dgvPoliza.Rows(e.RowIndex).Cells(CargoDataGridViewTextBoxColumn.Index).Value = 0
                        Else
                            e.Cancel = True
                        End If
                    Else
                        If e.ColumnIndex = CargoDataGridViewTextBoxColumn.Index Then
                            CType(dgvPoliza.Rows(e.RowIndex).DataBoundItem, CN.PolizaDetalleClass).Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                        ElseIf e.ColumnIndex = AbonoDataGridViewTextBoxColumn.Index Then
                            CType(dgvPoliza.Rows(e.RowIndex).DataBoundItem, CN.PolizaDetalleClass).Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                        End If
                    End If
                Else
                    If e.ColumnIndex = CargoDataGridViewTextBoxColumn.Index Then
                        CType(dgvPoliza.Rows(e.RowIndex).DataBoundItem, CN.PolizaDetalleClass).Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                    ElseIf e.ColumnIndex = AbonoDataGridViewTextBoxColumn.Index Then
                        CType(dgvPoliza.Rows(e.RowIndex).DataBoundItem, CN.PolizaDetalleClass).Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

   
    Private Sub dgvPoliza_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPoliza.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Dim col As Integer = dgvPoliza.CurrentCell.ColumnIndex
            'Dim row As Integer = dgvPoliza.CurrentCell.RowIndex

            'If col < dgvPoliza.ColumnCount - 1 Then
            '    col += 1
            'Else
            '    col = 0
            '    row += 1
            'End If

            'If row = dgvPoliza.RowCount Then
            '    dgvPoliza.Rows.Add()
            'End If

            'dgvPoliza.CurrentCell = dgvPoliza(col, row)

            If dgvPoliza.CurrentCell.ColumnIndex = AbonoDataGridViewTextBoxColumn.Index Then
                e.Handled = False
                SendKeys.Send("{home}")
            Else
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If


            
        End If

    End Sub
End Class