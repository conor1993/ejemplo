Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports DAO = Integralab.ORM.DaoClasses
Imports ORM = Integralab.ORM

Public Class RecepcionGanadoClass
    Inherits ClassBase(Of EC.RecepcionGanadoEntity)

#Region "Miembros"
    Enum Tipo As Short
        Ganado
        Ingrediente
        Otros
        Sacrificio
    End Enum

    'Dim Entity As EC.RecepcionGanadoEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Dim m_Proveedor As ProveedorClass
    Dim m_Detalle As RecepcionPesadasDetalleCollectionClass
    Dim m_TipoGanado As TipoGanadoClass
#End Region

#Region "Propiedades"
    Property LoteRecepcion() As String
        Get
            Return Entity.LoteRecepcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError(Me, "Especifique Lote de Recepción de Ganado")
                Throw New System.SystemException(" ")
            End If
            Entity.LoteRecepcion = value
        End Set
    End Property

    Property CantCabezas() As Integer
        Get
            Return Entity.CantCabezas
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                RaiseEvent MensajeError(Me, "Especifique numéro de Cabezas de Ganado")
                Throw New System.SystemException(" ")
            End If
            Entity.CantCabezas = value
        End Set
    End Property

    Property Conductor() As String
        Get
            Return Entity.Conductor
        End Get
        Set(ByVal value As String)
            Entity.Conductor = value
        End Set
    End Property

    Property Estatus() As String
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As String)
            Entity.Estatus = value
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

    Property FechaRecepcion() As Date
        Get
            Return Entity.FechaRecepcion
        End Get
        Set(ByVal value As Date)
            Entity.FechaRecepcion = value
        End Set
    End Property

    Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                RaiseEvent MensajeError(Me, "Especifique Productor de Ganado")
                Throw New System.SystemException(" ")
            End If
            Entity.IdCliente = value
        End Set
    End Property

    Property IdUsuario() As Integer
        Get
            Return Entity.IdUsuario
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuario = value
        End Set
    End Property

    Property IdUsuarioCancelacion() As Integer
        Get
            Return Entity.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancelacion = value
        End Set
    End Property

    Property KilosEnviados() As Decimal
        Get
            Return Entity.KilosEnviados
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosEnviados = value
        End Set
    End Property

    Property KilosRecibidos() As Decimal
        Get
            Return Entity.KilosRecibidos
        End Get
        Set(ByVal value As Decimal)
            'If value = 0 Then
            '    RaiseEvent MensajeError(Me, "Especifique Kilos Recibidos")
            '    Throw New System.SystemException(" ")
            'End If
            Entity.KilosRecibidos = value
        End Set
    End Property

    Public Property KilosPrimeraPesada() As Decimal
        Get
            Return Entity.KilosPrimerPesada
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosPrimerPesada = value
        End Set
    End Property

    Public Property KilosSegundaPesada() As Decimal
        Get
            Return Entity.KilosSegundaPesada
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosSegundaPesada = value
        End Set
    End Property

    Property LoteEngorda() As String
        Get
            Return Entity.LoteEngorda
        End Get
        Set(ByVal value As String)
            Entity.LoteEngorda = value
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

    Property ObservacionesCancelacion() As String
        Get
            Return Entity.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesCancelacion = value
        End Set
    End Property

    Property Placas() As String
        Get
            Return Entity.Placas
        End Get
        Set(ByVal value As String)
            Entity.Placas = value
        End Set
    End Property

    Property Unidad() As String
        Get
            Return Entity.Unidad
        End Get
        Set(ByVal value As String)
            Entity.Unidad = value
        End Set
    End Property

    Public Property MultiplesIntroductores() As Boolean
        Get
            Return Me.Entity.MultiplesIntroductores
        End Get
        Set(ByVal value As Boolean)
            Entity.MultiplesIntroductores = value
        End Set
    End Property

    Public Property TipoGanado() As TipoGanadoClass
        Get
            If m_TipoGanado Is Nothing Then
                m_TipoGanado = New TipoGanadoClass(Entity.IdTipoGanado)
            ElseIf Not m_TipoGanado.IdTipoGanado = Me.IdTipoGanado Then
                m_TipoGanado.Entidad = Entity.McgcatTiposdeGanado
            End If

            Return m_TipoGanado
        End Get
        Set(ByVal value As TipoGanadoClass)
            m_TipoGanado = value
            Entity.McgcatTiposdeGanado = IIf(value Is Nothing, Nothing, value.Entidad)
        End Set
    End Property

    Public Property CabezasHembras() As Integer
        Get
            Return Entity.CabezaHembra
        End Get
        Set(ByVal value As Integer)
            Entity.CabezaHembra = value
        End Set
    End Property

    Public Property CabezasMachos() As Integer
        Get
            Return Entity.CabezasMachos
        End Get
        Set(ByVal value As Integer)
            Entity.CabezasMachos = value
        End Set
    End Property

    Property IdProveedor() As Integer
        Get
            Return Entidad.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entidad.IdProveedor = value
        End Set
    End Property

    Property IdTipoGanado() As Integer
        Get
            Return Entity.IdTipoGanado
        End Get
        Set(ByVal value As Integer)
            Entity.IdTipoGanado = value
        End Set
    End Property

    Property TipoPesada() As Tipo
        Get
            Return Entidad.TipoPesada
        End Get
        Set(ByVal value As Tipo)
            Entidad.TipoPesada = value
        End Set
    End Property

    ReadOnly Property FechaCaptura() As DateTime
        Get
            Return Entidad.FechaCaptura
        End Get
    End Property

    Property FechaSalida() As DateTime
        Get
            Return Entidad.FechaSalida
        End Get
        Set(ByVal value As DateTime)
            Entidad.FechaSalida = value
        End Set
    End Property

    Property Proveedor() As ProveedorClass
        Get
            If m_Proveedor Is Nothing Then
                m_Proveedor = New ProveedorClass(Entity.IdProveedor)
                'ElseIf Not m_Proveedor.Codigo = Me.IdProveedor Then
                '    m_Proveedor.Entidad = Entity.Proveedor
            End If

            Return m_Proveedor
        End Get
        Set(ByVal value As ProveedorClass)
            m_Proveedor = value

            'If value Is Nothing Then
            '    Entity.Proveedor = Nothing
            'Else
            '    Entity.Proveedor = value.Entidad
            'End If
        End Set
    End Property

    ReadOnly Property Detalle() As RecepcionPesadasDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New RecepcionPesadasDetalleCollectionClass(Entity.UsrProdRecepcionDetalle)
            End If
            Return m_Detalle
        End Get
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

    Public ReadOnly Property NombreIntroductor() As String
        Get
            Return Entity.Clientes.Nombre
        End Get
    End Property

    Public ReadOnly Property KilosPromedio() As Decimal
        Get
            Try
                Return Me.KilosRecibidos / Me.CantCabezas
            Catch er As DivideByZeroException
                Return 0D
            Catch ex As Exception
                Return 0D
            End Try
        End Get
    End Property

    Property CveLugarCompra() As Integer
        Get
            Return Entity.CveLugCom
        End Get
        Set(ByVal value As Integer)
            Entity.CveLugCom = value
        End Set
    End Property

    Property CveCompradorGanado() As Integer
        Get
            Return Entity.CveComiGan
        End Get
        Set(ByVal value As Integer)
            Entity.CveComiGan = value
        End Set
    End Property

    Property HorasViaje() As Decimal
        Get
            Return Entity.HorasViaje
        End Get
        Set(ByVal value As Decimal)
            Entity.HorasViaje = value
        End Set
    End Property

    Property KilosComp() As Decimal
        Get
            Return Entity.KilosComp
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosComp = value
        End Set
    End Property

    Property ImporteComp() As Decimal
        Get
            Return Entity.ImpteComp
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteComp = value
        End Set
    End Property

    Property DiasCredito() As Integer
        Get
            Return Entity.DiasCredito
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCredito = value
        End Set
    End Property

    Property FechaPago() As DateTime
        Get
            Return Entity.FecPago
        End Get
        Set(ByVal value As DateTime)
            Entity.FecPago = value
        End Set
    End Property

    Property NumFactura() As String
        Get
            Return Entity.NumFactura
        End Get
        Set(ByVal value As String)
            Entity.NumFactura = value
        End Set
    End Property

    Property FechaContabilidad() As DateTime?
        Get
            Return Entity.FecConta
        End Get
        Set(ByVal value As DateTime?)
            Entity.FecConta = value
        End Set
    End Property

    Property NumPoliza() As String
        Get
            Return Entity.NumPoliza
        End Get
        Set(ByVal value As String)
            Entity.NumPoliza = value
        End Set
    End Property



