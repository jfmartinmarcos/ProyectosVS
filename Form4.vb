Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form1
        'Apertura de formulario en modo modal
        f.ShowDialog()
    End Sub
End Class