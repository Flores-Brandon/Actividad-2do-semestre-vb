Public Class Colores
    Public MustInherit Class Colores
        Public MustOverride Sub SeleccionarColor()
    End Class

    Public Class Azul
        Inherits Colores
        Implements Icolores

        Public Overrides Sub SeleccionarColor()
            MessageBox.Show("Has seleccionado el color azul")
        End Sub

        Public Sub Eleir() Implements Icolores.Eleir
            MessageBox.Show("Que bello color!!")
        End Sub
    End Class

    Public Class Rojo
        Inherits Colores
        Implements Icolores

        Public Overrides Sub SeleccionarColor()
            MessageBox.Show("Has seleccionado el color Rojo")
        End Sub

        Public Sub Eleir() Implements Icolores.Eleir
            MessageBox.Show("Que bello color!!")
        End Sub
    End Class

    Public Interface Icolores
        Sub Eleir()
    End Interface
End Class


