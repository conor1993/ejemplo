Imports CN = ClasesNegocio
Imports System.Data.SqlClient

Public Class frmReporteFactura
    Dim Clientes As New CN.ClientesIntroductoresColeccion
    Private Sub frmReporteFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim fileContents As String = String.Empty
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            'Me.mtb.sbCambiarEstadoBotones("Nuevo")

            Clientes.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            Me.cmbClientes.DisplayMember = "Nombre"
            Me.cmbClientes.ValueMember = "Codigo"
            Me.cmbClientes.DataSource = Clientes
            Me.cmbClientes.Text = "Todos"

            Me.Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Métodos"

    Sub Habilitar()
        Me.cmbClientes.Enabled = True
        Me.dtpFechaFinal.Enabled = True
        Me.dtpFechaInicial.Enabled = True

    End Sub

    Sub Deshabilitar()
        Me.cmbClientes.Enabled = False
        Me.dtpFechaFinal.Enabled = False
        Me.dtpFechaInicial.Enabled = False
       
    End Sub

    Sub Limpiar()
        Me.cmbClientes.SelectedIndex = -1
        Me.dtpFechaFinal.Value = DateTime.Now.ToShortDateString
        Me.dtpFechaInicial.Value = DateTime.Now.ToShortDateString
  
    End Sub

    Private Sub Imprimir()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("FacturasGenerales", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)
            Dim reporte As New rptCXCFacturasGenerales
            Dim prev As New ClasesNegocio.PreVisualizarForm
            Dim totalReal As New Double

            sqlCom.CommandType = CommandType.StoredProcedure

            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '1 todos los clientes en un rango de fechas
                '2 un cliente con un rango de fechas

                If Me.cmbClientes.SelectedIndex > -1 Then
                    .Add("@idCliente", SqlDbType.Int).Value = Me.cmbClientes.SelectedValue
                    .Add("@FechaIni", SqlDbType.DateTime).Value = Me.dtpFechaInicial.Value.ToShortDateString
                    .Add("@FechaFin", SqlDbType.DateTime).Value = Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString
                    .Add("@Opcion", SqlDbType.Int).Value = 2
                Else
                    .Add("@idCliente", SqlDbType.Int).Value = 0
                    .Add("@FechaIni", SqlDbType.DateTime).Value = Me.dtpFechaInicial.Value.ToShortDateString
                    .Add("@FechaFin", SqlDbType.DateTime).Value = Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString
                    .Add("@Opcion", SqlDbType.Int).Value = 1
                End If
               
            End With

            sqlCon.Open()

            ad.Fill(ds)
            'FechaFactura, NoFactura

            Dim Rows() As DataRow
            Dim datosOrdenados As DataTable = ds.Tables(0).Clone()

            If rbnFecha.Checked Then
                Rows = ds.Tables(0).Select("", "FechaFactura asc")
            Else
                Rows = ds.Tables(0).Select("", "NoFactura asc")
            End If

            For Each row As DataRow In Rows
                datosOrdenados.Rows.Add(row.ItemArray)
            Next

            'Se obtien el total, sumando los ingresos y restando los egresos

            'Dim indice As Integer = 0
            'For Each row As DataRow In datosOrdenados.Rows

            '    If (datosOrdenados.Rows(indice)(8) = "I") Then
            '        totalReal += datosOrdenados.Rows(indice)(3)
            '    ElseIf (datosOrdenados.Rows(indice)(8) = "E") Then
            '        totalReal -= datosOrdenados.Rows(indice)(3)
            '    End If

            '    indice += 1
            '    totalReal = Math.Round(totalReal, 2)

            'Next
            reporte.SetDataSource(datosOrdenados)
            'reporte.Subreports(0).SetDataSource(ds.Tables(1))
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            'reporte.SetParameterValue(1, "Ventas/Reportes/Facturas Generales por Cliente y Cargo a Cliente")
            reporte.SetParameterValue(3, Controlador.Sesion.MiUsuario.Usrnomcom)
            reporte.SetParameterValue(2, Me.dtpFechaInicial.Value)
            reporte.SetParameterValue(1, Me.dtpFechaFinal.Value)
            prev.Reporte = reporte

            prev.Text = "Reporte de Facturas Generales por Cliente y Cargo a Cliente"
            prev.Icon = Icon
            prev.StartPosition = FormStartPosition.CenterScreen
            prev.WindowState = FormWindowState.Maximized
            'reporte.SaveAs("c:\tempRpt\Reporte", True)
            prev.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al mostrar el reporte", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub
    

#End Region


#Region "Key Press"
    Private Sub cmbClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbClientes.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.dtpFechaInicial.Focus()
        End If
    End Sub

    

#End Region

#Region "Tool Bar"

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Try
            Imprimir()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class