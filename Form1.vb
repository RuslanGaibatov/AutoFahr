Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim binaryNumber As String = TextBox1.Text
        If IsBinary(binaryNumber) Then
            Dim decimalResult As Integer = BinaryToDecimal(binaryNumber)
            Label1.Text = "Dezimal: " & decimalResult.ToString()
        Else
            Label1.Text = "Bitte eine gültige Binärzahl eingeben."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim decimalNumber As Integer
        If Integer.TryParse(TextBox2.Text, decimalNumber) Then
            Dim binaryResult As String = DecimalToBinary(decimalNumber)
            Label1.Text = "Binär: " & binaryResult
        Else
            Label1.Text = "Bitte eine gültige Dezimalzahl eingeben."
        End If
    End Sub

    Private Function IsBinary(binary As String) As Boolean
        For Each c As Char In binary
            If c <> "0"c And c <> "1"c Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function BinaryToDecimal(binary As String) As Integer
        Dim decimalNumber As Integer = 0
        Dim length As Integer = binary.Length

        For i As Integer = 0 To length - 1
            If binary(i) = "1"c Then
                decimalNumber += Math.Pow(2, length - 1 - i)
            End If
        Next

        Return CInt(decimalNumber)
    End Function

    Private Function DecimalToBinary(decimalNumber As Integer) As String
        If decimalNumber = 0 Then
            Return "0"
        End If

        Dim binary As String = String.Empty

        While decimalNumber > 0
            binary = (decimalNumber Mod 2).ToString() & binary
            decimalNumber \= 2
        End While

        Return binary
    End Function
End Class
