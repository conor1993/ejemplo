Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Threading

Partial Public Class FrmBuscarProductos
#Region "Miembros"
    Private cargo As Boolean = False
    Dim Linea As New ClasesNegocio.LineaClass()
    Dim SubLinea As New ClasesNegocio.SubLineaClass()
    Dim marca As New ClasesNegocio.MarcaClass()
    Dim Lineas As New ClasesNegocio.LineaCollectionClass()
    Dim marcas As New ClasesNegocio.MarcaCollectionClass()
    Dim SubLineas As New ClasesNegocio.SubLineaCollectionClass()
    Dim productos As New ClasesNegocio.ProductoCollectionClass
    Dim edit As Boolean
    Dim m_ing As Boolean
    Dim bucket As New RelationCollection
    Dim pr As New ProductoCollectionClass()
    Dim loadcompleto As Boolean = False
    Public CodLista As Integer


#End Region

    Private Sub FrmBuscarProductos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        

        Select Case e.KeyCode
            Case Keys.Enter     '' seleccionar artículo
                e.Handled = True
                If txtCodBarra.Text.Trim <> "" And txtCodBarra.Focused Then
                    Buscar()
                End If
                Application.DoEvents()
                btnAceptar_Click(sender, New System.EventArgs())
            Case Keys.Escape    '' seleccionar artículo
                e.Handled = True
                btnCancelar_Click(sender, New System.EventArgs())
            Case Keys.Down
                If Not dgvProductosReg.Focused Then
                    e.Handled = True
                    Me.ActiveControl = Me.dgvProductosReg
                    dgvProductosReg.Focus()
                End If


        End Select
    End Sub

    Private Sub FrmBuscarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        If Edicion Then
            dgvProductosReg.MultiSelect = False
        Else
            dgvProductosReg.MultiSelect = True
        End If
        CargarLineas()
        dgvProductosReg.AutoGenerateColumns = False
        CodigoColumn.DataPropertyName = "Codigo"
        DescColumn.DataPropertyName = "Descripcion"
        DescCortaColumn.DataPropertyName = "DescCorta"
        IngredienteColumn.DataPropertyName = "Ingrediente"
        MarcaColumn.DataPropertyName = "Marca"
        SubLineaColumn.DataPropertyName = "SubLinea"
        'LineaColumn.DataPropertyName = SubLinea.Linea.ToString()
        LineaColumn.DataPropertyName = "Linea"
        If ING Then
            chkProductoGeneral.Checked = True
            chkProductoGeneral.Enabled = False
        End If

        'limpiar()
        cargo = True
        
        'If (So_Info.Version.Major = 5 And So_Info.Version.Minor = 1) Or So_Info.Version.Major < 5 Then
        '    CargarLineas()
        '    Buscar()
        'ElseIf So_Info.Version.Major = 6 And So_Info.Version.Minor = 1 Then
        '    hilo1 = New Thread(AddressOf CargarLineas)
        '    hilo1.Start()

        '    hilo2 = New Thread(AddressOf Buscar)
        '    hilo2.Start()
        'End If
        ' Trae todas las Marcas...

        'marcas.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'cmbMarca.DataSource = marcas
        'cmbMarca.DisplayMember = "nombre"
        'cmbMarca.ValueMember = "Codigo"

        'limpiar()
        

        
        rbtActivos.Checked = True
        
        Buscar()
        'txtDescripcion.Focus()
        loadcompleto = True
        Me.Cursor = Cursors.Default

    End Sub

    Public Sub CargarLineas()
        ' Trae todas las Líneas...
        'lineas.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Lineas.Obtener(CondicionEnum.ACTIVOS)
        Dim Linea As New ClasesNegocio.LineaClass
        Linea.Codigo = 0
        Linea.Descripcion = "TODAS"
        Lineas.Add(Linea)
        cmbLinea.DataSource = Lineas
        cmbLinea.DisplayMember = "Descripcion"
        cmbLinea.ValueMember = "Codigo"
        cmbLinea.SelectedText = ""
        cmbLinea.SelectedValue = 0
    End Sub
