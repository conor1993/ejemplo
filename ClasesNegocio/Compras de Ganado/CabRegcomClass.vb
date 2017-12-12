Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class ComprasGanadoClass
    Inherits ClassBase(Of EC.CabRegComEntity)

    '#Region "Declaraciones"
    '    Private m_Detalle As ComprasGanadoDetalleCollectionClass
    '    Private m_Proveedor As ProveedorClass
    '    Private m_Comprador As CompradoresGanadoClass
    '    Private m_LugarCompra As LugaresDeCompraClass
    '    Private m_Corral As CorralesCabClass
    '    Private m_GastosTransporte As GastoTransporteClass
    '    Private m_MovimeintoGanado As MovimientoGanadoClass
    '    Private m_MovimientoGanadoCancelacion As MovimientoGanadoClass
    '#End Region

    '#Region "Constructores"
    '    Sub New()
    '        Entity = New EC.CabRegComEntity
    '    End Sub

    '    Sub New(ByVal Entidad As EC.CabRegComEntity)
    '        Entity = Entidad
    '    End Sub

    '    Sub New(ByVal Folio As String)
    '        Entity = New EC.CabRegComEntity(Folio)
    '    End Sub
    '#End Region

    '#Region "Propiedades"
    '    Public Property Folio() As String
    '        Get
    '            Return Entity.FolRecep
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.FolRecep = value
    '        End Set
    '    End Property

    '    Public Property GastosTransporte() As GastoTransporteClass
    '        Get
    '            If Me.m_GastosTransporte Is Nothing Then
    '                m_GastosTransporte = New GastoTransporteClass(Entity.CabGasTrans)
    '            ElseIf Not m_GastosTransporte.Folio.Trim = Folio.Trim Then
    '                m_GastosTransporte.Entidad = Entity.CabGasTrans
    '            End If

    '            Return m_GastosTransporte
    '        End Get
    '        Set(ByVal value As GastoTransporteClass)
    '            m_GastosTransporte = value

    '            If value Is Nothing Then
    '                Entity.CabGasTrans = Nothing
    '            Else
    '                Entity.CabGasTrans = value.Entidad
    '            End If
    '        End Set
    '    End Property

    '    Public Property FechaRecepcion() As Date
    '        Get
    '            Return Entity.FecRecep
    '        End Get
    '        Set(ByVal value As Date)
    '            Entity.FecRecep = value
    '        End Set
    '    End Property

    '    Public Property IdProveedor() As Short
    '        Get
    '            Return Entity.CveProveGan
    '        End Get
    '        Set(ByVal value As Short)
    '            Entity.CveProveGan = value
    '        End Set
    '    End Property

    '    Public Property Proveedor() As ProveedorClass
    '        Get
    '            If m_Proveedor Is Nothing Then
    '                m_Proveedor = New ProveedorClass(Entity.Proveedor)
    '            ElseIf Not m_Proveedor.Codigo = Me.IdProveedor Then
    '                m_Proveedor.Entidad = Entity.Proveedor
    '            End If

    '            Return m_Proveedor
    '        End Get
    '        Set(ByVal value As ProveedorClass)
    '            m_Proveedor = value

    '            If value Is Nothing Then
    '                Entity.Proveedor = Nothing
    '            Else
    '                Entity.Proveedor = value.Entidad
    '            End If
    '        End Set
    '    End Property

    '    Public ReadOnly Property NombreProveedor() As String
    '        Get
    '            Return Proveedor.RazonSocial
    '        End Get
    '    End Property

    '    Public Property IdLugarCompra() As Integer
    '        Get
    '            Return Entity.CveLugCom
    '        End Get
    '        Set(ByVal value As Integer)
    '            Entity.CveLugCom = value
    '        End Set
    '    End Property

    '    Public Property LugarCompra() As LugaresDeCompraClass
    '        Get
    '            If Me.m_LugarCompra Is Nothing Then
    '                m_LugarCompra = New LugaresDeCompraClass(Entity.CatLugaresDeCompra)
    '            ElseIf Not m_LugarCompra.IdLugarCompra = Me.IdLugarCompra Then
    '                m_LugarCompra.Entidad = Entity.CatLugaresDeCompra
    '            End If

    '            Return m_LugarCompra
    '        End Get
    '        Set(ByVal value As LugaresDeCompraClass)
    '            m_LugarCompra = value

    '            If value Is Nothing Then
    '                Entity.CatLugaresDeCompra = Nothing
    '            Else
    '                Entity.CatLugaresDeCompra = value.Entidad
    '            End If
    '        End Set
    '    End Property

    '    Public Property IdComprador() As Short
    '        Get
    '            Return Entity.CveComiGan
    '        End Get
    '        Set(ByVal value As Short)
    '            Entity.CveComiGan = value
    '        End Set
    '    End Property

    '    Public Property Comprador() As CompradoresGanadoClass
    '        Get
    '            If Me.m_Comprador Is Nothing Then
    '                m_Comprador = New CompradoresGanadoClass(Entity.McgcatCompradoresdeGanado)
    '            ElseIf Not m_Comprador.IdComprador = IdComprador Then
    '                m_Comprador.Entidad = Entity.McgcatCompradoresdeGanado
    '            End If

    '            Return m_Comprador
    '        End Get
    '        Set(ByVal value As CompradoresGanadoClass)
    '            m_Comprador = value

    '            If value Is Nothing Then
    '                Entity.McgcatCompradoresdeGanado = Nothing
    '            Else
    '                Entity.McgcatCompradoresdeGanado = value.Entidad
    '            End If
    '        End Set
    '    End Property

    '    Public Property NumGuias() As Short
    '        Get
    '            Return Entity.NumGuias
    '        End Get
    '        Set(ByVal value As Short)
    '            Entity.NumGuias = value
    '        End Set
    '    End Property

    '    Public Property ImporteXGuia() As Decimal
    '        Get
    '            Return Entity.ImpteXguia
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.ImpteXguia = value
    '        End Set
    '    End Property

    '    Public Property HorasViaje() As Decimal
    '        Get
    '            Return Entity.HorasViaje
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.HorasViaje = value
    '        End Set
    '    End Property

    '    Public Property ImportePredial() As Decimal
    '        Get
    '            Return Entity.ImptePredial
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.ImptePredial = value
    '        End Set
    '    End Property

    '    Public Property PagarImportePredial() As String
    '        Get
    '            Return Entity.BooPredial
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.BooPredial = value
    '        End Set
    '    End Property

    '    Public Property ImporteEducacion() As Decimal
    '        Get
    '            Return Entity.ImpteEduc
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.ImpteEduc = value
    '        End Set
    '    End Property

    '    Public Property PagarImporteEducacion() As String
    '        Get
    '            Return Entity.BooEduc
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.BooEduc = value
    '        End Set
    '    End Property

    '    Public Property KilosRecibidos() As Decimal
    '        Get
    '            Return Entity.PesoEntReal
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.PesoEntReal = value
    '        End Set
    '    End Property

    '    Public Property Cabezas() As Integer
    '        Get
    '            Return Entity.CabezasComp
    '        End Get
    '        Set(ByVal value As Integer)
    '            Entity.CabezasComp = value
    '        End Set
    '    End Property

    '    Public Property KilosComprados() As Decimal
    '        Get
    '            Return Entity.KilosComp
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.KilosComp = value
    '        End Set
    '    End Property

    '    Public Property ImporteCompra() As Decimal
    '        Get
    '            Return Entity.ImpteComp
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.ImpteComp = value
    '        End Set
    '    End Property

    '    Public Property Observaciones() As String
    '        Get
    '            Return Entity.Observaciones
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.Observaciones = value
    '        End Set
    '    End Property

    '    Public Property Cerrado() As String
    '        Get
    '            Return Entity.StaCerrado
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.StaCerrado = value
    '        End Set
    '    End Property

    '    Public Property IdCorral() As String
    '        Get
    '            Return Entity.CveCorral
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.CveCorral = value
    '        End Set
    '    End Property

    '    Public Property Corral() As CorralesCabClass
    '        Get
    '            If m_Corral Is Nothing Then
    '                m_Corral = New CorralesCabClass(Entity.McecatCorralesCab)
    '            ElseIf Not m_Corral.IdCorral.Trim = IdCorral.Trim Then
    '                m_Corral.Entidad = Entity.McecatCorralesCab
    '            End If

    '            Return m_Corral
    '        End Get
    '        Set(ByVal value As CorralesCabClass)
    '            m_Corral = value

    '            If value Is Nothing Then
    '                Entity.McecatCorralesCab = Nothing
    '            Else
    '                Entity.McecatCorralesCab = value.Entidad
    '            End If
    '        End Set
    '    End Property

    '    Public Property DiasCredito() As Byte
    '        Get
    '            Return Entity.DiasCredito
    '        End Get
    '        Set(ByVal value As Byte)
    '            Entity.DiasCredito = value
    '        End Set
    '    End Property

    '    Public Property FechaPago() As Date
    '        Get
    '            Return Entity.FecPago
    '        End Get
    '        Set(ByVal value As Date)
    '            Entity.FecPago = value
    '        End Set
    '    End Property

    '    Public Property NumFactura() As String
    '        Get
    '            Return Entity.NumFactura
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.NumFactura = value
    '        End Set
    '    End Property

    '    Public Property NomBanco() As String
    '        Get
    '            Return Asc(Entity.NomBanco)
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.NomBanco = value
    '        End Set
    '    End Property

    '    Public Property NomSucursal() As String
    '        Get
    '            Return Entity.NomSucursal
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.NomSucursal = value
    '        End Set
    '    End Property

    '    Public Property NumCuenta() As String
    '        Get
    '            Return Entity.NumCuenta
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.NumCuenta = value
    '        End Set
    '    End Property

    '    Public Property FechaConta() As Date
    '        Get
    '            Return Entity.FecConta
    '        End Get
    '        Set(ByVal value As Date)
    '            Entity.FecConta = value
    '        End Set
    '    End Property

    '    Public Property NumPoliza() As String
    '        Get
    '            Return Entity.NumPoliza
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.NumPoliza = value
    '        End Set
    '    End Property

    '    Public Property Comision() As Decimal
    '        Get
    '            Return Entity.ComiXcab
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.ComiXcab = value
    '        End Set
    '    End Property

    '    Public Property Estatus() As EstatusChar
    '        Get
    '            Return Asc(Entity.Status)
    '        End Get
    '        Set(ByVal value As EstatusChar)
    '            Entity.Status = Chr(value)
    '        End Set
    '    End Property

    '    Public Property CostoIndirecto() As Decimal
    '        Get
    '            Return Entity.CostosIndi
    '        End Get
    '        Set(ByVal value As Decimal)
    '            Entity.CostosIndi = value
    '        End Set
    '    End Property

    '    Public Property FolioFactura() As String
    '        Get
    '            Return Entity.FolFactura
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.FolFactura = value
    '        End Set
    '    End Property

    '    Public Property FechaCaptura() As DateTime
    '        Get
    '            Return Entity.FechaCaptura
    '        End Get
    '        Set(ByVal value As DateTime)
    '            Entity.FechaCaptura = value
    '        End Set
    '    End Property

    '    Public Property FolioMovimientoGanado() As String
    '        Get
    '            Return Entity.FolioMovimientoGanado
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.FolioMovimientoGanado = value
    '        End Set
    '    End Property

    '    Public Property MovimientoGanado() As MovimientoGanadoClass
    '        Get
    '            If Me.m_MovimeintoGanado Is Nothing Then
    '                Me.m_MovimeintoGanado = New MovimientoGanadoClass(Entity.CabMovGan)
    '            ElseIf Not Me.m_MovimeintoGanado.FolioMovimeinto.Trim = Me.FolioMovimientoGanado.Trim Then
    '                Me.m_MovimeintoGanado.Entidad = Entity.CabMovGan
    '            End If

    '            Return Me.m_MovimeintoGanado
    '        End Get
    '        Set(ByVal value As MovimientoGanadoClass)
    '            Me.m_MovimeintoGanado = value

    '            If value Is Nothing Then
    '                Entity.CabMovGan = Nothing
    '            Else
    '                Entity.CabMovGan = value.Entidad
    '            End If
    '        End Set
    '    End Property

    '    Public Property FolioMovimientoGanadoCancelacion() As String
    '        Get
    '            Return Entity.FolioMovimientoGanadoCancelacion
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.FolioMovimientoGanadoCancelacion = value
    '        End Set
    '    End Property

    '    Public Property MovimientoGanadoCancelacion() As MovimientoGanadoClass
    '        Get
    '            If Me.m_MovimientoGanadoCancelacion Is Nothing Then
    '                Me.m_MovimientoGanadoCancelacion = New MovimientoGanadoClass(Entity.CabMovGan_)
    '            ElseIf Not Me.m_MovimientoGanadoCancelacion.FolioMovimeinto.Trim = Me.FolioMovimientoGanadoCancelacion Then
    '                Me.m_MovimientoGanadoCancelacion.Entidad = Entity.CabMovGan_
    '            End If

    '            Return Me.m_MovimientoGanadoCancelacion
    '        End Get
    '        Set(ByVal value As MovimientoGanadoClass)
    '            Me.m_MovimientoGanadoCancelacion = value

    '            If value Is Nothing Then
    '                Entity.CabMovGan_ = Nothing
    '            Else
    '                Entity.CabMovGan_ = value.Entidad
    '            End If
    '        End Set
    '    End Property

    '    Public Property TipoComision() As TiposComision
    '        Get
    '            Return Entity.TipoComision
    '        End Get
    '        Set(ByVal value As TiposComision)
    '            Entity.TipoComision = value
    '        End Set
    '    End Property

    '    Public Property FolioRecepcionPesada() As String
    '        Get
    '            Return Entity.FolioRecepcionPesada
    '        End Get
    '        Set(ByVal value As String)
    '            Entity.FolioRecepcionPesada = value
    '        End Set
    '    End Property

    '    Public ReadOnly Property Detalle() As ComprasGanadoDetalleCollectionClass
    '        Get
    '            If m_Detalle Is Nothing Then
    '                m_Detalle = New ComprasGanadoDetalleCollectionClass
    '                m_Detalle.RellenarMe(Entity.DetRegCom)
    '            End If

    '            Return m_Detalle
    '        End Get
    '    End Property
    '#End Region

    '#Region "Metodos"
    '    Public Function Obtener(ByVal Folio As String) As Boolean
    '        Try
    '            Return Entity.FetchUsingPK(Folio)
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        End Try
    '    End Function

    '    Public Shadows Function Guardar() As Boolean
    '        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Compra Ganado")

    '        Try
    '            If Entidad.IsNew Then
    '                Dim folio As New FoliosClass

    '                folio.Año = Now.Year
    '                folio.Mes = Now.Month
    '                folio.Codigo = CodigodeFolios.CompradeGanado

    '                If Not folio.Guardar(trans) Then
    '                    trans.Rollback()
    '                    MsgBox("Ocurrio un error al generar el consecutivo de movimiento de ganado", MsgBoxStyle.Exclamation, "Aviso")
    '                    Return False
    '                End If

    '                Me.CrearMovmientoGanado("G" & folio.Consecutivo.ToString("0000000000"))

    '            Else

    '            End If
    '        Catch ex As Exception
    '            trans.Rollback()
    '            Throw ex
    '        End Try
    '    End Function

    '    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
    '        Try
    '            Dim Nuevo As Boolean = False

    '            If Not Trans Is Nothing Then
    '                Trans.Add(Entity)
    '            Else
    '                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Recepcion de Pesadas")
    '                Trans.Add(Entity)
    '                Nuevo = True
    '            End If

    '            Estatus = EstatusChar.CANCELADO
    '            Entity.Save()

    '            If Nuevo Then
    '                Trans.Commit()
    '            End If
    '            Return True
    '        Catch ex As Exception
    '            Trans.Rollback()
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '            Return False
    '        End Try
    '    End Function

    '    Public Overrides Function ToString() As String
    '        Return Me.Folio.Trim
    '    End Function

    '    Private Sub CrearMovmientoGanado(ByVal folioMovimiento As String)
    '        Dim movimientoGanado As New MovimientoGanadoClass


    '    End Sub
    '#End Region

    '#Region "Enumeradores"
    '    Public Enum TiposComision
    '        SIN_COMISION
    '        CABEZAS
    '        KILOS
    '    End Enum
    '#End Region

