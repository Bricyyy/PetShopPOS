using System;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class MyAddress
    {
        private string userID;
        private string address;
        private string editAddressID;

        public string passEmail { get; set; }
        public string passUsername { get; set; }

        private Panel _addressPnl;

        private Panel addressPnl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _addressPnl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _addressPnl = value;
            }
        }
        private Label _dialogfn;

        private Label dialogfn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dialogfn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _dialogfn = value;
            }
        }
        private Label _dialogph;

        private Label dialogph
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dialogph;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _dialogph = value;
            }
        }
        private Label _dialogad;

        private Label dialogad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dialogad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _dialogad = value;
            }
        }
        private Label _lblFName;

        private Label lblFName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblFName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblFName = value;
            }
        }
        private Label _lblPNum;

        private Label lblPNum
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblPNum;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblPNum = value;
            }
        }
        private Label _lblAdd;

        private Label lblAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblAdd = value;
            }
        }
        private Guna.UI2.WinForms.Guna2PictureBox _picLine;

        private Guna.UI2.WinForms.Guna2PictureBox picLine
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _picLine;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _picLine = value;
            }
        }
        private Label _editlbl;

        private Label editlbl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _editlbl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _editlbl = value;
            }
        }
        private Label _deletelbl;

        private Label deletelbl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _deletelbl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _deletelbl = value;
            }
        }
        private Guna.UI2.WinForms.Guna2Button _btnSet;

        private Guna.UI2.WinForms.Guna2Button btnSet
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSet;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _btnSet = value;
            }
        }
        private Label _defaultlbl;

        private Label defaultlbl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _defaultlbl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _defaultlbl = value;
            }
        }

        public MyAddress()
        {
            addressPnl = new Panel();
            dialogfn = new Label();
            dialogph = new Label();
            dialogad = new Label();
            lblFName = new Label();
            lblPNum = new Label();
            lblAdd = new Label();
            picLine = new Guna.UI2.WinForms.Guna2PictureBox();
            editlbl = new Label();
            deletelbl = new Label();
            btnSet = new Guna.UI2.WinForms.Guna2Button();
            defaultlbl = new Label();
            InitializeComponent();
        }

        private void MyAddress_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            txtPhoneNum.MaxLength = 11;

            loadAddress();

            if (!flpAddress.Controls.Contains(addressPnl))
            {
                lblIndicator.Visible = true;
            }
            else
            {
                lblIndicator.Visible = false;
            }
        }

        public void loadAddress()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    userID = UniversalVariables.dr.GetString("uID").ToString();

                    if (UniversalVariables.conn.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn.Close();
                    }

                    UniversalVariables.sql = "SELECT * FROM userAddress WHERE uID = '" + userID + "'";
                    UniversalVariables.connect();

                    while (UniversalVariables.dr.Read())
                    {
                        addressPnl = new Panel()
                        {
                            Width = 455,
                            Height = 140,
                            BackColor = Color.White
                        };

                        dialogfn = new Label()
                        {
                            Text = "Full Name",
                            Width = 73,
                            Height = 18,
                            ForeColor = SystemColors.ControlDarkDark,
                            Location = new Point(27, 31),
                            Font = new Font("Proxima Nova Lt", 11f, FontStyle.Regular)
                        };

                        dialogph = new Label()
                        {
                            Text = "Phone",
                            Width = 53,
                            Height = 18,
                            ForeColor = SystemColors.ControlDarkDark,
                            Location = new Point(50, 61),
                            Font = new Font("Proxima Nova Lt", 11f, FontStyle.Regular)
                        };

                        dialogad = new Label()
                        {
                            Text = "Address",
                            Width = 65,
                            Height = 18,
                            ForeColor = SystemColors.ControlDarkDark,
                            Location = new Point(37, 91),
                            Font = new Font("Proxima Nova Lt", 11f, FontStyle.Regular)
                        };

                        lblFName = new Label()
                        {
                            Text = UniversalVariables.dr.GetString("userFName").ToString(),
                            Width = 221,
                            Height = 20,
                            ForeColor = Color.Black,
                            Location = new Point(121, 30),
                            Font = new Font("Proxima Nova Lt", 12f, FontStyle.Bold)
                        };

                        lblPNum = new Label()
                        {
                            Text = UniversalVariables.dr.GetString("userPNum").ToString(),
                            Width = 200,
                            Height = 18,
                            ForeColor = Color.Black,
                            Location = new Point(122, 61),
                            Font = new Font("Proxima Nova Rg", 11f, FontStyle.Regular)
                        };

                        string userFullAddress;
                        string houseNumber = UniversalVariables.dr.GetString("userHouseNum").ToString();
                        string houseRegion = UniversalVariables.dr.GetString("userRegion").ToString();
                        string housePostal = UniversalVariables.dr.GetString("userPostal").ToString();
                        userFullAddress = houseNumber + " " + houseRegion + " " + housePostal;
                        lblAdd = new Label()
                        {
                            Text = userFullAddress,
                            Width = 221,
                            Height = 36,
                            ForeColor = Color.Black,
                            Location = new Point(122, 91),
                            Font = new Font("Proxima Nova Rg", 11f, FontStyle.Regular)
                        };
                        lblAdd.SendToBack();

                        picLine = new Guna.UI2.WinForms.Guna2PictureBox()
                        {
                            Image = My.Resources.Resources.line,
                            Width = 540,
                            Height = 20,
                            Location = new Point(-32, 129),
                            BackColor = Color.Transparent,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            TabIndex = 57,
                            TabStop = false,
                            UseTransparentBackground = true
                        };

                        editlbl = new Label()
                        {
                            Text = "Edit",
                            Width = 35,
                            Height = 16,
                            ForeColor = Color.Black,
                            Location = new Point(409, 34),
                            Font = new Font("Proxima Nova Rg", 10f, FontStyle.Underline),
                            Cursor = Cursors.Hand,
                            Tag = UniversalVariables.dr["aID"].ToString()
                        };

                        deletelbl = new Label()
                        {
                            Text = "Delete",
                            AutoSize = true,
                            Size = new Size(45, 16),
                            ForeColor = Color.Black,
                            TabIndex = 59,
                            Location = new Point(348, 34),
                            Font = new Font("Proxima Nova Rg", 10f, FontStyle.Underline),
                            Cursor = Cursors.Hand,
                            Tag = UniversalVariables.dr["aID"].ToString()
                        };

                        btnSet = new Guna.UI2.WinForms.Guna2Button()
                        {
                            Text = "Set as Default",
                            Width = 80,
                            Height = 32,
                            ForeColor = Color.Black,
                            Location = new Point(360, 77),
                            Font = new Font("Proxima Nova Rg", 8f, FontStyle.Regular),
                            Cursor = Cursors.Hand,
                            FillColor = Color.Transparent,
                            BorderColor = Color.LightGray,
                            BorderThickness = 1,
                            Animated = true,
                            Tag = UniversalVariables.dr["aID"].ToString()
                        };
                        btnSet.BringToFront();

                        defaultlbl = new Label()
                        {
                            Text = "Default",
                            AutoSize = true,
                            BackColor = Color.FromArgb(0, 191, 165),
                            Font = new Font("Proxima Nova Lt", 10f, FontStyle.Bold),
                            ForeColor = Color.White,
                            Location = new Point(385, 89)
                        };
                        defaultlbl.BringToFront();

                        addressPnl.Controls.Add(dialogfn);
                        addressPnl.Controls.Add(dialogph);
                        addressPnl.Controls.Add(dialogad);
                        addressPnl.Controls.Add(lblFName);
                        addressPnl.Controls.Add(lblPNum);
                        addressPnl.Controls.Add(lblAdd);
                        addressPnl.Controls.Add(picLine);
                        addressPnl.Controls.Add(editlbl);
                        addressPnl.Controls.Add(deletelbl);
                        addressPnl.Controls.Add(defaultlbl);
                        addressPnl.Controls.Add(btnSet);

                        string defaultType = UniversalVariables.dr.GetString("isDefault").ToString();
                        if (defaultType.Equals("Yes"))
                        {
                            btnSet.Visible = false;
                            deletelbl.Visible = false;
                            defaultlbl.Visible = true;
                        }
                        else
                        {
                            btnSet.Enabled = true;
                            deletelbl.Visible = true;
                            defaultlbl.Visible = false;
                        }

                        flpAddress.Controls.Add(addressPnl);

                        btnSet.Click += btnSet_Click;
                        deletelbl.Click += deletelbl_Click;
                        editlbl.Click += editlbl_Click;
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void insertAddress()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                string fullname = txtFullName.Text;
                string phonenum = txtPhoneNum.Text;
                string region = txtRegion.Text;
                string postal = txtPostalCode.Text;
                string street = txtStreet.Text;
                string type;
                if (btnHome.ForeColor == Color.FromArgb(255, 152, 19))
                {
                    type = "Home";
                }
                else if (btnWork.ForeColor == Color.FromArgb(255, 152, 19))
                {
                    type = "Work";
                }
                else
                {
                    type = null;
                }
                string hset;
                if (chkDefault.Checked == true)
                {
                    hset = "Yes";
                }
                else
                {
                    hset = "No";
                }

                if (type == "Home" | type == "Work")
                {
                    UniversalVariables.sql = "INSERT INTO userAddress (uID, userFName, userPNum, userRegion, userPostal, userHouseNum, userLabel, isDefault) VALUES ('" + userID + "','" + fullname + "','" + phonenum + "','" + region + "','" + postal + "','" + street + "','" + type + "','" + hset + "')";
                    UniversalVariables.connect();
                }
                else
                {
                    UniversalVariables.sql = "INSERT INTO userAddress (uID, userFName, userPNum, userRegion, userPostal, userHouseNum, isDefault) VALUES ('" + userID + "','" + fullname + "','" + phonenum + "','" + region + "','" + postal + "','" + street + "','" + hset + "')";
                    UniversalVariables.connect();
                }

                UniversalVariables.dr.Close();
                getLastId();

                if (chkDefault.Checked == true)
                {
                    if (UniversalVariables.conn.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn.Close();
                    }

                    UniversalVariables.sql = "UPDATE userAddress SET isDefault = '" + "No" + "' WHERE  uID = '" + userID + "' AND  aID <> '" + address + "'";
                    UniversalVariables.connect();

                    UniversalVariables.dr.Close();

                    if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                    {
                        flpAddress.Controls.Clear();
                        loadAddress();
                    }
                }
                else
                {
                    flpAddress.Controls.Clear();
                    loadAddress();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void getLastId()
        {
            UniversalVariables.sql = "SELECT aID FROM userAddress WHERE aID = (SELECT max(aID) FROM userAddress)";
            var cmd1 = new MySqlCommand(UniversalVariables.sql, UniversalVariables.conn);
            UniversalVariables.dr = cmd1.ExecuteReader();
            UniversalVariables.dr.Read();
            address = Conversions.ToString(UniversalVariables.dr["aID"]);
            UniversalVariables.conn.Close();
        }

        private void updateAddress()
        {
            string houselabel;
            if (btnHome.ForeColor == Color.FromArgb(255, 152, 19))
            {
                houselabel = "Home";
            }
            else if (btnWork.ForeColor == Color.FromArgb(255, 152, 19))
            {
                houselabel = "Work";
            }
            else
            {
                houselabel = null;
            }

            string hset;
            if (chkDefault.Checked == true)
            {
                hset = "Yes";
            }
            else
            {
                hset = "No";
            }

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                if (houselabel == "Home" | houselabel == "Work")
                {
                    UniversalVariables.sql = "UPDATE userAddress SET userFName = '" + txtFullName.Text + "', userPNum = '" + txtPhoneNum.Text + "', userRegion = '" + txtRegion.Text + "', userPostal = '" + txtPostalCode.Text + "', userHouseNum = '" + txtStreet.Text + "', userLabel = '" + houselabel + "', isDefault = '" + hset + "' WHERE aID = '" + editAddressID + "'";
                    UniversalVariables.connect();
                }
                else
                {
                    UniversalVariables.sql = "UPDATE userAddress SET userFName = '" + txtFullName.Text + "', userPNum = '" + txtPhoneNum.Text + "', userRegion = '" + txtRegion.Text + "', userPostal = '" + txtPostalCode.Text + "', userHouseNum = '" + txtStreet.Text + "', userLabel = NULL, isDefault = '" + hset + "' WHERE aID = '" + editAddressID + "'";
                    UniversalVariables.connect();
                }

                UniversalVariables.dr.Close();

                if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                {
                    if (chkDefault.Checked == true)
                    {
                        if (UniversalVariables.conn.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn.Close();
                        }

                        UniversalVariables.sql = "UPDATE userAddress SET isDefault = '" + "No" + "' WHERE  uID = '" + userID + "' AND  aID <> '" + editAddressID + "'";
                        UniversalVariables.connect();

                        UniversalVariables.dr.Close();

                        if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                        {
                            flpAddress.Controls.Clear();
                            loadAddress();
                        }
                    }
                    else
                    {
                        flpAddress.Controls.Clear();
                        loadAddress();
                    }
                }

                flpAddress.Controls.Clear();
                loadAddress();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void editlbl_Click(object sender, EventArgs e)
        {
            addressPnl.Visible = false;
            pnlNewAddress.Visible = true;

            btnSubmit.Visible = false;
            btnSave.Visible = true;
            lblTitle.Text = "Edit Address";

            editAddressID = sender.tag.ToString();

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "SELECT * FROM userAddress WHERE aID = '" + editAddressID + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    txtFullName.Text = UniversalVariables.dr.GetString("userFName");
                    txtPhoneNum.Text = UniversalVariables.dr.GetString("userPNum");
                    txtRegion.Text = UniversalVariables.dr.GetString("userRegion");
                    txtPostalCode.Text = UniversalVariables.dr.GetString("userPostal");
                    txtStreet.Text = UniversalVariables.dr.GetString("userHouseNum");

                    if (UniversalVariables.dr.IsDBNull(7))
                    {
                        btnHome.ForeColor = Color.Black;
                        btnHome.BorderColor = Color.FromArgb(213, 218, 223);
                        btnWork.ForeColor = Color.Black;
                        btnWork.BorderColor = Color.FromArgb(213, 218, 223);
                    }
                    else
                    {
                        string houseLabel = UniversalVariables.dr.GetString("userLabel");
                        if (houseLabel == "Home")
                        {
                            btnHome.ForeColor = Color.FromArgb(255, 152, 19);
                            btnHome.BorderColor = Color.FromArgb(255, 152, 19);

                            btnWork.ForeColor = Color.Black;
                            btnWork.BorderColor = Color.FromArgb(213, 218, 223);
                        }
                        else if (houseLabel == "Work")
                        {
                            btnWork.ForeColor = Color.FromArgb(255, 152, 19);
                            btnWork.BorderColor = Color.FromArgb(255, 152, 19);

                            btnHome.ForeColor = Color.Black;
                            btnHome.BorderColor = Color.FromArgb(213, 218, 223);
                        }
                    }

                    string houseDefault = UniversalVariables.dr.GetString("isDefault");
                    if (houseDefault == "Yes")
                    {
                        chkDefault.Checked = true;
                        chkDefault.Enabled = false;
                    }
                    else if (houseDefault == "No")
                    {
                        chkDefault.Checked = false;
                        chkDefault.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void deletelbl_Click(object sender, EventArgs e)
        {
            string addressID;
            addressID = sender.tag.ToString();

            if (My.MyProject.Forms.DeleteConfirmation.ShowDialog() == DialogResult.OK)
            {
                if (UniversalVariables.conn.State == ConnectionState.Open)
                {
                    UniversalVariables.conn.Close();
                }

                try
                {
                    UniversalVariables.sql = "DELETE FROM userAddress WHERE aID = '" + addressID + "'";
                    UniversalVariables.connect();

                    UniversalVariables.dr.Close();

                    flpAddress.Controls.Clear();
                    loadAddress();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn.Close();
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string addressID;
            addressID = sender.tag.ToString();

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "UPDATE userAddress SET isDefault = '" + "Yes" + "' WHERE aID = '" + addressID + "' AND uID = '" + userID + "'";
                UniversalVariables.connect();

                UniversalVariables.dr.Close();

                if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                {
                    btnSet.Visible = false;
                    deletelbl.Visible = false;
                    defaultlbl.Visible = true;

                    if (UniversalVariables.conn.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn.Close();
                    }

                    UniversalVariables.sql = "UPDATE userAddress SET isDefault = '" + "No" + "' WHERE uID = '" + userID + "' AND aID <> '" + addressID + "'";
                    UniversalVariables.connect();

                    UniversalVariables.dr.Close();

                    if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                    {
                        btnSet.Enabled = true;
                        deletelbl.Visible = true;
                        defaultlbl.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();

            flpAddress.Controls.Clear();
            loadAddress();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addressPnl.Visible = false;
            lblIndicator.Visible = false;
            pnlNewAddress.Visible = true;

            btnSave.Visible = false;
            btnSubmit.Visible = true;
            lblTitle.Text = "New Address";

            lblChecker.Visible = false;

            clearFields();

            if (!flpAddress.Controls.Contains(addressPnl))
            {
                chkDefault.Checked = true;
                chkDefault.Enabled = false;
            }
            else
            {
                chkDefault.Checked = false;
                chkDefault.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            addressPnl.Visible = true;
            pnlNewAddress.Visible = false;

            if (!flpAddress.Controls.Contains(addressPnl))
            {
                lblIndicator.Visible = true;
            }
            else
            {
                lblIndicator.Visible = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (btnHome.ForeColor == Color.FromArgb(255, 152, 19))
            {
                btnHome.ForeColor = Color.Black;
                btnHome.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                btnHome.ForeColor = Color.FromArgb(255, 152, 19);
                btnHome.BorderColor = Color.FromArgb(255, 152, 19);

                btnWork.ForeColor = Color.Black;
                btnWork.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if (btnWork.ForeColor == Color.FromArgb(255, 152, 19))
            {
                btnWork.ForeColor = Color.Black;
                btnWork.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                btnWork.ForeColor = Color.FromArgb(255, 152, 19);
                btnWork.BorderColor = Color.FromArgb(255, 152, 19);

                btnHome.ForeColor = Color.Black;
                btnHome.BorderColor = Color.FromArgb(213, 218, 223);
            }
        }

        private void clearFields()
        {
            txtFullName.Text = null;
            txtPhoneNum.Text = null;
            txtRegion.Text = null;
            txtPostalCode.Text = null;
            txtStreet.Text = null;
            btnHome.ForeColor = Color.Black;
            btnHome.BorderColor = Color.FromArgb(213, 218, 223);
            btnWork.ForeColor = Color.Black;
            btnWork.BorderColor = Color.FromArgb(213, 218, 223);
            chkDefault.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) | string.IsNullOrEmpty(txtPhoneNum.Text) | string.IsNullOrEmpty(txtRegion.Text) | string.IsNullOrEmpty(txtPostalCode.Text) | string.IsNullOrEmpty(txtStreet.Text))
            {
                lblChecker.Visible = true;
            }
            else if (txtPhoneNum.Text.Length < 11)
            {
                lblChecker.Text = "Phone number should be 11 characters!";
                lblChecker.Visible = true;
            }
            else
            {
                insertAddress();
                clearFields();
                pnlNewAddress.Visible = false;
                addressPnl.Visible = true;
            }

            flpAddress.Controls.Clear();
            loadAddress();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) | string.IsNullOrEmpty(txtPhoneNum.Text) | string.IsNullOrEmpty(txtRegion.Text) | string.IsNullOrEmpty(txtPostalCode.Text) | string.IsNullOrEmpty(txtStreet.Text))
            {
                lblChecker.Visible = true;
            }
            else if (txtPhoneNum.Text.Length < 11)
            {
                lblChecker.Text = "Phone number should be 11 characters!";
                lblChecker.Visible = true;
            }
            else
            {
                updateAddress();
                clearFields();
                pnlNewAddress.Visible = false;
                addressPnl.Visible = true;
            }
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = Conversions.ToChar("");
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = Conversions.ToChar("");
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;
        }
    }
}