Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CN = ClasesNegocio

Public Class AutorizaPagosForm
    Dim Proveedores As New CN.ProveedorCollectionClass
    Dim TiposProveedores As New CN.TipoProveedorCollectionClass
    Dim NodoSelect As TreeNode
    Dim IdUsuarioAutoriza As Integer
    Dim FacturasApagar As New CN.FacturasAPagarCXPColeccion

#Region "Metodos"
    Private Sub Limpiar()
        Me.TxtSaldoProveedor.Clear()
        Me.txtSaldoBanco.Clear()
    End Sub
    Private Sub RellenarTrvProg()
        Try
            Me.TvwProg.Nodes.Clear()
            Me.TiposProveedores.Obtener(Integra.Clases.EstatusEnum.ACTIVO, True)
            For i As Integer = 0 To Me.TiposProveedores.Count - 1
                Me.TvwProg.Nodes.Add(TiposProveedores(i).Codigo, Me.TiposProveedores(i).Descripcion)
            Next i
            For i As Integer = 0 To Me.TiposProveedores.Count - 1
                'Necesito hacer el metodo en la coleccion de proveedores
                Me.Proveedores.Obtener(Me.TiposProveedores(i).Codigo, CondicionEnum.ACTIVOS)
                For j As Integer = 0 To Me.Proveedores.Count - 1
                    If Me.Proveedores.Count > 0 Then
                        If FacturasApagar.Obtener(Proveedores(j).Codigo, Controlador.Sesion.Empndx) Then
                            If FacturasApagar.Count > 0 Then
                                Me.TvwProg.Nodes(i).Nodes.Add(Me.Proveedores(j).Codigo, Me.Proveedores(j).RazonSocial)
                            End If
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
    Private Sub RellenarTrvAut()
        Try
            Me.TvwAut.Nodes.Clear()
            Me.TiposProveedores.Obtener(Integra.Clases.EstatusEnum.ACTIVO, True)
            For i As Integer = 0 To Me.TiposProveedores.Count - 1
                Me.TvwAut.Nodes.Add(TiposProveedores(i).Codigo, Me.TiposProveedores(i).Descripcion)
            Next i
            For i As Integer = 0 To Me.TiposProveedores.Count - 1
                'Tengo qe hacer el metodo 
                Me.Proveedores.Obtener(Me.TiposProveedores(i).Codigo, CondicionEnum.ACTIVOS)
                For j As Integer = 0 To Me.Proveedores.Count - 1
                    If Me.Proveedores.Count > 0 Then
                        If FacturasApagar.Obtener(Proveedores(j).Codigo, Controlador.Sesion.Empndx) Then
                            If FacturasApagar.Count > 0 Then
                                Me.TvwAut.Nodes(i).Nodes.Add(Me.Proveedores(j).Codigo, Me.Proveedores(j).RazonSocial)
                            End If
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
    'Con estos metodos no mostrará proveedores sin Facturas a pagar
    '    Private Sub ObtenerProvConFacturasTrvProg()
    '        Try
    '            Dim Nodos As Integer = Me.TvwProg.Nodes.Count
    '            Dim k As Integer = 0
    '            For i As Integer = 0 To Nodos
    '                If Me.TvwProg.Nodes(k).Nodes.Count < 1 Then
    '                    Me.TvwProg.Nodes(k).Remove()
    '                    k = 0
    '                Else
    '                    k = k + 1
    '                End If
    '            Next
    '        Catch ex As Exception
    '#If CONFIG = "Debug" Then
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '#Else
    '         msgbox("Ocurrió un Error", MsgBoxStyle.Critical ,"Error")
    '#End If
    '        End Try
    '    End Sub
    '    Private Sub ObtenerProvConFacturasTrvAut()
    '        Try
    '            Dim Nodos As Integer = Me.TvwAut.Nodes.Count
    '            Dim k As Integer = 0
    '            For i As Integer = 0 To Nodos
    '                If Me.TvwAut.Nodes(k).Nodes.Count < 1 Then
    '                    Me.TvwAut.Nodes(k).Remove()
    '                    k = 0
    '                Else
    '                    k = k + 1
    '                End If
    '            Next
    '        Catch ex As Exception
    '#If CONFIG = "Debug" Then
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '#Else
    '         msgbox("Ocurrió un Error", MsgBoxStyle.Critical ,"Error")
    '#End If
    '        End Try

    '    End Sub
    '
    Private Sub ObtenerFacturasAuto(ByVal Nodo As System.Windows.Forms.TreeNode)
        Try
            If Nodo.Level = 1 Then
                Limpiar()
                Me.Label2.Text = Nodo.Text
                Dim SaldoProveedor As Decimal = 0
                Dim Fact As New CC.UsrCxpfacturasCabCollection
                Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
                filtro.Add(HC.UsrCxpfacturasCabFields.Estatus = 2 Or HC.UsrCxpfacturasCabFields.Estatus = 3)
                filtro.Add(HC.UsrCxpfacturasCabFields.IdProveedor = Nodo.Name)
                Fact.GetMulti(filtro)
                For Each fac As EC.UsrCxpfacturasCabEntity In Fact
                    SaldoProveedor = SaldoProveedor + fac.Saldo
                Next
                If SaldoProveedor = 0 Then
                    Me.TxtSaldoProveedor.Text = 0.ToString("C2")
                Else
                    Me.TxtSaldoProveedor.Text = SaldoProveedor.ToString("C2")
                End If
                'busca las facturas de el proveedor seleccionado
                If FacturasApagar.Obtener(Nodo.Name) Then
                    Me.dgvFacturasAuto.AutoGenerateColumns = False
                    Me.dgvFacturasAuto.DataSource = FacturasApagar
                End If
                For i As Integer = 0 To Me.FacturasApagar.Count - 1
                    If FacturasApagar(i).Estatus = CN.EstatusFacturasApagar.AUTORIZADA Then
                        Me.dgvFacturasAuto.Rows(i).Cells("Autorizar").Value = True
                    ElseIf FacturasApagar(i).Estatus = CN.EstatusFacturasApagar.PAGADA Then
                        Me.dgvFacturasAuto.Rows(i).Cells("Autorizar").ReadOnly = True
                        Me.dgvFacturasAuto.Rows(i).Cells("Autorizar").Value = True
                        Me.dgvFacturasAuto.Rows(i).DefaultCellStyle.BackColor = Color.NavajoWhite
                        Me.dgvFacturasAuto.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                        Me.dgvFacturasAuto.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Coral
                    End If
                    'Como el saldo final es calculado C/ves qe se obtienen las facturas
                    'el saldo final se calcula de nuevo
                    'El importe a pagar se recomienda qe sea lo mismo qe el saldo
                    'Por eso antes se válida qe el Importe a pagar sea igual al saldo
                    If FacturasApagar(i).Saldo = 0 Then
                        Me.dgvFacturasAuto.Rows(i).Cells("ClmSaldoFinal").Value = 0.ToString("C2")
                    Else
                        Me.dgvFacturasAuto.Rows(i).Cells("ClmSaldoFinal").Value = FacturasApagar(i).Saldo - FacturasApagar(i).ImporteApagar
                    End If
                Next
            Else
                Me.Label2.Text = ""
                Me.dgvFacturasAuto.DataSource = Nothing
                Me.txtSaldoBanco.Text = ""
                Me.TxtSaldoProveedor.Text = ""
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
    Private Sub ObtenerFacturasProg(ByVal Nodo As System.Windows.Forms.TreeNode)
        Try
            If Nodo.Level = 1 Then
                Me.Label6.Text = Nodo.Text
                'busca las facturas de el proveedor seleecionado
                If FacturasApagar.Obtener(Nodo.Name) Then
                    Me.DgvFacturasProg.AutoGenerateColumns = False
                    Me.DgvFacturasProg.DataSource = FacturasApagar
                End If
                For i As Integer = 0 To Me.FacturasApagar.Count - 1
                    If FacturasApagar(i).Saldo = 0 Then
                        Me.DgvFacturasProg.Rows(i).Cells("SaldoFinal").Value = 0.ToString("C2")
                    Else
                        Me.DgvFacturasProg.Rows(i).Cells("SaldoFinal").Value = FacturasApagar(i).Saldo - FacturasApagar(i).ImporteApagar
                    End If
                    If FacturasApagar(i).Estatus = CN.EstatusFacturasApagar.AUTORIZADA Then
                        Me.DgvFacturasProg.Rows(i).Cells("ImporteApagar").ReadOnly = True
                        Me.DgvFacturasProg.Rows(i).DefaultCellStyle.BackColor = Color.NavajoWhite
                        Me.DgvFacturasProg.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Tan
                        Me.DgvFacturasProg.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Black
                    ElseIf FacturasApagar(i).Estatus = CN.EstatusFacturasApagar.PAGADA Then
                        Me.DgvFacturasProg.Rows(i).Cells("ImporteApagar").ReadOnly = True
                        Me.DgvFacturasProg.Rows(i).DefaultCellStyle.BackColor = Color.LightSalmon
                        Me.DgvFacturasProg.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Coral
                        Me.DgvFacturasProg.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Black
                    End If
                Next
            Else
                Me.DgvFacturasProg.DataSource = Nothing
                Label6.Text = ""
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub GuardarFacturasAuto()
        Try
            If Not Me.dgvFacturasAuto.Rows.Count = 0 Then
                For i As Integer = 0 To Me.dgvFacturasAuto.Rows.Count - 1
                    If CBool(Me.dgvFacturasAuto.Rows(i).Cells("Autorizar").Value) Then
                        Dim Fac As New Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
                        Fac.GetMulti(HC.UsrCxpfacturasApagarFields.NoFactura = Me.dgvFacturasAuto.Rows(i).Cells("NoFactura").Value And HC.UsrCxpfacturasApagarFields.IdProveedor = Me.NodoSelect.Name)
                        If Fac.Count = 1 Then
                            If Not Fac(0).Estatus = CN.EstatusFacturasApagar.PAGADA Then
                                If Not Fac(0).Estatus = CN.EstatusFacturasApagar.AUTORIZADA Then
                                    Fac(0).Estatus = CN.EstatusFacturasApagar.AUTORIZADA
                                    Fac(0).IdUsuarioAutorizacion = Me.IdUsuarioAutoriza
                                    Fac(0).Save()
                                    MsgBox(String.Format("La Factura {0} ha sido Guardada como Autorizada", Me.dgvFacturasAuto.Rows(i).Cells("NoFactura").Value), MsgBoxStyle.Information, "Aviso")
                                End If
                            End If
                        End If
                    Else
                        Dim Fac As New Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
                        Fac.GetMulti(Integralab.ORM.HelperClasses.UsrCxpfacturasApagarFields.NoFactura = Me.dgvFacturasAuto.Rows(i).Cells("NoFactura").Value)
                        Fac(0).Estatus = CN.EstatusFacturasApagar.PROGRAMADA
                        Fac(0).Save()
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub GuardarFacturasProg()
        Try
            If Me.FacturasApagar.Guardar Then
                MsgBox("La Factura ha sido Guardada con el Nuevo Importe a Pagar", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ValidarCantidadesProg(ByVal indexRw As Integer, ByVal Nodo As System.Windows.Forms.TreeNode, ByVal IndexCl As Integer)
        Try
            Dim fac As New Integralab.ORM.EntityClasses.UsrCxpfacturasApagarEntity
            fac.FetchUsingPK(Controlador.Sesion.Empndx, Nodo.Name, Me.DgvFacturasProg.Rows(indexRw).Cells("NoFacturaDataGridViewTextBoxColumn").Value)
            If fac.Estatus = CN.EstatusFacturasApagar.AUTORIZADA Then
                MsgBox("La Factura ya fue autorizada...")
            End If
            If Not IsNumeric(Me.DgvFacturasProg.Rows(indexRw).Cells("ImporteApagar").Value) Then
                Me.DgvFacturasProg.Rows(indexRw).Cells("ImporteApagar").Value = 0.0
            ElseIf Me.DgvFacturasProg.Rows(indexRw).Cells("ImporteApagar").Value < 0 Then
                MsgBox("El Importe a pagar no puede ser menor a 0.")
                Me.DgvFacturasProg.Rows(indexRw).Cells("ImporteApagar").Value = 0.0
            ElseIf Me.DgvFacturasProg.Rows(indexRw).Cells("ImporteApagar").Value > CDec(fac.Saldo) Then
                MsgBox("El Importe a pagar no puede ser mayor al Importe del Saldo")
                Me.DgvFacturasProg.Rows(indexRw).Cells("ImporteApagar").Value = CDec(0)
            End If
            If IndexCl = Me.ImporteApagar.Index Then
                Me.DgvFacturasProg.Rows(indexRw).Cells("SaldoFinal").Value = CDec(fac.Saldo) - Me.DgvFacturasProg.CurrentRow.Cells("ImporteApagar").Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ValidarCantidadesAuto(ByVal indexrow As Integer, ByVal Nodo As System.Windows.Forms.TreeNode, ByVal IndexCol As Integer)
        Try
            Dim fac As New Integralab.ORM.EntityClasses.UsrCxpfacturasApagarEntity
            fac.FetchUsingPK(Controlador.Sesion.Empndx, Nodo.Name, Me.dgvFacturasAuto.Rows(indexrow).Cells("NoFactura").Value)
            If Not IsNumeric(Me.dgvFacturasAuto.Rows(indexrow).Cells("ClmApagar").Value) Then
                Me.dgvFacturasAuto.Rows(indexrow).Cells("ClmApagar").Value = 0.0
            ElseIf Me.dgvFacturasAuto.Rows(indexrow).Cells("ClmApagar").Value < 0 Then
                MsgBox("El Importe a pagar no puede ser menor a 0.")
                Me.dgvFacturasAuto.Rows(indexrow).Cells("ClmApagar").Value = 0.0
            ElseIf Me.dgvFacturasAuto.Rows(indexrow).Cells("ClmApagar").Value > CDec(fac.Saldo) Then
                MsgBox("El Importe a pagar no puede ser mayor al Importe del Saldo")
                Me.dgvFacturasAuto.Rows(indexrow).Cells("ClmApagar").Value = CDec(0)
            End If
            If IndexCol = Me.ClmApagar.Index Then
                Me.dgvFacturasAuto.Rows(indexrow).Cells("ClmSaldoFinal").Value = CDec(fac.Saldo) - Me.dgvFacturasAuto.CurrentRow.Cells("ClmApagar").Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub AutorizaPagosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.RellenarTrvProg()
            Me.RellenarTrvAut()
            Me.Label2.Text = ""
            Me.Label6.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TvwAut_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TvwAut.AfterSelect
        NodoSelect = e.Node
        ObtenerFacturasAuto(e.Node)
    End Sub
    Private Sub TvwAut_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TvwAut.BeforeSelect
        '  GuardarFacturasAuto()
    End Sub

    Private Sub txtfiltroAuto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfiltroAuto.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If Not Me.txtfiltroAuto.Text = "" Then
                    Me.TvwAut.Nodes.Clear()

                    Me.TiposProveedores.Obtener(Integra.Clases.EstatusEnum.ACTIVO, True)
                    For i As Integer = 0 To Me.TiposProveedores.Count - 1
                        Me.TvwAut.Nodes.Add(TiposProveedores(i).Codigo, Me.TiposProveedores(i).Descripcion)
                    Next i
                    For i As Integer = 0 To Me.TiposProveedores.Count - 1
                        'En este fragmento obtiene los provedores de acuerdo al filtro
                        'Esta mal el metodooooo
                        Me.Proveedores.Obtener(Me.txtfiltroAuto.Text, TiposProveedores(i), CN.CondicionEstatusEnum.ACTIVO)
                        For j As Integer = 0 To Me.Proveedores.Count - 1
                            If Me.Proveedores.Count > 0 Then
                                Me.TvwAut.Nodes(i).Nodes.Add(Me.Proveedores(j).Codigo, Me.Proveedores(j).RazonSocial)
                            End If
                        Next
                    Next
                Else
                    Me.RellenarTrvAut()
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub

    Private Sub TvwProg_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TvwProg.AfterSelect
        NodoSelect = e.Node
        Me.ObtenerFacturasProg(e.Node)
    End Sub
    Private Sub TvwProg_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TvwProg.BeforeSelect

    End Sub

    Private Sub txtfiltroProg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfiltroProg.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If Not Me.txtfiltroProg.Text = "" Then
                    Me.TvwProg.Nodes.Clear()

                    Me.TiposProveedores.Obtener(Integra.Clases.EstatusEnum.ACTIVO, True)

                    For i As Integer = 0 To Me.TiposProveedores.Count - 1
                        Me.TvwProg.Nodes.Add(TiposProveedores(i).Codigo, Me.TiposProveedores(i).Descripcion)
                    Next i
                    For i As Integer = 0 To Me.TiposProveedores.Count - 1
                        Me.Proveedores.Obtener(Me.txtfiltroProg.Text, TiposProveedores(i), CN.CondicionEstatusEnum.ACTIVO)
                        For j As Integer = 0 To Me.Proveedores.Count - 1
                            If Me.Proveedores.Count > 0 Then
                                Me.TvwProg.Nodes(i).Nodes.Add(Me.Proveedores(j).Codigo, Me.Proveedores(j).RazonSocial)
                            End If
                        Next
                    Next
                Else
                    Me.RellenarTrvProg()
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "Autorizar"
    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        Try
            'se tiene qe qitar el campo de empreza
            If Me.TabControl1.SelectedIndex = 1 Then
                '    Dim Ventana As New ModCatAutorizacion
                '    If Ventana.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                '        Me.TabControl1.SelectedIndex = 0
                '    Else
                '        If Ventana.Permisos.CancelaOtrosProcesos Then
                '            Me.TvwAut.SelectedNode = Nothing
                Me.dgvFacturasAuto.DataSource = Nothing
                '            Me.IdUsuarioAutoriza = Ventana.Permisos.Usrndx
                '        Else
                '            MsgBox("El Usuario no está Autorizado...", MsgBoxStyle.Exclamation, "Advertencia")
                '        End If
                '    End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub
    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        If Me.TabControl1.SelectedIndex = 0 Then
            Me.DgvFacturasProg.DataSource = Nothing
            Me.TvwProg.SelectedNode = Nothing
        End If
    End Sub
#End Region

#Region "Terminar Edición"

    Private Sub dgvFacturasAuto_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturasAuto.CellContentClick
        Try
            If e.ColumnIndex = Me.Autorizar.Index Then
                Dim fac As New IntegraLab.ORM.EntityClasses.UsrCxpfacturasApagarEntity
                fac.FetchUsingPK(Controlador.Sesion.Empndx, NodoSelect.Name, Me.dgvFacturasAuto.Rows(e.RowIndex).Cells("NoFactura").Value)
                If fac.Estatus = ClasesNegocio.EstatusFacturasApagar.PAGADA Then
                    Exit Sub
                End If
                If CBool(Me.dgvFacturasAuto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                    Me.dgvFacturasAuto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
                Else
                    Me.dgvFacturasAuto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
                End If
                GuardarFacturasAuto()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
    Private Sub dgvFacturasAuto_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturasAuto.CellEndEdit
        Try
            Me.ValidarCantidadesAuto(e.RowIndex, NodoSelect, e.ColumnIndex)
            If e.ColumnIndex = Me.ClmApagar.Index Then
                Me.FacturasApagar.Guardar()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub

    Private Sub DgvFacturasProg_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DgvFacturasProg.CellBeginEdit

    End Sub

    Private Sub DgvFacturasProg_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturasProg.CellContentClick
        'If e.ColumnIndex = Me.ImporteApagar.Index Then
        '    If Me.DgvFacturasProg.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly Then

        '    End If
        'End If
    End Sub
    Private Sub DgvFacturasProg_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturasProg.CellEndEdit
        Try
            Me.ValidarCantidadesProg(e.RowIndex, NodoSelect, e.ColumnIndex)
            If e.ColumnIndex = Me.ImporteApagar.Index Then
                Me.GuardarFacturasProg()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub
    Private Sub dgvFacturasAuto_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFacturasAuto.DataError

    End Sub

    Private Sub DgvFacturasProg_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvFacturasProg.DataError

    End Sub
#End Region


End Class