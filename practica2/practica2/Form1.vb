Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val1 = TextBox1.Text
        Dim val2 = TextBox2.Text
        Dim res As Integer
        Dim opr As String

        opr = ComboBox1.SelectedItem.ToString()

        If opr = "+" Then
            res = Convert.ToInt32(val1) + Convert.ToInt32(val2)
            MessageBox.Show(res)
            TextBox3.Text = res

        ElseIf opr = "-" Then
            res = Convert.ToInt32(val1) - Convert.ToInt32(val2)
            MessageBox.Show(res)
            TextBox3.Text = res

        ElseIf opr = "*" Then
            res = Convert.ToInt32(val1) * Convert.ToInt32(val2)
            MessageBox.Show(res)
            TextBox3.Text = res

        ElseIf opr = "/" Then
            res = Convert.ToInt32(val1) / Convert.ToInt32(val2)
            MessageBox.Show(res)
            TextBox3.Text = res

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox2.Text = String.Empty
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3_Click= end
    End Sub
End Class
