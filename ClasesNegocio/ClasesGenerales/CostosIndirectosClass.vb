Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CN = ClasesNegocio


Public Class CostosIndirectosClass
    Implements IEntidad


    Private _Entidad As New EC.CostoIndirectoEntity


    Public ReadOnly Property IDCostosIndirectos() As Integer
        Get
            Return _Entidad.Codigo
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return _Entidad.Descripcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Descripcion", "Debe ingresar una Descripción")
                Throw New System.Exception(" ")
            Else
                _Entidad.Descripcion = value
            End If
        End Set
    End Property

    Public Property DescripcionCorta() As String
        Get
            Return _Entidad.DescripcionCorta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("DescripcionCorta", "Debe ingresar una Descripción Corta")
                Throw New System.Exception(" ")
            Else
                _Entidad.DescripcionCorta = value
            End If
        End Set
    End Property

    Public Property CuentaMayor() As String
        Get
            Return _Entidad.CtaMayor
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("CuentaMayor", "Debe ingresar una Cuenta Mayor")
                Throw New System.Exception(" ")
            Else
                _Entidad.CtaMayor = value
            End If
        End Set
    End Property

    Public Property CuentaS() As String
        Get
            Return _Entidad.Sscta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("CuentaS", "Debe ingresar una Cuenta S")
                Throw New System.Exception(" ")
            Else
                _Entidad.Scta = value
            End If
        End Set
    End Property

    Public Property CuentaSS() As String
        Get
            Return _Entidad.Sscta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("CuentaSS", "Debe ingresar una Cuenta SS")
                Throw New System.Exception(" ")
            Else
                _Entidad.Sscta = value
            End If
        End Set
    End Property

    Public Property CuentaSSS() As String
        Get
            Return _Entidad.Ssscta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("CuentaSSS", "Debe ingresar una Cuenta SSS")
                Throw New System.Exception(" ")
            Else
                _Entidad.Ssscta = value
            End If
        End Set
    End Property

    Public Property DescripcionCuenta() As String
        Get
            Return _Entidad.DescripcionCuenta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("DescripcionCuenta", "Debe ingresar una Descripción de Cuenta")
                Throw New System.Exception(" ")
            Else
                _Entidad.DescripcionCuenta = value
            End If
        End Set
    End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return _Entidad.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            _Entidad.Estatus = value
        End Set
    End Property


    Public Property FechaAlta() As Date
        Get
            Return _Entidad.FechaAlta
        End Get
        Set(ByVal value As Date)
            _Entidad.FechaAlta = value
        End Set
    End Property

    Public Property IDUsuarioAlta() As Integer
        Get
            Return _Entidad.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            _Entidad.UsuarioAlta = value
        End Set
    End Property

    Public Property FechaBaja() As Date
        Get
            Return _Entidad.FechaBaja
        End Get
        Set(ByVal value As Date)
            _Entidad.FechaBaja = value
        End Set
    End Property

    Public Property IDUsuarioBaja() As Integer
        Get
            Return _Entidad.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            _Entidad.UsuarioBaja = value
        End Set
    End Property

    Public Property MotivoBaja() As Integer
        Get
            Return _Entidad.MotivoBaja
        End Get
        Set(ByVal value As Integer)
            _Entidad.MotivoBaja = value
        End Set
    End Property

    Public Property ObservacionesBaja() As String
        Get
            Return _Entidad.ObservacionBaja
        End Get
        Set(ByVal value As String)
            _Entidad.ObservacionBaja = value
        End Set
    End Property

    Public Property IsNew() As Boolean
        Get
            Return _Entidad.IsNew
        End Get
        Set(ByVal value As Boolean)
            _Entidad.IsNew = value
        End Set
    End Property


    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            _Entidad.Estatus = EstatusEnum.INACTIVO
            If _Entidad.Save() Then
                Return True
            Else
                RaiseEvent MensajeError(Me, "No se logró dar de baja, intente de nuevo")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se logró dar de baja, intente de nuevo")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            'coleccion para ralisar las validaciones 
            Dim col As New CC.CostoIndirectoCollection
            If Me.IsNew Then
                'Me.ValidarDisponibilidad()
                Select Case Me.ValidarDisponibilidad
                    Case 0
                        MsgBox("La Descripción no esta disponible...", MsgBoxStyle.Exclamation, "Aviso")
                    Case 1
                        MsgBox("La Descripción Corta no esta disponible...", MsgBoxStyle.Exclamation, "Aviso")
                    Case 2
                        MsgBox("La Cuenta Contable no esta disponible...", MsgBoxStyle.Exclamation, "Aviso")
                    Case 3
                        'guarda y valida si se guardo
                        If _Entidad.Save Then
                            Return True
                        Else
                            RaiseEvent MensajeError(Me, "No se logro guardar, intente de nuevo")
                            Return False
                        End If
                End Select
            Else
                'Editar
                If (Me.ValidarModificar()) Then
                    If _Entidad.Save() Then
                        Return True
                    Else
                        RaiseEvent MensajeError(Me, "No se logro guardar, intente de nuevo")
                        Return False
                    End If
                End If
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function


    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If _Entidad.FetchUsingPK(Codigo) Then
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Costo Indirecto especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function



    Private Function ValidarCuentaContable() As Boolean
        'VALIDA CUENTA MAYOR
        Select Case Me.CuentaMayor.Length
            Case 0
                MsgBox("Debe ingresar digitos...", MsgBoxStyle.Information, "Aviso")
            Case 1
                Me.CuentaMayor = "000" & CuentaMayor
            Case 2
                Me.CuentaMayor = "00" & CuentaMayor
            Case 3
                Me.CuentaMayor = "0" & CuentaMayor
        End Select
        'VALIDA CUENTA S
        Select Case Me.CuentaS.Length
            Case 0
                MsgBox("Debe ingresar digitos...", MsgBoxStyle.Information, "Aviso")
            Case 1
                Me.CuentaS = "000" & CuentaS
            Case 2
                Me.CuentaS = "00" & CuentaS
            Case 3
                Me.CuentaS = "0" & CuentaS
        End Select
        'VALIDA CUENTA SS
        Select Case Me.CuentaSS.Length
            Case 0
                MsgBox("Debe ingresar digitos...", MsgBoxStyle.Information, "Aviso")
            Case 1
                Me.CuentaSS = "000" & CuentaSS
            Case 2
                Me.CuentaSS = "00" & CuentaSS
            Case 3
                Me.CuentaSS = "0" & CuentaSS
        End Select
        'VALIDA CUENTA SSS
        Select Case Me.CuentaSSS.Length
            Case 0
                MsgBox("Debe ingresar digitos...", MsgBoxStyle.Information, "Aviso")
            Case 1
                Me.CuentaSSS = "000" & CuentaSSS
            Case 2
                Me.CuentaSSS = "00" & CuentaSSS
            Case 3
                Me.CuentaSSS = "0" & CuentaSSS
        End Select
    End Function


    Private Function ValidarDisponibilidad() As Integer
        Dim cos As New CC.CostoIndirectoCollection

        If cos.GetDbCount(HC.CostoIndirectoFields.Descripcion = Descripcion) > 0 Then
            Return 0
        End If
        If cos.GetDbCount(HC.CostoIndirectoFields.DescripcionCorta = DescripcionCorta) Then
            Return 1
        End If
        If cos.GetDbCount(HC.CostoIndirectoFields.CtaMayor = CuentaMayor And HC.CostoIndirectoFields.Scta = CuentaS _
                And HC.CostoIndirectoFields.Sscta = CuentaSS And HC.CostoIndirectoFields.Ssscta = CuentaSSS) Then
            Return 2
        End If
        Return 3
    End Function

    Private Function ValidarModificar() As Boolean
        Dim cos As New CC.CostoIndirectoCollection
        Dim filtro As New OC.PredicateExpression
        Dim mensaje As String = ""

        filtro.Add(Not HC.CostoIndirectoFields.Codigo = Me.IDCostosIndirectos)
        filtro.Add(HC.CostoIndirectoFields.DescripcionCorta = Me.DescripcionCorta)
        If cos.GetDbCount(filtro) > 0 Then mensaje &= "No esta disponible la Descripcion Corta..." & Chr(13)

        filtro = New OC.PredicateExpression

        filtro.Add(Not HC.CostoIndirectoFields.Codigo = Me.IDCostosIndirectos)
        filtro.Add(HC.CostoIndirectoFields.Descripcion = Me.Descripcion)
        If cos.GetDbCount(filtro) > 0 Then mensaje &= "No esta disponible la Descripción..." & Chr(13)

        filtro = New OC.PredicateExpression

        filtro.Add(Not HC.CostoIndirectoFields.Codigo = Me.IDCostosIndirectos)
        filtro.Add(HC.CostoIndirectoFields.CtaMayor = Me.CuentaMayor And HC.CostoIndirectoFields.Scta = Me.CuentaS And _
        HC.CostoIndirectoFields.Sscta = Me.CuentaSS And HC.CostoIndirectoFields.Ssscta = Me.CuentaSSS)
        If cos.GetDbCount(filtro) > 0 Then mensaje &= "No esta disponible la Cuenta Contable..." & Chr(13)

        If mensaje = "" Then
            Return True
        Else
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If
    End Function

    Private Function ValidarGuardar() As Boolean
        Dim mensaje As String = ValidarDisponibilidad()
        ValidarCuentaContable()

        If Not mensaje = "" Then
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ValidarBorrar() As Boolean
        Dim procosd As New CC.ProductoCostoIndirectoCollection

        procosd.GetMulti(HC.ProductoCostoIndirectoFields.CodigoCostoIndirecto = Me.IDCostosIndirectos)

        For Each ent As EC.ProductoCostoIndirectoEntity In procosd
            If ent.Producto.Estatus Then
                MsgBox("No se puede dar de baja el Costo Directo, por que hay Productos Activos que dependen de el...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Next
        Return True
    End Function




    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Function ObtenerEntidad() As EC.CostoIndirectoEntity
        Return Me._Entidad
    End Function

    Public Sub LeerEntidad(ByVal entidad As EC.CostoIndirectoEntity)
        _Entidad = entidad
    End Sub

    Sub New()
        _Entidad = New EC.CostoIndirectoEntity
        _Entidad.UsuarioAlta = 0
        _Entidad.FechaAlta = Now
        _Entidad.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal IdCostosIndirecto As Integer)
        _Entidad = New EC.CostoIndirectoEntity(IdCostosIndirecto)
        IsNew = False
    End Sub

    Public Shared Function OptenerLista(ByVal condicion As CondicionEnum) As DataTable
        Select Case condicion
            Case CondicionEnum.TODOS
                Return CC.CostoIndirectoCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Case Else
                Return CC.CostoIndirectoCollection.GetMultiAsDataTable(HC.CostoIndirectoFields.Estatus = condicion, 0, Nothing)
        End Select
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class