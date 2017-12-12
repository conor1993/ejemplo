''Imports EC = IntegraLab.ORM.EntityClasses
''Imports CC = IntegraLab.ORM.CollectionClasses
''Imports HC = IntegraLab.ORM.HelperClasses
''Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
''Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures

''Public Class CotizacionClass
''    Implements IEntidad


''    Private WithEvents CotizacionEntity As EC.CotizacionEntity
''    Private CotizacionDetalles As CotizacionDetalleColleccionClass
''    Private WithEvents CotizacionDetalleEntity As New EC.CotizacionDetalleEntity
''    Private _plaza As PlazaClass
''    Private _Comisionista As ComisionistaClass
''    Private _Cliente As ClienteClass
''    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
''    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

''    Sub New()
''        AddHandler Modificado, AddressOf FueModificado
''        'Inicializacion de Todas las variables
''        CotizacionEntity = New EC.CotizacionEntity
''        _Cliente = New ClienteClass
''        _Comisionista = New ComisionistaClass
''        _plaza = New PlazaClass
''        CotizacionEntity.CodigoCliente = 0
''        CotizacionEntity.Descuento = 0
''        CotizacionEntity.DiasVigencia = 0
''        CotizacionEntity.Estatus = EstatusEnum.ACTIVO
''        CotizacionEntity.Observaciones = ""
''        CotizacionEntity.ObservacionesCancela = ""
''        CotizacionEntity.CodigoPlaza = 0
''        CotizacionEntity.SubTotal = 0
''        CotizacionEntity.Total = 0
''        CotizacionEntity.UsuarioElaboro = 0
''        CotizacionEntity.CodigoVendedor = 0
''        CotizacionEntity.Iva = 0
''    End Sub

''#Region "Constantes"
''    Const HSD As String = Chr(27) & Chr(35) & Chr(48)
''    Const NPP As String = Chr(27) & Chr(56)
''    Const CNA As String = Chr(15)
''    Const CND As String = Chr(18)
''    Const DWA As String = Chr(27) & Chr(87) & Chr(49)
''    Const DWD As String = Chr(27) & Chr(87) & Chr(48)
''#End Region

''#Region "PROPIEDADES"
''    <System.ComponentModel.DisplayName("Codigo")> _
''    Public ReadOnly Property codigo() As Integer
''        Get
''            Return CotizacionEntity.Codigo
''        End Get
''    End Property

