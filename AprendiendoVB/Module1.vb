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
        Condicionales()

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
    End Sub

End Module
