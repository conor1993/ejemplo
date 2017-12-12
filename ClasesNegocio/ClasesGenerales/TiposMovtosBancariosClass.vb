Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
'Public Class TiposMovtosBancariosClass


'    Inherits ClassBase(Of EC.TiposMovimientosBancariosEntity)

'#Region "Propiedades"
'    <System.ComponentModel.DisplayName("Código")> _
'       Public ReadOnly Property Codigo() As Integer
'        Get
'            Return Entity.IdMovBancario
'        End Get
'    End Property

'    <System.ComponentModel.DisplayName("Descripción")> _
'    Public Property Descripcion() As String
'        Get
'            Return Entity.Descripcion
'        End Get
'        Set(ByVal value As String)
'            Entity.Descripcion = value
'        End Set
'    End Property

'    <System.ComponentModel.DisplayName("Descripción Corta")> _
'    Public Property DescripcionCorta() As String
'        Get
'            Return Entity.DescripcionCorta
'        End Get
'        Set(ByVal value As String)
'            Entity.DescripcionCorta = value
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Observaciones")> _
'    Public Property Observaciones() As String
'        Get
'            Return Entity.Observaciones
'        End Get
'        Set(ByVal value As String)
'            Entity.Observaciones = value
'        End Set
'    End Property

'    <System.ComponentModel.DisplayName("Fecha Alta")> _
'    Public Property FechaAlta() As Date
'        Get
'            Return Entity.FechaCaptura
'        End Get
'        Set(ByVal value As Date)
'            Entity.FechaCaptura = value
'        End Set
'    End Property

'    <System.ComponentModel.DisplayName("Alta Usuario")> _
'    Public Property CodigoUsuarioAlta() As Integer
'        Get
'            Return Entity.IdUsuarioAlta
'        End Get
'        Set(ByVal value As Integer)
'            Entity.IdUsuarioAlta = value
'        End Set
'    End Property

'    <System.ComponentModel.DisplayName("Fecha Baja")> _
'    Public Property FechaBaja() As Date
'        Get
'            Return Entity.FechaBaja
'        End Get
'        Set(ByVal value As Date)
'            Entity.FechaBaja = value
'        End Set
'    End Property

'    <System.ComponentModel.DisplayName("Baja Usuario")> _
'    Public Property CodigoUsuarioBaja() As Integer
'        Get
'            Return Entity.IdUsuarioBaja
'        End Get
'        Set(ByVal value As Integer)
'            Entity.IdUsuarioBaja = value
'        End Set
'    End Property

'    <System.ComponentModel.DisplayName("Motivo Baja")> _
'    Public Property CodigoMotivoBaja() As Integer
'        Get
'            Return Entity.IdMotivoBaja
'        End Get
'        Set(ByVal value As Integer)
'            Entity.IdMotivoBaja = value
'        End Set
'    End Property

'    <System.ComponentModel.DisplayName("Estatus")> _
'    Public Property Estatus() As Integra.Clases.EstatusEnum
'        Get
'            Return Entity.Estatus
'        End Get
'        Set(ByVal value As Integra.Clases.EstatusEnum)
'            Entity.Estatus = value
'        End Set
'    End Property
'#End Region

'    Sub New()
'        'Inicializacion de Todas las variables
'        Entity = New IntegraLab.ORM.EntityClasses.TiposMovimientosBancariosEntity
'        Entity.Descripcion = ""
'        Entity.DescripcionCorta = ""
'        Entity.Observaciones = ""
'        Entity.FechaCaptura = Now
'        Entity.IdUsuarioAlta = 0
'        Entity.Estatus = Integra.Clases.EstatusEnum.ACTIVO
'        Entity.FechaBaja = New Date(1900, 1, 1)
'        Entity.IdUsuarioBaja = 0
'        Entity.IdMotivoBaja = 0
'    End Sub
'    Protected Overrides Function ValidarGuardar() As Boolean
'        Dim MovBanCol As New TiposMovimientosBancariosColeccion
'        Dim MbE As New EC.TiposMovimientosBancariosEntity
'        If Entity.IsNew Then
'            If MovBanCol.Obtener(Me) > 0 Then
'                MbE = MovBanCol.Item(0).ObtenerEntidad
'                If Entity.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
'                    MsgBox("El Tipo de Movimiento Bancario ya existe en estado Inactivo.")
'                Else
'                    MsgBox("El Tipo de Movimiento Bancario ya existe.")
'                End If
'            Else
'                Return True
'            End If
'        Else
'            If MovBanCol.Obtener(Me) > -1 Then
'                If MovBanCol.Count > 0 Then
'                    MbE = MovBanCol.Item(0).ObtenerEntidad
'                Else
'                    MbE = Entity
'                End If
'                If MbE.IdMovBancario = Me.Codigo Then
'                    Return True
'                Else
'                    MsgBox("El Tipo de Movimiento Bancario ya existe.")
'                End If
'            Else
'                MsgBox("Ha ocurrido un error al querer guardar El Tipo de Movimiento Bancario.")
'            End If
'        End If

