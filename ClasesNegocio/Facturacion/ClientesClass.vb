Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TVC = IntegraLab.ORM.TypedViewClasses

Public Class ClientesClass
    Implements IEntidad



    'Dim Clientes As EC.MfacCatClientesEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Dim _CodCliente As Integer

#Region "Constructores"
    'Sub New()
    '    Clientes = New EC.MfacCatClientesEntity
    'End Sub

    'Sub New(ByVal Entidad As EC.MfacCatClientesEntity)
    '    Clientes = Entidad
    'End Sub

    'Sub New(ByVal Codigo As Long)
    '    Clientes = New EC.MfacCatClientesEntity(Codigo)
    'End Sub



#End Region


    'ReadOnly Property Idcliente() As Integer
    '    Get
    '        Return Clientes.IdCliente
    '    End Get
    'End Property
    'Property CodCliente() As Integer
    '    Get
    '        Return _CodCliente
    '    End Get
    '    Set(ByVal value As Integer)
    '        _CodCliente = value
    '    End Set
    'End Property
    'Property Nombre() As String
    '    Get
    '        Return Clientes.Nombre
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.Nombre = value
    '    End Set
    'End Property
    'Property CodigoPostal() As String
    '    Get
    '        Return Clientes.CodigoPostal
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.CodigoPostal = value
    '    End Set
    'End Property
    'Property Colonia() As String
    '    Get
    '        Return Clientes.Colonia
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.Colonia = value
    '    End Set
    'End Property
    'Property DiasCredito() As Integer
    '    Get
    '        Return Clientes.DiasCredito
    '    End Get
    '    Set(ByVal value As Integer)
    '        Clientes.DiasCredito = value
    '    End Set
    'End Property
    'Property DiasPago() As String
    '    Get
    '        Return Clientes.DiasPago
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.DiasPago = value
    '    End Set
    'End Property
    'Property DiasRevision() As String
    '    Get
    '        Return Clientes.DiasPago
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.DiasPago = value
    '    End Set
    'End Property
    'Property Domicilio() As String
    '    Get
    '        Return Clientes.Domicilio
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.Domicilio = value
    '    End Set
    'End Property
    'Property Estatus() As String
    '    Get
    '        Return Clientes.Estatus
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.Estatus = value
    '    End Set
    'End Property
    'Property FechaAlta() As Date
    '    Get
    '        Return Clientes.FechaAlta
    '    End Get
    '    Set(ByVal value As Date)
    '        Clientes.FechaAlta = value
    '    End Set
    'End Property
    'Property FechaCancelacion() As Date
    '    Get
    '        Return Clientes.FechaCancelacion
    '    End Get
    '    Set(ByVal value As Date)
    '        Clientes.FechaCancelacion = value
    '    End Set
    'End Property
    'Property FechaUltimaCompra() As Date
    '    Get
    '        Return Clientes.FechaUltimaCompra
    '    End Get
    '    Set(ByVal value As Date)
    '        Clientes.FechaUltimaCompra = value
    '    End Set
    'End Property
    'Property IdCiudad() As Integer
    '    Get
    '        Return Clientes.IdCiudad
    '    End Get
    '    Set(ByVal value As Integer)
    '        Clientes.IdCiudad = value
    '    End Set
    'End Property
    'Property IdEstado() As Integer
    '    Get
    '        Return Clientes.IdEstado
    '    End Get
    '    Set(ByVal value As Integer)
    '        Clientes.IdEstado = value
    '    End Set
    'End Property
    'Property IdPoblacion() As Integer
    '    Get
    '        Return Clientes.IdPoblacion
    '    End Get
    '    Set(ByVal value As Integer)
    '        Clientes.IdPoblacion = value
    '    End Set
    'End Property
    'Property ImporteUltimaCompra() As Decimal
    '    Get
    '        Return Clientes.ImporteUltimaCompra
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Clientes.ImporteUltimaCompra = value
    '    End Set
    'End Property
    'Property LimiteCredito() As Decimal
    '    Get
    '        Return Clientes.LimiteCredito
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Clientes.LimiteCredito = value
    '    End Set
    'End Property
    'Property RFC() As String
    '    Get
    '        Return Clientes.Rfc
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.Rfc = value
    '    End Set
    'End Property
    'Property Telefono() As String
    '    Get
    '        Return Clientes.Telefono
    '    End Get
    '    Set(ByVal value As String)
    '        Clientes.Telefono = value
    '    End Set
    'End Property
    'Property TipoFacturacion() As Integer
    '    Get
    '        Return Clientes.TipoFacturacion
    '    End Get
    '    Set(ByVal value As Integer)
    '        Clientes.TipoFacturacion = value
    '    End Set
    'End Property
    'Property Func() As String
    '    Get
    '        Return _Func
    '    End Get
    '    Set(ByVal value As String)
    '        _Func = value
    '    End Set
    'End Property
    'Property NumOpc() As Integer
    '    Get
    '        Return _NumOpc
    '    End Get
    '    Set(ByVal value As Integer)
    '        _NumOpc = value
    '    End Set
    'End Property
    'Public Function Borrar() As Boolean Implements IEntidad.Borrar

    'End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            'If SPA.UspMfacCatClientes(Nombre, Domicilio, Colonia, IdEstado, IdCiudad, IdPoblacion, CodigoPostal, Estatus, FechaAlta, FechaCancelacion, DiasCredito, DiasRevision, LimiteCredito, DiasPago, TipoFacturacion, FechaUltimaCompra, ImporteUltimaCompra, Telefono, "", "", Func, NumOpc, CodCliente, trans) = 0 Then
            '    RaiseEvent MensajeError(Me, "Error al guardar información del cliente")
            '    Return False
            'End If
            'trans.Add(Clientes)
            'Clientes.FetchUsingPK(CodCliente)
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "Error al guardar información del cliente")
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Function Obtener(ByVal Descripcion As String) As Boolean
        ''Try
        ''    Dim ClientesCol As New CC.MfacCatClientesCollection
        ''    ClientesCol.GetMulti(HC.MfacCatClientesFields.Nombre = Nombre)
        ''    If ClientesCol.Count = 0 Then
        ''        Return False
        ''    Else
        ''        Clientes = ClientesCol(0)
        ''        Return True
        ''    End If
        'Catch ex As Exception
        '    RaiseEvent MensajeError(Me, "Error al consultar información del cliente")
        '    Return False
        '    Return False
        'End Try
    End Function
    'Public Function ObtenerEntidad() As EC.MfacCatClientesEntity
    '    Return Clientes
    'End Function

    Public Function Guardar1() As Boolean

    End Function

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ClientesColecttionClass

    'Inherits CollectionClass(Of ClientesConsultaClass)
    'Private WithEvents Coleccion As New TVC.VwClientesTypedView

    '    Inherits CollectionClass(Of ClientesClass)
    '    Private WithEvents Coleccion As New CC.MfacCatClientesCollection

    '    Public Function Obtener() As Integer
    '        Try
    '            'Coleccion.Clear()
    '            'Coleccion.Fill(0, Nothing, True)
    '            Coleccion.GetMulti(Nothing, 0, Nothing)
    '            Rellenar()
    '            Return Count
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '            Return -1
    '        End Try
    '    End Function
    '#Region "Código de Relleno"
    '    Private Sub Rellenar()

    '        'Clear()
    '        'For Each row As TVC.VwClientesRow In Coleccion
    '        '    Add(New ClientesConsultaClass(row))
    '        'Next
    '        Clear()
    '        For Each row As EC.MfacCatClientesEntity In Coleccion
    '            Add(New ClientesClass(row))
    '        Next
    '    End Sub

    '    'Public Sub RellenarMe(ByVal Collection As CC.MfacCatClientesCollection)
    '    '    Coleccion = Collection
    '    '    Rellenar()
    '    'End Sub

    '    'Private Sub RellenarColeccion()
    '    '    Coleccion.Clear()
    '    '    For Each entc As ClientesClass In Me
    '    '        Coleccion.Add(entc.ObtenerEntidad)
    '    '    Next
    '    'End Sub

    '    'Public Function ObtenerColeccion() As CC.MfacCatClientesCollection
    '    '    RellenarColeccion()
    '    '    Return Coleccion
    '    'End Function
    '#End Region


End Class


Public Class ClientesConsultaClass
    Implements IEntidad


    Dim ClientesR As TVC.VwClientesRow


#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Row As TVC.VwClientesRow)
        ClientesR = Row
    End Sub

#End Region

    Property IdCliente() As Integer
        Get
            Return ClientesR.IdCliente
        End Get
        Set(ByVal value As Integer)
            ClientesR.IdCliente = value
        End Set
    End Property
    Property Nombre() As String
        Get
            Return ClientesR.Nombre
        End Get
        Set(ByVal value As String)
            ClientesR.Nombre = value
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class
