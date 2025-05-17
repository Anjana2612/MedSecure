Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form6
    Private ReadOnly connectionString As String = "Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False"
    Private LoggedInAid As Integer ' Store the logged-in agent's Aid

    ' Function to Set the Logged-In Agent's Aid
    Public Sub SetLoggedInAid(aid As Integer)
        LoggedInAid = aid
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can use loggedInAid here to load agent-specific data
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Ensure Aid is valid
            If LoggedInAid <= 0 Then
                MessageBox.Show("Invalid user session. Please log in again.")
                Return
            End If

            ' Validate other fields (Name, DOB, Age, Phone, Email, etc.)
            Dim name As String = TextBox2.Text.Trim()
            Dim dob As DateTime
            If Not DateTime.TryParse(TextBox3.Text, dob) Then
                MessageBox.Show("Please enter a valid Date of Birth.")
                Return
            End If

            Dim age As Integer
            If Not Integer.TryParse(TextBox4.Text, age) OrElse age < 1 OrElse age > 120 Then
                MessageBox.Show("Please enter a valid Age (1-120).")
                Return
            End If

            Dim phoneNo As String = Regex.Replace(TextBox5.Text, "[^\d]", "")
            If Not Regex.IsMatch(phoneNo, "^\d{10,15}$") Then
                MessageBox.Show("Please enter a valid phone number (10-15 digits).")
                Return
            End If

            Dim emailId As String = TextBox6.Text.Trim()
            If String.IsNullOrWhiteSpace(emailId) OrElse Not emailId.Contains("@") Then
                MessageBox.Show("Please enter a valid Email ID.")
                Return
            End If

            Dim sumInsured As String = If(ComboBox1.SelectedItem IsNot Nothing, ComboBox1.SelectedItem.ToString().Trim(), String.Empty)
            If String.IsNullOrWhiteSpace(sumInsured) Then
                MessageBox.Show("Please select a valid Sum Insured amount.")
                Return
            End If

            Dim product As String = If(ComboBox2.SelectedItem IsNot Nothing, ComboBox2.SelectedItem.ToString(), String.Empty)

            Dim premium As Long
            If String.IsNullOrWhiteSpace(TextBox7.Text) OrElse Not Long.TryParse(TextBox7.Text.Trim(), premium) OrElse premium <= 0 Then
                MessageBox.Show("Please enter a valid Premium amount (must be a positive number).")
                Return
            End If

            Dim healthStatus As String = If(ComboBox4.SelectedItem IsNot Nothing, ComboBox4.SelectedItem.ToString(), "No Issue")

            If CheckBox1.Checked Then
                healthStatus = "No Issue" ' Checkbox checked means no health issues
            Else
                healthStatus = "Poor Health" ' Checkbox NOT checked means poor health
            End If


            ' Insert into Database
            Using conn As New SqlConnection(connectionString)
                conn.Open() ' Ensure connection is open

                Dim query As String = "INSERT INTO dbo.Prospect (Name, Dob, Age, PhoneNo, EmailId, SumInsured, Product, Premium, HealthStatus, Aid) " &
                          "VALUES (@Name, @Dob, @Age, @PhoneNo, @EmailId, @SumInsured, @Product, @Premium, @HealthStatus, @Aid)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Dob", dob)
                    cmd.Parameters.AddWithValue("@Age", age)
                    cmd.Parameters.AddWithValue("@PhoneNo", phoneNo)
                    cmd.Parameters.AddWithValue("@EmailId", emailId)
                    cmd.Parameters.AddWithValue("@SumInsured", sumInsured)
                    cmd.Parameters.AddWithValue("@Product", product)
                    cmd.Parameters.AddWithValue("@Premium", premium)
                    cmd.Parameters.AddWithValue("@HealthStatus", healthStatus)
                    cmd.Parameters.AddWithValue("@Aid", LoggedInAid) ' Use logged-in agent's Aid

                    ' Execute and check if data is inserted
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Rows Inserted: " & rowsAffected)
                End Using
            End Using

            MessageBox.Show("Prospect added successfully!")
            ResetForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetForm()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        CheckBox1.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        CheckBox1.Checked = False
        ComboBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        form3.Show()
        Me.Hide()

    End Sub


End Class