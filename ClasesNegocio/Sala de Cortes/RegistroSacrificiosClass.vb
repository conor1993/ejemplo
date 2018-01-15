Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class RegistroSacrificiosClass
    Inherits ClassBase(Of EC.MscregistroSacrificioCabEntity)

    Dim _Func As String
    Dim _NumOpc As Integer

    Public Function Clonar() As ClasesNegocio.RegistroSacrificiosClass
        Return DirectCast(Me.MemberwiseClone(), RegistroSacrificiosClass)
    End Function

    Property IdLoteSacrificio() As String
        Get
            Return Entity.IdFolioSacrificio
        End Get
        Set(ByVal value As String)
            Entity.IdFolioSacrificio = value
        End Set
    End Property

    Public Property LoteRastro() As String
        Get
            Return Entity.IdFolioRastro
        End Get
        Set(ByVal value As String)
            Entity.IdFolioRastro = value
        End Set
    End Property

    Public Property Introductor() As Integer
        Get
            Return Entity.IdCodCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCodCliente = value
        End Set
    End Property

    Public ReadOnly Property NombreIntroductor() As String
        Get
            Dim Configuracion As New ConfiguracionProduccionClass
            Configuracion.Obtener(1)
            If Configuracion.ObtenerEntidad.RecibirCanales = True Then
                Return "LOTE PROPIO"
            Else
                Dim Int As New ClientesIntroductoresClass
                Int.Obtener(Me.Introductor)
                Return Int.Nombre
            End If
        End Get
    End Property

    Property FechaSacrificio() As Date
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

    Property CantCabezasSacrificio() As Integer
        Get
            Return Entity.CantCabSacrificio
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                RaiseEvent MensajeError(Me, "Especifique Cantidad de Cabezas a Sacrificar")
                Throw New System.SystemException(" ")
            End If
            Entity.CantCabSacrificio = value
        End Set
    End Property

    Property CantCabezasEnmantadas() As Integer
        Get
            Return Entity.CantCabMuertas
        End Get
        Set(ByVal value As Integer)
            Entity.CantCabMuertas = value
        End Set
    End Property

    Property CantCanales() As Integer
        Get
            Return Entity.CantCanales
        End Get
        Set(ByVal value As Integer)
            Entity.CantCanales = value
        End Set
    End Property

    Property KilosEnPie() As Decimal
        Get
            Return Entity.KgsEnPie
        End Get
        Set(ByVal value As Decimal)
            Entity.KgsEnPie = value
        End Set
    End Property

    Property KilosCanal() As Decimal
        Get
            Return Entity.KgsCanal
        End Get
        Set(ByVal value As Decimal)
            Entity.KgsCanal = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property

    Property ObservacionesCancelacion() As String
        Get
            Return Entity.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesCancelacion = value
        End Set
    End Property

    Property Importe() As Decimal
        Get
            Return Entity.ImporteSacrificio
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteSacrificio = value
        End Set
    End Property

    Property FolioMovAlmacen() As String
        Get
            Return Entity.FolioMovAlmacen
        End Get
        Set(ByVal value As String)
            Entity.FolioMovAlmacen = value
        End Set
    End Property

    Property IdUsuario() As Integer
        Get
            Return Entity.IdUsuario
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuario = value
        End Set
    End Property

    Property IdUsuarioCancelacion() As Integer
        Get
            Return Entity.IdUsuarioCancela
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancela = value
        End Set
    End Property

    Property Contabilizado() As String
        Get
            Return Entity.Contabilizado
        End Get
        Set(ByVal value As String)
            Entity.Contabilizado = value
        End Set
    End Property

    Property FechaContabilizacion() As Date
        Get
            Return Entity.FechaContabilizacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaContabilizacion = value
        End Set
    End Property

    Property Poliza() As String
        Get
            Return Entity.IdPoliza
        End Get
        Set(ByVal value As String)
            Entity.IdPoliza = value
        End Set
    End Property

    Property Rendimiento() As Decimal
        Get
            Return Entity.PorcientoRendimiento
        End Get
        Set(ByVal value As Decimal)
            Entity.PorcientoRendimiento = value
        End Set
    End Property

    Property Estatus() As Char
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As Char)
            Entity.Estatus = value
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

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    'Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
    '    Try
    '        'No se guardará por procedimiento
    '        'If SPA.UspRegistroSacrificiosCab(IdLoteSacrificio, FechaSacrificio, CantCabezasSacrifio, CantCabezasEnmantadas, CantCabezasClasificadas, CantCabezasSinSacrificar, KilosRecibidos, KilosSacrificio, CantCanalesSacrificio, KilosCalientes, Rendimiento, Estatus, Func, NumOpc, trans) = 0 Then
    '        '    RaiseEvent MensajeError(Me, "Error al guardar información de Registro de Sacrificio")
    '        '    Return False
    '        'End If
    '        trans.Add(Me.Entity)
    '        If Entity.Save Then
    '            Return True
    '        End If
    '        Return False
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return False
    '    End Try
    'End Function
    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            'No se guardará por procedimiento
            'If SPA.UspRegistroSacrificiosCab(IdLoteSacrificio, FechaSacrificio, CantCabezasSacrifio, CantCabezasEnmantadas, CantCabezasClasificadas, CantCabezasSinSacrificar, KilosRecibidos, KilosSacrificio, CantCanalesSacrificio, KilosCalientes, Rendimiento, Estatus, Func, NumOpc, trans) = 0 Then
            '    RaiseEvent MensajeError(Me, "Error al guardar información de Registro de Sacrificio")
            '    Return False
            'End If
            If Not IsNothing(Trans) Then
                Trans.Add(Me.Entity)
            End If

            Return Entity.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)

    Public Function Obtener(ByVal FolioSacr As String) As Boolean
        Try
            Return Entity.FetchUsingPK(FolioSacr)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    'Public Function obtener(ByVal Opcion As Integer, ByVal LoteSacrificio As String) As DataTable
    '    Try
    '        ' Dim var As Integer = SPA.UspConMscregistroSacrificio((Opcion, LoteSacrificio)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        obtener = Nothing
    '    End Try
    'End Function

    Public Sub New()
        Entity = New EC.MscregistroSacrificioCabEntity
        Entity.IdFolioSacrificio = ""
        Entity.CantCabMuertas = 0
        Entity.CantCabSacrificio = 0
        Entity.CantCanales = 0
        Entity.Estatus = "A"
        Entity.FechaSacrificio = "01/01/1900"
        Entity.KgsCanal = 0
        Entity.KgsEnPie = 0
        Entity.PorcientoRendimiento = 0
        Entity.IdFolioRastro = ""
    End Sub

    Sub New(ByVal Entidad As EC.MscregistroSacrificioCabEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal FolioSacrificio As String)
        Entity = New EC.MscregistroSacrificioCabEntity(FolioSacrificio)
    End Sub
End Class

Public Class RegistroSacrificioDetClass
    Implements IEntidad

    Dim Registro As EC.RegistroSacrificiosDetEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Property LoteSacrificio() As String
        Get
            Return Registro.LoteSacrificio
        End Get
        Set(ByVal value As String)
            Registro.LoteSacrificio = value
        End Set
    End Property
    Property FolioCanal() As String
        Get
            Return Registro.FolioCanal
        End Get
        Set(ByVal value As String)
            Registro.FolioCanal = value
        End Set
    End Property
    Property Lado() As Boolean
        Get
            Return Registro.Lado
        End Get
        Set(ByVal value As Boolean)
            Registro.Lado = value
        End Set
    End Property
    Property KilosCalientes() As Decimal
        Get
            Return Registro.KilosCalientes
        End Get
        Set(ByVal value As Decimal)
            Registro.KilosCalientes = value
        End Set
    End Property
    Property FechaCaptura() As Date
        Get
            Return Registro.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Registro.FechaCaptura = value
        End Set
    End Property
    Property KilosFrios() As Decimal
        Get
            Return Registro.KilosFrios
        End Get
        Set(ByVal value As Decimal)
            Registro.KilosFrios = value
        End Set
    End Property
    Property Rendimiento() As Decimal
        Get
            Return Registro.Rendimiento
        End Get
        Set(ByVal value As Decimal)
            Registro.Rendimiento = value
        End Set
    End Property
    Property LoteCorte() As String
        Get
            Return Registro.LoteCorte
        End Get
        Set(ByVal value As String)
            Registro.LoteCorte = value
        End Set
    End Property
    Property Estatus() As String
        Get
            Return Registro.Estatus
        End Get
        Set(ByVal value As String)
            Registro.Estatus = value
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

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspMscregistroSacrificioDet(LoteSacrificio, FolioCanal, Lado, KilosCalientes, KilosFrios, Rendimiento, Estatus, "", Func, NumOpc, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al guardar información de Registro de Canal")
                Return False
            End If
            Return True
        Catch ex As Exception
            'RaiseEvent MensajeError(Me, "Error al guardar información de Registro de Canal")
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Obtener(ByVal Opcion As Integer, ByVal LoteSacrificio As String, ByVal FolioCanal As String) As DataSet
        Try
            ' Obtener = SPR.UspConMscrecepcionCanalesDet(LoteSacrificio, FolioCanal, Opcion)
            Return Nothing
        Catch ex As Exception
            Obtener = Nothing
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Sub New()
        Registro = New EC.RegistroSacrificiosDetEntity
        Registro.LoteSacrificio = ""
        Registro.Estatus = "V"
        Registro.FechaCaptura = "01/01/1900"
        Registro.FolioCanal = ""
        Registro.KilosCalientes = "0"
        Registro.Lado = False
        Registro.LoteCorte = ""
        Registro.Rendimiento = 0
        Registro.KilosFrios = 0
    End Sub

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus1() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class
'Public Class MSCRegistroSacrificios
'    Implements IEntidad
'    Dim Registro As EC.MscregistroSacrificioCabEntity

'#Region "Propiedades"
'    Property FolioSacrificio() As String
'        Get
'            Return Registro.IdFolioSacrificio
'        End Get
'        Set(ByVal value As String)
'            Registro.IdFolioSacrificio = value
'        End Set
'    End Property
'    Property FolioRastro() As String
'        Get
'            Return Registro.IdFolioRastro
'        End Get
'        Set(ByVal value As String)
'            Registro.IdFolioRastro = value
'        End Set
'    End Property
'    Property FechaSacrificio() As Date
'        Get
'            Return Registro.FechaSacrificio
'        End Get
'        Set(ByVal value As Date)
'            Registro.FechaSacrificio = value
'        End Set
'    End Property
'    Property FechaCaptura() As Date
'        Get
'            Return Registro.FechaCaptura
'        End Get
'        Set(ByVal value As Date)
'            Registro.FechaCaptura = value
'        End Set
'    End Property

'    Property FechaCancelacion() As Date
'        Get
'            Return Registro.FechaCancelacion
'        End Get
'        Set(ByVal value As Date)
'            Registro.FechaCancelacion = value
'        End Set
'    End Property
'    Property FechaContabilizacion() As Date
'        Get
'            Return Registro.FechaContabilizacion
'        End Get
'        Set(ByVal value As Date)
'            Registro.FechaContabilizacion = value
'        End Set
'    End Property
'    Property CantCabezasMuertas() As Integer
'        Get
'            Return Registro.CantCabMuertas
'        End Get
'        Set(ByVal value As Integer)
'            Registro.CantCabMuertas = value
'        End Set
'    End Property
'    Property CantCabezasSacrificio() As Integer
'        Get
'            Return Registro.CantCabSacrificio
'        End Get
'        Set(ByVal value As Integer)
'            Registro.CantCabSacrificio = value
'        End Set
'    End Property
'    Property CantCanales() As Integer
'        Get
'            Return Registro.CantCanales
'        End Get
'        Set(ByVal value As Integer)
'            Registro.CantCanales = value
'        End Set
'    End Property
'    Property Contabilizado() As String
'        Get
'            Return Registro.Contabilizado
'        End Get
'        Set(ByVal value As String)
'            Registro.Contabilizado = value
'        End Set
'    End Property
'    Property Estatus() As String
'        Get
'            Return Registro.Estatus
'        End Get
'        Set(ByVal value As String)
'            Registro.Estatus = value
'        End Set
'    End Property
'    Property IdCliente() As Integer
'        Get
'            Return Registro.IdCodCliente
'        End Get
'        Set(ByVal value As Integer)
'            Registro.IdCodCliente = value
'        End Set
'    End Property
'    Property Poliza() As String
'        Get
'            Return Registro.IdPoliza
'        End Get
'        Set(ByVal value As String)
'            Registro.IdPoliza = value
'        End Set
'    End Property
'    Property Usuario() As Integer
'        Get
'            Return Registro.IdUsuario
'        End Get
'        Set(ByVal value As Integer)
'            Registro.IdUsuario = value
'        End Set
'    End Property
'    Property UsuarioCancela() As Integer
'        Get
'            Return Registro.IdUsuarioCancela
'        End Get
'        Set(ByVal value As Integer)
'            Registro.IdUsuarioCancela = value
'        End Set
'    End Property
'    Property Importe() As Decimal
'        Get
'            Return Registro.ImporteSacrificio
'        End Get
'        Set(ByVal value As Decimal)
'            Registro.ImporteSacrificio = value
'        End Set
'    End Property
'    Property KilosCanales() As Decimal
'        Get
'            Return Registro.KgsCanal
'        End Get
'        Set(ByVal value As Decimal)
'            Registro.KgsCanal = value
'        End Set
'    End Property
'    Property KilosEnPie() As Decimal
'        Get
'            Return Registro.KgsEnPie
'        End Get
'        Set(ByVal value As Decimal)
'            Registro.KgsEnPie = value
'        End Set
'    End Property
'    Property Observaciones() As String
'        Get
'            Return Registro.Observaciones
'        End Get
'        Set(ByVal value As String)
'            Registro.Observaciones = value
'        End Set
'    End Property
'    Property ObservacionesCancelacion() As String
'        Get
'            Return Registro.ObservacionesCancelacion
'        End Get
'        Set(ByVal value As String)
'            Registro.ObservacionesCancelacion = value
'        End Set
'    End Property
'#End Region
'#Region "Metodos"
'    Public Function Borrar() As Boolean Implements IEntidad.Borrar
'        Try
'            Registro.Estatus = EstatusDatos.CANCELADO
'            Return Registro.Save
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Return False
'        End Try
'    End Function

'    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

'    End Function

'    Public Function Guardar() As Boolean
'        Try
'            'Dim RSC As New CC.MscregistroSacrificioCabCollection
'            'If Registro.IsNew Then
'            '    If RSC.GetDbCount(HC.msc.Nombre = Nombre And HC.CatIntroductoresFields.ApellidoPaterno = ApellidoPaterno And HC.CatIntroductoresFields.ApellidoMaterno = ApellidoMaterno) > 0 Then
'            '        MessageBox.Show("Nombre de Introductor de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'            '        Return False
'            '    End If
'            'Else
'            '    If RSC.GetDbCount(Not HC.CatIntroductoresFields.IdIntroductor = IdIntroductor And HC.CatIntroductoresFields.Nombre = Nombre And HC.CatIntroductoresFields.ApellidoPaterno = ApellidoPaterno And HC.CatIntroductoresFields.ApellidoMaterno = ApellidoMaterno) > 0 Then
'            '        MessageBox.Show("Nombre de Introductor de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'            '        Return False
'            '    End If
'            'End If
'            If Registro.IsNew Then
'                Return Registro.Save
'            End If
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Return False
'        End Try

'    End Function

'    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

'    End Function

'    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

'    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

'    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

'    End Function
'    Public Function Obtener(ByVal FolioSacrificio As String, ByVal FolioRastro As String) As Boolean
'        Try
'            Return Registro.FetchUsingPK(FolioSacrificio, FolioRastro)
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'    End Function
'#End Region

'#Region "Constructores"
'    Sub New()
'        Registro = New EC.MscregistroSacrificioCabEntity
'    End Sub
'    Sub New(ByVal Entidad As EC.MscregistroSacrificioCabEntity)
'        Registro = Entidad
'    End Sub
'    Sub New(ByVal Codigo As Long)
'        Registro = New EC.MscregistroSacrificioCabEntity
'    End Sub

'#End Region

'    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

'    End Function

'    Public Property Estatus1() As EstatusEnum Implements IEntidad.Estatus
'        Get

'        End Get
'        Set(ByVal value As EstatusEnum)

'        End Set
'    End Property

'    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

'    End Function
'End Class

Public Class RegistroSacrificioColeccionClass
    Inherits ColleccionBase(Of EC.MscregistroSacrificioCabEntity, CC.MscregistroSacrificioCabCollection, RegistroSacrificiosClass)
    Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    Public Overloads Function Obtener() As Integer
        Try
            Me.Clear()
            coleccion = New CC.MscregistroSacrificioCabCollection
            coleccion.GetMulti(Nothing)
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

    Public Overloads Function Obtener(ByVal Estatus As String) As Integer
        Try
            Me.Clear()
            coleccion = New CC.MscregistroSacrificioCabCollection

            coleccion.GetMulti(HC.MscregistroSacrificioCabFields.Estatus = Estatus)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overloads Function Obtener(ByVal FechaInicio As Date, ByVal FechaFinal As Date) As Integer
        Try
            Me.Clear()
            coleccion = New CC.MscregistroSacrificioCabCollection
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(HC.MscregistroSacrificioCabFields.FechaSacrificio, FechaInicio.ToShortDateString, FechaFinal.ToShortDateString))
            coleccion.GetMulti(filtro)
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

    Public Overloads Function Obtener(ByVal LoteSacrificio As String, ByVal Introductor As Integer) As Integer
        Try
            Me.Clear()
            coleccion = New CC.MscregistroSacrificioCabCollection
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If LoteSacrificio <> "" Then
                filtro.Add(HC.MscregistroSacrificioCabFields.IdFolioSacrificio = LoteSacrificio)
            End If
            If Introductor <> 0 And Not IsNothing(Introductor) Then
                filtro.Add(HC.MscregistroSacrificioCabFields.IdCodCliente = Introductor)
            End If
            coleccion.GetMulti(filtro)
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

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String, ByVal Modulo As String) As RptRegistroSacrificio
        Try
            Dim Rep As New RptRegistroSacrificio
            Dim Ds As New DataSet
            Dim Dt As New DsRegistroSacrificio.DtRegistroSacrificioDataTable
            For Each Reg As RegistroSacrificiosClass In Me
                Dt.AddDtRegistroSacrificioRow(Reg.IdLoteSacrificio, Reg.FechaSacrificio, Reg.NombreIntroductor, Reg.CantCabezasSacrificio, Reg.KilosEnPie, Reg.CantCanales, 0, Reg.Rendimiento)
            Next
            Ds.Tables.Add(Dt)
            Rep.SetDataSource(Ds)
            Rep.SetParameterValue(0, Empresa)
            Rep.SetParameterValue(1, Usuario)
            Rep.SetParameterValue(2, Modulo)
            Return Rep
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
End Class