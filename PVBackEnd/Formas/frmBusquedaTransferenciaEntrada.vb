Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaTransferenciaEntrada
    Private m_Transferencia As ClasesNegocio.TransferenciaAlmacenEntradaClass
    Private m_ReiniciarEstatus As Boolean
    Private filtro As New OC.PredicateExpression

    Public Property ReiniciarEstatus() As Boolean
        Get
            Return m_ReiniciarEstatus
        End Get
        Set(ByVal value As Boolean)
            m_ReiniciarEstatus = value
        End Set
    End Property

    Public Property TransferenciaSeleccionada() As ClasesNegocio.TransferenciaAlmacenEntradaClass
        Get
            Return m_Transferencia
        End Get
        Set(ByVal value As ClasesNegocio.TransferenciaAlmacenEntradaClass)
            m_Transferencia = value
        End Set
    End Property

    Private Sub Limpiar()
        Me.txtFolio.Clear()
        Me.cmbAlmacenOrigen.SelectedIndex = -1
        Me.cmbAlmacenOrigen.Text = "Seleccione un almacén..."
        Me.cmbAlmacenDestino.SelectedIndex = -1
        Me.cmbAlmacenDestino.Text = "Seleccione un almacén..."

        If Me.ReiniciarEstatus Then
            Me.chkCanceladas.Checked = True
            Me.chkRecibidas.Checked = True
        End If
    End Sub

    Private Sub ObtenerAlmacenes()
        Me.AlmacenOrigenC.Obtener(CondicionEnum.ACTIVOS)

        For Each alm As AlmacenClass In Me.AlmacenOrigenC
            Me.AlmacenDestinoC.Add(alm)
        Next
    End Sub

    Private Sub frmBusquedaTransferenciaEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ObtenerAlmacenes()
        Limpiar()
    End Sub

    Private Sub chkRecibidas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecibidas.CheckedChanged
        If Not Me.chkRecibidas.Checked AndAlso Not Me.chkCanceladas.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkRecibidas.Checked = True
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            filtro = New OC.PredicateExpression
            Dim vista As New TC.VwBusquedaTransferenciaEntradaTypedView

            If Me.txtFolio.Text.Trim = "" Then
                If Me.cmbAlmacenOrigen.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaTransferenciaEntradaFields.IdAlmacenOrigen = CInt(Me.cmbAlmacenOrigen.SelectedValue))
                End If

                If Me.cmbAlmacenDestino.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaTransferenciaEntradaFields.IdAlmacenDestino = CInt(Me.cmbAlmacenDestino.SelectedValue))
                End If

                If Not Me.chkCanceladas.Checked = Me.chkRecibidas.Checked Then
                    If Me.chkCanceladas.Checked Then
                        filtro.Add(HC.VwBusquedaTransferenciaEntradaFields.Estatus = TransferenciaAlmacenEntradaClass.EstatusTransferenciaEntrada.CANCELADA)
                    Else
                        filtro.Add(HC.VwBusquedaTransferenciaEntradaFields.Estatus = TransferenciaAlmacenEntradaClass.EstatusTransferenciaEntrada.VIGENTE)
                    End If
                End If
            Else
                filtro.Add(HC.VwBusquedaTransferenciaEntradaFields.FolioTransferenciaEntrada Mod String.Format("%{0}%", Me.txtFolio.Text.Trim))
            End If

            vista.Fill(0, Nothing, True, filtro)

            Me.dgTransferencias.AutoGenerateColumns = False
            Me.dgTransferencias.DataSource = vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCanceladas.CheckedChanged
        If Not Me.chkRecibidas.Checked AndAlso Not Me.chkCanceladas.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkRecibidas.Checked = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgTransferencias.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.TransferenciaSeleccionada = _
                        New TransferenciaAlmacenEntradaClass(Me.dgTransferencias.SelectedRows(0).Cells(Me.clmFolioTransferenciaEntrada.Index).Value.ToString)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class