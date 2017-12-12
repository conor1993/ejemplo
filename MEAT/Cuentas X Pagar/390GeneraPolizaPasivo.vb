Imports CN = ClasesNegocio
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class _390GeneraPolizaPasivo
    Dim Proveedores As CN.ProveedorCollectionClass
    Dim TiposProveedores As CN.TipoProveedorCollectionClass
    Dim Poliza As CN.PolizaClass
    Dim FacturasCabCol As CN.FacturaCabCXPColeccion
    Private Sub _390GeneraPolizaPasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.mtb.Buttons(0).ToolTipText = "Obtiene las cuentas contables que fueron afectadas en las facturas del proveedor."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(4).ToolTipText = "Genera la Poliza Auxiliar de pasivo"
            Me.mtb.Buttons(10).ToolTipText = "Imprime la Poliza de Auxiliar de Pasivo"
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Proveedores = New CN.ProveedorCollectionClass
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "Codigo"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"

            tiposproveedores = New CN.TipoProveedorCollectionClass
            Me.TiposProveedores.Obtener(ClasesNegocio.EstatusEnum.ACTIVO, True)
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

#Region "Metodos"
    Private Sub Limpiar()
        Me.CmbProveedor.SelectedIndex = 0
        'Me.CmbProveedor.Text = "Seleccione un Proveedor"
        Me.DgvFacturas.DataSource = Nothing
        Me.dtpFechaConta.Value = Now
        txtAbono.Text = ""
        txtCargo.Text = ""
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

    Private Sub Sumar()
        Dim Cargo As Decimal = 0D
        Dim Abono As Decimal = 0D

        For i As Integer = 0 To DgvFacturas.Rows.Count - 1
            With DgvFacturas.Rows(i)
                Cargo += .Cells(Me.clmCargo.Index).Value
                Abono += .Cells(Me.clmAbono.Index).Value
            End With
        Next

        txtCargo.Text = Cargo.ToString("C2")
        txtAbono.Text = Abono.ToString("C2")
    End Sub
#End Region

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Poliza As New DataTable
            If Me.CmbProveedor.SelectedIndex > 0 Then
                Poliza = SPR.GeneraPolizaPasivo(Controlador.Sesion.Empndx, Me.CmbProveedor.SelectedValue, Me.dtpFechaConta.Value.ToShortDateString, 1)
            Else
                Poliza = SPR.GeneraPolizaPasivo(Controlador.Sesion.Empndx, 0, Me.dtpFechaConta.Value.ToShortDateString, 2)
            End If

            If Poliza.Rows.Count > 0 Then
                Me.DgvFacturas.AutoGenerateColumns = False
                Me.DgvFacturas.DataSource = Poliza
                Sumar()
            Else
                MessageBox.Show("No se encontraron Facturas contabilizadas a esta fecha del proveedor seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
        Try

            If Me.DgvFacturas.Rows.Count > 0 Then
                Poliza = New CN.PolizaClass

                Poliza.Concepto = "POLIZA DE PASIVOS AL: " & Me.dtpFechaConta.Value
                Poliza.EmpresaId = Controlador.Sesion.MiEmpresa.Empndx
                Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
                Poliza.FechaCaptura = Now
                Poliza.FechaPoliza = Me.dtpFechaConta.Value
                Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.CUENTASxPAGAR
                Poliza.TipoCambio = 1
                Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
                Poliza.TipoError = ClasesNegocio.ErroresPolizaEnum.NINGUNO
                Poliza.Importe = CDec(Me.txtCargo.Text)

                If Me.txtCargo.Text <> Me.txtAbono.Text Then
                    If MessageBox.Show("¡La Poliza esta Descuadrada!, ¿Aun asi desea Guardarla?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Cancelar = True
                        Exit Sub
                    End If
                    Poliza.TipoError = ClasesNegocio.ErroresPolizaEnum.POLIZA_DESCUADRADA
                    Poliza.Importe = 0
                End If

                Dim PolizaDet As CN.PolizaDetalleClass
                For i As Integer = 0 To Me.DgvFacturas.Rows.Count - 1
                    With Me.DgvFacturas.Rows(i)
                        PolizaDet = New CN.PolizaDetalleClass
                        PolizaDet.IdCuentaContable = .Cells(Me.clmCodigo.Index).Value
                        If Not .Cells(Me.clmCargo.Index).Value = 0 Then
                            PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                            PolizaDet.Importe = .Cells(Me.clmCargo.Index).Value
                        Else
                            PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                            PolizaDet.Importe = .Cells(Me.clmAbono.Index).Value
                        End If
                    End With
                    PolizaDet.Posicion = i + 1
                    Poliza.Detalles2.Add(PolizaDet)
                Next

                If Not Poliza.Guardar2(Trans) Then
                    Trans.Rollback()
                    MessageBox.Show("Ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                FacturasCabCol = New CN.FacturaCabCXPColeccion
                Dim Contabilizada As Char = "N"
                Dim IdProveedor As Integer = -1
                If Me.CmbProveedor.SelectedIndex > 0 Then
                    IdProveedor = Me.CmbProveedor.SelectedValue
                End If
                FacturasCabCol.Obtener(Controlador.Sesion.Empndx, Me.dtpFechaConta.Value.ToShortDateString, Contabilizada, IdProveedor)
                If FacturasCabCol.Count > 0 Then
                    For Each fac As CN.FacturasCabCXPClass In FacturasCabCol
                        fac.IdPoliza = Poliza.Codigo
                        fac.Contabilizada = "S"
                        If Not fac.Guardar(Trans) Then
                            Trans.Rollback()
                            MessageBox.Show("Ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Next
                Else
                    Trans.Rollback()
                    MessageBox.Show("Ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Trans.Commit()
                MessageBox.Show("Se generó la poliza de pasivo con el folio: " & Poliza.NumeroPoliza, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("No hay datos a guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class