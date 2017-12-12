Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses

Public Class EstadoClass
    Implements IEntidad

    Private WithEvents EstadoEntity As EC.EstadoEntity
    Private CiudadEntity As EC.CiudadEntity
    Private EstadoCollection As New CC.EstadoCollection
    Private m_Error As Boolean
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    <System.ComponentModel.DisplayName("Codigo Estado")> _
   Public ReadOnly Property Codigo() As Integer
        Get
            Return EstadoEntity.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return EstadoEntity.Descripcion
        End Get
        Set(ByVal value As String)
            EstadoEntity.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return EstadoEntity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            EstadoEntity.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return EstadoEntity.Observaciones
        End Get
        Set(ByVal value As String)
            EstadoEntity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return EstadoEntity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            EstadoEntity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ReadOnly Property [Error]() As Boolean
        Get
            Return m_Error
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        EstadoEntity = New EC.EstadoEntity
        EstadoEntity.Descripcion = ""
        EstadoEntity.DescripcionCorta = ""
        EstadoEntity.Observaciones = ""
        EstadoEntity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As EC.EstadoEntity)
        EstadoEntity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        EstadoEntity = New EC.EstadoEntity(Codigo)
    End Sub
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.CiudadCollection

            If col.GetDbCount(HC.CiudadFields.CodigoEstado = Codigo And HC.CiudadFields.Estatus = 1) > 0 Then
                MsgBox("No se logro dar de baja el estado, tiene ciduades activas", MsgBoxStyle.Exclamation, "Ciudades Activas")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO

            Return EstadoEntity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            If EstadoEntity.IsNew Then
                Dim col As New CC.EstadoCollection

                If col.GetDbCount(HC.EstadoFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe une estado con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.EstadoFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un estado con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If EstadoEntity.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar el estado, intente nuevamente", MsgBoxStyle.Exclamation, "No Guardo")
                    Return False
                End If
            Else
                Dim col As New CC.EstadoCollection

                If col.GetDbCount(Not HC.EstadoFields.Codigo = Codigo And HC.EstadoFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe une stado con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.EstadoFields.Codigo = Codigo And HC.EstadoFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un estado con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If EstadoEntity.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar el estado, intente nuevamente", MsgBoxStyle.Exclamation, "No Guardo")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al querer guardar, intente nuevamente", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If EstadoEntity.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "El estado especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.EstadoEntity)
        EstadoEntity = Entidad
    End Sub

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Function ObtenerEntidad() As EC.EstadoEntity
        Return Me.EstadoEntity
    End Function

    Public Function ObtenerCiudad() As CiudadCollectionClass
        Dim X As New CiudadCollectionClass()
        X.Obtener(Me)
        Return X
    End Function
    Public Function ObtenerCiudad(ByVal IdEstado As Integer) As CiudadCollectionClass
        Dim X As New CiudadCollectionClass()
        X.Obtener(EstadoEntity.Codigo)
        Return X
    End Function

    Public Function verificar() As Boolean
        If Me.Descripcion.Replace("", "").Length <= 0 Or Me.DescripcionCorta.Replace("", "").Length <= 0 Then
            RaiseEvent MensajeError(Me, "La Descripción y Descripción Corta Son Obligatorios Agregue Información")
            Return False
        End If
        Return True
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

End Class

Public Class EstadoCollectionClass
    Inherits CollectionClass(Of EstadoClass)

    Public Event MensajeError As MensajeErrorHandler
    Private WithEvents Coleccion As New CC.EstadoCollection
    Private EstadoCollection As New CC.EstadoCollection
    Private Filtro As OC.PredicateExpression

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()
            If Not fcCondicion = CondicionEnum.Todos Then
                EstadoCollection.GetMulti(HC.EstadoFields.Estatus = fcCondicion)
            Else
                EstadoCollection.GetMulti(Nothing)
            End If
            Dim Conteo As Integer = Me.EstadoCollection.Count
            For Each EstadoEntity As EC.EstadoEntity In EstadoCollection
                Dim Estado As New EstadoClass
                Estado.LeerEntidad(EstadoEntity)
                Me.Add(Estado)
            Next
            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Estado As EstadoClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.EstadoFields.Codigo = Estado.Codigo)
            Filtro.AddWithOr(HC.EstadoFields.Descripcion = Estado.Descripcion)
            Filtro.AddWithOr(HC.EstadoFields.DescripcionCorta = Estado.DescripcionCorta)
            Dim Conteo As Integer = EstadoCollection.GetDbCount(Filtro)
            If Conteo > 0 Then
                EstadoCollection.GetMulti(Filtro)
                For Each estadoEntity As EC.EstadoEntity In EstadoCollection
                    Dim MiEstado As New EstadoClass
                    MiEstado.LeerEntidad(estadoEntity)
                    Me.Add(MiEstado)
                Next
            End If
            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Integer
        EstadoCollection = New CC.EstadoCollection
        For Each estado As EstadoClass In Me
            Dim EstadoEntity As New EC.EstadoEntity
            EstadoEntity = estado.ObtenerEntidad()
            EstadoCollection.Add(EstadoEntity)
        Next
        Try
            Dim Conteo As Integer = EstadoCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        EstadoCollection = New CC.EstadoCollection
        For Each estado As EstadoClass In Me
            Dim EstadoEntity As New EC.EstadoEntity
            EstadoEntity = estado.ObtenerEntidad()
            EstadoCollection.Add(EstadoEntity)
        Next
        Try
            Dim Conteo As Integer = EstadoCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtenercoleccion() As CC.EstadoCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Private Sub RellenarColeccion()
        Coleccion = New CC.EstadoCollection
        For Each Estado As EstadoClass In Me
            Dim EstadoE As New EC.EstadoEntity
            EstadoE = Estado.ObtenerEntidad
            Coleccion.Add(EstadoE)
        Next
    End Sub

    Public Sub RellenarMe(ByVal col As CC.EstadoCollection)
        Me.ClearItems()
        For Each EstadoE As EC.EstadoEntity In col
            Dim Estado As New EstadoClass
            Estado.LeerEntidad(EstadoE)
            Me.Add(Estado)
        Next
    End Sub

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CRepEstado
        Dim Reportes As New CRepEstado
        Dim ds As New DataSet
        Dim dtedo As New DSetEstado.EstadosDataTable
        For Each Edo As EstadoClass In Me
            dtedo.AddEstadosRow(Edo.Codigo, Edo.Descripcion, Edo.DescripcionCorta, Edo.Observaciones, Edo.Estatus.ToString())
        Next
        ds.Tables.Add(dtedo)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Catalogos/Generales/Estados")
        'Reportes.SetParameterValue("empresa", empresa)
        Return Reportes
    End Function

End Class