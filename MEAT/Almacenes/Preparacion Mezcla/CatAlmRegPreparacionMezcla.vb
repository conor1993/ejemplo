Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class CatAlmRegPreparacionMezcla

#Region "Miembros"
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Private WithEvents preparacionMezcla As ClasesNegocio.Mezcla
    Dim cargandoDatosMezcla As Boolean = False
#End Region

#Region "Metodos"
    Private Sub limpiar()
        CmbPlaza.SelectedValue = "Seleccione Plaza"
        TxtFolioPreparacion.Clear()
        DtpFecha.Value = Now
        CmbAlmacen.SelectedValue = "Seleccione Almacen"
        CmbMezcla.SelectedValue = "Seleccione Paquete"
        Me.txtCantidadPreparar.Clear()
        Me.txtCantidadRealPreparada.Clear()
        Me.txtCantidadEnvases.Clear()
        TxtUnidad.Clear()
        CmbEnvase.SelectedValue = "Seleccione Envase"
        TxtTotal.Clear()
        TxtObservaciones.Clear()
        lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = ContentAlignment.MiddleCenter
        Me.dgIngredientes.Rows.Clear()
        Me.txtLote.Clear()
        Me.dtFechaCaducidad.Value = Now
        Me.txtLote.ReadOnly = True
        Me.dtFechaCaducidad.Enabled = False
    End Sub

    Private Sub deshabilitar()
        CmbPlaza.Enabled = False
        TxtFolioPreparacion.Enabled = False
        DtpFecha.Enabled = False
        CmbAlmacen.Enabled = False
        CmbMezcla.Enabled = False
        Me.txtCantidadPreparar.Enabled = False
        Me.txtCantidadRealPreparada.Enabled = False
        Me.txtCantidadEnvases.Enabled = False
        TxtUnidad.Enabled = False
        CmbEnvase.Enabled = False
        TxtTotal.Enabled = False
        TxtObservaciones.Enabled = False
        dgIngredientes.Enabled = False
        Me.dtFechaCaducidad.Enabled = False
        Me.txtLote.ReadOnly = True
    End Sub

    Private Sub Habilitar()
        CmbPlaza.Enabled = True
        TxtFolioPreparacion.Enabled = True
        DtpFecha.Enabled = True
        CmbAlmacen.Enabled = True
        CmbMezcla.Enabled = True
        Me.txtCantidadPreparar.Enabled = True
        Me.txtCantidadRealPreparada.Enabled = True
        Me.txtCantidadEnvases.Enabled = True
        TxtUnidad.Enabled = True
        CmbEnvase.Enabled = True
        TxtTotal.Enabled = False
        TxtObservaciones.Enabled = True
        dgIngredientes.Enabled = True
        Me.dtFechaCaducidad.Enabled = False
    End Sub

    Private Function ValidarDatosNulos() As Boolean
        If Me.CmbPlaza.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una palza", MsgBoxStyle.Exclamation, "Aviso")
            Me.CmbPlaza.Focus()
            Return False
        End If

        If Me.CmbAlmacen.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un almacén", MsgBoxStyle.Exclamation, "Aviso")
            Me.CmbAlmacen.Focus()
            Return False
        End If

        If Me.CmbMezcla.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una mezcla", MsgBoxStyle.Exclamation, "Aviso")
            Me.CmbMezcla.Focus()
            Return False
        End If

        If Not IsNumeric(Me.txtCantidadRealPreparada.Text) OrElse CDec(Me.txtCantidadRealPreparada.Text) = 0D Then
            MsgBox("La cantidad real a preparar debe ser mayor a 0.00", MsgBoxStyle.Exclamation, "Aviso")
            Me.txtCantidadPreparar.Focus()
            Return False
        End If

        'If Me.CmbEnvase.SelectedIndex = -1 Then
        '    MsgBox("Debe seleccionar un envase", MsgBoxStyle.Exclamation, "Aviso")
        '    Me.CmbEnvase.Focus()
        '    Return False
        'End If

        'If Not IsNumeric(Me.txtCantidadEnvases.Text) OrElse CDec(Me.txtCantidadEnvases.Text) = 0D Then
        '    MsgBox("Debe ingresar una cantidad de envases mayor a 0", MsgBoxStyle.Exclamation, "Aviso")
        '    Me.txtCantidadEnvases.Focus()
        '    Return False
        'End If

        If Me.dtFechaCaducidad.Enabled AndAlso Me.dtFechaCaducidad.Value <= Me.DtpFecha.Value Then
            MsgBox("La fecha de caducidad debe ser mayor a la fecha de preparación", MsgBoxStyle.Exclamation, "Aviso")
            Me.dtFechaCaducidad.Focus()
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Asigna valores a los controles de la ventana obtenidos de preparacionMezcla
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PasarValores()
        Me.CmbPlaza.SelectedValue = Me.preparacionMezcla.IdPlaza
        Me.CmbAlmacen.SelectedValue = Me.preparacionMezcla.IdAlmacen
        Me.CmbMezcla.SelectedValue = Me.preparacionMezcla.IdMezcla
        'Me.CmbEnvase.SelectedValue = Me.preparacionMezcla.IdEnvase
        Me.TxtFolioPreparacion.Text = Me.preparacionMezcla.FolioPreparacionMezcla
        Me.txtCantidadEnvases.Text = Me.preparacionMezcla.CantidadEnvase.ToString("N0")
        Me.txtCantidadPreparar.Text = Me.preparacionMezcla.CantidadPreparar.ToString("N3")
        Me.txtCantidadRealPreparada.Text = Me.preparacionMezcla.CantidadRealPreparada.ToString("N3")
        Me.txtLote.Text = Me.preparacionMezcla.Lote
        Me.TxtObservaciones.Text = Me.preparacionMezcla.Observaciones
        Me.TxtTotal.Text = Me.preparacionMezcla.CostoTotal.ToString("C2")
        Me.TxtUnidad.Text = Me.preparacionMezcla.Mezcla.UnidadMedida.DescCorta
        Me.dtFechaCaducidad.Value = Me.preparacionMezcla.FechaCaducidad.GetValueOrDefault(Now)
        Me.DtpFecha.Value = Me.preparacionMezcla.FechaPreparacion
        Me.dgIngredientes.DataSource = Me.preparacionMezcla.Ingredientes
        Me.CantidadDisponible.Visible = False
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub CatAlmRegPreparacionMEzcla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            deshabilitar()
            'Plazas

            Plazas.Obtener(CondicionEnum.ACTIVOS)
            Me.limpiar()
            Me.deshabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Toolbar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            Me.preparacionMezcla.IdUsuarioCacnelacion = Controlador.Sesion.Usrndx
            Me.preparacionMezcla.FechaCancelacion = Now

            If Me.preparacionMezcla.Borrar Then
                limpiar()
                Me.deshabilitar()
                MsgBox("Se cancelo la preparacion de mezcla", MsgBoxStyle.Information, "Aviso")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se cancelaba la preparación", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Cursor = Cursors.WaitCursor

        Try
            Dim ventana As New frmBusquedaPreparacionMezcla

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.preparacionMezcla = New Mezcla(ventana.dgTransferencias.SelectedRows(0).Cells(ventana.clmFolioPreparacionMezcla.Index).Value.ToString.Trim, _
                                            ventana.dgTransferencias.SelectedRows(0).Cells(ventana.clmIdPlaza.Index).Value)
                Me.PasarValores()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se consultaba una preparación", MsgBoxStyle.Critical, "Error")
