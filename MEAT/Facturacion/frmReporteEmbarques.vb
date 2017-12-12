Imports System.Data.SqlClient

Public Class frmReporteEmbarques

#Region "Metodos"
    Private Sub ObtenerClientes()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim cadena As String = "SELECT IdCliente, Nombre FROM MFacCatClientes WHERE (Estatus = 1) ORDER BY Nombre"
            Dim sqlCom As New SqlCommand(cadena, sqlCon)
            Dim tb As New DataTable
            Dim ad As New SqlDataAdapter(sqlCom)

            sqlCon.Open()
            ad.Fill(tb)
            Me.cmbCLiente.DataSource = tb
            Me.cmbCLiente.DisplayMember = "Nombre"
            Me.cmbCLiente.ValueMember = "IdCliente"
            Me.cmbCLiente.SelectedIndex = -1
            Me.cmbCLiente.Text = "TODOS"
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los clientes", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtFolio.Clear()
        Me.txtCodigoCLiente.Clear()
        Me.cmbCLiente.SelectedIndex = -1
        Me.cmbCLiente.Text = "Seleccione un cliente..."
        Me.chkFiltrar.Checked = False
        Me.DtFechaFinal.Value = Now
        Me.dtFechaInicial.Value = Now
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmReporteEmbarques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ObtenerClientes()
        Limpiar()
    End Sub

    Private Sub chkVigente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigente.CheckedChanged
        If Not Me.chkCancelados.Checked AndAlso Not Me.chkFacturados.Checked AndAlso Not Me.chkVigente.Checked Then
            Me.chkVigente.Checked = True
            Me.chkFacturados.Checked = True
            Me.chkCancelados.Checked = True
        End If
    End Sub

    Private Sub chkFacturados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturados.CheckedChanged
        If Not Me.chkCancelados.Checked AndAlso Not Me.chkFacturados.Checked AndAlso Not Me.chkVigente.Checked Then
            Me.chkVigente.Checked = True
            Me.chkFacturados.Checked = True
            Me.chkCancelados.Checked = True
        End If
    End Sub

    Private Sub chkCancelados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCancelados.CheckedChanged
        If Not Me.chkCancelados.Checked AndAlso Not Me.chkFacturados.Checked AndAlso Not Me.chkVigente.Checked Then
            Me.chkVigente.Checked = True
            Me.chkFacturados.Checked = True
            Me.chkCancelados.Checked = True
        End If
    End Sub

    Private Sub cmbCLiente_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCLiente.ActualizarCombo
        Me.ObtenerClientes()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region
End Class