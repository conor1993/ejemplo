Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenSalidaClass
    Inherits ClassBase(Of EC.MinvTransferenciaAlmacenSalidaEntity)

#Region "Miembros"
    ''' <summary>
    ''' Almacena los datos del almacén del que se sacaran los productos
    ''' </summary>
    ''' <remarks></remarks>
    Private m_AlmacenOrigen As AlmacenClass
    ''' <summary>
    ''' Almacena los datos del almacén al que iran los productos
    ''' </summary>
    ''' <remarks></remarks>
    Private m_AlmacenDestino As AlmacenClass
    ''' <summary>
    ''' Almacena los datos del movimiento de almacén 
    ''' que se genera al realizar la transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Private m_MovimientoAlmacen As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Almacena los datos del movimiento de almacén
    ''' que se genera al cancelar la transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Private m_MovimientoAlmacenCancelacion As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Almacena los productos que se transfereiran al almacén destino
    ''' </summary>
    ''' <remarks></remarks>
    Private m_Detalle As TransferenciaAlmacenSalidaDetalleCollectionClass
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Inicializa la clase con los valor por default
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        MyBase.New()
        Me.FechaCancelacion = #1/1/1990#
    End Sub

    ''' <summary>
    ''' Inicializa la clase con los datos contenidos en la entity ingresada
    ''' </summary>
    ''' <param name="entidad">Entity con los datos de la transferencia</param>
    ''' <remarks></remarks>
    Sub New(ByVal entidad As EC.MinvTransferenciaAlmacenSalidaEntity)
        MyBase.New(entidad)
    End Sub

    ''' <summary>
    ''' Inicializa la clase y obtiene los datos de la transferencia con el folio ingresado
    ''' </summary>
    ''' <param name="folioTransferencia"></param>
    ''' <remarks></remarks>
    Sub New(ByVal folioTransferencia As String)
        MyBase.New(New EC.MinvTransferenciaAlmacenSalidaEntity(folioTransferencia))
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el folio de transferencia de la salida de productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioTransferencia() As String
        Get
            Return Entity.FolioTransferencia
        End Get
        Set(ByVal value As String)
            Entity.FolioTransferencia = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del almacén al que se enviaran los productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IdAlmacenDestino() As Integer
        Get
            Return Entity.IdAlmacenDestino
        End Get
        Set(ByVal value As Integer)
            Entity.IdAlmacenDestino = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el almacén al que se enviaran los productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AlmacenDestino() As AlmacenClass
        Get
            If m_AlmacenDestino Is Nothing Then
                m_AlmacenDestino = New AlmacenClass(Entity.AlmacenDestino)
            ElseIf Not m_AlmacenDestino.Codigo = IdAlmacenDestino Then
                m_AlmacenDestino.LeerEntidad(Entity.AlmacenDestino)
            End If

            Return m_AlmacenDestino
        End Get
        Set(ByVal value As AlmacenClass)
            m_AlmacenDestino = value

            If value Is Nothing Then

            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha en que se realizo la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaMovimiento() As Date
        Get
            Return Entity.FechaMovimiento
        End Get
        Set(ByVal value As Date)
            Entity.FechaMovimiento = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha en que se captura la transferecia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Private Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    ''' <summary>
    ''' Otiene o establece la el numero de productos que se transfieren
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TotalProductos() As Decimal
        Get
            Return Entity.TotalProductos
        End Get
        Set(ByVal value As Decimal)
            Entity.TotalProductos = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo total de los productos en la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el estatus de la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Estatus() As EstatusTransferenciaSalida
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusTransferenciaSalida)
            Entity.Estatus = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del almcén de donde salen los productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IdAlmacenOrigen() As Integer
        Get
            Return Entity.IdAlmacenOrigen
        End Get
        Set(ByVal value As Integer)
            Entity.IdAlmacenOrigen = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el almacén de donde salen los productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AlmacenOrigen() As AlmacenClass
        Get
            If m_AlmacenOrigen Is Nothing Then
                m_AlmacenOrigen = New AlmacenClass(Entity.AlmacenOrigen)
            ElseIf Not m_AlmacenOrigen.Codigo = IdAlmacenOrigen Then
                m_AlmacenOrigen.LeerEntidad(Entity.AlmacenOrigen)
            End If

            Return m_AlmacenOrigen
        End Get
        Set(ByVal value As AlmacenClass)
            m_AlmacenOrigen = value

            If value Is Nothing Then
                Entity.AlmacenOrigen = Nothing
            Else
                Entity.AlmacenOrigen = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha de cancelación de la transferencia en caso de estar cancelada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del usuario que cancelo la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IdUsuarioCancelacion() As Integer
        Get
            Return Entity.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio de movimiento del almacén que se genera al realizar la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioMovimientoAlmacen() As String
        Get
            Return Entity.FolioMovimiento
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimiento = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el movimiento de almacen que se genera al realizar la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MovimientoAlmacen() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If m_MovimientoAlmacen Is Nothing Then
                m_MovimientoAlmacen = New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen)
            ElseIf Not m_MovimientoAlmacen.IdAlmacen = IdAlmacenOrigen OrElse _
                    Not m_MovimientoAlmacen.FolioMovimientoAlmacen.Trim = Me.FolioMovimientoAlmacen.Trim Then
                m_MovimientoAlmacen.Entidad = Entity.InventarioMovimientoAlmacen
            End If

            Return m_MovimientoAlmacen
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            m_MovimientoAlmacen = value

            If value Is Nothing Then
                Entity.InventarioMovimientoAlmacen = Nothing
            Else
                Entity.InventarioMovimientoAlmacen = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio de movimeinto de almacén que se genera al cancelar la transferencia
    ''' en caso de estar cancelada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioMovimeintoAlmacenCancelacion() As String
        Get
            Return Entity.FolioMovimientoCancelacion
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el movimiento de almacén de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MovimientoAlmacenCancelacion() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoAlmacenCancelacion Is Nothing Then
                Me.m_MovimientoAlmacenCancelacion = New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen_)
            ElseIf Not Me.m_MovimientoAlmacenCancelacion.IdAlmacen = Me.IdAlmacenOrigen AndAlso _
                    Not Me.m_MovimientoAlmacenCancelacion.FolioMovimientoAlmacen.Trim = Me.FolioMovimeintoAlmacenCancelacion.Trim Then
                Me.m_MovimientoAlmacenCancelacion.Entidad = Entity.InventarioMovimientoAlmacen_
            End If

            Return Me.m_MovimientoAlmacenCancelacion
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimientoAlmacenCancelacion = value

            If value Is Nothing Then
                Entity.InventarioMovimientoAlmacen_ = Nothing
            Else
                Entity.InventarioMovimientoAlmacen_ = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el detalle de la transferencia con el listado de productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Detalle() As TransferenciaAlmacenSalidaDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New TransferenciaAlmacenSalidaDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.MinvTransferenciaAlmacenSalidaDetalle)
            End If

            Return m_Detalle
        End Get
        Private Set(ByVal value As TransferenciaAlmacenSalidaDetalleCollectionClass)
            m_Detalle = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del usuario que realizo la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAlta = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece quien entrega los productos de la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Entrega() As String
        Get
            Return Entity.Entrega
        End Get
        Set(ByVal value As String)
            Entity.Entrega = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece quien recibe los productos de la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Recibe() As String
        Get
            Return Entity.Recibe
        End Get
        Set(ByVal value As String)
            Entity.Recibe = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece las observaciones hechas a la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(False, False, False, 250), _
    ComponentModel.Description("Contiene las observaciones hechas a la transferencia")> _
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public Property Total() As Decimal
        Get
            Return Entity.Total
        End Get
        Set(ByVal value As Decimal)
            Entity.Total = value
        End Set
    End Property

    Public Property Iva() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal folioTransferencia As String) As Boolean
        Try
            Return Entidad.FetchUsingPK(folioTransferencia)
        Catch ex As Exception
            MsgBox("Ocurrio un error al consultar la transferencia", MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transferencia Salida")

        Try
            If Entidad.IsNew Then
                Dim folio As New FoliosClass

                folio.Año = Now.Year
                folio.Mes = Now.Month
                folio.Codigo = CodigodeFolios.TransferenciaAlmacenGeneralSalida

                If Not folio.Guardar(trans) Then
                    trans.Rollback()
                    MsgBox("No se logro generar un folio para la transferencia", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Me.FolioTransferencia = String.Format("{0}-{1}", Now.ToString("MMyy"), folio.Consecutivo.ToString("0000000"))

                trans.Add(Entity)

                Me.MovimientoAlmacen.Guardar(trans)

                Entity.Save()

                Detalle.Guardar(trans)

                trans.Commit()

                Return True
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Shadows Function Borrar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelacion Salida Transferencia")

        Try
            If Estatus = EstatusTransferenciaSalida.CANCELADA Then
                MsgBox("La transferencia ya esta cancelada", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Dim mov As New AlmacenGeneral.MovimientoAlmacenClass

            trans.Add(Entity)
            Estatus = EstatusTransferenciaSalida.CANCELADA

            mov.IdAlmacen = Me.IdAlmacenOrigen
            mov.Referencia = Me.FolioMovimientoAlmacen
            mov.TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cancelacion_Traspaso
            mov.FechaMovimiento = Now
            mov.Entidad.Origen = ""
            mov.IdUsuarioAlta = Me.IdUsuarioCancelacion
            mov.Entidad.EstatusContabilizado = 0

            For Each movdet As AlmacenGeneral.MovimientoAlmacenDetalleClass In Me.MovimientoAlmacen.Detalle
                mov.Detalle.Add(mov, movdet.Indice, movdet.IdProducto, Now, movdet.Cantidad, _
                                movdet.Costo, movdet.Descuento, movdet.Lote, movdet.FechaCaducidad)
            Next

            mov.Guardar(trans)

            Me.FolioMovimeintoAlmacenCancelacion = mov.FolioMovimientoAlmacen

            Entidad.Save()
            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
            Entity.Refetch()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub Imprimir(ByVal empresa As String)
        Try
            Dim vent As New PreVisualizarForm
            Dim reporte As New rptSalidasPorTransferencias
            Dim dst As New dstTransferenciasSalidas
            Dim tbCab As dstTransferenciasSalidas.TransferenciaSalidaDataTable = dst.Tables(0)
            Dim tbDet As dstTransferenciasSalidas.TransferenciaSalidaDetalleDataTable = dst.Tables(1)

            vent.Text = "Reporte de Salidas Por Transferencias"

            Dim row As dstTransferenciasSalidas.TransferenciaSalidaRow = tbCab.AddTransferenciaSalidaRow(Me.FolioTransferencia.Trim, _
                                                    Me.AlmacenDestino.Descripcion, Me.AlmacenOrigen.Descripcion, _
                                                    Me.FechaMovimiento, Me.TotalProductos, Me.Importe, _
                                                    Me.Estatus.ToString.Replace("_", " "))

            For Each det As TransferenciaAlmacenSalidaDetalleClass In Me.Detalle
                tbDet.AddTransferenciaSalidaDetalleRow(row, det.Producto.Descripcion, det.Lote, det.Cantidad, det.Importe, det.CostoUnitario, det.IVA)
            Next

            reporte.SetDataSource(dst)
            reporte.SetParameterValue(0, empresa)

            vent.Reporte = reporte

            vent.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Enumeradores"
    ''' <summary>
    ''' Estatus para la salida por transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum EstatusTransferenciaSalida As Short
        CANCELADA = 0S
        EN_TRANSITO
        RECIBIDA
    End Enum
#End Region
End Class