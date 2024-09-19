using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Signup : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlNavig = new Guna.UI2.WinForms.Guna2Panel();
            Guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlVerify = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblResend = new Label();
            lblResend.Click += new EventHandler(lblResend_Click);
            lblQuestion = new Label();
            lblCodeError = new Label();
            lblTimer = new Label();
            txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            txtCode.KeyPress += new KeyPressEventHandler(txtCode_KeyPress);
            txtCode.TextChanged += new EventHandler(txtCode_TextChanged);
            lblEmail = new Label();
            Label3 = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            btnBack.Click += new EventHandler(btnBack_Click);
            Label2 = new Label();
            btnVerify = new Guna.UI2.WinForms.Guna2Button();
            btnVerify.Click += new EventHandler(btnVerify_Click);
            Label1 = new Label();
            Label4 = new Label();
            lblCreate = new Label();
            lblDone = new Label();
            tmrResend = new Timer(components);
            tmrResend.Tick += new EventHandler(Timer1_Tick);
            Label5 = new Label();
            Label7 = new Label();
            btnSignup = new Guna.UI2.WinForms.Guna2Button();
            btnSignup.Click += new EventHandler(btnSignup_Click);
            pnlCreate = new Guna.UI2.WinForms.Guna2ShadowPanel();
            showCPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            showCPass.CheckedChanged += new EventHandler(showCPass_CheckedChanged);
            showPass = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            showPass.CheckedChanged += new EventHandler(showPass_CheckedChanged);
            picBack = new Guna.UI2.WinForms.Guna2PictureBox();
            picBack.Click += new EventHandler(picBack_Click);
            lblError = new Label();
            lblCPass = new Label();
            lblPass = new Label();
            lblUsername = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername.TextChanged += new EventHandler(Guna2TextBox1_TextChanged);
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtPass.TextChanged += new EventHandler(Guna2TextBox2_TextChanged);
            txtCPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtCPass.TextChanged += new EventHandler(txtCPass_TextChanged);
            pnlDone = new Guna.UI2.WinForms.Guna2ShadowPanel();
            Guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblDEmail = new Label();
            lblRedirect = new Label();
            btnDone = new Guna.UI2.WinForms.Guna2Button();
            btnDone.Click += new EventHandler(btnDone_Click);
            Label8 = new Label();
            Label6 = new Label();
            tmrRedirect = new Timer(components);
            tmrRedirect.Tick += new EventHandler(tmrRedirect_Tick);
            picCheck = new Guna.UI2.WinForms.Guna2PictureBox();
            pic2 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            arrow2 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            arrow1 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            pnlNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).BeginInit();
            pnlVerify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            pnlCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            pnlDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrow2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrow1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
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
            pnlNavig.Location = new Point(0, 0);
            pnlNavig.Name = "pnlNavig";
            pnlNavig.ShadowDecoration.Parent = pnlNavig;
            pnlNavig.Size = new Size(594, 29);
            pnlNavig.TabIndex = 20;
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
            Guna2ControlBox3.Location = new Point(498, 0);
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
            Guna2ControlBox4.Location = new Point(549, 0);
            Guna2ControlBox4.Name = "Guna2ControlBox4";
            Guna2ControlBox4.ShadowDecoration.Parent = Guna2ControlBox4;
            Guna2ControlBox4.Size = new Size(45, 29);
            Guna2ControlBox4.TabIndex = 1;
            // 
            // pnlVerify
            // 
            pnlVerify.BackColor = Color.Transparent;
            pnlVerify.Controls.Add(lblResend);
            pnlVerify.Controls.Add(lblQuestion);
            pnlVerify.Controls.Add(lblCodeError);
            pnlVerify.Controls.Add(lblTimer);
            pnlVerify.Controls.Add(txtCode);
            pnlVerify.Controls.Add(lblEmail);
            pnlVerify.Controls.Add(Label3);
            pnlVerify.Controls.Add(btnBack);
            pnlVerify.Controls.Add(Label2);
            pnlVerify.Controls.Add(btnVerify);
            pnlVerify.FillColor = Color.White;
            pnlVerify.Location = new Point(111, 191);
            pnlVerify.Name = "pnlVerify";
            pnlVerify.ShadowColor = Color.Black;
            pnlVerify.Size = new Size(375, 336);
            pnlVerify.TabIndex = 9;
            // 
            // lblResend
            // 
            lblResend.AutoSize = true;
            lblResend.Cursor = Cursors.Hand;
            lblResend.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResend.ForeColor = Color.FromArgb(255, 152, 19);
            lblResend.Location = new Point(155, 238);
            lblResend.Name = "lblResend";
            lblResend.Size = new Size(50, 16);
            lblResend.TabIndex = 11;
            lblResend.Text = "Resend";
            lblResend.Visible = false;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = SystemColors.ActiveBorder;
            lblQuestion.Location = new Point(111, 223);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(148, 16);
            lblQuestion.TabIndex = 10;
            lblQuestion.Text = "Did not receive the code?";
            lblQuestion.Visible = false;
            // 
            // lblCodeError
            // 
            lblCodeError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            lblCodeError.AutoSize = true;
            lblCodeError.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodeError.ForeColor = Color.IndianRed;
            lblCodeError.Location = new Point(116, 204);
            lblCodeError.Name = "lblCodeError";
            lblCodeError.Size = new Size(135, 13);
            lblCodeError.TabIndex = 22;
            lblCodeError.Text = "Verification code is invalid";
            lblCodeError.TextAlign = ContentAlignment.MiddleCenter;
            lblCodeError.Visible = false;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = SystemColors.ActiveBorder;
            lblTimer.Location = new Point(91, 231);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(198, 15);
            lblTimer.TabIndex = 9;
            lblTimer.Text = "Please wait null seconds to resend.";
            // 
            // txtCode
            // 
            txtCode.Animated = true;
            txtCode.BorderRadius = 3;
            txtCode.Cursor = Cursors.IBeam;
            txtCode.DefaultText = "";
            txtCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCode.DisabledState.Parent = txtCode;
            txtCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCode.FocusedState.Parent = txtCode;
            txtCode.Font = new Font("Proxima Nova Rg", 15.75f);
            txtCode.ForeColor = Color.Black;
            txtCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCode.HoverState.Parent = txtCode;
            txtCode.Location = new Point(125, 139);
            txtCode.Margin = new Padding(5, 5, 5, 5);
            txtCode.Name = "txtCode";
            txtCode.PasswordChar = '\0';
            txtCode.PlaceholderText = "";
            txtCode.SelectedText = "";
            txtCode.ShadowDecoration.Parent = txtCode;
            txtCode.Size = new Size(119, 60);
            txtCode.TabIndex = 5;
            txtCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            lblEmail.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(0, 109);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(372, 18);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(71, 93);
            Label3.Name = "Label3";
            Label3.Size = new Size(232, 16);
            Label3.TabIndex = 3;
            Label3.Text = "Your verification code is sent by email to:";
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FillColor = Color.Transparent;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            btnBack.ImageRotate = 0f;
            btnBack.Location = new Point(25, 25);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.Parent = btnBack;
            btnBack.Size = new Size(34, 35);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 2;
            btnBack.TabStop = false;
            btnBack.UseTransparentBackground = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Lt", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(84, 37);
            Label2.Name = "Label2";
            Label2.Size = new Size(209, 23);
            Label2.TabIndex = 1;
            Label2.Text = "Enter Verification Code";
            // 
            // btnVerify
            // 
            btnVerify.Animated = true;
            btnVerify.BorderRadius = 6;
            btnVerify.CheckedState.Parent = btnVerify;
            btnVerify.Cursor = Cursors.Hand;
            btnVerify.CustomImages.Parent = btnVerify;
            btnVerify.DisabledState.BorderColor = Color.DarkGray;
            btnVerify.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVerify.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVerify.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVerify.DisabledState.Parent = btnVerify;
            btnVerify.Enabled = false;
            btnVerify.FillColor = Color.FromArgb(255, 152, 19);
            btnVerify.Font = new Font("Proxima Nova Lt", 12.0f, FontStyle.Bold);
            btnVerify.ForeColor = Color.White;
            btnVerify.HoverState.Parent = btnVerify;
            btnVerify.Location = new Point(66, 269);
            btnVerify.Name = "btnVerify";
            btnVerify.ShadowDecoration.Parent = btnVerify;
            btnVerify.Size = new Size(242, 42);
            btnVerify.TabIndex = 0;
            btnVerify.Text = "VERIFY";
            btnVerify.UseTransparentBackground = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Proxima Nova Rg", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(90, 51);
            Label1.Name = "Label1";
            Label1.Size = new Size(108, 33);
            Label1.TabIndex = 11;
            Label1.Text = "Sign Up";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(190, 65, 109);
            Label4.Location = new Point(122, 154);
            Label4.Name = "Label4";
            Label4.Size = new Size(69, 15);
            Label4.TabIndex = 12;
            Label4.Text = "Verify Email";
            // 
            // lblCreate
            // 
            lblCreate.AutoSize = true;
            lblCreate.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreate.ForeColor = SystemColors.ActiveBorder;
            lblCreate.Location = new Point(259, 154);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(91, 15);
            lblCreate.TabIndex = 13;
            lblCreate.Text = "Create Account";
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDone.ForeColor = SystemColors.ActiveBorder;
            lblDone.Location = new Point(432, 154);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(36, 15);
            lblDone.TabIndex = 15;
            lblDone.Text = "Done";
            // 
            // tmrResend
            // 
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Proxima Nova Lt", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(111, 17);
            Label5.Name = "Label5";
            Label5.Size = new Size(157, 23);
            Label5.TabIndex = 3;
            Label5.Text = "Set Your Account";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(64, 46);
            Label7.Name = "Label7";
            Label7.Size = new Size(251, 32);
            Label7.TabIndex = 4;
            Label7.Text = "Last step! Set your username and password" + '\r' + '\n' + "to complete the sign up.";
            Label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignup
            // 
            btnSignup.Animated = true;
            btnSignup.BackColor = Color.Transparent;
            btnSignup.BorderRadius = 6;
            btnSignup.CheckedState.Parent = btnSignup;
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.CustomImages.Parent = btnSignup;
            btnSignup.DisabledState.BorderColor = Color.DarkGray;
            btnSignup.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignup.DisabledState.Parent = btnSignup;
            btnSignup.FillColor = Color.FromArgb(255, 152, 19);
            btnSignup.Font = new Font("Proxima Nova Lt", 12.0f, FontStyle.Bold);
            btnSignup.ForeColor = Color.White;
            btnSignup.HoverState.Parent = btnSignup;
            btnSignup.Location = new Point(82, 273);
            btnSignup.Name = "btnSignup";
            btnSignup.ShadowDecoration.Parent = btnSignup;
            btnSignup.Size = new Size(242, 42);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "SIGN UP";
            btnSignup.UseTransparentBackground = true;
            // 
            // pnlCreate
            // 
            pnlCreate.BackColor = Color.Transparent;
            pnlCreate.Controls.Add(showCPass);
            pnlCreate.Controls.Add(showPass);
            pnlCreate.Controls.Add(picBack);
            pnlCreate.Controls.Add(lblError);
            pnlCreate.Controls.Add(lblCPass);
            pnlCreate.Controls.Add(lblPass);
            pnlCreate.Controls.Add(lblUsername);
            pnlCreate.Controls.Add(btnSignup);
            pnlCreate.Controls.Add(txtUsername);
            pnlCreate.Controls.Add(Label7);
            pnlCreate.Controls.Add(txtPass);
            pnlCreate.Controls.Add(Label5);
            pnlCreate.Controls.Add(txtCPass);
            pnlCreate.FillColor = Color.White;
            pnlCreate.Location = new Point(111, 194);
            pnlCreate.Name = "pnlCreate";
            pnlCreate.ShadowColor = Color.Black;
            pnlCreate.Size = new Size(375, 336);
            pnlCreate.TabIndex = 18;
            pnlCreate.Visible = false;
            // 
            // showCPass
            // 
            showCPass.BackColor = Color.Transparent;
            showCPass.CheckedState.Image = My.Resources.Resources.icons8_eye_100;
            showCPass.CheckedState.Parent = showCPass;
            showCPass.Cursor = Cursors.Hand;
            showCPass.HoverState.Parent = showCPass;
            showCPass.Image = My.Resources.Resources.icons8_closed_eye_100;
            showCPass.ImageOffset = new Point(0, 0);
            showCPass.ImageRotate = 0f;
            showCPass.Location = new Point(289, 219);
            showCPass.Name = "showCPass";
            showCPass.PressedState.Parent = showCPass;
            showCPass.ShadowDecoration.Parent = showCPass;
            showCPass.Size = new Size(24, 24);
            showCPass.TabIndex = 21;
            showCPass.UseTransparentBackground = true;
            // 
            // showPass
            // 
            showPass.BackColor = Color.Transparent;
            showPass.CheckedState.Image = My.Resources.Resources.icons8_eye_100;
            showPass.CheckedState.Parent = showPass;
            showPass.Cursor = Cursors.Hand;
            showPass.HoverState.Parent = showPass;
            showPass.Image = My.Resources.Resources.icons8_closed_eye_100;
            showPass.ImageOffset = new Point(0, 0);
            showPass.ImageRotate = 0f;
            showPass.Location = new Point(288, 164);
            showPass.Name = "showPass";
            showPass.PressedState.Parent = showPass;
            showPass.ShadowDecoration.Parent = showPass;
            showPass.Size = new Size(24, 24);
            showPass.TabIndex = 19;
            showPass.UseTransparentBackground = true;
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.FillColor = Color.Transparent;
            picBack.Image = (Image)resources.GetObject("picBack.Image");
            picBack.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            picBack.ImageRotate = 0f;
            picBack.Location = new Point(24, 16);
            picBack.Name = "picBack";
            picBack.ShadowDecoration.Parent = picBack;
            picBack.Size = new Size(34, 35);
            picBack.SizeMode = PictureBoxSizeMode.Zoom;
            picBack.TabIndex = 12;
            picBack.TabStop = false;
            picBack.UseTransparentBackground = true;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            lblError.AutoSize = true;
            lblError.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(86, 254);
            lblError.Name = "lblError";
            lblError.Size = new Size(33, 13);
            lblError.TabIndex = 20;
            lblError.Text = "Error.";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // lblCPass
            // 
            lblCPass.AutoSize = true;
            lblCPass.Font = new Font("Proxima Nova Rg", 8.25f);
            lblCPass.ForeColor = SystemColors.ActiveBorder;
            lblCPass.Location = new Point(86, 198);
            lblCPass.Name = "lblCPass";
            lblCPass.Size = new Size(94, 13);
            lblCPass.TabIndex = 19;
            lblCPass.Text = "Confirm Password";
            lblCPass.Visible = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Proxima Nova Rg", 8.25f);
            lblPass.ForeColor = SystemColors.ActiveBorder;
            lblPass.Location = new Point(86, 143);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(53, 13);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password";
            lblPass.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Proxima Nova Rg", 8.25f);
            lblUsername.ForeColor = SystemColors.ActiveBorder;
            lblUsername.Location = new Point(86, 88);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(57, 13);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            lblUsername.Visible = false;
            // 
            // txtUsername
            // 
            txtUsername.Animated = true;
            txtUsername.BorderRadius = 3;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.Parent = txtUsername;
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.FocusedState.Parent = txtUsername;
            txtUsername.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.HoverState.Parent = txtUsername;
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.Location = new Point(89, 104);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.Parent = txtUsername;
            txtUsername.Size = new Size(227, 36);
            txtUsername.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Animated = true;
            txtPass.BorderRadius = 3;
            txtPass.Cursor = Cursors.IBeam;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.Parent = txtPass;
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.FocusedState.Parent = txtPass;
            txtPass.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtPass.ForeColor = Color.Black;
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.HoverState.Parent = txtPass;
            txtPass.IconLeft = My.Resources.Resources.@lock;
            txtPass.IconRight = (Image)resources.GetObject("txtPass.IconRight");
            txtPass.Location = new Point(89, 159);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '\0';
            txtPass.PlaceholderText = "Password";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.Parent = txtPass;
            txtPass.Size = new Size(226, 36);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtCPass
            // 
            txtCPass.Animated = true;
            txtCPass.BorderRadius = 3;
            txtCPass.Cursor = Cursors.IBeam;
            txtCPass.DefaultText = "";
            txtCPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCPass.DisabledState.Parent = txtCPass;
            txtCPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCPass.FocusedState.Parent = txtCPass;
            txtCPass.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtCPass.ForeColor = Color.Black;
            txtCPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCPass.HoverState.Parent = txtCPass;
            txtCPass.IconLeft = My.Resources.Resources.@lock;
            txtCPass.IconRight = (Image)resources.GetObject("txtCPass.IconRight");
            txtCPass.Location = new Point(89, 214);
            txtCPass.Name = "txtCPass";
            txtCPass.PasswordChar = '\0';
            txtCPass.PlaceholderText = "Confirm Password";
            txtCPass.SelectedText = "";
            txtCPass.ShadowDecoration.Parent = txtCPass;
            txtCPass.Size = new Size(226, 36);
            txtCPass.TabIndex = 2;
            txtCPass.UseSystemPasswordChar = true;
            // 
            // pnlDone
            // 
            pnlDone.BackColor = Color.Transparent;
            pnlDone.Controls.Add(Guna2PictureBox6);
            pnlDone.Controls.Add(lblDEmail);
            pnlDone.Controls.Add(lblRedirect);
            pnlDone.Controls.Add(btnDone);
            pnlDone.Controls.Add(Label8);
            pnlDone.Controls.Add(Label6);
            pnlDone.FillColor = Color.White;
            pnlDone.Location = new Point(111, 197);
            pnlDone.Name = "pnlDone";
            pnlDone.ShadowColor = Color.Black;
            pnlDone.Size = new Size(375, 336);
            pnlDone.TabIndex = 19;
            pnlDone.Visible = false;
            // 
            // Guna2PictureBox6
            // 
            Guna2PictureBox6.Image = (Image)resources.GetObject("Guna2PictureBox6.Image");
            Guna2PictureBox6.ImageRotate = 0f;
            Guna2PictureBox6.Location = new Point(141, 65);
            Guna2PictureBox6.Name = "Guna2PictureBox6";
            Guna2PictureBox6.ShadowDecoration.Parent = Guna2PictureBox6;
            Guna2PictureBox6.Size = new Size(83, 63);
            Guna2PictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox6.TabIndex = 25;
            Guna2PictureBox6.TabStop = false;
            Guna2PictureBox6.UseTransparentBackground = true;
            // 
            // lblDEmail
            // 
            lblDEmail.AutoSize = true;
            lblDEmail.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDEmail.ForeColor = Color.FromArgb(190, 65, 109);
            lblDEmail.Location = new Point(111, 174);
            lblDEmail.Name = "lblDEmail";
            lblDEmail.Size = new Size(39, 16);
            lblDEmail.TabIndex = 24;
            lblDEmail.Text = "Email";
            lblDEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRedirect
            // 
            lblRedirect.AutoSize = true;
            lblRedirect.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedirect.Location = new Point(54, 206);
            lblRedirect.Name = "lblRedirect";
            lblRedirect.Size = new Size(262, 16);
            lblRedirect.TabIndex = 23;
            lblRedirect.Text = "You will be redirected to Login in null seconds.";
            lblRedirect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            btnDone.Animated = true;
            btnDone.BackColor = Color.Transparent;
            btnDone.BorderRadius = 6;
            btnDone.CheckedState.Parent = btnDone;
            btnDone.Cursor = Cursors.Hand;
            btnDone.CustomImages.Parent = btnDone;
            btnDone.DisabledState.BorderColor = Color.DarkGray;
            btnDone.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDone.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDone.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDone.DisabledState.Parent = btnDone;
            btnDone.FillColor = Color.FromArgb(255, 152, 19);
            btnDone.Font = new Font("Proxima Nova Lt", 12.0f, FontStyle.Bold);
            btnDone.ForeColor = Color.White;
            btnDone.HoverState.Parent = btnDone;
            btnDone.Location = new Point(64, 251);
            btnDone.Name = "btnDone";
            btnDone.ShadowDecoration.Parent = btnDone;
            btnDone.Size = new Size(242, 42);
            btnDone.TabIndex = 22;
            btnDone.Text = "Back To Login";
            btnDone.UseTransparentBackground = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(54, 141);
            Label8.Name = "Label8";
            Label8.Size = new Size(251, 32);
            Label8.TabIndex = 5;
            Label8.Text = "You have successfully created a Puppy Love" + '\r' + '\n' + "account with the email:";
            Label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Proxima Nova Lt", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(90, 34);
            Label6.Name = "Label6";
            Label6.Size = new Size(179, 23);
            Label6.TabIndex = 2;
            Label6.Text = "Sign Up Successful!";
            // 
            // tmrRedirect
            // 
            // 
            // picCheck
            // 
            picCheck.BackColor = Color.Transparent;
            picCheck.FillColor = Color.Transparent;
            picCheck.Image = (Image)resources.GetObject("picCheck.Image");
            picCheck.ImageRotate = 0f;
            picCheck.Location = new Point(423, 99);
            picCheck.Name = "picCheck";
            picCheck.ShadowDecoration.Parent = picCheck;
            picCheck.Size = new Size(51, 52);
            picCheck.SizeMode = PictureBoxSizeMode.Zoom;
            picCheck.TabIndex = 17;
            picCheck.TabStop = false;
            picCheck.UseTransparentBackground = true;
            // 
            // pic2
            // 
            pic2.BackColor = Color.Transparent;
            pic2.FillColor = Color.Transparent;
            pic2.Image = (Image)resources.GetObject("pic2.Image");
            pic2.ImageRotate = 0f;
            pic2.Location = new Point(276, 102);
            pic2.Name = "pic2";
            pic2.ShadowDecoration.Parent = pic2;
            pic2.Size = new Size(51, 52);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 16;
            pic2.TabStop = false;
            pic2.UseTransparentBackground = true;
            // 
            // Guna2PictureBox9
            // 
            Guna2PictureBox9.BackColor = Color.Transparent;
            Guna2PictureBox9.FillColor = Color.Transparent;
            Guna2PictureBox9.Image = My.Resources.Resources.circle1colored;
            Guna2PictureBox9.ImageRotate = 0f;
            Guna2PictureBox9.Location = new Point(129, 102);
            Guna2PictureBox9.Name = "Guna2PictureBox9";
            Guna2PictureBox9.ShadowDecoration.Parent = Guna2PictureBox9;
            Guna2PictureBox9.Size = new Size(51, 52);
            Guna2PictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox9.TabIndex = 7;
            Guna2PictureBox9.TabStop = false;
            Guna2PictureBox9.UseTransparentBackground = true;
            // 
            // arrow2
            // 
            arrow2.BackColor = Color.Transparent;
            arrow2.FillColor = Color.Transparent;
            arrow2.Image = (Image)resources.GetObject("arrow2.Image");
            arrow2.ImageRotate = 0f;
            arrow2.Location = new Point(356, 117);
            arrow2.Name = "arrow2";
            arrow2.ShadowDecoration.Parent = arrow2;
            arrow2.Size = new Size(58, 22);
            arrow2.SizeMode = PictureBoxSizeMode.StretchImage;
            arrow2.TabIndex = 14;
            arrow2.TabStop = false;
            arrow2.UseTransparentBackground = true;
            // 
            // Guna2PictureBox8
            // 
            Guna2PictureBox8.BackColor = Color.Transparent;
            Guna2PictureBox8.FillColor = Color.Transparent;
            Guna2PictureBox8.Image = My.Resources.Resources._0Eto_pre;
            Guna2PictureBox8.ImageRotate = 0f;
            Guna2PictureBox8.Location = new Point(12, 39);
            Guna2PictureBox8.Name = "Guna2PictureBox8";
            Guna2PictureBox8.ShadowDecoration.Parent = Guna2PictureBox8;
            Guna2PictureBox8.Size = new Size(72, 63);
            Guna2PictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox8.TabIndex = 10;
            Guna2PictureBox8.TabStop = false;
            Guna2PictureBox8.UseTransparentBackground = true;
            // 
            // arrow1
            // 
            arrow1.BackColor = Color.Transparent;
            arrow1.FillColor = Color.Transparent;
            arrow1.Image = (Image)resources.GetObject("arrow1.Image");
            arrow1.ImageRotate = 0f;
            arrow1.Location = new Point(198, 117);
            arrow1.Name = "arrow1";
            arrow1.ShadowDecoration.Parent = arrow1;
            arrow1.Size = new Size(58, 22);
            arrow1.SizeMode = PictureBoxSizeMode.StretchImage;
            arrow1.TabIndex = 7;
            arrow1.TabStop = false;
            arrow1.UseTransparentBackground = true;
            // 
            // Guna2PictureBox5
            // 
            Guna2PictureBox5.BackColor = Color.Transparent;
            Guna2PictureBox5.FillColor = Color.Transparent;
            Guna2PictureBox5.Image = My.Resources.Resources.dog;
            Guna2PictureBox5.ImageRotate = 0f;
            Guna2PictureBox5.Location = new Point(246, 546);
            Guna2PictureBox5.Name = "Guna2PictureBox5";
            Guna2PictureBox5.ShadowDecoration.Parent = Guna2PictureBox5;
            Guna2PictureBox5.Size = new Size(61, 56);
            Guna2PictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox5.TabIndex = 6;
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
            Guna2PictureBox4.Location = new Point(376, 558);
            Guna2PictureBox4.Name = "Guna2PictureBox4";
            Guna2PictureBox4.ShadowDecoration.Parent = Guna2PictureBox4;
            Guna2PictureBox4.Size = new Size(35, 44);
            Guna2PictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox4.TabIndex = 5;
            Guna2PictureBox4.TabStop = false;
            Guna2PictureBox4.UseTransparentBackground = true;
            // 
            // Guna2PictureBox3
            // 
            Guna2PictureBox3.BackColor = Color.Transparent;
            Guna2PictureBox3.FillColor = Color.Transparent;
            Guna2PictureBox3.Image = My.Resources.Resources.trees;
            Guna2PictureBox3.ImageRotate = 0f;
            Guna2PictureBox3.Location = new Point(12, 512);
            Guna2PictureBox3.Name = "Guna2PictureBox3";
            Guna2PictureBox3.ShadowDecoration.Parent = Guna2PictureBox3;
            Guna2PictureBox3.Size = new Size(91, 90);
            Guna2PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox3.TabIndex = 4;
            Guna2PictureBox3.TabStop = false;
            Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // Guna2PictureBox2
            // 
            Guna2PictureBox2.BackColor = Color.Transparent;
            Guna2PictureBox2.FillColor = Color.Transparent;
            Guna2PictureBox2.Image = My.Resources.Resources.birds;
            Guna2PictureBox2.ImageRotate = 0f;
            Guna2PictureBox2.Location = new Point(492, 181);
            Guna2PictureBox2.Name = "Guna2PictureBox2";
            Guna2PictureBox2.ShadowDecoration.Parent = Guna2PictureBox2;
            Guna2PictureBox2.Size = new Size(96, 105);
            Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox2.TabIndex = 3;
            Guna2PictureBox2.TabStop = false;
            Guna2PictureBox2.UseTransparentBackground = true;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.FillColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(12, 338);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(59, 58);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 2;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(595, 615);
            Controls.Add(pnlNavig);
            Controls.Add(pnlVerify);
            Controls.Add(pnlCreate);
            Controls.Add(pnlDone);
            Controls.Add(picCheck);
            Controls.Add(pic2);
            Controls.Add(Guna2PictureBox9);
            Controls.Add(lblDone);
            Controls.Add(arrow2);
            Controls.Add(lblCreate);
            Controls.Add(Label4);
            Controls.Add(Label1);
            Controls.Add(Guna2PictureBox8);
            Controls.Add(arrow1);
            Controls.Add(Guna2PictureBox5);
            Controls.Add(Guna2PictureBox4);
            Controls.Add(Guna2PictureBox3);
            Controls.Add(Guna2PictureBox2);
            Controls.Add(Guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 984);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            pnlNavig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).EndInit();
            pnlVerify.ResumeLayout(false);
            pnlVerify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            pnlCreate.ResumeLayout(false);
            pnlCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            pnlDone.ResumeLayout(false);
            pnlDone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrow2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrow1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            Load += new EventHandler(Signup_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2ShadowPanel pnlVerify;
        internal Guna.UI2.WinForms.Guna2PictureBox arrow1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox5;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox4;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        internal Label Label1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox8;
        internal Guna.UI2.WinForms.Guna2Button btnVerify;
        internal Guna.UI2.WinForms.Guna2PictureBox btnBack;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2TextBox txtCode;
        internal Label lblEmail;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2PictureBox picCheck;
        internal Guna.UI2.WinForms.Guna2PictureBox pic2;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox9;
        internal Label lblDone;
        internal Guna.UI2.WinForms.Guna2PictureBox arrow2;
        internal Label lblCreate;
        internal Label Label4;
        internal Timer tmrResend;
        internal Label lblTimer;
        internal Label lblResend;
        internal Label lblQuestion;
        internal Guna.UI2.WinForms.Guna2TextBox txtPass;
        internal Guna.UI2.WinForms.Guna2TextBox txtUsername;
        internal Guna.UI2.WinForms.Guna2TextBox txtCPass;
        internal Guna.UI2.WinForms.Guna2ShadowPanel pnlCreate;
        internal Label lblUsername;
        internal Guna.UI2.WinForms.Guna2Button btnSignup;
        internal Label Label7;
        internal Label Label5;
        internal Label lblCPass;
        internal Label lblPass;
        internal Guna.UI2.WinForms.Guna2PictureBox picBack;
        internal Label lblError;
        internal Guna.UI2.WinForms.Guna2ImageCheckBox showPass;
        internal Guna.UI2.WinForms.Guna2ImageCheckBox showCPass;
        internal Label lblCodeError;
        internal Guna.UI2.WinForms.Guna2ShadowPanel pnlDone;
        internal Label Label6;
        internal Label lblRedirect;
        internal Guna.UI2.WinForms.Guna2Button btnDone;
        internal Label Label8;
        internal Label lblDEmail;
        internal Timer tmrRedirect;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox6;
        internal Guna.UI2.WinForms.Guna2Panel pnlNavig;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox3;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox4;
    }
}