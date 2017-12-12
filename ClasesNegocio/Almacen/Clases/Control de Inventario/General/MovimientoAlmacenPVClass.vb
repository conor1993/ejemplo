Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Namespace AlmacenGeneral

    Public Class MovimientoAlmacenPVClass
        Inherits ClassBase(Of EC.MinvMovimientosAlmacenPvEntity)


#Region "Enumeradores"
        Public Enum TipoMovimientoEnum As Integer
            ENTRADA_POR_COMPRA = 1
            SALIDA_POR_VENTA = 2
            ENTRADA_POR_TRANSFERENCIA = 3
            SALIDA_POR_TRANSFERENCIA = 4
            ENTRADA_POR_PRODUCCION = 5
            SALIDA_POR_PRODUCCION = 6
            SALIDA_POR_KIT = 7
            ENTRADA_X_AJUSTE_DE_INVENTARIO = 8
            SALIDA_X_AJUSTE_DE_INVENTARIO = 9
        End Enum

        Public Enum MovimientoAlmacenEstatus
            CANCELADO
            VIGENTE
            CONTABILIZADO
        End Enum
#End Region

#Region "Miembros"
        Private m_Detalle As MovimientoAlmacenPVDetalleCollectionClass
        Private m_Almacen As AlmacenClass
        Private m_TipoMovimiento As TipoMovimientoPVClass
        Private m_TipoMovimientos As TipoMovimientoEnum
#End Region

#Region "Constructores"
        Sub New()
            MyBase.New()
        End Sub

        Sub New(ByVal entidad As EC.MinvMovimientosAlmacenPvEntity)
            MyBase.New(entidad)
        End Sub

        Sub New(ByVal idAlmacen As Integer, ByVal folioMovimiento As String)
            MyBase.New(New EC.MinvMovimientosAlmacenPvEntity(idAlmacen, folioMovimiento))
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
        Public Property TipoMovimiento() As TipoMovimientoPVClass
            Get
                If m_TipoMovimiento Is Nothing Then
                    m_TipoMovimiento = New TipoMovimientoPVClass(Entity.CatMovimientosAlmacenPv)
                ElseIf Not m_TipoMovimiento.Codigo = IdTipoMovimiento Then
                    m_TipoMovimiento.LeerEntidad(Entity.CatMovimientosAlmacenPv)
                End If

                Return m_TipoMovimiento
            End Get
            Set(ByVal value As TipoMovimientoPVClass)
                m_TipoMovimiento = value

                If value Is Nothing Then
                    Entity.CatMovimientosAlmacenPv = Nothing
                Else
                    Entity.CatMovimientosAlmacenPv = value.ObtenerEntidad
                End If
            End Set
        End Property


        'Public Property TipoMovimiento() As TipoMovimientoPVClass
        '    Get
        '        If m_TipoMovimiento Is Nothing Then
        '            m_TipoMovimiento = New TipoMovimientoPVClass(Entity.CatMovimientosAlmacenPv)
        '        End If
        '        Return m_TipoMovimiento
        '    End Get
        '    Set(ByVal value As TipoMovimientoPVClass)

        '        m_TipoMovimiento = value
        '    End Set
        'End Property

        ''' <summary>
        ''' Establece el tipo de movimiento validando si este esta configurado
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        'Public Property TipoMovimientos() As TipoMovimientoEnum
        '    Private Get
        '        Return Me.m_TipoMovimientos
        '    End Get
        '    Set(ByVal value As TipoMovimientoEnum)
        '        m_TipoMovimientos = value

        '        IdTipoMovimiento = m_TipoMovimientos
        '    End Set
        'End Property

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

        Public ReadOnly Property Detalle() As MovimientoAlmacenPVDetalleCollectionClass
            Get
                If m_Detalle Is Nothing Then
                    m_Detalle = New MovimientoAlmacenPVDetalleCollectionClass
                    Dim Filtro As New OC.PredicateExpression
                    Filtro.Add(HC.MinvMovimientosAlmacenPvdetallesFields.FolioMovimiento = FolioMovimientoAlmacen)
                    m_Detalle.Obtener(Filtro)
                    'm_Detalle.RellenarMe(Entity.AlwaysFetchMinvMovimientosAlmacenPvdetalles)
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

        Public Function Obtener(ByVal idAlmacen As Integer, ByVal Folio As String) As Boolean
            Try
                Return Entity.FetchUsingPK(idAlmacen, Folio)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Function
    End Class

    Public Class MovimientoAlmacenPVCollectionClass
        Inherits ColleccionBase(Of EC.MinvMovimientosAlmacenPvEntity,  _
                            CC.MinvMovimientosAlmacenPvCollection, MovimientoAlmacenPVClass)
        Sub New()
            MyBase.New()
        End Sub

        Public Overloads Function Obtener(ByVal Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression) As Integer
            Try
                'Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

                'Filtro.Add(HC.minvmo.IdKit = CodKit)
                coleccion.GetMulti(Filtro)
                RellenarMe(coleccion)
                Return coleccion.Count
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return -1
            End Try
        End Function

        Public Shared Sub Imprimir(ByVal empresa As String, ByVal usuario As String, ByVal formulario As String, ByVal agruparProducto As Boolean, ByVal filtro As OC.PredicateExpression)
            Dim movimientos As New Integralab.ORM.TypedListClasses.MovimientosAlmacenGeneralTypedList
            Dim reporteAgrupado As rptMovimientosAlmacenGeneralAgrupado
            Dim reporteSinAgrupar As rptMovimientosAlmacenGeneralSinAgrupar
            Dim previsualizar As New PreVisualizarForm

            movimientos.Fill(0, New OC.SortExpression(New OC.SortClause(HC.MinvMovimientosAlmacenPvFields.FechaMovimiento, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), False, filtro)

            If agruparProducto Then
                reporteAgrupado = New rptMovimientosAlmacenGeneralAgrupado
                reporteAgrupado.SetDataSource(CType(movimientos, Object))
                reporteAgrupado.SetParameterValue(0, empresa)
                reporteAgrupado.SetParameterValue(1, usuario)
                reporteAgrupado.SetParameterValue(2, formulario)

                previsualizar.Reporte = reporteAgrupado
            Else
                reporteSinAgrupar = New rptMovimientosAlmacenGeneralSinAgrupar
                reporteSinAgrupar.SetDataSource(CType(movimientos, Object))
                reporteSinAgrupar.SetParameterValue(0, empresa)
                reporteSinAgrupar.SetParameterValue(1, usuario)
                reporteSinAgrupar.SetParameterValue(2, formulario)

                previsualizar.Reporte = reporteSinAgrupar
            End If

            previsualizar.Text = "Reporte de Movmientos de Almacén General"
            previsualizar.ShowDialog()

        End Sub
    End Class
End Namespace