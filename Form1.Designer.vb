<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-16, -10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 112)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Linen
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(-22, 101)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(430, 197)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Peru
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(-18, 295)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(455, 109)
        Panel3.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(131, 40)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 45)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(79, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(156, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(173, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(156, 66)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(173, 23)
        TextBox2.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(156, 110)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(136, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe Script", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(98, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(225, 40)
        Label4.TabIndex = 0
        Label4.Text = "La Rentals MDC"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(385, 393)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
