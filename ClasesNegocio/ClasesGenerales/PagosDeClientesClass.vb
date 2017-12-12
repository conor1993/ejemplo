Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class PagosDeClientesClass
    Inherits ClassBase(Of EC.PagoDeCtesEntity)

    Private _Facturas As EC.FacturasClientesCabEntity
    Private _Cliente As ClientesIntroductoresClass
    Private _FacturasClientes As FacturasClientesCabClass
    Public IdClienteFactura As Integer
    Public _FolioIngreso As String

#Region "Constructores"
    Sub New()
        Entity = New EC.PagoDeCtesEntity
    End Sub

    Sub New(ByVal entidad As EC.PagoDeCtesEntity)
        Entity = entidad
    End Sub

    Sub New(ByVal FolioIngreso As String, ByVal FolioFactura As String)
        Entity = New EC.PagoDeCtesEntity(FolioIngreso, FolioFactura)
    End Sub

#End Region

#Region "Propiedades "
    Public Property Cve_cliente() As Integer
        Get
            Return Entity.CveCliente
        End Get
        Set(ByVal value As Integer)
            Entity.CveCliente = value
        End Set
    End Property

    Public ReadOnly Property NomCliente() As String
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(Entity.MfacCatClientes)
            End If
            Return _Cliente.Nombre
        End Get
    End Property

    Public Property FolioIngreso() As String
        Get
            Return Entity.FolIngreso
        End Get
        Set(ByVal value As String)
            Entity.FolIngreso = value
        End Set
    End Property

    Public Property Fecha_ingreso() As Date
        Get
            Return Entity.FecIngreso
        End Get
        Set(ByVal value As Date)
            Entity.FecIngreso = value
        End Set
    End Property

    Public Property SerieFactura() As String
        Get
            Return Entity.SerieFactura
        End Get
        Set(ByVal value As String)
            Entity.SerieFactura = value
        End Set
    End Property

    Public Property NoFactura() As String
        Get
            Return Entity.FolFactura
        End Get
        Set(ByVal value As String)
            Entity.FolFactura = value
        End Set
    End Property

    Public Property ImporteIngreso() As Decimal
        Get
            Return Entity.ImpteIngreso
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteIngreso = value
        End Set
    End Property

    Public Property TipoPago() As TipoPagoFactura
        Get
            Return Asc(Entity.TipoPago)
        End Get
        Set(ByVal value As TipoPagoFactura)
            Entity.TipoPago = Chr(value)
        End Set
    End Property

    Public Property Documento() As String
        Get
            Return Entity.Documento
        End Get
        Set(ByVal value As String)
            Entity.Documento = value
        End Set
    End Property

    Public Property ImporteNotaCredito() As Decimal
        Get
            Return Entity.ImpteNotaCred
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteNotaCred = value
        End Set
    End Property

    Public Property ImporteChequePos() As Decimal
        Get
            Return Entity.ImpteChePos
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteChePos = value
        End Set
    End Property

    Public Property Estatus() As EstatusChar
        Get
            Return Asc(Entity.Estatus)
        End Get
        Set(ByVal value As EstatusChar)
            Entity.Estatus = Chr(value)
        End Set
    End Property

    Public Property IdUsuario() As Integer
        Get
            Return Entity.CveUser
        End Get
        Set(ByVal value As Integer)
            Entity.CveUser = value
        End Set
    End Property

    Public Property IdUsurioCancelacion() As Integer
        Get
            Return Entity.CveUserCancel
        End Get
        Set(ByVal value As Integer)
            Entity.CveUserCancel = value
        End Set
    End Property

    Public Property FechaCancelacion() As Date
        Get
            Return Entity.FecCancela
        End Get
        Set(ByVal value As Date)
            Entity.FecCancela = value
        End Set
    End Property

    Public Property ImporteFactura() As Decimal
        Get
            Return Entity.ImpteFactura
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteFactura = value
        End Set
    End Property

    Public Property SaldoFactura() As Decimal
        Get
            Return Entity.SaldoFactura
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoFactura = value
        End Set
    End Property

    Public ReadOnly Property FechaFactura() As Date
        Get
            ' If Me._FacturasClientes Is Nothing Then
            'Dim Relacion As New OC.RelationCollection
            'Dim EnRelacion As New OC.EntityRelation(HC.FacturasClientesCabFields.NoFactura, HC.PagoDeCtesFields.FolFactura, SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
            'Relacion.Add(EnRelacion, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            _FacturasClientes = New FacturasClientesCabClass(SerieFactura, NoFactura)
            ' End If
            Return _FacturasClientes.FechaFactura
        End Get
    End Property

    Public ReadOnly Property FechaVencimiento() As Date
        Get
            ' If Me._FacturasClientes Is Nothing Then
            _FacturasClientes = New FacturasClientesCabClass(Entity.FacturasClientesCab)
            'End If
            Return _FacturasClientes.FechaVencimiento
        End Get
    End Property

    Public Property IdPoliza() As Integer
        Get
            Return Entity.IdPoliza
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoliza = value
        End Set
    End Property

    Public Property IdPolizaCancelacion() As Integer
        Get
            Return Entity.IdPolizaCancelacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdPolizaCancelacion = value
        End Set
    End Property
    'propiedad que se agrega de acuerdo a los cambios de pagos de cliente, ya que algunos cliente compran producto
    'sin facturar y es necesario indicar a quien se le esta cobrando ese importe y marcar la factura correspondiente
    'que esta a publico en general, clientes varios o clientes no identificados.
    Public Property ClienteFactura() As Integer
        Get
            Return IdClienteFactura
        End Get
        Set(ByVal value As Integer)
            IdClienteFactura = value
        End Set
    End Property

    ReadOnly Property Factura() As FacturasClientesCabClass
        Get
            Return New FacturasClientesCabClass(SerieFactura, Me.NoFactura)
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Overloads Function Borrar(ByVal Trans As HC.Transaction, ByVal PagosColeccion As PagosDeClientesCollectionClass) As Boolean
        Try

            Dim coleccion As New CC.PagoDeCtesCollection
            Dim NotasCredito As New CC.NotaCreditoCabCollection
            Dim NotasCreditoDetalle As New CC.NotaCreditoDetCollection
            Dim Filtro As New OC.PredicateExpression
            Dim FiltroNotasCredito As New OC.PredicateExpression

            'se agregaron estas variables para buscar el codigo del cliente principal de la factura.
            'ya que la factura se pudo haber elaborado para clientes varios pero el cargo se lo hicieron
            ' a un cliente en especifico.
            Dim FacturasACancelar As New CC.FacturasClientesCabCollection
            Dim FiltroFacturas As New OC.PredicateExpression

            Dim Lista As New List(Of String)
            For Each pago As PagosDeClientesClass In PagosColeccion
                Lista.Add(pago.NoFactura)
            Next
            Filtro.Add(New OC.FieldCompareRangePredicate(HC.PagoDeCtesFields.FolFactura, Lista.ToArray))
            Filtro.Add(HC.PagoDeCtesFields.Estatus = EstatusChar.VIGENTE)
            Filtro.Add(HC.PagoDeCtesFields.CveCliente = PagosColeccion(0).Cve_cliente)
            Filtro.Add(HC.PagoDeCtesFields.FecIngreso > PagosColeccion(0).Fecha_ingreso)

            coleccion.GetMulti(Filtro)

            'buscar codigo de cliente principal de factura, ya que la factura se pudo haber elaborado para 
            'clientes varios pero el cargo se lo hicieron a un cliente en especifico.
            FiltroFacturas.Add(New OC.FieldCompareRangePredicate(HC.FacturasClientesCabFields.NoFactura, Lista.ToArray))
            FiltroFacturas.Add(HC.FacturasClientesCabFields.IdClienteCargo = PagosColeccion(0).Cve_cliente)
            FacturasACancelar.GetMulti(FiltroFacturas)

            'Buscar las notas de credito afectadas en este pago
            If PagosColeccion.Count > 0 Then
                FiltroNotasCredito.Add(New OC.FieldCompareRangePredicate(HC.NotaCreditoDetFields.FolFactura, Lista.ToArray))
                FiltroNotasCredito.Add(HC.NotaCreditoDetFields.FolPago = PagosColeccion(0).FolioIngreso Or HC.NotaCreditoDetFields.FolPago = "")
                FiltroNotasCredito.Add(HC.NotaCreditoDetFields.Estatus = NotaCreditoEnum.NO_APLICABLE Or HC.NotaCreditoDetFields.Estatus = NotaCreditoEnum.APLICADA)
                NotasCreditoDetalle.GetMulti(FiltroNotasCredito)
                Lista.Clear()

                For Each NotaDetalle As EC.NotaCreditoDetEntity In NotasCreditoDetalle
                    Lista.Add(NotaDetalle.FolNota)
                Next

                'Se valida que el pago haya afectado Notas de Credito para no generar una exepcion por que
                'el arreglo que se manda en la condicion de filtrado no debe ir sin datos
                If Lista.Count > 0 Then _
                            NotasCredito.GetMulti(New OC.FieldCompareRangePredicate(HC.NotaCreditoCabFields.FolNota, _
                            Lista.ToArray()))
            End If

            Dim Encuentra As Integer
            For Each Pago As PagosDeClientesClass In PagosColeccion
                Encuentra = 0
                For Each PagoEnty As EC.PagoDeCtesEntity In coleccion
                    If PagoEnty.FolFactura = Pago.NoFactura Then
                        Encuentra = 1
                        PagoEnty.SaldoFactura = PagoEnty.SaldoFactura + Pago.ImporteIngreso + Pago.ImporteNotaCredito
                    End If
                Next
                'se cambia el valor de pago.cve_cliente 
                'en un principio trae el que esta guardado en la tabla pagosdeclientes con el codigo de idclientecargo, pero 
                'para afectar las facturas y que cambien de estatus se debe tomar el idcliente que se encuentra en la tabla
                'facturasclientescan y no el cve_cliente de pagodeclientes
                For Each FacturasACan As EC.FacturasClientesCabEntity In FacturasACancelar
                    Pago.Cve_cliente = FacturasACan.IdCliente
                Next
                'Se actualiza el estatus de la factura
                _Facturas = New EC.FacturasClientesCabEntity
                If _Facturas.FetchUsingPK("", Pago.NoFactura) Then
                    If Encuentra < 1 Then
                        _Facturas.Estatus = "V"
                    Else
                        _Facturas.Estatus = "A"
                    End If
                    Trans.Add(_Facturas)
                    If Not _Facturas.Save Then
                        Return False
                    End If
                End If
                'Se cancela el pago
                Trans.Add(Pago.ObtenerEntidad)
                If Not Pago.ObtenerEntidad.Save() Then
                    Return False
                End If
            Next

            For Each Nota As EC.NotaCreditoCabEntity In NotasCredito
                Dim Vigentes As Boolean = False
                Dim Aplicadas As Boolean = False
                Dim Canceladas As Boolean = False

                For Each NotaDetalle As EC.NotaCreditoDetEntity In Nota.NotaCreditoDet
                    Dim PorAfectar As Boolean = False

                    For Each NotDet As EC.NotaCreditoDetEntity In NotasCreditoDetalle
                        If NotDet.FolNota = NotaDetalle.FolNota And NotDet.FolFactura = NotaDetalle.FolFactura Then
                            PorAfectar = True
                            Vigentes = True
                        End If
                    Next

                    Select Case CType(NotaDetalle.Estatus, NotaCreditoEnum)
                        Case NotaCreditoEnum.APLICADA
                            If Not PorAfectar Then
                                Aplicadas = True
                            End If
                        Case NotaCreditoEnum.CANCELADA
                            Canceladas = True
                        Case NotaCreditoEnum.VIGENTE
                            Vigentes = True
                    End Select
                Next

                If Aplicadas And (Vigentes Or Canceladas) Then
                    Nota.Estatus = NotaCreditoEnum.PARCIALMENTE_APLICADA
                ElseIf Aplicadas And Not Canceladas And Not Vigentes Then
                    Nota.Estatus = NotaCreditoEnum.APLICADA
                ElseIf Vigentes Then
                    Nota.Estatus = NotaCreditoEnum.VIGENTE
                End If
            Next

            For Each NotaDetalle As EC.NotaCreditoDetEntity In NotasCreditoDetalle
                NotaDetalle.Estatus = NotaCreditoEnum.VIGENTE

                If NotaDetalle.FolPago.Trim <> String.Empty Then
                    NotaDetalle.Aplicar = False
                    NotaDetalle.FolPago = ""
                    NotaDetalle.FecAplica = Nothing
                End If
            Next

            Trans.Add(NotasCredito)
            NotasCredito.SaveMulti()
            Trans.Add(NotasCreditoDetalle)
            NotasCreditoDetalle.SaveMulti()
            'se actualiza el saldo de la factura de los pagos posteriores 
            Trans.Add(coleccion)
            coleccion.SaveMulti()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub GenerarFolio()
        Dim Coleccion As New CC.PagoDeCtesCollection
        Dim Aux As String
        Dim Aux2 As Integer
        If _FolioIngreso = "" Then
            'Coleccion.GetScalar(Integralab.ORM.PagoDeCtesFieldIndex.FolIngreso, New OC.Expression(HC.PagoDeCtesFields.FolIngreso), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max)
            Coleccion.GetMulti(Nothing, 2, Nothing)
            If Coleccion.Count > 0 Then
                Dim ValorMaximo As String = Coleccion.GetScalar(Integralab.ORM.PagoDeCtesFieldIndex.FolIngreso, New OC.Expression(HC.PagoDeCtesFields.FolIngreso), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max) ', Filtro)
                If Not IsDBNull(ValorMaximo) Then
                    Aux = Microsoft.VisualBasic.Right(ValorMaximo, 7)
                    Aux2 = CInt(Aux) + 1
                    Entity.FolIngreso = "P" & Microsoft.VisualBasic.Right("0000000" & Aux2, 7)
                Else
                    Entity.FolIngreso = "P0000001"
                End If
                _FolioIngreso = Entity.FolIngreso
            Else
                Entity.FolIngreso = "P0000001"
                _FolioIngreso = Entity.FolIngreso
            End If
        End If
        ', Filtro) 
    End Sub

    Public Overloads Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Try
            'Dim Coleccion As New CC.PagoDeCtesCollection
            'Dim Filtro As New OC.PredicateExpression(HC.PagoDeCtesFields.FolFactura = Entity.FolFactura)
            'If Coleccion.GetDbCount(Filtro) > 0 Then
            'Dim Aux As String
            'Dim Aux2 As Integer
            'If _FolioIngreso = "" Then
            '    Dim ValorMaximo As String = Coleccion.GetScalar(Integralab.ORM.PagoDeCtesFieldIndex.FolIngreso, New OC.Expression(HC.PagoDeCtesFields.FolIngreso), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max) ', Filtro)
            '    If Not ValorMaximo Is Nothing Then
            '        Aux = Microsoft.VisualBasic.Right(ValorMaximo, 7)
            '        Aux2 = CInt(Aux) + 1
            '        Entity.FolIngreso = "P" & Microsoft.VisualBasic.Right("0000000" & Aux2, 7)
            '    Else
            '        Entity.FolIngreso = "P0000001"
            '    End If
            '    _FolioIngreso = Entity.FolIngreso
            'Else
            '    Aux = Microsoft.VisualBasic.Right(_FolioIngreso, 7)
            '    Aux2 = CInt(Aux) + 1
            '    Entity.FolIngreso = "P" & Microsoft.VisualBasic.Right("0000000" & Aux2, 7)
            'End If
            'Else
            'Entity.FolIngreso = "P0000001"
            'End If

            'Se afecta el estatus de la factura para indicar que ha sido abonada o pagada
            '_Facturas = New EC.FacturasClientesCabEntity(Entity.FolFactura, Entity.CveCliente)'instrucción primera con el codigo del cliente que se hace el cobro
            _Facturas = New EC.FacturasClientesCabEntity("", Entity.FolFactura) 'instrucción que sustituye con el código del cliente que tiene esa factura
            If Me.SaldoFactura > 0 Then
                _Facturas.Estatus = "A"
            Else
                _Facturas.Estatus = "P"
            End If

            Trans.Add(_Facturas)
            _Facturas.Save()

            Trans.Add(Entity)
            Return Entity.Save
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Function Obtener(ByVal FolioIngreso As String, ByVal FolioFactura As String) As Boolean
        Try
            Return Entity.FetchUsingPK(FolioIngreso, FolioFactura)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function



