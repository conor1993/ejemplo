Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class frmConfiguracionEngorda

#Region "Metodos"

    Private Sub PonerDatos()
        Me.txtGDP.Text = Controlador.Configuracion.Engorda.GDP

        If Controlador.Configuracion.Engorda.IdTipoAlmacenRolado.HasValue Then
            Me.cmbTipoAlmacenRolado.SelectedValue = Controlador.Configuracion.Engorda.IdTipoAlmacenRolado
        End If

        If Controlador.Configuracion.Engorda.IdTipoAlmacenMedicamento.HasValue Then
            Me.cmbTipoAlmacenMedicamento.SelectedValue = Controlador.Configuracion.Engorda.IdTipoAlmacenMedicamento
        End If

        If Controlador.Configuracion.Engorda.IdTipoAlmacenFormula.HasValue Then
            Me.cmbTipoAlmacenFormula.SelectedValue = Controlador.Configuracion.Engorda.IdTipoAlmacenFormula
        End If

        If Controlador.Configuracion.Engorda.IdFamiliaMedicamento.HasValue Then
            Me.cmbLinea.SelectedValue = Controlador.Configuracion.Engorda.IdFamiliaMedicamento
        End If

        Me.txtImpuestoPredialXAnimal.Text = Controlador.Configuracion.Engorda.ImportePredial.ToString("C2")
        Me.txtPorcentajeEducacion.Text = (Controlador.Configuracion.Engorda.PorcentajeEducacion / 100).ToString("N2")
        Me.txtCostoIndirectoMen.Text = Controlador.Configuracion.Engorda.CostoIndirectoMensual.ToString("C2")
        Me.chkRequerirArete.Checked = Controlador.Configuracion.Engorda.RequerirArete
        Me.chkTransRecibaPorArete.Checked = Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete

        If CType(Controlador.Configuracion.Engorda.MesCostosIndirecto, Byte) <> 0 Then
            Me.cmbMesCostoIndirecto.SelectedItem = CType(Controlador.Configuracion.Engorda.MesCostosIndirecto, MesesCollectionClass.MesesEnum)
        End If

        If Controlador.Configuracion.Engorda.FechaCierreEngorda.Year <> 1 _
        AndAlso Controlador.Configuracion.Engorda.FechaCierreEngorda.Year <> 1900 Then
            ultdtpFechaCierreDiario.Value = Controlador.Configuracion.Engorda.FechaCierreEngorda
            ultdtpFechaCierreDiario.Enabled = False
            lblFechaCierreInicial.Enabled = False
        Else
            ultdtpFechaCierreDiario.Value = Nothing
            ultdtpFechaCierreDiario.Visible = True
            lblFechaCierreInicial.Visible = True
        End If
    End Sub

    Public Sub ObtenerDatos()
        Controlador.Configuracion.Engorda.GDP = Me.txtGDP.Text
        If Me.cmbTipoAlmacenFormula.SelectedIndex > -1 Then Controlador.Configuracion.Engorda.IdTipoAlmacenFormula = Me.cmbTipoAlmacenFormula.SelectedValue
        If Me.cmbTipoAlmacenMedicamento.SelectedIndex > -1 Then Controlador.Configuracion.Engorda.IdTipoAlmacenMedicamento = Me.cmbTipoAlmacenMedicamento.SelectedValue
        If Me.cmbTipoAlmacenRolado.SelectedIndex > -1 Then Controlador.Configuracion.Engorda.IdTipoAlmacenRolado = Me.cmbTipoAlmacenRolado.SelectedValue
        If Me.cmbLinea.SelectedIndex > -1 Then Controlador.Configuracion.Engorda.IdFamiliaMedicamento = CInt(Me.cmbLinea.SelectedValue)

        Controlador.Configuracion.Engorda.ImportePredial = CDbl(Me.txtImpuestoPredialXAnimal.Text)
        Controlador.Configuracion.Engorda.PorcentajeEducacion = CType(Me.txtPorcentajeEducacion.Text, Integer)

        If Not IsNumeric(Me.txtCostoIndirectoMen.Text) Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONFIGURACION_ENGORDA, 0)
        ElseIf CType(Me.txtCostoIndirectoMen.Text, Decimal) <> 0D AndAlso Me.cmbMesCostoIndirecto.SelectedIndex = -1 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONFIGURACION_ENGORDA, 1)
        ElseIf CType(Me.txtCostoIndirectoMen.Text, Decimal) <> 0D AndAlso Me.ultdtpFechaCierreDiario.Value Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONFIGURACION_ENGORDA, 2)
        End If

        Controlador.Configuracion.Engorda.CostoIndirectoMensual = txtCostoIndirectoMen.Text

        If cmbMesCostoIndirecto.SelectedItem IsNot Nothing Then
            Controlador.Configuracion.Engorda.MesCostosIndirecto = cmbMesCostoIndirecto.SelectedItem
        End If

        If ultdtpFechaCierreDiario.Value IsNot Nothing Then
            Controlador.Configuracion.Engorda.FechaCierreEngorda = ultdtpFechaCierreDiario.Value
        End If
        Controlador.Configuracion.Engorda.RequerirArete = Me.chkRequerirArete.Checked
        Controlador.Configuracion.Engorda.TransferirDesdeRecibaPorArete = Me.chkTransRecibaPorArete.Checked
    End Sub

    Private Sub LlenarComboBox()
        Dim Meses As New MesesCollectionClass

        Me.TipoAlmacenFormulaC.Obtener(CondicionEnum.ACTIVOS)
        Me.LineaCollectionClass1.Obtener(CondicionEnum.ACTIVOS)

        For Each tipoAlmacen As TipoAlmacenClass In Me.TipoAlmacenFormulaC
            Me.TipoAlmacenMedicamentoC.Add(tipoAlmacen)
            Me.TipoAlmacenRoladoC.Add(tipoAlmacen)
        Next

        Me.cmbTipoAlmacenFormula.SelectedIndex = -1
        Me.cmbTipoAlmacenFormula.Text = "Seleccione el tipo de almacén de formulados"
        Me.cmbTipoAlmacenMedicamento.SelectedIndex = -1
        Me.cmbTipoAlmacenMedicamento.Text = "Seleccione el tipo de almacén de medicamentos"
        Me.cmbTipoAlmacenRolado.SelectedIndex = -1
        Me.cmbTipoAlmacenRolado.Text = "Seleccione el tipo de almacén de rolado"
        Me.cmbLinea.SelectedIndex = -1
        Me.cmbLinea.Text = "Seleccione la Familia de Medicamentos"
        Me.cmbMesCostoIndirecto.DataSource = Meses
        Me.cmbMesCostoIndirecto.SelectedIndex = -1
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar ConfEngorda")
        Me.ObtenerDatos()

        If Not Controlador.Configuracion.Engorda.Guardar(Trans) Then
            MsgBox("Ha ocurrido un error, por favor intentelo de nuevo", MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            Return False
        End If
        Trans.Commit()
        MsgBox("Se a guardado la configuración", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
        Return True
    End Function

#End Region

#Region "Eventos"

#Region "Form"

    Private Sub frmConfiguracionEngorda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.LlenarComboBox()
            Controlador.Configuracion.ActualizarEngorda()
            Me.PonerDatos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

#Region "ToolBar"

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Dim Resultado As Object = Nothing

        Resultado = Utilerias.RunControlException(Me, "Guardar")

        If Resultado Is Nothing OrElse Not Resultado Then
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub chkRequerirArete_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRequerirArete.CheckedChanged
        If chkRequerirArete.Checked Then
            chkTransRecibaPorArete.Checked = True
            chkTransRecibaPorArete.Enabled = False
        Else
            chkTransRecibaPorArete.Enabled = True
        End If
    End Sub

#End Region

#End Region

End Class