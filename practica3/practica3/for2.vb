Public Class for2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer
        For count = 1 To 5
            CheckedListBox1.Items.Add(count)
        Next
    End Sub
End Class