using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SavedConfirmation : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedConfirmation));
            lblConfirmation = new Label();
            btnDone = new Guna.UI2.WinForms.Guna2Button();
            btnDone.Click += new EventHandler(btnDone_Click);
            tmrClose = new Timer(components);
            tmrClose.Tick += new EventHandler(tmrClose_Tick);
            lblTime = new Label();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblConfirmation
            // 
            lblConfirmation.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmation.Location = new Point(-1, 78);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(301, 20);
            lblConfirmation.TabIndex = 1;
            lblConfirmation.Text = "Profile Updated";
            lblConfirmation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            btnDone.Animated = true;
            btnDone.BackColor = Color.Transparent;
            btnDone.BorderRadius = 8;
            btnDone.CheckedState.Parent = btnDone;
            btnDone.CustomImages.Parent = btnDone;
            btnDone.DisabledState.BorderColor = Color.DarkGray;
            btnDone.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDone.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDone.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDone.DisabledState.Parent = btnDone;
            btnDone.FillColor = Color.FromArgb(255, 152, 19);
            btnDone.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Bold);
            btnDone.ForeColor = Color.White;
            btnDone.HoverState.Parent = btnDone;
            btnDone.Location = new Point(93, 116);
            btnDone.Name = "btnDone";
            btnDone.ShadowDecoration.Parent = btnDone;
            btnDone.Size = new Size(117, 32);
            btnDone.TabIndex = 3;
            btnDone.Text = "Done";
            btnDone.UseTransparentBackground = true;
            // 
            // tmrClose
            // 
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(24, 61);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(19, 13);
            lblTime.TabIndex = 4;
            lblTime.Text = "03";
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(-1, 12);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(301, 52);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 0;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // SavedConfirmation
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 170);
            Controls.Add(lblTime);
            Controls.Add(btnDone);
            Controls.Add(lblConfirmation);
            Controls.Add(Guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SavedConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SavedConfirmation";
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            Load += new EventHandler(SavedConfirmation_Load);
            Closing += new System.ComponentModel.CancelEventHandler(SavedConfirmation_Closing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Label lblConfirmation;
        internal Guna.UI2.WinForms.Guna2Button btnDone;
        internal Timer tmrClose;
        internal Label lblTime;
    }
}