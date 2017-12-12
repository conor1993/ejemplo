Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports ORM = IntegraLab.ORM
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmCalcularNomina
    Dim Inicio As Boolean
    Dim CalNominas As New ClasesNegocio.CalculoNominaClass
    Dim calculos As New ClasesNegocio.CalculoNominaColeccion
    Dim ConfigNomina As New ClasesNegocio.NomConfiguracionClass
    Dim ConfigNominaCol As New ORM.CollectionClasses.NomConfiguracionCollection
    Dim DiasLaborables As Integer

    Private Sub FrmCalcularNomina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmCalcularNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            ConfigNominaCol.GetMulti(Nothing)
            If ConfigNominaCol.Count < 1 Then
                MsgBox("Configura nomina, para poder realizar el calculo", MsgBoxStyle.Information, "AVISO")
            End If

            ConfigNomina.Obtener(1)
            Me.txtMesComercial.Text = ConfigNomina.MesComercial
            Me.txtSmRegionA.Text = ConfigNomina.SalarioMinimoDF
            Me.txtSmRegionC.Text = ConfigNomina.SalarioMinimoSinaloa
            Me.DiasLaborables = ConfigNomina.DiasdeTrabajo
            Limpiar()
            Deshabilitar()

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtFolio.Clear()
        Me.dtpFecha.Value = Now
        Me.txtDescripcion.Clear()
        'Me.txtSmRegionA.Clear()
        'Me.txtSmRegionC.Clear()
        'Me.txtMesComercial.Clear()
        Me.dgvEmpleados.Rows.Clear()
    End Sub

    Private Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        'Me.txtSmRegionA.Enabled = True
        'Me.txtSmRegionC.Enabled = True
        'Me.txtMesComercial.Enabled = True
        Me.dgvEmpleados.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtSmRegionA.Enabled = False
        Me.txtSmRegionC.Enabled = False
        Me.txtMesComercial.Enabled = False
        Me.dgvEmpleados.Enabled = False
    End Sub

    Private Function Guardar() As Boolean
        Dim trans As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "CalculoNomina")
        Try
            Dim folioC As New ClasesNegocio.FoliosClass
            folioC.Codigo = CodigodeFolios.CalculodeNomina
            folioC.Año = Now.Year
            folioC.Mes = Now.ToString("MM")
            'trans.Add(folioC)
            If Not folioC.Guardar(trans) Then
                MessageBox.Show("Error al generar folio", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                trans.Rollback()
                Return False
            Else

                Dim folio As String = "NOM" & folioC.Año.Substring(2) & folioC.Mes & folioC.Consecutivo.ToString("000")
                For i As Integer = 0 To Me.EmpleadoCol.Count - 1
                    IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.CalculodeNomina(Me.EmpleadoCol(i).Codigo _
                    , Me.dgvEmpleados.Rows(i).Cells("clmDiasTrabajados").Value, Me.dgvEmpleados.Rows(i).Cells("clmHRD").Value, Me.dgvEmpleados.Rows(i).Cells("clmHRT").Value _
                    , Me.dgvEmpleados.Rows(i).Cells("clmComisiones").Value, Me.txtSmRegionC.Text, Me.txtMesComercial.Text, Me.txtSmRegionA.Text, folio, Me.dtpFecha.Value, Me.txtDescripcion.Text, Me.dgvEmpleados.Rows(i).Cells("clmPrestamos").Value, trans)
                Next
            End If
            trans.Commit()
            Return True
        Catch ex As Exception
            trans.Rollback()
            Return False
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error al intentar Guardar.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Function Validar() As Boolean
        Try
            Dim Imss As New ORM.CollectionClasses.NomImssinfonavitCollection
            Dim ISR As New ORM.CollectionClasses.NomIsrCollection
            Dim Subsidio As New ORM.CollectionClasses.NomSubsidioEmpleoCollection
            Imss.GetMulti(Nothing)
            ISR.GetMulti(Nothing)
            Subsidio.GetMulti(Nothing)
            If Imss.Count < 1 Then
                MsgBox("Agregue información a la configuración de Imss.", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            If ISR.Count < 1 Then
                MsgBox("Agregue información al ISR.", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            If Subsidio.Count < 1 Then
                MsgBox("Agregue información al Subsidio del Empleo.", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Sub PonerDatos()
        'Me.dtpFecha.Value = calculos.
        Me.txtDescripcion.Clear()
        Me.txtSmRegionA.Clear()
        Me.txtSmRegionC.Clear()
        Me.txtMesComercial.Clear()
        Me.dgvEmpleados.Rows.Clear()
    End Sub

    Private Sub Buscar()
        Try
            Dim Filtro As New OC.PredicateExpression


            If Me.txtFolio.Text <> "" Then
                Filtro.Add(HC.VwReporteNominaFields.Folio = Me.txtFolio.Text)
            ElseIf Me.txtDescripcion.Text <> "" Then
                Filtro.Add(HC.VwReporteNominaFields.Quincena = Me.txtDescripcion.Text)
            End If


            Dim VistaNomina As New TC.VwReporteNominaTypedView
            VistaNomina.Fill(0, Nothing, True, Filtro)

            If VistaNomina.Rows.Count = 0 Then
                MsgBox("No existe información para esta nomina ", MsgBoxStyle.Information, "")
                Exit Sub
            End If

            Me.dgvEmpleados.AutoGenerateColumns = False
            Me.dgvEmpleados.DataSource = VistaNomina

            Me.clmCodigo.DataPropertyName = "IdEmpleado"
            Me.clmNombre.DataPropertyName = "Nombre"
            Me.clmComisiones.DataPropertyName = "Comisiones"
            Me.clmDiasTrabajados.DataPropertyName = "DiasTrabajados"
            Me.clmFactor.DataPropertyName = "Factor"
            Me.clmHRD.DataPropertyName = "HorasExtrasDobles"
            Me.clmHRT.DataPropertyName = "HorasExtrasTriples"
            Me.clmPrestamos.DataPropertyName = "Prestamos"
            Me.clmSalario.DataPropertyName = "Sueldodiario"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "MEAToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar

    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()

    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Validar() Then
                If Guardar() Then
                    MsgBox("El Cálculo de Nómina ha sido guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Deshabilitar()
                Else
                    MsgBox("El Cálculo de Nómina no pudo ser guardado.", MsgBoxStyle.Critical, "Error")
                    Limpiar()
                    Deshabilitar()
                End If
            Else
                Cancelar = True
            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error al intentar Guardar.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar

    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Me.EmpleadoCol.ObtenerEmpleados(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
        For i As Integer = 0 To Me.dgvEmpleados.Rows.Count - 1
            Me.dgvEmpleados.Rows(i).Cells(Me.clmComisiones.Index).Value = 0
            Me.dgvEmpleados.Rows(i).Cells(Me.clmDiasTrabajados.Index).Value = Me.DiasLaborables
            Me.dgvEmpleados.Rows(i).Cells(Me.clmHRD.Index).Value = 0
            Me.dgvEmpleados.Rows(i).Cells(Me.clmHRT.Index).Value = 0
            Me.dgvEmpleados.Rows(i).Cells(Me.clmPrestamos.Index).Value = 0
        Next


    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "Validar TextBox"
    Private Sub txtSmRegionA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSmRegionA.KeyPress
        If (Me.txtSmRegionA.Text <> "") Then
            If Not IsNumeric(Me.txtSmRegionA.Text) Then
                MsgBox("Teclee una cantidad válida.", MsgBoxStyle.Exclamation, "Aviso")
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtSmRegionC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSmRegionC.KeyPress
        If (Me.txtSmRegionC.Text <> "") Then
            If Not IsNumeric(Me.txtSmRegionC.Text) Then
                MsgBox("Teclee una cantidad válida.", MsgBoxStyle.Exclamation, "Aviso")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMesComercial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMesComercial.KeyPress
        If (Me.txtMesComercial.Text <> "") Then
            If Not IsNumeric(Me.txtMesComercial.Text) Then
                MsgBox("Teclee una cantidad válida.", MsgBoxStyle.Exclamation, "Aviso")
                e.Handled = True
            End If
        End If
    End Sub
#End Region

    Private Sub dgvEmpleados_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellEndEdit
        If e.ColumnIndex > 1 And e.ColumnIndex < 7 Then
            Select Case (e.ColumnIndex)

                Case 2
                    If Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmDiasTrabajados").Value = "" Then
                        Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmDiasTrabajados").Value = 0
                    Else
                        If Not IsNumeric(Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmDiasTrabajados").Value) Then
                            MsgBox("Teclee una cantidad válida.", MsgBoxStyle.Critical, "Error")
                            Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmDiasTrabajados").Value = 0
                        End If
                    End If
                Case 3
                    If Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRD").Value = "" Then
                        Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRD").Value = 0
                    Else
                        If Not IsNumeric(Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRD").Value) Then
                            MsgBox("Teclee número de horas válida.", MsgBoxStyle.Critical, "Error")
                            Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRD").Value = 0
                        End If
                    End If
                Case 4
                    If Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRT").Value = "" Then
                        Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRT").Value = 0
                    Else
                        If Not IsNumeric(Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRT").Value) Then
                            MsgBox("Teclee número de horas válida.", MsgBoxStyle.Critical, "Error")
                            Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmHRT").Value = 0
                        End If
                    End If
                Case 5
                    If Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmComisiones").Value = "" Then
                        Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmComisiones").Value = 0
                    Else
                        If Not IsNumeric(Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmComisiones").Value) Then
                            MsgBox("Teclee una cantidad válida.", MsgBoxStyle.Critical, "Error")
                            Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmComisiones").Value = 0
                        End If
                    End If
                Case 6
                    If Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmPrestamos").Value = "" Then
                        Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmPrestamos").Value = 0
                    Else
                        If Not IsNumeric(Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmPrestamos").Value) Then
                            MsgBox("Teclee número de horas válida.", MsgBoxStyle.Critical, "Error")
                            Me.dgvEmpleados.Rows(e.RowIndex).Cells("clmPrestamos").Value = 0
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Inicio = False
            Dim Ventana As New frmBusquedaCalculosdeNomina
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                'CalNominas = New ClasesNegocio.CalculoNominaClass
                Me.txtFolio.Text = Ventana.DgvCalculos.CurrentRow.Cells(Ventana.Folio.Index).Value
                Me.txtDescripcion.Text = Ventana.DgvCalculos.CurrentRow.Cells(Ventana.Descripcion.Index).Value
                buscar()

                '                Me.PonerDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub
End Class