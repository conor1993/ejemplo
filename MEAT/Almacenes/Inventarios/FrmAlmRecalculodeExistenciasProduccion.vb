Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports System.Data.SqlClient

Public Class FrmAlmRecalculodeExistenciasProduccion

    Private Sub FrmAlmRecalculodeExistenciasProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim AlmacenesCol As New CN.AlmacenCollectionClass
            'AlmacenesCol.ObtenerDeProduccion()

            'Me.txtAlmacenCanal.Text = AlmacenesCol.Item(0).Descripcion
            'Me.txtAlmacenCorte.Text = AlmacenesCol.Item(1).Descripcion
            'Me.txtAlmacenProducto.Text = AlmacenesCol.Item(2).Descripcion
            'Me.txtAlmacenDecomiso.Text = AlmacenesCol.Item(3).Descripcion

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   
    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)
        Dim Productos As New CN.ProductosCollectionsClass

        Try
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                MsgBox("No existe configuración de producción", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            'almacenes
            If Me.chkAlmacenCanal.Checked Then
                Dim sqlCom As New SqlCommand("INVRecalculoExistencias", sqlCon)
                Dim ds As New DataSet
                'Dim ad As New SqlDataAdapter(sqlCom)
                'Dim reporte As New rptFacturaVentasPorCliente
                'Dim prev As New ClasesNegocio.PreVisualizarForm

                sqlCom.CommandType = CommandType.StoredProcedure

                With sqlCom.Parameters
                    'las Opciones para usar el procedimiento son
                    '1 para filtrar por almacen
                    '2 para filtrar por producto
                    .Add("@Almacen", SqlDbType.SmallInt).Value = Controlador.Configuracion.Produccion.IdAlmacenCanales
                    .Add("@Año", SqlDbType.SmallInt).Value = Year(Me.dtpFecha.Value)
                    .Add("@Mes", SqlDbType.SmallInt).Value = Month(Me.dtpFecha.Value)

                End With

                sqlCon.Open()

                sqlCom.ExecuteNonQuery()

                MsgBox("Se actualizo almacen de canales en forma correcta", MsgBoxStyle.Information, "")

                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If

            End If
            'cortes
            If Me.chkAlmacenCorte.Checked Then


                Dim sqlCom As New SqlCommand("INVRecalculoExistencias", sqlCon)
                Dim ds As New DataSet
                'Dim ad As New SqlDataAdapter(sqlCom)
                'Dim reporte As New rptFacturaVentasPorCliente
                'Dim prev As New ClasesNegocio.PreVisualizarForm

                sqlCom.CommandType = CommandType.StoredProcedure

                With sqlCom.Parameters
                    'las Opciones para usar el procedimiento son
                    '1 para filtrar por almacen
                    '2 para filtrar por producto
                    .Add("@IdAlmacen", SqlDbType.SmallInt).Value = Controlador.Configuracion.Produccion.IdAlmacenesCortes
                    .Add("@Año", SqlDbType.SmallInt).Value = Year(Me.dtpFecha.Value)
                    .Add("@Mes", SqlDbType.SmallInt).Value = Month(Me.dtpFecha.Value)

                End With

                sqlCon.Open()

                sqlCom.ExecuteNonQuery()



                MsgBox("Se actualizo almacen de cortes en forma correcta", MsgBoxStyle.Information, "")

                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If

            End If

            If Me.chkAlmacenDecomiso.Checked Then
                Dim sqlCom As New SqlCommand("INVRecalculoExistencias", sqlCon)
                Dim ds As New DataSet
                'Dim ad As New SqlDataAdapter(sqlCom)
                'Dim reporte As New rptFacturaVentasPorCliente
                'Dim prev As New ClasesNegocio.PreVisualizarForm

                sqlCom.CommandType = CommandType.StoredProcedure

                With sqlCom.Parameters
                    'las Opciones para usar el procedimiento son
                    '1 para filtrar por almacen
                    '2 para filtrar por producto
                    .Add("@Almacen", SqlDbType.SmallInt).Value = Controlador.Configuracion.Produccion.IdAlmacenDecomisos
                    .Add("@Año", SqlDbType.SmallInt).Value = Year(Me.dtpFecha.Value)
                    .Add("@Mes", SqlDbType.SmallInt).Value = Month(Me.dtpFecha.Value)

                End With

                sqlCon.Open()

                sqlCom.ExecuteNonQuery()

                MsgBox("Se actualizo almacen de decomisos en forma correcta", MsgBoxStyle.Information, "")

                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If

            End If
            'productos
            If Me.chkAlmacenProductos.Checked Then
                Dim sqlCom As New SqlCommand("INVRecalculoExistencias", sqlCon)
                Dim ds As New DataSet
                Dim ad As New SqlDataAdapter(sqlCom)
                'Dim reporte As New rptFacturaVentasPorCliente
                'Dim prev As New ClasesNegocio.PreVisualizarForm

                sqlCom.CommandType = CommandType.StoredProcedure

                With sqlCom.Parameters
                    'las Opciones para usar el procedimiento son
                    '1 para filtrar por almacen
                    '2 para filtrar por producto
                    .Add("@Almacen", SqlDbType.SmallInt).Value = Controlador.Configuracion.Produccion.IdAlmacenProductos
                    .Add("@Año", SqlDbType.SmallInt).Value = Year(Me.dtpFecha.Value)
                    .Add("@Mes", SqlDbType.SmallInt).Value = Month(Me.dtpFecha.Value)

                End With

                sqlCon.Open()

                sqlCom.ExecuteNonQuery()

                MsgBox("Se actualizo almacen de productos en forma correcta", MsgBoxStyle.Information, "")

                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If

            End If


        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al mostrar el reporte", MsgBoxStyle.Critical, "Error")
#End If
            'Finally
            '    If sqlCon.State = ConnectionState.Open Then
            '        sqlCon.Close()
            '    End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.chkAlmacenCanal.Checked = False
        Me.chkAlmacenCorte.Checked = False
        Me.chkAlmacenDecomiso.Checked = False
        Me.chkAlmacenProductos.Checked = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class