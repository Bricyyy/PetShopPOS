using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ResetPass : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPass));
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlNavig = new Guna.UI2.WinForms.Guna2Panel();
            Guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            Label1 = new Label();
            Label2 = new Label();
            lblNewPass = new Label();
            lblConfirmPass = new Label();
            lblError = new Label();
            btnReset = new Guna.UI2.WinForms.Guna2Button();
            btnReset.Click += new EventHandler(Guna2Button1_Click);
            resetPanel = new Guna.UI2.WinForms.Guna2Panel();
            confirmPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            confirmPass.CheckedChanged += new EventHandler(confirmPass_CheckedChanged);
            newPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            newPass.CheckedChanged += new EventHandler(Guna2ImageCheckBox1_CheckedChanged);
            txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtNewPass.TextChanged += new EventHandler(txtNewPass_TextChanged);
            txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtConfirmPass.TextChanged += new EventHandler(txtConfirmPass_TextChanged);
            donePanel = new Guna.UI2.WinForms.Guna2Panel();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            btnLogin.Click += new EventHandler(Guna2Button1_Click_1);
            Label4 = new Label();
            Label3 = new Label();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            dogPic = new Guna.UI2.WinForms.Guna2PictureBox();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnBack.Click += new EventHandler(btnBack_Click);
            pnlNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).BeginInit();
            resetPanel.SuspendLayout();
            donePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPic).BeginInit();
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
            pnlNavig.Controls.Add(Guna2PictureBox7);
            pnlNavig.Controls.Add(Guna2ControlBox3);
            pnlNavig.Controls.Add(Guna2ControlBox4);
            pnlNavig.Location = new Point(2, 0);
            pnlNavig.Name = "pnlNavig";
            pnlNavig.ShadowDecoration.Parent = pnlNavig;
            pnlNavig.Size = new Size(372, 29);
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
            Guna2ControlBox3.Location = new Point(276, 0);
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
            Guna2ControlBox4.Location = new Point(327, 0);
            Guna2ControlBox4.Name = "Guna2ControlBox4";
            Guna2ControlBox4.ShadowDecoration.Parent = Guna2ControlBox4;
            Guna2ControlBox4.Size = new Size(45, 29);
            Guna2ControlBox4.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Proxima Nova Lt", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(30, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(207, 25);
            Label1.TabIndex = 1;
            Label1.Text = "Reset Your Password";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = SystemColors.ActiveBorder;
            Label2.Location = new Point(14, 37);
            Label2.Name = "Label2";
            Label2.Size = new Size(241, 32);
            Label2.TabIndex = 2;
            Label2.Text = "Set your new password so you can Login" + '\r' + '\n' + "and buy from Puppy Love";
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Proxima Nova Rg", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPass.ForeColor = SystemColors.ActiveBorder;
            lblNewPass.Location = new Point(14, 93);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(113, 13);
            lblNewPass.TabIndex = 5;
            lblNewPass.Text = "Create New Password";
            lblNewPass.Visible = false;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Proxima Nova Rg", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPass.ForeColor = SystemColors.ActiveBorder;
            lblConfirmPass.Location = new Point(14, 155);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(119, 13);
            lblConfirmPass.TabIndex = 6;
            lblConfirmPass.Text = "Confirm New Password";
            lblConfirmPass.Visible = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(14, 210);
            lblError.Name = "lblError";
            lblError.Size = new Size(132, 13);
            lblError.TabIndex = 7;
            lblError.Text = "Password does not match.";
            lblError.Visible = false;
            // 
            // btnReset
            // 
            btnReset.Animated = true;
            btnReset.BackColor = Color.Transparent;
            btnReset.BorderRadius = 8;
            btnReset.CheckedState.Parent = btnReset;
            btnReset.Cursor = Cursors.Hand;
            btnReset.CustomImages.Parent = btnReset;
            btnReset.DisabledState.BorderColor = Color.DarkGray;
            btnReset.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReset.DisabledState.Parent = btnReset;
            btnReset.FillColor = Color.FromArgb(255, 152, 19);
            btnReset.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.HoverState.Parent = btnReset;
            btnReset.Location = new Point(17, 242);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.Parent = btnReset;
            btnReset.Size = new Size(238, 36);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset Password";
            btnReset.UseTransparentBackground = true;
            // 
            // resetPanel
            // 
            resetPanel.Controls.Add(Label2);
            resetPanel.Controls.Add(btnReset);
            resetPanel.Controls.Add(confirmPass);
            resetPanel.Controls.Add(Label1);
            resetPanel.Controls.Add(newPass);
            resetPanel.Controls.Add(txtNewPass);
            resetPanel.Controls.Add(txtConfirmPass);
            resetPanel.Controls.Add(lblNewPass);
            resetPanel.Controls.Add(lblError);
            resetPanel.Controls.Add(lblConfirmPass);
            resetPanel.Location = new Point(52, 144);
            resetPanel.Name = "resetPanel";
            resetPanel.ShadowDecoration.Parent = resetPanel;
            resetPanel.Size = new Size(268, 278);
            resetPanel.TabIndex = 14;
            // 
            // confirmPass
            // 
            confirmPass.BackColor = Color.Transparent;
            confirmPass.CheckedState.Image = My.Resources.Resources.icons8_eye_100;
            confirmPass.CheckedState.Parent = confirmPass;
            confirmPass.Cursor = Cursors.Hand;
            confirmPass.HoverState.Parent = confirmPass;
            confirmPass.Image = (Image)resources.GetObject("confirmPass.Image");
            confirmPass.ImageOffset = new Point(0, 0);
            confirmPass.ImageRotate = 0f;
            confirmPass.Location = new Point(229, 177);
            confirmPass.Name = "confirmPass";
            confirmPass.PressedState.Parent = confirmPass;
            confirmPass.ShadowDecoration.Parent = confirmPass;
            confirmPass.Size = new Size(24, 24);
            confirmPass.TabIndex = 12;
            confirmPass.UseTransparentBackground = true;
            // 
            // newPass
            // 
            newPass.BackColor = Color.Transparent;
            newPass.CheckedState.Image = My.Resources.Resources.icons8_eye_100;
            newPass.CheckedState.Parent = newPass;
            newPass.Cursor = Cursors.Hand;
            newPass.HoverState.Parent = newPass;
            newPass.Image = (Image)resources.GetObject("newPass.Image");
            newPass.ImageOffset = new Point(0, 0);
            newPass.ImageRotate = 0f;
            newPass.Location = new Point(229, 115);
            newPass.Name = "newPass";
            newPass.PressedState.Parent = newPass;
            newPass.ShadowDecoration.Parent = newPass;
            newPass.Size = new Size(24, 24);
            newPass.TabIndex = 11;
            newPass.UseTransparentBackground = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Animated = true;
            txtNewPass.BorderRadius = 3;
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
            txtNewPass.IconLeft = (Image)resources.GetObject("txtNewPass.IconLeft");
            txtNewPass.IconRight = (Image)resources.GetObject("txtNewPass.IconRight");
            txtNewPass.Location = new Point(17, 109);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '\0';
            txtNewPass.PlaceholderText = "Create New Password";
            txtNewPass.SelectedText = "";
            txtNewPass.ShadowDecoration.Parent = txtNewPass;
            txtNewPass.Size = new Size(238, 36);
            txtNewPass.TabIndex = 3;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Animated = true;
            txtConfirmPass.BorderRadius = 3;
            txtConfirmPass.Cursor = Cursors.IBeam;
            txtConfirmPass.DefaultText = "";
            txtConfirmPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPass.DisabledState.Parent = txtConfirmPass;
            txtConfirmPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPass.FocusedState.Parent = txtConfirmPass;
            txtConfirmPass.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtConfirmPass.ForeColor = Color.Black;
            txtConfirmPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPass.HoverState.Parent = txtConfirmPass;
            txtConfirmPass.IconLeft = (Image)resources.GetObject("txtConfirmPass.IconLeft");
            txtConfirmPass.IconRight = (Image)resources.GetObject("txtConfirmPass.IconRight");
            txtConfirmPass.Location = new Point(17, 171);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '\0';
            txtConfirmPass.PlaceholderText = "Confirm New Password";
            txtConfirmPass.SelectedText = "";
            txtConfirmPass.ShadowDecoration.Parent = txtConfirmPass;
            txtConfirmPass.Size = new Size(238, 36);
            txtConfirmPass.TabIndex = 4;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // donePanel
            // 
            donePanel.Controls.Add(btnLogin);
            donePanel.Controls.Add(Label4);
            donePanel.Controls.Add(Label3);
            donePanel.Location = new Point(52, 147);
            donePanel.Name = "donePanel";
            donePanel.ShadowDecoration.Parent = donePanel;
            donePanel.Size = new Size(268, 278);
            donePanel.TabIndex = 15;
            donePanel.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderRadius = 8;
            btnLogin.CheckedState.Parent = btnLogin;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomImages.Parent = btnLogin;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.DisabledState.Parent = btnLogin;
            btnLogin.FillColor = Color.FromArgb(255, 152, 19);
            btnLogin.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.Parent = btnLogin;
            btnLogin.Location = new Point(30, 93);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.Parent = btnLogin;
            btnLogin.Size = new Size(214, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login ";
            btnLogin.UseTransparentBackground = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = SystemColors.ActiveBorder;
            Label4.Location = new Point(27, 37);
            Label4.Name = "Label4";
            Label4.Size = new Size(217, 32);
            Label4.TabIndex = 1;
            Label4.Text = "You can now use your new password" + '\r' + '\n' + "to login to your account!";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Lt", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(2, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(265, 25);
            Label3.TabIndex = 0;
            Label3.Text = "Successful Password Reset";
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.Image = My.Resources.Resources._0Eto_pre;
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(128, 38);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(107, 103);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 0;
            Guna2PictureBox1.TabStop = false;
            // 
            // dogPic
            // 
            dogPic.BackColor = Color.Transparent;
            dogPic.FillColor = Color.Transparent;
            dogPic.Image = (Image)resources.GetObject("dogPic.Image");
            dogPic.ImageRotate = 0f;
            dogPic.Location = new Point(38, 329);
            dogPic.Name = "dogPic";
            dogPic.ShadowDecoration.Parent = dogPic;
            dogPic.Size = new Size(294, 205);
            dogPic.SizeMode = PictureBoxSizeMode.Zoom;
            dogPic.TabIndex = 13;
            dogPic.TabStop = false;
            dogPic.UseTransparentBackground = true;
            dogPic.Visible = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BorderColor = Color.FromArgb(187, 186, 186);
            btnBack.BorderThickness = 1;
            btnBack.CheckedState.Parent = btnBack;
            btnBack.Cursor = Cursors.Hand;
            btnBack.CustomImages.Parent = btnBack;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.DisabledState.Parent = btnBack;
            btnBack.FillColor = Color.Transparent;
            btnBack.Font = new Font("Proxima Nova Rg", 11.25f);
            btnBack.ForeColor = Color.Black;
            btnBack.HoverState.Parent = btnBack;
            btnBack.Location = new Point(-2, 490);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.Parent = btnBack;
            btnBack.Size = new Size(376, 45);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back To Login";
            // 
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 535);
            Controls.Add(btnBack);
            Controls.Add(pnlNavig);
            Controls.Add(resetPanel);
            Controls.Add(Guna2PictureBox1);
            Controls.Add(dogPic);
            Controls.Add(donePanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1280, 984);
            Name = "ResetPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPass";
            pnlNavig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).EndInit();
            resetPanel.ResumeLayout(false);
            resetPanel.PerformLayout();
            donePanel.ResumeLayout(false);
            donePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPic).EndInit();
            Load += new EventHandler(ResetPass_Load);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Label Label1;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        internal Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        internal Label lblConfirmPass;
        internal Label lblNewPass;
        internal Guna.UI2.WinForms.Guna2Button btnReset;
        internal Label lblError;
        internal Guna.UI2.WinForms.Guna2ImageCheckBox confirmPass;
        internal Guna.UI2.WinForms.Guna2ImageCheckBox newPass;
        internal Guna.UI2.WinForms.Guna2PictureBox dogPic;
        internal Guna.UI2.WinForms.Guna2Panel donePanel;
        internal Label Label4;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2Panel resetPanel;
        internal Guna.UI2.WinForms.Guna2Panel pnlNavig;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox3;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox4;
        internal Guna.UI2.WinForms.Guna2Button btnLogin;
        internal Guna.UI2.WinForms.Guna2Button btnBack;
    }
}