Imports System.Data.SqlClient

Public Class Form12
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection

        con.ConnectionString = "Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False"


        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        showdata()
    End Sub
    Public Sub showdata()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from dbo.Feedback"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form2.Show()
        Me.Hide()

    End Sub
End Class