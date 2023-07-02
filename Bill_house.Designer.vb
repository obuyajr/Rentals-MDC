<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill_house
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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Panel2 = New Panel()
        chkbox_include_deposit = New CheckBox()
        lbl_deposit = New Label()
        lbl_rent = New Label()
        lbl_category = New Label()
        lbl_location = New Label()
        Panel3 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Location = New Point(12, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(315, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(13, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 17)
        Label1.TabIndex = 1
        Label1.Text = "Select House"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(122, 30)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(162, 29)
        ComboBox1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(chkbox_include_deposit)
        Panel2.Controls.Add(lbl_deposit)
        Panel2.Controls.Add(lbl_rent)
        Panel2.Controls.Add(lbl_category)
        Panel2.Controls.Add(lbl_location)
        Panel2.Location = New Point(487, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(339, 273)
        Panel2.TabIndex = 1
        ' 
        ' chkbox_include_deposit
        ' 
        chkbox_include_deposit.AutoSize = True
        chkbox_include_deposit.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        chkbox_include_deposit.ForeColor = Color.DodgerBlue
        chkbox_include_deposit.Location = New Point(115, 220)
        chkbox_include_deposit.Name = "chkbox_include_deposit"
        chkbox_include_deposit.Size = New Size(142, 24)
        chkbox_include_deposit.TabIndex = 4
        chkbox_include_deposit.Text = "Include Deposit"
        chkbox_include_deposit.UseVisualStyleBackColor = True
        ' 
        ' lbl_deposit
        ' 
        lbl_deposit.AutoSize = True
        lbl_deposit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_deposit.ForeColor = Color.Fuchsia
        lbl_deposit.Location = New Point(115, 122)
        lbl_deposit.Name = "lbl_deposit"
        lbl_deposit.Size = New Size(76, 21)
        lbl_deposit.TabIndex = 3
        lbl_deposit.Text = "DEPOSIT"
        ' 
        ' lbl_rent
        ' 
        lbl_rent.AutoSize = True
        lbl_rent.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_rent.ForeColor = Color.Fuchsia
        lbl_rent.Location = New Point(115, 161)
        lbl_rent.Name = "lbl_rent"
        lbl_rent.Size = New Size(133, 21)
        lbl_rent.TabIndex = 2
        lbl_rent.Text = "MONTHLY RENT"
        ' 
        ' lbl_category
        ' 
        lbl_category.AutoSize = True
        lbl_category.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_category.ForeColor = Color.Fuchsia
        lbl_category.Location = New Point(115, 81)
        lbl_category.Name = "lbl_category"
        lbl_category.Size = New Size(91, 21)
        lbl_category.TabIndex = 1
        lbl_category.Text = "CATEGORY"
        ' 
        ' lbl_location
        ' 
        lbl_location.AutoSize = True
        lbl_location.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_location.ForeColor = Color.Fuchsia
        lbl_location.Location = New Point(115, 43)
        lbl_location.Name = "lbl_location"
        lbl_location.Size = New Size(89, 21)
        lbl_location.TabIndex = 0
        lbl_location.Text = "LOCATION"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.IndianRed
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(487, 321)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(339, 68)
        Panel3.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(116, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 41)
        Button1.TabIndex = 0
        Button1.Text = "Bill House"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Bill_house
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaShell
        ClientSize = New Size(838, 469)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Bill_house"
        StartPosition = FormStartPosition.Manual
        Text = "Bill House"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_deposit As Label
    Friend WithEvents lbl_rent As Label
    Friend WithEvents lbl_category As Label
    Friend WithEvents lbl_location As Label
    Friend WithEvents chkbox_include_deposit As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
