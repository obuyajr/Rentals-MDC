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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CheckBox1 = New CheckBox()
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
        Panel1.Size = New Size(315, 186)
        Panel1.TabIndex = 0
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(487, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(339, 273)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Fuchsia
        Label2.Location = New Point(115, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 0
        Label2.Text = "LOCATION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Fuchsia
        Label3.Location = New Point(115, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 21)
        Label3.TabIndex = 1
        Label3.Text = "CATEGORY"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Fuchsia
        Label4.Location = New Point(115, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 21)
        Label4.TabIndex = 3
        Label4.Text = "DEPOSIT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Fuchsia
        Label5.Location = New Point(115, 161)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 21)
        Label5.TabIndex = 2
        Label5.Text = "MONTHLY RENT"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.DodgerBlue
        CheckBox1.Location = New Point(115, 220)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(142, 24)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Include Deposit"
        CheckBox1.UseVisualStyleBackColor = True
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
        BackColor = Color.PeachPuff
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
