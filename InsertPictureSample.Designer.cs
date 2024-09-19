using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InsertPictureSample : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertPictureSample));
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlNavig = new Guna.UI2.WinForms.Guna2Panel();
            Guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            btnInsert = new Guna.UI2.WinForms.Guna2Button();
            btnInsert.Click += new EventHandler(btnInsert_Click);
            setPicture = new Guna.UI2.WinForms.Guna2CircleButton();
            setPicture.MouseEnter += new EventHandler(setPicture_MouseEnter);
            setPicture.MouseLeave += new EventHandler(setPicture_MouseLeave);
            setPicture.Click += new EventHandler(setPicture_Click);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).BeginInit();
            SuspendLayout();
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // pnlNavig
            // 
            pnlNavig.BackColor = SystemColors.Control;
            pnlNavig.Controls.Add(Guna2PictureBox7);
            pnlNavig.Controls.Add(Guna2ControlBox3);
            pnlNavig.Controls.Add(Guna2ControlBox4);
            pnlNavig.Location = new Point(-2, 0);
            pnlNavig.Name = "pnlNavig";
            pnlNavig.ShadowDecoration.Parent = pnlNavig;
            pnlNavig.Size = new Size(375, 29);
            pnlNavig.TabIndex = 22;
            // 
            // Guna2PictureBox7
            // 
            Guna2PictureBox7.BackColor = Color.Transparent;
            Guna2PictureBox7.FillColor = Color.Transparent;
            Guna2PictureBox7.Image = (Image)resources.GetObject("Guna2PictureBox7.Image");
            Guna2PictureBox7.ImageRotate = 0f;
            Guna2PictureBox7.Location = new Point(0, 0);
            Guna2PictureBox7.Name = "Guna2PictureBox7";
            Guna2PictureBox7.ShadowDecoration.Parent = Guna2PictureBox7;
            Guna2PictureBox7.Size = new Size(32, 30);
            Guna2PictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox7.TabIndex = 12;
            Guna2PictureBox7.TabStop = false;
            Guna2PictureBox7.UseTransparentBackground = true;
            // 
            // Guna2ControlBox3
            // 
            Guna2ControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Guna2ControlBox3.FillColor = Color.Transparent;
            Guna2ControlBox3.HoverState.Parent = Guna2ControlBox3;
            Guna2ControlBox3.IconColor = Color.Black;
            Guna2ControlBox3.Location = new Point(279, 0);
            Guna2ControlBox3.Name = "Guna2ControlBox3";
            Guna2ControlBox3.ShadowDecoration.Parent = Guna2ControlBox3;
            Guna2ControlBox3.Size = new Size(45, 29);
            Guna2ControlBox3.TabIndex = 2;
            // 
            // Guna2ControlBox4
            // 
            Guna2ControlBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox4.FillColor = Color.Transparent;
            Guna2ControlBox4.HoverState.Parent = Guna2ControlBox4;
            Guna2ControlBox4.IconColor = Color.Black;
            Guna2ControlBox4.Location = new Point(330, 0);
            Guna2ControlBox4.Name = "Guna2ControlBox4";
            Guna2ControlBox4.ShadowDecoration.Parent = Guna2ControlBox4;
            Guna2ControlBox4.Size = new Size(45, 29);
            Guna2ControlBox4.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.Parent = txtEmail;
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.FocusedState.Parent = txtEmail;
            txtEmail.Font = new Font("Segoe UI", 9.0f);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.HoverState.Parent = txtEmail;
            txtEmail.Location = new Point(80, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.Parent = txtEmail;
            txtEmail.Size = new Size(200, 36);
            txtEmail.TabIndex = 23;
            // 
            // btnInsert
            // 
            btnInsert.Animated = true;
            btnInsert.BackColor = Color.Transparent;
            btnInsert.BorderRadius = 6;
            btnInsert.CheckedState.Parent = btnInsert;
            btnInsert.CustomImages.Parent = btnInsert;
            btnInsert.DisabledState.BorderColor = Color.DarkGray;
            btnInsert.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInsert.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInsert.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInsert.DisabledState.Parent = btnInsert;
            btnInsert.Font = new Font("Segoe UI", 9.0f);
            btnInsert.ForeColor = Color.White;
            btnInsert.HoverState.Parent = btnInsert;
            btnInsert.Location = new Point(89, 347);
            btnInsert.Name = "btnInsert";
            btnInsert.ShadowDecoration.Parent = btnInsert;
            btnInsert.Size = new Size(180, 45);
            btnInsert.TabIndex = 24;
            btnInsert.Text = "OKAY";
            btnInsert.UseTransparentBackground = true;
            // 
            // setPicture
            // 
            setPicture.Animated = true;
            setPicture.BackColor = Color.Transparent;
            setPicture.BorderColor = Color.Transparent;
            setPicture.CheckedState.Parent = setPicture;
            setPicture.Cursor = Cursors.Hand;
            setPicture.CustomImages.Image = (Image)resources.GetObject("resource.Image");
            setPicture.CustomImages.ImageAlign = HorizontalAlignment.Center;
            setPicture.CustomImages.ImageSize = new Size(127, 130);
            setPicture.CustomImages.Parent = setPicture;
            setPicture.DisabledState.BorderColor = Color.DarkGray;
            setPicture.DisabledState.CustomBorderColor = Color.DarkGray;
            setPicture.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            setPicture.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            setPicture.DisabledState.Parent = setPicture;
            setPicture.FillColor = Color.Transparent;
            setPicture.Font = new Font("Proxima Nova Rg", 12.0f);
            setPicture.ForeColor = Color.Transparent;
            setPicture.HoverState.Parent = setPicture;
            setPicture.ImageSize = new Size(127, 130);
            setPicture.Location = new Point(112, 76);
            setPicture.Name = "setPicture";
            setPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            setPicture.ShadowDecoration.Parent = setPicture;
            setPicture.Size = new Size(134, 138);
            setPicture.TabIndex = 27;
            setPicture.UseTransparentBackground = true;
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.TargetControl = pnlNavig;
            // 
            // InsertPictureSample
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 453);
            Controls.Add(setPicture);
            Controls.Add(btnInsert);
            Controls.Add(txtEmail);
            Controls.Add(pnlNavig);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InsertPictureSample";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertPictureSample";
            pnlNavig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).EndInit();
            Load += new EventHandler(InsertPictureSample_Load);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2Panel pnlNavig;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox3;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox4;
        internal Guna.UI2.WinForms.Guna2Button btnInsert;
        internal Guna.UI2.WinForms.Guna2TextBox txtEmail;
        internal Guna.UI2.WinForms.Guna2CircleButton setPicture;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
    }
}