Public Class FrmCatTiposCliente

    Dim WithEvents Ciudad As ClasesNegocio.CiudadClass
    Dim WithEvents Estados As New ClasesNegocio.EstadoCollectionClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.CiudadClass)

#Region "constuctores"
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
#End Region

    Private Sub CmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstado.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripci�n.Focus()
            If CmbEstado.Text = "" Then
                MsgBox("Agregue Informacion al Combo de Estado . . . ", MsgBoxStyle.Exclamation, "Aviso")
                CmbEstado.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescripci�n_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripci�n.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescCorta.Focus()
            If TxtDescripci�n.Text = "" Then
                MsgBox("Agregue Informaci�n a la Descripci�n . . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescripci�n.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescCorta.KeyPress
        'Para que no acepte espacios
        If e.KeyChar = Chr(32) Then
            e.Handled = True
        End If
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtObservacion.Focus()
            If TxtDescCorta.Text = "" Then
                MsgBox("Agregue Informaci�n a la Descripci�n Corta . . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescCorta.Focus()
            End If
        End If
    End Sub

    Private Sub GralCatCiudades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")

        EstadoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        LlenarGrid()

        deshabilitar()
        limpiar()
    End Sub

#Region "Metodos"

    Private Sub limpiar()
        CmbEstado.SelectedIndex = -1
        Me.CmbEstado.Text = "Seleccione un Estado..."
        Me.TxtCodigo.Clear()
        Me.TxtDescripci�n.Clear()
        Me.TxtDescCorta.Clear()
        Me.TxtObservacion.Clear()
        lblEstatus.Text = "ESTATUS"
        seleccionado = False
        Editar = False
        Me.lblEstatus.Visible = False
        Me.TxtDescripci�n.Focus()
    End Sub

    Private Sub deshabilitar()
        CmbEstado.Enabled = False
        TxtCodigo.Enabled = False
        TxtDescripci�n.Enabled = False
        TxtDescCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub habilitar()
        CmbEstado.Enabled = True
        TxtCodigo.Enabled = False
        TxtDescripci�n.Enabled = True
        TxtDescCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub guardar()
        Ciudad.CodigoEstado = CmbEstado.SelectedItem
        Ciudad.Descripcion = TxtDescripci�n.Text
        Ciudad.DescripcionCorta = TxtDescCorta.Text
        Ciudad.Observaciones = TxtObservacion.Text
    End Sub

    Private Sub LlenarGrid()
        Dim com As New SqlClient.SqlCommand

        Try
            com.CommandText = "ConsultaCiudadesXEstatus"
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@Estatus", SqlDbType.SmallInt).Value = ClasesNegocio.CondicionEnum.TODOS
            com.Connection = New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

            Dim ad As New SqlClient.SqlDataAdapter

            ad.SelectCommand = com
            com.Connection.Open()

            Dim tb As New DataTable

            ad.Fill(tb)

            DataGrid.AutoGenerateColumns = False
            Me.DataGrid.DataSource = tb
            ClmCodigo.DataPropertyName = "C�digo"
            ClmDescripcion.DataPropertyName = "Descripci�n"
            ClmDescripcionCorta.DataPropertyName = "Descripci�n Corta"
            ClmEstado.DataPropertyName = "Estado"
            ClmObservaciones.DataPropertyName = "Observaciones"
            ClmEstatus.DataPropertyName = "Estatus"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            com.Connection.Close()
        End Try
    End Sub

#End Region

    Private Sub Ciudad_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Ciudad.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Information, "Aviso")
        Select Case sender.ToString
            Case "Descripcion"
                Me.TxtDescripci�n.Focus()
            Case "DescripcionCorta"
                Me.TxtDescCorta.Focus()
        End Select
    End Sub

    Private Sub Ciudad_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ciudad.Modificado
        If puedorefrescar Then
            CmbEstado.SelectedValue = Ciudad.CodigoEstado.Codigo
            TxtCodigo.Text = Ciudad.Codigo
            TxtDescripci�n.Text = Ciudad.Descripcion
            TxtDescCorta.Text = Ciudad.DescripcionCorta
            TxtObservacion.Text = Ciudad.Observaciones
            lblEstatus.Text = Ciudad.Estatus.ToString
        End If
    End Sub

    Private Sub MEAToolBar_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub MEAToolBar_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        If Ciudad.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            habilitar()
            Editar = True
            Me.TxtDescripci�n.Focus()
        Else
            If MessageBox.Show("La Ciudad esta inactiva, �Desea Activarla?", "Activar Ciudad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Ciudad.CodigoEstado.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                    Ciudad.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblEstatus.Text = Ciudad.Estatus.ToString
                    habilitar()
                    Me.TxtDescripci�n.Focus()
                    Editar = True
                Else
                    MsgBox(String.Format("No es posible activarla, primero debe activar el estado {0}", Ciudad.CodigoEstado.Descripcion), MsgBoxStyle.Exclamation, "Estado Inactivo")
                    Cancelar = True
                    mtb.sbCambiarEstadoBotones("Guardar")
                    limpiar()
                    deshabilitar()
                End If
            Else
                Cancelar = True
                mtb.sbCambiarEstadoBotones("Guardar")
                limpiar()
                deshabilitar()
            End If
        End If
    End Sub

    Private Sub MEAToolBar_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try

            If Me.TxtDescripci�n.Text = "" Then
                MsgBox("Debe ingresar una descripci�n", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = False
                Exit Sub
            End If

            If Me.TxtDescCorta.Text = "" Then
                MsgBox("Debe ingresar una descripci�n corta", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            If Me.CmbEstado.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar un estado", MsgBoxStyle.Exclamation, "Faltan Datos")
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If Ciudad.Guardar Then
                If Editar Then
                    MsgBox("La Ciudad se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Ciudad se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If

                limpiar()
                deshabilitar()
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

    Private Sub MEAToolBar_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar
        If Ciudad.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            If Ciudad.Borrar Then
                MsgBox("La Ciudad ha sido Inactivada.", MsgBoxStyle.Information, "Aviso")
                deshabilitar()
                LlenarGrid()
                limpiar()
            Else
                Cancelar = True
            End If
        Else
            MsgBox("La Ciudad Ya esta Inactivada.", MsgBoxStyle.Exclamation, "Aviso")
            limpiar()
            deshabilitar()
        End If
    End Sub

    Private Sub MEAToolBar_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If seleccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        limpiar()
        habilitar()
        Editar = False
        Ciudad = New ClasesNegocio.CiudadClass
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        If DataGrid.SelectedRows.Count > 0 Then
            Ciudad = New ClasesNegocio.CiudadClass
            Ciudad.Obtener(DataGrid.SelectedRows(0).Cells(0).Value)
            Ciudad_Modificado(Me, e)
            mtb.sbCambiarEstadoBotones("Buscar")
            seleccionado = True
            Me.lblEstatus.Visible = True
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Cursor = Cursors.WaitCursor
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Dim Ciudad As New ClasesNegocio.CiudadCollectionClass
            Ciudad.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If Ciudad.Count.ToString > 0 Then
                Previsualizar.Text = "Reporte Ciudades"
                Previsualizar.Reporte = Ciudad.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                Previsualizar.ShowDialog()
            Else
                MsgBox("No se enconto ninguna Ciudad", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

End Class