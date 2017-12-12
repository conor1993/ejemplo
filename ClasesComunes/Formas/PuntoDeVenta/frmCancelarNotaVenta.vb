Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports System.Drawing.Printing
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports Integralab.ORMSeguridad
Imports Integralab.FormasSeguridad

Public Class frmCancelarNotaVenta
    Dim BoolN As Boolean = False
    Dim BoolB As Boolean = True
    Dim Notas As New CN.NotaVentaCollectionClass
    Dim InvMovAlmacenCab As New CN.AlmacenGeneral.MovimientoAlmacenPVClass
    Dim InvMovAlmacenDet As New CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass
    Dim _FolioAlm As String
    Dim TransMovAlm As HC.Transaction
    Dim Trans As HC.Transaction
    Dim Almacen As ClasesNegocio.AlmacenClass
    Dim Total As Decimal = 0
    Dim Nota As New CN.NotaVentaClass
    Private Sub frmCancelarNotaVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        'Me.ActiveControl = Me


        MtbEstados.StateBuscar = "110001011"
        MtbEstados.StateLimpiar = "110000001"
        MtbEstados.StateCancelar = ""
        MtbEstados.StateNuevo = ""
        MtbEstados.StateGuardar = ""
        MtbEstados.StateBorrar = ""
        MtbEstados.StateEditar = ""
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        mtb.ToolBarButtonStatus = MtbEstados

        mtb.sbCambiarEstadoBotones("Limpiar")

        txtFolio.Focus()
    End Sub



