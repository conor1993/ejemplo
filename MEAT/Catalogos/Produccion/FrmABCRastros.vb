Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmABCRastros
    Dim WithEvents Rastro As ClasesNegocio.RastroClass
    Dim puedorefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False

    'Private Sub MEAToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles MEAToolBar1.ButtonClick
    '    Select Case e.Button.Text
    '        Case "Guardar"
    '            If Not Guardar() Then
    '                MessageBox.Show("No se pudo guardar rastro", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Else
    '                MessageBox.Show("Se guardo rastro con el codigo : " & Me.txtCodigo.Text, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '            Me.Limpiar()
    '        Case "Buscar"
    '            If Not Buscar() Then
    '                MessageBox.Show("No se encuentran embarques disponibles", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        Case "Imprimir"
    '            If Not Imprimir() Then
    '                MessageBox.Show("No se encuentra embarque disponible para impresion", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '    End Select
    'End Sub
    'Private Function Guardar() As Boolean
    '    Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
    '    Try
    '        Dim Rastro As New RastroClass
    '        Rastro.Descripcion = Me.txtDescripcion.Text
    '        Rastro.DescCorta = Me.txtDescCorta.Text
    '        Rastro.Estatus = "V"
    '        Rastro.Func = "I"
    '        Rastro.NumOpc = 1
    '        If Not Rastro.Guardar(Trans) Then
    '            Trans.Rollback()
    '            Return False
    '        End If
    '        Me.txtCodigo.Text = Rastro.IdRastro
    '        Trans.Commit()   
    '        Return True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Trans.Rollback()
    '        Return False
    '    End Try
    'End Function
    'Private Function Limpiar() As Boolean
    '    Me.txtCodigo.Text = 0
    '    Me.txtDescripcion.Text = ""
    '    Me.txtDescCorta.Text = ""
    'End Function
    'Private Function Buscar() As Boolean
    'End Function
    'Private Function Imprimir() As Boolean
    'End Function

#Region "Keypress"
    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescCorta.Focus()
            If txtDescripcion.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción . . . ", MsgBoxStyle.Exclamation, "Aviso")
                txtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescCorta.KeyPress
        If e.KeyChar = Chr(32) Then
            e.Handled = True
        End If
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescripcion.Focus()
            If txtDescCorta.Text = "" Then
                MsgBox("Agregue Informacion a la Descripción Corta . . . ", MsgBoxStyle.Exclamation, "Aviso")
                txtDescCorta.Focus()
            End If
        End If
    End Sub
#End Region
    Private Sub FrmABCRastros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "000100011"
        MtbEstados.StateBorrar = "000100011"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        DesHabilitar()
        Limpiar()
        dgvRastros.DataSource = RastroCollectionClass.CargarRastros()
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtCodigo.Text = 0
        Me.txtDescripcion.Text = ""
        Me.txtDescCorta.Text = ""
        Me.lblEstatus.Text = "ESTATUS"
        selesccionado = False
    End Sub

    Private Sub Habilitar()
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True
        txtDescCorta.Enabled = True
        dgvRastros.Enabled = False
    End Sub

    Private Sub DesHabilitar()
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        txtDescCorta.Enabled = False
        dgvRastros.Enabled = True
    End Sub

    Private Sub Guardar()
        Rastro.Descripcion = Me.txtDescripcion.Text
        Rastro.DescCorta = Me.txtDescCorta.Text
        Rastro.Estatus = EstatusEnum.ACTIVO
    End Sub

#End Region

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        If Rastro.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            If MessageBox.Show("Seguro que desea eliminarlo", "ERP MEAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Rastro.Borrar Then
                    MsgBox("El Rastro ha sido inactivado.", MsgBoxStyle.Information, "Aviso")
                    dgvRastros.DataSource = Nothing
                    dgvRastros.DataSource = RastroCollectionClass.CargarRastros()
                    DesHabilitar()
                    Limpiar()
                Else
                    Cancelar = True
                End If
            Else
                Cancelar = True
            End If
        Else
            MsgBox("El Rastro ya esta inactivo.", MsgBoxStyle.Exclamation, "Aviso")
            Limpiar()
            DesHabilitar()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Rastro.Estatus = ClasesNegocio.EstatusEnum.Activo Then
            Habilitar()
            Editar = True
            Me.txtDescripcion.Focus()
        Else
            If MessageBox.Show("El Rastro esta inactivo, ¿Desea activarlo?", "Activar Rastro ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Rastro.Estatus = ClasesNegocio.EstatusEnum.Activo
                Me.lblEstatus.Text = Rastro.Estatus.ToString
                Habilitar()
                Editar = True
                Me.txtDescripcion.Focus()
            Else
                Cancelar = True
                MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                DesHabilitar()
            End If
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try
            puedorefrescar = False
            Guardar()
            puedorefrescar = True
            If txtDescripcion.Text = "" Or txtDescCorta.Text = "" Then
                MsgBox("La Descripción y Descripción Corta es Obligatoria Agregue Información ", MsgBoxStyle.Exclamation, "Faltan Datos")
                Me.txtDescripcion.Focus()
                Cancelar = True
            Else
                If Rastro.Guardar() Then
                    If Editar Then
                        MsgBox("El Rastro se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                    Else
                        MessageBox.Show("El Rastro se ha modificado satisfactoriamente.", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    dgvRastros.DataSource = Nothing
                    dgvRastros.DataSource = RastroCollectionClass.CargarRastros()
                    Limpiar()
                    DesHabilitar()
                Else
                    Cancelar = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.selesccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Limpiar()
        Habilitar()
        Rastro = New RastroClass
        txtDescripcion.Focus()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub Actualizar()
        txtCodigo.Text = Rastro.IdRastro
        txtDescripcion.Text = Rastro.Descripcion
        txtDescCorta.Text = Rastro.DescCorta
        lblEstatus.Text = Rastro.Estatus.ToString
    End Sub

    Private Sub dgvRastros_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRastros.CellDoubleClick
        If Me.dgvRastros.SelectedRows.Count > 0 Then
            Rastro = New RastroClass(Integer.Parse(dgvRastros.SelectedRows(0).Cells(0).Value))
            Actualizar()
            MEAToolBar1.sbCambiarEstadoBotones("Buscar")
            Me.selesccionado = True
            Me.lblEstatus.Visible = True
        End If
    End Sub

    Private Sub dgvRastros_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRastros.CellFormatting
        If e.ColumnIndex = clmEstatus.Index Then
            e.Value = IIf(CType(e.Value, EstatusEnum) = EstatusEnum.ACTIVO, "ACTIVO", "INACTIVO")
        End If
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        RastroCollectionClass.Imprimir(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
    End Sub
End Class