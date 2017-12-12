Imports CN = ClasesNegocio
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class FrmBusqCanalesAcorte
    Public SinClientes As Boolean

    Private Sub FrmBusqCanalesAcorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'cambiar el llamado a la colección por un llamado a unan vista
            'Dim ColCanales As DataSet = SPR.UspConMscrecepcionCanalesDet("", "", 7, Now, "")
            'Dim TablaFac As DataSet = SPR.UspConMscrecepcionCanalesDet("", "", 7, Now, "")

            'Dim Coleccion As New CN.RecepcionCanalesDetCollectionClass

            'Coleccion.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, SinClientes)
          
            'Me.DgvCanales.AutoGenerateColumns = False
            ''Me.DgvCanales.DataSource = Coleccion
            'Me.DgvCanales.DataSource = ColCanales.Tables(0)
            ''Me.FechaSacrificio.DataPropertyName = "idfoliocanal"
            Buscar()
            Me.chkAgregar.Checked = False
            Me.dtpFecha.Enabled = False
            'Me.txtKilos.Text = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.DgvCanales.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub DgvCanales_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCanales.DoubleClick
        If Me.DgvCanales.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            'Dim Coleccion As New CN.RecepcionCanalesDetCollectionClass
            'Coleccion.Obtener(Me.txtFolioSacrificio.Text, Me.txtKilos.Text, SinClientes)

            'Me.DgvCanales.AutoGenerateColumns = False
            'Me.DgvCanales.DataSource = Coleccion
            Buscar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.txtFolioSacrificio.Text = ""
        Me.txtKilos.Text = ""
        Me.DgvCanales.DataSource = Nothing
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtKilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilos.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Buscar()
                'Dim Coleccion As New CN.RecepcionCanalesDetCollectionClass
                'Coleccion.Obtener(Me.txtFolioSacrificio.Text, Me.txtKilos.Text, SinClientes)

                'Me.DgvCanales.AutoGenerateColumns = False
                'Me.DgvCanales.DataSource = Coleccion
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtFolioSacrificio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioSacrificio.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKilos.Focus()
        End If
    End Sub

    'Private Sub txtKilos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKilos.LostFocus
    '    If Me.txtKilos.Text = "" Then
    '        Me.txtKilos.Text = 0
    '    End If
    'End Sub

    Private Sub Buscar()
        Try
            Dim Vista As New TC.VwBusqCanalesEmbarqueTypedView
            Dim Filtro As New OC.PredicateExpression

            Filtro.Add(HC.VwBusqCanalesEmbarqueFields.Estatus = "VIGENTE")

            If Not Me.txtFolioSacrificio.Text = "" Then
                Filtro.Add(HC.VwBusqCanalesEmbarqueFields.FolioSacrificio = Me.txtFolioSacrificio.Text)
            End If

            If Not Me.txtKilos.Text = "" Then
                Filtro.Add(HC.VwBusqCanalesEmbarqueFields.KgrsCalientes = Me.txtKilos.Text)
            End If

            If Me.chkAgregar.Checked Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusqCanalesEmbarqueFields.FechaSacrificio, Me.dtpFecha.Value.ToShortDateString, Me.dtpFecha.Value.AddDays(1).ToShortDateString))
            End If

            Vista.Fill(0, Nothing, True, Filtro)

            If Vista.Rows.Count = 0 Then
                MsgBox("No se encontraron canales para enviar a corte", MsgBoxStyle.Information, "MEAT")
                Exit Sub
            End If

            Me.DgvCanales.AutoGenerateColumns = False
            Me.DgvCanales.DataSource = Vista

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub chkAgregar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgregar.CheckedChanged
        If Me.chkAgregar.Checked Then
            Me.dtpFecha.Enabled = True
        Else
            Me.dtpFecha.Enabled = False
        End If
    End Sub
End Class