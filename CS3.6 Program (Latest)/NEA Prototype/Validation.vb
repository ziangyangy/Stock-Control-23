Module Validation
    'presence check function
    Function PresenceCheck(valueToCheck As String)
        If valueToCheck = "" Then
            Return False 'if no data present then returns False
        End If
        Return True 'if there is data present then returns True
    End Function

    'integer type check
    Function IntTypeCheck(valueToCheck As String)
        Dim tempInt As Integer 'stores the argument passed
        Try
            tempInt = valueToCheck 'tries to store the argument into tempInt
            Return True 'if it is an integer then returns True
        Catch ex As Exception
            Return False 'if not an integer then returns False
        End Try
    End Function

    'decimal type check
    Function DecimalTypeCheck(valueToCheck As String)
        Dim tempDecimal As Decimal 'stores the argument passed
        Try
            tempDecimal = valueToCheck 'tries to store the argument into tempDecimal
            Return True 'if it is a decimal then returns True
        Catch ex As Exception
            Return False 'if not a decimal then returns False
        End Try
    End Function

    'money format check
    Function MoneyFormatCheck(valueToCheck As String)
        Try
            Dim lengthValue As Integer = 0 'stores the length of the argument
            Dim decimalPosition As Integer = 0 'stores the position of the decimal point
            decimalPosition = valueToCheck.IndexOf(".") 'works out the decimal position
            lengthValue = valueToCheck.Length 'works out the length of the argument
            If lengthValue - decimalPosition = 3 Then 'if the length of the argument - position of decimal = 3 then
                If lengthValue > 3 Then 'if the whole length of the argument is more than 3 then
                    Return True 'return true
                Else
                    Return False 'return false if fails
                End If
            Else
                Return False 'return false if fails
            End If
        Catch ex As Exception
            Return False 'return false if an error occurs
        End Try
    End Function

    'smaller than length check
    Function lessThanLengthCheck(valueToCheck As String, length As Integer) 'length parameter is the length for the valueToCheck to be less than
        If Len(valueToCheck) < length Then
            Return True 'returns true if valueToCheck is less than the specified length
        Else
            Return False 'returns false if it is more than the specified length
        End If
    End Function

    'more than length check
    Function moreThanLengthCheck(valueToCheck As String, length As Integer) 'length parameter is the length for the valueToCheck to be more than
        If Len(valueToCheck) > length Then
            Return True 'returns true if valueToCheck is more than the specified length
        Else
            Return False 'returns false if it is less than the specified length
        End If
    End Function
End Module
