using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ChangePassword : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            Label8 = new Label();
            lblItems = new Label();
            Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblUsername = new Label();
            Label2 = new Label();
            txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtOldPass.TextChanged += new EventHandler(txtOldPass_TextChanged);
            Label1 = new Label();
            Label3 = new Label();
            txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtNewPass.TextChanged += new EventHandler(txtNewPass_TextChanged);
            txtConfirmNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtConfirmNewPass.TextChanged += new EventHandler(txtConfirmNewPass_TextChanged);
            btnChange = new Guna.UI2.WinForms.Guna2Button();
            btnChange.Click += new EventHandler(btnChange_Click);
            lblReset = new Label();
            lblReset.Click += new EventHandler(lblReset_Click);
            lblPassChecker = new Label();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.DimGray;
            Label8.Location = new Point(23, 48);
            Label8.Name = "Label8";
            Label8.Size = new Size(484, 18);
            Label8.TabIndex = 56;
            Label8.Text = "For your account's security, do not share your password with anyone else";
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Proxima Nova Lt", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.Location = new Point(21, 19);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(207, 29);
            lblItems.TabIndex = 55;
            lblItems.Text = "Change Password";
            // 
            // Guna2PictureBox3
            // 
            Guna2PictureBox3.BackColor = Color.Transparent;
            Guna2PictureBox3.Image = (Image)resources.GetObject("Guna2PictureBox3.Image");
            Guna2PictureBox3.ImageRotate = 0f;
            Guna2PictureBox3.Location = new Point(-39, 69);
            Guna2PictureBox3.Name = "Guna2PictureBox3";
            Guna2PictureBox3.ShadowDecoration.Parent = Guna2PictureBox3;
            Guna2PictureBox3.Size = new Size(625, 20);
            Guna2PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox3.TabIndex = 57;
            Guna2PictureBox3.TabStop = false;
            Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.Transparent;
            picProfile.Image = (Image)resources.GetObject("picProfile.Image");
            picProfile.ImageRotate = 0f;
            picProfile.Location = new Point(105, 124);
            picProfile.Name = "picProfile";
            picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picProfile.ShadowDecoration.Parent = picProfile;
            picProfile.Size = new Size(83, 85);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 58;
            picProfile.TabStop = false;
            picProfile.UseTransparentBackground = true;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.Font = new Font("Proxima Nova Lt", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(205, 150);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(178, 26);
            lblUsername.TabIndex = 59;
            lblUsername.Text = "(No username)";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Lt", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(73, 262);
            Label2.Name = "Label2";
            Label2.Size = new Size(115, 21);
            Label2.TabIndex = 61;
            Label2.Text = "Old Password";
            // 
            // txtOldPass
            // 
            txtOldPass.Animated = true;
            txtOldPass.BorderRadius = 8;
            txtOldPass.Cursor = Cursors.IBeam;
            txtOldPass.DefaultText = "";
            txtOldPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtOldPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtOldPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtOldPass.DisabledState.Parent = txtOldPass;
            txtOldPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtOldPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOldPass.FocusedState.Parent = txtOldPass;
            txtOldPass.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtOldPass.ForeColor = Color.Black;
            txtOldPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtOldPass.HoverState.Parent = txtOldPass;
            txtOldPass.Location = new Point(210, 249);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '\0';
            txtOldPass.PlaceholderText = "";
            txtOldPass.SelectedText = "";
            txtOldPass.ShadowDecoration.Parent = txtOldPass;
            txtOldPass.Size = new Size(264, 44);
            txtOldPass.TabIndex = 60;
            txtOldPass.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Proxima Nova Lt", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(66, 321);
            Label1.Name = "Label1";
            Label1.Size = new Size(122, 21);
            Label1.TabIndex = 62;
            Label1.Text = "New Password";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Lt", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Black;
            Label3.Location = new Point(79, 370);
            Label3.Name = "Label3";
            Label3.Size = new Size(109, 42);
            Label3.TabIndex = 63;
            Label3.Text = "Confirm New" + '\r' + '\n' + "Password";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNewPass
            // 
            txtNewPass.Animated = true;
            txtNewPass.BorderRadius = 8;
            txtNewPass.Cursor = Cursors.IBeam;
            txtNewPass.DefaultText = "";
            txtNewPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNewPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNewPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNewPass.DisabledState.Parent = txtNewPass;
            txtNewPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNewPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewPass.FocusedState.Parent = txtNewPass;
            txtNewPass.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtNewPass.ForeColor = Color.Black;
            txtNewPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewPass.HoverState.Parent = txtNewPass;
            txtNewPass.Location = new Point(210, 309);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '\0';
            txtNewPass.PlaceholderText = "";
            txtNewPass.SelectedText = "";
            txtNewPass.ShadowDecoration.Parent = txtNewPass;
            txtNewPass.Size = new Size(264, 44);
            txtNewPass.TabIndex = 64;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtConfirmNewPass
            // 
            txtConfirmNewPass.Animated = true;
            txtConfirmNewPass.BorderRadius = 8;
            txtConfirmNewPass.Cursor = Cursors.IBeam;
            txtConfirmNewPass.DefaultText = "";
            txtConfirmNewPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmNewPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmNewPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmNewPass.DisabledState.Parent = txtConfirmNewPass;
            txtConfirmNewPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmNewPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmNewPass.FocusedState.Parent = txtConfirmNewPass;
            txtConfirmNewPass.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtConfirmNewPass.ForeColor = Color.Black;
            txtConfirmNewPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmNewPass.HoverState.Parent = txtConfirmNewPass;
            txtConfirmNewPass.Location = new Point(210, 370);
            txtConfirmNewPass.Name = "txtConfirmNewPass";
            txtConfirmNewPass.PasswordChar = '\0';
            txtConfirmNewPass.PlaceholderText = "";
            txtConfirmNewPass.SelectedText = "";
            txtConfirmNewPass.ShadowDecoration.Parent = txtConfirmNewPass;
            txtConfirmNewPass.Size = new Size(264, 44);
            txtConfirmNewPass.TabIndex = 65;
            txtConfirmNewPass.UseSystemPasswordChar = true;
            // 
            // btnChange
            // 
            btnChange.Animated = true;
            btnChange.BackColor = Color.Transparent;
            btnChange.BorderRadius = 6;
            btnChange.CheckedState.Parent = btnChange;
            btnChange.Cursor = Cursors.Hand;
            btnChange.CustomImages.Parent = btnChange;
            btnChange.DisabledState.BorderColor = Color.DarkGray;
            btnChange.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChange.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChange.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChange.DisabledState.Parent = btnChange;
            btnChange.FillColor = Color.FromArgb(255, 152, 19);
            btnChange.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold);
            btnChange.ForeColor = Color.White;
            btnChange.HoverState.Parent = btnChange;
            btnChange.Location = new Point(210, 457);
            btnChange.Name = "btnChange";
            btnChange.ShadowDecoration.Parent = btnChange;
            btnChange.Size = new Size(147, 35);
            btnChange.TabIndex = 66;
            btnChange.Text = "Change Password";
            btnChange.UseTransparentBackground = true;
            // 
            // lblReset
            // 
            lblReset.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblReset.AutoSize = true;
            lblReset.Cursor = Cursors.Hand;
            lblReset.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReset.ForeColor = SystemColors.Highlight;
            lblReset.Location = new Point(207, 506);
            lblReset.Name = "lblReset";
            lblReset.Size = new Size(102, 16);
            lblReset.TabIndex = 67;
            lblReset.Text = "Forgot Password";
            // 
            // lblPassChecker
            // 
            lblPassChecker.AutoSize = true;
            lblPassChecker.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassChecker.ForeColor = Color.IndianRed;
            lblPassChecker.Location = new Point(207, 422);
            lblPassChecker.Name = "lblPassChecker";
            lblPassChecker.Size = new Size(135, 13);
            lblPassChecker.TabIndex = 68;
            lblPassChecker.Text = "Password does not match.";
            lblPassChecker.Visible = false;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(549, 573);
            Controls.Add(lblPassChecker);
            Controls.Add(lblReset);
            Controls.Add(btnChange);
            Controls.Add(txtConfirmNewPass);
            Controls.Add(txtNewPass);
            Controls.Add(Label3);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(txtOldPass);
            Controls.Add(lblUsername);
            Controls.Add(picProfile);
            Controls.Add(Guna2PictureBox3);
            Controls.Add(Label8);
            Controls.Add(lblItems);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            Load += new EventHandler(ChangePassword_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal Label Label8;
        internal Label lblItems;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
        internal Label lblUsername;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2TextBox txtOldPass;
        internal Label Label1;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        internal Guna.UI2.WinForms.Guna2TextBox txtConfirmNewPass;
        internal Guna.UI2.WinForms.Guna2Button btnChange;
        internal Label lblReset;
        internal Label lblPassChecker;
    }
}