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
        ComboBox3 = New ComboBox()
        Label4 = New Label()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(520, 139)
        Panel1.TabIndex = 0
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(90, 94)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(191, 28)
        ComboBox3.TabIndex = 7
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
        ' Button1
        ' 
        Button1.BackColor = Color.MistyRose
        Button1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(322, 59)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 38)
        Button1.TabIndex = 5
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(90, 64)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(191, 28)
        ComboBox2.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(90, 35)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(191, 28)
        ComboBox1.TabIndex = 3
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
        Panel2.Location = New Point(1, 180)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(520, 460)
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
        DataGridView1.Size = New Size(520, 436)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Location = New Point(527, 33)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(495, 607)
        Panel3.TabIndex = 2
        ' 
        ' House_Renting
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1023, 644)
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
End Class
