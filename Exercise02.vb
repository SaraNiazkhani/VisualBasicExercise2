Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num1 As Double = CDbl(TextBox1.Text)
        Dim Num2 As Double = CDbl(TextBox2.Text)
        Dim Multiplied As Long = Num1 * Num2
        Outputlbl.Text = Multiplied.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Num1 As Double = CDbl(TextBox1.Text)
        Dim Num2 As Double = CDbl(TextBox2.Text)
        Dim Square As Long = Num1 ^ 2 + Num2 ^ 2
        Outputlbl.Text = Square.ToString()
    End Sub
End Class
