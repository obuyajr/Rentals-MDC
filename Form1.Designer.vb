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
        Button2 = New Button()
        Label4 = New Label()
        Panel2 = New Panel()
        combo_utype = New ComboBox()
        txt_pwd = New TextBox()
        txt_uname = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-16, -10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 112)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SeaShell
        Button2.Image = My.Resources.Resources.close
        Button2.Location = New Point(361, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(38, 31)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Linen
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(combo_utype)
        Panel2.Controls.Add(txt_pwd)
        Panel2.Controls.Add(txt_uname)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(-22, 101)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(430, 197)
        Panel2.TabIndex = 1
        ' 
        ' combo_utype
        ' 
        combo_utype.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        combo_utype.FormattingEnabled = True
        combo_utype.Items.AddRange(New Object() {"USER", "ADMIN"})
        combo_utype.Location = New Point(156, 102)
        combo_utype.Name = "combo_utype"
        combo_utype.Size = New Size(136, 23)
        combo_utype.TabIndex = 5
        ' 
        ' txt_pwd
        ' 
        txt_pwd.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_pwd.Location = New Point(156, 66)
        txt_pwd.Name = "txt_pwd"
        txt_pwd.Size = New Size(173, 25)
        txt_pwd.TabIndex = 4
        ' 
        ' txt_uname
        ' 
        txt_uname.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_uname.Location = New Point(156, 24)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(173, 25)
        txt_uname.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(70, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 2
        Label3.Text = "USERTYPE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(62, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(62, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME"
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
        Button1.BackColor = Color.FloralWhite
        Button1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(152, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 36)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
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
    Friend WithEvents combo_utype As ComboBox
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
