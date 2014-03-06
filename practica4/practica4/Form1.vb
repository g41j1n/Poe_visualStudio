Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fact As Integer = 1
        Dim num As Integer

        If num = TextBox1.Text = 0 Or num = TextBox1.Text = 1 Then
            TextBox2.Text = 1

        Else
            For init As Integer = 1 To num
                fact = fact * init
            Next
            TextBox2.Text = Trim(fact)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class
