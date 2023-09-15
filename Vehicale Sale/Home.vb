Public Class Home
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnmaintance_Click(sender As Object, e As EventArgs) Handles btnmaintance.Click
        Me.Hide()
        Maintance.Show()
    End Sub

    Private Sub btnsold_Click(sender As Object, e As EventArgs) Handles btnsold.Click
        Me.Hide()
        Sold.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub btnforsale_Click(sender As Object, e As EventArgs) Handles btnforsale.Click
        Me.Hide()
        Forsale.Show()

    End Sub
End Class