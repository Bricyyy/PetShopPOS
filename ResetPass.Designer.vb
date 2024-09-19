<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResetPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPass))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlNavig = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox7 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.resetPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.confirmPass = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.newPass = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.txtNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.donePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dogPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlNavig.SuspendLayout()
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.resetPanel.SuspendLayout()
        Me.donePanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dogPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlNavig
        '
        'pnlNavig
        '
        Me.pnlNavig.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavig.Controls.Add(Me.Guna2PictureBox7)
        Me.pnlNavig.Controls.Add(Me.Guna2ControlBox3)
        Me.pnlNavig.Controls.Add(Me.Guna2ControlBox4)
        Me.pnlNavig.Location = New System.Drawing.Point(2, 0)
        Me.pnlNavig.Name = "pnlNavig"
        Me.pnlNavig.ShadowDecoration.Parent = Me.pnlNavig
        Me.pnlNavig.Size = New System.Drawing.Size(372, 29)
        Me.pnlNavig.TabIndex = 22
        '
        'Guna2PictureBox7
        '
        Me.Guna2PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox7.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox7.Image = CType(resources.GetObject("Guna2PictureBox7.Image"), System.Drawing.Image)
        Me.Guna2PictureBox7.ImageRotate = 0!
        Me.Guna2PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox7.Name = "Guna2PictureBox7"
        Me.Guna2PictureBox7.ShadowDecoration.Parent = Me.Guna2PictureBox7
        Me.Guna2PictureBox7.Size = New System.Drawing.Size(32, 30)
        Me.Guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox7.TabIndex = 12
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
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(276, 0)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox3.TabIndex = 2
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox4.HoverState.Parent = Me.Guna2ControlBox4
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(327, 0)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.ShadowDecoration.Parent = Me.Guna2ControlBox4
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox4.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Lt", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reset Your Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Lt", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Set your new password so you can Login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and buy from Puppy Love"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Proxima Nova Rg", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblNewPass.Location = New System.Drawing.Point(14, 93)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(113, 13)
        Me.lblNewPass.TabIndex = 5
        Me.lblNewPass.Text = "Create New Password"
        Me.lblNewPass.Visible = False
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("Proxima Nova Rg", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblConfirmPass.Location = New System.Drawing.Point(14, 155)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(119, 13)
        Me.lblConfirmPass.TabIndex = 6
        Me.lblConfirmPass.Text = "Confirm New Password"
        Me.lblConfirmPass.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.IndianRed
        Me.lblError.Location = New System.Drawing.Point(14, 210)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(132, 13)
        Me.lblError.TabIndex = 7
        Me.lblError.Text = "Password does not match."
        Me.lblError.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Animated = True
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BorderRadius = 8
        Me.btnReset.CheckedState.Parent = Me.btnReset
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.CustomImages.Parent = Me.btnReset
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.DisabledState.Parent = Me.btnReset
        Me.btnReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.HoverState.Parent = Me.btnReset
        Me.btnReset.Location = New System.Drawing.Point(17, 242)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.Parent = Me.btnReset
        Me.btnReset.Size = New System.Drawing.Size(238, 36)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset Password"
        Me.btnReset.UseTransparentBackground = True
        '
        'resetPanel
        '
        Me.resetPanel.Controls.Add(Me.Label2)
        Me.resetPanel.Controls.Add(Me.btnReset)
        Me.resetPanel.Controls.Add(Me.confirmPass)
        Me.resetPanel.Controls.Add(Me.Label1)
        Me.resetPanel.Controls.Add(Me.newPass)
        Me.resetPanel.Controls.Add(Me.txtNewPass)
        Me.resetPanel.Controls.Add(Me.txtConfirmPass)
        Me.resetPanel.Controls.Add(Me.lblNewPass)
        Me.resetPanel.Controls.Add(Me.lblError)
        Me.resetPanel.Controls.Add(Me.lblConfirmPass)
        Me.resetPanel.Location = New System.Drawing.Point(52, 144)
        Me.resetPanel.Name = "resetPanel"
        Me.resetPanel.ShadowDecoration.Parent = Me.resetPanel
        Me.resetPanel.Size = New System.Drawing.Size(268, 278)
        Me.resetPanel.TabIndex = 14
        '
        'confirmPass
        '
        Me.confirmPass.BackColor = System.Drawing.Color.Transparent
        Me.confirmPass.CheckedState.Image = Global.MilkTeaOrderAndInventorySystem.My.Resources.Resources.icons8_eye_100
        Me.confirmPass.CheckedState.Parent = Me.confirmPass
        Me.confirmPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmPass.HoverState.Parent = Me.confirmPass
        Me.confirmPass.Image = CType(resources.GetObject("confirmPass.Image"), System.Drawing.Image)
        Me.confirmPass.ImageOffset = New System.Drawing.Point(0, 0)
        Me.confirmPass.ImageRotate = 0!
        Me.confirmPass.Location = New System.Drawing.Point(229, 177)
        Me.confirmPass.Name = "confirmPass"
        Me.confirmPass.PressedState.Parent = Me.confirmPass
        Me.confirmPass.ShadowDecoration.Parent = Me.confirmPass
        Me.confirmPass.Size = New System.Drawing.Size(24, 24)
        Me.confirmPass.TabIndex = 12
        Me.confirmPass.UseTransparentBackground = True
        '
        'newPass
        '
        Me.newPass.BackColor = System.Drawing.Color.Transparent
        Me.newPass.CheckedState.Image = Global.MilkTeaOrderAndInventorySystem.My.Resources.Resources.icons8_eye_100
        Me.newPass.CheckedState.Parent = Me.newPass
        Me.newPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newPass.HoverState.Parent = Me.newPass
        Me.newPass.Image = CType(resources.GetObject("newPass.Image"), System.Drawing.Image)
        Me.newPass.ImageOffset = New System.Drawing.Point(0, 0)
        Me.newPass.ImageRotate = 0!
        Me.newPass.Location = New System.Drawing.Point(229, 115)
        Me.newPass.Name = "newPass"
        Me.newPass.PressedState.Parent = Me.newPass
        Me.newPass.ShadowDecoration.Parent = Me.newPass
        Me.newPass.Size = New System.Drawing.Size(24, 24)
        Me.newPass.TabIndex = 11
        Me.newPass.UseTransparentBackground = True
        '
        'txtNewPass
        '
        Me.txtNewPass.Animated = True
        Me.txtNewPass.BorderRadius = 3
        Me.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPass.DefaultText = ""
        Me.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPass.DisabledState.Parent = Me.txtNewPass
        Me.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPass.FocusedState.Parent = Me.txtNewPass
        Me.txtNewPass.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtNewPass.ForeColor = System.Drawing.Color.Black
        Me.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPass.HoverState.Parent = Me.txtNewPass
        Me.txtNewPass.IconLeft = CType(resources.GetObject("txtNewPass.IconLeft"), System.Drawing.Image)
        Me.txtNewPass.IconRight = CType(resources.GetObject("txtNewPass.IconRight"), System.Drawing.Image)
        Me.txtNewPass.Location = New System.Drawing.Point(17, 109)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPass.PlaceholderText = "Create New Password"
        Me.txtNewPass.SelectedText = ""
        Me.txtNewPass.ShadowDecoration.Parent = Me.txtNewPass
        Me.txtNewPass.Size = New System.Drawing.Size(238, 36)
        Me.txtNewPass.TabIndex = 3
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Animated = True
        Me.txtConfirmPass.BorderRadius = 3
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = ""
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.FocusedState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.HoverState.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.IconLeft = CType(resources.GetObject("txtConfirmPass.IconLeft"), System.Drawing.Image)
        Me.txtConfirmPass.IconRight = CType(resources.GetObject("txtConfirmPass.IconRight"), System.Drawing.Image)
        Me.txtConfirmPass.Location = New System.Drawing.Point(17, 171)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPass.PlaceholderText = "Confirm New Password"
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.ShadowDecoration.Parent = Me.txtConfirmPass
        Me.txtConfirmPass.Size = New System.Drawing.Size(238, 36)
        Me.txtConfirmPass.TabIndex = 4
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'donePanel
        '
        Me.donePanel.Controls.Add(Me.btnLogin)
        Me.donePanel.Controls.Add(Me.Label4)
        Me.donePanel.Controls.Add(Me.Label3)
        Me.donePanel.Location = New System.Drawing.Point(52, 147)
        Me.donePanel.Name = "donePanel"
        Me.donePanel.ShadowDecoration.Parent = Me.donePanel
        Me.donePanel.Size = New System.Drawing.Size(268, 278)
        Me.donePanel.TabIndex = 15
        Me.donePanel.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderRadius = 8
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.DisabledState.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(30, 93)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(214, 45)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login "
        Me.btnLogin.UseTransparentBackground = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxima Nova Lt", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Location = New System.Drawing.Point(27, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "You can now use your new password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to login to your account!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Lt", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Successful Password Reset"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.MilkTeaOrderAndInventorySystem.My.Resources.Resources._0Eto_pre
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(128, 38)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(107, 103)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'dogPic
        '
        Me.dogPic.BackColor = System.Drawing.Color.Transparent
        Me.dogPic.FillColor = System.Drawing.Color.Transparent
        Me.dogPic.Image = CType(resources.GetObject("dogPic.Image"), System.Drawing.Image)
        Me.dogPic.ImageRotate = 0!
        Me.dogPic.Location = New System.Drawing.Point(38, 329)
        Me.dogPic.Name = "dogPic"
        Me.dogPic.ShadowDecoration.Parent = Me.dogPic
        Me.dogPic.Size = New System.Drawing.Size(294, 205)
        Me.dogPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dogPic.TabIndex = 13
        Me.dogPic.TabStop = False
        Me.dogPic.UseTransparentBackground = True
        Me.dogPic.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnBack.BorderThickness = 1
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.DisabledState.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!)
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(-2, 490)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(376, 45)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Back To Login"
        '
        'ResetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 535)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlNavig)
        Me.Controls.Add(Me.resetPanel)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.dogPic)
        Me.Controls.Add(Me.donePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1280, 984)
        Me.Name = "ResetPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetPass"
        Me.pnlNavig.ResumeLayout(False)
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.resetPanel.ResumeLayout(False)
        Me.resetPanel.PerformLayout()
        Me.donePanel.ResumeLayout(False)
        Me.donePanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dogPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblError As Label
    Friend WithEvents confirmPass As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents newPass As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents dogPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents donePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents resetPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlNavig As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox7 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
