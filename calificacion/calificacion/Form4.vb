Public Class Form4
    Dim val As Integer
    Dim val0 As Integer
    Dim val1 As Integer
    Public cal As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        Label4.Text = "1"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton3.Enabled = False
        RadioButton2.Enabled = False
        Label4.Text = "0"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton1.Enabled = False
        RadioButton3.Enabled = False
        Label4.Text = "0"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        RadioButton4.Enabled = False
        RadioButton6.Enabled = False
        Label5.Text = "1"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        RadioButton5.Enabled = False
        RadioButton6.Enabled = False
        Label5.Text = "0"
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        RadioButton5.Enabled = False
        RadioButton4.Enabled = False
        Label5.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        val = Label5.Text
        val0 = Label6.Text
        val1 = Label4.Text
        cal = val + val0 + val1

        MsgBox("haz sumado &val1")
        Me.Hide()
        Form5.Show()
    End Sub

End Class