''    <System.ComponentModel.DisplayName("Plaza")> _
''    Public Property Plaza() As PlazaClass
''        Get
''            If _plaza Is Nothing Then
''                _plaza = New PlazaClass
''            End If
''            _plaza.LeerEntidad(CotizacionEntity.Plaza)
''            Return _plaza
''        End Get
''        Set(ByVal value As PlazaClass)
''            _plaza = value
''            CotizacionEntity.Plaza = value.ObtenerEntidad
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Cliente")> _
''    Public Property Cliente() As ClienteClass
''        Get
''            If _Cliente Is Nothing Then
''                _Cliente = New ClienteClass
''            End If
''            _Cliente.LeerEntidad(CotizacionEntity.Cliente)
''            Return _Cliente
''        End Get
''        Set(ByVal value As ClienteClass)
''            _Cliente = value
''            CotizacionEntity.Cliente = value.ObtenerEntidad(0)
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Comisionista")> _
''Public Property Comicionista() As ComisionistaClass
''        Get
''            If _Comisionista Is Nothing Then
''                _Comisionista = New ComisionistaClass
''            End If
''            _Comisionista.LeerEntidad(CotizacionEntity.Comicionista)
''            Return _Comisionista
''        End Get
''        Set(ByVal value As ComisionistaClass)
''            _Comisionista = value
''            CotizacionEntity.Comicionista = value.ObtenerEntidad
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Vigencia")> _
''Public Property Vigencia() As Integer
''        Get
''            Return CotizacionEntity.DiasVigencia
''        End Get
''        Set(ByVal value As Integer)
''            CotizacionEntity.DiasVigencia = value
''            RaiseEvent Modificado(Me, New EventArgs)
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Fecha")> _
''    Public Property Fecha() As Date
''        Get
''            Return CotizacionEntity.FechaCotizacion
''        End Get
''        Set(ByVal value As Date)
''            CotizacionEntity.FechaCotizacion = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Estatus")> _
''    Private Property Estatus() As EstatusEnum Implements IEntidad.Estatus
''        Get
''            Return CotizacionEntity.Estatus
''        End Get
''        Set(ByVal value As EstatusEnum)
''            CotizacionEntity.Estatus = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Estatus")> _
''    Public Property EstatusCotizacion() As EstatusCotizacionEnum
''        Get
''            Return CotizacionEntity.Estatus
''        End Get
''        Set(ByVal value As EstatusCotizacionEnum)
''            CotizacionEntity.Estatus = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Descuento")> _
''    Public Property Descuento() As Decimal
''        Get
''            Return CotizacionEntity.Descuento
''        End Get
''        Set(ByVal value As Decimal)
''            CotizacionEntity.Descuento = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Iva")> _
''    Public Property Iva() As Decimal
''        Get
''            Return CotizacionEntity.Iva
''        End Get
''        Set(ByVal value As Decimal)
''            CotizacionEntity.Iva = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Total")> _
''    Public Property Total() As Decimal
''        Get
''            Return CotizacionEntity.Total
''        End Get
''        Set(ByVal value As Decimal)
''            CotizacionEntity.Total = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Subtotal")> _
''    Public Property Subtotal() As Decimal
''        Get
''            Return CotizacionEntity.SubTotal
''        End Get
''        Set(ByVal value As Decimal)
''            CotizacionEntity.SubTotal = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Observaciones")> _
''    Public Property Observaciones() As String
''        Get
''            Return CotizacionEntity.Observaciones
''        End Get
''        Set(ByVal value As String)
''            CotizacionEntity.Observaciones = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Detalles")> _
''    Public Property Detalles() As CotizacionDetalleColleccionClass
''        Get
''            If CotizacionDetalles Is Nothing Then
''                CotizacionDetalles = New CotizacionDetalleColleccionClass
''                CotizacionDetalles.RellenarMe(CotizacionEntity.CotizacionDetalle)
''            End If
''            Return CotizacionDetalles
''        End Get
''        Set(ByVal value As CotizacionDetalleColleccionClass)
''            CotizacionDetalles = value
''        End Set
''    End Property
''#End Region

''    Public Function Borrar() As Boolean Implements IEntidad.Borrar
''        Try
''            CotizacionEntity.Estatus = EstatusCotizacionEnum.INACTIVA
''            If CotizacionEntity.Save() Then Return True
''            RaiseEvent MensajeError(Me, "La Cotización no se pudo borrar.")
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''        End Try
''        Return False
''    End Function

''    Public Function Guardar() As Boolean
''        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cotizacion")
''        Try
''            If CotizacionEntity.IsNew Then
''                Me.EstatusCotizacion = EstatusCotizacionEnum.EN_VENTA
''                Dim col As New CC.CotizacionCollection
''                'trans.Add(CotizacionEntity)
''                If Not SPA.CotizacionIns(Plaza.Codigo, Cliente.Codigo, Me.Comicionista.Codigo, Me.Vigencia, Me.Subtotal, _
''                            Me.Descuento, Me.Iva, Me.Total, Me.Observaciones, Estatus, 0, Me.CotizacionEntity.Codigo, trans) = 0 Then
''                    Dim det As CC.CotizacionDetalleCollection
''                    det = Detalles.ObtenerColeccion

''                    trans.Add(det)

''                    For Each detcot As EC.CotizacionDetalleEntity In det
''                        detcot.CodigoCotizacion = codigo
''                    Next

''                    If det.SaveMulti > 0 Then
''                        trans.Commit()
''                        Return True
''                    Else
''                        trans.Rollback()
''                        MsgBox("La Cotización no pudo ser guardada.", MsgBoxStyle.Exclamation, "Aviso")
''                        Return False
''                    End If
''                Else
''                    trans.Rollback()
''                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
''                    Return False
''                End If
''            Else
''                'Estatus = EstatusEnum.Activo
''                Dim col As New CC.CotizacionCollection
''                trans.Add(CotizacionEntity)
''                If CotizacionEntity.Save() Then
''                    Dim det As CC.CotizacionDetalleCollection
''                    det = Detalles.ObtenerColeccion
''                    'Dim col2 As New CC.CotizacionDetalleCollection
''                    'Dim Encontro As Boolean = False
''                    'col2.GetMulti(HC.CotizacionDetalleFields.RcdidCotizacion = codigo)
''                    trans.Add(det)
''                    If det.Count > 0 Then
''                        If det.SaveMulti > 0 Then
''                            trans.Rollback()
''                            MsgBox("La Cotización no pudo ser guardada.", MsgBoxStyle.Exclamation, "Aviso")
''                            Return False
''                        End If
''                    End If

