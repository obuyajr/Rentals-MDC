Imports System.Data.SqlClient

Public Class editTenant
    Dim con As SqlConnection
    Dim cmd As SqlCommand

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

End Class