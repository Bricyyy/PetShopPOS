using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class forgotPassForm : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPassForm));
            forgotPassDragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlNavig = new Guna.UI2.WinForms.Guna2Panel();
            Guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            emailReset = new Guna.UI2.WinForms.Guna2TextBox();
            emailReset.TextChanged += new EventHandler(Guna2TextBox1_TextChanged);
            emailReset.KeyDown += new KeyEventHandler(emailReset_KeyDown);
            btnSend = new Guna.UI2.WinForms.Guna2Button();
            btnSend.Click += new EventHandler(btnSend_Click);
            ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            createNewAcc = new Label();
            createNewAcc.Click += new EventHandler(createNewAcc_Click);
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            btnBack.Click += new EventHandler(Guna2Button2_Click);
            Label1 = new Label();
            Label2 = new Label();
            sendPanel = new Guna.UI2.WinForms.Guna2Panel();
            txtError = new Label();
            Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            verifyPanel = new Guna.UI2.WinForms.Guna2Panel();
            txtCodeCheck = new Label();
            txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            txtCode.TextChanged += new EventHandler(Guna2TextBox2_TextChanged);
            txtCode.KeyPress += new KeyPressEventHandler(txtCode_KeyPress);
            txtCode.KeyDown += new KeyEventHandler(txtCode_KeyDown);
            Label3 = new Label();
            btnVerify = new Guna.UI2.WinForms.Guna2Button();
            btnVerify.Click += new EventHandler(Guna2Button3_Click);
            Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            Label4 = new Label();
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            resetPanel = new Guna.UI2.WinForms.Guna2PictureBox();
            pnlNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).BeginInit();
            sendPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).BeginInit();
            verifyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resetPanel).BeginInit();
            SuspendLayout();
            // 
            // forgotPassDragControl
            // 
            forgotPassDragControl.TargetControl = pnlNavig;
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
            pnlNavig.Size = new Size(370, 29);
            pnlNavig.TabIndex = 21;
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
            Guna2ControlBox3.Location = new Point(274, 0);
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
            Guna2ControlBox4.Location = new Point(325, 0);
            Guna2ControlBox4.Name = "Guna2ControlBox4";
            Guna2ControlBox4.ShadowDecoration.Parent = Guna2ControlBox4;
            Guna2ControlBox4.Size = new Size(45, 29);
            Guna2ControlBox4.TabIndex = 1;
            // 
            // emailReset
            // 
            emailReset.Animated = true;
            emailReset.BorderRadius = 8;
            emailReset.Cursor = Cursors.IBeam;
            emailReset.DefaultText = "";
            emailReset.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailReset.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailReset.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailReset.DisabledState.Parent = emailReset;
            emailReset.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailReset.FillColor = Color.FromArgb(229, 229, 229);
            emailReset.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailReset.FocusedState.Parent = emailReset;
            emailReset.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            emailReset.ForeColor = Color.FromArgb(84, 37, 3);
            emailReset.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailReset.HoverState.Parent = emailReset;
            emailReset.Location = new Point(40, 198);
            emailReset.Margin = new Padding(4, 4, 4, 4);
            emailReset.Name = "emailReset";
            emailReset.PasswordChar = '\0';
            emailReset.PlaceholderText = "Email";
            emailReset.SelectedText = "";
            emailReset.ShadowDecoration.Parent = emailReset;
            emailReset.Size = new Size(229, 41);
            emailReset.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Animated = true;
            btnSend.BorderRadius = 8;
            btnSend.CheckedState.Parent = btnSend;
            btnSend.Cursor = Cursors.Hand;
            btnSend.CustomImages.Parent = btnSend;
            btnSend.DisabledState.BorderColor = Color.DarkGray;
            btnSend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSend.DisabledState.Parent = btnSend;
            btnSend.FillColor = Color.FromArgb(255, 152, 19);
            btnSend.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.HoverState.Parent = btnSend;
            btnSend.Location = new Point(40, 263);
            btnSend.Name = "btnSend";
            btnSend.ShadowDecoration.Parent = btnSend;
            btnSend.Size = new Size(229, 32);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            // 
            // ShapeContainer1
            // 
            ShapeContainer1.Location = new Point(0, 0);
            ShapeContainer1.Margin = new Padding(0);
            ShapeContainer1.Name = "ShapeContainer1";
            ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] { RectangleShape1 });
            ShapeContainer1.Size = new Size(370, 576);
            ShapeContainer1.TabIndex = 5;
            ShapeContainer1.TabStop = false;
            // 
            // RectangleShape1
            // 
            RectangleShape1.BorderColor = Color.Transparent;
            RectangleShape1.FillColor = SystemColors.ActiveCaptionText;
            RectangleShape1.FillGradientColor = Color.Transparent;
            RectangleShape1.Location = new Point(-110, -6);
            RectangleShape1.Name = "RectangleShape1";
            RectangleShape1.Size = new Size(96, 3);
            // 
            // createNewAcc
            // 
            createNewAcc.AutoSize = true;
            createNewAcc.Cursor = Cursors.Hand;
            createNewAcc.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewAcc.Location = new Point(117, 435);
            createNewAcc.Name = "createNewAcc";
            createNewAcc.Size = new Size(147, 18);
            createNewAcc.TabIndex = 7;
            createNewAcc.Text = "Create New Account";
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
            btnBack.Location = new Point(-5, 530);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.Parent = btnBack;
            btnBack.Size = new Size(376, 45);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back To Login";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ActiveBorder;
            Label1.Location = new Point(19, 151);
            Label1.Name = "Label1";
            Label1.Size = new Size(272, 32);
            Label1.TabIndex = 9;
            Label1.Text = "Enter your email address and we'll send you a" + '\r' + '\n' + "verification code to get back into" + " your account.";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(79, 116);
            Label2.Name = "Label2";
            Label2.Size = new Size(146, 20);
            Label2.TabIndex = 11;
            Label2.Text = "Trouble Logging In?";
            // 
            // sendPanel
            // 
            sendPanel.Controls.Add(txtError);
            sendPanel.Controls.Add(emailReset);
            sendPanel.Controls.Add(Label2);
            sendPanel.Controls.Add(btnSend);
            sendPanel.Controls.Add(Guna2PictureBox2);
            sendPanel.Controls.Add(Label1);
            sendPanel.Location = new Point(33, 61);
            sendPanel.Name = "sendPanel";
            sendPanel.ShadowDecoration.Parent = sendPanel;
            sendPanel.Size = new Size(302, 304);
            sendPanel.TabIndex = 12;
            // 
            // txtError
            // 
            txtError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            txtError.AutoSize = true;
            txtError.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtError.ForeColor = Color.IndianRed;
            txtError.Location = new Point(39, 244);
            txtError.Name = "txtError";
            txtError.Size = new Size(33, 13);
            txtError.TabIndex = 12;
            txtError.Text = "Error.";
            txtError.TextAlign = ContentAlignment.MiddleCenter;
            txtError.Visible = false;
            // 
            // Guna2PictureBox2
            // 
            Guna2PictureBox2.BackColor = Color.Transparent;
            Guna2PictureBox2.FillColor = Color.Transparent;
            Guna2PictureBox2.Image = (Image)resources.GetObject("Guna2PictureBox2.Image");
            Guna2PictureBox2.ImageRotate = 0f;
            Guna2PictureBox2.Location = new Point(106, 21);
            Guna2PictureBox2.Name = "Guna2PictureBox2";
            Guna2PictureBox2.ShadowDecoration.Parent = Guna2PictureBox2;
            Guna2PictureBox2.Size = new Size(84, 82);
            Guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox2.TabIndex = 10;
            Guna2PictureBox2.TabStop = false;
            Guna2PictureBox2.UseTransparentBackground = true;
            // 
            // verifyPanel
            // 
            verifyPanel.Controls.Add(txtCodeCheck);
            verifyPanel.Controls.Add(txtCode);
            verifyPanel.Controls.Add(Label3);
            verifyPanel.Controls.Add(btnVerify);
            verifyPanel.Controls.Add(Guna2PictureBox3);
            verifyPanel.Controls.Add(Label4);
            verifyPanel.Location = new Point(33, 64);
            verifyPanel.Name = "verifyPanel";
            verifyPanel.ShadowDecoration.Parent = verifyPanel;
            verifyPanel.Size = new Size(302, 304);
            verifyPanel.TabIndex = 13;
            // 
            // txtCodeCheck
            // 
            txtCodeCheck.AutoSize = true;
            txtCodeCheck.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodeCheck.ForeColor = Color.IndianRed;
            txtCodeCheck.Location = new Point(39, 244);
            txtCodeCheck.Name = "txtCodeCheck";
            txtCodeCheck.Size = new Size(40, 13);
            txtCodeCheck.TabIndex = 12;
            txtCodeCheck.Text = "Invalid";
            txtCodeCheck.Visible = false;
            // 
            // txtCode
            // 
            txtCode.Animated = true;
            txtCode.BorderRadius = 8;
            txtCode.Cursor = Cursors.IBeam;
            txtCode.DefaultText = "";
            txtCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCode.DisabledState.Parent = txtCode;
            txtCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCode.FillColor = Color.FromArgb(229, 229, 229);
            txtCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCode.FocusedState.Parent = txtCode;
            txtCode.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            txtCode.ForeColor = Color.FromArgb(84, 37, 3);
            txtCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCode.HoverState.Parent = txtCode;
            txtCode.Location = new Point(40, 198);
            txtCode.Margin = new Padding(4, 4, 4, 4);
            txtCode.Name = "txtCode";
            txtCode.PasswordChar = '\0';
            txtCode.PlaceholderText = "Code";
            txtCode.SelectedText = "";
            txtCode.ShadowDecoration.Parent = txtCode;
            txtCode.Size = new Size(229, 41);
            txtCode.TabIndex = 0;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(79, 106);
            Label3.Name = "Label3";
            Label3.Size = new Size(148, 20);
            Label3.TabIndex = 11;
            Label3.Text = "Verify Your Account";
            // 
            // btnVerify
            // 
            btnVerify.Animated = true;
            btnVerify.BorderRadius = 8;
            btnVerify.CheckedState.Parent = btnVerify;
            btnVerify.Cursor = Cursors.Hand;
            btnVerify.CustomImages.Parent = btnVerify;
            btnVerify.DisabledState.BorderColor = Color.DarkGray;
            btnVerify.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVerify.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVerify.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVerify.DisabledState.Parent = btnVerify;
            btnVerify.FillColor = Color.FromArgb(255, 152, 19);
            btnVerify.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            btnVerify.ForeColor = Color.White;
            btnVerify.HoverState.Parent = btnVerify;
            btnVerify.Location = new Point(40, 263);
            btnVerify.Name = "btnVerify";
            btnVerify.ShadowDecoration.Parent = btnVerify;
            btnVerify.Size = new Size(229, 32);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "Verify";
            // 
            // Guna2PictureBox3
            // 
            Guna2PictureBox3.BackColor = Color.Transparent;
            Guna2PictureBox3.FillColor = Color.Transparent;
            Guna2PictureBox3.Image = (Image)resources.GetObject("Guna2PictureBox3.Image");
            Guna2PictureBox3.ImageRotate = 0f;
            Guna2PictureBox3.Location = new Point(109, 21);
            Guna2PictureBox3.Name = "Guna2PictureBox3";
            Guna2PictureBox3.ShadowDecoration.Parent = Guna2PictureBox3;
            Guna2PictureBox3.Size = new Size(84, 82);
            Guna2PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox3.TabIndex = 10;
            Guna2PictureBox3.TabStop = false;
            Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = SystemColors.ActiveBorder;
            Label4.Location = new Point(46, 151);
            Label4.Name = "Label4";
            Label4.Size = new Size(216, 32);
            Label4.TabIndex = 9;
            Label4.Text = "We have sent the code to your email." + '\r' + '\n' + "Please verify to reset your account.";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // resetPanel
            // 
            resetPanel.BackColor = Color.Transparent;
            resetPanel.FillColor = Color.Transparent;
            resetPanel.Image = (Image)resources.GetObject("resetPanel.Image");
            resetPanel.ImageRotate = 0f;
            resetPanel.Location = new Point(-2, 102);
            resetPanel.Name = "resetPanel";
            resetPanel.ShadowDecoration.Parent = resetPanel;
            resetPanel.Size = new Size(370, 535);
            resetPanel.SizeMode = PictureBoxSizeMode.AutoSize;
            resetPanel.TabIndex = 6;
            resetPanel.TabStop = false;
            resetPanel.UseTransparentBackground = true;
            // 
            // forgotPassForm
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(370, 576);
            Controls.Add(sendPanel);
            Controls.Add(pnlNavig);
            Controls.Add(btnBack);
            Controls.Add(createNewAcc);
            Controls.Add(verifyPanel);
            Controls.Add(resetPanel);
            Controls.Add(ShapeContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 984);
            Name = "forgotPassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "forgotPassForm";
            pnlNavig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).EndInit();
            sendPanel.ResumeLayout(false);
            sendPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).EndInit();
            verifyPanel.ResumeLayout(false);
            verifyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)resetPanel).EndInit();
            Load += new EventHandler(forgotPassForm_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Guna.UI2.WinForms.Guna2DragControl forgotPassDragControl;
        internal Guna.UI2.WinForms.Guna2TextBox emailReset;
        internal Guna.UI2.WinForms.Guna2Button btnSend;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape1;
        internal Guna.UI2.WinForms.Guna2Button btnBack;
        internal Label createNewAcc;
        internal Guna.UI2.WinForms.Guna2PictureBox resetPanel;
        internal Label Label1;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        internal Guna.UI2.WinForms.Guna2Panel sendPanel;
        internal Guna.UI2.WinForms.Guna2Panel verifyPanel;
        internal Guna.UI2.WinForms.Guna2TextBox txtCode;
        internal Label Label3;
        internal Guna.UI2.WinForms.Guna2Button btnVerify;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal Label Label4;
        internal Label txtError;
        internal Label txtCodeCheck;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2Panel pnlNavig;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox3;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox4;
    }
}