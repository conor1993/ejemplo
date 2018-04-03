Imports SPA = Integralab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports System.Windows.Forms
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class FacturasClientesCabClass
    Inherits ClassBase(Of EC.FacturasClientesCabEntity)

    Private _NotasCreditoPorAplicar As CC.NotaCreditoDetCollection
    'Dim Facturas As New EC.FacturasClientesCabEntity
    Private _Func As String
    Private _NumOpc As Integer
    Private _Pagos As PagosDeClientesCollectionClass

#Region "Constructores"
    Public Sub New()
        Entity = New EC.FacturasClientesCabEntity
        Entity.IdCliente = 0
        Entity.Contabilizado = "N"
        Entity.Contado = False
        Entity.Credito = False
        Entity.Iva = 0
        Entity.IdPoliza = 0
        Entity.Estatus = "V"
        Entity.FechaCancelacion = #1/1/1900#
        Entity.FechaCaptura = #1/1/1900#
        Entity.FechaContabilizacion = #1/1/1900#
        Entity.FechaFactura = #1/1/1900#
        Entity.FechaVencimiento = #1/1/1900#
        Entity.IdUsuarioCancela = 0
        Entity.NoFactura = ""
        Entity.Observaciones = ""
        Entity.SubTotal = 0
        Entity.Total = 0
    End Sub

    Sub New(ByVal Entidad As EC.FacturasClientesCabEntity)
        Me.Entity = Entidad
    End Sub

    Sub New(ByVal SerieFact As String, ByVal FolioFact As String)
        Me.Entity = New EC.FacturasClientesCabEntity(FolioFact, SerieFact)
    End Sub
#End Region

