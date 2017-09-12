Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MsgBox("PLEASE ENTER USER ID :/")
        ElseIf (TextBox2.Text = "") Then
            MsgBox("PLEASE ENTER PASSWORD :/")
        End If

        If (TextBox1.Text = "admin" AndAlso TextBox2.Text = "1234") Then
            Form11.Show()
            Hide()

        Else
            MsgBox("SORRY MATE!!!EITHER YOU'RE NOT AN ADMIN :(")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form1.Show()
    End Sub
End Class