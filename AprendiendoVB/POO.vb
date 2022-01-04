Public Class POO

    'atributos
    Public marca As String
    Public modelo As String
    Public color As String

    'constructor
    Public Sub New(modelo As String, marca As String)
        Me.modelo = modelo
        Me.marca = marca
    End Sub

    'funciones
    Public Sub cambiarColor(color As String)
        Me.color = color 'Me es el this
    End Sub

    Public Function TeLoPaso() As String
        Return "El color del " & Me.marca & " " & Me.modelo & " es: " & color
    End Function

End Class
