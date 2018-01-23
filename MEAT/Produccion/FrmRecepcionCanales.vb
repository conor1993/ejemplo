Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class FrmRecepcionCanales

#Region "Miembros"
    Dim leerbascula As Boolean = True
    Dim WithEvents RegistroSacrificiosCab As New RegistroSacrificiosClass
    Dim WithEvents RegistroSacrificiosDet As New RegistroSacrificioDetClass
    Dim RegistroSacrifC As RegistroSacrificioColeccionClass
    Dim RecepcCanales As RecepcionCanalesCabClass
    Dim RecepcCanalesDet As RecepcionCanalesDetClass
    Dim NumLados As Integer  'Numero de lados por cabeza
    Dim Almacen As New AlmacenProduccionClass
    Dim AlmacenDetalle As New AlmacenDetalleClass
    Dim Folio As New FoliosClass
    Dim Inventario As New InventarioClass
    Dim Productos As New ProductosClass
    Dim Sacrificio As DataTable
    Dim Canales As DataSet
    Dim TotalCabezasSacrifcar As Integer
    Dim CodCliente As Integer
    'nuevas variables para usarse cuando no sea un rastro
    Private nPag As Integer
    Private codigoBarras As String
    Private folioCanal As String
    Private noRes As Integer
    Private lado As Integer
    Private peso As Decimal
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Private Sub ObtenerSacrificios(ByVal Opcion As Integer)
        Try
            'HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")
            RegistroSacrifC = New RegistroSacrificioColeccionClass

            If Opcion = 1 Then
                RegistroSacrifC.Obtener(Me.RegistroSacrificiosCab.IdLoteSacrificio, Me.RegistroSacrificiosCab.Introductor)

                If RegistroSacrifC.Count = 0 Then
                    MessageBox.Show("Este lote de sacrifcio no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                RegistroSacrifC.Obtener("A")

                If RegistroSacrifC.Count = 0 Then
                    MessageBox.Show("No existen lotes de sacrificios en apertura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            For Each Sacrif As RegistroSacrificiosClass In RegistroSacrifC
                Me.txtLoteSacrificio.Text = Sacrif.IdLoteSacrificio
                Me.dtpFechaSacrificio.Text = Sacrif.FechaSacrificio
                TotalCabezasSacrifcar = Sacrif.CantCabezasSacrificio
                Me.txtProductor.Text = Sacrif.NombreIntroductor
                Me.txtCantCanales.Text = Sacrif.CantCanales
                CodCliente = Sacrif.Introductor
                Me.txtLoteCorteRastro.Text = Sacrif.LoteRastro
            Next

            'el siguiiente codigo nos indica cuantos lados tendra el animal sacrificado 
            'por defaul son dos canales.
            Dim ConfigCol As New CC.UsrProdConfiguracionCollection

            ConfigCol.GetMulti(Nothing)

            If ConfigCol.Count > 0 Then
                If ConfigCol(0).RecibirCanales = True Then
                    NumLados = 2
                Else
                    If RegistroSacrifC(0).ObtenerEntidad.UsrProdRecepcionGanadoDet.Count > 0 Then


                        Dim RecGanDetEnty As EC.UsrProdRecepcionGanadoDetEntity = RegistroSacrifC(0).ObtenerEntidad.UsrProdRecepcionGanadoDet(0)
                        NumLados = RecGanDetEnty.RecepcionGanado.McgcatTiposdeGanado.Lados
                        'lblCostoXKilo.Text = Convert.ToDecimal(RecGanDetEnty.RecepcionGanado.ImpteComp / RecGanDetEnty.RecepcionGanado.KilosComp).ToString("N2")




                        ''Cambia a la bd idefoods para obtener el precio por kilo

                        HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")
                        RegistroSacrifC = New RegistroSacrificioColeccionClass

                        If Opcion = 1 Then
                            RegistroSacrifC.Obtener(Me.RegistroSacrificiosCab.IdLoteSacrificio, Me.RegistroSacrificiosCab.Introductor)

                            If RegistroSacrifC.Count = 0 Then
                                MessageBox.Show("Este lote de sacrifcio no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Else
                            RegistroSacrifC.Obtener("A")

                            If RegistroSacrifC.Count = 0 Then
                                MessageBox.Show("No existen lotes de sacrificios en apertura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        End If
                        RecGanDetEnty = RegistroSacrifC(0).ObtenerEntidad.UsrProdRecepcionGanadoDet(0)
                        If RecGanDetEnty.RecepcionGanado.KilosComp > 0 Then
                            lblCostoXKilo.Text = Convert.ToDecimal(RecGanDetEnty.RecepcionGanado.ImpteComp / RecGanDetEnty.RecepcionGanado.KilosComp).ToString("N2")
                        End If


                        ''Regresa a la estructura de la20
                        HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")

                        RegistroSacrifC = New RegistroSacrificioColeccionClass

                        If Opcion = 1 Then
                            RegistroSacrifC.Obtener(Me.RegistroSacrificiosCab.IdLoteSacrificio, Me.RegistroSacrificiosCab.Introductor)

                            If RegistroSacrifC.Count = 0 Then
                                MessageBox.Show("Este lote de sacrifcio no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Else
                            RegistroSacrifC.Obtener("A")

                            If RegistroSacrifC.Count = 0 Then
                                MessageBox.Show("No existen lotes de sacrificios en apertura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        End If
                        RecGanDetEnty = RegistroSacrifC(0).ObtenerEntidad.UsrProdRecepcionGanadoDet(0)


                    End If
                End If
            Else
                MsgBox("Configure la configuración de Producción", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TotalCanalesLotes()
        Try
            Dim col As New CC.MscrecepcionCanalesDetCollection
            Dim KilosCalientes As Decimal
            Dim KilosRecibidos As Decimal
            Dim kilRecObj As Object = col.GetScalar(IntegraLab.ORM.MscrecepcionCanalesDetFieldIndex.KgrsBascula, _
                                            New OC.Expression(HC.MscrecepcionCanalesDetFields.KgrsBascula), _
                                            SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Sum, HC.MscrecepcionCanalesDetFields.Estatus = "V")
            Dim kilCalObj As Object = col.GetScalar(IntegraLab.ORM.MscrecepcionCanalesDetFieldIndex.KgrsCalientes, _
                                            New OC.Expression(HC.MscrecepcionCanalesDetFields.KgrsCalientes), _
                                            SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Sum, HC.MscrecepcionCanalesDetFields.Estatus = "V")

            If DBNull.Value.Equals(kilRecObj) Then
                KilosRecibidos = 0D
            Else
                KilosRecibidos = CDec(kilRecObj)
            End If

            If DBNull.Value.Equals(kilCalObj) Then
                KilosCalientes = 0D
            Else
                KilosCalientes = CDec(kilCalObj)
            End If

            Me.txtCanales.Text = col.GetDbCount(HC.MscrecepcionCanalesDetFields.Estatus = "V")
            Me.txtKilosCalientes.Text = KilosCalientes
            Me.txtKilosRecibidos.Text = KilosRecibidos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Guardar(ByVal consecutivo As Integer, Optional ByVal CerrarLote As Boolean = False) As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            Dim FolioAlmacen As String
            Dim IdFolioAlmacen As String
            Dim RecepCabCol As New CC.MscrecepcionCanalesCabCollection
            Dim RecepCab As EC.MscrecepcionCanalesCabEntity

            Me.RecepcCanalesDet = New RecepcionCanalesDetClass
            RecepCabCol.GetMulti(HC.MscrecepcionCanalesCabFields.FolioSacrificio = Me.txtLoteSacrificio.Text.Trim)
            FolioAlmacen = ""
            If Not RecepCabCol.Count > 0 Then
                'Folio.Codigo = CodigodeFolios.EntradaCanalesAlmacen
                Folio.Codigo = CodigodeFolios.EntradaCanalesAlmacen
                Folio.Año = Now.Year
                Folio.Mes = Now.ToString("MM")

                If Not Folio.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If

                'folio para el registro de movimientos de almacen
                FolioAlmacen = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
                'Asignar valore a al cabecero de la recepcion de canales
                RecepcCanales = New RecepcionCanalesCabClass

                RecepcCanales.FolioMov = FolioAlmacen
                RecepcCanales.FolioSacrificio = txtLoteSacrificio.Text
                RecepcCanales.FechaSacrificio = dtpFechaSacrificio.Value
                RecepcCanales.FechaCaptura = Now
                RecepcCanales.LotePropio = False
                RecepcCanales.CodCliente = CodCliente
                RecepcCanales.CantCanales = 1
                RecepcCanales.KgrsRastro = 0
                RecepcCanales.Observaciones = ""
                RecepcCanales.Estatus = "V"
                RecepcCanales.IdRastro = 0
                RecepcCanales.KgrsCalientes = Me.txtPeso.Text
                RecepcCanales.KgrsBascula = Me.txtKgrsRecibidos.Text
                RecepcCanales.Funcion = "I"
                RecepcCanales.Opcion = 0

                Me.RecepcCanalesDet.FolioMov = FolioAlmacen

                If Not RecepcCanales.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If


            Else
                RecepCab = RecepCabCol(RecepCabCol.Count - 1)
                Me.RecepcCanalesDet.FolioMov = RecepCab.FolioMovimiento
                'IdFolioAlmacen = RecepDet.FolioMovimiento
                'Modificar las cantidades del cabecero de la recepcion

                RecepcCanales = New RecepcionCanalesCabClass

                RecepcCanales.FolioMov = RecepCab.FolioMovimiento
                RecepcCanales.FechaSacrificio = dtpFechaSacrificio.Value
                RecepcCanales.FolioSacrificio = Me.txtLoteSacrificio.Text
                RecepcCanales.KgrsCalientes = Me.txtPeso.Text
                RecepcCanales.KgrsBascula = Me.txtKgrsRecibidos.Text
                RecepcCanales.KgrsRastro = Me.txtKgrsRecibidos.Text
                RecepcCanales.CantCanales = Me.txtTotalCanales.Text
                RecepcCanales.FechaCaptura = Now
                RecepcCanales.LotePropio = False
                RecepcCanales.CodCliente = CodCliente
                RecepcCanales.Funcion = "M"
                RecepcCanales.Opcion = 1

                If Not RecepcCanales.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
            End If

            'Generar el Folio de movimiento 
            Folio = New FoliosClass
            Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            IdFolioAlmacen = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")

            'asignar datos de almacen a clase de cabecero de almacen 
            Dim ConfigAlmacen As New CC.MscconfigMovtosAlmacenCollection

            ConfigAlmacen.GetMulti(Nothing, 1, New SD.LLBLGen.Pro.ORMSupportClasses.SortExpression(New SD.LLBLGen.Pro.ORMSupportClasses.SortClause(HC.MscconfigMovtosAlmacenFields.IdConfiguracion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            Dim Config As EC.MscconfigMovtosAlmacenEntity

            If ConfigAlmacen.Count > 0 Then
                Config = ConfigAlmacen(0)
            Else
                Trans.Rollback()
                MsgBox("Configure los movimientos de Almacén producción para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If Config.EntradaCanalAlmacen.GetValueOrDefault(-1) = -1 Then
                Trans.Rollback()
                MsgBox("Debe configurar el movimiento de almacén Entradas de Canales a Almacén", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'Obtener la Configuracion 
            Dim ConfigProd As New CC.UsrProdConfiguracionCollection

            ConfigProd.GetMulti(Nothing)

            If Not ConfigProd.Count > 0 Then
                Trans.Rollback()
                MessageBox.Show("Seleccione un Almacen para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Dim Configproduccion As EC.UsrProdConfiguracionEntity = ConfigProd(ConfigProd.Count - 1)

            'Obtener el codigo del producto canal
            Dim Productos As New CC.MsccatProductosCollection

            Productos.GetMulti(HC.MsccatProductosFields.Canal = True)

            If Productos.Count = 0 Then
                Trans.Rollback()
                MsgBox("No hay un producto registrado como canal", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Dim Producto As EC.MsccatProductosEntity = Productos(0)

            Almacen.IdFolioMovimiento = IdFolioAlmacen

            If Not IsDBNull(Configproduccion.IdAlmacenCanales) Then
                Almacen.IdCodAlmacen = Configproduccion.IdAlmacenCanales
            Else
                Trans.Rollback()
                MessageBox.Show("Seleccione un Almacen para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Almacen.FechaMovimiento = Me.dtpFechaCaptura.Value
            Almacen.FechaCaptura = Now
            Almacen.IdCodMovimiento = Config.EntradaCanalAlmacen
            Almacen.CantKilos = Me.txtKgrsRecibidos.Text
            Almacen.CantPzas = 1
            Almacen.Estatus = "V"
            Almacen.QuienCancelo = ""
            Almacen.QuienContabilizo = ""
            Almacen.ObservacionCancela = ""
            Almacen.NumOpc = 1
            Almacen.Func = "I"

            If Not Almacen.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'clase para el detalle de almacen
            AlmacenDetalle.IdFolioMovimiento = IdFolioAlmacen
            AlmacenDetalle.IdCodProducto = Producto.IdProducto
            AlmacenDetalle.CantPzas = 1
            AlmacenDetalle.CantKilos = Me.txtKgrsRecibidos.Text
            AlmacenDetalle.CostoUnitario = 0D
            AlmacenDetalle.IVA = 0D
            'AlmacenDetalle.Estatus = "V"
            AlmacenDetalle.Func = "I"
            AlmacenDetalle.NumOpc = 1

            If Not AlmacenDetalle.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'RecepcCanalesDet.FolioMov = RecepcCanales.FolioMov
            RecepcCanalesDet.FolioSacrificio = Me.txtLoteSacrificio.Text
            RecepcCanalesDet.IdFolioCanal = CInt(Me.txtNoRes.Text).ToString("000") & "-" & Me.txtLado.Text
            'RecepcCanalesDet.Consecutivo = Me.txtNoRes.Text
            RecepcCanalesDet.Lado = Me.txtLado.Text
            RecepcCanalesDet.KgrsRastro = 0
            RecepcCanalesDet.KgrsBascula = Me.txtKgrsRecibidos.Text
            RecepcCanalesDet.Estatus = EstatusCanal.VIGENTE
            RecepcCanalesDet.IdFolioMovimiento = IdFolioAlmacen
            RecepcCanalesDet.CodigoBarra = Me.txtLoteSacrificio.Text & "-" & Me.txtNoRes.Text & "-" & Me.txtLado.Text
            RecepcCanalesDet.KgrsCalientes = Me.txtPeso.Text

            If Me.CmbCliente.SelectedIndex > -1 Then
                RecepcCanalesDet.IdCliente = Me.CmbCliente.SelectedValue
            End If

            If Me.rbtnHembra.Checked Then
                RecepcCanalesDet.Sexo = SexoEnum.HEMBRA
            Else
                RecepcCanalesDet.Sexo = SexoEnum.MACHO
            End If

            Me.RecepcCanalesDet.Funcion = "I"
            Me.RecepcCanalesDet.Opcion = 0

            If Not Me.RecepcCanalesDet.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'clase para el control de inventarios
            Inventario.IdCodAlmacen = Almacen.IdCodAlmacen
            Inventario.IdCodProducto = AlmacenDetalle.IdCodProducto
            Inventario.ExistKilos = AlmacenDetalle.CantKilos
            Inventario.ExistPzas = AlmacenDetalle.CantPzas
            Inventario.EntKilos = AlmacenDetalle.CantKilos
            Inventario.EntPzas = AlmacenDetalle.CantPzas
            Inventario.SalKilos = 0D
            Inventario.SalPzas = 0D
            Inventario.Func = "I"
            Inventario.NumOpc = 1
            Inventario.Año = Now.Year
            Inventario.Mes = Now.Month

            'llama el guardar del inventario de productos
            If Not Inventario.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'Guardar los servicios que fueron seleccionados en la tabla MSCServiciosPorSacrificio
            Dim SerXsacrif As EC.ServiciosPorSacrificioEntity
            Dim i As Integer = 0

            'For Each Serv As ServiciosClass In Me.ServiciosC
            '    If CBool(Me.dgvServicios.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
            '        SerXsacrif = New EC.ServiciosPorSacrificioEntity
            '        SerXsacrif.FolioSacrificio = RecepcCanalesDet.FolioSacrificio
            '        SerXsacrif.FolioCanal = RecepcCanalesDet.IdFolioCanal
            '        SerXsacrif.IdServicio = Serv.Codigo
            '        Trans.Add(SerXsacrif)

            '        If Not SerXsacrif.Save Then
            '            Trans.Rollback()
            '            Return False
            '        End If
            '    End If

            '    i = i + 1
            'Next

            If CerrarLote = True Then
                Dim FolioSacr As String = Me.txtLoteSacrificio.Text

                Me.RegistroSacrificiosCab = New RegistroSacrificiosClass(FolioSacr)

                RegistroSacrificiosCab.Estatus = "C"

                If Not RegistroSacrificiosCab.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If
            End If
            Trans.Commit()

            If Configproduccion.ImprimirEtiquetasCanales = True Then
                Dim Codigo As String = Me.txtLoteSacrificio.Text & Me.txtNoRes.Text & "-" & Me.txtLado.Text
                Me.Imprimir(Me.txtNoRes.Text, Me.txtLado.Text, Me.txtKgrsRecibidos.Text, Me.txtNoRes.Text & "-" & Me.txtLado.Text, Codigo)
            End If
            Trans.Dispose()

            GuardarIDE(FolioAlmacen, RecepCabCol.Count, IdFolioAlmacen, CerrarLote)
            'Return True

            MessageBox.Show("Se ha guardado la Recepción con el Folio: " & Me.txtLoteSacrificio.Text & Me.txtNoRes.Text & "-" & Me.txtLado.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

           

            Me.txtPeso.Text = "0.00"
            Me.txtTotalKilos.Text = "0.00"
            Me.txtKilosRecibidos.Text = "0.00"
            Me.tmActualizacion.Stop()
            Me.ObtenerCanales()
            Me.tmActualizacion.Start()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Private Function GuardarIDE(ByVal FolioAlm As String, ByVal RecepCabColCount As Integer, ByVal IdFolioAlmacen As String, Optional ByVal CerrarLote As Boolean = False) As Boolean

        HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")
        'Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try


            'Dim FolioAlmacen As String
            'Dim IdFolioAlmacen As String
            Dim RecepCabCol As New CC.MscrecepcionCanalesCabCollection
            Dim RecepCab As EC.MscrecepcionCanalesCabEntity

            Me.RecepcCanalesDet = New RecepcionCanalesDetClass
            RecepCabCol.GetMulti(HC.MscrecepcionCanalesCabFields.FolioSacrificio = Me.txtLoteSacrificio.Text.Trim)

            If Not RecepCabColCount > 0 Then
                'Folio.Codigo = CodigodeFolios.EntradaCanalesAlmacen
                'Folio.Codigo = CodigodeFolios.EntradaCanalesAlmacen
                'Folio.Año = Now.Year
                'Folio.Mes = Now.ToString("MM")

                'If Not Folio.Guardar(Trans) Then
                '    Trans.Rollback()
                '    Return False
                'End If

                'folio para el registro de movimientos de almacen
                'FolioAlmacen = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("0000")
                'Asignar valore a al cabecero de la recepcion de canales
                RecepcCanales = New RecepcionCanalesCabClass

                RecepcCanales.FolioMov = FolioAlm
                RecepcCanales.FolioSacrificio = txtLoteSacrificio.Text
                RecepcCanales.FechaSacrificio = dtpFechaSacrificio.Value
                RecepcCanales.FechaCaptura = Now
                RecepcCanales.LotePropio = False
                RecepcCanales.CodCliente = CodCliente
                RecepcCanales.CantCanales = 1
                RecepcCanales.KgrsRastro = 0
                RecepcCanales.Observaciones = ""
                RecepcCanales.Estatus = "V"
                RecepcCanales.IdRastro = 0
                RecepcCanales.KgrsCalientes = Me.txtPeso.Text
                RecepcCanales.KgrsBascula = Me.txtKgrsRecibidos.Text
                RecepcCanales.Funcion = "I"
                RecepcCanales.Opcion = 0

                Me.RecepcCanalesDet.FolioMov = FolioAlm

                If Not RecepcCanales.Guardar() Then
                    'Trans.Rollback()
                    Return False
                End If


            Else
                RecepCab = RecepCabCol(RecepCabCol.Count - 1)
                Me.RecepcCanalesDet.FolioMov = RecepCab.FolioMovimiento
                'IdFolioAlmacen = RecepDet.FolioMovimiento
                'Modificar las cantidades del cabecero de la recepcion

                RecepcCanales = New RecepcionCanalesCabClass

                RecepcCanales.FolioMov = RecepCab.FolioMovimiento
                RecepcCanales.FechaSacrificio = dtpFechaSacrificio.Value
                RecepcCanales.FolioSacrificio = Me.txtLoteSacrificio.Text
                RecepcCanales.KgrsCalientes = Me.txtPeso.Text
                RecepcCanales.KgrsBascula = Me.txtKgrsRecibidos.Text
                RecepcCanales.KgrsRastro = Me.txtKgrsRecibidos.Text
                RecepcCanales.CantCanales = Me.txtTotalCanales.Text
                RecepcCanales.FechaCaptura = Now
                RecepcCanales.LotePropio = False
                RecepcCanales.CodCliente = CodCliente
                RecepcCanales.Funcion = "M"
                RecepcCanales.Opcion = 1

                If Not RecepcCanales.Guardar() Then
                    'Trans.Rollback()
                    Return False
                End If
            End If

            'Generar el Folio de movimiento 
            'Folio = New FoliosClass
            'Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen
            'Folio.Año = Now.Year
            'Folio.Mes = Now.ToString("MM")

            'If Not Folio.Guardar(Trans) Then
            '    Trans.Rollback()
            '    Return False
            'End If

            'IdFolioAlmacen = Folio.Año & Folio.Mes & Folio.Consecutivo.ToString("000000")

            'asignar datos de almacen a clase de cabecero de almacen 
            Dim ConfigAlmacen As New CC.MscconfigMovtosAlmacenCollection

            ConfigAlmacen.GetMulti(Nothing, 1, New SD.LLBLGen.Pro.ORMSupportClasses.SortExpression(New SD.LLBLGen.Pro.ORMSupportClasses.SortClause(HC.MscconfigMovtosAlmacenFields.IdConfiguracion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            Dim Config As EC.MscconfigMovtosAlmacenEntity

            If ConfigAlmacen.Count > 0 Then
                Config = ConfigAlmacen(0)
            Else
                'Trans.Rollback()
                MsgBox("Configure los movimientos de Almacén producción para poder guardar", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If Config.EntradaCanalAlmacen.GetValueOrDefault(-1) = -1 Then
                'Trans.Rollback()
                MsgBox("Debe configurar el movimiento de almacén Entradas de Canales a Almacén", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'Obtener la Configuracion 
            Dim ConfigProd As New CC.UsrProdConfiguracionCollection

            ConfigProd.GetMulti(Nothing)

            If Not ConfigProd.Count > 0 Then
                'Trans.Rollback()
                MessageBox.Show("Seleccione un Almacen para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Dim Configproduccion As EC.UsrProdConfiguracionEntity = ConfigProd(ConfigProd.Count - 1)

            'Obtener el codigo del producto canal
            Dim Productos As New CC.MsccatProductosCollection

            Productos.GetMulti(HC.MsccatProductosFields.Canal = True)

            If Productos.Count = 0 Then
                'Trans.Rollback()
                MsgBox("No hay un producto registrado como canal", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Dim Producto As EC.MsccatProductosEntity = Productos(0)

            Almacen.IdFolioMovimiento = IdFolioAlmacen

            If Not IsDBNull(Configproduccion.IdAlmacenCanales) Then
                Almacen.IdCodAlmacen = Configproduccion.IdAlmacenCanales
            Else
                'Trans.Rollback()
                MessageBox.Show("Seleccione un Almacen para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Almacen.FechaMovimiento = Me.dtpFechaCaptura.Value
            Almacen.FechaCaptura = Now
            Almacen.IdCodMovimiento = Config.EntradaCanalAlmacen
            Almacen.CantKilos = Me.txtKgrsRecibidos.Text
            Almacen.CantPzas = 1
            Almacen.Estatus = "V"
            Almacen.QuienCancelo = ""
            Almacen.QuienContabilizo = ""
            Almacen.ObservacionCancela = ""
            Almacen.NumOpc = 1
            Almacen.Func = "I"

            If Not Almacen.Guardar() Then
                'Trans.Rollback()
                Return False
            End If

            'clase para el detalle de almacen
            AlmacenDetalle.IdFolioMovimiento = IdFolioAlmacen
            AlmacenDetalle.IdCodProducto = Producto.IdProducto
            AlmacenDetalle.CantPzas = 1
            AlmacenDetalle.CantKilos = Me.txtKgrsRecibidos.Text
            AlmacenDetalle.CostoUnitario = CDec(lblCostoXKilo.Text)
            AlmacenDetalle.IVA = 0D
            'AlmacenDetalle.Estatus = "V"
            AlmacenDetalle.Func = "I"
            AlmacenDetalle.NumOpc = 1

            If Not AlmacenDetalle.Guardar() Then
                'Trans.Rollback()
                Return False
            End If

            'RecepcCanalesDet.FolioMov = RecepcCanales.FolioMov
            RecepcCanalesDet.FolioSacrificio = Me.txtLoteSacrificio.Text
            RecepcCanalesDet.IdFolioCanal = CInt(Me.txtNoRes.Text).ToString("000") & "-" & Me.txtLado.Text
            'RecepcCanalesDet.Consecutivo = Me.txtNoRes.Text
            RecepcCanalesDet.Lado = Me.txtLado.Text
            RecepcCanalesDet.KgrsRastro = 0
            RecepcCanalesDet.KgrsBascula = Me.txtKgrsRecibidos.Text
            RecepcCanalesDet.Estatus = EstatusCanal.VIGENTE
            RecepcCanalesDet.IdFolioMovimiento = IdFolioAlmacen
            RecepcCanalesDet.CodigoBarra = Me.txtLoteSacrificio.Text & "-" & Me.txtNoRes.Text & "-" & Me.txtLado.Text
            RecepcCanalesDet.KgrsCalientes = Me.txtPeso.Text

            If Me.CmbCliente.SelectedIndex > -1 Then
                RecepcCanalesDet.IdCliente = Me.CmbCliente.SelectedValue
            End If

            If Me.rbtnHembra.Checked Then
                RecepcCanalesDet.Sexo = SexoEnum.HEMBRA
            Else
                RecepcCanalesDet.Sexo = SexoEnum.MACHO
            End If

            Me.RecepcCanalesDet.Funcion = "I"
            Me.RecepcCanalesDet.Opcion = 0

            If Not Me.RecepcCanalesDet.Guardar() Then
                'Trans.Rollback()
                Return False
            End If

            'clase para el control de inventarios
            Inventario.IdCodAlmacen = Almacen.IdCodAlmacen
            Inventario.IdCodProducto = AlmacenDetalle.IdCodProducto
            Inventario.ExistKilos = AlmacenDetalle.CantKilos
            Inventario.ExistPzas = AlmacenDetalle.CantPzas
            Inventario.EntKilos = AlmacenDetalle.CantKilos
            Inventario.EntPzas = AlmacenDetalle.CantPzas
            Inventario.SalKilos = 0D
            Inventario.SalPzas = 0D
            Inventario.Func = "I"
            Inventario.NumOpc = 1
            Inventario.Año = Now.Year
            Inventario.Mes = Now.Month

            'llama el guardar del inventario de productos
            If Not Inventario.Guardar() Then
                'Trans.Rollback()
                Return False
            End If

            'Guardar los servicios que fueron seleccionados en la tabla MSCServiciosPorSacrificio
            Dim SerXsacrif As EC.ServiciosPorSacrificioEntity
            Dim i As Integer = 0

            'For Each Serv As ServiciosClass In Me.ServiciosC
            '    If CBool(Me.dgvServicios.Rows(i).Cells(Me.clmSeleccion.Index).Value) Then
            '        SerXsacrif = New EC.ServiciosPorSacrificioEntity
            '        SerXsacrif.FolioSacrificio = RecepcCanalesDet.FolioSacrificio
            '        SerXsacrif.FolioCanal = RecepcCanalesDet.IdFolioCanal
            '        SerXsacrif.IdServicio = Serv.Codigo
            '        Trans.Add(SerXsacrif)

            '        If Not SerXsacrif.Save Then
            '            Trans.Rollback()
            '            Return False
            '        End If
            '    End If

            '    i = i + 1
            'Next

            If CerrarLote = True Then
                Dim FolioSacr As String = Me.txtLoteSacrificio.Text

                Me.RegistroSacrificiosCab = New RegistroSacrificiosClass(FolioSacr)

                RegistroSacrificiosCab.Estatus = "C"

                If Not RegistroSacrificiosCab.Guardar() Then
                    'Trans.Rollback()
                    Return False
                End If
            End If

            'Trans.Commit()
            'MessageBox.Show("Se ha guardado la Recepción con el Folio: " & Me.txtLoteSacrificio.Text & Me.txtNoRes.Text & "-" & Me.txtLado.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'If Configproduccion.ImprimirEtiquetasCanales = True Then
            '    Dim Codigo As String = Me.txtLoteSacrificio.Text & Me.txtNoRes.Text & "-" & Me.txtLado.Text

            '    Me.Imprimir(Me.txtNoRes.Text, Me.txtLado.Text, Me.txtKgrsRecibidos.Text, Me.txtNoRes.Text & "-" & Me.txtLado.Text, Codigo)
            'End If

            'Me.txtPeso.Text = "0.00"
            'Me.txtTotalKilos.Text = "0.00"
            'Me.txtKilosRecibidos.Text = "0.00"
            'Me.tmActualizacion.Stop()
            'Me.ObtenerCanales()
            'Me.tmActualizacion.Start()

            HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATIDE", "MEATLA20")
            Return True
        Catch ex As Exception
            'Trans.Rollback()
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Limpiar()
        'Me.GroupBox1.Enabled = False
        Me.txtLado.Text = "1"
        Me.txtLoteSacrificio.Text = ""
        txtLoteCorteRastro.Clear()
        Me.txtNoRes.Text = "1"
        Me.txtPeso.Text = "0.00"
        Me.txtTotalCanales.Text = "0"
        Me.txtTotalKilos.Text = "0"
        Me.txtProductor.Text = ""
        'Me.dtpFechaSacrificio.Value = Now
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = False
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True

        For i As Integer = 0 To Me.dgvServicios.Rows.Count - 1
            Me.dgvServicios.Rows(i).Cells(Me.clmSeleccion.Index).Value = False
        Next

        Me.leerbascula = True
        Me.txtKgrsRecibidos2.Text = "0.000"
        Me.txtKgrsRecibidos2.ReadOnly = True
        Me.txtPeso.Focus()
    End Sub

    Private Function Buscar() As Boolean

    End Function

    Private Function CancelarCanal() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            Dim FolioAlmacen As String
            Dim RecepDetColeccion As New CC.MscrecepcionCanalesDetCollection

            RecepDetColeccion.GetMulti(HC.MscrecepcionCanalesDetFields.FolioSacrificio = Me.txtLoteSacrificio.Text And HC.MscrecepcionCanalesDetFields.IdFolioCanal = Me.dgvCanales.SelectedRows(0).Cells(Me.clmCanal.Index).Value)

            Dim Entidad As EC.MscrecepcionCanalesDetEntity = RecepDetColeccion(0)

            Me.RecepcCanales = New RecepcionCanalesCabClass
            RecepcCanales.FolioMov = Entidad.FolioMovimiento
            RecepcCanales.FolioSacrificio = Entidad.FolioSacrificio
            RecepcCanales.KgrsCalientes = Me.dgvCanales.SelectedRows(0).Cells(Me.clmKilosCalientes.Index).Value
            RecepcCanales.KgrsBascula = Me.dgvCanales.SelectedRows(0).Cells(Me.clmKilosCalientes.Index).Value
            RecepcCanales.Funcion = "M"
            RecepcCanales.Opcion = 4

            If Not RecepcCanales.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            Me.RecepcCanalesDet = New RecepcionCanalesDetClass(Entidad)
            Me.RecepcCanalesDet.Estatus = "X"
            Me.RecepcCanalesDet.Funcion = "M"
            Me.RecepcCanalesDet.Opcion = 2

            If Not Me.RecepcCanalesDet.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'Folio.Codigo = CodigodeFolios.CanEntradasCanalesAlamcen
            Folio.Codigo = CodigodeFolios.MovimientosdeAlmacen
            Folio.Año = Now.Year
            Folio.Mes = Now.ToString("MM")

            If Not Folio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'folio para el registro de movimientos de almacen
            FolioAlmacen = Folio.Año & Folio.Mes & Folio.Codigo & Folio.Consecutivo.ToString("0000")

            Dim Productos As New CC.MsccatProductosCollection

            Productos.GetMulti(HC.MsccatProductosFields.Canal = True)

            Dim Producto As EC.MsccatProductosEntity = Productos(0)

            'Obtener la Configuracion 
            Dim ConfigProd As New CC.UsrProdConfiguracionCollection

            ConfigProd.GetMulti(Nothing)

            Dim Configproduccion As EC.UsrProdConfiguracionEntity = ConfigProd(ConfigProd.Count - 1)

            'asignar datos de almacen a clase de cabecero de almacen 
            Almacen.IdFolioMovimiento = FolioAlmacen
            Almacen.IdCodAlmacen = Configproduccion.IdAlmacenCanales
            Almacen.FechaMovimiento = Me.dtpFechaCaptura.Value
            Almacen.FechaCaptura = Now
            Almacen.IdCodMovimiento = MovtosAlmacen.CanEntradadeCanales
            Almacen.CantKilos = Me.txtPeso.Text
            Almacen.CantPzas = 1
            Almacen.Estatus = "V"
            Almacen.QuienCancelo = ""
            Almacen.QuienContabilizo = ""
            Almacen.ObservacionCancela = ""
            Almacen.NumOpc = 1
            Almacen.Func = "I"

            If Not Almacen.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'clase para el detalle de almacen
            AlmacenDetalle.IdFolioMovimiento = FolioAlmacen
            AlmacenDetalle.IdCodProducto = Producto.IdProducto
            AlmacenDetalle.CantPzas = 1
            AlmacenDetalle.CantKilos = Me.txtPeso.Text
            AlmacenDetalle.CostoUnitario = 0
            AlmacenDetalle.IVA = 0
            'AlmacenDetalle.Estatus = "V"
            AlmacenDetalle.Func = "I"
            AlmacenDetalle.NumOpc = 1

            If Not AlmacenDetalle.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'clase para el control de inventarios
            Inventario.IdCodAlmacen = 1
            Inventario.IdCodProducto = AlmacenDetalle.IdCodProducto
            Inventario.ExistKilos = AlmacenDetalle.CantKilos
            Inventario.ExistPzas = AlmacenDetalle.CantPzas
            Inventario.EntKilos = 0
            Inventario.EntPzas = 0
            Inventario.SalKilos = AlmacenDetalle.CantKilos
            Inventario.SalPzas = AlmacenDetalle.CantPzas
            Inventario.Func = "I"
            Inventario.NumOpc = 2
            Inventario.Año = Now.Year
            Inventario.Mes = Now.Month

            'llama el guardar del inventario de productos
            If Not Inventario.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            Trans.Commit()
            Me.txtLado.Text = CInt(Me.txtLado.Text) + 1

            If CInt(Me.txtLado.Text) = 3 Then
                Me.txtLado.Text = 1
                Me.txtNoRes.Text = CInt(Me.txtNoRes.Text) + 1
            End If

            Me.txtPeso.Text = "0"
            Me.txtTotalKilos.Text = "0"
            Me.ObtenerCanales()
            MessageBox.Show("Se cancelo el canal : " & RegistroSacrificiosDet.FolioCanal, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function ObtenerCanales() As Boolean
        Try
            RecepcCanalesDet = New RecepcionCanalesDetClass
            Canales = Obtener(Me.txtLoteSacrificio.Text, "", 1, "")

            If Canales.Tables(0).Rows.Count > 0 Then
                Me.dgvCanales.AutoGenerateColumns = False
                Me.dgvCanales.DataSource = Canales.Tables(0)
                Me.txtTotalCanales.Text = Me.dgvCanales.Rows.Count

                For i As Integer = 0 To Me.dgvCanales.Rows.Count - 1
                    Dim kgrsCalientes As Decimal
                    Dim KgrsREcibidos As Decimal

                    Me.txtTotalKilos.Text = Me.txtTotalKilos.Text + Me.dgvCanales.Rows(i).Cells(Me.clmKilosRecbidos.Index).Value
                    kgrsCalientes += Me.dgvCanales.Rows(i).Cells(Me.clmKilosCalientes.Index).Value
                    KgrsREcibidos += Me.dgvCanales.Rows(i).Cells(Me.clmKilosRecbidos.Index).Value

                    If i = Me.dgvCanales.Rows.Count - 1 Then
                        Me.txtTotalKgrsCalientes.Text = kgrsCalientes.ToString("N3")
                        Me.txtTotalKilos.Text = KgrsREcibidos.ToString("N3")
                    End If
                Next
            Else
                Me.dgvCanales.AutoGenerateColumns = False
                Me.dgvCanales.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Sub CalcularResLado()
        Dim conf As New CC.UsrProdConfiguracionCollection

        conf.GetMulti(Nothing)

        If conf.Count = 0 Then
            MsgBox("Debe ingresar una configuración de producción", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If

        If conf(0).ObtenerCanalEntradaCanalAlmacen Then
            Me.txtNoRes.ReadOnly = True
            Me.txtLado.ReadOnly = True

            'se cambio condigo para saber en que numero de animal y lado va el conteo de canales que se estan guardando.
            Me.txtNoRes.Text = CInt(Me.txtTotalCanales.Text) / NumLados

            If Me.txtNoRes.Text Mod NumLados Then
                If CDec(Me.txtNoRes.Text) - Math.Truncate(CDec(Me.txtNoRes.Text)) = 0 Then
                    Me.txtNoRes.Text = Me.txtNoRes.Text + 1
                    Me.txtLado.Text = 1
                Else
                    Me.txtNoRes.Text = Math.Round(CDec(Me.txtNoRes.Text), 0, MidpointRounding.AwayFromZero)
                    Me.txtLado.Text = txtLado.Text + 1
                End If
            Else
                Me.txtNoRes.Text = Me.txtNoRes.Text + 1
                Me.txtLado.Text = 1
            End If
        Else
            Me.txtNoRes.ReadOnly = False
            Me.txtLado.ReadOnly = False
        End If
    End Sub

    Private Function Obtener(ByVal FolioLote As String, ByVal IdFolioCanal As String, ByVal Opc As Integer, ByVal loteCorte As String) As DataSet
        Dim Con As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Dim Ds As New DataSet

        Try
            Dim Comando As New SqlCommand("UspCon_MSCRecepcionCanalesDet", Con)
            Comando.CommandType = CommandType.StoredProcedure


            Dim IdFolioLote As New SqlParameter("@FolioLote", SqlDbType.VarChar)

            IdFolioLote.Value = FolioLote
            Comando.Parameters.Add(IdFolioLote)

            Dim FolioCanal As New SqlParameter("@IdFolioCanal", SqlDbType.VarChar)

            FolioCanal.Value = IdFolioCanal
            Comando.Parameters.Add(FolioCanal)

            Dim Opcion As New SqlParameter("@Opcion", SqlDbType.Int)

            Opcion.Direction = ParameterDirection.Input
            Opcion.Value = Opc
            Comando.Parameters.Add(Opcion)

            Comando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Now
            Comando.Parameters.Add("@LoteCorte", SqlDbType.VarChar).Value = loteCorte

            Dim Adapter As New SqlDataAdapter(Comando)

            Con.Open()
            Adapter.Fill(Ds)
            Con.Close()

            Return Ds
        Catch ex As Exception
            Return Ds
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Con.Close()
        End Try
    End Function

    Private Sub Imprime_Documento(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Try
            'generadorCodigoBarra.Message = codigoBarras

            e.PageSettings.PaperSize = New Printing.PaperSize("Etiqueta", 406, 406)

            e.Graphics.DrawString("Folio Canal: ", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 5, 20)
            e.Graphics.DrawString(noRes & "-" & lado, New Font("Arial", 14), Brushes.Black, 140, 20)

            e.Graphics.DrawString("No Res: ", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 5, 45)
            e.Graphics.DrawString(noRes, New Font("Arial", 14), Brushes.Black, 90, 45)

            e.Graphics.DrawString("Lado: ", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 120, 45)
            e.Graphics.DrawString(lado, New Font("Arial", 14), Brushes.Black, 180, 45)

            e.Graphics.DrawString("Peso: ", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 5, 70)
            e.Graphics.DrawString(peso.ToString("N3") & " Kgs", New Font("Arial", 16), Brushes.Black, 70, 70)

            'e.Graphics.DrawImage(generadorCodigoBarra.Picture, 5, 95, 166, 100)
            'e.Graphics.DrawImage(generadorCodigoBarra.Picture, 5, 200, 166, 100)

            'e.Graphics.DrawString("Folio Canal: ", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, 210)
            'e.Graphics.DrawString(noRes & "-" & lado, New Font("Arial", 14), Brushes.Black, 300, 210)

            'e.Graphics.DrawString("No Res: ", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, 240)
            'e.Graphics.DrawString(noRes, New Font("Arial", 14), Brushes.Black, 180, 240)

            'e.Graphics.DrawString("Lado: ", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 230, 240)
            'e.Graphics.DrawString(lado, New Font("Arial", 14), Brushes.Black, 290, 240)

            'e.Graphics.DrawString("Peso: ", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 100, 270)
            'e.Graphics.DrawString(peso.ToString("N3") & " Kgs", New Font("Arial", 16), Brushes.Black, 200, 270)

            'e.Graphics.DrawImage(generadorCodigoBarra.Picture, 100, 310, 100, 390)

            nPag += 1

            If nPag < 1 Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            e.HasMorePages = False
        End Try
    End Sub

    Private Sub Imprimir(ByVal noRes As Integer, ByVal lado As Integer, ByVal peso As Decimal, ByVal folioCanal As String, ByVal CodigoBarras As String)
        Try
            Me.noRes = noRes
            Me.lado = lado
            Me.peso = peso
            Me.folioCanal = folioCanal
            Me.codigoBarras = CodigoBarras

            'Dim prev As New PrintDialog

            Me.pdDocumento.Print()
            'If prev.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    ppdVisor.WindowState = FormWindowState.Maximized
            '    ppdVisor.ShowDialog(Me)
            'End If

            'Dim generadorCodigoBarra As New AxTALBarCode.AxTALBarCd

            'generadorCodigoBarra.Message = CodigoBarras


            'Dim Reporte As New RptEtiquetaCanal

            'Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
            'Reporte.SetParameterValue("Introductor", Me.txtProductor.Text)
            'Reporte.SetParameterValue("Lote", Me.txtLoteSacrificio.Text)
            'Reporte.SetParameterValue("PesoCanal", Me.txtPeso.Text)

            'Dim FolioCanal As String = Me.txtNoRes.Text & " - " & Me.txtLado.Text

            'Reporte.SetParameterValue("FolioCanal", FolioCanal)
            'Reporte.SetParameterValue("CodigoBarras", CodigoBarras)

            'Dim VerReporte As New FrmReportes

            'VerReporte.CRV.ReportSource = Reporte
            ''VerReporte.CRV.PrintReport()
            'VerReporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function LeerPeso() As Boolean
        Try
            If Not Me.leerbascula Then Return True

            Me.txtKgrsRecibidos2.Text = ClasesNegocio.LecturaBasculaClass.Leer("COM1", LecturaBasculaClass.TipoLectura.GRAMOS, LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2")

            If CDec(Me.txtKgrsRecibidos2.Text) = 0D AndAlso MessageBox.Show("No se logro leer el peso. ¿Quiere teclear el peso?", "Peso no leido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.txtKgrsRecibidos2.ReadOnly = False
                Me.txtKgrsRecibidos2.Focus()

                Return False
            Else
                Me.txtKgrsRecibidos2.ReadOnly = True
                Me.txtPeso.Focus()
            End If

            Return True
        Catch ex As Exception

        End Try
    End Function

    Private Sub ConfigurarPuerto()
        txtKgrsRecibidos2.Port = 1 'Abro el com2
        txtKgrsRecibidos2.BaudRate = 9600 '9600 bits por segundo
        txtKgrsRecibidos2.DataBit = 8  '8 bits de datos
        txtKgrsRecibidos2.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1 'Un bit de parada
        txtKgrsRecibidos2.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None 'No paridad
        txtKgrsRecibidos2.TimeOut = 1500 'Esperar 1500 milisegundos antes de considerar time out

        'Esperar 300 milisegundos para dar tiempo a que llegue un grupo de bytes.
        'A menor tiempo menor es el número de bytes que llegan en cada llamada del evento SerialDataArrived.
        'Por ejemplo un lector que envia 14 bytes podrian llegar en la primer llamada al evento 7 caracteres y 
        'en otra llamada otros 7. Dando mayor tiempo damos oportunidad a que lleguen los 14 bytes juntos.
        txtKgrsRecibidos2.TimeToWaitForMoreData = 500

        'Puede mostrar la información con formato Ascii, Hexadecimal o Decimal. 
        'Por ejemplo si se recibe la cadena HOLA la salida sería:
        'ASCII: HOLA
        'Decimal:  072079076065
        'Hexadecimal: 484F4C41
        txtKgrsRecibidos2.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii 'Formato en que se mostrará la información
    End Sub
#End Region

#Region "Eventos"
#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            'If Not Buscar() Then
            '    MessageBox.Show("No se encuentran recepciones de ganado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
            'nos permitira seleccionar diferentes folios de sacrificio si es que recibimos canales para deshuese
            If Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos Then
                Dim Consultas As New ReporteRegistroSacrificios

                Consultas.Text = "Seleccione lote de sacrificio para captura de canales"
                Consultas.Label17.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE CANALES"

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.RegistroSacrificiosCab = Consultas.Sacrificio
                    Me.Gb.Enabled = True
                Else
                    For Each control As Control In Me.Controls
                        control.Enabled = False
                    Next

                    Me.mtb.Enabled = True

                    Exit Sub
                End If

                Me.Limpiar()
                ObtenerSacrificios(1)
            Else
                Me.Limpiar()
                ObtenerSacrificios(2)
            End If
            'obtener canales para este lote de sacrificio
            '' Obtener()
            Me.ObtenerCanales()
            TotalCanalesLotes()
            'para combo de clientes, es decir a donde se envia ese canal
            Dim AuxClientesCol As New ClientesIntroductoresColeccion

            AuxClientesCol.Obtener(CondicionEstatusEnum.ACTIVO)

            Dim ClientesCol As New ClientesIntroductoresColeccion
            Dim Cliente As New ClientesIntroductoresClass

            Cliente.Nombre = "NINGUNO"
            ClientesCol.Add(Cliente)

            For Each Cli As ClientesIntroductoresClass In AuxClientesCol
                ClientesCol.Add(Cli)
            Next

            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "Codigo"
            Me.CmbCliente.DataSource = ClientesCol
            Me.CmbCliente.SelectedIndex = 0

            Me.ServiciosC.Obtener(TipoServicionEnum.PRODUCCION)
            Me.tmActualizacion.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = False
        Me.mtb.HabilitarSalir = True
        Me.Gb.Enabled = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        'If Not Guardar() Then
        '    MessageBox.Show("No se pudo guardar la Recepción de canal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    MessageBox.Show("Se guardo Recepción con el folio : " & Me.txtLoteSacrificio.Text, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        'Me.Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Limpiar()
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = False
        Me.mtb.HabilitarSalir = True
        Me.Gb.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

#Region "Form"
    Private Sub FrmRecepcionCanales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'nos permitira seleccionar diferentes folios de sacrificio si es que recibimos canales para deshuese
            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos Then
                Dim Consultas As New ReporteRegistroSacrificios
                Consultas.Text = "Seleccione lote de sacrificio para captura de canales"
                Consultas.Label17.Text = "SELECCIONE LOTE DE SACRIFICIO PARA CAPTURA DE CANALES"

                Consultas.rbtActivos.Checked = True
                Consultas.grpEstatus.Enabled = False

                If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.RegistroSacrificiosCab = Consultas.Sacrificio
                Else
                    For Each control As Control In Me.Controls
                        control.Enabled = False
                    Next

                    Me.mtb.Enabled = True

                    Exit Sub
                End If

                Me.Limpiar()
                ObtenerSacrificios(1)
            Else
                Me.Limpiar()
                ObtenerSacrificios(2)
            End If

#If DEBUG Then
            lblCostoXKilo.Visible = True
#End If

            'obtener canales para este lote de sacrificio
            '' Obtener()
            Me.ObtenerCanales()
            TotalCanalesLotes()
            Me.CalcularResLado()

            'para combo de clientes, es decir a donde se envia ese canal
            Dim AuxClientesCol As New ClientesIntroductoresColeccion

            AuxClientesCol.Obtener(CondicionEstatusEnum.ACTIVO)

            Dim ClientesCol As New ClientesIntroductoresColeccion
            Dim Cliente As New ClientesIntroductoresClass

            Cliente.Nombre = "NINGUNO"
            ClientesCol.Add(Cliente)

            For Each Cli As ClientesIntroductoresClass In AuxClientesCol
                ClientesCol.Add(Cli)
            Next

            Me.CmbCliente.DisplayMember = "Nombre"
            Me.CmbCliente.ValueMember = "Codigo"
            Me.CmbCliente.DataSource = ClientesCol
            Me.CmbCliente.SelectedIndex = 0

            'Me.ServiciosC.Obtener(TipoServicionEnum.PRODUCCION)

            AddHandler pdDocumento.PrintPage, AddressOf Imprime_Documento
            ppdVisor.Document = pdDocumento

            Me.ConfigurarPuerto()
            Me.tmActualizacion.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Caja de Texto"
    Private Sub txtPeso_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeso.GotFocus
        Me.txtPeso.SelectAll()
    End Sub

    Private Sub txtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim RecepDetCol As New CC.MscrecepcionCanalesDetCollection
            Dim Consecutivo As Integer
            Dim numCanales As Integer = RecepDetCol.GetDbCount(HC.MscrecepcionCanalesDetFields.FolioSacrificio = Me.txtLoteSacrificio.Text.Trim)

            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                MsgBox("Debe establecer una configuración de producción antes de realizar una entrada de canal a almacén", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            'If conf(0).ObtenerCanalAutomaticamente Then
            Consecutivo = RecepDetCol.GetDbCount(HC.MscrecepcionCanalesDetFields.FolioSacrificio = Me.txtLoteSacrificio.Text)
            'Else
            If Me.txtNoRes.Text.Trim = "" Then
                MsgBox("Debe ingresar un numero de pieza", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf Me.txtLado.Text.Trim = "" Then
                MsgBox("Debe ingresar un lado de la pieza", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf CInt(Me.txtNoRes.Text) <= 0 Then
                MsgBox("Debe ingresar un numero de pieza mayor a 0", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf CInt(Me.txtNoRes.Text) > CInt(Me.txtCantCanales.Text) Then
                MsgBox("Debe ingresar un numero de pieza menor a la cantidad de cabezas del sacrificio", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf CInt(Me.txtLado.Text) <= 0 Then
                MsgBox("Debe ingresar un numero de lado mayor a 0", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf CInt(Me.txtLado.Text) > 2 Then
                MsgBox("Debe ingresar un numero de lado menor o igual a 2", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            If RecepDetCol.GetDbCount(HC.MscrecepcionCanalesDetFields.FolioSacrificio = Me.txtLoteSacrificio.Text.Trim And _
            (HC.MscrecepcionCanalesDetFields.IdFolioCanal = Me.txtNoRes.Text & "-" & Me.txtLado.Text.Trim Or _
            HC.MscrecepcionCanalesDetFields.IdFolioCanal = Me.txtNoRes.Text.PadLeft(3, "0") & "-" & Me.txtLado.Text.Trim)) > 0 Then
                MsgBox("El Numero de Pieza y Lado ya estan recepcionados", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If
            'End If

            If numCanales >= CInt(Me.txtCantCanales.Text) Then
                MessageBox.Show("Ya se han capturado todos los canales/combos de este lote de sacrifico/embarque. El lote de sacrifico/embarque esta cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Not Me.txtPeso.Text > 0 Then
                MessageBox.Show("Ingrese una cantidad mayor a cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Not IsNumeric(Me.txtKgrsRecibidos.Text) OrElse Not CDec(Me.txtKgrsRecibidos.Text) > 0 Then
                MsgBox("Ingrese los kilogramos recibidos", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtKgrsRecibidos.Focus()
                Me.txtKgrsRecibidos.SelectAll()
                Exit Sub
            End If

            If Not IsNumeric(Me.txtPeso.Text) Then
                MsgBox("Debe ingresar un peso", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
                'ElseIf Not (CDec(Me.txtPeso.Text) > 10 AndAlso CDec(Me.txtPeso.Text) < 350) Then
                '    MsgBox("El peso de la canal debe ser entre el rango de 50 a 350 Kgs.", MsgBoxStyle.Exclamation, "Aviso")
                '    Exit Sub
            End If

            If Not IsNumeric(Me.txtKgrsRecibidos.Text) Then
                MsgBox("Debe ingresar un peso", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
                'ElseIf Not (CDec(Me.txtKgrsRecibidos.Text) > 10 AndAlso CDec(Me.txtKgrsRecibidos.Text) < 350) Then
                '    MsgBox("El peso de la canal debe ser entre el rango de 50 a 350 Kgs.", MsgBoxStyle.Exclamation, "Aviso")
                '    Exit Sub
            End If

            If numCanales = CInt(Me.txtCantCanales.Text) - 1 Then
                If MessageBox.Show("Este es el ultimo Canal del lote, al guardarlo se cerrara el lote de sacrifico/embarque. ¿Desea guardarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If Not Me.Guardar(Consecutivo, True) Then
                        MessageBox.Show("No se logró guardar la Recepción, Intentelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    Else
                        Me.txtKgrsRecibidos.Text = "0.00"
                        'Me.txtKgrsRecibidos2.ReadOnly = True
                        Me.txtKilosCalientes.Clear()
                        Me.txtPeso.SelectAll()
                        Me.TotalCanalesLotes()
                        Me.leerbascula = True

                        If Controlador.Configuracion.Produccion.ObtenerCanalAutomaticamente Then
                            Me.txtPeso.Focus()
                            Me.txtPeso.SelectAll()
                        Else
                            Me.txtNoRes.Focus()
                            Me.txtNoRes.SelectAll()
                        End If
                    End If
                Else
                    Exit Sub
                End If
            Else
                If Not Me.Guardar(Consecutivo) Then
                    MessageBox.Show("No se logró guardar la Recepción, Inténtelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    Me.txtKgrsRecibidos.Text = "0.00"
                    'Me.txtKgrsRecibidos.ReadOnly = True
                    Me.txtKilosCalientes.Clear()
                    Me.txtPeso.SelectAll()
                    Me.TotalCanalesLotes()
                    Me.leerbascula = True

                    If Controlador.Configuracion.Produccion.ObtenerCanalAutomaticamente Then
                        Me.CalcularResLado()
                        Me.txtPeso.Focus()
                        Me.txtPeso.SelectAll()
                    Else
                        Me.txtNoRes.Focus()
                        Me.txtNoRes.SelectAll()
                    End If
                End If
            End If
        End If

        If (Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = ".") OrElse _
            (e.KeyChar = "."c AndAlso Me.txtPeso.Text.IndexOf(".") > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKgrsRecibidos_SerialDataArrived(ByVal sender As System.Object, ByVal e As wclTextBoxSerial.SerialDataArrivedEventArgs) Handles txtKgrsRecibidos2.SerialDataArrived
        'MsgBox(e.Data.Length)
        'En e.Data esta el grupo de caracteres recibidos desde el puerto serial
        If e.Data.Length >= 50 Then 'Si llegan 25 caracteres procesarlos
            Dim res As String = ClasesNegocio.LecturaBasculaClass.ObtenerPeso(e.Data.Substring(0, 50), _
                                LecturaBasculaClass.TipoLectura.GRAMOS, _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2") 'Solo deja pasar 19 caracteres
            Me.txtKgrsRecibidos.Text = res
        Else
            e.Handled = True 'Ignora los caracteres
        End If
    End Sub

    Private Sub txtKgrsRecibidos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKgrsRecibidos.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtKgrsRecibidos.Text = "" Then
                MsgBox("Debe ingresar un peso", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf Me.txtKgrsRecibidos.Text.Trim = "." Then
                MsgBox("Debe ingresar un peso", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf CDec(Me.txtKgrsRecibidos.Text) = 0D Then
                MsgBox("Debe ingresar una cantidad mayor a 0", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            If IsNumeric(Me.txtKgrsRecibidos.Text) Then
                Me.txtKgrsRecibidos.Text = CDec(Me.txtKgrsRecibidos.Text).ToString("N2")
            End If

            Me.txtPeso_KeyPress(sender, e)
            'Me.txtKgrsRecibidos.ReadOnly = True
        End If

        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(8)) OrElse _
            (e.KeyChar = "."c AndAlso Me.txtKgrsRecibidos.Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivarLectura.CheckedChanged
        Try
            If Me.chkActivarLectura.Checked Then
                'Me.TextBox1.Text = ClasesNegocio.LecturaBasculaClass.ObtenerPeso(String.Format("<9  41290   355{0}<9  41285   355{0}<9  41280   355{0}<9  41280   355{0}<9  41275   355{0}<9  41275   355{0}<9  41275   355{0}<9  41280   3", vbNewLine), LecturaBasculaClass.TipoLectura.GRAMOS, LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2")
                Me.txtKgrsRecibidos2.OpenPort()
                Me.chkActivarLectura.Text = "Lectura de Peso Activada"
                'Me.txtKgrsRecibidos.Enabled = False
                Me.txtKgrsRecibidos.ReadOnly = True
            Else
                Me.txtKgrsRecibidos2.ClosePort()
                Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
                'Me.txtKgrsRecibidos.Enabled = True
                Me.txtKgrsRecibidos.ReadOnly = False
            End If
        Catch UAex As UnauthorizedAccessException
            MsgBox("No se pudo conectar a la bascula, pruebe que este encendida o que no se este usando una lectura de bascula en otra ventana o aplicación", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Grid"
    Private Sub dgvCanales_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCanales.CellEndEdit
        Try
            If e.ColumnIndex = Me.clmKilosCalientes.Index Then
                With Me.dgvCanales.CurrentRow
                    If Not .Cells(Me.clmKilosCalientes.Index).Value = 0 Then
                        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Modificacion Canal Almacén")

                        Try
                            Dim Consecutivo As Integer = .Cells(Me.clmRegistro.Index).Value
                            Dim FolioMov As String = .Cells(Me.clmFolioMov.Index).Value
                            Dim FolioCanal As String = .Cells(Me.clmCanal.Index).Value
                            Dim idAlmacenCanal, idProductoCanal As Integer
                            Dim ConfigProd As New CC.UsrProdConfiguracionCollection
                            Dim kilos As Decimal = CDec(.Cells(Me.clmKilosCalientes.Index).Value)
                            Dim kilosAnt As Decimal = 0D

                            ConfigProd.GetMulti(Nothing)

                            If Not ConfigProd.Count > 0 Then
                                MessageBox.Show("Seleccione un Almacén para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Exit Sub
                            End If

                            idAlmacenCanal = ConfigProd(0).IdAlmacenCanales

                            'Obtener el codigo del producto canal
                            Dim Productos As New CC.MsccatProductosCollection
                            Productos.GetMulti(HC.MsccatProductosFields.Canal = True)
                            Dim Producto As EC.MsccatProductosEntity = Productos(0)

                            idProductoCanal = Producto.IdProducto

                            Dim EntiCanal As New EC.MscrecepcionCanalesDetEntity

                            trans.Add(EntiCanal)
                            EntiCanal.FetchUsingPK(FolioMov, Me.txtLoteSacrificio.Text, FolioCanal, Consecutivo)
                            EntiCanal.KgrsCalientes = kilos
                            EntiCanal.KgrsBascula = kilos

                            .Cells(Me.clmKilosRecbidos.Index).Value = kilos

                            If Not EntiCanal.Save Then
                                MsgBox("No se logro modificar el peso del canal", MsgBoxStyle.Critical, "Error")
                            End If

                            Dim movCab As New EC.MscmovtosAlmacenCabEntity

                            trans.Add(movCab)

                            kilosAnt = movCab.CantKilos
                            movCab.FetchUsingPK(EntiCanal.IdFolioMovimiento)
                            movCab.CantKilos = kilos

                            movCab.Save()

                            Dim movDet As New EC.MscmovtosAlmacenDetEntity

                            trans.Add(movDet)

                            movDet.FetchUsingPK(EntiCanal.IdFolioMovimiento, idProductoCanal)
                            movDet.CantKilos = kilos

                            movDet.Save()

                            Dim invProd As New EC.MscinventarioProductoEntity

                            trans.Add(invProd)

                            Dim kilosAgregar As Decimal = (kilos - kilosAnt)
                            'pendiente por corregir

                            Inventario.IdCodAlmacen = idAlmacenCanal
                            Inventario.IdCodProducto = idProductoCanal
                            Inventario.ExistKilos = 0
                            Inventario.ExistPzas = 0
                            Inventario.EntKilos = 0
                            Inventario.EntPzas = 0
                            Inventario.SalKilos = 0D
                            Inventario.SalPzas = 0D
                            Inventario.Func = "I"
                            Inventario.NumOpc = 1
                            Inventario.Año = Now.Year
                            Inventario.Mes = Now.Month

                            'llama el guardar del inventario de productos
                            If Not Inventario.Guardar(trans) Then
                                trans.Rollback()
                                MsgBox("No se logro guardar la modificación", MsgBoxStyle.Critical, "Error")
                                Exit Sub
                            End If

                            invProd.FetchUsingPK(idAlmacenCanal, idProductoCanal, Now.Year, Now.Month)
                            invProd.ExistKilos = invProd.ExistKilos + kilosAgregar
                            invProd.EntKilos = invProd.EntKilos + kilosAgregar

                            invProd.Save()

                            trans.Commit()

                            Me.dgvCanales.Refresh()
                        Catch ex As Exception
                            trans.Rollback()

#If CONFIG = "Debug" Then
                            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                            MsgBox("Ocurrio un error al editar el canal", MsgBoxStyle.Critical, "Error")
#End If
                        End Try
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvCanales_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCanales.CellEnter
        If Me.dgvCanales.Rows(e.RowIndex).Cells(Me.clmEstatus.Index).Value = "T" Then
            Me.dgvCanales.Rows(e.RowIndex).Cells(Me.clmKilosCalientes.Index).ReadOnly = True
            Me.dgvCanales.Rows(e.RowIndex).Cells(Me.clmKilosRecbidos.Index).ReadOnly = True
        Else
            Me.dgvCanales.Rows(e.RowIndex).Cells(Me.clmKilosCalientes.Index).ReadOnly = False
            Me.dgvCanales.Rows(e.RowIndex).Cells(Me.clmKilosRecbidos.Index).ReadOnly = False
        End If
    End Sub

    Private Sub dgvCanales_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCanales.EditingControlShowing
        If Me.dgvCanales.CurrentCell.ColumnIndex = Me.clmKilosCalientes.Index Then
            RemoveHandler e.Control.KeyPress, AddressOf Numeros
            AddHandler e.Control.KeyPress, AddressOf Numeros
        Else
            RemoveHandler e.Control.KeyPress, AddressOf Numeros
        End If
    End Sub
#End Region

#Region "Otros"
    Private Sub RegistroSacrificiosDet_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles RegistroSacrificiosDet.MensajeError
        MessageBox.Show(mensaje)
    End Sub

    Private Sub Numeros(ByVal Sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar = Chr(8) AndAlso e.KeyChar = "."c Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnLeerPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim antValor As Boolean = Me.leerbascula

        Me.leerbascula = True
        Me.LeerPeso()
        Me.leerbascula = antValor
    End Sub
#End Region
#End Region

    Private Sub dgvCanales_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvCanales.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            Me.tmActualizacion.Stop()

            If Me.dgvCanales.Rows.Count = 0 Then
                Me.tmActualizacion.Start()
                Exit Sub
            End If

            If Me.dgvCanales.CurrentRow.Cells(Me.clmEstatus.Index).Value = "CORTE" Then
                MsgBox("El canal esta en corte, No es posible borrarlo", MsgBoxStyle.Exclamation, "Aviso")
                Me.tmActualizacion.Start()
                Exit Sub
            End If

            If MessageBox.Show("¿Quiere borrar el canal " & Me.dgvCanales.CurrentRow.Cells(Me.clmCanal.Index).Value & " recepcionado?", "Borrar Canal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Borrar Canal")

                Try

                    Dim recepcionCabC As New CC.MscrecepcionCanalesCabCollection
                    Dim recepcionCab As EC.MscrecepcionCanalesCabEntity
                    Dim recepcionDetC As New CC.MscrecepcionCanalesDetCollection
                    Dim kilosBascula As Decimal
                    Dim canal As String
                    Dim kilosCalientes As Decimal
                    Dim recepcionDet As EC.MscrecepcionCanalesDetEntity
                    Dim movimientoCab As New ClasesNegocio.MovimientoAlmacenClass
                    Dim movimientoRecepcion As New EC.MscmovtosAlmacenCabEntity

                    kilosBascula = Me.dgvCanales.CurrentRow.Cells(Me.clmKilosRecbidos.Index).Value
                    kilosCalientes = Me.dgvCanales.CurrentRow.Cells(Me.clmKilosCalientes.Index).Value
                    canal = Me.dgvCanales.CurrentRow.Cells(Me.clmCanal.Index).Value

                    trans.Add(recepcionCabC)
                    recepcionCabC.GetMulti(HC.MscrecepcionCanalesCabFields.FolioMovimiento = _
                                            Me.dgvCanales.CurrentRow.Cells(Me.clmFolioMov.Index).Value And _
                                            HC.MscrecepcionCanalesCabFields.FolioSacrificio = _
                                            Me.txtLoteSacrificio.Text.Trim)
                    recepcionCab = recepcionCabC(0)

                    recepcionCab.KgrsBascula -= kilosBascula
                    recepcionCab.KgrsCalientes -= kilosCalientes

                    trans.Add(recepcionDetC)
                    recepcionDetC.GetMulti(HC.MscrecepcionCanalesDetFields.FolioMovimiento = recepcionCab.FolioMovimiento.Trim And _
                                            HC.MscrecepcionCanalesDetFields.FolioSacrificio = recepcionCab.FolioSacrificio.Trim And _
                                            HC.MscrecepcionCanalesDetFields.IdFolioCanal = canal.Trim)
                    recepcionDet = recepcionDetC(0)

                    trans.Add(recepcionCab)
                    recepcionCab.Save()
                    trans.Add(movimientoRecepcion)
                    movimientoRecepcion.FetchUsingPK(recepcionDet.IdFolioMovimiento)
                    trans.Add(recepcionDet)
                    recepcionDet.Delete()
                    movimientoRecepcion.MscmovtosAlmacenDet.DeleteMulti()
                    movimientoRecepcion.Delete()

                    With movimientoCab
                        .EstablecerAlmacen(MovimientoAlmacenClass.TipoAlmacenEnum.CANAL)
                        .EstablecerTipoMovimiento(InventarioConfigProduccionClass.TipoMovimientoProdEnum.Salida_Canal_X_Cancelacion_Canal_Almacen)
                        .FechaMovimiento = Now
                        .IdPoliza = ""
                        .Kilos = kilosBascula
                        .Piezas = 1
                        .AgregarCanalAlDetalle(kilosBascula, 1, 0, 0)
                    End With

                    If Not movimientoCab.Guardar(trans) Then
                        trans.Rollback()
                        MsgBox("No se logro guardar el movimeinto de almacén", MsgBoxStyle.Exclamation, "Aviso")
                        Me.tmActualizacion.Start()
                        Exit Sub
                    End If

                    trans.Commit()
                    ObtenerCanales()
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    Me.tmActualizacion.Start()
                    Exit Sub
                End Try
            End If

            Me.tmActualizacion.Start()
        End If
    End Sub

    Private Sub tmActualizacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmActualizacion.Tick
        Try
            Me.tmActualizacion.Stop()

            Me.ObtenerCanales()

            Me.tmActualizacion.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtNoRes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoRes.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLado.Focus()
            Me.txtLado.SelectAll()
        End If

        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLado.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPeso.Focus()
            Me.txtPeso.SelectAll()
        End If

        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPeso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeso.LostFocus
        If Me.txtPeso.Text.Trim = "" Then
            Me.txtPeso.Text = 0.ToString("N2")
        ElseIf IsNumeric(Me.txtPeso.Text) Then
            Me.txtPeso.Text = CDec(Me.txtPeso.Text).ToString("N2")
        Else
            Me.txtPeso.Text = 0.ToString("N2")
        End If
    End Sub

End Class