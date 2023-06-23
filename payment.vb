Imports System.Threading

Public Class payment



    Private Shared formInstance As payment = Nothing

    Public Sub New()
        ' Check if an instance of the form is already open
        If formInstance IsNot Nothing AndAlso Not formInstance.IsDisposed Then
            ' Another instance is already open, focus on the existing instance and close this instance
            formInstance.Focus()
            Close()
        Else
            ' Set the current instance as the active instance
            formInstance = Me
            InitializeComponent()
        End If
    End Sub

End Class