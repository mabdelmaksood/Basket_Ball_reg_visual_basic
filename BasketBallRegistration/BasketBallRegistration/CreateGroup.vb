Imports MySql.Data.MySqlClient
Public Class CreateGroup
    Public enddate As Date
    Public startdate As Date
    Public startselected As Boolean
    Public endselected As Boolean

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles weekdays.SelectedIndexChanged



    End Sub

    Private Sub CreateGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startselected = False
        endselected = False
        Me.weekdays.Items.Add("السبت")
        Me.weekdays.Items.Add("الأحد")
        Me.weekdays.Items.Add("الأثنين")
        Me.weekdays.Items.Add("الثلثاء")
        Me.weekdays.Items.Add("الأربعاء")
        Me.weekdays.Items.Add("الخميس")
        Me.weekdays.Items.Add("الجمعة")
        For x = 0 To 23
            Dim tm As New Date(1, 1, 1, x, 0, 0)
            starttime.Items.Add(tm.ToShortTimeString)
            endtime.Items.Add(tm.ToShortTimeString)
        Next

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        welcome.Visible = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles starttime.SelectedIndexChanged

        If Date.TryParse(starttime.SelectedItem.ToString, startdate) Then
            startselected = True
        End If

    End Sub
    Private Sub endtime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles endtime.SelectedIndexChanged

        If Date.TryParse(endtime.SelectedItem.ToString, enddate) Then
            endselected = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saturday As String
        Dim sunday As String
        Dim monday As String
        Dim tuesday As String
        Dim wednesday As String
        Dim thursday As String
        Dim friday As String
        Dim startingtm As String
        Dim endingtm As String
        Dim dayselectedflag As Boolean
        dayselectedflag = False
        If weekdays.GetItemChecked(0) Then
            saturday = "1"
            dayselectedflag = True
        Else
            saturday = "0"
        End If
        If weekdays.GetItemChecked(1) Then
            sunday = "1"
            dayselectedflag = True
        Else
            sunday = "0"
        End If
        If weekdays.GetItemChecked(2) Then
            monday = "1"
            dayselectedflag = True
        Else
            monday = "0"
        End If
        If weekdays.GetItemChecked(3) Then
            tuesday = "1"
            dayselectedflag = True
        Else
            tuesday = "0"
        End If
        If weekdays.GetItemChecked(4) Then
            wednesday = "1"
            dayselectedflag = True
        Else
            wednesday = "0"
        End If
        If weekdays.GetItemChecked(5) Then
            thursday = "1"
            dayselectedflag = True
        Else
            thursday = "0"
        End If
        If weekdays.GetItemChecked(6) Then
            friday = "1"
            dayselectedflag = True
        Else
            friday = "0"
        End If
        If dayselectedflag = False Then
            MsgBox("no day selected")
        ElseIf grpname.Text = "" Then
            MsgBox("no group name specified")
        ElseIf ((Not startselected) And (Not endselected)) Then
            MsgBox("please select start and end times")
        Else
            Try
                startingtm = startdate.ToString("HH:mm:ss")
                endingtm = enddate.ToString("HH:mm:ss")
            Catch ex As Exception
                MsgBox(ex.ToString())

            End Try
            Try
                connect()
                Dim cmd As New MySqlCommand(String.Format("INSERT INTO basketball.grp (grpName,saturday,sunday,monday,tuesday,wednesday,thursday,friday,start_time,end_time) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", grpname.Text, saturday, sunday, monday, tuesday, wednesday, thursday, friday, startingtm, endingtm))

                Dim rd As MySqlDataReader
                cmd.Connection = conn
                rd = cmd.ExecuteReader
                Me.Visible = False
                welcome.Visible = True
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        

    End Sub
End Class