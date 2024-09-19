<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyAccount))
        Me.lblItems = New System.Windows.Forms.Label()
        Me.setPicture = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btnDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPhoneNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMale = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.btnFemale = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnOther = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.lblUNInfo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbDate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbMonth = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSelectPic = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblUsernameChecker = New System.Windows.Forms.Label()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Proxima Nova Lt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(21, 19)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(141, 29)
        Me.lblItems.TabIndex = 18
        Me.lblItems.Text = "My Account"
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
        Me.setPicture.Location = New System.Drawing.Point(374, 124)
        Me.setPicture.Name = "setPicture"
        Me.setPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.setPicture.ShadowDecoration.Parent = Me.setPicture
        Me.setPicture.Size = New System.Drawing.Size(134, 138)
        Me.setPicture.TabIndex = 28
        Me.setPicture.UseTransparentBackground = True
        '
        'btnDiscard
        '
        Me.btnDiscard.Animated = True
        Me.btnDiscard.BackColor = System.Drawing.Color.Transparent
        Me.btnDiscard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnDiscard.BorderRadius = 6
        Me.btnDiscard.BorderThickness = 2
        Me.btnDiscard.CheckedState.Parent = Me.btnDiscard
        Me.btnDiscard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiscard.CustomImages.Parent = Me.btnDiscard
        Me.btnDiscard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDiscard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDiscard.DisabledState.Parent = Me.btnDiscard
        Me.btnDiscard.FillColor = System.Drawing.Color.Empty
        Me.btnDiscard.Font = New System.Drawing.Font("Proxima Nova Lt", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnDiscard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnDiscard.HoverState.Parent = Me.btnDiscard
        Me.btnDiscard.Location = New System.Drawing.Point(107, 480)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.ShadowDecoration.Parent = Me.btnDiscard
        Me.btnDiscard.Size = New System.Drawing.Size(141, 45)
        Me.btnDiscard.TabIndex = 29
        Me.btnDiscard.Text = "Discard Changes"
        Me.btnDiscard.UseTransparentBackground = True
        Me.btnDiscard.Visible = False
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
        Me.btnSave.Location = New System.Drawing.Point(279, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(141, 45)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseTransparentBackground = True
        Me.btnSave.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.AutoRoundedCorners = True
        Me.txtUsername.BorderRadius = 17
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(107, 115)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(227, 36)
        Me.txtUsername.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(23, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Username"
        '
        'txtFullName
        '
        Me.txtFullName.Animated = True
        Me.txtFullName.AutoRoundedCorners = True
        Me.txtFullName.BorderRadius = 17
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullName.DefaultText = ""
        Me.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullName.DisabledState.Parent = Me.txtFullName
        Me.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.FocusedState.Parent = Me.txtFullName
        Me.txtFullName.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtFullName.ForeColor = System.Drawing.Color.Black
        Me.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.HoverState.Parent = Me.txtFullName
        Me.txtFullName.Location = New System.Drawing.Point(107, 191)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullName.PlaceholderText = ""
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.ShadowDecoration.Parent = Me.txtFullName
        Me.txtFullName.Size = New System.Drawing.Size(227, 36)
        Me.txtFullName.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(24, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(54, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Email"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(105, 255)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(109, 16)
        Me.lblEmail.TabIndex = 37
        Me.lblEmail.Text = "ex*****@gmail.com"
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Animated = True
        Me.txtPhoneNum.AutoRoundedCorners = True
        Me.txtPhoneNum.BorderRadius = 17
        Me.txtPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNum.DefaultText = ""
        Me.txtPhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNum.DisabledState.Parent = Me.txtPhoneNum
        Me.txtPhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNum.FocusedState.Parent = Me.txtPhoneNum
        Me.txtPhoneNum.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtPhoneNum.ForeColor = System.Drawing.Color.Black
        Me.txtPhoneNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNum.HoverState.Parent = Me.txtPhoneNum
        Me.txtPhoneNum.Location = New System.Drawing.Point(107, 296)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNum.PlaceholderText = ""
        Me.txtPhoneNum.SelectedText = ""
        Me.txtPhoneNum.ShadowDecoration.Parent = Me.txtPhoneNum
        Me.txtPhoneNum.Size = New System.Drawing.Size(227, 36)
        Me.txtPhoneNum.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(47, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(40, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Gender"
        '
        'btnMale
        '
        Me.btnMale.BackColor = System.Drawing.Color.Transparent
        Me.btnMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnMale.CheckedState.BorderThickness = 0
        Me.btnMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnMale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnMale.CheckedState.Parent = Me.btnMale
        Me.btnMale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMale.Location = New System.Drawing.Point(109, 359)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.ShadowDecoration.Parent = Me.btnMale
        Me.btnMale.Size = New System.Drawing.Size(20, 20)
        Me.btnMale.TabIndex = 43
        Me.btnMale.Text = "Guna2CustomRadioButton2"
        Me.btnMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnMale.UncheckedState.BorderThickness = 2
        Me.btnMale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.btnMale.UncheckedState.Parent = Me.btnMale
        Me.btnMale.UseTransparentBackground = True
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.Location = New System.Drawing.Point(135, 361)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(41, 18)
        Me.lblMale.TabIndex = 44
        Me.lblMale.Text = "Male"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.Location = New System.Drawing.Point(208, 361)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(56, 18)
        Me.lblFemale.TabIndex = 46
        Me.lblFemale.Text = "Female"
        '
        'btnFemale
        '
        Me.btnFemale.BackColor = System.Drawing.Color.Transparent
        Me.btnFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnFemale.CheckedState.BorderThickness = 0
        Me.btnFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnFemale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnFemale.CheckedState.Parent = Me.btnFemale
        Me.btnFemale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFemale.Location = New System.Drawing.Point(182, 359)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.ShadowDecoration.Parent = Me.btnFemale
        Me.btnFemale.Size = New System.Drawing.Size(20, 20)
        Me.btnFemale.TabIndex = 45
        Me.btnFemale.Text = "Guna2CustomRadioButton1"
        Me.btnFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnFemale.UncheckedState.BorderThickness = 2
        Me.btnFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.btnFemale.UncheckedState.Parent = Me.btnFemale
        Me.btnFemale.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Proxima Nova Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Other"
        '
        'btnOther
        '
        Me.btnOther.BackColor = System.Drawing.Color.Transparent
        Me.btnOther.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnOther.CheckedState.BorderThickness = 0
        Me.btnOther.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnOther.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnOther.CheckedState.Parent = Me.btnOther
        Me.btnOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOther.Location = New System.Drawing.Point(270, 359)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.ShadowDecoration.Parent = Me.btnOther
        Me.btnOther.Size = New System.Drawing.Size(20, 20)
        Me.btnOther.TabIndex = 47
        Me.btnOther.Text = "Guna2CustomRadioButton2"
        Me.btnOther.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnOther.UncheckedState.BorderThickness = 2
        Me.btnOther.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnOther.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.btnOther.UncheckedState.Parent = Me.btnOther
        Me.btnOther.UseTransparentBackground = True
        '
        'lblUNInfo
        '
        Me.lblUNInfo.AutoSize = True
        Me.lblUNInfo.Font = New System.Drawing.Font("Proxima Nova Rg", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUNInfo.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblUNInfo.Location = New System.Drawing.Point(105, 154)
        Me.lblUNInfo.Name = "lblUNInfo"
        Me.lblUNInfo.Size = New System.Drawing.Size(210, 15)
        Me.lblUNInfo.TabIndex = 49
        Me.lblUNInfo.Text = "Username can only be changed once." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(23, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(228, 18)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Manage and protect your account"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(9, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Date of Birth"
        '
        'cmbDate
        '
        Me.cmbDate.AutoRoundedCorners = True
        Me.cmbDate.BackColor = System.Drawing.Color.Transparent
        Me.cmbDate.BorderRadius = 17
        Me.cmbDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDate.DropDownHeight = 120
        Me.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDate.DropDownWidth = 20
        Me.cmbDate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDate.FocusedState.Parent = Me.cmbDate
        Me.cmbDate.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.cmbDate.ForeColor = System.Drawing.Color.Black
        Me.cmbDate.HoverState.Parent = Me.cmbDate
        Me.cmbDate.IntegralHeight = False
        Me.cmbDate.ItemHeight = 30
        Me.cmbDate.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDate.ItemsAppearance.Parent = Me.cmbDate
        Me.cmbDate.Location = New System.Drawing.Point(107, 405)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.ShadowDecoration.Parent = Me.cmbDate
        Me.cmbDate.Size = New System.Drawing.Size(69, 36)
        Me.cmbDate.StartIndex = 0
        Me.cmbDate.TabIndex = 54
        Me.cmbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmbDate.TextOffset = New System.Drawing.Point(8, 0)
        '
        'cmbMonth
        '
        Me.cmbMonth.AutoRoundedCorners = True
        Me.cmbMonth.BackColor = System.Drawing.Color.Transparent
        Me.cmbMonth.BorderRadius = 17
        Me.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonth.DropDownHeight = 120
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.DropDownWidth = 20
        Me.cmbMonth.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonth.FocusedState.Parent = Me.cmbMonth
        Me.cmbMonth.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.cmbMonth.ForeColor = System.Drawing.Color.Black
        Me.cmbMonth.HoverState.Parent = Me.cmbMonth
        Me.cmbMonth.IntegralHeight = False
        Me.cmbMonth.ItemHeight = 30
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.ItemsAppearance.Parent = Me.cmbMonth
        Me.cmbMonth.Location = New System.Drawing.Point(182, 405)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.ShadowDecoration.Parent = Me.cmbMonth
        Me.cmbMonth.Size = New System.Drawing.Size(116, 36)
        Me.cmbMonth.StartIndex = 0
        Me.cmbMonth.TabIndex = 55
        Me.cmbMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmbMonth.TextOffset = New System.Drawing.Point(5, 0)
        '
        'cmbYear
        '
        Me.cmbYear.AutoRoundedCorners = True
        Me.cmbYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbYear.BorderRadius = 17
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYear.DropDownHeight = 120
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.DropDownWidth = 20
        Me.cmbYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbYear.FocusedState.Parent = Me.cmbYear
        Me.cmbYear.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.cmbYear.ForeColor = System.Drawing.Color.Black
        Me.cmbYear.HoverState.Parent = Me.cmbYear
        Me.cmbYear.IntegralHeight = False
        Me.cmbYear.ItemHeight = 30
        Me.cmbYear.Items.AddRange(New Object() {"2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910"})
        Me.cmbYear.ItemsAppearance.Parent = Me.cmbYear
        Me.cmbYear.Location = New System.Drawing.Point(304, 405)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.ShadowDecoration.Parent = Me.cmbYear
        Me.cmbYear.Size = New System.Drawing.Size(95, 36)
        Me.cmbYear.StartIndex = 0
        Me.cmbYear.TabIndex = 56
        Me.cmbYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmbYear.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnSelectPic
        '
        Me.btnSelectPic.Animated = True
        Me.btnSelectPic.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectPic.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnSelectPic.BorderRadius = 6
        Me.btnSelectPic.BorderThickness = 1
        Me.btnSelectPic.CheckedState.Parent = Me.btnSelectPic
        Me.btnSelectPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectPic.CustomImages.Parent = Me.btnSelectPic
        Me.btnSelectPic.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSelectPic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSelectPic.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSelectPic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSelectPic.DisabledState.Parent = Me.btnSelectPic
        Me.btnSelectPic.FillColor = System.Drawing.Color.Transparent
        Me.btnSelectPic.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPic.ForeColor = System.Drawing.Color.Black
        Me.btnSelectPic.HoverState.Parent = Me.btnSelectPic
        Me.btnSelectPic.Location = New System.Drawing.Point(374, 278)
        Me.btnSelectPic.Name = "btnSelectPic"
        Me.btnSelectPic.ShadowDecoration.Parent = Me.btnSelectPic
        Me.btnSelectPic.Size = New System.Drawing.Size(134, 45)
        Me.btnSelectPic.TabIndex = 57
        Me.btnSelectPic.Text = "Select Image"
        Me.btnSelectPic.UseTransparentBackground = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(462, 385)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 58
        Me.lblDate.Text = "Date"
        '
        'lblUsernameChecker
        '
        Me.lblUsernameChecker.AutoSize = True
        Me.lblUsernameChecker.Font = New System.Drawing.Font("Proxima Nova Lt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameChecker.ForeColor = System.Drawing.Color.IndianRed
        Me.lblUsernameChecker.Location = New System.Drawing.Point(106, 99)
        Me.lblUsernameChecker.Name = "lblUsernameChecker"
        Me.lblUsernameChecker.Size = New System.Drawing.Size(126, 13)
        Me.lblUsernameChecker.TabIndex = 59
        Me.lblUsernameChecker.Text = "Username already exist."
        Me.lblUsernameChecker.Visible = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(-35, 69)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(625, 20)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 51
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 90.0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(312, 117)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(87, 217)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 52
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'MyAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(549, 573)
        Me.Controls.Add(Me.lblUsernameChecker)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnSelectPic)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.setPicture)
        Me.Controls.Add(Me.cmbDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblUNInfo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.lblFemale)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.lblMale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MyAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyAccount"
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItems As Label
    Friend WithEvents setPicture As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btnDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPhoneNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnMale As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents btnFemale As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents btnOther As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents lblUNInfo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbDate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbMonth As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSelectPic As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblUsernameChecker As Label
End Class
