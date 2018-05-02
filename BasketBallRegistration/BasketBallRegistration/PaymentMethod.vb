Imports MySql.Data.MySqlClient

Public Class PaymentMethod
    Public is_per_lesson As Boolean
    Public Amount_left As Integer
    Public end_date As Date
    Private Sub PaymentMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panelsmall.Visible = False
        playerSelection.Items.Clear()
        playersearch.Text = ""


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        connect()
        If numberoflessons.Text <> "" Then
            Try
                If is_per_lesson Then
                    cmd = New MySqlCommand(String.Format("update basketball.payment set Amount_left='{0}'  where player_id=(select player_id from basketball.player where pname ='{1}')", (Amount_left + Convert.ToInt32(numberoflessons.Text)).ToString, playerSelection.Items.Item(playerSelection.SelectedIndex).ToString))

                Else
                    If Date.Now > end_date Then
                        end_date = Date.Now.AddMonths(Convert.ToInt32(numberoflessons.Text))
                    Else
                        end_date = end_date.AddMonths(Convert.ToInt32(numberoflessons.Text))
                    End If
                    cmd = New MySqlCommand(String.Format("update basketball.payment set end_date='{0}'  where player_id=(select player_id from basketball.player where pname ='{1}')", end_date.ToString("yyyy-MM-dd"), playerSelection.Items.Item(playerSelection.SelectedIndex).ToString))
                End If
                Dim rd As MySqlDataReader
                cmd.Connection = conn
                rd = cmd.ExecuteReader
                conn.Close()
                Me.Close()
                welcome.Visible = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If playerSelection.SelectedIndex <> -1 Then
            connect()
            Dim cmd As New MySqlCommand(String.Format("select Amount_left , end_date from basketball.payment join basketball.player on payment.player_id=player.player_id where pname= '{0}'", playerSelection.Items.Item(playerSelection.SelectedIndex).ToString))
            Dim rd As MySqlDataReader
            

            cmd.Connection = conn
            Try
                rd = cmd.ExecuteReader
                If rd.HasRows Then
                    While rd.Read()
                        Amount_left = rd("Amount_left")
                        end_date = rd("end_date")
                    End While
                End If
                If Amount_left = -1 Then
                    number_of.Text = "عدد الشهور"
                    is_per_lesson = False

                Else
                    number_of.Text = "عدد الحصص"
                    is_per_lesson = True
                    cmd = New MySqlCommand(String.Format("select Amount_left , end_date from basketball.payment join basketball.player on payment.player_id=player.player_id where pname= '{0}'", playerSelection.Items.Item(playerSelection.SelectedIndex).ToString))

                End If
                Panelsmall.Visible = True
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        welcome.Visible = True
    End Sub

    Private Sub playerSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerSelection.SelectedIndexChanged
        Amount_left = 0
        end_date = New Date()
        Panelsmall.Visible = False
        numberoflessons.Text = ""

    End Sub
End Class