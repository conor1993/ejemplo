Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient



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
                Dim guardarResult As Byte
                guardarResult = Guardar()
                If guardarResult = 0 Then
                    MessageBox.Show("No se pudo generar Lote de Corte", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Me.Limpiar()
                ElseIf guardarResult = 1 Then
                    MessageBox.Show("Se genero lote de corte con folio  : " & Me.txtLoteCorte.Text, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AbrirNuevo()
                    'Me.Limpiar()
                ElseIf guardarResult = 2 Then
                    MessageBox.Show("No es posible modificar la compra de producto", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

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
            Case "Nuevo"
                AbrirNuevo()

        End Select
    End Sub

    Private Function AbrirNuevo()
        Dim ventana As Form = New FrmAperturaLoteCorte2
        ventana.Icon = Me.Icon
        ventana.StartPosition = FormStartPosition.CenterScreen
        ventana.Show()
        Me.Close()
    End Function

    Private Function Guardar() As Byte
        If txtLoteCorte.Text = "0" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
            Try

                Dim LoteCorte As New CortesClass
                LoteCorte.LoteSacrificio = Me.txtFolioSacrificio.Text
                LoteCorte.FechaCorte = Me.dtpFechaLoteCorte.Value
                LoteCorte.FechaFapsa = Me.dtpFechaSacrificio.Value
                LoteCorte.IdCliente = 0
                Dim diasCant As Integer
                If String.IsNullOrEmpty(Me.txtDiasCaducidad.Text) Then
                    diasCant = 0
                Else
                    diasCant = CInt(Me.txtDiasCaducidad.Text)
                End If
                LoteCorte.DiasCad = Me.txtDiasCaducidad.Text
                LoteCorte.FechaCad = Me.dtpFechaCaducidad.Value
                LoteCorte.Observaciones = Me.txtObservaciones.Text
                LoteCorte.Estatus = "A"
                LoteCorte.Func = "A"
                LoteCorte.NumOpc = 1
                ''nuevos datos ----------------------------------------------------------------------------------------------------------------------------------
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

                ''----------------------------------------  calculo de  kilos    

                LoteCorte.Precioxkilo = calcularprecioxkilo(Convert.ToDecimal(txtKilosRecibidos.Text), Convert.ToDecimal(txtImporte.Text))
                LoteCorte.Precioxkilogasto = calcularprecioxkilo(Convert.ToDecimal(txtKilosRecibidos.Text), Convert.ToDecimal(txtTotal.Text))
                LoteCorte.Precioxkilototal = LoteCorte.Precioxkilo + LoteCorte.Precioxkilogasto

                If Not LoteCorte.Guardar(Trans) Then
                    Trans.Rollback()
                    Return 0
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
                                gastoDetalle.Nofactura = Fila.Cells(clmfactura.Index).Value
                                gastoDetalle.CodProveedor = Fila.Cells(clmproovedor.Index).Value
                                gastoDetalle.Retencion = Fila.Cells(clmretencion.Index).Value
                                Gastos.Detalle.Add(gastoDetalle)
                            End If
                        Next
                        'End If

                        If Not Gastos.Guardar(Trans) Then
                            Trans.Rollback()
                            Return 0
                        End If

                    End If


                End If


                Me.txtLoteCorte.Text = LoteCorte.LoteCorte
                Trans.Commit()
                Return 1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Trans.Rollback()
                Return 0
            End Try
        Else
            Return 2
        End If
    End Function
    Public Function Limpiar() As Boolean
        Me.txtLoteCorte.Text = 0
        Me.txtFolioSacrificio.Text = ""

        Me.txtDiasCaducidad.Text = 0

        Me.txtObservaciones.Text = ""
        Me.dtpFechaCaducidad.Value = Now
        Me.dtpFechaLoteCorte.Value = Now
        Me.dtpFechaSacrificio.Value = Now


        cmbComprador.Text = "Seleccione un Comprador..."
        cmbComprador.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione un Proveedor..."
        cmbProveedor.SelectedIndex = -1
        CmbLugarCompra.Text = "Seleccione un Lugar..."
        CmbLugarCompra.SelectedIndex = -1
        CmbTipoGanado.Text = "Seleccione un Tipo de ganado..."
        CmbTipoGanado.SelectedIndex = -1


        'TxtFolio.Text = ""
        'DgvConceptoGastos.DataSource = ""

        'DgvConceptoGastos.Rows.Clear()

        For Each row As DataGridViewRow In DgvConceptoGastos.Rows
            'If row.Cells(0).Value Is Nothing Then
            Try
                DgvConceptoGastos.Rows.Remove(row)
            Catch
            End Try

            'lista.Add(row.Index)
            'End If
        Next

        'For i As Integer = 0 To DgvConceptoGastos.RowCount - 1
        '    DgvConceptoGastos.Rows.Remove(Me.DgvConceptoGastos.Rows(i))

        'Next

        'DgvConceptoGastos.Rows.Clear()
        'DgvConceptoGastos.DataSource = Nothing

        'proveedores.Obtener(CondicionEnum.ACTIVOS)
        'Me.clmproovedor.DataSource = proveedores
        'Me.clmproovedor.DisplayMember = "RazonSocial"
        'Me.clmproovedor.ValueMember = "Codigo"

        dtpFechaPago.Value = DateTime.Now
        txtNoFactura.Text = ""
        txtDiasDeCredito.Text = ""
        txtHorasViaje.Text = ""
        txtobserbacioneslote.Text = ""
        txtPlacas.Text = ""
        txtConductor.Text = ""
        txtUnidad.Text = ""
        txtKilosRecibidos.Text = ""
        txtNoPiezas.Text = ""
        DgvConceptoGastos.AllowUserToAddRows = True
        txtSubTotal.Text = "0.00"
        txtIVA.Text = "0.00"
        txtTotal.Text = "0.00"
        txtImporte.Text = ""

    End Function
    Private Function Buscar() As Boolean
        Dim LCorteCons = New FrmConsAperturaLote2
        LCorteCons.FormPrincipal = Me
        LCorteCons.Show()

        Return True
    End Function

    Private Function Validar() As Boolean
        Try
            Dim Mensaje As New System.Text.StringBuilder()

            If Me.txtNoPiezas.Text.Trim = "" Then Mensaje.AppendLine("* No piezas")
            If Me.txtKilosRecibidos.Text.Trim = "" Then Mensaje.AppendLine("* Kilos recibidos")
            If Me.txtNoFactura.Text.Trim = "" Then Mensaje.AppendLine("* No de factura")
            If Me.txtImporte.Text.Trim = "" Then Mensaje.AppendLine("* El importe")
            'If Me.CmbTipoGanado.SelectedValue Is Nothing Then Mensaje.AppendLine("*Poblacion")
            If Me.CmbTipoGanado.SelectedValue Is Nothing Then Mensaje.AppendLine("* Producto")
            If Me.txtUnidad.Text.Trim = "" Then Mensaje.AppendLine("* La unidad")
            If Me.txtConductor.Text.Trim = "" Then Mensaje.AppendLine("*El conductor")
            If Me.txtPlacas.Text.Trim = "" Then Mensaje.AppendLine("* Las placas")
            If Me.cmbProveedor.SelectedValue Is Nothing Then Mensaje.AppendLine("* El proveedor")
            If Me.CmbLugarCompra.SelectedValue Is Nothing Then Mensaje.AppendLine("* El lugar de compra")
            If Me.cmbComprador.SelectedValue Is Nothing Then Mensaje.AppendLine("* El comprador")
            If Me.txtobserbacioneslote.Text.Trim = "" Then Mensaje.AppendLine("* La obserbacion")
            If Me.txtDiasCaducidad.Text.Trim = "0" Or String.IsNullOrEmpty(Me.txtDiasCaducidad.Text.Trim) Then Mensaje.AppendLine("* Días de caducidad")

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
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            'ENTER
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub FrmAperturaLoteCorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Limpiar()
        LlenaComboBox()
        tabControl.TabPages.Remove(tbDatosPago)

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

            'proveedores.Obtener(CondicionEnum.ACTIVOS)

            Dim query As String = "SELECT PrIdProveedor Codigo, PrRazSocial RazonSocial, ISNULL(EsdeGanado, 0) EsdeGanado" &
            " FROM MCatCompProveedores " &
            " WHERE(PrEstatus = 1 And ISNULL(EsdeGanado, 0) > 0) " &
            " ORDER BY PrRazSocial "

            'Me.cmbProveedor.DataSource = proveedores
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.ValueMember = "Codigo"
            Me.cmbProveedor.SelectedIndex = -1

            'proveedores.Obtener(CondicionEnum.ACTIVOS)
            'Me.clmproovedor.DataSource = proveedores
            Me.clmproovedor.DisplayMember = "RazonSocial"
            Me.clmproovedor.ValueMember = "Codigo"

            Dim tb As New DataTable
            Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
            Using sqlcom As New SqlCommand(query, sqlCon)
                Dim adp As New SqlDataAdapter(sqlcom)
                sqlCon.Open()
                adp.Fill(tb)
                cmbProveedor.DataSource = tb

                
                sqlCon.Close()
            End Using

            query = "SELECT PrIdProveedor Codigo, PrRazSocial RazonSocial, ISNULL(EsdeGanado, 0) EsdeGanado" &
                " FROM MCatCompProveedores " &
                " WHERE PrEstatus = 1 " &
                " ORDER BY PrRazSocial "

            Using sqlcom As New SqlCommand(query, sqlCon)
                tb = New DataTable
                Dim adp As New SqlDataAdapter(sqlcom)
                sqlCon.Open()
                adp.Fill(tb)
                clmproovedor.DataSource = tb


                sqlCon.Close()
            End Using


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
        If e.ColumnIndex = clmretencion.Index Then
            DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N2")
        End If
    End Sub
    Public Sub calcular(Optional ByVal forzarCalculo As Boolean = False)
        Dim sumaSubTotal As Decimal, sumaIVA As Decimal
        sumaIVA = 0
        sumaSubTotal = 0
        For Each row As DataGridViewRow In DgvConceptoGastos.Rows
            If Not row.IsNewRow Or forzarCalculo = True Then
                sumaIVA += Math.Round(CDec(row.Cells(clmtxtImporteGasto.Index).Value) * (CDec(row.Cells(clmtxtIva.Index).Value) / 100), 2)
                sumaSubTotal += Math.Round(CDec(row.Cells(clmtxtImporteGasto.Index).Value), 2)
            End If
        Next
        txtSubTotal.Text = sumaSubTotal.ToString("N2")
        txtIVA.Text = sumaIVA.ToString("N2")
        txtTotal.Text = (sumaIVA + sumaSubTotal).ToString("N2")
    End Sub

    Public Sub calcularManual()
        Dim sumaSubTotal As Decimal, sumaIVA As Decimal
        sumaIVA = 0
        sumaSubTotal = 0

        Dim importeInt As Double
        Dim importeIVAInt As Double

        For i As Integer = 0 To DgvConceptoGastos.Rows.Count - 1
            Dim row As DataGridViewRow = DgvConceptoGastos.Rows(i)
            If Not row.IsNewRow Then
                If DgvConceptoGastos.Rows(i).Cells("clmtxtImporteGasto").Value Is Nothing Then
                    importeInt = 0
                Else
                    importeInt = CDec(DgvConceptoGastos.Rows(i).Cells("clmtxtImporteGasto").Value.ToString())
                End If

                If DgvConceptoGastos.Rows(i).Cells("clmtxtIva").Value Is Nothing Then
                    importeIVAInt = 0
                Else
                    importeIVAInt = CDec(DgvConceptoGastos.Rows(i).Cells("clmtxtIva").Value.ToString())
                End If

                sumaIVA += Math.Round(importeInt * (importeIVAInt / 100), 2)
                sumaSubTotal += Math.Round(importeInt, 2)
            End If

        Next

        'For Each row As DataGridViewRow In DgvConceptoGastos.Rows
        '    If Not row.IsNewRow Then
        '        sumaIVA += Math.Round(CDec(DgvConceptoGastos.Rows(0).Cells("clmtxtImporteGasto").Value.ToString()) * (CDec(DgvConceptoGastos.Rows(0).Cells("clmtxtIva").Value.ToString()) / 100), 2)
        '        sumaSubTotal += Math.Round(CDec(DgvConceptoGastos.Rows(0).Cells("clmtxtImporteGasto").Value.ToString()), 2)
        '    End If
        'Next

        txtSubTotal.Text = sumaSubTotal.ToString("N2")
        txtIVA.Text = sumaIVA.ToString("N2")
        txtTotal.Text = (sumaIVA + sumaSubTotal).ToString("N2")

        Dim importe As Decimal
        If (String.IsNullOrEmpty(txtImporte.Text)) Then
            importe = 0
        Else
            importe = CDec(txtImporte.Text.Replace(",", ""))
        End If


        'Long.TryParse(txtImporte.Text.Replace(",", ""), 0)

        Dim totales As Decimal = sumaIVA + sumaSubTotal + importe

        txtTotalTotal.Text = totales.ToString("N2")

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
        If clmtxtImporteGasto.Index = e.ColumnIndex Then
            If DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit).ToString().Equals("") Then
                e.Cancel = True
                MessageBox.Show("Se debe ingresar el importe...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
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

    Private Sub DgvConceptoGastos_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvConceptoGastos.EditingControlShowing
        If Me.DgvConceptoGastos.CurrentCell.ColumnIndex = clmcmbConceptoGasto.Index Then
            Dim combo As ComboBox = TryCast(e.Control, ComboBox)
            If combo IsNot Nothing Then
                RemoveHandler combo.SelectedIndexChanged, AddressOf Me.combo_SelectedIndexChanged
                AddHandler combo.SelectedIndexChanged, AddressOf Me.combo_SelectedIndexChanged
            End If
        End If
        If Me.DgvConceptoGastos.CurrentCell.ColumnIndex = clmtxtImporteGasto.Index Or Me.DgvConceptoGastos.CurrentCell.ColumnIndex = clmtxtIva.Index Then
            Dim cajatexto As TextBox = TryCast(e.Control, TextBox)
            If cajatexto IsNot Nothing Then
                RemoveHandler cajatexto.KeyPress, AddressOf Me.cajaTexto_KeyPress
                AddHandler cajatexto.KeyPress, AddressOf Me.cajaTexto_KeyPress
            End If


        End If

        If Me.DgvConceptoGastos.CurrentCell.ColumnIndex = clmfactura.Index Then
            Dim cajatexto As TextBox = TryCast(e.Control, TextBox)
            If cajatexto IsNot Nothing Then
                RemoveHandler cajatexto.KeyPress, AddressOf Me.cajaTexto_KeyPress

            End If


        End If
    End Sub
    Private Sub combo_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cb As ComboBox = CType(sender, ComboBox)
        'Dim item As String = cb.Text
        'If item IsNot Nothing Then MessageBox.Show(item)+
        Dim catgasto As ClasesNegocio.ConceptoGastosTransporteClass
        If TypeOf cb.SelectedValue Is ClasesNegocio.ConceptoGastosTransporteClass Then
            catgasto = New ClasesNegocio.ConceptoGastosTransporteClass(CInt(CType(cb.SelectedValue, ClasesNegocio.ConceptoGastosTransporteClass).IdConceptoGasto))
        Else
            catgasto = New ClasesNegocio.ConceptoGastosTransporteClass(CInt(cb.SelectedValue))
        End If

        If catgasto.AplicaIVA Then
            Me.DgvConceptoGastos.CurrentRow.Cells(clmtxtIva.Index).Value = catgasto.PorcentajeIVA.ToString("N2")
        Else
            Me.DgvConceptoGastos.CurrentRow.Cells(clmtxtIva.Index).Value = Nothing
        End If

    End Sub

    Private Sub cajaTexto_KeyPress(sender As Object, e As EventArgs)
        NumerosyDecimal(sender, e)
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



    Private Sub txtKilosRecibidos_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosRecibidos.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtHorasViaje_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHorasViaje.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtImporte_Leave(sender As System.Object, e As System.EventArgs) Handles txtImporte.Leave
        'txtImporte.Text = Format(Val(Replace(txtImporte.Text, ",", "")), "#,###,###")

        Dim importe As Integer = Replace(txtImporte.Text, ",", "")
        txtImporte.Text = importe.ToString("N2")
    End Sub

    Private Sub txtDiasCaducidad_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDiasCaducidad.KeyUp
        e.Handled = False
        Dim date1 As DateTime = dtpFechaSacrificio.Value
        '(Not True)
        Dim dateAdd = If(Double.TryParse(txtDiasCaducidad.Text.ToString(), 0) = True, CDbl(txtDiasCaducidad.Text.ToString()), 0)
        date1 = date1.AddDays(dateAdd)
        dtpFechaCaducidad.Value = date1
    End Sub

    'Private Sub btnCalculo_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculo.Click
    '    calcular(True)
    'End Sub

    Private Sub txtImporte_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtImporte.KeyUp

        calcularManual()
    End Sub

    Private Sub txtImporte_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            'calcularManual()
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            'txtImporte.Text = Format(CDec(txtImporte.Text), "C")
            e.Handled = True
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotal.TextChanged
        calcularManual()

    End Sub

    Private Function calcularprecioxkilo(kilos As Decimal, importe As Decimal) As Decimal
        Dim Resultado As Decimal
        Resultado = 0
        If importe <> 0 Then
            Resultado = importe / kilos
        End If

        Return Resultado
    End Function

End Class