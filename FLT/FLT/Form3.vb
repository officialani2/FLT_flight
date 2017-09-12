Imports System.Data.OleDb
Public Class Form3
    Dim PROVIDER As String
    Dim DATAFILE As String
    Dim CONNSTRING As String
    Dim MYCONNECTION As OleDbConnection = New OleDbConnection
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        WindowState = FormWindowState.Maximized
        Dim SerialPort As New System.IO.Ports.SerialPort()
        Dim CR As String
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        form4.Show()
        Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PROVIDER = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        DATAFILE = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        CONNSTRING = PROVIDER & DATAFILE
        MYCONNECTION.ConnectionString = CONNSTRING
        MYCONNECTION.Open()


        Dim cmd As New OleDbCommand("SELECT * FROM REGISTER WHERE USER_ID='" & Convert.ToString(TextBox1.Text) & "' AND PASSWORD='" & Convert.ToString(TextBox2.Text) & "'", MYCONNECTION)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim USER_ID As Boolean = False
        Dim NAME As String = ""
        Dim LASTNAME As String = ""

        While dr.Read
            USER_ID = True
            NAME = dr("NAME").ToString


        End While
        Label4.Visible = True
        ProgressBar1.Visible = True
        Label4.Text = ""
        If USER_ID = True Then
            Form5.Label1.Text = "  " & NAME & "        "
            Timer2.Start()
        Else
            Timer1.Start()

        End If
        MYCONNECTION.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Form1.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If (TextBox1.Text = "") Then
            MsgBox("PLEASE ENTER YOUR ID TO CONTINUE")
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            Form13.Show()
            Hide()

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Increment(10)
        If ProgressBar1.Value > 10 And ProgressBar1.Value < 30 Then
            Label4.Text = "CONNECTING TO SERVER.."
        ElseIf ProgressBar1.Value > 30 And ProgressBar1.Value < 60 Then
            Label4.Text = "USER FOUND"
        ElseIf ProgressBar1.Value > 60 And ProgressBar1.Value < 80 Then
            Label4.Text = "VERIFYING PASSWORD "
        ElseIf ProgressBar1.Value > 80 And ProgressBar1.Value < 90 Then
            Label4.Text = "AUTHENTICATION SUCCESSFUL"
        ElseIf ProgressBar1.Value = 100 Then
            Label4.Text = "AUTHENTICATION SUCCESSFUL"
            Form5.Show()
            Hide()

            Timer2.Enabled = False
            ProgressBar1.Value = 0
            ProgressBar1.Value = False
            ProgressBar1.Visible = False
            Label4.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Enabled = True
        ProgressBar1.Increment(10)
        If ProgressBar1.Value > 10 And ProgressBar1.Value < 30 Then
            Label4.Text = "CONNECTING TO SERVER.."
        ElseIf ProgressBar1.Value > 30 And ProgressBar1.Value < 60 Then
            Label4.Text = "CONNECTING .."
        ElseIf ProgressBar1.Value > 60 And ProgressBar1.Value < 90 Then
            Label4.Text = "CHECKING USER"
        ElseIf ProgressBar1.Value = 100 Then
            Label4.Text = "AUTHENTICATION FAILED"
            ProgressBar1.Value = 0
            ProgressBar1.Value = False
            ProgressBar1.Visible = False
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub textbox2_mousehover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub textbox2_mouseLeave(sender As Object, e As EventArgs) Handles TextBox2.MouseLeave
        TextBox2.PasswordChar = "*"
    End Sub


End Class