Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        Dim counter As Integer = 0
        Do While sum < 10
            sum = sum + CInt(TextBox1.Text)
            counter = counter + 1

        Loop
        MsgBox("the loop has run" & CStr(counter) & "times")
    End Sub
End Class