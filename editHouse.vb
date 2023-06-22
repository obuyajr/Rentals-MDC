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
            Dim houseNumber As String = Convert.ToString(selectedRow.Cells("house_number").Value)

            Dim StrCmd As String = "UPDATE houses" &
                          " SET location = '" & txt_location.Text & "'" &
                          "   , category = '" & combo_category.SelectedItem.ToString() & "'" &
                          "   , deposit = '" & txt_deposit.Text.Trim() & "'" &
                          "   , rent = '" & txt_rent.Text.Trim() & "'" &
                          " WHERE house_number = '" & houseNumber & "'"

            cmd = New SqlCommand(StrCmd, con)

            Try
                MessageBox.Show("DETAILS EDITED SUCCESSFULLY", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cmd.Dispose()
            End Try

            ' Clear the textboxes and selection
            txt_houseNo.Text = ""
            txt_location.Text = ""
            combo_category.SelectedIndex = -1
            txt_deposit.Text = ""
            txt_rent.Text = ""

            UpdateGrid()
        End If


    End Sub
    '


End Class