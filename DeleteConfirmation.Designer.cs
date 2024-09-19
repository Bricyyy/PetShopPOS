using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DeleteConfirmation : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteConfirmation));
            lblConfirmation = new Label();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnCancel.Click += new EventHandler(btnCancel_Click);
            SuspendLayout();
            // 
            // lblConfirmation
            // 
            lblConfirmation.Font = new Font("Proxima Nova Rg", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmation.Location = new Point(12, 48);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(276, 23);
            lblConfirmation.TabIndex = 2;
            lblConfirmation.Text = "Delete Address?";
            lblConfirmation.TextAlign = ContentAlignment.MiddleCenter;
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
            btnDelete.Location = new Point(26, 113);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.Parent = btnDelete;
            btnDelete.Size = new Size(117, 32);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseTransparentBackground = true;
            // 
            // btnCancel
            // 
            btnCancel.Animated = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.LightGray;
            btnCancel.BorderRadius = 8;
            btnCancel.BorderThickness = 1;
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
            btnCancel.Location = new Point(149, 113);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.Parent = btnCancel;
            btnCancel.Size = new Size(117, 32);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseTransparentBackground = true;
            // 
            // DeleteConfirmation
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 170);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(lblConfirmation);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteConfirmation";
            Load += new EventHandler(DeleteConfirmation_Load);
            ResumeLayout(false);

        }

        internal Label lblConfirmation;
        internal Guna.UI2.WinForms.Guna2Button btnDelete;
        internal Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}