#Region "Propiedades"
    Property Serie() As String
        Get
            Return Entity.Serie
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            '    RaiseEvent MensajeError(Me, "Especifique numéro de Factura")
            '    Throw New System.SystemException(" ")
            'End If
            Entity.Serie = value
        End Set
    End Property

    Property NoFactura() As String
        Get
            Return Entity.NoFactura
        End Get
        Set(ByVal value As String)
            Entity.NoFactura = value
        End Set
    End Property

    Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Property IdDomicilioFiscal() As Integer
        Get
            Return Entity.IdDomicilioFiscal
        End Get
        Set(ByVal value As Integer)
            Entity.IdDomicilioFiscal = value
        End Set
    End Property

    Property FechaFactura() As Date
        Get
            Return Entity.FechaFactura
        End Get
        Set(ByVal value As Date)
            Entity.FechaFactura = value
        End Set
    End Property

    Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    Property FechaVencimiento() As Date
        Get
            Return Entity.FechaVencimiento
        End Get
        Set(ByVal value As Date)
            Entity.FechaVencimiento = value
        End Set
    End Property

    Property Contado() As Boolean
        Get
            Return Entity.Contado
        End Get
        Set(ByVal value As Boolean)
            Entity.Contado = value
        End Set
    End Property

    Property Credito() As Boolean
        Get
            Return Entity.Credito
        End Get
        Set(ByVal value As Boolean)
            Entity.Credito = value
        End Set
    End Property

    Property SubTotal() As Decimal
        Get
            Return Entity.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.SubTotal = value
        End Set
    End Property

    Property IVA() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property

    Property IEPS() As Decimal
        Get
            Return Entity.Ieps
        End Get
        Set(ByVal value As Decimal)
            Entity.Ieps = value
        End Set
    End Property

    Property Total() As Decimal
        Get
            Return Entity.Total
        End Get
        Set(ByVal value As Decimal)
            Entity.Total = value
        End Set
    End Property

    Property Contabilizado() As String
        Get
            Return Entity.Contabilizado
        End Get
        Set(ByVal value As String)
            Entity.Contabilizado = value
        End Set
    End Property

    Property IdPoliza() As Integer
        Get
            Return Entity.IdPoliza
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoliza = value
        End Set
    End Property

    Property FechaContabilizacion() As Date
        Get
            Return Entity.FechaContabilizacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaContabilizacion = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Property Origen() As String
        Get
            Return Entity.Origen
        End Get
        Set(ByVal value As String)
            Entity.Origen = value
        End Set
    End Property

    Property UUID() As String
        Get
            Return Entity.Uuid
        End Get
        Set(ByVal value As String)
            Entity.Uuid = value
        End Set
    End Property

    Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property

    Property IdUsuarioCancela() As Integer
        Get
            Return Entity.IdUsuarioCancela
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancela = value
        End Set
    End Property

    Property IdClienteCargo() As Integer
        Get
            Return Entity.IdClienteCargo
        End Get
        Set(ByVal value As Integer)
            Entity.IdClienteCargo = value
        End Set
    End Property

    Property FormaDePago() As String
        Get
            Return Entity.FormaDePago
        End Get
        Set(ByVal value As String)
            Entity.FormaDePago = value
        End Set
    End Property

    Property MetodoDePago() As String
        Get
            Return Entity.MetodoDePago
        End Get
        Set(ByVal value As String)
            Entity.MetodoDePago = value
        End Set
    End Property

    Property CondicionesDePago() As String
        Get
            Return Entity.CondicionesDePago
        End Get
        Set(ByVal value As String)
            Entity.CondicionesDePago = value
        End Set
    End Property

    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property

    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property

    Property TipoFactura() As Integer
        Get
            Return Entity.TopoFactura
        End Get
        Set(ByVal value As Integer)
            Entity.TopoFactura = value
        End Set
    End Property

    ReadOnly Property DetalleProductos() As CC.FacturasClientesDetProductosTotalesCollection
        Get
            Return Entity.FacturasClientesDetProductosTotales
        End Get
    End Property

    'ReadOnly Property DetalleProductosCol() As ClasesNegocio.fa
    '    Get

    '        Return Entity.FacturasClientesDetProductosTotales
    '    End Get
    'End Property

    ReadOnly Property Cliente() As ClientesIntroductoresClass
        Get
            Return New ClientesIntroductoresClass(Me.Entidad.MfacCatClientes)
        End Get
    End Property

    Public ReadOnly Property Pagos() As PagosDeClientesCollectionClass
        Get
            If _Pagos Is Nothing Then
                _Pagos = New PagosDeClientesCollectionClass()
                _Pagos.Obtener(EstatusChar.TODOS, -1, Me.NoFactura)
            End If
            Return _Pagos
        End Get
    End Property

    ReadOnly Property NotasCredito() As CC.NotaCreditoDetCollection
        Get
            Return Entity.NotaCreditoDet
        End Get
    End Property

    ReadOnly Property NotasCreditoPorAplicar() As CC.NotaCreditoDetCollection
        Get
            If _NotasCreditoPorAplicar Is Nothing Then
                _NotasCreditoPorAplicar = New CC.NotaCreditoDetCollection()
            End If
            Return _NotasCreditoPorAplicar
        End Get
    End Property

    ReadOnly Property TotalNotasCreditoAplicadas() As Decimal
        Get
            Dim Total As Decimal = 0D
            For Each NotaDetalle As EC.NotaCreditoDetEntity In NotasCredito
                If CType(NotaDetalle.Estatus, NotaCreditoEnum) = NotaCreditoEnum.APLICADA Then
                    Total += NotaDetalle.Total
                End If
            Next
            Return Total
        End Get
    End Property

    ReadOnly Property TotalNotasCreditoPorAplicar() As Decimal
        Get
            Dim Total As Decimal = 0D
            For Each NotaDetalle As EC.NotaCreditoDetEntity In NotasCreditoPorAplicar
                Total += NotaDetalle.Total
            Next
            Return Total
        End Get
    End Property

    Public Property Estatus() As String
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As String)
            Entity.Estatus = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Shadows Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If trans IsNot Nothing Then
                trans.Add(Entity)
            End If

            Entity.Save()
            'If SPA.UspFacturasClientesCab(Serie, NoFactura, IdCliente, FechaFactura, FechaCaptura, FechaVencimiento, Contado, Credito, SubTotal, IVA, Total, Contabilizado, IdPoliza, FechaContabilizacion, Estatus, Observaciones, FechaCancelacion, IdUsuarioCancela, IdClienteCargo, FormaDePago, MetodoDePago, CondicionesDePago, UUID, Origen, Func, NumOpc, trans) = 0 Then
            '    'RaiseEvent MensajeError(Me, "Error al guardar información de facturas")
            '    Return False
            'End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal Opcion As Integer, ByVal SerieFactura As String, ByVal NoFactura As String, ByRef trans As Integralab.ORM.HelperClasses.Transaction) As DataSet
        Try
            Dim Ds As DataSet
            Ds = SPR.UspConFacturas(Opcion, SerieFactura, NoFactura, trans)
            Return Ds
        Catch ex As Exception
            MsgBox("Error al consultar factura")
            Return Nothing
        End Try
    End Function

    Public Function Obtener(ByVal Opcion As Integer, ByVal SerieFactura As String, ByVal NoFactura As String) As DataSet
        Try
            Obtener = SPR.UspConFacturas(Opcion, SerieFactura, NoFactura)
        Catch ex As Exception
            MsgBox("Error al consultar factura")
            Obtener = Nothing
        End Try
    End Function

    Public Function Consulta(ByVal Serie As String, ByVal NoFactura As String, ByVal Opcion As Integer) As DataSet
        Try
            Consulta = SPR.UspConFacturas(Opcion, Serie, NoFactura)
        Catch ex As Exception
            MsgBox("Error al consultar factura")
            Consulta = Nothing
        End Try
    End Function
