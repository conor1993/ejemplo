Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class NutrienteporProductoClass
    Inherits ClassBase(Of EC.DetAlimentosEntity)

#Region "Miembros"
    Dim m_producto As ProductoClass
    Dim m_Nutriente As NutrienteClass
#End Region

#Region "Contructores"
    Sub New()

    End Sub

    Sub New(ByVal IdProducto As Integer, ByVal IdNutriente As Integer)
        Entity = New EC.DetAlimentosEntity(IdProducto, IdNutriente)
    End Sub

    Sub New(ByVal Entidad As EC.DetAlimentosEntity)
        Entity = Entidad
    End Sub
#End Region

#Region "Propiedades"
    Property IdProducto() As Integer
        Get
            Return Entity.CveAlimento
        End Get
        Set(ByVal value As Integer)
            Entity.CveAlimento = value
        End Set
    End Property

    Property IdNutriente() As Integer
        Get
            Return Entity.CveNutriente
        End Get
        Set(ByVal value As Integer)
            Entity.CveNutriente = value
        End Set
    End Property

    Property PorcentajeNutriente() As Decimal
        Get
            Return Entity.PtjNutriente
        End Get
        Set(ByVal value As Decimal)
            Entity.PtjNutriente = value
        End Set
    End Property

    Property IdRenglon() As Integer
        Get
            Return Entity.CveRenglon
        End Get
        Set(ByVal value As Integer)
            Entity.CveRenglon = value
        End Set
    End Property

    Property Producto() As ProductoClass
        Get
            If Me.m_producto Is Nothing Then
                Me.m_producto = New ProductoClass
                m_producto.LeerEntidad(Me.Entity.Producto)
            End If

            Return m_producto
        End Get
        Set(ByVal value As ProductoClass)
            m_producto = value

            If value Is Nothing Then
                m_producto.Entidad = Nothing
            Else
                m_producto.Entidad = value.Entidad
            End If
        End Set
    End Property

    Property Nutriente() As NutrienteClass
        Get
            If Me.m_Nutriente Is Nothing Then
                Me.m_Nutriente = New NutrienteClass
                m_Nutriente.LeerEntidad(Me.Entity.CatNutrientes)
            End If

            Return m_Nutriente
        End Get
        Set(ByVal value As NutrienteClass)
            m_Nutriente = value

            If value Is Nothing Then
                m_Nutriente.Entidad = Nothing
            Else
                m_Nutriente.Entidad = value.Entidad
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Dim Nuevo As Boolean = False

        If Not Trans Is Nothing Then
            Trans.Add(Entity)
        Else
            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "NutrienteporAlimento")
            Trans.Add(Entity)
            Nuevo = True
        End If

        Try
            If Not Entity.Save() Then
                Throw New Exception("Error al intentar guardar el nutriente del alimento, Intente de nuevo")
            End If

            If Nuevo Then
                Trans.Commit()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Return Entity.Delete(Trans)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.DetAlimentosEntity)
        Entity = Entidad
    End Sub

    Public Shared Function CargarNutrientedeAlimento(ByVal IdProducto As Integer, ByVal IdNutriente As Integer) As NutrienteporProductoClass
        Return New NutrienteporProductoClass(IdProducto, IdNutriente)
    End Function
#End Region
End Class

Public Class NutrientesporProductoCollectionClass
    Inherits ColleccionBase(Of EC.DetAlimentosEntity, CC.DetAlimentosCollection, NutrienteporProductoClass)

#Region "Contructores"
#End Region
End Class
