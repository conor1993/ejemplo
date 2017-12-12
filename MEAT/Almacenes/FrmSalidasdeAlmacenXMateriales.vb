Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports System.Data.SqlClient

Public Class FrmSalidasdeAlmacenXMateriales

    Dim mov As MovimientosAlmacenClass 'Movimiento
    Dim MovR As MovimientosAlmacenClass 'Movimiento para ponerlo de Referencia
    Dim AlmacenCol As New AlmacenCollectionClass
    Dim MovD As New MovAlmacenDetCollecionClass 'Detalle del movimiento
    'Dim MovAlmacenCab As MovimientosAlmacenClass
    Dim poliza As PolizaClass
    Dim borrar As Boolean = False
    Dim polizaR As PolizaClass 'Poliza para el movimiento referencia


    Private Sub FrmSalidasdeAlmacenXMateriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MiToolBar.miToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "101101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100001"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Me.cmbAlmacen.DataSource = AlmacenCol
            Me.cmbAlmacen.DisplayMember = "Descripcion"
            Me.cmbAlmacen.ValueMember = "Codigo"

            'Obtener Almacenes
            AlmacenCol.Obtener(CondicionEnum.ACTIVOS)

            'Obtener Productos
            Me.ProductosVistaC.Obtener(CondicionEnum.ACTIVOS)
            Me.Icon = Me.MdiParent.Icon
            Deshabilitar()
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

        Me.txtFolio.Clear()
        Me.dtpFecha.Value = Now
        Me.txtMovimiento.Clear()
        Me.cmbAlmacen.SelectedIndex = -1
        Me.cmbAlmacen.Text = "Seleccione un Almacén"
        Me.txtEntrega.Clear()
        Me.txtRecibe.Clear()
        Me.txtObservaciones.Clear()
        Me.txtImporteGuia.Text = "0.0"
        Me.txtImporteTotal.Text = "0.0"
        Me.dgvCuentas.Rows.Clear()
        Me.dgvProductos.Rows.Clear()
        borrar = False
        Me.lblEstatus.Visible = False
    End Sub

    Private Sub Habilitar()
        Me.cmbAlmacen.Enabled = True
        Me.txtEntrega.Enabled = True
        Me.txtRecibe.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.dgvCuentas.Enabled = True
        Me.dgvProductos.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.cmbAlmacen.Enabled = False
        Me.txtEntrega.Enabled = False
        Me.txtRecibe.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.dgvCuentas.Enabled = False
        Me.dgvProductos.Enabled = False
    End Sub

    Private Function Validar() As Boolean
        Try
            If IsNothing(Me.cmbAlmacen.SelectedValue) Then
                MsgBox("Seleccione un Almacén.", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            If Me.txtEntrega.Text = "" Then
                MsgBox("Capture un nombre de quien Entrega.", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            If Me.txtRecibe.Text = "" Then
                MsgBox("Capture un nombre de quien Recibe.", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    '    Public Function ExistenciaProducto(ByVal Cantidad As Decimal) As Boolean
    '        Try
    '            Dim InvAlm As New CC.InventarioAlmacenCollection
    '            Dim filtro As New OC.PredicateExpression
    '            'filtro.Add(HC.InventarioAlmacenFields.Año=)
    '            'invalm.GetScalar(Integralab.ORM.InventarioAlmacenFieldIndex.Cantidad,new OC.Expression(hc.InventarioAlmacenFields.Cantidad ),SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None,

    '        Catch ex As Exception
    '#If CONFIG = "Debug" Then
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '#Else
    '            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
    '#End If
    '        End Try
    '    End Function

    Private Sub ImporteGuia()
        Dim total As Decimal = 0
        For i As Integer = 0 To Me.dgvCuentas.Rows.Count - 1
            If Me.dgvCuentas.Rows(i).Cells("clmMov").Value = "A" Then
                total += Me.dgvCuentas.Rows(i).Cells("clmImporteCt").Value
            End If
        Next
        Me.txtImporteGuia.Text = total.ToString("C")
    End Sub

    Private Function ValidarImporteGuia() As Boolean
        Dim total As Decimal = 0
        For i As Integer = 0 To Me.dgvCuentas.Rows.Count - 1
            If Me.dgvCuentas.Rows(i).Cells("clmMov").Value = "C" Then
                total += Me.dgvCuentas.Rows(i).Cells("clmImporteCt").Value
            End If
        Next
        If total.ToString("C") <> Me.txtImporteGuia.Text Then
            MsgBox("Los Importes en la Guía Contable de los Movimientos Cargo y Abono no pueden ser diferentes.", MsgBoxStyle.Critical, "Error")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Total()
        Dim Total As Decimal = 0
        For i As Integer = 0 To Me.dgvProductos.Rows.Count - 1
            Total += Me.dgvProductos.Rows(i).Cells(Me.clmImporte.Index).Value
        Next
        Me.txtImporteTotal.Text = Total.ToString("C2")
    End Sub

    Private Sub RellenarGridCuentas(ByVal Cuenta As CuentaContableClass)
        Try
            If Not ExisteCuenta(Cuenta) Then
                If Cuenta.Afectable = Integra.Clases.SiNoEnum.SI Then
                    Me.dgvCuentas.Rows.Add(1)
                    Dim R As Integer = Me.dgvCuentas.Rows.Count - 2
                    Me.dgvCuentas.Rows(R).Cells(Me.clmCtaM.Index).Value = Cuenta.CuentaMayor
                    Me.dgvCuentas.Rows(R).Cells(Me.clmScta.Index).Value = Cuenta.SubCuenta
                    Me.dgvCuentas.Rows(R).Cells(Me.clmSsct.Index).Value = Cuenta.SSubCuenta
                    Me.dgvCuentas.Rows(R).Cells(Me.clmSssc.Index).Value = Cuenta.SSSubCuenta
                    Me.dgvCuentas.Rows(R).Cells(Me.clmCuentaContable.Index).Value = Cuenta.NombreCuenta

                Else
                    MsgBox("La Cuenta Seleccionada No es Afectable.", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("La Cuenta ya se encuentra en la Guía Contable", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Sub

    Private Function ExisteCuenta(ByVal cuenta As CuentaContableClass)
        Try
            For i As Integer = 0 To Me.dgvCuentas.Rows.Count - 1
                If Me.dgvCuentas.Rows(i).Cells("clmCtaM").Value = cuenta.CuentaMayor And Me.dgvCuentas.Rows(i).Cells("clmScta").Value = cuenta.SubCuenta And Me.dgvCuentas.Rows(i).Cells("clmSsct").Value = cuenta.SSubCuenta And Me.dgvCuentas.Rows(i).Cells("clmSssc").Value = cuenta.SSSubCuenta And Me.dgvCuentas.Rows(i).Cells("clmCuentaContable").Value = cuenta.NombreCuenta Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return True
        End Try
    End Function

    Private Sub PasarValores()

        Me.mov.AlmacenId = Me.cmbAlmacen.SelectedValue
        Me.mov.Entrega = Me.txtEntrega.Text
        Me.mov.Recibe = Me.txtRecibe.Text
        Me.mov.Observaciones = Me.txtObservaciones.Text
        Me.mov.Origen = "SALIDAS DE MATERIALES"
        Me.mov.EstatusContabilizado = 1
        Me.mov.CostoTotal = Me.txtImporteTotal.Text
        Me.mov.UsuarioId = Controlador.Sesion.Usrndx
        Me.mov.Estatus = Me.lblEstatus.Text

    End Sub

    Private Function GuardarDetProductos(ByVal tran As HC.Transaction) As Boolean
        Try
            For i As Integer = 0 To Me.dgvProductos.Rows.Count - 2
                Dim MovDet As New MovimientosAlmacenDetClass
                Dim productos As New Productos
                productos.Obtener(Me.dgvProductos.Rows(i).Cells("ClmProducto").Value)
                MovDet.AlmacenId = Me.cmbAlmacen.SelectedValue
                MovDet.Indice = i + 1
                MovDet.FolioMovimiento = Me.mov.FolioMovimiento
                MovDet.ProductoId = Me.dgvProductos.Rows(i).Cells("ClmProducto").Value
                MovDet.FechaMovimiento = Now
                MovDet.Cantidad = CInt(Me.dgvProductos.Rows(i).Cells("clmCantidad").Value)
                MovDet.Costo = Me.dgvProductos.Rows(i).Cells("clmCosto").Value
                MovDet.UnidadMed = productos.UnidadMedida.DescCorta

                'Actualizar existencia del producto en el almacen
                Dim InvCol As New CC.InventarioAlmacenCollection
                Dim Filtro As New OC.PredicateExpression
                'Se obtiene el ultimo movimiento del producto en el almacen 
                Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = Me.cmbAlmacen.SelectedValue And _
                          HC.InventarioAlmacenFields.ProductoId = Me.dgvProductos.Rows(i).Cells("clmProducto").Value)
                Dim Orden As New OC.SortExpression
                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                InvCol.GetMulti(Filtro, 1, Orden)

                If InvCol.Count = 1 Then
                    'Actualizando existencia
                    Dim AuxInvEntity As EC.InventarioAlmacenEntity = InvCol(0)
                    AuxInvEntity.CantidadExistencia = AuxInvEntity.CantidadExistencia - MovDet.Cantidad
                    tran.Add(AuxInvEntity)
                    If Not AuxInvEntity.Save Then
                        tran.Rollback()
                        Return False
                    Else
                        If Not MovDet.Guardar(tran) Then
                            tran.Rollback()
                            Return False
                        End If
                    End If
                End If

            Next
            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Function GenerarPoliza(ByVal trans As HC.Transaction) As Boolean
        Try
            'Dim poliza As New PolizaClass
            Dim Empresa As New EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
            poliza.Concepto = "SALIDAS DE ALMACÉN POR MATERIALES"
            poliza.Empresa = Empresa
            poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            poliza.FechaCaptura = Now
            poliza.FechaPoliza = Now
            poliza.Importe = Me.txtImporteGuia.Text
            poliza.Origen = ClasesNegocio.PolizaOrigenEnum.ALMACEN
            poliza.TipoCambio = 1
            poliza.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
            poliza.TipoError = ErroresPolizaEnum.NINGUNO
            For i As Integer = 0 To Me.dgvCuentas.Rows.Count - 1
                Dim polizadet As New PolizaDetalleClass
                Dim Cta As New CuentaContableCollectionClass
                Cta.Obtener(, , Me.dgvCuentas.Rows(i).Cells(Me.clmCtaM.Index).Value, _
                                    Me.dgvCuentas.Rows(i).Cells(Me.clmScta.Index).Value, Me.dgvCuentas.Rows(i).Cells(Me.clmSsct.Index).Value, _
                                    Me.dgvCuentas.Rows(i).Cells(Me.clmSssc.Index).Value, , , , , , )
                If Cta.Count = 1 Then
                    polizadet.CuentaContable = Cta(0)
                    polizadet.Importe = Me.dgvCuentas.Rows(i).Cells("clmImporteCt").Value
                    polizadet.Operacion = IIf(Me.dgvCuentas.Rows(i).Cells("clmMov").Value = "A", PolizaOperacionEnum.ABONO, PolizaOperacionEnum.CARGO)
                    polizadet.Posicion = i + 1
                    poliza.AgregarDetalle(polizadet)
                End If
            Next
            If Not poliza.Guardar2(trans) Then
                trans.Rollback()
                Return False
            End If
            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Function GuardarMovimientoNuevo() As Boolean
        Try
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "TransaccionMovimiento")

            Me.mov.Estatus = EstatusEnum.ACTIVO
            'Generar Póliza
            If GenerarPoliza(Trans) Then
                'Guardar Folio
                Dim Almacen As New AlmacenClass(CInt(Me.cmbAlmacen.SelectedValue))
                Dim Folio As New FolioAlmacenClass
                Folio.LetraSerie = Almacen.Letras
                Folio.Mes = Now.ToString("MM")
                Folio.Año = Now.Year
                If Not Folio.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
                Me.mov.FolioMovimiento = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
                Me.mov.PolizaContabilidad = poliza.Codigo
                Me.mov.FechaContabilizacion = Now
                'Guardar Movimiento
                If Not mov.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                Else
                    'GuardarProducto
                    If GuardarDetProductos(Trans) Then
                        Trans.Commit()
                        Return True
                    End If
                End If
            Else
                Return False
            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Sub ObtenerDetalleProductos()
        Me.dgvProductos.Rows.Clear()
        If Not IsNothing(Me.mov.Detalle) Then
            Me.dgvProductos.Rows.Add(Me.mov.Detalle.Count)
            For i As Integer = 0 To Me.mov.Detalle.Count - 1
                Me.dgvProductos.Rows(i).Cells("Clmproducto").Value = mov.Detalle(i).ProductoId
                Me.dgvProductos.Rows(i).Cells("clmCantidad").Value = mov.Detalle(i).Cantidad.ToString("N2")
                Me.dgvProductos.Rows(i).Cells("clmUnidad").Value = mov.Detalle(i).UnidadMed
                Me.dgvProductos.Rows(i).Cells("clmCosto").Value = mov.Detalle(i).Costo
                Me.dgvProductos.Rows(i).Cells("clmImporte").Value = (mov.Detalle(i).Cantidad * mov.Detalle(i).Costo).ToString("C")
            Next
        End If

    End Sub

    Private Sub ObtenerDetalleCuentas()
        Me.dgvCuentas.Rows.Clear()
        If Not IsNothing(mov.Poliza) Then
            Me.dgvCuentas.Rows.Add(Me.mov.Poliza.Detalles.Count)
            For i As Integer = 0 To Me.mov.Poliza.Detalles.Count - 1
                Me.dgvCuentas.Rows(i).Cells("clmCtaM").Value = Me.mov.Poliza.Detalles(i).Cta
                Me.dgvCuentas.Rows(i).Cells("clmScta").Value = Me.mov.Poliza.Detalles(i).SCta
                Me.dgvCuentas.Rows(i).Cells("clmSsct").Value = Me.mov.Poliza.Detalles(i).SSCta
                Me.dgvCuentas.Rows(i).Cells("clmSssc").Value = Me.mov.Poliza.Detalles(i).SSSCta
                Me.dgvCuentas.Rows(i).Cells("clmCuentaContable").Value = Me.mov.Poliza.Detalles(i).NombreCta
                If mov.Poliza.Detalles(i).Operacion = PolizaOperacionEnum.ABONO Then
                    Me.dgvCuentas.Rows(i).Cells("clmMov").Value = "A"
                Else
                    Me.dgvCuentas.Rows(i).Cells("clmMov").Value = "C"
                End If
                Me.dgvCuentas.Rows(i).Cells("clmImporteCt").Value = Me.mov.Poliza.Detalles(i).Importe
            Next
        End If

    End Sub

    Private Sub ObtenerValores()
        Me.txtFolio.Text = Me.mov.FolioMovimiento
        Me.dtpFecha.Value = Me.mov.FechaMovimiento
        Me.txtMovimiento.Text = Me.mov.NombreTipoMovimiento
        Me.cmbAlmacen.SelectedValue = Me.mov.AlmacenId
        Me.txtEntrega.Text = Me.mov.Entrega
        Me.txtRecibe.Text = Me.mov.Recibe
        Me.txtObservaciones.Text = Me.mov.Observaciones
        Me.txtImporteTotal.Text = Me.mov.CostoTotal.ToString("C")
        ObtenerDetalleProductos()
        ObtenerDetalleCuentas()
    End Sub

    '    Private Function Guardar() As Boolean
    '        Try
    '            Dim tr As String
    '            tr = "insert into MInvMovimientosAlmacen (AlmacenId,FolioMovimiento,FechaMovimiento, TipoMovimientoId,CostoTotal,Origen,UsuarioId,EstatusContabilizado,Entrega,Recibe,Observaciones,Estatus) values(" & Me.cmbAlmacen.SelectedValue & ",'2008090010','" & Me.dtpFecha.Value.ToString("dd-MM-yyyy") & "',3,350,'Salidas de Almacen'," & Controlador.Sesion.Usrndx & ",0,'" & Me.txtEntrega.Text & "','" & Me.txtRecibe.Text & "','" & Me.txtObservaciones.Text & "',1)"
    '            Using cone As New SqlCommand(tr, New SqlConnection(HC.DbUtils.ActualConnectionString))
    '                cone.Connection.Open()
    '                If cone.ExecuteNonQuery > 0 Then
    '                    Return True
    '                End If
    '            End Using
    '            Return False
    '        Catch ex As Exception
    '#If CONFIG = "Debug" Then
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '#Else
    '            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
    '#End If
    '        End Try
    '    End Function

    'Inactivar un movimiento

    Public Function GuardarMovimientoReferencia() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "TransaccionMovimiento")
        Try
            Me.MovR = New MovimientosAlmacenClass
            Me.MovR.AlmacenId = Me.cmbAlmacen.SelectedValue
            Me.MovR.Entrega = Me.txtEntrega.Text
            Me.MovR.Recibe = Me.txtRecibe.Text
            Me.MovR.Observaciones = Me.txtObservaciones.Text
            Me.MovR.Origen = "SALIDAS DE MATERIALES"
            Me.MovR.EstatusContabilizado = 1
            Me.MovR.CostoTotal = Me.txtImporteTotal.Text
            Me.MovR.UsuarioId = Controlador.Sesion.Usrndx
            'Obtener el Tipo de Movimiento
            Dim confi As New CC.InventarioConfiguracionCollection
            Dim TMov As Integer
            'obtener el movimiento 
            TMov = IIf(DBNull.Value.Equals(confi.GetScalar(IntegraLab.ORM.InventarioConfiguracionFieldIndex.ExDevolucionConsumo, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None)), 0, confi.GetScalar(IntegraLab.ORM.InventarioConfiguracionFieldIndex.ExDevolucionConsumo, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None))
            If TMov = 0 Then
                MsgBox("No existe un Tipo de Movimiento para Entradas por Consumo, Modifique la Configuración.", MsgBoxStyle.Critical, "Error")
                Limpiar()
                Deshabilitar()
            Else
                'Obtener Tipo Movimiento
                Dim TMovc As New TipoMovimientoClass
                TMovc.Obtener(TMov)
                Me.MovR.TipoMovimientoId = TMovc.Codigo
                '--------------------------------------------------------------


                Me.MovR.Estatus = EstatusEnum.ACTIVO
                'Generar Póliza
                If GenerarPolizaMovRef(Trans) Then
                    'Guardar Folio
                    Dim Almacen As New AlmacenClass(CInt(Me.cmbAlmacen.SelectedValue))
                    Dim Folio As New FolioAlmacenClass
                    Folio.LetraSerie = Almacen.Letras
                    Folio.Mes = Now.ToString("MM")
                    Folio.Año = Now.Year
                    If Not Folio.Guardar(Trans) Then
                        Trans.Rollback()
                        Return False
                    End If
                    Me.MovR.FolioMovimiento = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
                    Me.MovR.PolizaContabilidad = polizaR.Codigo
                    Me.MovR.FechaContabilizacion = Now
                    'Guardar Movimiento
                    Me.mov.Referencia = Me.MovR.FolioMovimiento
                    Me.mov.Estatus = EstatusEnum.INACTIVO
                    If mov.Guardar(Trans) Then
                        If Not MovR.Guardar(Trans) Then
                            Trans.Rollback()
                            Return False
                        Else
                            'GuardarProducto
                            If GuardarDetProductosMovRef(Trans) Then
                                Trans.Commit()
                                Return True
                            End If
                        End If
                    End If
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Trans.Rollback()
        End Try

    End Function
    Private Function GuardarDetProductosMovRef(ByVal tran As HC.Transaction) As Boolean
        Try
            For i As Integer = 0 To Me.dgvProductos.Rows.Count - 2
                Dim MovDet As New MovimientosAlmacenDetClass
                Dim productos As New Productos
                productos.Obtener(Me.dgvProductos.Rows(i).Cells("ClmProducto").Value)
                MovDet.AlmacenId = Me.cmbAlmacen.SelectedValue
                MovDet.Indice = i + 1
                MovDet.FolioMovimiento = Me.MovR.FolioMovimiento
                MovDet.ProductoId = Me.dgvProductos.Rows(i).Cells("ClmProducto").Value
                MovDet.FechaMovimiento = Now
                MovDet.Cantidad = CInt(Me.dgvProductos.Rows(i).Cells("clmCantidad").Value)
                MovDet.Costo = Me.dgvProductos.Rows(i).Cells("clmCosto").Value
                MovDet.UnidadMed = productos.UnidadMedida.DescCorta

                'Actualizar existencia del producto en el almacen
                Dim InvCol As New CC.InventarioAlmacenCollection
                Dim Filtro As New OC.PredicateExpression
                'Se obtiene el ultimo movimiento del producto en el almacen 
                Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = Me.cmbAlmacen.SelectedValue And _
                          HC.InventarioAlmacenFields.ProductoId = Me.dgvProductos.Rows(i).Cells("clmProducto").Value)
                Dim Orden As New OC.SortExpression
                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                InvCol.GetMulti(Filtro, 1, Orden)

                If InvCol.Count = 1 Then
                    'Actualizando existencia
                    Dim AuxInvEntity As EC.InventarioAlmacenEntity = InvCol(0)
                    AuxInvEntity.CantidadExistencia = AuxInvEntity.CantidadExistencia + MovDet.Cantidad
                    tran.Add(AuxInvEntity)
                    If Not AuxInvEntity.Save Then
                        tran.Rollback()
                        Return False
                    Else
                        If Not MovDet.Guardar(tran) Then
                            tran.Rollback()
                            Return False
                        End If
                    End If
                End If

            Next
            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
    Private Function GenerarPolizaMovRef(ByVal trans As HC.Transaction) As Boolean
        Try
            polizaR = New PolizaClass
            Dim Empresa As New EmpresaClass(Controlador.Sesion.MiEmpresa.Empndx)
            polizaR.Concepto = "ENTRADAS DE ALMACÉN POR MATERIALES"
            polizaR.Empresa = Empresa
            polizaR.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
            polizaR.FechaCaptura = Now
            polizaR.FechaPoliza = Now
            polizaR.Importe = Me.txtImporteGuia.Text
            polizaR.Origen = ClasesNegocio.PolizaOrigenEnum.ALMACEN
            polizaR.TipoCambio = 1
            polizaR.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
            polizaR.TipoError = ErroresPolizaEnum.NINGUNO
            polizaR.Referencia = Me.mov.Poliza.Folio 'Agregarle la referencia del mov original
            For i As Integer = 0 To Me.dgvCuentas.Rows.Count - 1
                Dim polizadet As New PolizaDetalleClass
                Dim Cta As New CuentaContableCollectionClass
                Cta.Obtener(, , Me.dgvCuentas.Rows(i).Cells(Me.clmCtaM.Index).Value, _
                                    Me.dgvCuentas.Rows(i).Cells(Me.clmScta.Index).Value, Me.dgvCuentas.Rows(i).Cells(Me.clmSsct.Index).Value, _
                                    Me.dgvCuentas.Rows(i).Cells(Me.clmSssc.Index).Value, , , , , , )
                If Cta.Count = 1 Then
                    polizadet.CuentaContable = Cta(0)
                    polizadet.Importe = Me.dgvCuentas.Rows(i).Cells("clmImporteCt").Value
                    polizadet.Operacion = IIf(Me.dgvCuentas.Rows(i).Cells("clmMov").Value = "A", PolizaOperacionEnum.CARGO, PolizaOperacionEnum.ABONO)
                    polizadet.Posicion = i + 1
                    polizaR.AgregarDetalle(polizadet)
                End If
            Next
            If Not polizaR.Guardar2(trans) Then
                trans.Rollback()
                Return False
            End If
            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function


#End Region

#Region "Keys"

    Private Sub cmbAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAlmacen.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.AlmacenCol.Obtener(CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub cmbAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAlmacen.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.cmbAlmacen.SelectedValue) Then
                MsgBox("Seleccione un Almacén.", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.txtEntrega.Focus()
            End If
        End If
    End Sub

    Private Sub txtEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrega.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtEntrega.Text = "" Then
                MsgBox("Capture el nombre de quien entrega.", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.txtRecibe.Focus()
            End If
        End If
    End Sub

    Private Sub txtRecibe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecibe.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtRecibe.Text = "" Then
                MsgBox("Capture el nombre de quien recibe.", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.txtObservaciones.Focus()
            End If
        End If
    End Sub
#End Region

#Region "Mitoolbar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If Not IsNothing(Me.mov) Then
                'Si el movimiento no está inactivo
                If Me.mov.Estatus = EstatusEnum.INACTIVO Then
                    Dim msj As String
                    If Me.mov.Referencia <> "" Then
                        msj = String.Format("El Movimiento ya fue Inactivado con el siguiente movimiento de Referencia={0}", Me.mov.Referencia)
                    Else
                        msj = "El Movimiento ya fue Inactivado"
                    End If
                    MsgBox(msj, MsgBoxStyle.Information, "Aviso")
                Else
                    'Confirmar Inactivar el movimiento
                    If MsgBox("¿Realmente desea Inactivar el Movimiento?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                        'Crear nuevo movimiento
                        If GuardarMovimientoReferencia() Then
                            MsgBox(String.Format("El Movimiento ha sido Inactivado con el Movimiento contrario con Folio #: {0}", Me.MovR.FolioMovimiento), MsgBoxStyle.Information, "Aviso")
                            Dim previo As New PreVisualizarForm
                            previo.Reporte = Me.MovR.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                            previo.ShowDialog()
                        Else
                            MsgBox("El Movimiento no pudo Inactivarse.", MsgBoxStyle.Critical, "Error")
                            Cancelar = True
                        End If
                    End If

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

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Dim ventana As New BusquedaSalidaDeAlmacenXMaterialesFrm
        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.mov = ventana.MovAlm
            ObtenerValores()
            ImporteGuia()
            Me.lblEstatus.Text = Me.mov.Estatus.ToString
            Me.lblEstatus.Visible = True
        End If
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try

            If Validar() Then
                If ValidarImporteGuia() Then
                    PasarValores()
                    If GuardarMovimientoNuevo() Then
                        Dim msj As String
                        msj = String.Format("La Salida de Almacén por Materiales ha sido Guardada Satisfactoriamente con el Folio: {0}. Se ha generado la póliza No.{1}", Me.mov.FolioMovimiento, Me.poliza.NumeroPoliza)
                        MsgBox(msj, MsgBoxStyle.Information, "Aviso")
                        Dim previo As New PreVisualizarForm
                        previo.Reporte = Me.mov.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                        previo.ShowDialog()
                        Limpiar()
                        Deshabilitar()
                    Else
                        MsgBox("La Salida de Almacén por Materiales No Pudo ser Guardada", MsgBoxStyle.Critical, "Error")
                        'Cancelar = True
                        Limpiar()
                        Deshabilitar()
                    End If
                Else
                    Cancelar = True
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error al intentar Guardar.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.mov = New MovimientosAlmacenClass
        Me.poliza = New PolizaClass
        Limpiar()
        Habilitar()
        Dim confi As New CC.InventarioConfiguracionCollection
        Dim TMov As Integer
        'obtener el movimiento 
        TMov = IIf(DBNull.Value.Equals(confi.GetScalar(IntegraLab.ORM.InventarioConfiguracionFieldIndex.SxConsumo, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None)), 0, confi.GetScalar(IntegraLab.ORM.InventarioConfiguracionFieldIndex.SxConsumo, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None))
        If TMov = 0 Then
            MsgBox("No existe un Tipo de Movimiento para Salidas por Consumo, Modifique la Configuración.", MsgBoxStyle.Critical, "Error")
        Else
            'Obtener Tipo Movimiento
            Dim TMovc As New TipoMovimientoClass
            TMovc.Obtener(TMov)
            Me.txtMovimiento.Text = TMovc.Nombre
            Me.mov.TipoMovimientoId = TMovc.Codigo
        End If
        Me.cmbAlmacen.Focus()
        Me.txtEntrega.Text = Controlador.Sesion.MiUsuario.Usrnomcom
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

    Private Sub dgvProductos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellEndEdit
        If e.RowIndex > -1 Then
            If e.ColumnIndex = Me.Clmproducto.Index Then
                If Not IsNothing(Me.dgvProductos.Rows(e.RowIndex).Cells("clmProducto").Value) Then
                    Dim UnidMed As New CC.UnidadMedidaCollection 'Para obtener la descripcion de la unidad del producto
                    Dim filtro As New OC.PredicateExpression
                    Dim unid As String
                    Dim rel As New OC.RelationCollection
                    rel.Add(EC.ProductoEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida)
                    filtro.Add(HC.ProductoFields.Codigo = Me.dgvProductos.Rows(e.RowIndex).Cells("clmProducto").Value)
                    unid = TryCast(UnidMed.GetScalar(IntegraLab.ORM.UnidadMedidaFieldIndex.Descripcion, New OC.Expression(HC.UnidadMedidaFields.Descripcion), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, filtro, rel, Nothing), String)
                    Me.dgvProductos.Rows(e.RowIndex).Cells("clmUnidad").Value = unid
                    'Obteniendo el precio del producto
                    Dim Alm As New CC.InventarioAlmacenCollection
                    Dim precio As Decimal
                    Dim filtro1 As New OC.PredicateExpression
                    filtro1.Add(HC.InventarioAlmacenFields.AlmacenId = Me.cmbAlmacen.SelectedValue And HC.InventarioAlmacenFields.ProductoId = CInt(Me.dgvProductos.Rows(e.RowIndex).Cells("clmProducto").Value) And _
                    HC.InventarioAlmacenFields.Año = Now.Year And HC.InventarioAlmacenFields.Mes = Now.Month.ToString("00"))
                    precio = Alm.GetScalar(IntegraLab.ORM.InventarioAlmacenFieldIndex.CostoPromedio, New OC.Expression(HC.InventarioAlmacenFields.CostoPromedio), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, filtro1, Nothing)
                    Me.dgvProductos.Rows(e.RowIndex).Cells("clmCosto").Value = precio

                End If
            ElseIf e.ColumnIndex = Me.clmCantidad.Index Then
                Me.dgvProductos.Rows(e.RowIndex).Cells("clmImporte").Value = Me.dgvProductos.Rows(e.RowIndex).Cells("clmCantidad").Value * Me.dgvProductos.Rows(e.RowIndex).Cells("clmCosto").Value
            End If

            '----------------------------------------------------------------------------------------------------
            Me.dgvProductos.Refresh()
            If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Then
                Dim Importe As Integer = 0
                For i As Integer = 0 To Me.dgvProductos.Rows.Count - 2
                    Importe += Me.dgvProductos.Rows(i).Cells("clmImporte").Value
                Next
                Me.txtImporteTotal.Text = Importe.ToString("C2")
            End If

            Select Case e.ColumnIndex
                Case Me.clmCantidad.Index

                    If Me.dgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value > 0 Then

                        Dim InvCol As New CC.InventarioAlmacenCollection
                        Dim Filtro As New OC.PredicateExpression
                        'Se obtiene el ultimo movimiento del producto en el almacen 
                        Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = Me.cmbAlmacen.SelectedValue And _
                                  HC.InventarioAlmacenFields.ProductoId = Me.dgvProductos.CurrentRow.Cells("clmProducto").Value)
                        Dim Orden As New OC.SortExpression
                        Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                        Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                        InvCol.GetMulti(Filtro, 1, Orden)

                        Dim AuxInvEntity As EC.InventarioAlmacenEntity
                        If InvCol.Count > 0 Then
                            AuxInvEntity = InvCol(0)
                            Dim Exist As Decimal = AuxInvEntity.CantidadExistencia
                            If Me.dgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value > Exist Then
                                MessageBox.Show("No hay existencia del Producto con esa Cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Me.dgvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                                Me.dgvProductos.Rows(e.RowIndex).Cells("clmImporte").Value = 0.ToString("C")
                            End If
                        Else
                            MessageBox.Show("No se encontró el producto en el Almacén", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Me.dgvProductos.Rows(e.RowIndex).Cells("clmUnidad").Value = ""
                            Me.dgvProductos.Rows(e.RowIndex).Cells("clmCosto").Value = 0
                            Me.dgvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Sub dgvCuentas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellEndEdit
        If e.ColumnIndex > -1 Then
            Select Case (e.ColumnIndex)
                Case Me.clmSssc.Index
                    'Buscar cuenta
                    Dim cuentas As New CuentaContableCollectionClass
                    cuentas.Obtener(, , Me.dgvCuentas.Rows(e.RowIndex).Cells(Me.clmCtaM.Index).Value, _
                    Me.dgvCuentas.Rows(e.RowIndex).Cells(Me.clmScta.Index).Value, Me.dgvCuentas.Rows(e.RowIndex).Cells(Me.clmSsct.Index).Value, _
                    Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, , , , , , )
                    If cuentas.Count = 1 Then
                        If ExisteCuenta(cuentas(0)) Then
                            MsgBox("La Cuenta ya se encuentra en la Guía Contable.", MsgBoxStyle.Exclamation, "Aviso")
                        Else
                            Me.dgvCuentas.Rows(e.RowIndex).Cells("clmCuentaContable").Value = cuentas(0).NombreCuenta
                        End If
                    End If
                Case Me.clmSsct.Index
                    'Buscar Cuenta
                    Dim cuentas As New CuentaContableCollectionClass
                    cuentas.Obtener(, , Me.dgvCuentas.Rows(e.RowIndex).Cells(Me.clmCtaM.Index).Value, _
                    Me.dgvCuentas.Rows(e.RowIndex).Cells(Me.clmScta.Index).Value, Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, _
                    , , , , , , )
                    If cuentas.Count = 1 Then
                        If ExisteCuenta(cuentas(0)) Then
                            MsgBox("La Cuenta ya se encuentra en la Guía Contable.", MsgBoxStyle.Exclamation, "Aviso")
                        Else
                            Me.dgvCuentas.Rows(e.RowIndex).Cells("clmCuentaContable").Value = cuentas(0).NombreCuenta
                            Me.dgvCuentas.Rows(e.RowIndex).Cells(Me.clmSssc.Index).Value = cuentas(0).SSSubCuenta
                        End If
                    End If
                Case Me.clmMov.Index
                    'Validar qe escriban bien el Movimiento
                    If Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "a" Then
                        Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "A"
                    ElseIf Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "c" Then
                        Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "C"
                    End If
                    If Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "A" And Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "C" Then
                        MsgBox("El movimiento no es válido, describa A si es Abono ó C si se trata de un Cargo", MsgBoxStyle.Critical, "Error")
                        Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ""
                    End If

                Case Me.clmImporteCt.Index
                    'Validar que escriban datos numericos en el importe
                    If Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "" Then
                        Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                    ElseIf Not IsNumeric(Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                        MsgBox("Capture un importe Válido.", MsgBoxStyle.Critical, "Error")
                        Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                    Else
                        Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDec(Me.dgvCuentas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value).ToString("C")
                        ImporteGuia()
                    End If
            End Select
        End If
    End Sub

    Private Sub dgvCuentas_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvCuentas.PreviewKeyDown

        If e.KeyCode = Keys.F3 Then
            Dim VtaBuscaCta As New BusquedaCuentasContablesForm

            VtaBuscaCta.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
            VtaBuscaCta.InactivaDefault(True) = ClasesNegocio.CondicionAsignadaEnum.NO

            If VtaBuscaCta.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim DetalleNvo As New PolizaDetalleClass

                DetalleNvo.Cta = VtaBuscaCta.CuentaContable.CuentaMayor
                DetalleNvo.SCta = VtaBuscaCta.CuentaContable.SubCuenta
                DetalleNvo.SSCta = VtaBuscaCta.CuentaContable.SSubCuenta
                DetalleNvo.SSSCta = VtaBuscaCta.CuentaContable.SSSubCuenta
                poliza.Detalles2.Add(DetalleNvo)



                RellenarGridCuentas(VtaBuscaCta.CuentaContable)
                'VtaBuscaCta.Close()

            End If
        End If

    End Sub

    Private Sub dgvCuentas_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvCuentas.UserDeletedRow
        Me.ImporteGuia()
    End Sub
End Class