''REIMPRIMIR:

''                    If Imprimir() Then
''                        If System.Windows.Forms.MessageBox.Show("¿Se imprimio correctamente?", "Aviso", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
''                            trans.Commit()
''                            Return True
''                        Else
''                            GoTo REIMPRIMIR
''                        End If
''                    Else
''                        trans.Rollback()
''                        MsgBox("La Cotización no pudo ser guardada.", MsgBoxStyle.Exclamation, "Aviso")
''                        Return False
''                    End If
''                Else
''                    trans.Rollback()
''                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
''                    Return False
''                End If
''            End If
''        Catch ex As Exception
''            trans.Rollback()
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return False
''        End Try
''    End Function

''    Public Function Imprimir() As Boolean
''        Try
''            Dim imp As New EscritorClass(96, 65)

''            imp.Escribe(HSD & NPP & CNA, 1, 1)
''            imp.Escribe(String.Format(DWA & "COTIZACION" & DWD), 35, 2)
''            imp.Escribe(String.Format("FOLIO   : {0}", codigo), 1, 3)
''            imp.Escribe(String.Format("CLIENTE: {0}", Me.Cliente.NombreCompleto), 2, 7)
''            imp.Escribe(String.Format("DOMICILIO: {0}", Me.Cliente.Domicilio), 2, 8)
''            imp.Escribe(String.Format("TELEFONO: {0}", Me.Cliente.LadaTelefono1 & " " & Me.Cliente.Telefono1), 2, 9)
''            imp.Escribe(String.Format("TELEFONO: {0}", Now.ToString("dd/MM/yyyy hh:mm:ss tt")), 50, 7)
''            imp.Escribe(String.Format("COMISIONISTA: {0}", Me.Comicionista.NombreCompleto), 2, 9)
''            imp.Escribe(String.Format("Cantidad         Clave    Producto                     P. Unitario   Descuento     Importe"), 1, 11)

''            Dim i As Integer

''            For i = 12 To Me.Detalles.Count + 12 - 1
''                imp.Escribe(String.Format(Detalles(i - 12).cantidad.ToString("N3") & " " & Detalles(i - 12).Producto.UnidadMedida.DescCorta), 1, i)
''                imp.Escribe(String.Format(Detalles(i - 12).Producto.Codigo.ToString), 18, i)
''                imp.Escribe(String.Format(Detalles(i - 12).Producto.Descripcion.Trim), 27, i)
''                imp.Escribe(String.Format(Detalles(i - 12).PrecioVenta.ToString("C")), 56, i)
''                imp.Escribe(String.Format(Detalles(i - 12).Descuento.ToString("C")), 70, i)
''                imp.Escribe(String.Format(Detalles(i - 12).importe.ToString("C")), 84, i)
''            Next

''            imp.Escribe(String.Format("SUB-TOTAL: " & Me.Subtotal.ToString("C")), 70, i + 2)
''            imp.Escribe(String.Format("DESCUENTO: " & Me.Descuento.ToString("C")), 70, i + 3)
''            imp.Escribe(String.Format("IVA      : " & Me.Iva.ToString("C")), 70, i + 4)
''            imp.Escribe(String.Format("TOTAL    : " & Me.Total.ToString("C")), 70, i + 5)

''            imp.Imprime()
''            Return True
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return False
''        End Try
''    End Function

''    Public Function Obtener(ByVal codigo As Long) As Boolean
''        Try
''            If CotizacionEntity.FetchUsingPK(codigo) Then
''                CotizacionDetalles = New CotizacionDetalleColleccionClass
''                CotizacionDetalles.RellenarMe(CotizacionEntity.CotizacionDetalle)
''                RaiseEvent Modificado(Me, New EventArgs)
''                Return True
''            End If
''            RaiseEvent MensajeError(Me, "La Cotización especificada no existe.")
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''        End Try
''        Return False
''    End Function

''    Public Function ObtenerDetalles() As Boolean
''        Try
''            CotizacionDetalles.RellenarMe(CotizacionEntity.CotizacionDetalle)
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''        End Try
''        Return False
''    End Function

''    Public Overrides Function tostring() As String
''        Return Me.Comicionista.NombreCompleto
''    End Function

''    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

''    End Sub

''    Public Function ObtenerEntidad() As EC.CotizacionEntity
''        Return Me.CotizacionEntity
''    End Function

''    Public Sub LeerEntidad(ByVal Entidad As Object())
''        Me.CotizacionEntity = Entidad(0)
''    End Sub

''    Public Sub LeerEntidad(ByVal Entidad As EC.CotizacionEntity)
''        CotizacionEntity = Entidad
''    End Sub

''    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

''    End Function

''    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

''    End Function

''    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

''    End Function
''End Class

''Public Class CotizacionDetalleClass
''    Implements IEntidad


''    Private _Cotizacion As CotizacionClass
''    Private _producto As Productos
''    Private WithEvents CotizacionDetalleEntity As EC.CotizacionDetalleEntity
''    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
''    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

''    Sub New()
''        AddHandler Modificado, AddressOf FueModificado
''        'Inicializacion de Todas las variables
''        CotizacionDetalleEntity = New EC.CotizacionDetalleEntity
''        _Cotizacion = New CotizacionClass
''        CotizacionDetalleEntity.Estatus = EstatusEnum.ACTIVO
''        CotizacionDetalleEntity.Importe = 0
''        CotizacionDetalleEntity.PrecioVenta = 0
''        CotizacionDetalleEntity.Descuento = 0
''        CotizacionDetalleEntity.CodigoProducto = 0
''        CotizacionDetalleEntity.Cantidad = 0
''    End Sub

''#Region "PROPIEDADES"
''    <System.ComponentModel.DisplayName("Codigo")> _
''    Public ReadOnly Property Codigo() As Integer
''        Get
''            Return CotizacionDetalleEntity.Codigo
''        End Get
''    End Property

''    <System.ComponentModel.DisplayName("Cotizacion")> _
''        Public Property cotizacion() As CotizacionClass
''        Get
''            If _Cotizacion Is Nothing Then
''                _Cotizacion = New CotizacionClass
''            End If
''            _Cotizacion.LeerEntidad(CotizacionDetalleEntity.Cotizacion)
''            Return _Cotizacion
''        End Get
''        Set(ByVal value As CotizacionClass)
''            _Cotizacion = value
''            CotizacionDetalleEntity.Cotizacion = value.ObtenerEntidad
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Producto")> _
''   Public Property Producto() As Productos
''        Get
''            If _producto Is Nothing Then
''                _producto = New Productos
''                _producto.LeerEntidad(CotizacionDetalleEntity.Producto)
''            End If
''            Return _producto
''        End Get
''        Set(ByVal value As Productos)
''            _producto = value
''            CotizacionDetalleEntity.Producto = value.ObtenerEntidad
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Precio Venta")> _
''        Public Property PrecioVenta() As Decimal
''        Get
''            Return CotizacionDetalleEntity.PrecioVenta
''        End Get
''        Set(ByVal value As Decimal)
''            CotizacionDetalleEntity.PrecioVenta = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("cantidad")> _
''        Public Property cantidad() As Integer
''        Get
''            Return CotizacionDetalleEntity.Cantidad
''        End Get
''        Set(ByVal value As Integer)
''            CotizacionDetalleEntity.Cantidad = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Descuento")> _
''       Public Property Descuento() As Decimal
''        Get
''            Return CotizacionDetalleEntity.Descuento
''        End Get
''        Set(ByVal value As Decimal)
''            CotizacionDetalleEntity.Descuento = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Importe")> _
''    Public Property importe() As Decimal
''        Get
''            Return CotizacionDetalleEntity.Importe
''        End Get
''        Set(ByVal value As Decimal)
''            CotizacionDetalleEntity.Importe = value
''        End Set
''    End Property

''    <System.ComponentModel.DisplayName("Estatus")> _
''        Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
''        Get
''            Return CotizacionDetalleEntity.Estatus
''        End Get
''        Set(ByVal value As EstatusEnum)
''            CotizacionDetalleEntity.Estatus = value
''        End Set
''    End Property
''#End Region

''    Public Function Borrar() As Boolean Implements IEntidad.Borrar
''        Try
''            CotizacionDetalleEntity.Estatus = EstatusEnum.INACTIVO
''            If CotizacionDetalleEntity.Save() Then Return True
''            RaiseEvent MensajeError(Me, "El Detalle de la Cotización no se pudo borrar.")
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''        End Try
''        Return False
''    End Function

''    Public Function Guardar() As Boolean
''        Try
''            If CotizacionDetalleEntity.Save Then Return True
''            RaiseEvent MensajeError(Me, "El Detalle de la Cotización no se pudo guardar.")
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''        End Try
''        Return False
''    End Function

''    Public Function Obtener(ByVal codigo As Integer) As Boolean Implements IEntidad.Obtener
''        Try
''            If CotizacionDetalleEntity.FetchUsingPK(codigo) Then
''                RaiseEvent Modificado(Me, New EventArgs)
''                Return True
''            End If
''            RaiseEvent MensajeError(Me, "La Cotización especificada no existe.")
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''        End Try
''        Return False
''    End Function

''    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

''    End Sub

''    Public Function ObtenerEntidad() As EC.CotizacionDetalleEntity
''        Return Me.CotizacionDetalleEntity
''    End Function

''    Public Sub LeerEntidad(ByVal Entidad As EC.CotizacionDetalleEntity)
''        CotizacionDetalleEntity = Entidad
''    End Sub

''    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

''    End Function

''    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

''    End Function
''End Class

''Public Class CotizacionDetalleColleccionClass
''    Inherits CollectionClass(Of CotizacionDetalleClass)

''    Private Coleccion As New CC.CotizacionDetalleCollection
''    Public Event MensajeError As MensajeErrorHandler
''    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

''    Sub New()
''        MyBase.New()
''    End Sub

''    Public Function Obtener() As Integer
''        Try
''            Me.ClearItems()
''            Dim Conteo As Integer = Coleccion.GetDbCount()
''            If Conteo > 0 Then
''                Coleccion.GetMulti(Nothing)
''                Rellenar()
''            End If
''            Return Conteo
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal CotizacionDetalle As CotizacionDetalleClass) As Integer
''        Try
''            Me.ClearItems()
''            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
''            Filtro.Add(HC.CotizacionDetalleFields.CodigoCotizacion = CotizacionDetalle.cotizacion)
''            Dim Conteo As Integer = Coleccion.GetDbCount(Filtro)
''            If Conteo > 0 Then
''                Coleccion.GetMulti(Filtro)
''                Rellenar()
''            End If
''            Return Conteo
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''            Return -1
''        End Try
''    End Function

