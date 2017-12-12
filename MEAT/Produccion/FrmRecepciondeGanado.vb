Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class FrmRecepciondeGanado
    Dim WithEvents RecepcionGanado As RecepcionGanadoClass
    Dim Introductores As New ClientesIntroductoresColeccion
    Dim TipoGanado As New TipoGanadoColecttionClass
    Dim Editar As Boolean = False

    Private Sub FrmRecepciondeGanado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.B

                Case Keys.N

                Case Keys.L

                Case Keys.C

                Case Keys.X

                Case Keys.E

                Case Keys.I

                Case Keys.S

            End Select
        End If
    End Sub

    Private Sub FrmRecepciondeGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010000"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Introductores.Obtener(True)
            Me.cmbIntroductor.DisplayMember = "Nombre"
            Me.cmbIntroductor.ValueMember = "Codigo"
            Me.cmbIntroductor.SelectedIndex = -1
            TipoGanado.Obtener()
            Me.CmbTipoGanado.DisplayMember = "Descripcion"
            Me.CmbTipoGanado.ValueMember = "IdTipoGanado"
            Me.CmbTipoGanado.DataSource = TipoGanado
            Me.Limpiar(False)
            Deshabilitar()
        Catch ex As Exception

        End Try
    End Sub

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            Dim Folio As New FoliosClass
            Folio.Codigo = CodigodeFolios.RecepcionGanadoPie
            Folio.A�o = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            'folio para el registro de embarque
            Me.txtLoteRecepcion.Text = Folio.A�o & Folio.Mes & Folio.Consecutivo.ToString("0000")
            RecepcionGanado.LoteRecepcion = Me.txtLoteRecepcion.Text
            RecepcionGanado.FechaRecepcion = Me.dtpFechaRecepcion.Value
            RecepcionGanado.CabezasHembras = Me.txtCabezasHembra.Text
            RecepcionGanado.CabezasMachos = Me.txtCabezasMachos.Text
            RecepcionGanado.CantCabezas = Me.txtCantCabezas.Text
            RecepcionGanado.Conductor = Me.txtConductor.Text
            RecepcionGanado.KilosPrimeraPesada = Me.txtKilos1erpasada.Text
            RecepcionGanado.KilosSegundaPesada = Me.txtKilos2daPasada.Text
            RecepcionGanado.KilosEnviados = Me.txtKilosEnviados.Text
            RecepcionGanado.KilosRecibidos = Me.txtKilosRecibidos.Text
            RecepcionGanado.MultiplesIntroductores = Me.ChkMultiples.Checked
            RecepcionGanado.LoteEngorda = Me.txtLoteEngorda.Text
            RecepcionGanado.Observaciones = Me.txtObservaciones.Text
            RecepcionGanado.Placas = Me.txtPlacas.Text
            RecepcionGanado.Unidad = Me.txtUnidad.Text
            RecepcionGanado.IdCliente = Me.cmbIntroductor.SelectedValue
            RecepcionGanado.Estatus = "V"
            RecepcionGanado.IdUsuario = Controlador.Sesion.Usrndx
            RecepcionGanado.TipoGanado = Me.CmbTipoGanado.SelectedItem
            RecepcionGanado.Func = "I"
            RecepcionGanado.NumOpc = 1
            If Not RecepcionGanado.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try
    End Function

    Private Function Limpiar(ByVal Multiple As Boolean) As Boolean
        If Multiple = True Then
            Me.txtCantCabezas.Text = "0"
            Me.txtCabezasHembra.Clear()
            Me.txtCabezasMachos.Clear()
            Me.txtKilosEnviados.Text = "0"
            Me.txtKilosRecibidos.Text = "0"
            Me.txtKilos1erpasada.Text = Me.txtKilos2daPasada.Text
            Me.txtKilos2daPasada.Text = "0"
            Me.txtLoteEngorda.Text = ""
            Me.txtLoteRecepcion.Text = ""
            Me.txtObservaciones.Text = ""
            Me.cmbIntroductor.Text = ""
            Me.SerialPort.Close()
            Me.dtpFechaRecepcion.Value = Now
            Me.mtb.sbCambiarEstadoBotones("Nuevo")
            RecepcionGanado = New RecepcionGanadoClass
        Else
            Me.txtCantCabezas.Text = "0"
            Me.txtCabezasHembra.Clear()
            Me.txtCabezasMachos.Clear()
            Me.txtConductor.Text = ""
            ' Me.txtImporte.Text = "0"
            Me.txtKilosEnviados.Text = "0"
            Me.txtKilosRecibidos.Text = "0"
            Me.txtKilos1erpasada.Text = "0"
            Me.txtKilos2daPasada.Text = "0"
            Me.txtLoteEngorda.Text = ""
            Me.txtLoteRecepcion.Text = ""
            Me.txtObservaciones.Text = ""
            Me.txtPlacas.Text = ""
            Me.txtUnidad.Text = ""
            Me.cmbIntroductor.SelectedIndex = -1
            Me.cmbIntroductor.Text = "Seleccione un Introductor"
            Me.CmbTipoGanado.SelectedIndex = -1
            Me.CmbTipoGanado.Text = "Seleccione un Tipo de Ganado"
            Me.SerialPort.Close()
            Me.dtpFechaRecepcion.Value = Now
            Me.CmbTipoGanado.SelectedIndex = -1
        End If
        Editar = False
    End Function

    Private Sub Habilitar()
        Me.txtCabezasHembra.Enabled = True
        Me.txtCabezasMachos.Enabled = True
        Me.txtLoteEngorda.Enabled = True
        Me.txtLoteEngorda.Enabled = True
        Me.txtCantCabezas.Enabled = False
        Me.txtKilosEnviados.Enabled = True
        Me.cmbIntroductor.Enabled = True
        Me.txtConductor.Enabled = True
        Me.txtPlacas.Enabled = True
        'Me.txtImporte.Enabled = True
        Me.txtUnidad.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.chkMaquila.Enabled = True
        Me.ChkMultiples.Enabled = True
        Me.CmbTipoGanado.Enabled = True
        Me.txtKilos1erpasada.Enabled = True
        If Editar = True Then Me.txtKilos2daPasada.Enabled = True
        chkBascula.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtCabezasHembra.Enabled = False
        Me.txtCabezasMachos.Enabled = False
        Me.dtpFechaRecepcion.Enabled = False
        Me.txtLoteRecepcion.Enabled = False
        Me.txtUnidad.Enabled = False
        Me.txtLoteEngorda.Enabled = False
        Me.txtCantCabezas.Enabled = False
        Me.txtKilosEnviados.Enabled = False
        Me.cmbIntroductor.Enabled = False
        Me.txtConductor.Enabled = False
        Me.txtPlacas.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtKilos1erpasada.Enabled = False
        Me.txtKilos2daPasada.Enabled = False
        Me.ChkMultiples.Enabled = False
        Me.chkMaquila.Enabled = False
        Me.CmbTipoGanado.Enabled = False
        Me.txtKilos1erpasada.Enabled = False
        Me.txtKilos2daPasada.Enabled = False
        chkBascula.Enabled = False
    End Sub


    Private Function CancelarRecepcion() As Boolean
        Dim Sacrificio As New CC.UsrProdRecepcionGanadoDetCollection
        Sacrificio.GetMulti(HC.UsrProdRecepcionGanadoDetFields.LoteRecepcion = Me.RecepcionGanado.LoteRecepcion)
        If Sacrificio.Count > 0 Then
            MsgBox("La Recepci�n ya est� en Sacrificio, Imposible Cancelar la Recepci�n...", MsgBoxStyle.Exclamation, "Error")
            Return False
        Else
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
            Try
                'cancelacion de recepcion de ganado
                RecepcionGanado.FechaCancelacion = Now
                RecepcionGanado.Estatus = "X"
                RecepcionGanado.IdUsuario = Controlador.Sesion.Usrndx
                RecepcionGanado.Func = "M"
                RecepcionGanado.NumOpc = 1
                Trans.Add(RecepcionGanado.ObtenerEntidad)
                If Not RecepcionGanado.ObtenerEntidad.Save Then
                    Trans.Rollback()
                    Return False
                End If
                Trans.Commit()
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Trans.Rollback()
                Return False
            End Try
        End If
    End Function

    Private Sub Imprimir()
        Try
            Dim Previsualizador As New PreVisualizarForm
            Dim Recepciones As New RecepcionGanadoColeccion
            Recepciones.Add(RecepcionGanado)
            Previsualizador.Reporte = Recepciones.Reporte(Controlador.Sesion.MiUsuario.Usrnom, Controlador.Sesion.MiEmpresa.Empnom, "Producci�n/Recepci�n de Ganado")
            Previsualizador.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub ObtenerKilos1erPesada()
    '    Try
    '        If Not Me.SerialPort.IsOpen Then
    '            Me.SerialPort.Open()
    '            If Me.SerialPort.CDHolding Then
    '                If Me.SerialPort.NewLine = "" Then
    '                    MsgBox("No es posible leer el Peso, Favor de Capturarlo...", MsgBoxStyle.Information, "Aviso")
    '                    Me.txtKilos1erpasada.Enabled = True
    '                Else
    '                    Dim kilos As String = Me.SerialPort.NewLine
    '                    Me.txtKilos1erpasada.Text = CDec(kilos).ToString("N2")
    '                    Me.SerialPort.Close()
    '                End If
    '            Else
    '                MsgBox("La B�scula no se encuentra conectada...")
    '                Me.txtKilos1erpasada.Enabled = True
    '                Me.txtKilos1erpasada.Focus()
    '            End If
    '            Me.SerialPort.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error en el Puerto", MsgBoxStyle.OkOnly, "Aviso")
    '    End Try

    'End Sub

    'Private Sub ObtenerKilos2daPesada()
    '    Try
    '        If Not Me.SerialPort.IsOpen Then
    '            Me.SerialPort.Open()
    '            If Me.SerialPort.CDHolding Then
    '                If Me.SerialPort.NewLine = "" Then
    '                    MsgBox("No es posible leer el Peso, Favor de Capturarlo...", MsgBoxStyle.Information, "Aviso")
    '                    Me.txtKilos2daPasada.Enabled = True
    '                Else
    '                    Dim kilos As String = Me.SerialPort.NewLine
    '                    Me.txtKilos2daPasada.Text = CDec(kilos).ToString("N2")
    '                    Me.SerialPort.Close()
    '                End If
    '            Else
    '                MsgBox("La B�scula no se encuentra conectada...")
    '                Me.txtKilos2daPasada.Enabled = True
    '                Me.txtKilos2daPasada.Focus()
    '            End If
    '            Me.SerialPort.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error en el Puerto", MsgBoxStyle.OkOnly, "Aviso")
    '        Me.txtKilos2daPasada.Enabled = True
    '        Me.txtKilos2daPasada.Focus()
    '    End Try
    'End Sub

    Private Sub ObtenerValores()
        Try
            TipoGanado.Obtener()
            Me.CmbTipoGanado.DisplayMember = "Descripcion"
            Me.CmbTipoGanado.ValueMember = "IdTipoGanado"
            Me.CmbTipoGanado.DataSource = TipoGanado
            Me.CmbTipoGanado.SelectedIndex = -1
            Me.txtLoteRecepcion.Text = Me.RecepcionGanado.LoteRecepcion
            Me.txtLoteEngorda.Text = Me.RecepcionGanado.LoteEngorda
            Me.txtKilosEnviados.Text = Me.RecepcionGanado.KilosEnviados.ToString("N3")
            Me.txtKilosRecibidos.Text = Me.RecepcionGanado.KilosRecibidos.ToString("N3")
            Me.txtKilos1erpasada.Text = Me.RecepcionGanado.KilosPrimeraPesada.ToString("N3")
            Me.txtKilos2daPasada.Text = Me.RecepcionGanado.KilosSegundaPesada.ToString("N3")
            Me.cmbIntroductor.ValueMember = "Codigo"
            Me.cmbIntroductor.DisplayMember = "Nombre"
            Me.cmbIntroductor.DataSource = Introductores
            Me.cmbIntroductor.SelectedIndex = -1
            Me.cmbIntroductor.SelectedValue = Me.RecepcionGanado.IdCliente
            Me.txtUnidad.Text = Me.RecepcionGanado.Unidad
            Me.txtConductor.Text = Me.RecepcionGanado.Conductor
            Me.txtPlacas.Text = Me.RecepcionGanado.Placas
            Me.txtObservaciones.Text = Me.RecepcionGanado.Observaciones
            Me.txtCantCabezas.Text = Me.RecepcionGanado.CantCabezas
            Me.CmbTipoGanado.SelectedValue = Me.RecepcionGanado.TipoGanado.IdTipoGanado
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurri� un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "Toolbar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        If Not CancelarRecepcion() Then
            MessageBox.Show("No se Pudo Cancelar la Recepci�n ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Se cancel� recepci�n de ganado con el folio : " & Me.txtLoteRecepcion.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Limpiar(False)
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Consultas As New FrmConsRecepcionGanado
            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.RecepcionGanado = New ClasesNegocio.RecepcionGanadoClass(Consultas.DgvRecepcionGanado.SelectedRows(0).Cells(Consultas.LoteRecepcion.Index).Value.ToString)
                ObtenerValores()
            Else
                Cancelar = True
            End If
            'Recepciones = RecepcionGanado.Obtener(2, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try

    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Me.RecepcionGanado.Estatus = "X" Then
            MsgBox("No se puede editar la Recepci�n de Animales, se encuentra cancelada", MsgBoxStyle.Exclamation, "Aviso")
            Cancelar = True
            Exit Sub
        End If
        Editar = True
        'Habilitar()
        Me.txtKilos2daPasada.Enabled = True
        If Me.txtKilos2daPasada.Text = "0" Then
            Me.txtKilos2daPasada.Enabled = True
            'Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
            'ObtenerPeso.Obtener()
            'If ObtenerPeso(0).ObtenerPeso = 1 Then
            '    Me.ObtenerKilos2daPesada()
            'Else
            '    Me.txtKilos2daPasada.Enabled = True
            'End If
        End If
        Editar = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Editar = False Then
                If Not Me.txtKilos1erpasada.Text > 0 Then
                    MsgBox("Ingrese la cantidad de Kilos de la primera pesada para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                End If
                If Not Guardar() Then
                    MessageBox.Show("No se Pudo Guardar la Recepci�n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Cancelar = True
                Else
                    MessageBox.Show("Se Guard� Recepci�n con el Folio : " & Me.txtLoteRecepcion.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Me.ChkMultiples.Checked = True Then
                        Me.Limpiar(True)
                        RecepcionGanado = New RecepcionGanadoClass
                        mtb.sbCambiarEstadoBotones("Nuevo")
                        Me.mtb.HabilitarNuevo = True
                    Else
                        Me.Limpiar(False)
                        Deshabilitar()
                    End If
                End If
            Else
                If Not Me.txtKilos2daPasada.Text > 0 Then
                    MsgBox("Ingrese la cantidad de Kilos de la Segunda pesada para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                    Cancelar = True
                    Exit Sub
                End If
                RecepcionGanado.KilosPrimeraPesada = Me.txtKilos1erpasada.Text
                RecepcionGanado.KilosSegundaPesada = Me.txtKilos2daPasada.Text
                RecepcionGanado.KilosRecibidos = RecepcionGanado.KilosPrimeraPesada - RecepcionGanado.KilosSegundaPesada
                If Me.RecepcionGanado.ObtenerEntidad.Save Then
                    MessageBox.Show("Se Guard� Recepci�n ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar(False)
                    Deshabilitar()
                    If RecepcionGanado.KilosSegundaPesada > 0D Then
                        Imprimir()
                    End If
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurri� un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar(False)
        Editar = False
        Habilitar()
        RecepcionGanado = New RecepcionGanadoClass
        Introductores = New ClientesIntroductoresColeccion
        Introductores.Obtener(True)
        Me.cmbIntroductor.ValueMember = "Codigo"
        Me.cmbIntroductor.DisplayMember = "Nombre"
        Me.cmbIntroductor.DataSource = Introductores
        Me.cmbIntroductor.SelectedIndex = -1
        TipoGanado.Obtener(ClasesNegocio.EstatusDatos.VIGENTE)
        Me.CmbTipoGanado.DisplayMember = "Descripcion"
        Me.CmbTipoGanado.ValueMember = "IdTipoGanado"
        Me.CmbTipoGanado.DataSource = TipoGanado
        Me.CmbTipoGanado.SelectedIndex = -1

    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar(False)
        Deshabilitar()
    End Sub
#End Region

#Region "Keypress"
    Private Sub dtpFechaRecepcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaRecepcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLoteEngorda.Focus()
        End If
    End Sub

    Private Sub txtLoteEngorda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoteEngorda.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCabezasMachos.Focus()
        End If
    End Sub

    Private Sub txtCantCabezas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantCabezas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKilosEnviados.Focus()
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbIntroductor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtUnidad.Focus()
        End If
    End Sub

    Private Sub txtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidad.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtConductor.Focus()
        End If
    End Sub

    Private Sub txtConductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConductor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPlacas.Focus()
        End If
    End Sub

    Private Sub txtPlacas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlacas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtKilosEnviados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosEnviados.KeyPress

        If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtKilosEnviados.Text.IndexOf(".", 0) > -1) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.txtKilosEnviados.Text <> "" Then
                If IsNumeric(Me.txtKilosEnviados.Text) Then
                    Me.txtKilosEnviados.Text = CDec(Me.txtKilosEnviados.Text).ToString("N2")
                End If
            End If
            Me.txtKilos1erpasada.Enabled = True
            'Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
            'ObtenerPeso.Obtener()
            'If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
            '    Me.ObtenerKilos1erPesada()
            'Else
            '    Me.txtKilos1erpasada.Enabled = True
            '    Me.txtKilos1erpasada.Focus()
            'End If

        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKilosRecibidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.cmbIntroductor.Focus()
        End If
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKilos1erpasada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilos1erpasada.KeyPress
        If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtKilos1erpasada.Text.IndexOf(".", 0) > -1) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.txtKilos1erpasada.Text <> "" Then
                If IsNumeric(Me.txtKilos1erpasada.Text) Then
                    Me.txtKilos1erpasada.Text = CDec(Me.txtKilos1erpasada.Text).ToString("N2")
                End If
            Else
                Me.txtKilos1erpasada.Text = "0.00"
            End If
            'Me.txtKilos2daPasada.Focus()
            Me.CmbTipoGanado.Focus()

            'Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
            'ObtenerPeso.Obtener()
            'If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
            '    Me.ObtenerKilos2daPasada()
            'Else
            '    Me.txtKilos2daPasada.Enabled = True
            '    Me.txtKilos2daPasada.Focus()
            'End If
        End If
    End Sub

    Private Sub txtKilos2daPasada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtKilos2daPasada.Text.IndexOf(".", 0) > -1) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.txtKilos2daPasada.Text <> "" Then
                If IsNumeric(Me.txtKilos2daPasada.Text) Then
                    Me.txtKilos2daPasada.Text = CDec(Me.txtKilos2daPasada.Text).ToString("N2")
                    Me.txtKilosRecibidos.Text = (CDec(Me.txtKilos1erpasada.Text) - CDec(Me.txtKilos2daPasada.Text)).ToString("N2")
                End If
            Else
                Me.txtKilos2daPasada.Text = "0.00"
            End If
            Me.CmbTipoGanado.Focus()
        End If
    End Sub
#End Region

    Private Sub RecepcionGanado_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles RecepcionGanado.MensajeError
        MessageBox.Show(mensaje)
    End Sub

    Private Sub chkMaquila_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMaquila.CheckedChanged
        If Me.chkMaquila.Checked = True Then
            Me.LblReferenciaOLote.Text = "Referencia Introductor :"
        Else
            Me.LblReferenciaOLote.Text = "Lote de Engorda :"
        End If
    End Sub

    Private Sub txtKilos2daPasada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not Me.txtKilos2daPasada.Text = "" Then
        '    Me.txtKilosRecibidos.Text = (CDec(Me.txtKilos1erpasada.Text) - CDec(Me.txtKilos2daPasada.Text)).ToString("N2")
        'Else
        '    Me.txtKilosRecibidos.Text = (CDec(Me.txtKilos1erpasada.Text) - CDec(0)).ToString("N2")
        'End If

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        If Me.txtKilos1erpasada.Text = "0" Then
    '            Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
    '            ObtenerPeso.Obtener()
    '            If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
    '                Me.ObtenerKilos1erPesada()
    '            Else
    '                Me.txtKilos1erpasada.Enabled = True
    '                Me.txtKilos1erpasada.Focus()
    '            End If
    '        Else
    '            Dim ObtenerPeso As New ClasesNegocio.ConfiguracionProduccionCollectionClass
    '            ObtenerPeso.Obtener()
    '            If ObtenerPeso(0).ObtenerEntidad.ObtenerPeso = True Then
    '                ObtenerKilos2daPesada()
    '            Else
    '                Me.txtKilos2daPasada.Enabled = True
    '                Me.txtKilos2daPasada.Focus()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error en el Puerto", MsgBoxStyle.OkOnly, "Aviso")
    '        Me.txtKilos2daPasada.Enabled = True
    '        Me.txtKilos2daPasada.Focus()
    '    End Try

    'End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar(False)
    End Sub

    Private Sub CmbTipoGanado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbTipoGanado.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbIntroductor.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLoteEngorda.Focus()
        End If
    End Sub

    Private Sub txtCabezasMachos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCabezasMachos.TextChanged
        Dim numCabezasMachos, numCabezasHembras As Integer

        If Me.txtCabezasHembra.Text.Trim.Length = 0 Then
            numCabezasHembras = 0
        Else
            numCabezasHembras = CInt(Me.txtCabezasHembra.Text)
        End If

        If Me.txtCabezasMachos.Text.Trim.Length = 0 Then
            numCabezasMachos = 0
        Else
            numCabezasMachos = CInt(Me.txtCabezasMachos.Text)
        End If

        Me.txtCantCabezas.Text = numCabezasHembras + numCabezasMachos
    End Sub

    Private Sub txtCabezasHembra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCabezasHembra.TextChanged
        Dim numCabezasMachos, numCabezasHembras As Integer

        If Me.txtCabezasHembra.Text.Trim.Length = 0 Then
            numCabezasHembras = 0
        Else
            numCabezasHembras = CInt(Me.txtCabezasHembra.Text)
        End If

        If Me.txtCabezasMachos.Text.Trim.Length = 0 Then
            numCabezasMachos = 0
        Else
            numCabezasMachos = CInt(Me.txtCabezasMachos.Text)
        End If

        Me.txtCantCabezas.Text = numCabezasHembras + numCabezasMachos
    End Sub

    Private Sub txtCabezasMachos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCabezasMachos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCabezasHembra.Focus()
        End If
    End Sub

    Private Sub txtCabezasHembra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCabezasHembra.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKilosEnviados.Focus()
        End If
    End Sub

    Private Sub CmbTipoGanado_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbTipoGanado.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            TipoGanado.Obtener()
        End If
    End Sub

    Private Sub cmbIntroductor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbIntroductor.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Introductores.Obtener(True)
        End If
    End Sub

#Region "Boton Bascula"
    Private Sub chkBascula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBascula.CheckedChanged
        Try
            If Me.chkBascula.Checked Then
                'Me.TextBox1.Text = ClasesNegocio.LecturaBasculaClass.ObtenerPeso(String.Format("<9  41290   355{0}<9  41285   355{0}<9  41280   355{0}<9  41280   355{0}<9  41275   355{0}<9  41275   355{0}<9  41275   355{0}<9  41280   3", vbNewLine), LecturaBasculaClass.TipoLectura.GRAMOS, LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2")
                Me.txtLeerPeso.OpenPort()
                Me.chkBascula.Text = "Lectura de Bascula Activada"
            Else
                Me.txtLeerPeso.ClosePort()
                Me.chkBascula.Text = "Lectura de Bascula Desactivada"
            End If
        Catch UAex As UnauthorizedAccessException
            MsgBox("No se pudo conectar a la bascula, pruebe que este encendida o que no se este usando una lectura de bascula en otra ventana o aplicaci�n", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Lector de Bascula"
    Private Sub txtLeerPeso_SerialDataArrived(ByVal sender As System.Object, ByVal e As wclTextBoxSerial.SerialDataArrivedEventArgs) Handles txtLeerPeso.SerialDataArrived
        'En e.Data esta el grupo de caracteres recibidos desde el puerto serial
        If e.Data.Length >= 50 Then 'Si llegan 25 caracteres procesarlos
            Dim res As String = (ClasesNegocio.LecturaBasculaClass.ObtenerPeso(e.Data.Substring(0, 50), _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS, _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS)).ToString("N2") 'Se divide entre 10 por q la bascula de cortes arroja 3 decimales

            Dim CampoPesada As TextBox = DetectarCampoPesada()
            If CampoPesada IsNot Nothing Then
                CampoPesada.Text = res
            End If
        Else
            e.Handled = True 'Ignora los caracteres
        End If
    End Sub
#End Region

    Private Function DetectarCampoPesada() As TextBox
        If txtKilos1erpasada.Enabled Then
            Return txtKilos1erpasada
        ElseIf txtKilos2daPasada.Enabled Then
            Return txtKilos2daPasada
        End If
        Return Nothing
    End Function
End Class