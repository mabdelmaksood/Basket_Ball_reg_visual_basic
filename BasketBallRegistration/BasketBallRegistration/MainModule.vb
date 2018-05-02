Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Module MainModule
    Public sign_in As New SignIn()
    Public welcome As New WelcomePage()
    Public attendancee As New Attendance()
    Public player As New PlayerCreation()
    Public group As New CreateGroup()
    Public payment As New PaymentMethod()
    Public createUserr As New createUser()
    Public showplayers As New viewPlayers()
    Public showattendance As New viewAttendance()
    Public conn As New MySqlConnection()


    Sub Main()
        sign_in.ShowDialog()

    End Sub



    Public Sub connect()
        Dim DatabaseName As String = "MySQL"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "sys"
        Dim password As String = "system"
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function
End Module
