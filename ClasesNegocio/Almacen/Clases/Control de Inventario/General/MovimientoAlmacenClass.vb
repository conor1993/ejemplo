Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral

    Public Class MovimientoAlmacenClass
        Inherits ClassBase(Of EC.InventarioMovimientoAlmacenEntity)

#Region "Miembros"
        Private m_Detalle As MovimientoAlmacenDetalleCollectionClass
        Private m_Almacen As AlmacenClass
        Private m_TipoMovimiento As TipoMovimientoAlmacenClass
        Private m_TipoMovimientos As ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum
#End Region

#Region "Constructores"

        Sub New()
            MyBase.New()
        End Sub

        Sub New(ByVal entidad As EC.InventarioMovimientoAlmacenEntity)
            MyBase.New(entidad)
        End Sub

        Sub New(ByVal idAlmacen As Integer, ByVal folioMovimiento As String)
            MyBase.New(New EC.InventarioMovimientoAlmacenEntity(idAlmacen, folioMovimiento))
        End Sub

#End Region

#Region "Propiedades"

        Public Property IdAlmacen() As Integer
            Get
                Return Entity.AlmacenId
            End Get
            Set(ByVal value As Integer)
                Entity.AlmacenId = value
            End Set
        End Property

        Public Property Almacen() As AlmacenClass
            Get
                If m_Almacen Is Nothing Then
                    m_Almacen = New AlmacenClass(Entity.Almacen)
                ElseIf Not m_Almacen.Codigo = IdAlmacen Then
                    m_Almacen.LeerEntidad(Entity.Almacen)
                End If

                Return m_Almacen
            End Get
            Set(ByVal value As AlmacenClass)
                m_Almacen = value

                If value Is Nothing Then
                    Entity.Almacen = Nothing
                Else
                    Entity.Almacen = value.ObtenerEntidad
                End If
            End Set
        End Property

        Public Property FolioMovimientoAlmacen() As String
            Get
                Return Entity.FolioMovimiento
            End Get
            Set(ByVal value As String)
                Entity.FolioMovimiento = value
            End Set
        End Property

        Public Property FechaMovimiento() As Date
            Get
                Return Entity.FechaMovimiento
            End Get
            Set(ByVal value As Date)
                Entity.FechaMovimiento = value
            End Set
        End Property

        Public Property IdTipoMovimiento() As Integer
            Get
                Return Entity.TipoMovimientoId
            End Get
            Set(ByVal value As Integer)
                Entity.TipoMovimientoId = value
            End Set
        End Property

        ''' <summary>
        ''' Obtiene o establece el tipo de movimiento 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TipoMovimiento() As TipoMovimientoAlmacenClass
            Get
                If m_TipoMovimiento Is Nothing Then
                    m_TipoMovimiento = New TipoMovimientoAlmacenClass(Entity.TipoMovimientoAlmacen)
                ElseIf Not m_TipoMovimiento.Codigo = IdTipoMovimiento Then
                    m_TipoMovimiento.LeerEntidad(Entity.TipoMovimientoAlmacen)
                End If

                Return m_TipoMovimiento
            End Get
            Set(ByVal value As TipoMovimientoAlmacenClass)
                m_TipoMovimiento = value

                If value Is Nothing Then
                    Entity.TipoMovimientoAlmacen = Nothing
                Else
                    Entity.TipoMovimientoAlmacen = value.ObtenerEntidad
                End If
            End Set
        End Property

        ''' <summary>
        ''' Establece el tipo de movimiento validando si este esta configurado
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TipoMovimientos() As ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum
            Private Get
                Return Me.m_TipoMovimientos
            End Get
            Set(ByVal value As ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum)
                m_TipoMovimientos = value

                IdTipoMovimiento = ObtenerTipoMovimiento(value)
            End Set
        End Property

        Public Property Referencia() As String
            Get
                Return Entity.Referencia
            End Get
            Set(ByVal value As String)
                Entity.Referencia = value
            End Set
        End Property

        Public Property IdUsuarioAlta() As Integer
            Get
                Return Entity.UsuarioId
            End Get
            Set(ByVal value As Integer)
                Entity.UsuarioId = value
            End Set
        End Property

        Public Property Contabilizado() As MovimientoAlmacenEstatus
            Get
                Return Entity.EstatusContabilizado
            End Get
            Set(ByVal value As MovimientoAlmacenEstatus)
                Entity.EstatusContabilizado = value
            End Set
        End Property

        Public Property FechaContabilizacion() As Date
            Get
                Return Entity.FechaContabilizacion.GetValueOrDefault(#1/1/1990#)
            End Get
            Set(ByVal value As Date)
                Entity.FechaContabilizacion = value
            End Set
        End Property

        Public Property PolizaContabilidad() As Integer
            Get
                Return Entity.PolizaContabilidad.GetValueOrDefault("0")
            End Get
            Set(ByVal value As Integer)
                Entity.PolizaContabilidad = value
            End Set
        End Property

        Public ReadOnly Property Detalle() As MovimientoAlmacenDetalleCollectionClass
            Get
                If m_Detalle Is Nothing Then
                    m_Detalle = New MovimientoAlmacenDetalleCollectionClass
                    m_Detalle.RellenarMe(Entity.InventarioMovimientosAlmacenDetalles)
                End If

                Return m_Detalle
            End Get
        End Property

        ''' <summary>
        ''' Obtiene o establece el donde se origina el movimeinto de almacén
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Origen() As String
            Get
                Return Entity.Origen
            End Get
            Set(ByVal value As String)
                Entity.Origen = value
            End Set
        End Property

        Public Property EstatusContabilizado() As Short
            Get
                Return Entity.EstatusContabilizado
            End Get
            Set(ByVal value As Short)
                Entity.EstatusContabilizado = value
            End Set
        End Property

        Public Property Entregar() As String
            Get
                Return Entity.Entrega
            End Get
            Set(ByVal value As String)
                Entity.Entrega = value
            End Set
        End Property

        Public Property Recibe() As String
            Get
                Return Entity.Recibe
            End Get
            Set(ByVal value As String)
                Entity.Recibe = value
            End Set
        End Property

        Public Property Observaciones() As String
            Get
                Return Entity.Observaciones
            End Get
            Set(ByVal value As String)
                Entity.Observaciones = value
            End Set
        End Property

        Public Property CostoTotal() As Decimal
            Get
                Return Entity.CostoTotal
            End Get
            Set(ByVal value As Decimal)
                Entity.CostoTotal = value
            End Set
        End Property
#End Region

#Region "Metodos"
        Public Function Obtener(ByVal idAlmacen As Integer, ByVal folioMovimiento As String) As Boolean
            Try
                Return Entity.FetchUsingPK(idAlmacen, folioMovimiento)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Function

        Public Shared Function ObtenerTipoMovimiento(ByVal tipoMovimiento As ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum) As Integer
            Dim configs As New CC.InventarioConfiguracionCollection
            Dim config As EC.InventarioConfiguracionEntity

            configs.GetMulti(Nothing)

            If configs.Count = 0 Then
                Throw New Exception("Debe establecer la configuración de movimiento de almacén ""Catalogos/Almacén/Configuración de Almacén""")
            Else
                config = configs(0)
            End If

            Select Case tipoMovimiento
                '========================================================
                '=                      ENTRADAS                        =
                '========================================================
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Ajuste_Inventario
                    If config.ExAjusteInventario.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entradas Por Ajuste de Inventario")
                    Else
                        Return config.ExAjusteInventario
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Compra
                    If config.ExCompra.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entradas Por Compra")
                    Else
                        Return config.ExCompra
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Consignacion
                    If config.ExConsignacion.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entradas Por Consignación")
                    Else
                        Return config.ExConsignacion
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Devolucion_Consumo
                    If config.ExDevolucionConsumo.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entradas Por Devolución de Consumo")
                    Else
                        Return config.ExDevolucionConsumo
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Devolucion_Venta
                    If config.ExDevolucionVenta.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entradas Por Devolución de Venta")
                    Else
                        Return config.ExDevolucionVenta
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Inventario_Inicial
                    If config.ExInventarioInicial.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entradas Por Inventario Inicial")
                    Else
                        Return config.ExInventarioInicial
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Otros
                    If config.ExOtros.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Otras Entradas")
                    Else
                        Return config.ExOtros
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Traspaso
                    If config.ExTraspaso.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entradas Por Traspaso")
                    Else
                        Return config.ExTraspaso
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cancelacion_Traspaso
                    If config.ExCancelacionTraspaso.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Cancelación de Traspaso")
                    Else
                        Return config.ExCancelacionTraspaso
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Preparacion_Mezcla
                    If config.ExPreparaciionMezcla.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Preparacion de Mezcla")
                    Else
                        Return config.ExPreparaciionMezcla
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_X_Preparacion_Mezcla
                    If config.ExCancelacionSalidaXpreparacionMezcla.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Cancelacion de Salida Por Preparaion de Mezcla")
                    Else
                        Return config.ExCancelacionSalidaXpreparacionMezcla
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cancelacion_Otras_Salidas
                    If config.ExCancelacionOtrasSalidas.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Cancelacion de Otras Salidas")
                    Else
                        Return config.ExCancelacionOtrasSalidas
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Medicamento
                    If config.Exmedicamento.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada De Medicamento")
                    Else
                        Return config.Exmedicamento
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Proceso_Grano_Rolado
                    If config.ExprocesoGranoRolado.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Proceso De Grano Rolado")
                    Else
                        Return config.ExprocesoGranoRolado
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_Grano_Rolado
                    If config.ExcancelacionSalidaGranoRolado.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Cancelación Salida Por Grano Rolado")
                    Else
                        Return config.ExcancelacionSalidaGranoRolado
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cacnelacion_Aplicacion_Formula
                    If config.ExcancelacionAplicacionFormula.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Cancelación Aplicación De Formula")
                    Else
                        Return config.ExcancelacionAplicacionFormula
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cancelacion_Aplicacion_Medicamento
                    If config.ExcancelacionAplicacionMedicamento.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Entrada Por Cancelación Aplicación De Medicamento")
                    Else
                        Return config.ExcancelacionAplicacionMedicamento
                    End If

                    '========================================================
                    '=                       SALIDAS                        =
                    '========================================================
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Ajuste_Inventario
                    If config.SxAjusteInventario.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Ajuste de Inventario")
                    Else
                        Return config.SxAjusteInventario
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Consumo
                    If config.SxConsumo.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Consumo")
                    Else
                        Return config.SxConsumo
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Devolucion_Compra
                    If config.SxDevolucionCompra.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Devolución Compra")
                    Else
                        Return config.SxDevolucionCompra
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Devolucion_Consignacion
                    If config.SxDevolucionConsignacion.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Devolución Consignación")
                    Else
                        Return config.SxDevolucionConsignacion
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Otros
                    If config.SxOtros.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Otras Salidas")
                    Else
                        Return config.SxOtros
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Traspaso
                    If config.SxTraspaso.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Traspaso")
                    Else
                        Return config.SxTraspaso
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Venta
                    If config.SxVenta.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Venta")
                    Else
                        Return config.SxVenta
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Traspaso
                    If config.SxCancelacionTraspaso.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Cancelación de Traspaso")
                    Else
                        Return config.SxCancelacionTraspaso
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Preparacion_Mezcla
                    If config.SxPreparacionMezcla.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Preparacion de Mezcla")
                    Else
                        Return config.SxPreparacionMezcla
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Preparacion_Mezcla
                    If config.SxCancelacionEntradaXpreparacionMezcla.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Cancelacion de Entrada Por Preparacion de Mezcla")
                    Else
                        Return config.SxCancelacionEntradaXpreparacionMezcla
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Otras_Entradas
                    If config.SxCancelacionOtrasEntradas.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Cancelacion de Otras Entradas")
                    Else
                        Return config.SxCancelacionOtrasEntradas
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Recepcion_Consignacion
                    If config.SxcancelacionEntradaRecepcionConsignacion.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Cancelacion de Otras Entradas")
                    Else
                        Return config.SxcancelacionEntradaRecepcionConsignacion
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Aplicacion_Formula
                    If config.SxaplicacionFormula.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Aplicación Formula")
                    Else
                        Return config.SxaplicacionFormula
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Aplicacion_Medicamento
                    If config.SxaplicacionMedicamento.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Aplicación Medicamento")
                    Else
                        Return config.SxaplicacionMedicamento
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_Medicamento
                    If config.SxcancelacionEntradaMedicamento.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Cancelación Entrada De Medicamento")
                    Else
                        Return config.SxcancelacionEntradaMedicamento
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Entradas_X_Proceso_Grano_Rolado
                    If config.SxcancelacionEntradaProcesoGranoRolado.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Cancelacion De Entrada Por Proceso De Grano Rolado")
                    Else
                        Return config.SxcancelacionEntradaProcesoGranoRolado
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Proceso_Grano_Rolado
                    If config.SxprocesoGranoRolado.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Proceso Grano Rolado")
                    Else
                        Return config.SxprocesoGranoRolado
                    End If
                Case ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Regreso_Medicamento
                    If config.SxcancelacionRegresoMedicamento.GetValueOrDefault(0) = 0 Then
                        Throw New Exception("Debe establecer el tipo de movimiento Salida Por Cancelacion Regreso De Medicamento")
                    Else
                        Return config.SxcancelacionRegresoMedicamento
                    End If
            End Select
        End Function

        Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
            Dim finalizarTrans As Boolean 'se usa para saber si la transaccion termina en este metodo

            Try
                If Trans Is Nothing Then
                    Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Movimiento Almacen")
                    finalizarTrans = True
                Else
                    finalizarTrans = False
                End If

                Trans.Add(Entity)

                FolioMovimientoAlmacen = ObtenerFolioMovimiento(Trans)

                Entity.Save()
                Detalle.Guardar(Trans)

                If finalizarTrans Then
                    Trans.Commit()
                End If

                Return True
            Catch ex As Exception
                If finalizarTrans Then
                    Trans.Rollback()
                End If

                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Genera un folio de movimiento de almacén para el almacén especificado.
        ''' Este metodo solo se usa para funciones ajenas a esta clase que requieren generar un folio
        ''' si guardara el movimiento de almacén con el metodo guardar de esta clase no es necesario
        ''' que se genere el folio antes
        ''' </summary>
        ''' <param name="idAlmacen">Código del almacén para el que se requiere generara el folio del movimiento de almacen</param>
        ''' <param name="trans">Transacción en la que se realizara el folio</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ObtenerFolioMovimiento(ByVal idAlmacen As Integer, ByVal trans As HC.Transaction) As String
            Try
                Dim folio As New FoliosClass

                folio.Año = Now.Year
                folio.Mes = Now.Month
                folio.Clasificador = idAlmacen
                folio.Codigo = CodigodeFolios.MovimientosdeAlmacen

                folio.Guardar(trans)

                'EJEMPLO: {IdAlmacen 4 Digitos}-{AÑOMES}-{Consecutivo}   0001-0801-0000000001
                Return idAlmacen.ToString("0000") & "-" & Now.ToString("yyMM") & _
                        "-" & folio.Consecutivo.ToString("0000000000")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function ObtenerFolioMovimiento(ByVal trans As HC.Transaction) As String
            Try
                Dim folio As New FoliosClass

                folio.Año = Now.Year
                folio.Mes = Now.Month
                folio.Clasificador = IdAlmacen
                folio.Codigo = CodigodeFolios.MovimientosdeAlmacen

                folio.Guardar(trans)

                'EJEMPLO: {IdAlmacen 4 Digitos}-{AÑOMES}-{Consecutivo}   0001-0801-0000000001
                Return Me.IdAlmacen.ToString("0000") & "-" & Now.ToString("yyMM") & _
                        "-" & folio.Consecutivo.ToString("0000000000")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "Enumeradores"
        Public Enum MovimientoAlmacenEstatus
            CANCELADO
            VIGENTE
            CONTABILIZADO
        End Enum
#End Region
    End Class
End Namespace