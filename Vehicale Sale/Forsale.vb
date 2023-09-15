Public Class Forsale



    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btnaddvehicle_Click(sender As Object, e As EventArgs) Handles btnaddvehicle.Click
        Me.Hide()
        addvehicle.Show()
    End Sub
End Class