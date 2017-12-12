Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ComisionistaClass
    Inherits ClassBase(Of EC.ComicionistaEntity)

    Private ComicionistaCollection As New CC.ComicionistaCollection
    Private _poblacion As PoblacionClass
    Private _Zona As ZonaClass
    Private _plaza As PlazaClass
    Private _TipoComisionista As TipoComisionistaClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        Me.Entidad = New EC.ComicionistaEntity
        _poblacion = New PoblacionClass
        _TipoComisionista = New TipoComisionistaClass
        _zona = New ZonaClass
        _plaza = New PlazaClass
        Me.Entidad.Nombre = ""
        Me.Entidad.Apaterno = ""
        Me.Entidad.Amaterno = ""
        Me.Entidad.Estatus = EstatusCotizacionEnum.EN_VENTA
        Me.Entidad.Plaza = 0
        Me.Entidad.Domicilio = ""
        Me.Entidad.TipoComisionista = 0
        Me.Entidad.Colonia = ""
        Me.Entidad.CodigoPostal = 0
        Me.Entidad.Email = ""
        Me.Entidad.Poblacion = 0
        Me.Entidad.LadaTel1 = 0
        Me.Entidad.LadaTel2 = 0
        Me.Entidad.LadaFax = 0
        Me.Entidad.Telefono1 = 0
        Me.Entidad.Telefono2 = 0
        Me.Entidad.Fax = 0
        Me.Entidad.Rfc = ""
        Me.Entidad.Zona = 0
    End Sub

#Region "Propiedades"

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum ' Implements IEntidad.Estatus
        Get
            Return Me.Entidad.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Me.Entidad.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return Me.Entidad.Codigo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Nombre")> _
    Public Property Nombre() As String
        Get
            Return Me.Entidad.Nombre
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Nombre", "Debe ingresar un Nombre")
                Throw New SystemException(" ")
            Else
                Me.Entidad.Nombre = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Apellido Paterno")> _
    Public Property Apaterno() As String
        Get
            Return Me.Entidad.Apaterno
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Apaterno", "Debe ingresar un Apellido Paterno")
                Throw New SystemException(" ")
            Else
                Me.Entidad.Apaterno = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Apellido Materno")> _
    Public Property Amaterno() As String
        Get
            Return Me.Entidad.Amaterno
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Amaterno", "Debe ingresar un Apellido Materno")
                Throw New SystemException(" ")
            Else
                Me.Entidad.Amaterno = value
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
            Me._plaza.LeerEntidad(Me.Entidad.Plaza_)
            Return Me._plaza
        End Get
        Set(ByVal value As PlazaClass)
            If value Is Nothing Then
                RaiseEvent MensajeError("Plaza", "Debe ingresar una plaza")
                Throw New SystemException(" ")
            Else
                Me.Entidad.Plaza_ = value.ObtenerEntidad
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Domicilio")> _
    Public Property Domicilio() As String
        Get
            Return Me.Entidad.Domicilio
        End Get
        Set(ByVal value As String)
            Me.Entidad.Domicilio = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Tipo de Comicionista")> _
    Public Property TipoComicionista() As TipoComisionistaClass
        Get
            Me._TipoComisionista.LeerEntidad(Me.Entidad.TipoComicionista_)
            Return _TipoComisionista
        End Get
        Set(ByVal value As TipoComisionistaClass)
            Me.Entidad.TipoComicionista_ = value.ObtenerEntidad
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Colonia")> _
    Public Property Colonia() As String
        Get
            Return Me.Entidad.Colonia
        End Get
        Set(ByVal value As String)
            Me.Entidad.Colonia = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código Postal")> _
    Public Property CodigoPostal() As Integer
        Get
            Return Me.Entidad.CodigoPostal
        End Get
        Set(ByVal value As Integer)
            Me.Entidad.CodigoPostal = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("E-mail")> _
    Public Property Email() As String
        Get
            Return Me.Entidad.Email
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Email", "Debe ingresar un Email")
                Throw New SystemException(" ")
            Else
                Me.Entidad.Email = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <System.ComponentModel.DisplayName("Población")> _
    Public Property Poblacion() As PoblacionClass
        Get
            Me._poblacion = New PoblacionClass(Entity.Estado, Entity.Ciudad, Entity.Poblacion)
            Return _poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            Me.Entidad.Poblacion = value.ObtenerEntidad.Codigo
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property Lada() As String
        Get
            Return Me.Entidad.LadaTel1
        End Get
        Set(ByVal value As String)
            Me.Entidad.LadaTel1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property Lada1() As String
        Get
            Return Me.Entidad.LadaTel2
        End Get
        Set(ByVal value As String)
            Me.Entidad.LadaTel2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Lada")> _
    Public Property Lada2() As String
        Get
            Return Me.Entidad.LadaFax
        End Get
        Set(ByVal value As String)
            Me.Entidad.LadaFax = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono() As String
        Get
            Return Me.Entidad.Telefono1
        End Get
        Set(ByVal value As String)
            Me.Entidad.Telefono1 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Telefono")> _
    Public Property Telefono1() As String
        Get
            Return Me.Entidad.Telefono2
        End Get
        Set(ByVal value As String)
            Me.Entidad.Telefono2 = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fax")> _
    Public Property Fax() As String
        Get
            Return Me.Entidad.Fax
        End Get
        Set(ByVal value As String)
            Me.Entidad.Fax = value
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
            If _Zona Is Nothing OrElse Me.IdZona.HasValue AndAlso _Zona.Codigo <> Me.IdZona.Value Then
                _Zona = New ZonaClass()
                Return Me._Zona
            End If
            Return _Zona
        End Get
    End Property

    <System.ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaAlta() As Date
        Get
            Return Me.Entidad.FechaAlta
        End Get
        Set(ByVal value As Date)
            Me.Entidad.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("RFC")> _
    Public Property Rfc() As String
        Get
            Return Me.Entidad.Rfc
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                RaiseEvent MensajeError("Rfc", "Debe ingresar un Rfc")
                Throw New SystemException(" ")
            Else
                Me.Entidad.Rfc = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

