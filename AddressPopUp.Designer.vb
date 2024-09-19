<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressPopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddressPopUp))
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.SuspendLayout()
        '
        'lblChecker
        '
        Me.lblChecker.AutoSize = True
        Me.lblChecker.Font = New System.Drawing.Font("Proxima Nova Lt", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecker.ForeColor = System.Drawing.Color.IndianRed
        Me.lblChecker.Location = New System.Drawing.Point(26, 279)
        Me.lblChecker.Name = "lblChecker"
        Me.lblChecker.Size = New System.Drawing.Size(119, 13)
        Me.lblChecker.TabIndex = 79
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
        Me.btnWork.Location = New System.Drawing.Point(112, 314)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.ShadowDecoration.Parent = Me.btnWork
        Me.btnWork.Size = New System.Drawing.Size(70, 31)
        Me.btnWork.TabIndex = 78
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
        Me.btnHome.Location = New System.Drawing.Point(29, 314)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.ShadowDecoration.Parent = Me.btnHome
        Me.btnHome.Size = New System.Drawing.Size(70, 31)
        Me.btnHome.TabIndex = 77
        Me.btnHome.Text = "Home"
        Me.btnHome.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 76
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
        Me.txtStreet.Location = New System.Drawing.Point(29, 238)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreet.PlaceholderText = "Street Name, Building, House No."
        Me.txtStreet.SelectedText = ""
        Me.txtStreet.ShadowDecoration.Parent = Me.txtStreet
        Me.txtStreet.Size = New System.Drawing.Size(417, 38)
        Me.txtStreet.TabIndex = 75
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
        Me.txtPostalCode.Location = New System.Drawing.Point(29, 184)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPostalCode.PlaceholderText = "Postal Code"
        Me.txtPostalCode.SelectedText = ""
        Me.txtPostalCode.ShadowDecoration.Parent = Me.txtPostalCode
        Me.txtPostalCode.Size = New System.Drawing.Size(417, 38)
        Me.txtPostalCode.TabIndex = 74
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
        Me.txtRegion.Location = New System.Drawing.Point(29, 130)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegion.PlaceholderText = "Barangay, City, Province, Region"
        Me.txtRegion.SelectedText = ""
        Me.txtRegion.ShadowDecoration.Parent = Me.txtRegion
        Me.txtRegion.Size = New System.Drawing.Size(417, 38)
        Me.txtRegion.TabIndex = 73
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Proxima Nova Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(24, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(136, 25)
        Me.lblTitle.TabIndex = 72
        Me.lblTitle.Text = "New Address"
        '
        'chkDefault
        '
        Me.chkDefault.AutoSize = True
        Me.chkDefault.Checked = True
        Me.chkDefault.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.chkDefault.CheckedState.BorderRadius = 1
        Me.chkDefault.CheckedState.BorderThickness = 0
        Me.chkDefault.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkDefault.Enabled = False
        Me.chkDefault.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!)
        Me.chkDefault.ForeColor = System.Drawing.Color.DarkGray
        Me.chkDefault.Location = New System.Drawing.Point(29, 358)
        Me.chkDefault.Name = "chkDefault"
        Me.chkDefault.Size = New System.Drawing.Size(175, 22)
        Me.chkDefault.TabIndex = 71
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
        Me.btnCancel.Location = New System.Drawing.Point(170, 389)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(133, 43)
        Me.btnCancel.TabIndex = 70
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
        Me.btnSubmit.Location = New System.Drawing.Point(325, 389)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(133, 43)
        Me.btnSubmit.TabIndex = 69
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
        Me.txtPhoneNum.Location = New System.Drawing.Point(246, 74)
        Me.txtPhoneNum.MaxLength = 11
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNum.PlaceholderText = "Phone Number"
        Me.txtPhoneNum.SelectedText = ""
        Me.txtPhoneNum.ShadowDecoration.Parent = Me.txtPhoneNum
        Me.txtPhoneNum.Size = New System.Drawing.Size(200, 38)
        Me.txtPhoneNum.TabIndex = 68
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
        Me.txtFullName.Location = New System.Drawing.Point(29, 74)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullName.PlaceholderText = "Full Name"
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.ShadowDecoration.Parent = Me.txtFullName
        Me.txtFullName.Size = New System.Drawing.Size(200, 38)
        Me.txtFullName.TabIndex = 67
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
        Me.btnSave.Location = New System.Drawing.Point(325, 389)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(133, 43)
        Me.btnSave.TabIndex = 80
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseTransparentBackground = True
        Me.btnSave.Visible = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'AddressPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 457)
        Me.Controls.Add(Me.lblChecker)
        Me.Controls.Add(Me.btnWork)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.chkDefault)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddressPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddressPopUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChecker As Label
    Friend WithEvents btnWork As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStreet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPostalCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents chkDefault As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPhoneNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
