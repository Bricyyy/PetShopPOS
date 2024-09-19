using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ProductsManagement : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsManagement));
            lblTitle = new Label();
            flpManage = new FlowLayoutPanel();
            pnlItemSample = new Panel();
            Label1 = new Label();
            Label3 = new Label();
            lblItemCount = new Label();
            lblItems = new Label();
            btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            btnAddNew.Click += new EventHandler(btnAddNew_Click);
            Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            picSamepleStock = new Guna.UI2.WinForms.Guna2PictureBox();
            picSampleItem = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            Guna2PictureBox13 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnCage = new Guna.UI2.WinForms.Guna2Button();
            btnCage.Click += new EventHandler(btnCage_Click);
            btnMedicine = new Guna.UI2.WinForms.Guna2Button();
            btnMedicine.Click += new EventHandler(btnMedicine_Click);
            btnToiletries = new Guna.UI2.WinForms.Guna2Button();
            btnToiletries.Click += new EventHandler(btnToiletries_Click);
            btnLeash = new Guna.UI2.WinForms.Guna2Button();
            btnLeash.Click += new EventHandler(btnLeash_Click);
            btnFoods = new Guna.UI2.WinForms.Guna2Button();
            btnFoods.Click += new EventHandler(btnFoods_Click);
            flpManage.SuspendLayout();
            pnlItemSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSamepleStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSampleItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox13).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Proxima Nova Lt", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(27, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(257, 29);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Products Management";
            // 
            // flpManage
            // 
            flpManage.AutoScroll = true;
            flpManage.Controls.Add(btnAddNew);
            flpManage.Controls.Add(pnlItemSample);
            flpManage.Controls.Add(Guna2CirclePictureBox1);
            flpManage.Location = new Point(22, 206);
            flpManage.Name = "flpManage";
            flpManage.Size = new Size(860, 454);
            flpManage.TabIndex = 24;
            // 
            // pnlItemSample
            // 
            pnlItemSample.BorderStyle = BorderStyle.FixedSingle;
            pnlItemSample.Controls.Add(picSamepleStock);
            pnlItemSample.Controls.Add(Label1);
            pnlItemSample.Controls.Add(Label3);
            pnlItemSample.Controls.Add(Guna2Button1);
            pnlItemSample.Controls.Add(picSampleItem);
            pnlItemSample.ForeColor = Color.Black;
            pnlItemSample.Location = new Point(210, 3);
            pnlItemSample.Name = "pnlItemSample";
            pnlItemSample.Size = new Size(201, 281);
            pnlItemSample.TabIndex = 19;
            pnlItemSample.Visible = false;
            // 
            // Label1
            // 
            Label1.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ControlDarkDark;
            Label1.Location = new Point(3, 190);
            Label1.Name = "Label1";
            Label1.Size = new Size(193, 21);
            Label1.TabIndex = 57;
            Label1.Text = "₱800 • 6 Available";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Black;
            Label3.Location = new Point(32, 137);
            Label3.Name = "Label3";
            Label3.Size = new Size(133, 41);
            Label3.TabIndex = 56;
            Label3.Text = "Ordinary Foldable Medium";
            Label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblItemCount
            // 
            lblItemCount.Font = new Font("Proxima Nova Lt", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemCount.ForeColor = SystemColors.ControlDarkDark;
            lblItemCount.Location = new Point(695, 142);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(182, 20);
            lblItemCount.TabIndex = 26;
            lblItemCount.Text = "00 All Result";
            lblItemCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItems
            // 
            lblItems.Font = new Font("Proxima Nova Lt", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.Location = new Point(649, 113);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(233, 29);
            lblItems.TabIndex = 25;
            lblItems.Text = "Choose Category";
            lblItems.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddNew
            // 
            btnAddNew.Animated = true;
            btnAddNew.BackColor = Color.Transparent;
            btnAddNew.BorderColor = Color.LightGray;
            btnAddNew.BorderRadius = 8;
            btnAddNew.BorderThickness = 1;
            btnAddNew.CheckedState.Parent = btnAddNew;
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.CustomImages.Parent = btnAddNew;
            btnAddNew.DisabledState.BorderColor = Color.DarkGray;
            btnAddNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNew.DisabledState.Parent = btnAddNew;
            btnAddNew.FillColor = Color.White;
            btnAddNew.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.HoverState.Parent = btnAddNew;
            btnAddNew.Image = (Image)resources.GetObject("btnAddNew.Image");
            btnAddNew.ImageOffset = new Point(1, 0);
            btnAddNew.ImageSize = new Size(200, 281);
            btnAddNew.Location = new Point(3, 3);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.ShadowDecoration.Parent = btnAddNew;
            btnAddNew.Size = new Size(201, 281);
            btnAddNew.TabIndex = 18;
            btnAddNew.TextOffset = new Point(-8, 20);
            btnAddNew.UseTransparentBackground = true;
            // 
            // Guna2Button1
            // 
            Guna2Button1.Animated = true;
            Guna2Button1.BackColor = Color.Transparent;
            Guna2Button1.CheckedState.Parent = Guna2Button1;
            Guna2Button1.Cursor = Cursors.Hand;
            Guna2Button1.CustomImages.Parent = Guna2Button1;
            Guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button1.DisabledState.Parent = Guna2Button1;
            Guna2Button1.FillColor = Color.PeachPuff;
            Guna2Button1.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Bold);
            Guna2Button1.ForeColor = Color.FromArgb(255, 152, 19);
            Guna2Button1.HoverState.Parent = Guna2Button1;
            Guna2Button1.Image = (Image)resources.GetObject("Guna2Button1.Image");
            Guna2Button1.ImageSize = new Size(23, 23);
            Guna2Button1.Location = new Point(-1, 227);
            Guna2Button1.Name = "Guna2Button1";
            Guna2Button1.ShadowDecoration.Parent = Guna2Button1;
            Guna2Button1.Size = new Size(201, 53);
            Guna2Button1.TabIndex = 1;
            Guna2Button1.Text = "Edit Item";
            Guna2Button1.UseTransparentBackground = true;
            // 
            // picSamepleStock
            // 
            picSamepleStock.BackColor = Color.Transparent;
            picSamepleStock.Image = My.Resources.Resources.outofstock;
            picSamepleStock.ImageRotate = 0f;
            picSamepleStock.Location = new Point(45, 18);
            picSamepleStock.Name = "picSamepleStock";
            picSamepleStock.ShadowDecoration.Parent = picSamepleStock;
            picSamepleStock.Size = new Size(106, 106);
            picSamepleStock.TabIndex = 58;
            picSamepleStock.TabStop = false;
            picSamepleStock.UseTransparentBackground = true;
            // 
            // picSampleItem
            // 
            picSampleItem.BackColor = Color.Transparent;
            picSampleItem.Image = (Image)resources.GetObject("picSampleItem.Image");
            picSampleItem.ImageRotate = 0f;
            picSampleItem.Location = new Point(45, 18);
            picSampleItem.Name = "picSampleItem";
            picSampleItem.ShadowDecoration.Parent = picSampleItem;
            picSampleItem.Size = new Size(106, 106);
            picSampleItem.SizeMode = PictureBoxSizeMode.Zoom;
            picSampleItem.TabIndex = 0;
            picSampleItem.TabStop = false;
            picSampleItem.UseTransparentBackground = true;
            // 
            // Guna2CirclePictureBox1
            // 
            Guna2CirclePictureBox1.ImageRotate = 0f;
            Guna2CirclePictureBox1.Location = new Point(417, 3);
            Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1";
            Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Guna2CirclePictureBox1.ShadowDecoration.Parent = Guna2CirclePictureBox1;
            Guna2CirclePictureBox1.Size = new Size(8, 8);
            Guna2CirclePictureBox1.TabIndex = 20;
            Guna2CirclePictureBox1.TabStop = false;
            // 
            // Guna2PictureBox13
            // 
            Guna2PictureBox13.BackColor = Color.Transparent;
            Guna2PictureBox13.Image = (Image)resources.GetObject("Guna2PictureBox13.Image");
            Guna2PictureBox13.ImageRotate = 0f;
            Guna2PictureBox13.Location = new Point(-108, 168);
            Guna2PictureBox13.Name = "Guna2PictureBox13";
            Guna2PictureBox13.ShadowDecoration.Parent = Guna2PictureBox13;
            Guna2PictureBox13.Size = new Size(1150, 32);
            Guna2PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox13.TabIndex = 23;
            Guna2PictureBox13.TabStop = false;
            Guna2PictureBox13.UseTransparentBackground = true;
            // 
            // btnCage
            // 
            btnCage.Animated = true;
            btnCage.BackColor = Color.Transparent;
            btnCage.BorderColor = Color.LightGray;
            btnCage.BorderRadius = 8;
            btnCage.BorderThickness = 1;
            btnCage.CheckedState.Parent = btnCage;
            btnCage.Cursor = Cursors.Hand;
            btnCage.CustomImages.Parent = btnCage;
            btnCage.DisabledState.BorderColor = Color.DarkGray;
            btnCage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCage.DisabledState.Parent = btnCage;
            btnCage.FillColor = Color.White;
            btnCage.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnCage.ForeColor = Color.Black;
            btnCage.HoverState.Parent = btnCage;
            btnCage.Image = (Image)resources.GetObject("btnCage.Image");
            btnCage.ImageOffset = new Point(8, -11);
            btnCage.ImageSize = new Size(30, 30);
            btnCage.Location = new Point(444, 72);
            btnCage.Name = "btnCage";
            btnCage.ShadowDecoration.Parent = btnCage;
            btnCage.Size = new Size(80, 90);
            btnCage.TabIndex = 21;
            btnCage.Text = "Cage";
            btnCage.TextOffset = new Point(-8, 20);
            btnCage.UseTransparentBackground = true;
            // 
            // btnMedicine
            // 
            btnMedicine.Animated = true;
            btnMedicine.BackColor = Color.Transparent;
            btnMedicine.BorderColor = Color.LightGray;
            btnMedicine.BorderRadius = 8;
            btnMedicine.BorderThickness = 1;
            btnMedicine.CheckedState.Parent = btnMedicine;
            btnMedicine.Cursor = Cursors.Hand;
            btnMedicine.CustomImages.Parent = btnMedicine;
            btnMedicine.DisabledState.BorderColor = Color.DarkGray;
            btnMedicine.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMedicine.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMedicine.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMedicine.DisabledState.Parent = btnMedicine;
            btnMedicine.FillColor = Color.White;
            btnMedicine.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnMedicine.ForeColor = Color.Black;
            btnMedicine.HoverState.Parent = btnMedicine;
            btnMedicine.Image = (Image)resources.GetObject("btnMedicine.Image");
            btnMedicine.ImageOffset = new Point(14, -11);
            btnMedicine.ImageSize = new Size(30, 30);
            btnMedicine.Location = new Point(341, 72);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.ShadowDecoration.Parent = btnMedicine;
            btnMedicine.Size = new Size(80, 90);
            btnMedicine.TabIndex = 20;
            btnMedicine.Text = "Medicine";
            btnMedicine.TextOffset = new Point(-8, 20);
            btnMedicine.UseTransparentBackground = true;
            // 
            // btnToiletries
            // 
            btnToiletries.Animated = true;
            btnToiletries.BackColor = Color.Transparent;
            btnToiletries.BorderColor = Color.LightGray;
            btnToiletries.BorderRadius = 8;
            btnToiletries.BorderThickness = 1;
            btnToiletries.CheckedState.Parent = btnToiletries;
            btnToiletries.Cursor = Cursors.Hand;
            btnToiletries.CustomImages.Parent = btnToiletries;
            btnToiletries.DisabledState.BorderColor = Color.DarkGray;
            btnToiletries.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToiletries.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToiletries.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToiletries.DisabledState.Parent = btnToiletries;
            btnToiletries.FillColor = Color.White;
            btnToiletries.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnToiletries.ForeColor = Color.Black;
            btnToiletries.HoverState.Parent = btnToiletries;
            btnToiletries.Image = (Image)resources.GetObject("btnToiletries.Image");
            btnToiletries.ImageOffset = new Point(14, -11);
            btnToiletries.ImageSize = new Size(30, 30);
            btnToiletries.Location = new Point(239, 72);
            btnToiletries.Name = "btnToiletries";
            btnToiletries.ShadowDecoration.Parent = btnToiletries;
            btnToiletries.Size = new Size(80, 90);
            btnToiletries.TabIndex = 19;
            btnToiletries.Text = "Toiletries";
            btnToiletries.TextOffset = new Point(-8, 20);
            btnToiletries.UseTransparentBackground = true;
            // 
            // btnLeash
            // 
            btnLeash.Animated = true;
            btnLeash.BackColor = Color.Transparent;
            btnLeash.BorderColor = Color.LightGray;
            btnLeash.BorderRadius = 8;
            btnLeash.BorderThickness = 1;
            btnLeash.CheckedState.Parent = btnLeash;
            btnLeash.Cursor = Cursors.Hand;
            btnLeash.CustomImages.Parent = btnLeash;
            btnLeash.DisabledState.BorderColor = Color.DarkGray;
            btnLeash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLeash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLeash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLeash.DisabledState.Parent = btnLeash;
            btnLeash.FillColor = Color.White;
            btnLeash.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnLeash.ForeColor = Color.Black;
            btnLeash.HoverState.Parent = btnLeash;
            btnLeash.Image = (Image)resources.GetObject("btnLeash.Image");
            btnLeash.ImageOffset = new Point(10, -11);
            btnLeash.ImageSize = new Size(30, 30);
            btnLeash.Location = new Point(136, 72);
            btnLeash.Name = "btnLeash";
            btnLeash.ShadowDecoration.Parent = btnLeash;
            btnLeash.Size = new Size(80, 90);
            btnLeash.TabIndex = 18;
            btnLeash.Text = "Leash";
            btnLeash.TextOffset = new Point(-8, 20);
            btnLeash.UseTransparentBackground = true;
            // 
            // btnFoods
            // 
            btnFoods.Animated = true;
            btnFoods.BackColor = Color.Transparent;
            btnFoods.BorderColor = Color.LightGray;
            btnFoods.BorderRadius = 8;
            btnFoods.BorderThickness = 1;
            btnFoods.CheckedState.Parent = btnFoods;
            btnFoods.Cursor = Cursors.Hand;
            btnFoods.CustomImages.Parent = btnFoods;
            btnFoods.DisabledState.BorderColor = Color.DarkGray;
            btnFoods.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFoods.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFoods.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFoods.DisabledState.Parent = btnFoods;
            btnFoods.FillColor = Color.White;
            btnFoods.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnFoods.ForeColor = Color.Black;
            btnFoods.HoverState.Parent = btnFoods;
            btnFoods.Image = (Image)resources.GetObject("btnFoods.Image");
            btnFoods.ImageOffset = new Point(9, -11);
            btnFoods.ImageSize = new Size(30, 30);
            btnFoods.Location = new Point(32, 72);
            btnFoods.Name = "btnFoods";
            btnFoods.ShadowDecoration.Parent = btnFoods;
            btnFoods.Size = new Size(80, 90);
            btnFoods.TabIndex = 17;
            btnFoods.Text = "Food";
            btnFoods.TextOffset = new Point(-8, 20);
            btnFoods.UseTransparentBackground = true;
            // 
            // ProductsManagement
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 683);
            Controls.Add(flpManage);
            Controls.Add(Guna2PictureBox13);
            Controls.Add(lblItemCount);
            Controls.Add(lblTitle);
            Controls.Add(lblItems);
            Controls.Add(btnCage);
            Controls.Add(btnMedicine);
            Controls.Add(btnToiletries);
            Controls.Add(btnLeash);
            Controls.Add(btnFoods);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsManagement";
            flpManage.ResumeLayout(false);
            pnlItemSample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSamepleStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSampleItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox13).EndInit();
            Load += new EventHandler(ProductsManagement_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2Button btnCage;
        internal Guna.UI2.WinForms.Guna2Button btnMedicine;
        internal Guna.UI2.WinForms.Guna2Button btnToiletries;
        internal Guna.UI2.WinForms.Guna2Button btnLeash;
        internal Guna.UI2.WinForms.Guna2Button btnFoods;
        internal Label lblTitle;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox13;
        internal FlowLayoutPanel flpManage;
        internal Guna.UI2.WinForms.Guna2Button btnAddNew;
        internal Panel pnlItemSample;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2PictureBox picSampleItem;
        internal Label Label1;
        internal Label Label3;
        internal Label lblItemCount;
        internal Label lblItems;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox Guna2CirclePictureBox1;
        internal Guna.UI2.WinForms.Guna2PictureBox picSamepleStock;
    }
}