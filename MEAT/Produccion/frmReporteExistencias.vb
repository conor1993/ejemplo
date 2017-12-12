Imports System.Data.SqlClient

Public Class frmReporteExistencias

    Private Sub LlenarIntroducto()
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim consulta As String = "SELECT IdCliente, Nombre, Estatus FROM MFacCatClientes WHERE (Estatus = 1 and Introductor=1) ORDER BY Nombre"
            Dim tb As New DataTable
            Dim ad As New SqlDataAdapter(New SqlCommand(consulta, sqlCon))

            sqlCon.Open()
            ad.Fill(tb)

            Me.cmbIntroductor.DataSource = tb
            Me.cmbIntroductor.DisplayMember = "Nombre"
            Me.cmbIntroductor.ValueMember = "IdCliente"

            Me.cmbIntroductor.SelectedIndex = -1
            Me.cmbIntroductor.Text = "Seleccione un introductor.."
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los introductores", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtCodigoIntroductor.Clear()
        Me.cmbIntroductor.SelectedIndex = -1
        Me.cmbIntroductor.Text = "Seleccionar un introductor"
        Me.txtFolioSacrificio.Clear()
    End Sub

    Private Sub txtFolioSacrificio_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioSacrificio.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Dim ventana As New ReporteRegistroSacrificio

            ventana.Text = "SELECCIONE UN LOTE DE SACRIFICIO PARA EL REPORTE"
            ventana.Label17.Text = "SELECCIONE UN LOTE DE SACRIFICIO PARA EL REPORTE"
            ventana.BtnImprimir.Visible = False
            ventana.Busqueda = True

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtFolioSacrificio.Text = ventana.DgvSacrificios.SelectedRows(0).Cells(ventana.LoteSacrificio.Index).Value
            End If
        End If
    End Sub

    Private Sub frmReporteExistencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LlenarIntroducto()
    End Sub

    Private Sub cmbIntroductor_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIntroductor.ActualizarCombo
        Me.LlenarIntroducto()
    End Sub
End Class