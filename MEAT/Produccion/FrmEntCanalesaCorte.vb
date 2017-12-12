Imports System.Data.SqlClient
Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmEntCanalesaCorte

#Region "Miembros"

    Dim WithEvents RegistroSacrificiosCab As New RegistroSacrificiosClass
    Dim WithEvents RegistroSacrificiosDet As New RegistroSacrificioDetClass
    Dim RecepDet As RecepcionCanalesDetClass
    Dim DetCanalACorte As DetCanalAcorteClass
    Dim LoteCorte As New CortesClass
    Dim FolioLoteCorte As String
    Dim Almacen As New AlmacenProduccionClass
    Dim AlmacenDetalle As New AlmacenDetalleClass
    Dim Folio As New FoliosClass
    Dim Inventario As New InventarioClass
    Dim Productos As New ProductosClass
    Dim Canales As DataSet
    Dim SacrificioAnterior As String ' campo para cuando se dejen de capturar canales que van a un corte y se requieran capturar mas.
    Dim Sacrificio As DataTable
    Dim LoteCorteAsociadoVariosSacrificios As Boolean
    Dim nuevo As Boolean
    Dim caracteres() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            If Me.txtKilosaCorte.Text.Trim.Length = 0 Then
                MsgBox("Debe ingresar un peso", MsgBoxStyle.Exclamation, "Aviso")
                Return False
                'ElseIf IsNumeric(Me.txtKilosaCorte.Text) Then
                '    Dim peso As Decimal = CDec(Me.txtKilosaCorte.Text)

                '    If peso < 50 OrElse peso > 300 Then
                '        MsgBox("Peso fuera de rango. ""Rango valido 50 a 300 Kgs.""", MsgBoxStyle.Exclamation, "Peso Fuera de Rango")
                '        Return False
                '    End If
            End If

            Dim movimientoAlm As New MovimientoAlmacenClass

            'Dim FolioAlmacen As String

            If Me.dtpFechaCorte.Value.ToShortDateString() <> Me.dtpFechaSacrificio.Value.ToShortDateString() Then
                If MessageBox.Show("La Fecha de Corte es distinta de la Fecha de Sacrificio, ¿Desea Guardarla?", "Confirmar fecha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                    Exit Function
                End If
            End If

            'validar para saber si es necesario generar un nuevo lote de corte            
            If Trim(SacrificioAnterior) = "" Then
                'obtener lote de corte
                Dim CorteActivo As New DataSet

                CorteActivo = LoteCorte.Obtener(3, "")

                If CorteActivo.Tables(0).Rows.Count > 0 Then
                    If Not Controlador.Configuracion.Produccion.TrabajarLotesCortesAbiertos Then
                        For i As Integer = 0 To CorteActivo.Tables(i).Rows.Count - 1
                            If Me.txtLoteSacrificio.Text = CorteActivo.Tables(0).Rows(i)("FolioSacrificio") Then
                                FolioLoteCorte = CorteActivo.Tables(0).Rows(i)("IdFolioLoteCorte")
                            Else
                                MessageBox.Show("Cierre el lote de Sacrificio: " & CorteActivo.Tables(0).Rows(i)("FolioSacrificio"), "Lotes Diferentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Return False
                            End If
                        Next
                    End If
                End If
            Else
                LoteCorte.LoteSacrificio = SacrificioAnterior
            End If

            If Trim(Me.txtLoteCorte.Text) = "" Or Me.txtLoteCorte.Text = "NUEVO" Then
                If MessageBox.Show("Esta apunto de crear un nuevo lote de corte. ¿Esta seguro que quiere continuar?", "Crear Lote de Corte Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Return False
                End If

                Dim col As New CC.MscloteCortesCabCollection
                Dim nuevoLote As String
                Dim lote As New EC.MscloteCortesCabEntity

                Do
                    nuevoLote = CrearLote()

                    If col.GetDbCount(HC.MscloteCortesCabFields.LoteCorte = nuevoLote) = 0 Then
                        Exit Do
                    End If
                Loop

                With lote
                    .LoteCorte = nuevoLote
                    .FechaCorte = Me.dtpFechaCorte.Value
                    .FechaCad = .FechaCorte.AddDays(30)
                    .Estatus = "A"
                    .DiasCad = 30
                    .IdCliente = CInt(Me.txtCodCliente.Text)
                    .LoteSacrificio = Me.txtLoteSacrificio.Text
                End With

                Trans.Add(lote)

                lote.Save()

                Me.LoteCorte.LoteCorte = nuevoLote
                'LoteCorte.LoteCorte = Me.txtLoteCorte.Text
                'LoteCorte.FechaCorte = Me.dtpFechaCorte.Value
                'LoteCorte.FechaCaptura = Now
                'LoteCorte.FechaCad = Me.dtpFechaCorte.Value.AddDays(30)
                'LoteCorte.Estatus = "A"
                'LoteCorte.DiasCad = 30
                'LoteCorte.IdCliente = Me.txtCodCliente.Text
                'LoteCorte.LoteSacrificio = Me.txtLoteSacrificio.Text
                'LoteCorte.Func = "I"
                'LoteCorte.NumOpc = 2

                'If Not LoteCorte.Guardar(Trans) Then
                '    Trans.Rollback()
                '    Return False
                'End If

                FolioLoteCorte = LoteCorte.LoteCorte
                txtLoteCorte.Text = FolioLoteCorte
            End If

            Me.RecepDet = New RecepcionCanalesDetClass
            Me.RecepDet.FolioMov = Canales.Tables(0).Rows(0)("FolioMovimiento")
            Me.RecepDet.FolioSacrificio = Canales.Tables(0).Rows(0)("FolioSacrificio")
            Me.RecepDet.IdFolioCanal = Canales.Tables(0).Rows(0)("IdFolioCanal")
            Me.RecepDet.Consecutivo = Canales.Tables(0).Rows(0)("Consecutivo")
            Me.RecepDet.Estatus = EstatusCanal.EN_CORTE '"T"
            Me.RecepDet.Funcion = "M"
            Me.RecepDet.Opcion = 2

            If Not Me.RecepDet.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
            movimientoAlm.FechaMovimiento = Now
            movimientoAlm.FechaCaptura = Now
            movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Canal_A_Corte)
            movimientoAlm.Kilos = Me.txtKilosaCorte.Text
            movimientoAlm.Piezas = 1
            movimientoAlm.Estatus = EstatusChar.VIGENTE
            movimientoAlm.QuienCancelo = ""
            movimientoAlm.IdPoliza = ""
            movimientoAlm.QuienContabilizo = ""
            movimientoAlm.ObservacionCancela = ""

            movimientoAlm.AgregarCanalAlDetalle(CDec(Me.txtKilosaCorte.Text), 1, 0D, 0D)

            If Not movimientoAlm.Guardar(Trans) Then
                Trans.Rollback()
                MsgBox("Ocurrio un error al momento de guardar el movimeinto de almacèn", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            DetCanalACorte = New DetCanalAcorteClass
            DetCanalACorte.FolioLoteCorte = Me.txtLoteCorte.Text 'FolioLoteCorte
            DetCanalACorte.FolioSacrificio = Me.txtLoteSacrificio.Text
            DetCanalACorte.FolioCanal = Canales.Tables(0).Rows(0)("IdFolioCanal")
            DetCanalACorte.Lado = Me.txtLado.Text
            DetCanalACorte.KgrsEnCorte = Me.txtKilosaCorte.Text
            DetCanalACorte.Estatus = "V"
            DetCanalACorte.IdFolioMovimientoAlmacen = movimientoAlm.FolioMovimiento
            DetCanalACorte.Entidad.IdUsuarioAlta = Controlador.Sesion.Usrndx

            If Not DetCanalACorte.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            Trans.Commit()

            Limpiar()

            Me.ObtenerCanales()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function Limpiar() As Boolean
        'Me.GroupBox2.Enabled = False
        Me.txtLado.Text = "1"
        Me.txtLoteSacrificio.Text = ""
        Me.txtNoRes.Text = "1"
        Me.txtFolioCanal.Text = ""
        Me.txtTotalCanales.Text = "0"
        Me.txtTotalKilos.Text = "0"
        Me.txtNoCanales.Text = "0"
        Me.txtKilosaCorte.Text = "0"
        Me.txtProductor.Text = ""
        Me.txtCodCliente.Text = "0"
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = False
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.txtKilosaCorte.Enabled = False
        Me.txtLoteRastro.Clear()
        'Me.GroupBox2.Enabled = False
    End Function

    Private Function Buscar() As Boolean
        Try
            Dim Ventana As New _960BusquasedaLotesDeCortes
            Ventana.Icon = Me.Icon
            Ventana.gbEstatus.Enabled = False
            Ventana.chkVigentes.Checked = True
            Ventana.chkCerrado.Checked = False
            Ventana.gbTipoLote.Enabled = False
            Ventana.chkProduccion.Checked = True
            Ventana.chkReproceso.Checked = False

            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtLoteCorte.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
                Me.dtpFechaCorte.Value = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmFechaCorte.Index).Value
                SacrificioAnterior = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteSacrificio.Index).Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function Imprimir() As Boolean
    End Function

    Private Function ObtenerCanales() As Boolean
        'If Me.RecepDet Is Nothing Then
        '    Return False
        'End If

        Try
            'Dim SumCanales = New DataSet
            Dim lote As String = Me.txtLoteCorte.Text
            Dim tb As New DataTable
            Dim kilos As Decimal

            If Me.txtLoteCorte.Text = "NUEVO" Or Me.txtLoteCorte.Text.Trim = "" Then
                Exit Function
            End If

            Dim consulta As String = "SELECT	Rec.KgrsCalientes, " & _
                                                "Det.KgrsEnCorte, " & _
                                                "CAST(SUBSTRING(Det.IdFolioCanal, 0, CHARINDEX('-', Det.IdFolioCanal)) AS INT) " & _
                                                "AS Res, Det.Lado, " & _
                                                "Det.FolioSacrificio, " & _
                                                "Det.IdFolioCanal, " & _
                                                "Det.IdFolioMovimientoAlmacen, " & _
                                                "Det.IdFolioLoteCorte, " & _
                                                "Rec.FolioMovimiento, " & _
                                                "Rec.Consecutivo " & _
                                    "FROM        MSCRecepcionCanalesDet AS Rec INNER JOIN " & _
                                                "MSCDetCanalACorte AS Det ON Rec.FolioSacrificio = " & _
                                                "Det.FolioSacrificio And Rec.IdFolioCanal = Det.IdFolioCanal " & _
                                    "WHERE		( Det.Estatus='V' AND Det.IdFolioLoteCorte ='" & Me.txtLoteCorte.Text.Trim & "')"



            Using ad As New SqlDataAdapter(New SqlCommand(consulta, New SqlConnection(HC.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()

                ad.Fill(tb)

                ad.SelectCommand.Connection.Close()
            End Using

            For Each dr As DataRow In tb.Rows
                kilos += CDec(dr("KgrsEnCorte"))
            Next

            Me.txtTotalCanales.Text = tb.Rows.Count
            Me.txtTotalKilos.Text = kilos.ToString("N3")

            Me.dgvCanales.AutoGenerateColumns = False
            Me.dgvCanales.DataSource = tb

            'SumCanales = Me.RecepDet.Obtener(5, Me.txtLoteSacrificio.Text, "", Me.dtpFechaCorte.Value, lote)

            'If Canales.Tables(0).Rows.Count > 0 Then
            '    Me.dgvCanales.AutoGenerateColumns = False
            '    Me.dgvCanales.DataSource = SumCanales.Tables(0)
            '    Me.txtTotalCanales.Text = Me.dgvCanales.Rows.Count

            '    Dim kilos As Decimal = 0D

            '    For i As Integer = 0 To Me.dgvCanales.Rows.Count - 1
            '        kilos += CDec(Me.dgvCanales.Rows(i).Cells("KilosBascula").Value)
            '    Next

            '    Me.txtTotalKilos.Text = kilos.ToString("N3") 'CDec(Me.txtTotalKilos.Text + Me.dgvCanales.Rows(i).Cells("KilosBascula").Value).ToString("N3")
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub ConfigurarPuerto()
        txtlectorPeso.Port = 1 'Abro el com2
        txtlectorPeso.BaudRate = 9600 '9600 bits por segundo
        txtlectorPeso.DataBit = 8  '8 bits de datos
        txtlectorPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1 'Un bit de parada
        txtlectorPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None 'No paridad
        txtlectorPeso.TimeOut = 1500 'Esperar 1500 milisegundos antes de considerar time out

        'Esperar 300 milisegundos para dar tiempo a que llegue un grupo de bytes.
        'A menor tiempo menor es el número de bytes que llegan en cada llamada del evento SerialDataArrived.
        'Por ejemplo un lector que envia 14 bytes podrian llegar en la primer llamada al evento 7 caracteres y 
        'en otra llamada otros 7. Dando mayor tiempo damos oportunidad a que lleguen los 14 bytes juntos.
        txtlectorPeso.TimeToWaitForMoreData = 500

        'Puede mostrar la información con formato Ascii, Hexadecimal o Decimal. 
        'Por ejemplo si se recibe la cadena HOLA la salida sería:
        'ASCII: HOLA
        'Decimal:  072079076065
        'Hexadecimal: 484F4C41
        txtlectorPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii 'Formato en que se mostrará la información
    End Sub

    Private Function CrearLote() As String
        Try
            Dim rnd As New Random

            Return Me.caracteres(rnd.Next(0, 25)) & Me.caracteres(rnd.Next(0, 25)) & _
                    Me.caracteres(rnd.Next(0, 25)) & Me.caracteres(rnd.Next(0, 25)) & _
                    Me.caracteres(rnd.Next(0, 25)) & Me.caracteres(rnd.Next(0, 25))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return ""
        End Try
    End Function
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub FrmEntCanalesaCorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Limpiar()
            'validar si se trabajara con un lote de corte asociado a varios lotes de sacrificio
            'verdadero varios lotes de sacrificio
            'falso solo un lote de sacrificio por lote de corte. (pueden se dos lotes de corte, por fecha diferente)            
            LoteCorteAsociadoVariosSacrificios = False

            If Controlador.Configuracion.Produccion.LoteCorteAsociado Then
                LoteCorteAsociadoVariosSacrificios = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Caja de Texto"
    Private Sub txtKilosaCorte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosaCorte.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.Guardar() Then
                MessageBox.Show("Se guardó canal para lote de corte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtLoteSacrificio.Focus()
            End If
        End If

        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFolioCanal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioCanal.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "-"c Then
                e.Handled = True
            End If

            If e.KeyChar = Chr(13) Then
                Canales = New DataSet
                Me.RecepDet = New RecepcionCanalesDetClass
                Canales = Me.RecepDet.Obtener(6, "", Me.txtFolioCanal.Text, Now)

                If Canales.Tables(0).Rows.Count = 0 Then
                    MessageBox.Show("No se tienen canales para este lote de sacrificio", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'Canales = RecepDet.Obtener(1, "", Me.txtFolioCanal.Text)
                    'If Canales.Tables(0).Rows.Count = 0 Then
                    '    MessageBox.Show("No existe folio de canal para enviarlo a corte", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Else
                    If Not IsDBNull(Canales.Tables(0).Rows(0)("idCliente")) AndAlso Not CInt(Canales.Tables(0).Rows(0)("idCliente")) = 0 Then
                        MsgBox("No se puede seleccionar este canal porque esta asociado a un cliente", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If

                    Me.txtLoteSacrificio.Text = Canales.Tables(0).Rows(0)("FolioSacrificio")

                    Dim Cad As String = Canales.Tables(0).Rows(0)("idFolioCanal")
                    Dim NumRes As String = Microsoft.VisualBasic.Left(Cad, Cad.IndexOf("-"))

                    Me.txtLado.Text = Canales.Tables(0).Rows(0)("Lado")
                    Me.txtNoRes.Text = NumRes
                    Me.dtpFechaSacrificio.Value = Canales.Tables(0).Rows(0)("FechaSacrificio")
                    Me.txtProductor.Text = Canales.Tables(0).Rows(0)("Nombre")
                    Me.txtCodCliente.Text = Canales.Tables(0).Rows(0)("Cliente")
                    'Me.txtFolioCanal.Text = Canales.Tables(0).Rows(0)("CodigoBarra")
                    'End If

                    Dim RecepCab As New IntegraLab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection

                    RecepCab.GetMulti(HC.MscrecepcionCanalesCabFields.FolioMovimiento = _
                                        Canales.Tables(0).Rows(0)("FolioMovimiento") And _
                                        HC.MscrecepcionCanalesCabFields.FolioSacrificio = _
                                        Me.txtLoteSacrificio.Text And _
                                        HC.MscrecepcionCanalesCabFields.Estatus = "V")

                    Dim Recep As IntegraLab.ORM.EntityClasses.MscrecepcionCanalesCabEntity = RecepCab(0)
                    Me.txtNoCanales.Text = Recep.CantCanales

                    Dim sacrifiC As New CC.MscregistroSacrificioCabCollection
                    Dim valor As Object

                    valor = sacrifiC.GetScalar(IntegraLab.ORM.MscregistroSacrificioCabFieldIndex.IdFolioRastro, New OC.Expression(HC.MscregistroSacrificioCabFields.IdFolioRastro), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, HC.MscregistroSacrificioCabFields.IdFolioSacrificio = Me.txtLoteSacrificio.Text.Trim)

                    If Not (valor Is Nothing OrElse DBNull.Value.Equals(valor)) Then
                        Me.txtLoteRastro.Text = valor
                    End If

                    If Not DBNull.Value.Equals(Canales.Tables(0).Rows(0)("KgrsCalientes")) Then
                        Me.txtKilosaCorte.Text = CDbl(Canales.Tables(0).Rows(0)("KgrsCalientes"))
                    End If

                    ObtenerCanales()
                    Me.txtKilosaCorte.Focus()
                    Me.txtKilosaCorte.Enabled = Not Me.chkActivarLectura.Checked
                    Me.txtKilosaCorte.SelectAll()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFolioCanal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioCanal.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim ventana As New FrmBusqCanalesAcorte

                ventana.SinClientes = True

                If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtFolioCanal.Text = ventana.DgvCanales.SelectedRows(0).Cells(ventana.clmCodBarras.Index).Value
                    Me.txtLoteSacrificio.Text = ventana.DgvCanales.SelectedRows(0).Cells(ventana.clmFolioSacrificio.Index).Value
                    Canales = New DataSet
                    Me.RecepDet = New RecepcionCanalesDetClass
                    Canales = Me.RecepDet.Obtener(6, "", Me.txtFolioCanal.Text, Now)

                    If Canales.Tables(0).Rows.Count = 0 Then
                        MessageBox.Show("No se tienen canales para este lote de sacrificio", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim Cad As String = Canales.Tables(0).Rows(0)("idFolioCanal")
                        Dim NumRes As String = Microsoft.VisualBasic.Left(Cad, Cad.IndexOf("-"))
                        Me.txtLado.Text = Canales.Tables(0).Rows(0)("Lado")
                        Me.txtNoRes.Text = NumRes

                        If Not DBNull.Value.Equals(Canales.Tables(0).Rows(0)("FechaSacrificio")) Then
                            Me.dtpFechaSacrificio.Value = Canales.Tables(0).Rows(0)("FechaSacrificio")
                        End If

                        Me.txtProductor.Text = Canales.Tables(0).Rows(0)("Nombre")
                        Me.txtFolioCanal.Text = Canales.Tables(0).Rows(0)("CodigoBarra")

                        If Not DBNull.Value.Equals(Canales.Tables(0).Rows(0)("Cliente")) Then
                            Me.txtCodCliente.Text = Canales.Tables(0).Rows(0)("Cliente")
                        Else
                            Me.txtCodCliente.Text = 0
                        End If

                        If Not DBNull.Value.Equals(Canales.Tables(0).Rows(0)("KgrsCalientes")) Then
                            Me.txtKilosaCorte.Text = CDbl(Canales.Tables(0).Rows(0)("KgrsCalientes"))
                        End If

                        'End If
                        Dim RecepCab As New IntegraLab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection

                        RecepCab.GetMulti(HC.MscrecepcionCanalesCabFields.FolioMovimiento = ventana.DgvCanales.SelectedRows(0).Cells(ventana.ClmFolioMov.Index).Value And _
                        HC.MscrecepcionCanalesCabFields.FolioSacrificio = Me.txtLoteSacrificio.Text And HC.MscrecepcionCanalesCabFields.Estatus = "V")

                        Dim Recep As IntegraLab.ORM.EntityClasses.MscrecepcionCanalesCabEntity

                        If RecepCab.Count > 0 Then
                            Recep = RecepCab(0)
                            Me.txtNoCanales.Text = Recep.CantCanales
                        End If

                        Dim sacrifiC As New CC.MscregistroSacrificioCabCollection
                        Dim valor As Object

                        valor = sacrifiC.GetScalar(IntegraLab.ORM.MscregistroSacrificioCabFieldIndex.IdFolioRastro, New OC.Expression(HC.MscregistroSacrificioCabFields.IdFolioRastro), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, HC.MscregistroSacrificioCabFields.IdFolioSacrificio = Me.txtLoteSacrificio.Text.Trim)

                        If Not (valor Is Nothing OrElse DBNull.Value.Equals(valor)) Then
                            Me.txtLoteRastro.Text = valor
                        End If

                        ObtenerCanales()

                        Me.txtKilosaCorte.Focus()
                        Me.txtKilosaCorte.Enabled = Not Me.chkActivarLectura.Checked
                        Me.txtKilosaCorte.SelectAll()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Grid"
    Private Sub dgvCanales_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvCanales.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgvCanales.SelectedRows.Count > 0 Then
                If MessageBox.Show("¿Quiere cancelar la entrada del canal " & Me.dgvCanales.Rows(Me.dgvCanales.CurrentRow.Index).Cells(Me.clmFolioCanal.Index).Value & " a Corte?", "Cancelar Entrada de Canal a Corte", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelar Canal a Corte")

                Try
                    Dim movimientoAlm As New ClasesNegocio.MovimientoAlmacenClass
                    Dim canales As DataTable = DirectCast(Me.dgvCanales.DataSource, DataTable)

                    Me.RecepDet = New RecepcionCanalesDetClass
                    Me.RecepDet.FolioMov = Me.dgvCanales.CurrentRow.Cells(Me.clmFolioMovimiento.Index).Value.ToString.Trim
                    Me.RecepDet.FolioSacrificio = Me.dgvCanales.CurrentRow.Cells(Me.clmFolioSacrificio.Index).Value.ToString.Trim
                    Me.RecepDet.IdFolioCanal = Me.dgvCanales.CurrentRow.Cells(Me.clmFolioCanal.Index).Value.ToString.Trim
                    Me.RecepDet.Consecutivo = Me.dgvCanales.CurrentRow.Cells(Me.clmConsecutivo.Index).Value.ToString.Trim
                    Me.RecepDet.Estatus = EstatusCanal.VIGENTE '"T"
                    Me.RecepDet.Funcion = "M"
                    Me.RecepDet.Opcion = 2

                    If Not Me.RecepDet.Guardar(trans) Then
                        trans.Rollback()
                        MsgBox("Ocurrio un error al actualizar el canal recepcionado", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If

                    movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
                    movimientoAlm.FechaMovimiento = Now
                    movimientoAlm.FechaCaptura = Now
                    movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Canal_X_Cancelacion_Canal_A_Corte)
                    movimientoAlm.Kilos = Me.dgvCanales.CurrentRow.Cells(Me.KilosBascula.Index).Value
                    movimientoAlm.Piezas = 1
                    movimientoAlm.Estatus = EstatusChar.VIGENTE
                    movimientoAlm.QuienCancelo = ""
                    movimientoAlm.IdPoliza = ""
                    movimientoAlm.QuienContabilizo = ""
                    movimientoAlm.ObservacionCancela = ""
                    movimientoAlm.FolioMovmientoReferencia = Me.dgvCanales.CurrentRow.Cells(Me.clmFolioMovimientoAlmacen.Index).Value.ToString.Trim

                    movimientoAlm.AgregarCanalAlDetalle(CDec(Me.txtKilosaCorte.Text), 1, 0D, 0D)

                    If Not movimientoAlm.Guardar(trans) Then
                        trans.Rollback()
                        MsgBox("Ocurrio un error al momento de guardar el movimeinto de almacèn", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If

                    Dim entDetCanCorte As New EC.MscdetCanalAcorteEntity

                    trans.Add(entDetCanCorte)

                    entDetCanCorte.FetchUsingPK(Me.txtLoteCorte.Text.Trim, _
                                                        Me.dgvCanales.CurrentRow.Cells(Me.clmFolioSacrificio.Index).Value.ToString.Trim, _
                                                        dgvCanales.CurrentRow.Cells(Me.clmFolioCanal.Index).Value.ToString.Trim, _
                                                        Me.dgvCanales.CurrentRow.Cells(Me.clmFolioMovimientoAlmacen.Index).Value.ToString.Trim)

                    DetCanalACorte = New DetCanalAcorteClass(entDetCanCorte)

                    'DetCanalACorte.FolioLoteCorte = Me.txtLoteCorte.Text 'FolioLoteCorte
                    'DetCanalACorte.FolioSacrificio = canales.Rows(Me.dgvCanales.CurrentRow.Index)("FolioSacrificio")
                    'DetCanalACorte.FolioCanal = canales.Rows(Me.dgvCanales.CurrentRow.Index)("IdFolioCanal")
                    'DetCanalACorte.Lado = Me.txtLado.Text
                    'DetCanalACorte.KgrsEnCorte = Me.txtKilosaCorte.Text
                    DetCanalACorte.Estatus = "C"
                    DetCanalACorte.IdFolioMovimeintoAlmacenCancelacion = movimientoAlm.FolioMovimiento
                    DetCanalACorte.Entidad.IdusaurioCancelacion = Controlador.Sesion.Usrndx
                    DetCanalACorte.Entidad.FechaCancelacion = Now
                    'DetCanalACorte.IdFolioMovimientoAlmacen = movimientoAlm.FolioMovimiento

                    If Not DetCanalACorte.Guardar(trans) Then
                        trans.Rollback()
                        MsgBox("Ocurrio un error al cambiar el estatus al canal en corte", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If

                    trans.Commit()
                    MsgBox("Canal cancelado", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Me.ObtenerCanales()

                Catch ex As Exception
                    trans.Rollback()

#If CONFIG = "Debug" Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                    MsgBox("Ocurrio un error al querer borrar el canal a corte", MsgBoxStyle.Critical, "Error")
#End If
                End Try
            End If
        End If
    End Sub
#End Region

#Region "Bonotes"

#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New _960BusquasedaLotesDeCortes
            Ventana.Icon = Me.Icon

            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtLoteCorte.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
                Me.dtpFechaCorte.Value = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmFechaCorte.Index).Value
                SacrificioAnterior = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteSacrificio.Index).Value
                Me.ObtenerCanales()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = False
        Me.mtb.HabilitarSalir = True
        Me.GroupBox2.Enabled = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If Not Guardar() Then
            'MessageBox.Show("No se pudo guardar tipo de corral", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Se guardo canal en corte  ", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.txtLoteCorte.Text = "NUEVO"
        nuevo = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "Otros"
    Private Sub chkActivarLectura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivarLectura.CheckedChanged
        Try
            If Me.chkActivarLectura.Checked Then
                Me.txtlectorPeso.Port = 4
                Me.txtlectorPeso.OpenPort()
                Me.chkActivarLectura.Text = "Lectura de Peso Activada"
                Me.txtKilosaCorte.ReadOnly = True
                Me.txtKilosaCorte.Focus()
            Else
                Me.txtlectorPeso.ClosePort()
                Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
                Me.txtKilosaCorte.ReadOnly = False
                Me.txtKilosaCorte.Focus()
            End If
        Catch UAex As UnauthorizedAccessException
            MsgBox("No se pudo conectar a la bascula, pruebe que este encendida o que no se este usando una lectura de bascula en otra ventana o aplicación", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtKilosaCorte_SerialDataArrived(ByVal sender As System.Object, ByVal e As wclTextBoxSerial.SerialDataArrivedEventArgs) Handles txtlectorPeso.SerialDataArrived
        'En e.Data esta el grupo de caracteres recibidos desde el puerto serial
        If e.Data.Length >= 50 Then 'Si llegan 25 caracteres procesarlos
            Dim res As String = ClasesNegocio.LecturaBasculaClass.ObtenerPeso(e.Data.Substring(0, 50), _
                                LecturaBasculaClass.TipoLectura.GRAMOS, _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2") 'Solo deja pasar 19 caracteres
            Me.txtKilosaCorte.Text = res
        Else
            e.Handled = True 'Ignora los caracteres
        End If
    End Sub
#End Region
#End Region

    Private Sub dtpFechaCorte_KeyPress(ByVal sender As System.Object, _
            ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaCorte.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKilosaCorte.Focus()
            Me.txtKilosaCorte.SelectAll()
        End If
    End Sub
End Class