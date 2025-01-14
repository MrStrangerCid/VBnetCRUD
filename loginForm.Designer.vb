<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        btnLogin = New Button()
        linkSignup = New LinkLabel()
        txtboxUname = New TextBox()
        txtboxPw = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        chkboxShowPw = New CheckBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(178, 160)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(125, 42)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' linkSignup
        ' 
        linkSignup.AutoSize = True
        linkSignup.Location = New Point(204, 215)
        linkSignup.Name = "linkSignup"
        linkSignup.Size = New Size(49, 15)
        linkSignup.TabIndex = 2
        linkSignup.TabStop = True
        linkSignup.Text = "Register"
        ' 
        ' txtboxUname
        ' 
        txtboxUname.Location = New Point(169, 43)
        txtboxUname.Name = "txtboxUname"
        txtboxUname.Size = New Size(208, 23)
        txtboxUname.TabIndex = 3
        ' 
        ' txtboxPw
        ' 
        txtboxPw.Location = New Point(169, 106)
        txtboxPw.Name = "txtboxPw"
        txtboxPw.Size = New Size(208, 23)
        txtboxPw.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 5
        Label1.Text = "username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(106, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 6
        Label2.Text = "password"
        ' 
        ' chkboxShowPw
        ' 
        chkboxShowPw.AutoSize = True
        chkboxShowPw.Location = New Point(169, 135)
        chkboxShowPw.Name = "chkboxShowPw"
        chkboxShowPw.Size = New Size(108, 19)
        chkboxShowPw.TabIndex = 7
        chkboxShowPw.Text = "Show Password"
        chkboxShowPw.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(449, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 21)
        Label3.TabIndex = 8
        Label3.Text = "x"
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 258)
        Controls.Add(Label3)
        Controls.Add(chkboxShowPw)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtboxPw)
        Controls.Add(txtboxUname)
        Controls.Add(linkSignup)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "loginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents linkSignup As LinkLabel
    Friend WithEvents txtboxUname As TextBox
    Friend WithEvents txtboxPw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkboxShowPw As CheckBox
    Friend WithEvents Label3 As Label
End Class
