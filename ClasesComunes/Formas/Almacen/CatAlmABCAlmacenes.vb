Imports System.Windows.Forms
Imports Ec = IntegraLab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CatAlmABCAlmacenes
    Dim Editar As Boolean = False
    Dim puedorefrescar As Boolean = True
    Dim seleccionado As Boolean = False
    Dim WithEvents Almacen As New ClasesNegocio.AlmacenClass
    Dim WithEvents AlmacenCol As New IntegraLab.ORM.CollectionClasses.AlmacenCollection
    Dim WithEvents Almacenes As New ClasesNegocio.AlmacenCollectionClass
    Dim WithEvents Talmacen As New ClasesNegocio.TipoAlmacenCollectionClass
    Dim WithEvents Plazas As New ClasesNegocio.PlazaCollectionClass
    Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.AlmacenClass)
    Dim Familias As New CC.LineaCollection

    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPlaza.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If CmbPlaza.SelectedIndex = -1 Then
                MsgBox("Seleccione una Plaza", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.CmbTipoAlmacen.Focus()
            End If
        End If
    End Sub

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripcion.Focus()
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripcionCorta.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Información a Descripción", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescripcionCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcionCorta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLetra.Focus()
            If TxtDescripcionCorta.Text = "" Then
                MsgBox("Agregue Información a Descripción Corta", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescripcionCorta.Focus()
            End If
        End If
    End Sub

    Private Sub TxtLetra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLetra.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If TxtLetra.Text = "" Then
                MsgBox("Agregue Información a Letra", MsgBoxStyle.Exclamation, "Aviso")
                TxtLetra.Focus()
            Else
                Me.CmbPlaza.Focus()
            End If
        End If
    End Sub

    Private Sub CmbAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbTerceros.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If Me.CmbTerceros.SelectedIndex = -1 Then
                MsgBox("Seleccione un almacén", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.rbtGeneral.Focus()
            End If
        End If
    End Sub

    Private Sub almacen_modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Almacen.Modificado
        If puedorefrescar Then
            TxtCodigo.Text = Almacen.Codigo
            TxtDescripcion.Text = Almacen.Descripcion
            TxtDescripcionCorta.Text = Almacen.DescripcionCorta
            lblEstatus.Text = Almacen.Estatus.ToString
            Me.CmbTipoAlmacen.SelectedValue = Almacen.TipoAlmacen.Codigo

            If Almacen.Terceros = True Then
                Me.chkTerceros.Checked = True
                Dim Clientes As New ClasesNegocio.ClientesIntroductoresClass
                Clientes.Obtener(Almacen.IdCliente)
                Me.CmbTerceros.Text = Clientes.Nombre
                Me.CmbTerceros.SelectedValue = Almacen.IdCliente
            Else
                Me.CmbTerceros.SelectedIndex = -1
                Me.CmbTerceros.Text = "Seleccione un cliente"
                Me.CmbTerceros.Enabled = False
            End If

            Me.CmbPlaza.SelectedValue = Almacen.Plaza.Codigo
            Me.TxtLetra.Text = Almacen.Letras
            Me.txtCuentaContable.Text = Almacen.CuentaContable.NombreCuenta & ": " & Almacen.CuentaContable.CuentaContable

        End If

    End Sub

    Private Sub almacen_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Almacen.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

#Region "Metodos"
    Private Sub limpiar()
        'Me.rbtGeneral.Checked = True
        Me.rbtVenta.Checked = True
        Me.txtCuentaContable.Clear()
        CmbPlaza.SelectedIndex = -1
        CmbPlaza.Text = "Seleccione Plaza"
        TxtCodigo.Clear()
        DtpFecha.Value = Now
        TxtDescripcion.Clear()
        TxtDescripcionCorta.Clear()
        TxtLetra.Clear()
        CmbTipoAlmacen.SelectedIndex = -1
        CmbTipoAlmacen.Text = "Seleccione Tipo Almacen"
        CmbTerceros.SelectedIndex = -1
        lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        Editar = False
        Me.seleccionado = False
        Me.TxtDescripcion.Focus()
        Me.dgvFamilias.Rows.Clear()
        Me.dgvFamiliasenAlmacen.Rows.Clear()
        LlenarGridDeFamilias()
    End Sub

    Private Sub deshabilitar()
        Me.txtCuentaContable.Enabled = False
        Me.btnCuentaContable.Enabled = False
        CmbPlaza.Enabled = False
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescripcionCorta.Enabled = False
        TxtLetra.Enabled = False
        CmbTipoAlmacen.Enabled = False
        CmbTerceros.Enabled = False
        'Me.gbTipoProducto.Enabled = False
        'DGContable.Enabled = False
        DataGrid.Enabled = True
        Me.dgvFamilias.Enabled = False
        Me.dgvFamiliasenAlmacen.Enabled = False
    End Sub

    Private Sub Habilitar()
        'Me.gbTipoProducto.Enabled = True
        Me.txtCuentaContable.Enabled = True
        Me.btnCuentaContable.Enabled = True
        CmbPlaza.Enabled = True
        TxtDescripcion.Enabled = True
        TxtDescripcionCorta.Enabled = True
        TxtLetra.Enabled = True
        CmbTipoAlmacen.Enabled = True
        CmbTerceros.Enabled = False
        DataGrid.Enabled = False
        Me.dgvFamilias.Enabled = True
        Me.dgvFamiliasenAlmacen.Enabled = True
    End Sub

    Private Sub Guardar()
        Almacen.Descripcion = TxtDescripcion.Text
        Almacen.DescripcionCorta = TxtDescripcionCorta.Text
        Almacen.TipoAlmacen = DirectCast(Me.CmbTipoAlmacen.SelectedItem, ClasesNegocio.TipoAlmacenClass)
        'Almacen.Almacen = DirectCast(Me.CmbTerceros.SelectedItem, ClasesNegocio.AlmacenClass)
        Almacen.FechaAlta = DtpFecha.Value
        Almacen.UsuarioAlta = Controlador.Sesion.Usrndx
        Almacen.Plaza = DirectCast(Me.CmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)
        Almacen.Letras = Me.TxtLetra.Text
        If Me.chkTerceros.Checked Then
            Almacen.Terceros = Me.chkTerceros.Checked
            Almacen.IdCliente = Me.CmbTerceros.SelectedValue
        Else
            Almacen.IdCliente = 0
        End If


        If Me.rbtCongelado.Checked Then
            Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.CONGELADO
        ElseIf Me.rbtFresco.Checked Then
            Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.FRESCO
        ElseIf Me.rbtGeneral.Checked Then
            Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.GENERAL
        Else
            Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.VENTA
        End If
    End Sub

    Public Function Validar() As Boolean
        Select Case ""
            Case Me.TxtDescripcion.Text
                MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TxtDescripcion.Focus()
                Return False
            Case Me.TxtDescripcionCorta.Text
                MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TxtDescripcionCorta.Focus()
                Return False
            Case Me.TxtLetra.Text
                MsgBox("Debe ingresar una letra", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TxtLetra.Focus()
                Return False
        End Select

        Select Case -1
            Case Me.CmbPlaza.SelectedIndex
                MsgBox("Debe ingresar una plaza", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.CmbTerceros.Focus()
                Return False
            Case Me.CmbTipoAlmacen.SelectedIndex
                MsgBox("Debe ingresar un tipo de almacén", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.CmbTerceros.Focus()
                Return False
            Case Me.CmbTerceros.SelectedIndex And DirectCast(Me.CmbTipoAlmacen.SelectedItem, ClasesNegocio.TipoAlmacenClass).SubAlmacen = ClasesNegocio.TipoAlmacenEnum.SUBALMACEN
                MsgBox("Debe ingresar un almacén", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.CmbTerceros.Focus()
                Return False
        End Select

        'If Almacen.CuentaContable.NombreCuenta.Trim = "" Then
        '    MsgBox("Selesccione una cuenta contable para el almacen", MsgBoxStyle.Exclamation, "Aviso")
        '    Me.btnCuentaContable.Focus()
        '    Return False
        'End If
        Return True
    End Function
#End Region

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Dim ventana As New FrmBuscarAlmacenes

        If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Almacen = New ClasesNegocio.AlmacenClass()

            If Almacen.Obtener(CInt(ventana.dgvAlmacenes.CurrentRow.Cells(ventana.clmCodigo.Index).Value)) Then
                Me.puedorefrescar = True
                almacen_modificado(Me, e)
                Me.puedorefrescar = False
                mtb.sbCambiarEstadoBotones("Buscar")
                Me.CmbTerceros.Enabled = False
                Me.seleccionado = True
                Me.lblEstatus.Visible = True
                Me.txtCuentaContable.Text = Almacen.CuentaContable.NombreLargo
                Me.LlenarGridDeFamiliasenAlmacen(Almacen.Codigo)
                EliminarFamiliasDelGrid()
                Me.rbtFresco.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.FRESCO
                Me.rbtCongelado.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.CONGELADO
                Me.rbtGeneral.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.GENERAL
                Me.rbtVenta.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.VENTA

            Else
                MsgBox("No selecciono un elemento valido.", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Me.seleccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Try
            Cursor = Cursors.WaitCursor
            Habilitar()
            Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.AlmacenAlmacenesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.Almacen = New ClasesNegocio.AlmacenClass
            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub CatAlmABCAlmacenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "010101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100011"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "0010100001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        Me.mtb.Buttons(1).Visible = False
        deshabilitar()

        Me.AlmacenTodosC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
        Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.AlmacenAlmacenesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Familias.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        'Me.dgvFamilias.AutoGenerateColumns = False

        'Familias.GetMulti(Nothing, 0, Nothing)
        'If Familias.Count > 0 Then
        '    Me.dgvFamilias.AutoGenerateColumns = False
        '    Me.dgvFamilias.DataSource = Familias
        'End If
        limpiar()
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBorrar
        Try
            Cursor = Cursors.WaitCursor
            If Me.chkTerceros.Checked Then
                Almacen.Terceros = Me.chkTerceros.Checked
                Almacen.IdCliente = Me.CmbTerceros.SelectedValue
            Else
                Almacen.IdCliente = 0
            End If
            If Almacen.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                Almacen.UsuarioBaja = 1
                If Almacen.Borrar Then
                    MsgBox("El Almacen ha sido inactivado.", MsgBoxStyle.Information, "Aviso")
                    deshabilitar()
                    Me.AlmacenTodosC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                    Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                    Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                    Me.AlmacenAlmacenesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                    limpiar()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("El Almacen ya ha sido inactivado.", MsgBoxStyle.Exclamation, "Aviso")
                limpiar()
                deshabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        Try
            Cursor = Cursors.WaitCursor
            If Almacen.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                Habilitar()
                Editar = True
                Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.AlmacenAlmacenesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.puedorefrescar = True
                almacen_modificado(Me, e)
                Me.puedorefrescar = False
                Me.TxtDescripcion.Focus()
            Else
                If MessageBox.Show("El Almacén esta inactivo, ¿Desea Activarlo?", "Activar Almacén", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    Select Case ClasesNegocio.EstatusEnum.INACTIVO
                        Case Almacen.Plaza.Estatus
                            MsgBox("No se puede activar el almacén, necesita activar la plaza " & Almacen.Plaza.Descripcion, MsgBoxStyle.Exclamation, "Plaza Inactiva")
                            Cancelar = True
                            Exit Sub
                        Case Almacen.TipoAlmacen.Estatus
                            MsgBox("No se puede activar el almacén, necesita activar el tipo de almacén " & Almacen.TipoAlmacen.Descripcion, MsgBoxStyle.Exclamation, "Tipo de Almacén Inactivo")
                            Cancelar = True
                            Exit Sub
                        Case Almacen.Almacen.Estatus
                            If Not Almacen.Codigo = Almacen.Almacen.Codigo Then
                                MsgBox("No se puede activar el sub-almacén, necesita activar el almacén " & Almacen.Almacen.Descripcion, MsgBoxStyle.Exclamation, "Almacén Inactivo")
                                Cancelar = True
                                Exit Sub
                            End If
                    End Select

                    Almacen.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblEstatus.Text = Almacen.Estatus.ToString
                    Habilitar()
                    Me.TxtDescripcion.Focus()
                    Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                    Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                    Me.AlmacenAlmacenesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                    Me.puedorefrescar = True
                    almacen_modificado(Me, e)
                    Me.puedorefrescar = False
                    Me.TxtDescripcion.Focus()
                Else
                    Cancelar = True
                    mtb.sbCambiarEstadoBotones("Guardar")
                    limpiar()
                    deshabilitar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Try
            Cursor = Cursors.WaitCursor

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            Guardar()
            puedorefrescar = True


            If Almacen.Guardar Then
                Dim CodigoAlm As Integer
                If Not Editar Then
                    CodigoAlm = Almacen.IdAlmacenRetorno
                Else
                    CodigoAlm = Almacen.Codigo
                End If
                'guardar el detalle de familias
                For i As Integer = 0 To Me.dgvFamiliasenAlmacen.Rows.Count - 1
                    Dim AlmacenesFamilias As New CN.AlmacenFamiliaClass
                    Dim AlmacenesFamilias2 As New CN.AlmacenFamiliaClass
                    AlmacenesFamilias.AlmacenID = CodigoAlm
                    AlmacenesFamilias.FamiliaID = Me.dgvFamiliasenAlmacen.Rows(i).Cells(Me.clmCodigoAlmacen.Index).Value
                    AlmacenesFamilias2.AlmacenID = CodigoAlm
                    AlmacenesFamilias2.FamiliaID = Me.dgvFamiliasenAlmacen.Rows(i).Cells(Me.clmCodigoAlmacen.Index).Value
                    'elimina los datos de la tabla de familias
                    If Not AlmacenesFamilias.Borrar() Then
                        Cancelar = True
                    End If
                    'agrega los datos a la tabla de familias
                    If Not AlmacenesFamilias2.Guardar() Then
                        Cancelar = True
                    End If
                Next
                'buscar datos en familia espejo para eliminar de la tabla almacenes familias
                If Editar Then
                    For i As Integer = 0 To Me.dgvFamilasEspejo.Rows.Count - 1
                        Dim AlmacenesFam As New CN.AlmacenFamiliaClass
                        AlmacenesFam.AlmacenID = Almacen.Codigo
                        AlmacenesFam.FamiliaID = Me.dgvFamilasEspejo.Rows(i).Cells(Me.clmCodigoFamiliaEspejo.Index).Value
                        'elimina los datos de la tabla de familias
                        If Not AlmacenesFam.Borrar() Then
                            Cancelar = True
                        End If
                    Next
                End If

                deshabilitar()
                Me.AlmacenTodosC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.AlmacenAlmacenesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                If Editar Then
                    MsgBox("El Almacen se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("El Almacen se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If
                limpiar()

            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub CmbTipoAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbTipoAlmacen.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.CmbTipoAlmacen.SelectedIndex = -1 Then
                MsgBox("Seleccione un tipo de almacén", MsgBoxStyle.Exclamation, "Aviso")
            Else
                If DirectCast(Me.CmbTipoAlmacen.SelectedItem, ClasesNegocio.TipoAlmacenClass).SubAlmacen Then
                    Me.CmbTerceros.Focus()
                Else
                    Me.rbtGeneral.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub CmbTipoAlmacen_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbTipoAlmacen.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.TipoAlmacenC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub CmbTipoAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoAlmacen.SelectedIndexChanged
        If Me.CmbTipoAlmacen.SelectedIndex = -1 Then
            Me.CmbTerceros.Enabled = False
        Else
            If DirectCast(Me.CmbTipoAlmacen.SelectedItem, ClasesNegocio.TipoAlmacenClass).SubAlmacen Then
                Me.CmbTerceros.Enabled = True
                Me.CmbTerceros.SelectedIndex = -1
                Me.CmbTerceros.Text = "Seleccione un Almacen"
                Me.CmbTerceros.Focus()
            Else
                Me.CmbTerceros.Enabled = False
                Me.CmbTerceros.SelectedIndex = -1
                Me.CmbTerceros.Text = "Seleccione un Almacen"
            End If
        End If
    End Sub

    Private Sub btnCuentaContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentaContable.Click
        Dim ventana As New BusquedaCuentasContablesForm

        ventana.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
        ventana.NarutalezaDefault(False) = ClasesNegocio.CuentaContableNaturalezaCondicionEnum.DEUDORAS

        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Almacen.CuentaContable = ventana.CuentaContable
            Me.txtCuentaContable.Text = ventana.CuentaContable.NombreCuenta & ": " & ventana.CuentaContable.CuentaContable
        End If
    End Sub

    Private Sub CmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbPlaza.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub CmbAlmacen_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbTerceros.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.AlmacenAlmacenesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If Me.txtFiltro.Text.Length > 5 Or e.KeyChar = Chr(13) Then
                Me.AlmacenTodosC.Obtener(Me.txtFiltro.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTerceros.SelectedIndexChanged

    End Sub

    Private Sub DataGrid_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid.MouseClick
        Try

            If Me.DataGrid.SelectedRows.Count = 0 Then
                Exit Sub
            End If

            Almacen = New ClasesNegocio.AlmacenClass()

            If Almacen.Obtener(CInt(Me.DataGrid.CurrentRow.Cells(Me.DataGridViewTextBoxColumn1.Index).Value)) Then
                Me.puedorefrescar = True
                almacen_modificado(Me, e)
                Me.puedorefrescar = False
                mtb.sbCambiarEstadoBotones("Buscar")
                Me.CmbTerceros.Enabled = False
                Me.seleccionado = True
                Me.lblEstatus.Visible = True
                Me.txtCuentaContable.Text = Almacen.CuentaContable.NombreLargo

                Me.rbtFresco.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.FRESCO
                Me.rbtCongelado.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.CONGELADO
                Me.rbtGeneral.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.GENERAL
                Me.rbtVenta.Checked = Almacen.ObtenerEntidad.TipoProducto = ClasesNegocio.TipoProductoAlmacen.VENTA
            Else
                MsgBox("No selecciono un elemento valido.", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkTerceros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTerceros.CheckedChanged
        If Me.chkTerceros.Checked Then
            Dim Clientes As CN.ClientesIntroductoresColeccion
            Clientes = New CN.ClientesIntroductoresColeccion
            Clientes.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.CmbTerceros.ValueMember = "Codigo"
            Me.CmbTerceros.DisplayMember = "Nombre"
            Me.CmbTerceros.DataSource = Clientes
            Me.CmbTerceros.Enabled = True
        Else
            Me.CmbTerceros.DataSource = Nothing
            Me.CmbTerceros.Enabled = False
        End If
    End Sub

    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub dgvFamilias_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFamilias.CellClick
        If e.ColumnIndex = 0 Then
            Dim Renglon As Integer
            Renglon = e.RowIndex
            ColocarDatosEnFamiliaAlmacen(Renglon)
        End If
    End Sub

    Private Sub ColocarDatosEnFamiliaAlmacen(ByVal Renglon As Integer)
        Try
            Dim Codigo As Integer
            Dim Descripcion As String
            Codigo = Me.dgvFamilias.CurrentRow.Cells(Me.clmCodigo.Index).Value
            Descripcion = Me.dgvFamilias.CurrentRow.Cells(Me.clmFamilia.Index).Value
            Me.dgvFamiliasenAlmacen.Rows.Add()
            For i As Integer = 0 To Me.dgvFamiliasenAlmacen.Rows.Count - 1
                If Me.dgvFamiliasenAlmacen.Rows(i).Cells(Me.clmFamiliaAlmacen.Index).Value = "" Then
                    Me.dgvFamiliasenAlmacen.Rows(i).Cells(Me.clmCodigoAlmacen.Index).Value = Codigo
                    Me.dgvFamiliasenAlmacen.Rows(i).Cells(Me.clmFamiliaAlmacen.Index).Value = Descripcion
                End If
            Next
            Me.dgvFamilias.Rows.RemoveAt(Renglon)
            Me.dgvFamilias.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvFamilias_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFamilias.DataError

    End Sub

    Private Sub dgvFamiliasenAlmacen_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFamiliasenAlmacen.CellClick
        If e.ColumnIndex = 0 Then
            Dim Renglon As Integer
            Renglon = e.RowIndex
            QuitarDatosEnFamiliaAlmacen(Renglon)
        End If
    End Sub

    Private Sub QuitarDatosEnFamiliaAlmacen(ByVal Renglon As Integer)
        Try
            If Editar Then
                Me.AgregarFamiliaAEspejo()
            End If
            Dim Codigo As Integer
            Dim Descripcion As String
            Codigo = Me.dgvFamiliasenAlmacen.CurrentRow.Cells(Me.clmCodigoAlmacen.Index).Value
            Descripcion = Me.dgvFamiliasenAlmacen.CurrentRow.Cells(Me.clmFamiliaAlmacen.Index).Value
            Me.dgvFamilias.Rows.Add()
            For i As Integer = 0 To Me.dgvFamilias.Rows.Count - 1
                If Me.dgvFamilias.Rows(i).Cells(Me.clmFamilia.Index).Value = "" Then
                    Me.dgvFamilias.Rows(i).Cells(Me.clmCodigo.Index).Value = Codigo
                    Me.dgvFamilias.Rows(i).Cells(Me.clmFamilia.Index).Value = Descripcion
                End If
            Next
            Me.dgvFamiliasenAlmacen.Rows.RemoveAt(Renglon)
            Me.dgvFamiliasenAlmacen.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarGridDeFamilias()
        Familias.GetMulti(Nothing, 0, Nothing)
        Me.dgvFamilias.AutoGenerateColumns = False
        If Familias.Count > 0 Then
            For i As Integer = 0 To Familias.Count - 1
                Dim a As Integer
                a = Me.dgvFamilias.Rows.Add()
                Me.dgvFamilias.Rows(a).Cells(Me.clmCodigo.Index).Value = Familias(i).Codigo
                Me.dgvFamilias.Rows(a).Cells(Me.clmFamilia.Index).Value = Familias(i).Descripcion
            Next
        End If
    End Sub

    Private Sub LlenarGridDeFamiliasenAlmacen(ByVal CodigoAlmacen As Integer)
        Dim FamiliasenAlmacen As New CC.AlmacenesFamiliasCollection
        Dim Filtro As New OC.PredicateExpression

        Filtro.Add(HC.AlmacenesFamiliasFields.CodigoAlmacen = CodigoAlmacen)

        FamiliasenAlmacen.GetMulti(Filtro, 0, Nothing)
        Me.dgvFamiliasenAlmacen.AutoGenerateColumns = False
        If FamiliasenAlmacen.Count > 0 Then
            For i As Integer = 0 To FamiliasenAlmacen.Count - 1
                Dim a As Integer
                Dim Filtro1 As New OC.PredicateExpression
                a = Me.dgvFamiliasenAlmacen.Rows.Add()
                Me.dgvFamiliasenAlmacen.Rows(a).Cells(Me.clmCodigoAlmacen.Index).Value = FamiliasenAlmacen(i).CodigoLinea
                Filtro1.Add(HC.LineaFields.Codigo = FamiliasenAlmacen(i).CodigoLinea)
                Familias.GetMulti(Filtro1, 0, Nothing)
                If Familias.Count > 0 Then
                    Me.dgvFamiliasenAlmacen.Rows(a).Cells(Me.clmFamiliaAlmacen.Index).Value = Familias(0).Descripcion
                End If
            Next
        End If
    End Sub


    Private Sub EliminarFamiliasDelGrid()
        Dim Renglon As Integer
        Dim Band As Boolean
        Band = False
        For i As Integer = 0 To Me.dgvFamilias.Rows.Count - 1
            Renglon = i
            For j As Integer = 0 To Me.dgvFamiliasenAlmacen.Rows.Count - 1
                If Me.dgvFamilias.Rows(i).Cells(Me.clmCodigo.Index).Value = Me.dgvFamiliasenAlmacen.Rows(j).Cells(Me.clmCodigoAlmacen.Index).Value Then
                    Me.dgvFamilias.Rows.RemoveAt(Renglon)
                    Band = True
                    Exit For
                End If
            Next
            If Band = True Then
                Exit For
            End If
        Next
        If Band Then
            Me.dgvFamilias.Refresh()
            EliminarFamiliasDelGrid()
        End If
    End Sub

    Private Sub AgregarFamiliaAEspejo()
        Dim Codigo As Integer
        Dim Descripcion As String
        Codigo = Me.dgvFamiliasenAlmacen.CurrentRow.Cells(Me.clmCodigoAlmacen.Index).Value
        Descripcion = Me.dgvFamiliasenAlmacen.CurrentRow.Cells(Me.clmFamiliaAlmacen.Index).Value
        Me.dgvFamilasEspejo.Rows.Add()
        For i As Integer = 0 To Me.dgvFamilasEspejo.Rows.Count - 1
            If Me.dgvFamilasEspejo.Rows(i).Cells(Me.clmDescripcionFamiliaEspejo.Index).Value = "" Then
                Me.dgvFamilasEspejo.Rows(i).Cells(Me.clmCodigoFamiliaEspejo.Index).Value = Codigo
                Me.dgvFamilasEspejo.Rows(i).Cells(Me.clmDescripcionFamiliaEspejo.Index).Value = Descripcion
            End If
        Next
        Me.dgvFamilasEspejo.Refresh()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir


    End Sub

End Class