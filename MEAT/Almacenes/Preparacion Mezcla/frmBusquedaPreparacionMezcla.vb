Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaPreparacionMezcla

#Region "Campos"
    Private realizarConsulta As Boolean = True
    Private cargando As Boolean = True
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtFolioPreparacion.Clear()
        Me.txtCodigoAlmacen.Clear()
        Me.txtCodigoMezcla.Clear()
        Me.cmbPlaza.SelectedIndex = -1
        cmbPlaza.Text = "Seleccione una plaza..."
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un almacén..."
        Me.cmbMezcla.SelectedIndex = -1
        Me.cmbMezcla.Text = "Seleccione una mezcla..."
        Me.chkFiltrarFechas.Checked = False
        Me.gbRangoFecha.Enabled = False
        Me.chkPreparadas.Checked = True
        Me.chkCanceladas.Checked = True
    End Sub

    Private Sub BuscarMezcla()
        Try

            If Me.cmbAlmacen.SelectedIndex > -1 Then
                Dim rel As New OC.RelationCollection

                rel.Add(New OC.EntityRelation(HC.ProductoFields.Codigo, HC.InventarioAlmacenFields.ProductoId, _
                        SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany), _
                        SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

                Me.cmbMezcla.DataSource = Nothing
                Me.Mezclas.Obtener(HC.ProductoFields.EsMezcla = 1 And _
                                    HC.InventarioAlmacenFields.AlmacenId = _
                                    CInt(cmbAlmacen.SelectedValue), rel)
                Me.cmbMezcla.DataSource = Me.Mezclas
                Me.cmbMezcla.SelectedIndex = -1
                Me.cmbMezcla.Text = "Seleccione una mezcla..."
            Else
                Me.cmbMezcla.DataSource = Nothing
                Me.Mezclas.Obtener(HC.ProductoFields.EsMezcla = 1)
                Me.cmbMezcla.DataSource = Me.Mezclas
                Me.cmbMezcla.SelectedIndex = -1
                Me.cmbMezcla.Text = "Seleccione una mezcla..."
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar las mezclas", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub BuscarAlmacenes()
        Try
            If Me.cmbPlaza.SelectedIndex > -1 Then
                cmbAlmacen.DataSource = Nothing
                AlmacenC.Obtener(HC.AlmacenFields.Plaza = CInt(cmbPlaza.SelectedValue))
                cmbAlmacen.DataSource = Me.AlmacenC
                cmbAlmacen.SelectedIndex = -1
                cmbAlmacen.Text = "Seleccione un almacén..."
            Else
                cmbAlmacen.DataSource = Nothing
                AlmacenC.Obtener(CondicionEnum.TODOS)
                cmbAlmacen.DataSource = Me.AlmacenC
                cmbAlmacen.SelectedIndex = -1
                cmbAlmacen.Text = "Seleccione un almacén..."
            End If

            Me.BuscarMezcla()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se consultaban los almacenes", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
#End Region

#Region "Eventos"
#Region "Buttons"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgTransferencias.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "CheckBox"
    Private Sub chkFiltrarFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarFechas.CheckedChanged
        Me.dtFechaFinal.Value = Now
        Me.dtFechaInicial.Value = Now

        Me.gbRangoFecha.Enabled = Me.chkFiltrarFechas.Checked
    End Sub

    Private Sub chkPreparadas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPreparadas.CheckedChanged
        If Me.chkPreparadas.Checked = False AndAlso Me.chkCanceladas.Checked = False Then
            Me.chkPreparadas.Checked = True
            Me.chkCanceladas.Checked = True
        End If
    End Sub

    Private Sub chkCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCanceladas.CheckedChanged
        If Me.chkPreparadas.Checked = False AndAlso Me.chkCanceladas.Checked = False Then
            Me.chkPreparadas.Checked = True
            Me.chkCanceladas.Checked = True
        End If
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmbAlmacen_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.ActualizarCombo
        Me.realizarConsulta = False
        Me.BuscarMezcla()
        Me.realizarConsulta = True
    End Sub

    Private Sub cmbAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedValueChanged
        If Not realizarConsulta OrElse Me.cargando Then Exit Sub

        BuscarMezcla()
    End Sub

    Private Sub cmbPlaza_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedValueChanged
        If Me.cargando Then Exit Sub
        Me.realizarConsulta = False
        Me.BuscarAlmacenes()
        Me.realizarConsulta = True
    End Sub

    Private Sub cmbPlaza_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.ActualizarCombo
        Try
            Me.realizarConsulta = False
            Me.Plazas.Obtener(CondicionEnum.TODOS)
            cmbPlaza.SelectedIndex = -1
            cmbPlaza.Text = "Seleccione una plaza..."
            BuscarAlmacenes()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al actulizar el listado de plazas", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Me.realizarConsulta = True
        End Try
    End Sub

    Private Sub cmbMezcla_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMezcla.ActualizarCombo
        Me.BuscarMezcla()
    End Sub
#End Region

#Region "Form"
    Private Sub frmBusquedaPreparacionMezcla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Plazas.Obtener(CondicionEnum.TODOS)
        Limpiar()
        Me.cargando = False
    End Sub
#End Region

#Region "ToolBar"

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim mezclasImprimir As New MezclaCollection
            Dim filtro As New OC.PredicateExpression

            If Me.txtFolioPreparacion.Text.Trim = "" Then
                If cmbPlaza.SelectedIndex > -1 Then
                    filtro.Add(HC.CabPrepFormFields.IdPlaza = CInt(Me.cmbPlaza.SelectedValue))
                End If

                If cmbAlmacen.SelectedIndex > -1 Then
                    filtro.Add(HC.CabPrepFormFields.CveAlmacen = CInt(Me.cmbAlmacen.SelectedValue))
                End If

                If cmbMezcla.SelectedIndex > -1 Then
                    filtro.Add(HC.CabPrepFormFields.CveFormula = CInt(cmbMezcla.SelectedValue))
                End If

                If Me.chkFiltrarFechas.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.CabPrepFormFields.FecPrepForm, _
                                Me.dtFechaInicial.Value.ToShortDateString, _
                                Me.dtFechaFinal.Value.AddDays(1).ToShortDateString))
                End If

                If Not (Me.chkPreparadas.Checked And Me.chkCanceladas.Checked) Then
                    If Me.chkPreparadas.Checked Then
                        filtro.Add(HC.CabPrepFormFields.Estatus = Mezcla.EstatusPreparacionMezcla.PREPARADA)
                    Else
                        filtro.Add(HC.CabPrepFormFields.Estatus = Mezcla.EstatusPreparacionMezcla.CANCELADA)
                    End If
                End If
            Else
                filtro.Add(HC.CabPrepFormFields.FolPrepForm Mod String.Format("%{0}%", Me.txtFolioPreparacion.Text))
            End If

            mezclasImprimir.Obtener(filtro)
            mezclasImprimir.Imprimir(Controlador.Sesion.MiEmpresa.Empnom)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Dim vista As New TC.VwBusquedaPreparacionMezclaTypedView
            Dim filtro As New OC.PredicateExpression

            If Me.txtFolioPreparacion.Text.Trim = "" Then
                If cmbPlaza.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaPreparacionMezclaFields.IdPlaza = CInt(Me.cmbPlaza.SelectedValue))
                End If

                If cmbAlmacen.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaPreparacionMezclaFields.IdAlmacen = CInt(Me.cmbAlmacen.SelectedValue))
                End If

                If cmbMezcla.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaPreparacionMezclaFields.IdMezcla = CInt(cmbMezcla.SelectedValue))
                End If

                If Me.chkFiltrarFechas.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaPreparacionMezclaFields.FecPrepForm, _
                                Me.dtFechaInicial.Value.ToShortDateString, _
                                Me.dtFechaFinal.Value.AddDays(1).ToShortDateString))
                End If

                If Not (Me.chkPreparadas.Checked And Me.chkCanceladas.Checked) Then
                    If Me.chkPreparadas.Checked Then
                        filtro.Add(HC.VwBusquedaPreparacionMezclaFields.Estatus = Mezcla.EstatusPreparacionMezcla.PREPARADA)
                    Else
                        filtro.Add(HC.VwBusquedaPreparacionMezclaFields.Estatus = Mezcla.EstatusPreparacionMezcla.CANCELADA)
                    End If
                End If
            Else
                filtro.Add(HC.VwBusquedaPreparacionMezclaFields.FolPrepForm Mod String.Format("%{0}%", Me.txtFolioPreparacion.Text))
            End If

            vista.Fill(0, Nothing, False, filtro)

            Me.dgTransferencias.AutoGenerateColumns = False
            Me.dgTransferencias.DataSource = vista
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se realizaba la busqueda", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region
#End Region
End Class