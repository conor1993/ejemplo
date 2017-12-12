Public Class OrdenarClass(Of TipoEntidad As IEntidad, Coleccion As CollectionClass(Of TipoEntidad))

    Public Sub Ordenar(ByRef FcColeccion As Coleccion, ByVal Inf As Integer, ByVal Sup As Integer, _
                            ByVal NombrePropiedad As String, ByVal Ordenamiento As System.ComponentModel.ListSortDirection)
        If Inf = Sup Then Exit Sub

        Dim TipoDato As TipoDatoEnum = TipoDatoEnum.Numero

        Select Case FcColeccion(Inf).GetType.GetProperty(NombrePropiedad).GetValue(FcColeccion(Inf), Nothing).GetType.ToString
            Case "System.Int16"
            Case "System.Int32"
            Case "System.Int64"
            Case "System.Decimal"
            Case "System.Double"
            Case "System.Single"
            Case "System.SByte"
            Case "System.DateTime"
                TipoDato = TipoDatoEnum.FECHA
            Case "System.Byte"
            Case Else
                TipoDato = TipoDatoEnum.CADENA
        End Select

        Dim Leng As Integer = Sup - Inf + 1
        Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

        Ordenar(FcColeccion, Inf, Sel, NombrePropiedad, Ordenamiento)
        Ordenar(FcColeccion, Sel + 1, Sup, NombrePropiedad, Ordenamiento)

        Dim temp(Leng) As TipoEntidad

        For i As Integer = 0 To Leng - 1
            temp(i) = FcColeccion(Inf + i)
        Next

        Dim M1 As Integer = 0
        Dim M2 As Integer = Sel - Inf + 1
        Dim n1, n2 As Decimal
        Dim n3 As String = ""
        Dim n4 As String = ""
        Dim d1 As Date = "01/01/1990"
        Dim d2 As Date = "01/01/1990"

        For i As Integer = 0 To Leng - 1
            If M2 <= (Sup - Inf) Then
                If M1 <= (Sel - Inf) Then

                    If TipoDato = TipoDatoEnum.Numero Then
                        n1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
                        n2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
                    ElseIf TipoDato = TipoDatoEnum.Cadena Then
                        n3 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing).ToString
                        n4 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing).ToString
                    Else
                        d1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
                        d2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
                    End If

                    If IIf(TipoDato = TipoDatoEnum.Numero, IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, n1 > n2, n1 < n2), _
                        IIf(TipoDato = TipoDatoEnum.Cadena, _
                        IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, String.Compare(n3, n4) > 0, String.Compare(n3, n4) < 0), _
                        IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, d1 > d2, d1 < d2))) Then
                        FcColeccion(i + Inf) = temp(M2)
                        M2 += 1
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If

                Else
                    FcColeccion(i + Inf) = temp(M2)
                    M2 += 1
                End If
            Else
                FcColeccion(i + Inf) = temp(M1)
                M1 += 1
            End If
        Next
    End Sub
End Class

'Public Class OrdenarClass2(Of TipoEntity As {SD.LLBLGen.Pro.ORMSupportClasses.EntityBase, New}, TipoEntidad As {IEntidad2, New}, _
'                            TipoCollection As {SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase(Of TipoEntity), New}, _
'                            Coleccion As CollectionClass2(Of TipoEntity, TipoEntidad, TipoCollection))

'    Public Sub Ordenar(ByRef FcColeccion As Coleccion, ByVal Inf As Integer, ByVal Sup As Integer, _
'                            ByVal NombrePropiedad As String, ByVal Ordenamiento As System.ComponentModel.ListSortDirection)

'        Dim TipoDato As TipoDatoEnum = TipoDatoEnum.Numero

'        Select Case FcColeccion(Inf).GetType.GetProperty(NombrePropiedad).GetValue(FcColeccion(Inf), Nothing).GetType.ToString
'            Case "System.Int16"
'            Case "System.Int32"
'            Case "System.Int64"
'            Case "System.Decimal"
'            Case "System.Double"
'            Case "System.Single"
'            Case "System.SByte"
'            Case "System.DateTime"
'                TipoDato = TipoDatoEnum.Fecha
'            Case "System.Byte"
'            Case Else
'                TipoDato = TipoDatoEnum.Cadena
'        End Select

'        If Inf = Sup Then Exit Sub

'        Dim Leng As Integer = Sup - Inf + 1
'        Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

'        Ordenar(FcColeccion, Inf, Sel, NombrePropiedad, Ordenamiento)
'        Ordenar(FcColeccion, Sel + 1, Sup, NombrePropiedad, Ordenamiento)

'        Dim temp(Leng) As TipoEntidad

'        For i As Integer = 0 To Leng - 1
'            temp(i) = FcColeccion(Inf + i)
'        Next

'        Dim M1 As Integer = 0
'        Dim M2 As Integer = Sel - Inf + 1
'        Dim n1, n2 As Decimal
'        Dim n3 As String = ""
'        Dim n4 As String = ""
'        Dim d1 As Date = "01/01/1990"
'        Dim d2 As Date = "01/01/1990"

'        For i As Integer = 0 To Leng - 1
'            If M2 <= (Sup - Inf) Then
'                If M1 <= (Sel - Inf) Then

'                    If TipoDato = TipoDatoEnum.Numero Then
'                        n1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
'                        n2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
'                    ElseIf TipoDato = TipoDatoEnum.Cadena Then
'                        n3 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing).ToString
'                        n4 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing).ToString
'                    Else
'                        d1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
'                        d2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
'                    End If

'                    If IIf(TipoDato = TipoDatoEnum.Numero, IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, n1 > n2, n1 < n2), _
'                        IIf(TipoDato = TipoDatoEnum.Cadena, _
'                        IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, String.Compare(n3, n4) > 0, String.Compare(n3, n4) < 0), _
'                        IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, d1 > d2, d1 < d2))) Then
'                        FcColeccion(i + Inf) = temp(M2)
'                        M2 += 1
'                    Else
'                        FcColeccion(i + Inf) = temp(M1)
'                        M1 += 1
'                    End If

'                Else
'                    FcColeccion(i + Inf) = temp(M2)
'                    M2 += 1
'                End If
'            Else
'                FcColeccion(i + Inf) = temp(M1)
'                M1 += 1
'            End If
'        Next
'    End Sub

'End Class