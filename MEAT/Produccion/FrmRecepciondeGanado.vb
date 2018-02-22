Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.IO

Public Class FrmRecepciondeGanado
    Dim WithEvents RecepcionGanado As RecepcionGanadoClass
    Dim Introductores As New ClientesIntroductoresColeccion
    Dim TipoGanado As New TipoGanadoColecttionClass
    Dim Editar As Boolean = False
    Dim CargaPantalla As Boolean = False

    Private Sub FrmRecepciondeGanado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.B

                Case Keys.N

                Case Keys.L

                Case Keys.C

                Case Keys.X

                Case Keys.E

                Case Keys.I

                Case Keys.S

            End Select
        End If
    End Sub

    Private Sub FrmRecepciondeGanado_Loadc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DgvConceptoGastos.AutoGenerateColumns = False
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "101001111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010000"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")


            Me.Limpiar(False)
            Deshabilitar()
            'tabControl.TabPages.Remove(tbOtrosGastos)

        Catch ex As Exception

        End Try
    End Sub

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            Dim Folio As New FoliosClass
            Folio.Codigo = CodigodeFolios.RecepcionGanadoPie
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            'folio para el registro de embarque
            Me.txtLoteRecepcion.Text = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
            RecepcionGanado.LoteRecepcion = Me.txtLoteRecepcion.Text
            RecepcionGanado.FechaRecepcion = Me.dtpFechaRecepcion.Value
            RecepcionGanado.CabezasHembras = Me.txtCabezasHembra.Text
            RecepcionGanado.CabezasMachos = Me.txtCabezasMachos.Text
            RecepcionGanado.CantCabezas = Me.txtCantCabezas.Text
            RecepcionGanado.Conductor = Me.txtConductor.Text
            RecepcionGanado.KilosPrimeraPesada = Me.txtKilos1erpasada.Text
            RecepcionGanado.KilosSegundaPesada = Me.txtKilos2daPasada.Text
            RecepcionGanado.KilosEnviados = Me.txtKilosEnviados.Text
            RecepcionGanado.KilosRecibidos = Me.txtKilosRecibidos.Text
            RecepcionGanado.MultiplesIntroductores = Me.ChkMultiples.Checked
            RecepcionGanado.LoteEngorda = Me.txtLoteEngorda.Text
            RecepcionGanado.Observaciones = Me.txtObservaciones.Text
            RecepcionGanado.Placas = Me.txtPlacas.Text
            RecepcionGanado.Unidad = Me.txtUnidad.Text
            RecepcionGanado.IdCliente = Me.cmbIntroductor.SelectedValue
            RecepcionGanado.Estatus = "V"
            RecepcionGanado.IdUsuario = Controlador.Sesion.Usrndx
            RecepcionGanado.TipoGanado = Me.CmbTipoGanado.SelectedItem

            'RecepcionGanado.IdProveedor = IIf(cmbProveedor.SelectedValue = String.Empty, 0, cmbProveedor.SelectedValue)
            'RecepcionGanado.CveCompradorGanado = IIf(cmbComprador.SelectedValue = String.Empty, 0, cmbComprador.SelectedValue)
            'RecepcionGanado.CveLugarCompra = IIf(CmbLugarCompra.SelectedValue = String.Empty, 0, CmbLugarCompra.SelectedValue)
            'RecepcionGanado.HorasViaje = IIf(txtHorasViaje.Text.Trim().Equals(""), 0, txtHorasViaje.Text.Trim())

            RecepcionGanado.IdProveedor = cmbProveedor.SelectedValue
            RecepcionGanado.CveCompradorGanado = cmbComprador.SelectedValue
            RecepcionGanado.CveLugarCompra = CmbLugarCompra.SelectedValue
            RecepcionGanado.HorasViaje = IIf(txtHorasViaje.Text.Trim().Equals(""), 0, txtHorasViaje.Text.Trim())

            ''falta total de kilos y el importe por kilo

            RecepcionGanado.DiasCredito = IIf(txtDiasDeCredito.Text.Trim().Equals(""), 0, txtDiasDeCredito.Text.Trim())
            RecepcionGanado.FechaPago = dtpFechaPago.Value
            RecepcionGanado.NumFactura = txtNoFactura.Text.Trim()

            Dim fechanull As DateTime?
            fechanull = Nothing
            RecepcionGanado.FechaContabilidad = New DateTime(1900, 1, 1, 0, 0, 0)

            Dim polizanull As String = Nothing
            RecepcionGanado.NumPoliza = polizanull




            RecepcionGanado.Func = "I"
            RecepcionGanado.NumOpc = 1

            Dim RecepcionGanadoIDE As ClasesNegocio.RecepcionGanadoClass
            RecepcionGanadoIDE = RecepcionGanado.Clonar()
            'RecepcionGanadoIDE = CloneObject(Of ClasesNegocio.RecepcionGanadoClass)(RecepcionGanado)

            If Not RecepcionGanado.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If


            Trans.Commit()


            ''''-----------------------------------------------------------''''
            ''''-------------------AQUI SE GUARDA EN IDE FOODS-------------''''
            ''''-----------------------------------------------------------''''

            HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")

            If Not txtImporte.Text.Trim().Equals("") Then
                RecepcionGanadoIDE.ImporteComp = CDec(txtImporte.Text)
            End If


            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

            If Not RecepcionGanadoIDE.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If




            Dim Gastos As New ClasesNegocio.GastoTransporteClass(RecepcionGanado.LoteRecepcion)
            If Not Gastos.Folio.Equals("") Then
                If DgvConceptoGastos.Rows.Count > 1 Then
                    Gastos.Folio = RecepcionGanado.LoteRecepcion
                    Gastos.FechaRecepcion = RecepcionGanado.FechaRecepcion
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





            Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try
    End Function

    Public Shared Function CloneObject(Of T As New)(objClone As T) As T
        Dim GetString As String = SeralizeObjectToXML(Of T)(objClone)
        Return DeserializeXML(Of T)(GetString)
    End Function

    Public Shared Function DeserializeXML(Of T As New)(xmlData As String) As T
        If String.IsNullOrEmpty(xmlData) Then
            Return Nothing
        End If

        Dim tr As TextReader = New StringReader(xmlData)
        Dim DocItms As New T()
        Dim xms As New System.Xml.Serialization.XmlSerializer(DocItms.[GetType]())
        DocItms = DirectCast(xms.Deserialize(tr), T)
        Return If(DocItms Is Nothing, Nothing, DocItms)
    End Function

    Public Shared Function SeralizeObjectToXML(Of T)(xmlObject As T) As String
        Dim sbTR As New System.Text.StringBuilder()
        Dim xmsTR As New System.Xml.Serialization.XmlSerializer(xmlObject.[GetType]())
        Dim xwsTR As New System.Xml.XmlWriterSettings()
        Dim xmwTR As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(sbTR, xwsTR)
        xmsTR.Serialize(xmwTR, xmlObject)
        Return sbTR.ToString()
    End Function


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

    Private Function Limpiar(ByVal Multiple As Boolean) As Boolean
        If Multiple = True Then
            Me.txtCantCabezas.Text = "0"
            Me.txtCabezasHembra.Clear()
            Me.txtCabezasMachos.Clear()
            Me.txtKilosEnviados.Text = "0"
            Me.txtKilosRecibidos.Text = "0"
            Me.txtKilos1erpasada.Text = Me.txtKilos2daPasada.Text
            Me.txtKilos2daPasada.Text = "0"
            Me.txtLoteEngorda.Text = ""
            Me.txtLoteRecepcion.Text = ""
            Me.txtObservaciones.Text = ""
            Me.cmbIntroductor.Text = "Seleccione un Introductor"
            Me.cmbIntroductor.SelectedIndex = -1
            Me.SerialPort.Close()
            Me.dtpFechaRecepcion.Value = Now
            cmbComprador.Text = "Seleccione un Comprador..."
            cmbComprador.SelectedIndex = -1
            cmbProveedor.Text = "Seleccione un Proveedor..."
            cmbProveedor.SelectedIndex = -1
            CmbLugarCompra.Text = "Seleccione un Lugar..."
            CmbLugarCompra.SelectedIndex = -1
            CmbTipoGanado.Text = "Seleccione un Tipo de ganado..."
            CmbTipoGanado.SelectedIndex = -1

            TxtFolio.Text = ""
            DgvConceptoGastos.Rows.Clear()
            DgvConceptoGastos.DataSource = Nothing
            dtpFechaPago.Value = DateTime.Now
            txtNoFactura.Text = ""
            txtDiasDeCredito.Text = ""
            txtHorasViaje.Text = ""
            Me.mtb.sbCambiarEstadoBotones("Nuevo")
            DgvConceptoGastos.AllowUserToAddRows = True
            txtSubTotal.Text = "0.00"
            txtIVA.Text = "0.00"
            txtTotal.Text = "0.00"
            txtImporte.Text = ""
            RecepcionGanado = New RecepcionGanadoClass
        Else
            Me.txtCantCabezas.Text = "0"
            Me.txtCabezasHembra.Clear()
            Me.txtCabezasMachos.Clear()
            Me.txtConductor.Text = ""
            ' Me.txtImporte.Text = "0"
            Me.txtKilosEnviados.Text = "0"
            Me.txtKilosRecibidos.Text = "0"
            Me.txtKilos1erpasada.Text = "0"
            Me.txtKilos2daPasada.Text = "0"
            Me.txtLoteEngorda.Text = ""
            Me.txtLoteRecepcion.Text = ""
            Me.txtObservaciones.Text = ""
            Me.txtPlacas.Text = ""
            Me.txtUnidad.Text = ""
            Me.cmbIntroductor.SelectedIndex = -1
            Me.cmbIntroductor.Text = "Seleccione un Introductor"
            Me.CmbTipoGanado.SelectedIndex = -1
            Me.CmbTipoGanado.Text = "Seleccione un Tipo de Ganado"
            Me.SerialPort.Close()
            Me.dtpFechaRecepcion.Value = Now
            Me.CmbTipoGanado.SelectedIndex = -1
            cmbComprador.Text = "Seleccione un Comprador..."
            cmbComprador.SelectedIndex = -1
            cmbProveedor.Text = "Seleccione un Proveedor..."
            cmbProveedor.SelectedIndex = -1
            CmbLugarCompra.Text = "Seleccione un Lugar..."
            CmbLugarCompra.SelectedIndex = -1
            TxtFolio.Text = ""
            DgvConceptoGastos.Rows.Clear()
            DgvConceptoGastos.DataSource = Nothing
            txtSubTotal.Text = "0.00"
            txtIVA.Text = "0.00"
            txtTotal.Text = "0.00"
            dtpFechaPago.Value = DateTime.Now
            txtNoFactura.Text = ""
            txtDiasDeCredito.Text = ""
            txtHorasViaje.Text = ""
            txtImporte.Text = ""
            DgvConceptoGastos.AllowUserToAddRows = True
        End If
        HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")
        CargaPantalla = False
        Editar = False
    End Function

    Private Sub Habilitar()
        Me.txtCabezasHembra.Enabled = True
        Me.txtCabezasMachos.Enabled = True
        Me.txtLoteEngorda.Enabled = True
        Me.txtLoteEngorda.Enabled = True
        Me.txtCantCabezas.Enabled = False
        Me.txtKilosEnviados.Enabled = True
        Me.cmbIntroductor.Enabled = True
        Me.txtConductor.Enabled = True
        Me.txtPlacas.Enabled = True
        'Me.txtImporte.Enabled = True
        Me.txtUnidad.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.chkMaquila.Enabled = True
        Me.ChkMultiples.Enabled = True
        Me.CmbTipoGanado.Enabled = True
        Me.txtKilos1erpasada.Enabled = True
        If Editar = True Then Me.txtKilos2daPasada.Enabled = True
        chkBascula.Enabled = True
        Me.cmbComprador.Enabled = True
        Me.cmbProveedor.Enabled = True
        Me.CmbLugarCompra.Enabled = True
        For Each ctl As Control In tabControl.Controls
            ctl.Enabled = True
        Next
        Me.txtHorasViaje.Enabled = True
        txtNoFactura.Enabled = True
        txtImporte.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtCabezasHembra.Enabled = False
        Me.txtCabezasMachos.Enabled = False
        Me.dtpFechaRecepcion.Enabled = False
        Me.txtLoteRecepcion.Enabled = False
        Me.txtUnidad.Enabled = False
        Me.txtLoteEngorda.Enabled = False
        Me.txtCantCabezas.Enabled = False
        Me.txtKilosEnviados.Enabled = False
        Me.cmbIntroductor.Enabled = False
        Me.txtConductor.Enabled = False
        Me.txtPlacas.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtKilos1erpasada.Enabled = False
        Me.txtKilos2daPasada.Enabled = False
        Me.ChkMultiples.Enabled = False
        Me.chkMaquila.Enabled = False
        Me.CmbTipoGanado.Enabled = False
        Me.txtKilos1erpasada.Enabled = False
        Me.txtKilos2daPasada.Enabled = False
        chkBascula.Enabled = False
        Me.cmbComprador.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.CmbLugarCompra.Enabled = False
        For Each ctl As Control In tabControl.Controls
            ctl.Enabled = False
        Next
        Me.txtHorasViaje.Enabled = False
        txtNoFactura.Enabled = False
        txtImporte.Enabled = False
    End Sub


    Private Function CancelarRecepcion() As Boolean
        Dim Sacrificio As New CC.UsrProdRecepcionGanadoDetCollection
        Sacrificio.GetMulti(HC.UsrProdRecepcionGanadoDetFields.LoteRecepcion = Me.RecepcionGanado.LoteRecepcion)
        If Sacrificio.Count > 0 Then
            MsgBox("La Recepción ya está en Sacrificio, Imposible Cancelar la Recepción...", MsgBoxStyle.Exclamation, "Error")
            Return False
        Else
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
            Try
                'cancelacion de recepcion de ganado
                RecepcionGanado.FechaCancelacion = Now
                RecepcionGanado.Estatus = "X"
                RecepcionGanado.IdUsuario = Controlador.Sesion.Usrndx
                RecepcionGanado.Func = "M"
                RecepcionGanado.NumOpc = 1
                Trans.Add(RecepcionGanado.ObtenerEntidad)
                If Not RecepcionGanado.ObtenerEntidad.Save Then
                    Trans.Rollback()
                    Return False
                End If
                Trans.Commit()
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Trans.Rollback()
                Return False
            End Try
        End If
    End Function

    Private Sub Imprimir()
        Try
            Dim Previsualizador As New PreVisualizarForm
            Dim Recepciones As New RecepcionGanadoColeccion
            Recepciones.Add(RecepcionGanado)
            Previsualizador.Reporte = Recepciones.Reporte(Controlador.Sesion.MiUsuario.Usrnom, Controlador.Sesion.MiEmpresa.Empnom, "Producción/Recepción de Ganado")
            Previsualizador.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub ObtenerKilos1erPesada()
    '    Try
    '        If Not Me.SerialPort.IsOpen Then
    '            Me.SerialPort.Open()
    '            If Me.SerialPort.CDHolding Then
    '                If Me.SerialPort.NewLine = "" Then
    '                    MsgBox("No es posible leer el Peso, Favor de Capturarlo...", MsgBoxStyle.Information, "Aviso")
    '                    Me.txtKilos1erpasada.Enabled = True
    '                Else
    '                    Dim kilos As String = Me.SerialPort.NewLine
    '                    Me.txtKilos1erpasada.Text = CDec(kilos).ToString("N2")
    '                    Me.SerialPort.Close()
    '                End If
    '            Else
    '                MsgBox("La Báscula no se encuentra conectada...")
    '                Me.txtKilos1erpasada.Enabled = True
    '                Me.txtKilos1erpasada.Focus()
    '            End If
    '            Me.SerialPort.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error en el Puerto", MsgBoxStyle.OkOnly, "Aviso")
    '    End Try

    'End Sub

    'Private Sub ObtenerKilos2daPesada()
    '    Try
    '        If Not Me.SerialPort.IsOpen Then
    '            Me.SerialPort.Open()
    '            If Me.SerialPort.CDHolding Then
    '                If Me.SerialPort.NewLine = "" Then
    '                    MsgBox("No es posible leer el Peso, Favor de Capturarlo...", MsgBoxStyle.Information, "Aviso")
    '                    Me.txtKilos2daPasada.Enabled = True
    '                Else
    '                    Dim kilos As String = Me.SerialPort.NewLine
    '                    Me.txtKilos2daPasada.Text = CDec(kilos).ToString("N2")
    '                    Me.SerialPort.Close()
    '                End If
    '            Else
    '                MsgBox("La Báscula no se encuentra conectada...")
    '                Me.txtKilos2daPasada.Enabled = True
    '                Me.txtKilos2daPasada.Focus()
    '            End If
    '            Me.SerialPort.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error en el Puerto", MsgBoxStyle.OkOnly, "Aviso")
    '        Me.txtKilos2daPasada.Enabled = True
    '        Me.txtKilos2daPasada.Focus()
    '    End Try
    'End Sub

    Private Sub ObtenerValores()
        Try
            'TipoGanado.Obtener()
            'Me.CmbTipoGanado.DisplayMember = "Descripcion"
            'Me.CmbTipoGanado.ValueMember = "IdTipoGanado"
            'Me.CmbTipoGanado.DataSource = TipoGanado
            'Me.CmbTipoGanado.SelectedIndex = -1

            LlenaComboBox()
            CargaPantalla = False
            Me.txtLoteRecepcion.Text = Me.RecepcionGanado.LoteRecepcion
            Me.txtLoteEngorda.Text = Me.RecepcionGanado.LoteEngorda
            Me.txtKilosEnviados.Text = Me.RecepcionGanado.KilosEnviados.ToString("N3")
            Me.txtKilosRecibidos.Text = Me.RecepcionGanado.KilosRecibidos.ToString("N3")
            Me.txtKilos1erpasada.Text = Me.RecepcionGanado.KilosPrimeraPesada.ToString("N3")
            Me.txtKilos2daPasada.Text = Me.RecepcionGanado.KilosSegundaPesada.ToString("N3")

            txtCabezasMachos.Text = Me.RecepcionGanado.CantCabezas.ToString()
            txtCabezasHembra.Text = "0"


            'Me.cmbIntroductor.ValueMember = "Codigo"
            'Me.cmbIntroductor.DisplayMember = "Nombre"
            'Me.cmbIntroductor.DataSource = Introductores
            'Me.cmbIntroductor.SelectedIndex = -1
            CargaPantalla = True
            Me.cmbIntroductor.SelectedValue = Me.RecepcionGanado.IdCliente
            CargaPantalla = False
            Me.txtUnidad.Text = Me.RecepcionGanado.Unidad
            Me.txtConductor.Text = Me.RecepcionGanado.Conductor
            Me.txtPlacas.Text = Me.RecepcionGanado.Placas
            Me.txtHorasViaje.Text = Me.RecepcionGanado.HorasViaje.ToString("N2")

            'Me.cmbProveedor.SelectedValue = Me.RecepcionGanado.IdProveedor

            Me.CmbLugarCompra.SelectedValue = Me.RecepcionGanado.CveLugarCompra
            Me.cmbComprador.SelectedValue = Me.RecepcionGanado.CveCompradorGanado
            Me.txtObservaciones.Text = Me.RecepcionGanado.Observaciones
            Me.txtCantCabezas.Text = Me.RecepcionGanado.CantCabezas
            Me.CmbTipoGanado.SelectedValue = Me.RecepcionGanado.TipoGanado.IdTipoGanado
            Me.dtpFechaPago.Value = Me.RecepcionGanado.FechaPago
            Me.txtNoFactura.Text = Me.RecepcionGanado.NumFactura
            txtDiasDeCredito.Text = Me.RecepcionGanado.DiasCredito.ToString()

            HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")
            Dim recepGanadoIDe As New ClasesNegocio.RecepcionGanadoClass(RecepcionGanado.LoteRecepcion)



            Dim Gastos As New ClasesNegocio.GastoTransporteClass
            Gastos.Obtener(RecepcionGanado.LoteRecepcion)
            txtSubTotal.Text = (Gastos.ImporteTotal - Gastos.IVA).ToString("N2")
            txtIVA.Text = Gastos.IVA.ToString("N2")
            txtTotal.Text = Gastos.ImporteTotal.ToString("N2")
            DgvConceptoGastos.DataSource = Gastos.Detalle
            DgvConceptoGastos.AllowUserToAddRows = False
            txtImporte.Text = recepGanadoIDe.ImporteComp.ToString("N2")
            'For Each renglon As ClasesNegocio.GastoTransporteDetalleClass In Gastos.Detalle

            'Next

            HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")


            CargaPantalla = True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "Toolbar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        If Not CancelarRecepcion() Then
            MessageBox.Show("No se Pudo Cancelar la Recepción ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Se canceló recepción de ganado con el folio : " & Me.txtLoteRecepcion.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Limpiar(False)
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Consultas As New FrmConsRecepcionGanado
            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.RecepcionGanado = New ClasesNegocio.RecepcionGanadoClass(Consultas.DgvRecepcionGanado.SelectedRows(0).Cells(Consultas.LoteRecepcion.Index).Value.ToString)
                ObtenerValores()
            Else
                Cancelar = True
            End If
            'Recepciones = RecepcionGanado.Obtener(2, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try

    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Me.RecepcionGanado.Estatus = "X" Then
            MsgBox("No se puede editar la Recepción de Animales, se encuentra cancelada", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If
        Editar = True
        'Habilitar()
        Me.txtKilos2daPasada.Enabled = True
        If Me.txtKilos2daPasada.Text = "0" Then
            Me.txtKilos2daPasada.Enabled = True
            'Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
            'ObtenerPeso.Obtener()
            'If ObtenerPeso(0).ObtenerPeso = 1 Then
            '    Me.ObtenerKilos2daPesada()
            'Else
            '    Me.txtKilos2daPasada.Enabled = True
            'End If
        End If
        Editar = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Editar = False Then
                If Not Me.txtKilos1erpasada.Text > 0 Then
                    MsgBox("Ingrese la cantidad de Kilos de la primera pesada para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                End If
                If Not Guardar() Then
                    MessageBox.Show("No se Pudo Guardar la Recepción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Cancelar = True
                Else
                    MessageBox.Show("Se Guardó Recepción con el Folio : " & Me.txtLoteRecepcion.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Me.ChkMultiples.Checked = True Then
                        Me.Limpiar(True)
                        RecepcionGanado = New RecepcionGanadoClass
                        mtb.sbCambiarEstadoBotones("Nuevo")
                        Me.mtb.HabilitarNuevo = True
                    Else
                        Me.Limpiar(False)
                        Deshabilitar()
                    End If
                End If
            Else
                If Not Me.txtKilos2daPasada.Text > 0 Then
                    MsgBox("Ingrese la cantidad de Kilos de la Segunda pesada para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                End If

                RecepcionGanado.KilosPrimeraPesada = CDec(Me.txtKilos1erpasada.Text)
                RecepcionGanado.KilosSegundaPesada = CDec(Me.txtKilos2daPasada.Text)
                RecepcionGanado.KilosRecibidos = RecepcionGanado.KilosPrimeraPesada - RecepcionGanado.KilosSegundaPesada
                RecepcionGanado.KilosComp = RecepcionGanado.KilosPrimeraPesada - RecepcionGanado.KilosSegundaPesada


                'RecepcionGanadoIDE = RecepcionGanado.Clonar()

                If Me.RecepcionGanado.ObtenerEntidad.Save Then
                    '''------GUARDAR EN IDE FOODS
                    ''' 
                    MessageBox.Show("Se Guardó Recepción ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If RecepcionGanado.KilosSegundaPesada > 0D Then
                        Imprimir()
                    End If

                    HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")
                    Dim RecepcionGanadoIDE As New ClasesNegocio.RecepcionGanadoClass(RecepcionGanado.LoteRecepcion)
                    RecepcionGanadoIDE.KilosPrimeraPesada = CDec(Me.txtKilos1erpasada.Text)
                    RecepcionGanadoIDE.KilosSegundaPesada = CDec(Me.txtKilos2daPasada.Text)
                    RecepcionGanadoIDE.KilosComp = RecepcionGanado.KilosPrimeraPesada - RecepcionGanado.KilosSegundaPesada
                    RecepcionGanadoIDE.KilosRecibidos = RecepcionGanado.KilosPrimeraPesada - RecepcionGanado.KilosSegundaPesada
                    If RecepcionGanadoIDE.ObtenerEntidad.Save Then

                        Limpiar(False)
                        Deshabilitar()
                        HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")
                        
                    Else
                        HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")
                    End If
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

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar(False)
        Editar = False
        LlenaComboBox()
        Habilitar()
        RecepcionGanado = New RecepcionGanadoClass
        Me.txtLoteEngorda.Focus()
        'Introductores = New ClientesIntroductoresColeccion
        'Introductores.Obtener(True)
        'Me.cmbIntroductor.ValueMember = "Codigo"
        'Me.cmbIntroductor.DisplayMember = "Nombre"
        'Me.cmbIntroductor.DataSource = Introductores
        'Me.cmbIntroductor.SelectedIndex = -1
        'TipoGanado.Obtener(ClasesNegocio.EstatusDatos.VIGENTE)
        'Me.CmbTipoGanado.DisplayMember = "Descripcion"
        'Me.CmbTipoGanado.ValueMember = "IdTipoGanado"
        'Me.CmbTipoGanado.DataSource = TipoGanado
        'Me.CmbTipoGanado.SelectedIndex = -1

    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar(False)
        Deshabilitar()
    End Sub
#End Region

#Region "Keypress"
    Private Sub dtpFechaRecepcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaRecepcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLoteEngorda.Focus()
        End If
    End Sub

    Private Sub txtLoteEngorda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoteEngorda.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCabezasMachos.Focus()
        End If
    End Sub

    Private Sub txtCantCabezas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantCabezas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKilosEnviados.Focus()
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbIntroductor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtUnidad.Focus()
        End If
    End Sub

    Private Sub txtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidad.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtConductor.Focus()
        End If
    End Sub

    Private Sub txtConductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConductor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPlacas.Focus()
        End If
    End Sub

    Private Sub txtPlacas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlacas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtKilosEnviados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosEnviados.KeyPress

        If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtKilosEnviados.Text.IndexOf(".", 0) > -1) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.txtKilosEnviados.Text <> "" Then
                If IsNumeric(Me.txtKilosEnviados.Text) Then
                    Me.txtKilosEnviados.Text = CDec(Me.txtKilosEnviados.Text).ToString("N2")
                End If
            End If
            Me.txtKilos1erpasada.Enabled = True
            'Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
            'ObtenerPeso.Obtener()
            'If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
            '    Me.ObtenerKilos1erPesada()
            'Else
            '    Me.txtKilos1erpasada.Enabled = True
            '    Me.txtKilos1erpasada.Focus()
            'End If

        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKilosRecibidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.cmbIntroductor.Focus()
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKilos1erpasada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilos1erpasada.KeyPress
        If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtKilos1erpasada.Text.IndexOf(".", 0) > -1) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.txtKilos1erpasada.Text <> "" Then
                If IsNumeric(Me.txtKilos1erpasada.Text) Then
                    Me.txtKilos1erpasada.Text = CDec(Me.txtKilos1erpasada.Text).ToString("N2")
                End If
            Else
                Me.txtKilos1erpasada.Text = "0.00"
            End If
            'Me.txtKilos2daPasada.Focus()
            Me.CmbTipoGanado.Focus()

            'Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
            'ObtenerPeso.Obtener()
            'If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
            '    Me.ObtenerKilos2daPasada()
            'Else
            '    Me.txtKilos2daPasada.Enabled = True
            '    Me.txtKilos2daPasada.Focus()
            'End If
        End If
    End Sub

    Private Sub txtKilos2daPasada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtKilos2daPasada.Text.IndexOf(".", 0) > -1) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.txtKilos2daPasada.Text <> "" Then
                If IsNumeric(Me.txtKilos2daPasada.Text) Then
                    Me.txtKilos2daPasada.Text = CDec(Me.txtKilos2daPasada.Text).ToString("N2")
                    Me.txtKilosRecibidos.Text = (CDec(Me.txtKilos1erpasada.Text) - CDec(Me.txtKilos2daPasada.Text)).ToString("N2")
                End If
            Else
                Me.txtKilos2daPasada.Text = "0.00"
            End If
            Me.CmbTipoGanado.Focus()
        End If
    End Sub
#End Region

    Private Sub RecepcionGanado_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles RecepcionGanado.MensajeError
        MessageBox.Show(mensaje)
    End Sub

    Private Sub chkMaquila_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMaquila.CheckedChanged
        If Me.chkMaquila.Checked = True Then
            Me.LblReferenciaOLote.Text = "Referencia Introductor :"
        Else
            Me.LblReferenciaOLote.Text = "Lote de Engorda :"
        End If
    End Sub

    Private Sub txtKilos2daPasada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not Me.txtKilos2daPasada.Text = "" Then
        '    Me.txtKilosRecibidos.Text = (CDec(Me.txtKilos1erpasada.Text) - CDec(Me.txtKilos2daPasada.Text)).ToString("N2")
        'Else
        '    Me.txtKilosRecibidos.Text = (CDec(Me.txtKilos1erpasada.Text) - CDec(0)).ToString("N2")
        'End If

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        If Me.txtKilos1erpasada.Text = "0" Then
    '            Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
    '            ObtenerPeso.Obtener()
    '            If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
    '                Me.ObtenerKilos1erPesada()
    '            Else
    '                Me.txtKilos1erpasada.Enabled = True
    '                Me.txtKilos1erpasada.Focus()
    '            End If
    '        Else
    '            Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
    '            ObtenerPeso.Obtener()
    '            If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
    '                ObtenerKilos2daPesada()
    '            Else
    '                Me.txtKilos2daPasada.Enabled = True
    '                Me.txtKilos2daPasada.Focus()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error en el Puerto", MsgBoxStyle.OkOnly, "Aviso")
    '        Me.txtKilos2daPasada.Enabled = True
    '        Me.txtKilos2daPasada.Focus()
    '    End Try

    'End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar(False)
    End Sub

    Private Sub CmbTipoGanado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbTipoGanado.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbIntroductor.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLoteEngorda.Focus()
        End If
    End Sub

    Private Sub txtCabezasMachos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCabezasMachos.TextChanged
        Dim numCabezasMachos, numCabezasHembras As Integer

        If Me.txtCabezasHembra.Text.Trim.Length = 0 Then
            numCabezasHembras = 0
        Else
            numCabezasHembras = CInt(Me.txtCabezasHembra.Text)
        End If

        If Me.txtCabezasMachos.Text.Trim.Length = 0 Then
            numCabezasMachos = 0
        Else
            numCabezasMachos = CInt(Me.txtCabezasMachos.Text)
        End If

        Me.txtCantCabezas.Text = numCabezasHembras + numCabezasMachos
    End Sub

    Private Sub txtCabezasHembra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCabezasHembra.TextChanged
        Dim numCabezasMachos, numCabezasHembras As Integer

        If Me.txtCabezasHembra.Text.Trim.Length = 0 Then
            numCabezasHembras = 0
        Else
            numCabezasHembras = CInt(Me.txtCabezasHembra.Text)
        End If

        If Me.txtCabezasMachos.Text.Trim.Length = 0 Then
            numCabezasMachos = 0
        Else
            numCabezasMachos = CInt(Me.txtCabezasMachos.Text)
        End If

        Me.txtCantCabezas.Text = numCabezasHembras + numCabezasMachos
    End Sub

    Private Sub txtCabezasMachos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCabezasMachos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCabezasHembra.Focus()
        End If
    End Sub

    Private Sub txtCabezasHembra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCabezasHembra.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKilosEnviados.Focus()
        End If
    End Sub

    Private Sub CmbTipoGanado_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbTipoGanado.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            TipoGanado.Obtener()
        End If
    End Sub

    Private Sub cmbIntroductor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbIntroductor.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Introductores.Obtener(True)
        End If
    End Sub

#Region "Boton Bascula"
    Private Sub chkBascula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBascula.CheckedChanged
        Try
            If Me.chkBascula.Checked Then
                'Me.TextBox1.Text = ClasesNegocio.LecturaBasculaClass.ObtenerPeso(String.Format("<9  41290   355{0}<9  41285   355{0}<9  41280   355{0}<9  41280   355{0}<9  41275   355{0}<9  41275   355{0}<9  41275   355{0}<9  41280   3", vbNewLine), LecturaBasculaClass.TipoLectura.GRAMOS, LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2")
                Me.txtLeerPeso.OpenPort()
                Me.chkBascula.Text = "Lectura de Bascula Activada"
            Else
                Me.txtLeerPeso.ClosePort()
                Me.chkBascula.Text = "Lectura de Bascula Desactivada"
            End If
        Catch UAex As UnauthorizedAccessException
            MsgBox("No se pudo conectar a la bascula, pruebe que este encendida o que no se este usando una lectura de bascula en otra ventana o aplicación", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Lector de Bascula"
    Private Sub txtLeerPeso_SerialDataArrived(ByVal sender As System.Object, ByVal e As wclTextBoxSerial.SerialDataArrivedEventArgs) Handles txtLeerPeso.SerialDataArrived
        'En e.Data esta el grupo de caracteres recibidos desde el puerto serial
        If e.Data.Length >= 50 Then 'Si llegan 25 caracteres procesarlos
            Dim res As String = (ClasesNegocio.LecturaBasculaClass.ObtenerPeso(e.Data.Substring(0, 50), _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS, _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS)).ToString("N2") 'Se divide entre 10 por q la bascula de cortes arroja 3 decimales

            Dim CampoPesada As TextBox = DetectarCampoPesada()
            If CampoPesada IsNot Nothing Then
                CampoPesada.Text = res
            End If
        Else
            e.Handled = True 'Ignora los caracteres
        End If
    End Sub
#End Region

    Private Function DetectarCampoPesada() As TextBox
        If txtKilos1erpasada.Enabled Then
            Return txtKilos1erpasada
        ElseIf txtKilos2daPasada.Enabled Then
            Return txtKilos2daPasada
        End If
        Return Nothing
    End Function


#Region "Metodos Creados"
    Private Function LlenaComboBox() As Boolean
        Try

            Dim lugares As New LugaresDeCompraCollectionClass
            Dim CompradoresGanadoC As New ClasesNegocio.CompradorGanadoCollectionClass
            Dim ConceptosGasto As New ClasesNegocio.ConceptoGastosTransporteColeccionClass
            Introductores = New ClientesIntroductoresColeccion

            CargaPantalla = False

            Introductores.Obtener(True)
            Me.cmbIntroductor.DataSource = Introductores
            Me.cmbIntroductor.DisplayMember = "Nombre"
            Me.cmbIntroductor.ValueMember = "Codigo"
            Me.cmbIntroductor.SelectedIndex = -1

            TipoGanado.Obtener()
            Me.CmbTipoGanado.DisplayMember = "Descripcion"
            Me.CmbTipoGanado.ValueMember = "IdTipoGanado"
            Me.CmbTipoGanado.DataSource = TipoGanado
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

            Dim proveedores As New CC.ProveedorCollection
            proveedores.GetMulti(HC.ProveedorFields.EsdeGanado = 1 And HC.ProveedorFields.Estatus = 1, 0, New SortExpression(New SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            'llena combo proveedores
            Me.cmbProveedor.DataSource = proveedores
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.ValueMember = "Codigo"
            Me.cmbProveedor.SelectedIndex = -1

            Application.DoEvents()

            CargaPantalla = True
            'Introductores.Obtener(True)
            'Me.cmbIntroductor.ValueMember = "Codigo"
            'Me.cmbIntroductor.DisplayMember = "Nombre"
            'Me.cmbIntroductor.DataSource = Introductores
            'Me.cmbIntroductor.SelectedIndex = -1

            'TipoGanado.Obtener(ClasesNegocio.EstatusDatos.VIGENTE)
            'Me.CmbTipoGanado.DisplayMember = "Descripcion"
            'Me.CmbTipoGanado.ValueMember = "IdTipoGanado"
            'Me.CmbTipoGanado.DataSource = TipoGanado
            'Me.CmbTipoGanado.SelectedIndex = -1


            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function



    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Dim keyCode As Keys = CType(msg.WParam, IntPtr).ToInt32
        Const WM_KEYDOWN As Integer = &H100
        'Const WM_KEYUP As Integer = &H101   in case people need this

        If msg.Msg = WM_KEYDOWN AndAlso keyCode = Keys.Enter Then
            'AndAlso (Me.ActiveControl.GetType.Name = "TextBox" Or Me.ActiveControl.GetType.Name = "ComboBox" Or Me.ActiveControl.GetType.Name = "UltraCombo" Or Me.ActiveControl.GetType.Name = "RadioButton") Then
            SendKeys.Send("{TAB}")
            Return True

        End If
        Return MyBase.ProcessCmdKey(msg, keyData)


    End Function
#End Region

    Private Sub cmbProveedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If cmbProveedor.SelectedIndex <> -1 And CargaPantalla Then
            Dim bandera As Boolean = False
            If HC.DbUtils.ActualConnectionString.Contains("MEATLA20") Then
                If cmbIntroductor.SelectedValue = 2 Then
                    bandera = True
                    'Dim x As String = HC.DbUtils.ActualConnectionString
                    HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")

                End If
            End If

            Dim proveedor As New ClasesNegocio.ProveedorClass(CInt(cmbProveedor.SelectedValue))
            txtDiasDeCredito.Text = proveedor.DiasCredito.ToString()
            dtpFechaPago.Value = DateTime.Now.AddDays(proveedor.DiasCredito)

            Application.DoEvents()
            If bandera Then
                HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")
            End If


        End If

    End Sub

    Private Sub cmbIntroductor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbIntroductor.SelectedIndexChanged
        If cmbIntroductor.SelectedIndex <> -1 And CargaPantalla Then
            Dim bandera As Boolean = False
            If HC.DbUtils.ActualConnectionString.Contains("MEATLA20") Then
                If cmbIntroductor.SelectedValue = 2 Then
                    bandera = True
                    'Dim x As String = HC.DbUtils.ActualConnectionString
                    HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")
                    cmbProveedor.DataSource = Nothing
                End If
            End If

            Dim proveedores As New CC.ProveedorCollection
            proveedores.GetMulti(HC.ProveedorFields.EsdeGanado = 1 And HC.ProveedorFields.Estatus = 1, 0, New SortExpression(New SortClause(HC.ProveedorFields.RazonSocial, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            'llena combo proveedores
            CargaPantalla = False
            Me.cmbProveedor.DataSource = proveedores
            CargaPantalla = True
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.ValueMember = "Codigo"
            Me.cmbProveedor.SelectedIndex = -1

            Application.DoEvents()

            If bandera Then
                HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")
            End If

        End If
    End Sub




    Private Sub txtImporte_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        NumerosyDecimal(txtImporte, e)
    End Sub

    Private Sub txtHorasViaje_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHorasViaje.KeyPress
        NumerosyDecimal(txtHorasViaje, e)
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
        End If

    End Sub

    Private Sub cajaTexto_KeyPress(sender As Object, e As EventArgs)
        NumerosyDecimal(sender, e)
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

    Private Sub txtNoFactura_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub Label33_Click(sender As System.Object, e As System.EventArgs)

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