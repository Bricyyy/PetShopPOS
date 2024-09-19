<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InsertPictureSample
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsertPictureSample))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlNavig = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox7 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnInsert = New Guna.UI2.WinForms.Guna2Button()
        Me.setPicture = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlNavig.SuspendLayout()
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlNavig
        '
        Me.pnlNavig.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNavig.Controls.Add(Me.Guna2PictureBox7)
        Me.pnlNavig.Controls.Add(Me.Guna2ControlBox3)
        Me.pnlNavig.Controls.Add(Me.Guna2ControlBox4)
        Me.pnlNavig.Location = New System.Drawing.Point(-2, 0)
        Me.pnlNavig.Name = "pnlNavig"
        Me.pnlNavig.ShadowDecoration.Parent = Me.pnlNavig
        Me.pnlNavig.Size = New System.Drawing.Size(375, 29)
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
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(279, 0)
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
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(330, 0)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.ShadowDecoration.Parent = Me.Guna2ControlBox4
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox4.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(80, 277)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(200, 36)
        Me.txtEmail.TabIndex = 23
        '
        'btnInsert
        '
        Me.btnInsert.Animated = True
        Me.btnInsert.BackColor = System.Drawing.Color.Transparent
        Me.btnInsert.BorderRadius = 6
        Me.btnInsert.CheckedState.Parent = Me.btnInsert
        Me.btnInsert.CustomImages.Parent = Me.btnInsert
        Me.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInsert.DisabledState.Parent = Me.btnInsert
        Me.btnInsert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.HoverState.Parent = Me.btnInsert
        Me.btnInsert.Location = New System.Drawing.Point(89, 347)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.ShadowDecoration.Parent = Me.btnInsert
        Me.btnInsert.Size = New System.Drawing.Size(180, 45)
        Me.btnInsert.TabIndex = 24
        Me.btnInsert.Text = "OKAY"
        Me.btnInsert.UseTransparentBackground = True
        '
        'setPicture
        '
        Me.setPicture.Animated = True
        Me.setPicture.BackColor = System.Drawing.Color.Transparent
        Me.setPicture.BorderColor = System.Drawing.Color.Transparent
        Me.setPicture.CheckedState.Parent = Me.setPicture
        Me.setPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.setPicture.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.setPicture.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.setPicture.CustomImages.ImageSize = New System.Drawing.Size(127, 130)
        Me.setPicture.CustomImages.Parent = Me.setPicture
        Me.setPicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.setPicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.setPicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.setPicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.setPicture.DisabledState.Parent = Me.setPicture
        Me.setPicture.FillColor = System.Drawing.Color.Transparent
        Me.setPicture.Font = New System.Drawing.Font("Proxima Nova Rg", 12.0!)
        Me.setPicture.ForeColor = System.Drawing.Color.Transparent
        Me.setPicture.HoverState.Parent = Me.setPicture
        Me.setPicture.ImageSize = New System.Drawing.Size(127, 130)
        Me.setPicture.Location = New System.Drawing.Point(112, 76)
        Me.setPicture.Name = "setPicture"
        Me.setPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.setPicture.ShadowDecoration.Parent = Me.setPicture
        Me.setPicture.Size = New System.Drawing.Size(134, 138)
        Me.setPicture.TabIndex = 27
        Me.setPicture.UseTransparentBackground = True
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlNavig
        '
        'InsertPictureSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 453)
        Me.Controls.Add(Me.setPicture)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.pnlNavig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InsertPictureSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertPictureSample"
        Me.pnlNavig.ResumeLayout(False)
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlNavig As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox7 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnInsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents setPicture As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
