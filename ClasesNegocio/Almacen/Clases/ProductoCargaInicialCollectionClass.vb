Imports System.Text.RegularExpressions

Public Class ProductoCargaInicialCollectionClass
    Inherits ColleccionBase(Of ProductoCargaInicialClass)

    Private m_ColeccionCompleta As ProductoCargaInicialCollectionClass
    Private m_HacerRespaldo As Boolean = True

    Public Sub Filtrar(ByVal nombreProducto As String, ByVal Linea As String)
        If Me.m_HacerRespaldo Then
            Me.m_ColeccionCompleta = New ProductoCargaInicialCollectionClass

            For Each prod As ProductoCargaInicialClass In Me
                Me.m_ColeccionCompleta.Add(prod)
            Next
            Me.m_HacerRespaldo = False
        End If

        Me.Clear()

        If nombreProducto.Trim.Length > 0 AndAlso Linea.Trim.Length > 0 Then
            For Each prod As ProductoCargaInicialClass In Me.m_ColeccionCompleta
                If Regex.Matches(prod.Linea, Linea, RegexOptions.IgnoreCase).Count > 0 AndAlso Regex.Matches(prod.Producto, nombreProducto, RegexOptions.IgnoreCase).Count > 0 Then
                    MyBase.Add(prod)
                End If
            Next
        ElseIf nombreProducto.Trim.Length > 0 Then
            For Each prod As ProductoCargaInicialClass In Me.m_ColeccionCompleta
                If Regex.Matches(prod.Producto, nombreProducto, RegexOptions.IgnoreCase).Count > 0 Then
                    MyBase.Add(prod)
                End If
            Next
        ElseIf Linea.Trim.Length > 0 Then
            For Each prod As ProductoCargaInicialClass In Me.m_ColeccionCompleta
                If Regex.Matches(prod.Linea, Linea, RegexOptions.IgnoreCase).Count > 0 Then
                    MyBase.Add(prod)
                End If
            Next
        Else
            For Each prod As ProductoCargaInicialClass In Me.m_ColeccionCompleta
                MyBase.Add(prod)
            Next
        End If
    End Sub
End Class