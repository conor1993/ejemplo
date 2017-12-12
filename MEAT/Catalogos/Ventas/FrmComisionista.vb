
Public Class FrmComisionista
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim seleccionado As Boolean = False
    Dim WithEvents Comisionista As New ClasesNegocio.VendedorClass
    Dim ComisionistaC As New ClasesNegocio.VendedorCollectionClass

    Private Sub FrmComisionista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "101101101"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "0010100001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            MEAToolBar1.ToolBarButtonStatus = MtbEstados
            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

            deshabilitar()

            'OJO
            Me.EstadoCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            ' Me.TipoComisionistaCol.Obtener(Integra.Clases.CondicionEnum.ACTIVOS)
            Me.ZonaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            limpiar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error al abrir la ventana", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "MEAToolBar"

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Try
            Cursor = Cursors.WaitCursor
            If Comisionista.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If Comisionista.Borrar Then
                    MsgBox("El Vendedor ha sido Inactivado.", MsgBoxStyle.Information, "Aviso")
                    deshabilitar()
                    limpiar()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("El Vendedor ya está Inactivado.", MsgBoxStyle.Exclamation, "Aviso")
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

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        limpiar()
        deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        Try
            Cursor = Cursors.WaitCursor

            If Comisionista.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                habilitar()
                Editar = True
            Else
                If MsgBox("El Vendedor esta inactivo, ¿Desea Activarlo?", MsgBoxStyle.OkCancel, "Activar Vendedor") = MsgBoxResult.Ok Then
                    Select Case ClasesNegocio.EstatusEnum.INACTIVO
                        Case Comisionista.Zona.Estatus
                            MsgBox(String.Format("No se activo, la zona {0} está inactiva", Comisionista.Zona.Descripcion), MsgBoxStyle.Exclamation, "Aviso")
                            Cancelar = True
                            MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                            limpiar()
                            deshabilitar()
                            'Case Comisionista.TipoComicionista.Estatus
                            '    MsgBox(String.Format("No se activo, el tipo de vendedor {0} esta inactivo", Comisionista.TipoComicionista.Descripcion), MsgBoxStyle.Exclamation, "Aviso")
                            '    Cancelar = True
                            '    MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                            '    limpiar()
                            '    deshabilitar()
                        Case Comisionista.Plaza.Estatus
                            MsgBox(String.Format("No se activo, la plaza {0} está inactiva", Comisionista.Plaza.Descripcion), MsgBoxStyle.Exclamation, "Aviso")
                            Cancelar = True
                            MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                            limpiar()
                            deshabilitar()
                        Case Else
                            Comisionista.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                            Me.lblEstatus.Text = Comisionista.Estatus.ToString
                            Me.lblEstatus.Visible = True
                            habilitar()
                            Editar = True
                    End Select
                Else
                    Cancelar = True
                    MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                    limpiar()
                    deshabilitar()
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error al habilitar la edición", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            Cursor = Cursors.WaitCursor

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            guardar()
            puedorefrescar = True

            If Comisionista.Guardar Then
                If Editar Then
                    MsgBox("El Vendedor se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("El Vendedor se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If

                limpiar()
                deshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        limpiar()
        habilitar()
        Comisionista = New ClasesNegocio.VendedorClass
        Me.TxtNombre.Focus()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Cursor = Cursors.WaitCursor

            Dim ventana As New FrmBuscarComisionista

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Comisionista = ventana.DataGrid.SelectedRows(0).DataBoundItem
                Me.puedorefrescar = True
                Me.Comisionista_Modificado(Me, New EventArgs)
                Me.puedorefrescar = False
                Me.lblEstatus.Visible = True
                Me.seleccionado = True
                ComisionistaC.Add(Comisionista)
                Me.txtSueldo.Enabled = False
                Me.txtPorcentaje.Enabled = False
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error al buscar los vendedores", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Cursor = Cursors.WaitCursor
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Previsualizar.Text = "Impresión de Vendedores"

            ComisionistaC.Obtener(Integra.Clases.CondicionEnum.TODOS)
            If ComisionistaC.Count.ToString > 0 Then
                Previsualizar.Reporte = ComisionistaC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                Previsualizar.ShowDialog()
            Else
                MsgBox("No se enconto ningun Vendedor", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Metodos"

    Private Sub limpiar()
        Me.txtSueldo.Clear()
        Me.txtPorcentaje.Clear()
        txtCtaCont.Clear()
        TxtCodigo.Clear()
        DtpFechaAlta.Value = Now
        TxtNombre.Clear()
        TxtAPaterno.Clear()
        TxtAmaterno.Clear()
        txtPlaza.Clear()
        CmbPlaza.SelectedIndex = -1
        CmbPlaza.SelectedValue = "Seleccione Plaza"
        'TxtCodTvendedor.Clear()
        'CmbTVendedor.SelectedIndex = -1
        'CmbTVendedor.SelectedValue = "Seleccione Tipo Vendedor"
        TxtDomicilio.Clear()
        TxtRfc.Clear()
        TxtColonia.Clear()
        TxtCp.Clear()
        TxtCodEdo.Clear()
        CmbEstado.SelectedIndex = -1
        CmbEstado.SelectedValue = "Seleccione Estado"
        txtCodCdad.Clear()
        CmbCiudad.SelectedIndex = -1
        CmbCiudad.SelectedValue = "Seleccione Ciudad"
        txtCodPob.Clear()
        CmbPoblacion.SelectedIndex = -1
        CmbPoblacion.SelectedValue = "Seleccione Población"
        TxtCorreo.Clear()
        'txtCodZona.Clear()
        'CmbZona.SelectedIndex = -1
        'CmbZona.SelectedValue = "Seleccione Zona"
        TxtLada.Clear()
        TxtTelefono.Clear()
        TxtLada1.Clear()
        TxtTelefono1.Clear()
        TxtLada2.Clear()
        TxtFax.Clear()
        seleccionado = False
        Editar = False
        Me.lblEstatus.Visible = False
        Me.TxtNombre.Focus()
        ComisionistaC.Clear()
        Me.TabControl.SelectedIndex = 0
    End Sub

    Private Sub habilitar()
        Me.txtSueldo.Enabled = True
        Me.txtPorcentaje.Enabled = True
        txtCtaCont.Enabled = True
        Me.btnCtaCont.Enabled = True
        TxtNombre.Enabled = True
        TxtAPaterno.Enabled = True
        TxtAmaterno.Enabled = True
        txtPlaza.Enabled = True
        CmbPlaza.Enabled = True
        'TxtCodTvendedor.Enabled = True
        'CmbTVendedor.Enabled = True
        TxtDomicilio.Enabled = True
        TxtColonia.Enabled = True
        TxtCp.Enabled = True
        TxtCodEdo.Enabled = True
        CmbEstado.Enabled = True
        txtCodCdad.Enabled = True
        CmbCiudad.Enabled = True
        txtCodPob.Enabled = True
        CmbPoblacion.Enabled = True
        TxtCorreo.Enabled = True
        'txtCodZona.Enabled = True
        'CmbZona.Enabled = True
        TxtLada.Enabled = True
        TxtTelefono.Enabled = True
        TxtLada1.Enabled = True
        TxtTelefono1.Enabled = True
        TxtLada2.Enabled = True
        TxtFax.Enabled = True
        TxtRfc.Enabled = True
    End Sub

    Private Sub deshabilitar()
        Me.txtSueldo.Enabled = False
        Me.txtPorcentaje.Enabled = False
        txtCtaCont.Enabled = False
        Me.btnCtaCont.Enabled = False
        TxtNombre.Enabled = False
        TxtAPaterno.Enabled = False
        TxtAmaterno.Enabled = False
        txtPlaza.Enabled = False
        CmbPlaza.Enabled = False
        'TxtCodTvendedor.Enabled = False
        'CmbTVendedor.Enabled = False
        TxtDomicilio.Enabled = False
        TxtColonia.Enabled = False
        TxtCp.Enabled = False
        TxtCodEdo.Enabled = False
        CmbEstado.Enabled = False
        txtCodCdad.Enabled = False
        CmbCiudad.Enabled = False
        txtCodPob.Enabled = False
        CmbPoblacion.Enabled = False
        TxtCorreo.Enabled = False
        'txtCodZona.Enabled = False
        'CmbZona.Enabled = False
        TxtLada.Enabled = False
        TxtTelefono.Enabled = False
        TxtLada1.Enabled = False
        TxtTelefono1.Enabled = False
        TxtLada2.Enabled = False
        TxtFax.Enabled = False
        TxtRfc.Enabled = False
    End Sub

    Private Sub guardar()

        Comisionista.FechaAlta = DtpFechaAlta.Text
        Comisionista.Nombre = TxtNombre.Text
        Comisionista.Apaterno = TxtAPaterno.Text
        Comisionista.Amaterno = TxtAmaterno.Text
        Comisionista.Plaza = DirectCast(Me.CmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)
        'Comisionista.TipoComicionista = DirectCast(Me.CmbTVendedor.SelectedItem, ClasesNegocios.TipoVendedorClass)
        Comisionista.Domicilio = TxtDomicilio.Text
        Comisionista.Colonia = TxtColonia.Text
        Comisionista.CodigoPostal = TxtCp.Text
        Comisionista.IdEstado = CInt(CmbEstado.SelectedValue)
        Comisionista.IdCiudad = CInt(CmbCiudad.SelectedValue)
        Comisionista.IdPoblacion = CInt(CmbPoblacion.SelectedValue)
        Comisionista.Email = TxtCorreo.Text
        'Comisionista.Zona = DirectCast(Me.CmbZona.SelectedItem, ClasesNegocio.ZonaClass)
        Comisionista.Lada = TxtLada.Text
        Comisionista.Telefono = TxtTelefono.Text
        Comisionista.Lada1 = TxtLada1.Text
        Comisionista.Telefono1 = TxtTelefono1.Text
        Comisionista.Lada2 = TxtLada2.Text
        Comisionista.Fax = TxtFax.Text
        Comisionista.Rfc = TxtRfc.Text

        If Me.txtSueldo.Enabled Then
            Me.Comisionista.Sueldo = CDec(Me.txtSueldo.Text.Replace("$", "").Replace(",", ""))
        Else
            Me.Comisionista.Sueldo = 0
        End If

        If Me.txtPorcentaje.Enabled Then
            Me.Comisionista.Porcentaje = CDbl(Me.txtPorcentaje.Text.Replace("%", ""))
        Else
            Me.Comisionista.Porcentaje = 0
        End If
    End Sub

    Private Function Validar() As Boolean
        Select Case ""
            Case Me.TxtNombre.Text
                MsgBox("Debe ingresar un nombre", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TxtNombre.Focus()
                Return False
            Case Me.TxtAPaterno.Text
                MsgBox("Debe ingresar un apellido paterno", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TxtAPaterno.Focus()
                Return False
            Case Me.TxtAmaterno.Text
                MsgBox("Debe ingresar un apellido materno", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TxtAmaterno.Focus()
                Return False
            Case Me.TxtRfc.Text
                MsgBox("Debe ingresar un RFC", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TabControl.SelectedIndex = 0
                Me.TxtRfc.Focus()
                Return False
            Case Me.TxtDomicilio.Text
                MsgBox("Debe ingresar un domicilio", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TabControl.SelectedIndex = 0
                Me.TxtDomicilio.Focus()
                Return False
            Case Me.TxtColonia.Text
                MsgBox("Debe ingresar una colonia", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TabControl.SelectedIndex = 0
                Me.TxtColonia.Focus()
                Return False
            Case Me.TxtCp.Text
                MsgBox("Debe ingresar un código Ppostal", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TabControl.SelectedIndex = 0
                Me.TxtCp.Focus()
                Return False
            Case Me.TxtCorreo.Text
                MsgBox("Debe ingresar un e-mail", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TabControl.SelectedIndex = 0
                Me.TxtCorreo.Focus()
                Return False
        End Select


        Select Case -1
            Case Me.CmbPlaza.SelectedIndex
                MsgBox("Debe ingresar una plaza", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.CmbPlaza.Focus()
                Return False
                'Case Me.CmbTVendedor.SelectedIndex
                '    MsgBox("Debe ingresar un tipo de comisionista", MsgBoxStyle.Exclamation, "Faltan Datos")
                '    CmbTVendedor.Focus()
                '    Return False
            Case Me.CmbPoblacion.SelectedIndex
                MsgBox("Debe ingresar una población", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.TabControl.SelectedIndex = 0

                If CmbCiudad.Items.Count = 0 Then
                    CmbEstado.Focus()
                ElseIf CmbCiudad.SelectedIndex = -1 Then
                    CmbCiudad.Focus()
                Else
                    CmbPoblacion.Focus()
                End If

                Return False
                'Case Me.CmbZona.SelectedIndex
                '    MsgBox("Debe ingresar una zona", MsgBoxStyle.Exclamation, "Faltan Datos")
                '    CmbZona.Focus()
                '    Return False
        End Select

        If Me.txtSueldo.Enabled AndAlso Me.txtSueldo.Text = "" Then
            MsgBox("Debe ingresar un sueldo", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtSueldo.Focus()
            Return False
        End If

        If Me.txtPorcentaje.Enabled AndAlso Me.txtPorcentaje.Text = "" Then
            MsgBox("debe ingresar un procentaje de comisión", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.txtPorcentaje.Focus()
            Return False
        End If

        If Me.Comisionista.CuentaContable.CuentaMayor = "" Then
            MsgBox("Debe establecer una cuenta contable", MsgBoxStyle.Exclamation, "Faltan Datos")
            Me.TabControl.SelectedIndex = 1
            Me.btnCtaCont.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

#Region "Keypress"

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtAPaterno.Focus()
            If TxtNombre.Text = "" Then
                MsgBox("Agregue Información a Nombre. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub TxtAPaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAPaterno.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtAmaterno.Focus()
            If TxtAPaterno.Text = "" Then
                MsgBox("Agregue Información al Apeido Paterno. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtAPaterno.Focus()
            End If
        End If
    End Sub

    Private Sub TxtAmaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmaterno.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtPlaza.Focus()
            If TxtAmaterno.Text = "" Then
                MsgBox("Agregue Información al Apeido Materno. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtAmaterno.Focus()
            End If
        End If
    End Sub

    Private Sub txtPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlaza.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtPlaza.Text) Then
                Me.CmbPlaza.SelectedValue = CInt(Me.txtPlaza.Text)
                If Me.CmbPlaza.SelectedIndex = -1 Then
                    MsgBox("No existe una plaza con este código o se encuentra inactiva", MsgBoxStyle.Exclamation, "Aviso")
                    CmbPlaza.Text = "Seleccione una plaza..."
                    CmbPlaza.Focus()
                    txtPlaza.Clear()
                Else
                    Me.txtSueldo.Focus()
                End If
            Else
                Me.txtPlaza.Text = ""
                Me.CmbPlaza.Focus()
            End If
        End If
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    'Private Sub TxtCodTvendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        If IsNumeric(Me.TxtCodTvendedor.Text) Then
    '            Me.CmbTVendedor.SelectedValue = CInt(Me.TxtCodTvendedor.Text)
    '            Me.txtCodZona.Focus()
    '        Else
    '            Me.TxtCodTvendedor.Text = ""
    '            Me.CmbTVendedor.Focus()
    '        End If
    '    End If
    '    If Not e.KeyChar = Chr(8) Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub
    'Private Sub txtCodZona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        If IsNumeric(Me.txtCodZona.Text) Then
    '            Me.CmbZona.SelectedValue = CInt(Me.txtCodZona.Text)
    '            Me.txtSueldo.Focus()
    '        Else
    '            Me.txtCodZona.Text = ""
    '            Me.CmbZona.Focus()
    '        End If
    '    End If
    '    If Not e.KeyChar = Chr(8) Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    Private Sub CmbZona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtSueldo.Focus()
            'If CmbZona.Text = "" Then
            '    MsgBox("Seleccione una Zona . . . ", MsgBoxStyle.Exclamation, "Aviso")
            '    CmbZona.Focus()
            'End If
        End If
    End Sub

    Private Sub txtSueldo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldo.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSueldo.Text = "" Then
                Me.txtSueldo.Text = 0.ToString("C2")
            Else
                Me.txtSueldo.Text = CDec(Me.txtSueldo.Text.Replace("$", "").Replace(",", "")).ToString("C2")
            End If

            Me.txtPorcentaje.Focus()
        ElseIf (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtSueldo.Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSueldo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSueldo.LostFocus
        If Me.txtSueldo.Text = "" Then
            Me.txtSueldo.Text = 0.ToString("C2")
        Else
            Me.txtSueldo.Text = CDec(Me.txtSueldo.Text.Replace("$", "").Replace(",", "")).ToString("C2")
        End If
    End Sub

    Private Sub TxtRfc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRfc.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If ValidateRFC(TxtRfc.Text) Then
                Me.SelectNextControl(sender, True, True, False, True)
                TxtDomicilio.Focus()
                If TxtRfc.Text = "" Then
                    MsgBox("Agregue Información a RFC (EJEMAAMMDDXXX). . . ", MsgBoxStyle.Critical, "Error")
                    TxtRfc.Focus()
                End If
            Else
                MsgBox("RFC Inválido (EJEMAAMMDDXXX). . . ", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    'Funcion que me valida la forma de un RFC
    Function ValidateRFC(ByVal RFC As String) As Boolean
        Dim RFCRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^[a-zA-Z]{3,4}(\d{6})((\D|\d){3})?$")
        Dim RFCMatch As _
            System.Text.RegularExpressions.Match = RFCRegex.Match(RFC)
        Return RFCMatch.Success
    End Function

    Private Sub TxtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDomicilio.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtColonia.Focus()
            If TxtDomicilio.Text = "" Then
                MsgBox("Agregue Información a Domicilio. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtDomicilio.Focus()
            End If
        End If
    End Sub

    Private Sub TxtColonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtColonia.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCp.Focus()
            If TxtColonia.Text = "" Then
                MsgBox("Agregue Información a Colonia. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtColonia.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCp.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCodEdo.Focus()
            If TxtCp.Text = "" Then
                MsgBox("Agregue Información a Codigo Postal. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtCp.Focus()
            End If
        End If
        Dim NNumeros As Integer = 5
        'Valida que el caracter ingresado sea numerico
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
                'Valida que la cantidad de Numeros  sean = a los establecidos
            ElseIf Me.TxtCp.Text.Length = NNumeros Then
                e.Handled = True
            End If
        End If
    End Sub

    'Validacion para Estado
    Private Sub TxtCodEdo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodEdo.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If IsNumeric(TxtCodEdo.Text) Then
                Dim Estado As New ClasesNegocio.EstadoClass

                If Estado.Obtener(CInt(Me.TxtCodEdo.Text)) Then
                    CmbEstado.SelectedValue = CInt(TxtCodEdo.Text)
                    CmbEstado.Focus()
                Else
                    Me.CmbEstado.SelectedIndex = -1
                    Me.TxtCodEdo.Text = ""
                End If
            Else
                Me.TxtCodEdo.Text = ""
                Me.CmbEstado.SelectedIndex = -1
                CmbEstado.Focus()
            End If
            'Me.SelectNextControl(sender, True, True, False, True)
        End If
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstado.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtCodCdad.Focus()
            If CmbEstado.Text = "" Then
                MsgBox("Seleccione un Estado . . . ", MsgBoxStyle.Exclamation, "Aviso")
                CmbEstado.Focus()
            End If
        End If
    End Sub

    'Codigo para Obtener las Ciudades de un Estado
    Private Sub CmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEstado.SelectedIndexChanged
        If CmbEstado.SelectedIndex > -1 And Not Me.CmbEstado.ValueMember = "" Then
            'CiudadCol = DirectCast(CmbEstado.SelectedItem, ClasesNegocio.EstadoClass).ObtenerCiudad
            '            CiudadCol = DirectCast(CmbEstado.SelectedItem, ClasesNegocio.EstadoClass).ObtenerCiudad(CInt(CmbEstado.SelectedValue))
            CiudadCol = New ClasesNegocio.CiudadCollectionClass
            CiudadCol.Obtener(CInt(CmbEstado.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)
            CmbCiudad.DataSource = CiudadCol
            Me.CmbCiudad.SelectedIndex = -1
            Me.CmbPoblacion.DataSource = Nothing
            CmbCiudad.Text = "Seleccione una Ciudad..."
            Me.TxtCodEdo.Text = Me.CmbEstado.SelectedValue
            Me.txtCodPob.Text = ""
            Me.txtCodCdad.Text = ""
            Me.CmbPoblacion.Text = ""
        Else
            Me.CmbCiudad.DataSource = Nothing
            Me.CmbPoblacion.DataSource = Nothing
            Me.TxtCodEdo.Text = ""
            Me.txtCodCdad.Text = ""
            Me.txtCodPob.Text = ""
        End If
    End Sub

    'Validacion para Ciudad
    Private Sub txtCodCdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCdad.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtCodCdad.Text) Then
                Dim Ciudad As New ClasesNegocio.CiudadClass

                If Ciudad.Obtener(CInt(Me.txtCodCdad.Text)) Then
                    Me.CmbEstado.SelectedValue = Ciudad.CodigoEstado.Codigo
                    Me.CmbCiudad.SelectedValue = Ciudad.Codigo
                    Me.TxtCodEdo.Text = Ciudad.CodigoEstado.Codigo.ToString
                    Me.txtCodPob.Focus()
                Else
                    'comisionista_MensajeError(sender, "No se encontro una ciudad con ese Codigo")
                    Me.CmbEstado.SelectedIndex = -1
                    Me.txtCodCdad.Text = ""
                End If
            Else
                Me.txtCodCdad.Text = ""
                Me.CmbEstado.SelectedIndex = -1
                Me.CmbEstado.Focus()
            End If
        End If
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CmbCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCiudad.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtCodPob.Focus()
            If CmbCiudad.Text = "" Then
                MsgBox("Seleccione una Ciudad . . . ")
                CmbCiudad.Focus()
            End If
        End If
    End Sub

    'Codigo para Obtener las Poblaciones de una Ciudad
    Private Sub CmbCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCiudad.SelectedIndexChanged
        If Me.CmbCiudad.SelectedIndex > -1 And Not Me.CmbCiudad.ValueMember = "" Then
            'OJO
            'PoblacionCol = DirectCast(CmbCiudad.SelectedItem, ClasesNegocio.CiudadClass).Poblaciones
            PoblacionCol = New ClasesNegocio.PoblacionCollectionClass
            PoblacionCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, CInt(CmbEstado.SelectedValue), CInt(CmbCiudad.SelectedValue))
            CmbPoblacion.DataSource = PoblacionCol
            Me.CmbPoblacion.SelectedIndex = -1
            CmbPoblacion.Text = "Seleccione una Población..."
            Me.txtCodCdad.Text = Me.CmbCiudad.SelectedValue
            Me.txtCodPob.Text = ""
        Else
            Me.CmbPoblacion.DataSource = Nothing
            Me.txtCodPob.Text = ""
            Me.txtCodCdad.Text = ""
        End If
    End Sub

    'Validación para población
    Private Sub txtCodPob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPob.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtCodPob.Text) Then
                Dim Poblacion As New ClasesNegocio.PoblacionClass

                If Poblacion.Obtener(CInt(Me.TxtCodEdo.Text), CInt(Me.txtCodCdad.Text), CInt(Me.txtCodPob.Text)) Then
                    Me.CmbEstado.SelectedValue = Poblacion.CodigoEstado.Codigo
                    Me.CmbCiudad.SelectedValue = Poblacion.CodigoCiudad.Codigo
                    Me.CmbPoblacion.SelectedValue = Poblacion.Codigo
                    Me.TxtCodEdo.Text = Poblacion.CodigoEstado.Codigo.ToString
                    Me.txtCodCdad.Text = Poblacion.CodigoCiudad.Codigo.ToString
                    Me.txtCodPob.Text = Poblacion.Codigo.ToString
                    Me.TxtCorreo.Focus()
                Else
                    'comisionista_MensajeError(sender, "No se encontro una poblacion con ese Codigo")
                    Me.txtCodPob.Text = ""
                    Me.txtCodCdad.Text = ""
                    Me.TxtCodEdo.Text = ""
                    Me.CmbEstado.SelectedIndex = -1
                End If
            Else
                Me.txtCodPob.Text = ""
                Me.txtCodCdad.Text = ""
                Me.TxtCodEdo.Text = ""
                Me.CmbEstado.SelectedIndex = -1
                Me.CmbEstado.Focus()
            End If
        End If
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CmbPoblacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPoblacion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCorreo.Focus()
            If CmbPoblacion.Text = "" Then
                MsgBox("Seleccione una Población . . . ", MsgBoxStyle.Exclamation, "Aviso")
                CmbPoblacion.Focus()
            End If
        End If
    End Sub

    Private Sub CmbPoblacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPoblacion.SelectedIndexChanged
        If Me.CmbPoblacion.SelectedIndex > -1 And Not Me.CmbPoblacion.ValueMember = "" Then
            Me.txtCodPob.Text = Me.CmbPoblacion.SelectedValue
        Else
            Me.txtCodPob.Text = ""
        End If
    End Sub

    Private Sub TxtCorreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCorreo.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If ValidateCorreo(TxtCorreo.Text) Then
                Me.SelectNextControl(sender, True, True, False, True)
                TxtLada.Focus()
                If TxtCorreo.Text = "" Then
                    MsgBox("Agregue Información a Email (nombre@ejemplo.com). . . ", MsgBoxStyle.Exclamation, "Aviso")
                    TxtCorreo.Focus()
                End If
            Else
                MsgBox("Email Invalida (nombre@ejemplo.com). . . ")
            End If
        End If
    End Sub

    'Funcion que me Valida la Forma de un Correo
    Function ValidateCorreo(ByVal Correo As String) As Boolean
        Dim CorreoRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim correoMatch As _
            System.Text.RegularExpressions.Match = CorreoRegex.Match(Correo)
        Return correoMatch.Success
    End Function

    Private Sub TxtLada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLada.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtTelefono.Focus()
            If TxtLada.Text = "" Then
                MsgBox("Agregue Información a Lada Telefónica. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtLada.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLada1.Focus()
            If TxtTelefono.Text = "" Then
                MsgBox("Agregue Información a Número de Teléfono. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtTelefono.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtLada1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLada1.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtTelefono1.Focus()
            If TxtLada1.Text = "" Then
                MsgBox("Agregue Información a Lada Telefónica. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtLada1.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtTelefono1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono1.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLada2.Focus()
            If TxtTelefono1.Text = "" Then
                MsgBox("Agregue Información a Número de Teléfono. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtTelefono1.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtLada2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLada2.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtFax.Focus()
            If TxtLada2.Text = "" Then
                MsgBox("Agregue Información a Lada Telefonica. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtLada2.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFax.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            btnCtaCont.Focus()
            If TxtFax.Text = "" Then
                MsgBox("Agregue Información a Número de Fax. . . ", MsgBoxStyle.Exclamation, "Aviso")
                TxtFax.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

#End Region

    Private Sub Comisionista_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Comisionista.Modificado
        If puedorefrescar Then
            TxtCodigo.Text = Comisionista.Codigo
            DtpFechaAlta.Text = Comisionista.FechaAlta
            TxtNombre.Text = Comisionista.Nombre
            TxtAPaterno.Text = Comisionista.Apaterno
            TxtAmaterno.Text = Comisionista.Amaterno
            txtPlaza.Text = Comisionista.Plaza.Codigo
            'TxtCodTvendedor.Text = Comisionista.TipoComicionista.codigo
            TxtDomicilio.Text = Comisionista.Domicilio
            TxtColonia.Text = Comisionista.Colonia
            TxtCp.Text = Comisionista.CodigoPostal
            txtCodPob.Text = Comisionista.Poblacion.Codigo
            TxtCorreo.Text = Comisionista.Email
            'txtCodZona.Text = Comisionista.Zona.Codigo
            TxtLada.Text = Comisionista.Lada
            TxtTelefono.Text = Comisionista.Telefono
            TxtLada1.Text = Comisionista.Lada1
            TxtTelefono1.Text = Comisionista.Telefono1
            TxtLada2.Text = Comisionista.Lada2
            TxtFax.Text = Comisionista.Fax
            TxtRfc.Text = Comisionista.Rfc
            lblEstatus.Text = Comisionista.Estatus.ToString
            CmbEstado.SelectedValue = Comisionista.IdEstado
            CmbCiudad.SelectedValue = Comisionista.IdCiudad
            CmbPoblacion.SelectedValue = Comisionista.IdPoblacion
            'CmbZona.SelectedValue = Comisionista.Zona.Codigo
            CmbPlaza.SelectedValue = Comisionista.Plaza.Codigo
            'CmbTVendedor.SelectedValue = Comisionista.TipoComicionista.codigo
            txtCtaCont.Text = String.Format("{0} : {1}", Comisionista.CuentaContable.NombreCuenta, Comisionista.CuentaContable.CuentaContable)
            Me.txtSueldo.Text = Me.Comisionista.Sueldo.ToString("C2")
            Me.txtPorcentaje.Text = (Me.Comisionista.Porcentaje / 100).ToString("P2")
        End If
    End Sub

    Private Sub Comisionista_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Comisionista.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub CmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbPlaza.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPlaza.SelectedIndexChanged
        If Me.CmbPlaza.SelectedIndex > -1 Then
            Me.txtPlaza.Text = Me.CmbPlaza.SelectedValue
        Else
            Me.txtPlaza.Text = ""
        End If
    End Sub

    Private Sub btnCtaCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtaCont.Click
        Dim buscarCuenta As New BusquedaCuentasContablesForm

        buscarCuenta.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
        buscarCuenta.BancosDefault(True) = ClasesNegocio.CondicionAsignadaEnum.NO

        If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Comisionista.CuentaContable = buscarCuenta.CuentaContable
            txtCtaCont.Text = String.Format("{0} : {1}", Comisionista.CuentaContable.NombreCuenta, Comisionista.CuentaContable.CuentaContable)
        End If
    End Sub

    Private Sub txtPorcentaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtPorcentaje.Text = "" Then
                Me.txtPorcentaje.Text = 0.ToString("P2")
            Else
                Me.txtPorcentaje.Text = CDec(CDec(Me.txtPorcentaje.Text.Replace("%", "")) / 100).ToString("P2")
            End If

            Me.TxtRfc.Focus()
        ElseIf (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.txtPorcentaje.Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPorcentaje_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentaje.LostFocus
        If Me.txtPorcentaje.Text = "" Then
            Me.txtPorcentaje.Text = 0.ToString("P2")
        Else
            Me.txtPorcentaje.Text = CDec(CDec(Me.txtPorcentaje.Text.Replace("%", "")) / 100).ToString("P2")
        End If
    End Sub

    'Private Sub CmbTVendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTVendedor.SelectedIndexChanged
    '    If Me.CmbTVendedor.SelectedIndex > -1 Then
    '        Me.TxtCodTvendedor.Text = Me.CmbTVendedor.SelectedValue

    '        If DirectCast(Me.CmbTVendedor.SelectedItem, ClasesNegocio.TipoVendedorClass).TipoPago = ClasesNegocios.EnumTipoComisionistaSueldoComision.COMISION Then
    '            Me.txtPorcentaje.Enabled = True
    '            Me.txtSueldo.Enabled = False
    '        Else
    '            Me.txtPorcentaje.Enabled = False
    '            Me.txtSueldo.Enabled = True
    '        End If
    '    Else
    '        Me.TxtCodTvendedor.Text = ""
    '    End If
    'End Sub

    'Private Sub CmbZona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.CmbZona.SelectedIndex > -1 Then
    '        Me.txtCodZona.Text = Me.CmbZona.SelectedValue
    '    Else
    '        Me.txtCodZona.Text = ""
    '    End If
    'End Sub

End Class