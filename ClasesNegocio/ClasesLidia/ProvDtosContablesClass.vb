Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProvDtosContablesClass
    Implements IEntidad


    Private Proveedores As New EC.ProveedorEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        ' Inicialización de las variables para Datos contables
        'ProveedorDtosContables = New EC.ProveedoresControlContableEntity
        'ProveedorDtosContables.PrCcctaMay = ""
        'ProveedorDtosContables.PrCcdescripcion = ""
        'ProveedorDtosContables.PrCcidProveedor = 0
        'ProveedorDtosContables.PrCcidCodigo = 0
        'ProveedorDtosContables.PrCcssbCta = ""
        'ProveedorDtosContables.PrCcsssCta = ""
        'ProveedorDtosContables.PrCcsubCta = ""
    End Sub

    'Public Property Proveedor() As Integer
    '    Get
    '        Return ProveedorDtosContables.PrCcidProveedor
    '    End Get
    '    Set(ByVal value As Integer)
    '        ProveedorDtosContables.PrCcidProveedor = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public ReadOnly Property Codigo() As Integer
    '    Get
    '        Return ProveedorDtosContables.PrCcidCodigo
    '    End Get
    '    '    'Set(ByVal value As Integer)
    '    '    ProveedorDtosContables.PrCcidCodigo = value
    '    '    RaiseEvent Modificado(Me, New EventArgs)
    '    'End Set
    'End Property

    'Public Property Descripcion() As Integer
    '    Get
    '        Return ProveedorDtosContables.PrCcdescripcion
    '    End Get
    '    Set(ByVal value As Integer)
    '        ProveedorDtosContables.PrCcdescripcion = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property CtaMay() As String
    '    Get
    '        Return ProveedorDtosContables.PrCcctaMay
    '    End Get
    '    Set(ByVal value As String)
    '        ProveedorDtosContables.PrCcctaMay = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property SubCta() As String
    '    Get
    '        Return ProveedorDtosContables.PrCcsubCta
    '    End Get
    '    Set(ByVal value As String)
    '        ProveedorDtosContables.PrCcsubCta = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property SsCta() As String
    '    Get
    '        Return ProveedorDtosContables.PrCcssbCta
    '    End Get
    '    Set(ByVal value As String)
    '        ProveedorDtosContables.PrCcssbCta = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    'Public Property SssCta() As String
    '    Get
    '        Return ProveedorDtosContables.PrCcsssCta
    '    End Get
    '    Set(ByVal value As String)
    '        ProveedorDtosContables.PrCcsssCta = value
    '        RaiseEvent Modificado(Me, New EventArgs)
    '    End Set
    'End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Proveedores.Estatus = EstatusEnum.INACTIVO
            If Proveedores.Save() Then Return True
            RaiseEvent MensajeError(Me, "El Proveedor no se pudo borrar.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Guardar() As Boolean
        'Try
        '    If ProveedorDtosContables.Save Then Return True
        '    RaiseEvent MensajeError(Me, "El Proveedor no se pudo guardar.")
        'Catch ex As Exception
        '    RaiseEvent MensajeError(Me, ex.Message)
        'End Try
        'Return False
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        'Try
        '    If ProveedorDtosContables.FetchUsingPK(Codigo, Proveedor) Then
        '        RaiseEvent Modificado(Me, New EventArgs)
        '        Return True
        '    End If
        '    RaiseEvent MensajeError(Me, "La Cuenta especificada no existe.")
        'Catch ex As Exception
        '    RaiseEvent MensajeError(Me, ex.Message)
        'End Try
        'Return False
    End Function

    'Public Function ObtenerEntidad() As EC.ProveedoresControlContableEntity
    '    Return Me.ProveedorDtosContables
    'End Function

    'Public Sub LeerEntidad(ByVal Entidad As EC.ProveedoresControlContableEntity)
    '    ProveedorDtosContables = Entidad
    'End Sub

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ProvDtosContablesCollectionClass
    Inherits CollectionClass(Of ProvDtosContablesClass)

    'Private ProveedorColection As New CC.ProveedoresControlContableCollection

    'Public Sub AgregarDatos(ByVal ProvDtosContables As ProvDtosContablesClass)
    '    If Me.IndexOf(ProvDtosContables) > 0 Then
    '        Me.Item(Me.IndexOf(ProvDtosContables)) = ProvDtosContables
    '    Else
    '        Me.Add(ProvDtosContables)
    '    End If
    'End Sub

    'Public Function Obtener(ByVal Proveedor As ProveedorClass) As ProvDtosContablesCollectionClass
    '    ProveedorColection.Clear()
    '    Dim ProveedorEntity As EC.ProveedoresEntity = Proveedor.ObtenerEntidad(0)
    '    ProveedorColection = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
    '    For Each ProveedoresEntity As EC.ProveedoresControlContableEntity In ProveedorColection
    '        Dim Proveedores As New ProvDtosContablesClass
    '        Proveedores.LeerEntidad(ProveedoresEntity)
    '        Me.Add(Proveedores)
    '    Next
    '    Return Me
    'End Function

    Public Sub Obtener()
        'ProveedorColection.Clear()
        'Dim ProveedorEntity As EC.ProveedoresEntity = Proveedor.ObtenerEntidad(0)
        'ProveedorColection = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
        'For Each ProveedoresEntity As EC.ProveedoresControlContableEntity In ProveedorColection
        '    Dim Proveedores As New ProvDtosContablesClass
        '    Proveedores.LeerEntidad(ProveedoresEntity)
        '    Me.Add(Proveedores)
        'Next
    End Sub


    'Public Function ObtenerEntidad() As CC.ProveedoresControlContableCollection
    '    Return ProveedorColection
    'End Function

End Class