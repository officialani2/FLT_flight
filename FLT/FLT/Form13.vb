Imports System.Data.OleDb

Public Class Form13
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("ENTER A ID TO CONTINUE")
        Else
            GroupBox1.Visible = True
        End If
    End Sub
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("PLEASE ENTER NAME")
        End If
        If TextBox3.Text = "" Then
            MsgBox("PLEASE ENTER CONTACT NUMBER")
        End If
        If TextBox4.Text = "" Then
            MsgBox("PLEASE ENTER AGE")
        End If
        If RadioButton1.Checked = True Then
            myConnection.Open()
            Dim CM As New OleDbCommand("SELECT * FROM register WHERE USER_ID='" & TextBox1.Text & "' AND NAME='" & TextBox2.Text & "' AND AGE='" & TextBox4.Text & "' AND SEX='" & RadioButton1.Text & "' AND CONTACT_NO='" & TextBox3.Text & "'", myConnection)
            Dim dr As OleDbDataReader = CM.ExecuteReader
            Dim BO As Boolean = False
            While dr.Read
                BO = True
            End While
            If BO = True Then
                Label6.Visible = True
                TextBox5.Visible = True
                Button3.Visible = True
            Else
                MsgBox("YOUR GIVEN DETAILS DOES NOT MATCH TRY AGAIN")
                Label6.Visible = False
                TextBox5.Visible = False
                Button3.Visible = False
            End If
            dr.Close()
            myConnection.Close()
        ElseIf RadioButton2.Checked = True Then
            myConnection.Open()
            Dim CM As New OleDbCommand("SELECT * FROM register WHERE USER_ID='" & TextBox1.Text & "' AND NAME='" & TextBox2.Text & "' AND AGE='" & TextBox4.Text & "' AND SEX='" & RadioButton2.Text & "' AND CONTACT_NO='" & TextBox3.Text & "'", myConnection)
            Dim dr As OleDbDataReader = CM.ExecuteReader
            Dim BO As Boolean = False
            While dr.Read
                BO = True
            End While
            If BO = True Then
                Label6.Visible = True
                TextBox5.Visible = True
                Button3.Visible = True
            Else
                MsgBox("YOUR GIVEN DETAILS DOES NOT MATCH TRY AGAIN")
                Label6.Visible = False
                TextBox5.Visible = False
                Button3.Visible = False
            End If
            dr.Close()
            myConnection.Close()
        Else
            MsgBox("PLEASE SELECT YOUR GENDER AND CONTINUE")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myConnection.Open()
        Dim KTR As String
        KTR = "UPDATE [register] SET [PASSWORD]='" & TextBox5.Text & "' WHERE [USER_ID]='" & TextBox1.Text & "'"
        Dim cmdI As OleDbCommand = New OleDbCommand(KTR, myConnection)
        Try
            cmdI.ExecuteNonQuery()
            cmdI.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("PASSWORD RESET DONE LOGIN TO CONTINUE")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        Form3.Show()
        Me.Close()
    End Sub
End Class