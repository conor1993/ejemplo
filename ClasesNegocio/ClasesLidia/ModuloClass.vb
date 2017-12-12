Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ModuloClass
    Implements IEntidad


    Private Modulo As New Integralab.ORM.EntityClasses.ModuloEntity
    Private Modulos As New Integralab.ORM.CollectionClasses.ModuloCollection
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        Modulo = New Integralab.ORM.EntityClasses.ModuloEntity
        Modulo.Descripcion = ""
        Modulo.DescripcionCorta = ""
        Modulo.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As EC.ModuloEntity)
        Modulo = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Modulo = New EC.ModuloEntity(Codigo)
    End Sub

    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Modulo.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Modulo.Descripcion
        End Get
        Set(ByVal value As String)
            Modulo.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Modulo.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Modulo.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Es Baja")> _
    Public Property EsBaja() As BajaCancelacionEnum
        Get
            Return Modulo.EsBaja
        End Get
        Set(ByVal value As BajaCancelacionEnum)
            Modulo.EsBaja = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Modulo.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Modulo.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.TipoMotivoCollection

            If col.GetDbCount(HC.TipoMotivoFields.Modulo = Codigo And HC.TipoMotivoFields.Estatus = 1) > 0 Then
                MsgBox("Hay Tipos de Motivos activos, no se peude dar de baja", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Modulo.Estatus = EstatusEnum.INACTIVO

            If Modulo.Save() Then Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.ModuloCollection

            If Modulo.IsNew Then
                Estatus = EstatusEnum.ACTIVO

                If col.GetDbCount(HC.ModuloFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un modulo con la misma descripción", MsgBoxStyle.Exclamation, "Datos Repetidos")
                    Return False
                End If

                If col.GetDbCount(HC.ModuloFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un modulo con la misma descripción corta", MsgBoxStyle.Exclamation, "Datos Repetidos")
                    Return False
                End If

                If Modulo.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If col.GetDbCount(Not HC.ModuloFields.Codigo = Codigo And HC.ModuloFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un modulo con la misma descripción", MsgBoxStyle.Exclamation, "Datos Repetidos")
                    Return False
                End If

                If col.GetDbCount(Not HC.ModuloFields.Codigo = Codigo And HC.ModuloFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un modulo con la misma descripción corta", MsgBoxStyle.Exclamation, "Datos Repetidos")
                    Return False
                End If

                If Modulo.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If Modulo.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Modulo especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function ObtenerEntidad() As Integralab.ORM.EntityClasses.ModuloEntity
        Return Me.Modulo
    End Function

    Public Sub LeerEntidad(ByVal Entidad As Integralab.ORM.EntityClasses.ModuloEntity)
        Modulo = Entidad
    End Sub

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function ObtenerModulo() As ModuloCollectionClass
        Dim X As New ModuloCollectionClass()
        X.Obtener(Me)
        Return X
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ModuloCollectionClass
    Inherits CollectionClass(Of ModuloClass)

    Private ModuloCollection As New IntegraLab.ORM.CollectionClasses.ModuloCollection
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Private Motivo As BajaCancelacionEnum = BajaCancelacionEnum.TODOS
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Obtiene o establece el tipo de motivo para filtrar la consulta de modulos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TipoMotivo() As BajaCancelacionEnum
        Get
            Return Motivo
        End Get
        Set(ByVal value As BajaCancelacionEnum)
            Motivo = value
        End Set
    End Property

    Public Function Guardar() As Object
        ModuloCollection = New IntegraLab.ORM.CollectionClasses.ModuloCollection
        For Each Modulo As ModuloClass In Me
            Dim ModuloE As New IntegraLab.ORM.EntityClasses.ModuloEntity
            ModuloE = Modulo.ObtenerEntidad()
            ModuloCollection.Add(ModuloE)
        Next
        Try
            Dim Conteo As Integer = ModuloCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Object
        ModuloCollection = New IntegraLab.ORM.CollectionClasses.ModuloCollection
        For Each Modulo As ModuloClass In Me
            Dim ModuloE As New IntegraLab.ORM.EntityClasses.ModuloEntity
            ModuloE = Modulo.ObtenerEntidad()
            ModuloCollection.Add(ModuloE)
        Next
        Try
            Dim Conteo As Integer = ModuloCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene una coleccion de los modulos con las caracteristicas establecidas
    ''' </summary>
    ''' <param name="FcCondicion">Estatus del modulo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.ModuloFields.Estatus = FcCondicion)
            End If

            Filtro.Add(HC.ModuloFields.EsBaja = Motivo)

            Me.ModuloCollection.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Modulo As ModuloClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            'Filtro.Add(IntegraLab.ORM.HelperClasses.ModuloFields.Codigo = Modulo.codigo)
            Filtro.AddWithOr(IntegraLab.ORM.HelperClasses.ModuloFields.Descripcion = Modulo.Descripcion)
            Filtro.AddWithOr(IntegraLab.ORM.HelperClasses.ModuloFields.DescripcionCorta = Modulo.DescripcionCorta)
            Dim Conteo As Integer = ModuloCollection.GetDbCount(Filtro)
            If Conteo > 0 Then
                ModuloCollection.GetMulti(Filtro)
                For Each ModuloE As IntegraLab.ORM.EntityClasses.ModuloEntity In ModuloCollection
                    Dim MiModulo As New ModuloClass
                    MiModulo.LeerEntidad(ModuloE)
                    Me.Add(Modulo)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As IntegraLab.ORM.CollectionClasses.ModuloCollection
        RellenarColeccion()
        Return ModuloCollection
    End Function

    Private Sub RellenarColeccion()
        ModuloCollection.Clear()
        For Each Modulo As ModuloClass In Me
            ModuloCollection.Add(Modulo.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Coleccion As CC.ModuloCollection)
        ModuloCollection = Coleccion
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.ModuloEntity In ModuloCollection
            Add(New ModuloClass(ente))
        Next
    End Sub

    Public Function Reporte() As CRepModulo
        Dim Reportes As New CRepModulo
        Dim ds As New DataSet
        Dim dtModulo As New DsModulo.DtModuloDataTable
        For Each Modulo As ModuloClass In Me
            dtModulo.AddDtModuloRow(Modulo.Codigo, Modulo.Descripcion, Modulo.DescripcionCorta, Modulo.Estatus.ToString)
        Next
        ds.Tables.Add(dtModulo)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class