#End Region

End Class

Public Class FacturasCXP
#Region "Constructores"
    'Por el momento no usaré
    Sub New()

    End Sub
#End Region

#Region "Metodos"
    Public Function CancelarFactura(ByVal NumeroFactura As String, ByVal ID_Proveedor As Integer) As Boolean
        Dim tabla As New DataSet
        Dim Success As Byte = 0
        Try
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Usp_FacturasCancelar",
                                New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.CommandType = CommandType.StoredProcedure
                With ad.SelectCommand.Parameters
                    .Add("@V_Opc", SqlDbType.Int).Value = 1
                    .Add("@V_FolioFactura", SqlDbType.VarChar).Value = NumeroFactura
                End With

                ad.SelectCommand.CommandTimeout = 30
                ad.SelectCommand.Connection.Open()
                ad.Fill(tabla)
                ad.SelectCommand.Connection.Close()

                If (tabla.Tables.Count > 0) Then
                    If (tabla.Tables(0).Rows.Count > 0) Then
                        Success = CByte(tabla.Tables(0).Rows(0)("Success"))
                        Dim Mensaje As String = tabla.Tables(0).Rows(0)("Mensaje").ToString()
                        If (CBool(Success) = False) Then
                            MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            'If MsgBox("¿Desea Realmente?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then

                            'Else

                        End If

                        'MessageBox.Show("Esta factura no tienes cuentas contables asociadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            End Using
        Catch ex As Exception

        End Try
        Return CBool(Success)
    End Function
#End Region

End Class
Public Class FacturasClientesCabCollectionClass
    Inherits ColleccionBase(Of EC.FacturasClientesCabEntity, CC.FacturasClientesCabCollection, FacturasClientesCabClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As FacturasClientesCabClass)
        MyBase.Add(item)
    End Sub

    Public Overloads Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal filtro As PredicateExpression) As Integer
        Try
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function


#End Region

