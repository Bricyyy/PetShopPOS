using System;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class Login
    {
        public static string randomCode;
        public static string toUser;
        public static string sendUserName;

        private readonly byte[] key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private readonly byte[] iv = new byte[] { 10, 9, 8, 7, 6, 5, 4, 3 };
        private PassEnCDeC des;

        public Login()
        {
            des = new PassEnCDeC(key, iv);
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            fadeIn();

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            // If My.Settings.userRememberMe = True Then
            // rememberMeLogin()

            // 'Dim obj As New Homepage
            // 'obj.Show()
            // 'Me.Hide()
            // End If
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private void Guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void fadeIn()
        {
            Opacity = 0d;
            var tmr = new Timer() { Interval = 2 };
            tmr.Start();
            tmr.Tick += () =>
                {
                    Opacity += 0.1d;
                    if (Opacity == 1d)
                        tmr.Stop();
                };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sendLogin();
        }

        public bool IsEncrypted(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;
            return text.StartsWith("!=!enc!=!", StringComparison.InvariantCulture);
        }

        public bool IsValidEmailFormat(string s)
        {
            return Regex.IsMatch(s, @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
        }

        private bool emailChecker(string email)
        {
            bool emailExist = false;

            UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + email + "'";
            UniversalVariables.connect();

            if (UniversalVariables.dr.Read())
            {
                emailExist = true;
            }
            UniversalVariables.conn.Close();
            return emailExist;
        }

        private void sendCode()
        {
            if (IsValidEmailFormat(signupEmail.Text))
            {
                emailCheck();
            }
            else
            {
                lblEmailChecker.Visible = true;
                lblEmailChecker.Text = "Invalid email address!";
            }
        }

        private void emailCheck()
        {
            UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + signupEmail.Text + "'";
            UniversalVariables.connect();

            if (UniversalVariables.dr.Read())
            {
                var obj = new AlreadyExist()
                {
                    passEmail = signupEmail.Text,
                    passUsername = Conversions.ToString(UniversalVariables.dr.GetValue(1))
                };
                obj.Show();
                Hide();
            }
            else
            {
                string from, pass, messageBody;
                var rand = new Random();
                randomCode = rand.Next(999999).ToString();
                var message = new MailMessage();
                toUser = signupEmail.Text;
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

                    var obj = new Signup()
                    {
                        sentCode = randomCode,
                        passEmail = toUser
                    };
                    obj.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            UniversalVariables.conn.Close();
        }

        private void rememberMeLogin()
        {
            string email = My.MySettingsProperty.Settings.userEmail;
            string pass = My.MySettingsProperty.Settings.userPassword;

            try
            {
                UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + email + "' AND uPass = '" + des.Decrypt(pass) + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    var obj = new Homepage();
                    obj.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void sendLogin()
        {
            try
            {
                UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + txtEmail.Text + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    string email = UniversalVariables.dr.GetString("uEmail").ToString();
                    string password = des.Decrypt(UniversalVariables.dr.GetString("uPass").ToString());

                    // If IsEncrypted(dr.GetString("uPass").ToString) Then
                    // password = des.Decrypt(dr.GetString("uPass").ToString)
                    // Else
                    // password = dr.GetString("uPass").ToString
                    // End If

                    if (txtEmail.Text.Equals(email) & txtPassword.Text.Equals(password))
                    {
                        if (chkRememberMe.Checked == true)
                        {
                            My.MySettingsProperty.Settings.userEmail = txtEmail.Text.ToString();
                            My.MySettingsProperty.Settings.userPassword = des.Encrypt(txtPassword.Text).ToString();
                            My.MySettingsProperty.Settings.userRememberMe = true;
                            My.MySettingsProperty.Settings.userUsername = UniversalVariables.dr.GetValue(1).ToString();
                            My.MySettingsProperty.Settings.Save();
                        }
                        else
                        {
                            My.MySettingsProperty.Settings.userEmail = "";
                            My.MySettingsProperty.Settings.userPassword = "";
                            My.MySettingsProperty.Settings.userRememberMe = false;
                            My.MySettingsProperty.Settings.userUsername = "";
                            My.MySettingsProperty.Settings.Save();
                        }

                        var obj = new Homepage()
                        {
                            emailPic = txtEmail.Text,
                            userPic = Conversions.ToString(UniversalVariables.dr.GetValue(1))
                        };
                        obj.Show();
                        Hide();
                    }
                    else
                    {
                        txtPassword.Text = "";
                        lblChecker.Visible = true;
                    }
                }
                else
                {
                    txtPassword.Text = "";
                    lblChecker.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var obj = new forgotPassForm();
            obj.Show();
            Hide();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            txtEmail.Text = null;
            txtPassword.Text = null;
            signupPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;

            lblEmail.Visible = true;
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblChecker.Visible = false;

            lblPass.Visible = true;
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPass.Visible = false;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendLogin();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendLogin();
            }
        }

        private void signupEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailChecker.Visible = false;

            lblSmail.Visible = true;
            if (string.IsNullOrEmpty(signupEmail.Text))
            {
                lblSmail.Visible = false;
            }
        }

        private void Label6_Click_1(object sender, EventArgs e)
        {
            signupEmail.Text = null;
            signupPanel.Hide();
            loginPanel.Show();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            sendCode();
        }

        private void Login_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Opacity = 1d;
            var tmr = new Timer() { Interval = 1 };
            tmr.Start();
            tmr.Tick += () =>
                {
                    Opacity -= 0.1d;
                    if (Opacity == 0d)
                    {
                        e.Cancel = false;
                        tmr.Stop();
                        Dispose();
                    }
                };
        }

        private void btnCloseProg_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}