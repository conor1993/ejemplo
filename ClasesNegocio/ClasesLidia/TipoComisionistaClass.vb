Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TipoComisionistaClass
    Implements IEntidad


    Private WithEvents TipoComicionistaEntity As EC.TipoComicionistaEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        TipoComicionistaEntity = New EC.TipoComicionistaEntity
        TipoComicionistaEntity.Descripcion = ""
        TipoComicionistaEntity.DescripcionCorta = ""
        TipoComicionistaEntity.Observaciones = ""
        TipoComicionistaEntity.Estatus = EstatusEnum.ACTIVO
        TipoComicionistaEntity.FechaAlta = New Date(1900, 1, 1)
    End Sub

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.ComicionistaCollection

            If col.GetDbCount(HC.ComicionistaFields.TipoComisionista = codigo And HC.ComicionistaFields.Estatus = 1) > 0 Then
                MsgBox("No es posible dar de baja este tipo de comisionista, tiene comisionistas activos", MsgBoxStyle.Exclamation, "Comisionistas Activos")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO
            Return TipoComicionistaEntity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#Region "Propiedades"
    <System.ComponentModel.DisplayName("Estatus")> _
       Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return TipoComicionistaEntity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            TipoComicionistaEntity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property codigo() As Integer
        Get
            Return TipoComicionistaEntity.Codigo
        End Get
    End Property
    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return TipoComicionistaEntity.Descripcion
        End Get
        Set(ByVal value As String)
            TipoComicionistaEntity.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("Descripción Corta")> _
Public Property DescripcionCorta() As String
        Get
            Return TipoComicionistaEntity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            TipoComicionistaEntity.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("Observacion")> _
Public Property Observacion() As String
        Get
            Return TipoComicionistaEntity.Observaciones
        End Get
        Set(ByVal value As String)
            TipoComicionistaEntity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("Fecha")> _
    Public Property Fecha() As Date
        Get
            Return TipoComicionistaEntity.FechaAlta
        End Get
        Set(ByVal value As Date)
            TipoComicionistaEntity.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
#End Region

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.TipoComicionistaCollection

            If Me.TipoComicionistaEntity.IsNew Then
                If col.GetDbCount(HC.TipoComicionistaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de comisionista con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.TipoComicionistaFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un tipo de comisionista con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Me.TipoComicionistaEntity.Save
            Else
                If col.GetDbCount(Not HC.TipoComicionistaFields.Codigo = codigo And HC.TipoComicionistaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de comisionista con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.TipoComicionistaFields.Codigo = codigo And HC.TipoComicionistaFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un tipo de comisionista con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Me.TipoComicionistaEntity.Save
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If TipoComicionistaEntity.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Tipo de Comicionista especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function ObtenerEntidad() As EC.TipoComicionistaEntity
        Return Me.TipoComicionistaEntity
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.TipoComicionistaEntity)
        TipoComicionistaEntity = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class


Public Class TipoComisionistaCollectionClass
    Inherits CollectionClass(Of TipoComisionistaClass)

    Private WithEvents Coleccion As New CC.TipoComicionistaCollection
    Private TipoComicionistaCollection As New CC.TipoComicionistaCollection
    Private Filtro As OC.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Borrar() As Object
        TipoComicionistaCollection = New CC.TipoComicionistaCollection
        For Each TipoComicionista As TipoComisionistaClass In Me
            Dim TipoComicionistaEntity As New EC.TipoComicionistaEntity
            TipoComicionistaEntity = TipoComicionista.ObtenerEntidad()
            TipoComicionistaCollection.Add(TipoComicionistaEntity)
        Next
        Try
            Dim Conteo As Integer = TipoComicionistaCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        TipoComicionistaCollection = New CC.TipoComicionistaCollection
        For Each TipoComicionista As TipoComisionistaClass In Me
            Dim TipoComicionistaEntity As New EC.TipoComicionistaEntity
            TipoComicionistaEntity = TipoComicionista.ObtenerEntidad()
            TipoComicionistaCollection.Add(TipoComicionistaEntity)
        Next
        Try
            Dim Conteo As Integer = TipoComicionistaCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()

            If FcCondicion = CondicionEnum.Todos Then
                TipoComicionistaCollection.GetMulti(Nothing)
            Else
                TipoComicionistaCollection.GetMulti(HC.TipoComicionistaFields.Estatus = FcCondicion)
            End If

            For Each TipoComicionistaEntity As EC.TipoComicionistaEntity In TipoComicionistaCollection
                Dim TipoComicionista As New TipoComisionistaClass
                TipoComicionista.LeerEntidad(TipoComicionistaEntity)
                Me.Add(TipoComicionista)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal TipoComicionista As TipoComisionistaClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            'Filtro.Add(HC.TipoComicionistaFields.Codigo = TipoComicionista.codigo)
            Filtro.AddWithOr(HC.TipoComicionistaFields.Descripcion = TipoComicionista.Descripcion)
            Filtro.AddWithOr(HC.TipoComicionistaFields.DescripcionCorta = TipoComicionista.DescripcionCorta)
            Dim Conteo As Integer = TipoComicionistaCollection.GetDbCount(Filtro)
            If Conteo > 0 Then
                TipoComicionistaCollection.GetMulti(Filtro)
                For Each TipoComicionistaEntity As EC.TipoComicionistaEntity In TipoComicionistaCollection
                    Dim MiTipoComicionista As New TipoComisionistaClass
                    MiTipoComicionista.LeerEntidad(TipoComicionistaEntity)
                    Me.Add(MiTipoComicionista)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As CC.TipoComicionistaCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Private Sub RellenarColeccion()
        Coleccion = New CC.TipoComicionistaCollection
        For Each TipoComicionista As TipoComisionistaClass In Me
            Dim TipoComicionistaE As New EC.TipoComicionistaEntity
            TipoComicionistaE = TipoComicionista.ObtenerEntidad
            Coleccion.Add(TipoComicionistaE)
        Next
    End Sub

    Private Sub RellenarMe()
        Me.ClearItems()
        For Each TipoComicionistaE As EC.TipoComicionistaEntity In Coleccion
            Dim TipoComicionista As New TipoComisionistaClass
            TipoComicionista.LeerEntidad(TipoComicionistaE)
            Me.Add(TipoComicionista)
        Next
    End Sub

    Public Function Reporte() As CRepTComisionista
        Dim Reportes As New CRepTComisionista
        Dim ds As New DataSet
        Dim dtTcom As New DSetTComisionista.DtTipoComisionistaDataTable
        For Each Tc As TipoComisionistaClass In Me
            dtTcom.AddDtTipoComisionistaRow(Tc.codigo, Tc.Descripcion, Tc.DescripcionCorta, Tc.Observacion, Tc.Estatus.ToString())
        Next
        ds.Tables.Add(dtTcom)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class