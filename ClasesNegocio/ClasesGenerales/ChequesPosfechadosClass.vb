Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Public Class ChequesPosfechadosClass
    Inherits ClassBase(Of EC.ChequesPosEntity)
    Dim _Cliente As ClientesIntroductoresClass
    Private _Banco As BancosClass
#Region "Propiedades"

    Public Property IdCliente() As Integer
        Get
            Return Entity.CveCliente
        End Get
        Set(ByVal value As Integer)
            Entity.CveCliente = value
        End Set
    End Property

    Public ReadOnly Property NomCliente() As String
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(Entity.MfacCatClientes)
            End If
            Return _Cliente.Nombre
        End Get
    End Property

    Public Property NumeroCheque() As String
        Get
            Return Entity.NumCheque
        End Get
        Set(ByVal value As String)
            Entity.NumCheque = value
        End Set
    End Property

    Public Property FechaCaptura() As Date
        Get
            Return Entity.FecCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FecCaptura = value
        End Set
    End Property

    Public Property IdBanco() As Integer
        Get
            Return Entity.CveBanCte
        End Get
        Set(ByVal value As Integer)
            Entity.CveBanCte = value
        End Set
    End Property

    'Public Property Banco() As BancosClass
    '    Get
    '        If _Banco Is Nothing Then
    '            _Banco = New BancosClass(Entity.Bancos)
    '        End If
    '        Return _Banco
    '    End Get
    '    Set(ByVal value As BancosClass)
    '        _Banco = value
    '        If value Is Nothing Then
    '            Entity.Bancos = Nothing
    '        Else
    '            Entity.Bancos = value.ObtenerEntidad
    '        End If
    '    End Set
    'End Property

    Public ReadOnly Property NomBanco() As String
        Get
            If _Banco Is Nothing Then
                _Banco = New BancosClass(Entity.Bancos)
            End If
            Return _Banco.Descripcion
        End Get
    End Property

    Public Property Importe() As Decimal
        Get
            Return Entity.ImpteCheque
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteCheque = value
        End Set
    End Property

    Public Property FechaCobro() As Date
        Get
            Return Entity.FecCobro
        End Get
        Set(ByVal value As Date)
            Entity.FecCobro = value
        End Set
    End Property

    Public Property FolioCobro() As String
        Get
            Return Entity.FolCobro
        End Get
        Set(ByVal value As String)
            Entity.FolCobro = value
        End Set
    End Property

    Public Property IdUsuario() As Integer
        Get
            Return Entity.CveUser
        End Get
        Set(ByVal value As Integer)
            Entity.CveUser = value
        End Set
    End Property

    Public Property Estatus() As EstatusChar
        Get
            Return Asc(Entity.Estatus)
        End Get
        Set(ByVal value As EstatusChar)
            Entity.Estatus = Chr(value)
        End Set
    End Property

    Public Property Aplicar() As Boolean
        Get
            Return Entity.BooAplicar
        End Get
        Set(ByVal value As Boolean)
            Entity.BooAplicar = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Sub New()
        Me.Entity = New EC.ChequesPosEntity
    End Sub
    Sub New(ByVal Entidad As EC.ChequesPosEntity)
        Me.Entity = Entidad
    End Sub
    Sub New(ByVal IdCliente As Integer)
        Me.Entity = New EC.ChequesPosEntity(IdCliente, NumeroCheque)
    End Sub
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal IdCliente As Integer, ByVal NumeroCheque As String) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(IdCliente, NumeroCheque)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim Coleccion As New CC.ChequesPosCollection
            If Coleccion.GetDbCount(HC.ChequesPosFields.CveCliente = IdCliente And HC.ChequesPosFields.NumCheque = NumeroCheque) > 0 Then
                MsgBox("Ya existe un cheque registrado, con este folio, Ingrese otro..", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            Return MyBase.Guardar(Trans)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim Coleccion As New CC.ChequesPosCollection
            If Coleccion.GetDbCount(HC.ChequesPosFields.CveCliente = IdCliente And HC.ChequesPosFields.NumCheque = NumeroCheque And HC.ChequesPosFields.Estatus = EstatusChar.CANCELADO) > 0 Then
                MsgBox("Este cheque no se puede cancelar, ya que se cancelo anteriormente..", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            If Coleccion.GetDbCount(HC.ChequesPosFields.CveCliente = IdCliente And HC.ChequesPosFields.NumCheque = NumeroCheque And HC.ChequesPosFields.BooAplicar = True) > 0 Then
                MsgBox("Este cheque no se puede cancelar, ya que se aplico a una factura..", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            Return MyBase.Guardar(Trans)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
#End Region


End Class

Public Class ChequesPosfechadosCollectionClass
    Inherits ColleccionBase(Of EC.ChequesPosEntity, CC.ChequesPosCollection, ChequesPosfechadosClass)

    Public Overloads Function Obtener(Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression
            If Not Estatus = EstatusChar.TODOS Then
                Filtro.Add(HC.ChequesPosFields.Estatus = Estatus)
            End If

            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return -1
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As RptChequesPostFechados
        Dim Reportes As New RptChequesPostFechados
        Try
            Dim Ds As New DataSet
            Dim Datos As New DsChequesPostFechados.ChequesDataTable
            Dim Aplica As String
            For Each Cheque As ChequesPosfechadosClass In Me
                If Cheque.Aplicar = True Then
                    Aplica = "SI"
                Else
                    Aplica = "NO"
                End If
                Datos.AddChequesRow(Cheque.IdCliente, Cheque.NumeroCheque, Cheque.FechaCaptura, Cheque.IdBanco, Cheque.Importe.ToString("C2"), Cheque.FechaCobro, Cheque.FolioCobro, Cheque.Estatus.ToString, _
                      Aplica, Cheque.NomCliente, Cheque.NomBanco)
            Next

            Ds.Tables.Add(Datos)
            Reportes.SetDataSource(Ds)
            Reportes.SetParameterValue(0, Empresa)
            Reportes.SetParameterValue(1, Usuario)
            Reportes.SetParameterValue(2, "Cuentas X Cobrar/Cheques Postfechados")

            Return Reportes
        Catch ex As Exception
            Return Reportes
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

End Class
Public Class ChColeccion
    Inherits ColleccionBase(Of EC.MfacCatClientesEntity, CC.MfacCatClientesCollection, ClientesIntroductoresClass)

    Public Overloads Function Obtener(ByVal Estatus As EstatusChar) As String
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.ChequesPosFields.CveCliente, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not Estatus = EstatusChar.TODOS Then
                Filtro.Add(HC.ChequesPosFields.Estatus = Estatus)
            End If
            coleccion.GetMulti(Filtro, 0, Orden)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return -1
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
    'Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As RptABCClientes
    '    Dim Report As New RptABCClientes
    '    Dim ds As New DataSet
    '    Dim Tabla As New DsClientes.ClientesDataTable
    '    For Each Cliente As CN.ClientesIntroductoresClass In Me
    '        Tabla.AddClientesRow(Cliente.Codigo, Cliente.Nombre, Cliente.RFC, Cliente.Domicilio, Cliente.Estatus.ToString)
    '    Next
    '    ds.Tables.Add(Tabla)
    '    Report.SetDataSource(ds)
    '    Report.SetParameterValue(0, Empresa)
    '    Report.SetParameterValue(1, Usuario)
    '    Report.SetParameterValue(2, "Ventas/Alta de Clientes")

    '    Return Report
    'End Function
End Class
