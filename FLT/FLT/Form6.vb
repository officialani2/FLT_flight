Public Class Form6
    Dim K As String

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        GroupBox3.Visible = False
        Label11.Visible = False

        K = 0
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        GroupBox3.Visible = True
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            Label11.Text = Form5.Label9.Text
            Label11.Visible = True
            Button1.Enabled = False
            Label12.Text = " ₹"
            Label12.Visible = True
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            Label11.Text = Form5.Label9.Text
            Label11.Visible = True
            Button1.Enabled = False
            Label12.Text = " ₹"
            Label12.Visible = True
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            Label11.Text = Form5.Label9.Text
            Label11.Visible = True
            Button1.Enabled = False
            Label12.Text = " ₹"
            Label12.Visible = True
        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Hide()
        Form5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("THANKYOU FOR YOUR PAYMENT WE HAVE UPDATED YOUR BOOKING YOU CAN NOW PRINT YOUR TICKET :) ")
        Hide()
        Form9.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Label11.Text = Form5.Label9.Text
        Label11.Visible = True

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim KTR As Char

        K = MaskedTextBox1.Text
        KTR = K.Substring(0, 1)

        If Val(KTR) = 4 And MaskedTextBox1.Text.Length = 19 Then
            CheckBox1.Visible = True
            CheckBox1.Checked = True
            CheckBox1.Text = " VISA CARD VERIFIED"
            Button1.Enabled = True
        ElseIf VAL(KTR) = 5 And MaskedTextBox1.Text.Length = 19 Then
            CheckBox1.Checked = True
            CheckBox1.Visible = True
            CheckBox1.Text = " MASTER CARD VERIFIED"
            Button1.Enabled = True
        ElseIf VAL(KTR) = 6 And MaskedTextBox1.Text.Length = 19 Then
            CheckBox1.Checked = True
            CheckBox1.Visible = True
            CheckBox1.Text = " RUPAY CARD VERIFIED"
            Button1.Enabled = True
        Else
            CheckBox1.Visible = True
            CheckBox1.Checked = False
            CheckBox1.Text = " CARD NOT VERIFIED"
        End If
    End Sub
End Class