Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class UnidadesMedidaClass
    Implements IEntidad


    Private UnidadMedida As EC.UnidadMedidaEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

#Region "Propiedades"

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return UnidadMedida.Descripcion
        End Get
        Set(ByVal value As String)
            UnidadMedida.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código")> _
    Public Property Codigo() As Integer
        Get
            Return UnidadMedida.Codigo
        End Get
        Set(ByVal value As Integer)
            'UnidadMedida.codigo = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescCorta() As String
        Get
            Return UnidadMedida.DescripcionCorta
        End Get
        Set(ByVal value As String)
            UnidadMedida.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observación")> _
    Public Property Observaciones() As String
        Get
            Return UnidadMedida.Observaciones
        End Get
        Set(ByVal value As String)
            UnidadMedida.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha")> _
    Public Property FechaAlta() As Date
        Get
            Return UnidadMedida.FechaAlta
        End Get
        Set(ByVal value As Date)
            UnidadMedida.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Usuario Alta")> _
    Public Property CodigoUsuarioAlta() As Integer
        Get
            Return CInt(UnidadMedida.UsuarioAlta)
        End Get
        Set(ByVal value As Integer)
            UnidadMedida.UsuarioAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha Baja")> _
    Public Property FechaBaja() As Date
        Get
            Return UnidadMedida.FechaBaja
        End Get
        Set(ByVal value As Date)
            UnidadMedida.FechaBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Usuario Baja")> _
    Public Property CodigoUsuarioBaja() As Integer
        Get
            Return CInt(UnidadMedida.UsuarioBaja)
        End Get
        Set(ByVal value As Integer)
            UnidadMedida.UsuarioBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Motivo Baja")> _
    Public Property CodigoMotivoBaja() As Integer
        Get
            Return UnidadMedida.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            UnidadMedida.UsuarioBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observacion Baja")> _
    Public Property ObservacionesBaja() As String
        Get
            Return UnidadMedida.ObservacionesBaja
        End Get
        Set(ByVal value As String)
            UnidadMedida.ObservacionesBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return UnidadMedida.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            UnidadMedida.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus Descripcion")> _
    Public ReadOnly Property EstatusDescripcion() As String
        Get
            Return Me.Estatus.ToString
        End Get
    End Property

