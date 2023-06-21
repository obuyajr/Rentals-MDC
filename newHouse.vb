Public Class newHouse


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

    End Sub

    Private Sub newHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddCategoryOfHousesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCategoryOfHousesToolStripMenuItem.Click
        Dim categoryHouse As New House_Category()
        categoryHouse.Show()
    End Sub
End Class