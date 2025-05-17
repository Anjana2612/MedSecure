Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form5

    Dim con As SqlConnection
    Dim cmd As SqlCommand

    ' This method calculates the total premium based on the input data
    Public Sub CalculatePremium()
        Try
            ' Retrieve the base premium based on the age from TextBox2 and sum insured from ComboBox1
            Dim age As Integer = Integer.Parse(TextBox2.Text)
            Dim sumInsured As String = ComboBox1.SelectedItem.ToString()
            Dim basePremium As Decimal = GetBasePremium(age, sumInsured)

            If basePremium = 0 Then
                MessageBox.Show("Base premium could not be found.")
                Return
            End If

            ' 1. Adjust base premium based on selected product (ComboBox2)
            Dim product As String = ComboBox2.SelectedItem.ToString()
            Dim productMultiplier As Decimal = 1
            Select Case product
                Case "Aspire"
                    productMultiplier = 1 ' No change
                Case "Reassure 2.0"
                    productMultiplier = 1.05 ' 5% increase
                Case "Reassure"
                    productMultiplier = 1.2 ' 20% increase
            End Select
            basePremium *= productMultiplier

            ' 2. Adjust for number of adults (ComboBox4)
            Dim numAdults As Integer = Integer.Parse(ComboBox4.SelectedItem.ToString())
            If numAdults = 2 Then
                basePremium *= 1.5 ' 50% increase for 2 adults
            End If

            ' 3. Adjust for number of children (ComboBox5)
            Dim numChildren As Integer = Integer.Parse(ComboBox5.SelectedItem.ToString())
            basePremium *= (1 + 0.1 * numChildren) ' 10% increase for each child

            ' 4. Adjust for selected riders (ComboBox3)
            Dim riders As String = ComboBox3.SelectedItem.ToString()
            If riders.Contains("Hospital Daily cash") Then
                basePremium *= 1.065 ' 6.5% increase
            End If
            If riders.Contains("Safe Guard") Then
                If sumInsured = "3 Lakh" Then
                    basePremium *= 1.1 ' 10% increase for 5 Lakh sum insured
                ElseIf sumInsured = "4 Lakh" Then
                    basePremium *= 1.1 ' 10% increase for 5 Lakh sum insured
                ElseIf sumInsured = "5 Lakh" Then
                    basePremium *= 1.1 ' 10% increase for 5 Lakh sum insured
                ElseIf Decimal.Parse(sumInsured.Replace(" Lakh", "")) > 7.5 Then
                    basePremium *= 1.075 ' 7.5% increase for sum insured > 7.5 Lakh
                End If
            End If

            ' 5. Calculate GST
            Dim totalPremium As Decimal = basePremium * 1.18 ' Add 18% GST

            ' 6. Display the total premium in TextBox6
            TextBox6.Text = totalPremium.ToString("C2") ' Format as currency

        Catch ex As Exception
            MessageBox.Show("Please enter values")
        End Try
    End Sub

    ' Helper method to retrieve the base premium from the database based on age and sum insured
    Private Function GetBasePremium(age As Integer, sumInsured As String) As Decimal
        Dim basePremium As Decimal = 0

        Try
            ' Initialize SQL connection
            con = New SqlConnection("Data Source=DESKTOP-1QFU7H5\SQLEXPRESS;Initial Catalog=medsecure;Integrated Security=True;Encrypt=False")
            con.Open()

            ' Map age to the corresponding value in the database
            Dim ageValue As Integer = GetAgeValue(age)

            ' Map sum insured to the corresponding column name in the database
            Dim sumInsuredColumn As String = GetSumInsuredColumn(sumInsured)

            ' Prepare the SQL query to fetch the base premium
            Dim query As String = "SELECT [" & sumInsuredColumn & "] FROM dbo.BasePremium WHERE Age = @Age"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Age", ageValue)

            ' Execute the query and retrieve the base premium
            basePremium = Convert.ToDecimal(cmd.ExecuteScalar())

        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching base premium: " & ex.Message)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Return basePremium
    End Function

    ' Helper method to map age to its corresponding value in the database
    Private Function GetAgeValue(age As Integer) As Integer
        Select Case age
            Case <= 17
                Return 17
            Case 18 To 35
                Return 35
            Case 36 To 40
                Return 40
            Case 41 To 45
                Return 45
            Case 46 To 50
                Return 50
            Case 51 To 55
                Return 55
            Case 56 To 60
                Return 60
            Case 61 To 65
                Return 65
            Case 66 To 70
                Return 70
            Case 71 To 75
                Return 75
            Case Else
                Return 100 ' For age > 75
        End Select
    End Function

    ' Helper method to map sum insured to the corresponding column name in the database
    Private Function GetSumInsuredColumn(sumInsured As String) As String
        Select Case sumInsured
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        ComboBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox4.Text = ""
        ComboBox2.Text = ""
        ComboBox5.Text = ""
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculatePremium()

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
End Class