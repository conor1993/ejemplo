Imports CN = ClasesNegocio
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Public Class ReporteFacturasForm

    Dim Proveedores As New CN.ProveedorCollectionClass
    Dim TiposProveedores As New CN.TipoProveedorCollectionClass
    'ojo
    Dim Facturas As TC.VwCxpfacturasAgrupadasTypedView
    Dim ReporteFac As TC.VwCxpfacturasTypedView
    Dim UltimaTeclaProv As DateTime

    Private Sub ReporteFacturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With Controlador.Sesion.MiEmpresa
                Me.lblEmpresa.Text = .Empnom
            End With
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "111001111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "111111111"
            MtbEstados.StateNuevo = "111010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            ' Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Factura."
            'Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Factura a Inactiva."
            'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Factura."
            Me.mtb.Buttons(10).ToolTipText = "Imprime las Facturas Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "Codigo"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.TiposProveedores.Obtener(ClasesNegocio.EstatusEnum.ACTIVO, True)
            Me.CmbTipoProveedor.ValueMember = "Codigo"
            Me.CmbTipoProveedor.DataSource = TiposProveedores
            Me.CmbTipoProveedor.DisplayMember = "Descripcion"
            Me.DgvDetFacturas.AutoGenerateColumns = False
            Me.DgvFacturas.AutoGenerateColumns = False
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
        Me.CmbProveedor.SelectedIndex = -1
        Me.CmbProveedor.Text = "Seleccione un Proveedor"
        Me.CmbTipoProveedor.SelectedIndex = -1
        Me.CmbTipoProveedor.Text = "Seleccione un Tipo de Proveedor"
        Me.DgvFacturas.DataSource = Nothing
        Me.DgvDetFacturas.DataSource = Nothing
        Me.DtpFecFin.Value = Now
        Me.DtpFecInicio.Value = Now
    End Sub

    Private Sub Habilitar()
        Me.CmbProveedor.Enabled = True
        Me.CmbTipoProveedor.Enabled = True
        Me.DtpFecFin.Enabled = True
        Me.DtpFecInicio.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.CmbProveedor.Enabled = False
        Me.CmbTipoProveedor.Enabled = False
        Me.DtpFecFin.Enabled = False
        Me.DtpFecInicio.Enabled = False
    End Sub

    Public Function Reporte() As CN.RptFacturasCXP
        Dim Rep As New CN.RptFacturasCXP
        Dim ds As New DataSet
        Dim dtF As New CN.DsFacturasCXP.DtFacturaDataTable

        For Each Fac As TC.VwCxpfacturasRow In ReporteFac
            dtF.AddDtFacturaRow(Fac.NoFactura, Fac.TprDescripcion, Fac.FechaFactura, Fac.FechaVencimiento, Fac.SubTotal, Fac.Iva, Fac.Total, Fac.Cheque, Fac.EstatusFacturas, Fac.PrRazSocial, Fac.IdProveedor.ToString, Fac.FolioRecepcion, Fac.Fecha, Fac.FolioOrdenCompra, Fac.CantidadRecepcion, Fac.ImporteRecepcion)
        Next
        ds.Tables.Add(dtF)
        Rep.SetDataSource(ds)
        Rep.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        Rep.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnom)
        Rep.SetParameterValue(2, "Cuentas Por Pagar/Facturas")
        Return Rep
    End Function

