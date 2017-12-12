Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class ComBusquedaRecepcionOrden
    Dim SucursalC As New SucursalCollectionClass
    Dim PlazaC As New ClasesNegocio.PlazaCollectionClass
    Dim Directas As Boolean

    Sub New(ByVal Directas As Boolean)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Directas = Directas
    End Sub

    Private Sub ComBusquedaRecepcionOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGridView1.AutoGenerateColumns = False
        Try
            Dim Prov As New ProveedorClass
            Prov.RazonSocial = "TODOS"

            Dim ProveCol As New ProveedorCollectionClass
            ProveCol.Obtener(CondicionEnum.ACTIVOS)
            Me.ProveedorC.Clear()
            Me.ProveedorC.Add(Prov)

            For Each Proveedor As ProveedorClass In ProveCol
                Me.ProveedorC.Add(Proveedor)
            Next

            Me.cmbProveedor.DataSource = Me.ProveedorC
            Me.cmbProveedor.DisplayMember = "RazonSocial"
            Me.cmbProveedor.ValueMember = "Codigo"

            ''''****comentado por Kareli Camargo 10/12/2014*******
            'Dim Almacen As New AlmacenClass
            'Almacen.Descripcion = "TODOS"

            'Me.AlmacenC.Add(Almacen)
            'Dim AlmaCol As New AlmacenCollectionClass
            'AlmaCol.Obtener(CondicionEnum.TODOS)

            'For Each Alm As AlmacenClass In AlmaCol
            'Me.AlmacenC.Add(Alm)
            'Next
            'Me.CmbAlmacen.DisplayMember = "Descripcion"
            'Me.CmbAlmacen.ValueMember = "Codigo"
            'Me.CmbAlmacen.DataSource = Me.AlmacenC
            'Me.CmbAlmacen.SelectedIndex = 0
            ''''****comentado por Kareli Camargo 10/12/2014*******

            LlenaCombox()
            Me.ChkFechas.Checked = True
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaCombox()
        Try
            'llena combo Plazas
            Dim Plaza As New PlazaClass
            Plaza.Descripcion = "TODAS"

            Dim PlazaColeccion As New PlazaCollectionClass
            PlazaColeccion.Obtener(CondicionEnum.ACTIVOS)
            Me.PlazaC.Clear()
            Me.PlazaC.Add(Plaza)

            For Each p As PlazaClass In PlazaColeccion
                Me.PlazaC.Add(p)
            Next

            Me.cmbPlaza.DataSource = Me.PlazaC
            Me.cmbPlaza.DisplayMember = "Descripcion"
            Me.cmbPlaza.ValueMember = "Codigo"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.cmbPlaza.SelectedIndex > 0 Then
                Filtro.Add(HC.VwCompRecepciondeOrdenesFields.IdPlaza = Me.cmbPlaza.SelectedValue)
            End If

            If Me.cmbProveedor.SelectedIndex > 0 Then
                Filtro.Add(HC.VwCompRecepciondeOrdenesFields.IdProveedor = Me.cmbProveedor.SelectedValue)
            End If

            If Me.cmbSucursal.SelectedIndex > 0 Then
                Filtro.Add(HC.VwCompRecepciondeOrdenesFields.IdSucursal = Me.cmbSucursal.SelectedValue)
            End If
            ''''****comentado por Kareli Camargo 10/12/2014*******
            'If Me.CmbAlmacen.SelectedIndex > 0 Then
            'Filtro.Add(HC.VwCompRecepciondeOrdenesFields.AlmacenId = Me.CmbAlmacen.ValueMember)
            'End If
            ''''****comentado por Kareli Camargo 10/12/2014*******

            If Validar() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompRecepciondeOrdenesFields.FechaRecepcion, Me.DtpFechaini.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            If Me.rbtnVigentes.Checked Then
                Filtro.Add(HC.VwCompRecepciondeOrdenesFields.Estatus2 = EstatusDatos.VIGENTE)
            End If

            If Me.rbtnCanceladas.Checked Then
                Filtro.Add(HC.VwCompRecepciondeOrdenesFields.Estatus2 = EstatusDatos.CANCELADO)
            End If

            Filtro.Add(HC.VwCompRecepciondeOrdenesFields.EsDirecta = Directas)

            Dim Lista As New TC.VwCompRecepciondeOrdenesTypedView
            Lista.Fill(0, Nothing, True, Filtro)


            'Me.DataGridView1.AutoGenerateColumns = True
            Me.DataGridView1.DataSource = Lista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Buscar()
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.cmbPlaza.SelectedIndex = 0
        Me.cmbProveedor.SelectedIndex = 0
        Me.cmbSucursal.SelectedIndex = 0
        ''''****comentado por Kareli Camargo 10/12/2014*******
        'Me.CmbAlmacen.SelectedIndex = 0
        ''''****comentado por Kareli Camargo 10/12/2014*******
        Me.ChkFechas.Checked = False
        Me.DtpFechaini.Value = Now
        Me.DtpFechaFin.Value = Now
        Me.rbtnVigentes.Checked = True
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

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
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

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            'Llena combo Sucursal
            If Me.cmbPlaza.SelectedIndex = -1 Or Me.cmbPlaza.ValueMember = "" Then
                Exit Sub
            End If
            Dim Suc As New SucursalClass
            Suc.Descripcion = "TODAS"

            Dim SucColeccion As New SucursalCollectionClass
            SucColeccion.Obtener(CType(Me.cmbPlaza.SelectedValue, Integer), CondicionEnum.ACTIVOS)
            Me.SucursalC.Clear()
            Me.SucursalC.Add(Suc)

            For Each s As SucursalClass In SucColeccion
                Me.SucursalC.Add(s)
            Next

            Me.cmbSucursal.DataSource = Me.SucursalC
            Me.cmbSucursal.DisplayMember = "Descripcion"
            Me.cmbSucursal.ValueMember = "Codigo"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFechas.CheckedChanged
        If Me.ChkFechas.Checked Then
            Me.GrpFechas.Enabled = True
        Else
            Me.GrpFechas.Enabled = False
        End If
    End Sub

    Private Function Validar() As Boolean
        If Me.ChkFechas.Checked Then
            If Me.DtpFechaini.Value.Date > Me.DtpFechaFin.Value.Date Then
                MsgBox("La Fecha Inicial debe ser menor o igual a la Fecha Final", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function
End Class