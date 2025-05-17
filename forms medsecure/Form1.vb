Imports System.Data.SqlClient
Imports forms_medsecure.medsecureDataSetTableAdapters

Public Class Form1
    Private connectionString As String = "Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False"
    Public Shared loggedInAid As Integer = -1 ' Store Agent ID (Aid) globall
    Private Function ValidateLogin(username As String, password As String) As String
        Dim role As String = ""

        Using con As New SqlClient.SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT 'Admin' FROM dbo.Admin WHERE UserName = @username AND Password = @password"
            Using cmd As New SqlClient.SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing And Me.role.Text = "Admin" Then
                    role = "Admin"
                End If
            End Using

            ' Check if the user is an Agent
            If role = "" And Me.role.Text = "Agent" Then
                query = "SELECT Aid FROM dbo.Agent WHERE UserName = @username AND Password = @password"
                Using cmd As New SqlClient.SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing And Me.role.Text = "Agent" Then
                        loggedInAid = Convert.ToInt32(result) ' Store Aid globally
                        role = "Agent"
                    End If
                End Using
            End If

            ' Check if the user is a Manager
            If role = "" And Me.role.Text = "Manager" Then
                query = "SELECT 'Manager' FROM dbo.Manager WHERE UserName = @username AND Password = @password"
                Using cmd As New SqlClient.SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing And Me.role.Text = "Manager" Then
                        role = "Manager"
                    End If
                End Using
            End If
        End Using

        Return role
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = textbox1.Text
        Dim password As String = textbox2.Text
        Dim role As String = ValidateLogin(username, password)

        If role = "Admin" Then

            MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim adminForm As New form2()
            adminForm.Show()
            Me.Hide()

            Form11.Button4.Visible = True
            Form11.Button1.Visible = False
            Form11.Button3.Visible = False
            Form9.Button4.Visible = False
            Form9.Button1.Visible = True
            Form12.Button1.Visible = True
            Form12.Button4.Visible = False


        ElseIf role = "Agent" Then
            MessageBox.Show("Welcome, Agent!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open Agent Dashboard (Form3)
            Dim userForm As New form3()
            userForm.Show()
            Me.Hide()

            Form11.Button1.Visible = True
            Form11.Button4.Visible = False
            Form11.Button3.Visible = False
            Form12.Button4.Visible = True
            Form12.Button1.Visible = False

        ElseIf role = "Manager" Then

            MessageBox.Show("Welcome, Manager!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim userForm As New form4()
            userForm.Show()
            Me.Hide()

            Form11.Button4.Visible = False
            Form11.Button1.Visible = False
            Form11.Button3.Visible = True
            Form9.Button1.Visible = False
            Form9.Button4.Visible = True


        Else

            MessageBox.Show("Invalid Credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    'Function to Open Form6 with Aid
    Public Shared Sub OpenProspectForm()
        If loggedInAid <> -1 Then
            Dim prospectForm As New Form6()
            prospectForm.SetLoggedInAid(loggedInAid) ' Pass Aid to Form6
            prospectForm.Show()
        Else
            MessageBox.Show("Error: Agent ID (Aid) not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form16.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
