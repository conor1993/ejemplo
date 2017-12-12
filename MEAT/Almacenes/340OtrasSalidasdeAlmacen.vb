Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class _340OtrasSalidasdeAlmacen
    Dim AlmacenesCol As CN.AlmacenCollectionClass
    Dim MovAlmacenCab As CN.MovimientosAlmacenClass
    Dim MovAlmacenDet As CN.MovimientosAlmacenDetClass
    Dim TipoMov As CN.TipoMovimientoClass
    Dim _FolioAlmacen As String
    Dim Salidas As Boolean
    Dim Folio As String
    Dim CodMov As Integer

    Private Sub _340OtrasSalidasdeAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Dim tbEstados As New MiToolBar.miToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            AlmacenesCol = New CN.AlmacenCollectionClass
            AlmacenesCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Me.CmbAlmacen.ValueMember = "Codigo"
            Me.CmbAlmacen.DisplayMember = "Descripcion"
            Me.CmbAlmacen.DataSource = AlmacenesCol
            Me.CmbAlmacen.SelectedIndex = 0

            Me.ProductosVistaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            DesHabilitar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtEntrega.Text = ""
        Me.txtFolio.Text = ""
        Me.txtImporte.Text = 0
        Me.txtObservaciones.Text = ""
        Me.txtRecibe.Text = ""
        Me.dtFechaAlta.Value = Now
        'Me.lblEstatus.Visible = False
        Me.DgvProductos.Rows.Clear()
        Me.CmbAlmacen.SelectedIndex = -1
        Me.CmbMovimiento.SelectedIndex = -1
    End Sub

    Private Sub Habilitar()
        Me.txtEntrega.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtRecibe.Enabled = True
        Me.CmbAlmacen.Enabled = True
        Me.CmbMovimiento.Enabled = True
        Me.DgvProductos.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.txtEntrega.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtRecibe.Enabled = False
        Me.CmbAlmacen.Enabled = False
        Me.CmbMovimiento.Enabled = False
        Me.DgvProductos.Enabled = False
    End Sub

    Private Sub Total()
        Dim Total As Decimal = 0
        For i As Integer = 0 To Me.DgvProductos.Rows.Count - 1
            Total += Me.DgvProductos.Rows(i).Cells(Me.clmImporte.Index).Value
        Next
        Me.txtImporte.Text = Total.ToString("C2")
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.CmbAlmacen.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione un Almac�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbAlmacen.Focus()
                Return False
            End If

            If Me.CmbMovimiento.SelectedIndex < 0 Then
                MessageBox.Show("Seleccione el tipo de movimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.CmbMovimiento.Focus()
                Return False
            End If

            If Not Me.DgvProductos.Rows.Count > 1 Then
                MessageBox.Show("seleccione los productos que van a entrar al Almac�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.DgvProductos.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GuardarCab() As Boolean
        Try
           
            Dim ConfigAlm As New CC.InventarioConfiguracionCollection
            ConfigAlm.GetMulti(Nothing, 0, Nothing)
            If ConfigAlm.Count < 1 Then
                MessageBox.Show("Configure los movimientos de almac�n para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Me.MovAlmacenCab.AlmacenId = Me.CmbAlmacen.SelectedValue
            Me.MovAlmacenCab.FolioMovimiento = _FolioAlmacen
            Me.MovAlmacenCab.Entrega = Me.txtEntrega.Text
            Me.MovAlmacenCab.Recibe = Me.txtRecibe.Text
            Me.MovAlmacenCab.FechaMovimiento = Now
            Me.MovAlmacenCab.Observaciones = Me.txtObservaciones.Text
            Me.MovAlmacenCab.Origen = "OTRAS SALIDAS"
            Me.MovAlmacenCab.CostoTotal = CDec(Me.txtImporte.Text.Replace("$", ""))
            Me.MovAlmacenCab.Estatus = ClasesNegocio.EstatusEnum.ACTIVO

            If Salidas Then
                If Me.CmbMovimiento.SelectedIndex = 0 Then
                    If IsDBNull(ConfigAlm(0).SxOtros) Then
                        MessageBox.Show("Configure los movimientos de almac�n para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End If
                    Me.MovAlmacenCab.TipoMovimientoId = ConfigAlm(0).SxOtros
                Else
                    If IsDBNull(ConfigAlm(0).SxAjusteInventario) Then
                        MessageBox.Show("Configure los movimientos de almac�n para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End If
                    Me.MovAlmacenCab.TipoMovimientoId = ConfigAlm(0).SxAjusteInventario
                End If
            Else
                Me.MovAlmacenCab.TipoMovimientoId = ConfigAlm(0).ExOtros
                Me.MovAlmacenCab.Referencia = Folio
            End If
            Me.MovAlmacenCab.EstatusContabilizado = 0
            Me.MovAlmacenCab.UsuarioId = Controlador.Sesion.MiUsuario.Usrndx
            CodMov = Me.MovAlmacenCab.TipoMovimientoId

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

    Private Sub DgvProductos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProductos.CellEndEdit
        Try
            Me.DgvProductos.Refresh()
            If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Then
                Dim Importe As Integer = 0
                For Each det As CN.MovimientosAlmacenDetClass In Me.MovAlmacenCab.Detalle
                    Dim sum As Integer = 0
                    If det.Costo > 0 Then
                        Importe += det.Cantidad * det.Costo
                    End If

                    For Each det2 As CN.MovimientosAlmacenDetClass In Me.MovAlmacenCab.Detalle
                        If det.ProductoId = det2.ProductoId Then
                            sum += 1
                        End If
                    Next

                    If sum > 1 Then
                        MovAlmacenCab.Detalle.Remove(MovAlmacenCab.Detalle(MovAlmacenCab.Detalle.Count - 1))
                        Me.DgvProductos.Refresh()
                        Exit For
                    End If
                Next
                Me.txtImporte.Text = Importe.ToString("C2")
            End If
            Select Case e.ColumnIndex
                Case Me.clmCantidad.Index
                    If Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value > 0 Then
                        Me.DgvProductos.CurrentRow.Cells(Me.clmImporte.Index).Value = Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value * _
                              Me.DgvProductos.CurrentRow.Cells(Me.clmUltimoCosto.Index).Value
                        Total()
                        If Me.CmbAlmacen.SelectedIndex < 0 Then
                            MessageBox.Show("Seleccione un almac�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Select
                            Me.CmbAlmacen.SelectedIndex = 0
                            Me.CmbAlmacen.Focus()
                        End If
                        If Not Me.DgvProductos.CurrentRow.Cells(Me.clmCodigo.Index).Value > 0 Then
                            MessageBox.Show("Seleccione un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Select
                        End If
                        Dim InvCol As New CC.InventarioAlmacenCollection
                        Dim Filtro As New OC.PredicateExpression
                        'Se obtiene el ultimo movimiento del producto en el almacen 
                        Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = Me.CmbAlmacen.SelectedValue And _
                                  HC.InventarioAlmacenFields.ProductoId = Me.DgvProductos.CurrentRow.Cells(Me.clmCodigo.Index).Value)
                        Dim Orden As New OC.SortExpression
                        Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.A�o, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                        Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                        InvCol.GetMulti(Filtro, 1, Orden)

                        Dim AuxInvEntity As EC.InventarioAlmacenEntity
                        If InvCol.Count > 0 Then
                            AuxInvEntity = InvCol(0)
                            Dim Exist As Decimal = AuxInvEntity.CantidadExistencia
                            If Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value > Exist Then
                                MessageBox.Show("Esta sacando mas mercancia de la que hay en el almac�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        Else
                            MessageBox.Show("No se encontro el producto en el Almac�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                Case Me.clmUltimoCosto.Index
                    If Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value > 0 Then
                        Me.DgvProductos.CurrentRow.Cells(Me.clmImporte.Index).Value = Me.DgvProductos.CurrentRow.Cells(Me.clmCantidad.Index).Value * _
                              Me.DgvProductos.CurrentRow.Cells(Me.clmUltimoCosto.Index).Value
                        Total()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvProductos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvProductos.DataError

    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            Salidas = False
            If Me.CmbMovimiento.SelectedIndex < 0 Then
                MessageBox.Show("El movimiento que ha seleccionado no es una salida, no se puede cancelar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If
            Dim Almacen As New CN.AlmacenClass(CInt(Me.CmbAlmacen.SelectedValue))
            Dim Folio As New CN.FolioAlmacenClass
            Folio.LetraSerie = Almacen.Letras
            Folio.Mes = Now.ToString("MM")
            Folio.A�o = Now.Year
            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            _FolioAlmacen = Folio.A�o & Folio.Mes & Folio.Consecutivo.ToString("0000")

            Me.MovAlmacenCab = New CN.MovimientosAlmacenClass
            If Not GuardarCab() Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudo cancelar la salida del Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not MovAlmacenCab.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudo cancelar la salida del Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim Divisor As Integer
            Dim AuxInvAlm As CN.MInvAlmacenClass
            Dim CostoPromedio As Integer
            Dim ProductoId As Integer
            Dim Cantidad As Decimal
            Dim Costo As Decimal
            Dim i As Integer = 0
            For i = 0 To Me.DgvProductos.Rows.Count - 2
                ProductoId = Me.DgvProductos.Rows(i).Cells(Me.clmCodigo.Index).Value
                Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                Costo = Me.DgvProductos.Rows(i).Cells(Me.clmUltimoCosto.Index).Value

                AuxInvAlm = New CN.MInvAlmacenClass
                If AuxInvAlm.Obtener(Almacen.Codigo, ProductoId, Now.Year, Now.ToString("MM")) Then
                    If Costo > 0 Then
                        Divisor = Cantidad + AuxInvAlm.Cantidad
                        If Divisor = 0 Then
                            CostoPromedio = 0
                        Else
                            CostoPromedio = ((AuxInvAlm.Cantidad * AuxInvAlm.CostoPromedio) + (Cantidad * Costo)) / _
                                             Divisor
                            AuxInvAlm.CostoPromedio = CostoPromedio
                            AuxInvAlm.FechaUltimoCosto = Now
                            AuxInvAlm.UltimoCosto = Costo
                        End If
                    End If
                    AuxInvAlm.Cantidad += Cantidad
                    AuxInvAlm.CantidadEntrada = Cantidad
                    AuxInvAlm.CantidadSalida = 0
                    If Not AuxInvAlm.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        MessageBox.Show("No se pudo cancelar la salida del Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    Dim InvCol As New CC.InventarioAlmacenCollection
                    Dim Filtro As New OC.PredicateExpression
                    'Se obtiene el ultimo movimiento del producto en el almacen 
                    Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = Almacen.Codigo And _
                              HC.InventarioAlmacenFields.ProductoId = ProductoId)
                    Dim Orden As New OC.SortExpression
                    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.A�o, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                    InvCol.GetMulti(Filtro, 1, Orden)

                    Dim AuxInvEntity As EC.InventarioAlmacenEntity
                    If InvCol.Count > 0 Then
                        AuxInvEntity = InvCol(0)

                        Dim cantExistencia As Integer = AuxInvEntity.CantidadExistencia
                        Dim CostoProm As Integer = AuxInvEntity.CostoPromedio
                        Divisor = cantExistencia + Cantidad
                        If Divisor = 0 Then
                            CostoPromedio = 0
                        Else
                            CostoPromedio = ((cantExistencia * CostoProm) + (Cantidad * Costo)) / _
                                             Divisor
                        End If

                        Dim InvEntity As New EC.InventarioAlmacenEntity
                        With InvEntity

                            .AlmacenId = AuxInvEntity.AlmacenId
                            .ProductoId = AuxInvEntity.ProductoId
                            .A�o = Now.Year
                            .Mes = Now.ToString("MM")
                            .CantidadExistencia = cantExistencia + Cantidad
                            .CantidadEntrada = Cantidad
                            .CantidadSalidas = 0
                            .CantidadInicial = AuxInvEntity.CantidadExistencia
                            If Costo > 0 Then
                                .CostoPromedio = CostoPromedio
                                .UltimoCosto = Costo
                                .FechaUltimoCosto = Now
                            Else
                                .CostoPromedio = AuxInvEntity.CostoPromedio
                                .UltimoCosto = AuxInvEntity.UltimoCosto
                                .FechaUltimoCosto = AuxInvEntity.FechaUltimoCosto
                            End If
                        End With
                        Trans.Add(InvEntity)
                        If Not InvEntity.Save Then
                            Trans.Rollback()
                            MessageBox.Show("No se pudo cancelar la salida del Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Cancelar = True
                        End If
                    Else
                        Dim invEntity As New EC.InventarioAlmacenEntity
                        With invEntity
                            .AlmacenId = Almacen.Codigo
                            .ProductoId = ProductoId
                            .A�o = Now.Year
                            .Mes = Now.ToString("MM")
                            .CantidadExistencia = Cantidad
                            .CantidadEntrada = Cantidad
                            .CantidadSalidas = 0
                            .CantidadInicial = 0
                            .UltimoCosto = Costo
                            .CostoPromedio = Costo
                            .FechaUltimoCosto = Now
                        End With
                        Trans.Add(invEntity)
                        If Not invEntity.Save Then
                            Trans.Rollback()
                            MessageBox.Show("No se pudo cancelar la salida del Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Cancelar = True
                        End If
                    End If
                End If


                Me.MovAlmacenDet = New CN.MovimientosAlmacenDetClass
                MovAlmacenDet.AlmacenId = Almacen.Codigo
                MovAlmacenDet.Indice = i + 1
                MovAlmacenDet.FolioMovimiento = _FolioAlmacen
                MovAlmacenDet.ProductoId = ProductoId
                MovAlmacenDet.FechaMovimiento = Now
                MovAlmacenDet.Cantidad = Cantidad
                MovAlmacenDet.Costo = Costo
                MovAlmacenDet.Descuento = 0
                MovAlmacenDet.IVA = 0
                If Not MovAlmacenDet.Guardar(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                    MessageBox.Show("No se pudo cancelar la salida del Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            Trans.Commit()
            MessageBox.Show("Se ha registrado la cancelaci�n de salida de Almac�n con el folio: " & _FolioAlmacen, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesHabilitar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
            Trans.Rollback()
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New FrmAlmBusqMovAmacen
            Ventana.Icon = Me.Icon
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Folio = Ventana.DgvMovimientos.SelectedRows(0).Cells(Ventana.ClmFolio.Index).Value
                Dim AlmacenId As Integer = Ventana.DgvMovimientos.SelectedRows(0).Cells(Ventana.clmAlmacenId.Index).Value

                Me.MovAlmacenCab = New CN.MovimientosAlmacenClass(AlmacenId, Folio)
                Me.DgvProductos.AutoGenerateColumns = False
                Me.DgvProductos.DataSource = MovAlmacenCab.Detalle

                Me.txtFolio.Text = Folio
                Me.txtEntrega.Text = MovAlmacenCab.Entrega
                Me.txtRecibe.Text = MovAlmacenCab.Recibe
                Me.txtObservaciones.Text = MovAlmacenCab.Observaciones
                Me.CmbAlmacen.SelectedValue = MovAlmacenCab.AlmacenId
                Me.dtFechaAlta.Value = MovAlmacenCab.FechaMovimiento
                Total()

                Dim ConfigAlm As New CC.InventarioConfiguracionCollection
                ConfigAlm.GetMulti(Nothing, 0, Nothing)
                Dim SxInv As Integer = ConfigAlm(0).SxAjusteInventario
                Dim SxOtros As Integer = ConfigAlm(0).SxOtros

                If MovAlmacenCab.TipoMovimientoId = SxInv Then
                    Me.CmbMovimiento.SelectedIndex = 0
                    Exit Sub
                End If
                If MovAlmacenCab.TipoMovimientoId = SxOtros Then
                    Me.CmbMovimiento.SelectedIndex = 1
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If
            Dim Almacen As New CN.AlmacenClass(CInt(Me.CmbAlmacen.SelectedValue))
            Dim Folio As New CN.FolioAlmacenClass
            Folio.LetraSerie = Almacen.Letras
            Folio.Mes = Now.ToString("MM")
            Folio.A�o = Now.Year
            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                Exit Sub
            End If

            _FolioAlmacen = Folio.A�o & Folio.Mes & Folio.Consecutivo.ToString("0000")

            Me.MovAlmacenCab = New CN.MovimientosAlmacenClass
            If Not GuardarCab() Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudo registrar la Salida en el Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not MovAlmacenCab.Guardar(Trans) Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudo registrar la Salida en el Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim Divisor As Integer
            Dim AuxInvAlm As CN.MInvAlmacenClass
            Dim CostoPromedio As Integer
            Dim ProductoId As Integer
            Dim Cantidad As Decimal
            Dim Costo As Decimal
            Dim i As Integer
            For i = 0 To Me.DgvProductos.Rows.Count - 2
                ProductoId = Me.DgvProductos.Rows(i).Cells(Me.clmCodigo.Index).Value
                Cantidad = Me.DgvProductos.Rows(i).Cells(Me.clmCantidad.Index).Value
                Costo = Me.DgvProductos.Rows(i).Cells(Me.clmUltimoCosto.Index).Value

                AuxInvAlm = New CN.MInvAlmacenClass
                If AuxInvAlm.Obtener(Almacen.Codigo, ProductoId, Now.Year, Now.ToString("MM")) Then

                    If Costo > 0 Then
                        Divisor = AuxInvAlm.Cantidad - Cantidad
                        If Divisor = 0 Then
                            CostoPromedio = 0
                        Else
                            CostoPromedio = ((AuxInvAlm.Cantidad * AuxInvAlm.CostoPromedio) - (Cantidad * Costo)) / _
                                             Divisor
                            AuxInvAlm.CostoPromedio = CostoPromedio
                            AuxInvAlm.FechaUltimoCosto = Now
                            AuxInvAlm.UltimoCosto = Costo
                        End If
                    End If
                    AuxInvAlm.Cantidad -= Cantidad
                    AuxInvAlm.CantidadEntrada = 0
                    AuxInvAlm.CantidadSalida = Cantidad
                    If AuxInvAlm.Cantidad = 0 Then
                        AuxInvAlm.UltimoCosto = 0
                        AuxInvAlm.FechaUltimoCosto = "01/01/1900"
                    End If
                    If Not AuxInvAlm.Guardar(Trans) Then
                        Trans.Rollback()
                        Cancelar = True
                        MessageBox.Show("No se pudo registrar la Salida en el Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    Dim InvCol As New CC.InventarioAlmacenCollection
                    Dim Filtro As New OC.PredicateExpression
                    'Se obtiene el ultimo movimiento del producto en el almacen 
                    Filtro.Add(HC.InventarioAlmacenFields.AlmacenId = Almacen.Codigo And _
                              HC.InventarioAlmacenFields.ProductoId = ProductoId)
                    Dim Orden As New OC.SortExpression
                    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.A�o, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                    Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                    InvCol.GetMulti(Filtro, 1, Orden)

                    Dim AuxInvEntity As EC.InventarioAlmacenEntity
                    If InvCol.Count > 0 Then
                        AuxInvEntity = InvCol(0)

                        Dim cantExistencia As Integer = AuxInvEntity.CantidadExistencia
                        Dim CostoProm As Integer = AuxInvEntity.CostoPromedio
                        Divisor = cantExistencia - Cantidad
                        If Divisor = 0 Then
                            CostoPromedio = 0
                        Else
                            CostoPromedio = ((cantExistencia * CostoProm) - (Cantidad * Costo)) / _
                                             Divisor
                        End If

                        Dim InvEntity As New EC.InventarioAlmacenEntity
                        With InvEntity

                            .AlmacenId = AuxInvEntity.AlmacenId
                            .ProductoId = AuxInvEntity.ProductoId
                            .A�o = Now.Year
                            .Mes = Now.ToString("MM")
                            .CantidadExistencia = cantExistencia - Cantidad
                            .CantidadEntrada = 0
                            .CantidadSalidas = Cantidad
                            .CantidadInicial = AuxInvEntity.CantidadExistencia
                            If Costo > 0 Then
                                .CostoPromedio = CostoPromedio
                                .UltimoCosto = Costo
                                .FechaUltimoCosto = Now
                            Else
                                .CostoPromedio = AuxInvEntity.CostoPromedio
                                .UltimoCosto = AuxInvEntity.UltimoCosto
                                .FechaUltimoCosto = AuxInvEntity.FechaUltimoCosto
                            End If
                        End With
                        Trans.Add(InvEntity)
                        If Not InvEntity.Save Then
                            Trans.Rollback()
                            MessageBox.Show("No se pudo registrar la Salida en el Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Cancelar = True
                        End If
                    Else
                        MessageBox.Show("No se encontro el producto " & Me.DgvProductos.Rows(i).Cells(Me.clmProducto.Index).Value & " en el almac�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Trans.Rollback()
                        Cancelar = True
                        Exit Sub
                    End If
                End If


                Me.MovAlmacenDet = New CN.MovimientosAlmacenDetClass
                MovAlmacenDet.AlmacenId = Almacen.Codigo
                MovAlmacenDet.Indice = i + 1
                MovAlmacenDet.FolioMovimiento = _FolioAlmacen
                MovAlmacenDet.ProductoId = ProductoId
                MovAlmacenDet.FechaMovimiento = Now
                MovAlmacenDet.Cantidad = Cantidad
                MovAlmacenDet.Costo = Costo
                MovAlmacenDet.Descuento = 0
                MovAlmacenDet.IVA = 0
                TipoMov = New CN.TipoMovimientoClass(CodMov)
                MovAlmacenDet.DescripcionMov = TipoMov.Nombre
                MovAlmacenDet.UnidadMed = MovAlmacenDet.UnidadMedida

                If Not MovAlmacenDet.Guardar(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                    MessageBox.Show("No se pudo registrar Salida en el Almac�n, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            Trans.Commit()
            MessageBox.Show("Se ha registrado Salida en el Almac�n con el folio: " & _FolioAlmacen, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesHabilitar()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
            Trans.Rollback()
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Me.MovAlmacenCab = New CN.MovimientosAlmacenClass
        Me.DgvProductos.AutoGenerateColumns = False
        Me.DgvProductos.DataSource = MovAlmacenCab.Detalle
        Salidas = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub CmbAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbAlmacen.KeyDown
        If e.KeyCode = Keys.F12 Then
            Me.AlmacenesCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub CmbAlmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbAlmacen.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.CmbMovimiento.Focus()
        End If
    End Sub

    Private Sub CmbMovimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbMovimiento.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtEntrega.Focus()
        End If
    End Sub

    Private Sub txtEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrega.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRecibe.Focus()
        End If
    End Sub

    Private Sub txtRecibe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecibe.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.DgvProductos.Focus()
        End If
    End Sub
End Class