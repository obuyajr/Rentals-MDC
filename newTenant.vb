Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class newTenant
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub newTenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False"
        con.Open()


        txt_name.CharacterCasing = CharacterCasing.Upper
        txt_telno.CharacterCasing = CharacterCasing.Upper
        txt_phoneNo.CharacterCasing = CharacterCasing.Upper
        txt_nationality.CharacterCasing = CharacterCasing.Upper
        txt_idNo.CharacterCasing = CharacterCasing.Upper
        txt_email.CharacterCasing = CharacterCasing.Upper
        txt_nok_name.CharacterCasing = CharacterCasing.Upper
        txt_nok_phone.CharacterCasing = CharacterCasing.Upper



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_addTenant.Click

        ' Check if any required field is empty
        If String.IsNullOrEmpty(txt_name.Text) OrElse
                String.IsNullOrEmpty(txt_telno.Text) OrElse
                String.IsNullOrEmpty(txt_phoneNo.Text) OrElse
                String.IsNullOrEmpty(txt_idNo.Text) OrElse
                String.IsNullOrEmpty(txt_email.Text) OrElse
                String.IsNullOrEmpty(txt_nok_name.Text) OrElse
           String.IsNullOrEmpty(txt_nok_phone.Text) Then

            ' Display an error message if any field is empty
            MessageBox.Show("Please fill in all the required fields.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the method early

        End If

        '
        ' Insert a new booking record into the bookings table
        Dim insertQuery As String = "INSERT INTO tenants (name, tel_number, phone_no, nationality, id_no, emailaddress, nok_name, nok_phone) " &
                "VALUES (@name, @telno, @phone, @nationality, @id_no, @email, @nok_name, @nok_phone)"

        Using insertCmd As New SqlCommand(insertQuery, con)

            insertCmd.Parameters.AddWithValue("@name", txt_name.Text)
            insertCmd.Parameters.AddWithValue("@telno", txt_telno.Text)
            insertCmd.Parameters.AddWithValue("@phone", txt_phoneNo.Text)
            insertCmd.Parameters.AddWithValue("@nationality", txt_nationality.Text)
            insertCmd.Parameters.AddWithValue("@id_no", txt_idNo.Text)
            insertCmd.Parameters.AddWithValue("@email", txt_email.Text)
            insertCmd.Parameters.AddWithValue("@nok_name", txt_nok_name.Text)
            insertCmd.Parameters.AddWithValue("@nok_phone", txt_nok_phone.Text)

            insertCmd.ExecuteNonQuery()

        End Using

        ' Show a success message for the booking
        MessageBox.Show("Tenant Added Successfully!!!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ' Clear the input fields and update the grid
        txt_name.Text = ""
        txt_idNo.Text = ""
        txt_email.Text = ""
        txt_nationality.Text = ""
        txt_nok_name.Text = ""
        txt_nok_phone.Text = ""
        txt_telno.Text = ""
        txt_phoneNo.Text = ""



    End Sub
End Class