Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmBanConsultasdeSaldos


    Private Sub FrmBanConsultasdeSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        Me.mtb.Buttons(0).ToolTipText = "Busca los Registros de Depósitos Registrados"
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
        Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Registro de depósitos."
        Me.mtb.Buttons(6).ToolTipText = "Guarda el Registro de Depósito o los cambios que se le hayan Realizado."
        Me.mtb.Buttons(10).ToolTipText = "Imprime Los resgistros de Depósitos Registrados."
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        buscar()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        buscar()
    End Sub
    Private Sub buscar()
        Try
            Dim Tabla As New DataTable
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("dbo.BancosReportes", _
                        New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.CommandType = CommandType.StoredProcedure

                With ad.SelectCommand.Parameters
                    .Add("@Opcion", SqlDbType.VarChar).Value = 1
                    .Add("@FechaInicial", SqlDbType.DateTime).Value = Now.ToShortDateString
                    .Add("@FechaFinal", SqlDbType.DateTime).Value = Now.AddDays(1).ToShortDateString
                    .Add("@Banco", SqlDbType.VarChar).Value = 0
                End With

                ad.SelectCommand.CommandTimeout = 120
                ad.SelectCommand.Connection.Open()

                ad.Fill(Tabla)
                ad.SelectCommand.Connection.Close()
                Me.DataGridView1.AutoGenerateColumns = False
                Me.DataGridView1.DataSource = Tabla
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            Me.txtBanco.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(Me.Banco.Index).Value
            Me.txtTipoMoneda.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(Me.Moneda.Index).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowLeave
        'Try
        '    Me.txtBanco.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(Me.Banco.Index).Value
        '    Me.txtTipoMoneda.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(Me.Moneda.Index).Value
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class