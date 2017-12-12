Imports CN = ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class PagosProveedoresClass
    Inherits CN.ClassBase(Of EC.UsrCxppagosProveedoresEntity)

    Sub New()

    End Sub

#Region "Propiedades"
    Public Property Proveedor() As ProveedorClass
        Get
            Dim P As New ProveedorClass(Entity.Proveedor)
            Return P
        End Get
        Set(ByVal value As ProveedorClass)
            'ojo
            Entity.IdProveedor = value.Codigo
        End Set
    End Property
    Public Property NoFactura() As String
        Get
            Return Entity.NoFactura
        End Get
        Set(ByVal value As String)
            Entity.NoFactura = value
        End Set
    End Property

    Public Property IdPoliza() As Integer
        Get
            Return Entity.PolizaId
        End Get
        Set(ByVal value As Integer)
            Entity.PolizaId = value
        End Set
    End Property
    Public Property Cheque() As String
        Get
            Return Entity.Cheque
        End Get
        Set(ByVal value As String)
            Entity.Cheque = value
        End Set
    End Property

    Public Property NoRemision() As String
        Get
            Return Entity.NoRemision
        End Get
        Set(ByVal value As String)
            Entity.NoRemision = value
        End Set
    End Property
    Public Property IdConcepto() As Integer
        Get
            Return Entity.IdConcepto
        End Get
        Set(ByVal value As Integer)
            Entity.IdConcepto = value
        End Set
    End Property
    Public ReadOnly Property ImporteCheque() As Decimal
        Get
            Dim Che As New CN.ChequeCollectionClass
            Che.Obtener(Me.Cheque, Poliza.NumeroPoliza, Poliza.Importe)
            Return Che(0).Importe
        End Get
    End Property

    Public Property Referencia() As String
        Get
            Return Entity.Referencia
        End Get
        Set(ByVal value As String)
            Entity.Referencia = value
        End Set
    End Property
    Public Property Poliza() As CN.PolizaClass
        Get
            Dim Pol As New PolizaClass(Entity.Poliza)
            Return Pol
        End Get
        Set(ByVal value As CN.PolizaClass)
            Entity.Poliza = value.ObtenerEntidad
        End Set
    End Property
    Public ReadOnly Property FolioPoliza() As String
        Get
            Return Me.Poliza.NumeroPoliza
        End Get
    End Property

    Public Property FechaPago() As Date
        Get
            Return Entity.FechaPago
        End Get
        Set(ByVal value As Date)
            Entity.FechaPago = value
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
    Public Property CuentaBancaria() As CN.CuentaClass
        Get
            Dim CtaBan As New CuentaClass(Entity.Cuenta)
            Return CtaBan
        End Get
        Set(ByVal value As CN.CuentaClass)
            Entity.Cuenta = value.ObtenerEntidad
        End Set
    End Property
    Public ReadOnly Property CuentaBancariaFolio() As String
        Get
            Return Me.CuentaBancaria.Cuenta
        End Get
    End Property

    Public Property Estatus() As CN.EstatusPagosProveedoresEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As CN.EstatusPagosProveedoresEnum)
            Entity.Estatus = value
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
    Public Property PolizaIdCancelacion() As Integer
        Get
            Return Entity.PolizaIdCancelacion
        End Get
        Set(ByVal value As Integer)
            Entity.PolizaIdCancelacion = value
        End Set
    End Property
    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAlta = value
        End Set
    End Property
    Public Property IdUsuarioCancelacion() As Integer
        Get
            Return Entity.IdUsuarioCancela
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancela = value
        End Set
    End Property

#End Region

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Me.Estatus = CN.EstatusPagosProveedoresEnum.VIGENTE Then
                Entity.Estatus = CN.EstatusPagosProveedoresEnum.CANCELADO
                Entity.FechaCancelacion = Now.ToShortDateString
            End If
            If Not IsNothing(Trans) Then
                Trans.Add(Entity)
            End If
            Return Entity.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

End Class

