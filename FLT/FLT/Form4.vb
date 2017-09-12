Imports System.Data.OleDb
Public Class form4
    Dim PROVIDER As String
    Dim DATAFILE As String
    Dim CONNSTRING As String
    Dim MYCONNECTION As OleDbConnection = New OleDbConnection
    Dim MYCONN As OleDbConnection = New OleDbConnection
    Dim KTR As String

    Private Sub form4_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        Label9.Visible = False
        Label10.Visible = False
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or MaskedTextBox1.Text = "" Or MaskedTextBox2.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If (RadioButton1.Checked = True) Then
                KTR = RadioButton1.Text
            ElseIf (RadioButton2.Checked = True) Then
                KTR = RadioButton2.Text
            Else
                MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            PROVIDER = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            DATAFILE = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
            CONNSTRING = PROVIDER & DATAFILE
            MYCONNECTION.ConnectionString = CONNSTRING
            MYCONN.ConnectionString = CONNSTRING
            MYCONN.Open()
            Dim cm As New OleDbCommand("Select * from [REGISTER] WHERE [USER_ID]='" & TextBox3.Text & "'", MYCONN)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            Dim BOL As Boolean = False
            While dr.Read
                BOL = True
            End While
            If BOL = True Then
                MsgBox("USER ID ALREADY IN USE TRY A DIFFERENT ONE")
                dr.Close()
                MYCONN.Close()
                Exit Sub
            End If
            MYCONN.Close()

            If (MaskedTextBox1.Text.Length = 12) Then
                Button2.Focus()
            Else
                MsgBox("MOBILE NUMBER NOT VERIFIED :/")
                Exit Sub
            End If
            If (MaskedTextBox2.Text.Length = 2) Then
                Button2.Focus()
            Else
                MsgBox("PLEASE FILL AGE PROPERLY  :/")
                Exit Sub
            End If
            MYCONNECTION.Open()
            Dim STR As String
            STR = "INSERT INTO register([USER_ID],[PASSWORD],[NAME],[AGE],[SEX],[CONTACT_NO]) VALUES(?,?,?,?,?,?)"
            Dim CMD As OleDbCommand = New OleDbCommand(STR, MYCONNECTION)
            CMD.Parameters.Add(New OleDbParameter("USER_ID", CType(TextBox3.Text, String)))
            CMD.Parameters.Add(New OleDbParameter("PASSWORD", CType(TextBox4.Text, String)))
            CMD.Parameters.Add(New OleDbParameter("NAME", CType(TextBox6.Text, String)))
            CMD.Parameters.Add(New OleDbParameter("AGE", CType(MaskedTextBox2.Text, String)))
            CMD.Parameters.Add(New OleDbParameter("SEX", CType(KTR, String)))
            CMD.Parameters.Add(New OleDbParameter("CONTACT_NO", CType(MaskedTextBox1.Text, String)))
            MsgBox("YOUR REQUEST IS ADDED :) LOGIN TO CONTINUE")
            Refresh()
            Try
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MYCONNECTION.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Hide()
            Form3.Show()
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            MaskedTextBox2.Text = ""
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            MaskedTextBox1.Text = ""
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        MaskedTextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        MaskedTextBox1.Text = ""
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
        Form1.Show()

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox4.Text = TextBox5.Text Then
            Label11.Visible = True
            Label11.Text = "Match"
            Label11.ForeColor = Color.Green
            Button2.Enabled = True

        Else
            Label11.Text = "Not match"
            Label11.ForeColor = Color.Red
            Button2.Enabled = False
        End If
    End Sub

    Private Sub textbox5_mousehover(sender As Object, e As EventArgs) Handles TextBox5.MouseHover
        TextBox5.PasswordChar = ""
    End Sub

    Private Sub textbox5_mouseLeave(sender As Object, e As EventArgs) Handles TextBox5.MouseLeave
        TextBox5.PasswordChar = "*"
    End Sub

    Private Sub textbox4_mousehover(sender As Object, e As EventArgs) Handles TextBox4.MouseHover
        TextBox4.PasswordChar = ""
    End Sub

    Private Sub textbox4_mouseLeave(sender As Object, e As EventArgs) Handles TextBox4.MouseLeave
        TextBox4.PasswordChar = "*"
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Label9.Visible = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Label10.Visible = True
        If TextBox4.Text = TextBox5.Text Then
            Label11.Text = "Match"
            Label11.ForeColor = Color.Green
            Button2.Enabled = True

        Else
            Label11.Text = "Not match"
            Label11.ForeColor = Color.Red
            Button2.Enabled = False
        End If
    End Sub
End Class