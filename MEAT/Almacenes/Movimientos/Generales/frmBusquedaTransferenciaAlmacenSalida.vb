Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaTransferenciaAlmacenSalida

    Private m_Transferencia As ClasesNegocio.TransferenciaAlmacenSalidaClass
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

    Public Property TransferenciaSeleccionada() As ClasesNegocio.TransferenciaAlmacenSalidaClass
        Get
            Return m_Transferencia
        End Get
        Set(ByVal value As ClasesNegocio.TransferenciaAlmacenSalidaClass)
            m_Transferencia = value
        End Set
    End Property

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgTransferencias.SelectedRows.Count > 0 Then
            Me.TransferenciaSeleccionada = _
            New TransferenciaAlmacenSalidaClass(Me.dgTransferencias.SelectedRows(0).Cells(Me.clmFolioTransferencia.Index).Value.ToString.Trim)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.TransferenciaSeleccionada = Nothing
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub cmbAlmacenOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacenOrigen.SelectedIndexChanged
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, _
                                ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, _
                                ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            filtro = New OC.PredicateExpression

            Dim vista As New TC.VwBusquedaTransferenciaSalidaTypedView

            If Me.txtFolio.Text.Trim = "" Then
                If Me.cmbAlmacenOrigen.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.IdAlmacenOrigen = CInt(Me.cmbAlmacenOrigen.SelectedValue))
                End If

                If Me.cmbAlmacenDestino.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.IdAlmacenDestino = CInt(Me.cmbAlmacenDestino.SelectedValue))
                End If

                If Not Me.chkCanceladas.Checked OrElse Not Me.chkEnTransito.Checked OrElse _
                    Not Me.chkRecibidas.Checked Then
                    If Me.chkCanceladas.Checked Then
                        If Me.chkEnTransito.Checked Then
                            filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.CANCELADA Or _
                                        HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.EN_TRANSITO)
                        ElseIf Me.chkRecibidas.Checked Then
                            filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.CANCELADA Or _
                                        HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.RECIBIDA)
                        Else
                            filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.CANCELADA)
                        End If
                    ElseIf Me.chkEnTransito.Checked Then
                        If Me.chkRecibidas.Checked Then
                            filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.EN_TRANSITO Or _
                                        HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.RECIBIDA)
                        Else
                            filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.EN_TRANSITO)
                        End If
                    ElseIf Me.chkRecibidas.Checked Then
                        filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.Estatus = _
                                        ClasesNegocio.TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.RECIBIDA)
                    End If
                End If
            Else
                filtro.Add(HC.VwBusquedaTransferenciaSalidaFields.FolioTransferencia Mod String.Format("%{0}%", Me.txtFolio.Text.Trim))
            End If

            vista.Fill(0, Nothing, True, filtro)

            Me.dgTransferencias.AutoGenerateColumns = False
            Me.dgTransferencias.DataSource = vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkEnTransito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnTransito.CheckedChanged
        If Not Me.chkRecibidas.Checked AndAlso Not Me.chkEnTransito.Checked AndAlso Not Me.chkCanceladas.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkEnTransito.Checked = True
            Me.chkRecibidas.Checked = True
        End If
    End Sub

    Private Sub chkRecibidas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecibidas.CheckedChanged
        If Not Me.chkRecibidas.Checked AndAlso Not Me.chkEnTransito.Checked AndAlso Not Me.chkCanceladas.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkEnTransito.Checked = True
            Me.chkRecibidas.Checked = True
        End If
    End Sub

    Private Sub chkCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCanceladas.CheckedChanged
        If Not Me.chkRecibidas.Checked AndAlso Not Me.chkEnTransito.Checked AndAlso Not Me.chkCanceladas.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkEnTransito.Checked = True
            Me.chkRecibidas.Checked = True
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmTransferenciaAlmacenSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ObtenerAlmacenes()
        Limpiar()
    End Sub

    Private Sub ObtenerAlmacenes()
        Me.AlmacenOrigenC.Obtener(CondicionEnum.ACTIVOS)

        For Each alm As AlmacenClass In Me.AlmacenOrigenC
            Me.AlmacenDestinoC.Add(alm)
        Next
    End Sub

    Private Sub Limpiar()
        Me.txtFolio.Clear()
        Me.cmbAlmacenOrigen.SelectedIndex = -1
        Me.cmbAlmacenOrigen.Text = "Seleccione un almacén..."
        Me.cmbAlmacenDestino.SelectedIndex = -1
        Me.cmbAlmacenDestino.Text = "Seleccione un almacén..."

        If Me.ReiniciarEstatus Then
            Me.chkCanceladas.Checked = True
            Me.chkEnTransito.Checked = True
            Me.chkRecibidas.Checked = True
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Cursor = Cursors.WaitCursor

        Try
            Dim transferencias As New TransferenciaAlmacenSalidaCollectionClass

            transferencias.Obtener(filtro)

            transferencias.Reporte(Controlador.Sesion.MiEmpresa.Empnom)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se mostraba el reporte", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class