Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CatComp07Choferes

    Private PuedoModificar As Boolean = False
    Private selecciono As Boolean = False
    Private editar As Boolean = False
    Private Chofer As CN.ChoferesClass
    Dim ChoferesCol As CN.ChoferesCollectionClass
    Dim Estados As CN.EstadoCollectionClass
    Dim Ciudades As CN.CiudadCollectionClass
    Dim Poblaciones As CN.PoblacionCollectionClass

    Private Sub frmChoferes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        mtbEstados.StateBuscar = "110101101"
        mtbEstados.StateLimpiar = "000100011"
        mtbEstados.StateCancelar = "000100011"
        mtbEstados.StateNuevo = "011010001"
        mtbEstados.StateGuardar = "110100011"
        mtbEstados.StateBorrar = "100100001"
        mtbEstados.StateEditar = "001010000"
        mtbEstados.StateImprimir = ""
        mtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = mtbEstados
        Me.MEAToolBar1.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.MEAToolBar1.Buttons(3).ToolTipText = "Cancela la acción actual."
        Me.MEAToolBar1.Buttons(5).ToolTipText = "Crea un nuevo Chofer."
        Me.MEAToolBar1.Buttons(6).ToolTipText = "Guarda el Chofer o los cambios que se le hayan Realizado."
        Me.MEAToolBar1.Buttons(7).ToolTipText = "Cambia el estatus de el Chofer a Inactivo."
        Me.MEAToolBar1.Buttons(8).ToolTipText = "Permite Modificar el Chofer."
        Me.MEAToolBar1.Buttons(10).ToolTipText = "Imprime los Choferes Registrados."
        Me.MEAToolBar1.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        sbLectura()

        Me.MEAToolBar1.Buttons(1).Visible = False

        Estados = New CN.EstadoCollectionClass
        Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        Me.cmbEstado.ValueMember = "Codigo"
        Me.cmbEstado.DisplayMember = "Descripcion"
        Me.cmbEstado.DataSource = Estados
        Me.cmbEstado.SelectedIndex = -1
        LlenarGrid()
    End Sub

