Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports ClasesNegocio

Public Class MenusForm

    Private _menu As ECS.MenusEntity
    Private Menus As ClasesNegocio.MenuCollectionClass

    Private Sub sbLectura()
        Tabla.Enabled = False
        MiMenu.Enabled = True
        Me.MiMenu.CheckBoxes = False
    End Sub

    Private Sub sbEscritura()
        Tabla.Enabled = True
        MiMenu.Enabled = False
    End Sub

    Private Sub sbLimpiar()
        IdentificadorTextBox.Clear()
        SolucionTextBox.Clear()
        NombreTextBox.Clear()
        PadreTextBox.Clear()
        ObligatorioCheckBox.Checked = False
    End Sub

    Private Sub sbIniciarToolBar()
        Dim mtbConfig As MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        mtbConfig.StateBuscar = "110101101"
        mtbConfig.StateLimpiar = "100100001"
        mtbConfig.StateCancelar = "100110001"
        mtbConfig.StateNuevo = "011010000"
        mtbConfig.StateGuardar = "100100001"
        mtbConfig.StateBorrar = "100100001"
        mtbConfig.StateEditar = "011010000"
        mtbConfig.StateImprimir = ""
        mtbConfig.StateSalir = "000000000"
        mtb.ToolBarButtonStatus = mtbConfig
    End Sub

    Private Sub MenusForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sbIniciarToolBar()
            Menus = New ClasesNegocio.MenuCollectionClass
            Menus.Obtener(Me.MdiParent.FindForm.Tag)
            MiMenu.Menus = New ILTreeViewMenu.MenuCollectionClass(Menus.ObtenerColeccion)
            sbLectura()
            mtb.sbCambiarEstadoBotones("Cancelar")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        sbLimpiar()
        sbLectura()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        sbEscritura()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            _menu.Mnuglo = ObligatorioCheckBox.Checked
            _menu.Mnuid = IdentificadorTextBox.Text
            _menu.Mnunom = NombreTextBox.Text
            _menu.Mnupad = PadreTextBox.Text
            _menu.Mnusol = SolucionTextBox.Text
            If _menu.Save() Then
                MsgBox("Menu almacenado")
                Menus.Obtener(Me.MdiParent.Name)
                MiMenu.Nodes.Clear()
                MiMenu.Menus = New ILTreeViewMenu.MenuCollectionClass(Menus.ObtenerColeccion)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        sbLimpiar()
        sbLectura()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        sbLimpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub ObtenerMenusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObtenerMenusButton.Click
        Try
            'Dim Trans As New HCS.Transaction(IsolationLevel.ReadCommitted, "Guardar")

            Menus = New ClasesNegocio.MenuCollectionClass
            Menus.LeerMenuStrip(Me.MdiParent.MainMenuStrip)
            MiMenu.Nodes.Clear()
            'RemoverMenus()
            Me.GuardarMenus()
            MiMenu.Menus = New ILTreeViewMenu.MenuCollectionClass(Menus.ObtenerColeccion)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GuardarMenus() As Boolean
        Dim trans As New HCS.Transaction(IsolationLevel.ReadCommitted, "Menus")

        Try
            GuardarMenu(Me.Menus, Nothing, trans)

            trans.Commit()
            Return True
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Sub GuardarMenu(ByVal menus As MenuCollectionClass, ByRef padre As ECS.MenusEntity, ByRef trans As HCS.Transaction)
        For Each menu As MenuClass In menus
            Dim menuC As New CCS.MenusCollection
            Dim ent As ECS.MenusEntity

            trans.Add(menuC)
            menuC.GetMulti(HCS.MenusFields.Mnuid = menu.NombreCorto And HCS.MenusFields.Mnusol = Me.MdiParent.FindForm.Tag)

            If menuC.Count > 0 Then
                ent = menuC(0)
            Else
                ent = New ECS.MenusEntity
            End If

            trans.Add(ent)

            If padre IsNot Nothing Then
                ent.Mnupad = padre.Mnundx
            End If

            ent.Mnusol = menu.Solucion
            ent.Mnunom = menu.Nombre
            ent.Mnuid = menu.NombreCorto
            ent.Mnuglo = menu.Obligatorio
            ent.Save()
            GuardarMenu(menu.MisMenus, ent, trans)
        Next
    End Sub

    Private Sub RemoverMenus()
        Dim Trans As New HCS.Transaction(IsolationLevel.ReadCommitted, "Borrar Menus")

        Try
            Dim Lista As New List(Of String)
            Dim Filtro As New OC.PredicateExpression
            Dim ColeccionMenus As New CCS.MenusCollection

            For Each Menu As ECS.MenusEntity In Menus.ObtenerColeccion()
                ObtenerMenusHijos(Lista, Menu)
            Next
            Filtro.Add(New OC.FieldCompareRangePredicate(HCS.MenusFields.Mnuid, True, Lista))
            ColeccionMenus.GetMulti(Filtro)
            Trans.Add(ColeccionMenus)
            ColeccionMenus.DeleteMulti()
            Trans.Commit()
        Catch ex As Exception
            Trans.Rollback()
        End Try
    End Sub

    Private Sub ObtenerMenusHijos(ByRef Lista As List(Of String), ByVal MenuPadre As ECS.MenusEntity)
        If MenuPadre.MisMenus.Count > 0 Then
            For Each Menu As ECS.MenusEntity In MenuPadre.MisMenus
                ObtenerMenusHijos(Lista, Menu)
            Next
        Else
            Lista.Add(MenuPadre.Mnuid)
        End If
    End Sub

    Private Sub MiMenu_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles MiMenu.AfterSelect
        Try
            _menu = MiMenu.MenuSeleccionado.ObtenerEntidad
            IdentificadorTextBox.Text = _menu.Mnuid
            SolucionTextBox.Text = _menu.Mnusol
            NombreTextBox.Text = _menu.Mnunom
            PadreTextBox.Text = _menu.MiPadre.Mnunom
            ObligatorioCheckBox.Checked = _menu.Mnuglo
            mtb.sbCambiarEstadoBotones("Buscar")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class