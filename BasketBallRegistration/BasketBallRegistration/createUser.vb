Imports MySql.Data.MySqlClient
Public Class createUser
    Public issadmin As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        welcome.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        Dim cmd As New MySqlCommand(String.Format("select username from basketball.users where username='{0}'", username.Text))
        Dim rd As MySqlDataReader
        cmd.Connection = conn
        Try
            rd = cmd.ExecuteReader
            rd.Close()
            If rd.HasRows Then
                MsgBox("اسم المستخدم مستعمل من قبل")
            Else
                If isAdmin.Checked Then
                    issadmin = 1
                Else
                    issadmin = 0
                End If
                cmd = New MySqlCommand(String.Format("insert into basketball.users values('{0}','{1}','{2}') ", username.Text, GetHash(pwd.Text), issadmin.ToString))
                cmd.Connection = conn
                rd = cmd.ExecuteReader
                rd.Close()
                Me.Visible = False
                welcome.Visible = True
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class