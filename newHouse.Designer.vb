<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newHouse
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
        Button1 = New Button()
        Panel1 = New Panel()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        combo_category = New ComboBox()
        txt_rent = New TextBox()
        txt_deposit = New TextBox()
        txt_location = New TextBox()
        txt_houseNo = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        MenuStrip1 = New MenuStrip()
        AdditionalRunningsToolStripMenuItem = New ToolStripMenuItem()
        AddCategoryOfHousesToolStripMenuItem = New ToolStripMenuItem()
        combo_status = New ComboBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(211, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 51)
        Button1.TabIndex = 0
        Button1.Text = "Add House"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(combo_status)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(combo_category)
        Panel1.Controls.Add(txt_rent)
        Panel1.Controls.Add(txt_deposit)
        Panel1.Controls.Add(txt_location)
        Panel1.Controls.Add(txt_houseNo)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(820, 400)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(433, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(380, 390)
        Panel3.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(8, 16)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(364, 367)
        DataGridView1.TabIndex = 0
        ' 
        ' combo_category
        ' 
        combo_category.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        combo_category.FormattingEnabled = True
        combo_category.Location = New Point(210, 186)
        combo_category.Name = "combo_category"
        combo_category.Size = New Size(133, 25)
        combo_category.TabIndex = 12
        ' 
        ' txt_rent
        ' 
        txt_rent.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rent.Location = New Point(210, 283)
        txt_rent.Name = "txt_rent"
        txt_rent.Size = New Size(133, 28)
        txt_rent.TabIndex = 11
        ' 
        ' txt_deposit
        ' 
        txt_deposit.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_deposit.Location = New Point(210, 236)
        txt_deposit.Name = "txt_deposit"
        txt_deposit.Size = New Size(133, 28)
        txt_deposit.TabIndex = 10
        ' 
        ' txt_location
        ' 
        txt_location.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_location.Location = New Point(210, 130)
        txt_location.Name = "txt_location"
        txt_location.Size = New Size(133, 28)
        txt_location.TabIndex = 7
        ' 
        ' txt_houseNo
        ' 
        txt_houseNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_houseNo.Location = New Point(210, 70)
        txt_houseNo.Name = "txt_houseNo"
        txt_houseNo.Size = New Size(133, 28)
        txt_houseNo.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(114, 289)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 17)
        Label6.TabIndex = 5
        Label6.Text = "Rent"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(95, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 17)
        Label5.TabIndex = 4
        Label5.Text = "Deposit"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(87, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 3
        Label4.Text = "Category"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(47, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 1
        Label2.Text = "House Location"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(77, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 17)
        Label1.TabIndex = 0
        Label1.Text = "House No."
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.DarkGray
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(2, 479)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(820, 78)
        Panel2.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(444, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 51)
        Button2.TabIndex = 1
        Button2.Text = "Clear Details"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AdditionalRunningsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(823, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AdditionalRunningsToolStripMenuItem
        ' 
        AdditionalRunningsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddCategoryOfHousesToolStripMenuItem})
        AdditionalRunningsToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AdditionalRunningsToolStripMenuItem.Name = "AdditionalRunningsToolStripMenuItem"
        AdditionalRunningsToolStripMenuItem.Size = New Size(145, 20)
        AdditionalRunningsToolStripMenuItem.Text = "Additional Runnings"
        ' 
        ' AddCategoryOfHousesToolStripMenuItem
        ' 
        AddCategoryOfHousesToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AddCategoryOfHousesToolStripMenuItem.Name = "AddCategoryOfHousesToolStripMenuItem"
        AddCategoryOfHousesToolStripMenuItem.Size = New Size(221, 22)
        AddCategoryOfHousesToolStripMenuItem.Text = "Add Category of Houses"
        ' 
        ' combo_status
        ' 
        combo_status.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        combo_status.FormattingEnabled = True
        combo_status.Items.AddRange(New Object() {"AVAILABLE"})
        combo_status.Location = New Point(210, 331)
        combo_status.Name = "combo_status"
        combo_status.Size = New Size(133, 25)
        combo_status.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(105, 339)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 17)
        Label3.TabIndex = 14
        Label3.Text = "Status"
        ' 
        ' newHouse
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(823, 568)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "newHouse"
        StartPosition = FormStartPosition.Manual
        Text = "newHouse"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_category As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_rent As TextBox
    Friend WithEvents txt_deposit As TextBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents txt_houseNo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdditionalRunningsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCategoryOfHousesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents Label3 As Label
End Class
