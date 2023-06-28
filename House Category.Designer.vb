<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class House_Category
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
        txt_category = New TextBox()
        Label1 = New Label()
        btn_addCategory = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CadetBlue
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(txt_category)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btn_addCategory)
        Panel1.Location = New Point(1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(526, 135)
        Panel1.TabIndex = 0
        ' 
        ' txt_category
        ' 
        txt_category.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_category.Location = New Point(110, 50)
        txt_category.Name = "txt_category"
        txt_category.Size = New Size(221, 28)
        txt_category.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 17)
        Label1.TabIndex = 1
        Label1.Text = "Category "
        ' 
        ' btn_addCategory
        ' 
        btn_addCategory.BackColor = Color.Yellow
        btn_addCategory.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_addCategory.Location = New Point(390, 44)
        btn_addCategory.Name = "btn_addCategory"
        btn_addCategory.Size = New Size(92, 40)
        btn_addCategory.TabIndex = 0
        btn_addCategory.Text = "Add"
        btn_addCategory.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Image = My.Resources.Resources.close1
        Button1.Location = New Point(492, -2)
        Button1.Name = "Button1"
        Button1.Size = New Size(32, 32)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = False
        ' 
        ' House_Category
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(528, 139)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "House_Category"
        StartPosition = FormStartPosition.CenterScreen
        Text = "House Category"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_category As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_addCategory As Button
    Friend WithEvents Button1 As Button
End Class
