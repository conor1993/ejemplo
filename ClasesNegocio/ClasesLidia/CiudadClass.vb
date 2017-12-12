Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class CiudadClass
    Implements IEntidad
    'Inherits ClassBase(Of EC.CiudadEntity)

    Private CiudadEntity As EC.CiudadEntity
    Private CiudadCollection As New CC.CiudadCollection
    Private PoblacionEntity As EC.PoblacionEntity
    Private m_estado As EstadoClass

    Public Property CodigoEstado() As EstadoClass
        Get
            m_estado.LeerEntidad(CiudadEntity.Estado)
            Return m_estado
        End Get
        Set(ByVal value As EstadoClass)
            If IsNothing(value) Then
                RaiseEvent MensajeError(Me, "Debe seleccionar un Estado")
                Throw New SystemException(" ")
            Else
                m_estado = value
                CiudadEntity.Estado = m_estado.ObtenerEntidad
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Codigo")> _
        Public ReadOnly Property Codigo() As Integer
        Get
            Return CiudadEntity.Codigo()
        End Get
    End Property

   

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return CiudadEntity.Descripcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Descripcion", "Debe ingresar una descripción")
                Throw New SystemException(" ")
            Else
                CiudadEntity.Descripcion = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return CiudadEntity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("DescripcionCorta", "Debe ingresar una descripción corta")
                Throw New SystemException(" ")
            Else
                CiudadEntity.DescripcionCorta = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return CiudadEntity.Observaciones
        End Get
        Set(ByVal value As String)
            CiudadEntity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return CiudadEntity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            CiudadEntity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public ReadOnly Property Poblaciones() As PoblacionCollectionClass
        Get
            Dim PobCol As New PoblacionCollectionClass
            PobCol.Obtener(Me, CondicionEnum.ACTIVOS)
            Return PobCol
        End Get
    End Property

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        CiudadEntity = New EC.CiudadEntity
        m_estado = New EstadoClass
        CiudadEntity.Descripcion = ""
        CiudadEntity.DescripcionCorta = ""
        CiudadEntity.Observaciones = ""
        CiudadEntity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As EC.CiudadEntity)
        CiudadEntity = Entidad
    End Sub

    Sub New(ByVal CodEstado As Integer, Codigo As Integer)
        CiudadEntity = New EC.CiudadEntity(CodEstado, Codigo)
    End Sub

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.PoblacionCollection

            If col.GetDbCount(HC.PoblacionFields.CodigoCiudad = Codigo And HC.PoblacionFields.Estatus = 1) > 0 Then
                MsgBox("No es posible dar de baja la ciudad, cuenta con poblaciones activas", MsgBoxStyle.Exclamation, "Poblaciones Activas")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO

            Return CiudadEntity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean Implements IEntidad.Guardar
        Try
            Dim col As New CC.CiudadCollection

            If CiudadEntity.IsNew Then
                If col.GetDbCount(HC.CiudadFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una ciudad con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.CiudadFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya exste una ciudad con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return CiudadEntity.Save
            Else
                If col.GetDbCount(Not HC.CiudadFields.Codigo = Codigo And HC.CiudadFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una ciudad con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.CiudadFields.Codigo = Codigo And HC.CiudadFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya exste una ciudad con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return CiudadEntity.Save
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            'If CiudadEntity.FetchUsingPK(CodigoEstado.Codigo, Codigo) Then
            If CiudadEntity.FetchUsingPK(CodigoEstado.Codigo, Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            Else
                RaiseEvent MensajeError(Me, "La ciudad especificada no existe.")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal CodEstado As Integer, ByVal Codigo As Integer) As Boolean
        Try
            'If CiudadEntity.FetchUsingPK(CodigoEstado.Codigo, Codigo) Then
            If CiudadEntity.FetchUsingPK(CodEstado, Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            Else
                RaiseEvent MensajeError(Me, "La ciudad especificada no existe.")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.CiudadEntity)
        CiudadEntity = Entidad
    End Sub

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Function ObtenerEntidad() As EC.CiudadEntity
        Return Me.CiudadEntity
    End Function

    Public Function Obtenerpoblacion() As PoblacionCollectionClass
        Dim X As New PoblacionCollectionClass()
        X.Obtener(CondicionEnum.ACTIVOS)
        Return X
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean 
    End Function


    'Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    'Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
End Class

<Serializable()> _
Public Class CiudadCollectionClass
    Inherits CollectionClass(Of CiudadClass)

    Private coleccion As New CC.CiudadCollection
    Private CiudadCollection As New CC.CiudadCollection
    Private Filtro As OC.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()

            If Not fcCondicion = CondicionEnum.Todos Then
                CiudadCollection.GetMulti(HC.CiudadFields.Estatus = fcCondicion)
            Else
                CiudadCollection.GetMulti(Nothing)
            End If

            For Each ciudadEntity As EC.CiudadEntity In CiudadCollection
                Dim ciudad As New CiudadClass
                ciudad.LeerEntidad(ciudadEntity)
                Me.Add(ciudad)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Ciudad As CiudadClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.CiudadFields.Codigo = Ciudad.Codigo)
            Filtro.AddWithOr(HC.CiudadFields.Descripcion = Ciudad.Descripcion)
            Filtro.AddWithOr(HC.CiudadFields.DescripcionCorta = Ciudad.DescripcionCorta)

            CiudadCollection.GetMulti(Filtro)

            For Each CiudadEntity As EC.CiudadEntity In CiudadCollection
                Dim MiCiudad As New CiudadClass
                MiCiudad.LeerEntidad(CiudadEntity)
                Me.Add(MiCiudad)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal estado As EstadoClass, Optional ByVal fcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Filtro = New OC.PredicateExpression

            If Not fcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.CiudadFields.Estatus = fcCondicion)
            End If

            Filtro.Add(HC.CiudadFields.CodigoEstado = estado.Codigo)

            Dim Conteo As Integer = CiudadCollection.Count

            CiudadCollection.GetMulti(Filtro)

            Me.Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal idEstado As Integer, ByVal fccondicion As CondicionEnum) As Integer
        Try
             filtro = New OC.PredicateExpression

            Filtro.Add(HC.CiudadFields.CodigoEstado = idEstado)

            If Not fccondicion = CondicionEnum.TODOS Then filtro.Add(HC.CiudadFields.Estatus = fccondicion)

            Me.coleccion.GetMulti(filtro)

            Clear()

            For Each ent As EC.CiudadEntity In coleccion
                Add(New CiudadClass(ent))
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As CC.CiudadCollection
        RellenarColeccion()
        Return coleccion
    End Function

    Private Sub RellenarColeccion()
        coleccion = New CC.CiudadCollection
        For Each Ciudad As CiudadClass In Me
            Dim miciudad As New EC.CiudadEntity
            miciudad = Ciudad.ObtenerEntidad
            coleccion.Add(miciudad)
        Next
    End Sub

    Private Sub Rellenar()
        For Each ciudad As EC.CiudadEntity In CiudadCollection
            Dim miciudad As New CiudadClass
            miciudad.LeerEntidad(ciudad)
            Me.Add(miciudad)
        Next
    End Sub

    Public Function Guardar() As Integer
        CiudadCollection = New CC.CiudadCollection
        For Each Ciudad As CiudadClass In Me
            Dim CiudadEntity As New EC.CiudadEntity
            CiudadEntity = Ciudad.ObtenerEntidad()
            CiudadCollection.Add(CiudadEntity)
        Next
        Try
            Dim Conteo As Integer = CiudadCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        CiudadCollection = New CC.CiudadCollection
        For Each Ciudad As CiudadClass In Me
            Dim CiudadEntity As New EC.CiudadEntity
            CiudadEntity = Ciudad.ObtenerEntidad()
            CiudadCollection.Add(CiudadEntity)
        Next
        Try
            Dim Conteo As Integer = CiudadCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CRepCiudad
        Dim Reportes As New CRepCiudad
        'Reporte = New CRepCiudad
        Dim ds As New DataSet
        Dim dtCdad As New DSetCiudad.CiudadesDataTable
        For Each Cdad As CiudadClass In Me
            dtCdad.AddCiudadesRow(Cdad.Codigo, Cdad.Descripcion, Cdad.DescripcionCorta, Cdad.Observaciones, Cdad.CodigoEstado.Descripcion, Cdad.Estatus.ToString)
        Next
        ds.Tables.Add(dtCdad)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Catalogo/Generales/Ciudades")
        'Reporte.SetParameterValue("empresa", empresa)
        Return Reportes
    End Function

End Class