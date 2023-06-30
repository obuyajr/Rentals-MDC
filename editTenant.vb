Imports System.Data.SqlClient

Public Class editTenant
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub editTenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False"

        UpdateGrid()
        ' Open the database connection
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        'open dB con
        con.Open()



        'make the textboxes read only
        txt_idNo.ReadOnly = True




    End Sub


    Private Sub UpdateGrid()
        ' Clear the existing data in the grid
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Retrieve updated data from the database and populate the grid
        Dim query As String = "SELECT * FROM tenants"


        Using adapter As New SqlDataAdapter(query, con)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Add the checkbox column to the DataGridView
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.Name = "Select"
            checkBoxColumn.HeaderText = "Select"
            DataGridView1.Columns.Add(checkBoxColumn)

            ' Add the remaining columns to the DataGridView
            DataGridView1.Columns.Add("tenant_id", "Tenant ID")
            DataGridView1.Columns.Add("name", "Name")
            DataGridView1.Columns.Add("tel_number", "Tel #")
            DataGridView1.Columns.Add("phone_no", "Phone #")
            DataGridView1.Columns.Add("nationality", "Nationality")
            DataGridView1.Columns.Add("id_no", "ID #")
            DataGridView1.Columns.Add("emailaddress", "Email")
            DataGridView1.Columns.Add("nok_name", "NOK Name")
            DataGridView1.Columns.Add("nok_phone", "NOK Phone")

            ' Populate the grid with the retrieved data
            For Each row As DataRow In dataTable.Rows
                Dim tenantID As String = row("tenant_id").ToString()
                Dim name As String = row("name").ToString()
                Dim TelNo As String = row("tel_number").ToString()
                Dim PhoneNo As String = row("phone_no").ToString()
                Dim nationality As String = row("nationality").ToString()
                Dim idNo As String = row("id_no").ToString()
                Dim email As String = row("emailaddress").ToString()
                Dim nokName As String = row("nok_name").ToString()
                Dim nokPhone As String = row("nok_phone").ToString()

                DataGridView1.Rows.Add(False, tenantID, name, TelNo, PhoneNo, nationality, idNo, email, nokName, nokPhone)
            Next
        End Using

        ' Attach the CellContentClick event handler to the DataGridView
        'AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick
    End Sub


    '
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        ' Handle the click event in the DataGridView cells
        If e.ColumnIndex = DataGridView1.Columns("Select").Index AndAlso e.RowIndex >= 0 Then

            ' Uncheck all other checkboxes
            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.Index <> e.RowIndex AndAlso Convert.ToBoolean(row.Cells("Select").Value) Then

                    row.Cells("Select").Value = False

                End If

            Next

            ' Update the selected row's checkbox value
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim isSelected As Boolean = Convert.ToBoolean(selectedRow.Cells("Select").Value)
            selectedRow.Cells("Select").Value = Not isSelected

            ' Update the room details text boxes if a room is selected
            If selectedRow.Cells("Select").Value Then

                txt_tenantName.Text = selectedRow.Cells("name").Value.ToString()
                txt_telNo.Text = selectedRow.Cells("tel_number").Value.ToString()
                txt_phone.Text = selectedRow.Cells("phone_no").Value.ToString()

                txt_nationality.Text = selectedRow.Cells("nationality").Value.ToString()
                txt_idNo.Text = selectedRow.Cells("id_no").Value.ToString()
                txt_email.Text = selectedRow.Cells("emailaddress").Value.ToString()
                txt_nok_name.Text = selectedRow.Cells("nok_name").Value.ToString()
                txt_nok_phone.Text = selectedRow.Cells("nok_phone").Value.ToString()



            Else

                ' If the checkbox is unchecked, clear the TextBox
                txt_tenantName.Text = ""
                txt_telNo.Text = ""
                txt_phone.Text = ""
                txt_nationality.Text = ""
                txt_idNo.Text = ""
                txt_email.Text = ""
                txt_nok_name.Text = ""
                txt_nok_phone.Text = ""

            End If

        End If

    End Sub
    '

    Private Sub txt_searchbox_TextChanged(sender As Object, e As EventArgs) Handles txt_searchbox.TextChanged

        txt_searchbox.CharacterCasing = CharacterCasing.Upper

        ' Clear the existing data in the grid
        DataGridView1.Rows.Clear()

        ' Retrieve the search keyword from the text box
        Dim searchKeyword As String = txt_searchbox.Text.Trim()

        ' Construct the query to search for matching records
        Dim query As String = "SELECT * FROM tenants WHERE name LIKE '%' + @keyword + '%'" ' Assuming you want to search by the 'name' field

        Using adapter As New SqlDataAdapter(query, con)
            adapter.SelectCommand.Parameters.AddWithValue("@keyword", searchKeyword)

            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Populate the grid with the retrieved data
            For Each row As DataRow In dataTable.Rows
                Dim tenantID As String = row("tenant_id").ToString()
                Dim name As String = row("name").ToString()
                Dim TelNo As String = row("tel_number").ToString()
                Dim PhoneNo As String = row("phone_no").ToString()
                Dim nationality As String = row("nationality").ToString()
                Dim idNo As String = row("id_no").ToString()
                Dim email As String = row("emailaddress").ToString()
                Dim nokName As String = row("nok_name").ToString()
                Dim nokPhone As String = row("nok_phone").ToString()

                DataGridView1.Rows.Add(False, tenantID, name, TelNo, PhoneNo, nationality, idNo, email, nokName, nokPhone)
            Next
        End Using

    End Sub

    Private Sub txt_tenantName_TextChanged(sender As Object, e As EventArgs) Handles txt_tenantName.TextChanged
        txt_tenantName.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub txt_nationality_TextChanged(sender As Object, e As EventArgs) Handles txt_nationality.TextChanged
        txt_nationality.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub txt_nok_name_TextChanged(sender As Object, e As EventArgs) Handles txt_nok_name.TextChanged
        txt_nok_name.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Retrieve the selected row
        Dim selectedRow As DataGridViewRow = Nothing

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Convert.ToBoolean(row.Cells("Select").Value) Then
                selectedRow = row
                Exit For
            End If
        Next

        ' Update the corresponding record in the database
        If selectedRow IsNot Nothing Then
            Dim tenantID As String = Convert.ToString(selectedRow.Cells("tenant_id").Value)



            ' Update the record using a parameterized query
            Dim query As String = "UPDATE tenants SET name = @name, tel_number = @tel_number, phone_no = @phoneNo,
                                                             nationality = @nationality, id_no = @idNo,
                                                             emailaddress = @email, nok_name = @nok_name,
                                                             nok_phone = @nok_phone WHERE tenant_id = @tenantId"

            Dim cmd As SqlCommand = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", txt_tenantName.Text)
            cmd.Parameters.AddWithValue("@tel_number", txt_telNo.Text)
            cmd.Parameters.AddWithValue("@phoneNo", txt_phone.Text)
            cmd.Parameters.AddWithValue("@nationality", txt_nationality.Text)
            cmd.Parameters.AddWithValue("@idNo", txt_idNo.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@nok_name", txt_nok_name.Text)
            cmd.Parameters.AddWithValue("@nok_phone", txt_nok_phone.Text)
            cmd.Parameters.AddWithValue("@tenantId", tenantID)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("TENANT DETAILS EDITED SUCCESSFULLY")

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            Finally

                'con.Close()
                cmd.Dispose()
            End Try

            ' Clear the textboxes and selection
            txt_nok_name.Text = ""
            txt_nationality.Text = ""
            txt_idNo.Text = ""
            txt_nok_phone.Text = ""
            txt_phone.Text = ""
            txt_email.Text = ""
            txt_telNo.Text = ""
            txt_tenantName.Text = ""
            txt_searchbox.Text = ""

            ' Refresh the grid
            UpdateGrid()
        Else
            MessageBox.Show("No Tenant selected.")
        End If




    End Sub
End Class