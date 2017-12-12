Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

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
    Dim pr As New ProductoCollectionClass()
#End Region

    Private Sub FrmBuscarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Edicion Then
            dgvProductosReg.MultiSelect = False
        Else
            dgvProductosReg.MultiSelect = True
        End If

        ' Trae todas las Líneas...
        'lineas.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Lineas.Obtener(CondicionEnum.ACTIVOS)
        cmbLinea.DataSource = Lineas
        cmbLinea.DisplayMember = "Descripcion"
        cmbLinea.ValueMember = "Codigo"

        ' Trae todas las Marcas...

        'marcas.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'cmbMarca.DataSource = marcas
        'cmbMarca.DisplayMember = "nombre"
        'cmbMarca.ValueMember = "Codigo"

        limpiar()
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

        limpiar()
        cargo = True
        Buscar()
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

    Private Sub Buscar()
        Dim col As New CC.ProductoCollection()
        Dim rel As OC.RelationCollection = Nothing
        Dim filtro As New OC.PredicateExpression()

        If Me.cmbLinea.SelectedIndex > -1 Then
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
        filtro.Add(New OC.FieldLikePredicate(HC.ProductoFields.Descripcion, String.Format("%{0}%", Me.txtDescripcion.Text.Trim())))
        col.GetMulti(filtro, 0, Nothing, rel)
        productos.RellenarMe(col)
        Me.dgvProductosReg.DataSource = productos
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
        Me.pr.Clear()

        'Recorrer el grid para ver cuales registros estan seleccionados
        For Each r As DataGridViewRow In Me.dgvProductosReg.SelectedRows
            pr.Add(CType(r.DataBoundItem, ProductoGeneralClass))
        Next

        If (productos.Count > 0) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cargo Then
            Buscar()
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
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
            Me.pr.Clear()

            'Recorrer el grid para ver cuales registros estan seleccionados
            For Each r As DataGridViewRow In Me.dgvProductosReg.SelectedRows
                pr.Add(CType(r.DataBoundItem, ProductoGeneralClass))
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

 
  
End Class