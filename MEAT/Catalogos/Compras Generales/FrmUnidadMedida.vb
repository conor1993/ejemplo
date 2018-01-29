Imports System.Data.SqlClient
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmUnidadMedida

    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim WithEvents UnidadMedida As New ClasesNegocio.UnidadesMedidaClass
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.UnidadesMedidaClass)

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDesCta.Focus()
            If txtDescripcion.Text = "" Then
                MsgBox("Agregue Información a la Descripción . . . ", MsgBoxStyle.Exclamation, "Faltan Datos")
                txtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub txtDesCta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesCta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtObservacion.Focus()
            If txtDesCta.Text = "" Then
                MsgBox("Agregue Información a la Descripción Corta. . . ", MsgBoxStyle.Exclamation, "Faltan Datos")
                txtDesCta.Focus()
            End If
        End If
        'Impedir que pueda teclear Espacios
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        txtCodigo.Clear()
        dtpFecha.Value = Now
        txtDescripcion.Clear()
        txtDesCta.Clear()
        txtObservacion.Clear()
        seleccionado = False
        Editar = False
        Me.LblEstatus.Visible = False
        Me.txtDescripcion.Focus()
        CmbClaveSAT.SelectedItem = Nothing

    End Sub

    Private Sub Habilitar()
        txtDescripcion.Enabled = True
        txtDesCta.Enabled = True
        txtObservacion.Enabled = True
        DataGrid.Enabled = False
        CmbClaveSAT.Enabled = True

    End Sub

    Private Sub DesHabilitar()
        txtDescripcion.Enabled = False
        txtDesCta.Enabled = False
        txtObservacion.Enabled = False
        DataGrid.Enabled = True
        CmbClaveSAT.Enabled = False

    End Sub

    Private Sub Guardar()
        UnidadMedida.FechaAlta = dtpFecha.Value
        UnidadMedida.Descripcion = txtDescripcion.Text
        UnidadMedida.DescCorta = txtDesCta.Text
        UnidadMedida.Observaciones = txtObservacion.Text
        UnidadMedida.Claveunidadsat = CmbClaveSAT.SelectedValue
    End Sub

    Private Function Validar() As Boolean
        If Me.txtDescripcion.Text = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtDescripcion.Focus()
            Return False
        End If

        If Me.txtDesCta.Text = "" Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos ")
            Me.txtDesCta.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaUnidadMedidaXEstatus"
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@Estatus", SqlDbType.SmallInt).Value = ClasesNegocio.CondicionEnum.TODOS
            com.Connection = New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

            Dim ad As New SqlClient.SqlDataAdapter

            ad.SelectCommand = com
            com.Connection.Open()

            Dim tb As New DataTable

            ad.Fill(tb)

            Me.DataGrid.AutoGenerateColumns = False
            Me.DataGrid.DataSource = tb
            ClmCodigo.DataPropertyName = "Código"
            ClmDescripcion.DataPropertyName = "Descripción"
            ClmDescripcionCorta.DataPropertyName = "Descripción Corta"
            ClmObservaciones.DataPropertyName = "Observaciones"
            ClmFechaAlta.DataPropertyName = "Fecha de Alta"
            ClmEstatus.DataPropertyName = "Estatus"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            com.Connection.Close()
        End Try
    End Sub

#End Region

    Private Sub UnidadMedida_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles UnidadMedida.Modificado
        If puedorefrescar Then
            txtCodigo.Text = UnidadMedida.Codigo
            dtpFecha.Value = UnidadMedida.FechaAlta
            txtDescripcion.Text = UnidadMedida.Descripcion
            txtDesCta.Text = UnidadMedida.DescCorta
            txtObservacion.Text = UnidadMedida.Observaciones
            LblEstatus.Text = UnidadMedida.Estatus.ToString
            CmbClaveSAT.SelectedValue = UnidadMedida.Claveunidadsat
        End If
    End Sub

    Private Sub UnidadMedida_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles UnidadMedida.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub FrmUnidadMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "010101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        LlenarGrid()
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT * FROM CatUnidadSAT"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            Me.CmbClaveSAT.DataSource = FormasPago.Tables(0)
            Me.CmbClaveSAT.DisplayMember = "concepto"
            Me.CmbClaveSAT.ValueMember = "clave"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DesHabilitar()
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        Try
            If UnidadMedida.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If UnidadMedida.Borrar Then
                    MsgBox("La Unidad de Medida ha sido Inactivada.", MsgBoxStyle.Information, "Aviso")
                    DesHabilitar()
                    LlenarGrid()
                    Limpiar()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("La Unidad de Medida Ya esta Inactivada.", MsgBoxStyle.Exclamation, "Aviso")
                Limpiar()
                DesHabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        Cursor = Cursors.WaitCursor
        If UnidadMedida.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Editar = True
            Me.txtDescripcion.Focus()
        Else
            If MessageBox.Show("La Unidad de Medida esta Inactiva, ¿Desea Activarla?", "Activar Unidad de Medida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                UnidadMedida.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.LblEstatus.Text = UnidadMedida.Estatus.ToString
                Habilitar()
                Editar = True
                Me.txtDescripcion.Focus()
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                DesHabilitar()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            Guardar()
            puedorefrescar = True

            If UnidadMedida.Guardar Then
                If Editar Then
                    MsgBox("La Unidad de Medida se ha modificado Satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Unidad de Medida se ha Guardado Satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If

                DesHabilitar()
                Limpiar()
                LlenarGrid()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            UnidadesMedidaC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim Reporte As New ClasesNegocio.rptABCUnidadesMedida
            Dim VerReporte As New FrmReportes
            Reporte.SetDataSource(UnidadesMedidaC)
            Reporte.SetParameterValue(2, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, "Catalogos\Compras Generales\Familias")
            Reporte.SetParameterValue(0, Controlador.Sesion.MiUsuario.Usrnomcom)
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()

            'Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            'Previsualizar.Text = "Reporte de ABC de Unidades de Medida"
            'Previsualizar.Reporte = UnidadesMedidaC.Reporte
            'Previsualizar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.seleccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Habilitar()
        Limpiar()
        UnidadMedida = New ClasesNegocio.UnidadesMedidaClass()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Cursor = Cursors.WaitCursor
        Try
            If DataGrid.SelectedRows.Count > 0 Then
                UnidadMedida = New ClasesNegocio.UnidadesMedidaClass
                UnidadMedida.Obtener(DataGrid.SelectedRows(0).Cells(0).Value)

                puedorefrescar = True
                UnidadMedida_Modificado(Me, e)
                puedorefrescar = False

                MEAToolBar1.sbCambiarEstadoBotones("Buscar")
                Me.seleccionado = True
                Me.LblEstatus.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
End Class