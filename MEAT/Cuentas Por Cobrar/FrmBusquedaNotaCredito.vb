Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class FrmBusquedaNotaCredito

#Region "Miembros"
    Dim Estado As FormState
#End Region

#Region "Metodos"
    Public Sub Limpiar()
        ulttxtFolioNota.Clear()
        ulttxtFolFactura.Clear()
        ultdtpFechaInicio.Value = Nothing
        ultdtpFechaFinal.Value = Nothing
        ultcmbCliente.Clear()
        ultchkAplicada.Checked = True
        ultchkCancelada.Checked = True
        ultchkVigente.Checked = True
        ultchkNoAplicable.Checked = True
        ultchkParcialmenteAplicable.Checked = True
    End Sub

    Public Sub Buscar()
        Dim Filtro As New OC.PredicateExpression
        Dim Notas As New CC.NotaCreditoCabCollection()
        Dim Relaciones As New OC.RelationCollection
        Dim Coleccion As New System.ComponentModel.BindingList(Of NotaCreditoCabClass)

        If ulttxtFolioNota.Text.Trim <> String.Empty Then
            Filtro.Add(HC.NotaCreditoCabFields.FolNota Mod String.Format("%{0}%", ulttxtFolioNota.Text.Trim))
        Else
            If ulttxtFolFactura.Text.Trim <> String.Empty Then
                Filtro.Add(HC.NotaCreditoDetFields.FolFactura Mod String.Format("%{0}%", ulttxtFolFactura.Text.Trim))
                Relaciones.Add(EC.NotaCreditoCabEntity.Relations.NotaCreditoDetEntityUsingFolNota)
            End If

            If ultcmbCliente.SelectedItem IsNot Nothing Then
                Filtro.Add(HC.NotaCreditoCabFields.IdCliente = ultcmbCliente.Value)
            End If

            If ultdtpFechaInicio.Value IsNot Nothing Then
                Filtro.Add(HC.NotaCreditoCabFields.FechaNota >= CDate(ultdtpFechaInicio.Value).AddDays(-1))
            End If

            If ultdtpFechaFinal.Value IsNot Nothing Then
                Filtro.Add(HC.NotaCreditoCabFields.FechaNota <= CDate(ultdtpFechaFinal.Value).AddDays(1))
            End If

            If ultchkVigente.Checked Or ultchkAplicada.Checked Or ultchkCancelada.Checked Or ultchkNoAplicable.Checked Or ultchkParcialmenteAplicable.Checked Then
                Dim FiltroEstatus As New OC.PredicateExpression()

                If ultchkVigente.Checked Then
                    FiltroEstatus.AddWithOr(HC.NotaCreditoDetFields.Estatus = NotaCreditoEnum.VIGENTE)

                    If Relaciones.Count = 0 Then
                        Relaciones.Add(EC.NotaCreditoCabEntity.Relations.NotaCreditoDetEntityUsingFolNota)
                    End If
                End If

                If ultchkAplicada.Checked Then
                    FiltroEstatus.AddWithOr(HC.NotaCreditoDetFields.Estatus = NotaCreditoEnum.APLICADA)

                    If Relaciones.Count = 0 Then
                        Relaciones.Add(EC.NotaCreditoCabEntity.Relations.NotaCreditoDetEntityUsingFolNota)
                    End If
                End If

                If ultchkCancelada.Checked Then
                    FiltroEstatus.AddWithOr(HC.NotaCreditoDetFields.Estatus = NotaCreditoEnum.CANCELADA)

                    If Relaciones.Count = 0 Then
                        Relaciones.Add(EC.NotaCreditoCabEntity.Relations.NotaCreditoDetEntityUsingFolNota)
                    End If
                End If

                If ultchkParcialmenteAplicable.Checked Then
                    FiltroEstatus.AddWithOr(HC.NotaCreditoCabFields.Estatus = NotaCreditoEnum.PARCIALMENTE_APLICADA)
                End If

                If ultchkNoAplicable.Checked Then
                    FiltroEstatus.AddWithOr(HC.NotaCreditoDetFields.Estatus = NotaCreditoEnum.NO_APLICABLE)

                    If Relaciones.Count = 0 Then
                        Relaciones.Add(EC.NotaCreditoCabEntity.Relations.NotaCreditoDetEntityUsingFolNota)
                    End If
                End If
                Filtro.Add(FiltroEstatus)
            End If
        End If
        Notas.GetMulti(Filtro, 0, Nothing, Relaciones)

        For Each Nota As EC.NotaCreditoCabEntity In Notas
            Dim NotaCredito As New NotaCreditoCabClass(Nota)
            NotaCredito.IsNew = False
            Coleccion.Add(NotaCredito)
        Next
        Notas.Dispose()
        DgvNotas.DataSource = Coleccion
        'dgvNotaCreditoDetalle.DataSource = Nothing

        'If Coleccion.Count > 0 Then

        'End If
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

    Public Sub Accion(ByVal Accion As String)
        Select Case Accion
            Case "Buscar"
                Estado = FormState.Buscar
                Buscar()
            Case "Limpiar"
                Estado = FormState.Limpiar
                Limpiar()
            Case "Salir"
                Estado = FormState.Salir
                Salir()
        End Select
    End Sub
#End Region

#Region "Eventos"
    Private Sub FrmBusquedaNotaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Clientes As New ClientesIntroductoresColeccion()

        Try
            Limpiar()
            DgvNotas.AutoGenerateColumns = False
            dgvNotaCreditoDetalle.AutoGenerateColumns = False

            ultcmbCliente.DisplayMember = "Nombre"
            ultcmbCliente.ValueMember = "Codigo"
            Clientes.Obtener(CondicionEstatusEnum.ACTIVO)
            ultcmbCliente.DataSource = Clientes
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar, mtb.ClickLimpiar, mtb.ClickSalir
        Utilerias.RunControlException(Me, "Accion", New Object() {e.Button.Text})
    End Sub

    Private Sub ultbtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultbtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ultbtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultbtnAceptar.Click
        If DgvNotas.SelectedRows.Count < 1 Then
            MessageBox.Show("Por favor seleccione las notas de credito")
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub DgvNotas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvNotas.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub SeleccionEstatus_CheckedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultchkVigente.CheckedValueChanged, ultchkCancelada.CheckedValueChanged, ultchkAplicada.CheckedValueChanged
        If Not (ultchkAplicada.Checked Or ultchkCancelada.Checked Or ultchkVigente.Checked Or ultchkNoAplicable.Checked Or ultchkParcialmenteAplicable.Checked) Then
            ultchkAplicada.Checked = True
            ultchkCancelada.Checked = True
            ultchkVigente.Checked = True
            ultchkNoAplicable.Checked = True
            ultchkParcialmenteAplicable.Checked = True
        End If
    End Sub

    Private Sub dgvNotaCreditoDetalle_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvNotaCreditoDetalle.CellFormatting
        If e.ColumnIndex = clmEstatusDetalle.Index Then
            Dim NotaDetalle As EC.NotaCreditoDetEntity = CType(dgvNotaCreditoDetalle.Rows(e.RowIndex).DataBoundItem, EC.NotaCreditoDetEntity)
            dgvNotaCreditoDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CType(NotaDetalle.Estatus, NotaCreditoEnum).ToString().Replace("_", " ")
        End If
    End Sub

    Private Sub DgvNotas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvNotas.SelectionChanged
        If DgvNotas.SelectedRows.Count > 0 Then
            dgvNotaCreditoDetalle.DataSource = CType(DgvNotas.SelectedRows(0).DataBoundItem, NotaCreditoCabClass).Detalle
        End If
    End Sub
#End Region
End Class