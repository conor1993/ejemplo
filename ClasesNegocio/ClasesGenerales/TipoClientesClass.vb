Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports System.Windows.Forms

Public Class TipoClientesClass
    Implements IEntidad
    Dim Entity As EC.McattiposclienteEntity

#Region "Miembros"
    'Private WithEvents TipoProveedor As IntegraLab.ORM.EntityClasses.TipoProveedorEntity
    Private _Error As Boolean = False

#End Region

#Region "propiedades"
    <System.ComponentModel.DisplayName("Codigo")> _
    ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Idtipocliente
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            'If value.Replace(" ", "").Length = 0 Then
            '    _Error = True
            '    RaiseEvent MensajeError(Me, "La Descripción Corta es Obligatoria.")
            'Else
            Entity.DescripcionCorta = value
            'End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("ObserVaciones")> _
    Public Property ObserVaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            'If value.Replace(" ", "").Length = 0 Then
            '    _Error = True
            '    RaiseEvent MensajeError(Me, "La Descripción Corta es Obligatoria.")
            'Else
            Entity.Observaciones = value
            'End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha")> _
    Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    ReadOnly Property [Error]() As Boolean
        Get
            Return _Error
        End Get
    End Property

#End Region

#Region "Region"
    Sub New()
        Entity = New Integralab.ORM.EntityClasses.McattiposclienteEntity
        Entity.FechaAlta = Now
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As EC.McattiposclienteEntity)
        Me.Entity = Entidad
    End Sub

    Public Sub LimpiarError()
        _Error = False
    End Sub

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Entity.Estatus = EstatusEnum.INACTIVO
            If Entity.Save Then
                Return True
            Else
                RaiseEvent MensajeError(Me, "No se logró dar de baja, intente de nuevo.")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se logró dar de baja, intente de nuevo.")
            Return False
        End Try
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function


    Public Function Guardar() As Boolean Implements IEntidad.Guardar
        Try
            If Entity.Save Then
                Return True
            Else
                MsgBox("No se logró guardar el tipo de cliente, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("No se logro guardar el tipo de cliente, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

    Public Event MensajeError(sender As Object, mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(sender As Object, e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If Entity.FetchUsingPK(Codigo) Then
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Tipo de Cliente especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal entidad As EC.McattiposclienteEntity)
        Entity = entidad
    End Sub

    Public Function ObtenerEntidad() As EC.McattiposclienteEntity
        Return Me.Entity
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

#End Region

End Class


Public Class tiposclienteCollectionClass
    Inherits CollectionClass(Of TipoClientesClass)

    Private Col As New CC.McattiposclienteCollection

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.Clear()

            If FcCondicion = CondicionEnum.TODOS Then
                Col.GetMulti(Nothing)
            Else
                Col.GetMulti(HC.McattiposclienteFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Col.Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Nombre As Integer, ByVal NombreCorto As Integer, Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.Clear()

            Dim filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.McattiposclienteFields.Estatus = FcCondicion)
            End If

            filtro.Add(HC.McattiposclienteFields.Descripcion Mod String.Format("%{0}%", Nombre))
            filtro.Add(HC.McattiposclienteFields.DescripcionCorta Mod String.Format("%{0}%", NombreCorto))

            Col.GetMulti(filtro)

            Rellenar()

            Return Col.Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Private Sub Rellenar()
        For Each ente As EC.McattiposclienteEntity In Col
            Dim tipo As New TipoClientesClass
            tipo.LeerEntidad(ente)
            Add(tipo)
        Next
    End Sub

End Class