#End If

            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not ValidarDatosNulos() Then
                Cancelar = True
                Exit Sub
            End If

            If Me.dtFechaCaducidad.Enabled Then Me.preparacionMezcla.FechaCaducidad = Me.dtFechaCaducidad.Value

            Me.preparacionMezcla.FechaPreparacion = Me.DtpFecha.Value
            'Me.preparacionMezcla.IdEnvase = Me.CmbEnvase.SelectedValue
            'Me.preparacionMezcla.CantidadEnvase = CDec(Me.txtCantidadEnvases.Text)
            Me.preparacionMezcla.IdUsuarioAlta = Controlador.Sesion.Usrndx

            If Me.preparacionMezcla.Guardar Then
                Me.preparacionMezcla.Imprimir(Controlador.Sesion.MiEmpresa.Empnom)
                Me.limpiar()
                Me.deshabilitar()
                MsgBox("Se preparo la mezcla con el folio " & Me.preparacionMezcla.FolioPreparacionMezcla, MsgBoxStyle.Information, "Aviso")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Try
            limpiar()
            Habilitar()
            Editar = False
            Me.preparacionMezcla = New ClasesNegocio.Mezcla
            Me.dgIngredientes.DataSource = Me.preparacionMezcla.Ingredientes
            Me.CantidadDisponible.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region "ComboBox"
    Private Sub CmbMezcla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMezcla.SelectedIndexChanged
        If Me.cargandoDatosMezcla Then Exit Sub

        Try
            If CmbMezcla.SelectedIndex > -1 Then
                Me.preparacionMezcla.Mezcla = DirectCast(Me.CmbMezcla.SelectedItem, ProductoClass)
                Me.TxtUnidad.Text = Me.preparacionMezcla.Mezcla.UnidadMedida.DescCorta
                Me.txtLote.ReadOnly = Not preparacionMezcla.Mezcla.SeManejaPorLotes
                Me.dtFechaCaducidad.Enabled = Me.preparacionMezcla.Mezcla.Caducidad
            Else
                Me.preparacionMezcla.Mezcla = Nothing
                Me.txtLote.Clear()
                Me.txtLote.ReadOnly = True
                Me.dtFechaCaducidad.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPlaza.SelectedIndexChanged
        Try
            If CmbPlaza.SelectedIndex > -1 Then
                Me.cargandoDatosMezcla = True
                Me.Almacenes.RellenarMe(DirectCast(Me.CmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).ObtenerEntidad.Almacen)
                Me.CmbAlmacen.SelectedIndex = -1
                Me.CmbAlmacen.Text = "Seleccione un almacén..."
                Me.preparacionMezcla.Plaza = DirectCast(Me.CmbPlaza.SelectedItem, PlazaClass)
                Me.cargandoDatosMezcla = False
            Else
                Me.Almacenes.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAlmacen.SelectedIndexChanged
        Try
            If CmbAlmacen.SelectedIndex > -1 Then
                Dim mezclas As New CC.ProductoCollection
                Dim envases As New CC.ProductoCollection
                Dim rel As New OC.RelationCollection

                Me.preparacionMezcla.Almacen = DirectCast(Me.CmbAlmacen.SelectedItem, AlmacenClass)

                rel.Add(New OC.EntityRelation(HC.ProductoFields.Codigo, HC.InventarioAlmacenFields.ProductoId, SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany), SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

                mezclas.GetMulti(HC.ProductoFields.EsMezcla = 1 And _
                                    HC.ProductoFields.Estatus = 1)
                envases.GetMulti(HC.ProductoFields.EsMaterialEnvase = 1 And _
                                    HC.ProductoFields.Estatus = 1 And _
                                    HC.InventarioAlmacenFields.AlmacenId = _
                                    CInt(Me.CmbAlmacen.SelectedValue), 0, Nothing, rel)

                Me.cargandoDatosMezcla = True
                Me.CmbMezcla.DataSource = Nothing
                Me.Mezclas.RellenarMe(mezclas)
                Me.CmbMezcla.DataSource = Me.Mezclas
                Me.CmbMezcla.SelectedIndex = -1
                Me.CmbMezcla.Text = "Seleccione una mezcla"
                Me.CmbEnvase.DataSource = Nothing
                Me.Envases.RellenarMe(envases)
                Me.CmbEnvase.DataSource = Me.Envases
                Me.CmbEnvase.SelectedIndex = -1
                Me.CmbEnvase.Text = "Seleccione un envase"
                Me.cargandoDatosMezcla = False
            Else
                Me.Mezclas.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "TextBox"
    Private Sub TxtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUnidad.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbEnvase.Focus()
            If TxtUnidad.Text = "" Then
                MsgBox("Agregue Información a Unidad")
                TxtUnidad.Focus()
            End If
        End If
    End Sub

    Private Sub TxtFolSalida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFolioPreparacion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            DtpFecha.Focus()
            If TxtFolioPreparacion.Text = "" Then
                MsgBox("Agregue Información a Folio Salida")
                TxtFolioPreparacion.Focus()
            End If
        End If
    End Sub

    Private Sub txtCantidadPreparar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadPreparar.TextChanged
        Try
            If IsNumeric(Me.txtCantidadPreparar.Text) Then
                Me.preparacionMezcla.CantidadPreparar = CDec(Me.txtCantidadPreparar.Text)
                Me.TxtTotal.Text = Me.preparacionMezcla.CostoTotal.ToString("C2")
                Me.dgIngredientes.Refresh()
                Me.txtCantidadRealPreparada.Text = Me.preparacionMezcla.CantidadRealPreparada.ToString("N3")
            Else
                Me.preparacionMezcla.CantidadPreparar = 0D
                Me.TxtTotal.Text = Me.preparacionMezcla.CostoTotal.ToString("C2")
                Me.dgIngredientes.Refresh()
                Me.txtCantidadRealPreparada.Text = Me.preparacionMezcla.CantidadRealPreparada.ToString("N3")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLote.TextChanged
        Me.preparacionMezcla.Lote = Me.txtLote.Text.Trim
    End Sub
#End Region

#Region "DateTipe"
    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbAlmacen.Focus()
        End If
    End Sub
#End Region

#Region "DataGird"
    Private Sub dgIngredientes_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgIngredientes.CellEndEdit
        Me.preparacionMezcla.CalcularCantidadRealPrepararYCostoTotal()
        Me.TxtTotal.Text = Me.preparacionMezcla.CostoTotal.ToString("C2")
        Me.txtCantidadRealPreparada.Text = Me.preparacionMezcla.CantidadRealPreparada.ToString("N3")
        Me.dgIngredientes.Refresh()
    End Sub
#End Region
#End Region
End Class