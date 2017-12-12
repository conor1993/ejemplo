Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class TipoPresupuestoClass
    Implements IEntidad


    Private PresupuestoEntity As EC.TipoPresupuestoEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        PresupuestoEntity = New EC.TipoPresupuestoEntity
        PresupuestoEntity.Descripcion = ""
        PresupuestoEntity.DescripcionCorta = ""
        PresupuestoEntity.Observaciones = ""
        PresupuestoEntity.Estatus = EstatusEnum.ACTIVO
        PresupuestoEntity.FechaAlta = New Date(1900, 1, 1)
        PresupuestoEntity.FechaBaja = New Date(1900, 1, 1)
        PresupuestoEntity.MotivoBaja = 0
        PresupuestoEntity.UsuarioBaja = 0
        PresupuestoEntity.ObservacionesBaja = ""

    End Sub

    Sub New(ByVal Codigo As Integer)
        PresupuestoEntity = New EC.TipoPresupuestoEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.TipoPresupuestoEntity)
        PresupuestoEntity = Entidad
    End Sub

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function ObtenerEntidad() As EC.TipoPresupuestoEntity
        Return Me.PresupuestoEntity
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If PresupuestoEntity.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return PresupuestoEntity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            PresupuestoEntity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return PresupuestoEntity.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return PresupuestoEntity.Descripcion
        End Get
        Set(ByVal value As String)
            PresupuestoEntity.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCta() As String
        Get
            Return PresupuestoEntity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            PresupuestoEntity.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaAlta() As Date
        Get
            Return PresupuestoEntity.FechaAlta
        End Get
        Set(ByVal value As Date)
            PresupuestoEntity.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return PresupuestoEntity.Observaciones
        End Get
        Set(ByVal value As String)
            PresupuestoEntity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Estatus = EstatusEnum.INACTIVO

            Return Me.PresupuestoEntity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.TipoPresupuestoCollection

            If Me.PresupuestoEntity.IsNew Then
                If col.GetDbCount(HC.TipoPresupuestoFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de presupuesto cone sa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.TipoPresupuestoFields.DescripcionCorta = DescripcionCta) > 0 Then
                    MsgBox("Ya existe un tipo de presupuesto con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return PresupuestoEntity.Save
            Else
                If col.GetDbCount(Not HC.TipoPresupuestoFields.Codigo = Codigo And HC.TipoPresupuestoFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de presupuesto cone sa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.TipoPresupuestoFields.Codigo = Codigo And HC.TipoPresupuestoFields.DescripcionCorta = DescripcionCta) > 0 Then
                    MsgBox("Ya existe un tipo de presupuesto con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return PresupuestoEntity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.TipoPresupuestoEntity)
        PresupuestoEntity = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class TipoPresupuestoCollectionClass
    Inherits CollectionClass(Of TipoPresupuestoClass)

    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Private Coleccion As New CC.TipoPresupuestoCollection
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Col As CC.TipoPresupuestoCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Public Function Borrar() As Object
        Coleccion = New CC.TipoPresupuestoCollection
        For Each Presupuesto As TipoPresupuestoClass In Me
            Dim PresupuestoEntity As New EC.TipoPresupuestoEntity
            PresupuestoEntity = Presupuesto.ObtenerEntidad()
            Coleccion.Add(PresupuestoEntity)
        Next
        Try
            Dim Conteo As Integer = Coleccion.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        Coleccion = New CC.TipoPresupuestoCollection
        For Each Presupuesto As TipoPresupuestoClass In Me
            Dim PresupuestoEntity As New EC.TipoPresupuestoEntity
            PresupuestoEntity = Presupuesto.ObtenerEntidad()
            Coleccion.Add(PresupuestoEntity)
        Next
        Try
            Dim Conteo As Integer = Coleccion.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(Nothing)
            Else
                Coleccion.GetMulti(HC.TipoPresupuestoFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Presupuesto As TipoPresupuestoClass) As Integer
        Try
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.AddWithOr(HC.TipoPresupuestoFields.Descripcion = Presupuesto.Descripcion)
            Filtro.AddWithOr(HC.TipoPresupuestoFields.DescripcionCorta = Presupuesto.DescripcionCta)

            Coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As CC.TipoPresupuestoCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each Presupuesto As TipoPresupuestoClass In Me
            Coleccion.Add(Presupuesto.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.TipoPresupuestoCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.TipoPresupuestoEntity In Coleccion
            Add(New TipoPresupuestoClass(ente))
        Next
    End Sub

    Public Function Reporte() As CRepTPresupuesto
        Dim Reportes As New CRepTPresupuesto
        Dim ds As New DataSet
        Dim dtPre As New DSetTPresupuestos.TipoPresupuestosDataTable
        For Each Pre As TipoPresupuestoClass In Me
            dtPre.AddTipoPresupuestosRow(Pre.Codigo.ToString(), Pre.FechaAlta, Pre.Descripcion, Pre.DescripcionCta, Pre.Observaciones, Pre.Estatus.ToString())
        Next
        ds.Tables.Add(dtPre)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class