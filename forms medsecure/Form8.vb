Imports System.Data.SqlClient

Public Class Form8
    Private ReadOnly connectionString As String = "Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False"

    Private Sub LoadProspectData(pid As Integer)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()


                Dim query As String = "SELECT Name, Dob, Age, PhoneNo, EmailId, SumInsured, Product, Premium, HealthStatus 
                                       FROM dbo.Prospect WHERE Pid = @Pid"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Pid", pid)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then

                            TextBox2.Text = reader("Name").ToString()
                            TextBox3.Text = Convert.ToDateTime(reader("Dob")).ToString("yyyy-MM-dd")
                            TextBox4.Text = reader("Age").ToString()
                            TextBox5.Text = reader("PhoneNo").ToString()
                            TextBox6.Text = reader("EmailId").ToString()
                            TextBox7.Text = reader("SumInsured").ToString()
                            TextBox8.Text = reader("Product").ToString()
                            TextBox10.Text = reader("Premium").ToString()
                            TextBox9.Text = reader("HealthStatus").ToString()


                            Dim newStatus As String = ""
                            If reader("HealthStatus").ToString() = "No Issue" Then
                                newStatus = "Approved"
                            ElseIf reader("HealthStatus").ToString() = "Poor Health" Then
                                newStatus = "Rejected"
                            Else
                                ComboBox3.SelectedIndex = -1 ' No selection
                            End If


                            If Not String.IsNullOrEmpty(newStatus) Then
                                ComboBox3.SelectedItem = newStatus
                                UpdateProspectStatus(pid, newStatus) ' Update database
                            End If
                        Else
                            MessageBox.Show("Prospect ID not found.", "Error", MessageBoxButtons.OK)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Database Error", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Sub UpdateProspectStatus(pid As Integer, status As String)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Update the Status column in the dbo.Prospect table
                Dim query As String = "UPDATE dbo.Prospect SET Status = @Status WHERE Pid = @Pid"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@Pid", pid)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message, "Database Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pid As Integer
        If Integer.TryParse(TextBox1.Text.Trim(), pid) Then
            LoadProspectData(pid) ' Call function to retrieve data
        Else
            MessageBox.Show("Please enter a valid Prospect ID.", "Validation Error", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        ComboBox3.Text = ""

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class