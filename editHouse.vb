Imports System.Data.SqlClient

Public Class editHouse

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub editHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' Add the checkbox column to the DataGridView
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.Name = "Select"
            checkBoxColumn.HeaderText = "Select"
            DataGridView1.Columns.Add(checkBoxColumn)

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
End Class