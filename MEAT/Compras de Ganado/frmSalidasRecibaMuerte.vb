Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmSalidasRecibaMuerte

    Dim TotalKilosporTipoGanado As Decimal
    Dim CostoPorTipoGanado As Decimal
    Dim CabezasPorTipodeGanado As Integer
    Dim TipodeGanado As Integer
    Dim RenglonDetallePrincipal As Integer
    Dim RenglonDetalleAretes As Integer

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
        'Cargar Causas de Muerte
        ActualizarCausasMuerte()

        dgvDetalle.AutoGenerateColumns = False
        clmIdTipoGanado.ValueMember = "IdTipoGanado"
        clmIdTipoGanado.DisplayMember = "Descripcion"
        Modo(False)
        Limpiar()
        If Controlador.Configuracion.Engorda.RequerirArete Then
            Me.dgvDetalleLote.Visible = True
            Me.dgvDetalle.Size = Me.dgvDetalle.MinimumSize
            Me.txtTotalCabezas.Top = 340
            Me.txtTotalImporte.Top = 340
            'Me.txtTotalImporteVenta.Top = 340
            Me.txtTotalKilos.Top = 340
            Me.dgvDetalle.Columns(Me.clmCabezas.Index).ReadOnly = True
        Else
            Me.dgvDetalleLote.Visible = False
            Me.dgvDetalle.Size = Me.dgvDetalle.MaximumSize
            Me.txtTotalCabezas.Top = 495
            Me.txtTotalImporte.Top = 495
            'Me.txtTotalImporteVenta.Top = 473
            Me.txtTotalKilos.Top = 495
            Me.dgvDetalle.Columns(Me.clmCabezas.Index).ReadOnly = False
        End If
    End Sub

    Private Sub Modo(ByVal Edicion As Boolean)
        dtpFecha.Enabled = Edicion
        cmbCorral.Enabled = Edicion
        dgvDetalle.Enabled = Edicion
        dgvDetalle.AllowUserToAddRows = Edicion
        txtAviso.Enabled = Edicion
        cmbCausaMuerte.Enabled = Edicion
        chkRecuperacion.Enabled = Edicion
    End Sub

    Public Sub ActualizarCorral(ByVal Corral As CorralClass)
        clmIdTipoGanado.DataSource = Corral.Entidad.McgcatTiposdeGanadoCollectionViaMcecatCorralesDet
        txtCabezas.Text = Corral.TotalCabezas
        txtKilos.Text = Corral.TotalKilos
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

    Private Sub ActualizarCausasMuerte()
        Dim CausasMuerte As CC.McgcatCausasMuerteCollection = Controlador.ObtenerCausasMuerte(CondicionEnum.ACTIVOS)
        cmbCausaMuerte.DataSource = Nothing
        cmbCausaMuerte.ValueMember = "IdCausaMuerte"
        cmbCausaMuerte.DisplayMember = "NombreCausaMuerte"
        cmbCausaMuerte.DataSource = CausasMuerte
        cmbCausaMuerte.SelectedIndex = -1
        cmbCausaMuerte.Text = "Seleccione la Causa de Muerte"
    End Sub

    ''' <summary>
    ''' Valida que cada detalle tenga un tipo de ganado diferente y una cantidad de cabezas y kilos mayor a 0
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub ValidarGrid(ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        If dgvDetalle.Rows.Count > 0 Then
            If Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmKilos.Index).Value = 0 Then
                Exit Sub
            End If
            Dim CorralRecibaDetalleSeleccionado As SalidaGanadoDetalleClass = CType(Me.dgvDetalle.Rows(e.RowIndex).DataBoundItem, SalidaGanadoDetalleClass)

            If CorralRecibaDetalleSeleccionado IsNot Nothing Then
                If Not Controlador.Configuracion.Engorda.RequerirArete Then
                    If CorralRecibaDetalleSeleccionado.Cabezas <= 0 Then
                        e.Cancel = True
                        Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 1)
                    End If
                End If

                For Each CorralDetalle As EC.McecatCorralesDetEntity In CorralReciba.Corral.Detalle.ObtenerColeccion()
                    Dim TotalCabezas As Integer = CorralDetalle.ExistCabezas

                    For i As Integer = dgvDetalle.Rows.Count - 2 To 0 Step -1
                        Dim CorralRecibaDetalle As SalidaGanadoDetalleClass = CType(Me.dgvDetalle.Rows(i).DataBoundItem, SalidaGanadoDetalleClass)

                        If CorralRecibaDetalle.IdTipoGanado = CorralDetalle.IdTipoGanado Then
                            If CorralRecibaDetalle.Cabezas <= TotalCabezas Then
                                TotalCabezas -= CorralRecibaDetalle.Cabezas
                            Else
                                e.Cancel = True
                                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 6)
                            End If
                        End If
                    Next
                Next

                If CorralRecibaDetalleSeleccionado.Kilos <= 0 Then
                    e.Cancel = True
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 2)
                End If
            End If
        End If
    End Sub

    Private Sub ValidarDatos()
        If cmbCorral.SelectedValue Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 4)
        ElseIf Not CorralReciba.Detalles.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 5)
        ElseIf cmbCausaMuerte.SelectedValue Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_MUERTE, 0)
        ElseIf CorralReciba.Detalles.Count = 1 AndAlso Not CorralReciba.Detalles(0).IsDirty Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 5)
        End If
    End Sub
    Public Sub ValidarGridDetalleLote(ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs)
        Dim KilosDetalle As Decimal
        If dgvDetalleLote.Rows.Count > 0 Then
            For i As Integer = 0 To Me.dgvDetalleLote.Rows.Count - 1
                KilosDetalle += Me.dgvDetalleLote.Rows(i).Cells(Me.clmDetalleKilos.Index).Value
            Next
        End If
        If Math.Round(KilosDetalle, 3) > Math.Round(Me.TotalKilosporTipoGanado, 3) Then
            MessageBox.Show("Favor de restar los " & KilosDetalle - Me.TotalKilosporTipoGanado & " kilos sobrantes entre las cabezas del detalle", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If Math.Round(KilosDetalle, 3) < Math.Round(Me.TotalKilosporTipoGanado, 3) Then
            MessageBox.Show("Favor de agregar los " & KilosDetalle - Me.TotalKilosporTipoGanado & " kilos faltantes entre las cabezas del detalle", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function VerificarAretes(ByVal Arete As String, ByVal Columna As Integer, ByVal Renglon As Integer, ByVal TipodeGanado As Integer) As Boolean
        Try
            For i As Integer = 0 To Me.dgvDetalleLote.Rows.Count - 1
                If i <> Renglon Then
                    If Me.dgvDetalleLote.Rows(i).Cells(Columna).Value = Arete Then
                        MessageBox.Show("Arete se ecuentra capturado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Dim Identificador As String
                        'Identificador = Me.dgvDetalleLote.CurrentRow.Cells(Me.clmIdentificador.Index).Value
                        'TipodeGanado = Me.dgvDetalleLote.CurrentRow.Cells(Me.clmTipoGanado.Index).Value
                        'Me.dgvDetalleLote.Rows.Remove(Me.dgvDetalleLote.CurrentRow)
                        'Me.dgvDetalleLote.Refresh()
                        'Me.QuitarDatosdeEspejo(TipodeGanado, Identificador)
                        'Me.RecalcularKiloEnDetalleyEspejo()
                        Return True
                    End If
                End If
            Next
            For i As Integer = 0 To Me.dgvAretesEspejo.Rows.Count - 1
                If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipoGanado.Index).Value <> TipodeGanado Then
                    If Me.dgvAretesEspejo.Rows(i).Cells(Columna).Value = Arete Then
                        MessageBox.Show("Arete se encuentra capturado con otro tipo de ganado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return True
                    End If
                End If
            Next
            Return False
        Catch ex As Exception
            Return True
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ColocarDatosEnEspejo(ByVal KilosPromedio As Decimal, ByVal CostoPromedio As Decimal, ByVal TipodeGanado As Integer)
        Try
            If Me.dgvAretesEspejo.Rows(0).Cells(Me.clmIdentificadorEspejo.Index).Value = "" Then
                ColocarDatosEnEspejo(0)
            Else
                For i As Integer = 0 To Me.dgvAretesEspejo.Rows.Count - 2
                    If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmIdentificadorEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmIdentificador.Index).Value Then
                        ColocarDatosEnEspejo(i)
                    Else
                        If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmIdentificadorEspejo.Index).Value = "" Then
                            ColocarDatosEnEspejo(i)
                            ReescribirDatosEnEspejo(KilosPromedio, CostoPromedio, TipodeGanado)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ColocarDatosEnEspejo(ByVal Renglon As Integer)
        Me.dgvAretesEspejo.Rows(Renglon).Cells(Me.clmAretePropioEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmArete.Index).Value
        Me.dgvAretesEspejo.Rows(Renglon).Cells(Me.clmAreteSINIIGAEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmAreteSINIIGA.Index).Value
        Me.dgvAretesEspejo.Rows(Renglon).Cells(Me.clmAreteTransporteEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmAreteTransporte.Index).Value
        Me.dgvAretesEspejo.Rows(Renglon).Cells(Me.clmKilosEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmDetalleKilos.Index).Value
        Me.dgvAretesEspejo.Rows(Renglon).Cells(Me.clmCostoxKiloEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmDetalleCostoxKilo.Index).Value
        Me.dgvAretesEspejo.Rows(Renglon).Cells(Me.clmTipodeGanadoEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmTipoGanado.Index).Value
        Me.dgvAretesEspejo.Rows(Renglon).Cells(Me.clmIdentificadorEspejo.Index).Value = Me.dgvDetalleLote.Rows(Me.RenglonDetalleAretes).Cells(Me.clmIdentificador.Index).Value
    End Sub

    Private Sub ReescribirDatosEnEspejo(ByVal KilosPromedio As Decimal, ByVal CostoPromedio As Decimal, ByVal TipodeGanado As Integer)
        For i As Integer = 0 To Me.dgvAretesEspejo.Rows.Count - 2
            If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipodeGanadoEspejo.Index).Value = TipodeGanado Then
                Me.dgvAretesEspejo.Rows(i).Cells(Me.clmCostoxKiloEspejo.Index).Value = CostoPromedio
                Me.dgvAretesEspejo.Rows(i).Cells(Me.clmKilosEspejo.Index).Value = KilosPromedio
            End If
        Next
    End Sub

    Private Sub BuscarDatosEnEspejo(ByVal TipodeGanado As Integer)
        Try
            Dim Cont As Integer
            Cont = 0

            For i As Integer = 0 To Me.dgvAretesEspejo.Rows.Count - 1
                If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipoGanado.Index).Value Is Nothing Then
                    Exit For
                Else
                    If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipoGanado.Index).Value = TipodeGanado Then
                        Me.dgvDetalleLote.Rows.Add(1)
                        Me.dgvDetalleLote.Rows(Cont).Cells(Me.clmArete.Index).Value = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmAretePropioEspejo.Index).Value
                        Me.dgvDetalleLote.Rows(Cont).Cells(Me.clmAreteSINIIGA.Index).Value = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmAreteSINIIGAEspejo.Index).Value
                        Me.dgvDetalleLote.Rows(Cont).Cells(Me.clmAreteTransporte.Index).Value = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmAreteTransporteEspejo.Index).Value
                        Me.dgvDetalleLote.Rows(Cont).Cells(Me.clmDetalleKilos.Index).Value = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmKilosEspejo.Index).Value
                        Me.dgvDetalleLote.Rows(Cont).Cells(Me.clmDetalleCostoxKilo.Index).Value = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmCostoxKiloEspejo.Index).Value
                        Me.dgvDetalleLote.Rows(Cont).Cells(Me.clmTipoGanado.Index).Value = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipodeGanadoEspejo.Index).Value
                        Me.dgvDetalleLote.Rows(Cont).Cells(Me.clmIdentificador.Index).Value = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmIdentificadorEspejo.Index).Value
                        Cont += 1
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QuitarDatosdeEspejo(ByVal TipodeGanado As Integer, ByVal Identificador As String)
        Try
            For i As Integer = 0 To Me.dgvAretesEspejo.Rows.Count - 1
                If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipoGanado.Index).Value Is Nothing Then
                    Exit For
                Else
                    If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipoGanado.Index).Value = TipodeGanado Then
                        If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmIdentificadorEspejo.Index).Value = Identificador Then
                            Me.dgvAretesEspejo.Rows.RemoveAt(i)
                            Me.dgvAretesEspejo.Refresh()
                        End If
                    End If
                    Me.dgvAretesEspejo.Refresh()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RecalcularKiloEnDetalleyEspejo()
        Try
            Dim KilosPromedio As Decimal
            Dim CostoPromedio As Decimal

            CabezasPorTipodeGanado = Me.dgvDetalleLote.Rows.Count - 1
            For i As Integer = 0 To Me.dgvDetalleLote.Rows.Count - 2
                Me.dgvDetalleLote.Rows(i).Cells(Me.clmDetalleKilos.Index).Value = Me.TotalKilosporTipoGanado / Me.CabezasPorTipodeGanado
            Next
            KilosPromedio = Me.TotalKilosporTipoGanado / Me.CabezasPorTipodeGanado
            Me.dgvDetalle.Rows(RenglonDetallePrincipal).Cells(Me.clmCabezas.Index).Value = CabezasPorTipodeGanado
            Me.CostoPorTipoGanado = Me.dgvDetalle.Rows(RenglonDetallePrincipal).Cells(Me.clmCostoxKilo.Index).Value
            For i As Integer = 0 To Me.dgvDetalleLote.Rows.Count - 2
                Me.dgvDetalleLote.Rows(i).Cells(Me.clmDetalleCostoxKilo.Index).Value = Me.CostoPorTipoGanado
            Next
            CostoPromedio = Me.CostoPorTipoGanado
            'Me.dgvDetalleLote.CurrentRow.Cells(Me.clmIdentificador.Index).Value = Me.dgvDetalleLote.CurrentRow.Cells(Me.clmArete.Index).Value & Me.dgvDetalleLote.CurrentRow.Cells(Me.clmAreteSINIIGA.Index).Value & Me.dgvDetalleLote.CurrentRow.Cells(Me.clmAreteTransporte.Index).Value
            'Me.dgvAretesEspejo.Rows.Add(1)
            'Me.RenglonDetalleAretes = Me.dgvDetalleLote.CurrentRow.Index
            'ColocarDatosEnEspejo(KilosPromedio, CostoPromedio)
            'recalcular kilos en espejo
            For i As Integer = 0 To Me.dgvAretesEspejo.Rows.Count - 1
                If Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipodeGanadoEspejo.Index).Value = Me.dgvDetalle.Rows(RenglonDetallePrincipal).Cells(Me.clmIdTipoGanado.Index).Value Then
                    Me.dgvAretesEspejo.Rows(i).Cells(Me.clmKilosEspejo.Index).Value = Me.TotalKilosporTipoGanado / Me.CabezasPorTipodeGanado
                    Me.dgvAretesEspejo.Rows(i).Cells(Me.clmCostoxKiloEspejo.Index).Value = Me.CostoPorTipoGanado
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            lblEstatus.Text = CorralRecibaAretes.Estatus.ToString()
            IdTipodeGanado = CorralRecibaAretes.Detalles(0).IdTipoGanado
            TipodeGanado = CorralRecibaAretes.Detalles(0).TipoGanado
            Cont = 0
            Me.dgvAretesEspejo.AutoGenerateColumns = False
            Me.dgvAretesEspejo.DataSource = CorralRecibaAretes.Detalles
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
            txtTotalCabezas.Text = Cabezas
            txtTotalKilos.Text = Kilos.ToString("N2")
            txtTotalImporte.Text = Importe.ToString("C2")
            'txtTotalImporteVenta.Text = ImporteVenta.ToString("C2")
            TipodeGanado = Me.dgvDetalle.Rows(0).Cells(Me.clmIdTipoGanado.Index).Value
            Me.BuscarDatosEnEspejo(TipodeGanado.IdTipoGanado)
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
        Me.dgvDetalle.Rows(I).Cells(Me.clmCabezasExistentes.Index).Value = 0
    End Sub
