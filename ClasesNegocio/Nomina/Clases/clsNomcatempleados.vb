Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports oc = SD.LLBLGen.Pro.ORMSupportClasses

Public Class NomcatempleadosClass
    Inherits ClassBase(Of EC.NomCatEmpleadosEntity)

    Dim _Departamento As DepartamentosClass
    Dim _Puesto As NomcatpuestosClass
    Dim _Turno As TurnoClass
    Dim _Estado As EstadoClass
    Dim _Ciudad As CiudadClass
    Dim _Poblacion As PoblacionClass
    Dim _dias As DiaClass

#Region "Propiedades"
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
            'Return Entity.noclinica()

        End Get
    End Property

    Public Property Nombres() As String
        Get
            Return Entity.Nombres
        End Get
        Set(ByVal value As String)
            Entity.Nombres = value
        End Set
    End Property

    Public Property ApellidoPaterno() As String
        Get
            Return Entity.ApellidoPaterno
        End Get

        Set(ByVal value As String)
            Entity.ApellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno() As String
        Get
            Return Entity.ApellidoMaterno
        End Get

        Set(ByVal value As String)
            Entity.ApellidoMaterno = value
        End Set
    End Property

    Public ReadOnly Property NombreCompleto() As String
        Get
            Return Entity.Nombres & " " & Entity.ApellidoPaterno & " " & Entity.ApellidoMaterno
        End Get
    End Property

    Public Property FechaNacimiento() As DateTime
        Get
            Return Entity.FechaNacimiento
        End Get

        Set(ByVal value As DateTime)
            Entity.FechaNacimiento = value
        End Set
    End Property

    Public Property RFC() As String
        Get
            Return Entity.Rfc
        End Get

        Set(ByVal value As String)
            Entity.Rfc = value
        End Set
    End Property

    Public Property CURP() As String
        Get
            Return Entity.Curp
        End Get

        Set(ByVal value As String)
            Entity.Curp = value
        End Set
    End Property

    Public Property SEXO() As Boolean
        Get
            Return Entity.Sexo
        End Get

        Set(ByVal value As Boolean)
            Entity.Sexo = value
        End Set
    End Property

    Public Property Domicilio() As String
        Get
            Return Entity.Domicilio
        End Get

        Set(ByVal value As String)
            Entity.Domicilio = value
        End Set
    End Property

    Public Property Colonia() As String
        Get
            Return Entity.Colonia
        End Get

        Set(ByVal value As String)
            Entity.Colonia = value
        End Set
    End Property

    Public Property CodigoPostal() As String
        Get
            Return Entity.CodigoPostal
        End Get

        Set(ByVal value As String)
            Entity.CodigoPostal = value
        End Set
    End Property

    Public Property Poblacion() As PoblacionClass
        Get
            If _Poblacion Is Nothing Then
                _Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            End If
            Return _Poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            _Poblacion = value
            If value Is Nothing Then
                Entity.IdPoblacion = -1
            Else
                Entity.IdPoblacion = value.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomPoblacion() As String
        Get
            Return Poblacion.Descripcion
        End Get
    End Property

    Public Property Ciudad() As CiudadClass
        Get
            If _Ciudad Is Nothing Then
                _Ciudad = New CiudadClass(Entity.IdEstado, Entity.IdCiudad)
            End If
            Return _Ciudad
        End Get
        Set(ByVal value As CiudadClass)
            _Ciudad = value
            If value Is Nothing Then
                Entity.Codigo = -1
            Else
                Entity.Codigo = value.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomCiudad() As String
        Get
            Return Ciudad.Descripcion
        End Get
    End Property

    Public Property Estado() As EstadoClass
        Get
            If _Estado Is Nothing Then
                _Estado = New EstadoClass(Entity.Codigo)
            End If
            Return _Estado
        End Get
        Set(ByVal value As EstadoClass)
            _Estado = value
            If value Is Nothing Then
                Entity.Codigo = -1
            Else
                Entity.Codigo = value.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomEstado() As String
        Get
            Return Estado.Descripcion
        End Get
    End Property

    Public Property Padre() As String
        Get
            Return Entity.Padre
        End Get

        Set(ByVal value As String)
            Entity.Padre = value
        End Set
    End Property

    Public Property Madre() As String
        Get
            Return Entity.Madre
        End Get

        Set(ByVal value As String)
            Entity.Madre = value
        End Set
    End Property

    Public Property Telefonos() As String
        Get
            Return Entity.Telefono
        End Get

        Set(ByVal value As String)
            Entity.Telefono = value
        End Set
    End Property

    Public Property Celular() As String
        Get
            Return Entity.Celular
        End Get

        Set(ByVal value As String)
            Entity.Celular = value
        End Set
    End Property

    Public Property EstadoCivil() As String
        Get
            Return Entity.EstadoCivil
        End Get

        Set(ByVal value As String)
            Entity.EstadoCivil = value
        End Set
    End Property

    Public Property Conyuge() As String
        Get
            Return Entity.Conyuge
        End Get

        Set(ByVal value As String)
            Entity.Conyuge = value
        End Set
    End Property

    Public Property IMSS() As String
        Get
            Return Entity.Imss
        End Get

        Set(ByVal value As String)
            Entity.Imss = value
        End Set
    End Property

    Public Property FONACOT() As String
        Get
            Return Entity.Fonacot
        End Get

        Set(ByVal value As String)
            Entity.Fonacot = value
        End Set
    End Property

    Public Property TipoCredito() As Boolean
        Get
            Return Entity.Tipocreditoinfonavit
        End Get
        Set(ByVal value As Boolean)
            Entity.Tipocreditoinfonavit = value
        End Set
    End Property

    Public Property Infonavit() As String
        Get
            Return Entity.Infonavit
        End Get

        Set(ByVal value As String)
            Entity.Infonavit = value
        End Set
    End Property

    Public Property ImporteInfonavit() As Decimal
        Get
            Return Entity.ImporteDescuentoInfonavit
        End Get

        Set(ByVal value As Decimal)
            Entity.ImporteDescuentoInfonavit = value
        End Set
    End Property

    Public Property ImportePensionAlimenticia() As Decimal
        Get
            Return Entity.PorcDescuentoPensionAlimenticia
        End Get

        Set(ByVal value As Decimal)
            Entity.PorcDescuentoPensionAlimenticia = value
        End Set
    End Property


    Public Property IdDepartamento() As Integer
        Get
            Return Entity.IdDepartamento
        End Get

        Set(ByVal value As Integer)
            Entity.IdDepartamento = value
        End Set
    End Property

    Public Property Departamento() As DepartamentosClass
        Get
            If _Departamento Is Nothing Then
                _Departamento = New DepartamentosClass(Entity.CatDeptos)
            End If
            Return _Departamento
        End Get
        Set(ByVal value As DepartamentosClass)
            _Departamento = value
            If value Is Nothing Then
                Entity.CatDeptos = Nothing
            Else
                Entity.CatDeptos = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property IdPuesto() As NomcatpuestosClass
        Get
            If _Puesto Is Nothing Then
                _Puesto = New NomcatpuestosClass(Entity.Codigo)
            End If
            Return _Puesto
        End Get
        Set(ByVal value As NomcatpuestosClass)
            _Puesto = value
            If value Is Nothing Then
                Entity.IdPuesto = -1
            Else
                Entity.IdPuesto = value.IdPuesto
            End If
        End Set
    End Property

    Public ReadOnly Property NomPuesto() As String
        Get
            Return _Puesto.Descripcion
        End Get
    End Property

    Public Property Salario() As Decimal
        Get
            Return Entity.SalarioActual
        End Get

        Set(ByVal value As Decimal)
            Entity.SalarioActual = value
        End Set
    End Property

    Public Property SDI() As Decimal
        Get
            Return Entity.Sdi
        End Get

        Set(ByVal value As Decimal)
            Entity.Sdi = value
        End Set
    End Property

    Public Property Descanso() As Integer
        Get
            Return Entity.Descanso
        End Get

        Set(ByVal value As Integer)
            Entity.Descanso = value
        End Set
    End Property

    Public Property DiasDescanso() As DiaClass
        Get
            If _Dias Is Nothing Then
                _dias = New DiaClass(Entity.Descanso)
            End If
            Return _dias
        End Get
        Set(ByVal value As DiaClass)
            _dias = value
            If value Is Nothing Then
                Entity.Descanso = Nothing
            Else
                Entity.Descanso = value.Dia
            End If
        End Set
    End Property

    Public Property Turno() As Integer
        Get
            Return Entity.Turno
        End Get

        Set(ByVal value As Integer)
            Entity.Turno = value
        End Set
    End Property

    Public Property TURNOS() As TurnoClass
        Get
            If _Turno Is Nothing Then
                _Turno = New TurnoClass(Entity.Turno)
            End If
            Return _Turno
        End Get
        Set(ByVal value As TurnoClass)
            _Turno = value
            If value Is Nothing Then
                Entity.Turno = Nothing
            Else
                Entity.Turno = value.Turno
            End If
        End Set
    End Property

    Public Property AplicaIMSS() As Integer
        Get
            Return Entity.AplicaImss
        End Get

        Set(ByVal value As Integer)
            Entity.AplicaImss = value
        End Set
    End Property

    Public Property AplicaISR() As Integer
        Get
            Return Entity.AplicaIsr
        End Get

        Set(ByVal value As Integer)
            Entity.AplicaIsr = value
        End Set
    End Property

    Public Property AplicaPension() As Integer
        Get
            Return Entity.PensionAlimenticia
        End Get

        Set(ByVal value As Integer)
            Entity.PensionAlimenticia = value
        End Set
    End Property

    Public Property Estatus() As Integer
        Get
            Return Entity.Estatus
        End Get

        Set(ByVal value As Integer)
            Entity.Estatus = value
        End Set
    End Property

    Public Property FechaAlta() As DateTime
        Get
            Return Entity.FechaAlta
        End Get

        Set(ByVal value As DateTime)
            Entity.FechaAlta = value
        End Set
    End Property

    Public Property FechaOtorgoCredito() As DateTime
        Get
            Return Entity.FecheOtorgamientoCrédito
        End Get
        Set(ByVal value As DateTime)
            Entity.FecheOtorgamientoCrédito = value
        End Set
    End Property

    Public Property Factor() As Decimal
        Get
            Return Entity.Factor
        End Get
        Set(ByVal value As Decimal)
            Entity.Factor = value
        End Set
    End Property

    Public Property DiasAginaldo() As Integer
        Get
            Return Entity.DiasAginaldo
        End Get
        Set(ByVal value As Integer)
            Entity.DiasAginaldo = value
        End Set
    End Property

    Public Property DiasAginaldoAdicional() As Integer
        Get
            Return Entity.DiasAginaldoAdicional
        End Get
        Set(ByVal value As Integer)
            Entity.DiasAginaldoAdicional = value
        End Set
    End Property

    Public Property DiasVacaciones() As Integer
        Get
            Return Entity.DiasVacaciones
        End Get
        Set(ByVal value As Integer)
            Entity.DiasVacaciones = value
        End Set
    End Property

    Public Property DiasVacacionesAdicional() As Integer
        Get
            Return Entity.DiasVacacionesAdicional
        End Get
        Set(ByVal value As Integer)
            Entity.DiasVacacionesAdicional = value
        End Set
    End Property

    Public Property DiasPrimaVacacional() As Integer
        Get
            Return Entity.DiasPrimaVacacional
        End Get
        Set(ByVal value As Integer)
            Entity.DiasPrimaVacacional = value
        End Set
    End Property

    Public Property FechaIngreso() As DateTime
        Get
            Return Entity.FechaIngreso
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaIngreso = value
        End Set
    End Property

    Public Property FechaBaja() As DateTime
        Get
            Return Entity.FechaBaja
        End Get

        Set(ByVal value As DateTime)
            Entity.FechaBaja = value
        End Set
    End Property

    'Public Property IdUsuarioAlta() As Integer
    '    Get
    '        Return Entity.IdUsuarioAlt
    '    End Get

    '    Set(ByVal value As Integer)
    '        _IdUsuarioAlta = value
    '    End Set
    'End Property

    'Private _IdUsuarioCancela As Integer
    'Public Property IdUsuarioCancela() As Integer
    '    Get
    '        Return _IdUsuarioCancela
    '    End Get

    '    Set(ByVal value As Integer)
    '        _IdUsuarioCancela = value
    '    End Set
    'End Property

    'Private _FechaCancelacion As DateTime

