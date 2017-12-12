Imports Ec = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class presentacionClass
    Implements IEntidad

    Private Presentacion As Ec.PresentacionEntity
    Private PresentacionCollection As New CC.PresentacionCollection
    Private _UnidadMedida As UnidadesMedidaClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.ProductoCollection

            If col.GetDbCount(HC.ProductoFields.CodigoPresentacion = Codigo And HC.ProductoFields.Estatus = 1) > 0 Then
                MsgBox("No es posible darla de baja, existen productos activos relacionados a esta presentación", MsgBoxStyle.Exclamation, "Productos Activos")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO

            Return Presentacion.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.PresentacionCollection

            If Presentacion.IsNew Then
                If col.GetDbCount(HC.PresentacionFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una presentación con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.PresentacionFields.DescripcionCorta = DescripcionCta) > 0 Then
                    MsgBox("Ya existe una presentación con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Presentacion.Save
            Else
                If col.GetDbCount(Not HC.PresentacionFields.Codigo = Codigo And HC.PresentacionFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una presentación con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.PresentacionFields.Codigo = Codigo And HC.PresentacionFields.DescripcionCorta = DescripcionCta) > 0 Then
                    MsgBox("Ya existe una presentación con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Presentacion.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If Presentacion.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "La Presentación Especificada No Existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Sub LeerEntidad(ByVal Entidad As Ec.PresentacionEntity)
        Presentacion = Entidad
    End Sub

    Public Function ObtenerEntidad() As Ec.PresentacionEntity
        Return Me.Presentacion
    End Function

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Presentacion.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Presentacion.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Presentacion.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Presentacion.Descripcion
        End Get
        Set(ByVal value As String)
            Presentacion.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCta() As String
        Get
            Return Presentacion.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Presentacion.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Piezas")> _
    Public Property Piezas() As Integer
        Get
            Return Presentacion.Cantidad
        End Get
        Set(ByVal value As Integer)
            Presentacion.Cantidad = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Unidad de Medida")> _
    Public Property UnidadMedida() As UnidadesMedidaClass
        Get
            If _UnidadMedida Is Nothing Then
                _UnidadMedida = New UnidadesMedidaClass(Presentacion.UnidadMedida)
            End If

            Return _UnidadMedida
        End Get
        Set(ByVal value As UnidadesMedidaClass)
            _UnidadMedida = value
            Presentacion.UnidadMedida = value.ObtenerEntidad
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observación")> _
    Public Property Observaciones() As String
        Get
            Return Presentacion.Observacion
        End Get
        Set(ByVal value As String)
            Presentacion.Observacion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        Presentacion = New Ec.PresentacionEntity
        Presentacion.Descripcion = ""
        Presentacion.DescripcionCorta = ""
        Presentacion.Observacion = ""
        Presentacion.Estatus = EstatusEnum.ACTIVO
        Presentacion.UsuarioAlta = 0
        Presentacion.Cantidad = 0
    End Sub

    Sub New(ByVal Codigo As Integer)
        Presentacion = New Ec.PresentacionEntity(Codigo)
    End Sub

    Sub New(ByVal entidad As Ec.PresentacionEntity)
        Presentacion = entidad
    End Sub

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class PresentacionCollectionClass
    Inherits CollectionClass(Of presentacionClass)

    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Private Coleccion As New CC.PresentacionCollection
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Borrar() As Object
        Coleccion = New CC.PresentacionCollection
        For Each Presentacion As presentacionClass In Me
            Dim PresentacionEntity As New Ec.PresentacionEntity
            PresentacionEntity = Presentacion.ObtenerEntidad()
            Coleccion.Add(PresentacionEntity)
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
        Coleccion = New CC.PresentacionCollection
        For Each Presentacion As presentacionClass In Me
            Dim PresentacionEntity As New Ec.PresentacionEntity
            PresentacionEntity = Presentacion.ObtenerEntidad()
            Coleccion.Add(PresentacionEntity)
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
                Coleccion.GetMulti(HC.PresentacionFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Presentacion As presentacionClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New OC.PredicateExpression

            Filtro.Add(HC.PresentacionFields.Codigo = Presentacion.Codigo)
            Filtro.AddWithOr(HC.PresentacionFields.Descripcion = Presentacion.Descripcion)
            Filtro.AddWithOr(HC.PresentacionFields.DescripcionCorta = Presentacion.DescripcionCta)

            Coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As CC.PresentacionCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each Presentacion As presentacionClass In Me
            Coleccion.Add(Presentacion.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.PresentacionCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Clear()
        For Each ente As Ec.PresentacionEntity In Coleccion
            Add(New presentacionClass(ente))
        Next
    End Sub

    Public Function Reporte() As CRepPresentacion
        Dim Reportes As New CRepPresentacion
        Dim ds As New DataSet
        Dim dtPres As New DSetPresentacion.PresentacionDataTable

        For Each Pres As presentacionClass In Me
            dtPres.AddPresentacionRow(Pres.Codigo, Pres.Descripcion, Pres.DescripcionCta, Pres.Piezas, Pres.UnidadMedida.Descripcion, Pres.Observaciones, Pres.Estatus.ToString)
        Next

        ds.Tables.Add(dtPres)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class