'    End Function

'    Public Function Obtener(ByVal Codigo As Integer) As Boolean
'        Try
'            If Entity.FetchUsingPK(Codigo) Then
'                Return True
'            End If
'            MsgBox("El Tipo de Movimiento Bancario No existe.")
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'        End Try
'        Return False
'    End Function

'    Public Overrides Function ToString() As String
'        Return Me.Descripcion
'    End Function
'    Public Overrides Function Borrar(Optional ByVal Trans As IntegraLab.ORM.HelperClasses.Transaction = Nothing) As Boolean
'        Try
'            If Me.Estatus = Integra.Clases.EstatusEnum.ACTIVO Then
'                Me.Estatus = Integra.Clases.EstatusEnum.INACTIVO
'                Me.Entity.Save()
'                Return True
'            End If
'            Return False
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'        End Try
'    End Function

'End Class
'Public Class TiposMovimientosBancariosColeccion
'    Inherits ColleccionBase(Of EC.TiposMovimientosBancariosEntity, CC.TiposMovimientosBancariosCollection, TiposMovtosBancariosClass)

'    Public Function Obtener(Optional ByVal FcCondicion As CondicionEstatusEnum = CondicionEstatusEnum.TODOS) As Integer
'        Try
'            Me.ClearItems()

'            If FcCondicion = CondicionEstatusEnum.TODOS Then
'                Me.coleccion.GetMulti(Nothing)
'            Else
'                Me.coleccion.GetMulti(IntegraLab.ORM.HelperClasses.TiposMovimientosBancariosFields.Estatus = FcCondicion)
'            End If
'            Rellenar()
'            Return Count
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'            Return -1
'        End Try
'    End Function
'    Public Function Obtener(ByVal condicion As String) As Integer
'        Try
'            Me.ClearItems()
'            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
'            If condicion = "" Then
'                Me.coleccion.GetMulti(Nothing)
'            Else
'                filtro.Add(HC.TiposMovimientosBancariosFields.Descripcion Mod (String.Format("%{0}%", condicion)))
'                Me.coleccion.GetMulti(filtro)
'            End If
'            Rellenar()
'            Return Count
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'            Return -1
'        End Try
'    End Function
'    Public Function Obtener(ByVal MtoBan As TiposMovtosBancariosClass) As Integer
'        Try
'            Me.ClearItems()
'            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
'            filtro.Add(IntegraLab.ORM.HelperClasses.TiposMovimientosBancariosFields.IdMovBancario = MtoBan.Codigo)
'            filtro.AddWithOr(IntegraLab.ORM.HelperClasses.TiposMovimientosBancariosFields.DescripcionCorta = MtoBan.DescripcionCorta)
'            filtro.Add(HC.TiposMovimientosBancariosFields.Descripcion = MtoBan.Descripcion)
'            Me.coleccion.GetMulti(filtro)
'            Rellenar()
'            Return Count
'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'            Return -1
'        End Try
'    End Function
'    Public Function Reporte(ByVal Empresa As String, ByVal usuario As String, ByVal Modulo As String) As RptTiposMovtosBan
'        Dim rpt As New RptTiposMovtosBan
'        Dim ds As New DataSet
'        Dim dtTipMovB As New DSTiposMvtosBancos.DtTiposMovBanDataTable
'        Dim Emp As New DSTiposMvtosBancos.DtEmpresaDataTable
'        For Each TM As TiposMovtosBancariosClass In Me
'            dtTipMovB.AddDtTiposMovBanRow(TM.Codigo, TM.Descripcion, TM.DescripcionCorta, TM.Observaciones, TM.Estatus.ToString())
'        Next
'        Emp.AddDtEmpresaRow(Empresa, usuario, Modulo)
'        ds.Tables.Add(Emp)
'        ds.Tables.Add(dtTipMovB)
'        rpt.SetDataSource(ds)
'        Return rpt
'    End Function
'End Class
