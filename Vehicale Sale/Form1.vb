Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String
        Dim password As String
        username = txtuname.Text
        password = txtpassword.Text

        If username = "kalo" And password = "123" Or username = "sankalpa" And password = "1010" Then
            Me.Hide()
            Home.Show()
        Else : MsgBox("Incorrect Username Or Password.Try Again")
        End If
        txtpassword.Clear()
        txtuname.Clear()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
