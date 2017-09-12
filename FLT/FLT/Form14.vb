Imports System.Data.OleDb

Public Class Form14
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim STR As String
    Dim KTR As String
    Dim k As Char
    Dim i As PictureBox
    Public myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\LENOVO\Desktop\FLT\Database5.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        Label22.Text = Form5.ComboBox4.Text
        If Form5.RadioButton1.Checked = True Then
            myConnection.Open()
            Dim CM As New OleDbCommand("SELECT * FROM [SEAT_INFO] WHERE FLIGHT_NO='" & Form5.ComboBox3.Text & "'AND DATE_TRAVEL='" & Form5.DateTimePicker1.Text & "' AND CLASS='" & Form5.RadioButton1.Text & "'", myConnection)
            Dim dr As OleDbDataReader = CM.ExecuteReader
            While dr.Read
                STR = dr(7).ToString
            End While
            myConnection.Close()
            If STR.Chars(0) = "E" Then
                PictureBox21.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf STR.Chars(0) = "B" Then
                PictureBox21.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = STR.Chars(1)
            If k = "E" Then
                PictureBox22.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox22.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(2)
            If k = "E" Then
                PictureBox23.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox23.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(3)
            If k = "E" Then
                PictureBox24.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox24.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(4)
            If k = "E" Then
                PictureBox25.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox25.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(5)
            If k = "E" Then
                PictureBox26.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox26.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(6)
            If k = "E" Then
                PictureBox27.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox27.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(7)
            If k = "E" Then
                PictureBox28.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox28.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(8)
            If k = "E" Then
                PictureBox29.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox29.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(9)
            If k = "E" Then
                PictureBox30.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox30.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(10)
            If k = "E" Then
                PictureBox31.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox31.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(11)
            If k = "E" Then
                PictureBox32.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox32.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(12)
            If k = "E" Then
                PictureBox33.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox33.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If

            k = STR.Chars(13)
            If STR.Length > 12 And k = "E" Then
                PictureBox34.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox34.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If

            k = STR.Chars(14)
            If STR.Length > 12 And k = "E" Then
                PictureBox35.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox35.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(15)
            If STR.Length > 12 And k = "E" Then
                PictureBox36.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox36.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(16)
            If STR.Length > 12 And k = "E" Then
                PictureBox37.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox37.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(17)
            If STR.Length > 12 And k = "E" Then
                PictureBox38.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox38.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(18)
            If STR.Length > 12 And k = "E" Then
                PictureBox39.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox39.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(19)
            If STR.Length > 12 And k = "E" Then
                PictureBox40.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox40.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(20)
            If STR.Length > 12 And k = "E" Then
                PictureBox41.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox41.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(21)
            If STR.Length > 12 And k = "E" Then
                PictureBox42.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox42.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(22)
            If STR.Length > 12 And k = "E" Then
                PictureBox43.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox43.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = STR.Chars(23)
            If STR.Length > 12 And k = "E" Then
                PictureBox44.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox44.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            GroupBox1.Visible = False
        ElseIf Form5.RadioButton2.Checked = True Then
            myConnection.Open()
            Dim CM As New OleDbCommand("SELECT * FROM [SEAT_INFO] WHERE FLIGHT_NO='" & Form5.ComboBox3.Text & "'AND DATE_TRAVEL='" & Form5.DateTimePicker1.Text & "' AND CLASS='" & Form5.RadioButton2.Text & "'", myConnection)
            Dim dr As OleDbDataReader = CM.ExecuteReader
            While dr.Read
                KTR = dr(7).ToString
            End While
            myConnection.Close()
            If KTR.Chars(0) = "E" Then
                PictureBox1.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf KTR.Chars(0) = "B" Then
                PictureBox1.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = KTR.Chars(1)
            If k = "E" Then
                PictureBox2.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox2.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(2)
            If k = "E" Then
                PictureBox3.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox3.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(3)
            If k = "E" Then
                PictureBox4.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox4.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(4)
            If k = "E" Then
                PictureBox5.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox5.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(5)
            If k = "E" Then
                PictureBox6.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox6.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(6)
            If k = "E" Then
                PictureBox7.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox7.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(7)
            If k = "E" Then
                PictureBox8.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox8.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(8)
            If k = "E" Then
                PictureBox9.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox9.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(9)
            If k = "E" Then
                PictureBox10.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox10.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(10)
            If k = "E" Then
                PictureBox11.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox11.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(11)
            If k = "E" Then
                PictureBox12.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox12.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(12)
            If k = "E" Then
                PictureBox13.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox13.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If

            k = KTR.Chars(13)
            If k = "E" Then
                PictureBox14.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox14.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If

            k = KTR.Chars(14)
            If k = "E" Then
                PictureBox15.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox15.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(15)
            If k = "E" Then
                PictureBox16.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox16.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(16)
            If k = "E" Then
                PictureBox17.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox17.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(17)
            If k = "E" Then
                PictureBox18.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox18.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(18)
            If k = "E" Then
                PictureBox19.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox19.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            k = ""
            k = KTR.Chars(19)
            If k = "E" Then
                PictureBox20.Image = Image.FromFile(Application.StartupPath & "\greychair.gif")
            ElseIf k = "B" Then
                PictureBox20.Image = Image.FromFile(Application.StartupPath & "\redchair.gif")
            End If
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If KTR.Chars(0) = "E" And Val(Label22.Text) > 0 Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(0, 1).Insert(0, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If KTR.Chars(1) = "E" And Val(Label22.Text) > 0 Then
            PictureBox2.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(1, 1).Insert(1, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If KTR.Chars(2) = "E" And Val(Label22.Text) > 0 Then
            PictureBox3.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(2, 1).Insert(2, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If KTR.Chars(3) = "E" And Val(Label22.Text) > 0 Then
            PictureBox4.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(3, 1).Insert(3, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If KTR.Chars(4) = "E" And Val(Label22.Text) > 0 Then
            PictureBox5.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(4, 1).Insert(4, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If KTR.Chars(5) = "E" And Val(Label22.Text) > 0 Then
            PictureBox6.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(5, 1).Insert(5, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If KTR.Chars(6) = "E" And Val(Label22.Text) > 0 Then
            PictureBox7.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(6, 1).Insert(6, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If KTR.Chars(7) = "E" And Val(Label22.Text) > 0 Then
            PictureBox8.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(7, 1).Insert(7, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If KTR.Chars(8) = "E" And Val(Label22.Text) > 0 Then
            PictureBox9.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(8, 1).Insert(8, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If KTR.Chars(9) = "E" And Val(Label22.Text) > 0 Then
            PictureBox10.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(9, 1).Insert(9, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If KTR.Chars(10) = "E" And Val(Label22.Text) > 0 Then
            PictureBox11.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(10, 1).Insert(10, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If KTR.Chars(11) = "E" And Val(Label22.Text) > 0 Then
            PictureBox12.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(11, 1).Insert(11, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If KTR.Chars(12) = "E" And Val(Label22.Text) > 0 Then
            PictureBox13.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(12, 1).Insert(12, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If KTR.Chars(13) = "E" And Val(Label22.Text) > 0 Then
            PictureBox14.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(13, 1).Insert(13, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If KTR.Chars(14) = "E" And Val(Label22.Text) > 0 Then
            PictureBox15.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(14, 1).Insert(14, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If KTR.Chars(15) = "E" And Val(Label22.Text) > 0 Then
            PictureBox16.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(15, 1).Insert(15, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If KTR.Chars(16) = "E" And Val(Label22.Text) > 0 Then
            PictureBox17.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(16, 1).Insert(16, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If KTR.Chars(17) = "E" And Val(Label22.Text) > 0 Then
            PictureBox18.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(17, 1).Insert(17, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If KTR.Chars(18) = "E" And Val(Label22.Text) > 0 Then
            PictureBox19.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(18, 1).Insert(18, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If KTR.Chars(19) = "E" And Val(Label22.Text) > 0 Then
            PictureBox20.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            KTR = KTR.Remove(19, 1).Insert(19, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If STR.Chars(0) = "E" And Val(Label22.Text) > 0 Then
            PictureBox21.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(0, 1).Insert(0, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label23.Text = KTR
        Label24.Text = STR
        If Form5.RadioButton2.Checked = True Then
            myConnection.Open()
            Dim KTm As String
            KTm = "update [SEAT_INFO] set [SEAT_SELECT] = '" & Label23.Text & "' Where [FLIGHT_NO]='" & Form5.ComboBox3.Text & "' AND [DATE_TRAVEL]='" & Form5.DateTimePicker1.Text & "' AND [CLASS]='" & Form5.RadioButton2.Text & "' "
            Dim cmdI As OleDbCommand = New OleDbCommand(KTm, myConnection)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf Form5.Radiobutton1.Checked = True Then
            myConnection.Open()
            Dim KTm As String
            KTm = "update [SEAT_INFO] set [SEAT_SELECT] = '" & Label24.Text & "' Where [FLIGHT_NO]='" & Form5.ComboBox3.Text & "' AND [DATE_TRAVEL]='" & Form5.DateTimePicker1.Text & "' AND [CLASS]='" & Form5.RadioButton1.Text & "' "
            Dim cmdI As OleDbCommand = New OleDbCommand(KTm, myConnection)
            Try
                cmdI.ExecuteNonQuery()
                cmdI.Dispose()
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Form5.Show()
        Hide()

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If STR.Chars(1) = "E" And Val(Label22.Text) > 0 Then
            PictureBox22.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(1, 1).Insert(1, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        If STR.Chars(2) = "E" And Val(Label22.Text) > 0 Then
            PictureBox23.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(2, 1).Insert(2, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        If STR.Chars(3) = "E" And Val(Label22.Text) > 0 Then
            PictureBox24.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(3, 1).Insert(3, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If STR.Chars(4) = "E" And Val(Label22.Text) > 0 Then
            PictureBox25.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(4, 1).Insert(4, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        If STR.Chars(5) = "E" And Val(Label22.Text) > 0 Then
            PictureBox26.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(5, 1).Insert(5, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        If STR.Chars(6) = "E" And Val(Label22.Text) > 0 Then
            PictureBox27.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(6, 1).Insert(6, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        If STR.Chars(7) = "E" And Val(Label22.Text) > 0 Then
            PictureBox28.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(7, 1).Insert(7, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        If STR.Chars(8) = "E" And Val(Label22.Text) > 0 Then
            PictureBox29.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(8, 1).Insert(8, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        If STR.Chars(9) = "E" And Val(Label22.Text) > 0 Then
            PictureBox30.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(9, 1).Insert(9, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        If STR.Chars(10) = "E" And Val(Label22.Text) > 0 Then
            PictureBox31.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(10, 1).Insert(10, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        If STR.Chars(11) = "E" And Val(Label22.Text) > 0 Then
            PictureBox32.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(11, 1).Insert(11, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        If STR.Chars(12) = "E" And Val(Label22.Text) > 0 Then
            PictureBox33.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(12, 1).Insert(12, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        If STR.Chars(13) = "E" And Val(Label22.Text) > 0 Then
            PictureBox34.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(13, 1).Insert(13, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        If STR.Chars(14) = "E" And Val(Label22.Text) > 0 Then
            PictureBox35.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(14, 1).Insert(14, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        If STR.Chars(15) = "E" And Val(Label22.Text) > 0 Then
            PictureBox36.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(15, 1).Insert(15, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        If STR.Chars(16) = "E" And Val(Label22.Text) > 0 Then
            PictureBox37.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(16, 1).Insert(16, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        If STR.Chars(17) = "E" And Val(Label22.Text) > 0 Then
            PictureBox38.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(17, 1).Insert(17, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        If STR.Chars(18) = "E" And Val(Label22.Text) > 0 Then
            PictureBox39.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(18, 1).Insert(18, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        If STR.Chars(19) = "E" And Val(Label22.Text) > 0 Then
            PictureBox40.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(19, 1).Insert(19, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        If STR.Chars(20) = "E" And Val(Label22.Text) > 0 Then
            PictureBox41.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(20, 1).Insert(20, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        If STR.Chars(21) = "E" And Val(Label22.Text) > 0 Then
            PictureBox42.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(21, 1).Insert(21, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        If STR.Chars(22) = "E" And Val(Label22.Text) > 0 Then
            PictureBox43.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(22, 1).Insert(22, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        If STR.Chars(23) = "E" And Val(Label22.Text) > 0 Then
            PictureBox44.Image = Image.FromFile(Application.StartupPath & "\greenchair.gif")
            Label22.Text = Val(Label22.Text) - 1
            STR = STR.Remove(23, 1).Insert(23, "B")
            If Val(Label22.Text) = 0 Then
                MsgBox("ALL SEATS SELECTED GO BACK TO CONFIRM BOOKING :)")
            End If
        Else
            MsgBox("SEAT ALREADY BOOKED OR YOU HAVE SELECTED ALL YOUR SEATS")
        End If
    End Sub
End Class