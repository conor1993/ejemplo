Public Class TurnosClass
    Inherits System.ComponentModel.BindingList(Of TurnoClass)

    Sub New()
        Me.Add(New TurnoClass(TurnoEnum.MATUTINO))
        Me.Add(New TurnoClass(TurnoEnum.VESPERTINO))
        Me.Add(New TurnoClass(TurnoEnum.NOCTURNO))
        Me.Add(New TurnoClass(TurnoEnum.MIXTO))
    End Sub
End Class