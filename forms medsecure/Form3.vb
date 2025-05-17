Public Class form3
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.OpenProspectForm() ' Call OpenProspectForm from Form1
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
        Form1.textbox1.Text = ""
        Form1.textbox2.Text = ""
        Form1.role.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub AgentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class