#End Region

#Region "Metodos"
    'Property LoteSacrificio() As String
    '    Get
    '        Return Recepcion.LoteSacrific

    '    End Get
    '    Set(ByVal value As String)
    '        Recepcion.LoteSacrificio = value
    '    End Set
    'End Property

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim Nuevo As Boolean = False

            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            Else
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Recepcion de Pesadas")
                Trans.Add(Entity)
                Nuevo = True
            End If

            Estatus = "X"
            If Entity.Save() Then

                If Nuevo Then
                    Trans.Commit()
                End If
                Return True
            Else
                Throw New Exception("Error al intentar cancelarlo")
                Return False
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Me.Entidad.TipoPesada.HasValue() Then
                Dim Nuevo As Boolean = False

                If Not Trans Is Nothing Then
                    Trans.Add(Entity)
                Else
                    Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Recepcion de Pesadas")
                    Trans.Add(Entity)
                    Nuevo = True
                End If

                For i As Integer = 0 To Detalle.Count - 1
                    Detalle(i).Cabecero = Me
                    Detalle(i).Renglon = i + 1
                Next

                If Entity.IsNew Then
                    Dim Coleccion As New CC.McgcatTiposdeGanadoCollection()
                    Dim Folio As New FoliosClass()
                    Folio.Año = Now.Year
                    Folio.Mes = 1
                    Folio.Codigo = CodigodeFolios.RecepcionGanadoPie

                    If Not Folio.Guardar(Trans) Then
                        Throw New Exception("Ocurrio un error al generar el folio")
                    End If

                    Entity.LoteRecepcion = Folio.Año.Substring(2) & Folio.Consecutivo.ToString("00000000")
                    Coleccion.GetMulti(Nothing)
                    IdTipoGanado = Coleccion(0).IdTipoGanado

                    If Not Entity.Save(True) Then
                        Throw New Exception("Error al intentar guardar la Recepcion de Pesadas")
                    End If
                Else
                    Dim DetalleAnterior As RecepcionPesadasDetalleCollectionClass = New RecepcionGanadoClass(LoteRecepcion).Detalle

                    If TipoPesada = Tipo.Ingrediente Then
                        DetalleAnterior(0).IdProducto = Detalle(0).IdProducto
                        DetalleAnterior(0).Guardar(Trans)
                    ElseIf TipoPesada = Tipo.Otros Then
                        DetalleAnterior(0).DescripcionProducto = Detalle(0).DescripcionProducto
                        DetalleAnterior(0).Guardar(Trans)
                    Else
                        For Each Item As RecepcionPesadasDetalleClass In DetalleAnterior
                            If Not Modificada(Item, Trans) Then
                                Item.Borrar(Trans)
                            End If
                        Next

                        For Each Item As RecepcionPesadasDetalleClass In Detalle
                            Item.Guardar(Trans)
                        Next
                    End If
                End If

                If Not Entity.Save() Then
                    Throw New Exception("Error al intentar guardar la Recepcion de Pesadas")
                End If

                If Nuevo Then
                    Trans.Commit()
                End If
            Else

                If SPA.UspRecepcionGanado(LoteRecepcion, FechaRecepcion, IdProveedor, LoteEngorda, CantCabezas, KilosEnviados, KilosRecibidos, Unidad, Conductor, Placas, Observaciones, IdUsuario, TipoGanado.IdTipoGanado, Estatus, FechaCancelacion, IdUsuarioCancelacion, ObservacionesCancelacion, KilosPrimeraPesada, KilosSegundaPesada, IdCliente, CveLugarCompra, CveCompradorGanado, HorasViaje, KilosComp, ImporteComp, DiasCredito, FechaPago, NumFactura, FechaContabilidad, NumPoliza, CabezasMachos, CabezasHembras, Func, NumOpc) = 0 Then
                    RaiseEvent MensajeError(Me, "Error al guardar información de Recepción de Ganado")
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            If Not Trans Is Nothing Then
                Trans.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Modificada(ByRef Item As RecepcionPesadasDetalleClass, ByRef Trans As HC.Transaction) As Boolean
        For Each DetalleActual As RecepcionPesadasDetalleClass In Detalle
            If Item.IdTipoGanado = DetalleActual.IdTipoGanado Then
                Item.CantCabezas = DetalleActual.CantCabezas
                Item.Guardar(Trans)
                Detalle.Remove(DetalleActual)
                Return True
            End If
        Next
        Return False
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Function Obtener(ByVal Codigo As Integer) As Boolean

    End Function

    Public Function Obtener(ByVal LoteRecepcion As String) As Boolean
        Try
            Return Entity.FetchUsingPK(LoteRecepcion)
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se encuentran recepciones de ganado vigentes")
            Obtener = Nothing
        End Try
    End Function
