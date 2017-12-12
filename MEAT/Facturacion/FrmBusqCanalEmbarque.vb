Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Public Class FrmBusqCanalEmbarque
    Public Codigos() As String
    Private Sub FrmBusqCanalEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim Vista As New TC.VwBusqCanalesEmbarqueTypedView
            Dim Filtro As New OC.PredicateExpression
            Filtro.Add(HC.VwBusqCanalesEmbarqueFields.Estatus = "VIGENTE")
            If Not Me.txtLoteSacrificio.Text = "" Then
                Filtro.Add(HC.VwBusqCanalesEmbarqueFields.FolioSacrificio Mod String.Format("%{0}%", Me.txtLoteSacrificio.Text))
            End If

            Vista.Fill(0, Nothing, True, Filtro)
            Me.DgvCanales.AutoGenerateColumns = False
            Me.DgvCanales.DataSource = Vista

            If Vista.Rows.Count > 0 Then
                Me.DgvCanales.AutoGenerateColumns = False
                Me.DgvCanales.DataSource = Vista
                If Not Codigos Is Nothing Then

                    Dim Tope As Integer = 0
                    For i As Integer = 0 To Me.DgvCanales.Rows.Count - 1

                        For j As Integer = 0 To Me.Codigos.Length - 1
                            If Not DgvCanales.Rows(i).Cells(Me.clmFolioCanal.Index).Value = "" Then
                                If DgvCanales.Rows(i).Cells(Me.clmFolioCanal.Index).Value = Me.Codigos(j) Then
                                    DgvCanales.Rows(i).Cells(Me.clmSeleccion.Index).Value = True
                                    DgvCanales.Rows(i).Cells(Me.clmSeleccion.Index).ReadOnly = True
                                    Tope += 1
                                    Exit For
                                End If
                            End If
                        Next

                        If Tope = Me.Codigos.Length Then
                            Exit For
                        End If
                    Next
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Buscar()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            Dim Enc As Boolean
            If Me.DgvCanales.Rows.Count > 0 Then
                For i As Integer = 0 To Me.DgvCanales.Rows.Count - 1
                    If CBool(DgvCanales.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
                        Enc = True
                    End If
                Next
            End If
            If Enc Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BrnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BrnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtLoteSacrificio_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtLoteSacrificio.PreviewKeyDown
        Try
            If Me.txtLoteSacrificio.Text.Length > 4 Then
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class