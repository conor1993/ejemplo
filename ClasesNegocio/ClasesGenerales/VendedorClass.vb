Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class VendedorClass
    Inherits ClassBase(Of EC.ComicionistaEntity)

    Private _poblacion As PoblacionClass
    Private _zona As ZonaClass
    Private _plaza As PlazaClass
    'Private _TipoComisionista As TipoVendedorClass
    Private _CuentaContable As CuentaContableClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        Entity = New EC.ComicionistaEntity
        Entity.Nombre = ""
        Entity.Apaterno = ""
        Entity.Amaterno = ""
        Entity.Estatus = EstatusEnum.ACTIVO
        Entity.Plaza = 0
        Entity.Domicilio = ""
        Entity.TipoComisionista = 0
        Entity.Colonia = ""
        Entity.CodigoPostal = "" '0
        Entity.Email = ""
        Entity.Poblacion = 0
        Entity.LadaTel1 = "" '0
        Entity.LadaTel2 = "" '0
        Entity.LadaFax = "" '0
        Entity.Telefono1 = "" '0
        Entity.Telefono2 = "" '0
        Entity.Fax = "" '0
        Entity.Rfc = ""
        Entity.Zona = 0
    End Sub
    Sub New(ByVal Entity As EC.ComicionistaEntity)
        Me.Entity = Entity
    End Sub

#Region "Propiedades"
    <System.ComponentModel.DisplayName("Estatus")> _
        Public Property Estatus() As EstatusEnum 'Implements IEntidad.Estatus
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Nombre")> _
    Public Property Nombre() As String
        Get
            Return Entity.Nombre
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Nombre", "Debe ingresar un Nombre")
                Throw New SystemException(" ")
            Else
                Entity.Nombre = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Apellido Paterno")> _
    Public Property Apaterno() As String
        Get
            Return Entity.Apaterno
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Apaterno", "Debe ingresar un Apellido Paterno")
                Throw New SystemException(" ")
            Else
                Entity.Apaterno = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Apellido Materno")> _
    Public Property Amaterno() As String
        Get
            Return Entity.Amaterno
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Amaterno", "Debe ingresar un Apellido Materno")
                Throw New SystemException(" ")
            Else
                Entity.Amaterno = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Nombre Completo")> _
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return String.Format("{0} {1} {2}", Nombre, Apaterno, Amaterno)
        End Get
    End Property

    <System.ComponentModel.DisplayName("Plaza")> _
    Public Property Plaza() As PlazaClass
        Get
            If Me._plaza Is Nothing Then
                Me._plaza = New PlazaClass
                Me._plaza.LeerEntidad(Entity.Plaza_)
            End If

            Return Me._plaza
        End Get
        Set(ByVal value As PlazaClass)
            If value Is Nothing Then
                Me._plaza = Nothing
                Entity.Plaza = Nothing
                RaiseEvent MensajeError("Plaza", "Debe ingresar una plaza")
                Throw New SystemException(" ")
            Else
                Me._plaza = value
                Entity.Plaza_ = value.ObtenerEntidad
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Domicilio")> _
    Public Property Domicilio() As String
        Get
            Return Entity.Domicilio
        End Get
        Set(ByVal value As String)
            Entity.Domicilio = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    '<System.ComponentModel.DisplayName("Tipo de Comicionista")> _
    'Public Property TipoComicionista() As TipoVendedorClass
    '    Get
    '        If Me._TipoComisionista Is Nothing Then
    '            Me._TipoComisionista = New TipoVendedorClass
    '            Me._TipoComisionista.LeerEntidad(Me.Entity.TipoComicionista)
    '        End If

    '        Return _TipoComisionista
    '    End Get
    '    Set(ByVal value As TipoVendedorClass)
    '        If value Is Nothing Then
    '            Me._TipoComisionista = Nothing
    '            Entity.TipoComicionista = Nothing
    '            RaiseEvent Modificado(Me, New EventArgs)
    '        Else
    '            Me._TipoComisionista = value
    '            Entity.TipoComicionista = value.ObtenerEntidad
    '            RaiseEvent Modificado(Me, New EventArgs)
    '        End If
    '    End Set
    'End Property

    <System.ComponentModel.DisplayName("Colonia")> _
    Public Property Colonia() As String
        Get
            Return Entity.Colonia
        End Get
        Set(ByVal value As String)
            Entity.Colonia = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código Postal")> _
    Public Property CodigoPostal() As String
        Get
            Return Entity.CodigoPostal
        End Get
        Set(ByVal value As String)
            Entity.CodigoPostal = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("E-mail")> _
    Public Property Email() As String
        Get
            Return Entity.Email
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Email", "Debe ingresar un Email")
                Throw New SystemException(" ")
            Else
                Entity.Email = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("CodEstado")> _
    Public Property IdEstado() As Integer
        Get
            Return Entity.Estado
        End Get
        Set(ByVal value As Integer)
            Entity.Estado = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("CodCiudad")> _
    Public Property IdCiudad() As Integer
        Get
            Return Entity.Ciudad
        End Get
        Set(ByVal value As Integer)
            Entity.Ciudad = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("CodPoblacion")> _
    Public Property IdPoblacion() As Integer
        Get
            Return Entity.Poblacion
        End Get
        Set(ByVal value As Integer)
            Entity.Poblacion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Población")> _
    Public Property Poblacion() As PoblacionClass
        Get
            If Me._poblacion Is Nothing Then
                Me._poblacion = New PoblacionClass(Entity.Estado, Entity.Ciudad, Entity.Poblacion)
                'Me._poblacion.LeerEntidad(Me._)
            End If

            Return _poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            Me._poblacion = value

            'If value Is Nothing Then
            '    Entity.Poblacion = Nothing
            'Else
            '    Entity.Poblacion_ = value.ObtenerEntidad
            'End If

            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
        Public Property Lada() As String
        Get
            Return Entity.LadaTel1
        End Get
        Set(ByVal value As String)
            Entity.LadaTel1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property Lada1() As String
        Get
            Return Entity.LadaTel2
        End Get
        Set(ByVal value As String)
            Entity.LadaTel2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property Lada2() As String
        Get
            Return Entity.LadaFax
        End Get
        Set(ByVal value As String)
            Entity.LadaFax = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono() As String
        Get
            Return Entity.Telefono1
        End Get
        Set(ByVal value As String)
            Entity.Telefono1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono1() As String
        Get
            Return Entity.Telefono2
        End Get
        Set(ByVal value As String)
            Entity.Telefono2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fax")> _
        Public Property Fax() As String
        Get
            Return Entity.Fax
        End Get
        Set(ByVal value As String)
            Entity.Fax = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property IdZona() As Nullable(Of Integer)
        Get
            Return Me.Entidad.Zona
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Me.Entidad.Zona = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Zona")> _
    Public ReadOnly Property Zona() As ZonaClass
        Get
            If Me._zona Is Nothing OrElse Me.IdZona.HasValue AndAlso Me._zona.Codigo <> Me.IdZona.Value Then
                Me._zona = New ZonaClass(Me.IdZona)
            End If
            Return Me._zona
        End Get
    End Property

    <System.ComponentModel.DisplayName("Fecha de Alta")> _
        Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("RFC")> _
    Public Property Rfc() As String
        Get
            Return Entity.Rfc
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                RaiseEvent MensajeError("Rfc", "Debe ingresar un Rfc")
                Throw New SystemException(" ")
            Else
                Entity.Rfc = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get
            If Me._CuentaContable Is Nothing Then
                Me._CuentaContable = New CuentaContableClass(Entity.CuentaContable)
            End If

            Return Me._CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            Me._CuentaContable = value

            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property Sueldo() As Decimal
        Get
            Return Entity.Sueldo
        End Get
        Set(ByVal value As Decimal)
            Entity.Sueldo = value
        End Set
    End Property

    Public Property Porcentaje() As Decimal
        Get
            Return Entity.Porcentaje
        End Get
        Set(ByVal value As Decimal)
            Entity.Porcentaje = value
        End Set
    End Property
