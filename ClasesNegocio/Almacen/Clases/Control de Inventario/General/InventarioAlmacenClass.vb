Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral

    Public Class InventarioAlmacenClass
        Inherits ClassBase(Of EC.InventarioAlmacenEntity)

#Region " Declaraciones "
        Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
        Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
        Private m_Almacen As AlmacenClass
        Private m_Producto As ProductoClass
        Private m_Lotes As InventarioAlmacenLoteCollectionClass
#End Region

#Region "Constructores"
        Sub New()
            MyBase.New()
        End Sub

        Sub New(ByVal idAlmacen As Integer, ByVal idProducto As Integer, ByVal año As Integer, ByVal mes As Integer)
            MyBase.New(New EC.InventarioAlmacenEntity(idAlmacen, idProducto, año, mes))
        End Sub

        Sub New(ByVal Entidad As EC.InventarioAlmacenEntity)
            MyBase.New(Entidad)
        End Sub
#End Region

#Region " Propiedades "
        Public Property IdAlmacen() As Integer
            Get
                Return Entity.AlmacenId
            End Get
            Private Set(ByVal value As Integer)
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
            Private Set(ByVal value As AlmacenClass)
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
            Private Set(ByVal value As Integer)
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
            Private Set(ByVal value As ProductoClass)
                m_Producto = value

                If value Is Nothing Then
                    Entity.Producto = Nothing
                Else
                    Entity.Producto = m_Producto.ObtenerEntidad
                End If
            End Set
        End Property

        Public Property Año() As Integer
            Get
                Return Entity.Año
            End Get
            Private Set(ByVal value As Integer)
                Entity.Año = value
            End Set
        End Property

        Public Property Mes() As Integer
            Get
                Return Entity.Mes
            End Get
            Private Set(ByVal value As Integer)
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
            Private Set(ByVal value As Decimal)
                Entity.CantidadInicial = value
            End Set
        End Property

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

        Public Property FechaUltimaEntrada() As Date
            Get
                Return Entity.FechaUltimaEntrada.GetValueOrDefault(#1/1/1990#)
            End Get
            Private Set(ByVal value As Date)
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

        Public Property FechaUltimaSalida() As Date
            Get
                Return Entity.FechaUltimaSalida.GetValueOrDefault(#1/1/1990#)
            End Get
            Private Set(ByVal value As Date)
                Entity.FechaUltimaSalida = value
            End Set
        End Property

        Public Property CantidadPorSurtir() As Decimal
            Get
                Return Entity.CantidadPorSurtir
            End Get
            Private Set(ByVal value As Decimal)
                Entity.CantidadPorSurtir = value
            End Set
        End Property

        Public ReadOnly Property Disponible() As Decimal
            Get
                Return CantidadExistencia - CantidadPorSurtir
            End Get
        End Property

        Public ReadOnly Property Lotes() As InventarioAlmacenLoteCollectionClass
            Get
                If m_Lotes Is Nothing Then
                    m_Lotes = New InventarioAlmacenLoteCollectionClass
                    m_Lotes.RellenarMe(Entity.InventarioAlmacenLotes)
                End If

                Return m_Lotes
            End Get
        End Property
#End Region

#Region " Metodos "
        ''' <summary>
        ''' Obtiene el inventario del Producto en el Almacén, Año y Mes indicados
        ''' </summary>
        ''' <param name="idAlmacen">Código del Almacén</param>
        ''' <param name="idProducto">Código del Producto</param>
        ''' <param name="año">Año del Inventario</param>
        ''' <param name="mes">Mes del Inventario</param>
        ''' <returns>True si encuentra el inventario con los datos ingresados y False si no lo enceuntra</returns>
        ''' <remarks></remarks>
        Public Function Obtener(ByVal idAlmacen As Integer, ByVal idProducto As Integer, ByVal año As Integer, ByVal mes As Integer, Optional ByVal Trans As HC.Transaction = Nothing) As Boolean 'Implements IEntidad.Obtener
            Try
                If Trans Is Nothing Then
                    Return Entity.FetchUsingPK(idAlmacen, idProducto, año, mes)
                Else
                    Dim Col As New CC.InventarioAlmacenCollection

                    Trans.Add(Col)
                    Col.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And HC.InventarioAlmacenFields.ProductoId = idProducto And HC.InventarioAlmacenFields.Año = año And HC.InventarioAlmacenFields.Mes = mes, 1)

                    If Col.Count > 0 Then
                        Me.Entidad = Col(0)
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Obtiene el inventario del año y mes mas recientes de un Producto en un Almacén
        ''' </summary>
        ''' <param name="idAlmacen">Código del Almacén</param>
        ''' <param name="idProducto">Código del Producto</param>
        ''' <returns>True si encuentra un registro de inventario de ese producto en el almacen indicado y False si no encuentra</returns>
        ''' <remarks></remarks>
        Public Function Obtener(ByVal idproducto As Integer, ByVal idalmacen As Integer) As Boolean
            Try
                Dim ultimoInventario As New CC.InventarioAlmacenCollection
                Dim sort As New OC.SortExpression

                sort.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                sort.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

                ultimoInventario.GetMulti(HC.InventarioAlmacenFields.ProductoId = idproducto And HC.InventarioAlmacenFields.AlmacenId = idalmacen, 1, sort)

                If ultimoInventario.Count = 0 Then
                    Return False
                Else
                    Entidad = ultimoInventario(0)
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Guarda el inventario con los datos proporcionados.
        ''' Es recomendable que haya obtenido los datos del inventario por medio del la función
        ''' <see cref="ObteneryActualizarInventario"/> para estar seguro que afectara el inventario
        ''' en la fecha actual
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shadows Function Guardar(ByVal trans As HC.Transaction) As Boolean
            Try
                trans.Add(Entity)

                Return Entity.Save()
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ''' <summary>
        ''' Obtiene el inventario en el año y mes mas recientes del producto y almacen  especificado.
        ''' Si el inventario es de un año y mes anterior a la fecha actual se actualiza creando un nuevo registro
        ''' en la fecha actual e inicializando los valores que se acumulan por mes.
        ''' </summary>
        ''' <param name="idAlmacen">Código de Almacén</param>
        ''' <param name="idProducto">Código de Producto</param>
        ''' <returns>True si enceuntra un registro en el inventario y lo actualiza. False si no encuentra</returns>
        ''' <remarks></remarks>
        Public Function ObteneryActualizarInventario(ByVal idAlmacen As Integer, ByVal idProducto As Integer, _
                                                ByVal trans As HC.Transaction) As Boolean
            Try
                If Not Me.ExisteInventario(idAlmacen, idProducto, trans) Then Return False

                Dim ultimoInventario As New CC.InventarioAlmacenCollection
                Dim sort As New OC.SortExpression

                sort.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, _
                            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                sort.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, _
                            SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

                If trans IsNot Nothing Then
                    trans.Add(ultimoInventario)
                End If

                'ultimoInventario.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And _
                '            HC.InventarioAlmacenFields.ProductoId = idProducto, 1, sort)

                ultimoInventario.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And _
                            HC.InventarioAlmacenFields.ProductoId = idProducto And HC.InventarioAlmacenFields.Año = Now.Year And HC.InventarioAlmacenFields.Mes = Now.Month, 1)

                If ultimoInventario.Count > 0 Then

                    Entity = ultimoInventario(0)



                    'If ultimoInventario.Count = 0 Then
                    '    Return False
                    'Else
                    '    Entity = ultimoInventario(0)

                    '    If Not (Mes = Now.Month And Año = Now.Year) Then
                    '        Dim invAlmacen As New EC.InventarioAlmacenEntity

                    '        If trans IsNot Nothing Then
                    '            trans.Add(invAlmacen)
                    '        End If

                    '        With invAlmacen
                    '            .AlmacenId = idAlmacen
                    '            .ProductoId = idProducto
                    '            .Año = Now.Year
                    '            .Mes = Now.Month
                    '            .FechaUltimoCosto = Me.FechaUltimoCosto
                    '            .UltimoCosto = Me.UltimoCosto
                    '            .CostoPromedio = Me.CostoPromedio
                    '            .CantidadInicial = Me.CantidadExistencia
                    '            .CantidadExistencia = Me.CantidadExistencia
                    '            .CantidadEntrada = 0D
                    '            .CantidadSalidas = 0D
                    '            .CantidadPorSurtir = Me.CantidadPorSurtir
                    '        End With

                    '        invAlmacen.Save()

                    '        Entidad = invAlmacen
                    '    End If

                    Return True
                Else
                    ultimoInventario = New CC.InventarioAlmacenCollection

                    If trans IsNot Nothing Then
                        trans.Add(ultimoInventario)
                    End If

                    ultimoInventario.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And HC.InventarioAlmacenFields.ProductoId = idProducto, 1, sort)

                    If ultimoInventario.Count > 0 Then
                        Entidad = ultimoInventario(0)
                    Else
                        Return False
                    End If

                    Dim invAlmacen As New EC.InventarioAlmacenEntity


                    If trans IsNot Nothing Then
                        trans.Add(invAlmacen)
                    End If

                    With invAlmacen
                        .AlmacenId = idAlmacen
                        .ProductoId = idProducto
                        .Año = Now.Year
                        .Mes = Now.Month
                        .FechaUltimoCosto = Me.FechaUltimoCosto
                        .UltimoCosto = Me.UltimoCosto
                        .CostoPromedio = Me.CostoPromedio
                        .CantidadInicial = Me.CantidadExistencia
                        .CantidadExistencia = Me.CantidadExistencia
                        .CantidadEntrada = 0D
                        .CantidadSalidas = 0D
                        .CantidadPorSurtir = Me.CantidadPorSurtir
                    End With

                    invAlmacen.Save()

                    Entidad = invAlmacen
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

            'se comento para vender sin existencia

            If direccion = DireccionEnum.SALIDAS Then
                If Not ClasesNegocio.ControladorGanadera.ObtenerVtaSinExistencia Then
                    If direccion = DireccionEnum.SALIDAS AndAlso Not CantidadExistencia >= cantidad Then
                        Throw New Exception("No hay sufiente producto " & Me.Producto.Descripcion & " solo se dispone de " & Me.CantidadExistencia & _
                                                " " & Me.Producto.UnidadMedida.DescCorta)
                        Return False


                    End If
                End If
            End If




            If direccion = DireccionEnum.ENTRADAS Then
                Me.FechaUltimaEntrada = Now
                Me.CantidadExistencia += cantidad
                Me.CantidadEntrada += cantidad
            Else
                Me.FechaUltimaSalida = Now
                Me.CantidadExistencia -= cantidad
                Me.CantidadSalidas += cantidad
            End If

            If afectarCosto Then
                With Me
                    If direccion = DireccionEnum.ENTRADAS Then
                        .UltimoCosto = costo
                        If .CantidadExistencia >= 0 Then
                            .CostoPromedio = ((.CantidadExistencia - cantidad) * .CostoPromedio + cantidad * costo) / _
                                        (.CantidadExistencia)
                            '.CostoPromedio = (.CantidadExistencia * .CostoPromedio + cantidad * costo) / _
                            '            (.CantidadExistencia + cantidad)
                        Else
                            .CostoPromedio = (0 * .CostoPromedio + cantidad * costo) / _
                                        (0 + cantidad)
                        End If
                        .FechaUltimoCosto = Now
                        'Else
                        '    .CostoPromedio = .UltimoCosto
                        '    .FechaUltimoCosto = Now
                    End If
                End With
            End If

            Return True
        End Function


        'Public Function AfectarInventario(ByVal cantidad As Decimal, ByVal costo As Decimal, _
        '                                  ByVal direccion As Integer, ByVal afectarCosto As Boolean) As Boolean
        '    'If direccion = 1 AndAlso Not CantidadExistencia >= cantidad Then
        '    '    Throw New Exception("No hay sufiente producto solo se dispone de " & Me.CantidadExistencia & _
        '    '                            " " & Me.Producto.UnidadMedida.DescCorta)
        '    'End If

        '    If direccion = 0 Then
        '        Me.FechaUltimaEntrada = Now
        '        Me.CantidadExistencia += cantidad
        '        Me.CantidadEntrada += cantidad
        '    Else
        '        Me.FechaUltimaSalida = Now
        '        Me.CantidadExistencia -= cantidad
        '        Me.CantidadSalidas += cantidad
        '    End If

        '    If afectarCosto Then
        '        With Me
        '            If direccion = 0 Then
        '                .UltimoCosto = .CostoPromedio
        '                .CostoPromedio = (.CantidadExistencia * .CostoPromedio + cantidad * costo) / _
        '                                (.CantidadExistencia + cantidad)

        '                .FechaUltimoCosto = Now
        '            Else
        '                .CostoPromedio = .UltimoCosto
        '                .FechaUltimoCosto = Now
        '            End If
        '        End With
        '    End If

        '    Return True
        'End Function

        ''' <summary>
        ''' Crea un registro de inventario en la fecha actual para llevar estadisticas por mes.
        ''' No ejecutar si ya existe un inventario.
        ''' </summary>
        ''' <param name="idAlmacen">Código del Almacén</param>
        ''' <param name="idProducto">Código del Producto</param>
        ''' <param name="costo">Costo del Producto</param>
        ''' <param name="cantidad">Cantidad a ingresar al inventario</param>
        ''' <param name="trans">Transaccion es obligatorio no se admite Nothing</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function CrearInventario(ByVal idAlmacen As Integer, ByVal idProducto As Integer, _
                                        ByVal costo As Decimal, ByVal cantidad As Decimal, _
                                        ByVal año As Integer, ByVal mes As Integer, _
                                        ByVal trans As HC.Transaction) As Boolean

            If Me.ExisteInventario(idAlmacen, idProducto, trans) Then Return False

            With Me
                .IdAlmacen = idAlmacen
                .IdProducto = idProducto
                .Año = año
                .Mes = mes
                .FechaUltimoCosto = Now
                .UltimoCosto = 0D
                .CostoPromedio = costo
                .CantidadInicial = 0D
                .CantidadExistencia = cantidad
                .CantidadEntrada = cantidad
                .FechaUltimaEntrada = Now
                .CantidadSalidas = 0D
                .CantidadPorSurtir = 0D
                Return .Guardar(trans)
            End With
        End Function

        Public Function CrearInventarioSalida(ByVal idAlmacen As Integer, ByVal idProducto As Integer, _
                                        ByVal costo As Decimal, ByVal cantidad As Decimal, _
                                        ByVal año As Integer, ByVal mes As Integer, _
                                        ByVal trans As HC.Transaction) As Boolean

            If Me.ExisteInventario(idAlmacen, idProducto, trans) Then Return False

            With Me
                .IdAlmacen = idAlmacen
                .IdProducto = idProducto
                .Año = año
                .Mes = mes
                .FechaUltimoCosto = Now
                .UltimoCosto = 0D
                .CostoPromedio = costo
                .CantidadInicial = 0D
                .CantidadExistencia = cantidad * -1
                .CantidadEntrada = 0D
                .FechaUltimaEntrada = Now
                .CantidadSalidas = cantidad
                .CantidadPorSurtir = 0D
                Return .Guardar(trans)
            End With
        End Function

        ''' <summary>
        ''' Valida si hay un registro en el inventario de un producto en un almacen
        ''' </summary>
        ''' <param name="idAlmacen">Código del Almacén</param>
        ''' <param name="idProducto">Código del Producto</param>
        ''' <param name="trans">Transaccion Nothing si no utiliza una</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function ExisteInventario(ByVal idAlmacen As Integer, ByVal idProducto As Integer, _
                                            ByVal trans As HC.Transaction) As Boolean
            Dim inventarios As New CC.InventarioAlmacenCollection

            If trans IsNot Nothing Then trans.Add(inventarios)

            Return inventarios.GetDbCount(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And _
                                          HC.InventarioAlmacenFields.ProductoId = idProducto) > 0
        End Function

        ''' <summary>
        ''' Aumenta la cantidad por surtir del producto
        ''' Es recomendable ejecutar la función ObtenerYActualizarInventario de esta manera se asegura
        ''' estar afectando el inventario en el año y mes actual. Esta función no afecta los registros en la BD
        ''' solo realiza los calculos en la clase.
        ''' </summary>
        ''' <param name="cantidad">Cantidad de producto</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function AgregarProductoPorSurtir(ByVal cantidad As Decimal) As Boolean
            If cantidad > Me.Disponible Then
                Throw New Exception("No hay suficiente producto en existencia. Se dispone de " & _
                                    Me.Disponible & " " & Me.Producto.UnidadMedida.DescCorta & _
                                    " de " & Me.Producto.Descripcion)
            End If

            Me.CantidadPorSurtir += cantidad
        End Function
#End Region
    End Class

End Namespace