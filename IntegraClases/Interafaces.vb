Public Interface IEntidad

    Event Modificado As EventHandler

    Event MensajeError As Integra.Clases.MensajeErrorHandler

    Property Estatus() As Integra.Clases.EstatusEnum

    Function Guardar() As Boolean

    Function Borrar() As Boolean

    Function Obtener(ByVal Codigo As Integer) As Boolean

End Interface