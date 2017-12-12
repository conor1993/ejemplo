Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral
    Public Class MovimientoAlmacenDetalleClass
        Inherits ClassBase(Of EC.InventarioMovimientoAlmacenDetallesEntity)

#Region "Miembros"
        Private m_MovimientoAlmacen As MovimientoAlmacenClass
        Private m_Almacen As AlmacenClass
        Private m_Producto As ProductoClass
        Private m_FechaCaducidad As Nullable(Of Date)
        Private m_invAlmacen As InventarioAlmacenClass
#End Region

#Region "Constructores"
        Sub New()
            MyBase.New()
        End Sub

        Sub New(ByVal entidad As EC.InventarioMovimientoAlmacenDetallesEntity)
            MyBase.New(entidad)
        End Sub

        Sub New(ByVal idAlmacen As Integer, ByVal folioMovimiento As String, _
                ByVal indice As Integer, ByVal idProducto As Integer)
            MyBase.New(New EC.InventarioMovimientoAlmacenDetallesEntity(indice, idAlmacen, folioMovimiento, idProducto))
        End Sub
#End Region

#Region "Propiedades"
        ''' <summary>
        ''' Obtiene o establece el indice o renglon del registro en el detalle del movimiento
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <ComponentModel.DataObjectField(True, False, False), _
        ComponentModel.Description("Contiene el indice o renglon del registro en el detalle del movimiento")> _
        Public Property Indice() As Integer
            Get
                Return Entity.Indice
            End Get
            Set(ByVal value As Integer)
                Entity.Indice = value
            End Set
        End Property

        ''' <summary>
        ''' Obtiene o establece el código del almacén donde se genera el movimiento
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <ComponentModel.DataObjectField(True, False, False), _
        ComponentModel.Description("Código del almacén que sera afectado por el movimeinto")> _
        Public Property IdAlmacen() As Integer
            Get
                Return Entity.AlmacenId
            End Get
            Set(ByVal value As Integer)
                Entity.AlmacenId = value
            End Set
        End Property

        ''' <summary>
        ''' Obtiene o establece el almacén donde se genera el movimiento
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
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

        Public ReadOnly Property DescripcionTipoMov() As String
            Get
                Return Me.MovimientoAlmacen.TipoMovimiento.Nombre
            End Get
        End Property

        Public Property MovimientoAlmacen() As MovimientoAlmacenClass
            Get
                If m_MovimientoAlmacen Is Nothing Then
                    m_MovimientoAlmacen = New MovimientoAlmacenClass(Entity.InventarioMovimientosAlmacen)
                ElseIf Not m_MovimientoAlmacen.IdAlmacen = IdAlmacen AndAlso _
                        Not m_MovimientoAlmacen.FolioMovimientoAlmacen.Trim = FolioMovimientoAlmacen.Trim Then
                    m_MovimientoAlmacen.Entidad = Entity.InventarioMovimientosAlmacen
                End If
                Return m_MovimientoAlmacen
            End Get
            Set(ByVal value As MovimientoAlmacenClass)
                m_MovimientoAlmacen = value

                If value Is Nothing Then
                    Entity.InventarioMovimientosAlmacen = Nothing
                Else
                    Entity.InventarioMovimientosAlmacen = value.Entidad
                End If
            End Set
        End Property

        Public Property IdProducto() As Integer
            Get
                Return Entity.ProductoId
            End Get
            Set(ByVal value As Integer)
                Entity.ProductoId = value
            End Set
        End Property

        Public Property Producto() As ProductoClass
            Get
                If m_Producto Is Nothing Then
                    m_Producto = New ProductoClass(Entity.Producto)
                ElseIf Not m_Producto.Codigo = IdProducto Then
                    m_Producto.LeerEntidad(Entity.Producto)
                End If

                Return m_Producto
            End Get
            Set(ByVal value As ProductoClass)
                m_Producto = value

                If value Is Nothing Then
                    Entity.Producto = Nothing
                Else
                    Entity.Producto = value.ObtenerEntidad
                End If
            End Set
        End Property

        Public Property FechaMovimiento() As Date
            Get
                Return Entity.FechaMovimiento.GetValueOrDefault(#1/1/1990#)
            End Get
            Set(ByVal value As Date)
                Entity.FechaMovimiento = value
            End Set
        End Property

        Public Property Cantidad() As Decimal
            Get
                Return CDec(Entity.Cantidad)
            End Get
            Set(ByVal value As Decimal)
                Entity.Cantidad = value
            End Set
        End Property

        Public Property Costo() As Decimal
            Get
                Return CDec(Entity.Costo)
            End Get
            Set(ByVal value As Decimal)
                Entity.Costo = value
            End Set
        End Property

        Public Property Descuento() As Decimal
            Get
                Return CDec(Entity.Descuento)
            End Get
            Set(ByVal value As Decimal)
                Entity.Descuento = value
            End Set
        End Property

        Public Property Lote() As String
            Get
                Return Entity.Lote
            End Get
            Set(ByVal value As String)
                Entity.Lote = value
            End Set
        End Property

        Public Property FechaCaducidad() As Nullable(Of Date)
            Get
                Return Me.m_FechaCaducidad
            End Get
            Set(ByVal value As Nullable(Of Date))
                Me.m_FechaCaducidad = value
            End Set
        End Property

        Public ReadOnly Property Improte() As Decimal
            Get
                Return Me.Costo * Me.Cantidad
            End Get
        End Property

        Public Property CostoPromedioAnterior() As Decimal
            Get
                Return Entity.CostoPromedioAnterior
            End Get
            Private Set(ByVal value As Decimal)
                Entity.CostoPromedioAnterior = value
            End Set
        End Property

        Public Property CostoPromedio() As Decimal
            Get
                Return Entity.CostoPromedio
            End Get
            Private Set(ByVal value As Decimal)
                Entity.CostoPromedio = value
            End Set
        End Property

        Public Property idCostoAplicacion() As Nullable(Of Integer)
            Get
                Return Entity.IdCentroCosto
            End Get
            Set(ByVal value As Nullable(Of Integer))
                Entity.IdCentroCosto = value
            End Set
        End Property

        Public Property CantidadUsada() As Decimal
            Get
                Return Entity.CantidadUsada
            End Get
            Set(ByVal value As Decimal)
                Entity.CantidadUsada = value
            End Set
        End Property
#End Region

#Region "Metodos"
        Public Function Obtener(ByVal indice As Integer, ByVal idAlmacen As Integer, ByVal folioMovimiento As String, ByVal idProducto As Integer) As Boolean
            Try
                Return Entity.FetchUsingPK(indice, idAlmacen, folioMovimiento, idProducto)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Function

        Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
            Trans.Add(Entity)
            AfectarInventario(Trans)
            Return Entity.Save()
        End Function

        Private Sub AfectarInventario(ByVal trans As HC.Transaction)
            Dim inventario As New InventarioAlmacenClass

            If inventario.ObteneryActualizarInventario(IdAlmacen, IdProducto, trans) Then
                With inventario
                    Me.CostoPromedioAnterior = .CostoPromedio

                    .AfectarInventario(Cantidad, Costo, MovimientoAlmacen.TipoMovimiento.Direccion, _
                                        CBool(MovimientoAlmacen.TipoMovimiento.AfectaCosto))
                    .Guardar(trans)

                    Me.CostoPromedio = .CostoPromedio

                    If CBool(Producto.SeManejaPorLotes) Then
                        Dim cantidadInventariada As Decimal = 0D
                        Dim inventarioLote As New InventarioAlmacenLoteClass

                        If inventarioLote.ObteneryActualizarInventario(IdAlmacen, IdProducto, Lote, trans) Then
                            inventarioLote.AfectarInventario(Cantidad, Costo, MovimientoAlmacen.TipoMovimiento.Direccion, _
                                                                CBool(MovimientoAlmacen.TipoMovimiento.AfectaCosto))
                        Else
                            If Me.MovimientoAlmacen.TipoMovimiento.Direccion = DireccionEnum.SALIDAS Then
                                Throw New Exception("No es posible dar salida a un producto que no existe en el inventario")
                            Else
                                inventarioLote.CrearInventario(IdAlmacen, IdProducto, Costo, Cantidad, Lote, _
                                                                Producto.Caducidad, Me.FechaCaducidad, Now.Year, _
                                                                Now.Month, trans)
                            End If
                        End If
                    End If
                End With
            Else
                If MovimientoAlmacen.TipoMovimiento.Direccion = DireccionEnum.SALIDAS Then
                    Throw New Exception("No es posible dar salida a un producto que no existe en el inventario")
                Else
                    If inventario.CrearInventario(IdAlmacen, IdProducto, Costo, Cantidad, Now.Year, Now.Month, trans) Then
                        Me.CostoPromedio = Me.Costo
                        Me.CostoPromedioAnterior = 0D

                        If Me.Producto.SeManejaPorLotes = AsignadaEnum.SI Then
                            Dim inventarioLote As New InventarioAlmacenLoteClass

                            inventarioLote.CrearInventario(IdAlmacen, IdProducto, _
                                                            Costo, Cantidad, Me.Lote, Me.Producto.Caducidad, _
                                                            Me.FechaCaducidad, Now.Year, Now.Month, trans)
                        End If
                    End If
                End If
            End If
        End Sub
#End Region

#Region "Enumeradores"

#End Region

    End Class
End Namespace