Module Module1

    Sub Main()
        Console.WriteLine("What do you want to compute?")
        Console.WriteLine("a.) Triangle")
        Console.WriteLine("b.) Square")
        Console.WriteLine("c.) Rectangle")
        Console.Write("Enter the letter: ")
        Dim input As String = Console.ReadLine()
        If (input = "a" Or input = "A") Then
            Console.Write("What is the length of the base?: ")
            Dim inputBase As String = Console.ReadLine()
            Dim base As Decimal
            If Decimal.TryParse(inputBase, base) Then
                Console.Write("What is the height?: ")
                Dim inputHeight As String = Console.ReadLine()
                Dim height As Decimal
                If Decimal.TryParse(inputHeight, height) Then
                    Dim areaTriangle As String = (base * height) * 1 / 2
                    Console.WriteLine("The area of the triangle is " + areaTriangle)
                    Console.WriteLine()
                    Main()
                Else
                    Console.WriteLine("Invalid Input")
                    Console.WriteLine()
                    Main()
                End If
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
                Main()
            End If
        ElseIf (input = "b" Or input = "B") Then
            Console.Write("What is the length of the sides?: ")
            Dim inputSide As String = Console.ReadLine()
            Dim side As Decimal
            If Decimal.TryParse(inputSide, side) Then
                Dim areaSquare As String = side * side
                Console.WriteLine("The area of the square is " + areaSquare)
                Console.WriteLine()
                Main()
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
                Main()
            End If
        ElseIf (input = "c" Or input = "C") Then
            Console.Write("What is the length: ")
            Dim inputlength As String = Console.ReadLine()
            Dim length As Decimal
            If Decimal.TryParse(inputlength, length) Then
                Console.Write("What is the width?: ")
                Dim inputWidth As String = Console.ReadLine()
                Dim width As Decimal
                If Decimal.TryParse(inputWidth, width) Then
                    Dim areaRectangle As String = length * width
                    Console.WriteLine("The area of the rectangle is " + areaRectangle)
                    Console.WriteLine()
                    Main()
                Else
                    Console.WriteLine("Invalid Input")
                    Console.WriteLine()
                    Main()
                End If
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
                Main()
            End If
        Else
            Console.WriteLine("Invalid Input")
            Console.WriteLine()
            Main()
        End If
        Console.ReadLine()
    End Sub

End Module
