Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.ComponentModel

Namespace AlmacenGeneral

    Public Class ConfiguracionMovimientoAlmacenGeneralClass
        Implements IDisposable

        Public Enum TipoMovimientoEnum
            Entradas_X_Inventario_Inicial
            Entradas_X_Compra
            Entradas_X_Devolucion_Venta
            Entradas_X_Traspaso
            Entradas_X_Devolucion_Consumo
            Entradas_X_Consignacion
            Entradas_X_Ajuste_Inventario
            Entradas_X_Otros
            Entradas_X_Cancelacion_Traspaso
            Entradas_X_Preparacion_Mezcla
            Entradas_X_Cancelacion_Salida_X_Preparacion_Mezcla
            Entradas_X_Cancelacion_Otras_Salidas
            Entradas_X_Medicamento
            Entradas_X_Proceso_Grano_Rolado
            Entradas_X_Cancelacion_Salida_Grano_Rolado
            Entradas_X_Regreso_Medicamento
            Entradas_X_Cacnelacion_Aplicacion_Formula
            Entradas_X_Cancelacion_Aplicacion_Medicamento

            Salidas_X_Venta
            Salidas_X_Devolucion_Compra
            Salidas_X_Traspaso
            Salidas_X_Consumo
            Salidas_X_Devolucion_Consignacion
            Salidas_X_Ajuste_Inventario
            Salidas_X_Otros
            Salidas_X_Cancelacion_Traspaso
            Salidas_X_Preparacion_Mezcla
            Salidas_X_Cancelacion_Entrada_X_Preparacion_Mezcla
            Salidas_X_Cancelacion_Otras_Entradas
            Salidas_X_Cancelacion_Entrada_X_Recepcion_Consignacion
            Salidas_X_Aplicacion_Formula
            Salidas_X_Aplicacion_Medicamento
            Salidas_X_Cancelacion_Entrada_Medicamento
            Salidas_X_Cancelacion_Entradas_X_Proceso_Grano_Rolado
            Salidas_X_Proceso_Grano_Rolado
            Salidas_X_Cancelacion_Regreso_Medicamento
        End Enum

#Region " IDispose "
        Private disposed As Boolean = False        ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposed Then
                If disposing Then
                    ' TODO: free unmanaged resources when explicitly called
                End If

                ' TODO: free shared unmanaged resources
            End If
            Me.disposed = True
        End Sub

#Region " IDisposable Support "
        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overrides Sub Finalize()
            ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            Dispose(False)
            MyBase.Finalize()
        End Sub
#End Region
#End Region

#Region " Declaraciones "
        Private Shared _tipos As TipoMovimientoAlmacenCollectionClass
        Private InvConfig As EC.InventarioConfiguracionEntity
        Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)
        Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region

