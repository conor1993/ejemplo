Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class FrmBusquedaCortesConEtiqueta
    Public EtiquetasSelecionadas() As String

    Private _Almacen As EC.AlmacenEntity
    Private _IdCliente As Integer

    Private Sub FrmBusquedaCortesConEtiqueta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Controlador.LlenarComboAlmacenesDeProduccion(cmbAlmacen)

        If _Almacen IsNot Nothing Then
            cmbAlmacen.SelectedValue = _Almacen.AlmacenId
            cmbAlmacen.Enabled = False
        End If

        Buscar()
        Me.chkAgregar.Checked = False
        Me.dtpFecha.Enabled = False

        AddHandler txtAlmacenCodigo.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosEnteros
    End Sub

    Private Sub Buscar()
        Try
            Dim Vista As New TC.VwBusquedaCortesTypedView
            Dim Filtro As New OC.PredicateExpression

            If Me.txtFolioEtiqueta.Text.Trim = "" Then
                If _Almacen IsNot Nothing Then
                    Filtro.Add(HC.VwBusquedaCortesFields.IdAlmacen <> _Almacen.AlmacenId)

                    If _Almacen.TipoProducto = 1 Then
                        Filtro.Add(HC.VwBusquedaCortesFields.TipoAlmacen <> 2)
                    End If
                ElseIf cmbAlmacen.SelectedIndex > -1 Then
                    Filtro.Add(HC.VwBusquedaCortesFields.IdAlmacen = CType(cmbAlmacen.SelectedValue, Integer))
                End If

                If Me.chkAgregar.Checked Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaCortesFields.FechaCorte, Me.dtpFecha.Value.ToShortDateString, Me.dtpFecha.Value.AddDays(1).ToShortDateString))
                End If

                If IsNumeric(Me.txtKilos.Text) AndAlso CDec(Me.txtKilos.Text) > 0D Then
                    Filtro.Add(HC.VwBusquedaCortesFields.CantKgrs = CDec(Me.txtKilos.Text))
                End If

                Filtro.Add(HC.VwBusquedaCortesFields.LoteSacrificio Mod String.Format("%{0}%", Me.txtFolioSacrificio.Text.Trim))

                Filtro.Add(HC.VwBusquedaCortesFields.NomSubCorte Mod String.Format("%{0}%", Me.txtCorte.Text.Trim))

                If IsNumeric(Me.txtPiezas.Text) AndAlso CInt(Me.txtPiezas.Text) > 0 Then
                    Filtro.Add(HC.VwBusquedaCortesFields.CantPzas = CInt(Me.txtPiezas.Text))
                End If

                Filtro.Add(HC.VwBusquedaCortesFields.NomSubCorte Mod String.Format("%{0}%", Me.txtLoteCorte.Text.Trim))

                Dim filtroEstatus As New OC.PredicateExpression

                If Me.chkAjustada.Checked Then
                    filtroEstatus.AddWithOr(HC.VwBusquedaCortesFields.Estatus = "AJUSTADA")
                End If

                If Me.ChkCanceladas.Checked Then
                    filtroEstatus.AddWithOr(HC.VwBusquedaCortesFields.Estatus = "CANCELADA")
                End If

                If Me.chkEmbarcadas.Checked Then
                    filtroEstatus.AddWithOr(HC.VwBusquedaCortesFields.Estatus = "EMBARCADA")
                End If

                If Me.chkReproceso.Checked Then
                    filtroEstatus.AddWithOr(HC.VwBusquedaCortesFields.Estatus = "REPROCESO")
                End If

                If Me.chkVigentes.Checked Then
                    filtroEstatus.AddWithOr(HC.VwBusquedaCortesFields.Estatus = "VIGENTE")
                End If

                If _IdCliente > 0 Then
                    filtroEstatus.AddWithOr(HC.VwBusquedaCortesFields.IdCliente = _IdCliente)
                End If



                Filtro.Add(filtroEstatus)

                Filtro.Add(HC.VwBusquedaCortesFields.IdFolioEmbarque Mod String.Format("%{0}%", Me.txtFolioEmbarque.Text.Trim))
            Else
                Filtro.Add(HC.VwBusquedaCortesFields.IdFolioEtiqueta Mod String.Format("%{0}%", Me.txtFolioEtiqueta.Text.Trim))
            End If

            Vista.Fill(0, Nothing, True, Filtro)

            Me.DgvCortes.AutoGenerateColumns = False
            Me.DgvCortes.DataSource = Vista

            If Not EtiquetasSelecionadas Is Nothing Then
                Dim Tope As Integer = 0

                For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                    For j As Integer = 0 To Me.EtiquetasSelecionadas.Length - 1
                        If DgvCortes.Rows(i).Cells(Me.clmFolioEtiqueta.Index).Value = Me.EtiquetasSelecionadas(j) Then
                            DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).Value = True
                            DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).ReadOnly = True
                            Tope += 1
                            Exit For
                        End If
                    Next

                    If Tope = Me.EtiquetasSelecionadas.Length Then
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Enum EstatusCaja
        CANCELADA
        VIGENTE
        EMBARCADA
        REPROCESO
    End Enum

    Public Sub EstablecerEstatus(ByVal vigentes As Boolean, ByVal embarcadas As Boolean, _
                                ByVal reproceso As Boolean, ByVal canceladas As Boolean, ByVal ajustadas As Boolean, Optional ByVal IdCliente As Integer = 0)
        If Not ((Not vigentes AndAlso Not embarcadas AndAlso Not reproceso AndAlso Not canceladas) OrElse (vigentes AndAlso embarcadas AndAlso reproceso AndAlso canceladas)) Then
            Me.GroupBox1.Enabled = False
            Me.chkVigentes.Checked = vigentes
            Me.chkReproceso.Checked = reproceso
            Me.chkEmbarcadas.Checked = embarcadas
            Me.ChkCanceladas.Checked = canceladas
            Me.chkAjustada.Checked = ajustadas
            Me._IdCliente = IdCliente
        End If
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim Enc As Boolean

        If Me.DgvCortes.MultiSelect Then
            For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                If CBool(Me.DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
                    Enc = True
                End If
            Next
        Else
            Enc = Me.DgvCortes.SelectedRows.Count > 0
        End If

        If Enc = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub chkAgregar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgregar.CheckedChanged
        If Me.chkAgregar.Checked Then
            Me.dtpFecha.Enabled = True
        Else
            Me.dtpFecha.Enabled = False
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Try
            Me.txtKilos.Text = ""
            Me.dtpFecha.Value = Now
            Me.dtpFecha.Enabled = False
            Me.txtCorte.Text = ""
            Me.txtFolioSacrificio.Text = ""
            Me.txtLoteCorte.Clear()
            Me.txtPiezas.Clear()
            Me.txtFolioEtiqueta.Clear()
            Me.txtFolioEmbarque.Clear()

            If Me.GroupBox1.Enabled Then
                For Each chk As CheckBox In Me.GroupBox1.Controls
                    chk.Checked = True
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub chkVigentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged
        If Not Me.ChkCanceladas.Checked AndAlso Not Me.chkEmbarcadas.Checked AndAlso _
                    Not Me.chkReproceso.Checked AndAlso Not Me.chkVigentes.Checked AndAlso Not Me.chkAjustada.Checked Then
            Me.chkVigentes.Checked = True
            Me.chkReproceso.Checked = True
            Me.chkEmbarcadas.Checked = True
            Me.ChkCanceladas.Checked = True
            Me.chkAjustada.Checked = True
        End If
    End Sub

    Private Sub chkEmbarcadas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmbarcadas.CheckedChanged
        If Not Me.ChkCanceladas.Checked AndAlso Not Me.chkEmbarcadas.Checked AndAlso _
                    Not Me.chkReproceso.Checked AndAlso Not Me.chkVigentes.Checked AndAlso Not Me.chkAjustada.Checked Then
            Me.chkVigentes.Checked = True
            Me.chkReproceso.Checked = True
            Me.chkEmbarcadas.Checked = True
            Me.ChkCanceladas.Checked = True
            Me.chkAjustada.Checked = True
        End If
    End Sub

    Private Sub chkReproceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReproceso.CheckedChanged
        If Not Me.ChkCanceladas.Checked AndAlso Not Me.chkEmbarcadas.Checked AndAlso _
                    Not Me.chkReproceso.Checked AndAlso Not Me.chkVigentes.Checked AndAlso Not Me.chkAjustada.Checked Then
            Me.chkVigentes.Checked = True
            Me.chkReproceso.Checked = True
            Me.chkEmbarcadas.Checked = True
            Me.ChkCanceladas.Checked = True
            Me.chkAjustada.Checked = True
        End If
    End Sub

    Private Sub ChkCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCanceladas.CheckedChanged
        If Not Me.ChkCanceladas.Checked AndAlso Not Me.chkEmbarcadas.Checked AndAlso _
                    Not Me.chkReproceso.Checked AndAlso Not Me.chkVigentes.Checked AndAlso Not Me.chkAjustada.Checked Then
            Me.chkVigentes.Checked = True
            Me.chkReproceso.Checked = True
            Me.chkEmbarcadas.Checked = True
            Me.ChkCanceladas.Checked = True
            Me.chkAjustada.Checked = True
        End If
    End Sub

    Private Sub chkAjustada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAjustada.CheckedChanged
        If Not Me.ChkCanceladas.Checked AndAlso Not Me.chkEmbarcadas.Checked AndAlso _
            Not Me.chkReproceso.Checked AndAlso Not Me.chkVigentes.Checked AndAlso Not Me.chkAjustada.Checked Then
            Me.chkVigentes.Checked = True
            Me.chkReproceso.Checked = True
            Me.chkEmbarcadas.Checked = True
            Me.ChkCanceladas.Checked = True
            Me.chkAjustada.Checked = True
        End If
    End Sub

    Private Sub txtFolioEmbarque_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioEmbarque.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Try
                Dim Consultas As New MConsEmbarques

                Consultas.RbtnCancelado.Enabled = False
                Consultas.rbtnTodos.Enabled = False
                Consultas.RbtnVigente.Checked = True

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtFolioEmbarque.Text = Consultas.DgvEmbarques.SelectedRows(0).Cells(Consultas.IdFolioEmbarque.Index).Value.ToString.Trim
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSleccionar.Click
        For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
            Me.DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).Value = True
        Next
    End Sub

    Private Sub btnQuitarSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarSeleccion.Click
        For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
            Me.DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).Value = False
        Next
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New(ByVal Almacen As EC.AlmacenEntity)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        _Almacen = Almacen
    End Sub

    Private Sub txtAlmacenCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlmacenCodigo.TextChanged
        If IsNumeric(txtAlmacenCodigo.Text) Then
            cmbAlmacen.SelectedValue = Integer.Parse(txtAlmacenCodigo.Text)
        Else
            cmbAlmacen.SelectedIndex = -1
            cmbAlmacen.Text = "Seleccione el Almacen"
        End If
    End Sub

    Private Sub cmbAlmacen_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectionChangeCommitted
        txtAlmacenCodigo.Text = cmbAlmacen.SelectedValue.ToString
    End Sub
End Class