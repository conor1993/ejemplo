Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Namespace AlmacenGeneral
    Public Class InventarioHistorialPVClass
        Inherits ClassBase(Of EC.InvHistorialPvEntity)

#Region "Miembros"
        Private m_Almacen As AlmacenClass
        Private m_Producto As ProductoClass
#End Region

#Region "Constructores"
        Sub New()
            MyBase.New()
        End Sub

        Sub New(ByVal entidad As EC.InvHistorialPvEntity)
            MyBase.New(entidad)
        End Sub

        Sub New(ByVal idAlmacen As Integer, ByVal idProducto As Integer, ByVal fecha As Date)
            MyBase.New(New EC.InvHistorialPvEntity(idAlmacen, idProducto, fecha))
        End Sub
#End Region

#Region "Propiedades"
        <ComponentModel.DataObjectField(True, False, False), _
            ComponentModel.Description("Codigo del almacen")> _
        Public Property IdAlmacen() As Integer
            Get
                Return Entity.IdAlmacen
            End Get
            Set(ByVal value As Integer)
                Entity.IdAlmacen = value
            End Set
        End Property

        <ComponentModel.DataObjectField(True, False, False), _
            ComponentModel.Description("Codigo del producto")> _
        Public Property IdProducto() As Integer
            Get
                Return Entity.IdProducto
            End Get
            Set(ByVal value As Integer)
                Entity.IdProducto = value
            End Set
        End Property

        <ComponentModel.DataObjectField(True, False, False), _
            ComponentModel.Description("Fecha del inventario")> _
        Public Property FechaInv() As Date
            Get
                Return Entity.FechaInventario
            End Get
            Set(ByVal value As Date)
                Entity.FechaInventario = value
            End Set
        End Property

        <ComponentModel.DataObjectField(True, False, False), _
            ComponentModel.Description("Existencia Fisica")> _
        Public Property ExistenciaFisica() As Decimal
            Get
                Return Entity.ExistenciaFisica
            End Get
            Set(ByVal value As Decimal)
                Entity.ExistenciaFisica = value
            End Set
        End Property

        <ComponentModel.DataObjectField(True, False, False), _
            ComponentModel.Description("Existencia Sistema")> _
        Public Property ExistenciaSistema() As Decimal
            Get
                Return Entity.ExistenciaSistema
            End Get
            Set(ByVal value As Decimal)
                Entity.ExistenciaSistema = value
            End Set
        End Property

        <ComponentModel.DataObjectField(True, False, False), _
            ComponentModel.Description("Precio Unitario")> _
        Public Property PrecioUnitario() As Decimal
            Get
                Return Entity.PrecioUnitario
            End Get
            Set(ByVal value As Decimal)
                Entity.PrecioUnitario = value
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
#End Region

#Region "Metodos"
        Public Function Obtener(ByVal IdAlmacen As Integer, ByVal IdProducto As Integer, ByVal FechaInv As Date) As Boolean
            Try
                Return Entity.FetchUsingPK(IdAlmacen, IdProducto, FechaInv)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Function

        Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
            Try
                'Me.Estatus = EstatusEnum.INACTIVO
                If Trans IsNot Nothing Then
                    Trans.Add(Entity)
                End If

                If Entity.Save Then
                    Return True
                Else
                    MsgBox("No se a logrado dar de alta el historial del inventario, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Catch ex As Exception
                MsgBox("No se a logrado dar de alta el historial del inventario, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End Try
        End Function

        Public Shadows Function Borrar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
            Try
                'Me.Estatus = EstatusEnum.INACTIVO
                If Trans IsNot Nothing Then
                    Trans.Add(Entity)
                End If

                If Entity.Delete Then
                    Return True
                Else
                    MsgBox("No se a logrado dar de baja el producto, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Catch ex As Exception
                MsgBox("No se a logrado dar de baja el producto, intente enuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End Try
        End Function
#End Region
    End Class

    ''coleccion
    Public Class InventarioHistorialPVCollectionClass
        Inherits ColleccionBase(Of EC.InvHistorialPvEntity,  _
                                CC.InvHistorialPvCollection, InventarioHistorialPVClass)
        Sub New()
            MyBase.New()
        End Sub
    End Class
End Namespace
