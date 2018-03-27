Public Class BusquedaFacturasForm

    Private Proveedores As New ClasesNegocio.ProveedorCollectionClass
    Public Factura As String
    Public ProveedorID As Integer
    Public EsDeGastos As Boolean
    Public Ifacturacancelada As Integer

    Private Sub BusquedaFacturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TxtFactura.Clear()

            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.ValueMember = "Codigo"
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Limpiar()
        Me.TxtFactura.Clear()
        Me.CmbProveedor.SelectedIndex = -1
        Me.CmbProveedor.Text = "Seleccione un proveedor..."
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Try
            Dim Facturas As New IntegraLab.ORM.TypedViewClasses.VwFacturasTypedView
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            Filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(IntegraLab.ORM.HelperClasses.VwFacturasFields.FechaFactura, Me.DateTimePicker1.Value.ToString("dd/MM/yyyy"), Me.DateTimePicker2.Value.AddDays(1).ToString("dd/MM/yyyy")))
            If Not Me.TxtFactura.Text = "" Then
                Filtro.Add(IntegraLab.ORM.HelperClasses.VwFacturasFields.NoFactura = Me.TxtFactura.Text)
            End If
            If Me.CmbProveedor.SelectedValue > 0 Then
                Filtro.Add(IntegraLab.ORM.HelperClasses.VwFacturasFields.IdProveedor = Me.CmbProveedor.SelectedValue)
            End If
            If EsDeGastos Then
                Filtro.Add(IntegraLab.ORM.HelperClasses.VwFacturasFields.Gastos = True)
            End If


            Facturas.Fill(0, Nothing, True, Filtro)
            Me.DgvFacturas.AutoGenerateColumns = False
            Me.DgvFacturas.DataSource = Facturas

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.DgvFacturas.SelectedRows.Count = 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DgvFacturas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvFacturas.Click
        Factura = Me.DgvFacturas.SelectedRows(0).Cells("NoFactura").Value
        Ifacturacancelada = Me.DgvFacturas.SelectedRows(0).Cells("idfacturacancelada").Value
        Dim Proveedores As New ClasesNegocio.ProveedorCollectionClass
        Proveedores.Obtener(Me.DgvFacturas.SelectedRows(0).Cells("Proveedor").Value)
        If Proveedores.Count = 1 Then
            Me.ProveedorID = Proveedores(0).Codigo
        End If
    End Sub

    Private Sub RecepcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepcionesToolStripMenuItem.Click
        'Ojo
        'Try
        '    Dim FRecep As New FacturasDetallesForm
        '    If Me.DgvFacturas.SelectedRows.Count > 0 Then
        '        If Not IsNothing(Factura) Then
        '            FRecep.FolioF = Factura
        '            Dim Receps As New IntegraLab.ORM.TypedViewClasses.VwRecepcionFacturaTypedView
        '            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
        '            filtro.Add(IntegraLab.ORM.HelperClasses.VwRecepcionFacturaFields.FolioFactura = Factura)
        '            FRecep.DataGridView1.AutoGenerateColumns = False
        '            Receps.Fill(0, Nothing, True, filtro)
        '            If Receps.Count > 0 Then
        '                FRecep.DataGridView1.DataSource = Receps
        '                FRecep.ShowDialog()
        '            Else
        '                MsgBox("La Factura no tiene Recepciones Relacionadas...")
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try
    End Sub

    Private Sub DgvFacturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvFacturas.SelectionChanged
        Factura = Me.DgvFacturas.SelectedRows(0).Cells("NoFactura").Value
        Dim Proveedores As New ClasesNegocio.ProveedorCollectionClass
        Proveedores.Obtener(Me.DgvFacturas.SelectedRows(0).Cells("Proveedor").Value)
        If Proveedores.Count = 1 Then
            Me.ProveedorID = Proveedores(0).Codigo
        End If
    End Sub
End Class