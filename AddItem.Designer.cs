using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddItem : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            itemPicture = new Guna.UI2.WinForms.Guna2Button();
            itemPicture.Click += new EventHandler(setPic_Click);
            lblItems = new Label();
            Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnCancel.Click += new EventHandler(btnDiscard_Click);
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            txtItemPrice = new Guna.UI2.WinForms.Guna2TextBox();
            txtItemPrice.TextChanged += new EventHandler(txtItemPrice_TextChanged);
            txtItemPrice.KeyPress += new KeyPressEventHandler(txtItemPrice_KeyPress);
            txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            txtItemName.TextChanged += new EventHandler(txtItemName_TextChanged);
            txtItemQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            txtItemQuantity.TextChanged += new EventHandler(txtItemQuantity_TextChanged);
            txtItemQuantity.KeyPress += new KeyPressEventHandler(txtItemQuantity_KeyPress);
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            test = new Label();
            lblChecker = new Label();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).BeginInit();
            SuspendLayout();
            // 
            // itemPicture
            // 
            itemPicture.Animated = true;
            itemPicture.BackColor = Color.Transparent;
            itemPicture.BorderRadius = 20;
            itemPicture.CheckedState.Parent = itemPicture;
            itemPicture.Cursor = Cursors.Hand;
            itemPicture.CustomImages.Parent = itemPicture;
            itemPicture.DisabledState.BorderColor = Color.DarkGray;
            itemPicture.DisabledState.CustomBorderColor = Color.DarkGray;
            itemPicture.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            itemPicture.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            itemPicture.DisabledState.Parent = itemPicture;
            itemPicture.FillColor = Color.White;
            itemPicture.Font = new Font("Segoe UI", 9.0f);
            itemPicture.ForeColor = Color.White;
            itemPicture.HoverState.Parent = itemPicture;
            itemPicture.Image = (Image)resources.GetObject("itemPicture.Image");
            itemPicture.ImageOffset = new Point(-1, -3);
            itemPicture.ImageSize = new Size(200, 200);
            itemPicture.Location = new Point(200, 91);
            itemPicture.Name = "itemPicture";
            itemPicture.ShadowDecoration.Parent = itemPicture;
            itemPicture.Size = new Size(157, 158);
            itemPicture.TabIndex = 0;
            itemPicture.UseTransparentBackground = true;
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Proxima Nova Lt", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.Location = new Point(25, 20);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(202, 29);
            lblItems.TabIndex = 19;
            lblItems.Text = "Add New Product";
            // 
            // Guna2PictureBox3
            // 
            Guna2PictureBox3.BackColor = Color.Transparent;
            Guna2PictureBox3.Image = (Image)resources.GetObject("Guna2PictureBox3.Image");
            Guna2PictureBox3.ImageRotate = 0f;
            Guna2PictureBox3.Location = new Point(-37, 52);
            Guna2PictureBox3.Name = "Guna2PictureBox3";
            Guna2PictureBox3.ShadowDecoration.Parent = Guna2PictureBox3;
            Guna2PictureBox3.Size = new Size(625, 20);
            Guna2PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox3.TabIndex = 52;
            Guna2PictureBox3.TabStop = false;
            Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // btnSave
            // 
            btnSave.Animated = true;
            btnSave.BackColor = Color.Transparent;
            btnSave.BorderRadius = 6;
            btnSave.CheckedState.Parent = btnSave;
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomImages.Parent = btnSave;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.DisabledState.Parent = btnSave;
            btnSave.FillColor = Color.FromArgb(255, 152, 19);
            btnSave.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.Parent = btnSave;
            btnSave.Location = new Point(282, 501);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.Parent = btnSave;
            btnSave.Size = new Size(141, 45);
            btnSave.TabIndex = 54;
            btnSave.Text = "Save Item";
            btnSave.UseTransparentBackground = true;
            // 
            // btnCancel
            // 
            btnCancel.Animated = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(255, 152, 19);
            btnCancel.BorderRadius = 6;
            btnCancel.BorderThickness = 2;
            btnCancel.CheckedState.Parent = btnCancel;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomImages.Parent = btnCancel;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.DisabledState.Parent = btnCancel;
            btnCancel.FillColor = Color.Empty;
            btnCancel.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(255, 152, 19);
            btnCancel.HoverState.Parent = btnCancel;
            btnCancel.Location = new Point(110, 501);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.Parent = btnCancel;
            btnCancel.Size = new Size(141, 45);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Cancel";
            btnCancel.UseTransparentBackground = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ControlDarkDark;
            Label1.Location = new Point(114, 306);
            Label1.Name = "Label1";
            Label1.Size = new Size(82, 18);
            Label1.TabIndex = 55;
            Label1.Text = "Item Name:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = SystemColors.ControlDarkDark;
            Label2.Location = new Point(121, 365);
            Label2.Name = "Label2";
            Label2.Size = new Size(75, 18);
            Label2.TabIndex = 56;
            Label2.Text = "Item Price:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = SystemColors.ControlDarkDark;
            Label3.Location = new Point(100, 426);
            Label3.Name = "Label3";
            Label3.Size = new Size(96, 18);
            Label3.TabIndex = 57;
            Label3.Text = "Item Quantity:";
            // 
            // txtItemPrice
            // 
            txtItemPrice.Animated = true;
            txtItemPrice.BorderRadius = 8;
            txtItemPrice.Cursor = Cursors.IBeam;
            txtItemPrice.DefaultText = "";
            txtItemPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtItemPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtItemPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtItemPrice.DisabledState.Parent = txtItemPrice;
            txtItemPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtItemPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemPrice.FocusedState.Parent = txtItemPrice;
            txtItemPrice.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtItemPrice.ForeColor = Color.Black;
            txtItemPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemPrice.HoverState.Parent = txtItemPrice;
            txtItemPrice.Location = new Point(209, 356);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.PasswordChar = '\0';
            txtItemPrice.PlaceholderText = "";
            txtItemPrice.SelectedText = "";
            txtItemPrice.ShadowDecoration.Parent = txtItemPrice;
            txtItemPrice.Size = new Size(227, 36);
            txtItemPrice.TabIndex = 59;
            // 
            // txtItemName
            // 
            txtItemName.Animated = true;
            txtItemName.BorderRadius = 8;
            txtItemName.Cursor = Cursors.IBeam;
            txtItemName.DefaultText = "";
            txtItemName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtItemName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtItemName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.DisabledState.Parent = txtItemName;
            txtItemName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtItemName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.FocusedState.Parent = txtItemName;
            txtItemName.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtItemName.ForeColor = Color.Black;
            txtItemName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemName.HoverState.Parent = txtItemName;
            txtItemName.Location = new Point(209, 297);
            txtItemName.Name = "txtItemName";
            txtItemName.PasswordChar = '\0';
            txtItemName.PlaceholderText = "";
            txtItemName.SelectedText = "";
            txtItemName.ShadowDecoration.Parent = txtItemName;
            txtItemName.Size = new Size(227, 36);
            txtItemName.TabIndex = 58;
            // 
            // txtItemQuantity
            // 
            txtItemQuantity.Animated = true;
            txtItemQuantity.BorderRadius = 8;
            txtItemQuantity.Cursor = Cursors.IBeam;
            txtItemQuantity.DefaultText = "";
            txtItemQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtItemQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtItemQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtItemQuantity.DisabledState.Parent = txtItemQuantity;
            txtItemQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtItemQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemQuantity.FocusedState.Parent = txtItemQuantity;
            txtItemQuantity.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtItemQuantity.ForeColor = Color.Black;
            txtItemQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtItemQuantity.HoverState.Parent = txtItemQuantity;
            txtItemQuantity.Location = new Point(209, 417);
            txtItemQuantity.Name = "txtItemQuantity";
            txtItemQuantity.PasswordChar = '\0';
            txtItemQuantity.PlaceholderText = "";
            txtItemQuantity.SelectedText = "";
            txtItemQuantity.ShadowDecoration.Parent = txtItemQuantity;
            txtItemQuantity.Size = new Size(227, 36);
            txtItemQuantity.TabIndex = 60;
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // test
            // 
            test.AutoSize = true;
            test.ForeColor = Color.White;
            test.Location = new Point(389, 155);
            test.Name = "test";
            test.Size = new Size(34, 13);
            test.TabIndex = 61;
            test.Text = "lbltest";
            // 
            // lblChecker
            // 
            lblChecker.AutoSize = true;
            lblChecker.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChecker.ForeColor = Color.IndianRed;
            lblChecker.Location = new Point(206, 456);
            lblChecker.Name = "lblChecker";
            lblChecker.Size = new Size(107, 13);
            lblChecker.TabIndex = 62;
            lblChecker.Text = "Fill out all the fields.";
            lblChecker.Visible = false;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(549, 573);
            Controls.Add(lblChecker);
            Controls.Add(test);
            Controls.Add(txtItemQuantity);
            Controls.Add(txtItemName);
            Controls.Add(txtItemPrice);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(Guna2PictureBox3);
            Controls.Add(lblItems);
            Controls.Add(itemPicture);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageItem";
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).EndInit();
            Load += new EventHandler(ManageItem_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2Button itemPicture;
        internal Label lblItems;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal Guna.UI2.WinForms.Guna2Button btnSave;
        internal Guna.UI2.WinForms.Guna2Button btnCancel;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox txtItemPrice;
        internal Guna.UI2.WinForms.Guna2TextBox txtItemName;
        internal Guna.UI2.WinForms.Guna2TextBox txtItemQuantity;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Label test;
        internal Label lblChecker;
    }
}