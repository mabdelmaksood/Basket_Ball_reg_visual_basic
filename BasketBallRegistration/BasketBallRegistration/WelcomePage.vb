Public Class WelcomePage
    Public isAdmin As Boolean = False
    Public username As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.groupreg.Visible = Me.isAdmin
        Me.paymentreg.Visible = Me.isAdmin
        Me.newUser.Visible = Me.isAdmin
        Me.usernamelabel.Text = username
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Visible = False
        sign_in.pwd.Clear()
        sign_in.Visible = True

        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles playerreg.Click
        Me.Visible = False
        player.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles groupreg.Click
        Me.Visible = False
        group.ShowDialog()
    End Sub

    Private Sub attendancereg_Click(sender As Object, e As EventArgs) Handles attendancereg.Click
        Me.Visible = False
        attendancee.ShowDialog()
    End Sub

    Private Sub paymentreg_Click(sender As Object, e As EventArgs) Handles paymentreg.Click
        Me.Visible = False
        payment.ShowDialog()

    End Sub

    Private Sub newUser_Click(sender As Object, e As EventArgs) Handles newUser.Click
        Me.Visible = False
        createUserr.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        showplayers.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        showattendance.ShowDialog()
    End Sub
End Class