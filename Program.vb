Imports System.Console
Module Program
    Dim cost As Single
    Dim typeofbread As Integer
    Dim length As Integer
    Dim topping As Integer
    Dim topping1 As String
    Dim bread As String
    Dim length1 As String
    Sub Main()
        Clear()
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
    End Sub
    Sub breadselection()
        Clear()
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

    End Sub
    Sub toppingselection()
        Clear()
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
            summary()
        ElseIf topping = 2 Then
            WriteLine("Italian Bacon & Peperoni")
            cost = cost + 1.1
            WriteLine("Current price is {0}", cost)
            topping1 = "Italian Bacon & Peperoni"
            summary()
        ElseIf topping = 3 Then
            WriteLine("Tuna & Mayo")
            cost = cost + 0.95
            WriteLine("Current price is {0}", cost)
            topping1 = "Tuna & Mayo"
            summary()
        ElseIf topping = 4 Then
            WriteLine("Turkey & Ham")
            cost = cost + 1.35
            WriteLine("Current price is {0}", cost)
            topping1 = "Turkey & Ham"
            summary()
        ElseIf topping = 5 Then
            WriteLine("Chicken Teriyaki")
            cost = cost + 1.4
            WriteLine("Current price is {0}", cost)
            topping1 = "Chicken Teriyaki"
            summary()
        ElseIf topping = 6 Then
            WriteLine("Steak & Cheese")
            cost = cost + 1.95
            WriteLine("Current price is {0}", cost)
            topping1 = "Steak & Cheese"
            summary()
        Else
            WriteLine("Invalid Input, please try again")
            toppingselection()
        End If

    End Sub
    Sub summary()
        Clear()
        WriteLine("Order summary")
        WriteLine(cost)
        WriteLine(length1)
        WriteLine(topping1)
        WriteLine(bread)
        ReadKey()

    End Sub
End Module
