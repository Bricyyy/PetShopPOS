using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class HomePanel : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.Label2 = new System.Windows.Forms.Label();
            this.pnlOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2PictureBox11 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlCartCheck = new System.Windows.Forms.Panel();
            this.Label28 = new System.Windows.Forms.Label();
            this.Guna2PictureBox17 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblSubT = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.flpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.Guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.Label17 = new System.Windows.Forms.Label();
            this.Guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbAddress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnProceed = new Guna.UI2.WinForms.Guna2Button();
            this.lstPrices = new System.Windows.Forms.ListBox();
            this.Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblItems = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.Guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.Label29 = new System.Windows.Forms.Label();
            this.lblAddPlace = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Guna2PictureBox12 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlFinal = new System.Windows.Forms.Panel();
            this.checkoutLstBox = new System.Windows.Forms.ListBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.lblMerch = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Label30 = new System.Windows.Forms.Label();
            this.Guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flpCheckoutCart = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Guna2PictureBox14 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lstCheckout = new System.Windows.Forms.ListBox();
            this.Guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLast = new System.Windows.Forms.Panel();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblItemTotal = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2PictureBox15 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.Guna2Elipse9 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnCage = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnToiletries = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeash = new Guna.UI2.WinForms.Guna2Button();
            this.btnFoods = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.AccountdbDataSet = new MilkTeaOrderAndInventorySystem.accountdbDataSet();
            this.UsercartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsercartTableAdapter = new MilkTeaOrderAndInventorySystem.accountdbDataSetTableAdapters.usercartTableAdapter();
            this.Guna2PictureBox13 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox16 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox11)).BeginInit();
            this.pnlCartCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).BeginInit();
            this.flpCart.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox6)).BeginInit();
            this.flpOrder.SuspendLayout();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.pnlAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox12)).BeginInit();
            this.pnlFinal.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.flpCheckoutCart.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox14)).BeginInit();
            this.pnlLast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsercartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox16)).BeginInit();
            this.pnlCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Proxima Nova Rg", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(28, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(228, 33);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Choose Category";
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.White;
            this.pnlOrder.Controls.Add(this.Guna2PictureBox11);
            this.pnlOrder.Controls.Add(this.pnlCartCheck);
            this.pnlOrder.Controls.Add(this.Guna2PictureBox5);
            this.pnlOrder.Controls.Add(this.Guna2PictureBox7);
            this.pnlOrder.Controls.Add(this.Guna2PictureBox4);
            this.pnlOrder.Controls.Add(this.Guna2PictureBox3);
            this.pnlOrder.Controls.Add(this.Guna2PictureBox2);
            this.pnlOrder.Controls.Add(this.Label8);
            this.pnlOrder.Controls.Add(this.lblSubT);
            this.pnlOrder.Controls.Add(this.Label6);
            this.pnlOrder.Controls.Add(this.Label5);
            this.pnlOrder.Controls.Add(this.lblTotal);
            this.pnlOrder.Controls.Add(this.Label3);
            this.pnlOrder.Controls.Add(this.lblCart);
            this.pnlOrder.Controls.Add(this.flpCart);
            this.pnlOrder.Controls.Add(this.btnProceed);
            this.pnlOrder.Location = new System.Drawing.Point(657, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.ShadowDecoration.Parent = this.pnlOrder;
            this.pnlOrder.Size = new System.Drawing.Size(259, 683);
            this.pnlOrder.TabIndex = 3;
            // 
            // Guna2PictureBox11
            // 
            this.Guna2PictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox11.Image")));
            this.Guna2PictureBox11.ImageRotate = 0F;
            this.Guna2PictureBox11.Location = new System.Drawing.Point(21, 565);
            this.Guna2PictureBox11.Name = "Guna2PictureBox11";
            this.Guna2PictureBox11.ShadowDecoration.Parent = this.Guna2PictureBox11;
            this.Guna2PictureBox11.Size = new System.Drawing.Size(25, 26);
            this.Guna2PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox11.TabIndex = 30;
            this.Guna2PictureBox11.TabStop = false;
            this.Guna2PictureBox11.UseTransparentBackground = true;
            // 
            // pnlCartCheck
            // 
            this.pnlCartCheck.Controls.Add(this.Label28);
            this.pnlCartCheck.Controls.Add(this.Guna2PictureBox17);
            this.pnlCartCheck.Location = new System.Drawing.Point(15, 61);
            this.pnlCartCheck.Name = "pnlCartCheck";
            this.pnlCartCheck.Size = new System.Drawing.Size(225, 390);
            this.pnlCartCheck.TabIndex = 28;
            this.pnlCartCheck.Visible = false;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Proxima Nova Lt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label28.Location = new System.Drawing.Point(26, 203);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(166, 16);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "Your shopping cart is empty";
            // 
            // Guna2PictureBox17
            // 
            this.Guna2PictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox17.Image")));
            this.Guna2PictureBox17.ImageRotate = 0F;
            this.Guna2PictureBox17.Location = new System.Drawing.Point(53, 94);
            this.Guna2PictureBox17.Name = "Guna2PictureBox17";
            this.Guna2PictureBox17.ShadowDecoration.Parent = this.Guna2PictureBox17;
            this.Guna2PictureBox17.Size = new System.Drawing.Size(118, 113);
            this.Guna2PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Guna2PictureBox17.TabIndex = 0;
            this.Guna2PictureBox17.TabStop = false;
            this.Guna2PictureBox17.UseTransparentBackground = true;
            // 
            // Guna2PictureBox5
            // 
            this.Guna2PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox5.Image")));
            this.Guna2PictureBox5.ImageRotate = 0F;
            this.Guna2PictureBox5.Location = new System.Drawing.Point(20, 516);
            this.Guna2PictureBox5.Name = "Guna2PictureBox5";
            this.Guna2PictureBox5.ShadowDecoration.Parent = this.Guna2PictureBox5;
            this.Guna2PictureBox5.Size = new System.Drawing.Size(25, 26);
            this.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox5.TabIndex = 29;
            this.Guna2PictureBox5.TabStop = false;
            this.Guna2PictureBox5.UseTransparentBackground = true;
            // 
            // Guna2PictureBox7
            // 
            this.Guna2PictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox7.Image")));
            this.Guna2PictureBox7.ImageRotate = 0F;
            this.Guna2PictureBox7.Location = new System.Drawing.Point(17, 14);
            this.Guna2PictureBox7.Name = "Guna2PictureBox7";
            this.Guna2PictureBox7.ShadowDecoration.Parent = this.Guna2PictureBox7;
            this.Guna2PictureBox7.Size = new System.Drawing.Size(57, 46);
            this.Guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox7.TabIndex = 27;
            this.Guna2PictureBox7.TabStop = false;
            this.Guna2PictureBox7.UseTransparentBackground = true;
            // 
            // Guna2PictureBox4
            // 
            this.Guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox4.Image")));
            this.Guna2PictureBox4.ImageRotate = 0F;
            this.Guna2PictureBox4.Location = new System.Drawing.Point(20, 484);
            this.Guna2PictureBox4.Name = "Guna2PictureBox4";
            this.Guna2PictureBox4.ShadowDecoration.Parent = this.Guna2PictureBox4;
            this.Guna2PictureBox4.Size = new System.Drawing.Size(25, 26);
            this.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox4.TabIndex = 28;
            this.Guna2PictureBox4.TabStop = false;
            this.Guna2PictureBox4.UseTransparentBackground = true;
            // 
            // Guna2PictureBox3
            // 
            this.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox3.Image")));
            this.Guna2PictureBox3.ImageRotate = 0F;
            this.Guna2PictureBox3.Location = new System.Drawing.Point(-35, 458);
            this.Guna2PictureBox3.Name = "Guna2PictureBox3";
            this.Guna2PictureBox3.ShadowDecoration.Parent = this.Guna2PictureBox3;
            this.Guna2PictureBox3.Size = new System.Drawing.Size(327, 20);
            this.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox3.TabIndex = 28;
            this.Guna2PictureBox3.TabStop = false;
            this.Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // Guna2PictureBox2
            // 
            this.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox2.Image")));
            this.Guna2PictureBox2.ImageRotate = 0F;
            this.Guna2PictureBox2.Location = new System.Drawing.Point(-36, 544);
            this.Guna2PictureBox2.Name = "Guna2PictureBox2";
            this.Guna2PictureBox2.ShadowDecoration.Parent = this.Guna2PictureBox2;
            this.Guna2PictureBox2.Size = new System.Drawing.Size(327, 20);
            this.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox2.TabIndex = 27;
            this.Guna2PictureBox2.TabStop = false;
            this.Guna2PictureBox2.UseTransparentBackground = true;
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(184, 517);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(37, 18);
            this.Label8.TabIndex = 25;
            this.Label8.Text = "₱50";
            // 
            // lblSubT
            // 
            this.lblSubT.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubT.ForeColor = System.Drawing.Color.Black;
            this.lblSubT.Location = new System.Drawing.Point(148, 489);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(73, 18);
            this.lblSubT.TabIndex = 24;
            this.lblSubT.Text = "₱00";
            this.lblSubT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Proxima Nova Lt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label6.Location = new System.Drawing.Point(52, 491);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(61, 16);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Sub Total";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Proxima Nova Lt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label5.Location = new System.Drawing.Point(52, 523);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(79, 16);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "Delivery Fee";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(148, 569);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 18);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "₱00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Proxima Nova Lt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label3.Location = new System.Drawing.Point(52, 571);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 16);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Total";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Proxima Nova Lt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(67, 25);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(85, 25);
            this.lblCart.TabIndex = 19;
            this.lblCart.Text = "My Cart";
            // 
            // flpCart
            // 
            this.flpCart.AutoScroll = true;
            this.flpCart.Controls.Add(this.Panel3);
            this.flpCart.Controls.Add(this.cmbAddress);
            this.flpCart.Controls.Add(this.Label9);
            this.flpCart.Location = new System.Drawing.Point(17, 72);
            this.flpCart.Name = "flpCart";
            this.flpCart.Size = new System.Drawing.Size(223, 379);
            this.flpCart.TabIndex = 1;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Label14);
            this.Panel3.Controls.Add(this.Label15);
            this.Panel3.Controls.Add(this.Guna2Button4);
            this.Panel3.Controls.Add(this.Label16);
            this.Panel3.Controls.Add(this.Guna2NumericUpDown2);
            this.Panel3.Controls.Add(this.Label17);
            this.Panel3.Controls.Add(this.Guna2PictureBox6);
            this.Panel3.Location = new System.Drawing.Point(3, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(205, 91);
            this.Panel3.TabIndex = 33;
            this.Panel3.Visible = false;
            // 
            // Label14
            // 
            this.Label14.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(162, 43);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(36, 16);
            this.Label14.TabIndex = 32;
            this.Label14.Text = "Total";
            // 
            // Label15
            // 
            this.Label15.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(117, 53);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(30, 18);
            this.Label15.TabIndex = 31;
            this.Label15.Text = "₱70";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Guna2Button4
            // 
            this.Guna2Button4.Animated = true;
            this.Guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button4.CheckedState.Parent = this.Guna2Button4;
            this.Guna2Button4.CustomImages.Parent = this.Guna2Button4;
            this.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button4.DisabledState.Parent = this.Guna2Button4;
            this.Guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.Guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2Button4.ForeColor = System.Drawing.Color.White;
            this.Guna2Button4.HoverState.Parent = this.Guna2Button4;
            this.Guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button4.Image")));
            this.Guna2Button4.Location = new System.Drawing.Point(188, 8);
            this.Guna2Button4.Name = "Guna2Button4";
            this.Guna2Button4.ShadowDecoration.Parent = this.Guna2Button4;
            this.Guna2Button4.Size = new System.Drawing.Size(10, 13);
            this.Guna2Button4.TabIndex = 30;
            this.Guna2Button4.UseTransparentBackground = true;
            // 
            // Label16
            // 
            this.Label16.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(140, 59);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(58, 18);
            this.Label16.TabIndex = 29;
            this.Label16.Text = "₱140";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Guna2NumericUpDown2
            // 
            this.Guna2NumericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2NumericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2NumericUpDown2.DisabledState.Parent = this.Guna2NumericUpDown2;
            this.Guna2NumericUpDown2.FocusedState.Parent = this.Guna2NumericUpDown2;
            this.Guna2NumericUpDown2.Font = new System.Drawing.Font("Proxima Nova Rg", 8.999999F);
            this.Guna2NumericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.Guna2NumericUpDown2.Location = new System.Drawing.Point(64, 48);
            this.Guna2NumericUpDown2.Name = "Guna2NumericUpDown2";
            this.Guna2NumericUpDown2.ShadowDecoration.Parent = this.Guna2NumericUpDown2;
            this.Guna2NumericUpDown2.Size = new System.Drawing.Size(48, 29);
            this.Guna2NumericUpDown2.TabIndex = 1;
            this.Guna2NumericUpDown2.UpDownButtonFillColor = System.Drawing.Color.White;
            this.Guna2NumericUpDown2.UseTransparentBackground = true;
            this.Guna2NumericUpDown2.Value = new decimal(new int[] {
            46,
            0,
            0,
            0});
            // 
            // Label17
            // 
            this.Label17.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.Location = new System.Drawing.Point(61, 8);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(121, 32);
            this.Label17.TabIndex = 29;
            this.Label17.Text = "Ordinary Foldable Medium";
            // 
            // Guna2PictureBox6
            // 
            this.Guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox6.BorderRadius = 16;
            this.Guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox6.Image")));
            this.Guna2PictureBox6.ImageRotate = 0F;
            this.Guna2PictureBox6.Location = new System.Drawing.Point(7, 3);
            this.Guna2PictureBox6.Name = "Guna2PictureBox6";
            this.Guna2PictureBox6.ShadowDecoration.Parent = this.Guna2PictureBox6;
            this.Guna2PictureBox6.Size = new System.Drawing.Size(52, 85);
            this.Guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox6.TabIndex = 0;
            this.Guna2PictureBox6.TabStop = false;
            this.Guna2PictureBox6.UseTransparentBackground = true;
            // 
            // cmbAddress
            // 
            this.cmbAddress.BackColor = System.Drawing.Color.Transparent;
            this.cmbAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAddress.FocusedState.Parent = this.cmbAddress;
            this.cmbAddress.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Bold);
            this.cmbAddress.ForeColor = System.Drawing.Color.Black;
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.HoverState.Parent = this.cmbAddress;
            this.cmbAddress.ItemHeight = 30;
            this.cmbAddress.ItemsAppearance.Parent = this.cmbAddress;
            this.cmbAddress.Location = new System.Drawing.Point(3, 100);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.ShadowDecoration.Parent = this.cmbAddress;
            this.cmbAddress.Size = new System.Drawing.Size(188, 36);
            this.cmbAddress.TabIndex = 27;
            this.cmbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbAddress.Visible = false;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(3, 139);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(101, 16);
            this.Label9.TabIndex = 26;
            this.Label9.Text = "Delivery Address";
            this.Label9.Visible = false;
            // 
            // btnProceed
            // 
            this.btnProceed.Animated = true;
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.BorderRadius = 6;
            this.btnProceed.CheckedState.Parent = this.btnProceed;
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.CustomImages.Parent = this.btnProceed;
            this.btnProceed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProceed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProceed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProceed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProceed.DisabledState.Parent = this.btnProceed;
            this.btnProceed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.btnProceed.Font = new System.Drawing.Font("Proxima Nova Lt", 12F, System.Drawing.FontStyle.Bold);
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.HoverState.Parent = this.btnProceed;
            this.btnProceed.Location = new System.Drawing.Point(30, 608);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.ShadowDecoration.Parent = this.btnProceed;
            this.btnProceed.Size = new System.Drawing.Size(195, 48);
            this.btnProceed.TabIndex = 0;
            this.btnProceed.Text = "Proceed to Checkout";
            this.btnProceed.UseTransparentBackground = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lstPrices
            // 
            this.lstPrices.FormattingEnabled = true;
            this.lstPrices.Location = new System.Drawing.Point(3, 3);
            this.lstPrices.Name = "lstPrices";
            this.lstPrices.Size = new System.Drawing.Size(89, 186);
            this.lstPrices.TabIndex = 27;
            this.lstPrices.Visible = false;
            this.lstPrices.SelectedIndexChanged += new System.EventHandler(this.lstPrices_SelectedIndexChanged);
            // 
            // Guna2Elipse1
            // 
            this.Guna2Elipse1.BorderRadius = 20;
            this.Guna2Elipse1.TargetControl = this.pnlOrder;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Proxima Nova Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(29, 231);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(159, 29);
            this.lblItems.TabIndex = 17;
            this.lblItems.Text = "Choose Items";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(444, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 18);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemCount
            // 
            this.lblItemCount.Font = new System.Drawing.Font("Proxima Nova Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCount.Location = new System.Drawing.Point(467, 238);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(148, 20);
            this.lblItemCount.TabIndex = 23;
            this.lblItemCount.Text = "00 All Result";
            this.lblItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpOrder
            // 
            this.flpOrder.AutoScroll = true;
            this.flpOrder.Controls.Add(this.lstPrices);
            this.flpOrder.Location = new System.Drawing.Point(34, 271);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Size = new System.Drawing.Size(581, 385);
            this.flpOrder.TabIndex = 18;
            // 
            // Guna2Elipse2
            // 
            this.Guna2Elipse2.BorderRadius = 20;
            this.Guna2Elipse2.TargetControl = this.pnlBack;
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.Controls.Add(this.btnBack);
            this.pnlBack.Controls.Add(this.Label1);
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(910, 59);
            this.pnlBack.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnBack.ImageRotate = 0F;
            this.btnBack.Location = new System.Drawing.Point(31, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(41, 40);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Proxima Nova Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.Label1.Location = new System.Drawing.Point(96, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(117, 29);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Checkout";
            // 
            // Guna2Elipse3
            // 
            this.Guna2Elipse3.TargetControl = this.pnlAddress;
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.White;
            this.pnlAddress.Controls.Add(this.Label29);
            this.pnlAddress.Controls.Add(this.lblAddPlace);
            this.pnlAddress.Controls.Add(this.lblAddName);
            this.pnlAddress.Controls.Add(this.Label4);
            this.pnlAddress.Controls.Add(this.Guna2PictureBox12);
            this.pnlAddress.Location = new System.Drawing.Point(31, 72);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(844, 92);
            this.pnlAddress.TabIndex = 1;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.ForeColor = System.Drawing.Color.DarkGray;
            this.Label29.Location = new System.Drawing.Point(765, 29);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(49, 16);
            this.Label29.TabIndex = 57;
            this.Label29.Text = "Default";
            // 
            // lblAddPlace
            // 
            this.lblAddPlace.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPlace.Location = new System.Drawing.Point(321, 53);
            this.lblAddPlace.Name = "lblAddPlace";
            this.lblAddPlace.Size = new System.Drawing.Size(494, 16);
            this.lblAddPlace.TabIndex = 56;
            this.lblAddPlace.Text = "168 Mamatid, Cabuyao, Laguna, South Luzon, 4025";
            this.lblAddPlace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Proxima Nova Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(20, 51);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(295, 18);
            this.lblAddName.TabIndex = 55;
            this.lblAddName.Text = "Bryan Iverson Delos Santos 09162964676";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Proxima Nova Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.Label4.Location = new System.Drawing.Point(47, 12);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(132, 20);
            this.Label4.TabIndex = 54;
            this.Label4.Text = "Delivery Address";
            // 
            // Guna2PictureBox12
            // 
            this.Guna2PictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2PictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox12.Image")));
            this.Guna2PictureBox12.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.Guna2PictureBox12.ImageRotate = 0F;
            this.Guna2PictureBox12.Location = new System.Drawing.Point(16, 8);
            this.Guna2PictureBox12.Name = "Guna2PictureBox12";
            this.Guna2PictureBox12.ShadowDecoration.Parent = this.Guna2PictureBox12;
            this.Guna2PictureBox12.Size = new System.Drawing.Size(31, 26);
            this.Guna2PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox12.TabIndex = 54;
            this.Guna2PictureBox12.TabStop = false;
            this.Guna2PictureBox12.UseTransparentBackground = true;
            // 
            // Guna2Elipse4
            // 
            this.Guna2Elipse4.TargetControl = this.pnlFinal;
            // 
            // pnlFinal
            // 
            this.pnlFinal.BackColor = System.Drawing.Color.White;
            this.pnlFinal.Controls.Add(this.checkoutLstBox);
            this.pnlFinal.Controls.Add(this.Label26);
            this.pnlFinal.Controls.Add(this.Label25);
            this.pnlFinal.Controls.Add(this.Label20);
            this.pnlFinal.Controls.Add(this.lblMerch);
            this.pnlFinal.Controls.Add(this.Label18);
            this.pnlFinal.Controls.Add(this.lblGrandTotal);
            this.pnlFinal.Controls.Add(this.btnSubmit);
            this.pnlFinal.Location = new System.Drawing.Point(31, 510);
            this.pnlFinal.Name = "pnlFinal";
            this.pnlFinal.Size = new System.Drawing.Size(844, 161);
            this.pnlFinal.TabIndex = 4;
            // 
            // checkoutLstBox
            // 
            this.checkoutLstBox.FormattingEnabled = true;
            this.checkoutLstBox.Location = new System.Drawing.Point(237, 13);
            this.checkoutLstBox.Name = "checkoutLstBox";
            this.checkoutLstBox.Size = new System.Drawing.Size(120, 69);
            this.checkoutLstBox.TabIndex = 54;
            this.checkoutLstBox.Visible = false;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label26.Location = new System.Drawing.Point(590, 9);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(92, 16);
            this.Label26.TabIndex = 12;
            this.Label26.Text = "Order Subtotal:";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label25.Location = new System.Drawing.Point(590, 34);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(89, 16);
            this.Label25.TabIndex = 11;
            this.Label25.Text = "Shipping Total:";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label20.Location = new System.Drawing.Point(590, 63);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(90, 16);
            this.Label20.TabIndex = 10;
            this.Label20.Text = "Total Payment:";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMerch
            // 
            this.lblMerch.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMerch.Location = new System.Drawing.Point(727, 9);
            this.lblMerch.Name = "lblMerch";
            this.lblMerch.Size = new System.Drawing.Size(85, 16);
            this.lblMerch.TabIndex = 9;
            this.lblMerch.Text = "₱150";
            this.lblMerch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label18.Location = new System.Drawing.Point(779, 34);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(32, 16);
            this.Label18.TabIndex = 8;
            this.Label18.Text = "₱50";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(693, 50);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(125, 32);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.Text = "₱200";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 3;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.DisabledState.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.btnSubmit.Font = new System.Drawing.Font("Proxima Nova Lt", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(682, 106);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(133, 43);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Place Order";
            this.btnSubmit.UseTransparentBackground = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Guna2Elipse5
            // 
            this.Guna2Elipse5.TargetControl = this.pnlPayment;
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.White;
            this.pnlPayment.Controls.Add(this.Guna2Button3);
            this.pnlPayment.Controls.Add(this.Guna2Button1);
            this.pnlPayment.Controls.Add(this.Guna2Button2);
            this.pnlPayment.Controls.Add(this.Label30);
            this.pnlPayment.Location = new System.Drawing.Point(31, 450);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(844, 60);
            this.pnlPayment.TabIndex = 9;
            // 
            // Guna2Button3
            // 
            this.Guna2Button3.Animated = true;
            this.Guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button3.BorderColor = System.Drawing.Color.LightGray;
            this.Guna2Button3.BorderRadius = 8;
            this.Guna2Button3.BorderThickness = 1;
            this.Guna2Button3.CheckedState.Parent = this.Guna2Button3;
            this.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button3.CustomImages.Parent = this.Guna2Button3;
            this.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button3.DisabledState.Parent = this.Guna2Button3;
            this.Guna2Button3.Enabled = false;
            this.Guna2Button3.FillColor = System.Drawing.Color.White;
            this.Guna2Button3.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.Guna2Button3.HoverState.Parent = this.Guna2Button3;
            this.Guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button3.Image")));
            this.Guna2Button3.ImageOffset = new System.Drawing.Point(10, -6);
            this.Guna2Button3.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button3.Location = new System.Drawing.Point(344, 8);
            this.Guna2Button3.Name = "Guna2Button3";
            this.Guna2Button3.ShadowDecoration.Parent = this.Guna2Button3;
            this.Guna2Button3.Size = new System.Drawing.Size(83, 42);
            this.Guna2Button3.TabIndex = 67;
            this.Guna2Button3.Text = "E-Wallet";
            this.Guna2Button3.TextOffset = new System.Drawing.Point(-8, 11);
            this.Guna2Button3.UseTransparentBackground = true;
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Animated = true;
            this.Guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.Guna2Button1.BorderRadius = 8;
            this.Guna2Button1.BorderThickness = 1;
            this.Guna2Button1.CheckedState.Parent = this.Guna2Button1;
            this.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button1.CustomImages.Parent = this.Guna2Button1;
            this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button1.DisabledState.Parent = this.Guna2Button1;
            this.Guna2Button1.FillColor = System.Drawing.Color.White;
            this.Guna2Button1.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.Guna2Button1.HoverState.Parent = this.Guna2Button1;
            this.Guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button1.Image")));
            this.Guna2Button1.ImageOffset = new System.Drawing.Point(8, -7);
            this.Guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.Guna2Button1.Location = new System.Drawing.Point(166, 8);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.ShadowDecoration.Parent = this.Guna2Button1;
            this.Guna2Button1.Size = new System.Drawing.Size(83, 42);
            this.Guna2Button1.TabIndex = 65;
            this.Guna2Button1.Text = "Cash";
            this.Guna2Button1.TextOffset = new System.Drawing.Point(-8, 11);
            this.Guna2Button1.UseTransparentBackground = true;
            // 
            // Guna2Button2
            // 
            this.Guna2Button2.Animated = true;
            this.Guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button2.BorderColor = System.Drawing.Color.LightGray;
            this.Guna2Button2.BorderRadius = 8;
            this.Guna2Button2.BorderThickness = 1;
            this.Guna2Button2.CheckedState.Parent = this.Guna2Button2;
            this.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guna2Button2.CustomImages.Parent = this.Guna2Button2;
            this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button2.DisabledState.Parent = this.Guna2Button2;
            this.Guna2Button2.Enabled = false;
            this.Guna2Button2.FillColor = System.Drawing.Color.White;
            this.Guna2Button2.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.Guna2Button2.HoverState.Parent = this.Guna2Button2;
            this.Guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button2.Image")));
            this.Guna2Button2.ImageOffset = new System.Drawing.Point(14, -6);
            this.Guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.Guna2Button2.Location = new System.Drawing.Point(255, 8);
            this.Guna2Button2.Name = "Guna2Button2";
            this.Guna2Button2.ShadowDecoration.Parent = this.Guna2Button2;
            this.Guna2Button2.Size = new System.Drawing.Size(83, 42);
            this.Guna2Button2.TabIndex = 66;
            this.Guna2Button2.Text = "Debit Card";
            this.Guna2Button2.TextOffset = new System.Drawing.Point(-7, 11);
            this.Guna2Button2.UseTransparentBackground = true;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label30.ForeColor = System.Drawing.Color.Black;
            this.Label30.Location = new System.Drawing.Point(20, 19);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(128, 20);
            this.Label30.TabIndex = 58;
            this.Label30.Text = "Payment Method";
            // 
            // Guna2Elipse6
            // 
            this.Guna2Elipse6.TargetControl = this.pnlProducts;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.Label12);
            this.pnlProducts.Controls.Add(this.Label11);
            this.pnlProducts.Controls.Add(this.Label10);
            this.pnlProducts.Controls.Add(this.Label7);
            this.pnlProducts.Location = new System.Drawing.Point(31, 172);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(844, 45);
            this.pnlProducts.TabIndex = 2;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Proxima Nova Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.DarkGray;
            this.Label12.Location = new System.Drawing.Point(724, 15);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(94, 18);
            this.Label12.TabIndex = 57;
            this.Label12.Text = "Item Subtotal";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Proxima Nova Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DarkGray;
            this.Label11.Location = new System.Drawing.Point(525, 15);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(59, 18);
            this.Label11.TabIndex = 56;
            this.Label11.Text = "Amount";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Proxima Nova Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.DarkGray;
            this.Label10.Location = new System.Drawing.Point(402, 15);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 18);
            this.Label10.TabIndex = 55;
            this.Label10.Text = "Item Price";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Proxima Nova Rg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(20, 12);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(159, 23);
            this.Label7.TabIndex = 54;
            this.Label7.Text = "Products Ordered";
            // 
            // Guna2Elipse7
            // 
            this.Guna2Elipse7.TargetControl = this.flpCheckoutCart;
            // 
            // flpCheckoutCart
            // 
            this.flpCheckoutCart.AutoScroll = true;
            this.flpCheckoutCart.BackColor = System.Drawing.Color.White;
            this.flpCheckoutCart.Controls.Add(this.Panel6);
            this.flpCheckoutCart.Controls.Add(this.lstCheckout);
            this.flpCheckoutCart.Location = new System.Drawing.Point(31, 215);
            this.flpCheckoutCart.Name = "flpCheckoutCart";
            this.flpCheckoutCart.Size = new System.Drawing.Size(844, 161);
            this.flpCheckoutCart.TabIndex = 3;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Label21);
            this.Panel6.Controls.Add(this.Label22);
            this.Panel6.Controls.Add(this.Label23);
            this.Panel6.Controls.Add(this.Label24);
            this.Panel6.Controls.Add(this.Guna2PictureBox14);
            this.Panel6.Location = new System.Drawing.Point(3, 3);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(820, 73);
            this.Panel6.TabIndex = 6;
            this.Panel6.Visible = false;
            // 
            // Label21
            // 
            this.Label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.Black;
            this.Label21.Location = new System.Drawing.Point(724, 25);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(91, 21);
            this.Label21.TabIndex = 5;
            this.Label21.Text = "₱150";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label22
            // 
            this.Label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.Color.Black;
            this.Label22.Location = new System.Drawing.Point(525, 25);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(56, 21);
            this.Label22.TabIndex = 4;
            this.Label22.Text = "1";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label23
            // 
            this.Label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.Color.Black;
            this.Label23.Location = new System.Drawing.Point(402, 25);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(69, 21);
            this.Label23.TabIndex = 3;
            this.Label23.Text = "₱150";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label24
            // 
            this.Label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(95, 24);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(276, 21);
            this.Label24.TabIndex = 2;
            this.Label24.Text = "Furr Magic Small";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Guna2PictureBox14
            // 
            this.Guna2PictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox14.Image")));
            this.Guna2PictureBox14.ImageRotate = 0F;
            this.Guna2PictureBox14.Location = new System.Drawing.Point(21, 8);
            this.Guna2PictureBox14.Name = "Guna2PictureBox14";
            this.Guna2PictureBox14.ShadowDecoration.Parent = this.Guna2PictureBox14;
            this.Guna2PictureBox14.Size = new System.Drawing.Size(55, 55);
            this.Guna2PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox14.TabIndex = 1;
            this.Guna2PictureBox14.TabStop = false;
            this.Guna2PictureBox14.UseTransparentBackground = true;
            // 
            // lstCheckout
            // 
            this.lstCheckout.FormattingEnabled = true;
            this.lstCheckout.Location = new System.Drawing.Point(3, 82);
            this.lstCheckout.Name = "lstCheckout";
            this.lstCheckout.Size = new System.Drawing.Size(120, 56);
            this.lstCheckout.TabIndex = 7;
            this.lstCheckout.Visible = false;
            // 
            // Guna2Elipse8
            // 
            this.Guna2Elipse8.TargetControl = this.pnlLast;
            // 
            // pnlLast
            // 
            this.pnlLast.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLast.Controls.Add(this.Label19);
            this.pnlLast.Controls.Add(this.Label13);
            this.pnlLast.Controls.Add(this.lblItemTotal);
            this.pnlLast.Controls.Add(this.lblCartCount);
            this.pnlLast.Controls.Add(this.txtMessage);
            this.pnlLast.Controls.Add(this.Guna2PictureBox15);
            this.pnlLast.Controls.Add(this.Label27);
            this.pnlLast.Location = new System.Drawing.Point(31, 376);
            this.pnlLast.Name = "pnlLast";
            this.pnlLast.Size = new System.Drawing.Size(844, 60);
            this.pnlLast.TabIndex = 8;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Proxima Nova Lt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.Black;
            this.Label19.Location = new System.Drawing.Point(368, 13);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(94, 16);
            this.Label19.TabIndex = 60;
            this.Label19.Text = "Standard Local";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Proxima Nova Rg", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label13.Location = new System.Drawing.Point(368, 33);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(108, 13);
            this.Label13.TabIndex = 59;
            this.Label13.Text = "Receive within 7 days";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemTotal
            // 
            this.lblItemTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(19)))));
            this.lblItemTotal.Location = new System.Drawing.Point(710, 11);
            this.lblItemTotal.Name = "lblItemTotal";
            this.lblItemTotal.Size = new System.Drawing.Size(105, 25);
            this.lblItemTotal.TabIndex = 13;
            this.lblItemTotal.Text = "₱150";
            this.lblItemTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCartCount.Location = new System.Drawing.Point(590, 22);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(113, 16);
            this.lblCartCount.TabIndex = 58;
            this.lblCartCount.Text = "Order Total (1 Item):";
            this.lblCartCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMessage
            // 
            this.txtMessage.Animated = true;
            this.txtMessage.BorderRadius = 3;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.Parent = this.txtMessage;
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.FocusedState.Parent = this.txtMessage;
            this.txtMessage.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.HoverState.Parent = this.txtMessage;
            this.txtMessage.Location = new System.Drawing.Point(97, 11);
            this.txtMessage.MaxLength = 99;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderText = "(Optional) Leave a message";
            this.txtMessage.SelectedText = "";
            this.txtMessage.ShadowDecoration.Parent = this.txtMessage;
            this.txtMessage.Size = new System.Drawing.Size(221, 36);
            this.txtMessage.TabIndex = 14;
            // 
            // Guna2PictureBox15
            // 
            this.Guna2PictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox15.Image")));
            this.Guna2PictureBox15.ImageRotate = 90F;
            this.Guna2PictureBox15.Location = new System.Drawing.Point(302, 2);
            this.Guna2PictureBox15.Name = "Guna2PictureBox15";
            this.Guna2PictureBox15.ShadowDecoration.Parent = this.Guna2PictureBox15;
            this.Guna2PictureBox15.Size = new System.Drawing.Size(83, 56);
            this.Guna2PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox15.TabIndex = 9;
            this.Guna2PictureBox15.TabStop = false;
            this.Guna2PictureBox15.UseTransparentBackground = true;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Proxima Nova Rg", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.Color.Black;
            this.Label27.Location = new System.Drawing.Point(21, 20);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(70, 18);
            this.Label27.TabIndex = 13;
            this.Label27.Text = "Message:";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Guna2Elipse9
            // 
            this.Guna2Elipse9.TargetControl = this.flpOrder;
            // 
            // Guna2PictureBox10
            // 
            this.Guna2PictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox10.Image")));
            this.Guna2PictureBox10.ImageRotate = 0F;
            this.Guna2PictureBox10.Location = new System.Drawing.Point(402, 44);
            this.Guna2PictureBox10.Name = "Guna2PictureBox10";
            this.Guna2PictureBox10.ShadowDecoration.Parent = this.Guna2PictureBox10;
            this.Guna2PictureBox10.Size = new System.Drawing.Size(47, 48);
            this.Guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox10.TabIndex = 29;
            this.Guna2PictureBox10.TabStop = false;
            this.Guna2PictureBox10.UseTransparentBackground = true;
            // 
            // Guna2PictureBox9
            // 
            this.Guna2PictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox9.Image")));
            this.Guna2PictureBox9.ImageRotate = 0F;
            this.Guna2PictureBox9.Location = new System.Drawing.Point(358, 80);
            this.Guna2PictureBox9.Name = "Guna2PictureBox9";
            this.Guna2PictureBox9.ShadowDecoration.Parent = this.Guna2PictureBox9;
            this.Guna2PictureBox9.Size = new System.Drawing.Size(47, 48);
            this.Guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox9.TabIndex = 28;
            this.Guna2PictureBox9.TabStop = false;
            this.Guna2PictureBox9.UseTransparentBackground = true;
            // 
            // Guna2PictureBox8
            // 
            this.Guna2PictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox8.Image")));
            this.Guna2PictureBox8.ImageRotate = 0F;
            this.Guna2PictureBox8.Location = new System.Drawing.Point(402, -20);
            this.Guna2PictureBox8.Name = "Guna2PictureBox8";
            this.Guna2PictureBox8.ShadowDecoration.Parent = this.Guna2PictureBox8;
            this.Guna2PictureBox8.Size = new System.Drawing.Size(47, 48);
            this.Guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox8.TabIndex = 27;
            this.Guna2PictureBox8.TabStop = false;
            this.Guna2PictureBox8.UseTransparentBackground = true;
            // 
            // Guna2PictureBox1
            // 
            this.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox1.Image")));
            this.Guna2PictureBox1.ImageRotate = 0F;
            this.Guna2PictureBox1.Location = new System.Drawing.Point(358, 12);
            this.Guna2PictureBox1.Name = "Guna2PictureBox1";
            this.Guna2PictureBox1.ShadowDecoration.Parent = this.Guna2PictureBox1;
            this.Guna2PictureBox1.Size = new System.Drawing.Size(47, 48);
            this.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Guna2PictureBox1.TabIndex = 26;
            this.Guna2PictureBox1.TabStop = false;
            this.Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.Transparent;
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(551, 14);
            this.picProfile.Name = "picProfile";
            this.picProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProfile.ShadowDecoration.Parent = this.picProfile;
            this.picProfile.Size = new System.Drawing.Size(64, 64);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 19;
            this.picProfile.TabStop = false;
            this.picProfile.UseTransparentBackground = true;
            // 
            // btnCage
            // 
            this.btnCage.Animated = true;
            this.btnCage.BackColor = System.Drawing.Color.Transparent;
            this.btnCage.BorderColor = System.Drawing.Color.LightGray;
            this.btnCage.BorderRadius = 8;
            this.btnCage.BorderThickness = 1;
            this.btnCage.CheckedState.Parent = this.btnCage;
            this.btnCage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCage.CustomImages.Parent = this.btnCage;
            this.btnCage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCage.DisabledState.Parent = this.btnCage;
            this.btnCage.FillColor = System.Drawing.Color.White;
            this.btnCage.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.btnCage.ForeColor = System.Drawing.Color.Black;
            this.btnCage.HoverState.Parent = this.btnCage;
            this.btnCage.Image = ((System.Drawing.Image)(resources.GetObject("btnCage.Image")));
            this.btnCage.ImageOffset = new System.Drawing.Point(8, -11);
            this.btnCage.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCage.Location = new System.Drawing.Point(535, 129);
            this.btnCage.Name = "btnCage";
            this.btnCage.ShadowDecoration.Parent = this.btnCage;
            this.btnCage.Size = new System.Drawing.Size(80, 90);
            this.btnCage.TabIndex = 16;
            this.btnCage.Text = "Cage";
            this.btnCage.TextOffset = new System.Drawing.Point(-8, 20);
            this.btnCage.UseTransparentBackground = true;
            this.btnCage.Click += new System.EventHandler(this.btnCage_Click);
            this.btnCage.MouseEnter += new System.EventHandler(this.btnCage_MouseEnter);
            this.btnCage.MouseLeave += new System.EventHandler(this.btnCage_MouseLeave);
            // 
            // btnMedicine
            // 
            this.btnMedicine.Animated = true;
            this.btnMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicine.BorderColor = System.Drawing.Color.LightGray;
            this.btnMedicine.BorderRadius = 8;
            this.btnMedicine.BorderThickness = 1;
            this.btnMedicine.CheckedState.Parent = this.btnMedicine;
            this.btnMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicine.CustomImages.Parent = this.btnMedicine;
            this.btnMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicine.DisabledState.Parent = this.btnMedicine;
            this.btnMedicine.FillColor = System.Drawing.Color.White;
            this.btnMedicine.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.btnMedicine.ForeColor = System.Drawing.Color.Black;
            this.btnMedicine.HoverState.Parent = this.btnMedicine;
            this.btnMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicine.Image")));
            this.btnMedicine.ImageOffset = new System.Drawing.Point(14, -11);
            this.btnMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMedicine.Location = new System.Drawing.Point(436, 129);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.ShadowDecoration.Parent = this.btnMedicine;
            this.btnMedicine.Size = new System.Drawing.Size(80, 90);
            this.btnMedicine.TabIndex = 15;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.TextOffset = new System.Drawing.Point(-8, 20);
            this.btnMedicine.UseTransparentBackground = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            this.btnMedicine.MouseEnter += new System.EventHandler(this.btnMedicine_MouseEnter);
            this.btnMedicine.MouseLeave += new System.EventHandler(this.btnMedicine_MouseLeave);
            // 
            // btnToiletries
            // 
            this.btnToiletries.Animated = true;
            this.btnToiletries.BackColor = System.Drawing.Color.Transparent;
            this.btnToiletries.BorderColor = System.Drawing.Color.LightGray;
            this.btnToiletries.BorderRadius = 8;
            this.btnToiletries.BorderThickness = 1;
            this.btnToiletries.CheckedState.Parent = this.btnToiletries;
            this.btnToiletries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToiletries.CustomImages.Parent = this.btnToiletries;
            this.btnToiletries.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToiletries.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToiletries.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToiletries.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToiletries.DisabledState.Parent = this.btnToiletries;
            this.btnToiletries.FillColor = System.Drawing.Color.White;
            this.btnToiletries.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.btnToiletries.ForeColor = System.Drawing.Color.Black;
            this.btnToiletries.HoverState.Parent = this.btnToiletries;
            this.btnToiletries.Image = ((System.Drawing.Image)(resources.GetObject("btnToiletries.Image")));
            this.btnToiletries.ImageOffset = new System.Drawing.Point(14, -11);
            this.btnToiletries.ImageSize = new System.Drawing.Size(30, 30);
            this.btnToiletries.Location = new System.Drawing.Point(335, 129);
            this.btnToiletries.Name = "btnToiletries";
            this.btnToiletries.ShadowDecoration.Parent = this.btnToiletries;
            this.btnToiletries.Size = new System.Drawing.Size(80, 90);
            this.btnToiletries.TabIndex = 14;
            this.btnToiletries.Text = "Toiletries";
            this.btnToiletries.TextOffset = new System.Drawing.Point(-8, 20);
            this.btnToiletries.UseTransparentBackground = true;
            this.btnToiletries.Click += new System.EventHandler(this.btnToiletries_Click);
            this.btnToiletries.MouseEnter += new System.EventHandler(this.btnToiletries_MouseEnter);
            this.btnToiletries.MouseLeave += new System.EventHandler(this.btnToiletries_MouseLeave);
            // 
            // btnLeash
            // 
            this.btnLeash.Animated = true;
            this.btnLeash.BackColor = System.Drawing.Color.Transparent;
            this.btnLeash.BorderColor = System.Drawing.Color.LightGray;
            this.btnLeash.BorderRadius = 8;
            this.btnLeash.BorderThickness = 1;
            this.btnLeash.CheckedState.Parent = this.btnLeash;
            this.btnLeash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeash.CustomImages.Parent = this.btnLeash;
            this.btnLeash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeash.DisabledState.Parent = this.btnLeash;
            this.btnLeash.FillColor = System.Drawing.Color.White;
            this.btnLeash.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.btnLeash.ForeColor = System.Drawing.Color.Black;
            this.btnLeash.HoverState.Parent = this.btnLeash;
            this.btnLeash.Image = ((System.Drawing.Image)(resources.GetObject("btnLeash.Image")));
            this.btnLeash.ImageOffset = new System.Drawing.Point(10, -11);
            this.btnLeash.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLeash.Location = new System.Drawing.Point(234, 129);
            this.btnLeash.Name = "btnLeash";
            this.btnLeash.ShadowDecoration.Parent = this.btnLeash;
            this.btnLeash.Size = new System.Drawing.Size(80, 90);
            this.btnLeash.TabIndex = 13;
            this.btnLeash.Text = "Leash";
            this.btnLeash.TextOffset = new System.Drawing.Point(-8, 20);
            this.btnLeash.UseTransparentBackground = true;
            this.btnLeash.Click += new System.EventHandler(this.btnLeash_Click);
            this.btnLeash.MouseEnter += new System.EventHandler(this.btnLeash_MouseEnter);
            this.btnLeash.MouseLeave += new System.EventHandler(this.btnLeash_MouseLeave);
            // 
            // btnFoods
            // 
            this.btnFoods.Animated = true;
            this.btnFoods.BackColor = System.Drawing.Color.Transparent;
            this.btnFoods.BorderColor = System.Drawing.Color.LightGray;
            this.btnFoods.BorderRadius = 8;
            this.btnFoods.BorderThickness = 1;
            this.btnFoods.CheckedState.Parent = this.btnFoods;
            this.btnFoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoods.CustomImages.Parent = this.btnFoods;
            this.btnFoods.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoods.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoods.DisabledState.Parent = this.btnFoods;
            this.btnFoods.FillColor = System.Drawing.Color.White;
            this.btnFoods.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.btnFoods.ForeColor = System.Drawing.Color.Black;
            this.btnFoods.HoverState.Parent = this.btnFoods;
            this.btnFoods.Image = ((System.Drawing.Image)(resources.GetObject("btnFoods.Image")));
            this.btnFoods.ImageOffset = new System.Drawing.Point(9, -11);
            this.btnFoods.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFoods.Location = new System.Drawing.Point(133, 129);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.ShadowDecoration.Parent = this.btnFoods;
            this.btnFoods.Size = new System.Drawing.Size(80, 90);
            this.btnFoods.TabIndex = 12;
            this.btnFoods.Text = "Food";
            this.btnFoods.TextOffset = new System.Drawing.Point(-8, 20);
            this.btnFoods.UseTransparentBackground = true;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            this.btnFoods.MouseEnter += new System.EventHandler(this.btnFoods_MouseEnter);
            this.btnFoods.MouseLeave += new System.EventHandler(this.btnFoods_MouseLeave);
            // 
            // btnAll
            // 
            this.btnAll.Animated = true;
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BorderColor = System.Drawing.Color.LightGray;
            this.btnAll.BorderRadius = 8;
            this.btnAll.BorderThickness = 1;
            this.btnAll.CheckedState.Parent = this.btnAll;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.CustomImages.Parent = this.btnAll;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.DisabledState.Parent = this.btnAll;
            this.btnAll.FillColor = System.Drawing.Color.White;
            this.btnAll.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F);
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.HoverState.Parent = this.btnAll;
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.ImageOffset = new System.Drawing.Point(4, -11);
            this.btnAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAll.Location = new System.Drawing.Point(34, 129);
            this.btnAll.Name = "btnAll";
            this.btnAll.ShadowDecoration.Parent = this.btnAll;
            this.btnAll.Size = new System.Drawing.Size(80, 90);
            this.btnAll.TabIndex = 11;
            this.btnAll.Text = "All";
            this.btnAll.TextOffset = new System.Drawing.Point(-9, 20);
            this.btnAll.UseTransparentBackground = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            this.btnAll.MouseEnter += new System.EventHandler(this.Guna2Button1_MouseEnter);
            this.btnAll.MouseLeave += new System.EventHandler(this.btnAll_MouseLeave);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Proxima Nova Lt", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.txtSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(34, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search category or menu...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(275, 44);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // AccountdbDataSet
            // 
            this.AccountdbDataSet.DataSetName = "accountdbDataSet";
            this.AccountdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsercartBindingSource
            // 
            this.UsercartBindingSource.DataMember = "usercart";
            this.UsercartBindingSource.DataSource = this.AccountdbDataSet;
            // 
            // UsercartTableAdapter
            // 
            this.UsercartTableAdapter.ClearBeforeFill = true;
            // 
            // Guna2PictureBox13
            // 
            this.Guna2PictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox13.Image")));
            this.Guna2PictureBox13.ImageRotate = 0F;
            this.Guna2PictureBox13.Location = new System.Drawing.Point(-81, 588);
            this.Guna2PictureBox13.Name = "Guna2PictureBox13";
            this.Guna2PictureBox13.ShadowDecoration.Parent = this.Guna2PictureBox13;
            this.Guna2PictureBox13.Size = new System.Drawing.Size(1087, 32);
            this.Guna2PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox13.TabIndex = 7;
            this.Guna2PictureBox13.TabStop = false;
            this.Guna2PictureBox13.UseTransparentBackground = true;
            // 
            // Guna2PictureBox16
            // 
            this.Guna2PictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox16.Image")));
            this.Guna2PictureBox16.ImageRotate = 0F;
            this.Guna2PictureBox16.Location = new System.Drawing.Point(-81, 491);
            this.Guna2PictureBox16.Name = "Guna2PictureBox16";
            this.Guna2PictureBox16.ShadowDecoration.Parent = this.Guna2PictureBox16;
            this.Guna2PictureBox16.Size = new System.Drawing.Size(1087, 32);
            this.Guna2PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox16.TabIndex = 10;
            this.Guna2PictureBox16.TabStop = false;
            this.Guna2PictureBox16.UseTransparentBackground = true;
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Controls.Add(this.pnlBack);
            this.pnlCheckout.Controls.Add(this.Guna2PictureBox16);
            this.pnlCheckout.Controls.Add(this.pnlPayment);
            this.pnlCheckout.Controls.Add(this.Guna2PictureBox13);
            this.pnlCheckout.Controls.Add(this.pnlLast);
            this.pnlCheckout.Controls.Add(this.pnlFinal);
            this.pnlCheckout.Controls.Add(this.flpCheckoutCart);
            this.pnlCheckout.Controls.Add(this.pnlProducts);
            this.pnlCheckout.Controls.Add(this.pnlAddress);
            this.pnlCheckout.Location = new System.Drawing.Point(0, 0);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(913, 683);
            this.pnlCheckout.TabIndex = 30;
            this.pnlCheckout.Visible = false;
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 683);
            this.Controls.Add(this.pnlCheckout);
            this.Controls.Add(this.Guna2PictureBox10);
            this.Controls.Add(this.Guna2PictureBox9);
            this.Controls.Add(this.Guna2PictureBox8);
            this.Controls.Add(this.Guna2PictureBox1);
            this.Controls.Add(this.lblItemCount);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.flpOrder);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnCage);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.btnToiletries);
            this.Controls.Add(this.btnLeash);
            this.Controls.Add(this.btnFoods);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePanel";
            this.Load += new System.EventHandler(this.HomePanel_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox11)).EndInit();
            this.pnlCartCheck.ResumeLayout(false);
            this.pnlCartCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).EndInit();
            this.flpCart.ResumeLayout(false);
            this.flpCart.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Guna2NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox6)).EndInit();
            this.flpOrder.ResumeLayout(false);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox12)).EndInit();
            this.pnlFinal.ResumeLayout(false);
            this.pnlFinal.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.flpCheckoutCart.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox14)).EndInit();
            this.pnlLast.ResumeLayout(false);
            this.pnlLast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsercartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox16)).EndInit();
            this.pnlCheckout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2Panel pnlOrder;
        internal Guna.UI2.WinForms.Guna2Button btnAll;
        internal Guna.UI2.WinForms.Guna2TextBox txtSearch;
        internal Guna.UI2.WinForms.Guna2Button btnFoods;
        internal Guna.UI2.WinForms.Guna2Button btnLeash;
        internal Guna.UI2.WinForms.Guna2Button btnToiletries;
        internal Guna.UI2.WinForms.Guna2Button btnMedicine;
        internal Guna.UI2.WinForms.Guna2Button btnCage;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Label lblItems;
        internal Guna.UI2.WinForms.Guna2Button btnProceed;
        internal FlowLayoutPanel flpCart;
        internal Label lblCart;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox picProfile;
        internal Label Label3;
        internal Label lblTotal;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbAddress;
        internal Label Label9;
        internal Label Label8;
        internal Label lblSubT;
        internal Label Label6;
        internal Label Label5;
        internal Label lblUsername;
        internal Label lblItemCount;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        internal FlowLayoutPanel flpOrder;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse2;
        internal ListBox lstPrices;
        internal Panel Panel3;
        internal Label Label14;
        internal Label Label15;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button4;
        internal Label Label16;
        internal Guna.UI2.WinForms.Guna2NumericUpDown Guna2NumericUpDown2;
        internal Label Label17;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox6;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox8;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox9;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox10;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox11;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox5;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox4;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse3;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse4;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse5;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse6;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse7;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse8;
        internal Panel pnlCartCheck;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox17;
        internal Label Label28;
        internal accountdbDataSet AccountdbDataSet;
        internal BindingSource UsercartBindingSource;
        internal accountdbDataSetTableAdapters.usercartTableAdapter UsercartTableAdapter;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse9;
        internal Panel pnlBack;
        internal Guna.UI2.WinForms.Guna2PictureBox btnBack;
        internal Label Label1;
        internal Panel pnlAddress;
        internal Label Label29;
        internal Label lblAddPlace;
        internal Label lblAddName;
        internal Label Label4;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox12;
        internal Panel pnlFinal;
        internal ListBox checkoutLstBox;
        internal Label Label26;
        internal Label Label25;
        internal Label Label20;
        internal Label lblMerch;
        internal Label Label18;
        internal Label lblGrandTotal;
        internal Guna.UI2.WinForms.Guna2Button btnSubmit;
        internal Panel pnlPayment;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button3;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button2;
        internal Label Label30;
        internal Panel pnlProducts;
        internal Label Label12;
        internal Label Label11;
        internal Label Label10;
        internal Label Label7;
        internal FlowLayoutPanel flpCheckoutCart;
        internal Panel Panel6;
        internal Label Label21;
        internal Label Label22;
        internal Label Label23;
        internal Label Label24;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox14;
        internal ListBox lstCheckout;
        internal Panel pnlLast;
        internal Label Label19;
        internal Label Label13;
        internal Label lblItemTotal;
        internal Label lblCartCount;
        internal Guna.UI2.WinForms.Guna2TextBox txtMessage;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox15;
        internal Label Label27;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox13;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox16;
        internal Panel pnlCheckout;
    }
}