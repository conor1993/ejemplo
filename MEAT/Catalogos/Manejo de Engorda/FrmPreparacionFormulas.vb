'Programa:          ERP MEAT
'Objetivo:          Preparacion de Formulas
'Modulo:            Preparacion de Formulas
'Elaboro:           Jorge Alfredo Niebla Ojeda
'Fecha Inicio:      Miercoles, 10 de Junio de 2009
'Fecha Modificado:  Miercoles, 10 de Junio de 2009
'Fecha Terminado:   
'Fecha Modificado:  
'Modificado Por:    

Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmPreparacionFormulas

#Region "Declaraciones"
    Dim EstatusForm As FormState
#End Region

#Region "Metodos"
    Private Function Buscar() As Boolean
        EstatusForm = FormState.Buscar
    End Function

    Private Function Cancelar() As Boolean
        EstatusForm = FormState.Cancelar
        Limpiar()
        ModoEdicion(EstatusEnum.INACTIVO)
        Return True
    End Function

    Private Function Limpiar() As Boolean
        dgvIngredientes.DataSource = Nothing
        txtCantidadReal.ResetText()

        For Each cont As Control In PanelEdicion.Controls
            If TypeOf cont Is TextBox Or TypeOf cont Is DateTimePicker Then
                cont.ResetText()
            ElseIf TypeOf cont Is ComboBox Then
                CType(cont, ComboBox).SelectedValue = -1
                CType(cont, ComboBox).SelectedText = cont.Tag
            End If
        Next
        Return True
    End Function

    Private Function Nuevo() As Boolean
        EstatusForm = FormState.Nuevo
        ModoEdicion(EstatusEnum.ACTIVO)

        Try
            Dim Coleccion As New CC.ConfigGanCollection()
            Coleccion.GetMulti(Nothing)
            Dim Configuracion As New ConfiguracionEngordaClass(Coleccion(0))
            cmbAlmacen.DataSource = AlmacenCollectionClass.CargarAlmacenes(HC.AlmacenFields.TipoAlmacen = Configuracion.TipoAlmacenFormula.Codigo)
            cmbFormula.DataSource = ProductoCollectionClass.CargarProductos(HC.ProductoFields.EsMezcla = True)
            cmbAlmacen.SelectedValue = -1
            cmbAlmacen.SelectedText = cmbAlmacen.Tag
            cmbFormula.SelectedValue = -1
            cmbFormula.SelectedText = cmbFormula.Tag
            MensajesValidacion()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Function Guardar() As Boolean

    End Function

    Private Function Borrar() As Boolean

    End Function

    Private Function Editar() As Boolean
        EstatusForm = FormState.Editar
        ModoEdicion(EstatusEnum.ACTIVO)
        MensajesValidacion()
    End Function

    Private Function Imprimir() As Boolean
        EstatusForm = FormState.Imprimir
    End Function

    Private Function Salir() As Boolean
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Function

    Private Sub ModoEdicion(ByVal Edicion As EstatusEnum)
        PanelEdicion.Enabled = IIf(Edicion = EstatusEnum.ACTIVO, True, False)
        dgvIngredientes.Enabled = PanelEdicion.Enabled
    End Sub

    Private Sub MensajesValidacion()
        ErrorProvider1.SetError(txtCantidad, "Ingrese la cantidad")
        ErrorProvider1.SetError(cmbAlmacen, cmbAlmacen.Tag)
        ErrorProvider1.SetError(cmbFormula, cmbFormula.Tag)
    End Sub
#End Region

#Region "Eventos"
    Private Sub FrmPreparacionFormulas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvIngredientes.AutoGenerateColumns = False
        ModoEdicion(EstatusEnum.INACTIVO)

        Try
            cmbAlmacen.DisplayMember = "Descripcion"
            cmbAlmacen.ValueMember = "AlmacenId"
            cmbFormula.DisplayMember = "Descripcion"
            cmbFormula.ValueMember = "Codigo"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

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

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If Not sender.Text = String.Empty Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Combos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedValueChanged, cmbFormula.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            ErrorProvider1.SetError(sender, "")

            If cmbFormula.Focused Then
                Dim Formulas As New ProductosMezclaCollection()
                Formulas.LeerColeccion(CType(sender.SelectedItem, EC.ProductoEntity).ProductoMezcla)
                dgvIngredientes.DataSource = Formulas
            End If
        Else
            If EstatusForm = FormState.Nuevo Or EstatusForm = FormState.Editar Then
                ErrorProvider1.SetError(sender, sender.Tag)

                If cmbFormula.Focused Then
                    dgvIngredientes.DataSource = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub dgvIngredientes_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvIngredientes.DataError

    End Sub
#End Region
End Class