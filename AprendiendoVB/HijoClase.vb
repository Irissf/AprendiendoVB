Public Class HijoClase
    Inherits POO
    'inherits, es para indicar la herencia

    Public puertas As Integer

    Public Sub New(modelo As String, marca As String, puertas As Integer)
        'el super seria
        MyBase.New(marca, puertas) 'se lo mandamos al padre
        Me.puertas = puertas
    End Sub

End Class
