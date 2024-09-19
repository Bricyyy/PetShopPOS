<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmailChecker = New System.Windows.Forms.Label()
        Me.lblSmail = New System.Windows.Forms.Label()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkRememberMe = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.forgPass = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSignup = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblChecker = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.signupPanel = New System.Windows.Forms.Panel()
        Me.signupEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.passwordShow = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.showPass = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlNavig = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox7 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnCloseProg = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.signupPanel.SuspendLayout()
        Me.loginPanel.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNavig.SuspendLayout()
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("iCiel Rukola", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 115)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sign in to Puppy Love"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmailChecker
        '
        Me.lblEmailChecker.AutoSize = True
        Me.lblEmailChecker.Font = New System.Drawing.Font("Proxima Nova Lt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailChecker.ForeColor = System.Drawing.Color.IndianRed
        Me.lblEmailChecker.Location = New System.Drawing.Point(53, 195)
        Me.lblEmailChecker.Name = "lblEmailChecker"
        Me.lblEmailChecker.Size = New System.Drawing.Size(73, 13)
        Me.lblEmailChecker.TabIndex = 21
        Me.lblEmailChecker.Text = "Invalid Email."
        Me.lblEmailChecker.Visible = False
        '
        'lblSmail
        '
        Me.lblSmail.AutoSize = True
        Me.lblSmail.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmail.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSmail.Location = New System.Drawing.Point(54, 128)
        Me.lblSmail.Name = "lblSmail"
        Me.lblSmail.Size = New System.Drawing.Size(39, 16)
        Me.lblSmail.TabIndex = 20
        Me.lblSmail.Text = "Email"
        Me.lblSmail.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Animated = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BorderRadius = 6
        Me.btnNext.CheckedState.Parent = Me.btnNext
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.CustomImages.Parent = Me.btnNext
        Me.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNext.DisabledState.Parent = Me.btnNext
        Me.btnNext.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Proxima Nova Rg", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.HoverState.Parent = Me.btnNext
        Me.btnNext.Location = New System.Drawing.Point(85, 217)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.ShadowDecoration.Parent = Me.btnNext
        Me.btnNext.Size = New System.Drawing.Size(180, 45)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseTransparentBackground = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(35, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(295, 42)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Enter the email that will be associated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to your account"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(351, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Welcome, Create your account"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogin.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(252, 346)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(55, 21)
        Me.lblLogin.TabIndex = 15
        Me.lblLogin.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(53, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Already have an account?"
        '
        'chkRememberMe
        '
        Me.chkRememberMe.AutoSize = True
        Me.chkRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.chkRememberMe.CheckedState.BorderRadius = 5
        Me.chkRememberMe.CheckedState.BorderThickness = 0
        Me.chkRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkRememberMe.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold)
        Me.chkRememberMe.Location = New System.Drawing.Point(51, 234)
        Me.chkRememberMe.Name = "chkRememberMe"
        Me.chkRememberMe.Size = New System.Drawing.Size(113, 19)
        Me.chkRememberMe.TabIndex = 10
        Me.chkRememberMe.Text = "Remember Me"
        Me.chkRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkRememberMe.UncheckedState.BorderRadius = 5
        Me.chkRememberMe.UncheckedState.BorderThickness = 0
        Me.chkRememberMe.UncheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder
        '
        'forgPass
        '
        Me.forgPass.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.forgPass.AutoSize = True
        Me.forgPass.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgPass.LinkColor = System.Drawing.SystemColors.AppWorkspace
        Me.forgPass.Location = New System.Drawing.Point(184, 234)
        Me.forgPass.Name = "forgPass"
        Me.forgPass.Size = New System.Drawing.Size(112, 15)
        Me.forgPass.TabIndex = 15
        Me.forgPass.TabStop = True
        Me.forgPass.Text = "Forgot Password?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(51, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Don't have an account?"
        '
        'lblSignup
        '
        Me.lblSignup.AutoSize = True
        Me.lblSignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignup.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.lblSignup.Location = New System.Drawing.Point(232, 346)
        Me.lblSignup.Name = "lblSignup"
        Me.lblSignup.Size = New System.Drawing.Size(63, 21)
        Me.lblSignup.TabIndex = 14
        Me.lblSignup.Text = "Signup"
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderRadius = 21
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.DisabledState.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Proxima Nova Rg", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(83, 280)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(180, 45)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "LOGIN"
        '
        'lblChecker
        '
        Me.lblChecker.AutoSize = True
        Me.lblChecker.Font = New System.Drawing.Font("Proxima Nova Lt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecker.ForeColor = System.Drawing.Color.IndianRed
        Me.lblChecker.Location = New System.Drawing.Point(51, 215)
        Me.lblChecker.Name = "lblChecker"
        Me.lblChecker.Size = New System.Drawing.Size(136, 13)
        Me.lblChecker.TabIndex = 18
        Me.lblChecker.Text = "Invalid Email or Password."
        Me.lblChecker.Visible = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblEmail.Location = New System.Drawing.Point(51, 98)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 16)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email"
        Me.lblEmail.Visible = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPass.Location = New System.Drawing.Point(51, 154)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(63, 16)
        Me.lblPass.TabIndex = 20
        Me.lblPass.Text = "Password"
        Me.lblPass.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(355, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Sign in with your Email Address and Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(77, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 33)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Welcome Back"
        '
        'signupPanel
        '
        Me.signupPanel.Controls.Add(Me.lblEmailChecker)
        Me.signupPanel.Controls.Add(Me.Label8)
        Me.signupPanel.Controls.Add(Me.lblSmail)
        Me.signupPanel.Controls.Add(Me.Label2)
        Me.signupPanel.Controls.Add(Me.btnNext)
        Me.signupPanel.Controls.Add(Me.lblLogin)
        Me.signupPanel.Controls.Add(Me.signupEmail)
        Me.signupPanel.Controls.Add(Me.Label7)
        Me.signupPanel.Location = New System.Drawing.Point(43, 159)
        Me.signupPanel.Name = "signupPanel"
        Me.signupPanel.Size = New System.Drawing.Size(365, 378)
        Me.signupPanel.TabIndex = 21
        '
        'signupEmail
        '
        Me.signupEmail.BorderRadius = 8
        Me.signupEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.signupEmail.DefaultText = ""
        Me.signupEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.signupEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.signupEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signupEmail.DisabledState.Parent = Me.signupEmail
        Me.signupEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.signupEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.signupEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signupEmail.FocusedState.Parent = Me.signupEmail
        Me.signupEmail.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold)
        Me.signupEmail.ForeColor = System.Drawing.Color.Black
        Me.signupEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.signupEmail.HoverState.Parent = Me.signupEmail
        Me.signupEmail.IconLeft = CType(resources.GetObject("signupEmail.IconLeft"), System.Drawing.Image)
        Me.signupEmail.Location = New System.Drawing.Point(52, 148)
        Me.signupEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.signupEmail.Name = "signupEmail"
        Me.signupEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.signupEmail.PlaceholderText = "Email"
        Me.signupEmail.SelectedText = ""
        Me.signupEmail.ShadowDecoration.Parent = Me.signupEmail
        Me.signupEmail.Size = New System.Drawing.Size(245, 43)
        Me.signupEmail.TabIndex = 18
        '
        'loginPanel
        '
        Me.loginPanel.Controls.Add(Me.passwordShow)
        Me.loginPanel.Controls.Add(Me.txtPassword)
        Me.loginPanel.Controls.Add(Me.forgPass)
        Me.loginPanel.Controls.Add(Me.Label3)
        Me.loginPanel.Controls.Add(Me.Label5)
        Me.loginPanel.Controls.Add(Me.Label4)
        Me.loginPanel.Controls.Add(Me.chkRememberMe)
        Me.loginPanel.Controls.Add(Me.lblSignup)
        Me.loginPanel.Controls.Add(Me.txtEmail)
        Me.loginPanel.Controls.Add(Me.btnLogin)
        Me.loginPanel.Controls.Add(Me.lblPass)
        Me.loginPanel.Controls.Add(Me.lblChecker)
        Me.loginPanel.Controls.Add(Me.lblEmail)
        Me.loginPanel.Location = New System.Drawing.Point(40, 156)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(368, 378)
        Me.loginPanel.TabIndex = 22
        '
        'passwordShow
        '
        Me.passwordShow.BackColor = System.Drawing.Color.Transparent
        Me.passwordShow.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.passwordShow.CheckedState.Parent = Me.passwordShow
        Me.passwordShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passwordShow.HoverState.Parent = Me.passwordShow
        Me.passwordShow.Image = CType(resources.GetObject("passwordShow.Image"), System.Drawing.Image)
        Me.passwordShow.ImageOffset = New System.Drawing.Point(0, 0)
        Me.passwordShow.ImageRotate = 0!
        Me.passwordShow.Location = New System.Drawing.Point(263, 174)
        Me.passwordShow.Name = "passwordShow"
        Me.passwordShow.PressedState.Parent = Me.passwordShow
        Me.passwordShow.ShadowDecoration.Parent = Me.passwordShow
        Me.passwordShow.Size = New System.Drawing.Size(31, 33)
        Me.passwordShow.TabIndex = 9
        Me.passwordShow.UseTransparentBackground = True
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.BorderRadius = 8
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.IconLeft = CType(resources.GetObject("txtPassword.IconLeft"), System.Drawing.Image)
        Me.txtPassword.IconRight = CType(resources.GetObject("txtPassword.IconRight"), System.Drawing.Image)
        Me.txtPassword.Location = New System.Drawing.Point(51, 172)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(245, 36)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BorderRadius = 8
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.IconLeft = CType(resources.GetObject("txtEmail.IconLeft"), System.Drawing.Image)
        Me.txtEmail.Location = New System.Drawing.Point(51, 116)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(245, 36)
        Me.txtEmail.TabIndex = 5
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1, 35)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(56, 51)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 2
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'showPass
        '
        Me.showPass.BackColor = System.Drawing.Color.Transparent
        Me.showPass.FillColor = System.Drawing.Color.Transparent
        Me.showPass.Image = CType(resources.GetObject("showPass.Image"), System.Drawing.Image)
        Me.showPass.ImageRotate = 0!
        Me.showPass.Location = New System.Drawing.Point(461, 30)
        Me.showPass.Name = "showPass"
        Me.showPass.ShadowDecoration.Parent = Me.showPass
        Me.showPass.Size = New System.Drawing.Size(357, 521)
        Me.showPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showPass.TabIndex = 1
        Me.showPass.TabStop = False
        Me.showPass.UseTransparentBackground = True
        '
        'pnlNavig
        '
        Me.pnlNavig.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavig.Controls.Add(Me.Guna2PictureBox7)
        Me.pnlNavig.Controls.Add(Me.Guna2ControlBox3)
        Me.pnlNavig.Controls.Add(Me.btnCloseProg)
        Me.pnlNavig.Location = New System.Drawing.Point(-2, -1)
        Me.pnlNavig.Name = "pnlNavig"
        Me.pnlNavig.ShadowDecoration.Parent = Me.pnlNavig
        Me.pnlNavig.Size = New System.Drawing.Size(820, 32)
        Me.pnlNavig.TabIndex = 23
        '
        'Guna2PictureBox7
        '
        Me.Guna2PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox7.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox7.Image = CType(resources.GetObject("Guna2PictureBox7.Image"), System.Drawing.Image)
        Me.Guna2PictureBox7.ImageRotate = 0!
        Me.Guna2PictureBox7.Location = New System.Drawing.Point(4, 2)
        Me.Guna2PictureBox7.Name = "Guna2PictureBox7"
        Me.Guna2PictureBox7.ShadowDecoration.Parent = Me.Guna2PictureBox7
        Me.Guna2PictureBox7.Size = New System.Drawing.Size(32, 30)
        Me.Guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox7.TabIndex = 24
        Me.Guna2PictureBox7.TabStop = False
        Me.Guna2PictureBox7.UseTransparentBackground = True
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(719, 2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox3.TabIndex = 2
        '
        'btnCloseProg
        '
        Me.btnCloseProg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseProg.FillColor = System.Drawing.Color.Transparent
        Me.btnCloseProg.HoverState.Parent = Me.btnCloseProg
        Me.btnCloseProg.IconColor = System.Drawing.Color.Black
        Me.btnCloseProg.Location = New System.Drawing.Point(770, 2)
        Me.btnCloseProg.Name = "btnCloseProg"
        Me.btnCloseProg.ShadowDecoration.Parent = Me.btnCloseProg
        Me.btnCloseProg.Size = New System.Drawing.Size(45, 29)
        Me.btnCloseProg.TabIndex = 1
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlNavig
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(815, 550)
        Me.Controls.Add(Me.pnlNavig)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.signupPanel)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.showPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 984)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.signupPanel.ResumeLayout(False)
        Me.signupPanel.PerformLayout()
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNavig.ResumeLayout(False)
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents signupEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSmail As Label
    Friend WithEvents lblEmailChecker As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblChecker As Label
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblSignup As Label
    Friend WithEvents chkRememberMe As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents forgPass As LinkLabel
    Friend WithEvents passwordShow As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents signupPanel As Panel
    Friend WithEvents loginPanel As Panel
    Friend WithEvents showPass As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlNavig As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnCloseProg As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox7 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
