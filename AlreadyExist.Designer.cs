using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AlreadyExist : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AlreadyExist));
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlNavig = new Guna.UI2.WinForms.Guna2Panel();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblEmail = new Label();
            lblUname = new Label();
            lblReset = new Label();
            lblReset.Click += new EventHandler(lblReset_Click);
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            btnLogin.Click += new EventHandler(btnVerify_Click);
            Label3 = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            btnBack.Click += new EventHandler(btnBack_Click);
            Label2 = new Label();
            pnlNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox6).BeginInit();
            Guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.TargetControl = pnlNavig;
            // 
            // pnlNavig
            // 
            pnlNavig.BackColor = SystemColors.Control;
            pnlNavig.Controls.Add(Guna2PictureBox1);
            pnlNavig.Controls.Add(Guna2ControlBox2);
            pnlNavig.Controls.Add(Guna2ControlBox1);
            pnlNavig.Location = new Point(0, 0);
            pnlNavig.Name = "pnlNavig";
            pnlNavig.ShadowDecoration.Parent = pnlNavig;
            pnlNavig.Size = new Size(594, 29);
            pnlNavig.TabIndex = 0;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.FillColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(0, 0);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(32, 30);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 12;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Guna2ControlBox2
            // 
            Guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Guna2ControlBox2.FillColor = Color.Transparent;
            Guna2ControlBox2.HoverState.Parent = Guna2ControlBox2;
            Guna2ControlBox2.IconColor = Color.Black;
            Guna2ControlBox2.Location = new Point(498, 0);
            Guna2ControlBox2.Name = "Guna2ControlBox2";
            Guna2ControlBox2.ShadowDecoration.Parent = Guna2ControlBox2;
            Guna2ControlBox2.Size = new Size(45, 29);
            Guna2ControlBox2.TabIndex = 2;
            // 
            // Guna2ControlBox1
            // 
            Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox1.FillColor = Color.Transparent;
            Guna2ControlBox1.HoverState.Parent = Guna2ControlBox1;
            Guna2ControlBox1.IconColor = Color.Black;
            Guna2ControlBox1.Location = new Point(549, 0);
            Guna2ControlBox1.Name = "Guna2ControlBox1";
            Guna2ControlBox1.ShadowDecoration.Parent = Guna2ControlBox1;
            Guna2ControlBox1.Size = new Size(45, 29);
            Guna2ControlBox1.TabIndex = 1;
            // 
            // Guna2PictureBox5
            // 
            Guna2PictureBox5.BackColor = Color.Transparent;
            Guna2PictureBox5.FillColor = Color.Transparent;
            Guna2PictureBox5.Image = My.Resources.Resources.dog;
            Guna2PictureBox5.ImageRotate = 0f;
            Guna2PictureBox5.Location = new Point(255, 487);
            Guna2PictureBox5.Name = "Guna2PictureBox5";
            Guna2PictureBox5.ShadowDecoration.Parent = Guna2PictureBox5;
            Guna2PictureBox5.Size = new Size(61, 56);
            Guna2PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox5.TabIndex = 11;
            Guna2PictureBox5.TabStop = false;
            Guna2PictureBox5.UseTransparentBackground = true;
            // 
            // Guna2PictureBox4
            // 
            Guna2PictureBox4.BackColor = Color.Transparent;
            Guna2PictureBox4.FillColor = Color.Transparent;
            Guna2PictureBox4.Image = My.Resources.Resources.rabbit;
            Guna2PictureBox4.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            Guna2PictureBox4.ImageRotate = 0f;
            Guna2PictureBox4.Location = new Point(378, 499);
            Guna2PictureBox4.Name = "Guna2PictureBox4";
            Guna2PictureBox4.ShadowDecoration.Parent = Guna2PictureBox4;
            Guna2PictureBox4.Size = new Size(35, 44);
            Guna2PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox4.TabIndex = 10;
            Guna2PictureBox4.TabStop = false;
            Guna2PictureBox4.UseTransparentBackground = true;
            // 
            // Guna2PictureBox3
            // 
            Guna2PictureBox3.BackColor = Color.Transparent;
            Guna2PictureBox3.FillColor = Color.Transparent;
            Guna2PictureBox3.Image = My.Resources.Resources.trees;
            Guna2PictureBox3.ImageRotate = 0f;
            Guna2PictureBox3.Location = new Point(12, 453);
            Guna2PictureBox3.Name = "Guna2PictureBox3";
            Guna2PictureBox3.ShadowDecoration.Parent = Guna2PictureBox3;
            Guna2PictureBox3.Size = new Size(91, 90);
            Guna2PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox3.TabIndex = 9;
            Guna2PictureBox3.TabStop = false;
            Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // Guna2PictureBox2
            // 
            Guna2PictureBox2.BackColor = Color.Transparent;
            Guna2PictureBox2.FillColor = Color.Transparent;
            Guna2PictureBox2.Image = My.Resources.Resources.birds;
            Guna2PictureBox2.ImageRotate = 0f;
            Guna2PictureBox2.Location = new Point(487, 74);
            Guna2PictureBox2.Name = "Guna2PictureBox2";
            Guna2PictureBox2.ShadowDecoration.Parent = Guna2PictureBox2;
            Guna2PictureBox2.Size = new Size(96, 105);
            Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox2.TabIndex = 8;
            Guna2PictureBox2.TabStop = false;
            Guna2PictureBox2.UseTransparentBackground = true;
            // 
            // Guna2PictureBox6
            // 
            Guna2PictureBox6.BackColor = Color.Transparent;
            Guna2PictureBox6.FillColor = Color.Transparent;
            Guna2PictureBox6.Image = (Image)resources.GetObject("Guna2PictureBox6.Image");
            Guna2PictureBox6.ImageRotate = 0f;
            Guna2PictureBox6.Location = new Point(18, 180);
            Guna2PictureBox6.Name = "Guna2PictureBox6";
            Guna2PictureBox6.ShadowDecoration.Parent = Guna2PictureBox6;
            Guna2PictureBox6.Size = new Size(59, 58);
            Guna2PictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox6.TabIndex = 7;
            Guna2PictureBox6.TabStop = false;
            Guna2PictureBox6.UseTransparentBackground = true;
            // 
            // Guna2ShadowPanel1
            // 
            Guna2ShadowPanel1.BackColor = Color.Transparent;
            Guna2ShadowPanel1.Controls.Add(picProfile);
            Guna2ShadowPanel1.Controls.Add(lblEmail);
            Guna2ShadowPanel1.Controls.Add(lblUname);
            Guna2ShadowPanel1.Controls.Add(lblReset);
            Guna2ShadowPanel1.Controls.Add(btnLogin);
            Guna2ShadowPanel1.Controls.Add(Label3);
            Guna2ShadowPanel1.Controls.Add(btnBack);
            Guna2ShadowPanel1.Controls.Add(Label2);
            Guna2ShadowPanel1.FillColor = Color.White;
            Guna2ShadowPanel1.Location = new Point(106, 46);
            Guna2ShadowPanel1.Name = "Guna2ShadowPanel1";
            Guna2ShadowPanel1.ShadowColor = Color.Black;
            Guna2ShadowPanel1.Size = new Size(375, 435);
            Guna2ShadowPanel1.TabIndex = 12;
            // 
            // picProfile
            // 
            picProfile.FillColor = Color.Transparent;
            picProfile.Image = My.Resources.Resources.PersonIcon;
            picProfile.ImageRotate = 0f;
            picProfile.Location = new Point(130, 85);
            picProfile.Name = "picProfile";
            picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picProfile.ShadowDecoration.Parent = picProfile;
            picProfile.Size = new Size(109, 107);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 9;
            picProfile.TabStop = false;
            picProfile.UseTransparentBackground = true;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(255, 152, 19);
            lblEmail.Location = new Point(6, 233);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(363, 18);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "EMAIL";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUname
            // 
            lblUname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUname.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUname.Location = new Point(3, 211);
            lblUname.Name = "lblUname";
            lblUname.Size = new Size(366, 18);
            lblUname.TabIndex = 7;
            lblUname.Text = "USERNAME";
            lblUname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReset
            // 
            lblReset.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblReset.AutoSize = true;
            lblReset.Cursor = Cursors.Hand;
            lblReset.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReset.ForeColor = SystemColors.Highlight;
            lblReset.Location = new Point(130, 394);
            lblReset.Name = "lblReset";
            lblReset.Size = new Size(102, 16);
            lblReset.TabIndex = 6;
            lblReset.Text = "Forgot Password";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Animated = true;
            btnLogin.BorderRadius = 6;
            btnLogin.CheckedState.Parent = btnLogin;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomImages.Parent = btnLogin;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.DisabledState.Parent = btnLogin;
            btnLogin.FillColor = Color.FromArgb(255, 152, 19);
            btnLogin.Font = new Font("Proxima Nova Lt", 12.0f, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.Parent = btnLogin;
            btnLogin.Location = new Point(62, 333);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.Parent = btnLogin;
            btnLogin.Size = new Size(242, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseTransparentBackground = true;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(51, 265);
            Label3.Name = "Label3";
            Label3.Size = new Size(265, 48);
            Label3.TabIndex = 4;
            Label3.Text = "Please proceed to login if this account belongs" + '\r' + '\n' + "to you. Alternatively, you may r" + "eset the" + '\r' + '\n' + "password to reclaim this account";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FillColor = Color.Transparent;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            btnBack.ImageRotate = 0f;
            btnBack.Location = new Point(22, 16);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.Parent = btnBack;
            btnBack.Size = new Size(34, 35);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 3;
            btnBack.TabStop = false;
            btnBack.UseTransparentBackground = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Lt", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(77, 42);
            Label2.Name = "Label2";
            Label2.Size = new Size(227, 23);
            Label2.TabIndex = 2;
            Label2.Text = "Email Already Registered";
            // 
            // AlreadyExist
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(595, 555);
            Controls.Add(Guna2ShadowPanel1);
            Controls.Add(Guna2PictureBox5);
            Controls.Add(Guna2PictureBox4);
            Controls.Add(Guna2PictureBox3);
            Controls.Add(Guna2PictureBox2);
            Controls.Add(Guna2PictureBox6);
            Controls.Add(pnlNavig);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 984);
            Name = "AlreadyExist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlreadyExist";
            pnlNavig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox6).EndInit();
            Guna2ShadowPanel1.ResumeLayout(false);
            Guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            Load += new EventHandler(AlreadyExist_Load);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2Panel pnlNavig;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox5;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox4;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox6;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2ShadowPanel Guna2ShadowPanel1;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2PictureBox btnBack;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2Button btnLogin;
        internal Label lblReset;
        internal Label lblUname;
        internal Label lblEmail;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
    }
}