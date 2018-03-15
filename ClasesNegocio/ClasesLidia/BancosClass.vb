Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures

Public Class BancosClass
    Implements IEntidad

    'Private WithEvents BancosEntity As EC.BancosEntity
    Private BancoEntity As New EC.BancosEntity
    Private BancoCollection As New CC.BancosCollection
    Private m_Error As Boolean

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        BancoEntity = New EC.BancosEntity
        BancoEntity.Descripcion = ""
        BancoEntity.DescripcionCorta = ""
        BancoEntity.Observaciones = ""
        BancoEntity.Estatus = EstatusEnum.ACTIVO
        BancoEntity.FechaAlta = New Date(1900, 1, 1)
        BancoEntity.FechaBaja = New Date(1900, 1, 1)
        BancoEntity.MotivoBaja = 0
        BancoEntity.UsuarioAlta = 0
        BancoEntity.UsuarioBaja = 0
        BancoEntity.ObservacionesBaja = ""
    End Sub
    Sub New(ByVal Entidad As EC.BancosEntity)
        BancoEntity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        BancoEntity = New EC.BancosEntity(Codigo)
    End Sub

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return BancoEntity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            BancoEntity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("Código")> _
    Public Property Codigo() As Integer
        Get
            Return BancoEntity.Codigo
        End Get
        Set(ByVal value As Integer)
            BancoEntity.Codigo = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return BancoEntity.Descripcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Descripcion", "Debe ingresar una Descripción")
                Throw New SystemException(" ")
            Else
                BancoEntity.Descripcion = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property
    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCta() As String
        Get
            Return BancoEntity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("DescripcionCta", "Debe ingresar una Descripción Corta")
                Throw New SystemException(" ")
            Else
                BancoEntity.DescripcionCorta = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public ReadOnly Property CveSat() As String
        Get
            Return BancoEntity.BncCveSat
        End Get
    End Property

    <System.ComponentModel.DisplayName("Cuentas Bancarias")> _
   Public ReadOnly Property Cuentas() As CuentaCollectionClass
        Get
            Dim tmp As New CuentaCollectionClass
            If BancoEntity.Cuenta.Count > 0 Then tmp = New CuentaCollectionClass(BancoEntity.Cuenta)
            Return tmp
        End Get
    End Property

    Public Property Observaciones() As String
        Get
            Return BancoEntity.Observaciones
        End Get
        Set(ByVal value As String)
            BancoEntity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.DescripcionCta
    End Function

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Dim Cuentas As New CuentaCollectionClass
            Cuentas.Obtener(Me.Codigo, EstatusEnum.ACTIVO)
            If Cuentas.Count > 0 Then
                MsgBox("No se puede Norrar el banco. Tiene cuentas Activas", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            BancoEntity.Estatus = EstatusEnum.INACTIVO
            If BancoEntity.Save() Then Return True
            RaiseEvent MensajeError(Me, "El Banco no se pudo borrar.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Guardar() As Boolean Implements IEntidad.Guardar
        Dim BancoCol As New BancosCollectionClass
        Dim BancoT As New EC.BancosEntity
        If BancoEntity.IsNew Then
            If BancoCol.Obtener(Me) > 0 Then
                BancoT = BancoCol.Item(0).ObtenerEntidad
                If BancoT.Estatus = EstatusEnum.INACTIVO Then
                    RaiseEvent MensajeError(Me, "El Banco Ya Existe y Esta Inactivo")
                Else
                    RaiseEvent MensajeError(Me, "El Banco Ya Existe...")
                End If
            Else
                Return BancoEntity.Save
            End If
        Else
            If BancoCol.Obtener(Me) > -1 Then
                If BancoCol.Count > 0 Then
                    BancoT = BancoCol.Item(0).ObtenerEntidad
                Else
                    BancoEntity = BancoT
                End If
                If BancoT.Codigo = BancoEntity.Codigo Then
                    Return BancoEntity.Save
                Else
                    RaiseEvent MensajeError(Me, "El Banco Si existe  . . .")
                End If
            Else
                RaiseEvent MensajeError(Me, "hubo un erropas.da.sd...")
            End If
        End If
        Return False
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function ObtenerEntidad() As EC.BancosEntity
        Return Me.BancoEntity
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.BancosEntity)
        BancoEntity = Entidad
    End Sub

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If BancoEntity.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Banco especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

End Class

Public Class BancosCollectionClass
    Inherits CollectionClass(Of BancosClass)

    Private BancoCollection As New CC.BancosCollection
    Private WithEvents Coleccion As New CC.BancosCollection
    Private Filtro As OC.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Borrar() As Object
        BancoCollection = New CC.BancosCollection
        For Each Banco As BancosClass In Me
            Dim BancoEntity As New EC.BancosEntity
            BancoEntity = Banco.ObtenerEntidad()
            BancoCollection.Add(BancoEntity)
        Next
        Try
            Dim Conteo As Integer = BancoCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        BancoCollection = New CC.BancosCollection
        For Each Banco As BancosClass In Me
            Dim BancoEntity As New EC.BancosEntity
            BancoEntity = Banco.ObtenerEntidad()
            BancoCollection.Add(BancoEntity)
        Next
        Try
            Dim Conteo As Integer = BancoCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()
            Dim sort As New OC.SortExpression
            sort.Add(New OC.SortClause(HC.BancosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If FcCondicion = CondicionEnum.Todos Then
                BancoCollection.GetMulti(Nothing)
            Else
                BancoCollection.GetMulti(HC.BancosFields.Estatus = FcCondicion, 0, sort)
            End If

            For Each BancoEntity As EC.BancosEntity In BancoCollection
                Dim Banco As New BancosClass
                Banco.LeerEntidad(BancoEntity)
                Me.Add(Banco)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String) As Integer
        Try
            Me.Clear()
            If Not Descripcion = "" Then
                BancoCollection.GetMulti(HC.BancosFields.DescripcionCorta Mod String.Format("%{0}%", Descripcion))
            Else
                BancoCollection.GetMulti(Nothing)
            End If

            For Each BancoEntity As EC.BancosEntity In BancoCollection
                Dim Banco As New BancosClass
                Banco.LeerEntidad(BancoEntity)
                Me.Add(Banco)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Listar() As String()
        Dim lista As New List(Of String)
        For Each e As BancosClass In Me
            lista.Add(e.DescripcionCta)
        Next
        Return lista.ToArray
    End Function
    Public Function Obtener(ByVal Banco As BancosClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.BancosFields.Codigo = Banco.Codigo)
            Filtro.AddWithOr(HC.BancosFields.Descripcion = Banco.Descripcion)
            Filtro.AddWithOr(HC.BancosFields.DescripcionCorta = Banco.DescripcionCta)
            Dim Conteo As Integer = BancoCollection.GetDbCount(Filtro)
            If Conteo > 0 Then
                BancoCollection.GetMulti(Filtro)
                For Each BancoEntity As EC.BancosEntity In BancoCollection
                    Dim MiBanco As New BancosClass
                    MiBanco.LeerEntidad(BancoEntity)
                    Me.Add(MiBanco)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As CC.BancosCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Private Sub RellenarColeccion()
        Coleccion = New CC.BancosCollection
        For Each Banco As BancosClass In Me
            Dim BancoE As New EC.BancosEntity
            BancoE = Banco.ObtenerEntidad
            Coleccion.Add(BancoE)
        Next
    End Sub

    Private Sub RellenarMe()
        Me.ClearItems()
        For Each BancoE As EC.BancosEntity In Coleccion
            Dim Banco As New BancosClass
            Banco.LeerEntidad(BancoE)
            Me.Add(Banco)
        Next
    End Sub

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CRepBanco
        Dim Reportes As New CRepBanco
        'Reporte = New CRepBanco
        Dim ds As New DataSet
        Dim dtBco As New DSetBanco.BancosDataTable
        For Each Bco As BancosClass In Me
            dtBco.AddBancosRow(Bco.Codigo.ToString(), Bco.Descripcion, Bco.DescripcionCta, Bco.Observaciones, Bco.Estatus.ToString())
        Next
        ds.Tables.Add(dtBco)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Catálogos/Bancos/Bancos")
        Return Reportes
    End Function

End Class
