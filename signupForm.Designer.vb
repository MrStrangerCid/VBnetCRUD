<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signupForm
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
        btnSignup = New Button()
        txtUsername = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' btnSignup
        ' 
        btnSignup.Location = New Point(158, 183)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(109, 37)
        btnSignup.TabIndex = 0
        btnSignup.Text = "Register"
        btnSignup.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(109, 47)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(278, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(109, 93)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(278, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(109, 142)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(278, 23)
        txtPassword.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 4
        Label1.Text = "username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 5
        Label2.Text = "email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 6
        Label3.Text = "password"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(308, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(79, 15)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Back to Login"
        ' 
        ' signupForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(425, 244)
        Controls.Add(LinkLabel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(btnSignup)
        FormBorderStyle = FormBorderStyle.None
        Name = "signupForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "signupForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSignup As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
