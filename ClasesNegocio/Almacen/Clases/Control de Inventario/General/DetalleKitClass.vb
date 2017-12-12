Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class DetalleKitClass
    Inherits ClassBase(Of EC.DetalleKitPvEntity)

    Private _Producto As ProductoGeneralClass

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.DetalleKitPvEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal codKit As Integer, ByVal codProd As Integer)
        MyBase.New(New EC.DetalleKitPvEntity(codKit, codProd))
    End Sub

#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("IdKit")> _
    Public Property IdKit() As Integer
        Get
            Return Entity.IdKit
        End Get
        Set(ByVal value As Integer)
            Entity.IdKit = value
        End Set
    End Property

    <ComponentModel.DisplayName("IdProd")> _
    Public Property IdProd() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cantidad")> _
    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Cantidad = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cantidad")> _
    Public Property Precio() As Decimal
        Get
            Return Entity.Precio
        End Get
        Set(ByVal value As Decimal)
            Entity.Precio = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cantidad")> _
    Public Property Iva() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cantidad")> _
    Public Property Ieps() As Decimal
        Get
            Return Entity.Ieps
        End Get
        Set(ByVal value As Decimal)
            Entity.Ieps = value
        End Set
    End Property

    <ComponentModel.DisplayName("Producto"), ComponentModel.DataObjectField(True, False, False)> _
    Public Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass
            End If
            _Producto.LeerEntidad(Entidad.Producto_)
            Return _Producto
        End Get
        Set(ByVal value As ProductoGeneralClass)
            Entidad.Producto_ = value.ObtenerEntidad
            'RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal codkit As Integer, ByVal codProd As Integer) As Boolean
        Return Entity.FetchUsingPK(codkit, codProd)
    End Function

    Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        'Trans.Add(Entity)
        'Return Entity.Save
        Try
            If Entity.IsNew Then
                Trans.Add(Entity)
                If Not Entity.Save Then
                    Return False
                Else
                    Return True
                End If
            Else
                Trans.Add(Entity)
                If Not Entity.Save Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shadows Function Borrar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            'Me.Estatus = EstatusEnum.INACTIVO
            Trans.Add(Entity)
            If Entity.Delete Then
                Return True
            Else
                MsgBox("No se pudo borrar el detalle del kit, reintente.", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se pudo borrar el detalle del kit, reintente.", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

    Public Shadows Function Borrar() As Boolean
        Try
            'Me.Estatus = EstatusEnum.INACTIVO

            If Entity.Delete Then
                Return True
            Else
                MsgBox("No se pudo borrar el detalle del kit, reintente.", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se pudo borrar el detalle del kit, reintente. " & ex.Message.ToString, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

#End Region


End Class

Public Class DetalleKitCollectionClass
    Inherits ColleccionBase(Of EC.DetalleKitPvEntity,  _
                            CC.DetalleKitPvCollection, DetalleKitClass)
    Private Col As New Integralab.ORM.CollectionClasses.DetalleKitPvCollection

    Sub New()
        MyBase.New()
    End Sub

    Public Overloads Function Obtener(ByVal CodKit As Long) As Integer
        Try
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            Filtro.Add(HC.DetalleKitPvFields.IdKit = CodKit)


            Return Obtener(Filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    
    
End Class
