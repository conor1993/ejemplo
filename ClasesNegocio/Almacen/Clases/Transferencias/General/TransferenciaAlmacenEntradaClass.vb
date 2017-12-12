Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenEntradaClass
    Inherits ClassBase(Of EC.MinvTransferenciaAlmacenEntradaEntity)

#Region "Miembros"
    ''' <summary>
    ''' Almacena los datos del almacén al que se le dara entrada los productos
    ''' </summary>
    ''' <remarks></remarks>
    Private m_AlmacenDestino As AlmacenClass
    ''' <summary>
    ''' Almacena los datos del almacén de donde se le dio salida a los productos
    ''' </summary>
    ''' <remarks></remarks>
    Private m_AlmacenOrigen As AlmacenClass
    ''' <summary>
    ''' Almacena los datos de la transferencia con que se les dio salida a los productos
    ''' </summary>
    ''' <remarks></remarks>
    Private m_TransferenciaSalida As TransferenciaAlmacenSalidaClass
    ''' <summary>
    ''' Almacena el detalle de la transferencia con los productos que se transferiran
    ''' </summary>
    ''' <remarks></remarks>
    Private m_Detalle As TransferenciaAlmacenEntradaDetalleCollectionClass
    ''' <summary>
    ''' Almacena los datos del movimiento de almacen que se genera al hacer una transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Private m_MovimientoAlmacen As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Almacena los datos del movimiento de almacen que se genera al cancelar la transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Private m_MovimientoAlmacenCancelacion As AlmacenGeneral.MovimientoAlmacenClass
#End Region

