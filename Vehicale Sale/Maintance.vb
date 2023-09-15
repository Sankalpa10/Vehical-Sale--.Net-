Imports System.Data.SqlClient


Public Class Maintance
    Dim connect As New SqlConnection("Data Source=DESKTOP-JVBNIE6;Initial Catalog=vehicle_sale;Integrated Security=True")

    Public Sub Addnew()
        Dim dupsql As String
        dupsql = "select Car_id from Maintance where car_id = @car_id"
        connect.Open()

        Dim cmd2 As New SqlCommand(dupsql, connect)
        cmd2.Parameters.AddWithValue("@Car_id", txtcarid.Text)


        Dim myreader As SqlDataReader
        myreader = cmd2.ExecuteReader()

        If (myreader.Read()) Then
            connect.Close()
            MessageBox.Show("Duplicate Vehicale Number", " Error")
        Else
            connect.Close()
            Dim strsql As String

            strsql = "Insert into Maintance values (@Car id,@Garage name,@Problem,@Finishdate)"
            Dim cmd1 As New SqlCommand(strsql, connect)

            cmd2.Parameters.AddWithValue("@Car_id", txtcarid.Text)
            cmd2.Parameters.AddWithValue("@Garage_name", txtgragename.Text)
            cmd2.Parameters.AddWithValue("@Problem", txtproblam.Text)
            cmd2.Parameters.AddWithValue("@Finish_date", txtfinishdate.Text)

            connect.Open()
            cmd1.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Data Added Succesfull")
        End If

    End Sub
    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        Addnew()
    End Sub

    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Are You Sure ?", "Delete Record", MessageBoxButtons.YesNo) - DialogResult.Yes Then
            Dim delsql As String
            delsql = "delete from Maintance where Car_id = @Car_id"


            Dim cmd3 As New SqlCommand(delsql, connect)
            cmd3.Parameters.AddWithValue("@car_id", txtcarid.Text)
            connect.Open()
            cmd3.ExecuteNonQuery()
            MessageBox.Show("Record is Deleted")
            txtcarid.Clear()
        Else
            MessageBox.Show("operation is aborted", "cancel")

        End If
        connect.Close()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        LoadData()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim upsql As String = "update Maintance set Problem =@Problem,Garage_name = @Garage_name where Car_id = @Car_id"
        Dim cmdup As New SqlCommand(upsql, connect)

        cmdup.Parameters.AddWithValue("@Car_id", txtcarid.Text)
        cmdup.Parameters.AddWithValue("@Garage_name", txtgragename.Text)
        cmdup.Parameters.AddWithValue("@Problem", txtproblam.Text)
        cmdup.Parameters.AddWithValue("@Finish_date", txtfinishdate.Text)

        connect.Open()
        cmdup.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show("Successfully Updated", "Update Record")
        LoadData



    End Sub
    Public Sub LoadData()
        Dim loadsql As String = "select * from Maintance"
        Dim cmdload As New SqlCommand(loadsql, connect)
        connect.Open()
        cmdload.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim sda As New SqlDataAdapter(cmdload)
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        connect.Close()

    End Sub

    Private Sub Maintance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class