Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        TextBox1.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fact As Integer = 1
        Dim num As Integer
        Dim count As Integer
        num = TextBox1.Text
        If num = 0 Or num = 1 Then
            Label2.Text = 1
        Else
            For init As Integer = 1 To num - 1
                count = count + 1
                fact = num * init
            Next
            Label2.Text = "el factorial es" & fact

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