#End Region

    Public Shadows Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            Entity.Estatus = EstatusEnum.INACTIVO
            If Entity.Save() Then
                Return True
            Else
                MsgBox("No ha sido dado de baja, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Shadows Function Guardar() As Boolean 'Implements IEntidad.Guardar
        Try
            If Entity.IsNew Then
                Dim col As New CC.ComicionistaCollection

                If col.GetDbCount(HC.ComicionistaFields.Rfc = Rfc) > 0 Then
                    MsgBox("Ya existe un comicionista con el mismo RFC.", MsgBoxStyle.Exclamation, "RFC Repetido")
                    Return False
                End If

                If col.GetDbCount(HC.ComicionistaFields.Nombre = Nombre And HC.ComicionistaFields.Apaterno = Apaterno And HC.ComicionistaFields.Amaterno = Amaterno) > 0 Then
                    MsgBox("Ya existe un comicionista con el mismo nombre completo.", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If Entity.Save Then
                    Return True
                Else
                    MsgBox("No se logró guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                Dim col As New CC.ComicionistaCollection

                If col.GetDbCount(Not HC.ComicionistaFields.Codigo = Codigo And HC.ComicionistaFields.Rfc = Rfc) > 0 Then
                    MsgBox("Ya exite un comicionista con el mismo RFC", MsgBoxStyle.Exclamation, "RFC Repetido")
                    Return False
                End If

                If Entity.Save Then
                    Return True
                Else
                    MsgBox("No se logró guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean 'Implements IEntidad.Obtener
        Try
            If Me.Entity.FetchUsingPK(Codigo) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class