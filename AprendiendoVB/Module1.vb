Module Module1

    'Módulo de nuestro proyecto

    'Variables globales
    Dim numeroGolbal As Integer = 8
    Dim num2 As Integer = 4

    Sub Main()

        'Variables y constantes, vb no es case sensitive
        Dim variable As Integer = 12
        Dim CONSTANTE As Integer = 1

        Console.WriteLine("Imprimir mensaje es como en c#")
        Console.WriteLine("El numero:" & variable)

        'Llamamos a la funión
        'UnMetodo()
        'Operadores()
        'EntradaDatos()
        'Condicionales()
        'Bucles()
        'Arrays()
        Matrices()

        'Pongo readline para que no se me cierre la consola, espera a que pulsemos una tecla
        Console.ReadKey(True)

    End Sub

    'Una función
    Sub UnMetodo()
        Console.WriteLine("num globaL:" & numeroGolbal)
    End Sub

    Sub Operadores()
        '+,-,*,/ los de siempre, para el resto es MOD += incremento -= decremento
        Console.WriteLine("resultado :" & (numeroGolbal + num2))

        '>,<,>=,<= como siempre, <> distinto de, = asignacion e igual que

        'AND, OR, NOT => y, o , negación respectivamente
    End Sub

    'meter datos por consola
    Sub EntradaDatos()
        Dim nombre As String = ""
        Console.WriteLine("Introduce tu nombre:")
        nombre = Console.ReadLine()

        Console.WriteLine("Hola:" & nombre)
    End Sub

    Sub Condicionales()
        'Similar a otros lenguajes, aunque con más texto en vez de llaves
        If numeroGolbal < num2 Then
            Console.WriteLine("El número global es más pequeño que el num2")
        ElseIf num2 < numeroGolbal Then
            Console.WriteLine("El num2 es más pequeño que el número global")
        Else
            Console.WriteLine("Las dos variables son iguales")
        End If

        'Select case => viene a ser el switch
        Select Case num2
            Case 1
                'instrucciones
            Case 2
                'instrucciones
            Case 3
                'instrucciones
            Case Else
                'Como el Default
        End Select

    End Sub

    Sub Bucles()
        'for
        For index = 1 To 10
            Console.WriteLine(index)
        Next
        Console.WriteLine("==============================")
        For index = 0 To 10 Step 2
            'Con Step indicamos el rango de cuanto aumenta, en este caso suma 2 a index
            'De esta manera, por ejemplo, mostraríamos los números pares
            Console.WriteLine(index)
        Next

        Console.WriteLine("==============================")

        'while
        While num2 < 10
            'si no se cumple la condición ya ni entra, lo de siempre
            Console.WriteLine(num2)
            num2 += 1
        End While

        'do-Loop
        Do
            'ejecuta las instrucciones al menos una vez
            Console.WriteLine("entro una vez")
        Loop While (num2 > 10) 'en vez de While podemos usar Until => se va a repetir hasta que la condición sea verdadera
        'en este caso, si ponemos Loop Until (num2>10) nos meterá un bucle infinito, ya que esa condición no será verdadera
    End Sub

    Sub Arrays()
        Dim nombres(6) As String
        'meter datos 
        'nombres(0) = "Iris"

        Dim nombresDos = New String() {"Iris", "Carlos", "Marta", "Raúl", "Hugo", "Maria"} 'meter datos en la declaración

        'mostrar datos
        For Each nombre As String In nombresDos
            Console.WriteLine(nombre)
        Next
    End Sub

    Sub Matrices()
        'a diferencia de los arrays tienen más de una dimensión
        Dim numeros(2, 3) As Integer
        'numeros(1,1) = 3 meter datos 

        'meter datos en la declaración
        Dim matrix = New Integer(3, 2) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}

        'mostrar, con un for doble anidados o con un foreach
        For Each numero As Integer In matrix
            Console.WriteLine(numero)
        Next
    End Sub

End Module