#Region "Constructores"
    ''' <summary>
    ''' inicializa la clase con los valores por default
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Inicializa la clase con los valores de la entity ingresada
    ''' </summary>
    ''' <param name="entidad">Entity con los valores de una transferencia</param>
    ''' <remarks></remarks>
    Sub New(ByVal entidad As EC.MinvTransferenciaAlmacenEntradaEntity)
        MyBase.New(entidad)
    End Sub

    ''' <summary>
    ''' Inicializa la clase y obtiene la transferencia con el folio ingresado
    ''' </summary>
    ''' <param name="folioTransferencia">Folio de la transferencia que quiere obtener</param>
    ''' <remarks></remarks>
    Sub New(ByVal folioTransferencia As String)
        MyBase.New(New EC.MinvTransferenciaAlmacenEntradaEntity(folioTransferencia))
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el folio de tranferencia de entrada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioTranferencia() As String
        Get
            Return Entity.FolioTransferencia
        End Get
        Set(ByVal value As String)
            Entity.FolioTransferencia = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del almacen al que se dara entrada los productos
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
    ''' Obtiene o establece el almacén donde se dara entrada los productos
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
                Entity.AlmacenDestino = Nothing
            Else
                Entity.AlmacenDestino = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha en que se realiza la tranferencia
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
    ''' Obtiene la fecha en que se capturo la tranferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de productos que se encuentran en la tranferencia
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
    ''' Obtiene o establece el costo total de los productos que se encuentran en la tranferencia
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
    ''' Obtiene o establece el estatus en que se ecncuentra la transferencia
    ''' </summary>
    ''' <value>CANCELADA = 0, VIGENTE = 1</value>
    ''' <returns>CANCELADA = 0, VIGENTE = 1</returns>
    ''' <remarks></remarks>
    Public Property Estatus() As EstatusTransferenciaEntrada
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusTransferenciaEntrada)
            Entity.Estatus = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del almacén de donde bienen los productos
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
    ''' Obtiene o establece el almacén del que bienen los productos
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
    ''' Obtiene o establece la fecha en que se cancelo la tranferencia en caso de estar cancelada
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
    ''' Obtiene o establece el código del usuario que cancelo la tranferencia en caso de estar cancelada
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
    ''' Obtiene o establece el folio de tranferencia con que se les dio salida a los productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioTranferenciaSalida() As String
        Get
            Return Entity.FolioTransferenciaSalida
        End Get
        Set(ByVal value As String)
            Entity.FolioTransferenciaSalida = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la transferencia con que se les dio salida a los productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TransferenciaSalida() As TransferenciaAlmacenSalidaClass
        Get
            If m_TransferenciaSalida Is Nothing Then
                m_TransferenciaSalida = New TransferenciaAlmacenSalidaClass(Entity.MinvTransferenciaAlmacenSalida)
            ElseIf Not m_TransferenciaSalida.FolioTransferencia.Trim = FolioTranferenciaSalida.Trim Then
                m_TransferenciaSalida.Entidad = Entity.MinvTransferenciaAlmacenSalida
            End If

            Return m_TransferenciaSalida
        End Get
        Set(ByVal value As TransferenciaAlmacenSalidaClass)
            m_TransferenciaSalida = value

            If value Is Nothing Then
                Entity.MinvTransferenciaAlmacenSalida = Nothing
            Else
                Entity.MinvTransferenciaAlmacenSalida = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del usuario que realizo la tranferencia
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
    ''' Obtiene o establece quien entrega los productos
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
    ''' Obtiene o establece quien recibe los productos
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
    ''' Obtiene el detalle de la entrada por transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Detalle() As TransferenciaAlmacenEntradaDetalleCollectionClass
        Get
            If Me.m_Detalle Is Nothing Then
                Me.m_Detalle = New TransferenciaAlmacenEntradaDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.MinvTransferenciaAlmacenEntradaDetalle)
            End If

            Return m_Detalle
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece las observaciones hechas a la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio del movimiento de almacén que se genera
    ''' al guardar la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioMovimientoAlmacen() As String
        Get
            Return Entity.FolioMovmientoAlmacen
        End Get
        Set(ByVal value As String)
            Entity.FolioMovmientoAlmacen = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el movmiento de almacén que se genera al hacer una ebntrada por transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MovimientoAlmacen() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoAlmacen Is Nothing Then
                Me.m_MovimientoAlmacen = New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen)
            ElseIf Not Me.m_MovimientoAlmacen.FolioMovimientoAlmacen.Trim = Me.FolioMovimientoAlmacen.Trim AndAlso _
                Not Me.m_MovimientoAlmacen.IdAlmacen = Me.IdAlmacenDestino Then
                Me.m_MovimientoAlmacen.Entidad = Entity.InventarioMovimientoAlmacen
            End If

            Return Me.m_MovimientoAlmacen
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimientoAlmacen = value

            If value Is Nothing Then
                Entity.InventarioMovimientoAlmacen = Nothing
            Else
                Entity.InventarioMovimientoAlmacen = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio del movimiento de almacén por la cancelacion de la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioMovimientoAlmacenCancelacion() As String
        Get
            Return Entity.FolioMovmientoAlmacenCancelacion
        End Get
        Set(ByVal value As String)
            Entity.FolioMovmientoAlmacenCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el movimiento de almacén por la cancelacion de la transferencia
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MovimientoAlmacenCancelacion() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoAlmacenCancelacion Is Nothing Then
                Me.m_MovimientoAlmacenCancelacion = New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen_)
            ElseIf Not Me.m_MovimientoAlmacenCancelacion.FolioMovimientoAlmacen.Trim = _
                Me.FolioMovimientoAlmacenCancelacion.Trim AndAlso Me.m_MovimientoAlmacenCancelacion.IdAlmacen = Me.IdAlmacenDestino Then
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
#End Region

