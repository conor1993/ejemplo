Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports CN = ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class frmListaProdReg

    Private cargo As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Dim Linea As New CN.LineaClass()
    Dim marca As New CN.MarcaClass()
    Dim Lineas As New CN.LineaCollectionClass()
    Dim marcas As New CN.MarcaCollectionClass()
    Dim SubLineas As New CN.SubLineaCollectionClass()
    Dim productos As New CN.ProductoCollectionClass()
    'CN.Productos producto 

    Dim busqueda As New CN.BusquedaClass(Of CN.ProductoGeneralClass)()

    Private Sub frmListaProdReg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Edicion Then
            dgvProductosReg.MultiSelect = False
        Else
            dgvProductosReg.MultiSelect = True
        End If

        ' Trae todas las Líneas...
        'lineas.Obtener(CN.CondicionEnum.ACTIVOS) 
        Lineas.Obtener(CN.CondicionEnum.ACTIVOS)
        cmbLinea.DataSource = Lineas
        cmbLinea.DisplayMember = "Descripcion"
        cmbLinea.ValueMember = "Codigo"

        ' Trae todas las Marcas...

        marcas.Obtener(CN.CondicionEnum.ACTIVOS)
        cmbMarca.DataSource = marcas
        cmbMarca.DisplayMember = "nombre"
        cmbMarca.ValueMember = "Codigo"

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
    Dim _edit As Boolean
    Public Property Edicion() As Boolean
        Get
            Return _edit
        End Get
        Set(ByVal value As Boolean)
            _edit = value
        End Set
    End Property

    Dim _ing As Boolean
    Public Property ING() As Boolean
        Get
            Return _ing
        End Get
        Set(ByVal value As Boolean)
            _ing = value
        End Set
    End Property


    Dim pr As New CN.ProductoCollectionClass()

    ' Propiedad que envia los productos seleccionados en el grid...
    Public Property ProductosSeleccionados() As CN.ProductoCollectionClass
        Get
            Return pr
        End Get
        Set(ByVal value As CN.ProductoCollectionClass)
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
        Dim col As New CC.ProductoCollection
        Dim rel As OC.RelationCollection
        Dim filtro As New OC.PredicateExpression

        If (Me.cmbLinea.SelectedIndex > -1) Then
            rel = New OC.RelationCollection
            'rel.Add(EC.ProductoEntity.Relations.SubLineaEntityUsingSubLinea)
            filtro.Add(HC.LineaFields.Codigo = Me.cmbLinea.SelectedValue)
        End If

        If Me.cmbMarca.SelectedIndex > -1 Then
            filtro.Add(HC.ProductoFields.CodigoMarca = cmbMarca.SelectedValue)
        End If

        If Not (chkMezcla.Checked = chkProductoGeneral.Checked And chkMaterialEnvace.Checked = chkIngrediente.Checked) Then
            If chkMezcla.Checked <> chkProductoGeneral.Checked Then
                If chkMezcla.Checked Or (chkProductoGeneral.Checked And chkMaterialEnvace.Checked = chkIngrediente.Checked) Then
                    filtro.Add(HC.ProductoFields.EsMezcla = chkMezcla.Checked And HC.ProductoFields.ProductoGeneral = chkProductoGeneral.Checked)
                Else
                    filtro.Add(HC.ProductoFields.EsMezcla = False And HC.ProductoFields.ProductoGeneral = True And HC.ProductoFields.EsMaterialEnvase = chkMaterialEnvace.Checked And HC.ProductoFields.EsIngrediente = chkIngrediente.Checked)
                End If
            Else
                filtro.Add(HC.ProductoFields.EsMezcla = True Or (HC.ProductoFields.ProductoGeneral = True And HC.ProductoFields.EsMaterialEnvase = chkMaterialEnvace.Checked And HC.ProductoFields.EsIngrediente = chkIngrediente.Checked))
            End If
        End If

        If rbtActivos.Checked Then filtro.Add(HC.ProductoFields.Estatus = CN.EstatusEnum.ACTIVO)
        If rbtInactivos.Checked Then filtro.Add(HC.ProductoFields.Estatus = CN.EstatusEnum.INACTIVO)

        filtro.Add(New OC.FieldLikePredicate(HC.ProductoFields.Descripcion, String.Format("%{0}%", Me.txtDescripcion.Text.Trim())))

        'col.GetMulti(filtro, 0, null, rel)
        col.GetMulti(filtro, 0)

        productos.RellenarMe(col)

        Me.dgvProductosReg.DataSource = productos
    End Sub

