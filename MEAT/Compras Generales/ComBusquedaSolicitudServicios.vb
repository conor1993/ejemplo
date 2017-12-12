Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class ComBusquedaSolicitudServicios

    Private Sub ComBusquedaSolicitudServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaCombox()
    End Sub

    Sub LlenaCombox()
        Try
            'llena combo Plazas
            Dim PlazaC As New PlazaCollectionClass
            Dim Plaza As New PlazaClass
            Plaza.Descripcion = "TODAS"
            PlazaC.Add(Plaza)

            Dim AuxColeccion As New PlazaCollectionClass
            AuxColeccion.Obtener(CondicionEnum.ACTIVOS)
            For Each Pl As PlazaClass In AuxColeccion
                PlazaC.Add(Pl)
            Next

            Me.cmbPlaza.DisplayMember = "plDescripcion"
            Me.cmbPlaza.ValueMember = "Codigo"
            Me.cmbPlaza.DataSource = PlazaC
            Me.cmbPlaza.SelectedIndex = 1
            Me.DataGridView1.AutoGenerateColumns = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.cmbPlaza.SelectedIndex > 0 Then
                Filtro.Add(HC.VwCompSolicitudServiciosFields.PlidPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > 0 Then
                Filtro.Add(HC.VwCompSolicitudServiciosFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If
            If Me.chkFechas.Checked = True Then
                If Validar() Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompSolicitudServiciosFields.FechaAlta, Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
                End If
            End If
            Dim Lista As New TC.VwCompSolicitudServiciosTypedView
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
        Me.cmbPlaza.SelectedValue = 0
        Me.cmbSucursal.SelectedValue = 0
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

    Private Sub brnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            If Me.cmbPlaza.SelectedIndex > 0 Then
                'Llena combo Sucursal
                Dim SucursalC As New SucursalCollectionClass
                Dim Sucursal As New SucursalClass
                Sucursal.Descripcion = "TODAS"
                SucursalC.Add(Sucursal)

                Dim AuxColeccion As New SucursalCollectionClass
                AuxColeccion.Obtener(Me.cmbPlaza.SelectedValue, CondicionEnum.ACTIVOS)
                For Each Suc As SucursalClass In AuxColeccion
                    SucursalC.Add(Suc)
                Next

                Me.cmbSucursal.DisplayMember = "Descripcion"
                Me.cmbSucursal.ValueMember = "Codigo"
                Me.cmbSucursal.DataSource = SucursalC
                Me.cmbSucursal.SelectedIndex = 0

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class