''    Public Function ObtenerColeccion() As CC.CotizacionDetalleCollection
''        RellenarColeccion()
''        Return Coleccion
''    End Function

''    Private Sub Rellenar()
''        For Each CotizacionDetalle As EC.CotizacionDetalleEntity In Coleccion
''            Dim miCotizacionD As New CotizacionDetalleClass
''            miCotizacionD.LeerEntidad(CotizacionDetalle)
''            Me.Add(miCotizacionD)
''        Next
''    End Sub

''    Public Sub RellenarMe(ByVal NuevaColeccion As CC.CotizacionDetalleCollection)
''        Me.Clear()
''        For Each CotizacionDetalle As EC.CotizacionDetalleEntity In NuevaColeccion
''            Dim miCotizacionD As New CotizacionDetalleClass
''            miCotizacionD.LeerEntidad(CotizacionDetalle)
''            Me.Add(miCotizacionD)
''        Next
''    End Sub

''    Private Sub RellenarColeccion()
''        Coleccion = New CC.CotizacionDetalleCollection
''        For Each CotizacionD As CotizacionDetalleClass In Me
''            Dim miCotizacionD As New EC.CotizacionDetalleEntity
''            miCotizacionD = CotizacionD.ObtenerEntidad
''            Coleccion.Add(miCotizacionD)
''        Next
''    End Sub

