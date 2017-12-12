Imports EC = integralab.ORM.EntityClasses
Imports CC = integralab.ORM.CollectionClasses
Imports HC = integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = integralab.ORM.TypedListClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses

Public Class DetallesEmpresasForm

    Private Sub DetallesEmpresasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Empresas.Fill()
        EmpresaComboBox.SelectedIndex = -1
        EmpresaComboBox.Text = "Seleccione una empresa"
        UsuariosAsociadosListBox.SelectedIndex = -1
        UsuariosDisponiblesListBox.SelectedIndex = -1
    End Sub

    Private Sub UsuariosAsociadosListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsuariosAsociadosListBox.SelectedIndexChanged
        If UsuariosAsociadosListBox.SelectedIndex > -1 Then
            DesasociarButton.Enabled = True
        Else
            DesasociarButton.Enabled = False
        End If
    End Sub

    Private Sub UsuariosDisponiblesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsuariosDisponiblesListBox.SelectedIndexChanged
        If UsuariosDisponiblesListBox.SelectedIndex > -1 Then
            AsociarButton.Enabled = True
        Else
            AsociarButton.Enabled = False
        End If
    End Sub

    Private Sub sbActualizarListBox()
        UsuariosDisponibles.Clear()
        Dim filtro As New OC.PredicateExpression(New OC.FieldCompareSetPredicate( _
        HCS.UsuarioFields.Usrndx, HCS.DetalleempresasFields.Usrndx, _
        SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.NotEqualAll, _
        HCS.DetalleempresasFields.Empndx = EmpresaComboBox.SelectedValue))
        UsuariosDisponibles.Fill(0, Nothing, True, filtro)

        UsuariosAsociados.Clear()
        filtro = New OC.PredicateExpression(New OC.FieldCompareSetPredicate( _
        HCS.UsuarioFields.Usrndx, HCS.DetalleempresasFields.Usrndx, _
        SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.In, _
        HCS.DetalleempresasFields.Empndx = EmpresaComboBox.SelectedValue))
        UsuariosAsociados.Fill(0, Nothing, True, filtro)
    End Sub

    Private Sub EmpresaComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmpresaComboBox.SelectedIndexChanged
        If EmpresaComboBox.SelectedIndex > -1 Then sbActualizarListBox()
    End Sub

    Private Sub AsociarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsociarButton.Click
        Try
            Dim DetalleEmpresa As New ECS.DetalleempresasEntity
            DetalleEmpresa.Empndx = EmpresaComboBox.SelectedValue
            DetalleEmpresa.Usrndx = UsuariosDisponiblesListBox.SelectedValue
            DetalleEmpresa.Save()
            sbActualizarListBox()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DesasociarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesasociarButton.Click
        Try
            Dim DetalleEmpresa As New ECS.DetalleempresasEntity
            DetalleEmpresa.FetchUsingPK(EmpresaComboBox.SelectedValue, UsuariosAsociadosListBox.SelectedValue)
            DetalleEmpresa.Delete()
            sbActualizarListBox()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class