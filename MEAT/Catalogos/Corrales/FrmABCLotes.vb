Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmABCLotes

#Region "Miembros"

    Dim Lote As New LoteClass
    Dim LotesC As New ClasesNegocio.LoteCollectionClass

#End Region

#Region "Form"

    Private Sub FrmABCLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "101101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001010001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.Limpiar()
            Me.Modo(False)
            Me.dgCabezas.AutoGenerateColumns = False
            Me.dgDetallesTipoGanado.AutoGenerateColumns = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmABCLotes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Controlador.Configuracion.ActualizarEngorda()

            If Controlador.Configuracion.Engorda.GDP = 0D Then
                MsgBox("Primero debe establecer el GDP en la configuración de engorda", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub LlenarComboCorrales()
        Dim Filtro As OC.PredicateExpression
        Dim _in_ As OC.FieldCompareRangePredicate = Nothing
        Dim Lotes As CC.McecatLotesCabCollection
        Dim ListaLotes As New List(Of String)

        Lotes = New CC.McecatLotesCabCollection
        Lotes.GetMulti(HC.McecatLotesCabFields.Estatus = 1)

        For Each lote As EC.McecatLotesCabEntity In Lotes
            ListaLotes.Add(lote.IdCorral)
        Next

        Filtro = New OC.PredicateExpression(HC.McecatCorralesCabFields.Estatus = 1 And HC.McecatCorralesCabFields.TipoCorral <> 3)

        If ListaLotes.Count > 0 Then
            _in_ = New OC.FieldCompareRangePredicate(HC.McecatCorralesCabFields.IdCorral, True, ListaLotes)
            Filtro.Add(_in_)
        End If

        Me.CorralesC.Obtener(Filtro, Nothing)
        Me.cmbCorral.SelectedIndex = -1
        Me.cmbCorral.Text = "Seleccione un corral..."
    End Sub

    Private Sub ObtenerDatos()
        Lote.Descripcion = Me.txtDescripcion.Text.Trim
        Lote.DescCorta = Me.txtDescCorta.Text.Trim
        Lote.IdCorral = Me.cmbCorral.SelectedValue.ToString
        Lote.Observaciones = Me.txtObservaciones.Text.Trim
        Lote.PesoEstimado = CDec(Me.txtPesoProyectado.Text)
        Lote.GDPINI = CDec(Me.txtGDP.Text)
        Lote.FechaCierre = Me.dtpFechaSal.Value
        Lote.CantSemReimplante = Decimal.ToInt32(nudSemanasReimplante.Value)
        Lote.ObservacionesReimplante = txtObserbacionesDesparasitacion.Text
    End Sub

    Private Sub PonerDatos()
        Dim Cabezas As Integer = 0, KilosEntrada As Decimal = 0D, KilosSalida As Decimal = 0D, GananciaKilos As Decimal = 0D

        Me.txtCodigo.Text = Lote.IdLote
        Me.txtDescripcion.Text = Lote.Descripcion
        Me.txtDescCorta.Text = Lote.DescCorta
        Me.cmbCorral.SelectedValue = Lote.IdCorral
        Me.txtObservaciones.Text = Lote.Observaciones
        Me.txtGDP.Text = Lote.GDPINI.ToString("N3")
        Me.txtPesoProyectado.Text = Lote.PesoEstimado.ToString("N3")
        Me.lblEstatus.Text = Lote.Estatus
        Me.lblEstatus.Visible = True

        Me.dtpFechaInicio.Value = Lote.FechaInicio
        Me.dtpFechaSal.Value = Lote.FechaEstimadaDeSalida
        Me.txtDiasEngorda.Text = DateDiff(DateInterval.Day, Lote.FechaInicio, Lote.FechaCierre)
        Me.txtDiasLote.Text = DateDiff(DateInterval.Day, Lote.FechaInicio, Now)
        Me.txtPesoActualTotal.Text = Lote.TotalPesoProyectado.ToString("N2")
        Me.txtPesoActualxCabeza.Text = Lote.PesoProyectadoxCbz.ToString("N2")

        Me.txtObserbacionesDesparasitacion.Text = Lote.ObservacionesReimplante
        Me.nudSemanasReimplante.Value = Decimal.ToInt32(Lote.CantSemReimplante)
        Me.dtpFechaReimplante.Value = Lote.FechaReimplante
        Me.dgCabezas.DataSource = Lote.Detalles
        Me.dgDetallesTipoGanado.DataSource = Lote.DetallesPorTiposGanado

        For Each Fila As dsDetalleTiposGanado.DataTable1Row In Lote.DetallesPorTiposGanado
            Cabezas += Fila.Cabezas
            KilosEntrada += Fila.KilosEntrada
            KilosSalida += Fila.KilosSalida
            GananciaKilos += Fila.GananciaKilos
        Next
        txtTotalCabezas.Text = Cabezas
        txtTotalKilosEntrada.Text = KilosEntrada.ToString("N2")
        txtTotalKilosSalida.Text = KilosSalida.ToString("N2")
        txtTotalKilosGanancia.Text = GananciaKilos.ToString("N2")
    End Sub

    Private Function Validar() As Boolean
        Dim LotesRepetidos As CC.McecatLotesCabCollection = Nothing

        If Me.txtDescripcion.Text.Trim = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Aviso")
            Me.txtDescripcion.Focus()
            Return False
        End If

        If Me.txtDescCorta.Text.Trim = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Aviso")
            Me.txtDescCorta.Focus()
            Return False
        End If

        If Me.cmbCorral.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un corral", MsgBoxStyle.Exclamation, "Aviso")
            Me.cmbCorral.Focus()
            Return False
        End If

        If Me.txtGDP.Text.Trim = "" OrElse Not IsNumeric(Me.txtGDP.Text) OrElse CDec(Me.txtGDP.Text) = 0D Then
            MsgBox("Debe ingresar una ganancia diaria de peso", MsgBoxStyle.Exclamation, "Aviso")
            Me.txtGDP.Focus()
            Return False
        End If

        If Me.txtPesoProyectado.Text.Trim = "" OrElse Not IsNumeric(Me.txtPesoProyectado.Text) OrElse CDec(Me.txtPesoProyectado.Text) = 0D Then
            MsgBox("Debe ingresar un peso proyectado", MsgBoxStyle.Exclamation, "Aviso")
            Me.txtPesoProyectado.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function Limpiar() As Boolean
        Me.txtCodigo.Clear()
        Me.txtDescCorta.Clear()
        Me.txtDescripcion.Clear()
        Me.txtDiasEngorda.Clear()
        Me.txtDiasLote.Clear()
        Me.txtGDP.Clear()
        Me.txtObserbacionesDesparasitacion.Clear()
        Me.txtObservaciones.Clear()
        Me.txtPesoActualTotal.Clear()
        Me.txtPesoActualxCabeza.Clear()
        Me.nudSemanasReimplante.Value = 0
        Me.txtTotalCabezas.Clear()
        Me.txtTotalKilosEntrada.Clear()
        Me.txtTotalKilosSalida.Clear()
        Me.txtPesoProyectado.Clear()
        Me.cmbCorral.SelectedIndex = -1
        Me.cmbCorral.Text = "Seleccione un corral..."
        Me.dtpFechaInicio.Value = Now
        Me.dtpFechaReimplante.Value = Now
        Me.dtpFechaSal.Value = Now
        Me.dgDetallesTipoGanado.DataSource = Nothing
        Me.btnFormulas.Enabled = False
        Me.lblEstatus.Visible = False
    End Function

    Private Sub Modo(ByVal Edicion As Boolean)
        Me.txtDescCorta.Enabled = Edicion
        Me.txtDescripcion.Enabled = Edicion
        Me.txtObservaciones.Enabled = Edicion
        Me.cmbCorral.Enabled = Edicion
        Me.txtPesoProyectado.Enabled = Edicion
        Me.txtGDP.Enabled = Edicion
        Me.nudSemanasReimplante.Enabled = Edicion
        Me.txtObserbacionesDesparasitacion.Enabled = Edicion
    End Sub

    Private Function Buscar() As Boolean
        Try
            Dim ventana As New frmBusquedaLotes

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Lote = ventana.dgLotes.SelectedRows(0).DataBoundItem
                Me.CorralesC.Obtener(HC.McecatCorralesCabFields.TipoCorral <> 3)
                Me.PonerDatos()
                Me.btnFormulas.Enabled = True
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

#Region "Eventos"


#Region "ToolBar"

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Cancelar = Not Buscar()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Me.Modo(False)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            Me.Modo(True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Public Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Catalogo Lote")

        If Not Me.Validar Then
            Return False
        End If

        Me.ObtenerDatos()

        If Lote.Entidad.IsNew Then
            Lote.AcumCabMuerte = 0D
            Lote.AcumEntCab = 0D
            Lote.AcumEntImpte = 0D
            Lote.AcumEntKilos = 0D
            Lote.AcumImpteAlim = 0D
            Lote.AcumImpteMedic = 0D
            Lote.AcumImpteMuerte = 0D
            Lote.AcumKilosAlim = 0D
            Lote.AcumKilosMuerte = 0D
            Lote.AcumSalCab = 0D
            Lote.AcumSalKilos = 0D
            Lote.CantSemReimplante = 0D
            Lote.Estatus = EstatusEnum.ACTIVO
            Lote.ObservacionesReimplante = ""
            Lote.SaldoCabezas = 0D
            Lote.SaldoCostoInd = 0D
            Lote.SaldoImpte = 0D
            Lote.SaldoImpteAlim = 0D
            Lote.SaldoimpteMed = 0D
            Lote.SaldoKilos = 0D
            Lote.SaldoKilosAlim = 0D

            If Lote.Guardar(Trans) Then
                MsgBox("Lote guardado con el Codigo " & Lote.IdLote, MsgBoxStyle.Information, "Aviso")
                Me.Limpiar()
                Me.Modo(False)
            Else
                Return False
            End If
        Else
            If Lote.Guardar(Trans) Then
                MsgBox("Lote guardado con el Codigo " & Lote.IdLote, MsgBoxStyle.Information, "Aviso")
                Me.Limpiar()
                Me.Modo(False)
            Else
                Return False
            End If
        End If
        Trans.Commit()
        Return True
    End Function

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Resultado As Object = Utilerias.RunControlException(Me, "Guardar")

        If Resultado Is Nothing OrElse Not CType(Resultado, Boolean) Then
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            LotesC.Obtener(CondicionEstatusEnum.TODOS)
            If LotesC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.RptCatLotes = LotesC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(LotesC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Engorda\Lotes")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se encontro ningun Lote", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            If Controlador.Configuracion.Engorda.GDP = 0D Then
                MsgBox("Debe registrar una configuración de engorda. Menu Engorda/Configuración", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If
            Me.Lote = New LoteClass
            Me.LlenarComboCorrales()
            Me.Limpiar()
            Me.Modo(True)
            Me.txtGDP.Text = Controlador.Configuracion.Engorda.GDP.ToString("N3")
            txtDescripcion.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

#Region "TextBox"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescCorta.Focus()
        End If
    End Sub

    Private Sub txtGDP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGDP.TextChanged
        Try
            Dim gdp As Decimal
            Dim pesoProyectado As Decimal
            Dim numDias As Integer
            Dim res As Decimal

            If IsNumeric(Me.txtGDP.Text) AndAlso IsNumeric(Me.txtPesoProyectado.Text) Then
                gdp = CDec(Me.txtGDP.Text)
                pesoProyectado = CDec(Me.txtPesoProyectado.Text)

                If pesoProyectado = 0D OrElse gdp = 0D Then
                    Me.dtpFechaSal.Value = Me.dtpFechaInicio.Value
                    Exit Sub
                End If

                res = pesoProyectado / gdp

                If res - Math.Truncate(res) = 0D Then
                    numDias = CInt(res)
                Else
                    numDias = CInt(Math.Truncate(res)) + 1
                End If

                Me.dtpFechaSal.Value = Me.dtpFechaInicio.Value.AddDays(numDias)
            Else
                Me.dtpFechaSal.Value = Me.dtpFechaInicio.Value
            End If
        Catch es As ArithmeticException
            MsgBox("Ocurrio un error al calcular la fecha de salida estimada", MsgBoxStyle.Critical, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtPesoProyectado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesoProyectado.TextChanged
        Try
            Dim gdp As Decimal
            Dim pesoProyectado As Decimal
            Dim numDias As Integer
            Dim res As Decimal

            If IsNumeric(Me.txtGDP.Text) AndAlso IsNumeric(Me.txtPesoProyectado.Text) Then
                gdp = CDec(Me.txtGDP.Text)
                pesoProyectado = CDec(Me.txtPesoProyectado.Text)

                If pesoProyectado = 0D OrElse gdp = 0D Then
                    Me.dtpFechaSal.Value = Me.dtpFechaInicio.Value
                    Exit Sub
                End If

                res = pesoProyectado / gdp

                If res - Math.Truncate(res) = 0D Then
                    numDias = CInt(res)
                Else
                    numDias = CInt(Math.Truncate(res)) + 1
                End If

                Me.dtpFechaSal.Value = Me.dtpFechaInicio.Value.AddDays(numDias)
            Else
                Me.dtpFechaSal.Value = Me.dtpFechaInicio.Value
            End If
        Catch es As ArithmeticException
            MsgBox("Ocurrio un error al calcular la fecha de salida estimada", MsgBoxStyle.Critical, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtSemanasReimplante_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Utilerias.ValidarEntradaNumerosEnteros(sender, e)
    End Sub

    Private Sub txtGDPytxtPesoProyectado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGDP.KeyPress, txtPesoProyectado.KeyPress
        Utilerias.ValidarEntradaNumerosDecimales(sender, e)
    End Sub

#End Region

#Region "ComboBox"
    Private Sub cmbCorral_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCorral.KeyDown
        If e.KeyCode = Keys.F12 Then
            LlenarComboCorrales()
        End If
    End Sub

    Private Sub cmbCorral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCorral.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpFechaInicio.Focus()
        End If
    End Sub
#End Region

#Region "DateTimePiker"
    Private Sub dtpFechaInicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaInicio.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpFechaSal.Focus()
        End If
    End Sub
#End Region

    Private Sub btnFormulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormulas.Click
        Dim ProgramacionFormulas As New frmProgramacionFormulas(Lote, txtDescripcion.Enabled)
        ProgramacionFormulas.ShowDialog()
    End Sub

    Private Sub nudSemanasReimplante_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSemanasReimplante.ValueChanged
        Try
            If Me.nudSemanasReimplante.Value > 0 Then
                Me.dtpFechaReimplante.Value = Me.dtpFechaInicio.Value.AddDays(Me.nudSemanasReimplante.Value * 7)
            Else
                Me.dtpFechaReimplante.Value = Me.dtpFechaInicio.Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

End Class