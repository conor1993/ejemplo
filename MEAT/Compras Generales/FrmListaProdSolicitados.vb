Public Class FrmListaProdSolicitados

    Private tol As New MEAToolBar.MEAToolBar
    Public CodigoPlaza As Integer = -1
    Public CodigoSucursal As Integer = -1
    Public FolioPres As String = ""
    Public ListaProd As New ClasesNegocio.SolicitudProductoDetalleCollectionClass

    Private Sub ComListaProdSolicitados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tol.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
            Me.btnBuscar.ImageList = tol.ImageList
            Me.btnBuscar.ImageIndex = 0

            DataGrid.AutoGenerateColumns = False
            'DataGrid.DataSource = ListaProductos

            Me.ClmCantidad.DataPropertyName = "Cantidad"
            Me.ClmCodigo.DataPropertyName = "Codigo"
            Me.ClmEntregarA.DataPropertyName = "EntregarA"
            Me.ClmEntrgarEn.DataPropertyName = "EntregarEn"
            Me.ClmFechaSolicito.DataPropertyName = "FechaSolicito"
            Me.ClmFechaSurtir.DataPropertyName = "FechaSurtir"
            Me.ClmFolio.DataPropertyName = "Folio"
            Me.ClmObservaciones.DataPropertyName = "Observaciones"
            Me.ClmProducto.DataPropertyName = "Producto"
            Me.ClmUnidad.DataPropertyName = "Unidad"
            Me.ClmUrgente.DataPropertyName = "Urgente"
            Me.ClmChk.DataPropertyName = "Checada"

            Dim PlazaC As New ClasesNegocio.PlazaCollectionClass
            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            PlazaC.Add(New ClasesNegocio.PlazaClass)

            Dim nueva As New ClasesNegocio.PlazaCollectionClass
            Dim p As New ClasesNegocio.PlazaClass

            p.Descripcion = "TODAS"
            nueva.Add(p)

            For Each plaza As ClasesNegocio.PlazaClass In PlazaC
                nueva.Add(plaza)
            Next

            cmbPlaza.DataSource = nueva
            cmbPlaza.DisplayMember = "Descripcion"
            cmbPlaza.ValueMember = "Codigo"

            Dim LineaC As New ClasesNegocio.LineaCollectionClass
            LineaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim Linn As New ClasesNegocio.LineaCollectionClass
            Dim lin As New ClasesNegocio.LineaClass

            lin.Descripcion = "TODAS"

            Linn.Add(lin)

            For Each linea As ClasesNegocio.LineaClass In LineaC
                Linn.Add(linea)
            Next

            cmbFamilia.DataSource = Linn
            cmbFamilia.DisplayMember = "Descripcion"
            cmbFamilia.ValueMember = "Codigo"

            cmbPlaza.SelectedValue = CodigoPlaza
            cmbSucursal.SelectedValue = CodigoSucursal
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            'Finally
            '    Com.Connection.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim PLazaId As Integer = -1
            Dim sucursalid As Integer = -1
            Dim LineaId As Integer = -1
            Dim SubLineaId As Integer = -1

            If Not cmbPlaza.SelectedIndex = 0 Then
                PLazaId = CType(cmbPlaza.SelectedValue, Integer)
            End If

            If cmbSucursal.SelectedIndex > 0 Then
                sucursalid = CType(cmbSucursal.SelectedValue, Integer)
            End If

            If cmbFamilia.SelectedIndex > 0 Then
                LineaId = CType(cmbFamilia.SelectedValue, Integer)
            End If

            If cmbSubFamilia.SelectedIndex > 0 Then
                SubLineaId = CType(cmbSubFamilia.SelectedValue, Integer)
            End If

            'ListaProductos.Obtener(PLazaId, sucursalid, LineaId, SubLineaId, Me.txtProducto.Text, ClasesNegocio.CondicionEnum.ACTIVOS)

            'For i As Integer = ListaProductos.Count - 1 To 0 Step -1
            '    For Each prod As ClasesNegocio.SolicitudProductoDetalleClass In ListaProd
            '        If prod.IdSolicitud = ListaProductos(i).IdSolicitud And prod.IdProducto = ListaProductos(i).Codigo Then
            '            ListaProductos.RemoveAt(i)
            '            Exit For
            '        End If
            '    Next
            'Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > -1 Then
            Dim suc As ClasesNegocio.SucursalCollectionClass = DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
            Dim sucn As New ClasesNegocio.SucursalCollectionClass
            Dim nueva As New ClasesNegocio.SucursalClass
            nueva.Descripcion = "TODAS"
            sucn.Add(nueva)

            For Each sucursal As ClasesNegocio.SucursalClass In suc
                sucn.Add(sucursal)
            Next

            cmbSucursal.DataSource = sucn
            cmbSucursal.DisplayMember = "Descripcion"
            cmbSucursal.ValueMember = "Codigo"
        Else
            cmbSucursal.SelectedIndex = -1
            cmbSucursal.DataSource = Nothing
        End If
    End Sub

    'Private Sub cmbFamilia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFamilia.SelectedIndexChanged
    '    If cmbFamilia.SelectedIndex > -1 Then
    '        Dim SubLineaC As ClasesNegocio.SubLineaCollectionClass = DirectCast(cmbFamilia.SelectedItem, ClasesNegocio.LineaClass).SubLineas
    '        Dim subl As New ClasesNegocio.SubLineaCollectionClass
    '        Dim subN As New ClasesNegocio.SubLineaClass

    '        subN.Descripcion = "TODAS"

    '        subl.Add(subN)

    '        For Each SubLinea As ClasesNegocio.SubLineaClass In SubLineaC
    '            subl.Add(SubLinea)
    '        Next

    '        cmbSubFamilia.DataSource = subl
    '        cmbSubFamilia.DisplayMember = "Descripcion"
    '        cmbSubFamilia.ValueMember = "Codigo"
    '    Else
    '        cmbSubFamilia.SelectedIndex = -1
    '        cmbSubFamilia.DataSource = Nothing
    '    End If
    'End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim Cont As Integer

            For i As Integer = 0 To DataGrid.Rows.Count - 1
                If CBool(DataGrid.Rows(i).Cells(0).Value) Then
                    Cont += 1
                    Exit For
                End If
            Next

            If Cont <= 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmbFamilia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFamilia.SelectedIndexChanged
        If cmbFamilia.SelectedIndex > -1 Then
            Dim SubLineaC As ClasesNegocio.SubLineaCollectionClass = DirectCast(cmbFamilia.SelectedItem, ClasesNegocio.LineaClass).SubLineas
            Dim subl As New ClasesNegocio.SubLineaCollectionClass
            Dim subN As New ClasesNegocio.SubLineaClass

            subN.Descripcion = "TODAS"

            subl.Add(subN)

            For Each SubLinea As ClasesNegocio.SubLineaClass In SubLineaC
                subl.Add(SubLinea)
            Next

            cmbSubFamilia.DataSource = subl
            cmbSubFamilia.DisplayMember = "Descripcion"
            cmbSubFamilia.ValueMember = "Codigo"
        Else
            cmbSubFamilia.SelectedIndex = -1
            cmbSubFamilia.DataSource = Nothing
        End If
    End Sub
End Class