#End Region

#Region "Constructores"
    Public Sub New()
        Entity = New EC.RecepcionGanadoEntity
        Entity.LoteEngorda = ""
        Entity.LoteRecepcion = ""
        Entity.CantCabezas = 0
        Entity.Conductor = ""
        Entity.Estatus = "V"
        Entity.IdUsuario = 0
        'ojo
        ' Recepcion.IdIntroductor = 0
        Entity.IdUsuarioCancelacion = 0
        Entity.KilosEnviados = 0
        Entity.KilosRecibidos = 0
        Entity.ObservacionesCancelacion = ""
        Entity.Placas = ""
        Entity.Unidad = ""
        Entity.FechaCancelacion = "01/01/1900"
        Entity.FechaRecepcion = "01/01/1900"
        Entity.Observaciones = ""
        'ojo
        'Recepcion.LoteSacrificio = ""
    End Sub

    Sub New(ByVal Entidad As EC.RecepcionGanadoEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal LoteRecepcion As String)
        Entity = New EC.RecepcionGanadoEntity(LoteRecepcion)
    End Sub
#End Region
End Class

Public Class RecepcionGanadoColeccion

    Inherits ColleccionBase(Of EC.RecepcionGanadoEntity, CC.RecepcionGanadoCollection, RecepcionGanadoClass)

    Public Overloads Function Obtener(Optional ByVal IntroductorNombre As String = "", Optional ByVal FechaInicio As Date = Nothing, Optional ByVal FechaFinal As Date = Nothing) As Integer
        Try
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Dim rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection
            rel.Add(EC.RecepcionGanadoEntity.Relations.MfacCatClientesEntityUsingIdCliente, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            FechaFinal.AddDays(1)

            If Not IsNothing(FechaInicio.ToShortDateString) And Not IsNothing(FechaFinal.ToShortDateString) Then
                Filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(HC.RecepcionGanadoFields.FechaRecepcion, FechaInicio.ToShortDateString, FechaFinal.ToShortDateString))
            End If

            If Not IntroductorNombre = "" Then
                Filtro.Add(HC.MfacCatClientesFields.Nombre Mod String.Format("%{0}%", IntroductorNombre))
            End If

            coleccion.GetMulti(Filtro, rel)

            Rellenar()

            Return Me.Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
    Public Overloads Function Obtener(ByVal Folio As String, ByVal LoteEngorda As String, ByVal Estatus As String, Optional ByVal Introductor As Integer = 0) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Folio <> "" Then
                filtro.Add(HC.RecepcionGanadoFields.LoteRecepcion = Folio)
            End If
            If LoteEngorda <> "" Then
                filtro.Add(HC.RecepcionGanadoFields.LoteEngorda = LoteEngorda)
            End If
            If Introductor <> 0 Then
                filtro.Add(HC.RecepcionGanadoFields.IdCliente = Introductor)
            End If
            If Estatus <> "" Then
                If Estatus = "V" Then
                    filtro.Add(HC.RecepcionGanadoFields.Estatus = Estatus)
                ElseIf Estatus = "X" Then
                    filtro.Add(HC.RecepcionGanadoFields.Estatus = Estatus)
                End If
            End If
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
    Public Overloads Function Obtener(ByVal FechaInicio As Date, ByVal FechaFinal As Date, ByVal Estatus As String) As Integer
        Try
            Me.Clear()
            FechaFinal.AddDays(1)
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(HC.RecepcionGanadoFields.FechaRecepcion, FechaInicio.ToShortDateString, FechaFinal.AddDays(1).ToShortDateString))
            If Estatus <> "" Then
                If Estatus = "V" Then
                    filtro.Add(HC.RecepcionGanadoFields.Estatus = Estatus)
                ElseIf Estatus = "X" Then
                    filtro.Add(HC.RecepcionGanadoFields.Estatus = Estatus)
                End If
            End If
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function
    '    Public Function Obtener(ByVal Introductor As Integer) As Integer
    '        Try
    '            Dim fields As New HC.ResultsetFields(1)
    '            Dim rel As New OC.RelationCollection
    '            Dim lis As New DAO.TypedListDAO
    '            Dim tb As New DataTable
    '            Dim grup As New OC.GroupByCollection
    '            Dim recepciones As New List(Of String)
    '            Dim col As New CC.RecepcionGanadoCollection
    '            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    '            filtro.Add(HC.RecepcionGanadoFields.Estatus = "V")
    '            filtro.Add(HC.RecepcionGanadoFields.IdCliente = Introductor)
    '            fields.DefineField(ORM.RecepcionGanadoFieldIndex.LoteRecepcion, 0, "LoteRecepcion")
    '            rel.Add(EC.RecepcionGanadoEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteRecepcion, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
    '            grup.Add(HC.RecepcionGanadoFields.LoteRecepcion)

    '            lis.GetMultiAsDataTable(fields, tb, 0, Nothing, filtro, rel, True, grup, Nothing, 0, 0)

    '            For i As Integer = 0 To tb.Rows.Count - 1
    '                recepciones.Add(tb.Rows(i)(0))
    '            Next

    '            If recepciones.Count = 0 Then
    '                col.GetMulti(Nothing)
    '            Else
    '                col.GetMulti(New OC.FieldCompareRangePredicate(HC.RecepcionGanadoFields.LoteRecepcion, True, recepciones.ToArray))
    '            End If

    '        Catch ex As Exception
    '            Return Nothing
    '#If CONFIG = "Debug" Then
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '#Else
    '            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
    '#End If
    '        End Try
    '    End Function
    Public Function Reporte(ByVal Usuario As String, ByVal Empresa As String, ByVal Modulo As String) As RptRecepcionGanado
        Dim Rep As New RptRecepcionGanado
        Dim Ds As New DataSet
        Dim DT As New DsRecepcionGanado.DtRecepcionGanadoDataTable
        For Each Recep As RecepcionGanadoClass In Me            
            DT.AddDtRecepcionGanadoRow(Recep.FechaRecepcion, Recep.LoteRecepcion, Recep.LoteEngorda, Recep.NombreIntroductor, Recep.KilosEnviados, Recep.KilosRecibidos, Recep.Estatus, Recep.Unidad, Recep.Conductor, Recep.Placas, Recep.KilosPrimeraPesada, Recep.KilosSegundaPesada, Recep.CantCabezas, Recep.Observaciones, Recep.TipoGanado.Descripcion)
        Next
        Ds.Tables.Add(DT)
        Rep.SetDataSource(Ds)
        Rep.SetParameterValue(0, Empresa)
        Rep.SetParameterValue(1, Usuario)
        'Rep.SetParameterValue(2, Modulo)

        Return Rep
    End Function

    Public Shared Function ImprimirRecepcionPesadas(ByVal NomEmpresa As String, ByVal NomUsuario As String, Optional ByVal Folio As String = Nothing) As Boolean
        Try
            Dim ds As New DataSet()
            Dim dtEncabezado As DataTable = Nothing
            Dim dtDetalle As DataTable = Nothing
            Dim rep As New rptRecepcionPesadas
            Dim vent As New PreVisualizarForm

            If Folio Is Nothing Then
                dtEncabezado = CC.RecepcionGanadoCollection.GetMultiAsDataTable(New OC.FieldCompareNullPredicate(HC.RecepcionGanadoFields.TipoPesada, True), 0, New OC.SortExpression(New OC.SortClause(HC.RecepcionGanadoFields.FechaRecepcion, OC.SortOperator.Ascending)))
                Dim Filtro As New OC.PredicateExpression()

                For Each Row As DataRow In dtEncabezado.Rows
                    Filtro.AddWithOr(HC.UsrProdRecepcionDetalleFields.LoteRecepcion = Row.Item("LoteRecepcion"))
                Next
                dtDetalle = CC.UsrProdRecepcionDetalleCollection.GetMultiAsDataTable(Filtro, 0, Nothing)
            Else
                dtEncabezado = CC.RecepcionGanadoCollection.GetMultiAsDataTable(HC.RecepcionGanadoFields.LoteRecepcion = Folio, 0, Nothing)
                dtDetalle = CC.UsrProdRecepcionDetalleCollection.GetMultiAsDataTable(HC.UsrProdRecepcionDetalleFields.LoteRecepcion = Folio, 0, New OC.SortExpression(New OC.SortClause(HC.UsrProdRecepcionDetalleFields.Renglon, OC.SortOperator.Ascending)))
            End If

            dtEncabezado.TableName = "Cabecero"
            dtEncabezado.Columns("LoteRecepcion").ColumnName = "Folio"
            dtEncabezado.Columns("FechaRecepcion").ColumnName = "Fecha"
            dtEncabezado.Columns("CantCabezas").ColumnName = "TotalCabezas"
            dtEncabezado.Columns.Add("NombreProveedor")
            For Each row As DataRow In dtEncabezado.Rows
                If Not IsDBNull(row.Item("IdProveedor")) Then
                    row.Item("NombreProveedor") = ProveedorClass.CargarProveedor(row.Item("IdProveedor")).RazonSocial
                End If
            Next
            ds.Tables.Add(dtEncabezado)

            dtDetalle.TableName = "Detalle"
            dtDetalle.Columns("LoteRecepcion").ColumnName = "Folio"
            dtDetalle.Columns("Renglon").ColumnName = "IdRenglon"
            dtDetalle.Columns.Add("NombreTipoGanado")
            For Each row As DataRow In dtDetalle.Rows
                If Not IsDBNull(row.Item("IdTipoGanado")) Then
                    row.Item("NombreTipoGanado") = TipoGanadoClass.CargarTipoGanado(row.Item("IdTipoGanado")).Descripcion
                End If
            Next
            ds.Tables.Add(dtDetalle)

            rep.SetDataSource(ds)
            vent.Text = "Recepcion de Pesadas"
            rep.SetParameterValue(0, NomEmpresa)
            rep.SetParameterValue(1, "Compras de Ganado/Recepción de Pesadas")
            rep.SetParameterValue(2, NomUsuario)
            vent.Reporte = rep
            vent.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            vent.WindowState = Windows.Forms.FormWindowState.Maximized
            vent.ShowDialog()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class

