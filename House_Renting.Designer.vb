<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class House_Renting
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
        combo_status = New ComboBox()
        Label4 = New Label()
        btn_generate = New Button()
        combo_location = New ComboBox()
        combo_category = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        Panel6 = New Panel()
        Button2 = New Button()
        btn_rentHouse = New Button()
        Panel4 = New Panel()
        txt_status = New TextBox()
        txt_rent = New TextBox()
        txt_deposit = New TextBox()
        txt_category = New TextBox()
        txt_location = New TextBox()
        txt_houseNo = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel5 = New Panel()
        Label18 = New Label()
        rd_btn1 = New RadioButton()
        txt_nok_phone = New TextBox()
        Label17 = New Label()
        combo_tenant_name = New ComboBox()
        txt_nationality = New TextBox()
        txt_nok_name = New TextBox()
        txt_phone = New TextBox()
        Label19 = New Label()
        txt_telno = New TextBox()
        Label13 = New Label()
        Label11 = New Label()
        txt_email = New TextBox()
        Label12 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        txt_idno = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(combo_status)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btn_generate)
        Panel1.Controls.Add(combo_location)
        Panel1.Controls.Add(combo_category)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(808, 139)
        Panel1.TabIndex = 0
        ' 
        ' combo_status
        ' 
        combo_status.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        combo_status.FormattingEnabled = True
        combo_status.Location = New Point(90, 94)
        combo_status.Name = "combo_status"
        combo_status.Size = New Size(191, 28)
        combo_status.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(34, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 17)
        Label4.TabIndex = 6
        Label4.Text = "Status"
        ' 
        ' btn_generate
        ' 
        btn_generate.BackColor = Color.MistyRose
        btn_generate.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_generate.Location = New Point(322, 59)
        btn_generate.Name = "btn_generate"
        btn_generate.Size = New Size(95, 38)
        btn_generate.TabIndex = 5
        btn_generate.Text = "Generate"
        btn_generate.UseVisualStyleBackColor = False
        ' 
        ' combo_location
        ' 
        combo_location.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        combo_location.FormattingEnabled = True
        combo_location.Location = New Point(90, 64)
        combo_location.Name = "combo_location"
        combo_location.Size = New Size(191, 28)
        combo_location.TabIndex = 4
        ' 
        ' combo_category
        ' 
        combo_category.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        combo_category.FormattingEnabled = True
        combo_category.Location = New Point(90, 35)
        combo_category.Name = "combo_category"
        combo_category.Size = New Size(191, 28)
        combo_category.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(19, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 17)
        Label3.TabIndex = 2
        Label3.Text = "Location"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(19, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 1
        Label2.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 20)
        Label1.TabIndex = 0
        Label1.Text = "Selection Criteria"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(12, 180)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(808, 460)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridView1.BackgroundColor = Color.WhiteSmoke
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-1, 19)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(815, 436)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Panel5)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(850, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(487, 644)
        Panel3.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Button2)
        Panel6.Controls.Add(btn_rentHouse)
        Panel6.Location = New Point(9, 544)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(464, 60)
        Panel6.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(323, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 35)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btn_rentHouse
        ' 
        btn_rentHouse.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_rentHouse.Location = New Point(106, 12)
        btn_rentHouse.Name = "btn_rentHouse"
        btn_rentHouse.Size = New Size(127, 35)
        btn_rentHouse.TabIndex = 0
        btn_rentHouse.Text = "Rent House"
        btn_rentHouse.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.PeachPuff
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(txt_status)
        Panel4.Controls.Add(txt_rent)
        Panel4.Controls.Add(txt_deposit)
        Panel4.Controls.Add(txt_category)
        Panel4.Controls.Add(txt_location)
        Panel4.Controls.Add(txt_houseNo)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label5)
        Panel4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Panel4.Location = New Point(3, 10)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(476, 129)
        Panel4.TabIndex = 1
        ' 
        ' txt_status
        ' 
        txt_status.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_status.Location = New Point(300, 81)
        txt_status.Name = "txt_status"
        txt_status.Size = New Size(100, 25)
        txt_status.TabIndex = 11
        ' 
        ' txt_rent
        ' 
        txt_rent.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rent.Location = New Point(300, 48)
        txt_rent.Name = "txt_rent"
        txt_rent.Size = New Size(100, 25)
        txt_rent.TabIndex = 10
        ' 
        ' txt_deposit
        ' 
        txt_deposit.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_deposit.Location = New Point(300, 14)
        txt_deposit.Name = "txt_deposit"
        txt_deposit.Size = New Size(100, 25)
        txt_deposit.TabIndex = 9
        ' 
        ' txt_category
        ' 
        txt_category.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_category.Location = New Point(111, 81)
        txt_category.Name = "txt_category"
        txt_category.Size = New Size(100, 25)
        txt_category.TabIndex = 8
        ' 
        ' txt_location
        ' 
        txt_location.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_location.Location = New Point(111, 49)
        txt_location.Name = "txt_location"
        txt_location.Size = New Size(100, 25)
        txt_location.TabIndex = 7
        ' 
        ' txt_houseNo
        ' 
        txt_houseNo.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_houseNo.Location = New Point(111, 14)
        txt_houseNo.Name = "txt_houseNo"
        txt_houseNo.Size = New Size(100, 25)
        txt_houseNo.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(245, 89)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 17)
        Label10.TabIndex = 5
        Label10.Text = "Status"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(254, 57)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 17)
        Label9.TabIndex = 4
        Label9.Text = "Rent"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(235, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 17)
        Label8.TabIndex = 3
        Label8.Text = "Deposit"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(30, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 17)
        Label7.TabIndex = 2
        Label7.Text = "Category"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(30, 56)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 17)
        Label6.TabIndex = 1
        Label6.Text = "Location"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(20, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 17)
        Label5.TabIndex = 0
        Label5.Text = "House No."
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.PeachPuff
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Label18)
        Panel5.Controls.Add(rd_btn1)
        Panel5.Controls.Add(txt_nok_phone)
        Panel5.Controls.Add(Label17)
        Panel5.Controls.Add(combo_tenant_name)
        Panel5.Controls.Add(txt_nationality)
        Panel5.Controls.Add(txt_nok_name)
        Panel5.Controls.Add(txt_phone)
        Panel5.Controls.Add(Label19)
        Panel5.Controls.Add(txt_telno)
        Panel5.Controls.Add(Label13)
        Panel5.Controls.Add(Label11)
        Panel5.Controls.Add(txt_email)
        Panel5.Controls.Add(Label12)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(Label15)
        Panel5.Controls.Add(Label16)
        Panel5.Controls.Add(txt_idno)
        Panel5.Location = New Point(3, 145)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(476, 359)
        Panel5.TabIndex = 2
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(4, 320)
        Label18.Name = "Label18"
        Label18.Size = New Size(87, 17)
        Label18.TabIndex = 20
        Label18.Text = "Init. Renting"
        ' 
        ' rd_btn1
        ' 
        rd_btn1.AutoSize = True
        rd_btn1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        rd_btn1.Location = New Point(111, 322)
        rd_btn1.Name = "rd_btn1"
        rd_btn1.Size = New Size(14, 13)
        rd_btn1.TabIndex = 19
        rd_btn1.TabStop = True
        rd_btn1.UseVisualStyleBackColor = True
        ' 
        ' txt_nok_phone
        ' 
        txt_nok_phone.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nok_phone.Location = New Point(111, 282)
        txt_nok_phone.Name = "txt_nok_phone"
        txt_nok_phone.Size = New Size(227, 25)
        txt_nok_phone.TabIndex = 18
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(4, 290)
        Label17.Name = "Label17"
        Label17.Size = New Size(90, 17)
        Label17.TabIndex = 17
        Label17.Text = "N.O.K Phone"
        ' 
        ' combo_tenant_name
        ' 
        combo_tenant_name.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        combo_tenant_name.FormattingEnabled = True
        combo_tenant_name.Location = New Point(111, 14)
        combo_tenant_name.Name = "combo_tenant_name"
        combo_tenant_name.Size = New Size(289, 25)
        combo_tenant_name.TabIndex = 16
        ' 
        ' txt_nationality
        ' 
        txt_nationality.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nationality.Location = New Point(111, 122)
        txt_nationality.Name = "txt_nationality"
        txt_nationality.Size = New Size(100, 25)
        txt_nationality.TabIndex = 9
        ' 
        ' txt_nok_name
        ' 
        txt_nok_name.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_nok_name.Location = New Point(111, 246)
        txt_nok_name.Name = "txt_nok_name"
        txt_nok_name.Size = New Size(227, 25)
        txt_nok_name.TabIndex = 15
        ' 
        ' txt_phone
        ' 
        txt_phone.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_phone.Location = New Point(111, 84)
        txt_phone.Name = "txt_phone"
        txt_phone.Size = New Size(100, 25)
        txt_phone.TabIndex = 8
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(3, 254)
        Label19.Name = "Label19"
        Label19.Size = New Size(87, 17)
        Label19.TabIndex = 12
        Label19.Text = "N.O.K Name"
        ' 
        ' txt_telno
        ' 
        txt_telno.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_telno.Location = New Point(111, 49)
        txt_telno.Name = "txt_telno"
        txt_telno.Size = New Size(100, 25)
        txt_telno.TabIndex = 7
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(16, 130)
        Label13.Name = "Label13"
        Label13.Size = New Size(78, 17)
        Label13.TabIndex = 3
        Label13.Text = "Nationality"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(44, 213)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 17)
        Label11.TabIndex = 5
        Label11.Text = "Email "
        ' 
        ' txt_email
        ' 
        txt_email.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_email.Location = New Point(111, 205)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(227, 25)
        txt_email.TabIndex = 11
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(40, 170)
        Label12.Name = "Label12"
        Label12.Size = New Size(50, 17)
        Label12.TabIndex = 4
        Label12.Text = "ID No."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(15, 92)
        Label14.Name = "Label14"
        Label14.Size = New Size(75, 17)
        Label14.TabIndex = 2
        Label14.Text = "Phone No."
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(40, 57)
        Label15.Name = "Label15"
        Label15.Size = New Size(54, 17)
        Label15.TabIndex = 1
        Label15.Text = "Tel. No"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(2, 22)
        Label16.Name = "Label16"
        Label16.Size = New Size(92, 17)
        Label16.TabIndex = 0
        Label16.Text = "Tenant Name"
        ' 
        ' txt_idno
        ' 
        txt_idno.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_idno.Location = New Point(111, 162)
        txt_idno.Name = "txt_idno"
        txt_idno.Size = New Size(163, 25)
        txt_idno.TabIndex = 10
        ' 
        ' House_Renting
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1337, 644)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "House_Renting"
        Text = "House_Renting"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_generate As Button
    Friend WithEvents combo_location As ComboBox
    Friend WithEvents combo_category As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_idno As TextBox
    Friend WithEvents txt_nationality As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_telno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents txt_rent As TextBox
    Friend WithEvents txt_deposit As TextBox
    Friend WithEvents txt_category As TextBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents txt_houseNo As TextBox
    Friend WithEvents txt_nok_name As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents combo_tenant_name As ComboBox
    Friend WithEvents txt_nok_phone As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_rentHouse As Button
    Friend WithEvents rd_btn1 As RadioButton
    Friend WithEvents Label18 As Label
End Class
