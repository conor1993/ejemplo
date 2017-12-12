Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral

    Public Class InventarioAlmacenLoteClass
        Inherits ClassBase(Of EC.inventarioAlmacenLotesEntity)

#Region "Miembros"
        Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
        Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
        Private m_Almacen As AlmacenClass
        Private m_Producto As ProductoClass
#End Region

#Region "Constructores"
        Sub New()
            Entity = New EC.inventarioAlmacenLotesEntity
        End Sub

        Sub New(ByVal AlmacenId As Integer, ByVal ProductoId As Integer, ByVal Lote As String, ByVal año As Integer, ByVal mes As Integer)
            Entity = New EC.inventarioAlmacenLotesEntity(AlmacenId, ProductoId, Lote, año, mes)
        End Sub

        Sub New(ByVal Entidad As EC.inventarioAlmacenLotesEntity)
            Entity = Entidad
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
                ElseIf Not IdAlmacen = m_Almacen.Codigo Then
                    m_Almacen.LeerEntidad(Entity.Almacen)
                End If

                Return m_Almacen
            End Get
            Set(ByVal value As AlmacenClass)
                m_Almacen = value

                If value Is Nothing Then
                    Entity.Almacen = Nothing
                Else
                    Entity.Almacen = m_Almacen.ObtenerEntidad
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
                    Entity.Producto = m_Producto.ObtenerEntidad
                End If
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

        Public Property Año() As Integer
            Get
                Return Entity.Año
            End Get
            Set(ByVal value As Integer)
                Entity.Año = value
            End Set
        End Property

        Public Property Mes() As Integer
            Get
                Return Entity.Mes
            End Get
            Set(ByVal value As Integer)
                Entity.Mes = value
            End Set
        End Property

        Public Property FechaUltimoCosto() As Date
            Get
                Return Entity.FechaUltimoCosto
            End Get
            Set(ByVal value As Date)
                Entity.FechaUltimoCosto = value
            End Set
        End Property

        Public Property UltimoCosto() As Decimal
            Get
                Return Entity.UltimoCosto
            End Get
            Set(ByVal value As Decimal)
                Entity.UltimoCosto = value
            End Set
        End Property

        Public Property CostoPromedio() As Decimal
            Get
                Return Entity.CostoPromedio
            End Get
            Set(ByVal value As Decimal)
                Entity.CostoPromedio = value
            End Set
        End Property

        Public Property CantidadInicial() As Decimal
            Get
                Return Entity.CantidadInicial
            End Get
            Set(ByVal value As Decimal)
                Entity.CantidadInicial = value
            End Set
        End Property

        'Public Property CantidadExistencia() As Integer
        Public Property CantidadExistencia() As Decimal
            Get
                Return Entity.CantidadExistencia
            End Get
            Set(ByVal value As Decimal)
                Entity.CantidadExistencia = value
            End Set
        End Property

        Public Property CantidadEntrada() As Decimal
            Get
                Return Entity.CantidadEntrada
            End Get
            Set(ByVal value As Decimal)
                Entity.CantidadEntrada = value
            End Set
        End Property

        Public Property FechaUltimaEntrada() As Nullable(Of Date)
            Get
                Return Entity.FechaUltimaEntrada
            End Get
            Set(ByVal value As Nullable(Of Date))
                Entity.FechaUltimaEntrada = value
            End Set
        End Property

        Public Property CantidadSalidas() As Decimal
            Get
                Return Entity.CantidadSalidas
            End Get
            Set(ByVal value As Decimal)
                Entity.CantidadSalidas = value
            End Set
        End Property

        Public Property FechaUltimaSalida() As Nullable(Of Date)
            Get
                Return Entity.FechaUltimaSalida
            End Get
            Set(ByVal value As Nullable(Of Date))
                Entity.FechaUltimaSalida = value
            End Set
        End Property

        Public Property FechaCaducidad() As Nullable(Of Date)
            Get
                Return Entity.FechaCaducidad
            End Get
            Set(ByVal value As Nullable(Of Date))
                Entity.FechaCaducidad = value
            End Set
        End Property

        Public Property FechaAlta() As Date
            Get
                Return Entity.FechaAlta
            End Get
            Set(ByVal value As Date)
                Entity.FechaAlta = value
            End Set
        End Property

        Public Property CantidadPorSurtir() As Decimal
            Get
                Return Entity.CantidadPorSurtir
            End Get
            Set(ByVal value As Decimal)
                Entity.CantidadPorSurtir = value
            End Set
        End Property

        'Public ReadOnly Property Disponible() As Integer
        Public ReadOnly Property Disponible() As Decimal
            Get
                Return CantidadExistencia - CantidadPorSurtir
            End Get
        End Property
#End Region