#Region "Eventos"

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmbLinea_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbLinea.SelectedIndexChanged
        If cargo Then
            SubLineas.Clear()
            If cmbLinea.SelectedIndex >= 0 Then
                cargo = False
                Linea = DirectCast(cmbLinea.SelectedItem, CN.LineaClass)
                SubLineas = Linea.ObtenerSubLinea()
                cmbSubLinea.DataSource = SubLineas
                cmbSubLinea.DisplayMember = "Descripcion"
                cmbSubLinea.ValueMember = "Codigo"
                cmbSubLinea.SelectedIndex = -1
                cmbSubLinea.Text = "Seleccione una Sub-Línea..."
                Buscar()
                cargo = True
            End If
        End If
    End Sub

    'Private Sub cmbSubLinea_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSubLinea.SelectedIndexChanged
    '    If (cargo) Then
    '        If (cmbSubLinea.SelectedIndex > -1) Then
    '            SubLinea = (SubLineaClass)cmbSubLinea.SelectedItem 
    '            Buscar()
    '        End If
    '    End If
    'End Sub

    'Private Sub cmbMarca_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbMarca.SelectedIndexChanged
    '    If (cargo) Then
    '        If cmbMarca.SelectedIndex > -1 Then
    '            marca = (MarcaClass)cmbMarca.SelectedItem 
    '            Buscar()
    '        End If
    '    End If
    'End Sub

#End Region

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        Me.pr.Clear()

        'Recorrer el grid para ver cuales registros estan seleccionados
        For Each r As DataGridViewRow In Me.dgvProductosReg.SelectedRows
            pr.Add(DirectCast(r.DataBoundItem, CN.ProductoGeneralClass))
        Next
        If (productos.Count > 0) Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub frmListaProdReg_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.FormOwnerClosing Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDescripcion.TextChanged
        If cargo Then Buscar()
    End Sub


    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub chkProductoGeneral_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkProductoGeneral.CheckedChanged
        If cargo Then
            cargo = False

            If Not Me.chkProductoGeneral.Checked And Not chkMezcla.Checked Then
                chkProductoGeneral.Checked = True
                chkMezcla.Checked = True
            End If

            If Me.chkProductoGeneral.Checked Then
                Me.groupBox2.Enabled = True
                Me.chkIngrediente.Checked = True
                Me.chkMaterialEnvace.Checked = True
            Else
                Me.groupBox2.Enabled = False
                Me.chkIngrediente.Checked = False
                Me.chkMaterialEnvace.Checked = False
            End If

            cargo = True
            Buscar()
        End If
    End Sub

    Private Sub chkMezcla_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkMezcla.CheckedChanged
        If (cargo) Then
            cargo = False

            If Not chkProductoGeneral.Checked And Not chkMezcla.Checked Then
                Me.chkMezcla.Checked = True
                Me.chkProductoGeneral.Checked = True
                Me.groupBox2.Enabled = True
                Me.chkIngrediente.Checked = True
                Me.chkMaterialEnvace.Checked = True
            End If

            cargo = True
            Buscar()
        End If
    End Sub

    Private Sub dgvProductosReg_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles dgvProductosReg.DoubleClick
        'Recorrer el grid para ver cuales registros estan seleccionados
        For Each r As DataGridViewRow In Me.dgvProductosReg.SelectedRows
            pr.Add(DirectCast(r.DataBoundItem, CN.ProductoGeneralClass))
        Next

        If productos.Count > 0 Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub rbtActivos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtActivos.CheckedChanged
        If cargo Then Buscar()
    End Sub

    Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cargo Then Buscar()
    End Sub

    Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cargo Then Buscar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean)
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub chkIngrediente_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cargo Then
            cargo = False

            If ((Not Me.chkMaterialEnvace.Checked And Not Me.chkIngrediente.Checked) And Me.chkProductoGeneral.Checked) Then
                Me.chkMaterialEnvace.Checked = True
                Me.chkIngrediente.Checked = True
            End If

            cargo = True
            Buscar()
        End If
    End Sub

    Private Sub chkMaterialEnvace_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cargo Then
            cargo = False

            If ((Not Me.chkMaterialEnvace.Checked And Not Me.chkIngrediente.Checked) And Me.chkProductoGeneral.Checked) Then
                Me.chkMaterialEnvace.Checked = True
                Me.chkIngrediente.Checked = True
            End If

            cargo = True
            Buscar()
        End If
    End Sub

End Class