#End Region

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.PresentacionCollection

            If col.GetDbCount(HC.PresentacionFields.CodigoUnidadMedida = Codigo And HC.PresentacionFields.Estatus = 1) > 0 Then
                MsgBox("No es posible dar de baja la Unidad de Medida, tiene presentaciones activas", MsgBoxStyle.Exclamation, "Presentaciones Activas")
                Return False
            End If

            Dim colp As New CC.ProductoCollection

            If colp.GetDbCount(HC.ProductoFields.CodigoUnidadMedida = Codigo And HC.ProductoFields.Estatus = 1) > 0 Then
                MsgBox("No es posible dar de baja la unidad de medida, tiene productos activos", MsgBoxStyle.Exclamation, "Productos Activos")
                Return False
            End If

            UnidadMedida.Estatus = EstatusEnum.INACTIVO

            Return UnidadMedida.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If UnidadMedida.FetchUsingPK(Codigo) Then
                Return True
            End If
            RaiseEvent MensajeError(Me, "La Linea no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Sub LeerEntidad(ByVal Entidad As EC.UnidadMedidaEntity)
        Me.UnidadMedida = Entidad
    End Sub

    Public Function ObtenerEntidad() As EC.UnidadMedidaEntity
        Return UnidadMedida
    End Function

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.UnidadMedidaCollection

            If UnidadMedida.IsNew Then
                If col.GetDbCount(HC.UnidadMedidaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una unidad de medida con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.UnidadMedidaFields.DescripcionCorta = Me.DescCorta) > 0 Then
                    MsgBox("Ya existe una unidad de medida con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return UnidadMedida.Save
            Else
                If col.GetDbCount(Not HC.UnidadMedidaFields.Codigo = Codigo And HC.UnidadMedidaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una unidad de medida con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.UnidadMedidaFields.Codigo = Codigo And HC.UnidadMedidaFields.DescripcionCorta = Me.DescCorta) > 0 Then
                    MsgBox("Ya existe una unidad de medida con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return UnidadMedida.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        UnidadMedida = New EC.UnidadMedidaEntity
        'UnidadMedida.codigo = 0
        UnidadMedida.Descripcion = ""
        UnidadMedida.DescripcionCorta = ""
        UnidadMedida.Observaciones = ""
        UnidadMedida.FechaAlta = New Date(1900, 1, 1)
        UnidadMedida.UsuarioAlta = 0
        UnidadMedida.FechaBaja = New Date(1900, 1, 1)
        UnidadMedida.UsuarioBaja = 0
        UnidadMedida.MotivoBaja = 0
        UnidadMedida.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Codigo As Integer)
        UnidadMedida = New EC.UnidadMedidaEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.UnidadMedidaEntity)
        UnidadMedida = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Descripcion
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

    Public Shared Function CargarUnidadMedida(ByVal IdUnidadMedida As Integer) As UnidadesMedidaClass
        Return New UnidadesMedidaClass(IdUnidadMedida)
    End Function
End Class

Public Class UnidadesMedidaCollectionClass
    Inherits CollectionClass(Of UnidadesMedidaClass)

    Private Coleccion As New CC.UnidadMedidaCollection
    Private filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(Nothing)
            Else
                Coleccion.GetMulti(HC.UnidadMedidaFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal activo As Boolean) As Integer
        Try
            Coleccion.GetMulti(HC.UnidadMedidaFields.Estatus = activo)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal UM As UnidadesMedidaClass) As Integer
        Try
            Me.ClearItems()
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            filtro.Add(HC.UnidadMedidaFields.Codigo = UM.Codigo)
            filtro.Add(HC.UnidadMedidaFields.DescripcionCorta = UM.DescCorta)
            filtro.AddWithOr(HC.UnidadMedidaFields.Descripcion = UM.Descripcion)

            Coleccion.GetMulti(filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Guardar() As Integer
        Coleccion = New CC.UnidadMedidaCollection
        For Each UM As UnidadesMedidaClass In Me
            Dim UnidadesMedidaEntity As New EC.UnidadMedidaEntity
            UnidadesMedidaEntity = UM.ObtenerEntidad()
            Coleccion.Add(UnidadesMedidaEntity)
        Next
        Try
            Dim Conteo As Integer = Coleccion.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        Coleccion = New CC.UnidadMedidaCollection
        For Each UM As UnidadesMedidaClass In Me
            Dim UnidadesMedidaEntity As New EC.UnidadMedidaEntity
            UnidadesMedidaEntity = UM.ObtenerEntidad()
        Next
        Try
            Dim Conteo As Integer = Coleccion.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptABCUnidadesMedida
        Dim rpt As New rptABCUnidadesMedida
        Dim ds As New DataSet
        Dim dtUMedida As New DSUnidadesMedida.dtUnidadesMedidaDataTable
        For Each UM As UnidadesMedidaClass In Me
            dtUMedida.AdddtUnidadesMedidaRow(UM.Codigo, UM.Descripcion, UM.DescCorta, UM.Observaciones, UM.Estatus.ToString())
        Next
        ds.Tables.Add(dtUMedida)
        rpt.SetDataSource(ds)
        Return rpt
    End Function

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.UnidadMedidaEntity In Coleccion
            Add(New UnidadesMedidaClass(ente))
        Next
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each uni As UnidadesMedidaClass In Me
            Coleccion.Add(uni.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.UnidadMedidaCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Public Function ObtenerColeccion() As CC.UnidadMedidaCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Public Shared Function CargarUnidadesMedida(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Coleccion As New CC.UnidadMedidaCollection()

        Try
            Coleccion.GetMulti(Filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return Coleccion.GetList()
    End Function

End Class