#Region "Interfaz"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar

        If txtFolio.Text.Trim().Equals("") Then
            MessageBox.Show("Campo de folio vacio.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cancelar = True
            Return
        End If


        Me.Cursor = Cursors.WaitCursor



        Dim filtro As New OC.PredicateExpression

        If txtFolio.Text.Trim <> "" Then filtro.Add(HC.NotaVentaFields.Codigo = CInt(txtFolio.Text.Trim))

        'If chkFiltroFecha.Checked Then 
        ' filtro.Add(New FieldBetweenPredicate(HC.NotaVentaFields.Codigo, CInt(txtFolio.Text.Trim())))
        filtro.Add(HC.NotaVentaFields.Codigo = CInt(txtFolio.Text.Trim()))
        'filtro.Add(HC.NotaVentaFields.FechaVenta >= dtpDe  sde.Value.Date)
        'filtro.Add(HC.NotaVentaFields.FechaVenta <= dtpHasta.Value.Date)
        Notas = New CN.NotaVentaCollectionClass
        Notas.Obtener(filtro)

        'Dim notasResp As New CN.NotaVentaRespCollectionClass
        'filtro = New OC.PredicateExpression
        'If txtFolio.Text.Trim <> "" Then filtro.Add(HC.NotaVentaRespFields.Codigo = CInt(txtFolio.Text.Trim))

        'If chkFiltroFecha.Checked Then filtro.Add(New FieldBetweenPredicate(HC.NotaVentaRespFields.FechaVenta, dtpDesde.Value.ToString("yyyy-MM-dd 00:00:00"), dtpHasta.Value.ToString("yyyy-MM-dd 23:59:59")))
        'notasResp.Obtener(filtro)
        Dim cont As Integer = 0
        Dim Totalkit As Integer = 0
        Dim contKits As Integer = 1
        Dim SumKit As Decimal = 0
        If Notas.Count > 0 Then
            Timer1.Start()
            Nota = Notas(0)


            If Notas(0).Estatus = ClasesNegocio.CondicionEnum.ACTIVOS Then
                lblEstatus.Text = "VIGENTE"
            Else
                lblEstatus.Text = "CANCELADA"
            End If

            For Each det As CN.NotaVentaDetalleClass In Notas(0).Detalles
                ' dgvNotas.Rows.Add(det.Codigo, det.Total, det.FechaVenta, "NO")
                If det.IdProductoCompuesto <> 0 Then
                    cont += 1

                    Dim kitdet As New CN.DetalleKitCollectionClass
                    Dim prod As New CN.ProductoGeneralClass(det.IdProductoCompuesto)
                    kitdet.Obtener(det.IdProductoCompuesto)

                    If cont = 1 Then
                        Totalkit = kitdet.Count
                    End If
                    If cont >= Totalkit Then
                        cont = 0
                        SumKit = SumKit + det.Importe
                        'contKits += 1
                        Total += SumKit
                        dgvDetalle.Rows.Add(prod.Codigo, prod.Descripcion, 1, SumKit, SumKit)
                        SumKit = 0
                        ''dgvDetalle.Rows.Add(prod.Descripcion, 1, prod.Precio(1).PrecioVentaC, prod.Precio(1).PrecioVentaC)
                    Else
                        SumKit = SumKit + det.Importe
                    End If
                Else
                    Total += (det.Precio * det.Cantidad)
                    dgvDetalle.Rows.Add(det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Cantidad * det.Precio)
                End If
            Next
            'For Each det As CN.NotaVentaRespClass In notasResp
            '    dgvNotas.Rows.Add(det.Codigo, det.Total, det.FechaVenta, "SI")
            'Next
            'mtb.sbCambiarEstadoBotones("Buscar")
        Else
            Timer1.Stop()
            Cancelar = True
            dgvDetalle.Rows.Clear()
            MessageBox.Show("No se encontraron resultados.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Me.Cursor = Cursors.Default
        ''dgvNotas.DataSource = Notas
        ''LlenarGrid()

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        dgvDetalle.Rows.Clear()
        txtFolio.Text = ""
        lblEstatus.Text = "ESTATUS"
        txtFolio.Focus()
        Total = 0
        Timer1.Stop()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar

        If Notas(0).Estatus = ClasesNegocio.CondicionEnum.ACTIVOS Then
            Dim resultado As DialogResult = MessageBox.Show("¿Seguro que quieres cancelar la nota de venta?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If resultado = Windows.Forms.DialogResult.Yes Then
                ''Autorizacion si es usuario comun
                Dim permiso As New EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, Controlador.Sesion.MiUsuario.Usrndx)
                If Not IsDBNull(permiso.Usrtipo) Then
                    If permiso.Usrtipo.Equals("A") Then
                        cancelarNota()
                    Else
                        'Dim frmlogin As New LoginForm()
                        Dim validar As New ValidateForm()
                        If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                            permiso = New EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, validar.Usuario.Usrndx)
                            'Grupo = New ECS.CollectionClasses.DetallegruposCollection()
                            'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = validar.Usuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
                            'gpo = 0
                            'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
                            '    gpo = elem.Gpondx
                            'Next
                            If Not IsDBNull(permiso.Usrtipo) Then
                                If permiso.Usrtipo.Equals("A") Then
                                    cancelarNota()
                                Else
                                    MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                                End If
                            Else
                                MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                            End If

                        Else
                            Exit Sub
                        End If
                    End If
                Else
                    Dim validar As New ValidateForm()
                    If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                        permiso = New EntityClasses.DetalleempresasEntity(validar.Usuario.Usrndx, Controlador.Empresa.CodEmpndx)
                        'Grupo = New ECS.CollectionClasses.DetallegruposCollection()
                        'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = validar.Usuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
                        'gpo = 0
                        'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
                        '    gpo = elem.Gpondx
                        'Next
                        If Not IsDBNull(permiso.Usrtipo) Then
                            If permiso.Usrtipo.Equals("A") Then
                                '' Cortez()
                                cancelarNota()
                            Else
                                MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                            End If
                        Else
                            MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                        End If
                    Else
                        Exit Sub
                    End If
                End If
            Else
                Cancelar = True
            End If
        Else
            Cancelar = True
            MessageBox.Show("La nota de venta ya esta cancelada.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

    Public Sub cancelarNota()
        Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelar Nota")
        ''Genera Mov de Almacen por cancelacion de compra
        Dim Sucursal As New ClasesNegocio.SucursalClass
        Sucursal.Obtener(Utilerias.ObtenerControlTurnoActual.CodSucursal)
        'obtiene la letra serie del almacen seleccionado
        Almacen = New ClasesNegocio.AlmacenClass
        Almacen.Obtener(Sucursal.IdAlmacen)
        'genera el folio de movimiento de almacen en la clase
        Dim FolioAlmacen As New CN.FolioAlmacenClass
        FolioAlmacen.LetraSerie = Almacen.Letras
        FolioAlmacen.Año = Now.Year
        FolioAlmacen.Mes = Now.ToString("MM")

        If Not FolioAlmacen.Guardar(Trans) Then
            Trans.Rollback()
            'Cancelar = True
            'Exit Function
            Exit Sub
        End If

        'asigna el folio de movimiento de almacen
        _FolioAlm = CN.AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, Trans)

        ''GUARDA EL DETALLE
        MovAlmacenDetalle()
        Notas(0).IdControlTurnoCanc = Utilerias.ObtenerControlTurnoActual.Id
        ''Cambia el estatus a cancelada de la nota de venta
        If Notas(0).Borrar(Trans) Then
            TransMovAlm.Commit()
            Trans.Commit()
            MessageBox.Show("La nota de venta con el folio " & Notas(0).Codigo.ToString() & " se ha cancelado correctamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mtb_ClickLimpiar(New Object, Nothing, False)
        Else
            Trans.Rollback()
            TransMovAlm.Rollback()
            MessageBox.Show("Problema al cancelar la nota de venta.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Function GuardarMovAlmacenCab(ByVal TipoMov As Integer) As Boolean
        'Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            'Dim ConfigAlm As New CC.InventarioConfiguracionCollection
            'ConfigAlm.GetMulti(Nothing, 0, Nothing)

            'If ConfigAlm.Count < 1 Then
            '    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
            Dim Sucursal As New CN.SucursalClass
            Sucursal.Obtener(Utilerias.ObtenerCodSucursal)

            Me.InvMovAlmacenCab = New CN.AlmacenGeneral.MovimientoAlmacenPVClass



            Me.InvMovAlmacenCab.IdAlmacen = Sucursal.IdAlmacen
            Me.InvMovAlmacenCab.FolioMovimientoAlmacen = _FolioAlm
            Me.InvMovAlmacenCab.FechaMovimiento = Now

            'If Modo = 1 Then
            '    If IsDBNull(ConfigAlm(0).ExCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
            'ElseIf Modo = 2 Then
            '    If IsDBNull(ConfigAlm(0).SxDevolucionCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
            'End If
            ' Me.InvMovAlmacenCab.ValorMovimientoId = ""

            Me.InvMovAlmacenCab.IdTipoMovimiento = TipoMov ''ENTRADA POR COMPRA
            Me.InvMovAlmacenCab.CostoTotal = Total
            Me.InvMovAlmacenCab.Origen = "CANCELACION VTA"
            Me.InvMovAlmacenCab.Referencia = Nota.Codigo
            Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.InvMovAlmacenCab.EstatusContabilizado = 0

            Return True
            ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
            'Me.InvMovAlmacenCab.PolizaContabilidad = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



    Public Sub MovAlmacenDetalle()
        'With dgvDetalle
        '    Dim prod As New ProductoClass(CInt(.Rows(i).Cells("clmCodProducto").Value))
        '    If prod.EsKit Then
        '        Dim Detkit As New ClasesNegocio.DetalleKitCollectionClass
        '        Detkit.Obtener(HC.DetalleKitPvFields.IdKit = prod.Codigo)
        '        For Each row As CN.DetalleKitClass In Detkit
        '            j += 1
        '            Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
        '            Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
        '            Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
        '            Me.InvMovAlmacenDet.IdProducto = row.IdProd
        '            Me.InvMovAlmacenDet.Cantidad = row.Cantidad
        '            Dim listpre As New CN.ListaPrecioDetalleClass(1, row.IdProd)
        '            Me.InvMovAlmacenDet.Costo = listpre.PrecioVentaC
        '            Me.InvMovAlmacenDet.Descuento = listpre.Descuento
        '            Me.InvMovAlmacenDet.Indice = j
        '            Me.InvMovAlmacenDet.CostoPromedio = listpre.PrecioVentaC
        '            Me.InvMovAlmacenDet.CostoPromedioAnterior = listpre.PrecioVentaC
        '            Me.InvMovAlmacenDet.IdProdComp = prod.Codigo
        '            If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
        '                Trans.Rollback()
        '                'Cancelar = True
        '                Exit Sub
        '            Else
        '                txthistorial.Text += "Guarda y actualiza el mov. de inv en kit. Hora: " & Now().ToString & vbLf
        '                Application.DoEvents()
        '            End If
        '        Next
        '    Else
        '        j += 1
        '        Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
        '        Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
        '        Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
        '        Me.InvMovAlmacenDet.IdProducto = CInt(.Rows(i).Cells("clmCodProducto").Value)
        '        Me.InvMovAlmacenDet.Cantidad = CDec(.Rows(i).Cells("clmCantidad").Value)
        '        Me.InvMovAlmacenDet.Costo = CDec(.Rows(i).Cells("clmPrecioUnit").Value)
        '        Me.InvMovAlmacenDet.Descuento = CDec(.Rows(i).Cells("clmDescuento").Value)
        '        Me.InvMovAlmacenDet.Indice = j


        '        If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
        '            Trans.Rollback()
        '            'Cancelar = True
        '            Exit Sub
        '        Else
        '            txthistorial.Text += "Guarda y actualiza el mov. de inv. Hora: " & Now().ToString & vbLf
        '            Application.DoEvents()
        '        End If
        '    End If
        'End With

        '------------------Abajo Parte de los movimientos de inventario-----------------------
        TransMovAlm = New HC.Transaction(IsolationLevel.ReadCommitted, "MovAlm")



        If Not GuardarMovAlmacenCab(10) Then ''Entrada
            Trans.Rollback()
            TransMovAlm.Rollback()

            'Cancelar = True
            'Exit Function
            Exit Sub
        End If

        If Not InvMovAlmacenCab.Guardar(TransMovAlm) Then
            Trans.Rollback()
            TransMovAlm.Rollback()

            'Cancelar = True
            'Exit Function
            Exit Sub
        End If

        Dim j As Integer = 0
        For Each rown As DataGridViewRow In dgvDetalle.Rows
            'Dim prod As New ProductoClass(CInt(.Rows(i).Cells("clmCodProducto").Value))
            Dim prod As New CN.ProductoClass(CInt(rown.Cells(clmCodProducto.Index).Value))
            If prod.EsKit Then
                Dim cantidad As Integer = CInt(rown.Cells(ClmCantidad.Index).Value)
                Dim Detkit As New ClasesNegocio.DetalleKitCollectionClass
                Detkit.Obtener(HC.DetalleKitPvFields.IdKit = prod.Codigo)
                For index As Integer = 1 To cantidad
                    For Each row As CN.DetalleKitClass In Detkit
                        j += 1
                        Me.InvMovAlmacenDet = New CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                        Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                        Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                        Me.InvMovAlmacenDet.IdProducto = row.IdProd
                        Me.InvMovAlmacenDet.Cantidad = row.Cantidad
                        'Dim listpre As New CN.ListaPrecioDetalleClass(1, row.IdProd)
                        Me.InvMovAlmacenDet.Costo = row.Precio
                        Me.InvMovAlmacenDet.Descuento = 0
                        Me.InvMovAlmacenDet.Indice = j

                        'Me.InvMovAlmacenDet.CostoPromedio = listpre.PrecioVentaC
                        'Me.InvMovAlmacenDet.CostoPromedioAnterior = listpre.PrecioVentaC
                        Me.InvMovAlmacenDet.IdProdComp = prod.Codigo
                        If Not Me.InvMovAlmacenDet.Guardar(TransMovAlm) Then
                            Trans.Rollback()
                            TransMovAlm.Rollback()
                            'Cancelar = True
                            Exit Sub
                        Else
                            'txthistorial.Text += "Guarda y actualiza el mov. de inv en kit. Hora: " & Now().ToString & vbLf
                            Application.DoEvents()
                        End If
                    Next
                Next

            Else
                'If dgvDetalle.Rows(ind).Cells(clmCodprodComp.Index).Value = 0 Then
                j += 1
                Me.InvMovAlmacenDet = New CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                Me.InvMovAlmacenDet.IdProducto = CInt(rown.Cells(clmCodProducto.Index).Value)
                Me.InvMovAlmacenDet.Cantidad = CDec(rown.Cells(ClmCantidad.Index).Value)
                Me.InvMovAlmacenDet.Costo = CDec(rown.Cells(clmPrecio.Index).Value)
                Me.InvMovAlmacenDet.Descuento = 0
                Me.InvMovAlmacenDet.Indice = j

                If Not Me.InvMovAlmacenDet.Guardar(TransMovAlm) Then
                    Trans.Rollback()
                    TransMovAlm.Rollback()
                    'Cancelar = True
                    Exit Sub
                Else
                    'txthistorial.Text += "Guarda y actualiza el mov. de inv. Hora: " & Now().ToString & vbLf
                    Application.DoEvents()
                End If
                'End If
            End If
        Next



    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If BoolB Then
            lblEstatus.ForeColor = Drawing.Color.White
            BoolB = False
            BoolN = True
        Else
            lblEstatus.ForeColor = Drawing.Color.Black
            BoolB = True
            BoolN = False
        End If

    End Sub

    Private Sub txtFolio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFolio.KeyDown
        If txtFolio.Text.Length > 0 Then
            If e.KeyCode = Keys.Enter Then
                mtb_ClickBuscar(Nothing, Nothing, False)
                mtb.sbCambiarEstadoBotones("Buscar")
            End If
        End If
    End Sub
End Class