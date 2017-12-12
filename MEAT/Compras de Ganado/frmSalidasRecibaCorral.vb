Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmSalidasRecibaCorral

#Region "Miembros"
    Dim Estado As New FormState
    Dim CorralReciba As SalidaGanadoCabeceroClass
    Dim CorralRecibaAretes As SalidaGanadoCabeceroClass
#End Region

#Region "Metodos"

    Public Sub Inicializar_Forma()
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
        Me.MEAToolBar1.ToolBarButtonStatus = tbEstados
        Me.MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        'Cargar Corrales
        ActualizarCorrales()
        'Cargar Lotes
        ActualizarLotes()

        dgvDetalle.AutoGenerateColumns = False
        dgvTiposGanadoReciba.AutoGenerateColumns = False
        dgvTiposGanadoLote.AutoGenerateColumns = False
        clmIdTipoGanado.ValueMember = "IdTipoGanado"
        clmIdTipoGanado.DisplayMember = "Descripcion"
        Modo(False)
        Limpiar()

        If Not Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
            Me.dgvDetalle.Columns(Me.clmArete.Index).Visible = False
            Me.dgvDetalle.Columns(Me.clmAreteSiniiga.Index).Visible = False
            Me.dgvDetalle.Columns(Me.clmAreteTransporte.Index).Visible = False
            Me.dgvDetalle.Columns(Me.clmCabezas.Index).Visible = True
            Me.dgvDetalle.Columns(Me.clmKilos.Index).Width = 100
            Me.dgvDetalle.Columns(Me.clmCostoxKilo.Index).Width = 100
        End If
    End Sub

    Private Sub ActualizarCorrales()
        Dim Corrales As CC.McecatCorralesCabCollection = Controlador.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.RECIBA)

        For i As Integer = Corrales.Count - 1 To 0 Step -1
            If Not Corrales(i).McgcatTiposdeGanadoCollectionViaMcecatCorralesDet.Count > 0 Then
                Corrales.RemoveAt(i)
            End If
        Next
        cmbCorral.DataSource = Nothing
        cmbCorral.ValueMember = "IdCorral"
        cmbCorral.DisplayMember = "NombreCorral"
        cmbCorral.DataSource = Corrales
        cmbCorral.SelectedIndex = -1
        cmbCorral.Text = "Seleccione el Corral"
    End Sub

    Private Sub ActualizarLotes()
        cmbLoteDestino.DataSource = Nothing
        cmbLoteDestino.ValueMember = "IdLote"
        cmbLoteDestino.DisplayMember = "Descripcion"
        cmbLoteDestino.DataSource = Controlador.ObtenerLotes()
        cmbLoteDestino.SelectedIndex = -1
        cmbLoteDestino.Text = "Seleccione el Lote"
    End Sub

    Private Sub Modo(ByVal Edicion As Boolean)
        dtpFecha.Enabled = Edicion
        cmbCorral.Enabled = Edicion
        cmbLoteDestino.Enabled = Edicion
        dgvDetalle.Enabled = Edicion
        dgvDetalle.AllowUserToAddRows = Edicion
    End Sub

    Public Sub ActualizarCorral(ByVal Corral As CorralClass)
        clmIdTipoGanado.DataSource = Corral.Entidad.McgcatTiposdeGanadoCollectionViaMcecatCorralesDet
        'txtCorRecCabezas.Text = Corral.TotalCabezas
        'txtCorRecKilos.Text = Corral.TotalKilos

        'If Corral.TotalCabezas <> 0 Then
        '    txtKilosPromedio.Text = Corral.TotalKilos / Corral.TotalCabezas
        'Else
        '    txtKilosPromedio.Text = 0
        'End If
    End Sub

    ''' <summary>
    ''' Valida que cada detalle tenga un tipo de ganado diferente y una cantidad de cabezas y kilos mayor a 0
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub ValidarGrid(ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        If dgvDetalle.Rows.Count > 0 Then
            Dim Seleccionado As SalidaGanadoDetalleClass = CType(Me.dgvDetalle.Rows(e.RowIndex).DataBoundItem, SalidaGanadoDetalleClass)

            For i As Integer = dgvDetalle.Rows.Count - 2 To 0 Step -1
                Dim CorralRecibaDetalle As SalidaGanadoDetalleClass = CType(Me.dgvDetalle.Rows(i).DataBoundItem, SalidaGanadoDetalleClass)

                If Seleccionado IsNot Nothing Then
                    If i <> e.RowIndex Then
                        If (Not Controlador.Configuracion.Engorda.RequerirArete _
                        AndAlso (Seleccionado.Arete.Trim <> String.Empty OrElse Seleccionado.AreteTransporte.Trim <> String.Empty OrElse Seleccionado.AreteSiniiga.Trim <> String.Empty) _
                        OrElse Controlador.Configuracion.Engorda.RequerirArete) _
                        AndAlso (Seleccionado.Arete.Trim <> String.Empty AndAlso Seleccionado.Arete = CorralRecibaDetalle.Arete _
                        OrElse Seleccionado.AreteTransporte.Trim <> String.Empty AndAlso Seleccionado.AreteTransporte = CorralRecibaDetalle.AreteTransporte _
                        OrElse Seleccionado.AreteSiniiga.Trim <> String.Empty AndAlso Seleccionado.AreteSiniiga = CorralRecibaDetalle.AreteSiniiga) Then
                            e.Cancel = True
                            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 1)
                        End If
                    Else
                        If Controlador.Configuracion.Engorda.RequerirArete AndAlso Not (Seleccionado.Arete.Trim <> String.Empty OrElse Seleccionado.AreteTransporte.Trim <> String.Empty OrElse Seleccionado.AreteSiniiga.Trim <> String.Empty) Then
                            e.Cancel = True
                            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 2)
                        ElseIf (Not Controlador.Configuracion.Engorda.RequerirArete _
                        AndAlso (Seleccionado.Arete.Trim <> String.Empty OrElse Seleccionado.AreteSiniiga.Trim <> String.Empty) _
                        OrElse Controlador.Configuracion.Engorda.RequerirArete) _
                        AndAlso (Seleccionado.Arete.Trim <> String.Empty AndAlso CC.McecatLotesDetCollection.GetMultiAsDataTable(HC.McecatLotesDetFields.AretePropio = CorralReciba.Detalles(i).Arete, 0, Nothing).Rows.Count > 0 _
                        OrElse Seleccionado.AreteSiniiga.Trim <> String.Empty AndAlso CC.McecatLotesDetCollection.GetMultiAsDataTable(HC.McecatLotesDetFields.AreteSiniiga = CorralReciba.Detalles(i).AreteSiniiga, 0, Nothing).Rows.Count > 0) Then
                            e.Cancel = True
                            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 1)
                        ElseIf Seleccionado.TipoGanado.Entidad.IsNew Then
                            e.Cancel = True
                            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 7)
                        ElseIf Seleccionado.Kilos <= 0 Then
                            e.Cancel = True
                            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 2)
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ValidarDatos()
        If cmbCorral.SelectedValue Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 4)
        ElseIf cmbLoteDestino.SelectedValue Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 0)
        ElseIf Not CorralReciba.Detalles.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 5)
        ElseIf CorralReciba.Detalles.Count = 1 AndAlso Not CorralReciba.Detalles(0).IsDirty Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 5)
        End If
    End Sub

    Private Sub ColocarDatodeBusquedadeAretes()
        Try
            Dim Cabezas As Integer = 0, Kilos As Decimal = 0D, Importe As Decimal = 0D, ImporteVenta As Decimal = 0D
            Dim CabezasxTipodeGanado As Integer = 0, KilosxTipodeGanado As Decimal = 0D, ImportexTipodeGanado As Decimal = 0D, ImporteVentaxTipodeGanado As Decimal = 0D
            Dim IdTipodeGanado As Integer
            Dim TipodeGanado As TipoGanadoClass
            Dim Cont As Integer
            Dim PrecioxKilo As Decimal = 0, CostoxKilo As Decimal = 0

            txtFolio.Text = CorralRecibaAretes.Folio
            dtpFecha.Value = CorralRecibaAretes.Fecha

            cmbCorral.SelectedValue = CorralRecibaAretes.IdCorral
            Me.ActualizarCorral(CorralRecibaAretes.Corral)

            Me.cmbLoteDestino.SelectedValue = CorralRecibaAretes.IdLoteDestino
            Me.ActualizarLotes()

            lblEstatus.Text = CorralRecibaAretes.Estatus.ToString()
            IdTipodeGanado = CorralRecibaAretes.Detalles(0).IdTipoGanado
            TipodeGanado = CorralRecibaAretes.Detalles(0).TipoGanado
            Cont = 0

            For Each Detalle As SalidaGanadoDetalleClass In CorralRecibaAretes.Detalles
                If IdTipodeGanado = Detalle.IdTipoGanado Then
                    CabezasxTipodeGanado += Detalle.Cabezas
                    KilosxTipodeGanado += Detalle.Kilos
                    ImportexTipodeGanado += Detalle.Importe
                    ImporteVentaxTipodeGanado += Detalle.ImporteVenta
                    CostoxKilo = Detalle.CostoxKilo
                    If Detalle.PrecioxKilo.HasValue Then
                        PrecioxKilo = Detalle.PrecioxKilo
                    Else
                        PrecioxKilo = 0
                    End If
                Else

                    Me.ColocarDatosdeTipodeGanado(TipodeGanado, CabezasxTipodeGanado, KilosxTipodeGanado, PrecioxKilo, CostoxKilo, ImporteVentaxTipodeGanado, ImportexTipodeGanado, Cont)

                    'inicializar variables
                    CabezasxTipodeGanado = 0
                    KilosxTipodeGanado = 0
                    ImportexTipodeGanado = 0
                    ImporteVentaxTipodeGanado = 0
                    CostoxKilo = 0
                    PrecioxKilo = 0

                    'asignar de nuevo valores para el siguiente tipo de ganado
                    CabezasxTipodeGanado += Detalle.Cabezas
                    KilosxTipodeGanado += Detalle.Kilos
                    ImportexTipodeGanado += Detalle.Importe
                    ImporteVentaxTipodeGanado += Detalle.ImporteVenta
                    CostoxKilo = Detalle.CostoxKilo
                    If Detalle.PrecioxKilo.HasValue Then
                        PrecioxKilo = Detalle.PrecioxKilo
                    Else
                        PrecioxKilo = 0
                    End If
                    TipodeGanado = Detalle.TipoGanado
                    IdTipodeGanado = Detalle.IdTipoGanado
                    Cont = Cont + 1
                End If
                Cabezas += Detalle.Cabezas
                Kilos += Detalle.Kilos
                Importe += Detalle.Importe
                ImporteVenta += Detalle.ImporteVenta
            Next
            If CabezasxTipodeGanado >= 1 Then
                Me.ColocarDatosdeTipodeGanado(TipodeGanado, CabezasxTipodeGanado, KilosxTipodeGanado, PrecioxKilo, CostoxKilo, ImporteVentaxTipodeGanado, ImportexTipodeGanado, Cont)
            End If
            'txtTotalCabezas.Text = Cabezas
            txtTotalKilos.Text = Kilos.ToString("N2")
            txtTotalImporte.Text = Importe.ToString("C2")
            'txtTotalImporteVenta.Text = ImporteVenta.ToString("C2")
            'TipodeGanado = Me.dgvDetalle.Rows(0).Cells(Me.clmIdTipoGanado.Index).Value
            'Me.BuscarDatosEnEspejo(TipodeGanado.IdTipoGanado)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ColocarDatosdeTipodeGanado(ByVal TipodeGanado As TipoGanadoClass, ByVal Cabezas As Integer, _
                                            ByVal Kilos As Decimal, ByVal PrecioxKilo As Decimal, ByVal CostoxKilo As Decimal, _
                                            ByVal ImporteVenta As Decimal, ByVal Importe As Decimal, ByVal Renglon As Integer)
        Dim I As Integer
        I = Me.dgvDetalle.Rows.Add()
        Me.dgvDetalle.Rows(I).Cells(Me.clmIdTipoGanado.Index).Value = TipodeGanado
        Me.dgvDetalle.Rows(I).Cells(Me.clmCabezas.Index).Value = Cabezas
        Me.dgvDetalle.Rows(I).Cells(Me.clmKilos.Index).Value = Kilos
        'Me.dgvDetalle.Rows(I).Cells(Me.clmPrecioxKilo.Index).Value = PrecioxKilo
        Me.dgvDetalle.Rows(I).Cells(Me.clmCostoxKilo.Index).Value = CostoxKilo
        'Me.dgvDetalle.Rows(I).Cells(Me.clmImporteVenta.Index).Value = ImporteVenta
        Me.dgvDetalle.Rows(I).Cells(Me.clmImporte.Index).Value = Importe
        'Me.dgvDetalle.Rows(I).Cells(Me.clmCabezasExistentes.Index).Value = 0
    End Sub
