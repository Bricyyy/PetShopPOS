using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class Signup
    {
        private DateTime TargetDT;
        private DateTime tDateTime;
        private TimeSpan CountDownFrom = TimeSpan.FromSeconds(60d);
        private TimeSpan stopWatch = TimeSpan.FromSeconds(7d);

        private string randCode;
        private string toUser;

        private readonly byte[] key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private readonly byte[] iv = new byte[] { 10, 9, 8, 7, 6, 5, 4, 3 };
        private PassEnCDeC des;

        public string sentCode { get; set; }
        public string passEmail { get; set; }

        public Signup()
        {
            des = new PassEnCDeC(key, iv);
            InitializeComponent();
        }

        private void insertData()
        {
            try
            {
                UniversalVariables.sql = "INSERT INTO userProfile (uName, uNCount, uEmail, uPass) VALUES ('" + txtUsername.Text + "', '" + "0" + "' , '" + passEmail + "','" + des.Encrypt(txtPass.Text) + "')";
                UniversalVariables.connect();
                UniversalVariables.conn.Close();

                arrow2.Image = My.Resources.Resources.arrowcolored;
                picCheck.Image = My.Resources.Resources.checkcolored;
                lblDone.ForeColor = Color.FromArgb(190, 65, 109);
                pnlCreate.Visible = false;
                pnlDone.Visible = true;
                timerRedirect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private bool usernameCheck(string uname)
        {
            bool usernameExist = false;

            try
            {
                UniversalVariables.sql = "SELECT * FROM userProfile WHERE uName = '" + txtUsername.Text + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    lblError.Visible = true;
                    lblError.Text = "Username already exist!";
                    usernameExist = true;
                }
                UniversalVariables.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return usernameExist;
        }

        private void sendCode()
        {
            string from, pass, messageBody;
            var rand = new Random();
            randCode = rand.Next(999999).ToString();
            var message = new MailMessage();
            toUser = passEmail;
            from = "trialkoito4@gmail.com";
            pass = "broxxedasqosbrvy";
            messageBody = "Your Verification Code is: " + randCode;
            message.To.Add(toUser);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Resetting Code";
            var smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587
            };
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);

                var obj1 = new CodeVerification();
                obj1.ShowDialog();

                sentCode = randCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerStarter()
        {
            tmrResend.Start();
            tmrResend.Interval = 100;
            TargetDT = DateTime.Now.Add(CountDownFrom);
        }

        private void timerRedirect()
        {
            tmrRedirect.Start();
            tmrRedirect.Interval = 100;
            tDateTime = DateTime.Now.Add(stopWatch);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Show();
            Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            txtCode.MaxLength = 6;
            lblEmail.Text = passEmail;
            lblDEmail.Text = passEmail;
            timerStarter();
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = Conversions.ToChar("");
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(sentCode))
            {
                arrow1.Image = My.Resources.Resources.arrowcolored;
                pic2.Image = My.Resources.Resources.colored;
                lblCreate.ForeColor = Color.FromArgb(190, 65, 109);

                pnlVerify.Visible = false;
                pnlCreate.Visible = true;
            }
            else
            {
                lblCodeError.Visible = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var ts = TargetDT.Subtract(DateTime.Now);
            if (ts.TotalMilliseconds > 1d)
            {
                lblTimer.Text = "Please wait " + ts.ToString("ss") + " seconds to resend.";
            }
            else
            {
                tmrResend.Stop();
                lblTimer.Visible = false;
                lblQuestion.Visible = true;
                lblResend.Visible = true;
            }
        }

        private void lblResend_Click(object sender, EventArgs e)
        {
            sendCode();
            timerStarter();
            lblTimer.Visible = true;
            lblQuestion.Visible = false;
            lblResend.Visible = false;
        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;

            lblUsername.Visible = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUsername.Visible = false;
            }
        }

        private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;

            lblPass.Visible = true;
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                lblPass.Visible = false;
            }
        }

        private void txtCPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;

            lblCPass.Visible = true;
            if (string.IsNullOrEmpty(txtCPass.Text))
            {
                lblCPass.Visible = false;
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void showCPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showCPass.Checked == true)
            {
                txtCPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtCPass.UseSystemPasswordChar = true;
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            lblCodeError.Visible = false;

            if (txtCode.TextLength == 6)
            {
                btnVerify.Enabled = true;
            }
            else
            {
                btnVerify.Enabled = false;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            lblError.Location = new Point(86, 254);

            if (string.IsNullOrEmpty(txtUsername.Text) | string.IsNullOrEmpty(txtPass.Text) | string.IsNullOrEmpty(txtCPass.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Please fill out the form!";
            }
            else if (txtUsername.Text.Contains(" "))
            {
                lblError.Visible = true;
                lblError.Text = "Username should not contain spaces!";
            }
            else if (txtPass.TextLength < 8)
            {
                lblError.Visible = true;
                lblError.Text = "Password should be at least 8 characters long!";
            }
            else if (txtPass.Text.Equals(txtCPass.Text))
            {
                if (!usernameCheck(txtUsername.Text))
                {
                    if (ValidatePassword(txtPass.Text))
                    {
                        insertData();
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Location = new Point(15, 254);
                        lblError.Text = "Password must contain at least 1 Uppercase, 1 Number, and 1 Special!";
                    }
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Password does not match!";
            }
        }

        private void tmrRedirect_Tick(object sender, EventArgs e)
        {
            var ts = tDateTime.Subtract(DateTime.Now);
            if (ts.TotalMilliseconds > 1d)
            {
                lblRedirect.Text = "You will be redirected to Login in " + ts.ToString("ss") + " seconds.";
            }
            else
            {
                tmrRedirect.Stop();
                var obj = new Login();
                obj.signupPanel.Visible = false;
                obj.loginPanel.Visible = true;
                obj.Show();
                Hide();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Show();
            Hide();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            pnlCreate.Visible = false;
            pnlVerify.Visible = true;
            txtCode.Text = "";

            pic2.Image = My.Resources.Resources.circle2;
            arrow1.Image = My.Resources.Resources.arrowgray;
            lblCreate.ForeColor = SystemColors.ActiveBorder;
            timerStarter();
        }
    }
}