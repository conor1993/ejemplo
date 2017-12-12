Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses
Imports ORM = Integralab.ORM
Public Class _690ReporteFacturasGastos

    Dim FacturasGastos As New CN.FacturaCabCXPColeccion
    Dim Proveedores As New CN.ProveedorCollectionClass
    Dim FacturaDet As New CN.FacturaDetalleCXPColeccion
    Dim Factura As CN.FacturasCabCXPClass
    Dim TiposProveedores As New CN.TipoProveedorCollectionClass
    Dim UltimaTeclaProv As DateTime

    Private Sub _690ReporteFacturasGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "110100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Factura."
            Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Factura a Inactiva."
            Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Factura."
            ' Me.mtb.Buttons(10).ToolTipText = "Imprime las Ciudades Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            Me.Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "Codigo"
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.SelectedIndex = 0

            Me.TiposProveedores.Obtener(ClasesNegocio.EstatusEnum.ACTIVO, True)
            Me.CmbTipoProveedor.ValueMember = "Codigo"
            Me.CmbTipoProveedor.DataSource = TiposProveedores
            Me.CmbTipoProveedor.DisplayMember = "Descripcion"

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Function ObtenerCuentas(ByVal Nofactura As String, ByVal IdProveedor As Integer) As DataTable
        Try
            Dim campos As New HC.ResultsetFields(8)
            Dim rel As New OC.RelationCollection
            rel.Add(EC.UsrCxpfacturasDetEntity.Relations.CuentaContableEntityUsingCuentaContableId, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            campos.DefineField(ORM.UsrCxpfacturasDetFieldIndex.CarAbo, 0, "CargoAbono")
            campos.DefineField(ORM.UsrCxpfacturasDetFieldIndex.Importe, 1, "Importe")
            campos.DefineField(ORM.CuentaContableFieldIndex.Codigo, 2, "Codigo")
            campos.DefineField(ORM.CuentaContableFieldIndex.Cta, 3, "CuentaMayor")
            campos.DefineField(ORM.CuentaContableFieldIndex.SubCta, 4, "SubCta")
            campos.DefineField(ORM.CuentaContableFieldIndex.SsubCta, 5, "SsubCta")
            campos.DefineField(ORM.CuentaContableFieldIndex.SssubCta, 6, "SssubCta")
            campos.DefineField(ORM.CuentaContableFieldIndex.NomCuenta, 7, "Descripcion")
            Dim typedView As New ORM.DaoClasses.TypedListDAO
            Dim DT As New DataTable
            Dim Orden As New OC.SortExpression(New OC.SortClause(campos(0), SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasDetFields.NoFactura = Nofactura)
            filtro.Add(HC.UsrCxpfacturasDetFields.IdProveedor = IdProveedor)
            typedView.GetMultiAsDataTable(campos, DT, 0, Orden, filtro, rel, True, Nothing, Nothing, 0, 0)
            Return DT
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function

    Private Function Impresion() As CN.RptFacturasGastos
        Try
            Dim Reporte As New CN.RptFacturasGastos
            Dim DtFactura As New CN.DsFacturasGastos.DtFacturasDataTable
            Dim DtCuenta As New CN.DsFacturasGastos.DtCuentasDataTable
            Dim Ds As New DataSet
            For Each Fac As CN.FacturasCabCXPClass In FacturasGastos
                Dim Fact As CN.DsFacturasGastos.DtFacturasRow
                Fact = DtFactura.AddDtFacturasRow(Fac.NoFactura, Fac.FechaFactura, Fac.FechaVencimiento, Fac.ProveedorRazon, Fac.Subtotal, Fac.Iva, Fac.Total)
                Dim Dt As DataTable = ObtenerCuentas(Fac.NoFactura, Fac.IdProveedor)
                For i As Integer = 0 To Dt.Rows.Count - 1
                    With Dt.Rows(i)
                        DtCuenta.AddDtCuentasRow(CStr(.Item("CuentaMayor")), CStr(.Item("SubCta")), CStr(.Item("SsubCta")), _
                    CStr(.Item("SssubCta")), CStr(.Item("Descripcion")), CDec(IIf(CStr(.Item("CargoAbono")) = "C", .Item("Importe"), 0D)), CDec(IIf(CStr(.Item("CargoAbono")) = "A", .Item("Importe"), 0D)), Fact)
                    End With
                Next
            Next
            Ds.Tables.Add(DtFactura)
            Ds.Tables.Add(DtCuenta)
            Reporte.SetDataSource(Ds)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnom)
            Reporte.SetParameterValue(2, "Cuentas Por Pagar/Factura de Gastos")
            Return Reporte
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Me.dgvCuentas.Rows.Clear()
        If Me.CmbTipoProveedor.SelectedIndex > 0 Or Me.CmbProveedor.SelectedIndex > 0 Then
            If Me.ChkRango.Checked Then
                FacturasGastos.Obtener(Me.dtpFechaInicial.Value, Me.DtpFechaFinal.Value, CInt(Me.CmbTipoProveedor.SelectedValue), CInt(Me.CmbProveedor.SelectedValue))
            Else
                FacturasGastos.Obtener("", CInt(Me.CmbProveedor.SelectedValue), False, CInt(Me.CmbTipoProveedor.SelectedValue))
            End If
            Me.dgvFacturas.AutoGenerateColumns = False
            Me.dgvFacturas.DataSource = FacturasGastos
        Else
            If Me.ChkRango.Checked Then
                FacturasGastos.Obtener(Me.dtpFechaInicial.Value, Me.DtpFechaFinal.Value)
                Me.dgvFacturas.AutoGenerateColumns = False
                Me.dgvFacturas.DataSource = FacturasGastos
            Else
                FacturasGastos.Obtener()
                Me.dgvFacturas.AutoGenerateColumns = False
                Me.dgvFacturas.DataSource = FacturasGastos
            End If
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim previsualizar As New CN.PreVisualizarForm
        previsualizar.Reporte = Impresion()
        previsualizar.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.CmbTipoProveedor.SelectedIndex = 0
        Me.CmbProveedor.SelectedIndex = 0
        Me.CmbProveedor.Text = "Seleccione un Proveedor"
        Me.DtpFechaFinal.Value = Now
        Me.dtpFechaInicial.Value = Now
        Me.ChkRango.Checked = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub ChkRango_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRango.CheckedChanged
        If Me.ChkRango.Checked Then
            Me.DtpFechaFinal.Enabled = True
            Me.dtpFechaInicial.Enabled = True
        Else
            Me.DtpFechaFinal.Enabled = False
            Me.dtpFechaInicial.Enabled = False
        End If
    End Sub

    Private Sub dgvFacturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFacturas.SelectionChanged
        Try
            If Me.dgvFacturas.SelectedRows.Count > 0 Then
                Factura = DirectCast(Me.dgvFacturas.SelectedRows(0).DataBoundItem, ClasesNegocio.FacturasCabCXPClass)
                Me.dgvCuentas.AutoGenerateColumns = False
                'Me.dgvCuentas.DataSource = Factura.ObtenerEntidad.CuentaContableCollectionViaUsrCxpfacturasDet
                Dim campos As New HC.ResultsetFields(8)
                Dim rel As New OC.RelationCollection
                rel.Add(EC.UsrCxpfacturasDetEntity.Relations.CuentaContableEntityUsingCuentaContableId, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
                campos.DefineField(ORM.UsrCxpfacturasDetFieldIndex.CarAbo, 0, "CargoAbono")
                campos.DefineField(ORM.UsrCxpfacturasDetFieldIndex.Importe, 1, "Importe")
                campos.DefineField(ORM.CuentaContableFieldIndex.Codigo, 2, "Codigo")
                campos.DefineField(ORM.CuentaContableFieldIndex.Cta, 3, "CuentaMayor")
                campos.DefineField(ORM.CuentaContableFieldIndex.SubCta, 4, "SubCta")
                campos.DefineField(ORM.CuentaContableFieldIndex.SsubCta, 5, "SsubCta")
                campos.DefineField(ORM.CuentaContableFieldIndex.SssubCta, 6, "SssubCta")
                campos.DefineField(ORM.CuentaContableFieldIndex.NomCuenta, 7, "Descripcion")
                Dim typedView As New ORM.DaoClasses.TypedListDAO
                Dim DT As New DataTable
                Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
                filtro.Add(HC.UsrCxpfacturasDetFields.NoFactura = Factura.NoFactura)
                filtro.Add(HC.UsrCxpfacturasDetFields.IdProveedor = Factura.IdProveedor)
                typedView.GetMultiAsDataTable(campos, DT, 0, Nothing, filtro, rel, True, Nothing, Nothing, 0, 0)
                Me.dgvCuentas.Rows.Clear()
                For i As Integer = 0 To DT.Rows.Count - 1
                    Me.dgvCuentas.Rows.Add(1)
                    Dim Row As DataRow = DT.Rows(i)
                    With Me.dgvCuentas.Rows(i)
                        .Cells(Me.ClmCtaMayor.Index).Value = Row("CuentaMayor")
                        .Cells(Me.ClmSubCta.Index).Value = Row("SubCta")
                        .Cells(Me.ClmSsbCta.Index).Value = Row("SsubCta")
                        .Cells(Me.ClmSssCta.Index).Value = Row("SssubCta")
                        .Cells(Me.ClmDescripcion.Index).Value = Row("Descripcion")
                        If DT.Rows(i)("CargoAbono") = "A" Then
                            .Cells(Me.ClmAbono.Index).Value = Row("Importe")
                            .Cells(Me.ClmCargo.Index).Value = 0.0
                        Else
                            .Cells(Me.ClmCargo.Index).Value = Row("Importe")
                            .Cells(Me.ClmAbono.Index).Value = 0.0
                        End If
                    End With
                Next
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub

    Private Sub CmbTipoProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoProveedor.SelectedIndexChanged
        If Me.CmbTipoProveedor.SelectedIndex > 0 Then
            Me.Proveedores.Obtener(Me.CmbTipoProveedor.SelectedValue, ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub CmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.CmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
                Me.CmbProveedor.Focus()
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "IDProveedor"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.SelectedIndex = -1
            Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            Me.TmProveedor.Stop()
            Me.UltimaTeclaProv = Now
            Me.TmProveedor.Start()
        End If
    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTeclaProv.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                Proveedores.Obtener(True, Me.CmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class