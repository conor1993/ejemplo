''' <summary>
''' Contiene los requerimiento para crear el detalle de un movimiento de ganado
''' </summary>
''' <remarks></remarks>
Public Interface IMovimientoGanadoDetalle
    Property IdTipoGanado() As Integer
    ReadOnly Property FolioMovimeintoGanado() As String
    ReadOnly Property MovimeintoGanado() As MovimientoGanadoClass
    Property FechaMovimiento() As Date
    Property Cabezas() As Integer
    Property Kilos() As Decimal
    Property CostoKilo() As Decimal
    ReadOnly Property Importe() As Decimal
End Interface

''' <summary>
''' Contiene los requerimiento para crear el detalle de un movimiento de ganado
''' </summary>
''' <remarks></remarks>
Public Interface IMovimientoGanadoDetalleCancelacion
    Property IdTipoGanado() As Integer
    ReadOnly Property FolioMovimeintoGanado() As String
    ReadOnly Property MovimeintoGanado() As MovimientoGanadoClass
    Property Cabezas() As Integer
    Property Kilos() As Decimal
    Property CostoKilo() As Decimal
    ReadOnly Property Importe() As Decimal
    Property FechaCancelacion() As Nullable(Of Date)
End Interface