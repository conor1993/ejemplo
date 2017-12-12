Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ComBusquedaCotizacion
    Dim PlazaC As New ClasesNegocio.PlazaCollectionClass
    Dim SucursalC As New ClasesNegocio.SucursalCollectionClass
    Dim ProveedorC As New ClasesNegocio.ProveedorCollectionClass
    Public IdPlaza As Integer = -1
    Public idSucursal As Integer = -1
    Public OrdenGenerda As Boolean

    Private Sub ComBusquedaCotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim plaza As New ClasesNegocio.PlazaClass
            plaza.Descripcion = "TODAS"

            Dim plzC As New ClasesNegocio.PlazaCollectionClass
            plzC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            PlazaC.Add(plaza)
            For Each pl As ClasesNegocio.PlazaClass In plzC
                PlazaC.Add(pl)
            Next

            cmbPlaza.DataSource = PlazaC
            cmbPlaza.DisplayMember = "Descripcion"
            cmbPlaza.ValueMember = "Codigo"

            Dim provC As New ClasesNegocio.ProveedorCollectionClass
            provC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim pro As New ClasesNegocio.ProveedorClass

            pro.RazonSocial = "TODOS"

            Me.ProveedorC.Clear()

            Me.ProveedorC.Add(pro)

            For Each p As ClasesNegocio.ProveedorClass In provC
                Me.ProveedorC.Add(p)
            Next

            cmbProveedor.DataSource = Me.ProveedorC
            cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.ValueMember = "Codigo"

            If Not IdPlaza = -1 Then
                Me.cmbPlaza.SelectedValue = IdPlaza
                Me.cmbPlaza.Enabled = False
            End If
            If Not idSucursal = -1 Then
                Me.cmbSucursal.SelectedValue = idSucursal
                Me.cmbSucursal.Enabled = False
            End If
            Me.txtFolio.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim vista As New TC.VwBusquedaCotizacionesTypedView
            Dim filtro As New OC.PredicateExpression

            If Me.txtFolio.Text.Trim = "" Then
                If Me.cmbProveedor.SelectedIndex > 0 Then
                    filtro.Add(HC.VwBusquedaCotizacionesFields.IdProveedor = cmbProveedor.SelectedValue)
                End If

                If Me.cmbPlaza.SelectedIndex > 0 Then
                    filtro.Add(HC.VwBusquedaCotizacionesFields.PlazId = cmbPlaza.SelectedValue)
                End If

                If Me.cmbSucursal.SelectedIndex > 0 Then
                    filtro.Add(HC.VwBusquedaCotizacionesFields.IdSucursal = cmbSucursal.SelectedValue)
                End If

                If Me.chkFechas.Checked = True Then
                    If Me.validar = True Then
                        filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaCotizacionesFields.FechaAlta, Me.dtInicio.Value.ToShortDateString, Me.dtFin.Value.AddDays(1).ToShortDateString))
                    End If
                End If

                If Me.rbtActivaa.Checked Then
                    filtro.Add(HC.VwBusquedaCotizacionesFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO)
                End If

                If Me.rbtCanceladas.Checked Then
                    filtro.Add(HC.VwBusquedaCotizacionesFields.Estatus = ClasesNegocio.EstatusEnum.INACTIVO)
                End If
            Else
                filtro.Add(HC.VwBusquedaCotizacionesFields.IdCotizacion Mod String.Format("%{0}%", Me.txtFolio.Text.Trim))
            End If

            vista.Fill(0, Nothing, True, filtro)

            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.txtFolio.Clear()
        Me.cmbProveedor.SelectedIndex = 0
        Me.cmbPlaza.SelectedIndex = 0
        Me.dtFin.Value = Now
        Me.dtInicio.Value = Now
        Me.rbtTodas.Checked = True
        Me.txtPresupuesto.Clear()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            If Me.cmbPlaza.SelectedIndex = -1 Or Me.cmbPlaza.ValueMember = "" Then
                Exit Sub
            End If
            Me.SucursalC.Obtener(Me.cmbPlaza.SelectedValue, ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim suc As New ClasesNegocio.SucursalClass
            suc.Descripcion = "TODAS"

            Dim sucs As New ClasesNegocio.SucursalCollectionClass
            sucs.Add(suc)

            For Each s As ClasesNegocio.SucursalClass In SucursalC
                sucs.Add(s)
            Next

            Me.cmbSucursal.DataSource = sucs
            Me.cmbSucursal.DisplayMember = "Descripcion"
            Me.cmbSucursal.ValueMember = "Codigo"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DataGridView1.SelectedRows.Count = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function validar() As Boolean
        If Me.dtInicio.Value > Me.dtFin.Value Then
            MessageBox.Show("La fecha inicial debe ser Mayor o Igual a la fecha final", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub chkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechas.CheckedChanged
        Try
            If Me.chkFechas.Checked = True Then
                Me.dtInicio.Enabled = True
                Me.dtFin.Enabled = True
            Else
                Me.dtInicio.Enabled = False
                Me.dtFin.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class