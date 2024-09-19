using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Label1 = new System.Windows.Forms.Label();
            this.lblEmailChecker = new System.Windows.Forms.Label();
            this.lblSmail = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.forgPass = new System.Windows.Forms.LinkLabel();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblSignup = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblChecker = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.signupEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordShow = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.showPass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlNavig = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCloseProg = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.signupPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).BeginInit();
            this.pnlNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("iCiel Rukola", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.Label1.Location = new System.Drawing.Point(27, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(402, 115);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Sign in to Puppy Love";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailChecker
            // 
            this.lblEmailChecker.AutoSize = true;
            this.lblEmailChecker.Font = new System.Drawing.Font("Proxima Nova Lt", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailChecker.ForeColor = System.Drawing.Color.IndianRed;
            this.lblEmailChecker.Location = new System.Drawing.Point(53, 195);
            this.lblEmailChecker.Name = "lblEmailChecker";
            this.lblEmailChecker.Size = new System.Drawing.Size(73, 13);
            this.lblEmailChecker.TabIndex = 21;
            this.lblEmailChecker.Text = "Invalid Email.";
            this.lblEmailChecker.Visible = false;
            // 
            // lblSmail
            // 
            this.lblSmail.AutoSize = true;
            this.lblSmail.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSmail.Location = new System.Drawing.Point(54, 128);
            this.lblSmail.Name = "lblSmail";
            this.lblSmail.Size = new System.Drawing.Size(38, 16);
            this.lblSmail.TabIndex = 20;
            this.lblSmail.Text = "Email";
            this.lblSmail.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 6;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.DisabledState.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.btnNext.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(85, 217);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseTransparentBackground = true;
            this.btnNext.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(35, 71);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(295, 42);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Enter the email that will be associated\r\nto your account";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(8, 42);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(351, 29);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Welcome, Create your account";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.lblLogin.Location = new System.Drawing.Point(252, 346);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 21);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.Label6_Click_1);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label2.Location = new System.Drawing.Point(53, 346);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(203, 21);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Already have an account?";
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.chkRememberMe.CheckedState.BorderRadius = 5;
            this.chkRememberMe.CheckedState.BorderThickness = 0;
            this.chkRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.chkRememberMe.Location = new System.Drawing.Point(51, 234);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(113, 19);
            this.chkRememberMe.TabIndex = 10;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRememberMe.UncheckedState.BorderRadius = 5;
            this.chkRememberMe.UncheckedState.BorderThickness = 0;
            this.chkRememberMe.UncheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // forgPass
            // 
            this.forgPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(37)))), ((int)(((byte)(3)))));
            this.forgPass.AutoSize = true;
            this.forgPass.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgPass.LinkColor = System.Drawing.SystemColors.AppWorkspace;
            this.forgPass.Location = new System.Drawing.Point(184, 234);
            this.forgPass.Name = "forgPass";
            this.forgPass.Size = new System.Drawing.Size(112, 15);
            this.forgPass.TabIndex = 15;
            this.forgPass.TabStop = true;
            this.forgPass.Text = "Forgot Password?";
            this.forgPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label5.Location = new System.Drawing.Point(51, 346);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(186, 21);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Don\'t have an account?";
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignup.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.lblSignup.Location = new System.Drawing.Point(232, 346);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(63, 21);
            this.lblSignup.TabIndex = 14;
            this.lblSignup.Text = "Signup";
            this.lblSignup.Click += new System.EventHandler(this.Label6_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderRadius = 21;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.btnLogin.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(83, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblChecker
            // 
            this.lblChecker.AutoSize = true;
            this.lblChecker.Font = new System.Drawing.Font("Proxima Nova Lt", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecker.ForeColor = System.Drawing.Color.IndianRed;
            this.lblChecker.Location = new System.Drawing.Point(51, 215);
            this.lblChecker.Name = "lblChecker";
            this.lblChecker.Size = new System.Drawing.Size(136, 13);
            this.lblChecker.TabIndex = 18;
            this.lblChecker.Text = "Invalid Email or Password.";
            this.lblChecker.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEmail.Location = new System.Drawing.Point(51, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 16);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPass.Location = new System.Drawing.Point(51, 154);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(62, 16);
            this.lblPass.TabIndex = 20;
            this.lblPass.Text = "Password";
            this.lblPass.Visible = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(4, 71);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(355, 21);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Sign in with your Email Address and Password";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(77, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(204, 33);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Welcome Back";
            // 
            // signupPanel
            // 
            this.signupPanel.Controls.Add(this.lblEmailChecker);
            this.signupPanel.Controls.Add(this.Label8);
            this.signupPanel.Controls.Add(this.lblSmail);
            this.signupPanel.Controls.Add(this.Label2);
            this.signupPanel.Controls.Add(this.btnNext);
            this.signupPanel.Controls.Add(this.lblLogin);
            this.signupPanel.Controls.Add(this.signupEmail);
            this.signupPanel.Controls.Add(this.Label7);
            this.signupPanel.Location = new System.Drawing.Point(43, 159);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(365, 378);
            this.signupPanel.TabIndex = 21;
            // 
            // signupEmail
            // 
            this.signupEmail.BorderRadius = 8;
            this.signupEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupEmail.DefaultText = "";
            this.signupEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupEmail.DisabledState.Parent = this.signupEmail;
            this.signupEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.signupEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupEmail.FocusedState.Parent = this.signupEmail;
            this.signupEmail.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold);
            this.signupEmail.ForeColor = System.Drawing.Color.Black;
            this.signupEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupEmail.HoverState.Parent = this.signupEmail;
            this.signupEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("signupEmail.IconLeft")));
            this.signupEmail.Location = new System.Drawing.Point(52, 148);
            this.signupEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupEmail.Name = "signupEmail";
            this.signupEmail.PasswordChar = '\0';
            this.signupEmail.PlaceholderText = "Email";
            this.signupEmail.SelectedText = "";
            this.signupEmail.ShadowDecoration.Parent = this.signupEmail;
            this.signupEmail.Size = new System.Drawing.Size(245, 43);
            this.signupEmail.TabIndex = 18;
            this.signupEmail.TextChanged += new System.EventHandler(this.signupEmail_TextChanged);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passwordShow);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.forgPass);
            this.loginPanel.Controls.Add(this.Label3);
            this.loginPanel.Controls.Add(this.Label5);
            this.loginPanel.Controls.Add(this.Label4);
            this.loginPanel.Controls.Add(this.chkRememberMe);
            this.loginPanel.Controls.Add(this.lblSignup);
            this.loginPanel.Controls.Add(this.txtEmail);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.lblPass);
            this.loginPanel.Controls.Add(this.lblChecker);
            this.loginPanel.Controls.Add(this.lblEmail);
            this.loginPanel.Location = new System.Drawing.Point(40, 156);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(368, 378);
            this.loginPanel.TabIndex = 22;
            // 
            // passwordShow
            // 
            this.passwordShow.BackColor = System.Drawing.Color.Transparent;
            this.passwordShow.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.passwordShow.CheckedState.Parent = this.passwordShow;
            this.passwordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordShow.HoverState.Parent = this.passwordShow;
            this.passwordShow.Image = ((System.Drawing.Image)(resources.GetObject("passwordShow.Image")));
            this.passwordShow.ImageOffset = new System.Drawing.Point(0, 0);
            this.passwordShow.ImageRotate = 0F;
            this.passwordShow.Location = new System.Drawing.Point(263, 174);
            this.passwordShow.Name = "passwordShow";
            this.passwordShow.PressedState.Parent = this.passwordShow;
            this.passwordShow.ShadowDecoration.Parent = this.passwordShow;
            this.passwordShow.Size = new System.Drawing.Size(31, 33);
            this.passwordShow.TabIndex = 9;
            this.passwordShow.UseTransparentBackground = true;
            this.passwordShow.CheckedChanged += new System.EventHandler(this.Guna2ImageCheckBox1_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconRight")));
            this.txtPassword.Location = new System.Drawing.Point(51, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(245, 36);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtEmail.IconLeft")));
            this.txtEmail.Location = new System.Drawing.Point(51, 116);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(245, 36);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // Guna2Elipse1
            // 
            this.Guna2Elipse1.TargetControl = this;
            // 
            // Guna2PictureBox2
            // 
            this.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox2.Image")));
            this.Guna2PictureBox2.ImageRotate = 0F;
            this.Guna2PictureBox2.Location = new System.Drawing.Point(1, 35);
            this.Guna2PictureBox2.Name = "Guna2PictureBox2";
            this.Guna2PictureBox2.ShadowDecoration.Parent = this.Guna2PictureBox2;
            this.Guna2PictureBox2.Size = new System.Drawing.Size(56, 51);
            this.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox2.TabIndex = 2;
            this.Guna2PictureBox2.TabStop = false;
            this.Guna2PictureBox2.UseTransparentBackground = true;
            // 
            // showPass
            // 
            this.showPass.BackColor = System.Drawing.Color.Transparent;
            this.showPass.FillColor = System.Drawing.Color.Transparent;
            this.showPass.Image = ((System.Drawing.Image)(resources.GetObject("showPass.Image")));
            this.showPass.ImageRotate = 0F;
            this.showPass.Location = new System.Drawing.Point(461, 30);
            this.showPass.Name = "showPass";
            this.showPass.ShadowDecoration.Parent = this.showPass;
            this.showPass.Size = new System.Drawing.Size(357, 521);
            this.showPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPass.TabIndex = 1;
            this.showPass.TabStop = false;
            this.showPass.UseTransparentBackground = true;
            // 
            // pnlNavig
            // 
            this.pnlNavig.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNavig.Controls.Add(this.Guna2PictureBox7);
            this.pnlNavig.Controls.Add(this.Guna2ControlBox3);
            this.pnlNavig.Controls.Add(this.btnCloseProg);
            this.pnlNavig.Location = new System.Drawing.Point(-2, -1);
            this.pnlNavig.Name = "pnlNavig";
            this.pnlNavig.ShadowDecoration.Parent = this.pnlNavig;
            this.pnlNavig.Size = new System.Drawing.Size(820, 32);
            this.pnlNavig.TabIndex = 23;
            // 
            // Guna2PictureBox7
            // 
            this.Guna2PictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox7.FillColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox7.Image")));
            this.Guna2PictureBox7.ImageRotate = 0F;
            this.Guna2PictureBox7.Location = new System.Drawing.Point(4, 2);
            this.Guna2PictureBox7.Name = "Guna2PictureBox7";
            this.Guna2PictureBox7.ShadowDecoration.Parent = this.Guna2PictureBox7;
            this.Guna2PictureBox7.Size = new System.Drawing.Size(32, 30);
            this.Guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox7.TabIndex = 24;
            this.Guna2PictureBox7.TabStop = false;
            this.Guna2PictureBox7.UseTransparentBackground = true;
            // 
            // Guna2ControlBox3
            // 
            this.Guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.Guna2ControlBox3.HoverState.Parent = this.Guna2ControlBox3;
            this.Guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.Guna2ControlBox3.Location = new System.Drawing.Point(719, 2);
            this.Guna2ControlBox3.Name = "Guna2ControlBox3";
            this.Guna2ControlBox3.ShadowDecoration.Parent = this.Guna2ControlBox3;
            this.Guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.Guna2ControlBox3.TabIndex = 2;
            // 
            // btnCloseProg
            // 
            this.btnCloseProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseProg.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseProg.HoverState.Parent = this.btnCloseProg;
            this.btnCloseProg.IconColor = System.Drawing.Color.Black;
            this.btnCloseProg.Location = new System.Drawing.Point(770, 2);
            this.btnCloseProg.Name = "btnCloseProg";
            this.btnCloseProg.ShadowDecoration.Parent = this.btnCloseProg;
            this.btnCloseProg.Size = new System.Drawing.Size(45, 29);
            this.btnCloseProg.TabIndex = 1;
            this.btnCloseProg.Click += new System.EventHandler(this.btnCloseProg_Click);
            // 
            // Guna2DragControl1
            // 
            this.Guna2DragControl1.TargetControl = this.pnlNavig;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 550);
            this.Controls.Add(this.pnlNavig);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.signupPanel);
            this.Controls.Add(this.Guna2PictureBox2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.showPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Login_Closing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).EndInit();
            this.pnlNavig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        internal Label Label1;
        internal Label lblLogin;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2TextBox signupEmail;
        internal Label Label8;
        internal Label Label7;
        internal Guna.UI2.WinForms.Guna2Button btnNext;
        internal Label lblSmail;
        internal Label lblEmailChecker;
        internal Label Label3;
        internal Label Label4;
        internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
        internal Guna.UI2.WinForms.Guna2TextBox txtEmail;
        internal Label lblPass;
        internal Label lblEmail;
        internal Label lblChecker;
        internal Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        internal Label lblSignup;
        internal Guna.UI2.WinForms.Guna2CheckBox chkRememberMe;
        internal Label Label5;
        internal LinkLabel forgPass;
        internal Guna.UI2.WinForms.Guna2ImageCheckBox passwordShow;
        internal Panel signupPanel;
        internal Panel loginPanel;
        internal Guna.UI2.WinForms.Guna2PictureBox showPass;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2Panel pnlNavig;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox3;
        internal Guna.UI2.WinForms.Guna2ControlBox btnCloseProg;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
    }
}