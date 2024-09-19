using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class Settings
    {
        public static string toEmail;
        public static string ToUserName;

        public string passEmail { get; set; }
        public string passUsername { get; set; }

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            toEmail = passEmail;
            ToUserName = passUsername;

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            lblUsername.Text = passUsername;
            getProfilePic();

            btnAccount.Image = My.Resources.Resources.iconPersonColored;
            btnAccount.ForeColor = Color.FromArgb(255, 152, 19);
            btnAccount.FillColor = Color.FromArgb(255, 240, 220);

            var obj1 = new MyAccount()
            {
                passEmail = toEmail,
                passUsername = ToUserName,
                TopLevel = false
            };
            pnlSettingsMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();
        }

        public void getProfilePic()
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlSettingsMain.Controls.Clear();
            var obj1 = new MyAccount()
            {
                passEmail = toEmail,
                passUsername = ToUserName,
                TopLevel = false
            };
            pnlSettingsMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();

            btnAccount.Image = My.Resources.Resources.iconPersonColored;
            btnAccount.ForeColor = Color.FromArgb(255, 152, 19);
            btnAccount.FillColor = Color.FromArgb(255, 240, 220);

            btnAddress.Image = My.Resources.Resources.addressIconBlack;
            btnAddress.ForeColor = Color.Black;
            btnAddress.FillColor = Color.White;
            btnSecurity.Image = My.Resources.Resources.securityIconBlack;
            btnSecurity.ForeColor = Color.Black;
            btnSecurity.FillColor = Color.White;
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            pnlSettingsMain.Controls.Clear();
            var obj1 = new MyAddress()
            {
                passEmail = toEmail,
                passUsername = ToUserName,
                TopLevel = false
            };
            pnlSettingsMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();

            btnAddress.Image = My.Resources.Resources.addressIconColored;
            btnAddress.ForeColor = Color.FromArgb(255, 152, 19);
            btnAddress.FillColor = Color.FromArgb(255, 240, 220);

            btnAccount.Image = My.Resources.Resources.personIconBlack;
            btnAccount.ForeColor = Color.Black;
            btnAccount.FillColor = Color.White;
            btnSecurity.Image = My.Resources.Resources.securityIconBlack;
            btnSecurity.ForeColor = Color.Black;
            btnSecurity.FillColor = Color.White;
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            pnlSettingsMain.Controls.Clear();
            var obj1 = new ChangePassword()
            {
                passEmail = toEmail,
                passUsername = ToUserName,
                TopLevel = false
            };
            pnlSettingsMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();

            btnSecurity.Image = My.Resources.Resources.securityIconColored;
            btnSecurity.ForeColor = Color.FromArgb(255, 152, 19);
            btnSecurity.FillColor = Color.FromArgb(255, 240, 220);

            btnAccount.Image = My.Resources.Resources.personIconBlack;
            btnAccount.ForeColor = Color.Black;
            btnAccount.FillColor = Color.White;
            btnAddress.Image = My.Resources.Resources.addressIconBlack;
            btnAddress.ForeColor = Color.Black;
            btnAddress.FillColor = Color.White;
        }
    }
}