End Class
Public Class FacurasClientesDetClass
    Implements IEntidad

    Dim Facturas As New EC.FacturasClientesDetEntity
    Dim _Func As String
    Dim _NumOpc As Integer

    Property Serie() As String
        Get
            Return Facturas.SerieFactura
        End Get
        Set(ByVal value As String)
            Facturas.SerieFactura = value
        End Set
    End Property

    Property NoFactura() As String
        Get
            Return Facturas.NoFactura
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError(Me, "Especifique numéro de Factura")
                Throw New System.SystemException(" ")
            End If
            Facturas.NoFactura = value
        End Set
    End Property

    Property IdCliente() As Integer
        Get
            Return Facturas.IdCliente
        End Get
        Set(ByVal value As Integer)
            Facturas.IdCliente = value
        End Set
    End Property

    Property CtaMay() As String
        Get
            Return Facturas.CtaMay
        End Get
        Set(ByVal value As String)
            Facturas.CtaMay = value
        End Set
    End Property

    Property SubCta() As String
        Get
            Return Facturas.SubCta
        End Get
        Set(ByVal value As String)
            Facturas.SubCta = value
        End Set
    End Property

    Property SsbCta() As String
        Get
            Return Facturas.SsbCta
        End Get
        Set(ByVal value As String)
            Facturas.SsbCta = value
        End Set
    End Property

    Property SssCta() As String
        Get
            Return Facturas.SssCta
        End Get
        Set(ByVal value As String)
            Facturas.SssCta = value
        End Set
    End Property

    Property Importe() As Decimal
        Get
            Return Facturas.Importe
        End Get
        Set(ByVal value As Decimal)
            Facturas.Importe = value
        End Set
    End Property

    Property CargoAbono() As String
        Get
            Return Facturas.CargoAbono
        End Get
        Set(ByVal value As String)
            Facturas.CargoAbono = value
        End Set
    End Property

    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property

    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspFacturasClientesDet(NoFactura, IdCliente, CtaMay, SubCta, SsbCta, SssCta, Importe, CargoAbono, Func, NumOpc, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al guardar información de factura")
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function

End Class
''Public Class FacturasClientesDetProductosClass
''    Implements IEntidad


''    Dim Facturas As New EC.FacturasClientesDetProductosEntity
''    Dim _Func As String
''    Dim _NumOpc As Integer
''    Property NoFactura() As String
''        Get
''            Return Facturas.NoFactura
''        End Get
''        Set(ByVal value As String)
''            If value = "" Then
''                RaiseEvent MensajeError(Me, "Especifique numéro de Factura")
''                Throw New System.SystemException(" ")
''            End If
''            Facturas.NoFactura = value
''        End Set
''    End Property
''    Property IdFolioEtiqueta() As String
''        Get
''            Return Facturas.IdFolioEtiqueta
''        End Get
''        Set(ByVal value As String)
''            Facturas.IdFolioEtiqueta = value
''        End Set
''    End Property
''    Property PrecioxKgr() As Decimal
''        Get
''            Return Facturas.PrecioxKgr
''        End Get
''        Set(ByVal value As Decimal)
''            Facturas.PrecioxKgr = value
''        End Set
''    End Property
''    Property Importe() As Decimal
''        Get
''            Return Facturas.Importe
''        End Get
''        Set(ByVal value As Decimal)
''            Facturas.Importe = value
''        End Set
''    End Property
''    Property ImporteDescuento() As Decimal
''        Get
''            Return Facturas.ImporteDescuento
''        End Get
''        Set(ByVal value As Decimal)
''            Facturas.ImporteDescuento = value
''        End Set
''    End Property
''    Property ImporteIVA() As Decimal
''        Get
''            Return Facturas.ImporteIva
''        End Get
''        Set(ByVal value As Decimal)
''            Facturas.ImporteIva = value
''        End Set
''    End Property
''    Property Func() As String
''        Get
''            Return _Func
''        End Get
''        Set(ByVal value As String)
''            _Func = value
''        End Set
''    End Property
''    Property NumOpc() As Integer
''        Get
''            Return _NumOpc
''        End Get
''        Set(ByVal value As Integer)
''            _NumOpc = value
''        End Set
''    End Property

''    Public Function Borrar() As Boolean Implements IEntidad.Borrar

''    End Function

''    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

''    End Function

''    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
''        Try
''            If SPA.UspFacturasClientesDetProductos(NoFactura, IdFolioEtiqueta, PrecioxKgr, Importe, ImporteIVA, ImporteDescuento, Func, NumOpc, trans) = 0 Then
''                RaiseEvent MensajeError(Me, "Error al guardar información de factura")
''                Return False
''            End If
''            Return True
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, "Error al guardar información de factura")
''            Return False
''        End Try
''    End Function

''    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

''    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

''    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

''    End Function

''    Public Sub New()
''        Facturas = New EC.FacturasClientesDetProductosEntity
''        Facturas.NoFactura = ""
''        Facturas.IdFolioEtiqueta = ""
''        Facturas.Importe = 0
''        Facturas.ImporteDescuento = 0
''        Facturas.ImporteIva = 0
''        Facturas.PrecioxKgr = 0
''    End Sub

