Imports System.Data.SqlClient

Public Class Bill_house
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand






































    '
    ' Insert the house account data into the database
    Private Sub InsertHouseAccountData(totalAmount As Decimal)
        Try
            ' Create a new SQL connection

            Using connection As New SqlConnection("Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False")
                ' Open the connection
                connection.Open()

                ' Create a SQL command for the insert statement
                Dim updateCommand As New SqlCommand("UPDATE House_accounts SET MonthlyRent = @MonthlyRent, Deposit = @Deposit, TotalAmount = @TotalAmount WHERE HouseName = @HouseName", connection)

                ' Set the parameter values
                updateCommand.Parameters.AddWithValue("@HouseName", HouseName)
                updateCommand.Parameters.AddWithValue("@MonthlyRent", lbl_rent)
                updateCommand.Parameters.AddWithValue("@Deposit", lbl_deposit)
                updateCommand.Parameters.AddWithValue("@TotalAmount", totalAmount)

                ' Execute the insert command
                updateCommand.ExecuteNonQuery()

                ' Close the connection
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting data into the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    '
End Class