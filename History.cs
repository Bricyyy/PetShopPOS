using System;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class History
    {
        private string userID;
        private bool flag = false;

        private Panel _pnlItemOrders;

        private Panel pnlItemOrders
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlItemOrders;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _pnlItemOrders = value;
            }
        }
        private Label _lblOrderNum;

        private Label lblOrderNum
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblOrderNum;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblOrderNum = value;
            }
        }
        private Label _lblOrderPlaced;

        private Label lblOrderPlaced
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblOrderPlaced;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblOrderPlaced = value;
            }
        }
        private Label _lblAddress;

        private Label lblAddress
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAddress;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblAddress = value;
            }
        }
        private Label _lblTotalTitle;

        private Label lblTotalTitle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblTotalTitle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblTotalTitle = value;
            }
        }
        private Label _lblPrice;

        private Label lblPrice
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblPrice;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblPrice = value;
            }
        }
        private PictureBox _line1;

        private PictureBox line1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _line1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _line1 = value;
            }
        }
        private PictureBox _line2;

        private PictureBox line2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _line2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _line2 = value;
            }
        }
        private FlowLayoutPanel _flpProducts;

        private FlowLayoutPanel flpProducts
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _flpProducts;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _flpProducts = value;
            }
        }

        private Panel _pnlProductItem;

        private Panel pnlProductItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlProductItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _pnlProductItem = value;
            }
        }
        private PictureBox _itemPic;

        private PictureBox itemPic
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _itemPic;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _itemPic = value;
            }
        }
        private Label _itemName;

        private Label itemName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _itemName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _itemName = value;
            }
        }
        private Label _itemQuan;

        private Label itemQuan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _itemQuan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _itemQuan = value;
            }
        }
        private Label _itemPrice;

        private Label itemPrice
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _itemPrice;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _itemPrice = value;
            }
        }

        private Panel _pnlItemOverview;

        private Panel pnlItemOverview
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlItemOverview;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _pnlItemOverview = value;
            }
        }
        private PictureBox _ItemOverviewPic;

        private PictureBox ItemOverviewPic
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ItemOverviewPic;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ItemOverviewPic = value;
            }
        }
        private Label _lblItemNameOV;

        private Label lblItemNameOV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItemNameOV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblItemNameOV = value;
            }
        }
        private Label _lblItemQuanOV;

        private Label lblItemQuanOV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItemQuanOV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblItemQuanOV = value;
            }
        }
        private Label _lblItemPriceOV;

        private Label lblItemPriceOV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItemPriceOV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblItemPriceOV = value;
            }
        }

        public string passEmail { get; set; }

        public History()
        {
            pnlItemOrders = new Panel();
            lblOrderNum = new Label();
            lblOrderPlaced = new Label();
            lblAddress = new Label();
            lblTotalTitle = new Label();
            lblPrice = new Label();
            line1 = new PictureBox();
            line2 = new PictureBox();
            flpProducts = new FlowLayoutPanel();
            pnlProductItem = new Panel();
            itemPic = new PictureBox();
            itemName = new Label();
            itemQuan = new Label();
            itemPrice = new Label();
            ItemOverviewPic = new PictureBox();
            lblItemNameOV = new Label();
            lblItemQuanOV = new Label();
            lblItemPriceOV = new Label();
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            try
            {
                UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    userID = Conversions.ToString(UniversalVariables.dr.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();

            getOrderNumber();
            getItemCount();
            flpProducts.Controls.Clear();
            loadHistory("Temp");
        }

        private void getOrderNumber()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                if (txtSearchHistory.Text != default)
                {
                    UniversalVariables.sql = "SELECT * FROM usersOrderHistory WHERE uID = '" + userID + "' AND oNum LIKE '%" + txtSearchHistory.Text + "%'";
                    UniversalVariables.connect();
                }
                else
                {
                    UniversalVariables.sql = "SELECT * FROM usersOrderHistory WHERE uID = '" + userID + "' ORDER BY oID DESC";
                    UniversalVariables.connect();
                }

                while (UniversalVariables.dr.Read())
                    listOrderNum.Items.Add(UniversalVariables.dr.GetString("oNum").ToString());
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void getItemCount()
        {
            foreach (string orderNumber in listOrderNum.Items)
            {
                if (UniversalVariables.conn.State == ConnectionState.Open)
                {
                    UniversalVariables.conn.Close();
                }

                try
                {
                    UniversalVariables.sql = "SELECT COUNT(*) FROM usersProdPurchased WHERE oNum = '" + orderNumber + "'";
                    UniversalVariables.connect();

                    if (UniversalVariables.dr.Read())
                    {
                        listItemCount.Items.Add(UniversalVariables.dr.GetValue(0).ToString());
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn.Close();
            }
        }

        private void loadHistory(string search)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                if (txtSearchHistory.Text != default)
                {
                    UniversalVariables.sql = "SELECT * FROM usersOrderHistory WHERE uID = '" + userID + "' AND oNum LIKE '%" + txtSearchHistory.Text + "%'";
                    UniversalVariables.connect();
                }
                else
                {
                    UniversalVariables.sql = "SELECT * FROM usersOrderHistory WHERE uID = '" + userID + "' ORDER BY oID DESC";
                    UniversalVariables.connect();
                }

                while (UniversalVariables.dr.Read())
                {
                    pnlItemOrders = new Panel()
                    {
                        Width = 855,
                        Height = 238,
                        BackColor = Color.White
                    };
                    roundCorners(pnlItemOrders);

                    lblOrderNum = new Label()
                    {
                        Text = "Order #" + UniversalVariables.dr.GetString("oNum").ToString(),
                        Width = 180,
                        Height = 20,
                        ForeColor = Color.Black,
                        Location = new Point(16, 10),
                        Font = new Font("Proxima Nova Lt", 12f, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    lblOrderPlaced = new Label()
                    {
                        Text = "Order Placed: " + UniversalVariables.dr.GetString("orderDateTime").ToString(),
                        Width = 239,
                        Height = 16,
                        ForeColor = SystemColors.ControlDarkDark,
                        Location = new Point(593, 14),
                        Font = new Font("Proxima Nova Rg", 10f, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleRight
                    };

                    lblAddress = new Label()
                    {
                        Text = "Deliver to: " + UniversalVariables.dr.GetString("userFName").ToString() + " " + UniversalVariables.dr.GetString("userPNum").ToString() + " " + UniversalVariables.dr.GetString("userStreet").ToString() + " " + UniversalVariables.dr.GetString("userRegion").ToString() + " " + UniversalVariables.dr.GetString("userPostalCode").ToString(),
                        Width = 632,
                        Height = 16,
                        ForeColor = SystemColors.ControlDarkDark,
                        Location = new Point(17, 198),
                        Font = new Font("Proxima Nova Rg", 10f, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    lblTotalTitle = new Label()
                    {
                        Text = "Order Total: ",
                        Width = 90,
                        Height = 21,
                        ForeColor = Color.Black,
                        Location = new Point(655, 196),
                        Font = new Font("Proxima Nova Rg", 12f, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    lblPrice = new Label()
                    {
                        Text = "₱" + UniversalVariables.dr.GetString("userTotal").ToString(),
                        Width = 88,
                        Height = 27,
                        ForeColor = Color.FromArgb(255, 152, 19),
                        Location = new Point(744, 189),
                        Font = new Font("Proxima Nova Rg", 18f, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleRight
                    };

                    line1 = new PictureBox()
                    {
                        BackgroundImage = My.Resources.Resources.line,
                        Width = 1087,
                        Height = 32,
                        Location = new Point(-107, 23),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    line2 = new PictureBox()
                    {
                        BackgroundImage = My.Resources.Resources.line,
                        Width = 1087,
                        Height = 32,
                        Location = new Point(-108, 157),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Anchor = AnchorStyles.Bottom
                    };

                    flpProducts = new FlowLayoutPanel()
                    {
                        Width = 812,
                        Height = 100,
                        BackColor = Color.White,
                        Location = new Point(20, 55),
                        AutoScroll = true,
                        Visible = true,
                        Tag = UniversalVariables.dr.GetString("oNum").ToString()
                    };

                    pnlItemOrders.Controls.Add(lblOrderNum);
                    pnlItemOrders.Controls.Add(lblOrderPlaced);
                    pnlItemOrders.Controls.Add(lblAddress);
                    pnlItemOrders.Controls.Add(lblTotalTitle);
                    pnlItemOrders.Controls.Add(lblPrice);
                    pnlItemOrders.Controls.Add(line1);
                    pnlItemOrders.Controls.Add(line2);
                    pnlItemOrders.Controls.Add(flpProducts);
                    flpHistory.Controls.Add(pnlItemOrders);

                    flpProducts.Click += flpProducts_Click;
                    flpProducts.Paint += flpProducts_Paint;
                    flpProducts.VisibleChanged += flpProducts_VisibleChanged;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void flpProducts_Paint(object sender, EventArgs e)
        {
            flag = false;
        }

        private void flpProducts_VisibleChanged(object sender, EventArgs e)
        {
            flag = true;
            if (flag == true)
            {
                flpProducts_Click(sender, new EventArgs());
            }
            else
            {
                flag = false;
            }
        }

        private void flpProducts_Click(object sender, EventArgs e)
        {
            sender.visible = (object)true;

            if (flag == true)
            {
                if (UniversalVariables.conn.State == ConnectionState.Open)
                {
                    UniversalVariables.conn.Close();
                }

                try
                {
                    UniversalVariables.sql = "SELECT * FROM usersProdPurchased WHERE uID = '" + userID + "' AND oNum = '" + sender.tag.ToString() + "'";
                    UniversalVariables.connect();

                    while (UniversalVariables.dr.Read())
                    {
                        pnlProductItem = new Panel()
                        {
                            Width = 774,
                            Height = 93,
                            BackColor = Color.White,
                            Tag = UniversalVariables.dr.GetString("oNum").ToString(),
                            Cursor = Cursors.Hand
                        };

                        long len = UniversalVariables.dr.GetBytes(4, 0L, null, 0, 0);
                        var array = new byte[(int)len + 1];
                        UniversalVariables.dr.GetBytes(4, 0L, array, 0, (int)len);
                        itemPic = new PictureBox()
                        {
                            Width = 78,
                            Height = 78,
                            BackgroundImageLayout = ImageLayout.Zoom,
                            Location = new Point(8, 7)
                        };
                        var ms = new System.IO.MemoryStream(array);
                        var bitmap = new Bitmap(ms);
                        itemPic.BackgroundImage = bitmap;

                        itemName = new Label()
                        {
                            Text = UniversalVariables.dr.GetString("prodName").ToString(),
                            Width = 275,
                            Height = 20,
                            ForeColor = Color.Black,
                            Location = new Point(91, 23),
                            Font = new Font("Proxima Nova Rg", 12f, FontStyle.Regular),
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        itemQuan = new Label()
                        {
                            Text = "x" + UniversalVariables.dr.GetString("prodQuan").ToString(),
                            Width = 56,
                            Height = 21,
                            ForeColor = Color.Black,
                            Location = new Point(91, 44),
                            Font = new Font("Proxima Nova Rg", 12f, FontStyle.Regular),
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        itemPrice = new Label()
                        {
                            Text = "₱" + UniversalVariables.dr.GetString("prodPrice").ToString(),
                            Width = 91,
                            Height = 21,
                            ForeColor = Color.Black,
                            Location = new Point(660, 35),
                            Font = new Font("Proxima Nova Rg", 12f, FontStyle.Regular),
                            TextAlign = ContentAlignment.MiddleRight
                        };

                        pnlProductItem.Controls.Add(itemPic);
                        pnlProductItem.Controls.Add(itemName);
                        pnlProductItem.Controls.Add(itemQuan);
                        pnlProductItem.Controls.Add(itemPrice);
                        sender.Controls.Add(pnlProductItem);

                        pnlProductItem.Click += pnlProductItem_Click;
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn.Close();
            }

            flag = false;
        }

        private void loadProducts(string orderNumber)
        {
            lblONum.Text = "Order #" + orderNumber;

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM usersOrderHistory WHERE uID = '" + userID + "' AND oNum = '" + orderNumber + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    lblAddName.Text = UniversalVariables.dr.GetString("userFName").ToString();
                    lblAddPhone.Text = UniversalVariables.dr.GetString("userPNum").ToString();
                    lblAddFull.Text = UniversalVariables.dr.GetString("userStreet").ToString() + " " + UniversalVariables.dr.GetString("userRegion").ToString() + " " + UniversalVariables.dr.GetString("userPostalCode").ToString();

                    if (UniversalVariables.dr.IsDBNull(11))
                    {
                        lblMessage.Text = "(No message left for the seller)";
                    }
                    else
                    {
                        lblMessage.Text = UniversalVariables.dr.GetString("userMessage").ToString();
                    }

                    int subtotal = Conversions.ToInteger(UniversalVariables.dr.GetString("userTotal").ToString()) - 50;
                    lblOSubT.Text = "₱" + subtotal.ToString();
                    lblOTotal.Text = "₱" + UniversalVariables.dr.GetString("userTotal").ToString();

                    if (UniversalVariables.dr.GetString("uPayType").ToString().Equals("Cash"))
                    {
                        lblPayType.Text = "Cash on Delivery";
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM usersProdPurchased WHERE uID = '" + userID + "' AND oNum = '" + orderNumber + "'";
                UniversalVariables.connect();

                while (UniversalVariables.dr.Read())
                {
                    pnlItemOverview = new Panel()
                    {
                        Width = 855,
                        Height = 100,
                        BackColor = Color.WhiteSmoke
                    };

                    long len = UniversalVariables.dr.GetBytes(4, 0L, null, 0, 0);
                    var array = new byte[(int)len + 1];
                    UniversalVariables.dr.GetBytes(4, 0L, array, 0, (int)len);
                    ItemOverviewPic = new PictureBox()
                    {
                        Width = 89,
                        Height = 89,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Location = new Point(20, 12)
                    };
                    var ms = new System.IO.MemoryStream(array);
                    var bitmap = new Bitmap(ms);
                    ItemOverviewPic.BackgroundImage = bitmap;

                    lblItemNameOV = new Label()
                    {
                        Text = UniversalVariables.dr.GetString("prodName").ToString(),
                        Width = 300,
                        Height = 23,
                        ForeColor = Color.Black,
                        Location = new Point(122, 34),
                        Font = new Font("Proxima Nova Rg", 12f, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    lblItemQuanOV = new Label()
                    {
                        Text = "x" + UniversalVariables.dr.GetString("prodQuan").ToString(),
                        Width = 124,
                        Height = 23,
                        ForeColor = Color.Black,
                        Location = new Point(122, 57),
                        Font = new Font("Proxima Nova Rg", 12f, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    lblItemPriceOV = new Label()
                    {
                        Text = "₱" + UniversalVariables.dr.GetString("prodPrice").ToString(),
                        Width = 160,
                        Height = 16,
                        ForeColor = Color.Black,
                        Location = new Point(655, 48),
                        Font = new Font("Proxima Nova Rg", 12f, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleRight
                    };

                    pnlItemOverview.Controls.Add(ItemOverviewPic);
                    pnlItemOverview.Controls.Add(lblItemNameOV);
                    pnlItemOverview.Controls.Add(lblItemQuanOV);
                    pnlItemOverview.Controls.Add(lblItemPriceOV);
                    flpOrderOverview.Controls.Add(pnlItemOverview);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void pnlProductItem_Click(object sender, EventArgs e)
        {
            pnlOrders.Visible = true;
            this.loadProducts(sender.tag.ToString());
        }

        private void roundCorners(Panel pnl)
        {
            var g = new System.Drawing.Drawing2D.GraphicsPath();
            g.StartFigure();

            // Top Left Corner
            g.AddArc(new Rectangle(0, 0, 20, 20), 180f, 90f);
            g.AddLine(20, 0, pnl.Width - 20, 0);

            // Top Right Corner
            g.AddArc(new Rectangle(pnl.Width - 20, 0, 20, 20), -90, 90f);
            g.AddLine(pnl.Width, 20, pnl.Width, pnl.Height - 20);

            // Bottom Right Corner
            g.AddArc(new Rectangle(pnl.Width - 20, pnl.Height - 20, 20, 20), 0f, 90f);
            g.AddLine(pnl.Width - 20, pnl.Height, 20, pnl.Width);

            // Bottom Left Corner
            g.AddArc(new Rectangle(0, pnl.Height - 20, 20, 20), 90f, 90f);
            g.CloseFigure();

            pnl.Region = new Region(g);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlOrders.Visible = false;
            flpOrderOverview.Controls.Clear();
        }

        private void txtSearchHistory_TextChanged(object sender, EventArgs e)
        {
            getOrderNumber();
            getItemCount();
            flpProducts.Controls.Clear();
            flpHistory.Controls.Clear();
            loadHistory(txtSearchHistory.Text);

            if (string.IsNullOrEmpty(txtSearchHistory.Text))
            {
                getOrderNumber();
                getItemCount();
                flpProducts.Controls.Clear();
                flpHistory.Controls.Clear();
                loadHistory("Temp");
            }
        }
    }
}