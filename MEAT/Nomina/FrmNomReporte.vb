Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio
Public Class FrmNomReporte
    Dim Nomina As CN.CalculoNominaClass
    Dim Empleados As New CN.EmpleadosCollectionClass
    Private Sub FrmNomReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "110100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010000"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            Empleados.Obtener()
            Me.cmbEmpleados.DisplayMember = "NombreCompleto"
            Me.cmbEmpleados.ValueMember = "Codigo"
            Me.cmbEmpleados.DataSource = Empleados
            Me.cmbEmpleados.SelectedIndex = -1
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub
    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.txtCodigoEmpleado.Clear()
        Me.cmbEmpleados.SelectedIndex = -1
        Me.txtDescripcion.Clear()
    End Sub
    Private Sub buscar()
        Dim Filtro As New OC.PredicateExpression


        If Me.txtCodigo.Text <> "" Then
            Filtro.Add(HC.VwReporteNominaFields.Folio = Me.txtCodigo.Text)
        ElseIf Me.txtDescripcion.Text <> "" Then
            Filtro.Add(HC.VwReporteNominaFields.Quincena = Me.txtDescripcion.Text)
        Else
            Filtro.Add(HC.VwReporteNominaFields.Nombre = Me.cmbEmpleados.Text)
        End If


        Dim VistaNomina As New TC.VwReporteNominaTypedView
        VistaNomina.Fill(0, Nothing, True, Filtro)

        If VistaNomina.Rows.Count = 0 Then
            MsgBox("No existe información para esta nomina ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub
    Private Sub imprimir()
        Dim Filtro As New OC.PredicateExpression


        If Me.txtCodigo.Text <> "" Then
            Filtro.Add(HC.VwReporteNominaFields.Folio = Me.txtCodigo.Text)
        ElseIf Me.txtDescripcion.Text <> "" Then
            Filtro.Add(HC.VwReporteNominaFields.Quincena = Me.txtDescripcion.Text)
        ElseIf Me.txtCodigoEmpleado.Text <> "" Then
            Filtro.Add(HC.VwReporteNominaFields.Nombre = Me.cmbEmpleados.Text)
        End If


        Dim VistaNomina As New TC.VwReporteNominaTypedView
        VistaNomina.Fill(0, Nothing, True, Filtro)

        If VistaNomina.Rows.Count = 0 Then
            MsgBox("No existe información para esta nomina ", MsgBoxStyle.Information, "")
            Exit Sub
        End If

        Dim NominaDatos As New DataGridView
        NominaDatos.DataSource = VistaNomina

        Dim Reporte As New CN.crReporteNomina
        Reporte.SetDataSource(NominaDatos.DataSource)
        Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        'Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
        Dim VerReporte As New FrmReportes
        VerReporte.CRV.ReportSource = Reporte
        VerReporte.Show()

    End Sub
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        buscar()

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub ComboBoxMejorado1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpleados.SelectedIndexChanged
        If Me.cmbEmpleados.ValueMember = "" Then Exit Sub
        If Me.cmbEmpleados.SelectedIndex = -1 Then Exit Sub
        Me.txtCodigoEmpleado.Text = Me.cmbEmpleados.SelectedValue

    End Sub

    Private Sub txtCodigo_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtCodigo.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim Ventana As New frmBusquedaCalculosdeNomina
                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtCodigo.Text = Ventana.DgvCalculos.CurrentRow.Cells(Ventana.Folio.Index).Value
                    Me.txtDescripcion.Text = Ventana.DgvCalculos.CurrentRow.Cells(Ventana.Descripcion.Index).Value
                    buscar()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtDescripcion_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtDescripcion.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim Ventana As New frmBusquedaCalculosdeNomina
                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtCodigo.Text = Ventana.DgvCalculos.CurrentRow.Cells(Ventana.Folio.Index).Value
                    Me.txtDescripcion.Text = Ventana.DgvCalculos.CurrentRow.Cells(Ventana.Descripcion.Index).Value
                    buscar()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class