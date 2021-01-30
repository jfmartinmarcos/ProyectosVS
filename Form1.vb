''' <summary>
''' Realizado a partir de la información de https://stackoverflow.com/questions/40418861/c-sharp-how-to-show-preview-pdf-inside-in-winforms-application
''' </summary>
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim visorPDF As New Form2
        ''Apertura de formulario en modo NO modal
        visorPDF.Show()
        'Prueba commit en GitHub en repositorio ProyectosVS
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim visorWeb As New Form3
        ''Apertura de formulario en modo NO modal
        visorWeb.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

End Class
