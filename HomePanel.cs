using System;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class HomePanel
    {
        private string userID;
        private string countPrice;
        private int price;
        private int total;
        private bool flag = false;
        private string orderNum;

        private string userName;
        private string phoneNum;
        private string houseNum;
        private string houseRegion;
        private string houseCode;

        private bool AllLeave = true;
        private bool FoodsLeave = true;
        private bool LeashLeave = true;
        private bool ToiletriesLeave = true;
        private bool MedicineLeave = true;
        private bool CageLeave = true;
        public static bool bTopLevel;

        private PictureBox _pic;

        private PictureBox pic
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pic;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _pic = value;
            }
        }
        private Panel _itemPnl;

        private Panel itemPnl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _itemPnl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _itemPnl = value;
            }
        }
        private Guna.UI2.WinForms.Guna2Button _btnCart;

        private Guna.UI2.WinForms.Guna2Button btnCart
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCart;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _btnCart = value;
            }
        }
        private Label _lblItemName;

        private Label lblItemName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItemName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblItemName = value;
            }
        }
        private Label _lblItemPrice;

        private Label lblItemPrice
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItemPrice;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblItemPrice = value;
            }
        }
        private Label _lblItemQuan;

        private Label lblItemQuan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItemQuan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblItemQuan = value;
            }
        }

        private Panel _cartPnl;

        private Panel cartPnl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cartPnl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cartPnl = value;
            }
        }
        private PictureBox _cartPic;

        private PictureBox cartPic
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cartPic;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cartPic = value;
            }
        }
        private Label _cartProdName;

        private Label cartProdName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cartProdName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cartProdName = value;
            }
        }
        private Label _cartProdPrice;

        private Label cartProdPrice
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cartProdPrice;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cartProdPrice = value;
            }
        }
        private Guna.UI2.WinForms.Guna2NumericUpDown _cartQuan;

        private Guna.UI2.WinForms.Guna2NumericUpDown cartQuan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cartQuan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cartQuan = value;
            }
        }
        private Guna.UI2.WinForms.Guna2Button _removeItem;

        private Guna.UI2.WinForms.Guna2Button removeItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _removeItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _removeItem = value;
            }
        }
        private Label _lblAmount;

        private Label lblAmount
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAmount;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblAmount = value;
            }
        }
        private Label _lblOriginal;

        private Label lblOriginal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblOriginal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblOriginal = value;
            }
        }

        private PictureBox tempPic;
        private PictureBox tempPic1;

        private Panel _pnlCheckoutItem;

        private Panel pnlCheckoutItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlCheckoutItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _pnlCheckoutItem = value;
            }
        }
        private PictureBox _checkoutPic;

        private PictureBox checkoutPic
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkoutPic;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _checkoutPic = value;
            }
        }
        private Label _checkoutIName;

        private Label checkoutIName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkoutIName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _checkoutIName = value;
            }
        }
        private Label _checkoutItemPrice;

        private Label checkoutItemPrice
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkoutItemPrice;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _checkoutItemPrice = value;
            }
        }
        private Label _checkoutItemQuan;

        private Label checkoutItemQuan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkoutItemQuan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _checkoutItemQuan = value;
            }
        }
        private Label _checkoutItemSubT;

        private Label checkoutItemSubT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkoutItemSubT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _checkoutItemSubT = value;
            }
        }

        public string passEmail { get; set; }
        public string passUsername { get; set; }

        public HomePanel()
        {
            pic = new PictureBox();
            itemPnl = new Panel();
            btnCart = new Guna.UI2.WinForms.Guna2Button();
            lblItemName = new Label();
            lblItemPrice = new Label();
            lblItemQuan = new Label();
            cartPnl = new Panel();
            cartPic = new PictureBox();
            cartProdName = new Label();
            cartProdPrice = new Label();
            cartQuan = new Guna.UI2.WinForms.Guna2NumericUpDown();
            removeItem = new Guna.UI2.WinForms.Guna2Button();
            lblAmount = new Label();
            lblOriginal = new Label();
            tempPic = new PictureBox();
            tempPic1 = new PictureBox();
            pnlCheckoutItem = new Panel();
            checkoutPic = new PictureBox();
            checkoutIName = new Label();
            checkoutItemPrice = new Label();
            checkoutItemQuan = new Label();
            checkoutItemSubT = new Label();
            InitializeComponent();
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            if (UniversalVariables.conn1.State == ConnectionState.Open)
            {
                UniversalVariables.conn1.Close();
            }
            UniversalVariables.conn1.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            if (UniversalVariables.conn2.State == ConnectionState.Open)
            {
                UniversalVariables.conn2.Close();
            }
            UniversalVariables.conn2.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            try
            {
                UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    lblUsername.Text = Conversions.ToString(UniversalVariables.dr.GetValue(1));
                    userID = Conversions.ToString(UniversalVariables.dr.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();

            LoadItems("All");
            loadCart();
            getProfilePic();
            loadComboBox();

            btnAll.BorderColor = Color.FromArgb(255, 152, 19);
            btnAll.ForeColor = Color.FromArgb(255, 152, 19);
            AllLeave = false;

            lblItems.Text = "All Items";

            showItemCount("All");
            countAmount();

            restrictionButton();
        }

        private void loadCartID()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userCart WHERE uID = '" + userID + "'";
                UniversalVariables.connect();

                while (UniversalVariables.dr.Read())
                    lstCheckout.Items.Add(UniversalVariables.dr.GetString("cID").ToString());
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void removeItems()
        {
            foreach (string cartID in lstCheckout.Items)
            {
                if (UniversalVariables.conn.State == ConnectionState.Open)
                {
                    UniversalVariables.conn.Close();
                }

                try
                {
                    UniversalVariables.sql = "DELETE FROM userCart WHERE cID = '" + cartID + "'";
                    UniversalVariables.connect();

                    UniversalVariables.dr.Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn.Close();
            }
        }

        private void checkoutItem()
        {
            string itemID;
            byte[] arrimage;
            byte[] arrimage1;
            string itemName;
            string itemPrice;
            string itemQuan;
            string itemSubT;

            string orderTotal = (total + 50).ToString();
            string payMethod = "Cash";
            string datentime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string message = txtMessage.Text;

            string origQuan;
            var newQuan = default(int);

            // Retrieving Default Address
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userAddress WHERE uID = '" + userID + "' AND isDefault = '" + "Yes" + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    userName = UniversalVariables.dr.GetString("userFName").ToString();
                    phoneNum = UniversalVariables.dr.GetString("userPNum").ToString();
                    houseNum = UniversalVariables.dr.GetString("userHouseNum").ToString();
                    houseRegion = UniversalVariables.dr.GetString("userRegion").ToString();
                    houseCode = UniversalVariables.dr.GetString("userPostal").ToString();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
            // End of retrieving address

            // Start of generating order number
            string validchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            var sb = new StringBuilder();
            var rand = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int idx = rand.Next(0, validchars.Length);
                char randomChar = validchars[idx];
                sb.Append(randomChar);
            }

            orderNum = sb.ToString();

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM usersProdPurchased WHERE oNum = '" + orderNum + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        int idx = rand.Next(0, validchars.Length);
                        char randomChar = validchars[idx];
                        sb.Append(randomChar);
                    }

                    orderNum = sb.ToString();
                }
                else
                {
                    UniversalVariables.conn.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
            // End of generating order number

            // Start of retrieving items in cart
            foreach (string item in lstCheckout.Items)
            {
                if (UniversalVariables.conn.State == ConnectionState.Open)
                {
                    UniversalVariables.conn.Close();
                }

                try
                {
                    UniversalVariables.sql = "SELECT * FROM userCart WHERE cID = '" + item + "'";
                    UniversalVariables.connect();

                    if (UniversalVariables.dr.Read())
                    {
                        if (UniversalVariables.conn1.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn1.Close();
                        }

                        try
                        {
                            UniversalVariables.sql1 = "SELECT * FROM storeItems WHERE sID = '" + UniversalVariables.dr.GetString("sID").ToString() + "' AND prodAvail <> 0";
                            UniversalVariables.connectAlt();

                            if (UniversalVariables.dr1.Read())
                            {
                                itemID = UniversalVariables.dr.GetString("sID").ToString();

                                arrimage = (byte[])UniversalVariables.dr["prodPic"];
                                var mstream = new System.IO.MemoryStream(arrimage);
                                tempPic1.Image = Image.FromStream(mstream);

                                var originalImage = tempPic1.Image;
                                uint filesize;
                                var mstream1 = new System.IO.MemoryStream();
                                originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg);
                                arrimage1 = mstream1.GetBuffer();
                                filesize = (uint)mstream1.Length;
                                mstream1.Close();

                                itemName = UniversalVariables.dr.GetString("prodName").ToString();
                                itemPrice = UniversalVariables.dr.GetString("prodPrice").ToString();
                                itemQuan = UniversalVariables.dr.GetString("prodQuan").ToString();
                                itemSubT = UniversalVariables.dr.GetString("prodSubT").ToString();

                                // Start of saving user Purchased Items
                                if (UniversalVariables.conn.State == ConnectionState.Open)
                                {
                                    UniversalVariables.conn.Close();
                                }

                                try
                                {
                                    UniversalVariables.sql = "INSERT INTO usersProdPurchased (uID, oNum, sID, prodPic, prodName, prodPrice, prodQuan, prodSubT) VALUES (@uID, @oNum, @sID, @prodPic, @prodName, @prodPrice, @prodQuan, @prodSubT)";
                                    {
                                        ref var withBlock = ref UniversalVariables.cmd;
                                        withBlock.Parameters.Clear();
                                        withBlock.Parameters.AddWithValue("@uID", userID);
                                        withBlock.Parameters.Add("@oNum", MySqlDbType.VarChar).Value = orderNum;
                                        withBlock.Parameters.Add("@sID", MySqlDbType.VarChar).Value = itemID;
                                        withBlock.Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1;
                                        withBlock.Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName;
                                        withBlock.Parameters.Add("@prodPrice", MySqlDbType.Int32).Value = itemPrice;
                                        withBlock.Parameters.Add("@prodQuan", MySqlDbType.VarChar).Value = itemQuan;
                                        withBlock.Parameters.Add("@prodSubT", MySqlDbType.VarChar).Value = itemSubT;
                                    }
                                    UniversalVariables.connect();

                                    flag = true;
                                }
                                catch (Exception ex)
                                {
                                    Interaction.MsgBox(ex.Message);
                                }
                                UniversalVariables.conn.Close();
                                // End of saving user Purchased Items
                            }
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox(ex.Message);
                        }
                        UniversalVariables.conn1.Close();
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn.Close();
            }
            // End of retrieving items in cart

            // Start of saving user Order to History
            foreach (string item in lstCheckout.Items)
            {
                if (UniversalVariables.conn1.State == ConnectionState.Open)
                {
                    UniversalVariables.conn1.Close();
                }

                try
                {
                    UniversalVariables.sql1 = "SELECT * FROM userCart WHERE cID = '" + item + "'";
                    UniversalVariables.connectAlt();

                    if (UniversalVariables.dr1.Read())
                    {
                        if (UniversalVariables.conn2.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn2.Close();
                        }

                        try
                        {
                            UniversalVariables.sql2 = "SELECT * FROM storeItems WHERE sID = '" + UniversalVariables.dr1.GetString("sID").ToString() + "' AND prodAvail <> 0";
                            UniversalVariables.connectAgain();

                            if (UniversalVariables.dr2.Read())
                            {
                                if (UniversalVariables.conn.State == ConnectionState.Open)
                                {
                                    UniversalVariables.conn.Close();
                                }

                                try
                                {
                                    if (string.IsNullOrEmpty(txtMessage.Text))
                                    {
                                        UniversalVariables.sql = "INSERT INTO usersOrderHistory (uID, oNum, userTotal, uPayType, orderDateTime, userFName, userPNum, userStreet, userRegion, userPostalCode) VALUES (@uID, @oNum, @userTotal, @uPayType, @orderDateTime, @userFName, @userPNum, @userStreet, @userRegion, @userPostalCode)";
                                        {
                                            ref var withBlock1 = ref UniversalVariables.cmd;
                                            withBlock1.Parameters.Clear();
                                            withBlock1.Parameters.AddWithValue("@uID", userID);
                                            withBlock1.Parameters.Add("@oNum", MySqlDbType.VarChar).Value = orderNum;
                                            withBlock1.Parameters.Add("@userTotal", MySqlDbType.VarChar).Value = orderTotal;
                                            withBlock1.Parameters.Add("@uPayType", MySqlDbType.VarChar).Value = payMethod;
                                            withBlock1.Parameters.Add("@orderDateTime", MySqlDbType.VarChar).Value = datentime;
                                            withBlock1.Parameters.Add("@userFName", MySqlDbType.VarChar).Value = userName;
                                            withBlock1.Parameters.Add("@userPNum", MySqlDbType.VarChar).Value = phoneNum;
                                            withBlock1.Parameters.Add("@userStreet", MySqlDbType.VarChar).Value = houseNum;
                                            withBlock1.Parameters.Add("@userRegion", MySqlDbType.VarChar).Value = houseRegion;
                                            withBlock1.Parameters.Add("@userPostalCode", MySqlDbType.VarChar).Value = houseCode;
                                        }
                                        UniversalVariables.connect();
                                    }
                                    else
                                    {
                                        UniversalVariables.sql = "INSERT INTO usersOrderHistory (uID, oNum, userTotal, uPayType, orderDateTime, userFName, userPNum, userStreet, userRegion, userPostalCode, userMessage) VALUES (@uID, @oNum, @userTotal, @uPayType, @orderDateTime, @userFName, @userPNum, @userStreet, @userRegion, @userPostalCode, @userMessage)";
                                        {
                                            ref var withBlock2 = ref UniversalVariables.cmd;
                                            withBlock2.Parameters.Clear();
                                            withBlock2.Parameters.AddWithValue("@uID", userID);
                                            withBlock2.Parameters.Add("@oNum", MySqlDbType.VarChar).Value = orderNum;
                                            withBlock2.Parameters.Add("@userTotal", MySqlDbType.VarChar).Value = orderTotal;
                                            withBlock2.Parameters.Add("@uPayType", MySqlDbType.VarChar).Value = payMethod;
                                            withBlock2.Parameters.Add("@orderDateTime", MySqlDbType.VarChar).Value = datentime;
                                            withBlock2.Parameters.Add("@userFName", MySqlDbType.VarChar).Value = userName;
                                            withBlock2.Parameters.Add("@userPNum", MySqlDbType.VarChar).Value = phoneNum;
                                            withBlock2.Parameters.Add("@userStreet", MySqlDbType.VarChar).Value = houseNum;
                                            withBlock2.Parameters.Add("@userRegion", MySqlDbType.VarChar).Value = houseRegion;
                                            withBlock2.Parameters.Add("@userPostalCode", MySqlDbType.VarChar).Value = houseCode;
                                            withBlock2.Parameters.Add("@userMessage", MySqlDbType.VarChar).Value = message;
                                        }
                                        UniversalVariables.connect();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Interaction.MsgBox(ex.Message);
                                }
                                UniversalVariables.conn.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox(ex.Message);
                        }
                        UniversalVariables.conn2.Close();
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn1.Close();
            }
            // End of saving user Order to History

            // Getting the items to be checked out
            foreach (string item in lstCheckout.Items)
            {
                if (UniversalVariables.conn.State == ConnectionState.Open)
                {
                    UniversalVariables.conn.Close();
                }

                try
                {
                    UniversalVariables.sql = "SELECT * FROM userCart WHERE cID = '" + item + "'";
                    UniversalVariables.connect();

                    if (UniversalVariables.dr.Read())
                    {
                        itemID = UniversalVariables.dr.GetString("sID").ToString();
                        itemQuan = UniversalVariables.dr.GetString("prodQuan").ToString();

                        // Getting and reducing the original amount of item
                        if (UniversalVariables.conn.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn.Close();
                        }

                        try
                        {
                            UniversalVariables.sql = "SELECT * FROM storeItems WHERE sID = '" + itemID + "' AND prodAvail <> 0";
                            UniversalVariables.connect();

                            if (UniversalVariables.dr.Read())
                            {
                                origQuan = UniversalVariables.dr.GetString("prodAvail").ToString();

                                newQuan = Conversions.ToInteger(origQuan) - Conversions.ToInteger(itemQuan);
                            }
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox(ex.Message);
                        }
                        UniversalVariables.conn.Close();
                        // End of getting and reducing the original amount of item

                        // Setting the new quantity of bought item
                        if (UniversalVariables.conn.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn.Close();
                        }

                        try
                        {
                            UniversalVariables.sql = "UPDATE storeItems SET prodAvail = '" + newQuan + "' WHERE sID = '" + itemID + "' AND prodAvail <> 0";
                            UniversalVariables.connect();

                            UniversalVariables.dr.Close();

                            if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                            {
                                UniversalVariables.conn.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox(ex.Message);
                        }
                        UniversalVariables.conn.Close();
                        // End of setting the new quantity of bought item
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn.Close();
            }
            // End of getting the items to be checked out
        }

        private void restrictionButton()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userCart WHERE uID = '" + userID + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    btnProceed.Enabled = true;
                    pnlCartCheck.Visible = false;
                }
                else
                {
                    pnlCartCheck.Visible = true;
                    btnProceed.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void getAddress()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userAddress WHERE uID = '" + userID + "' AND isDefault = '" + "Yes" + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    lblAddName.Text = UniversalVariables.dr.GetString("userFName").ToString() + " " + UniversalVariables.dr.GetString("userPNum").ToString();
                    lblAddPlace.Text = UniversalVariables.dr.GetString("userHouseNum").ToString() + ", " + UniversalVariables.dr.GetString("userRegion").ToString() + " " + UniversalVariables.dr.GetString("userPostal");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void loadCheckout()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userCart WHERE uID = '" + userID + "'";
                UniversalVariables.connect();

                while (UniversalVariables.dr.Read())
                {
                    if (UniversalVariables.conn1.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn1.Close();
                    }

                    UniversalVariables.sql1 = "SELECT * FROM storeItems WHERE sID = '" + UniversalVariables.dr.GetString("sID").ToString() + "' AND prodAvail <> 0";
                    UniversalVariables.connectAlt();

                    if (UniversalVariables.dr1.Read())
                    {
                        pnlCheckoutItem = new Panel()
                        {
                            Width = 820,
                            Height = 73,
                            BackColor = Color.White
                        };

                        long len = UniversalVariables.dr.GetBytes(3, 0L, null, 0, 0);
                        var array = new byte[(int)len + 1];
                        UniversalVariables.dr.GetBytes(3, 0L, array, 0, (int)len);
                        checkoutPic = new PictureBox()
                        {
                            Width = 55,
                            Height = 55,
                            BackgroundImageLayout = ImageLayout.Zoom,
                            Location = new Point(21, 8)
                        };
                        var ms = new System.IO.MemoryStream(array);
                        var bitmap = new Bitmap(ms);
                        checkoutPic.BackgroundImage = bitmap;

                        checkoutIName = new Label()
                        {
                            Text = UniversalVariables.dr.GetString("prodName").ToString(),
                            Font = new Font("Segoe UI", 12f, FontStyle.Regular),
                            Width = 276,
                            Height = 21,
                            ForeColor = Color.Black,
                            BackColor = Color.Transparent,
                            Location = new Point(95, 24)
                        };

                        checkoutItemPrice = new Label()
                        {
                            Text = "₱" + UniversalVariables.dr.GetString("prodPrice").ToString(),
                            Font = new Font("Segoe UI", 12f, FontStyle.Regular),
                            Width = 69,
                            Height = 21,
                            ForeColor = Color.Black,
                            BackColor = Color.Transparent,
                            Location = new Point(400, 24),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        checkoutItemQuan = new Label()
                        {
                            Text = UniversalVariables.dr.GetString("prodQuan").ToString(),
                            Font = new Font("Segoe UI", 12f, FontStyle.Regular),
                            Width = 56,
                            Height = 21,
                            ForeColor = Color.Black,
                            BackColor = Color.Transparent,
                            Location = new Point(525, 24),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        checkoutItemSubT = new Label()
                        {
                            Text = "₱" + UniversalVariables.dr.GetString("prodSubT").ToString(),
                            Font = new Font("Segoe UI", 12f, FontStyle.Regular),
                            Width = 91,
                            Height = 21,
                            ForeColor = Color.Black,
                            BackColor = Color.Transparent,
                            Location = new Point(724, 24),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        pnlCheckoutItem.Controls.Add(checkoutPic);
                        pnlCheckoutItem.Controls.Add(checkoutIName);
                        pnlCheckoutItem.Controls.Add(checkoutItemPrice);
                        pnlCheckoutItem.Controls.Add(checkoutItemQuan);
                        pnlCheckoutItem.Controls.Add(checkoutItemSubT);
                        flpCheckoutCart.Controls.Add(pnlCheckoutItem);

                        checkoutLstBox.Items.Add(Conversions.ToInteger(UniversalVariables.dr.GetString("prodSubT").ToString()));
                    }
                    UniversalVariables.conn1.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void countCheckout()
        {
            foreach (string price in checkoutLstBox.Items)
                total += Conversions.ToInteger(price);
            lblItemTotal.Text = "₱" + total;
            lblMerch.Text = "₱" + total;
            lblGrandTotal.Text = "₱" + (total + 50);
        }

        private void countAmount()
        {
            foreach (string amount in lstPrices.Items)
                price += Conversions.ToInteger(amount);
            lblSubT.Text = "₱" + price;
            lblTotal.Text = "₱" + (price + 50);
        }

        private void countCart()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT COUNT(*) FROM userCart WHERE uID = '" + userID + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    lblCartCount.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Order Total (", UniversalVariables.dr.GetValue(0)), " Item/s):"));
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void loadCart()
        {
            lstPrices.Items.Clear();

            string itemQuantity;

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userCart";
                UniversalVariables.connect();

                while (UniversalVariables.dr.Read())
                {
                    if (UniversalVariables.conn1.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn1.Close();
                    }

                    try
                    {
                        UniversalVariables.sql1 = "SELECT * FROM storeItems WHERE sID = '" + UniversalVariables.dr.GetString("sID").ToString() + "'";
                        UniversalVariables.connectAlt();

                        if (!UniversalVariables.dr1.Read())
                        {
                            if (UniversalVariables.conn2.State == ConnectionState.Open)
                            {
                                UniversalVariables.conn2.Close();
                            }

                            try
                            {
                                UniversalVariables.sql2 = "DELETE FROM userCart WHERE cID = '" + UniversalVariables.dr.GetString("cID").ToString() + "'";
                                UniversalVariables.connectAgain();

                                UniversalVariables.dr2.Close();
                            }
                            catch (Exception ex)
                            {
                                Interaction.MsgBox(ex.Message);
                            }
                            UniversalVariables.conn2.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message);
                    }
                    UniversalVariables.conn1.Close();
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
                UniversalVariables.sql = "DELETE FROM userCart WHERE sID IN (SELECT (sID) FROM storeItems WHERE prodAvail = 0)";
                UniversalVariables.connect();

                UniversalVariables.dr.Close();
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
                UniversalVariables.sql = "SELECT * FROM userCart WHERE uID = '" + userID + "' AND cID IN (SELECT (cID) FROM userCart WHERE uID = '" + userID + "')";
                UniversalVariables.connect();

                while (UniversalVariables.dr.Read())
                {
                    if (UniversalVariables.conn2.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn2.Close();
                    }

                    UniversalVariables.sql2 = "SELECT * FROM storeItems WHERE sID = '" + UniversalVariables.dr.GetString("sID").ToString() + "' AND prodAvail <> 0";
                    UniversalVariables.connectAgain();

                    if (UniversalVariables.dr2.Read())
                    {
                        cartPnl = new Panel()
                        {
                            Width = 200,
                            Height = 91,
                            BackColor = Color.White
                        };

                        long len = UniversalVariables.dr.GetBytes(3, 0L, null, 0, 0);
                        var array = new byte[(int)len + 1];
                        UniversalVariables.dr.GetBytes(3, 0L, array, 0, (int)len);
                        cartPic = new PictureBox()
                        {
                            Width = 52,
                            Height = 85,
                            BackgroundImageLayout = ImageLayout.Zoom,
                            Location = new Point(7, 3)
                        };
                        var ms = new System.IO.MemoryStream(array);
                        var bitmap = new Bitmap(ms);
                        cartPic.BackgroundImage = bitmap;

                        cartProdName = new Label()
                        {
                            Text = UniversalVariables.dr.GetString("prodName").ToString(),
                            Font = new Font("Proxima Nova Rg", 10f, FontStyle.Regular),
                            Width = 115,
                            Height = 35,
                            ForeColor = Color.Black,
                            BackColor = Color.Transparent,
                            Location = new Point(61, 8)
                        };
                        cartProdName.SendToBack();

                        lblOriginal = new Label()
                        {
                            Text = "₱" + UniversalVariables.dr.GetString("prodPrice").ToString(),
                            Font = new Font("Proxima Nova Rg", 9f, FontStyle.Regular),
                            Width = 35,
                            Height = 18,
                            ForeColor = Color.Black,
                            BackColor = Color.Transparent,
                            Location = new Point(110, 55)
                        };

                        if (UniversalVariables.dr.IsDBNull(7))
                        {
                            countPrice = UniversalVariables.dr.GetString("prodPrice").ToString();
                            cartProdPrice = new Label()
                            {
                                Text = "₱" + countPrice,
                                Font = new Font("Proxima Nova Lt", 11f, FontStyle.Bold),
                                Width = 64,
                                Height = 18,
                                TextAlign = ContentAlignment.MiddleRight,
                                ForeColor = Color.Black,
                                Location = new Point(140, 59),
                                Tag = UniversalVariables.dr.GetString("sID")
                            };
                        }
                        else
                        {
                            countPrice = UniversalVariables.dr.GetString("prodSubT").ToString();
                            cartProdPrice = new Label()
                            {
                                Text = "₱" + countPrice,
                                Font = new Font("Proxima Nova Lt", 11f, FontStyle.Bold),
                                Width = 64,
                                Height = 18,
                                TextAlign = ContentAlignment.MiddleRight,
                                ForeColor = Color.Black,
                                Location = new Point(140, 59),
                                Tag = UniversalVariables.dr.GetString("sID")
                            };
                        }

                        if (UniversalVariables.conn1.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn1.Close();
                        }

                        UniversalVariables.sql1 = "SELECT * FROM storeItems WHERE sID = '" + UniversalVariables.dr.GetString("sID").ToString() + "'";
                        UniversalVariables.connectAlt();

                        if (UniversalVariables.dr1.Read())
                        {
                            itemQuantity = UniversalVariables.dr1.GetString("prodAvail").ToString();

                            if (UniversalVariables.dr.IsDBNull(6))
                            {
                                cartQuan = new Guna.UI2.WinForms.Guna2NumericUpDown()
                                {
                                    Value = 1m,
                                    Font = new Font("Proxima Nova Rg", 9f, FontStyle.Regular),
                                    UseTransparentBackground = true,
                                    Width = 45,
                                    Height = 29,
                                    UpDownButtonFillColor = Color.White,
                                    Location = new Point(64, 48),
                                    Tag = UniversalVariables.dr.GetString("sID")
                                };
                                cartQuan.Minimum = 1m;
                                cartQuan.Maximum = Conversions.ToInteger(itemQuantity);
                            }
                            else
                            {
                                cartQuan = new Guna.UI2.WinForms.Guna2NumericUpDown()
                                {
                                    Value = Convert.ToInt32(Convert.ToDecimal(UniversalVariables.dr.GetString("prodQuan"))),
                                    Font = new Font("Proxima Nova Rg", 9f, FontStyle.Regular),
                                    UseTransparentBackground = true,
                                    Width = 45,
                                    Height = 29,
                                    UpDownButtonFillColor = Color.White,
                                    Location = new Point(64, 48),
                                    Tag = UniversalVariables.dr.GetString("sID")
                                };
                                cartQuan.Minimum = 1m;
                                cartQuan.Maximum = Conversions.ToInteger(itemQuantity);
                            }
                        }
                        UniversalVariables.conn1.Close();

                        removeItem = new Guna.UI2.WinForms.Guna2Button()
                        {
                            Width = 10,
                            Height = 10,
                            Animated = true,
                            UseTransparentBackground = true,
                            FillColor = Color.Transparent,
                            Location = new Point(190, 11),
                            BackgroundImage = My.Resources.Resources.xIcon3,
                            BackgroundImageLayout = ImageLayout.Zoom,
                            Cursor = Cursors.Hand,
                            Tag = UniversalVariables.dr.GetString("cID")
                        };
                        removeItem.BringToFront();

                        lblAmount = new Label()
                        {
                            Text = "Total",
                            Font = new Font("Proxima Nova Rg", 10f, FontStyle.Regular),
                            Width = 36,
                            Height = 16,
                            ForeColor = Color.Black,
                            BackColor = Color.Transparent,
                            Location = new Point(167, 43)
                        };

                        cartPnl.Controls.Add(cartPic);
                        cartPnl.Controls.Add(cartProdName);
                        cartPnl.Controls.Add(lblOriginal);
                        cartPnl.Controls.Add(cartProdPrice);
                        cartPnl.Controls.Add(cartQuan);
                        cartPnl.Controls.Add(removeItem);
                        cartPnl.Controls.Add(lblAmount);
                        flpCart.Controls.Add(cartPnl);

                        lstPrices.Items.Add(countPrice);

                        cartQuan.ValueChanged += cartQuan_ValueChanged;
                        removeItem.Click += removeItem_Click;
                    }
                    UniversalVariables.conn2.Close();
                }
                UniversalVariables.dr.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            price = 0;

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "DELETE FROM userCart WHERE cID = '" + sender.tag.ToString() + "'";
                UniversalVariables.connect();

                UniversalVariables.dr.Close();

                flpCart.Controls.Clear();
                loadCart();
                countAmount();
                restrictionButton();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void cartQuan_ValueChanged(object sender, EventArgs e)
        {
            price = 0;

            string productID = sender.tag.ToString();

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            try
            {
                UniversalVariables.sql = "SELECT * FROM storeItems WHERE sID = '" + productID + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    string subtotal = UniversalVariables.dr.GetString("prodPrice");
                    int quantity = Conversions.ToInteger(sender.Value);
                    int total;
                    total = (int)Math.Round(Conversions.ToDouble(subtotal) * quantity);

                    if (UniversalVariables.conn.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn.Close();
                    }

                    UniversalVariables.sql = "SELECT * FROM userCart WHERE uID = '" + userID + "' AND sID = '" + productID + "'";
                    UniversalVariables.connect();

                    if (UniversalVariables.dr.Read())
                    {
                        string cartID = UniversalVariables.dr.GetString("cID").ToString();

                        if (UniversalVariables.conn.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn.Close();
                        }

                        UniversalVariables.sql = "UPDATE userCart SET prodQuan = '" + sender.Value.ToString() + "', prodSubT = '" + total + "' WHERE cID = '" + cartID + "'";
                        UniversalVariables.connect();

                        UniversalVariables.dr.Close();

                        if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                        {
                            flpCart.Controls.Clear();
                            loadCart();
                            countAmount();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void loadComboBox()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userAddress WHERE uID = '" + userID + "' AND isDefault = '" + "Yes" + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    cmbAddress.Items.Insert(0, UniversalVariables.dr.GetString("userHouseNum") + " " + UniversalVariables.dr.GetString("userRegion"));
                }
                UniversalVariables.conn.Close();

                UniversalVariables.sql = "SELECT * FROM userAddress WHERE uID = '" + userID + "' AND isDefault = '" + "No" + "'";
                UniversalVariables.connect();

                while (UniversalVariables.dr.Read())
                    cmbAddress.Items.Add(UniversalVariables.dr.GetString("userHouseNum") + " " + UniversalVariables.dr.GetString("userRegion"));

                cmbAddress.StartIndex = 0;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void LoadItems(string itemType)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                if (txtSearch.Text != default)
                {
                    UniversalVariables.sql = "SELECT * FROM storeItems WHERE prodName LIKE '%" + itemType + "%' ORDER BY prodAvail DESC";
                    UniversalVariables.connect();
                }
                else if (itemType.Equals("All"))
                {
                    UniversalVariables.sql = "SELECT * FROM storeItems ORDER BY prodAvail DESC";
                    UniversalVariables.connect();
                }
                else
                {
                    UniversalVariables.sql = "SELECT * FROM storeItems WHERE prodCat = '" + itemType + "' ORDER BY prodAvail DESC";
                    UniversalVariables.connect();
                }

                while (UniversalVariables.dr.Read())
                {
                    int prodQuantity = Conversions.ToInteger(UniversalVariables.dr.GetString("prodAvail").ToString());

                    long len = UniversalVariables.dr.GetBytes(1, 0L, null, 0, 0);
                    var array = new byte[(int)len + 1];
                    UniversalVariables.dr.GetBytes(1, 0L, array, 0, (int)len);

                    itemPnl = new Panel()
                    {
                        Width = 275,
                        Height = 230,
                        BackColor = Color.White
                    };
                    roundCorners(itemPnl);

                    pic = new PictureBox()
                    {
                        Width = 137,
                        Height = 131,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Anchor = AnchorStyles.Left,
                        Location = new Point(14, 14)
                    };
                    var ms = new System.IO.MemoryStream(array);
                    var bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;

                    btnCart = new Guna.UI2.WinForms.Guna2Button()
                    {
                        Width = 195,
                        Height = 48,
                        FillColor = Color.FromArgb(255, 152, 19),
                        BorderRadius = 6,
                        Location = new Point(44, 156),
                        Font = new Font("Proxima Nova Lt", 12f, FontStyle.Bold),
                        Cursor = Cursors.Hand,
                        Animated = true,
                        Tag = UniversalVariables.dr["sID"].ToString()
                    };
                    if (prodQuantity == 0)
                    {
                        btnCart.Text = "Item Unavailable";
                        btnCart.Enabled = false;
                    }
                    else
                    {
                        btnCart.Text = "Add to Cart";
                        btnCart.Enabled = true;
                    }

                    lblItemName = new Label()
                    {
                        Text = UniversalVariables.dr.GetString("prodName").ToString(),
                        Width = 104,
                        Height = 62,
                        ForeColor = Color.Black,
                        Location = new Point(150, 10),
                        Font = new Font("Proxima Nova Lt", 12f, FontStyle.Bold)
                    };

                    lblItemPrice = new Label()
                    {
                        Text = "₱" + UniversalVariables.dr.GetString("prodPrice").ToString(),
                        Width = 134,
                        Height = 21,
                        ForeColor = Color.Black,
                        Location = new Point(150, 100),
                        Font = new Font("Proxima Nova Lt", 12f, FontStyle.Bold)
                    };

                    if (prodQuantity >= 1 & prodQuantity <= 10)
                    {
                        lblItemQuan = new Label()
                        {
                            Text = "(" + UniversalVariables.dr.GetString("prodAvail").ToString() + " item/s left)",
                            Width = 134,
                            Height = 21,
                            ForeColor = Color.Black,
                            Location = new Point(150, 80),
                            Font = new Font("Proxima Nova Lt", 10f, FontStyle.Bold),
                            Visible = true
                        };
                    }
                    else
                    {
                        lblItemQuan = new Label()
                        {
                            Text = "",
                            Width = 134,
                            Height = 21,
                            ForeColor = Color.Black,
                            Location = new Point(150, 80),
                            Font = new Font("Proxima Nova Lt", 10f, FontStyle.Bold),
                            Visible = false
                        };
                    }

                    itemPnl.Controls.Add(lblItemPrice);
                    itemPnl.Controls.Add(lblItemQuan);
                    itemPnl.Controls.Add(lblItemName);
                    itemPnl.Controls.Add(pic);
                    itemPnl.Controls.Add(btnCart);
                    flpOrder.Controls.Add(itemPnl);

                    btnCart.Click += btnCart_Click;
                }

                UniversalVariables.dr.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM storeItems WHERE sID = '" + sender.tag.ToString() + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    string itemID = UniversalVariables.dr.GetString("sID");
                    byte[] arrimage;
                    arrimage = (byte[])UniversalVariables.dr["prodPic"];
                    var mstream = new System.IO.MemoryStream(arrimage);
                    tempPic.Image = Image.FromStream(mstream);

                    var originalImage = tempPic.Image;
                    uint filesize;
                    var mstream1 = new System.IO.MemoryStream();
                    originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrimage1 = mstream1.GetBuffer();
                    filesize = (uint)mstream1.Length;
                    mstream1.Close();

                    string itemName = UniversalVariables.dr.GetString("prodName").ToString();
                    string itemPrice = UniversalVariables.dr.GetString("prodPrice").ToString();
                    string itemCount = "1";
                    int itemAvailability = Conversions.ToInteger(UniversalVariables.dr.GetString("prodAvail").ToString());

                    if (UniversalVariables.conn.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn.Close();
                    }

                    try
                    {
                        UniversalVariables.sql = "SELECT * FROM userCart WHERE sID = '" + itemID + "' AND uID = '" + userID + "'";
                        UniversalVariables.connect();

                        if (UniversalVariables.dr.Read())
                        {
                            string quantity;
                            int changeQuan;
                            if (UniversalVariables.dr.IsDBNull(6))
                            {
                                quantity = "1";
                                changeQuan = 1 + Conversions.ToInteger(quantity);
                            }
                            else
                            {
                                quantity = UniversalVariables.dr.GetString("prodQuan").ToString();
                                changeQuan = 1 + Conversions.ToInteger(quantity);
                            }

                            string quanSubT;
                            int totalSubT;
                            if (UniversalVariables.dr.IsDBNull(7))
                            {
                                quanSubT = itemPrice;
                                totalSubT = Conversions.ToInteger(quanSubT) + Conversions.ToInteger(itemPrice);
                            }
                            else
                            {
                                quanSubT = UniversalVariables.dr.GetString("prodSubT").ToString();
                                totalSubT = Conversions.ToInteger(quanSubT) + Conversions.ToInteger(itemPrice);
                            }

                            if (UniversalVariables.conn2.State == ConnectionState.Open)
                            {
                                UniversalVariables.conn2.Close();
                            }

                            try
                            {
                                UniversalVariables.sql2 = "SELECT * FROM userCart WHERE sID = '" + itemID + "' AND uID = '" + userID + "'";
                                UniversalVariables.connectAgain();

                                if (UniversalVariables.dr2.Read())
                                {
                                    int itemInCartQuan = Conversions.ToInteger(UniversalVariables.dr.GetString("prodQuan").ToString());

                                    if (!itemAvailability.Equals(itemInCartQuan))
                                    {
                                        if (UniversalVariables.conn1.State == ConnectionState.Open)
                                        {
                                            UniversalVariables.conn1.Close();
                                        }

                                        UniversalVariables.sql1 = "SELECT * FROM storeItems WHERE sID = '" + itemID + "'";
                                        UniversalVariables.connectAlt();

                                        if (UniversalVariables.dr1.Read())
                                        {
                                            if (UniversalVariables.conn.State == ConnectionState.Open)
                                            {
                                                UniversalVariables.conn.Close();
                                            }

                                            try
                                            {
                                                UniversalVariables.sql = "UPDATE userCart SET prodQuan = '" + changeQuan.ToString() + "', prodSubT = '" + totalSubT + "' WHERE uID = '" + userID + "' AND sID = '" + itemID + "'";
                                                UniversalVariables.connect();

                                                UniversalVariables.dr.Close();

                                                if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                                                {
                                                    price = 0;
                                                    flpCart.Controls.Clear();
                                                    loadCart();
                                                    countAmount();
                                                    restrictionButton();
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                Interaction.MsgBox(ex.Message);
                                            }
                                            UniversalVariables.conn.Close();
                                        }
                                        UniversalVariables.conn1.Close();
                                    }
                                    else
                                    {
                                        UniversalVariables.conn2.Close();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Interaction.MsgBox(ex.Message);
                            }
                            UniversalVariables.conn2.Close();
                        }
                        else
                        {
                            if (UniversalVariables.conn.State == ConnectionState.Open)
                            {
                                UniversalVariables.conn.Close();
                            }

                            try
                            {
                                UniversalVariables.sql = "INSERT INTO userCart (uID, sID, prodPic, prodName, prodPrice, prodQuan, prodSubT) VALUES (@uID, @sID, @prodPic, @prodName, @prodPrice, @prodQuan, @prodSubT)";
                                {
                                    ref var withBlock = ref UniversalVariables.cmd;
                                    withBlock.Parameters.Clear();
                                    withBlock.Parameters.Add("@uID", MySqlDbType.VarChar).Value = userID;
                                    withBlock.Parameters.Add("@sID", MySqlDbType.VarChar).Value = itemID;
                                    withBlock.Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1;
                                    withBlock.Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName;
                                    withBlock.Parameters.Add("@prodPrice", MySqlDbType.VarChar).Value = itemPrice;
                                    withBlock.Parameters.Add("@prodQuan", MySqlDbType.VarChar).Value = itemCount;
                                    withBlock.Parameters.Add("@prodSubT", MySqlDbType.VarChar).Value = itemPrice;
                                }
                                UniversalVariables.connect();

                                price = 0;
                                flpCart.Controls.Clear();
                                loadCart();
                                countAmount();
                                restrictionButton();
                            }
                            catch (Exception ex)
                            {
                                Interaction.MsgBox(ex.Message);
                            }
                            UniversalVariables.conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message);
                    }
                    UniversalVariables.conn.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void showItemCount(string prodType)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            if (prodType.Equals("All"))
            {
                try
                {
                    UniversalVariables.sql = "SELECT COUNT(*) FROM storeItems";
                    UniversalVariables.connect();

                    if (UniversalVariables.dr.Read())
                    {
                        lblItemCount.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(UniversalVariables.dr.GetValue(0), " "), prodType), " Result"));
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
            }
            else if (txtSearch.Text != default)
            {
                try
                {
                    UniversalVariables.sql = "SELECT COUNT(*) FROM storeItems WHERE prodName LIKE '%" + prodType + "%'";
                    UniversalVariables.connect();

                    if (UniversalVariables.dr.Read())
                    {
                        lblItemCount.Text = Conversions.ToString(Operators.ConcatenateObject(UniversalVariables.dr.GetValue(0), " Search Result"));
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
            }
            else
            {
                try
                {
                    UniversalVariables.sql = "SELECT COUNT(*) FROM storeItems WHERE prodCat = '" + prodType + "'";
                    UniversalVariables.connect();

                    if (UniversalVariables.dr.Read())
                    {
                        lblItemCount.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(UniversalVariables.dr.GetValue(0), " "), prodType), " Result"));
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
            }
        }

        private void getProfilePic()
        {
            byte[] arrimage;

            try
            {
                UniversalVariables.sql = "SELECT userPic FROM userProfile WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    arrimage = (byte[])UniversalVariables.dr["userPic"];
                    var mstream = new System.IO.MemoryStream(arrimage);
                    picProfile.Image = Image.FromStream(mstream);
                }
                else if (UniversalVariables.dr.IsDBNull(4))
                {
                    UniversalVariables.conn.Close();
                }
            }
            catch (Exception ex)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.Close();
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

        private void Guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            btnAll.BorderColor = Color.FromArgb(255, 152, 19);
            btnAll.ForeColor = Color.FromArgb(255, 152, 19);
        }

        private void btnFoods_MouseEnter(object sender, EventArgs e)
        {
            btnFoods.BorderColor = Color.FromArgb(255, 152, 19);
            btnFoods.ForeColor = Color.FromArgb(255, 152, 19);
        }

        private void btnAll_MouseLeave(object sender, EventArgs e)
        {
            if (AllLeave)
            {
                btnAll.BorderColor = Color.LightGray;
                btnAll.ForeColor = Color.Black;
            }
        }

        private void btnFoods_MouseLeave(object sender, EventArgs e)
        {
            if (FoodsLeave)
            {
                btnFoods.BorderColor = Color.LightGray;
                btnFoods.ForeColor = Color.Black;
            }
        }

        private void btnLeash_MouseEnter(object sender, EventArgs e)
        {
            btnLeash.BorderColor = Color.FromArgb(255, 152, 19);
            btnLeash.ForeColor = Color.FromArgb(255, 152, 19);
        }

        private void btnLeash_MouseLeave(object sender, EventArgs e)
        {
            if (LeashLeave)
            {
                btnLeash.BorderColor = Color.LightGray;
                btnLeash.ForeColor = Color.Black;
            }
        }

        private void btnToiletries_MouseEnter(object sender, EventArgs e)
        {
            btnToiletries.BorderColor = Color.FromArgb(255, 152, 19);
            btnToiletries.ForeColor = Color.FromArgb(255, 152, 19);
        }

        private void btnToiletries_MouseLeave(object sender, EventArgs e)
        {
            if (ToiletriesLeave)
            {
                btnToiletries.BorderColor = Color.LightGray;
                btnToiletries.ForeColor = Color.Black;
            }
        }

        private void btnMedicine_MouseEnter(object sender, EventArgs e)
        {
            btnMedicine.BorderColor = Color.FromArgb(255, 152, 19);
            btnMedicine.ForeColor = Color.FromArgb(255, 152, 19);
        }

        private void btnMedicine_MouseLeave(object sender, EventArgs e)
        {
            if (MedicineLeave)
            {
                btnMedicine.BorderColor = Color.LightGray;
                btnMedicine.ForeColor = Color.Black;
            }
        }

        private void btnCage_MouseEnter(object sender, EventArgs e)
        {
            btnCage.BorderColor = Color.FromArgb(255, 152, 19);
            btnCage.ForeColor = Color.FromArgb(255, 152, 19);
        }

        private void btnCage_MouseLeave(object sender, EventArgs e)
        {
            if (CageLeave)
            {
                btnCage.BorderColor = Color.LightGray;
                btnCage.ForeColor = Color.Black;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            AllLeave = false;

            FoodsLeave = true;
            LeashLeave = true;
            ToiletriesLeave = true;
            MedicineLeave = true;
            CageLeave = true;

            btnFoods.BorderColor = Color.LightGray;
            btnFoods.ForeColor = Color.Black;
            btnLeash.BorderColor = Color.LightGray;
            btnLeash.ForeColor = Color.Black;
            btnToiletries.BorderColor = Color.LightGray;
            btnToiletries.ForeColor = Color.Black;
            btnMedicine.BorderColor = Color.LightGray;
            btnMedicine.ForeColor = Color.Black;
            btnCage.BorderColor = Color.LightGray;
            btnCage.ForeColor = Color.Black;

            btnAll.BorderColor = Color.FromArgb(255, 152, 19);
            btnAll.ForeColor = Color.FromArgb(255, 152, 19);

            txtSearch.Text = null;
            showItemCount("All");
            flpOrder.Controls.Clear();
            LoadItems("All");

            lblItems.Text = "All Items";
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            showItemCount("Foods");
            flpOrder.Controls.Clear();
            LoadItems("Foods");

            lblItems.Text = "Food Items";

            if (lblItems.Text == "Food Items")
            {
                FoodsLeave = false;

                AllLeave = true;
                LeashLeave = true;
                ToiletriesLeave = true;
                MedicineLeave = true;
                CageLeave = true;

                btnAll.BorderColor = Color.LightGray;
                btnAll.ForeColor = Color.Black;
                btnLeash.BorderColor = Color.LightGray;
                btnLeash.ForeColor = Color.Black;
                btnToiletries.BorderColor = Color.LightGray;
                btnToiletries.ForeColor = Color.Black;
                btnMedicine.BorderColor = Color.LightGray;
                btnMedicine.ForeColor = Color.Black;
                btnCage.BorderColor = Color.LightGray;
                btnCage.ForeColor = Color.Black;

                btnFoods.BorderColor = Color.FromArgb(255, 152, 19);
                btnFoods.ForeColor = Color.FromArgb(255, 152, 19);
            }
        }

        private void btnLeash_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;

            showItemCount("Leash");
            flpOrder.Controls.Clear();
            LoadItems("Leash");

            lblItems.Text = "Leash Items";

            if (lblItems.Text == "Leash Items")
            {
                LeashLeave = false;

                AllLeave = true;
                FoodsLeave = true;
                ToiletriesLeave = true;
                MedicineLeave = true;
                CageLeave = true;

                btnAll.BorderColor = Color.LightGray;
                btnAll.ForeColor = Color.Black;
                btnFoods.BorderColor = Color.LightGray;
                btnFoods.ForeColor = Color.Black;
                btnToiletries.BorderColor = Color.LightGray;
                btnToiletries.ForeColor = Color.Black;
                btnMedicine.BorderColor = Color.LightGray;
                btnMedicine.ForeColor = Color.Black;
                btnCage.BorderColor = Color.LightGray;
                btnCage.ForeColor = Color.Black;

                btnLeash.BorderColor = Color.FromArgb(255, 152, 19);
                btnLeash.ForeColor = Color.FromArgb(255, 152, 19);
            }
        }

        private void btnToiletries_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;

            showItemCount("Toiletries");
            flpOrder.Controls.Clear();
            LoadItems("Toiletries");

            lblItems.Text = "Toiletries Items";

            if (lblItems.Text == "Toiletries Items")
            {
                ToiletriesLeave = false;

                AllLeave = true;
                FoodsLeave = true;
                LeashLeave = true;
                MedicineLeave = true;
                CageLeave = true;

                btnAll.BorderColor = Color.LightGray;
                btnAll.ForeColor = Color.Black;
                btnFoods.BorderColor = Color.LightGray;
                btnFoods.ForeColor = Color.Black;
                btnLeash.BorderColor = Color.LightGray;
                btnLeash.ForeColor = Color.Black;
                btnMedicine.BorderColor = Color.LightGray;
                btnMedicine.ForeColor = Color.Black;
                btnCage.BorderColor = Color.LightGray;
                btnCage.ForeColor = Color.Black;

                btnToiletries.BorderColor = Color.FromArgb(255, 152, 19);
                btnToiletries.ForeColor = Color.FromArgb(255, 152, 19);
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;

            showItemCount("Medicines");
            flpOrder.Controls.Clear();
            LoadItems("Medicines");

            lblItems.Text = "Medicine Items";

            if (lblItems.Text == "Medicine Items")
            {
                MedicineLeave = false;

                AllLeave = true;
                FoodsLeave = true;
                LeashLeave = true;
                ToiletriesLeave = true;
                CageLeave = true;

                btnAll.BorderColor = Color.LightGray;
                btnAll.ForeColor = Color.Black;
                btnFoods.BorderColor = Color.LightGray;
                btnFoods.ForeColor = Color.Black;
                btnLeash.BorderColor = Color.LightGray;
                btnLeash.ForeColor = Color.Black;
                btnToiletries.BorderColor = Color.LightGray;
                btnToiletries.ForeColor = Color.Black;
                btnCage.BorderColor = Color.LightGray;
                btnCage.ForeColor = Color.Black;

                btnMedicine.BorderColor = Color.FromArgb(255, 152, 19);
                btnMedicine.ForeColor = Color.FromArgb(255, 152, 19);
            }
        }

        private void btnCage_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;

            showItemCount("Cage");
            flpOrder.Controls.Clear();
            LoadItems("Cage");

            lblItems.Text = "Cage Items";

            if (lblItems.Text == "Cage Items")
            {
                CageLeave = false;

                AllLeave = true;
                FoodsLeave = true;
                LeashLeave = true;
                ToiletriesLeave = true;
                MedicineLeave = true;

                btnAll.BorderColor = Color.LightGray;
                btnAll.ForeColor = Color.Black;
                btnFoods.BorderColor = Color.LightGray;
                btnFoods.ForeColor = Color.Black;
                btnLeash.BorderColor = Color.LightGray;
                btnLeash.ForeColor = Color.Black;
                btnToiletries.BorderColor = Color.LightGray;
                btnToiletries.ForeColor = Color.Black;
                btnMedicine.BorderColor = Color.LightGray;
                btnMedicine.ForeColor = Color.Black;

                btnCage.BorderColor = Color.FromArgb(255, 152, 19);
                btnCage.ForeColor = Color.FromArgb(255, 152, 19);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnAll.BorderColor = Color.FromArgb(255, 152, 19);
            btnAll.ForeColor = Color.FromArgb(255, 152, 19);

            AllLeave = false;

            FoodsLeave = true;
            LeashLeave = true;
            ToiletriesLeave = true;
            MedicineLeave = true;
            CageLeave = true;

            btnFoods.BorderColor = Color.LightGray;
            btnFoods.ForeColor = Color.Black;
            btnLeash.BorderColor = Color.LightGray;
            btnLeash.ForeColor = Color.Black;
            btnToiletries.BorderColor = Color.LightGray;
            btnToiletries.ForeColor = Color.Black;
            btnMedicine.BorderColor = Color.LightGray;
            btnMedicine.ForeColor = Color.Black;
            btnCage.BorderColor = Color.LightGray;
            btnCage.ForeColor = Color.Black;

            flpOrder.Controls.Clear();
            LoadItems(txtSearch.Text);
            showItemCount(txtSearch.Text);
            lblItems.Text = "Found Items";

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadItems("All");
                showItemCount("All");
                lblItems.Text = "All Items";
            }
        }

        private void lstPrices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPrices.Items.Clear();
            price = 0;
            countAmount();
        }

        public void btnProceed_Click(object sender, EventArgs e)
        {
            if (cmbAddress.Items.Count == 0)
            {
                var obj = new AddressNotice();
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    obj.Close();
                    var obj1 = new AddressPopUp() { userID = userID };
                    if (obj1.ShowDialog() == DialogResult.OK)
                    {
                        obj1.Close();
                        pnlCheckout.Visible = true;
                        loadCheckout();
                        countCart();
                        countCheckout();
                        getAddress();
                    }
                }
            }
            else
            {
                pnlCheckout.Visible = true;
                loadCheckout();
                countCart();
                countCheckout();
                getAddress();
                loadCartID();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCheckout.Visible = false;
            flpCheckoutCart.Controls.Clear();
            checkoutLstBox.Items.Clear();
            total = 0;
            lstCheckout.Items.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool checkoutCheker = false;

            foreach (string item in lstCheckout.Items)
            {
                if (UniversalVariables.conn1.State == ConnectionState.Open)
                {
                    UniversalVariables.conn1.Close();
                }

                try
                {
                    UniversalVariables.sql1 = "SELECT * FROM storeItems WHERE prodAvail = 0 AND sID IN (SELECT (sID) FROM userCart WHERE cID = '" + item + "')";
                    UniversalVariables.connectAlt();

                    if (UniversalVariables.dr1.Read())
                    {
                        checkoutCheker = true;
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn1.Close();
            }

            if (checkoutCheker == false)
            {
                checkoutItem();
            }
            else
            {
                var obj = new ItemCheckoutConfirmation();
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    flpCart.Controls.Clear();
                    loadCart();

                    removeItems();
                    lstCheckout.Items.Clear();
                    flpCheckoutCart.Controls.Clear();
                    checkoutLstBox.Items.Clear();

                    pnlCheckout.Visible = false;
                    flpOrder.Controls.Clear();
                    LoadItems("All");

                    if (UniversalVariables.conn.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn.Close();
                    }

                    try
                    {
                        UniversalVariables.sql = "SELECT * FROM userCart WHERE uID = '" + userID + "'";
                        UniversalVariables.connect();

                        while (UniversalVariables.dr.Read())
                            lstCheckout.Items.Add(UniversalVariables.dr.GetString("cID").ToString());
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox(ex.Message);
                    }
                    UniversalVariables.conn.Close();
                }
            }

            if (flag == true)
            {
                var obj = new OrderConfirmation() { ordernumber = orderNum };
                if (obj.ShowDialog() == DialogResult.OK)
                {
                    flpCart.Controls.Clear();
                    pnlCartCheck.Visible = true;
                    btnProceed.Enabled = false;
                    lblSubT.Text = "₱0";
                    lblTotal.Text = "₱50";
                    total = 0;
                    removeItems();
                    pnlCheckout.Visible = false;
                    flag = false;
                    lstCheckout.Items.Clear();
                    flpCheckoutCart.Controls.Clear();
                    checkoutLstBox.Items.Clear();
                    flpOrder.Controls.Clear();
                    LoadItems("All");
                }
            }
        }
    }
}