Imports ClasesNegocio
Imports TC = Integralab.ORM.TypedViewClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmSalidaXReproceso

#Region "Miembros"
    Dim loteReproceso As New EC.MscloteCortesCabEntity
    Dim caracteres() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
#End Region

#Region "Metodos"
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

    Private Sub BuscarCajasAReproceso(ByVal etiquetas As List(Of String))
        Try
            Dim vista As New TC.VwConsultaCortesParaReimprecionTypedView
            Dim filtro As New OC.PredicateExpression

            filtro.Add(New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.IdFolioEtiqueta, etiquetas.ToArray) Or New OC.FieldCompareRangePredicate(HC.VwConsultaCortesParaReimprecionFields.CodigoBarra, etiquetas.ToArray))
            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.Estatus = 1 And HC.VwConsultaCortesParaReimprecionFields.EstatusCad = "VIGENTE")

            vista.Fill(0, Nothing, True, filtro)

            If vista.Count > 0 Then
                Me.AgregarCajas(vista)
            Else
                MsgBox("Las etiquetas no se les puede dar salida a reproceso. Compruebe si no estan Embarcadas, Canceladas o Reprocesadas", MsgBoxStyle.Exclamation, "AvisO")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub ObtenerCajasDelLoteReproceso()
        Try
            Dim vista As New TC.VwConsultaCortesParaReimprecionTypedView
            Dim filtro As New OC.PredicateExpression

            filtro.Add(HC.VwConsultaCortesParaReimprecionFields.LoteCorteReproceso = Me.txtLoteCorteReproceso.Text.Trim)

            vista.Fill(0, Nothing, True, filtro)

            Dim ultimaFila As Integer = 0
            Me.DgvCortes.Rows.Clear()

            For Each row As TC.VwConsultaCortesParaReimprecionRow In vista
                Me.DgvCortes.Rows.Add(1)

                With Me.DgvCortes.Rows(ultimaFila)
                    .Cells(Me.clmSelecciono.Index).Value = False
                    .Cells(Me.clmEtiqueta.Index).Value = row.IdFolioEtiqueta.Trim
                    .Cells(Me.clmLoteCorte.Index).Value = row.LoteCorte.Trim
                    .Cells(Me.clmCliente.Index).Value = row.Cliente.Trim
                    .Cells(Me.clmPrecorte.Index).Value = row.PreCorte.Trim
                    .Cells(Me.clmCorte.Index).Value = row.Corte.Trim
                    .Cells(Me.clmPiezas.Index).Value = row.CantPzas
                    .Cells(Me.clmKilos.Index).Value = row.CantKgrs
                    .Cells(Me.clmFechaCorte.Index).Value = row.FechaCorte
                    .Cells(Me.clmFechaCad.Index).Value = row.FechaCad
                    .Cells(Me.clmIdPreCorte.Index).Value = row.IdPreCorte
                    .Cells(Me.clmIdCorte.Index).Value = row.IdCorte
                    .Cells(Me.clmGrados.Index).Value = 0D
                End With

                ultimaFila += 1
            Next

            Me.loteReproceso.Refetch()
            Me.txtPiezas.Text = Me.loteReproceso.TotalPzas
            Me.txtkilos.Text = Me.loteReproceso.TotalKgs.ToString("N2")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub AgregarCajas(ByVal vista As TC.VwConsultaCortesParaReimprecionTypedView)
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")

        Try
            For Each row As TC.VwConsultaCortesParaReimprecionRow In vista
                Guardar(row.LoteCorte, row.IdFolioEtiqueta, trans)
            Next

            trans.Commit()
            MsgBox("Salida por reproceso realizada", MsgBoxStyle.Information, "AvisO")
            Me.ObtenerCajasDelLoteReproceso()
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SalidaCaja(ByVal loteCorte As String, ByVal folioEtiqueta As String, ByVal trans As HC.Transaction)
        Try
            Dim caja As New EC.MscloteCortesDetEntity
            Dim movimientoAlmacen As New MovimientoAlmacenClass

            trans.Add(caja)

            caja.FetchUsingPK(loteCorte, folioEtiqueta)

            With movimientoAlmacen
                .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Reproceso)
                .Estatus = EstatusChar.VIGENTE
                .FechaMovimiento = Now
                .IdPoliza = ""
                .Kilos = caja.CantKgrs
                .Piezas = caja.CantPzas

                .AgregarDetalle(caja.IdProducto, caja.CantKgrs, caja.CantPzas, 0D, 0D)

                If Not .Guardar(trans) Then
                    Throw New Exception("No se logro dar salida a la caja " & folioEtiqueta)
                End If
            End With

            caja.IdFolioMovimientoAlmacenReproceso = movimientoAlmacen.FolioMovimiento
            caja.Estatus = EstatusCorte.REPROCESO
            caja.LoteCorteReproceso = Me.txtLoteCorteReproceso.Text


            caja.Save()

            trans.Add(loteReproceso)

            loteReproceso.TotalKgs += caja.CantKgrs
            loteReproceso.TotalPzas += caja.CantPzas

            loteReproceso.Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CancelacionCaja(ByVal loteCorte As String, ByVal folioEtiqueta As String) As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelacion Reproceso")

        Try
            Dim caja As New EC.MscloteCortesDetEntity
            Dim movimientoAlmacen As New MovimientoAlmacenClass

            trans.Add(caja)

            caja.FetchUsingPK(loteCorte, folioEtiqueta)

            With movimientoAlmacen
                .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Cancelacion_Reproceso)
                .Estatus = EstatusChar.VIGENTE
                .FechaMovimiento = Now
                .IdPoliza = ""
                .Kilos = caja.CantKgrs
                .Piezas = caja.CantPzas
                .FolioMovmientoReferencia = caja.IdFolioMovimientoAlmacenReproceso

                .AgregarDetalle(caja.IdProducto, caja.CantKgrs, caja.CantPzas, 0D, 0D)

                If Not .Guardar(trans) Then
                    Throw New Exception("No se logro dar salida a la caja " & folioEtiqueta)
                End If
            End With

            caja.IdFolioMovimientoAlmacenReproceso = ""
            caja.Estatus = EstatusCorte.VIGENTE
            caja.LoteCorteReproceso = ""

            caja.Save()

            trans.Add(loteReproceso)

            loteReproceso.TotalKgs -= caja.CantKgrs
            loteReproceso.TotalPzas -= caja.CantPzas

            loteReproceso.Save()

            trans.Commit()
            MsgBox("Se cancelo el reproceso de la caja " & caja.IdFolioEtiqueta)
            Return True
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Guardar(ByVal loteCorte As String, ByVal folioEtiqueta As String, ByVal trans As HC.Transaction)
        Try
            Dim LoteCorteReproceso As New CortesClass

            If Trim(Me.txtLoteCorteReproceso.Text) = "" Or Me.txtLoteCorteReproceso.Text = "NUEVO" Then
                If MessageBox.Show("Esta apunto de crear un nuevo lote de corte. ¿Esta seguro que quiere continuar?", "Crear Lote de Corte Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Throw New Exception("Salida Cancelada")
                End If

                trans.Add(loteReproceso)

                Dim col As New CC.MscloteCortesCabCollection
                Dim nuevoLote As String
                Dim lote As New EC.MscloteCortesCabEntity

                Do
                    nuevoLote = CrearLote()

                    If col.GetDbCount(HC.MscloteCortesCabFields.LoteCorte = nuevoLote) = 0 Then
                        Exit Do
                    End If
                Loop

                loteReproceso.LoteCorte = nuevoLote
                loteReproceso.FechaCorte = Me.dtpFechaCorte.Value
                loteReproceso.FechaCad = Me.dtpFechaCorte.Value.AddDays(30)
                loteReproceso.DiasCad = 30
                loteReproceso.IdCliente = 0
                loteReproceso.LoteSacrificio = ""
                loteReproceso.Estatus = "A"
                loteReproceso.EsReproceso = True

                loteReproceso.Save()

                Me.txtLoteCorteReproceso.Text = loteReproceso.LoteCorte
            End If

            Me.SalidaCaja(loteCorte, folioEtiqueta, trans)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Limpiar()
        Try
            Me.txtLoteCorteReproceso.Clear()
            Me.txtFolioEtiqueta.Clear()
            Me.txtPiezas.Clear()
            Me.txtkilos.Clear()
            Me.dtpFechaCorte.Value = Now
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Habilitar()
        Me.dtpFechaCorte.Enabled = True
        Me.gbCajas.Enabled = True
    End Sub
#End Region

#Region "Eventos"
    Private Sub btnVaciarPistola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaciarPistola.Click
        Try
            Dim abrirArchivo As New OpenFileDialog

            abrirArchivo.Filter = "Archivos de Texto(Bloc de Notas)*.txt|*.txt"

            If abrirArchivo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fileContents As String
                Dim etiquetas As New List(Of String)
                Dim etiquetasAgregadas As New List(Of String)
                Dim cajas() As String = Nothing

                For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                    etiquetasAgregadas.Add(Me.DgvCortes.Rows(i).Cells(Me.clmEtiqueta.Index).Value.ToString.Trim)
                Next

                If etiquetasAgregadas.Count > 0 Then
                    cajas = etiquetasAgregadas.ToArray
                End If

                fileContents = My.Computer.FileSystem.ReadAllText(abrirArchivo.FileName)

                For Each folioEtiqueta As String In fileContents.Split(New Char() {Chr(13), Chr(10)})
                    If Not folioEtiqueta.Trim = "" AndAlso (etiquetasAgregadas.Count = 0 OrElse _
                        (etiquetasAgregadas.Count > 0 AndAlso Not Array.IndexOf(cajas, folioEtiqueta.Trim) > -1)) Then
                        etiquetas.Add(folioEtiqueta.Trim)
                    End If
                Next

                If etiquetas.Count > 0 Then
                    Me.BuscarCajasAReproceso(etiquetas)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBusquedaEtiquetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusquedaEtiquetas.Click
        Try
            Dim busqueda As New FrmBusquedaCortesConEtiqueta
            Dim etiquetasAgregadas As New List(Of String)

            busqueda.EstablecerEstatus(True, False, False, False, False)

            For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                etiquetasAgregadas.Add(Me.DgvCortes.Rows(i).Cells(Me.clmEtiqueta.Index).Value.ToString.Trim)
            Next

            busqueda.EtiquetasSelecionadas = etiquetasAgregadas.ToArray

            If busqueda.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim etiquetas As New List(Of String)

                For i As Integer = 0 To busqueda.DgvCortes.Rows.Count - 1
                    Dim row As DataGridViewRow = busqueda.DgvCortes.Rows(i)

                    If CBool(row.Cells(busqueda.clmSeleccion.Index).Value) Then
                        etiquetas.Add(row.Cells(busqueda.clmFolioEtiqueta.Index).Value)
                    End If
                Next

                Me.BuscarCajasAReproceso(etiquetas)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dtpFechaCorte_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaCorte.ValueChanged
        Me.dtpFechaCaducidad.Value = Me.dtpFechaCorte.Value.AddDays(30)
    End Sub

    Private Sub txtEmbarque_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioEtiqueta.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim etiqueta As New List(Of String)

            etiqueta.Add(Me.txtFolioEtiqueta.Text.Trim)

            Me.BuscarCajasAReproceso(etiqueta)
        End If
    End Sub

    Private Sub DgvCortes_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DgvCortes.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Delete AndAlso Me.DgvCortes.CurrentRow.Index > -1 Then
                If Me.CancelacionCaja(Me.DgvCortes.CurrentRow.Cells(Me.clmLoteCorte.Index).Value, Me.DgvCortes.CurrentRow.Cells(Me.clmEtiqueta.Index).Value) Then _
                    Me.ObtenerCajasDelLoteReproceso()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New _960BusquasedaLotesDeCortes
            Ventana.Icon = Me.Icon
            Ventana.gbEstatus.Enabled = False
            Ventana.chkVigentes.Checked = True
            Ventana.chkCerrado.Checked = False
            Ventana.gbTipoLote.Enabled = False
            Ventana.chkProduccion.Checked = False
            Ventana.chkReproceso.Checked = True

            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtLoteCorteReproceso.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
                Me.ObtenerCajasDelLoteReproceso()
                Me.txtPiezas.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmPiezas.Index).Value
                Me.txtkilos.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.cmlKilos.Index).Value
                Me.dtpFechaCorte.Value = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmFechaCorte.Index).Value
                Me.dtpFechaCorte.Enabled = False
                Me.gbCajas.Enabled = True
                Me.loteReproceso.FetchUsingPK(Me.txtLoteCorteReproceso.Text.Trim)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region
#End Region
End Class