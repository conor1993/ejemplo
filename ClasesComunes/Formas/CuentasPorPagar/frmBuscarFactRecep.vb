Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses

Public Class frmBuscarFactRecep
    Dim TipoBusq As String, NoFactura As String, NR As String, Recep As String
    Dim CodProveedor As Integer
    Public Property Tipo As String
        Get
            Return TipoBusq
        End Get
        Set(value As String)
            TipoBusq = value
        End Set
    End Property

    Public Property Proveedor As Integer
        Get
            Return CodProveedor
        End Get
        Set(value As Integer)
            CodProveedor = value
        End Set
    End Property

    Public Property Factura As String
        Get
            Return NoFactura
        End Get
        Set(value As String)
            NoFactura = value
        End Set
    End Property

    Public Property NotaRemision As String
        Get
            Return NR
        End Get
        Set(value As String)
            NR = value
        End Set
    End Property

    Public Property Recepcion As String
        Get
            Return Recep
        End Get
        Set(value As String)
            Recep = value
        End Set
    End Property

    Private Sub frmBuscarFactRecep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100001"
        MtbEstados.StateNuevo = "001010001"
        MtbEstados.StateGuardar = "000100001"
        MtbEstados.StateBorrar = "000100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")

        Dim i As Integer
        For i = 0 To dgvRecepComp.Columns.Count - 1
            dgvRecepComp.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next i
        For i = 0 To dgvFacturas.Columns.Count - 1
            dgvFacturas.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next i
        ''LLENAR COMBO DE PROVEEDORES
        Dim Proveedores As New ClasesNegocio.ProveedorCollectionClass
        Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        cmbProveedor.ValueMember = "IDProveedor"
        cmbProveedor.DisplayMember = "RazonSocial"
        Dim proveedor As New ClasesNegocio.ProveedorClass
        proveedor.RazonSocial = "< TODOS >"
        Proveedores.Add(proveedor)
        cmbProveedor.DataSource = Proveedores
        cmbProveedor.SelectedIndex = cmbProveedor.FindStringExact("< TODOS >")

        rbFactura.Checked = True
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        dgvRecepComp.AutoGenerateColumns = False
        dgvFacturas.AutoGenerateColumns = False
        

        ' Dim x As ProveedorClass = cmbProveedor.SelectedValue
        Dim filter As New OC.PredicateExpression
        If rbFactura.Checked Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            dgvRecepComp.Visible = False
            dgvFacturas.Visible = True
            'Dim fact As New FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo, txtFolio.Text.Trim)

            Dim fact As New FacturaCabCXPColeccion
            Dim filtro As New OC.PredicateExpression
            If CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo <> 0 Then
                filtro.Add(HC.UsrCxpfacturasCabFields.IdProveedor = CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo)
            End If
            If Not txtFolio.Text.Trim().Equals("") Then
                filtro.Add(HC.UsrCxpfacturasCabFields.NoFactura = txtFolio.Text.Trim())
            End If
            filtro.Add(HC.UsrCxpfacturasCabFields.EmpresaId = Controlador.Empresa.CodEmpndx)

            '  Dim fat As New FacturasCabCXPClass(Controlador.Empresa.CodEmpndx, CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo, txtFolio.Text.Trim())
            ' fact.Obtener(txtFolio.Text.Trim, CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo)
            fact.Obtener(filtro)

            dgvFacturas.DataSource = fact
            Windows.Forms.Cursor.Current = Cursors.Default

            dgvFacturas.Focus()
            '' Dim recepciones As New CC.RecepcionOrdenCompraCollection
            'dgvRecepComp.Rows.Clear()
            'For Each row As FacturasDetalleCXPRecepcionesClass In fact.DetalleRecepciones
            '   ' recepciones.Add(row.RecepcionOC.ObtenerEntidad)
            'Next
            'dgvRecepComp.DataSource = fact.DetalleRecepciones

            'dgvRecepComp.Columns(1).DataPropertyName = "IdRecepOC"
            'dgvRecepComp.Columns(2).DataPropertyName = "FechaRecepcion"
            'dgvRecepComp.Columns(3).DataPropertyName = "SubTotal"
            'dgvRecepComp.Columns(4).DataPropertyName = "Iva"
            'dgvRecepComp.Columns(5).DataPropertyName = "Ieps"
            'dgvRecepComp.Columns(6).DataPropertyName = "Total"
        Else
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            dgvRecepComp.Visible = True
            dgvFacturas.Visible = False
            Dim RecepcionesOrdenCompra As New IntegraLab.ORM.CollectionClasses.RecepcionOrdenCompraCollection


            If CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo <> 0 Then
                filter.Add(HC.RecepcionOrdenCompraFields.IdProveedor = CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo)
            End If
            'If Not txtFolio.Text.Trim().Equals("") Then
            If rbNotaRem.Checked Then
                clmIdRecepCom.HeaderText = "Nota Remision"
                If Not txtFolio.Text.Trim.Equals("") Then
                    filter.Add(HC.RecepcionOrdenCompraFields.NoRemision = txtFolio.Text.Trim)
                Else
                    filter.Add(HC.RecepcionOrdenCompraFields.NoRemision <> "")
                End If
            Else
                clmIdRecepCom.HeaderText = "Fol. ROC"
                If Not txtFolio.Text.Trim.Equals("") Then
                    filter.Add(HC.RecepcionOrdenCompraFields.FolioRecepcionOrdenCompra Mod ("%" & txtFolio.Text.Trim() & "%").ToString())
                End If
            End If
            'End If
            dgvRecepComp.Refresh()

            If rbNotaRem.Checked Then
                Dim sort As New OC.SortExpression(New OC.SortClause(HC.RecepcionOrdenCompraFields.NoRemision, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

                'RecepcionesOrdenCompra.GetMulti( HC.RecepcionOrdenCompraFields.Pagada = False And HC.RecepcionOrdenCompraFields.Facturada = False)
                RecepcionesOrdenCompra.GetMulti(filter, 0, sort)
            Else
                Dim sort As New OC.SortExpression(New OC.SortClause(HC.RecepcionOrdenCompraFields.FechaRecepcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

                'RecepcionesOrdenCompra.GetMulti( HC.RecepcionOrdenCompraFields.Pagada = False And HC.RecepcionOrdenCompraFields.Facturada = False)
                RecepcionesOrdenCompra.GetMulti(filter, 0, sort)
            End If


            'RecepcionOrdenCompra.GetMulti(HC.RecepcionOrdenCompraFields.IdOrdenCompra = OrdenesCompra(i).IdOrdenCompra) ''And HC.RecepcionOrdenCompraFields.Facturada = False)
            'RecepcionesOrdenCompra.Add(RecepcionOrdenCompra(0))
            dgvRecepComp.Rows.Clear()
            For Each row As EC.RecepcionOrdenCompraEntity In RecepcionesOrdenCompra
                Dim proveedor As New ClasesNegocio.ProveedorClass(row.IdProveedor)
                dgvRecepComp.Rows.Add(False, IIf(rbNotaRem.Checked, row.NoRemision, row.FolioRecepcionOrdenCompra), row.FechaRecepcion, row.SubTotal, row.Iva, row.Ieps, row.Total, Nothing, IIf(rbNotaRem.Checked, "NR", "R"), row.IdProveedor, row.IdRecepcionOrdenCompra, IIf(proveedor.Nombre = "", proveedor.RazonSocial, proveedor.Nombre))
            Next
            Application.DoEvents()
            Windows.Forms.Cursor.Current = Cursors.Default
            dgvRecepComp.Focus()
            'Me.dgvRecepComp.DataSource = RecepcionesOrdenCompra

            'dgvRecepComp.Focus()
            'dgvRecepComp.Rows(0).Cells(0).Selected = False
            'dgvRecepComp.Rows(0).Cells(1).Selected = True



            'Me.dgvRecepComp.DataSource = RecepcionesOrdenCompra

            'If rbNotaRem.Checked Then
            '    For Each row As DataGridViewRow In dgvRecepComp.Rows
            '        row.Cells(clmTipoRecep.Index).Value = "NR"
            '    Next
            'Else
            '    For Each row As DataGridViewRow In dgvRecepComp.Rows
            '        row.Cells(clmTipoRecep.Index).Value = "R"
            '    Next
            'End If

            'If Not rbNotaRem.Checked Then
            '    dgvRecepComp.Columns(1).DataPropertyName = "FolioRecepcionOrdenCompra"
            'Else
            '    dgvRecepComp.Columns(1).DataPropertyName = "NoRemision"
            'End If

            'dgvRecepComp.Columns(1).DataPropertyName = "IdRecepcionOrdenCompra"
            'dgvRecepComp.Columns(2).DataPropertyName = "FechaRecepcion"
            'dgvRecepComp.Columns(3).DataPropertyName = "SubTotal"
            'dgvRecepComp.Columns(4).DataPropertyName = "Iva"
            'dgvRecepComp.Columns(5).DataPropertyName = "Ieps"
            'dgvRecepComp.Columns(6).DataPropertyName = "Total"
            'dgvRecepComp.Columns(9).DataPropertyName = "IdProveedor"
            'dgvRecepComp.Columns(10).DataPropertyName = "IdRecepcionOrdenCompra"
            'Application.DoEvents()
            'For Each row As DataGridViewRow In dgvRecepComp.Rows
            '    If rbNotaRem.Checked Then
            '        row.Cells(8).Value = "NR"
            '    Else
            '        row.Cells(8).Value = "R"
            '    End If
            'Next
            Application.DoEvents()
        End If


    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvRecepComp_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvFacturas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellContentClick

    End Sub

    Private Sub dgvFacturas_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellDoubleClick
        If e.RowIndex <> -1 Then
            Tipo = "F"
            Proveedor = dgvFacturas.Rows(e.RowIndex).Cells(clmCodProveedorFact.Index).Value
            Factura = dgvFacturas.Rows(e.RowIndex).Cells(clmNoFactura.Index).Value.ToString()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub dgvRecepComp_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepComp.CellDoubleClick
        If e.RowIndex <> -1 Then
            Tipo = dgvRecepComp.SelectedRows(0).Cells(8).Value.ToString()
            Proveedor = dgvRecepComp.Rows(e.RowIndex).Cells(clmProveedorRecep.Index).Value
            If Tipo = "NR" Then
                NotaRemision = dgvRecepComp.Rows(e.RowIndex).Cells(clmIdRecepCom.Index).Value.ToString()
            Else
                Recepcion = dgvRecepComp.Rows(e.RowIndex).Cells(clmIdRecepcionDeCompra.Index).Value.ToString()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub frmBuscarFactRecep_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If dgvFacturas.Rows.Count <= 0 And dgvRecepComp.Rows.Count <= 0 Then
        '    Return
        'End If

        Select Case e.KeyCode
            Case Keys.Enter     '' seleccionar artículo
                e.Handled = True
                

                If rbFactura.Checked Then
                    'If dgvFacturas.Rows.Count = 0 Then
                    '    Return
                    'End If
                    If txtFolio.Focused Then
                        Application.DoEvents()
                        mtb_ClickBuscar(New Object, Nothing, False)
                        Return
                    End If

                    If dgvFacturas.SelectedRows(0) IsNot Nothing Then
                        Application.DoEvents()
                        btnAceptar_Click(sender, New System.EventArgs())
                    End If
                Else
                    'If dgvRecepComp.Rows.Count = 0 Then
                    '    Return
                    'End If
                    If txtFolio.Focused Then
                        Application.DoEvents()
                        mtb_ClickBuscar(New Object, Nothing, False)
                        Return
                    End If
                    If dgvRecepComp.SelectedRows(0) IsNot Nothing Then
                        Application.DoEvents()
                        btnAceptar_Click(sender, New System.EventArgs())
                    End If
                End If
            Case Keys.Escape    '' seleccionar artículo
                e.Handled = True
                btnCancelar_Click(sender, New System.EventArgs())
            Case Keys.Down
                'If Not dgvProductosReg.Focused Then
                '    e.Handled = True
                '    Me.ActiveControl = Me.dgvProductosReg
                '    dgvProductosReg.Focus()
                'End If
                If rbFactura.Checked Then
                    If Not dgvFacturas.Focused Then
                        e.Handled = True
                        Me.ActiveControl = Me.dgvFacturas
                        dgvFacturas.Focus()
                    End If
                Else
                    If Not dgvRecepComp.Focused Then
                        e.Handled = True
                        Me.ActiveControl = Me.dgvRecepComp
                        dgvRecepComp.Focus()
                    End If
                End If

        End Select
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If rbFactura.Checked Then
            Tipo = "F"
            Proveedor = dgvFacturas.SelectedRows(0).Cells(clmCodProveedorFact.Index).Value
            Factura = dgvFacturas.SelectedRows(0).Cells(clmNoFactura.Index).Value.ToString()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Tipo = dgvRecepComp.SelectedRows(0).Cells(clmTipoRecep.Index).Value.ToString()
            Proveedor = CType(cmbProveedor.SelectedValue, ProveedorClass).Codigo
            If Tipo = "NR" Then
                NotaRemision = dgvRecepComp.SelectedRows(0).Cells(clmIdRecepCom.Index).Value.ToString()
            Else
                Recepcion = dgvRecepComp.SelectedRows(0).Cells(clmIdRecepcionDeCompra.Index).Value.ToString()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub
End Class