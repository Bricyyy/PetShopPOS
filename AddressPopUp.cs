using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class AddressPopUp
    {

        public string userID { get; set; }

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

        public AddressPopUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
            }
        }

        private void AddressPopUp_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";
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
                string hset = "Yes";

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

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
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
    }
}