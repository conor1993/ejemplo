Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmCapturaInvFisico
    Dim InvenFisico As CN.InventarioFisicoClass

    Private Sub FrmCapturaInvFisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados

            mtb.sbCambiarEstadoBotones("Cancelar")

            Dim AlmacenesCol As New CN.AlmacenCollectionClass
            AlmacenesCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            CmbAlmacenes.DisplayMember = "Descripcion"
            CmbAlmacenes.ValueMember = "Codigo"
            CmbAlmacenes.DataSource = AlmacenesCol

            Habilitar(False)
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        CmbAlmacenes.SelectedIndex = -1
        DgvProductos.DataSource = Nothing
    End Sub

    Private Sub Habilitar(ByVal Estado As Boolean)
        Me.DgvProductos.Enabled = Estado
        Me.CmbAlmacenes.Enabled = Estado
    End Sub

#End Region

    Private Sub CmbAlmacenes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.SelectedIndexChanged
        Try
            If Me.CmbAlmacenes.SelectedIndex > -1 Then
                Dim Filtro As New OC.PredicateExpression
                Filtro.Add(HC.VwProductosEnAlmacenFields.AlmacenId = Me.CmbAlmacenes.SelectedValue)
                Dim Vista As New TC.VwProductosEnAlmacenTypedView
                Vista.Fill(0, Nothing, False, Filtro)

                Me.DgvProductos.AutoGenerateColumns = False
                Me.DgvProductos.DataSource = Vista
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New FrmBusqInvFisico
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Coleccion As New CN.InventarioFisicoCollectionClass
                Coleccion.Obtener(Ventana.CmbAlmacenes.SelectedValue)
                Me.CmbAlmacenes.SelectedValue = Ventana.CmbAlmacenes.SelectedValue

                If Coleccion.Count > 0 Then
                    Me.DtpFecha.Value = Coleccion(Coleccion.Count - 1).FechaInventario
                    Me.DgvProductos.AutoGenerateColumns = False
                    Me.DgvProductos.DataSource = Coleccion
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Habilitar(False)
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            Habilitar(True)
            Me.clmCantidad.ReadOnly = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Inventario_Fisico")
        Try
            If Me.CmbAlmacenes.SelectedIndex = -1 Then
                MessageBox.Show("Seleccione un almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            If Me.DgvProductos.Rows.Count = 0 Then
                MessageBox.Show("No hay productos registrados en el almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            Me.CmbAlmacenes.Focus()
            For i As Integer = 0 To Me.DgvProductos.Rows.Count - 1
                InvenFisico = New CN.InventarioFisicoClass(Me.CmbAlmacenes.SelectedValue, DgvProductos.Rows(i).Cells(Me.clmProductoId.Index).Value)
                If Not InvenFisico Is Nothing Then
                    InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                    InvenFisico.FechaInventario = Now
                    If Not InvenFisico.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If
                Else
                    InvenFisico = New CN.InventarioFisicoClass
                    InvenFisico.AlmacenId = Me.CmbAlmacenes.SelectedValue
                    InvenFisico.ProductoID = Me.DgvProductos.Rows(i).Cells(Me.clmProductoId.Index).Value
                    InvenFisico.Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                    InvenFisico.FechaInventario = Now

                    If Not InvenFisico.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If
                End If
            Next
            Trans.Commit()
            MessageBox.Show("Los Datos han sido guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            Habilitar(False)
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar(True)

    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub DgvProductos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProductos.CellEndEdit
        Try
            Select Case e.ColumnIndex
                Case Me.clmCantidad.Index
                    If Not IsNumeric(Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value) Then
                        MessageBox.Show("Ingrese solo números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value = Nothing
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvProductos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvProductos.DataError

    End Sub
End Class