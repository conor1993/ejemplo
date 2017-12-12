Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class frmPolizaFacturaRecibaaMuerte
    Dim CodigoPoliza As Long
    Private Sub frmPolizaFacturaRecibaaMuerte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101001111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.MEAToolBar1.ToolBarButtonStatus = MtbEstados
            Me.MEAToolBar1.sbCambiarEstadoBotones("imprimir")
            VerificarCuentas()
            Me.dtbFechaContable.Value = Now

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub VerificarCuentas()
        Try
            Dim FitlroConCfgCtas As New OC.PredicateExpression

            'HC.CfgCtrlCtasFields.Folio = "018" Or HC.CfgCtrlCtasFields.Folio = "019"
            CuentaControl.GetMulti(FitlroConCfgCtas)

            Me.dgvCuentasControl.AutoGenerateColumns = False
            Me.dgvCuentasControl.DataSource = Me.CuentaControl
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function GenerarPoliza(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If Me.dgvCuentasControl.Rows(0).Cells(Me.clmCargo.Index).Value = 0 Then
                MessageBox.Show("No se han realizado los cargos correspondientes, realizarlos para hacer la poliza", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Function
            End If
            If Me.dgvCuentasControl.Rows(0).Cells(Me.clmCargo.Index).Value = 0 Then
                MessageBox.Show("No se han realizado los cargos correspondientes, realizarlos para hacer la poliza", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Function
            End If

            Dim FacturasdeVenta As New FacturasCollectionClass

            Dim Empresa As New EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
            Dim Poliza As New PolizaClass
            Poliza.Concepto = "Facturación de Venta en Corral"
            Poliza.Empresa = Empresa
            Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            Poliza.FechaCaptura = Now
            Poliza.FechaPoliza = Me.dtbFechaContable.Value
            Poliza.Importe = 0
            Poliza.Origen = ClasesNegocio.PolizaOrigenEnum.CONTABILIDAD
            Poliza.TipoCambio = 0
            Poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
            Poliza.TipoError = 0
            For i As Integer = 0 To Me.dgvCuentasControl.Rows.Count - 1
                Dim polizaDet As New PolizaDetalleClass
                Dim CuenCont As New CuentaContableCollectionClass
                CuenCont.Obtener(, , Me.dgvCuentasControl.Rows(i).Cells("Cuenta").Value, Me.dgvCuentasControl.Rows(i).Cells("SubCuenta").Value, Me.dgvCuentasControl.Rows(i).Cells("SsubCuenta").Value, Me.dgvCuentasControl.Rows(i).Cells("SssubCuenta").Value)
                polizaDet.CuentaContable = CuenCont(0)
                If Me.dgvCuentasControl.Rows(i).Cells("ClmCargo").Value > 0 Then
                    polizaDet.Importe = Me.dgvCuentasControl.Rows(i).Cells("ClmCargo").Value
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.CARGO
                Else
                    polizaDet.Importe = Me.dgvCuentasControl.Rows(i).Cells("ClmAbono").Value
                    polizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO
                End If
                polizaDet.Posicion = i
                Poliza.AgregarDetalle(polizaDet)
            Next
            'guardar poliza

            If Poliza.Guardar(Trans) Then
                CodigoPoliza = Poliza.Codigo
                MessageBox.Show("Poliza :" & Poliza.NumeroPoliza & " se genero con exito", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Trans.Commit()
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Function ImportesPolizas() As Boolean
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Fac As New CC.CabFacturasCollection
            Filtro.Add(HC.CabFacturasFields.FecConta = Me.dtbFechaContable.Value)
            Filtro.Add(HC.CabFacturasFields.TipoFactu = TipoFacturaEnum.FACTURACION_DE_MUERTE_EN_RECIBA)
            Fac.GetMulti(Filtro, 0, Nothing)
            If Fac.Items.Count > 0 Then
                For i As Integer = 0 To Fac.Items.Count - 1
                    Dim Subtotal As Decimal
                    Subtotal = Fac.Items(i).SubTotal
                    Me.dgvCuentasControl.Rows(0).Cells("clmCargo").Value = Me.dgvCuentasControl.Rows(0).Cells("clmCargo").Value + Subtotal
                    Me.dgvCuentasControl.Rows(1).Cells("clmAbono").Value = Me.dgvCuentasControl.Rows(1).Cells("clmAbono").Value + Subtotal
                Next
            Else
                MessageBox.Show("Genere el auxiliar contable para la fecha: " & Me.dtbFechaContable.Value.ToShortDateString.ToString, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If
            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function MarcarFacturas(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Dim Total As Decimal
            Total = 0
            For Each FacturasdeVentaCabecero As FacturasClass In Controlador.ObtenerFacturasdeVentasParaAuxiliarContable(Me.dtbFechaContable.Value.AddDays(1), TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA)
                FacturasdeVentaCabecero.FolPoliza = CodigoPoliza
                FacturasdeVentaCabecero.StaFacturacion = "S"
                Controlador.ContabilizarFacturas(FacturasdeVentaCabecero, FacturasdeVentaCabecero.NoFactura, Trans)
            Next

            Me.MEAToolBar1.sbCambiarEstadoBotones("imprimir")
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Facturas")
        If ImportesPolizas() Then
            If GenerarPoliza(Trans) Then
                If MarcarFacturas(Trans) Then
                    Trans.Commit()
                    Imprimir()
                Else
                    MessageBox.Show("", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Me.MEAToolBar1.sbCambiarEstadoBotones("imprimir")
        End If
    End Sub


    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub
    Private Function Imprimir() As Boolean
        If Me.Validate() Then
            PolizaCollectionClass.ImprimirPolizaFacturasdeVentas(Controlador.Sesion, TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA, New OC.FieldBetweenPredicate(HC.PolizaFields.FechaPoliza, dtbFechaContable.Value, dtbFechaContable.Value.AddDays(1)) And HC.PolizaFields.Estatus = 1 And HC.PolizaFields.Codigo = CodigoPoliza)
        End If
    End Function
End Class