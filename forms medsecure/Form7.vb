Imports System.Data.SqlClient

Public Class Form7
    Private ReadOnly connectionString As String = "Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False"

    ' Load Aid and Product List
    Private Sub LoadData(pid As Integer)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                '  Retrieve Aid based on Prospect ID
                Dim query As String = "SELECT Aid, Product FROM dbo.Prospect WHERE Pid = @Pid"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Pid", pid)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TextBox2.Text = reader("Aid").ToString() ' Aid
                            ComboBox2.SelectedItem = reader("Product").ToString() ' Product
                        Else
                            MessageBox.Show("Prospect ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '  Save Feedback to Database 
    Private Sub SaveFeedback()
        Try
            If String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
               ComboBox2.SelectedItem Is Nothing OrElse
               String.IsNullOrWhiteSpace(RichTextBox1.Text) Then
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK)
                Return
            End If

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                '  Insert into Feedback table 
                Dim query As String = "INSERT INTO dbo.Feedback (Aid, Product, Review) VALUES (@Aid, @Product, @Review)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Aid", TextBox2.Text.Trim())
                    cmd.Parameters.AddWithValue("@Product", ComboBox2.SelectedItem?.ToString())
                    cmd.Parameters.AddWithValue("@Review", RichTextBox1.Text.Trim())

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Feedback saved successfully!", "Success", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Failed to save feedback.", "Error", MessageBoxButtons.OK)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving feedback: " & ex.Message, "Database Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        form3.Show()
        Me.Hide()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFeedback()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        ComboBox2.Text = ""
        RichTextBox1.Text = ""
    End Sub
End Class