Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProvAvanzadoClass
    Implements IEntidad

    Private Proveedor As New EC.ProveedorEntity
    Private ProvAvanzado As New EC.ProveedorAvanzadoEntity
    Private ProvAvanzadoCol As New CC.ProveedorAvanzadoCollection

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicialización de las variables para Da0tos contables
        ProvAvanzado = New EC.ProveedorAvanzadoEntity
        ProvAvanzado.Email = ""
        ProvAvanzado.PrioridadPago = PPagoEnum.NO
        ProvAvanzado.Web = ""
        ProvAvanzado.CodigoTipoProveedor = 0
        ProvAvanzado.DiaRevision = 0
        ProvAvanzado.DiaPago = 0
        ProvAvanzado.Telefono1 = ""
        ProvAvanzado.LadaTel1 = ""
        ProvAvanzado.LadaTel2 = ""
        ProvAvanzado.Telefono2 = ""
        ProvAvanzado.Fax = ""
        ProvAvanzado.LadaFax = ""
        ProvAvanzado.DiasCredito = 0
        ProvAvanzado.PorcentajeDescuento = 0
        ProvAvanzado.ClaveBancaria = ""
        ProvAvanzado.CodigoBanco = 0
        ProvAvanzado.PrClaveBancaria = 0
        ProvAvanzado.PrNoCuenta = 0
    End Sub

    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return ProvAvanzado.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("E-mail")> _
    Public Property Email() As String
        Get
            Return ProvAvanzado.Email
        End Get
        Set(ByVal value As String)
            ProvAvanzado.Email = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Web")> _
    Public Property Web() As String
        Get
            Return ProvAvanzado.Web
        End Get
        Set(ByVal value As String)
            ProvAvanzado.Web = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Tipo Proveedor")> _
    Public Property TipoProveedor() As Integer
        Get
            Return ProvAvanzado.CodigoTipoProveedor
        End Get
        Set(ByVal value As Integer)
            ProvAvanzado.CodigoTipoProveedor = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Dia Revisión")> _
    Public Property DiaRevision() As Short
        Get
            Return ProvAvanzado.DiaRevision
        End Get
        Set(ByVal value As Short)
            ProvAvanzado.DiaRevision = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Dia Pago")> _
    Public Property DiaPago() As Short
        Get
            Return ProvAvanzado.DiaPago
        End Get
        Set(ByVal value As Short)
            ProvAvanzado.DiaPago = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono1() As String
        Get
            Return ProvAvanzado.Telefono1
        End Get
        Set(ByVal value As String)
            ProvAvanzado.Telefono1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property lada1() As String
        Get
            Return ProvAvanzado.LadaTel1
        End Get
        Set(ByVal value As String)
            ProvAvanzado.LadaTel1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property lada2() As String
        Get
            Return ProvAvanzado.LadaTel2
        End Get
        Set(ByVal value As String)
            ProvAvanzado.LadaTel2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada Fax")> _
    Public Property ladafax() As String
        Get
            Return ProvAvanzado.LadaFax
        End Get
        Set(ByVal value As String)
            ProvAvanzado.LadaFax = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono2() As String
        Get
            Return ProvAvanzado.Telefono2
        End Get
        Set(ByVal value As String)
            ProvAvanzado.Telefono2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fax")> _
    Public Property Fax() As String
        Get
            Return ProvAvanzado.Fax
        End Get
        Set(ByVal value As String)
            ProvAvanzado.Fax = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Dias Credito")> _
    Public Property DiasCredito() As Integer
        Get
            Return ProvAvanzado.DiasCredito
        End Get
        Set(ByVal value As Integer)
            ProvAvanzado.DiasCredito = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descuento")> _
    Public Property PorcDescto() As Short
        Get
            Return ProvAvanzado.PorcentajeDescuento
        End Get
        Set(ByVal value As Short)
            ProvAvanzado.PorcentajeDescuento = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Banco")> _
    Public Property Banco() As Integer
        Get
            Return ProvAvanzado.CodigoBanco
        End Get
        Set(ByVal value As Integer)
            ProvAvanzado.CodigoBanco = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Clave Bancaria")> _
    Public Property Clave() As String
        Get
            Return ProvAvanzado.ClaveBancaria
        End Get
        Set(ByVal value As String)
            ProvAvanzado.ClaveBancaria = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("ClaveBancaria")> _
    Public Property PrClaveBancaria() As Int64
        Get
            Return ProvAvanzado.PrClaveBancaria
        End Get
        Set(ByVal value As Int64)
            ProvAvanzado.PrClaveBancaria = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
    <System.ComponentModel.DisplayName("CuentaBancaria")> _
    Public Property prNoCuenta() As Int64?
        Get
            Return ProvAvanzado.PrNoCuenta

        End Get
        Set(ByVal value As Int64?)
            ProvAvanzado.PrNoCuenta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    <System.ComponentModel.DisplayName("Prioridad Pago")> _
    Public Property ppago() As PPagoEnum
        Get
            Return ProvAvanzado.PrioridadPago
        End Get
        Set(ByVal value As PPagoEnum)
            ProvAvanzado.PrioridadPago = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Proveedor.Estatus = EstatusEnum.INACTIVO
            If Proveedor.Save() Then Return True
            RaiseEvent MensajeError(Me, "El Proveedor no se pudo borrar.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False

    End Function

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function Guardar() As Boolean
        Try
            If ProvAvanzado.Save Then Return True
            RaiseEvent MensajeError(Me, "El Proveedor no se pudo guardar.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If ProvAvanzado.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "El proveedor especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.ProveedorAvanzadoEntity)
        ProvAvanzado = Entidad
    End Sub

    Public Function ObtenerEntidad() As EC.ProveedorAvanzadoEntity
        Return Me.ProvAvanzado
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
End Class

Public Class ProvAvanzadoCollectionClass
    Inherits CollectionClass(Of ProvAvanzadoClass)

    Private ProveedorAvCol As New CC.ProveedorAvanzadoCollection
    Public Event MensajeError As MensajeErrorHandler
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    Sub New()
        MyBase.New()
    End Sub

    Public Function Borrar() As Object
        ProveedorAvCol = New CC.ProveedorAvanzadoCollection
        For Each ProveedorAv As ProvAvanzadoClass In Me
            Dim ProveedorAvEnt As New EC.ProveedorAvanzadoEntity
            ProveedorAvEnt = ProveedorAv.ObtenerEntidad()
            ProveedorAvCol.Add(ProveedorAvEnt)
        Next
        Try
            Dim Conteo As Integer = ProveedorAvCol.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        ProveedorAvCol = New CC.ProveedorAvanzadoCollection
        For Each proveedorav As ProvAvanzadoClass In Me
            Dim proveedoravEnt As New EC.ProveedorAvanzadoEntity
            proveedoravEnt = proveedorav.ObtenerEntidad()
            ProveedorAvCol.Add(proveedoravEnt)
        Next
        Try
            Dim Conteo As Integer = ProveedorAvCol.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener() As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = ProveedorAvCol.GetDbCount()
            If Conteo > 0 Then
                ProveedorAvCol.GetMulti(Nothing)
                For Each proveedoravEnt As EC.ProveedorAvanzadoEntity In ProveedorAvCol
                    Dim ProveedorAV As New ProvAvanzadoClass
                    ProveedorAV.LeerEntidad(proveedoravEnt)
                    If ProveedorAV.Estatus = EstatusEnum.Activo Then
                        Me.Add(ProveedorAV)
                    End If
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function
    Public Function Obtener(ByVal TipoProveedor As Integer, Optional ByVal RazonSocial As String = "") As ProveedorCollectionClass
        Try
            Me.ClearItems()

            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.ProveedorAvanzadoFields.CodigoTipoProveedor = TipoProveedor)
            Me.ProveedorAvCol.GetMulti(filtro)
            Dim proveedores As New ProveedorCollectionClass
            For Each ProvAv As EC.ProveedorAvanzadoEntity In Me.ProveedorAvCol
                Dim prov As New EC.ProveedorEntity
                Dim ProvClas As New ProveedorClass
                prov.FetchUsingPK(ProvAv.Proveedor.Codigo)
                Dim Entidades(1) As Object
                Entidades(0) = prov
                Entidades(1) = ProvAv
                ProvClas.LeerEntidad(Entidades)
                proveedores.Add(ProvClas)
            Next
            'proveedores.Obtener(RazonSocial, CondicionEnum.ACTIVOS)
            Return proveedores
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Obtener(ByVal ProveedorAV As ProvAvanzadoClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.ProveedorAvanzadoFields.Codigo = ProveedorAV.Codigo)
            Filtro.AddWithOr(HC.ProveedorAvanzadoFields.Email = ProveedorAV.Email)
            Filtro.AddWithOr(HC.ProveedorAvanzadoFields.ClaveBancaria = ProveedorAV.Clave)
            Dim Conteo As Integer = ProveedorAvCol.GetDbCount(Filtro)
            If Conteo > 0 Then
                ProveedorAvCol.GetMulti(Filtro)
                For Each proveedoravEnt As EC.ProveedorAvanzadoEntity In ProveedorAvCol
                    Dim Miproveedorav As New ProvAvanzadoClass
                    Miproveedorav.LeerEntidad(proveedoravEnt)
                    Me.Add(Miproveedorav)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

End Class
