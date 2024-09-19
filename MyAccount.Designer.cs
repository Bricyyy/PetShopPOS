using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MyAccount : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            lblItems = new Label();
            setPicture = new Guna.UI2.WinForms.Guna2CircleButton();
            setPicture.Click += new EventHandler(setPicture_Click);
            btnDiscard = new Guna.UI2.WinForms.Guna2Button();
            btnDiscard.Click += new EventHandler(btnDiscard_Click);
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnSave.Click += new EventHandler(btnSave_Click);
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername.TextChanged += new EventHandler(txtUsername_TextChanged);
            Label1 = new Label();
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            txtFullName.TextChanged += new EventHandler(txtFullName_TextChanged);
            Label2 = new Label();
            Label3 = new Label();
            lblEmail = new Label();
            txtPhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            txtPhoneNum.TextChanged += new EventHandler(txtPhoneNum_TextChanged);
            txtPhoneNum.KeyPress += new KeyPressEventHandler(txtPhoneNum_KeyPress);
            Label4 = new Label();
            Label5 = new Label();
            btnMale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            btnMale.CheckedChanged += new EventHandler(btnMale_CheckedChanged);
            lblMale = new Label();
            lblFemale = new Label();
            btnFemale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            btnFemale.CheckedChanged += new EventHandler(btnFemale_CheckedChanged);
            Label6 = new Label();
            btnOther = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            btnOther.CheckedChanged += new EventHandler(btnOther_CheckedChanged);
            lblUNInfo = new Label();
            Label8 = new Label();
            Label9 = new Label();
            cmbDate = new Guna.UI2.WinForms.Guna2ComboBox();
            cmbDate.SelectedIndexChanged += new EventHandler(cmbDate_SelectedIndexChanged);
            cmbMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            cmbMonth.SelectedIndexChanged += new EventHandler(cmbMonth_SelectedIndexChanged);
            cmbYear = new Guna.UI2.WinForms.Guna2ComboBox();
            cmbYear.SelectedIndexChanged += new EventHandler(cmbYear_SelectedIndexChanged);
            btnSelectPic = new Guna.UI2.WinForms.Guna2Button();
            btnSelectPic.Click += new EventHandler(btnSelectPic_Click);
            lblDate = new Label();
            lblUsernameChecker = new Label();
            Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Proxima Nova Lt", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.Location = new Point(21, 19);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(141, 29);
            lblItems.TabIndex = 18;
            lblItems.Text = "My Account";
            // 
            // setPicture
            // 
            setPicture.Animated = true;
            setPicture.BackColor = Color.Transparent;
            setPicture.BorderColor = Color.Transparent;
            setPicture.CheckedState.Parent = setPicture;
            setPicture.Cursor = Cursors.Hand;
            setPicture.CustomImages.Image = (Image)resources.GetObject("resource.Image");
            setPicture.CustomImages.ImageAlign = HorizontalAlignment.Center;
            setPicture.CustomImages.ImageSize = new Size(127, 130);
            setPicture.CustomImages.Parent = setPicture;
            setPicture.DisabledState.BorderColor = Color.DarkGray;
            setPicture.DisabledState.CustomBorderColor = Color.DarkGray;
            setPicture.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            setPicture.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            setPicture.DisabledState.Parent = setPicture;
            setPicture.FillColor = Color.Transparent;
            setPicture.Font = new Font("Proxima Nova Rg", 12.0f);
            setPicture.ForeColor = Color.Transparent;
            setPicture.HoverState.Parent = setPicture;
            setPicture.ImageSize = new Size(127, 130);
            setPicture.Location = new Point(374, 124);
            setPicture.Name = "setPicture";
            setPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            setPicture.ShadowDecoration.Parent = setPicture;
            setPicture.Size = new Size(134, 138);
            setPicture.TabIndex = 28;
            setPicture.UseTransparentBackground = true;
            // 
            // btnDiscard
            // 
            btnDiscard.Animated = true;
            btnDiscard.BackColor = Color.Transparent;
            btnDiscard.BorderColor = Color.FromArgb(255, 152, 19);
            btnDiscard.BorderRadius = 6;
            btnDiscard.BorderThickness = 2;
            btnDiscard.CheckedState.Parent = btnDiscard;
            btnDiscard.Cursor = Cursors.Hand;
            btnDiscard.CustomImages.Parent = btnDiscard;
            btnDiscard.DisabledState.BorderColor = Color.DarkGray;
            btnDiscard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDiscard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDiscard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDiscard.DisabledState.Parent = btnDiscard;
            btnDiscard.FillColor = Color.Empty;
            btnDiscard.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold);
            btnDiscard.ForeColor = Color.FromArgb(255, 152, 19);
            btnDiscard.HoverState.Parent = btnDiscard;
            btnDiscard.Location = new Point(107, 480);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.ShadowDecoration.Parent = btnDiscard;
            btnDiscard.Size = new Size(141, 45);
            btnDiscard.TabIndex = 29;
            btnDiscard.Text = "Discard Changes";
            btnDiscard.UseTransparentBackground = true;
            btnDiscard.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Animated = true;
            btnSave.BackColor = Color.Transparent;
            btnSave.BorderRadius = 6;
            btnSave.CheckedState.Parent = btnSave;
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomImages.Parent = btnSave;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.DisabledState.Parent = btnSave;
            btnSave.FillColor = Color.FromArgb(255, 152, 19);
            btnSave.Font = new Font("Proxima Nova Lt", 9.749999f, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.Parent = btnSave;
            btnSave.Location = new Point(279, 480);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.Parent = btnSave;
            btnSave.Size = new Size(141, 45);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save Changes";
            btnSave.UseTransparentBackground = true;
            btnSave.Visible = false;
            // 
            // txtUsername
            // 
            txtUsername.Animated = true;
            txtUsername.AutoRoundedCorners = true;
            txtUsername.BorderRadius = 17;
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
            txtUsername.Location = new Point(107, 115);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.Parent = txtUsername;
            txtUsername.Size = new Size(227, 36);
            txtUsername.TabIndex = 31;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ControlDarkDark;
            Label1.Location = new Point(23, 124);
            Label1.Name = "Label1";
            Label1.Size = new Size(74, 18);
            Label1.TabIndex = 32;
            Label1.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.Animated = true;
            txtFullName.AutoRoundedCorners = true;
            txtFullName.BorderRadius = 17;
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
            txtFullName.Location = new Point(107, 191);
            txtFullName.Name = "txtFullName";
            txtFullName.PasswordChar = '\0';
            txtFullName.PlaceholderText = "";
            txtFullName.SelectedText = "";
            txtFullName.ShadowDecoration.Parent = txtFullName;
            txtFullName.Size = new Size(227, 36);
            txtFullName.TabIndex = 33;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = SystemColors.ControlDarkDark;
            Label2.Location = new Point(24, 200);
            Label2.Name = "Label2";
            Label2.Size = new Size(73, 18);
            Label2.TabIndex = 34;
            Label2.Text = "Full Name";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = SystemColors.ControlDarkDark;
            Label3.Location = new Point(54, 253);
            Label3.Name = "Label3";
            Label3.Size = new Size(43, 18);
            Label3.TabIndex = 36;
            Label3.Text = "Email";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(105, 255);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(109, 16);
            lblEmail.TabIndex = 37;
            lblEmail.Text = "ex*****@gmail.com";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Animated = true;
            txtPhoneNum.AutoRoundedCorners = true;
            txtPhoneNum.BorderRadius = 17;
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
            txtPhoneNum.Location = new Point(107, 296);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.PasswordChar = '\0';
            txtPhoneNum.PlaceholderText = "";
            txtPhoneNum.SelectedText = "";
            txtPhoneNum.ShadowDecoration.Parent = txtPhoneNum;
            txtPhoneNum.Size = new Size(227, 36);
            txtPhoneNum.TabIndex = 38;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = SystemColors.ControlDarkDark;
            Label4.Location = new Point(47, 305);
            Label4.Name = "Label4";
            Label4.Size = new Size(50, 18);
            Label4.TabIndex = 39;
            Label4.Text = "Phone";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = SystemColors.ControlDarkDark;
            Label5.Location = new Point(40, 359);
            Label5.Name = "Label5";
            Label5.Size = new Size(57, 18);
            Label5.TabIndex = 40;
            Label5.Text = "Gender";
            // 
            // btnMale
            // 
            btnMale.BackColor = Color.Transparent;
            btnMale.CheckedState.BorderColor = Color.FromArgb(255, 152, 19);
            btnMale.CheckedState.BorderThickness = 0;
            btnMale.CheckedState.FillColor = Color.FromArgb(255, 152, 19);
            btnMale.CheckedState.InnerColor = Color.White;
            btnMale.CheckedState.Parent = btnMale;
            btnMale.Cursor = Cursors.Hand;
            btnMale.Location = new Point(109, 359);
            btnMale.Name = "btnMale";
            btnMale.ShadowDecoration.Parent = btnMale;
            btnMale.Size = new Size(20, 20);
            btnMale.TabIndex = 43;
            btnMale.Text = "Guna2CustomRadioButton2";
            btnMale.UncheckedState.BorderColor = Color.FromArgb(213, 218, 223);
            btnMale.UncheckedState.BorderThickness = 2;
            btnMale.UncheckedState.FillColor = Color.Transparent;
            btnMale.UncheckedState.InnerColor = Color.Transparent;
            btnMale.UncheckedState.Parent = btnMale;
            btnMale.UseTransparentBackground = true;
            // 
            // lblMale
            // 
            lblMale.AutoSize = true;
            lblMale.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMale.Location = new Point(135, 361);
            lblMale.Name = "lblMale";
            lblMale.Size = new Size(41, 18);
            lblMale.TabIndex = 44;
            lblMale.Text = "Male";
            // 
            // lblFemale
            // 
            lblFemale.AutoSize = true;
            lblFemale.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFemale.Location = new Point(208, 361);
            lblFemale.Name = "lblFemale";
            lblFemale.Size = new Size(56, 18);
            lblFemale.TabIndex = 46;
            lblFemale.Text = "Female";
            // 
            // btnFemale
            // 
            btnFemale.BackColor = Color.Transparent;
            btnFemale.CheckedState.BorderColor = Color.FromArgb(255, 152, 19);
            btnFemale.CheckedState.BorderThickness = 0;
            btnFemale.CheckedState.FillColor = Color.FromArgb(255, 152, 19);
            btnFemale.CheckedState.InnerColor = Color.White;
            btnFemale.CheckedState.Parent = btnFemale;
            btnFemale.Cursor = Cursors.Hand;
            btnFemale.Location = new Point(182, 359);
            btnFemale.Name = "btnFemale";
            btnFemale.ShadowDecoration.Parent = btnFemale;
            btnFemale.Size = new Size(20, 20);
            btnFemale.TabIndex = 45;
            btnFemale.Text = "Guna2CustomRadioButton1";
            btnFemale.UncheckedState.BorderColor = Color.FromArgb(213, 218, 223);
            btnFemale.UncheckedState.BorderThickness = 2;
            btnFemale.UncheckedState.FillColor = Color.Transparent;
            btnFemale.UncheckedState.InnerColor = Color.Transparent;
            btnFemale.UncheckedState.Parent = btnFemale;
            btnFemale.UseTransparentBackground = true;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Proxima Nova Lt", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(296, 361);
            Label6.Name = "Label6";
            Label6.Size = new Size(46, 18);
            Label6.TabIndex = 48;
            Label6.Text = "Other";
            // 
            // btnOther
            // 
            btnOther.BackColor = Color.Transparent;
            btnOther.CheckedState.BorderColor = Color.FromArgb(255, 152, 19);
            btnOther.CheckedState.BorderThickness = 0;
            btnOther.CheckedState.FillColor = Color.FromArgb(255, 152, 19);
            btnOther.CheckedState.InnerColor = Color.White;
            btnOther.CheckedState.Parent = btnOther;
            btnOther.Cursor = Cursors.Hand;
            btnOther.Location = new Point(270, 359);
            btnOther.Name = "btnOther";
            btnOther.ShadowDecoration.Parent = btnOther;
            btnOther.Size = new Size(20, 20);
            btnOther.TabIndex = 47;
            btnOther.Text = "Guna2CustomRadioButton2";
            btnOther.UncheckedState.BorderColor = Color.FromArgb(213, 218, 223);
            btnOther.UncheckedState.BorderThickness = 2;
            btnOther.UncheckedState.FillColor = Color.Transparent;
            btnOther.UncheckedState.InnerColor = Color.Transparent;
            btnOther.UncheckedState.Parent = btnOther;
            btnOther.UseTransparentBackground = true;
            // 
            // lblUNInfo
            // 
            lblUNInfo.AutoSize = true;
            lblUNInfo.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUNInfo.ForeColor = SystemColors.ControlDark;
            lblUNInfo.Location = new Point(105, 154);
            lblUNInfo.Name = "lblUNInfo";
            lblUNInfo.Size = new Size(210, 15);
            lblUNInfo.TabIndex = 49;
            lblUNInfo.Text = "Username can only be changed once." + '\r' + '\n';
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.DimGray;
            Label8.Location = new Point(23, 48);
            Label8.Name = "Label8";
            Label8.Size = new Size(228, 18);
            Label8.TabIndex = 50;
            Label8.Text = "Manage and protect your account";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Proxima Nova Rg", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = SystemColors.ControlDarkDark;
            Label9.Location = new Point(9, 414);
            Label9.Name = "Label9";
            Label9.Size = new Size(88, 18);
            Label9.TabIndex = 53;
            Label9.Text = "Date of Birth";
            // 
            // cmbDate
            // 
            cmbDate.AutoRoundedCorners = true;
            cmbDate.BackColor = Color.Transparent;
            cmbDate.BorderRadius = 17;
            cmbDate.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDate.DropDownHeight = 120;
            cmbDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDate.DropDownWidth = 20;
            cmbDate.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbDate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbDate.FocusedState.Parent = cmbDate;
            cmbDate.Font = new Font("Proxima Nova Rg", 9.749999f);
            cmbDate.ForeColor = Color.Black;
            cmbDate.HoverState.Parent = cmbDate;
            cmbDate.IntegralHeight = false;
            cmbDate.ItemHeight = 30;
            cmbDate.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cmbDate.ItemsAppearance.Parent = cmbDate;
            cmbDate.Location = new Point(107, 405);
            cmbDate.Name = "cmbDate";
            cmbDate.ShadowDecoration.Parent = cmbDate;
            cmbDate.Size = new Size(69, 36);
            cmbDate.StartIndex = 0;
            cmbDate.TabIndex = 54;
            cmbDate.TextAlign = HorizontalAlignment.Center;
            cmbDate.TextOffset = new Point(8, 0);
            // 
            // cmbMonth
            // 
            cmbMonth.AutoRoundedCorners = true;
            cmbMonth.BackColor = Color.Transparent;
            cmbMonth.BorderRadius = 17;
            cmbMonth.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMonth.DropDownHeight = 120;
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.DropDownWidth = 20;
            cmbMonth.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbMonth.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbMonth.FocusedState.Parent = cmbMonth;
            cmbMonth.Font = new Font("Proxima Nova Rg", 9.749999f);
            cmbMonth.ForeColor = Color.Black;
            cmbMonth.HoverState.Parent = cmbMonth;
            cmbMonth.IntegralHeight = false;
            cmbMonth.ItemHeight = 30;
            cmbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbMonth.ItemsAppearance.Parent = cmbMonth;
            cmbMonth.Location = new Point(182, 405);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.ShadowDecoration.Parent = cmbMonth;
            cmbMonth.Size = new Size(116, 36);
            cmbMonth.StartIndex = 0;
            cmbMonth.TabIndex = 55;
            cmbMonth.TextAlign = HorizontalAlignment.Center;
            cmbMonth.TextOffset = new Point(5, 0);
            // 
            // cmbYear
            // 
            cmbYear.AutoRoundedCorners = true;
            cmbYear.BackColor = Color.Transparent;
            cmbYear.BorderRadius = 17;
            cmbYear.DrawMode = DrawMode.OwnerDrawFixed;
            cmbYear.DropDownHeight = 120;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.DropDownWidth = 20;
            cmbYear.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbYear.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbYear.FocusedState.Parent = cmbYear;
            cmbYear.Font = new Font("Proxima Nova Rg", 9.749999f);
            cmbYear.ForeColor = Color.Black;
            cmbYear.HoverState.Parent = cmbYear;
            cmbYear.IntegralHeight = false;
            cmbYear.ItemHeight = 30;
            cmbYear.Items.AddRange(new object[] { "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910" });
            cmbYear.ItemsAppearance.Parent = cmbYear;
            cmbYear.Location = new Point(304, 405);
            cmbYear.Name = "cmbYear";
            cmbYear.ShadowDecoration.Parent = cmbYear;
            cmbYear.Size = new Size(95, 36);
            cmbYear.StartIndex = 0;
            cmbYear.TabIndex = 56;
            cmbYear.TextAlign = HorizontalAlignment.Center;
            cmbYear.TextOffset = new Point(5, 0);
            // 
            // btnSelectPic
            // 
            btnSelectPic.Animated = true;
            btnSelectPic.BackColor = Color.Transparent;
            btnSelectPic.BorderColor = Color.FromArgb(213, 218, 223);
            btnSelectPic.BorderRadius = 6;
            btnSelectPic.BorderThickness = 1;
            btnSelectPic.CheckedState.Parent = btnSelectPic;
            btnSelectPic.Cursor = Cursors.Hand;
            btnSelectPic.CustomImages.Parent = btnSelectPic;
            btnSelectPic.DisabledState.BorderColor = Color.DarkGray;
            btnSelectPic.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSelectPic.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSelectPic.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSelectPic.DisabledState.Parent = btnSelectPic;
            btnSelectPic.FillColor = Color.Transparent;
            btnSelectPic.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectPic.ForeColor = Color.Black;
            btnSelectPic.HoverState.Parent = btnSelectPic;
            btnSelectPic.Location = new Point(374, 278);
            btnSelectPic.Name = "btnSelectPic";
            btnSelectPic.ShadowDecoration.Parent = btnSelectPic;
            btnSelectPic.Size = new Size(134, 45);
            btnSelectPic.TabIndex = 57;
            btnSelectPic.Text = "Select Image";
            btnSelectPic.UseTransparentBackground = true;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(462, 385);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(30, 13);
            lblDate.TabIndex = 58;
            lblDate.Text = "Date";
            // 
            // lblUsernameChecker
            // 
            lblUsernameChecker.AutoSize = true;
            lblUsernameChecker.Font = new Font("Proxima Nova Lt", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameChecker.ForeColor = Color.IndianRed;
            lblUsernameChecker.Location = new Point(106, 99);
            lblUsernameChecker.Name = "lblUsernameChecker";
            lblUsernameChecker.Size = new Size(126, 13);
            lblUsernameChecker.TabIndex = 59;
            lblUsernameChecker.Text = "Username already exist.";
            lblUsernameChecker.Visible = false;
            // 
            // Guna2PictureBox3
            // 
            Guna2PictureBox3.BackColor = Color.Transparent;
            Guna2PictureBox3.Image = (Image)resources.GetObject("Guna2PictureBox3.Image");
            Guna2PictureBox3.ImageRotate = 0f;
            Guna2PictureBox3.Location = new Point(-35, 69);
            Guna2PictureBox3.Name = "Guna2PictureBox3";
            Guna2PictureBox3.ShadowDecoration.Parent = Guna2PictureBox3;
            Guna2PictureBox3.Size = new Size(625, 20);
            Guna2PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox3.TabIndex = 51;
            Guna2PictureBox3.TabStop = false;
            Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 90.0f;
            Guna2PictureBox1.Location = new Point(312, 117);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(87, 217);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox1.TabIndex = 52;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // MyAccount
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(549, 573);
            Controls.Add(lblUsernameChecker);
            Controls.Add(lblDate);
            Controls.Add(btnSelectPic);
            Controls.Add(cmbYear);
            Controls.Add(cmbMonth);
            Controls.Add(setPicture);
            Controls.Add(cmbDate);
            Controls.Add(Label9);
            Controls.Add(Guna2PictureBox3);
            Controls.Add(Label8);
            Controls.Add(lblUNInfo);
            Controls.Add(Label6);
            Controls.Add(btnOther);
            Controls.Add(lblFemale);
            Controls.Add(btnFemale);
            Controls.Add(lblMale);
            Controls.Add(btnMale);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(txtPhoneNum);
            Controls.Add(lblEmail);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(txtFullName);
            Controls.Add(Label1);
            Controls.Add(txtUsername);
            Controls.Add(btnSave);
            Controls.Add(btnDiscard);
            Controls.Add(lblItems);
            Controls.Add(Guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyAccount";
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            Load += new EventHandler(MyAccount_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label lblItems;
        internal Guna.UI2.WinForms.Guna2CircleButton setPicture;
        internal Guna.UI2.WinForms.Guna2Button btnDiscard;
        internal Guna.UI2.WinForms.Guna2Button btnSave;
        internal Guna.UI2.WinForms.Guna2TextBox txtUsername;
        internal Label Label1;
        internal Guna.UI2.WinForms.Guna2TextBox txtFullName;
        internal Label Label2;
        internal Label Label3;
        internal Label lblEmail;
        internal Guna.UI2.WinForms.Guna2TextBox txtPhoneNum;
        internal Label Label4;
        internal Label Label5;
        internal Guna.UI2.WinForms.Guna2CustomRadioButton btnMale;
        internal Label lblMale;
        internal Label lblFemale;
        internal Guna.UI2.WinForms.Guna2CustomRadioButton btnFemale;
        internal Label Label6;
        internal Guna.UI2.WinForms.Guna2CustomRadioButton btnOther;
        internal Label lblUNInfo;
        internal Label Label8;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Label Label9;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbDate;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbMonth;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbYear;
        internal Guna.UI2.WinForms.Guna2Button btnSelectPic;
        internal Label lblDate;
        internal Label lblUsernameChecker;
    }
}