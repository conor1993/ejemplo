Imports System.Windows.Forms
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports SPA = Integralab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class RecepcionCanalesCabClass
    Inherits ClassBase(Of EC.MscrecepcionCanalesCabEntity)

#Region "Miembros"

    Private _Funcion As String
    Private _Opcion As Integer

#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.MscrecepcionCanalesCabEntity
    End Sub
    Sub New(ByVal Entidad As EC.MscrecepcionCanalesCabEntity)
        Entity = Entidad
    End Sub
    Sub New(ByVal FolioMov As String, ByVal FolioSacrif As String)
        Entity = New EC.MscrecepcionCanalesCabEntity(FolioMov, FolioSacrif)
    End Sub
#End Region

#Region "Propiedades"

    Public Property FolioMov() As String
        Get
            Return Entity.FolioMovimiento
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimiento = value
        End Set
    End Property

    Public Property FolioSacrificio() As String
        Get
            Return Entity.FolioSacrificio
        End Get
        Set(ByVal value As String)
            Entity.FolioSacrificio = value
        End Set
    End Property

    Public Property IFechaSacrificio() As Date
        Get
            Return Entity.FechaSacrificio
        End Get
        Set(ByVal value As Date)
            Entity.FechaSacrificio = value
        End Set
    End Property

    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    Public Property LotePropio() As Byte
        Get
            Return Entity.LotePropio
        End Get
        Set(ByVal value As Byte)
            Entity.LotePropio = value
        End Set
    End Property

    Public Property CodCliente() As Integer
        Get
            Return Entity.CodCliente
        End Get
        Set(ByVal value As Integer)
            Entity.CodCliente = value
        End Set
    End Property

    Public Property CantCanales() As Integer
        Get
            Return Me.Entity.CantCanales
        End Get
        Set(ByVal value As Integer)
            Me.Entity.CantCanales = value
        End Set
    End Property

    Public Property KgrsRastro() As Decimal
        Get
            Return Me.Entity.KgrsRastro
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.KgrsRastro = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Me.Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Me.Entity.Observaciones = value
        End Set
    End Property

    Public Property Estatus() As Char
        Get
            Return Me.Entity.Estatus
        End Get
        Set(ByVal value As Char)
            Me.Entity.Estatus = value
        End Set
    End Property

    Public Property FechaSacrificio() As Date
        Get
            Return Me.Entity.FechaSacrificio
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaSacrificio = value
        End Set
    End Property
    Public Property FechaCancelacion() As Date
        Get
            Return Me.Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property IdRastro() As Integer
        Get
            Return Me.Entity.IdRastro
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdRastro = value
        End Set
    End Property

    Public Property KgrsBascula() As Decimal
        Get
            Return Me.Entity.KgrsBascula
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.KgrsBascula = value
        End Set
    End Property

    Public Property KgrsCalientes() As Decimal
        Get
            Return Me.Entity.KgrsCalientes
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.KgrsCalientes = value
        End Set
    End Property

    Public Property IdUsuarioCancelacion() As Integer
        Get
            Return Me.Entity.IdUsuarioCancela
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdUsuarioCancela = value
        End Set
    End Property

    Public Property Funcion() As String
        Get
            Return _Funcion
        End Get
        Set(ByVal value As String)
            _Funcion = value
        End Set
    End Property

    Public Property Opcion() As Integer
        Get
            Return _Opcion
        End Get
        Set(ByVal value As Integer)
            _Opcion = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal FolioMov As String, ByVal FolioSacrif As String) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(FolioMov, FolioSacrif)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If SPA.UspMscrecepcionCanalesCab(Me.FolioMov, Me.FolioSacrificio, Me.FechaSacrificio, Me.FechaCaptura, Me.LotePropio, Me.CodCliente, Me.CantCanales, Me.KgrsRastro, Me.Observaciones, Me.Estatus, "01/01/2000", Me.KgrsCalientes, Me.IdRastro, Me.KgrsBascula, Me.Funcion, Me.Opcion, Trans) = 0 Then
                Return False
                MessageBox.Show("No se pudo guardar la recepción de canales, ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

#End Region

End Class

Public Class RecepcionCanaleCabCollectionClass
    Inherits ColleccionBase(Of EC.MscrecepcionCanalesCabEntity, CC.MscrecepcionCanalesCabCollection, RecepcionCanalesCabClass)
    Dim Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    Public Overloads Function Obtener() As Integer
        Try
            Me.Clear()
            coleccion = New CC.MscrecepcionCanalesCabCollection
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
#Else
            MessageBox.Show("Ocurrió un Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
#End If
        End Try
    End Function
End Class

Public Class RecepcionCanalesDetClass
    Inherits ClassBase(Of EC.MscrecepcionCanalesDetEntity)
    Private _Func As String
    Private _Opcion As String
    Private _Cliente As ClientesIntroductoresClass

#Region "Constructores"
    Sub New()
        Entity = New EC.MscrecepcionCanalesDetEntity
    End Sub
    Sub New(ByVal Entidad As EC.MscrecepcionCanalesDetEntity)
        Entity = entidad
    End Sub
    Sub New(ByVal FolioMov As String, ByVal FolioSacrif As String, ByVal IdFolioCanal As String, ByVal Consecutivo As Integer)
        Entity = New EC.MscrecepcionCanalesDetEntity(FolioMov, FolioSacrif, IdFolioCanal, Consecutivo)
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioMov() As String
        Get
            Return Me.Entity.FolioMovimiento
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioMovimiento = value
        End Set
    End Property

    Public Property IdFolioCanal() As String
        Get
            Return Me.Entity.IdFolioCanal
        End Get
        Set(ByVal value As String)
            Me.Entity.IdFolioCanal = value
        End Set
    End Property

    Public Property FolioSacrificio() As String
        Get
            Return Me.Entity.FolioSacrificio
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioSacrificio = value
        End Set
    End Property

    Public Property Consecutivo() As Integer
        Get
            Return Me.Entity.Consecutivo
        End Get
        Set(ByVal value As Integer)
            Me.Entity.Consecutivo = value
        End Set
    End Property

    Public Property Lado() As Integer
        Get
            Return Me.Entity.Lado
        End Get
        Set(ByVal value As Integer)
            Me.Entity.Lado = value
        End Set
    End Property

    Public Property KgrsBascula() As Decimal
        Get
            Return Me.Entity.KgrsBascula
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.KgrsBascula = value
        End Set
    End Property

    Public Property KgrsRastro() As Decimal
        Get
            Return Me.Entity.KgrsRastro
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.KgrsRastro = value
        End Set
    End Property

    Public Property Estatus() As EstatusCanal
        Get
            Return Asc(Entity.Estatus)
        End Get
        Set(ByVal value As EstatusCanal)
            Me.Entity.Estatus = Chr(value)
        End Set
    End Property

    Public ReadOnly Property EstatusCadena() As String
        Get
            Return Estatus.ToString
        End Get
    End Property

    Public Property IdFolioMovimiento() As String
        Get
            Return Me.Entity.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            Me.Entity.IdFolioMovimiento = value
        End Set
    End Property

    Public Property CodigoBarra() As String
        Get
            Return Me.Entity.CodigoBarra
        End Get
        Set(ByVal value As String)
            Me.Entity.CodigoBarra = value
        End Set
    End Property

    Public Property KgrsCalientes() As Decimal
        Get
            Return Me.Entity.KgrsCalientes.GetValueOrDefault(0)
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.KgrsCalientes = value
        End Set
    End Property

    Public Property IdFolioMovCancela() As String
        Get
            Return Me.Entity.IdFolioMovimientoCancela
        End Get
        Set(ByVal value As String)
            Me.Entity.IdFolioMovimientoCancela = value
        End Set
    End Property

    Public Property IdUsuarioCancela() As Integer
        Get
            Return Me.Entity.IdUsuarioCancela
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdUsuarioCancela = value
        End Set
    End Property

    Property FechaCancela() As Date
        Get
            Return Me.Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property LoteEngorda() As String
        Get
            Return Me.Entity.LoteEngora
        End Get
        Set(ByVal value As String)
            Me.Entity.LoteEngora = value
        End Set
    End Property

    Public Property IdCliente() As Integer
        Get
            Return Entity.IdCliente.GetValueOrDefault(0)
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Public ReadOnly Property NomCliente() As String
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(IdCliente)
            End If
            Return _Cliente.Nombre
        End Get
    End Property
    Public Property Sexo() As SexoEnum
        Get
            Return Entity.Sexo.GetValueOrDefault(0)
        End Get
        Set(ByVal value As SexoEnum)
            Entity.Sexo = value
        End Set
    End Property

    Public Property Funcion() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property

    Public Property Opcion() As Integer
        Get
            Return _Opcion
        End Get
        Set(ByVal value As Integer)
            _Opcion = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If SPA.UspMscrecepcionCanalesDet(Me.FolioMov, Me.FolioSacrificio, Me.IdFolioCanal, Me.Lado, Me.KgrsRastro, Me.KgrsBascula, Me.KgrsCalientes, Chr(Me.Estatus), Me.IdFolioMovimiento, Me.IdCliente, Me.Sexo, Me.Consecutivo, Me.CodigoBarra, Me.Funcion, Me.Opcion, Trans) = 0 Then
                Return False
                MessageBox.Show("No se ha podido Guardar en Recepción de Canales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function Obtener(ByVal FolioMov As String, ByVal FolioSacrif As String, ByVal FolioCanal As String, ByVal Consecutivo As Integer) As Integer
        Try
            Return Me.Entity.FetchUsingPK(FolioMov, FolioSacrif, FolioCanal, Consecutivo)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
#Else
            messagebox.Show("Ocurrió un Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
#End If
        End Try
    End Function

    Public Function Obtener(ByVal Opcion As Integer, ByVal LoteSacrificio As String, ByVal FolioCanal As String, ByVal fecha As Date, Optional ByVal LoteCorte As String = "") As DataSet
        Try
            Obtener = SPR.UspConMscrecepcionCanalesDet(LoteSacrificio, FolioCanal, Opcion, fecha, LoteCorte)
        Catch ex As Exception
            Obtener = Nothing
            MessageBox.Show(ex.Message)
        End Try
    End Function
#End Region

End Class

Public Class RecepcionCanalesDetCollectionClass
    Inherits ColleccionBase(Of EC.MscrecepcionCanalesDetEntity, CC.MscrecepcionCanalesDetCollection, RecepcionCanalesDetClass)

    Public Overloads Function Obtener(ByVal FcCondicion As CondicionEnum, Optional ByVal SinClientes As Boolean = False) As Integer
        Try            
            Me.Clear()
            coleccion = New CC.MscrecepcionCanalesDetCollection
            Dim Filtro As New OC.PredicateExpression

            If SinClientes Then
                Filtro.Add(HC.MscrecepcionCanalesDetFields.IdCliente = DBNull.Value Or HC.MscrecepcionCanalesDetFields.IdCliente = 0)
            End If

            If FcCondicion = CondicionEnum.ACTIVOS Then
                Filtro.Add(HC.MscrecepcionCanalesDetFields.Estatus = "V")
            End If

            If FcCondicion = CondicionEnum.INACTIVOS Then
                Filtro.Add(HC.MscrecepcionCanalesDetFields.Estatus = "X")
            End If

            coleccion.GetMulti(Filtro, 0, Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
#Else
messagebox.Show("Ocurrió un Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
#End If
        End Try
    End Function

    Public Overloads Function Obtener(ByVal folioSacrificio As String) As Integer
        Try
            coleccion.GetMulti(HC.MscrecepcionCanalesDetFields.FolioSacrificio = folioSacrificio, 0, Nothing)

            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
#Else
messagebox.Show("Ocurrió un Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
#End If
        End Try
    End Function

    Public Overloads Function Obtener(ByVal FolioSacrificio As String, ByVal Kilos As Decimal, Optional ByVal SinClientes As Boolean = False) As Integer
        Try
            Me.Clear()
            Dim Filtro As New OC.PredicateExpression
            If Not FolioSacrificio = "" Then
                Filtro.Add(HC.MscrecepcionCanalesDetFields.FolioSacrificio = FolioSacrificio)
            End If
            If Not Kilos = 0 Then
                Filtro.Add(HC.MscrecepcionCanalesDetFields.KgrsCalientes = Kilos)
            End If
            If SinClientes Then
                Filtro.Add(HC.MscrecepcionCanalesDetFields.IdCliente = DBNull.Value Or HC.MscrecepcionCanalesDetFields.IdCliente = 0)
            End If
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class