#Region "Propiedades"


    ' Propiedad que Permite Seleccionar varios o mas de uno...
    Public Property SeleccionarVarios() As Boolean
        Get
            Return Me.dgvProductosReg.MultiSelect
        End Get
        Set(ByVal value As Boolean)
            Me.dgvProductosReg.MultiSelect = value
        End Set
    End Property

    ' Propiedad que indica cuando se da una edición...
    Public Property Edicion() As Boolean
        Get
            Return edit
        End Get
        Set(ByVal value As Boolean)
            edit = value
        End Set
    End Property

    Public Property ING() As Boolean
        Get
            Return Me.m_ing
        End Get
        Set(ByVal value As Boolean)
            Me.m_ing = value
        End Set
    End Property



    ' Propiedad que envia los productos seleccionados en el grid...
    Public Property ProductosSeleccionados() As ProductoCollectionClass
        Get
            Return pr
        End Get
        Set(ByVal value As ProductoCollectionClass)
            pr = value
        End Set
    End Property
#End Region

    Private Sub limpiar()
        cmbLinea.SelectedIndex = -1
        cmbLinea.Text = "Seleccione una Línea"
        cmbSubLinea.SelectedIndex = -1
        cmbMarca.SelectedIndex = -1
        cmbMarca.Text = "Seleccione una Marca"
        txtDescripcion.Text = ""
        SubLineas.Clear()
        cmbLinea.Focus()
        chkIngrediente.Checked = True
        chkMaterialEnvace.Checked = True
        chkMezcla.Checked = True
        chkProductoGeneral.Checked = True
        rbtTodos.Checked = True

    End Sub

    Friend Sub Buscar()
        Try
            Me.Cursor = Cursors.WaitCursor
            If Utilerias.ObtenerCodSucursal = 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If

            'dgvProductosReg.DataSource = Nothing
            dgvProductosReg.Rows.Clear()
            productos = New ProductoCollectionClass
            Dim col As New CC.ProductoCollection()
            'Dim rel As OC.RelationCollection = Nothing
            Dim filtro As New OC.PredicateExpression()
            Dim Sucursal As New ClasesNegocio.SucursalClass
            Sucursal.Obtener(Utilerias.ObtenerControlTurnoActual.CodSucursal)
            'obtiene la letra serie del almacen seleccionado
            Dim Almacen As New ClasesNegocio.AlmacenClass
            Almacen.Obtener(Sucursal.IdAlmacen)


            If Me.cmbLinea.SelectedIndex > -1 And cmbLinea.SelectedValue <> 0 Then
                filtro.Add(HC.ProductoFields.PdIdLinea = Me.cmbLinea.SelectedValue)
                'Else
                'If Me.cmbLinea.SelectedIndex > -1 Then
                '    rel = New OC.RelationCollection()
                '    rel.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea)
                '    filtro.Add(HC.LineaFields.Codigo = Me.cmbLinea.SelectedValue)
                'End If
                'End If

                'If (Me.cmbMarca.SelectedIndex > -1) Then
                '    filtro.Add(HC.ProductoFields.CodigoMarca = cmbMarca.SelectedValue)
            End If



            'If Not (chkMezcla.Checked = chkProductoGeneral.Checked And chkMaterialEnvace.Checked = chkIngrediente.Checked) Then
            '    If (chkMezcla.Checked <> chkProductoGeneral.Checked) Then
            '        If (chkMezcla.Checked Or (chkProductoGeneral.Checked And chkMaterialEnvace.Checked = chkIngrediente.Checked)) Then
            '            filtro.Add(HC.ProductoFields.EsMezcla = chkMezcla.Checked And HC.ProductoFields.ProductoGeneral = chkProductoGeneral.Checked)
            '        Else
            '            filtro.Add(HC.ProductoFields.EsMezcla = False And HC.ProductoFields.ProductoGeneral = True And HC.ProductoFields.EsMaterialEnvase = chkMaterialEnvace.Checked And HC.ProductoFields.EsIngrediente = chkIngrediente.Checked)
            '        End If
            '    Else
            '        filtro.Add(HC.ProductoFields.EsMezcla = True Or (HC.ProductoFields.ProductoGeneral = True And HC.ProductoFields.EsMaterialEnvase = chkMaterialEnvace.Checked And HC.ProductoFields.EsIngrediente = chkIngrediente.Checked))
            '    End If
            'End If
            'bucket.Add(EC.ProductoEntity.Relations.InventarioAlmacenEntityUsingProductoId)

            If Me.chkProductoGeneral.Checked And Me.chkIngrediente.Checked And Me.chkMezcla.Checked Then
                filtro.Add(HC.ProductoFields.ProductoGeneral = True Or HC.ProductoFields.EsIngrediente = True Or HC.ProductoFields.EsMezcla = True)
            ElseIf Me.chkProductoGeneral.Checked And Not Me.chkIngrediente.Checked And Not Me.chkMezcla.Checked Then
                filtro.Add(HC.ProductoFields.ProductoGeneral = True)
            ElseIf Me.chkProductoGeneral.Checked And Me.chkIngrediente.Checked And Not Me.chkMezcla.Checked Then
                filtro.Add(HC.ProductoFields.ProductoGeneral = True Or HC.ProductoFields.EsIngrediente = True)
            ElseIf Me.chkProductoGeneral.Checked And Not Me.chkIngrediente.Checked And Me.chkMezcla.Checked Then
                filtro.Add(HC.ProductoFields.ProductoGeneral = True Or HC.ProductoFields.EsMezcla = True)
            ElseIf Not Me.chkProductoGeneral.Checked And Me.chkIngrediente.Checked And Not Me.chkMezcla.Checked Then
                filtro.Add(HC.ProductoFields.EsIngrediente = True)
            ElseIf Not Me.chkProductoGeneral.Checked And Not Me.chkIngrediente.Checked And Me.chkMezcla.Checked Then
                filtro.Add(HC.ProductoFields.EsMezcla = True)
            ElseIf Not Me.chkProductoGeneral.Checked And Me.chkIngrediente.Checked And Me.chkMezcla.Checked Then
                filtro.Add(HC.ProductoFields.EsIngrediente = True Or HC.ProductoFields.EsMezcla = True)
            End If



            If rbtActivos.Checked Then filtro.Add(HC.ProductoFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO)
            If rbtInactivos.Checked Then filtro.Add(HC.ProductoFields.Estatus = ClasesNegocio.EstatusEnum.INACTIVO)
            If txtDescripcion.Text.Trim <> "" Then
                filtro.Add(New OC.FieldLikePredicate(HC.ProductoFields.Descripcion, String.Format("%{0}%", Me.txtDescripcion.Text.Trim())))
                ''filtro.Add(New OC.FieldLikePredicate(HC.ProductoFields.Descripcion, String.Format("{0}%", Me.txtDescripcion.Text.Trim())) Or New OC.FieldLikePredicate(HC.ProductoFields.Descripcion, String.Format("%{0}%", Me.txtDescripcion.Text.Trim())))
                productos.Obtener(filtro)
            Else
                If txtCodBarra.Text.Trim <> "" And txtCodBarra.Focused Then
                    'filtro.Add(New OC.FieldLikePredicate(HC.ProductoFields.Descripcion, String.Format("%{0}%", Me.txtDescripcion.Text.Trim())))
                    filtro.Add(HC.ProductoFields.CodigoBarra = txtCodBarra.Text.Trim)
                    productos.Obtener(filtro)
                Else
                    productos.Obtener(filtro)
                End If
            End If

            'col.GetMulti(filtro, 0, Nothing)
            'productos.RellenarMe(col)
            dgvProductosReg.DataSource = productos

            ' For Each row As ClasesNegocio.ProductoGeneralClass In productos
            '    If row IsNot Nothing Then
            '        If row.CodigoBarra IsNot Nothing And row.CodigoBarra <> "" And row.Precio(1) IsNot Nothing And row.InvAlmacen(Almacen.Codigo) IsNot Nothing Then
            '            dgvProductosReg.Rows.Add(row.Codigo, row.CodigoBarra, row.Descripcion, row.DescCorta, row.Marca.Codigo, row.Linea.Codigo, row.Linea.SubLineas, row.EsMezcla, 0, row.ProductoGeneral, row.Ingrediente, row.MaterialEnvase, row.Precio(1).PrecioVentaC, row.InvAlmacen(Almacen.Codigo).CantidadExistencia)
            '        End If
            '    End If
            'Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, Application.ProductName)
        End Try
        

        
        Me.Cursor = Cursors.Default
        'Me.dgvProductosReg.DataSource = productos
        Me.ActiveControl = Me.dgvProductosReg
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#Region "Eventos"

    Private Sub cmbLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLinea.SelectedIndexChanged
        If cargo Then
            SubLineas.Clear()

            If (cmbLinea.SelectedIndex >= 0) Then
                cargo = False
                Linea = CType(cmbLinea.SelectedItem, LineaClass)
                'SubLineas = Linea.ObtenerSubLinea()
                'cmbSubLinea.DataSource = SubLineas
                'cmbSubLinea.DisplayMember = "Descripcion"
                'cmbSubLinea.ValueMember = "Codigo"
                'cmbSubLinea.SelectedIndex = -1
                'cmbSubLinea.Text = "Seleccione una Sub-Línea..."
                Buscar()
                cargo = True
            End If
        End If
    End Sub

    Private Sub cmbSubLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubLinea.SelectedIndexChanged
        If cargo Then
            If (cmbSubLinea.SelectedIndex > -1) Then
                SubLinea = CType(cmbSubLinea.SelectedItem, SubLineaClass)
                Buscar()
            End If
        End If
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.SelectedIndexChanged
        If (cargo) Then
            If (cmbMarca.SelectedIndex > -1) Then
                marca = CType(cmbMarca.SelectedItem, MarcaClass)
                Buscar()
            End If
        End If
    End Sub

