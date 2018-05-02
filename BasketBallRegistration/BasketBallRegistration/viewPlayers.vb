Imports MySql.Data.MySqlClient
Public Class viewPlayers


    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        Try
            Dim com As String = "select Pname, Amount_left , end_date from basketball.payment right outer join basketball.player on payment.player_id=player.player_id ;"

            Dim Adpt As New MySqlDataAdapter(com, conn)

            Dim ds As New DataSet()

            Adpt.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ScrollBars = ScrollBars.Both
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        welcome.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class