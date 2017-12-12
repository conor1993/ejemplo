Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Public Class FacturasAPagarCxP
    Inherits ClassBase(Of EC.UsrCxpfacturasApagarEntity)

    Sub New(ByVal Entity As EC.UsrCxpfacturasApagarEntity)
        Me.Entity = Entity
    End Sub
    Sub New()
        Me.Entity.IdProveedor = 0
        Me.Entity.IdUsuarioAutorizacion = 0
        Me.Entity.ImporteAbono = 0
        Me.Entity.ImporteApagar = 0
        Me.Entity.ImporteTotal = 0
        Me.Entity.NoFactura = ""
    End Sub

#Region "Propiedades"
    Public Property IdEmpresa() As Integer
        Get
            Return Entity.EmpresaId
        End Get
        Set(ByVal value As Integer)
            Entity.EmpresaId = value
        End Set
    End Property
    Public Property IdProveedor() As Integer
        Get
            Return Entity.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entity.IdProveedor = value
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
    Public Property FechaVencimiento() As Date
        Get
            Return Entity.FechaVencimiento
        End Get
        Set(ByVal value As Date)
            Entity.FechaVencimiento = value
        End Set
    End Property
    Public Property ImporteTotal() As Decimal
        Get
            Return Entity.ImporteTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteTotal = value
        End Set
    End Property
    Public Property ImporteAbono() As Decimal
        Get
            Return Entity.ImporteAbono
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteAbono = value
        End Set
    End Property
    Public Property ImporteApagar() As Decimal
        Get
            Return Entity.ImporteApagar
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteApagar = value
        End Set
    End Property
    Public Property Estatus() As EstatusFacturasApagar
        Get
            Return CType(Entity.Estatus, EstatusFacturasApagar)
        End Get
        Set(ByVal value As EstatusFacturasApagar)
            Entity.Estatus = CType(value, Short)
        End Set
    End Property
    Public Property Saldo() As Decimal
        Get
            Return Entity.Saldo
        End Get
        Set(ByVal value As Decimal)
            Entity.Saldo = value
        End Set
    End Property
    Public Property FechaProgramacion() As Date
        Get
            Return Entity.FechaProgramacion.Value
        End Get
        Set(ByVal value As Date)
            Entity.FechaProgramacion = value
        End Set
    End Property
    Public Property IdUsuarioAutorizacion() As Integer
        Get
            Return Entity.IdUsuarioAutorizacion.Value
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAutorizacion = value
        End Set
    End Property
    Public Property Autorizada() As Boolean
        Get
            If Me.Estatus = EstatusFacturasApagar.AUTORIZADA Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal value As Boolean)
            If value Then
                Me.Estatus = EstatusFacturasApagar.AUTORIZADA
            Else
                Me.Estatus = EstatusFacturasApagar.PROGRAMADA
            End If
        End Set
    End Property
#End Region

End Class
Public Class FacturasAPagarCXPColeccion
    Inherits ColleccionBase(Of EC.UsrCxpfacturasApagarEntity, CC.UsrCxpfacturasApagarCollection, FacturasAPagarCxP)

    Public Overloads Function Obtener(ByVal IdProveedor As Integer, ByVal EmpresaId As Integer) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasApagarFields.IdProveedor = IdProveedor)
            filtro.Add(HC.UsrCxpfacturasApagarFields.EmpresaId = EmpresaId)
            filtro.Add(HC.UsrCxpfacturasApagarFields.Estatus = EstatusFacturasApagar.AUTORIZADA Or HC.UsrCxpfacturasApagarFields.Estatus = EstatusFacturasApagar.PROGRAMADA)
            Me.coleccion.GetMulti(filtro)
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
    Public Overloads Function Obtener(ByVal Estatus As EstatusFacturasApagar) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasApagarFields.Estatus = Estatus)
            Me.coleccion.GetMulti(filtro)
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
    Public Overloads Function Obtener() As Integer
        Try
            Me.Clear()
            Me.coleccion.GetMulti(Nothing)
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
    ''' Metodo paraa obtener las facturas a pagar qe estén programadas y autorizadas
    ''' </summary>
    ''' <param name="IdProveedor"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal IdProveedor As String) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasApagarFields.IdProveedor = CInt(IdProveedor))
            filtro.Add(HC.UsrCxpfacturasApagarFields.Estatus = EstatusFacturasApagar.AUTORIZADA Or HC.UsrCxpfacturasApagarFields.Estatus = EstatusFacturasApagar.PROGRAMADA)
            Me.coleccion.GetMulti(filtro)
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
    Public Overloads Function Obtener(ByVal Proveedor As Integer, ByVal Nofactura As String) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasApagarFields.IdProveedor = Proveedor)
            filtro.Add(HC.UsrCxpfacturasApagarFields.NoFactura = Nofactura)
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
    Public Function Guardar() As Boolean
        Try
            If Me.coleccion.SaveMulti() > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

End Class
