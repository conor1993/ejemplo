Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class SubLineaClass
    Implements IEntidad


    Private SubLinea As EC.SubLineaEntity
    Private m_linea As New LineaClass

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            SubLinea.Estatus = EstatusEnum.INACTIVO
            If SubLinea.Save Then Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return SubLinea.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            SubLinea.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.SubLineaCollection

            If SubLinea.IsNew Then
                Estatus = EstatusEnum.ACTIVO

                If col.GetDbCount(HC.SubLineaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una sub-linea con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.SubLineaFields.DescripcionCorta = DescCorta) > 0 Then
                    MsgBox("Ya existe una sub-linea con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If SubLinea.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If col.GetDbCount(Not HC.SubLineaFields.Codigo = Codigo And HC.SubLineaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una sub-linea con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.SubLineaFields.Codigo = Codigo And HC.SubLineaFields.DescripcionCorta = DescCorta) > 0 Then
                    MsgBox("Ya existe una sub-linea con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If SubLinea.Save Then
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
            If SubLinea.FetchUsingPK(Codigo) Then
                Return True
            End If
            RaiseEvent MensajeError(Me, "La Sub-Linea no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Sub LeerEntidad(ByVal Entidad As EC.SubLineaEntity)
        Me.SubLinea = Entidad
    End Sub

    Public Function ObtenerEntidad() As EC.SubLineaEntity
        Return SubLinea
    End Function

    Public Property Linea() As LineaClass
        Get
            m_linea.LeerEntidad(SubLinea.Linea)
            Return m_linea
        End Get
        Set(ByVal value As LineaClass)
            m_linea = value
            SubLinea.Linea = m_linea.ObtenerEntidad
            'SubLinea.Linea = m_linea.Codigo.ToString
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return SubLinea.Codigo
        End Get
        Set(ByVal value As Integer)
            'SubLinea.SubLinea = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return SubLinea.Descripcion
        End Get
        Set(ByVal value As String)
            SubLinea.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property DescCorta() As String
        Get
            Return SubLinea.DescripcionCorta
        End Get
        Set(ByVal value As String)
            SubLinea.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return SubLinea.Observaciones
        End Get
        Set(ByVal value As String)
            SubLinea.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return SubLinea.FechaAlta
        End Get
        Set(ByVal value As Date)
            SubLinea.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property CodigoUsuarioAlta() As Integer
        Get
            Return SubLinea.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            SubLinea.UsuarioAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property FechaBaja() As Date
        Get
            Return SubLinea.FechaBaja
        End Get
        Set(ByVal value As Date)
            SubLinea.FechaBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property CodigoUsuarioBaja() As Integer
        Get
            Return SubLinea.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            SubLinea.UsuarioBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property CodigoMotivoBaja() As Integer
        Get
            Return SubLinea.MotivoBaja
        End Get
        Set(ByVal value As Integer)
            SubLinea.MotivoBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property ObservacionesBaja() As String
        Get
            Return SubLinea.Observaciones
        End Get
        Set(ByVal value As String)
            SubLinea.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Sub New()

        AddHandler Modificado, AddressOf FueModificado

        'Inicializo el objeto...
        SubLinea = New EC.SubLineaEntity()

        'SubLinea.Linea = 0
        SubLinea.Descripcion = ""
        SubLinea.DescripcionCorta = ""
        SubLinea.Observaciones = ""
        SubLinea.FechaAlta = New Date(1900, 1, 1)
        SubLinea.UsuarioAlta = 0
        SubLinea.FechaBaja = New Date(1900, 1, 1)
        SubLinea.UsuarioBaja = 0
        SubLinea.MotivoBaja = 0
        SubLinea.ObservacionBaja = ""

    End Sub

    Sub New(ByVal codigo As Integer)
        SubLinea = New EC.SubLineaEntity(codigo)
    End Sub

    Sub New(ByVal Entidad As EC.SubLineaEntity)
        SubLinea = Entidad
    End Sub

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

Public Class SubLineaCollectionClass
    Inherits CollectionClass(Of SubLineaClass)

    Private SubLineaCol As New CC.SubLineaCollection
    Private filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.ClearItems()

            If FcCondicion = CondicionEnum.TODOS Then
                SubLineaCol.GetMulti(Nothing)
            Else
                SubLineaCol.GetMulti(HC.SubLineaFields.Estatus = FcCondicion)
            End If

            For Each SubLineaEntity As EC.SubLineaEntity In SubLineaCol
                Dim subLinea As New SubLineaClass
                subLinea.LeerEntidad(SubLineaEntity)
                Me.Add(subLinea)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal SubLinea As SubLineaClass) As Integer
        Try
            Me.ClearItems()
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            'filtro.Add(HC.SubLineaFields.SlidSubLinea = SubLinea.Codigo)
            filtro.AddWithOr(HC.SubLineaFields.DescripcionCorta = SubLinea.DescCorta)
            filtro.AddWithOr(HC.SubLineaFields.Descripcion = SubLinea.Descripcion)
            Dim Conteo As Integer = SubLineaCol.GetDbCount(filtro)
            If Conteo > 0 Then
                SubLineaCol.GetMulti(filtro)
                For Each SubLineaEntity As EC.SubLineaEntity In SubLineaCol
                    Dim miSubLinea As New SubLineaClass
                    miSubLinea.LeerEntidad(SubLineaEntity)
                    Me.Add(miSubLinea)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Linea As LineaClass) As SubLineaCollectionClass
        Try
            Me.ClearItems()
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.SubLineaFields.CodigoLinea = Linea.Codigo)
            Dim Conteo As Integer = SubLineaCol.GetDbCount(filtro)
            If Conteo > 0 Then
                SubLineaCol.GetMulti(filtro)
                Me.Rellenar()
            End If
            Return Me
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub Rellenar()
        Clear()
        For Each SubLineas As EC.SubLineaEntity In SubLineaCol
            Add(New SubLineaClass(SubLineas))
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.SubLineaCollection)
        SubLineaCol = Col
        Rellenar()
    End Sub

    Public Function Guardar() As Integer
        SubLineaCol = New CC.SubLineaCollection
        For Each SubLinea As SubLineaClass In Me
            Dim SubLineaEntity As New EC.SubLineaEntity
            SubLineaEntity = SubLinea.ObtenerEntidad()
            SubLineaCol.Add(SubLineaEntity)
        Next
        Try
            Dim Conteo As Integer = SubLineaCol.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        SubLineaCol = New CC.SubLineaCollection
        For Each subLinea As SubLineaClass In Me
            Dim SubLineaEntity As New EC.SubLineaEntity
            SubLineaEntity = subLinea.ObtenerEntidad
            SubLineaCol.Add(SubLineaEntity)
        Next
        Try
            Dim Conteo As Integer = SubLineaCol.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptABCSubLineas
        Dim rpt As New rptABCSubLineas
        Dim ds As New DataSet
        Dim dtSubLinea As New DSSubLineas.dtSubLineasDataTable
        For Each SL As SubLineaClass In Me
            dtSubLinea.AdddtSubLineasRow(SL.Codigo, SL.Descripcion, SL.DescCorta, SL.Observaciones, SL.Estatus.ToString(), SL.Linea.Descripcion)
        Next
        ds.Tables.Add(dtSubLinea)
        rpt.SetDataSource(ds)
        Return rpt
    End Function

End Class