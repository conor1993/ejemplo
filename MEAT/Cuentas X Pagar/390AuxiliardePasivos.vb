Imports CN = ClasesNegocio
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Public Class _390AuxiliardePasivos
    Dim Proveedores As New CN.ProveedorCollectionClass
    Dim TiposProveedores As New CN.TipoProveedorCollectionClass
    Private Sub _390AuxiliardePasivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With Controlador.Sesion.MiEmpresa
                Me.lblEmpresa.Text = .Empnom
            End With
            Me.Icon = MdiParent.Icon
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = ""
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = ""
            MtbEstados.StateNuevo = ""
            MtbEstados.StateGuardar = ""
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = ""
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas sin Contabilizar del Proveedor."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(4).ToolTipText = "Actualiza las Fecha de Contabilizacion de las Facturas Seleccionadas"
            Me.mtb.Buttons(10).ToolTipText = "Imprime en el Auxiliar de Pasivos de las Facturas Seleccionadas"
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "Codigo"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.TiposProveedores.Obtener(ClasesNegocio.EstatusEnum.ACTIVO, True)
            Me.DgvFacturas.AutoGenerateColumns = False
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
        Me.DgvFacturas.DataSource = Nothing
        Me.dtpFechaCorte.Value = Now
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
        End If
    End Sub

    Private Sub CmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProveedor.SelectedIndexChanged

    End Sub



    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            'buscar facturas del proveedor seleccionado
            Dim Filtro As New OC.PredicateExpression

            If Me.CmbProveedor.SelectedIndex > 0 Then
                Filtro.Add(HC.VwCxpfacturasSinContabilizarFields.IdProveedor = Me.CmbProveedor.SelectedValue)
            End If

            Filtro.Add(HC.VwCxpfacturasSinContabilizarFields.FechaFactura <= Me.dtpFechaCorte.Value.ToShortDateString)

            Dim VistaFacturas As New TC.VwCxpfacturasSinContabilizarTypedView
            VistaFacturas.Fill(0, Nothing, True, Filtro)

            If VistaFacturas.Rows.Count = 0 Then
                MsgBox("No existen facturas para contabilizar de este proveedor a la fecha " & Me.dtpFechaCorte.Value, MsgBoxStyle.Information, "")
                Exit Sub
            End If

            Me.DgvFacturas.AutoGenerateColumns = False
            Me.DgvFacturas.DataSource = VistaFacturas
            Me.DgvFacturas.ReadOnly = True


        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
        Try
            Dim FacturasCab As CN.FacturasCabCXPClass
            Dim NoFactura As String
            Dim IdProveedor As Integer
            Dim Encuentra As Boolean = False
            For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                ' If Me.DgvFacturas.Rows(i).Cells(Me.ClmFechaContable.Index).Value Is Nothing Then
                Encuentra = True
                NoFactura = Trim(Me.DgvFacturas.Rows(i).Cells(Me.ClmNoFactura.Index).Value)
                IdProveedor = Me.DgvFacturas.Rows(i).Cells(Me.clmIdProveedor.Index).Value
                FacturasCab = New CN.FacturasCabCXPClass(Controlador.Sesion.Empndx, IdProveedor, NoFactura)
                FacturasCab.FechaContabilizacion = Me.dtpFechaCorte.Value
                '   FacturasCab.Contabilizada = "S"
                If Not FacturasCab.Guardar(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                End If
                'End If
            Next

            If Encuentra Then
                Trans.Commit()
                MessageBox.Show("Se han contabilizado las facturas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("No existen facturas para contabilizar a esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cancelar = True
            End If
        Catch ex As Exception
            Trans.Rollback()
            Cancelar = True
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim AuxiliarPasivo As New DataGrid

            Dim Filtro As New OC.PredicateExpression
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.VwCxpauxiliarPasivosFields.Cta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Me.CmbProveedor.SelectedIndex > 0 Then
                Filtro.Add(HC.VwCxpauxiliarPasivosFields.IdProveedor = Me.CmbProveedor.SelectedValue)
            End If

            Filtro.Add(HC.VwCxpauxiliarPasivosFields.FechaFactura <= Me.dtpFechaCorte.Value.ToShortDateString)

            Dim VistaAuxiliares As New TC.VwCxpauxiliarPasivosTypedView
            VistaAuxiliares.Fill(0, Orden, True, Filtro)

            If VistaAuxiliares.Rows.Count = 0 Then
                MsgBox("No existe información para este proveedor en esta fecha " & Me.dtpFechaCorte.Value, MsgBoxStyle.Information, "")
                Exit Sub
            End If

            AuxiliarPasivo.DataSource = VistaAuxiliares

            Dim Reporte As New CN.RptCXPAuxiliarPasivos
            Reporte.SetDataSource(AuxiliarPasivo.DataSource)
            Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, Me.dtpFechaCorte.Value)
            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Reporte
            VerReporte.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class