#Region "Metodos"
    Public Shadows Function Guardar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transferencia Entrada")

        Try
            trans.Add(Entity)

            If Entity.IsNew Then
                Me.MovimientoAlmacen.Guardar(trans)
                Me.FolioTranferencia = Me.ObtenerFolioTransferencia(trans)
                Entity.Save()
                Me.Detalle.Guardar(trans)

                Me.TransferenciaSalida.Estatus = TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.RECIBIDA

                trans.Add(Me.TransferenciaSalida.Entidad)
                Me.TransferenciaSalida.Entidad.Save()

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
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelacion Transferencia")

        Try
            With MovimientoAlmacenCancelacion
                .IdAlmacen = Me.IdAlmacenDestino
                .FechaMovimiento = Me.FechaCancelacion
                .TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Traspaso
                .Origen = ""
                .Referencia = Me.MovimientoAlmacen.FolioMovimientoAlmacen
                .IdUsuarioAlta = Me.IdUsuarioCancelacion
                .EstatusContabilizado = 0
            End With

            For Each det As AlmacenGeneral.MovimientoAlmacenDetalleClass In Me.MovimientoAlmacen.Detalle
                Me.MovimientoAlmacenCancelacion.Detalle.Add(Me.MovimientoAlmacenCancelacion, _
                                                    det.Indice, det.IdProducto, _
                                                    Me.MovimientoAlmacenCancelacion.FechaMovimiento, _
                                                    det.Cantidad, det.Costo, det.Descuento, det.Lote, det.FechaCaducidad)
            Next

            Estatus = EstatusTransferenciaEntrada.CANCELADA

            trans.Add(Entidad)

            Me.MovimientoAlmacenCancelacion.Guardar(trans)

            Entidad.Save()

            trans.Add(Me.TransferenciaSalida.Entidad)

            Me.TransferenciaSalida.Estatus = TransferenciaAlmacenSalidaClass.EstatusTransferenciaSalida.EN_TRANSITO

            Me.TransferenciaSalida.Entidad.Save()

            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al cancelar la transferencia", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function

    Private Function ObtenerFolioTransferencia(ByVal trans As HC.Transaction) As String
        Dim folio As New FoliosClass

        folio.Año = Now.Year
        folio.Mes = Now.Month
        folio.Codigo = CodigodeFolios.TransferenciaAlmacenGeneralEntrada

        If Not folio.Guardar(trans) Then
            Throw New Exception("No se logro general el folio de transferencias")
        End If

        Return String.Format("{0}-{1}", Now.ToString("MMyy"), folio.Consecutivo.ToString("0000000"))
    End Function

    Public Sub Imprimir(ByVal empresa As String)
        Try
            Dim rpt As New rptEntradaPorTransferencias
            Dim ventPrevisualizacion As New PreVisualizarForm
            Dim dst As New dstTransferenciasEntradas
            Dim tbCab As dstTransferenciasEntradas.TransferenciaEntradasDataTable = dst.Tables(0)
            Dim tbDet As dstTransferenciasEntradas.TransferenciaEntradasDetalleDataTable = dst.Tables(1)

            With Me
                Dim row As dstTransferenciasEntradas.TransferenciaEntradasRow = _
                                        tbCab.AddTransferenciaEntradasRow(.FolioTranferencia, _
                                        .AlmacenDestino.Descripcion, .AlmacenOrigen.Descripcion, _
                                        .FechaMovimiento, .TotalProductos, .Importe, .Estatus.ToString, _
                                        .FolioTranferenciaSalida)

                For Each det As TransferenciaAlmacenEntradaDetalleClass In .Detalle
                    tbDet.AddTransferenciaEntradasDetalleRow(row, det.Producto.Descripcion, _
                                                        det.Lote, det.Cantidad, det.Importe, _
                                                        det.CostoUnitario, det.Iva)
                Next
            End With

            rpt.SetDataSource(dst)
            rpt.SetParameterValue(0, empresa)

            ventPrevisualizacion.Reporte = rpt
            ventPrevisualizacion.Text = "Reporte de Entradas Por Transferencias"
            ventPrevisualizacion.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error mientras se realizaba la impresión de la transferencia", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Public Function Obtener(ByVal folioTransferenciaEntrada As String) As Boolean
        Try
            Return Entity.FetchUsingPK(folioTransferenciaEntrada)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "Enumeradores"
    ''' <summary>
    ''' Estatus para la entrada por transferencia
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum EstatusTransferenciaEntrada As Short
        CANCELADA = 0S
        VIGENTE
    End Enum
#End Region
End Class