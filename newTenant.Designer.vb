<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newTenant
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
        txt_email = New TextBox()
        txt_idNo = New TextBox()
        txt_nationality = New TextBox()
        txt_phoneNo = New TextBox()
        txt_telno = New TextBox()
        txt_name = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label10 = New Label()
        Label9 = New Label()
        txt_nok_phone = New TextBox()
        txt_nok_name = New TextBox()
        Label8 = New Label()
        Panel3 = New Panel()
        btn_addTenant = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txt_email)
        Panel1.Controls.Add(txt_idNo)
        Panel1.Controls.Add(txt_nationality)
        Panel1.Controls.Add(txt_phoneNo)
        Panel1.Controls.Add(txt_telno)
        Panel1.Controls.Add(txt_name)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 188)
        Panel1.TabIndex = 0
        ' 
        ' txt_email
        ' 
        txt_email.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_email.Location = New Point(594, 134)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(329, 28)
        txt_email.TabIndex = 12
        ' 
        ' txt_idNo
        ' 
        txt_idNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_idNo.Location = New Point(594, 91)
        txt_idNo.Name = "txt_idNo"
        txt_idNo.Size = New Size(194, 28)
        txt_idNo.TabIndex = 11
        ' 
        ' txt_nationality
        ' 
        txt_nationality.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nationality.Location = New Point(594, 37)
        txt_nationality.Name = "txt_nationality"
        txt_nationality.Size = New Size(194, 28)
        txt_nationality.TabIndex = 10
        ' 
        ' txt_phoneNo
        ' 
        txt_phoneNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_phoneNo.Location = New Point(131, 134)
        txt_phoneNo.Name = "txt_phoneNo"
        txt_phoneNo.Size = New Size(238, 28)
        txt_phoneNo.TabIndex = 9
        ' 
        ' txt_telno
        ' 
        txt_telno.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_telno.Location = New Point(131, 91)
        txt_telno.Name = "txt_telno"
        txt_telno.Size = New Size(238, 28)
        txt_telno.TabIndex = 8
        ' 
        ' txt_name
        ' 
        txt_name.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_name.Location = New Point(131, 37)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(329, 28)
        txt_name.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(497, 143)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 17)
        Label7.TabIndex = 6
        Label7.Text = "Email Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(515, 46)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 17)
        Label6.TabIndex = 5
        Label6.Text = "Nationality"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(515, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 17)
        Label5.TabIndex = 4
        Label5.Text = "ID Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(53, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 17)
        Label4.TabIndex = 3
        Label4.Text = "Phone No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(75, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 17)
        Label3.TabIndex = 2
        Label3.Text = "Tel No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(37, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 17)
        Label2.TabIndex = 1
        Label2.Text = "Tenant Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 0
        Label1.Text = "Personal Details"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txt_nok_phone)
        Panel2.Controls.Add(txt_nok_name)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(2, 277)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(940, 158)
        Panel2.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(49, 80)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 17)
        Label10.TabIndex = 11
        Label10.Text = "Phone No."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(51, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 17)
        Label9.TabIndex = 10
        Label9.Text = "Nxt of Kin"
        ' 
        ' txt_nok_phone
        ' 
        txt_nok_phone.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nok_phone.Location = New Point(131, 69)
        txt_nok_phone.Name = "txt_nok_phone"
        txt_nok_phone.Size = New Size(329, 28)
        txt_nok_phone.TabIndex = 9
        ' 
        ' txt_nok_name
        ' 
        txt_nok_name.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nok_name.Location = New Point(131, 24)
        txt_nok_name.Name = "txt_nok_name"
        txt_nok_name.Size = New Size(329, 28)
        txt_nok_name.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(3, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 20)
        Label8.TabIndex = 0
        Label8.Text = "Extra Details"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btn_addTenant)
        Panel3.Location = New Point(2, 568)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(940, 72)
        Panel3.TabIndex = 2
        ' 
        ' btn_addTenant
        ' 
        btn_addTenant.BackColor = Color.RosyBrown
        btn_addTenant.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_addTenant.Location = New Point(133, 20)
        btn_addTenant.Name = "btn_addTenant"
        btn_addTenant.Size = New Size(153, 41)
        btn_addTenant.TabIndex = 0
        btn_addTenant.Text = "Add Tenant"
        btn_addTenant.UseVisualStyleBackColor = False
        ' 
        ' newTenant
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(941, 644)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "newTenant"
        StartPosition = FormStartPosition.Manual
        Text = "newTenant"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_idNo As TextBox
    Friend WithEvents txt_nationality As TextBox
    Friend WithEvents txt_phoneNo As TextBox
    Friend WithEvents txt_telno As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nok_phone As TextBox
    Friend WithEvents txt_nok_name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_addTenant As Button
End Class
