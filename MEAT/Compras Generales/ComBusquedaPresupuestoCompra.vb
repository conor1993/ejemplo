Imports ClasesNegocio

Public Class ComBusquedaPresupuestoCompra

#Region "Miembros"

    Public IdPlaza As Integer = -1
    Public idSucursal As Integer = -1
    Private SoloSinGenerarEnOrden As Boolean

#End Region

#Region "Constructores"

    Public Sub New(Optional ByVal SoloSinGenerarEnOrden As Boolean = False)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.SoloSinGenerarEnOrden = SoloSinGenerarEnOrden
    End Sub

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        txtFolio.Clear()
        cmbPlaza.SelectedIndex = 0
        cmbSucursal.SelectedIndex = -1
        cmbSucursal.Text = "TODAS"
        cmbTipoPresupuesto.SelectedIndex = 0
        txtDescripcion.Clear()
    End Sub
#End Region

    Private Sub ComBusqeudaPresupuestoCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim colpl As New ClasesNegocio.PlazaCollectionClass

            Dim pl As New ClasesNegocio.PlazaClass

            pl.Descripcion = "TODAS"

            colpl.Add(pl)

            For Each plaza As ClasesNegocio.PlazaClass In PlazaC
                colpl.Add(plaza)
            Next

            cmbPlaza.DataSource = colpl

            TipoPresupuestoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim coltp As New ClasesNegocio.TipoPresupuestoCollectionClass

            Dim tp As New ClasesNegocio.TipoPresupuestoClass
            tp.Descripcion = "TODOS"

            coltp.Add(tp)

            For Each tipo As ClasesNegocio.TipoPresupuestoClass In TipoPresupuestoC
                coltp.Add(tipo)
            Next

            cmbTipoPresupuesto.DataSource = coltp

            Limpiar()

            If Not IdPlaza = -1 Then
                Me.cmbPlaza.SelectedValue = IdPlaza
                Me.cmbPlaza.Enabled = False
            End If
            If Not idSucursal = -1 Then
                Me.cmbSucursal.SelectedValue = idSucursal
                Me.cmbSucursal.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        Try
            If cmbPlaza.SelectedIndex > 0 Then
                cmbSucursal.DataSource = Nothing

                SucursalC.Clear()
                Dim suc As New ClasesNegocio.SucursalClass
                suc.Descripcion = "TODAS"

                SucursalC.Add(suc)

                For Each sucursal As ClasesNegocio.SucursalClass In DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
                    SucursalC.Add(sucursal)
                Next

                cmbSucursal.DataSource = SucursalC
            Else
                cmbSucursal.DataSource = Nothing
                cmbSucursal.Text = "TODAS"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Condicion As ClasesNegocio.CondicionEnum
            Dim Plaza As ClasesNegocio.PlazaClass = Nothing
            Dim Sucursal As ClasesNegocio.SucursalClass = Nothing
            Dim Tipo As ClasesNegocio.TipoPresupuestoClass = Nothing

            If Me.rbtAcivas.Checked Then
                Condicion = ClasesNegocio.CondicionEnum.ACTIVOS
            End If

            If Me.rbtCanceladas.Checked Then
                Condicion = ClasesNegocio.CondicionEnum.INACTIVOS
            End If

            If Me.rbtTodas.Checked Then
                Condicion = ClasesNegocio.CondicionEnum.TODOS
            End If

            If cmbPlaza.SelectedIndex > 0 Then
                Plaza = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)
            End If

            If cmbSucursal.SelectedIndex > 0 Then
                Sucursal = DirectCast(cmbSucursal.SelectedItem, ClasesNegocio.SucursalClass)
            End If

            If cmbTipoPresupuesto.SelectedIndex > 0 Then
                Tipo = cmbTipoPresupuesto.SelectedItem
            End If

            Me.PresupuestoCompraC.Obtener(Me.txtFolio.Text, Me.txtDescripcion.Text, Condicion, Plaza, Sucursal, Tipo)

            If Me.SoloSinGenerarEnOrden Then
                For i As Integer = Me.PresupuestoCompraC.Count - 1 To 0 Step -1
                    If Me.PresupuestoCompraC(i).OrdenCompraGenerada = AsignadaEnum.SI Then
                        Me.PresupuestoCompraC.RemoveAt(i)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DataGrid.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        Try
            If Me.DataGrid.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class