#End Region

#Region "Acciones_Menu"

    Public Function Buscar() As Boolean
        Dim Cabezas As Integer = 0, Kilos As Decimal = 0D, Importe As Decimal = 0D
        Dim frmCorralesReciba As New frmBusquedaCorralesRecibaMuerte
        Estado = FormState.Buscar
        'Me.dgvDetalle.Enabled = True
        'Me.dgvDetalle.ReadOnly = True

        If frmCorralesReciba.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Controlador.Configuracion.Engorda.RequerirArete Then
                Limpiar()
                CorralRecibaAretes = CType(frmCorralesReciba.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
                Me.ColocarDatodeBusquedadeAretes()
            Else
                CorralReciba = CType(frmCorralesReciba.dgvCorralesRecibaCab.SelectedRows(0).DataBoundItem, SalidaGanadoCabeceroClass)
                txtFolio.Text = CorralReciba.Folio
                dtpFecha.Value = CorralReciba.Fecha
                cmbCorral.SelectedValue = CorralReciba.IdCorral
                Me.ActualizarCorral(CorralReciba.Corral)
                cmbCausaMuerte.SelectedValue = CorralReciba.IdCausaMuerte
                txtAviso.Text = CorralReciba.Aviso
                chkRecuperacion.Checked = CorralReciba.Recuperacion
                lblEstatus.Text = CorralReciba.Estatus.ToString()
                dgvDetalle.DataSource = CorralReciba.Detalles

                For Each Detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                    Cabezas += Detalle.Cabezas
                    Kilos += Detalle.Kilos
                    Importe += Detalle.Importe
                Next

                txtTotalCabezas.Text = Cabezas
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
        clmIdTipoGanado.ToolTipText = "Seleccione el Tipo de Ganado"
        txtCabezas.Text = 0
        txtKilos.Text = (0D).ToString("C2")
        txtTotalCabezas.ResetText()
        txtTotalKilos.ResetText()
        txtTotalImporte.ResetText()
        txtFolio.ResetText()
        txtAviso.ResetText()
        cmbCausaMuerte.SelectedIndex = -1
        cmbCausaMuerte.Text = "Seleccione la Causa de Muerte"
        chkRecuperacion.Checked = False
        Me.dgvDetalleLote.Rows.Clear()
        Me.dgvAretesEspejo.Rows.Clear()
        Me.Estado = EstAnterior
        Me.dgvAretesEspejo.DataSource = Nothing
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
        CorralReciba = New SalidaGanadoCabeceroClass()
        CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte
        dgvDetalle.DataSource = CorralReciba.Detalles
    End Sub

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        ValidarDatos()
        If Me.Validate() Then
            If Controlador.Configuracion.Engorda.RequerirArete Then
                CorralRecibaAretes = New SalidaGanadoCabeceroClass()
                CorralRecibaAretes.IdCorral = Me.cmbCorral.SelectedValue
                CorralRecibaAretes.IdCausaMuerte = Me.cmbCausaMuerte.SelectedValue
                CorralRecibaAretes.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte
                'Me.dgvDetalle.DataSource = Nothing
                For i As Integer = 0 To Me.dgvAretesEspejo.Rows.Count - 2
                    CorralRecibaAretes.Detalles.AddNew()
                    CorralRecibaAretes.Detalles(i).Arete = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmAretePropioEspejo.Index).Value
                    CorralRecibaAretes.Detalles(i).AreteSiniiga = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmAreteSINIIGAEspejo.Index).Value
                    CorralRecibaAretes.Detalles(i).AreteTransporte = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmAreteTransporteEspejo.Index).Value
                    CorralRecibaAretes.Detalles(i).Cabezas = 1
                    CorralRecibaAretes.Detalles(i).CostoxKilo = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmCostoxKiloEspejo.Index).Value
                    CorralRecibaAretes.Detalles(i).IdTipoGanado = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmTipodeGanadoEspejo.Index).Value
                    CorralRecibaAretes.Detalles(i).Kilos = Me.dgvAretesEspejo.Rows(i).Cells(Me.clmKilosEspejo.Index).Value
                Next
                Controlador.RealizarSalidadeRecibaaMuerte(CorralRecibaAretes, Me.dtpFecha.Value, txtAviso.Text.Trim, cmbCausaMuerte.SelectedValue, chkRecuperacion.Checked, Trans)
            Else
                Controlador.RealizarSalidadeRecibaaMuerte(CorralReciba, Me.dtpFecha.Value, txtAviso.Text.Trim, cmbCausaMuerte.SelectedValue, chkRecuperacion.Checked, Trans)
            End If
            Trans.Commit()
            If Controlador.Configuracion.Engorda.RequerirArete Then
                MessageBox.Show("La Salida de Reciba por Muerte se ha realizado satisfactoriamente con el folio: " & CorralRecibaAretes.Folio)
                Controlador.ImpresionSalidaDeGanado(CorralRecibaAretes)
            Else
                MessageBox.Show("La Salida de Reciba por Muerte se ha realizado satisfactoriamente con el folio: " & CorralReciba.Folio)
                Controlador.ImpresionSalidaDeGanado(CorralReciba)
            End If
            Cancelar()
            Return True
        End If
    End Function

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        If Controlador.Configuracion.Engorda.RequerirArete Then
            Controlador.CancelarSalidadeRecibaaRastro(CorralRecibaAretes, CorralRecibaAretes.Detalles, Trans)
        Else
            Controlador.CancelarSalidadeRecibaaMuerte(CorralReciba, CorralReciba.Detalles, Trans)
        End If
        Trans.Commit()
        Cancelar()
        MessageBox.Show("La Salida de Reciba por Muerte se ha cancelado satisfactoriamente")
        Return True
    End Function

    Public Sub Editar()
        Estado = FormState.Editar
        Modo(True)
    End Sub

    Public Sub Imprimir()
        If Controlador.Configuracion.Engorda.RequerirArete Then
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
        If cmbCorral.SelectedValue IsNot Nothing And (Estado = FormState.Nuevo Or Estado = FormState.Editar) Then
            CorralReciba.IdCorral = cmbCorral.SelectedValue
            Utilerias.RunControlException(Me, "ActualizarCorral", New Object() {CorralReciba.Corral})
        End If
    End Sub

    Private Sub dgvDetalle_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalle.DataError

    End Sub

    Private Sub dgvDetalle_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalle.RowValidating
        If Me.Estado = FormState.Nuevo OrElse Me.Estado = FormState.Editar Then
            Utilerias.RunControlException(Me, "ValidarGrid", New Object() {e})
        End If
    End Sub

    Private Sub dgvDetalle_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        If e.ColumnIndex = clmIdTipoGanado.Index Then
            TipodeGanado = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIdTipoGanado.Index).Value
            RenglonDetallePrincipal = e.RowIndex
            Me.dgvDetalleLote.Rows.Clear()
            dgvDetalle.Refresh()
        ElseIf e.ColumnIndex = clmCabezas.Index Or e.ColumnIndex = clmKilos.Index Then
            Dim TotalCabezas As Integer = 0D, TotalKilos As Decimal = 0D, TotalImporte As Decimal = 0D

            For Each detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                If detalle.IsDirty OrElse Not detalle.IsNew Then
                    TotalCabezas += detalle.Cabezas
                    TotalKilos += detalle.Kilos
                    TotalImporte += detalle.Importe
                End If
            Next
            txtTotalCabezas.Text = TotalCabezas
            txtTotalKilos.Text = TotalKilos.ToString("N2")
            txtTotalImporte.Text = TotalImporte.ToString("C2")
            dgvDetalle.Refresh()
            Me.TotalKilosporTipoGanado = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmKilos.Index).Value
            Me.CostoPorTipoGanado = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmCostoxKilo.Index).Value
        End If
    End Sub

    Private Sub dgvDetalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalle.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If dgvDetalle.CurrentCell.ColumnIndex = clmCabezas.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        ElseIf dgvDetalle.CurrentCell.ColumnIndex = clmKilos.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub dgvDetalle_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvDetalle.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvDetalle.CurrentRow.Index <> dgvDetalle.Rows.Count - 1 Then
                If MessageBox.Show("Seguro que desea eliminarlo", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    RemoveHandler dgvDetalle.RowValidating, AddressOf dgvDetalle_RowValidating
                    CorralReciba.Detalles.RemoveAt(dgvDetalle.CurrentRow.Index)
                    AddHandler dgvDetalle.RowValidating, AddressOf dgvDetalle_RowValidating
                End If
            End If
        End If
    End Sub

    Private Sub dgvDetalle_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.RowEnter
        Try
            If Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmKilos.Index).Value = 0 Then
                Exit Sub
            End If
            If Controlador.Configuracion.Engorda.RequerirArete Then
                Me.dgvDetalleLote.Rows.Clear()
                If Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmKilos.Index).Value = 0 Then
                    Me.TotalKilosporTipoGanado = Me.dgvDetalle.Rows(Me.RenglonDetallePrincipal).Cells(Me.clmKilos.Index).Value
                Else
                    Me.TotalKilosporTipoGanado = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmKilos.Index).Value
                End If
                'Dim TipGan As New TipoGanadoClass
                'TipGan = Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIdTipoGanado.Index).Value
                'If TipGan IsNot Nothing Then
                Me.BuscarDatosEnEspejo(Me.dgvDetalle.Rows(e.RowIndex).Cells(Me.clmIdTipoGanado.Index).Value)
                'End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCorral_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCorral.KeyDown
        If e.KeyCode = Keys.F12 Then
            ActualizarCorrales()
        End If
    End Sub

    Private Sub dgvDetalleLote_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleLote.CellEndEdit
        Try
            Dim KilosPromedio As Decimal
            Dim CostoPromedio As Decimal
            Dim Arete As String
            Dim Columna As String
            If e.ColumnIndex = Me.clmArete.Index Or e.ColumnIndex = Me.clmAreteSINIIGA.Index Or e.ColumnIndex = Me.clmAreteTransporte.Index Then
                If Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmArete.Index).Value = "" Then
                    If Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteSINIIGA.Index).Value <> "" Then
                        Arete = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteSINIIGA.Index).Value
                        Columna = Me.clmAreteSINIIGA.Index
                    Else
                        Arete = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteTransporte.Index).Value
                        Columna = Me.clmAreteTransporte.Index
                    End If
                Else
                    Arete = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmArete.Index).Value
                    Columna = Me.clmArete.Index
                End If
                Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmTipoGanado.Index).Value = TipodeGanado
                If Not Me.VerificarAretes(Arete, Columna, e.RowIndex, Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmTipoGanado.Index).Value) Then
                    Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmDetalleCostoxKilo.Index).Value = Me.CostoPorTipoGanado
                    CabezasPorTipodeGanado = Me.dgvDetalleLote.Rows.Count - 1
                    For i As Integer = 0 To Me.dgvDetalleLote.Rows.Count - 2
                        Me.dgvDetalleLote.Rows(i).Cells(Me.clmDetalleKilos.Index).Value = Me.TotalKilosporTipoGanado / Me.CabezasPorTipodeGanado
                    Next
                    KilosPromedio = Me.TotalKilosporTipoGanado / Me.CabezasPorTipodeGanado
                    Me.dgvDetalle.Rows(RenglonDetallePrincipal).Cells(Me.clmCabezas.Index).Value = CabezasPorTipodeGanado
                    Me.CostoPorTipoGanado = Me.dgvDetalle.Rows(RenglonDetallePrincipal).Cells(Me.clmCostoxKilo.Index).Value
                    For i As Integer = 0 To Me.dgvDetalleLote.Rows.Count - 2
                        Me.dgvDetalleLote.Rows(i).Cells(Me.clmDetalleCostoxKilo.Index).Value = Me.CostoPorTipoGanado
                    Next
                    CostoPromedio = Me.CostoPorTipoGanado
                    Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmIdentificador.Index).Value = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmArete.Index).Value & Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteSINIIGA.Index).Value & Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteTransporte.Index).Value
                    Me.RenglonDetalleAretes = e.RowIndex
                    Me.dgvAretesEspejo.Rows.Add(1)
                    ColocarDatosEnEspejo(KilosPromedio, CostoPromedio, TipodeGanado)
                End If
            End If
            If e.ColumnIndex = Me.clmDetalleKilos.Index Then
                Dim CorralRecibaAuxiliar As SalidaGanadoCabeceroClass
                CorralRecibaAuxiliar = New SalidaGanadoCabeceroClass()
                CorralRecibaAuxiliar.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta
                CorralRecibaAuxiliar.IdCorral = Me.cmbCorral.SelectedValue
                CorralRecibaAuxiliar.Detalles.AddNew()
                CorralRecibaAuxiliar.Detalles(0).IdTipoGanado = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmTipoGanado.Index).Value
                CorralRecibaAuxiliar.Detalles(0).Cabezas = 1
                CorralRecibaAuxiliar.Detalles(0).Kilos = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmDetalleKilos.Index).Value
                Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmDetalleCostoxKilo.Index).Value = CorralRecibaAuxiliar.Detalles(0).CostoxKilo
                Me.RenglonDetalleAretes = e.RowIndex
                ColocarDatosEnEspejo(CorralRecibaAuxiliar.Detalles(0).Kilos, CorralRecibaAuxiliar.Detalles(0).CostoxKilo, CorralRecibaAuxiliar.Detalles(0).IdTipoGanado)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvDetalleLote_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalleLote.DataError

    End Sub

    Private Sub dgvDetalleLote_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDetalleLote.GotFocus
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDetalleLote_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvDetalleLote.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvDetalleLote.CurrentRow.Index <> dgvDetalleLote.Rows.Count - 1 Then
                If MessageBox.Show("Seguro que desea eliminarlo", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Dim Identificador As String
                    Dim TipodeGanado As String
                    Identificador = Me.dgvDetalleLote.CurrentRow.Cells(Me.clmIdentificador.Index).Value
                    TipodeGanado = Me.dgvDetalleLote.CurrentRow.Cells(Me.clmTipoGanado.Index).Value
                    Me.dgvDetalleLote.Rows.Remove(Me.dgvDetalleLote.CurrentRow)
                    Me.dgvDetalleLote.Refresh()
                    Me.QuitarDatosdeEspejo(TipodeGanado, Identificador)
                    Me.RecalcularKiloEnDetalleyEspejo()
                End If
            End If
        End If
    End Sub

    Private Sub dgvDetalleLote_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalleLote.RowValidating
        If Me.dgvDetalleLote.Rows(e.RowIndex).IsNewRow Then
            Exit Sub
        End If

        Dim Arete As String, Columna As Integer

        If e.ColumnIndex = Me.clmArete.Index Or e.ColumnIndex = Me.clmAreteSINIIGA.Index Or e.ColumnIndex = Me.clmAreteTransporte.Index Then
            If Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmArete.Index).Value = "" Then
                If Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteSINIIGA.Index).Value <> "" Then
                    Arete = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteSINIIGA.Index).Value
                    Columna = Me.clmAreteSINIIGA.Index
                Else
                    Arete = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmAreteTransporte.Index).Value
                    Columna = Me.clmAreteTransporte.Index
                End If
            Else
                Arete = Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmArete.Index).Value
                Columna = Me.clmArete.Index
            End If
            e.Cancel = Me.VerificarAretes(Arete, Columna, e.RowIndex, Me.dgvDetalleLote.Rows(e.RowIndex).Cells(Me.clmTipoGanado.Index).Value)
        End If

        If Me.Estado = FormState.Nuevo OrElse Me.Estado = FormState.Editar Then
            Utilerias.RunControlException(Me, "ValidarGridDetalleLote", New Object() {e})
        End If
    End Sub

#End Region

  
    Private Sub cmbCausaMuerte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCausaMuerte.KeyDown
        If e.KeyCode = Keys.F12 Then
            ActualizarCausasMuerte()
        End If
    End Sub
End Class