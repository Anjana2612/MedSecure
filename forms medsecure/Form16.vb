
Imports System.Data.SqlClient

Public Class Form16
    Private ConnectionString As String = "Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False"

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox2.Text.Trim()
        Dim employeeName As String = TextBox1.Text.Trim()
        Dim password As String = TextBox3.Text.Trim()
        Dim contact As String = TextBox4.Text.Trim()
        Dim emailid As String = TextBox5.Text.Trim()
        Dim role As String = ComboBox1.SelectedItem.ToString()

        ' Validate input fields
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(employeeName) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(role) Then
            MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Determine the correct table based on the role
        Dim tableName As String = ""
        Select Case role
            Case "Admin"
                tableName = "dbo.Admin"
            Case "Agent"
                tableName = "dbo.Agent"
            Case "Manager"
                tableName = "dbo.Manager"
            Case Else
                MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select


        Dim query As String = "INSERT INTO " & tableName & " ( Name,UserName, Password,ContactNo,EmailId) VALUES (@EmployeeName, @username, @Password,@contact,@emailid)"

        Try
            Using conn As New SqlClient.SqlConnection(connectionString)
                Using cmd As New SqlClient.SqlCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@EmployeeName", employeeName)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@Password", password) ' Store securely in real applications
                    cmd.Parameters.AddWithValue("@contact", contact)
                    cmd.Parameters.AddWithValue("@emailid", emailid)
                    ' Open connection and execute query
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    MessageBox.Show(role & " registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
        Form1.textbox1.Text = ""
        Form1.textbox2.Text = ""
        Form1.role.Text = ""
    End Sub
End Class