#Region " Constructores "
        Sub New(ByVal Tipos As TipoMovimientoAlmacenCollectionClass)
            InvConfig = New EC.InventarioConfiguracionEntity
            _tipos = Tipos
            For x As Integer = 1 To 36
                tms.Add(Nothing)
            Next
        End Sub

        Sub New(ByVal Entidad As EC.InventarioConfiguracionEntity, ByVal Tipos As TipoMovimientoAlmacenCollectionClass)
            InvConfig = Entidad
            _tipos = Tipos
            For x As Integer = 1 To 36
                tms.Add(Nothing)
            Next
            Inicializar()
        End Sub

        Sub New(ByVal Indice As Integer, ByVal Tipos As TipoMovimientoAlmacenCollectionClass)
            InvConfig = New EC.InventarioConfiguracionEntity(Indice)
            _tipos = Tipos

            For x As Integer = 1 To 36
                tms.Add(Nothing)
            Next
            Inicializar()
        End Sub

        Private Sub Inicializar()

            tms(TipoMovimientoEnum.Entradas_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExAjusteInventario.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExCompra.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Consignacion) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExConsignacion.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Devolucion_Consumo) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExDevolucionConsumo.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Devolucion_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExDevolucionVenta.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Inventario_Inicial) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExInventarioInicial.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Otros) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExOtros.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExTraspaso.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExCancelacionTraspaso.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Preparacion_Mezcla) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExPreparaciionMezcla.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_X_Preparacion_Mezcla) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExCancelacionSalidaXpreparacionMezcla.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Otras_Salidas) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExCancelacionOtrasSalidas.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Medicamento) = ObtenerNombre(_tipos.Seleccionar(InvConfig.Exmedicamento.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Proceso_Grano_Rolado) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExprocesoGranoRolado.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_Grano_Rolado) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExcancelacionSalidaGranoRolado.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Regreso_Medicamento) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExregresoMedicamento.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Cacnelacion_Aplicacion_Formula) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExcancelacionAplicacionFormula.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Aplicacion_Medicamento) = ObtenerNombre(_tipos.Seleccionar(InvConfig.ExcancelacionAplicacionMedicamento.GetValueOrDefault(0)))

            tms(TipoMovimientoEnum.Salidas_X_Ajuste_Inventario) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxAjusteInventario.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Consumo) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxConsumo.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Devolucion_Compra) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxDevolucionCompra.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Devolucion_Consignacion) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxDevolucionConsignacion.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Otros) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxOtros.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxTraspaso.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Venta) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxVenta.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Traspaso) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxCancelacionTraspaso.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Preparacion_Mezcla) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxPreparacionMezcla.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Preparacion_Mezcla) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxCancelacionEntradaXpreparacionMezcla.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Otras_Entradas) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxCancelacionOtrasEntradas.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Recepcion_Consignacion) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxcancelacionEntradaRecepcionConsignacion.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Aplicacion_Formula) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxaplicacionFormula.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Aplicacion_Medicamento) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxaplicacionMedicamento.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_Medicamento) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxcancelacionEntradaMedicamento.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entradas_X_Proceso_Grano_Rolado) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxcancelacionEntradaProcesoGranoRolado.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Proceso_Grano_Rolado) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxprocesoGranoRolado.GetValueOrDefault(0)))
            tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Regreso_Medicamento) = ObtenerNombre(_tipos.Seleccionar(InvConfig.SxcancelacionRegresoMedicamento.GetValueOrDefault(0)))
        End Sub
#End Region

        Private Function ObtenerNombre(ByVal tipo As TipoMovimientoAlmacenClass) As String
            If Not IsNothing(tipo) Then Return tipo.Nombre
            Return Nothing
        End Function

#Region " Propiedades "

#Region " Declaraciones "
        Shared tms As New List(Of String)
        Dim Nulo As New System.Nullable(Of Integer)
