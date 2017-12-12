Public Class MesesCollectionClass
    Inherits System.ComponentModel.BindingList(Of MesesEnum)

    Sub New()
        For i As Integer = 1 To 12
            Add(CType(i, MesesEnum))
        Next
    End Sub

#Region "Enumeradores"
    Public Enum MesesEnum As Byte
        ENERO = 1
        FEBRERO
        MARZO
        ABRIL
        MAYO
        JUNIO
        JULIO
        AGOSTO
        SEPTIEMBRE
        OCTUBRE
        NOVIEMBRE
        DICIEMBRE
    End Enum
#End Region
End Class

Public Class AñoCollectionClass
    Inherits System.ComponentModel.BindingList(Of Integer)

    Sub New(ByVal fechaInicial As Date, ByVal fechaFinal As Date)
        For i As Integer = fechaInicial.Year To fechaFinal.Year
            Add(i)
        Next
    End Sub
End Class
