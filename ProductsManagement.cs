using System;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class ProductsManagement
    {
        private bool FoodsLeave = true;
        private bool LeashLeave = true;
        private bool ToiletriesLeave = true;
        private bool MedicineLeave = true;
        private bool CageLeave = true;

        private Panel _pnlItems;

        private Panel pnlItems
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _pnlItems;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _pnlItems = value;
            }
        }
        private PictureBox _picItem;

        private PictureBox picItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _picItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _picItem = value;
            }
        }
        private Label _lblItem;

        private Label lblItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblItem = value;
            }
        }
        private Label _lblPriceAvail;

        private Label lblPriceAvail
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblPriceAvail;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblPriceAvail = value;
            }
        }
        private Guna.UI2.WinForms.Guna2Button _btnEdit;

        private Guna.UI2.WinForms.Guna2Button btnEdit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnEdit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _btnEdit = value;
            }
        }
        private PictureBox _btnRemove;

        private PictureBox btnRemove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnRemove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _btnRemove = value;
            }
        }
        private Guna.UI2.WinForms.Guna2PictureBox _picNoStock;

        private Guna.UI2.WinForms.Guna2PictureBox picNoStock
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _picNoStock;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _picNoStock = value;
            }
        }

        public ProductsManagement()
        {
            pnlItems = new Panel();
            picItem = new PictureBox();
            lblItem = new Label();
            lblPriceAvail = new Label();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnRemove = new PictureBox();
            picNoStock = new Guna.UI2.WinForms.Guna2PictureBox();
            InitializeComponent();
        }

        private void ProductsManagement_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            btnFoods.BorderColor = Color.FromArgb(255, 152, 19);
            btnFoods.ForeColor = Color.FromArgb(255, 152, 19);
            FoodsLeave = false;

            flpManage.Controls.Clear();
            loadProducts("Foods");
            showItemCount("Foods");
            lblItems.Text = "Foods Category";
        }

        private void loadProducts(string itemType)
        {
            flpManage.Controls.Add(btnAddNew);

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM storeItems WHERE prodCat = '" + itemType + "' ORDER BY prodAvail ASC";
                UniversalVariables.connect();

                while (UniversalVariables.dr.Read())
                {
                    pnlItems = new Panel()
                    {
                        Width = 201,
                        Height = 281,
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    picNoStock.BringToFront();
                    picNoStock = new Guna.UI2.WinForms.Guna2PictureBox()
                    {
                        Width = 122,
                        Height = 120,
                        Location = new Point(43, 19),
                        Image = My.Resources.Resources.outofstock,
                        UseTransparentBackground = true,
                        SizeMode = PictureBoxSizeMode.Normal
                    };
                    if (Conversions.ToInteger(UniversalVariables.dr.GetString("prodAvail").ToString()) == 0)
                    {
                        picNoStock.Visible = true;
                    }
                    else
                    {
                        picNoStock.Visible = false;
                    }

                    long len = UniversalVariables.dr.GetBytes(1, 0L, null, 0, 0);
                    var array = new byte[(int)len + 1];
                    UniversalVariables.dr.GetBytes(1, 0L, array, 0, (int)len);
                    picItem = new PictureBox()
                    {
                        Width = 106,
                        Height = 106,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Location = new Point(45, 18)
                    };
                    var ms = new System.IO.MemoryStream(array);
                    var bitmap = new Bitmap(ms);
                    picItem.BackgroundImage = bitmap;

                    lblItem = new Label()
                    {
                        Text = UniversalVariables.dr.GetString("prodName").ToString(),
                        Font = new Font("Proxima Nova Rg", 11f, FontStyle.Regular),
                        Width = 133,
                        Height = 41,
                        ForeColor = Color.Black,
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.TopCenter,
                        Location = new Point(32, 137)
                    };

                    lblPriceAvail = new Label()
                    {
                        Text = "₱" + UniversalVariables.dr.GetString("prodPrice").ToString() + " • " + UniversalVariables.dr.GetString("prodAvail").ToString() + " Available",
                        Font = new Font("Proxima Nova Rg", 11f, FontStyle.Regular),
                        Width = 193,
                        Height = 21,
                        ForeColor = SystemColors.ControlDarkDark,
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(3, 190)
                    };

                    btnEdit = new Guna.UI2.WinForms.Guna2Button()
                    {
                        Text = "Edit Item",
                        Font = new Font("Proxima Nova Rg", 12f, FontStyle.Bold),
                        Width = 201,
                        Height = 53,
                        Animated = true,
                        UseTransparentBackground = true,
                        FillColor = Color.PeachPuff,
                        ForeColor = Color.FromArgb(255, 152, 19),
                        Location = new Point(-1, 227),
                        Image = My.Resources.Resources.EditItemIconColored,
                        Cursor = Cursors.Hand,
                        ImageSize = new Size(23, 23),
                        Tag = UniversalVariables.dr.GetString("sID").ToString()
                    };

                    btnRemove = new PictureBox()
                    {
                        Width = 25,
                        Height = 30,
                        Location = new Point(170, 5),
                        BackgroundImage = My.Resources.Resources.trashIconBlack,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Cursor = Cursors.Hand,
                        Tag = UniversalVariables.dr.GetString("sID").ToString()
                    };

                    pnlItems.Controls.Add(picItem);
                    pnlItems.Controls.Add(lblItem);
                    pnlItems.Controls.Add(lblPriceAvail);
                    pnlItems.Controls.Add(btnEdit);
                    pnlItems.Controls.Add(btnRemove);
                    pnlItems.Controls.Add(picNoStock);
                    flpManage.Controls.Add(pnlItems);

                    btnEdit.Click += btnEdit_Click;
                    btnRemove.Click += btnRemove_Click;
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

            try
            {
                UniversalVariables.sql = "SELECT COUNT(*) FROM storeItems WHERE prodCat = '" + prodType + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    lblItemCount.Text = Conversions.ToString(Operators.ConcatenateObject(UniversalVariables.dr.GetValue(0), " Items"));
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void deleteItem(string itemID)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "DELETE FROM storeItems WHERE sID = '" + itemID + "'";
                UniversalVariables.connect();

                UniversalVariables.dr.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var obj = new DeleteConfirmation() { passConfirmation = "Delete Item?" };
            if (obj.ShowDialog() == DialogResult.OK)
            {
                this.deleteItem(sender.tag.ToString());
                flpManage.Controls.Clear();
                loadAll();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var obj = new AddItem()
            {
                checker = true,
                itemID = sender.tag.ToString()
            };
            obj.ShowDialog();
            loadAll();
        }

        private void loadAll()
        {
            flpManage.Controls.Clear();
            if (btnFoods.BorderColor == Color.FromArgb(255, 152, 19))
            {
                loadProducts("Foods");
                showItemCount("Foods");
            }
            else if (btnLeash.BorderColor == Color.FromArgb(255, 152, 19))
            {
                loadProducts("Leash");
                showItemCount("Leash");
            }
            else if (btnToiletries.BorderColor == Color.FromArgb(255, 152, 19))
            {
                loadProducts("Toiletries");
                showItemCount("Toiletries");
            }
            else if (btnMedicine.BorderColor == Color.FromArgb(255, 152, 19))
            {
                loadProducts("Medicines");
                showItemCount("Medicines");
            }
            else
            {
                loadProducts("Cage");
                showItemCount("Cage");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var obj = new AddItem();
            if (btnFoods.BorderColor == Color.FromArgb(255, 152, 19))
            {
                obj.passItemCategory = "Foods";
            }
            else if (btnLeash.BorderColor == Color.FromArgb(255, 152, 19))
            {
                obj.passItemCategory = "Leash";
            }
            else if (btnToiletries.BorderColor == Color.FromArgb(255, 152, 19))
            {
                obj.passItemCategory = "Toiletries";
            }
            else if (btnMedicine.BorderColor == Color.FromArgb(255, 152, 19))
            {
                obj.passItemCategory = "Medicines";
            }
            else
            {
                obj.passItemCategory = "Cage";
            }
            if (obj.ShowDialog() == DialogResult.OK)
            {
                loadAll();
                var obj1 = new SavedConfirmation() { ItemAddedConfirmation = "Item Added Succesfully!" };
                obj1.ShowDialog();
            }
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            showItemCount("Foods");
            flpManage.Controls.Clear();
            loadProducts("Foods");

            lblItems.Text = "Foods Category";

            FoodsLeave = false;

            LeashLeave = true;
            ToiletriesLeave = true;
            MedicineLeave = true;
            CageLeave = true;

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

        private void btnLeash_Click(object sender, EventArgs e)
        {
            showItemCount("Leash");
            flpManage.Controls.Clear();
            loadProducts("Leash");

            lblItems.Text = "Leash Category";

            if (lblItems.Text == "Leash Category")
            {
                LeashLeave = false;

                FoodsLeave = true;
                ToiletriesLeave = true;
                MedicineLeave = true;
                CageLeave = true;

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
            showItemCount("Toiletries");
            flpManage.Controls.Clear();
            loadProducts("Toiletries");

            lblItems.Text = "Toiletries Category";

            if (lblItems.Text == "Toiletries Category")
            {
                ToiletriesLeave = false;

                FoodsLeave = true;
                LeashLeave = true;
                MedicineLeave = true;
                CageLeave = true;

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
            showItemCount("Medicines");
            flpManage.Controls.Clear();
            loadProducts("Medicines");

            lblItems.Text = "Medicine Category";

            if (lblItems.Text == "Medicine Category")
            {
                MedicineLeave = false;

                FoodsLeave = true;
                LeashLeave = true;
                ToiletriesLeave = true;
                CageLeave = true;

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
            showItemCount("Cage");
            flpManage.Controls.Clear();
            loadProducts("Cage");

            lblItems.Text = "Cage Category";

            if (lblItems.Text == "Cage Category")
            {
                CageLeave = false;

                FoodsLeave = true;
                LeashLeave = true;
                ToiletriesLeave = true;
                MedicineLeave = true;

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
    }
}