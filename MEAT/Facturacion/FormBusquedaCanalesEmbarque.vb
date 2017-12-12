Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class FrmBusquedaCortesEmbarque
    Dim ProductosCol As CC.MsccatProductosCollection

    Public Cortes As Boolean
    Public Canales As Boolean
    Public Productos As Boolean
    Public Codigos() As Integer
    Public Bloquear As Boolean = True

    Private Sub FrmBusquedaCortesEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            ProductosCol = New CC.MsccatProductosCollection

            Dim Filtro As New OC.PredicateExpression

            If Not Me.txtCodigo.Text = "" And IsNumeric(Me.txtCodigo.Text) Then
                Filtro.Add(HC.MsccatProductosFields.IdProducto Mod String.Format("%{0}%", Me.txtCodigo.Text))
            End If

            If Cortes Then
                Filtro.Add(HC.MsccatProductosFields.Corte = True)
                ProductosCol.GetMulti(Filtro)
                Me.DgvCortes.AutoGenerateColumns = False
                Me.DgvCortes.DataSource = ProductosCol
            End If

            If Canales Then
                Filtro.Add(HC.MsccatProductosFields.Canal = True)
                ProductosCol.GetMulti(Filtro)
                DgvCortes.AutoGenerateColumns = False
                DgvCortes.DataSource = ProductosCol
            End If

            If Productos Then
                Filtro.Add(HC.MsccatProductosFields.Canal = False And HC.MsccatProductosFields.Corte = False)
                ProductosCol.GetMulti(Filtro)
                DgvCortes.AutoGenerateColumns = False
                DgvCortes.DataSource = ProductosCol
            End If

            ' se deshabilitan los cortes que ya han sido seleccionados anteriormente
            If Me.DgvCortes.Rows.Count > 0 Then
                If Not Codigos Is Nothing Then
                    'Dim Tope As Integer = 0

                    For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
                        Dim index As Integer = Array.IndexOf(Me.Codigos, CInt(DgvCortes.Rows(i).Cells(Me.ClmCodigo.Index).Value))

                        If index > -1 Then
                            DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).Value = True

                            If Bloquear Then
                                DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).ReadOnly = True
                            End If
                        End If
                        'For j As Integer = 0 To Me.Codigos.Length - 1
                        'If CStr(DgvCortes.Rows(i).Cells(Me.ClmCodigo.Index).Value) = Me.Codigos(j) Then
                        'DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).Value = True

                        'If Bloquear Then
                        '    DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).ReadOnly = True
                        'End If
                        ''Tope += 1
                        'Exit For
                        'End If
                        'Next

                        'If Tope = Me.Codigos.Length - 1 Then
                        '    Exit For
                        'End If
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigo_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtCodigo.PreviewKeyDown
        Try
            If Me.txtCodigo.Text.Length > 0 Then
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        'Dim enc As Boolean
        'For i As Integer = 0 To Me.DgvCortes.Rows.Count - 1
        '    If CBool(Me.DgvCortes.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
        '        enc = True
        '        Exit For
        '    End If
        'Next
        'If enc Then
        Me.DialogResult = Windows.Forms.DialogResult.OK
        ' Else
        '  Me.DialogResult = Windows.Forms.DialogResult.Cancel
        ' End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BtnBucar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBucar.Click
        Buscar()
    End Sub
End Class