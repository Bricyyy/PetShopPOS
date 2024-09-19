<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsManagement))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.flpManage = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlItemSample = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblItemCount = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.btnAddNew = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.picSamepleStock = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.picSampleItem = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2PictureBox13 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnCage = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMedicine = New Guna.UI2.WinForms.Guna2Button()
        Me.btnToiletries = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLeash = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFoods = New Guna.UI2.WinForms.Guna2Button()
        Me.flpManage.SuspendLayout()
        Me.pnlItemSample.SuspendLayout()
        CType(Me.picSamepleStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSampleItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Proxima Nova Lt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(27, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(257, 29)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "Products Management"
        '
        'flpManage
        '
        Me.flpManage.AutoScroll = True
        Me.flpManage.Controls.Add(Me.btnAddNew)
        Me.flpManage.Controls.Add(Me.pnlItemSample)
        Me.flpManage.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.flpManage.Location = New System.Drawing.Point(22, 206)
        Me.flpManage.Name = "flpManage"
        Me.flpManage.Size = New System.Drawing.Size(860, 454)
        Me.flpManage.TabIndex = 24
        '
        'pnlItemSample
        '
        Me.pnlItemSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItemSample.Controls.Add(Me.picSamepleStock)
        Me.pnlItemSample.Controls.Add(Me.Label1)
        Me.pnlItemSample.Controls.Add(Me.Label3)
        Me.pnlItemSample.Controls.Add(Me.Guna2Button1)
        Me.pnlItemSample.Controls.Add(Me.picSampleItem)
        Me.pnlItemSample.ForeColor = System.Drawing.Color.Black
        Me.pnlItemSample.Location = New System.Drawing.Point(210, 3)
        Me.pnlItemSample.Name = "pnlItemSample"
        Me.pnlItemSample.Size = New System.Drawing.Size(201, 281)
        Me.pnlItemSample.TabIndex = 19
        Me.pnlItemSample.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(3, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 21)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "₱800 • 6 Available"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 41)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Ordinary Foldable Medium"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblItemCount
        '
        Me.lblItemCount.Font = New System.Drawing.Font("Proxima Nova Lt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblItemCount.Location = New System.Drawing.Point(695, 142)
        Me.lblItemCount.Name = "lblItemCount"
        Me.lblItemCount.Size = New System.Drawing.Size(182, 20)
        Me.lblItemCount.TabIndex = 26
        Me.lblItemCount.Text = "00 All Result"
        Me.lblItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItems
        '
        Me.lblItems.Font = New System.Drawing.Font("Proxima Nova Lt", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(649, 113)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(233, 29)
        Me.lblItems.TabIndex = 25
        Me.lblItems.Text = "Choose Category"
        Me.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddNew
        '
        Me.btnAddNew.Animated = True
        Me.btnAddNew.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNew.BorderColor = System.Drawing.Color.LightGray
        Me.btnAddNew.BorderRadius = 8
        Me.btnAddNew.BorderThickness = 1
        Me.btnAddNew.CheckedState.Parent = Me.btnAddNew
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.CustomImages.Parent = Me.btnAddNew
        Me.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddNew.DisabledState.Parent = Me.btnAddNew
        Me.btnAddNew.FillColor = System.Drawing.Color.White
        Me.btnAddNew.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnAddNew.ForeColor = System.Drawing.Color.Black
        Me.btnAddNew.HoverState.Parent = Me.btnAddNew
        Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
        Me.btnAddNew.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnAddNew.ImageSize = New System.Drawing.Size(200, 281)
        Me.btnAddNew.Location = New System.Drawing.Point(3, 3)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.ShadowDecoration.Parent = Me.btnAddNew
        Me.btnAddNew.Size = New System.Drawing.Size(201, 281)
        Me.btnAddNew.TabIndex = 18
        Me.btnAddNew.TextOffset = New System.Drawing.Point(-8, 20)
        Me.btnAddNew.UseTransparentBackground = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.PeachPuff
        Me.Guna2Button1.Font = New System.Drawing.Font("Proxima Nova Rg", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Button1.Location = New System.Drawing.Point(-1, 227)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(201, 53)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Edit Item"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'picSamepleStock
        '
        Me.picSamepleStock.BackColor = System.Drawing.Color.Transparent
        Me.picSamepleStock.Image = Global.MilkTeaOrderAndInventorySystem.My.Resources.Resources.outofstock
        Me.picSamepleStock.ImageRotate = 0!
        Me.picSamepleStock.Location = New System.Drawing.Point(45, 18)
        Me.picSamepleStock.Name = "picSamepleStock"
        Me.picSamepleStock.ShadowDecoration.Parent = Me.picSamepleStock
        Me.picSamepleStock.Size = New System.Drawing.Size(106, 106)
        Me.picSamepleStock.TabIndex = 58
        Me.picSamepleStock.TabStop = False
        Me.picSamepleStock.UseTransparentBackground = True
        '
        'picSampleItem
        '
        Me.picSampleItem.BackColor = System.Drawing.Color.Transparent
        Me.picSampleItem.Image = CType(resources.GetObject("picSampleItem.Image"), System.Drawing.Image)
        Me.picSampleItem.ImageRotate = 0!
        Me.picSampleItem.Location = New System.Drawing.Point(45, 18)
        Me.picSampleItem.Name = "picSampleItem"
        Me.picSampleItem.ShadowDecoration.Parent = Me.picSampleItem
        Me.picSampleItem.Size = New System.Drawing.Size(106, 106)
        Me.picSampleItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSampleItem.TabIndex = 0
        Me.picSampleItem.TabStop = False
        Me.picSampleItem.UseTransparentBackground = True
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(417, 3)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(8, 8)
        Me.Guna2CirclePictureBox1.TabIndex = 20
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2PictureBox13
        '
        Me.Guna2PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox13.Image = CType(resources.GetObject("Guna2PictureBox13.Image"), System.Drawing.Image)
        Me.Guna2PictureBox13.ImageRotate = 0!
        Me.Guna2PictureBox13.Location = New System.Drawing.Point(-108, 168)
        Me.Guna2PictureBox13.Name = "Guna2PictureBox13"
        Me.Guna2PictureBox13.ShadowDecoration.Parent = Me.Guna2PictureBox13
        Me.Guna2PictureBox13.Size = New System.Drawing.Size(1150, 32)
        Me.Guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox13.TabIndex = 23
        Me.Guna2PictureBox13.TabStop = False
        Me.Guna2PictureBox13.UseTransparentBackground = True
        '
        'btnCage
        '
        Me.btnCage.Animated = True
        Me.btnCage.BackColor = System.Drawing.Color.Transparent
        Me.btnCage.BorderColor = System.Drawing.Color.LightGray
        Me.btnCage.BorderRadius = 8
        Me.btnCage.BorderThickness = 1
        Me.btnCage.CheckedState.Parent = Me.btnCage
        Me.btnCage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCage.CustomImages.Parent = Me.btnCage
        Me.btnCage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCage.DisabledState.Parent = Me.btnCage
        Me.btnCage.FillColor = System.Drawing.Color.White
        Me.btnCage.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnCage.ForeColor = System.Drawing.Color.Black
        Me.btnCage.HoverState.Parent = Me.btnCage
        Me.btnCage.Image = CType(resources.GetObject("btnCage.Image"), System.Drawing.Image)
        Me.btnCage.ImageOffset = New System.Drawing.Point(8, -11)
        Me.btnCage.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCage.Location = New System.Drawing.Point(444, 72)
        Me.btnCage.Name = "btnCage"
        Me.btnCage.ShadowDecoration.Parent = Me.btnCage
        Me.btnCage.Size = New System.Drawing.Size(80, 90)
        Me.btnCage.TabIndex = 21
        Me.btnCage.Text = "Cage"
        Me.btnCage.TextOffset = New System.Drawing.Point(-8, 20)
        Me.btnCage.UseTransparentBackground = True
        '
        'btnMedicine
        '
        Me.btnMedicine.Animated = True
        Me.btnMedicine.BackColor = System.Drawing.Color.Transparent
        Me.btnMedicine.BorderColor = System.Drawing.Color.LightGray
        Me.btnMedicine.BorderRadius = 8
        Me.btnMedicine.BorderThickness = 1
        Me.btnMedicine.CheckedState.Parent = Me.btnMedicine
        Me.btnMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedicine.CustomImages.Parent = Me.btnMedicine
        Me.btnMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMedicine.DisabledState.Parent = Me.btnMedicine
        Me.btnMedicine.FillColor = System.Drawing.Color.White
        Me.btnMedicine.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnMedicine.ForeColor = System.Drawing.Color.Black
        Me.btnMedicine.HoverState.Parent = Me.btnMedicine
        Me.btnMedicine.Image = CType(resources.GetObject("btnMedicine.Image"), System.Drawing.Image)
        Me.btnMedicine.ImageOffset = New System.Drawing.Point(14, -11)
        Me.btnMedicine.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMedicine.Location = New System.Drawing.Point(341, 72)
        Me.btnMedicine.Name = "btnMedicine"
        Me.btnMedicine.ShadowDecoration.Parent = Me.btnMedicine
        Me.btnMedicine.Size = New System.Drawing.Size(80, 90)
        Me.btnMedicine.TabIndex = 20
        Me.btnMedicine.Text = "Medicine"
        Me.btnMedicine.TextOffset = New System.Drawing.Point(-8, 20)
        Me.btnMedicine.UseTransparentBackground = True
        '
        'btnToiletries
        '
        Me.btnToiletries.Animated = True
        Me.btnToiletries.BackColor = System.Drawing.Color.Transparent
        Me.btnToiletries.BorderColor = System.Drawing.Color.LightGray
        Me.btnToiletries.BorderRadius = 8
        Me.btnToiletries.BorderThickness = 1
        Me.btnToiletries.CheckedState.Parent = Me.btnToiletries
        Me.btnToiletries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToiletries.CustomImages.Parent = Me.btnToiletries
        Me.btnToiletries.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToiletries.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToiletries.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToiletries.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToiletries.DisabledState.Parent = Me.btnToiletries
        Me.btnToiletries.FillColor = System.Drawing.Color.White
        Me.btnToiletries.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnToiletries.ForeColor = System.Drawing.Color.Black
        Me.btnToiletries.HoverState.Parent = Me.btnToiletries
        Me.btnToiletries.Image = CType(resources.GetObject("btnToiletries.Image"), System.Drawing.Image)
        Me.btnToiletries.ImageOffset = New System.Drawing.Point(14, -11)
        Me.btnToiletries.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnToiletries.Location = New System.Drawing.Point(239, 72)
        Me.btnToiletries.Name = "btnToiletries"
        Me.btnToiletries.ShadowDecoration.Parent = Me.btnToiletries
        Me.btnToiletries.Size = New System.Drawing.Size(80, 90)
        Me.btnToiletries.TabIndex = 19
        Me.btnToiletries.Text = "Toiletries"
        Me.btnToiletries.TextOffset = New System.Drawing.Point(-8, 20)
        Me.btnToiletries.UseTransparentBackground = True
        '
        'btnLeash
        '
        Me.btnLeash.Animated = True
        Me.btnLeash.BackColor = System.Drawing.Color.Transparent
        Me.btnLeash.BorderColor = System.Drawing.Color.LightGray
        Me.btnLeash.BorderRadius = 8
        Me.btnLeash.BorderThickness = 1
        Me.btnLeash.CheckedState.Parent = Me.btnLeash
        Me.btnLeash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLeash.CustomImages.Parent = Me.btnLeash
        Me.btnLeash.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLeash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLeash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLeash.DisabledState.Parent = Me.btnLeash
        Me.btnLeash.FillColor = System.Drawing.Color.White
        Me.btnLeash.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnLeash.ForeColor = System.Drawing.Color.Black
        Me.btnLeash.HoverState.Parent = Me.btnLeash
        Me.btnLeash.Image = CType(resources.GetObject("btnLeash.Image"), System.Drawing.Image)
        Me.btnLeash.ImageOffset = New System.Drawing.Point(10, -11)
        Me.btnLeash.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLeash.Location = New System.Drawing.Point(136, 72)
        Me.btnLeash.Name = "btnLeash"
        Me.btnLeash.ShadowDecoration.Parent = Me.btnLeash
        Me.btnLeash.Size = New System.Drawing.Size(80, 90)
        Me.btnLeash.TabIndex = 18
        Me.btnLeash.Text = "Leash"
        Me.btnLeash.TextOffset = New System.Drawing.Point(-8, 20)
        Me.btnLeash.UseTransparentBackground = True
        '
        'btnFoods
        '
        Me.btnFoods.Animated = True
        Me.btnFoods.BackColor = System.Drawing.Color.Transparent
        Me.btnFoods.BorderColor = System.Drawing.Color.LightGray
        Me.btnFoods.BorderRadius = 8
        Me.btnFoods.BorderThickness = 1
        Me.btnFoods.CheckedState.Parent = Me.btnFoods
        Me.btnFoods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFoods.CustomImages.Parent = Me.btnFoods
        Me.btnFoods.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFoods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFoods.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFoods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFoods.DisabledState.Parent = Me.btnFoods
        Me.btnFoods.FillColor = System.Drawing.Color.White
        Me.btnFoods.Font = New System.Drawing.Font("Proxima Nova Rg", 9.749999!)
        Me.btnFoods.ForeColor = System.Drawing.Color.Black
        Me.btnFoods.HoverState.Parent = Me.btnFoods
        Me.btnFoods.Image = CType(resources.GetObject("btnFoods.Image"), System.Drawing.Image)
        Me.btnFoods.ImageOffset = New System.Drawing.Point(9, -11)
        Me.btnFoods.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFoods.Location = New System.Drawing.Point(32, 72)
        Me.btnFoods.Name = "btnFoods"
        Me.btnFoods.ShadowDecoration.Parent = Me.btnFoods
        Me.btnFoods.Size = New System.Drawing.Size(80, 90)
        Me.btnFoods.TabIndex = 17
        Me.btnFoods.Text = "Food"
        Me.btnFoods.TextOffset = New System.Drawing.Point(-8, 20)
        Me.btnFoods.UseTransparentBackground = True
        '
        'ProductsManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 683)
        Me.Controls.Add(Me.flpManage)
        Me.Controls.Add(Me.Guna2PictureBox13)
        Me.Controls.Add(Me.lblItemCount)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.btnCage)
        Me.Controls.Add(Me.btnMedicine)
        Me.Controls.Add(Me.btnToiletries)
        Me.Controls.Add(Me.btnLeash)
        Me.Controls.Add(Me.btnFoods)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductsManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductsManagement"
        Me.flpManage.ResumeLayout(False)
        Me.pnlItemSample.ResumeLayout(False)
        CType(Me.picSamepleStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSampleItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMedicine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnToiletries As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLeash As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFoods As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Guna2PictureBox13 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents flpManage As FlowLayoutPanel
    Friend WithEvents btnAddNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlItemSample As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents picSampleItem As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblItemCount As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents picSamepleStock As Guna.UI2.WinForms.Guna2PictureBox
End Class
