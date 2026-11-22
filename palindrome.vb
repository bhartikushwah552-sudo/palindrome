
Module Module1
    Sub Main()
        Dim num, temp, rem, rev As Integer

        Console.Write("Enter a number: ")
        num = Convert.ToInt32(Console.ReadLine())

        temp = num
        rev = 0

        While num > 0
            rem = num Mod 10
            rev = rev * 10 + rem
            num = num \ 10
        End While

        If temp = rev Then
            Console.WriteLine("Number is Palindrome")
        Else
            Console.WriteLine("Number is Not Palindrome")
        End If

        Console.ReadKey()
    End Sub
End Module
