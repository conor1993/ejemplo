'Programa:          ERP MEAT
'Objetivo:          ABC de Nutrientes
'Modulo:            ABC de Nutrientes
'Elaboro:           Jorge Alfredo Niebla Ojeda
'Fecha Inicio:      Miercoles, 5 de Junio de 2009
'Fecha Modificado:  Miercoles, 5 de Junio de 2009
'Fecha Terminado:   Miercoles, 5 de Junio de 2009
'Fecha Modificado:  
'Modificado Por:   

Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class FrmNutrientes

#Region "Miembros"
    Dim Nutriente As NutrienteClass
#End Region

#Region "Forma"
    Private Sub FrmNutrientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "101101111"
        MtbEstados.StateLimpiar = "011010001"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtbMenu.ToolBarButtonStatus = MtbEstados
        mtbMenu.sbCambiarEstadoBotones("Cancelar")
        Inhabilitar()
        cmbUnidadMedida.DisplayMember = "Descripcion"
        cmbUnidadMedida.ValueMember = "Codigo"
        cmbUnidadMedida.DataSource = UnidadesMedidaCollectionClass.CargarUnidadesMedida(HC.UnidadMedidaFields.Estatus = "1")
        cmbUnidadMedida.SelectedIndex = -1
        cmbUnidadMedida.SelectedText = "Seleccione la unidad de medida"
        dgvNutrientes.AutoGenerateColumns = False
        dgvNutrientes.DataSource = NutrientesCollectionClass.CargarNutrientes()
    End Sub
#End Region

#Region "Metodos"

#Region "Acciones"
    Private Function Limpiar() As Boolean
        txtDescripcion.Text = String.Empty
        cmbUnidadMedida.SelectedIndex = -1
        cmbUnidadMedida.SelectedText = "Seleccione la unidad de medida"
        Return True
    End Function

    Private Function Cancelar() As Boolean
        Limpiar()
        Inhabilitar()
        Return True
    End Function

    Private Function Nuevo() As Boolean
        Limpiar()
        Nutriente = New NutrienteClass()
        Habilitar()
        Return True
    End Function

    Private Function Editar() As Boolean
        If Nutriente.Estatus = EstatusEnum.INACTIVO AndAlso _
            MessageBox.Show("El nutriente esta inactivo, ¿Desea activarlo?", "Activar Nutriente ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Return False
        End If

        Habilitar()
        Refrescar()
        Return True
    End Function

    Private Function Guardar() As Boolean
        If Validar() Then
            InicializarInstancia()
            If Nutriente.Guardar() Then
                MsgBox("El Nutriente se ha guardado satisfactoriamente", MsgBoxStyle.Information, "ERP MEAT")
                Limpiar()
                Inhabilitar()
                dgvNutrientes.DataSource = Nothing
                dgvNutrientes.DataSource = NutrientesCollectionClass.CargarNutrientes()
                Return True
            End If
        End If
    End Function

    Private Function Imprimir() As Boolean
        NutrientesCollectionClass.Imprimir(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        Return True
    End Function

    Private Function Borrar() As Boolean
        If Nutriente.Estatus = EstatusEnum.INACTIVO Then
            MsgBox("El Nutriente ya ha sido eliminado", MsgBoxStyle.Information, "ERP MEAT")
            Return False
        End If

        If MessageBox.Show("Seguro que desea eliminarlo", "ERP MEAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes AndAlso Nutriente.Borrar() Then
            MsgBox("El Nutriente se ha borrado satisfactoriamente", MsgBoxStyle.Information, "ERP MEAT")
            Limpiar()
            Inhabilitar()
            dgvNutrientes.DataSource = Nothing
            dgvNutrientes.DataSource = NutrientesCollectionClass.CargarNutrientes()
            Return True
        End If
    End Function

    Private Sub Salir()
        Me.Close()
    End Sub
#End Region

    Private Sub Inhabilitar()
        txtDescripcion.ReadOnly = True
        cmbUnidadMedida.Enabled = False
        dgvNutrientes.Enabled = True
    End Sub

    Private Sub Habilitar()
        txtDescripcion.ReadOnly = False
        cmbUnidadMedida.Enabled = True
        dgvNutrientes.Enabled = False
    End Sub

    Private Function Validar() As Boolean
        If txtDescripcion.Text = String.Empty Then
            MsgBox("Debe proporcionar la descripcion", MsgBoxStyle.Exclamation, "Aviso")
            txtDescripcion.Focus()
            Return False
        ElseIf cmbUnidadMedida.SelectedValue Is Nothing Then
            MsgBox("Debe proporcionar la unidad de medida", MsgBoxStyle.Exclamation, "Aviso")
            cmbUnidadMedida.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub Refrescar()
        txtDescripcion.Text = Nutriente.Descripcion.Trim()
        cmbUnidadMedida.SelectedValue = Nutriente.IdUnidad
    End Sub

    Private Sub InicializarInstancia()
        Nutriente.Descripcion = txtDescripcion.Text.Trim
        Nutriente.Estatus = EstatusEnum.ACTIVO
        Nutriente.IdUnidad = cmbUnidadMedida.SelectedValue
    End Sub
#End Region

#Region "Eventos"

#Region "Acciones"
    Private Sub Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtbMenu.ClickBuscar, mtbMenu.ClickGuardar, mtbMenu.ClickEditar, mtbMenu.ClickCancelar, mtbMenu.ClickBorrar, mtbMenu.ClickSalir, mtbMenu.ClickNuevo, mtbMenu.ClickLimpiar, mtbMenu.ClickImprimir
        Dim Resultado As Boolean = False

        Select Case e.Button.Text
            Case "Limpiar"
                Resultado = Me.Limpiar()
            Case "Cancelar"
                Resultado = Me.Cancelar()
            Case "Nuevo"
                Resultado = Me.Nuevo()
            Case "Guardar"
                Resultado = Me.Guardar()
            Case "Borrar"
                Resultado = Me.Borrar()
            Case "Editar"
                Resultado = Me.Editar()
            Case "Imprimir"
                Resultado = Me.Imprimir()
            Case "Salir"
                Me.Salir()
        End Select

        Cancelar = Not Resultado
    End Sub
#End Region

#Region "DataGridView"
    Private Sub dgvNutrientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNutrientes.CellDoubleClick
        If dgvNutrientes.SelectedRows.Count > 0 Then
            Nutriente = New NutrienteClass(CType(dgvNutrientes.SelectedRows(0).DataBoundItem, EC.CatNutrientesEntity))
            Refrescar()
            mtbMenu.sbCambiarEstadoBotones("Buscar")
        End If
    End Sub

    Private Sub dgvNutrientes_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvNutrientes.CellFormatting
        If e.ColumnIndex = clmUnidad.Index Then
            e.Value = UnidadesMedidaClass.CargarUnidadMedida(Integer.Parse(e.Value)).Descripcion
        ElseIf e.ColumnIndex = clmEstatus.Index Then
            e.Value = IIf(e.Value.ToString = "1", "ACTIVO", "INACTIVO").ToString
        End If
    End Sub
#End Region

    Private Sub cmbUnidadMedida_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbUnidadMedida.Format
        e.Value = e.Value.ToString.Trim()
    End Sub

#End Region

End Class