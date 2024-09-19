using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CodeVerification : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeVerification));
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnDone = new Guna.UI2.WinForms.Guna2Button();
            btnDone.Click += new EventHandler(btnDone_Click);
            lblConfirmation = new Label();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(0, 20);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(301, 52);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 5;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
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
            btnDone.Location = new Point(92, 123);
            btnDone.Name = "btnDone";
            btnDone.ShadowDecoration.Parent = btnDone;
            btnDone.Size = new Size(117, 32);
            btnDone.TabIndex = 7;
            btnDone.Text = "Done";
            btnDone.UseTransparentBackground = true;
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmation.Location = new Point(20, 86);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(261, 20);
            lblConfirmation.TabIndex = 8;
            lblConfirmation.Text = "Verification Code Sent Successfully!";
            // 
            // CodeVerification
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 170);
            Controls.Add(lblConfirmation);
            Controls.Add(btnDone);
            Controls.Add(Guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CodeVerification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeVerification";
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2Button btnDone;
        internal Label lblConfirmation;
    }
}