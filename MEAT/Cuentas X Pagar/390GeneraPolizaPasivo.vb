Imports CN = ClasesNegocio
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient

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

            TiposProveedores = New CN.TipoProveedorCollectionClass
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
        dgvGastos.DataSource = Nothing

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
            If DgvFacturas.Rows(i).Cells(check.Index).Value = True Then
                Cargo = Cargo + DgvFacturas.Rows(i).Cells(clmCargo.Index).Value
                Abono = Abono + DgvFacturas.Rows(i).Cells(clmAbono.Index).Value

                'With DgvFacturas.Rows(i)
                '    Cargo += .Cells(Me.clmCargo.Index).Value
                '    Abono += .Cells(Me.clmAbono.Index).Value
                'End With
            End If
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
                'Sumar()
                Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                If CmbProveedor.SelectedValue = 0 Then
                    Try
                        Dim cadenaConsulta As String = "select gdfg.IdPoliza,IdSucursal,IdMetodo,Cuenta,Ptj_Importe,Importe,Fecha,gdfg.Estatus,Factura,Idprovedor from GastosDepartamentalesFG as gdfg join usrCXPFacturasCab on NoFactura=Factura and IdProveedor= Idprovedor"
                        cadenaConsulta = String.Format(cadenaConsulta)
                        Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                        Dim adp As New SqlDataAdapter(sqlcom)

                        Dim tb As New DataTable

                        sqlCon.Open()
                        adp.Fill(tb)
                        Me.dgvGastos.AutoGenerateColumns = False
                        Me.dgvGastos.DataSource = tb
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    Try
                        Dim cadenaConsulta As String = "select gdfg.IdPoliza,IdSucursal,IdMetodo,Cuenta,Ptj_Importe,Importe,Fecha,gdfg.Estatus,Factura,Idprovedor from GastosDepartamentalesFG as gdfg join usrCXPFacturasCab on NoFactura=Factura and IdProveedor= Idprovedor where IdProveedor={0}"
                        cadenaConsulta = String.Format(cadenaConsulta, CmbProveedor.SelectedValue)

                        Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                        Dim adp As New SqlDataAdapter(sqlcom)

                        Dim tb As New DataTable

                        sqlCon.Open()
                        adp.Fill(tb)
                        Me.dgvGastos.AutoGenerateColumns = False
                        Me.dgvGastos.DataSource = tb
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show("No se encontraron Facturas contabilizadas a esta fecha del proveedor seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function obtenerdatasetPoliza(Poliza As ClasesNegocio.PolizaClass) As DataSet

        Dim cuentac, cuentac1, cuentac2, cuentac3 As New CN.CuentaContableClass
        Dim detalles As New CN.PolizaDetalleCollectionClass
        detalles = Poliza.Detalles
        Dim padre, padre1, padre2, padre3 As String
        Dim ds As New DataSet()
        Dim dt As New DataTable()
        Try
            ''--------------------------------
            ds.Tables.Add(dt)
            dt.Columns.Add("cta")
            dt.Columns.Add("subcta")
            dt.Columns.Add("ssubcta")
            dt.Columns.Add("sssubcta")
            dt.Columns.Add("nomcuenta1")
            dt.Columns.Add("nomcuenta2")
            dt.Columns.Add("nomcuenta3")
            dt.Columns.Add("nomcuenta4")
            dt.Columns.Add("origen")
            dt.Columns.Add("poliza")
            dt.Columns.Add("fecha")
            dt.Columns.Add("importe")
            dt.Columns.Add("cargo")
            dt.Columns.Add("abono")

            ''elemntos del tatset -------------------------------------

            For Each item As CN.PolizaDetalleClass In detalles

                cuentac = item.CuentaContable
                padre = cuentac.NombreCuenta

                If (cuentac.Nivel = 1) Then
                    padre = cuentac.NombreCuenta
                End If

                If (cuentac.Nivel = 2) Then
                    padre1 = cuentac.NombreCuenta
                    padre = cuentac.CuentaPadre.NombreCuenta
                End If

                If (cuentac.Nivel = 3) Then
                    padre2 = cuentac.NombreCuenta
                    padre1 = cuentac.CuentaPadre.NombreCuenta
                    padre = cuentac.CuentaPadre.CuentaPadre.NombreCuenta
                End If

                If (cuentac.Nivel = 4) Then
                    padre3 = cuentac.NombreCuenta
                    padre2 = cuentac.CuentaPadre.NombreCuenta
                    padre1 = cuentac.CuentaPadre.CuentaPadre.NombreCuenta
                    padre1 = cuentac.CuentaPadre.CuentaPadre.CuentaPadre.NombreCuenta
                End If

                dt.Rows.Add(item.Cta, item.SCta, item.SSCta, item.SSSCta, padre, padre1, padre2, padre3, Poliza.Origen, Poliza.NumeroPoliza, Poliza.FechaPoliza, item.Importe, item.Cargo, item.Abono)
            Next

        Catch ex As Exception

        End Try
        Return ds
    End Function

    Private Function imprimir(Poliza As ClasesNegocio.PolizaClass)
        Try

            ''obtener  datos de la poliza guardada
            Dim datos As New DataSet
            datos = obtenerdatasetPoliza(Poliza)

            ''------------------------------------

            'Dim datos As New DataSet
            'Dim query = "EXEC  rptcuentascontables 1"
            'Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
            '    Dim adapter As New SqlDataAdapter()
            '    adapter.SelectCommand = New SqlCommand(query, connection)
            '    adapter.Fill(datos)
            'End Using

            Dim Reporte As New Rptpolizapasivo
            Reporte.SetDataSource(datos.Tables(0))
            Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
            Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue("Modulo", "")

            Dim pre As New ClasesNegocio.PreVisualizarForm
            pre.Reporte = Reporte
            pre.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try

    End Function

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
        Try

            If Me.DgvFacturas.Rows.Count > 0 Then
                For j As Integer = 0 To DgvFacturas.Rows.Count - 1
                    If DgvFacturas.Rows(j).Cells(check.Index).Value = True Then
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
                            If DgvFacturas.Rows(i).Cells(check.Index).Value = True Then
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
                            End If
                            'With Me.DgvFacturas.Rows(i)
                            '    PolizaDet = New CN.PolizaDetalleClass
                            '    PolizaDet.IdCuentaContable = .Cells(Me.clmCodigo.Index).Value
                            '    If Not .Cells(Me.clmCargo.Index).Value = 0 Then
                            '        PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                            '        PolizaDet.Importe = .Cells(Me.clmCargo.Index).Value
                            '    Else
                            '        PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                            '        PolizaDet.Importe = .Cells(Me.clmAbono.Index).Value
                            '    End If
                            'End With
                            'PolizaDet.Posicion = i + 1
                            'Poliza.Detalles2.Add(PolizaDet)
                        Next
                    End If
                Next

                If Not Poliza.Guardar2(Trans) Then
                    Trans.Rollback()
                    MessageBox.Show("Ocurrió un error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ''---------------------------------------------------
                ''              IMPRESIONS DE LA POLIZA
                ''---------------------------------------------------

                imprimir(Poliza)

                ''---------------------------------------------------
                ''            fin   IMPRESIONS DE LA POLIZA
                ''---------------------------------------------------

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


                      
                    
                For i As Integer = 0 To Me.dgvGastos.Rows.Count - 1
                    If dgvGastos.Rows(i).Cells(chkb.Index).Value = True Then
                        If Me.dgvGastos.Rows(i).Cells(Me.Importe.Index).Value = 0 Then
                            Exit For
                        End If
                        Dim Gastos As New CN.GastosDepartamentosClass
                        Gastos.IdCuentaContable = Me.dgvGastos.Rows(i).Cells(Me.Cuenta.Index).Value
                        Gastos.IdSucursal = Me.dgvGastos.Rows(i).Cells(Me.IdSucursal.Index).Value
                        Gastos.IdMetodoProrrateo = Me.dgvGastos.Rows(i).Cells(Me.IdMetodo.Index).Value
                        Gastos.Importe = Me.dgvGastos.Rows(i).Cells(Me.Importe.Index).Value
                        Gastos.IdPoliza = Poliza.Codigo
                        Gastos.Porcentaje = Me.dgvGastos.Rows(i).Cells(Me.Ptj_Importe.Index).Value
                        Gastos.FechaPolizas = Me.dtpFechaConta.Value

                        If Not Gastos.Guardar(Trans) Then
                            Trans.Rollback()
                            Cancelar = True
                        End If
                    End If

                Next
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

    Private Sub mtb_ClickLimpiar(sender As System.Object, e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub DgvFacturas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFacturas.CellClick
        If DgvFacturas.CurrentRow.Cells(check.Index).Value = False Then

            DgvFacturas.CurrentRow.Cells(check.Index).Value = True

            If DgvFacturas.Rows.Count > 0 Then
                If DgvFacturas.Rows.Count > 1 Then
                    'Dim ID_ProductoDet As Integer
                    For Each Fila As DataGridViewRow In DgvFacturas.Rows

                        For i As Integer = 0 To dgvGastos.Rows.Count - 1
                            Try
                                If DgvFacturas.CurrentRow.Cells(NoFactura.Index).Value = DgvFacturas.Rows(i).Cells(NoFactura.Index).Value Then
                                    DgvFacturas.Rows(i).Cells(check.Index).Value = True
                                    Sumar()
                                    For j As Integer = 0 To dgvGastos.Rows.Count - 1
                                        If DgvFacturas.CurrentRow.Cells(NoFactura.Index).Value = dgvGastos.Rows(j).Cells(Factura.Index).Value And DgvFacturas.CurrentRow.Cells(IdProveedor.Index).Value = dgvGastos.Rows(j).Cells(IdProveedorFG.Index).Value Then
                                            dgvGastos.Rows(j).Cells(chkb.Index).Value = True
                                        End If
                                    Next
                                End If
                            Catch ex As Exception
                                Exit For
                                'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Next
                    Next

                End If
            End If

        Else

            DgvFacturas.CurrentRow.Cells(check.Index).Value = False
            If DgvFacturas.Rows.Count > 0 Then
                If DgvFacturas.Rows.Count > 1 Then
                    'Dim ID_ProductoDet As Integer
                    For Each Fila As DataGridViewRow In DgvFacturas.Rows
                        For i As Integer = 0 To dgvGastos.Rows.Count - 1
                            Try
                                If DgvFacturas.CurrentRow.Cells(NoFactura.Index).Value = DgvFacturas.Rows(i).Cells(NoFactura.Index).Value Then
                                    DgvFacturas.Rows(i).Cells(check.Index).Value = False
                                    Sumar()
                                    For j As Integer = 0 To dgvGastos.Rows.Count - 1
                                        If DgvFacturas.CurrentRow.Cells(NoFactura.Index).Value = dgvGastos.Rows(j).Cells(Factura.Index).Value Then
                                            dgvGastos.Rows(j).Cells(chkb.Index).Value = False
                                        End If
                                    Next
                                End If
                            Catch ex As Exception
                                Exit For

                            End Try
                        Next
                    Next

                End If
            End If

        End If



    End Sub





End Class