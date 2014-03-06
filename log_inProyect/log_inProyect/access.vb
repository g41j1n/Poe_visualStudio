Public Class access

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim usr1 As String = "juan"
        Dim pass1 As Integer = 123
        Dim usr2 As String = "hugo"
        Dim pass2 As Integer = 123
        Dim usr3 As String = "paco"
        Dim pass3 As Integer = 123
        Dim i As Integer

        If usr1.Equals(TextBox1.Text) And pass1 = Val(TextBox2.Text) Then

            MsgBox("Acceso Concedido")
            Me.Hide()
            user.Show()
            user.Label2.text = usr1

        ElseIf usr2.Equals(TextBox1.Text) And pass2 = Val(TextBox2.Text) Then

            MsgBox("Acceso Concedido")
            Me.Hide()
            user.Show()
            user.Label2.Text = usr2

        ElseIf usr3.Equals(TextBox1.Text) And pass3 = Val(TextBox2.Text) Then

            MsgBox("Acceso Concedido")
            Me.Hide()
            user.Show()
            user.Label2.Text = usr3
        Else
            For i = 0 To 5
                i = 1 + i
                If i < 4 Then
                    Me.Hide()
                    deny.Show()
                    deny.Label1.Text = i
                End If
            Next

            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBox1.Clear()
        TextBox2.Clear()


    End Sub
End Class