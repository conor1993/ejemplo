Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports System.Data.SqlClient
Public Class FrmComparativoFisicoLibrosProduccion
    Dim Band As Boolean = False
    Private Sub FrmComparativoFisicoLibrosProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Almacen As New CN.AlmacenClass
            Dim AlmacenesCol As New CN.AlmacenCollectionClass
            'AlmacenesCol.Add(Almacen)

            Dim AuxCol As New CN.AlmacenCollectionClass
            AuxCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            For Each Alm As CN.AlmacenClass In AuxCol
                AlmacenesCol.Add(Alm)
            Next


            CmbAlmacenes.SelectedIndex = -1
            CmbAlmacenes.ValueMember = "Codigo"
            CmbAlmacenes.DisplayMember = "Descripcion"
            CmbAlmacenes.DataSource = AlmacenesCol
            Band = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CmbAlmacenes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.SelectedIndexChanged
        If Band = False Then
            Exit Sub
        End If

        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Band = False
            Dim sqlCom As New SqlCommand("INVComparativoProduccion", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)
            'Dim reporte As New rptFacturaVentasPorCliente
            'Dim prev As New ClasesNegocio.PreVisualizarForm

            sqlCom.CommandType = CommandType.StoredProcedure

            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '1 para filtrar por almacen
                '2 para filtrar por producto
                .Add("@Opcion", SqlDbType.SmallInt).Value = 1
                .Add("@Almacen", SqlDbType.SmallInt).Value = Me.CmbAlmacenes.SelectedValue
                .Add("@IdProducto", SqlDbType.SmallInt).Value = 0

            End With

            sqlCon.Open()

            ad.Fill(ds)

            If ds.Tables(0) Is Nothing Then
                MsgBox("No existe información para comparativo", MsgBoxStyle.Information, "")
            Else
                Me.DataGridView1.AutoGenerateColumns = False
                Me.DataGridView1.DataSource = ds.Tables(0)
                Band = True
            End If

            'reporte.SetDataSource(ds.Tables(0))
            'reporte.Subreports(0).SetDataSource(ds.Tables(1))
            'reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            'reporte.SetParameterValue(1, "Ventas/Reportes/Facturas Por Cliente Detallada")
            'reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            'reporte.SetParameterValue(3, Me.dtFechaInicial.Value)
            'reporte.SetParameterValue(4, Me.dtFechaFinal.Value)

            'prev.Reporte = reporte
            'prev.Text = "Reporte de Facturas por Cliente Detallada"
            'prev.Icon = Icon
            'prev.StartPosition = FormStartPosition.CenterScreen
            'prev.WindowState = FormWindowState.Maximized
            ''reporte.SaveAs("c:\tempRpt\Reporte", True)
            'prev.ShowDialog()
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

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Report As New CN.RptInventFisico
            Report.SetDataSource(Me.DataGridView1.DataSource)
            Report.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Report.SetParameterValue(1, "Inventarios / Comparación de Inventario")
            Report.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)

            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Report
            VerReporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.CmbAlmacenes.SelectedIndex = 0
        Me.DataGridView1.DataSource = Nothing
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    

   
    Private Sub ExistenciasLibros(ByVal renglon As Integer)
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("INVComparativoProduccion", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)

            sqlCom.CommandType = CommandType.StoredProcedure

            'existencias libros
            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '0 para filtrar por almacen
                '1 para filtrar por producto
                .Add("@Opcion", SqlDbType.SmallInt).Value = 2
                .Add("@Almacen", SqlDbType.SmallInt).Value = Me.CmbAlmacenes.SelectedValue
                .Add("@IdProducto", SqlDbType.SmallInt).Value = Me.DataGridView1.Rows(renglon).Cells(Me.clmProductoId.Index).Value

            End With

            sqlCon.Open()

            ad.Fill(ds)

            Me.DataGridView2.AutoGenerateColumns = False
            Me.DataGridView2.DataSource = ds.Tables(0)

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

    Private Sub ExistenciasFisicas(ByVal renglon As Integer)
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("INVComparativoProduccion", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)

            sqlCom.CommandType = CommandType.StoredProcedure


            'existencias fisicas
            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '0 para filtrar por almacen
                '1 para filtrar por producto
                .Add("@Opcion", SqlDbType.SmallInt).Value = 3
                .Add("@Almacen", SqlDbType.SmallInt).Value = Me.CmbAlmacenes.SelectedValue
                .Add("@IdProducto", SqlDbType.SmallInt).Value = Me.DataGridView1.Rows(renglon).Cells(Me.clmProductoId.Index).Value

            End With

            sqlCon.Open()

            ad.Fill(ds)

            Me.DataGridView3.AutoGenerateColumns = False
            Me.DataGridView3.DataSource = ds.Tables(0)
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

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If e.RowIndex > -1 And Band = True Then
            ExistenciasLibros(e.RowIndex)
            ExistenciasFisicas(e.RowIndex)
            Comparativo()
        End If
    End Sub

    Private Sub Comparativo()
        Try
            Dim Encontrado As Boolean            
            For i As Integer = 0 To Me.DataGridView2.RowCount - 1
                'Encontrado = True
                For j As Integer = 0 To Me.DataGridView3.RowCount - 1
                    If Me.DataGridView2.Rows(i).Cells("clmEtiqueta").Value = Me.DataGridView3.Rows(j).Cells("clmEtiquetaFisica").Value Then
                        Encontrado = True
                        Exit For
                    Else
                        Encontrado = False
                    End If
                Next
                If Not Encontrado Then
                    Me.DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Chocolate
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub
End Class