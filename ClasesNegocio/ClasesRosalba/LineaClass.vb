Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class LineaClass
    Implements IEntidad

    Private Linea As EC.LineaEntity
    Private _SubLinea As SubLineaCollectionClass

    <ComponentModel.DisplayName("Código")> _
    Public Property Codigo() As Integer
        Get
            Return Linea.Codigo
        End Get
        Set(ByVal value As Integer)
            'Linea.codigo = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Linea.Descripcion
        End Get
        Set(ByVal value As String)
            Linea.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Linea.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Linea.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return Linea.Observaciones
        End Get
        Set(ByVal value As String)
            Linea.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaAlta() As Date
        Get
            Return Linea.FechaAlta
        End Get
        Set(ByVal value As Date)
            Linea.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Usuario de Alta")> _
    Public Property UsuarioAlta() As Integer
        Get
            Return Linea.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Linea.UsuarioAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha de Baja")> _
    Public Property FechaBaja() As Date
        Get
            Return Linea.FechaBaja
        End Get
        Set(ByVal value As Date)
            Linea.FechaBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Usuario de Baja")> _
    Public Property UsuarioBaja() As Integer
        Get
            Return Linea.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            Linea.UsuarioBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Motivo de Baja")> _
    Public Property MotivoBaja() As Integer
        Get
            Return Linea.MotivoBaja
        End Get
        Set(ByVal value As Integer)
            Linea.MotivoBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Observaciones de Baja")> _
    Public Property ObservacionesBaja() As String
        Get
            Return Linea.ObservacionBaja
        End Get
        Set(ByVal value As String)
            Linea.ObservacionBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Linea.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Linea.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Linea de Meat")> _
    Public Property LinMeat() As Boolean
        Get
            Return Linea.LinMeat
        End Get
        Set(ByVal value As Boolean)
            Linea.LinMeat = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Linea de Punto de Venta")> _
    Public Property LinPuntoVenta() As Boolean
        Get
            Return Linea.LinPuntoVenta
        End Get
        Set(ByVal value As Boolean)
            Linea.LinPuntoVenta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Estatus Descripcion")> _
    Public ReadOnly Property EstatusDescripcion() As String
        Get
            Return Me.Estatus.ToString
        End Get
    End Property

    Public ReadOnly Property SubLineas() As SubLineaCollectionClass
        Get
            If _SubLinea Is Nothing Then
                _SubLinea = New SubLineaCollectionClass
                _SubLinea.RellenarMe(Linea.SubLinea)
            End If

            Return _SubLinea
        End Get
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim col As New CC.SubLineaCollection

            If col.GetDbCount(HC.SubLineaFields.CodigoLinea = Codigo And HC.SubLineaFields.Estatus = 1) > 0 Then
                MsgBox("Existen Sub-Líneas activas que dependen de esta línea", MsgBoxStyle.Exclamation, "Sub-Líneas Activas")
                Return False
            End If

            Linea.Estatus = EstatusEnum.INACTIVO

            Return Linea.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.LineaCollection

            If Linea.IsNew Then
                If col.GetDbCount(HC.LineaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una línea con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.LineaFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe una línea con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Linea.Save
            Else
                If col.GetDbCount(Not HC.LineaFields.Codigo = Codigo And HC.LineaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una línea con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.LineaFields.Codigo = Codigo And HC.LineaFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe una línea con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return Linea.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If Linea.FetchUsingPK(Codigo) Then
                Return True
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Sub LeerEntidad(ByVal Entidad As EC.LineaEntity)
        Me.Linea = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function ObtenerEntidad() As EC.LineaEntity
        Return Linea
    End Function

    Public Function ObtenerSubLinea() As SubLineaCollectionClass
        Dim X As New SubLineaCollectionClass()
        X.Obtener(Me)
        Return X
    End Function

    Sub New()

        AddHandler Modificado, AddressOf FueModificado

        Linea = New EC.LineaEntity

        'Linea.codigo = 0
        Linea.Descripcion = ""
        Linea.DescripcionCorta = ""
        Linea.Observaciones = ""
        Linea.Estatus = EstatusEnum.ACTIVO
        Linea.FechaAlta = New Date(1900, 1, 1)
        Linea.UsuarioAlta = 0
        Linea.FechaBaja = New Date(1900, 1, 1)
        Linea.UsuarioBaja = 0
        Linea.MotivoBaja = 0
        Linea.ObservacionBaja = ""
    End Sub

    Sub New(ByVal Codigo As Integer)
        Linea = New EC.LineaEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.LineaEntity)
        Linea = Entidad
    End Sub

    'Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    'Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
End Class

Public Class LineaCollectionClass
    Inherits CollectionClass(Of LineaClass)

    Private LineaCollection As New CC.LineaCollection
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Coleccion As CC.LineaCollection)
        Me.RellenarMe(Coleccion)
    End Sub

    Public Function Obtener(Optional ByVal fccondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.ClearItems()

            If fccondicion = CondicionEnum.TODOS Then
                LineaCollection.GetMulti(Nothing)
            Else
                LineaCollection.GetMulti(HC.LineaFields.Estatus = fccondicion)
            End If

            For Each lineaEntity As EC.LineaEntity In LineaCollection
                Dim Linea As New LineaClass
                Linea.LeerEntidad(lineaEntity)
                Me.Add(Linea)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Linea As LineaClass) As Integer
        Try
            Me.ClearItems()
            filtro = New OC.PredicateExpression
            filtro.Add(HC.LineaFields.Codigo = Linea.Codigo)
            filtro.Add(HC.LineaFields.DescripcionCorta = Linea.DescripcionCorta)
            filtro.AddWithOr(HC.LineaFields.Descripcion = Linea.Descripcion)
            Dim Conteo As Integer = LineaCollection.GetDbCount(filtro)
            If Conteo > 0 Then
                LineaCollection.GetMulti(filtro)
                For Each lineaEntity As Ec.LineaEntity In LineaCollection
                    Dim MiLinea As New LineaClass
                    MiLinea.LeerEntidad(lineaEntity)
                    Me.Add(MiLinea)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Integer
        LineaCollection = New CC.LineaCollection
        For Each linea As LineaClass In Me
            Dim lineaEntity As New EC.LineaEntity
            lineaEntity = linea.ObtenerEntidad()
            LineaCollection.Add(lineaEntity)
        Next
        Try
            Dim Conteo As Integer = LineaCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        LineaCollection = New CC.LineaCollection
        For Each linea As LineaClass In Me
            Dim LineaEntity As New EC.LineaEntity
            LineaEntity = linea.ObtenerEntidad()
            LineaCollection.Add(LineaEntity)
        Next
        Try
            Dim Conteo As Integer = LineaCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptABCLineas
        Dim Rpt As New rptABCLineas
        Dim ds As New DataSet
        Dim dtLinea As New DSLineas.dtLineasDataTable
        For Each Linea As LineaClass In Me
            dtLinea.AdddtLineasRow(Linea.Codigo, Linea.Descripcion, Linea.DescripcionCorta, Linea.Observaciones, Linea.Estatus.ToString())
        Next
        ds.Tables.Add(dtLinea)
        Rpt.SetDataSource(ds)
        Return Rpt
    End Function

    Private Sub RellenarColeccion()
        LineaCollection.Clear()
        For Each entC As LineaClass In Me
            LineaCollection.Add(entC.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal col As CC.LineaCollection)
        LineaCollection = col
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.LineaEntity In LineaCollection
            Add(New LineaClass(ente))
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.LineaCollection
        RellenarColeccion()
        Return LineaCollection
    End Function

End Class