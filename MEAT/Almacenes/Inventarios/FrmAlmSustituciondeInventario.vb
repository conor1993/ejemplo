Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports PA = Integralab.ORM.StoredProcedureCallerClasses
Imports System.Data.SqlClient

Public Class FrmAlmSustituciondeInventario
    Dim band As Boolean

    Private Sub FrmAlmSustituciondeInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Almacen As New AlmacenClass
            Dim AlmacenesCol As New AlmacenCollectionClass
            Dim AuxCol As New AlmacenCollectionClass
            Dim AlmacenesConfigurados As Boolean

            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                AlmacenesConfigurados = True
                MsgBox("Debe establecer la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
            Else
                If Not Controlador.Configuracion.Produccion.IdAlmacenesCortes.HasValue Then
                    AlmacenesConfigurados = True
                    MsgBox("Debe seleccionar el Almacen de Cortes en la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
                Else
                    Dim ProductosValorAgregado As New CC.MsccatProductosCollection()

                    ProductosValorAgregado.GetMulti(HC.MsccatProductosFields.ValorAgregado = True)

                    If Not Controlador.Configuracion.Produccion.IdAlmacenValorAgregado.HasValue AndAlso ProductosValorAgregado.Count > 0 Then
                        AlmacenesConfigurados = True
                        MsgBox("Debe seleccionar el Almacen de Valor Agregado en la configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End If
            End If

            If AlmacenesConfigurados Then
                CmbAlmacenes.Enabled = False
                DateTimePicker1.Enabled = False
                mtb.Enabled = False
                DataGridView2.Enabled = False
                DataGridView3.Enabled = False
                Exit Sub
            End If

            AlmacenesCol.Add(Almacen)
            AuxCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            For Each Alm As AlmacenClass In AuxCol
                AlmacenesCol.Add(Alm)
            Next

            CmbAlmacenes.SelectedIndex = -1
            CmbAlmacenes.ValueMember = "Codigo"
            CmbAlmacenes.DisplayMember = "Descripcion"
            CmbAlmacenes.DataSource = AlmacenesCol
            band = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbAlmacenes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAlmacenes.SelectedIndexChanged
        If Band = False Then
            Exit Sub
        End If

        Try            
            ExistenciasLibros()
            ExistenciasFisicas()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al mostrar el reporte", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim ColeccionLotesCortes As New CC.MscloteCortesDetCollection()
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            Dim FolioLoteCorte As String = ""

            HC.DbUtils.CommandTimeOut = 120

            'generar salidas de almacen 
            For i As Integer = 0 To Me.DataGridView2.RowCount - 1

                Dim movimientoAlm As New MovimientoAlmacenClass
                Dim LoteCorteDetalle As New CortesDetalleClass

                'movimientoAlm.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                movimientoAlm.IdAlmacen = Me.CmbAlmacenes.SelectedValue
                movimientoAlm.FechaMovimiento = Now
                movimientoAlm.FechaCaptura = Now
                movimientoAlm.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Corte_X_Ajuste_Inventario)
                movimientoAlm.Kilos = Me.DataGridView2.Rows(i).Cells(Me.clmKilosLibros.Index).Value
                movimientoAlm.Piezas = Me.DataGridView2.Rows(i).Cells(Me.clmPiezasLibros.Index).Value
                movimientoAlm.Estatus = EstatusChar.VIGENTE
                movimientoAlm.QuienCancelo = ""
                movimientoAlm.IdPoliza = ""
                movimientoAlm.QuienContabilizo = ""
                movimientoAlm.ObservacionCancela = ""
                movimientoAlm.AgregarDetalle(Me.DataGridView2.Rows(i).Cells(Me.Codigo.Index).Value, Me.DataGridView2.Rows(i).Cells(Me.clmKilosLibros.Index).Value, Me.DataGridView2.Rows(i).Cells(Me.clmPiezasLibros.Index).Value, 0, 0)

                If Not movimientoAlm.Guardar(Trans) Then
                    Trans.Rollback()
                    MsgBox("Ocurrio un error al momento de guardar el movimiento de almacèn", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                'LoteCorteDetalle = New CortesDetalleClass(" ", Me.DataGridView2.Rows(i).Cells(Me.Etiqueta.Index).Value)
                LoteCorteDetalle.IdFolioLoteCorte = Me.DataGridView2.Rows(i).Cells(Me.clmLoteCorte.Index).Value
                LoteCorteDetalle.Estatus = 3
                LoteCorteDetalle.IdProducto = Me.DataGridView2.Rows(i).Cells(Me.Codigo.Index).Value
                LoteCorteDetalle.IdFolioEtiqueta = Me.DataGridView2.Rows(i).Cells(Me.Etiqueta.Index).Value
                LoteCorteDetalle.IdFolioMovimiento = movimientoAlm.FolioMovimiento
                LoteCorteDetalle.Operacion = CortesDetalleClass.OperacionEnum.AjustarInventario

                If Not LoteCorteDetalle.Guardar(Trans) Then
                    Trans.Rollback()
                    MessageBox.Show("Error al guardar el detalle de cortes", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next

            'generar entradas de almacen 
            'generar corte a partir de una sustitucion de inventario
            If Me.DataGridView3.Rows.Count > 0 Then
                Dim LoteCorte As New CortesClass
                'LoteCorte.LoteCorte = ""
                LoteCorte.LoteSacrificio = "AJUSINV"
                LoteCorte.FechaCorte = Now
                LoteCorte.FechaCaptura = Now
                LoteCorte.FechaCad = Me.DateTimePicker1.Value.AddDays(30)
                LoteCorte.Estatus = "A"
                LoteCorte.DiasCad = 30
                LoteCorte.IdCliente = 0
                LoteCorte.Func = "I"
                LoteCorte.NumOpc = 1

                If Not LoteCorte.Guardar(Trans) Then
                    Trans.Rollback()
                    Exit Sub
                End If
                FolioLoteCorte = LoteCorte.LoteCorte
            End If

            For i As Integer = 0 To Me.DataGridView3.RowCount - 1

                Dim movimientoAlmEnt As New MovimientoAlmacenClass
                Dim LoteCorteDetalle As New CortesDetalleClass
                Dim Consecutivo As String

                'movimientoAlmEnt.EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CORTE)
                movimientoAlmEnt.IdAlmacen = Me.CmbAlmacenes.SelectedValue
                movimientoAlmEnt.FechaMovimiento = Now
                movimientoAlmEnt.FechaCaptura = Now
                movimientoAlmEnt.EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Entrada_Corte_X_Ajuste_Inventario)
                movimientoAlmEnt.Kilos = 0
                movimientoAlmEnt.Piezas = 0
                movimientoAlmEnt.Estatus = EstatusChar.VIGENTE
                movimientoAlmEnt.QuienCancelo = ""
                movimientoAlmEnt.IdPoliza = ""
                movimientoAlmEnt.QuienContabilizo = ""
                movimientoAlmEnt.ObservacionCancela = ""
                movimientoAlmEnt.AgregarDetalle(Me.DataGridView3.Rows(i).Cells(Me.Codigo.Index).Value, movimientoAlmEnt.Kilos, movimientoAlmEnt.Piezas, 0, 0)

                If Not movimientoAlmEnt.Guardar(Trans) Then
                    Trans.Rollback()
                    MsgBox("Ocurrio un error al momento de guardar el movimiento de almacèn", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                'LoteCorteDetalle = New CortesDetalleClass(" ", Me.DataGridView2.Rows(i).Cells("EtiquetaFisica").Value)
                Consecutivo = LoteCorteDetalle.Folios(FolioLoteCorte, 0, Trans)
                If Consecutivo = 0 Then
                    Trans.Rollback()
                    Exit Sub
                End If
                LoteCorteDetalle.IdFolioLoteCorte = FolioLoteCorte
                LoteCorteDetalle.IdFolioEtiqueta = Trim(FolioLoteCorte) & Consecutivo.ToString
                LoteCorteDetalle.IdProducto = Me.DataGridView3.Rows(i).Cells(Me.Codigo.Index).Value
                LoteCorteDetalle.IdCorte = CC.MsccortesPreCortesCollection.GetMultiAsDataTable(HC.MsccortesPreCortesFields.IdCorte = LoteCorteDetalle.IdProducto, 0, Nothing).Rows(0)("IdPreCorte")
                LoteCorteDetalle.IdFolioEmbarque = ""
                LoteCorteDetalle.CantKgrs = Me.DataGridView3.Rows(i).Cells("KilosFisicos").Value
                LoteCorteDetalle.CantPzas = Me.DataGridView3.Rows(i).Cells("PiezasFisicAs").Value
                LoteCorteDetalle.IdFolioMovimiento = movimientoAlmEnt.FolioMovimiento

                If Me.DataGridView3.Rows(i).Cells(EtiquetaFisica.Index).Value.ToString.Trim = "" Then
                    LoteCorteDetalle.CodigoBarra = LoteCorteDetalle.FormarCodigoBarra()
                Else
                    LoteCorteDetalle.CodigoBarra = Me.DataGridView3.Rows(i).Cells("EtiquetaFisica").Value
                End If
                LoteCorteDetalle.Estatus = 1

                If LoteCorteDetalle.ObtenerEntidad.MsccatProductosCorte.ValorAgregado Then
                    If Controlador.Configuracion.Produccion.AlmacenValorAgregado.TipoProducto = TipoProductoAlmacen.FRESCO Then
                        LoteCorteDetalle.ObtenerEntidad.TipoProducto = TipoCorte.VALOR_AGREGADO_FRESCO
                    ElseIf Controlador.Configuracion.Produccion.AlmacenValorAgregado.TipoProducto = TipoProductoAlmacen.CONGELADO Then
                        LoteCorteDetalle.ObtenerEntidad.TipoProducto = TipoCorte.VALOR_AGREGADO_CONGELADO
                    Else 'sino finalmente suponemos que es de VENTA
                        LoteCorteDetalle.ObtenerEntidad.TipoProducto = TipoCorte.VALOR_AGREGADO_VENTA
                    End If
                Else ' Es Corte
                    If Controlador.Configuracion.Produccion.AlmacenCortes.TipoProducto = TipoProductoAlmacen.FRESCO Then
                        LoteCorteDetalle.ObtenerEntidad.TipoProducto = TipoCorte.FRESCO
                    ElseIf Controlador.Configuracion.Produccion.AlmacenCortes.TipoProducto = TipoProductoAlmacen.CONGELADO Then
                        LoteCorteDetalle.ObtenerEntidad.TipoProducto = TipoCorte.CONGELADO
                    Else 'sino finalmente suponemos que es de VENTA
                        LoteCorteDetalle.ObtenerEntidad.TipoProducto = TipoCorte.VENTA
                    End If
                End If

                LoteCorteDetalle.ObtenerEntidad.IdAlmacenActual = movimientoAlmEnt.IdAlmacen
                ColeccionLotesCortes.Add(LoteCorteDetalle.ObtenerEntidad)
            Next

            If ColeccionLotesCortes.Count > 0 Then
                Trans.Add(ColeccionLotesCortes)
                ColeccionLotesCortes.SaveMulti()
            End If
            Trans.Commit()
            MsgBox("Se genero movimiento de salida de almacen por ajuste de inventario  y  " & Chr(13) & _
                   "Se genero movimiento de entrada de almacen por ajuste de inventario : ", MsgBoxStyle.Information)
            DataGridView2.DataSource = Nothing
            DataGridView3.DataSource = Nothing
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.CmbAlmacenes.SelectedIndex = 0
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub ExistenciasLibros()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("INVComparativoProduccion", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)

            sqlCom.CommandType = CommandType.StoredProcedure
            'existencias libros
            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '0 para filtrar por almacen
                '1 para filtrar por producto
                .Add("@Opcion", SqlDbType.SmallInt).Value = 4
                .Add("@Almacen", SqlDbType.SmallInt).Value = Me.CmbAlmacenes.SelectedValue
                .Add("@IdProducto", SqlDbType.SmallInt).Value = 0
            End With

            sqlCon.Open()

            ad.Fill(ds)
            Me.DataGridView2.DataSource = Nothing
            Me.DataGridView2.AutoGenerateColumns = False
            Me.DataGridView2.DataSource = ds.Tables(0)

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al mostrar el reporte", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    'busca las cajas que no existen en sistema pero si en fisico
    Private Sub ExistenciasFisicas()
        Dim dt As New DataTable
        Dim Query As String = "Select distinct" & _
            " Dc.LoteCorte" & _
            ",Dc.IdFolioEtiqueta" & _
            ",Dc.IdProducto as CodigoFis" & _
            ",Cp.Descripcion as Corte" & _
            ",Dc.CodigoBarra as EtiquetaFisica" & _
            ",Dc.CantKgrs as KilosFisicos" & _
            ",Dc.CantPzas as PiezasFisicas" & _
            " From MSCLoteCortesDetComparacion As DC Left outer join MSCLoteCortesDet As MS On Dc.CodigoBarra = MS.CodigoBarra" & _
            " Inner join MSCCatProductos Cp on Cp.IDProducto = dc.IdProducto" & _
            " WHERE Dc.Estatus = 1 AND Dc.IdAlmacen = 1 And Dc.CodigoBarra = '' OR MS.CodigoBarra is null"
        Dim da As New SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

        da.SelectCommand.Parameters.Add("@Almacen", SqlDbType.Int).Value = CType(Me.CmbAlmacenes.SelectedValue, Integer)
        da.SelectCommand.Connection.Open()
        da.SelectCommand.Prepare()
        da.Fill(dt)

        Me.DataGridView3.DataSource = Nothing
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.DataSource = dt
    End Sub
End Class