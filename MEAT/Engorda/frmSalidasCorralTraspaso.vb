Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmSalidasCorralTraspaso
    Inherits MeatForm

#Region "Miembros"
    Dim Estado As New FormState
    Private SalidaGanado As SalidaGanadoCabeceroClass = Nothing
    Private DetalleSalidas As LoteDetCollectionClass = Nothing
    Private DetalleEntradas As LoteDetCollectionClass = Nothing
    Private Lotes As LoteCollectionClass = Nothing
#End Region

#Region "Metodos"
    Public Overrides Sub InicializarForma()
        'Establecer acciones del menu
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "001101111"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "100100001"
        tbEstados.StateNuevo = "011010001"
        tbEstados.StateGuardar = "100100001"
        tbEstados.StateBorrar = "100100001"
        tbEstados.StateEditar = "001011001"
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""
        Me.tbrMenu.ToolBarButtonStatus = tbEstados
        Me.tbrMenu.sbCambiarEstadoBotones("Cancelar")

        dgvLoteSalida.AutoGenerateColumns = False
        dgvLoteEntrada.AutoGenerateColumns = False
        Modo(False)
        Lotes = Controlador.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
        Limpiar()
    End Sub

    Public Overrides Sub Modo(ByVal Edicion As Boolean)
        dtpFecha.Enabled = Edicion
        cmbLoteSalida.Enabled = Edicion
        cmbLoteEntrada.Enabled = Edicion

        If Not Edicion Then
            btnDerecha.Enabled = Edicion
            btnIzquierda.Enabled = Edicion
            btnTodosDerecha.Enabled = Edicion
            btnTodosIzquierda.Enabled = Edicion
        End If
    End Sub

    Private Sub LimpiarSalidas()
        If DetalleEntradas IsNot Nothing Then
            DetalleEntradas.Clear()
        End If

        If DetalleSalidas IsNot Nothing Then
            DetalleSalidas.Clear()
        End If

        txtTransCabezas.Text = 0
        txtTransImporte.Text = 0
        txtTransKilos.Text = 0
    End Sub

    Private Sub RefrescarLoteSalida()
        Dim KilosLoteSalida As Decimal = 0D, KilosLoteEntrada As Decimal = 0D
        Dim ImporteLoteSalida As Decimal = 0D, ImporteLoteEntrada As Decimal = 0D
        Dim CabezasLoteEntrada As Integer = 0

        LimpiarSalidas()

        If cmbLoteSalida.SelectedItem IsNot Nothing Then
            For Each LoteDetalle As LoteDetClass In CType(cmbLoteSalida.SelectedItem, LoteClass).Detalles_Vigentes
                If LoteDetalle.Estatus = LoteDetClass.EstatusLoteDetalle.VIGENTE Then
                    DetalleSalidas.Add(LoteDetalle)
                    KilosLoteSalida += LoteDetalle.KilosEntrada
                    ImporteLoteSalida += Decimal.Round(LoteDetalle.ImporteTotal, 2)
                End If
            Next
        End If

        txtLotSalCabezas.Text = dgvLoteSalida.Rows.Count
        txtLotSalKilos.Text = KilosLoteSalida.ToString("N2")
        txtLotSalImporte.Text = ImporteLoteSalida.ToString("C2")

        If cmbLoteEntrada.SelectedItem IsNot Nothing Then
            For Each LoteDetalle As LoteDetClass In CType(cmbLoteEntrada.SelectedItem, LoteClass).Detalles_Vigentes
                If LoteDetalle.Estatus = 1 Then
                    CabezasLoteEntrada += 1
                    KilosLoteEntrada += LoteDetalle.KilosEntrada
                    ImporteLoteEntrada += Decimal.Round(LoteDetalle.ImporteTotal, 2)
                End If
            Next
        End If

        If cmbLoteSalida.SelectedItem IsNot Nothing AndAlso cmbLoteSalida.SelectedItem.Detalles_Vigentes.Count > 0 AndAlso cmbLoteEntrada.SelectedItem IsNot Nothing Then
            btnDerecha.Enabled = True
            btnTodosDerecha.Enabled = True
            ultgrpCabezas.Enabled = True
        Else
            btnDerecha.Enabled = False
            btnTodosDerecha.Enabled = False
            ultgrpCabezas.Enabled = False
        End If

        txtLotEntCabezas.Text = CabezasLoteEntrada
        txtLotEntKilos.Text = KilosLoteEntrada.ToString("N2")
        txtLotEntImporte.Text = Decimal.Round(ImporteLoteEntrada, 2).ToString("C2")

        btnIzquierda.Enabled = False
        btnTodosIzquierda.Enabled = False
    End Sub

    Public Sub Validar()
        If cmbLoteSalida.SelectedItem Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_CORRAL_TRANSFERENCIA, 0)
        ElseIf cmbLoteEntrada.SelectedItem Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 0)
        ElseIf Not dgvLoteEntrada.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_CORRAL_TRANSFERENCIA, 1)
        End If
    End Sub

    Private Sub RecargarLotesEntrada()
        cmbLoteEntrada.ValueMember = "IdLote"
        cmbLoteEntrada.DisplayMember = "Descripcion"
        cmbLoteEntrada.Items.Clear()

        For Each Lote As LoteClass In Lotes
            If cmbLoteSalida.SelectedItem Is Nothing OrElse cmbLoteSalida.SelectedItem.IdLote <> Lote.IdLote Then
                cmbLoteEntrada.Items.Add(Lote)
            End If
        Next
    End Sub

    Private Sub RecargarLotesSalida()
        cmbLoteSalida.ValueMember = "IdLote"
        cmbLoteSalida.DisplayMember = "Descripcion"
        cmbLoteSalida.Items.Clear()

        For Each Lote As LoteClass In Lotes
            If cmbLoteEntrada.SelectedItem Is Nothing OrElse cmbLoteEntrada.SelectedItem.IdLote <> Lote.IdLote Then
                cmbLoteSalida.Items.Add(Lote)
            End If
        Next
    End Sub
