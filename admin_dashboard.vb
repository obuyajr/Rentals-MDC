Public Class admin_dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        Dim f1 As New Form1
        f1.Show()

    End Sub


    'switch between panels
    Sub switchPanel(panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newHouse As New newHouse()
        switchPanel(newHouse)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newHouse As New editHouse()
        switchPanel(editHouse)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub
End Class