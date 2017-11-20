Public Class loginForm
    Dim uname As String = ""
    Dim pword As String = ""

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        uname = txtUsername.Text
        pword = txtPassword.Text
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        uname = "cancelClick"
        Me.Close()
    End Sub

    Public Function getUsername()
        Return uname
    End Function

    Public Function getPassword()
        Return pword
    End Function
End Class