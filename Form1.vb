Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sConnectionString As String = "Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False"

        ' Define the connection string to the database
        ' Check if the username, password, and user type fields are empty
        If String.IsNullOrWhiteSpace(txt_uname.Text) OrElse String.IsNullOrWhiteSpace(txt_pwd.Text) OrElse combo_utype.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return
        End If

        '

        ' Create a SqlConnection using the connection string
        Using con As SqlConnection = New SqlConnection(sConnectionString)
            con.Open()

            ' Define the SQL query with parameters for username, password, and usertype
            Dim query As String = "SELECT * FROM user_data WHERE username = @username AND password = @password AND usertype = @usertype"
            Dim cmd As SqlCommand = New SqlCommand(query, con)

            ' Set parameter values to prevent SQL injection and improve security
            cmd.Parameters.AddWithValue("@username", txt_uname.Text.ToUpper())
            cmd.Parameters.AddWithValue("@password", txt_pwd.Text.ToUpper())
            cmd.Parameters.AddWithValue("@usertype", combo_utype.SelectedItem.ToUpper())

            ' Create a DataTable to hold the results of the query
            Dim dt As DataTable = New DataTable()

            ' Create a SqlDataAdapter to fill the DataTable with data from the query
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)

            ' Check if any rows are returned from the query
            If dt.Rows.Count > 0 Then
                ' If there are rows, display a success message with the user type
                MessageBox.Show("You are logged in as " & dt.Rows(0)("usertype").ToString())

                ' Based on the selected user type, show the appropriate form
                If combo_utype.SelectedIndex = 0 Then
                    ' If user type is "User", create an instance of the User form and show it
                    Dim userForm As New user_dashbord()
                    userForm.Show()
                Else

                    ' If user type is "Admin", create an instance of the Admin form and show it
                    Dim adminForm As New admin_dashboard()
                    adminForm.Show()
                End If

                ' Hide the current form
                Me.Hide()
            Else
                ' If no rows are returned, display an error message

                MessageBox.Show("Incorrect DETAILS!! .", "WRONG DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                ' Clear all fields
                'txt_uname.Text = ""
                txt_pwd.Text = ""
                combo_utype.SelectedItem = Nothing
            End If
        End Using





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