''    Public Function Existe(ByVal CotizacionDetalle As CotizacionDetalleClass) As Boolean
''        For Each entc As CotizacionDetalleClass In Me
''            If entc.Codigo = CotizacionDetalle.Codigo Then
''                Return True
''            End If
''        Next
''        Return False
''    End Function

''End Class

''Public Class CotizacionColleccionClass
''    Inherits CollectionClass(Of CotizacionClass)

''    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
''    Public Event MensajeError As MensajeErrorHandler
''    Private CotizacionCollection As New CC.CotizacionCollection
''    Private Coleccion As New CC.CotizacionCollection

''    Sub New()
''        MyBase.New()
''    End Sub

''    Public Function Obtener(Optional ByVal fcCondicion As CondicionCotizacionEnum = CondicionCotizacionEnum.TODAS) As Integer
''        Try
''            Me.Clear()
''            If fcCondicion = CondicionCotizacionEnum.TODAS Then
''                CotizacionCollection.GetMulti(Nothing)
''            Else
''                CotizacionCollection.GetMulti(HC.CotizacionFields.Estatus = fcCondicion)
''            End If

''            For Each CotizacionEntity As EC.CotizacionEntity In CotizacionCollection
''                Dim Cotizacion As New CotizacionClass
''                Cotizacion.LeerEntidad(CotizacionEntity)
''                Me.Add(Cotizacion)
''            Next

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal Cotizacion As CotizacionClass) As Integer
''        Try
''            Me.ClearItems()
''            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
''            Filtro.Add(HC.CotizacionFields.Codigo = Cotizacion.codigo)
''            Filtro.AddWithOr(HC.CotizacionFields.CodigoPlaza = Cotizacion.Plaza)
''            Filtro.AddWithOr(HC.CotizacionFields.CodigoCliente = Cotizacion.Cliente)
''            Dim Conteo As Integer = CotizacionCollection.GetDbCount(Filtro)
''            If Conteo > 0 Then
''                CotizacionCollection.GetMulti(Filtro)
''                For Each CotizacionEntity As EC.CotizacionEntity In CotizacionCollection
''                    Dim MiCotizacion As New CotizacionClass
''                    MiCotizacion.LeerEntidad(CotizacionEntity)
''                    Me.Add(MiCotizacion)
''                Next
''            End If
''            Return Conteo
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal FechaI As Date, ByVal FechaF As Date, Optional ByVal plaza As Integer = -1, Optional ByVal cliente As Integer = -1, _
''                            Optional ByVal vendedor As Integer = -1, Optional ByVal fccondicion As CondicionCotizacionEnum = CondicionCotizacionEnum.TODAS, _
''                            Optional ByVal CodigoCotizacion As Long = -1) As Integer
''        Try
''            Me.Clear()
''            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

