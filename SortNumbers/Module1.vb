Imports System.Collections.Generic

Module Module1
    Sub Main()
        ' Create an empty list to store positive integers
        Dim numbers As New List(Of Integer)()

        ' Continuously prompt for input until 5 unique positive integers are entered
        While numbers.Count < 5
            System.Console.ForegroundColor = ConsoleColor.Cyan
            System.Console.Write("Enter a positive integer: ")
            System.Console.ForegroundColor = ConsoleColor.Yellow
            Dim input As String = System.Console.ReadLine()
            Dim number As Integer

            System.Console.BackgroundColor = ConsoleColor.Red
            System.Console.ForegroundColor = ConsoleColor.White
            ' Try to parse the input as an integer
            If Integer.TryParse(input, number) Then
                ' Check if the number is positive and not a duplicate
                If number <= 0 Then
                    System.Console.WriteLine("The entered number must be positive. Try again.")
                ElseIf numbers.Contains(number) Then
                    System.Console.WriteLine("The entered number is duplicate. Please enter another number.")
                Else
                    ' Add the valid number to the list
                    numbers.Add(number)
                End If
            Else
                System.Console.WriteLine("The input is invalid. Please enter a valid number.")
            End If
            System.Console.ResetColor()
        End While

        ' Sort the list in ascending order
        numbers.Sort()

        System.Console.ResetColor()
        System.Console.ForegroundColor = ConsoleColor.Blue
        ' Display the sorted numbers
        System.Console.WriteLine("Numbers in ascending order : ")
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White
        For Each num In numbers
            System.Console.WriteLine(num)
        Next
        System.Console.ResetColor()
        ' Display developer name and GitHub ID
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
        System.Console.ReadKey()
    End Sub
End Module
