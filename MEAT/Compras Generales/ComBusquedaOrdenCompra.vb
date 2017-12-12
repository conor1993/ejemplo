Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio

Public Class ComBusquedaOrdenCompra

    Private Sub ComConsultaOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim colplz As New ClasesNegocio.PlazaCollectionClass
            Dim p As New ClasesNegocio.PlazaClass

            p.Descripcion = "TODAS"
            colplz.Add(p)

            For Each plaza As ClasesNegocio.PlazaClass In PlazaC
                colplz.Add(plaza)
            Next

            cmbPlaza.DataSource = colplz

            ProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Dim colprv As New ClasesNegocio.ProveedorCollectionClass
            Dim pro As New ClasesNegocio.ProveedorClass
            pro.RazonSocial = "TODOS"

            colprv.Add(pro)

            For Each prove As ClasesNegocio.ProveedorClass In ProveedorC
                colprv.Add(prove)
            Next

            cmbProveedor.DataSource = colprv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Condicion As ClasesNegocio.CondicionEnum
            'Dim Plaza As ClasesNegocio.PlazaClass
            'Dim Sucursal As ClasesNegocio.SucursalClass
            'Dim Proveedor As ClasesNegocio.ProveedorClass
            Dim Autorizadas As ClasesNegocio.CondicionAsignadaEnum
            Dim recibidas As ClasesNegocio.CondicionOrdenRecibida

            If Me.rbtAcivas.Checked Then
                Condicion = ClasesNegocio.CondicionEnum.ACTIVOS
            End If

            If Me.rbtCanceladas.Checked Then
                Condicion = ClasesNegocio.CondicionEnum.INACTIVOS
            End If

            If Me.rbtTodas.Checked Then
                Condicion = ClasesNegocio.CondicionEnum.TODOS
            End If

            If Me.RbtSi.Checked Then
                Autorizadas = ClasesNegocio.CondicionAsignadaEnum.SI
            End If

            If Me.RbtNo.Checked Then
                Autorizadas = ClasesNegocio.CondicionAsignadaEnum.NO
            End If

            If Me.RbtautorizadasTodas.Checked Then
                Autorizadas = ClasesNegocio.CondicionAsignadaEnum.TODOS
            End If

            If Me.RbtRecTodas.Checked Then
                recibidas = ClasesNegocio.CondicionOrdenRecibida.TODOS
            End If

            If Me.RbtRecSI.Checked Then
                recibidas = ClasesNegocio.CondicionOrdenRecibida.SI
            End If

            If Me.RbtRecParcial.Checked Then
                recibidas = ClasesNegocio.CondicionOrdenRecibida.PARCIAL
            End If

            If Me.RbtRecNo.Checked Then
                recibidas = ClasesNegocio.CondicionOrdenRecibida.NO
            End If

            'If cmbPlaza.SelectedIndex > 0 Then
            '    Plaza = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)
            'End If

            'If cmbSucursal.SelectedIndex > 0 Then
            '    Sucursal = DirectCast(cmbSucursal.SelectedItem, ClasesNegocio.SucursalClass)
            'End If

            'If cmbProveedor.SelectedIndex > 0 Then
            '    Proveedor = DirectCast(cmbProveedor.SelectedItem, ClasesNegocio.ProveedorClass)
            'End If

            'Me.OrdenCompraC.Obtener(Condicion, Plaza, Sucursal, Proveedor, Autorizadas, recibidas)



            Dim Filtro As New OC.PredicateExpression

            If Trim(Me.txtFolioOrden.Text) <> "" Then
                Filtro.Add(HC.VwCompConsultaOrdenCompraFields.FolioOrdenCompra = Me.txtFolioOrden.Text)
            Else
                If Condicion <> ClasesNegocio.CondicionEnum.TODOS Then
                    Filtro.Add(HC.VwCompConsultaOrdenCompraFields.Estatus = Condicion)
                End If
                If recibidas <> ClasesNegocio.CondicionOrdenRecibida.TODOS Then
                    Filtro.Add(HC.VwCompConsultaOrdenCompraFields.Recibida = recibidas)
                End If
                If Autorizadas <> ClasesNegocio.CondicionAsignadaEnum.TODOS Then
                    Filtro.Add(HC.VwCompConsultaOrdenCompraFields.Autorizada = Autorizadas)
                End If


                If Me.txtFolioOrden.Text <> "" Then
                    Filtro.Add(HC.VwCompConsultaOrdenCompraFields.FolioOrdenCompra = Me.txtFolioOrden.Text)
                End If
                If Me.cmbProveedor.SelectedIndex > 0 Then                    
                    Filtro.Add(HC.VwCompConsultaOrdenCompraFields.IdProveedor = Me.cmbProveedor.SelectedValue)
                End If
                If Me.cmbPlaza.SelectedIndex > 0 Then
                    Filtro.Add(HC.VwCompConsultaOrdenCompraFields.PlIdPlaza = Me.cmbPlaza.SelectedValue)
                End If
                If Me.cmbSucursal.SelectedIndex > 0 Then
                    Filtro.Add(HC.VwCompConsultaOrdenCompraFields.IdSucursal = Me.cmbSucursal.SelectedValue)
                End If

            End If

            Dim VistaCompras As New TC.VwCompConsultaOrdenCompraTypedView
            VistaCompras.Fill(0, Nothing, True, Filtro)

            If VistaCompras.Rows.Count = 0 Then
                Me.DgvOrdencompra.DataSource = Nothing
                Me.Dgvproductos.DataSource = Nothing
                MsgBox("No existe información de ordenes de compra con esos parametros ", MsgBoxStyle.Information, "")
                Exit Sub
            End If

            Me.DgvOrdencompra.AutoGenerateColumns = False
            Me.DgvOrdencompra.DataSource = VistaCompras

            Me.DgvOrdencompra.ReadOnly = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        cmbPlaza.SelectedIndex = 0
        txtFolioOrden.Clear()
        cmbSucursal.DataSource = Nothing
        cmbProveedor.SelectedIndex = 0
        Me.rbtTodas.Checked = True
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgvOrdencompra.DoubleClick
        Try
            If Me.DgvOrdencompra.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.DgvOrdencompra.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > 0 Then
            SucursalC.Obtener(CInt(cmbPlaza.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)
            Dim colsuc As New ClasesNegocio.SucursalCollectionClass
            Dim suc As New ClasesNegocio.SucursalClass

            suc.Descripcion = "TODAS"

            colsuc.Add(suc)

            For Each sucursal As ClasesNegocio.SucursalClass In SucursalC
                colsuc.Add(sucursal)
            Next

            cmbSucursal.DataSource = colsuc
        Else
            cmbSucursal.DataSource = Nothing
            cmbSucursal.Text = "TODAS"
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvOrdencompra.CellContentClick

    End Sub

    Private Sub DgvOrdencompra_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvOrdencompra.SelectionChanged
        Try
            If Me.DgvOrdencompra.SelectedRows.Count > 0 Then
                Dim FolioOrdenCompra As String
                Dim IdOrdenCompra As Integer
                Dim OrdenCompra As New CN.OrdenCompraClass
                FolioOrdenCompra = Me.DgvOrdencompra.CurrentRow.Cells(Me.Folio.Index).Value
                IdOrdenCompra = Me.DgvOrdencompra.CurrentRow.Cells(Me.clmIdOrdenCompra.Index).Value
                OrdenCompra.Obtener(IdOrdenCompra)
                'Dim ordencompra As ClasesNegocio.OrdenCompraClass = Me.DgvOrdencompra.SelectedRows(0).DataBoundItem
                Me.Dgvproductos.AutoGenerateColumns = False
                Me.Dgvproductos.DataSource = OrdenCompra.Detalle
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub EstatusOrdenCompra()
    '    If Not Me.DgvOrdencompra.DataSource Is Nothing Then
    '        For i As Integer = 0 To Me.DgvOrdencompra.Rows.Count - 1
    '            If Me.DgvOrdencompra.Rows(i).Cells(Me.Folio.Index).Value = 0 Then
    '                Me.DgvOrdencompra.Rows(i).Cells(Me.Folio.Index).Value = "Cancelado"
    '            Else
    '                Me.DgvOrdencompra.Rows(i).Cells(Me.Folio.Index).Value = "Vigente"
    '            End If
    '        Next
    '    End If
    'End Sub
End Class