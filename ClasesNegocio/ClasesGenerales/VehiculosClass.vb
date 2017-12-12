Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class VehiculosClass
    Inherits ClassBase(Of EC.McgcatVehiculosEntity)

#Region "Costructores"
    Sub New()
        Entity = New EC.McgcatVehiculosEntity
    End Sub

    Sub New(ByVal Entidad As EC.McgcatVehiculosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.McgcatVehiculosEntity(Codigo)
    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.IdVehiculo
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.DescVehiculo
        End Get
        Set(ByVal value As String)
            Entity.DescVehiculo = value
        End Set
    End Property

    Property DesCorta() As String
        Get
            Return Entity.DescCorVehiculo
        End Get
        Set(ByVal value As String)
            Entity.DescCorVehiculo = value
        End Set
    End Property

    Public Property FechaCompra() As Date
        Get
            Return Entity.FechaCompra
        End Get
        Set(ByVal value As Date)
            Entity.FechaCompra = value
        End Set
    End Property

    Property Marca() As String
        Get
            Return Entity.Marca
        End Get
        Set(ByVal value As String)
            Entity.Marca = value
        End Set
    End Property

    Property Modelo() As Integer
        Get
            Return Entity.Modelo
        End Get
        Set(ByVal value As Integer)
            Entity.Modelo = value
        End Set
    End Property

    Property Placas() As String
        Get
            Return Entity.Placas
        End Get
        Set(ByVal value As String)
            Entity.Placas = value
        End Set
    End Property

    Public Property NoSerie() As String
        Get
            Return Entity.NoSerie
        End Get
        Set(ByVal value As String)
            Entity.NoSerie = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
        End Set
    End Property

    Public Property IdUsuarioBaja() As Integer
        Get
            Return Entity.QuiendioBaja
        End Get
        Set(ByVal value As Integer)
            Entity.QuiendioBaja = value
        End Set
    End Property

    Public Property MotivoBaja() As String
        Get
            Return Entity.MotivoBaja
        End Get
        Set(ByVal value As String)
            Entity.MotivoBaja = value
        End Set
    End Property

    Public Property Estatus() As EstatusChar
        Get
            Return Asc(Entity.Estatus)
        End Get
        Set(ByVal value As EstatusChar)
            Entity.Estatus = Chr(value)
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
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
                Estatus = EstatusChar.VIGENTE

                Return Entity.Save
            Else
                Dim Coleccion As New CC.McgcatVehiculosCollection

                If Coleccion.GetDbCount(HC.McgcatVehiculosFields.DescVehiculo = Descripcion And HC.McgcatVehiculosFields.Estatus = EstatusCharX.VIGENTE) > 1 Then
                    MsgBox("Ya existe otro Vehiculo con esta descripcion, Ingrese otra", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If Coleccion.GetDbCount(HC.McgcatVehiculosFields.DescCorVehiculo = DesCorta And HC.McgcatVehiculosFields.Estatus = EstatusCharX.VIGENTE) > 1 Then
                    MsgBox("Ya existe otro Vehiculo con esta descripcion corta, Ingrese otra", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Return Entity.Save
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Me.Estatus = EstatusChar.CANCELADO

        Return MyBase.Borrar(Trans)
    End Function
#End Region
End Class

Public Class VehiculosCollectionClass
    Inherits ColleccionBase(Of EC.McgcatVehiculosEntity, CC.McgcatVehiculosCollection, VehiculosClass)

    Public Overloads Function Obtener(ByVal Estatus As EstatusCharX, Optional ByVal Descripcion As String = "") As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not Estatus = EstatusCharX.TODOS Then
                Filtro.Add(HC.McgcatVehiculosFields.Estatus = Chr(Estatus))
            End If

            If Not Descripcion = "" Then
                Filtro.Add(HC.McgcatVehiculosFields.DescVehiculo Mod String.Format("%{0}%", Descripcion))
            End If

            Return Me.Obtener(Filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptCatVehiculos
        Dim Reportes As New rptCatVehiculos
        Dim ds As New DataSet
        Dim dtVehiculos As New DSetCatVehiculos.dtVehiculosDataTable
        For Each Vehiculos As VehiculosClass In Me
            dtVehiculos.AdddtVehiculosRow(Vehiculos.Codigo, Vehiculos.DesCorta, Vehiculos.Descripcion, Vehiculos.Marca, Vehiculos.Modelo, Vehiculos.Placas, Vehiculos.NoSerie, Vehiculos.Estatus.ToString)
        Next
        ds.Tables.Add(dtVehiculos)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class