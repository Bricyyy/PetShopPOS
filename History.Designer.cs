using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class History : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            flpHistory = new FlowLayoutPanel();
            pnlOrderTest = new Panel();
            lblAddPlace = new Label();
            lblGrandTotal = new Label();
            Label24 = new Label();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Panel1 = new Panel();
            Label21 = new Label();
            Label22 = new Label();
            Label1 = new Label();
            Label26 = new Label();
            Label7 = new Label();
            listOrderNum = new ListBox();
            listItemCount = new ListBox();
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnlOrders = new Panel();
            Panel2 = new Panel();
            lblOSubT = new Label();
            Label10 = new Label();
            lblOTotal = new Label();
            lblPayType = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            pnlNothing = new Panel();
            flpOrderOverview = new FlowLayoutPanel();
            Panel3 = new Panel();
            Label13 = new Label();
            Label12 = new Label();
            Label11 = new Label();
            pnlInfo = new Panel();
            lblMessage = new Label();
            Label4 = new Label();
            lblAddFull = new Label();
            lblAddPhone = new Label();
            lblAddName = new Label();
            Label3 = new Label();
            pnlReOrder = new Panel();
            btnBuyAgain = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader = new Panel();
            lblONum = new Label();
            Label2 = new Label();
            Guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            btnBack.Click += new EventHandler(btnBack_Click);
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2PictureBox13 = new Guna.UI2.WinForms.Guna2PictureBox();
            txtSearchHistory = new Guna.UI2.WinForms.Guna2TextBox();
            txtSearchHistory.TextChanged += new EventHandler(txtSearchHistory_TextChanged);
            flpHistory.SuspendLayout();
            pnlOrderTest.SuspendLayout();
            FlowLayoutPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            pnlOrders.SuspendLayout();
            Panel2.SuspendLayout();
            flpOrderOverview.SuspendLayout();
            Panel3.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlReOrder.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox13).BeginInit();
            SuspendLayout();
            // 
            // flpHistory
            // 
            flpHistory.Anchor = AnchorStyles.Bottom;
            flpHistory.AutoScroll = true;
            flpHistory.Controls.Add(pnlOrderTest);
            flpHistory.Controls.Add(listOrderNum);
            flpHistory.Controls.Add(listItemCount);
            flpHistory.Location = new Point(12, 73);
            flpHistory.Name = "flpHistory";
            flpHistory.Size = new Size(885, 598);
            flpHistory.TabIndex = 1;
            // 
            // pnlOrderTest
            // 
            pnlOrderTest.BackColor = Color.White;
            pnlOrderTest.Controls.Add(lblAddPlace);
            pnlOrderTest.Controls.Add(lblGrandTotal);
            pnlOrderTest.Controls.Add(Label24);
            pnlOrderTest.Controls.Add(Guna2PictureBox1);
            pnlOrderTest.Controls.Add(FlowLayoutPanel1);
            pnlOrderTest.Controls.Add(Label26);
            pnlOrderTest.Controls.Add(Guna2PictureBox13);
            pnlOrderTest.Controls.Add(Label7);
            pnlOrderTest.Location = new Point(3, 3);
            pnlOrderTest.Name = "pnlOrderTest";
            pnlOrderTest.Size = new Size(855, 246);
            pnlOrderTest.TabIndex = 0;
            pnlOrderTest.Visible = false;
            // 
            // lblAddPlace
            // 
            lblAddPlace.Anchor = AnchorStyles.Bottom;
            lblAddPlace.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddPlace.ForeColor = SystemColors.ControlDarkDark;
            lblAddPlace.Location = new Point(17, 200);
            lblAddPlace.Name = "lblAddPlace";
            lblAddPlace.Size = new Size(632, 16);
            lblAddPlace.TabIndex = 63;
            lblAddPlace.Text = "Address: Bryan Iverson Delos Santos 09162964676 168 Mamatid, Cabuyao, Laguna, Sou" + "th Luzon, 4025";
            lblAddPlace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.Font = new Font("Proxima Nova Rg", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.FromArgb(255, 152, 19);
            lblGrandTotal.Location = new Point(744, 189);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(88, 27);
            lblGrandTotal.TabIndex = 61;
            lblGrandTotal.Text = "₱99999";
            lblGrandTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label24.ForeColor = Color.Black;
            Label24.Location = new Point(655, 195);
            Label24.Name = "Label24";
            Label24.Size = new Size(90, 20);
            Label24.TabIndex = 60;
            Label24.Text = "Order Total:";
            Label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Controls.Add(Panel1);
            FlowLayoutPanel1.Location = new Point(20, 55);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(812, 100);
            FlowLayoutPanel1.TabIndex = 58;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label21);
            Panel1.Controls.Add(Label22);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(Guna2PictureBox2);
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(774, 93);
            Panel1.TabIndex = 0;
            // 
            // Label21
            // 
            Label21.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label21.ForeColor = Color.Black;
            Label21.Location = new Point(660, 35);
            Label21.Name = "Label21";
            Label21.Size = new Size(91, 21);
            Label21.TabIndex = 6;
            Label21.Text = "₱150";
            Label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label22
            // 
            Label22.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label22.ForeColor = Color.Black;
            Label22.Location = new Point(91, 44);
            Label22.Name = "Label22";
            Label22.Size = new Size(56, 21);
            Label22.TabIndex = 5;
            Label22.Text = "1";
            Label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(91, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(276, 21);
            Label1.TabIndex = 3;
            Label1.Text = "Furr Magic Small";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label26
            // 
            Label26.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label26.ForeColor = SystemColors.ControlDarkDark;
            Label26.Location = new Point(593, 14);
            Label26.Name = "Label26";
            Label26.Size = new Size(239, 16);
            Label26.TabIndex = 57;
            Label26.Text = "Order Placed: 2020/11/18 01:47";
            Label26.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            Label7.Font = new Font("Proxima Nova Lt", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.Black;
            Label7.Location = new Point(16, 10);
            Label7.Name = "Label7";
            Label7.Size = new Size(180, 20);
            Label7.TabIndex = 55;
            Label7.Text = "Order #KF3OFD";
            // 
            // listOrderNum
            // 
            listOrderNum.FormattingEnabled = true;
            listOrderNum.Location = new Point(3, 255);
            listOrderNum.Name = "listOrderNum";
            listOrderNum.Size = new Size(120, 95);
            listOrderNum.TabIndex = 1;
            listOrderNum.Visible = false;
            // 
            // listItemCount
            // 
            listItemCount.FormattingEnabled = true;
            listItemCount.Location = new Point(129, 255);
            listItemCount.Name = "listItemCount";
            listItemCount.Size = new Size(120, 95);
            listItemCount.TabIndex = 2;
            listItemCount.Visible = false;
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = pnlOrderTest;
            // 
            // Guna2Elipse2
            // 
            Guna2Elipse2.TargetControl = flpHistory;
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(Panel2);
            pnlOrders.Controls.Add(pnlNothing);
            pnlOrders.Controls.Add(flpOrderOverview);
            pnlOrders.Controls.Add(pnlInfo);
            pnlOrders.Controls.Add(pnlReOrder);
            pnlOrders.Controls.Add(pnlHeader);
            pnlOrders.Location = new Point(2, 3);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(904, 678);
            pnlOrders.TabIndex = 2;
            pnlOrders.Visible = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.WhiteSmoke;
            Panel2.Controls.Add(Guna2PictureBox8);
            Panel2.Controls.Add(lblOSubT);
            Panel2.Controls.Add(Guna2PictureBox7);
            Panel2.Controls.Add(Guna2PictureBox6);
            Panel2.Controls.Add(Label10);
            Panel2.Controls.Add(Guna2PictureBox5);
            Panel2.Controls.Add(lblOTotal);
            Panel2.Controls.Add(lblPayType);
            Panel2.Controls.Add(Label9);
            Panel2.Controls.Add(Label8);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(Label5);
            Panel2.Controls.Add(Guna2PictureBox4);
            Panel2.Location = new Point(10, 520);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(885, 148);
            Panel2.TabIndex = 4;
            // 
            // lblOSubT
            // 
            lblOSubT.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOSubT.ForeColor = Color.Black;
            lblOSubT.Location = new Point(695, 20);
            lblOSubT.Name = "lblOSubT";
            lblOSubT.Size = new Size(160, 16);
            lblOSubT.TabIndex = 71;
            lblOSubT.Text = "₱500";
            lblOSubT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            Label10.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.ForeColor = Color.Black;
            Label10.Location = new Point(695, 52);
            Label10.Name = "Label10";
            Label10.Size = new Size(160, 16);
            Label10.TabIndex = 68;
            Label10.Text = "₱50";
            Label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOTotal
            // 
            lblOTotal.Font = new Font("Segoe UI", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOTotal.ForeColor = Color.FromArgb(255, 152, 19);
            lblOTotal.Location = new Point(730, 78);
            lblOTotal.Name = "lblOTotal";
            lblOTotal.Size = new Size(128, 32);
            lblOTotal.TabIndex = 66;
            lblOTotal.Text = "₱200";
            lblOTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPayType
            // 
            lblPayType.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayType.ForeColor = Color.Black;
            lblPayType.Location = new Point(695, 124);
            lblPayType.Name = "lblPayType";
            lblPayType.Size = new Size(160, 16);
            lblPayType.TabIndex = 62;
            lblPayType.Text = "Cash on Delivery";
            lblPayType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = SystemColors.ControlDarkDark;
            Label9.Location = new Point(557, 21);
            Label9.Name = "Label9";
            Label9.Size = new Size(86, 15);
            Label9.TabIndex = 65;
            Label9.Text = "Order Subtotal";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = SystemColors.ControlDarkDark;
            Label8.Location = new Point(588, 51);
            Label8.Name = "Label8";
            Label8.Size = new Size(55, 15);
            Label8.TabIndex = 64;
            Label8.Text = "Shipping";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = SystemColors.ControlDarkDark;
            Label6.Location = new Point(576, 87);
            Label6.Name = "Label6";
            Label6.Size = new Size(67, 15);
            Label6.TabIndex = 63;
            Label6.Text = "Order Total";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Proxima Nova Rg", 8.999999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = SystemColors.ControlDarkDark;
            Label5.Location = new Point(560, 125);
            Label5.Name = "Label5";
            Label5.Size = new Size(83, 15);
            Label5.TabIndex = 57;
            Label5.Text = "Payment Type";
            // 
            // pnlNothing
            // 
            pnlNothing.BackColor = Color.WhiteSmoke;
            pnlNothing.Location = new Point(10, 262);
            pnlNothing.Name = "pnlNothing";
            pnlNothing.Size = new Size(885, 15);
            pnlNothing.TabIndex = 1;
            // 
            // flpOrderOverview
            // 
            flpOrderOverview.AutoScroll = true;
            flpOrderOverview.BackColor = Color.WhiteSmoke;
            flpOrderOverview.Controls.Add(Panel3);
            flpOrderOverview.Location = new Point(10, 273);
            flpOrderOverview.Name = "flpOrderOverview";
            flpOrderOverview.Size = new Size(885, 250);
            flpOrderOverview.TabIndex = 3;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(Label13);
            Panel3.Controls.Add(Label12);
            Panel3.Controls.Add(Label11);
            Panel3.Controls.Add(Guna2PictureBox9);
            Panel3.Location = new Point(3, 3);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(855, 113);
            Panel3.TabIndex = 0;
            Panel3.Visible = false;
            // 
            // Label13
            // 
            Label13.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label13.ForeColor = Color.Black;
            Label13.Location = new Point(655, 48);
            Label13.Name = "Label13";
            Label13.Size = new Size(160, 16);
            Label13.TabIndex = 73;
            Label13.Text = "₱500";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            Label12.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label12.ForeColor = Color.Black;
            Label12.Location = new Point(122, 57);
            Label12.Name = "Label12";
            Label12.Size = new Size(124, 23);
            Label12.TabIndex = 63;
            Label12.Text = "x1";
            // 
            // Label11
            // 
            Label11.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.ForeColor = Color.Black;
            Label11.Location = new Point(122, 34);
            Label11.Name = "Label11";
            Label11.Size = new Size(301, 23);
            Label11.TabIndex = 62;
            Label11.Text = "Delivery Address";
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.White;
            pnlInfo.Controls.Add(lblMessage);
            pnlInfo.Controls.Add(Label4);
            pnlInfo.Controls.Add(Guna2PictureBox3);
            pnlInfo.Controls.Add(lblAddFull);
            pnlInfo.Controls.Add(lblAddPhone);
            pnlInfo.Controls.Add(lblAddName);
            pnlInfo.Controls.Add(Label3);
            pnlInfo.Location = new Point(10, 109);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(885, 153);
            pnlInfo.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = SystemColors.ControlDarkDark;
            lblMessage.Location = new Point(332, 60);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(523, 82);
            lblMessage.TabIndex = 61;
            lblMessage.Text = "Near St Joseph 3 Villge";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Proxima Nova Rg", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.Black;
            Label4.Location = new Point(331, 22);
            Label4.Name = "Label4";
            Label4.Size = new Size(95, 23);
            Label4.TabIndex = 60;
            Label4.Text = "Message: ";
            // 
            // lblAddFull
            // 
            lblAddFull.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFull.ForeColor = SystemColors.ControlDarkDark;
            lblAddFull.Location = new Point(23, 99);
            lblAddFull.Name = "lblAddFull";
            lblAddFull.Size = new Size(226, 43);
            lblAddFull.TabIndex = 58;
            lblAddFull.Text = "168 Mamatid, Cabuyao, Laguna, South Luzon 4025";
            // 
            // lblAddPhone
            // 
            lblAddPhone.AutoSize = true;
            lblAddPhone.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddPhone.ForeColor = SystemColors.ControlDarkDark;
            lblAddPhone.Location = new Point(23, 83);
            lblAddPhone.Name = "lblAddPhone";
            lblAddPhone.Size = new Size(90, 16);
            lblAddPhone.TabIndex = 57;
            lblAddPhone.Text = "09162964676";
            lblAddPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAddName
            // 
            lblAddName.AutoSize = true;
            lblAddName.Font = new Font("Proxima Nova Rg", 9.749999f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddName.ForeColor = Color.Black;
            lblAddName.Location = new Point(23, 60);
            lblAddName.Name = "lblAddName";
            lblAddName.Size = new Size(160, 16);
            lblAddName.TabIndex = 56;
            lblAddName.Text = "Bryan Iverson Delos Santos";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Proxima Nova Rg", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.Black;
            Label3.Location = new Point(22, 22);
            Label3.Name = "Label3";
            Label3.Size = new Size(152, 23);
            Label3.TabIndex = 55;
            Label3.Text = "Delivery Address";
            // 
            // pnlReOrder
            // 
            pnlReOrder.BackColor = Color.SeaShell;
            pnlReOrder.Controls.Add(btnBuyAgain);
            pnlReOrder.Location = new Point(10, 51);
            pnlReOrder.Name = "pnlReOrder";
            pnlReOrder.Size = new Size(885, 59);
            pnlReOrder.TabIndex = 1;
            // 
            // btnBuyAgain
            // 
            btnBuyAgain.Animated = true;
            btnBuyAgain.BackColor = Color.Transparent;
            btnBuyAgain.BorderRadius = 3;
            btnBuyAgain.CheckedState.Parent = btnBuyAgain;
            btnBuyAgain.Cursor = Cursors.Hand;
            btnBuyAgain.CustomImages.Parent = btnBuyAgain;
            btnBuyAgain.DisabledState.BorderColor = Color.DarkGray;
            btnBuyAgain.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuyAgain.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuyAgain.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuyAgain.DisabledState.Parent = btnBuyAgain;
            btnBuyAgain.Enabled = false;
            btnBuyAgain.FillColor = Color.FromArgb(255, 152, 19);
            btnBuyAgain.Font = new Font("Proxima Nova Lt", 12.0f, FontStyle.Bold);
            btnBuyAgain.ForeColor = Color.White;
            btnBuyAgain.HoverState.Parent = btnBuyAgain;
            btnBuyAgain.Location = new Point(701, 7);
            btnBuyAgain.Name = "btnBuyAgain";
            btnBuyAgain.ShadowDecoration.Parent = btnBuyAgain;
            btnBuyAgain.Size = new Size(157, 42);
            btnBuyAgain.TabIndex = 7;
            btnBuyAgain.Text = "Buy Again";
            btnBuyAgain.UseTransparentBackground = true;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblONum);
            pnlHeader.Controls.Add(Label2);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Location = new Point(10, 9);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(885, 44);
            pnlHeader.TabIndex = 0;
            // 
            // lblONum
            // 
            lblONum.Font = new Font("Proxima Nova Rg", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblONum.ForeColor = Color.Black;
            lblONum.Location = new Point(599, 11);
            lblONum.Name = "lblONum";
            lblONum.Size = new Size(259, 23);
            lblONum.TabIndex = 55;
            lblONum.Text = "Order #KD34KF";
            lblONum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Proxima Nova Lt", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(255, 152, 19);
            Label2.Location = new Point(60, 11);
            Label2.Name = "Label2";
            Label2.Size = new Size(51, 23);
            Label2.TabIndex = 54;
            Label2.Text = "Back";
            // 
            // Guna2Elipse3
            // 
            Guna2Elipse3.TargetControl = pnlHeader;
            // 
            // Guna2Elipse4
            // 
            Guna2Elipse4.TargetControl = pnlReOrder;
            // 
            // Guna2Elipse5
            // 
            Guna2Elipse5.TargetControl = pnlInfo;
            // 
            // Guna2Elipse6
            // 
            Guna2Elipse6.TargetControl = flpOrderOverview;
            // 
            // Guna2Elipse7
            // 
            Guna2Elipse7.TargetControl = pnlNothing;
            // 
            // Guna2PictureBox8
            // 
            Guna2PictureBox8.BackColor = Color.Transparent;
            Guna2PictureBox8.Image = (Image)resources.GetObject("Guna2PictureBox8.Image");
            Guna2PictureBox8.ImageRotate = 0f;
            Guna2PictureBox8.Location = new Point(-104, -3);
            Guna2PictureBox8.Name = "Guna2PictureBox8";
            Guna2PictureBox8.ShadowDecoration.Parent = Guna2PictureBox8;
            Guna2PictureBox8.Size = new Size(1111, 32);
            Guna2PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox8.TabIndex = 72;
            Guna2PictureBox8.TabStop = false;
            Guna2PictureBox8.UseTransparentBackground = true;
            // 
            // Guna2PictureBox7
            // 
            Guna2PictureBox7.BackColor = Color.Transparent;
            Guna2PictureBox7.Image = (Image)resources.GetObject("Guna2PictureBox7.Image");
            Guna2PictureBox7.ImageRotate = 0f;
            Guna2PictureBox7.Location = new Point(-106, 28);
            Guna2PictureBox7.Name = "Guna2PictureBox7";
            Guna2PictureBox7.ShadowDecoration.Parent = Guna2PictureBox7;
            Guna2PictureBox7.Size = new Size(1111, 32);
            Guna2PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox7.TabIndex = 70;
            Guna2PictureBox7.TabStop = false;
            Guna2PictureBox7.UseTransparentBackground = true;
            // 
            // Guna2PictureBox6
            // 
            Guna2PictureBox6.BackColor = Color.Transparent;
            Guna2PictureBox6.Image = (Image)resources.GetObject("Guna2PictureBox6.Image");
            Guna2PictureBox6.ImageRotate = 0f;
            Guna2PictureBox6.Location = new Point(-106, 59);
            Guna2PictureBox6.Name = "Guna2PictureBox6";
            Guna2PictureBox6.ShadowDecoration.Parent = Guna2PictureBox6;
            Guna2PictureBox6.Size = new Size(1111, 32);
            Guna2PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox6.TabIndex = 69;
            Guna2PictureBox6.TabStop = false;
            Guna2PictureBox6.UseTransparentBackground = true;
            // 
            // Guna2PictureBox5
            // 
            Guna2PictureBox5.BackColor = Color.Transparent;
            Guna2PictureBox5.Image = (Image)resources.GetObject("Guna2PictureBox5.Image");
            Guna2PictureBox5.ImageRotate = 0f;
            Guna2PictureBox5.Location = new Point(-105, 99);
            Guna2PictureBox5.Name = "Guna2PictureBox5";
            Guna2PictureBox5.ShadowDecoration.Parent = Guna2PictureBox5;
            Guna2PictureBox5.Size = new Size(1111, 32);
            Guna2PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox5.TabIndex = 67;
            Guna2PictureBox5.TabStop = false;
            Guna2PictureBox5.UseTransparentBackground = true;
            // 
            // Guna2PictureBox4
            // 
            Guna2PictureBox4.BackColor = Color.Transparent;
            Guna2PictureBox4.Image = (Image)resources.GetObject("Guna2PictureBox4.Image");
            Guna2PictureBox4.ImageRotate = 90.0f;
            Guna2PictureBox4.Location = new Point(604, 15);
            Guna2PictureBox4.Name = "Guna2PictureBox4";
            Guna2PictureBox4.ShadowDecoration.Parent = Guna2PictureBox4;
            Guna2PictureBox4.Size = new Size(105, 132);
            Guna2PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox4.TabIndex = 62;
            Guna2PictureBox4.TabStop = false;
            Guna2PictureBox4.UseTransparentBackground = true;
            // 
            // Guna2PictureBox9
            // 
            Guna2PictureBox9.BackColor = Color.Transparent;
            Guna2PictureBox9.Image = (Image)resources.GetObject("Guna2PictureBox9.Image");
            Guna2PictureBox9.ImageRotate = 0f;
            Guna2PictureBox9.Location = new Point(20, 12);
            Guna2PictureBox9.Name = "Guna2PictureBox9";
            Guna2PictureBox9.ShadowDecoration.Parent = Guna2PictureBox9;
            Guna2PictureBox9.Size = new Size(89, 89);
            Guna2PictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox9.TabIndex = 0;
            Guna2PictureBox9.TabStop = false;
            Guna2PictureBox9.UseTransparentBackground = true;
            // 
            // Guna2PictureBox3
            // 
            Guna2PictureBox3.BackColor = Color.Transparent;
            Guna2PictureBox3.Image = (Image)resources.GetObject("Guna2PictureBox3.Image");
            Guna2PictureBox3.ImageRotate = 90.0f;
            Guna2PictureBox3.Location = new Point(243, 11);
            Guna2PictureBox3.Name = "Guna2PictureBox3";
            Guna2PictureBox3.ShadowDecoration.Parent = Guna2PictureBox3;
            Guna2PictureBox3.Size = new Size(105, 132);
            Guna2PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox3.TabIndex = 59;
            Guna2PictureBox3.TabStop = false;
            Guna2PictureBox3.UseTransparentBackground = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            btnBack.ImageRotate = 0f;
            btnBack.Location = new Point(16, 5);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.Parent = btnBack;
            btnBack.Size = new Size(32, 32);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 3;
            btnBack.TabStop = false;
            btnBack.UseTransparentBackground = true;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.Image = (Image)resources.GetObject("Guna2PictureBox1.Image");
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(-108, 157);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1;
            Guna2PictureBox1.Size = new Size(1087, 32);
            Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox1.TabIndex = 59;
            Guna2PictureBox1.TabStop = false;
            Guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Guna2PictureBox2
            // 
            Guna2PictureBox2.BackColor = Color.Transparent;
            Guna2PictureBox2.Image = (Image)resources.GetObject("Guna2PictureBox2.Image");
            Guna2PictureBox2.ImageRotate = 0f;
            Guna2PictureBox2.Location = new Point(8, 7);
            Guna2PictureBox2.Name = "Guna2PictureBox2";
            Guna2PictureBox2.ShadowDecoration.Parent = Guna2PictureBox2;
            Guna2PictureBox2.Size = new Size(77, 78);
            Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            Guna2PictureBox2.TabIndex = 0;
            Guna2PictureBox2.TabStop = false;
            Guna2PictureBox2.UseTransparentBackground = true;
            // 
            // Guna2PictureBox13
            // 
            Guna2PictureBox13.BackColor = Color.Transparent;
            Guna2PictureBox13.Image = (Image)resources.GetObject("Guna2PictureBox13.Image");
            Guna2PictureBox13.ImageRotate = 0f;
            Guna2PictureBox13.Location = new Point(-107, 23);
            Guna2PictureBox13.Name = "Guna2PictureBox13";
            Guna2PictureBox13.ShadowDecoration.Parent = Guna2PictureBox13;
            Guna2PictureBox13.Size = new Size(1087, 32);
            Guna2PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            Guna2PictureBox13.TabIndex = 56;
            Guna2PictureBox13.TabStop = false;
            Guna2PictureBox13.UseTransparentBackground = true;
            // 
            // txtSearchHistory
            // 
            txtSearchHistory.Animated = true;
            txtSearchHistory.BorderRadius = 6;
            txtSearchHistory.Cursor = Cursors.IBeam;
            txtSearchHistory.DefaultText = "";
            txtSearchHistory.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchHistory.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchHistory.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchHistory.DisabledState.Parent = txtSearchHistory;
            txtSearchHistory.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchHistory.FillColor = Color.Gainsboro;
            txtSearchHistory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchHistory.FocusedState.Parent = txtSearchHistory;
            txtSearchHistory.Font = new Font("Proxima Nova Rg", 9.749999f);
            txtSearchHistory.ForeColor = Color.Black;
            txtSearchHistory.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchHistory.HoverState.Parent = txtSearchHistory;
            txtSearchHistory.IconLeft = (Image)resources.GetObject("txtSearchHistory.IconLeft");
            txtSearchHistory.IconLeftOffset = new Point(10, 0);
            txtSearchHistory.Location = new Point(12, 13);
            txtSearchHistory.Margin = new Padding(3, 4, 3, 4);
            txtSearchHistory.Name = "txtSearchHistory";
            txtSearchHistory.PasswordChar = '\0';
            txtSearchHistory.PlaceholderForeColor = SystemColors.ControlDark;
            txtSearchHistory.PlaceholderText = "Search by Order Number or Product Name";
            txtSearchHistory.SelectedText = "";
            txtSearchHistory.ShadowDecoration.Parent = txtSearchHistory;
            txtSearchHistory.Size = new Size(885, 43);
            txtSearchHistory.TabIndex = 0;
            txtSearchHistory.TextOffset = new Point(5, 0);
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 683);
            Controls.Add(pnlOrders);
            Controls.Add(flpHistory);
            Controls.Add(txtSearchHistory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            flpHistory.ResumeLayout(false);
            pnlOrderTest.ResumeLayout(false);
            pnlOrderTest.PerformLayout();
            FlowLayoutPanel1.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            pnlOrders.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            flpOrderOverview.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlReOrder.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox13).EndInit();
            Load += new EventHandler(History_Load);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2TextBox txtSearchHistory;
        internal FlowLayoutPanel flpHistory;
        internal Panel pnlOrderTest;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Label Label7;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox13;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Label Label26;
        internal Label Label24;
        internal Label lblGrandTotal;
        internal Label lblAddPlace;
        internal Panel Panel1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse2;
        internal Label Label1;
        internal Label Label22;
        internal Label Label21;
        internal ListBox listOrderNum;
        internal ListBox listItemCount;
        internal Panel pnlOrders;
        internal Panel pnlHeader;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse3;
        internal Guna.UI2.WinForms.Guna2PictureBox btnBack;
        internal Label Label2;
        internal Label lblONum;
        internal Panel pnlReOrder;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse4;
        internal Panel pnlInfo;
        internal Guna.UI2.WinForms.Guna2Button btnBuyAgain;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse5;
        internal Label Label3;
        internal Label lblAddName;
        internal Label lblAddPhone;
        internal Label lblAddFull;
        internal Label lblMessage;
        internal Label Label4;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox3;
        internal FlowLayoutPanel flpOrderOverview;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse6;
        internal Panel Panel2;
        internal Label Label9;
        internal Label Label8;
        internal Label Label6;
        internal Label Label5;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox4;
        internal Label lblPayType;
        internal Label lblOTotal;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox5;
        internal Label Label10;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox8;
        internal Label lblOSubT;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox7;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox6;
        internal Panel Panel3;
        internal Label Label13;
        internal Label Label12;
        internal Label Label11;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox9;
        internal Panel pnlNothing;
        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse7;
    }
}