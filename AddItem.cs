using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class AddItem
    {
        private int flag = 0;

        public string passItemCategory { get; set; }
        public bool checker { get; set; } = false;
        public string itemID { get; set; }

        private readonly OpenFileDialog opf = new OpenFileDialog() { Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif" };

        private const int CS_DROPSHADOW = 131072;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_DROPSHADOW;
                return cp;
            }
        }

        public AddItem()
        {
            InitializeComponent();
        }

        private void ManageItem_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            if (checker == true)
            {
                setFields();
                lblItems.Text = "Edit Product";
            }
        }

        private bool isProductExist(string item)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                if (checker == true)
                {
                    UniversalVariables.sql = "SELECT * FROM storeItems WHERE prodName = '" + item + "' AND sID <> '" + itemID + "'";
                    UniversalVariables.connect();
                }
                else
                {
                    UniversalVariables.sql = "SELECT * FROM storeItems WHERE prodName = '" + item + "'";
                    UniversalVariables.connect();
                }

                if (UniversalVariables.dr.Read())
                {
                    lblChecker.Visible = true;
                    lblChecker.Text = "An item with this name already exist!";

                    return true;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();

            return false;
        }

        private void setFields()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM storeItems WHERE sID = '" + itemID + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    byte[] arrimage = (byte[])UniversalVariables.dr["prodPic"];
                    var mstream = new System.IO.MemoryStream(arrimage);
                    itemPicture.Image = Image.FromStream(mstream);

                    txtItemName.Text = UniversalVariables.dr.GetString("prodName").ToString();
                    txtItemPrice.Text = UniversalVariables.dr.GetString("prodPrice").ToString();
                    txtItemQuantity.Text = UniversalVariables.dr.GetString("prodAvail").ToString();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void updateItem()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                byte[] arrimage1;
                var originalImage = itemPicture.Image;
                var mstream1 = new System.IO.MemoryStream();
                originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg);
                arrimage1 = mstream1.GetBuffer();
                mstream1.Close();

                string itemCat = passItemCategory;
                string itemName = txtItemName.Text;
                string itemPrice = txtItemPrice.Text;
                string itemCount = txtItemQuantity.Text;

                UniversalVariables.sql = "UPDATE storeItems SET prodPic = @prodPic, prodName = @prodName, prodPrice = @prodPrice, prodAvail = @prodAvail WHERE sID = '" + itemID + "'";
                {
                    ref var withBlock = ref UniversalVariables.cmd;
                    withBlock.Parameters.Clear();
                    withBlock.Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1;
                    withBlock.Parameters.Add("@prodCat", MySqlDbType.VarChar).Value = itemCat;
                    withBlock.Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName;
                    withBlock.Parameters.Add("@prodPrice", MySqlDbType.VarChar).Value = itemPrice;
                    withBlock.Parameters.Add("@prodAvail", MySqlDbType.VarChar).Value = itemCount;
                }
                UniversalVariables.connect();

                UniversalVariables.dr.Close();

                if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                {
                    Close();
                    var obj1 = new SavedConfirmation();
                    obj1.ItemAddedConfirmation = "Item Updated Succesfully!";
                    obj1.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void insertNewItem()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                byte[] arrimage1;
                var originalImage = itemPicture.Image;
                var mstream1 = new System.IO.MemoryStream();
                originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg);
                arrimage1 = mstream1.GetBuffer();
                mstream1.Close();

                string itemCat = passItemCategory;
                string itemName = txtItemName.Text;
                string itemPrice = txtItemPrice.Text;
                string itemCount = txtItemQuantity.Text;

                UniversalVariables.sql = "INSERT INTO storeItems (prodPic, prodCat, prodName, prodPrice, prodAvail) VALUES (@prodPic, @prodCat, @prodName, @prodPrice, @prodAvail)";
                {
                    ref var withBlock = ref UniversalVariables.cmd;
                    withBlock.Parameters.Clear();
                    withBlock.Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1;
                    withBlock.Parameters.Add("@prodCat", MySqlDbType.VarChar).Value = itemCat;
                    withBlock.Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName;
                    withBlock.Parameters.Add("@prodPrice", MySqlDbType.VarChar).Value = itemPrice;
                    withBlock.Parameters.Add("@prodAvail", MySqlDbType.VarChar).Value = itemCount;
                }
                UniversalVariables.connect();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void setItemPic()
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                flag = 1;
                var originalImage = Image.FromFile(opf.FileName);
                itemPicture.Image = originalImage;
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                flag = 1;
            }

            if (string.IsNullOrEmpty(txtItemName.Text) | string.IsNullOrEmpty(txtItemPrice.Text) | string.IsNullOrEmpty(txtItemQuantity.Text) | flag == 0)
            {
                lblChecker.Visible = true;
            }
            else if (!isProductExist(txtItemName.Text))
            {
                if (checker == false)
                {
                    insertNewItem();
                    flag = 0;
                }
                else
                {
                    updateItem();
                    checker = false;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void setPic_Click(object sender, EventArgs e)
        {
            setItemPic();
            lblChecker.Visible = false;
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }

        private void txtItemPrice_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }

        private void txtItemQuantity_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }

        private void txtItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = Conversions.ToChar("");
        }

        private void txtItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = Conversions.ToChar("");
        }
    }
}