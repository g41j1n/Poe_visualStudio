Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        MsgBox("el resultado de tu suma es : " + TextBox3.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        MsgBox("el resultado de tu resta es : " + TextBox3.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        MsgBox("el resultado de tu multiplicacion es : " + TextBox3.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        MsgBox("el resultado de tu division es : " + TextBox3.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End

    End Sub
End Class