#End Region
End Class

Public Class PagosDeClientesCollectionClass
    Inherits ColleccionBase(Of EC.PagoDeCtesEntity, CC.PagoDeCtesCollection, PagosDeClientesClass)

    Public Overloads Function Obtener(Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal Cliente As Integer = -1, _
       Optional ByVal Factura As String = "", Optional ByVal FechaIni As Date = #1/1/1900#, Optional ByVal FechaFin As Date = #1/1/1900#, Optional ByVal FolioIngreso As String = "") As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not Estatus = EstatusChar.TODOS Then
                Filtro.Add(HC.PagoDeCtesFields.Estatus = Estatus)
            End If

            If Not Cliente = -1 Then
                Filtro.Add(HC.PagoDeCtesFields.CveCliente = Cliente)
            End If

            If Not Factura = "" Then
                Filtro.Add(HC.PagoDeCtesFields.FolFactura = Factura)
            End If

            If Not FechaIni = #1/1/1900# And Not FechaFin = #1/1/1900# Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.PagoDeCtesFields.FecIngreso, FechaIni, FechaFin))
            End If

            If Not FolioIngreso = "" Then
                Filtro.Add(HC.PagoDeCtesFields.FolIngreso = FolioIngreso)
            End If

            coleccion.GetMulti(Filtro)
            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function obtener(ByVal IdCliente As Integer, ByVal FolioIngreso As String) As Integer
        Try
            coleccion.Clear()
            coleccion.GetMulti(HC.PagoDeCtesFields.CveCliente = IdCliente And HC.PagoDeCtesFields.FolIngreso = FolioIngreso)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class