Public Class RecepcionGanadoDetalleClass
    Inherits ClassBase(Of EC.UsrProdRecepcionGanadoDetEntity)

    Sub New()
        Entity.KilosEnPie = 0
        Entity.LoteRecepcion = ""
        Entity.LoteSacrificio = ""
        Entity.CantCabezas = 0
    End Sub

    Public Property LoteRecepcion() As String
        Get
            Return Entity.LoteRecepcion
        End Get
        Set(ByVal value As String)
            Entity.LoteRecepcion = value
        End Set
    End Property
    Public Property LoteSacrificio() As String
        Get
            Return Entity.LoteSacrificio
        End Get
        Set(ByVal value As String)
            Entity.LoteSacrificio = value
        End Set
    End Property
    Public Property KilosEnPie() As Decimal
        Get
            Return Entity.KilosEnPie
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosEnPie = value
        End Set
    End Property
    Public Property CantidadCabezas() As Integer
        Get
            Return Entity.CantCabezas
        End Get
        Set(ByVal value As Integer)
            Entity.CantCabezas = value
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

End Class

Public Class RecepcionGanadoDetColeccion
    Inherits ColleccionBase(Of EC.UsrProdRecepcionGanadoDetEntity, CC.UsrProdRecepcionGanadoDetCollection, RecepcionGanadoDetalleClass)

    Public Overloads Function Obtener(ByVal LoteSacrificio As String) As Integer
        Try
            Me.Clear()
            coleccion = New CC.UsrProdRecepcionGanadoDetCollection
            coleccion.GetMulti(HC.UsrProdRecepcionGanadoDetFields.LoteSacrificio = LoteSacrificio)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
