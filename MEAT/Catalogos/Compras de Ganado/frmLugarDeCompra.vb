Imports ClasesNegocio
Imports CN = ClasesNegocio

Public Class frmLugarDeCompra
    Dim Estados As CN.EstadoCollectionClass
    Dim Ciudades As CN.CiudadCollectionClass
    Dim Poblaciones As CN.PoblacionCollectionClass
#Region "Miembros"
    Dim lugarDeCompra As LugaresDeCompraClass

    Dim editando As Boolean = False
#End Region

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtHorasTransporte.Clear()
        Me.editando = False
        Me.txtCodigo.Clear()
        Me.cmbEstado.SelectedIndex = -1
        Me.cmbEstado.Text = "Seleccione un estado..."
        Me.txtDescripcion.Clear()
        Me.lblEstatus.Text = "ESTATUS"
        Me.cmbCiudad.SelectedIndex = -1
        Me.cmbPoblacion.SelectedIndex = -1
    End Sub

    Private Sub Habilitar()
        Me.txtHorasTransporte.Enabled = True
        Me.cmbEstado.Enabled = True
        Me.cmbCiudad.Enabled = True
        Me.cmbPoblacion.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.lblEstatus.Visible = True
        Me.GroupBox1.Enabled = False
        Me.txtCodigoCiudad.Enabled = True
        Me.txtCodigoEstado.Enabled = True
        Me.txtCodigoPoblacion.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtHorasTransporte.Enabled = False
        Me.cmbEstado.Enabled = False
        Me.cmbCiudad.Enabled = False
        Me.cmbPoblacion.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.lblEstatus.Visible = False
        Me.GroupBox1.Enabled = True
        Me.txtCodigoCiudad.Enabled = False
        Me.txtCodigoEstado.Enabled = False
        Me.txtCodigoPoblacion.Enabled = False
    End Sub

#End Region

#Region "Eventos"

#Region "Form"
    Private Sub frmLugarDeCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "101001101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.EstadoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.LugaresDeCompraC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Me.Deshabilitar()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "TextBox"

#End Region

#Region "DataGrid"

    Private Sub dgLugaresDeCompra_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLugaresDeCompra.CellDoubleClick
        If e.RowIndex > -1 Then
            Me.lugarDeCompra = CType(dgLugaresDeCompra.Rows(e.RowIndex).DataBoundItem, LugaresDeCompraClass)
            Me.txtCodigo.Text = Me.lugarDeCompra.IdLugarCompra
            Me.txtDescripcion.Text = Me.lugarDeCompra.Descripcion
            Me.cmbEstado.SelectedValue = lugarDeCompra.Entidad.IdEstado
            Me.cmbCiudad.SelectedValue = lugarDeCompra.Entidad.IdCiudad
            Me.cmbPoblacion.SelectedValue = lugarDeCompra.Entidad.IdPoblacion
            Me.lblEstatus.Text = Me.lugarDeCompra.Estatus.ToString
            Me.txtHorasTransporte.Text = Me.lugarDeCompra.Entidad.HorasTransporte
            Me.lblEstatus.Visible = True
            Me.mtb.sbCambiarEstadoBotones("Buscar")
        End If
    End Sub

#End Region

#Region "ComboBox"
    Private Sub cmbEstado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedValueChanged
        Try
            If Me.cmbEstado.SelectedIndex > -1 Then
                Ciudades = New CN.CiudadCollectionClass
                Ciudades.Obtener(Me.cmbEstado.SelectedValue, ClasesNegocio.CondicionEnum.ACTIVOS)

                Me.cmbCiudad.DataSource = Nothing
                Me.cmbCiudad.ValueMember = "Codigo"
                Me.cmbCiudad.DisplayMember = "Descripcion"
                Me.cmbCiudad.DataSource = Ciudades
                Me.cmbCiudad.SelectedIndex = -1
                Me.cmbPoblacion.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCiudad_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCiudad.SelectedValueChanged
        Try
            If Me.cmbCiudad.SelectedIndex > -1 Then
                Poblaciones = New CN.PoblacionCollectionClass
                ''Poblaciones.Obtener(Me.cmbCiudad.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                Poblaciones.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, CInt(cmbEstado.SelectedValue), CInt(cmbCiudad.SelectedValue))

                Me.cmbPoblacion.DataSource = Nothing
                Me.cmbPoblacion.ValueMember = "Codigo"
                Me.cmbPoblacion.DisplayMember = "Descripcion"
                Me.cmbPoblacion.DataSource = Poblaciones
                Me.cmbPoblacion.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "ToolBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Me.lugarDeCompra.Borrar(Nothing) Then
                MsgBox("Se inactivo el lugar de compra", MsgBoxStyle.Information, "Aviso")
                Deshabilitar()
                Limpiar()
            Else
                MsgBox("No se logro inactivar", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Deshabilitar()
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            If Me.lugarDeCompra.Estatus = EstatusEnum.ACTIVO Then
                Me.editando = True
                Me.Habilitar()
            Else
                If MessageBox.Show("El lugar de compra esta INACTIVO. ¿Quiere activarlo?", "Activar Lugar De Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.lugarDeCompra.Estatus = EstatusEnum.ACTIVO
                    Me.editando = True
                    Me.Habilitar()
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Me.txtDescripcion.Text.Trim = "" Then
                MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Me.cmbPoblacion.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar una población", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If
            If Me.cmbEstado.SelectedIndex < 0 Then
                MsgBox("Debe seleccionar un estado", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            If Me.cmbCiudad.SelectedIndex < 0 Then
                MsgBox("Debe seleccionar una ciudad", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
                Exit Sub
            End If


            lugarDeCompra.Descripcion = Me.txtDescripcion.Text.Trim
            lugarDeCompra.Entidad.IdEstado = Me.cmbEstado.SelectedValue
            lugarDeCompra.Entidad.IdCiudad = Me.cmbCiudad.SelectedValue
            lugarDeCompra.Entidad.IdPoblacion = Me.cmbPoblacion.SelectedValue
            lugarDeCompra.Entidad.HorasTransporte = Me.txtHorasTransporte.Text


            If Me.lugarDeCompra.Guardar(Nothing) Then
                If Me.editando Then
                    MsgBox("Se modifico el lugar de compra", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Deshabilitar()
                Else
                    MsgBox("Se guardo el lugar de compra", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Deshabilitar()
                End If

                Me.LugaresDeCompraC.Obtener()
            Else
                MsgBox("No se logro guardar", MsgBoxStyle.Exclamation, "Aviso")
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            LugaresDeCompraC.Obtener()
            If LugaresDeCompraC.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatLugaresDeCompra = LugaresDeCompraC.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(LugaresDeCompraC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Compras de Ganado\Lugares de Compra")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Lugar de Compra", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Me.lugarDeCompra = New LugaresDeCompraClass
            Me.EstadoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.Limpiar()
            Me.Habilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#End Region


End Class