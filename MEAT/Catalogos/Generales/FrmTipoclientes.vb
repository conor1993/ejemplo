Imports System.Data.SqlClient

Public Class FrmTipoclientes

    Dim tipocliente = New ClasesNegocio.TipoClientesClass
    Dim WithEvents tipoclientes As New ClasesNegocio.tiposclienteCollectionClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False

    Private Sub FrmTipoclientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100001"
        MtbEstados.StateEditar = "0010100001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        llenargrid()
        Deshabilitar()
        Me.lblEstatus.Visible = False
    End Sub
#Region "METODOS"

    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.dtpFecha.Value = Now
        Me.txtDescripcion.Clear()
        Me.txtDescripcionCorta.Clear()
        Me.TxtObservacion.Clear()
        Me.lblEstatus.Visible = False
        lblEstatus.Text = "ESTATUS"
    End Sub

    Private Sub Deshabilitar()
        txtCodigo.Enabled = False
        dtpFecha.Enabled = False
        txtDescripcion.Enabled = False
        txtDescripcionCorta.Enabled = False
        TxtObservacion.Enabled = False
        DataGrid.Enabled = True
    End Sub

    Private Sub Habilitar()
        txtCodigo.Enabled = False
        dtpFecha.Enabled = True
        txtDescripcion.Enabled = True
        txtDescripcionCorta.Enabled = True
        TxtObservacion.Enabled = True
        DataGrid.Enabled = False
    End Sub

    Private Sub Guardar()
        Try

            tipocliente.Descripcion = txtDescripcion.Text
            tipocliente.DescripcionCorta = txtDescripcionCorta.Text
            tipocliente.ObserVaciones = TxtObservacion.Text
            tipocliente.FechaAlta = dtpFecha.Value
            tipocliente.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "botones laterales"

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar

    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar


    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If tipocliente.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Editar = True
        Else
            MessageBox.Show("El Tipo de Cliente esta Inactivo No se Puede Editar.")
            Editar = False
            Cancelar = True
            MEAToolBar1.sbCambiarEstadoBotones("Guardar")
            Limpiar()
            Deshabilitar()
        End If

    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar

        Guardar()

        If txtDescripcion.Text = "" Or txtDescripcionCorta.Text = "" Then
            MessageBox.Show("La Descripción y Descripción Corta es Obligatoria Agregue Información ")
            Cancelar = True
        Else
            If tipocliente.Guardar Then
                MessageBox.Show("El Tipo de Cliente se ha guardado satisfactoriamente.")
                Limpiar()
                Deshabilitar()
                llenargrid()
            Else
                Cancelar = True
            End If
        End If

    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir


    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar


    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Limpiar()
        Habilitar()
        tipocliente = New ClasesNegocio.TipoClientesClass()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

#End Region

    Private Sub DataGrid_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGrid.DoubleClick
        If Me.DataGrid.SelectedRows.Count > 0 Then
            tipocliente = New ClasesNegocio.TipoClientesClass
            tipocliente.Obtener(DataGrid.SelectedRows(0).Cells(0).Value)
            txtDescripcion.Text = tipocliente.Descripcion
            txtDescripcionCorta.Text = tipocliente.DescripcionCorta
            txtCodigo.Text = tipocliente.Codigo
            puedorefrescar = True
            puedorefrescar = False
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.lblEstatus.Visible = True

        End If
    End Sub

    Private Sub llenargrid()

        tipoclientes.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        DataGrid.AutoGenerateColumns = False
        DataGrid.DataSource = tipoclientes
    End Sub

End Class