Imports System.Data.OleDb

Public Class Form5
    Dim strin As String() = {"KOLKATA", "DELHI", "CHENNAI", "MUMBAI"}
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim KST As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public MYConn As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = DateTimePicker1.Value
        WindowState = FormWindowState.Maximized
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        Button1.Visible = False
        ProgressBar1.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        MYConn.ConnectionString = connString
        ComboBox1.Items.AddRange(strin)
        ComboBox2.Items.AddRange(strin)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form15.TextBox1.Text = "" Then
            MsgBox("PLEASE SELECT THE TRAVELLER DETAILS USING THE BUTTON GIVEN")
            Button6.Focus()
            Exit Sub
        End If
        Dim xCharArray() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray
        Dim xNoArray() As Char = "0123456789".ToCharArray
        Dim xGenerator As System.Random = New System.Random()
        Dim xStr As String = String.Empty
        If RadioButton1.Checked = True Then
            KST = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            KST = RadioButton2.Text
        End If
        While xStr.Length < 10

            If xGenerator.Next(0, 2) = 0 Then
                xStr &= xCharArray(xGenerator.Next(0, xCharArray.Length))
            Else
                xStr &= xNoArray(xGenerator.Next(0, xNoArray.Length))
            End If

        End While
        myConnection.Open()
        Dim STR As String
        STR = "INSERT INTO RESERVATION([PNR_NO],[PERSON_NAME],[DATE],[TIME],[FLIGHT_NO],[CLASS],[NO_OF_TICKET],[FROM],[TO],[PRICE])VALUES(?,?,?,?,?,?,?,?,?,?)"
        Dim CMD As OleDbCommand = New OleDbCommand(STR, myConnection)
        CMD.Parameters.Add(New OleDbParameter("PNR_NO", CType(xStr, String)))
        CMD.Parameters.Add(New OleDbParameter("PERSON_NAME", CType(Form15.TextBox1.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("DATE", CType(DateTimePicker1.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("TIME", CType(Label11.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("FLIGHT_NO", CType(ComboBox3.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("CLASS", CType(KST, String)))
        CMD.Parameters.Add(New OleDbParameter("NO_OF_TICKET", CType(ComboBox4.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("FROM", CType(ComboBox1.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("TO", CType(ComboBox2.Text, String)))
        CMD.Parameters.Add(New OleDbParameter("TO", CType(Label9.Text, String)))
        MsgBox("CLICK OK TO GET YOUR PNR!NOTE IT FOR FURTHER USE")
        MsgBox(xStr)
        Refresh()
        Try
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If RadioButton1.Checked = True Then
            MYConn.Open()
            Dim KTR As String
            KTR = "update [SEAT_INFO] set [SEAT_LEFT] = '" & Label18.Text & "' Where [FLIGHT_NO]='" & ComboBox3.Text & "' AND [DATE_TRAVEL]='" & DateTimePicker1.Text & "' AND [CLASS]='" & RadioButton1.Text & "' "
            Dim cmdI As OleDbCommand = New OleDbCommand(KTR, MYConn)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                MYConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf RadioButton2.Checked = True Then
            MYConn.Open()
            Dim KTR As String
            KTR = "update [SEAT_INFO] set [SEAT_LEFT] = '" & Label19.Text & "' Where [FLIGHT_NO]='" & ComboBox3.Text & "'AND [DATE_TRAVEL]='" & DateTimePicker1.Text & "' AND [CLASS]='" & RadioButton2.Text & "'"
            Dim cmdI As OleDbCommand = New OleDbCommand(KTR, MYConn)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                MYConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Label21.Text = "STEP:5 OF 5(BOOKED)"
            ProgressBar1.Value = 100
        End If
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        DateTimePicker1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = False
        Label20.Visible = False
        ProgressBar1.Value = 0
        Label21.Text = "STEP:0 OF 5(JUST STARTED)"
        ProgressBar1.Visible = False
        Label21.Visible = False
        Form6.Show()
        Hide()
        Form15.TextBox1.Text = ""
        Form15.TextBox2.Text = ""
        Form15.TextBox3.Text = ""
        Form15.TextBox4.Text = ""
        Form15.TextBox5.Text = ""
        Form14.Close()
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (ComboBox1.Text = "KOLKATA" AndAlso ComboBox2.Text = "MUMBAI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("Select * from [FLIGHT_DESC] WHERE FROM='KOLKATA' AND TO='MUMBAI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "KOLKATA" AndAlso ComboBox2.Text = "DELHI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='KOLKATA' AND TO='DELHI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "KOLKATA" AndAlso ComboBox2.Text = "CHENNAI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='KOLKATA' AND TO='CHENNAI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "DELHI" AndAlso ComboBox2.Text = "CHENNAI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='DELHI' AND TO='CHENNAI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "DELHI" AndAlso ComboBox2.Text = "KOLKATA") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='DELHI' AND TO='KOLKATA'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "DELHI" AndAlso ComboBox2.Text = "MUMBAI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='DELHI' AND TO='MUMBAI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "CHENNAI" AndAlso ComboBox2.Text = "DELHI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='CHENNAI' AND TO='DELHI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "CHENNAI" AndAlso ComboBox2.Text = "KOLKATA") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='CHENNAI' AND TO='KOLKATA'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "CHENNAI" AndAlso ComboBox2.Text = "MUMBAI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='CHENNAI' AND TO='MUMBAI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "MUMBAI" AndAlso ComboBox2.Text = "CHENNAI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='MUMBAI' AND TO='CHENNAI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "MUMBAI" AndAlso ComboBox2.Text = "DELHI") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='MUMBAI' AND TO='DELHI'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        ElseIf (ComboBox1.Text = "MUMBAI" AndAlso ComboBox2.Text = "KOLKATA") Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from [FLIGHT_DESC] WHERE FROM='MUMBAI' AND TO='KOLKATA'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            ComboBox3.Items.Clear()
            While dr.Read
                ComboBox3.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            myConnection.Close()
            GroupBox2.Visible = True
            Label21.Text = "STEP:1 OF 5(30% COMPLETED)"
            ProgressBar1.Value = 30
        Else
            MsgBox("PLEASE ENTER VALID DETAILS")
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        GroupBox3.Visible = True
        Button1.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM FLIGHT_DESC WHERE(FLIGHT_NO ='" & ComboBox3.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            Label11.Text = dr("TIME").ToString
            Label14.Text = dr("PRICE_ECONOMY").ToString
            Label15.Text = dr("PRICE_BUSSINESS").ToString
        End While
        myConnection.Close()
        Label21.Text = "STEP:2 OF 5(40% COMPLETED)"
        ProgressBar1.Value = 40
        Label22.Text = "  ₹"
        Label23.Text = "  ₹"
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then

            Label14.Visible = True
            Label22.Visible = True
            Label15.Visible = False
            Label23.Visible = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            Label15.Visible = True
            Label14.Visible = False
            Label23.Visible = True
            Label22.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim K As Integer
        K = 500
        If (RadioButton1.Checked = True) Then
            myConnection.Open()
            Dim cm As New OleDbCommand("select * from SEAT_INFO WHERE FLIGHT_NO='" & ComboBox3.Text & "'AND DATE_TRAVEL='" & DateTimePicker1.Text & "' AND CLASS='" & RadioButton1.Text & "'", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            While dr.Read
                Label18.Text = dr(4)
            End While
            myConnection.Close()
            If (Val(Label18.Text) = 0) Then
                Label17.Text = "NOT AVAILABLE"
                Label17.Visible = True
                Label17.ForeColor = Color.Red
            Else
                Label18.Text = (Val(Label18.Text) - Val(ComboBox4.Text))
                Label9.Text = (Val(Label14.Text) * Val(ComboBox4.Text))
                If (DateTimePicker1.Text = "23 April 2017" Or DateTimePicker1.Text = "24 April 2017") Then
                    Label9.Text = Val(Label9.Text) - 500
                End If
                If ComboBox4.Text = "" Then
                    MsgBox("SELECT NO OF SEATS")
                Else
                    Button1.Visible = True
                    Label9.Visible = True
                    Label8.Visible = True
                    Label17.Visible = True
                    Label17.Text = "AVAILABLE"
                    Label17.ForeColor = Color.Green
                    Button6.Visible = True
                    Label24.Text = "  ₹"
                    Label24.Visible = True
                End If
            End If
        ElseIf (RadioButton2.Checked = True) Then
            myConnection.Open()
            Dim cm As New OleDbCommand("Select * from SEAT_INFO WHERE FLIGHT_NO='" & ComboBox3.Text & "'AND DATE_TRAVEL='" & DateTimePicker1.Text & "' AND CLASS='" & RadioButton2.Text & "' ", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            While dr.Read
                Label19.Text = dr(4)

            End While
            myConnection.Close()
            If (Val(Label19.Text) = 0) Then
                Label17.Text = "NOT AVAILABLE"
                Label17.Visible = True
                Label17.ForeColor = Color.Red
            Else
                Label19.Text = (Val(Label19.Text) - Val(ComboBox4.Text))
                Label9.Text = (Val(Label15.Text) * Val(ComboBox4.Text))
                If (DateTimePicker1.Text = "23 April 2017" Or DateTimePicker1.Text = "24 April 2017") Then
                    Label9.Text = Val(Label9.Text) - 500
                End If
                If ComboBox4.Text = "" Then
                    MsgBox("SELECT NO OF SEATS")
                Else
                    Label17.Visible = True
                    Button1.Visible = True
                    Label9.Visible = True
                    Label8.Visible = True
                    Label17.Text = "AVAILABLE"
                    Label17.ForeColor = Color.Green
                    Button6.Visible = True
                    Label24.Text = "  ₹"
                    Label24.Visible = True
                End If
            End If
        End If
        If (Label17.Text = "NOT AVAILABLE ") Then
            MsgBox("THIS FLIGHT IS BOOKED OUT TRY OUT A DIFFERENT ONE")
        End If
        ProgressBar1.Value = 80
        Label21.Text = "STEP:4 OF 5(80% COMPLETED)"
    End Sub


    Private Sub BOOKINGPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGPAGEToolStripMenuItem.Click
        Label21.Text = "STEP:0 OF 5(JUST STARTED)"
        Label21.Visible = True
        Label20.Visible = True
        GroupBox1.Visible = True
        ProgressBar1.Visible = True
    End Sub

    Private Sub CHECKPNRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHECKPNRToolStripMenuItem.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        DateTimePicker1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = False
        Label20.Visible = False
        ProgressBar1.Value = 0
        Label21.Text = "STEP:0 OF 5(JUST STARTED)"
        ProgressBar1.Visible = False
        Label21.Visible = False
        Form8.Show()
        Hide()

    End Sub

    Private Sub PRINTTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTTICKETToolStripMenuItem.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        DateTimePicker1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = False
        Label20.Visible = False
        ProgressBar1.Value = 0
        Label21.Text = "STEP:0 OF 5(JUST STARTED)"
        ProgressBar1.Visible = False
        Label21.Visible = False
        Form9.Show()
        Hide()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        DateTimePicker1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = False
        Label20.Visible = False
        ProgressBar1.Value = 0
        Label21.Text = "STEP:0 OF 5(JUST STARTED)"
        ProgressBar1.Visible = False
        Label21.Visible = False
        Form3.Show()
        Hide()
        Me.Close()
        Form10.Close()
        Form9.Close()
        Form8.Close()
        Form14.Close()
        Form15.Close()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label21.Text = "STEP:3 OF 5"
        ProgressBar1.Value = 65
        Label13.Visible = True
        ComboBox4.Visible = True
        Button4.Visible = True
        If RadioButton1.Checked = True Then
            myConnection.Open()
            Dim KST As String
            Dim cm As New OleDbCommand("select * from [SEAT_INFO] WHERE FLIGHT_NO='" & ComboBox3.Text & "' AND DATE_TRAVEL='" & DateTimePicker1.Text & "' AND CLASS='" & RadioButton1.Text & "' ", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            Dim USER_ID As Boolean = False
            While dr.Read()
                USER_ID = True
            End While
            myConnection.Close()
            If USER_ID = False Then
                myConnection.Close()
                MYConn.Open()
                KST = "EEEEEEEEEEEEEEEEEEEEEEEE"
                Dim STR As String
                STR = "INSERT INTO SEAT_INFO([FLIGHT_NO],[DATE_TRAVEL],[TIME_TRAVEL],[CLASS],[SEAT_LEFT],[FROM],[TO],[SEAT_SELECT])VALUES(?,?,?,?,?,?,?,?)"
                Dim CMD As OleDbCommand = New OleDbCommand(STR, MYConn)
                CMD.Parameters.Add(New OleDbParameter("FLIGHT_NO", CType(ComboBox3.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("DATE_TRAVEL", CType(DateTimePicker1.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("TIME_TRAVEL", CType(Label11.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("CLASS", CType(RadioButton1.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("SEAT_LEFT", CType(24, String)))
                CMD.Parameters.Add(New OleDbParameter("FROM", CType(ComboBox1.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("TO", CType(ComboBox2.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("SEAT_SELECT", CType(KST, String)))
                Try
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    MYConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf RadioButton2.Checked = True Then
            myConnection.Open()
            Dim KST As String
            Dim cm As New OleDbCommand("select * from [SEAT_INFO] WHERE FLIGHT_NO='" & ComboBox3.Text & "' AND DATE_TRAVEL='" & DateTimePicker1.Text & "' AND CLASS ='" & RadioButton2.Text & "' ", myConnection)
            Dim dr As OleDbDataReader = cm.ExecuteReader
            Dim USER_ID As Boolean = False
            While dr.Read()
                USER_ID = True
            End While
            myConnection.Close()
            If USER_ID = False Then
                myConnection.Close()
                MYConn.Open()
                KST = "EEEEEEEEEEEEEEEEEEEE"
                Dim STR As String
                STR = "INSERT INTO SEAT_INFO([FLIGHT_NO],[DATE_TRAVEL],[TIME_TRAVEL],[CLASS],[SEAT_LEFT],[FROM],[TO],[SEAT_SELECT])VALUES(?,?,?,?,?,?,?,?)"
                Dim CMD As OleDbCommand = New OleDbCommand(STR, MYConn)
                CMD.Parameters.Add(New OleDbParameter("FLIGHT_NO", CType(ComboBox3.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("DATE_TRAVEL", CType(DateTimePicker1.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("TIME_TRAVEL", CType(Label11.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("CLASS", CType(RadioButton2.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("SEAT_LEFT", CType(20, String)))
                CMD.Parameters.Add(New OleDbParameter("FROM", CType(ComboBox1.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("TO", CType(ComboBox2.Text, String)))
                CMD.Parameters.Add(New OleDbParameter("SEAT_SELECT", CType(KST, String)))
                Try
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    MYConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub CANCELTICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANCELTICKETToolStripMenuItem.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        DateTimePicker1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = False
        Label20.Visible = False
        ProgressBar1.Value = 0
        Label21.Text = "STEP:0 OF 5(JUST STARTED)"
        ProgressBar1.Visible = False
        Label21.Visible = False
        Hide()
        Form10.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If (DateTimePicker1.Text = "08 JUNE 2017" Or DateTimePicker1.Text = "09 JUNE 2017") Then
            MsgBox("IT IS AUR ANNIVERSARY YOU WILL GET INR 500 DISCOUNT")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form15.Show()
    End Sub

End Class