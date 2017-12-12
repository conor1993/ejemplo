''Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
''Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
''Imports HC = IntegraLab.ORM.HelperClasses
''Imports CC = IntegraLab.ORM.CollectionClasses
''Imports EC = IntegraLab.ORM.EntityClasses

''Public Class FolioDiarioPolizaClass
''    Implements IEntidad


''    Dim FolDia As New EC.FolDiaEntity
''    Dim _Func As String
''    Dim _NumOpc As Integer
''    Dim _Consecutivo As Integer


''    Property Año() As String
''        Get
''            Return FolDia.NumYear
''        End Get
''        Set(ByVal value As String)
''            FolDia.NumYear = value
''        End Set
''    End Property
''    Property Mes() As String
''        Get
''            Return FolDia.NumMes
''        End Get
''        Set(ByVal value As String)
''            FolDia.NumMes = value
''        End Set
''    End Property
''    Property Consecutivo() As Integer
''        Get
''            Return _Consecutivo
''        End Get
''        Set(ByVal value As Integer)
''            _Consecutivo = value
''        End Set
''    End Property
''    Property Consecutivof() As Integer
''        Get
''            Return FolDia.Consecutif
''        End Get
''        Set(ByVal value As Integer)
''            FolDia.Consecutif = value
''        End Set
''    End Property
''    Property Func() As String
''        Get
''            Return _Func
''        End Get
''        Set(ByVal value As String)
''            _Func = value
''        End Set
''    End Property
''    Property NumOpc() As Integer
''        Get
''            Return _NumOpc
''        End Get
''        Set(ByVal value As Integer)
''            _NumOpc = value
''        End Set
''    End Property

''    Public Function Borrar() As Boolean Implements IEntidad.Borrar

''    End Function

''    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

''    End Function


''    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
''        Try
''            If SPA.UspFolDia(Año, Mes, Consecutivof, Func, NumOpc, Consecutivo, trans) = 0 Then
''                RaiseEvent MensajeError(Me, "No se pudo generar folio de poliza")
''                Return False
''            End If
''            Return True
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, "No se pudo generar folio de poliza")
''            Return False
''        End Try

''    End Function

''    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

''    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

''    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

''    End Function

''    Public Sub New()
''        FolDia = New EC.FolDiaEntity
''    End Sub

''    Public Function Guardar1() As Boolean

''    End Function

''    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

''    End Function

''    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
''        Get

''        End Get
''        Set(ByVal value As EstatusEnum)

''        End Set
''    End Property

''    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

''    End Function
''End Class
''Public Class FolioCancelacionPolizaClass
''    Implements IEntidad


''    Dim FolCan As New EC.FolCanEntity
''    Dim _Func As String
''    Dim _NumOpc As Integer
''    Dim _Consecutivo As Integer


''    Property Año() As String
''        Get
''            Return FolCan.NumYear
''        End Get
''        Set(ByVal value As String)
''            FolCan.NumYear = value
''        End Set
''    End Property
''    Property Mes() As String
''        Get
''            Return FolCan.NumMes
''        End Get
''        Set(ByVal value As String)
''            FolCan.NumMes = value
''        End Set
''    End Property
''    Property Consecutivo() As Integer
''        Get
''            Return _Consecutivo
''        End Get
''        Set(ByVal value As Integer)
''            _Consecutivo = value
''        End Set
''    End Property
''    Property Func() As String
''        Get
''            Return _Func
''        End Get
''        Set(ByVal value As String)
''            _Func = value
''        End Set
''    End Property
''    Property NumOpc() As Integer
''        Get
''            Return _NumOpc
''        End Get
''        Set(ByVal value As Integer)
''            _NumOpc = value
''        End Set
''    End Property

''    Public Function Borrar() As Boolean Implements IEntidad.Borrar

''    End Function

''    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

''    End Function


''    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
''        Try
''            If SPA.UspFolCan(Año, Mes, Func, NumOpc, Consecutivo, trans) = 0 Then
''                RaiseEvent MensajeError(Me, "No se pudo generar folio de poliza")
''                Return False
''            End If
''            Return True
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, "No se pudo generar folio de poliza")
''            Return False
''        End Try

''    End Function

''    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

''    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

''    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

''    End Function

''    Public Sub New()
''        FolCan = New EC.FolCanEntity
''    End Sub

''    Public Function Guardar1() As Boolean

''    End Function

''    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

''    End Function

''    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
''        Get

''        End Get
''        Set(ByVal value As EstatusEnum)

''        End Set
''    End Property

''    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

''    End Function
''End Class
