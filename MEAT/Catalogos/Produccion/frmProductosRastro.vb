Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class frmProductosRastro

#Region "Miembros"

#End Region
    
#Region "Metodos"
    Private Function Limpiar() As Boolean
        cmbRastro.SelectedIndex = -1
        cmbRastro.Text = "Seleccione el Rastro"
        dgvProductosRastro.DataSource = Nothing
        Return True
    End Function

    Private Function Cancelar() As Boolean
        Edicion(EstatusEnum.INACTIVO)
        Limpiar()
        Return True
    End Function

    Private Function Nuevo() As Boolean
        Try
            Edicion(EstatusEnum.ACTIVO)
            Dim Coleccion As New RastroCollectionClass

            For Each rastro As EC.CatRastrosEntity In RastroCollectionClass.CargarRastros(HC.CatRastrosFields.Estatus = "1")
                Coleccion.Add(New RastroClass(rastro))
            Next
            cmbRastro.DataSource = Coleccion
            Limpiar()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Function

    Private Function Guardar() As Boolean
        Dim Trans As HC.Transaction = Nothing

        Try
            If Validar() Then
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "ProductosRastro")
                CType(cmbRastro.SelectedItem, RastroClass).GuardarProductos(Trans)
            Else
                Return False
            End If

            If Trans IsNot Nothing Then
                Trans.Commit()
            End If

            Edicion(EstatusEnum.INACTIVO)
            Limpiar()
            MsgBox("El registro se ha guardado satisfactoriamente")
            Return True
        Catch ex As Exception
            If Trans IsNot Nothing Then
                Trans.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Function

    Private Function Imprimir() As Boolean
        Controlador.ReporteRelacionProductoRastro()
    End Function

    Private Function Salir() As Boolean
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
        Return True
    End Function

    Private Function Validar() As Boolean
        If cmbRastro.SelectedValue Is Nothing Then
            MsgBox("Por favor seleccione el Rastro", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Return False
        End If

        If dgvProductosRastro.Rows.Count = 0 Then
            MsgBox("Introduzca los productos para el Rastro", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Return False
        End If
        Return Me.Validate()
    End Function

    Private Sub Edicion(ByVal Modo As EstatusEnum)
        Dim Result As Boolean = IIf(Modo = EstatusEnum.ACTIVO, True, False)
        cmbRastro.Enabled = Result
        txtIdRastro.ReadOnly = Not Result
        dgvProductosRastro.ReadOnly = Not Result
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmProductosRastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "011010001"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        Edicion(EstatusEnum.INACTIVO)
        clmProducto.DisplayMember = "Descripcion"
        clmProducto.ValueMember = "IdProducto"
        clmProducto.DataSource = ProductosCollectionsClass.CargarProductos(HC.MsccatProductosFields.Estatus = 1)
        dgvProductosRastro.AutoGenerateColumns = False
    End Sub

    Private Sub dgvProductosRastro_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvProductosRastro.DataError

    End Sub

    Private Sub dgvProductosRastro_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvProductosRastro.RowValidating
        If Not dgvProductosRastro.Rows(e.RowIndex) Is Nothing And Not dgvProductosRastro.Rows(e.RowIndex).IsNewRow And dgvProductosRastro.IsCurrentRowDirty Then
            For i As Integer = 0 To dgvProductosRastro.Rows.Count - 2
                If dgvProductosRastro.Rows(i).Index <> e.RowIndex _
                AndAlso dgvProductosRastro.Rows(i).Cells(clmProducto.Index).Value.ToString = dgvProductosRastro.Rows(e.RowIndex).Cells(clmProducto.Index).Value.ToString Then
                    MsgBox("No se puede repetir el producto", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                    e.Cancel = True
                End If
            Next

            If dgvProductosRastro.Rows(e.RowIndex).Cells(clmCodigo.Index).Value.ToString.Trim = String.Empty Then
                MsgBox("Debe asignar un codigo", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dgvProductosRastro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvProductosRastro.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvProductosRastro.SelectedCells(0).RowIndex <> dgvProductosRastro.Rows.Count - 1 Then
                If MessageBox.Show("Seguro que desea la eliminacion", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    dgvProductosRastro.Rows.RemoveAt(dgvProductosRastro.SelectedCells(0).RowIndex)
                End If
            End If
        End If
    End Sub

    Private Sub cmbRastro_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRastro.SelectedValueChanged
        If cmbRastro.SelectedValue Is Nothing Then
            dgvProductosRastro.DataSource = Nothing
            dgvProductosRastro.ReadOnly = True
            txtIdRastro.Text = "0"
        Else
            Dim Rastro As RastroClass = CType(cmbRastro.SelectedItem, RastroClass)
            dgvProductosRastro.DataSource = Rastro.ProductosRastro
            dgvProductosRastro.ReadOnly = False
            txtIdRastro.Text = Rastro.IdRastro
        End If
    End Sub

    Private Sub txtIdRastro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdRastro.TextChanged
        For Each rastro As RastroClass In cmbRastro.Items
            If txtIdRastro.Text.Trim = rastro.IdRastro Then
                txtIdRastro.Text = rastro.IdRastro
            End If
        Next
    End Sub
#End Region

    Private Sub Acciones(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar, MEAToolBar1.ClickGuardar, MEAToolBar1.ClickImprimir, MEAToolBar1.ClickLimpiar, MEAToolBar1.ClickNuevo, MEAToolBar1.ClickSalir
        Dim Resultado As Boolean

        Select Case (e.Button.Text)
            Case "Limpiar"
                Resultado = Limpiar()
            Case "Cancelar"
                Resultado = Me.Cancelar()
            Case "Nuevo"
                Resultado = Nuevo()
            Case "Guardar"
                Resultado = Guardar()
            Case "Imprimir"
                Resultado = Imprimir()
            Case "Salir"
                Resultado = Salir()
        End Select

        Cancelar = Not Resultado
    End Sub
End Class