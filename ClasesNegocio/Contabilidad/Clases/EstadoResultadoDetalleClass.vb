Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class EstadoResultadoDetalleClass
    Inherits ClassBase(Of EC.DetEdoResEntity)

#Region "Miembros"
    Private WithEvents m_CuentaContable As CuentaContableClass
    Private WithEvents m_EstadoResultado As EstadoResultadoClass
    'Private m_Cuenta As String
    Private m_CuentaMayor As String = "0000"
    Private m_SubCuenta As String = "0000"
    Private m_SSubCuenta As String = "0000"
    Private m_SSSubCuenta As String = "0000"

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.DetEdoResEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal idEstadoResultado As String, ByVal renglon As Short)
        Entity = New EC.DetEdoResEntity(idEstadoResultado, renglon)
    End Sub
#End Region

#Region "Propiedades"
    Public Property Rubro() As String
        Get
            Return Entity.CveEdoRes
        End Get
        Set(ByVal value As String)
            Entity.CveEdoRes = value
        End Set
    End Property

    <ComponentModel.DisplayName("Estado Resultado")> _
    Public Property EstadoResultado() As EstadoResultadoClass
        Get
            If m_EstadoResultado Is Nothing Then
                m_EstadoResultado = New EstadoResultadoClass(Entity.CabEdoRes)
            ElseIf Not m_EstadoResultado.Rubro = Rubro Then
                m_EstadoResultado.Entidad = Entity.CabEdoRes
            End If

            Return m_EstadoResultado
        End Get
        Set(ByVal value As EstadoResultadoClass)
            m_EstadoResultado = value

            If value Is Nothing Then
                Entity.CabEdoRes = Nothing
            Else
                Entity.CabEdoRes = value.Entidad
            End If
        End Set
    End Property

    Public Property Renglon() As Short
        Get
            Return Entity.CveRenglon
        End Get
        Set(ByVal value As Short)
            Entity.CveRenglon = value
        End Set
    End Property

    Public Property SumaOResta() As Char
        Get
            Return Entity.StaSumaResta
        End Get
        Set(ByVal value As Char)
            If value = "+"c OrElse value = "-"c Then
                Entity.StaSumaResta = value
            Else
                MsgBox("Solo se permite los catacteres ""+"" y ""-""", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Código Cuenta Contable")> _
    Public Property IdCuentaContable() As Integer
        Get
            Return Entity.CuentaContableId
        End Get
        Set(ByVal value As Integer)
            Entity.CuentaContableId = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cuenta Contable")> _
    Public Property CuentaContable() As CuentaContableClass
        Get
            If m_CuentaContable Is Nothing Then
                m_CuentaContable = New CuentaContableClass(Entity.CuentaContable)
            ElseIf Not m_CuentaContable.Codigo = IdCuentaContable Then
                m_CuentaContable.Entidad = Entity.CuentaContable
            End If

            Return m_CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            m_CuentaContable = value

            If value Is Nothing Then
                Entity.CuentaContable = New EC.CuentaContableEntity
                InicializarCuentas()
            Else
                Entity.CuentaContable = value.Entidad
                'Me.AsigarValorCuentas()
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Saldo Mes")> _
    Public Property SaldoMes() As Decimal
        Get
            Return Entity.SaldoMes
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoMes = value
        End Set
    End Property

    <ComponentModel.DisplayName("Saldo Acumulado")> _
    Public Property SaldoAumulado() As Decimal
        Get
            Return Entity.SaldoAcum
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoAcum = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cuenta Mayor")> _
    Public Property CuentaMayor() As String
        Get
            'Me.AsigarValorCuentas()
            m_CuentaMayor = Microsoft.VisualBasic.Right("0000" & CuentaContable.CuentaMayor, 4)

            Return Me.m_CuentaMayor
        End Get
        Set(ByVal value As String)
            Me.m_CuentaMayor = Right("0000" & value, 4)

            ObtenerCuenta()
            Me.OnItemModificado()
        End Set
    End Property

    <ComponentModel.DisplayName("SubCuenta")> _
    Public Property SubCuenta() As String
        Get
            'Me.AsigarValorCuentas()
            m_SubCuenta = Microsoft.VisualBasic.Right("0000" & CuentaContable.SubCuenta, 4)

            Return m_SubCuenta
        End Get
        Set(ByVal value As String)
            m_SubCuenta = Right("0000" & value, 4)

            ObtenerCuenta()
            Me.OnItemModificado()
        End Set
    End Property

    Public Property SSubCuenta() As String
        Get
            'Me.AsigarValorCuentas()
            m_SSubCuenta = Microsoft.VisualBasic.Right("0000" & CuentaContable.SSubCuenta, 4)

            Return Me.m_SSubCuenta
        End Get
        Set(ByVal value As String)
            Me.m_SSubCuenta = Right("0000" & value, 4)

            ObtenerCuenta()
            Me.OnItemModificado()
        End Set
    End Property

    Public Property SSSubCuenta() As String
        Get
            'Me.AsigarValorCuentas()
            m_SSSubCuenta = Microsoft.VisualBasic.Right("0000" & CuentaContable.SSSubCuenta, 4)

            Return Me.m_SSSubCuenta
        End Get
        Set(ByVal value As String)
            Me.m_SSSubCuenta = Right("0000" & value, 4)

            ObtenerCuenta()
            Me.OnItemModificado()
        End Set
    End Property
#End Region

#Region "Metodos"
    Private Sub ObtenerCuenta()
        Dim col As New CC.CuentaContableCollection

        col.GetMulti(HC.CuentaContableFields.Cta = CuentaMayor And HC.CuentaContableFields.SubCta = SubCuenta And _
                    HC.CuentaContableFields.SsubCta = SSubCuenta And HC.CuentaContableFields.SssubCta = SSSubCuenta)

        If col.Count > 0 Then
            Entity.CuentaContable = col(0)
            Me.m_CuentaContable = New CuentaContableClass(Entity.CuentaContable)

            If col(0).BooResultad Then
                Dim detedo As New CC.DetEdoResCollection

                If detedo.GetDbCount(HC.DetEdoResFields.CuentaContableId = col(0).Codigo) > 0 Then
                    MsgBox("La cuenta ya esta en otro estado de resultado", MsgBoxStyle.Exclamation, "Aviso")
                    Me.CuentaContable = Nothing
                    Me.InicializarCuentas()
                Else
                    Me.Seleccionado = True
                End If
            Else
                Me.Seleccionado = False
            End If
        Else
            Me.CuentaContable = Nothing
            Me.InicializarCuentas()
            Me.Seleccionado = False
        End If
    End Sub

    Private Sub InicializarCuentas()
        m_CuentaMayor = "0000"
        m_SubCuenta = "0000"
        m_SSubCuenta = "0000"
        m_SSSubCuenta = "0000"
    End Sub

    Private Sub AsigarValorCuentas()
        m_CuentaMayor = CuentaContable.CuentaMayor.ToString("0000")
        m_SubCuenta = CuentaContable.SubCuenta.ToString("0000")
        m_SSubCuenta = CuentaContable.SSubCuenta.ToString("0000")
        m_SSSubCuenta = CuentaContable.SSSubCuenta.ToString("0000")
    End Sub
#End Region

#Region "Eventos"

#End Region
End Class