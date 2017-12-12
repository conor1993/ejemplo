Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Windows.Forms

Public Class MovimientosBancosClass
    Inherits ClassBase(Of EC.MvtosBancariosCbEntity)

    Private _Cuenta As CuentaClass

#Region "Propiedades"
    Public Property NumPoliza() As Integer
        Get
            Return Entity.NumeroPol
        End Get
        Set(ByVal value As Integer)
            Entity.NumeroPol = value
        End Set
    End Property

    Public Property CtaBancaria() As Integer
        Get
            Return Entity.CtaBancar
        End Get
        Set(ByVal value As Integer)
            Entity.CtaBancar = value
        End Set
    End Property

    Public Property SaldoAnterior() As Decimal
        Get
            Return Entity.SaldoAnterior
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoAnterior = value
        End Set
    End Property

    Public Property FechaMov() As Date
        Get
            Return Entity.FecMov
        End Get
        Set(ByVal value As Date)
            Entity.FecMov = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return Entity.Referencia
        End Get
        Set(ByVal value As String)
            Entity.Referencia = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    Public Property Beneficiario() As String
        Get
            Return Entity.Benefic
        End Get
        Set(ByVal value As String)
            Entity.Benefic = value
        End Set
    End Property

    Public ReadOnly Property CuentaBancaria() As CuentaClass
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaClass(Me.CtaBancaria)
            End If
            Return _Cuenta
        End Get
    End Property

    Public ReadOnly Property Banco() As BancosClass
        Get
            Return Me.CuentaBancaria.Banco
        End Get
    End Property

    Public Property Concepto() As String
        Get
            Return Entity.Concepto
        End Get
        Set(ByVal value As String)
            Entity.Concepto = value
        End Set
    End Property

    Public Property TipoMov() As Char
        Get
            Return Entity.TipoMov(0)
        End Get
        Set(ByVal value As Char)
            Entity.TipoMov = value
        End Set
    End Property

    Public Property Cargo_Abono() As PolizaOperacionEnum
        Get
            Return CType(Asc(Entity.CarAbo), PolizaOperacionEnum)
        End Get
        Set(ByVal value As PolizaOperacionEnum)
            Entity.CarAbo = Chr(value)
        End Set
    End Property

    Public Property Origen() As Char
        Get
            Return Entity.Origen(0)
        End Get
        Set(ByVal value As Char)
            Entity.Origen = value
        End Set
    End Property

    Public Property CveCancelacion() As Char
        Get
            Return Entity.CveCancel(0)
        End Get
        Set(ByVal value As Char)
            Entity.CveCancel = value
        End Set
    End Property

    Public Property CveConciliacion() As Char
        Get
            Return Entity.CveConcil(0)
        End Get
        Set(ByVal value As Char)
            Entity.CveConcil = value
        End Set
    End Property

    Public Property CtaBancDestino() As String
        Get
            Return Entity.CtaBanDes.ToString
        End Get
        Set(ByVal value As String)
            Entity.CtaBanDes = Integer.Parse(value)
        End Set
    End Property

    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCap
        End Get
        Set(ByVal value As Date)
            Entity.FechaCap = value
        End Set
    End Property

    Public Property TipoCambio() As Decimal
        Get
            Return Entity.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            Entity.TipoCambio = value
        End Set
    End Property
#End Region

#Region "Costructores"
    Sub New()
        Entity = New EC.MvtosBancariosCbEntity
    End Sub

    Sub New(ByVal Entidad As EC.MvtosBancariosCbEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal NumPoliza As Integer, ByVal CtaBancaria As Integer)
        Entity = New EC.MvtosBancariosCbEntity(NumPoliza, CtaBancaria)
    End Sub
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal NumPoliza As Integer, ByVal CtaBancaria As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(NumPoliza, CtaBancaria)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function ModificarConciliacion(ByVal CveConciliacion As String, ByVal trans As HC.Transaction) As Boolean
        trans.Add(Entity)
        Entity.CveConcil = CveConciliacion
        Entity.Save()
    End Function

#End Region

End Class

Public Class MovimientosBancosColecctionClass
    Inherits ColleccionBase(Of EC.MvtosBancariosCbEntity, CC.MvtosBancariosCbCollection, MovimientosBancosClass)

    Public Overloads Function Obtener(ByVal IdPoliza As Integer, ByVal origen As Char, ByVal Estatus As CondicionEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Estatus = CondicionEnum.ACTIVOS Then
                Filtro.Add(HC.MvtosBancariosCbFields.NumeroPol = IdPoliza And HC.MvtosBancariosCbFields.Origen = origen)
            End If

            If Estatus = CondicionEnum.INACTIVOS Then
                Filtro.Add(HC.MvtosBancariosCbFields.Referencia = IdPoliza And HC.MvtosBancariosCbFields.Origen = origen)
            End If
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Overloads Function Obtener(ByVal idCuentaBancaria As Integer, ByVal Estatus As CondicionEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression
            If Estatus = CondicionEnum.ACTIVOS Then
                Filtro.Add(HC.MvtosBancariosCbFields.CtaBancar = idCuentaBancaria)
            End If
            If Estatus = CondicionEnum.INACTIVOS Then
                Filtro.Add(HC.MvtosBancariosCbFields.CtaBancar = idCuentaBancaria)
            End If
            If Estatus = CondicionEnum.TODOS Then
                Filtro.Add(HC.MvtosBancariosCbFields.CtaBancar = idCuentaBancaria)
            End If
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Overloads Function Obtener(ByVal idCuentaBancaria As Integer, ByVal FechaInicial As Date, ByVal FechaFinal As Date) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression
            Filtro.Add(HC.MvtosBancariosCbFields.CtaBancar = idCuentaBancaria And HC.MvtosBancariosCbFields.FechaCap > FechaInicial And HC.MvtosBancariosCbFields.FechaCap < FechaFinal)
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Overloads Function Obtener(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As Integer
        Dim Filtro As New OC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.MvtosBancariosCbFields.CtaBancar, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Filtro.Add(HC.MvtosBancariosCbFields.FecMov > FechaInicial And HC.MvtosBancariosCbFields.FecMov < FechaFinal)
        coleccion.GetMulti(Filtro, -1, Orden)
        Rellenar()
        Return Count
    End Function

    'Public Function Reporte() As RptConciliacionBancaria
    '    Dim Reportes As New RptConciliacionBancaria
    '    Dim ds As New DataSet
    '    Dim dtConciliacionBancaria As New DSetConciliacionBancaria.dtConciliacionBancariaDataTable
    '    For Each MovimientosBancos As MovimientosBancosClass In Me
    '        dtConciliacionBancaria.AdddtConciliacionBancariaRow(MovimientosBancos.Beneficiario, MovimientosBancos.Cargo_Abono.ToString, MovimientosBancos.Concepto, MovimientosBancos.CtaBancaria, MovimientosBancos.CtaBancDestino, MovimientosBancos.CveConciliacion, MovimientosBancos.FechaCaptura, MovimientosBancos.FechaMov.Date, MovimientosBancos.Importe, MovimientosBancos.NumPoliza, MovimientosBancos.Origen, MovimientosBancos.Referencia, MovimientosBancos.SaldoAnterior, MovimientosBancos.TipoCambio, MovimientosBancos.TipoMov)
    '    Next
    '    ds.Tables.Add(dtConciliacionBancaria)
    '    Reportes.SetDataSource(ds)
    '    Return Reportes
    'End Function

End Class