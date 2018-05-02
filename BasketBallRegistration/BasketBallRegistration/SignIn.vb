Imports MySql.Data.MySqlClient

Public Class SignIn

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        Dim cmd As New MySqlCommand(String.Format("select pwd,isAdmin from basketball.users where username='{0}'", username.Text))
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
                If rd.Read Then
                    StrVar = rd.GetString(0)
                    welcome.isAdmin = rd(1)
                    If StrVar.ToUpper() = GetHash(pwd.Text) Then
                        rd.Close()
                        Me.Visible = False
                        welcome.username = " أهلا" & Me.username.Text
                        welcome.ShowDialog()
                        conn.Close()

                    Else
                        MsgBox("Wrong password")
                    End If
                End If
            Else
                MsgBox("Wrong username")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
