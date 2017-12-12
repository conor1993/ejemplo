Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses


Public Class ProductosPaqueteClass
    Inherits ClassBase(Of EC.ProductoMezclaEntity)

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
    Private m_producto As New ProductoGeneralClass()
    Private m_productoIng As New ProductoGeneralClass()

    Public Property Paquete() As ProductoGeneralClass
        Get
            m_producto.LeerEntidad(Entity.Producto)
            Return m_producto
        End Get
        Set(ByVal value As ProductoGeneralClass)
            m_producto = value
            Entity.Producto = m_producto.ObtenerEntidad
        End Set
    End Property

    Public Property Ingrediente() As ProductoGeneralClass
        Get
            m_productoIng.LeerEntidad(Entity.Producto_)
            Return m_productoIng
        End Get
        Set(ByVal value As ProductoGeneralClass)
            m_productoIng = value
            Entity.Producto_ = m_productoIng.ObtenerEntidad
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Entity.Porcentaje
        End Get
        Set(ByVal value As Decimal)
            Entity.Porcentaje = value
        End Set
    End Property

    Public Property IdProducto() As Integer
        Get
            Return Entity.CodigoProducto
        End Get
        Set(ByVal value As Integer)
            Entity.CodigoProducto = value
        End Set
    End Property

    Public Property IdIngrediente() As Integer
        Get
            Return Entity.CodigoIngrediente
        End Get
        Set(ByVal value As Integer)
            Entity.CodigoIngrediente = value
        End Set
    End Property

    Public Function Borrar() As Boolean
        Try
            If Entity.Save Then
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

    'Public Property Estatus() As EstatusEnum 
    '    Get

    '    End Get
    '    Set(ByVal value As EstatusEnum)

    '    End Set
    'End Property

    Public Function Guardar() As Boolean
        Try
            If Entity.Save Then
                Return True
            Else
                MsgBox("No se logró guardar el producto, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("No se logro guardar el producto, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Sub New()

        AddHandler Modificado, AddressOf FueModificado

        Entity = New EC.ProductoMezclaEntity

        'PPaquete.ingrediente = Nothing
        'PPaquete.Productos = Nothing
        Entity.Producto = Nothing
        Entity.Porcentaje = 0
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Ingrediente.Descripcion
    End Function

    Public Function ObtenerEntidad() As EC.ProductoMezclaEntity
        Return Entity
    End Function

    Public Sub LeerEntidad(ByVal FcEntidad As EC.ProductoMezclaEntity)
        Entity = FcEntidad
    End Sub

    Public Function Obtener(ByVal Codigo As Integer) As Boolean

    End Function

    Public Function Cancelar() As Boolean

    End Function

    Public Function Guardar1() As Boolean

    End Function
End Class

Public Class ProductosPaqueteCollection
    Inherits ColleccionBase(Of EC.ProductoMezclaEntity, CC.ProductoMezclaCollection, ProductosPaqueteClass)

    Private PPaqueteColl As New CC.ProductoMezclaCollection
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Borrar() As Object
        PPaqueteColl = New CC.ProductoMezclaCollection
        For Each PM As ProductosPaqueteClass In Me
            Dim PPaqueteEntity As New EC.ProductoMezclaEntity
            PPaqueteEntity = PM.ObtenerEntidad()
            PPaqueteColl.Add(PPaqueteEntity)
        Next
        Try
            Dim Conteo As Integer = PPaqueteColl.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        PPaqueteColl = New CC.ProductoMezclaCollection
        For Each PM As ProductosPaqueteClass In Me
            Dim PMezclaEntity As New EC.ProductoMezclaEntity
            PMezclaEntity = PM.ObtenerEntidad()
            PPaqueteColl.Add(PMezclaEntity)
        Next
        Try
            Dim Conteo As Integer = PPaqueteColl.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener() As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = PPaqueteColl.GetDbCount()
            If Conteo > 0 Then
                PPaqueteColl.GetMulti(Nothing)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Private Sub RellenarMe()
        Me.ClearItems()
        For Each PPaqueteEntity As EC.ProductoMezclaEntity In PPaqueteColl
            Dim PM As New ProductosPaqueteClass
            PM.LeerEntidad(PPaqueteEntity)
            Me.Add(PM)
        Next
    End Sub

    Public Function Obtener(ByVal PM As ProductosPaqueteClass) As Integer
        Try
            Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Me.ClearItems()
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.ProductoMezclaFields.CodigoProducto = PM.Paquete)
            filtro.Add(HC.ProductoMezclaFields.CodigoIngrediente = PM.Ingrediente)
            'filtro.AddWithOr(HC.ProductoMezclaFields.Porcentaje = PM.Porcentaje)
            Dim Conteo As Integer = PPaqueteColl.GetDbCount(filtro)
            If Conteo > 0 Then
                PPaqueteColl.GetDbCount(filtro)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerPaqueteColl() As CC.ProductoMezclaCollection
        RellenarPaqueteColl()
        Return PPaqueteColl
    End Function

    Private Sub RellenarPaqueteColl()
        PPaqueteColl = New CC.ProductoMezclaCollection
        For Each PM As ProductosPaqueteClass In Me
            Dim PPaqueteEntity As New EC.ProductoMezclaEntity
            PPaqueteEntity = PM.ObtenerEntidad
            PPaqueteColl.Add(PPaqueteEntity)
        Next
    End Sub

    Public Sub LeerColeccion(ByVal Coleccion As CC.ProductoMezclaCollection)
        PPaqueteColl = Coleccion
        RellenarMe()
    End Sub

End Class