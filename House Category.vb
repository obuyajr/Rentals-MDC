Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class House_Category

    Dim con As New SqlConnection()
    Dim cmd As New SqlCommand

    Private Sub House_Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the database connection string
        con.ConnectionString =
            "Data Source=DESKTOP-KCVKSCU;Initial Catalog=rentals;Integrated Security=True;Pooling=False"


        ' Open the database connection
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        'open dB con
        con.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_addCategory.Click


        ' Check if field is empty or not
        If Not String.IsNullOrEmpty(txt_category.Text) Then
            Try
                ' insert room category to the table

                Using insertCmd As New SqlCommand("INSERT INTO category (house_type) VALUES (@category)", con)
                    insertCmd.Parameters.AddWithValue("@category", txt_category.Text)
                    insertCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("category added successfully!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_category.Text = ""
                Me.Close()

            Catch ex As Exception

                MessageBox.Show("Entry already exists!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                txt_category.Text = ""
            End Try

        End If

    End Sub

    Private Sub txt_category_TextChanged(sender As Object, e As EventArgs) Handles txt_category.TextChanged
        txt_category.CharacterCasing = CharacterCasing.Upper

    End Sub
End Class