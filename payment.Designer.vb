﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label4 = New Label()
        btn_print = New Button()
        TextBox2 = New TextBox()
        Label3 = New Label()
        txt_cash = New TextBox()
        Label2 = New Label()
        lbl_amount = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSalmon
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btn_print)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txt_cash)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lbl_amount)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(392, 449)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(309, 330)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 21)
        Label4.TabIndex = 7
        ' 
        ' btn_print
        ' 
        btn_print.BackColor = Color.PaleTurquoise
        btn_print.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_print.ForeColor = Color.Black
        btn_print.Image = My.Resources.Resources.printer_solid_24
        btn_print.ImageAlign = ContentAlignment.MiddleRight
        btn_print.Location = New Point(155, 388)
        btn_print.Name = "btn_print"
        btn_print.Size = New Size(167, 41)
        btn_print.TabIndex = 6
        btn_print.Text = "Print Receipt"
        btn_print.TextAlign = ContentAlignment.MiddleLeft
        btn_print.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(155, 140)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(135, 33)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(3, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 21)
        Label3.TabIndex = 4
        Label3.Text = "M/Money ( F2 )"
        ' 
        ' txt_cash
        ' 
        txt_cash.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_cash.Location = New Point(155, 83)
        txt_cash.Name = "txt_cash"
        txt_cash.Size = New Size(135, 33)
        txt_cash.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(92, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 21)
        Label2.TabIndex = 2
        Label2.Text = "Ksh."
        ' 
        ' lbl_amount
        ' 
        lbl_amount.AutoSize = True
        lbl_amount.Font = New Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_amount.ForeColor = Color.Yellow
        lbl_amount.Location = New Point(234, 13)
        lbl_amount.Name = "lbl_amount"
        lbl_amount.Size = New Size(113, 40)
        lbl_amount.TabIndex = 1
        lbl_amount.Text = "TOTAL"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 37)
        Label1.TabIndex = 0
        Label1.Text = "Amount Due."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(155, 344)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 8
        Label5.Text = "Loose Change:"
        ' 
        ' payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 473)
        Controls.Add(Panel1)
        Name = "payment"
        Text = "payment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_amount As Label
    Friend WithEvents txt_cash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