''    Public Function Guardar1() As Boolean

''    End Function

''    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

''    End Function

''    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
''        Get

''        End Get
''        Set(ByVal value As EstatusEnum)

''        End Set
''    End Property

''    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

''    End Function
''End Class
Public Class FolioFacturaClass
    Implements IEntidad


    Dim Facturas As New EC.FolioFacturaEntity
    Dim _Consecutivo As Integer
    Property Consecutivo() As Integer
        Get
            Return _Consecutivo
        End Get
        Set(ByVal value As Integer)
            _Consecutivo = value
        End Set
    End Property
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspFolioFactura(Consecutivo, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al generar folio de factura")
                Return False
            End If
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "Error al al generar folio de factura")
            Return False
        End Try

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Sub New()
        Facturas = New EC.FolioFacturaEntity
    End Sub

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class


'detalle de facturas de embarques
Public Class FacturasClientesDetProductosTotalesClass
    Implements IEntidad
    Dim FacturasDetalle As New EC.FacturasClientesDetProductosTotalesEntity
    Dim _Producto As ProductoGeneralClass

    Public Property SerieFactura() As String
        Get
            Return FacturasDetalle.SerieFactura
        End Get
        Set(ByVal value As String)
            FacturasDetalle.SerieFactura = value
        End Set
    End Property

    Public Property NoFactura() As String
        Get
            Return FacturasDetalle.NoFactura
        End Get
        Set(ByVal value As String)
            FacturasDetalle.NoFactura = value
        End Set
    End Property

    Public Property IdProducto() As Integer
        Get
            Return FacturasDetalle.IdProducto
        End Get
        Set(ByVal value As Integer)
            FacturasDetalle.IdProducto = value
        End Set
    End Property

    Public Property KilosEmb() As Decimal
        Get
            Return FacturasDetalle.KilosEmbarcados
        End Get
        Set(ByVal value As Decimal)
            FacturasDetalle.KilosEmbarcados = value
        End Set
    End Property

    Public Property KilosFac() As Decimal
        Get
            Return FacturasDetalle.KilosFacturados
        End Get
        Set(ByVal value As Decimal)
            FacturasDetalle.KilosFacturados = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return FacturasDetalle.PrecioxKgr
        End Get
        Set(ByVal value As Decimal)
            FacturasDetalle.PrecioxKgr = value
        End Set
    End Property

    Public Property ImporteEmb() As Decimal
        Get
            Return FacturasDetalle.ImporteEmbarcado
        End Get
        Set(ByVal value As Decimal)
            FacturasDetalle.ImporteEmbarcado = value
        End Set
    End Property

    Public Property ImporteFac() As Decimal
        Get
            Return FacturasDetalle.ImporteFacturado
        End Get
        Set(ByVal value As Decimal)
            FacturasDetalle.ImporteFacturado = value
        End Set
    End Property

    Public Property Renglon() As Integer
        Get
            Return FacturasDetalle.Renglon
        End Get
        Set(ByVal value As Integer)
            FacturasDetalle.Renglon = value
        End Set
    End Property

    Public Property NotaVenta() As Integer
        Get
            Return FacturasDetalle.NotaVenta
        End Get
        Set(ByVal value As Integer)
            FacturasDetalle.NotaVenta = value
        End Set
    End Property

    Public Property Embarque() As String
        Get
            Return FacturasDetalle.FolioEmbarque
        End Get
        Set(ByVal value As String)
            FacturasDetalle.FolioEmbarque = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return FacturasDetalle.Iva
        End Get
        Set(ByVal value As Decimal)
            FacturasDetalle.Iva = value
        End Set
    End Property

    Public Property IEPS() As Decimal
        Get
            Return FacturasDetalle.Ieps
        End Get
        Set(ByVal value As Decimal)
            FacturasDetalle.Ieps = value
        End Set
    End Property

    Public ReadOnly Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass(FacturasDetalle.IdProducto)
            End If
            Return _Producto
        End Get
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If trans IsNot Nothing Then
                trans.Add(FacturasDetalle)
            End If

            FacturasDetalle.Save()
            Return True
        Catch ex As Exception
            'RaiseEvent MensajeError(Me, "Error guardar el detalle de la factura")
            'Return False
            Throw ex
        End Try

    End Function

    Public Function Guardar() As Boolean Implements IEntidad.Guardar
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
End Class



