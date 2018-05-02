Imports MySql.Data.MySqlClient


Public Class PlayerCreation
    Public groupselected As Boolean
    Public PaymentDone As Boolean
    Public enddate As Date
    Public amountleft As Integer
    Public playerid As String
    Private Sub PlayerCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpselection.Items.Clear()
        groupselected = False
        PaymentDone = False
        Me.Panel1.Visible = False
        connect()
        Dim cmd As New MySqlCommand(String.Format("select grpName from basketball.grp"))
        Dim StrVar As String
        Dim rd As MySqlDataReader
        cmd.Connection = conn
        Try
            rd = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            If rd.HasRows Then
                While rd.Read()
                    'Dim item As New ListItem()
                    'item.Text = rd("grpName").ToString()
                    'item.Value = rd("group_ID").ToString()
                    grpselection.Items.Add(rd("grpName").ToString())
                End While
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles perlesson.CheckedChanged
        Me.Panel1.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles permonth.CheckedChanged
        Me.Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pname.Text = "" Or Pcode.Text = "" Then
            MsgBox("please enter valid player information")
        ElseIf (Not PaymentDone) And (Not groupselected) Then
            MsgBox("please make sure the group is selected and the payment in completed")

        Else
            connect()
            Dim cmd1 As New MySqlCommand(String.Format("select group_ID from basketball.grp where grpName ='{0}'", grpselection.Items.Item(grpselection.SelectedIndex()).ToString()))
            Dim grpid As String
            Dim rd1 As MySqlDataReader
            cmd1.Connection = conn
            Try
                rd1 = cmd1.ExecuteReader
                rd1.Read()
                grpid = rd1.GetString(0)
                rd1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim cmd As New MySqlCommand(String.Format("insert into basketball.player(pcode ,pname,birthyear,group_ID,birthmonth,birthday) values('{0}','{1}','{2}','{3}','{4}','{5}')", Pcode.Text, pname.Text, DateTimePicker1.Value.Year, grpid, DateTimePicker1.Value.Month, DateTimePicker1.Value.Day))
                'Dim StrVar As String
                Dim rd As MySqlDataReader
                cmd.Connection = conn
                rd = cmd.ExecuteReader
                rd.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                payment()
                Dim cmd2 As New MySqlCommand(String.Format("select player_id from basketball.player where pcode='{0}' and pname='{1}'", Pcode.Text, pname.Text))

                Dim rd2 As MySqlDataReader
                cmd2.Connection = conn
                rd2 = cmd2.ExecuteReader
                rd2.Read()
                playerid = rd2.GetString(0)
                rd2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try

                Dim cmd3 As New MySqlCommand(String.Format("insert into basketball.payment(player_id ,Amount_left,end_date) values('{0}','{1}','{2}')", playerid.ToString(), amountleft, enddate.ToString("yyyy-MM-dd")))
                'Dim StrVar As String
                Dim rd3 As MySqlDataReader
                cmd3.Connection = conn
                rd3 = cmd3.ExecuteReader
                rd3.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            conn.Close()
            welcome.Visible = True
            Me.Close()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        welcome.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grpselection.SelectedIndexChanged
        'MsgBox(grpselection.Items.Item(grpselection.SelectedIndex()).ToString())
        groupselected = True
    End Sub
    Private Sub payment()

        If permonth.Checked Then
            amountleft = -1
            enddate = Date.Now.AddMonths(1)
        ElseIf perlesson.Checked Then
            'amountleft = Convert.ToString(Convert.ToInt32(numberoflessons.Text) * Convert.ToInt32(numberoflessons.Text))
            amountleft = Convert.ToInt32(numberoflessons.Text)
            enddate = Date.Now
        End If
        PaymentDone = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class