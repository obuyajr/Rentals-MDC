﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editTenant
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
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(2, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(546, 516)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(522, 510)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox7)
        Panel2.Controls.Add(TextBox8)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox6)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(553, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(369, 584)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom
        Button2.BackColor = Color.RosyBrown
        Button2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(255, 533)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 32)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom
        Button1.BackColor = Color.RosyBrown
        Button1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(98, 533)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 32)
        Button1.TabIndex = 0
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(5, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 17)
        Label1.TabIndex = 2
        Label1.Text = "Tenant Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(48, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 17)
        Label2.TabIndex = 3
        Label2.Text = "Tel No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(27, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 4
        Label3.Text = "Phone No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(48, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 17)
        Label4.TabIndex = 5
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(48, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 17)
        Label5.TabIndex = 9
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(48, 253)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 17)
        Label6.TabIndex = 8
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(48, 296)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 17)
        Label7.TabIndex = 7
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(48, 338)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 17)
        Label8.TabIndex = 6
        Label8.Text = "Label8"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(129, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(229, 28)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(129, 55)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(229, 28)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(129, 153)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(229, 28)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(129, 105)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(229, 28)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(129, 242)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(229, 28)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(129, 198)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(229, 28)
        TextBox6.TabIndex = 14
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(129, 327)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(229, 28)
        TextBox7.TabIndex = 17
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(129, 285)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(229, 28)
        TextBox8.TabIndex = 16
        ' 
        ' editTenant
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(925, 605)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "editTenant"
        StartPosition = FormStartPosition.Manual
        Text = "editTenant"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
