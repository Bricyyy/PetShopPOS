<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyAddress
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyAddress))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.flpAddress = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.pnlNewAddress = New System.Windows.Forms.Panel()
        Me.lblChecker = New System.Windows.Forms.Label()
        Me.btnWork = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStreet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPostalCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkDefault = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPhoneNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.flpAddress.SuspendLayout()
        Me.pnlNewAddress.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(23, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(297, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Manage your default and multiple addresses"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Proxima Nova Lt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(21, 19)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(138, 29)
        Me.lblItems.TabIndex = 52
        Me.lblItems.Text = "My Address"
        '
        'flpAddress
        '
        Me.flpAddress.AutoScroll = True
        Me.flpAddress.Controls.Add(Me.lblIndicator)
        Me.flpAddress.Location = New System.Drawing.Point(26, 95)
        Me.flpAddress.Name = "flpAddress"
        Me.flpAddress.Size = New System.Drawing.Size(482, 457)
        Me.flpAddress.TabIndex = 56
        '
        'lblIndicator
        '
        Me.lblIndicator.Font = New System.Drawing.Font("Proxima Nova Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicator.Location = New System.Drawing.Point(3, 0)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(476, 453)
        Me.lblIndicator.TabIndex = 1
        Me.lblIndicator.Text = "You don't have addresses yet."
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlNewAddress
        '
        Me.pnlNewAddress.Controls.Add(Me.lblChecker)
        Me.pnlNewAddress.Controls.Add(Me.btnWork)
        Me.pnlNewAddress.Controls.Add(Me.btnHome)
        Me.pnlNewAddress.Controls.Add(Me.Label5)
        Me.pnlNewAddress.Controls.Add(Me.txtStreet)
        Me.pnlNewAddress.Controls.Add(Me.txtPostalCode)
        Me.pnlNewAddress.Controls.Add(Me.txtRegion)
        Me.pnlNewAddress.Controls.Add(Me.lblTitle)
        Me.pnlNewAddress.Controls.Add(Me.chkDefault)
        Me.pnlNewAddress.Controls.Add(Me.btnCancel)
        Me.pnlNewAddress.Controls.Add(Me.btnSubmit)
        Me.pnlNewAddress.Controls.Add(Me.txtPhoneNum)
        Me.pnlNewAddress.Controls.Add(Me.txtFullName)
        Me.pnlNewAddress.Controls.Add(Me.btnSave)
        Me.pnlNewAddress.Location = New System.Drawing.Point(26, 91)
        Me.pnlNewAddress.Name = "pnlNewAddress"
        Me.pnlNewAddress.Size = New System.Drawing.Size(482, 457)
        Me.pnlNewAddress.TabIndex = 57
        Me.pnlNewAddress.Visible = False
        '
        'lblChecker
        '
        Me.lblChecker.AutoSize = True
        Me.lblChecker.Font = New System.Drawing.Font("Proxima Nova Lt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecker.ForeColor = System.Drawing.Color.IndianRed
        Me.lblChecker.Location = New System.Drawing.Point(30, 286)
        Me.lblChecker.Name = "lblChecker"
        Me.lblChecker.Size = New System.Drawing.Size(119, 13)
        Me.lblChecker.TabIndex = 65
        Me.lblChecker.Text = "Some fields are empty."
        Me.lblChecker.Visible = False
        '
        'btnWork
        '
        Me.btnWork.Animated = True
        Me.btnWork.BackColor = System.Drawing.Color.Transparent
        Me.btnWork.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnWork.BorderRadius = 2
        Me.btnWork.BorderThickness = 1
        Me.btnWork.CheckedState.Parent = Me.btnWork
        Me.btnWork.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWork.CustomImages.Parent = Me.btnWork
        Me.btnWork.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWork.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWork.DisabledState.Parent = Me.btnWork
        Me.btnWork.FillColor = System.Drawing.Color.Transparent
        Me.btnWork.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnWork.ForeColor = System.Drawing.Color.Black
        Me.btnWork.HoverState.Parent = Me.btnWork
        Me.btnWork.Location = New System.Drawing.Point(116, 321)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.ShadowDecoration.Parent = Me.btnWork
        Me.btnWork.Size = New System.Drawing.Size(70, 31)
        Me.btnWork.TabIndex = 64
        Me.btnWork.Text = "Work"
        Me.btnWork.UseTransparentBackground = True
        '
        'btnHome
        '
        Me.btnHome.Animated = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnHome.BorderRadius = 2
        Me.btnHome.BorderThickness = 1
        Me.btnHome.CheckedState.Parent = Me.btnHome
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.CustomImages.Parent = Me.btnHome
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.DisabledState.Parent = Me.btnHome
        Me.btnHome.FillColor = System.Drawing.Color.Transparent
        Me.btnHome.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.HoverState.Parent = Me.btnHome
        Me.btnHome.Location = New System.Drawing.Point(33, 321)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.ShadowDecoration.Parent = Me.btnHome
        Me.btnHome.Size = New System.Drawing.Size(70, 31)
        Me.btnHome.TabIndex = 63
        Me.btnHome.Text = "Home"
        Me.btnHome.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Label As:"
        '
        'txtStreet
        '
        Me.txtStreet.Animated = True
        Me.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStreet.DefaultText = ""
        Me.txtStreet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStreet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStreet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.DisabledState.Parent = Me.txtStreet
        Me.txtStreet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.FocusedState.Parent = Me.txtStreet
        Me.txtStreet.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtStreet.ForeColor = System.Drawing.Color.Black
        Me.txtStreet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.HoverState.Parent = Me.txtStreet
        Me.txtStreet.Location = New System.Drawing.Point(33, 245)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreet.PlaceholderText = "Street Name, Building, House No."
        Me.txtStreet.SelectedText = ""
        Me.txtStreet.ShadowDecoration.Parent = Me.txtStreet
        Me.txtStreet.Size = New System.Drawing.Size(417, 38)
        Me.txtStreet.TabIndex = 61
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Animated = True
        Me.txtPostalCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPostalCode.DefaultText = ""
        Me.txtPostalCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPostalCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPostalCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPostalCode.DisabledState.Parent = Me.txtPostalCode
        Me.txtPostalCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPostalCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPostalCode.FocusedState.Parent = Me.txtPostalCode
        Me.txtPostalCode.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtPostalCode.ForeColor = System.Drawing.Color.Black
        Me.txtPostalCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPostalCode.HoverState.Parent = Me.txtPostalCode
        Me.txtPostalCode.Location = New System.Drawing.Point(33, 191)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPostalCode.PlaceholderText = "Postal Code"
        Me.txtPostalCode.SelectedText = ""
        Me.txtPostalCode.ShadowDecoration.Parent = Me.txtPostalCode
        Me.txtPostalCode.Size = New System.Drawing.Size(417, 38)
        Me.txtPostalCode.TabIndex = 60
        '
        'txtRegion
        '
        Me.txtRegion.Animated = True
        Me.txtRegion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegion.DefaultText = ""
        Me.txtRegion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegion.DisabledState.Parent = Me.txtRegion
        Me.txtRegion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegion.FocusedState.Parent = Me.txtRegion
        Me.txtRegion.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.txtRegion.ForeColor = System.Drawing.Color.Black
        Me.txtRegion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegion.HoverState.Parent = Me.txtRegion
        Me.txtRegion.Location = New System.Drawing.Point(33, 137)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegion.PlaceholderText = "Barangay, City, Province, Region"
        Me.txtRegion.SelectedText = ""
        Me.txtRegion.ShadowDecoration.Parent = Me.txtRegion
        Me.txtRegion.Size = New System.Drawing.Size(417, 38)
        Me.txtRegion.TabIndex = 59
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Proxima Nova Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(28, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(136, 25)
        Me.lblTitle.TabIndex = 58
        Me.lblTitle.Text = "New Address"
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = True
        Me.chkDefault.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.chkDefault.CheckedState.BorderRadius = 1
        Me.chkDefault.CheckedState.BorderThickness = 0
        Me.chkDefault.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.chkDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDefault.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!)
        Me.chkDefault.ForeColor = System.Drawing.Color.DarkGray
        Me.chkDefault.Location = New System.Drawing.Point(33, 365)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(175, 22)
        Me.chkDefault.TabIndex = 7
        Me.chkDefault.Text = "Set as Default Address"
        Me.chkDefault.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.chkDefault.UncheckedState.BorderRadius = 1
        Me.chkDefault.UncheckedState.BorderThickness = 1
        Me.chkDefault.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 3
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.DisabledState.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Proxima Nova Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(174, 396)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(133, 43)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseTransparentBackground = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Animated = True
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderRadius = 3
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.DisabledState.Parent = Me.btnSubmit
        Me.btnSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Proxima Nova Rg", 12.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(329, 396)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(133, 43)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseTransparentBackground = True
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Animated = True
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
        Me.txtPhoneNum.Location = New System.Drawing.Point(250, 81)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNum.PlaceholderText = "Phone Number"
        Me.txtPhoneNum.SelectedText = ""
        Me.txtPhoneNum.ShadowDecoration.Parent = Me.txtPhoneNum
        Me.txtPhoneNum.Size = New System.Drawing.Size(200, 38)
        Me.txtPhoneNum.TabIndex = 1
        '
        'txtFullName
        '
        Me.txtFullName.Animated = True
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
        Me.txtFullName.Location = New System.Drawing.Point(33, 81)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullName.PlaceholderText = "Full Name"
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.ShadowDecoration.Parent = Me.txtFullName
        Me.txtFullName.Size = New System.Drawing.Size(200, 38)
        Me.txtFullName.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 3
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.DisabledState.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Proxima Nova Rg", 12.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(329, 396)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(133, 43)
        Me.btnSave.TabIndex = 66
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseTransparentBackground = True
        Me.btnSave.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 6
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.DisabledState.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Proxima Nova Lt", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnAdd.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnAdd.Location = New System.Drawing.Point(355, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(153, 45)
        Me.btnAdd.TabIndex = 55
        Me.btnAdd.Text = "Add New Address"
        Me.btnAdd.TextOffset = New System.Drawing.Point(3, 0)
        Me.btnAdd.UseTransparentBackground = True
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
        Me.Guna2PictureBox3.TabIndex = 54
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'MyAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(549, 573)
        Me.Controls.Add(Me.pnlNewAddress)
        Me.Controls.Add(Me.flpAddress)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MyAddress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyAddress"
        Me.flpAddress.ResumeLayout(False)
        Me.pnlNewAddress.ResumeLayout(False)
        Me.pnlNewAddress.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpAddress As FlowLayoutPanel
    Friend WithEvents pnlNewAddress As Panel
    Friend WithEvents txtPhoneNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkDefault As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRegion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnWork As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStreet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPostalCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblChecker As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblIndicator As Label
End Class