#End Region

    Public Shadows Function Borrar() As Boolean ' Implements IEntidad.Borrar
        Try
            Me.Entidad.Estatus = EstatusEnum.INACTIVO
            If Me.Entidad.Save() Then
                Return True
            Else
                MsgBox("No a sido dado de baja, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Shadows Function Guardar() As Boolean
        Try
            If Me.Entidad.IsNew Then
                Dim col As New CC.ComicionistaCollection

                If col.GetDbCount(HC.ComicionistaFields.Rfc = Rfc) > 0 Then
                    MsgBox("Ya exite un comicionista con el mismo RFC", MsgBoxStyle.Exclamation, "RFC Repetido")
                    Return False
                End If

                If Me.Entidad.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                Dim col As New CC.ComicionistaCollection

                If col.GetDbCount(Not HC.ComicionistaFields.Codigo = Codigo And HC.ComicionistaFields.Rfc = Rfc) > 0 Then
                    MsgBox("Ya exite un comicionista con el mismo RFC", MsgBoxStyle.Exclamation, "RFC Repetido")
                    Return False
                End If

                If Me.Entidad.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean ' Implements IEntidad.Obtener
        Try
            If Me.Entidad.FetchUsingPK(Codigo) Then
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

    Public Shared Function CargarComisionista(ByVal IdComisionista As Integer) As ComisionistaClass
        Dim Comisionista As New ComisionistaClass()
        Comisionista.Obtener(IdComisionista)
        Return Comisionista
    End Function
End Class

Public Class ComisionistaCollectionClass
    Inherits ColleccionBase(Of EC.ComicionistaEntity, CC.ComicionistaCollection, ComisionistaClass)

    'Private WithEvents Coleccion As New CC.ComicionistaCollection
    'Private Filtro As OC.PredicateExpression
    'Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Overloads Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.TODOS Then filtro.Add(HC.ComicionistaFields.Estatus = FcCondicion)

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Comicionista As ComisionistaClass) As Integer
        Try
            Return Obtener(HC.ComicionistaFields.Codigo = Comicionista.Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Nombre As String, ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, Optional ByVal Codigo As Integer = -1, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            If Codigo = -1 Then
                Filtro.Add(HC.ComicionistaFields.Nombre Mod String.Format("%{0}%", Nombre))
                Filtro.Add(HC.ComicionistaFields.Apaterno Mod String.Format("%{0}%", ApellidoPaterno))
                Filtro.Add(HC.ComicionistaFields.Amaterno Mod String.Format("%{0}%", ApellidoMaterno))
                If Not fccondicion = CondicionEnum.TODOS Then Filtro.Add(HC.ComicionistaFields.Estatus = fccondicion)
            Else
                Filtro.Add(HC.ComicionistaFields.Codigo = Codigo)
            End If

            Return Obtener(Filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CrepComisionista
        Dim Reportes As New CrepComisionista
        Dim ds As New DataSet
        Dim dcom As New DSetComisionista.DtComisionistaDataTable

        For Each com As ComisionistaClass In Me
            dcom.AddDtComisionistaRow(com.Codigo, com.Nombre, com.Apaterno, com.Amaterno, com.Domicilio, com.Colonia, com.Lada, com.Telefono, com.Rfc, com.Plaza.Descripcion, com.Email, com.Estatus.ToString)
        Next
        ds.Tables.Add(dcom)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Catalogos/Ventas/Vendedores")
        'Reportes.SetParameterValue("empresa", empresa)
        Return Reportes
    End Function

    Public Shared Function CargarComisionistas(Optional ByVal Filtro As OC.IPredicate = Nothing) As ComisionistaCollectionClass
        Dim Comisionistas As New ComisionistaCollectionClass()
        Dim ColeccionEntity As New CC.ComicionistaCollection()
        Dim Ordenamiento As New OC.SortExpression()

        Ordenamiento.Add(New OC.SortClause(HC.ComicionistaFields.Nombre, OC.SortOperator.Ascending))
        Ordenamiento.Add(New OC.SortClause(HC.ComicionistaFields.Apaterno, OC.SortOperator.Ascending))
        Ordenamiento.Add(New OC.SortClause(HC.ComicionistaFields.Amaterno, OC.SortOperator.Ascending))

        Try
            ColeccionEntity.GetMulti(Filtro, 0, Ordenamiento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Comisionistas.RellenarMe(ColeccionEntity)
        Return Comisionistas
    End Function
End Class