#End Region

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'Me.pr.Clear()
        pr = New ClasesNegocio.ProductoCollectionClass
        'Recorrer el grid para ver cuales registros estan seleccionados
        For Each r As DataGridViewRow In Me.dgvProductosReg.SelectedRows
            Dim p As New ClasesNegocio.ProductoGeneralClass
            p.Obtener(CInt(r.Cells(CodigoColumn.Index).Value))
            pr.Add(CType(p, ProductoGeneralClass))
        Next

        If (productos.Count > 0) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cargo Then
        '    Buscar()
        'End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        If txtDescripcion.Text.Length > 0 And txtDescripcion.Focused Then
            Buscar()
        End If
        If txtCodBarra.Text.Length > 0 And txtCodBarra.Focused Then
            Buscar()
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    'Private Sub chkSoloIngredientes_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkIngrediente.CheckedChanged
    '    If cargo Then
    '        cargo = False

    '        'If Not Me.chkProductoGeneral.Checked And Not chkMezcla.Checked Then
    '        '    chkProductoGeneral.Checked = True
    '        '    chkMezcla.Checked = True
    '        'End If

    '        'If Me.chkProductoGeneral.Checked Then
    '        '    Me.groupBox2.Enabled = True
    '        '    Me.chkIngrediente.Checked = True
    '        '    Me.chkMaterialEnvace.Checked = True
    '        'Else

    '        '    Me.groupBox2.Enabled = False
    '        '    Me.chkIngrediente.Checked = False
    '        '    Me.chkMaterialEnvace.Checked = False
    '        'End If

    '        cargo = True
    '        'Buscar()
    '    End If
    'End Sub

    'Private Sub chkSoloPaquetes_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkMezcla.CheckedChanged
    '    If cargo Then
    '        cargo = False

    '        If Me.chkMezcla.Checked Then
    '            Me.chkProductoGeneral.Checked = False
    '            Me.chkIngrediente.Checked = False
    '        End If
    '        'If Not chkProductoGeneral.Checked And Not chkMezcla.Checked Then
    '        '    'Me.chkMezcla.Checked = True
    '        '    'Me.chkProductoGeneral.Checked = True
    '        '    'Me.groupBox2.Enabled = True
    '        '    Me.chkIngrediente.Checked = True
    '        '    'Me.chkMaterialEnvace.Checked = True
    '        'End If

    '        cargo = True
    '        'Buscar()
    '    End If
    'End Sub

    Private Sub radioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbtActivos.CheckedChanged, rbtInactivos.CheckedChanged, rbtTodos.CheckedChanged
        If cargo Then
            Buscar()
        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub chkIngrediente_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkIngrediente.CheckedChanged
    '    If (cargo) Then
    '        cargo = False

    '        ''If Not Me.chkMaterialEnvace.Checked And Not Me.chkIngrediente.Checked And Me.chkProductoGeneral.Checked Then
    '        'If Not Me.chkIngrediente.Checked And Me.chkProductoGeneral.Checked Then
    '        '    'Me.chkMaterialEnvace.Checked = True
    '        '    Me.chkIngrediente.Checked = True
    '        'End If
    '        If Me.chkIngrediente.Checked Then
    '            Me.chkProductoGeneral.Checked = False
    '            Me.chkMezcla.Checked = False
    '        End If
    '        cargo = True
    '        'Buscar()
    '    End If
    'End Sub

    'Private Sub chkMaterialEnvace_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkMaterialEnvace.CheckedChanged
    '    If cargo Then
    '        cargo = False

    '        'If Not Me.chkMaterialEnvace.Checked And Not Me.chkIngrediente.Checked And Me.chkProductoGeneral.Checked Then
    '        '    Me.chkMaterialEnvace.Checked = True
    '        '    Me.chkIngrediente.Checked = True
    '        'End If

    '        cargo = True
    '        'Buscar()
    '    End If
    'End Sub
    'Private Sub chkProductoGeneral_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkProductoGeneral.CheckedChanged
    '    If cargo Then
    '        cargo = False

    '        If Me.chkProductoGeneral.Checked Then
    '            Me.chkIngrediente.Checked = True
    '            Me.chkMezcla.Checked = True
    '        End If
    '        'If Not Me.chkMaterialEnvace.Checked And Not Me.chkIngrediente.Checked And Me.chkProductoGeneral.Checked Then
    '        '    Me.chkMaterialEnvace.Checked = True
    '        '    Me.chkIngrediente.Checked = True
    '        'End If

    '        cargo = True
    '        'Buscar()
    '    End If
    'End Sub

    Private Sub FrmBuscarProductos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.FormOwnerClosing Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub dgvProductosReg_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductosReg.CellDoubleClick
        If sender.Rows.Count > 0 Then
            'Me.pr.Clear()
            pr = New ClasesNegocio.ProductoCollectionClass

            'Recorrer el grid para ver cuales registros estan seleccionados
            For Each r As DataGridViewRow In Me.dgvProductosReg.SelectedRows
                'pr.Add(CType(r.DataBoundItem, ProductoGeneralClass))
                Dim p As New ClasesNegocio.ProductoGeneralClass
                p.Obtener(CInt(r.Cells(CodigoColumn.Index).Value))
                pr.Add(CType(p, ProductoGeneralClass))
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub dgvProductosReg_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProductosReg.CellFormatting
        'If e.ColumnIndex = 12 Then
        '    Dim prec As ClasesNegocio.ListaPrecioDetalleClass = DirectCast(dgvProductosReg.Rows(e.RowIndex).DataBoundItem, ClasesNegocio.ProductoGeneralClass).Precio(CodLista)
        '    If prec Is Nothing Then
        '        e.Value = 0
        '    Else
        '        e.Value = prec.PrecioVentaC
        '    End If
        'End If
    End Sub

    

    Private Sub txtDescripcion_Enter(sender As System.Object, e As System.EventArgs) Handles txtDescripcion.Enter
        txtCodBarra.Text = ""
    End Sub

    Private Sub txtCodBarra_Enter(sender As System.Object, e As System.EventArgs) Handles txtCodBarra.Enter
        txtDescripcion.Text = ""
    End Sub
End Class