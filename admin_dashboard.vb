Public Class admin_dashboard



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        Dim f1 As New Form1
        f1.Show()

    End Sub


    'switch between panels
    Sub switchPanel(panel As Form)
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.Width = intX
        Me.Height = intY - 40
        Me.Left = 0
        Me.Top = 0

        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newHouse As New newHouse()
        switchPanel(newHouse)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim editHouse As New editHouse()
        switchPanel(editHouse)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newtenant As New newTenant()
        switchPanel(newtenant)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_editTenant.Click
        Dim editTenant As New editTenant()
        switchPanel(editTenant)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim assignHouse As New House_Renting()
        switchPanel(assignHouse)
    End Sub

    Private Sub admin_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
    End Sub




End Class