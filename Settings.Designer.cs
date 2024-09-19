using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Settings : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            pnlSettings = new Guna.UI2.WinForms.Guna2Panel();
            Guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            Label1 = new Label();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblUsername = new Label();
            picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btnSecurity = new Guna.UI2.WinForms.Guna2Button();
            btnSecurity.Click += new EventHandler(btnSecurity_Click);
            btnAddress = new Guna.UI2.WinForms.Guna2Button();
            btnAddress.Click += new EventHandler(btnAddress_Click);
            btnAccount = new Guna.UI2.WinForms.Guna2Button();
            btnAccount.Click += new EventHandler(btnAccount_Click);
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlSettingsMain = new Guna.UI2.WinForms.Guna2Panel();
            Guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // pnlSettings
            // 
            pnlSettings.BackColor = Color.White;
            pnlSettings.Controls.Add(Guna2PictureBox4);
            pnlSettings.Controls.Add(Guna2PictureBox2);
            pnlSettings.Controls.Add(Label1);
            pnlSettings.Controls.Add(Guna2PictureBox1);
            pnlSettings.Controls.Add(lblUsername);
            pnlSettings.Controls.Add(picProfile);
            pnlSettings.Controls.Add(btnSecurity);
            pnlSettings.Controls.Add(btnAddress);
            pnlSettings.Controls.Add(btnAccount);
            pnlSettings.Location = new Point(38, 34);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.ShadowDecoration.Parent = pnlSettings;
            pnlSettings.Size = new Size(245, 573);
            pnlSettings.TabIndex = 0;
            // 
            // Guna2PictureBox4
            // 
            Guna2PictureBox4.BackColor = Color.Transparent;
            Guna2PictureBox4.Image = (Image)resources.GetObject("Guna2PictureBox4.Image");
            Guna2PictureBox4.ImageRotate = 0f;
            Guna2PictureBox4.Location = new Point(-15, 354);
            Guna2PictureBox4.Name = "Guna2PictureBox4";
            Guna2PictureBox4.ShadowDecoration.Parent = Guna2PictureBox4;
            Guna2PictureBox4.Size = new Size(278, 15);
            Guna2PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox4.TabIndex = 27;
            Guna2PictureBox4.TabStop = false;
            Guna2PictureBox4.UseTransparentBackground = true;
            // 
            // Guna2PictureBox2
            // 
            Guna2PictureBox2.BackColor = Color.Transparent;
            Guna2PictureBox2.Image = (Image)resources.GetObject("Guna2PictureBox2.Image");
            Guna2PictureBox2.ImageRotate = 0f;
            Guna2PictureBox2.Location = new Point(-15, 132);
            Guna2PictureBox2.Name = "Guna2PictureBox2";
            Guna2PictureBox2.ShadowDecoration.Parent = Guna2PictureBox2;
            Guna2PictureBox2.Size = new Size(278, 10);
            Guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox2.TabIndex = 0;
            Guna2PictureBox2.TabStop = false;
            Guna2PictureBox2.UseTransparentBackground = true;
            // 
            // Label1
            // 
            Label1.Cursor = Cursors.Arrow;
            Label1.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ControlDarkDark;
            Label1.ImageAlign = ContentAlignment.MiddleLeft;
            Label1.Location = new Point(14, 32);
            Label1.Name = "Label1";
            Label1.Size = new Size(209, 72);
            Label1.TabIndex = 25;
            Label1.Text = "Manage your profile, address and password here in settings.";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(34, 379);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(167, 172);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 0;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(108, 32);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(115, 18);
            lblUsername.TabIndex = 21;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            lblUsername.Visible = false;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.Transparent;
            picProfile.Image = My.Resources.Resources.PersonIcon;
            picProfile.ImageRotate = 0f;
            picProfile.Location = new Point(17, 15);
            picProfile.Name = "picProfile";
            picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picProfile.ShadowDecoration.Parent = picProfile;
            picProfile.Size = new Size(76, 78);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 3;
            picProfile.TabStop = false;
            picProfile.UseTransparentBackground = true;
            picProfile.Visible = false;
            // 
            // btnSecurity
            // 
            btnSecurity.Animated = true;
            btnSecurity.BackColor = Color.Transparent;
            btnSecurity.CheckedState.Parent = btnSecurity;
            btnSecurity.Cursor = Cursors.Hand;
            btnSecurity.CustomImages.Parent = btnSecurity;
            btnSecurity.DisabledState.BorderColor = Color.DarkGray;
            btnSecurity.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSecurity.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSecurity.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSecurity.DisabledState.Parent = btnSecurity;
            btnSecurity.FillColor = Color.White;
            btnSecurity.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSecurity.ForeColor = Color.Black;
            btnSecurity.HoverState.Parent = btnSecurity;
            btnSecurity.Image = My.Resources.Resources.securityIconBlack;
            btnSecurity.Location = new Point(0, 286);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.ShadowDecoration.Parent = btnSecurity;
            btnSecurity.Size = new Size(245, 72);
            btnSecurity.TabIndex = 2;
            btnSecurity.Text = "Security";
            btnSecurity.UseTransparentBackground = true;
            // 
            // btnAddress
            // 
            btnAddress.Animated = true;
            btnAddress.BackColor = Color.Transparent;
            btnAddress.CheckedState.Parent = btnAddress;
            btnAddress.Cursor = Cursors.Hand;
            btnAddress.CustomImages.Parent = btnAddress;
            btnAddress.DisabledState.BorderColor = Color.DarkGray;
            btnAddress.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddress.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddress.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddress.DisabledState.Parent = btnAddress;
            btnAddress.FillColor = Color.White;
            btnAddress.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddress.ForeColor = Color.Black;
            btnAddress.HoverState.Parent = btnAddress;
            btnAddress.Image = My.Resources.Resources.addressIconBlack;
            btnAddress.Location = new Point(0, 214);
            btnAddress.Name = "btnAddress";
            btnAddress.ShadowDecoration.Parent = btnAddress;
            btnAddress.Size = new Size(245, 72);
            btnAddress.TabIndex = 1;
            btnAddress.Text = "My Address";
            btnAddress.UseTransparentBackground = true;
            // 
            // btnAccount
            // 
            btnAccount.Animated = true;
            btnAccount.BackColor = Color.Transparent;
            btnAccount.CheckedState.Parent = btnAccount;
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.CustomImages.Parent = btnAccount;
            btnAccount.DisabledState.BorderColor = Color.DarkGray;
            btnAccount.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAccount.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAccount.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAccount.DisabledState.Parent = btnAccount;
            btnAccount.FillColor = Color.White;
            btnAccount.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            btnAccount.ForeColor = Color.Black;
            btnAccount.HoverState.Parent = btnAccount;
            btnAccount.Image = My.Resources.Resources.personIconBlack;
            btnAccount.Location = new Point(0, 142);
            btnAccount.Name = "btnAccount";
            btnAccount.ShadowDecoration.Parent = btnAccount;
            btnAccount.Size = new Size(245, 72);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "My Account";
            btnAccount.UseTransparentBackground = true;
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.BorderRadius = 20;
            Guna2Elipse1.TargetControl = pnlSettings;
            // 
            // pnlSettingsMain
            // 
            pnlSettingsMain.BackColor = Color.White;
            pnlSettingsMain.Location = new Point(311, 34);
            pnlSettingsMain.Name = "pnlSettingsMain";
            pnlSettingsMain.ShadowDecoration.Parent = pnlSettingsMain;
            pnlSettingsMain.Size = new Size(549, 573);
            pnlSettingsMain.TabIndex = 3;
            // 
            // Guna2Elipse2
            // 
            Guna2Elipse2.BorderRadius = 20;
            Guna2Elipse2.TargetControl = pnlSettingsMain;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 644);
            Controls.Add(pnlSettingsMain);
            Controls.Add(pnlSettings);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            Load += new EventHandler(Settings_Load);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Panel pnlSettings;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2Button btnSecurity;
        internal Guna.UI2.WinForms.Guna2Button btnAddress;
        internal Guna.UI2.WinForms.Guna2Button btnAccount;
        internal Guna.UI2.WinForms.Guna2Panel pnlSettingsMain;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse2;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
        internal Label lblUsername;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Label Label1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox4;
    }
}