<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlNavig = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnCloseProg = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnManage = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlDim = New System.Windows.Forms.Panel()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMessage = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlNavig.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlNavig
        '
        Me.pnlNavig.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavig.BorderColor = System.Drawing.Color.LightGray
        Me.pnlNavig.BorderThickness = 2
        Me.pnlNavig.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlNavig.Controls.Add(Me.btnCloseProg)
        Me.pnlNavig.Controls.Add(Me.lblUserInfo)
        Me.pnlNavig.FillColor = System.Drawing.Color.Transparent
        Me.pnlNavig.Location = New System.Drawing.Point(-9, -9)
        Me.pnlNavig.Name = "pnlNavig"
        Me.pnlNavig.ShadowDecoration.Parent = Me.pnlNavig
        Me.pnlNavig.Size = New System.Drawing.Size(1090, 41)
        Me.pnlNavig.TabIndex = 1
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(992, 9)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 32)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'btnCloseProg
        '
        Me.btnCloseProg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseProg.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseProg.FillColor = System.Drawing.Color.Transparent
        Me.btnCloseProg.HoverState.Parent = Me.btnCloseProg
        Me.btnCloseProg.IconColor = System.Drawing.Color.Black
        Me.btnCloseProg.Location = New System.Drawing.Point(1043, 9)
        Me.btnCloseProg.Name = "btnCloseProg"
        Me.btnCloseProg.ShadowDecoration.Parent = Me.btnCloseProg
        Me.btnCloseProg.Size = New System.Drawing.Size(45, 32)
        Me.btnCloseProg.TabIndex = 1
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblUserInfo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUserInfo.Location = New System.Drawing.Point(150, 18)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(39, 13)
        Me.lblUserInfo.TabIndex = 3
        Me.lblUserInfo.Text = "Label1"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlNavig
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.White
        Me.pnlMenu.BorderColor = System.Drawing.Color.LightGray
        Me.pnlMenu.Controls.Add(Me.btnManage)
        Me.pnlMenu.Controls.Add(Me.pnlDim)
        Me.pnlMenu.Controls.Add(Me.btnSettings)
        Me.pnlMenu.Controls.Add(Me.btnMessage)
        Me.pnlMenu.Controls.Add(Me.btnHistory)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 30)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowDecoration.Parent = Me.pnlMenu
        Me.pnlMenu.Size = New System.Drawing.Size(170, 687)
        Me.pnlMenu.TabIndex = 4
        '
        'btnManage
        '
        Me.btnManage.Animated = True
        Me.btnManage.BackColor = System.Drawing.Color.Transparent
        Me.btnManage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnManage.BorderRadius = 6
        Me.btnManage.CheckedState.Parent = Me.btnManage
        Me.btnManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManage.CustomImages.Parent = Me.btnManage
        Me.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnManage.DisabledState.Parent = Me.btnManage
        Me.btnManage.FillColor = System.Drawing.Color.Transparent
        Me.btnManage.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManage.ForeColor = System.Drawing.Color.Black
        Me.btnManage.HoverState.Parent = Me.btnManage
        Me.btnManage.Image = CType(resources.GetObject("btnManage.Image"), System.Drawing.Image)
        Me.btnManage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManage.Location = New System.Drawing.Point(18, 407)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.ShadowDecoration.Parent = Me.btnManage
        Me.btnManage.Size = New System.Drawing.Size(130, 38)
        Me.btnManage.TabIndex = 62
        Me.btnManage.Text = "Products"
        Me.btnManage.TextOffset = New System.Drawing.Point(8, 0)
        Me.btnManage.UseTransparentBackground = True
        '
        'pnlDim
        '
        Me.pnlDim.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlDim.Location = New System.Drawing.Point(42, 154)
        Me.pnlDim.Name = "pnlDim"
        Me.pnlDim.Size = New System.Drawing.Size(55, 18)
        Me.pnlDim.TabIndex = 61
        Me.pnlDim.Visible = False
        '
        'btnSettings
        '
        Me.btnSettings.Animated = True
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSettings.BorderRadius = 6
        Me.btnSettings.CheckedState.Parent = Me.btnSettings
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.CustomImages.Parent = Me.btnSettings
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.DisabledState.Parent = Me.btnSettings
        Me.btnSettings.FillColor = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSettings.HoverState.Parent = Me.btnSettings
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.Location = New System.Drawing.Point(18, 349)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.ShadowDecoration.Parent = Me.btnSettings
        Me.btnSettings.Size = New System.Drawing.Size(130, 38)
        Me.btnSettings.TabIndex = 16
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextOffset = New System.Drawing.Point(8, 0)
        Me.btnSettings.UseTransparentBackground = True
        '
        'btnMessage
        '
        Me.btnMessage.Animated = True
        Me.btnMessage.BackColor = System.Drawing.Color.Transparent
        Me.btnMessage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnMessage.BorderRadius = 6
        Me.btnMessage.CheckedState.Parent = Me.btnMessage
        Me.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMessage.CustomImages.Parent = Me.btnMessage
        Me.btnMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMessage.DisabledState.Parent = Me.btnMessage
        Me.btnMessage.FillColor = System.Drawing.Color.Transparent
        Me.btnMessage.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnMessage.ForeColor = System.Drawing.Color.Black
        Me.btnMessage.HoverState.Parent = Me.btnMessage
        Me.btnMessage.Image = CType(resources.GetObject("btnMessage.Image"), System.Drawing.Image)
        Me.btnMessage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMessage.Location = New System.Drawing.Point(18, 291)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.ShadowDecoration.Parent = Me.btnMessage
        Me.btnMessage.Size = New System.Drawing.Size(130, 38)
        Me.btnMessage.TabIndex = 15
        Me.btnMessage.Text = "Message"
        Me.btnMessage.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnMessage.UseTransparentBackground = True
        '
        'btnHistory
        '
        Me.btnHistory.Animated = True
        Me.btnHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnHistory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnHistory.BorderRadius = 6
        Me.btnHistory.CheckedState.Parent = Me.btnHistory
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistory.CustomImages.Parent = Me.btnHistory
        Me.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHistory.DisabledState.Parent = Me.btnHistory
        Me.btnHistory.FillColor = System.Drawing.Color.Transparent
        Me.btnHistory.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnHistory.ForeColor = System.Drawing.Color.Black
        Me.btnHistory.HoverState.Parent = Me.btnHistory
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHistory.Location = New System.Drawing.Point(18, 234)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.ShadowDecoration.Parent = Me.btnHistory
        Me.btnHistory.Size = New System.Drawing.Size(130, 38)
        Me.btnHistory.TabIndex = 14
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextOffset = New System.Drawing.Point(5, 0)
        Me.btnHistory.UseTransparentBackground = True
        '
        'btnHome
        '
        Me.btnHome.Animated = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnHome.BorderRadius = 6
        Me.btnHome.CheckedState.Parent = Me.btnHome
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.CustomImages.Parent = Me.btnHome
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.DisabledState.Parent = Me.btnHome
        Me.btnHome.FillColor = System.Drawing.Color.Transparent
        Me.btnHome.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.HoverState.Parent = Me.btnHome
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.Location = New System.Drawing.Point(18, 178)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.ShadowDecoration.Parent = Me.btnHome
        Me.btnHome.Size = New System.Drawing.Size(130, 38)
        Me.btnHome.TabIndex = 13
        Me.btnHome.Text = "Home"
        Me.btnHome.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(27, 38)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(106, 97)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 12
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnLogout.BorderRadius = 6
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.DisabledState.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.Location = New System.Drawing.Point(18, 628)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(130, 38)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextOffset = New System.Drawing.Point(6, 0)
        Me.btnLogout.UseTransparentBackground = True
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        Me.Guna2Elipse2.TargetControl = Me.pnlMenu
        '
        'pnlMain
        '
        Me.pnlMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.pnlMain.Location = New System.Drawing.Point(170, 34)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(909, 683)
        Me.pnlMain.TabIndex = 5
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1080, 720)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlNavig)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.pnlNavig.ResumeLayout(False)
        Me.pnlNavig.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlNavig As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnCloseProg As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents pnlMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMessage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Public WithEvents pnlMain As Panel
    Public WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlDim As Panel
    Public WithEvents btnManage As Guna.UI2.WinForms.Guna2Button
End Class
