Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form10
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Public Sub UpdateBasePremium(ageRange As String, sumInsuredRange As String, newBasePremium As Decimal)
        Try
            ' Age range to the corresponding database value   
            Dim ageValue As Integer = GetAgeValue(ageRange)

            ' SumInsured range to the corresponding column name in the database
            Dim sumInsuredColumn As String = GetSumInsuredColumn(sumInsuredRange)

            ' Initialize the connection
            con = New SqlConnection("Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False")

            ' Open the connection
            con.Open()

            ' Prepare the SQL update query
            Dim query As String = "UPDATE dbo.BasePremium SET [" & sumInsuredColumn & "] = @NewBasePremium WHERE Age = @Age"

            ' Create the command and add parameters to avoid SQL injection
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@NewBasePremium", newBasePremium)
            cmd.Parameters.AddWithValue("@Age", ageValue)

            ' Execute the command
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            ' Check if the record was updated
            If rowsAffected > 0 Then
                MessageBox.Show("Base premium updated successfully.")
            Else
                MessageBox.Show("No record found matching the criteria.")
            End If

        Catch ex As Exception
            ' Show an error message if something goes wrong
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Close the connection
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    '  map the age range to its SQL value
    Private Function GetAgeValue(ageRange As String) As Integer
        Select Case ageRange
            Case "0-17"
                Return 17
            Case "18-35"
                Return 35
            Case "36-40"
                Return 40
            Case "41-45"
                Return 45
            Case "46-50"
                Return 50
            Case "51-55"
                Return 55
            Case "56-60"
                Return 60
            Case "61-65"
                Return 65
            Case "66-70"
                Return 70
            Case "71-75"
                Return 75
            Case "<75"
                Return 100
            Case Else
                Return 0 ' Default to 0 if no match is found
        End Select
    End Function

    ' Helper method to map the sum insured range to the corresponding column name in the database
    Private Function GetSumInsuredColumn(sumInsuredRange As String) As String
        Select Case sumInsuredRange
            Case "3 Lakh"
                Return "3 Lakh"
            Case "4 Lakh"
                Return "4 Lakh"
            Case "5 Lakh"
                Return "5 Lakh"
            Case "7.5 Lakh"
                Return "7.5 Lakh"
            Case "10 Lakh"
                Return "10 Lakh"
            Case "15 Lakh"
                Return "15 Lakh"
            Case "20 Lakh"
                Return "20 Lakh"
            Case "25 Lakh"
                Return "25 Lakh"
            Case "50 Lakh"
                Return "50 Lakh"
            Case "75 Lakh"
                Return "75 Lakh"
            Case "1 Crore"
                Return "1 Crore"
            Case Else
                Return "" ' Default to empty if no match is found
        End Select
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedAge As String = ComboBox1.SelectedItem.ToString()
        Dim selectedSumInsured As String = ComboBox2.SelectedItem.ToString()
        Dim newBasePremium As Decimal = Decimal.Parse(TextBox2.Text) ' Get the new base premium from the text box

        ' Call the update function
        If Not String.IsNullOrEmpty(selectedAge) AndAlso Not String.IsNullOrEmpty(selectedSumInsured) Then
            UpdateBasePremium(selectedAge, selectedSumInsured, newBasePremium)
        Else
            MessageBox.Show("Please select valid age and sum insured.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub


End Class