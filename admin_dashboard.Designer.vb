﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        lbl_uname = New Label()
        Button9 = New Button()
        Button5 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button1 = New Button()
        Button6 = New Button()
        btn_editTenant = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        btn_billHouse = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Indigo
        Panel1.Controls.Add(btn_billHouse)
        Panel1.Controls.Add(lbl_uname)
        Panel1.Controls.Add(Button9)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(btn_editTenant)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(142, 616)
        Panel1.TabIndex = 0
        ' 
        ' lbl_uname
        ' 
        lbl_uname.AutoSize = True
        lbl_uname.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_uname.ForeColor = Color.Yellow
        lbl_uname.Location = New Point(42, 56)
        lbl_uname.Name = "lbl_uname"
        lbl_uname.Size = New Size(71, 17)
        lbl_uname.TabIndex = 11
        lbl_uname.Text = "Username"
        ' 
        ' Button9
        ' 
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Image = My.Resources.Resources.user_circle_solid_48
        Button9.Location = New Point(5, 3)
        Button9.Name = "Button9"
        Button9.Size = New Size(134, 50)
        Button9.TabIndex = 10
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 467)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 9
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button8.FlatAppearance.BorderColor = Color.Indigo
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.ForeColor = Color.White
        Button8.Image = My.Resources.Resources.report_solid_24__1_
        Button8.ImageAlign = ContentAlignment.MiddleRight
        Button8.Location = New Point(5, 507)
        Button8.Name = "Button8"
        Button8.Size = New Size(131, 40)
        Button8.TabIndex = 8
        Button8.Text = "Reports"
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.FlatAppearance.BorderColor = Color.Indigo
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = Color.White
        Button7.Image = My.Resources.Resources.reset_regular_24
        Button7.ImageAlign = ContentAlignment.MiddleRight
        Button7.Location = New Point(5, 328)
        Button7.Name = "Button7"
        Button7.Size = New Size(131, 40)
        Button7.TabIndex = 7
        Button7.Text = "Reset House"
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.FlatAppearance.BorderColor = Color.Indigo
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.close
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(5, 564)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 40)
        Button1.TabIndex = 6
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatAppearance.BorderColor = Color.Indigo
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Image = My.Resources.Resources.category_alt_solid_24
        Button6.ImageAlign = ContentAlignment.MiddleRight
        Button6.Location = New Point(5, 278)
        Button6.Name = "Button6"
        Button6.Size = New Size(131, 40)
        Button6.TabIndex = 5
        Button6.Text = "Assign Hse."
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = True
        ' 
        ' btn_editTenant
        ' 
        btn_editTenant.FlatAppearance.BorderColor = Color.Indigo
        btn_editTenant.FlatStyle = FlatStyle.Flat
        btn_editTenant.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_editTenant.ForeColor = Color.White
        btn_editTenant.Image = My.Resources.Resources.edit_regular_24
        btn_editTenant.ImageAlign = ContentAlignment.MiddleRight
        btn_editTenant.Location = New Point(5, 232)
        btn_editTenant.Name = "btn_editTenant"
        btn_editTenant.Size = New Size(128, 40)
        btn_editTenant.TabIndex = 4
        btn_editTenant.Text = "Edit Tenant"
        btn_editTenant.TextAlign = ContentAlignment.MiddleLeft
        btn_editTenant.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderColor = Color.Indigo
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Image = My.Resources.Resources.user_plus_regular_24
        Button4.ImageAlign = ContentAlignment.MiddleRight
        Button4.Location = New Point(5, 186)
        Button4.Name = "Button4"
        Button4.Size = New Size(128, 40)
        Button4.TabIndex = 3
        Button4.Text = "New Tenant"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderColor = Color.Indigo
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Image = My.Resources.Resources.edit_alt_solid_24__1_
        Button3.ImageAlign = ContentAlignment.MiddleRight
        Button3.Location = New Point(5, 140)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 40)
        Button3.TabIndex = 2
        Button3.Text = "Edit House"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.Indigo
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.building_house_solid_24
        Button2.ImageAlign = ContentAlignment.MiddleRight
        Button2.Location = New Point(5, 101)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 40)
        Button2.TabIndex = 1
        Button2.Text = "New House"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(888, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(0, 616)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BackgroundImage = My.Resources.Resources.download__1_
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(142, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(746, 616)
        Panel3.TabIndex = 2
        ' 
        ' btn_billHouse
        ' 
        btn_billHouse.FlatAppearance.BorderColor = Color.Indigo
        btn_billHouse.FlatStyle = FlatStyle.Flat
        btn_billHouse.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_billHouse.ForeColor = Color.White
        btn_billHouse.Image = My.Resources.Resources.reset_regular_24
        btn_billHouse.ImageAlign = ContentAlignment.MiddleRight
        btn_billHouse.Location = New Point(8, 374)
        btn_billHouse.Name = "btn_billHouse"
        btn_billHouse.Size = New Size(131, 40)
        btn_billHouse.TabIndex = 12
        btn_billHouse.Text = "Bill House"
        btn_billHouse.TextAlign = ContentAlignment.MiddleLeft
        btn_billHouse.UseVisualStyleBackColor = True
        ' 
        ' admin_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(888, 616)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "admin_dashboard"
        StartPosition = FormStartPosition.Manual
        Text = "admin_dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents btn_editTenant As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents lbl_uname As Label
    Friend WithEvents btn_billHouse As Button
End Class
