Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim total As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        num1 = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        num2 = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        total = num1 + num2
        MsgBox("Total de la suma es: " & total)
    End Sub
End Class
