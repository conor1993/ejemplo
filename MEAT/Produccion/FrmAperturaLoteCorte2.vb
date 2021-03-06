Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
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
                    MessageBox.Show("No se pudo generar Lote de Corte", "ERP MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Me.Limpiar()
                ElseIf guardarResult = 1 Then
                    MessageBox.Show("Se genero lote de corte con folio  : " & Me.txtLoteCorte.Text, "ERP MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AbrirNuevo()
                    'Me.Limpiar()
                ElseIf guardarResult = 2 Then
                    MessageBox.Show("No es posible modificar la compra de producto", "Acci�n inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case "Buscar"
                If Not Buscar() Then
                    MessageBox.Show("No se encuentran lotes de corte disponibles", "ERP MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "Imprimir"
                If Not Imprimir() Then
                    MessageBox.Show("No se encuentran lotes de corte disponible para impresion", "ERP MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                LoteCorte.Producto = 0 'CmbTipoGanado.SelectedValue
                LoteCorte.Unidad = txtUnidad.Text
                LoteCorte.Conductor = txtConductor.Text
                LoteCorte.Placas = txtPlacas.Text
                LoteCorte.Horaviaje = txtHorasViaje.Text
                LoteCorte.Idproveedor = cmbProveedor.SelectedValue
                LoteCorte.Cvelugcom = CmbLugarCompra.SelectedValue
                LoteCorte.Cvecomprador = cmbComprador.SelectedValue
                'LoteCorte.Observacioneslote = txtobserbacioneslote.Text
                LoteCorte.KilosRecibidos = txtKilosRecibidos.Text
                LoteCorte.Nofactura = txtNoFactura.Text
                LoteCorte.Importe = txtImporte.Text

                ''-------------------------------------------  calculo de  kilos------------------------------------------------------------------
                'Original Juan
                'LoteCorte.Precioxkilo = calcularprecioxkilo(Convert.ToDecimal(txtKilosRecibidos.Text), Convert.ToDecimal(txtImporte.Text))
                'Cambio Dorantes
                'LoteCorte.Precioxkilo = calcularprecioxkilo(Convert.ToDecimal(txtKilosRecibidos.Text), Convert.ToDecimal(txtImporte.Text))
                LoteCorte.Precioxkilo = 0
                LoteCorte.Precioxkilogasto = calcularprecioxkilo(Convert.ToDecimal(txtKilosRecibidos.Text), Convert.ToDecimal(txtTotal.Text))
                LoteCorte.Precioxkilototal = 0
                'LoteCorte.Precioxkilo + LoteCorte.Precioxkilogasto

                'LoteSacrificio, FechaCorte, IdCliente, FechaCad, DiasCad, TotalPzas, TotalKgs, ConsecEtiquetas, Observaciones, Estatus, FechaCierre, FechaCancela, MotivoCancela, FechaCaptura, IdUsuarioCancela,
                '                       ObservacionesCancela, FolCorPza, FechaFapsa, Nopiezas, Producto, Unidad, Conductor, Placas, Horaviaje, Idproveedor, Cvelugcom, Cvecomprador, Observacioneslote, KilosRecibidos, Nofactura,
                '                       Importe, Precioxkilo, Precioxkilogasto, Precioxkilototal, Func, NumOpc, LoteCorte

                Dim Mensaje As New System.Text.StringBuilder()

                'Mensaje.AppendLine("LoteSacrificio: " + LoteCorte.LoteSacrificio.ToString())
                'Mensaje.AppendLine(" FechaCorte: " + LoteCorte.FechaCorte.ToString())
                'Mensaje.AppendLine(" IdCliente: " + LoteCorte.IdCliente.ToString())
                'Mensaje.AppendLine(" DiasCad: " + LoteCorte.DiasCad.ToString())
                'Mensaje.AppendLine("TotalPzas: " + LoteCorte.TotalPzas.ToString())
                'Mensaje.AppendLine(" TotalKgs: " + LoteCorte.TotalKgs.ToString())
                'Mensaje.AppendLine(" ConsecEtiquetas: " + LoteCorte.ConsecEtiquetas.ToString())
                'Mensaje.AppendLine(" Observaciones: " + LoteCorte.Observaciones.ToString())
                'Mensaje.AppendLine(" Estatus: " + LoteCorte.Estatus.ToString())
                'Mensaje.AppendLine(" FechaCierre: " + LoteCorte.FechaCierre.ToString())
                'Mensaje.AppendLine(" FechaCancela: " + LoteCorte.FechaCancela.ToString())
                'Mensaje.AppendLine(" MotivoCancela: " + LoteCorte.MotivoCancela.ToString())
                'Mensaje.AppendLine(" FechaCaptura: " + LoteCorte.FechaCaptura.ToString())
                'Mensaje.AppendLine(" IdUsuarioCancela: " + LoteCorte.IdUsuarioCancela.ToString())
                'Mensaje.AppendLine(" ObservacionesCancela: " + LoteCorte.ObservacionesCancela.ToString())
                'Mensaje.AppendLine(" FolCorPza: " + LoteCorte.FolCorPza.ToString())
                'Mensaje.AppendLine(" FechaFapsa: " + LoteCorte.FechaFapsa.ToString())
                'Mensaje.AppendLine(" Nopiezas: " + LoteCorte.Nopiezas.ToString())
                'Mensaje.AppendLine(" Producto: " + LoteCorte.Producto.ToString())
                'Mensaje.AppendLine(" Unidad: " + LoteCorte.Unidad.ToString())
                'Mensaje.AppendLine(" Conductor: " + LoteCorte.Conductor.ToString())
                'Mensaje.AppendLine(" Placas: " + LoteCorte.Placas.ToString())
                'Mensaje.AppendLine(" Horaviaje: " + LoteCorte.Horaviaje.ToString())
                'Mensaje.AppendLine(" Idproveedor: " + LoteCorte.Idproveedor.ToString())
                'Mensaje.AppendLine(" Cvelugcom: " + LoteCorte.Cvelugcom.ToString())
                'Mensaje.AppendLine(" Cvecomprador: " + LoteCorte.Cvecomprador.ToString())
                'Mensaje.AppendLine(" Observacioneslote: " + LoteCorte.Observacioneslote.ToString())
                'Mensaje.AppendLine(" KilosRecibidos: " + LoteCorte.KilosRecibidos.ToString())
                'Mensaje.AppendLine(" Nofactura: " + LoteCorte.Nofactura.ToString())
                'Mensaje.AppendLine(" Importe: " + LoteCorte.Importe.ToString())
                'Mensaje.AppendLine(" Precioxkilo: " + Math.Round(CDbl(LoteCorte.Precioxkilo)).ToString())
                'Mensaje.AppendLine(" Precioxkilogasto: " + Math.Round(CDbl(LoteCorte.Precioxkilogasto)).ToString())
                'Mensaje.AppendLine(" Func: " + LoteCorte.Func.ToString())
                'Mensaje.AppendLine(" NumOpc: " + LoteCorte.NumOpc.ToString())
                'Mensaje.AppendLine(" LoteCorte: " + LoteCorte.ToString())


                If Not LoteCorte.Guardar(Trans) Then
                    Trans.Rollback()
                    Return 0
                End If
                Try
                    'Guardando detalles productos
                Catch ex As Exception
                    Trans.Rollback()
                    Return 0
                End Try
                'Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

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

                Dim transaction As SqlTransaction
                Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                    connection.Open()

                    Dim command As SqlCommand = connection.CreateCommand()
                    transaction = connection.BeginTransaction("SampleTransaction")
                    command.Connection = connection
                    command.Transaction = transaction
                    Dim actualizarTipo As Byte = 1
                    Dim query As String = ""

                    Try
                        If gridProductos.Rows.Count > 1 Then
                            Dim ID_ProductoDet As String
                            Dim KilosRecibidosDet As String
                            Dim NoPiezasDet As String
                            Dim PrecioXKiloDet As String
                            Dim TotalDet As String
                            For Each Fila As DataGridViewRow In gridProductos.Rows
                                If Not Fila.IsNewRow Then
                                    ID_ProductoDet = Fila.Cells(clmProductoDet.Index).Value.ToString()
                                    KilosRecibidosDet = Fila.Cells(clmKilosRecibidosDet.Index).Value.Replace(",", "")
                                    NoPiezasDet = Fila.Cells(clmNoPiezasDet.Index).Value.Replace(",", "")
                                    PrecioXKiloDet = Fila.Cells(clmPrecioXKiloDet.Index).Value.Replace(",", "")
                                    TotalDet = Fila.Cells(clmTotalDet.Index).Value.Replace(",", "")
                                    'EXEC Usp_MSCLoteCortesSave 1, '140218035' , '2', '2.65', '3.25', '4.2568'
                                    query = "EXEC Usp_MSCLoteCortesSave 1, '{0}', {1}, {2}, {3}, {4}, {5}, {6}"
                                    query = String.Format(query, LoteCorte.LoteCorte, ID_ProductoDet, KilosRecibidosDet, NoPiezasDet, PrecioXKiloDet, TotalDet, actualizarTipo)
                                    command.CommandText = query
                                    command.ExecuteNonQuery()
                                    actualizarTipo = 0
                                End If
                            Next
                            command.Transaction.Commit()

                        End If
                        connection.Close()
                    Catch ex As Exception
                        Try
                            command.Transaction.Rollback()
                        Catch ex2 As Exception
                            Return 0
                            'Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                            'Console.WriteLine("  Message: {0}", ex2.Message)
                        End Try
                        Return 0
                    End Try

                End Using



                Return 1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERP MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        For Each row As DataGridViewRow In gridProductos.Rows
            'If row.Cells(0).Value Is Nothing Then
            Try
                gridProductos.Rows.Remove(row)
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

        'dtpFechaPago.Value = DateTime.Now
        txtNoFactura.Text = ""
        'txtDiasDeCredito.Text = ""
        txtHorasViaje.Text = ""
        'txtobserbacioneslote.Text = ""
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
        txtNoFactura.Focus()

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

            'If Me.txtNoPiezas.Text.Trim = "" Then Mensaje.AppendLine("* No piezas")
            'If Me.txtKilosRecibidos.Text.Trim = "" Then Mensaje.AppendLine("* Kilos recibidos")
            If Me.txtNoFactura.Text.Trim = "" Then Mensaje.AppendLine("* No de factura")

            Dim importekilosDet As Decimal = 0

            If Me.txtImporte.Text.Trim = "" Then Mensaje.AppendLine("* El importe")
            'If Me.CmbTipoGanado.SelectedValue Is Nothing Then Mensaje.AppendLine("*Poblacion")
            'If Me.CmbTipoGanado.SelectedValue Is Nothing Then Mensaje.AppendLine("* Producto")
            If Me.txtUnidad.Text.Trim = "" Then Mensaje.AppendLine("* La unidad")
            If Me.txtConductor.Text.Trim = "" Then Mensaje.AppendLine("* El conductor")
            If Me.txtPlacas.Text.Trim = "" Then Mensaje.AppendLine("* Las placas")
            If Me.cmbProveedor.SelectedValue Is Nothing Then Mensaje.AppendLine("* El proveedor")
            If Me.CmbLugarCompra.SelectedValue Is Nothing Then Mensaje.AppendLine("* El lugar de compra")
            If Me.cmbComprador.SelectedValue Is Nothing Then Mensaje.AppendLine("* El comprador")
            'If Me.txtobserbacioneslote.Text.Trim = "" Then Mensaje.AppendLine("* La obserbacion")
            If Me.txtDiasCaducidad.Text.Trim = "0" Or String.IsNullOrEmpty(Me.txtDiasCaducidad.Text.Trim) Then Mensaje.AppendLine("* D�as de caducidad")

            Dim totalKilos As Decimal = 0
            Dim totalPiezas As Decimal = 0
            Dim totaltotalDet As Decimal = 0
            If gridProductos.Rows.Count > 1 Then
                Dim ID_ProductoDet As String
                Dim KilosRecibidosDet As String
                Dim NoPiezasDet As String
                Dim PrecioXKiloDet As String
                Dim totalDet As String

                For Each Fila As DataGridViewRow In gridProductos.Rows
                    If Not Fila.IsNewRow Then
                        ID_ProductoDet = Fila.Cells(clmProductoDet.Index).Value
                        KilosRecibidosDet = Fila.Cells(clmKilosRecibidosDet.Index).Value
                        NoPiezasDet = Fila.Cells(clmNoPiezasDet.Index).Value
                        PrecioXKiloDet = Fila.Cells(clmPrecioXKiloDet.Index).Value
                        totalDet = Fila.Cells(clmTotalDet.Index).Value

                        If ID_ProductoDet Is Nothing Or
                            ID_ProductoDet = 0 Or
                            (String.IsNullOrEmpty(KilosRecibidosDet) Or CDec(KilosRecibidosDet)) <= 0 Or
                            (String.IsNullOrEmpty(NoPiezasDet) Or CDec(NoPiezasDet) <= 0) Or
                            (String.IsNullOrEmpty(PrecioXKiloDet) Or CDec(PrecioXKiloDet) <= 0) Then

                            Mensaje.AppendLine("* En la Secci�n de Productos todos los campos de las filas son requeridos")
                        Else
                            importekilosDet += (CDec(totalDet)) '+= calcularTotalPrecioXKiloDet(CDec(KilosRecibidosDet), CDec(PrecioXKiloDet))
                            totaltotalDet += CDec(totalDet)
                            totalKilos += CDec(KilosRecibidosDet)
                            totalPiezas += CDec(NoPiezasDet)

                        End If
                    End If
                Next
            Else
                Mensaje.AppendLine("* Favor de capturar los productos")
            End If

            Me.txtKilosRecibidos.Text = totalKilos
            Me.txtNoPiezas.Text = totalPiezas

            If Not Me.txtImporte.Text.Trim = "" Then
                If Mensaje.ToString() = String.Empty Then
                    If totaltotalDet <> CDec(txtImporte.Text) Then
                        Mensaje.AppendLine("* La suma de los totales por producto no coinciden con el total de la factura")
                    End If
                End If
            End If

            'Validando datos de gastos de transporte
            If DgvConceptoGastos.Rows.Count > 1 Then
                Dim Importe As String
                Dim NoFactura As String
                Dim ID_Proveedor As String

                For Each Fila As DataGridViewRow In DgvConceptoGastos.Rows
                    If Not Fila.IsNewRow Then
                        Importe = Fila.Cells(clmtxtImporteGasto.Index).Value
                        NoFactura = Fila.Cells(clmfactura.Index).Value
                        ID_Proveedor = CInt(Fila.Cells(clmproovedor.Index).Value)

                        If ID_Proveedor Is Nothing Or
                            ID_Proveedor = 0 Or
                            (String.IsNullOrEmpty(NoFactura)) Or
                            (String.IsNullOrEmpty(Importe) Or CDec(Importe) <= 0) Then
                            Mensaje.AppendLine("* Verifique que la informaci�n ingresada en la Secci�n de Gastos de compra sea correcta")
                        End If
                    End If
                Next
                'Else
                '    Mensaje.AppendLine("* Favor de capturar los Gastos de Compra")
            End If

            'Validando datos de gastos de transporte End

            If Mensaje.ToString() <> String.Empty Then
                Mensaje.Insert(0, New System.Text.StringBuilder().AppendLine("Debe especificar los siguientes datos correctamente:"))
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
        Dim tbProductos As New DataTable
        If txtLoteCorte.Text <> "0" And String.IsNullOrEmpty(txtLoteCorte.Text) = False Then
        Else
            gridProductos.DataSource = tbProductos
        End If

        Me.Limpiar()
        LlenaComboBox()
        'tabControl.TabPages.Remove(tbDatosPago)

    End Sub
    Private Function LlenaComboBox() As Boolean
        Try

            Dim lugares As New LugaresDeCompraCollectionClass
            Dim CompradoresGanadoC As New ClasesNegocio.CompradorGanadoCollectionClass
            Dim ConceptosGasto As New ClasesNegocio.ConceptoGastosTransporteColeccionClass
            Dim productos As New ClasesNegocio.ProductosCollectionsClass
            'Dim productosDet As New ClasesNegocio.ProductosCollectionsClass



            productos.Obtener()
            'productosDet.Obtener()
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

            Me.clmProductoDet.DisplayMember = "Descripcion"
            Me.clmProductoDet.ValueMember = "IdProducto"
            'Me.clmProductoDet.SelectedIndex = -1


            query = "SELECT IdProducto, Descripcion, Corte" &
            " FROM MSCCatProductos" &
            " WHERE (Corte = 1) ORDER BY Descripcion"

            Me.clmProductoDet.DisplayMember = "Descripcion"
            Me.clmProductoDet.ValueMember = "IdProducto"

            Using sqlcom As New SqlCommand(query, sqlCon)
                tb = New DataTable
                Dim adp As New SqlDataAdapter(sqlcom)
                sqlCon.Open()
                adp.Fill(tb)
                clmProductoDet.DataSource = tb

                sqlCon.Close()
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function

    Private Sub DgvConceptoGastos_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvConceptoGastos.CellEndEdit
        If e.ColumnIndex = clmtxtImporteGasto.Index Or e.ColumnIndex = clmtxtIva.Index Or e.ColumnIndex = clmretencion.Index Then
            Dim importeAux As Decimal = 0.0
            If Not String.IsNullOrEmpty(DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                importeAux = CDec(DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N4")
            End If
            DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = importeAux
            If e.ColumnIndex <> clmretencion.Index Then
                calcular()
            End If
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
        txtSubTotal.Text = sumaSubTotal.ToString("N4")
        txtIVA.Text = sumaIVA.ToString("N4")
        txtTotal.Text = (sumaIVA + sumaSubTotal).ToString("N4")
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

        txtSubTotal.Text = sumaSubTotal.ToString("N4")
        txtIVA.Text = sumaIVA.ToString("N4")
        txtTotal.Text = (sumaIVA + sumaSubTotal).ToString("N4")

        Dim importe As Decimal
        If (String.IsNullOrEmpty(txtImporte.Text)) Then
            importe = 0
        Else
            importe = CDec(txtImporte.Text.Replace(",", ""))
        End If


        'Long.TryParse(txtImporte.Text.Replace(",", ""), 0)

        Dim totales As Decimal = sumaIVA + sumaSubTotal + importe

        txtTotalTotal.Text = totales.ToString("N4")

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
            Me.DgvConceptoGastos.CurrentRow.Cells(clmtxtIva.Index).Value = catgasto.PorcentajeIVA.ToString("N4")
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

        Dim importe As Decimal = Replace(txtImporte.Text, ",", "")
        txtImporte.Text = importe.ToString("N4")
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

        If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Convert.ToChar(Keys.Back)) Or (e.KeyChar = "." And Me.txtImporte.Text.IndexOf(".") < 0)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        'If Char.IsDigit(e.KeyChar) Then
        '    'calcularManual()
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    'txtImporte.Text = Format(CDec(txtImporte.Text), "C")
        '    e.Handled = True
        'End If
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

        Return Math.Round(Resultado, 4)
    End Function

    Private Function calcularTotalPrecioXKiloDet(kilos As Decimal, precioXKilo As Decimal) As Decimal
        Dim Resultado As Decimal
        Resultado = 0
        If precioXKilo <> 0 Then
            Resultado = precioXKilo * kilos
        End If

        Return Math.Round(Resultado, 4)
    End Function

    Private Sub txtObservaciones_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtObservaciones.TextChanged

    End Sub

    Private Sub gridProductos_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridProductos.CellEndEdit
        If e.ColumnIndex = clmKilosRecibidosDet.Index Or e.ColumnIndex = clmNoPiezasDet.Index Or e.ColumnIndex = clmPrecioXKiloDet.Index Or e.ColumnIndex = clmTotalDet.Index Then
            'calculo
            If e.ColumnIndex = clmKilosRecibidosDet.Index Or e.ColumnIndex = clmPrecioXKiloDet.Index Then
                gridProductos.Rows(e.RowIndex).Cells(clmTotalDet.Index).Value = (CDec(gridProductos.Rows(e.RowIndex).Cells(clmKilosRecibidosDet.Index).Value) * CDec(gridProductos.Rows(e.RowIndex).Cells(clmPrecioXKiloDet.Index).Value)).ToString("N4")
            End If
            'If e.ColumnIndex = clmKilosRecibidosDet.Index Or e.ColumnIndex = clmPrecioXKiloDet.Index Then
            '    gridProductos.Rows(e.RowIndex).Cells(clmTotalDet.Index).Value = (CDec(gridProductos.Rows(e.RowIndex).Cells(clmKilosRecibidosDet.Index).Value) * CDec(gridProductos.Rows(e.RowIndex).Cells(clmPrecioXKiloDet.Index).Value)).ToString("N4")
            'ElseIf e.ColumnIndex = clmTotalDet.Index Then
            '    gridProductos.Rows(e.RowIndex).Cells(clmPrecioXKiloDet.Index).Value = (CDec(gridProductos.Rows(e.RowIndex).Cells(clmTotalDet.Index).Value) / CDec(gridProductos.Rows(e.RowIndex).Cells(clmKilosRecibidosDet.Index).Value)).ToString("N4")
            'ElseIf e.ColumnIndex = clmKilosRecibidosDet.Index Then

            'Else
            '    gridProductos.Rows(e.RowIndex).Cells(clmTotalDet.Index).Value = (CDec(gridProductos.Rows(e.RowIndex).Cells(clmKilosRecibidosDet.Index).Value) * CDec(gridProductos.Rows(e.RowIndex).Cells(clmPrecioXKiloDet.Index).Value)).ToString("N4")
            'End If
            'endCalculo
            gridProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(gridProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("N4")

        End If

        'Verificando producto
        Try
            If gridProductos.Rows.Count > 1 Then
                Dim ID_ProductoDet As Integer
                For Each Fila As DataGridViewRow In gridProductos.Rows
                    If Not Fila.IsNewRow Then
                        ID_ProductoDet = Fila.Cells(clmProductoDet.Index).Value
                        If Fila.Index <> e.RowIndex Then
                            If gridProductos.Rows(e.RowIndex).Cells(clmProductoDet.Index).Value = ID_ProductoDet Then
                                gridProductos.Rows(e.RowIndex).Cells(clmProductoDet.Index).Value = Nothing
                                MessageBox.Show("Ya se ha seleccionado ese producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit For
                            End If
                        End If
                    End If
                Next

            End If
        Catch ex As Exception

        End Try

        'End Verificar producto


    End Sub

    'Private Sub gridProductos_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gridProductos.RowValidating
    '    If clmKilosRecibidosDet.Index = e.ColumnIndex Then
    '        If gridProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit).ToString().Equals("") Then
    '            e.Cancel = True
    '            MessageBox.Show("Se debe ingresar los Kilos Recibidos...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '    End If
    'End Sub

    Private Sub gridProductos_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gridProductos.EditingControlShowing
        If Me.gridProductos.CurrentCell.ColumnIndex = clmKilosRecibidosDet.Index Or Me.gridProductos.CurrentCell.ColumnIndex = clmNoPiezasDet.Index Or Me.gridProductos.CurrentCell.ColumnIndex = clmPrecioXKiloDet.Index Then
            Dim cajatexto As TextBox = TryCast(e.Control, TextBox)
            If cajatexto IsNot Nothing Then
                RemoveHandler cajatexto.KeyPress, AddressOf Me.cajaTexto_KeyPress
                AddHandler cajatexto.KeyPress, AddressOf Me.cajaTexto_KeyPress
            End If


        End If

        'REMEMBER TO CHANGE THE COLUMN INDEX NUMBER TO YOUR COMBOBOX INDEX!!

        If gridProductos.CurrentCell.ColumnIndex = clmProductoDet.Index Then

            Dim combo As ComboBox = CType(e.Control, ComboBox)

            If (combo IsNot Nothing) Then

                ' Remove an existing event-handler, if present, to avoid adding multiple handlers when the editing control is reused.

                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionchangeCommitted)
                ' Add the event handler.

                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionchangeCommitted)

            End If

        End If


    End Sub

    Private Sub ComboBox_SelectionchangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        'DO STUFF HERE

    End Sub


    Private Sub txtAddProducto_Click(sender As System.Object, e As System.EventArgs) Handles txtAddProducto.Click
        'Dim dt As DataTable = TryCast(gridProductos.DataSource, DataTable)

        'Dim dtAux As New DataTable
        'dtAux.Columns.Add("ID")
        'dtAux.Columns.Add("Name")
        'dtAux.Columns(0).AutoIncrement = True
        ''Dim dt As New DataTable
        'Dim row As DataRow = dt.NewRow
        'row("clmKilosRecibidosDet") = 1
        'row(1) = 2
        'row(2) = 3
        'row(3) = 4
        'dt.Rows.Add(row)
        ''gridProductos.Rows.Add(row)
        ''gridProductos.CurrentCell = gridProductos.Rows(gridProductos.RowCount - 1).Cells(0)
    End Sub

    Private Sub gridProductos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gridProductos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim i As Integer = gridProductos.CurrentCell.RowIndex
            If Not gridProductos.Rows(i).IsNewRow Then
                gridProductos.Rows.RemoveAt(i)
                'calcular()
            End If
        End If
    End Sub


    Private Sub gridProductos_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gridProductos.RowValidating
        'If gridProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit) Is Nothing Then
        '    e.Cancel = True
        '    MessageBox.Show("Seleccione un concepto...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        ' End If
        'If clmtxtImporteGasto.Index = e.ColumnIndex Then
        '    If DgvConceptoGastos.Rows(e.RowIndex).Cells(e.ColumnIndex).GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit).ToString().Equals("") Then
        '        e.Cancel = True
        '        MessageBox.Show("Se debe ingresar el importe...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If

        'End If
    End Sub
End Class