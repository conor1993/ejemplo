Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class MarcaClass
    Implements IEntidad


    Private WithEvents Marca As EC.MarcaEntity
    Private MarcaCollection As New CC.MarcaCollection

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        Marca = New EC.MarcaEntity
        Marca.Descripcion = ""
        Marca.DescripcionCorta = ""
        Marca.Observaciones = ""
        Marca.Estatus = EstatusEnum.ACTIVO
        Marca.FechaAlta = New Date(1900, 1, 1)
        Marca.FechaBaja = New Date(1900, 1, 1)
        Marca.MotivoBaja = 0
        Marca.UsuarioAlta = 0
        Marca.UsuarioBaja = 0
        Marca.ObservacionBaja = ""
    End Sub

    Sub New(ByVal Codigo As Integer)
        Marca = New EC.MarcaEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.MarcaEntity)
        Marca = Entidad
    End Sub

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            If Marca.Estatus = False Then
                Return EstatusEnum.INACTIVO
            Else
                Return EstatusEnum.ACTIVO
            End If
        End Get
        Set(ByVal value As EstatusEnum)
            Marca.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Marca.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Nombre() As String
        Get
            Return Marca.Descripcion
        End Get
        Set(ByVal value As String)
            Marca.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property NombreCorto() As String
        Get
            Return Marca.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Marca.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observación")> _
    Public Property Observacion() As String
        Get
            Return Marca.Observaciones
        End Get
        Set(ByVal value As String)
            Marca.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.ProductoCollection

            If col.GetDbCount(HC.ProductoFields.CodigoMarca = Codigo And HC.ProductoFields.Estatus = 1) > 0 Then
                MsgBox("Existen productos activos con esta marca, no es posible dar de baja esta marca", MsgBoxStyle.Exclamation, "Productos Activos")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO

            Return Marca.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.MarcaCollection

            If Marca.IsNew Then
                If col.GetDbCount(HC.MarcaFields.Descripcion = Nombre) > 0 Then
                    MsgBox("Ya existe una marca con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.MarcaFields.DescripcionCorta = NombreCorto) > 0 Then
                    MsgBox("Ya existe una marca con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Marca.Save
            Else
                If col.GetDbCount(Not HC.MarcaFields.Codigo = Codigo And HC.MarcaFields.Descripcion = Nombre) > 0 Then
                    MsgBox("Ya existe una marca con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.MarcaFields.Codigo = Codigo And HC.MarcaFields.DescripcionCorta = NombreCorto) > 0 Then
                    MsgBox("Ya existe una marca con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Marca.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If Marca.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "La Marca especificada no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.MarcaEntity)
        Marca = Entidad
    End Sub

    Public Function ObtenerEntidad() As EC.MarcaEntity
        Return Me.Marca
    End Function

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class MarcaCollectionClass
    Inherits CollectionClass(Of MarcaClass)

    Private WithEvents Coleccion As New CC.MarcaCollection
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    'Public Function Borrar() As Object
    '    MarcaCollection = New CC.MarcaCollection
    '    For Each Marca As MarcaClass In Me
    '        Dim MarcaEntity As New EC.MarcaEntity
    '        MarcaEntity = Marca.ObtenerEntidad()
    '        MarcaCollection.Add(MarcaEntity)
    '    Next
    '    Try
    '        Dim Conteo As Integer = MarcaCollection.DeleteMulti()
    '        Return Conteo
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, ex.Message)
    '        Return -1
    '    End Try
    'End Function

    'Public Function Guardar() As Object
    '    MarcaCollection = New CC.MarcaCollection
    '    For Each Marca As MarcaClass In Me
    '        Dim MarcaEntity As New EC.MarcaEntity
    '        MarcaEntity = Marca.ObtenerEntidad()
    '        MarcaCollection.Add(MarcaEntity)
    '    Next
    '    Try
    '        Dim Conteo As Integer = MarcaCollection.SaveMulti()
    '        Return Conteo
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, ex.Message)
    '        Return -1
    '    End Try
    'End Function

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(Nothing)
            Else
                Coleccion.GetMulti(HC.MarcaFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Marca As MarcaClass) As Integer
        Try
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.MarcaFields.Codigo = Marca.Codigo)
            Filtro.AddWithOr(HC.MarcaFields.Descripcion = Marca.Nombre)
            Filtro.AddWithOr(HC.MarcaFields.DescripcionCorta = Marca.NombreCorto)

            Coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As CC.MarcaCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each Marca As MarcaClass In Me
            Coleccion.Add(Marca.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.MarcaCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.MarcaEntity In Coleccion
            Add(New MarcaClass(ente))
        Next
    End Sub

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CRepMarca
        Dim Reportes As New CRepMarca
        '
        Dim ds As New DataSet
        Dim dtMar As New DSetMarca.MarcaDataTable
        For Each Mar As MarcaClass In Me
            dtMar.AddMarcaRow(Mar.Codigo, Mar.Nombre, Mar.NombreCorto, Mar.Observacion, Mar.Estatus.ToString())
        Next
        ds.Tables.Add(dtMar)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Marcas de Productos")
        'Reportes.SetParameterValue("empresa", empresa)
        Return Reportes
    End Function

End Class