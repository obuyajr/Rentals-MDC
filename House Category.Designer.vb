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
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MistyRose
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(526, 135)
        Panel1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(110, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(221, 28)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
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
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(384, 50)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 28)
        Button1.TabIndex = 0
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' House_Category
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(528, 139)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        MaximizeBox = False
        Name = "House_Category"
        StartPosition = FormStartPosition.CenterScreen
        Text = "House Category"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