#End Region

        '=================================================================='
        '=                           ENTRADAS                             ='
        '=================================================================='

        <Description("Movimiento utilizado para hacer el levantamiento inicial del invetario."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Inventario Inicial"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_InventarioInicial() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Inventario_Inicial)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Inventario_Inicial, Value)
                If opc > -1 Then
                    InvConfig.ExInventarioInicial = opc
                Else
                    InvConfig.ExInventarioInicial = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por compras."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Compra"), System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_Compra() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Compra)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Compra, Value)
                If opc > -1 Then
                    InvConfig.ExCompra = opc
                Else
                    InvConfig.ExCompra = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por devoluciones sobre ventas."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Devolución sobre Venta"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_DevolucionVenta() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Devolucion_Venta)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Devolucion_Venta, Value)
                If opc > -1 Then
                    InvConfig.ExDevolucionVenta = opc
                Else
                    InvConfig.ExDevolucionVenta = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por traspaso entre almacenes."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Traspaso"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_Traspaso() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Traspaso)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Traspaso, Value)
                If opc > -1 Then
                    InvConfig.ExTraspaso = opc
                Else
                    InvConfig.ExTraspaso = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por devoluciones por consumo."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Devolución sobre Consumo"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_DevolucionConsumo() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Devolucion_Consumo)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Devolucion_Consumo, Value)
                If opc > -1 Then
                    InvConfig.ExDevolucionConsumo = opc
                Else
                    InvConfig.ExDevolucionConsumo = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por Consignacion."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Consignación"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_Consignacion() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Consignacion)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Consignacion, Value)
                If opc > -1 Then
                    InvConfig.ExConsignacion = opc
                Else
                    InvConfig.ExConsignacion = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por Ajuste de Inventario."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Ajuste de Inventario"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_AjusteInventario() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Ajuste_Inventario)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Ajuste_Inventario, Value)
                If opc > -1 Then
                    InvConfig.ExAjusteInventario = opc
                Else
                    InvConfig.ExAjusteInventario = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por otros tipos de movimientos."), _
        TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Entradas x Otros"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_Otros() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Otros)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Otros, Value)
                If opc > -1 Then
                    InvConfig.ExOtros = opc
                Else
                    InvConfig.ExOtros = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por cancelación de salidas por traspasos."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Cancelación de Salidas Por Traspasos"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_Cancelacion_De_Salida_X_Traspaso() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Traspaso)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Cancelacion_Traspaso, Value)
                If opc > -1 Then
                    InvConfig.ExCancelacionTraspaso = opc
                Else
                    InvConfig.ExCancelacionTraspaso = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por preparación de mezclas."), _
    TypeConverter(GetType(TiposMovimientosClass)), _
    DisplayName("Entradas x Preparación de Mezcla"), _
    System.ComponentModel.Category("Entradas"), _
    System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_X_Preparacion_Mezcla() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Preparacion_Mezcla)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Preparacion_Mezcla, Value)
                If opc > -1 Then
                    InvConfig.ExPreparaciionMezcla = opc
                Else
                    InvConfig.ExPreparaciionMezcla = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por cancelacion de salida por preparación de mezclas."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Entradas x Cancelación de Salida x Preparación de Mezcla"), _
        System.ComponentModel.Category("Entradas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Entrada_X_Cancelacion_Salilda_X_Preparacion_Mezcla() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_X_Preparacion_Mezcla)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_X_Preparacion_Mezcla, Value)
                If opc > -1 Then
                    InvConfig.ExCancelacionSalidaXpreparacionMezcla = opc
                Else
                    InvConfig.ExCancelacionSalidaXpreparacionMezcla = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por cancelacion de otras salidas."), _
            TypeConverter(GetType(TiposMovimientosClass)), _
            DisplayName("Entradas x Cancelación de Otras Salidas"), _
            System.ComponentModel.Category("Entradas"), _
            System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
            Public Property Entrada_X_Cancelacion_Otras_Salidas() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Otras_Salidas)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Cancelacion_Otras_Salidas, Value)
                If opc > -1 Then
                    InvConfig.ExCancelacionOtrasSalidas = opc
                Else
                    InvConfig.ExCancelacionOtrasSalidas = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas de medicamentos."), _
    TypeConverter(GetType(TiposMovimientosClass)), _
    DisplayName("Entradas De Medicamentos"), _
    System.ComponentModel.Category("Entradas"), _
    System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
    Public Property Entrada_X_Medicamento() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Medicamento)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Medicamento, Value)
                If opc > -1 Then
                    InvConfig.Exmedicamento = opc
                Else
                    InvConfig.Exmedicamento = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por proceso de grano rolado."), _
