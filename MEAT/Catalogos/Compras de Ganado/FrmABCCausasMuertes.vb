Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports System.Windows.Forms
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class FrmABCCausasMuertes
    Dim CausaMuerte As New CausaMuertesClass

#Region "Load"
    Private Sub FrmABCCausasMuertes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.CausaMuerteC.Obtener()

            Dim tbCausas As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbCausas.StateBuscar = "001101101"
            tbCausas.StateLimpiar = ""
            tbCausas.StateCancelar = "100100011"
            tbCausas.StateNuevo = "011010001"
            tbCausas.StateGuardar = "100100011"
            tbCausas.StateBorrar = "100100011"
            tbCausas.StateEditar = "010011001"
            tbCausas.StateImprimir = ""
            tbCausas.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbCausas
            Me.mtb.sbCambiarEstadoBotones("Cancelar")
            mtb.Buttons(1).Visible = False

            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

    'Me.CatTiposdeGanado.GetMulti(HC.McgcatTiposdeGanadoFields.Estatus = "V")
    'Me.mtb.HabilitarBorrar = False
    'Me.mtb.HabilitarBuscar = True
    'Me.mtb.HabilitarCancelar = False
    'Me.mtb.HabilitarEditar = True
    'Me.mtb.HabilitarGuardar = False
    'Me.mtb.HabilitarImprimir = False
    'Me.mtb.HabilitarLimpiar = False
    'Me.mtb.HabilitarNuevo = True
    'Me.mtb.HabilitarSalir = True
#End Region

#Region "Metodos"
    Private Function Guardar() As Boolean
        'Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try

            CausaMuerte.Descripcion = Me.txtDescripcion.Text
            CausaMuerte.DescCorta = Me.txtDescCorta.Text
            CausaMuerte.Observaciones = Me.txtObservaciones.Text
            CausaMuerte.Estatus = 1
            'CausaMuerte.Func = "I"
            'CausaMuerte.NumOpc = 1
            'If Not CausaMuerte.Guardar(Trans) Then
            '    Trans.Rollback()
            '    Return False
            'End If
            Me.txtCodigo.Text = CausaMuerte.IdCausaMuerte
            'Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Trans.Rollback()
            Return False
        End Try
    End Function
    Private Function Limpiar() As Boolean
        Me.lblEstatus.Visible = False
        Me.txtCodigo.Text = 0
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.txtObservaciones.Text = ""
    End Function
    Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.txtObservaciones.Enabled = True
    End Sub
    Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.txtObservaciones.Enabled = False
    End Sub
    Sub PonerDatos()
        Me.txtCodigo.Text = CausaMuerte.IdCausaMuerte
        Me.txtDescripcion.Text = CausaMuerte.Descripcion
        Me.txtDescCorta.Text = CausaMuerte.DescCorta
        Me.txtObservaciones.Text = CausaMuerte.Observaciones
        Me.lblEstatus.Text = CausaMuerte.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub
    Public Function Validar() As Boolean
        Try
            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Especifique la Descripcion de la Causa de Muerte", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDescripcion.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function Buscar() As Boolean
    End Function
    Private Function Imprimir() As Boolean
    End Function
#End Region

#Region "key press"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub
#End Region

#Region "Botones TollBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If CausaMuerte.Estatus = EstatusDatos.CANCELADO Then
                MsgBox("No se puede Cancelar ya ha sido cancelado anteriormente", MessageBoxIcon.Exclamation, "Aviso")
            End If
            CausaMuerte.Borrar()
            MsgBox("La causa de muerte ha sido cancelada", MsgBoxStyle.Information, "Aviso")
            Me.Limpiar()
            Me.CausaMuerteC.Obtener()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        'If Not Buscar() Then
        '    MessageBox.Show("No se encuentran tipos de corrales disponibles", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If CausaMuerte.Estatus = EstatusDatos.CANCELADO Then
            If MessageBox.Show("No se puede editar la Causa de Muerte, se encuentra cancelada ¿Desea activarla?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CausaMuerte.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Me.Habilitar()
                Exit Sub
            Else
                Cancelar = True
            End If
        Else
            Habilitar()
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Me.Validar() Then
                Cancelar = True
                Exit Sub
            Else
                Me.Guardar()
                CausaMuerte.Guardar()
                MsgBox("La causa de muerte ha sido guardada con el código: " & CausaMuerte.IdCausaMuerte, MsgBoxStyle.Information, "Aviso")
                Me.CausaMuerteC.Obtener()
                Me.Limpiar()
                Me.Deshabilitar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            CausaMuerteC.Obtener()
            If CausaMuerteC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatCausaMuertes = CausaMuerteC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(CausaMuerteC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Compras de Ganado\Causas de Muerte")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ninguna Causa de Muerte", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.Habilitar()
        Me.txtDescripcion.Focus()
        CausaMuerte = New CausaMuertesClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

#Region "DataGrid"
    Private Sub dgvTipoGanado_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvTipoGanado.DataError

    End Sub

    Private Sub dgvTipoGanado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvTipoGanado.DoubleClick
        'Try
        '    If Me.dgvTipoGanado.SelectedRows.Count > 0 Then
        '        CausaMuerte = New ClasesNegocio.CausaMuertesClass
        '        If Not CausaMuerte.Obtener(DirectCast(Me.dgvTipoGanado.SelectedRows(0).DataBoundItem, ClasesNegocio.CausaMuertesClass).IdCausaMuerte) Then
        '            MessageBox.Show("No existe La Causa de Muerte", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Else
        '            Me.PonerDatos()
        '            Me.mtb.sbCambiarEstadoBotones("Buscar")
        '            Me.Deshabilitar()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try 
        Try
            If Me.dgvTipoGanado.SelectedRows.Count > 0 Then
                CausaMuerte = New ClasesNegocio.CausaMuertesClass
                If Not CausaMuerte.Obtener(DirectCast(Me.dgvTipoGanado.SelectedRows(0).DataBoundItem, ClasesNegocio.CausaMuertesClass).IdCausaMuerte) Then
                    MessageBox.Show("No existe La Causa de Muerte", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.PonerDatos()
                    Me.mtb.sbCambiarEstadoBotones("Buscar")
                    Deshabilitar()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text.Length > 5 Or e.KeyChar = Chr(13) Then
                Me.CausaMuerteC.Obtener(Me.txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class