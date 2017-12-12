Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses


Public Class ProductosMezclaClass
    Implements IEntidad


    Private PMezcla As EC.ProductoMezclaEntity
    Private PMezclas As New CC.ProductoMezclaCollection
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private m_producto As New ProductoGeneralClass()
    Private m_productoIng As New ProductoGeneralClass()

    Public Property Mezcla() As ProductoGeneralClass
        Get
            m_producto.LeerEntidad(PMezcla.Producto)
            Return m_producto
        End Get
        Set(ByVal value As ProductoGeneralClass)
            m_producto = value
            PMezcla.Producto = m_producto.ObtenerEntidad
        End Set
    End Property

    Public Property Ingrediente() As ProductoGeneralClass
        Get
            m_productoIng.LeerEntidad(PMezcla.Producto_)
            Return m_productoIng
        End Get
        Set(ByVal value As ProductoGeneralClass)
            m_productoIng = value
            PMezcla.Producto_ = m_productoIng.ObtenerEntidad
        End Set
    End Property

    Public Property Porcentaje() As Decimal
        Get
            Return PMezcla.Porcentaje
        End Get
        Set(ByVal value As Decimal)
            PMezcla.Porcentaje = value
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            If PMezcla.Save Then
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

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar() As Boolean
        Try
            If PMezcla.Save Then
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

        PMezcla = New EC.ProductoMezclaEntity

        PMezcla.CodigoIngrediente = Nothing
        PMezcla.CodigoProducto = Nothing
        PMezcla.Porcentaje = 0
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Ingrediente.Descripcion
    End Function

    Public Function ObtenerEntidad() As EC.ProductoMezclaEntity
        Return PMezcla
    End Function

    Public Sub LeerEntidad(ByVal FcEntidad As EC.ProductoMezclaEntity)
        PMezcla = FcEntidad
    End Sub

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ProductosMezclaCollection
    Inherits CollectionClass(Of ProductosMezclaClass)

    Private PMezclaColl As New CC.ProductoMezclaCollection
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Borrar() As Object
        PMezclaColl = New CC.ProductoMezclaCollection
        For Each PM As ProductosMezclaClass In Me
            Dim PMezclaEntity As New EC.ProductoMezclaEntity
            PMezclaEntity = PM.ObtenerEntidad()
            PMezclaColl.Add(PMezclaEntity)
        Next
        Try
            Dim Conteo As Integer = PMezclaColl.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        PMezclaColl = New CC.ProductoMezclaCollection
        For Each PM As ProductosMezclaClass In Me
            Dim PMezclaEntity As New EC.ProductoMezclaEntity
            PMezclaEntity = PM.ObtenerEntidad()
            PMezclaColl.Add(PMezclaEntity)
        Next
        Try
            Dim Conteo As Integer = PMezclaColl.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener() As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = PMezclaColl.GetDbCount()
            If Conteo > 0 Then
                PMezclaColl.GetMulti(Nothing)
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
        For Each PMezclaEntity As EC.ProductoMezclaEntity In PMezclaColl
            Dim PM As New ProductosMezclaClass
            PM.LeerEntidad(PMezclaEntity)
            Me.Add(PM)
        Next
    End Sub

    Public Function Obtener(ByVal PM As ProductosMezclaClass) As Integer
        Try
            Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Me.ClearItems()
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.ProductoMezclaFields.CodigoProducto = PM.Mezcla)
            filtro.AddWithOr(HC.ProductoMezclaFields.CodigoIngrediente = PM.Ingrediente)
            'filtro.AddWithOr(HC.ProductoMezclaFields.Porcentaje = PM.Porcentaje)
            Dim Conteo As Integer = PMezclaColl.GetDbCount(filtro)
            If Conteo > 0 Then
                PMezclaColl.GetDbCount(filtro)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerPMezclaColl() As CC.ProductoMezclaCollection
        RellenarPMezclaColl()
        Return PMezclaColl
    End Function

    Private Sub RellenarPMezclaColl()
        PMezclaColl = New CC.ProductoMezclaCollection
        For Each PM As ProductosMezclaClass In Me
            Dim PMezclaEntity As New EC.ProductoMezclaEntity
            PMezclaEntity = PM.ObtenerEntidad
            PMezclaColl.Add(PMezclaEntity)
        Next
    End Sub

    Public Sub LeerColeccion(ByVal Coleccion As CC.ProductoMezclaCollection)
        PMezclaColl = Coleccion
        RellenarMe()
    End Sub

End Class