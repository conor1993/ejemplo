Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Windows.Forms


Public Class FrmABCConceptoGastosTransportes
    Dim ConceptoGasto As New ConceptoGastosTransporteClass

#Region "Load"
    Private Sub FrmABCConceptoGastosTransportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ConceptoGastoC.Obtener()
            Dim tbConceptoGasto As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbConceptoGasto.StateBuscar = "001101101"
            tbConceptoGasto.StateLimpiar = ""
            tbConceptoGasto.StateCancelar = "100100011"
            tbConceptoGasto.StateNuevo = "011010001"
            tbConceptoGasto.StateGuardar = "100100011"
            tbConceptoGasto.StateBorrar = "100100011"
            tbConceptoGasto.StateEditar = "010011001"
            tbConceptoGasto.StateImprimir = ""
            tbConceptoGasto.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbconceptogasto
            Me.mtb.sbCambiarEstadoBotones("Cancelar")
            mtb.Buttons(1).Visible = False

            Me.Limpiar()
            Me.Deshabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub
#End Region

#Region "Metodos"

    Private Function Guardar() As Boolean
        Try
            ConceptoGasto.Descripcion = Me.txtDescripcion.Text
            ConceptoGasto.DescCorta = Me.txtDescCorta.Text
            ConceptoGasto.AplicaIVA = Me.chkIVA.Checked
            ConceptoGasto.PorcentajeIVA = Decimal.Parse(Me.txtPorcentaje.Text)
            ConceptoGasto.Observaciones = Me.txtObservaciones.Text
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Function Limpiar() As Boolean
        Me.txtCodigo.Text = "0"
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.txtObservaciones.Text = ""
        Me.lblEstatus.Visible = False
        Me.txtPorcentaje.Text = "0"
        Me.chkIVA.Checked = False
    End Function
    Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.txtDescCorta.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.chkIVA.Enabled = True
        Me.btnCtaCont.Enabled = True
    End Sub
    Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtDescCorta.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.chkIVA.Enabled = False
        Me.txtPorcentaje.Enabled = False
        Me.btnCtaCont.Enabled = False
    End Sub
    Sub PonerDatos()
        Me.txtCodigo.Text = ConceptoGasto.IdConceptoGasto.ToString
        Me.txtDescripcion.Text = ConceptoGasto.Descripcion
        Me.txtDescCorta.Text = ConceptoGasto.DescCorta
        Me.txtObservaciones.Text = ConceptoGasto.Observaciones
        Me.chkIVA.Checked = ConceptoGasto.AplicaIVA
        Me.txtPorcentaje.Text = ConceptoGasto.PorcentajeIVA.ToString
        Me.lblEstatus.Text = ConceptoGasto.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub
    Private Function Buscar() As Boolean
    End Function
    Private Function Imprimir() As Boolean
    End Function
    Public Function Validar() As Boolean
        Try
            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Especifique la Desctpcion del Conepto de Gasto", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtDescCorta.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Key Press"
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

    Private Sub chkIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIVA.CheckedChanged
        If Me.chkIVA.Checked = True Then
            Me.txtPorcentaje.Enabled = True
        Else
            Me.txtPorcentaje.Enabled = False
        End If
    End Sub
#End Region

#Region "Botones TollBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If ConceptoGasto.Estatus = EstatusEnum.INACTIVO Then
                MsgBox("No se puede Cancelar este Concepto de Gasto ya ha sido cancelado anteriormente", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
            Me.ConceptoGasto.Borrar()
            MsgBox("El concepto de Gasto de tranporte ha sido cancelado", MsgBoxStyle.Information, "Aviso")
            Me.Limpiar()
            Me.ConceptoGastoC.Obtener()
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        'If Not Buscar() Then
        '    MessageBox.Show("No se encuentran tipos de corrales disponibles", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Limpiar()
        Me.Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If ConceptoGasto.Estatus = EstatusEnum.INACTIVO Then
            If MessageBox.Show("No se puede editar el Concepto de Gasto de Transporte se encuentra inactivo ¿Desea activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ConceptoGasto.Estatus = EstatusEnum.ACTIVO
                Habilitar()
                Exit Sub
            Else
                Cancelar = True
                Exit Sub
            End If
        End If
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If
            Me.Guardar()
            ConceptoGasto.Guardar()
            MsgBox("El Concepto de gasto de transporte ha sido guardado", MsgBoxStyle.Information, "Aviso")
            Me.Limpiar()
            Deshabilitar()
            Me.ConceptoGastoC.Obtener()
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            ConceptoGastoC.Obtener()
            If ConceptoGastoC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatConceptoGastosTransporte = ConceptoGastoC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(ConceptoGastoC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Compras de Ganado\Concepto Gastos de Transporte ")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Concepto Gastos de Transporte  ", MsgBoxStyle.Information, "No hay Informacion")
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
        Habilitar()
        txtDescripcion.Focus()
        ConceptoGasto = New ClasesNegocio.ConceptoGastosTransporteClass
        'Me.mtb.HabilitarBorrar = False
        'Me.mtb.HabilitarBuscar = True
        'Me.mtb.HabilitarCancelar = False
        'Me.mtb.HabilitarEditar = False
        'Me.mtb.HabilitarGuardar = True
        'Me.mtb.HabilitarImprimir = False
        'Me.mtb.HabilitarLimpiar = True
        'Me.mtb.HabilitarNuevo = False
        'Me.mtb.HabilitarSalir = True
        'Me.GroupBox1.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

#Region "DataGrid"

    Private Sub dgvConceptoGasto_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvConceptoGasto.DataError
    End Sub
    Private Sub dgvConceptoGasto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvConceptoGasto.DoubleClick
        Try
            If Me.dgvConceptoGasto.SelectedRows.Count > 0 Then
                ConceptoGasto = New ClasesNegocio.ConceptoGastosTransporteClass
                If Not ConceptoGasto.Obtener(DirectCast(Me.dgvConceptoGasto.SelectedRows(0).DataBoundItem, ClasesNegocio.ConceptoGastosTransporteClass).IdConceptoGasto) Then
                    MsgBox("No existe el Concepto de Gasto", MsgBoxStyle.Exclamation, "MEAT")
                Else
                    Me.PonerDatos()
                    Me.mtb.sbCambiarEstadoBotones("Buscar")
                    Me.Deshabilitar()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub chkIVA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkIVA.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPorcentaje.Focus()
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text.Length > 4 Or e.KeyChar = Chr(13) Then
                Me.ConceptoGastoC.Obtener(txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class