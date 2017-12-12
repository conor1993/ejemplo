Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures

Public Class CapturadePagosaFacturasForm
    Dim ProveedoresAV As New ProvAvanzadoCollectionClass
    Dim proveedores As New ProveedorCollectionClass
    Dim TiposProveedores As New TipoProveedorCollectionClass
    Dim RutaNodos As String
    Dim NodoSelect As TreeNode
    'Dim FacturasApagar As New CC.FacturasApagarCollection

    Private Sub CapturadePagosaFacturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.tvwProveedores.Nodes.Clear()

            Me.TiposProveedores.Obtener(ClasesNegocio.EstatusEnum.ACTIVO)

            For i As Integer = 0 To Me.TiposProveedores.Count - 1
                Me.tvwProveedores.Nodes.Add(TiposProveedores(i).Codigo, Me.TiposProveedores(i).Descripcion)
            Next i
            For i As Integer = 0 To Me.TiposProveedores.Count - 1
                proveedores = Me.ProveedoresAV.Obtener(Me.TiposProveedores(i).Codigo)
                For j As Integer = 0 To Me.proveedores.Count - 1
                    If Me.proveedores.Count > 0 Then
                        Me.tvwProveedores.Nodes(i).Nodes.Add(Me.proveedores(j).Codigo, Me.proveedores(j).RazonSocial)
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tvwProveedores_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwProveedores.AfterSelect
        Try
            If e.Node.Level = 1 Then
                'NodoSelect.Checked = False
                NodoSelect = e.Node
                Me.Label2.Text = NodoSelect.Text
                'busca las facturas de el proveedor seleecionado
                If FacturasApagar.GetMulti(HC.UsrCxpfacturasApagarFields.IdProveedor = NodoSelect.Name And HC.UsrCxpfacturasApagarFields.EmpresaId = Controlador.Sesion.Empndx) Then
                    Me.dgvFacturas.DataSource = FacturasApagar
                End If
            Else
                Label2.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tvwProveedores_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvwProveedores.BeforeSelect
        Try
            If Me.FacturasApagar.SaveMulti() Then
                MsgBox("La Factura ha sido guardada con el Importe Nuevo a pagar", MsgBoxStyle.Information, "AVISO")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvFacturas_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvFacturas.CellBeginEdit

    End Sub

    Private Sub dgvFacturas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturas.CellEndEdit
        Try
            Dim fac As New Integralab.ORM.EntityClasses.UsrCxpfacturasApagarEntity
            fac.FetchUsingPK(Controlador.Sesion.Empndx, NodoSelect.Name, Me.dgvFacturas.CurrentRow.Cells("NoFacturaDataGridViewTextBoxColumn").Value)
            If Not IsNumeric(Me.dgvFacturas.Rows(e.RowIndex).Cells("ImporteApagar").Value) Then
                Me.dgvFacturas.Rows(e.RowIndex).Cells("ImporteApagar").Value = 0.0
            ElseIf Me.dgvFacturas.Rows(e.RowIndex).Cells("ImporteApagar").Value < 0 Then
                MsgBox("El Importe a pagar no puede ser menor a 0.")
                Me.dgvFacturas.Rows(e.RowIndex).Cells("ImporteApagar").Value = 0.0
            ElseIf Me.dgvFacturas.Rows(e.RowIndex).Cells("ImporteApagar").Value > CDec(fac.Saldo) Then
                MsgBox("El Importe a pagar no puede ser mayor al Importe del Saldo")
                Me.dgvFacturas.Rows(e.RowIndex).Cells("ImporteApagar").Value = CDec(0)
            End If
            If e.RowIndex = Me.ImporteApagar.Index Then

            End If
            Me.dgvFacturas.CurrentRow.Cells("Saldo").Value = CDec(fac.Saldo) - Me.dgvFacturas.CurrentRow.Cells("ImporteApagar").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtfiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfiltro.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.txtfiltro.Text = "" Then
                Me.tvwProveedores.Nodes.Clear()

                Me.TiposProveedores.Obtener(ClasesNegocio.EstatusEnum.ACTIVO)

                For i As Integer = 0 To Me.TiposProveedores.Count - 1
                    Me.tvwProveedores.Nodes.Add(TiposProveedores(i).Codigo, Me.TiposProveedores(i).Descripcion)
                Next i
                For i As Integer = 0 To Me.TiposProveedores.Count - 1
                    proveedores = Me.ProveedoresAV.Obtener(Me.TiposProveedores(i).Codigo, Me.txtfiltro.Text)
                    ' Me.proveedores.Obtener(Me.txtfiltro.Text, CondicionEnum.ACTIVOS, TiposProveedores(i).Codigo)
                    For j As Integer = 0 To Me.proveedores.Count - 1
                        If Me.proveedores.Count > 0 Then
                            Me.tvwProveedores.Nodes(i).Nodes.Add(Me.proveedores(j).Codigo, Me.proveedores(j).RazonSocial)
                        End If
                    Next
                Next
            Else
                Me.tvwProveedores.Nodes.Clear()

                Me.TiposProveedores.Obtener(ClasesNegocio.EstatusEnum.ACTIVO)

                For i As Integer = 0 To Me.TiposProveedores.Count - 1
                    Me.tvwProveedores.Nodes.Add(TiposProveedores(i).Codigo, Me.TiposProveedores(i).Descripcion)
                Next i
                For i As Integer = 0 To Me.TiposProveedores.Count - 1
                    proveedores = Me.ProveedoresAV.Obtener(Me.TiposProveedores(i).Codigo)
                    For j As Integer = 0 To Me.proveedores.Count - 1
                        If Me.proveedores.Count > 0 Then
                            Me.tvwProveedores.Nodes(i).Nodes.Add(Me.proveedores(j).Codigo, Me.proveedores(j).RazonSocial)
                        End If
                    Next
                Next
            End If
        End If
    End Sub

End Class