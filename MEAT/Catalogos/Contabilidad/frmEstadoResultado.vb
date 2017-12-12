Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmEstadoResultado
#Region "Miembros"
    Private WithEvents estadoResultado As EstadoResultadoClass

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtDescripcion.Clear()
        Me.txtRubro.Clear()
        Me.DataGridView1.DataSource = Nothing
        Me.cmbCategoria.SelectedIndex = -1
        Me.cmbCategoria.Text = "Seleccione la categoria"
    End Sub

    Private Sub Deshabilitar()
        Me.txtRubro.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.DataGridView1.Enabled = False
        Me.cmbCategoria.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.txtRubro.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.DataGridView1.Enabled = True
        Me.cmbCategoria.Enabled = True
    End Sub

    Private Sub PasarValores()
        estadoResultado.Descripcion = Me.txtDescripcion.Text
        estadoResultado.Rubro = Me.txtRubro.Text
        'estadoResultado.IdAgrupador = cmbCategoria.SelectedValue
    End Sub

    Private Sub ObtenerValores()
        Me.txtDescripcion.Text = estadoResultado.Descripcion
        Me.txtRubro.Text = estadoResultado.Rubro
        'Me.cmbCategoria.SelectedValue = estadoResultado.IdAgrupador
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.DataSource = estadoResultado.Detalle
    End Sub

    Private Function CuentaValida(ByVal itemSel As ClasesNegocio.EstadoResultadoDetalleClass, ByVal detalle As ClasesNegocio.EstadoResultadoDetalleCollectionClas) As Boolean
        If itemSel.CuentaMayor = "0000" AndAlso itemSel.SubCuenta = "0000" AndAlso itemSel.SSubCuenta = "0000" AndAlso itemSel.SSSubCuenta = "0000" Then
            detalle.Remove(itemSel)
        Else
            For Each det As ClasesNegocio.EstadoResultadoDetalleClass In detalle
                If det.CuentaMayor = itemSel.CuentaMayor AndAlso det.SubCuenta = itemSel.SubCuenta AndAlso det.SSubCuenta = itemSel.SSubCuenta AndAlso det.SSSubCuenta = itemSel.SSSubCuenta AndAlso Not itemSel.Equals(det) Then
                    MsgBox("La cuenta ya se encuentra en el listado", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    detalle.Remove(itemSel)
                    Return False
                    Exit For
                End If
            Next
        End If
        Return True
    End Function
#End Region

#Region "Eventos"
    Private Sub frmEstadoResultado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "001101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = MtbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            cmbCategoria.ValueMember = "Código"
            cmbCategoria.DisplayMember = "Descripcion"
            cmbCategoria.DataSource = CatAgrupadoresBalGralEdoResCollectionClass.CargarAgrupadoresBalanceGral(HC.CatAgrupadoresBalGralEdoResFields.BalanceGral = False)
            Limpiar()
            Deshabilitar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al abrir la ventana de estado de resultado", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating
        If e.RowIndex > estadoResultado.Detalle.Count - 1 Then
            Exit Sub
        End If

        Me.CuentaValida(Me.estadoResultado.Detalle(e.RowIndex), Me.estadoResultado.Detalle)

        If DataGridView1.Rows(e.RowIndex).Cells(SumaORestaDataGridViewTextBoxColumn.Index).Value.ToString() <> "-" And DataGridView1.Rows(e.RowIndex).Cells(SumaORestaDataGridViewTextBoxColumn.Index).Value.ToString() <> "+" Then
            MsgBox("No se ha establecido el tipo de operacion (+/-) en la cuenta, Especifiquela", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.RowIndex > -1 Then
            If e.ColumnIndex = Me.SumaORestaDataGridViewTextBoxColumn.Index Then
                Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = Not (estadoResultado.Detalle(e.RowIndex).Seleccionado OrElse CType(estadoResultado.Detalle(e.RowIndex).CuentaContable.Resultado, Boolean))
            End If
        End If
    End Sub

    Private Sub DataGridView1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DataGridView1.PreviewKeyDown
        If e.KeyCode = Keys.F3 AndAlso Me.DataGridView1.Enabled Then
            Dim ventana As New BusquedaCuentasContablesForm

            ventana.ResultadosDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim detalle As New ClasesNegocio.EstadoResultadoDetalleClass

                detalle.CuentaContable = ventana.CuentaContable

                If CuentaValida(detalle, estadoResultado.Detalle) Then
                    Me.estadoResultado.Detalle.CancelNew(Me.estadoResultado.Detalle.Count - 1)
                    estadoResultado.Detalle.Add(detalle)
                End If
            End If
        ElseIf e.KeyCode = Keys.Delete AndAlso Me.DataGridView1.Enabled Then
            If Me.DataGridView1.SelectedCells(0).RowIndex <= Me.estadoResultado.Detalle.Count - 1 Then
                If Me.estadoResultado.Detalle(Me.DataGridView1.SelectedCells(0).RowIndex).SaldoAumulado = 0D AndAlso _
                    Me.estadoResultado.Detalle(Me.DataGridView1.SelectedCells(0).RowIndex).SaldoMes = 0D Then
                    Me.estadoResultado.Detalle.RemoveAt(Me.DataGridView1.SelectedCells(0).RowIndex)
                End If
            End If
        End If
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim ventana As New frmBusquedaEstadoResultado

            ventana.Icon = Me.Icon

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                estadoResultado = TryCast(ventana.dgEstadoResultado.SelectedRows(0).DataBoundItem, ClasesNegocio.EstadoResultadoClass)
                'cmbCategoria.DataSource = CatAgrupadoresBalGralEdoResCollectionClass.CargarAgrupadoresBalanceGral(HC.CatAgrupadoresBalGralEdoResFields.BalanceGral = False)
                Me.ObtenerValores()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
                Me.txtDescripcion.Focus()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los estados de resultados", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            Cursor = Cursors.WaitCursor

            Me.txtDescripcion.Enabled = True
            Me.DataGridView1.Enabled = True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al editar el estado de resultado", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Me.Validate() Then
                Cursor = Cursors.WaitCursor

                If Me.DataGridView1.Rows.Count > 0 Then
                    Me.DataGridView1.Rows(0).Cells(0).Selected = True
                End If

                Me.PasarValores()

                If estadoResultado.Guardar Then
                    MsgBox("Se ha guardado el estado de resultado", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Deshabilitar()
                Else
                    Cancelar = True
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar el estado de resutlado", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        estadoResultado = New ClasesNegocio.EstadoResultadoClass
        Me.EstadoResultadoDetalleC = estadoResultado.Detalle
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.DataSource = Me.EstadoResultadoDetalleC
        Me.txtRubro.Focus()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub txtRubro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRubro.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Or (txtRubro.Text.Length > 2 And Not e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRubro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRubro.Leave
        txtRubro.Text = txtRubro.Text.PadLeft(3, "0"c)
    End Sub
#End Region
End Class