TypeConverter(GetType(TiposMovimientosClass)), _
DisplayName("Entradas x Proceso de Grano Rolado"), _
System.ComponentModel.Category("Entradas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_X_Proceso_Grano_Rolado() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Proceso_Grano_Rolado)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Proceso_Grano_Rolado, Value)
                If opc > -1 Then
                    InvConfig.ExprocesoGranoRolado = opc
                Else
                    InvConfig.ExprocesoGranoRolado = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por cancelacion de salida por proceso de grano rolado."), _
TypeConverter(GetType(TiposMovimientosClass)), _
DisplayName("Entradas x Cancelacion de Salida Por Proceso de Grano Rolado"), _
System.ComponentModel.Category("Entradas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_X_Cancelacion_Salida_Proceso_Grano_Rolado() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_Grano_Rolado)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_Grano_Rolado, Value)
                If opc > -1 Then
                    InvConfig.ExcancelacionSalidaGranoRolado = opc
                Else
                    InvConfig.ExcancelacionSalidaGranoRolado = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por regreso de medicamento."), _
TypeConverter(GetType(TiposMovimientosClass)), _
DisplayName("Entradas x Regreso de Medicamento"), _
System.ComponentModel.Category("Entradas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_X_Regreso_Medicamento() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Regreso_Medicamento)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Regreso_Medicamento, Value)
                If opc > -1 Then
                    InvConfig.ExregresoMedicamento = opc
                Else
                    InvConfig.ExregresoMedicamento = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por cancelacion de aplicacion formula."), _
TypeConverter(GetType(TiposMovimientosClass)), _
DisplayName("Entradas Por Cancelacion de Aplicación Formula"), _
System.ComponentModel.Category("Entradas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_X_Cancelacion_Aplicacion_Formula() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Cacnelacion_Aplicacion_Formula)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Cacnelacion_Aplicacion_Formula, Value)
                If opc > -1 Then
                    InvConfig.ExcancelacionAplicacionFormula = opc
                Else
                    InvConfig.ExcancelacionAplicacionFormula = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las entradas por cancelacion de aplicacion medicamento."), _
TypeConverter(GetType(TiposMovimientosClass)), _
DisplayName("Entradas Por Cancelacion de Aplicación Medicamento"), _
System.ComponentModel.Category("Entradas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Entrada_X_Cancelacion_Aplicacion_Medicamento() As String
            Get
                Return tms(TipoMovimientoEnum.Entradas_X_Cancelacion_Aplicacion_Medicamento)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Entradas_X_Cancelacion_Aplicacion_Medicamento, Value)
                If opc > -1 Then
                    InvConfig.ExcancelacionAplicacionMedicamento = opc
                Else
                    InvConfig.ExcancelacionAplicacionMedicamento = Nulo
                    MsgBox("Este movimiento ya fue seleccionado", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        '=================================================================='
        '=                            SALIDAS                             ='
        '=================================================================='

        <Description("Movimiento utilizado para las salidas por ventas."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Salidas x Venta"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_Venta() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Venta)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Venta, Value)
                If opc > -1 Then
                    InvConfig.SxVenta = opc
                Else
                    InvConfig.SxVenta = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por devoluciones sobre compras."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Salidas x Devolución sobre Compra"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_DevolucionCompra() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Devolucion_Compra)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Devolucion_Compra, Value)
                If opc > -1 Then
                    InvConfig.SxDevolucionCompra = opc
                Else
                    InvConfig.SxDevolucionCompra = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por traspaso entre almacenes."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Salidas x Traspaso"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_Traspaso() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Traspaso)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Traspaso, Value)
                If opc > -1 Then
                    InvConfig.SxTraspaso = opc
                Else
                    InvConfig.SxTraspaso = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por consumo."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Salidas x Consumo"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_Consumo() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Consumo)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Consumo, Value)
                If opc > -1 Then
                    InvConfig.SxConsumo = opc
                Else
                    InvConfig.SxConsumo = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por devoluciones sobre consignaciones."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Salidas x Devolución por Consignación"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_DevolucionConsignacion() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Devolucion_Consignacion)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Devolucion_Consignacion, Value)
                If opc > -1 Then
                    InvConfig.SxDevolucionConsignacion = opc
                Else
                    InvConfig.SxDevolucionConsignacion = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por ajuste de inventarios."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Salidas x Ajuste de Inventario"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_AjusteInventario() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Ajuste_Inventario)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Ajuste_Inventario, Value)
                If opc > -1 Then
                    InvConfig.SxAjusteInventario = opc
                Else
                    InvConfig.SxAjusteInventario = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por otros tipos de movimientos."), _
        TypeConverter(GetType(TiposMovimientosClass)), _
        DisplayName("Salidas x Otros"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_Otros() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Otros)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Otros, Value)
                If opc > -1 Then
                    InvConfig.SxOtros = opc
                Else
                    InvConfig.SxOtros = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por cancelación de entradas por traspaso."), _
        TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Cancelación de Entradas Por Traspaso"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_X_Cancelacion_De_Entradas_X_Traspaso() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Traspaso)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Cancelacion_Traspaso, Value)
                If opc > -1 Then
                    InvConfig.SxCancelacionTraspaso = opc
                Else
                    InvConfig.SxCancelacionTraspaso = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por preparación de mezcla."), _
        TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Preparación de Mezclas"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_X_Preparacion_Mezcla() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Preparacion_Mezcla)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Preparacion_Mezcla, Value)
                If opc > -1 Then
                    InvConfig.SxPreparacionMezcla = opc
                Else
                    InvConfig.SxPreparacionMezcla = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por cancelación de entrada por preparación de mezcla."), _
        TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Cancelación de Entrada x Preparación de Mezclas"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_X_Cancelacion_Entrada_X_Preparacion_Mezcla() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Preparacion_Mezcla)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Preparacion_Mezcla, Value)
                If opc > -1 Then
                    InvConfig.SxCancelacionEntradaXpreparacionMezcla = opc
                Else
                    InvConfig.SxCancelacionEntradaXpreparacionMezcla = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por cancelación de otras entradas."), _
            TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Cancelación de Otras Entradas"), _
            System.ComponentModel.Category("Salidas"), _
            System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
            Public Property Salida_X_Cancelacion_Otras_Entradas() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Otras_Entradas)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Cancelacion_Otras_Entradas, Value)
                If opc > -1 Then
                    InvConfig.SxCancelacionOtrasEntradas = opc
                Else
                    InvConfig.SxCancelacionOtrasEntradas = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por cancelación de entradas por recepcion por consignacion."), _
        TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Cancelación de Entradas Por Recepcion Por Consignacion"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_X_Cancelacion_Entradas_Recepcion_Consignacion() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Recepcion_Consignacion)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Recepcion_Consignacion, Value)
                If opc > -1 Then
                    InvConfig.SxcancelacionEntradaRecepcionConsignacion = opc
                Else
                    InvConfig.SxcancelacionEntradaRecepcionConsignacion = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por aplicación de formula."), _
        TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Aplicación de Formula"), _
        System.ComponentModel.Category("Salidas"), _
        System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
        Public Property Salida_X_Aplicacion_Formula() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Aplicacion_Formula)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Aplicacion_Formula, Value)
                If opc > -1 Then
                    InvConfig.SxaplicacionFormula = opc
                Else
                    InvConfig.SxaplicacionFormula = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por aplicación de medicameto."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Aplicación de Medicamento"), _
