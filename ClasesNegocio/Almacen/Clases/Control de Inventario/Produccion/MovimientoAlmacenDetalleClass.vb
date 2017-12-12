Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Data.SqlClient

Public Class MovimientoAlmacenDetalleClass
    Inherits ClassBase(Of EC.MscmovtosAlmacenDetEntity)

#Region "Miembros"
    Dim m_Producto As ProductosClass
    Dim m_Movimiento As MovimientoAlmacenClass
#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("Folio Movimiento"), ComponentModel.DataObjectField(True, False, False, 12)> _
    Public Property FolioMovimiento() As String
        Get
            Return Entity.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimiento = value
        End Set
    End Property

    <ComponentModel.DisplayName("Movimiento de Almacen")> _
    Public Property Movimiento() As MovimientoAlmacenClass
        Get
            If m_Movimiento Is Nothing Then
                m_Movimiento = New MovimientoAlmacenClass(Entity.MscmovtosAlmacenCab)
            ElseIf Not m_Movimiento.FolioMovimiento = FolioMovimiento Then
                m_Movimiento.LeerEntidad(Entity.MscmovtosAlmacenCab)
            End If

            Return m_Movimiento
        End Get
        Set(ByVal value As MovimientoAlmacenClass)
            m_Movimiento = value

            If value Is Nothing Then
                Entity.MscmovtosAlmacenCab = Nothing
            Else
                Entity.MscmovtosAlmacenCab = value.Entidad
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Código Producto"), ComponentModel.DataObjectField(True, False, False)> _
    Public Property IdProducto() As Integer
        Get
            Return Entity.IdCodProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdCodProducto = value
        End Set
    End Property

    <ComponentModel.DisplayName("Producto")> _
    Public Property Producto() As ProductosClass
        Get
            If m_Producto Is Nothing Then
                m_Producto = New ProductosClass(Entity.MsccatProductos)
            ElseIf Not IdProducto = m_Producto.IdProducto Then
                m_Producto.Entidad = Entity.MsccatProductos
            End If

            Return m_Producto
        End Get
        Set(ByVal value As ProductosClass)
            m_Producto = value

            If value Is Nothing Then
                Entity.MsccatProductos = Nothing
            Else
                Entity.MsccatProductos = value.Entidad
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Piezas")> _
    Public Property Piezas() As Integer
        Get
            Return Entity.CantPzas
        End Get
        Set(ByVal value As Integer)
            Entity.CantPzas = value
        End Set
    End Property

    <ComponentModel.DisplayName("kilos")> _
    Public Property Kilos() As Decimal
        Get
            Return Entity.CantKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.CantKilos = value
        End Set
    End Property

    <ComponentModel.DisplayName("Costo Unitario")> _
    Public Property CostoUnitario() As Decimal
        Get
            Return Entity.CostoUnitario
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoUnitario = value
        End Set
    End Property

    <ComponentModel.DisplayName("IVA")> _
    Public Property IVA() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property
#End Region
End Class