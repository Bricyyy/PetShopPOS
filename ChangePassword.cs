using System;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MilkTeaOrderAndInventorySystem
{
    public partial class ChangePassword
    {
        public string passEmail { get; set; }
        public string passUsername { get; set; }

        private readonly byte[] key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private readonly byte[] iv = new byte[] { 10, 9, 8, 7, 6, 5, 4, 3 };
        private PassEnCDeC des;

        public ChangePassword()
        {
            des = new PassEnCDeC(key, iv);
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.userRememberMe == true)
            {
                passEmail = My.MySettingsProperty.Settings.userEmail;
                passUsername = My.MySettingsProperty.Settings.userPassword;
            }

            if (UniversalVariables.conn.State == ConnectionState.Open)
            {
                UniversalVariables.conn.Close();
            }
            UniversalVariables.conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb";

            try
            {
                UniversalVariables.sql = "SELECT * FROM userProfile WHERE uEmail = '" + passEmail + "'";
                UniversalVariables.connect();

                if (UniversalVariables.dr.Read())
                {
                    lblUsername.Text = Conversions.ToString(UniversalVariables.dr.GetValue(1));
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();

            getProfilePic();
        }

        private void getProfilePic()
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

        // Private Sub fieldsChecker()
        // If Not txtOldPass.Text.Equals("") And Not txtNewPass.Text.Equals("") And Not txtConfirmNewPass.Text.Equals("") Then
        // btnChange.Enabled = True
        // Else
        // btnChange.Enabled = False
        // End If
        // End Sub

        // Private Sub changePass()
        // If conn.State = ConnectionState.Open Then
        // conn.Close()
        // End If

        // Try
        // sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
        // connect()

        // If dr.Read Then
        // Dim pass As String = des.Decrypt(dr.GetString("uPass").ToString)
        // If txtOldPass.Text.Equals(pass) Then
        // If txtNewPass.Text.Equals(txtConfirmNewPass.Text) Then
        // If Not txtNewPass.Text.Length < 8 Or txtConfirmNewPass.Text.Length < 8 Then
        // lblPassChecker.Location = New Point(207, 422)

        // If ValidatePassword(txtNewPass.Text) Then
        // If conn.State = ConnectionState.Open Then
        // conn.Close()
        // End If

        // sql = "UPDATE userProfile SET uPass = '" & des.Encrypt(txtNewPass.Text) & "' WHERE uEmail = '" & passEmail & "'"
        // connect()

        // dr.Close()

        // If cmd.ExecuteNonQuery Then
        // SavedConfirmation.Show()
        // End If
        // Else
        // lblPassChecker.Visible = True
        // lblPassChecker.Text = "Password must contain at least 1 Uppercase, 1 Number, and 1 Special!"
        // End If
        // Else
        // lblPassChecker.Visible = True
        // lblPassChecker.Text = "Password must be at least 8 characters."
        // End If
        // Else
        // lblPassChecker.Visible = True
        // lblPassChecker.Text = "Password does not match."
        // End If
        // Else
        // lblPassChecker.Visible = True
        // lblPassChecker.Text = "Current password is incorrect"
        // End If
        // End If
        // Catch ex As Exception
        // MsgBox(ex.Message)
        // End Try
        // conn.Close()
        // End Sub

        private bool fieldsChecker()
        {
            lblPassChecker.Location = new Point(207, 422);

            if (string.IsNullOrEmpty(txtNewPass.Text) | string.IsNullOrEmpty(txtConfirmNewPass.Text) | string.IsNullOrEmpty(txtOldPass.Text))
            {
                lblPassChecker.Visible = true;
                lblPassChecker.Text = "Password is invalid!";
                return false;
            }
            else if (txtNewPass.TextLength < 8 | txtConfirmNewPass.TextLength < 8)
            {
                lblPassChecker.Visible = true;
                lblPassChecker.Text = "Password should be more than 8 characters!";
                return false;
            }
            else if ((txtNewPass.Text ?? "") != (txtConfirmNewPass.Text ?? ""))
            {
                lblPassChecker.Visible = true;
                lblPassChecker.Text = "Password does not match!";
                return false;
            }
            else if (!ValidatePassword(txtNewPass.Text))
            {
                lblPassChecker.Visible = true;
                lblPassChecker.Location = new Point(119, 422);
                lblPassChecker.Text = "Password must contain at least 1 Uppercase, 1 Number, and 1 Special!";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void changePass()
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
                    string pass = des.Decrypt(UniversalVariables.dr.GetString("uPass").ToString());

                    if (txtOldPass.Text.Equals(pass))
                    {
                        if (UniversalVariables.conn.State == ConnectionState.Open)
                        {
                            UniversalVariables.conn.Close();
                        }

                        UniversalVariables.sql = "UPDATE userProfile SET uPass = '" + des.Encrypt(txtNewPass.Text) + "' WHERE uEmail = '" + passEmail + "'";
                        UniversalVariables.connect();

                        UniversalVariables.dr.Close();

                        if (Conversions.ToBoolean(UniversalVariables.cmd.ExecuteNonQuery()))
                        {
                            My.MyProject.Forms.SavedConfirmation.Show();
                        }
                    }
                    else
                    {
                        lblPassChecker.Visible = true;
                        lblPassChecker.Text = "Current password is incorrect";
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            UniversalVariables.conn.Close();
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (fieldsChecker())
            {
                changePass();
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            lblPassChecker.Visible = false;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            lblPassChecker.Visible = false;
        }

        private void txtConfirmNewPass_TextChanged(object sender, EventArgs e)
        {
            lblPassChecker.Visible = false;
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmNewPass.Text = "";
            lblPassChecker.Visible = false;

            var obj = new forgotPassForm() { Size = new Size(370, 400) };
            obj.emailReset.Text = passEmail;
            obj.emailReset.Enabled = false;
            obj.passedValue = true;
            obj.Show();
        }
    }
}