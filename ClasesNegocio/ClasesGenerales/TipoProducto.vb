Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class TipoProductoClass
    Implements IEntidad


    Private _Entidad As New EC.TipoProductoEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public ReadOnly Property Codigo() As Integer
        Get
            Return _Entidad.Codigo
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return _Entidad.Descripcion
        End Get
        Set(ByVal value As String)
            _Entidad.Descripcion = value
        End Set
    End Property

    Public Property DescripcionCorta() As String
        Get
            Return _Entidad.DescripcionCorta
        End Get
        Set(ByVal value As String)
            _Entidad.DescripcionCorta = value
        End Set
    End Property

    Public Property SeVende() As Boolean
        Get
            Return _Entidad.Venta
        End Get
        Set(ByVal value As Boolean)
            _Entidad.Venta = value
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

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            _Entidad.Estatus = EstatusEnum.INACTIVO
            If _Entidad.Save Then
                Return True
            Else
                RaiseEvent MensajeError(Me, "No se logró dar de baja, intente de nuevo.")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se logró dar de baja, intente de nuevo.")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Try
            If _Entidad.IsNew Then
                Estatus = EstatusEnum.ACTIVO
                'coleccion para realizar busquedas para validar nombre y nombrecorto
                Dim col As New CC.TipoProductoCollection

                'valida que no haya ningun nombre = al que se desea guardar
                If col.GetDbCount(HC.TipoProductoFields.Descripcion = Descripcion) > 0 Then
                    RaiseEvent MensajeError("Nombre", "El Nombre ya existe, ingrese otro")
                    Return False
                End If
                'valida que no haya ningun nombrecorto = al que se desea guardar
                If col.GetDbCount(HC.TipoProductoFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    RaiseEvent MensajeError("NombreCorto", "El Nombre Corto ya existe, ingrese otro")
                    Return False
                End If

                'guarda y valida si se a guardado
                If _Entidad.Save Then
                    Return True
                Else
                    RaiseEvent MensajeError(Me, "No se logro guardar, intente de nuevo")
                    Return False
                End If
                'si no es nueva
            Else
                'coleccion para ralisar las validaciones 
                Dim col As New CC.TipoProductoCollection

                'valida que no haya ningun nombre = al que se desa guardar descartando
                'al que ya tiene la familia que se esta modificando
                If col.GetDbCount(Not HC.TipoProductoFields.Codigo = Codigo And HC.TipoProductoFields.Descripcion = Descripcion) > 0 Then
                    RaiseEvent MensajeError("Nombre", "El Nombre ya existe, ingrese otro")
                    Return False
                End If

                'valida que no haya ningun nombrecorto = al que se desa guardar descartando
                'al que ya tiene la familia que se esta modificando
                If col.GetDbCount(Not HC.TipoProductoFields.Codigo = Codigo And HC.TipoProductoFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    RaiseEvent MensajeError("NombreCorto", "El Nombre Corto ya existe, ingrese otro")
                    Return False
                End If

                'guarda y valida si se guardo
                If _Entidad.Save Then
                    Return True
                Else
                    RaiseEvent MensajeError(Me, "No se logro guardar, intente de nuevo")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If _Entidad.FetchUsingPK(Codigo) Then
                Return True
            End If
            RaiseEvent MensajeError(Me, "El Tipo de Producto especificado no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal entidad As EC.TipoProductoEntity)
        _Entidad = entidad
    End Sub

    Public Function ObtenerEntidad() As EC.TipoProductoEntity
        Return Me._Entidad
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class TipoProductoCollectionClass
    Inherits CollectionClass(Of TipoProductoClass)

    Private Col As New CC.TipoProductoCollection

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.Clear()

            If FcCondicion = CondicionEnum.Todos Then
                Col.GetMulti(Nothing)
            Else
                Col.GetMulti(HC.TipoProductoFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Col.Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Nombre As Integer, ByVal NombreCorto As Integer, Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.Clear()

            Dim filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.Todos Then
                filtro.Add(HC.TipoProductoFields.Estatus = FcCondicion)
            End If

            filtro.Add(HC.TipoProductoFields.Descripcion Mod String.Format("%{0}%", Nombre))
            filtro.Add(HC.TipoProductoFields.DescripcionCorta Mod String.Format("%{0}%", NombreCorto))

            Col.GetMulti(filtro)

            Rellenar()

            Return Col.Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Private Sub Rellenar()
        For Each ente As EC.TipoProductoEntity In col
            Dim tipo As New TipoProductoClass
            tipo.LeerEntidad(ente)
            Add(tipo)
        Next
    End Sub

End Class
