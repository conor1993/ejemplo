Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = Integralab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports System.Data.SqlClient
Imports AlmacenGeneral
Imports ClasesNegocio.AlmacenGeneral

Public Class AlmacenClass
    Implements IEntidad

    Private entidad As EC.AlmacenEntity
    Private _plaza As New PlazaClass
    Private _tipoAlmacen As New TipoAlmacenClass
    Private _almacen As AlmacenClass
    Private _CuentaContable As CuentaContableClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private CodigoRetorno As Integer
    Private _InventarioProductosGenerales As InventarioAlmacenCollectionClass
    Private _ProductosConExistencia As ProductoCollectionClass
    Private _Familias As LineaCollectionClass

#Region "Propiedades"

    <ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return entidad.AlmacenId
        End Get
    End Property

    <ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return entidad.Descripcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Descripcion", "Debe ingresar una Descripción")
                Throw New System.Exception(" ")
            Else
                entidad.Descripcion = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return entidad.DescripcionCorta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("DescripcionCorta", "Debe ingresar una Descripción Corta")
                Throw New System.Exception(" ")
            Else
                entidad.DescripcionCorta = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaAlta() As Date
        Get
            Return entidad.FechaAlta
        End Get
        Set(ByVal value As Date)
            entidad.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property FechaBaja() As Date
        Get
            Return entidad.FechaBaja.GetValueOrDefault(#1/1/1990#)
        End Get
        Set(ByVal value As Date)
            entidad.FechaBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property UsuarioAlta() As Integer
        Get
            Return entidad.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                RaiseEvent MensajeError("UsuarioAlta", "Debe Ingresar un Usuario de Alta")
            Else
                entidad.UsuarioAlta = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    Public Property UsuarioBaja() As Integer
        Get
            Return entidad.UsuarioBaja.GetValueOrDefault(0)
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                RaiseEvent MensajeError("UsuarioBaja", "Debe Ingresar un Usuario de Baja")
            Else
                entidad.UsuarioBaja = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return entidad.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            entidad.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property TipoAlmacen() As TipoAlmacenClass
        Get
            _tipoAlmacen.LeerEntidad(entidad.TipoAlmacen_)
            Return _tipoAlmacen
        End Get
        Set(ByVal value As TipoAlmacenClass)
            If IsNothing(value) Then
                RaiseEvent MensajeError("TipoAlmacen", "Debe ingresar un tipo de almacen")
                Throw New System.Exception(" ")
            Else
                entidad.TipoAlmacen_ = value.ObtenerEntidad
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    Public Property Almacen() As AlmacenClass
        Get
            If _almacen Is Nothing Then
                _almacen = New AlmacenClass
            End If
            _almacen.LeerEntidad(entidad.Almacen_)
            Return _almacen
        End Get
        Set(ByVal value As AlmacenClass)
            If Not IsNothing(value) Then
                entidad.Almacen_ = value.ObtenerEntidad
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    Public Property Letras() As String
        Get
            Return entidad.Letra
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Letras", "Debe ingresar una letra")
                Throw New System.Exception(" ")
            Else
                entidad.Letra = value

                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    Public Property Plaza() As PlazaClass
        Get
            _plaza.LeerEntidad(entidad.Plaza_)
            Return _plaza
        End Get
        Set(ByVal value As PlazaClass)
            entidad.Plaza_ = value.ObtenerEntidad
        End Set
    End Property


    Public Property CuentaContableId() As Integer
        Get
            Return Me.entidad.IdCuentaContable.GetValueOrDefault(-1)
        End Get
        Set(ByVal value As Integer)
            Me.entidad.IdCuentaContable = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get
            If Me._CuentaContable Is Nothing Then
                Me._CuentaContable = New CuentaContableClass
                Me._CuentaContable.LeerEntidad(Me.entidad.CuentaContable)
            End If

            Return Me._CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            Me._CuentaContable = value

            If value Is Nothing Then
                entidad.CuentaContable = Nothing
            Else
                entidad.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property TipoProducto() As TipoProductoAlmacen
        Get
            Return entidad.TipoProducto
        End Get
        Set(ByVal value As TipoProductoAlmacen)
            entidad.TipoProducto = value
        End Set
    End Property

    Public Property Terceros() As Boolean
        Get
            Return entidad.Tercero
        End Get
        Set(ByVal value As Boolean)
            entidad.Tercero = value
        End Set
    End Property

    Public Property IdCliente() As Integer
        Get
            Return entidad.IdCliente
        End Get
        Set(ByVal value As Integer)
            entidad.IdCliente = value
        End Set
    End Property

    Public ReadOnly Property Familias() As LineaCollectionClass
        Get
            If _Familias Is Nothing Then
                _Familias = New LineaCollectionClass(Me.entidad.LineaCollectionViaAlmacenesFamilias)
            End If
            Return _Familias
        End Get
    End Property

    Public ReadOnly Property InventarioProductosGenerales() As InventarioAlmacenCollectionClass
        Get
            If _InventarioProductosGenerales Is Nothing Then
                Dim Filtro As New OC.PredicateExpression(HC.InventarioAlmacenFields.AlmacenId = Me.Codigo)
                Dim Orden As New OC.SortExpression(), Relacion As New OC.RelationCollection
                Dim Productos As New List(Of Integer)
                Dim ExistenciasAnteriores As New List(Of Integer)

                _InventarioProductosGenerales = New InventarioAlmacenCollectionClass()

                Relacion.Add(EC.InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
                Orden.Add(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                Orden.Add(New OC.SortClause(HC.InventarioAlmacenFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

                _InventarioProductosGenerales.Obtener(Filtro, Orden, Relacion)

                For i As Integer = 0 To _InventarioProductosGenerales.Count - 1
                    If Productos.Contains(_InventarioProductosGenerales(i).IdProducto) Then
                        ExistenciasAnteriores.Add(i)
                    Else
                        Productos.Add(_InventarioProductosGenerales(i).IdProducto)
                    End If
                Next

                For i As Integer = ExistenciasAnteriores.Count - 1 To 0 Step -1
                    _InventarioProductosGenerales.RemoveAt(ExistenciasAnteriores(i))
                Next
            End If
            Return _InventarioProductosGenerales
        End Get
    End Property

    Public ReadOnly Property ProductosConExistencia() As ProductoCollectionClass
        Get
            If _ProductosConExistencia Is Nothing Then
                _ProductosConExistencia = New ProductoCollectionClass

                For Each Inventario As InventarioAlmacenClass In Me.InventarioProductosGenerales
                    If Inventario.CantidadExistencia > 0 Then
                        _ProductosConExistencia.Add(CType(Inventario.Producto, ProductoGeneralClass))
                    End If
                Next
            End If
            Return _ProductosConExistencia
        End Get
    End Property

    Public ReadOnly Property CatalogoProductos() As ProductoCollectionClass
        Get
            Dim ListaFamilias As New List(Of Integer)
            Dim Productos As New ProductoCollectionClass
            Dim Filtro As New OC.PredicateExpression

            For Each Familia As LineaClass In Me.Familias
                ListaFamilias.Add(Familia.Codigo)
            Next

            If ListaFamilias.Count > 0 Then
                Filtro.Add(New OC.FieldCompareRangePredicate(HC.ProductoFields.PdIdLinea, ListaFamilias))
            End If
            Filtro.Add(HC.ProductoFields.Estatus = EstatusEnum.ACTIVO)
            Productos.Obtener(Filtro, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Return Productos
        End Get
    End Property

#Region "Propiedades Especiales"

    Public Property IdAlmacenRetorno() As Integer
        Get
            Return CodigoRetorno
        End Get
        Set(ByVal value As Integer)
            CodigoRetorno = value
        End Set
    End Property

#End Region

#End Region

    Public Sub ActualizarInventarioProductosGenerales()
        _InventarioProductosGenerales = Nothing
    End Sub

    Public Sub ActualizarProductosConExistencia()
        _ProductosConExistencia = Nothing
    End Sub

    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.AlmacenCollection
            Dim letrasT As String = "abcdefghijklmnñopqrstuvwxyz"
            If Letras = "" Or Letras.Length = 0 Then
                For i As Integer = 0 To Len(letrasT) - 1
                    If col.GetDbCount(HC.AlmacenFields.Letra = letrasT(i)) = 0 Then
                        Letras = letrasT(i).ToString.ToUpper
                        Exit For
                    End If
                Next
            End If


            If entidad.IsNew Then
                'enviar codigo con valor = -1 para obligar al procedimiento a que agregue un nuevo almacen
                'no se utilizo 0 por que peude existir un registro 0


                If SPA.UspMcatAlmacenesIns(-1, Descripcion, DescripcionCorta, TipoAlmacen.Codigo, _
                                        entidad.AlmacenId, Estatus, Now, UsuarioAlta, FechaBaja, _
                                        UsuarioBaja, Plaza.Codigo, Letras, IIf(Me.CuentaContableId = -1, Nothing, Me.CuentaContableId), entidad.TipoProducto, Terceros, IdCliente, IdAlmacenRetorno) > 0 Then
                    IdAlmacenRetorno = CodigoRetorno
                    Return True
                Else
                    MsgBox("No se logro guardar el Almacen, Intente de nuevo...", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                'en el caso que se requiera actualizar un registro solo envie el codigo del almacen que
                'desea hacerle modificaciones
                If SPA.UspMcatAlmacenesIns(Codigo, Descripcion, DescripcionCorta, TipoAlmacen.Codigo, _
                                                        entidad.AlmacenId, Estatus, FechaAlta, UsuarioAlta, FechaBaja, _
                                                        UsuarioBaja, Plaza.Codigo, Letras, IIf(Me.CuentaContableId = -1, Nothing, Me.CuentaContableId), entidad.TipoProducto, Terceros, IdCliente, IdAlmacenRetorno) > 0 Then

                    Return True
                Else
                    MsgBox("No se logro guardar el Almacen, Intente de nuevo...", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Estatus = EstatusEnum.INACTIVO
            FechaBaja = Now
            If Guardar() Then
                Return True
            Else
                RaiseEvent MensajeError(Me, "No se logro dar de baja, intente nuevamente...")
                Return False
            End If


            'Dim col As New CC.AlmacenCollection


            'If SPA.UspMcatAlmacenesIns(Codigo, Descripcion, DescripcionCorta, TipoAlmacen.Codigo, Almacen.Codigo, Estatus, FechaAlta, UsuarioAlta, FechaBaja, UsuarioBaja, Plaza.Codigo, Letras, Me.CuentaContableId, TipoProducto, Terceros, IdCliente, IdAlmacenRetorno) > 0 Then
            '    Return True
            'Else
            '    RaiseEvent MensajeError(Me, "No se logro dar de baja, intente nuevamente...")
            '    Return False
            'End If
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "Se produjo un Error al dar de baja, intente nuevamente...")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Return entidad.FetchUsingPK(Codigo)
        RaiseEvent Modificado(Me, New EventArgs)
    End Function

    Public Function ObtenerEntidad() As EC.AlmacenEntity
        Return entidad
    End Function

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        entidad = New EC.AlmacenEntity
        Estatus = EstatusEnum.ACTIVO
        ' entidad.AlmacenId = 0
        entidad.TipoAlmacen = 0
        entidad.UsuarioAlta = 0
        entidad.UsuarioBaja = 0
        entidad.FechaBaja = CDate("01/01/1990")
        entidad.FechaAlta = CDate("01/01/1990")
    End Sub

    Sub New(ByVal cod As Integer)
        entidad = New EC.AlmacenEntity(cod)
        entidad.IsNew = False
    End Sub

    Sub New(ByVal Entidad As Integralab.ORM.EntityClasses.AlmacenEntity)
        Me.entidad = Entidad
        Entidad.IsNew = False
    End Sub

    Public Sub LeerEntidad(ByVal fcentidad As EC.AlmacenEntity)
        Me.entidad = fcentidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class