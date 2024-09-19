using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Homepage : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlNavig = new Guna.UI2.WinForms.Guna2Panel();
            Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            btnCloseProg = new Guna.UI2.WinForms.Guna2ControlBox();
            btnCloseProg.Click += new EventHandler(btnCloseProg_Click);
            lblUserInfo = new Label();
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            _btnManage = new Guna.UI2.WinForms.Guna2Button();
            _btnManage.Click += new EventHandler(btnManage_Click);
            pnlDim = new Panel();
            _btnSettings = new Guna.UI2.WinForms.Guna2Button();
            _btnSettings.Click += new EventHandler(btnSettings_Click);
            btnMessage = new Guna.UI2.WinForms.Guna2Button();
            btnMessage.Click += new EventHandler(btnMessage_Click);
            btnHistory = new Guna.UI2.WinForms.Guna2Button();
            btnHistory.Click += new EventHandler(btnHistory_Click);
            btnHome = new Guna.UI2.WinForms.Guna2Button();
            btnHome.Click += new EventHandler(btnHome_Click);
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            btnLogout.Click += new EventHandler(btnLogout_Click);
            btnLogout.MouseEnter += new EventHandler(btnLogout_MouseEnter);
            btnLogout.MouseLeave += new EventHandler(btnLogout_MouseLeave);
            Guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            _pnlMain = new Panel();
            pnlNavig.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.BorderRadius = 20;
            Guna2Elipse1.TargetControl = this;
            // 
            // pnlNavig
            // 
            pnlNavig.BackColor = SystemColors.Control;
            pnlNavig.BorderColor = Color.LightGray;
            pnlNavig.BorderThickness = 2;
            pnlNavig.Controls.Add(Guna2ControlBox2);
            pnlNavig.Controls.Add(btnCloseProg);
            pnlNavig.Controls.Add(lblUserInfo);
            pnlNavig.FillColor = Color.Transparent;
            pnlNavig.Location = new Point(-9, -9);
            pnlNavig.Name = "pnlNavig";
            pnlNavig.ShadowDecoration.Parent = pnlNavig;
            pnlNavig.Size = new Size(1090, 41);
            pnlNavig.TabIndex = 1;
            // 
            // Guna2ControlBox2
            // 
            Guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox2.BackColor = Color.Transparent;
            Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Guna2ControlBox2.FillColor = Color.Transparent;
            Guna2ControlBox2.HoverState.Parent = Guna2ControlBox2;
            Guna2ControlBox2.IconColor = Color.Black;
            Guna2ControlBox2.Location = new Point(992, 9);
            Guna2ControlBox2.Name = "Guna2ControlBox2";
            Guna2ControlBox2.ShadowDecoration.Parent = Guna2ControlBox2;
            Guna2ControlBox2.Size = new Size(45, 32);
            Guna2ControlBox2.TabIndex = 2;
            // 
            // btnCloseProg
            // 
            btnCloseProg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseProg.BackColor = Color.Transparent;
            btnCloseProg.FillColor = Color.Transparent;
            btnCloseProg.HoverState.Parent = btnCloseProg;
            btnCloseProg.IconColor = Color.Black;
            btnCloseProg.Location = new Point(1043, 9);
            btnCloseProg.Name = "btnCloseProg";
            btnCloseProg.ShadowDecoration.Parent = btnCloseProg;
            btnCloseProg.Size = new Size(45, 32);
            btnCloseProg.TabIndex = 1;
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.BackColor = Color.Transparent;
            lblUserInfo.ForeColor = SystemColors.Control;
            lblUserInfo.Location = new Point(150, 18);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(39, 13);
            lblUserInfo.TabIndex = 3;
            lblUserInfo.Text = "Label1";
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.TargetControl = pnlNavig;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.BorderColor = Color.LightGray;
            pnlMenu.Controls.Add(_btnManage);
            pnlMenu.Controls.Add(pnlDim);
            pnlMenu.Controls.Add(_btnSettings);
            pnlMenu.Controls.Add(btnMessage);
            pnlMenu.Controls.Add(btnHistory);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(Guna2PictureBox1);
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Location = new Point(0, 30);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.ShadowDecoration.Parent = pnlMenu;
            pnlMenu.Size = new Size(170, 687);
            pnlMenu.TabIndex = 4;
            // 
            // btnManage
            // 
            _btnManage.Animated = true;
            _btnManage.BackColor = Color.Transparent;
            _btnManage.BorderColor = Color.FromArgb(255, 152, 19);
            _btnManage.BorderRadius = 6;
            _btnManage.CheckedState.Parent = _btnManage;
            _btnManage.Cursor = Cursors.Hand;
            _btnManage.CustomImages.Parent = _btnManage;
            _btnManage.DisabledState.BorderColor = Color.DarkGray;
            _btnManage.DisabledState.CustomBorderColor = Color.DarkGray;
            _btnManage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            _btnManage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            _btnManage.DisabledState.Parent = _btnManage;
            _btnManage.FillColor = Color.Transparent;
            _btnManage.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            _btnManage.ForeColor = Color.Black;
            _btnManage.HoverState.Parent = _btnManage;
            _btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            _btnManage.ImageAlign = HorizontalAlignment.Left;
            _btnManage.Location = new Point(18, 407);
            _btnManage.Name = "_btnManage";
            _btnManage.ShadowDecoration.Parent = _btnManage;
            _btnManage.Size = new Size(130, 38);
            _btnManage.TabIndex = 62;
            _btnManage.Text = "Products";
            _btnManage.TextOffset = new Point(8, 0);
            _btnManage.UseTransparentBackground = true;
            // 
            // pnlDim
            // 
            pnlDim.BackColor = SystemColors.ControlDark;
            pnlDim.Location = new Point(42, 154);
            pnlDim.Name = "pnlDim";
            pnlDim.Size = new Size(55, 18);
            pnlDim.TabIndex = 61;
            pnlDim.Visible = false;
            // 
            // btnSettings
            // 
            _btnSettings.Animated = true;
            _btnSettings.BackColor = Color.Transparent;
            _btnSettings.BorderColor = Color.FromArgb(255, 152, 19);
            _btnSettings.BorderRadius = 6;
            _btnSettings.CheckedState.Parent = _btnSettings;
            _btnSettings.Cursor = Cursors.Hand;
            _btnSettings.CustomImages.Parent = _btnSettings;
            _btnSettings.DisabledState.BorderColor = Color.DarkGray;
            _btnSettings.DisabledState.CustomBorderColor = Color.DarkGray;
            _btnSettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            _btnSettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            _btnSettings.DisabledState.Parent = _btnSettings;
            _btnSettings.FillColor = Color.Transparent;
            _btnSettings.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            _btnSettings.ForeColor = Color.Black;
            _btnSettings.HoverState.Parent = _btnSettings;
            _btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            _btnSettings.ImageAlign = HorizontalAlignment.Left;
            _btnSettings.Location = new Point(18, 349);
            _btnSettings.Name = "_btnSettings";
            _btnSettings.ShadowDecoration.Parent = _btnSettings;
            _btnSettings.Size = new Size(130, 38);
            _btnSettings.TabIndex = 16;
            _btnSettings.Text = "Settings";
            _btnSettings.TextOffset = new Point(8, 0);
            _btnSettings.UseTransparentBackground = true;
            // 
            // btnMessage
            // 
            btnMessage.Animated = true;
            btnMessage.BackColor = Color.Transparent;
            btnMessage.BorderColor = Color.FromArgb(255, 152, 19);
            btnMessage.BorderRadius = 6;
            btnMessage.CheckedState.Parent = btnMessage;
            btnMessage.Cursor = Cursors.Hand;
            btnMessage.CustomImages.Parent = btnMessage;
            btnMessage.DisabledState.BorderColor = Color.DarkGray;
            btnMessage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMessage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMessage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMessage.DisabledState.Parent = btnMessage;
            btnMessage.FillColor = Color.Transparent;
            btnMessage.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            btnMessage.ForeColor = Color.Black;
            btnMessage.HoverState.Parent = btnMessage;
            btnMessage.Image = (Image)resources.GetObject("btnMessage.Image");
            btnMessage.ImageAlign = HorizontalAlignment.Left;
            btnMessage.Location = new Point(18, 291);
            btnMessage.Name = "btnMessage";
            btnMessage.ShadowDecoration.Parent = btnMessage;
            btnMessage.Size = new Size(130, 38);
            btnMessage.TabIndex = 15;
            btnMessage.Text = "Message";
            btnMessage.TextOffset = new Point(10, 0);
            btnMessage.UseTransparentBackground = true;
            // 
            // btnHistory
            // 
            btnHistory.Animated = true;
            btnHistory.BackColor = Color.Transparent;
            btnHistory.BorderColor = Color.FromArgb(255, 152, 19);
            btnHistory.BorderRadius = 6;
            btnHistory.CheckedState.Parent = btnHistory;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.CustomImages.Parent = btnHistory;
            btnHistory.DisabledState.BorderColor = Color.DarkGray;
            btnHistory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHistory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHistory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHistory.DisabledState.Parent = btnHistory;
            btnHistory.FillColor = Color.Transparent;
            btnHistory.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            btnHistory.ForeColor = Color.Black;
            btnHistory.HoverState.Parent = btnHistory;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = HorizontalAlignment.Left;
            btnHistory.Location = new Point(18, 234);
            btnHistory.Name = "btnHistory";
            btnHistory.ShadowDecoration.Parent = btnHistory;
            btnHistory.Size = new Size(130, 38);
            btnHistory.TabIndex = 14;
            btnHistory.Text = "History";
            btnHistory.TextOffset = new Point(5, 0);
            btnHistory.UseTransparentBackground = true;
            // 
            // btnHome
            // 
            btnHome.Animated = true;
            btnHome.BackColor = Color.Transparent;
            btnHome.BorderColor = Color.FromArgb(255, 152, 19);
            btnHome.BorderRadius = 6;
            btnHome.CheckedState.Parent = btnHome;
            btnHome.Cursor = Cursors.Hand;
            btnHome.CustomImages.Parent = btnHome;
            btnHome.DisabledState.BorderColor = Color.DarkGray;
            btnHome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHome.DisabledState.Parent = btnHome;
            btnHome.FillColor = Color.Transparent;
            btnHome.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            btnHome.ForeColor = Color.Black;
            btnHome.HoverState.Parent = btnHome;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = HorizontalAlignment.Left;
            btnHome.Location = new Point(18, 178);
            btnHome.Name = "btnHome";
            btnHome.ShadowDecoration.Parent = btnHome;
            btnHome.Size = new Size(130, 38);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.UseTransparentBackground = true;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.FillColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(27, 38);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(106, 97);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 12;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnLogout
            // 
            btnLogout.Animated = true;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BorderColor = Color.FromArgb(255, 152, 19);
            btnLogout.BorderRadius = 6;
            btnLogout.CheckedState.Parent = btnLogout;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.CustomImages.Parent = btnLogout;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.DisabledState.Parent = btnLogout;
            btnLogout.FillColor = Color.Transparent;
            btnLogout.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold);
            btnLogout.ForeColor = Color.Black;
            btnLogout.HoverState.Parent = btnLogout;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = HorizontalAlignment.Left;
            btnLogout.Location = new Point(18, 628);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.Parent = btnLogout;
            btnLogout.Size = new Size(130, 38);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.TextOffset = new Point(6, 0);
            btnLogout.UseTransparentBackground = true;
            // 
            // Guna2Elipse2
            // 
            Guna2Elipse2.BorderRadius = 20;
            Guna2Elipse2.TargetControl = pnlMenu;
            // 
            // pnlMain
            // 
            _pnlMain.AccessibleRole = AccessibleRole.None;
            _pnlMain.Location = new Point(170, 34);
            _pnlMain.Name = "_pnlMain";
            _pnlMain.Size = new Size(909, 683);
            _pnlMain.TabIndex = 5;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1080, 720);
            Controls.Add(_pnlMain);
            Controls.Add(pnlNavig);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            pnlNavig.ResumeLayout(false);
            pnlNavig.PerformLayout();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            Load += new EventHandler(Homepage_Load);
            Closing += new System.ComponentModel.CancelEventHandler(Homepage_Closing);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2Panel pnlNavig;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
        internal Guna.UI2.WinForms.Guna2ControlBox btnCloseProg;
        internal Guna.UI2.WinForms.Guna2Button btnLogout;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Label lblUserInfo;
        internal Guna.UI2.WinForms.Guna2Panel pnlMenu;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse2;
        internal Guna.UI2.WinForms.Guna2Button btnHome;
        internal Guna.UI2.WinForms.Guna2Button btnMessage;
        internal Guna.UI2.WinForms.Guna2Button btnHistory;
        private Panel _pnlMain;

        public virtual Panel pnlMain
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlMain;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _pnlMain = value;
            }
        }
        private Guna.UI2.WinForms.Guna2Button _btnSettings;

        public virtual Guna.UI2.WinForms.Guna2Button btnSettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSettings != null)
                {
                    _btnSettings.Click -= btnSettings_Click;
                }

                _btnSettings = value;
                if (_btnSettings != null)
                {
                    _btnSettings.Click += btnSettings_Click;
                }
            }
        }
        internal Panel pnlDim;
        private Guna.UI2.WinForms.Guna2Button _btnManage;

        public virtual Guna.UI2.WinForms.Guna2Button btnManage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnManage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnManage != null)
                {
                    _btnManage.Click -= btnManage_Click;
                }

                _btnManage = value;
                if (_btnManage != null)
                {
                    _btnManage.Click += btnManage_Click;
                }
            }
        }
    }
}