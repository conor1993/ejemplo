Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses


Public Class TiposNotasCreditoClass

    #Region "Miembros"
    Inherits ClassBase(Of EC.CatTipNotasEntity)

    Dim _CuentaCont As CuentaContableClass
    #End Region

    #region "Constructores"

    Sub New()
        Entity = New EC.CatTipNotasEntity
    End Sub

    Sub New(ByVal Entidad As EC.CatTipNotasEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.CatTipNotasEntity(Codigo)
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.CveTipNota
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.NomTipNota
        End Get
        Set(ByVal value As String)
            Entity.NomTipNota = value
        End Set
    End Property

    Public Property IdCuentaContable() As Integer
        Get
            Return Entity.IdCuentaContable
        End Get
        Set(ByVal value As Integer)
            Entity.IdCuentaContable = value
        End Set
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get
            If IsNothing(_CuentaCont) Then
                _CuentaCont = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _CuentaCont
        End Get
        Set(ByVal value As CuentaContableClass)
            _CuentaCont = value
            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property NomCuenta() As String
        Get
            Return CuentaContable.NombreLargo
        End Get
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            Entity.Estatus = value
        End Set
    End Property

    Public ReadOnly Property FechaAlta() As DateTime
        Get
            Return Entity.FehaAlta
        End Get
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Dim Coleccion As New CC.CatTipNotasCollection
                If Coleccion.GetDbCount(HC.CatTipNotasFields.NomTipNota = Descripcion) > 0 Then
                    MsgBox("Ya existe otro concepto de nota de crédito con la misma descripción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                Else
                    Return Entity.Save
                End If
            Else
                Dim Coleccion As New CC.CatTipNotasCollection
                If Coleccion.GetDbCount(Not HC.CatTipNotasFields.CveTipNota = Me.Codigo And HC.CatTipNotasFields.NomTipNota = Descripcion) > 0 Then
                    MsgBox("Ya existe otro concepto de nota de crédito con la misma descripción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                Else
                    Return Entity.Save
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region

End Class

Public Class TiposNotasCreditoCollectionClass
    Inherits ColleccionBase(Of EC.CatTipNotasEntity, CC.CatTipNotasCollection, TiposNotasCreditoClass)

    Public Overloads Function Obtener(ByVal Estatus As CondicionEnum) As Integer
        Try
            If Not Estatus = CondicionEnum.TODOS Then
                coleccion.GetMulti(HC.CatTipNotasFields.Estatus = Estatus)
            Else
                coleccion.GetMulti(Nothing)
            End If
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class

