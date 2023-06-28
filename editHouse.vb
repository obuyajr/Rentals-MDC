Imports System.Data.SqlClient

Public Class editHouse

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub editHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Establish a connection to the database
        ' Set the database connection string
        con.ConnectionString =
            "Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False"

        UpdateGrid()
        ' Open the database connection
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        'open dB con
        con.Open()


        ' SQL query to fetch data from the category table
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


        'make the textboxes read only
        txt_houseNo.ReadOnly = True
        txt_location.ReadOnly = True



    End Sub

    Private Sub UpdateGrid()
        ' Clear the existing data in the grid
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Retrieve updated data from the database and populate the grid
        Dim query As String = "SELECT * FROM houses"

        Using con As New SqlConnection("Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False")
            con.Open()

            Using adapter As New SqlDataAdapter(query, con)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                ' Add the checkbox column to the DataGridView
                Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
                checkBoxColumn.Name = "Select"
                checkBoxColumn.HeaderText = "Select"
                DataGridView1.Columns.Add(checkBoxColumn)

                ' Add the remaining columns to the DataGridView
                DataGridView1.Columns.Add("house_number", "House No.")
                DataGridView1.Columns.Add("location", "Location")
                DataGridView1.Columns.Add("category", "Category")
                DataGridView1.Columns.Add("deposit", "Deposit")
                DataGridView1.Columns.Add("rent", "Rent")
                DataGridView1.Columns.Add("status", "Status")

                ' Populate the grid with the retrieved data
                For Each row As DataRow In dataTable.Rows
                    Dim houseNo As String = row("house_number").ToString()
                    Dim location As String = row("location").ToString()
                    Dim category As String = row("category").ToString()
                    Dim deposit As String = row("deposit").ToString()
                    Dim rent As String = row("rent").ToString()
                    Dim status As String = row("status").ToString()

                    DataGridView1.Rows.Add(False, houseNo, location, category, deposit, rent, status)
                Next
            End Using
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

                txt_houseNo.Text = selectedRow.Cells("house_number").Value.ToString()
                txt_location.Text = selectedRow.Cells("location").Value.ToString()
                combo_category.Text = selectedRow.Cells("category").Value.ToString()

                txt_deposit.Text = selectedRow.Cells("deposit").Value.ToString()
                txt_rent.Text = selectedRow.Cells("rent").Value.ToString()
                txtStatus.Text = selectedRow.Cells("status").Value.ToString()


            Else

                ' If the checkbox is unchecked, clear the TextBox
                txt_houseNo.Text = ""
                txt_location.Text = ""
                combo_category.Text = ""
                txt_deposit.Text = ""
                txt_rent.Text = ""

            End If

        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

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
            Dim houseNo As String = Convert.ToString(selectedRow.Cells("house_number").Value)

            ' Open the database connection
            'con.Open()

            ' Update the record using a parameterized query
            Dim query As String = "UPDATE houses SET location = @location, category = @category, deposit = @deposit, rent = @rent, status = @status WHERE house_number = @house_number"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@location", txt_location.Text)
            cmd.Parameters.AddWithValue("@category", combo_category.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@deposit", txt_deposit.Text)
            cmd.Parameters.AddWithValue("@rent", txt_rent.Text)
            cmd.Parameters.AddWithValue("@status", txtStatus.Text)
            cmd.Parameters.AddWithValue("@house_number", houseNo)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("HOUSE DETAILS EDITED SUCCESSFULLY")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally

            End Try

            cmd.Dispose()

            ' Clear the textboxes and selection
            txt_houseNo.Text = ""
            txt_location.Text = ""
            combo_category.SelectedItem = Nothing
            txt_deposit.Text = ""
            txt_rent.Text = ""
            txtStatus.Text = ""

            ' Refresh the grid
            UpdateGrid()
        Else
            MessageBox.Show("No house selected.")
        End If





    End Sub
    '


End Class