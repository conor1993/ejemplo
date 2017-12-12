Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.HelperClasses
Imports ClasesNegocio
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures

Public Class ComSolicitudServicios
    Private SolicitudCab As SolicitudServiciosClass
    Private SolicitudDet As SolicitudServiciosDetClass
    Private UltimaTeclaPlaza As DateTime
    Private UltimaTeclaSucursal As DateTime

    Private Sub ComSolicitudServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.PlazaC.Obtener(CondicionEnum.ACTIVOS)
            Me.CmbPlaza.DataSource = PlazaC
            Me.CmbPlaza.DisplayMember = "Descripcion"

            Me.SucursalC.Obtener(CondicionEnum.ACTIVOS)
            Me.CmbSucursal.DataSource = SucursalC
            Me.CmbSucursal.DisplayMember = "Descripcion"
            Limpiar()
            Habilitar(False)
            'Me.LlenaCombox()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Metodos"
    Sub Limpiar()
        Me.CmbPlaza.SelectedValue = -1
        Me.CmbSucursal.SelectedValue = -1
        Me.lblEstatus.Visible = False
        Me.txtFolio.Text = 0
        Me.txtSolicita.Text = ""
        txtPara.Text = ""
        txtEntregarA.Text = ""
        txtEntregarEn.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtSuma.Text = 0
        Me.DgvDetalleSolic.Rows.Clear()
        Me.DgvDetalleSolic.DataSource = Nothing
        Me.clmEstatus.Visible = False
        Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.clmObservaciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
    End Sub

    Sub Habilitar(ByVal Estado As Boolean)
        Me.CmbSucursal.Enabled = Estado
        Me.CmbPlaza.Enabled = Estado
        Me.DgvDetalleSolic.Enabled = Estado
        Me.txtObservaciones.Enabled = Estado
        txtPara.Enabled = Estado
        txtEntregarA.Enabled = Estado
        txtEntregarEn.Enabled = Estado
    End Sub

    Sub GuardarCabecero()
        Try
            Me.SolicitudCab.Folio = Me.txtFolio.Text
            Me.SolicitudCab.SucursalId = Me.CmbSucursal.SelectedValue
            Me.SolicitudCab.Observaciones = Me.txtObservaciones.Text
            Me.SolicitudCab.SolicitadoPor = txtPara.Text.Trim
            Me.SolicitudCab.EntregarA = txtEntregarA.Text.Trim
            Me.SolicitudCab.EntregarEn = txtEntregarEn.Text.Trim
            Me.SolicitudCab.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            Me.SolicitudCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GuardarDetalle(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If Me.DgvDetalleSolic.Rows.Count > 0 Then
                For i As Integer = 0 To Me.DgvDetalleSolic.Rows.Count - 2
                    Me.SolicitudDet = New SolicitudServiciosDetClass
                    Me.SolicitudDet.Folio = Me.txtFolio.Text
                    Me.SolicitudDet.Indice = i + 1
                    If Not Me.DgvDetalleSolic.Rows(i).Cells("clmServicio").Value = Nothing Then
                        Me.SolicitudDet.Servicio = (Me.DgvDetalleSolic.Rows(i).Cells("clmServicio").Value).ToString.ToUpper
                    Else
                        MessageBox.Show("Especifique la Descripcion del Servicio", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return False
                    End If
                    Me.SolicitudDet.Cantidad = Me.DgvDetalleSolic.Rows(i).Cells("clmCantidad").Value
                    Me.SolicitudDet.Urgente = Me.DgvDetalleSolic.Rows(i).Cells("clmUrgente").Value
                    If Not Me.DgvDetalleSolic.Rows(i).Cells("clmObservaciones").Value = Nothing Then
                        Me.SolicitudDet.Observaciones = (Me.DgvDetalleSolic.Rows(i).Cells("clmObservaciones").Value).ToString.ToUpper
                    End If
                    Me.SolicitudDet.Estatus = EstatusDatos.VIGENTE
                    Me.SolicitudDet.FechaServicio = Now
                    If Not Me.SolicitudDet.Guardar(Trans) Then
                        Return False
                    End If
                Next
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Validar() As Boolean
        Try
            If Me.CmbPlaza.SelectedValue Is Nothing OrElse Me.CmbPlaza.SelectedValue = -1 Then
                MessageBox.Show("Especifique la Plaza", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CmbPlaza.Focus()
                Return False
            ElseIf Me.CmbSucursal.SelectedValue Is Nothing OrElse Me.CmbSucursal.SelectedValue = -1 Then
                MessageBox.Show("Especifique la Sucursal", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CmbSucursal.Focus()
                Return False
            End If

            If DgvDetalleSolic.RowCount > 0 AndAlso Not (DgvDetalleSolic.RowCount = 1 AndAlso DgvDetalleSolic.Rows(0).IsNewRow) Then
                For i As Integer = 0 To Me.DgvDetalleSolic.Rows.Count - 2
                    If Me.DgvDetalleSolic.Rows(i).Cells(Me.clmCantidad.Index).Value = 0 Or Me.DgvDetalleSolic.Rows(i).Cells(Me.clmCantidad.Index).Value = Nothing Then
                        MessageBox.Show("Especifique la cantidad a solicitar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.DgvDetalleSolic.Focus()
                        Return False
                    End If
                Next
            Else
                MessageBox.Show("Especifique los servicios a solicitar", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Sub PonerDatos()
        Me.CmbPlaza.SelectedValue = Me.SolicitudCab.Sucursal.Plaza.Codigo
        Me.CmbSucursal.SelectedValue = Me.SolicitudCab.SucursalId
        Me.txtFolio.Text = Me.SolicitudCab.Folio
        Me.txtSolicita.Text = Me.SolicitudCab.UsuarioAlta.NombreCompleto
        Me.DtpFecha.Text = Me.SolicitudCab.FechaAlta
        Me.lblEstatus.Text = Me.SolicitudCab.Estatus.ToString
        Me.lblEstatus.Visible = True
        Me.txtObservaciones.Text = Me.SolicitudCab.Observaciones
        Me.txtPara.Text = Me.SolicitudCab.SolicitadoPor
        Me.txtEntregarA.Text = Me.SolicitudCab.EntregarA
        Me.txtEntregarEn.Text = Me.SolicitudCab.EntregarEn
    End Sub

    Sub CalcularSuma()
        Dim Total As Decimal = 0D

        Try
            Me.txtSuma.Text = 0
            For i As Integer = 0 To Me.DgvDetalleSolic.Rows.Count - 2
                If Not Me.DgvDetalleSolic.Rows(i).Cells("clmCantidad").Value = Nothing Then
                    Total += CType(Me.DgvDetalleSolic.Rows(i).Cells("clmcantidad").Value, Decimal)
                End If
            Next
            Me.txtSuma.Text = Total.ToString("N2")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Botones TollBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "GuardarSolSer")

        Try
            If Me.SolicitudCab.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MessageBox.Show("No se Puede Cancelar esta Solicitud de Servicios", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                'Me.SolicitudCab = New SolicitudServiciosClass
                If MessageBox.Show("¿Estas seguro de cancelar la Solicitud de Servicios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If Me.SolicitudCab.Borrar(Trans) Then
                        Trans.Commit()
                        Me.Limpiar()
                        MessageBox.Show("Se ha cancelado la Solicitud de Servicios", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Cancelar = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Cancelar = True

            Dim Ventana As New ComBusquedaSolicitudServicios

            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Folio As String = Ventana.DataGridView1.SelectedRows(0).Cells("ClmFolio").Value
                Me.SolicitudCab = New SolicitudServiciosClass
                Me.SolicitudCab.Obtener(Folio)
                PonerDatos()
                Me.DgvDetalleSolic.AutoGenerateColumns = False
                Me.clmEstatus.Visible = True
                Me.DgvDetalleSolic.DataSource = Me.SolicitudCab.Detalle
                Me.clmServicio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.clmObservaciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Me.CalcularSuma()
                Cancelar = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Habilitar(False)
        Limpiar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
        Me.Validate()

        Cancelar = True

        Try
            If MessageBox.Show("Se registrara la solicitud, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            If Not Validar() Then
                Exit Sub
            End If
            ' Genero el Folio

            If SPA.UspMcompFolioSolicitudServIns(Me.txtFolio.Text, Trans) = 0 Then
                Trans.Rollback()
            End If

            'Dim Folio As New FoliosClass
            'Folio.Codigo = CodigodeFolios.SolicitudServicios
            'Folio.Año = Now.Year
            'Folio.Mes = Now.ToString("MM")
            'If Not Folio.Guardar(Trans) Then
            '    Trans.Rollback()
            '    Exit Sub
            'End If
            ''asignar folio 
            'Me.txtFolio.Text = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
            ' Guardar el cabecero
            Me.GuardarCabecero()
            If Not SolicitudCab.Guardar(Trans) Then
                Trans.Rollback()
                Exit Sub
            End If
            'guardar el detalle
            If Not Me.GuardarDetalle(Trans) Then
                Trans.Rollback()
                Exit Sub
            End If
            Trans.Commit()
            MessageBox.Show("Se guardo la Solicitud de Servicios con el Folio: " & Me.txtFolio.Text)
            Cancelar = False
            Limpiar()
            Habilitar(False)
            ' Me.SolicitudServDetC.Obtener()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Limpiar()
            Habilitar(True)
            Me.txtSolicita.Text = Controlador.Sesion.MiUsuario.Usrnomcom
            Me.CmbPlaza.Focus()
            Me.SolicitudCab = New SolicitudServiciosClass

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "DataGrid"
    Private Sub DgvDetalleSolic_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDetalleSolic.CellEndEdit
        Select Case e.ColumnIndex
            Case Me.clmFolio.Index
                Refresh()
            Case Me.clmCantidad.Index
                If Not IsNumeric(Me.DgvDetalleSolic.CurrentRow.Cells("clmCantidad").Value) Then
                    MsgBox("Ingrese solo números", MsgBoxStyle.Information)
                Else
                    CalcularSuma()
                End If
        End Select
    End Sub
#End Region

#Region "Key Press"
    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPlaza.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.CmbSucursal.Focus()
        Else
            Tmplaza.Stop()
            UltimaTeclaPlaza = Now
            Me.Tmplaza.Start()
        End If
    End Sub

    Private Sub CmbSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSucursal.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.DgvDetalleSolic.Focus()
        Else
            TmSucursal.Stop()
            UltimaTeclaSucursal = Now
            Me.TmSucursal.Start()
        End If
    End Sub
#End Region

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPlaza.SelectedIndexChanged
        Try
            If Me.CmbPlaza.SelectedIndex > -1 Then
                Me.SucursalC.Obtener(Me.CmbPlaza.SelectedValue, CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbPlaza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPlaza.TextChanged
        Try
            If Me.CmbPlaza.SelectedIndex > -1 Then
                Me.SucursalC.Obtener(Me.CmbPlaza.SelectedValue, CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Tmplaza_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmplaza.Tick
        If Me.UltimaTeclaPlaza.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.Tmplaza.Stop()
            Me.PlazaC.Obtener(Me.CmbPlaza.Text, ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
        If Me.CmbPlaza.Text = "" Then
            PlazaC.Obtener(CondicionEnum.ACTIVOS)
            Me.CmbPlaza.SelectedIndex = -1
        End If
    End Sub

    Private Sub TmSucursal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmSucursal.Tick
        If Me.UltimaTeclaSucursal.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
            Me.TmSucursal.Stop()
            Me.SucursalC.Obtener(Me.CmbSucursal.Text, ClasesNegocio.CondicionEnum.ACTIVOS, Me.CmbPlaza.SelectedValue)
            Me.CmbSucursal.DataSource = SucursalC
        End If
        If Me.CmbSucursal.Text = "" Then
            SucursalC.Obtener(CondicionEnum.ACTIVOS)
            Me.CmbSucursal.SelectedIndex = -1
        End If
    End Sub
End Class