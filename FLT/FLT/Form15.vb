Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("PLEASE MAKE SURE YOU ENTER THE DETAILS FOR THE FIRST PERSON ")
        Label1.Text = Form5.ComboBox4.Text
        If (Label1.Text = "1") Then
            Label2.Visible = True
            TextBox1.Visible = True
        ElseIf (Label1.Text = "2") Then
            Label2.Visible = True
            TextBox1.Visible = True
            Label3.Visible = True
            TextBox2.Visible = True
        ElseIf (Label1.Text = "3") Then
            Label2.Visible = True
            TextBox1.Visible = True
            Label3.Visible = True
            TextBox2.Visible = True
            Label7.Visible = True
            TextBox3.Visible = True
        ElseIf (Label1.Text = "4") Then
            Label2.Visible = True
            TextBox1.Visible = True
            Label3.Visible = True
            TextBox2.Visible = True
            Label7.Visible = True
            TextBox3.Visible = True
            Label5.Visible = True
            TextBox4.Visible = True
        ElseIf (Label1.Text = "5") Then
            Label2.Visible = True
            TextBox1.Visible = True
            Label3.Visible = True
            TextBox2.Visible = True
            Label7.Visible = True
            TextBox3.Visible = True
            Label5.Visible = True
            TextBox4.Visible = True
            Label4.Visible = True
            TextBox5.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("ARE YOU SURE TO CONTINUE?")
        If (TextBox1.Text = "") Then
            MsgBox("PLEASE FILL IN PRIMARY NAME")
            Exit Sub
        End If
        Form14.Show()
        Hide()
    End Sub
End Class