Public Class POO

    'atributos
    Public marca As String
    Public modelo As String
    Public color As String

    'Encapsulación set y get
    Private referencia As String
    Public Sub setReferencia(referencia As String)
        Me.referencia = referencia
    End Sub
    Public Function getReferencia() As String
        Return Me.referencia
    End Function

    'constructor
    Public Sub New(modelo As String, marca As String)
        Me.modelo = modelo
        Me.marca = marca
    End Sub

    'Sobrecarga del constructo
    Public Sub New()
        Console.WriteLine("Constructor vacio")
    End Sub

    'funciones
    Public Sub cambiarColor(color As String)
        Me.color = color 'Me es el this
    End Sub

    Public Function TeLoPaso() As String
        Return "El color del " & Me.marca & " " & Me.modelo & " es: " & color
    End Function

    'sobrecargas
    Public Function TeLoPaso(nombre As String) As String
        Return "Hola " & nombre & " el color del " & Me.marca & " " & Me.modelo & " es: " & color
    End Function

End Class
