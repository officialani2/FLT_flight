Imports System.Data.OleDb

Public Class Form8
    Dim PROVIDER As String
    Dim DATAFILE As String
    Dim CONNSTRING As String
    Dim MYCONNECTION As OleDbConnection = New OleDbConnection
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        GroupBox2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PROVIDER = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        DATAFILE = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        CONNSTRING = PROVIDER & DATAFILE
        MYCONNECTION.ConnectionString = CONNSTRING
        MYCONNECTION.Open()
        Dim USER_ID As Boolean = False
        Dim cmd As New OleDbCommand("SELECT * FROM RESERVATION WHERE PNR_NO='" & TextBox1.Text & "'", MYCONNECTION)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            USER_ID = True
            Label5.Text = (dr(4).ToString)
            Label7.Text = (dr(1).ToString)
                Label11.Text = (dr(2).ToString)
                Label13.Text = (dr(3).ToString)
                Label15.Text = (dr(5).ToString)
                Label17.Text = (dr(6).ToString)
                Label9.Text = "CONFIRMED"
            End While
        If USER_ID = True Then
            GroupBox2.Visible = True

        ElseIf TextBox1.Text = "" Then
            MsgBox("PLEASE ENTER A PNR TO CONTINUE")
        Else
            MsgBox("WRONG PNR :/")
        End If
        MYCONNECTION.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox2.Visible = False
        TextBox1.Text = ""
        Form5.Show()
        Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox2.Visible = False
        TextBox1.Text = ""
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        GroupBox2.Visible = False
        TextBox1.Text = ""
        Form3.Show()
        Hide()
        Form5.Close()
        Form10.Close()
        Form9.Close()
        Form14.Close()
        Form15.Close()
        Me.Close()
    End Sub

    Private Sub BOOKAFLIGHTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKAFLIGHTToolStripMenuItem.Click
        GroupBox2.Visible = False
        TextBox1.Text = ""
        Form5.Show()
        Hide()
    End Sub

    Private Sub PRINTTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTTICKETToolStripMenuItem.Click
        GroupBox2.Visible = False
        TextBox1.Text = ""
        Form9.Show()
        Hide()
    End Sub

    Private Sub CANCELTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANCELTICKETToolStripMenuItem.Click
        GroupBox2.Visible = False
        TextBox1.Text = ""
        Form10.Show()
        Hide()
    End Sub
End Class