#Region "Toolbar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            'ojo
            Me.Facturas = New TC.VwCxpfacturasAgrupadasTypedView
            Dim filtro As New OC.PredicateExpression
            If Me.CmbTipoProveedor.SelectedIndex > 0 Then
                filtro.Add(HC.VwCxpfacturasAgrupadasFields.PrIdTipoProveedor = Me.CmbTipoProveedor.SelectedValue)
            End If
            If Me.CmbProveedor.SelectedIndex > 0 Then
                filtro.Add(HC.VwCxpfacturasAgrupadasFields.IdProveedor = Me.CmbProveedor.SelectedValue)
            End If
            If Me.chkServicio.Checked Then
                filtro.Add(HC.VwCxpfacturasAgrupadasFields.EsServicio = True)
            Else
                filtro.Add(HC.VwCxpfacturasAgrupadasFields.EsServicio = False)
            End If
            filtro.Add(New OC.FieldBetweenPredicate(HC.VwCxpfacturasAgrupadasFields.FechaFactura, Me.DtpFecInicio.Value.ToString("dd/MM/yyyy"), Me.DtpFecFin.Value.AddDays(1).ToString("dd/MM/yyyy")))
            Facturas.Fill(0, Nothing, True, filtro)
            Me.DgvFacturas.DataSource = Facturas
            If Me.Facturas.Count = 0 And Not IsNothing(Me.CmbProveedor.SelectedValue) Then
                MsgBox("El Proveedor Seleccionado no tiene Facturas", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
    '    Limpiar()
    '    Deshabilitar()
    'End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try

            Me.ReporteFac = New TC.VwCxpfacturasTypedView
            Dim filtro As New OC.PredicateExpression
            If Not IsNothing(Me.CmbTipoProveedor.SelectedValue) Or Me.CmbTipoProveedor.SelectedIndex > 0 Then
                filtro.Add(HC.VwCxpfacturasFields.PrIdTipoProveedor = Me.CmbTipoProveedor.SelectedValue)
            End If
            If Not IsNothing(Me.CmbProveedor.SelectedValue) Or Me.CmbProveedor.SelectedIndex > 0 Then
                filtro.Add(HC.VwCxpfacturasFields.IdProveedor = Me.CmbProveedor.SelectedValue)
            End If
            If Me.chkServicio.Checked Then
                filtro.Add(HC.VwCxpfacturasFields.EsServicio = True)
            Else
                filtro.Add(HC.VwCxpfacturasFields.EsServicio = False)
            End If
            filtro.Add(New OC.FieldBetweenPredicate(HC.VwCxpfacturasFields.FechaFactura, Me.DtpFecInicio.Value.ToString("dd/MM/yyyy"), Me.DtpFecFin.Value.AddDays(1).ToString("dd/MM/yyyy")))
            ReporteFac.Fill(0, Nothing, True, filtro)

            Dim Previsualizador As New CN.PreVisualizarForm
            Previsualizador.Reporte = Reporte()
            Previsualizador.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub DgvFacturas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellClick
        Try
            If Me.DgvFacturas.SelectedRows.Count > 0 Then
                'ojo
                Me.DgvDetFacturas.Rows.Clear()
                If Me.chkServicio.Checked Then
                    Dim Rec As New CN.OrdenServicioCollectionClass
                    Rec.Obtener(CInt(Me.DgvFacturas.SelectedRows(0).Cells("ClmIdProveedor").Value), Me.DgvFacturas.SelectedRows(0).Cells("ClmNoFactura").Value)
                    For i As Integer = 0 To Rec.Count - 1
                        Me.DgvDetFacturas.Rows.Add()
                        Me.DgvDetFacturas.Rows(i).Cells("ClmFolioRecepcion").Value = Rec(i).Folio
                        Me.DgvDetFacturas.Rows(i).Cells("ClmFechaRecepcion").Value = Rec(i).FechaRecepcion
                        Me.DgvDetFacturas.Rows(i).Cells("ClmCantidad").Value = Rec(i).Cantidad
                        Me.DgvDetFacturas.Rows(i).Cells("ClmSubtotalRec").Value = Rec(i).SubTotal
                        Me.DgvDetFacturas.Rows(i).Cells("ClmivaRec").Value = Rec(i).IVA
                        Me.DgvDetFacturas.Rows(i).Cells("ClmTotalRec").Value = Rec(i).Total
                        Me.DgvDetFacturas.Rows(i).Cells("ClmEstatusRec").Value = Rec(i).Estatus
                    Next
                Else
                    Dim Rece As New CN.RecepcionOrdenCompraCollectionClass
                    Rece.Obtener(Me.DgvFacturas.SelectedRows(0).Cells("ClmIdProveedor").Value, Me.DgvFacturas.SelectedRows(0).Cells("ClmNoFactura").Value)
                    For i As Integer = 0 To Rece.Count - 1
                        Me.DgvDetFacturas.Rows.Add()
                        Me.DgvDetFacturas.Rows(i).Cells("ClmFolioRecepcion").Value = Rece(i).FolioRecepcionOrdenCompra
                        Me.DgvDetFacturas.Rows(i).Cells("ClmFechaRecepcion").Value = Rece(i).FechaRecepcion
                        Me.DgvDetFacturas.Rows(i).Cells("ClmCantidad").Value = Rece(i).Cantidad
                        Me.DgvDetFacturas.Rows(i).Cells("ClmSubtotalRec").Value = Rece(i).SubTotal
                        Me.DgvDetFacturas.Rows(i).Cells("ClmivaRec").Value = Rece(i).IVA
                        Me.DgvDetFacturas.Rows(i).Cells("ClmTotalRec").Value = Rece(i).Total
                        Me.DgvDetFacturas.Rows(i).Cells("ClmEstatusRec").Value = Rece(i).Estatus
                    Next
                    'Me.DgvDetFacturas.AutoGenerateColumns = False
                    'Me.DgvDetFacturas.DataSource = Rece
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvFacturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellContentClick

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