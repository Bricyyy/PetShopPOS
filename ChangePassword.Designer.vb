<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.picProfile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOldPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfirmNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnChange = New Guna.UI2.WinForms.Guna2Button()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.lblPassChecker = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(23, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(484, 18)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "For your account's security, do not share your password with anyone else"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Proxima Nova Lt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(21, 19)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(207, 29)
        Me.lblItems.TabIndex = 55
        Me.lblItems.Text = "Change Password"
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(-39, 69)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(625, 20)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 57
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.Transparent
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.ImageRotate = 0!
        Me.picProfile.Location = New System.Drawing.Point(105, 124)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picProfile.ShadowDecoration.Parent = Me.picProfile
        Me.picProfile.Size = New System.Drawing.Size(83, 85)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 58
        Me.picProfile.TabStop = False
        Me.picProfile.UseTransparentBackground = True
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.Font = New System.Drawing.Font("Proxima Nova Lt", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(205, 150)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(178, 26)
        Me.lblUsername.TabIndex = 59
        Me.lblUsername.Text = "(No username)"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Lt", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(73, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Old Password"
        '
        'txtOldPass
        '
        Me.txtOldPass.Animated = True
        Me.txtOldPass.BorderRadius = 8
        Me.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOldPass.DefaultText = ""
        Me.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOldPass.DisabledState.Parent = Me.txtOldPass
        Me.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOldPass.FocusedState.Parent = Me.txtOldPass
        Me.txtOldPass.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtOldPass.ForeColor = System.Drawing.Color.Black
        Me.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOldPass.HoverState.Parent = Me.txtOldPass
        Me.txtOldPass.Location = New System.Drawing.Point(210, 249)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOldPass.PlaceholderText = ""
        Me.txtOldPass.SelectedText = ""
        Me.txtOldPass.ShadowDecoration.Parent = Me.txtOldPass
        Me.txtOldPass.Size = New System.Drawing.Size(264, 44)
        Me.txtOldPass.TabIndex = 60
        Me.txtOldPass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Lt", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(66, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 21)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Lt", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(79, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 42)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Confirm New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewPass
        '
        Me.txtNewPass.Animated = True
        Me.txtNewPass.BorderRadius = 8
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
        Me.txtNewPass.Location = New System.Drawing.Point(210, 309)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPass.PlaceholderText = ""
        Me.txtNewPass.SelectedText = ""
        Me.txtNewPass.ShadowDecoration.Parent = Me.txtNewPass
        Me.txtNewPass.Size = New System.Drawing.Size(264, 44)
        Me.txtNewPass.TabIndex = 64
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'txtConfirmNewPass
        '
        Me.txtConfirmNewPass.Animated = True
        Me.txtConfirmNewPass.BorderRadius = 8
        Me.txtConfirmNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmNewPass.DefaultText = ""
        Me.txtConfirmNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmNewPass.DisabledState.Parent = Me.txtConfirmNewPass
        Me.txtConfirmNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmNewPass.FocusedState.Parent = Me.txtConfirmNewPass
        Me.txtConfirmNewPass.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtConfirmNewPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmNewPass.HoverState.Parent = Me.txtConfirmNewPass
        Me.txtConfirmNewPass.Location = New System.Drawing.Point(210, 370)
        Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
        Me.txtConfirmNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmNewPass.PlaceholderText = ""
        Me.txtConfirmNewPass.SelectedText = ""
        Me.txtConfirmNewPass.ShadowDecoration.Parent = Me.txtConfirmNewPass
        Me.txtConfirmNewPass.Size = New System.Drawing.Size(264, 44)
        Me.txtConfirmNewPass.TabIndex = 65
        Me.txtConfirmNewPass.UseSystemPasswordChar = True
        '
        'btnChange
        '
        Me.btnChange.Animated = True
        Me.btnChange.BackColor = System.Drawing.Color.Transparent
        Me.btnChange.BorderRadius = 6
        Me.btnChange.CheckedState.Parent = Me.btnChange
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.CustomImages.Parent = Me.btnChange
        Me.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChange.DisabledState.Parent = Me.btnChange
        Me.btnChange.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnChange.Font = New System.Drawing.Font("Proxima Nova Lt", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.HoverState.Parent = Me.btnChange
        Me.btnChange.Location = New System.Drawing.Point(210, 457)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.ShadowDecoration.Parent = Me.btnChange
        Me.btnChange.Size = New System.Drawing.Size(147, 35)
        Me.btnChange.TabIndex = 66
        Me.btnChange.Text = "Change Password"
        Me.btnChange.UseTransparentBackground = True
        '
        'lblReset
        '
        Me.lblReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReset.AutoSize = True
        Me.lblReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReset.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblReset.Location = New System.Drawing.Point(207, 506)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(102, 16)
        Me.lblReset.TabIndex = 67
        Me.lblReset.Text = "Forgot Password"
        '
        'lblPassChecker
        '
        Me.lblPassChecker.AutoSize = True
        Me.lblPassChecker.Font = New System.Drawing.Font("Proxima Nova Lt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassChecker.ForeColor = System.Drawing.Color.IndianRed
        Me.lblPassChecker.Location = New System.Drawing.Point(207, 422)
        Me.lblPassChecker.Name = "lblPassChecker"
        Me.lblPassChecker.Size = New System.Drawing.Size(135, 13)
        Me.lblPassChecker.TabIndex = 68
        Me.lblPassChecker.Text = "Password does not match."
        Me.lblPassChecker.Visible = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(549, 573)
        Me.Controls.Add(Me.lblPassChecker)
        Me.Controls.Add(Me.lblReset)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtConfirmNewPass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents picProfile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOldPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnChange As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblReset As Label
    Friend WithEvents lblPassChecker As Label
End Class
