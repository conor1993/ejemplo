Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class ServiciosClass
    Inherits ClassBase(Of EC.ServiciosEntity)

#Region "Propiedades"

    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.NomServicio
        End Get
        Set(ByVal value As String)
            Entity.NomServicio = value
        End Set
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            Entity.Estatus = value
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
        End Set
    End Property

    Public Property TipoServicio() As TipoServicionEnum
        Get
            Return Entity.TipoServicio
        End Get
        Set(ByVal value As TipoServicionEnum)
            Entity.TipoServicio = value
        End Set
    End Property
    Public Property Costo() As Decimal

        Get
            Return Entity.Costo
        End Get
        Set(ByVal value As Decimal)
            Entity.Costo = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Overloads Function Guardar() As Boolean
        Try
            Dim Col As New CC.ServiciosCollection
            If Entity.IsNew Then
                If Col.GetDbCount(Not HC.ServiciosFields.Codigo = Codigo And HC.ServiciosFields.NomServicio = Descripcion) > 0 Then
                    MsgBox("Ya existe otro servicio con el mismo nombre, Ingrese otro", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Return Entity.Save
            Else
                If Col.GetDbCount(HC.ServiciosFields.Codigo = Codigo And HC.ServiciosFields.NomServicio = Descripcion) > 0 Then
                    MsgBox("Ya existe otro servicio con el mismo nombre, Ingrese otro", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Return Entity.FetchUsingPK(Codigo)
    End Function

#End Region

#Region "Costructores"

    Sub New()
        Entity = New EC.ServiciosEntity
    End Sub

    Sub New(ByVal Entidad As EC.ServiciosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codgigo As Integer)
        Entity = New EC.ServiciosEntity(Codigo)
    End Sub
#End Region
End Class

Public Class ServiciosCollectionClass
    Inherits ColleccionBase(Of EC.ServiciosEntity, CC.ServiciosCollection, ServiciosClass)

    Public Overloads Function Obtener(ByVal Descripcion As String) As Integer
        Try
            If Not Descripcion = "" Then
                coleccion.GetMulti(HC.ServiciosFields.Estatus = EstatusDatos.VIGENTE And HC.ServiciosFields.NomServicio Mod String.Format("%{0}%", Descripcion))
            Else
                coleccion.GetMulti(Nothing)
            End If

            Rellenar()
            Return Count
        Catch ex As Exception
            Return -1
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function Obtener(ByVal TipoServicio As TipoServicionEnum) As Integer
        Try
            coleccion.GetMulti(HC.ServiciosFields.Estatus = EstatusDatos.VIGENTE And HC.ServiciosFields.TipoServicio = TipoServicio)

            Rellenar()
            Return Count
        Catch ex As Exception
            Return -1
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As RptServicios
        Dim Ds As New DataSet
        Dim Tabla As New DsServicios.ServiciosDataTable
        For Each Serv As ServiciosClass In Me
            Tabla.AddServiciosRow(Serv.Codigo, Serv.Descripcion, Serv.TipoServicio.ToString, Serv.Estatus.ToString, Serv.FechaAlta)
        Next
        Ds.Tables.Add(Tabla)
        Dim Report As New RptServicios
        Report.SetDataSource(Ds)
        Report.SetParameterValue(0, Empresa)
        Report.SetParameterValue(1, Usuario)
        Report.SetParameterValue(2, "Catalogos \ Servicios de Rastros")
        Return Report
    End Function
End Class
