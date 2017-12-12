Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class ReporteExistenciasYCostosfrm

    Dim AlmacenCol As New AlmacenCollectionClass
    Dim productos As New IntegraLab.ORM.TypedViewClasses.VwProductosGeneralesTypedView
    Dim dt As New DataTable
    Dim tvw As New IntegraLab.ORM.DaoClasses.TypedListDAO
    Dim campos As New HC.ResultsetFields(2)
    Dim InvAlmC As New AlmacenGeneral.InventarioAlmacenCollectionClass


    Private Sub ReporteExistenciasYCostosfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.cmbAlmacen.DataSource = AlmacenCol
            Me.cmbAlmacen.DisplayMember = "Descripcion"
            Me.cmbAlmacen.ValueMember = "Codigo"

            'Obtener Almacenes
            AlmacenCol.Obtener(CondicionEnum.ACTIVOS)

            'Me.cmbProducto.DataSource = Me.productos
            'Me.cmbProducto.DisplayMember = "PdDescripcion"
            'Me.cmbProducto.ValueMember = "PdIdProducto"

            ''Dim pr As New ProductosVistaClass
            ''pr.Descripcion = "TODOS"
            ''Me.productos.Add(pr)
            'Dim dr As DataRow = productos.NewRow()
            'dr(1) = "-TODOS-"

            'productos.Clear()
            'productos.Rows.Add(dr)
            'productos.Fill(0, Nothing, False)

            'Experimentando con typedlist

            campos.DefineField(HC.ProductoFields.Codigo, 0)
            campos.DefineField(HC.ProductoFields.Descripcion, 1)

            tvw.GetMultiAsDataTable(campos, dt, 0, Nothing, Nothing, Nothing, False, Nothing, Nothing, 0, 0)
            Dim dr As DataRow = dt.NewRow
            dr("Codigo") = 0
            dr("Descripcion") = "-TODOS"
            dt.Rows.Add(dr)

            Me.cmbProducto.DataSource = dt
            Me.cmbProducto.DisplayMember = "Descripcion"
            Me.cmbProducto.ValueMember = "Codigo"
            Limpiar()

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub Limpiar()

        AlmacenCol.Obtener(CondicionEnum.ACTIVOS, True)

        dt = New DataTable
        tvw.GetMultiAsDataTable(campos, dt, 0, Nothing, Nothing, Nothing, False, Nothing, Nothing, 0, 0)
        Dim dr As DataRow = dt.NewRow
        dr("Codigo") = 0
        dr("Descripcion") = "-TODOS"
        dt.Rows.Add(dr)
        Me.cmbProducto.DataSource = dt
        Me.cmbProducto.DisplayMember = "Descripcion"
        Me.cmbProducto.ValueMember = "Codigo"
        Me.txtCodigoAlmacen.Clear()
        Me.txtCodigoProducto.Clear()
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbProducto.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un Almacén"
        Me.cmbProducto.Text = "Seleccione un Producto"
    End Sub

    Private Sub txtCodigoProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                dt = New DataTable
                If Me.txtCodigoProducto.Text <> "" Then
                    If IsNumeric(Me.txtCodigoProducto.Text) Then
                        Dim IdProducto As Integer = Me.txtCodigoProducto.Text
                        dt.Rows.Clear()

                        Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
                        filtro.Add(HC.ProductoFields.Codigo = IdProducto)
                        tvw.GetMultiAsDataTable(campos, dt, 0, Nothing, filtro, Nothing, False, Nothing, Nothing, 0, 0)

                        Me.cmbProducto.DataSource = dt
                        Me.cmbProducto.DisplayMember = "Descripcion"
                        Me.cmbProducto.ValueMember = "Codigo"
                        Me.txtCodigoProducto.Text = IdProducto
                    Else
                        'tvw.GetMultiAsDataTable(campos, dt, 0, Nothing, Nothing, Nothing, False, Nothing, Nothing, 0, 0)
                    End If
                Else
                    tvw.GetMultiAsDataTable(campos, dt, 0, Nothing, Nothing, Nothing, False, Nothing, Nothing, 0, 0)
                    Me.cmbProducto.DataSource = dt
                    Me.cmbProducto.DisplayMember = "Descripcion"
                    Me.cmbProducto.ValueMember = "Codigo"
                End If
            Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            End Try
        End If
    End Sub

    Private Sub txtCodigoProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProducto.TextChanged


    End Sub

    Private Sub txtCodigoAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtCodigoAlmacen_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoAlmacen.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If Me.txtCodigoAlmacen.Text <> "" Then
                    If IsNumeric(Me.txtCodigoAlmacen.Text) Then
                        Dim idalmacen As Integer = Me.txtCodigoAlmacen.Text
                        Me.AlmacenCol.Obtener(CInt(Me.txtCodigoAlmacen.Text), CondicionEnum.ACTIVOS)
                        If AlmacenCol.Count = 1 Then
                            Me.txtCodigoAlmacen.Text = idalmacen
                        End If
                    Else
                        AlmacenCol.Obtener(CondicionEnum.ACTIVOS)
                    End If
                Else
                    AlmacenCol.Obtener(CondicionEnum.ACTIVOS)
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            If Not IsNothing(Me.cmbAlmacen.SelectedValue) And Not IsNothing(Me.cmbProducto.SelectedValue) Then
                Me.InvAlmC.Obtener(Me.cmbAlmacen.SelectedValue, Me.cmbProducto.SelectedValue)
            ElseIf Not IsNothing(Me.cmbProducto.SelectedValue) Then
                Me.InvAlmC.Obtener(, Me.cmbProducto.SelectedValue)
            ElseIf Not IsNothing(Me.cmbAlmacen.SelectedValue) Then
                Me.InvAlmC.Obtener(Me.cmbAlmacen.SelectedValue, )
            End If

            If Me.rdbAlmacen.Checked Then
                Dim rpt As RptExistenciasYCostosDeAlmacen
                rpt = Me.InvAlmC.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                Dim previsualizar As New PreVisualizarForm
                previsualizar.Reporte = rpt
                previsualizar.ShowDialog()
            Else
                Dim rpt As RptExistenciasYCostosAlmacenAgrupadoXProducto
                rpt = Me.InvAlmC.Reporte2(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                Dim previsualizar As New PreVisualizarForm
                previsualizar.Reporte = rpt
                previsualizar.ShowDialog()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
End Class