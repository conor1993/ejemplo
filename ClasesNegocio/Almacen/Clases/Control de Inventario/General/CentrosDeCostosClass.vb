Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CentrosDeCostosClass
    Inherits ClassBase(Of EC.McatCentroCostosEntity)
    Dim _plaza As New PlazaClass
    Dim _Cuenta As CuentaContableClass

#Region "Costructores"
    Sub New()
        Entity = New EC.McatCentroCostosEntity
    End Sub

    Sub New(ByVal Entidad As EC.McatCentroCostosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdPlaza As Integer, ByVal Codigo As Integer)
        Entity = New EC.McatCentroCostosEntity(IdPlaza, Codigo)
    End Sub
#End Region

#Region "Propiedades"

    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.IdCentroCostoAlm
        End Get
    End Property

    'Public Property IdPlaza() As PlazaClass
    '    Get
    '        _plaza.LeerEntidad(Entity.Plaza)
    '        Return _plaza
    '    End Get
    '    Set(ByVal value As PlazaClass)
    '        _plaza = value
    '        Entity.Plaza = _plaza.ObtenerEntidad
    '    End Set
    'End Property

    Public Property IdPlaza() As Integer
        Get
            Return Entity.IdPlaza
        End Get
        Set(ByVal value As Integer)
            Entity.IdPlaza = value
        End Set
    End Property

    'Public Overridable Property Plaza() As PlazaClass
    '    Get
    '        If _plaza Is Nothing Then
    '            _plaza = New PlazaClass()
    '        End If
    '        Return _plaza
    '    End Get
    '    Set(ByVal value As PlazaClass)
    '        _plaza = value
    '        If value Is Nothing Then
    '            Entity.Plaza = Nothing
    '        Else
    '            Entity.Plaza = value.ObtenerEntidad
    '        End If
    '    End Set
    'End Property

    'Public ReadOnly Property NomPlaza() As String
    '    Get
    '        Return Plaza.Descripcion
    '    End Get
    'End Property

    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public Property IdCuentaContable() As Integer
        Get
            Return Entity.IdCuentaCont
        End Get
        Set(ByVal value As Integer)
            Entity.IdCuentaCont = value
        End Set
    End Property

    Public Property Cuenta() As CuentaContableClass
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _Cuenta
        End Get
        Set(ByVal value As CuentaContableClass)
            _Cuenta = value
            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property NomCuenta() As String
        Get
            Return Cuenta.NombreLargo
        End Get
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property
#End Region

    Public Function Obtener(ByVal IdPlaza As Integer, ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(IdPlaza, Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As HC.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Return Entity.Save
            Else
                Dim Col As New CC.McatCentroCostosCollection
                If Col.GetDbCount(Not HC.McatCentroCostosFields.IdCentroCostoAlm = Me.Codigo And HC.McatCentroCostosFields.Descripcion = Me.Descripcion) > 0 Then
                    MsgBox("Ya existe otro centro de costos con la misma Descripción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class

Public Class CentroDeCostosCollectionClass
    Inherits ColleccionBase(Of EC.McatCentroCostosEntity, CC.McatCentroCostosCollection, CentrosDeCostosClass)

    Public Overloads Function Obtener(ByVal Descripcion As String) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not Descripcion = "" Then _
                filtro.Add(HC.McatCentroCostosFields.Descripcion Mod String.Format("%{0}%", Descripcion))

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not fcCondicion = CondicionEnum.TODOS Then _
                filtro.Add(HC.PlazaFields.Estatus = fcCondicion)

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

End Class