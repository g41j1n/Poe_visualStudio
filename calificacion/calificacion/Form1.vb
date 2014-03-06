Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
        Label2.Text = "bienvenido"
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label3.Text = ProgressBar1.Value & (" %")

        If ProgressBar1.Value = 20 Then
            Label2.Text = "loading..."

        End If

        If ProgressBar1.Value = 40 Then
            Label2.Text = "loading textures"

        End If
        If ProgressBar1.Value = 60 Then
            Label2.Text = "loading little rabbits on the forest"

        End If
        If ProgressBar1.Value = 80 Then
            Label2.Text = "letting the little monsters Came to play"

        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MsgBox("successfull loaded")
            Label1.Text = "prepare to run"
            Button1.Enabled = True
            Me.Hide()
            Form2.Show()
        End If
    End Sub

End Class

