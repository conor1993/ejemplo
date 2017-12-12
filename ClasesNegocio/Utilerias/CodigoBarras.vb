Public Class CodigoBarras

    Private Const _STOP As Integer = 156

    Private Shared Function ObtenerCodigo128(ByVal ascii As Integer) As Integer
        Try
            Dim res As Integer

            If ascii >= 33 AndAlso ascii <= 126 Then
                res = ascii - 32
            ElseIf ascii = 128 Then
                res = 0
            ElseIf ascii >= 145 AndAlso ascii <= 156 Then
                res = ascii - 50
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Shared Function ObtenerAscii(ByVal codigo128 As Integer) As Integer
        Try
            Dim res As Integer

            If codigo128 = 128 Then
                res = 0
            ElseIf codigo128 >= 1 AndAlso codigo128 <= 94 Then
                res = codigo128 + 32
            ElseIf codigo128 >= 95 AndAlso codigo128 <= 106 Then
                res = codigo128 + 50
            End If

            Return res
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Shared Function ObtenerCheckSum(ByVal cadena As String, ByVal codigo128 As Integer) As Integer
        Try
            Dim suma As Integer = codigo128

            For i As Integer = 1 To cadena.Length
                suma += ObtenerCodigo128(Asc(cadena.Chars(i - 1))) * i
            Next

            Return suma
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Shared Function ObtenerCheckDigit(ByVal checkSum As Integer) As Char
        Return Chr(ObtenerAscii((checkSum Mod 103)))
    End Function

    'function getBarcode(rawData) { 
    '	var offset = 32; 
    '	var highAscii = 18; 
    '	var newCodeString = new Array(rawData.length + 3); 

    '	newCodeString[0] = offset + highAscii + 104; 

    '	var total = 104; 

    '	for(var stringCounter = 0 ;stringCounter < rawData.length ; stringCounter++) 
    '	{ 
    '		var character = rawData.substr(stringCounter, 1); 
    '		var ASCIIValue = character.charCodeAt(0); 
    '		var checkDigit = ((ASCIIValue - offset) * (stringCounter + 1)); 

    '		total += checkDigit; 

    '		newCodeString[stringCounter + 1] = ASCIIValue; 
    '	} 


    '	var check = total % 103; 
    '	var holder = 0; 

    '            If (check + offset >= 127) Then
    '	{ 
    '		holder = check + offset + highAscii; 
    '	} 
    '            Else
    '	{
    '		holder = check + offset; 
    '	} 

    '	newCodeString[newCodeString.length - 2] = holder; 
    '	holder = 106 + offset + highAscii;
    '	newCodeString[newCodeString.length - 1] = holder; 

    '	for(var rCounter = 0; rCounter < newCodeString.length ; rCounter++) 
    '	{
    '		if(newCodeString[rCounter] == 32) 
    '		{ 
    '			newCodeString[rCounter] = 128; 
    '		} 
    '	}

    '	return getBarcodeText(newCodeString);
    '}

    Public Shared Function ObtenerCodigoBarra(ByVal cadena As String, ByVal starVariant As StarVariant) As String
        Try
            Dim offset As Integer = 32
            Dim highAscii As Integer = 18
            Dim newCodeString(cadena.Length + 3) As Integer

            newCodeString(0) = offset + highAscii + 104

            Dim total As Integer = 104

            For stringcounter As Integer = 0 To cadena.Length - 1
                Dim character As Char = cadena.Chars(stringcounter)
                Dim ASCIIValue As Integer = Asc(character)
                Dim checkDigit As Integer = ((ASCIIValue - offset) * (stringcounter + 1))

                total += checkDigit

                newCodeString(stringcounter + 1) = ASCIIValue
            Next

            Dim check As Integer = total Mod 103
            Dim holder As Integer = 0

            If check + offset >= 127 Then
                holder = check + offset + highAscii
            Else
                holder = check + offset
            End If

            newCodeString(newCodeString.Length - 2) = holder
            holder = 106 + offset + highAscii
            newCodeString(newCodeString.Length - 1) = holder

            For rCounter As Integer = 0 To newCodeString.Length - 1
                If newCodeString(rCounter) = 32 Then
                    newCodeString(rCounter) = 128
                End If
            Next

            Dim resultado As String = Nothing

            For Each digito As Integer In newCodeString
                resultado &= Chr(digito)
            Next

            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Enum StarVariant
        VariantB = 104
        VariantC = 105
    End Enum
End Class