End Class

Public Class ComprasGanadoCollectionClass
    Inherits ColleccionBase(Of EC.CabRegComEntity, CC.CabRegComCollection, ComprasGanadoClass)

    Enum TipoImpresion
        Proveedor
        Comisionista
    End Enum

    Public Shared Function Imprimir(ByVal TipoImp As TipoImpresion, _
                    ByVal Session As EC.SesionesEntity, _
                    Optional ByVal Condicion As OC.PredicateExpression = Nothing, _
                    Optional ByVal dtCabecero As DataTable = Nothing) As Boolean
        Try
            ' Declaraciones generales
            Dim ds As DataSet
            Dim dtDetalle As DataTable = Nothing

            ' Obtencion de datos
            ds = New DataSet()

            If dtCabecero Is Nothing Then
                If Condicion Is Nothing Then
                    dtCabecero = CC.CabRegComCollection.GetMultiAsDataTable(Nothing, _
                                0, New OC.SortExpression(New OC.SortClause(HC.CabRegComFields.FechaCaptura, _
                                OC.SortOperator.Ascending)))
                Else
                    dtCabecero = CC.CabRegComCollection.GetMultiAsDataTable(Condicion, 0, Nothing)
                End If
            End If

            Dim Filtro As New OC.PredicateExpression()

            For Each Row As DataRow In dtCabecero.Rows
                Filtro.AddWithOr(HC.DetRegComFields.FolRecep = Row.Item("FolRecep"))
            Next

            dtDetalle = CC.DetRegComCollection.GetMultiAsDataTable(Filtro, _
                        0, New OC.SortExpression(New OC.SortClause(HC.DetRegComFields.CveRenglon, _
                        OC.SortOperator.Ascending)))
            ds.Tables.Add(dtCabecero)
            ds.Tables.Add(dtDetalle)

            ' Aqui se definen las columnas de Proveedor, Comisionista, TipoGanado, Importe, KilosPromxCabeza y PrecioPromxCabeza
            CompletarEstructuraDataSet(ds)
            LlamarReporte(Session, TipoImp, ds)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ' Se proporiona los datos en el reporte y se llama al reporte correpondiene
    Private Shared Sub LlamarReporte(ByVal Session As EC.SesionesEntity, ByVal TipoImp As TipoImpresion, ByVal ds As DataSet)
        Dim vent As New ClasesNegocio.PreVisualizarForm

        If TipoImp = TipoImpresion.Proveedor Then
            Dim rep As New CrRptComprasGanado
            rep.SetDataSource(ds)
            vent.Text = "Reporte de Compras de Ganado"
            rep.SetParameterValue(0, "Compras de Ganado/Reportes/De Compras de Ganado")
            rep.SetParameterValue(1, Session.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, Session.MiEmpresa.Empnom)
            vent.Reporte = rep
        ElseIf TipoImp = TipoImpresion.Comisionista Then
            Dim rep As New CrRptComprasGanadoComi
            rep.SetDataSource(ds)
            vent.Text = "Reporte de Compras de Ganado por Comisionistas"
            rep.SetParameterValue(0, "Compras de Ganado/Reportes/De Compras de Ganado por Comisionistas")
            rep.SetParameterValue(1, Session.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, Session.MiEmpresa.Empnom)
            vent.Reporte = rep
        End If
        vent.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        vent.WindowState = Windows.Forms.FormWindowState.Maximized
        vent.ShowDialog()
    End Sub

    'Aqui se definen las columnas de Proveedor, Comisionista, TipoGanado, Importe, KilosPromxCabeza y PrecioPromxCabeza
    Private Shared Sub CompletarEstructuraDataSet(ByVal ds As DataSet)
        ' Obtener la descripción(Razón Social) del Proveedor
        If Not ds.Tables(0).Columns.Contains("Proveedor") Then
            ds.Tables(0).Columns.Add("Proveedor")

            For Each row As DataRow In ds.Tables(0).Rows
                row.Item("Proveedor") = ProveedorClass.CargarProveedor(row.Item("CveProveGan")).RazonSocial
            Next
        End If

        ' Obtener el Nombre completo del Comisionista
        If Not ds.Tables(0).Columns.Contains("Comisionista") Then
            ds.Tables(0).Columns.Add("Comisionista")

            For Each row As DataRow In ds.Tables(0).Rows
                row.Item("Comisionista") = ComisionistaClass.CargarComisionista(row.Item("CveComiGan")).NombreCompleto
            Next
        End If

        ' Calcular el Importe, el Promedio en Kilos por cabeza, Promedio en Precio por cabeza, y obtener la descripción del Tipo de Ganado
        Dim CampoTipoGanado As Boolean = False
        Dim CampoImporte As Boolean = False
        Dim CampoKilosPromxCabeza As Boolean = False
        Dim CampoPrecioPromxCabeza As Boolean = False

        If Not ds.Tables(1).Columns.Contains("TipoGanado") Then
            ds.Tables(1).Columns.Add("TipoGanado")
            CampoTipoGanado = True
        End If

        If Not ds.Tables(1).Columns.Contains("Importe") Then
            ds.Tables(1).Columns.Add("Importe", Type.GetType("System.Decimal"))
            CampoImporte = True
        End If

        If Not ds.Tables(1).Columns.Contains("KilosPromxCabeza") Then
            ds.Tables(1).Columns.Add("KilosPromxCabeza", Type.GetType("System.Decimal"))
            CampoKilosPromxCabeza = True
        End If

        If Not ds.Tables(1).Columns.Contains("PrecioPromxCabeza") Then
            ds.Tables(1).Columns.Add("PrecioPromxCabeza", Type.GetType("System.Decimal"))
            CampoPrecioPromxCabeza = True
        End If

        For Each row As DataRow In ds.Tables(1).Rows
            If CampoTipoGanado Then
                row.Item("TipoGanado") = TipoGanadoClass.CargarTipoGanado(row.Item("CveGanado")).Descripcion
            End If

            If CampoImporte Then
                Dim Importe As Decimal = Decimal.Parse(row.Item("PrecioXKilo")) * Decimal.Parse(row.Item("CantKilos"))
                row.Item("Importe") = Importe
            End If

            If CampoKilosPromxCabeza Then
                Dim KilosPromedioxCabeza As Decimal = 0

                If Integer.Parse(row.Item("CantCabezas")) <> 0 Then
                    KilosPromedioxCabeza = Decimal.Parse(row.Item("CantKilos")) / Integer.Parse(row.Item("CantCabezas"))
                End If

                row.Item("KilosPromxCabeza") = KilosPromedioxCabeza
            End If

            If CampoPrecioPromxCabeza Then
                Dim PrecioPromedioxCabeza As Decimal = 0

                If Integer.Parse(row.Item("CantCabezas")) <> 0 Then
                    PrecioPromedioxCabeza = Decimal.Parse(row.Item("Importe")) / Integer.Parse(row.Item("CantCabezas"))
                End If

                row.Item("PrecioPromxCabeza") = PrecioPromedioxCabeza
            End If
        Next

        ' Especificación de datos dirigidos al reporte
        ds.Tables(0).TableName = "Cabecero"
        ds.Tables(1).TableName = "Detalle"
    End Sub
End Class