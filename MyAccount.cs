using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class MyAccount
    {
        private string b1;
        private string a;
        private string b;
        private string c;
        private string setUname;
        private int index1;
        private int index3;
        private int flag;

        public string passEmail { get; set; }
        public string passUsername { get; set; }

        private readonly OpenFileDialog opf = new OpenFileDialog() { Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif" };

        public MyAccount()
        {
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            if (My.MySettingsProperty.Settings.userRememberMe == true)
            {
                passEmail = My.MySettingsProperty.Settings.userEmail;
                passUsername = My.MySettingsProperty.Settings.userUsername;
            }

            getProfilePic();
            setCredentials();
            userNameChangeChecker();

            char outputEmail;
            outputEmail = Conversions.ToChar(passEmail.Substring(0, 1));
            char outputEmail1;
            outputEmail1 = Conversions.ToChar(passEmail.Substring(1, 1));
            int count;
            count = passEmail.Length;

            string[] split = passEmail.Split('@');
            if (split.Count() == 2)
            {
                b1 = split[1].ToString();
            }

            if (count > 18)
            {
                lblEmail.Text = Conversions.ToString(outputEmail) + outputEmail1 + "***********@" + b1;
            }
            else
            {
                lblEmail.Text = Conversions.ToString(outputEmail) + outputEmail1 + "******@" + b1;
            }

            txtPhoneNum.MaxLength = 11;
        }

        private void userNameChangeChecker()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            try
            {
                UniversalVariables.sql = "Select * FROM userProfile WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    string count;
                    count = UniversalVariables.dr.GetInt32(2).ToString();
                    if (count == "0")
                    {
                        txtUsername.Enabled = true;
                    }
                    else
                    {
                        txtUsername.Enabled = false;
                        lblUNInfo.Text = "You already changed your username once.";
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private void setCredentials()
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
                    setUname = UniversalVariables.dr.GetString("uName");
                    txtUsername.Text = setUname;
                    txtFullName.Text = UniversalVariables.dr.GetString("userName");
                    txtPhoneNum.Text = UniversalVariables.dr.GetString("userPhone");
                    if (!UniversalVariables.dr.IsDBNull(8))
                    {
                        if (UniversalVariables.dr.GetString("userGend").Equals("Male"))
                        {
                            btnMale.Checked = true;
                        }
                        else if (UniversalVariables.dr.GetString("userGend").Equals("Female"))
                        {
                            btnFemale.Checked = true;
                        }
                        else if (UniversalVariables.dr.GetString("userGend").Equals("Other"))
                        {
                            btnOther.Checked = true;
                        }
                        else
                        {
                            btnMale.Checked = false;
                            btnFemale.Checked = false;
                            btnOther.Checked = false;
                        }
                    }
                    else
                    {
                        btnMale.Checked = false;
                        btnFemale.Checked = false;
                        btnOther.Checked = false;
                    }
                    if (!UniversalVariables.dr.IsDBNull(9))
                    {
                        lblDate.Text = Conversions.ToString(UniversalVariables.dr.GetDateTime("userBday"));
                        string[] split = lblDate.Text.Split('/');
                        if (split.Count() == 3)
                        {
                            a = split[0];
                            b = split[1];
                            c = split[2];
                        }
                        index1 = cmbYear.FindString(c);
                        cmbYear.SelectedIndex = index1;
                        cmbMonth.SelectedIndex = (int)Math.Round(Conversions.ToDouble(a) - 1d);
                        index3 = cmbDate.FindString(b);
                        cmbDate.SelectedIndex = index3;
                    }
                }
            }
            catch (Exception ex)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.Close();

            btnSave.Visible = false;
            btnDiscard.Visible = false;
        }

        private void saveCredentials()
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
                    string uname = UniversalVariables.dr.GetString("uName");

                    if (UniversalVariables.dr.GetInt32(2) == Conversions.ToDouble("0"))
                    {
                        if (unameChecker(txtUsername.Text))
                        {
                            lblUsernameChecker.Visible = true;
                            btnSave.Enabled = true;
                            btnDiscard.Enabled = true;
                        }
                        else if (!txtUsername.Text.Equals(uname))
                        {
                            if (UniversalVariables.conn.State == ConnectionState.Open)
                            {
                                UniversalVariables.conn.Close();
                            }

                            UniversalVariables.sql = "UPDATE userProfile SET uName = '" + txtUsername.Text + "', uNCount = '" + "1" + "' WHERE uEmail = '" + passEmail + "'";
                            UniversalVariables.connect();

                            UniversalVariables.dr.Close();

                            if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                            {
                                if (lblUsernameChecker.Visible == false)
                                {
                                    My.MyProject.Forms.SavedConfirmation.ShowDialog();
                                }
                            }
                        }
                    }

                    if (UniversalVariables.conn.State == ConnectionState.Open)
                    {
                        UniversalVariables.conn.Close();
                    }

                    string gender;
                    if (btnMale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else if (btnFemale.Checked == true)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "Other";
                    }

                    string bday;
                    string a = cmbYear.Text;
                    int b = cmbMonth.SelectedIndex + 1;
                    string c = cmbDate.Text;
                    bday = a + "-" + b + "-" + c;

                    UniversalVariables.sql = "UPDATE userProfile SET userName = '" + txtFullName.Text + "', userPhone = '" + txtPhoneNum.Text + "', userGend = '" + gender + "', userBday = '" + bday + "' WHERE uEmail = '" + passEmail + "'";
                    UniversalVariables.connect();

                    UniversalVariables.dr.Close();

                    if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                    {
                        if (!(flag == 1))
                        {
                            if (lblUsernameChecker.Visible == false)
                            {
                                My.MyProject.Forms.SavedConfirmation.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
        }

        private bool unameChecker(object userName)
        {
            bool usernameExist = false;

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            try
            {
                UniversalVariables.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM userProfile WHERE uName = '", userName), "'"));
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    string email = UniversalVariables.dr.GetString("uEmail");
                    if (!email.Equals(passEmail))
                    {
                        usernameExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
            return usernameExist;
        }

        private void getProfilePic()
        {
            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }

            byte[] arrimage;

            try
            {
                UniversalVariables.sql = "SELECT userPic FROM userProfile WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    arrimage = (byte[])UniversalVariables.dr["userPic"];
                    var mstream = new System.IO.MemoryStream(arrimage);
                    setPicture.CustomImages.Image = Image.FromStream(mstream);

                    var originalImage = setPicture.CustomImages.Image;
                    var croppedImage = new Bitmap(originalImage.Width, originalImage.Height);

                    using (var g = Graphics.FromImage(croppedImage))
                    {
                        var path = new GraphicsPath();

                        path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height);

                        var reg = new Region(path);

                        g.Clip = reg;
                        g.DrawImage(originalImage, Point.Empty);
                    }

                    setPicture.CustomImages.Image = croppedImage;
                }
                else if (UniversalVariables.dr.IsDBNull(5))
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

        private void setProfilePic()
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                flag = 1;
                var originalImage = Image.FromFile(opf.FileName);
                var croppedImage = new Bitmap(originalImage.Width, originalImage.Height);

                using (var g = Graphics.FromImage(croppedImage))
                {
                    var path = new GraphicsPath();

                    path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height);

                    var reg = new Region(path);

                    g.Clip = reg;
                    g.DrawImage(originalImage, Point.Empty);
                }

                setPicture.CustomImages.Image = croppedImage;

                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
        }

        private void saveProfilePic()
        {
            if (flag == 1)
            {
                var originalImage = Image.FromFile(opf.FileName);

                uint filesize;

                var mstream = new System.IO.MemoryStream();
                originalImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrimage = mstream.GetBuffer();
                filesize = (uint)mstream.Length;
                mstream.Close();

                if (UniversalVariables.conn.State == ConnectionState.Open)
                {
                    UniversalVariables.conn.Close();
                }

                try
                {
                    UniversalVariables.sql = "UPDATE userProfile SET userPic = @pic WHERE uEmail = @email";
                    {
                        ref var withBlock = ref UniversalVariables.cmd;
                        withBlock.Parameters.Clear();
                        withBlock.Parameters.Add("@pic", MySqlDbType.Blob).Value = arrimage;
                        withBlock.Parameters.Add("@email", MySqlDbType.VarChar).Value = passEmail;
                    }
                    UniversalVariables.connect();
                }
                // SavedConfirmation.ShowDialog()
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
                UniversalVariables.conn.Close();

                flag = 0;
            }
        }

        private void setPicture_Click(object sender, EventArgs e)
        {
            setProfilePic();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var obj = new Settings();
            obj.getProfilePic();

            saveProfilePic();
            if (txtUsername.Text.Contains(" "))
            {
                lblUsernameChecker.Visible = true;
                lblUsernameChecker.Text = "Username should not contain spaces";
            }
            else
            {
                saveCredentials();
            }
            userNameChangeChecker();

            if (lblUsernameChecker.Visible == true)
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
            else
            {
                btnSave.Visible = false;
                btnDiscard.Visible = false;
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            getProfilePic();

            btnDiscard.Visible = false;
            btnSave.Visible = false;

            setCredentials();
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            setProfilePic();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnDiscard.Visible = true;

            lblUsernameChecker.Visible = false;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnDiscard.Visible = true;
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnDiscard.Visible = true;
        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (!(btnFemale.Checked == true))
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
            else if (btnMale.Checked == false & btnOther.Checked == false)
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
        }

        private void btnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!(btnMale.Checked == true))
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
            else if (btnFemale.Checked == false & btnOther.Checked == false)
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
        }

        private void btnOther_CheckedChanged(object sender, EventArgs e)
        {
            if (!(btnOther.Checked == true))
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
            else if (btnMale.Checked == false & btnFemale.Checked == false)
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbDate.SelectedIndex == index3))
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbMonth.SelectedIndex == Conversions.ToDouble(a) - 1d))
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbYear.SelectedIndex == index1))
            {
                btnSave.Visible = true;
                btnDiscard.Visible = true;
            }
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = Conversions.ToChar("");
        }
    }
}