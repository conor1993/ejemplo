Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports spr = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DecomisosClass
    Inherits ClassBase(Of EC.RegistroSacrificiosDecomisosEntity)

#Region "Miembros"
    Dim _Func As String
    Dim _NumOpc As Integer
#End Region

#Region "Constructores"
    Public Sub New()
        Entity = New EC.RegistroSacrificiosDecomisosEntity
        Entity.LoteSacrificio = ""
        Entity.IdProducto = 0
        Entity.Kilos = 0
        Entity.Piezas = 0
        Entity.Decomiso = True
    End Sub

    Public Sub New(ByVal Dec As EC.RegistroSacrificiosDecomisosEntity)
        Entity = Dec
    End Sub

    Public Sub New(ByVal FolioSacrificio As String, ByVal IdProducto As Integer)
        Entity = New EC.RegistroSacrificiosDecomisosEntity(FolioSacrificio, IdProducto)
    End Sub
#End Region

#Region "Propiedades"
    Property LoteSacrificio() As String
        Get
            Return Entity.LoteSacrificio
        End Get
        Set(ByVal value As String)
            Entity.LoteSacrificio = value
        End Set
    End Property

    ReadOnly Property Sacrificio() As RegistroSacrificiosClass
        Get
            Dim Sac As New RegistroSacrificiosClass
            Sac.LeerEntidad(Entity.MscregistroSacrificioCab)
            Return Sac
        End Get
    End Property

    Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    ReadOnly Property NombreProducto() As String
        Get
            Dim producto As New ProductosClass
            producto.Obtener(Me.IdProducto)
            Return producto.Descripcion
        End Get
    End Property

    Property Piezas() As Integer
        Get
            Return Entity.Piezas
        End Get
        Set(ByVal value As Integer)
            Entity.Piezas = value
        End Set
    End Property

    Public Property PiezasEmbarcadas() As Integer
        Get
            Return Entity.PiezasEmbarcadas
        End Get
        Set(ByVal value As Integer)
            Entity.PiezasEmbarcadas = value
        End Set
    End Property

    Public ReadOnly Property PiezasDisponibles() As Integer
        Get
            Return Piezas - PiezasEmbarcadas
        End Get
    End Property

    Property Kilos() As Decimal
        Get
            Return Entity.Kilos
        End Get
        Set(ByVal value As Decimal)
            Entity.Kilos = value
        End Set
    End Property

    Public Property KilosEmbarcados() As Decimal
        Get
            Return Entity.KilosEmbarcados
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosEmbarcados = value
        End Set
    End Property

    Public ReadOnly Property KilosDisponibles() As Decimal
        Get
            Return Kilos - KilosEmbarcados
        End Get
    End Property

    Property Decomiso() As Boolean
        Get
            Return Entity.Decomiso
        End Get
        Set(ByVal value As Boolean)
            Entity.Decomiso = value
        End Set
    End Property

    Property MotivoDecomiso() As Integer
        Get
            Return Entity.IdDecomiso
        End Get
        Set(ByVal value As Integer)
            Entity.IdDecomiso = value
        End Set
    End Property

    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property

    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property

    Property IdAlmacenProd() As Integer
        Get
            Return Me.Entity.IdAlmacenProd.GetValueOrDefault(0)
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdAlmacenProd = value
        End Set
    End Property

    Public Property KilosSalida() As Decimal
        Get
            Return Entity.KilosSalida
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosSalida = value
        End Set
    End Property

    Public Property PiezasSalida() As Integer
        Get
            Return Entity.PiezasSalida
        End Get
        Set(ByVal value As Integer)
            Entity.PiezasSalida = value
        End Set
    End Property

    Property FolioMovimientoAlm() As String
        Get
            Return Entity.FolioMovAlmacen
        End Get
        Set(ByVal value As String)
            Entity.FolioMovAlmacen = value
        End Set
    End Property

    Property FolioCancelMovAlm() As String
        Get
            Return Entity.FolioCancelAlmacen
        End Get
        Set(ByVal value As String)
            Entity.FolioCancelAlmacen = value
        End Set
    End Property

    Property Estatus() As EstatusDatos
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            Entity.Estatus = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function Guardar(Optional ByVal trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Estatus = EstatusDatos.VIGENTE

            If SPA.UspRegistroSacrificiosDecomisos(LoteSacrificio, IdProducto, Piezas, Kilos, Decomiso, Me.IdAlmacenProd, Me.FolioMovimientoAlm, Estatus, Func, NumOpc, trans) = 0 Then
                'RaiseEvent MensajeError(Me, "Error al guardar información de Productos")
                Return False
            End If

            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function Guardar2(ByVal trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            trans.Add(Entity)
            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Opcion As String, ByVal LoteSacrificio As String) As DataTable
        Try
            Obtener = spr.UspConRegistroSacrificiosDecomisos(Opcion, LoteSacrificio)
        Catch ex As Exception
            Obtener = Nothing
            MessageBox.Show(ex.Message)
        End Try
    End Function
#End Region
End Class

Public Class DecomisosColeccionClass
    Inherits ColleccionBase(Of EC.RegistroSacrificiosDecomisosEntity, CC.RegistroSacrificiosDecomisosCollection, DecomisosClass)

#Region "Miembros"
    Dim filtro As ORM.PredicateExpression
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Obtiene los qe son decomisos filtrando por determinado folio de Sacrificio
    ''' </summary>
    ''' <param name="FolioSacrificio"></param >
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal FolioSacrificio As String, Optional ByVal IdIntroductor As Integer = 0, Optional ByVal IdProducto As Integer = 0, Optional ByVal EsDecomiso As Boolean = False, Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS, Optional ByVal IgnonarExistencia As Boolean = True) As Integer
        Try
            Dim rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection

            rel.Add(EC.RegistroSacrificiosDecomisosEntity.Relations.MscregistroSacrificioCabEntityUsingLoteSacrificio, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            rel.Add(EC.MsccatProductosEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdProducto, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

            coleccion = New CC.RegistroSacrificiosDecomisosCollection
            filtro = New ORM.PredicateExpression
            filtro.Add(HC.RegistroSacrificiosDecomisosFields.Decomiso = EsDecomiso)

            If FolioSacrificio <> "" Then
                filtro.Add(HC.RegistroSacrificiosDecomisosFields.LoteSacrificio = FolioSacrificio)
            End If

            If IdIntroductor <> 0 Then
                filtro.Add(HC.MscregistroSacrificioCabFields.IdCodCliente = IdIntroductor)
            End If

            If IdProducto <> 0 Then
                filtro.Add(HC.RegistroSacrificiosDecomisosFields.IdProducto = IdProducto)
                filtro.Add(HC.RegistroSacrificiosDecomisosFields.Kilos > HC.RegistroSacrificiosDecomisosFields.KilosEmbarcados And HC.RegistroSacrificiosDecomisosFields.Piezas > HC.RegistroSacrificiosDecomisosFields.PiezasEmbarcadas)
            End If

            If Estatus <> CondicionEnum.TODOS Then
                filtro.Add(HC.RegistroSacrificiosDecomisosFields.Estatus = Estatus)
            End If

            If Not IgnonarExistencia Then
                filtro.Add(HC.RegistroSacrificiosDecomisosFields.Kilos > HC.RegistroSacrificiosDecomisosFields.KilosEmbarcados And HC.RegistroSacrificiosDecomisosFields.Piezas > HC.RegistroSacrificiosDecomisosFields.PiezasEmbarcadas)
            End If

            coleccion.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.MsccatProductosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), rel)
            Rellenar()

            Return Me.Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    ''' <summary>
    ''' Obtiene Todos los qe son decomisos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal EsDecomiso As Boolean, Optional ByVal FolioSacrificio As String = "", Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS, Optional ByVal IgnonarExistencia As Boolean = True) As Integer
        Try
            Dim rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection
            Dim Filtro As New OC.PredicateExpression

            rel.Add(EC.MsccatProductosEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdProducto, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

            If Not FolioSacrificio = "" Then
                Filtro.Add(HC.RegistroSacrificiosDecomisosFields.LoteSacrificio = FolioSacrificio)
            End If

            If Estatus <> CondicionEnum.TODOS Then
                Filtro.Add(HC.RegistroSacrificiosDecomisosFields.Estatus = Estatus)
            End If

            If Not IgnonarExistencia Then
                Filtro.Add(HC.RegistroSacrificiosDecomisosFields.Kilos > HC.RegistroSacrificiosDecomisosFields.KilosEmbarcados And HC.RegistroSacrificiosDecomisosFields.Piezas > HC.RegistroSacrificiosDecomisosFields.PiezasEmbarcadas)
            End If

            Filtro.Add(HC.RegistroSacrificiosDecomisosFields.Decomiso = EsDecomiso)

            coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.MsccatProductosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), rel)
            Rellenar()

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal IdProducto As Integer, Optional ByVal FolioSacrificio As String = "", Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.Clear()
            Dim Filtro As New OC.PredicateExpression
            coleccion = New CC.RegistroSacrificiosDecomisosCollection
            If IdProducto > 0 Then
                Filtro.Add(HC.RegistroSacrificiosDecomisosFields.IdProducto = IdProducto)
            End If
            If Not FolioSacrificio = "" Then
                Filtro.Add(HC.RegistroSacrificiosDecomisosFields.LoteSacrificio = FolioSacrificio)
            End If

            If Estatus <> CondicionEnum.TODOS Then
                Filtro.Add(HC.RegistroSacrificiosDecomisosFields.Estatus = Estatus)
            End If
            Filtro.Add(HC.RegistroSacrificiosDecomisosFields.Decomiso = False)

            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Private Overloads Sub Rellenar()
        Clear()
        For Each ente As EC.RegistroSacrificiosDecomisosEntity In coleccion
            Add(New DecomisosClass(ente))
        Next
    End Sub
#End Region
End Class