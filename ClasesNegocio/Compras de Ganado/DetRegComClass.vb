Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TVC = IntegraLab.ORM.TypedViewClasses

'Public Class ComprasGanadoDetalleClass
'    Inherits ClassBase(Of EC.DetRegComEntity)

'#Region "Declaraciones"
'    Dim m_CompraGanado As CompraGanadoClass
'    Dim m_TipoGanado As TipoGanadoClass
'#End Region

'#Region "Constructores"

'    Sub New()
'        Entity = New EC.DetRegComEntity
'    End Sub

'    Sub New(ByVal Entidad As EC.DetRegComEntity)
'        Entity = Entidad
'    End Sub

'    Sub New(ByVal Folio As String, ByVal IdRenglon As Short, ByVal IdTipoGanado As Integer)
'        Entity = New EC.DetRegComEntity(Folio, IdRenglon, IdTipoGanado)
'    End Sub
'#End Region

'#Region "Propiedades"

'    Property Folio() As String
'        Get
'            Return Entity.FolRecep
'        End Get
'        Set(ByVal value As String)
'            Entity.FolRecep = value
'        End Set
'    End Property

'    Public Property CompraGanado() As CompraGanadoClass
'        Get
'            If m_CompraGanado Is Nothing Then
'                m_CompraGanado = New CompraGanadoClass(Entity.CabRegCom)
'            ElseIf Not m_CompraGanado.Folio.Trim = Folio.Trim Then
'                m_CompraGanado.Entidad = Entity.CabRegCom
'            End If

'            Return m_CompraGanado
'        End Get
'        Set(ByVal value As CompraGanadoClass)
'            m_CompraGanado = value

'            If value Is Nothing Then
'                Entity.CabRegCom = Nothing
'            Else
'                Entity.CabRegCom = value.Entidad
'            End If
'        End Set
'    End Property

'    Property IdRenglon() As Short
'        Get
'            Return Entity.CveRenglon
'        End Get
'        Set(ByVal value As Short)
'            Entity.CveRenglon = value
'        End Set
'    End Property

'    Property IdTipoGanado() As Integer
'        Get
'            Return Entity.CveGanado
'        End Get
'        Set(ByVal value As Integer)
'            Entity.CveGanado = value
'        End Set
'    End Property

'    Property CantCabezas() As Short
'        Get
'            Return Entity.CantCabezas
'        End Get
'        Set(ByVal value As Short)
'            Entity.CantCabezas = value
'        End Set
'    End Property

'    Property CantKilos() As Decimal
'        Get
'            Return Entity.CantKilos
'        End Get
'        Set(ByVal value As Decimal)
'            Entity.CantKilos = value
'        End Set
'    End Property

'    Property PrecioXKilo() As Decimal
'        Get
'            Return Entity.PrecioXkilo
'        End Get
'        Set(ByVal value As Decimal)
'            Entity.PrecioXkilo = value
'        End Set
'    End Property

'    Property Encabezado() As CompraGanadoClass
'        Get
'            If Me.m_CompraGanado Is Nothing Then
'                m_CompraGanado = New CompraGanadoClass(Entity.CabRegCom)
'            ElseIf Not m_CompraGanado.Folio = Me.Folio Then
'                m_CompraGanado.Entidad = Entity.CabRegCom
'            End If

'            Return m_CompraGanado
'        End Get
'        Set(ByVal value As CompraGanadoClass)
'            m_CompraGanado = value

'            If value Is Nothing Then
'                Entity.CabRegCom = Nothing
'            Else
'                Entity.CabRegCom = value.Entidad
'            End If
'        End Set
'    End Property

'    Property TipoGanado() As TipoGanadoClass
'        Get
'            If m_TipoGanado Is Nothing Then
'                m_TipoGanado = New TipoGanadoClass(Entity.McgcatTiposdeGanado)
'            ElseIf Not m_TipoGanado.IdTipoGanado = Me.IdTipoGanado Then
'                m_TipoGanado.Entidad = Entity.McgcatTiposdeGanado
'            End If

'            Return m_TipoGanado
'        End Get
'        Set(ByVal value As TipoGanadoClass)
'            m_TipoGanado = value

'            If value Is Nothing Then
'                Entity.McgcatTiposdeGanado = Nothing
'            Else
'                Entity.McgcatTiposdeGanado = value.Entidad
'            End If
'        End Set
'    End Property

'    Public Property KilosRecibidos() As Decimal
'        Get
'            Return Entity.CantKilosRecibidos
'        End Get
'        Set(ByVal value As Decimal)
'            Entity.CantKilosRecibidos = value
'        End Set
'    End Property

'    ReadOnly Property DescripcionTipoGanado() As String
'        Get
'            Return TipoGanado.Descripcion
'        End Get
'    End Property

'    ReadOnly Property Importe() As Decimal
'        Get
'            Return CantKilos * PrecioXKilo
'        End Get
'    End Property

'    ReadOnly Property PromxCabeza() As Decimal
'        Get
'            Return CantKilos / CantCabezas
'        End Get
'    End Property
'#End Region

'#Region "Metodos"
'    Public Function Obtener(ByVal Folio As String) As Boolean
'        Try
'            Return Entity.FetchUsingPK(Folio, IdRenglon, IdTipoGanado)
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'        End Try
'    End Function

'    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
'        Try
'            Dim Nuevo As Boolean = False

'            If Not Trans Is Nothing Then
'                Trans.Add(Entity)
'            Else
'                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Poliza")
'                Trans.Add(Entity)
'                Nuevo = True
'            End If

'            Entity.Delete()

'            If Nuevo Then
'                Trans.Commit()
'            End If
'            Return True
'        Catch ex As Exception
'            Trans.Rollback()
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'            Return False
'        End Try
'    End Function

'#End Region

'End Class


'Public Class ComprasGanadoDetalleCollectionClass
'    Inherits ColleccionBase(Of EC.DetRegComEntity, CC.DetRegComCollection, ComprasGanadoDetalleClass)

'    Public Shadows Sub Add(ByVal item As ComprasGanadoDetalleClass)
'        MyBase.Add(item)
'    End Sub

'    Public Shadows Sub Add(ByVal folioCompraGanado As String, ByVal renglon As Short, _
'                    ByVal idTipoGanado As Integer, ByVal cabezas As Integer, _
'                    ByVal kilos As Decimal, ByVal precioxkilo As Decimal, _
'                    ByVal kilosRecibidos As Decimal)
'        Dim det As New ComprasGanadoDetalleClass

'        det.Folio = folioCompraGanado
'        det.IdRenglon = renglon
'        det.IdTipoGanado = idTipoGanado
'        det.CantCabezas = cabezas
'        det.CantKilos = kilos
'        det.PrecioXKilo = precioxkilo
'        det.KilosRecibidos = kilosRecibidos

'        Add(det)
'    End Sub

'    Public Shadows Sub Add(ByVal compraGanado As CompraGanadoClass, ByVal renglon As Short, _
'                ByVal idTipoGanado As Integer, ByVal cabezas As Integer, _
'                ByVal kilos As Decimal, ByVal precioxkilo As Decimal, _
'                ByVal kilosRecibidos As Decimal)
'        Dim det As New ComprasGanadoDetalleClass

'        det.CompraGanado = compraGanado
'        det.IdRenglon = renglon
'        det.IdTipoGanado = idTipoGanado
'        det.CantCabezas = cabezas
'        det.CantKilos = kilos
'        det.PrecioXKilo = precioxkilo
'        det.KilosRecibidos = kilosRecibidos

'        Add(det)
'    End Sub

'End Class