Public Class PagosProveedoresColeccionClass
    Inherits ColleccionBase(Of EC.UsrCxppagosProveedoresEntity, CC.UsrCxppagosProveedoresCollection, PagosProveedoresClass)
    Dim Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

#Region "Metodos"
    Public Function Obtener() As Integer
        Me.Clear()
        coleccion.GetMulti(Nothing)
        Rellenar()
        Return Me.Count
    End Function
    Public Function Obtener(ByVal Estatus As EstatusPagosProveedoresEnum, Optional ByVal IdProveedor As Integer = Nothing) As Integer
        Try
            Me.Clear()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Not IsNothing(IdProveedor) Then
                Filtro.Add(HC.UsrCxppagosProveedoresFields.IdProveedor = IdProveedor)
            End If
            Filtro.Add(HC.UsrCxppagosProveedoresFields.Estatus = Estatus)
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal Cheque As String) As Integer
        Try
            Me.Clear()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.UsrCxppagosProveedoresFields.Cheque = Cheque)
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
    ''' <summary>
    ''' Obtiene los pagos filtrado por los parametros, el ultimo parametro si es true no trae lo pagos cancelados, de lo contrario trae todos cancelados o no
    ''' </summary>
    ''' <param name="IdProveedor"></param>
    ''' <param name="NoFactura"></param>
    ''' <param name="EmpresaId"></param>
    ''' <param name="PagoNoCancelado"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal IdProveedor As Integer, ByVal NoFactura As String, ByVal EmpresaId As Integer, Optional ByVal PagoNoCancelado As Boolean = False) As PagosProveedoresClass
        Try
            Me.Clear()
            coleccion = New CC.UsrCxppagosProveedoresCollection
            Dim exp As New OC.Expression(HC.UsrCxppagosProveedoresFields.FechaPago)
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.UsrCxppagosProveedoresFields.IdProveedor = IdProveedor)
            'If Not NoFactura.Equals("") Then
            Filtro.Add(HC.UsrCxppagosProveedoresFields.NoFactura = NoFactura)
            'End If
            Filtro.Add(HC.UsrCxppagosProveedoresFields.EmpresaId = EmpresaId)
            If PagoNoCancelado Then
                Filtro.Add(HC.UsrCxppagosProveedoresFields.PolizaIdCancelacion = Nothing)
            End If
            Filtro.Add(HC.UsrCxppagosProveedoresFields.FechaPago = _
                    coleccion.GetScalar(Integralab.ORM.UsrCxppagosProveedoresFieldIndex.FechaPago, _
                    exp, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max, Filtro))
            coleccion.GetMulti(Filtro)
            Rellenar()
            If Me.Count = 1 Then
                Return Me(0)
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal IdProveedor As Integer, ByVal NoFactura As String, ByVal EmpresaId As Integer, ByVal Anio As Integer) As integer
        Try
            Me.Clear()
            coleccion = New CC.UsrCxppagosProveedoresCollection
            Dim exp As New OC.Expression(HC.UsrCxppagosProveedoresFields.FechaPago)
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.UsrCxppagosProveedoresFields.IdProveedor = IdProveedor)
            If Not NoFactura.Equals("") Then
                Filtro.Add(HC.UsrCxppagosProveedoresFields.NoFactura = NoFactura)
            End If
            Filtro.Add(HC.UsrCxppagosProveedoresFields.EmpresaId = EmpresaId)

            Dim datei As New Date(Anio, 1, 1, 0, 0, 0)
            Dim datef As New Date(Anio, 12, 31, 23, 59, 59)
            Filtro.Add(HC.UsrCxppagosProveedoresFields.FechaPago >= datei And HC.UsrCxppagosProveedoresFields.FechaPago <= datef)
            'If PagoNoCancelado Then
            '    Filtro.Add(HC.UsrCxppagosProveedoresFields.PolizaIdCancelacion = Nothing)
            'End If
            Filtro.Add(HC.UsrCxppagosProveedoresFields.FechaPago = _
                    coleccion.GetScalar(Integralab.ORM.UsrCxppagosProveedoresFieldIndex.FechaPago, _
                    exp, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max, Filtro))
            coleccion.GetMulti(Filtro)
            Rellenar()
            Return coleccion.Count
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal IdProveedor As Integer, ByVal NoRemision As String, ByVal EmpresaId As Integer, ByVal tipo As String) As PagosProveedoresClass
        Try
            Me.Clear()
            coleccion = New CC.UsrCxppagosProveedoresCollection
            Dim exp As New OC.Expression(HC.UsrCxppagosProveedoresFields.FechaPago)
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.UsrCxppagosProveedoresFields.IdProveedor = IdProveedor)
            Filtro.Add(HC.UsrCxppagosProveedoresFields.NoRemision = NoRemision)
            Filtro.Add(HC.UsrCxppagosProveedoresFields.EmpresaId = EmpresaId)

            Filtro.Add(HC.UsrCxppagosProveedoresFields.FechaPago = _
                    coleccion.GetScalar(Integralab.ORM.UsrCxppagosProveedoresFieldIndex.FechaPago, _
                    exp, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max, Filtro))
            coleccion.GetMulti(Filtro)
            Rellenar()
            If Me.Count = 1 Then
                Return Me(0)
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal IdProveedor As Integer, ByVal IdRecepCompra As Integer, ByVal EmpresaId As Integer, ByVal tipo As String) As PagosProveedoresClass
        Try
            Me.Clear()
            coleccion = New CC.UsrCxppagosProveedoresCollection
            Dim exp As New OC.Expression(HC.UsrCxppagosProveedoresFields.FechaPago)
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.UsrCxppagosProveedoresFields.IdProveedor = IdProveedor)
            ' Filtro.Add(HC.UsrCxppagosProveedoresFields.NoRemision = NoRemision)
            Filtro.Add(HC.UsrCxppagosProveedoresFields.EmpresaId = EmpresaId)

            Filtro.Add(HC.UsrCxppagosProveedoresFields.FechaPago = _
                    coleccion.GetScalar(Integralab.ORM.UsrCxppagosProveedoresFieldIndex.FechaPago, _
                    exp, SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max, Filtro))
            coleccion.GetMulti(Filtro)
            Rellenar()
            If Me.Count = 1 Then
                Return Me(0)
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal IdProveedor As Integer) As DataTable
        Try
            Me.Clear()
            Filtro = New OC.PredicateExpression
            Dim Group As New OC.GroupByCollection
            Dim rel As New OC.RelationCollection
            Dim campos As New HC.ResultsetFields(5)
            Dim Dt As New DataTable
            Dim TV As New Integralab.ORM.DaoClasses.TypedListDAO
            campos.DefineField(HC.UsrCxppagosProveedoresFields.Cheque, 0, "Cheque")
            campos.DefineField(HC.CuentaFields.Cuenta, 1, "Cuenta")
            campos.DefineField(HC.UsrCxppagosProveedoresFields.FechaPago, 2, "FechaPago")
            campos.DefineField(HC.PolizaFields.NumeroPoliza, 3, "Poliza")
            campos.DefineField(HC.PolizaFields.Importe, 4, "Importe")

            rel.Add(EC.UsrCxppagosProveedoresEntity.Relations.CuentaEntityUsingCuentaBancariaId, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            rel.Add(EC.UsrCxppagosProveedoresEntity.Relations.PolizaEntityUsingPolizaId, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

            Group.Add(HC.UsrCxppagosProveedoresFields.Cheque)
            Group.Add(HC.UsrCxppagosProveedoresFields.FechaPago)
            Group.Add(HC.PolizaFields.Importe)
            Group.Add(HC.CuentaFields.Cuenta)
            Group.Add(HC.PolizaFields.NumeroPoliza)

            Filtro.Add(HC.UsrCxppagosProveedoresFields.IdProveedor = IdProveedor)

            TV.GetMultiAsDataTable(campos, Dt, 0, Nothing, Filtro, rel, True, Group, Nothing, 0, 0)
            Return Dt
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
#End Region
End Class
