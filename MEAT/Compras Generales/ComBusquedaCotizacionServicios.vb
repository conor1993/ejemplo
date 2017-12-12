Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class ComBusquedaCotizacionServicios

    Private Sub ComBusquedaCotizacionServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PlazaC.Obtener()
            Me.ProveedorC.Obtener()
            Limpiar()
            'Me.cmbPlaza.SelectedValue = -1
            'Me.cmbSucursal.SelectedValue = -1
            'Me.CmbProveedor.SelectedValue = -1
            'Me.cmbPlaza.Text = "Seleccione una Plaza..."
            'Me.cmbSucursal.Text = "Seleccione una Sucursal..."
            'Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.cmbPlaza.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompCotizacionServiciosFields.IdPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompCotizacionServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If Me.CmbProveedor.SelectedIndex > -1 Then
                Filtro.Add(HC.VwCompCotizacionServiciosFields.ProveedorId = Me.CmbProveedor.SelectedValue)
            End If

            If Me.chkFechas.Checked = True Then
                If Validar() Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompCotizacionServiciosFields.FechaAlta, Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
                End If
            End If

            Dim Lista As New TC.VwCompCotizacionServiciosTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Lista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function Validar() As Boolean
        If Not Me.DtpFechaIni.Text = "" And Not Me.DtpFechaFin.Text = "" Then
            If Me.DtpFechaIni.Value > Me.DtpFechaFin.Value Then
                MessageBox.Show("La Fecha Inicial debe ser Menor o Igual a la Fecha Final", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        'Me.cmbPlaza.SelectedValue = -1
        'Me.cmbSucursal.SelectedValue = -1
        'Me.CmbProveedor.SelectedValue = -1
        'Me.cmbPlaza.Text = "Seleccione una Plaza..."
        'Me.cmbSucursal.Text = "Seleccione una Sucursal..."
        'Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Limpiar()
        Me.DataGridView1.DataSource = Nothing
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub brnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub chkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechas.CheckedChanged
        If Me.chkFechas.Checked = True Then
            Me.DtpFechaIni.Enabled = True
            Me.DtpFechaFin.Enabled = True
        Else
            Me.DtpFechaIni.Enabled = False
            Me.DtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub chkFiltro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFiltro.CheckedChanged
        If Me.chkFiltro.Checked = True Then
            Me.cmbPlaza.Enabled = True
            Me.cmbSucursal.Enabled = True
            Me.CmbProveedor.Enabled = True
        Else
            Me.cmbPlaza.Enabled = False
            Me.cmbSucursal.Enabled = False
            Me.CmbProveedor.Enabled = False
            Limpiar()
        End If
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            If Me.cmbPlaza.SelectedIndex > -1 Then
                Me.SucursalC.Obtener(Me.cmbPlaza.SelectedValue, CondicionEnum.ACTIVOS)
                Me.cmbSucursal.SelectedIndex = -1
                Me.cmbSucursal.Text = "Seleccione una Sucursal"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        Me.cmbPlaza.SelectedValue = -1
        Me.cmbSucursal.SelectedValue = -1
        Me.CmbProveedor.SelectedValue = -1
        Me.cmbPlaza.Text = "Seleccione una Plaza..."
        Me.cmbSucursal.Text = "Seleccione una Sucursal..."
        Me.CmbProveedor.Text = "Seleccione un Proveedor..."
    End Sub

End Class