End Class

Public Class RecepcionPesadasDetalleClass
    Inherits ClassBase(Of EC.UsrProdRecepcionDetalleEntity)

#Region "Miembros"
    Dim m_Cabecero As RecepcionGanadoClass
    Dim m_Producto As ProductoClass
    Dim m_TipoGanado As TipoGanadoClass
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Entidad As EC.UsrProdRecepcionDetalleEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal LoteRecepcion As String, ByVal Renglon As Integer)
        Entity = New EC.UsrProdRecepcionDetalleEntity(LoteRecepcion, Renglon)
    End Sub
#End Region

#Region "Propiedades"
    Property LoteRecepcion() As String
        Get
            Return Entity.LoteRecepcion
        End Get
        Set(ByVal value As String)
            Entity.LoteRecepcion = value
        End Set
    End Property

    Property Renglon() As Integer
        Get
            Return Entity.Renglon
        End Get
        Set(ByVal value As Integer)
            Entity.Renglon = value
        End Set
    End Property

    Property IdTipoGanado() As Integer
        Get
            Return Entity.IdTipoGanado
        End Get
        Set(ByVal value As Integer)
            Entity.IdTipoGanado = value
        End Set
    End Property

    Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    Property CantCabezas() As Integer
        Get
            Return Entity.CantCabezas
        End Get
        Set(ByVal value As Integer)
            Entity.CantCabezas = value
        End Set
    End Property

    Property DescripcionProducto() As String
        Get
            Return Entity.DescripcionProducto
        End Get
        Set(ByVal value As String)
            Entity.DescripcionProducto = value
        End Set
    End Property

    Property Cabecero() As RecepcionGanadoClass
        Get
            If m_Cabecero Is Nothing Then
                m_Cabecero = New RecepcionGanadoClass(Entity.RecepcionGanado)
            ElseIf Not m_Cabecero.LoteRecepcion = Me.LoteRecepcion Then
                m_Cabecero.Entidad = Entity.RecepcionGanado
            End If

            Return m_Cabecero
        End Get
        Set(ByVal value As RecepcionGanadoClass)
            m_Cabecero = value
            Entity.RecepcionGanado = IIf(value Is Nothing, Nothing, value.Entidad)
        End Set
    End Property

    Property TipoGanado() As TipoGanadoClass
        Get
            If m_TipoGanado Is Nothing Then
                m_TipoGanado = New TipoGanadoClass(Entity.McgcatTiposdeGanado)
            ElseIf Not m_TipoGanado.IdTipoGanado = Me.IdTipoGanado Then
                m_TipoGanado.Entidad = Entity.McgcatTiposdeGanado
            End If

            Return m_TipoGanado
        End Get
        Set(ByVal value As TipoGanadoClass)
            m_TipoGanado = value

            If value Is Nothing Then
                Entity.McgcatTiposdeGanado = Nothing
            Else
                Entity.McgcatTiposdeGanado = value.Entidad
            End If
        End Set
    End Property

    Property Producto() As ProductoClass
        Get
            If m_Producto Is Nothing Then
                m_Producto = New ProductoClass(Entity.Producto)
            ElseIf Not m_Producto.Codigo = Me.IdProducto Then
                m_Producto.Entidad = Entity.Producto
            End If

            Return m_Producto
        End Get
        Set(ByVal value As ProductoClass)
            m_Producto = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.Entidad
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim Nuevo As Boolean = False

            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            Else
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Recepcion de Pesadas")
                Trans.Add(Entity)
                Nuevo = True
            End If

            If Not Entity.Delete() Then
                Throw New Exception("Error al intentar eliminar el detalle de la recepcion")
            End If

            If Nuevo Then
                Trans.Commit()
            End If
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

End Class

Public Class RecepcionPesadasDetalleCollectionClass
    Inherits ColleccionBase(Of EC.UsrProdRecepcionDetalleEntity, CC.UsrProdRecepcionDetalleCollection, RecepcionPesadasDetalleClass)

#Region "Miembros"

#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal CollectionEntity As CC.UsrProdRecepcionDetalleCollection)
        Me.RellenarMe(CollectionEntity)
    End Sub
#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"

#End Region

End Class