#End Region

#Region "Acciones_Menu"

    Public Function Buscar() As Boolean
        Dim Kilos As Decimal = 0D, Importe As Decimal = 0D
        Dim frmCorralesReciba As New frmBusquedaCorralesRecibaCorral
        Estado = FormState.Buscar

        If frmCorralesReciba.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
                Limpiar()
                Me.dgvDetalle.Rows.Clear()
                CorralRecibaAretes = CType(frmCorralesReciba.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
                Me.ColocarDatodeBusquedadeAretes()
            Else
                CorralReciba = CType(frmCorralesReciba.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
                txtFolio.Text = CorralReciba.Folio
                dtpFecha.Value = CorralReciba.Fecha
                cmbLoteDestino.SelectedValue = CorralReciba.IdLoteDestino
                cmbCorral.SelectedValue = CorralReciba.IdCorral
                Me.ActualizarCorral(CorralReciba.Corral)
                lblEstatus.Text = CorralReciba.Estatus.ToString()
                dgvDetalle.DataSource = CorralReciba.Detalles

                For Each Detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                    Kilos += Detalle.Kilos
                    Importe += Detalle.Importe
                Next

                txtTotalKilos.Text = Kilos.ToString("N2")
                txtTotalImporte.Text = Importe.ToString("C2")
            End If
            Return True
        End If
    End Function

    Public Sub Limpiar()
        Dim EstAnterior As FormState = Me.Estado
        Me.Estado = FormState.Limpiar
        dgvDetalle.DataSource = Nothing

        If CorralReciba IsNot Nothing Then
            CorralReciba.Detalles.Clear()
            dgvDetalle.DataSource = CorralReciba.Detalles
        End If
        dtpFecha.Value = Now
        cmbCorral.SelectedIndex = -1
        cmbCorral.Text = "Seleccione el Corral"
        cmbLoteDestino.SelectedIndex = -1
        cmbLoteDestino.Text = "Seleccione el Lote"
        clmIdTipoGanado.ToolTipText = "Seleccione el Tipo de Ganado"
        'txtCorRecCabezas.Text = 0
        'txtCorRecKilos.Text = (0D).ToString("N2")
        'txtKilosPromedio.Text = 0
        txtTotalKilos.ResetText()
        txtTotalImporte.ResetText()
        txtFolio.ResetText()
        Me.Estado = EstAnterior
    End Sub

    Public Sub Cancelar()
        Dim EstAnterior As FormState = Me.Estado
        Me.Estado = FormState.Cancelar
        Limpiar()
        Modo(False)
        lblEstatus.Text = "ESTATUS"
        Me.Estado = EstAnterior
    End Sub

    Public Sub Nuevo()
        Estado = FormState.Nuevo
        Limpiar()
        Modo(True)
        lblEstatus.Text = "ESTATUS"
        Controlador.Configuracion.Engorda.Entidad.Refetch()
        CorralReciba = New SalidaGanadoCabeceroClass()
        CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral
        dgvDetalle.DataSource = CorralReciba.Detalles

        If cmbCorral.DataSource IsNot Nothing AndAlso cmbCorral.DataSource.GetType Is GetType(CC.McecatCorralesCabCollection) _
        AndAlso CType(cmbCorral.DataSource, CC.McecatCorralesCabCollection).Count = 1 Then
            cmbCorral.SelectedIndex = 0
        End If
    End Sub

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim Cont As Integer
        ValidarDatos()
        If Me.Validate() Then
            If Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
                Controlador.RealizarSalidadeRecibaaCorral(CorralReciba, Me.dtpFecha.Value, Trans)
            Else
                CorralRecibaAretes = New SalidaGanadoCabeceroClass()
                CorralRecibaAretes.IdCorral = Me.cmbCorral.SelectedValue
                CorralRecibaAretes.IdLoteDestino = Me.cmbLoteDestino.SelectedValue
                CorralRecibaAretes.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral
                Cont = 0
                For i As Integer = 0 To Me.dgvDetalle.Rows.Count - 1
                    If Me.dgvDetalle.Rows(i).Cells(Me.clmIdTipoGanado.Index).Value <> 0 Then
                        For j As Integer = 0 To Me.dgvDetalle.Rows(i).Cells(Me.clmCabezas.Index).Value - 1
                            CorralRecibaAretes.Detalles.AddNew()
                            'CorralRecibaAretes.Detalles(Cont).Arete = Me.dgvDetalle.Rows(i).Cells(Me.clmArete.Index).Value
                            'CorralRecibaAretes.Detalles(Cont).AreteSiniiga = Me.dgvDetalle.Rows(i).Cells(Me.clmAreteSiniiga.Index).Value
                            'CorralRecibaAretes.Detalles(Cont).AreteTransporte = Me.dgvDetalle.Rows(i).Cells(Me.clmAreteTransporte.Index).Value
                            CorralRecibaAretes.Detalles(Cont).Cabezas = 1
                            CorralRecibaAretes.Detalles(Cont).CostoxKilo = Me.dgvDetalle.Rows(i).Cells(Me.clmCostoxKilo.Index).Value
                            CorralRecibaAretes.Detalles(Cont).IdTipoGanado = Me.dgvDetalle.Rows(i).Cells(Me.clmIdTipoGanado.Index).Value
                            CorralRecibaAretes.Detalles(Cont).Kilos = Me.dgvDetalle.Rows(i).Cells(Me.clmKilos.Index).Value / Me.dgvDetalle.Rows(i).Cells(Me.clmCabezas.Index).Value
                            Cont += 1
                        Next
                    End If
                Next
                Controlador.RealizarSalidadeRecibaaCorral(CorralRecibaAretes, Me.dtpFecha.Value, Trans)
            End If
            Trans.Commit()
            If Not Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
                MessageBox.Show("La Transferencia de Reciba a Corral se ha realizado satisfactoriamente con el folio: " & CorralRecibaAretes.Folio)
                Controlador.ImpresionSalidaDeGanado(CorralRecibaAretes)
            Else
                MessageBox.Show("La Transferencia de Reciba a Corral se ha realizado satisfactoriamente con el folio: " & CorralReciba.Folio)
                Controlador.ImpresionSalidaDeGanado(CorralReciba)
            End If
            Cancelar()
            Return True
        End If
    End Function

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        If Not Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
            Controlador.CancelarSalidadeRecibaaCorral(CorralRecibaAretes, CorralRecibaAretes.Detalles, Trans)
        Else
            Controlador.CancelarSalidadeRecibaaCorral(CorralReciba, CorralReciba.Detalles, Trans)
        End If
        Trans.Commit()
        Cancelar()
        MessageBox.Show("La Transferencia de Reciba a Corral se ha cancelado satisfactoriamente")
        Return True
    End Function

    Public Sub Editar()
        Estado = FormState.Editar
        Modo(True)
    End Sub

    Public Sub Imprimir()
        If Not Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
            Controlador.ImpresionSalidaDeGanado(CorralRecibaAretes)
        Else
            Controlador.ImpresionSalidaDeGanado(CorralReciba)
        End If
    End Sub

    Public Sub Salir()
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub
#End Region

#Region "Eventos"

    Private Sub frmSalidasRecibaRastro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar, MEAToolBar1.ClickBuscar, MEAToolBar1.ClickCancelar, MEAToolBar1.ClickEditar, MEAToolBar1.ClickGuardar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickNuevo, MEAToolBar1.ClickSalir
        If e.Button.Text = "Guardar" OrElse e.Button.Text = "Borrar" OrElse e.Button.Text = "Buscar" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Balance General")
            Dim Resultado As Object = Nothing

            If e.Button.Text = "Guardar" OrElse e.Button.Text = "Borrar" Then
                Resultado = Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans})
            Else
                Resultado = Utilerias.RunControlException(Me, e.Button.Text)
            End If

            If Resultado Is Nothing OrElse Resultado = False Then
                Trans.Rollback()
                Cancelar = True
            End If
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
    End Sub

    Private Sub cmbCorral_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCorral.SelectedValueChanged
        dgvTiposGanadoReciba.DataSource = Nothing

        If cmbCorral.SelectedValue IsNot Nothing And (Estado = FormState.Nuevo Or Estado = FormState.Editar) Then
            CorralReciba.IdCorral = cmbCorral.SelectedValue
            Utilerias.RunControlException(Me, "ActualizarCorral", New Object() {CorralReciba.Corral})
            dgvTiposGanadoReciba.DataSource = CorralReciba.Corral.Detalle
        End If
    End Sub

    Private Sub cmbLoteDestino_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLoteDestino.SelectedValueChanged
        dgvTiposGanadoLote.DataSource = Nothing

        If cmbLoteDestino.SelectedValue IsNot Nothing AndAlso (Estado = FormState.Nuevo Or Estado = FormState.Editar) Then
            CorralReciba.IdLoteDestino = cmbLoteDestino.SelectedValue
            Utilerias.RunControlException(Me, "ActualizarLote", New Object() {CorralReciba.LoteDestino})
            dgvTiposGanadoLote.DataSource = CorralReciba.LoteDestino.DetallesPorTiposGanado_Vigentes
        End If
    End Sub

    Private Sub dgvDetalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalle.DataError

    End Sub

    Private Sub dgvDetalle_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalle.RowValidating
        If Me.Estado = FormState.Nuevo OrElse Me.Estado = FormState.Editar Then
            Utilerias.RunControlException(Me, "ValidarGrid", New Object() {e})
        End If
    End Sub

    Public Sub CalcularTotales()
        Dim TotalCabezas As Integer = 0D, TotalKilos As Decimal = 0D, TotalImporte As Decimal = 0D

        For Each detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                TotalCabezas += detalle.Cabezas
                TotalKilos += detalle.Kilos
                TotalImporte += detalle.Importe
            End If
        Next
        txtTotalKilos.Text = TotalKilos.ToString("N2")
        txtTotalImporte.Text = TotalImporte.ToString("C2")
        dgvDetalle.Refresh()
    End Sub

    Private Sub dgvDetalle_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        If e.ColumnIndex = clmIdTipoGanado.Index Then
            dgvDetalle.Refresh()
        Else
            If e.ColumnIndex = clmKilos.Index Then
                If Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
                    CorralReciba.Detalles(e.RowIndex).Cabezas = 1
                Else
                    CorralReciba.Detalles(e.RowIndex).Cabezas = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCabezas.Index).Value
                End If
                CalcularTotales()
            End If
            If e.ColumnIndex = clmCabezas.Index Then
                If Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete Then
                    CorralReciba.Detalles(e.RowIndex).Cabezas = 1
                Else
                    CorralReciba.Detalles(e.RowIndex).Cabezas = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCabezas.Index).Value
                End If
                CalcularTotales()
            End If
        End If
    End Sub

    Private Sub dgvDetalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalle.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If dgvDetalle.CurrentCell.ColumnIndex = clmKilos.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        ElseIf dgvDetalle.CurrentCell.ColumnIndex = clmArete.Index OrElse _
                dgvDetalle.CurrentCell.ColumnIndex = clmAreteSiniiga.Index OrElse _
                dgvDetalle.CurrentCell.ColumnIndex = clmAreteTransporte.Index Then
            CType(e.Control, TextBox).MaxLength = 10
            CType(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    Private Sub dgvDetalle_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvDetalle.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvDetalle.CurrentRow.Index <> dgvDetalle.Rows.Count - 1 Then
                If MessageBox.Show("Seguro que desea eliminarlo", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    RemoveHandler dgvDetalle.RowValidating, AddressOf dgvDetalle_RowValidating
                    CorralReciba.Detalles.RemoveAt(dgvDetalle.CurrentRow.Index)
                    CalcularTotales()
                    AddHandler dgvDetalle.RowValidating, AddressOf dgvDetalle_RowValidating
                End If
            End If
        End If
    End Sub

    Private Sub cmbCorral_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCorral.KeyDown
        If e.KeyCode = Keys.F12 Then
            ActualizarCorrales()
        End If
    End Sub

    Private Sub cmbLoteDestino_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLoteDestino.KeyDown
        If e.KeyCode = Keys.F12 Then
            ActualizarLotes()
        End If
    End Sub

#End Region

End Class