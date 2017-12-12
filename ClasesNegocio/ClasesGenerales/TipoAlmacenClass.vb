Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = INTEGRALAB.orm.StoredProcedureCallerClasses.ActionProcedures

Public Class TipoAlmacenClass
    Implements IEntidad

    Private entidad As EC.TipoAlmacenEntity

#Region "Propiedades"
    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return entidad.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return entidad.Descripcion
        End Get
        Set(ByVal value As String)
            entidad.Descripcion = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return entidad.DescripcionCorta
        End Get
        Set(ByVal value As String)
            entidad.DescripcionCorta = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return entidad.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            entidad.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Sub-Almacén")> _
    Public Property SubAlmacen() As TipoAlmacenEnum
        Get
            Return entidad.EsSubAlmacen
        End Get
        Set(ByVal value As TipoAlmacenEnum)
            entidad.EsSubAlmacen = value
        End Set
    End Property

    Public Property DeProduccion() As Boolean
        Get
            Return entidad.DeProduccion
        End Get
        Set(ByVal value As Boolean)
            entidad.DeProduccion = value
        End Set
    End Property
#End Region

    Private Function Validar() As Boolean
        Dim mensaje As String = ValidarNulos() & ValidarDisponibilidad()

        If mensaje = "" Then
            Return True
        Else
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
    End Function

    Private Function ValidarNulos() As String
        Dim mensaje As String = ""

        If Descripcion = "" Then mensaje &= "No se admite  Descripcion Nulo..." & Chr(13)
        If DescripcionCorta = "" Then mensaje &= "No se admite  Descripcion Corto Nulo..." & Chr(13)

        Return mensaje
    End Function

    Private Function ValidarDisponibilidad() As String
        Dim col As New CC.TipoAlmacenCollection
        Dim mensaje As String = ""
        If entidad.IsNew Then
            If col.GetDbCount(HC.TipoAlmacenFields.Descripcion = Descripcion) > 0 Then mensaje &= "No esta disponible la Descripción de almacen..." & Chr(13)
            If col.GetDbCount(HC.TipoAlmacenFields.DescripcionCorta = DescripcionCorta) > 0 Then mensaje &= "No esta disponible la Descripción Corta de almacen..." & Chr(13)
        Else
            If col.GetDbCount((Not HC.TipoAlmacenFields.Codigo = Codigo) And HC.TipoAlmacenFields.Descripcion = Descripcion) > 0 Then mensaje &= "No esta disponible la Descripción de almacen..." & Chr(13)
            If col.GetDbCount((Not HC.TipoAlmacenFields.Codigo = Codigo) And HC.TipoAlmacenFields.DescripcionCorta = DescripcionCorta) > 0 Then mensaje &= "No esta disponible la Descripción Corta de almacen..." & Chr(13)
        End If
        Return mensaje
    End Function

    Private Function ValidarDependencia() As Boolean
        Dim col As New CC.AlmacenCollection

        If col.GetDbCount(HC.AlmacenFields.TipoAlmacen = Codigo And HC.AlmacenFields.Estatus = EstatusEnum.ACTIVO) = 0 Then
            Return True
        Else
            MsgBox("No es posible dar de baja este Tipo de Almacen, por que hay almacenes activos " & _
                    "que dependen de el...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
    End Function

    Sub New()
        entidad = New EC.TipoAlmacenEntity
    End Sub

    Sub New(ByVal Codigo As Integer)
        entidad = New EC.TipoAlmacenEntity(Codigo)
        entidad.IsNew = False
    End Sub

    Sub New(ByVal entidad As EC.TipoAlmacenEntity)
        Me.entidad = entidad
    End Sub

    Public Sub LeerEntidad(ByVal fcentidad As EC.TipoAlmacenEntity)
        Me.entidad = fcentidad
    End Sub

    Public Function ObtenerEntidad() As EC.TipoAlmacenEntity
        Return entidad
    End Function

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        If ValidarDependencia() Then
            Try
                Estatus = EstatusEnum.INACTIVO
                If entidad.Save Then
                    Return True
                Else
                    MsgBox("No se dio de baja, intente neuvamente...", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function Guardar() As Boolean
        If Validar() Then
            Try
                Estatus = EstatusEnum.ACTIVO
                If entidad.Save Then
                    entidad.Refetch()
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        entidad.FetchUsingPK(Codigo)
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
End Class