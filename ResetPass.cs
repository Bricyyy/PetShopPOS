using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class ResetPass
    {
        public string passEmail { get; set; }
        public bool passValue { get; set; } = false;

        private readonly byte[] key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private readonly byte[] iv = new byte[] { 10, 9, 8, 7, 6, 5, 4, 3 };
        private PassEnCDeC des;

        public ResetPass()
        {
            des = new PassEnCDeC(key, iv);
            InitializeComponent();
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            if (passValue == true)
            {
                btnBack.Visible = false;
            }
        }

        private void clearFields()
        {
            if (txtNewPass.TextLength < 8 | txtConfirmPass.TextLength < 8)
            {
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
            }
            else if ((txtNewPass.Text ?? "") != (txtConfirmPass.Text ?? ""))
            {
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
            }
            else if (!ValidatePassword(txtNewPass.Text))
            {
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
            }
        }

        private bool fieldsChecker()
        {
            lblError.Location = new Point(14, 210);

            if (string.IsNullOrEmpty(txtNewPass.Text) | string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Password is invalid!";
                return false;
            }
            else if (txtNewPass.TextLength < 8 | txtConfirmPass.TextLength < 8)
            {
                lblError.Visible = true;
                lblError.Text = "Password should be more than 8 characters!";
                return false;
            }
            else if ((txtNewPass.Text ?? "") != (txtConfirmPass.Text ?? ""))
            {
                lblError.Visible = true;
                lblError.Text = "Password does not match!";
                return false;
            }
            else if (!ValidatePassword(txtNewPass.Text))
            {
                lblError.Visible = true;
                lblError.Location = new Point(3, 210);
                lblError.Text = "Password must contain 1 Upper, Number, and Special!";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatePassword(string pwd, int minLength = 8, int numUpper = 1, int numLower = 5, int numNumbers = 1, int numSpecial = 1)
        {

            // Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
            var upper = new System.Text.RegularExpressions.Regex("[A-Z]");
            var lower = new System.Text.RegularExpressions.Regex("[a-z]");
            var number = new System.Text.RegularExpressions.Regex("[0-9]");
            // Special is "none of the above".
            var special = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");

            // Check the length.
            if (Strings.Len(pwd) < minLength)
                return false;
            // Check for minimum number of occurrences.
            if (upper.Matches(pwd).Count < numUpper)
                return false;
            if (lower.Matches(pwd).Count < numLower)
                return false;
            if (number.Matches(pwd).Count < numNumbers)
                return false;
            if (special.Matches(pwd).Count < numSpecial)
                return false;

            // Passed all checks.
            return true;
        }

        private void NewPassword()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "UPDATE userProfile SET uPass = '" + des.Encrypt(txtNewPass.Text) + "' WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                UniversalVariables.dr.Close();

                if (UniversalVariables.cmd.ExecuteNonQuery() > 0)
                {
                    donePanel.Visible = true;
                    resetPanel.Hide();
                    donePanel.Show();
                    dogPic.Visible = true;
                    btnBack.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            if (fieldsChecker())
            {
                NewPassword();
            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;

            lblNewPass.Visible = true;
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                lblNewPass.Visible = false;
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;

            lblConfirmPass.Visible = true;
            if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                lblConfirmPass.Visible = false;
            }
        }

        private void Guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (newPass.Checked == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void confirmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmPass.Checked == true)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void Guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (passValue == true)
            {
                Close();
            }
            else
            {
                var obj = new Login();
                obj.signupPanel.Visible = false;
                obj.loginPanel.Visible = true;
                obj.Show();
                Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Show();
            Hide();
        }
    }
}