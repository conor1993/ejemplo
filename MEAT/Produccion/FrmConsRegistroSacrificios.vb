Imports CN = ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class ReporteRegistroSacrificios

    Dim Registros As New CN.RegistroSacrificioColeccionClass
    Dim Introductores As New CN.ClientesIntroductoresColeccion
    Dim m_sacrificio As New CN.RegistroSacrificiosClass

    Public ReadOnly Property Sacrificio() As CN.RegistroSacrificiosClass
        Get
            If Me.DgvSacrificios.SelectedRows.Count > 0 Then
                Me.m_sacrificio.Obtener(Me.DgvSacrificios.SelectedRows(0).Cells(Me.LoteSacrificio.Index).Value)
            End If

            Return Me.m_sacrificio
        End Get
    End Property

    Public Sub Buscar()
        Try
            Dim vista As New TC.VwConsultaSacrificiosTypedView
            Dim filtro As New OC.PredicateExpression

            If Me.txtLoteSacrificio.Text.Trim = "" Then
                If Me.CmbIntroductor.SelectedIndex > -1 Then
                    filtro.Add(HC.VwConsultaSacrificiosFields.IdCliente = Me.CmbIntroductor.SelectedValue)
                End If

                If Me.rbtActivos.Checked Then
                    filtro.Add(HC.VwConsultaSacrificiosFields.Estatus = "A")
                ElseIf Me.rbtInactivos.Checked Then
                    filtro.Add(HC.VwConsultaSacrificiosFields.Estatus = "X")
                ElseIf Me.rbtCerrados.Checked Then
                    filtro.Add(HC.VwConsultaSacrificiosFields.Estatus = "C")
                End If

                If Me.chkPorCabezas.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwConsultaSacrificiosFields.CantCabSacrificio, CInt(Me.txtNumeroCabezasDe.Text), CInt(Me.txtNumeroCabezasA.Text)))
                End If

                If Me.chkFiltrar.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwConsultaSacrificiosFields.FechaSacrificio, Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString))
                End If
            Else
                filtro.Add(HC.VwConsultaSacrificiosFields.FolioSacrificio Mod String.Format("%{0}%", Me.txtLoteSacrificio.Text.Trim))
            End If

            vista.Fill(0, Nothing, False, filtro)

            Me.DgvSacrificios.AutoGenerateColumns = False
            Me.DgvSacrificios.DataSource = vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvSacrificios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSacrificios.CellDoubleClick

        If Me.DgvSacrificios.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("No ha Seleccionado un Registro...", MsgBoxStyle.Exclamation, "Error")
        End If
       

    End Sub

    Private Sub FrmConsRegistroSacrificios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Introductores.Obtener(True)
        Me.CmbIntroductor.DisplayMember = "Nombre"
        Me.CmbIntroductor.ValueMember = "Codigo"
        Me.CmbIntroductor.DataSource = Introductores
        Me.CmbIntroductor.SelectedIndex = -1
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.DgvSacrificios.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("No ha Seleccionado un Registro...", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
       
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Buscar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al realizar la busqeuda", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.DtpFechaInicio.Value = Now
        Me.DtpFechaFinal.Value = Now
        Me.txtLoteSacrificio.Clear()
        Me.txtCodigoIntroductor.Clear()
        Me.txtNumeroCabezasA.Text = 0
        Me.txtNumeroCabezasDe.Text = 0
        Me.chkFiltrar.Checked = False
        Me.chkPorCabezas.Checked = False
        Me.rbtActivos.Checked = True
        Me.CmbIntroductor.SelectedIndex = -1
        Me.CmbIntroductor.Text = "Seleccione un introductor"
        Me.grpCabezas.Enabled = False
        Me.grpFecha.Enabled = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub chkPorCabezas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorCabezas.CheckedChanged
        Me.grpCabezas.Enabled = Me.chkPorCabezas.Checked
    End Sub

    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        Me.grpFecha.Enabled = Me.chkFiltrar.Checked
    End Sub
End Class