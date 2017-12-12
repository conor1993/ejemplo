Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ChoferesClass
    Inherits ClassBase(Of EC.McgcatChoferesEntity)
    Dim _Estado As EstadoClass
    Dim _Ciudad As CiudadClass
    Dim _Poblacion As PoblacionClass

#Region "Constructores"
    Sub New()
        Entity = New EC.McgcatChoferesEntity
    End Sub

    Sub New(ByVal Entidad As EC.McgcatChoferesEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdChofer As Integer)
        Entity = New EC.McgcatChoferesEntity(IdChofer)
    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property IdChofer() As Integer
        Get
            Return Entity.IdChofer
        End Get
    End Property

    Public Property Nombre() As String
        Get
            Return Entity.NombreChofer
        End Get
        Set(ByVal value As String)
            Entity.NombreChofer = value
        End Set
    End Property

    Public Property Apellido_Paterno() As String
        Get
            Return Entity.ApPatChofer
        End Get
        Set(ByVal value As String)
            Entity.ApPatChofer = value
        End Set
    End Property

    Public Property Apellido_Materno() As String
        Get
            Return Entity.ApMatChofer
        End Get
        Set(ByVal value As String)
            Entity.ApMatChofer = value
        End Set
    End Property

    Public Property NombreCorto() As String
        Get
            Return Entity.NomCorChofer
        End Get
        Set(ByVal value As String)
            Entity.NomCorChofer = value
        End Set
    End Property

    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Trim(Entity.NombreChofer) & " " & Trim(Entity.ApPatChofer) & " " & Trim(Entity.ApMatChofer)
        End Get
    End Property

    Public Property Domicilio() As String
        Get
            Return Entity.Domicilio
        End Get
        Set(ByVal value As String)
            Entity.Domicilio = value
        End Set
    End Property

    Public Property Colonia() As String
        Get
            Return Entity.Colonia
        End Get
        Set(ByVal value As String)
            Entity.Colonia = value
        End Set
    End Property

    Public Property Poblacion() As PoblacionClass
        Get
            If _Poblacion Is Nothing Then
                _Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            End If
            Return _Poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            _Poblacion = value
            If value Is Nothing Then
                Entity.IdPoblacion = -1
            Else
                Entity.IdPoblacion = value.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomPoblacion() As String
        Get
            Return Poblacion.Descripcion
        End Get
    End Property

    Public Property Ciudad() As CiudadClass
        Get
            If _Ciudad Is Nothing Then
                _Ciudad = New CiudadClass(Entity.IdEstado, Entity.IdCiudad)
            End If
            Return _Ciudad
        End Get
        Set(ByVal value As CiudadClass)
            _Ciudad = value
            If value Is Nothing Then
                Entity.IdCiudad = -1
            Else
                Entity.IdCiudad = value.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomCiudad() As String
        Get
            Return Ciudad.Descripcion
        End Get
    End Property

    Public Property Estado() As EstadoClass
        Get
            If _Estado Is Nothing Then
                _Estado = New EstadoClass(Entity.IdEstado)
            End If

            Return _Estado
        End Get
        Set(ByVal value As EstadoClass)
            _Estado = value
            If value Is Nothing Then
                Entity.IdEstado = -1
            Else
                Entity.IdEstado = value.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomEstado() As String
        Get
            Return Estado.Descripcion
        End Get
    End Property

    Public Property Telefono() As String
        Get
            Return Entity.Telefono
        End Get
        Set(ByVal value As String)
            Entity.Telefono = value
        End Set
    End Property

    Public Property TelefonoCel() As String
        Get
            Return Entity.TelefonoCel
        End Get
        Set(ByVal value As String)
            Entity.TelefonoCel = value
        End Set
    End Property

    Public Property NoLicencia() As String
        Get
            Return Entity.NoLicencia
        End Get
        Set(ByVal value As String)
            Entity.NoLicencia = value
        End Set
    End Property

    Public Property TipoLicencia() As Char
        Get
            Return Entity.TipoLicencia
        End Get
        Set(ByVal value As Char)
            Entity.TipoLicencia = value
        End Set
    End Property

    Public Property FechaVenciLicencia() As Date
        Get
            Return Entity.FechaVenceLicencia
        End Get
        Set(ByVal value As Date)
            Entity.FechaVenceLicencia = value
        End Set
    End Property

    Public Property TipoSangre() As String
        Get
            Return Entity.TipoSangre
        End Get
        Set(ByVal value As String)
            Entity.TipoSangre = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
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

    Public Property UsuarioBajaId() As Integer
        Get
            Return Entity.QuiendioBaja
        End Get
        Set(ByVal value As Integer)
            Entity.QuiendioBaja = value
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

    Public Function Obtener(ByVal CodChofer As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(CodChofer)
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
                Dim Col As New CC.McgcatChoferesCollection

                If Col.GetDbCount(HC.McgcatChoferesFields.NombreChofer = Me.Nombre And HC.McgcatChoferesFields.ApPatChofer = Me.Apellido_Paterno _
                                 And HC.McgcatChoferesFields.ApMatChofer = Me.Apellido_Materno) > 1 Then
                    MsgBox("Ya existe un chofer registrado con este nombre", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Return Entity.Save
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

Public Class ChoferesCollectionClass
    Inherits ColleccionBase(Of EC.McgcatChoferesEntity, CC.McgcatChoferesCollection, ChoferesClass)

    Public Overloads Function Obtener(Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.McgcatChoferesFields.NombreChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Ordenamiento.Add(New OC.SortClause(HC.McgcatChoferesFields.ApPatChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Ordenamiento.Add(New OC.SortClause(HC.McgcatChoferesFields.ApMatChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Estatus = CondicionEnum.ACTIVOS Then
                Filtro.Add(HC.McgcatChoferesFields.Estatus = Chr(EstatusCharX.VIGENTE))
            End If

            If Estatus = CondicionEnum.INACTIVOS Then
                Filtro.Add(HC.McgcatChoferesFields.Estatus = Chr(EstatusCharX.CANCELADO))
            End If

            coleccion.GetMulti(Filtro, 0, Ordenamiento)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function Obtener(ByVal NomCompleto As String) As Integer
        Try
            Me.Clear()
            Dim Filtro As New OC.PredicateExpression
            Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.McgcatChoferesFields.NombreChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Ordenamiento.Add(New OC.SortClause(HC.McgcatChoferesFields.ApPatChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Ordenamiento.Add(New OC.SortClause(HC.McgcatChoferesFields.ApMatChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))


            If Not NomCompleto = "" Then
                Filtro.Add(HC.McgcatChoferesFields.NombreChofer Mod String.Format("%{0}%", NomCompleto) Or HC.McgcatChoferesFields.ApPatChofer Mod _
                       String.Format("%{0}%", NomCompleto) Or HC.McgcatChoferesFields.ApMatChofer Mod String.Format("%{0}%", NomCompleto))
            End If
            coleccion.GetMulti(Filtro, 0, Ordenamiento)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal fcEstatus As CondicionEstatusEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not fcEstatus = CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.McecatCorralesCabFields.Estatus = fcEstatus)
            End If

            Return Obtener(filtro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Reporte() As rptCatChoferes
        Dim Reportes As New rptCatChoferes
        Dim ds As New DataSet
        Dim dtChoferes As New DSetCatChoferes.dtChoferesDataTable
        For Each Choferes As ChoferesClass In Me
            dtChoferes.AdddtChoferesRow(Choferes.IdChofer, Choferes.NombreCompleto, Choferes.Estado.Descripcion, Choferes.Ciudad.Descripcion, Choferes.Poblacion.Descripcion, Choferes.Estatus.ToString)
        Next
        ds.Tables.Add(dtChoferes)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class