''detalle de facturas en general
'Public Class FacturasClientesDetalleClass
'    Implements IEntidad
'    Dim Facturas As New EC.FacturasClientesDetalleEntity

'    Property NoFactura() As String
'        Get
'            Return Facturas.NoFactura
'        End Get
'        Set(ByVal value As String)
'            Facturas.NoFactura = value
'        End Set
'    End Property
'    Property Renglon() As Integer
'        Get
'            Return Facturas.Renglon
'        End Get
'        Set(ByVal value As Integer)
'            Facturas.Renglon = value
'        End Set
'    End Property
'    Property IdConcepto() As Integer
'        Get
'            Return Facturas.IdConceptoFacEspecial
'        End Get
'        Set(ByVal value As Integer)
'            Facturas.IdConceptoFacEspecial = value
'        End Set
'    End Property
'    Property Cantidad() As Decimal
'        Get
'            Return Facturas.Cantidad
'        End Get
'        Set(ByVal value As Decimal)
'            Facturas.Cantidad = value
'        End Set
'    End Property
'    Property Corral() As Integer
'        Get
'            Return Facturas.IdCorral
'        End Get
'        Set(ByVal value As Integer)
'            Facturas.IdCorral = value
'        End Set
'    End Property
'    Property TipoGanado() As Integer
'        Get
'            Return Facturas.IdTipoGanado
'        End Get
'        Set(ByVal value As Integer)
'            Facturas.IdTipoGanado = value
'        End Set
'    End Property
'    Property Kilos() As Decimal
'        Get
'            Return Facturas.Kilos
'        End Get
'        Set(ByVal value As Decimal)
'            Facturas.Kilos = value
'        End Set
'    End Property
'    Property PrecioXKilo() As Decimal
'        Get
'            Return Facturas.PrecioxKilo
'        End Get
'        Set(ByVal value As Decimal)
'            Facturas.PrecioxKilo = value
'        End Set
'    End Property
'    Property CostoXKilo() As Decimal
'        Get
'            Return Facturas.CostoxKilo
'        End Get
'        Set(ByVal value As Decimal)
'            Facturas.CostoxKilo = value
'        End Set
'    End Property
'    Property IVA() As Decimal
'        Get
'            Return Facturas.PtjIva
'        End Get
'        Set(ByVal value As Decimal)
'            Facturas.PtjIva = value
'        End Set
'    End Property
'    Property Almacen() As Integer
'        Get
'            Return Facturas.IdAlmacen
'        End Get
'        Set(ByVal value As Integer)
'            Facturas.IdAlmacen = value
'        End Set
'    End Property
'    Property Producto() As Integer
'        Get
'            Return Facturas.IdProducto
'        End Get
'        Set(ByVal value As Integer)
'            Facturas.IdProducto = value
'        End Set
'    End Property
'    Property Servicio() As String
'        Get
'            Return Facturas.Servicio
'        End Get
'        Set(ByVal value As String)
'            Facturas.Servicio = value
'        End Set
'    End Property
'    Property CostoUni() As Decimal
'        Get
'            Return Facturas.CostoUni
'        End Get
'        Set(ByVal value As Decimal)
'            Facturas.CostoUni = value
'        End Set
'    End Property
'    Property PrecioUni() As Decimal
'        Get
'            Return Facturas.PrecioUni
'        End Get
'        Set(ByVal value As Decimal)
'            Facturas.PrecioUni = value
'        End Set
'    End Property

'    Public Function Borrar() As Boolean Implements IEntidad.Borrar

'    End Function

'    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

'    End Function

'    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
'        Get

'        End Get
'        Set(ByVal value As EstatusEnum)

'        End Set
'    End Property

'    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
'        Try
'            Facturas.Save()
'            Return True
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, "Error guardar el detalle de la factura")
'            Return False
'        End Try

'    End Function
'    Public Function Guardar() As Boolean Implements IEntidad.Guardar

'    End Function

'    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

'    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

'    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

'    End Function
'End Class