Public Class RutinaClass
    Public Shared Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As _
            System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Public Shared Function ValidarUrl(ByVal URL As String) As Boolean
        'Comprobamos si la direcci�n es correcta, en caso de no ser as� devolvemos False y salimos de la funci�n.
        If Not System.Uri.IsWellFormedUriString(URL, UriKind.Absolute) Then
            Return False
            Exit Function
        End If
        'Instanciamos la clase Uri para poder comprobar el scheme.
        Dim objUri As Uri = New Uri(URL)
        'Y ahora comprobamos si es de tipo HTTP o HTTPs
        If objUri.Scheme = Uri.UriSchemeHttp Or objUri.Scheme = Uri.UriSchemeHttps Then
            Return True
            Exit Function
        Else
            Return False
        End If
    End Function
End Class
