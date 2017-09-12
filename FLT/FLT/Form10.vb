Imports System.Data.OleDb

Public Class Form10
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim MYCONN As OleDbConnection = New OleDbConnection
    Dim MYCONi As OleDbConnection = New OleDbConnection
    Dim MYS As OleDbConnection = New OleDbConnection
    Dim MYSK As OleDbConnection = New OleDbConnection
    Dim S As Boolean
    Dim ch As String
    Dim i As Integer
    Private Sub BOOKTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKTICKETToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        DateTimePicker1.Text = ""
        Hide()
        Form5.Show()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        MYCONN.ConnectionString = connString
        MYCONi.ConnectionString = connString
        MYS.ConnectionString = connString
        MYSK.ConnectionString = connString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MYS.Open()
        Dim FTR As String
        FTR = "SELECT * FROM RESERVATION WHERE PNR_NO='" & TextBox1.Text & "'"
        Dim CMDIB As OleDbCommand = New OleDbCommand(FTR, MYS)
        Dim DK As OleDbDataReader = CMDIB.ExecuteReader
        While DK.Read()
            Label6.Text = DK(6).ToString
        End While
        DK.Close()
        Try
            CMDIB.ExecuteNonQuery()
            CMDIB.Dispose()
            MYS.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If RadioButton1.Checked = True Then
            MYCONi.Open()
            Dim cmdIk As New OleDbCommand("SELECT * FROM SEAT_INFO WHERE FLIGHT_NO='" & TextBox2.Text & "'  AND DATE_TRAVEL='" & DateTimePicker1.Text & "' AND CLASS='" & RadioButton1.Text & "' ", MYCONi)
            Dim DD As OleDbDataReader = cmdIk.ExecuteReader
            S = False
            While DD.Read()
                S = True
                Label5.Text = DD(4).ToString
                Label9.Text = DD(7).ToString
            End While
            ch = Label9.Text
            Label10.Text = Label6.Text
            i = 0
            While Not Val(Label10.Text) = 0
                If ch.Chars(i) = "B" Then
                    ch = ch.Remove(i, 1).Insert(i, "E")
                    Label10.Text = Val(Label10.Text) - 1
                End If
                i = i + 1
            End While
            Label12.Text = ch
            If S = False Then
                MsgBox("TICKET DOES NOT EXISTS")
            End If
            DD.Close()
            Try
                cmdIk.ExecuteNonQuery()
                cmdIk.Dispose()
                MYCONi.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Label5.Text = Val(Label5.Text) + Val(Label6.Text)
        ElseIf RadioButton2.Checked = True Then
            MYCONi.Open()
            Dim KTR As String
            KTR = "SELECT* FROM [SEAT_INFO] WHERE FLIGHT_NO='" & TextBox2.Text & "' AND CLASS='" & RadioButton2.Text & "' AND DATE_TRAVEL='" & DateTimePicker1.Text & "' "
            Dim cmdIk As OleDbCommand = New OleDbCommand(KTR, MYCONi)
            Dim DD As OleDbDataReader = cmdIk.ExecuteReader
            S = False
            While DD.Read()
                S = True
                Label5.Text = DD(4).ToString
                Label9.Text = DD(7).ToString
            End While
            ch = Label9.Text
            Label10.Text = Label6.Text
            i = 0
            While Val(Label10.Text) <> 0
                If ch.Chars(i) = "B" Then
                    ch = ch.Remove(i, 1).Insert(i, "E")
                    Label10.Text = Val(Label10.Text) - 1
                End If
                i = i + 1
            End While

            Label12.Text = ch
            If S = False Then
                MsgBox("TICKET DOES NOT EXISTS")
            End If
            DD.Close()
            Try
                cmdIk.ExecuteNonQuery()
                cmdIk.Dispose()
                MYCONi.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Label5.Text = Val(Label5.Text) + Val(Label6.Text)
        End If
        If (TextBox1.Text = "") Then
            MsgBox("PLEASE ENTER PNR")
        ElseIf S = True Then
            myConnection.Open()
            Dim str As String
            str = "Delete from RESERVATION Where PNR_NO = '" & TextBox1.Text & "' AND FLIGHT_NO='" & TextBox2.Text & "'"
            Dim cmdk As OleDbCommand = New OleDbCommand(str, myConnection)
            GroupBox2.Visible = True
            Try
                cmdk.ExecuteNonQuery()
                cmdk.Dispose()
                myConnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If RadioButton1.Checked = True Then
            MYSK.Open()
            Dim KTR As String
            Dim ztr As String
            KTR = "update [SEAT_INFO] set [SEAT_LEFT] = '" & Label5.Text & "' Where [FLIGHT_NO]='" & TextBox2.Text & "' AND [DATE_TRAVEL]='" & DateTimePicker1.Text & "' AND [CLASS]='" & RadioButton1.Text & "' "
            ztr = "update [SEAT_INFO] set [SEAT_SELECT] = '" & Label12.Text & "' Where [FLIGHT_NO]='" & TextBox2.Text & "' AND [DATE_TRAVEL]='" & DateTimePicker1.Text & "' AND [CLASS]='" & RadioButton1.Text & "' "
            Dim cmdI As OleDbCommand = New OleDbCommand(KTR, MYSK)
            Dim cmdIz As OleDbCommand = New OleDbCommand(ztr, MYSK)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                cmdIz.ExecuteNonQuery()
                cmdIz.Dispose()
                MYSK.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf RadioButton2.Checked = True Then
            MYSK.Open()
            Dim KTR As String
            Dim ztr As String
            KTR = "update [SEAT_INFO] Set [SEAT_LEFT] = '" & Label5.Text & "' Where [FLIGHT_NO]='" & TextBox2.Text & "'AND [DATE_TRAVEL]='" & DateTimePicker1.Text & "' AND [CLASS]='" & RadioButton2.Text & "'"
            ztr = "update [SEAT_INFO] set [SEAT_SELECT] = '" & Label12.Text & "' Where [FLIGHT_NO]='" & TextBox2.Text & "' AND [DATE_TRAVEL]='" & DateTimePicker1.Text & "' AND [CLASS]='" & RadioButton2.Text & "' "
            Dim cmdI As OleDbCommand = New OleDbCommand(KTR, MYSK)
            Dim cmdIz As OleDbCommand = New OleDbCommand(ztr, MYSK)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                cmdIz.ExecuteNonQuery()
                cmdIz.Dispose()
                MYSK.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        DateTimePicker1.Text = ""
        Hide()
        Form1.Show()
        Form5.Close()
        Me.Close()
        Form9.Close()
        Form14.Close()
        Form15.Close()
        Form8.Close()
    End Sub

    Private Sub CANCELTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANCELTICKETToolStripMenuItem.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub PRINTTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTTICKETToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        DateTimePicker1.Text = ""
        Hide()
        Form9.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MYS.Open()
        Dim FTR As String
        FTR = "SELECT * FROM RESERVATION WHERE PNR_NO='" & TextBox1.Text & "'"
        Dim CMDIB As OleDbCommand = New OleDbCommand(FTR, MYS)
        Dim DK As OleDbDataReader = CMDIB.ExecuteReader
        Dim ASSS As Boolean = False
        While DK.Read()
            ASSS = True
            TextBox2.Text = DK(4).ToString
            DateTimePicker1.Text = DK(2).ToString
            Label7.Text = DK(5).ToString
        End While
        If ASSS = True Then
            If Label7.Text = "ECONOMY" Then
                RadioButton1.Checked = True
            ElseIf Label7.Text = "BUSSINESS" Then
                RadioButton2.Checked = True
            End If
        Else
            If ASSS = False Then
                MsgBox("CHECK YOUR PNR AND TRY AGAIN")
            End If
        End If
            DK.Close()
        Try
            CMDIB.ExecuteNonQuery()
            CMDIB.Dispose()
            MYS.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("PNR VERIFIED :) CHECK YOUR DETAILS AND PRESS CANCEL TICKET TO PROCEED ")
    End Sub

    Private Sub PNRSEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNRSEARCHToolStripMenuItem.Click
        Hide()
        Form8.Show()
    End Sub
End Class