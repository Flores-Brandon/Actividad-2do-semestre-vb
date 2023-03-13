Imports Actividad_2do_semestre_vb.Colores
Public Class Form1
    Private azul As Azul
    Private rojo As Rojo


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        azul = New Azul()
        rojo = New Rojo()
    End Sub

    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        lblResultado.Text = ""
        rojo.SeleccionarColor()
        lblResultado.Text = "El color Rojo es magnifico, queda bien con todo" & vbCrLf

        Dim Colores As Icolores = rojo
        Colores.Eleir()
        lblResultado.Text += "para que usaras el color Rojo?"
    End Sub

    Private Sub btnAzul_Click(sender As Object, e As EventArgs) Handles btnAzul.Click

        lblResultado.Text = ""
        azul.SeleccionarColor()
        lblResultado.Text = "El color azul es magnifico, queda bien con todo" & vbCrLf

        Dim colores As Icolores = azul
        colores.Eleir()
        lblResultado.Text += "para que usaras el color azul?"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblResultado_Click(sender As Object, e As EventArgs) Handles lblResultado.Click

    End Sub
End Class
