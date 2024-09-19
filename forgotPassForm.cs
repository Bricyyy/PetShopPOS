using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class forgotPassForm
    {
        private string randomCode;
        public bool passedValue { get; set; } = false;

        public static string toUser;

        public forgotPassForm()
        {
            InitializeComponent();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Show();
            Hide();
        }

        private void createNewAcc_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.signupPanel.Visible = true;
            obj.loginPanel.Visible = false;
            obj.Show();
            Hide();
        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            txtError.Visible = false;

            txtError.Visible = false;
            if (string.IsNullOrEmpty(emailReset.Text))
            {
                btnSend.Enabled = false;
            }
            else
            {
                btnSend.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendCode();
        }

        private void sendCode()
        {
            if (IsValidEmailFormat(emailReset.Text))
            {
                emailCheck();
            }
            else
            {
                txtError.Visible = true;
                txtError.Text = "Please enter a valid email address!";
            }
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            verifyCode();
        }

        private void verifyCode()
        {
            if (passedValue == true)
            {
                if (txtCode.Text.Equals(randomCode))
                {
                    var obj = new ResetPass()
                    {
                        passEmail = emailReset.Text,
                        passValue = passedValue
                    };
                    obj.btnLogin.Text = "Done";
                    obj.Show();
                    Hide();
                }
                else
                {
                    txtCodeCheck.Visible = true;
                    txtCodeCheck.Text = "Invalid Code!";
                }
            }
            else if (txtCode.Text.Equals(randomCode))
            {
                var obj = new ResetPass() { passEmail = emailReset.Text };
                obj.Show();
                Hide();
            }
            else
            {
                txtCodeCheck.Visible = true;
                txtCodeCheck.Text = "Invalid Code!";
            }
        }

        public bool IsValidEmailFormat(string s)
        {
            try
            {
                var a = new MailAddress(s);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void emailCheck()
        {
            UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + emailReset.Text + "'";
            UniversalVariables.connect();

            if (UniversalVariables.dr.Read())
            {
                string from, pass, messageBody;
                var rand = new Random();
                randomCode = rand.Next(999999).ToString();
                var message = new MailMessage();
                toUser = emailReset.Text;
                from = "trialkoito4@gmail.com";
                pass = "broxxedasqosbrvy";
                messageBody = "Your Verification Code is: " + randomCode;
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

                    sendPanel.Hide();
                    verifyPanel.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                txtError.Visible = true;
                txtError.Text = "Email is not found!";
            }
            UniversalVariables.conn.Close();
        }

        private void forgotPassForm_Load(object sender, EventArgs e)
        {
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";
            txtCode.MaxLength = 6;
        }

        private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            txtCodeCheck.Visible = false;

            if (string.IsNullOrEmpty(txtCode.Text))
            {
                btnVerify.Enabled = false;
            }
            else
            {
                btnVerify.Enabled = true;
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = Conversions.ToChar("");
        }

        private void emailReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendCode();
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verifyCode();
            }
        }
    }
}