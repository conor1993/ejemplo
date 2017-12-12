Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Public Class _660ReportedeCanales


    Private Sub _660ReportedeCanales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
#Region "Metodos"
    Private Sub Limpiar()
        Me.txtFolioSacrificio.Text = ""
        Me.DtpFechaInicio.Value = Now
        Me.DtpFechaFinal.Value = Now
        Me.dgvDetalleCanales.DataSource = Nothing
        Me.dgvRegistroCanales.DataSource = Nothing
    End Sub

    Private Sub Deshabilitar()

    End Sub

    Private Sub Habilitar()

    End Sub

    Private Function Validar() As Boolean
        Try


            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Guardar()

    End Sub

    Private Sub Imprimir()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Vista As New TC.VwProdRegistroCanalesTypedView
            Dim Filtro As New OC.PredicateExpression

            If Not Me.txtFolioSacrificio.Text = "" Then
                Filtro.Add(HC.VwProdRegistroCanalesFields.FolioSacrificio Mod String.Format("%{0}%", Me.txtFolioSacrificio.Text))
            End If

            If Not Me.DtpFechaInicio.Value > Me.DtpFechaFinal.Value Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwProdRegistroCanalesFields.FechaSacrificio, Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString))
            End If

            Vista.Fill(0, Nothing, False, Filtro)

            Me.dgvDetalleCanales.AutoGenerateColumns = False
            Me.dgvDetalleCanales.DataSource = Vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

  
End Class