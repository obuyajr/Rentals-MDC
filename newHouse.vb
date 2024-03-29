﻿Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class newHouse
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub newHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establish a connection to the database
        ' Set the database connection string
        con.ConnectionString =
            "Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False"


        ' Open the database connection
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        'open dB con
        con.Open()

        UpdateGrid()

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

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_houseNo.TextChanged
        txt_houseNo.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub txt_location_TextChanged(sender As Object, e As EventArgs) Handles txt_location.TextChanged
        txt_location.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub combo_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_category.SelectedIndexChanged
        combo_category.SelectedItem = CharacterCasing.Upper

    End Sub

    'btn add new house
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if any required field is empty
        If String.IsNullOrEmpty(txt_houseNo.Text) OrElse
               String.IsNullOrEmpty(txt_location.Text) OrElse
               String.IsNullOrEmpty(txt_location.Text) OrElse
               String.IsNullOrEmpty(combo_category.Text) OrElse
               String.IsNullOrEmpty(txt_location.Text) OrElse
               String.IsNullOrEmpty(txt_rent.Text) Then


            ' Display an error message if any field is empty
            MessageBox.Show("Please fill in all the required fields.", "DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method early
        Else

            ' Insert a new booking record into the bookings table
            Dim insertQuery As String = "INSERT INTO houses (house_number, location, category, deposit, rent, status) " &
                    "VALUES (@h_number, @location, @category, @deposit, @rent, @status)"

            Using insertCmd As New SqlCommand(insertQuery, con)

                insertCmd.Parameters.AddWithValue("@h_number", txt_houseNo.Text)
                insertCmd.Parameters.AddWithValue("@location", txt_location.Text)
                insertCmd.Parameters.AddWithValue("@category", combo_category.Text)
                insertCmd.Parameters.AddWithValue("@deposit", txt_deposit.Text)
                insertCmd.Parameters.AddWithValue("@rent", txt_rent.Text)
                insertCmd.Parameters.AddWithValue("@status", combo_status.Text)

                insertCmd.ExecuteNonQuery()

            End Using

            ' Show a success message
            MessageBox.Show("House Added successfully!", "House", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateGrid()
            txt_houseNo.Text = ""
            txt_location.Text = ""
            combo_category.Text = ""
            txt_deposit.Text = ""
            txt_rent.Text = ""
            combo_status.Text = ""



        End If

        '

    End Sub



    Private Sub AddCategoryOfHousesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCategoryOfHousesToolStripMenuItem.Click
        Dim categoryHouse As New House_Category()
        categoryHouse.Show()
    End Sub

    'data to Dgrid from db
    Private Sub UpdateGrid()
        ' Clear the existing data in the grid
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        ' Retrieve updated data from the database and populate the grid
        Dim query As String = "SELECT * FROM houses"

        Using adapter As New SqlDataAdapter(query, con)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            '' Add the checkbox column to the DataGridView
            'Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            'checkBoxColumn.Name = "Select"
            'checkBoxColumn.HeaderText = "Select"
            'DataGridView1.Columns.Add(checkBoxColumn)

            ' Add the remaining columns to the DataGridView
            DataGridView1.Columns.Add("house_number", "House NO.")
            DataGridView1.Columns.Add("location", " Location ")
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

                DataGridView1.Rows.Add(houseNo, location, category, deposit, rent, status)

            Next

        End Using

    End Sub
    '
End Class