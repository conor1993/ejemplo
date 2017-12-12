Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class FrmBusquedaSolicitudProducto
    Inherits MeatForm

#Region "Miembros"

#End Region

#Region "Metodos"

    Public Overrides Sub InicializarForma()
        cmbSucursal.DisplayMember = "Descripcion"
        cmbSucursal.ValueMember = "Codigo"

        Controlador.LlenarComboPlazas(cmbPlaza, ClasesNegocio.CondicionEnum.TODOS)
        Limpiar()
        Buscar()
    End Sub

    Public Sub ActualizarPlazas(ByVal e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboPlazas(cmbPlaza, CondicionEnum.ACTIVOS)
        End If
    End Sub

    Public Sub ActualizarSucursales(ByVal e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.F12 Then
            If cmbPlaza.SelectedIndex <> -1 Then
                cmbSucursal.DataSource = CType(cmbPlaza.SelectedItem, PlazaClass).Sucursales
            Else
                cmbSucursal.DataSource = Nothing
            End If
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.Text = "Seleccione una Sucursal..."
        End If
    End Sub

#End Region

#Region "Metodos del Menu"

    Public Overrides Function Limpiar() As Boolean
        Me.txtFolio.Clear()
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione una Plaza..."
        ChkFiltroFechas.Checked = True
        Me.dtFin.Value = Now
        Me.dtInicio.Value = Now.AddMonths(-1)

        For Each Control As CheckBox In grbEstatus.Controls
            Control.Checked = True
        Next
        Return True
    End Function

    Public Overrides Function Buscar() As Boolean
        Dim Solicitudes As New SolicitudProductoCollectionClass
        Dim filtro As New OC.PredicateExpression, FiltroEstatus As New OC.PredicateExpression
        Dim Relacion As New OC.RelationCollection

        If Me.txtFolio.Text.Trim = "" Then
            If Me.cmbSucursal.SelectedIndex >= 0 Then
                filtro.Add(HC.SolicitudProductoFields.IdSucursal = CType(cmbSucursal.SelectedValue, Integer))
            ElseIf cmbPlaza.SelectedIndex >= 0 Then
                Relacion.Add(EC.SolicitudProductoEntity.Relations.SucursalEntityUsingIdSucursal)
                Relacion.Add(EC.SucursalEntity.Relations.PlazaEntityUsingCodigoPlaza)
                filtro.Add(HC.PlazaFields.Codigo = CType(cmbPlaza.SelectedValue, Integer))
            End If

            If chkVigentes.Checked Then
                FiltroEstatus.Add(HC.SolicitudProductoFields.Estatus = SolicitudProductoClass.EstatusSolicitud.VIGENTE)
            End If

            If chkCancelados.Checked Then
                FiltroEstatus.AddWithOr(HC.SolicitudProductoFields.Estatus = SolicitudProductoClass.EstatusSolicitud.CANCELADA)
            End If

            If chkEmitida.Checked Then
                FiltroEstatus.AddWithOr(HC.SolicitudProductoFields.Estatus = SolicitudProductoClass.EstatusSolicitud.EMITIDA)
            End If

            If chkParEmitida.Checked Then
                FiltroEstatus.AddWithOr(HC.SolicitudProductoFields.Estatus = SolicitudProductoClass.EstatusSolicitud.PARCIALMENTE_EMITIDA)
            End If

            If Me.ChkFiltroFechas.Checked Then
                If Validar() Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.SolicitudProductoFields.FechaSolicitud, Me.dtInicio.Value.Date, Me.dtFin.Value.Date.AddDays(1).AddTicks(-1)))
                End If
            End If

        Else
            filtro.Add(HC.SolicitudProductoFields.FolioSolicitud Mod String.Format("%{0}%", Me.txtFolio.Text.Trim))
        End If

        filtro.Add(FiltroEstatus)
        Solicitudes.Obtener(filtro, New OC.SortExpression(New OC.SortClause(HC.SolicitudProductoFields.FechaSolicitud, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)), Relacion)

        Me.dgvSolicitudes.AutoGenerateColumns = False
        Me.dgvSolicitudes.DataSource = Solicitudes
        Return True
    End Function

#End Region

#Region "Eventos"

    Private Sub FrmBusquedaSolicitudProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "InicializarForma")
    End Sub

    Private Sub cmbPlaza_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbPlaza.PreviewKeyDown
        Utilerias.RunControlException(Me, "ActualizarPlazas", New Object() {e})
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Dim Argumentos As New PreviewKeyDownEventArgs(Keys.F12)
        Utilerias.RunControlException(Me, "ActualizarSucursales", New Object() {Argumentos})
    End Sub

    Private Sub cmbSucursal_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbSucursal.PreviewKeyDown
        Utilerias.RunControlException(Me, "ActualizarSucursales", New Object() {e})
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dgvSolicitudes.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ChkFiltroFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFiltroFechas.CheckedChanged
        Me.dtInicio.Enabled = Me.ChkFiltroFechas.Checked
        Me.dtFin.Enabled = Me.ChkFiltroFechas.Checked
    End Sub

    Private Function Validar() As Boolean
        If Me.dtInicio.Value > Me.dtFin.Value Then
            MessageBox.Show("La Fecha Inicial debe ser menor o igual a la Fecha Final", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub dgvSolicitudes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudes.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

#End Region

End Class