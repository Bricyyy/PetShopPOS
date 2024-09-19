using System;
using System.Data;
using System.Drawing;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class AlreadyExist
    {

        public string passEmail { get; set; }
        public string passUsername { get; set; }

        public AlreadyExist()
        {
            InitializeComponent();
        }

        private void showPicture()
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

        private void AlreadyExist_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            lblEmail.Text = passEmail;
            lblUname.Text = passUsername;

            showPicture();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.signupPanel.Visible = true;
            obj.loginPanel.Visible = false;
            obj.Show();
            Hide();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Show();
            Hide();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            var obj = new forgotPassForm();
            obj.emailReset.Text = passEmail;
            obj.emailReset.Enabled = false;
            obj.Show();
            Hide();
        }
    }
}