''            If Not fccondicion = CondicionCotizacionEnum.TODAS Then
''                Filtro.Add(HC.CotizacionFields.Estatus = fccondicion)
''            End If

''            If Not plaza = -1 Then
''                Filtro.Add(HC.CotizacionFields.CodigoPlaza = plaza)
''            End If

''            If Not cliente = -1 Then
''                Filtro.Add(HC.CotizacionFields.CodigoCliente = cliente)
''            End If

''            If Not vendedor = -1 Then
''                Filtro.Add(HC.CotizacionFields.CodigoVendedor = vendedor)
''            End If

''            If Not CodigoCotizacion = -1 Then
''                Filtro.Add(HC.CotizacionFields.Codigo = CodigoCotizacion)
''            End If

''            Filtro.Add(New OC.FieldBetweenPredicate(HC.CotizacionFields.FechaCotizacion, FechaI, FechaF.AddDays(1)))

''            CotizacionCollection.GetMulti(Filtro)

''            For Each CotizacionEntity As EC.CotizacionEntity In CotizacionCollection
''                Dim MiCotizacion As New CotizacionClass
''                MiCotizacion.LeerEntidad(CotizacionEntity)
''                Me.Add(MiCotizacion)
''            Next

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Public Function Guardar()
''        CotizacionCollection = New CC.CotizacionCollection
''        For Each Cotizacion As CotizacionClass In Me
''            Dim CotizacionEntity As New EC.CotizacionEntity
''            CotizacionEntity = Cotizacion.ObtenerEntidad()
''            CotizacionCollection.Add(CotizacionEntity)
''        Next
''        Try
''            Dim Conteo As Integer = CotizacionCollection.SaveMulti()
''            Return Conteo
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''            Return -1
''        End Try
''    End Function

