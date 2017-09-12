Imports System.Data.OleDb

Public Class Form12
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim myConn As OleDbConnection = New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim strin As String() = {"KOLKATA", "DELHI", "CHENNAI", "MUMBAI"}

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Label3.Text = Form11.Label3.Text
        Label4.Text = Form11.Label4.Text
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConn.ConnectionString = connString
        ComboBox1.Items.AddRange(strin)
        ComboBox2.Items.AddRange(strin)
    End Sub

    Private Sub ADDFLIGHTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDFLIGHTToolStripMenuItem.Click
        Hide()
        Form11.Show()
        Form11.GroupBox1.Visible = True
        Form11.GroupBox2.Visible = False
        Form11.GroupBox3.Visible = False
        Form11.GroupBox4.Visible = True
    End Sub

    Private Sub CHANGEFAREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHANGEFAREToolStripMenuItem.Click
        Hide()
        Form11.Show()
        Form11.GroupBox1.Visible = False
        Form11.GroupBox2.Visible = True
        Form11.GroupBox3.Visible = False
        Form11.GroupBox4.Visible = True
    End Sub


    Private Sub ADDSEATSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDSEATSToolStripMenuItem.Click
        Hide()
        Form11.Show()
        Form11.GroupBox1.Visible = False
        Form11.GroupBox3.Visible = True
        Form11.GroupBox2.Visible = False
        Form11.GroupBox4.Visible = True
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
        End If
        Label6.Visible = True
        ComboBox3.Visible = True
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo)
        If okToDelete = MsgBoxResult.Yes Then
            myConnection.Open()
            Dim str As String
            str = "Delete from FLIGHT_DESC Where FLIGHT_NO = '" & ComboBox3.Text & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("FLIGHT REMOVED SUCCESSFULLY :)")
            Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf okToDelete = MsgBoxResult.No Then
        End If
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub REMOVEUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVEUSERToolStripMenuItem.Click
        Label13.Visible = False
        Button5.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        DataGridView1.Visible = False
        GroupBox2.Visible = True
        GroupBox1.Visible = False
        GroupBox3.Visible = False
    End Sub


    Private Sub REMOVEFLIGHTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVEFLIGHTToolStripMenuItem.Click
        Label13.Visible = False
        Button5.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        DataGridView1.Visible = False
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete the current user?", MsgBoxStyle.YesNo)
        If okToDelete = MsgBoxResult.Yes Then
            myConnection.Open()
            Dim str As String
            str = "Delete from register Where USER_ID = '" & TextBox1.Text & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("USER DELETED SUCCESSFULLY :)")
            Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf okToDelete = MsgBoxResult.No Then
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myConn.Open()
        Dim cm As New OleDbCommand("Select * from [RESERVATION] WHERE DATE='" & DateTimePicker1.Text & "'", myConn)
        Dim dr As OleDbDataReader = cm.ExecuteReader
        Dim BOOL As Boolean = False
        While dr.Read()
            BOOL = True
        End While
        If BOOL = False Then
            MsgBox("NO TRANSACTION ON GIVEN DATE")
            myConn.Close()
            DataGridView1.Visible = False
            Label13.Visible = False
            Button5.Visible = False
            Label14.Text = "0"
            Label14.Visible = False
            Label15.Visible = False
            Exit Sub
        Else
            myConn.Close()
            myConnection = New OleDbConnection
            myConnection.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [RESERVATION] WHERE DATE='" & DateTimePicker1.Text & "'", myConnection)
        da.Fill(ds, "items")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
        DataGridView1.Visible = True
        Label13.Visible = True
        Button5.Visible = True
            Label14.Text = "0"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim TOTAL As String = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            TOTAL += DataGridView1.Rows(i).Cells(9).Value
        Next
        Label14.Visible = True
        Label15.Visible = True
        Label14.Text = TOTAL
    End Sub

    Private Sub BOOKINGDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGDETAILSToolStripMenuItem.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = False
        GroupBox3.Visible = True
    End Sub
End Class