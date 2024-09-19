using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddressNotice : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressNotice));
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnCancel.Click += new EventHandler(btnCancel_Click);
            lblConfirmation = new Label();
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Animated = true;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderRadius = 8;
            btnDelete.CheckedState.Parent = btnDelete;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CustomImages.Parent = btnDelete;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.DisabledState.Parent = btnDelete;
            btnDelete.FillColor = Color.FromArgb(255, 152, 19);
            btnDelete.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.Parent = btnDelete;
            btnDelete.Location = new Point(31, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.Parent = btnDelete;
            btnDelete.Size = new Size(117, 32);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "New Address";
            btnDelete.UseTransparentBackground = true;
            // 
            // btnCancel
            // 
            btnCancel.Animated = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.LightGray;
            btnCancel.BorderRadius = 8;
            btnCancel.BorderThickness = 1;
            btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCancel.CheckedState.Parent = btnCancel;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomImages.Parent = btnCancel;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.DisabledState.Parent = btnCancel;
            btnCancel.FillColor = Color.Transparent;
            btnCancel.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.HoverState.Parent = btnCancel;
            btnCancel.Location = new Point(154, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.Parent = btnCancel;
            btnCancel.Size = new Size(117, 32);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Back";
            btnCancel.UseTransparentBackground = true;
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmation.Location = new Point(49, 67);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(213, 36);
            lblConfirmation.TabIndex = 8;
            lblConfirmation.Text = "Kindly update your address" + '\r' + '\n' + "before proceeding to checkout.";
            lblConfirmation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(127, 13);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(48, 51);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox1.TabIndex = 7;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // AddressNotice
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 170);
            Controls.Add(lblConfirmation);
            Controls.Add(Guna2PictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddressNotice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddressNotice";
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            Load += new EventHandler(AddressNotice_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2Button btnDelete;
        internal Guna.UI2.WinForms.Guna2Button btnCancel;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Label lblConfirmation;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
    }
}