System.ComponentModel.Category("Salidas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_X_Aplicacion_Medicamento() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Aplicacion_Medicamento)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Aplicacion_Medicamento, Value)
                If opc > -1 Then
                    InvConfig.SxaplicacionMedicamento = opc
                Else
                    InvConfig.SxaplicacionMedicamento = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por cancelación de entrada de medicamento."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Cancelación Entrada de Medicamento"), _
System.ComponentModel.Category("Salidas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_X_Cancelacion_Entrada_Medicamento() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_Medicamento)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_Medicamento, Value)
                If opc > -1 Then
                    InvConfig.SxcancelacionEntradaMedicamento = opc
                Else
                    InvConfig.SxcancelacionEntradaMedicamento = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por cancelación de entrada por proceso de grano rolado."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Cancelación Entrada x Proceso de Grano Rolado"), _
System.ComponentModel.Category("Salidas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_X_Cancelacion_Entrada_Proceso_Grano_Rolado() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Entradas_X_Proceso_Grano_Rolado)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Cancelacion_Entradas_X_Proceso_Grano_Rolado, Value)
                If opc > -1 Then
                    InvConfig.SxcancelacionEntradaProcesoGranoRolado = opc
                Else
                    InvConfig.SxcancelacionEntradaProcesoGranoRolado = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por proceso grano rolado."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Proceso de Grano Rolado"), _
