Imports CN = ClasesNegocio
Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class MFacRegEmbarques

#Region "Miembros"

    Dim CodEstado As Integer
    Dim CodCiudad As Integer
    Dim CodPoblacion As Integer
    Dim PuntoEntrega As String
    Dim Colonia As String
    Dim Direccion As String
    Dim Embarque As New CN.EmbarquesClass
    Dim EmbarquesDet As CN.EmbarqueDetalleClass
    Dim EmbarquesDetCol As CN.EmbarqueDetalleCollectionClass

    Private RecepcionCanalDet As CN.RecepcionCanalesDetClass
    Private DecomisosCol As CN.DecomisosColeccionClass

    Dim CortesCol As CN.EmbarqueDetalleCollectionClass
    Dim CanalesCol As CN.EmbarqueDetalleCollectionClass
    Dim Productoscol2 As CN.EmbarqueDetalleCollectionClass
    Dim Modo As Integer
    Dim Importe As Decimal
    Dim Inicio As Boolean
    Dim Autorizo As Boolean
#End Region

    Private Sub MFacRegEmbarques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Inicio = True
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Controlador.Configuracion.Produccion.ObtenerEntidad.Refetch()

            clmCorPrecioEspecial.Visible = Controlador.Configuracion.Produccion.PrecioEmbarque
            clmCanPrecioEspecial.Visible = Controlador.Configuracion.Produccion.PrecioEmbarque
            clmProPrecioEspecial.Visible = Controlador.Configuracion.Produccion.PrecioEmbarque

            Dim TransportesCol As New CC.McgcatVehiculosCollection

            TransportesCol.GetMulti(HC.McgcatVehiculosFields.Estatus = Chr(CN.EstatusChar.VIGENTE))

            Me.CmbTransporte.DisplayMember = "DescVehiculo"
            Me.CmbTransporte.ValueMember = "IdVehiculo"
            Me.CmbTransporte.DataSource = TransportesCol

            Dim ChoferesCol As New CN.ChoferesCollectionClass
            ChoferesCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)


            Me.CmbConductor.DisplayMember = "NombreCompleto"
            Me.CmbConductor.ValueMember = "IdChofer"
            Me.CmbConductor.DataSource = ChoferesCol


            Dim ClientesCol As New CN.ClientesIntroductoresColeccion
            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "Codigo"
            Me.CmbCliente.DataSource = ClientesCol

            Me.cmbClienteAsignado.DisplayMember = "Nombre"
            Me.cmbClienteAsignado.ValueMember = "Codigo"
            Dim ClientesAsignados(ClientesCol.Count - 1) As CN.ClientesIntroductoresClass
            ClientesCol.CopyTo(ClientesAsignados, 0)
            Me.cmbClienteAsignado.DataSource = ClientesAsignados

            Me.ServiciosC.Obtener(CN.TipoServicionEnum.EMBARQUE)
            Me.Limpiar()
            Deshabilitar()
            Inicio = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbCliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCliente.SelectedValueChanged
        If Not CmbCliente.Focused Then
            Exit Sub
        End If

        Try
            Dim PuntosCol As New CC.MgralcatPuntosEntregaCollection

            If Not Inicio And (Modo = 1 Or Modo = 2) And CmbCliente.SelectedIndex > -1 Then
                CmbPuntoEntrega.DataSource = Nothing
                PuntosCol = New CC.MgralcatPuntosEntregaCollection
                PuntosCol.GetMulti(HC.MgralcatPuntosEntregaFields.IdCliente = Me.CmbCliente.SelectedValue)
                CmbPuntoEntrega.DisplayMember = "Descripcion"
                CmbPuntoEntrega.ValueMember = "IdPuntoEntrega"
                CmbPuntoEntrega.DataSource = PuntosCol
                CmbPuntoEntrega.SelectedIndex = -1

                If Not PuntosCol.Count > 0 Then
                    MsgBox("Este cliente no tiene Puntos de Entrega, debera registrar sus Puntos de Entrega", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    CmbCliente.SelectedIndex = -1
                    Exit Sub
                End If

                If Modo = 1 Then
                    Dim Cliente As New CN.ClientesIntroductoresClass(CInt(Me.CmbCliente.SelectedValue))

                    If PuntosCol.Count = 1 Then
                        CmbPuntoEntrega.SelectedIndex = 0
                        ActualizarDatosPuntoDeEntrega()
                    End If

                    If Cliente.DiasCredito = 0 And Cliente.LimiteCredito = 0 Then
                        Exit Sub
                    End If

                    Dim FacturasCol As New CC.CabFacturasCollection()
                    FacturasCol.GetMulti(HC.CabFacturasFields.CveCliente = Me.CmbCliente.SelectedValue And (HC.CabFacturasFields.Status = "V" Or _
                                     HC.CabFacturasFields.Status = "A"))



                    For Each Fact As EC.CabFacturasEntity In FacturasCol
                        If Fact.FecVenci < Now Then

                            If MessageBox.Show("El cliente tiene facturas vencidas, ¿Quiere realizar el embarque?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                Dim Ventana As New FrmAutorizacion
                                Ventana.Icon = Me.Icon
                                Autorizo = False

                                'If Ventana.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                                '    Limpiar()
                                '    Deshabilitar()
                                '    Me.mtb.sbCambiarEstadoBotones("Cancelar")
                                '    Exit Sub
                                'Else
                                '    Autorizo = True
                                '    Exit Sub
                                'End If

                                Autorizo = True

                            Else
                                Limpiar()
                                Deshabilitar()
                                Me.mtb.sbCambiarEstadoBotones("Cancelar")
                                Exit Sub
                            End If
                        End If
                    Next
                ElseIf Modo = 2 Then
                    If Not PuntosCol.Count > 0 Then
                        CmbCliente.SelectedValue = Embarque.IdCliente
                        CmbPuntoEntrega.SelectedValue = Embarque.IdPuntoEntrega
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub CmbPuntoEntrega_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPuntoEntrega.SelectedValueChanged
        If Not sender.Focused Then
            Exit Sub
        End If

        Try
            If Me.CmbPuntoEntrega.ValueMember = "" Then Exit Sub
            If Me.CmbPuntoEntrega.SelectedIndex = -1 Then Exit Sub
            ' se llenan los datos del punto de entrega en pantalla
            ActualizarDatosPuntoDeEntrega()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarDatosPuntoDeEntrega()
        Dim TablaPuntoEntrega As DataSet = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspConMgralcatPuntosEntrega(4, 0, 0, 0, CInt(Me.CmbPuntoEntrega.SelectedValue), CInt(Me.CmbCliente.SelectedValue), Me.CmbPuntoEntrega.Text)
        PuntoEntrega = TablaPuntoEntrega.Tables(0).Rows(0)("Descripcion").ToString()
        Direccion = TablaPuntoEntrega.Tables(0).Rows(0)("Direccion").ToString()
        Colonia = TablaPuntoEntrega.Tables(0).Rows(0)("Colonia").ToString()
        'Me.txtTelefono.Text = TablaPuntoEntrega.Tables(0).Rows(0)("Telefono")
        Me.CodEstado = CInt(TablaPuntoEntrega.Tables(0).Rows(0)("IdEstado"))
        Me.CodCiudad = CInt(TablaPuntoEntrega.Tables(0).Rows(0)("IdCiudad"))
        Me.CodPoblacion = CInt(TablaPuntoEntrega.Tables(0).Rows(0)("IdPoblacion"))

        If Modo = 1 Then
            dgvRelaciondeCortes.DataSource = Nothing
            DgvCanales.DataSource = Nothing
            DgvProductos.DataSource = Nothing
            CortesCol = New CN.EmbarqueDetalleCollectionClass
            CanalesCol = New CN.EmbarqueDetalleCollectionClass
            Productoscol2 = New CN.EmbarqueDetalleCollectionClass
            dgvRelaciondeCortes.DataSource = CortesCol
            DgvCanales.DataSource = CanalesCol
            DgvProductos.DataSource = Productoscol2
        ElseIf Modo = 2 Then
            Dim oPuntoEntrega As New PuntosEntregaClass(CInt(CmbPuntoEntrega.SelectedValue))

            If Not ValidarClienteyPuntoEntrega(oPuntoEntrega.Entidad) Then
                CmbCliente.Focus()
                CmbCliente.SelectedValue = Embarque.IdCliente
                CmbPuntoEntrega.SelectedValue = Embarque.IdPuntoEntrega
            End If
        End If
    End Sub

#Region "Metodos"

    Private Sub Deshabilitar()
        Me.chkParaExportacion.Enabled = False
        Me.CmbCliente.Enabled = False
        Me.CmbConductor.Enabled = False
        Me.CmbPuntoEntrega.Enabled = False
        Me.CmbTransporte.Enabled = False
        Me.DgvCanales.Enabled = False
        Me.DgvProductos.Enabled = False
        Me.dgvRelaciondeCortes.Enabled = False
        Me.dtFechaEmbarque.Enabled = False
        Me.txtReferencia.Enabled = False
        Me.cmdLeerArchivo.Enabled = False
        Me.cmbClienteAsignado.Enabled = False
        Me.chkAsignarCliente.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.chkParaExportacion.Enabled = True
        Me.CmbCliente.Enabled = True
        Me.CmbConductor.Enabled = True
        Me.CmbPuntoEntrega.Enabled = True
        Me.CmbTransporte.Enabled = True
        Me.DgvCanales.Enabled = True
        Me.DgvProductos.Enabled = True
        Me.dgvRelaciondeCortes.Enabled = True
        Me.dtFechaEmbarque.Enabled = True
        Me.txtReferencia.Enabled = True
        Me.cmdLeerArchivo.Enabled = True
        Me.chkAsignarCliente.Enabled = True
        Me.cmbClienteAsignado.Enabled = False

        If Controlador.Configuracion.Produccion.PrecioEmbarque Then
            clmProPrecioEspecial.ReadOnly = False
        End If
    End Sub

    Private Function Validar() As Boolean
        Try
            Dim aux As Boolean
            aux = False
            Dim ValidaListadeCajas As New List(Of CorteMenor)

            If Me.CmbCliente.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbCliente.SelectedIndex = 0
                Me.CmbCliente.Focus()
                Return False
            End If

            If Me.CmbConductor.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un conductor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbConductor.SelectedIndex = 0
                Me.CmbConductor.Focus()
                Return False
            End If

            If Me.CmbPuntoEntrega.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione el punto de entrega", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbPuntoEntrega.SelectedIndex = 0
                Me.CmbPuntoEntrega.Focus()
                Return False
            End If

            If Me.CmbTransporte.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione el transporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbTransporte.SelectedIndex = 0
                Me.CmbTransporte.Focus()
                Return False
            End If

            If Me.Validate Then
                If Me.DgvCanales.Rows.Count > 1 Then
                    aux = True
                ElseIf Me.DgvCanales.Rows.Count = 1 AndAlso Me.DgvCanales.Rows(0).DataBoundItem IsNot Nothing Then
                    aux = True
                End If

                If Not aux Then
                    If Me.DgvProductos.Rows.Count > 1 Then
                        aux = True
                    ElseIf Me.DgvProductos.Rows.Count = 1 AndAlso Me.DgvProductos.Rows(0).DataBoundItem IsNot Nothing Then
                        aux = True
                    End If
                End If

                If Not aux Then
                    If Me.dgvRelaciondeCortes.Rows.Count > 1 Then
                        aux = True
                    ElseIf Me.dgvRelaciondeCortes.Rows.Count = 1 AndAlso Me.dgvRelaciondeCortes.Rows(0).DataBoundItem IsNot Nothing Then
                        aux = True
                    End If
                End If

                If Not aux Then
                    MessageBox.Show("No hay detalle para el embarque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return aux
                End If
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function Guardar(ByVal trans As HC.Transaction) As Boolean
        Try
            'variables para las clases de embarques
            'Dim EmbarqueDetalle As CN.EmbarqueDetalleClass
            Dim Folio As New CN.FoliosClass 'variable para la clase de folio
            Dim Almacen As New CN.AlmacenProduccionClass  'variables para las clases de almacen
            'Dim AlmacenDetalle As CN.AlmacenDetalleClass
            'Dim Inventario As CN.InventarioClass 'variable para la clase de inventario
            Dim CortesDetalle As CN.CortesDetalleClass 'variable para la clase de cortes detalle 
            Dim CanalesDet As CN.RecepcionCanalesDetClass 'variable para los canales
            Dim FolioEmbarque As String
            Dim FolioAlmacen As String = ""

            Embarque = New CN.EmbarquesClass

            'crear folio para embarque.
            Folio.Codigo = CodigodeFolios.Registrodeembarques
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(trans) Then
                trans.Rollback()
                MessageBox.Show("Error al generar folio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            'folio para el registro de embarque
            FolioEmbarque = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
            'asignar datos de embarque a clase de cabecero de embarque
            Embarque.FolioEmbarque = FolioEmbarque
            Embarque.FechaEmbarque = Me.dtFechaEmbarque.Value
            Embarque.Referencia = Me.txtReferencia.Text
            Embarque.FechaCaptura = Now
            Embarque.IdCliente = CInt(Me.CmbCliente.SelectedValue)
            Embarque.IdVehiculo = CInt(Me.CmbTransporte.SelectedValue)
            Embarque.IdChofer = CInt(Me.CmbConductor.SelectedValue)
            Embarque.IdEstado = Me.CodEstado
            Embarque.IdCiudad = Me.CodCiudad
            Embarque.IdPoblacion = Me.CodPoblacion
            Embarque.IdPuntoEntrega = CInt(Me.CmbPuntoEntrega.SelectedValue)
            Embarque.TotalCajas = Integer.Parse(Me.txtCajas.Text)
            Embarque.TotalKilos = CDec(Me.txtKgrs.Text)
            Embarque.TotalPiezas = Integer.Parse(Me.txtPiezas.Text)
            Embarque.Exportacion = Me.chkParaExportacion.Checked
            Embarque.Estatus = EstatusCharX.VIGENTE

            If Me.chkAsignarCliente.Checked Then
                Embarque.IdClienteAsignado = CInt(Me.cmbClienteAsignado.SelectedValue)
            Else
                Embarque.IdClienteAsignado = CInt(Me.CmbCliente.SelectedValue)
            End If

            If Autorizo Then
                Embarque.IdUsuarioAutorizo = CShort(Controlador.Sesion.Usrndx)
            End If

            'guardar cabecero de embarque
            If Not Embarque.Guardar(trans) Then
                trans.Rollback()
                MessageBox.Show("Error al generar embarque", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim ConfigAlmCol As New CC.MscconfigMovtosAlmacenCollection

            ConfigAlmCol.GetMulti(Nothing)

            If ConfigAlmCol.Count = 0 Then
                trans.Rollback()
                MsgBox("Configure los movimientos de almacén", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Select Case -1
                Case ConfigAlmCol(0).SalidaProductoXventa.GetValueOrDefault(-1)
                    trans.Rollback()
                    MsgBox("Configure los movimientos de almacén salida de producto por venta", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                Case ConfigAlmCol(0).SalidaCanalXventa.GetValueOrDefault(-1)
                    trans.Rollback()
                    MsgBox("Configure los movimientos de almacén salida de canalaes por venta", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                Case ConfigAlmCol(0).SalidaCorteXventa.GetValueOrDefault(-1)
                    trans.Rollback()
                    MsgBox("Configure los movimientos de almacén salida de cortes por venta", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
            End Select

            Me.txtFolioEmbarque.Text = Embarque.FolioEmbarque

            'llenado del detalle de embarques y afectacion en el inventario de producto
            Dim renglon As Integer = 0

            For Each Fila As DataGridViewRow In dgvRelaciondeCortes.Rows
                If Not Fila.IsNewRow Then
                    If Trim(dgvRelaciondeCortes.Item(clmIdCorte.Index, Fila.Index).Value) = "" Or Trim(dgvRelaciondeCortes.Item(clmIdCorte.Index, Fila.Index).Value) = "0" Then
                        Exit For
                    End If

                    Dim embarqueDet As EC.MfacEmbarquesDetEntity = Fila.DataBoundItem.Entidad
                    Dim movimientoAlm As New ClasesNegocio.MovimientoAlmacenClass
                    Dim caja As New EC.MscloteCortesDetEntity
                    Dim Precio As Decimal = 0D

                    If Controlador.Configuracion.Produccion.PrecioEmbarque AndAlso IsNumeric(dgvRelaciondeCortes.Item(clmCorPrecioEspecial.Index, Fila.Index).Value) Then
                        Precio = CDec(dgvRelaciondeCortes.Item(clmCorPrecioEspecial.Index, Fila.Index).Value)
                    End If

                    trans.Add(caja)

                    If dgvRelaciondeCortes.Item(clmfetiqueta.Index, Fila.Index).Value.ToString.Trim <> "" Then
                        caja.FetchUsingPK(dgvRelaciondeCortes.Item(LoteCorte.Index, Fila.Index).Value.ToString.Trim, dgvRelaciondeCortes.Item(clmfetiqueta.Index, Fila.Index).Value.ToString.Trim)
                    End If

                    With movimientoAlm
                        If dgvRelaciondeCortes.Item(clmfetiqueta.Index, Fila.Index).Value.ToString.Trim <> "" Then
                            .IdAlmacen = caja.IdAlmacenActual
                        Else
                            .IdAlmacen = 1
                        End If
                        '.IdAlmacen = caja.IdAlmacenActual
                        '.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                        .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Venta)
                        .FechaMovimiento = Me.dtFechaEmbarque.Value
                        .Estatus = EstatusChar.VIGENTE
                        .IdPoliza = ""
                        .Piezas = CInt(dgvRelaciondeCortes.Item(Piezas.Index, Fila.Index).Value)
                        .Kilos = CDec(dgvRelaciondeCortes.Item(Kilos.Index, Fila.Index).Value)
                        .AgregarDetalle(CInt(dgvRelaciondeCortes.Item(clmIdCorte.Index, Fila.Index).Value), _
                                         CDec(dgvRelaciondeCortes.Item(Kilos.Index, Fila.Index).Value), _
                                        CInt(dgvRelaciondeCortes.Item(Piezas.Index, Fila.Index).Value), Precio, 0D)

                        If Not .Guardar(trans) Then
                            trans.Rollback()
                            MsgBox("No se logro guardar el movmineto de almacén", MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        End If
                    End With

                    trans.Add(embarqueDet)
                    embarqueDet.Renglon = renglon
                    embarqueDet.IdFolioEmbarque = FolioEmbarque
                    embarqueDet.IdFolioMovimientoAlmacen = movimientoAlm.FolioMovimiento

                    'clase para la modificacion de lotes de corte en el detalle
                    CortesDetalle = New CN.CortesDetalleClass
                    CortesDetalle.IdFolioLoteCorte = dgvRelaciondeCortes.Item(LoteCorte.Index, Fila.Index).Value.ToString()
                    CortesDetalle.IdFolioEtiqueta = embarqueDet.IdFolioEtiqueta
                    CortesDetalle.IdFolioEmbarque = FolioEmbarque
                    CortesDetalle.Operacion = CortesDetalleClass.OperacionEnum.AsignarEmbarque

                    'llama el guardar del detalle de embarques
                    If Not embarqueDet.Save Then
                        trans.Rollback()
                        MessageBox.Show("Error al guardar el detalle del embarque", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                    'llama el guardar del detalle de cortes
                    If Not embarqueDet.IdFolioEtiqueta.Trim = "" Then
                        If Not CortesDetalle.Guardar(trans) Then
                            trans.Rollback()
                            MessageBox.Show("Error al guardar el detalle de cortes", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If

                    renglon += 1
                End If
            Next

            'Guardar el detalle con los canales del grid
            Dim Topej As Integer = 0

            For j As Integer = 0 To Me.DgvCanales.Rows.Count - 2
                If Trim(DgvCanales.Rows(j).Cells(Me.clmCodigoCanal.Index).Value) = "" Or Trim(DgvCanales.Rows(j).Cells(Me.clmCodigoCanal.Index).Value) = "0" Then
                    Exit For
                End If

                Dim embarqueDet As EC.MfacEmbarquesDetEntity = DgvCanales.Rows(j).DataBoundItem.Entidad
                Dim movimientoAlm As New ClasesNegocio.MovimientoAlmacenClass
                Dim Precio As Decimal = 0D

                If Controlador.Configuracion.Produccion.PrecioEmbarque AndAlso IsNumeric(DgvCanales.Item(clmCanPrecioEspecial.Index, j).Value) Then
                    Precio = CDec(DgvCanales.Item(clmCanPrecioEspecial.Index, j).Value)
                End If

                With movimientoAlm
                    .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
                    .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Venta)
                    .FechaMovimiento = Me.dtFechaEmbarque.Value
                    .Estatus = EstatusChar.VIGENTE
                    .IdPoliza = ""
                    .Piezas = CDec(DgvCanales.Item(clmPiezas.Index, j).Value)
                    .Kilos = CDec(DgvCanales.Item(Me.clmKilos.Index, j).Value)
                    .AgregarDetalle(CInt(DgvCanales.Item(Me.clmCodigoCanal.Index, j).Value), _
                                    CDec(DgvCanales.Item(Me.clmKilos.Index, j).Value), _
                                    CDec(DgvCanales.Item(clmPiezas.Index, j).Value), Precio, 0D)

                    If Not .Guardar(trans) Then
                        trans.Rollback()
                        MsgBox("No se logro guardar el movmineto de almacén", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                End With

                trans.Add(embarqueDet)
                embarqueDet.Renglon = renglon
                embarqueDet.IdFolioEmbarque = FolioEmbarque
                embarqueDet.IdFolioMovimientoAlmacen = movimientoAlm.FolioMovimiento

                'clase para la modificacion de lotes de corte en el detalle
                CanalesDet = New CN.RecepcionCanalesDetClass
                CanalesDet.CodigoBarra = embarqueDet.IdFolioEtiqueta
                CanalesDet.Estatus = ClasesNegocio.EstatusCanal.EMBARCADO
                CanalesDet.Funcion = "M"
                CanalesDet.Opcion = 4
                'EmbarqueDetalle.FolioCorte = dgvRelaciondeCortes.Item(LoteCorte.Index, i).Value

                'llama el guardar del detalle de embarques
                If Not embarqueDet.Save Then
                    trans.Rollback()
                    Return False
                End If

                'llama el guardar del detalle de canales
                If Not embarqueDet.IdFolioEtiqueta = "" Then
                    If Not CanalesDet.Guardar(trans) Then
                        trans.Rollback()
                        Return False
                    End If
                End If

                renglon += 1
            Next

            For k As Integer = 0 To Me.DgvProductos.Rows.Count - 2
                'clase para el detalle de embarques
                If Trim(DgvProductos.Rows(k).Cells(Me.clmProdCodigo.Index).Value) = "" Or Trim(DgvProductos.Rows(k).Cells(Me.clmProdCodigo.Index).Value) = "0" Then
                    'Or Trim(Me.DgvProductos.Rows(k).Cells(Me.clmProdLoteSacrificio.Index).Value) = "" Or Me.DgvProductos.Rows(k).Cells(Me.clmProdLoteSacrificio.Index).Value = "0" Then
                    Exit For
                End If

                Dim embarqueDet As EC.MfacEmbarquesDetEntity = DgvProductos.Rows(k).DataBoundItem.Entidad
                Dim movimientoAlm As New ClasesNegocio.MovimientoAlmacenClass
                Dim Precio As Decimal = 0D

                If Controlador.Configuracion.Produccion.PrecioEmbarque AndAlso IsNumeric(DgvProductos.Item(clmProPrecioEspecial.Index, k).Value) Then
                    Precio = CDec(DgvProductos.Item(clmProPrecioEspecial.Index, k).Value)
                End If

                With movimientoAlm
                    .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.PRODUCTO)
                    .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Producto_X_Venta)
                    .FechaMovimiento = Me.dtFechaEmbarque.Value
                    .Estatus = EstatusChar.VIGENTE
                    .IdPoliza = ""
                    .Piezas = CInt(DgvProductos.Rows(k).Cells(Me.clmProdPiezas.Index).Value)
                    .Kilos = CDec(DgvProductos.Rows(k).Cells(Me.clmProdKilos.Index).Value)
                    .AgregarDetalle(CInt(DgvProductos.Rows(k).Cells(Me.clmProdCodigo.Index).Value), _
                                    CDec(DgvProductos.Rows(k).Cells(Me.clmProdKilos.Index).Value), _
                                    CInt(DgvProductos.Rows(k).Cells(Me.clmProdPiezas.Index).Value), Precio, 0D)

                    If Not .Guardar(trans) Then
                        trans.Rollback()
                        MsgBox("No se logro guardar el movmineto de almacén", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                End With

                trans.Add(embarqueDet)
                embarqueDet.Renglon = renglon
                embarqueDet.IdFolioEmbarque = FolioEmbarque
                embarqueDet.IdFolioMovimientoAlmacen = movimientoAlm.FolioMovimiento

                ' Se actualiza la existencia en productos
                If Me.DgvProductos.Rows(k).Cells(Me.clmProdLoteSacrificio.Index).Value <> "" Then
                    Dim FolioSacrif As String = Me.DgvProductos.Rows(k).Cells(Me.clmProdLoteSacrificio.Index).Value
                    Dim IdProd As Integer = Me.DgvProductos.Rows(k).Cells(Me.clmProdCodigo.Index).Value

                    Dim ent As New EC.RegistroSacrificiosDecomisosEntity

                    trans.Add(ent)

                    ent.FetchUsingPK(FolioSacrif, IdProd)
                    ent.PiezasSalida += embarqueDet.CantPzas
                    ent.KilosSalida += embarqueDet.CantKgrs
                    ent.PiezasEmbarcadas += embarqueDet.CantPzas
                    ent.KilosEmbarcados += embarqueDet.CantKgrs

                    If Not ent.Save Then
                        trans.Rollback()
                        MsgBox("Ocurrio un error al actualizar el producto en el sacrificio", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                End If
                'llama el guardar del detalle de embarques
                If Not embarqueDet.Save Then
                    trans.Rollback()
                    MsgBox("Ocurrio un error al guardar los productos", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                renglon += 1
            Next

            Dim ServXEmbarque As EC.ServiciosXembarqueEntity
            Dim l As Integer = 0

            For Each Serv As CN.ServiciosClass In Me.ServiciosC
                If CBool(Me.dgvServicios.Rows(l).Cells(Me.clmSeleccion.Index).Value) Then
                    ServXEmbarque = New EC.ServiciosXembarqueEntity
                    ServXEmbarque.FoloEmbarque = Embarque.FolioEmbarque
                    ServXEmbarque.IdCliente = Embarque.IdCliente
                    ServXEmbarque.IdServicio = Serv.Codigo
                    trans.Add(ServXEmbarque)

                    If Not ServXEmbarque.Save Then
                        trans.Rollback()
                        Return False
                    End If

                    l += 1
                End If
            Next

            Return True
        Catch ex As Exception
            trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function GuardarAutorizacion(ByVal Trans As HC.Transaction) As Boolean
        Try
            Dim Autorizacion As New EC.AutCreditoEmbEntity
            Autorizacion.Fecha = Now
            Autorizacion.FolioEmbarque = Embarque.FolioEmbarque
            Autorizacion.Importe = Importe
            Autorizacion.Usuario = Controlador.Sesion.Usrndx
            Trans.Add(Autorizacion)

            If Not Autorizacion.Save Then
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Limpiar()
        Me.txtCajas.Text = 0
        Me.txtPiezas.Text = 0
        Me.txtKgrs.Text = 0
        Me.dtFechaEmbarque.Value = Now
        Me.CmbCliente.SelectedIndex = -1
        Me.CmbConductor.SelectedIndex = -1
        Me.CmbPuntoEntrega.SelectedIndex = -1
        Me.CmbTransporte.SelectedIndex = -1
        Me.txtFolioEmbarque.Text = ""
        'Me.txtFolioEtiqueta.Text = ""
        Me.dgvRelaciondeCortes.Rows.Clear()
        Me.DgvCanales.Rows.Clear()
        Me.DgvProductos.Rows.Clear()
        Me.dgvRelaciondeCortes.DataSource = Nothing
        Me.DgvCanales.DataSource = Nothing
        Me.DgvProductos.DataSource = Nothing
        Me.txtKgrsCortes.Text = 0
        Me.txtPzasCortes.Text = 0
        Me.txtKilosCanales.Text = 0
        Me.txtPzasCanales.Text = 0
        Me.txtKilosProd.Text = 0
        Me.txtPzasProd.Text = 0
        Me.LblEstatus.Visible = False
        Me.txtReferencia.Text = ""
        Me.chkParaExportacion.Checked = False

        For i As Integer = 0 To Me.dgvServicios.Rows.Count - 1
            Me.dgvServicios.Rows(i).Cells(Me.clmSeleccion.Index).Value = False
        Next
    End Sub

    Private Function Buscar() As Boolean
        Try
            Dim Consultas As New MConsEmbarques

            If Consultas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Embarque = New CN.EmbarquesClass
                Me.txtFolioEmbarque.Text = Consultas.DgvEmbarques.CurrentRow.Cells(Consultas.IdFolioEmbarque.Index).Value
                Embarque.Obtener(Me.txtFolioEmbarque.Text)

                Me.chkParaExportacion.Checked = Me.Embarque.ObtenerEntidad.Exportacion
                Me.dtFechaEmbarque.Value = Embarque.FechaEmbarque
                Me.txtReferencia.Text = Embarque.Referencia
                Me.CmbCliente.SelectedValue = Embarque.IdCliente

                If Embarque.IdClienteAsignado <> 0 Then
                    Me.cmbClienteAsignado.SelectedValue = Embarque.IdClienteAsignado
                End If

                If Embarque.IdClienteAsignado <> Embarque.IdCliente Then
                    chkAsignarCliente.Checked = True
                End If
                Me.cmbClienteAsignado.Enabled = False
                Me.CmbConductor.SelectedValue = Embarque.IdChofer

                Dim PuntosCol As New CC.MgralcatPuntosEntregaCollection
                PuntosCol.GetMulti(HC.MgralcatPuntosEntregaFields.IdCliente = Me.CmbCliente.SelectedValue)
                CmbPuntoEntrega.DisplayMember = "Descripcion"
                CmbPuntoEntrega.ValueMember = "IdPuntoEntrega"
                CmbPuntoEntrega.DataSource = PuntosCol

                Me.CmbPuntoEntrega.SelectedValue = Embarque.IdPuntoEntrega
                Me.CmbTransporte.SelectedValue = Embarque.IdVehiculo
                Me.txtReferencia.Text = Embarque.Referencia
                Me.CodEstado = Embarque.IdEstado
                Me.CodCiudad = Embarque.IdCiudad
                Me.CodPoblacion = Embarque.IdPoblacion
                Me.LblEstatus.Text = Embarque.Estatus.ToString
                Me.LblEstatus.Visible = True

                CortesCol = New CN.EmbarqueDetalleCollectionClass
                CanalesCol = New CN.EmbarqueDetalleCollectionClass
                Productoscol2 = New CN.EmbarqueDetalleCollectionClass
                Me.EmbarquesDetCol = Embarque.Detalles

                For Each Det As CN.EmbarqueDetalleClass In Embarque.Detalles
                    'EmbarquesDetCol.Add(Det)

                    Select Case Det.TipoProducto
                        Case ClasesNegocio.TipoProductoEnum.CORTE
                            CortesCol.Add(Det)

                        Case ClasesNegocio.TipoProductoEnum.CANAL
                            CanalesCol.Add(Det)

                        Case ClasesNegocio.TipoProductoEnum.PRODUCTO
                            Productoscol2.Add(Det)
                    End Select
                Next

                Me.dgvRelaciondeCortes.AutoGenerateColumns = False
                Me.dgvRelaciondeCortes.DataSource = CortesCol
                Me.TotalCortes(True)

                Me.DgvCanales.AutoGenerateColumns = False
                Me.DgvCanales.DataSource = CanalesCol
                Me.TotalCanales(True)

                Me.DgvProductos.AutoGenerateColumns = False
                Me.DgvProductos.DataSource = Productoscol2
                Me.TotalProductos(True)

                Dim ColServ As New CC.ServiciosXembarqueCollection
                ColServ.GetMulti(HC.ServiciosXembarqueFields.FoloEmbarque = Embarque.FolioEmbarque And HC.ServiciosXembarqueFields.IdCliente = Embarque.IdCliente)
                Dim i As Integer
                If ColServ.Count > 0 Then
                    For Each SerEnty As EC.ServiciosXembarqueEntity In ColServ
                        i = 0
                        For Each serv As CN.ServiciosClass In Me.ServiciosC
                            If SerEnty.IdServicio = serv.Codigo Then
                                Me.dgvServicios.Rows(i).Cells(Me.clmSeleccion.Index).Value = True
                                Exit For
                            End If
                            i = i + 1
                        Next
                    Next
                End If
            Else
                Return False
            End If

            Me.txtFolioEmbarque.Focus()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Imprimir() As Boolean
        Try
            If Not chkParaExportacion.Checked Then
                Dim TablaEmbarque As DataSet = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspRptEmbarques(1, Me.txtFolioEmbarque.Text, 0, False)
                'Dim DatosEmbarque As New Embarques
                'For Each Renglon As DataRow In TablaEmbarque.Tables(0).Rows
                '    DatosEmbarque.DataTable1.AddDataTable1Row(Renglon("IdFolioEmbarque"), Renglon("fechaembarque"), Renglon("Nombre"), Renglon("Vehiculo"), Renglon("chofer"), Renglon("TotalPiezas"), _
                '                                              Renglon("totalKgrs"), Renglon("TotalCajas"), Renglon("Estado"), Renglon("Ciudad"), Renglon("Poblacion"), Renglon("Descripcion"), Renglon("Direccion"), _
                '                                              Renglon("Colonia"), Renglon("Telefono"), Renglon("CodigoPostal"), Renglon("IdFolioEtiqueta"), Renglon("IdProducto"), Renglon("Producto"), _
                '                                              Renglon("CantPzas"), Renglon("CantKgrs"))
                'Next
                Dim Reporte As New RegEmbarques
                Dim Bandera As Boolean

                Reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

                If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                    Bandera = True
                Else
                    Bandera = False
                End If

                Reporte.SetDataSource(TablaEmbarque.Tables(0))
                Reporte.SetParameterValue(0, Bandera)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiEmpresa.Empnom)

                Dim VerReporte As New FrmReportes

                VerReporte.CRV.ReportSource = Reporte
                VerReporte.ShowDialog()
            Else
                Dim Reporte As New rptPackingList
                Dim Bandera As Boolean

                Reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter

                Controlador.Configuracion.ActualizarProduccion()

                If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                    Bandera = True
                Else
                    Bandera = False
                End If

                Dim Cliente As New EC.MfacCatClientesEntity(Embarque.IdCliente)

                Dim Domicilio As New EC.MfacClientesDatosFiscalesEntity(Cliente.IdCliente, 1)
                Dim Poblacion As New EC.PoblacionEntity(Domicilio.IdEstado, Domicilio.IdCiudad, Domicilio.IdPoblacion)
                Dim Cds As New EC.CiudadEntity(Domicilio.IdEstado, Domicilio.IdCiudad)
                Dim Edos As New EC.EstadoEntity(Domicilio.IdEstado)
                Dim Vista As New TC.VwConsultaPakingListDetalleTypedView()

                Vista.Fill(0, New OC.SortExpression(New OC.SortClause(HC.VwConsultaPakingListDetalleFields.ProductoIngles, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), True, HC.VwConsultaPakingListDetalleFields.IdFolioEmbarque = Embarque.FolioEmbarque)

                Reporte.SetDataSource(CType(Vista, Object))
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiEmpresa.EmpDomicilio)
                Reporte.SetParameterValue(2, Controlador.Sesion.MiEmpresa.EmpTelefono)
                Reporte.SetParameterValue(3, Embarque.FechaEmbarque)
                Reporte.SetParameterValue(4, Cliente.Nombre & " (" & Cliente.IdCliente.ToString & ")")
                Reporte.SetParameterValue(5, Domicilio.Domicilio)
                Reporte.SetParameterValue(6, Poblacion.Descripcion)
                Reporte.SetParameterValue(7, Cds.Descripcion)
                Reporte.SetParameterValue(8, Edos.Descripcion)
                Reporte.SetParameterValue(9, Controlador.Sesion.MiEmpresa.EmpRfc)
                Reporte.SetParameterValue(10, "Ventas/Registro de Embarques/Exportacion")
                Reporte.SetParameterValue(11, Controlador.Sesion.MiUsuario.Usrnomcom)

                Dim VerReporte As New FrmReportes

                VerReporte.CRV.ReportSource = Reporte
                VerReporte.ShowDialog()
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub TotalCortes(Optional ByVal MostrarDevueltos As Boolean = False)
        Try
            Dim SumKilos As Decimal = 0D
            Dim SumPiezas As Decimal = 0D
            Me.txtKgrsCortes.Text = ""
            Me.txtPzasCortes.Text = ""

            For Each Fila As DataGridViewRow In Me.dgvRelaciondeCortes.Rows
                If Not Fila.IsNewRow Then
                    SumPiezas += CDec(Fila.Cells(Me.Piezas.Index).Value)
                    SumKilos += CDec(Fila.Cells(Me.Kilos.Index).Value)

                    If MostrarDevueltos AndAlso Not Fila.IsNewRow Then
                        If CType(Fila.DataBoundItem, EmbarqueDetalleClass).Estatus = EstatusCharX.DEVUELTO Then
                            Fila.DefaultCellStyle.ForeColor = Color.Red
                        End If
                    End If
                End If
            Next

            Me.txtPzasCortes.Text = SumPiezas
            Me.txtKgrsCortes.Text = SumKilos

            Total()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TotalCanales(Optional ByVal MostrarDevueltos As Boolean = False)
        Try
            Dim SumKilos As Decimal = 0D
            Dim SumPiezas As Decimal = 0D
            Me.txtKilosCanales.Text = ""
            Me.txtPzasCanales.Text = ""

            For Each Fila As DataGridViewRow In Me.DgvCanales.Rows
                If Not Fila.IsNewRow Then
                    SumPiezas += CDec(Fila.Cells(Me.clmPiezas.Index).Value)
                    SumKilos += CDec(Fila.Cells(Me.clmKilos.Index).Value)

                    If MostrarDevueltos AndAlso Not Fila.IsNewRow Then
                        If CType(Fila.DataBoundItem, EmbarqueDetalleClass).Estatus = EstatusCharX.DEVUELTO Then
                            Fila.DefaultCellStyle.ForeColor = Color.Red
                        End If
                    End If
                End If
            Next

            Me.txtPzasCanales.Text = SumPiezas
            Me.txtKilosCanales.Text = SumKilos

            Total()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TotalProductos(Optional ByVal MostrarDevueltos As Boolean = False)
        Try
            Dim SumKilos As Decimal = 0D
            Dim SumPiezas As Decimal = 0D
            Me.txtKilosProd.Text = ""
            Me.txtPzasProd.Text = ""

            For Each Fila As DataGridViewRow In Me.DgvProductos.Rows
                If Not Fila.IsNewRow Then
                    SumPiezas += CDec(Fila.Cells(Me.clmProdPiezas.Index).Value)
                    SumKilos += CDec(Fila.Cells(Me.clmProdKilos.Index).Value)

                    If MostrarDevueltos AndAlso Not Fila.IsNewRow Then
                        If CType(Fila.DataBoundItem, EmbarqueDetalleClass).Estatus = EstatusCharX.DEVUELTO Then
                            Fila.DefaultCellStyle.ForeColor = Color.Red
                        End If
                    End If
                End If
            Next

            Me.txtKilosProd.Text = SumKilos
            Me.txtPzasProd.Text = SumPiezas

            Total()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Total()
        Try
            Me.txtKgrs.Text = ""
            Me.txtPiezas.Text = ""
            Me.txtCajas.Text = ""

            Me.txtKgrs.Text = CDec(Me.txtKilosProd.Text) + CDec(Me.txtKgrsCortes.Text) + CDec(Me.txtKilosCanales.Text)
            Me.txtPiezas.Text = CDec(Me.txtPzasProd.Text) + CDec(Me.txtPzasCanales.Text) + CDec(Me.txtPzasCortes.Text)
            Me.txtCajas.Text = Me.dgvRelaciondeCortes.Rows.Count + Me.DgvCanales.Rows.Count + Me.DgvProductos.Rows.Count - 3
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PonerDatos()
        Me.Embarque.ObtenerEntidad.Exportacion = Me.chkParaExportacion.Checked
        Me.Embarque.IdChofer = Me.CmbConductor.SelectedValue
        Me.Embarque.IdCliente = Me.CmbCliente.SelectedValue

        If Not Me.chkAsignarCliente.Checked Then
            Me.Embarque.IdClienteAsignado = Me.CmbCliente.SelectedValue
        Else
            Me.Embarque.IdClienteAsignado = Me.cmbClienteAsignado.SelectedValue
        End If

        Embarque.FechaEmbarque = Me.dtFechaEmbarque.Value
        Me.Embarque.IdPuntoEntrega = Me.CmbPuntoEntrega.SelectedValue
        Embarque.Estatus = ClasesNegocio.EstatusCharX.VIGENTE
        Embarque.IdEstado = Me.CodEstado
        Embarque.IdCiudad = Me.CodCiudad
        Embarque.IdPoblacion = Me.CodPoblacion
        Embarque.IdVehiculo = Me.CmbTransporte.SelectedValue
        Embarque.TotalCajas = Me.txtCajas.Text
        Embarque.TotalKilos = Me.txtKgrs.Text
        Embarque.TotalCajas = Me.txtCajas.Text
        Embarque.Referencia = Me.txtReferencia.Text
    End Sub

    Private Function ChecarCredito() As Integer
        Try
            If Me.CmbCliente.SelectedIndex > -1 And Me.CmbPuntoEntrega.SelectedIndex > -1 Then
                Dim Cliente As CN.ClientesIntroductoresClass = Me.CmbCliente.SelectedItem

                Dim PrexCortCol As CC.CatPrexCortCollection
                Dim PreXProd As CC.CatPrexProdCollection
                Dim productosSinPrecio As String = ""
                Dim listaProductos As New List(Of String)

                For Each Fila As DataGridViewRow In Me.dgvRelaciondeCortes.Rows
                    If Not Fila.IsNewRow Then
                        PrexCortCol = New CC.CatPrexCortCollection

                        PrexCortCol.GetMulti(HC.CatPrexCortFields.CveCliente = Me.CmbCliente.SelectedValue And _
                                    HC.CatPrexCortFields.CveDestino = Me.CmbPuntoEntrega.SelectedValue _
                                    And HC.CatPrexCortFields.CveSubCorte = _
                                    Fila.Cells(Me.clmIdCorte.Index).Value)

                        If PrexCortCol.Count > 0 Then
                            Importe += PrexCortCol(0).PrecioxKgr
                        Else
                            If listaProductos.Count > 0 AndAlso _
                                listaProductos.IndexOf(Fila.Cells(Me.clmDesCorte.Index).Value.ToString.Trim) = -1 Then
                                productosSinPrecio &= Fila.Cells(Me.clmDesCorte.Index).Value.ToString.Trim & ", "
                                listaProductos.Add(Fila.Cells(Me.clmDesCorte.Index).Value.ToString.Trim)
                            Else
                                productosSinPrecio &= Fila.Cells(Me.clmDesCorte.Index).Value.ToString.Trim & ", "
                                listaProductos.Add(Fila.Cells(Me.clmDesCorte.Index).Value.ToString.Trim)
                            End If

                            'MsgBox("No se encontro el precio de un producto, Capture los precios para el cliente", MsgBoxStyle.Exclamation, "Aviso")
                            'Return 1
                        End If
                    End If
                Next

                Dim ImpDisponible As Decimal

                ImpDisponible = Cliente.LimiteCredito - Cliente.ObtenerSaldoDeuda

                If Importe > ImpDisponible Then
                    Return 2
                End If

                For Each Fila As DataGridViewRow In Me.DgvCanales.Rows
                    If Not Fila.IsNewRow Then
                        PreXProd = New CC.CatPrexProdCollection

                        PreXProd.GetMulti(HC.CatPrexProdFields.CveCliente = Me.CmbCliente.SelectedValue And HC.CatPrexProdFields.CveDestino = Me.CmbPuntoEntrega.SelectedValue _
                                            And HC.CatPrexProdFields.CveProdRas = Fila.Cells(Me.clmCodigoCanal.Index).Value)

                        If PreXProd.Count > 0 Then
                            Importe += PreXProd(0).PrecioxKgr
                        Else
                            If listaProductos.Count > 0 AndAlso _
                                listaProductos.IndexOf(Fila.Cells(Me.clmDesCanal.Index).Value.ToString.Trim) = -1 Then
                                productosSinPrecio &= Fila.Cells(Me.clmDesCanal.Index).Value.ToString.Trim & ", "
                                listaProductos.Add(Fila.Cells(Me.clmDesCanal.Index).Value.ToString.Trim)
                            Else
                                productosSinPrecio &= Fila.Cells(Me.clmDesCanal.Index).Value.ToString.Trim & ", "
                                listaProductos.Add(Fila.Cells(Me.clmDesCanal.Index).Value.ToString.Trim)
                            End If
                            'MsgBox("No se encontro el precio de un producto, Capture los precios para el cliente", MsgBoxStyle.Exclamation, "Aviso")
                            'Return 1
                        End If
                    End If
                Next

                If Importe > ImpDisponible Then
                    Return 2
                End If

                For Each Fila As DataGridViewRow In Me.DgvProductos.Rows
                    If Not Fila.IsNewRow Then
                        PreXProd = New CC.CatPrexProdCollection

                        PreXProd.GetMulti(HC.CatPrexProdFields.CveCliente = Me.CmbCliente.SelectedValue And _
                                            HC.CatPrexProdFields.CveDestino = Me.CmbPuntoEntrega.SelectedValue _
                                            And HC.CatPrexProdFields.CveProdRas = Fila.Cells(Me.clmProdCodigo.Index).Value)

                        If PreXProd.Count > 0 Then
                            Importe += PreXProd(0).PrecioxKgr
                        Else
                            If listaProductos.Count > 0 AndAlso _
                                listaProductos.IndexOf(Fila.Cells(Me.clmProdDescripcion.Index).Value.ToString.Trim) = -1 Then
                                productosSinPrecio &= Fila.Cells(Me.clmProdDescripcion.Index).Value.ToString.Trim & ", "
                                listaProductos.Add(Fila.Cells(Me.clmProdDescripcion.Index).Value.ToString.Trim)
                            Else
                                productosSinPrecio &= Fila.Cells(Me.clmProdDescripcion.Index).Value.ToString.Trim & ", "
                                listaProductos.Add(Fila.Cells(Me.clmProdDescripcion.Index).Value.ToString.Trim)
                            End If

                            'MsgBox("No se encontro el precio de un producto, Capture los precios para el cliente", MsgBoxStyle.Exclamation, "Aviso")
                            'Return 1
                        End If
                    End If
                Next

                If Not productosSinPrecio.Trim.Length = 0 Then
                    productosSinPrecio = productosSinPrecio.Substring(0, productosSinPrecio.Trim.Length - 1)
                    MsgBox("Los siguientes productos, cajas o canales no tienen precio" & vbNewLine & productosSinPrecio, MsgBoxStyle.Exclamation, "Aviso")
                    Return 1
                End If

                If Importe > ImpDisponible Then
                    Return 2
                End If

                Return 3
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 1
        End Try
    End Function
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Borrar")

        Try
            If Me.Embarque.Estatus = ClasesNegocio.EstatusCharX.FACTURADO Then
                MessageBox.Show("No se puede cancelar el Embarque, se encuentra facturado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If Me.Embarque.Estatus = ClasesNegocio.EstatusCharX.CANCELADO Then
                MessageBox.Show("El embarque actualmente esta cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("¿Esta seguro de cancelar el Embarque?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Embarque.Estatus = ClasesNegocio.EstatusCharX.CANCELADO
            Embarque.FechaCancelacion = Now

            If Not Embarque.Borrar(trans) Then
                trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            trans.Commit()
            MessageBox.Show("Se ha cancelado el embarque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Deshabilitar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Modo = 0
        Cancelar = Not Buscar()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            Dim col As New CC.MfacEmbarquesDetCollection

            'If Embarque.Detalles.Count = col.GetDbCount(HC.MfacEmbarquesDetFields.IdFolioEmbarque = _
            '    Embarque.FolioEmbarque And (HC.MfacEmbarquesDetFields.NoFactura = "" Or _
            '    HC.MfacEmbarquesDetFields.NoFactura = DBNull.Value)) Then

            'End If

            If Not Embarque.Detalles.Count = col.GetDbCount(HC.MfacEmbarquesDetFields.IdFolioEmbarque = _
                Embarque.FolioEmbarque And (HC.MfacEmbarquesDetFields.NoFactura = "" Or _
                HC.MfacEmbarquesDetFields.NoFactura = DBNull.Value)) Then
                MessageBox.Show("No se puede editar el ambarque, se encuentra facturado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If Me.Embarque.Estatus = ClasesNegocio.EstatusCharX.CANCELADO Then
                MessageBox.Show("No se puede editar el ambarque, se encuentra Cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            Modo = 2 'Edicion
            Habilitar()

            If chkAsignarCliente.Checked Then
                cmbClienteAsignado.Enabled = True
            End If

            For Each Fila As DataGridViewRow In Me.dgvRelaciondeCortes.Rows
                Fila.Cells(clmCorPrecioEspecial.Index).ReadOnly = True

                If Not Fila.IsNewRow Then
                    If Fila.Cells(Me.clmDesCorte.Index).Value IsNot Nothing _
                    AndAlso Fila.Cells(Me.clmDesCorte.Index).Value.ToString.Trim <> String.Empty Then
                        Fila.ReadOnly = True

                        If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                            Fila.Cells(clmCorPrecioEspecial.Index).ReadOnly = False
                        End If
                    End If
                End If
            Next

            For Each Fila As DataGridViewRow In Me.DgvCanales.Rows
                Fila.Cells(clmCanPrecioEspecial.Index).ReadOnly = True

                If Not Fila.IsNewRow Then
                    If Fila.Cells(Me.clmDesCanal.Index).Value IsNot Nothing _
                    AndAlso Fila.Cells(Me.clmDesCanal.Index).Value.ToString.Trim <> String.Empty Then
                        Fila.ReadOnly = True

                        If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                            Fila.Cells(clmCanPrecioEspecial.Index).ReadOnly = False
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Modificar")

        Try
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                MsgBox("Debe establecer la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            Dim Cliente As New CN.ClientesIntroductoresClass(CInt(Me.CmbCliente.SelectedValue))

            If Not Cliente.DiasCredito = 0 And Not Cliente.LimiteCredito = 0 Then
                Dim Limite As Integer = Me.ChecarCredito

                If Limite = 1 Then
                    If MessageBox.Show("No se pudo verificar el limite de crédito del cliente, ¿Aún asi desea generar el embarque?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Limpiar()
                        Deshabilitar()
                        Me.mtb.sbCambiarEstadoBotones("Cancelar")
                        Exit Sub
                    Else
                        Dim Ventana As New FrmAutorizacion

                        Ventana.Icon = Me.Icon
                        Autorizo = False

                        If Ventana.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                            Limpiar()
                            Deshabilitar()
                            Me.mtb.sbCambiarEstadoBotones("Cancelar")
                            Exit Sub
                        Else
                            Autorizo = True
                        End If
                    End If
                ElseIf Limite = 2 Then
                    If MessageBox.Show("El cliente sobrepasará su limite de crédito si realiza el embarque, ¿Aún asi desea generar el embarque?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Limpiar()
                        Deshabilitar()
                        Me.mtb.sbCambiarEstadoBotones("Cancelar")
                        Exit Sub
                    Else
                        Dim Ventana As New FrmAutorizacion

                        Ventana.Icon = Me.Icon
                        Autorizo = False

                        If Ventana.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                            Limpiar()
                            Deshabilitar()
                            Me.mtb.sbCambiarEstadoBotones("Cancelar")
                            Exit Sub
                        Else
                            Autorizo = True
                        End If
                    End If
                End If
            End If

            If Modo = 2 Then 'modo edicion
                PonerDatos()

                If Not Me.Embarque.Guardar2(Controlador.Configuracion.Produccion.PrecioEmbarque, trans) Then
                    trans.Rollback()
                    Cancelar = True
                    Exit Sub
                Else
                    If Autorizo Then
                        If Not GuardarAutorizacion(trans) Then
                            trans.Rollback()
                            MessageBox.Show("No se puede generar embarque de cortes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Cancelar = True
                            Exit Sub
                        End If
                    End If

                    trans.Commit()
                    MessageBox.Show("Se ha modificado el embarque: " & Me.txtFolioEmbarque.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Deshabilitar()
                    Exit Sub
                End If
            End If

            If Not Guardar(trans) Then
                trans.Rollback()
                MessageBox.Show("No se puede generar embarque de cortes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cancelar = True
            Else
                If Autorizo Then
                    If Not GuardarAutorizacion(trans) Then
                        trans.Rollback()
                        MessageBox.Show("No se puede generar embarque de cortes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Cancelar = True
                        Exit Sub
                    End If
                End If

                trans.Commit()
                MessageBox.Show("Se genero embarque de cortes con folio : " & Me.txtFolioEmbarque.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Not Imprimir() Then
                    MessageBox.Show("No se logro Imprimir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                Me.Limpiar()
                Deshabilitar()
            End If
        Catch ex As Exception
            trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Controlador.Configuracion.ActualizarProduccion()

        If Controlador.Configuracion.Produccion.Entidad.IsNew Then
            MsgBox("Debe establecer la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If

        If Not Imprimir() Then
            MessageBox.Show("No se encuentra embarque disponible para impresion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Limpiar()
            Habilitar()
            Me.txtReferencia.Focus()
            CortesCol = New CN.EmbarqueDetalleCollectionClass
            CanalesCol = New CN.EmbarqueDetalleCollectionClass
            Productoscol2 = New CN.EmbarqueDetalleCollectionClass
            Me.dgvRelaciondeCortes.AutoGenerateColumns = False
            Me.dgvRelaciondeCortes.DataSource = CortesCol
            Me.DgvCanales.AutoGenerateColumns = False
            Me.DgvCanales.DataSource = CanalesCol
            Me.DgvProductos.AutoGenerateColumns = False
            Me.DgvProductos.DataSource = Productoscol2
            Modo = 1 'inserccion
        Catch ex As Exception
            MsgBox(e.Button, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Grids"
    Private Sub dgvRelaciondeCortes_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRelaciondeCortes.CellEndEdit
        Try
            Select Case e.ColumnIndex
                Case Etiqueta.Index
                    If Me.dgvRelaciondeCortes.CurrentRow.Cells(Etiqueta.Index).Value IsNot Nothing AndAlso Me.dgvRelaciondeCortes.CurrentRow.Cells(Etiqueta.Index).Value.ToString.Trim <> String.Empty Then
                        Me.EmbarquesDet = New CN.EmbarqueDetalleClass
                        Dim DatosCorte As New DataSet

                        DatosCorte = EmbarquesDet.ObtenerEtiqueta(CStr(Me.dgvRelaciondeCortes.CurrentRow.Cells(Etiqueta.Index).Value))

                        Me.dgvRelaciondeCortes.CurrentRow.Cells(clmCorPrecioEspecial.Index).ReadOnly = True

                        If DatosCorte.Tables(0).Rows.Count > 0 Then
                            Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.clmIdCorte.Index).Value = DatosCorte.Tables(0).Rows(0)("IdProducto")
                            Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.clmDesCorte.Index).Value = DatosCorte.Tables(0).Rows(0)("Nom_SubCorte")
                            Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.Piezas.Index).Value = DatosCorte.Tables(0).Rows(0)("CantPzas")
                            Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.Kilos.Index).Value = DatosCorte.Tables(0).Rows(0)("CantKgrs")
                            Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.LoteCorte.Index).Value = DatosCorte.Tables(0).Rows(0)("LoteCorte")
                            Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.clmIdPreCorte.Index).Value = DatosCorte.Tables(0).Rows(0)("IdCorte")
                            Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.clmfetiqueta.Index).Value = DatosCorte.Tables(0).Rows(0)("idfolioetiqueta")

                            Dim DetEmbarque As EmbarqueDetalleClass = CType(dgvRelaciondeCortes.CurrentRow.DataBoundItem, EmbarqueDetalleClass)
                            DetEmbarque.TipoProducto = TipoProductoEnum.CORTE

                            If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                MsgBox("El corte: " & DatosCorte.Tables(0).Rows(0)("Nom_SubCorte").ToString.Trim & " no tiene precio, por favor definaselo.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)

                                RemoveHandler dgvRelaciondeCortes.RowValidating, AddressOf dgvRelaciondeCortes_RowValidating
                                dgvRelaciondeCortes.Rows.RemoveAt(dgvRelaciondeCortes.CurrentRow.Index)
                                AddHandler dgvRelaciondeCortes.RowValidating, AddressOf dgvRelaciondeCortes_RowValidating
                                Exit Sub
                            End If
                            Me.dgvRelaciondeCortes.CurrentRow.ReadOnly = True

                            If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                                Me.dgvRelaciondeCortes.CurrentRow.Cells(clmCorPrecioEspecial.Index).ReadOnly = False
                            End If

                            TotalCortes()

                            If Modo = 2 Then
                                Me.Productoscol2(Productoscol2.Count - 1).Renglon = Me.Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                Me.EmbarquesDetCol.AgregarProducto(Me.Productoscol2(Productoscol2.Count - 1))
                            End If
                        End If
                    End If
                Case Me.Kilos.Index
                    If IsNumeric(Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.Kilos.Index).Value) Then
                        TotalCortes()
                    Else
                        dgvRelaciondeCortes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0D
                    End If
                Case Me.clmPiezas.Index
                    If IsNumeric(Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.clmPiezas.Index).Value) Then
                        TotalCortes()
                    Else
                        dgvRelaciondeCortes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0D
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRelaciondeCortes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvRelaciondeCortes.DataError
        MessageBox.Show(e.Exception.ToString)
    End Sub

    Private Sub DgvCanales_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCanales.CellEndEdit
        Try
            Select Case e.ColumnIndex
                Case Me.ClmEtiqueta.Index
                    If Me.DgvCanales.CurrentRow.Cells(Me.ClmEtiqueta.Index).Value IsNot Nothing _
                    AndAlso Me.DgvCanales.CurrentRow.Cells(Me.ClmEtiqueta.Index).Value.ToString.Trim <> String.Empty Then
                        Dim DsCanal As New DataSet

                        Me.RecepcionCanalDet = New CN.RecepcionCanalesDetClass
                        RecepcionCanalDet.Opcion = 6
                        RecepcionCanalDet.FolioSacrificio = ""
                        RecepcionCanalDet.CodigoBarra = DgvCanales.CurrentRow.Cells(Me.ClmEtiqueta.Index).Value
                        DsCanal = Me.RecepcionCanalDet.Obtener(RecepcionCanalDet.Opcion, RecepcionCanalDet.FolioSacrificio, RecepcionCanalDet.CodigoBarra, Now)

                        Me.DgvCanales.CurrentRow.Cells(clmCanPrecioEspecial.Index).ReadOnly = True

                        If DsCanal.Tables(0).Rows.Count > 0 Then
                            Dim ProdCol As New CC.MsccatProductosCollection
                            ProdCol.GetMulti(HC.MsccatProductosFields.Canal = True)
                            Me.DgvCanales.CurrentRow.Cells(Me.clmCodigoCanal.Index).Value = ProdCol(0).IdProducto
                            Me.DgvCanales.CurrentRow.Cells(Me.clmDesCanal.Index).Value = ProdCol(0).Descripcion
                            Me.DgvCanales.CurrentRow.Cells(Me.clmPiezas.Index).Value = 1
                            Me.DgvCanales.CurrentRow.Cells(Me.clmKilos.Index).Value = DsCanal.Tables(0).Rows(0)("KgrsBascula")
                            Dim DetEmbarque As EmbarqueDetalleClass = CType(DgvCanales.CurrentRow.DataBoundItem, EmbarqueDetalleClass)
                            DetEmbarque.TipoProducto = TipoProductoEnum.CANAL

                            If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                MsgBox("El canal: " & ProdCol(0).Descripcion.Trim & " no tiene precio, por favor definaselo.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)

                                RemoveHandler DgvCanales.RowValidating, AddressOf dgvCanales_RowValidating
                                DgvCanales.Rows.RemoveAt(DgvCanales.CurrentRow.Index)
                                AddHandler DgvCanales.RowValidating, AddressOf dgvCanales_RowValidating
                            End If
                            Me.DgvCanales.CurrentRow.ReadOnly = True

                            If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                                Me.DgvCanales.CurrentRow.Cells(clmCanPrecioEspecial.Index).ReadOnly = False
                            End If

                            TotalCanales()

                            If Modo = 2 Then
                                Me.CanalesCol(CanalesCol.Count - 1).Renglon = Me.Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                Me.CanalesCol(CanalesCol.Count - 1).TipoProducto = ClasesNegocio.TipoProductoEnum.CANAL
                                Me.EmbarquesDetCol.AgregarProducto(Me.CanalesCol(CanalesCol.Count - 1))
                            End If
                        End If
                    End If

                Case Me.clmKilos.Index
                    If IsNumeric(Me.DgvCanales.CurrentRow.Cells(Me.clmKilos.Index).Value) Then
                        TotalCanales()
                    End If

                Case Me.clmPiezas.Index
                    If IsNumeric(Me.DgvCanales.CurrentRow.Cells(Me.clmPiezas.Index).Value) Then
                        TotalCanales()
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvCanales_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvCanales.DataError

    End Sub

    Private Sub DgvProductos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProductos.CellEndEdit
        Try
            Select Case e.ColumnIndex
                Case Me.clmProdCodigo.Index
                    If CInt(Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value) > 0 Then
                        If Not Me.DgvProductos.CurrentRow.Cells(Me.clmProdLoteSacrificio.Index).Value.ToString.Trim = "" Then
                            Dim CodProducto As Integer = CInt(Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value)
                            DecomisosCol = New CN.DecomisosColeccionClass
                            Dim FolioSacrificio As String = Me.DgvProductos.CurrentRow.Cells(Me.clmProdLoteSacrificio.Index).Value
                            DecomisosCol.Obtener(CodProducto, FolioSacrificio, CondicionEnum.ACTIVOS)

                            If DecomisosCol.Count > 0 Then
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdDescripcion.Index).Value = DecomisosCol(0).NombreProducto
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdKilos.Index).Value = DecomisosCol(0).Kilos
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdPiezas.Index).Value = DecomisosCol(0).Piezas
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdLoteSacrificio.Index).Value = DecomisosCol(0).LoteSacrificio
                                Dim DetEmbarque As EmbarqueDetalleClass = CType(DgvProductos.CurrentRow.DataBoundItem, EmbarqueDetalleClass)
                                DetEmbarque.TipoProducto = TipoProductoEnum.PRODUCTO

                                If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                    MsgBox("El producto: " & DecomisosCol(0).NombreProducto.Trim & " no tiene precio, por favor definaselo.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)

                                    RemoveHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating
                                    DgvProductos.Rows.RemoveAt(DgvProductos.CurrentRow.Index)
                                    AddHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating

                                    Exit Sub
                                End If

                                TotalProductos()
                                If Modo = 2 Then
                                    Me.Productoscol2(Productoscol2.Count - 1).Renglon = Me.Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                    Me.EmbarquesDetCol.AgregarProducto(Me.Productoscol2(Productoscol2.Count - 1))
                                End If
                            Else
                                Exit Sub
                            End If
                        Else
                            Dim Producto As New EC.MsccatProductosEntity(CInt(Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value))

                            Me.DgvProductos.CurrentRow.Cells(Me.clmProdDescripcion.Index).Value = ""

                            If Not Producto.IsNew Then
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdDescripcion.Index).Value = Producto.Descripcion
                            End If
                        End If
                    End If
                Case Me.clmProdKilos.Index
                    If IsNumeric(Me.DgvProductos.CurrentRow.Cells(Me.clmProdKilos.Index).Value) Then
                        TotalProductos()
                    Else
                        Me.DgvProductos.CurrentRow.Cells(Me.clmProdPiezas.Index).Value = 0D
                    End If
                Case Me.clmProdPiezas.Index
                    If IsNumeric(Me.DgvProductos.CurrentRow.Cells(Me.clmProdPiezas.Index).Value) Then
                        TotalProductos()
                    Else
                        Me.DgvProductos.CurrentRow.Cells(Me.clmProdPiezas.Index).Value = 0D
                    End If
                Case Me.clmProdLoteSacrificio.Index
                    If Not Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value.ToString.Trim = "" Then
                        If CInt(Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value) > 0 Then
                            Dim CodProducto As Integer = CInt(Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value)
                            DecomisosCol = New CN.DecomisosColeccionClass
                            Dim FolioSacrificio As String = Me.DgvProductos.CurrentRow.Cells(Me.clmProdLoteSacrificio.Index).Value
                            Dim IdProducto As Integer = Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value
                            DecomisosCol.Obtener(IdProducto, FolioSacrificio, CondicionEnum.ACTIVOS)

                            If DecomisosCol.Count > 0 Then
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdDescripcion.Index).Value = DecomisosCol(0).NombreProducto
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdKilos.Index).Value = DecomisosCol(0).Kilos
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdPiezas.Index).Value = DecomisosCol(0).Piezas
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdLoteSacrificio.Index).Value = DecomisosCol(0).LoteSacrificio
                                Dim DetEmbarque As EmbarqueDetalleClass = CType(DgvProductos.CurrentRow.DataBoundItem, EmbarqueDetalleClass)
                                DetEmbarque.TipoProducto = TipoProductoEnum.PRODUCTO

                                If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                    MsgBox("El producto: " & DecomisosCol(0).NombreProducto.Trim & " no tiene precio, por favor definaselo.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)

                                    RemoveHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating
                                    DgvProductos.Rows.RemoveAt(DgvProductos.CurrentRow.Index)
                                    AddHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating

                                    Exit Sub
                                End If
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdKilos.Index).ReadOnly = True
                                Me.DgvProductos.CurrentRow.Cells(Me.clmProdPiezas.Index).ReadOnly = True

                                TotalProductos()

                                If Modo = 2 Then
                                    Me.Productoscol2(Productoscol2.Count - 1).Renglon = Me.Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                    Me.Productoscol2(Productoscol2.Count - 1).TipoProducto = ClasesNegocio.TipoProductoEnum.PRODUCTO
                                    Me.EmbarquesDetCol.AgregarProducto(Me.Productoscol2(Productoscol2.Count - 1))
                                End If
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
            End Select
            TotalProductos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvProductos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvProductos.DataError

    End Sub

    Private Sub dgvRelaciondeCortes_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRelaciondeCortes.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If dgvRelaciondeCortes.CurrentCell.ColumnIndex = clmCorPrecioEspecial.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub dgvRelaciondeCortes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvRelaciondeCortes.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If dgvRelaciondeCortes.CurrentRow IsNot Nothing AndAlso Not dgvRelaciondeCortes.CurrentRow.IsNewRow Then
                    If MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        If Modo = 2 Then  ' Modo Edición
                            If Not Me.dgvRelaciondeCortes.CurrentRow.Cells(Etiqueta.Index).Value = "" Then
                                Dim Cortes As New EC.MscloteCortesDetEntity
                                Cortes.IdFolioEmbarque = ""
                                Dim CortesCol As New CC.MscloteCortesDetCollection
                                CortesCol.UpdateMulti(Cortes, HC.MscloteCortesDetFields.IdFolioEtiqueta = dgvRelaciondeCortes.CurrentRow.Cells(Etiqueta.Index).Value)
                            End If
                            Me.Embarque.Detalles.QuitarProducto(Trim(dgvRelaciondeCortes.CurrentRow.Cells(Etiqueta.Index).Value), dgvRelaciondeCortes.CurrentRow.Cells(Me.clmIdCorte.Index).Value)
                        End If
                        RemoveHandler dgvRelaciondeCortes.RowValidating, AddressOf dgvRelaciondeCortes_RowValidating
                        Me.dgvRelaciondeCortes.Rows.RemoveAt(dgvRelaciondeCortes.CurrentRow.Index)
                        AddHandler dgvRelaciondeCortes.RowValidating, AddressOf dgvRelaciondeCortes_RowValidating

                        TotalCortes()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRelaciondeCortes_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvRelaciondeCortes.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                If Not ValidarClienteyDestino() Then
                    Exit Sub
                End If

                Dim Ventana As New FrmBusquedaCortesConEtiqueta                              ' ventana de busqueda de cortes con etiqueta
                Dim FoliosSeleccionados(CType(Me.dgvRelaciondeCortes.DataSource, EmbarqueDetalleCollectionClass).Count - 1) As String

                Ventana.EstablecerEstatus(True, False, False, False, False)

                If Me.dgvRelaciondeCortes.Rows.Count > 1 Then       'Se guardan los cortes que ya estan agregados al grid
                    For Each Fila As DataGridViewRow In Me.dgvRelaciondeCortes.Rows
                        If Not Fila.IsNewRow Then
                            If Not Fila.Cells(Etiqueta.Index).Value = "" Then
                                FoliosSeleccionados(Fila.Index) = Fila.Cells(Etiqueta.Index).Value
                            End If
                        End If
                    Next
                End If

                If FoliosSeleccionados.Length > 0 Then         ' Se pasan los cortes que ya estan agregados en el grid a la ventana de busqueda
                    Ventana.EtiquetasSelecionadas = FoliosSeleccionados
                End If

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim Coleccion As New Collection

                    RemoveHandler dgvRelaciondeCortes.RowValidating, AddressOf dgvRelaciondeCortes_RowValidating

                    If dgvRelaciondeCortes.CurrentRow IsNot Nothing AndAlso Not dgvRelaciondeCortes.CurrentRow.IsNewRow _
                    AndAlso (dgvRelaciondeCortes.CurrentRow.Cells(clmDesCorte.Index).Value Is Nothing _
                    OrElse dgvRelaciondeCortes.CurrentRow.Cells(clmDesCorte.Index).Value.ToString.Trim = String.Empty) Then
                        dgvRelaciondeCortes.Rows.RemoveAt(dgvRelaciondeCortes.CurrentRow.Index)
                    End If

                    Me.dgvRelaciondeCortes.DataSource = Nothing
                    AddHandler dgvRelaciondeCortes.RowValidating, AddressOf dgvRelaciondeCortes_RowValidating

                    For i As Integer = 0 To Ventana.DgvCortes.Rows.Count - 1
                        If CBool(Ventana.DgvCortes.Rows(i).Cells(Ventana.clmSeleccion.Index).Value) AndAlso Not Ventana.DgvCortes.Rows(i).Cells(Ventana.clmSeleccion.Index).ReadOnly Then
                            ' se pasan los cortes que se seleccionaron en la ventana de busqueda al grid de cortes
                            Dim DetEmbarque As New CN.EmbarqueDetalleClass

                            DetEmbarque.IdFolioEmbarque = Embarque.FolioEmbarque
                            DetEmbarque.IdFolioEtiqueta = Ventana.DgvCortes.Rows(i).Cells(Ventana.clmFolioEtiqueta.Index).Value
                            DetEmbarque.IdProducto = Ventana.DgvCortes.Rows(i).Cells(Ventana.clmCodigoCorte.Index).Value
                            DetEmbarque.Producto = Trim(Ventana.DgvCortes.Rows(i).Cells(Ventana.clmCorte.Index).Value)
                            DetEmbarque.CantPzas = Ventana.DgvCortes.Rows(i).Cells(Ventana.clmPiezas.Index).Value
                            DetEmbarque.CantKgrs = Ventana.DgvCortes.Rows(i).Cells(Ventana.clmKilos.Index).Value
                            DetEmbarque.TipoProducto = ClasesNegocio.TipoProductoEnum.CORTE
                            DetEmbarque.LoteCorte = Ventana.DgvCortes.Rows(i).Cells(Ventana.ClmLoteCorte.Index).Value

                            If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                If Not Coleccion.Contains(DetEmbarque.IdProducto) Then
                                    Coleccion.Add(DetEmbarque.Producto, DetEmbarque.IdProducto)
                                End If
                                Continue For
                            End If

                            If Modo = 2 Then
                                If Embarque.Detalles.Count > 0 Then
                                    DetEmbarque.Renglon = Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                Else
                                    DetEmbarque.Renglon = 1
                                End If
                            End If

                            CortesCol.Add(DetEmbarque)

                            If Modo = 2 Then ' modo edicion
                                Me.Embarque.Detalles.AgregarProducto(Me.CortesCol(CortesCol.Count - 1))
                            End If
                        End If
                    Next

                    If Coleccion.Count > 0 Then
                        Dim dialog As New frmProductosSinPrecio
                        dialog.lblMensaje.Text = "Los Productos : "
                        dialog.lblMensaje2.Text = "No tienen precio en este Punto de Entrega, debera registrarlos previamente"
                        Dim Cliente As ClientesIntroductoresClass = CType(CmbCliente.SelectedItem, ClientesIntroductoresClass)
                        dialog.lblCliente.Text = IIf(Cliente.RazonSocial = "", Cliente.Nombre, Cliente.RazonSocial)
                        dialog.lblPuntoEntrega.Text = CmbPuntoEntrega.Text
                        dialog.lbxProductos.DataSource = Coleccion
                        dialog.ShowDialog()
                    End If

                    Me.dgvRelaciondeCortes.DataSource = CortesCol

                    For Each Fila As DataGridViewRow In Me.dgvRelaciondeCortes.Rows
                        Fila.Cells(clmCorPrecioEspecial.Index).ReadOnly = True

                        If Not Fila.IsNewRow Then
                            If Fila.Cells(Me.clmDesCorte.Index).Value IsNot Nothing _
                            AndAlso Fila.Cells(Me.clmDesCorte.Index).Value.ToString.Trim <> String.Empty Then
                                Fila.ReadOnly = True

                                If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                                    Fila.Cells(clmCorPrecioEspecial.Index).ReadOnly = False
                                End If
                            End If
                        End If
                    Next
                    TotalCortes()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvCanales_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvCanales.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If DgvCanales.CurrentCell.ColumnIndex = clmCanPrecioEspecial.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub DgvCanales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvCanales.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If DgvCanales.CurrentRow IsNot Nothing AndAlso Not DgvCanales.CurrentRow.IsNewRow Then
                    If MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        If Modo = 2 Then  ' Modo Edición
                            If Not Me.DgvCanales.CurrentRow.Cells(Me.ClmEtiqueta.Index).Value = "" Then

                                Dim CanalesCol As New CC.MscrecepcionCanalesDetCollection
                                Dim Etiqueta As String = Me.DgvCanales.CurrentRow.Cells(Me.Etiqueta.Index).Value
                                CanalesCol.GetMulti(HC.MscrecepcionCanalesDetFields.CodigoBarra = Etiqueta)
                                If CanalesCol.Count > 0 Then
                                    CanalesCol(0).Estatus = "V"
                                    CanalesCol(0).Save()
                                End If
                                'CanalesCol.UpdateMulti(Canales, HC.MscrecepcionCanalesDetFields.CodigoBarra = dgvRelaciondeCortes.CurrentRow.Cells(Etiqueta.Index).Value)
                            End If
                            Me.Embarque.Detalles.QuitarProducto(Trim(DgvCanales.CurrentRow.Cells(ClmEtiqueta.Index).Value), DgvCanales.CurrentRow.Cells(Me.clmCodigoCanal.Index).Value)
                        End If

                        RemoveHandler DgvCanales.RowValidating, AddressOf dgvCanales_RowValidating
                        Me.DgvCanales.Rows.RemoveAt(DgvCanales.CurrentRow.Index)
                        AddHandler DgvCanales.RowValidating, AddressOf dgvCanales_RowValidating

                        TotalCanales()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvCanales_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DgvCanales.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                If Not ValidarClienteyDestino() Then
                    Exit Sub
                End If

                Dim Ventana As New FrmBusqCanalEmbarque
                Dim Etiquetas(CType(Me.DgvCanales.DataSource, EmbarqueDetalleCollectionClass).Count - 1) As String

                If Me.DgvCanales.Rows.Count > 1 Then    ' se guardan los canales que ya estan agregados al grid
                    For Each Fila As DataGridViewRow In Me.DgvCanales.Rows
                        If Not Fila.IsNewRow Then
                            If Not CInt(Fila.Cells(clmCodigoCanal.Index).Value) = 0 Then
                                Etiquetas(Fila.Index) = Fila.Cells(Me.ClmEtiqueta.Index).Value
                            End If
                        End If
                    Next
                End If

                If Etiquetas.Length > 0 Then    ' se pasan los canales que ya estan agregados en el grid para que la busqueda los excluya
                    Ventana.Codigos = Etiquetas
                End If

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim ProdCol As New CC.MsccatProductosCollection
                    Dim Coleccion As New Collection()

                    ProdCol.GetMulti(HC.MsccatProductosFields.Canal = True)

                    RemoveHandler DgvCanales.RowValidating, AddressOf dgvCanales_RowValidating

                    If DgvCanales.CurrentRow IsNot Nothing AndAlso Not DgvCanales.CurrentRow.IsNewRow _
                    AndAlso (DgvCanales.CurrentRow.Cells(clmDesCanal.Index).Value Is Nothing _
                    OrElse DgvCanales.CurrentRow.Cells(clmDesCanal.Index).Value.ToString.Trim = String.Empty) Then
                        DgvCanales.Rows.RemoveAt(DgvCanales.CurrentRow.Index)
                    End If

                    Me.DgvCanales.DataSource = Nothing
                    AddHandler DgvCanales.RowValidating, AddressOf dgvCanales_RowValidating

                    For i As Integer = 0 To Ventana.DgvCanales.Rows.Count - 1
                        If CBool(Ventana.DgvCanales.Rows(i).Cells(Ventana.clmSeleccion.Index).Value) And Ventana.DgvCanales.Rows(i).Cells(Ventana.clmSeleccion.Index).ReadOnly = False Then
                            ' If Modo = 2 Then 'modo edicion
                            Dim DetEmbarque As New CN.EmbarqueDetalleClass
                            DetEmbarque.IdFolioEmbarque = Embarque.FolioEmbarque
                            DetEmbarque.IdFolioEtiqueta = Ventana.DgvCanales.Rows(i).Cells(Ventana.clmFolioCanal.Index).Value
                            DetEmbarque.IdProducto = ProdCol(0).IdProducto
                            DetEmbarque.Producto = ProdCol(0).Descripcion
                            DetEmbarque.CantPzas = 1
                            DetEmbarque.CantKgrs = Ventana.DgvCanales.Rows(i).Cells(Ventana.clmKgrs.Index).Value
                            DetEmbarque.TipoProducto = ClasesNegocio.TipoProductoEnum.CANAL
                            DetEmbarque.Estatus = ClasesNegocio.EstatusCharX.VIGENTE

                            If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                If Not Coleccion.Contains(DetEmbarque.IdProducto) Then
                                    Coleccion.Add(DetEmbarque.Producto.Trim, DetEmbarque.IdProducto)
                                End If
                                Continue For
                            End If

                            If Modo = 2 Then
                                If Embarque.Detalles.Count > 0 Then
                                    DetEmbarque.Renglon = Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                Else
                                    DetEmbarque.Renglon = 1
                                End If
                            End If

                            Me.CanalesCol.Add(DetEmbarque)

                            If Modo = 2 Then
                                Me.Embarque.Detalles.AgregarProducto(Me.CanalesCol(CanalesCol.Count - 1))
                            End If
                        End If
                    Next

                    If Coleccion.Count > 0 Then
                        Dim dialog As New frmProductosSinPrecio
                        dialog.lblMensaje.Text = "Los Productos : "
                        dialog.lblMensaje2.Text = "No tienen precio en este Punto de Entrega, debera registrarlos previamente"
                        Dim Cliente As ClientesIntroductoresClass = CType(CmbCliente.SelectedItem, ClientesIntroductoresClass)
                        dialog.lblCliente.Text = IIf(Cliente.RazonSocial = "", Cliente.Nombre, Cliente.RazonSocial)
                        dialog.lblPuntoEntrega.Text = CmbPuntoEntrega.Text
                        dialog.lbxProductos.DataSource = Coleccion
                        dialog.ShowDialog()
                    End If

                    Me.DgvCanales.DataSource = CanalesCol

                    For Each Fila As DataGridViewRow In DgvCanales.Rows
                        Fila.Cells(clmCanPrecioEspecial.Index).ReadOnly = True

                        If Not Fila.IsNewRow Then
                            If Fila.Cells(Me.clmDesCanal.Index).Value IsNot Nothing _
                            AndAlso Fila.Cells(Me.clmDesCanal.Index).Value.ToString.Trim <> String.Empty Then
                                Fila.ReadOnly = True

                                If Controlador.Configuracion.Produccion.PrecioEmbarque Then
                                    Fila.Cells(clmCanPrecioEspecial.Index).ReadOnly = False
                                End If
                            End If
                        End If
                    Next
                End If
            End If
            TotalCanales()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvProductos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvProductos.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales

        If DgvProductos.CurrentCell.ColumnIndex = clmProdPiezas.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
        ElseIf DgvProductos.CurrentCell.ColumnIndex = clmProdKilos.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        ElseIf DgvProductos.CurrentCell.ColumnIndex = clmProPrecioEspecial.Index Then
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub DgvProductos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvProductos.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If DgvProductos.CurrentRow IsNot Nothing AndAlso Not DgvProductos.CurrentRow.IsNewRow Then
                    If MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    Else
                        Me.Embarque.Detalles.QuitarProducto("", Me.DgvProductos.CurrentRow.Cells(Me.clmProdCodigo.Index).Value)

                        RemoveHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating
                        Me.DgvProductos.Rows.RemoveAt(DgvProductos.CurrentRow.Index)
                        AddHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating

                        TotalProductos()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvProductos_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DgvProductos.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                If Not ValidarClienteyDestino() Then
                    Exit Sub
                End If

                Dim Ventana As New FrmBusqProductos 'FrmBusquedaCortesEmbarque                                    ' se abre la ventana de busqueda de productos 
                Dim Lista As New List(Of ProductosSeleccionados)

                For Each Fila As DataGridViewRow In Me.DgvProductos.Rows
                    If Not Fila.IsNewRow Then
                        Dim Productos As ProductosSeleccionados
                        Productos.FolioSacrificio = Fila.Cells(Me.clmProdLoteSacrificio.Index).Value
                        Productos.IdProducto = Fila.Cells(Me.clmProdCodigo.Index).Value
                        Lista.Add(Productos)
                    End If
                Next

                Ventana.ListaProd = Lista ' Se pasan los productos Seleccionados

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim Coleccion As New Collection
                    For i As Integer = 0 To Ventana.DgvDecomisos.Rows.Count - 1
                        If CBool(Ventana.DgvDecomisos.Rows(i).Cells(Ventana.ClmSelccion.Index).Value) = True And Ventana.DgvDecomisos.Rows(i).Cells(Ventana.ClmSelccion.Index).ReadOnly = False Then
                            Dim DetEmbarque As New CN.EmbarqueDetalleClass

                            RemoveHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating

                            If DgvProductos.CurrentRow IsNot Nothing AndAlso Not DgvProductos.CurrentRow.IsNewRow _
                            AndAlso (DgvProductos.CurrentRow.Cells(clmProdDescripcion.Index).Value Is Nothing _
                            OrElse DgvProductos.CurrentRow.Cells(clmProdDescripcion.Index).Value.ToString.Trim = String.Empty) Then
                                DgvProductos.Rows.RemoveAt(DgvProductos.CurrentRow.Index)
                            End If

                            Me.DgvProductos.DataSource = Nothing
                            AddHandler DgvProductos.RowValidating, AddressOf DgvProductos_RowValidating

                            DetEmbarque.kilosMaximos = Ventana.DgvDecomisos.Rows(i).Cells(Ventana.clmKilosRestantes.Index).Value
                            DetEmbarque.PiezasMaximas = Ventana.DgvDecomisos.Rows(i).Cells(Ventana.clmPiezasrestantes.Index).Value
                            DetEmbarque.IdFolioEmbarque = Embarque.FolioEmbarque
                            DetEmbarque.IdFolioEtiqueta = ""
                            DetEmbarque.IdProducto = Ventana.DgvDecomisos.Rows(i).Cells(Ventana.ClmIdProducto.Index).Value
                            DetEmbarque.Producto = Trim(Ventana.DgvDecomisos.Rows(i).Cells(Ventana.ClmProducto.Index).Value)
                            DetEmbarque.CantPzas = Ventana.DgvDecomisos.Rows(i).Cells(Ventana.clmPiezasrestantes.Index).Value
                            DetEmbarque.CantKgrs = Ventana.DgvDecomisos.Rows(i).Cells(Ventana.clmKilosRestantes.Index).Value
                            DetEmbarque.TipoProducto = ClasesNegocio.TipoProductoEnum.PRODUCTO
                            DetEmbarque.Estatus = ClasesNegocio.EstatusCharX.VIGENTE
                            DetEmbarque.FolioSacrificio = Ventana.DgvDecomisos.Rows(i).Cells(Ventana.ClmLoteSacrificio.Index).Value
                            DetEmbarque.kilosMaximos = DetEmbarque.CantKgrs
                            DetEmbarque.PiezasMaximas = DetEmbarque.CantPzas
                            DetEmbarque.ValidarLimites = True

                            If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                If Not Coleccion.Contains(DetEmbarque.IdProducto) Then
                                    Coleccion.Add(DetEmbarque.Producto, DetEmbarque.IdProducto)
                                End If
                                Continue For
                            End If

                            If Modo = 2 Then 'modo edicion
                                If Embarque.Detalles.Count > 1 Then
                                    DetEmbarque.Renglon = Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                Else
                                    DetEmbarque.Renglon = 1
                                End If
                            End If

                            Me.Productoscol2.Add(DetEmbarque)

                            If Modo = 2 Then 'modo edicion
                                Me.Embarque.Detalles.AgregarProducto(Me.Productoscol2(Productoscol2.Count - 1))
                            End If
                        End If
                    Next

                    If Coleccion.Count > 0 Then
                        Dim dialog As New frmProductosSinPrecio
                        dialog.lblMensaje.Text = "Los Productos : "
                        dialog.lblMensaje2.Text = "No tienen precio en este Punto de Entrega, debera registrarlos previamente"
                        Dim Cliente As ClientesIntroductoresClass = CType(CmbCliente.SelectedItem, ClientesIntroductoresClass)
                        dialog.lblCliente.Text = IIf(Cliente.RazonSocial = "", Cliente.Nombre, Cliente.RazonSocial)
                        dialog.lblPuntoEntrega.Text = CmbPuntoEntrega.Text
                        dialog.lbxProductos.DataSource = Coleccion
                        dialog.ShowDialog()
                    End If
                    Me.DgvProductos.DataSource = Productoscol2
                End If
                TotalProductos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Close()
    End Sub

#End Region

#Region "Key Press"

    Private Sub txtReferencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReferencia.KeyPress, chkParaExportacion.KeyPress, CmbCliente.KeyPress, CmbTransporte.KeyPress, CmbConductor.KeyPress, CmbPuntoEntrega.KeyPress, dtFechaEmbarque.KeyPress, chkAsignarCliente.KeyPress, cmbClienteAsignado.KeyPress, TabControl1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub
#End Region

    Private Sub cmdLeerArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeerArchivo.Click
        If Not ValidarClienteyDestino() Then
            Exit Sub
        End If

        Try
            Dim strRuta As String
            Dim archivo As New OpenFileDialog
            Dim ListadeCajas As List(Of String) 'lista para guardar los codigos de barra a guardar en la tabla de cortes
            Dim Etiqueta As String
            Dim Cont As Integer
            Dim etiquetasSinAgregar As String = ""

            Cont = 0
            'lectura de archivo
            archivo.Filter = "*.txt |*.txt"

            If archivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                strRuta = archivo.FileName

                ListadeCajas = Utilerias.LeerArchivodeTexto(strRuta)

                'verifica si las cajas ya estan en el embarque
                For Each Fila As DataGridViewRow In Me.dgvRelaciondeCortes.Rows
                    If Not Fila.IsNewRow Then
                        Dim caja As String = Fila.Cells(Me.ClmEtiqueta.Index).Value

                        If caja.Trim.Length = 0 Then
                            Continue For
                        End If

                        For Each folioEtiqueta As String In ListadeCajas
                            If caja.Trim = folioEtiqueta.Trim Then
                                ListadeCajas.Remove(folioEtiqueta)
                                etiquetasSinAgregar &= folioEtiqueta & ","
                                Exit For
                            End If
                        Next
                    End If
                Next

                'muestra las cajas que ya estan en el embarque actual
                If Not etiquetasSinAgregar.Trim.Length = 0 Then
                    etiquetasSinAgregar = etiquetasSinAgregar.Substring(0, etiquetasSinAgregar.Length - 1)
                    etiquetasSinAgregar = "Estas cajas ya estan en el embarque" & vbNewLine & etiquetasSinAgregar

                    MsgBox(etiquetasSinAgregar, MsgBoxStyle.Exclamation, "Cajas Repetidas")
                End If

                'agrega las cajas al embarque
                'Me.txtFolioReferencia.Text = Utilerias.LeerArchivodeTexto(strRuta)
                Dim ListaCajas As New Collection
                Dim ListaRepetidos As New Collection
                Dim ListaProductosSinPrecio As New Collection
                For i As Integer = 0 To ListadeCajas.Count - 1
                    Etiqueta = ListadeCajas.Item(i).ToString.Trim

                    If ListaCajas.Contains(Etiqueta) Then
                        If Not ListaRepetidos.Contains(Etiqueta) Then
                            ListaRepetidos.Add(Etiqueta, Etiqueta)
                        End If
                        Continue For
                    End If
                    ListaCajas.Add(Etiqueta, Etiqueta)

                    'Me.dgvRelaciondeCortes.Rows(Cont).Cells(Me.Etiqueta.Index).Value = ListadeCajas.Item(i).ToString
                    'If Not CStr(Me.dgvRelaciondeCortes.Rows(Cont).Cells(Etiqueta.Index).Value) = "" Then
                    If Not Etiqueta.Trim = "" Then
                        Me.EmbarquesDet = New CN.EmbarqueDetalleClass
                        Dim DatosCorte As New DataSet

                        DatosCorte = EmbarquesDet.ObtenerEtiqueta(Etiqueta)
                        'busca por folio de etiqueta

                        If DatosCorte.Tables(0).Rows.Count > 0 Then
                            Dim DetEmbarque As New CN.EmbarqueDetalleClass

                            'deja informaciío en pantalla para embarque
                            DetEmbarque.IdFolioEmbarque = Embarque.FolioEmbarque
                            DetEmbarque.IdFolioEtiqueta = DatosCorte.Tables(0).Rows(0)("IdFolioEtiqueta")

                            'Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.Etiqueta.Index).Value = DatosCorte.Tables(0).Rows(0)("IdFolioEtiqueta")
                            DetEmbarque.IdProducto = DatosCorte.Tables(0).Rows(0)("IdProducto")
                            DetEmbarque.Producto = DatosCorte.Tables(0).Rows(0)("Nom_SubCorte")
                            DetEmbarque.CantPzas = DatosCorte.Tables(0).Rows(0)("CantPzas")
                            DetEmbarque.CantKgrs = DatosCorte.Tables(0).Rows(0)("CantKgrs")
                            DetEmbarque.TipoProducto = ClasesNegocio.TipoProductoEnum.CORTE
                            DetEmbarque.LoteCorte = DatosCorte.Tables(0).Rows(0)("LoteCorte")

                            If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                If Not ListaProductosSinPrecio.Contains(DetEmbarque.IdProducto) Then
                                    ListaProductosSinPrecio.Add(DetEmbarque.Producto, DetEmbarque.IdProducto)
                                End If
                                Continue For
                            End If

                            If Modo = 2 Then
                                DetEmbarque.Renglon = Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                            End If

                            CortesCol.Add(DetEmbarque)

                            If Modo = 2 Then
                                Me.Embarque.Detalles.AgregarProducto(Me.CortesCol(CortesCol.Count - 1))
                            End If

                            'Me.dgvRelaciondeCortes.DataSource = Nothing


                            'Cont += 1
                            'TotalCortes()

                        Else 'busca por codigo de barra
                            Dim loteCorteDetC As New CC.MscloteCortesDetCollection
                            Dim LoteCorteCabC As New CC.MscloteCortesCabCollection

                            loteCorteDetC.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = Etiqueta.Trim Or HC.MscloteCortesDetFields.CodigoBarra = Etiqueta.Trim)

                            If loteCorteDetC.Count > 0 Then
                                Dim EmbarqueC As New CN.EmbarquesClass
                                Dim DetEmbarque As New CN.EmbarqueDetalleClass

                                With loteCorteDetC(0)
                                    If .Estatus = 0 Then
                                        MsgBox("El Corte con la etiqueta " & Etiqueta.Trim & " fue cancelado")
                                        Continue For
                                    End If
                                    If .Estatus = 1 AndAlso Not .IdFolioEmbarque.Trim = "" Then
                                        EmbarqueC.Obtener(.IdFolioEmbarque)
                                        MsgBox("El Corte con la etiqueta " & Etiqueta.Trim & " ya fue embarcado " & Chr(13) & _
                                               "En el embarque " & .IdFolioEmbarque & " con fecha " & EmbarqueC.FechaEmbarque)
                                        Continue For
                                    End If
                                    If .Estatus = 2 Then
                                        MsgBox("El Corte con la etiqueta " & Etiqueta.Trim & " esta en reproceso")
                                        Continue For
                                    End If
                                    If .Estatus = 3 Then
                                        MsgBox("El Corte con la etiqueta " & Etiqueta.Trim & " esta en ajuste de inventario")
                                        Continue For
                                    End If

                                    'busca fecha de corte del producto 
                                    LoteCorteCabC.GetMulti(HC.MscloteCortesCabFields.LoteCorte = .LoteCorte)

                                    'deja información en pantalla para generar archivo
                                    DetEmbarque.IdFolioEmbarque = Embarque.FolioEmbarque
                                    DetEmbarque.IdFolioEtiqueta = .IdFolioEtiqueta

                                    'Me.dgvRelaciondeCortes.CurrentRow.Cells(Me.Etiqueta.Index).Value = DatosCorte.Tables(0).Rows(0)("IdFolioEtiqueta")
                                    DetEmbarque.IdProducto = .IdProducto
                                    DetEmbarque.CantPzas = .CantPzas
                                    DetEmbarque.CantKgrs = .CantKgrs
                                    DetEmbarque.TipoProducto = ClasesNegocio.TipoProductoEnum.CORTE
                                    DetEmbarque.LoteCorte = .LoteCorte

                                    If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, CmbPuntoEntrega.SelectedValue) = 0 Then
                                        If Not ListaProductosSinPrecio.Contains(DetEmbarque.IdProducto) Then
                                            ListaProductosSinPrecio.Add(DetEmbarque.Producto, DetEmbarque.IdProducto)
                                        End If
                                        Continue For
                                    End If

                                    If Modo = 2 Then
                                        DetEmbarque.Renglon = Embarque.Detalles(Embarque.Detalles.Count - 1).Renglon + 1
                                    End If

                                    CortesCol.Add(DetEmbarque)

                                    If Modo = 2 Then
                                        Me.Embarque.Detalles.AgregarProducto(Me.CortesCol(CortesCol.Count - 1))
                                    End If
                                End With
                            End If
                        End If
                    End If
                Next

                If ListaProductosSinPrecio.Count > 0 Then
                    Dim dialog As New frmProductosSinPrecio
                    dialog.lblMensaje.Text = "Los Productos : "
                    dialog.lblMensaje2.Text = "No tienen precio en este Punto de Entrega, debera registrarlos previamente"
                    Dim Cliente As ClientesIntroductoresClass = CType(CmbCliente.SelectedItem, ClientesIntroductoresClass)
                    dialog.lblCliente.Text = IIf(Cliente.RazonSocial = "", Cliente.Nombre, Cliente.RazonSocial)
                    dialog.lblPuntoEntrega.Text = CmbPuntoEntrega.Text
                    dialog.lbxProductos.DataSource = ListaProductosSinPrecio
                    dialog.ShowDialog()
                End If

                If ListaRepetidos.Count > 0 Then
                    Dim Cajas() As String = Nothing

                    For i As Integer = 0 To ListaRepetidos.Count - 1
                        ReDim Preserve Cajas(i)
                        Cajas(i) = ListaRepetidos.Item(i + 1)
                    Next

                    MsgBox("Las siguientes cajas estan repetidas :" & Chr(Keys.Enter) & Chr(Keys.Enter) & _
                    String.Join(Chr(Keys.Enter), Cajas), MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                End If

                TotalCortes()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
    End Sub

    Private Structure CorteMenor
        Public Codigo As Integer
        Public Corte As String
        Public Fecha As DateTime
        Sub New(ByVal cod As Integer, ByVal descripcion As String, ByVal fechacorte As DateTime)
            Codigo = cod
            Corte = descripcion
            Fecha = fechacorte
        End Sub

    End Structure

    Private Sub chkAsignarCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAsignarCliente.CheckedChanged
        If Me.chkAsignarCliente.Checked Then
            Me.cmbClienteAsignado.Enabled = True
        Else
            Me.cmbClienteAsignado.Enabled = False
        End If
    End Sub

    Private Function ValidarClienteyDestino() As Boolean
        If CmbCliente.SelectedValue Is Nothing Then
            MsgBox("Por favor seleccione el cliente", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Return False
        End If

        If CmbPuntoEntrega.SelectedValue Is Nothing Then
            MsgBox("Por favor seleccione el punto de entrega", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' No permite cambiar el cliente o el punto de entrega en el modo de edicion,
    ''' si el cliente no tiene puntos de entrega registrados y si algun corte, canal o producto
    ''' no tienen el precio registrado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidarClienteyPuntoEntrega(ByVal PuntodeEntrega As EC.MgralcatPuntosEntregaEntity) As Boolean
        Dim Productos As New Collection()
        For Each DetEmbarque As EmbarqueDetalleClass In Embarque.Detalles
            If DetEmbarque.ActualizarPrecio(CmbCliente.SelectedValue, PuntodeEntrega.IdPuntoEntrega) = 0 _
            And Not Productos.Contains(DetEmbarque.Producto.Trim) Then
                Productos.Add(DetEmbarque.Producto.Trim, DetEmbarque.Producto.Trim)
            End If
        Next
        If Productos.Count > 0 Then
            Dim ventana As New frmProductosSinPrecio
            ventana.lblMensaje.Text = "Los Productos : "
            ventana.lblMensaje2.Text = "No tienen precio en este Punto de Entrega, debera registrarlos previamente"
            Dim Cliente As ClientesIntroductoresClass = CType(CmbCliente.SelectedItem, ClientesIntroductoresClass)
            ventana.lblCliente.Text = IIf(Cliente.RazonSocial.Trim = "", Cliente.Nombre.Trim, Cliente.RazonSocial.Trim)
            ventana.lblPuntoEntrega.Text = PuntodeEntrega.Descripcion
            ventana.lbxProductos.DataSource = Productos
            ventana.ShowDialog()
            Return False
        End If
        Return True
    End Function

    Private Sub dgvRelaciondeCortes_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvRelaciondeCortes.RowValidating
        If Not dgvRelaciondeCortes.Rows(e.RowIndex).IsNewRow Then
            If dgvRelaciondeCortes.Rows(e.RowIndex).Cells(clmDesCorte.Index).Value Is Nothing OrElse dgvRelaciondeCortes.Rows(e.RowIndex).Cells(clmDesCorte.Index).Value.ToString.Trim = String.Empty Then
                e.Cancel = True
                dgvRelaciondeCortes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                MsgBox("Debe seleccionar el corte", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Else
                For Each Fila As DataGridViewRow In dgvRelaciondeCortes.Rows
                    If Not Fila.IsNewRow AndAlso Fila.Index <> e.RowIndex Then
                        If Fila.Cells(Etiqueta.Index).Value.ToString.Trim = dgvRelaciondeCortes.Rows(e.RowIndex).Cells(Etiqueta.Index).Value.ToString.Trim Then
                            e.Cancel = True
                            dgvRelaciondeCortes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                            MessageBox.Show(String.Format("La caja con folio ({0}) ya ha sido agregado, por favor especifique otra", dgvRelaciondeCortes.Rows(e.RowIndex).Cells(Etiqueta.Index).Value.ToString.Trim), Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                Next
                dgvRelaciondeCortes.Rows(e.RowIndex).DefaultCellStyle.BackColor = dgvRelaciondeCortes.Rows(dgvRelaciondeCortes.NewRowIndex).DefaultCellStyle.BackColor
            End If
        End If
    End Sub

    Private Sub dgvCanales_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvCanales.RowValidating
        If Not DgvCanales.Rows(e.RowIndex).IsNewRow Then
            If DgvCanales.Rows(e.RowIndex).Cells(clmDesCanal.Index).Value Is Nothing OrElse DgvCanales.Rows(e.RowIndex).Cells(clmDesCanal.Index).Value.ToString.Trim = String.Empty Then
                e.Cancel = True
                DgvCanales.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                MsgBox("Debe seleccionar el canal", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Else
                For Each Fila As DataGridViewRow In DgvCanales.Rows
                    If Not Fila.IsNewRow AndAlso Fila.Index <> e.RowIndex Then
                        If Fila.Cells(ClmEtiqueta.Index).Value.ToString.Trim = DgvCanales.Rows(e.RowIndex).Cells(ClmEtiqueta.Index).Value.ToString.Trim Then
                            e.Cancel = True
                            DgvCanales.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                            MessageBox.Show(String.Format("El canal con folio ({0}) ya ha sido agregado, por favor especifique otra", DgvCanales.Rows(e.RowIndex).Cells(ClmEtiqueta.Index).Value.ToString.Trim), Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                Next
                DgvCanales.Rows(e.RowIndex).DefaultCellStyle.BackColor = DgvCanales.Rows(DgvCanales.NewRowIndex).DefaultCellStyle.BackColor
            End If
        End If
    End Sub

    Private Sub DgvProductos_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvProductos.RowValidating
        If Not DgvProductos.Rows(e.RowIndex).IsNewRow Then
            If DgvProductos.Rows(e.RowIndex).Cells(clmProdDescripcion.Index).Value Is Nothing OrElse DgvProductos.Rows(e.RowIndex).Cells(clmProdDescripcion.Index).Value.ToString.Trim = String.Empty Then
                e.Cancel = True
                DgvProductos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                MsgBox("Debe seleccionar el producto", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Else
                For Each Fila As DataGridViewRow In DgvProductos.Rows
                    If Not Fila.IsNewRow AndAlso Fila.Index <> e.RowIndex Then
                        If Fila.Cells(clmProdLoteSacrificio.Index).Value.ToString.Trim = DgvProductos.Rows(e.RowIndex).Cells(clmProdLoteSacrificio.Index).Value.ToString.Trim _
                        AndAlso Fila.Cells(clmProdCodigo.Index).Value = DgvProductos.Rows(e.RowIndex).Cells(clmProdCodigo.Index).Value.ToString.Trim Then
                            e.Cancel = True
                            DgvProductos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                            MessageBox.Show(String.Format("El producto ({0}) con lote sacrificio ({1}) ya ha sido agregado, por favor especifique otra", DgvProductos.Rows(e.RowIndex).Cells(clmProdDescripcion.Index).Value.ToString.Trim, DgvProductos.Rows(e.RowIndex).Cells(clmProdLoteSacrificio.Index).Value.ToString.Trim), Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                Next

                If Not IsNumeric(DgvProductos.Rows(e.RowIndex).Cells(clmProdPiezas.Index).Value) OrElse CType(DgvProductos.Rows(e.RowIndex).Cells(clmProdPiezas.Index).Value, Integer) = 0I Then
                    e.Cancel = True
                    DgvProductos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                    MsgBox("Debe establecer las piezas", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                ElseIf Not IsNumeric(DgvProductos.Rows(e.RowIndex).Cells(clmProdKilos.Index).Value) OrElse CType(DgvProductos.Rows(e.RowIndex).Cells(clmProdKilos.Index).Value, Decimal) = 0D Then
                    e.Cancel = True
                    DgvProductos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                    MsgBox("Debe establecer los kilos", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Else
                    DgvProductos.Rows(e.RowIndex).DefaultCellStyle.BackColor = DgvProductos.Rows(DgvProductos.NewRowIndex).DefaultCellStyle.BackColor
                End If
            End If
        End If
    End Sub

End Class

Public Structure ProductosSeleccionados
    Public FolioSacrificio As String
    Public IdProducto As String
End Structure