Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CN = ClasesNegocio

Public Class FrmRelacionClienteCorte

#Region "Miembros"
    Dim RelCliCor As CN.RelacionClienteCorteClass
    Private RelacionCol As CN.RelacionClienteCorteCollection
    Dim CortesCol As CC.MsccatProductosCollection
    Dim Inicio As Boolean
    Dim PuntosCol As CC.MgralcatPuntosEntregaCollection
    Dim llenarGrid As Boolean = False
#End Region

#Region "Metedos"
    Private Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.cmbClientes.SelectedIndex = -1
        Me.cmbClientes.Text = "Seleccione un Cliente.."

        Me.RelacionClienteCorteC.Clear()
    End Sub

    Private Sub Habilitar(ByVal Estado As Boolean)
        'Me.txtCodigo.Enabled = Estado
        'Me.cmbClientes.Enabled = Estado
        Me.DgvCanales.Enabled = Estado
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub FrmRelacionClienteCanal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon

            Inicio = True

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            mtb.Buttons(1).Visible = False

            PuntosCol = New CC.MgralcatPuntosEntregaCollection

            Dim ClientesCol As New CN.ClientesIntroductoresColeccion
            ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)

            Me.cmbClientes.DisplayMember = "Nombre"
            Me.cmbClientes.ValueMember = "Codigo"
            Me.cmbClientes.DataSource = ClientesCol

            'CortesCol = New CC.MsccatProductosCollection
            'CortesCol.GetMulti(HC.MsccatProductosFields.Estatus = 1)

            'Me.DgvCanales.AutoGenerateColumns = False
            'Me.DgvCanales.DataSource = CortesCol



            Habilitar(False)
            Limpiar()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#End Region

#Region "ToolBar"
    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Habilitar(False)
        Limpiar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Me.txtCodigo.Focus()
            'msgbox("Si hay relacion
            If Me.RelacionClienteCorteC.Guardar(Nothing) Then
                MessageBox.Show("Se ha Guardado la Relación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Habilitar(False)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        'Me.RelacionCol
        Try
            Dim Ver As New CN.PreVisualizarForm
            Ver.Reporte = ClasesNegocio.RelacionClienteCorteCollection.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            Ver.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Habilitar(True)
        Limpiar()
        Inicio = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

#Region "ComboBox"
    Private Sub ComboBoxMejorado1_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestino.ActualizarCombo
        Try
            PuntosCol.GetMulti(HC.MgralcatPuntosEntregaFields.Estatus = CN.EstatusChar.VIGENTE)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestino.SelectedIndexChanged
        If Me.llenarGrid Then
            Try
                If Me.cmbDestino.SelectedIndex > -1 Then
                    Me.RelacionClienteCorteC.Obtener(Me.cmbClientes.SelectedValue, Me.cmbDestino.SelectedValue)
                Else
                    Me.RelacionClienteCorteC.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClientes.SelectedIndexChanged
        If Me.cmbClientes.SelectedIndex > -1 Then
            Try
                Me.cmbDestino.DataSource = Nothing

                PuntosCol.GetMulti(HC.MgralcatPuntosEntregaFields.Estatus = "V" And _
                        HC.MgralcatPuntosEntregaFields.IdCliente = Me.cmbClientes.SelectedValue)
                Me.llenarGrid = False
                Me.cmbDestino.ValueMember = "IdPuntoEntrega"
                Me.cmbDestino.DisplayMember = "Descripcion"
                Me.cmbDestino.DataSource = Me.PuntosCol
                Me.cmbDestino.SelectedIndex = -1
                Me.cmbDestino.Text = "Seleccionar Destiono..."
                Me.llenarGrid = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Me.llenarGrid = False
            Me.cmbDestino.DataSource = Nothing
        End If
    End Sub
#End Region

#Region "DataGrid"
    Private Sub DgvCanales_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCanales.CellEndEdit
        Try
            'Select Case e.ColumnIndex
            '    Case Me.clmDescripcionCorteCte.Index
            '        If Not IsNumeric(Me.DgvCanales.CurrentRow.Cells(Me.clmDescripcionCorteCte.Index).Value) Then
            '            If Not CStr(Me.DgvCanales.CurrentRow.Cells(Me.clmDescripcionCorteCte.Index).Value) = "" Then
            '                Me.DgvCanales.CurrentRow.Cells(Me.clmDescripcionCorteCte.Index).Value = CStr(DgvCanales.CurrentRow.Cells(Me.clmDescripcionCorteCte.Index).Value).ToUpper
            '            End If
            '        End If
            'End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvCanales_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvCanales.DataError

    End Sub
#End Region

#Region "TextBox"
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
                e.Handled = True
            End If
            If e.KeyChar = Chr(Keys.Enter) Then
                If Not Me.txtCodigo.Text = "" Then
                    Me.cmbClientes.SelectedValue = CInt(Me.txtCodigo.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

End Class