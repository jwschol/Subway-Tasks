Imports System.Console
Imports System.Threading.Thread
Imports System.Math
Module Program
    Dim cost As Single
    Dim typeofbread As Integer
    Dim length As Integer
    Dim topping As Integer
    Dim topping1 As String
    Dim bread As String
    Dim length1 As String
    Dim out1 As Single
    Dim inourout1 As String
    Sub Main()
        Clear()
        cost = 0
        Try
            WriteLine("Welcome to subway.")
            WriteLine("Would you like it to be 6 inch or 12 inch")
            length = ReadLine()
            If length = 6 Then
                WriteLine("6 inch bread")
                cost = cost + 1.65
                WriteLine("Current price is {0}", cost)
                length1 = "6 inch"
                breadselection()
            ElseIf length = 12 Then
                WriteLine("12 inch bread")
                cost = cost + 2.05
                WriteLine("Current price is {0}", cost)
                length1 = "12 inch"
                breadselection()
            Else
                WriteLine("Invalid Input, pleasde try again")
                Main()
            End If
        Catch ex As Exception
            WriteLine("Error")
            Sleep(2000)
            Clear()
            Main()
        End Try
    End Sub
    Sub breadselection()
        Clear()
        Try
            WriteLine("What type of bread")
            WriteLine("1, Plain")
            WriteLine("2, Wheat")
            WriteLine("3, Italian")
            WriteLine("4, Cheese")
            typeofbread = ReadLine()
            If typeofbread = 1 Then
                WriteLine("Plain")
                cost = cost + 0.4
                WriteLine("Current price is {0}", cost)
                bread = "Plain"
                toppingselection()
            ElseIf typeofbread = 2 Then
                WriteLine("Wheat")
                cost = cost + 0.65
                WriteLine("Current price is {0}", cost)
                bread = "Wheat"
                toppingselection()
            ElseIf typeofbread = 3 Then
                WriteLine("Italian")
                cost = cost + 0.75
                WriteLine("Current price is {0}", cost)
                bread = "Italian"
                toppingselection()
            ElseIf typeofbread = 4 Then
                WriteLine("Cheese")
                cost = cost + 0.8
                WriteLine("Current price is {0}", cost)
                bread = "Cheese"
                toppingselection()
            Else
                WriteLine("Invalid Input, please try again")
                breadselection()
            End If
        Catch ex As Exception
            WriteLine("Error")
            Sleep(2000)
            Clear()
            breadselection()
        End Try
    End Sub
    Sub toppingselection()
        Clear()
        Try
            WriteLine("What type of topping")
            WriteLine("1, Cheese & Tomato")
            WriteLine("2, Italian Bacon & Peperoni")
            WriteLine("3, Tuna & Mayo")
            WriteLine("4, Turkey & Ham")
            WriteLine("5, Chicken Teriyaki")
            WriteLine("6, Steak & Cheese")
            topping = ReadLine()
            If topping = 1 Then
                WriteLine("Cheese & Tomato")
                cost = cost + 0.95
                WriteLine("Current price is {0}", cost)
                topping1 = "Cheese & Tomato"
                inorouteat()
            ElseIf topping = 2 Then
                WriteLine("Italian Bacon & Peperoni")
                cost = cost + 1.1
                WriteLine("Current price is {0}", cost)
                topping1 = "Italian Bacon & Peperoni"
                inorouteat()
            ElseIf topping = 3 Then
                WriteLine("Tuna & Mayo")
                cost = cost + 0.95
                WriteLine("Current price is {0}", cost)
                topping1 = "Tuna & Mayo"
                inorouteat()
            ElseIf topping = 4 Then
                WriteLine("Turkey & Ham")
                cost = cost + 1.35
                WriteLine("Current price is {0}", cost)
                topping1 = "Turkey & Ham"
                inorouteat()
            ElseIf topping = 5 Then
                WriteLine("Chicken Teriyaki")
                cost = cost + 1.4
                WriteLine("Current price is {0}", cost)
                topping1 = "Chicken Teriyaki"
                inorouteat()
            ElseIf topping = 6 Then
                WriteLine("Steak & Cheese")
                cost = cost + 1.95
                WriteLine("Current price is {0}", cost)
                topping1 = "Steak & Cheese"
                inorouteat()
            Else
                WriteLine("Invalid Input, please try again")
                toppingselection()
            End If
        Catch ex As Exception
            WriteLine("Error")
            Sleep(2000)
            Clear()
            toppingselection()
        End Try
    End Sub
    Sub inorouteat()
        Clear()
        Try
            WriteLine("eat in or out")
            inourout1 = ReadLine()
            If inourout1 = 1 Then
                WriteLine("")
                cost = 105% * cost
            ElseIf inourout1 = 2 Then
                WriteLine("")
                cost = cost
            Else
                inorouteat()
            End If
            summary()
        Catch ex As Exception
            WriteLine("Error")
            Sleep(2000)
            Clear()
            inorouteat()
        End Try
    End Sub
    Sub summary()
        Clear()
        Math.Round(cost, 2)
        WriteLine("----------Order summary----------")
        WriteLine(cost)
        WriteLine(length1)
        WriteLine(topping1)
        WriteLine(bread)
        ReadKey()
    End Sub
End Module
