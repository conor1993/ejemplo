Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports ClasesNegocio

Public Class frmBusquedaLotes

#Region "Miembros"
    Private PreFiltrado As OC.PredicateExpression = Nothing
#End Region

#Region "Constructores"
    Sub New(Optional ByVal PreFiltrado As LoteClass.EstatusLote = LoteClass.EstatusLote.TODOS)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If PreFiltrado <> LoteClass.EstatusLote.TODOS Then
            Me.PreFiltrado = New OC.PredicateExpression(HC.McecatLotesCabFields.Estatus = PreFiltrado)
        End If
    End Sub
#End Region

    Public Sub Limpiar()
        Me.cmbCorral.SelectedIndex = -1
        Me.cmbCorral.Text = "Seleccione un corral..."
        Me.txtDescripcion.Clear()
        Me.txtCodigoLote.Clear()
        Me.chkFiltrarFecha.Checked = False
        Me.dtFechaInicial.Enabled = chkFiltrarFecha.Checked
        Me.dtFechaFinal.Enabled = chkFiltrarFecha.Checked
    End Sub

    Public Function ObtenerSeleccionados() As LoteCollectionClass
        ObtenerSeleccionados = New LoteCollectionClass()

        For Each Fila As DataGridViewRow In dgLotes.SelectedRows
            ObtenerSeleccionados.Add(CType(Fila.DataBoundItem, LoteClass))
        Next
        Return ObtenerSeleccionados
    End Function

    Private Sub chkFiltrarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarFecha.CheckedChanged
        Me.dtFechaInicial.Enabled = chkFiltrarFecha.Checked
        Me.dtFechaFinal.Enabled = chkFiltrarFecha.Checked
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgLotes.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("No a seleccionado un lote", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Dim filtro As New OC.PredicateExpression

            dgLotes.DataSource = Nothing

            If Not IsNumeric(Me.txtCodigoLote.Text) Then
                If txtDescripcion.Text.Trim <> String.Empty Then
                    filtro.Add(HC.McecatLotesCabFields.NombreLote Mod String.Format("%{0}%", Me.txtDescripcion.Text.Trim))
                End If

                If Me.cmbCorral.SelectedIndex > -1 Then
                    filtro.Add(HC.McecatLotesCabFields.IdCorral = Me.cmbCorral.SelectedValue)
                End If
            Else
                filtro.Add(HC.McecatLotesCabFields.IdLote = CInt(Me.txtCodigoLote.Text))
            End If

            If PreFiltrado IsNot Nothing Then
                filtro.Add(PreFiltrado)
            End If
            Me.LotesCabC.Obtener(filtro)

            If Me.chkFiltrarFecha.Checked AndAlso Not IsNumeric(Me.txtCodigoLote.Text) Then
                For i As Integer = LotesCabC.Count - 1 To 0 Step -1
                    If LotesCabC(i).FechaInicio.Ticks < dtFechaInicial.Value.Date.Ticks OrElse LotesCabC(i).FechaInicio.Date.Ticks > dtFechaFinal.Value.Ticks Then
                        LotesCabC.RemoveAt(i)
                    End If
                Next
            End If
            dgLotes.DataSource = LotesCabC
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtCodigoLote_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoLote.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgLotes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLotes.CellDoubleClick
        If dgLotes.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub frmBusquedaLotes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dgLotes.AutoGenerateColumns = False
        dgLotes.DataSource = Nothing
        Limpiar()
    End Sub
End Class