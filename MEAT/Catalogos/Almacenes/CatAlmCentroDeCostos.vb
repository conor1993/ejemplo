Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CatAlmCentroDeCostos
    Dim Centro As CN.CentrosDeCostosClass
    'Dim Cuenta As CN.CuentaContableClass
    Private Sub CatCentroDeCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "010101111"
            MtbEstados.StateLimpiar = "100100011"
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "0010100011"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            mtb.Buttons(1).Visible = False

            Dim PlazaC As New CN.PlazaCollectionClass
            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbPlaza.DisplayMember = "Descripcion"
            Me.CmbPlaza.ValueMember = "COdigo"
            Me.CmbPlaza.DataSource = PlazaC

            Me.CentroDeCostosC.Obtener()

            Limpiar()
            DesHabilitar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.txtCta.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtFiltro.Text = ""
        Me.CmbPlaza.SelectedIndex = -1
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.btnCta.Enabled = True
        Me.CmbPlaza.Enabled = True
        Me.DgvCentros.Enabled = False
        Me.txtFiltro.Enabled = False
    End Sub

    Private Sub DesHabilitar()
        Me.txtDescripcion.Enabled = False
        Me.btnCta.Enabled = False
        Me.CmbPlaza.Enabled = False
        Me.DgvCentros.Enabled = True
        Me.txtFiltro.Enabled = True
    End Sub

    Private Function Guardar() As Boolean
        Try
            Centro.IdPlaza = Me.CmbPlaza.SelectedValue
            Centro.Descripcion = Me.txtDescripcion.Text
            Centro.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub PonerDatos()
        Me.txtCodigo.Text = Centro.Codigo
        Me.CmbPlaza.SelectedValue = Centro.IdPlaza
        Me.txtDescripcion.Text = Centro.Descripcion
        Me.txtCta.Text = Centro.NomCuenta
        Me.lblEstatus.Text = Centro.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.CmbPlaza.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione una plaza", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbPlaza.Focus()
                Return False
            End If

            If Me.txtDescripcion.Text = "" Then
                MessageBox.Show("Ingrese la Descrición", "Abviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                Return False
            End If

            If Centro.Cuenta Is Nothing Then
                MsgBox("No ha seleccionado una cuenta contable", MsgBoxStyle.Exclamation, "Aviso")
                Me.btnCta.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Centro.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
                MsgBox("No se puede cancelar el Centro de Costos debido a que ya se encuentra cancelado", MsgBoxStyle.Information)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("Esta seguro de cancelar el centro de costos", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Centro.Estatus = ClasesNegocio.EstatusDatos.CANCELADO
                If Centro.Borrar Then
                    MsgBox("Se ha cancelado el centro de costos", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    DesHabilitar()
                    Me.CentroDeCostosC.Obtener()
                    'Me.DgvCentros.AutoGenerateColumns = False
                    'Me.DgvCentros.DataSource = Me.CentroDeCostosC
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        DesHabilitar()
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Centro.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
            If MessageBox.Show("No se puede modificar un centro de costos cancelado , ¿Desea Activarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Centro.Estatus = ClasesNegocio.EstatusDatos.VIGENTE
                Habilitar()
                Exit Sub
            Else
                Cancelar = True
            End If
        End If
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If Not Guardar() Then
                Cancelar = True
                Exit Sub
            End If

            If Centro.Guardar() Then
                MsgBox("El Centro de Costos ha sido guardado con el código: " & Centro.Codigo, MsgBoxStyle.Information, "Aviso")
                Limpiar()
                DesHabilitar()
            End If

            Me.CentroDeCostosC.Obtener()
            'Me.DgvCentros.AutoGenerateColumns = False
            'Me.DgvCentros.DataSource = CentroDeCostosC
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Me.CmbPlaza.Focus()
        Me.Centro = New CN.CentrosDeCostosClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub btnCta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCta.Click
        Try
            Dim Ventana As New BusquedaCuentasContablesForm
            Ventana.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
            Ventana.InactivaDefault(True) = ClasesNegocio.CondicionAsignadaEnum.NO
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Centro.Cuenta = Ventana.CuentaContable
                Me.txtCta.Text = Centro.Cuenta.NombreLargo
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvCentros_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvCentros.Click
        Try
            If Me.DgvCentros.SelectedRows.Count > 0 Then
                Centro = DirectCast(Me.DgvCentros.SelectedRows(0).DataBoundItem, CN.CentrosDeCostosClass)
                PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvCentros_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCentros.RowEnter
        Try
            If Me.DgvCentros.SelectedRows.Count > 0 Then
                Centro = DirectCast(Me.DgvCentros.SelectedRows(0).DataBoundItem, CN.CentrosDeCostosClass)
                PonerDatos()
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        Try
            If e.KeyChar = Chr(13) Or Me.txtFiltro.Text.Length > 4 Then
                ' Me.CentroDeCostosC = New CN.CentroDeCostosCollectionClass
                Me.CentroDeCostosC.Obtener(Me.txtFiltro.Text)
                'Me.DgvCentros.AutoGenerateColumns = False
                'Me.DgvCentros.DataSource = Me.CentroDeCostosC
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class