
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CN = ClasesNegocio

Public Class FrmBusquedaClientes
    Dim EstadosC As CN.EstadoCollectionClass
    Dim CiudadesC As CN.CiudadCollectionClass
    Dim PoblacionC As CN.PoblacionCollectionClass

    Private Sub FrmBusquedaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Est As New CN.EstadoClass
            Est.Descripcion = "TODOS"
            Dim estadosc As New CN.EstadoCollectionClass
            EstadosC.Add(Est)

            Dim EstC As New CN.EstadoCollectionClass
            EstC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
          
            For Each Estado As CN.EstadoClass In EstC
                EstadosC.Add(Estado)
            Next

            Me.cmbEstado.DisplayMember = "Descripcion"
            Me.cmbEstado.ValueMember = "Codigo"
            Me.cmbEstado.DataSource = EstadosC

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not Me.txtCodigo.Text = "" Then
                Filtro.Add(HC.VwBusquedaClientesFields.IdCliente = Me.txtCodigo.Text)
            End If

            If Not Me.txtCodigo.Text = "" Then
                Filtro.Add(HC.VwBusquedaClientesFields.)
            End If

            If Not Me.txtNombre.Text = "" Then
                Filtro.Add(HC.VwBusquedaClientesFields.Nombre Mod String.Format("%{0}%", Me.txtNombre.Text))
            End If

            If Not Me.txtRazonSocial.Text = "" Then
                Filtro.Add(HC.VwBusquedaClientesFields.RazonSocial Mod String.Format("%{0}%", Me.txtRazonSocial.Text))
            End If

            If Me.cmbEstado.SelectedIndex > 0 Then
                Filtro.Add(HC.VwBusquedaClientesFields.IdEstado = Me.cmbEstado.SelectedValue)
            End If

            If Me.cmbCiudad.SelectedIndex > 0 Then
                Filtro.Add(HC.VwBusquedaClientesFields.IdCiudad = Me.cmbCiudad.SelectedValue)
            End If

            If Me.cmbPoblacion.SelectedIndex > 0 Then
                Filtro.Add(HC.VwBusquedaClientesFields.IdPoblacion = Me.cmbPoblacion.SelectedValue)
            End If

            If Me.RbtnPersonaFisica.Checked Then
                Filtro.Add(HC.VwBusquedaClientesFields.TipoPersona = True)
            End If

            If Me.RbtnPersonaMoral.Checked Then
                Filtro.Add(HC.VwBusquedaClientesFields.TipoPersona = False)
            End If

            If Me.rbtnActivo.Checked Then
                Filtro.Add(HC.VwBusquedaClientesFields.Estatus = CN.EstatusEnum.ACTIVO)
            End If

            If Me.rbtnCancelado.Checked Then
                Filtro.Add(HC.VwBusquedaClientesFields.Estatus = CN.EstatusEnum.INACTIVO)
            End If

            If Me.ChkFechas.Checked Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaClientesFields.FechaAlta, Me.dtpFechaInicial.Value.ToShortDateString, Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString))
            End If

            Dim Vista As New TC.VwBusquedaClientesTypedView
            Vista.Fill(0, Nothing, True, Filtro)

            Me.dgvClientes.AutoGenerateColumns = False
            Me.dgvClientes.DataSource = Vista



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        Try
            If Me.cmbEstado.SelectedIndex > 0 Then
                Dim Ciudad As New CN.CiudadClass
                Ciudad.Descripcion = "TODAS"
                Me.CiudadesC = New CN.CiudadCollectionClass
                Me.CiudadesC.Add(Ciudad)

                Dim CiudadC As New CN.CiudadCollectionClass
                CiudadC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

                For Each CD As CN.CiudadClass In CiudadC
                    CiudadesC.Add(CD)
                Next

                Me.cmbCiudad.DisplayMember = "Descripcion"
                Me.cmbCiudad.ValueMember = "Codigo"
                Me.cmbCiudad.DataSource = CiudadesC
                Me.cmbCiudad.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCiudad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCiudad.SelectedIndexChanged
        Try
            If Me.cmbCiudad.SelectedIndex > 0 Then
                Dim Pob As New CN.PoblacionClass
                Me.PoblacionC = New CN.PoblacionCollectionClass
                Pob.Descripcion = "TODAS"
                Me.PoblacionC.Add(Pob)

                Dim PobC As New CN.PoblacionCollectionClass
                PobC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

                For Each Poblacion As CN.PoblacionClass In PobC
                    PoblacionC.Add(Poblacion)
                Next

                Me.cmbPoblacion.DisplayMember = "Descripcion"
                Me.cmbPoblacion.ValueMember = "Codigo"
                Me.cmbPoblacion.DataSource = PoblacionC
                Me.cmbPoblacion.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFechas.CheckedChanged
        If Me.ChkFechas.Checked = True Then
            Me.dtpFechaInicial.Enabled = True
            Me.dtpFechaFinal.Enabled = True
        Else
            Me.dtpFechaInicial.Enabled = False
            Me.dtpFechaFinal.Enabled = False
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Me.dgvClientes.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Try
            Me.txtCodigo.Text = ""
            Me.txtNombre.Text = ""
            Me.txtRazonSocial.Text = ""
            Me.cmbEstado.SelectedIndex = 0
            Me.cmbCiudad.SelectedIndex = -1
            Me.cmbPoblacion.SelectedIndex = -1
            Me.ChkFechas.Checked = False
            Me.rbtnTodos.Checked = True
            Me.rbtTodas.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvClientes.DoubleClick
        Try
            If Me.dgvClientes.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class