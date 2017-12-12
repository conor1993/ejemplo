Public Class TurnoClass
    Private _Turno As TurnoEnum

    Property Turno() As TurnoEnum
        Get
            Return _Turno
        End Get
        Set(ByVal value As TurnoEnum)
            _Turno = value
        End Set
    End Property

    Sub New(ByVal Turno As TurnoEnum)
        _Turno = Turno
    End Sub
End Class

Public Enum TurnoEnum
    MATUTINO
    VESPERTINO
    NOCTURNO
    MIXTO
End Enum