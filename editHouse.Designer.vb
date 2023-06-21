<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editHouse
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
        btn_edit = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
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
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_edit
        ' 
        btn_edit.BackColor = Color.RosyBrown
        btn_edit.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_edit.Location = New Point(44, 330)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(92, 39)
        btn_edit.TabIndex = 0
        btn_edit.Text = "Edit"
        btn_edit.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(2, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(822, 400)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(combo_category)
        Panel2.Controls.Add(btn_edit)
        Panel2.Controls.Add(txt_rent)
        Panel2.Controls.Add(txt_deposit)
        Panel2.Controls.Add(txt_location)
        Panel2.Controls.Add(txt_houseNo)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(507, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(308, 390)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RosyBrown
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(185, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 39)
        Button1.TabIndex = 23
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' combo_category
        ' 
        combo_category.FormattingEnabled = True
        combo_category.Location = New Point(144, 143)
        combo_category.Name = "combo_category"
        combo_category.Size = New Size(133, 23)
        combo_category.TabIndex = 22
        ' 
        ' txt_rent
        ' 
        txt_rent.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rent.Location = New Point(144, 235)
        txt_rent.Name = "txt_rent"
        txt_rent.Size = New Size(133, 28)
        txt_rent.TabIndex = 21
        ' 
        ' txt_deposit
        ' 
        txt_deposit.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_deposit.Location = New Point(144, 188)
        txt_deposit.Name = "txt_deposit"
        txt_deposit.Size = New Size(133, 28)
        txt_deposit.TabIndex = 20
        ' 
        ' txt_location
        ' 
        txt_location.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_location.Location = New Point(144, 87)
        txt_location.Name = "txt_location"
        txt_location.Size = New Size(133, 28)
        txt_location.TabIndex = 19
        ' 
        ' txt_houseNo
        ' 
        txt_houseNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_houseNo.Location = New Point(144, 27)
        txt_houseNo.Name = "txt_houseNo"
        txt_houseNo.Size = New Size(133, 28)
        txt_houseNo.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(71, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 17)
        Label6.TabIndex = 17
        Label6.Text = "Rent"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(52, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 17)
        Label5.TabIndex = 16
        Label5.Text = "Deposit"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(44, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 15
        Label4.Text = "Category"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(4, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 14
        Label2.Text = "House Location"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(34, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 17)
        Label1.TabIndex = 13
        Label1.Text = "House No."
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridView1.BackgroundColor = SystemColors.MenuHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-2, -2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(503, 400)
        DataGridView1.TabIndex = 0
        ' 
        ' editHouse
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(823, 568)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "editHouse"
        StartPosition = FormStartPosition.CenterScreen
        Text = "editHouse"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_edit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents combo_category As ComboBox
    Friend WithEvents txt_rent As TextBox
    Friend WithEvents txt_deposit As TextBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents txt_houseNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