#End Region

#Region "Costructores"
    Sub New()
        Entity = New EC.NomCatEmpleadosEntity
    End Sub

    Sub New(ByVal Entidad As EC.NomCatEmpleadosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdPlaza As Integer, ByVal Codigo As Integer)
        Entity = New EC.NomCatEmpleadosEntity(Codigo)
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(ByVal codigo As Integer) As Boolean
        Try
            If Entity.FetchUsingPK(codigo) Then
                Dim emple As New CC.NomCatEmpleadosCollection
                emple.GetMulti(HC.NomCatEmpleadosFields.Codigo = Entity.Codigo)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Function Obtener(ByVal IdPlaza As Integer, ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As HC.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Return Entity.Save
            Else
                Dim Col As New CC.NomCatEmpleadosCollection
                If Col.GetDbCount(Not HC.NomCatPuestosFields.Codigo = Me.Codigo And HC.NomCatEmpleadosFields.Nombres = Me.Nombres And HC.NomCatEmpleadosFields.ApellidoPaterno = Me.ApellidoPaterno And HC.NomCatEmpleadosFields.ApellidoMaterno = Me.ApellidoMaterno) > 0 Then
                    MsgBox("Ya existe otra persona con el mismo Nombre", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

End Class

Public Class EmpleadosCollectionClass
    Inherits ColleccionBase(Of EC.NomCatEmpleadosEntity, CC.NomCatEmpleadosCollection, NomcatempleadosClass)
    Private _mostrar As MostrarEnum
    Private FILTRO As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    Public Overloads Function Obtener(ByVal Descripcion As String) As Integer
        Try
            Me.Clear()
            If Not Descripcion = "" Then
                coleccion.GetMulti(HC.NomCatEmpleadosFields.Nombres Mod String.Format("%{0}%", Descripcion))
            Else
                coleccion.GetMulti(Nothing)
            End If

            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function ObtenerEmpleados(ByVal Condicion As EstatusChar) As Integer
        Try
            Me.Clear()
            If Condicion <> EstatusChar.TODOS Then
                coleccion.GetMulti(HC.NomCatEmpleadosFields.Estatus = Condicion)
            Else
                coleccion.GetMulti(Nothing)
            End If
            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Property mostrar() As MostrarEnum
        Get
            Return _mostrar
        End Get
        Set(ByVal value As MostrarEnum)
            _mostrar = value
        End Set
    End Property

    Sub New(ByVal fcmostrar As MostrarEnum)
        MyBase.New()
        mostrar = fcmostrar
    End Sub

    Sub New()
        MyBase.new()
    End Sub

   
    Public Overloads Function Obtener(ByVal Nombre As String, ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, ByVal rfc As String, ByVal TipoBusqueda As TipoBusquedaEnum, Optional ByVal Codigo As Integer = -1, Optional ByVal fccondicion As CondicionEstatusEnum = CondicionEstatusEnum.TODOS, Optional ByVal Ignorar As NomcatempleadosClass = Nothing) As Integer
        Try
            Me.Clear()
            FILTRO = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            If Codigo = -1 Then
                If rfc = "" Then
                    FILTRO.Add(HC.NomCatEmpleadosFields.Nombres Mod String.Format("%{0}%", Nombre))
                    FILTRO.Add(HC.NomCatEmpleadosFields.ApellidoPaterno Mod String.Format("%{0}%", ApellidoMaterno))
                    FILTRO.Add(HC.NomCatEmpleadosFields.ApellidoMaterno Mod String.Format("%{0}%", ApellidoPaterno))
                Else
                    FILTRO.Add(HC.NomCatEmpleadosFields.Rfc Mod String.Format("%{0}%", rfc))
                End If
            Else
                FILTRO.Add(HC.NomCatEmpleadosFields.Codigo = Codigo)
            End If

            If Not fccondicion = CondicionEstatusEnum.TODOS Then
                FILTRO.Add(HC.NomCatEmpleadosFields.Estatus = fccondicion)
            End If

            If Not Ignorar Is Nothing Then
                FILTRO.Add(Not HC.NomCatEmpleadosFields.Codigo = Ignorar.Codigo)
            End If

            coleccion.GetMulti(FILTRO)

            Dim Conteo As Integer = coleccion.Count

            For Each empleadoEntity As EC.NomCatEmpleadosEntity In coleccion
                Dim Miempleado As New NomcatempleadosClass
                Miempleado.LeerEntidad(empleadoEntity)
                Me.Add(Miempleado)
                Conteo += 1
            Next
            Return Conteo
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Codigo As Integer) As Integer
        Try
            Me.Clear()
            coleccion.GetMulti(HC.NomCatEmpleadosFields.Codigo = Codigo )

            For Each entidad As EC.NomCatEmpleadosEntity In coleccion
                Dim MiEmpleado As New NomcatempleadosClass
                MiEmpleado.LeerEntidad(entidad)
                Me.Add(MiEmpleado)
            Next
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function




End Class
