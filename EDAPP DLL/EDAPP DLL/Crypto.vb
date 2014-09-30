Imports System.IO
Imports System.Random

Public Class Crypto
    Public Shared Function random_gen()
        Dim random As New Random()
        Dim firstRandom As Int64 = random.Next(1000000000, 2147483647)
        Dim multiplier As Int64 = random.Next(1, 1000)
        Dim number As Int64 = firstRandom * multiplier
        Return number
    End Function
    Public Shared Function check_serial(ByVal serialNumber As Int64, ByVal license As String)

        Dim number As Integer = 1
        Dim licStringsLenght As Integer = 0
        Dim licenseOK As Boolean
        Dim licenseVerified As String = " "
        For i As Integer = 0 To 100
            While number <> 0
                number = serialNumber Mod 10000
                serialNumber = serialNumber / 10000
                licenseVerified = licenseVerified.Insert(licStringsLenght, get_license(number).ToString)
                licStringsLenght = licenseVerified.Length
            End While
            Exit For
        Next
        licenseVerified = licenseVerified.Replace(" ", "X")
        If licenseVerified.Equals(license) Then
            licenseOK = True
            Return licenseOK
        Else
            licenseOK = False
            Return licenseOK
        End If
    End Function

    Public Shared Function get_license(ByVal tok As Integer)
        Dim numberToHex As Decimal = Math.Pow(tok, 4)
        Dim hexa As String = Hex(numberToHex)
        Return hexa
    End Function
    'Public Shared Function decrypt()

    'End Function
End Class
