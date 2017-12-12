Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class ClienteCuentasClass
    Implements IEntidad



    'Private cliente As New EC.ClienteEntity
    'Private ClienteCuentas As New EC.ClienteControlContableEnti
    'Private ClienteCuentasCol As New CC.ClienteControlContableCollection



    'Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    'Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    'Sub New()
    '    AddHandler Modificado, AddressOf FueModificado
    '    ' Inicialización de las variables para Datos contables
    '    'ClienteCuentas = New EC.ClienteControlContableEntity
    '    ClienteCuentas.CccctaMay = ""
    '    ClienteCuentas.Cccdescripcion = ""
    '    ClienteCuentas.CccidCliente = 0
    '    'ClienteCuentas.CccidCodigo = 0
    '    ClienteCuentas.CccssbCta = ""
    '    ClienteCuentas.CccsssCta = ""
    '    ClienteCuentas.CccsubCta = ""
    'End Sub

    'Public Function Borrar() As Boolean Implements IEntidad.Borrar
    '    Try
    '        cliente.Clestatus = EstatusEnum.Inactivo
    '        If cliente.Save() Then Return True
    '        RaiseEvent MensajeError(Me, "La Cuenta no se pudo borrar.")
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, ex.Message)
    '    End Try
    '    Return False
    'End Function

    'Public Function Guardar() As Boolean 
    '    Try
    '        If ClienteCuentas.Save Then Return True
    '        RaiseEvent MensajeError(Me, "La Cuenta no se pudo guardar.")
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, ex.Message)
    '    End Try
    '    Return False
    'End Function

    'Public Function ObtenerDtosCta() As Boolean
    '    Return Me.ObtenerDtosCta
    'End Function

    'Public Function ObtenerEntidad() As EC.ClienteControlContableEntity
    '    Return Me.ClienteCuentas
    'End Function

    'Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    'End Sub

    'Public Sub LeerEntidad(ByVal Entidad As EC.ClienteControlContableEntity)
    '    ClienteCuentas = Entidad
    'End Sub

    'Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
    '    Try
    '        If ClienteCuentas.FetchUsingPK(Codigo, Cuenta) Then
    '            RaiseEvent Modificado(Me, New EventArgs)
    '            Return True
    '        End If
    '        RaiseEvent MensajeError(Me, "La Cuenta especificada no existe.")
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, ex.Message)
    '    End Try
    '    Return False
    'End Function

    'Public Property Cuenta() As Integer
    '    Get
    '        Return ClienteCuentas.CccidCodigo
    '    End Get
    '    Set(ByVal value As Integer)
    '        ClienteCuentas.CccidCodigo = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property Codigo() As Integer
    '    Get
    '        Return ClienteCuentas.CccidCliente
    '    End Get
    '    Set(ByVal value As Integer)
    '        ClienteCuentas.CccidCliente = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property Descripcion() As String
    '    Get
    '        Return ClienteCuentas.Cccdescripcion
    '    End Get
    '    Set(ByVal value As String)
    '        ClienteCuentas.Cccdescripcion = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property SubCta() As String
    '    Get
    '        Return ClienteCuentas.CccsubCta
    '    End Get
    '    Set(ByVal value As String)
    '        ClienteCuentas.CccsubCta = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property SssCta() As String
    '    Get
    '        Return ClienteCuentas.CccsssCta
    '    End Get
    '    Set(ByVal value As String)
    '        ClienteCuentas.CccsssCta = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property SsbCta() As String
    '    Get
    '        Return ClienteCuentas.CccssbCta
    '    End Get
    '    Set(ByVal value As String)
    '        ClienteCuentas.CccssbCta = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property CtaMay() As String
    '    Get
    '        Return ClienteCuentas.CccctaMay
    '    End Get
    '    Set(ByVal value As String)
    '        ClienteCuentas.CccctaMay = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
    '    Get
    '        Return cliente.Clestatus
    '    End Get
    '    Set(ByVal value As EstatusEnum)
    '        cliente.Clestatus = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar() As Boolean

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ClienteCuentasCollectionClass
    Inherits System.ComponentModel.BindingList(Of ClienteCuentasClass)
    'Private ClienteCuentaCol As New CC.ClienteControlContableCollection

    'Public Sub AgregarDatos(ByVal cuenta As ClienteCuentasClass)
    '    If Me.IndexOf(cuenta) > 0 Then
    '        Me.Item(Me.IndexOf(cuenta)) = cuenta
    '    Else
    '        Me.Add(cuenta)
    '    End If
    'End Sub

    'Public Function Obtener(ByVal Cliente As ClienteClass) As ClienteCuentasCollectionClass
    '    ClienteCuentaCol.Clear()
    '    Dim ClienteEntity As EC.ClienteEntity = Cliente.ObtenerEntidad(0)
    '    ClienteCuentaCol = ClienteEntity.GetMultiMcatVtasClientesControlContable(True)
    '    For Each CuentaEntity As EC.ClienteControlContableEntity In ClienteCuentaCol
    '        Dim Cuenta As New ClienteCuentasClass
    '        Cuenta.LeerEntidad(CuentaEntity)
    '        Me.Add(Cuenta)
    '    Next
    '    Return Me
    'End Function

    'Public Function ObtenerEntidad() As CC.ClienteControlContableCollection
    '    Return ClienteCuentaCol
    'End Function

End Class

