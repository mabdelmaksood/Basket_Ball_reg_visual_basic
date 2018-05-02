Imports MySql.Data.MySqlClient
Public Class Attendance
    Public player_id As String
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        playersearch.Text = ""
        playerSelection.Items.Clear()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'enddd
        connect()
        Try
            Dim cmd As New MySqlCommand(String.Format("select player_id from basketball.player where pname='{0}'", playerSelection.Items.Item(playerSelection.SelectedIndex()).ToString()))
            Dim rd As MySqlDataReader

            cmd.Connection = conn
                rd = cmd.ExecuteReader
                If rd.HasRows Then
                    While rd.Read()
                        player_id = rd.GetString(0)
                End While
                rd.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cmd1 As New MySqlCommand(String.Format("select Amount_left,end_date from basketball.payment where player_id='{0}'", player_id))
            Dim rd1 As MySqlDataReader
            Dim amount_left As String
            Dim dateend As Date
            cmd1.Connection = conn
            rd1 = cmd1.ExecuteReader
            If rd1.HasRows Then
                While rd1.Read()
                    amount_left = rd1("Amount_left").ToString
                    dateend = rd1("end_date")
                End While
                rd1.Close()
                If amount_left = "-1" And dateend < Date.Now Then
                    MsgBox("this player is out of payment")
                ElseIf amount_left = "0" Then
                    MsgBox("this player is out of payment")
                ElseIf Convert.ToInt32(amount_left) > 0 Then
                    cmd1 = New MySqlCommand(String.Format("INSERT INTO basketball.attendance values('{0}','{1}')", Date.Now.ToString("yyyy-MM-dd"), player_id))
                    cmd1.Connection = conn
                    rd1 = cmd1.ExecuteReader
                    rd1.Close()
                    cmd1 = New MySqlCommand(String.Format("update basketball.payment set Amount_left='{0}' where player_id='{1}'", (Convert.ToInt32(amount_left) - 1).ToString, player_id))
                    cmd1.Connection = conn
                    rd1 = cmd1.ExecuteReader
                    MsgBox("number of lessons left for player =" + (Convert.ToInt32(amount_left) - 1).ToString)
                    rd1.Close()
                ElseIf amount_left = "-1" Then
                    cmd1 = New MySqlCommand(String.Format("INSERT INTO basketball.attendance values('{0}','{1}')", Date.Now.ToString("yyyy-MM-dd"), player_id))
                    cmd1.Connection = conn
                    rd1 = cmd1.ExecuteReader
                    rd1.Close()
                    cmd1 = New MySqlCommand(String.Format("update basketball.payment set Amount_left='{0}' where player_id='{1}'", (Convert.ToInt32(amount_left) - 1).ToString, player_id))
                    cmd1.Connection = conn
                    rd1 = cmd1.ExecuteReader
                    MsgBox("the player can attend up to =" + dateend.ToString("yyyy-MM-dd"))
                    rd1.Close()


                End If
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If playerSelection.SelectedIndex <> -1 Then
            Panel1.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        Dim cmd As New MySqlCommand(String.Format("select pname from basketball.player where pname like'%{0}%'", playersearch.Text))
        Dim rd As MySqlDataReader
        cmd.Connection = conn
        Try
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                While rd.Read()
                    playerSelection.Items.Add(rd("pname").ToString())
                End While
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        welcome.Visible = True
    End Sub
End Class