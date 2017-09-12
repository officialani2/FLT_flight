Imports System.Data.OleDb

Public Class Form9
    Dim PROVIDER As String
    Dim DATAFILE As String
    Dim CONNSTRING As String
    Dim MYCONNECTION As OleDbConnection = New OleDbConnection


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        WindowState = FormWindowState.Maximized
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
            Label1.Text = (dr(4).ToString)
            Label2.Text = (dr(2).ToString)
            Label4.Text = (dr(1).ToString)
            Label3.Text = (dr(7).ToString)
            Label5.Text = (dr(8).ToString)
            Label10.Text = (dr(3).ToString)
            Label12.Text = (dr(6).ToString)
            Label9.Text = dr(5).ToString
        End While
        Label6.Text = Label5.Text
        Label11.Text = Label4.Text
        If (Label12.Text = "1") Then
            Label4.Text = Label4.Text
        ElseIf (Label12.Text = "2") Then
            Label4.Text = Label4.Text + "+1"
        ElseIf (Label12.Text = "3") Then
            Label4.Text = Label4.Text + "+2"
        ElseIf (Label12.Text = "4") Then
            Label4.Text = Label4.Text + "+3"
        ElseIf (Label12.Text = "5") Then
            Label4.Text = Label4.Text + "+4"
        End If
        Label11.Text = Label4.Text
        If USER_ID = True Then
            GroupBox1.Visible = True
            If (Label9.Text = "ECONOMY") Then
                Label9.Text = "ECONOMY CLASS/ÉCONOMIE CLASSE"
                Label9.Visible = True
            Else
                Label9.Visible = False
            End If
        ElseIf TextBox1.Text = "" Then
                MsgBox("PLEASE ENTER A PNR TO CONTINUE")
            Else
                MsgBox("WRONG PNR :/")
        End If
        MYCONNECTION.Close()
        Button2.Visible = True
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Form1.Show()
        Hide()
        Form5.Close()
        Form10.Close()
        Me.Close()
        Form8.Close()
        Form14.Close()
        Form15.Close()
    End Sub

    Private Sub BOOKAFLIGHTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKAFLIGHTToolStripMenuItem.Click
        Form5.Show()
        Hide()
        TextBox1.Text = ""
        GroupBox1.Visible = False
    End Sub

    Private Sub CANCELTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANCELTICKETToolStripMenuItem.Click
        Form10.Show()
        Hide()
        TextBox1.Text = ""
        GroupBox1.Visible = False
    End Sub

    Private Sub PNRSEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNRSEARCHToolStripMenuItem.Click
        Form8.Show()
        Hide()
        TextBox1.Text = ""
        GroupBox1.Visible = False
    End Sub
End Class