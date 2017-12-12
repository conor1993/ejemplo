Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class PoblacionClass
    Inherits ClassBase(Of EC.PoblacionEntity)

    Private _PoblacionCollection As New CC.PoblacionCollection
    Private _Ciudad As New CiudadClass
    Private _Zonas As ZonaCollectionClass

    <System.ComponentModel.DisplayName("Estado")> _
        Public Property CodigoEstado() As EstadoClass
        Get
            'm_Ciudad.LeerEntidad(PoblacionEntity.McatGenCiudades)
            _Ciudad = CodigoCiudad
            Return _Ciudad.CodigoEstado
        End Get
        Set(ByVal value As EstadoClass)
            If IsNothing(value) Then
                Throw New Exception("Debe seleccionar un Estado")
            Else
                _Ciudad.CodigoEstado = value
                Entity.PidEstado = value.ObtenerEntidad.Codigo
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Ciudad")> _
    Public Property CodigoCiudad() As CiudadClass
        Get
            _Ciudad = New CiudadClass(Entity.PidEstado, Entity.CodigoCiudad)
            Return _Ciudad
        End Get
        Set(ByVal value As CiudadClass)
            If IsNothing(value) Then
                Throw New Exception("Debe seleccionar una ciudad")
            Else
                _Ciudad = value
                Entity.CodigoCiudad = value.Codigo
                'PoblacionEntity.McatGenCiudades = m_Ciudad.ObtenerEntidad
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Codigo Poblacion")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Debe ingresar una Descripcion")
            Else
                Entity.Descripcion = value
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Debe ingresar una Descripcion Corta")
            Else
                Entity.DescripcionCorta = value
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Sub New()
        'Inicializacion de Todas las variables
        Entity = New EC.PoblacionEntity
        _Ciudad = New CiudadClass
        Entity.Descripcion = ""
        Entity.DescripcionCorta = ""
        Entity.Observaciones = ""
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As EC.PoblacionEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdEstado As Integer, ByVal IdCiudad As Integer, ByVal IdPoblacion As Integer)
        Entity = New EC.PoblacionEntity(IdEstado, IdCiudad, IdPoblacion)
    End Sub

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Entity.Estatus = EstatusEnum.INACTIVO
            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim col As New CC.PoblacionCollection

            If Entity.IsNew Then
                If col.GetDbCount(HC.PoblacionFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una población con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.PoblacionFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe una población con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Entity.Save
            Else
                If col.GetDbCount(Not HC.PoblacionFields.Codigo = Codigo And HC.PoblacionFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una población con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.PoblacionFields.Codigo = Codigo And HC.PoblacionFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe una población con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal CodEstado As Integer, ByVal CodCiudad As Integer, ByVal Codigo As Integer) As Boolean
        Try
            If Entity.FetchUsingPK(CodEstado, CodCiudad, Codigo) Then
                Return True
            End If
            Throw New Exception("La Población especificada no existe.")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return False
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function
End Class

Public Class PoblacionCollectionClass
    Inherits ColleccionBase(Of EC.PoblacionEntity, CC.PoblacionCollection, PoblacionClass)

    Private PoblacionCollection As New CC.PoblacionCollection
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()

            If Not fcCondicion = CondicionEnum.Todos Then
                PoblacionCollection.GetMulti(HC.PoblacionFields.Estatus = fcCondicion)
            Else
                PoblacionCollection.GetMulti(Nothing)
            End If

            For Each poblacionEntity As EC.PoblacionEntity In PoblacionCollection
                Dim poblacion As New PoblacionClass
                poblacion.LeerEntidad(poblacionEntity)
                Me.Add(poblacion)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal fcCondicion As CondicionEnum, ByVal CodEstado As Integer, ByVal CodCiudad As Integer) As Integer
        Try
            Me.ClearItems()

            If Not fcCondicion = CondicionEnum.TODOS Then
                PoblacionCollection.GetMulti(HC.PoblacionFields.Estatus = fcCondicion And HC.PoblacionFields.PidEstado = CodEstado And HC.PoblacionFields.CodigoCiudad = CodCiudad)
            Else
                PoblacionCollection.GetMulti(Nothing)
            End If

            For Each poblacionEntity As EC.PoblacionEntity In PoblacionCollection
                Dim poblacion As New PoblacionClass
                poblacion.LeerEntidad(poblacionEntity)
                Me.Add(poblacion)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function


    Public Function Obtener(ByVal Poblacion As PoblacionClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.PoblacionFields.Codigo = Poblacion.Codigo)
            Filtro.AddWithOr(HC.PoblacionFields.DescripcionCorta = Poblacion.DescripcionCorta)
            Dim Conteo As Integer = PoblacionCollection.GetDbCount(Filtro)
            If Conteo > 0 Then
                PoblacionCollection.GetMulti(Filtro)
                For Each PoblacionEntity As EC.PoblacionEntity In PoblacionCollection
                    Dim MiPoblacion As New PoblacionClass
                    MiPoblacion.LeerEntidad(PoblacionEntity)
                    Me.Add(MiPoblacion)
                Next
            End If
            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal ciudad As CiudadClass, Optional ByVal fcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.Clear()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            If Not fcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.PoblacionFields.Estatus = fcCondicion)
            End If
            Filtro.Add(HC.PoblacionFields.CodigoCiudad = ciudad.Codigo)

            PoblacionCollection.GetMulti(Filtro)

            Dim Conteo As Integer = PoblacionCollection.Count
            Me.Rellenar()
            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtenercoleccion() As CC.PoblacionCollection
        RellenarColeccion()
        Return PoblacionCollection
    End Function

    Private Overloads Sub RellenarColeccion()
        For Each Poblacion As PoblacionClass In Me
            Dim PoblacionE As New EC.PoblacionEntity
            PoblacionE = Poblacion.ObtenerEntidad
            PoblacionCollection.Add(PoblacionE)
        Next
    End Sub

    Private Overloads Sub Rellenar()
        For Each poblacion As EC.PoblacionEntity In PoblacionCollection
            Dim mipoblacion As New PoblacionClass
            mipoblacion.LeerEntidad(poblacion)
            Me.Add(mipoblacion)
        Next
    End Sub

    Public Function Guardar() As Integer
        PoblacionCollection = New CC.PoblacionCollection
        For Each Poblacion As PoblacionClass In Me
            Dim PoblacionEntity As New EC.PoblacionEntity
            PoblacionEntity = Poblacion.ObtenerEntidad()
            PoblacionCollection.Add(PoblacionEntity)
        Next
        Try
            Dim Conteo As Integer = PoblacionCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        PoblacionCollection = New CC.PoblacionCollection
        For Each Poblacion As PoblacionClass In Me
            Dim PoblacionEntity As New EC.PoblacionEntity
            PoblacionEntity = Poblacion.ObtenerEntidad()
            PoblacionCollection.Add(PoblacionEntity)
        Next
        Try
            Dim Conteo As Integer = PoblacionCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Reporte() As CRepPblacion
        Dim Reportes As New CRepPblacion
        Dim ds As New DataSet
        Dim dtPob As New DSetPoblacion.PoblacionDataTable
        For Each Pob As PoblacionClass In Me
            dtPob.AddPoblacionRow(Pob.Codigo, Pob.Descripcion, Pob.DescripcionCorta, Pob.Observaciones, Pob.CodigoEstado.Descripcion, Pob.CodigoCiudad.Descripcion, Pob.Estatus.ToString)
        Next
        ds.Tables.Add(dtPob)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class
