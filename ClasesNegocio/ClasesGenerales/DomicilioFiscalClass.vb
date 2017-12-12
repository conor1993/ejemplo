Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DomicilioFiscalClass
    Implements IEntidad

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Private entidad As EC.DomicilioFiscalEntity
    Private _Poblacion As PoblacionClass

    <ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return entidad.Codigo
        End Get
    End Property

    <ComponentModel.DisplayName("RFC")> _
    Public Property RFC() As String
        Get
            Return entidad.Rfc
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("RFC", "Debe ingresar un RFC")
                Throw New SystemException(" ")
            Else
                entidad.Rfc = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Razón Social")> _
    Public Property RazonSocial() As String
        Get
            Return entidad.RazonSocial
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("RazonSocial", "Debe ingresar una Razón Social")
                Throw New SystemException(" ")
            Else
                entidad.RazonSocial = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Domicilio")> _
    Public Property Domicilio() As String
        Get
            Return entidad.Domicilio
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Domicilio", "Debe ingresar un domicilio")
                Throw New SystemException(" ")
            Else
                entidad.Domicilio = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Calle")> _
    Public Property Calle() As String
        Get
            Return entidad.Calle
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Calle", "Debe ingresar una calle")
                Throw New SystemException(" ")
            Else
                entidad.Calle = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("No. Exterior")> _
    Public Property NoExterior() As String
        Get
            Return entidad.NoExterior
        End Get
        Set(ByVal value As String)
            entidad.NoExterior = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("No. Interior")> _
    Public Property NoInterior() As String
        Get
            Return entidad.NoInterior
        End Get
        Set(ByVal value As String)
            entidad.NoInterior = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <ComponentModel.DisplayName("Colonia")> _
    Public Property Colonia() As String
        Get
            Return entidad.Colonia
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Colonia", "Debe ingresar una colonia")
                Throw New SystemException(" ")
            Else
                entidad.Colonia = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Código Postal")> _
    Public Property CP() As String
        Get
            Return entidad.CodigoPostal
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("CP", "Debe ingresar un Código Postal")
                Throw New SystemException(" ")
            Else
                entidad.CodigoPostal = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Población")> _
    Public Property Poblacion() As PoblacionClass
        Get
            _Poblacion = New PoblacionClass(entidad.Estado, entidad.Ciudad, entidad.Poblacion)
            Return _Poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            If value Is Nothing Then
                RaiseEvent MensajeError("Poblacion", "Debe seleccionar una poblacion")
                Throw New SystemException(" ")
                'Else
                '    entidad. = value
                '    RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Estado")> _
    Public ReadOnly Property Estado() As EstadoClass
        Get

            Dim estadov As New EstadoClass(entidad.Estado)
            Return estadov
        End Get
    End Property

    <ComponentModel.DisplayName("Ciudad")> _
    Public ReadOnly Property Ciudad() As CiudadClass
        Get
            Dim ciudadv As New CiudadClass(entidad.Estado, entidad.Ciudad)
            Return ciudadv
        End Get
    End Property

    <ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaAlta() As DateTime
        Get
            Return entidad.FechaAlta
        End Get
        Set(ByVal value As DateTime)
            entidad.FechaAlta = value
        End Set
    End Property

    <ComponentModel.DisplayName("Usuario de Alta")> _
    Public Property UsuarioAlta() As Integer
        Get
            Return entidad.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            entidad.UsuarioAlta = value
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha de Baja")> _
    Public ReadOnly Property FechaBaja() As DateTime
        Get
            Return entidad.FechaBaja
        End Get
    End Property

    <ComponentModel.DisplayName("Usuario de Baja")> _
    Public Property UsuarioBaja() As Integer
        Get
            Return entidad.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            entidad.UsuarioBaja = value
        End Set
    End Property

    <ComponentModel.DisplayName("Observaciones de Baja")> _
    Public Property ObservacionesBaja() As String
        Get
            Return entidad.ObservacionesBaja
        End Get
        Set(ByVal value As String)
            entidad.ObservacionesBaja = value
        End Set
    End Property

    <ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return entidad.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            entidad.Estatus = value
        End Set
    End Property

    <ComponentModel.DisplayName("Es Principal")> _
    Public Property EsPrincipal() As Boolean
        Get
            Return entidad.EsPrincipal
        End Get
        Set(ByVal value As Boolean)
            entidad.EsPrincipal = value
        End Set
    End Property

    Public ReadOnly Property DomicilioCompleto() As String
        Get
            Return String.Format("{0}, {1}, {2}", Domicilio, Colonia, Poblacion.Descripcion)
        End Get
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            'coleccion que se usara para validar qye no haya domicilios fiscales secundarios activos
            Dim col As New CC.DomicilioFiscalCollection

            'valida si el domicilio fiscal es principal
            If entidad.EsPrincipal Then
                'valida que no haya domicilios fiscales secundarios que dependan del domicilio principal
                If col.GetDbCount(HC.DomicilioFiscalFields.Estatus = EstatusEnum.ACTIVO And HC.DomicilioFiscalFields.Rfc = RFC And _
                    HC.DomicilioFiscalFields.EsPrincipal = False) > 0 And EsPrincipal Then
                    RaiseEvent MensajeError(Me, "No es posible dar de baja el el domicilio fiscal, por que es un domicilio principal y cuenta con domicilios fiscales activos")
                    Return False
                End If
            End If

            'coleccion que se usara para validar que no haya clientes o compradores usando el domicilio fiscal activos
            Dim coldom As New CC.DomicilioFiscalesClientesCollection

            'valida que no haya clientes ni compradores activos usando el domicilio fiscal
            If coldom.GetDbCount(HC.DomicilioFiscalesClientesFields.Codigo = Codigo) > 0 Then
                RaiseEvent MensajeError(Me, "No es podible dar de baja el domicilio fiscal, por que hay clientes o compradores utilizando el domicilio fiscal")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO

            If entidad.Save Then
                Return True
            Else
                RaiseEvent MensajeError(Me, "No se logro dar de baja, intente neuvamente")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se logro dar de baja, intente neuvamente")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            If entidad.IsNew Then
                'declaro la coleccion de domicilios ficales para realizar validaciones
                Dim col As New CC.DomicilioFiscalCollection

                'busco si hay un domicilio con el RFC ingresado
                col.GetMulti(HC.DomicilioFiscalFields.Rfc = RFC And HC.DomicilioFiscalFields.EsPrincipal = True)

                'obtengo la entidad que se obtuvo de la busqueda anterior
                For Each ent As EC.DomicilioFiscalEntity In col
                    'valido que la razon social ingresada sea = a la ya establecida al RFC
                    If Not RazonSocial = ent.RazonSocial Then
                        'variable para almacenar el mensaje a mostrar
                        Dim men As String = String.Format("El RFC: {1}, ya esta registrado con la Razón Social {2}, y usted" & _
                                            "proporciono la Razón Social {0}.", RazonSocial, RFC, ent.RazonSocial)

                        'pregunto que si esta deacuerdo con lo que se desea hacer
                        RaiseEvent MensajeError("RazonSocial", men)
                        Return False
                    End If

                    'como ya existe un domicilio con el RFC especificado el domicilio no es principal
                    EsPrincipal = False

                    Exit For
                Next

                'guardo y valido que se haya guardado
                If entidad.Save Then
                    Return True
                    'si no se guardo
                Else
                    RaiseEvent MensajeError(Me, "No se logro guardar, intente nuevamente")
                    Return False
                End If
                'si no es nuevo
            Else
                Dim col As New CC.DomicilioFiscalCollection
                Dim ent As New EC.DomicilioFiscalEntity
                Dim EsNuevo As Boolean = False

                'obtengo el registro original del domicilio fiscal
                If ent.FetchUsingPK(Codigo) Then
                    'valido si el rfc del original y el modificado son iguales
                    If ent.Rfc = RFC Then
                        'valido que la Razón Social que ingreso sea = a la que ya esta establecida con el RFC actual
                        If ent.RazonSocial = RazonSocial Then
                            'variable donde almaceno el mensaje que sera mostrado por no ser iguales la razon social 
                            Dim men As String = String.Format("El RFC: {1}, ya esta registrado con la Razón Social {2}, y usted" & _
                                                "proporciono la Razón Social {0}. Un RFC solo peude tener una Razón Social", _
                                                RazonSocial, RFC, ent.RazonSocial)

                            RaiseEvent MensajeError("RazonSocial", men)
                            Return False
                        End If
                    Else
                        'valido que el domicilio fiscal que se desea modificar no sea principal
                        If entidad.EsPrincipal Then
                            RaiseEvent MensajeError(Me, "No es posible modificar un domicilio fiscal principal")
                            Return False
                        End If

                        'como el rfc fue modificado utilizare una variable booleana para guardar ahi el valor si el registro
                        'va a ser principal en caso que no haya otro domicilio con el rfc nuevo
                        'o si no sera princpal en caso que ya haya domicilios con el nuevo rfc
                        'por default utilisare el valor true
                        Dim principal As Boolean = True

                        'obtengo el domicilio fical principal del rfc que se acaba de igresar
                        col.GetMulti(HC.DomicilioFiscalFields.Rfc = RFC And HC.DomicilioFiscalFields.EsPrincipal = True)

                        'obtengo la entidad que se obtubo de la consulta anterior en caso que se haya obtenido alguna 
                        For Each ente As EC.DomicilioFiscalEntity In col
                            'valido que la razon social se = a la del otro rfc que se desea guardar
                            If Not ente.RazonSocial = RazonSocial Then
                                'variable donde almaceno el mensaje que sera mostrado por no ser iguales la razon social 
                                Dim men As String = String.Format("El RFC: {1}, ya esta registrado con la Razón Social {2}, y usted" & _
                                                    "proporciono la Razón Social {0}.", RazonSocial, RFC, ente.RazonSocial)

                                RaiseEvent MensajeError("RazonSocial", men)
                                Return False
                            End If
                            'establesco que el domicilio no es principal por que ya existe otro
                            principal = False
                        Next

                        'asigno el valor de la variable principal que contiene el valor si sera o no sera principal 
                        'el domicilio fiscal
                        entidad.EsPrincipal = principal
                    End If

                    'guardo y valido si se guardo
                    If entidad.Save Then
                        Return True
                        'si no guardo
                    Else
                        RaiseEvent MensajeError(Me, "No se logro guardar el domicilio, intente nuevamente")
                        Return False
                    End If
                End If
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se logro guardar el domicilio, intente nuevamente")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Return entidad.FetchUsingPK(Codigo)
    End Function

    Public Function ObtenerEntidad() As EC.DomicilioFiscalEntity
        Return entidad
    End Function

    Public Sub LeerEntidad(ByVal fcentidad As EC.DomicilioFiscalEntity)
        entidad = fcentidad
    End Sub

    Sub New()
        entidad = New EC.DomicilioFiscalEntity
        Me._Poblacion = New PoblacionClass
        UsuarioAlta = 0
        FechaAlta = Now
        EsPrincipal = True
        Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal EntidadE As EC.DomicilioFiscalEntity)
        Me.entidad = EntidadE
        Me._Poblacion = New PoblacionClass
    End Sub

    Public Overrides Function ToString() As String
        Return Me.DomicilioCompleto
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

End Class