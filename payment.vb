﻿Imports System.Threading

Public Class payment

    Public Sub SetPayment(paymentAmount As Decimal)

        ' For example, display the payment amount in a label
        lbl_amount.Text = paymentAmount.ToString()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_cash.TextChanged

        Dim enteredValue As Decimal

        If Decimal.TryParse(txt_cash.Text, enteredValue) Then

            ' Subtract the entered value from the total amount
            Dim remainingAmount As Decimal = enteredValue - lbl_amount.Text
            txt_balance.Text = remainingAmount.ToString()

        Else
            txt_balance.Text = ""
        End If

    End Sub
End Class