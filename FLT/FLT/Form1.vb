Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\2.gif")
        GroupBox1.Parent = PictureBox1
        GroupBox2.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        WindowState = FormWindowState.Maximized
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

    End Sub

    Private Sub ENTRYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRYToolStripMenuItem.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form2.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form3.Show()
    End Sub

End Class
