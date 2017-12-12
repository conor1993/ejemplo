Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmConfigImpresionCheque
    Dim Config As CN.ConfigImpresionChequeClass
    Dim ConfigCol As CN.ConfigImpresionChequesCollectionClass
    Dim BancosCol As CN.BancosCollectionClass
    Dim Editar As Boolean = False
    Dim _ConfigAux As CN.ConfigImpresionChequeClass

    Private Sub FrmConfigImpresionCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = "000100011"
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "000100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            BancosCol = New CN.BancosCollectionClass
            BancosCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Me.DgvBancos.AutoGenerateColumns = False
            Me.DgvBancos.DataSource = BancosCol
            Limpiar()
            DesHabilitar()
            Me.txtFechaX.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtCodigo.Text = 0
        Me.txtAbonoACuentaX.Text = 0
        Me.txtAbonoACuentaY.Text = 0
        Me.txtAbonoX.Text = 0
        Me.txtAbonoY.Text = 0
        Me.txtBeneficiarioX.Text = 0
        Me.txtBeneficiarioY.Text = 0
        Me.txtCargoX.Text = 0
        Me.txtCargoY.Text = 0
        Me.txtCopiaBeneX.Text = 0
        Me.txtCopiaBeneY.Text = 0
        Me.txtCopiaFechaX.Text = 0
        Me.txtCopiaFechaY.Text = 0
        Me.txtCopiaImpLetraY.Text = 0
        Me.txtCopiaImpLetraX.Text = 0
        Me.txtCopiaImporteX.Text = 0
        Me.txtCopiaImporteY.Text = 0
        Me.txtCuentaX.Text = 0
        Me.txtCuentaY.Text = 0
        Me.txtFechaX.Text = 0
        Me.txtFechaY.Text = 0
        Me.txtImpLetraX.Text = 0
        Me.txtImpLetraY.Text = 0
        Me.txtImporteX.Text = 0
        Me.txtImporteY.Text = 0
        Me.txtSSubCuentaY.Text = 0
        Me.txtSSSubCuentaX.Text = 0
        Me.txtSSSubCuentaY.Text = 0
        Me.txtSSubCuentaX.Text = 0
        Me.txtSubCuentaX.Text = 0
        Me.txtSubCuentaY.Text = 0
        Me.RbtnRenglon.Checked = False
        Me.rbtnDetallada.Checked = False
        Me.txtConceptoX.Text = 0
        Me.txtConceptoY.Text = 0
        Me.txtCopiaAbonoACuentaX.Text = 0
        Me.txtCopiaAbonoACuentaY.Text = 0
        Me.txtFolioX.Text = 0
        Me.txtFolioY.Text = 0
        Me.txtTotalCargoX.Text = 0
        Me.txtTotalCargoY.Text = 0
        Me.txtCopiaFolioX.Text = 0
        txtCopiaFolioY.Text = 0
        Me.txtTotalAbonoX.Text = 0
        Me.txtTotalAbonoY.Text = 0
        Me.txtBancoX.Text = 0
        Me.txtBancoY.Text = 0
        Me.txtCuentaBancoX.Text = 0
        Me.txtCuentaBancoY.Text = 0
        Me.txtChequeX.Text = 0
        Me.txtChequeY.Text = 0

        For i As Integer = 0 To Me.DgvBancos.Rows.Count - 1
            If CBool(Me.DgvBancos.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
                Me.DgvBancos.Rows(i).Cells(Me.clmSeleccion.Index).Value = False
            End If
        Next
    End Sub

    Private Sub Habilitar()
        Me.GroupBox1.Enabled = True
        Me.GroupBox2.Enabled = True
        Me.GroupBox3.Enabled = True
        Me.GroupBox4.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.GroupBox1.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.GroupBox3.Enabled = False
        Me.GroupBox4.Enabled = False
    End Sub

    Private Function Validar() As Boolean
        Try
            For Each Caja As Control In Me.GroupBox1.Controls
                If Caja.GetType.ToString = "system.Windows.Forms.TextBox" Then
                    If Caja.Text = "" Then
                        MessageBox.Show("No deje casillas en blanco", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Caja.Focus()
                        Return False
                    End If
                End If
            Next

            For Each Caja As Control In Me.GroupBox2.Controls
                If Caja.GetType.ToString = "system.Windows.Forms.TextBox" Then
                    If Caja.Text = "" Then
                        MessageBox.Show("No deje casillas en blanco", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Caja.Focus()
                        Return False
                    End If
                End If
            Next

            For Each Caja As Control In Me.GroupBox3.Controls
                If Caja.GetType.ToString = "system.Windows.Forms.TextBox" Then
                    If Caja.Text = "" Then
                        MessageBox.Show("No deje casillas en blanco", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Caja.Focus()
                        Return False
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub PonerDatos()
        Me.txtCodigo.Text = Config.Codigo

        Me.txtFolioX.Text = Config.FolioCol
        Me.txtFolioY.Text = Config.FolioRen

        Me.txtCopiaFolioX.Text = Config.FolioCopiaCol
        Me.txtCopiaFolioY.Text = Config.FolioCopiaRen

        Me.txtCopiaAbonoACuentaX.Text = Config.AbonoACuentaCopiaCol
        Me.txtCopiaAbonoACuentaY.Text = Config.AbonoACuentaCopiaRen
        Me.txtConceptoX.Text = Config.ConceptoCol
        Me.txtConceptoY.Text = Config.ConceptoRen
        Me.txtTotalCargoX.Text = Config.CargoTotalCol
        Me.txtTotalCargoY.Text = Config.CargoTotalRen
        Me.txtTotalAbonoX.Text = Config.AbonoTotalCol
        Me.txtTotalAbonoY.Text = Config.AbonoTotalRen
        Me.txtFechaX.Text = Config.FechaImpCol
        Me.txtFechaY.Text = Config.FechaImpRen
        Me.txtBeneficiarioX.Text = Config.BeneficiarioCol
        Me.txtBeneficiarioY.Text = Config.BeneficiarioRen
        Me.txtImporteX.Text = Config.ImporteCol
        Me.txtImporteY.Text = Config.ImporteRen
        Me.txtImpLetraX.Text = Config.ImpteLetraCol
        Me.txtImpLetraY.Text = Config.ImpteLetraRen
        Me.txtAbonoACuentaX.Text = Config.AbonoACuentaCol
        Me.txtAbonoACuentaY.Text = Config.AbonoACuentaRen

        Me.txtCopiaFechaX.Text = Config.FechaCopiaCol
        Me.txtCopiaFechaY.Text = Config.FechaCopiaRen
        Me.txtCopiaBeneX.Text = Config.BeneCopiaCol
        Me.txtCopiaBeneY.Text = Config.BeneCopiaRen
        Me.txtCopiaImporteX.Text = Config.ImporteCopiaCol
        Me.txtCopiaImporteY.Text = Config.ImporteCopiaRen
        Me.txtCopiaImpLetraX.Text = Config.ImporteLetraCopiaCol
        Me.txtCopiaImpLetraY.Text = Config.ImporteLetraCopiaRen

        Me.txtCuentaX.Text = Config.CuentaCol
        Me.txtCuentaY.Text = Config.CuentaRen
        Me.txtSubCuentaX.Text = Config.SubCuentaCol
        Me.txtSubCuentaY.Text = Config.SubCuentaRen
        Me.txtSSubCuentaX.Text = Config.SSubCuentaCol
        Me.txtSSubCuentaY.Text = Config.SSubCuentaRen
        Me.txtSSSubCuentaX.Text = Config.SSSubCuentaCol
        Me.txtSSSubCuentaY.Text = Config.SSSubCuentaRen

        Me.txtCargoX.Text = Config.CargoCol
        Me.txtCargoY.Text = Config.CargoRen
        Me.txtAbonoX.Text = Config.AbonoCol
        Me.txtAbonoY.Text = Config.AbonoRen

        Me.txtBancoX.Text = Config.BancoCol
        Me.txtBancoY.Text = Config.BancoRen
        Me.txtCuentaBancoX.Text = Config.CuentaBancoCol
        Me.txtCuentaBancoY.Text = Config.CuentaBancoRen
        Me.txtChequeX.Text = Config.ChequeCol
        Me.txtChequeY.Text = Config.ChequeRen

        Me.RbtnRenglon.Checked = Config.ImpCuentaConcentrada
        Me.rbtnDetallada.Checked = Config.ImpCuentaDetallada
    End Sub

    Private Sub Guardar(ByVal _Config As CN.ConfigImpresionChequeClass)
        _Config.FolioCol = Me.txtFolioX.Text
        _Config.FolioRen = Me.txtFolioY.Text
        _Config.FolioCopiaCol = Me.txtCopiaFolioX.Text
        _Config.FolioCopiaRen = Me.txtCopiaFolioY.Text
        _Config.AbonoACuentaCopiaCol = Me.txtCopiaAbonoACuentaX.Text
        _Config.AbonoACuentaCopiaRen = Me.txtCopiaAbonoACuentaY.Text
        _Config.ConceptoCol = Me.txtConceptoX.Text
        _Config.ConceptoRen = Me.txtConceptoY.Text
        _Config.CargoTotalCol = Me.txtTotalCargoX.Text
        _Config.CargoTotalRen = Me.txtTotalCargoY.Text
        _Config.AbonoTotalCol = Me.txtTotalAbonoX.Text
        _Config.AbonoTotalRen = Me.txtTotalAbonoY.Text
        _Config.FechaImpCol = Me.txtFechaX.Text
        _Config.FechaImpRen = Me.txtFechaY.Text
        _Config.BeneficiarioCol = Me.txtBeneficiarioX.Text
        _Config.BeneficiarioRen = Me.txtBeneficiarioY.Text
        _Config.ImporteCol = Me.txtImporteX.Text
        _Config.ImporteRen = Me.txtImporteY.Text
        _Config.ImpteLetraCol = Me.txtImpLetraX.Text
        _Config.ImpteLetraRen = Me.txtImpLetraY.Text
        _Config.AbonoACuentaCol = Me.txtAbonoACuentaX.Text
        _Config.AbonoACuentaRen = Me.txtAbonoACuentaY.Text

        _Config.FechaCopiaCol = Me.txtCopiaFechaX.Text
        _Config.FechaCopiaRen = Me.txtCopiaFechaY.Text
        _Config.BeneCopiaCol = Me.txtCopiaBeneX.Text
        _Config.BeneCopiaRen = Me.txtCopiaBeneY.Text
        _Config.ImporteCopiaCol = Me.txtCopiaImporteX.Text
        _Config.ImporteCopiaRen = Me.txtCopiaImporteY.Text
        _Config.ImporteLetraCopiaCol = Me.txtCopiaImpLetraX.Text
        _Config.ImporteLetraCopiaRen = Me.txtCopiaImpLetraY.Text

        _Config.CuentaCol = Me.txtCuentaX.Text
        _Config.CuentaRen = Me.txtCuentaY.Text
        _Config.SubCuentaCol = Me.txtSubCuentaX.Text
        _Config.SubCuentaRen = Me.txtSubCuentaY.Text
        _Config.SSubCuentaCol = Me.txtSSubCuentaX.Text
        _Config.SSubCuentaRen = Me.txtSSubCuentaY.Text
        _Config.SSSubCuentaCol = Me.txtSSSubCuentaX.Text
        _Config.SSSubCuentaRen = Me.txtSSSubCuentaY.Text

        _Config.CargoCol = Me.txtCargoX.Text
        _Config.CargoRen = Me.txtCargoY.Text
        _Config.AbonoCol = Me.txtAbonoX.Text
        _Config.AbonoRen = Me.txtAbonoY.Text

        _Config.BancoCol = Me.txtBancoX.Text
        _Config.BancoRen = Me.txtBancoY.Text
        _Config.CuentaBancoCol = Me.txtCuentaBancoX.Text
        _Config.CuentaBancoRen = Me.txtCuentaBancoY.Text
        _Config.ChequeCol = Me.txtChequeX.Text
        _Config.ChequeRen = Me.txtChequeY.Text


        _Config.ImpCuentaConcentrada = Me.RbtnRenglon.Checked
        _Config.ImpCuentaDetallada = Me.rbtnDetallada.Checked
    End Sub
#End Region

#Region "Tool Bar"

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Limpiar()
            Dim Ventana As New FrmBusquedaConfig
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim codigo As Integer = Ventana.DataGridView1.SelectedRows(0).Cells(Ventana.clmCodigo.Index).Value
                Dim IdBanco As Integer = Ventana.DataGridView1.SelectedRows(0).Cells(Ventana.clmIdBanco.Index).Value
                Config = New CN.ConfigImpresionChequeClass(codigo, IdBanco)
                _ConfigAux = Config
                PonerDatos()

                ConfigCol = New CN.ConfigImpresionChequesCollectionClass
                ConfigCol.Obtener(codigo)

                For Each Configuracion As CN.ConfigImpresionChequeClass In ConfigCol
                    For i As Integer = 0 To Me.DgvBancos.Rows.Count - 1
                        If Me.DgvBancos.Rows(i).Cells(Me.ClmCodigo.Index).Value = Configuracion.IdBanco Then
                            Me.DgvBancos.Rows(i).Cells(Me.clmSeleccion.Index).Value = True
                        End If
                    Next
                Next

                DesHabilitar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
        Editar = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
        Try
            Me.txtCodigo.Focus()
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            Dim Max As Integer = 0
            Dim Selecciono As Boolean = False
            Dim Seleccionado As Boolean = False
            Dim Guarda As Boolean = False
            Dim Bancos As String = ""
            Dim Enc As Boolean = False
            Dim Band As Boolean = False
            Dim Coleccion As New CC.ConfiguracionChequesImpCollection

            '/////////////////////////////////////////////////////////////
            'Nuevo Registro

            If Not Editar Then
                Coleccion.GetMulti(Nothing)
                If Coleccion.Count > 0 Then
                    Max = Coleccion.GetScalar(Integralab.ORM.ConfiguracionChequesImpFieldIndex.Codigo, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max)
                End If

                If Max = 0 Then
                    Max = 1
                Else
                    Max = Max + 1
                End If
                For i As Integer = 0 To Me.DgvBancos.Rows.Count - 1
                    If CBool(Me.DgvBancos.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
                        Selecciono = True
                        If CBool(Me.DgvBancos.Rows(i).Cells(Me.ClmNoGuardar.Index).Value) Then
                            Enc = True
                            Bancos &= Me.DgvBancos.Rows(i).Cells(Me.clmBanco.Index).Value & ", "
                            Continue For
                        End If

                        Me.Config = New CN.ConfigImpresionChequeClass

                        Config.Codigo = Max
                        Config.IdBanco = Me.DgvBancos.Rows(i).Cells(Me.ClmCodigo.Index).Value

                        Guardar(Config)
                        If Not Config.Guardar(Trans) Then
                            Trans.Rollback()
                            MessageBox.Show("No se logro guardar la configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Cancelar = True
                        Else
                            Guarda = True
                        End If
                    End If
                Next

            Else
                '//////////////////////////////////////////////////////////////////////////////////////////////////////
                ' Modo edicion

                For i As Integer = 0 To Me.DgvBancos.Rows.Count - 1
                    Band = False
                    Seleccionado = False
                    If CBool(Me.DgvBancos.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
                        Seleccionado = True ' Si el banco esta seleccionado 
                        Selecciono = True
                    End If
                    For Each Configuracion As CN.ConfigImpresionChequeClass In ConfigCol 'Bancos que estan en la bd con esta configuracion
                        If Me.DgvBancos.Rows(i).Cells(Me.ClmCodigo.Index).Value = Configuracion.IdBanco Then
                            'Si el banco esta en la coleccion
                            Band = True
                        End If
                    Next

                    If Seleccionado And Band Then ' Se el banco esta en la coleccion y esta seleccionado entonces se modifica
                        _ConfigAux = New CN.ConfigImpresionChequeClass(ConfigCol(0).Codigo, Me.DgvBancos.Rows(i).Cells(Me.ClmCodigo.Index).Value)
                        Guardar(_ConfigAux)
                        If Not _ConfigAux.Guardar(Trans) Then
                            Trans.Rollback()
                            MessageBox.Show("No se logro guardar la configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            Guarda = True
                            Exit For
                        End If
                    End If

                    If Band And Not Seleccionado Then ' Si el banco esta en la coleccion y no esta seleccionado entonces se borra
                        Dim Entidad As New EC.ConfiguracionChequesImpEntity(ConfigCol(0).Codigo, Me.DgvBancos.Rows(i).Cells(Me.ClmCodigo.Index).Value)
                        Trans.Add(Entidad)
                        If Not Entidad.Delete() Then
                            Trans.Rollback()
                            MessageBox.Show("No se logro modificar la configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Cancelar = True
                        Else
                            Guarda = True
                        End If
                    End If

                    If Seleccionado And Not Band Then 'Si el banco no esta en la coleccion y esta selecciondo entonces se crea una nueva instancia
                        If CBool(Me.DgvBancos.Rows(i).Cells(Me.ClmNoGuardar.Index).Value) Then
                            Enc = True
                            Bancos &= Me.DgvBancos.Rows(i).Cells(Me.clmBanco.Index).Value & ", "
                            Continue For
                        End If

                        Me.Config = New CN.ConfigImpresionChequeClass

                        Config.Codigo = ConfigCol(0).Codigo
                        Config.IdBanco = Me.DgvBancos.Rows(i).Cells(Me.ClmCodigo.Index).Value

                        Guardar(Config)
                        If Not Config.Guardar(Trans) Then
                            Trans.Rollback()
                            MessageBox.Show("No se logro modificar la configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Cancelar = True
                        Else
                            Guarda = True
                        End If
                    End If
                Next
            End If
            '/////////////////////////////////////////////////////////////////////
            If Selecciono = False Then
                Trans.Rollback()
                MessageBox.Show("Seleccione por lo menos un banco al cual se le aplicará esta configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.DgvBancos.Focus()
                Cancelar = True
                Exit Sub
            End If
            Trans.Commit()
            If Enc = True Then
                MessageBox.Show("No se le aplico la configuración a los siguientes Bancos: " & Bancos & "debido a que ya cuentan con otra configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If Guarda Then
                MessageBox.Show("Se ha guardado la configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DesHabilitar()
                Limpiar()
            Else
                Cancelar = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Habilitar()
        Limpiar()
        Me.txtFolioX.Focus()
        Editar = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "KeyPress"
    Private Sub txtFolioX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioX.KeyPress
        If Not Me.txtFolioX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtFolioY.Focus()
            End If
        End If
    End Sub

    Private Sub txtFolioY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioY.KeyPress
        If Not Me.txtFolioY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtFechaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtFechaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaX.KeyPress
        If Not Me.txtFechaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtFechaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtFechaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaY.KeyPress
        If Not Me.txtFechaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtBeneficiarioX.Focus()
            End If
        End If
    End Sub

    Private Sub txtBeneficiarioX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBeneficiarioX.KeyPress
        If Not Me.txtBeneficiarioX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtBeneficiarioY.Focus()
            End If
        End If
    End Sub

    Private Sub txtBeneficiarioY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBeneficiarioY.KeyPress
        If Not Me.txtBeneficiarioY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtImporteX.Focus()
            End If
        End If
    End Sub

    Private Sub txtImporteX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteX.KeyPress
        If Not Me.txtImporteX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtImporteY.Focus()
            End If
        End If
    End Sub

    Private Sub txtImporteY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteY.KeyPress
        If Not Me.txtImporteY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtImpLetraX.Focus()
            End If
        End If
    End Sub

    Private Sub txtImpLetraX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImpLetraX.KeyPress
        If Not Me.txtImpLetraX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtImpLetraY.Focus()
            End If
        End If
    End Sub

    Private Sub txtAbonoACuentaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbonoACuentaX.KeyPress
        If Not Me.txtAbonoACuentaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtAbonoACuentaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtAbonoACuentaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbonoACuentaY.KeyPress
        If Not Me.txtAbonoACuentaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaFolioX.Focus()
            End If
        End If
    End Sub



    Private Sub txtCopiaFolioX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaFolioX.KeyPress
        If Not Me.txtCopiaFolioX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaFolioY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaFolioY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaFolioY.KeyPress
        If Not Me.txtCopiaFolioY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaFechaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaFechaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaFechaX.KeyPress
        If Not Me.txtCopiaFechaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaFechaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaFechaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaFechaY.KeyPress
        If Not Me.txtCopiaFechaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaBeneX.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaBeneX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaBeneX.KeyPress
        If Not Me.txtCopiaBeneX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaBeneY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaBeneY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaBeneY.KeyPress
        If Not Me.txtCopiaBeneY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaImporteX.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaImporteX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaImporteX.KeyPress
        If Not Me.txtCopiaImporteX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaImporteY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaImporteY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaImporteY.KeyPress
        If Not Me.txtCopiaImporteY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaImpLetraX.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaImpLetraX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaImpLetraX.KeyPress
        If Not Me.txtCopiaImpLetraX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaImpLetraY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaImpLetraY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaImpLetraY.KeyPress
        If Not Me.txtCopiaImpLetraY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaAbonoACuentaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtImpLetraY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImpLetraY.KeyPress
        If Not Me.txtCopiaImpLetraY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtAbonoACuentaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaAbonoACuentaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaAbonoACuentaX.KeyPress
        If Not Me.txtCopiaAbonoACuentaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCopiaAbonoACuentaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCopiaAbonoACuentaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCopiaAbonoACuentaY.KeyPress
        If Not Me.txtCopiaAbonoACuentaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtConceptoX.Focus()
            End If
        End If
    End Sub


    Private Sub txtConceptoX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConceptoX.KeyPress
        If Not Me.txtConceptoX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtConceptoY.Focus()
            End If
        End If
    End Sub

    Private Sub txtConceptoY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConceptoY.KeyPress
        If Not Me.txtConceptoY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCuentaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuentaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaX.KeyPress
        If Not Me.txtCuentaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCuentaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuentaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaY.KeyPress
        If Not Me.txtCuentaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtSubCuentaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtSubCuentaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubCuentaX.KeyPress
        If Not Me.txtSubCuentaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtSubCuentaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtSubCuentaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubCuentaY.KeyPress
        If Not Me.txtSubCuentaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtSSubCuentaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtSSubCuentaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSubCuentaX.KeyPress
        If Not Me.txtSSubCuentaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtSSubCuentaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtSSubCuentaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSubCuentaY.KeyPress
        If Not Me.txtSSubCuentaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtSSSubCuentaX.Focus()
            End If
        End If
    End Sub

    Private Sub txtSSSubCuentaX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSSubCuentaX.KeyPress
        If Not Me.txtSSSubCuentaX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtSSSubCuentaY.Focus()
            End If
        End If
    End Sub

    Private Sub txtSSSubCuentaY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSSubCuentaY.KeyPress
        If Not Me.txtSSSubCuentaY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCargoX.Focus()
            End If
        End If
    End Sub

    Private Sub txtCargoX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCargoX.KeyPress
        If Not Me.txtCargoX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtCargoY.Focus()
            End If
        End If
    End Sub

    Private Sub txtCargoY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCargoY.KeyPress
        If Not Me.txtCargoY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtAbonoX.Focus()
            End If
        End If
    End Sub

    Private Sub txtAbonoY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbonoY.KeyPress
        If Not Me.txtAbonoY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtTotalCargoX.Focus()
            End If
        End If
    End Sub


    Private Sub txtTotalCargoX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalCargoX.KeyPress
        If Not Me.txtTotalCargoX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtTotalCargoY.Focus()
            End If
        End If
    End Sub

    Private Sub txtTotalCargoY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalCargoY.KeyPress
        If Not Me.txtTotalCargoY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtTotalAbonoX.Focus()
            End If
        End If
    End Sub

    Private Sub txtTotalAbonoX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalAbonoX.KeyPress
        If Not Me.txtTotalAbonoX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtTotalAbonoY.Focus()
            End If
        End If
    End Sub

    Private Sub txtTotalAbonoY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalAbonoY.KeyPress
        If Not Me.txtTotalAbonoY.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.DgvBancos.Focus()
            End If
        End If
    End Sub

    Private Sub txtAbonoX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbonoX.KeyPress
        If Not Me.txtAbonoX.Text = "" Then
            If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(13) Then
                Me.txtAbonoY.Focus()
            End If
        End If
    End Sub

#End Region


    Private Sub DgvBancos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvBancos.CellContentClick
        Try
            Select Case e.ColumnIndex
                Case Me.clmSeleccion.Index
                    Dim Col As New CC.ConfiguracionChequesImpCollection
                    If Col.GetDbCount(HC.ConfiguracionChequesImpFields.IdBanco = Me.DgvBancos.CurrentRow.Cells(Me.ClmCodigo.Index).Value) > 0 Then
                        Me.DgvBancos.CurrentRow.Cells(Me.ClmNoGuardar.Index).Value = True
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class