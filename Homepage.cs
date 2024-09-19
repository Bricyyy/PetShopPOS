using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MilkTeaOrderAndInventorySystem
{

    public partial class Homepage
    {
        private bool _useHomeEventLeave = true;
        private bool _useHistoryEventLeave = true;
        private bool _useMessageEventLeave = true;
        private bool _useSettingsEventLeave = true;
        private bool _useManageEventLeavee = true;

        public static string toEmail;
        public static string ToUserName;

        public string emailPic { get; set; }
        public string userPic { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        public Homepage()
        {
            InitializeComponent();
            btnManage = _btnManage;
            btnSettings = _btnSettings;
            pnlMain = _pnlMain;
            _btnManage.Name = "btnManage";
            _btnSettings.Name = "btnSettings";
            _pnlMain.Name = "pnlMain";
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

        private void Homepage_Load(object sender, EventArgs e)
        {
            fadeIn();

            toEmail = emailPic;
            ToUserName = userPic;

            My.MyProject.Forms.Login.Hide();

            btnHome.BorderThickness = 2;
            btnHome.ForeColor = Color.FromArgb(255, 152, 19);
            btnHome.Image = My.Resources.Resources.homeIconColored;
            _useHomeEventLeave = false;

            var obj = new Login();
            if (obj.chkRememberMe.Checked)
            {
                My.MySettingsProperty.Settings.userRememberMe = true;
            }

            if (My.MySettingsProperty.Settings.userRememberMe == true)
            {
                lblUserInfo.Text = string.Concat("email: ", My.MySettingsProperty.Settings.userEmail, " password: ", My.MySettingsProperty.Settings.userPassword, " username: ", My.MySettingsProperty.Settings.userUsername, " remember me: ", My.MySettingsProperty.Settings.userRememberMe);
                toEmail = My.MySettingsProperty.Settings.userEmail;
                ToUserName = My.MySettingsProperty.Settings.userUsername;
            }

            var obj1 = new HomePanel()
            {
                passEmail = toEmail,
                passUsername = ToUserName,
                TopLevel = false
            };
            pnlMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();
        }

        public void switchPanel(Form panel)
        {
            pnlMain.Controls.Clear();
            panel.TopLevel = false;
            pnlMain.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.userRememberMe = false;
            My.MySettingsProperty.Settings.userEmail = "";
            My.MySettingsProperty.Settings.userPassword = "";
            My.MySettingsProperty.Settings.userUsername = "";
            My.MySettingsProperty.Settings.Save();
            var obj = new Login();
            obj.Show();
            Hide();
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BorderThickness = 2;
            btnLogout.ForeColor = Color.FromArgb(255, 152, 19);
            btnLogout.Image = My.Resources.Resources.logoutIconColored;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BorderThickness = 0;
            btnLogout.ForeColor = Color.Black;
            btnLogout.Image = My.Resources.Resources.logoutIconBlack;
        }

        // Private Sub btnHome_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter
        // btnHome.BorderThickness = 2
        // btnHome.ForeColor = Color.FromArgb(255, 152, 19)
        // btnHome.Image = My.Resources.homeIconColored
        // End Sub

        // Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        // If _useHomeEventLeave Then
        // btnHome.BorderThickness = 0
        // btnHome.ForeColor = Color.Black
        // btnHome.Image = My.Resources.homeIconBlack
        // End If
        // End Sub

        // Private Sub btnHistory_MouseEnter(sender As Object, e As EventArgs) Handles btnHistory.MouseEnter
        // btnHistory.BorderThickness = 2
        // btnHistory.ForeColor = Color.FromArgb(255, 152, 19)
        // btnHistory.Image = My.Resources.historyIconColored
        // End Sub

        // Private Sub btnHistory_MouseLeave(sender As Object, e As EventArgs) Handles btnHistory.MouseLeave
        // If _useHistoryEventLeave Then
        // btnHistory.BorderThickness = 0
        // btnHistory.ForeColor = Color.Black
        // btnHistory.Image = My.Resources.historyIconBlack
        // End If
        // End Sub

        // Private Sub btnMessage_MouseEnter(sender As Object, e As EventArgs) Handles btnMessage.MouseEnter
        // btnMessage.BorderThickness = 2
        // btnMessage.ForeColor = Color.FromArgb(255, 152, 19)
        // btnMessage.Image = My.Resources.messageIconColored
        // End Sub

        // Private Sub btnMessage_MouseLeave(sender As Object, e As EventArgs) Handles btnMessage.MouseLeave
        // If _useMessageEventLeave Then
        // btnMessage.BorderThickness = 0
        // btnMessage.ForeColor = Color.Black
        // btnMessage.Image = My.Resources.messageIconBlack
        // End If
        // End Sub

        // Private Sub btnSettings_MouseEnter(sender As Object, e As EventArgs) Handles btnSettings.MouseEnter
        // btnSettings.BorderThickness = 2
        // btnSettings.ForeColor = Color.FromArgb(255, 152, 19)
        // btnSettings.Image = My.Resources.settingsIconColored
        // End Sub

        // Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        // If _useSettingsEventLeave Then
        // btnSettings.BorderThickness = 0
        // btnSettings.ForeColor = Color.Black
        // btnSettings.Image = My.Resources.settingsIconBlack
        // End If
        // End Sub

        private void btnHome_Click(object sender, EventArgs e)
        {
            _useHomeEventLeave = false;

            _useHistoryEventLeave = true;
            _useMessageEventLeave = true;
            _useSettingsEventLeave = true;
            _useManageEventLeavee = true;

            btnHistory.BorderThickness = 0;
            btnHistory.ForeColor = Color.Black;
            btnHistory.Image = My.Resources.Resources.historyIconBlack;
            btnMessage.BorderThickness = 0;
            btnMessage.ForeColor = Color.Black;
            btnMessage.Image = My.Resources.Resources.messageIconBlack;
            btnSettings.BorderThickness = 0;
            btnSettings.ForeColor = Color.Black;
            btnSettings.Image = My.Resources.Resources.settingsIconBlack;
            btnManage.BorderThickness = 0;
            btnManage.ForeColor = Color.Black;
            btnManage.Image = My.Resources.Resources.ManageItemIconBlack;

            btnHome.BorderThickness = 2;
            btnHome.ForeColor = Color.FromArgb(255, 152, 19);
            btnHome.Image = My.Resources.Resources.homeIconColored;

            pnlMain.Controls.Clear();
            var obj1 = new HomePanel()
            {
                passEmail = toEmail,
                passUsername = userPic,
                TopLevel = false
            };
            pnlMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            _useHistoryEventLeave = false;

            _useHomeEventLeave = true;
            _useMessageEventLeave = true;
            _useSettingsEventLeave = true;
            _useManageEventLeavee = true;

            btnHome.BorderThickness = 0;
            btnHome.ForeColor = Color.Black;
            btnHome.Image = My.Resources.Resources.homeIconBlack;
            btnMessage.BorderThickness = 0;
            btnMessage.ForeColor = Color.Black;
            btnMessage.Image = My.Resources.Resources.messageIconBlack;
            btnSettings.BorderThickness = 0;
            btnSettings.ForeColor = Color.Black;
            btnSettings.Image = My.Resources.Resources.settingsIconBlack;
            btnManage.BorderThickness = 0;
            btnManage.ForeColor = Color.Black;
            btnManage.Image = My.Resources.Resources.ManageItemIconBlack;

            btnHistory.BorderThickness = 2;
            btnHistory.ForeColor = Color.FromArgb(255, 152, 19);
            btnHistory.Image = My.Resources.Resources.historyIconColored;

            pnlMain.Controls.Clear();
            var obj1 = new History()
            {
                passEmail = toEmail,
                TopLevel = false
            };
            pnlMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            _useMessageEventLeave = false;

            _useHomeEventLeave = true;
            _useHistoryEventLeave = true;
            _useSettingsEventLeave = true;
            _useManageEventLeavee = true;

            btnHome.BorderThickness = 0;
            btnHome.ForeColor = Color.Black;
            btnHome.Image = My.Resources.Resources.homeIconBlack;
            btnHistory.BorderThickness = 0;
            btnHistory.ForeColor = Color.Black;
            btnHistory.Image = My.Resources.Resources.historyIconBlack;
            btnSettings.BorderThickness = 0;
            btnSettings.ForeColor = Color.Black;
            btnSettings.Image = My.Resources.Resources.settingsIconBlack;
            btnManage.BorderThickness = 0;
            btnManage.ForeColor = Color.Black;
            btnManage.Image = My.Resources.Resources.ManageItemIconBlack;

            btnMessage.BorderThickness = 2;
            btnMessage.ForeColor = Color.FromArgb(255, 152, 19);
            btnMessage.Image = My.Resources.Resources.messageIconColored;
        }

        public void btnSettings_Click(object sender, EventArgs e)
        {
            _useSettingsEventLeave = false;

            _useHomeEventLeave = true;
            _useHistoryEventLeave = true;
            _useMessageEventLeave = true;
            _useManageEventLeavee = true;

            btnHome.BorderThickness = 0;
            btnHome.ForeColor = Color.Black;
            btnHome.Image = My.Resources.Resources.homeIconBlack;
            btnHistory.BorderThickness = 0;
            btnHistory.ForeColor = Color.Black;
            btnHistory.Image = My.Resources.Resources.historyIconBlack;
            btnMessage.BorderThickness = 0;
            btnMessage.ForeColor = Color.Black;
            btnMessage.Image = My.Resources.Resources.messageIconBlack;
            btnManage.BorderThickness = 0;
            btnManage.ForeColor = Color.Black;
            btnManage.Image = My.Resources.Resources.ManageItemIconBlack;

            btnSettings.BorderThickness = 2;
            btnSettings.ForeColor = Color.FromArgb(255, 152, 19);
            btnSettings.Image = My.Resources.Resources.settingsIconColored;

            pnlMain.Controls.Clear();
            var obj1 = new Settings()
            {
                passEmail = toEmail,
                passUsername = userPic,
                TopLevel = false
            };
            pnlMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            _useManageEventLeavee = false;

            _useHomeEventLeave = true;
            _useHistoryEventLeave = true;
            _useMessageEventLeave = true;
            _useSettingsEventLeave = true;

            btnHome.BorderThickness = 0;
            btnHome.ForeColor = Color.Black;
            btnHome.Image = My.Resources.Resources.homeIconBlack;
            btnHistory.BorderThickness = 0;
            btnHistory.ForeColor = Color.Black;
            btnHistory.Image = My.Resources.Resources.historyIconBlack;
            btnMessage.BorderThickness = 0;
            btnMessage.ForeColor = Color.Black;
            btnMessage.Image = My.Resources.Resources.messageIconBlack;
            btnSettings.BorderThickness = 0;
            btnSettings.ForeColor = Color.Black;
            btnSettings.Image = My.Resources.Resources.settingsIconBlack;

            btnManage.BorderThickness = 2;
            btnManage.ForeColor = Color.FromArgb(255, 152, 19);
            btnManage.Image = My.Resources.Resources.ManageItemIconColored;

            pnlMain.Controls.Clear();
            var obj1 = new ProductsManagement() { TopLevel = false };
            pnlMain.Controls.Add(obj1);
            obj1.Dock = DockStyle.Fill;
            obj1.Show();
        }

        private void Homepage_Closing(object sender, CancelEventArgs e)
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