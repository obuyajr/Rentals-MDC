Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class House_Renting

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub House_Renting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False"
        con.Open()

        'set textbox to UNEDITABLE STATE'''''''''''''''''''''''''''''''''''''''''''''
        txt_telno.ReadOnly = True
        txt_nok_phone.ReadOnly = True
        txt_nationality.ReadOnly = True
        txt_nok_phone.ReadOnly = True
        txt_nok_name.ReadOnly = True
        txt_email.ReadOnly = True
        txt_idno.ReadOnly = True
        txt_houseNo.ReadOnly = True
        txt_deposit.ReadOnly = True
        txt_category.ReadOnly = True
        txt_deposit.ReadOnly = True
        txt_rent.ReadOnly = True
        txt_nok_name.ReadOnly = True
        txt_status.ReadOnly = True
        txt_phone.ReadOnly = True
        txt_location.ReadOnly = True
        combo_category.DropDownStyle = ComboBoxStyle.DropDownList
        combo_location.DropDownStyle = ComboBoxStyle.DropDownList
        combo_status.DropDownStyle = ComboBoxStyle.DropDownList
        combo_tenant_name.DropDownStyle = ComboBoxStyle.DropDownList
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




        'get data to the category combobox
        ' SQL query to fetch data from the table
        Dim query As String = "SELECT DISTINCT house_type FROM category"

        ' Create a command to execute the query
        Using cmd As New SqlCommand(query, con)
            ' Execute the query and obtain a data reader
            Using reader As SqlDataReader = cmd.ExecuteReader()
                ' Clear the existing items in the ComboBox
                combo_category.Items.Clear()

                ' Iterate through the data reader and add items to the ComboBox
                While reader.Read()
                    combo_category.Items.Add(reader("house_type").ToString())
                End While
            End Using
        End Using



        'get data to the location combobox
        ' SQL query to fetch data from the table
        Dim query1 As String = "SELECT DISTINCT location FROM houses"

        ' Create a command to execute the query
        Using cmd As New SqlCommand(query1, con)
            ' Execute the query and obtain a data reader
            Using reader As SqlDataReader = cmd.ExecuteReader()
                ' Clear the existing items in the ComboBox
                combo_location.Items.Clear()

                ' Iterate through the data reader and add items to the ComboBox
                While reader.Read()
                    combo_location.Items.Add(reader("location").ToString())
                End While
            End Using
        End Using


        'get data to the status combobox
        ' SQL query to fetch data from the table
        Dim query2 As String = "SELECT DISTINCT status FROM houses"

        ' Create a command to execute the query
        Using cmd As New SqlCommand(query2, con)
            ' Execute the query and obtain a data reader
            Using reader As SqlDataReader = cmd.ExecuteReader()
                ' Clear the existing items in the ComboBox
                combo_status.Items.Clear()

                ' Iterate through the data reader and add items to the ComboBox
                While reader.Read()
                    combo_status.Items.Add(reader("status").ToString())
                End While
            End Using
        End Using

        'get data to the tenant name  combobox
        ' SQL query to fetch data from the table
        Dim query3 As String = " SELECT name FROM tenants "

        ' Create a command to execute the query
        Using cmd As New SqlCommand(query3, con)
            ' Execute the query and obtain a data reader
            Using reader As SqlDataReader = cmd.ExecuteReader()
                ' Clear the existing items in the ComboBox
                combo_tenant_name.Items.Clear()

                ' Iterate through the data reader and add items to the ComboBox
                While reader.Read()
                    combo_tenant_name.Items.Add(reader("name").ToString())
                End While
            End Using
        End Using



    End Sub













    Private Sub combo_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_category.SelectedIndexChanged
        combo_category.Text = CharacterCasing.Upper

    End Sub

    Private Sub combo_location_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_location.SelectedIndexChanged
        combo_location.Text = CharacterCasing.Upper

    End Sub

    Private Sub combo_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_status.SelectedIndexChanged
        combo_status.Text = CharacterCasing.Upper

    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click

        '' Get the selected values from the ComboBoxes
        'Dim selectedCategory As String = combo_category.SelectedItem.ToString()
        'Dim selectedLocation As String = combo_location.SelectedItem.ToString()
        'Dim selectedStatus As String = combo_status.SelectedItem.ToString()

        '' SQL query to fetch data from the table based on the selected values
        'Dim query As String = "SELECT * FROM houses WHERE category = @category AND location = @location AND status = @status"

        '' Create a command with the query and parameterize the values
        'Using cmd As New SqlCommand(query, con)
        '    cmd.Parameters.AddWithValue("@category", selectedCategory)
        '    cmd.Parameters.AddWithValue("@location", selectedLocation)
        '    cmd.Parameters.AddWithValue("@status", selectedStatus)

        '    ' Create a DataTable to store the fetched data
        '    Dim dataTable As New DataTable()

        '    ' Create a SqlDataAdapter to fill the DataTable with the query results
        '    Using adapter As New SqlDataAdapter(cmd)
        '        adapter.Fill(dataTable)

        '        ' Add the checkbox column to the DataGridView
        '        Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        '        checkBoxColumn.Name = "Select"
        '        checkBoxColumn.HeaderText = "Select"
        '        DataGridView1.Columns.Add(checkBoxColumn)

        '    End Using

        '    ' Set the DataTable as the data source for the DataGridView
        '    DataGridView1.DataSource = dataTable
        'End Using


        '
        ' Get the selected values from the ComboBoxes
        Dim selectedCategory As String = combo_category.SelectedItem.ToString()
        Dim selectedLocation As String = combo_location.SelectedItem.ToString()
        Dim selectedStatus As String = combo_status.SelectedItem.ToString()

        ' SQL query to fetch data from the table based on the selected values
        Dim query As String = "SELECT * FROM houses WHERE category = @category AND location = @location AND status = @status"

        ' Create a command with the query and parameterize the values
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@category", selectedCategory)
            cmd.Parameters.AddWithValue("@location", selectedLocation)
            cmd.Parameters.AddWithValue("@status", selectedStatus)

            ' Create a DataTable to store the fetched data
            Dim dataTable As New DataTable()

            ' Create a SqlDataAdapter to fill the DataTable with the query results
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dataTable)

                ' Add the checkbox column to the DataGridView
                Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
                checkBoxColumn.Name = "Select"
                checkBoxColumn.HeaderText = "Select"
                DataGridView1.Columns.Add(checkBoxColumn)
            End Using

            ' Set the DataTable as the data source for the DataGridView
            DataGridView1.DataSource = dataTable
        End Using
        '

    End Sub


    '
    Private Sub UpdateGrid()

        ' Get the selected values from the ComboBoxes
        Dim selectedCategory As String = combo_category.SelectedItem.ToString()
        Dim selectedLocation As String = combo_location.SelectedItem.ToString()
        Dim selectedStatus As String = combo_status.SelectedItem.ToString()

        ' SQL query to fetch data from the table based on the selected values
        Dim query As String = "SELECT * FROM houses WHERE category = @category AND location = @location AND status = @status"

        ' Create a command with the query and parameterize the values
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@category", selectedCategory)
            cmd.Parameters.AddWithValue("@location", selectedLocation)
            cmd.Parameters.AddWithValue("@status", selectedStatus)

            ' Create a DataTable to store the fetched data
            Dim dataTable As New DataTable()

            ' Create a SqlDataAdapter to fill the DataTable with the query results
            Using adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dataTable)

                ' Add the checkbox column to the DataGridView
                Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
                checkBoxColumn.Name = "Select"
                checkBoxColumn.HeaderText = "Select"
                DataGridView1.Columns.Add(checkBoxColumn)
            End Using

            ' Set the DataTable as the data source for the DataGridView
            DataGridView1.DataSource = dataTable
        End Using


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

            ' Update the room details text boxes if a room Is selected
            If selectedRow.Cells("Select").Value Then

                txt_houseNo.Text = selectedRow.Cells("house_number").Value.ToString()
                txt_location.Text = selectedRow.Cells("location").Value.ToString()
                txt_category.Text = selectedRow.Cells("category").Value.ToString()
                txt_deposit.Text = selectedRow.Cells("deposit").Value.ToString()
                txt_rent.Text = selectedRow.Cells("rent").Value.ToString()
                txt_status.Text = selectedRow.Cells("status").Value.ToString()


            Else

                ' If the checkbox is unchecked, clear the TextBox
                txt_houseNo.Text = ""
                txt_location.Text = ""
                combo_category.Text = ""
                txt_deposit.Text = ""
                txt_rent.Text = ""
                txt_status.Text = ""

            End If

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_tenant_name.SelectedIndexChanged
        '
        ' Retrieve the selected item from the ComboBox
        Dim selectedItem As String = combo_tenant_name.SelectedItem.ToString()

        ' Create a SQL query to retrieve data based on the selected item
        Dim query As String = "SELECT * FROM tenants WHERE name = @Name"

        ' Prepare the command object with the query and connection
        Using command As New SqlCommand(query, con)
            ' Add a parameter to the query for the selected item
            command.Parameters.AddWithValue("@Name", selectedItem)



            ' Execute the query and retrieve the data
            Using reader As SqlDataReader = command.ExecuteReader()
                ' Check if there are any rows returned
                If reader.HasRows Then
                    ' Read the first row (assuming you only expect one row)
                    reader.Read()

                    ' Assign the values to the textboxes

                    txt_telno.Text = reader("tel_number").ToString()
                    txt_telno.ReadOnly = True
                    txt_phone.Text = reader("phone_no").ToString()
                    txt_phone.ReadOnly = True
                    txt_nationality.Text = reader("nationality").ToString()
                    txt_nationality.ReadOnly = True
                    txt_idno.Text = reader("id_no").ToString()
                    txt_idno.ReadOnly = True
                    txt_email.Text = reader("emailaddress").ToString()
                    txt_email.ReadOnly = True
                    txt_nok_name.Text = reader("nok_name").ToString()
                    txt_nok_name.ReadOnly = True
                    txt_nok_phone.Text = reader("nok_phone").ToString()
                    txt_nok_phone.ReadOnly = True

                    ' Assign other textbox values accordingly

                    ' Close the reader
                    reader.Close()
                End If
            End Using



            combo_tenant_name.Text = CharacterCasing.Upper
        End Using

    End Sub

    Private Sub SaveRentAccount(houseNo As String, location As String, category As String, deposit As Decimal, rent As Decimal, tenantName As String, telNo As String, phoneNo As String, nationality As String, idNo As String, email As String, nokName As String, nokPhone As String)
        Dim query As String = "INSERT INTO rent (house_no, location, category, deposit, rent, tenant_name, tel_no, phone_no, nationality, ID_no, email, nok_name, nok_phone) VALUES (@HouseNo, @Location, @Category, @Deposit, @Rent, @TenantName, @TelNo, @PhoneNo, @Nationality, @IDNo, @Email, @NokName, @NokPhone)"

        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@HouseNo", houseNo)
            cmd.Parameters.AddWithValue("@Location", location)
            cmd.Parameters.AddWithValue("@Category", category)
            cmd.Parameters.AddWithValue("@Deposit", deposit)
            cmd.Parameters.AddWithValue("@Rent", rent)
            cmd.Parameters.AddWithValue("@TenantName", tenantName)
            cmd.Parameters.AddWithValue("@TelNo", telNo)
            cmd.Parameters.AddWithValue("@PhoneNo", phoneNo)
            cmd.Parameters.AddWithValue("@Nationality", nationality)
            cmd.Parameters.AddWithValue("@IDNo", idNo)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@NokName", nokName)
            cmd.Parameters.AddWithValue("@NokPhone", nokPhone)

            cmd.ExecuteNonQuery()
        End Using

        ' Update the house_status column in the houses table
        Dim updateQuery As String = "UPDATE houses SET status = 'OCCUPIED' WHERE house_number = @HouseNo"

        Using updateCmd As New SqlCommand(updateQuery, con)
            updateCmd.Parameters.AddWithValue("@HouseNo", houseNo)
            updateCmd.ExecuteNonQuery()
        End Using

        txt_houseNo.Text = ""
        txt_location.Text = ""
        txt_category.Text = ""
        txt_deposit.Text = ""
        txt_rent.Text = ""
        txt_deposit.Text = ""
        combo_tenant_name.Text = ""
        txt_telno.Text = ""
        txt_phone.Text = ""
        txt_nationality.Text = ""
        txt_idno.Text = ""
        txt_email.Text = ""
        txt_nok_name.Text = ""
        txt_nok_phone.Text = ""




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_rentHouse.Click


        '
        ' Check if the radio button is checked
        If rd_btn1.Checked Then
            ' Retrieve the data from the houses table
            Dim houseNo As String = txt_houseNo.Text
            Dim location As String = txt_location.Text
            Dim category As String = txt_category.Text
            Dim deposit As Decimal = Decimal.Parse(txt_deposit.Text)
            Dim rent As Decimal = Decimal.Parse(txt_rent.Text)
            Dim tenantName As String = combo_tenant_name.Text
            Dim telNo As String = txt_telno.Text
            Dim phoneNo As String = txt_phone.Text
            Dim nationality As String = txt_nationality.Text
            Dim idNo As String = txt_idno.Text
            Dim email As String = txt_email.Text
            Dim nokName As String = txt_nok_name.Text
            Dim nokPhone As String = txt_nok_phone.Text

            ' Multiply deposit and rent by -1 to make them negative
            deposit *= -1
            rent *= -1


            ' Save the data to the rent_accounts table
            SaveRentAccount(houseNo, location, category, deposit, rent, tenantName, telNo, phoneNo, nationality, idNo, email, nokName, nokPhone)

            MessageBox.Show("Rent account created successfully.")
            UpdateGrid()


        Else

            MessageBox.Show("Please check the box!")

        End If









    End Sub








End Class