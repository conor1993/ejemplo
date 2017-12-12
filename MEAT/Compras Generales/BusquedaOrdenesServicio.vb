Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class BusquedaOrdenesServicio
    Private _DefaultRecibida As EstatusOrdenRecibida = EstatusOrdenRecibida.TODAS

    Public Property DefaultRecibida(Optional ByVal BloquearControl As Boolean = False) As EstatusOrdenRecibida
        Get
            Return _DefaultRecibida
        End Get
        Set(ByVal value As EstatusOrdenRecibida)
            _DefaultRecibida = value
            Me.GrpRecibidas.Enabled = Not BloquearControl
        End Set
    End Property

    Private _DefaultAutorizada As EstatusAutorizada = EstatusAutorizada.TODAS

    Public Property DefaultAutorizada(Optional ByVal BloquearControl As Boolean = False) As EstatusAutorizada
        Get
            Return _DefaultAutorizada
        End Get
        Set(ByVal value As EstatusAutorizada)
            _DefaultAutorizada = value
            Me.GrpAutorizadas.Enabled = Not BloquearControl
        End Set
    End Property

    Private Sub BusquedaOrdenesServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ProveedorC = New ProveedorCollectionClass
            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Dim colprv As New ClasesNegocio.ProveedorCollectionClass
            Dim pro As New ClasesNegocio.ProveedorClass
            pro.RazonSocial = "TODOS"

            colprv.Add(pro)

            For Each prove As ClasesNegocio.ProveedorClass In ProveedorC
                colprv.Add(prove)
            Next

            cmbProveedor.DataSource = colprv
            cmbProveedor.DisplayMember = "RazonSocial"
            cmbProveedor.ValueMember = "Codigo"

            PlazaC = New PlazaCollectionClass
            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim colplz As New ClasesNegocio.PlazaCollectionClass
            Dim p As New ClasesNegocio.PlazaClass

            p.Descripcion = "TODAS"
            colplz.Add(p)

            For Each plaza As ClasesNegocio.PlazaClass In PlazaC
                colplz.Add(plaza)
            Next

            cmbPlaza.DisplayMember = "Descripcion"
            cmbPlaza.ValueMember = "Codigo"
            cmbPlaza.DataSource = colplz
           
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.cmbPlaza.SelectedIndex > 0 Then
                Filtro.Add(HC.VwOrdenesServicioFields.IdPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > 0 Then
                Filtro.Add(HC.VwOrdenesServicioFields.SucursalId = Me.cmbSucursal.SelectedValue)
            End If

            If Me.cmbProveedor.SelectedIndex > 0 Then
                Filtro.Add(HC.VwOrdenesServicioFields.ProveedorId = Me.cmbProveedor.SelectedValue)
            End If

            If Not Me.txtFolioOrden.Text = "" Then
                Filtro.Add(HC.VwOrdenesServicioFields.Folio = Me.txtFolioOrden.Text)
            End If

            If Me.RbtRecSI.Checked = True Then
                Filtro.Add(HC.VwOrdenesServicioFields.RecibidaEnum = ClasesNegocio.EstatusOrdenRecibida.RECIBIDA)
            End If

            If Me.RbtRecNo.Checked = True Then
                Filtro.Add(HC.VwOrdenesServicioFields.RecibidaEnum = ClasesNegocio.EstatusOrdenRecibida.NO_RECIBIDA)
            End If

            If Me.RbtSi.Checked = True Then
                Filtro.Add(HC.VwOrdenesServicioFields.Autorizada = ClasesNegocio.EstatusAutorizada.SI)
            End If

            If Me.RbtNo.Checked = True Then
                Filtro.Add(HC.VwOrdenesServicioFields.Autorizada = ClasesNegocio.EstatusAutorizada.NO)
            End If

            If Me.rbtActivas.Checked = True Then
                Filtro.Add(HC.VwOrdenesServicioFields.Estatus = EstatusDatos.VIGENTE)
            End If

            If Me.rbtCanceladas.Checked = True Then
                Filtro.Add(HC.VwOrdenesServicioFields.Estatus = EstatusDatos.CANCELADO)
            End If


            Dim Lista As New TC.VwOrdenesServicioTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.DataSource = Lista

        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        Try
            Me.txtFolioOrden.Text = ""

            Select Case Me.DefaultRecibida
                Case EstatusOrdenRecibida.TODAS
                    Me.RbtRecTodas.Checked = True
                Case EstatusOrdenRecibida.NO_RECIBIDA
                    Me.RbtRecNo.Checked = True
                Case EstatusOrdenRecibida.RECIBIDA
                    Me.RbtRecSI.Checked = True
            End Select

            Select Case Me.DefaultAutorizada
                Case EstatusAutorizada.TODAS
                    Me.RbtautorizadasTodas.Checked = True
                Case EstatusAutorizada.SI
                    Me.RbtSi.Checked = True
                Case EstatusAutorizada.NO
                    Me.RbtNo.Checked = True
            End Select

            Me.cmbPlaza.SelectedIndex = 0
            Me.cmbSucursal.SelectedIndex = 0
            Me.cmbProveedor.SelectedIndex = 0

            Me.rbtTodas.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            If Me.cmbPlaza.SelectedIndex > -1 Then
                Me.SucursalC = New SucursalCollectionClass
                Me.SucursalC.Obtener(Me.cmbPlaza.SelectedValue, CondicionEnum.ACTIVOS)

                Dim colSuc As New ClasesNegocio.SucursalCollectionClass

                Dim S As New ClasesNegocio.SucursalClass

                S.Descripcion = "TODAS"
                colSuc.Add(S)

                For Each Sucursal As ClasesNegocio.SucursalClass In SucursalC
                    colSuc.Add(Sucursal)
                Next

                Me.cmbSucursal.DataSource = colSuc
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class