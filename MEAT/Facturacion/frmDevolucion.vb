Imports CN = ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmDevolucion
#Region "Miembros"
    Dim motivoDecomiso As Integer
    Dim agregarPiezas As Boolean
    Dim validandoEtiqueta As Boolean
    Dim validandoEmbarque As Boolean
#End Region

#Region "Metodos"
    Private Function CancelarDevolucion(ByVal folio As String) As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelar Devolucion")

        Try
            Dim devolucion As New EC.DevolucionProductosEntity
            Dim movimientoAlm As New ClasesNegocio.MovimientoAlmacenClass
            Dim caja As New EC.MscloteCortesDetEntity

            trans.Add(devolucion)

            devolucion.FetchUsingPK(folio)

            If devolucion.EnCaja Then
                Dim cajas As New CC.MscloteCortesDetCollection

                trans.Add(cajas)

                cajas.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = devolucion.IdFolioEtiqueta)

                If cajas.Count > 0 Then
                    caja = cajas(0)
                Else
                    trans.Rollback()
                    MsgBox("No se encontro una caja con el folio de etiqueta " & devolucion.IdFolioEtiqueta, MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                caja.IdFolioEmbarque = devolucion.Embarque
                trans.Add(caja)

                caja.Save()
            End If

            With movimientoAlm
                .EstablecerTipoMovimiento(ClasesNegocio.InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Cancelacion_Devolucion_Venta)
                .EstablecerAlmacen(ClasesNegocio.MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                .Estatus = ClasesNegocio.EstatusChar.VIGENTE
                .FechaMovimiento = Now
                .FolioMovmientoReferencia = devolucion.FolioMovimientoAlmacen
                .IdPoliza = ""
                .Kilos = devolucion.Kilos
                .Piezas = devolucion.Piezas
                .QuienCancelo = Controlador.Sesion.MiUsuario.Usrnomcom
                .AgregarDetalle(devolucion.IdProducto, devolucion.Kilos, devolucion.Piezas, 0D, 0D)

                If Not .Guardar(trans) Then
                    trans.Rollback()
                    MsgBox("Ocurrio un error al afectar el inventario", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                devolucion.FolioMovimeintoAlmacenCancelacion = .FolioMovimiento
            End With

            devolucion.Estatus = ClasesNegocio.EstatusEnum.INACTIVO
            devolucion.Save()

            trans.Commit()
            Return True
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Buscar(ByVal etiquetas As List(Of String))
        Try
            Dim vista As New TC.VwConsultaCortesParaReimprecionTypedView
            'Dim vista1 As New TC.VwConsultaCortesParaReimprecionTypedView
            Dim filtro As New OC.PredicateExpression
            'Dim filtro1 As New OC.PredicateExpression
            Dim ultimaFila As Integer = 0

            filtro.Add((New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.IdFolioEtiqueta, etiquetas.ToArray) Or _
                        New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.CodigoBarra, etiquetas.ToArray)))
            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1 And HC.VwConsultaCortesParaReimprecionFields.IdFolioEmbarque <> "")

            vista.Fill(0, Nothing, True, filtro)

            'If vista.Rows.Count = 0 Then
            '    filtro1.Add(New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.CodigoBarra, etiquetas.ToArray))
            '    filtro1.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1 And HC.VwConsultaCortesParaReimprecionFields.IdFolioEmbarque <> "")
            '    vista1.Fill(0, Nothing, True, filtro1)
            'End If

            'If vista.Rows.Count = 0 Then
            '    Me.Devolver(vista1)
            'Else
            If vista.Count > 0 Then
                If MessageBox.Show("Se devolveran " & vista.Count & " caja. ¿Quiere continuar?", "Devolver Cajas", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = _
                    Windows.Forms.DialogResult.Yes Then
                    Me.Devolver(vista)

                    Me.Buscar()
                    Me.Deshabilitar()
                    Limpiar()
                    MsgBox("Se devolvieron " & vista.Count & " cajas")
                    mtb.sbCambiarEstadoBotones("Guardar")
                End If
            Else
                MsgBox("No hay cajas a devolver", MsgBoxStyle.Exclamation, "Aviso")
            End If

            'End If

            'Me.Buscar()
            'Me.Deshabilitar()
            'Limpiar()
            'If vista.Rows.Count = 0 Then
            '    MsgBox("Se devolvieron " & vista1.Count & " cajas")
            'Else
            'MsgBox("Se devolvieron " & vista.Count & " cajas")
            'End If

            'mtb.sbCambiarEstadoBotones("Guardar")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Buscar(ByVal folioEmbarque As String)
        Try
            Dim vista As New TC.VwConsultaCortesParaReimprecionTypedView
            Dim filtro As New OC.PredicateExpression
            Dim ultimaFila As Integer = 0

            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.IdFolioEmbarque = folioEmbarque)
            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1)

            vista.Fill(0, Nothing, True, filtro)

            If vista.Count > 0 Then
                If MessageBox.Show("Se devolveran " & vista.Count & " caja. ¿Quiere continuar?", "Devolver Cajas", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = _
                    Windows.Forms.DialogResult.Yes Then

                    Me.Devolver(vista)

                    Me.Buscar()
                    Me.Deshabilitar()
                    Limpiar()
                    'If vista.Rows.Count = 0 Then
                    '    MsgBox("Se devolvieron " & vista1.Count & " cajas")
                    'Else
                    MsgBox("Se devolvieron " & vista.Count & " cajas")
                    'End If

                    mtb.sbCambiarEstadoBotones("Guardar")
                End If
            Else
                MsgBox("No hay cajas a devolver", MsgBoxStyle.Exclamation, "Aviso")
            End If

            'MsgBox("Se devolvieron " & vista.Count & " cajas")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Devolver(ByVal vista As TC.VwConsultaCortesParaReimprecionTypedView)
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Devolucion")

        Try
            Dim devolucion As New EC.DevolucionProductosEntity
            Dim movAlm As CN.MovimientoAlmacenClass
            Dim caja As EC.MscloteCortesDetEntity
            Dim folio As New CN.FoliosClass
            Dim EmbarqueDetalle As New CC.MfacEmbarquesDetCollection

            For Each row As TC.VwConsultaCortesParaReimprecionRow In vista
                caja = New EC.MscloteCortesDetEntity
                trans.Add(caja)
                caja.FetchUsingPK(row.LoteCorte.Trim, row.IdFolioEtiqueta.Trim)
                caja.IdFolioEmbarque = ""

                caja.Save()

                movAlm = New CN.MovimientoAlmacenClass
                movAlm.EstablecerAlmacen(ClasesNegocio.MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                movAlm.EstablecerTipoMovimiento(ClasesNegocio.InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Devolucion_Venta)
                movAlm.Estatus = ClasesNegocio.EstatusChar.VIGENTE
                movAlm.FechaMovimiento = Now
                movAlm.FolioMovmientoReferencia = ""
                movAlm.IdPoliza = ""
                movAlm.Kilos = row.CantKgrs
                movAlm.Piezas = row.CantPzas
                movAlm.AgregarDetalle(row.IdCorte, movAlm.Kilos, movAlm.Piezas, 0D, 0D)

                If Not movAlm.Guardar(trans) Then
                    Throw New Exception("No se realizo la devolución, ocurrio un problema al afectar el inventario de cajas")
                End If

                folio.Año = Now.Year
                folio.Mes = Now.Month
                folio.Codigo = ClasesNegocio.CodigodeFolios.Devoluciones

                If Not folio.Guardar(trans) Then
                    Throw New Exception("No se realizo la devolución, ocurrio un problema al generar el folio de la devolución")
                End If

                devolucion = New EC.DevolucionProductosEntity
                trans.Add(devolucion)
                devolucion.Folio = String.Format("{0}{1}{2}", Now.Year, Now.Month.ToString("00"), _
                                    folio.Consecutivo.ToString("0000"))
                devolucion.FolioMovimientoAlmacen = movAlm.FolioMovimiento
                devolucion.Embarque = row.IdFolioEmbarque
                devolucion.EnCaja = True
                devolucion.Estatus = CN.EstatusDevolucion.ACTIVA
                devolucion.IdCliente = row.IdCliente
                devolucion.IdFolioEtiqueta = row.IdFolioEtiqueta
                devolucion.IdMotivoDevolucion = Me.motivoDecomiso
                devolucion.IdProducto = row.IdCorte
                devolucion.IdUsuarioAlta = Controlador.Sesion.Usrndx
                devolucion.Kilos = row.CantKgrs
                devolucion.Piezas = row.CantPzas
                devolucion.UtilparaVenta = True
                devolucion.Save()

                trans.Add(EmbarqueDetalle)

                If EmbarqueDetalle.GetMulti(HC.MfacEmbarquesDetFields.IdFolioEmbarque = row.IdFolioEmbarque And HC.MfacEmbarquesDetFields.IdFolioEtiqueta = row.IdFolioEtiqueta) Then
                    EmbarqueDetalle(0).Estatus = "D"
                    trans.Add(EmbarqueDetalle(0))
                    EmbarqueDetalle(0).Save()
                End If
            Next

            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            Throw ex
        End Try
    End Sub

    Private Sub Devolver(ByVal folioEmbarque As String, ByVal folioEtiqueta As String, ByVal loteCorte As String, _
                        ByVal idProducto As Integer, ByVal idCliente As Integer, ByVal piezas As Integer, _
                        ByVal kilos As Decimal, ByVal esCaja As Boolean)
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Devolucion")

        Try
            Dim devolucion As New EC.DevolucionProductosEntity
            Dim movAlm As CN.MovimientoAlmacenClass
            Dim folio As New CN.FoliosClass
            Dim caja As EC.MscloteCortesDetEntity
            Dim EmbarqueDetalle As New CC.MfacEmbarquesDetCollection

            If esCaja Then
                caja = New EC.MscloteCortesDetEntity
                trans.Add(caja)
                caja.FetchUsingPK(loteCorte.Trim, folioEtiqueta.Trim)
                caja.IdFolioEmbarque = ""

                caja.Save()
            End If

            movAlm = New CN.MovimientoAlmacenClass
            movAlm.EstablecerAlmacen(ClasesNegocio.MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
            movAlm.EstablecerTipoMovimiento(ClasesNegocio.InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Devolucion_Venta)
            movAlm.Estatus = ClasesNegocio.EstatusChar.VIGENTE
            movAlm.FechaMovimiento = Now
            movAlm.FolioMovmientoReferencia = ""
            movAlm.IdPoliza = ""
            movAlm.Kilos = kilos
            movAlm.Piezas = piezas
            movAlm.AgregarDetalle(idProducto, movAlm.Kilos, movAlm.Piezas, 0D, 0D)

            If Not movAlm.Guardar(trans) Then
                Throw New Exception("No se realizo la devolución, ocurrio un problema al afectar el inventario de cajas")
            End If

            folio.Año = Now.Year
            folio.Mes = Now.Month
            folio.Codigo = ClasesNegocio.CodigodeFolios.Devoluciones

            If Not folio.Guardar(trans) Then
                Throw New Exception("No se realizo la devolución, ocurrio un problema al generar el folio de la devolución")
            End If

            devolucion = New EC.DevolucionProductosEntity
            trans.Add(devolucion)
            devolucion.Folio = String.Format("{0}{1}{2}", Now.Year, Now.Month.ToString("00"), _
                                folio.Consecutivo.ToString("0000"))
            devolucion.FolioMovimientoAlmacen = movAlm.FolioMovimiento
            devolucion.Embarque = folioEmbarque
            devolucion.EnCaja = esCaja
            devolucion.Estatus = CN.EstatusDevolucion.ACTIVA
            devolucion.IdCliente = idCliente
            devolucion.IdFolioEtiqueta = folioEtiqueta
            devolucion.IdMotivoDevolucion = Me.cmbMotivoDevolucion.SelectedValue
            devolucion.IdProducto = movAlm.Detalle(0).IdProducto
            devolucion.IdUsuarioAlta = Controlador.Sesion.Usrndx
            devolucion.Kilos = movAlm.Kilos
            devolucion.Piezas = movAlm.Piezas
            devolucion.UtilparaVenta = True
            devolucion.Save()

            If EmbarqueDetalle.GetMulti(HC.MfacEmbarquesDetFields.IdFolioEmbarque = folioEmbarque And HC.MfacEmbarquesDetFields.IdFolioEtiqueta = folioEtiqueta) Then
                EmbarqueDetalle(0).Estatus = "D"
                trans.Add(EmbarqueDetalle(0))
                EmbarqueDetalle(0).Save()
            End If
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            Throw ex
        End Try
    End Sub

    Private Sub Limpiar()
        Dim color As Color = Me.txtFolio.BackColor

        Me.txtFolioEmbarque.BackColor = color
        Me.txtFolioEtiqueta.BackColor = color
        Me.txtPiezas.BackColor = color
        Me.txtCodigoCorte.BackColor = color
        Me.txtKilos.BackColor = color
        Me.cmbMotivoDevolucion.BackColor = color
        Me.txtCodigoMotivoDevolucion.BackColor = color
        Me.txtCliente.Clear()
        Me.txtCodigoCliente.Clear()
        Me.txtCodigoCorte.Clear()
        Me.txtCodigoPrecorte.Clear()
        Me.txtCorte.Clear()
        Me.txtFolio.Clear()
        Me.txtFolioEmbarque.Text = "F3 para buscar"
        Me.txtFolioEmbarque.ForeColor = Drawing.Color.Gray
        Me.txtFolioEmbarqueConsulta.Clear()
        Me.txtKilos.Clear()
        Me.txtLoteCorte.Clear()
        Me.txtPiezas.Clear()
        Me.txtPrecorte.Clear()
        Me.txtFolioEtiqueta.Clear()
        Me.cmbMotivoDevolucion.SelectedIndex = -1
        Me.dtFechaCaducidad.Value = Now
        Me.dtFechaEmbarque.Value = Now
        Me.dtFechaEmpaque.Value = Now
        Me.agregarPiezas = False
        Me.txtFolioEtiqueta.Text = "F3 para buscar"
    End Sub

    Private Sub Habilitar()
        Me.txtFolioEmbarque.Enabled = True
        Me.txtFolioEtiqueta.Enabled = True
        Me.txtCodigoCorte.Enabled = True
        Me.btnBuscarCortes.Enabled = True
        Me.txtPiezas.Enabled = True
        Me.txtKilos.Enabled = True
        Me.gbDevolucionesmasde1.Enabled = True
        Me.gbCaja.Enabled = True
        Me.txtCodigoMotivoDevolucion.Enabled = True
        Me.cmbMotivoDevolucion.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtFolioEmbarque.Enabled = False
        Me.txtFolioEtiqueta.Enabled = False
        Me.txtCodigoCorte.Enabled = False
        Me.btnBuscarCortes.Enabled = False
        Me.txtPiezas.Enabled = False
        Me.txtKilos.Enabled = False
        Me.gbDevolucionesmasde1.Enabled = False
        Me.gbCaja.Enabled = False
        Me.txtCodigoMotivoDevolucion.Enabled = False
        Me.cmbMotivoDevolucion.Enabled = False
        Me.txtFolioEtiqueta.Enabled = False
    End Sub

    Private Sub Buscar()
        Try
            Dim busqueda As New TC.VwBusquedaDevolucionesTypedView

            busqueda.Fill()

            Me.dgDevoluciones.AutoGenerateColumns = False
            Me.dgDevoluciones.DataSource = busqueda
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub HabilitarAgregadoCajas()
        Dim color As Color = Drawing.Color.White

        Deshabilitar()
        Me.dgDevoluciones.Enabled = False
        Me.txtFolioEtiqueta.Enabled = True
        Me.txtFolioEmbarque.BackColor = color
        Me.txtFolioEtiqueta.BackColor = color
        Me.txtPiezas.BackColor = color
        Me.txtKilos.BackColor = color
        Me.cmbMotivoDevolucion.BackColor = Drawing.Color.LightGoldenrodYellow
        Me.txtCodigoMotivoDevolucion.BackColor = Drawing.Color.LightGoldenrodYellow
        Me.txtFolioEtiqueta.BackColor = Drawing.Color.LightGoldenrodYellow
        Me.gbCaja.Enabled = False
        Me.gbDevolucionesmasde1.Enabled = False
        Me.txtFolioEmbarque.Enabled = False
        Me.agregarPiezas = False
        Me.cmbMotivoDevolucion.Enabled = True
        Me.txtCodigoMotivoDevolucion.Enabled = True
    End Sub

    Private Sub HabilitarAgregadoPiezas()
        Dim color As Color = Drawing.Color.LightGoldenrodYellow

        Me.txtPiezas.Focus()
        Me.txtFolioEtiqueta.Enabled = True
        Me.txtFolioEmbarque.BackColor = color
        Me.txtFolioEtiqueta.BackColor = color
        Me.txtPiezas.BackColor = color
        Me.txtKilos.BackColor = color
        Me.cmbMotivoDevolucion.BackColor = color
        Me.txtCodigoMotivoDevolucion.BackColor = color
        Me.txtCodigoCorte.BackColor = color
        Me.gbDevolucionesmasde1.Enabled = False
        Me.txtCodigoCorte.Enabled = False
        Me.agregarPiezas = True
        Me.txtCodigoCorte.Enabled = False
        Me.btnBuscarCortes.Enabled = False
    End Sub

    Private Function ValidarEtiqueta() As Boolean
        If Me.validandoEtiqueta Then
            Return False
        End If

        Me.validandoEtiqueta = True

        Try
            Dim vista As New TC.VwConsultaCortesParaReimprecionTypedView
            Dim filtro As New OC.PredicateExpression
            Dim ultimaFila As Integer = 0
            Dim etiquetas As New List(Of String)

            etiquetas.Add(Me.txtFolioEtiqueta.Text.Trim)

            filtro.Add(New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.IdFolioEtiqueta, etiquetas.ToArray))
            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1 And _
                        HC.VwConsultaCortesParaReimprecionFields.EstatusCad = "EMBARCADA")

            vista.Fill(0, Nothing, True, filtro)

            If vista.Count = 0 Then

                If Not Me.txtFolioEtiqueta.Text.Trim.Length = 0 Then
                    MsgBox("El folio de etiqueta no existe o no se encuentra embarcado")
                    Me.txtFolioEtiqueta.Clear()

                    Return False
                Else
                    Me.txtFolioEtiqueta.Clear()
                    Return False
                End If
            End If

            If Me.agregarPiezas Then
                If Not (CInt(Me.txtCodigoCorte.Text) = vista(0).IdCorte) Then
                    MsgBox("La Folio de Etiqueta pertenese a una caja de un producto diferente al ya ingresado", MsgBoxStyle.Exclamation, "Aviso")

                    If MessageBox.Show("¿Quiere devolver de todas formas la caja?" & vbNewLine & _
                                    "Si selecciona ""SI"" la devolución sera por la caja completa, los datos del embarque ya ingresados se ignoraran" & vbNewLine & _
                                    "Si selecciona ""NO"" se omitira la acción.", "Caja con producto diferente", _
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                        With vista(0)
                            Me.txtFolioEmbarque.Text = vista(0).IdFolioEmbarque.Trim
                            Me.txtCodigoCliente.Text = vista(0).IdCliente
                            Me.txtCliente.Text = vista(0).Cliente
                            Me.dtFechaEmbarque.Value = vista(0).FechaEmbarque
                            Me.txtLoteCorte.Text = vista(0).LoteCorte.Trim
                            Me.dtFechaCaducidad.Value = vista(0).FechaCad
                            Me.dtFechaEmpaque.Value = vista(0).FechaCorte
                            Me.txtCodigoCorte.Text = .IdCorte
                            Me.txtCorte.Text = .Corte
                            Me.txtCodigoPrecorte.Text = .IdPreCorte
                            Me.txtPrecorte.Text = .PreCorte
                            Me.txtPiezas.Text = .CantPzas
                            Me.txtKilos.Text = .CantKgrs.ToString("N2")
                        End With

                        Me.HabilitarAgregadoCajas()
                        Return True
                    Else
                        Me.txtFolioEtiqueta.Clear()

                        Return False
                    End If
                Else
                    If Not Me.txtFolioEmbarque.Text.Trim = vista(0).IdFolioEmbarque.Trim Then
                        If Me.txtFolioEmbarque.Text.Trim.Length = 0 Then
                            Me.txtFolioEmbarque.Text = vista(0).IdFolioEmbarque.Trim
                            Me.txtCodigoCliente.Text = vista(0).IdCliente
                            Me.txtCliente.Text = vista(0).Cliente
                            Me.dtFechaEmbarque.Value = vista(0).FechaEmbarque
                            Me.txtLoteCorte.Text = vista(0).LoteCorte.Trim
                            Me.dtFechaCaducidad.Value = vista(0).FechaCad
                            Me.dtFechaEmpaque.Value = vista(0).FechaCorte

                            Return True
                        Else
                            MsgBox("La caja no pertenese al embarque ingresado", MsgBoxStyle.Exclamation, "Aviso")

                            If MessageBox.Show("¿Aun asi quiere devolver la caja?" & vbNewLine & _
                                    "Si selecciona ""SI"" se cambiaran los datos del embarque ingresado por los del embarque al que pertenece la caja" & vbNewLine & _
                                    "Si selecciona ""NO"" se omitira la devolución de la caja.", "Devolver Caja", _
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                                Me.txtFolioEmbarque.Text = vista(0).IdFolioEmbarque.Trim
                                Me.txtCodigoCliente.Text = vista(0).IdCliente
                                Me.txtCliente.Text = vista(0).Cliente
                                Me.dtFechaEmbarque.Value = vista(0).FechaEmbarque
                                Me.txtLoteCorte.Text = vista(0).LoteCorte.Trim
                                Me.dtFechaCaducidad.Value = vista(0).FechaCad
                                Me.dtFechaEmpaque.Value = vista(0).FechaCorte

                                Return True
                            Else
                                Me.txtFolioEtiqueta.Clear()
                                Return False
                            End If
                        End If
                    Else
                        Me.txtLoteCorte.Text = vista(0).LoteCorte.Trim
                        Me.dtFechaCaducidad.Value = vista(0).FechaCad
                        Me.dtFechaEmpaque.Value = vista(0).FechaCorte

                        Return True
                    End If
                End If
            Else
                With vista(0)
                    Me.txtFolioEmbarque.Text = vista(0).IdFolioEmbarque.Trim
                    Me.txtCodigoCliente.Text = vista(0).IdCliente
                    Me.txtCliente.Text = vista(0).Cliente
                    Me.dtFechaEmbarque.Value = vista(0).FechaEmbarque
                    Me.txtLoteCorte.Text = vista(0).LoteCorte.Trim
                    Me.dtFechaCaducidad.Value = vista(0).FechaCad
                    Me.dtFechaEmpaque.Value = vista(0).FechaCorte
                    Me.txtCodigoCorte.Text = .IdCorte
                    Me.txtCorte.Text = .Corte
                    Me.txtCodigoPrecorte.Text = .IdPreCorte
                    Me.txtPrecorte.Text = .PreCorte
                    Me.txtPiezas.Text = .CantPzas
                    Me.txtKilos.Text = .CantKgrs.ToString("N2")
                End With

                Me.HabilitarAgregadoCajas()

                Return True
            End If
        Catch ex As Exception
            Me.txtFolioEtiqueta.Clear()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.validandoEtiqueta = False
        End Try
    End Function

    Private Function ValirdarEmbarque(ByVal folioEmbarque As String) As Boolean
        If Me.validandoEmbarque Then
            Return False
        End If

        Me.validandoEmbarque = True

        Try
            Dim vista As New TC.VwBusquedaEmbarquesTypedView

            vista.Fill(0, Nothing, True, HC.VwBusquedaEmbarquesFields.IdFolioEmbarque = folioEmbarque.Trim)

            If vista.Count > 0 Then
                With vista(0)
                    If .EstatusCad = "FACTURADO" Then
                        Me.txtFolioEmbarque.Text = .IdFolioEmbarque
                        Me.txtCliente.Text = .Nombre
                        Me.txtCodigoCliente.Text = .IdCliente
                        Me.dtFechaEmbarque.Value = .FechaEmbarque

                        If Not Me.agregarPiezas Then
                            Me.agregarPiezas = True
                            Me.HabilitarAgregadoPiezas()
                            Me.txtCodigoCorte.Enabled = True
                            Me.btnBuscarCortes.Enabled = True
                        End If

                        Me.txtFolioEmbarque.Enabled = False
                        Me.txtFolioEtiqueta.Focus()
                        Return True
                    Else
                        Me.txtFolioEmbarque.Clear()
                        MsgBox("El embarque que esta ingresando no a sido facturado, solo puede devolver cortes de un embarque facturado", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                End With
            Else
                Me.txtFolioEmbarque.Clear()
                MsgBox("El embarque no existe", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            Me.txtFolioEmbarque.Clear()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.validandoEmbarque = False
        End Try
    End Function

    Private Function ValidarGuardado() As Boolean
        Try
            If Me.agregarPiezas Then
                If Me.txtFolioEtiqueta.Text.Trim.Length = 0 Then
                    MsgBox("Debe ingresar un folio de etiqeuta", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If Me.txtFolioEmbarque.Text.Trim.Length = 0 Then
                    MsgBox("Debe ingresar un folio de embarque", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If Not (IsNumeric(Me.txtPiezas.Text) AndAlso CInt(Me.txtPiezas.Text) > 0) Then
                    MsgBox("Debe ingresar minimo 1 pieza", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If Not (IsNumeric(Me.txtKilos.Text) AndAlso CDec(Me.txtKilos.Text) > 0) Then
                    MsgBox("Debe ingresar mas de 0 Kilos", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If Me.txtFolioEtiqueta.Text.Trim.Length = 0 Then
                    MsgBox("Debe ingresar un folio de etiqueta", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If Me.txtFolioEmbarque.Text.Trim.Length = 0 Then
                    MsgBox("Debe ingresar un folio de embarque", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If

            If Me.txtLoteCorte.Text.Trim.Length = 0 Then
                MsgBox("Debe ingresar un folio de etiqueta", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If Me.cmbMotivoDevolucion.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar un motivo de devolución", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If Me.txtCodigoCliente.Text.Trim.Length = 0 Then
                MsgBox("Debe ingresar un folio de embarque", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub frmDevolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "000100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "000100011"
            MtbEstados.StateBorrar = "000100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Me.mtb.Buttons(1).Visible = False
            Me.Buscar()
            Me.Deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar

    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Deshabilitar()
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Me.ValidarGuardado Then
                Me.Devolver(Me.txtFolioEmbarque.Text.Trim, Me.txtFolioEtiqueta.Text.Trim, Me.txtLoteCorte.Text.Trim, CInt(Me.txtCodigoCorte.Text), CInt(Me.txtCodigoCliente.Text), CInt(Me.txtPiezas.Text), CDec(Me.txtKilos.Text), Not Me.agregarPiezas)

                If Me.agregarPiezas Then
                    MsgBox("Se a devuelto la pieza", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("Se a devuelto la caja", MsgBoxStyle.Information, "Aviso")
                End If

                Me.Deshabilitar()
                Me.Limpiar()
                Me.Buscar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Cursor = Cursors.WaitCursor

        Try
            Me.MotivoDevolucionC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Limpiar()
            Me.Habilitar()
            Me.txtFolioEtiqueta.Focus()
            Me.txtFolioEmbarque.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "TextBox"
    Private Sub txtFolioEmbarque_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolioEmbarque.GotFocus
        If Me.txtFolioEmbarque.Text.Trim = "F3 para buscar" Then
            Me.txtFolioEmbarque.Clear()
            Me.txtFolioEmbarque.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtFolioEmbarque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioEmbarque.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtFolioEmbarque.Text.Trim.Length > 0 AndAlso Not Me.validandoEmbarque Then
                Me.ValirdarEmbarque(Me.txtFolioEmbarque.Text.Trim)
            End If
        End If
    End Sub

    Private Sub txtFolioEmbarque_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolioEmbarque.LostFocus
        If Not Me.validandoEmbarque AndAlso (Me.txtFolioEmbarque.Text.Trim.Length = 0 OrElse Me.txtFolioEmbarque.Text.Trim = "F3 para buscar") Then
            Me.txtFolioEmbarque.Text = "F3 para buscar"
            Me.txtFolioEmbarque.ForeColor = Color.Gray
        Else
            If Not Me.validandoEmbarque AndAlso ValirdarEmbarque(Me.txtFolioEmbarque.Text.Trim) Then
                Me.txtFolioEmbarque.Text = "F3 para buscar"
                Me.txtFolioEmbarque.ForeColor = Color.Gray
            End If
        End If
    End Sub

    Private Sub txtFolioEmbarque_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioEmbarque.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Try
                Dim Consultas As New MConsEmbarques

                Consultas.EstatusDefault(True) = ClasesNegocio.EstatusCharX.FACTURADO

                Me.validandoEmbarque = True

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.validandoEmbarque = False
                    Me.ValirdarEmbarque(Consultas.DgvEmbarques.SelectedRows(0).Cells(Consultas.IdFolioEmbarque.Index).Value.ToString.Trim)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtCodigoCorte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoCorte.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtCodigoCorte.Text) Then
                Try
                    Dim cortePrecorte As New EC.MsccortesPreCortesEntity
                    Dim color As Color = Drawing.Color.LightGoldenrodYellow

                    If cortePrecorte.FetchUsingPK(CInt(Me.txtCodigoCorte.Text)) Then
                        Me.txtCorte.Text = cortePrecorte.MsccatProductos.Descripcion
                        Me.txtCodigoPrecorte.Text = cortePrecorte.IdPreCorte
                        Me.txtPrecorte.Text = cortePrecorte.MsccatProductos_.Descripcion

                        Me.HabilitarAgregadoPiezas()
                    Else
                        MsgBox("No existe un corte con ese código", MsgBoxStyle.Exclamation, "Aviso")
                        Me.txtCodigoCorte.SelectAll()
                    End If
                Catch ex As Exception

                End Try
            End If

        End If
    End Sub

    Private Sub txtFolioEtiqueta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolioEtiqueta.GotFocus
        If Me.txtFolioEtiqueta.Text.Trim = "F3 para buscar" Then
            Me.txtFolioEtiqueta.Clear()
            Me.txtFolioEtiqueta.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtFolioEtiqueta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioEtiqueta.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtFolioEtiqueta.Text.Trim.Length > 0 AndAlso Not Me.validandoEtiqueta Then
                ValidarEtiqueta()
            End If
        End If
    End Sub

    Private Sub txtFolioEtiqueta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolioEtiqueta.LostFocus
        If Not Me.validandoEtiqueta AndAlso (Me.txtFolioEtiqueta.Text.Trim.Length = 0 OrElse Me.txtFolioEtiqueta.Text.Trim = "F3 para buscar") Then
            Me.txtFolioEtiqueta.Text = "F3 para buscar"
            Me.txtFolioEtiqueta.ForeColor = Color.Gray
        Else
            If Not Me.validandoEtiqueta AndAlso Not ValidarEtiqueta() Then
                Me.txtFolioEtiqueta.Text = "F3 para buscar"
                Me.txtFolioEtiqueta.ForeColor = Color.Gray
            End If
        End If
    End Sub

    Private Sub txtFolioEtiqueta_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioEtiqueta.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Dim busqueda As New FrmBusquedaCortesConEtiqueta

            busqueda.DgvCortes.MultiSelect = False
            busqueda.DgvCortes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            busqueda.clmSeleccion.Visible = False
            busqueda.EstablecerEstatus(False, True, False, False, False)

            If busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtFolioEtiqueta.Text = busqueda.DgvCortes.SelectedRows(0).Cells(busqueda.clmFolioEtiqueta.Index).Value
                Me.txtFolioEtiqueta_KeyPress(sender, New KeyPressEventArgs(Chr(13)))
            End If
        End If
    End Sub

    Private Sub txtFolioEmbarqueConsulta_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioEmbarqueConsulta.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Try
                Dim Consultas As New MConsEmbarques

                Consultas.EstatusDefault(True) = ClasesNegocio.EstatusCharX.FACTURADO

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtFolioEmbarqueConsulta.Text = Consultas.DgvEmbarques.SelectedRows(0).Cells(Consultas.IdFolioEmbarque.Index).Value.ToString.Trim
                    Me.Buscar(Me.txtFolioEmbarqueConsulta.Text.Trim)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
#End Region

#Region "Butons"
    Private Sub btnBusquedaEtiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusquedaEtiquetas.Click
        Try
            If Me.cmbMotivoDevolucion.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar un motivo de devolución", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            Else
                Me.motivoDecomiso = Me.cmbMotivoDevolucion.SelectedValue
            End If

            Dim busqueda As New FrmBusquedaCortesConEtiqueta

            busqueda.EstablecerEstatus(False, True, False, False, False)

            If busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim etiquetas As New List(Of String)

                For i As Integer = 0 To busqueda.DgvCortes.Rows.Count - 1
                    Dim row As DataGridViewRow = busqueda.DgvCortes.Rows(i)

                    If CBool(row.Cells(busqueda.clmSeleccion.Index).Value) Then
                        etiquetas.Add(row.Cells(busqueda.clmFolioEtiqueta.Index).Value)
                    End If
                Next

                Me.Buscar(etiquetas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnVaciarPistola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaciarPistola.Click
        Try
            If Me.cmbMotivoDevolucion.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar un motivo de devolución", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            Else
                Me.motivoDecomiso = Me.cmbMotivoDevolucion.SelectedValue
            End If

            Dim abrirArchivo As New OpenFileDialog

            abrirArchivo.Filter = "Archivos de Texto(Bloc de Notas)*.txt|*.txt"

            If abrirArchivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fileContents As String
                Dim etiquetas As New List(Of String)

                fileContents = My.Computer.FileSystem.ReadAllText(abrirArchivo.FileName)

                For Each folioEtiqueta As String In fileContents.Split(New Char() {Chr(13), Chr(10)})
                    If Not folioEtiqueta.Trim = "" Then
                        etiquetas.Add(folioEtiqueta.Trim)
                    End If
                Next
                Me.Buscar(etiquetas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmdBuscarCortes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCortes.Click
        Try
            Dim TablaProductos As New DataSet
            Dim Consultas As New FrmConsultaCortes
            Dim productos As New ClasesNegocio.ProductosClass

            TablaProductos = productos.Obtener(0, "", 0, 9)

            If TablaProductos.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No existen cortes para captura", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Consultas.dgvCortes.AutoGenerateColumns = False
                Consultas.dgvCortes.DataSource = TablaProductos.Tables(0)
                Consultas.Codigo.DataPropertyName = "IdCorte"
                Consultas.Descripcion.DataPropertyName = "Descripcion"
                Consultas.Piezas.DataPropertyName = "MaximoPiezasxCaja"
                Consultas.CodigoPrecorte.DataPropertyName = "IdPrecorte"
                Consultas.DescripcionPrecorte.DataPropertyName = "PreCorte"

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtCodigoPrecorte.Text = Consultas.dgvCortes.CurrentRow.Cells("CodigoPreCorte").Value
                    Me.txtPrecorte.Text = Consultas.dgvCortes.CurrentRow.Cells("DescripcionPreCorte").Value
                    Me.txtPiezas.Text = Consultas.dgvCortes.CurrentRow.Cells("Piezas").Value
                    Me.txtCodigoCorte.Text = Consultas.dgvCortes.CurrentRow.Cells("Codigo").Value

                    If DBNull.Value.Equals(Consultas.dgvCortes.CurrentRow.Cells("Descripcion").Value) Then
                        Me.txtCorte.Text = ""
                    Else
                        Me.txtCorte.Text = Consultas.dgvCortes.CurrentRow.Cells("Descripcion").Value
                    End If

                    Me.HabilitarAgregadoPiezas()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgDevoluciones_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgDevoluciones.PreviewKeyDown
        If Me.dgDevoluciones.SelectedRows.Count > 0 Then
            If e.KeyCode = Keys.Delete Then
                If Me.dgDevoluciones.SelectedRows(0).Cells(Me.clmFolioDevilucion.Index).Value.ToString.Trim = "CANCELADA" Then
                    MsgBox("Ya esta cancelada", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If

                If MessageBox.Show("¿Quiere cancelar la devolución?", "Cancelar Devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If Me.CancelarDevolucion(Me.dgDevoluciones.SelectedRows(0).Cells(Me.clmFolioDevilucion.Index).Value.ToString.Trim) Then
                        MsgBox("Devolución Cancelada", MsgBoxStyle.Information, "Aviso")
                        Deshabilitar()
                        Limpiar()
                        Me.Buscar()
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmbMotivoDevolucion_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMotivoDevolucion.ActualizarCombo
        Try
            Me.MotivoDevolucionC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region
#End Region
End Class