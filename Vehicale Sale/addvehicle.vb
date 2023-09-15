
Imports System.Data.SqlClient
Public Class addvehicle


    Dim connect As New SqlConnection("Data Source=DESKTOP-JVBNIE6;Initial Catalog=vehicle_sale;Integrated Security=True")

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Forsale.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
        Home.Show()
    End Sub


    Private Sub btnaddvehicle_Click(sender As Object, e As EventArgs) Handles btnaddvehicle.Click
        Dim Strsql As String


        Strsql = "insert into add_car table values(@vehi_brand,@vehi_model,@manu_year,@reg_year,@price,@image )"
        Dim cmd2 As New SqlCommand(Strsql, Connect)

        cmd2.Parameters.AddWithValue("@vehi_brand", txtbrand.Text)
        cmd2.Parameters.AddWithValue("@vehi_model", txtmodel.Text)
        cmd2.Parameters.AddWithValue("@manu_year", txtmanuyear.Text)
        cmd2.Parameters.AddWithValue("@reg_year", txtregyear.Text)
        cmd2.Parameters.AddWithValue("@price", txtprice.Text)
        cmd2.Parameters.AddWithValue("@image", picbox1.Text)

        connect.Open()
        cmd2.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show("Vehicle Added Succesfuly", "Insert Record")

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Dim cmd1 As New SqlCommand("insert into add_car img1 values @image")
    End Sub
End Class