#End Region

#Region "Acciones_Menu"

    Public Overrides Function Buscar() As Boolean
        Dim frmCorralesReciba As New frmBusquedaCorralesporTransferencia
        Estado = FormState.Buscar
        Limpiar()

        If frmCorralesReciba.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SalidaGanado = CType(frmCorralesReciba.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
            txtFolio.Text = SalidaGanado.Folio
            dtpFecha.Value = SalidaGanado.Fecha
            lblEstatus.Text = SalidaGanado.Estatus.ToString()

            DetalleEntradas = New LoteDetCollectionClass()
            'DetalleSalidas = New LoteDetCollectionClass()
            'dgvLoteSalida.DataSource = DetalleSalidas
            dgvLoteEntrada.DataSource = DetalleEntradas

            Lotes = Controlador.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
            RecargarLotesSalida()

            For i As Integer = 0 To cmbLoteSalida.Items.Count - 1
                If cmbLoteSalida.Items(i).IdLote = SalidaGanado.LoteOrigen.IdLote Then
                    cmbLoteSalida.SelectedIndex = i
                End If
            Next

            RecargarLotesEntrada()

            For i As Integer = 0 To cmbLoteEntrada.Items.Count - 1
                If cmbLoteEntrada.Items(i).IdLote = SalidaGanado.LoteDestino.IdLote Then
                    cmbLoteEntrada.SelectedIndex = i
                End If
            Next

            For Each Detalle As SalidaGanadoDetalleClass In SalidaGanado.Detalles
                DetalleEntradas.Add(New LoteDetClass(Detalle.McecatLotesDet))
            Next

            txtTransCabezas.Text = SalidaGanado.Cabezas
            txtTransKilos.Text = SalidaGanado.Kilos.ToString("N2")
            txtTransImporte.Text = SalidaGanado.CostoMovto.Value.ToString("C2")

            Modo(False)
            Return True
        End If
    End Function

    Public Overrides Function Limpiar() As Boolean
        Dim EstAnterior As FormState = Me.Estado
        Me.Estado = FormState.Limpiar

        cmbLoteSalida.SelectedIndex = -1
        cmbLoteSalida.Text = "Seleccione el Lote de Salida"
        txtCorralSalida.ResetText()
        cmbLoteEntrada.SelectedIndex = -1
        cmbLoteEntrada.Text = "Seleccione el Lote de Entrada"
        txtCorralEntrada.ResetText()
        dtpFecha.Value = Now
        btnDerecha.Enabled = False
        btnIzquierda.Enabled = False
        btnTodosDerecha.Enabled = False
        btnTodosIzquierda.Enabled = False
        ultgrpCabezas.Enabled = False
        ulttxtCabezas.Value = Nothing
        RefrescarLoteSalida()

        If EstAnterior = FormState.Nuevo _
        AndAlso Not Controlador.Configuracion.Engorda.RequerirArete Then
            ultgrpCabezas.Visible = True
        Else
            ultgrpCabezas.Visible = False
        End If

        Me.Estado = EstAnterior
        Return True
    End Function

    Public Overrides Function Cancelar() As Boolean
        Dim EstAnterior As FormState = Me.Estado
        Me.Estado = FormState.Cancelar
        Limpiar()
        Modo(False)
        dgvLoteSalida.DataSource = Nothing
        dgvLoteEntrada.DataSource = Nothing
        DetalleEntradas = Nothing
        DetalleSalidas = Nothing
        txtFolio.ResetText()
        lblEstatus.Text = "ESTATUS"
        Me.Estado = EstAnterior
        Return True
    End Function

    Public Overrides Function Nuevo() As Boolean
        Estado = FormState.Nuevo
        Limpiar()
        Modo(True)
        lblEstatus.Text = "ESTATUS"
        Controlador.Configuracion.Engorda.Entidad.Refetch()
        Lotes = Controlador.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
        SalidaGanado = New SalidaGanadoCabeceroClass()
        SalidaGanado.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia
        DetalleEntradas = New LoteDetCollectionClass()
        DetalleSalidas = New LoteDetCollectionClass()
        dgvLoteSalida.DataSource = DetalleSalidas
        dgvLoteEntrada.DataSource = DetalleEntradas
        Return True
    End Function

    Public Overrides Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim FrmVistaDetalle As frmDetalleLote = Nothing

        If MessageBox.Show("La Salida por Transferencia se efectuara, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Return False
        End If

        Me.Validar()

        If Me.Validate() Then
            SalidaGanado.Detalles.Clear()

            For Each Renglon As DataGridViewRow In dgvLoteEntrada.Rows
                Dim Arete As LoteDetClass = CType(Renglon.DataBoundItem, LoteDetClass)

                With Arete
                    SalidaGanado.Detalles.Add(New SalidaGanadoDetalleClass(0, .IdTipoGanado, 0, dtpFecha.Value, .IdLote, 0, 1, .PesoEstimado, .CostoxKilo, .Impte, .ImpteAlim, .ImpteMed, .KilosAlim, .IdMcecatLotesDet, "", "", "", 0))
                End With
            Next
            Controlador.RealizarSalidadeCorralporTranferencia(SalidaGanado, cmbLoteEntrada.SelectedItem.IdLote, Me.dtpFecha.Value, Trans)
            Trans.Commit()
            MessageBox.Show("La Salida de Corral por Tranferencia se ha realizado satisfactoriamente con el folio: " & SalidaGanado.Folio)

            If MessageBox.Show("¿Desea previsualizar los datos para impresion?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Controlador.ImpresionSalidaDeGanado(SalidaGanado)
            End If
            Cancelar()
            Return True
        End If
    End Function

    Public Overrides Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        If MessageBox.Show("La Salida por Transferencia (" & SalidaGanado.Folio & ") se cancelara, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Return False
        End If

        Controlador.CancelarSalidaDeCorralporTranferencia(SalidaGanado, Trans)
        Trans.Commit()
        Cancelar()
        MessageBox.Show("La Salida de Corral por Transferencia se ha cancelado satisfactoriamente")
        Return True
    End Function

    Public Overrides Function Imprimir() As Boolean
        Controlador.ImpresionSalidaDeGanado(SalidaGanado)
        Return True
    End Function

#End Region

#Region "Eventos"

    Private Sub frmSalidasRecibaRastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "InicializarForma")
    End Sub

    Private Sub cmbLotes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLoteSalida.KeyDown, cmbLoteEntrada.KeyDown
        If e.KeyCode = Keys.F12 Then
            Lotes = Controlador.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
            sender.SelectedIndex = -1
            sender.Text = "Seleccione el Lote de Salida de " & sender.Tag
        End If
    End Sub

    Private Sub cmbLoteSalida_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoteSalida.SelectedValueChanged
        If Estado = FormState.Nuevo Or Estado = FormState.Buscar Then
            txtCorralSalida.ResetText()

            If cmbLoteSalida.SelectedItem IsNot Nothing Then
                txtCorralSalida.Text = cmbLoteSalida.SelectedItem.Corral.Descripcion
            End If

            If Estado = FormState.Nuevo Then
                RefrescarLoteSalida()
            End If
        End If
    End Sub

    Private Sub cmbLoteEntrada_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoteEntrada.SelectedValueChanged
        If Estado = FormState.Nuevo Or Estado = FormState.Buscar Then
            txtCorralEntrada.ResetText()

            If cmbLoteEntrada.SelectedItem IsNot Nothing Then
                txtCorralEntrada.Text = cmbLoteEntrada.SelectedItem.Corral.Descripcion
            End If

            If Estado = FormState.Nuevo Then
                RefrescarLoteSalida()
            End If
        End If
    End Sub

    Private Sub dgvLoteEntrada_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvLoteEntrada.DataError

    End Sub

    Private Sub btnTodosDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodosDerecha.Click
        For i As Integer = DetalleSalidas.Count - 1 To 0 Step -1
            Dim Arete As LoteDetClass = DetalleSalidas(i)
            DetalleEntradas.Add(Arete)
            DetalleSalidas.Remove(Arete)
            txtLotSalCabezas.Text -= 1
            txtLotSalKilos.Text -= Arete.KilosEntrada
            txtLotSalImporte.Text -= Decimal.Round(Arete.ImporteTotal, 2)
            txtLotEntCabezas.Text += 1
            txtLotEntKilos.Text += Arete.KilosEntrada
            txtLotEntImporte.Text += Decimal.Round(Arete.ImporteTotal, 2)
            txtTransCabezas.Text += 1
            txtTransKilos.Text += Arete.KilosEntrada
            txtTransImporte.Text += Decimal.Round(Arete.ImporteTotal, 2)
        Next
        sender.Enabled = False
        btnDerecha.Enabled = False
        btnIzquierda.Enabled = True
        btnTodosIzquierda.Enabled = True
    End Sub

    Private Sub btnTodosIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodosIzquierda.Click
        For i As Integer = DetalleEntradas.Count - 1 To 0 Step -1
            Dim Arete As LoteDetClass = DetalleEntradas(i)
            DetalleSalidas.Add(Arete)
            DetalleEntradas.Remove(Arete)
            txtLotSalCabezas.Text += 1
            txtLotSalKilos.Text += Arete.KilosEntrada
            txtLotSalImporte.Text += Decimal.Round(Arete.ImporteTotal, 2)
            txtLotEntCabezas.Text -= 1
            txtLotEntKilos.Text -= Arete.KilosEntrada
            txtLotEntImporte.Text -= Decimal.Round(Arete.ImporteTotal, 2)
            txtTransCabezas.Text -= 1
            txtTransKilos.Text -= Arete.KilosEntrada
            txtTransImporte.Text -= Decimal.Round(Arete.ImporteTotal, 2)
        Next
        sender.Enabled = False
        btnIzquierda.Enabled = False
        btnDerecha.Enabled = True
        btnTodosDerecha.Enabled = True
        ultgrpCabezas.Enabled = True
    End Sub

    Private Sub btnDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDerecha.Click
        If Not dgvLoteSalida.SelectedRows.Count > 0 Then
            MessageBox.Show("Seleccione al menos un arete", Controlador.Sesion.MiEmpresa.Empnom)
        Else
            btnIzquierda.Enabled = True
            btnTodosIzquierda.Enabled = True
        End If

        For i As Integer = dgvLoteSalida.SelectedRows.Count - 1 To 0 Step -1
            Dim Arete As LoteDetClass = CType(dgvLoteSalida.SelectedRows(i).DataBoundItem, LoteDetClass)
            DetalleEntradas.Add(Arete)
            DetalleSalidas.Remove(Arete)
            txtLotSalCabezas.Text -= 1
            txtLotSalKilos.Text -= Arete.KilosEntrada
            txtLotSalImporte.Text -= Decimal.Round(Arete.ImporteTotal, 2)
            txtLotEntCabezas.Text += 1
            txtLotEntKilos.Text += Arete.KilosEntrada
            txtLotEntImporte.Text += Decimal.Round(Arete.ImporteTotal, 2)
            txtTransCabezas.Text += 1
            txtTransKilos.Text += Arete.KilosEntrada
            txtTransImporte.Text += Decimal.Round(Arete.ImporteTotal, 2)
        Next

        If Not DetalleSalidas.Count > 0 Then
            sender.Enabled = False
            btnTodosDerecha.Enabled = False
            ultgrpCabezas.Enabled = False
        End If
    End Sub

    Private Sub btnIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzquierda.Click
        If Not dgvLoteEntrada.SelectedRows.Count > 0 Then
            MessageBox.Show("Seleccione al menos un arete", Controlador.Sesion.MiEmpresa.Empnom)
        Else
            btnDerecha.Enabled = True
            btnTodosDerecha.Enabled = True
            ultgrpCabezas.Enabled = True
        End If

        For i As Integer = dgvLoteEntrada.SelectedRows.Count - 1 To 0 Step -1
            Dim Arete As LoteDetClass = CType(dgvLoteEntrada.SelectedRows(i).DataBoundItem, LoteDetClass)
            DetalleSalidas.Add(Arete)
            DetalleEntradas.Remove(Arete)
            txtLotSalCabezas.Text += 1
            txtLotSalKilos.Text += Arete.KilosEntrada
            txtLotSalImporte.Text += Decimal.Round(Arete.ImporteTotal, 2)
            txtLotEntCabezas.Text -= 1
            txtLotEntKilos.Text -= Arete.KilosEntrada
            txtLotEntImporte.Text -= Decimal.Round(Arete.ImporteTotal, 2)
            txtTransCabezas.Text -= 1
            txtTransKilos.Text -= Arete.KilosEntrada
            txtTransImporte.Text -= Decimal.Round(Arete.ImporteTotal, 2)
        Next

        If Not DetalleEntradas.Count > 0 Then
            sender.Enabled = False
            btnTodosIzquierda.Enabled = False
        End If
    End Sub

    Private Sub cmbLoteEntrada_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoteEntrada.DropDown
        RecargarLotesEntrada()
    End Sub

    Private Sub cmbLoteSalida_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoteSalida.DropDown
        RecargarLotesSalida()
    End Sub

    Private Sub ulttxtCabezas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ulttxtCabezas.KeyPress
        If e.KeyChar = Chr(Keys.Enter) AndAlso ulttxtCabezas.Value IsNot Nothing AndAlso CType(ulttxtCabezas.Value, Integer) <> 0 Then
            Dim Cabezas As Integer = ulttxtCabezas.Value, Lote As LoteClass = CType(cmbLoteSalida.SelectedItem, LoteClass)

            ulttxtCabezas.Value = Nothing

            If Cabezas <= Lote.SaldoCabezas Then
                btnTodosIzquierda_Click(btnTodosIzquierda, New EventArgs())
                dgvLoteSalida.ClearSelection()

                For i As Integer = 0 To Cabezas - 1
                    dgvLoteSalida.Rows(i).Selected = True
                Next
                btnDerecha_Click(btnDerecha, New EventArgs())
            Else
                MessageBox.Show("La cantidad de cabezas proporcionada supera el total de cabezas del lote" & vbNewLine & "Por proporcione un cantidad valida", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

#End Region

End Class