Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses



Public Class FrmAperturaLoteCorte2
    Dim Introductores As New ClientesIntroductoresColeccion
    Dim TipoGanado As New TipoGanadoColecttionClass
    Dim proveedores As New ProveedorCollectionClass


    Private Sub MEAToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles MEAToolBar1.ButtonClick
        Select Case e.Button.Text
            Case "Guardar"
                If (Not Validar()) Then
                    Exit Sub
                End If
                If Not Guardar() Then
                    MessageBox.Show("No se pudo generar Lote de Corte", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Se genero lote de corte con folio  : " & Me.txtLoteCorte.Text, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.Limpiar()
            Case "Buscar"
                If Not Buscar() Then
                    MessageBox.Show("No se encuentran lotes de corte disponibles", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "Imprimir"
                If Not Imprimir() Then
                    MessageBox.Show("No se encuentran lotes de corte disponible para impresion", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try

            Dim LoteCorte As New CortesClass
            LoteCorte.LoteSacrificio = Me.txtFolioSacrificio.Text
            LoteCorte.FechaCorte = Me.dtpFechaLoteCorte.Value
            LoteCorte.FechaFapsa = Me.dtpFechaSacrificio.Value
            LoteCorte.IdCliente = 0
            LoteCorte.DiasCad = Me.txtDiasCaducidad.Text
            LoteCorte.FechaCad = Me.dtpFechaCaducidad.Value
            LoteCorte.Observaciones = Me.txtObservaciones.Text
            LoteCorte.Estatus = "A"
            LoteCorte.Func = "A"
            LoteCorte.NumOpc = 1

            ''nuevos datos -------------------------------
            LoteCorte.Nopiezas = txtNoPiezas.Text
            LoteCorte.Producto = CmbTipoGanado.SelectedValue
            LoteCorte.Unidad = txtUnidad.Text
            LoteCorte.Conductor = txtConductor.Text
            LoteCorte.Placas = txtPlacas.Text
            LoteCorte.Horaviaje = txtHorasViaje.Text
            LoteCorte.Idproveedor = cmbProveedor.SelectedValue
            LoteCorte.Cvelugcom = CmbLugarCompra.SelectedValue
            LoteCorte.Cvecomprador = cmbComprador.SelectedValue
            LoteCorte.Observacioneslote = txtobserbacioneslote.Text
            LoteCorte.KilosRecibidos = txtKilosRecibidos.Text
            LoteCorte.Nofactura = txtNoFactura.Text
            LoteCorte.Importe = txtImporte.Text

            If Not LoteCorte.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If


            Dim Gastos As New ClasesNegocio.GastoTransporteClass(LoteCorte.LoteCorte)
            If Not Gastos.Folio.Equals("") Then
                If DgvConceptoGastos.Rows.Count > 1 Then
                    Gastos.Folio = LoteCorte.LoteCorte
                    Gastos.FechaRecepcion = LoteCorte.FechaCorte
                    Gastos.ImporteTotal = CDec(Me.txtTotal.Text.Replace("$", ""))
                    Gastos.IVA = CDec(Me.txtIVA.Text.Replace("$", ""))

                    'If Gastos.Detalle.Count = DgvConceptoGastos.RowCount Then
                    For Each Fila As DataGridViewRow In DgvConceptoGastos.Rows
                        If Not Fila.IsNewRow Then
                            Dim gastoDetalle As New ClasesNegocio.GastoTransporteDetalleClass()
                            gastoDetalle.Folio = Gastos.Folio
                            gastoDetalle.Renglon = (Fila.Index + 1)
                            gastoDetalle.IdGasto = Fila.Cells(clmcmbConceptoGasto.Index).Value
                            gastoDetalle.PorcentajeIva = Fila.Cells(clmtxtIva.Index).Value
                            gastoDetalle.ImporteGasto = Fila.Cells(clmtxtImporteGasto.Index).Value
                            Gastos.Detalle.Add(gastoDetalle)
                        End If
                    Next
                    'End If

                    If Not Gastos.Guardar(Trans) Then
                        Trans.Rollback()
                        Return False
                    End If

                End If


            End If


            Me.txtLoteCorte.Text = LoteCorte.LoteCorte
            Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try


    End Function
    Private Function Limpiar() As Boolean
        Me.txtLoteCorte.Text = 0
        Me.txtFolioSacrificio.Text = ""

        Me.txtDiasCaducidad.Text = 0

        Me.txtObservaciones.Text = ""
        Me.dtpFechaCaducidad.Value = Now
        Me.dtpFechaLoteCorte.Value = Now
        Me.dtpFechaSacrificio.Value = Now
    End Function
    Private Function Buscar() As Boolean
        Dim TablaEmbarque As DataSet = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspConMscloteCortesCab(1, "")
        'Dim Consultas As New FrmConsLoteCortes
        'Consultas.dgvLoteCortes.AutoGenerateColumns = False
        'Consultas.dgvLoteCortes.DataSource = TablaEmbarque.Tables(0)
        'Consultas.LoteCorte.DataPropertyName = "IdFolioLoteCorte"
        'Consultas.FechaCorte.DataPropertyName = "FechaCorte"
        'Consultas.Cliente.DataPropertyName = "Nom_Cliente"
        'Consultas.DiasCad.DataPropertyName = "DiasCad"
        'Consultas.Estatus.DataPropertyName = "Estatus"
        'If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Me.txtLoteCorte.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("IdFolioLoteCorte").Value
        '    Me.dtpFechaLoteCorte.Value = Consultas.dgvLoteCortes.CurrentRow.Cells("Fecha").Value
        '    Me.txtNombre.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("Cliente").Value
        '    Me.txtDiasCaducidad.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("DiasCad").Value
        '    Me.lblEstatus.Text = Consultas.dgvLoteCortes.CurrentRow.Cells("Estatus").Value
        'End If
        Me.txtLoteCorte.Focus()
    End Function

    Private Function Validar() As Boolean
        Try
            Dim Mensaje As New System.Text.StringBuilder()

            If Me.txtNoPiezas.Text.Trim = "" Then Mensaje.AppendLine("*No piezas")
            If Me.txtKilosRecibidos.Text.Trim = "" Then Mensaje.AppendLine("*Kilos recibidos")
            If Me.txtNoFactura.Text.Trim = "" Then Mensaje.AppendLine("*No de factura")
            If Me.txtImporte.Text.Trim = "" Then Mensaje.AppendLine("*El importe")
            If Me.CmbTipoGanado.SelectedValue Is Nothing Then Mensaje.AppendLine("*Poblacion")
            If Me.txtUnidad.Text.Trim = "" Then Mensaje.AppendLine("*La unidad")
            If Me.txtConductor.Text.Trim = "" Then Mensaje.AppendLine("*El conductor")
            If Me.txtPlacas.Text.Trim = "" Then Mensaje.AppendLine("*Las placas")
            If Me.cmbProveedor.SelectedValue Is Nothing Then Mensaje.AppendLine("* el proveedor")
            If Me.cmbProveedor.SelectedValue Is Nothing Then Mensaje.AppendLine("* el lugar de compra")
            If Me.cmbComprador.SelectedValue Is Nothing Then Mensaje.AppendLine("* el comprador")
            If Me.txtobserbacioneslote.Text.Trim = "" Then Mensaje.AppendLine("* la obserbacion")

            If Mensaje.ToString() <> String.Empty Then

                Mensaje.Insert(0, New System.Text.StringBuilder().AppendLine("En la seccion de , debe especificar los siguientes datos correctamente:"))
                'Throw New Exception(Mensaje.ToString())
                MessageBox.Show(Mensaje.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom.Trim & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function Imprimir() As Boolean
    End Function

    Private Sub txtFolioSacrificio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioSacrificio.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpFechaSacrificio.Focus()
        End If
    End Sub

    Private Sub dtpFechaLoteCorte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaLoteCorte.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtFolioSacrificio.Focus()
        End If
    End Sub


    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtDiasCaducidad.Focus()
        End If
    End Sub


    Private Sub txtDiasCaducidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasCaducidad.KeyPress
        If e.KeyChar = Chr(13) Then
            'Me.dtpFechaCaducidad.Value = Me.dtpFechaCaducidad. + Me.txtDiasCaducidad.Text
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub FrmAperturaLoteCorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Limpiar()
        LlenaComboBox()

    End Sub
    Private Function LlenaComboBox() As Boolean
        Try

            Dim lugares As New LugaresDeCompraCollectionClass
            Dim CompradoresGanadoC As New ClasesNegocio.CompradorGanadoCollectionClass
            Dim ConceptosGasto As New ClasesNegocio.ConceptoGastosTransporteColeccionClass
            Dim productos As New ClasesNegocio.ProductosCollectionsClass



            productos.Obtener()
            Me.CmbTipoGanado.DisplayMember = "Descripcion"
            Me.CmbTipoGanado.ValueMember = "IdProducto"
            Me.CmbTipoGanado.DataSource = productos
            Me.CmbTipoGanado.SelectedIndex = -1



            lugares.Obtener(CondicionEnum.ACTIVOS)
            Me.CmbLugarCompra.DisplayMember = "Descripcion"
            Me.CmbLugarCompra.ValueMember = "IdLugarCompra"
            Me.CmbLugarCompra.DataSource = lugares
            Me.CmbLugarCompra.SelectedIndex = -1

            CompradoresGanadoC.Obtener(CondicionEnum.ACTIVOS)
            Me.cmbComprador.DataSource = CompradoresGanadoC
            Me.cmbComprador.DisplayMember = "NomCompleto"
            Me.cmbComprador.ValueMember = "IdComprador"
            Me.cmbComprador.SelectedIndex = -1


            ConceptosGasto.Obtener(CondicionEnum.ACTIVOS)
            clmcmbConceptoGasto.DisplayMember = "Descripcion"
            clmcmbConceptoGasto.ValueMember = "IdConceptoGasto"
            clmcmbConceptoGasto.DataSource = ConceptosGasto

            proveedores.Obtener(CondicionEnum.ACTIVOS)
            Me.cmbProveedor.DataSource = proveedores
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.ValueMember = "Codigo"
            Me.cmbProveedor.SelectedIndex = -1


            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function

    Private Sub DgvConceptoGastos_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvConceptoGastos.CellEndEdit
        If e.ColumnIndex = clmtxtImporteGasto.Index Or e.ColumnIndex = clmtxtIva.Index Then
            DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N2")
            calcular()
        End If
    End Sub
    Public Sub calcular()
        Dim sumaSubTotal As Decimal, sumaIVA As Decimal
        sumaIVA = 0
        sumaSubTotal = 0
        For Each row As DataGridViewRow In DgvConceptoGastos.Rows
            If Not row.IsNewRow Then
                sumaIVA += Math.Round(CDec(row.Cells(clmtxtImporteGasto.Index).Value) * (CDec(row.Cells(clmtxtIva.Index).Value) / 100), 2)
                sumaSubTotal += Math.Round(CDec(row.Cells(clmtxtImporteGasto.Index).Value), 2)
            End If
        Next
        txtSubTotal.Text = sumaSubTotal.ToString("N2")
        txtIVA.Text = sumaIVA.ToString("N2")
        txtTotal.Text = (sumaIVA + sumaSubTotal).ToString("N2")
    End Sub


    Private Sub DgvConceptoGastos_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvConceptoGastos.RowValidating
        'If clmcmbConceptoGasto.Index = e.ColumnIndex or Then
        'MessageBox.Show(DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        If DgvConceptoGastos.Rows(e.RowIndex).IsNewRow Then
            e.Cancel = False
            Return
        End If

        If DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit) Is Nothing Then
            e.Cancel = True
            MessageBox.Show("Seleccione un concepto...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' End If
        'If clmtxtImporteGasto.Index = e.ColumnIndex Then
        If DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit).ToString().Equals("") Then
            e.Cancel = True
            MessageBox.Show("Se debe ingresar el importe...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' End If
    End Sub

    Private Sub DgvConceptoGastos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DgvConceptoGastos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim i As Integer = DgvConceptoGastos.CurrentCell.RowIndex
            If Not DgvConceptoGastos.Rows(i).IsNewRow Then
                DgvConceptoGastos.Rows.RemoveAt(i)
                calcular()
            End If
        End If
    End Sub
End Class