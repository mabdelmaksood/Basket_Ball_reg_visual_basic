Imports MySql.Data.MySqlClient
Public Class viewAttendance

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim com As String = " select Pname, at_date as attendance_date from basketball.player a left outer join basketball.attendance b on a.player_id = b.player_id order by  at_date desc;"

            Dim Adpt As New MySqlDataAdapter(com, conn)

            Dim ds As New DataSet()

            Adpt.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)
            'DataGridView1.AutoSize = True
            DataGridView1.ScrollBars = ScrollBars.Both
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        welcome.Visible = True
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub viewAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub
End Class