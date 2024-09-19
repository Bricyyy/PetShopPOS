using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddressPopUp : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressPopUp));
            lblChecker = new Label();
            btnWork = new Guna.UI2.WinForms.Guna2Button();
            btnWork.Click += new EventHandler(btnWork_Click);
            btnHome = new Guna.UI2.WinForms.Guna2Button();
            btnHome.Click += new EventHandler(btnHome_Click);
            Label5 = new Label();
            txtStreet = new Guna.UI2.WinForms.Guna2TextBox();
            txtStreet.TextChanged += new EventHandler(txtStreet_TextChanged);
            txtPostalCode = new Guna.UI2.WinForms.Guna2TextBox();
            txtPostalCode.TextChanged += new EventHandler(txtPostalCode_TextChanged);
            txtPostalCode.KeyPress += new KeyPressEventHandler(txtPostalCode_KeyPress);
            txtRegion = new Guna.UI2.WinForms.Guna2TextBox();
            txtRegion.TextChanged += new EventHandler(txtRegion_TextChanged);
            lblTitle = new Label();
            chkDefault = new Guna.UI2.WinForms.Guna2CheckBox();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnCancel.Click += new EventHandler(btnCancel_Click);
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            txtPhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            txtPhoneNum.TextChanged += new EventHandler(txtPhoneNum_TextChanged);
            txtPhoneNum.KeyPress += new KeyPressEventHandler(txtPhoneNum_KeyPress);
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            txtFullName.TextChanged += new EventHandler(txtFullName_TextChanged);
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // lblChecker
            // 
            lblChecker.AutoSize = true;
            lblChecker.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChecker.ForeColor = Color.IndianRed;
            lblChecker.Location = new Point(26, 279);
            lblChecker.Name = "lblChecker";
            lblChecker.Size = new Size(119, 13);
            lblChecker.TabIndex = 79;
            lblChecker.Text = "Some fields are empty.";
            lblChecker.Visible = false;
            // 
            // btnWork
            // 
            btnWork.Animated = true;
            btnWork.BackColor = Color.Transparent;
            btnWork.BorderColor = Color.FromArgb(213, 218, 223);
            btnWork.BorderRadius = 2;
            btnWork.BorderThickness = 1;
            btnWork.CheckedState.Parent = btnWork;
            btnWork.Cursor = Cursors.Hand;
            btnWork.CustomImages.Parent = btnWork;
            btnWork.DisabledState.BorderColor = Color.DarkGray;
            btnWork.DisabledState.CustomBorderColor = Color.DarkGray;
            btnWork.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnWork.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnWork.DisabledState.Parent = btnWork;
            btnWork.FillColor = Color.Transparent;
            btnWork.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnWork.ForeColor = Color.Black;
            btnWork.HoverState.Parent = btnWork;
            btnWork.Location = new Point(112, 314);
            btnWork.Name = "btnWork";
            btnWork.ShadowDecoration.Parent = btnWork;
            btnWork.Size = new Size(70, 31);
            btnWork.TabIndex = 78;
            btnWork.Text = "Work";
            btnWork.UseTransparentBackground = true;
            // 
            // btnHome
            // 
            btnHome.Animated = true;
            btnHome.BackColor = Color.Transparent;
            btnHome.BorderColor = Color.FromArgb(213, 218, 223);
            btnHome.BorderRadius = 2;
            btnHome.BorderThickness = 1;
            btnHome.CheckedState.Parent = btnHome;
            btnHome.Cursor = Cursors.Hand;
            btnHome.CustomImages.Parent = btnHome;
            btnHome.DisabledState.BorderColor = Color.DarkGray;
            btnHome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHome.DisabledState.Parent = btnHome;
            btnHome.FillColor = Color.Transparent;
            btnHome.Font = new Font("Proxima Nova Rg", 9.749999f);
            btnHome.ForeColor = Color.Black;
            btnHome.HoverState.Parent = btnHome;
            btnHome.Location = new Point(29, 314);
            btnHome.Name = "btnHome";
            btnHome.ShadowDecoration.Parent = btnHome;
            btnHome.Size = new Size(70, 31);
            btnHome.TabIndex = 77;
            btnHome.Text = "Home";
            btnHome.UseTransparentBackground = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(26, 293);
            Label5.Name = "Label5";
            Label5.Size = new Size(68, 18);
            Label5.TabIndex = 76;
            Label5.Text = "Label As:";
            // 
            // txtStreet
            // 
            txtStreet.Animated = true;
            txtStreet.Cursor = Cursors.IBeam;
            txtStreet.DefaultText = "";
            txtStreet.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStreet.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStreet.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStreet.DisabledState.Parent = txtStreet;
            txtStreet.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStreet.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStreet.FocusedState.Parent = txtStreet;
            txtStreet.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtStreet.ForeColor = Color.Black;
            txtStreet.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStreet.HoverState.Parent = txtStreet;
            txtStreet.Location = new Point(29, 238);
            txtStreet.Name = "txtStreet";
            txtStreet.PasswordChar = '\0';
            txtStreet.PlaceholderText = "Street Name, Building, House No.";
            txtStreet.SelectedText = "";
            txtStreet.ShadowDecoration.Parent = txtStreet;
            txtStreet.Size = new Size(417, 38);
            txtStreet.TabIndex = 75;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Animated = true;
            txtPostalCode.Cursor = Cursors.IBeam;
            txtPostalCode.DefaultText = "";
            txtPostalCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPostalCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPostalCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPostalCode.DisabledState.Parent = txtPostalCode;
            txtPostalCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPostalCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPostalCode.FocusedState.Parent = txtPostalCode;
            txtPostalCode.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtPostalCode.ForeColor = Color.Black;
            txtPostalCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPostalCode.HoverState.Parent = txtPostalCode;
            txtPostalCode.Location = new Point(29, 184);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.PasswordChar = '\0';
            txtPostalCode.PlaceholderText = "Postal Code";
            txtPostalCode.SelectedText = "";
            txtPostalCode.ShadowDecoration.Parent = txtPostalCode;
            txtPostalCode.Size = new Size(417, 38);
            txtPostalCode.TabIndex = 74;
            // 
            // txtRegion
            // 
            txtRegion.Animated = true;
            txtRegion.Cursor = Cursors.IBeam;
            txtRegion.DefaultText = "";
            txtRegion.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRegion.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRegion.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRegion.DisabledState.Parent = txtRegion;
            txtRegion.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRegion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRegion.FocusedState.Parent = txtRegion;
            txtRegion.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtRegion.ForeColor = Color.Black;
            txtRegion.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRegion.HoverState.Parent = txtRegion;
            txtRegion.Location = new Point(29, 130);
            txtRegion.Name = "txtRegion";
            txtRegion.PasswordChar = '\0';
            txtRegion.PlaceholderText = "Barangay, City, Province, Region";
            txtRegion.SelectedText = "";
            txtRegion.ShadowDecoration.Parent = txtRegion;
            txtRegion.Size = new Size(417, 38);
            txtRegion.TabIndex = 73;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Proxima Nova Rg", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(136, 25);
            lblTitle.TabIndex = 72;
            lblTitle.Text = "New Address";
            // 
            // chkDefault
            // 
            chkDefault.AutoSize = true;
            chkDefault.Checked = true;
            chkDefault.CheckedState.BorderColor = Color.FromArgb(255, 152, 19);
            chkDefault.CheckedState.BorderRadius = 1;
            chkDefault.CheckedState.BorderThickness = 0;
            chkDefault.CheckedState.FillColor = Color.FromArgb(255, 152, 19);
            chkDefault.CheckState = CheckState.Checked;
            chkDefault.Cursor = Cursors.Hand;
            chkDefault.Enabled = false;
            chkDefault.Font = new Font("Proxima Nova Rg", 11.25f);
            chkDefault.ForeColor = Color.DarkGray;
            chkDefault.Location = new Point(29, 358);
            chkDefault.Name = "chkDefault";
            chkDefault.Size = new Size(175, 22);
            chkDefault.TabIndex = 71;
            chkDefault.Text = "Set as Default Address";
            chkDefault.UncheckedState.BorderColor = Color.FromArgb(193, 200, 207);
            chkDefault.UncheckedState.BorderRadius = 1;
            chkDefault.UncheckedState.BorderThickness = 1;
            chkDefault.UncheckedState.FillColor = Color.Transparent;
            // 
            // btnCancel
            // 
            btnCancel.Animated = true;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderRadius = 3;
            btnCancel.CheckedState.Parent = btnCancel;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomImages.Parent = btnCancel;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.DisabledState.Parent = btnCancel;
            btnCancel.FillColor = Color.Transparent;
            btnCancel.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.HoverState.Parent = btnCancel;
            btnCancel.Location = new Point(170, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.Parent = btnCancel;
            btnCancel.Size = new Size(133, 43);
            btnCancel.TabIndex = 70;
            btnCancel.Text = "CANCEL";
            btnCancel.UseTransparentBackground = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Animated = true;
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.BorderRadius = 3;
            btnSubmit.CheckedState.Parent = btnSubmit;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.CustomImages.Parent = btnSubmit;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.DisabledState.Parent = btnSubmit;
            btnSubmit.FillColor = Color.FromArgb(255, 152, 19);
            btnSubmit.Font = new Font("Proxima Nova Rg", 12.0f);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.HoverState.Parent = btnSubmit;
            btnSubmit.Location = new Point(325, 389);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.Parent = btnSubmit;
            btnSubmit.Size = new Size(133, 43);
            btnSubmit.TabIndex = 69;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseTransparentBackground = true;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Animated = true;
            txtPhoneNum.Cursor = Cursors.IBeam;
            txtPhoneNum.DefaultText = "";
            txtPhoneNum.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhoneNum.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhoneNum.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNum.DisabledState.Parent = txtPhoneNum;
            txtPhoneNum.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNum.FocusedState.Parent = txtPhoneNum;
            txtPhoneNum.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtPhoneNum.ForeColor = Color.Black;
            txtPhoneNum.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNum.HoverState.Parent = txtPhoneNum;
            txtPhoneNum.Location = new Point(246, 74);
            txtPhoneNum.MaxLength = 11;
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.PasswordChar = '\0';
            txtPhoneNum.PlaceholderText = "Phone Number";
            txtPhoneNum.SelectedText = "";
            txtPhoneNum.ShadowDecoration.Parent = txtPhoneNum;
            txtPhoneNum.Size = new Size(200, 38);
            txtPhoneNum.TabIndex = 68;
            // 
            // txtFullName
            // 
            txtFullName.Animated = true;
            txtFullName.Cursor = Cursors.IBeam;
            txtFullName.DefaultText = "";
            txtFullName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFullName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFullName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFullName.DisabledState.Parent = txtFullName;
            txtFullName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFullName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFullName.FocusedState.Parent = txtFullName;
            txtFullName.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtFullName.ForeColor = Color.Black;
            txtFullName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFullName.HoverState.Parent = txtFullName;
            txtFullName.Location = new Point(29, 74);
            txtFullName.Name = "txtFullName";
            txtFullName.PasswordChar = '\0';
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.SelectedText = "";
            txtFullName.ShadowDecoration.Parent = txtFullName;
            txtFullName.Size = new Size(200, 38);
            txtFullName.TabIndex = 67;
            // 
            // btnSave
            // 
            btnSave.Animated = true;
            btnSave.BackColor = Color.Transparent;
            btnSave.BorderRadius = 3;
            btnSave.CheckedState.Parent = btnSave;
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomImages.Parent = btnSave;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.DisabledState.Parent = btnSave;
            btnSave.FillColor = Color.FromArgb(255, 152, 19);
            btnSave.Font = new Font("Proxima Nova Rg", 12.0f);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.Parent = btnSave;
            btnSave.Location = new Point(325, 389);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.Parent = btnSave;
            btnSave.Size = new Size(133, 43);
            btnSave.TabIndex = 80;
            btnSave.Text = "SAVE";
            btnSave.UseTransparentBackground = true;
            btnSave.Visible = false;
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // AddressPopUp
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 457);
            Controls.Add(lblChecker);
            Controls.Add(btnWork);
            Controls.Add(btnHome);
            Controls.Add(Label5);
            Controls.Add(txtStreet);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(lblTitle);
            Controls.Add(chkDefault);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtFullName);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddressPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddressPopUp";
            Load += new EventHandler(AddressPopUp_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label lblChecker;
        internal Guna.UI2.WinForms.Guna2Button btnWork;
        internal Guna.UI2.WinForms.Guna2Button btnHome;
        internal Label Label5;
        internal Guna.UI2.WinForms.Guna2TextBox txtStreet;
        internal Guna.UI2.WinForms.Guna2TextBox txtPostalCode;
        internal Guna.UI2.WinForms.Guna2TextBox txtRegion;
        internal Label lblTitle;
        internal Guna.UI2.WinForms.Guna2CheckBox chkDefault;
        internal Guna.UI2.WinForms.Guna2Button btnCancel;
        internal Guna.UI2.WinForms.Guna2Button btnSubmit;
        internal Guna.UI2.WinForms.Guna2TextBox txtPhoneNum;
        internal Guna.UI2.WinForms.Guna2TextBox txtFullName;
        internal Guna.UI2.WinForms.Guna2Button btnSave;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
    }
}