#Region "Metodos"
    Private Sub sbLimpiar()
        Me.txtLicencia.Text = ""
        Me.TxtNombre.Text = ""
        Me.TxtAPaterno.Text = ""
        Me.TxtAmaterno.Text = ""
        Me.TxtCodigo.Text = ""
        Me.txtCalle.Text = ""
        Me.txtCelular.Text = ""
        Me.txtColonia.Text = ""
        Me.Txtfiltro.Text = ""
        Me.txtNombreCorto.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtTipoLicencia.Text = ""
        Me.txtTipoSangre.Text = ""
        Me.DtpFechaVencimiento.Value = Now
        selecciono = False
        Me.lblEstatus.Visible = False
        Me.cmbEstado.SelectedIndex = -1
        Me.cmbCiudad.SelectedIndex = -1
        Me.cmbPoblacion.SelectedIndex = -1
        MEAToolBar1.sbCambiarEstadoBotones("Limpiar")
    End Sub

    Private Sub sbLectura()
        Me.txtLicencia.Enabled = False
        Me.TxtNombre.Enabled = False
        Me.TxtAPaterno.Enabled = False
        Me.TxtAmaterno.Enabled = False
        Me.DtpFechaVencimiento.Enabled = False
        Me.txtNombreCorto.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.txtTipoLicencia.Enabled = False
        Me.txtTipoSangre.Enabled = False
        Me.txtColonia.Enabled = False
        Me.txtCalle.Enabled = False
        Me.txtCelular.Enabled = False
        Me.cmbEstado.Enabled = False
        Me.cmbCiudad.Enabled = False
        Me.cmbPoblacion.Enabled = False
        Me.DgvChoferes.Enabled = True
        Me.Txtfiltro.Enabled = True
    End Sub

    Private Sub sbEscritura()
        Me.txtLicencia.Enabled = True
        Me.TxtNombre.Enabled = True
        Me.TxtAPaterno.Enabled = True
        Me.TxtAmaterno.Enabled = True
        Me.DtpFechaVencimiento.Enabled = True
        Me.txtNombreCorto.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtTipoLicencia.Enabled = True
        Me.txtTipoSangre.Enabled = True
        Me.txtColonia.Enabled = True
        Me.txtCalle.Enabled = True
        Me.txtCelular.Enabled = True
        Me.cmbEstado.Enabled = True
        Me.cmbCiudad.Enabled = True
        Me.cmbPoblacion.Enabled = True
        Me.DgvChoferes.Enabled = False
        Me.Txtfiltro.Enabled = False
    End Sub

    Private Sub Guardar()
        Chofer.Nombre = Me.TxtNombre.Text
        Chofer.Apellido_Paterno = Me.TxtAPaterno.Text
        Chofer.Apellido_Materno = Me.TxtAmaterno.Text
        Chofer.NombreCorto = Me.txtNombreCorto.Text
        Chofer.Domicilio = Me.txtCalle.Text
        Chofer.Colonia = Me.txtColonia.Text
        Chofer.Entidad.IdEstado = Me.cmbEstado.SelectedValue
        Chofer.Entidad.IdCiudad = Me.cmbCiudad.SelectedValue
        Chofer.Entidad.IdPoblacion = Me.cmbPoblacion.SelectedValue
        Chofer.TipoLicencia = Me.txtTipoLicencia.Text
        Chofer.TipoSangre = Me.txtTipoSangre.Text
        Chofer.FechaVenciLicencia = Me.DtpFechaVencimiento.Value
        Chofer.NoLicencia = Me.txtLicencia.Text
        Chofer.Observaciones = Me.txtObservaciones.Text
        Chofer.Telefono = Me.txtTelefono.Text
        Chofer.TelefonoCel = Me.txtCelular.Text
    End Sub

    Private Sub ObtenerValores()
        Me.TxtNombre.Text = Chofer.Nombre
        Me.TxtAPaterno.Text = Chofer.Apellido_Paterno
        Me.TxtAmaterno.Text = Chofer.Apellido_Materno
        Me.TxtCodigo.Text = Chofer.IdChofer
        Me.txtNombreCorto.Text = Chofer.NombreCorto
        Me.txtCalle.Text = Chofer.Domicilio
        Me.txtColonia.Text = Chofer.Colonia
        Me.cmbEstado.SelectedValue = Chofer.Estado.Codigo
        Me.cmbCiudad.SelectedValue = Chofer.Ciudad.Codigo
        Me.cmbPoblacion.SelectedValue = Chofer.Poblacion.Codigo
        Me.txtTipoLicencia.Text = Chofer.TipoLicencia
        Me.txtTipoSangre.Text = Chofer.TipoSangre
        Me.DtpFechaVencimiento.Value = Chofer.FechaVenciLicencia
        Me.txtLicencia.Text = Chofer.NoLicencia
        Me.txtObservaciones.Text = Chofer.Observaciones
        Me.txtTelefono.Text = Chofer.Telefono
        Me.txtCelular.Text = Chofer.TelefonoCel
        Me.lblEstatus.Text = Chofer.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.TxtNombre.Text = "" Then
                MessageBox.Show("Ingrese el nombre del chofer", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.TxtNombre.Focus()
                Return False
            End If

            If Me.TxtAPaterno.Text = "" Then
                MessageBox.Show("Ingrese el Apellido Paterno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.TxtAPaterno.Focus()
                Return False
            End If

            If Me.TxtAmaterno.Text = "" Then
                MessageBox.Show("Ingrese el Apellido Materno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.TxtAmaterno.Focus()
                Return False
            End If

            If Me.txtCalle.Text = "" Then
                MessageBox.Show("Ingrese el Domicilio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCalle.Focus()
                Return False
            End If

            If Me.txtColonia.Text = "" Then
                MessageBox.Show("Ingrese el nombre de la colonia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtColonia.Focus()
                Return False
            End If

            If Me.cmbEstado.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione un Estado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbEstado.SelectedIndex = 0
                Me.cmbEstado.Focus()
                Return False
            End If

            If Me.cmbCiudad.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione una Ciudad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbCiudad.SelectedIndex = 0
                Me.cmbCiudad.Focus()
                Return False
            End If

            If Me.cmbPoblacion.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione una Poblacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbPoblacion.SelectedIndex = 0
                Me.cmbPoblacion.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub LlenarGrid()
        ChoferesCol = New CN.ChoferesCollectionClass
        ChoferesCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)

        Me.DgvChoferes.AutoGenerateColumns = False
        Me.DgvChoferes.DataSource = ChoferesCol
    End Sub
#End Region

#Region "Tool Bar"
    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Try

            If Me.Chofer.Estatus = ClasesNegocio.EstatusChar.CANCELADO Then
                MessageBox.Show("No se puede cancelar el estado porque ya se encuentra cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("Esta seguro de cancelar el chofer", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Chofer.Estatus = ClasesNegocio.EstatusChar.CANCELADO
            Chofer.FechaBaja = Now
            Chofer.UsuarioBajaId = Controlador.Sesion.MiUsuario.Usrndx

            If Chofer.Borrar Then
                MsgBox("El chofer ha sido dado de baja", MsgBoxStyle.Information, "Aviso")
                sbLimpiar()
                sbLectura()
                LlenarGrid()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        sbLectura()
        sbLimpiar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        If Chofer.Estatus = ClasesNegocio.EstatusChar.VIGENTE Then
            sbEscritura()
            editar = True
            Me.TxtNombre.Focus()
        Else
            If MessageBox.Show("El Chofer está inactivo, ¿Desea activarlo?", "Activar Chofer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Chofer.Estatus = ClasesNegocio.EstatusChar.VIGENTE
                Me.lblEstatus.Text = Chofer.Estatus.ToString
                sbEscritura()
                editar = True
                Me.TxtNombre.Focus()
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                sbLimpiar()
                sbLectura()
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            PuedoModificar = False
            Guardar()
            PuedoModificar = True

            If Chofer.Guardar Then
                MsgBox("El Chofer se ha guardado exitosamente", MsgBoxStyle.Information, "Aviso")
                sbLimpiar()
                sbLectura()
                LlenarGrid()
            Else
                Cancelar = True
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            ChoferesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)
            If ChoferesCol.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatChoferes = ChoferesCol.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(ChoferesCol)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(1, "Catalogos\Compras de Ganado\Choferes")
                Reporte.SetParameterValue(2, Controlador.Sesion.MiEmpresa.Empnom)
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Chofer", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        If selecciono Then
            sbLimpiar()
        Else
            sbLimpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        sbEscritura()
        sbLimpiar()
        Chofer = New CN.ChoferesClass
        Me.TxtNombre.Focus()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub

#End Region

#Region "Key Press"
    Private Sub TxtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.TxtNombre.Text = "" Then
                MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information, "Aviso")
            Else
                Me.TxtAPaterno.Focus()
            End If
        End If
    End Sub

    Private Sub TxtAPaterno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAPaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.TxtAPaterno.Text = "" Then
                MsgBox("Debe ingresar un apellido paterno", MsgBoxStyle.Information, "Aviso")
            Else
                Me.TxtAmaterno.Focus()
            End If
        End If
    End Sub
    Private Sub TxtAmaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.TxtAmaterno.Text = "" Then
                MsgBox("Debe ingresar un apellido materno", MsgBoxStyle.Information, "Aviso")
            Else
                Me.txtNombreCorto.Focus()
            End If
        End If
    End Sub
    Private Sub txtLicencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLicencia.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTipoLicencia.Focus()
        End If
    End Sub

    Private Sub Txtfiltro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtfiltro.KeyDown
        Try
            If Me.Txtfiltro.Text.Length > 4 Then
                ChoferesCol = New CN.ChoferesCollectionClass
                ChoferesCol.Obtener(Me.Txtfiltro.Text)
                Me.DgvChoferes.AutoGenerateColumns = False
                Me.DgvChoferes.DataSource = ChoferesCol
            End If
            If e.KeyCode = Keys.Enter Then
                ChoferesCol = New CN.ChoferesCollectionClass
                ChoferesCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
                Me.DgvChoferes.AutoGenerateColumns = False
                Me.DgvChoferes.DataSource = ChoferesCol
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Chofer_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Chofer.MensajeError
    '    MsgBox(mensaje, MsgBoxStyle.Information, "Aviso")

    '    Select Case sender.ToString
    '        Case "Nombre"
    '            Me.TxtNombre.Focus()
    '        Case "ApellidoPaterno"
    '            Me.TxtAPaterno.Focus()
    '        Case "ApellidoMaterno"
    '            Me.TxtAmaterno.Focus()
    '        Case "LicenciaManejo"
    '            Me.txtLicencia.Focus()
    '    End Select
    'End Sub

    'Private Sub Chofer_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chofer.Modificado
    '    If PuedoModificar Then
    '        Me.TxtNombre.Text = Chofer.Nombre
    '        Me.TxtAPaterno.Text = Chofer.ApellidoPaterno
    '        Me.TxtAmaterno.Text = Chofer.ApellidoMaterno
    '        Me.txtLicencia.Text = Chofer.LicenciaManejo
    '        Me.TxtCodigo.Text = Chofer.Codigo
    '        Me.lblEstatus.Text = Chofer.Estatus.ToString
    '    End If
    'End Sub

    Private Sub txtCalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalle.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtColonia.Focus()
        End If
    End Sub

    Private Sub txtColonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtColonia.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbEstado.Focus()
        End If
    End Sub

    Private Sub cmbEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbEstado.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.Estados = New CN.EstadoCollectionClass
            Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbEstado.ValueMember = "Codigo"
            Me.cmbEstado.DisplayMember = "Descripcion"
            Me.cmbEstado.DataSource = Estados
        End If
    End Sub

    Private Sub cmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEstado.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbCiudad.Focus()
        End If
    End Sub

    Private Sub cmbCiudad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCiudad.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.cmbEstado_SelectedIndexChanged(sender, New EventArgs)
        End If
    End Sub

    Private Sub cmbCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCiudad.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbPoblacion.Focus()
        End If
    End Sub

    Private Sub cmbPoblacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPoblacion.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.cmbCiudad_SelectedIndexChanged(sender, New EventArgs)
        End If
    End Sub

    Private Sub cmbPoblacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPoblacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCelular.Focus()
        End If
    End Sub

    Private Sub txtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTelefono.Focus()
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTipoSangre.Focus()
        End If
    End Sub

    Private Sub DtpFechaVencimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaVencimiento.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtTipoLicencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoLicencia.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.DtpFechaVencimiento.Focus()
        End If
    End Sub

    Private Sub txtTipoSangre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoSangre.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLicencia.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.MEAToolBar1.Focus()
        End If
    End Sub

#End Region

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
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

    Private Sub cmbCiudad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCiudad.SelectedIndexChanged
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

    Private Sub DgvChoferes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvChoferes.Click
        Try
            If Me.DgvChoferes.SelectedRows.Count > 0 Then
                Chofer = DirectCast(Me.DgvChoferes.SelectedRows(0).DataBoundItem, CN.ChoferesClass)
                ObtenerValores()
                Me.sbLectura()
                Me.MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNombreCorto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCorto.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCalle.Focus()
        End If
    End Sub

    Private Sub DgvChoferes_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvChoferes.DataError

    End Sub

    Private Sub txtCelular_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular.TextChanged

    End Sub
End Class