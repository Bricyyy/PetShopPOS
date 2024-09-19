<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItem))
        Me.itemPicture = New Guna.UI2.WinForms.Guna2Button()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.test = New System.Windows.Forms.Label()
        Me.lblChecker = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemPicture
        '
        Me.itemPicture.Animated = True
        Me.itemPicture.BackColor = System.Drawing.Color.Transparent
        Me.itemPicture.BorderRadius = 20
        Me.itemPicture.CheckedState.Parent = Me.itemPicture
        Me.itemPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.itemPicture.CustomImages.Parent = Me.itemPicture
        Me.itemPicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.itemPicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.itemPicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.itemPicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.itemPicture.DisabledState.Parent = Me.itemPicture
        Me.itemPicture.FillColor = System.Drawing.Color.White
        Me.itemPicture.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.itemPicture.ForeColor = System.Drawing.Color.White
        Me.itemPicture.HoverState.Parent = Me.itemPicture
        Me.itemPicture.Image = CType(resources.GetObject("itemPicture.Image"), System.Drawing.Image)
        Me.itemPicture.ImageOffset = New System.Drawing.Point(-1, -3)
        Me.itemPicture.ImageSize = New System.Drawing.Size(200, 200)
        Me.itemPicture.Location = New System.Drawing.Point(200, 91)
        Me.itemPicture.Name = "itemPicture"
        Me.itemPicture.ShadowDecoration.Parent = Me.itemPicture
        Me.itemPicture.Size = New System.Drawing.Size(157, 158)
        Me.itemPicture.TabIndex = 0
        Me.itemPicture.UseTransparentBackground = True
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Proxima Nova Lt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(25, 20)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(202, 29)
        Me.lblItems.TabIndex = 19
        Me.lblItems.Text = "Add New Product"
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(-37, 52)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(625, 20)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 52
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 6
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.DisabledState.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Proxima Nova Lt", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(282, 501)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(141, 45)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "Save Item"
        Me.btnSave.UseTransparentBackground = True
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.BorderThickness = 2
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.DisabledState.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Proxima Nova Lt", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(110, 501)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(141, 45)
        Me.btnCancel.TabIndex = 53
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(114, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(121, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Item Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(100, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Item Quantity:"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Animated = True
        Me.txtItemPrice.BorderRadius = 8
        Me.txtItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemPrice.DefaultText = ""
        Me.txtItemPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemPrice.DisabledState.Parent = Me.txtItemPrice
        Me.txtItemPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemPrice.FocusedState.Parent = Me.txtItemPrice
        Me.txtItemPrice.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtItemPrice.ForeColor = System.Drawing.Color.Black
        Me.txtItemPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemPrice.HoverState.Parent = Me.txtItemPrice
        Me.txtItemPrice.Location = New System.Drawing.Point(209, 356)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemPrice.PlaceholderText = ""
        Me.txtItemPrice.SelectedText = ""
        Me.txtItemPrice.ShadowDecoration.Parent = Me.txtItemPrice
        Me.txtItemPrice.Size = New System.Drawing.Size(227, 36)
        Me.txtItemPrice.TabIndex = 59
        '
        'txtItemName
        '
        Me.txtItemName.Animated = True
        Me.txtItemName.BorderRadius = 8
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.Parent = Me.txtItemName
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.FocusedState.Parent = Me.txtItemName
        Me.txtItemName.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtItemName.ForeColor = System.Drawing.Color.Black
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.HoverState.Parent = Me.txtItemName
        Me.txtItemName.Location = New System.Drawing.Point(209, 297)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.PlaceholderText = ""
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.ShadowDecoration.Parent = Me.txtItemName
        Me.txtItemName.Size = New System.Drawing.Size(227, 36)
        Me.txtItemName.TabIndex = 58
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Animated = True
        Me.txtItemQuantity.BorderRadius = 8
        Me.txtItemQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemQuantity.DefaultText = ""
        Me.txtItemQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemQuantity.DisabledState.Parent = Me.txtItemQuantity
        Me.txtItemQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemQuantity.FocusedState.Parent = Me.txtItemQuantity
        Me.txtItemQuantity.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtItemQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtItemQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemQuantity.HoverState.Parent = Me.txtItemQuantity
        Me.txtItemQuantity.Location = New System.Drawing.Point(209, 417)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemQuantity.PlaceholderText = ""
        Me.txtItemQuantity.SelectedText = ""
        Me.txtItemQuantity.ShadowDecoration.Parent = Me.txtItemQuantity
        Me.txtItemQuantity.Size = New System.Drawing.Size(227, 36)
        Me.txtItemQuantity.TabIndex = 60
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'test
        '
        Me.test.AutoSize = True
        Me.test.ForeColor = System.Drawing.Color.White
        Me.test.Location = New System.Drawing.Point(389, 155)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(34, 13)
        Me.test.TabIndex = 61
        Me.test.Text = "lbltest"
        '
        'lblChecker
        '
        Me.lblChecker.AutoSize = True
        Me.lblChecker.Font = New System.Drawing.Font("Proxima Nova Lt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecker.ForeColor = System.Drawing.Color.IndianRed
        Me.lblChecker.Location = New System.Drawing.Point(206, 456)
        Me.lblChecker.Name = "lblChecker"
        Me.lblChecker.Size = New System.Drawing.Size(107, 13)
        Me.lblChecker.TabIndex = 62
        Me.lblChecker.Text = "Fill out all the fields."
        Me.lblChecker.Visible = False
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(549, 573)
        Me.Controls.Add(Me.lblChecker)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.txtItemQuantity)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.itemPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageItem"
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemPicture As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblItems As Label
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtItemQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents test As Label
    Friend WithEvents lblChecker As Label
End Class