System.ComponentModel.Category("Salidas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_X_Proceso_Grano_Rolado() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Proceso_Grano_Rolado)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Proceso_Grano_Rolado, Value)
                If opc > -1 Then
                    InvConfig.SxprocesoGranoRolado = opc
                Else
                    InvConfig.SxprocesoGranoRolado = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        <Description("Movimiento utilizado para las salidas por cancelación regreso de medicamento."), _
TypeConverter(GetType(TiposMovimientosClass)), DisplayName("Salidas x Cancelación Regreso de Medicamento"), _
System.ComponentModel.Category("Salidas"), _
System.ComponentModel.RefreshProperties(RefreshProperties.All)> _
Public Property Salida_X_Cancelacion_Regreso_Medicamento() As String
            Get
                Return tms(TipoMovimientoEnum.Salidas_X_Cancelacion_Regreso_Medicamento)
            End Get
            Set(ByVal Value As String)
                Dim opc As Integer = EstablecerValor(TipoMovimientoEnum.Salidas_X_Cancelacion_Regreso_Medicamento, Value)
                If opc > -1 Then
                    InvConfig.SxcancelacionRegresoMedicamento = opc
                Else
                    InvConfig.SxcancelacionRegresoMedicamento = Nulo
                    MsgBox("Este tipo de movimiento ya fue seleccionado.", MsgBoxStyle.Information, "Aviso")
                End If
            End Set
        End Property

        Private Function EstablecerValor(ByVal Indice As Integer, ByVal Valor As String) As Integer
            Dim bl As Boolean = False
            For Each texto As String In tms
                If texto = Valor Then
                    bl = True
                    Exit For
                End If
            Next
            If Not bl Then
                tms(Indice) = Valor
                Return _tipos.Seleccionar(Valor).Codigo
            Else
                tms(Indice) = Nothing
                Return -1
            End If
        End Function

        <System.ComponentModel.Browsable(False)> _
        Public Property Estatus() As EstatusEnum
            Get

            End Get
            Set(ByVal value As EstatusEnum)

            End Set
        End Property

        Public Function ObtenerTipoMovimiento(ByVal TipoMovimiento As TipoMovimientoEnum) As TipoMovimientoAlmacenClass
            If Not IsNothing(tms(TipoMovimiento)) Then
                Return _tipos.Seleccionar(tms(TipoMovimiento))
            Else
                Return Nothing
            End If
        End Function

#End Region

#Region " Metodos "
        Public Function Guardar() As Boolean
            Return InvConfig.Save
        End Function

        Public Sub LeerEntidad(ByVal Entidad As EC.InventarioConfiguracionEntity)
            InvConfig = Entidad
        End Sub

        Public Function ObtenerEntidad() As EC.InventarioConfiguracionEntity
            Return InvConfig
        End Function
#End Region

#Region " Clases "
        Public Class TiposMovimientosClass
            Inherits StringConverter

            Private mTipos As New TipoMovimientoAlmacenCollectionClass

            Public Sub New()
                MyBase.New()
                For Each tipo As TipoMovimientoAlmacenClass In _tipos
                    Dim b As Boolean = False
                    For Each t As String In tms
                        If tipo.Nombre = t Then b = True
                    Next
                    If Not b Then mTipos.Add(tipo)
                Next
            End Sub

            Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                'True = Se despliega la lista
                'False = No se despliega la lista y el ususario debe escribir un valor
                Return True
            End Function

            Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(_tipos)
            End Function

            Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                'True = el combo no admite más items que los de la lista
                'False = el combo admite un item que no esté en la lista
                Return True
            End Function

        End Class
#End Region
    End Class

End Namespace