''    Public Function Borrar()
''        CotizacionCollection = New CC.CotizacionCollection
''        For Each Cotizacion As CotizacionClass In Me
''            Dim CotizacionEntity As New EC.CotizacionEntity
''            CotizacionEntity = Cotizacion.ObtenerEntidad()
''            CotizacionCollection.Add(CotizacionEntity)
''        Next
''        Try
''            Dim Conteo As Integer = CotizacionCollection.DeleteMulti()
''            Return Conteo
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, ex.Message)
''            Return -1
''        End Try
''    End Function

''    Private Sub Rellenar()
''        For Each Cotizacion As EC.CotizacionEntity In Coleccion
''            Dim miCotizacion As New CotizacionClass
''            miCotizacion.LeerEntidad(Cotizacion)
''            Me.Add(miCotizacion)
''        Next
''    End Sub

''    Public Sub RellenarMe(ByVal NuevaColeccion As CC.CotizacionCollection)
''        Me.Clear()
''        For Each Cotizacion As EC.CotizacionEntity In NuevaColeccion
''            Dim miCotizacion As New CotizacionClass
''            miCotizacion.LeerEntidad(Cotizacion)
''            Me.Add(miCotizacion)
''        Next
''    End Sub

''    Private Sub RellenarColeccion()
''        Coleccion = New CC.CotizacionCollection
''        For Each Cotizacion As CotizacionClass In Me
''            Dim miCotizacion As New EC.CotizacionEntity
''            miCotizacion = Cotizacion.ObtenerEntidad
''            Coleccion.Add(miCotizacion)
''        Next
''    End Sub

''    Public Function Existe(ByVal Cotizacion As CotizacionClass) As Boolean
''        For Each entc As CotizacionClass In Me
''            If entc.codigo = Cotizacion.codigo Then
''                Return True
''            End If
''        Next
''        Return False
''    End Function

''    Public Function Reporte() As CRepCotizacion
''        Dim Rep As New CRepCotizacion
''        Dim ds As New DataSet
''        Dim dtCot As New DSetCotizacion.DtCotizacionDataTable
''        Dim dtCotd As New DSetCotizacion.DtDetalleCotizacionDataTable
''        For Each cot As CotizacionClass In Me
''            Dim Coti As DSetCotizacion.DtCotizacionRow = dtCot.AddDtCotizacionRow(cot.codigo, cot.Plaza.Descripcion, cot.Cliente.NombreCompleto, _
''                                                        cot.Comicionista.NombreCompleto, cot.Fecha.ToString("d"), cot.Subtotal.ToString("C2"), _
''                                                        cot.Iva.ToString("C2"), cot.Total.ToString("C2"))
''            For Each detCot As CotizacionDetalleClass In cot.Detalles
''                dtCotd.AddDtDetalleCotizacionRow(detCot.Producto.Codigo, detCot.cantidad.ToString("N3"), detCot.PrecioVenta.ToString("C2"), _
''                detCot.importe.ToString("C2"), detCot.Producto.Descripcion, Coti, detCot.Codigo)
''            Next
''        Next
''        ds.Tables.Add(dtCot)
''        ds.Tables.Add(dtCotd)
''        Rep.SetDataSource(ds)
''        Return Rep
''    End Function

''    Public Function Rpt() As CRepListCotizacion
''        Dim Rep As New CRepListCotizacion
''        Dim ds As New DataSet
''        Dim dtlcot As New DsetLCotizacion.DtLCotizacionDataTable
''        For Each lcot As CotizacionClass In Me
''            dtlcot.AddDtLCotizacionRow(lcot.codigo, lcot.Plaza.Descripcion, lcot.Comicionista.NombreCompleto, lcot.Cliente.NombreCompleto, lcot.Fecha.ToString("d"), lcot.Total.ToString("c"), lcot.EstatusCotizacion.ToString)
''        Next
''        ds.Tables.Add(dtlcot)
''        Rep.SetDataSource(ds)
''        Return Rep
''    End Function

''End Class