using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PictureBox1 = new PictureBox();
            progressbar = new PictureBox();
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressbar).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(-1, -1);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(481, 724);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // progressbar
            // 
            progressbar.Image = (Image)resources.GetObject("progressbar.Image");
            progressbar.Location = new Point(82, 672);
            progressbar.Name = "progressbar";
            progressbar.Size = new Size(27, 20);
            progressbar.TabIndex = 1;
            progressbar.TabStop = false;
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            // 
            // Guna2Elipse2
            // 
            Guna2Elipse2.TargetControl = progressbar;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 720);
            Controls.Add(progressbar);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressbar).EndInit();
            ResumeLayout(false);

        }

        internal PictureBox PictureBox1;
        internal PictureBox progressbar;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Timer Timer1;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse2;
    }
}