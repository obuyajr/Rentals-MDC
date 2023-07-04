<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        txt_nok_phone = New TextBox()
        txt_nok_name = New TextBox()
        txt_email = New TextBox()
        txt_idNo = New TextBox()
        txt_nationality = New TextBox()
        txt_phone = New TextBox()
        txt_telNo = New TextBox()
        txt_tenantName = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        txt_searchbox = New TextBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(2, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(596, 603)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(9, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(571, 597)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Panel2.BackColor = Color.PeachPuff
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(txt_nok_phone)
        Panel2.Controls.Add(txt_nok_name)
        Panel2.Controls.Add(txt_email)
        Panel2.Controls.Add(txt_idNo)
        Panel2.Controls.Add(txt_nationality)
        Panel2.Controls.Add(txt_phone)
        Panel2.Controls.Add(txt_telNo)
        Panel2.Controls.Add(txt_tenantName)
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
        Panel2.Location = New Point(639, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(396, 540)
        Panel2.TabIndex = 1
        ' 
        ' txt_nok_phone
        ' 
        txt_nok_phone.BackColor = Color.White
        txt_nok_phone.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nok_phone.Location = New Point(129, 402)
        txt_nok_phone.Name = "txt_nok_phone"
        txt_nok_phone.Size = New Size(229, 28)
        txt_nok_phone.TabIndex = 17
        ' 
        ' txt_nok_name
        ' 
        txt_nok_name.BackColor = Color.White
        txt_nok_name.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nok_name.Location = New Point(129, 360)
        txt_nok_name.Name = "txt_nok_name"
        txt_nok_name.Size = New Size(229, 28)
        txt_nok_name.TabIndex = 16
        ' 
        ' txt_email
        ' 
        txt_email.BackColor = Color.White
        txt_email.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_email.Location = New Point(129, 317)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(229, 28)
        txt_email.TabIndex = 15
        ' 
        ' txt_idNo
        ' 
        txt_idNo.BackColor = Color.White
        txt_idNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_idNo.Location = New Point(129, 273)
        txt_idNo.Name = "txt_idNo"
        txt_idNo.Size = New Size(229, 28)
        txt_idNo.TabIndex = 14
        ' 
        ' txt_nationality
        ' 
        txt_nationality.BackColor = Color.White
        txt_nationality.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nationality.Location = New Point(129, 228)
        txt_nationality.Name = "txt_nationality"
        txt_nationality.Size = New Size(229, 28)
        txt_nationality.TabIndex = 13
        ' 
        ' txt_phone
        ' 
        txt_phone.BackColor = Color.White
        txt_phone.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_phone.Location = New Point(129, 180)
        txt_phone.Name = "txt_phone"
        txt_phone.Size = New Size(229, 28)
        txt_phone.TabIndex = 12
        ' 
        ' txt_telNo
        ' 
        txt_telNo.BackColor = Color.White
        txt_telNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_telNo.Location = New Point(129, 130)
        txt_telNo.Name = "txt_telNo"
        txt_telNo.Size = New Size(229, 28)
        txt_telNo.TabIndex = 11
        ' 
        ' txt_tenantName
        ' 
        txt_tenantName.BackColor = Color.White
        txt_tenantName.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_tenantName.Location = New Point(129, 79)
        txt_tenantName.Name = "txt_tenantName"
        txt_tenantName.Size = New Size(229, 28)
        txt_tenantName.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(48, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 17)
        Label5.TabIndex = 9
        Label5.Text = "ID No."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(48, 328)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 17)
        Label6.TabIndex = 8
        Label6.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(10, 371)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 17)
        Label7.TabIndex = 7
        Label7.Text = "N.O.K Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(7, 413)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 17)
        Label8.TabIndex = 6
        Label8.Text = "N.O.K Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(19, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 17)
        Label4.TabIndex = 5
        Label4.Text = "Nationality"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(27, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 4
        Label3.Text = "Phone No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(48, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 17)
        Label2.TabIndex = 3
        Label2.Text = "Tel No."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(5, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 17)
        Label1.TabIndex = 2
        Label1.Text = "Tenant Name"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom
        Button2.BackColor = Color.RosyBrown
        Button2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(269, 489)
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
        Button1.Location = New Point(112, 489)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 32)
        Button1.TabIndex = 0
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txt_searchbox
        ' 
        txt_searchbox.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txt_searchbox.Location = New Point(114, 33)
        txt_searchbox.Name = "txt_searchbox"
        txt_searchbox.Size = New Size(445, 29)
        txt_searchbox.TabIndex = 3
        ' 
        ' editTenant
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1047, 692)
        Controls.Add(txt_searchbox)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "editTenant"
        ShowIcon = False
        StartPosition = FormStartPosition.Manual
        Text = "Edit Tenant"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents txt_nok_phone As TextBox
    Friend WithEvents txt_nok_name As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_idNo As TextBox
    Friend WithEvents txt_nationality As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_telNo As TextBox
    Friend WithEvents txt_tenantName As TextBox
    Friend WithEvents txt_searchbox As TextBox
End Class
