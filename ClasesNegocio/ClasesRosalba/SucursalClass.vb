Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports Integralab.ORM.CollectionClasses

'' Relacionado a la tabla MCatGenSucursales
<ComponentModel.Bindable(True)> _
Public Class SucursalClass
    Inherits ClassBase(Of EC.SucursalEntity)

    Private _plaza As New PlazaClass
    Private _Inventario As New AlmacenGeneral.InventarioAlmacenCollectionClass
    Private _SerieFactura As FacturaFoliosClass


    <System.ComponentModel.DisplayName("Código Plaza")> _
    Public ReadOnly Property Plaza() As PlazaClass
        Get
            If _plaza Is Nothing OrElse _plaza.Codigo <> Me.IdPlaza Then
                _plaza = New PlazaClass(Entity.Plaza)
            End If
            Return _plaza
        End Get
    End Property

    <System.ComponentModel.DataObjectField(True)> _
    Public Property IdPlaza() As Integer
        Get
            Return Entity.CodigoPlaza
        End Get
        Set(ByVal value As Integer)
            Entity.CodigoPlaza = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código Sucursal")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescripcionCorta = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la serie
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Serie")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property Letra() As String
        Get
            Return Entity.Serie
        End Get
        Set(ByVal value As String)
            Entity.Serie = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha Alta")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha Alta Usurario")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property UsuarioAlta() As Integer
        Get
            Return Entity.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.UsuarioAlta = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha Baja")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Código Usuario Baja")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property UsuarioBaja() As Integer
        Get
            Return Entity.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            Entity.UsuarioBaja = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Motivo Baja")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property MotivoBaja() As Integer
        Get
            Return Entity.MotivoBaja
        End Get
        Set(ByVal value As Integer)
            Entity.MotivoBaja = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Observaciones Baja")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property ObservacionesBaja() As String
        Get
            Return Entity.ObservacionesBaja
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesBaja = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Id Serie Fact")> _
    <System.ComponentModel.DataObjectField(True)> _
    Public Property IdSerieFactura() As Integer
        Get
            Return Entity.ScidFolioFactura
        End Get
        Set(ByVal value As Integer)
            Entity.ScidFolioFactura = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Serie Factura")> _
    Public ReadOnly Property SerieFactura() As FacturaFoliosClass
        Get
            If _SerieFactura Is Nothing OrElse _SerieFactura.IdFacturaFolios <> Me.IdSerieFactura Then
                _SerieFactura = New FacturaFoliosClass(Entity.FacturaFolios)
            End If
            Return _SerieFactura
        End Get
    End Property

    <System.ComponentModel.DisplayName("Id almacen")> _
    Public ReadOnly Property IdAlmacen() As Integer
        Get
            Return Entity.ScidAlmacen
        End Get
    End Property

    Public ReadOnly Property Inventario(ByVal Almacen As AlmacenClass) As AlmacenGeneral.InventarioAlmacenCollectionClass
        Get
            _Inventario.Obtener(Almacen.Codigo)
            Return _Inventario
        End Get
    End Property

    Sub New()
        'Inicialización de todas las variables
        Entity = New EC.SucursalEntity
        Entity.CodigoPlaza = 0
        Entity.Descripcion = ""
        Entity.DescripcionCorta = ""
        Entity.Observaciones = ""
        Entity.UsuarioAlta = 0
        Entity.FechaBaja = New Date(1900, 1, 1)
        Entity.UsuarioBaja = 0
        Entity.MotivoBaja = 0
        Entity.MotivoBaja = 0
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Ent As Integralab.ORM.EntityClasses.SucursalEntity)
        Me.Entity = Ent
    End Sub

    Sub New(ByVal CodSucursal As Integer)
        Me.Entity = New EC.SucursalEntity(CodSucursal)
    End Sub

    Public Function Borrar() As Boolean
        Try
            Entity.Estatus = EstatusEnum.INACTIVO
            Return Entity.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return False
    End Function

    Public Function Guardar(Optional ByVal ApplicationName As String = "") As Boolean
        Try
            Dim col As New CC.SucursalCollection

            If Entity.IsNew Then

                If col.GetDbCount(HC.SucursalFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una sucursal con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.SucursalFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe una sucursal con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta")
                    Return False
                End If

                If ApplicationName.ToUpper() = "PUNTO DE VENTA" Then
                    ' Si la aplicación es el punto de venta
                    ' Verifica que haya un tipo de almacen llamado PUNTO DE VENTA, si no hay, lo crea
                    Dim TipoAlm As TipoAlmacenClass = Nothing
                    Dim TiposAlm As New TipoAlmacenCollectionClass()
                    TiposAlm.Obtener(CondicionEnum.ACTIVOS)
                    For Each tipo As TipoAlmacenClass In TiposAlm
                        If tipo.Descripcion = "PUNTO DE VENTA" Then
                            TipoAlm = tipo
                        End If
                    Next

                    If TipoAlm Is Nothing Then
                        TipoAlm = New TipoAlmacenClass()
                        TipoAlm.Descripcion = "PUNTO DE VENTA"
                        TipoAlm.DescripcionCorta = "PUNTO DE VENTA"
                        TipoAlm.SubAlmacen = TipoAlmacenEnum.ALMACEN
                        TipoAlm.DeProduccion = False
                        TipoAlm.Estatus = EstatusEnum.ACTIVO
                        TipoAlm.Guardar()
                    End If
                    '  crea un almacen para la sucursal
                    Dim Almacen As New AlmacenClass()
                    Almacen.Descripcion = Entity.Descripcion
                    Almacen.DescripcionCorta = Entity.DescripcionCorta
                    Almacen.TipoAlmacen = TipoAlm
                    Almacen.Estatus = EstatusEnum.ACTIVO
                    Almacen.TipoProducto = TipoProductoAlmacen.VENTA
                    Almacen.Plaza = New PlazaClass(Entity.Plaza)
                    Almacen.IdCliente = Nothing

                    If Not Almacen.Guardar() Then
                        Return False
                        'Else
                        '    Dim AlmacenesFamilias As New AlmacenesFamiliasCollection
                        '    AlmacenesFamilias.GetMulti(Nothing)
                        '    For Each Alcn As EC.AlmacenesFamiliasEntity In AlmacenesFamilias

                        '    Next
                        '    Dim Familias As New LineaCollection
                        '    Familias.GetMulti(Nothing)
                        '    For Each Familia As EC.LineaEntity In Familias
                        '        Dim AlmacenesFam As New AlmacenFamiliaClass
                        '        AlmacenesFam.AlmacenID = Almacen.Codigo
                        '        AlmacenesFam.FamiliaID = Familia.Codigo
                        '        If Not AlmacenesFam.Guardar() Then Return False
                        '    Next

                    End If

                    Entity.ScidAlmacen = Almacen.IdAlmacenRetorno
                Else
                    Entity.ScidAlmacen = 0
                End If
                Return Entity.Save
            Else
                If col.GetDbCount(Not HC.SucursalFields.Codigo = Codigo And HC.SucursalFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe una sucursal con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.SucursalFields.Codigo = Codigo And HC.SucursalFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe una sucursal con esa descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta")
                    Return False
                End If
                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal EntidadL As EC.SucursalEntity)
        Me.Entity = EntidadL
    End Sub

    Public Function ObtenerEntidad() As EC.SucursalEntity
        Return Me.Entity
    End Function

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function AgregarAlmacen(ByVal Almacen As AlmacenClass) As Boolean
        'Dim AlmSuc As New IntegraLab.ORM.EntityClasses.AlmacenSucursalEntity
        'AlmSuc.AlmacenId = Almacen.ObtenerEntidad
        'AlmSuc.SucursalId = sucursal
        'If sucursal.AlmacenSucursal.SaveMulti() > 0 Then Return True
        'Return False
    End Function

    Public Function QuitarAlmacen(ByVal Almacen As AlmacenClass) As Boolean
        'Dim tmp As IntegraLab.ORM.EntityClasses.AlmacenSucursalEntity
        'For Each AlmSuc As Integralab.ORM.EntityClasses.AlmacenSucursalEntity In sucursal.AlmacenSucursal
        '    If AlmSuc.Almacen.AlmacenId = Almacen.ObtenerEntidad.AlmacenId Then
        '        tmp = AlmSuc
        '        Exit For
        '    End If
        'Next
        'If Not IsNothing(tmp) Then
        '    tmp.Delete()
        '    Return True
        'End If
        'Return False
    End Function

    Public Function AgregarUsuario(ByVal Usuario As UsuarioClass) As Boolean
        'Dim UsuSuc As New Integralab.ORM.EntityClasses.UsuarioEntity
        'UsuSuc.Usrndx = Usuario.Obtener
        'UsuSuc.Usrndx = sucursal
        'If sucursal.UsuariosSucursal.SaveMulti() > 0 Then Return True
        'Return False
    End Function

    Public Function QuitarUsuario(ByVal Usuario As UsuarioClass) As Boolean
        'Dim tmp As IntegraLab.ORM.EntityClasses.UsuarioSucursalEntity
        'For Each UsuSuc As IntegraLab.ORM.EntityClasses.UsuarioSucursalEntity In sucursal.UsuariosSucursal
        '    If UsuSuc.UsuarioId = Usuario.Codigo Then
        '        tmp = UsuSuc
        '        Exit For
        '    End If
        'Next
        'If Not IsNothing(tmp) Then
        '    tmp.Delete()
        '    Return True
        'End If
        'Return False
    End Function

End Class