#Region "Metodos"
        ''' <summary>
        ''' Guarda los datos del producto en el lote especificado.
        ''' Es recomendable que haya obtenido los datos del lote por medio de la función
        ''' <see cref="ObteneryActualizarInventario"/> para asegurarse de que guarde el inventario
        ''' en la fecha actual
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shadows Function Guardar(ByVal trans As HC.Transaction) As Boolean 'Implements IEntidad.Guardar
            Try
                trans.Add(Entity)

                Return Entity.Save
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Obtiene un lote de un producto y almacen especificado. Depues de ejecutar esta función
        ''' si quiere actualizar estos datos a la fecha actual solo es necesario ejecutar 
        ''' la función ActualizarInventario.
        ''' </summary>
        ''' <param name="AlmacenId">Almacén del que quiere obtener el lote</param>
        ''' <param name="ProductoId">Producto que quiere obtener del lote</param>
        ''' <param name="Lote">Lote</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Obtener(ByVal AlmacenId As Integer, ByVal ProductoId As Integer, _
                                ByVal Lote As String, ByVal año As Integer, ByVal mes As Integer) As Boolean
            Try
                Return Entity.FetchUsingPK(AlmacenId, ProductoId, Lote, año, mes)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Function

        ''' <summary>
        ''' Obtiene el inventario en el año y mes mas recientes del producto, almacen y lote especificado.
        ''' Depues de ejecutar esta función si quiere actualizar estos datos a la fecha actual solo es necesario ejecutar 
        ''' la función ActualizarInventario.
        ''' </summary>
        ''' <param name="idAlmacen">Código de Almacén</param>
        ''' <param name="idProducto">Código de Producto</param>
        ''' <param name="lote">Lote del producto</param>
        ''' <returns>True si enceuntra un registro en el inventario de lotes y False si no</returns>
        ''' <remarks></remarks>
        Public Function Obtener(ByVal idAlmacen As Integer, ByVal idProducto As Integer, ByVal lote As String) As Boolean
            Try
                Dim ultimoLote As New CC.inventarioAlmacenLotesCollection
                Dim sort As New OC.SortExpression

                sort.Add(New OC.SortClause(HC.inventarioAlmacenLotesFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                sort.Add(New OC.SortClause(HC.inventarioAlmacenLotesFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                'Dim a As String = HC.DbUtils.ActualConnectionString
                ultimoLote.GetMulti(HC.inventarioAlmacenLotesFields.AlmacenId = idAlmacen And _
                            HC.inventarioAlmacenLotesFields.ProductoId = idProducto And _
                            HC.inventarioAlmacenLotesFields.Lote = lote.Trim, 2, sort)

                If ultimoLote.Count = 0 Then
                    Return False
                Else
                    Entity = ultimoLote(0)

                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Obtiene el inventario en el año y mes mas recientes del producto, almacen y lote especificado.
        ''' Si el inventario es de un año y mes anterior a la fecha actual se actualiza creando un nuevo registro
        ''' en la fecha actual e inicializando los valores que se acumulan por mes. 
        ''' </summary>
        ''' <param name="idAlmacen">Código de Almacén</param>
        ''' <param name="idProducto">Código de Producto</param>
        ''' <param name="lote">Lote del producto</param>
        ''' <returns>True si enceuntra un registro en el inventario de lotes y False si no</returns>
        ''' <remarks></remarks>
        Public Function ObteneryActualizarInventario(ByVal idAlmacen As Integer, ByVal idProducto As Integer, _
                                        ByVal lote As String, ByVal trans As HC.Transaction) As Boolean
            Try
                Dim ultimoLote As New CC.inventarioAlmacenLotesCollection
                Dim sort As New OC.SortExpression

                sort.Add(New OC.SortClause(HC.inventarioAlmacenLotesFields.Año, _
                         SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                sort.Add(New OC.SortClause(HC.inventarioAlmacenLotesFields.Mes, _
                         SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

                If trans IsNot Nothing Then
                    trans.Add(ultimoLote)
                End If

                ultimoLote.GetMulti(HC.inventarioAlmacenLotesFields.AlmacenId = idAlmacen And _
                            HC.inventarioAlmacenLotesFields.ProductoId = idProducto And _
                            HC.inventarioAlmacenLotesFields.Lote = lote.Trim, 1, sort)

                If ultimoLote.Count = 0 Then
                    Return False
                Else
                    Entity = ultimoLote(0)

                    If Not Mes = Now.Month OrElse Not Año = Now.Year Then
                        Dim invLote As New EC.inventarioAlmacenLotesEntity

                        If trans IsNot Nothing Then
                            trans.Add(invLote)
                        End If

                        With invLote
                            .AlmacenId = idAlmacen
                            .ProductoId = idProducto
                            .Lote = lote
                            .Año = Now.Year
                            .Mes = Now.Month
                            .FechaUltimoCosto = Me.FechaUltimoCosto
                            .UltimoCosto = Me.UltimoCosto
                            .CostoPromedio = Me.CostoPromedio
                            .CantidadInicial = Me.CantidadExistencia
                            .CantidadExistencia = Me.CantidadExistencia
                            .CantidadEntrada = 0D
                            .CantidadSalidas = 0D
                            .FechaCaducidad = Me.FechaCaducidad
                            .FechaAlta = Me.FechaAlta
                            .CantidadPorSurtir = Me.CantidadPorSurtir
                        End With

                        invLote.Save()

                        Entidad = invLote
                    End If

                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Afecta el inventario con los datos ingresados. Aumenta o disminuye el inventario
        ''' segun la dirección del movimiento y afecta el costo si se le indica.
        ''' Es recomendable ejecutar la función ObtenerYActualizarInventario de esta manera se asegura
        ''' estar afectando el inventario en el año y mes actual. Esta función no afecta los registros en la BD
        ''' solo realiza los calculos en la clase.
        ''' </summary>
        ''' <param name="cantidad">Cantidad de producto</param>
        ''' <param name="costo">Costo del producto</param>
        ''' <param name="direccion">Dirección del movimiento [Entrada/Salida]</param>
        ''' <param name="afectarCosto">Indica si se afectara el costo del inventario</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AfectarInventario(ByVal cantidad As Decimal, ByVal costo As Decimal, _
                                          ByVal direccion As DireccionEnum, ByVal afectarCosto As Boolean) As Boolean
            If direccion = DireccionEnum.SALIDAS AndAlso Not CantidadExistencia >= cantidad Then
                Throw New Exception("No hay sufiente producto en el lote """ & Me.Lote & """ solo se dispone de " & Me.CantidadExistencia & _
                                        " " & Me.Producto.UnidadMedida.DescCorta)
            End If

            If direccion = DireccionEnum.ENTRADAS Then
                Me.FechaUltimaEntrada = Now
                Me.CantidadExistencia += cdec(cantidad)
                Me.CantidadEntrada += cantidad
            Else
                Me.FechaUltimaSalida = Now
                Me.CantidadExistencia -= cantidad
                Me.CantidadSalidas += cantidad
            End If

            If afectarCosto Then
                With Me
                    If direccion = DireccionEnum.ENTRADAS Then
                        .CostoPromedio = (.CantidadExistencia * .CostoPromedio + cantidad * costo) / _
                                        (.CantidadExistencia + cantidad)
                        .UltimoCosto = costo
                        .FechaUltimoCosto = Now
                    End If
                End With
            End If

            Return True
        End Function

        ''' <summary>
        ''' Crea un registro de inventario en la fecha actual para llevar estadisticas por mes.
        ''' No ejecutar si ya existe un inventario.
        ''' </summary>
        ''' <param name="idAlmacen">Código del Almacén</param>
        ''' <param name="idProducto">Código del Producto</param>
        ''' <param name="costo">Costo del Producto</param>
        ''' <param name="cantidad">Cantidad a ingresar al inventario</param>
        ''' <param name="lote">Lote del almacén</param>
        ''' <param name="caduca">Establesca si el producto caduca</param>
        ''' <param name="fechaCaducidad">Fecha de Caducidad en caso de que el producto no caduque indique cualquier fecha
        ''' no se tomara en cuenta</param>
        ''' <param name="trans">Transaccion es obligatorio no se admite Nothing</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CrearInventario(ByVal idAlmacen As Integer, ByVal idProducto As Integer, _
                                        ByVal costo As Decimal, ByVal cantidad As Decimal, _
                                        ByVal lote As String, ByVal caduca As Boolean, _
                                        ByVal fechaCaducidad As Nullable(Of Date), _
                                        ByVal año As Integer, ByVal mes As Integer, _
                                        ByVal trans As HC.Transaction) As Boolean
            If Me.ExisteInventario(idAlmacen, idProducto, lote, trans) Then Return False

            With Me
                .IdAlmacen = idAlmacen
                .IdProducto = idProducto
                .Año = año
                .Mes = mes
                .Lote = lote
                .FechaUltimoCosto = Now
                .UltimoCosto = costo
                .CostoPromedio = costo
                .CantidadInicial = 0D
                .CantidadExistencia = cantidad
                .CantidadEntrada = cantidad
                .FechaUltimaEntrada = Now
                .CantidadSalidas = 0D
                .FechaAlta = Now
                .FechaCaducidad = fechaCaducidad
                .CantidadPorSurtir = 0D

                Return .Guardar(trans)
            End With
        End Function

        ''' <summary>
        ''' Valida si hay un registro en el inventario de un producto en un almacen
        ''' </summary>
        ''' <param name="idAlmacen">Código del Almacén</param>
        ''' <param name="idProducto">Código del Producto</param>
        ''' <param name="lote">Lote del almcén</param>
        ''' <param name="trans">Transaccion Nothing si no la requiere</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function ExisteInventario(ByVal idAlmacen As Integer, ByVal idProducto As Integer, _
                                          ByVal lote As String, ByVal trans As HC.Transaction) As Boolean
            Dim lotes As New CC.inventarioAlmacenLotesCollection

            If trans IsNot Nothing Then trans.Add(lotes)

            Return lotes.GetDbCount(HC.inventarioAlmacenLotesFields.AlmacenId = idAlmacen And _
                                          HC.inventarioAlmacenLotesFields.ProductoId = idProducto And _
                                          HC.inventarioAlmacenLotesFields.Lote = lote) > 0
        End Function
#End Region
    End Class

End Namespace