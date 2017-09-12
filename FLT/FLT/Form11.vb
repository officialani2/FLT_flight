Imports System.Data.OleDb

Public Class Form11
    Dim strin As String() = {"KOLKATA", "DELHI", "CHENNAI", "MUMBAI"}
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Label3.Text = Format(Now, "dd-MMM-yyyy")
        Label4.Text = Format(Now, "hh:mm")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        ComboBox1.Items.AddRange(strin)
        ComboBox2.Items.AddRange(strin)
        Label9.Visible = False
        Label10.Visible = False
        TextBox2.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        TextBox4.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        ComboBox2.Items.AddRange(strin)
        ComboBox2.Items.Remove(ComboBox1.Text)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(strin)
        ComboBox1.Items.Remove(ComboBox2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("PLEASE ENTER FLIGHT NUMBER :/")
        End If
        myConnection.Open()
        Dim cm As New OleDbCommand("select * from FLIGHT_dESC WHERE FLIGHT_NO='" & TextBox1.Text & "'OR TIME='" & TextBox3.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cm.ExecuteReader
        Dim US As Boolean = False
        While dr.Read
            US = True
        End While
        myConnection.Close()
        If US = True Then
            MsgBox("THE FLIGHT OR THE TIME OF FLIGHT ALREADY EXISTS PLEASE INSERT SOME OTHER FLIGHT OR CHANGE THE TIME")
        ElseIf TextBox3.Text = "" Then
            MsgBox("PLEASE ADD TIME OF FLIGHT :/")
        Else
            TextBox3.Text = TextBox3.Text + " HRS"
            Label9.Visible = True
            Label10.Visible = True
            TextBox2.Visible = True
            TextBox4.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("ARE YOU SURE TO ADD THIS FLIGHT?", MsgBoxStyle.OkCancel)
        myConnection.Open()
        Dim STR As String
        STR = "INSERT INTO FLIGHT_DESC([FLIGHT_NO],[TIME],[PRICE_ECONOMY],[PRICE_BUSSINESS],[ECONOMY_SEAT],[BUSSINESS_SEAT],[FROM],[TO])VALUES(?,?,?,?,?,?,?,?)"
        Dim CMD As OleDbCommand = New OleDbCommand(STR, myConnection)
        CMD.Parameters.Add(New OleDbParameter("FLIGHT_NO", CType(TextBox1.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("TIME", CType(TextBox3.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("PRICE_ECONOMY", CType(TextBox2.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("PRICE_BUSSINESS", CType(TextBox4.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("ECONOMY_SEAT", CType(TextBox5.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("BUSSINESS_SEAT", CType(TextBox6.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("FROM", CType(ComboBox1.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("TO", CType(ComboBox2.Text, String)))
        Refresh()
        Try
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (ComboBox3.Text = "") Then
            MsgBox("PLEASE ENTER FLIGHT NO ")
        End If

        If RadioButton1.Checked = True Then
            myConnection.Open()
            Dim STR As String
            STR = "UPDATE [FLIGHT_DESC] SET [PRICE_ECONOMY] ='" & TextBox8.Text & "'WHERE [FLIGHT_NO]='" & ComboBox3.Text & "'"
            Dim cmdI As OleDbCommand = New OleDbCommand(STR, myConnection)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("ECONOMY CLASS FARE CHANGED SUCESSFULLY :)")
        ElseIf RadioButton2.Checked = True Then
            myConnection.Open()
            Dim STR As String
            STR = "UPDATE [FLIGHT_DESC] SET [PRICE_BUSSINESS] ='" & TextBox8.Text & "'WHERE [FLIGHT_NO]='" & ComboBox3.Text & "'"
            Dim cmdI As OleDbCommand = New OleDbCommand(STR, myConnection)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("BUSSINESS CLASS FARE CHANGED SUCESSFULLY :)")
        Else
            MsgBox("PLEASE SELECT A VALID CLASS :/")
        End If
        ComboBox3.Text = ""
        TextBox8.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Hide()
        Form1.Show()

    End Sub

    Private Sub ADDFLIGHTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDFLIGHTToolStripMenuItem.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = True
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Label12.Visible = True
    End Sub

    Private Sub CHANGEFAREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHANGEFAREToolStripMenuItem.Click
        GroupBox4.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub ADDSEATSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDSEATSToolStripMenuItem.Click
        GroupBox4.Visible = True
        GroupBox3.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (ComboBox5.Text = "") Then
            MsgBox("PLEASE ENTER FLIGHT NO ")
        End If

        If RadioButton4.Checked = True Then
            myConnection.Open()
            Dim STR As String
            STR = "UPDATE [FLIGHT_DESC] SET [ECONOMY_SEAT] ='" & TextBox9.Text & "'WHERE [FLIGHT_NO]='" & ComboBox5.Text & "'"
            Dim cmdI As OleDbCommand = New OleDbCommand(STR, myConnection)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("NO OF SEATS CHANGED SUCESSFULLY :)")
        ElseIf RadioButton3.Checked = True Then
            myConnection.Open()
            Dim STR As String
            STR = "UPDATE [FLIGHT_DESC] SET [BUSSINESS_SEAT] ='" & TextBox9.Text & "'WHERE [FLIGHT_NO]='" & ComboBox5.Text & "'"
            Dim cmdI As OleDbCommand = New OleDbCommand(STR, myConnection)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("NO OF SEATS CHANGED SUCESSFULLY :)")
        Else
            MsgBox("PLEASE SELECT A VALID CLASS :/")
        End If
        ComboBox5.Text = ""
        TextBox9.Text = ""
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub REMOVEFLIGHTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVEFLIGHTToolStripMenuItem.Click
        Form12.Label13.Visible = False
        Form12.Button5.Visible = False
        Form12.Label14.Visible = False
        Form12.GroupBox1.Visible = True
        Form12.GroupBox2.Visible = False
        Form12.GroupBox3.Visible = False
        Form12.Show()
        Hide()
    End Sub

    Private Sub REMOVEUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVEUSERToolStripMenuItem.Click
        Form12.Label13.Visible = False
        Form12.Button5.Visible = False
        Form12.Label14.Visible = False
        Form12.GroupBox1.Visible = False
        Form12.GroupBox2.Visible = True
        Form12.GroupBox3.Visible = False
        Form12.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (ComboBox1.Text = "") Then
            MsgBox("ENTER SOURCE ")
        ElseIf (ComboBox2.Text = "") Then
            MsgBox("ENTER DESTINATION ")
        Else

            If (ComboBox1.Text = "KOLKATA" AndAlso ComboBox2.Text = "MUMBAI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("Select * from [FLIGHT_DESC] WHERE FROM='KOLKATA' AND TO='MUMBAI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "KOLMUM"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "KOLKATA" AndAlso ComboBox2.Text = "DELHI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='KOLKATA' AND TO='DELHI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "KOLDEL"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "KOLKATA" AndAlso ComboBox2.Text = "CHENNAI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='KOLKATA' AND TO='CHENNAI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "KOLCHE"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "DELHI" AndAlso ComboBox2.Text = "CHENNAI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='DELHI' AND TO='CHENNAI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "DELCHE"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "DELHI" AndAlso ComboBox2.Text = "KOLKATA") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='DELHI' AND TO='KOLKATA'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "DELKOL"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "DELHI" AndAlso ComboBox2.Text = "MUMBAI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='DELHI' AND TO='MUMBAI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "DELMUM"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "CHENNAI" AndAlso ComboBox2.Text = "DELHI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='CHENNAI' AND TO='DELHI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "CHEDEL"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "CHENNAI" AndAlso ComboBox2.Text = "KOLKATA") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='CHENNAI' AND TO='KOLKATA'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "CHEKOL"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "CHENNAI" AndAlso ComboBox2.Text = "MUMBAI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='CHENNAI' AND TO='MUMBAI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "CHEMUM"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "MUMBAI" AndAlso ComboBox2.Text = "CHENNAI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='MUMBAI' AND TO='CHENNAI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "MUMCHE"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "MUMBAI" AndAlso ComboBox2.Text = "DELHI") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='MUMBAI' AND TO='DELHI'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read

                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "MUMDEL"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            ElseIf (ComboBox1.Text = "MUMBAI" AndAlso ComboBox2.Text = "KOLKATA") Then
                myConnection.Open()
                Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='MUMBAI' AND TO='KOLKATA'", myConnection)
                Dim dr As OleDbDataReader = cm.ExecuteReader
                ComboBox3.Items.Clear()
                While dr.Read
                    ComboBox3.Items.Add(dr(0).ToString)
                    TextBox1.Text = "MUMKOL"
                    ComboBox5.Items.Add(dr(0).ToString)
                End While
                dr.Close()
                myConnection.Close()
            End If
        End If
    End Sub

    Private Sub BOOKINGDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGDETAILSToolStripMenuItem.Click
        Form12.GroupBox1.Visible = False
        Form12.GroupBox2.Visible = False
        Form12.GroupBox3.Visible = True
        Form12.Show()
        Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label24.Visible = True
    End Sub
End Class