Imports Ec = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses


Public Class TipoMonedaClass
    Inherits ClassBase(Of Ec.TipoMonedaEntity)

#Region "Miembros"

    Dim _TiposCambio As TipoCambioCollectionClass

#End Region

#Region "Constructores"

    Sub New()
        'Inicializacion de Todas las variables
        Entity = New Ec.TipoMonedaEntity
        Entity.Descripcion = ""
        Entity.DescripcionCorta = ""
        Entity.Observaciones = ""
        Entity.FechaAlta = Now
        Entity.MonedaLocal = False
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As Ec.TipoMonedaEntity)
        Entity = Entidad
    End Sub

#End Region

#Region "Propiedades"

    <System.ComponentModel.DisplayName("Estatus")> _
        Public Property Estatus() As EstatusEnum
        Get
            Return CType(Entity.Estatus, EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = CType(value, Short)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código")> _
    Public Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescripcionCorta = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observación")> _
    Public Property Observacion() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    <ComponentModel.DisplayName("Estatus Descripcion")> _
Public ReadOnly Property EstatusDescripcion() As String
        Get
            Return Me.Estatus.ToString
        End Get
    End Property

    <System.ComponentModel.DisplayName("Moneda Local")> _
    Public Property EsMonedaLocal() As Boolean
        Get
            Return Entity.MonedaLocal
        End Get
        Set(ByVal value As Boolean)
            Entity.MonedaLocal = value
        End Set
    End Property

    Public ReadOnly Property MonedaLocal() As SiNoEnum
        Get
            If Entity.MonedaLocal Then
                Return SiNoEnum.SI
            Else
                Return SiNoEnum.NO
            End If
        End Get
    End Property

    <System.ComponentModel.DisplayName("Fecha")> _
    Public ReadOnly Property Fecha() As Date
        Get
            Return Entity.FechaAlta
        End Get
    End Property

    Public ReadOnly Property TiposCambio() As TipoCambioCollectionClass
        Get
            If _TiposCambio Is Nothing Then
                _TiposCambio = New TipoCambioCollectionClass(Me.Entity.TipoCambio)
            End If
            Return _TiposCambio
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Shadows Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Entity)
            Entity.Estatus = EstatusEnum.INACTIVO
            If Entity.Save() Then Return True
            MsgBox("El Tipo de Moneda no se pudo borrar.", MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return False
    End Function

    Public Shadows Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim TMoneda As New TipoMonedaCollectionClass
        Dim TMonedas As New Ec.TipoMonedaEntity

        TMoneda.Obtener(HC.TipoMonedaFields.MonedaLocal = 1)

        If TMoneda.Count > 0 Then
            If Entity.MonedaLocal Then
                If Entity.IsNew Then
                    MsgBox("Ya se definio una moneda local y solamente se permite una. . .", MsgBoxStyle.Exclamation)
                    Return False
                Else
                    If Entity.Codigo <> TMoneda(0).Codigo Then
                        MsgBox("Ya se definio una moneda local y solamente se permite una. . .", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                End If
            End If
        End If

        If Entity.IsNew Then
            If TMoneda.Obtener(HC.TipoMonedaFields.Descripcion Mod String.Format("%{0}%", Me.Descripcion) Or HC.TipoMonedaFields.DescripcionCorta Mod String.Format("%{0}%", Me.DescripcionCorta)) > 0 Then
                TMonedas = TMoneda.Item(0).ObtenerEntidad
                'Se le da el valor de Estatus de Tipo Monedas a la valiable est por que 
                'en la Tabla TipoMoneda en el campo estatus es posible establecerlo en nulo
                'y el LLBLGen no me deja hacer una igualacion en el if por que es Nullable
                'y puede generar un error
                If TMonedas.Estatus = EstatusEnum.INACTIVO Then
                    MsgBox("El Tipo de Moneda Ya Existe y Esta Inactivo", MsgBoxStyle.Exclamation)
                Else
                    MsgBox("El Tipo de Moneda Ya Existe . . .", MsgBoxStyle.Exclamation)
                End If
            Else
                Entity.FechaAlta = Now
                Trans.Add(Entity)
                Return Entity.Save
            End If
        Else
            If TMoneda.Obtener(HC.TipoMonedaFields.Codigo <> Me.Codigo And (HC.TipoMonedaFields.Descripcion Mod String.Format("%{0}%", Me.Descripcion) Or HC.TipoMonedaFields.DescripcionCorta Mod String.Format("%{0}%", Me.DescripcionCorta))) > 0 Then
                TMonedas = TMoneda.Item(0).ObtenerEntidad
                MsgBox(String.Format("El Tipo de Moneda {0}, {1} ya existe  . . .", Me.Descripcion, Me.DescripcionCorta), MsgBoxStyle.Exclamation)
            Else
                Trans.Add(Entity)
                Return Entity.Save
            End If
        End If
        Return False
    End Function

    Public Sub GuardarTipoCambio(ByVal nuevovalor As Decimal, ByVal fecha As Date)
        Dim TipoCambio As New Ec.TipoCambioEntity

        TipoCambio.TipomonedaId = Me.Codigo
        TipoCambio.Fecha = fecha
        TipoCambio.Tipocambio = nuevovalor
        TipoCambio.Save()
    End Sub

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            If Entity.FetchUsingPK(Codigo) Then
                Return True
            End If
            MsgBox("El Tipo de Moneda especificado no existe.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return False
    End Function

    Public Function TipoCambio(ByVal Fecha As Date) As Decimal
        Try
            If Entity.MonedaLocal Then
                Return 1D
            Else
                Dim TipoCamb As New CC.TipoCambioCollection
                TipoCamb.GetMulti(HC.TipoCambioFields.TipomonedaId = Me.Codigo And New OC.FieldBetweenPredicate(HC.TipoCambioFields.Fecha, Fecha.ToShortDateString, Fecha.AddDays(1).ToShortDateString), 1, _
                New OC.SortExpression(New OC.SortClause(HC.TipoCambioFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

                If TipoCamb.Count > 0 Then
                    Return TipoCamb(0).Tipocambio
                Else
                    MsgBox("No ha ingresado el valor de la moneda de este día", MsgBoxStyle.Information, "Aviso")
                    Return 0D
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

#End Region

End Class

Public Class TipoMonedaCollectionClass
    Inherits ColleccionBase(Of Ec.TipoMonedaEntity, CC.TipoMonedaCollection, TipoMonedaClass)

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Collection As CC.TipoMonedaCollection)
        MyBase.New(Collection)
    End Sub

#End Region

#Region "Metodos"

    Public Function Listar() As String()
        Dim lista As New List(Of String)

        For Each e As TipoMonedaClass In Me
            lista.Add(e.DescripcionCorta)
        Next
        Return lista.ToArray
    End Function

    Public Overloads Function Obtener(Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS, Optional ByVal Excluir_Moneda_Local As Boolean = False) As Integer
        Dim Filtro As New OC.PredicateExpression

        If Estatus <> CondicionEnum.TODOS Then
            Filtro.Add(HC.TipoMonedaFields.Estatus = Estatus)
        End If

        If Excluir_Moneda_Local Then
            Filtro.Add(HC.TipoMonedaFields.MonedaLocal = 0)
        End If

        Return Me.Obtener(Filtro)
    End Function

    Public Function Reporte() As CRepTipoMoneda
        Dim Reportes As New CRepTipoMoneda
        Dim ds As New DataSet
        Dim dtMon As New DSetTMoneda.TipoMonedaDataTable

        For Each Mon As TipoMonedaClass In Me
            dtMon.AddTipoMonedaRow(Mon.Codigo.ToString, Mon.Descripcion, Mon.DescripcionCorta, Mon.Observacion, Mon.Estatus.ToString())
        Next
        ds.Tables.Add(dtMon)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

#End Region

End Class